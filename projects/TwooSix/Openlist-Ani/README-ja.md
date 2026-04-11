<h1 align="center">Openlist-Ani</h1>

<p align="center">
  <b>🎬 RSS購読 → 自動ダウンロード → AIリネーム、一括アニメ自動管理</b>
</p>

<p align="center">
  アニメのRSS購読フィードから自動的にアニメの更新を取得し、Openlistを通じて対応するクラウドストレージにオフラインダウンロードします。<br/>
  さらにLLMでリソース名を解析し、Emby / Jellyfinが認識できる形式にリネームします。
</p>

---

## ✨ 特徴

- 📡 **自動追跡** — RSSアニメ更新を自動取得してダウンロード
- 📦 **複数クラウド対応** — OpenListベースでPikPak、115などのオフラインダウンロードをサポート
- 🤖 **AIリネーム** — AIでリソース名解析＋TMDB検索により、正確にアニメ名、シーズン、話数を取得
- 💬 **スマートアシスタント** — Telegram Botに接続し、自然言語でAIに検索やダウンロードを依頼可能
- 🔔 **更新通知** — PushPlus、Telegramなどのチャネルで更新を通知

## 📋 準備作業

1. [Openlist公式ドキュメント](https://doc.oplist.org/guide)を参照しOpenlistをデプロイ、オフラインダウンロード環境を構築
2. RSS購読リンクを準備（例：[Mikan Project](https://mikanani.me)）
3. LLM APIキーを用意

## 🚀 クイックスタート

<details open>
<summary><b>方法1：PIPインストール（推奨）</b></summary>

**1. インストール**

```bash
pip install openlist-ani
```

**2. 設定ファイルの作成**

実行ディレクトリに `config.toml` を新規作成し、以下の内容を記入してください：

```toml
[rss]
urls = ["RSS订阅链接"]

[openlist]
url = "http://localhost:5244"       # Openlist 访问地址
token = ""                          # 令牌，见「设置 → 其他 → 令牌」
download_path = "/PikPak/Anime"     # 下载保存路径
offline_download_tool = "QBITTORRENT"  # 离线下载工具

[llm]
openai_api_key = ""                 # API Key
openai_base_url = "https://api.deepseek.com/v1"
openai_model = "deepseek-chat"
```

> 完整配置项请参考 [`config.toml.example`](https://raw.githubusercontent.com/TwooSix/Openlist-Ani/master/config.toml.example) 及 [配置说明](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

**3. 启动**

```bash
openlist-ani
```

**4.（オプション）AIアシスタントの起動**

設定ファイルにアシスタントの設定を追加した後に実行：

```toml
[assistant]
enabled = true

[assistant.telegram]
bot_token = ""        # 从 @BotFather 获取
allowed_users = []    # 允许的用户 ID 列表，留空则不限制
```

```bash
openlist-ani-assistant
```

</details>

<details>
<summary><b>方式二：Docker デプロイ</b></summary>

**1. ファイルの準備**

実行ディレクトリに作成：
- `config.toml` — 設定ファイル（内容は上記と同じ）
- `data/` — データディレクトリ

**2. コンテナの起動**

```bash
docker run -d \
  --name openlist-ani \
  --network host \
  -e ENABLE_ASSISTANT=false \
  -v /path/to/config.toml:/config.toml \
  -v /path/to/data:/data \
  twosix26/openlist-ani:latest
```

> `/path/to/` を実際のパスに置き換えてください。  
> AIアシスタントを有効にするには、設定を完了した後で `ENABLE_ASSISTANT` を `true` に設定してください。  
> 詳細は [Docker 部署ガイド](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南) を参照してください。

</details>

<details>
<summary><b>方法3：ソースからのビルド</b></summary>

#### 前提条件：uvのインストール

<table><tr><td>

**Linux / macOS**
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

</td><td>

**Windows（ウィンドウズ）**
```powershell
powershell -ExecutionPolicy ByPass -c "irm https://astral.sh/uv/install.ps1 | iex"
```

</td></tr></table>

> 更多安装方式参考 [uv 官方文档](https://github.com/astral-sh/uv)

#### 步骤

```bash
# 1. 克隆仓库
git clone https://github.com/TwooSix/Openlist-Ani.git && cd Openlist-Ani

# 2. 切换到最新版本（master 为开发分支，不保证稳定）
git checkout v***    # 替换为最新版本号

# 3. 安装依赖
uv sync --no-dev --frozen

# 4. 创建 config.toml 并填写配置（内容同上）

# 5. 启动
uv run openlist-ani

# 6.（可选）启动 AI 助理
uv run openlist-ani-assistant
```

</details>

## 📖 ドキュメント

- [クイックスタート](https://github.com/TwooSix/Openlist-Ani/wiki/快速开始)
- [PIP インストールガイド](https://github.com/TwooSix/Openlist-Ani/wiki/PIP安装指南)
- [Docker デプロイガイド](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南)
- [ソースコードコンパイルガイド](https://github.com/TwooSix/Openlist-Ani/wiki/源码编译指南)
- [設定説明](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

## 🖼️ 効果表示

| リネーム結果 | スマートアシスタント |
| :---: | :---: |
| <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic1.png" width="400"/> | <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic2.jpg" width="150"/> |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---