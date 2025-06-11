# RSS-Master

針對 RSS 源的自訂過濾、篩選，使用 AI 總結、概括、打分等。性能優化版本，支持非同步處理和並行 AI 總結。

### 前言

9 月初旬，我開始使用 Inoreader + RSSHub 來聚合、訂閱我感興趣的 RSS，配合 Reeder 閱讀，試圖完全掌控每日輸入的資訊源頭，一個月下來，逐漸增多的 RSS 源，日益增加的未讀資訊，給我增添了不少閱讀焦慮，於是想著是否有方式可以自訂一些過濾規則的，最好能加入 AI 來輔助我閱讀，減少我閱讀的負擔。

Inoreader 自帶有過濾器，但僅僅為這個功能買單感覺有點不划算；NewsBlur 有「Intelligence Trainer」來做智能分類，但我簡單嘗試了下感覺反饋不明顯，短時間內體現不出智能；Feedly 既有篩選還有 AI 功能，聽起來很滿足我的需求，正當我躊躇要不要從 Inoreader 轉到 Feedly 的付費用戶的時候，我看到了這兩個項目

- [讓 ChatGPT 幫我們總結 Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT 使用指南](http://yinan.me/rss-gpt-manual-zh.html)

這兩個項目的整體思路都是透過 GitAction 去執行一個腳本，獲取資訊後使用 Open AI 的 API 進行翻譯、總結，然後渲染成模板，部署到 GitHub Page 上。RSS-GPT 中的方式會更加滿足我的需求，透過定時執行腳本直接獲取 RSS 的 xml 檔案，處理後把 xml 部署到 GitHub Page 上後，就可以得到這個 xml 檔案的訪問連結，最後讓閱讀器直接訂閱這個連結即可。

我對 Inoreader 的多端同步有強需求，對於在 config 配置檔中新增的 RSS 源，需要及時通知到 Inoreader 去同步，於是我在[RSS-GPT](https://github.com/yinan-c/)的思路上做了擴展，叫做 RSS-Master。

### 功能特點

- **支持並行處理**：使用非同步和線程池實現 RSS 源和 AI 總結的並行處理，顯著提升處理速度
- **增強的快取機制**：更穩定的快取系統，防止資料遺失和提高重複訪問性能
- **更好的錯誤處理**：所有操作都有完整的錯誤處理和日誌記錄，提高穩定性
- **HTML 內容優化提取**：智能提取文章內容，忽略無關資訊，提高 AI 總結品質
- **支持最新的 OpenAI API**：完全相容最新版本的 OpenAI API
- **詳細統計資訊**：處理完成後提供運行時間、成功率和成本統計
- **支持 opml 檔案的生成**：以及和 config.yml 的相互轉換：`https://raw.githubusercontent.com/TD21forever/RSS-Master/main/script/convert_opml_to_yaml.sh` `https://raw.githubusercontent.com/TD21forever/RSS-Master/main/script/convert_yaml_to_opml.sh`
- **支持自訂篩選規則**：支持 include、exclude 兩種類型，title 和 article 兩種作用域
- **可自訂 AI 模型**：透過環境變數配置使用不同的 OpenAI 模型
- **可自訂基礎 URL**：可配置 RSS 檔案的基礎訪問 URL，便於在不同環境中部署
- **互動式測試筆記本**：提供 Jupyter 筆記本用於測試各項功能

### 環境變數配置

專案支持透過 `.env` 檔案配置以下參數：

```
# 必需參數
OPENAI_API_KEY=your_openai_api_key_here

# 可選參數
RSS_BASE_URL=https://example.com/rss-feeds/  # RSS 基礎 URL
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAI 模型
LOG_LEVEL=INFO                               # 日誌級別
PARALLEL_WORKERS=5                           # 並行處理數量
```

可以複製 `.env.example` 檔案並重新命名為 `.env`，然後修改相應的參數值。

### 性能改進

本版本相比原始版本有以下性能改進：

1. **RSS 源並行處理**：使用`asyncio`同時處理多個 RSS 源
2. **AI 總結並行化**：使用線程池並發處理多篇文章的 AI 總結
3. **文本處理優化**：改進了 HTML 內容提取演算法，更智能地提取文章關鍵內容
4. **安全的檔案處理**：採用了安全的檔案寫入機制，避免因程式崩潰導致的資料遺失
5. **記憶體使用優化**：優化資料結構和處理流程，減少記憶體佔用

### 使用說明

1. 克隆專案到本地
2. 安裝依賴：`pip install -r requirements.txt`
3. 建立`.env`檔案並設定 OpenAI API 密鑰：`OPENAI_API_KEY=你的密鑰`
4. 修改`https://raw.githubusercontent.com/TD21forever/RSS-Master/main/resource/config.yml`配置你的 RSS 源
5. 運行`python main.py`開始處理

### 測試與調試

專案提供了一個互動式測試筆記本 `https://raw.githubusercontent.com/TD21forever/RSS-Master/main/test.ipynb`，可以用於測試各項功能：

1. RSS 源獲取與解析
2. 篩選器功能
3. AI 摘要功能
4. 快取機制
5. 自訂基礎 URL
6. 性能測試

使用方法：

```bash
# 安裝 Jupyter
pip install jupyter

# 啟動筆記本
jupyter notebook https://raw.githubusercontent.com/TD21forever/RSS-Master/main/test.ipynb
```

### 自訂篩選規則示例

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什麼值得買 | 優惠精選
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可樂',
          '雪碧',
          '芬達',
          '檸檬',
          '茶葉',
          '紙巾',
          '酒精',
          '濕紙巾',
          '餐巾紙',
        ]
```

### 使用截圖

- AI 概括、摘要功能

<div style="display: flex;">
    <img src="https://qiniu.dcts.top/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://qiniu.dcts.top/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- 自訂篩選：過濾「什麼值得買」的好價頻道，只推薦近期想屯的貨，如汽水

<img src="https://qiniu.dcts.top/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400; height: 400;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---