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

## 🧸 概覽

BIRD-INTERACT 是一個互動式 text-to-SQL 基準，**以動態互動的視角重新定義 Text-to-SQL 的評估方式**。
該環境融合了階層式知識庫、資料庫文件以及以功能為導向的用戶模擬器，重現企業環境下真實的全方位 **CRUD** 操作。
它提供兩種嚴謹的測試模式：(1) 被動的 **對話互動**，以及 (2) 主動的 **代理互動**，涵蓋 600 個帶註釋的任務，包括商業智慧（BI）、CRUD 操作等，每一項任務均配有可執行的測試案例。
典型的評估會觸發模型與用戶模擬器之間 1,968-5,496 次互動回合，而現有最先進的推理模型僅能解決 **約 24%** 及 **約 18%** 的任務，凸顯該基準的挑戰性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 兩種評估模式

如上所述，BIRD-INTERACT 支援兩種評估模式：

   - **c-Interact**：對話互動，是一種被動模式，流程固定。相關程式碼和詳細資訊請參見 `bird_interact_conv`。
   - **a-Interact**：代理互動，是一種具體現性的主動模式，流程動態且由模型主導。相關程式碼和詳細資訊請參見 `bird_interact_agent`。

### 🐣 精簡版

我們發布了 BIRD-INTERACT 的精簡版 `bird-interact-lite-exp`，包含 270 個高品質、針對 PostgreSQL 的真實世界任務。這是快速實驗的良好起點。

### 🦜 完整版

BIRD-INTERACT 的完整版 `bird-interact-full` 是一套全面的基準，包含 600 個針對 PostgreSQL 的任務，涵蓋廣泛的 SQL 操作和用戶查詢。完整版即將推出。

### BIRD-INTERACT Lite 的模型效能結果

#### 1. **c-Interact** 效能
| 排名 | 模型名稱            | 標準化獎勵 | 等級              |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 優異對話      |
| 2    | GPT-4o             | 30.33 | 💎 良好對話      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 良好對話      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 標準           |
| 5    | DeepSeek-R1        | 21.74 | ✨ 標準           |
| 6    | Qwen3              | 20.33 | ⚪ 基本           |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基本           |

#### 2. **a-Interact** 效能
| 排名 | 模型名稱            | 預算參數*   | 平均回合/任務 | 平均花費 (美元)/任務 | 標準化獎勵 | 等級                  |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 優異互動          |
| 2    | o3-mini            | 6/6 | 7.8  | $0.0754 | 21.07 | 💎 良好互動          |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 良好互動          |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 標準              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 標準              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基本              |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基本              |

> \* 預算參數：起始預算/用戶耐心預算，以我們的虛擬貨幣 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 為單位。詳細資訊請參見 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 互動時間擴展性（ITS）

互動時間擴展性（ITS）指模型能夠通過多輪互動持續提升其最終效能。當這種互動效能超越模型在完全明確、無歧義任務上的單輪理想效能時，我們認為其符合 **ITS 法則**。隨著用戶耐心增加與互動回合積累，效能不斷提升，展現出模型能在長時間對話中保持有效溝通。目前僅有 claude-3-7-sonnet 符合 ITS 法則。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 數據集詳情

### 數據集說明

- **資料庫：** 完整的 PostgreSQL 資料庫可從 [Google Drive 下載](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view)。更多詳情請參見 [快速評測](#quick-eval) 部分。
- **data：** 每個數據實例包含以下主要部分：
   - `selected_database`：資料庫名稱。  
   - `query`：無歧義的用戶查詢。  
   - `amb_user_query`：帶有注入歧義的用戶查詢。
   - `user_query_ambiguity`：注入到用戶查詢中的歧義。
   - `non_critical_ambiguity`：非關鍵性的歧義，如排序、限制等。
   - `knowledge_ambiguity`: 由被遮蔽的外部知識產生的歧義。
   - `sol_sql`: 標準答案的 SQL 解決方案。
   - `preprocess_sql`: 在執行解決方案或預測之前需要執行的 SQL 查詢。
   - `clean_up_sql`: 測試案例後執行，用於還原對資料庫所做更改的 SQL 查詢。
   - `test_cases`: 用於驗證預測修正後 SQL 的一組測試案例。
   - `follow_up`: 標註的後續問題。
   - `external_knowledge`: 與特定任務相關的外部知識。

- **評估:** 評估程式碼可於 [`./evaluation`](./evaluation) 目錄中取得。
- **策劃團隊:** BIRD 團隊 & Google Cloud
- **授權條款:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 資料集卡片:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 資料集用途

為避免自動爬蟲造成的資料洩漏，我們未在資料中包含 GT 解答 sql 及測試案例。
如需完整資料，請寄信至 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)，
信件標題請加上 `[bird-interact-lite GT&Test Cases]`，系統將自動寄送完整資料集。


<!-- ### 從 HuggingFace 使用資料集

你可以使用以下指令從 HuggingFace 下載資料集：
```bash
from datasets import load_dataset
# 載入精簡版本資料集
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# 載入完整版資料集（即將推出）
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

或者你可以使用提供的腳本下載完整版資料集並依不同方言切割：
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 輸入 JSONL 檔案路徑（如要從 HuggingFace 下載資料集可留空）
  --output_folder path/to/output_dir # 分割檔案的輸出資料夾
``` -->

## 資料夾結構
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
有關如何執行 **a-interact** 的詳細資訊請參見 `./bird_interact_agent/README.md`；**c-interact** 的資訊則請參見 `./bird_interact_conv/README.md`。


## 📋 待辦清單

- [x] 發布精簡版，bird-interact-lite (270)。
- [x] 發布對話版，bird-interact-conv。
- [x] 發布代理人版，bird-interact-agent。
- [ ] 發布完整版 bird-interact-full (600)。
- [ ] SFT / RL 使用者模擬器

## 製作團隊：
BIRD 團隊 & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---