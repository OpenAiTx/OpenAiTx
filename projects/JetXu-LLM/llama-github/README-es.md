# llama-github

[Documento Detallado] https://deepwiki.com/JetXu-LLM/llama-github

[![Versión PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Descargas](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licencia](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github es una herramienta poderosa que te ayuda a recuperar (basado en Agentic RAG) los fragmentos de código, issues e información del repositorio más relevantes de GitHub según tus consultas, transformándolos en un contexto de conocimiento valioso. Potencia chatbots LLM, agentes de IA y agentes Auto-dev para resolver tareas de codificación complejas. Ya seas un desarrollador buscando soluciones rápidas o un ingeniero implementando avanzados agentes Auto Dev IA, llama-github lo hace fácil y eficiente.

Si te gusta este proyecto o crees que tiene potencial, por favor dale una ⭐️. ¡Tu apoyo es nuestra mayor motivación!

## Arquitectura
![Arquitectura de Alto Nivel](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalación
```
pip install llama-github
```

## Uso

Aquí hay un ejemplo simple de cómo usar llama-github:

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
Para un uso y ejemplos más avanzados, por favor consulte la [documentación](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Características clave

- **🔍 Recuperación inteligente de GitHub**: Aproveche el poder de llama-github para recuperar fragmentos de código altamente relevantes, issues e información de repositorios en GitHub basados en consultas de usuarios. Nuestras técnicas avanzadas de recuperación aseguran que encuentre la información más pertinente rápida y eficientemente.

- **⚡ Caché del pool de repositorios**: Llama-github cuenta con un innovador mecanismo de caché del pool de repositorios. Al almacenar en caché repositorios (incluyendo READMEs, estructuras, código y issues) a través de hilos, llama-github acelera significativamente la eficiencia de búsqueda en GitHub y minimiza el consumo de tokens de la API de GitHub. Despliegue llama-github en entornos de producción multihilo con confianza, sabiendo que funcionará de manera óptima y ahorrará valiosos recursos.

- **🧠 Análisis de preguntas impulsado por LLM**: Aproveche modelos de lenguaje de última generación para analizar preguntas de usuarios y generar estrategias y criterios de búsqueda altamente efectivos. Llama-github descompone inteligentemente consultas complejas, garantizando que recupere la información más relevante de la vasta red de repositorios de GitHub.

- **📚 Generación de contexto integral**: Genere respuestas ricas y contextualmente relevantes combinando sin problemas la información recuperada de GitHub con las capacidades de razonamiento de modelos de lenguaje avanzados. Llama-github sobresale manejando incluso las preguntas más complejas y extensas, proporcionando respuestas completas y perspicaces que incluyen un contexto amplio para apoyar sus necesidades de desarrollo.

- **🚀 Excelencia en procesamiento asincrónico**: Llama-github está construido desde cero para aprovechar todo el potencial de la programación asincrónica. Con mecanismos asincrónicos meticulosamente implementados a lo largo del código, llama-github puede manejar múltiples solicitudes simultáneamente, aumentando significativamente el rendimiento general. Experimente la diferencia mientras llama-github gestiona eficientemente cargas de trabajo de alto volumen sin comprometer velocidad ni calidad.

- **🔧 Integración flexible de LLM**: Integre fácilmente llama-github con diversos proveedores de LLM, modelos de incrustación y modelos de reranking para adaptar las capacidades de la biblioteca a sus requerimientos específicos. Nuestra arquitectura extensible le permite personalizar y mejorar la funcionalidad de llama-github, asegurando que se adapte sin problemas a su entorno de desarrollo único.

- **🔒 Opciones robustas de autenticación**: Llama-github soporta tanto tokens de acceso personal como autenticación mediante GitHub App, brindándole flexibilidad para integrarlo en diferentes configuraciones de desarrollo. Ya sea que sea un desarrollador individual o trabaje dentro de un contexto organizacional, llama-github le ofrece mecanismos de autenticación seguros y confiables.

- **🛠️ Registro y manejo de errores**: Entendemos la importancia de operaciones fluidas y una resolución de problemas sencilla. Por eso llama-github viene equipado con mecanismos comprensivos de registro y manejo de errores. Obtenga información profunda sobre el comportamiento de la biblioteca, diagnostique problemas rápidamente y mantenga un flujo de trabajo de desarrollo estable y confiable.

## 🤖 Pruebe nuestro asistente de revisión de PR impulsado por IA: LlamaPReview

Si encuentra útil llama-github, también podría interesarle nuestro asistente de revisión de PR de GitHub impulsado por IA, LlamaPReview. Está diseñado para complementar su flujo de trabajo de desarrollo y mejorar aún más la calidad del código.

### Características clave de LlamaPReview:
- 🚀 Instalación con un clic, sin configuración requerida, ejecución totalmente automática
- 💯 Actualmente gratuito - no se necesita tarjeta de crédito ni información de pago
- 🧠 Revisiones automáticas de PR impulsadas por IA con profunda comprensión del código
- 🌐 Soporta múltiples lenguajes de programación

**LlamaPReview utiliza la avanzada recuperación de contexto de llama-github y el análisis potenciado por LLM** para proporcionar revisiones de código inteligentes y conscientes del contexto. ¡Es como tener un desarrollador senior, armado con el contexto completo de su repositorio, revisando cada PR automáticamente!

👉 [Instale LlamaPReview ahora](https://github.com/marketplace/llamapreview/) (Gratis)

Usando llama-github para la recuperación de contexto y LlamaPReview para revisiones de código, puede crear un entorno de desarrollo potente y potenciado por IA.

## Visión y hoja de ruta

### Visión

Nuestra visión es convertirnos en un módulo clave en el futuro de las soluciones de desarrollo impulsadas por IA, integrándonos perfectamente con GitHub para capacitar a los LLM en la resolución automática de tareas complejas de codificación.

![Arquitectura de la visión](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Hoja de ruta

Para una vista detallada de nuestra hoja de ruta del proyecto, por favor visite nuestro [Roadmap del proyecto](https://github.com/users/JetXu-LLM/projects/2).

## Agradecimientos

Queremos expresar nuestra gratitud a los siguientes proyectos de código abierto por su apoyo y contribuciones:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Por proporcionar el marco fundamental que potencia las capacidades de prompting y procesamiento de LLM en llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Por ofrecer la API s.jina.ai y modelos de reranking e incrustación de código abierto que mejoran la precisión y relevancia de los contextos generados en llama-github.

Sus contribuciones han sido instrumentales en el desarrollo de llama-github, y recomendamos ampliamente revisar sus proyectos para más soluciones innovadoras.

## Contribuciones

¡Damos la bienvenida a contribuciones para llama-github! Por favor consulte nuestras [directrices de contribución](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) para más información.

## Licencia

Este proyecto está licenciado bajo los términos de la licencia Apache 2.0. Consulte el archivo [LICENSE](LICENSE) para más detalles.

## Contacto

Si tiene alguna pregunta, sugerencia o comentario, no dude en contactarnos en el [correo electrónico de Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

¡Gracias por elegir llama-github! Esperamos que esta biblioteca mejore su experiencia en desarrollo con IA y le ayude a construir aplicaciones potentes con facilidad.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---