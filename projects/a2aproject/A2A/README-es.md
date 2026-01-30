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

**Un protocolo abierto que permite la comunicación e interoperabilidad entre aplicaciones agenticas opacas.**

El protocolo Agent2Agent (A2A) aborda un desafío crítico en el panorama de la IA: permitir que agentes de IA generativa, construidos sobre marcos diversos por diferentes empresas en servidores separados, puedan comunicarse y colaborar eficazmente, como agentes y no solo como herramientas. A2A busca proporcionar un lenguaje común para los agentes, fomentando un ecosistema de IA más interconectado, potente e innovador.

Con A2A, los agentes pueden:

- Descubrir las capacidades de otros agentes.
- Negociar modalidades de interacción (texto, formularios, medios).
- Colaborar de forma segura en tareas de larga duración.
- Operar sin exponer su estado interno, memoria ni herramientas.

## Video introductorio de A2A

[![Video Introductorio de A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## ¿Por qué A2A?

A medida que los agentes de IA se vuelven más comunes, su capacidad de interoperar es crucial para construir aplicaciones complejas y multifuncionales. A2A busca:

- **Romper Silos:** Conectar agentes a través de diferentes ecosistemas.
- **Habilitar Colaboración Compleja:** Permitir que agentes especializados colaboren en tareas que un solo agente no puede manejar por sí solo.
- **Promover Estándares Abiertos:** Fomentar un enfoque comunitario para la comunicación entre agentes, impulsando la innovación y la adopción generalizada.
- **Preservar la Opacidad:** Permitir que los agentes colaboren sin necesidad de compartir memoria interna, lógica propietaria ni implementaciones específicas de herramientas, mejorando la seguridad y protegiendo la propiedad intelectual.

### Características clave

- **Comunicación estandarizada:** JSON-RPC 2.0 sobre HTTP(S).
- **Descubrimiento de agentes:** A través de "Tarjetas de Agente" que detallan capacidades e información de conexión.
- **Interacción flexible:** Soporta solicitudes/respuestas síncronas, streaming (SSE) y notificaciones push asíncronas.
- **Intercambio de datos enriquecido:** Maneja texto, archivos y datos estructurados en JSON.
- **Preparado para empresa:** Diseñado con seguridad, autenticación y observabilidad en mente.

## Primeros pasos

- 📚 **Explora la documentación:** Visita el [Sitio de Documentación del Protocolo Agent2Agent](https://a2a-protocol.org) para una visión completa, la especificación del protocolo, tutoriales y guías.
- 📝 **Ver la especificación:** [Especificación del Protocolo A2A](https://a2a-protocol.org/latest/specification/)
- Usa los SDKs:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) usando maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) usando [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Usa nuestros [ejemplos](https://github.com/a2aproject/a2a-samples) para ver A2A en acción

## Contribuir

¡Damos la bienvenida a las contribuciones de la comunidad para mejorar y evolucionar el protocolo A2A!

- **Preguntas y debates:** Únete a nuestras [Discusiones en GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problemas y sugerencias:** Reporta problemas o sugiere mejoras a través de [GitHub Issues](https://github.com/a2aproject/A2A/issues).
- **Guía de contribución:** Consulta nuestro [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) para detalles sobre cómo contribuir.
- **Comentarios privados:** Usa este [Formulario de Google](https://goo.gle/a2a-feedback).
- **Programa de socios:** Los clientes de Google Cloud pueden unirse a nuestro programa de socios a través de este [formulario](https://goo.gle/a2a-partner).

## Próximos pasos

### Mejoras al protocolo

- **Descubrimiento de agentes:**
    - Formalizar la inclusión de esquemas de autorización y credenciales opcionales directamente en el `AgentCard`.
- **Colaboración entre agentes:**
    - Investigar un método `QuerySkill()` para comprobar dinámicamente habilidades no soportadas o no anticipadas.
- **Ciclo de vida de tareas y UX:**
    - Soporte para negociación dinámica de UX _dentro_ de una tarea (por ejemplo, agente agregando audio/video en medio de la conversación).
- **Métodos de cliente y transporte:**
    - Explorar la extensión de soporte a métodos iniciados por el cliente (más allá de la gestión de tareas).
    - Mejoras en la fiabilidad del streaming y mecanismos de notificaciones push.

## Sobre

El Protocolo A2A es un proyecto de código abierto bajo la Linux Foundation, contribuido por Google. Está licenciado bajo la [Licencia Apache 2.0](LICENSE) y está abierto a contribuciones de la comunidad.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---