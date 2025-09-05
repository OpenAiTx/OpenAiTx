<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-CN">簡體中文</a>
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

一個無需代理的多搜尋引擎LLM網路檢索工具，支援URL內容解析及網頁爬取，結合 **LangGraph** 與 **LangGraph-MCP** 實現模組化智能體鏈路。專為大型語言模型外部知識調用場景設計，支援 **Playwright + Crawl4AI** 網頁獲取與解析，支援非同步並發、內容切片及重排過濾。

## 🚀 更新日誌

- 🔥 2025-09-05：支援 **langgraph-mcp**
- 🔥 2025-09-03：新增 Docker 部署、內建智能重排器、支援自訂文本切分器與重排器

## ✨ 特性一覽

- 🌐 **無需代理**：透過 Playwright 配置國內瀏覽器支援，無需代理也能進行網路搜尋。
- 🔍 **多搜尋引擎支援**：支援 Bing、夸克、百度、搜狗等主流搜尋引擎，增強資訊來源多樣性。
- 🤖 **意圖識別**：系統能夠根據使用者的輸入內容，自動判斷是進行網路搜尋還是解析 URL。
- 🔄 **查詢分解**：根據使用者的搜尋意圖，自動將查詢分解為多個子任務，並依序執行，從而提升搜尋的相關性與效率。
- ⚙️ **智能體架構**：基於 **LangGraph** 封裝的**「web_search」**與**「link_parser」**。
- 🏃‍♂️ **非同步並發任務處理**：支援非同步並發任務處理，可高效處理多個搜尋任務。
- 📝 **內容處理優化**：

  - ✂️ **內容切片**：將網頁長內容依段切分。

  - 🔄 **內容重排**：智能重排序，提高資訊相關性。

  - 🚫 **內容過濾**：自動剔除無關或重複內容。
- 🌐 **多端支援**：
  - 🐳 **支援 Docker 部署**：一鍵啟動，快速建置後端服務。

  - 🖥️ 提供 FastAPI 後端介面，可整合至任意系統中。

  - 🌍 提供 Gradio Web UI，可快速部署成視覺化應用。

  - 🧩[ **瀏覽器插件支援**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension)：支援 Edge，提供智能 URL 解析插件，直接於瀏覽器中發起網頁解析與內容擷取請求。


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ 快速開始

### 克隆倉庫

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 安裝依賴

```
pip install -r requirements.txt
python -m playwright install
```

### 環境變數配置

```
# 百炼llm
OPENAI_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
OPENAI_API_KEY=sk-xxx
MODEL_NAME=qwen-plus-latest

# 百炼embedding
EMBEDDING_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
EMBEDDING_API_KEY=sk-xxx
EMBEDDING_MODEL_NAME=text-embedding-v4

# 百炼reranker
RERANK_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
RERANK_API_KEY=sk-xxx
RERANK_MODEL=gte-rerank-v2
```

### Langgraph-Agent

#### 演示

```shell
python agent/demo.py
```

#### API 服務

```shell
python agent/api_serve.py
```

```python
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气",
  "engine": "bing",
  "split": {
    "chunk_size": 512,
    "chunk_overlap": 128
  },
  "rerank": {
    "top_k": 5
  }
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

#### Gradio

```
python agent/gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

#### docker

```
docker-compose -f docker-compose-ag.yml up -d --build
```

### Langgrph-MCP

#### 啟動MCP服務

```
python mcp/websearch.py
```

#### 示範

```
python mcp/demo.py
```

#### API 服務

```
python mcp/api_serve.py
```

```
import requests

url = "http://localhost:8800/search"

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

#### docker

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### 自訂模組

#### 自訂分塊

```
from typing import Optional, List

class YourSplitter:
    def __init__(self, text: str, chunk_size: int = 512, chunk_overlap: int = 128):
        self.text = text
        self.chunk_size = chunk_size
        self.chunk_overlap = chunk_overlap

    def split_text(self, text: Optional[str] = None) -> List:
        # TODO: implement splitting logic
        return ["your chunk"]
```

#### 自訂重排

```
from typing import List, Union, Tuple

class YourReranker:
    async def get_reranked_documents(
        self,
        query: Union[str, List[str]],
        documents: List[str],
    ) -> Union[
        Tuple[List[str]],
        Tuple[List[int]],
    ]:
        return ["your chunk"], ["chunk index"]
```
## 🔍 與線上網路檢索測試對比

我們將項目與一些主流的線上 API 進行對比，評估其在複雜問題下的表現。

### 🔥 數據集

- 數據集來自阿里發布的 [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA)，包含 680 個高難度問題，涵蓋教育、學術會議、遊戲等多個領域。
- 數據集包括中英文問題。

### 🧑‍🏫 對比結果

| 搜尋引擎/系統  | ✅ 正確 | ❌ 錯誤 | ⚠️ 部分正確 |
| -------------- | --------- | ----------- | ------------------- |
| **火山方舟**   | 5.00%     | 72.21%      | 22.79%              |
| **百鍊**       | 9.85%     | 62.79%      | 27.35%              |
| **Our** | 19.85%    | 47.94%      | 32.06%              |
## 🙏 致謝

本項目部分功能得益於以下開源項目的支持與啟發，特此致謝：

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph)：用於構建模組化智能體鏈路框架，幫助快速搭建複雜的智能體系統。
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai)：強大的網頁內容解析工具，助力高效網頁抓取與數據提取。
- 🌐 [Playwright](https://github.com/microsoft/playwright)：現代瀏覽器自動化工具，支持跨瀏覽器的網頁抓取和測試自動化。
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters)：用於多鏈處理 MCP 的構建。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---