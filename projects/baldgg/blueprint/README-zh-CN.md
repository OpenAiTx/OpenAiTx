如果你想学习如何使用它来制作游戏，[点击这里](https://learn.randy.gg/?src=template-starter)

如果你想不时收到像这个蓝图一样的免费资源，看看[我的邮件列表](https://path.randy.gg)

---

这几乎是我用于无引擎游戏开发的全部工具集。

我用这里的概念制作了这些游戏：
- https://store.steampowered.com/app/2571560/ARCANA/
- https://store.steampowered.com/app/3309460/Demon_Knives/
- https://store.steampowered.com/app/3433610/Terrafactor/

在过去五年里，我一直在迭代这些想法，学习如何不依赖引擎编程制作游戏。

这些内容处于不同的完成阶段，有很多待办事项，性能瓶颈也不少，等等。但目前来看，它已经是我迄今为止能达到的最接近生产环境的状态。

我会随着继续制作游戏和学习新知识不断更新它。

# 功能
- 通过 `asset_workbench/aseprite_asset_export.lua` 与 Aseprite 实现的非常快速的像素艺术资产创建和迭代流程
- 拥有可完全改造以满足各种视觉特效需求的渲染系统和着色器
- 单函数实体游戏编程工作流，具有良好的扩展性
- 通过 FMOD 实现的完整声音设计，附带封装，使编程实际声音播放钩子非常简单
- 非常紧凑的 Game_State 和实体结构，支持轻松序列化

## 未来某天™️
这些功能的预计时间未知，只有真正需要时才会实现。
- 控制器支持
- 适用于主机（Switch，Xbox，PS5）的自定义后端
- 3D 渲染包和管线

# 结构

`/sauce/bald` 目录下的包概览
- `/draw` 通过 Sokol 实现的跨平台高性能 2D 精灵渲染
- `/sound` 通过 FMOD 实现的简易声音播放和设计系统
- `/input` 简单的输入抽象
- `/utils/shape` 简单的碰撞形状抽象

^ 总的来说，这些包设计为易于升级和跨项目共享。

## `main.odin`  
这是入口点和主循环结构。

默认情况下，我使用可变时间步。它在大多数情况下表现良好，且尽可能减少复杂性。但这可以根据游戏的具体需求修改。比如多玩家游戏，或者需要固定时间步的场景，等等。

## `game.odin`
大多数魔法发生的地方。所有技术的交汇点。一个“只管做游戏”的地方。

这是我花费90%时间的文件，不断向游戏中添加新内容。它会很快变得很大。这里是编写游戏玩法杂项的舒适空间。

## `entity.odin`
实体巨构的骨干。如[这里](https://randyprime.beehiiv.com/p/entity-structure-made-simple)所述。

## `bald_helpers.odin`
这是 `/bald` 包与所有游戏特定内容的交汇点。

# 构建

总体来说，Windows 上开发更简单，因为工具更多，[大约96%](https://store.steampowered.com/hwsurvey/Steam-Hardware-Software-Survey-Welcome-to-Steam) 的 Steam 用户使用 Windows，这也意味着大多数人会遇到更少的 BUG，因为你每天使用同一个操作系统，可以解决所有平台特有的问题。如果你打算全职做游戏开发并以 Steam 为目标，我强烈建议搭建 Windows 环境。

我理解有些人更喜欢 Linux 或 Mac。由于 Sokol 很棒，原生支持相对简单，所以我开始添加对这两者的支持。

## Windows
1. [安装 Odin](https://odin-lang.org/docs/install/)
2. 运行 `build.bat`
3. 查看 `build/windows_debug`
4. 参见下面的运行说明

## Mac
1. [安装 Odin](https://odin-lang.org/docs/install/)
2. 运行 `build_mac.sh`
3. 查看 `build/mac_debug`
4. 参见下面的运行说明

## Linux
待办

## Web
即将推出™️

# 运行
需要从根目录运行，因为它访问 `/res`。

建议设置 [RAD Debugger](https://github.com/EpicGamesExt/raddebugger)（仅限 Windows）以获得优秀的运行和调试体验。我总是直接从那里启动我的游戏，这样更容易随时捕捉 BUG。

# 常见问题
## 我如何用它来制作游戏？
我专注于通过[我的付费课程](https://learn.randy.gg/?src=template-starter)教大家如何使用它。

如果你预算有限，以下是一些免费替代方案：
- 我会在[直播](https://www.youtube.com/@randyprime2)中使用它进行开发
- 我在[我的 YouTube 频道](https://www.youtube.com/@randyprime)制作相关教学内容

## 为什么这叫“蓝图”（而不是库）？
游戏开发很复杂。

我认为试图用一个库来抽象一切是个错误。它让事情看起来“干净”，但牺牲了能力，限制了你能做的事，迫使你使用蹩脚的变通方法，而不是用最简单直接的方式解决问题。

旧方法：  
1. 使用库  
2. 在使用过程中遇到瓶颈  
3. 采用临时解决方案或放弃该想法  

新方法：  
1. 使用此蓝图  
2. 在使用过程中遇到瓶颈  
3. 学习其所做的基本原理，然后在此基础上构建，调整源代码  
4. （可选）提交问题，以便我考虑将其集成到蓝图中  

> 最常见的例子是你想在渲染中实现某些功能。于是你去学习图形编程，使用[这个](https://learnopengl.com/)，可能重写你自己的 `/draw` 版本，或者只调整它以实现你需要的功能。（渲染纹理、调整顶点数据、多阶段绘制过程和后期处理等）  

我尽力将核心层 `/bald` 与游戏特定内容分离，以便后续升级，但我相信在许多地方仍不可避免地存在一些想法上的纠缠。  

我将继续努力简化它，使其尽可能易读易用，同时不牺牲其完全适用于生产的强大功能。  

## 为什么选择 Odin？  
相比 C 语言，工作起来更有趣。总体输入更少，默认更安全，且生活质量更高。愉快的编程 = 更多游戏内容。  

相比 Jai，它有更多用户且是公开的（Jai 仍处于封闭测试阶段）。这意味着更高的稳定性和更完善的生态系统，包括包管理、工具等（因为使用的人更多）。  

## 为什么选择 Sokol？  
它感觉像是高低层次的一个良好平衡点。  

它不像 Raylib 那样高级，所以你可以更灵活地操作。但要使用它，你需要学习图形编程。对于初学者来说，这有点困难。这就是我构建这个蓝图的原因。它有点像一个集成的生产准备套件，你可以选择深入细节，而无需改变最终的游戏编程流程。  

但它也不像手动编写 win32 代码和原始 directx11 那样低级，来实现屏幕上绘制三角形。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---