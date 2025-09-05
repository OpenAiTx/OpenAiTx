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
# 🧠 Motor de búsqueda web LLM sin proxy

Una herramienta de recuperación web LLM multi-motor sin necesidad de proxy, compatible con análisis de contenido de URL y rastreo de páginas web, que integra **LangGraph** y **LangGraph-MCP** para lograr una cadena de agentes modular. Diseñada para escenarios de consulta de conocimientos externos por modelos de lenguaje grande, soporta adquisición y análisis de páginas web con **Playwright + Crawl4AI**, así como concurrencia asíncrona, segmentación y reordenamiento de contenidos.

## 🚀 Registro de actualizaciones

- 🔥 2025-09-05: Soporte para **langgraph-mcp**
- 🔥 2025-09-03: Despliegue en Docker añadido, reordenador inteligente incorporado, soporte para segmentador y reordenador de texto personalizados

## ✨ Resumen de características

- 🌐 **Sin necesidad de proxy**: Mediante la configuración de Playwright para soportar navegadores nacionales, permite realizar búsquedas en la web sin requerir proxy.
- 🔍 **Soporte para múltiples motores de búsqueda**: Compatible con Bing, Quark, Baidu, Sogou y otros motores de búsqueda principales, mejorando la diversidad de fuentes de información.
- 🤖 **Reconocimiento de intención**: El sistema puede determinar automáticamente si debe realizar una búsqueda web o analizar una URL según el contenido ingresado por el usuario.
- 🔄 **Descomposición de consultas**: Según la intención de búsqueda del usuario, descompone automáticamente la consulta en varias subtareas y las ejecuta secuencialmente para mejorar la relevancia y eficiencia de la búsqueda.
- ⚙️ **Arquitectura inteligente**: Basado en **LangGraph**, encapsula **「web_search」** y **「link_parser」**.
- 🏃‍♂️ **Procesamiento de tareas asíncronas y concurrentes**: Soporta el manejo asíncrono y concurrente de tareas, permitiendo procesar eficientemente múltiples búsquedas.
- 📝 **Optimización del procesamiento de contenido**:

  - ✂️ **Fragmentación de contenido**: Divide el contenido extenso de la web en segmentos.

  - 🔄 **Reordenamiento de contenido**: Reorganización inteligente para mejorar la relevancia informativa.

  - 🚫 **Filtrado de contenido**: Elimina automáticamente contenido irrelevante o duplicado.
- 🌐 **Soporte multiplataforma**:
  - 🐳 **Compatible con despliegue en Docker**: Inicio con un solo clic, construcción rápida de servicios backend.

  - 🖥️ Proporciona interfaz backend FastAPI, integrable en cualquier sistema.

  - 🌍 Ofrece Gradio Web UI, permitiendo un despliegue rápido como aplicación visual.

  - 🧩[ **Soporte para extensión de navegador**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Compatible con Edge, ofrece extensión para análisis inteligente de URL, permitiendo iniciar solicitudes de análisis y extracción de contenido directamente en el navegador.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Comenzar rápidamente

### Clonar el repositorio

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Instalar dependencias

```
pip install -r requirements.txt
python -m playwright install
```

### Configuración de variables de entorno

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

#### SERVICIO API

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

#### Iniciar el servicio MCP

```
python mcp/websearch.py
```

#### DEMOSTRACIÓN

```
python mcp/demo.py
```

#### SERVICIO API

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

### Módulos personalizados

#### Segmentación personalizada

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

#### Reordenación personalizada

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

## 🔍 Comparación con pruebas de búsqueda en línea

Comparamos el proyecto con algunas API en línea principales, evaluando su desempeño en problemas complejos.

### 🔥 Conjunto de datos

- El conjunto de datos proviene de [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) publicado por Alibaba, contiene 680 preguntas de alta dificultad que abarcan educación, conferencias académicas, juegos y otros campos.
- El conjunto de datos incluye preguntas en chino e inglés.

### 🧑‍🏫 Resultados comparativos

| Motor de búsqueda/Sistema | ✅ Correcto | ❌ Incorrecto | ⚠️ Parcialmente correcto |
| ------------------------ | ---------- | ------------ | ----------------------- |
| **Volcano Ark**          | 5.00%      | 72.21%       | 22.79%                  |
| **Bailian**              | 9.85%      | 62.79%       | 27.35%                  |
| **Nuestro**              | 19.85%     | 47.94%       | 32.06%                  |
## 🙏 Agradecimientos

Algunas funciones de este proyecto se benefician del apoyo e inspiración de los siguientes proyectos de código abierto. Agradecemos especialmente:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): Utilizado para construir el marco de cadenas de agentes modulares, ayuda a crear rápidamente sistemas de agentes complejos.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): Potente herramienta de análisis de contenido web, facilita la extracción eficiente de datos y el rastreo de páginas.
- 🌐 [Playwright](https://github.com/microsoft/playwright): Herramienta moderna de automatización de navegadores, compatible con el rastreo web y la automatización de pruebas en múltiples navegadores.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): Utilizado para la construcción de MCP de procesamiento multichain.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---