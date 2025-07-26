
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

# 🧠 Wyszukiwarka LLM bez potrzeby użycia proxy

Narzędzie do wyszukiwania w sieci przez LLM bez potrzeby korzystania z proxy, obsługujące wiele wyszukiwarek, analizę treści URL oraz skanowanie stron, z modułową architekturą agentów opartą na LangGraph. Zaprojektowane z myślą o pozyskiwaniu zewnętrznej wiedzy przez modele językowe. Obsługuje pobieranie i analizę stron przez **Playwright + Crawl4AI**, asynchroniczność, podział treści i filtrację.

## ✨ Przegląd funkcji

- 🌐 **Bez potrzeby proxy**: Dzięki konfiguracji Playwright z przeglądarką krajową, wyszukiwanie w sieci możliwe jest bez proxy.
- 🔍 **Wsparcie wielu wyszukiwarek**: Obsługa głównych wyszukiwarek takich jak Bing, Quark, Baidu, Sogou – większa różnorodność źródeł informacji.
- 🤖 **Rozpoznawanie intencji**: System automatycznie rozpoznaje na podstawie wpisu użytkownika, czy wykonać wyszukiwanie czy analizę URL.
- 🔄 **Rozbijanie zapytań**: Na podstawie intencji użytkownika automatycznie dzieli zapytanie na zadania podrzędne i wykonuje je sekwencyjnie, zwiększając trafność i efektywność wyszukiwania.
- ⚙️ **Architektura agentów**: Oparta na **LangGraph** z modułami **„web_search”** i **„link_parser”**.
- 🏃‍♂️ **Asynchroniczna obsługa zadań**: Wspiera asynchroniczne, współbieżne zadania – efektywne przetwarzanie wielu wyszukiwań.
- 📝 **Optymalizacja przetwarzania treści**:

  - ✂️ **Podział treści**: Długie treści stron dzielone są na fragmenty.

  - 🔄 **Przebudowa treści**: Inteligentne sortowanie, poprawa trafności informacji.

  - 🚫 **Filtrowanie treści**: Automatyczne usuwanie zbędnych lub powtarzających się treści.
- 🌐 **Wsparcie wieloplatformowe**:

  - 🖥️ Interfejs backendowy FastAPI – do integracji z dowolnym systemem.

  - 🌍 Gradio Web UI – szybkie wdrożenie jako aplikacja wizualna.
  
  - 🧩[ **Wsparcie dla wtyczek przeglądarkowych**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Obsługa Edge, inteligentna wtyczka do analizy URL, pozwala na bezpośrednie wysyłanie żądań analizy i ekstrakcji treści z przeglądarki.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Szybki start

### 1. Sklonuj repozytorium

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Instalacja zależności

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Szybki start

#### Konfiguracja zmiennych środowiskowych

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

## 🔍 Porównanie z testami wyszukiwania online

Porównaliśmy projekt z niektórymi popularnymi API online, oceniając jego wydajność przy złożonych pytaniach.

### 🔥 Zbiór danych

- Zbiór danych pochodzi z opublikowanego przez Alibaba [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), zawiera 680 trudnych pytań, obejmujących edukację, konferencje naukowe, gry i inne dziedziny.
- Zbiór danych obejmuje pytania w języku chińskim i angielskim.

### 🧑‍🏫 Wyniki porównania

| Wyszukiwarka/system | ✅ Poprawne | ❌ Niepoprawne | ⚠️ Częściowo poprawne |
| ------------------- | ---------- | ------------- | -------------------- |
| **火山方舟**         | 5,00%      | 72,21%        | 22,79%               |
| **百炼**             | 9,85%      | 62,79%        | 27,35%               |
| **Nasze**           | 19,85%     | 47,94%        | 32,06%               |

## 🙏 Podziękowania

Część funkcjonalności projektu powstała dzięki wsparciu i inspiracji następujących projektów open source, za co serdecznie dziękujemy:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): do budowy modularnych łańcuchów inteligentnych agentów.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): potężne narzędzie do analizy treści stron internetowych.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---