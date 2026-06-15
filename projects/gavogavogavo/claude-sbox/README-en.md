# claude-sbox

A [Claude Code](https://code.claude.com) skill that teaches Claude to write idiomatic [s&box](https://sbox.game) code — C# components, Razor UI, physics, and networking — without falling back on Unity patterns.

s&box is Facepunch's Source 2 game engine with a C# scripting layer. Its API, lifecycle, and networking model are *nothing like* Unity's, which means stock Claude hallucinates constantly: `void Start()`, `GetComponent<T>()` in the Unity sense, `Physics.Raycast`, `[SerializeField]`, `StartCoroutine` — all wrong in s&box. This skill loads when you're writing s&box code and redirects Claude to the correct APIs, verified against the engine's exported schema.

---

## Install

**Personal (available across all your projects):**

```bash
mkdir -p ~/.claude/skills
git clone https://github.com/gavogavogavo/claude-sbox ~/.claude/skills/sbox
```

**Project-local (this game only):**

```bash
cd my-sbox-game
mkdir -p .claude/skills
git clone https://github.com/gavogavogavo/claude-sbox .claude/skills/sbox
```
Claude Code picks up skill file changes live. However, if `~/.claude/skills/` did not exist when your Claude Code session started (i.e. this is your first personal skill), you need to **restart Claude Code** after the `mkdir` so the watcher registers the new directory.

> **Why the `sbox` (not `claude-sbox`) directory name?** The `name:` frontmatter in `SKILL.md` is `sbox`, which becomes the `/sbox` slash command. Cloning into `~/.claude/skills/sbox/` keeps the directory name and the invocation name in sync.

---

## Verify it's working

In any Claude Code session, type:


```
/sbox
```
The router loads. Alternatively, ask a triggering question and watch Claude reach for a reference file:


```
How do I write a networked player controller in s&box?
```

Claude should open `references/core-concepts.md`, `references/networking.md`, and/or `references/patterns-and-examples.md` before answering — *that's the signal the skill is working*. If it answers from memory without reading a file, something's wrong; see [Troubleshooting](#troubleshooting).

---

## What's inside

`SKILL.md` is a router, not a reference. When Claude needs detail, it opens one of these:

| File | Lines | Covers |
|---|---:|---|
| `SKILL.md` | 271 | Router + Unity→s&box translation table + the ten rules |
| `references/core-concepts.md` | 575 | Scene system, GameObjects, Components, lifecycle, `[Property]`, prefabs, scene events, `GameObjectSystem`, async |
| `references/components-builtin.md` | 729 | 144 built-in components — renderers, rigidbodies, colliders, `CharacterController`, `CameraComponent`, lights, audio, UI, `NavMeshAgent`, `PlayerController`, particles, post-processing |
| `references/ui-razor.md` | 834 | Razor panels, SCSS, flexbox layout, built-in controls (Button / TextEntry / DropDown / SliderControl / VirtualGrid), `NavigationHost`, transitions |
| `references/networking.md` | 672 | Lobbies, `Connection`, `[Sync]` + `SyncFlags`, `[Rpc.Broadcast/Host/Owner]`, ownership, `INetworkListener`, `INetworkSpawn`, snapshot data, dedicated servers |
| `references/input-and-physics.md` | 597 | Input system, `SceneTrace` builder API, `PhysicsWorld`, collision, `Vector3`/`Rotation`/`Angles`/`Transform`/`BBox`/`Ray`/`Capsule`, `TimeSince`/`TimeUntil`, `Gizmo.Draw` |
| `references/api-schema-core.md` | 930 | Full public signatures for the ~50 most-used types |
| `references/api-schema-extended.md` | 2753 | Namespace-organized index of 738 additional types for discovery |
| `references/patterns-and-examples.md` | 1056 | 10 complete runnable examples (Health + `IDamageable`, first-person `CharacterController`, hitscan weapon, networked game manager, player with `[Sync]`/RPCs, Razor HUD, rigidbody grenade, NavMeshAgent AI state machine, prefab spawner, trigger pickup) |

Every API signature in every reference file is verified against the s&box engine's exported schema (`raw/api-schema.json`, ~1,850 types across 61 namespaces). Schema is the single source of truth — if the docs and the schema disagree, the schema wins.

---

## Updating

```bash
cd ~/.claude/skills/sbox
git pull
```

Claude Code reloads modified skill files within the current session.

---

## Regenerating from source

End users do not need this. For maintainers who want to rebuild the reference files against a newer s&box engine:

```bash
./scripts/fetch-raw.sh         # clones Facepunch/sbox-docs into raw/sbox-docs
# manually place raw/api-schema.json (see docs/DESIGN.md)
node scripts/build_extended.js # rebuilds references/api-schema-extended.md
```
The full build workflow — including how each reference file was curated, the schema-verification loop, and known gotchas — is documented in [`docs/DESIGN.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/DESIGN.md) and [`docs/BUILD_LOG.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/BUILD_LOG.md).

---

## Troubleshooting

**Claude isn't triggering the skill on s&box questions.**
Check that the directory is at `~/.claude/skills/sbox/` (not `~/.claude/skills/claude-sbox/` or `~/.claude/skills/sbox-skill/`). The directory name must match the `name:` frontmatter. Also try invoking it explicitly with `/sbox` to confirm it's installed.

**Claude answers s&box questions without opening a reference file.**
That means it's hallucinating from Unity muscle memory — the exact failure this skill exists to prevent. Either the skill isn't loading, or the description isn't matching. Try `/sbox` to force-load it, then retry the question.

**The skill is loading but suggesting APIs that don't compile.**
Open an issue with the suggested code and which reference file Claude claims it came from. Every shipped signature should be schema-verified; regressions are bugs.

**I cloned it into `~/.claude/skills/claude-sbox/` — now what?**
Either rename the directory to `sbox`, or change the `name:` field in `SKILL.md` to `claude-sbox` to match. Same deal for project-local installs.

---

## Contributing

Issues and PRs welcome. Before submitting:

- **Verify new API signatures against `raw/api-schema.json`.** The schema is ground truth. If you can't find a method in the schema, don't add it.
- **Keep `SKILL.md` under 500 lines.** It's a router — reference detail lives in `references/`. If you can answer an s&box question using only `SKILL.md` without opening a reference file, the router has too much detail.
- **Update `CHANGELOG.md`** for any user-visible change.
- **Match the existing prose style** — terse, dense, written for Claude rather than for a tutorial reader.

---

## License

MIT — see [LICENSE](LICENSE).

This project is not affiliated with or endorsed by Facepunch or Anthropic. s&box is a product of Facepunch Studios. Claude Code and the Agent Skills format are products of Anthropic.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---