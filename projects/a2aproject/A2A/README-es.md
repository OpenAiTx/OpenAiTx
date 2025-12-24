# Protocolo Agent2Agent (A2A)

[![PyPI - Versión](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Licencia Apache](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Logotipo del Protocolo Agent2Agent" width="100">
    <h1>Protocolo Agent2Agent (A2A)</h1>
  </div>
</div>

**Un protocolo abierto que permite la comunicación e interoperabilidad entre aplicaciones agenticas opacas.**

El protocolo Agent2Agent (A2A) aborda un desafío crítico en el panorama de la IA: permitir que agentes gen AI, construidos sobre diversos marcos por diferentes compañías y ejecutándose en servidores separados, se comuniquen y colaboren eficazmente - como agentes, no solo como herramientas. A2A busca proporcionar un lenguaje común para los agentes, fomentando un ecosistema de IA más interconectado, poderoso e innovador.

Con A2A, los agentes pueden:

- Descubrir las capacidades del otro.
- Negociar modalidades de interacción (texto, formularios, medios).
- Colaborar de manera segura en tareas de larga duración.
- Operar sin exponer su estado interno, memoria o herramientas.

## Video introductorio a A2A

[![Video Intro A2A](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## ¿Por qué A2A?

A medida que los agentes de IA se vuelven más prevalentes, su capacidad para interoperar es crucial para construir aplicaciones complejas y multifuncionales. A2A busca:

- **Romper silos:** Conectar agentes a través de diferentes ecosistemas.
- **Habilitar colaboración compleja:** Permitir que agentes especializados trabajen juntos en tareas que un solo agente no puede manejar solo.
- **Promover estándares abiertos:** Fomentar un enfoque comunitario para la comunicación entre agentes, alentando la innovación y una adopción amplia.
- **Preservar la opacidad:** Permitir que los agentes colaboren sin necesidad de compartir memoria interna, lógica propietaria o implementaciones específicas de herramientas, mejorando la seguridad y protegiendo la propiedad intelectual.

### Características clave

- **Comunicación estandarizada:** JSON-RPC 2.0 sobre HTTP(S).
- **Descubrimiento de agentes:** A través de "Tarjetas de Agente" que detallan capacidades e información de conexión.
- **Interacción flexible:** Soporta solicitud/respuesta síncrona, transmisión (SSE) y notificaciones push asíncronas.
- **Intercambio de datos enriquecido:** Maneja texto, archivos y datos JSON estructurados.
- **Listo para empresas:** Diseñado con seguridad, autenticación y observabilidad en mente.

## Comenzando

- 📚 **Explora la documentación:** Visita el [Sitio de Documentación del Protocolo Agent2Agent](https://a2a-protocol.org) para una visión completa, especificación completa del protocolo, tutoriales y guías.
- 📝 **Ver la especificación:** [Especificación del Protocolo A2A](https://a2a-protocol.org/latest/specification/)
- Usa los SDKs:
    - [🐍 SDK A2A para Python](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ SDK A2A para Go](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 SDK A2A para JS](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ SDK A2A para Java](https://github.com/a2aproject/a2a-java) usando maven
    - [🔷 SDK A2A para .NET](https://github.com/a2aproject/a2a-dotnet) usando [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
- 🎬 Usa nuestros [ejemplos](https://github.com/a2aproject/a2a-samples) para ver A2A en acción

## Contribuir

¡Damos la bienvenida a contribuciones de la comunidad para mejorar y evolucionar el protocolo A2A!

- **Preguntas y discusiones:** Únete a nuestras [Discusiones en GitHub](https://github.com/a2aproject/A2A/discussions).
- **Problemas y retroalimentación:** Reporta problemas o sugiere mejoras a través de [Issues en GitHub](https://github.com/a2aproject/A2A/issues).
- **Guía de contribución:** Consulta nuestro [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) para detalles sobre cómo contribuir.
- **Retroalimentación privada:** Usa este [Formulario de Google](https://goo.gle/a2a-feedback).
- **Programa de socios:** Los clientes de Google Cloud pueden unirse a nuestro programa de socios a través de este [formulario](https://goo.gle/a2a-partner).

## Qué sigue

### Mejoras del protocolo

- **Descubrimiento de agentes:**
    - Formalizar la inclusión de esquemas de autorización y credenciales opcionales directamente dentro de la `AgentCard`.
- **Colaboración entre agentes:**
    - Investigar un método `QuerySkill()` para verificar dinámicamente habilidades no soportadas o no anticipadas.
- **Ciclo de vida de tareas y UX:**
    - Soporte para negociación dinámica de UX _dentro_ de una tarea (por ejemplo, que un agente añada audio/video en medio de la conversación).
- **Métodos del Cliente y Transporte:**
    - Explorar la ampliación del soporte a métodos iniciados por el cliente (más allá de la gestión de tareas).
    - Mejoras en la fiabilidad del streaming y los mecanismos de notificación push.

## Acerca de

El Protocolo A2A es un proyecto de código abierto bajo la Linux Foundation, aportado por Google. Está licenciado bajo la [Licencia Apache 2.0](LICENSE) y está abierto a contribuciones de la comunidad.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---