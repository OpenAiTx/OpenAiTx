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

## ⚠️ 公告  
請注意，在您開始評測流程前，Docker 載入資料庫時，因環境不一致偶爾會出現錯誤（這些錯誤不會終止流程，但會出現在 Docker 日誌中）。因此，某些資料庫可能無法正確載入，導致資料庫為空，進而造成評測結果異常偏低。  
👉 因此，我們強烈建議您在執行評測**前**，先檢查 Docker 日誌是否有任何錯誤，並確認所有資料庫皆已成功載入。

## 📰 最新消息

- [2025-08-26] 🚀 我們很高興宣布 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** 集正式釋出！  
這是一組高難度資料集——目前最佳 LLM 僅達成 **16.33%** 成功率，`c-interact` 與 `a-interact` 部分僅 **10.0%**。  
👉 詳細資訊請見我們的[專案網站](https://bird-interact.github.io/)。

- [2025-08-26] 📬 本週將透過郵件列表發送 **標準答案與測試案例**。  
如需提前取得，請依網站說明寄信，即可**自動下載**。  

- [2025-08-26] 💾 另外，我們也釋出了 SQLite 版本的 **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**，方便本地端研究。  
完整版 **LiveSQLBench-Base** 及 **-Large** 即將推出！

- [2025-08-22] **錯誤修正**：Bird-Interact-Agent 程式碼中修正了一個錯誤：在評測 phase-2 SQL 時，儲存的 phase-1 SQL 無法成功執行，導致 Phase-2 成功率降低。此錯誤僅影響 phase1 sql 有對資料庫進行操作（如 CREATE table 等）的任務。

## 🧸 總覽

BIRD-INTERACT 是一套互動式 text-to-SQL 基準，**以動態互動視角重新構想 Text-to-SQL 評測**。
此環境結合階層式知識庫、資料庫文件及函數驅動的用戶模擬器，重現企業級環境下完整 **CRUD** 操作的真實場景。
它提供兩種嚴謹的測試模式：（1）被動式**對話互動**與（2）主動式**代理互動**，涵蓋600個帶標註的任務，包括商業智慧（BI）、CRUD 操作等，每項任務均由可執行的測試案例保護。
典型評估會觸發 1,968-5,496 次模型與用戶模擬器的互動回合，而先進的推理模型目前僅能解決**約24%**與**約18%**的任務，突顯了此基準的挑戰性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 兩種評估模式

BIRD-INTERACT 支援上述兩種評估模式：

   - **c-Interact**：對話互動，屬於被動模式，流程是固定的。相關程式碼與詳細資訊可參見 `bird_interact_conv`。
   - **a-Interact**：代理互動，屬於具身主動模式，流程是動態且由模型主導。相關程式碼與詳細資訊可參見 `bird_interact_agent`。


### 🐣 精簡版

我們釋出 BIRD-INTERACT 的精簡版 `bird-interact-lite-exp`，包含 270 個高品質的真實世界任務，專為 PostgreSQL 設計。這是快速實驗的良好起點。

### 🦜 完整版

BIRD-INTERACT 的完整版 `bird-interact-full` 是一套全面性的基準，包含 600 個 PostgreSQL 任務，涵蓋廣泛的 SQL 操作及用戶查詢。完整版即將推出。

### 模型在 BIRD-INTERACT 精簡版上的表現結果

#### 1. **c-Interact** 表現
| 排名 | 模型名稱           | 標準化獎勵 | 水平            |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 優秀對話       |
| 2    | GPT-4o             | 30.33 | 💎 良好對話       |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 良好對話       |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ 標準            |
| 5    | DeepSeek-R1        | 21.74 | ✨ 標準            |
| 6    | Qwen3              | 20.33 | ⚪ 基礎            |
| 7    | DeepSeek-V3        | 15.85 | ⚪ 基礎            |

#### 2. **a-Interact** 表現
| 排名 | 模型名稱           | 預算參數*         | 任務平均步數     | 任務平均花費 (美元) | 標準化獎勵         | 水平                |

| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 優異互動 |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 良好互動 |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 良好互動 |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ 標準 |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ 標準 |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ 基礎 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ 基礎 |

> \* 預算參數：起始預算／用戶耐心預算，使用我們的虛擬貨幣 *bird-coin* <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 度量。詳細資訊請參考 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 互動時間擴展（ITS）

互動時間擴展（ITS）指的是模型能夠透過多輪互動不斷提升其最終表現的能力。當這種互動式表現超越模型在完全明確且無歧義任務下的理想化單輪表現時，即可稱其符合 **ITS 法則**。隨著用戶耐心提升和互動回合累積，表現持續進步，展現出模型能在長時間對話中維持有效溝通。目前僅發現 claude-3-7-sonnet 符合 ITS 法則。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 數據集詳情

### 數據集說明

- **資料庫：** 完整 PostgreSQL 資料庫可從 [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) 下載。詳情請見 [Quick Eval](#quick-eval) 章節。
- **數據：** 每筆數據包含以下主要部分：
   - `selected_database`: 資料庫名稱。  
   - `query`: 明確無歧義的用戶查詢。  
   - `amb_user_query`: 注入歧義的用戶查詢。
   - `user_query_ambiguity`: 注入至用戶查詢中的歧義。
   - `non_critical_ambiguity`: 非關鍵性歧義，如排序、限制等。
   - `knowledge_ambiguity`: 由外部知識遮罩產生的歧義。 
   - `sol_sql`: 標準答案 SQL 解法。  
   - `preprocess_sql`: 執行解答或預測前需運行的 SQL 查詢。  
   - `clean_up_sql`: 測試案例後執行以還原資料庫變動的 SQL 查詢。  
   - `test_cases`: 用於驗證預測修正 SQL 的一組測試案例。
   - `follow_up`: 標記過的後續問題。
   - `external_knowledge`: 與特定任務相關的外部知識。

- **評估：** 評估程式碼可於 [`./evaluation`](./evaluation) 目錄取得。
- **整理者：** BIRD 團隊 & Google Cloud
- **授權條款：** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 資料集卡片：** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### 資料集用途

為避免因自動爬蟲導致的資料洩漏，我們未將 GT 解答 SQL 與測試案例直接隨資料提供。
如需完整資料集，請以標題包含 `[bird-interact-lite GT&Test Cases]` 發送電子郵件至 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)，系統將自動寄送。




<!-- ### 從 HuggingFace 取得資料集

您可以使用以下指令從 HuggingFace 下載此資料集：
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
有關運行 **a-interact** 的詳細資訊，請參閱 `./bird_interact_agent/README.md`；而 **c-interact** 的相關資訊，請參閱 `./bird_interact_conv/README.md`。

## 📋 待辦清單

- [x] 發佈精簡版，bird-interact-lite（270）。
- [x] 發佈對話版，bird-interact-conv。
- [x] 發佈代理版，bird-interact-agent。
- [x] 發佈完整版，bird-interact-full（600）。
- [ ] SFT / RL 使用者模擬器

## 製作者：
BIRD 團隊 & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---