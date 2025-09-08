<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# 🧠 Bezproxyowy silnik wyszukiwania internetowego LLM

Wielosilnikowe narzędzie LLM do wyszukiwania w Internecie bez potrzeby korzystania z proxy, obsługujące analizę zawartości URL i pobieranie stron internetowych, łączące **LangGraph** oraz **LangGraph-MCP** w celu realizacji modularnych łańcuchów agentów. Zaprojektowane specjalnie do wykorzystania zewnętrznej wiedzy przez duże modele językowe, obsługuje pobieranie i analizę stron przez **Playwright + Crawl4AI**, wspiera asynchroniczność, równoległość, dzielenie treści i filtrowanie oraz re-ranking.

## 🚀 Dziennik zmian

- 🔥 2025-09-05: Wsparcie dla **langgraph-mcp**
- 🔥 2025-09-03: Nowe wdrożenie Docker, wbudowany inteligentny re-ranker, wsparcie dla niestandardowych segmentatorów i re-rankerów tekstu

## ✨ Przegląd funkcji

- 🌐 **Brak potrzeby proxy**: Dzięki konfiguracji Playwright dla przeglądarek krajowych, możliwe jest wyszukiwanie w sieci bez użycia proxy.
- 🔍 **Wsparcie wielu wyszukiwarek**: Obsługuje główne wyszukiwarki, takie jak Bing, Quark, Baidu, Sogou, zwiększając różnorodność źródeł informacji.
- 🤖 **Rozpoznawanie intencji**: System automatycznie rozpoznaje, czy użytkownik chce wyszukać w internecie, czy przeanalizować URL, na podstawie treści wejściowej.
- 🔄 **Rozbijanie zapytań**: Na podstawie intencji użytkownika, zapytania są automatycznie dzielone na podzadania i wykonywane kolejno, zwiększając trafność i efektywność wyszukiwania.
- ⚙️ **Architektura agentowa**: Bazuje na **LangGraph**, obejmuje **"web_search"** oraz **"link_parser"**.
- 🏃‍♂️ **Asynchroniczna i równoległa obsługa zadań**: Obsługuje asynchroniczne i równoległe przetwarzanie zadań, umożliwiając wydajną obsługę wielu wyszukiwań.
- 📝 **Optymalizacja przetwarzania treści**:

  - ✂️ **Dzielenie treści**: Długie treści na stronach internetowych dzielone są na fragmenty.

  - 🔄 **Przestawianie treści**: Inteligentna reorganizacja, zwiększająca trafność informacji.

  - 🚫 **Filtrowanie treści**: Automatyczne usuwanie nieistotnych lub powtarzających się informacji.
- 🌐 **Wsparcie dla wielu platform**:
  - 🐳 **Wsparcie dla wdrożenia w Dockerze**: Uruchomienie jednym kliknięciem, szybkie budowanie usług backendowych.

  - 🖥️ Dostępne API FastAPI dla backendu, możliwa integracja z dowolnym systemem.

  - 🌍 Dostępny Gradio Web UI, umożliwiający szybkie wdrożenie aplikacji wizualnej.

  - 🧩[ **Wsparcie dla wtyczek przeglądarkowych**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Wsparcie dla Edge, inteligentny plugin do analizy URL, pozwalający na bezpośrednie wysyłanie zapytań o analizę i ekstrakcję treści w przeglądarce.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Szybki start

### Klonowanie repozytorium

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Instalacja zależności

```
pip install -r requirements.txt
python -m playwright install
```

### Konfiguracja zmiennych środowiskowych

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

#### DEMO

```shell
python agent/demo.py
```

#### SERWER API

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

#### Uruchamianie usługi MCP

```
python mcp/websearch.py
```

#### DEMO

```
python mcp/demo.py
```

#### SERWER API

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

### Moduły niestandardowe

#### Niestandardowe podziały na bloki

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

#### Niestandardowe przestawianie

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

## 🔍 Porównanie z testem wyszukiwania online

Porównaliśmy nasz projekt z kilkoma popularnymi API online, aby ocenić jego wydajność przy złożonych problemach.

### 🔥 Zbiór danych

- Zbiór danych pochodzi z publikacji Ali [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), zawiera 680 trudnych pytań, obejmujących edukację, konferencje naukowe, gry i inne dziedziny.
- Zbiór danych zawiera pytania w języku chińskim i angielskim.

### 🧑‍🏫 Wyniki porównania

| Wyszukiwarka/System | ✅ Poprawne | ❌ Niepoprawne | ⚠️ Częściowo poprawne |
| ------------------- | ---------- | ------------- | --------------------- |
| **Volcano Ark**     | 5,00%      | 72,21%        | 22,79%                |
| **Bailian**         | 9,85%      | 62,79%        | 27,35%                |
| **Our**             | 19,85%     | 47,94%        | 32,06%                |
## 🙏 Podziękowania

Część funkcji tego projektu została zainspirowana i wsparta przez następujące projekty open-source, za co serdecznie dziękujemy:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): służy do budowy modułowych frameworków agentów, umożliwiając szybkie tworzenie złożonych systemów agentowych.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): zaawansowane narzędzie do analizy treści stron internetowych, wspierające efektywne pobieranie i ekstrakcję danych.
- 🌐 [Playwright](https://github.com/microsoft/playwright): nowoczesne narzędzie do automatyzacji przeglądarek, umożliwiające cross-browser web scraping i automatyzację testów.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): służy do budowania obsługi MCP dla wielu łańcuchów.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---