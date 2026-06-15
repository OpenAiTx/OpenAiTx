# claude-sbox

Une compétence [Claude Code](https://code.claude.com) qui apprend à Claude à écrire du code idiomatique [s&box](https://sbox.game) — composants C#, interface Razor, physique et réseau — sans recourir aux modèles Unity.

s&box est le moteur de jeu Source 2 de Facepunch avec une couche de script C#. Son API, son cycle de vie et son modèle réseau *n’ont rien à voir* avec ceux d’Unity, ce qui fait que Claude génère constamment des hallucinations : `void Start()`, `GetComponent<T>()` au sens Unity, `Physics.Raycast`, `[SerializeField]`, `StartCoroutine` — tout cela est faux dans s&box. Cette compétence se charge lorsque vous écrivez du code s&box et redirige Claude vers les API correctes, vérifiées contre le schéma exporté du moteur.

---

## Installer

**Personnel (disponible dans tous vos projets) :**

```bash
mkdir -p ~/.claude/skills
git clone https://github.com/gavogavogavo/claude-sbox ~/.claude/skills/sbox
```

**Local au projet (ce jeu uniquement) :**

```bash
cd my-sbox-game
mkdir -p .claude/skills
git clone https://github.com/gavogavogavo/claude-sbox .claude/skills/sbox
```
Claude Code détecte en direct les modifications des fichiers de compétences. Cependant, si `~/.claude/skills/` n'existait pas lorsque votre session Claude Code a démarré (c’est-à-dire qu’il s’agit de votre première compétence personnelle), vous devez **redémarrer Claude Code** après le `mkdir` afin que le surveillant enregistre le nouveau répertoire.

> **Pourquoi le nom du répertoire `sbox` (et non `claude-sbox`) ?** Le frontmatter `name:` dans `SKILL.md` est `sbox`, ce qui devient la commande slash `/sbox`. Cloner dans `~/.claude/skills/sbox/` maintient la cohérence entre le nom du répertoire et le nom d’invocation.

---

## Vérifiez que ça fonctionne

Dans n’importe quelle session Claude Code, tapez :


```
/sbox
```

Le routeur se charge. Alternativement, posez une question déclencheuse et regardez Claude consulter un fichier de référence :

```
How do I write a networked player controller in s&box?
```

Claude doit ouvrir `references/core-concepts.md`, `references/networking.md`, et/ou `references/patterns-and-examples.md` avant de répondre — *c’est le signal que la compétence fonctionne*. S’il répond de mémoire sans lire un fichier, quelque chose ne va pas ; voir [Dépannage](#troubleshooting).

---

## Contenu

`SKILL.md` est un routeur, pas une référence. Quand Claude a besoin de détails, il ouvre l’un de ceux-ci :

| Fichier | Lignes | Couvre |
|---|---:|---|
| `SKILL.md` | 271 | Routeur + table de traduction Unity→s&box + les dix règles |
| `references/core-concepts.md` | 575 | Système de scènes, GameObjects, Composants, cycle de vie, `[Property]`, prefabs, événements de scène, `GameObjectSystem`, asynchrone |
| `references/components-builtin.md` | 729 | 144 composants intégrés — renderers, rigidbodies, colliders, `CharacterController`, `CameraComponent`, lumières, audio, UI, `NavMeshAgent`, `PlayerController`, particules, post-traitement |
| `references/ui-razor.md` | 834 | Panneaux Razor, SCSS, mise en page flexbox, contrôles intégrés (Button / TextEntry / DropDown / SliderControl / VirtualGrid), `NavigationHost`, transitions |
| `references/networking.md` | 672 | Lobbies, `Connection`, `[Sync]` + `SyncFlags`, `[Rpc.Broadcast/Host/Owner]`, propriété, `INetworkListener`, `INetworkSpawn`, données snapshot, serveurs dédiés |
| `references/input-and-physics.md` | 597 | Système d’entrée, API constructeur `SceneTrace`, `PhysicsWorld`, collision, `Vector3`/`Rotation`/`Angles`/`Transform`/`BBox`/`Ray`/`Capsule`, `TimeSince`/`TimeUntil`, `Gizmo.Draw` |
| `references/api-schema-core.md` | 930 | Signatures publiques complètes pour les ~50 types les plus utilisés |
| `references/api-schema-extended.md` | 2753 | Index organisé par namespace de 738 types supplémentaires pour la découverte |
| `references/patterns-and-examples.md` | 1056 | 10 exemples complets exécutables (Health + `IDamageable`, `CharacterController` à la première personne, arme hitscan, gestionnaire de jeu réseau, joueur avec `[Sync]`/RPCs, HUD Razor, grenade rigide, machine d’état IA NavMeshAgent, générateur de prefabs, déclencheur de ramassage) |

Chaque signature d’API dans chaque fichier de référence est vérifiée par rapport au schéma exporté du moteur s&box (`raw/api-schema.json`, ~1 850 types répartis sur 61 namespaces). Le schéma est la source unique de vérité — si la documentation et le schéma diffèrent, c’est le schéma qui prévaut.

---

## Mise à jour

```bash
cd ~/.claude/skills/sbox
git pull
```

Claude Code recharge les fichiers de compétences modifiés dans la session en cours.

---

## Régénération à partir de la source

Les utilisateurs finaux n’en ont pas besoin. Pour les mainteneurs qui souhaitent reconstruire les fichiers de référence avec une version plus récente du moteur s&box :

```bash
./scripts/fetch-raw.sh         # clones Facepunch/sbox-docs into raw/sbox-docs
# manually place raw/api-schema.json (see docs/DESIGN.md)
node scripts/build_extended.js # rebuilds references/api-schema-extended.md
```

Le flux de travail complet de construction — incluant la façon dont chaque fichier de référence a été élaboré, la boucle de vérification du schéma, et les pièges connus — est documenté dans [`docs/DESIGN.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/DESIGN.md) et [`docs/BUILD_LOG.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/BUILD_LOG.md).

---

## Dépannage

**Claude ne déclenche pas la compétence sur les questions s&box.**
Vérifiez que le répertoire est à `~/.claude/skills/sbox/` (pas `~/.claude/skills/claude-sbox/` ni `~/.claude/skills/sbox-skill/`). Le nom du répertoire doit correspondre au champ `name:` du frontmatter. Essayez aussi de l’invoquer explicitement avec `/sbox` pour confirmer qu’il est installé.

**Claude répond aux questions s&box sans ouvrir de fichier de référence.**
Cela signifie qu’il hallucine à partir de la mémoire musculaire Unity — l’échec exact que cette compétence vise à prévenir. Soit la compétence ne se charge pas, soit la description ne correspond pas. Essayez `/sbox` pour forcer son chargement, puis reposez la question.

**La compétence se charge mais suggère des APIs qui ne compilent pas.**
Ouvrez un ticket avec le code suggéré et le fichier de référence dont Claude affirme qu’il provient. Chaque signature fournie doit être vérifiée par le schéma ; les régressions sont des bugs.

**Je l’ai cloné dans `~/.claude/skills/claude-sbox/` — et maintenant ?**
Renommez soit le répertoire en `sbox`, soit changez le champ `name:` dans `SKILL.md` en `claude-sbox` pour que cela corresponde. Même chose pour les installations locales au projet.

---

## Contribution

Issues et PRs bienvenues. Avant de soumettre :

- **Vérifiez les nouvelles signatures d’API avec `raw/api-schema.json`.** Le schéma est la vérité fondamentale. Si vous ne trouvez pas une méthode dans le schéma, ne l’ajoutez pas.
- **Gardez `SKILL.md` sous 500 lignes.** C’est un routeur — les détails des références vivent dans `references/`. Si vous pouvez répondre à une question s&box en n’utilisant que `SKILL.md` sans ouvrir un fichier de référence, le routeur contient trop de détails.
- **Mettez à jour `CHANGELOG.md`** pour tout changement visible par l’utilisateur.
- **Respectez le style de prose existant** — concis, dense, écrit pour Claude plutôt que pour un lecteur de tutoriel.

---

## Licence

MIT — voir [LICENSE](LICENSE).

Ce projet n’est affilié ni approuvé par Facepunch ou Anthropic. s&box est un produit de Facepunch Studios. Claude Code et le format Agent Skills sont des produits d’Anthropic.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---