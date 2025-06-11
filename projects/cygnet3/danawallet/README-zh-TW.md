# Dana wallet

Dana 是一款用於接受比特幣捐款的 Flutter 應用程式。它使用 silent payments，一種新的靜態支付協議，以在保護鏈上隱私的同時接收捐款。

## 試用 Dana wallet

**Dana wallet 目前仍處於實驗階段。我們建議使用 testnet/signet。如果您真的想在主網測試錢包，請僅使用您願意損失的資金。我們不對資金損失負責。**

我們正在考慮在應用程式更加穩定後，在流行的應用商店發布 Dana wallet。

在此期間，有兩種方式可以試用 Dana wallet：

- 從 [releases 頁面](https://github.com/cygnet3/danawallet/releases) 下載最新的 Dana wallet APK
- 使用我們的 [自建 F-Droid 軟體庫](https://fdroid.silentpayments.dev/fdroid/repo) 下載 Dana wallet

### 使用 F-Droid 下載

我們推薦使用 F-Droid 選項，因為它支持自動更新，且只需設定一次。

- 在您的 Android 手機上開啟 F-Droid
- 前往「設定」
- 在「我的應用程式」區段，點選「軟體庫」
- 點擊「+」圖示新增軟體庫
- 掃描本頁提供的 QR 碼：https://fdroid.silentpayments.dev/fdroid/repo

您已新增我們自建的軟體庫。要下載應用程式，請在 F-Droid 應用商店區搜尋「Dana Wallet」（您可能需要先透過向下滑動來刷新應用列表）。

## 從原始碼建置 Dana wallet

以下是從原始碼建置 Dana wallet 的說明。僅建議想協助 Dana wallet 開發者使用。

### 為 Linux（桌面）建置

為 Linux 建置應不需額外操作，只需執行

```
flutter run
```

這可能也適用於其他平台（macOS、Windows），但我們尚未測試。

### 為 Android 建置

為 Android 裝置建置需先進行準備工作，以產生該架構的二進位檔。

首先，您需要安裝 `cargo-ndk`。您可能還需新增所需的工具鏈：

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

安裝完成後，進入 rust 目錄並執行 `just build-android`。

```
cd rust
just build-android
```

如果未安裝 `just`，也可以複製 `justfile` 中的命令執行。
此步驟會產生二進位檔。

接著，連接您的手機並啟用除錯模式。
執行以下指令確認手機是否連接：

```
flutter devices
```

最後，為您的 Android 裝置建置並安裝應用程式：

```
flutter run
```

## 捐贈給 Dana

您可以使用以下地址捐贈給 Dana wallet：

> ₿donate@danawallet.app

或使用下列 silent payment 地址：

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---