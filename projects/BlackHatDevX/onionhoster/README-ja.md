<details align="right">
<summary>🌐 言語</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **究極のTor隠しサービスホスティングツール** - 数分でダークウェブにウェブプロジェクトをデプロイ！

[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

---

## 🚀 OnionHosterとは？

OnionHosterは強力なクロスプラットフォーム対応のbashスクリプトで、どんなウェブプロジェクトもワンコマンドでTor隠しサービスに変換します。Next.jsアプリ、Flaskバックエンド、静的ウェブサイトなど、複雑なTorの設定はすべて自動で処理します。

### ✨ OnionHosterを選ぶ理由

- **🔧 設定不要** - どんなウェブプロジェクトでもすぐに動作
- **🌍 クロスプラットフォーム** - Linux、macOS、主要ディストリビューション対応
- **⚡ ワンクリックセットアップ** - 2分以内で隠しサービスを構築
- **🔄 自動アップデート** - 組み込みのアップデートチェッカーで常に最新
- **💾 バックアップ＆復元** - オニオンアドレスを絶対に失わない
- **🎯 プロ仕様UI** - 直感的なメニューと美しいカラーインターフェース

---
## プレビュー

https://github.com/user-attachments/assets/b8fe44e8-2b1f-4fdc-bb52-7c4a5ee2c67e


# ⚠️ 警告: OnionHosterは魔法の匿名化ツールではありません — ベストプラクティスを守らないと匿名性が失われるリスクがあります

**システムの強化**

* サービスはVMやコンテナ内で実行し分離を行うこと。
* OSおよびパッケージは常に最新に保つこと。
* 不要なサービスやポートは無効化し、Torトラフィックのみが出入りするようにすること。


**OpSecの実践**

* 個人アカウントや活動に同じマシンを使用しないこと。
* 識別可能なメタデータ（ファイル名、ヘッダー、エラーメッセージ）を公開しないようにすること。
* ログに注意すること — 何をログに記録するか、どのくらいの期間保持するか、情報が漏れないか。

**ネットワーク衛生**

* 隠しサービスをクリアネットのIDやドメインとブリッジしないこと。
* Torの外部に誤って情報が漏れないようにファイアウォールを使用すること。
* 追加の隔離のためにリバースプロキシを検討すること。

**テストと監視**

* torsocksまたはTorブラウザを使用して、サービスが`.onion`アドレス経由のみでアクセス可能か確認すること。
* 漏洩がないか定期的にテストすること（例：アプリがクリアネットからの取得を試みていないか）。

**ユースケースの認識**

* 趣味・テスト・教育目的の場合：上記で通常は十分。
* 高リスクの実際の匿名性が必要な場合（ジャーナリスト、内部告発者、活動家）：単一のミスが匿名性を失わせるため、より深い運用セキュリティと脅威モデリングが必要。

---
## 🎯 最適対象

- **開発者** Tor上でアプリをテストしたい方
- **プライバシー擁護者** 匿名サービスをホストする方
- **研究者** ダークウェブ技術を研究する方
- **企業** 匿名ホスティングソリューションを必要とする方
- **ホビイスト** Torネットワークを探求する方

---

## 🚀 クイックスタート

### 前提条件
- rootまたはsudoアクセス
- インターネット接続
- 任意のウェブプロジェクト（HTML、Next.js、Flaskなど）


### インストールと使用方法

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```
**以上です！** 🎉

完全なOnionHosterプロジェクトを入手できます：
- メインの`onionhoster.sh`スクリプト
- ホスティング用のプロフェッショナルな`index.html`テンプレート
- すべてのドキュメントと例

スクリプトは自動的に：
- あなたのオペレーティングシステムを検出
- 必要な依存関係（Tor、Apacheなど）をインストール
- Torサービスを設定
- 直感的なメニューを表示

---

## 🎮 機能概要

### 🌐 ホスティングオプション
- **静的HTML** - 任意の`index.html`ファイルをホスト
- **ポートフォワーディング** - 任意のローカルアプリケーションポートへ転送
- **動的アプリ** - Next.js、Flask、Node.jsなどをサポート

### 🛠️ 管理ツール
- **サービス制御** - 隠れサービスの開始、停止、管理
- **バックアップ＆復元** - オニオンドメインの安全なバックアップと復元
- **URLリフレッシュ** - 必要に応じて新しいオニオンアドレスを生成
- **ステータス監視** - サービスの健康状態とステータスを確認

### 🔄 スマートアップデート
- **自動検出** - 最新バージョンを自動で検出
- **ワンクリックアップデート** - メニューオプション1つで更新
- **安全なアップデート** - 設定を失うリスクなし

---

## 📱 対応オペレーティングシステム

| OS | パッケージマネージャー | ステータス |
|----|----------------|---------|

| **Ubuntu/Debian** | `apt-get` | ✅ 完全サポート |
| **CentOS/RHEL** | `yum` | ✅ 完全サポート |
| **Fedora** | `dnf` | ✅ 完全サポート |
| **Arch Linux** | `pacman` | ✅ 完全サポート |
| **macOS** | `brew` | ✅ 完全サポート |

---

## 🎯 利用ケース

### 🏠 個人プロジェクト
- ポートフォリオを匿名でホストする
- ウェブアプリケーションをプライベートにテストする
- 身元を明かさずにコンテンツを共有する

### 🏢 ビジネスアプリケーション
- 匿名の顧客サポートポータル
- 安全な社内コミュニケーションシステム
- プライバシー重視のビジネスウェブサイト

### 🔬 研究開発
- ダークウェブ技術の研究
- プライバシーツールの開発
- 匿名サービスのテスト

---

## 📖 詳細な使い方

### メインメニューオプション

1. **index.htmlをホスト** - 静的HTMLファイルを配信
2. **アプリケーションポートへ転送** - 任意のローカルサービスにプロキシ
3. **torドメインのバックアップ** - オニオン設定を保存
4. **torドメインの復元** - バックアップから復元
5. **現在のtorドメインを表示** - アクティブなオニオンアドレスを見る
6. **torドメインを更新** - 新しいオニオンアドレスを生成
7. **アップデートを確認** - 最新バージョンに更新
8. **ウェブサーバーステータス** - サービスの状態を監視
9. **OnionHosterについて** - バージョンおよび機能情報

### 例のワークフロー

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 高度な設定

### カスタムポートフォワーディング
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### バックアップ管理
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ セキュリティ機能

- **自動Tor設定** - 初期設定から安全なデフォルト
- **適切なファイル権限** - 安全なファイル所有権とアクセス
- **サービスの分離** - 各隠しサービスは独立して動作
- **データのログ記録なし** - あなたの活動はプライベートに保たれます

---

## 🚨 重要な注意事項

- **ルートアクセスが必要** - Torサービスにはシステムレベルの設定が必要
- **Torネットワーク** - あなたのサービスはTorブラウザ経由でアクセス可能
- **オンリーンアドレス** - 各サービスにはユニークな`.onion`アドレスが付与されます
- **定期的なバックアップ** - Onionアドレスはリフレッシュ時に変わります

---

## 🤝 貢献について

貢献を歓迎します！以下のようなものが対象です：
- 🐛 バグ報告
- 💡 機能リクエスト
- 📝 ドキュメントの改善
- 🔧 コードの寄稿

**始め方：**
1. リポジトリをフォークする
2. 機能ブランチを作成する
3. 変更を加える
4. プルリクエストを送る

---

## 📄 ライセンス

このプロジェクトはMITライセンスのもとでライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

---

## 🙏 謝辞

- **Torプロジェクト** - 素晴らしい匿名ネットワークに感謝
- **オープンソースコミュニティ** - 継続的な改善に感謝
- **ユーザー＆貢献者** - フィードバックと提案に感謝

---

## 🔗 リンク

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Issues**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Discussions**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ このプロジェクトにスターを

OnionHosterが役立ったら、ぜひスターを付けてください！それが私たちの改善の励みとなり、他の人がこのツールを見つける助けになります。

---

**匿名で始める準備はできましたか？** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```
*匿名ホスティングへの旅は今始まります！* 🚀



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-20

---