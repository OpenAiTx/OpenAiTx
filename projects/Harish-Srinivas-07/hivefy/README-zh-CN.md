![Hivefy 横幅](https://raw.githubusercontent.com/Harish-Srinivas-07/hivefy/main/./assets/docs/fullbanner.png)

<h1 align="center">Hivefy 🎧</h1>

<p align="center">

  <!-- 🔹 GitHub 下载量 -->
  <a href="https://github.com/Harish-Srinivas-07/hivefy/releases/latest">
    <img alt="GitHub 下载量" src="https://img.shields.io/github/downloads/Harish-Srinivas-07/hivefy/total?label=Downloads(Git)">
  </a>

  <!-- 🔹 SourceForge 下载量 -->
  <a href="https://sourceforge.net/projects/hivefy/files/">
    <img alt="SourceForge 下载量" src="https://img.shields.io/sourceforge/dt/hivefy?label=Downloads(SF)">
  </a>

  <!-- 🔹 GitHub 最新发布 -->
  <a href="https://github.com/Harish-Srinivas-07/hivefy/releases/latest">
    <img alt="GitHub 发布" src="https://img.shields.io/github/v/release/Harish-Srinivas-07/hivefy">
  </a>
  <!-- 🔹 构建于 / 平台 / 开源 -->
  <img alt="Flutter" src="https://img.shields.io/badge/Built%20With-Flutter-02569B">
  <img alt="Android" src="https://img.shields.io/badge/Platform-Android-3DDC84?logo=android&logoColor=white">
  <img alt="开源" src="https://img.shields.io/badge/Open%20Source-Yes-brightgreen">
  
</p>

**Hivefy** 是一款 **FOSS，灵感来自 Spotify，无广告且支持离线的音乐应用**，使用 **Flutter** 构建，基于 **非官方的 JioSaavn API**。  
探索热门榜单、专辑、播放列表和多语言内容——全部 **开源、尊重隐私且高度可定制**。🎵

<a href="https://github.com/Harish-Srinivas-07/hivefy/releases/latest">
  <img alt="Hivefy 的 OSS 新星徽章" src="https://b.sf-syn.com/badge_img/3922596/oss-rising-star-black" width="170">
</a>

<h3>安卓下载 😍</h3>

<!-- GitHub 按钮 -->
<p>
  <a href="https://github.com/Harish-Srinivas-07/hivefy/releases" target="_blank">
    <img alt="Github 构建" src="https://raw.githubusercontent.com/NeoApplications/Neo-Backup/034b226cea5c1b30eb4f6a6f313e4dadcbb0ece4/badge_github.png" height="60" style="vertical-align: middle;" />
  </a>
</p>

<!-- SourceForge button -->
<p>
  <a href="https://sourceforge.net/projects/hivefy/" target="_blank">
    <img alt="下载 Hivefy" src="https://a.fsdn.com/con/app/sf-download-button" height="40" style="vertical-align: middle;" />
  </a>
</p>


> ⚠️ 确保在您的设备设置中启用了“允许安装未知来源应用”，以安装 Hivefy。

## ✨ 功能

### 🎨 现代体验

- 受 Spotify 启发的**界面和动画**
- 动态的**Material You 主题**
- 使用 **SpotifyMix** 的自适应图标和排版

### 🎧 强大的播放器

- 通过 `audio_service` 实现后台播放
- 滑动手势和可视化进度控制
- **动画迷你播放器 → 全屏播放器过渡**

### 💾 离线优先

- 下载并本地存储音乐（专辑 / 播放列表 / 歌曲）
- 自动清理无效文件
- 后台下载通知

### 🔍 智能搜索与库

- 统一的全局搜索（歌曲、专辑、艺术家、播放列表）
- 由 **Hive DB** 支持的持久化库
- 完全**离线可用**

### ⚙️ 设置与自定义
- 服务器选择器（主服务器 / 备份服务器 / 镜像服务器）
- 缓存管理与下载监控
- 切换主题、清除存储等功能

## 🖼️ 截图

<p align="center">
  <img src="https://raw.githubusercontent.com/Harish-Srinivas-07/hivefy/main/./assets/docs/pic1.png" width="230" />
  <img src="https://raw.githubusercontent.com/Harish-Srinivas-07/hivefy/main/./assets/docs/pic2.png" width="230" />
  <img src="https://raw.githubusercontent.com/Harish-Srinivas-07/hivefy/main/./assets/docs/pic3.png" width="230" />
</p>
<p align="center">
  <img src="https://raw.githubusercontent.com/Harish-Srinivas-07/hivefy/main/./assets/docs/pic4.png" width="230" />
  <img src="https://raw.githubusercontent.com/Harish-Srinivas-07/hivefy/main/./assets/docs/pic5.png" width="230" />
</p>

## 🧠 即将推出的功能

- [ ] 🎼 歌词同步与覆盖显示
- [ ] 🧠 基于 AI 的推荐
- [ ] ☁️ 云端个人资料同步
- [ ] 🖥️ Windows 应用支持
- [ ] 🍏 iOS 应用支持
- [ ] 🤝 播放列表分享与协作

---
## 🌐 Hivefy 网页版（全新 🚀）

Hivefy 现已支持 **网页版**！

👉 **在线演示:** https://hivefyweb.vercel.app  
👉 **开源仓库:** https://github.com/Harish-Srinivas-07/hivefyweb

Hivefy 网页版基于 **Next.js** 构建，带来快速、响应式且无需安装的音乐体验，直接在浏览器中畅享。

### ✨ 亮点

* 🎨 灵感源自 Spotify 的用户界面
* ⚡ 轻量且响应迅速

* 🔍 全局搜索  
* 💾 离线优先缓存  
* 🎧 画中画 & 媒体会话支持  
* 🌍 多语言支持  

> 无需安装 — 打开即可开始收听。  

---  


## 🚀 快速开始  

### 前提条件  

- Flutter SDK **(>=3.7.2)**  
- 配置好 Flutter 的 Android Studio / VS Code  
- Java JDK **17+**（用于应用签名）  
- 运行 **Android 7.0+** 的设备或模拟器  

### 设置与运行  

```bash
git clone https://github.com/Harish-Srinivas-07/hivefy.git
cd hivefy
flutter pub get
flutter run
```

## 🧩 技术栈

| 类别       | 包                                                                                 |
| ---------- | ---------------------------------------------------------------------------------- |
| **状态管理** | `flutter_riverpod`                                                                 |
| **音频**   | `just_audio`, `audio_service`, `just_audio_background`                             |
| **存储**   | `hive`, `shared_preferences`, `path_provider`                                      |
| **界面/用户体验** | `shimmer`, `cached_network_image`, `figma_squircle`, `flashy_tab_bar2`, `readmore` |
| **网络**   | `dio`, `http`, `html_unescape`                                                     |
| **系统**   | `flutter_local_notifications`, `disk_space_plus`, `package_info_plus`              |
| **工具**   | `toastification`, `permission_handler`, `internet_connection_checker_plus`         |

## 💡 开发者说明

- **调试构建** 使用 `DebugServer` 端点（无需签名）
- **发布构建** 会自动通过 ProGuard 优化
- 所有数据模型均包含带有反转义规范化的 `toJson` 和 `fromJson`
- 你可以修改 `services/` 下的后端逻辑和 `views/` 下的界面流程

---

## ❤️ 贡献

我们欢迎每个人的 PR 和想法。
如果你想添加功能或修复错误：

```bash
# Fork & branch
git checkout -b feature/my-awesome-feature

# Make changes
flutter pub get
flutter run
```

然后打开一个拉取请求——我们将一起审查它 🎵

## ⚠️ 免责声明

> Hivefy 使用 **非官方的 JioSaavn API** 仅用于教育和研究目的。
> 该应用 **不托管或分发** 任何受版权保护的媒体。
> 所有权利归其各自所有者所有。

## ⭐ 给仓库点星

如果 Hivefy 激励了你，通过在 GitHub 上为它点星 ⭐ 来表达你的支持！
让我们一起构建下一代开放音乐应用——**为所有人，无广告**。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-09

---