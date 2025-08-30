
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

## 📰 ニュース

- [2025-08-26] 🚀 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** セットのリリースを発表できることを嬉しく思います。  
これは難易度が高く、最高のLLMでも成功率は**16.33%**で、`c-interact`と`a-interact`部分ではわずか**10.0%**です。  
👉 詳細については、[プロジェクト公式サイト](https://bird-interact.github.io/)をご覧ください。

- [2025-08-26] 📬 **Ground Truth & Test cases** を今週メーリングリストに送信します。  
早期アクセスを希望される場合は、サイトの指示に従いメールを送信すると**自動ダウンロード**が可能です。  

- [2025-08-26] 💾 さらに、ローカル研究が簡単になるよう **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** のSQLiteバージョンもリリースしました。  
完全版の **LiveSQLBench-Base** および **-Large** も近日公開予定です！

- [2025-08-22] **バグ修正**: Bird-Interact-Agentコードにて、phase-2 SQL評価時に保存されたphase-1 SQLが正常に実行されず、Phase-2の成功率が低下するバグを修正しました。このバグは、phase1 SQLがDBに対しCREATE table等の操作を行うタスクにのみ影響します。

## 🧸 概要

BIRD-INTERACTはインタラクティブなText-to-SQLベンチマークであり、**動的インタラクションの観点からText-to-SQL評価を再定義します**。
この環境は階層的な知識ベース、データベースドキュメント、関数駆動型ユーザーシミュレータを融合し、企業環境の本格的な**CRUD**操作を再現します。
2つの厳格なテストモード：(1) 受動的な**会話型インタラクション**と(2) 能動的な**エージェント型インタラクション**を提供し、Business Intelligence (BI)、CRUD操作などを含む600件の注釈付きタスクを網羅し、それぞれ実行可能なテストケースで保護されています。
典型的な評価ではモデルとユーザーシミュレータ間で1,968～5,496回のインタラクションが発生し、最先端推論モデルでもタスク解決率は**約24%**および**約18%**にとどまり、ベンチマークの難易度を示しています。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 2つの評価モード

BIRD-INTERACTは、上記の2つの評価モードをサポートしています：

   - **c-Interact**: 会話型インタラクションで、受動的なモードです。ワークフローは固定されており、コードや詳細は `bird_interact_conv` にあります。
   - **a-Interact**: エージェント型インタラクションで、能動的かつモデル主導の動的なワークフローです。コードや詳細は `bird_interact_agent` にあります。

### 🐣 ライト版

BIRD-INTERACTのライト版 `bird-interact-lite-exp` を公開しています。これはPostgreSQL用に特化した270件の高品質な実タスクを含み、迅速な実験の出発点に適しています。

### 🦜 フルバージョン

BIRD-INTERACTのフルバージョン `bird-interact-full` は、PostgreSQL用600件のタスクを網羅した総合ベンチマークです。幅広いSQL操作とユーザークエリをカバーします。フルバージョンは近日公開予定です。

### BIRD-INTERACT Liteにおけるモデル性能結果

#### 1. **c-Interact** の性能
| ランク | モデル名          | 正規化報酬 | レベル           |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 優秀なチャット |
| 2    | GPT-4o             | 30.33 | 💎 良好なチャット  |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 良好なチャット  |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 標準           |
| 5    | DeepSeek-R1        | 21.74 | ✨ 標準           |
| 6    | Qwen3              | 20.33 | ⚪ 基本           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基本           |

#### 2. **a-Interact** の性能
| ランク | モデル名          | 予算パラメータ* | 平均ステップ/タスク | 平均コスト(USD)/タスク | 正規化報酬 | レベル                 |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 優秀なインタラクション |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 良好なインタラクション  |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 良好なインタラクション  |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 標準                   |

| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 標準                  |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ ベーシック            |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ ベーシック            |

> \* 予算パラメータ：スタート予算/ユーザ忍耐予算は、仮想通貨 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> で計測されます。[bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) を参照してください。

### インタラクション時間スケーリング (ITS)

インタラクション時間スケーリング（ITS）は、モデルが複数ターンの対話を通じて最終的な性能を継続的に向上できる能力を指します。この対話性能が、完全に特定され曖昧さのない理想的な単一ターン性能を超えた場合、**ITS則**を満たすと言います。ユーザの忍耐力が増し、対話ターンが蓄積されることで性能が向上し続け、モデルが長期的な対話でも効果的なコミュニケーションを維持できることを示します。現時点では、claude-3-7-sonnetのみがITS則を満たすことが確認されています。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 データセット詳細

### データセットの説明

- **データベース:** 完全なPostgreSQLデータベースは[Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view)からダウンロード可能です。[Quick Eval](#quick-eval) セクションも参照してください。
- **data:** 各データインスタンスは以下の主要部分を含みます:
   - `selected_database`: データベース名  
   - `query`: 明確なユーザクエリ  
   - `amb_user_query`: 曖昧さを注入したユーザクエリ
   - `user_query_ambiguity`: ユーザクエリに注入された曖昧さ
   - `non_critical_ambiguity`: 順序やlimitなどの非重要な曖昧さ
   - `knowledge_ambiguity`: 外部知識をマスクすることで生じる曖昧さ 
   - `sol_sql`: 正解SQLソリューション  
   - `preprocess_sql`: ソリューションや予測を実行する前に実行するSQLクエリ  
   - `clean_up_sql`: テストケース後にデータベースの変更を元に戻すためのSQLクエリ  
   - `test_cases`: 予測された修正SQLを検証するためのテストケースのセット
   - `follow_up`: ラベル付けされたフォローアップ質問
   - `external_knowledge`: 特定タスクに関連する外部知識

- **evaluation:** 評価コードは[`./evaluation`](./evaluation) ディレクトリにあります。
- **作成:** BIRD Team & Google Cloud
- **ライセンス:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### データセットの用途

自動クロールによるデータ漏洩を避けるため、GTソリューションのSQLおよびテストケースはデータと一緒に含めていません。
完全なセットが必要な場合は、タイトルに `[bird-interact-lite GT&Test Cases]` のタグを付けて [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) までメールしてください。自動で送信されます。


<!-- ### HuggingFaceからデータセットを利用する

以下のコマンドを使って、HuggingFaceからデータセットをダウンロードできます。
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
**a-interact** の実行に関する詳細は `./bird_interact_agent/README.md` に、**c-interact** の詳細は `./bird_interact_conv/README.md` に記載されています。

## 📋 Todoリスト

- [x] ライト版、bird-interact-lite (270) をリリース。
- [x] 会話版、bird-interact-conv をリリース。
- [x] エージェント版、bird-interact-agent をリリース。
- [x] フルバージョン、bird-interact-full (600) をリリース。
- [ ] SFT / RL ユーザーシミュレーター

## 作成者:
BIRD Team & Google Cloud





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---