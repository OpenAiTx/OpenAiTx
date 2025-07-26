
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

# 🧠 Motor de Búsqueda Web LLM Sin Proxy

Una herramienta de recuperación web LLM multibuscador que no requiere proxy, compatible con el análisis de contenido de URL y rastreo web, combinada con LangGraph para implementar cadenas de agentes modulares. Diseñada para escenarios de consulta de conocimiento externo para grandes modelos de lenguaje, soporta obtención y análisis web mediante **Playwright + Crawl4AI**, admite concurrencia asíncrona, segmentación y reordenamiento de contenidos.

## ✨ Vista general de características

- 🌐 **Sin necesidad de proxy**: Compatible con navegadores locales mediante configuración de Playwright, permite búsquedas web sin proxy.
- 🔍 **Soporte para múltiples motores de búsqueda**: Compatible con Bing, Quark, Baidu, Sogou y otros motores principales, aumentando la diversidad de fuentes de información.
- 🤖 **Reconocimiento de intención**: El sistema puede determinar automáticamente, según el contenido de entrada del usuario, si debe realizar una búsqueda web o analizar una URL.
- 🔄 **Descomposición de consultas**: Según la intención de búsqueda del usuario, descompone la consulta en subtareas que se ejecutan secuencialmente, mejorando la relevancia y eficiencia de la búsqueda.
- ⚙️ **Arquitectura de agentes**: Basada en **LangGraph** encapsulando **「web_search」** y **「link_parser」**.
- 🏃‍♂️ **Procesamiento asíncrono y concurrente de tareas**: Admite procesamiento asíncrono y concurrente, permitiendo gestionar múltiples tareas de búsqueda eficientemente.
- 📝 **Optimización del procesamiento de contenido**:

  - ✂️ **Segmentación de contenido**: Divide el contenido largo de páginas web en secciones.

  - 🔄 **Reordenamiento de contenido**: Reordena inteligentemente para mejorar la relevancia de la información.

  - 🚫 **Filtrado de contenido**: Elimina automáticamente contenido irrelevante o duplicado.
- 🌐 **Soporte multiplataforma**:

  - 🖥️ Proporciona una API backend FastAPI, integrable en cualquier sistema.

  - 🌍 Ofrece una interfaz web Gradio para un despliegue visual rápido.

  - 🧩[ **Soporte para extensiones de navegador**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Soporta Edge, incluye extensión inteligente para análisis de URLs, permitiendo solicitudes directas de análisis y extracción de contenido desde el navegador.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Comenzar rápidamente

### 1. Clona el repositorio

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Instalar dependencias

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Inicio rápido

#### Configuración de variables de entorno

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### demostración

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

## 🔍 Comparación con pruebas de búsqueda web en línea

Comparamos el proyecto con algunas API en línea populares para evaluar su desempeño en preguntas complejas.

### 🔥 Conjunto de datos

- El conjunto de datos proviene de [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) publicado por Alibaba, contiene 680 preguntas de alta dificultad, cubriendo educación, conferencias académicas, juegos y otros campos.
- El conjunto de datos incluye preguntas en chino e inglés.

### 🧑‍🏫 Resultados de la comparación

| Motor de búsqueda/Sistema | ✅ Correcto | ❌ Incorrecto | ⚠️ Parcialmente correcto |
| ------------------------ | ---------- | ------------ | ----------------------- |
| **火山方舟**             | 5.00%      | 72.21%       | 22.79%                  |
| **百炼**                 | 9.85%      | 62.79%       | 27.35%                  |
| **Our**                  | 19.85%     | 47.94%       | 32.06%                  |

## 🙏 Agradecimientos

Algunas funciones de este proyecto se benefician del apoyo e inspiración de los siguientes proyectos de código abierto, a quienes agradecemos especialmente:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): para construir marcos de agentes modulares.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): una potente herramienta de análisis de contenido web.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---