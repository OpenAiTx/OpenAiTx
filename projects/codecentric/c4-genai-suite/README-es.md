# c4 GenAI Suite

Una aplicación de chatbot de IA con integración de Model Context Provider (MCP), impulsada por Langchain y compatible con todos los principales Modelos de Lenguaje de Gran Escala (LLMs) y Modelos de Embedding.

Los administradores pueden crear asistentes con diferentes capacidades añadiendo extensiones, como servicios RAG (Generación Aumentada por Recuperación) o servidores MCP. La aplicación está construida utilizando una pila tecnológica moderna, incluyendo React, NestJS y Python FastAPI para el servicio REI-S.

Los usuarios pueden interactuar con los asistentes a través de una interfaz fácil de usar. Dependiendo de la configuración del asistente, los usuarios pueden hacer preguntas, subir sus propios archivos o utilizar otras funciones. Los asistentes interactúan con varios proveedores de LLM para proporcionar respuestas basadas en las extensiones configuradas. La información contextual proporcionada por las extensiones configuradas permite a los asistentes responder preguntas específicas de dominio y ofrecer información relevante.

La aplicación está diseñada para ser modular y extensible, permitiendo a los usuarios crear asistentes con diferentes capacidades mediante la adición de extensiones.

![vídeo corto de demostración del uso básico](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Características

### Modelos de Lenguaje de Gran Escala (LLM) y Modelos Multimodales

La c4 GenAI Suite ya es compatible con muchos modelos directamente. Y si tu modelo preferido aún no está soportado, debería ser fácil escribir una extensión para soportarlo.

* Modelos compatibles con OpenAI
* Modelos Azure OpenAI
* Modelos Bedrock
* Modelos Google GenAI
* Modelos compatibles con Ollama
### Generación Aumentada por Recuperación (RAG)

La Suite c4 GenAI incluye REI-S, un servidor para preparar archivos para su consumo por el LLM.

* REI-S, un servidor RAG integrado personalizado
  * Almacenes vectoriales
    * pgvector
    * Azure AI Search
  * Modelos de embedding
    * Embeddings compatibles con OpenAI
    * Embeddings de Azure OpenAI
    * Embeddings compatibles con Ollama
  * Formatos de archivo:
    * pdf, docx, pptx, xlsx, ...
    * transcripción de voz de archivos de audio (vía Whisper)

### Extensiones

La Suite c4 GenAI está diseñada para ser extensible. Es fácil escribir extensiones, así como utilizar un servidor MCP ya existente.

* Servidores de Protocolo de Contexto de Modelo (MCP)
* Systemprompt personalizado
* Búsqueda de Bing
* Calculadora
## Comenzando

### Usando Docker-Compose

- Ejecuta `docker compose up` en la raíz del proyecto.
- Abre la [aplicación](http://localhost:3333) en un navegador. Las credenciales de inicio de sesión por defecto son usuario `admin@example.com` y contraseña `secret`.

![video mostrando la configuración del asistente](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Usando Helm y Kubernetes

Para el despliegue en entornos Kubernetes, por favor consulta el [README de nuestro Helm Chart](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Configuración de Asistentes y Extensiones

La c4 GenAI Suite gira en torno a los *asistentes*.
Cada asistente consiste en un conjunto de extensiones, que determinan el modelo LLM y qué herramientas puede utilizar.

- En el área de administración (haz clic en el nombre de usuario en la parte inferior izquierda), ve a la [sección de asistentes](http://localhost:3333/admin/assistants).
- Agrega un asistente con el botón verde `+` junto al título de la sección. Elige un nombre y una descripción.
- Selecciona el asistente creado y haz clic en el botón verde `+ Agregar Extensión`.
- Selecciona el modelo y completa las credenciales.
- Usa el botón `Probar` para verificar que funciona y `guardar`.

Ahora puedes regresar a la [página de chat](http://localhost:3333/chat) (haz clic en `c4 GenAI Suite` en la parte superior izquierda) y comenzar una nueva conversación con tu nuevo asistente.

> [!TIP]
> Nuestro `docker-compose` incluye un Ollama local, que se ejecuta en la CPU. Puedes utilizarlo para pruebas rápidas. Pero será lento y probablemente querrás usar otro modelo. Si deseas utilizarlo, simplemente crea la siguiente extensión de modelo en tu Asistente.
> * Extensión: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Modelo: `llama3.2`

### Protocolo de Contexto de Modelo (MCP) [opcional]

Utilice cualquier servidor MCP que ofrezca una interfaz `sse` con la Extensión `MCP Tools` (o use nuestro `mcp-tool-as-server` como proxy frente a un servidor MCP `stdio`).
Cada servidor MCP puede configurarse en detalle como una extensión.

### Generación Aumentada por Recuperación (RAG) / Búsqueda de Archivos [opcional]

Utilice nuestro servidor RAG `REI-S` para buscar en archivos proporcionados por el usuario. Solo necesita configurar una extensión `Buscar Archivos` para el asistente.
Este proceso se describe en detalle en [el subdirectorio `services/reis`](services/reis/#example-configuration-in-c4).

## Contribuir y Desarrollo

* Consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) para obtener pautas sobre cómo contribuir.
* Para la incorporación de desarrolladores, revise [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Bloques Constructivos Principales

La aplicación consiste en un **Frontend**, un **Backend** y un servicio **REI-S**.

```
┌──────────┐
│  Usuario │
└─────┬────┘
      │ acceso
      ▼
┌──────────┐
│ Frontend │
└─────┬────┘
      │ acceso
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ acceso
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Modelo de Embedding │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Almacén Vectorial │
└──────────┘     └─────────────────┘
```
### Frontend

El frontend está construido con React y TypeScript, proporcionando una interfaz fácil de usar para interactuar con el backend y el servicio REI-S. Incluye funcionalidades para la gestión de asistentes, extensiones y funciones de chat.

> Fuentes: `/frontend`

### Backend

El backend está desarrollado con NestJS y TypeScript, sirviendo como la capa principal de API para la aplicación. Gestiona las solicitudes del frontend e interactúa con los proveedores de LLM para facilitar las funcionalidades de chat. El backend también administra los asistentes y sus extensiones, permitiendo a los usuarios configurar y utilizar diversos modelos de IA para sus chats.

Además, el backend gestiona la autenticación de usuarios y se comunica con el servicio REI-S para la indexación y recuperación de archivos.

Para la persistencia de datos, el backend utiliza una base de datos **PostgreSQL**.

> Fuentes: `/backend`

### REI-S

El REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) es un servidor basado en Python que proporciona capacidades básicas de RAG (Generación Aumentada por Recuperación). Permite la extracción de contenido de archivos, indexación y consultas, lo que habilita a la aplicación para manejar grandes conjuntos de datos de manera eficiente. El servicio REI-S está diseñado para funcionar sin problemas con el backend, proporcionando los datos necesarios para las funcionalidades de chat y búsquedas de archivos.

El REI-S es compatible con Azure AI Search y pgvector para el almacenamiento vectorial, permitiendo opciones de recuperación de datos flexibles y escalables. El servicio puede configurarse mediante variables de entorno para especificar el tipo de almacenamiento vectorial y los detalles de conexión.

> Fuentes: `/services/reis`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---