
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=BlackHatDevX&project=openspot-music-app&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# OpenSpot 音乐 🎶

<p align="center">
 <img width="100" alt="OpenSpot Logo" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">您的无限音乐之门——跨平台音乐流媒体</h3>

<p align="center">
  <strong>在所有设备上免费播放和下载高质量音乐，无广告、无需登录。</strong>
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

## 📱📺 两款出色应用，一个仓库

本仓库包含**两个完整的音乐流媒体应用**：

### 🎵 **OpenSpot Mobile**（React Native + Expo）
- **平台**：Android，iOS
- **位置**：`openspot-music-mobile/`
- **功能**：原生移动体验，支持离线下载、后台播放和持久状态

### 🖥️ **OpenSpot Desktop**（Electron + React）
- **平台**：macOS，Windows，Linux
- **位置**：`openspot-music-electron/`
- **功能**：为桌面优化的界面，拥有全局音频控制、窗口管理和本地存储

---

### 📢 加入我们的 Telegram 频道

在官方 Openspot Telegram 频道获取**版本更新**和**重要公告**。

[![Join us on Telegram](https://img.shields.io/badge/Join%20Us%20on-Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/openspot_music)


---


## 📱 移动应用（React Native + Expo）

### 截图

![WhatsApp Image 2025-07-26 at 00 52 14](https://github.com/user-attachments/assets/cc7b262d-ccfe-4899-bd86-56d0e3e90be7)



### 下载链接

- **Android APK**：[OpenSpot-2.0.3-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.3/OpenSpot-2.0.3-release.apk)
- **iOS**：维护者招募中

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

- **macOS DMG**: [OpenSpot.Music-2.0.2-arm64.zip](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64-mac.zip)
- 如果安装后遇到应用损坏问题，请运行此命令。
  ```bash
  xattr -rd com.apple.quarantine /Applications/OpenSpot\ Music.app
- **Windows EXE**：即将推出！
- **Linux DEB**：即将推出！

### 开发环境设置

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

## ✨ 主要功能（两个应用均有）

- **🎵 高品质流媒体**：以最佳音质聆听你喜爱的曲目
- **💾 离线下载**：将音乐直接保存到你的设备，随时离线播放
- **❤️ 喜欢与收藏**：通过点赞歌曲建立你的个人收藏
- **🔄 后台播放**：在使用其他应用时继续收听
- **🚫 无需登录**：直接使用！无需账户或注册
- **💾 持久化状态**：你的喜欢歌曲和最近播放曲目在应用重启后依然保存
- **🎨 精美界面**：为每个平台设计的简洁现代界面
- **🆓 完全免费且无广告**：畅享无广告、无花费的音乐体验

---


## 💻 技术栈

### 移动端应用
- **框架**：[React Native](https://reactnative.dev/) 和 [Expo](https://expo.dev/)
- **导航**：[Expo Router](https://expo.github.io/router/)
- **音频**：[Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **构建**：[EAS Build](https://docs.expo.dev/build/introduction/)
- **定位获取**：[IPinfo API](https://github.com/ipinfo)

### 桌面端应用
- **框架**：[Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **界面**：[Material-UI](https://mui.com/)
- **状态管理**：React Context + useReducer
- **存储**：[electron-store](https://github.com/sindresorhus/electron-store)
- **构建**：[electron-builder](https://www.electron.build/)

### 共享
- **语言**：[TypeScript](https://www.typescriptlang.org/)
- **包管理器**：npm/yarn

---

### 环境配置

此项目需要一个环境变量才能正确运行。

- 模板已在 [`.env.template`](https://github.com/BlackHatDevX/openspot-music-app/blob/main/openspot-mobile/.env.template) 文件中提供。
- 完成你的 `.env` 文件所需的**值**已在我们**官方 Telegram 频道**的**置顶消息**中分享：[ @openspot_music](https://t.me/openspot_music)。


---

## 🚀 快速开始

### 用于移动端开发
```bash
```
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

## 🤝 参与贡献

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

本项目为开源项目，遵循 MIT 许可证。更多信息请参见 `LICENSE` 文件。

---

<p align="center">
  <strong>⭐ 如果你喜欢这个项目，请为它加一颗星！⭐</strong>
  <br />
  <em>你的支持帮助我们持续为所有人开发出色的免费音乐应用。</em>
</p> 
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---