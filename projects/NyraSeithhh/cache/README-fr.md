# Comment nous avons construit ce système de cache de prompt

Test en ligne : une requête opus en un tour demande **49310** tokens, dont **47354** sont directement lus depuis le cache, taux de succès **96%**. Sur près de 100 requêtes, 74 ont été satisfaites par le cache.

Ce document ne parle pas de « ce qu’est le caching de prompt », mais **de la manière dont nous découpons précisément la requête en plusieurs blocs, ce que chaque bloc contient, et pourquoi cette découpe permet un taux de succès aussi stable et élevé**.

---

## Idée clé : découper la requête en deux piles, « ce qui change » et « ce qui ne change pas »

Le cache est un **matching de préfixe**. La comparaison commence au premier octet, dès qu’un octet diffère de la fois précédente, tout ce qui suit est invalidé et recalculé.

Donc la seule chose que nous faisons, c’est découper une requête entière en blocs, les ordonner du « le moins susceptible de changer » au « le plus susceptible de changer », n’attribuer une marque de cache qu’aux blocs fixes devant, et mettre tout ce qui peut changer à la fin.

Le taux de succès élevé ne vient pas d’une technologie secrète, mais parce que **notre préfixe cache est vraiment identique octet par octet**.

---

## Notre disposition des blocs (BP1 → BP4)

Chez Anthropic, une requête peut avoir jusqu’à 4 points de cache. Voici comment nous les répartissons :

```
═══ system blocks（每块单独挂 cache_control）═══

  ┌─────────────────────────────────────────────┐
  │ BP1  人设 + 语言规则 + 工具说明 + 长期记忆    │  几乎永不动
  ├─────────────────────────────────────────────┤
  │ BP2  每日内容（gateway-bp2-daily.txt）       │  一天换一次
  ├─────────────────────────────────────────────┤
  │ BP3  当前会话压缩摘要（这个 session 专属）    │  约 80K token 触发一次压缩
  └─────────────────────────────────────────────┘

═══ messages 数组 ═══

  ...历史轮次（一字不改）...
  ┌─────────────────────────────────────────────┐
  │ BP4  倒数第二条 user 消息挂标（rolling）      │  把全部历史纳进缓存
  └─────────────────────────────────────────────┘
  <gateway_volatile_context> 动态注入            ← 不挂标，所有会变的塞这里
  当前这条 user 消息
```

### Pourquoi chaque bloc est-il placé ainsi

**BP1 — Le fond le plus stable.** Personnage, règles linguistiques, manuel d'outils, mémoire à long terme, ces éléments changent presque jamais, donc placés en premier. Si cela change, tout le reste est inutile, donc il doit être l’élément le plus stable de toute la requête.

**BP2 — La couche qui change chaque jour.** Lu depuis `gateway-bp2-daily.txt`, mis à jour une fois par jour. Son changement n’affecte que BP2 et les suivants, sans toucher à BP1.

**BP3 — Le résumé compressé propre à cette session.** Point clé : il est **uniquement sessionnel**, pas un squelette global à long terme. Quand la fenêtre atteint environ 80K tokens, un résumé est déclenché pour compresser l’ancien contexte. Notez que seul un « résumé stable côté passerelle » est accroché à BP3 ; le résumé dynamique côté front, qui change à chaque tour, **n’est pas accroché**, il est directement mis dans la zone dynamique ci-dessous, sinon le cache serait reconstruit à chaque tour.

**BP4 — Point de rupture roulant, c’est lui qui économise le plus.** La limite de cache par défaut s’arrête à la fin du système, les dialogues historiques ne sont pas en cache. On accroche un marqueur sur le **avant-dernier message utilisateur**, étendant la limite de cache jusqu’à inclure tout l’historique. Dans les longues conversations multi-tours, les tokens des dizaines de tours précédents deviennent entièrement lus depuis le cache, ce qui réalise 96 % des hits.

On accroche sur « avant-dernier » plutôt que « dernier » message, car le dernier message utilisateur est la nouvelle entrée de ce tour, toujours différente, donc accrocher dessus serait inutile. Accrocher sur l’avant-dernier message fait que la limite de cache s’arrête juste avant tout le contenu de ce tour.

### Où vont les éléments changeants

Timestamp, rappel de mémoire de ce tour, notes temporaires, résumé actuel côté front — tout est placé dans un pseudo message utilisateur après BP4 :

```
<gateway_volatile_context>仅供参考，勿复述：
（当前时间 / 本轮召回的记忆 / 摘要 / 纸条……）
</gateway_volatile_context>
```

Il change à chaque tour, mais il est placé **après tous les points d’arrêt**, donc peu importe comment il change, il ne touche jamais au préfixe du cache. C’est la clé de toute la conception : **isoler le contenu volatile en dehors de la frontière du cache**.

---

## Faire en sorte que les requêtes restent sur le même backend : user_id

