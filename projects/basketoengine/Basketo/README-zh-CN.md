<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Basketo 游戏引擎标志" width="200"/>
</p>

<h2 align="center">创造、游玩、启发。让游戏焕发生机。✨</h2>

<h1 align="center">Basketo 游戏引擎</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- 用您的实际服务器 ID 替换 your_discord_server_id -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
欢迎来到 Basketo 引擎——这是一个充满激情的项目，我们正在全力以赴打造一个出色且高性能的引擎，并计划将其打造成原生 AI 游戏引擎。它拥有类 Unity 的编辑器界面、Gemini AI 集成、先进的多音效系统和强大的 ECS 架构。无论你是来贡献代码、提出建议，还是只是见证它的成长，你都是这段旅程的一部分！🚀
</p>
## 🚀 引擎当前状态
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>查看最新开发进展和功能演示！</em> 🎮
</p>

## ✨ 主要特性

### 🎮 **类Unity编辑器界面**
- **双窗口布局**：场景编辑器和游戏视图并排显示
- **实时编辑**：游戏运行时可修改场景
- **检查器面板**：可视化组件拖拽编辑
- **层级视图**：组织和管理实体
- **资源浏览器**：轻松管理纹理和音频

### 🤖 **AI原生开发**
- **集成Gemini AI**：使用自然语言指令进行游戏开发
- **智能脚本生成**：AI驱动的Lua脚本创建
- **实体修改**：用简单英文描述变更
- **简易API配置**：内置Gemini API密钥设置
### 🔊 **高级音频系统**
- **多音效**：每个实体可拥有多个命名音效（行走、跳跃、攻击等）
- **传统音频**：背景音乐和环境音效
- **Lua集成**：通过脚本使用 `PlaySound(entity, "action")` 触发音效
- **可视化编辑器**：通过检查器管理音效

### 🎯 **实体-组件-系统（ECS）**
- **高性能**：针对大量实体进行优化
- **模块化设计**：可按需组合各类组件
- **脚本集成**：Lua脚本可完全访问ECS
- **实时更新**：组件可实时编辑

### 🎨 **图形与动画**
- **精灵渲染**：高效的2D图形渲染管线
- **动画系统**：基于帧的动画及循环播放
- **变换系统**：位置、旋转与缩放
- **摄像机系统**：支持多摄像机

### ⚡ **物理与碰撞**
- **碰撞检测**：AABB碰撞检测及空间优化
- **刚体物理**：重力、速度与力
- **碰撞回调**：脚本可访问的碰撞事件
- **空间划分**：四叉树优化性能
## 🎬 点击下方图片观看视频演示：
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## 🚀 快速入门指南

### 1. **获取您的 Gemini API 密钥**（可选但推荐）
- 访问 [Google AI Studio](https://aistudio.google.com/app/apikey)
- 登录并创建一个免费的 API 密钥
- 这将启用如自然语言指令等 AI 驱动的功能

### 2. **构建并运行**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **配置 AI 功能**
- 在引擎中，进入 AI Prompt 面板（底部）
- 查找“🤖 Gemini AI 配置”
- 输入你的 API 密钥并点击“保存”

### 4. **开始创作**
- 尝试 AI 命令：`"create a player at 100 200"`
- 在检查器中为实体添加音效
- 编写 Lua 脚本或让 AI 生成脚本
- 使用双窗口编辑器进行实时开发

## 🛠️ 构建引擎（Linux）🐧

### 先决条件
- 需要 CMake 3.26.0 或更高版本。
- SDL2、SDL2_image、SDL2_ttf、SDL2_mixer
- Lua 5.4
- g++（C++17）
- libcurl（用于 AI 功能）
- nlohmann/json（作为子模块包含）
- ImGui（作为子模块包含）
### 构建步骤
```bash
# 克隆代码仓库
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### 运行
```bash
./BasketoGameEngine

```
如果你想运行物理测试：
```bash
./PhysicsTest

```

## 🛠️ 构建引擎（Windows）💻

### 前置条件

1. **Visual Studio 2022（社区版或更高版本）**  
   安装以下工作负载：
   - 使用 C++ 的桌面开发
   - Windows 的 C++ CMake 工具
   - Windows 10 或 11 SDK

2. **CMake**（随 Visual Studio 附带或从 https://cmake.org/download/ 下载）

3. **vcpkg**（用于安装依赖项）


---
### 安装依赖项

```bash
# 打开 VS 2022 的开发者命令提示符或 PowerShell

# 克隆 vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# 安装所需库
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### 构建步骤
```bash
# 克隆 Basketo 仓库
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# 使用 CMake 进行配置
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# 将 "C:/path/to/vcpkg" 替换为你的 vcpkg 目录的完整路径

# 构建引擎
cmake --build . --config Release
```

---

### 运行

```bash
# 从 build/Release 目录运行
```
./BasketoGameEngine.exe

# 运行物理测试
./PhysicsTest.exe
```

## 📚 文档

### 核心功能
- **[音效系统](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**：多音效完整指南
- **[Gemini API 设置](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**：AI 配置分步教程
- **[Lua 脚本](assets/Scripts/)**：示例脚本和 API 参考

### 示例用法

#### AI 驱动开发
```bash
# 自然语言指令
"在位置 100 200 创建一个玩家角色"
"为玩家添加跳跃行为"
"让敌人移动得更快"

# 脚本生成
gemini_script 创建一个带有二段跳的横版平台控制器
```

#### 多音效
```lua
-- 在你的 Lua 脚本中
PlaySound(entity, "jump")    -- 播放跳跃音效
PlaySound(entity, "walk")    -- 播放行走音效
PlaySound(entity, "attack")  -- 播放攻击音效

-- 检查音效是否存在
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### 组件系统
- **Transform**：位置、旋转、缩放
- **Sprite**：纹理渲染
- **Animation**：基于帧的动画
- **Script**：Lua 行为脚本
- **Collider**：物理碰撞
- **Rigidbody**：物理模拟
- **Audio**：背景音乐
- **SoundEffects**：多个命名音效
- **Camera**：视角管理
## 🤝 参与贡献

我们非常欢迎社区的贡献 ❤️。关于如何贡献或以开发模式运行本项目的详细说明，请查阅我们的[贡献指南](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md)。

- 🐛 发现了 Bug？欢迎提交 Issue！
- ✨ 有很酷的功能想法？快来说说吧！
- 💻 想要贡献代码？Fork、编码并提交 Pull Request！

让我们一起构建这个引擎，让游戏开发变得有趣且简单，人人都能参与。🌍

## 👥 社区
热烈欢迎您的加入 🤗。我们非常期待各种形式的社区贡献——无论是代码改进 📝、文档更新 📚、问题报告 🐞、功能请求 💡，还是在我们的 Discord 进行讨论 🗣️。

欢迎加入我们的社区：

- 👋 [加入我们的 Discord 社区](https://discord.gg/F3DswRMW)
- ⭐ [在 GitHub 上为我们点亮 Star](https://github.com/basketoengine/Basketo)

## 🙏 支持我们:
我们在不断改进中，更多功能和示例即将上线 🌟。如果你喜欢这个项目，请在 GitHub 仓库为我们点亮一颗星 ⭐ [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo)，关注我们并助力成长。🌱

---

祝你编程愉快，创造精彩游戏！🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---