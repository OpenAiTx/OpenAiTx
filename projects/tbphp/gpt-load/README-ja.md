# GPT-Load

中文文档 | [English](https://raw.githubusercontent.com/tbphp/gpt-load/main/README_EN.md)

[![Release](https://img.shields.io/github/v/release/tbphp/gpt-load)](https://github.com/tbphp/gpt-load/releases)
![Go Version](https://img.shields.io/badge/Go-1.23+-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

高性能かつエンタープライズ向けのAIインターフェース透明プロキシサービスであり、多様なAIサービスを統合する必要がある企業や開発者向けに設計されています。Go言語で開発されており、スマートなキー管理、負荷分散、充実した監視機能を備え、高い同時処理環境に最適化されています。

詳細は[公式ドキュメント](https://www.gpt-load.com/docs)をご覧ください。

<a href="https://hellogithub.com/repository/tbphp/gpt-load" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=554dc4c46eb14092b9b0c56f1eb9021c&claim_uid=Qlh8vzrWJ0HCneG" alt="Featured｜HelloGitHub" style="width: 250px; height: 54px;" width="250" height="54" /></a>

## 機能特徴

- **透明プロキシ**: ネイティブAPIフォーマットを完全に保持し、OpenAI、Google Gemini、Anthropic Claudeなど複数のフォーマットをサポート
- **スマートキー管理**: 高性能なキー・プール、グループ管理、自動ローテーションおよび障害復旧をサポート
- **負荷分散**: 複数の上流エンドポイントに対する加重負荷分散をサポートし、サービスの可用性を向上
- **スマート障害処理**: 自動キーのブラックリスト管理と回復機構によりサービスの継続性を保証
- **動的設定**: システム設定およびグループ設定はホットリロード対応で、再起動不要で反映可能
- **エンタープライズアーキテクチャ**: 分散マスター・スレーブ展開、水平スケールと高可用性をサポート
- **モダン管理**: Vue 3ベースのWeb管理画面で直感的かつ使いやすい
- **総合監視**: リアルタイム統計、ヘルスチェック、詳細なリクエストログ
- **高性能設計**: ゼロコピーのストリーム伝送、コネクションプール再利用、アトミック操作
- **本番対応**: 優雅なシャットダウン、エラーリカバリー、充実したセキュリティ機構
- **二重認証体系**: 管理側とプロキシ側の認証分離、プロキシ認証はグローバルおよびグループレベルのキーをサポート

## 対応AIサービス

GPT-Loadは透明プロキシサービスとして、各AIベンダーのネイティブAPIフォーマットを完全に保持します：

- **OpenAIフォーマット**: 公式OpenAI API、Azure OpenAI、およびその他のOpenAI互換サービス
- **Google Geminiフォーマット**: Gemini Pro、Gemini Pro VisionなどのモデルのネイティブAPI
- **Anthropic Claudeフォーマット**: Claudeシリーズモデル、高品質な対話およびテキスト生成をサポート

## クイックスタート

### 環境要件

- Go 1.23+（ソースコードビルド）
- Docker（コンテナ化デプロイ）
- MySQL、PostgreSQL、または SQLite（データベースストレージ）
- Redis（キャッシュおよび分散調整、オプション）

### 方法1：Dockerクイックスタート

```bash
docker run -d --name gpt-load \
    -p 3001:3001 \
    -e AUTH_KEY=sk-123456 \
    -v "$(pwd)/data":/app/data \
    ghcr.io/tbphp/gpt-load:latest
```

> 使用 `sk-123456` ログイン管理画面：<http://localhost:3001>

### 方法2：Docker Composeを使用（推奨）

**インストールコマンド：**

```bash
# 创建目录
mkdir -p gpt-load && cd gpt-load

# 下载配置文件
wget https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/docker-compose.yml
wget -O .env https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/.env.example

# 启动服务
docker compose up -d
```

デフォルトでインストールされているのは SQLite バージョンで、軽量な単一マシンアプリケーションに適しています。

MySQL、PostgreSQL、Redis をインストールする場合は、`docker-compose.yml` ファイル内で必要なサービスのコメントを解除し、対応する環境設定を行ってから再起動してください。

**その他のコマンド：**

```bash
# 查看服务状态
docker compose ps

# 查看日志
docker compose logs -f

# 重启服务
docker compose down && docker compose up -d

# 更新到最新版本
docker compose pull && docker compose down && docker compose up -d
```

デプロイ後：

- Web管理インターフェースにアクセス：<http://localhost:3001>
- APIプロキシアドレス：<http://localhost:3001/proxy>

> デフォルトの認証キー `sk-123456` を使用して管理画面にログインします。認証キーは .env の AUTH_KEY で変更可能です。

### 方法3：ソースコードからのビルド

ソースコードからのビルドには、ローカルにデータベース（SQLite、MySQL、または PostgreSQL）と Redis（オプション）がインストールされている必要があります。

```bash
# 克隆并构建
git clone https://github.com/tbphp/gpt-load.git
cd gpt-load
go mod tidy

# 创建配置
cp .env.example .env

# 修改 .env 中 DATABASE_DSN 和 REDIS_DSN 配置
# REDIS_DSN 为可选，如果不配置则启用内存存储

# 运行
make run
```
部署完了後：

- Web管理画面にアクセス：<http://localhost:3001>
- APIプロキシアドレス：<http://localhost:3001/proxy>

> デフォルトの認証キー `sk-123456` を使って管理画面にログインします。認証キーは .env の AUTH_KEY で変更可能です。

### 方法4：クラスタ展開

クラスタ展開では、全てのノードが同じ MySQL（または PostgreSQL）と Redis に接続する必要があり、Redisは必須です。統一された分散MySQLとRedisクラスタの利用を推奨します。

**展開要件：**

- すべてのノードで同一の `AUTH_KEY`、`DATABASE_DSN`、`REDIS_DSN` を設定すること
- マスター・スレーブ構成の場合、スレーブノードは環境変数：`IS_SLAVE=true` を設定すること

詳細は[クラスタ展開ドキュメント](https://www.gpt-load.com/docs/cluster)を参照してください。

## システム設定

### 設定アーキテクチャ概要

GPT-Loadは二層構成の設定アーキテクチャを採用しています：

#### 1. 静的設定（環境変数）

- **特徴**：アプリ起動時に読み込み、稼働中は変更不可。再起動で反映
- **用途**：基盤構成設定（データベース接続、サーバーポート、認証キーなど）
- **管理方法**：`.env` ファイルまたはシステム環境変数で設定

#### 2. 動的設定（ホットリロード）

- **システム設定**：データベースに保存され、アプリ全体の動作基準を提供
- **グループ設定**：特定グループ向けの動作パラメータで、システム設定を上書き可能
- **設定優先度**：グループ設定 > システム設定 > 環境設定
- **特徴**：ホットリロード対応。変更後すぐに反映し、再起動不要

<details>
<summary>静的設定（環境変数）</summary>

**サーバー構成：**

| 設定項目     | 環境変数                          | デフォルト値     | 説明                          |
| ------------ | --------------------------------- | --------------- | ----------------------------- |
| サーバーポート | `PORT`                           | 3001            | HTTPサーバーのリッスンポート  |
| サーバーアドレス | `HOST`                           | 0.0.0.0         | HTTPサーバーのバインドアドレス |
| 読み取りタイムアウト | `SERVER_READ_TIMEOUT`            | 60              | HTTPサーバーの読み取りタイムアウト（秒） |
| 書き込みタイムアウト | `SERVER_WRITE_TIMEOUT`           | 600             | HTTPサーバーの書き込みタイムアウト（秒） |
| アイドルタイムアウト | `SERVER_IDLE_TIMEOUT`            | 120             | HTTP接続のアイドルタイムアウト（秒）     |
| 優雅なシャットダウンタイムアウト | `SERVER_GRACEFUL_SHUTDOWN_TIMEOUT` | 10              | サービスの優雅なシャットダウン待機時間（秒） |
| スレーブモード | `IS_SLAVE`                       | false           | クラスタ展開時のスレーブノード識別       |
| タイムゾーン   | `TZ`                             | `Asia/Shanghai` | 指定タイムゾーン                |

**認証とデータベース構成：**

| 設定項目     | 環境変数       | デフォルト値          | 説明                                  |
| ------------ | -------------- | --------------------- | ------------------------------------- |
| 管理キー     | `AUTH_KEY`     | `sk-123456`           | **管理側**のアクセス認証キー          |
| データベース接続 | `DATABASE_DSN` | ./data/gpt-load.db    | データベース接続文字列（DSN）またはファイルパス |
| Redis接続   | `REDIS_DSN`    | -                     | Redis接続文字列。空の場合はメモリストレージを使用 |

**パフォーマンスとクロスオリジン設定：**

| 設定項目         | 環境変数                  | デフォルト値                         | 説明                        |
| ---------------- | ------------------------- | ---------------------------------- | --------------------------- |
| 最大同時リクエスト数 | `MAX_CONCURRENT_REQUESTS` | 100                                | システムが許容する最大同時リクエスト数 |
| CORSを有効化     | `ENABLE_CORS`             | true                               | クロスオリジンリソース共有を有効にするか |
| 許可するオリジン | `ALLOWED_ORIGINS`         | `*`                                | 許可するオリジン（カンマ区切り）    |
| 許可するHTTPメソッド | `ALLOWED_METHODS`         | `GET,POST,PUT,DELETE,OPTIONS`      | 許可するHTTPメソッド             |
| 許可するヘッダー  | `ALLOWED_HEADERS`         | `*`                                | 許可するリクエストヘッダー（カンマ区切り） |
| 認証情報を許可   | `ALLOW_CREDENTIALS`       | false                              | 認証情報の送信を許可するか         |

**ログ設定：**

| 設定項目       | 環境変数          | デフォルト値           | 説明                                 |
| -------------- | ----------------- | --------------------- | ------------------------------------ |
| ログレベル     | `LOG_LEVEL`       | `info`                | ログレベル：debug, info, warn, error |
| ログフォーマット | `LOG_FORMAT`      | `text`                | ログフォーマット：text, json         |
| ファイルログ有効化 | `LOG_ENABLE_FILE` | false                 | ファイルログ出力を有効にするか       |

| 日志文件路径 | `LOG_FILE_PATH`   | `./data/logs/app.log` | ログファイルの保存パス                   |

**プロキシ設定：**

GPT-Loadは環境変数からプロキシ設定を自動的に読み取り、上流のAIサービスプロバイダーへのリクエストに使用します。

| 設定項目     | 環境変数       | デフォルト | 説明                                     |
| ---------- | ------------- | ------ | ---------------------------------------- |
| HTTPプロキシ  | `HTTP_PROXY`  | -      | HTTPリクエスト用のプロキシサーバーアドレス           |
| HTTPSプロキシ | `HTTPS_PROXY` | -      | HTTPSリクエスト用のプロキシサーバーアドレス          |
| プロキシ除外   | `NO_PROXY`    | -      | プロキシを経由しないホストまたはドメイン、カンマ区切り |

対応するプロキシプロトコル形式：

- **HTTP**: `http://user:pass@host:port`
- **HTTPS**: `https://user:pass@host:port`
- **SOCKS5**: `socks5://user:pass@host:port`
</details>

<details>
<summary>動的設定（ホットリロード）</summary>

**基本設定：**

| 設定項目       | フィールド名                             | デフォルト値                 | グループ上書き可否 | 説明                                     |
| ------------ | ------------------------------------ | --------------------------- | ---------- | -------------------------------------- |
| プロジェクトURL | `app_url`                            | `http://localhost:3001`     | ❌         | プロジェクトの基本URL                   |
| ログ保持日数   | `request_log_retention_days`         | 7                           | ❌         | リクエストログの保持日数、0はクリアしない |
| ログ書き込み間隔 | `request_log_write_interval_minutes` | 1                           | ❌         | ログをデータベースに書き込む周期（分） |
| グローバルプロキシキー | `proxy_keys`                         | 初期値は環境設定のAUTH_KEY     | ❌         | グローバルに有効なプロキシ認証キー、複数はカンマ区切り |

**リクエスト設定：**

| 設定項目               | フィールド名                    | デフォルト値 | グループ上書き可否 | 説明                             |
| -------------------- | ------------------------- | -------- | ---------- | ------------------------------ |
| リクエストタイムアウト   | `request_timeout`         | 600      | ✅         | 転送リクエストの全ライフサイクルのタイムアウト（秒） |
| 接続タイムアウト       | `connect_timeout`         | 15       | ✅         | 上流サービスとの接続確立タイムアウト（秒）           |
| アイドル接続タイムアウト | `idle_conn_timeout`       | 120      | ✅         | HTTPクライアントのアイドル接続タイムアウト（秒）     |
| レスポンスヘッダタイムアウト | `response_header_timeout` | 600      | ✅         | 上流レスポンスヘッダ待機タイムアウト（秒）           |
| 最大アイドル接続数     | `max_idle_conns`          | 100      | ✅         | コネクションプールの最大アイドル接続数               |
| ホストごとの最大アイドル接続数 | `max_idle_conns_per_host` | 50     | ✅         | 各アップストリームホストの最大アイドル接続数    |
| プロキシサーバーアドレス         | `proxy_url`               | -      | ✅         | リクエスト転送に使用する HTTP/HTTPS プロキシ。空欄の場合は環境設定を使用 |

**キー設定：**

| 設定項目       | フィールド名                          | デフォルト値 | グループ上書き可 | 説明                                               |
| -------------- | ----------------------------------- | ------------ | --------------- | -------------------------------------------------- |
| 最大リトライ回数 | `max_retries`                       | 3            | ✅              | 単一リクエストで異なるキーを使用する最大リトライ回数 |
| ブラックリスト閾値 | `blacklist_threshold`               | 3            | ✅              | キーが連続で失敗した回数の閾値を超えた後にブラックリストに登録 |
| キー検証間隔（分）| `key_validation_interval_minutes`  | 60           | ✅              | バックグラウンドでキーを定期検証する周期（分）    |
| キー検証同時実行数 | `key_validation_concurrency`        | 10           | ✅              | バックグラウンドで無効なキーを検証する際の同時実行数 |
| キー検証タイムアウト（秒） | `key_validation_timeout_seconds` | 20           | ✅              | バックグラウンドで単一キーの API リクエストタイムアウト時間（秒） |

</details>

## Web 管理画面

管理コンソールにアクセス：<http://localhost:3001>（デフォルトアドレス）

### 画面表示

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/dashboard.png" alt="ダッシュボード" width="600" />

<br/>

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/keys.png" alt="キー管理" width="600" />

<br/>

Web 管理画面は以下の機能を提供します：

- **ダッシュボード**: リアルタイムの統計情報とシステム状態の概要
- **キー管理**: AI サービスプロバイダーグループの作成・設定、API キーの追加・削除・監視
- **リクエストログ**: 詳細なリクエスト履歴およびデバッグ情報
- **システム設定**: グローバル設定管理とホットリロード

## API 使用説明

<details>
<summary>プロキシインターフェース呼び出し方法</summary>
GPT-Load はグループ名によってリクエストを異なる AI サービスにルーティングします。使用方法は以下の通りです：

#### 1. プロキシエンドポイントの形式


```text
http://localhost:3001/proxy/{group_name}/{原始API路径}
```

- `{group_name}`: 管理画面で作成したグループ名
- `{原始API路径}`: 元の AI サービスと完全に一致するパス

#### 2. 認証方式

Web 管理画面で**プロキシキー**(`Proxy Keys`)を設定し、システムレベルおよびグループレベルのプロキシキーを設定可能。

- **認証方式**: ネイティブ API と同じだが、元のキーを設定したプロキシキーに置き換える必要がある。
- **キーのスコープ**: システム設定で設定した**グローバルプロキシキー**はすべてのグループで使用可能、グループ設定の**グループプロキシキー**は当該グループ内のみ有効。
- **形式**: 複数のキーは半角カンマで区切る。

#### 3. OpenAI インターフェース呼び出し例

`openai` という名前のグループを作成したと仮定：

**元の呼び出し方式：**

```bash
curl -X POST https://api.openai.com/v1/chat/completions \
  -H "Authorization: Bearer sk-your-openai-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**代理呼び出し方式：**

```bash
curl -X POST http://localhost:3001/proxy/openai/v1/chat/completions \
  -H "Authorization: Bearer your-proxy-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**変更内容：**

- `https://api.openai.com` を `http://localhost:3001/proxy/openai` に置き換え
- 元の API キーを**代理キー**に置き換え

#### 4. Gemini インターフェース呼び出し例

`gemini` という名前のグループを作成したと仮定：

**元の呼び出し方法：**

```bash
curl -X POST https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-pro:generateContent?key=your-gemini-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**代理呼び出し方法：**

```bash
curl -X POST http://localhost:3001/proxy/gemini/v1beta/models/gemini-2.5-pro:generateContent?key=your-proxy-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**変更内容：**

- `https://generativelanguage.googleapis.com` を `http://localhost:3001/proxy/gemini` に置換
- URL パラメータの `key=your-gemini-key` を**プロキシキー**に置換

#### 5. Anthropic インターフェース呼び出し例

`anthropic` という名前のグループを作成したと仮定：

**元の呼び出し方法：**

```bash
curl -X POST https://api.anthropic.com/v1/messages \
  -H "x-api-key: sk-ant-api03-your-anthropic-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**代理呼び出し方法：**

```bash
curl -X POST http://localhost:3001/proxy/anthropic/v1/messages \
  -H "x-api-key: your-proxy-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**変更説明：**

- `https://api.anthropic.com` を `http://localhost:3001/proxy/anthropic` に置き換え
- `x-api-key` ヘッダー内の元の API キーを**プロキシキー**に置き換え

#### 6. サポートされているインターフェース

**OpenAI 形式：**

- `/v1/chat/completions` - チャット対話
- `/v1/completions` - テキスト補完
- `/v1/embeddings` - テキスト埋め込み
- `/v1/models` - モデル一覧
- その他すべての OpenAI 互換インターフェース

**Gemini 形式：**

- `/v1beta/models/*/generateContent` - コンテンツ生成
- `/v1beta/models` - モデル一覧
- その他すべての Gemini ネイティブインターフェース

**Anthropic 形式：**

- `/v1/messages` - メッセージ対話
- `/v1/models` - モデル一覧（利用可能な場合）
- その他すべての Anthropic ネイティブインターフェース

#### 7. クライアント SDK 設定

**OpenAI Python SDK：**

```python
from openai import OpenAI

client = OpenAI(
    api_key="your-proxy-key",  # 使用密钥
    base_url="http://localhost:3001/proxy/openai"  # 使用代理端点
)

response = client.chat.completions.create(
    model="gpt-4.1-mini",
    messages=[{"role": "user", "content": "Hello"}]
)
```

**Google Gemini SDK（Python）：**

```python
import google.generativeai as genai

# 配置 API 密钥和基础 URL
genai.configure(
    api_key="your-proxy-key",  # 使用代理密钥
    client_options={"api_endpoint": "http://localhost:3001/proxy/gemini"}
)

model = genai.GenerativeModel('gemini-2.5-pro')
response = model.generate_content("Hello")
```

**Anthropic SDK（Python）：**

```python
from anthropic import Anthropic

client = Anthropic(
    api_key="your-proxy-key",  # 使用代理密钥
    base_url="http://localhost:3001/proxy/anthropic"  # 使用代理端点
)

response = client.messages.create(
    model="claude-sonnet-4-20250514",
    messages=[{"role": "user", "content": "Hello"}]
)
```

> **重要な注意**：透明なプロキシサービスとして、GPT-Loadは各AIサービスのネイティブAPI形式と認証方式を完全に保持し、エンドポイントアドレスを置き換え、管理画面で設定した**プロキシキー**を使用するだけでシームレスに移行できます。

</details>

## ライセンス

MITライセンス - 詳細は [LICENSE](LICENSE) ファイルを参照してください。

## スター履歴

[![Stargazers over time](https://starchart.cc/tbphp/gpt-load.svg?variant=adaptive)](https://starchart.cc/tbphp/gpt-load)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---