Il ne suffit pas de mettre `cache_control`. Le load balancer intermédiaire envoie les requêtes aléatoirement à différents nœuds backend, le cache est écrit sur le nœud A, la requête suivante arrive sur le nœud B et ne peut pas lire, ce qui donne un comportement de « écriture sans lecture, hit toujours à 0 ».

Notre solution : fixer au niveau supérieur de la requête

```json
"metadata": { "user_id": "sillage-anan-stable" }
```
Chaîne fixe, pour que la route sticky colle toujours cette conversation au même backend. Sans cela, tous les points de rupture précédents sont inutiles.

---

## Différents canaux, différentes méthodes de liaison

Tous les upstreams ne fonctionnent pas de la même manière. La passerelle détermine automatiquement selon le domaine de l'upstream, avec trois modes :

| Mode | Upstream | Protocole | cache_control attaché où | TTL |
|---|---|---|---|---|
| `anthropic-bp` | Connexion directe Anthropic / msui / Jingguagua | `/v1/messages` | au-dessus des blocs system | 1h (Jingguagua supporte seulement 5m) |
| `or-blocks` | OpenRouter | OAI `/chat/completions` | intégré dans le bloc content des messages | 1h |
| `oai-passthrough` | OAI classique en relais / site inconnu | OAI | pas attaché, le site gère le cache implicitement | incontrôlable |

Les mécanismes de persistance des deux principales routes sont différents, **à ne jamais mélanger** :

- **Route native Anthropic** utilise `metadata.user_id` pour coller au backend.
- **Route OpenRouter** ne regarde pas user_id, utilise `hash(première partie du system + premier message non system)` pour coller au backend. Donc changer le personnage, changer le monde ou modifier l’intro sur OR change le hash, rendant le cache inutile. Sur OR, l’intro et le personnage doivent être figés.

De plus, certains sites (comme ekan) renvoient directement un 4xx sur `cache_control`. La passerelle inscrit ces hôtes en erreur dans une liste noire, puis rétrograde définitivement en mode passthrough sans cache, évitant ainsi les répétitions de 400. C’est une auto-guérison sans intervention humaine.

---

## 5min ou 1h

| TTL | Coût d’écriture | Coût de lecture | Usage |
|---|---|---|---|
| 5min | 1,25x | 0,1x | Conversations rapides et continues |
| 1h | 2x | 0,1x | Reprendre la conversation après une pause de 30 minutes, sûr |

La lecture coûte toujours 0,1x (10 fois moins cher). La différence est seulement le coût d’écriture et la durée de conservation. Pour un enchaînement rapide, on utilise 5m, pour les longues sessions interrompues, 1h.

---

## Comment vérifier que le cache a vraiment fonctionné

Consulter l’usage dans la réponse :

- Anthropic natif : `usage.cache_read_input_tokens` (lecture) / `cache_creation_input_tokens` (écriture)

- Compatible OAI : `usage.prompt_tokens_details.cached_tokens`

Interprétation :

- Première passe read=0, write un gros bloc → Normal, construction du cache
- À partir de la deuxième passe read non nul → **Cache utilisé**
- Toujours read=0 write=0 → cache_control n'a pas du tout fonctionné, panne
- Toujours write sans read → le routage a déraillé (user_id non transmis / ou le hash OR a changé)

Consulter les logs de la passerelle :

```bash
pm2 logs chat-gateway-proxy | grep -E "HIT|MISS"
```
- `HIT 96% (47354/49310)` ← Notre état actuel  
- `MISS (created 0)` ← Échec, ni écrit ni lu  

Page de surveillance : `https://catcatty.uk/llm/cache-stats`  

---  

## Les règles d'or que nous avons établies  

1. **Le système doit impérativement séparer « segment stable + segment dynamique »**, seul le segment stable est marqué. Même une phrase comme « ce soir à 18h » dans BP1 rend tout le cache invalide.  
2. **Tout ce qui change doit être placé après BP4**, dans `gateway_volatile_context`. Temps, rappel de mémoire, résumés temporaires, rien ne doit rester dans le préfixe.  
3. **`user_id` fixe et immuable**, s’il n’est pas présent, écrire sans lire.  
4. **Le dernier user ajoute un marqueur rolling** (accroché à l’avant-dernier), intégrant l’historique dans le cache, économisant au maximum sur les longues sessions.  
5. **Historique en lecture seule, ne pas réessayer d’écrire les tours précédents**. « Régénérer le tour précédent » modifie le préfixe, reconstruisant tout le segment.  
6. **Ordre du schéma des outils fixe**. Réordonner dynamiquement la liste des outils selon les commutateurs = miss complet.  
7. **Fixer rigoureusement le personnage et l’introduction** par OR, ils se lient au backend via hash, tout changement est pris comme une nouvelle conversation.  

En respectant ces sept règles, il ne reste plus qu’à choisir le bon `mode` et `ttl` en amont. C’est ainsi que nous atteignons 96%.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-13

---