# RemoteVideoCam

Remote Video Cam 是一款开源的安卓应用程序，允许两台设备通过本地连接相互传输高质量的视频和音频。无论你是用它作为婴儿监视器、DIY 安全摄像头，还是对讲机，RemoteVideoCam 都提供了一个安全的、离线优先的解决方案，无需互联网访问或第三方服务器。

## ✨ 功能

- **零配置**：设备自动发现并连接彼此。
- **稳定连接**：自动协商最佳可用连接方式：
  - **本地网络 (LAN)**：使用你现有的 Wi-Fi 网络。
  - **Wi-Fi Aware / Wi-Fi Direct**：设备直接连接，无需接入点（离线）。
- **安全与隐私**：无外部服务器，无云端。视频和音频流绝不会离开你的本地环境。
- **现代界面**：使用 **Jetpack Compose** 和 **Material 3** 构建，提供美观、响应快速且直观的界面，支持动态颜色。
- **两种模式**：
  - **摄像头模式**：作为广播端。
  - **显示模式**：观看另一设备的视频流。
    - *包含“镜像”选项，可水平翻转视频。*
  - *注意：两台设备均可处于显示模式，实现双向观看。*
- **音频支持**：听见对端的声音。

## ⚠️ 重要提示

**非医疗设备**：虽然 RemoteVideoCam 可用于监控（例如作为婴儿监视器），但它 **不是** 认证的医疗设备。  
- 网络干扰可能导致视频冻结。  
- 始终备有备用监控方式。  
- **建议**：在画面中放置一个运动物体（如带秒针的时钟），便于确认视频是实时的。

## 🛠️ 技术栈

- **语言**：Kotlin  
- **UI 框架**：Jetpack Compose（Material 3）  
- **视频/音频**：WebRTC（本地协商）  
- **计算机视觉**：OpenCV（用于特定图像处理任务）  
- **架构**：MVVM 结合响应式数据流（RxJava/RxAndroid）

## 📥 distinct

[<img src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png"
     alt="Get it on F-Droid"
     height="80">](https://f-droid.org/packages/org.avmedia.remotevideocam/)
[<img src="https://play.google.com/intl/en_us/badges/images/generic/en-play-badge.png"
     alt="在 Google Play 获取"
     height="80">](https://play.google.com/store/apps/details?id=org.avmedia.remotevideocam)

## 🤝 贡献

欢迎贡献！如果你是开发者并且想帮助改进 RemoteVideoCam，请随时 fork 本仓库并提交 pull request。

对于重大更改或问题，请联系维护者：`izivkov@gmail.com`。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---