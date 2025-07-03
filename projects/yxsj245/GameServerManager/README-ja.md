# プロジェクト紹介
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**ゲームサーバーのデプロイ、管理、保守をシンプルかつ効率的に**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 ドキュメントサイト](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 公式ウェブサイト](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQグループ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 プロジェクト概要

GameServerManager（略称GSManager）は、**Docker** 技術をベースとしたモダンなゲームサーバー管理プラットフォームであり、ゲームサーバーのデプロイ・管理・保守を簡素化するために設計されています。

### ✨ 主な特徴

- 🐳 **Docker コンテナ化** - 完全にDocker上で動作し、環境分離・高い互換性を実現
- 🎯 **ワンクリックデプロイ** - 人気ゲームの高速デプロイをサポート
- 🌐 **Web管理画面** - モダンなReactフロントエンド、直感的で使いやすい
- 🔧 **リアルタイムターミナル** - Webターミナル内蔵で、コマンドをリアルタイム実行可能
- 📊 **リソースモニタリング** - サーバーリソースの使用状況をリアルタイム監視
- 🔐 **権限管理** - 充実したユーザー認証と権限制御システム
- 🎮 **マルチゲーム対応** - Steamプラットフォームの多数の人気ゲームサーバーに対応
- 💾 **データ永続化** - ゲームデータや設定ファイルを外部マッピング、安全かつ信頼性高い

![コンテナ情報パネル](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 クイックスタート

### ワンクリックインストールスクリプト

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> debian（dockerは手動インストール）およびcentosは手動インストールを推奨、詳細はドキュメントサイト参照

---

## 🎮 サポート対象ゲーム

| ゲーム名 | 日本語名 | Steam ID | 匿名ダウンロード | ステータス |
|---------|--------|----------|----------|------|
| **人気ゲーム** | | | | |
| Palworld | パルワールド | 2394010 | ✅ | 🟢 完全対応 |
| Rust | ラスト | 258550 | ✅ | 🟢 完全対応 |
| Satisfactory | サティスファクトリー | 1690800 | ✅ | 🟢 完全対応 |
| Valheim | ヴァルヘイム | 896660 | ✅ | 🟢 完全対応 |
| 7 Days to Die | 7デイズ・トゥ・ダイ | 294420 | ✅ | 🟢 完全対応 |
| Project Zomboid | プロジェクトゾンボイド | 380870 | ✅ | 🟢 完全対応 |
| ARK: Survival Evolved | ARK:サバイバルエボルブド | 376030 | ✅ | 🟢 完全対応 |
| **FPS/TPS** | | | | |
| Left 4 Dead 2 | レフト4デッド2 | 222860 | ❌ | 🟡 正規版必要 |
| Team Fortress 2 | チームフォートレス2 | 232250 | ✅ | 🟢 完全対応 |
| Squad | スコード | 403240 | ✅ | 🟢 完全対応 |
| Insurgency: Sandstorm | インサージェンシー: サンドストーム | 581330 | ✅ | 🟢 完全対応 |
| Killing Floor 2 | キリングフロア2 | 232130 | ✅ | 🟢 完全対応 |
| Insurgency (2014) | インサージェンシー2 | 237410 | ✅ | 🟢 完全対応 |
| MORDHAU | モーダウ | 629800 | ✅ | 🟢 完全対応 |
| No More Room in Hell | ノーモアルームインヘル | 317670 | ✅ | 🟢 完全対応 |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 完全対応 |
| Half-Life | ハーフライフ | 90 | ✅ | 🟢 完全対応 |
| Half-Life 2: Deathmatch | ハーフライフ2：デスマッチ | 232370 | ✅ | 🟢 完全対応 |
| Operation: Harsh Doorstop | オペレーション：ハーシュドアストップ | 950900 | ✅ | 🟢 完全対応 |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 設定が必要 |
| **インディーゲーム** | | | | |
| Unturned | アンターンド | 1110390 | ✅ | 🟢 完全対応 |
| Don't Starve Together | ドント・スターブ・トゥギャザー | 343050 | ✅ | 🟡 設定が必要 |
| Last Oasis | ラストオアシス | 920720 | ✅ | 🟢 完全対応 |
| Hurtworld | ハートワールド | 405100 | ✅ | 🟢 完全対応 |
| Soulmask | ソウルマスク | 3017300 | ✅ | 🟢 完全対応 |
| **シミュレーション** | | | | |
| Euro Truck Simulator 2 | ユーロトラックシミュレーター2 | 1948160 | ✅ | 🟡 設定が必要 |
| American Truck Simulator | アメリカントラックシミュレーター | 2239530 | ✅ | 🟡 設定が必要 |
| ECO | エコサバイバル | 739590 | ✅ | 🟡 設定が必要 |

> 対応ゲームは随時追加中...

---

## 🏗️ 技術アーキテクチャ

### フロントエンド技術スタック
- **React 18** - モダンなフロントエンドフレームワーク
- **Ant Design** - エンタープライズ向けUIコンポーネントライブラリ
- **Monaco Editor** - コードエディタ
- **Xterm.js** - Webターミナルエミュレータ
- **Vite** - 高速ビルドツール

### バックエンド技術スタック
- **Python 3.13** - メイン開発言語
- **Flask** - Webフレームワーク
- **Gunicorn** - WSGIサーバー
- **Docker** - コンテナ化技術
- **SteamCMD** - Steamコマンドラインツール
- **Aria2** - マルチプロトコルダウンローダー

---

## 📁 プロジェクト構成

```
GameServerManager/
├── app/                    # フロントエンドアプリケーション
│   ├── src/               # Reactソースコード
│   ├── public/            # 静的リソース
│   └── package.json       # フロントエンド依存関係
├── server/                # バックエンドサービス
│   ├── api_server.py      # メインAPIサーバー
│   ├── game_installer.py  # ゲームインストーラー
│   ├── pty_manager.py     # ターミナルマネージャー
│   ├── auth_middleware.py # 認証ミドルウェア
│   └── installgame.json   # ゲーム設定ファイル
├── docker-compose.yml     # Dockerコンポーズファイル
├── Dockerfile            # Dockerイメージビルドファイル
└── README.md             # プロジェクト説明ドキュメント
```

---

## 🔧 設定説明

### ポート設定
- **5000** - Web管理画面
- **27015-27020** - Steamゲームサーバーポート範囲

### データボリュームマッピング
- `./game_data` → `/home/steam/games` - ゲームデータディレクトリ
- `./game_file` → `/home/steam/.config` - ゲーム設定ディレクトリ
- `./game_file` → `/home/steam/.local` - ゲームセーブディレクトリ

### 環境変数
- `TZ=Asia/Shanghai` - タイムゾーン設定
- `USE_GUNICORN=true` - Gunicornを有効化
- `GUNICORN_TIMEOUT=120` - リクエストタイムアウト時間
- `GUNICORN_PORT=5000` - サーバーポート

---

## 🤝 コントリビューションガイド

すべての形の貢献を歓迎します！

1. **Fork** 本プロジェクト
2. フィーチャーブランチを作成 (`git checkout -b feature/AmazingFeature`)
3. 変更をコミット (`git commit -m 'Add some AmazingFeature'`)
4. ブランチへプッシュ (`git push origin feature/AmazingFeature`)
5. **Pull Request** を作成

---

## 📞 サポートとフィードバック

- 🐛 **問題報告**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQグループ**：1040201322
- 📖 **詳細ドキュメント**：[ドキュメントを見る](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 オープンソースライセンス

本プロジェクトは [AGPL-3.0 license](LICENSE) オープンソースライセンスのもとで公開されています。

---

## 👨‍💻 作者について

このプロジェクトは **又菜又爱玩的小朱** によって単独で開発・管理されています。

もしこのプロジェクトが役に立ったら、ぜひ ⭐ Star をお願いします！

---

## 📈 プロジェクト統計

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 ゲームサーバー管理をもっとシンプルで楽しく！**

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---