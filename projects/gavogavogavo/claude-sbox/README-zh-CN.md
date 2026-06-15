# claude-sbox

一个 [Claude Code](https://code.claude.com) 技能，教 Claude 编写地道的 [s&box](https://sbox.game) 代码 — C# 组件、Razor UI、物理和网络 — 不依赖 Unity 模式。

s&box 是 Facepunch 的 Source 2 游戏引擎，带有 C# 脚本层。它的 API、生命周期和网络模型与 Unity *完全不同*，这意味着普通 Claude 经常产生幻觉：`void Start()`、Unity 语境中的 `GetComponent<T>()`、`Physics.Raycast`、`[SerializeField]`、`StartCoroutine` — 在 s&box 中全都错。这项技能在你编写 s&box 代码时加载，并将 Claude 引导到正确的 API，基于引擎导出的架构进行验证。

---

## 安装

**个人（适用于你所有项目）：**

```bash
mkdir -p ~/.claude/skills
git clone https://github.com/gavogavogavo/claude-sbox ~/.claude/skills/sbox
```

**项目本地（仅限本游戏）：**

```bash
cd my-sbox-game
mkdir -p .claude/skills
git clone https://github.com/gavogavogavo/claude-sbox .claude/skills/sbox
```
Claude Code 会实时捕捉技能文件的更改。然而，如果在启动 Claude Code 会话时 `~/.claude/skills/` 不存在（即这是您的第一个个人技能），您需要在执行 `mkdir` 后**重新启动 Claude Code**，以便监视器注册新目录。

> **为什么目录名是 `sbox`（而不是 `claude-sbox`）？** `SKILL.md` 中的 `name:` 前置内容是 `sbox`，这会变成 `/sbox` 斜杠命令。克隆到 `~/.claude/skills/sbox/` 保持了目录名和调用名的一致。

---

## 验证是否工作正常

在任何 Claude Code 会话中，输入：


```
/sbox
```
路由器加载完成。或者，提出一个触发性问题，观察Claude查找参考文件：


```
How do I write a networked player controller in s&box?
```
Claude 应该先打开 `references/core-concepts.md`、`references/networking.md` 和/或 `references/patterns-and-examples.md` 再回答——*这是技能正常工作的信号*。如果它在未阅读任何文件的情况下凭记忆回答，那就是出了问题；请参见[故障排除](#troubleshooting)。

---

## 内容简介

`SKILL.md` 是路由器，而非参考资料。当 Claude 需要细节时，它会打开以下文件之一：

| 文件 | 行数 | 涵盖内容 |
|---|---:|---|
| `SKILL.md` | 271 | 路由器 + Unity→s&box 转换表 + 十条规则 |
| `references/core-concepts.md` | 575 | 场景系统、游戏对象、组件、生命周期、`[Property]`、预制件、场景事件、`GameObjectSystem`、异步 |
| `references/components-builtin.md` | 729 | 144 个内置组件——渲染器、刚体、碰撞体、`CharacterController`、`CameraComponent`、灯光、音频、UI、`NavMeshAgent`、`PlayerController`、粒子、后期处理 |
| `references/ui-razor.md` | 834 | Razor 面板、SCSS、弹性盒布局、内置控件（按钮 / 文本输入 / 下拉菜单 / 滑块控件 / 虚拟网格）、`NavigationHost`、过渡效果 |
| `references/networking.md` | 672 | 大厅、`Connection`、`[Sync]` + `SyncFlags`、`[Rpc.Broadcast/Host/Owner]`、所有权、`INetworkListener`、`INetworkSpawn`、快照数据、专用服务器 |
| `references/input-and-physics.md` | 597 | 输入系统、`SceneTrace` 构建 API、`PhysicsWorld`、碰撞、`Vector3`/`Rotation`/`Angles`/`Transform`/`BBox`/`Ray`/`Capsule`、`TimeSince`/`TimeUntil`、`Gizmo.Draw` |
| `references/api-schema-core.md` | 930 | 约 50 个最常用类型的完整公共签名 |
| `references/api-schema-extended.md` | 2753 | 按命名空间组织的 738 个附加类型索引以供查找 |
| `references/patterns-and-examples.md` | 1056 | 10 个完整可运行示例（Health + `IDamageable`、第一人称 `CharacterController`、命中扫描武器、联网游戏管理器、带 `[Sync]`/RPC 的玩家、Razor HUD、刚体手榴弹、NavMeshAgent AI 状态机、预制件生成器、触发拾取） |

每个参考文件中的每个 API 签名均经过与 s&box 引擎导出的架构（`raw/api-schema.json`，约 1,850 个类型，涵盖 61 个命名空间）的验证。架构是唯一的真实来源——如果文档与架构不符，以架构为准。

---

## 更新


```bash
cd ~/.claude/skills/sbox
git pull
```

Claude Code 会在当前会话中重新加载已修改的技能文件。

---

## 从源代码重新生成

最终用户不需要此操作。对于希望针对较新 s&box 引擎重建参考文件的维护者：

```bash
./scripts/fetch-raw.sh         # clones Facepunch/sbox-docs into raw/sbox-docs
# manually place raw/api-schema.json (see docs/DESIGN.md)
node scripts/build_extended.js # rebuilds references/api-schema-extended.md
```
完整的构建工作流程——包括每个参考文件的整理方式、架构验证循环以及已知的注意事项——记录在 [`docs/DESIGN.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/DESIGN.md) 和 [`docs/BUILD_LOG.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/BUILD_LOG.md) 中。

---

## 故障排除

**Claude 没有在 s&box 问题上触发技能。**  
检查目录是否位于 `~/.claude/skills/sbox/`（而非 `~/.claude/skills/claude-sbox/` 或 `~/.claude/skills/sbox-skill/`）。目录名称必须与 `name:` 前置字段匹配。也尝试用 `/sbox` 显式调用以确认技能已安装。

**Claude 回答 s&box 问题时没有打开参考文件。**  
这意味着它在凭借 Unity 肌肉记忆进行幻觉——这正是该技能存在以防止的失败。要么技能未加载，要么描述不匹配。尝试 `/sbox` 强制加载，然后重新提问。

**技能已加载但建议的 API 无法编译。**  
请提交一个问题，附上建议的代码和 Claude 声称来源的参考文件。每个发布的签名都应经过架构验证；出现回归即为错误。

**我把它克隆到了 `~/.claude/skills/claude-sbox/`——接下来怎么办？**  
要么将目录重命名为 `sbox`，要么将 `SKILL.md` 中的 `name:` 字段改为 `claude-sbox` 以匹配。本地项目安装同理。

---

## 贡献指南

欢迎提交问题和 PR。提交前请：

- **验证新的 API 签名是否符合 `raw/api-schema.json`。** 架构即权威真相。如果在架构中找不到方法，请勿添加。  
- **保持 `SKILL.md` 少于 500 行。** 它是路由器——详细参考内容存放在 `references/`。如果你能仅用 `SKILL.md` 回答一个 s&box 问题而无需打开参考文件，说明路由器内容过于冗杂。  
- **更新 `CHANGELOG.md`** 以反映任何用户可见的更改。  
- **保持现有文风一致**——简洁、密集，面向 Claude 而非教程读者。

---

## 许可证

MIT — 详见 [LICENSE](LICENSE)。

本项目与 Facepunch 或 Anthropic 无任何关联或背书。s&box 是 Facepunch Studios 的产品。Claude Code 和 Agent Skills 格式是 Anthropic 的产品。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---