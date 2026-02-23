# Chrome Debloat

Chromiumベースのブラウザ（Chrome、Brave、Edge）向けに、不要な機能、テレメトリー、不要なソフトウェアを無効化し、一部の利便性向上機能を有効化するポリシーを生成するツール。

## Features

- テレメトリーと使用状況レポートの無効化を試みる
- 不要な機能とプリインストールされた不要なソフトウェアを削除
- プロモーションコンテンツと不要なUI要素をブロック
- ブラウザの機能を維持しつつリソース使用量を削減
- 必須拡張機能を事前設定：
  - uBlock Origin
  - Cookie AutoDelete
  - Don't f*** with paste
  - I still don't care about cookies
  - SponsorBlock
  - BlockTube
  - BlankTab
  - Decentraleyes

### Supported Browsers

| ブラウザ | Windows | macOS | Linux |
|---------|---------|-------|-------|
| Google Chrome | ✅ | ✅ | ✅ |
| Microsoft Edge | ✅ | ✅ | ✅ |
| Brave | ✅ | ✅ | ✅ |

## Quick Start

### Windows
1.  ブラウザ用の `.reg` ファイルを [`generated/windows/`](./generated/windows/) からダウンロードします。
2.  ダウンロードした `.reg` ファイルを開き、Windowsレジストリに設定を追加します。
3.  ブラウザを再起動するか、`chrome://policy`（または `edge://policy`、`brave://policy`）にアクセスして「ポリシーを再読み込み」をクリックします。

### macOS
1.  ブラウザ用の `.mobileconfig` ファイルを [`generated/macos/`](./generated/macos/) からダウンロードします。
2.  ダウンロードした `.mobileconfig` ファイルを開き、プロファイルのインストールを開始します。
3.  「システム設定」>「プライバシーとセキュリティ」>「プロファイル」に移動し、新しいプロファイルを承認します。
4.  ブラウザを再起動するか、`chrome://policy`（または `edge://policy`、`brave://policy`）にアクセスして「ポリシーを再読み込み」をクリックします。
### Linux
1.  ブラウザ用の `.json` ファイルを [`generated/linux/`](./generated/linux/) からダウンロードします。
2.  ダウンロードしたファイルを正しいポリシーディレクトリに移動します（必要に応じて作成してください）：
    *   **Chrome:** `/etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `/etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `/etc/brave/policies/managed/brave.json`
    *   *注意: これを行うには `sudo` 権限が必要な場合があります。*
3.  ブラウザを再起動するか、`chrome://policy`（または `edge://policy`、`brave://policy`）にアクセスして「ポリシーの再読み込み」をクリックします。

## カスタム設定

ポリシーをカスタマイズしたい場合：

1. このリポジトリをクローンします
2. 依存関係をインストールします：

   ```bash
   uv sync
   ```
3. 必要に応じて `policies.yaml` を修正してください  
4. 新しい設定ファイルを生成します:
   ```bash
   uv run main.py
   ```
5. 生成されたファイルは `generated/` ディレクトリにあります


### ポリシーのアンインストール

**Windows:**
1.  このリポジトリの [`uninstall/windows/`](./uninstall/) ディレクトリに移動します。
2.  ブラウザに対応する `.reg` ファイル（例：`uninstall_chrome.reg`）を実行します。これによりインストール時に追加されたレジストリキーが削除されます。
3.  ブラウザを再起動するか、`chrome://policy`（または `edge://policy`、`brave://policy`）にアクセスして「ポリシーの再読み込み」をクリックします。

**macOS:**
1.  「システム設定」＞「プライバシーとセキュリティ」＞「プロファイル」に移動します。
2.  ブラウザに関連付けられたプロファイル（例：「Chrome Debloat Policies」）を選択します。
3.  「-」（マイナス）ボタンをクリックしてプロファイルを削除します。
4.  ブラウザを再起動するか、`chrome://policy`（または `edge://policy`、`brave://policy`）にアクセスして「ポリシーの再読み込み」をクリックします。

**Linux:**
1.  ブラウザ固有のディレクトリからポリシーの JSON ファイルを削除します（`sudo` 権限が必要な場合があります）：
    *   **Chrome:** `sudo rm /etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `sudo rm /etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `sudo rm /etc/brave/policies/managed/brave.json`
2.  ブラウザを再起動するか、`chrome://policy`（または `edge://policy`、`brave://policy`）にアクセスして「ポリシーの再読み込み」をクリックします。

## ポリシー ドキュメント

- [Chrome Enterprise ポリシー](https://chromeenterprise.google/policies/)
- [Brave ポリシー](https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy)
- [Microsoft Edge ポリシー](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies)

## ライセンス

[Apache 2.0](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---