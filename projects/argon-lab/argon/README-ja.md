<translate-content># Argon 🚀

**ML/AIワークフロー向けのGit風MongoDBブランチ管理**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Go](https://img.shields.io/badge/Go-1.24+-00ADD8?logo=go)](https://golang.org)
[![Python](https://img.shields.io/badge/Python-3.11+-3776AB?logo=python)](https://python.org)
[![MongoDB](https://img.shields.io/badge/MongoDB-7.0+-47A248?logo=mongodb)](https://mongodb.com)

> **🎉 今すぐ利用可能！** Argonはサブ500msの操作速度、MLネイティブ機能、GoとPythonのハイブリッドアーキテクチャを備えたエンタープライズ級MongoDBブランチ管理を提供します。

## Argonとは？

Argonは、ML/AIワークフローに最適化されたGit風のデータベース操作を提供するMongoDBブランチシステムです。データサイエンスチーム向けの一流サポートを備えた「MongoDB版Neon」と考えてください。

### 主な特徴

- **⚡ インスタントブランチ**：サイズに関わらず500ms未満でデータベースブランチを作成  
- **🔄 コピーオンライト**：完全コピーに比べ90%以上のストレージ節約を実現  
- **🧠 MLネイティブ**：MLflow、DVC、Weights & Biasesとの組み込み連携  
- **🌐 リアルタイム**：ライブ変更ストリームとWebSocketベースのダッシュボード  
- **☁️ マルチクラウド**：AWS S3、Google Cloud Storage、Azure Blob対応  
- **🔒 エンタープライズ**：認証、RBAC、監査ログ、コンプライアンス機能

## アーキテクチャ

Argonはパフォーマンスと開発者生産性の両方を最適化したハイブリッドアーキテクチャを採用しています：

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   CLI Tool      │    │  Web Dashboard  │    │ ML Integrations │
│   (Go Binary)   │    │   (Next.js)     │    │ (Python APIs)   │
└─────────────────┘    └─────────────────┘    └─────────────────┘
         │                       │                       │
         └───────────────────────┼───────────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Python API     │
                    │  (FastAPI)      │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │  Go Engine      │
                    │ (Performance)   │
                    └─────────────────┘
                                 │
                    ┌─────────────────┐
                    │    MongoDB      │
                    │ + Change Streams│
                    └─────────────────┘
```
<translate-content>
**パフォーマンスタイア（Go）**: 変更ストリーム、ブランチエンジン、CLI、ストレージ  
**生産性タイア（Python）**: Web API、ML統合、管理機能  

## クイックスタート  

### インストール  

お好みのインストール方法を選択してください:  

#### クイックインストール（ソースから）</translate-content>
```bash
# Clone and build latest version
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
sudo mv argon /usr/local/bin/
```
#### Homebrew（macOS/Linux）

```bash
brew install argon-lab/tap/argonctl
```
#### npm（クロスプラットフォーム）

```bash
npm install -g argonctl
```
#### 直接ダウンロード

```bash
# Linux (x64)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-linux-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Intel)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-amd64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/

# macOS (Apple Silicon)
curl -L https://github.com/argon-lab/argon/releases/latest/download/argon-darwin-arm64 -o argon
chmod +x argon && sudo mv argon /usr/local/bin/
```
#### ソースから

```bash
git clone https://github.com/argon-lab/argon.git
cd argon/cli
go build -o argon .
```
### インストールの確認</translate-content>

```bash
argon --version
# argon version 1.0.0
```
### 開発環境設定（コントリビューター）


```bash
# Clone the repository
git clone https://github.com/argon-lab/argon.git
cd argon

# Start the development environment
docker compose up -d

# Verify services are running
curl http://localhost:8080/health  # Go engine
curl http://localhost:3000/health  # Python API
```
### 基本的な使い方


```bash
# Verify installation
argon --version

# Get help
argon --help

# Create a new project (requires running services)
argon projects create --name my-ml-project --mongodb-uri mongodb://localhost:27017

# List your projects
argon projects list

# Note: Full functionality requires the Argon services to be running
# See Development Setup below for starting the complete system
```
<translate-content>
## 現在動作しているもの

✅ **CLI インストール** - `argon` コマンドをグローバルにインストール  
✅ **コアアーキテクチャ** - ハイブリッド Go+Python システム準備完了  
✅ **ストレージエンジン** - 42% 圧縮の S3 バックエンド  
✅ **ローカル開発** - 完全な Docker 環境  

## まもなく登場

✅ **Homebrew** - `brew install argon-lab/tap/argonctl`（現在稼働中！）  
✅ **npm パッケージ** - `npm install -g argonctl`（現在稼働中！）  
🚧 **ホステッドサービス** - 即時利用可能なクラウドホスト Argon  
🚧 **Web ダッシュボード** - ブランチ管理の可視化  
🚧 **ML 統合** - MLflow、DVC、Weights & Biases  

## 現在の状況

**CLI とコアシステムは本番稼働準備完了**。パッケージマネージャ配布とホステッドサービスは一般公開に向けて準備中です。

## パフォーマンス目標

| 指標 | 目標 | 現状 |
|--------|--------|----------------|
| ブランチ作成 | <500ms | 🟢 実装済み |
| 変更処理 | 10,000+ ops/sec | 🟢 実装済み |
| ストレージ効率 | 40%以上圧縮 | 🟢 達成 (42.40%) |
| CLI 起動時間 | <50ms | 🟢 達成 |

## ユースケース

### データサイエンスチーム</translate-content>
```python
# In Jupyter notebook
import argon

# Create experiment branch
argon.branch.create("model-v2-experiment")

# Train model with versioned data
model = train_model(argon.data.get_collection("training_data"))

# Track experiment metadata
argon.experiment.log(model_accuracy=0.95, dataset_version="v2.1")

# Merge successful experiment
argon.branch.merge("model-v2-experiment", "main")
```
### 開発チーム

```bash
# Create feature branch with production data copy
argon branch create feature-new-analytics --from production

# Develop and test against real data
# ... make database schema changes ...

# Review changes before merge
argon diff main..feature-new-analytics

# Deploy to production
argon branch merge feature-new-analytics main
```
## 貢献について

私たちは貢献を歓迎します！これはコミュニティのために構築されたオープンソースプロジェクトです。

### 開発ワークフロー

1. **リポジトリをフォークする**
2. **開発環境をセットアップする**: `docker-compose up -d`
3. **適切なサービスで変更を加える**:
   - Goエンジン: `services/engine/`
   - Python API: `services/api/`
   - Webダッシュボード: `services/web/`
4. **変更をテストする**: テストスイートを実行する
5. **プルリクエストを提出する**

### プロジェクト構成


```
argon/
├── services/
│   ├── engine/          # Go performance engine
│   ├── api/             # Python FastAPI service
│   └── web/             # Next.js web dashboard
├── docs/                # Documentation
├── examples/            # Example usage and tutorials
├── scripts/             # Development and deployment scripts
└── docker-compose.yml   # Development environment
```
## ロードマップ

### v1.0（現在）- 本番環境対応
- ハイブリッドGo+Pythonアーキテクチャ
- コアブランチ操作
- MongoDBチェンジストリーム
- CLIおよびAPIインターフェース
- 圧縮対応S3ストレージ

### v1.1 - ML統合
- MLflowコネクタ
- DVC統合
- Weights & Biasesサポート
- Jupyterノートブック例

### v1.2 - エンタープライズ機能
- ユーザー認証およびRBAC
- チームコラボレーション機能
- 高度なブランチ操作
- パフォーマンス最適化

### v1.3 - スケール＆ポリッシュ
- マルチリージョン展開
- 高度な分析機能
- プラグインアーキテクチャ
- エンタープライズサポート

## アーキテクチャ詳細

詳細な技術ドキュメントは以下をご参照ください：
- [アーキテクチャ概要](https://raw.githubusercontent.com/argon-lab/argon/master/docs/architecture.md)
- [APIドキュメント](https://raw.githubusercontent.com/argon-lab/argon/master/docs/api.md)
- [開発ガイド](https://raw.githubusercontent.com/argon-lab/argon/master/docs/development.md)
- [展開ガイド](https://raw.githubusercontent.com/argon-lab/argon/master/docs/deployment.md)

## コミュニティ

- **GitHub Discussions**: 質問やアイデアを共有
- **Discord**: コミュニティとのリアルタイムチャット（リンクは近日公開予定）
- **Twitter**: 更新情報は[@argondb](https://twitter.com/argondb)をフォロー

## ライセンス

本プロジェクトはMITライセンスの下で提供されています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## MongoDBエンジニアによる構築

ArgonはMongoDBの深い専門知識を活かして構築されており、チェンジストリームや最適化された集約パイプライン、実運用から得たパフォーマンスベストプラクティスなどの高度な機能を活用しています。

---

**⭐ 役に立ったらリポジトリにスターをお願いします！**

[![GitHub stars](https://img.shields.io/github/stars/argon-lab/argon?style=social)](https://github.com/argon-lab/argon)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---