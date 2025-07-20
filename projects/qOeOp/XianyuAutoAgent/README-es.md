<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Sistema inteligente de atención al cliente para Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Solución de IA diseñada específicamente para la plataforma Xianyu, permite atención automatizada 24/7, soporta decisión colaborativa entre expertos, negociación inteligente y conversaciones sensibles al contexto.

## 🎮 Playground - Experiencia rápida (versión sin configuración)

¡No necesitas entorno local ni configurar Secrets! **Simplemente introduce los parámetros desde la web de GitHub Actions**, y lanza el robot de Xianyu con un solo clic.

### Cómo usar
1. **Haz Fork de este repositorio** → Haz clic en el botón `Fork` en la esquina superior derecha
2. **Dispara la Acción**:
   - Entra en la pestaña `Actions` de tu repositorio
   - Selecciona el flujo de trabajo **`🚀 Run Service`**
   - Haz clic en el botón **`Run workflow`** y rellena los parámetros:
      - `API Key`: Pega tu clave API del modelo grande (por ejemplo, Aliyun DashScope)
      - `Cookies`: Pega la cadena completa de cookies de Xianyu versión web
3. **Consulta los registros de ejecución**:
   - El robot comenzará a escuchar mensajes de Xianyu automáticamente
   - Busca `🤖 Reply:` en los logs de Action para ver el historial de conversaciones

### Notas importantes
⚠️ Ten en cuenta las limitaciones de ejecución temporal:
- Por defecto funciona **30 minutos** (limitación de cuentas gratuitas de GitHub)
- La información sensible (como cookies) **no se almacena**, solo es válida para esa ejecución

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Características principales

### Motor de conversación inteligente
| Módulo         | Implementación técnica   | Características clave                                     |
| -------------- | ----------------------- | --------------------------------------------------------- |
| Conciencia de contexto | Almacenamiento de historial de conversación | Gestión ligera de la memoria del chat, historial completo como entrada de contexto para LLM |
| Enrutamiento experto | LLM prompt+reglas de enrutamiento | Identificación de intención basada en ingeniería de prompts → Distribución dinámica a agentes expertos, soporta cambio entre negociación/técnico/soporte |

### Matriz de funciones de negocio
| Módulo     | Implementado                   | En desarrollo                   |
| ---------- | ----------------------------- | ------------------------------- |
| Motor principal | ✅ Respuesta automática LLM<br>✅ Gestión de contexto | 🔄 Mejora de análisis de sentimiento          |
| Sistema de negociación | ✅ Estrategia de precios escalonada         | 🔄 Función de comparación de mercado          |
| Soporte técnico | ✅ Integración de búsqueda web                 | 🔄 Mejora de base de conocimientos RAG        |

## 🚴 Comenzar rápidamente

### Requisitos del entorno
- JDK 21+
- Maven 3.9.10+

### Pasos de instalación

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Participación y contribución

Se invita a enviar sugerencias mediante Issues o contribuir con código mediante PRs, por favor sigue la [Guía de Contribución](https://contributing.md/)



## 🛡 Consideraciones

⚠️ Atención: **Este proyecto es solo para fines de aprendizaje e intercambio. Si hay alguna infracción, contacta al autor para su eliminación.**

Debido a la naturaleza especial del proyecto, el equipo de desarrollo puede en cualquier momento **detener las actualizaciones** o **eliminar el proyecto**.


## 🧸 Agradecimientos especiales

Este proyecto ha sido reconstruido a partir de los siguientes proyectos de código abierto:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Sistema inteligente de chatbot para Xianyu, desarrollado por [@shaxiu](https://github.com/shaxiu) y [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---