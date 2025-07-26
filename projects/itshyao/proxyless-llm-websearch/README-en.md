
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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

# 🧠 Proxyless LLM Web Search Engine

A multi-search engine LLM web retrieval tool that does not require a proxy, supporting URL content parsing and web crawling, combined with LangGraph to realize modular agent chains. Designed specifically for external knowledge invocation scenarios for large language models, it supports **Playwright + Crawl4AI** web acquisition and parsing, supports asynchronous concurrency, content chunking, and reranking/filtering.

## ✨ Features Overview

- 🌐 **Proxyless**: Supports domestic browsers via Playwright configuration, enabling web search without the need for a proxy.
- 🔍 **Multi-Search Engine Support**: Supports mainstream search engines such as Bing, Quark, Baidu, Sogou, enhancing the diversity of information sources.
- 🤖 **Intent Recognition**: The system can automatically determine whether to perform a web search or parse a URL based on user input.
- 🔄 **Query Decomposition**: Automatically decomposes queries into multiple subtasks according to the user's search intent, executing them sequentially to improve search relevance and efficiency.
- ⚙️ **Agent Architecture**: Encapsulates **"web_search"** and **"link_parser"** based on **LangGraph**.
- 🏃‍♂️ **Asynchronous Concurrent Task Processing**: Supports asynchronous concurrent task processing, efficiently handling multiple search tasks.
- 📝 **Optimized Content Processing**:

  - ✂️ **Content Chunking**: Divides long web content into segments.

  - 🔄 **Content Reranking**: Intelligently reorders content to enhance information relevance.

  - 🚫 **Content Filtering**: Automatically removes irrelevant or duplicate content.
- 🌐 **Multi-terminal Support**:

  - 🖥️ Provides FastAPI backend interface, which can be integrated into any system.

  - 🌍 Offers Gradio Web UI for rapid deployment as a visual application.
  
  - 🧩[ **Browser Extension Support**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Supports Edge, providing an intelligent URL parsing extension, enabling web page parsing and content extraction requests directly in the browser.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Quick Start

### 1. Clone the repository

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```
### 2. Install Dependencies


```
pip install -r requirements.txt
python -m playwright install
```
### 3. Quick Start

#### Environment Variable Configuration


```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```
#### demo


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
#### Backend API


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

## 🔍 Comparison with Online Web Search Tests

We compared the project with some mainstream online APIs to evaluate its performance on complex questions.

### 🔥 Dataset

- The dataset comes from Alibaba's released [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), containing 680 challenging questions covering multiple fields such as education, academic conferences, and gaming.
- The dataset includes questions in both Chinese and English.

### 🧑‍🏫 Comparison Results

| Search Engine/System | ✅ Correct | ❌ Incorrect | ⚠️ Partially Correct |
| -------------------- | ---------- | ------------ | -------------------- |
| **Volcano Ark**      | 5.00%      | 72.21%       | 22.79%               |
| **Bailian**          | 9.85%      | 62.79%       | 27.35%               |
| **Our**              | 19.85%     | 47.94%       | 32.06%               |

## 🙏 Acknowledgments

Some features of this project benefited from the support and inspiration of the following open-source projects, hereby acknowledged:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Used for building modular intelligent agent chain frameworks.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): A powerful web content parsing tool.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---