# AgenticSeek: プライベート・ローカル Manus 代替

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

* **100%ローカルなManus AIの代替。** この音声対応AIアシスタントは、すべてのデータをデバイス上に保持しながら、自律的にウェブを閲覧し、コードを書き、タスクを計画します。ローカル推論モデル向けに最適化されており、完全に自分のハードウェア上で動作し、完全なプライバシーとクラウド依存ゼロを保証します。

[![Visit AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### なぜAgenticSeekなのか？

* 🔒 完全ローカル＆プライベート - すべてがあなたのマシン上で動作します。クラウドなし、データ共有なし。ファイル、会話、検索内容はすべてプライベートに保たれます。

* 🌐 スマートなウェブブラウジング - AgenticSeekは自動でインターネットを閲覧できます。検索、読取、情報抽出、ウェブフォームへの入力もハンズフリーで可能です。

* 💻 自律型コーディングアシスタント - コードが必要ですか？Python、C、Go、Javaなどのプログラムを自動で作成、デバッグ、実行できます。

* 🧠 スマートエージェント選択 - あなたが依頼すれば、自動的に最適なエージェントを選択します。まるで専門家チームが常に助けてくれるようです。

* 📋 複雑なタスクの計画と実行 - 旅行計画から複雑なプロジェクトまで、大きなタスクをステップに分解し、複数のAIエージェントを使って完遂します。

* 🎙️ 音声対応 - クリアで高速、未来的な音声認識・テキスト変換機能により、まるでSF映画のAIのように会話できます。（開発中）

### **デモ**

> *agenticSeekプロジェクトを検索し、必要なスキルを調べてからCV_candidates.zipを開き、プロジェクトに最も合致する候補者を教えてください*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

免責事項：このデモに登場する全てのファイル（例：CV_candidates.zip）は完全なフィクションです。私たちは法人ではなく、候補者でなくオープンソースのコントリビューターを募集しています。

> 🛠⚠️️ **活発な開発中**

> 🙏 このプロジェクトはサイドプロジェクトとして始まり、ロードマップも資金もありません。GitHub Trending入りで想像以上に成長しました。貢献・フィードバック・ご辛抱に深く感謝します。

## 前提条件

開始する前に、以下のソフトウェアがインストールされていることを確認してください：

*   **Git:** リポジトリのクローン用。[Gitをダウンロード](https://git-scm.com/downloads)
*   **Python 3.10.x:** Python 3.10.xバージョンを強く推奨します。他のバージョンでは依存関係エラーが発生することがあります。[Python 3.10をダウンロード](https://www.python.org/downloads/release/python-3100/)（3.10.xバージョンを選択）
*   **Docker Engine & Docker Compose:** SearxNGなどのバンドルサービス用。
    *   Docker Desktop（Docker Compose V2を含む）をインストール：[Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   またはLinuxでDocker EngineとDocker Composeを個別にインストール：[Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/)（必ずCompose V2をインストール、例：`sudo apt-get install docker-compose-plugin`）

### 1. **リポジトリのクローンとセットアップ**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. .envファイルの内容を変更

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

必要に応じて `.env` ファイルを自分の値に更新してください：

- **SEARXNG_BASE_URL**: 変更不要 
- **REDIS_BASE_URL**: 変更不要 
- **WORK_DIR**: ローカルマシン上の作業ディレクトリへのパス。AgenticSeekがこれらのファイルを読み書きできます。
- **OLLAMA_PORT**: Ollamaサービス用のポート番号。
- **LM_STUDIO_PORT**: LM Studioサービス用のポート番号。
- **CUSTOM_ADDITIONAL_LLM_PORT**: 追加のカスタムLLMサービス用のポート。

**APIキーはローカルでLLMを動作させる場合は完全に任意です。本プロジェクトの主目的です。十分なハードウェアがある場合は空欄でOKです。**

### 3. **Dockerを起動**

Dockerがインストールされ、システムで起動していることを確認してください。以下のコマンドでDockerを起動できます：

- **Linux/macOSの場合:**  
    ターミナルを開いて以下を実行：
    ```sh
    sudo systemctl start docker
    ```
    または、インストール済みの場合はアプリケーションメニューからDocker Desktopを起動。

- **Windowsの場合:**  
    スタートメニューからDocker Desktopを起動。

Dockerが動作しているかを確認するには、以下を実行：
```sh
docker info
```
Dockerインストール情報が表示されれば、正常に動作しています。

下記の[ローカルプロバイダー一覧](#list-of-local-providers)を参照してください。

次のステップ：[AgenticSeekをローカルで実行](#start-services-and-run)

*問題が発生した場合は[トラブルシューティング](#troubleshooting)セクションを参照してください。*
*ハードウェアがローカルLLMに対応していない場合は[APIでの実行セットアップ](#setup-to-run-with-an-api)を参照してください。*
*詳しい`config.ini`の説明は[Configセクション](#config)を参照してください。*

---

## LLMをローカルマシンで実行するセットアップ

**ハードウェア要件:**

LLMをローカルで動作させるには十分なハードウェアが必要です。最低でもMagistral、Qwen、Deepseek 14Bが動作するGPUが必要です。詳しいモデル・パフォーマンスの推奨はFAQを参照してください。

**ローカルプロバイダーの起動**

例としてollamaを起動する場合：

```sh
ollama serve
```

対応するローカルプロバイダーの一覧は下記参照。

**config.iniの更新**

config.iniファイルのprovider_nameを対応プロバイダーに、provider_modelを利用したいLLMモデル名に設定します。推論モデル（*Magistral*や*Deepseek*など）を推奨します。

必要ハードウェアはREADME末尾の**FAQ**参照。

```sh
[MAIN]
is_local = True # ローカルまたはリモートプロバイダーの使用を選択
provider_name = ollama # lm-studio, openaiなども可
provider_model = deepseek-r1:14b # ハードウェアに合ったモデルを選択
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # AIの名前
recover_last_session = True # 前回セッションの復元
save_session = True # 現在のセッションを保存
speak = False # テキスト読み上げ
listen = False # 音声認識（CLIのみ、実験的）
jarvis_personality = False # Jarvis風パーソナリティ使用（実験的）
languages = en zh # 言語リスト、TTSはリスト先頭をデフォルト使用
[BROWSER]
headless_browser = True # CLIでの利用を除き変更不要
stealth_mode = True # ブラウザ検出防止のため未検出Seleniumを使用
```

**注意:**

- `config.ini`の書式はコメントをサポートしていません。 
例の設定をそのままコピー＆ペーストしないでください。コメントがエラーとなります。必要な設定のみ手動で編集してください。

- LM-studioでLLMを起動する場合、`provider_name`を`openai`に設定しないでください。`lm-studio`に設定してください。

- 一部プロバイダー（例：lm-studio）はIPの前に`http://`が必要です。例：`http://127.0.0.1:1234`

**ローカルプロバイダー一覧**

| プロバイダー  | ローカル対応 | 説明                                               |
|-----------|--------|-----------------------------------------------------------|
| ollama    | はい    | ollamaをLLMプロバイダーとして使い、簡単にローカルLLM実行       |
| lm-studio  | はい    | LM StudioでローカルLLM実行（`provider_name`は`lm-studio`に設定）|
| openai    | はい     | openai互換API使用（例：llama.cppサーバー）  |

次のステップ：[AgenticSeekのサービス開始・実行](#Start-services-and-Run)  

*問題が発生した場合は[トラブルシューティング](#troubleshooting)セクションを参照してください。*
*ハードウェアがローカルLLMに対応していない場合は[APIでの実行セットアップ](#setup-to-run-with-an-api)を参照してください。*
*詳しい`config.ini`の説明は[Configセクション](#config)を参照してください。*

## APIでの実行セットアップ

このセットアップでは、外部クラウドベースのLLMプロバイダーを利用します。選択したサービスのAPIキーが必要です。

**1. APIプロバイダーを選択しAPIキーを取得:**

[APIプロバイダー一覧](#list-of-api-providers)を参照し、各ウェブサイトでサインアップしAPIキーを取得してください。

**2. APIキーを環境変数として設定:**

*   **Linux/macOS:**
    ターミナルを開き、`export`コマンドを利用。永続化にはシェルのプロファイルファイル（例：`~/.bashrc`, `~/.zshrc`）に追加するのが最適です。
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # PROVIDER_API_KEYは各サービスの変数名（例：OPENAI_API_KEY, GOOGLE_API_KEY）に置き換えてください
    ```
    TogetherAIの例：
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **コマンドプロンプト（現在のセッションのみ一時的に設定）:**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell（現在のセッションのみ一時的に設定）:**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **永続的に設定:** Windowsの検索バーで「環境変数」と検索し、「システム環境変数の編集」をクリックして、「環境変数...」ボタンを押します。適切な名前（例: `OPENAI_API_KEY`）と値（APIキー）で新しいユーザー変数を追加してください。

*（詳細はFAQ: [APIキーの設定方法](#how-do-i-set-api-keys) を参照してください）。*


**3. `config.ini` の更新:**
```ini
[MAIN]
is_local = False
provider_name = openai # または google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # または gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 など
provider_server_address = # 通常、is_local = False の場合はほとんどのAPIで無視されるか空欄でOK
# ... その他の設定 ...
```
*警告:* `config.ini` の値に末尾スペースが無いことを確認してください。

**APIプロバイダー一覧**

| プロバイダー   | `provider_name` | ローカル? | 説明                                              | APIキーリンク（例）                        |
|----------------|-----------------|-----------|--------------------------------------------------|---------------------------------------------|
| OpenAI         | `openai`        | いいえ    | OpenAIのAPI経由でChatGPTモデルを使用              | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini  | `google`        | いいえ    | Google AI Studio経由でGoogle Geminiモデルを使用   | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek       | `deepseek`      | いいえ    | DeepseekのAPI経由でDeepseekモデルを使用           | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face   | `huggingface`   | いいえ    | Hugging Face Inference API経由でモデルを使用      | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI     | `togetherAI`    | いいえ    | TogetherAI API経由で様々なOSSモデルを利用可能     | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*注意:*
*   複雑なウェブブラウジングやタスク計画には、現在のプロンプト最適化はDeepseek向けのため、`gpt-4o`や他のOpenAIモデルの利用は推奨しません。
*   コーディングやbashのタスクはGeminiではDeepseek向けの書式に厳密に従わない可能性があり、問題が発生する場合があります。
*   `config.ini` の `provider_server_address` は、`is_local = False` の場合、APIエンドポイントが各プロバイダーのライブラリでハードコーディングされているため通常使用しません。

次のステップ: [サービスの起動とAgenticSeekの実行](#Start-services-and-Run)

*問題が発生した場合は「**既知の問題**」セクションを参照してください。*

*詳細な設定ファイルの説明は「**Config**」セクションを参照してください。*

---

## サービスの起動と実行

デフォルトでは、AgenticSeekはすべてDocker内で実行されます。

必要なサービスを起動します。これによりdocker-compose.ymlから以下のすべてのサービスが起動します:
    - searxng
    - redis（searxngに必須）
    - frontend
    - backend（`full`を使用する場合）

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**警告:** このステップで全てのDockerイメージのダウンロード・ロードが行われ、最大30分かかる場合があります。サービス起動後、バックエンドサービスが完全に起動するまで（ログに **backend: "GET /health HTTP/1.1" 200 OK** と表示されるまで）メッセージの送信はお待ちください。初回起動時はバックエンドサービスの起動に最大5分かかることがあります。

`http://localhost:3000/` にアクセスするとWebインターフェースが表示されます。

*サービス起動時のトラブルシューティング:* これらのスクリプトが失敗する場合は、Docker Engineが起動しており、Docker Compose（V2, `docker compose`）が正しくインストールされていることを確認してください。エラーメッセージは端末の出力を確認してください。[FAQ: AgenticSeekやスクリプト実行時にエラーが出る場合の対処法](#faq-troubleshooting)も参照してください。

**オプション:** ホスト（CLIモード）での実行

CLIインターフェースで実行するには、ホストにパッケージをインストールしてください:

```sh
./install.sh
./install.bat # windows
```

サービスを起動します:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

CLIの利用: `python3 cli.py`


---

## 利用方法

`./start_services.sh full` でサービスが稼働していることを確認し、Webインターフェースは `localhost:3000` で利用できます。

CLIモードのみ、configで `listen = True` に設定することで音声認識（speech to text）も利用可能です。

終了するには、単に `goodbye` と発話または入力してください。

利用例:

> *pythonでスネークゲームを作って！*

> *フランス・レンヌのトップカフェをWeb検索し、3つを住所付きでrennes_cafes.txtに保存して。*

> *Goで階乗を計算するプログラムを書き、factorial.goとしてワークスペースに保存して*

> *summer_picturesフォルダー内の全JPGファイルを今日の日付でリネームし、リネーム後のファイル一覧をphotos_list.txtに保存*

> *2024年の人気SF映画をネットで調べて、今夜観る3本を選んで。リストをmovie_night.txtに保存。*

> *2025年の最新AIニュース記事をネット検索し、3つ選んで、それらのタイトルと要約をスクレイピングするPythonスクリプトを書いて。スクリプトはnews_scraper.py、要約は/home/projectsのai_news.txtに保存*

> *金曜日、無料の株価APIをWebで探し、supersuper7434567@gmail.comで登録、そのAPIでテスラの日次株価を取得するPythonスクリプトを書いて、結果をstock_prices.csvに保存*

*なお、フォーム入力の自動化は実験的機能のため失敗する場合があります。*



クエリを入力すると、AgenticSeekがタスクに最適なエージェントを割り当てます。

本プロトタイプは初期段階のため、エージェントルーティングが必ずしも最適なものとは限りません。

そのため、AIにしてほしいことや進め方をできるだけ明確に伝えてください。例えばWeb検索させたい場合は、

`Do you know some good countries for solo-travel?`

のように曖昧にせず、

`Do a web search and find out which are the best country for solo-travel`

のように具体的に指示しましょう。

---

## **LLMを自分のサーバーで動かす設定**  

高性能なコンピュータやサーバーがあり、それをノートPCから利用したい場合は、独自のllmサーバーでLLMをリモート実行できます。

AIモデルを動かす「サーバー」でIPアドレスを取得します。

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # ローカルIP
curl https://ipinfo.io/ip # グローバルIP
```

注: WindowsやmacOSの場合は、それぞれipconfigやifconfigでIPアドレスを確認してください。

リポジトリをクローンし、`server/`フォルダーに移動します。

```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

サーバー用の要件をインストール:

```sh
pip3 install -r requirements.txt
```

サーバースクリプトを実行します。

```sh
python3 app.py --provider ollama --port 3333
```

`ollama`または`llamacpp`をLLMサービスとして利用可能です。


次に、個人PC側で:

`config.ini`ファイルの`provider_name`を`server`、`provider_model`を`deepseek-r1:xxb`に設定します。
`provider_server_address`にはモデルを動かすマシンのIPアドレスを設定します。

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```


次のステップ: [サービスの起動とAgenticSeekの実行](#Start-services-and-Run)  

---

## 音声認識（Speech to Text）

注意: 音声認識は現状CLIモードのみ対応です。

現時点では音声認識は英語のみ対応しています。

音声認識はデフォルトで無効です。有効にするには、config.iniのlistenオプションをTrueに設定してください:

```
listen = True
```

有効にすると、音声認識は入力処理の前にトリガーワード（エージェント名）を待ち受けます。エージェント名は*config.ini*ファイルの `agent_name` 値を更新してカスタマイズできます:

```
agent_name = Friday
```

最適な認識のため、エージェント名には「John」や「Emma」などの一般的な英語名を使用することを推奨します。

トランスクリプトが表示され始めたら、エージェント名（例：「Friday」）を声に出して呼びかけて起動します。

質問ははっきりと話してください。

リクエストの最後に、システムに処理を進めるよう伝える確認フレーズを付けてください。確認フレーズの例：
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## Config

設定例：
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # Ollamaの場合の例。LM-Studioの場合は http://127.0.0.1:1234
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # TTSやルーティングに利用する言語リスト
[BROWSER]
headless_browser = False
stealth_mode = False
```

**`config.ini` 設定の説明**:

*   **`[MAIN]` セクション:**
    *   `is_local`: ローカルLLMプロバイダ（Ollama、LM-Studio、OpenAI互換ローカルサーバー、セルフホスト型サーバー）を使用する場合は `True`。クラウドAPI（OpenAI、Google等）は `False`。
    *   `provider_name`: LLMプロバイダーを指定します。
        *   ローカル: `ollama`, `lm-studio`, `openai`（OpenAI互換ローカルサーバー用）, `server`（セルフホストサーバー用）
        *   API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`
    *   `provider_model`: 選択したプロバイダー用のモデル名またはID（例：Ollamaなら `deepseekcoder:6.7b`、OpenAI APIなら `gpt-3.5-turbo`、TogetherAIなら `mistralai/Mixtral-8x7B-Instruct-v0.1`）
    *   `provider_server_address`: LLMプロバイダーのアドレス
        *   ローカル: 例 `http://127.0.0.1:11434`（Ollama）、`http://127.0.0.1:1234`（LM-Studio）
        *   `server` プロバイダーの場合: セルフホストLLMサーバーのアドレス（例：`http://your_server_ip:3333`）
        *   クラウドAPI（`is_local = False`）の場合：多くは無視されるか空欄でOK。APIエンドポイントはクライアントライブラリが管理します。
    *   `agent_name`: AIアシスタントの名前（例：Friday）。音声認識トリガーワードとして使用。
    *   `recover_last_session`: 前回セッションの状態を復元する場合は `True`、新規開始は `False`
    *   `save_session`: 現在のセッション状態を保存する場合は `True`
    *   `speak`: テキスト読み上げ音声出力を有効にする場合は `True`
    *   `listen`: 音声入力（CLIモードのみ）を有効にする場合は `True`
    *   `work_dir`: **重要:** AgenticSeekがファイルの読み書きを行うディレクトリ。**このパスが有効かつアクセス可能であることを確認してください。**
    *   `jarvis_personality`: "Jarvis風" のシステムプロンプトを使う場合は `True`（実験的）、標準プロンプトは `False`
    *   `languages`: カンマ区切りの言語リスト（例：`en, zh, fr`）。TTS音声選択（最初がデフォルト）やLLMルーターに利用。効率化のため、似すぎた言語や多すぎる言語は避けてください。
*   **`[BROWSER]` セクション:**
    *   `headless_browser`: ウィンドウを表示せず自動化ブラウザを実行する場合は `True`（ウェブインターフェースや非対話用途推奨）。ウィンドウを表示する場合は `False`（CLIモードやデバッグ用）。
    *   `stealth_mode`: ブラウザ自動化の検出を難しくする機能を有効化する場合は `True`。anticaptcha等の拡張機能の手動インストールが必要な場合があります。


このセクションではサポートされているLLMプロバイダータイプをまとめています。`config.ini` で設定してください。

**ローカルプロバイダー（自身のハードウェア上で実行）:**

| `config.ini`内のプロバイダー名 | `is_local` | 説明                                                                         | セットアップセクション                                                   |
|-------------------------------|------------|------------------------------------------------------------------------------|--------------------------------------------------------------------------|
| `ollama`                      | `True`     | OllamaでローカルLLMを提供                                                    | [ローカル実行のセットアップ](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | LM-StudioでローカルLLMを提供                                                 | [ローカル実行のセットアップ](#setup-for-running-llm-locally-on-your-machine) |
| `openai`（ローカルサーバー用）| `True`     | OpenAI互換APIを公開するローカルサーバーへ接続（例：llama.cpp）               | [ローカル実行のセットアップ](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | 他のマシンで動作するAgenticSeekセルフホストLLMサーバーへ接続                 | [独自サーバーでのセットアップ](#setup-to-run-the-llm-on-your-own-server)      |

**APIプロバイダー（クラウドベース）:**

| `config.ini`内のプロバイダー名 | `is_local` | 説明                                             | セットアップセクション                     |
|-------------------------------|------------|--------------------------------------------------|--------------------------------------------|
| `openai`                      | `False`    | OpenAI公式API（例：GPT-3.5, GPT-4）利用         | [API利用セットアップ](#setup-to-run-with-an-api) |
| `google`                      | `False`    | Google GeminiモデルをAPI経由で利用               | [API利用セットアップ](#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | Deepseek公式API利用                             | [API利用セットアップ](#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | Hugging Face Inference API利用                   | [API利用セットアップ](#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | TogetherAIのAPIで様々なオープンモデルを利用      | [API利用セットアップ](#setup-to-run-with-an-api) |

---
## トラブルシューティング

問題が発生した場合、このセクションがガイドとなります。

# 既知の問題

## ChromeDriverの問題

**エラー例:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **原因:** インストール済みのChromeDriverのバージョンがGoogle Chromeブラウザのバージョンと互換性がありません。
*   **解決策:**
    1.  **Chromeバージョンの確認:** Google Chromeを開き、`設定 > Chromeについて` でバージョン（例："Version 120.0.6099.110"）を確認。
    2.  **対応するChromeDriverをダウンロード:**
        *   Chrome 115以降の場合: [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/)で「stable」チャンネルを探し、ご自身のOSに合ったChromeのメジャーバージョンに一致するChromeDriverをダウンロード。
        *   旧バージョン（稀）: [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads)ページを参照。
        *   下記画像はCfTページの例です:
            ![Download Chromedriver specific version from Chrome for Testing page](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **ChromeDriverのインストール:**
        *   ダウンロードした `chromedriver`（Windowsの場合は `chromedriver.exe`）を、システムのPATH環境変数に含まれるディレクトリ（例：Linux/macOSは `/usr/local/bin`、WindowsはPATHに追加したカスタムスクリプトフォルダ等）に配置。
        *   もしくは、`agenticSeek` プロジェクトのルートディレクトリに配置。
        *   実行権限を付与（例：Linux/macOSは `chmod +x chromedriver`）。
    4.  詳細はインストールガイド内 [ChromeDriver Installation](#chromedriver-installation) セクションを参照。

このセクションが不完全な場合や他のChromeDriver問題が発生した場合、[GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) で既存の内容を検索、または新規Issueを作成してください。

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

このエラーはブラウザとchromedriverのバージョンが一致していない場合に発生します。

以下から最新バージョンをダウンロードしてください：

https://developer.chrome.com/docs/chromedriver/downloads

Chrome バージョン115以降の場合はこちら：

https://googlechromelabs.github.io/chrome-for-testing/

ご自身のOSに合ったchromedriverバージョンをダウンロードしてください。

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

このセクションが不完全な場合はIssueを作成してください。

## connection adapters の問題

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (Note: port may vary)
```

*   **原因:** `lm-studio`（または同様のOpenAI互換ローカルサーバー）用に `config.ini` の `provider_server_address` に `http://` プレフィックスがない、またはポートが誤っています。
*   **解決策:**
    *   アドレスが `http://` を含んでいることを確認。LM-Studioは通常 `http://127.0.0.1:1234` がデフォルトです。
    *   `config.ini`の修正例：`provider_server_address = http://127.0.0.1:1234`（ご利用のLM-Studioサーバーのポートに合わせて修正）

## SearxNG Base URL未指定

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## FAQ

**Q: 必要なハードウェアは？**  

| モデルサイズ  | GPU  | コメント                                               |
|--------------|--------|-----------------------------------------------------------|
| 7B           | 8GB Vram | ⚠️ 推奨しません。パフォーマンスが悪く、幻覚も多く、プランナーエージェントはほぼ失敗します。 |
| 14B          | 12GB VRAM (例：RTX 3060) | ✅ 簡単なタスクには使用可能。ウェブブラウジングや計画タスクにはやや力不足。 |
| 32B          | 24GB以上VRAM (例：RTX 4090) | 🚀 ほとんどのタスクで成功。ただしタスクプランニングはやや苦手な場合あり。|
| 70B以上       | 48GB以上VRAM | 💪 優秀。高度な用途に推奨。|

**Q: エラーが出た場合は？**  

ローカルが起動中（`ollama serve`）、`config.ini`がプロバイダーに一致、依存関係がインストール済みであることを確認。それでも解決しない場合はIssueを作成してください。

**Q: 本当に100％ローカル実行できる？**  

Ollama、lm-studioまたはserverプロバイダー利用時は、音声認識・LLM・TTSモデルすべてローカル動作します。非ローカル（OpenAI等API）はオプションです。

**Q: ManusがあるのにAgenticSeekを使う理由は？**

Manusと異なり、AgenticSeekは外部システム依存を最小化し、より多くのコントロールやプライバシー、APIコスト回避を重視しています。

**Q: プロジェクトの運営者は？**

このプロジェクトは私と、オープンソースコミュニティの2人の友人（メンテナー兼コントリビューター）で開発しています。私たちはスタートアップや組織所属ではなく、情熱を持った個人の集まりです。

私の個人アカウント（https://x.com/Martin993886460）以外のAgenticSeek名義のXアカウントはなりすましです。

## 貢献について

AgenticSeekの開発にご協力いただける開発者を募集中です！オープンなIssueやディスカッションをご覧ください。

[貢献ガイド](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## メンテナー:

 > [Fosowl](https://github.com/Fosowl) | パリ時間

 > [antoineVIVIES](https://github.com/antoineVIVIES) | 台北時間

 > [steveh8758](https://github.com/steveh8758) | 台北時間

## スペシャルサンクス:

 > [tcsenpai](https://github.com/tcsenpai) および [plitc](https://github.com/plitc) バックエンドのDocker化にご協力いただきました

## スポンサー:

月額5ドル以上のスポンサー様（順不同）:
- **tatra-labs**

It appears that you have not provided the content of Part 4 of 4 for translation. Please paste the text you would like translated, and I will proceed as instructed.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---