# Protocolo Agent2Agent (A2A)

[![PyPI - Versión](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Licencia Apache](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Idioma</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logotipo del Protocolo Agent2Agent" width="100">
    <h1>Protocolo Agent2Agent (A2A)</h1>
  </div>
</div>

**Un protocolo abierto que permite la comunicación e interoperabilidad entre aplicaciones agénticas opacas.**

El protocolo Agent2Agent (A2A) aborda un desafío crítico en el panorama de la IA: permitir que agentes de IA generativa, construidos sobre diferentes frameworks por distintas empresas y ejecutándose en servidores separados, puedan comunicarse y colaborar eficazmente, como agentes y no solo como herramientas. A2A busca proporcionar un lenguaje común para los agentes, fomentando un ecosistema de IA más interconectado, potente e innovador.

Con A2A, los agentes pueden:

- Descubrir las capacidades de otros agentes.
- Negociar modalidades de interacción (texto, formularios, multimedia).
- Colaborar de forma segura en tareas de larga duración.
- Operar sin exponer su estado interno, memoria o herramientas.

## Curso de DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

Únete a este curso corto sobre [A2A: El Protocolo Agent2Agent](https://goo.gle/dlai-a2a), desarrollado en colaboración con Google Cloud e IBM Research, e impartido por [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini) y [Sandi Besen](https://github.com/sandijean90).

**Lo que aprenderás:**

- **Haz que tus agentes sean compatibles con A2A:** Expón agentes construidos con frameworks como Google ADK, LangGraph o BeeAI como servidores A2A.
- **Conecta agentes:** Crea clientes A2A desde cero o utilizando integraciones para conectarte con agentes compatibles con A2A.
- **Orquesta flujos de trabajo:** Crea flujos de trabajo secuenciales y jerárquicos de agentes compatibles con A2A.
- **Sistemas multiagente:** Construye un sistema multiagente de salud utilizando diferentes frameworks y observa cómo A2A permite la colaboración.
- **A2A y MCP:** Aprende cómo A2A complementa MCP al permitir la colaboración entre agentes.

## ¿Por qué A2A?

A medida que los agentes de IA se vuelven más prevalentes, su capacidad de interoperar es crucial para construir aplicaciones complejas y multifuncionales. A2A busca:

- **Romper barreras:** Conectar agentes en distintos ecosistemas.
- **Habilitar colaboración compleja:** Permitir que agentes especializados trabajen juntos en tareas que un solo agente no puede manejar por sí mismo.
- **Promover estándares abiertos:** Fomentar un enfoque impulsado por la comunidad para la comunicación entre agentes, promoviendo la innovación y la adopción generalizada.
- **Preservar la opacidad:** Permitir que los agentes colaboren sin necesidad de compartir memoria interna, lógica propietaria o implementaciones específicas de herramientas, mejorando la seguridad y protegiendo la propiedad intelectual.

### Características Clave

- **Comunicación Estandarizada:** JSON-RPC 2.0 sobre HTTP(S).
- **Descubrimiento de Agentes:** Mediante "Tarjetas de Agente" que detallan capacidades e información de conexión.
- **Interacción Flexible:** Soporta solicitud/respuesta síncrona, streaming (SSE) y notificaciones push asíncronas.
- **Intercambio Rico de Datos:** Maneja texto, archivos y datos JSON estructurados.
- **Listo para Empresas:** Diseñado teniendo en cuenta la seguridad, autenticación y observabilidad.

## Primeros Pasos

- 📚 **Explora la Documentación:** Visita el [Sitio de Documentación del Protocolo Agent2Agent](https://a2a-protocol.org) para una visión completa, la especificación completa del protocolo, tutoriales y guías.
- 📝 **Ver la Especificación:** [Especificación del Protocolo A2A](https://a2a-protocol.org/latest/specification/)
- Usa los SDKs:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) usando maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) usando [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Usa nuestros [ejemplos](https://github.com/a2aproject/a2a-samples) para ver A2A en acción

## Contribuir

¡Damos la bienvenida a las contribuciones de la comunidad para mejorar y evolucionar el protocolo A2A!

- **Preguntas y Discusiones:** Únete a nuestras [Discusiones de GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problemas y Sugerencias:** Reporta problemas o sugiere mejoras mediante [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Guía de Contribución:** Consulta nuestro [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) para detalles sobre cómo contribuir.
- **Comentarios Privados:** Usa este [Formulario de Google](https://goo.gle/a2a-feedback).
- **Programa de Socios:** Los clientes de Google Cloud pueden unirse a nuestro programa de socios mediante este [formulario](https://goo.gle/a2a-partner).

## Qué sigue

### Mejoras del Protocolo

- **Descubrimiento de Agentes:**
    - Formalizar la inclusión de esquemas de autorización y credenciales opcionales directamente en el `AgentCard`.
- **Colaboración entre Agentes:**
    - Investigar un método `QuerySkill()` para comprobar dinámicamente habilidades no soportadas o imprevistas.
- **Ciclo de Vida de Tareas y UX:**
    - Soporte para la negociación dinámica de UX _dentro_ de una tarea (por ejemplo, el agente agrega audio/video en medio de la conversación).
- **Métodos del cliente y transporte:**
    - Explorar la extensión del soporte a métodos iniciados por el cliente (más allá de la gestión de tareas).
    - Mejoras en la confiabilidad del streaming y los mecanismos de notificaciones push.

## Acerca de

El Protocolo A2A es un proyecto de código abierto bajo la Linux Foundation, contribuido por Google. Está licenciado bajo la [Licencia Apache 2.0](LICENSE) y está abierto a contribuciones de la comunidad.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---