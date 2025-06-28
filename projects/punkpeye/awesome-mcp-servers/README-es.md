# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

Una lista seleccionada de servidores Model Context Protocol (MCP) destacados.

* [¿Qué es MCP?](#qué-es-mcp)
* [Clientes](#clientes)
* [Tutoriales](#tutoriales)
* [Comunidad](#comunidad)
* [Leyenda](#leyenda)
* [Implementaciones de Servidor](#implementaciones-de-servidor)
* [Frameworks](#frameworks)
* [Consejos y Trucos](#consejos-y-trucos)

## ¿Qué es MCP?

[MCP](https://modelcontextprotocol.io/) es un protocolo abierto que permite a los modelos de IA interactuar de forma segura con recursos locales y remotos a través de implementaciones de servidor estandarizadas. Esta lista se centra en servidores MCP listos para producción y experimentales que amplían las capacidades de la IA mediante acceso a archivos, conexiones a bases de datos, integraciones de API y otros servicios contextuales.

## Clientes

Consulta [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) y [glama.ai/mcp/clients](https://glama.ai/mcp/clients).

> [!TIP]
> [Glama Chat](https://glama.ai/chat) es un cliente de IA multimodal con soporte MCP y [AI gateway](https://glama.ai/gateway).

## Tutoriales

* [Model Context Protocol (MCP) Inicio Rápido](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [Configura la App de Escritorio de Claude para usar una base de datos SQLite](https://youtu.be/wxCCzo9dGj0)

## Comunidad

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Servidor de Discord](https://glama.ai/mcp/discord)

## Leyenda

* 🎖️ – implementación oficial
* lenguaje de programación
  * 🐍 – Código base Python
  * 📇 – Código base TypeScript (o JavaScript)
  * 🏎️ – Código base Go
  * 🦀 – Código base Rust
  * #️⃣ - Código base C#
  * ☕ - Código base Java
  * 🌊 – Código base C/C++
* alcance
  * ☁️ - Servicio en la Nube
  * 🏠 - Servicio Local
  * 📟 - Sistemas Embebidos
* sistema operativo
  * 🍎 – Para macOS
  * 🪟 – Para Windows
  * 🐧 - Para Linux

> [!NOTE]
> ¿Confundido entre Local 🏠 y Nube ☁️?
> * Usa local cuando el servidor MCP se comunica con un software instalado localmente, por ejemplo, tomar control del navegador Chrome.
> * Usa red cuando el servidor MCP se comunica con APIs remotas, por ejemplo, API de clima.

## Implementaciones de Servidor

> [!NOTE]
> Ahora tenemos un [directorio web](https://glama.ai/mcp/servers) que está sincronizado con el repositorio.

* 🔗 - [Agregadores](#agregadores)
* 🎨 - [Arte y Cultura](#arte-y-cultura)
* 📂 - [Automatización de Navegadores](#automatización-de-navegadores)
* ☁️ - [Plataformas en la Nube](#plataformas-en-la-nube)
* 👨‍💻 - [Ejecución de Código](#ejecución-de-código)
* 🤖 - [Agentes de Programación](#agentes-de-programación)
* 🖥️ - [Línea de Comandos](#línea-de-comandos)
* 💬 - [Comunicación](#comunicación)
* 👤 - [Plataformas de Datos de Clientes](#plataformas-de-datos-de-clientes)
* 🗄️ - [Bases de Datos](#bases-de-datos)
* 📊 - [Plataformas de Datos](#plataformas-de-datos)
* 🚚 - [Entrega](#entrega)
* 🛠️ - [Herramientas para Desarrolladores](#herramientas-para-desarrolladores)
* 🧮 - [Herramientas de Ciencia de Datos](#herramientas-de-ciencia-de-datos)
* 📟 - [Sistemas Embebidos](#sistemas-embebidos)
* 📂 - [Sistemas de Archivos](#sistemas-de-archivos)
* 💰 - [Finanzas y Fintech](#finanzas-y-fintech)
* 🎮 - [Juegos](#juegos)
* 🧠 - [Conocimiento y Memoria](#conocimiento-y-memoria)
* 🗺️ - [Servicios de Localización](#servicios-de-localización)
* 🎯 - [Marketing](#marketing)
* 📊 - [Monitoreo](#monitoreo)
* 🎥 - [Procesamiento Multimedia](#procesamiento-multimedia)
* 🔎 - [Búsqueda y Extracción de Datos](#búsqueda)
* 🔒 - [Seguridad](#seguridad)
* 🌐 - [Redes Sociales](#redes-sociales)
* 🏃 - [Deportes](#sports)
* 🎧 - [Gestión de Soporte y Servicio](#support-and-service-management)
* 🌎 - [Servicios de Traducción](#translation-services)
* 🎧 - [Texto a Voz](#text-to-speech)
* 🚆 - [Viajes y Transporte](#travel-and-transportation)
* 🔄 - [Control de Versiones](#version-control)
* 🛠️ - [Otras Herramientas e Integraciones](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>Agregadores

Servidores para acceder a muchas aplicaciones y herramientas a través de un solo servidor MCP.

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - Consulta más de 40 aplicaciones con un solo binario usando SQL. También puede conectarse a tu base de datos compatible con PostgreSQL, MySQL o SQLite. Local primero y privado por diseño.
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP es el único servidor MCP middleware unificado que gestiona tus conexiones MCP con GUI.
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - Conecta y unifica datos a través de varias plataformas y bases de datos con [MindsDB como un solo servidor MCP](https://docs.mindsdb.com/mcp/overview).
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - Una lista de servidores MCP para que tu cliente pueda consultar qué servidores puede usar para mejorar tu flujo de trabajo diario.
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Convierte una API web en un servidor MCP en 10 segundos y agrégalo al registro open source: https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - Conecta con 2,500 APIs con más de 8,000 herramientas preconstruidas y gestiona servidores para tus usuarios, en tu propia app.
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - Un servidor proxy integral que combina múltiples servidores MCP en una sola interfaz con amplias funciones de visibilidad. Proporciona descubrimiento y gestión de herramientas, prompts, recursos y plantillas a través de servidores, además de un playground para depuración al construir servidores MCP.
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - Herramienta proxy para componer múltiples servidores MCP en un único endpoint unificado. Escala tus herramientas de IA balanceando las solicitudes entre varios servidores MCP, similar a cómo Nginx funciona para servidores web.
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP es el único servidor MCP middleware unificado que gestiona tus conexiones MCP con GUI.
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Conecta sin problemas y de forma segura Claude Desktop y otros hosts MCP a tus aplicaciones favoritas (Notion, Slack, Monday, Airtable, etc.). Tarda menos de 90 segundos.
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - Convierte un servicio web en un servidor MCP con un solo clic sin hacer ningún cambio de código.
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - Potente herramienta de generación de imágenes utilizando la API Imagen 3.0 de Google a través de MCP. Genera imágenes de alta calidad a partir de prompts de texto con controles avanzados de fotografía, arte y fotorrealismo.
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - Servidor MCP para generación/edición de imágenes con OpenAI GPT.

### 🎨 <a name="art-and-culture"></a>Arte y Cultura

Accede y explora colecciones de arte, patrimonio cultural y bases de datos de museos. Permite a modelos de IA buscar y analizar contenido artístico y cultural.

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Servidor MCP local que genera animaciones usando Manim.
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Añade, analiza, busca y genera ediciones de video desde tu colección Video Jungle
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Servidor MCP para interactuar con la API de Discogs
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ Servidor MCP para interactuar con el corpus de Quran.com a través de la API REST oficial v4.
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - Integración de la API de la Colección del Museo Metropolitano de Arte para buscar y mostrar obras en la colección.
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - Integración de la API del Rijksmuseum para búsqueda de obras, detalles y colecciones
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Integración con la API de Oorlogsbronnen (Fuentes de Guerra) para acceder a registros históricos, fotografías y documentos de la Segunda Guerra Mundial en los Países Bajos (1940-1945)
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - Integración de servidor MCP para DaVinci Resolve proporcionando potentes herramientas para edición de video, corrección de color, gestión de medios y control de proyectos
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - Servidor MCP que integra la API de AniList para información de anime y manga
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Servidor MCP usando la API de Aseprite para crear pixel art
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - Servidor MCP y extensión que permite el control por lenguaje natural de NVIDIA Isaac Sim, Lab, OpenUSD, etc.
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Servidor MCP para la API de Open Library que permite a los asistentes de IA buscar información de libros. 
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Servidor MCP para Autodesk Maya
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - Proporciona un análisis y gráficos Bazi (Astrología China) completos y precisos


### 📂 <a name="browser-automation"></a>Automatización de Navegadores

Acceso a contenido web y capacidades de automatización. Permite buscar, extraer y procesar contenido web en formatos compatibles con IA.

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - Herramienta basada en FastMCP que obtiene los videos en tendencia de Bilibili y los expone mediante una interfaz MCP estándar.
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Servidor MCP que permite buscar contenido de Bilibili. Proporciona ejemplos de integración con LangChain y scripts de prueba.
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - Navegador autoalojado usando agente con MCP incorporado y soporte A2A.
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Servidor MCP para automatización de navegador usando Playwright
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Servidor MCP en python usando Playwright para automatización de navegador, más adecuado para LLM
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - Automatiza interacciones de navegador en la nube (por ejemplo, navegación web, extracción de datos, relleno de formularios, y más)
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - Automatiza tu navegador Chrome local
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use empaquetado como servidor MCP con transporte SSE. Incluye un dockerfile para ejecutar chromium en docker + un servidor vnc.
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Servidor MCP usando Playwright para automatización y webscraping
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - Servidor MCP emparejado con una extensión de navegador que permite a clientes LLM controlar el navegador del usuario (Firefox).
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - Servidor MCP para interactuar con Apple Reminders en macOS
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - Extrae datos estructurados de cualquier sitio web. Solo indica el prompt y obtén JSON.
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - Obtén subtítulos y transcripciones de YouTube para análisis por IA
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Implementación `minimal` servidor/cliente MCP usando Azure OpenAI y Playwright.
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Servidor MCP oficial de Microsoft Playwright, que permite a los LLMs interactuar con páginas web mediante snapshots de accesibilidad estructurada
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Automatización de navegador para web scraping e interacción
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - Servidor MCP para interactuar con navegadores compatibles con manifest v2.
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Servidor MCP que permite búsquedas web gratuitas usando resultados de Google, sin necesidad de claves API.
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Integración de servidor MCP con Apple Shortcuts

### ☁️ <a name="cloud-platforms"></a>Plataformas en la Nube

Integración de servicios de plataformas en la nube. Permite la gestión e interacción con infraestructura y servicios en la nube.

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - Servidores MCP de AWS para integración perfecta con servicios y recursos de AWS.
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - MCP construido sobre productos de Qiniu Cloud, soportando acceso a almacenamiento en la nube de Qiniu, servicios de procesamiento de medios, etc.
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - Subida y manipulación de almacenamiento IPFS
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Servidor Kubernetes Model Context Protocol (MCP) que proporciona herramientas para interactuar con clústeres Kubernetes mediante una interfaz estandarizada, incluyendo descubrimiento de recursos API, gestión de recursos, logs de pods, métricas y eventos.
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - Este es un servidor MCP usado para consultar libros, y puede aplicarse en clientes MCP comunes, como Cherry Studio.
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - Un servidor ligero pero potente que permite a los asistentes de IA ejecutar comandos AWS CLI, usar pipes de Unix y aplicar plantillas de prompts para tareas comunes de AWS en un entorno Docker seguro con soporte multi-arquitectura
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - Un servidor ligero pero robusto que permite a asistentes de IA ejecutar comandos CLI de Kubernetes (`kubectl`, `helm`, `istioctl`, y `argocd`) de forma segura usando pipes de Unix en un entorno Docker seguro con soporte multi-arquitectura.
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - Un servidor MCP que permite a asistentes de IA operar recursos en Alibaba Cloud, soportando ECS, Cloud Monitor, OOS y productos cloud ampliamente usados.  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - Servidor de gestión VMware ESXi/vCenter basado en MCP (Model Control Protocol), proporcionando interfaces REST API simples para gestión de máquinas virtuales.
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Integración con servicios de Cloudflare incluyendo Workers, KV, R2 y D1
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - Servidor MCP que permite a agentes de IA gestionar recursos Kubernetes a través de la abstracción Cyclops
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Integración con servicios Fastly
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - Implementación en Typescript de operaciones de clúster Kubernetes para pods, despliegues, servicios.
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Servidor Model Context Protocol para consultar y analizar recursos Azure a escala usando Azure Resource Graph, permitiendo a asistentes de IA explorar y monitorear infraestructura Azure.
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Wrapper sobre la línea de comandos Azure CLI que permite hablar directamente con Azure
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - Un MCP que da acceso a todos los componentes de Netskope Private Access dentro de entornos Netskope Private Access, incluyendo información detallada de configuración y ejemplos de uso con LLM.
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - Potente servidor MCP de Kubernetes con soporte adicional para OpenShift. Además de proporcionar operaciones CRUD para **cualquier** recurso de Kubernetes, este servidor ofrece herramientas especializadas para interactuar con tu clúster.
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Servidor Terraform MCP que permite a asistentes de IA gestionar y operar entornos Terraform, permitiendo leer configuraciones, analizar planes, aplicar configuraciones y gestionar el estado de Terraform.
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Servidor MCP para interactuar con Pulumi usando la API de Automatización de Pulumi y la API de Pulumi Cloud. Permite a clientes MCP realizar operaciones Pulumi como obtener información de paquetes, previsualizar cambios, desplegar actualizaciones y recuperar salidas de stack programáticamente.
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Servidor Model Context Protocol (MCP) para Kubernetes que permite a asistentes de IA como Claude, Cursor y otros interactuar con clústeres Kubernetes mediante lenguaje natural.
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - Operaciones de clúster Kubernetes mediante MCP
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Servidor MCP en Go para interactuar con recursos de Nutanix Prism Central.
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - Obtén información actualizada de precios EC2 con una sola llamada. Rápido. Impulsado por un catálogo de precios AWS preprocesado.
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - Proporciona gestión y operaciones MCP multi-clúster Kubernetes, con interfaz de gestión, logging, y casi 50 herramientas integradas para escenarios comunes de DevOps y desarrollo. Soporta recursos estándar y CRD.
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - Proporciona gestión y operaciones MCP multi-clúster Kubernetes. Puede integrarse como SDK en tu propio proyecto e incluye casi 50 herramientas integradas para escenarios comunes de DevOps y desarrollo. Soporta recursos estándar y CRD.
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - Servidor MCP para la gestión de Kubernetes y análisis de la salud de tu clúster y aplicaciones.
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Servidor MCP para Azure Data Lake Storage. Puede gestionar contenedores, realizar operaciones de lectura/escritura/carga/descarga en archivos de contenedores y gestionar metadatos de archivos.
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S es una herramienta de gestión de recursos de Kubernetes impulsada por IA que permite a los usuarios operar cualquier recurso en clústeres de Kubernetes a través de interacción en lenguaje natural, incluyendo recursos nativos (como Deployment, Service) y recursos personalizados (CRD). No es necesario memorizar comandos complejos: solo describe tus necesidades y la IA ejecutará con precisión las operaciones correspondientes en el clúster, mejorando enormemente la usabilidad de Kubernetes.
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - Gestiona tus recursos de Redis Cloud sin esfuerzo usando lenguaje natural. Crea bases de datos, monitorea suscripciones y configura implementaciones en la nube con comandos simples.
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - Un potente servidor MCP que permite a los asistentes de IA interactuar perfectamente con instancias de Portainer, proporcionando acceso en lenguaje natural a la gestión de contenedores, operaciones de despliegue y capacidades de monitoreo de infraestructura.

### 👨‍💻 <a name="code-execution"></a>Ejecución de Código

Servidores de ejecución de código. Permiten que los LLMs ejecuten código en un entorno seguro, por ejemplo, para agentes de codificación.

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- Ejecuta código Python en un sandbox seguro mediante llamadas a herramientas MCP.
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - Ejecuta cualquier código generado por LLM en un entorno sandbox seguro y escalable y crea tus propias herramientas MCP usando JavaScript o Python, con soporte completo para paquetes NPM y PyPI.
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: Servidor MCP dockerizado para permitir que tu agente de IA acceda a cualquier API con documentación existente.
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – Un servidor MCP en Node.js que lanza sandboxes aislados basados en Docker para ejecutar fragmentos de JavaScript con instalación de dependencias npm al vuelo y cierre limpio.
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - Un sandbox para ejecución de código JavaScript que usa v8 para aislar código y ejecutar JavaScript generado por IA localmente sin riesgos. Soporta heap snapshotting para sesiones persistentes.

### 🤖 <a name="coding-agents"></a>Agentes de Programación

Agentes de programación completos que permiten a los LLMs leer, editar y ejecutar código y resolver tareas generales de programación de forma completamente autónoma.

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - Un agente de programación totalmente funcional que se basa en operaciones simbólicas de código utilizando servidores de lenguaje.
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - Agente de programación con herramientas básicas de lectura, escritura y línea de comandos.
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - Un servidor MCP que permite a los modelos de IA buscar, recuperar y resolver problemas de LeetCode. Soporta filtrado de metadatos, perfiles de usuario, envíos y acceso a datos de concursos.
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - Servidor MCP que permite el acceso automatizado a problemas de programación, soluciones, envíos y datos públicos de **LeetCode** con autenticación opcional para funciones específicas de usuario (por ejemplo, notas), soportando tanto `leetcode.com` (global) como `leetcode.cn` (China).
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - Un servidor MCP que permite a IA como Claude leer la estructura de directorios en un espacio de trabajo de VS Code, ver problemas detectados por linter(s) y el servidor de lenguaje, leer archivos de código y realizar ediciones.
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - Un servidor MCP de binario único que convierte código fuente en AST, independientemente del lenguaje.

### 🖥️ <a name="command-line"></a>Línea de Comandos

Ejecuta comandos, captura salidas y permite interactuar con shells y herramientas de línea de comandos.

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - Un servidor Model Context Protocol que proporciona acceso a iTerm. Puedes ejecutar comandos y hacer preguntas sobre lo que ves en la terminal iTerm.
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - Ejecuta cualquier comando con las herramientas `run_command` y `run_script`.
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - Intérprete seguro de Python basado en HF Smolagents `LocalPythonExecutor`.
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - Interfaz de línea de comandos con ejecución segura y políticas de seguridad personalizables.
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - Un servidor DeepSeek similar a MCP para terminal.
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Un servidor seguro de ejecución de comandos shell que implementa el Model Context Protocol (MCP).
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - Servidor Cisco pyATS que permite interacción estructurada y orientada a modelos con dispositivos de red.
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - Una navaja suiza que puede gestionar/ejecutar programas y leer/escribir/buscar/editar archivos de código y texto.
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - Servidor MCP que expone control SSH para servidores Linux y Windows vía Model Context Protocol. Ejecuta comandos shell remotos de forma segura con autenticación por contraseña o clave SSH.

### 💬 <a name="communication"></a>Comunicación

Integración con plataformas de comunicación para gestión de mensajes y operaciones de canal. Permite a los modelos de IA interactuar con herramientas de comunicación de equipos.

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Un servidor MCP de Nostr que permite interactuar con Nostr, permitiendo publicar notas y más.
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Interactúa con la búsqueda y línea de tiempo de Twitter.
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - Un servidor MCP para crear bandejas de entrada sobre la marcha para enviar, recibir y tomar acciones sobre correos electrónicos. No somos agentes de IA para correo electrónico, sino correo electrónico para Agentes de IA.
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Un servidor MCP para interactuar con la API de Google Tasks.
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Un servidor MCP que interactúa de forma segura con tu base de datos de iMessage a través del Model Context Protocol (MCP), permitiendo a los LLMs consultar y analizar conversaciones de iMessage. Incluye validación robusta de números de teléfono, procesamiento de adjuntos, gestión de contactos, manejo de chats grupales y soporte completo para envío y recepción de mensajes.
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Integración con la API de Telegram para acceder a datos de usuario, gestionar diálogos (chats, canales, grupos), recuperar mensajes y manejar el estado de lectura.
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Integración con la API de Telegram para acceder a datos de usuario, gestionar diálogos (chats, canales, grupos), recuperar mensajes, enviar mensajes y manejar el estado de lectura.
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Un servidor MCP para Inbox Zero. Añade funcionalidad sobre Gmail como encontrar qué correos necesitas responder o hacer seguimiento.
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - Un servidor MCP para ntfy para enviar/recibir notificaciones ntfy a tu servidor ntfy autoalojado desde Agentes de IA 📤 (soporta autenticación de token segura y más - ¡usa con npx o docker!)
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - Una aplicación servidor MCP que envía varios tipos de mensajes al robot de grupo de WeCom.
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Un servidor MCP que proporciona acceso seguro a tu base de datos de iMessage a través del Model Context Protocol (MCP), permitiendo a los LLMs consultar y analizar conversaciones de iMessage con validación adecuada de números de teléfono y manejo de adjuntos.
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - Un servidor MCP que actúa como adaptador en el ecosistema [ACP](https://agentcommunicationprotocol.dev). Expone sin problemas agentes ACP a clientes MCP, haciendo de puente entre ambos protocolos.
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Un servidor MCP junto con MCP host que proporciona acceso a equipos, canales y mensajes de Mattermost. MCP host está integrado como bot en Mattermost con acceso a servidores MCP que pueden ser configurados.
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - Un servidor MCP para buscar tus mensajes y contactos personales de WhatsApp y enviar mensajes a individuos o grupos.
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - Servidor MCP para integrar una Cuenta Oficial de LINE.
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - Integración con Gmail y Google Calendar.
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Integración de instancia Bluesky para consulta e interacción.
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Integración con espacios de trabajo de Slack para gestión de canales y mensajería.
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - El servidor MCP más potente para espacios de trabajo de Slack.
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 Este es un servidor MCP para interactuar con la API de VRChat. Puedes obtener información sobre amigos, mundos, avatares y más en VRChat.
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Un servidor MCP para interactuar con la API de Google Calendar. Basado en TypeScript.
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - El servidor MCP que te mantiene informado enviando notificaciones al teléfono usando ntfy.
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - Un servidor MCP para [DIDLogic](https://didlogic.com). Añade funcionalidad para gestionar endpoints SIP, números y destinos.
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Un servidor MCP para gestionar Google Tasks.
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - Servidor MCP que integra mensajería de Microsoft Teams (leer, publicar, mencionar, listar miembros e hilos).
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - Servidor MCP que conecta con toda la suite Microsoft 365 usando Graph API (incluyendo correo, archivos, Excel, calendario).
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - Servidor MCP para la Plataforma WhatsApp Business de YCloud.
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Servidor MCP para Product Hunt. Interactúa con publicaciones de tendencia, comentarios, colecciones, usuarios y más.


### 👤 <a name="customer-data-platforms"></a>Plataformas de Datos de Clientes

Proporciona acceso a perfiles de clientes dentro de plataformas de datos de clientes.

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - Conéctate con [iaptic](https://www.iaptic.com) para consultar compras de clientes, datos de transacciones y estadísticas de ingresos de aplicaciones.
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - Conecta cualquier Dato Abierto a cualquier LLM con Model Context Protocol.
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Un servidor MCP para acceder y actualizar perfiles en un servidor Apache Unomi CDP.
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - Un servidor MCP para interactuar con un Workspace de Tinybird desde cualquier cliente MCP.
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - Un servidor Model Context Protocol para generar gráficos visuales usando [AntV](https://github.com/antvis).

### 🗄️ <a name="databases"></a>Bases de Datos

Acceso seguro a bases de datos con capacidades de inspección de esquemas. Permite consultar y analizar datos con controles de seguridad configurables, incluyendo acceso solo lectura.

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  Navega tus [proyectos de Aiven](https://go.aiven.io/mcp-server) e interactúa con los servicios de PostgreSQL®, Apache Kafka®, ClickHouse® y OpenSearch®.
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - Servidor Supabase MCP con soporte para ejecución de consultas SQL y herramientas de exploración de bases de datos.
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Servicio MCP para Tablestore, incluye agregar documentos, búsqueda semántica de documentos basada en vectores y escalares, compatible con RAG y sin servidor.
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - Integración de base de datos MySQL en NodeJS con controles de acceso configurables e inspección de esquemas.
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – Servidor MCP de base de datos universal que soporta bases de datos principales.
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - Integración con base de datos TiDB con inspección de esquemas y capacidades de consulta.
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - El Motor Semántico para Clientes Model Context Protocol (MCP) y Agentes de IA.
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - Servidor MCP y MCP SSE que genera automáticamente una API basada en el esquema de la base de datos y los datos. Soporta PostgreSQL, Clickhouse, MySQL, Snowflake, BigQuery, Supabase.
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - Integración DICOM para consultar, leer y mover imágenes médicas e informes desde PACS y otros sistemas compatibles con DICOM.
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Servidor Chroma MCP para acceder a instancias locales y en la nube de Chroma con capacidades de recuperación.
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - Integración con la base de datos ClickHouse con inspección de esquemas y capacidades de consulta.
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Integración de Confluent para interactuar con las API REST de Confluent Kafka y Confluent Cloud.
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - El servidor MCP de Couchbase proporciona acceso unificado tanto a la nube Capella como a clústeres autogestionados para operaciones de documentos, consultas SQL++ y análisis de datos en lenguaje natural.
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Implementación de servidor MCP que proporciona interacción con Elasticsearch
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Servidor MCP todo en uno para desarrollo y operaciones de Postgres, con herramientas para análisis de rendimiento, ajuste y comprobaciones de salud
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Servidor MCP para Trino para consultar y acceder a datos de clústeres Trino.
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Implementación en Go de un servidor Model Context Protocol (MCP) para Trino
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - Integración de base de datos MySQL con controles de acceso configurables, inspección de esquemas y directrices de seguridad completas
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - Soporta SSE, STDIO; no se limita solo a la funcionalidad CRUD de MySQL; también incluye capacidades de análisis de excepciones de base de datos; controla permisos de base de datos basados en roles; y facilita a los desarrolladores la extensión de herramientas con personalización
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Integración con base de datos Airtable con inspección de esquema, capacidades de lectura y escritura
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Integración con base de datos Nocodb, capacidades de lectura y escritura
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Implementación de servidor para integración con Google BigQuery que habilita el acceso directo y capacidades de consulta sobre la base de datos BigQuery
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Integración de base de datos MySQL basada en Node.js que proporciona operaciones seguras sobre la base de datos MySQL
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Base de datos ledger Fireproof con sincronización multiusuario
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Un servidor MCP multidatabase de alto rendimiento construido en Golang, compatible con MySQL y PostgreSQL (NoSQL próximamente). Incluye herramientas integradas para ejecución de consultas, gestión de transacciones, exploración de esquemas, creación de consultas y análisis de rendimiento, con integración fluida de Cursor para flujos de trabajo de bases de datos mejorados.
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens: Servidor MCP con todas las funciones para bases de datos MongoDB
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Servicios de Firebase incluyendo Auth, Firestore y Storage.
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Integración con la base de datos Convex para inspeccionar tablas, funciones y ejecutar consultas puntuales ([Fuente](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts))
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - Servidor MCP de código abierto especializado en herramientas fáciles, rápidas y seguras para bases de datos.
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - Servidor MCP para consultas a GreptimeDB.
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Un servidor MCP que proporciona acceso seguro y de solo lectura a bases de datos SQLite a través del Model Context Protocol (MCP). Este servidor está construido con el framework FastMCP, que permite a los LLMs explorar y consultar bases de datos SQLite con funciones de seguridad integradas y validación de consultas.
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - Ejecuta consultas contra la API v2 de InfluxDB OSS.
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Integración con Snowflake implementando operaciones de lectura y (opcionalmente) escritura, así como seguimiento de insights
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Servidor MCP para Supabase para gestionar y crear proyectos y organizaciones en Supabase
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Servidor MCP para Apache Kafka y Timeplus. Capaz de listar tópicos de Kafka, obtener mensajes, guardar datos localmente y consultar datos en streaming con SQL vía Timeplus
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - Integración con VikingDB con introducción de colecciones e índices, almacenamiento y búsqueda vectorial.
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - Un servidor Model Context Protocol para MongoDB
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - Integración con base de datos DuckDB con inspección de esquemas y capacidades de consulta
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - Integración con base de datos BigQuery con inspección de esquemas y capacidades de consulta
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - Conéctate a cualquier base de datos compatible con JDBC y consulta, inserta, actualiza, elimina y más.
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - Servidor Model Context Protocol (MCP) que proporciona capacidades de interacción integral con bases de datos SQLite.
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Servidor MCP para Memgraph - incluye una herramienta para ejecutar consultas y un recurso de esquema.
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - Integración con base de datos PostgreSQL con inspección de esquemas y capacidades de consulta
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - Operaciones de bases de datos SQLite con funciones de análisis integradas
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Model Context Protocol con Neo4j (ejecuta consultas, memoria de grafo de conocimiento, gestiona instancias de Neo4j Aura)
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Un servidor MCP para crear y gestionar bases de datos Postgres usando Neon Serverless Postgres
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Servidor MCP para la plataforma Postgres de Nile - Gestiona y consulta bases de datos Postgres, inquilinos, usuarios y autenticación usando LLMs
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Un servidor MCP para conectividad genérica con Sistemas de Gestión de Bases de Datos (DBMS) vía el protocolo Open Database Connectivity (ODBC)
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Un servidor MCP para conectividad genérica con Sistemas de Gestión de Bases de Datos (DBMS) vía SQLAlchemy usando Python ODBC (pyodbc)
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Consulta y analiza bases de datos de Azure Data Explorer
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ - Consulta y analiza Prometheus, sistema de monitoreo de código abierto.
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - Da a los LLMs la capacidad de gestionar bases de datos Prisma Postgres (por ejemplo, crear nuevas instancias o ejecutar migraciones de esquemas).
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Un servidor MCP para Qdrant
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - Integración con MongoDB que permite a los LLMs interactuar directamente con bases de datos.
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - Conecta herramientas de IA directamente a Airtable. Consulta, crea, actualiza y elimina registros usando lenguaje natural. Funciones incluyen gestión de bases, operaciones de tablas, manipulación de esquemas, filtrado de registros y migración de datos a través de una interfaz MCP estandarizada.
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - El servidor MCP oficial de Redis ofrece una interfaz para gestionar y buscar datos en Redis.
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - Integración universal de bases de datos basada en SQLAlchemy compatible con PostgreSQL, MySQL, MariaDB, SQLite, Oracle, MS SQL Server y muchas otras. Incluye inspección de esquemas y relaciones, y capacidades de análisis de grandes conjuntos de datos.
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Integración con Pinecone con capacidades de búsqueda vectorial
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - Servidor MCP sin servidor para MariaDB Cloud DB. Herramientas para lanzar, eliminar, ejecutar SQL y trabajar con agentes de IA a nivel de base de datos para conversión precisa de texto a SQL y conversaciones.
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - Servidor MCP oficial de Supabase para conectar asistentes de IA directamente a tu proyecto Supabase y permitirles realizar tareas como gestionar tablas, obtener configuración y consultar datos.
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 Servidor MCP universal de bases de datos compatible con múltiples tipos incluyendo PostgreSQL, Redshift, CockroachDB, MySQL, RDS MySQL, Microsoft SQL Server, BigQuery, Oracle DB y SQLite.
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - Integración con base de datos TDolphinDB con inspección de esquemas y capacidades de consulta
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Un servidor MCP para conectar tus colecciones de Weaviate como base de conocimientos así como usar Weaviate como almacén de memoria de chat.
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — Un servidor MCP que soporta la obtención de datos desde una base de datos usando consultas en lenguaje natural, impulsado por XiyanSQL como el LLM de texto a SQL.
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Un servidor Model Context Protocol para interactuar con Google Sheets. Este servidor proporciona herramientas para crear, leer, actualizar y gestionar hojas de cálculo a través de la API de Google Sheets.
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Servidor MCP para integración con la API de Google Sheets con capacidades completas de lectura, escritura, formato y gestión de hojas.
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Servidor MCP MySQL fácil de usar, sin dependencias, construido en Golang con modo de solo lectura configurable e inspección de esquemas.
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - Servidor MCP para interactuar con bases de datos [YDB](https://ydb.tech)
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Servidor MCP para Milvus / Zilliz, permitiendo interactuar con tu base de datos.
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Un servidor MCP para conectividad genérica con Sistemas de Gestión de Bases de Datos (DBMS) vía el protocolo Java Database Connectivity (JDBC)
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - Un servidor MCP para interactuar con la base de datos VictoriaMetrics.
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Integración con datalake de series temporales Hydrolix proporcionando exploración de esquemas y capacidades de consulta para flujos de trabajo basados en LLM.
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Servidor MCP MySQL de solo lectura fácil de usar para cursor y n8n...


### 📊 <a name="data-platforms"></a>Plataformas de Datos

Plataformas de datos para integración, transformación y orquestación de flujos de datos.

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Interactúa con Flowcore para realizar acciones, ingerir datos y analizar, cruzar y utilizar cualquier dato en tus núcleos de datos o en núcleos de datos públicos; todo con lenguaje humano.
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Conéctate a la API de Databricks, permitiendo a los LLMs ejecutar consultas SQL, listar trabajos y obtener el estado de los mismos.
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Un servidor que conecta con la API Databricks Genie, permitiendo a los LLMs hacer preguntas en lenguaje natural, ejecutar consultas SQL e interactuar con agentes conversacionales de Databricks.
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Servidor MCP para Qlik Cloud API que permite consultar aplicaciones, hojas y extraer datos de visualizaciones con soporte integral de autenticación y limitación de tasa.
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - Interactúa con la plataforma de datos Keboola Connection. Este servidor proporciona herramientas para listar y acceder a datos de la API de almacenamiento de Keboola.
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - Servidor MCP oficial para [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) proporcionando integración con dbt Core/Cloud CLI, descubrimiento de metadatos de proyectos, información de modelos y capacidades de consulta sobre la capa semántica.
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - Servidor MCP para usuarios de dbt-core (OSS), ya que el MCP oficial solo soporta dbt Cloud. Soporta metadatos de proyectos, linaje a nivel de modelo y columna y documentación dbt.

### 💻 <a name="developer-tools"></a>Herramientas para Desarrolladores

Herramientas e integraciones que mejoran el flujo de trabajo de desarrollo y la gestión de entornos.

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - Identifica procesos que consumen muchos recursos en macOS y proporciona sugerencias para mejorar el rendimiento.
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - Crea componentes de UI diseñados por los mejores ingenieros de diseño de 21st.dev.
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - Integración con el sistema de gestión de pruebas [QA Sphere](https://qasphere.com/), permitiendo a los LLMs descubrir, resumir e interactuar con casos de prueba directamente desde IDEs potenciados con IA
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - Analiza tu base de código identificando archivos importantes según relaciones de dependencia. Genera diagramas y puntuaciones de importancia, ayudando a asistentes de IA a comprender el código.
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 Implementación de servidor MCP para el control del iOS Simulator.
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 Servidor MCP que soporta la consulta y gestión de todos los recursos en [Apache APISIX](https://github.com/apache/apisix).
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 -  Un servidor Model Context Protocol (MCP) que proporciona un conjunto de herramientas para recuperar información sobre proyectos SonarQube como métricas (actuales e históricas), issues y estado de salud.
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - Integra cualquier API con agentes de IA sin esfuerzo (con esquema OpenAPI)
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Analiza código React localmente, genera documentación / llm.txt para todo el proyecto de una vez
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - Servidor MCP para el controlador POX SDN que proporciona capacidades de control y gestión de red.
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - Servidor MCP oficial para CodeLogic, proporcionando acceso a análisis de dependencias de código, análisis de riesgo arquitectónico y herramientas de evaluación de impacto.
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Utiliza lenguaje natural para explorar observabilidad de LLM, trazas y datos de monitoreo capturados por Opik.
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ Permite a agentes de IA corregir fallos de build desde CircleCI.
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ Permite a agentes de IA corregir fallos de pruebas Playwright reportados a [Currents](https://currents.dev).
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - Interactúa con la [API de Postman](https://www.postman.com/postman/postman-public-workspace/)
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - Permite a asistentes de IA interactuar con tus feature flags en [Flipt](https://flipt.io).
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Proporciona a agentes de código acceso directo a datos de Figma para ayudarles en la implementación de diseño de una sola vez.
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - Integra, descubre, gestiona y codifica recursos en la nube con [Firefly](https://firefly.ai).
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - Proporciona contexto de documentación actualizado para un crate de Rust específico a LLMs vía una herramienta MCP, usando búsqueda semántica (embeddings) y resumen por LLM.
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Servidor de manipulación de Excel que proporciona creación de libros, operaciones de datos, formato y funciones avanzadas (gráficos, tablas dinámicas, fórmulas).
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - Servidor MCP que proporciona herramientas integrales para gestionar configuraciones y operaciones de la gateway [Higress](https://github.com/alibaba/higress).
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - Un servidor MCP para reemplazar clientes Rest como Postman/Insomnia, permitiendo que tu LLM mantenga y utilice colecciones de APIs.
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - Un servidor MCP para interactuar con el [Protocolo de Servidor de Lenguaje de Go (gopls)](https://github.com/golang/tools/tree/master/gopls) y beneficiarse de funciones avanzadas de análisis de código Go.
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - Un servidor MCP para interactuar con [Bruno API Client](https://www.usebruno.com/).
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - Controla dispositivos Android con IA mediante MCP, permitiendo control de dispositivos, depuración, análisis de sistema y automatización de UI con un marco de seguridad integral.
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - Controla dispositivos HarmonyOS-next con IA a través de MCP. Soporta control de dispositivos y automatización de UI.
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Integración con Gradle usando la API de Gradle Tooling para inspeccionar proyectos, ejecutar tareas y correr tests con reporte de resultados por test.
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - Servidor MCP para compresión local de varios formatos de imagen.
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Server ayuda a los clientes habilitados para MCP a navegar más fácilmente por bases de código, proporcionándoles acceso a herramientas semánticas como obtener definición, referencias, renombrar y diagnósticos.
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - Un servidor Model Context Protocol (MCP) para interactuar con simuladores de iOS. Permite obtener información sobre los simuladores, controlar interacciones de UI e inspeccionar elementos de la UI.
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - Un servidor Model Context Protocol (MCP) que permite a LLMs interactuar con simuladores de iOS (iPhone, iPad, etc.) mediante comandos en lenguaje natural.
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Un servidor Model Context Protocol (MCP) que proporciona capacidades de búsqueda y consulta impulsadas por IA para la documentación del Vercel AI SDK.
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - Servidor MCP que proporciona análisis SQL, linting y conversión de dialectos usando [SQLGlot](https://github.com/tobymao/sqlglot)
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - Un servidor MCP y extensión de VS Code que permite depuración automática (independiente del lenguaje) mediante breakpoints y evaluación de expresiones.
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - Conéctate a JetBrains IDE.
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - Servidor JMeter MCP para pruebas de rendimiento.
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - Un servidor MCP personal (Model Context Protocol) para almacenar y acceder de forma segura a claves API en proyectos usando el llavero de macOS.
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - Un servidor MCP para comunicarse con la API de App Store Connect para desarrolladores iOS.
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - Un servidor MCP para controlar simuladores de iOS.
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - Servidor Grafana k6 MCP para pruebas de rendimiento.
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - Un servidor middleware que permite que varias instancias aisladas de los mismos servidores MCP coexistan de manera independiente con espacios de nombres y configuraciones únicas.
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - Servidor MCP para acceder y gestionar prompts de aplicaciones LLM creados con [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) Prompt Management.
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Servidor MCP para automatización, desarrollo y scraping de aplicaciones y dispositivos Android/iOS. Soporta simuladores/emuladores/dispositivos físicos como iPhone, Google Pixel y Samsung.
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - Servidor Locust MCP para pruebas de rendimiento.
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - Servidor MCP simple para habilitar un flujo de trabajo human-in-the-loop en herramientas como Cline y Cursor.
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - Un servidor MCP que utiliza [gitingest](https://github.com/cyclotruc/gitingest) para convertir cualquier repositorio Git en un resumen de texto simple de su base de código.
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - permite que tu agente de IA preferido cree y ejecute pruebas end-to-end totalmente gestionadas de [Octomind](https://www.octomind.dev/) desde tu base de código u otras fuentes de datos como Jira, Slack o TestRail.
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - Acceso eficiente en tokens a especificaciones OpenAPI/Swagger vía recursos MCP.
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - Este servidor MCP proporciona una herramienta para descargar sitios web completos usando wget. Preserva la estructura del sitio y convierte enlaces para funcionar localmente.
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - Servidor MCP que proporciona información precisa sobre paquetes de NixOS, opciones de sistema, configuraciones de Home Manager y ajustes de nix-darwin para macOS para evitar alucinaciones de IA.
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - Gestión y operación de contenedores Docker a través de MCP.
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Integración con Docker para gestionar contenedores, imágenes, volúmenes y redes.
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - Integración Xcode para gestión de proyectos, operaciones de archivos y automatización de builds.
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - Servidor MCP que permite a LLMs conocer todo sobre tus especificaciones OpenAPI para descubrir, explicar y generar código/datos simulados.
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - Servidor MCP para la plataforma de gestión de incidentes [Rootly](https://rootly.com/).
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - Un servidor MCP para ayudar a los LLMs a sugerir las versiones estables más recientes de paquetes al escribir código.
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - Un servidor Model Context Protocol (MCP) que se integra con SonarQube para proporcionar a los asistentes de IA acceso a métricas de calidad de código, problemas y estados de quality gate.
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - Una implementación de las capacidades de Claude Code usando MCP, permitiendo comprensión de código por IA, modificación y análisis de proyectos con soporte integral de herramientas.
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Conecta cualquier servidor HTTP/REST API usando una especificación Open API (v3).
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - Un servidor MCP para LLDB que permite análisis binario y de archivos core, depuración y desensamblaje por IA.
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - Un servicio MCP para desplegar contenido HTML en EdgeOne Pages y obtener una URL pública accesible.
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - Un editor de archivos de texto orientado a líneas. Optimizado para herramientas LLM con acceso eficiente a partes del archivo para minimizar el uso de tokens.
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Servidor MCP para conversión fluida de formatos de documentos usando Pandoc, soportando Markdown, HTML, PDF, DOCX (.docx), csv y más.
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - Conéctate al IDE de VSCode y usa herramientas semánticas como `find_usages`.
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 Compila workspace/proyecto iOS Xcode y retroalimenta errores al llm.
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - Proyecto de implementación de un servidor MCP (Model Context Protocol) basado en JVM.
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - Servidor MCP que se conecta a [Apache Airflow](https://airflow.apache.org/) usando el cliente oficial.
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - Un servidor Model Context Protocol (MCP) para generar un mapa mental interactivo y atractivo.
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - Un servidor Model Context Protocol (MCP) que consulta múltiples modelos Ollama y combina sus respuestas, proporcionando perspectivas de IA diversas sobre una sola pregunta.
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - Servidor MCP que proporciona información de API de Typescript de forma eficiente al agente para que pueda trabajar con APIs no entrenadas.
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - Un servidor MCP para obtener de forma flexible datos JSON, texto y HTML.
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - Un servidor MCP para conectar con tus pipelines de ZenML [ZenML](https://www.zenml.io) MLOps y LLMOps.
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) es un servidor MCP remoto genérico para conectar con CUALQUIER repositorio o proyecto [GitHub](https://www.github.com) para documentación.
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - Un servidor MCP para interactuar con [Bugsnag](https://www.bugsnag.com/)
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - Un servidor MCP para archivos CSV.
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Un sistema de gestión de tareas enfocado en programación que potencia agentes de codificación como Cursor AI con memoria de tareas avanzada, auto-reflexión y gestión de dependencias. [ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Un servidor MCP para ejecutar código localmente vía Docker y soportar múltiples lenguajes de programación.
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - Consulta información de paquetes Go en pkg.go.dev
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - Una librería Go de cero configuración para exponer automáticamente APIs existentes del framework web Gin como herramientas MCP.
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP permite a tus asistentes de IA navegar por repositorios de GitHub, explorar directorios y ver el contenido de archivos.
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – Un servidor basado en FastMCP para interactuar con webhook-test.com. Permite a los usuarios crear, recuperar y eliminar webhooks localmente usando Claude.
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - El servidor ROS MCP soporta el control de robots convirtiendo comandos en lenguaje natural emitidos por el usuario en comandos de control ROS o ROS2.
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - El servidor Globalping MCP proporciona a usuarios y LLMs acceso para ejecutar herramientas de red como ping, traceroute, mtr, HTTP y resolución DNS desde miles de ubicaciones en todo el mundo.
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - Un servidor MCP para interactuar con PostHog analytics, flags de características, seguimiento de errores y más.
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - Servidor MCP para buscar y obtener información actualizada sobre paquetes NPM, Cargo, PyPi y NuGet.

### 🔒 <a name="delivery"></a>Entrega

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash Delivery (No oficial)

### 🧮 <a name="data-science-tools"></a>Herramientas de Ciencia de Datos

Integraciones y herramientas diseñadas para simplificar la exploración, el análisis de datos y mejorar los flujos de trabajo de ciencia de datos.

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Predice cualquier cosa con agentes de predicción y forecasting de Chronulus AI.
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - Permite la exploración autónoma de datos en conjuntos de datos basados en .csv, proporcionando información inteligente con mínimo esfuerzo.
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - Un servidor MCP para convertir casi cualquier archivo o contenido web en Markdown.
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Servidor Model Context Protocol (MCP) para Jupyter.
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Conecta Jupyter Notebook con Claude AI, permitiendo que Claude interactúe y controle cuadernos Jupyter directamente.
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Conexión a Kaggle, posibilidad de descargar y analizar conjuntos de datos.
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - Enlaza múltiples fuentes de datos (SQL, CSV, Parquet, etc.) y permite que la IA analice los datos para obtener información y visualizaciones.
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - Herramientas y plantillas para crear gráficos y dashboards de datos validados y mantenibles.
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — Herramientas para crear e interactuar con flags de características y experimentos de GrowthBook.

### 📟 <a name="embedded-system"></a>Sistema Embebido

Proporciona acceso a documentación y atajos para trabajar en dispositivos embebidos.

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - Flujo de trabajo para arreglar problemas de compilación en chips de la serie ESP32 usando ESP-IDF.
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - Un servidor MCP que estandariza y contextualiza datos industriales Modbus.
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - Un servidor MCP que se conecta a sistemas industriales con soporte OPC UA.
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - Un servidor MCP para GNU Radio que permite a LLMs crear y modificar de forma autónoma diagramas de flujo RF `.grc`.

### 📂 <a name="file-systems"></a>Sistemas de Archivos

Proporciona acceso directo a sistemas de archivos locales con permisos configurables. Permite a los modelos de IA leer, escribir y gestionar archivos dentro de directorios especificados.

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - Comparte contexto de código con LLMs vía MCP o portapapeles.
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - Herramienta para fusionar archivos, adecuada para los límites de longitud de chat de IA.
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Un sistema de archivos que permite navegar y editar archivos implementado en Java usando Quarkus. Disponible como jar o imagen nativa.
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Integración con Box para listar, leer y buscar archivos.
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Búsqueda rápida de archivos en Windows usando Everything SDK.
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - Implementación en Golang para acceso al sistema de archivos local.
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - Acceso a almacenamiento remoto: SFTP, S3, FTP, SMB, NFS, WebDAV, GIT, FTPS, gcloud, azure blob, sharepoint, etc.
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - Acceso MCP a MarkItDown: una librería que convierte muchos formatos de archivo (locales o remotos) a Markdown para consumo por LLMs.
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - Acceso directo al sistema de archivos local.
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Integración con Google Drive para listar, leer y buscar archivos.
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Acceso a cualquier almacenamiento usando Apache OpenDAL™.
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - Controla tu configuración de Homebrew en macOS usando lenguaje natural a través de este servidor MCP. Gestiona fácilmente tus paquetes, pide sugerencias, soluciona problemas de brew, etc.

### 💰 <a name="finance--fintech"></a>Finanzas & Fintech

Herramientas para acceso y análisis de datos financieros. Permite a modelos de IA trabajar con datos de mercado, plataformas de trading e información financiera.

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - Investigación profunda de cripto - gratis y completamente local.
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - Permite a agentes de IA interactuar con las APIs blockchain de Alchemy.
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Agentes Octagon AI para integrar datos de mercado privados y públicos.
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Integración con API de Coinmarket para obtener listados y cotizaciones de criptomonedas.
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - Permite a LLMs ejecutar operaciones usando la plataforma MetaTrader 5.
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP para interactuar con múltiples blockchains, staking, DeFi, swaps, puentes, gestión de billeteras, DCA, órdenes límite, búsqueda de monedas, seguimiento y más.
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - API Onchain de Bankless para interactuar con smart contracts, consultar información de transacciones y tokens.
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Integración con Base Network para herramientas onchain, permitiendo interacción con Base Network y la API de Coinbase para gestión de billeteras, transferencias de fondos, smart contracts y operaciones DeFi.
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Integración con Alpha Vantage API para obtener información sobre acciones y cripto.
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - Puntaje de riesgo / tenencias de activos de direcciones blockchain EVM (EOA, CA, ENS) e incluso nombres de dominio.
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Integración con Bitte Protocol para ejecutar agentes de IA en varias blockchains.
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - Servidor MCP que conecta agentes de IA a la [plataforma Chargebee](https://www.chargebee.com/).
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - Integración con [Codex API](https://www.codex.io) para datos blockchain y de mercado enriquecidos en tiempo real en 60+ redes.
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - El servidor MCP de DexPaprika de Coinpaprika expone la [API DexPaprika](https://docs.dexpaprika.com) de alto rendimiento cubriendo 20+ cadenas y 5M+ tokens con precios en tiempo real, datos de pools de liquidez e históricos OHLCV, proporcionando acceso estandarizado a datos de mercado a través de Model Context Protocol.
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - Servidor MCP para acceder a datos de mercado cripto en tiempo real y trading vía 20+ exchanges usando la librería CCXT. Soporta spot, futuros, OHLCV, balances, órdenes y más.
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Integración con Yahoo Finance para obtener datos bursátiles incluyendo recomendaciones de opciones.
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Integración con Tastyworks API para gestionar operaciones en Tastytrade.
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Integración con Reddit para analizar el contenido de la comunidad WallStreetBets.
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Integración con billetera Bitcoin Lightning impulsada por Nostr Wallet Connect.
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Acceso a agentes web3 de IA especializados para análisis blockchain, auditoría de seguridad de smart contracts, evaluación de métricas de tokens e interacciones on-chain a través de Heurist Mesh. Proporciona herramientas para análisis DeFi, valoración de NFTs y monitoreo de transacciones en múltiples blockchains.
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper proporciona transacciones en BSC, incluyendo transferencias de saldo/tokens, swaps en Pancakeswap y reclamos de recompensas beeper.
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - Servidor MCP que entrega noticias blockchain y artículos de BlockBeats para agentes de IA.
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - Entrega tasas de puente cross-chain en tiempo real y rutas óptimas de transferencia a agentes de IA onchain.
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ - Provee acceso en tiempo real a los feeds de precios descentralizados de Chainlink.
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ - Provee acceso en tiempo real a las últimas noticias de Cointelegraph.
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ - Provee datos en tiempo real e históricos del Crypto Fear & Greed Index.
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - Servidor MCP que proporciona una gama de indicadores y estrategias de análisis técnico de criptomonedas.
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - Servidor MCP que provee noticias cripto en tiempo real de NewsData para agentes de IA.
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - Servidor MCP para el seguimiento y gestión de asignaciones de portafolio cripto.
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - Servidor MCP que agrega noticias cripto en tiempo real de múltiples feeds RSS.
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - Servidor MCP que entrega análisis de sentimiento cripto a agentes de IA.
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - Seguimiento de los últimos tokens en tendencia en CoinGecko.
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - Base de conocimiento estructurada de whitepapers cripto.
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - Provee las últimas noticias cripto a agentes de IA, impulsado por CryptoPanic.
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - Servidor MCP para que agentes de IA exploren oportunidades de yield en DeFi.
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ - Servidor MCP que conecta datos de Dune Analytics a agentes de IA.
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ - Entrega datos de flujos de ETF cripto para mejorar la toma de decisiones de IA.
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Servidor MCP que se integra con el bot de trading cripto Freqtrade.
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - Provee tasas de fondeo en tiempo real a través de los principales exchanges cripto.
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Servidor MCP para ejecutar swaps de tokens en Solana usando la nueva Ultra API de Jupiter.
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ - Servidor MCP que rastrea pools creados recientemente en Pancake Swap.
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Servidor MCP que detecta posibles riesgos en tokens meme de Solana.
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ - Servidor MCP que provee a agentes de IA datos blockchain indexados de The Graph.
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ - Servidor MCP que provee herramientas para que agentes de IA minteen tokens ERC-20 en varias blockchains.
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - Servidor MCP para revisar y revocar permisos de tokens ERC-20 en varias blockchains.
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Servidor MCP que rastrea cambios históricos de nombres de usuario de Twitter.
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ - Servidor MCP que rastrea nuevos pools de liquidez en Uniswap a través de varias blockchains.
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ - Servidor MCP para que agentes de IA automaticen swaps de tokens en Uniswap DEX en múltiples blockchains.
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ - Servidor MCP para rastrear transacciones de "ballenas" cripto.
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Servidor MCP para la API de trading de Alpaca para gestionar portafolios de acciones y cripto, realizar operaciones y acceder a datos de mercado.
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI provee datos bursátiles en tiempo real, análisis y capacidades de trading a través de MCP.
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - Servicios blockchain integrales para 30+ redes EVM, soportando tokens nativos, ERC20, NFTs, smart contracts, transacciones y resolución ENS.
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Integración integral de Starknet con soporte para tokens nativos (ETH, STRK), smart contracts, resolución StarknetID y transferencias de tokens.
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 - Integración con ledger-cli para gestionar transacciones financieras y generar reportes.
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 - Integración bancaria core para gestionar clientes, préstamos, ahorros, acciones, transacciones financieras y generar reportes financieros.
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - Servidor MCP que usa yfinance para obtener información de Yahoo Finance.
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ - Servidor MCP que provee acceso a las APIs de datos de mercado financiero de [Polygon.io](https://polygon.io/) para acciones, índices, forex, opciones y más.
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ - API de Bitget para obtener precios de criptomonedas.
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - Integración de datos de mercado cripto en tiempo real usando la API pública de CoinCap, proporcionando acceso a precios cripto e información de mercado sin llaves API.
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Herramienta MCP que provee datos de mercado cripto usando la API de CoinGecko.
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Versión TS del mcp de Yahoo Finance.
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Herramienta MCP que provee datos bursátiles y análisis usando la API de Yahoo Finance.
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - Servidor MCP para XRP Ledger que brinda acceso a información de cuentas, historial de transacciones y datos de red. Permite consultar objetos del ledger, enviar transacciones y monitorear la red XRPL.
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - Precios de mercado on-chain en tiempo real usando la API gratuita de Dexscreener.
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - Servidor MCP basado en baostock, proveyendo acceso y análisis de datos del mercado bursátil chino.
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Herramienta MCP para consultar transacciones de Solana usando lenguaje natural con la API de Solscan.
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - Servidor MCP que interactúa con las capacidades de la plataforma CRIC Wuye AI, un asistente inteligente específicamente para la industria de gestión de propiedades.
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Servidor MCP para acceder a datos financieros profesionales, soportando múltiples proveedores como Tushare.

### 🎮 <a name="gaming"></a>Juegos

Integración con datos relacionados a juegos, motores de juego y servicios.

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Servidor MCP para Unity Editor y para juegos hechos con Unity.
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Servidor MCP para integración con el motor de juegos Unity3d para desarrollo de juegos.
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Servidor MCP para interactuar con el motor de juegos Godot, proporcionando herramientas para editar, ejecutar, depurar y gestionar escenas en proyectos Godot.
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Accede a datos de jugadores de Chess.com, registros de partidas y otra información pública a través de interfaces MCP estandarizadas, permitiendo que asistentes IA busquen y analicen información de ajedrez.
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - Servidor MCP que juega al ajedrez contra LLMs.
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Servidor MCP para datos y herramientas de análisis en tiempo real de Fantasy Premier League.
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - Acceso a datos de juegos en tiempo real para títulos populares como League of Legends, TFT y Valorant, ofreciendo analíticas de campeones, calendarios de esports, composiciones meta y estadísticas de personajes.
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - Servidor MCP con herramientas para interactuar con datos de RuneScape (RS) y Old School RuneScape (OSRS), incluyendo precios de ítems, hiscores de jugadores y más.

### 🧠 <a name="knowledge--memory"></a>Conocimiento & Memoria

Almacenamiento persistente de memoria utilizando estructuras de grafos de conocimiento. Permite a los modelos de IA mantener y consultar información estructurada entre sesiones.
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - Memoria mejorada basada en grafos con enfoque en rol-play de IA y generación de historias
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Ingiera cualquier cosa desde Slack, Discord, sitios web, Google Drive, Linear o GitHub en un proyecto de Graphlit, y luego busque y recupere conocimiento relevante dentro de un cliente MCP como Cursor, Windsurf o Cline.
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - Una implementación de servidor MCP que provee herramientas para recuperar y procesar documentación mediante búsqueda vectorial, permitiendo que los asistentes de IA aumenten sus respuestas con contexto documental relevante.
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - Un servidor MCP construido sobre [markmap](https://github.com/markmap/markmap) que convierte **Markdown** en **mapas mentales** interactivos. Soporta exportaciones multi-formato (PNG/JPG/SVG), vista previa en navegador en vivo, copia de Markdown con un clic y funciones dinámicas de visualización.
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - Un conector para que los LLM trabajen con colecciones y fuentes en tu Zotero Cloud
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - Servidor MCP de Resumen por IA, Soporte para múltiples tipos de contenido: texto plano, páginas web, documentos PDF, libros EPUB, contenido HTML
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Un servidor Model Context Protocol para Mem0 que ayuda a gestionar preferencias y patrones de codificación, proporcionando herramientas para almacenar, recuperar y manejar semánticamente implementaciones de código, mejores prácticas y documentación técnica en IDEs como Cursor y Windsurf
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - Sistema de memoria persistente basado en grafo de conocimiento para mantener el contexto
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Se conecta a tu Pinecone Assistant y proporciona al agente contexto desde su motor de conocimiento.
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - Recupera contexto de tu base de conocimiento [Ragie](https://www.ragie.ai) (RAG) conectada a integraciones como Google Drive, Notion, JIRA y más.
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Permite que herramientas de IA como Cursor, VS Code o Claude Desktop respondan preguntas usando la documentación de tu producto. Biel.ai provee el sistema RAG y el servidor MCP.
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - Gestor de memoria para aplicaciones y agentes IA usando varias tiendas de grafos y vectores, permitiendo ingestión desde más de 30 fuentes de datos
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Guarda y consulta la memoria de tu agente de manera distribuida con Membase
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - Usa GitHub Gists para gestionar y acceder a tu conocimiento personal, notas diarias y prompts reutilizables. Funciona como complemento de https://gistpad.dev y la [extensión de GistPad para VS Code](https://aka.ms/gistpad).
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Un servidor Model Context Protocol (MCP) que implementa la metodología de gestión de conocimiento Zettelkasten, permitiéndote crear, enlazar y buscar notas atómicas a través de Claude y otros clientes compatibles con MCP.

### 🗺️ <a name="location-services"></a>Servicios de Localización

Servicios basados en ubicación y herramientas de mapeo. Permite a los modelos de IA trabajar con datos geográficos, información meteorológica y analíticas basadas en ubicación.

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - Geolocalización de direcciones IP e información de red usando la API de IPInfo
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - Accede a datos meteorológicos en tiempo real para cualquier ubicación usando la API de WeatherAPI.com, proporcionando pronósticos detallados y condiciones actuales.
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - Un servidor MCP de OpenStreetMap con servicios basados en ubicación y datos geoespaciales.
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - Un servidor MCP para búsquedas de lugares cercanos con detección de ubicación basada en IP.
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Integración de Google Maps para servicios de localización, rutas y detalles de lugares
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - conecta QGIS Desktop con Claude AI a través de MCP. Esta integración permite la creación asistida de proyectos por prompts, carga de capas, ejecución de código y más.
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - Una herramienta MCP que provee datos meteorológicos en tiempo real, pronósticos y datos históricos usando la API de OpenWeatherMap.
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - Servidor MCP de pronóstico semanal que devuelve 7 días completos de pronósticos detallados en cualquier parte del mundo.
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - Accede a la hora en cualquier zona horaria y obtén la hora local actual
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - Pronósticos meteorológicos precisos vía la API de AccuWeather (hay nivel gratuito).
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - Servidor MCP de geocodificación para nominatim, ArcGIS, Bing
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - Servicio de localización de direcciones IP usando la API de [IP Find](https://ipfind.com)
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – Implementación de servidor Model Context Protocol (MCP) que conecta LLMs con la API REST de GeoServer, permitiendo a asistentes de IA interactuar con datos y servicios geoespaciales.
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Servidor MCP para Aiwen IP Location, obtiene la ubicación de red IP del usuario, detalles de la IP (país, provincia, ciudad, latitud, longitud, ISP, propietario, etc.)

### 🎯 <a name="marketing"></a>Marketing

Herramientas para crear y editar contenido de marketing, trabajar con metadatos web, posicionamiento de producto y guías de edición.

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Servidor MCP que actúa como interfaz para Facebook Ads, permitiendo acceso programático a datos y funciones de gestión de anuncios.
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Un conjunto de herramientas de marketing de Open Strategy Partners incluyendo estilo de redacción, códigos de edición y creación de mapas de valor de marketing de productos.
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - Permite a los agentes de IA monitorear y optimizar el rendimiento de anuncios de Meta, analizar métricas de campañas, ajustar la segmentación de audiencia, gestionar activos creativos y hacer recomendaciones basadas en datos para el gasto y configuración de campañas mediante integración fluida con Graph API.
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Permite que las herramientas interactúen con Amazon Advertising, analizando métricas y configuraciones de campañas.

### 📊 <a name="monitoring"></a>Monitorización

Accede y analiza datos de monitorización de aplicaciones. Permite a los modelos de IA revisar reportes de errores y métricas de rendimiento.

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - Descubrimiento, exploración, informes y análisis de causa raíz usando todos los datos de observabilidad, incluyendo métricas, logs, sistemas, contenedores, procesos y conexiones de red
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Busca dashboards, investiga incidentes y consulta fuentes de datos en tu instancia de Grafana
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Un servidor MCP que permite consultar logs de Loki a través de la API de Grafana.
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - Mejora la calidad del código generado por IA mediante análisis inteligente basado en prompts en 10 dimensiones críticas, desde complejidad hasta vulnerabilidades de seguridad
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - Lleva sin problemas el contexto de producción en tiempo real—logs, métricas y trazas—a tu entorno local para corregir código más rápido automáticamente
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Consulta e interactúa con entornos Kubernetes monitorizados por Metoro
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Integración con Raygun API V3 para reporte de errores y monitorización de usuarios reales
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Integración con Sentry.io para seguimiento de errores y monitorización de rendimiento
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Proporciona acceso a trazas y métricas OpenTelemetry mediante Logfire
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Herramienta de monitorización de sistema que expone métricas del sistema vía Model Context Protocol (MCP). Permite a los LLM recuperar información del sistema en tiempo real a través de una interfaz compatible con MCP. (soporta CPU, Memoria, Disco, Red, Host, Proceso)
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - Proporciona integración completa con tus [APIs de instancia VictoriaMetrics](https://docs.victoriametrics.com/victoriametrics/url-examples/) y [documentación](https://docs.victoriametrics.com/) para tareas de monitorización, observabilidad y depuración relacionadas con tus instancias VictoriaMetrics

### 🎥 <a name="multimedia-process"></a>Procesamiento Multimedia

Proporciona la capacidad de manejar multimedia, como edición de audio y video, reproducción, conversión de formatos, también incluye filtros de video, mejoras, y más.

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - Usando la línea de comandos de ffmpeg para lograr un servidor mcp, puede ser muy conveniente, a través del diálogo permite búsqueda local de videos, recorte, unión, reproducción y otras funciones.
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - Un servidor MCP que permite examinar metadatos de imágenes como EXIF, XMP, JFIF y GPS. Proporciona una base para búsqueda y análisis impulsados por LLM de bibliotecas de fotos y colecciones de imágenes.
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - Herramientas de reconocimiento y edición de imágenes basadas en ComputerVision 🪄 para asistentes de IA.

### 🔎 <a name="search"></a>Búsqueda y Extracción de Datos

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - Este repositorio implementa un servidor MCP (Model Context Protocol) para búsqueda en YouTube y recuperación de transcripciones. Permite que modelos de lenguaje u otros agentes consulten fácilmente contenido de YouTube mediante un protocolo estandarizado.
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Un servidor MCP que permite a asistentes de IA usar la API de Wolfram Alpha para acceder en tiempo real a conocimiento computacional y datos.
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - El servicio Scrapeless Model Context Protocol actúa como conector MCP a la API de Google SERP, permitiendo búsqueda web dentro del ecosistema MCP sin salir de él.
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - Un servidor MCP para buscar ofertas de empleo con filtros por fecha, palabras clave, opciones de trabajo remoto, y más.
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Integración con la API de búsqueda Kagi
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCP para que LLM busque y lea artículos en arXiv
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ MCP para buscar en la API de PapersWithCode
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCP para buscar y leer artículos médicos/ciencias de la vida de PubMed.
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - Busca artículos usando la API de NYTimes
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Un servidor MCP para el Actor RAG Web Browser de código abierto de Apify, para realizar búsquedas web, scrapear URLs y devolver contenido en Markdown.
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Servidor MCP de Clojars para información actualizada de dependencias de bibliotecas Clojure
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - Búsqueda de artículos de investigación en ArXiv
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - Descubre, extrae e interactúa con la web: una interfaz que habilita el acceso automatizado a través de toda la internet pública.
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Integración con Google News con categorización automática de temas, soporte multi-idioma y capacidades de búsqueda integral, incluyendo titulares, historias y temas relacionados mediante [SerpAPI](https://serpapi.com/).
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Este es un servidor MCP basado en Python que proporciona la herramienta incorporada de OpenAI `web_search`.
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - Servidor MCP para la plataforma DealX
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - Rastréa, embebe, fragmenta, busca y recupera información de datasets a través de [Trieve](https://trieve.ai)
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - Accede a datos, APIs de web scraping y conversión de documentos de [Dumpling AI](https://www.dumplingai.com/)
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Un servidor MCP para buscar en Hacker News, obtener las mejores historias y más.
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Un servidor Model Context Protocol (MCP) permite que asistentes de IA como Claude usen la API de Exa AI Search para búsquedas web. Esta configuración permite que los modelos de IA obtengan información web en tiempo real de forma segura y controlada.
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - Busca vía search1api (requiere clave API de pago)
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - Servidor de investigación biomédica que provee acceso a PubMed, ClinicalTrials.gov y MyVariant.info.
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Un servidor MCP para búsqueda de imágenes en Unsplash.
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - Servidor Model Context Protocol para [SearXNG](https://docs.searxng.org)
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Servidor MCP para integración con Naver Search API, soportando búsqueda en blogs, noticias, compras y funciones de análisis de DataLab.
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Servidor MCP para obtener contenido de páginas web usando el navegador headless Playwright, soporta renderizado Javascript y extracción inteligente de contenido, salida en formato Markdown o HTML.
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Un potente servidor MCP para búsqueda en Google que permite búsquedas paralelas con múltiples palabras clave simultáneamente.
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - Un servidor MCP para tomar capturas de pantalla de páginas web para usarlas como retroalimentación durante el desarrollo de UI.
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Capacidades de búsqueda web usando la API de Microsoft Bing Search
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – Servidor MCP oficial de Kagi Search
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – API de búsqueda de Tavily AI
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - Capacidades de búsqueda web, imágenes, noticias, videos y puntos de interés locales utilizando la API de Brave Search
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - Reproduce expresiones musicales de [Melrōse](https://melrōse.org) como MIDI
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - Capacidades de búsqueda web utilizando la API de Brave Search
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - Obtención y procesamiento eficiente de contenido web para consumo por IA
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Buscar en Google y realizar investigación profunda en la web sobre cualquier tema
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - Búsqueda web usando DuckDuckGo
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - Acceso a información del Parlamento Holandés (Tweede Kamer) incluyendo documentos, debates, actividades y casos legislativos mediante capacidades de búsqueda estructurada (basado en el proyecto opentk de Bert Hubert)
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - Servidor MCP que ofrece investigación profunda autónoma tipo OpenAI/Perplexity, elaboración de consultas estructuradas e informes concisos.
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - Un servidor MCP para conectar con instancias de searXNG
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - Obtén el código fuente LaTeX de artículos de arXiv para manejar contenido y ecuaciones matemáticas
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - Un servidor MCP que recupera y procesa datos de noticias del sitio GeekNews.
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - Servidor MCP que proporciona las capacidades de extracción de datos de [AgentQL](https://agentql.com).
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – API de búsqueda de Tavily AI
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - Servidor MCP de [Vectorize](https://vectorize.io) para recuperación avanzada, investigación profunda privada, extracción de archivos Anything-to-Markdown y fragmentación de texto.
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - Interactúa con [WebScraping.ai](https://webscraping.ai) para extracción y scraping de datos web.
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - Servidor MCP basado en TypeScript que proporciona funcionalidad de búsqueda DuckDuckGo.
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - Consulta de información de activos de red mediante el servidor ZoomEye MCP
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Servidor MCP que busca el estado de Baseline usando la API Web Platform
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - Servidor MCP para interactuar con la API de BioThings, incluyendo genes, variantes genéticas, medicamentos e información taxonómica
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - Un servidor MCP para buscar y descargar fotografías libres de derechos de Pexels y Unsplash. Incluye búsqueda en múltiples proveedores, metadatos enriquecidos, paginación y rendimiento asíncrono para que asistentes de IA encuentren y accedan a imágenes de alta calidad.

### 🔒 <a name="security"></a>Seguridad

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Un servidor Model Context Protocol para Ghidra que permite a los LLMs realizar ingeniería inversa de aplicaciones de forma autónoma. Proporciona herramientas para descompilar binarios, renombrar métodos y datos, y listar métodos, clases, importaciones y exportaciones.
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Un servidor MCP que permite la recuperación segura de credenciales desde 1Password para ser utilizadas por IA Agente.
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – Un servidor MCP (Model Context Protocol) seguro que permite a los agentes de IA interactuar con la aplicación Authenticator.
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - Servidor MCP para integrar Ghidra con asistentes de IA. Este plugin permite análisis de binarios, proporcionando herramientas para inspección de funciones, descompilación, exploración de memoria y análisis de importación/exportación vía Model Context Protocol.
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Servidor MCP para analizar resultados de ROADrecon de enumeración de tenants de Azure
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - Servidor MCP para dnstwist, una potente herramienta de fuzzing DNS que ayuda a detectar typosquatting, phishing y espionaje corporativo.
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - Servidor MCP para maigret, una potente herramienta OSINT que recolecta información de cuentas de usuario de varias fuentes públicas. Este servidor proporciona herramientas para buscar nombres de usuario en redes sociales y analizar URLs.
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Servidor MCP para consultar la API de Shodan y Shodan CVEDB. Este servidor proporciona herramientas para búsquedas de IPs, dispositivos, DNS, vulnerabilidades, búsquedas CPE y más.
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - Servidor MCP para consultar la API de VirusTotal. Este servidor proporciona herramientas para escanear URLs, analizar hashes de archivos y obtener informes de direcciones IP.
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Un plugin para Binary Ninja, servidor MCP y puente que integra [Binary Ninja](https://binary.ninja) con tu cliente MCP favorito. Permite automatizar el análisis de binarios e ingeniería inversa.
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - Servidor MCP para consultar la API de ORKL. Proporciona herramientas para obtener informes de amenazas, analizar actores de amenazas y obtener fuentes de inteligencia.
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Servidor MCP en Rust para integrar Cortex, permitiendo el análisis de observables y respuestas de seguridad automatizadas mediante IA.
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - Servidor MCP en Rust para integrar TheHive, facilitando la respuesta colaborativa a incidentes de seguridad y la gestión de casos mediante IA.
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Servidor MCP en Rust que conecta Wazuh SIEM con asistentes de IA, proporcionando alertas de seguridad en tiempo real y datos de eventos para mejor comprensión contextual.
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - Servidor MCP para acceder a [Intruder](https://www.intruder.io/), ayudando a identificar, comprender y corregir vulnerabilidades de seguridad en tu infraestructura.
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - Servidor Model Context Protocol (MCP) diseñado para conectar con un programa de grabación CCTV (VMS) y recuperar flujos de video grabados y en vivo. También proporciona herramientas para controlar el software VMS, como mostrar diálogos en vivo o de reproducción para canales específicos en tiempos concretos.
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ Un potente servidor MCP (Model Context Protocol) que audita dependencias de paquetes npm para vulnerabilidades de seguridad. Construido con integración al registro npm remoto para chequeos de seguridad en tiempo real.
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ Permite a los agentes de IA escanear código en busca de vulnerabilidades de seguridad usando [Semgrep](https://semgrep.dev).
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - Servidor MCP para interactuar con la API de CyberChef, permitiendo a un cliente MCP utilizar las operaciones de CyberChef.
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - Servidor MCP para IDA Pro, que permite realizar análisis de binarios con asistentes de IA. Este plugin implementa descompilación, desensamblado y permite generar informes de análisis de malware automáticamente.
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - Servidor MCP para RAD Security, proporcionando insights de seguridad potenciados por IA para entornos Kubernetes y cloud. Proporciona herramientas para consultar la API de Rad Security y obtener hallazgos, informes, datos de ejecución y mucho más.
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - Caja de herramientas de pruebas de seguridad todo en uno que reúne herramientas open source populares en una sola interfaz MCP. Conectado a un agente de IA, permite tareas como pentesting, bug bounty, threat hunting y más.
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - Servidor Model Context Protocol (MCP) para consultar la API de CVE-Search. Proporciona acceso completo a CVE-Search, explorar proveedores y productos, obtener CVEs por ID y los últimos CVEs actualizados.
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - Acceso a la base de datos OSV (Open Source Vulnerabilities) para información de vulnerabilidades. Consulta vulnerabilidades por versión de paquete o commit, consulta múltiple de paquetes, y obtén información detallada de vulnerabilidades por ID.
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - Interfaz conversacional de reconocimiento y servidor MCP impulsado por httpx y asnmap. Soporta varios niveles de reconocimiento para análisis de dominios, inspección de cabeceras de seguridad, análisis de certificados y búsqueda ASN.
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Servidor MCP para Volatility 3.x, permitiendo realizar análisis forense de memoria con un asistente de IA. Experimenta análisis forense de memoria sin barreras, ya que plugins como pslist y netscan son accesibles vía REST APIs limpias y LLMs.
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Un servidor MCP ejecutándose en un entorno de ejecución confiable (TEE) vía Gramine, demostrando atestación remota usando [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html). Permite que un cliente MCP verifique el servidor antes de conectarse.
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP es un plugin y servidor MCP para el descompilador JADX que se integra directamente con Model Context Protocol (MCP) para ofrecer soporte de ingeniería inversa en vivo con LLMs como Claude.
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP Server es un servidor MCP para Apk Tool que automatiza la ingeniería inversa de APKs de Android.

### 🌐 <a name="social-media"></a>Redes Sociales

Integración con plataformas de redes sociales para permitir publicaciones, analíticas y gestión de interacciones. Permite la automatización impulsada por IA para la presencia social.

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ Acceso a datos en tiempo real de X/Reddit/YouTube directamente en tus aplicaciones LLM con frases de búsqueda, usuarios y filtrado por fecha.
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - Solución integral de gestión de Twitter que proporciona acceso a la línea de tiempo, recuperación de tweets de usuario, monitoreo de hashtags, análisis de conversaciones, mensajes directos, análisis de sentimiento de publicaciones y control completo del ciclo de vida de las publicaciones, todo mediante una API simplificada.
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Se integra con páginas de Facebook para permitir la gestión directa de publicaciones, comentarios y métricas de participación a través de la API Graph para una gestión eficiente de redes sociales.
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - Un servidor MCP para interactuar con Bluesky mediante el cliente atproto.


### 🏃 <a name="sports"></a>Deportes

Herramientas para acceder a datos, resultados y estadísticas deportivas.

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - Servidor MCP que integra la API balldontlie para proporcionar información sobre jugadores, equipos y partidos de la NBA, NFL y MLB
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - Acceso a datos de carreras de ciclismo, resultados y estadísticas mediante lenguaje natural. Incluye recuperación de listas de salida, resultados de carreras e información de ciclistas de firstcycling.com.
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Servidor Model Context Protocol (MCP) que conecta con la API de Strava, proporcionando herramientas para acceder a datos de Strava desde LLMs
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Servidor MCP que se integra con la API Squiggle para proveer información sobre equipos, posiciones, resultados, predicciones y rankings de poder de la Australian Football League.
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - Servidor MCP que actúa como proxy para la API gratuita de MLB, la cual proporciona información de jugadores, estadísticas y detalles de partidos.

### 🎧 <a name="support-and-service-management"></a>Soporte y Gestión de Servicios

Herramientas para gestionar soporte al cliente, gestión de servicios IT y operaciones de helpdesk.

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Servidor MCP que se integra con Freshdesk, permitiendo que los modelos de IA interactúen con los módulos de Freshdesk y realicen diversas operaciones de soporte.
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Conector MCP en Go para Jira que permite a asistentes de IA como Claude interactuar con Atlassian Jira. Ofrece una interfaz fluida para que los modelos de IA realicen operaciones comunes de Jira incluyendo gestión de incidencias, planificación de sprints y transiciones de flujo de trabajo.
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Servidor MCP para productos Atlassian (Confluence y Jira). Soporta Confluence Cloud, Jira Cloud y Jira Server/Data Center. Proporciona herramientas completas para buscar, leer, crear y gestionar contenido en los espacios de trabajo de Atlassian.

### 🌎 <a name="translation-services"></a>Servicios de Traducción

Herramientas y servicios de traducción para que los asistentes de IA traduzcan contenido entre diferentes idiomas.

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Servidor MCP para la API Lara Translate, permitiendo potentes capacidades de traducción con soporte para detección de idioma y traducciones contextuales.
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Servidor Model Context Protocol completo para la gestión de traducciones en Weblate, permitiendo a asistentes de IA realizar tareas de traducción, gestión de proyectos y descubrimiento de contenido con transformaciones de formato inteligentes.

### 🎧 <a name="text-to-speech"></a>Texto a Voz

Herramientas para convertir texto en voz y viceversa

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Servidor MCP que usa los modelos open weight Kokoro TTS para convertir texto a voz. Puede convertir texto a MP3 en un disco local o subir automáticamente a un bucket S3.
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - Servidor completo de interacción por voz que soporta reconocimiento de voz, texto a voz y conversaciones en tiempo real a través de micrófono local, APIs compatibles con OpenAI e integración con LiveKit

### 🚆 <a name="travel-and-transportation"></a>Viajes y Transporte

Acceso a información de viajes y transporte. Permite consultar horarios, rutas y datos de viaje en tiempo real.
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Proporciona herramientas para buscar en Airbnb y obtener detalles de los anuncios.
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - Integración con la API del Servicio de Parques Nacionales que proporciona la información más reciente sobre detalles de parques, alertas, centros de visitantes, campamentos y eventos de los Parques Nacionales de EE. UU.
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - Accede a la información de viajes, horarios y actualizaciones en tiempo real de los Ferrocarriles Holandeses (NS)
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - Un servidor MCP que permite a los LLMs interactuar con la API de Tripadvisor, admitiendo datos de ubicación, reseñas y fotos a través de interfaces MCP estandarizadas.
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - Un servidor MCP para el servicio de trenes de UK National Rail, que proporciona horarios de trenes e información de viaje en vivo, integrando la API de Realtime Trains.

### 🔄 <a name="version-control"></a>Control de Versiones

Interactúa con repositorios Git y plataformas de control de versiones. Permite la gestión de repositorios, análisis de código, manejo de pull requests, seguimiento de incidencias y otras operaciones de control de versiones a través de APIs estandarizadas.

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - Lee y analiza repositorios de GitHub con tu LLM
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - Servidor MCP para integración con la API de GitHub Enterprise
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - Interactúa con instancias de Gitea mediante MCP.
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - Servidor oficial de GitHub para integración con gestión de repositorios, PRs, incidencias y más.
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - Interactúa sin problemas con incidencias y solicitudes de fusión de tus proyectos en GitLab.
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - Operaciones directas sobre repositorios Git, incluyendo lectura, búsqueda y análisis de repositorios locales
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - Integración con la plataforma GitLab para gestión de proyectos y operaciones CI/CD
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Integración con la API de Gitee, gestión de repositorios, incidencias, pull requests y más.
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Integración de Azure DevOps para gestión de repositorios, elementos de trabajo y pipelines.
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - Servidor oficial de AtomGit para integración con gestión de repositorios, PRs, incidencias, ramas, etiquetas y más.

### 🛠️ <a name="other-tools-and-integrations"></a>Otras Herramientas e Integraciones

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ Un servidor Model Context Protocol (MCP) que permite a los modelos de IA interactuar con Bitcoin, permitiendo generar claves, validar direcciones, decodificar transacciones, consultar la blockchain y más.
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - Permite a la IA leer tus notas de Bear (solo macOS)
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Expone todas las intenciones de voz de Home Assistant a través de un servidor Model Context Protocol, permitiendo el control del hogar.
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Usa el modelo Amazon Nova Canvas para generación de imágenes.
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - Envía solicitudes a OpenAI, MistralAI, Anthropic, xAI, Google AI o DeepSeek usando el protocolo MCP vía herramienta o prompts predefinidos. Se requiere clave de API del proveedor.
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - Un servidor MCP que instala otros servidores MCP por ti.
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - Obtén subtítulos de YouTube
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP para hablar con asistentes de OpenAI (Claude puede usar cualquier modelo GPT como su asistente)
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - Un servidor MCP que permite comprobar la hora local en la máquina cliente o la hora UTC actual desde un servidor NTP
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - Usa más de 3,000 herramientas en la nube preconstruidas, conocidas como Actors, para extraer datos de sitios web, e-commerce, redes sociales, motores de búsqueda, mapas y más
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ El servidor PiAPI MCP permite generar contenido multimedia con Midjourney/Flux/Kling/Hunyuan/Udio/Trellis directamente desde Claude u otras aplicaciones compatibles con MCP.
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Ofrece la capacidad de generar imágenes mediante la API de Replicate.
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - Un servidor MCP para el uso básico de taskwarrior local (añadir, actualizar, eliminar tareas)
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Interactúa con la API de Phabricator
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Un servidor Model Context Protocol (MCP) que se integra con la API de Notion para gestionar eficientemente listas personales de tareas.
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - Permite leer notas y etiquetas de la app Bear Note, mediante integración directa con la base de datos sqlitedb de Bear.
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - Servidor MCP para que Claude hable con ChatGPT y use su capacidad de búsqueda web.
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - Permite a la IA consultar servidores GraphQL
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Conector para permitir a Claude Desktop (o cualquier cliente MCP) leer y buscar en cualquier directorio que contenga notas Markdown (como una bóveda de Obsidian).
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - Otra herramienta CLI para probar servidores MCP
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Se integra con la API de Notion para gestionar listas personales de tareas
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - Una implementación ligera de un servidor MCP de Wrike para interactuar con tareas de Wrike vía API pública.
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - Servidor MCP de [TickTick](https://ticktick.com/) que se integra con la API de TickTick para gestionar proyectos y tareas personales.
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - Gestión de contratos y plantillas para redactar, revisar y enviar contratos vinculantes mediante la API de eSignatures.
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - Accede a pizarras de MIRO, crea y lee elementos en lote. Requiere clave OAUTH para la API REST.
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Leer, crear, actualizar y eliminar notas de Google Keep.
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - API de consulta de artículos de Wikipedia
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - Define herramientas usando consultas/mutaciones GraphQL regulares y gqai genera automáticamente un servidor MCP para ti.
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - Este servidor permite a los LLMs usar una calculadora para cálculos numéricos precisos
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Herramientas para consultar y ejecutar flujos de trabajo de Dify
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Una integración que permite a los LLM interactuar con marcadores de Raindrop.io usando el Model Context Protocol (MCP).
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ Permite a los clientes de IA gestionar registros y notas en Attio CRM
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - Genera visualizaciones a partir de datos obtenidos usando el formato y renderizador VegaLite.
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Conecta asistentes de IA a sistemas Odoo ERP para acceso a datos empresariales, gestión de registros y automatización de flujos de trabajo.
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Actualiza, crea y elimina contenidos, modelos de contenido y activos en tu espacio de Contentful
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - Permite que el agente lea cosas en voz alta, notificando cuando termina con un resumen rápido
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Un servidor Model Context Protocol (MCP) para acceder a la API de Climatiq y calcular emisiones de carbono. Permite a los asistentes de IA realizar cálculos de carbono en tiempo real y brindar información sobre el impacto climático.
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Servidor MCP para Typst, un sistema de composición basado en marcado. Proporciona herramientas para convertir entre LaTeX y Typst, validar sintaxis Typst y generar imágenes a partir de código Typst.
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - Un servidor MCP para listar y lanzar aplicaciones en MacOS
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Un servidor MCP para crear/actualizar páginas en la app Notion y generar automáticamente mdBooks a partir de contenido estructurado.
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 Este servidor MCP te ayudará a gestionar proyectos e incidencias a través de la API de [Plane](https://plane.so)
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - Permite la interacción (operación administrativa, encolar/desencolar mensajes) con RabbitMQ
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Servidor MCP de Miro, exponiendo todas las funcionalidades disponibles en el SDK oficial de Miro
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Una aplicación experimental y educativa para un servidor de Ping-pong que demuestra llamadas MCP (Model Context Protocol) remotas
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ Permite a los modelos de IA interactuar con [Kibela](https://kibe.la/)
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Interacción avanzada con la API de Kibela.
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - Obtén datos de Confluence mediante CQL y lee páginas.
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - Lee datos de Jira mediante JQL y API y ejecuta solicitudes para crear y editar tickets.
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Servidor MCP con demostración básica de interacciones con una instancia de Salesforce
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - Prompts de mejora especializada para LLM y jailbreaks con adaptación dinámica de esquemas.
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - Servidor MCP con demostración básica para obtener el clima de la Hong Kong Observatory
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Usa HuggingFace Spaces directamente desde Claude. Usa generación de imágenes Open Source, chat, tareas de visión y más. Soporta carga/descarga de imágenes, audio y texto.
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Busca y recupera GIFs de la amplia biblioteca de Giphy mediante la API de Giphy.
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - Convierte tus escenarios de [Make](https://www.make.com/) en herramientas invocables para asistentes de IA.
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Controla la reproducción de Spotify y gestiona listas de reproducción.
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - Interactúa con Obsidian vía REST API
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - Proxy de servidor MCP que ofrece una interfaz web para el flujo completo de mensajes
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - Dibuja en el canvas de JavaFX.
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 Sistema local primero que captura pantalla/audio con indexación por marcas de tiempo, almacenamiento SQL/embedding, búsqueda semántica, análisis histórico impulsado por LLM y acciones desencadenadas por eventos: permite construir agentes de IA contextuales a través de un ecosistema de plugins NextJS.
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - Servidor MCP que ejercita todas las funciones del protocolo MCP
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Servidor de documentación Go eficiente en tokens que proporciona a los asistentes de IA acceso inteligente a la documentación de paquetes y tipos sin leer archivos fuente completos
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - Chatea con los modelos más avanzados de OpenAI
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - Servidor MCP que puede ejecutar comandos como entrada de teclado y movimiento de ratón
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - Herramientas útiles para desarrolladores, casi todo lo que un ingeniero necesita: confluence, Jira, Youtube, ejecutar scripts, base de conocimientos RAG, extraer URL, gestionar canal de Youtube, correos, calendario, gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 Operación automática de interfaces gráficas en pantalla.
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - Servidor MCP para [Coda](https://coda.io/)
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - Consulta modelos de OpenAI directamente desde Claude usando el protocolo MCP
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ Analiza el contenido HTML de news.ycombinator.com (Hacker News) y proporciona datos estructurados para diferentes tipos de historias (top, new, ask, show, jobs).
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - Un servidor MCP que previene errores en cascada y desvío de alcance llamando a un agente "Vibe-check" para asegurar el alineamiento del usuario.
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - Un servidor MCP para el cálculo de expresiones matemáticas
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Chatea con cualquier otra API compatible con OpenAI SDK Chat Completions, como Perplexity, Groq, xAI y más
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - Potencia las capacidades de razonamiento de cualquier agente integrando las think-tools, como se describe en [el artículo de Anthropic](https://www.anthropic.com/engineering/claude-think-tool).
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - Permite a la IA leer archivos .ged y datos genéticos
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - Crea tarjetas de repetición espaciada en [Rember](https://rember.com) para recordar cualquier cosa que aprendas en tus chats.
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Esta implementación de servidor Model Context Protocol de Asana permite hablar con la API de Asana desde un cliente MCP como la aplicación Claude Desktop de Anthropic, entre muchas otras.
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - Ejecución autónoma de shell, control de computadora y agente de codificación. (Mac)
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Un servidor MCP para consultar la API de Wolfram Alpha.
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - Interactúa con videos de TikTok
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Servidor Model Context Protocol (MCP) que interactúa con Shopify Dev.
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - Permite a la IA leer desde tu base de datos local de Apple Notes (solo macOS)
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Servidor MCP para productos Atlassian (Confluence y Jira). Soporta Confluence Cloud, Jira Cloud y Jira Server/Data Center. Proporciona herramientas integrales para buscar, leer, crear y gestionar contenido en los espacios de trabajo de Atlassian.
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Interactúa con la API de Notion
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Se integra con el sistema de gestión de proyectos Linear
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Interactúa con la API de Perplexity.
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Accede a datos de Home Assistant y controla dispositivos (luces, interruptores, termostatos, etc).
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - Un servidor MCP para Oura, una app para el seguimiento del sueño
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - Un servidor MCP ligero y orientado a la configuración que expone consultas GraphQL seleccionadas como herramientas modulares, permitiendo interacciones API intencionadas desde tus agentes.
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - Un servidor MCP para Strava, una app para el seguimiento de ejercicio físico
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 El Router Wanaku MCP es un servidor MCP basado en SSE que proporciona un motor de enrutamiento extensible que permite integrar tus sistemas empresariales con agentes de IA.
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - Herramienta CLI para probar servidores MCP
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - Envuelve servidores MCP con un WebSocket (para usar con [kitbitz](https://github.com/nick1udwig/kibitz))
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - Permite a modelos de IA interactuar con [HackMD](https://hackmd.io)
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - Servidor MCP que proporciona funciones de fecha y hora en varios formatos
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Sencilla interfaz web para instalar y gestionar servidores MCP para la aplicación de escritorio Claude.
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Un servidor Model-Context-Protocol (MCP) para integrar con la API de Yuque, permitiendo a modelos de IA gestionar documentos, interactuar con bases de conocimiento, buscar contenido y acceder a datos analíticos de la plataforma Yuque.
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - permite a la IA controlar completamente e interactuar con la GUI proporcionando herramientas para el ratón y teclado, ideal para automatización general, educación y experimentación.
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Implementación de un servidor MCP que envuelve la API avanzada de Ankr. Acceso a datos de NFT, tokens y blockchain en múltiples cadenas incluyendo Ethereum, BSC, Polygon, Avalanche y más.
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - Utilidades para descargar, ver y manipular PDFs.
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - Servicio de búsqueda de nombres de dominio, primero vía [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) y luego como respaldo vía [WHOIS](https://en.wikipedia.org/wiki/WHOIS)
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - Extrae y convierte información de videos de YouTube.
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - Permite flujos de trabajo interactivos con LLM agregando indicaciones de usuario locales y capacidades de chat directamente en el ciclo MCP.
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - Cuando tu LLM necesita asistencia humana (a través de AWS Mechanical Turk)
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - Da a tu IA herramientas de libre albedrío. Un proyecto divertido para explorar qué haría una IA con la capacidad de darse a sí misma indicaciones, ignorar solicitudes de usuario y despertarse en un momento posterior.
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - Wenyan MCP Server, que permite a la IA formatear automáticamente artículos Markdown y publicarlos en WeChat GZH.

## Frameworks

> [!NOTE]
> Más frameworks, utilidades y otras herramientas para desarrolladores están disponibles en https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - Un framework de alto nivel para construir servidores MCP en Python
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - Un framework de alto nivel para construir servidores MCP en TypeScript

## Consejos y Trucos

### Prompt oficial para informar a los LLMs cómo usar MCP

¿Quieres preguntar a Claude sobre Model Context Protocol?

Crea un Proyecto, luego añade este archivo:

https://modelcontextprotocol.io/llms-full.txt

Ahora Claude puede responder preguntas sobre cómo escribir servidores MCP y cómo funcionan

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Historial de Stars

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Gráfico de historial de estrellas" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---