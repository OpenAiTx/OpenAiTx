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
請注意，在您的評測流程開始前，當 Docker 載入資料庫時，偶爾可能因環境不一致而出現錯誤（這些錯誤不會終止流程，但會顯示在 Docker 日誌中）。因此，部分資料庫可能未能正確載入，導致資料庫為空，這會造成評測結果異常偏低。  
👉 因此，我們強烈建議在**執行評測前**先檢查 Docker 日誌是否有錯誤，並確認所有資料庫皆已成功載入。

👉 我們已更新**投稿指南**，現已支援自訂代理程式模板。歡迎參閱我們的詳細投稿指南 [這裡](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true)。

## 📰 最新消息

- [2025-11-06] 🐛 **錯誤修正** & 🐳 **Docker 更新**：將 sqlglot 版本升級至 26.16.4，以修正用戶模擬器無法正確解析 SQL 的錯誤。您可在 `bird_interact_eval` 環境中透過 `pip install sqlglot==26.16.4` 重新安裝修復。`bird_interact_eval` 映像也已更新，亦可重新拉取並建立新的 `bird_interact_eval` 容器。

- [2025-10-21] 🐳 **Docker 更新**：我們新增了 Full DB Env 的 docker，並已將 3 個映像（Base/Full DB Env 及 `a-Interact` 與 `c-Interact` 的評測環境）推送至 Docker Hub，方便您建置環境。不需手動下載 DB dumps 及建構映像！

