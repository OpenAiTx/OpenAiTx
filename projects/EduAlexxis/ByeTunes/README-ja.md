# ByeTunes 🎵

**iTunesの同期にさよならを！**

ByeTunesはネイティブiOSアプリで、音楽（MP3、M4A、FLAC、WAV）や着信音をデバイスのメディアライブラリに直接注入できます—毎回PCと接続して同期する必要はありません。iOSのメディアデータベースと直接通信し、あなたの条件で音楽を管理する力を与えます。

## 機能

-   **直接音楽注入**：PCなしでApple Musicライブラリに曲を追加。
-   （現在無効）**着信音マネージャ**：カスタム着信音（`.m4r`および`.mp3`自動変換）を注入。
-   **プレイリスト対応**：即座にプレイリストを作成・管理。
-   **PC不要**（セットアップ後）：ペアリング後は自由！
-   **メタデータ編集**：iTunesやDeezerから自動取得。

## コンパイル手順

ByeTunesを自分でビルドするには、Xcodeが入ったMacが必要です。

### 前提条件

1.  **Xcode**：バージョン15以上推奨。
2.  **iOSデバイス**：iOS 16.0以降を実行。

### 外部ライブラリ

ByeTunesはiOS内部ファイルシステムと通信するために`idevice`（`libimobiledevice`の代替）に依存しています。**これらのファイルはライセンスやサイズの理由でこのリポジトリに含まれていません。**

アプリをコンパイルするには、以下の2つのファイルを入手して`MusicManager/`ディレクトリに置く必要があります：

1.  `libidevice_ffi.a`（静的ライブラリ）
2.  `idevice.h`（ヘッダーファイル）

ideviceはここから入手してコンパイルできます：[https://github.com/jkcoxson/idevice](https://github.com/jkcoxson/idevice)

*これらのファイルがないと、プロジェクトはコンパイルできません。*

### ビルド手順

1.  Rustをインストール：
    ```bash
    curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
    ```
2.  iosアーキテクチャを追加する:
    ```bash
    rustup target add aarch64-apple-ios
    ```
    
3.  まだインストールしていない場合は、Xcodeコマンドラインツールをインストールしてください:
    ```bash
    xcode-select --install
    ```

4.  リポジトリをクローンする:
    ```bash
    git clone https://github.com/jkcoxson/idevice
    ```

5.  デプロイメントターゲットを設定する:
    ```bash
    export IPHONEOS_DEPLOYMENT_TARGET=xx.x
    ```

6.  cargo buildを実行します:
    ```bash
    cargo build --release --package idevice-ffi --target aarch64-apple-ios
    ```
ideviceフォルダ内にある：idevice.h と libidevice_ffi.a を見つけます。これらをXcodeのプロジェクト内に移動し、**Bridging-Header.h** を必ず作成してください。  
Xcodeプロジェクト内で以下を追加してください：

 ```bash
    #import "idevice.h"
```

**Project Settings > Build Phases > Link Binary With Librariesで、libidevice_ffi.aがリストにあることを確認してください。**

## 使い方

1. **LocalDevVPN**:
    - App Store/Altstore PALからLocalDevVPNをダウンロード https://apps.apple.com/us/app/localdevvpn/id6755608044。
    - 開いてConnectをタップします。アプリ内でペアリングファイルをインポートするにはアクティブな接続が必要です。

2.  **ペアリング**:
    -   初回起動時に「Import Pairing File」画面が表示されます。
    -   `ペアリングファイル`を取得する必要があります。
    -   idevice_pairをダウンロードしてください https://github.com/jkcoxson/idevice_pair を参照。
    -   `ペアリングファイル`を生成します。
    -   コンピュータからエクスポートし、Airdropや保存でiPhoneに送ります。
    -   ByeTunesにインポートしてください。
      
3.  **音楽を追加**:
    -   「Add Songs」をタップし、Filesアプリからファイルを選択します。
    -   「Inject to Device」を押すと魔法が起こります。
      
4.  **着信音**:
    -   Ringtonesタブに移動し、ファイルを追加して注入してください！

## 注意事項

-   **署名済みアプリ**: サインサービス（Signulous、AltStoreなど）経由でインストールする場合、ファイルインポートがクラッシュせず正しく動作するように修正（`asCopy: true`）が含まれています。
-   **バックアップ**: データベース注入を行う前に音楽ライブラリのバックアップを取ることをお勧めします！

## サポート＆バグ報告

バグを見つけましたか？修正したいです！

1.  **問題報告**: [GitHub Issues](https://github.com/EduAlexxis/ByeTunes/issues)でチケットを開いてください。
2.  **コミュニティに参加**: [Discord](https://discord.gg/dDQ4P4SyKJ)でチャットしましょう。
3.  **デバッグログの添付**:
    *   注入失敗が発生した場合、設定内のdelte libraryの下にある**Debug Options**を使用してください。
    *   「Debug Logs」画面があり、アプリログをコピーできます。
    *   これらのログを問題報告に添付してください。問題解決がずっと早くなります！

---
*EduAlexxisによって❤️を込めて作成されました*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---