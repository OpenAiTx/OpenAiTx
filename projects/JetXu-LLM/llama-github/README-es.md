
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[Documento Detallado] https://deepwiki.com/JetXu-LLM/llama-github

[![Versión PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Descargas](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licencia](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github es una herramienta poderosa que te ayuda a recuperar (basada en Agentic RAG) los fragmentos de código, incidencias e información de repositorios más relevantes de GitHub según tus consultas, transformándolos en un contexto de conocimiento valioso. Potencia Chatbots LLM, Agentes de IA y Agentes Auto-dev para resolver tareas complejas de codificación. Ya seas un desarrollador buscando soluciones rápidas o un ingeniero implementando avanzados Agentes Auto Dev de IA, llama-github lo hace fácil y eficiente.

Si te gusta este proyecto o crees que tiene potencial, por favor dale una ⭐️. ¡Tu apoyo es nuestra mayor motivación!

## Arquitectura
![Arquitectura de Alto Nivel](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalación
```
pip install llama-github
```

Objetivo de tiempo de ejecución mantenido actualmente: Python `3.10+`.

## Uso

Aquí tienes un ejemplo sencillo de cómo usar llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```

`retrieve_context()` devuelve una lista de diccionarios de contexto. Cada elemento contiene al menos `context` y `url`.

Para usos más avanzados y ejemplos, consulta la [documentación](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Ejemplos ejecutables de bajo costo también están disponibles en [`examples/`](examples).

## Características clave

- **🔍 Recuperación inteligente de GitHub**: Aprovecha la potencia de llama-github para recuperar fragmentos de código altamente relevantes, problemas e información de repositorios de GitHub según consultas de usuario. Nuestras técnicas avanzadas de recuperación garantizan que encuentres la información más pertinente rápida y eficientemente.

- **⚡ Caché de pool de repositorios**: Llama-github cuenta con un innovador mecanismo de caché de pool de repositorios. Al almacenar repositorios en caché (incluyendo README, estructuras, código y issues) a través de hilos, llama-github acelera significativamente la eficiencia de búsqueda y minimiza el consumo de tokens de la API de GitHub.

- **🧠 Análisis de preguntas impulsado por LLM**: Utiliza modelos de lenguaje de última generación para analizar preguntas de usuario y generar estrategias y criterios de búsqueda altamente efectivos. Llama-github descompone inteligentemente consultas complejas, asegurando que recuperes la información más relevante de la vasta red de repositorios de GitHub.

- **📚 Generación integral de contexto**: Genera respuestas ricas y contextualmente relevantes combinando información recuperada de GitHub con las capacidades de razonamiento de modelos de lenguaje avanzados. Llama-github destaca en el manejo de preguntas complejas y extensas, proporcionando respuestas completas y profundas que incluyen contexto extenso para apoyar tus necesidades de desarrollo.

- **🚀 Excelencia en procesamiento asincrónico**: Llama-github está construido desde cero para aprovechar todo el potencial de la programación asincrónica. Con mecanismos meticulosamente implementados a lo largo del código, llama-github puede manejar múltiples solicitudes simultáneamente, aumentando significativamente el rendimiento general.

- **🔧 Integración flexible de LLM**: Integra fácilmente llama-github con varios proveedores de LLM, modelos de embeddings, modelos de reranking o un modelo de chat compatible con LangChain para adaptar las capacidades de la biblioteca a tus requisitos específicos.

- **🔒 Opciones sólidas de autenticación**: Llama-github soporta tokens de acceso personal y autenticación de GitHub App, brindando flexibilidad para integrarlo en diferentes entornos de desarrollo. Ya seas un desarrollador individual o trabajes en un contexto organizacional, llama-github te ofrece mecanismos seguros y confiables de autenticación.

- **🛠️ Registro y manejo de errores**: Entendemos la importancia de operaciones fluidas y fácil resolución de problemas. Por eso, llama-github viene equipado con mecanismos completos de registro y manejo de errores. Obtén información detallada sobre el comportamiento de la biblioteca, diagnostica problemas rápidamente y mantén un flujo de trabajo estable y confiable.

## 🤖 Prueba nuestro asistente de revisión de PR con IA: LlamaPReview

Si encuentras útil llama-github, también te puede interesar nuestro asistente de revisión de PR de GitHub impulsado por IA, LlamaPReview. Está diseñado para complementar tu flujo de trabajo de desarrollo y mejorar aún más la calidad del código.

### Características clave de LlamaPReview:
- 🚀 Instalación en un clic, sin configuración, completamente automática
- 💯 Actualmente gratis - no se requiere tarjeta de crédito ni información de pago
- 🧠 Revisiones automáticas de PR impulsadas por IA con profunda comprensión de código
- 🌐 Soporta múltiples lenguajes de programación

**LlamaPReview utiliza la avanzada recuperación de contexto y análisis impulsado por LLM de llama-github** para ofrecer revisiones de código inteligentes y conscientes del contexto. ¡Es como tener un desarrollador sénior, armado con todo el contexto de tu repositorio, revisando cada PR automáticamente!

👉 [Instala LlamaPReview ahora](https://github.com/marketplace/llamapreview/) (Gratis)

Al usar llama-github para la recuperación de contexto y LlamaPReview para las revisiones de código, puedes crear un entorno de desarrollo potenciado por IA.

## Visión y hoja de ruta

### Visión

Nuestra visión es convertirnos en un módulo fundamental en el futuro de las soluciones de desarrollo impulsadas por IA, integrándonos perfectamente con GitHub para empoderar a los LLMs en la resolución automática de tareas de codificación complejas.

![Arquitectura de la Visión](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Hoja de Ruta

Para una vista histórica de la hoja de ruta anterior, por favor visite [Visión y Hoja de Ruta](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Agradecimientos

Nos gustaría expresar nuestro agradecimiento a los siguientes proyectos de código abierto por su apoyo y contribuciones:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Por proporcionar el marco fundamental que potencia las capacidades de procesamiento y prompting de LLM en llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Por ofrecer la API s.jina.ai y modelos de reranker y embedding de código abierto que mejoran la precisión y relevancia de los contextos generados en llama-github.

Sus contribuciones han sido fundamentales para el desarrollo de llama-github y recomendamos encarecidamente revisar sus proyectos para más soluciones innovadoras.

## Contribuciones

¡Damos la bienvenida a contribuciones para llama-github! Consulte nuestras [directrices de contribución](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) para más información.

## Licencia

Este proyecto está licenciado bajo los términos de la licencia Apache 2.0. Consulte el archivo [LICENSE](LICENSE) para más detalles.

## Contacto

Si tienes alguna pregunta, sugerencia o comentario, no dudes en ponerte en contacto con nosotros en [correo de Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

¡Gracias por elegir llama-github! Esperamos que esta biblioteca mejore tu experiencia de desarrollo con IA y te ayude a construir aplicaciones poderosas con facilidad.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---