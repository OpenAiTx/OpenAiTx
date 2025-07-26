
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

# 🧠 Motore di Ricerca LLM Senza Proxy

Uno strumento di recupero web per LLM multi-motore di ricerca senza proxy, supporta l'analisi dei contenuti degli URL e il crawling delle pagine web, combinato con LangGraph per realizzare catene di agenti modulari. Progettato per scenari in cui i grandi modelli linguistici richiedono conoscenze esterne, supporta acquisizione e parsing web tramite **Playwright + Crawl4AI**, oltre a supportare elaborazione asincrona, suddivisione e riordino dei contenuti.

## ✨ Panoramica delle Caratteristiche

- 🌐 **Senza Proxy**: tramite la configurazione di Playwright con browser supportati in Cina, si può effettuare la ricerca web senza proxy.
- 🔍 **Supporto Multi-motore di Ricerca**: supporta Bing, Quark, Baidu, Sogou e altri motori di ricerca principali, aumentando la varietà delle fonti informative.
- 🤖 **Riconoscimento dell’Intento**: il sistema può determinare automaticamente, in base all’input dell’utente, se effettuare una ricerca web o analizzare un URL.
- 🔄 **Decomposizione delle Query**: in base all’intento di ricerca dell’utente, suddivide automaticamente la query in più sotto-compiti da eseguire in sequenza, migliorando pertinenza ed efficienza della ricerca.
- ⚙️ **Architettura ad Agenti**: basata su **LangGraph**, include **«web_search»** e **«link_parser»**.
- 🏃‍♂️ **Gestione Asincrona e Concorrente dei Task**: supporta la gestione asincrona e concorrente, consentendo l’elaborazione efficiente di più ricerche.
- 📝 **Ottimizzazione del Trattamento dei Contenuti**:

  - ✂️ **Suddivisione dei Contenuti**: suddivide i contenuti web lunghi in sezioni.

  - 🔄 **Riordino dei Contenuti**: riordino intelligente per aumentare la rilevanza delle informazioni.

  - 🚫 **Filtraggio dei Contenuti**: rimozione automatica di contenuti irrilevanti o duplicati.
- 🌐 **Supporto Multi-piattaforma**:

  - 🖥️ Fornisce API backend FastAPI, integrabile in qualsiasi sistema.

  - 🌍 Offre una Web UI Gradio, per un rapido deployment come applicazione visuale.
  
  - 🧩[ **Supporto Plugin Browser**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): supporta Edge e offre un plugin intelligente per l’analisi degli URL, consentendo parsing e estrazione contenuti direttamente dal browser.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Avvio Rapido

### 1. Clona il repository

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Installazione delle dipendenze

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Avvio rapido

#### Configurazione delle variabili d'ambiente

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

#### API backend

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

## 🔍 Confronto con i test di ricerca online

Abbiamo confrontato il progetto con alcune API online mainstream, valutando le sue prestazioni su domande complesse.

### 🔥 Dataset

- Il dataset proviene dal [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) rilasciato da Alibaba e contiene 680 domande ad alta difficoltà, coprendo campi come istruzione, conferenze accademiche, giochi e altro ancora.
- Il dataset include domande sia in cinese che in inglese.

### 🧑‍🏫 Risultati del confronto

| Motore di ricerca/sistema  | ✅ Corretto | ❌ Errato | ⚠️ Parzialmente corretto |
| --------------------------| ---------- | -------- | ----------------------- |
| **Volcano Ark**           | 5,00%      | 72,21%   | 22,79%                  |
| **Bailian**               | 9,85%      | 62,79%   | 27,35%                  |
| **Our**                   | 19,85%     | 47,94%   | 32,06%                  |

## 🙏 Ringraziamenti

Alcune funzionalità di questo progetto sono state rese possibili e ispirate dai seguenti progetti open source, che ringraziamo:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): utilizzato per costruire framework modulari di agenti intelligenti.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): potente strumento per l'analisi dei contenuti web.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---