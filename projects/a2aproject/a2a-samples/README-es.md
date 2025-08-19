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

Este repositorio contiene ejemplos de código y demostraciones que utilizan el [Protocolo Agent2Agent (A2A)](https://goo.gle/a2a).

## Repositorios Relacionados

- [A2A](https://github.com/a2aproject/A2A) - Especificación y documentación de A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK de Python para A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Herramienta de UI para inspeccionar agentes habilitados para A2A.

## Contribuir

¡Contribuciones bienvenidas! Consulta la [Guía de Contribución](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtener ayuda

Utiliza la [página de issues](https://github.com/a2aproject/a2a-samples/issues) para enviar sugerencias, comentarios o reportar errores.

## Descargo de responsabilidad

Este repositorio no es un producto oficialmente soportado por Google. El código en este repositorio es solo para fines demostrativos.

Importante: El código de ejemplo proporcionado es solo para demostración y muestra la mecánica del protocolo Agent-to-Agent (A2A). Al desarrollar aplicaciones en producción, es fundamental tratar cualquier agente que opere fuera de tu control directo como una entidad potencialmente no confiable.

Todos los datos recibidos de un agente externo—incluyendo pero no limitado a su AgentCard, mensajes, artefactos y estados de tareas—deben tratarse como entrada no confiable. Por ejemplo, un agente malicioso podría proporcionar un AgentCard con datos manipulados en sus campos (por ejemplo, descripción, nombre, skills.description). Si estos datos se usan sin sanitización para construir instrucciones para un Modelo de Lenguaje Extenso (LLM), podría exponer tu aplicación a ataques de inyección de instrucciones. No validar y sanitizar correctamente estos datos antes de usarlos puede introducir vulnerabilidades de seguridad en tu aplicación.

Los desarrolladores son responsables de implementar medidas de seguridad apropiadas, como la validación de entrada y el manejo seguro de credenciales para proteger sus sistemas y usuarios.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---