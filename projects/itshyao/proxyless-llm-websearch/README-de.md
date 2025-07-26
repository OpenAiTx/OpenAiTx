
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# 🧠 Proxylose LLM-Websuchmaschine

Ein Proxy-loses, Multi-Suchmaschinen-LLM-Webrecherche-Tool, das URL-Inhaltsanalyse und Web-Crawling unterstützt und mit LangGraph eine modulare Agentenverkettung ermöglicht. Speziell für externe Wissensabrufe großer Sprachmodelle konzipiert, unterstützt **Playwright + Crawl4AI** zum Webseitenabruf und -parsing, asynchrone Parallelverarbeitung, Inhaltsslicing und Re-Ranking-Filterung.

## ✨ Funktionsübersicht

- 🌐 **Kein Proxy erforderlich**: Über Playwright mit inländischer Browserunterstützung konfigurierbar, Websuche auch ohne Proxy möglich.
- 🔍 **Mehrere Suchmaschinen unterstützt**: Unterstützung von Bing, Quark, Baidu, Sogou und weiteren führenden Suchmaschinen für vielfältige Informationsquellen.
- 🤖 **Intent-Erkennung**: Das System erkennt anhand der Nutzereingabe automatisch, ob eine Websuche oder eine URL-Analyse durchgeführt werden soll.
- 🔄 **Abfrageaufteilung**: Entsprechend der Suchabsicht des Nutzers werden Suchanfragen automatisch in mehrere Teilaufgaben zerlegt und nacheinander ausgeführt, um Relevanz und Effizienz zu steigern.
- ⚙️ **Agenten-Architektur**: Basierend auf **LangGraph** gekapselte **„web_search“** und **„link_parser“**.
- 🏃‍♂️ **Asynchrone Parallelverarbeitung**: Unterstützt asynchrone parallele Aufgabenverarbeitung zur effizienten Abwicklung mehrerer Suchaufträge.
- 📝 **Optimierte Inhaltsverarbeitung**:

  - ✂️ **Inhaltsslicing**: Lange Webseiteninhalte werden abschnittsweise aufgeteilt.

  - 🔄 **Inhaltsneuanordnung**: Intelligente Umstrukturierung zur Steigerung der Informationsrelevanz.

  - 🚫 **Inhaltsfilterung**: Automatisches Entfernen irrelevanter oder doppelter Inhalte.
- 🌐 **Multi-Plattform-Unterstützung**:

  - 🖥️ FastAPI-Backend-Schnittstelle, integrierbar in beliebige Systeme.

  - 🌍 Gradio Web-UI zur schnellen Bereitstellung als Visualisierungslösung.
  
  - 🧩[ **Unterstützung für Browser-Plugins**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Unterstützung für Edge, bietet intelligentes URL-Parsing-Plugin, um Webseitenanalyse und Inhaltsextraktion direkt im Browser zu starten.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Schnellstart

### 1. Repository klonen

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Abhängigkeiten installieren

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Schnellstart

#### Konfiguration der Umgebungsvariablen

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### Demo

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

#### Backend-API

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

## 🔍 Vergleich mit Online-Websuche-Tests

Wir haben das Projekt mit einigen gängigen Online-APIs verglichen und seine Leistung bei komplexen Fragestellungen bewertet.

### 🔥 Datensatz

- Der Datensatz stammt von [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), veröffentlicht von Alibaba, und enthält 680 schwierige Fragen aus verschiedenen Bereichen wie Bildung, wissenschaftliche Konferenzen, Spiele usw.
- Der Datensatz umfasst sowohl chinesische als auch englische Fragen.

### 🧑‍🏫 Vergleichsergebnisse

| Suchmaschine/System  | ✅ Korrekt | ❌ Falsch | ⚠️ Teilweise korrekt |
| -------------------- | ----------| ----------| -------------------- |
| **Volcano Ark**      | 5,00%     | 72,21%    | 22,79%               |
| **Bailian**          | 9,85%     | 62,79%    | 27,35%               |
| **Unser**            | 19,85%    | 47,94%    | 32,06%               |

## 🙏 Danksagung

Einige Funktionen dieses Projekts wurden durch die Unterstützung und Inspiration folgender Open-Source-Projekte ermöglicht:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Zum Aufbau modularer Agenten-Frameworks.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Leistungsstarkes Tool zur Analyse von Webseiteninhalten.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---