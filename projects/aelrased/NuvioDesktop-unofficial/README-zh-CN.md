<div align="center">

  <img src="https://github.com/tapframe/NuvioTV/blob/main/assets/brand/app_logo_wordmark.png" alt="Nuvio" width="300" />
  <br />
  <br />

  [![Contributors][contributors-shield]][contributors-url]
  [![Forks][forks-shield]][forks-url]
  [![Stargazers][stars-shield]][stars-url]
  [![Issues][issues-shield]][issues-url]
  [![License][license-shield]][license-url]

  <p>
    一个为Android和iOS打造的现代媒体中心，采用Kotlin多平台和Compose多平台开发。
    <br />
    Stremio插件生态 • 跨平台
  </p>

</div>

## 关于

Nuvio是原React Native应用的Kotlin多平台重写版本。它为Android和iOS提供共享的Compose UI，同时保持了以播放为核心的体验、收藏工具、观看进度流程、下载功能以及塑造早期应用的Stremio插件生态集成。

该移动应用由[composeApp](./composeApp)中的单一共享代码库构建，拥有针对Android和iOS的原生平台入口点。

## 安装

### Android

从[GitHub Releases](https://github.com/NuvioMedia/NuvioMobile/releases/latest)下载最新的Android版本。

### iOS

- [TestFlight](https://testflight.apple.com/join/u4y7MHK9)

## 开发

```bash
git clone https://github.com/NuvioMedia/NuvioMobile.git
cd NuvioMobile
./scripts/run-mobile.sh android
# or
./scripts/run-mobile.sh ios
```

### 项目结构

- `composeApp/` 包含共享的 Kotlin 多平台和 Compose 多平台应用代码。
- `composeApp/src/commonMain/` 包含共享的 UI、功能、仓库和平台无关的逻辑。
- `composeApp/src/androidMain/` 包含 Android 特定的集成。
- `composeApp/src/iosMain/` 包含 iOS 特定的集成。
- `iosApp/` 包含原生 Xcode 项目和 iOS 入口点。

有用的命令：

```bash
./gradlew :composeApp:assembleDebug
./gradlew :composeApp:compileKotlinIosSimulatorArm64
./scripts/build-distribution.sh
```
版本控制来源于 `iosApp/Configuration/Version.xcconfig`，该文件作为 iOS 和 Android 构建的共享真实来源。

## 法律与 DMCA

Nuvio 仅作为客户端界面，用于浏览元数据和播放由用户安装的扩展和/或用户提供的来源提供的媒体。它旨在用于用户拥有或被授权访问的内容。

Nuvio 与任何第三方扩展、目录、来源或内容提供商无关。它不托管、存储或分发任何媒体内容。

有关全面的法律信息，包括我们的完整免责声明、第三方扩展政策以及 DMCA/版权信息，请访问我们的[法律与免责声明页面](https://nuvioapp.space/legal)。

## 构建技术

- Kotlin 多平台
- Compose 多平台
- Kotlin
- AndroidX Media3
- AVFoundation 及原生 iOS 集成

## Star 历史

<a href="https://www.star-history.com/#NuvioMedia/NuvioMobile&type=date&legend=top-left">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&theme=dark&legend=top-left" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=NuvioMedia/NuvioMobile&type=date&legend=top-left" />
 </picture>
</a>

<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[contributors-url]: https://github.com/NuvioMedia/NuvioMobile/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[forks-url]: https://github.com/NuvioMedia/NuvioMobile/network/members
[stars-shield]: https://img.shields.io/github/stars/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[stars-url]: https://github.com/NuvioMedia/NuvioMobile/stargazers
[issues-shield]: https://img.shields.io/github/issues/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[issues-url]: https://github.com/NuvioMedia/NuvioMobile/issues
[license-shield]: https://img.shields.io/github/license/NuvioMedia/NuvioMobile.svg?style=for-the-badge
[license-url]: https://github.com/NuvioMedia/NuvioMobile/blob/main/LICENSE


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-22

---