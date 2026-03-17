# PrivacyFlip

**Androidデバイス向けの自動ロック/アンロックプライバシー制御 🔐📱✨**

**PrivacyFlip** は、ロック/アンロック状態に基づいてAndroidデバイスのプライバシー機能を自動管理します。デバイスをロックすると、**Wi-Fi**、**Bluetooth**、**モバイルデータ**、**位置情報**サービス、**NFC**、さらには**カメラ/マイクセンサー**を無効にできます。アンロック時には、必要な機能を賢く復元します。

**ShizukuまたはRootに対応** - お好みの権限方法を選択可能！

<div>
  <a href="https://f-droid.org/en/packages/io.github.dorumrr.privacyflip/" target="_blank" rel="noopener"><img height="50" src="https://f-droid.org/badge/get-it-on.png"></a> 
  <a href="https://apt.izzysoft.de/fdroid/index/apk/io.github.dorumrr.privacyflip" target="_blank" rel="noopener"><img height="50" src="https://gitlab.com/IzzyOnDroid/repo/-/raw/master/assets/IzzyOnDroid.png"></a> 
  <a href="https://www.buymeacoffee.com/ossdev"><img height="50" src="https://cdn.buymeacoffee.com/buttons/v2/arial-yellow.png" /></a>
</div>

## 📸 スクリーンショット

<div align="center">
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/1.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
  <img src="https://raw.githubusercontent.com/dorumrr/privacyFlip/main/fastlane/metadata/android/en-US/images/phoneScreenshots/2.png" alt="PrivacyFlip by Doru Moraru" width="300" style="margin: 10px; border: 1px solid #222222"/>
</div>

## 🔒 機能

### **自動プライバシー制御**
- **ロック検知**: 画面ロック時にプライバシー機能を即時無効化
- **アンロック検知**: 適切な認証を待つ（画面オンだけではない）
- **スマート復元**: アンロック時に再有効化する機能を設定可能

### **制御可能なプライバシー機能**
- 📶 **Wi-Fi** - 無線接続の無効化/有効化
- 📱 **Bluetooth** - Bluetoothラジオの制御
- 📡 **モバイルデータ** - 携帯データ接続の管理
- 📍 **位置情報サービス** - GPSおよび位置追跡の制御
- 📳 **NFC** - 近距離無線通信センサーの制御
- 📷 **カメラ** - カメラセンサーのプライバシー無効化/有効化（Android 12以上）
- 🎤 **マイク** - マイクセンサーのプライバシー無効化/有効化（Android 12以上）
- ✈️ **機内モード** - ロック時に機内モードを有効化（任意、全ラジオ無効化）
- 🔋 **バッテリーセーバー** - ロック時にバッテリーセーバーモードを有効化（任意）

### **高度な機能**
- **スマート無効化オプション**:
  - **「未使用/未接続の場合のみ」** - 使用中のWiFi、Bluetooth、または位置情報は無効化しない
  - **「既に有効の場合は無効化しない」** - 既にオンの機能を再有効化せず接続リセットを防止
  - **「手動設定の場合は無効化しない」** - ロック解除時に手動で有効化された保護モードを尊重

- **アプリ除外設定** - フォアグラウンド時に特定のアプリをプライバシー操作から除外
- **Samsung NFC 自動再試行** - SamsungペイメントフレームワークのNFCオーバーライド対策（Galaxy S、Note、Zシリーズ向けのオプトイン機能）
- **アクセシビリティサービス** - サイド/電源ボタン即時ロックの実験的サポート（オプトイン、アクセシビリティ権限が必要）
- **高度検出** - 多段階Bluetooth接続検出で不要なヘッドホン切断を防止

### **カスタマイズ可能なタイミング**
- **ロック遅延**: 0～60秒（細かく設定可能）、2分、または5分のいずれかでプライバシー動作が開始
- **解除遅延**: 0～60秒（細かく設定可能）、2分、または5分のいずれかで機能が復元
- **インスタントモード**: 遅延を0に設定して即時動作を実現
- **注意**: Androidの制限によりカメラとマイクはカスタム遅延を無視し即時起動

## 📱 要件

**最低限:** Android 7.0+（APIレベル24）
**カメラ/マイク機能:** Android 12+（APIレベル31）

**権限付与方法を選択してください:**

### **オプション1: Shizuku**（root不要！）
- **Shizuku**アプリがインストールされ起動していること
- **USBデバッグまたは無線ADBによるADB権限**
- **root不要** - ADBレベルの権限で動作

### **オプション2: Rootアクセス**（root端末推奨）
- Magisk、SuperSUなどによる**rootアクセス**
- UID 0権限で**最高のパフォーマンス**

### **オプション3: Dhizuku**（デバイスオーナー方式）
- **デバイスオーナー**または**プロファイルオーナー**権限
- **root不要**、初期設定後はADB不要
- **永続的な権限** - 再起動後も持続
- **推奨対象**: 企業端末、ワークプロファイル、プライバシー重視環境

### **オプション4: Sui**（両者の良いとこ取り）
- Magiskがインストールされた**root端末**
- **Sui Magisk** モジュールがインストール済み
- **最高のユーザー体験** - 許可プロンプトなし、自動起動

### **権限検出の優先順位**
1. **Sui** - root権限付きのShizuku APIを提供するMagiskモジュール（最高のUX）
2. **Root** - Magisk/SuperSUによる従来のrootアクセス
3. **Dhizuku** - デバイスオーナー方式（セットアップ後はrootやADB不要）
4. **Shizuku** - Shizukuアプリ経由のADB権限

## 🤝 貢献について

このアプリをより良くするためにご協力ください。どんな貢献も小さなものはありません！

### 貢献方法

1. **リポジトリをフォークする**
2. **機能ブランチを作成する** (`git checkout -b feature/amazing-feature`)
3. **変更を加える**
4. **変更をコミットする** (`git commit -m 'Add some amazing feature'`)
5. **ブランチにプッシュする** (`git push origin feature/amazing-feature`)
6. **プルリクエストを作成する**

すべての貢献を**大切に**し**感謝**しています！

## 📄 ライセンス

このプロジェクトはMITライセンスの下でライセンスされています - 詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## 💖 開発支援

PrivacyFlipはあなたのプライバシーを守ります。未来を守るために支援してください！

[![DONATE](https://img.shields.io/badge/DONATE-FFD700?style=for-the-badge&logoColor=white)](https://buymeacoffee.com/ossdev)

---

*明るい未来のための深夜作業*

作成者 Doru Moraru


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-17

---