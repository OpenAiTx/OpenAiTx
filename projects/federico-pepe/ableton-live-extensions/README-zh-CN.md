# Ableton Live 扩展实验

![Ableton Live 扩展](/images/Ableton-Extensions.png)

🖥️ [观看我在 YouTube 上的介绍视频](https://www.youtube.com/watch?v=_izRiBGngGI)

*打破常规。让 Live 成为你的专属工具。*

扩展是一种通过强大工具增强 Live 功能的新方式，可以通过自动化重复任务来加快你的工作流程，激发或打乱新创意，甚至更多。

本仓库收集了一些我为你开发的扩展，供你试用、探索和编辑。它们大多数只是用来测试 SDK 功能的实验。

你可以在这里了解更多关于 Ableton 扩展的信息：

* [Ableton.com](https://www.ableton.com/en/live/extensions)
* [扩展 SDK](https://ableton.github.io/extensions-sdk)
* [加入 Ableton 的 Discord](https://discord.gg/ableton) 讨论扩展相关话题

## 要求

* Ableton Live Suite 12.4.5 测试版

## 免责声明

这些扩展大部分是在 *Claude Code* 的帮助下开发的，他承担了代码部分的大量工作。如果这让你感到不安或者你不认同这种做法，完全没问题。无论如何，非常感谢你花时间来了解它们。

特别感谢 **Rain** 和 **Jackie** 帮助我开发 **Bird Game** 扩展并让它看起来如此出色。感谢 Glau [@glaurossi](https://github.com/glaurossi) 让 **Doom** 支持 Windows。**Freesound Sampler** 是在 Freesound 主要开发者 Frederic Font Corbera [@ffont](https://github.com/ffont) 的反馈协助下开发的。

---

# 扩展

| 名称 | 版本 | 描述 | 下载 | 源码 |
|---|---|---|---|---|
| Arrangement Helper | 0.0.8 | 在 MIDI 轨道上构建带有命名、着色区段的结构化编排。*⚠️ 请阅读扩展自述文件中的已知限制。* | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Arrangement-Helper-0.0.8.ablx) | [🏗️ 源码](extensions/arrangement-helper) |
| Basic Pitch ✨ | 1.0.3 | 使用 Spotify 的 Basic Pitch 神经网络将音频片段转换为 MIDI，完全离线（macOS 和 Windows） | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Basic-Pitch-1.0.3.ablx) | [🏗️ 源码](extensions/spotify-basic-pitch) |
| Bird Game | 1.1.0 | 一个灵感来自 Flappy Bird 的趣味游戏，将你的运行转换为 MIDI 片段（macOS 和 Windows） | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/bird-game-1.1.0.ablx) | [🏗️ 源码](extensions/bird-game) |
| Chord Progression Helper | 0.5.1 | 从任意调构建和弦进程并写入 MIDI 片段 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Progression-Helper-0.5.1.ablx) | [🏗️ 源码](extensions/chord-progression-helper) |
| Chord Voicing Helper | 1.0.2 | 检测 MIDI 片段中的和弦，允许你应用和预览和弦配音策略 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Voicing-Helper-1.0.2.ablx) | [🏗️ 源码](extensions/chord-voicings-helper) |
| ChromaFlux | 0.0.7 | 使用可配置的模式和强度随机化乐器机架参数 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/ChromaFlux-0.0.7.ablx) | [🏗️ 源码](extensions/chroma-flux) |
| Doom | 1.0.0 | 在 Ableton Live（macOS 和 Windows）中完全离线运行原版 DOOM 试玩版（1993） | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Doom-1.0.0.ablx) | [🏗️ 源码](extensions/doom) |
| Duplicate Track | 0.0.7 | 复制轨道但不复制其剪辑 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Duplicate-Track-0.0.7.ablx) | [🏗️ 源码](extensions/duplicate-track) |
| Freesound Sampler | 1.1.3 | 搜索 Freesound.org 并直接将声音下载到你的轨道中 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Freesound-Sampler-1.1.3.ablx) | [🏗️ 源码](extensions/freesound-sampler) |
| Session to Arrangement Bridge | 0.0.8 | 将所有 Session 视图剪辑以完全保真度传输到 Arrangement 视图。*⚠️ 请阅读扩展的 README 文件中的当前已知限制。* | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Session-to-Arrangement-Bridge-0.0.8.ablx) | [🏗️ 源码](extensions/session-arrangement-bridge) |
| Snake | 0.0.7 | 在 Live 内玩贪吃蛇，并将你的游戏过程转换为 MIDI 剪辑 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Snake-0.0.7.ablx) | [🏗️ 源码](extensions/snake) |
| Track Creator | 0.0.6 | 通过简单对话框一次创建多个音频或 MIDI 轨道 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Track-Creator-0.0.6.ablx) | [🏗️ 源码](extensions/track-creator) |
| Transpose Clips | 0.1.0 | 将 Live 集合中每个 MIDI 剪辑升降指定半音数 | [⬇️ 下载](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Transpose-Clips-0.1.0.ablx) | [🏗️ 源码](extensions/transposer) |

✨ *最近更新*

---

# 更新日志

## 2026年6月28日

### Basic Pitch 1.0.3
- **不确定进度条** — 转录期间进度条现在以不确定模式动画显示，而不是冻结。TF.js CPU 推理是同步的，会阻塞 Node 的单线程，因此固定百分比在推理完成前无法更新。

## 2026年6月15日

### Freesound Sampler 1.1.3
- **启发我** — 点击 **启发我** 选择随机搜索词，立即发现意想不到的声音
- **OAuth 登录** — 改进流程。移除 API 密钥字段。

## 2026年6月12日

### Freesound Sampler 1.0.0
- **OAuth 登录** — 可直接通过扩展使用 Freesound 账号登录，无需手动填写 API 密钥
- **原始质量下载** — 登录后，声音以其原始格式（WAV、FLAC、AIFF 等）下载，而非 MP3 预览
- **归属助手** — 归属视图列出导入的声音，一键复制以便致谢创作者
- **高级搜索过滤器** — 可按音色描述（明亮度、温暖度、粗糙度等）、调性、BPM、时长、许可证等过滤

## 2026年6月9日

### Bird Game 1.1.0
- **Windows 支持** — 现支持 macOS 和 Windows 双平台

### Doom 1.0.0
- **Windows 支持** — 现支持 macOS 和 Windows 双平台（感谢 Glau [@glaurossi](https://github.com/glaurossi)）
- **完全离线** — 所有游戏资源打包，无需互联网连接

## 2026年6月7日

### Basic Pitch 1.0.0
- **支持Windows** — 得益于[@jwfeniello](https://github.com/jwfeniello)的贡献，实现了完整的跨平台支持（macOS和Windows）
- **内置模型** — 机器学习模型完全本地运行，数据不离开您的设备
- **稳定性修复** — 修复了主机崩溃及压缩音频样本的处理问题

## 2026年6月1日

### 首次公开发布
- **Bird Game 1.0.0** — 受Flappy Bird启发的游戏，将您的跑动转换为MIDI片段
- **Doom** — 原版DOOM共享版（1993）在Ableton Live内运行，迁移至新SDK
- **Arrangement Helper**、**Basic Pitch**、**Chord Progression Helper**、**Chord Voicing Helper**、**ChromaFlux**、**Duplicate Track**、**Freesound Sampler**、**Session to Arrangement Bridge**、**Snake**、**Track Creator**、**Transpose Clips** — 首个公开版本

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-12

---