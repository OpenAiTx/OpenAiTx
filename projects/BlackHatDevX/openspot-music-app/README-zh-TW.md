<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

# OpenSpot 音樂 🎶

<p align="center">
 <img width="100" alt="OpenSpot Logo" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">您的無限音樂之門 - 跨平台音樂串流</h3>

<p align="center">
  <strong>在所有裝置上免費串流與下載高品質音樂，無廣告、無需登入。</strong>
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

## 📱📺 兩大精彩應用，一個倉庫

本倉庫包含**兩套完整的音樂串流應用程式**：

### 🎵 **OpenSpot Mobile**（React Native + Expo）
- **平台**：Android、iOS
- **位置**：`openspot-music-mobile/`
- **特點**：原生行動體驗，支援離線下載、背景播放和狀態持久化

### 🖥️ **OpenSpot Desktop**（Electron + React）
- **平台**：macOS、Windows、Linux
- **位置**：`openspot-music-electron/`
- **特點**：桌面優化介面，支援全域音訊控制、視窗管理和本地儲存

---

### 📢 加入我們的 Telegram 頻道

在官方 Openspot Telegram 頻道隨時掌握**版本釋出**與**重要公告**。

[![Join us on Telegram](https://img.shields.io/badge/Join%20Us%20on-Telegram-2CA5E0?style=for-the-badge&logo=telegram&logoColor=white)](https://t.me/openspot_music)


---


## 📱 行動應用程式（React Native + Expo）

### 截圖

![WhatsApp Image 2025-07-26 at 00 52 14](https://github.com/user-attachments/assets/cc7b262d-ccfe-4899-bd86-56d0e3e90be7)



### 下載連結

- **Android APK**：[OpenSpot-2.0.3-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.3/OpenSpot-2.0.3-release.apk)
- **iOS**：徵求維護者

### 開發環境設置


```bash
cd openspot-music-app
cd openspot-music-mobile/
npm install
npx expo start
```
### 建置生產環境


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

## 🖥️ 桌面應用程式（Electron + React）

### 截圖

![macOS 應用程式](https://github.com/user-attachments/assets/1cb18d3f-4986-4eb2-9cd2-1b606fbf31db)

### 下載連結

- **macOS DMG**：[OpenSpot.Music-2.0.2-arm64.zip](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64-mac.zip)
- 如果安裝後遇到應用程式已損毀的問題，請執行此操作。
  ```bash
  xattr -rd com.apple.quarantine /Applications/OpenSpot\ Music.app
- **Windows EXE**：即將推出！
- **Linux DEB**：即將推出！

### 開發環境設置

```bash
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```

### 進行生產環境建置

```bash
cd openspot-music-app/
cd openspot-music-electron/
npm run build
npm run electron-pack
```

---

## ✨ 主要功能（兩個應用程式皆有）

- **🎵 高品質串流**：以最佳音質收聽您喜愛的曲目
- **💾 離線下載**：將音樂直接儲存到您的裝置以供離線聆聽
- **❤️ 喜愛與收藏**：透過點讚歌曲建立個人收藏
- **🔄 背景播放**：使用其他應用時也可繼續聆聽
- **🚫 無需登入**：立即開始！不需帳號或註冊
- **💾 狀態持久保存**：您喜愛的歌曲與最近播放曲目在重啟應用後仍會保存
- **🎨 精美介面**：為各平台設計的簡潔現代介面
- **🆓 完全免費且無廣告**：享受無間斷音樂，無需付費亦無廣告

---


## 💻 技術棧

### 行動應用
- **框架**：[React Native](https://reactnative.dev/) 與 [Expo](https://expo.dev/)
- **導覽**：[Expo Router](https://expo.github.io/router/)
- **音訊**：[Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **建構**：[EAS Build](https://docs.expo.dev/build/introduction/)
- **位置獲取**：[IPinfo API](https://github.com/ipinfo)

### 桌面應用
- **框架**：[Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **UI**：[Material-UI](https://mui.com/)
- **狀態管理**：React Context + useReducer
- **儲存**：[electron-store](https://github.com/sindresorhus/electron-store)
- **建構**：[electron-builder](https://www.electron.build/)

### 共用
- **語言**：[TypeScript](https://www.typescriptlang.org/)
- **套件管理**：npm/yarn

---

### 環境設定

本專案需要一個環境變數才能正確運作。

- 範本已提供於 [`.env.template`](https://github.com/BlackHatDevX/openspot-music-app/blob/main/openspot-mobile/.env.template) 檔案中。
- 完成 `.env` 檔所需的**值**已在我們**官方 Telegram 頻道**的**置頂訊息**中分享：[ @openspot_music](https://t.me/openspot_music)。


---

## 🚀 快速開始

### 用於行動開發
```bash
```
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-mobile/
npm install
npx expo start
```

### 桌面端開發
```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```

---

## 🤝 貢獻指南

我們歡迎對這兩個應用程式的貢獻！
## 📞 社群與支援

- **Telegram**: [Openspot Music](https://telegram.dog/Openspot_Music)
- **問題回報**: [GitHub Issues](https://github.com/BlackHatDevX/openspot-music-app/issues)

## 👤 作者與聯絡方式

**Jash Gro**

- **LinkedIn**: [https://linkedin.com/in/jash-gro/](https://linkedin.com/in/jash-gro/)
- **作品集**: [https://bit.ly/jashgro](https://bit.ly/jashgro)
- **Telegram**: [https://telegram.dog/deveIoper_x](https://telegram.dog/deveIoper_x)
- **GitHub**: [https://github.com/BlackHatDevX](https://github.com/BlackHatDevX)

## 📄 授權條款

本專案為開源，並採用 MIT 授權條款。詳情請參閱 `LICENSE` 檔案。

---

<p align="center">
  <strong>⭐ 如果你喜歡這個專案，請給我們一顆星！⭐</strong>
  <br />
  <em>您的支持能幫助我們繼續為大家開發優秀的免費音樂應用程式。</em>
</p> 
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---