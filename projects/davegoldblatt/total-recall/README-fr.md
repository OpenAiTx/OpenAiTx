# Total Recall

Un système de mémoire pour Claude Code qui retient l'essentiel et oublie le superflu.

## Le Problème

Claude Code oublie tout entre les sessions. À chaque nouvelle conversation, c’est comme parler à quelqu’un atteint d’amnésie. Vous vous retrouvez à vous répéter :

- « Nous avons déjà essayé cette approche, ça n’a pas marché. »
- « Ne touche pas au fichier d’auth. »
- « Je préfère les tabulations aux espaces. »
- « Le nom du client est Sarah, pas Sara. »

Ça devient vite lassant.

## Ce Que Fait Total Recall

Il donne à Claude Code un bloc-notes qui se conserve entre les sessions, mais un bloc-notes *exigeant*. Tout ne s’y inscrit pas. Avant qu’une information soit sauvegardée définitivement, elle doit passer un test simple : **est-ce que cela aura de l’importance demain ?**

Une préférence que vous garderez pendant des mois ? Enregistrée. Une décision prise et ses raisons ? Enregistrées. Le fait d’avoir lancé un test il y a cinq minutes ? Pas enregistré. Le système reste propre pour que Claude ne patauge pas dans le superflu pour trouver ce qui est pertinent.

## Comment Ça Marche

Pensez-y comme une cuisine avec quatre zones de rangement :

**Plan de travail** (`CLAUDE.local.md`) : Ce que vous utilisez tous les jours. Chargé automatiquement à chaque session. Gardé petit volontairement, environ une page de texte.

**Garde-manger** (`memory/registers/`) : Organisé par catégorie. Vos préférences, décisions clés, détails de projets, personnes avec qui vous travaillez. Claude vérifie ici quand il a besoin de quelque chose de précis.

**Carnet quotidien** (`memory/daily/`) : Notes brutes horodatées de chaque jour. Tout s’écrit d’abord ici. Vous décidez ensuite ce qui mérite d’être conservé définitivement.

**Placard de stockage** (`memory/archive/`) : Vieilles données terminées ou obsolètes. Toujours consultables, mais jamais chargées automatiquement.

L’idée clé : **les notes vont d’abord dans le carnet quotidien, puis vous promouvez celles à garder.** Claude ne décide pas seul ce qui est assez important pour être mémorisé à long terme. C’est vous qui décidez.

## Démarrage Rapide

### Installer comme plugin (recommandé)

```
/plugin marketplace add davegoldblatt/recall-marketplace
/plugin install recall@recall-marketplace
```

### Ou installez en mode autonome

```
git clone https://github.com/davegoldblatt/total-recall.git
cd total-recall
./install.sh /path/to/your/project
```

Après l'installation, redémarrez Claude Code ou exécutez `/hooks` pour activer.

## Utilisation

Voici votre quotidien :

**Claude remarque quelque chose à retenir.** Il l'écrit dans votre carnet quotidien et vous le dit. Vous n'avez rien à faire.

**Vous voulez que Claude retienne quelque chose.** Dites simplement "souviens-toi de ça" ou utilisez la commande d'écriture :

```
/recall-write Dave prefers concise error messages, no stack traces in prod
```
**Fin de journée (ou à tout moment).** Passez en revue ce qui s’est accumulé et mettez en avant les bonnes choses :


```
/recall-promote
```

**Trouvez quelque chose de la semaine dernière.** Recherchez dans tout :

```
/recall-search authentication decision
```

**Vous avez raison Claude.** La correction met à jour partout en même temps : le cahier quotidien, les registres et le compteur. La même erreur ne se reproduira plus.

### Toutes les commandes

