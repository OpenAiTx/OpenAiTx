<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
# 🧠 Motore di ricerca LLM senza proxy

Uno strumento di recupero web LLM multi-motore che non richiede proxy, supporta l'analisi del contenuto degli URL e lo scraping delle pagine web, realizzato tramite **LangGraph** e **LangGraph-MCP** per una catena modulare di agenti intelligenti. Progettato per scenari di chiamata a conoscenze esterne per i grandi modelli linguistici, supporta il recupero e l'analisi delle pagine con **Playwright + Crawl4AI**, nonché la concorrenza asincrona, il slicing dei contenuti e il filtraggio/reordering.

## 🚀 Registro degli aggiornamenti

- 🔥 2025-09-05: Supporto a **langgraph-mcp**
- 🔥 2025-09-03: Nuovo deploy Docker, riordinatore intelligente integrato, supporto per splitter di testo e riordinatore personalizzati

## ✨ Panoramica delle funzionalità

- 🌐 **Nessun bisogno di proxy**: Tramite la configurazione di Playwright, supporto ai browser nazionali senza necessità di proxy per effettuare ricerche online.
- 🔍 **Supporto a motori di ricerca multipli**: Supporta Bing, Quark, Baidu, Sogou e altri motori di ricerca principali, aumentando la varietà delle fonti di informazione.
- 🤖 **Riconoscimento dell’intento**: Il sistema può determinare automaticamente se effettuare una ricerca web o analizzare un URL in base all’input dell’utente.
- 🔄 **Scomposizione delle query**: In base all’intento di ricerca dell’utente, suddivide automaticamente la query in più sotto-task ed esegue ciascuno in sequenza, migliorando pertinenza ed efficienza della ricerca.
- ⚙️ **Architettura degli agenti**: Basata su **LangGraph** con **«web_search»** e **«link_parser»** integrati.
- 🏃‍♂️ **Gestione di task asincroni e concorrenti**: Supporta l’elaborazione asincrona e concorrente dei task, consentendo una gestione efficiente di più ricerche.
- 📝 **Ottimizzazione del trattamento dei contenuti**:

  - ✂️ **Suddivisione dei contenuti**: I contenuti lunghi delle pagine web vengono suddivisi in sezioni.

  - 🔄 **Riordinamento dei contenuti**: Riordino intelligente per aumentare la pertinenza delle informazioni.

  - 🚫 **Filtraggio dei contenuti**: Rimozione automatica dei contenuti irrilevanti o duplicati.
- 🌐 **Supporto multi-piattaforma**:
  - 🐳 **Supporto per il deployment Docker**: Avvio con un click, costruzione rapida del servizio backend.

  - 🖥️ Backend FastAPI disponibile, integrabile in qualsiasi sistema.

  - 🌍 Interfaccia Web Gradio disponibile, per una rapida conversione in applicazione visuale.

  - 🧩[ **Supporto plugin browser**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Supporta Edge, offre plugin di analisi URL intelligente, per richiedere parsing e estrazione contenuti direttamente dal browser.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Avvio rapido

### Clona il repository

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Installazione delle dipendenze

```
pip install -r requirements.txt
python -m playwright install
```

### Configurazione delle variabili d'ambiente

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

#### API SERVE

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

#### Avvio del servizio MCP

```
python mcp/websearch.py
```

#### DEMO

```
python mcp/demo.py
```

#### API SERVE

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

### Moduli personalizzati

#### Suddivisione personalizzata

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

#### Riordinamento personalizzato

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

## 🔍 Confronto con i test di ricerca online

Abbiamo confrontato il progetto con alcune delle principali API online, valutando le loro prestazioni su domande complesse.

### 🔥 Dataset

- Il dataset proviene da [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) pubblicato da Alibaba, e contiene 680 domande ad alta difficoltà che coprono vari settori come istruzione, conferenze accademiche, giochi e altro.
- Il dataset include domande sia in cinese che in inglese.

### 🧑‍🏫 Risultati del confronto

| Motore di ricerca/Sistema | ✅ Corretto | ❌ Errato | ⚠️ Parzialmente corretto |
| ------------------------ | ---------- | -------- | ----------------------- |
| **Volcano Ark**          | 5,00%      | 72,21%   | 22,79%                  |
| **Bailian**              | 9,85%      | 62,79%   | 27,35%                  |
| **Our**                  | 19,85%     | 47,94%   | 32,06%                  |
## 🙏 Ringraziamenti

Alcune funzionalità di questo progetto sono state rese possibili grazie al supporto e all’ispirazione dei seguenti progetti open source, che desideriamo ringraziare:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): utilizzato per costruire un framework modulare di collegamento tra agenti, facilitando la rapida creazione di sistemi di agenti complessi.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): potente strumento di parsing dei contenuti web, aiuta nell’estrazione efficiente di dati e scraping di pagine web.
- 🌐 [Playwright](https://github.com/microsoft/playwright): moderno strumento di automazione browser, supporta lo scraping web e i test automatizzati cross-browser.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): utilizzato per la costruzione di MCP multi-chain.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---