# Ejemplos de Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Probar en Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Idioma</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
    </div>
  </details>
</div>

Bienvenido a los ejemplos de código oficiales y demostraciones para el [Protocolo Agent2Agent (A2A)](https://goo.gle/a2a).

¡Nos alegra que estés aquí! Ya sea que estés explorando arquitecturas multiagente por primera vez o construyendo redes avanzadas de agentes interoperables, este repositorio ofrece recursos de aprendizaje simples, inspiradores y accesibles para acelerar tu desarrollo.

## ¿Por qué Agent2Agent?

En un mundo de diversos marcos y ecosistemas de IA, los agentes necesitan un lenguaje común para comunicarse, colaborar y delegar tareas de forma segura. El protocolo A2A establece un estándar abierto y estandarizado para la interoperabilidad multiagente.

Nuestros ejemplos demuestran lo fácil que es resolver problemas complejos de múltiples agentes en diferentes lenguajes y aplicaciones anfitrionas.

## Inicio Rápido

Comienza de inmediato lanzando un agente Helloworld y comunicándote con él a través de nuestro host CLI de Python.

1. **Inicia el servidor del agente**:
   Abre una terminal e inicia el servidor del agente Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Ejecute el Cliente Host**:
   Abra una segunda terminal y ejecute el cliente CLI para enviar una tarea al agente:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Estructura del Repositorio

El repositorio está organizado en varios directorios clave por lenguaje:

| Directorio | Descripción |
| --- | --- |
| [samples](/samples) | Ejemplos principales de A2A organizados por lenguaje de programación. |
| [samples/python](/samples/python) | Demuestra implementaciones de agentes en Python usando el SDK de A2A para Python. |
| [samples/go](/samples/go) | Demuestra implementaciones de agentes en Go usando el SDK de A2A para Go. |
| [samples/dotnet](/samples/dotnet) | Demuestra implementaciones de agentes en C# usando el SDK de A2A para .NET. |
| [samples/java](/samples/java) | Demuestra implementaciones de agentes en Java usando el SDK de A2A para Java. |
| [samples/js](/samples/js) | Demuestra implementaciones de agentes en Node.js usando el SDK de A2A para JavaScript. |

## Contribuir

¡Damos la bienvenida y alentamos contribuciones de todos los niveles de habilidad! Si tienes una idea para un nuevo ejemplo, una corrección de errores o una mejora en la documentación, por favor revisa nuestra [Guía de Contribución](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtener Ayuda

Estamos dedicados a proporcionar una comunidad acogedora y de apoyo. Si tienes preguntas, comentarios o encuentras algún problema, por favor contáctanos en nuestra [página de issues](https://github.com/a2aproject/a2a-samples/issues).

## Repositorios Relacionados

| Repositorio | Categoría | Descripción |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Especificación Principal | Especificación y documentación de A2A. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Herramientas | Herramienta UI para inspeccionar agentes habilitados para A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Pruebas | Conjunto de pruebas para validar el cumplimiento del Protocolo A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Pruebas | Kit de herramientas para verificar la compatibilidad entre diferentes implementaciones y versiones de SDK de A2A usando modelo de recorrido multi-hop y variados protocolos de transporte. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | SDK oficial de A2A para Python. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK oficial de A2A para Go. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | SDK oficial de A2A para Java. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | SDK oficial de Node.js/JavaScript para A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK oficial de C#/.NET para A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | SDK oficial de A2A para Rust. |

## Descargo de Responsabilidad

**Importante:** El código de ejemplo proporcionado es solo para fines demostrativos e ilustra la mecánica del
Protocolo Agente-a-Agente (A2A). Al construir aplicaciones de producción, es fundamental tratar cualquier agente
que opere fuera de su control directo como una entidad potencialmente no confiable.

Todos los datos recibidos de un agente externo—including pero no limitado a su AgentCard, mensajes,
artefactos y estados de tareas—deben ser tratados como entrada no confiable. Por ejemplo, un agente malicioso
podría proporcionar una AgentCard que contenga datos manipulados en sus campos (por ejemplo, descripción, nombre,
skills.description). Si estos datos se utilizan sin saneamiento para construir indicaciones para un Modelo
de Lenguaje Grande (LLM), su aplicación podría quedar expuesta a ataques de inyección de indicaciones. El no
validar y sanear adecuadamente estos datos antes de usarlos puede introducir vulnerabilidades de seguridad en
su aplicación.

> Los desarrolladores son responsables de implementar medidas de seguridad apropiadas, como la validación de entradas
> y el manejo seguro de credenciales para proteger sus sistemas y usuarios.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---