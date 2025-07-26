
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

# 🧠 Proxyloze LLM-webzoekmachine

Een proxyloze LLM-webzoektool met meerdere zoekmachines, die URL-inhoudsanalyse en webscraping ondersteunt, gecombineerd met LangGraph voor modulaire agent-ketens. Speciaal ontworpen voor scenario's waarin grote taalmodellen externe kennis moeten raadplegen, met ondersteuning voor **Playwright + Crawl4AI** voor webpagina-acquisitie en -analyse, asynchrone taken, inhoudssegmentatie en herschikking/filtering.

## ✨ Belangrijkste functies

- 🌐 **Geen proxy nodig**: Ondersteunt binnenlandse browsers via Playwright-configuratie, waardoor zoeken op het web zonder proxy mogelijk is.
- 🔍 **Ondersteuning voor meerdere zoekmachines**: Ondersteunt Bing, Quark, Baidu, Sogou en andere populaire zoekmachines voor meer diverse informatiebronnen.
- 🤖 **Intentieherkenning**: Het systeem kan automatisch bepalen of het een webzoekopdracht moet uitvoeren of een URL moet analyseren op basis van de gebruikersinput.
- 🔄 **Query-ontleding**: Splitst zoekopdrachten automatisch op in meerdere subtaken volgens de zoekintentie van de gebruiker, en voert deze achtereenvolgens uit voor hogere relevantie en efficiëntie.
- ⚙️ **Agentarchitectuur**: Op basis van **LangGraph** met de modules **"web_search"** en **"link_parser"**.
- 🏃‍♂️ **Asynchrone en gelijktijdige taakverwerking**: Ondersteunt het efficiënt verwerken van meerdere zoekopdrachten tegelijk.
- 📝 **Geoptimaliseerde inhoudsverwerking**:

  - ✂️ **Inhoudssegmentatie**: Splitst lange webinhoud op in segmenten.

  - 🔄 **Herschikking van inhoud**: Intelligente herschikking voor verhoogde informatierelatie.

  - 🚫 **Inhoudsfiltering**: Automatisch verwijderen van irrelevante of dubbele inhoud.
- 🌐 **Ondersteuning voor meerdere platformen**:

  - 🖥️ Biedt FastAPI-backend, te integreren in elk systeem.

  - 🌍 Gradio Web UI voor snelle visuele implementatie.
  
  - 🧩[ **Browserextensie-ondersteuning**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Ondersteuning voor Edge, slimme URL-analyse-extensie, direct webpagina-analyse en inhoudsextractie in de browser.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Snel starten

### 1. Repository klonen

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Installatie van afhankelijkheden

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Snel starten

#### Configuratie van omgevingsvariabelen

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

#### Backend-api

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

## 🔍 Vergelijking met online websearch-tests

We hebben het project vergeleken met enkele gangbare online API’s om de prestaties bij complexe vraagstukken te beoordelen.

### 🔥 Dataset

- De dataset is afkomstig van [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) uitgebracht door Alibaba en bevat 680 complexe vragen, verdeeld over onderwijs, wetenschappelijke conferenties, games en andere domeinen.
- De dataset bevat zowel Chinese als Engelse vragen.

### 🧑‍🏫 Vergelijkingsresultaten

| Zoekmachine/systeem  | ✅ Correct | ❌ Incorrect | ⚠️ Gedeeltelijk correct |
| -------------------- | --------- | ----------- | ---------------------- |
| **Volcano Ark**      | 5,00%     | 72,21%      | 22,79%                 |
| **Bailian**          | 9,85%     | 62,79%      | 27,35%                 |
| **Onze**             | 19,85%    | 47,94%      | 32,06%                 |

## 🙏 Dankbetuiging

Sommige functies van dit project zijn mogelijk gemaakt door de steun en inspiratie van de volgende open source-projecten. Onze dank daarvoor:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Voor het bouwen van een modulaire agent linkage framework.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Krachtige tool voor het parseren van webinhoud.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---