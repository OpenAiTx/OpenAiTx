
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## ⚠️ お知らせ  
評価プロセスの前に、Dockerがデータベースをロードする際、環境の不一致によるエラーが時折発生する場合があります（これらはプロセスを停止しませんが、Dockerログに表示されます）。その結果、一部のデータベースが正常にロードされず、空のデータベースとなることがあります。これにより評価結果が異常に低くなる場合があります。  
👉 したがって、評価を実行する前にDockerログを確認し、エラーがないかチェックし、すべてのデータベースが正常にロードされていることを確認することを強く推奨します。

👉 カスタマイズされたエージェントスキャフォールドがサポートされる**提出ガイドライン**を更新しました。詳細な提出ガイドラインは[こちら](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true)をご覧ください。

## 📰 ニュース

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**: **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)** をリリースしました。Google ADKベースの実装で、モジュラー3マイクロサービス（エージェント、ユーザーシミュレータ、DB環境）アーキテクチャを採用しています。独自のエージェント、ユーザーシミュレータ、DB環境を簡単に入れ替え可能です。並列実行や[LiteLlm互換](https://docs.litellm.ai/docs/providers)のLLMプロバイダーにも対応。研究用途にはこの実装の使用を推奨します。

- [2026-02-08] 🔥🔥🔥 **[Bird-Interact論文](https://huggingface.co/papers/2510.05318)** が **ICLR 2026 (口頭発表)** に採択されました！リオでお会いしましょう 🇧🇷!  

- [2025-11-06] 🐛 **バグ修正** & 🐳 **Docker更新**: sqlglotバージョンを26.16.4に更新し、ユーザーシミュレータ用SQLパーサーがSQLを正しく解析できないバグを修正しました。`bird_interact_eval`環境で `pip install sqlglot==26.16.4` を実行することで修正できます。`bird_interact_eval`イメージも更新されたため、プルして `bird_interact_eval` コンテナを再作成できます。

- [2025-10-21] 🐳 **Docker更新**: Full DB Env用Dockerを追加しました。Base/Full DB Envと評価環境（`a-Interact`と`c-Interact`両方用）の3つのDockerイメージをDocker Hubに公開し、環境構築を簡略化しました。DBダンプのダウンロードやイメージの手動作成は不要です！

- [2025-10-08] 📝 **[Bird-Interact論文](https://huggingface.co/papers/2510.05318)** を公開しました！  
  インタラクティブなText-to-SQLベンチマークの詳細、手法、評価を掲載しています。  
  👉 [BIRD-Interact](https://bird-interact.github.io/)の背景やアイデアをぜひご覧ください。

- [2025-08-26] 🚀 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** セットをリリースしました！  
難易度が高く — 最良のLLMでも成功率はわずか **16.33%**、`c-interact`と`a-interact`部分では **10.0%** のみです。  
👉 詳細については、[プロジェクトウェブサイト](https://bird-interact.github.io/)をご覧ください。

- [2025-08-26] 📬 今週、**Ground Truth & Test cases** をメーリングリストに送信します。  
早期アクセスをご希望の場合は、サイトの指示に従ってメールを送信してください。**自動ダウンロード**が可能です。  

- [2025-08-26] 💾 さらに、ローカルでの研究を容易にするために、**[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** のSQLiteバージョンもリリースしました。  
完全版の **LiveSQLBench-Base** および **-Large** バージョンも近日公開予定です！

- [2025-08-22] **バグ修正**: Bird-Interact-Agentコードにて、phase-2のSQL評価時に保存されたphase-1 SQLが正常に実行できず、Phase-2の成功率が低下するバグを修正しました。このバグは、phase1 sqlがCREATE tableなどデータベース操作を行うタスクにのみ影響します。

## 🧸 概要

BIRD-INTERACTはインタラクティブなtext-to-SQLベンチマークであり、**ダイナミックな対話という観点からText-to-SQL評価を再構築します**。
この環境は階層型ナレッジベース、データベースドキュメント、関数駆動型ユーザーシミュレータを組み合わせ、実際のエンタープライズ環境をCRUD操作全体で再現します。
2つの厳格なテストモード：（1）受動的な**会話型インタラクション**と（2）能動的な**エージェンティックインタラクション**を提供し、各600件の注釈付きタスク（BI、CRUD操作など）には実行可能なテストケースが用意されています。
一般的な評価ではモデルとユーザーシミュレータ間で1,968～5,496ターンの対話が発生し、最先端の推論モデルでも現状**約24%**および**約18%**のタスクしか解決できておらず、本ベンチマークの難易度を示しています。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 2つの評価モード

BIRD-INTERACTは上記の2つの評価モードをサポートしています：

   - **c-Interact**：会話型インタラクションで、受動的モードかつワークフローは固定です。コードと詳細は`bird_interact_conv`にあります。
   - **a-Interact**：エージェンティックインタラクションで、能動的かつモデルが主導するダイナミックなワークフローです。コードと詳細は`bird_interact_agent`にあります。


### 🐣 ライト版

BIRD-INTERACTのライト版 `bird-interact-lite-exp` を公開します。これはPostgreSQL用の高品質な実タスク270件を含み、素早い実験の出発点として最適です。

### 🦜 フルバージョン

BIRD-INTERACTのフルバージョン `bird-interact-full` は600件のPostgreSQLタスクを含む包括的なベンチマークです。広範なSQL操作とユーザー問い合わせを網羅しています。フルバージョンは近日公開予定です。

### BIRD-INTERACT-FULLにおけるモデル性能結果

#### 1. **c-Interact Text-to-SQL** パフォーマンス
| 順位 | モデル名              | 正規化報酬         | 平均コスト（USD）/タスク | レベル               |
|:----:|:----------------------|:-------------------:|:-----------------------:|:--------------------:|
| 1    | Gemini-2.5-Pro        | 20.92               | $0.04                   | 🏆 優秀なチャット     |
| 2    | O3-Mini               | 20.27               | $0.07                   | 🏆 優秀なチャット     |
| 3    | Claude-Sonnet-4       | 18.35               | $0.29                   | 💎 良好なチャット     |
| 4    | Qwen-3-Coder-480B     | 17.75               | $0.11                   | 💎 良好なチャット     |
| 5    | Deepseek-Chat-V3.1    | 15.15               | $0.12                   | ✨ 標準               |
| 6    | Claude-Sonnet-3.7     | 13.87               | $0.29                   | ✨ 標準               |
| 7    | GPT-5                 | 12.58               | $0.08                   | ⚪ 基本               |

#### 2. **a-Interact Text-to-SQL** パフォーマンス
| 順位 | モデル名              | 正規化報酬         | 平均コスト（USD）/タスク | レベル                   |
|:----:|:----------------------|:-------------------:|:-----------------------:|:------------------------:|
| 1    | GPT-5                 | 25.52               | $0.24                   | 🏆 優秀な対話            |
| 2    | Claude-Sonnet-4       | 23.28               | $0.51                   | 🏆 優秀な対話            |
| 3    | Claude-Sonnet-3.7     | 17.45               | $0.60                   | 💎 良好な対話            |
| 4    | Gemini-2.5-Pro        | 17.33               | $0.22                   | 💎 良好な対話            |
| 5    | O3-Mini               | 16.43               | $0.06                   | ✨ 標準                  |
| 6    | Deepseek-Chat-V3.1    | 13.47               | $0.06                   | ✨ 標準                  |
| 7    | Qwen-3-Coder-480B     | 10.58               | $0.07                   | ⚪ 基本                  |

> \* 予算パラメータ：開始予算／ユーザー忍耐予算は、仮想通貨 *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> で測定されます。詳細は [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) を参照してください。

### Interaction-Time Scaling（ITS）

Interaction-Time Scaling（ITS）とは、モデルが複数回の対話を通じて最終的なパフォーマンスを継続的に向上させる能力を指します。この対話的パフォーマンスが、完全に仕様化された明確なタスクにおける理想化された単一ターンのモデル性能を上回る場合、**ITS法則**を満たすといいます。ユーザーの忍耐が増し、対話ターンが蓄積されることで、パフォーマンスが向上し続け、モデルが長時間の対話でも効果的なコミュニケーションを維持できることを示します。現在、ITS法則を満たすのは claude-3-7-sonnet のみです。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 環境セットアップ

1. bird-interact-lite データベース、bird-interact-full データベース、および評価環境用の Docker コンテナを実行します：
  
  > `bird-interact-lite` のみで評価したい場合は、環境セットアップの高速化のため [`postgresql_full` サービス](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) を `docker-compose.yml` でコメントアウトできます。
  
  環境を起動するには次のコマンドを実行してください：
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   データベースの初期化が完了するまで数分待ちます。
   
  ビルドの進行状況は以下で追跡できます。
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  完了した場合、エラーなしでログが表示されるはずです。

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  以前にコンテナを作成していて再作成したい場合は、次のコマンドを実行できます。
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   これはDocker Hubからの事前構築済みイメージを使用して3つのコンテナを起動します：
   - `bird_interact_postgresql`: bird-interact-lite用のPostgreSQLデータベース
   - `bird_interact_postgresql_full`: bird-interact-full用のPostgreSQLデータベース
   - `bird_interact_eval`: `a-Interact`および`c-Interact`両方の評価環境

   次のコマンドを実行することで評価環境を開始できます：
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. （オプション）環境を手動で構築する（イメージをゼロから作成したい場合）:
   - データベースダンプをダウンロード
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view)。解凍して `env/postgre_table_dumps` にリネームしてください。
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view)。解凍して `env/postgre_table_dumps_full` にリネームしてください。
   - `docker-compose.build.yml` を実行して環境を手動で構築します。

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. （推奨）データベースコンテナが正常に構築され、稼働していることを確認してください。

- コンテナの構築ログを表示し、データベースがエラーなく正常に構築されていることを確認します。
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   エラーが発生した場合、ログファイルに「インポート中にエラーが発生しました：」が出力されます。


-  データベースコンテナが正常であることを確認してください。
   
   提供されたPythonスクリプトを使用してデータベースメタデータを検証してください。
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   期待される結果:
   - **bird-interact-lite**: 
     - 📈 総データベース数: 18
     - 📋 総テーブル数: 175
     - 🔢 総カラム数: 2286
     - 📈 テーブルごとの平均行数: 1,038.48
     - 💾 総サイズ: 207.15 MB（おおよそ）
   - **bird-interact-full**: 
     - 📈 総データベース数: 22
     - 📋 総テーブル数: 244
     - 🔢 総カラム数: 2011
     - 📈 テーブルごとの平均行数: 1,121.19
     - 💾 総サイズ: 272.00 MB（おおよそ）


## 📦 データセット詳細

### データセットの説明

- **データベース:** 完全なPostgreSQLデータベースは [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) および [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) からダウンロードできます。
- **data:** 各データインスタンスには以下の主要な部分が含まれます:
   - `selected_database`: データベース名。  
   - `query`: 曖昧性のないユーザー問い合わせ。  
   - `amb_user_query`: 曖昧さを加えたユーザー問い合わせ。
   - `user_query_ambiguity`: ユーザー問い合わせに挿入された曖昧性。
   - `non_critical_ambiguity`: 並び順や上限などの非クリティカルな曖昧性。
   - `knowledge_ambiguity`: 外部知識をマスキングして生じた曖昧性。 
   - `sol_sql`: 正解SQLソリューション。  
   - `preprocess_sql`: ソリューションや予測を実行する前に実行するSQLクエリ。  
   - `clean_up_sql`: テストケース実行後、データベースの変更を元に戻すためのSQLクエリ。  
   - `test_cases`: 予測された修正SQLを検証するテストケースのセット。
   - `follow_up`: ラベル付けされたフォローアップ質問。
   - `external_knowledge`: 特定のタスクに関連する外部知識。

- **evaluation:** 評価コードは [`./evaluation`](./evaluation) ディレクトリにあります。
- **キュレーション:** BIRDチーム & Google Cloud
- **ライセンス:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace データセットカード:** PostgreSQL用 [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  および [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)；SQLite用 [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact)
### データセットの利用

自動クロールによるデータリークを防ぐため、GTソリューションSQLとテストケースはデータと一緒には含めていません。
bird-interact-liteまたはbird-interact-fullデータセットのグラウンドトゥルースおよびテストケースについては、タイトルに `[bird-interact-lite GT&Test Cases]` または `[bird-interact-full GT&Test Cases]` のタグを付けて [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) までメールを送ってください。自動的に送付されます。


### 公開データとグラウンドトゥルースおよびテストケースの結合

次に、以下のスクリプトを利用して公開データとグラウンドトゥルースおよびテストケースを結合します。

フルバージョンの例：
(1) 実行：
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
これにより、結合されたデータを含む新しいファイルが `/path/to/bird_interact_data.jsonl` に作成されます。

(2) 次に、元の公開データを結合データで置き換えます。

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

他のバージョン（bird-interact-lite、miniバージョンなど）についても同様です。パブリックデータ、正解データ、テストケースのパスを正しく設定し、その後パブリックデータを結合データに置き換えてください。




<!-- ### HuggingFaceからデータセットを使用する

以下のコマンドを使用して、HuggingFaceからデータセットをダウンロードできます:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
または、提供されたスクリプトを使用してデータセットの完全版をダウンロードし、異なる方言ごとに分割することもできます。

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 入力JSONLファイルのパス（HuggingFaceからデータセットをダウンロードしたい場合は空でも可）
  --output_folder path/to/output_dir # 分割ファイルの出力フォルダー
```

## フォルダー構成
```ultree
.
├── LICENSE
├── README.md
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
**a-interact** の実行に関する詳細は `./bird_interact_agent/README.md` に、**c-interact** については `./bird_interact_conv/README.md` に、**ADK ベースの実装**については `./BIRD-Interact-ADK/README.md` に記載されています。

## 📋 Todo リスト

- [x] 軽量版 bird-interact-lite (270) をリリース。
- [x] 会話型バージョン bird-interact-conv をリリース。
- [x] エージェントバージョン bird-interact-agent をリリース。
- [x] フル版 bird-interact-full (600) をリリース。
- [x] ADK ベースの実装 BIRD-Interact-ADK をリリース。
- [ ] SFT / RL ユーザーシミュレータ

## 謝辞
本プロジェクトの改善に貢献した実りある議論と貴重な洞察をいただいた **Irina Saparina**、**Mohammadreza Pourreza**、**Mehdi Bouzouina**、**Hailong Li**、**Jiatong Shi**、および **Shinji Watanabe** 教授に心より感謝申し上げます。

## 作成者:
BIRD チーム & Google Cloud







## 引用

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```


## 変更履歴

- [2025-11-06] 🐛 **バグ修正** & 🐳 **Dockerアップデート**: sqlglotのバージョンを26.16.4に更新し、ユーザーシミュレータ用SQLパーサーがSQLを正しく解析できないバグを修正しました。`bird_interact_eval`環境で `pip install sqlglot==26.16.4` を実行して再インストールすることで修正可能です。`bird_interact_eval`イメージも更新されているため、イメージをプルしてコンテナを再作成することもできます。
- [2025-10-21] 🐳 **Dockerアップデート**: Full DB Env用のDockerを追加しました。また、環境構築を容易にするため、3つのDockerイメージ（Base/Full DB Envおよび両方の評価環境 `a-Interact` と `c-Interact`）をDocker Hubに公開しました。DBダンプをダウンロードしたりイメージを手動で作成する必要はありません！Docker Hubから最新イメージをプルし、コンテナを再作成してください。例：`docker compose down -v && docker compose pull && docker compose up -d --force-recreate`
- [2025-08-22]  🐛 **バグ修正**: phase-2 SQLの評価時に、保存されたphase-1 SQLが正しく実行できず、Phase-2の成功率が低下するバグを修正しました。このバグは、phase1 SQLがデータベース上で何らかの操作（例：CREATE tableなど）を行うタスクのみに影響します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---