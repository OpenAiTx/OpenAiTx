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
# 🧠 프록시 없이 사용하는 LLM 웹검색 엔진

프록시가 필요 없는 멀티 검색엔진 기반 LLM 웹 검색 도구로, URL 콘텐츠 파싱과 웹 크롤링을 지원합니다. **LangGraph**와 **LangGraph-MCP**를 결합하여 모듈형 에이전트 체인을 구현합니다. 대형 언어 모델의 외부 지식 활용 환경에 특화되어 있으며, **Playwright + Crawl4AI**를 통한 웹 페이지 수집 및 파싱, 비동기 병렬 처리, 콘텐츠 분할 및 재정렬/필터링을 지원합니다.

## 🚀 업데이트 로그

- 🔥 2025-09-05: **langgraph-mcp** 지원
- 🔥 2025-09-03: Docker 배포 추가, 내장형 스마트 리랭커, 커스텀 텍스트 분할기 및 리랭커 지원

## ✨ 주요 특징 요약

- 🌐 **프록시 불필요**: Playwright를 통해 국내 브라우저 지원을 구성하여 프록시 없이도 네트워크 검색이 가능합니다.
- 🔍 **다중 검색 엔진 지원**: Bing, Quark, Baidu, Sogou 등 주요 검색 엔진을 지원하여 정보 출처의 다양성을 강화합니다.
- 🤖 **의도 인식**: 시스템은 사용자의 입력 내용을 기반으로 네트워크 검색 또는 URL 분석을 자동으로 판단합니다.
- 🔄 **쿼리 분해**: 사용자의 검색 의도에 따라 쿼리를 여러 하위 작업으로 자동 분해하고 순차적으로 실행하여 검색의 관련성과 효율을 높입니다.
- ⚙️ **에이전트 아키텍처**: **LangGraph** 기반으로 래핑된 **「web_search」**와 **「link_parser」**.
- 🏃‍♂️ **비동기 동시 작업 처리**: 비동기 동시 작업 처리 지원으로 여러 검색 작업을 효율적으로 처리할 수 있습니다.
- 📝 **콘텐츠 처리 최적화**:

  - ✂️ **콘텐츠 슬라이싱**: 웹페이지의 긴 내용을 단락별로 분할.

  - 🔄 **콘텐츠 재정렬**: 스마트 재정렬로 정보 관련성을 향상.

  - 🚫 **콘텐츠 필터링**: 불필요하거나 중복된 내용을 자동으로 제거.
- 🌐 **다중 플랫폼 지원**:
  - 🐳 **Docker 배포 지원**: 원클릭 실행으로 백엔드 서비스를 빠르게 구축.

  - 🖥️ FastAPI 백엔드 인터페이스 제공, 어떤 시스템에도 통합 가능.

  - 🌍 Gradio Web UI 제공으로 시각화 애플리케이션을 빠르게 배포.

  - 🧩[ **브라우저 플러그인 지원**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge 지원, 스마트 URL 파싱 플러그인 제공, 브라우저에서 웹페이지 분석 및 콘텐츠 추출 요청 직접 가능.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ 빠른 시작

### 저장소 클론

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 의존성 설치

```
pip install -r requirements.txt
python -m playwright install
```

### 환경 변수 구성

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

#### 데모

```shell
python agent/demo.py
```

#### API 제공

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

#### 그라디오

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

#### MCP 서비스 시작

```
python mcp/websearch.py
```

#### 데모

```
python mcp/demo.py
```

#### API 서브

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

#### 도커

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### 사용자 정의 모듈

#### 사용자 정의 블록

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

#### 사용자 지정 재배열

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

## 🔍 온라인 네트워크 검색 테스트와의 비교

프로젝트를 주요 온라인 API와 비교하여 복잡한 문제에서의 성능을 평가했습니다.

### 🔥 데이터셋

- 데이터셋은 알리에서 공개한 [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA)에서 가져왔으며, 교육, 학술대회, 게임 등 다양한 분야를 아우르는 680개의 고난도 문제가 포함되어 있습니다.
- 데이터셋에는 중문 및 영문 문제가 포함되어 있습니다.

### 🧑‍🏫 비교 결과

| 검색엔진/시스템  | ✅ 정답 | ❌ 오답 | ⚠️ 부분 정답 |
| -------------- | ------- | ------- | ------------ |
| **화산방주**   | 5.00%   | 72.21%  | 22.79%       |
| **백련**       | 9.85%   | 62.79%  | 27.35%       |
| **Our** | 19.85%  | 47.94%  | 32.06%       |
## 🙏 감사의 글

본 프로젝트의 일부 기능은 다음 오픈소스 프로젝트의 지원 및 영감에서 얻었습니다. 이에 감사의 뜻을 전합니다.

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph)：모듈형 에이전트 체인 프레임워크 구축에 활용, 복잡한 에이전트 시스템을 빠르게 구성할 수 있도록 지원.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai)：강력한 웹 콘텐츠 파싱 도구로, 웹 크롤링 및 데이터 추출의 효율성을 높여줍니다.
- 🌐 [Playwright](https://github.com/microsoft/playwright)：최신 브라우저 자동화 도구로, 크로스 브라우저 웹 크롤링과 테스트 자동화를 지원합니다.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters)：다중 체인 MCP 처리 구축에 사용됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---