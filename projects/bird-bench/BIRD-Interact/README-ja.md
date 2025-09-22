
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
評価プロセスの前に、Dockerがデータベースをロードする際、環境の不一致によりエラーが時々発生することがあります（これらはプロセスを終了させませんが、Dockerログに表示されます）。その結果、一部のデータベースが正常にロードされず、空のデータベースとなる場合があります。これにより、評価結果が異常に低くなることがあります。  
👉 したがって、**評価を実行する前に**Dockerログでエラーがないか確認し、すべてのデータベースが正常にロードされていることを必ずご確認ください。

## 📰 最新情報

- [2025-08-26] 🚀 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** セットのリリースを発表します！  
難易度が高く、最先端LLMでも成功率はわずか**16.33%**、`c-interact`と`a-interact`部分では**10.0%**にとどまっています。  
👉 詳細は[プロジェクトサイト](https://bird-interact.github.io/)をご覧ください。

- [2025-08-26] 📬 今週、**Ground Truth & Test cases** をメーリングリストに送付予定です。  
早期アクセスをご希望の方は、サイト記載の手順でメールを送信し、**自動ダウンロード**をご利用ください。  

- [2025-08-26] 💾 さらに、ローカル研究の利便性向上のため、SQLite版の**[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** も公開しました。  
完全な **LiveSQLBench-Base** および **-Large** バージョンも近日公開予定です！

- [2025-08-22] **バグ修正**: Bird-Interact-Agentコードで、Phase-2 SQL評価時に保存されているPhase-1 SQLが正常に実行できず、Phase-2の成功率が低下するバグを修正しました。このバグは、Phase1 SQLがCREATE tableなどのDB操作を行うタスクにのみ影響します。

## 🧸 概要

BIRD-INTERACTは、インタラクティブなText-to-SQLベンチマークであり、**動的インタラクションの観点からText-to-SQL評価を再定義します**。
この環境は、階層型ナレッジベース、データベースドキュメント、機能駆動型ユーザーシミュレータを融合し、完全な**CRUD**操作を通じて本格的な企業環境を再現します。
2つの厳格なテストモードを提供します：(1) パッシブな**会話型インタラクション**と(2) アクティブな**エージェント型インタラクション**で、BI（ビジネスインテリジェンス）、CRUD操作などを含む600件のアノテーション付きタスクにわたり、各タスクは実行可能なテストケースによって保護されています。
典型的な評価では、モデルとユーザーシミュレータ間で1,968～5,496回のインタラクションターンが発生し、最先端の推論モデルは現在**約24％**および**約18％**のタスクしか解決できず、ベンチマークの難易度を浮き彫りにしています。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 2つの評価モード

BIRD-INTERACTは前述の2つの評価モードをサポートしています：

   - **c-Interact**: 会話型インタラクション。パッシブモードでワークフローは固定されています。コードや詳細情報は `bird_interact_conv` にあります。
   - **a-Interact**: エージェント型インタラクション。モデル主導の動的なワークフローとなるアクティブモードです。コードや詳細情報は `bird_interact_agent` にあります。


### 🐣 ライト版

BIRD-INTERACTのライト版 `bird-interact-lite-exp` を公開しています。これはPostgreSQL向けに特化した高品質な270件の実タスクを含んでおり、迅速な実験を行うのに適した入門版です。

### 🦜 フルバージョン

BIRD-INTERACTのフルバージョン `bird-interact-full` は、PostgreSQL向けに600件のタスクを含む包括的なベンチマークです。SQL操作やユーザークエリの広範な範囲をカバーします。フルバージョンは近日公開予定です。

### BIRD-INTERACTライト版におけるモデル性能結果

#### 1. **c-Interact** 性能
| 順位 | モデル名           | 正規化報酬値 | レベル         |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 優秀なチャット |
| 2    | GPT-4o             | 30.33 | 💎 良質なチャット  |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 良質なチャット  |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 標準           |
| 5    | DeepSeek-R1        | 21.74 | ✨ 標準           |
| 6    | Qwen3              | 20.33 | ⚪ 基本           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基本           |

#### 2. **a-Interact** 性能
| 順位 | モデル名           | 予算パラメータ* | 平均ステップ数/タスク | 平均コスト(USD)/タスク | 正規化報酬値         | レベル                |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 優れた対話性        |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 良好な対話性        |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 良好な対話性        |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 標準的               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 標準的               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基本的               |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基本的               |

> \* 予算パラメータ：開始予算/ユーザー忍耐予算は、仮想通貨 *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> で測定します。詳細は [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) を参照してください。

### インタラクション時間スケーリング（ITS）

インタラクション時間スケーリング（ITS）は、モデルが複数ターンの対話を通じて、最終的なパフォーマンスを継続的に向上させる能力を指します。この対話型パフォーマンスが、完全に指定された曖昧さのないタスクでの理想的な単一ターンのパフォーマンスを上回った場合、**ITS法則**を満たしていると言えます。ユーザーの忍耐力が増し、対話ターンが蓄積されるにつれ、パフォーマンスは向上し続け、モデルが長期にわたる効果的なコミュニケーションを維持できることを示します。現時点では、claude-3-7-sonnet のみが ITS 法則を満たしています。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 データセット詳細

### データセット説明

- **データベース:** 完全な PostgreSQL データベースは [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) からダウンロードできます。詳細は [Quick Eval](#quick-eval) セクションをご覧ください。
- **data:** 各データインスタンスは以下の主要な部分を含みます:
   - `selected_database`: データベース名  
   - `query`: 曖昧さのないユーザークエリ  
   - `amb_user_query`: 曖昧さを注入したユーザークエリ
   - `user_query_ambiguity`: ユーザークエリに注入された曖昧さ
   - `non_critical_ambiguity`: 順序や制限などの非クリティカルな曖昧さ
   - `knowledge_ambiguity`: 外部知識のマスキングによって生じる曖昧さ 
   - `sol_sql`: 正解のSQLソリューション  
   - `preprocess_sql`: ソリューションや予測を実行する前に実行するSQLクエリ  
   - `clean_up_sql`: データベースに加えた変更を元に戻すためにテストケース後に実行するSQLクエリ  
   - `test_cases`: 予測された修正SQLを検証するためのテストケースのセット
   - `follow_up`: ラベル付けされたフォローアップ質問
   - `external_knowledge`: 特定のタスクに関連する外部知識

- **evaluation:** 評価コードは [`./evaluation`](./evaluation) ディレクトリにあります。
- **Curated by:** BIRD Team & Google Cloud
- **ライセンス:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace データセットカード:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### データセットの利用

自動クロールによるデータリークを防ぐため、GTソリューションSQLおよびテストケースはデータと一緒に含めていません。
完全なセットが必要な場合は、タイトルに `[bird-interact-lite GT&Test Cases]` を含めて [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) までメールしてください。自動的に送信されます。


<!-- ### HuggingFaceからデータセットを利用する

以下のコマンドを使ってHuggingFaceからデータセットをダウンロードできます:
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
**a-interact** の実行方法の詳細は `./bird_interact_agent/README.md` に記載されています。また、**c-interact** の詳細は `./bird_interact_conv/README.md` に記載されています。

## 📋 Todo リスト

- [x] ライト版、bird-interact-lite (270) をリリース。
- [x] 会話版、bird-interact-conv をリリース。
- [x] エージェント版、bird-interact-agent をリリース。
- [x] フル版、bird-interact-full (600) をリリース。
- [ ] SFT / RL によるユーザーシミュレータ

## 作成者:
BIRD チーム & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---