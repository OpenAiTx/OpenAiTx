<img src="https://raw.githubusercontent.com/jerthz/scion/main/banner.png" alt="Scion" />

Scion 是一个用 Rust 编写的 2D 游戏库。

> 请注意，该项目处于初期里程碑阶段，可能会根据便利性需求和即将到来的重要功能进行变更。
> 
> 你可以随意使用 Scion，虽然我将其开源是为了服务社区，而不是作为现有 Rust 游戏引擎生态的竞争者。

## 为什么做这个项目？ 
首先，因为这是学习游戏开发各个方面的好方法。 
其次，因为我想创建一个目标适中的项目，专注于易用性和一套简洁的原则，同时也作为指导方针。

Scion 并非“受”其他引擎启发，而是基于真实游戏项目的需求。这意味着我不会仅仅因为在别处看到某个功能就去实现它，而是因为我需要它来支持下一个使用 Scion 的项目。

### 目标
- 重点专注于 **2D**。
- **简单**且**有趣**的使用体验。 
- 干净且易读的源代码（至少必要时我们会尝试重写）
- 无编辑器，它是一个库且应该一直保持如此

### 非目标
- 超级/过度优化的代码和性能。对此，请尝试其他引擎或自己构建！
- 3D

## 文档，教程？
是的，计划中并正在制作。如果你想看 Scion 的实际效果，目前请查看示例。

## 为什么选择 ECS？
如今，ECS 就像是游戏、游戏库和游戏引擎中的“魔法”词汇。但 ECS 并非，也不应被视为解决多个问题的万能答案。
我相信 ECS 有其优点和缺点。 
这里选择 ECS 是因为该库最初的目标游戏是能够制作： 
- 复杂的城市建设游戏。
- 一个带有实时训练师进度和野生宝可梦的宝可梦同人游戏。
- 细粒度的网络数据包表示和点模拟游戏。

## 主要依赖
这些是本项目所依赖的库。感谢这些优秀的社区，我们才能构建这样的轻量级项目。

- <a href="https://github.com/rust-windowing/winit" target="blank">winit</a> 和 <a href="https://github.com/gfx-rs/wgpu/tree/master/wgpu" target="blank">wgpu</a>（窗口和多后端渲染）
- <a href="https://github.com/Ralith/hecs" target="blank">hecs</a>（实体组件系统）
- <a href="https://github.com/termhn/ultraviolet" target="blank">ultraviolet</a>（数学）

## 先决条件
要构建 Scion，您需要为您的系统安装所需的软件包：
### Debian、Ubuntu、PopOS...
```sh
sudo apt install gcc cmake build-essential libx11-dev libxi-dev libgl1-mesa-dev libasound2-dev
```

### 费多拉
```sh
sudo dnf install gcc cmake make automake gcc gcc-c++ kernel-devel libX11-devel libXi-devel mesa-libGL-devel alsa-lib-devel
```

### Arch，Manjaro...
```sh
sudo pacman -S gcc cmake make automake linux-headers libx11 libxi mesa alsa-lib
```

### 运行示例
然后，您可以运行一个示例：
```sh
cargo run --example bomberman --release
```

## 展示

| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/taquin/taquin_2.gif" alt="Taquin" style="width:300px; border: 2px solid black;"/>  | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/tetris/tetris.gif" alt="Tetris" style="width:300px" />             | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/pixel-adventures/pixel-adventures.gif" alt="Pixel-adventures" style="width:300px" /> |
|---------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/bomberman/bomberman.gif" alt="Bomberman" style="width:300px" />                    | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/jezzball/jezzball.gif" alt="Jezzball" style="width:300px" />       | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/new-bark-town/new-bark-town.gif" alt="New bark town" style="width:300px" />          |
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/starlight-1961/starlight.gif" alt="Starlight" style="width:300px" />               | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/klondike.gif" alt="Starlight" style="width:300px" /> | |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---