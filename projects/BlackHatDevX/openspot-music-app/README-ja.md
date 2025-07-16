<translate-content># OpenSpot Music 🎶

<p align="center">
 <img width="100" alt="OpenSpot ロゴ" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">無限の音楽へのゲートウェイ - クロスプラットフォーム音楽ストリーミング</h3>

<p align="center">
  <strong>広告なし、ログイン不要で、すべてのデバイスで高品質な音楽を無料でストリーミングおよびダウンロード。</strong>
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

## 📱📺 2つの素晴らしいアプリ、1つのリポジトリ

このリポジトリには**2つの完全な音楽ストリーミングアプリケーション**が含まれています：

### 🎵 **OpenSpot Mobile** (React Native + Expo)
- **対応プラットフォーム**: Android、iOS
- **場所**: `openspot-music-mobile/`
- **特徴**: オフラインダウンロード、バックグラウンド再生、永続的な状態管理を備えたネイティブモバイル体験

### 🖥️ **OpenSpot Desktop** (Electron + React)
- **対応プラットフォーム**: macOS、Windows、Linux
- **場所**: `openspot-music-electron/`
- **特徴**: グローバルオーディオコントロール、ウィンドウ管理、ローカルストレージを備えたデスクトップ最適化インターフェース

---

## ✨ 主な特徴（両アプリ共通）

- **🎵 高品質ストリーミング**: お気に入りのトラックを最高の品質で聴く
- **💾 オフラインダウンロード**: 音楽を直接デバイスに保存してオフライン再生
- **❤️ いいね＆コレクション**: 曲を「いいね」して個人コレクションを作成
- **🔄 バックグラウンド再生**: 他のアプリを使用中でも再生を継続
- **🚫 ログイン不要**: アカウントやサインアップなしで即利用可能
- **💾 永続的な状態**: いいねした曲や最近再生したトラックがアプリ再起動後も保存される
- **🎨 美しいUI**: 各プラットフォーム向けにデザインされたクリーンでモダンなインターフェース
- **🆓 完全無料＆広告なし**: 料金や広告なしで途切れない音楽を楽しめる

---

## 📱 モバイルアプリ (React Native + Expo)

### スクリーンショット

![Android アプリ](https://github.com/user-attachments/assets/5a48d1e1-c862-4cea-9d0a-a29606ac5b74)

### ダウンロードリンク

- **Android APK**: [OpenSpot-2.0.2-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot-2.0.2-release.apk)
- **iOS**: 近日公開予定（TestFlight）

### 開発環境セットアップ

```bash
cd openspot-music-app
cd openspot-music-mobile/
npm install
npx expo start
```
### 本番環境向けビルド


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

## 🖥️ デスクトップアプリ（Electron + React）

### スクリーンショット

![macOSアプリ](https://github.com/user-attachments/assets/1cb18d3f-4986-4eb2-9cd2-1b606fbf31db)

### ダウンロードリンク

- **macOS DMG**: [OpenSpot.Music-2.0.2-arm64.dmg](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64.dmg)
- **Windows EXE**: 近日公開予定！
- **Linux DEB**: 近日公開予定！

### 開発環境設定


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
### 本番用ビルド


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm run build
npm run electron-pack
```
---


## 💻 技術スタック

### モバイルアプリ
- **フレームワーク**: [React Native](https://reactnative.dev/) と [Expo](https://expo.dev/)
- **ナビゲーション**: [Expo Router](https://expo.github.io/router/)
- **オーディオ**: [Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **ビルド**: [EAS Build](https://docs.expo.dev/build/introduction/)

### デスクトップアプリ
- **フレームワーク**: [Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **UI**: [Material-UI](https://mui.com/)
- **状態管理**: React Context + useReducer
- **ストレージ**: [electron-store](https://github.com/sindresorhus/electron-store)
- **ビルド**: [electron-builder](https://www.electron.build/)

### 共通
- **言語**: [TypeScript](https://www.typescriptlang.org/)
- **パッケージマネージャー**: npm/yarn

---

## 🚀 クイックスタート

### モバイル開発用

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-mobile/
npm install
npx expo start
```
### デスクトップ開発向け

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
---

## 🤝 貢献について

両方のアプリへの貢献を歓迎します！
## 📞 コミュニティとサポート

- **Telegram**: [Openspot Music](https://telegram.dog/Openspot_Music)
- **Issues**: [GitHub Issues](https://github.com/BlackHatDevX/openspot-music-app/issues)

## 👤 作者と連絡先

**Jash Gro**

- **LinkedIn**: [https://linkedin.com/in/jash-gro/](https://linkedin.com/in/jash-gro/)
- **ポートフォリオ**: [https://bit.ly/jashgro](https://bit.ly/jashgro)
- **Telegram**: [https://telegram.dog/deveIoper_x](https://telegram.dog/deveIoper_x)
- **GitHub**: [https://github.com/BlackHatDevX](https://github.com/BlackHatDevX)

## 📄 ライセンス

このプロジェクトはオープンソースで、MITライセンスの下で提供されています。詳細は`LICENSE`ファイルをご覧ください。

---

<p align="center">
  <strong>⭐ このプロジェクトが気に入ったら、スターを付けてください！ ⭐</strong>
  <br />
  <em>皆さんのサポートが、素晴らしい無料音楽アプリの開発を続ける力になります。</em>
</p> 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---