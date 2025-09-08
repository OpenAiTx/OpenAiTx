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

# 🧠 Proxyloses LLM-Websuchsystem

Ein Proxy-loses Multi-Suchmaschinen-LLM-Web-Retrieval-Tool, das die Analyse von URL-Inhalten und Web-Scraping unterstützt und eine modulare Agentenkette mit **LangGraph** und **LangGraph-MCP** realisiert. Entwickelt für die Einbindung von externem Wissen in große Sprachmodelle, unterstützt **Playwright + Crawl4AI** für Webzugriff und -analyse sowie asynchrone Parallelisierung, Content-Slicing und Re-Ranking-Filterung.

## 🚀 Changelog

- 🔥 2025-09-05: Unterstützung für **langgraph-mcp**
- 🔥 2025-09-03: Docker-Deployment hinzugefügt, eingebauter intelligenter Re-Ranker, Unterstützung für benutzerdefinierten Text-Splitter und Re-Ranker

## ✨ Feature-Übersicht

- 🌐 **Kein Proxy erforderlich**: Durch die Playwright-Konfiguration wird die Unterstützung für inländische Browser ermöglicht, sodass Netzrecherche ohne Proxy durchgeführt werden kann.
- 🔍 **Unterstützung mehrerer Suchmaschinen**: Unterstützt Bing, Quark, Baidu, Sogou und andere gängige Suchmaschinen, um die Vielfalt der Informationsquellen zu erhöhen.
- 🤖 **Intent-Erkennung**: Das System kann anhand der Nutzereingabe automatisch erkennen, ob eine Websuche oder eine URL-Analyse durchgeführt werden soll.
- 🔄 **Abfragezerlegung**: Je nach Suchabsicht des Nutzers werden Anfragen automatisch in mehrere Teilaufgaben zerlegt und nacheinander ausgeführt, um Relevanz und Effizienz zu steigern.
- ⚙️ **Agentenarchitektur**: Basierend auf **LangGraph** wurden die Agenten **„web_search“** und **„link_parser“** implementiert.
- 🏃‍♂️ **Asynchrone Parallelverarbeitung von Aufgaben**: Unterstützt asynchrone und parallele Aufgabenverarbeitung und kann mehrere Suchaufgaben effizient bewältigen.
- 📝 **Optimierte Inhaltsverarbeitung**:

  - ✂️ **Inhaltsschnitt**: Lange Webseiteninhalte werden segmentiert.

  - 🔄 **Inhalts-Neuordnung**: Intelligente Neusortierung zur Erhöhung der Informationsrelevanz.

  - 🚫 **Inhaltsfilterung**: Automatisches Entfernen irrelevanter oder doppelter Inhalte.
- 🌐 **Multi-Plattform-Unterstützung**:
  - 🐳 **Docker-Deployment-Unterstützung**: Ein-Klick-Start für schnellen Aufbau von Backend-Diensten.

  - 🖥️ FastAPI-Backend-Schnittstelle wird bereitgestellt und kann in jedes System integriert werden.

  - 🌍 Gradio Web UI verfügbar, kann schnell als visuelle Anwendung bereitgestellt werden.

  - 🧩[ **Browser-Plugin-Unterstützung**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge-Unterstützung, intelligentes URL-Parsing-Plugin, ermöglicht direktes Parsen und Extrahieren von Webseiteninhalten im Browser.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Schnellstart

### Repository klonen

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Abhängigkeiten installieren

```
pip install -r requirements.txt
python -m playwright install
```

### Umgebungsvariablenkonfiguration

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

#### API-BEREITSTELLUNG

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

#### Starten des MCP-Dienstes

```
python mcp/websearch.py
```

#### DEMO

```
python mcp/demo.py
```

#### API-BEREITSTELLUNG

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

#### Docker

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### Benutzerdefinierte Module

#### Benutzerdefinierte Blockierung

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

#### Benutzerdefinierte Neuordnung

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

## 🔍 Vergleich mit Online-Netzwerksuchtests

Wir haben das Projekt mit einigen führenden Online-APIs verglichen und dessen Leistung bei komplexen Fragestellungen bewertet.

### 🔥 Datensatz

- Der Datensatz stammt aus Alis Veröffentlichung [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) und enthält 680 schwierige Fragen aus Bereichen wie Bildung, wissenschaftliche Konferenzen, Spiele und mehr.
- Der Datensatz umfasst sowohl chinesische als auch englische Fragen.

### 🧑‍🏫 Vergleichsergebnisse

| Suchmaschine/System | ✅ Korrekt | ❌ Falsch | ⚠️ Teilweise korrekt |
| ------------------- | ----------| ---------| --------------------|
| **Volcano Ark**     | 5,00%     | 72,21%   | 22,79%              |
| **Bailian**         | 9,85%     | 62,79%   | 27,35%              |
| **Unser**           | 19,85%    | 47,94%   | 32,06%              |
## 🙏 Danksagung

Einige Funktionen dieses Projekts wurden durch die Unterstützung und Inspiration der folgenden Open-Source-Projekte ermöglicht. Unser besonderer Dank gilt:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Zum Aufbau eines modularen Agenten-Frameworks, das den schnellen Aufbau komplexer Agentensysteme ermöglicht.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Leistungsstarkes Tool zur Analyse von Webseiteninhalten, das effizientes Crawling und Datenextraktion unterstützt.
- 🌐 [Playwright](https://github.com/microsoft/playwright): Modernes Browser-Automatisierungstool zur plattformübergreifenden Web-Erfassung und Testautomatisierung.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): Für die Entwicklung von MCPs zur Multi-Chain-Verarbeitung.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---