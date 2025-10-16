<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### CORE: Tu Capa de Memoria Personal para Aplicaciones de IA

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="Insignia DeepWiki" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Documentación</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Destacados de Investigación

La memoria CORE logra una precisión promedio de **88.24%** en el conjunto de datos Locomo en todas las tareas de razonamiento, superando significativamente a otros proveedores de memoria. Consulta este [blog](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) para más información.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Las preguntas de salto único requieren respuestas basadas en una sola sesión; (2) Las preguntas de salto múltiple requieren sintetizar información de múltiples sesiones diferentes; (3) Las preguntas de conocimiento de dominio abierto pueden responderse integrando la información proporcionada por el hablante con conocimiento externo como sentido común o hechos del mundo; (4) Las preguntas de razonamiento temporal pueden responderse mediante razonamiento temporal y capturando pistas de datos relacionadas con el tiempo dentro de la conversación;

## Descripción general

**Problema** 

Los desarrolladores pierden tiempo re-explicando el contexto a las herramientas de IA. ¿Llegaste al límite de tokens en Claude? Comienza desde cero y pierdes todo. ¿Cambias de ChatGPT/Claude a Cursor? Explica tu contexto nuevamente. Tus conversaciones, decisiones y conocimientos desaparecen entre sesiones. Con cada nueva herramienta de IA, el costo de cambiar de contexto aumenta.

**Solución** - **CORE** (**Motor de Observación y Recuperación Contextual**)

CORE es una capa de memoria unificada y persistente de código abierto para todas tus herramientas de IA. Tu contexto te acompaña de Cursor a Claude, de ChatGPT a Claude Code. Un gráfico de conocimiento recuerda quién dijo qué, cuándo y por qué. Conéctate una vez, recuerda en todas partes. Deja de gestionar el contexto y comienza a construir.

## 🚀 CORE Autohospedado
¿Quieres ejecutar CORE en tu propia infraestructura? El autohospedaje te da control total sobre tus datos y despliegue.

**Requisitos previos**:

- Docker (20.10.0+) y Docker Compose (2.20.0+) instalados
- Clave de API de OpenAI

> **Nota sobre Modelos Open-Source:** Probamos opciones OSS como Ollama y modelos GPT, pero su extracción de hechos y calidad de grafos no fueron suficientes. Estamos buscando activamente alternativas.

### Instalación

