# 🚀 MountMate

_外付けドライブを管理するためのシンプルなmacOSメニューバーアプリ。_

<p align="center">
  <img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/assets/icon.png" alt="MountMate Icon" width="100" height="100" style="border-radius: 22%; border: 0.5px solid rgba(0,0,0,0.1);" />
</p>

<p align="center">
  <a href="https://github.com/homielab/mountmate/releases">
    <img src="https://img.shields.io/github/v/release/homielab/mountmate?label=release&style=flat-square" />
  </a>
  <a href="https://github.com/homielab/mountmate">
    <img src="https://img.shields.io/github/downloads/homielab/mountmate/total?style=flat-square" />
  </a>
  <a href="https://brew.sh">
    <img src="https://img.shields.io/badge/homebrew-supported-blue?style=flat-square" />
  </a>
</p>

---

## ⚡️ クイックスタート

[Homebrew](https://brew.sh)からインストール:

```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
または[最新の .dmg をダウンロード](https://github.com/homielab/mountmate/releases)して、MountMate.app をアプリケーションフォルダにドラッグしてください。

## 🧩 MountMateとは？

MountMate は軽量な macOS メニューバーユーティリティで、**外付けドライブをワンクリックでマウント・アンマウント**できます。ターミナルもディスクユーティリティも不要、面倒な操作はありません。

騒音の大きい回転式HDDを扱う場合でも、ドライブがアクティブになるタイミングを細かく制御したい場合でも、MountMate はメニューバーからシンプルで実用的な解決策を提供します。

## 🧠 開発の経緯

私は4TBの外付けHDDをMac miniに24時間接続しています。回転式ドライブなので、macOS はちょっとした操作（Finderを開く、Spotlightを使うなど）だけでドライブを頻繁に回転させてしまいます。結果として：

- 不要な騒音
- システムの遅延
- エネルギーの無駄遣い

を招きました。

試したもの：

- ディスクユーティリティ — 遅くて使いにくい
- カスタムシェルスクリプト — 技術的すぎる
- 既存のサードパーティ製アプリ — 重すぎたり正しく動かなかったり

そこで **MountMate** を作りました。

## ✅ 機能

- 接続されている**外付けドライブ**を一覧表示
- どのドライブが**マウント済み**かを確認
- 任意のドライブをクリック一つで**マウント／アンマウント**
- 利用可能な**空き容量**をチェック
- **メニューバー**で静かに動作
- 完全ネイティブ — Electronや依存関係なし

## ✨ MountMateを使う理由

macOS はドライブを接続すると自動でマウントしますが、後で簡単に再マウントする方法はありません（ターミナルかディスクユーティリティを使わない限り）。MountMate は以下に最適です：

- 常に使わない外付けHDD
- バックアップ専用ドライブ
- 摩耗や騒音の軽減
- システムの応答性向上

## 🔐 プライベートで高速、安全

MountMate は**完全にオフライン**で動作し、macOS のネイティブAPIとコマンドラインツールを使います。以下を保証します：

- 何もトラッキングしません
- インターネット接続不要
- ファイルにアクセスしません
- ルート権限不要

一つの仕事をきちんとこなす、シンプルなユーティリティです。

## 🖼️ スクリーンショット

<img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light.png" width="300" /><img src="https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/dark.png" width="300" />

![フルスクリーンショット](https://raw.githubusercontent.com/homielab/mountmate/main/docs/screenshots/light-full.png)

## 🛠️ インストール方法

### 手動インストール

1. [最新の `.dmg` リリースをダウンロード](https://github.com/homielab/mountmate/releases)
2. `.dmg` ファイルを開く
3. `MountMate.app` を**アプリケーション**フォルダにドラッグ
4. インストーラのディスクイメージを取り出す
5. **アプリケーション**から MountMate を起動

### Homebrew でインストール

[Homebrew](https://brew.sh) がインストールされていれば、このリポジトリから直接 MountMate をインストールできます：
```bash
brew tap homielab/mountmate https://github.com/homielab/mountmate
brew install --cask mountmate
```
### macOSでの初回使用

- MountMateが未確認の開発元からのものであるという警告が表示された場合は、  
  **システム設定 → プライバシーとセキュリティ → それでも開く** に移動してください
- macOSがアプリを検証し、アップデートを受け取れるようにインターネットに接続されていることを確認してください

## 📫 フィードバックと貢献

MountMateは私個人のワークフローの問題を解決するために作られましたが、  
他の人のためにも改善したいと考えています。
[issueを開く](https://github.com/homielab/mountmate/issues)か改善案を気軽に提案してください！

## 🤝 サポート

MountMateが役に立ったと感じたら、開発支援を検討してください:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/homielab)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-14

---