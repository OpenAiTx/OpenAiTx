# Tail Tray
Plasmaデスクトップ用のTailscaleトレイメニューとUI

**免責事項** 私はTailscale Inc.とは一切関係がありません。

これは個人プロジェクトであり、Tailscale Inc.のいかなる形での支持も受けていません。

### 機能
- [X] トレイからTailscale接続を制御
- [X] IPアドレスの表示
- [X] デバイスの現在の接続状態の表示
- [X] ネットワークとネットワーク状態の概要
- [X] Tailscaleの出口ノードの設定と変更
- [X] 適切なマルチアカウント処理
- [X] Mullvad出口ノード対応
- [X] Tailドライブサポート - davfs2対応 + davfs2設定やマウントの追加支援
- [X] トレイメニューからTailnet上の任意のデバイスへファイル送信
- [X] Tailnet上の任意のデバイスからファイル受信の通知および事前定義されたディスク上の場所への保存
- [X] 主要ディストリビューション向けのプリビルドバイナリと実験的なWindowsサポート

### ライセンス
GNU一般公衆利用許諾契約書 v3.0 - 詳細は[LICENSE](LICENSE)参照

### インストール
現状、最も簡単かつ確実なインストール方法はソースからビルドすることです。
その方法については以下のGetting startedセクションを参照してください。

### 前提条件
* Tailscaleがインストールされ実行中であること - https://tailscale.com 
* davfs2がインストールされ設定済みであること（Tailドライブを使用する場合やアクセスする場合。Tail Trayはこれの自動設定も支援します） - https://wiki.archlinux.org/title/Davfs2


### 対応アーキテクチャ
* x86_64
* ARM64
* QT 6がサポートし、このプロジェクトをビルドでき、かつTailscaleが動作するその他のアーキテクチャ

### Getting started

### プリビルドパッケージ
 * [Debian / Ubuntu / Mint ベースのディストリビューション](https://github.com/SneWs/tail-tray/releases)
 * [OpenSUSE & Fedora RPM](https://software.opensuse.org/download.html?project=home%3Aayankov&package=tail-tray)
 * [NixOS](/docs/nix-os.md)
 * [Windows（実験的！最新の不安定版のみ、署名なし）](https://github.com/SneWs/tail-tray/releases/download/latest/Tail-Tray-Windows.zip)

### ソースからのビルドとインストール
 * [Linuxでのビルド](/docs/build-from-src.md)
 * [Windowsでのビルド](/docs/build-from-src-windows.md)

### スクリプト可能なアクション
スクリプト可能なアクションの書き方と使用方法については、[Scriptable actions ガイド](https://raw.githubusercontent.com/SneWs/tail-tray/master/docs/scriptable-actions.md)をご覧ください。

### 参加とバグ報告
* このプロジェクトの開発に参加したい場合は、リポジトリをフォークしてプルリクエストを送ってください。
* バグは誰にでもあります… 問題タブにイシューを作成してください。一緒に解決しましょう。

### スクリーンショット
![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/launcher.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/connected-tray.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/disconnected-tray.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/settings-ui.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/network-status.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/file-sharing.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/devices-ui.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/ui-settings.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives01.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives02.png)

![Screenshot](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives03.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---