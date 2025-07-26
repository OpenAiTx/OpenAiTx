
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🧠 無需代理的LLM網路搜尋引擎

一個無需代理的多搜尋引擎 LLM 網路檢索工具，支援 URL 內容解析與網頁爬蟲，結合 LangGraph 實現模組化智能體鏈路。專為大語言模型的外部知識調用場景而設計，支援 **Playwright + Crawl4AI** 網頁獲取與解析，支援非同步並發、內容切片與重排過濾。

## ✨ 特色總覽

- 🌐 **無需代理**：透過 Playwright 配置國內瀏覽器支援，無需代理即可進行網路搜尋。
- 🔍 **多搜尋引擎支援**：支援 Bing、夸克、百度、搜狗 等主流搜尋引擎，增強資訊來源多樣性。
- 🤖 **意圖識別**：系統能夠根據用戶的輸入內容，自動判斷是進行網路搜尋還是解析 URL。
- 🔄 **查詢分解**：根據用戶的搜尋意圖，自動將查詢分解為多個子任務，並依次執行，從而提升搜尋的相關性與效率。
- ⚙️ **智能體架構**：基於 **LangGraph** 封裝的**「web_search」**與**「link_parser」**。
- 🏃‍♂️ **非同步並發任務處理**：支援非同步並發任務處理，可高效處理多個搜尋任務。
- 📝 **內容處理優化**：

  - ✂️ **內容切片**：將網頁長內容按段切分。

  - 🔄 **內容重排**：智能重新排序，提高資訊相關性。

  - 🚫 **內容過濾**：自動剔除無關或重複內容。
- 🌐 **多端支援**：

  - 🖥️ 提供 FastAPI 後端介面，可整合到任意系統中。

  - 🌍 提供 Gradio Web UI，可快速部署為可視化應用。
  
  - 🧩[ **瀏覽器擴充套件支援**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension)：支援 Edge，提供智能 URL 解析擴充套件，可直接在瀏覽器中發起網頁解析與內容擷取請求。
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ 快速開始

### 1. 複製倉庫

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. 安裝依賴

```
pip install -r requirements.txt
python -m playwright install
```

### 3. 快速開始

#### 環境變數配置

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### 示範

```python
'''
python demo.py
'''

from pools import BrowserPool, CrawlerPool
from agent import ToolsGraph
import asyncio

async def main():
    browser_pool = BrowserPool(pool_size=1)
    crawler_pool = CrawlerPool(pool_size=1)
    
    graph = ToolsGraph(browser_pool, crawler_pool, engine="bing")

    await browser_pool._create_browser_instance(headless=True)
    await crawler_pool._get_instance()

    result = await graph.run("广州今日天气")

    await browser_pool.cleanup()
    await crawler_pool.cleanup()

    print(result)

if __name__ == "__main__":
    asyncio.run(main())
```

#### 後端api

```python
'''
python api_serve.py
'''
import requests

url = "http://localhost:8000/search"

data = {
    "question": "广州今日天气"
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### gradio_demo

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 與線上網路檢索測試對比

我們將本專案與一些主流的線上 API 進行對比，評估其在複雜問題下的表現。

### 🔥 數據集

- 數據集來自阿里發佈的 [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA)，包含了 680 個高難度問題，涵蓋教育、學術會議、遊戲等多個領域。
- 數據集包含中英文問題。

### 🧑‍🏫 對比結果

| 搜尋引擎/系統  | ✅ 正確 | ❌ 錯誤 | ⚠️ 部分正確 |
| -------------- | ------- | ------- | ----------- |
| **火山方舟**   | 5.00%   | 72.21%  | 22.79%      |
| **百煉**       | 9.85%   | 62.79%  | 27.35%      |
| **Our** | 19.85%  | 47.94%  | 32.06%      |

## 🙏 致謝

本專案部分功能得益於以下開源專案的支持與啟發，特此致謝：

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph)：用於構建模組化智慧體鏈路框架。
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai)：強大的網頁內容解析工具。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---