- [2025-10-08] 📝 我們的**[Bird-Interact 論文](https://huggingface.co/papers/2510.05318)**現已公開！  
  詳細介紹了我們互動式 text-to-SQL 基準的完整細節、方法論與評測。  
  👉 點擊查看，深入了解 [BIRD-Interact](https://bird-interact.github.io/) 的設計理念。

- [2025-08-26] 🚀 我們很高興宣布 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** 集正式釋出！  
這是一組高難度資料——最強大的 LLMs 也僅達到 **16.33%** 成功率，`c-interact` 與 `a-interact` 部分僅有 **10.0%**。  
👉 詳情請訪問我們的 [專案網站](https://bird-interact.github.io/)。

- [2025-08-26] 📬 本週我們將寄送**正確答案與測試案例**至郵件名單。  
若您希望優先取得，請依網站指示發信申請**自動下載**。  
- [2025-08-26] 💾 另外，我們也發布了 SQLite 版本的 **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)**，以方便本地研究。  
完整版的 **LiveSQLBench-Base** 及 **-Large** 即將推出！

- [2025-08-22] **錯誤修正**：在 Bird-Interact-Agent 代碼中，我們修復了當評估 phase-2 SQL 時，儲存的 phase-1 SQL 無法成功執行，導致 Phase-2 成功率降低的錯誤。此錯誤僅影響 phase1 sql 會在資料庫上執行某些操作的任務，例如 CREATE table 等。

## 🧸 簡介

BIRD-INTERACT 是一個互動式 text-to-SQL 基準，**以動態互動的視角重新定義 Text-to-SQL 評測**。
此環境融合了分層知識庫、資料庫文件及功能驅動的使用者模擬器，重現企業級環境，涵蓋完整 **CRUD** 操作。
它提供兩種嚴謹的測試模式：(1) 被動式 **對話互動** 及 (2) 主動式 **智能體互動**，共計 600 個帶註釋任務，包含商業智能 (BI)、CRUD 操作等，每個任務皆有可執行測試案例。
典型評測會觸發模型與使用者模擬器間 1,968-5,496 次互動，而最先進的推理模型目前僅能解決約 **24%** 及 **18%** 任務，凸顯此基準的挑戰性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 兩種評測模式

BIRD-INTERACT 支援上述兩種評測模式：

   - **c-Interact**：對話式互動，屬於被動模式且流程固定。相關程式碼及詳細資訊可見於 `bird_interact_conv`。
   - **a-Interact**：智能體互動，屬於主動模式，流程由模型主導並具動態性。相關程式碼及詳細資訊可見於 `bird_interact_agent`。


### 🐣 精簡版

我們正在發布 BIRD-INTERACT 的精簡版 `bird-interact-lite-exp`，包含 270 個高品質的真實世界 PostgreSQL 任務，是快速實驗的良好起點。

### 🦜 完整版

BIRD-INTERACT 的完整版本 `bird-interact-full` 是一個全面的基準，涵蓋 600 個 PostgreSQL 任務。包括各種 SQL 操作及使用者查詢。完整版即將推出。

### BIRD-INTERACT-FULL 模型效能結果

#### 1. **c-Interact Text-to-SQL** 效能
| 排名 | 模型名稱           | 標準化獎勵          | 平均花費 (USD)/任務 | 等級              |
|:----:|:-------------------|:-------------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92               | $0.04               | 🏆 卓越對話       |

| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 優秀對話          |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 良好對話          |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 良好對話          |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ 標準               |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ 標準               |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ 基本               |

#### 2. **a-Interact Text-to-SQL** 性能表現
| Rank | Model Name         | Normalized Reward | Avg Cost (USD)/Task | Level                    |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 優秀互動              |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 優秀互動              |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 良好互動              |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 良好互動              |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ 標準                  |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ 標準                  |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ 基本                  |

> \* 預算參數：啟動預算／用戶耐心預算，以我們的虛擬貨幣 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 進行度量。詳情請參考 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 互動時間擴展（ITS）

互動時間擴展（ITS）指的是模型能夠通過多輪互動持續提升其最終表現的能力。當這種互動表現超越模型在完全明確、無歧義任務下的理想化單輪表現時，我們認為它符合 **ITS 法則**。隨著用戶耐心提升和互動輪次累積，性能持續進步，展現出模型能在長時間對話中保持有效溝通。目前僅發現 claude-3-7-sonnet 符合 ITS 法則。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 環境設置

1. 為 bird-interact-lite 資料庫、bird-interact-full 資料庫以及評估環境執行 Docker 容器：
  
  > 若您僅需在 `bird-interact-lite` 上評估，可將 `docker-compose.yml` 內的 [`postgresql_full` 服務](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) 註解，以加快環境設置速度。
  
  執行以下指令以啟動環境：
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   請等待數分鐘以完成資料庫初始化。
   
  您可以透過以下方式追蹤建置進度：
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  如果完成，您應該會看到沒有錯誤的日誌，如下所示：

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  如果您之前已建立過容器，並希望重新建立它，可以執行以下命令：
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   這會使用來自 Docker Hub 的預建映像檔運行 3 個容器：
   - `bird_interact_postgresql`：bird-interact-lite 的 PostgreSQL 資料庫
   - `bird_interact_postgresql_full`：bird-interact-full 的 PostgreSQL 資料庫
   - `bird_interact_eval`：同時用於 `a-Interact` 和 `c-Interact` 的評估環境。

   現在，你可以執行以下指令來啟動評估環境：
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. （可選）手動建置環境（如果您想從頭開始建構映像檔）：
   - 下載資料庫轉儲檔案
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view)。解壓縮並重新命名為 `env/postgre_table_dumps`。
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view)。解壓縮並重新命名為 `env/postgre_table_dumps_full`。
   - 執行 `docker-compose.build.yml` 手動建置環境。

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3.（建議）檢查資料庫容器是否已成功建置並運行。

-  列印容器建置日誌，以確保資料庫已成功建置且無錯誤：
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   如果發生錯誤，日誌檔案中會顯示 `"Errors occurred during import:"`。

-  檢查資料庫容器是否運作正常。
   
   使用我們提供的 Python 指令碼來驗證資料庫中繼資料：

   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   預期結果：
   - **bird-interact-lite**: 
     - 📈 資料庫總數：18
     - 📋 資料表總數：175
     - 🔢 欄位總數：2286
     - 📈 每個資料表的平均列數：1,038.48
     - 💾 總大小：207.15 MB（約略值）
   - **bird-interact-full**: 
     - 📈 資料庫總數：22
     - 📋 資料表總數：244
     - 🔢 欄位總數：2011
     - 📈 每個資料表的平均列數：1,121.19
     - 💾 總大小：272.00 MB（約略值）


## 📦 資料集詳情

### 資料集說明

