
# 🧠 Proxy-Free LLM Web Search Engine

A proxy-free multi-search engine LLM web retrieval tool that supports URL content parsing and web crawling, combined with LangGraph to implement modular intelligent agent workflows. Designed specifically for external knowledge invocation scenarios of large language models, supporting **Playwright + Crawl4AI** for web fetching and parsing, with asynchronous concurrency, content slicing, and reordering filtering.

## ✨ Features Overview

- 🌐 **Proxy-Free**: Configures domestic browsers via Playwright, enabling web search without proxy.
- 🔍 **Multi-Search Engine Support**: Supports major search engines like Bing, Quark, Baidu, Sogou, enhancing information source diversity.
- 🤖 **Intent Recognition**: The system automatically determines whether to perform a web search or parse a URL based on user input.
- 🔄 **Query Decomposition**: Automatically breaks down queries into multiple subtasks based on search intent and executes them sequentially, improving search relevance and efficiency.
- ⚙️ **Agent Architecture**: Based on **LangGraph** encapsulated **“web_search”** and **“link_parser”** modules.
- 🏃‍♂️ **Asynchronous Concurrent Task Handling**: Supports asynchronous concurrent task processing for efficient handling of multiple search tasks.
- 📝 **Content Processing Optimization**:

  - ✂️ **Content Slicing**: Splits long web content into segments.

  - 🔄 **Content Reordering**: Intelligently reorders content to enhance information relevance.

  - 🚫 **Content Filtering**: Automatically removes irrelevant or duplicate content.
- 🌐 **Multi-Platform Support**:

  - 🖥️ Provides FastAPI backend interfaces, integrable into any system.

  - 🌍 Provides Gradio Web UI for quick deployment as a visual application.
  
  - 🧩[ **Browser Extension Support**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Supports Edge, offering an intelligent URL parsing extension to initiate web parsing and content extraction requests directly in the browser.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Quick Start

### 1. Clone the Repository


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---