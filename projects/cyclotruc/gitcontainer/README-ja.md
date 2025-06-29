![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**あらゆるGitHubリポジトリを、AIによるDockerfile生成で本番環境対応のDockerコンテナに変換します。**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainerは、GitHubリポジトリを解析し、本番環境対応のDockerfileを自動生成するAI搭載Webアプリケーションです。GitHubのURLを貼り付けるだけで、最適なベースイメージ選択、依存関係管理、Dockerのベストプラクティスを備えたDockerfileが得られます。

## 🌟 クイックアクセス

任意のGitHubリポジトリURL内の `github.com` を `gitcontainer.com` に置き換えるだけで、そのリポジトリのDockerfile生成ページに即座にアクセスできます。

例:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ 特徴

- **🔄 即時URLアクセス**: どんなGitHub URLでも 'github.com' を 'gitcontainer.com' に置き換えるだけ
- **🤖 AIによる解析**: OpenAI GPT-4を活用し、リポジトリ構造を解析してインテリジェントなDockerfileを生成
- **⚡ リアルタイムストリーミング**: WebSocketストリーミングでDockerfile生成の様子をリアルタイムで確認可能
- **🎯 スマート検出**: 技術スタック（Python、Node.js、Java、Goなど）を自動検出
- **🔧 本番環境対応**: セキュリティ、マルチステージビルド、最適化などベストプラクティスに従ったDockerfileを生成
- **📋 追加指示**: 特殊な環境向けにカスタム要件を追加可能
- **📄 Docker Compose**: 複雑なアプリケーションには自動でdocker-compose.ymlを提案
- **🎨 モダンUI**: シンタックスハイライト付きMonacoエディタによるクリーンでレスポンシブなインターフェース
- **📱 モバイル対応**: デスクトップでもモバイルでもシームレスに利用可能

## 🚀 クイックスタート

### 前提条件

- Python 3.9以上
- Git
- OpenAI APIキー

### インストール

1. **リポジトリをクローン:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **依存関係をインストール:**
   ```bash
   pip install -r requirements.txt
   ```

3. **環境変数を設定:**
   ```bash
   # .envファイルを作成
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **アプリケーションを実行:**
   ```bash
   python app.py
   ```

5. **ブラウザで開く:**
   `http://localhost:8000` にアクセス

## 🛠️ 仕組み

1. **URL処理**: URL内の 'github.com' を 'gitcontainer.com' に置き換えて任意のリポジトリにアクセス
2. **リポジトリのクローン**: Gitを使ってGitHubリポジトリをローカルにクローン
3. **コード解析**: [gitingest](https://github.com/cyclotruc/gitingest) を用いてリポジトリ構造を解析し、関連情報を抽出
4. **AI生成**: 解析結果をOpenAI GPT-4に送り、Dockerfile生成用の専用プロンプトで応答を取得
5. **スマート最適化**: AIは以下を考慮:
   - 技術スタック検出
   - 依存関係管理
   - セキュリティベストプラクティス
   - 必要に応じたマルチステージビルド
   - ポート設定
   - 環境変数
   - ヘルスチェック

## 📁 プロジェクト構成

```
cyclotruc-gitcontainer/
├── app.py                 # メインFastAPIアプリケーション
├── requirements.txt       # Python依存パッケージ
├── .env                  # 環境変数ファイル（作成する）
├── static/               # 静的アセット（アイコン、CSS）
├── templates/
│   └── index.jinja       # メインHTMLテンプレート
└── tools/                # コア機能モジュール
    ├── __init__.py
    ├── create_container.py  # AIによるDockerfile生成
    ├── git_operations.py    # GitHubリポジトリのクローン
    └── gitingest.py        # リポジトリ解析
```

## 🔧 設定

### 環境変数

| 変数 | 説明 | 必須 |
|----------|-------------|----------|
| `OPENAI_API_KEY` | あなたのOpenAI APIキー | はい |
| `PORT` | サーバーポート（デフォルト: 8000） | いいえ |
| `HOST` | サーバーホスト（デフォルト: 0.0.0.0） | いいえ |

### 高度な使用方法

ツールをプログラムから使用できます:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # リポジトリをクローン
    clone_result = await clone_repo_tool(github_url)
    
    # gitingestで分析
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Dockerfileを生成
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# 使用例
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 カスタマイズ

### カスタム指示の追加

「追加指示」機能を使って生成処理をカスタマイズできます:

- `"小さいイメージサイズのためにAlpine Linuxを使用する"`
- `"RedisとPostgreSQLを含める"`
- `"本番環境デプロイ用に最適化する"`
- `"デバッグ用の開発ツールを追加する"`

## 📝 ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。詳細は [LICENSE](LICENSE) ファイルをご覧ください。

## 🙏 謝辞

- **[OpenAI](https://openai.com/)** — GPT-4 APIの提供
- **[gitingest](https://github.com/cyclotruc/gitingest)** — リポジトリ分析機能
- **[FastAPI](https://fastapi.tiangolo.com/)** — 優れたWebフレームワーク
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** — コード構文ハイライト

## 🔗 リンク

- **GitHubリポジトリ**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **デモ**: サンプルリポジトリでライブ体験
- **Issue**: [バグ報告・機能リクエスト](https://github.com/cyclotruc/gitcontainer/issues)

---

**Made with ❤️ by [Romain Courtois](https://github.com/cyclotruc)**

*どんなリポジトリも数秒でコンテナ化！*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---