- **資料庫：** 完整的 PostgreSQL 資料庫可從 [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) 及 [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) 下載。
- **data：** 每個資料實例包含以下主要部分：
   - `selected_database`：資料庫名稱。  
   - `query`：無歧義的使用者查詢。  
   - `amb_user_query`：注入歧義的使用者查詢。
   - `user_query_ambiguity`：注入到使用者查詢的歧義。
   - `non_critical_ambiguity`：非關鍵性歧義，如順序、限制等。
   - `knowledge_ambiguity`：由遮蔽外部知識產生的歧義。 
   - `sol_sql`：標準解 SQL 解答。  
   - `preprocess_sql`：在執行解答或預測前需執行的 SQL 查詢。  
   - `clean_up_sql`：測試案例後還原資料庫變動的 SQL 查詢。  
   - `test_cases`：驗證預測修正後 SQL 的一組測試案例。
   - `follow_up`：標註的後續問題。
   - `external_knowledge`：與特定任務相關的外部知識。

- **evaluation：** 評估程式碼可在 [`./evaluation`](./evaluation) 目錄中取得。
- **策劃者：** BIRD 團隊 & Google Cloud
- **授權：** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 資料集卡片：** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  及 [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### 資料集用途

為了避免自動爬取導致資料洩漏，我們並未將 GT 解答 SQL 及測試案例與資料一同提供。
請發送電子郵件至 [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com)，郵件標題請加上標籤 `[bird-interact-lite GT&Test Cases]` 或 `[bird-interact-full GT&Test Cases]`，以獲取 bird-interact-lite 或 bird-interact-full 資料集的正確解答及測試案例，這些資料將會自動發送。

### 合併公開資料與正確解答及測試案例

接著，請使用以下腳本將公開資料與正確解答及測試案例合併：

以完整版為例：
(1) 執行：

```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
這將在 `/path/to/bird_interact_data.jsonl` 創建一個新檔案，內容為合併後的資料。

(2) 然後用合併後的資料取代原本的公開資料：

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

其他版本也是如此：bird-interact-lite、mini 版本等等。只需為公共數據、真實值和測試案例設定正確的路徑，然後將公共數據替換為合併後的數據。




<!-- ### 使用 HuggingFace 上的資料集

你可以用以下指令從 HuggingFace 下載資料集：
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
有關執行 **a-interact** 的詳細資訊可參見 `./bird_interact_agent/README.md`；而 **c-interact** 的資訊則可參見 `./bird_interact_conv/README.md`。

## 📋 待辦清單

- [x] 發佈精簡版，bird-interact-lite (270)。
- [x] 發佈對話版，bird-interact-conv。
- [x] 發佈代理版，bird-interact-agent。
- [x] 發佈完整版，bird-interact-full (600)。
- [ ] SFT / RL 使用者模擬器

## 致謝
我們衷心感謝 **Irina Saparina**、**Mohammadreza Pourreza**、**Mehdi Bouzouina**、**李海龍**、**史佳童** 以及 **渡邊真二** 教授對本項目的富有成效的討論和寶貴見解，這些都大大促進了本項目的完善。

## 團隊成員：
BIRD 團隊 & Google Cloud








## 更新日誌

- [2025-11-06] 🐛 **錯誤修復** & 🐳 **Docker 更新**：將 sqlglot 版本升級至 26.16.4，以修復 SQL 解析器無法正確解析使用者模擬器 SQL 的錯誤。您可以在 `bird_interact_eval` 環境中透過 `pip install sqlglot==26.16.4` 重新安裝來修復此問題。`bird_interact_eval` 映像檔亦已更新，因此也可直接拉取並重建 `bird_interact_eval` 容器。
- [2025-10-21] 🐳 **Docker 更新**：新增完整版資料庫環境的 docker。並已將 3 個 docker 映像檔（Base/完整版資料庫環境，以及 `a-Interact` 和 `c-Interact` 的評估環境）推送至 Docker Hub，以便於環境設置。無需手動下載資料庫檔案並構建映像！請從 Docker Hub 拉取最新映像並重建容器，例如使用 `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`。
- [2025-08-22]  🐛 **錯誤修復**：修復在評估第二階段 SQL 時，儲存的第一階段 SQL 無法成功執行，導致第二階段成功率下降的錯誤。此錯誤僅影響第一階段 SQL 會對資料庫執行某些操作（如 CREATE table 等）的任務。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---