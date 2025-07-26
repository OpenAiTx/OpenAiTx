
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

# 🧠 프록시 없이 사용하는 LLM 웹 검색 엔진

프록시 없이 다중 검색 엔진을 지원하는 LLM 웹 검색 도구로, URL 내용 분석 및 웹 크롤링을 지원하며 LangGraph와 결합하여 모듈식 에이전트 체인을 구현합니다. 대형 언어 모델의 외부 지식 호출을 위해 설계되었으며 **Playwright + Crawl4AI** 기반 웹 페이지 수집 및 분석, 비동기 병렬 처리, 콘텐츠 슬라이싱 및 재정렬 필터링을 지원합니다.

## ✨ 주요 특징

- 🌐 **프록시 불필요**: Playwright를 통한 국내 브라우저 구성으로, 프록시 없이도 웹 검색이 가능합니다.
- 🔍 **다중 검색 엔진 지원**: Bing, Quark, Baidu, Sogou 등 주요 검색 엔진을 지원하여 정보 출처의 다양성을 높입니다.
- 🤖 **의도 인식**: 시스템이 사용자의 입력 내용을 기반으로 웹 검색 또는 URL 해석이 필요한지 자동으로 판단합니다.
- 🔄 **쿼리 분해**: 사용자의 검색 의도에 따라 쿼리를 여러 하위 작업으로 자동 분해하여 순차적으로 실행함으로써 검색의 관련성과 효율을 높입니다.
- ⚙️ **에이전트 아키텍처**: **LangGraph** 기반으로 패키징된 **「web_search」**와 **「link_parser」**를 제공합니다.
- 🏃‍♂️ **비동기 병렬 작업 처리**: 비동기 병렬 처리를 지원하여 여러 검색 작업을 효율적으로 처리할 수 있습니다.
- 📝 **콘텐츠 처리 최적화**:

  - ✂️ **콘텐츠 슬라이싱**: 긴 웹 페이지 내용을 단락별로 분할합니다.

  - 🔄 **콘텐츠 재정렬**: 스마트한 순서 재배치로 정보의 관련성을 높입니다.

  - 🚫 **콘텐츠 필터링**: 무관하거나 중복된 내용을 자동으로 제거합니다.
- 🌐 **멀티 플랫폼 지원**:

  - 🖥️ FastAPI 백엔드 API 제공으로, 어떤 시스템에도 쉽게 통합할 수 있습니다.

  - 🌍 Gradio Web UI 제공으로, 시각화된 애플리케이션으로 빠르게 배포할 수 있습니다.
  
  - 🧩[ **브라우저 확장 프로그램 지원**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension)：Edge 지원, 스마트 URL 분석 확장 프로그램 제공, 브라우저 내에서 직접 웹 페이지 분석 및 콘텐츠 추출 요청 가능.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ 빠른 시작

### 1. 저장소 클론하기

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```
### 2. 의존성 설치


```
pip install -r requirements.txt
python -m playwright install
```
### 3. 빠른 시작

#### 환경 변수 설정


```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```
#### 데모


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
#### 백엔드 API


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

## 🔍 온라인 네트워크 검색 테스트 비교

우리는 프로젝트를 일부 주류 온라인 API와 비교하여 복잡한 문제에서의 성능을 평가했습니다.

### 🔥 데이터셋

- 데이터셋은 알리바바에서 발표한 [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA)에서 가져왔으며, 680개의 고난이도 문제를 포함하고 교육, 학술 회의, 게임 등 여러 분야를 포괄합니다.
- 데이터셋에는 중문과 영문 문제가 포함되어 있습니다.

### 🧑‍🏫 비교 결과

| 검색 엔진/시스템  | ✅ 정답 | ❌ 오답 | ⚠️ 부분 정답 |
| -------------- | ------- | ------- | ------------ |
| **화산방주**    | 5.00%   | 72.21%  | 22.79%       |
| **백련**       | 9.85%   | 62.79%  | 27.35%       |
| **우리**       | 19.85%  | 47.94%  | 32.06%       |

## 🙏 감사의 말씀

본 프로젝트의 일부 기능은 다음 오픈소스 프로젝트들의 지원과 영감으로 가능했으며, 이에 감사드립니다:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): 모듈화된 지능형 에이전트 링크 프레임워크 구축에 사용됨.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): 강력한 웹페이지 콘텐츠 파싱 도구.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---