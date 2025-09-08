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

# 🧠 Proxyloze LLM Webzoekmachine

Een proxyloze multi-zoekmachine LLM-web retrieval tool, ondersteunt URL-inhoudsanalyse en webpagina crawling, combineert **LangGraph** en **LangGraph-MCP** voor modulaire agent-chaining. Speciaal ontworpen voor externe kennisoproep door grote taalmodellen, ondersteunt **Playwright + Crawl4AI** voor webpagina-ophaling en -analyse, ondersteunt asynchrone parallelle verwerking, inhoudssnijden en herordening/filtering.

## 🚀 Changelog

- 🔥 2025-09-05: Ondersteuning voor **langgraph-mcp**
- 🔥 2025-09-03: Nieuwe Docker-implementatie, ingebouwde slimme herordener, ondersteuning voor aangepaste tekstsplitters en herordenaars

## ✨ Overzicht van functies

- 🌐 **Geen proxy nodig**: Via Playwright-configuratie wordt ondersteuning voor Chinese browsers geboden, waardoor zoeken op het web mogelijk is zonder proxy.
- 🔍 **Ondersteuning voor meerdere zoekmachines**: Ondersteunt Bing, Quark, Baidu, Sogou en andere populaire zoekmachines, wat de diversiteit van informatiebronnen vergroot.
- 🤖 **Intentieherkenning**: Het systeem kan op basis van de invoer van de gebruiker automatisch bepalen of het een webzoekopdracht of een URL-analyse betreft.
- 🔄 **Query-ontleding**: Op basis van de zoekintentie van de gebruiker wordt de zoekopdracht automatisch opgesplitst in meerdere subtaken, die vervolgens worden uitgevoerd om de relevantie en efficiëntie van de zoekopdracht te verbeteren.
- ⚙️ **Agentarchitectuur**: Gebaseerd op **LangGraph** en omvat **"web_search"** en **"link_parser"**.
- 🏃‍♂️ **Asynchrone en gelijktijdige taakverwerking**: Ondersteunt asynchrone gelijktijdige taakverwerking en kan efficiënt meerdere zoekopdrachten afhandelen.
- 📝 **Optimalisatie van inhoudsverwerking**:

  - ✂️ **Inhoudsnedes**: Lange webpagina-inhoud wordt per sectie gesplitst.

  - 🔄 **Herindeling van inhoud**: Intelligente herschikking om informatie-relevantie te verbeteren.

  - 🚫 **Inhoudsfiltering**: Automatisch verwijderen van irrelevante of dubbele inhoud.
- 🌐 **Multiplatform ondersteuning**:
  - 🐳 **Ondersteunt Docker-deployment**: Eén-klik-opstart, snelle opbouw van backend-diensten.

  - 🖥️ FastAPI-backendinterface beschikbaar, integreerbaar in elk systeem.

  - 🌍 Gradio Web UI beschikbaar, snel te deployen als visuele applicatie.

  - 🧩[ **Ondersteuning voor browserextensies**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Ondersteunt Edge, biedt een slimme URL-analyse-extensie waarmee direct vanuit de browser webanalyse en inhoudsextractieverzoeken kunnen worden verzonden.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Snel aan de slag

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

## 🔍 Vergelijking met online netwerkzoektests

We vergelijken het project met enkele toonaangevende online API's en beoordelen hun prestaties bij complexe vraagstukken.

### 🔥 Dataset

- De dataset is afkomstig van Alibaba's [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA), bevat 680 moeilijke vragen en bestrijkt diverse domeinen zoals onderwijs, academische conferenties en games.
- De dataset bevat zowel Chinese als Engelse vragen.

### 🧑‍🏫 Vergelijkingsresultaten

| Zoekmachine/Systeem | ✅ Correct | ❌ Incorrect | ⚠️ Gedeeltelijk correct |
| ------------------- | ---------- | ------------ | ----------------------- |
| **Volcano Ark**     | 5,00%      | 72,21%       | 22,79%                  |
| **Bailian**         | 9,85%      | 62,79%       | 27,35%                  |
| **Onze**            | 19,85%     | 47,94%       | 32,06%                  |
## 🙏 Dankwoord

Enkele functies van dit project zijn mogelijk gemaakt en geïnspireerd door de volgende open source projecten. Onze oprechte dank:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Voor het opzetten van een modulair agent-framework, dat helpt bij het snel bouwen van complexe agent-systemen.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Een krachtige tool voor webinhoudsanalyse, die efficiënt webscrapen en data-extractie ondersteunt.
- 🌐 [Playwright](https://github.com/microsoft/playwright): Moderne browserautomatiseringstool die cross-browser webscraping en testautomatisering ondersteunt.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): Voor de bouw van multi-chain verwerking MCP.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---