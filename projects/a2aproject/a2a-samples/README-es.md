# Ejemplos de Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

Este repositorio contiene ejemplos de código y demostraciones que utilizan el [Protocolo Agent2Agent (A2A)](https://goo.gle/a2a).

## Repositorios relacionados

- [A2A](https://github.com/a2aproject/A2A) - Especificación y documentación de A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK de A2A para Python.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Herramienta de interfaz gráfica para inspeccionar agentes habilitados para A2A.

## Contribuir

¡Contribuciones bienvenidas! Consulta la [Guía de Contribución](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Obtener ayuda

Utiliza la [página de issues](https://github.com/a2aproject/a2a-samples/issues) para enviar sugerencias, comentarios o reportar errores.

## Descargo de responsabilidad

Este repositorio no es un producto oficial de Google. El código presente es solo para propósitos demostrativos.

Importante: El código de ejemplo proporcionado es solo para demostración y muestra la mecánica del protocolo Agent-to-Agent (A2A). Al construir aplicaciones en producción, es fundamental tratar cualquier agente fuera de tu control directo como una entidad potencialmente no confiable.

Todos los datos recibidos de un agente externo —incluyendo, pero no limitado a, su AgentCard, mensajes, artefactos y estados de tareas— deben ser tratados como entrada no confiable. Por ejemplo, un agente malicioso podría proporcionar un AgentCard con datos manipulados en sus campos (por ejemplo, descripción, nombre, skills.description). Si estos datos se usan sin sanitizar para construir prompts para un Modelo de Lenguaje Grande (LLM), tu aplicación podría quedar expuesta a ataques de inyección de prompts. Si no validas y sanitizas adecuadamente estos datos antes de usarlos, puedes introducir vulnerabilidades de seguridad en tu aplicación.

Los desarrolladores son responsables de implementar medidas de seguridad apropiadas, como validación de entradas y gestión segura de credenciales, para proteger sus sistemas y usuarios.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---