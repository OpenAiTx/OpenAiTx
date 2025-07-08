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

## 🧸 概要

BIRD-INTERACTは、インタラクティブなText-to-SQLベンチマークであり、**動的なインタラクションの観点からText-to-SQL評価を再構築します**。
この環境は、階層的なナレッジベース、データベースドキュメント、関数駆動型ユーザーシミュレータを組み合わせ、エンタープライズ環境を忠実に再現し、**CRUD**全操作をカバーします。
厳格な2つのテストモードを提供します：(1) 受動的な**会話型インタラクション**、(2) 能動的な**エージェント型インタラクション**。600件のアノテーション付きタスク（BI、CRUD操作等を含む）を収録し、各タスクには実行可能なテストケースが付属しています。
一般的な評価では、モデルとユーザーシミュレータ間で1,968～5,496ターンのインタラクションが発生し、最先端の推論モデルでも現在**約24%**および**約18%**のタスクしか解決できておらず、ベンチマークの難易度の高さを示しています。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 2つの評価モード

BIRD-INTERACTは、前述の2つの評価モードをサポートしています：

   - **c-Interact**：会話型インタラクション（受動的モード）で、ワークフローは固定されています。コードおよび詳細は `bird_interact_conv` にあります。
   - **a-Interact**：エージェント型インタラクション（能動的モード）で、ワークフローは動的でモデル主導です。コードおよび詳細は `bird_interact_agent` にあります。

### 🐣 Liteバージョン

BIRD-INTERACTのLiteバージョン `bird-interact-lite-exp` を公開しています。これはPostgreSQL向けに特化した270件の高品質な実タスクを含んでおり、迅速な実験の出発点として最適です。

### 🦜 フルバージョン

BIRD-INTERACTのフルバージョン `bird-interact-full` は、PostgreSQL向けの600件のタスクを網羅した総合ベンチマークです。幅広いSQL操作とユーザー問い合わせをカバーしています。フルバージョンは近日公開予定です。

### BIRD-INTERACT Liteにおけるモデル性能結果

#### 1. **c-Interact** パフォーマンス
| 順位 | モデル名           | 正規化報酬 | レベル              |
|:------:|--------------------|:-------:|:----------------:|
| 1    | o3-mini            | 33.04 | 🏆 優秀チャット      |
| 2    | GPT-4o             | 30.33 | 💎 良好チャット      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 良好チャット      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 標準              |
| 5    | DeepSeek-R1        | 21.74 | ✨ 標準              |
| 6    | Qwen3              | 20.33 | ⚪ 基本              |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基本              |

#### 2. **a-Interact** パフォーマンス
| 順位 | モデル名           | バジェットパラメータ* | 平均ターン/タスク | 平均コスト (USD)/タスク | 正規化報酬 | レベル                    |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 優秀インタラクション     |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 良好インタラクション      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 良好インタラクション      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 標準                    |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 標準                    |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基本                    |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基本                    |

> \* バジェットパラメータ：開始バジェット／ユーザー忍耐バジェット（仮想通貨 *bird-coin*<img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">で計測）。詳細は [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) を参照してください。

### インタラクション時間スケーリング（ITS）

インタラクション時間スケーリング（ITS）は、モデルがマルチターンのインタラクションを通じて最終性能を継続的に向上できる能力を指します。このインタラクティブな性能が、完全に明確化された単一ターンタスクでの理想性能を上回った場合、**ITS法則**を満たすといいます。ユーザー忍耐が増し、インタラクションターンが重なるにつれ性能が向上し続けることで、モデルが長期的な対話でも効果的なコミュニケーションを維持できることを示します。現時点ではclaude-3-7-sonnetのみがITS法則を満たしています。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 データセット詳細

### データセット説明

- **データベース：** 完全なPostgreSQLデータベースは[Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view)からダウンロード可能です。[Quick Eval](#quick-eval)セクションもご参照ください。
- **data：** 各データインスタンスは以下の主要部分を含みます：
   - `selected_database`: データベース名  
   - `query`: 曖昧さのないユーザー問い合わせ  
   - `amb_user_query`: 曖昧さを注入したユーザー問い合わせ
   - `user_query_ambiguity`: ユーザー問い合わせに注入された曖昧さ
   - `non_critical_ambiguity`: 並び順や制限などの非重要な曖昧さ
   - `knowledge_ambiguity`: マスクされた外部知識によって生じる曖昧さ。
   - `sol_sql`: 正解となるSQLソリューション。
   - `preprocess_sql`: ソリューションや予測を実行する前に実行するSQLクエリ。
   - `clean_up_sql`: テストケースの後で、データベースに加えられた変更を元に戻すために実行するSQLクエリ。
   - `test_cases`: 予測された修正SQLを検証するためのテストケースのセット。
   - `follow_up`: ラベル付けされたフォローアップ質問。
   - `external_knowledge`: 特定のタスクに関連する外部知識。

- **evaluation:** 評価用コードは [`./evaluation`](./evaluation) ディレクトリにあります。
- **Curated by:** BIRDチーム & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### データセットの用途

自動クロールによるデータリークを防ぐため、GTソリューションSQLおよびテストケースはデータと共に含めていません。
完全なセットが必要な場合は、タイトルに `[bird-interact-lite GT&Test Cases]` タグを付けて [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) までメールしてください。自動で送信されます。


<!-- ### HuggingFaceからデータセットを利用する

以下のコマンドでHuggingFaceからデータセットをダウンロードできます:
```bash
from datasets import load_dataset
# データセットのflashバージョンをロード
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# データセットのフルバージョンをロード（近日公開）
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

または、付属のスクリプトを使ってデータセットのフルバージョンをダウンロードし、異なる方言に分割できます。
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 入力JSONLファイルのパス（HuggingFaceからデータセットをダウンロードする場合は空でも可）
  --output_folder path/to/output_dir # 分割ファイルの出力フォルダ
``` -->

## フォルダ構成
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
**a-interact** の実行方法の詳細は `./bird_interact_agent/README.md` に、**c-interact** については `./bird_interact_conv/README.md` に記載しています。


## 📋 Todoリスト

- [x] ライト版リリース、bird-interact-lite (270)。
- [x] 会話型バージョンリリース、bird-interact-conv。
- [x] エージェントバージョンリリース、bird-interact-agent。
- [ ] フル版リリース、bird-interact-full (600)。
- [ ] SFT / RL ユーザーシミュレータ

## 制作:
BIRDチーム & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---