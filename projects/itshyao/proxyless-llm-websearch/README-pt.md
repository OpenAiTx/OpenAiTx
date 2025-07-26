
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

# 🧠 Motor de Busca Web LLM sem Proxy

Uma ferramenta de recuperação web LLM com múltiplos motores de busca, sem necessidade de proxy, que suporta análise de conteúdo de URL e raspagem de páginas, integrando LangGraph para criar cadeias modulares de agentes inteligentes. Projetado para cenários de busca de conhecimento externo por grandes modelos de linguagem, suporta obtenção e análise de páginas com **Playwright + Crawl4AI**, além de processamento assíncrono, fragmentação de conteúdo e reordenação/filtragem.

## ✨ Visão geral dos recursos

- 🌐 **Sem necessidade de proxy**: Suporte a navegadores nacionais via Playwright, permitindo buscas na web sem proxy.
- 🔍 **Suporte a múltiplos motores de busca**: Compatível com Bing, Quark, Baidu, Sogou e outros motores populares, ampliando a diversidade de fontes de informação.
- 🤖 **Reconhecimento de intenção**: O sistema identifica automaticamente se o usuário deseja fazer uma busca na web ou analisar uma URL.
- 🔄 **Decomposição de consulta**: A intenção de busca do usuário é dividida automaticamente em subtarefas, executadas sequencialmente para maior relevância e eficiência.
- ⚙️ **Arquitetura de agentes**: Com base no **LangGraph**, encapsula **"web_search"** e **"link_parser"**.
- 🏃‍♂️ **Processamento assíncrono e concorrente de tarefas**: Suporta execução assíncrona e paralela de múltiplas buscas.
- 📝 **Otimização do processamento de conteúdo**:

  - ✂️ **Fragmentação de conteúdo**: Quebra conteúdos longos em segmentos por parágrafos.

  - 🔄 **Reordenação de conteúdo**: Reorganiza inteligentemente para aumentar a relevância das informações.

  - 🚫 **Filtragem de conteúdo**: Remove automaticamente conteúdos irrelevantes ou duplicados.
- 🌐 **Suporte multiplataforma**:

  - 🖥️ Disponibiliza API backend FastAPI, podendo ser integrado em qualquer sistema.

  - 🌍 Disponibiliza Gradio Web UI, permitindo implantação rápida como aplicação visual.
  
  - 🧩[ **Suporte a extensão para navegador**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Suporta Edge, com plugin inteligente de análise de URLs para extração de conteúdo diretamente no navegador.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Início rápido

### 1. Clonar o repositório

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Instalação de dependências

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Início Rápido

#### Configuração de Variáveis de Ambiente

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### demonstração

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

#### API de backend

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

## 🔍 Comparação com Testes de Pesquisa Online

Comparamos o projeto com algumas APIs online populares, avaliando seu desempenho em questões complexas.

### 🔥 Conjunto de Dados

- O conjunto de dados é proveniente do [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) lançado pela Alibaba, contendo 680 questões de alta dificuldade, abrangendo áreas como educação, conferências acadêmicas, jogos, entre outras.
- O conjunto de dados inclui perguntas em chinês e inglês.

### 🧑‍🏫 Resultados Comparativos

| Motor de Busca/Sistema | ✅ Correto | ❌ Incorreto | ⚠️ Parcialmente Correto |
| ---------------------- | ----------| ------------| ----------------------- |
| **Huoshanafangzhou**   | 5,00%     | 72,21%      | 22,79%                 |
| **Bailian**            | 9,85%     | 62,79%      | 27,35%                 |
| **Nosso**              | 19,85%    | 47,94%      | 32,06%                 |

## 🙏 Agradecimentos

Algumas funcionalidades deste projeto foram possíveis graças ao apoio e inspiração dos seguintes projetos open source:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): usado para construir um framework de agentes modulares.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): poderosa ferramenta de análise de conteúdo web.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---