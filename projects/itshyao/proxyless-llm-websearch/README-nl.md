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

Een proxyloze multi-zoekmachine LLM web retrieval tool, ondersteunt URL-inhoudsanalyse en webscraping, combineert **LangGraph** en **LangGraph-MCP** voor modulaire agent-ketens. Speciaal ontworpen voor externe kennisopvraagscenario’s met grote taalmodellen, ondersteunt **Playwright + Crawl4AI** voor webverzameling en analyse, ondersteunt asynchrone concurrentie, inhoudssegmentatie en herordening/filtering.

## 🚀 Changelog

- 🔥 2025-09-05: Ondersteuning voor **langgraph-mcp**
- 🔥 2025-09-03: Nieuw: Docker-deployment, ingebouwde slimme herordener, ondersteuning voor aangepaste tekstsegmentatie en herordening

## ✨ Overzicht van functies

- 🌐 **Geen proxy nodig**: Via Playwright-configuratie wordt ondersteuning voor binnenlandse browsers geboden, zodat zoeken op het internet mogelijk is zonder proxy.
- 🔍 **Ondersteuning voor meerdere zoekmachines**: Ondersteunt Bing, Quark, Baidu, Sogou en andere grote zoekmachines, waardoor de diversiteit van informatiebronnen wordt vergroot.
- 🤖 **Intentieherkenning**: Het systeem kan op basis van de invoer van de gebruiker automatisch bepalen of er een webzoekopdracht moet worden uitgevoerd of een URL moet worden geanalyseerd.
- 🔄 **Query-opdeling**: Op basis van de zoekintentie van de gebruiker wordt de query automatisch opgedeeld in meerdere subtaken die achtereenvolgens worden uitgevoerd, waardoor relevantie en efficiëntie van de zoekopdracht worden verbeterd.
- ⚙️ **Agentarchitectuur**: Op basis van **LangGraph** verpakte **"web_search"** en **"link_parser"**.
- 🏃‍♂️ **Asynchrone en gelijktijdige taakverwerking**: Ondersteunt asynchrone en gelijktijdige taakverwerking, waardoor meerdere zoekopdrachten efficiënt kunnen worden verwerkt.
- 📝 **Geoptimaliseerde inhoudsverwerking**:

  - ✂️ **Inhoudsnederzetting**: Lange webpagina-inhoud wordt per segment gesplitst.

  - 🔄 **Herordening van inhoud**: Slimme herschikking om de relevantie van informatie te verhogen.

  - 🚫 **Inhoudsfiltering**: Automatische verwijdering van irrelevante of dubbele inhoud.
- 🌐 **Ondersteuning voor meerdere platforms**:
  - 🐳 **Ondersteunt Docker-deployment**: Met één klik te starten, snelle backend-serviceopbouw.

  - 🖥️ FastAPI backend-interfaces beschikbaar, te integreren in elk systeem.

  - 🌍 Gradio Web UI beschikbaar, eenvoudig te implementeren als visuele applicatie.

  - 🧩[ **Ondersteuning voor browserextensies**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Ondersteunt Edge, biedt een slimme URL-analyse-extensie, waarmee direct in de browser webpagina-analyse en inhoudsextractie kan worden uitgevoerd.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Snel starten

### Repository klonen

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Installatie van afhankelijkheden

```
pip install -r requirements.txt
python -m playwright install
```

### Configuratie van omgevingsvariabelen

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

#### DEMONSTRATIE

```shell
python agent/demo.py
```

#### API SERVEREN

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

#### Start MCP-service

```
python mcp/websearch.py
```

#### DEMONSTRATIE

```
python mcp/demo.py
```

#### API SERVEREN

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

### Aangepaste module

#### Aangepaste blokverdeling

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

#### Aangepaste herschikking

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

## 🔍 Vergelijking met online netwerkinformatie-zoektesten

We hebben het project vergeleken met enkele toonaangevende online API's en hun prestaties bij complexe vraagstukken geëvalueerd.

### 🔥 Dataset

- De dataset is afkomstig van Alibaba's [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), bevat 680 moeilijke vragen en bestrijkt verschillende domeinen zoals onderwijs, academische conferenties en games.
- De dataset bevat zowel Chinese als Engelse vragen.

### 🧑‍🏫 Vergelijkingsresultaten

| Zoekmachine/Systeem | ✅ Correct | ❌ Incorrect | ⚠️ Gedeeltelijk correct |
| ------------------- | --------- | ----------- | ---------------------- |
| **Volcano Ark**     | 5,00%     | 72,21%      | 22,79%                 |
| **Bailian**         | 9,85%     | 62,79%      | 27,35%                 |
| **Onze**            | 19,85%    | 47,94%      | 32,06%                 |
## 🙏 Dankbetuiging

Een deel van de functionaliteit van dit project is te danken aan de ondersteuning en inspiratie van de volgende open source projecten. Onze dank daarvoor:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Gebruikt voor het bouwen van een modulaire agent-link framework, waarmee snel complexe agent-systemen kunnen worden opgebouwd.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Krachtige tool voor het analyseren van webinhoud, ondersteunt efficiënt webscrapen en data-extractie.
- 🌐 [Playwright](https://github.com/microsoft/playwright): Moderne browserautomatiseringstool, ondersteunt webscrapen en testautomatisering over meerdere browsers.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): Gebruikt voor het bouwen van MCP-verwerking over meerdere chains.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---