1. Clona el repositorio:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Configura las variables de entorno en `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Inicie el servicio
```
docker-compose up -d
```

Una vez desplegado, puedes configurar tus proveedores de IA (OpenAI, Anthropic) y comenzar a construir tu gráfico de memoria.

👉 [Ver guía completa de auto-hospedaje](https://docs.heysol.ai/self-hosting/docker)

Nota: Probamos modelos de código abierto como Ollama o GPT OSS pero la generación de hechos no fue buena, aún estamos buscando cómo mejorar eso y luego también soportaremos modelos OSS.

## 🚀 CORE Cloud
**Construye tu gráfico de memoria unificado en 5 minutos:**

¿No quieres administrar infraestructura? CORE Cloud te permite construir tu sistema personal de memoria al instante: sin configuración, sin servidores, solo memoria que funciona.

1. **Regístrate** en [core.heysol.ai](https://core.heysol.ai) y crea tu cuenta
2. **Visualiza tu gráfico de memoria** y observa cómo CORE forma automáticamente conexiones entre hechos
3. **Pruébalo**: pregunta "¿Qué sabes sobre mí?" en la sección de conversación
4. Conecta tus herramientas:
   - [Claude](https://docs.heysol.ai/providers/claude) y [Cursor](https://docs.heysol.ai/providers/cursor): programación con contexto
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) y [Codex CLI](https://docs.heysol.ai/providers/codex): programación en terminal con memoria
   - [Agregar extensión de navegador](https://docs.heysol.ai/providers/browser-extension): lleva tu memoria a cualquier sitio web
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github): agrega contexto de proyecto automáticamente

## 🧩 Funciones Clave

### 🧠 **Memoria Unificada y Portátil**: 
Agrega y recupera tu memoria en **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS's Kiro, VS Code y Roo Code** vía MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Grafo de Conocimiento Temporal + Reificado**: 

Recuerda la historia detrás de cada hecho: rastrea quién dijo qué, cuándo y por qué con relaciones ricas y procedencia completa, no solo almacenamiento plano

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Extensión de Navegador**: 

Guarda conversaciones y contenido de ChatGPT, Grok, Gemini, Twitter, YouTube, publicaciones de blogs y cualquier página web directamente en tu memoria CORE.

**Cómo usar la extensión**
1. [Descarga la extensión](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) desde Chrome Web Store.
2. Inicia sesión en el [panel de CORE](https://core.heysol.ai)
   - Navega a Configuración (esquina inferior izquierda)
   - Ve a Clave API → Generar nueva clave → Nómbrala “extensión.”
3. Abre la extensión, pega tu clave API y guarda.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Chatea con Memoria**: 
Haz preguntas como "¿Cuáles son mis preferencias de escritura?" con información instantánea de tu conocimiento conectado

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Sincronización Automática desde Apps**:

Captura automáticamente el contexto relevante de Linear, Slack, Notion, GitHub y otras aplicaciones conectadas en tu memoria CORE

📖 **[Ver todas las integraciones](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - Lista completa de servicios compatibles y sus características

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **Centro de Integración MCP**: 

Conecta Linear, Slack, GitHub, Notion una vez a CORE—luego utiliza todas sus herramientas en Claude, Cursor o cualquier cliente MCP con una sola URL


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Cómo CORE crea memoria

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

La canalización de ingestión de CORE tiene cuatro fases diseñadas para capturar el contexto evolutivo:

1. **Normalización**: Vincula nueva información con el contexto reciente, divide documentos largos en fragmentos coherentes mientras mantiene referencias cruzadas, y estandariza términos para que, cuando CORE extrae conocimiento, trabaje con una entrada limpia y contextualizada en lugar de texto desordenado.
2. **Extracción**: Extrae significado del texto normalizado identificando entidades (personas, herramientas, proyectos, conceptos), convirtiéndolas en declaraciones con contexto, fuente y tiempo, y mapeando relaciones. Por ejemplo, “Escribimos CORE en Next.js” se convierte en: Entidades (CORE, Next.js), Declaración (CORE fue desarrollado usando Next.js), y Relación (fue desarrollado usando).
3. **Resolución**: Detecta contradicciones, rastrea cómo evolucionan las preferencias, y preserva múltiples perspectivas con procedencia en lugar de sobrescribirlas, para que la memoria refleje todo tu recorrido, no solo la última instantánea.
4. **Integración de Grafo**: Conecta entidades, declaraciones y episodios en un grafo de conocimiento temporal que enlaza hechos con su contexto e historia, convirtiendo datos aislados en una red viva de conocimiento que los agentes realmente pueden usar.

El Resultado: En lugar de una base de datos plana, CORE te da una memoria que crece y cambia contigo, preservando contexto, evolución y propiedad para que los agentes realmente puedan usarla.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Cómo CORE recupera de la memoria

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Cuando le preguntas algo a CORE, no solo busca texto: explora todo tu grafo de conocimiento para encontrar las respuestas más útiles.

1. **Búsqueda**: CORE revisa la memoria desde múltiples ángulos a la vez: búsqueda por palabras clave para coincidencias exactas, búsqueda semántica para ideas relacionadas aunque estén expresadas de forma diferente, y recorrido de grafo para seguir vínculos entre conceptos conectados.
2. **Reordenamiento**: Los resultados recuperados se reordenan para destacar los más relevantes y diversos, asegurando que no solo veas coincidencias obvias sino también conexiones más profundas.
3. **Filtrado**: CORE aplica filtros inteligentes basados en tiempo, fiabilidad y fuerza de relación, para que solo aflore el conocimiento más significativo.
4. **Salida**: Recibes tanto hechos (declaraciones claras) como episodios (el contexto original del que provienen), de modo que el recuerdo siempre esté fundamentado en contexto, tiempo e historia.

El resultado: CORE no solo recuerda hechos, los recuerda en el contexto, tiempo e historia adecuados, para que los agentes puedan responder como tú lo recordarías.

## Documentación

Explora nuestra documentación para aprovechar al máximo CORE

- [Conceptos Básicos](https://docs.heysol.ai/concepts/memory_graph)
- [Auto hospedaje](https://docs.heysol.ai/self-hosting/overview)
- [Conectar Core MCP con Claude](https://docs.heysol.ai/providers/claude)
- [Conectar Core MCP con Cursor](https://docs.heysol.ai/providers/cursor)
- [Conectar Core MCP con Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Conectar Core MCP con Codex](https://docs.heysol.ai/providers/codex) 

- [Conceptos Básicos](https://docs.heysol.ai/overview)
- [Referencia de API](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Seguridad

CORE se toma la seguridad en serio. Implementamos prácticas de seguridad estándar de la industria para proteger tus datos:

- **Cifrado de datos**: Todos los datos en tránsito (TLS 1.3) y en reposo (AES-256)
- **Autenticación**: OAuth 2.0 y autenticación por enlace mágico
- **Control de acceso**: Aislamiento por espacio de trabajo y permisos basados en roles
- **Reporte de vulnerabilidades**: Por favor, informe problemas de seguridad a harshith@poozle.dev

Para información detallada sobre seguridad, consulte nuestra [Política de Seguridad](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Soporte

¿Tiene preguntas o comentarios? Estamos aquí para ayudarle:

- Discord: [Únase al canal core-support](https://discord.gg/YGUZcvDjUa)
- Documentación: [docs.heysol.ai](https://docs.heysol.ai)
- Correo electrónico: manik@poozle.dev

## Directrices de uso

**Almacene:**

- Historial de conversaciones
- Preferencias de usuario
- Contexto de tareas
- Materiales de referencia

**No almacene:**

- Datos sensibles (PII)
- Credenciales
- Registros del sistema
- Datos temporales

## 👥 Contribuidores

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---