| Commande | Ce qu'elle fait |
|---|---|
| `/recall-init` | Configurer les dossiers de mémoire pour la première fois |
| `/recall-write <note>` | Enregistrer une note (vérifie si elle vaut la peine d'être gardée, suggère où) |
| `/recall-log <note>` | Note rapide dans le cahier quotidien, sans poser de questions |
| `/recall-search <requête>` | Rechercher partout |
| `/recall-promote` | Revoir les notes quotidiennes, déplacer les gardiennes vers les registres |
| `/recall-status` | Vérification de santé. Tout fonctionne-t-il ? |
| `/recall-maintain` | Nettoyer les entrées obsolètes ou en double |
| `/recall-forget <requête>` | Marquer quelque chose comme périmé |
| `/recall-context` | Montrer quelle mémoire Claude a chargée actuellement |

Si installé comme plugin, les commandes sont sous un namespace : `/recall:recall-write` au lieu de `/recall-write`.

## La Porte d'Écriture

C’est l’idée centrale. Avant qu’une information soit promue en mémoire permanente, elle doit passer au moins une de ces vérifications :

1. **Cela va-t-il changer le comportement de Claude la prochaine fois ?** (une préférence, une limite, un schéma)
2. **Est-ce un engagement sur lequel quelqu’un compte ?** (une échéance, une livraison, un suivi)
3. **Est-ce une décision dont il vaut la peine de se rappeler la raison ?** (pourquoi vous avez choisi X plutôt que Y)
4. **Est-ce un fait stable qui reviendra ?** (pas quelque chose qui sera différent demain)
5. **Avez-vous explicitement dit « souviens-toi de ça » ?**

Si aucun de ces cas n’est vrai, cela reste dans le cahier quotidien et finit par disparaître avec le temps. Cela maintient la mémoire légère. Pas de tiroir à bazar.

## Quand les corrections arrivent

Si vous dites à Claude qu’il a fait une erreur, il ne se contente pas de dire « désolé » et de passer à autre chose. Il met à jour le cahier quotidien, le registre concerné, et le compteur, tout en une fois. L’ancienne information est marquée comme remplacée (pas supprimée) pour qu’il y ait une trace de ce qui a changé et quand.

## Ce qui se charge automatiquement

Seulement deux choses, à chaque session :

| Quoi | Où | Comment |
|---|---|---|
| Les règles (write gate, protocole de correction) | `rules/total-recall.md` | Claude Code charge automatiquement tous les fichiers de règles |
| Compteur / mémoire de travail | `CLAUDE.local.md` | Claude Code charge ceci automatiquement |

Tout le reste se charge à la demande : lors d'une recherche, lorsque c'est pertinent, ou au démarrage de la session via des hooks.

## Hooks

Deux choses se passent automatiquement en arrière-plan :

**Quand une session démarre :** Claude reçoit un résumé des éléments ouverts et des notes journalières récentes. C'est le briefing "voici où nous en étions restés".

**Avant que la mémoire soit compactée :** Un horodatage est écrit dans le carnet quotidien pour garder une trace. Celui-ci est silencieux. Claude ne le voit pas, c'est juste de la tenue de registre.

Les deux hooks échouent sans risque. Si quelque chose ne va pas, ils ne bloquent pas le fonctionnement de Claude Code.

Les hooks utilisent `$CLAUDE_PROJECT_DIR` (mode autonome) ou `${CLAUDE_PLUGIN_ROOT}` (plugin) pour résoudre les chemins. Pas de parsing de transcript. Le hook PreCompact écrit uniquement un marqueur d’horodatage dans le journal quotidien. Il ne lit ni ne parse les transcripts de conversation.

## Architecture

Pour ceux qui veulent les détails techniques.

```
Conversation (ephemeral, compacted/discarded)
    |
    v  WRITE GATE: "Does this change future behavior?"
    |
Daily Log (memory/daily/YYYY-MM-DD.md)
    All writes land here first. Raw, timestamped.
    |
    v  PROMOTION: user-controlled via /recall-promote
    |
Registers (memory/registers/*.md)
    Structured claims with metadata (confidence, evidence, last_verified)
    |
    v  DISTILLATION: only what's essential for every session
    |
Working Memory (CLAUDE.local.md)
    ~1500 words. Auto-loaded. The persistent "personality."
    |
    v  EXPIRY
    |
Archive (memory/archive/)
    Searchable history. Never auto-loaded.
```

### Mécanismes Clés

**Porte d’écriture :** Filtre le bruit. Seuls les faits modifiant le comportement, les engagements, décisions et demandes explicites de « se souvenir de ceci » passent.

**Journal Quotidien d’Abord :** Toutes les écritures atterrissent dans le journal quotidien. La promotion vers les registres est une étape distincte, contrôlée par l’utilisateur. Cela empêche le modèle de figer prématurément les inférences.

**Protocole de Contradiction :** Ne remplace jamais silencieusement. Les anciennes affirmations sont marquées `[superseded]` avec date et raison. Le schéma de changement est conservé.

**Porte de Correction :** Les corrections humaines ont la plus haute priorité. Une correction déclenche des écritures dans le journal quotidien + registre + mémoire de travail.

### Structure des Fichiers

**Format du plugin** (installé via `/plugin install`) :

```
total-recall/                     # Plugin root
├── .claude-plugin/
│   └── plugin.json               # Plugin manifest
├── skills/                       # Slash commands (namespaced)
│   ├── recall-write/SKILL.md
│   ├── recall-search/SKILL.md
│   └── ...
├── hooks/
│   ├── hooks.json                # Hook configuration
│   ├── session-start.sh
│   └── pre-compact.sh
├── rules/
│   └── total-recall.md           # Protocol (auto-loaded)
└── templates/                    # Scaffolding templates
    ├── SCHEMA.md
    ├── CLAUDE.local.md
    └── registers/
```

**Format autonome** (installé via `install.sh`) :

```
your-project/
├── .claude/
│   ├── commands/recall-*.md      # Slash commands
│   ├── rules/total-recall.md     # Protocol (auto-loaded)
│   ├── hooks/*.sh                # Hook scripts
│   └── settings.local.json       # Hook configuration
├── memory/
│   ├── SCHEMA.md
│   ├── daily/YYYY-MM-DD.md
│   ├── registers/*.md
│   └── archive/
├── CLAUDE.md
└── CLAUDE.local.md               # Working memory (gitignored)
```

### Comparé à d'autres outils de mémoire

|  | Total Recall | Outils d'auto-ingestion |
|---|---|---|
| **Ce qui est sauvegardé** | Seulement ce qui passe la porte d'écriture | Tout |
| **Destination par défaut** | Journal quotidien (promotion ultérieure) | Stockage permanent |
| **Coût en contexte** | Mémoire de travail d'environ 1500 mots | Croît sans limite |
| **Corrections** | Propagation immédiate à tous les niveaux | Variable |
| **Contrôle utilisateur** | La promotion est explicite | Automatique |
| **Architecture** | 4 niveaux avec métadonnées | Plate ou à 2 niveaux |

## Confidentialité

- Tout est local. Pas d'appels réseau, pas de télémétrie, pas de services externes.
- Toute la mémoire est constituée de fichiers markdown que vous pouvez lire et modifier vous-même.
- `CLAUDE.local.md` est ignoré par git par défaut (c'est personnel).
- `memory/` est ignoré par git par défaut (il peut contenir des notes personnelles).
- Les hooks ne lisent jamais vos transcriptions de conversation.
- Pour voir exactement ce qui se passe : vérifiez `hooks/*.sh` et `memory/`. Tout est en texte clair.
- Pour désinstaller : supprimez `memory/`, `CLAUDE.local.md` et les entrées `.claude/` (ou `/plugin uninstall recall`).

## Fonctionne avec Superpowers

Si vous utilisez [Superpowers](https://github.com/obra/superpowers), il n'y a pas de conflits. Superpowers gère *comment* Claude fonctionne (méthodologie, TDD, plans). Total Recall gère *ce que* Claude retient. Différents rôles, même projet.

## Licence

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---