<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="Logo de LangChain" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Notas de lanzamiento](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - Licencia](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Descargas](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![Gráfico de estrellas en GitHub](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Issues abiertos](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Abrir en Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Abrir en Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTA]
> ¿Buscas la librería JS/TS? Consulta [LangChain.js](https://github.com/langchain-ai/langchainjs).

LangChain es un framework para construir aplicaciones potenciadas por LLM. Te ayuda a encadenar componentes interoperables e integraciones de terceros para simplificar el desarrollo de aplicaciones de IA, todo mientras se protegen las decisiones a futuro a medida que evoluciona la tecnología subyacente.

```bash
pip install -U langchain
```

Para saber más sobre LangChain, consulta
[la documentación](https://python.langchain.com/docs/introduction/). Si buscas una personalización más avanzada u orquestación de agentes, consulta
[LangGraph](https://langchain-ai.github.io/langgraph/), nuestro framework para crear flujos de trabajo de agentes controlables.

## ¿Por qué usar LangChain?

LangChain ayuda a los desarrolladores a construir aplicaciones potenciadas por LLMs mediante una interfaz estándar para modelos, embeddings, almacenes vectoriales y más.

Usa LangChain para:
- **Aumento de datos en tiempo real**. Conecta fácilmente LLMs a diversas fuentes de datos y sistemas externos/internos, aprovechando la amplia biblioteca de integraciones de LangChain con proveedores de modelos, herramientas, almacenes vectoriales, recuperadores y más.
- **Interoperabilidad de modelos**. Cambia modelos según lo que tu equipo de ingeniería necesite experimentar para encontrar la mejor opción para tu aplicación. A medida que evoluciona la frontera de la industria, adáptate rápidamente: las abstracciones de LangChain te permiten seguir avanzando sin perder impulso.

## Ecosistema de LangChain
Si bien el framework LangChain puede usarse de manera independiente, también se integra perfectamente con cualquier producto LangChain, brindando a los desarrolladores un conjunto completo de herramientas al construir aplicaciones LLM.

Para mejorar el desarrollo de tu aplicación LLM, combina LangChain con:

- [LangSmith](http://www.langchain.com/langsmith) - Útil para evaluación de agentes y observabilidad. Depura ejecuciones de apps LLM con bajo rendimiento, evalúa trayectorias de agentes, gana visibilidad en producción y mejora el desempeño con el tiempo.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - Construye agentes que pueden manejar tareas complejas de manera confiable con LangGraph, nuestro framework de orquestación de agentes de bajo nivel. LangGraph ofrece arquitectura personalizable, memoria a largo plazo y flujos de trabajo human-in-the-loop, y es confiable en producción por empresas como LinkedIn, Uber, Klarna y GitLab.
- [Plataforma LangGraph](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - Despliega y escala agentes fácilmente con una plataforma de despliegue creada para flujos de trabajo de larga duración y con estado. Descubre, reutiliza, configura y comparte agentes entre equipos, e itera rápidamente con prototipado visual en
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## Recursos adicionales
- [Tutoriales](https://python.langchain.com/docs/tutorials/): Guías sencillas con ejemplos guiados para comenzar con LangChain.
- [Guías prácticas](https://python.langchain.com/docs/how_to/): Fragmentos de código rápidos y accionables para temas como llamadas a herramientas, casos de uso de RAG y más.
- [Guías conceptuales](https://python.langchain.com/docs/concepts/): Explicaciones de los conceptos clave detrás del framework LangChain.
- [Referencia de API](https://python.langchain.com/api_reference/): Referencia detallada para navegar por los paquetes base e integraciones de LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---