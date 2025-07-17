<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

# OpenSpot Music 🎶

<p align="center">
 <img width="100" alt="OpenSpot Logo" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">Your Gateway to Limitless Music - Cross-Platform Music Streaming</h3>

<p align="center">
  <strong>Stream and download high-quality music for free across all your devices, with no ads and no login required.</strong>
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

## 📱📺 Two Amazing Apps, One Repository

This repository contains **two complete music streaming applications**:

### 🎵 **OpenSpot Mobile** (React Native + Expo)
- **Platforms**: Android, iOS
- **Location**: `openspot-music-mobile/`
- **Features**: Native mobile experience with offline downloads, background playback, and persistent state

### 🖥️ **OpenSpot Desktop** (Electron + React)
- **Platforms**: macOS, Windows, Linux
- **Location**: `openspot-music-electron/`
- **Features**: Desktop-optimized interface with global audio controls, window management, and local storage

---

## ✨ Key Features (Both Apps)

- **🎵 High-Quality Streaming**: Listen to your favorite tracks in the best possible quality
- **💾 Offline Downloads**: Save music directly to your device for offline listening
- **❤️ Like & Collect**: Build your personal collection by liking songs
- **🔄 Background Playback**: Continue listening while using other apps
- **🚫 No Login Required**: Jump right in! No accounts or sign-ups needed
- **💾 Persistent State**: Your liked songs and recently played tracks are saved across app restarts
- **🎨 Beautiful UI**: Clean, modern interface designed for each platform
- **🆓 Completely Free & Ad-Free**: Enjoy uninterrupted music without any cost or advertisements

---

## 📱 Mobile App (React Native + Expo)

### Screenshots

![Android App](https://github.com/user-attachments/assets/5a48d1e1-c862-4cea-9d0a-a29606ac5b74)

### Download Links

- **Android APK**: [OpenSpot-2.0.2-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot-2.0.2-release.apk)
- **iOS**: Coming Soon (TestFlight)

### Development Setup


```bash
cd openspot-music-app
cd openspot-music-mobile/
npm install
npx expo start
```
### Build for Production


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

## 🖥️ Desktop App (Electron + React)

### Screenshots

![macOS App](https://github.com/user-attachments/assets/1cb18d3f-4986-4eb2-9cd2-1b606fbf31db)

### Download Links

- **macOS DMG**: [OpenSpot.Music-2.0.2-arm64.dmg](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64.dmg)
- **Windows EXE**: Coming Soon!
- **Linux DEB**: Coming Soon!

### Development Setup


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
### Build for Production


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm run build
npm run electron-pack
```
---


## 💻 Tech Stack

### Mobile App
- **Framework**: [React Native](https://reactnative.dev/) with [Expo](https://expo.dev/)
- **Navigation**: [Expo Router](https://expo.github.io/router/)
- **Audio**: [Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **Build**: [EAS Build](https://docs.expo.dev/build/introduction/)

### Desktop App
- **Framework**: [Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **UI**: [Material-UI](https://mui.com/)
- **State**: React Context + useReducer
- **Storage**: [electron-store](https://github.com/sindresorhus/electron-store)
- **Build**: [electron-builder](https://www.electron.build/)

### Shared
- **Language**: [TypeScript](https://www.typescriptlang.org/)
- **Package Manager**: npm/yarn

---

## 🚀 Quick Start

### For Mobile Development

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-mobile/
npm install
npx expo start
```
### For Desktop Development

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
---

## 🤝 Contributing

We welcome contributions to both apps!
## 📞 Community & Support

- **Telegram**: [Openspot Music](https://telegram.dog/Openspot_Music)
- **Issues**: [GitHub Issues](https://github.com/BlackHatDevX/openspot-music-app/issues)

## 👤 Author & Contact

**Jash Gro**

- **LinkedIn**: [https://linkedin.com/in/jash-gro/](https://linkedin.com/in/jash-gro/)
- **Portfolio**: [https://bit.ly/jashgro](https://bit.ly/jashgro)
- **Telegram**: [https://telegram.dog/deveIoper_x](https://telegram.dog/deveIoper_x)
- **GitHub**: [https://github.com/BlackHatDevX](https://github.com/BlackHatDevX)

## 📄 License

This project is open-source and licensed under the MIT License. See the `LICENSE` file for more information.

---

<p align="center">
  <strong>⭐ If you like this project, please give it a star! ⭐</strong>
  <br />
  <em>Your support helps us continue developing amazing free music apps for everyone.</em>
</p> 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---