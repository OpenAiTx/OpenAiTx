_库 crate:_
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)

_编辑器 crate:_
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)

[![CI](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml/badge.svg)](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml)

# Bevy 动画图

> **_注意:_** 如果您当前使用的是版本 `0.8.0` 或更低版本，请注意
> `0.9.0` 引入了许多重大变更。请查看
> [迁移指南](https://mbrea-c.github.io/bevy_animation_graph/migration_guides/0.8_to_0.9.html)
> 以进行升级。

## 动机

动画图是管理现代3D游戏动画流程复杂性的关键工具。当您的游戏拥有数十个
动画，且包含复杂的混合和过渡，或者您想通过极少的关键帧程序化生成动画时，
简单的动画剪辑播放就远远不够了。

该 crate 作为大多数 `bevy_animation` 的替代方案，旨在
提供完整的动画系统和开发工作流程，包括动画图、动画状态机（即动画控制器）
以及用于创建动画图和状态机的图形编辑器。

_注意：此项目与 `bevy_animation` 0.14 版本中引入的动画图是分开的。_

![示例使用截图](https://raw.githubusercontent.com/mbrea-c/bevy_animation_graph/master/locomotion_graph.png)

## 当前功能

- 动画图是资源。它们可以从资源文件加载，也可以通过符合人体工学的 API 在代码中创建。
- 可视化图形编辑器。





- 动画状态机：
  - 动画状态机作为节点嵌入动画图中。
  - 状态机中的每个状态按需播放其自身的动画图。
  - 转换也有自己的动画图，并且可以查询源状态和目标状态的动画图。
- 布娃娃支持：
  - 编辑器中可视化布娃娃编辑。
  - 支持_部分布娃娃_，其中部分骨骼通过物理模拟，其他骨骼由目标动画姿势驱动。
- 支持用 Rust 编写自定义节点。
  - 用户可以通过添加编辑器插件并在 Bevy 类型注册表中注册额外的自定义节点来创建自己的编辑器二进制文件。
  - 编辑器会自动识别所有已注册的节点。
- 内置节点包括：
  - 动画链式播放（即一个节点接着另一个播放）。
  - 两骨反向运动学。
  - 循环播放。
  - 线性混合（在骨骼空间中）。
  - 2D 混合空间节点。
  - 关于 YZ 平面的动画镜像。
  - 动画剪辑播放。
  - 使用骨骼蒙版对某些骨骼应用给定的旋转。
  - 加速或减慢动画播放速度。
  - 动画图节点。
  - 动画状态机节点。
  - 算术节点：对 f32、Vec3、Quat 等常见操作的多种支持。
- 嵌套动画图作为其他动画图中的节点。
- 使用事件轨道进行动画同步。
- 节点输出进行缓存以避免不必要的计算。

## 计划功能

1. 布娃娃“姿势跟随”模式，模拟布娃娃骨骼尝试通过物理力匹配目标姿势：
   - _绝对_匹配模式，跟踪目标骨骼的世界空间位置/旋转，并作为弹簧力作用于布娃娃骨骼的锚点。
   - _相对_匹配模式，布娃娃骨骼尝试匹配相对于其父骨骼的目标位置/旋转。我们可能需要 Avian 支持关节马达以正确实现此模式。









## 安装

### 库

[bevy_animation_graph](https://crates.io/crates/bevy_animation_graph) 是
该项目的库部分。应将其作为依赖项添加到您的
项目中以使用动画图。要安装来自 crates.io 的最新发布版本，
请运行

```bash
cargo add bevy_animation_graph
```

或者手动将最新版本添加到你的 `Cargo.toml` 中。

要安装最新的 git 主分支版本，请将以下内容添加到 `Cargo.toml`：

```toml
# ...
[dependencies]
# ...
bevy_animation_graph = { git = "https://github.com/mbrea-c/bevy_animation_graph.git" }
# ...
```

### 编辑器

[bevy_animation_graph_editor](https://crates.io/crates/bevy_animation_graph_editor)
是编辑器。你可以像安装其他 Rust 二进制文件一样安装它：

```bash
# for the latest crates.io version
cargo install bevy_animation_graph_editor
# for the latest master
cargo install --git https://github.com/mbrea-c/bevy_animation_graph bevy_animation_graph_editor
# for the version from a local workspace
cargo install --path <PATH_TO_WORKSPACE> bevy_animation_graph_editor

# use the --force flag to force reinstall
```
或者，我建议查看
[作为插件的编辑器示例](https://github.com/mbrea-c/bevy_animation_graph/blob/master/examples/editor_as_a_plugin/examples/editor_as_a_plugin.rs)
以便在您的 crate/工作区中设置自己的编辑器二进制文件，使用与您的游戏相同的库版本。这样您就可以注册自定义动画图节点，这是该 crate 的一个强大功能。

## 入门

请查看
[正在进行中的教程书](https://sarahihme.github.io/initial_book_bevy_animation_graph/)
（非常感谢 @SarahIhme 的启动贡献！）。

额外的、最新的示例包含在
[examples](https://github.com/mbrea-c/bevy_animation_graph/tree/master/examples)
目录中。

以下资源可能也有用，但它们有些过时：

- [docs.rs](https://docs.rs/bevy_animation_graph) 中的文档包含
  库和编辑器的介绍以及一个简单动画图示例的说明。另请参见下面的视频，演示编辑器的使用。
- 有一个过时的
  [使用视频演练](https://www.youtube.com/watch?v=q-JBSQJIcX0)。

## 贡献或寻求帮助

如果您遇到错误或想讨论潜在的新功能，欢迎
发布 issue，提交 PR 或在 Discord 上联系我（在 Bevy discord 中我是 @mbreac，有一个针对 `bevy_animation_graph` 的 crate-help 频道：
[链接](https://discord.com/channels/691052431525675048/1202998277482479616)）。

## 常见问题

### 这已经可以用于生产环境了吗？

视情况而定。

它已经可以用于较小的项目，但我不能保证 API






不同 `0.x` 版本之间的稳定性（这是一个大型库，相对较新，我之前没有动画编程的经验，所以我仍在摸索最佳的实现方式）。  
这意味着可能需要手动迁移你的动画图资产到不同版本，至少在我找到更好的迁移处理方法之前是这样。  

此外，肯定会有（而非可能有）错误和其他问题。  
我会尽量在它们出现时修复。  

### 你会实现功能 X 吗？  

如果是小功能（例如一些额外的向量或浮点运算节点），很可能是我还没有来得及实现。  
如果你提出问题，我很可能会很快实现它。PR 也欢迎。  

对于更大的功能，最好先开一个 issue 进行讨论，或者在 Bevy discord 中@我。  

## 版本对应表  

| `bevy` | `bevy_animation_graph` |  
| ------ | ---------------------- |  
| 0.18 | master |  
| 0.18 | 0.10 |  
| 0.17 | 0.9 |  
| 0.17 | 0.8 |  
| 0.16 | 0.7 |  
| 0.15 | 0.6 |  
| 0.14 | 0.5 |  
| 0.13 | 0.4 |  
| 0.13 | 0.3 |  
| 0.12 | 0.2 |  

## 致谢  

非常感谢 [Bobby Anguelov](https://www.youtube.com/@BobbyAnguelov) 提供的动画编程讲座。









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---