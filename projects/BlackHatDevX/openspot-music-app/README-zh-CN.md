<translate-content># OpenSpot 音乐 🎶

<p align="center">
 <img width="100" alt="OpenSpot Logo" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">通向无限音乐的门户 - 跨平台音乐流媒体</h3>

<p align="center">
  <strong>免费在所有设备上流式传输和下载高质量音乐，无广告，无需登录。</strong>
</p>

<p align="center">
  <a href="https://github.com/BlackHatDevX/openspot-music-app/stargazers">
    <img src="https://img.shields.io/github/stars/BlackHatDevX/openspot-music-app?style=for-the-badge&color=ffd700" alt="Stars">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/network/members">
    <img src="https://img.shields.io/github/forks/BlackHatDevX/openspot-music-app?style=for-the-badge&color=84b4a3" alt="Forks">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/issues">
    <img src="https://img.shields.io/github/issues/BlackHatDevX/openspot-music-app?style=for-the-badge&color=f38ba8" alt="Issues">
  </a>
</p>

---

## 📱📺 两个惊艳应用，一个代码库

本代码库包含 **两个完整的音乐流媒体应用**：

### 🎵 **OpenSpot 移动版** (React Native + Expo)
- **平台**：Android，iOS
- **位置**：`openspot-music-mobile/`
- **功能**：原生移动体验，支持离线下载、后台播放及持久状态

### 🖥️ **OpenSpot 桌面版** (Electron + React)
- **平台**：macOS，Windows，Linux
- **位置**：`openspot-music-electron/`
- **功能**：桌面优化界面，具备全局音频控制、窗口管理和本地存储

---

## ✨ 主要功能（两个应用均支持）

- **🎵 高质量流媒体**：以最佳音质聆听您喜爱的曲目
- **💾 离线下载**：直接保存音乐到设备，随时离线收听
- **❤️ 收藏与点赞**：通过点赞歌曲构建您的个人收藏
- **🔄 后台播放**：在使用其他应用时继续聆听
- **🚫 无需登录**：立即使用！无需账户或注册
- **💾 持久状态**：您点赞的歌曲和最近播放的曲目会在应用重启后保存
- **🎨 美观界面**：针对各平台设计的简洁现代界面
- **🆓 完全免费且无广告**：享受无中断音乐，无任何费用或广告

---

## 📱 移动应用（React Native + Expo）

### 截图

![Android App](https://github.com/user-attachments/assets/5a48d1e1-c862-4cea-9d0a-a29606ac5b74)

### 下载链接

- **Android APK**：[OpenSpot-2.0.2-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot-2.0.2-release.apk)
- **iOS**：即将推出（TestFlight）

### 开发环境搭建

```bash
cd openspot-music-app
cd openspot-music-mobile/
npm install
npx expo start
```
### 生产构建


```bash
cd openspot-music-app/

# Development Build
eas build --platform android --profile development

# Preview Build (APK)
eas build --platform android --profile preview

# Production Build
eas build --platform android --profile production
```
---

## 🖥️ 桌面应用（Electron + React）

### 截图

![macOS 应用](https://github.com/user-attachments/assets/1cb18d3f-4986-4eb2-9cd2-1b606fbf31db)

### 下载链接

- **macOS DMG**：[OpenSpot.Music-2.0.2-arm64.dmg](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64.dmg)
- **Windows EXE**：敬请期待！
- **Linux DEB**：敬请期待！

### 开发环境配置


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
### 生产环境构建


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm run build
npm run electron-pack
```
---


## 💻 技术栈

### 移动应用
- **框架**: [React Native](https://reactnative.dev/) 结合 [Expo](https://expo.dev/)
- **导航**: [Expo Router](https://expo.github.io/router/)
- **音频**: [Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **构建**: [EAS Build](https://docs.expo.dev/build/introduction/)

### 桌面应用
- **框架**: [Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **界面**: [Material-UI](https://mui.com/)
- **状态管理**: React Context + useReducer
- **存储**: [electron-store](https://github.com/sindresorhus/electron-store)
- **构建**: [electron-builder](https://www.electron.build/)

### 共享部分
- **语言**: [TypeScript](https://www.typescriptlang.org/)
- **包管理器**: npm/yarn

---

## 🚀 快速开始

### 移动开发使用</translate-content>

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-mobile/
npm install
npx expo start
```
### 用于桌面开发

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
---

## 🤝 贡献

我们欢迎对两个应用程序的贡献！
## 📞 社区与支持

- **Telegram**: [Openspot Music](https://telegram.dog/Openspot_Music)
- **问题反馈**: [GitHub Issues](https://github.com/BlackHatDevX/openspot-music-app/issues)

## 👤 作者与联系方式

**Jash Gro**

- **LinkedIn**: [https://linkedin.com/in/jash-gro/](https://linkedin.com/in/jash-gro/)
- **作品集**: [https://bit.ly/jashgro](https://bit.ly/jashgro)
- **Telegram**: [https://telegram.dog/deveIoper_x](https://telegram.dog/deveIoper_x)
- **GitHub**: [https://github.com/BlackHatDevX](https://github.com/BlackHatDevX)

## 📄 许可证

本项目是开源的，采用 MIT 许可证。更多信息请参见 `LICENSE` 文件。

---

<p align="center">
  <strong>⭐ 如果您喜欢这个项目，请给它点个星！⭐</strong>
  <br />
  <em>您的支持帮助我们继续为大家开发出色的免费音乐应用。</em>
</p> 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---