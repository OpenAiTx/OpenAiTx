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
請注意，在您的評估流程開始之前，當 Docker 載入資料庫時，偶爾會因為環境不一致而發生錯誤（這些錯誤不會終止流程，但會顯示在 Docker 日誌中）。因此，有些資料庫可能無法正確載入，導致資料庫為空。這將導致評估結果異常偏低。  
👉 因此，我們強烈建議在**執行評估前**，先檢查 Docker 日誌是否有錯誤，並確認所有資料庫都已成功載入。

👉 我們已更新**提交規則**，現已支援自訂代理腳手架。歡迎參閱我們的詳細提交規範 [這裡](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true)。

## 📰 最新消息

- [2026-03-29] 🔥🔥🔥 **BIRD-Interact-ADK**：我們釋出了**[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**，這是一個基於 Google ADK 的實作，具備模組化 3 微服務（代理、人類模擬器與 DB 環境）架構。可輕鬆更換自己的代理、人類模擬器或 DB 環境。支援平行執行及所有 [LiteLlm 兼容](https://docs.litellm.ai/docs/providers) 的 LLM 供應商。建議您將此實作用於研究。

- [2026-02-08] 🔥🔥🔥 我們的**[Bird-Interact 論文](https://huggingface.co/papers/2510.05318)** 已被 **ICLR 2026（口頭報告）** 接收！里約見 🇧🇷！  

- [2025-11-06] 🐛 **錯誤修正** & 🐳 **Docker 更新**：將 sqlglot 版本升級至 26.16.4，以修正用戶模擬器無法正確解析 SQL 的問題。您可在 `bird_interact_eval` 環境中使用 `pip install sqlglot==26.16.4` 重新安裝修正。`bird_interact_eval` 映像檔也已更新，可直接拉取並重建 `bird_interact_eval` 容器。

- [2025-10-21] 🐳 **Docker 更新**：我們新增了 Full DB Env 的 docker，並已將 3 個 docker 映像檔（Base/Full DB Env 和 `a-Interact`、`c-Interact` 評估環境）推送至 Docker Hub，方便您進行環境部署。無須手動下載資料庫轉存檔並自行建構映像檔！

- [2025-10-08] 📝 我們的**[Bird-Interact 論文](https://huggingface.co/papers/2510.05318)** 現已公開！  
  內容詳述了我們互動式 text-to-SQL 基準的完整細節、方法論與評估。  
  👉 歡迎查看，深入了解 [BIRD-Interact](https://bird-interact.github.io/) 的設計理念。

- [2025-08-26] 🚀 我們很高興宣布 **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** 數據集正式釋出！  
這是一組極具挑戰性的測試——最佳 LLM 僅達到 **16.33%** 成功率，`c-interact` 與 `a-interact` 區塊僅有 **10.0%**。  
👉 欲了解更多詳情，請參閱我們的 [專案網站](https://bird-interact.github.io/)。

- [2025-08-26] 📬 本週我們將會把 **Ground Truth & Test cases** 發送至郵件訂閱名單。  
如需提前獲取，請依網站說明發送郵件以取得**自動下載**。

- [2025-08-26] 💾 另外，我們也釋出了**[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** 的 SQLite 版本，方便本地研究使用。  
完整版 **LiveSQLBench-Base** 與 **-Large** 即將推出！

- [2025-08-22] **錯誤修復**：在 Bird-Interact-Agent 代碼中，我們修正了一個錯誤，當評估 phase-2 SQL 時，儲存的 phase-1 SQL 無法成功執行，導致第二階段成功率降低。此錯誤僅影響 phase1 sql 會對資料庫進行操作（如 CREATE table 等）的任務。

## 🧸 總覽

BIRD-INTERACT 是一個互動式 text-to-SQL 基準測試，**以動態互動的視角重新定義 Text-to-SQL 評估**。
該環境結合了分層知識庫、資料庫文件和以函式為驅動的用戶模擬器，重現企業級真實場景，涵蓋完整 **CRUD** 操作。
它提供兩種嚴謹測試模式：（1）被動式 **對話互動** 及（2）主動式 **智能體互動**，涵蓋 600 筆帶註釋任務，包含商業智慧（BI）、CRUD 操作等，每項皆有可執行測試案例。
標準評測過程中，模型與用戶模擬器之間會產生 1,968-5,496 次互動，目前最先進推理模型僅能解決 **≈24%** 與 **≈18%** 任務，突顯此基準的挑戰性。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ 兩種評測模式

BIRD-INTERACT 支援上述兩種評測模式：

   - **c-Interact**：對話互動，屬於被動模式，流程固定。代碼及詳細資訊可於 `bird_interact_conv` 查詢。
   - **a-Interact**：智能體互動，屬於具體化主動模式，流程由模型動態主導。代碼及詳細資訊可於 `bird_interact_agent` 查詢。


### 🐣 輕量版

我們釋出了 BIRD-INTERACT 的輕量版 `bird-interact-lite-exp`，包含 270 筆高品質真實世界任務，專為 PostgreSQL 設計，是快速實驗的良好起點。

### 🦜 完整版

BIRD-INTERACT 的完整版 `bird-interact-full` 是一套涵蓋 600 項 PostgreSQL 任務的綜合基準，範圍廣泛，涵蓋多種 SQL 操作與用戶查詢。完整版即將推出。

### BIRD-INTERACT-FULL 的模型表現結果

#### 1. **c-Interact Text-to-SQL** 性能
| 排名 | 模型名稱            | 正規化回報         | 平均成本 (美元)/任務 | 級別                |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 優秀對話         |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 優秀對話         |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 良好對話         |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 良好對話         |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ 標準             |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ 標準             |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ 基本             |

#### 2. **a-Interact Text-to-SQL** 性能
| 排名 | 模型名稱            | 正規化回報         | 平均成本 (美元)/任務 | 級別                    |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 優秀互動              |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 優秀互動              |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 良好互動              |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 良好互動              |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ 標準                  |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ 標準                  |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ 基本                  |

> \* 預算參數：起始預算／用戶耐心預算，透過我們的虛擬貨幣 *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> 進行衡量。更多詳情請參見 [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)。

### 互動時間擴展 (ITS)

互動時間擴展（ITS）指模型通過多輪互動不斷提升其最終性能的能力。當這種互動性能超過模型在完全明確、無歧義任務下的理想單輪表現時，我們稱其滿足 **ITS 定律**。隨著用戶耐心增加與互動輪次累積，性能持續提升，展現模型能在長時間對話中維持有效溝通。目前我們僅發現 claude-3-7-sonnet 滿足 ITS 定律。

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 環境設置

1. 運行 bird-interact-lite 資料庫、bird-interact-full 資料庫及評測環境的 Docker 容器：
  
  > 如果你只想在 `bird-interact-lite` 上評測，可以在 `docker-compose.yml` 中註解掉 [`postgresql_full` 服務](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) 以加快環境設置速度。
  
  通過以下命令啟動環境：
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
     - 📈 每個資料表平均列數：1,038.48
     - 💾 總容量：207.15 MB（約略）
   - **bird-interact-full**: 
     - 📈 資料庫總數：22
     - 📋 資料表總數：244
     - 🔢 欄位總數：2011
     - 📈 每個資料表平均列數：1,121.19
     - 💾 總容量：272.00 MB（約略）


## 📦 數據集詳情

### 數據集說明

- **資料庫：** 完整的 PostgreSQL 資料庫可從 [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) 及 [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view) 下載。
- **資料：** 每筆資料實例包含以下主要部分：
   - `selected_database`：資料庫名稱。  
   - `query`：明確的使用者查詢。  
   - `amb_user_query`：帶有歧義的使用者查詢。
   - `user_query_ambiguity`：注入至使用者查詢的歧義。
   - `non_critical_ambiguity`：如排序、限制等非關鍵性歧義。
   - `knowledge_ambiguity`：由外部知識遮蔽產生的歧義。 
   - `sol_sql`：標準答案 SQL 解決方案。  
   - `preprocess_sql`：在執行解決方案或預測前需執行的 SQL 查詢。  
   - `clean_up_sql`：測試案例後還原資料庫變更的 SQL 查詢。  
   - `test_cases`：用於驗證預測修正 SQL 的一組測試案例。
   - `follow_up`：標註的後續問題。
   - `external_knowledge`：與特定任務相關的外部知識。

- **評估：** 評估程式碼於 [`./evaluation`](./evaluation) 目錄中提供。
- **策劃單位：** BIRD 團隊 & Google Cloud
- **授權：** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace 數據集卡片：** PostgreSQL 版本見 [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  及 [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)；SQLite 版本見 [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact)。
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
有關執行 **a-interact** 的詳細資訊可參見 `./bird_interact_agent/README.md`；**c-interact** 可參見 `./bird_interact_conv/README.md`；而 **基於 ADK 的實現** 可參見 `./BIRD-Interact-ADK/README.md`。

## 📋 待辦事項清單

- [x] 發布輕量版，bird-interact-lite (270)。
- [x] 發布對話版，bird-interact-conv。
- [x] 發布代理版，bird-interact-agent。
- [x] 發布完整版，bird-interact-full (600)。
- [x] 發布基於 ADK 的實現，BIRD-Interact-ADK。
- [ ] SFT / RL 與用戶模擬器

## 致謝
我們誠摯感謝 **Irina Saparina**、**Mohammadreza Pourreza**、**Mehdi Bouzouina**、**Hailong Li**、**Jiatong Shi** 以及 **Shinji Watanabe** 教授，感謝他們的建設性討論與寶貴見解，幫助我們提升了本專案。

## 製作團隊：
BIRD 團隊 & Google Cloud







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

## 變更日誌

- [2025-11-06] 🐛 **錯誤修正** & 🐳 **Docker 更新**：將 sqlglot 版本更新至 26.16.4，以修復用戶模擬器的 SQL 解析器無法正確解析 SQL 的錯誤。你可以在 `bird_interact_eval` 環境中透過 `pip install sqlglot==26.16.4` 重新安裝來修復此問題。`bird_interact_eval` 映像檔也已更新，因此你也可以拉取並重新建立 `bird_interact_eval` 容器。
- [2025-10-21] 🐳 **Docker 更新**：新增 Full DB Env 的 Docker。並且我們已將 3 個 Docker 映像檔（Base/Full DB Env，以及 `a-Interact` 和 `c-Interact` 的評估環境）推送至 Docker Hub，以方便環境設定。不需再下載 DB dumps 或手動建立映像檔！請從 Docker Hub 拉取最新映像並重新建立容器，例如使用 `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`。
- [2025-08-22]  🐛 **錯誤修正**：修正評估 Phase-2 SQL 時，儲存的 Phase-1 SQL 無法成功執行，導致 Phase-2 成功率降低的錯誤。這個錯誤僅影響 Phase1 SQL 對資料庫進行某些操作的任務，例如 CREATE table 等。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---