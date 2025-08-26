<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">簡體中文</a></p>
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

## 最新消息
- [2025-08-22] **錯誤修正**：在 Bird-Interact-Agent 程式碼中，我們修復了一個錯誤，當評估第二階段 SQL 時，儲存的第一階段 SQL 無法成功執行，導致第二階段成功率降低。此錯誤僅影響第一階段 SQL 涉及資料庫操作（如 CREATE table 等）的任務。

## 🧸 概覽

BIRD-INTERACT 是一個互動式 text-to-SQL 基準，**以動態互動的視角重新定義 Text-to-SQL 評估方式**。
此環境融合了分層知識庫、資料庫文件以及基於函數的用戶模擬器，重現真實企業環境下的完整 **CRUD** 操作流程。
它提供兩種嚴謹的測試模式：(1) 被動式 **會話互動** 以及 (2) 主動式 **代理互動**，涵蓋 600 個註釋任務，包括商業智慧（BI）、CRUD 操作等，每個任務都配有可執行的測試案例。
典型評估會引發模型與用戶模擬器間 1,968 到 5,496 次互動回合，而目前最先進的推理模型僅解決了 **約 24%** 與 **約 18%** 的任務，凸顯了此基準的挑戰性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 兩種評估模式

BIRD-INTERACT 支援上述兩種評估模式：

   - **c-Interact**：會話互動，屬於被動模式，流程固定。程式碼與詳細資訊可見於 `bird_interact_conv`。
   - **a-Interact**：代理互動，屬於具身主動模式，流程由模型主導且動態。程式碼與詳細資訊可見於 `bird_interact_agent`。


### 🐣 輕量版

我們推出了 BIRD-INTERACT 的輕量版 `bird-interact-lite-exp`，包含 270 個專為 PostgreSQL 設計的高品質真實世界任務。這是快速實驗的良好起點。

### 🦜 完整版

BIRD-INTERACT 的完整版 `bird-interact-full` 是一個全面的基準測試，涵蓋 600 個 PostgreSQL 任務，涵蓋各種 SQL 操作與用戶查詢。完整版即將推出。

### BIRD-INTERACT 輕量版模型效能結果

#### 1. **c-Interact** 效能
| 排名 | 模型名稱           | 標準化獎勵分數 | 等級            |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 卓越對話      |
| 2    | GPT-4o             | 30.33 | 💎 優良對話      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 優良對話      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 標準          |
| 5    | DeepSeek-R1        | 21.74 | ✨ 標準          |
| 6    | Qwen3              | 20.33 | ⚪ 基礎          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基礎          |

#### 2. **a-Interact** 效能
| 排名 | 模型名稱           | 預算參數*        | 平均步驟/任務 | 平均花費 (USD)/任務 | 標準化獎勵分數 | 等級                  |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 卓越互動             |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 優良互動             |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 優良互動             |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 標準                 |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 標準                 |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基礎                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基礎                 |

> \* 預算參數：起始預算／用戶耐心預算，以我們的虛擬貨幣 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 為單位。詳情請參閱 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 互動時間擴展 (ITS)

互動時間擴展 (ITS) 指的是模型透過多輪互動，持續提升最終效能的能力。當互動效能超越模型在完全明確、無歧義任務上的理想單輪效能時，則稱其符合 **ITS 法則**。隨著用戶耐心增加、互動輪數累積，效能持續提升，展現模型能在長時間對話中維持有效溝通。目前僅發現 claude-3-7-sonnet 符合 ITS 法則。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 資料集詳情

### 資料集說明

- **資料庫：** 完整的 PostgreSQL 資料庫可從 [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) 下載。更多細節請參考 [快速評估](#quick-eval) 部分。
- **data：** 每筆資料包含以下主要部分：
   - `selected_database`：資料庫名稱。  
   - `query`：明確的使用者查詢。  
   - `amb_user_query`：注入歧義的使用者查詢。
   - `user_query_ambiguity`：注入到使用者查詢中的歧義。
   - `non_critical_ambiguity`：非關鍵性歧義，如排序、限制等。
   - `knowledge_ambiguity`：由遮蔽外部知識產生的歧義。 
   - `sol_sql`：標準答案 SQL 解決方案。  
   - `preprocess_sql`：執行解決方案或預測前要運行的 SQL 查詢。  
   - `clean_up_sql`：測試案例後執行、用於還原資料庫變更的 SQL 查詢。  
   - `test_cases`：一組用於驗證預測修正 SQL 的測試案例。
   - `follow_up`：標註的追問問題。
   - `external_knowledge`：與特定任務相關的外部知識。

- **evaluation：** 評估程式碼可在 [`./evaluation`](./evaluation) 目錄中取得。
- **策劃單位：** BIRD 團隊 & Google Cloud
- **授權：** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 資料集卡片：** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 資料集用途

為避免自動爬取造成資料外洩，資料集中不包含 GT 解決方案 sql 及測試案例。
請以標題加入標籤 `[bird-interact-lite GT&Test Cases]`，發信至 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) 取得完整內容，系統將自動寄送。


<!-- ### 從 HuggingFace 使用資料集

你可以使用以下指令從 HuggingFace 下載資料集：
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

或者，您可以使用提供的腳本下載資料集的完整版本，並將其分割成不同的方言。
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # 輸入 JSONL 檔案的路徑（如果要從 HuggingFace 下載資料集，可以為空）
  --output_folder path/to/output_dir # 分割檔案的輸出資料夾
```

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
有關執行 **a-interact** 的詳細資訊可在 `./bird_interact_agent/README.md` 中找到；而 **c-interact** 的資訊則在 `./bird_interact_conv/README.md` 中。


## 📋 待辦事項清單

- [x] 發布精簡版，bird-interact-lite (270)。
- [x] 發布對話版，bird-interact-conv。
- [x] 發布代理人版，bird-interact-agent。
- [x] 發布完整版，bird-interact-full (600)。
- [ ] SFT / RL 使用者模擬器

## 建立者：
BIRD 團隊 & Google Cloud


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---