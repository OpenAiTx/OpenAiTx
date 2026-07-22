# PleaseDontStopTheMusic

一个 iOS 调整工具，通过防止音频会话中断，允许多个音频源同时播放。

## ❤️ 支持项目

如果您觉得本项目有用并希望支持开发，欢迎捐助。

### 莱特币
**网络：** 莱特币 (LTC)  
**地址：** `ltc1qaz2zqcc5usl4ueg7w5m8kqcmvrfqurpn6wqyfa`

请务必确认您是在 **莱特币** 网络上发送。

感谢您的支持！

---

## 概述

**PleaseDontStopTheMusic** 是一款钩取 iOS `AVAudioSession` 的调整工具，实现音频混合。它允许您当前播放的音频（音乐、播客等）在其他应用请求播放音频时继续不中断，而不是系统通常暂停您的音频并只播放新音源。

## 功能

- **连续播放** - 当其他应用想播放声音时，您的音频依然持续播放。
- **音频混合** - 通过 `MixWithOthers` 选项，多路音频源混合播放。
- **通用支持** - 支持 rootful、rootless 和越狱安装。
- **轻量级** - 最小开销，纯钩取实现。

## 工作原理

该调整拦截 `AVAudioSession` 的配置调用，**仅当已有其他应用正在播放音频**（`isOtherAudioPlaying`）时，向新应用的会话应用 `AVAudioSessionCategoryOptionMixWithOthers` 选项。此选项告诉 iOS 将新音频与现有播放混合，而非中断。

关键是，它**不会**强制混合主音乐源的应用。选择 `MixWithOthers` 的应用被 iOS 视为*次要*音源，会失去锁屏 / 控制中心的“正在播放”传输控制。通过保持第一个/主要应用不变，该应用保留完整的锁屏跳过和暂停控制，而后来的应用（TikTok、游戏等）被强制静默混合，不中断主音频。

### 钩取的方法

- `setCategory:error:`
- `setCategory:mode:options:error:`
- `setCategory:mode:routeSharingPolicy:options:error:` *(TikTok 及大多数当前应用使用的现代 API)*
- `setCategory:withOptions:error:`
- `setActive:error:`
- `setActive:withOptions:error:`

`SoloAmbient` 会话（不能混合使用）在其他应用播放时会透明切换为 `Ambient`，因此它们不会再静音你的音乐。

---

## 安装指南

请选择适合您设备配置的方法。

### 方法一：未越狱（侧载）
如果您的设备未越狱，请使用此方法。您需要将发布的 tweak `.dylib` 注入目标应用的 IPA 文件中。

1. **准备：** 确保您拥有 `PleaseDontStopTheMusic.dylib` 文件。
2. **选择工具：** 使用侧载工具，如 **Esign**、**Feather** 或 **Sideloadly**。
3. **注入：** 将目标应用（您想要在其上播放媒体的应用，例如，如果我想在玩 Roblox 时听 Spotify，我就会将其注入到 Roblox）IPA 导入工具，选择 `.dylib` 进行注入，并签名应用。
4. **安装：** 将修改后的 IPA 安装到您的设备。

### 方法二：越狱
如果您的设备已越狱，请使用此方法。

1. **添加源：** 打开 https://repo.chariz.com/ 并点击按钮将其添加到您偏好的软件包管理器（这应该是默认源，如果没有请添加）。
2. **安装：** 在软件包管理器中找到该源，搜索“PleaseDontStopTheMusic”进行安装。
3. **完成：** 对设备执行 **重启 SpringBoard** 以应用钩子。

---

如果您有任何问题或疑问，欢迎在 Discord 上私信我！dc: fuseegelee

```bash
make all
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---