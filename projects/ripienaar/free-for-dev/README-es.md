# free-for.dev

Los desarrolladores y autores de Open Source ahora cuentan con muchos servicios que ofrecen planes gratuitos, pero encontrarlos todos requiere tiempo para tomar decisiones informadas.

Esta es una lista de software (SaaS, PaaS, IaaS, etc.) y otras ofertas con planes gratuitos para desarrolladores.

El alcance de esta lista en particular está limitado a cosas que los desarrolladores de infraestructura (Administradores de Sistemas, Profesionales DevOps, etc.) probablemente encuentren útiles. Amamos todos los servicios gratuitos que existen, pero sería bueno mantenerlo en el tema. A veces es una línea gris, así que esto es subjetivo; por favor, no te ofendas si no acepto tu contribución.

Esta lista es el resultado de Pull Requests, revisiones, ideas y trabajo realizado por más de 1600 personas. También puedes ayudar enviando [Pull Requests](https://github.com/ripienaar/free-for-dev) para agregar más servicios o eliminar aquellos cuyas ofertas hayan cambiado o hayan sido retiradas.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**NOTA**: Esta lista es solo para ofertas tipo as-a-Service, no para software autohospedado. Para ser elegible, un servicio debe ofrecer un plan gratuito, no solo una prueba gratuita. El plan gratuito debe durar al menos un año si es limitado por tiempo. También consideramos el plan gratuito desde una perspectiva de seguridad, por lo que SSO está bien, pero no aceptaré servicios que restrinjan TLS solo para planes pagos.

# Tabla de Contenidos

  * [Límites Siempre Gratis de los Principales Proveedores Cloud](#major-cloud-providers)
  * [Soluciones de Gestión Cloud](#cloud-management-solutions)
  * [Analítica, Eventos y Estadísticas](#analytics-events-and-statistics)
  * [APIs, Datos y ML](#apis-data-and-ml)
  * [Repositorios de Artefactos](#artifact-repos)
  * [BaaS](#baas)
  * [Plataformas Low-code](#low-code-platform)
  * [CDN y Protección](#cdn-and-protection)
  * [CI y CD](#ci-and-cd)
  * [CMS](#cms)
  * [Generación de Código](#code-generation)
  * [Calidad de Código](#code-quality)
  * [Búsqueda y Navegación de Código](#code-search-and-browsing)
  * [Gestión de Errores y Excepciones](#crash-and-exception-handling)
  * [Visualización de Datos en Mapas](#data-visualization-on-maps)
  * [Servicios de Datos Gestionados](#managed-data-services)
  * [Diseño y UI](#design-and-ui)
  * [Inspiración de Diseño](#design-inspiration)
  * [Sitios de Blogging para Desarrolladores](#dev-blogging-sites)
  * [DNS](#dns)
  * [Relacionado con Docker](#docker-related)
  * [Dominios](#domain)
  * [Educación y Desarrollo Profesional](#education-and-career-development)
  * [Email](#email)
  * [Plataformas de Gestión de Feature Toggles](#feature-toggles-management-platforms)
  * [Fuentes](#font)
  * [Formularios](#forms)
  * [IA Generativa](#generative-ai)
  * [IaaS](#iaas)
  * [IDE y Edición de Código](#ide-and-code-editing)
  * [API y SDK de Verificación Internacional de Números Móviles](#international-mobile-number-verification-api-and-sdk)
  * [Gestión de Incidencias y Proyectos](#issue-tracking-and-project-management)
  * [Gestión de Logs](#log-management)
  * [Distribución y Feedback de Apps Móviles](#mobile-app-distribution-and-feedback)
  * [Sistemas de Gestión](#management-system)
  * [Mensajería y Streaming](#messaging-and-streaming)
  * [Misceláneos](#miscellaneous)
  * [Monitoreo](#monitoring)
  * [PaaS](#paas)
  * [Sistema de Construcción de Paquetes](#package-build-system)
  * [Integración de Pagos y Facturación](#payment-and-billing-integration)
  * [Gestión de Privacidad](#privacy-management)
  * [APIs de Captura de Pantallas](#screenshot-apis)
  * [Relacionado con Flutter y Construcción de Apps IOS sin Mac](#flutter-related-and-building-ios-apps-without-mac)
  * [Búsqueda](#search)
  * [Seguridad y PKI](#security-and-pki)
  * [Autenticación, Autorización y Gestión de Usuarios](#authentication-authorization-and-user-management)
  * [Repositorios de Código Fuente](#source-code-repos)
  * [Almacenamiento y Procesamiento de Medios](#storage-and-media-processing)
  * [Túneles, WebRTC, Servidores Web Socket y Otros Routers](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [Testing](#testing)
  * [Herramientas para Equipos y Colaboración](#tools-for-teams-and-collaboration)
  * [Gestión de Traducciones](#translation-management)
  * [Relacionado con Vagrant](#vagrant-related)
  * [Grabación de Sesiones de Visitantes](#visitor-session-recording)
  * [Alojamiento Web](#web-hosting)
  * [Plataformas de Comentarios](#commenting-platforms)
  * [Emulación de Hardware en el Navegador](#browser-based-hardware-emulation-written-in-javascript)
  * [Herramientas de Escritorio Remoto](#remote-desktop-tools)
  * [Desarrollo de Videojuegos](#game-development)
  * [Otros Recursos Gratuitos](#other-free-resources)

## Principales Proveedores Cloud

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 28 horas de instancia frontend por día, nueve horas de instancia backend por día
    * Cloud Firestore - 1GB de almacenamiento, 50,000 lecturas, 20,000 escrituras, 20,000 eliminaciones por día
    * Compute Engine - 1 e2-micro no preemtible, 30GB HDD, 5GB de almacenamiento de snapshots (restringido a ciertas regiones), 1 GB de egreso de red desde Norteamérica a todos los destinos regionales (excluyendo China y Australia) por mes
    * Cloud Storage - 5GB, 1GB de egreso de red
    * Cloud Shell - Shell Linux basada en web/IDE principal con 5GB de almacenamiento persistente. Límite de 60 horas por semana
    * Cloud Pub/Sub - 10GB de mensajes por mes
    * Cloud Functions - 2 millones de invocaciones por mes (incluye tanto invocaciones en background como HTTP)
    * Cloud Run - 2 millones de solicitudes por mes, 360,000 GB-segundos de memoria, 180,000 vCPU-segundos de tiempo de cómputo, 1 GB de egreso de red desde Norteamérica por mes
    * Google Kubernetes Engine - Sin tarifa de gestión de clúster para un clúster zonal. Cada nodo de usuario se cobra a precio estándar de Compute Engine
    * BigQuery - 1 TB de consultas por mes, 10 GB de almacenamiento cada mes
    * Cloud Build - 120 minutos de construcción por día
    * Cloud Source Repositories - Hasta 5 usuarios, 50 GB de almacenamiento, 50 GB de egreso
    * [Google Colab](https://colab.research.google.com/) - Entorno de desarrollo de Jupyter Notebooks gratuito.
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio (anteriormente Project IDX). VSCode online funcionando en Google Cloud.
    * Lista completa y detallada - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 1TB de egreso por mes y 2M de invocaciones de funciones por mes
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10 métricas personalizadas y diez alarmas
* [CodeBuild](https://aws.amazon.com/codebuild/) - 100 minutos de tiempo de compilación por mes  
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5 usuarios activos, 50 GB de almacenamiento y 10 000 solicitudes por mes  
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 1 canalización activa por mes  
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25 GB de base de datos NoSQL  
* [EC2](https://aws.amazon.com/ec2/) - 750 horas por mes de t2.micro o t3.micro (12 meses). 100 GB de egreso por mes  
* [EBS](https://aws.amazon.com/ebs/) - 30 GB por mes de almacenamiento de propósito general (SSD) o magnético (12 meses)  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 750 horas por mes (12 meses)  
* [RDS](https://aws.amazon.com/rds/) - 750 horas por mes de db.t2.micro, db.t3.micro o db.t4g.micro, 20 GB de almacenamiento de propósito general (SSD), 20 GB de copias de seguridad de almacenamiento (12 meses)  
* [S3](https://aws.amazon.com/s3/) - 5 GB de almacenamiento estándar de objetos, 20 000 solicitudes Get y 2 000 solicitudes Put (12 meses)  
* [Glacier](https://aws.amazon.com/glacier/) - 10 GB de almacenamiento de objetos a largo plazo  
* [Lambda](https://aws.amazon.com/lambda/) - 1 millón de solicitudes por mes  
* [SNS](https://aws.amazon.com/sns/) - 1 millón de publicaciones por mes  
* [SES](https://aws.amazon.com/ses/) - 3.000 mensajes por mes (12 meses)  
* [SQS](https://aws.amazon.com/sqs/) - 1 millón de solicitudes de cola de mensajes  
* Lista completa y detallada - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)  
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 VM Linux B1S, 1 VM Windows B1S (12 meses)  
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10 aplicaciones web, móviles o API (60 minutos de CPU/día)  
  * [Functions](https://azure.microsoft.com/services/functions/) - 1 millón de solicitudes por mes  
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - Habilita entornos de desarrollo y pruebas rápidos, fáciles y ligeros  
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500.000 objetos  
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 50.000 usuarios almacenados mensualmente  
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5 usuarios activos, repositorios Git privados ilimitados  
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 10 trabajos paralelos gratuitos con minutos ilimitados para código abierto en Linux, macOS y Windows  
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 8.000 mensajes por día  
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1 IP pública balanceada gratuita (VIP)  
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 1 millón de notificaciones push  
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 15 GB de entrada (12 meses) y 5 GB de egreso por mes  
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25 GB de almacenamiento y 1.000 RUs de rendimiento aprovisionado  
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — Crea, implementa y aloja aplicaciones estáticas y funciones serverless con SSL gratuito, autenticación/autorización y dominios personalizados  
  * [Storage](https://azure.microsoft.com/services/storage/) - 5 GB de almacenamiento LRS de archivos o blobs (12 meses)  
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - APIs de IA/ML (Visión por Computadora, Traductor, Detección de rostros, Bots, etc.) con nivel gratuito que incluye transacciones limitadas  
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - Servicio de búsqueda e indexación basado en IA, gratuito para 10.000 documentos  
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - Servicio administrado de Kubernetes, gestión de clúster gratuita  
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 100.000 operaciones/mes  
  * Lista completa y detallada - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)  
  * Compute  
     - 2 VMs de cómputo basadas en AMD con 1/8 OCPU y 1 GB de memoria cada una  
     - 4 núcleos Arm Ampere A1 y 24 GB de memoria, utilizables como una VM o hasta 4 VMs  
     - Las instancias serán reclamadas cuando se [consideren inactivas](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)  
  * Volumen de bloques - 2 volúmenes, 200 GB en total (usados para cómputo)  
  * Almacenamiento de objetos - 10 GB  
  * Balanceador de carga - 1 instancia con 10 Mbps  
  * Bases de datos - 2 BD, 20 GB cada una  
  * Monitorización - 500 millones de puntos de datos ingeridos, 1 mil millones de puntos de datos recuperados  
  * Ancho de banda - 10 TB de egreso por mes, velocidad limitada a 50 Mbps en VMs basadas en x64, 500 Mbps * cantidad de núcleos en VM ARM  
  * IP pública - 2 IPv4 para VMs, 1 IPv4 para balanceador  
  * Notificaciones - 1 millón de opciones de entrega por mes, 1.000 correos enviados por mes  
  * Lista completa y detallada - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)  
  * Base de datos Cloudant - 1 GB de almacenamiento de datos  
  * Base de datos Db2 - 100 MB de almacenamiento de datos  
  * API Connect - 50.000 llamadas API por mes  
  * Monitorización de disponibilidad - 3 millones de puntos de datos por mes  
  * Análisis de logs - 500 MB de logs diarios  
  * Lista completa y detallada - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)  
  * [Application Services](https://www.cloudflare.com/plans/) - DNS gratuito para número ilimitado de dominios, protección DDoS, CDN con SSL gratuito, reglas de firewall y de página, WAF, mitigación de bots, limitación de tasas sin medición gratuita - 1 regla por dominio, análisis, reenvío de correo  
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - Hasta 50 usuarios, 24 horas de registro de actividad, tres ubicaciones de red  
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - Puedes exponer un puerto HTTP local a través de un túnel a un subdominio aleatorio en trycloudflare.com usando [Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/), no se requiere cuenta. Más funciones (túnel TCP, balanceo de carga, VPN) en [Zero Trust](https://www.cloudflare.com/products/zero-trust/) Plan Gratuito.  
  * [Workers](https://developers.cloudflare.com/workers/) - Despliega código serverless gratis en la red global de Cloudflare—100.000 solicitudes diarias.  
  * [Workers KV](https://developers.cloudflare.com/kv) - 100.000 solicitudes de lectura por día, 1.000 de escritura por día, 1.000 de borrado por día, 1.000 de listado por día, 1 GB de datos almacenados  
  * [R2](https://developers.cloudflare.com/r2/) - 10 GB por mes, 1 millón de operaciones Clase A por mes, 10 millones de operaciones Clase B por mes  
  * [D1](https://developers.cloudflare.com/d1/) - 5 millones de filas leídas por día, 100.000 filas escritas por día, 1 GB de almacenamiento  
  * [Pages](https://developers.cloudflare.com/pages/) - Desarrolla e implementa tus aplicaciones web en la red global rápida y segura de Cloudflare. 500 compilaciones mensuales, 100 dominios personalizados, SSL integrado, asientos ilimitados, implementaciones de vista previa ilimitadas y capacidad full-stack mediante integración con Cloudflare Workers.  
  * [Queues](https://developers.cloudflare.com/queues/) - 1 millón de operaciones por mes  
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 1 TB de tráfico (saliente) gratis por mes.

**[⬆️ Volver arriba](#table-of-contents)**

## Soluciones de gestión de la nube

* [Brainboard](https://www.brainboard.co) - Solución colaborativa para construir y gestionar infraestructuras cloud visualmente de extremo a extremo.  
* [Cloud 66](https://www.cloud66.com/) - Gratis para proyectos personales (incluye un servidor de despliegue, un sitio estático). Cloud 66 te da todo lo necesario para construir, desplegar y hacer crecer tus aplicaciones en cualquier nube sin complicaciones de "cosas del servidor".  
* [Pulumi](https://www.pulumi.com/) — Plataforma moderna de infraestructura como código que permite usar lenguajes y herramientas de programación familiares para construir, desplegar y gestionar infraestructura cloud.  
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. Gestión remota de estado gratuita y colaboración en equipo para hasta 500 recursos.  
* [scalr.com](https://scalr.com/) - Scalr es un producto de Automatización y Colaboración de Terraform (TACO) utilizado para mejorar la colaboración y automatización en infraestructuras y configuraciones gestionadas por Terraform. Soporte completo de CLI de Terraform, integración con OPA y modelo de configuración jerárquico. Sin impuestos por SSO. Todas las funciones incluidas. Hasta 50 ejecuciones/mes gratis.  
* [deployment.io](https://deployment.io) - Deployment.io ayuda a los desarrolladores a automatizar despliegues en AWS. En nuestro plan gratuito, un desarrollador (usuario único) puede desplegar sitios estáticos ilimitados, servicios web y entornos. Ofrecemos 20 ejecuciones de trabajos gratis al mes con previsualizaciones y autodespliegues incluidos en el plan gratuito.

**[⬆️ Volver arriba](#table-of-contents)**

## Repositorios de código fuente

* [Bitbucket](https://bitbucket.org/) — Repositorios Git públicos y privados ilimitados para hasta 5 usuarios con Pipelines para CI/CD  
* [chiselapp.com](https://chiselapp.com/) — Repositorios Fossil públicos y privados ilimitados  
* [codebasehq.com](https://www.codebasehq.com/) — Un proyecto gratis con 100 MB de espacio y dos usuarios  
* [Codeberg](https://codeberg.org/) — Repositorios Git públicos y privados ilimitados para proyectos libres y de código abierto (con colaboradores ilimitados). Potenciado por [Forgejo](https://forgejo.org/). Hosting de sitios estáticos con [Codeberg Pages](https://codeberg.page/). Hosting CI/CD con [Codeberg's CI](https://docs.codeberg.org/ci/). Hosting de traducciones con [Codeberg Translate](https://translate.codeberg.org/). Incluye hosting de paquetes y contenedores, gestión de proyectos y seguimiento de incidencias  
* [GitGud](https://gitgud.io) — Repositorios públicos y privados ilimitados. Gratis para siempre. Potenciado por GitLab y Sapphire. CI/CD no incluido.  
* [GitHub](https://github.com/) — Repositorios públicos ilimitados y privados ilimitados (con colaboradores ilimitados). Incluye CI/CD, entorno de desarrollo, hosting estático, hosting de paquetes y contenedores, gestión de proyectos y Copilot de IA  
* [gitlab.com](https://about.gitlab.com/) — Repositorios Git públicos y privados ilimitados con hasta 5 colaboradores. Incluye CI/CD, hosting estático, registro de contenedores, gestión de proyectos y seguimiento de incidencias  
* [framagit.org](https://framagit.org/) — Framagit es la forja de software de Framasoft basada en el software Gitlab; incluye CI, páginas estáticas, páginas de proyectos y seguimiento de incidencias.  
* [heptapod.net](https://foss.heptapod.net/) — Heptapod es un fork amigable de GitLab Community Edition que proporciona soporte para Mercurial  
* [ionicframework.com](https://ionicframework.com/appflow) - Repositorio y herramientas para desarrollar aplicaciones con Ionic; también dispones de un repositorio ionic  
* [NotABug](https://notabug.org) — NotABug.org es una plataforma de colaboración de código gratuita para proyectos con licencia libre, basada en Git  
* [OSDN](https://osdn.net/) - OSDN.net es un servicio gratuito para desarrolladores de software de código abierto, ofreciendo repositorios SVN/Git/Mercurial/Bazaar/CVS.
  * [Pagure.io](https://pagure.io) — Pagure.io es una plataforma gratuita y de código abierto para la colaboración en proyectos de software con licencia FOSS, basada en Git.
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — 1GB gratuito en la nube y repositorios Git, Mercurial o SVN.
  * [pijul.com](https://pijul.com/) - Sistema de control de versiones distribuido, gratuito y de código abierto sin límites. Su característica distintiva se basa en una teoría sólida de parches, lo que facilita su aprendizaje, uso y distribución. Resuelve muchos problemas de git/hg/svn/darcs.
  * [plasticscm.com](https://plasticscm.com/) — Gratis para individuos, OSS y organizaciones sin fines de lucro.
  * [projectlocker.com](https://projectlocker.com) — Un proyecto privado gratuito (Git y Subversion) con 50 MB de espacio.
  * [RocketGit](https://rocketgit.com) — Hospedaje de repositorios basado en Git. Repositorios públicos y privados ilimitados.
  * [savannah.gnu.org](https://savannah.gnu.org/) - Sirve como sistema de gestión colaborativa de desarrollo de software para proyectos de Software Libre (para Proyectos GNU).
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - Sirve como sistema de gestión colaborativa de desarrollo de software para proyectos de Software Libre (para proyectos no-GNU).

**[⬆️ Volver arriba](#table-of-contents)**

## APIs, Datos y ML

  * [JSONGrid](https://jsongrid.com) - Herramienta gratuita para visualizar, editar y filtrar datos JSON complejos en una bella cuadrícula tabular. Guarda y comparte datos JSON mediante un enlace.
  * [Zerosheets](https://zerosheets.com) - Convierte tus hojas de cálculo de Google Sheets en potentes API para desarrollar rápidamente prototipos, sitios web, apps y más. 500 solicitudes al mes disponibles gratis.
  * [IP.City](https://ip.city) — 100 solicitudes gratuitas de geolocalización IP por día.
  * [Abstract API](https://www.abstractapi.com) — Suite de API para varios casos de uso, incluyendo geolocalización IP, detección de género o validación de email.
  * [Apify](https://www.apify.com/) — Plataforma de scraping y automatización web para crear una API de cualquier sitio web y extraer datos. Scrapers listos, proxies integrados y soluciones personalizadas. Plan gratuito con $5 de créditos de plataforma incluidos cada mes.
  * [APITemplate.io](https://apitemplate.io) - Genera automáticamente imágenes y documentos PDF con una simple API o herramientas de automatización como Zapier & Airtable. No se requiere CSS/HTML. El plan gratuito incluye 50 imágenes/mes y tres plantillas.
  * [APIToolkit.io](https://apitoolkit.io) - Todas las herramientas que necesitas para comprender completamente lo que sucede en tus APIs y backends. Validación automática de contratos de API y monitoreo. El plan gratuito cubre servidores con hasta 10.000 solicitudes diarias.
  * [APIVerve](https://apiverve.com) - Obtén acceso instantáneo a más de 120 APIs gratis, diseñadas con calidad, consistencia y fiabilidad en mente. El plan gratuito cubre hasta 50 tokens de API al mes. (Posiblemente fuera de línea, 2025-06-25)
  * [Arize AI](https://arize.com/) - Observabilidad de machine learning para monitoreo de modelos y detección de causas raíz de problemas como calidad de datos y deriva de rendimiento. Gratis hasta dos modelos.
  * [Maxim AI](https://getmaxim.ai/) - Simula, evalúa y observa tus agentes de IA. Maxim es una plataforma de evaluación y observabilidad end-to-end, ayudando a los equipos a lanzar sus agentes de IA de forma confiable y >5 veces más rápido. Gratis para siempre para desarrolladores independientes y equipos pequeños (3 asientos).
  * [Beeceptor](https://beeceptor.com) - Simula una API REST en segundos, respuestas falsas de API y mucho más. Gratis 50 solicitudes por día, panel público, endpoints abiertos (cualquiera con el enlace al panel puede ver envíos y respuestas).
  * [BigDataCloud](https://www.bigdatacloud.com/) - Ofrece APIs rápidas, precisas y gratuitas (Ilimitadas o hasta 10K-50K/mes) para la web moderna como geolocalización IP, geocodificación inversa, información de redes, validación de email y teléfono, información de cliente y más.
  * [Browse AI](https://www.browse.ai) — Extracción y monitoreo de datos en la web. 1.000 créditos por mes gratis, equivalente a 1.000 solicitudes concurrentes.
  * [BrowserCat](https://www.browsercat.com) - API de navegador sin cabeza para automatización, scraping, acceso web para agentes de IA, generación de imágenes/pdf y más. Plan gratuito con 1.000 solicitudes por mes.
  * [Calendarific](https://calendarific.com) - Servicio de API de días festivos de nivel empresarial para más de 200 países. El plan gratuito incluye 500 llamadas al mes.
  * [Canopy](https://www.canopyapi.co/) - API GraphQL para datos de productos, búsqueda y categorías de Amazon.com. El plan gratuito incluye 100 llamadas al mes.
  * [Clarifai](https://www.clarifai.com) — API de imágenes para reconocimiento y detección facial personalizado. Permite entrenar modelos de IA. El plan gratuito tiene 1.000 llamadas por mes.
  * [Cloudmersive](https://cloudmersive.com/) — Plataforma de utilidades API con acceso completo a una amplia biblioteca de APIs, incluyendo conversión de documentos, escaneo de virus y más con 600 llamadas/mes, solo en Norteamérica AZ, tamaño máximo de archivo de 2,5MB.
  * [Colaboratory](https://colab.research.google.com) — Entorno de notebooks Python basado en la web, gratuito, con GPU Nvidia Tesla K80.
  * [CometML](https://www.comet.com/site/) - Plataforma MLOps para seguimiento de experimentos, gestión de modelos en producción, registro de modelos y trazabilidad completa de datos, cubriendo el flujo de trabajo desde entrenamiento hasta producción. Gratis para individuos y académicos.
  * [Commerce Layer](https://commercelayer.io) - API de comercio componible que permite crear, gestionar y procesar pedidos desde cualquier front end. El plan para desarrolladores permite 100 pedidos al mes y hasta 1.000 SKUs de forma gratuita.
  * [Composio](https://composio.dev/) - Plataforma de integración para Agentes de IA y LLMs. Integra más de 200 herramientas a través de la internet agentica.
  * [Conversion Tools](https://conversiontools.io/) - Conversor de archivos en línea para documentos, imágenes, video, audio y eBooks. API REST disponible. Librerías para Node.js, PHP, Python. Soporta archivos de hasta 50 GB (para planes pagos). El plan gratuito está limitado por tamaño de archivo (20MB) y número de conversiones (30/día, 300/mes).
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - API y microservicio que proporciona una amplia gama de información incluyendo países, regiones, provincias, ciudades, códigos postales y mucho más. El nivel gratuito incluye hasta 100 solicitudes por día.
  * [Coupler](https://www.coupler.io/) - Herramienta de integración de datos que sincroniza entre aplicaciones. Puede crear paneles y reportes en vivo, transformar y manipular valores, recolectar y respaldar insights. El plan gratuito está limitado a un usuario, una conexión de datos, una fuente y un destino. También requiere actualización manual de los datos.
  * [CraftMyPDF](https://craftmypdf.com) - Genera automáticamente documentos PDF desde plantillas reutilizables con un editor drag and drop y una API simple. El plan gratuito incluye 100 PDFs/mes y tres plantillas.
  * [Crawlbase](https://crawlbase.com/) — Rastrea y extrae datos de sitios web sin proxies, infraestructura o navegadores. Resolvemos captchas por ti y prevenimos bloqueos. Las primeras 1.000 llamadas son gratuitas.
  * [CurlHub](https://curlhub.io) — Servicio proxy para inspeccionar y depurar llamadas API. El plan gratuito incluye 10.000 solicitudes por mes.
  * [CurrencyScoop](https://currencyscoop.com) - API de datos de divisas en tiempo real para aplicaciones fintech. El plan gratuito incluye 5.000 llamadas al mes.
  * [Cube](https://cube.dev/) - Cube ayuda a ingenieros de datos y desarrolladores de aplicaciones a acceder a datos desde almacenes modernos, organizarlos en definiciones consistentes y entregarlos a cada aplicación. La forma más rápida de usar Cube es con Cube Cloud, que tiene un nivel gratuito limitado a 1.000 consultas por día.
  * [Data Dead Drop](https://datadeaddrop.com) - Compartición simple y gratuita de archivos. Los datos se autodestruyen tras el acceso. Sube y descarga datos vía navegador o tu cliente de línea de comandos favorito.
  * [Data Fetcher](https://datafetcher.com) - Conecta Airtable con cualquier aplicación o API sin código. Interfaz tipo Postman para ejecutar solicitudes API en Airtable. Integraciones preconstruidas con docenas de apps. El plan gratuito incluye 100 ejecuciones por mes.
  * [Dataimporter.io](https://www.dataimporter.io) - Herramienta para conectar, limpiar e importar datos a Salesforce. El plan gratuito incluye hasta 20.000 registros por mes.
  * [Datalore](https://datalore.jetbrains.com) - Notebooks Python por Jetbrains. Incluye 10 GB de almacenamiento y 120 horas de ejecución cada mes.
  * [Data Miner](https://dataminer.io/) - Extensión de navegador (Google Chrome, MS Edge) para extraer datos de páginas web a CSV o Excel. El plan gratuito te da 500 páginas/mes.
  * [Datapane](https://datapane.com) - API para construir reportes interactivos en Python y desplegar scripts y notebooks de Jupyter como herramientas de autoservicio.
  * [DB-IP](https://db-ip.com/api/free) - API gratuita de geolocalización IP con 1.000 solicitudes por IP al día. Base de datos lite bajo licencia CC-BY 4.0 también es gratuita.
  * [DB Designer](https://www.dbdesigner.net/) — Herramienta en la nube para diseño y modelado de esquemas de bases de datos con un plan inicial gratuito de 2 modelos de bases de datos y diez tablas por modelo.
  * [DeepAR](https://developer.deepar.ai) — Filtros faciales de realidad aumentada para cualquier plataforma con un solo SDK. El plan gratuito proporciona hasta 10 usuarios activos mensuales (MAU) y seguimiento de hasta 4 rostros.
  * [Deepnote](https://deepnote.com) - Nuevo notebook para ciencia de datos. Compatible con Jupyter, colaboración en tiempo real y ejecución en la nube. El nivel gratuito incluye proyectos personales ilimitados, máquinas básicas ilimitadas con 5GB de RAM y 2vCPU, y equipos de hasta 3 editores.
  * [Disease.sh](https://disease.sh/) — API gratuita que proporciona datos precisos para construir aplicaciones útiles relacionadas con Covid-19.
  * [Doczilla](https://www.doczilla.app/) — API SaaS que permite la generación de capturas de pantalla o PDFs directamente desde código HTML/CSS/JS. El plan gratuito permite 250 documentos al mes.
  * [Doppio](https://doppio.sh/) — API gestionada para generar y almacenar de forma privada PDFs y capturas de pantalla usando tecnología de renderizado avanzada. El plan gratuito permite 400 PDFs y capturas al mes.
  * [drawDB](https://drawdb.app/) — Editor de diagramas de base de datos en línea, gratuito y de código abierto, sin registro requerido.
  * [dreamfactory.com](https://dreamfactory.com/) — Backend REST API de código abierto para aplicaciones móviles, web e IoT. Conecta cualquier base de datos SQL/NoSQL, sistema de almacenamiento de archivos o servicio externo, e instantáneamente crea una plataforma REST API completa con documentación en vivo y gestión de usuarios.
  * [Duply.co](https://duply.co) — Crea imágenes dinámicas desde API y URL, diseña la plantilla una vez y reutilízala. El nivel gratuito ofrece 20 créditos.
  * [DynamicDocs](https://advicement.io) - Genera documentos PDF con API JSON a PDF basado en plantillas LaTeX. El plan gratuito permite 50 llamadas API por mes y acceso a una biblioteca de plantillas.
  * [Efemarai](https://efemarai.com) - Plataforma de pruebas y depuración para modelos y datos de ML. Visualiza cualquier grafo computacional. Uso local gratuito.
  * [ERD Lab](https://www.erdlab.io) — Herramienta de diagramas de relación de entidades (ERD) gratuita en la nube hecha para desarrolladores. Prueba gratuita incluye 2 proyectos con 10 tablas cada uno.
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - Cliente HTTP web gratuito para enviar solicitudes HTTP.
  * [Export SDK](https://exportsdk.com) - API generadora de PDFs con editor de plantillas drag-and-drop, SDK e integraciones sin código. El plan gratuito incluye 250 páginas mensuales, usuarios ilimitados y tres plantillas.
  * [file.coffee](https://file.coffee/) - Plataforma donde puedes almacenar hasta 15MB/archivo (30MB/archivo con cuenta).
  * [Financial Data](https://financialdata.net/) - API de datos financieros y de mercado bursátil. El plan gratuito permite 300 solicitudes por día.
  * [FormatJSONOnline.com](https://formatjsononline.com) - Herramienta gratuita en el navegador para formatear, validar, comparar y minificar datos JSON al instante.
  * [FraudLabs Pro](https://www.fraudlabspro.com) — Filtra transacciones de pedidos para detectar fraude en pagos con tarjeta de crédito. Esta API REST detectará todos los posibles fraudes según los parámetros de la orden. El plan Micro gratuito tiene 500 transacciones al mes.
  * [GeoDataSource](https://www.geodatasource.com) — Servicio de búsqueda de ubicación que consulta nombres de ciudades usando coordenadas de latitud y longitud. Consultas API gratuitas hasta 500 veces por mes.
  * [Geolocated.io](https://geolocated.io) — API de geolocalización IP con servidores multicontinentales, ofrece un plan gratuito con 2.000 solicitudes por día.
  * [Glitterly](https://glitterly.app/) - Genera programáticamente imágenes dinámicas desde plantillas base. API RESTful e integraciones sin código. El nivel gratuito incluye 50 imágenes/mes y cinco plantillas.
  * [Hex](https://hex.tech/) - Plataforma colaborativa de datos para notebooks, apps de datos y bibliotecas de conocimiento. Nivel comunitario gratuito con hasta cinco proyectos.
  * [Hook0](https://www.hook0.com/) - Hook0 es un servicio open source de Webhooks como servicio (WaaS) que facilita a los productos online proporcionar webhooks. Envía hasta 100 eventos/día con retención de historial de siete días gratis.
  * [Hoppscotch](https://hoppscotch.io) - Constructor de solicitudes API gratuito, rápido y bello.
  * [huggingface.co](https://huggingface.co) - Construye, entrena y despliega modelos NLP para Pytorch, TensorFlow y JAX. Gratis hasta 30k caracteres de entrada/mes.
  * [Hybiscus](https://hybiscus.dev/) - Crea reportes PDF usando una simple API declarativa. El nivel gratuito de 14 días incluye 50 reportes de una sola página, con la opción de personalizar paletas de colores y fuentes.
  * [Invantive Cloud](https://cloud.invantive.com/) — Accede a más de 70 plataformas (cloud) como Exact Online, Twinfield, ActiveCampaign o Visma usando Invantive SQL u OData4 (típicamente Power BI o Power Query). Incluye replicación e intercambio de datos. Plan gratuito para desarrolladores y consultores de implementación. Gratis para plataformas específicas con limitaciones en volúmenes de datos.
  * [ipaddress.sh](https://ipaddress.sh) — Servicio simple para obtener una IP pública en diferentes [formatos](https://about.ipaddress.sh/).
  * [ip-api](https://ip-api.com) — API de geolocalización IP, gratis para uso no comercial, no requiere clave de API, limitado a 45 solicitudes/minuto desde la misma IP en el plan gratuito.
  * [ipbase.com](https://ipbase.com) - API de geolocalización IP - Plan gratis para siempre con 150 solicitudes mensuales.
  * [IP Geolocation](https://ipgeolocation.io/) — API de geolocalización IP - Plan gratis para siempre para desarrolladores con un límite de 1.000 solicitudes por día.
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — API de geolocalización IP de Abstract - Permite 1.000 solicitudes gratuitas.
  * [IPLocate](https://www.iplocate.io) — API de geolocalización IP, gratis hasta 1.000 solicitudes/día. Incluye detección de proxy/VPN/hosting, datos ASN, IP a empresa y más. IPLocate también ofrece bases de datos gratuitas descargables de IP a país y IP a ASN en formatos CSV o MMDB compatibles con GeoIP.
  * [IP2Location](https://www.ip2location.com) — Servicio freemium de geolocalización IP. Base de datos LITE disponible para descarga gratuita. Importa la base de datos en el servidor y realiza consultas locales para determinar ciudad, coordenadas e información del ISP.
  * [IP2Location.io](https://www.ip2location.io/) — API de geolocalización IP freemium, rápida y fiable. Obtén datos como ciudad, coordenadas, ISP y más. El plan gratuito incluye 50k créditos al mes. IP2Location.io también ofrece 500 búsquedas WHOIS y de dominios alojados por mes. Consulta detalles de registro de dominio y encuentra dominios alojados en una IP específica. Actualiza a un plan de pago para más funciones.
  * [ipapi](https://ipapi.co/) - API de localización de IP por Kloudend, Inc - Una API de geolocalización fiable sobre AWS, utilizada por empresas Fortune 500. El nivel gratuito ofrece 30k búsquedas/mes (1k/día) sin registro.
  * [ipapi.is](https://ipapi.is/) - API de direcciones IP fiable, creada por desarrolladores para desarrolladores, con las mejores capacidades de detección de hosting disponibles. El plan gratuito ofrece 1.000 búsquedas sin registro.
  * [IPinfo](https://ipinfo.io/) — API de datos de dirección IP rápida, precisa y gratuita (hasta 50k/mes). Ofrece APIs con detalles sobre geolocalización, empresas, carriers, rangos de IP, dominios, contactos de abuso y más. Todas las APIs de pago pueden probarse gratis.
  * [IPQuery](https://ipquery.io) — API de IP ilimitada para desarrolladores, sin límites de tasa ni precios.
  * [IPTrace](https://iptrace.io) — Una API extremadamente simple que proporciona a tu empresa datos de geolocalización IP fiables y útiles con 50.000 consultas gratuitas al mes.
  * [JSON2Video](https://json2video.com) - API de edición de video para automatizar videos de marketing y redes sociales, de forma programática o sin código.
  * [JSON IP](https://getjsonip.com) — Devuelve la IP pública del cliente que hace la solicitud. No se requiere registro para el nivel gratuito. Usando CORS, los datos pueden solicitarse desde JS del lado del cliente directamente en el navegador. Útil para monitorizar cambios de IP de cliente y servidor. Solicitudes ilimitadas.
  * [JSON Serve](https://jsonserve.com/) — Servicio gratuito que ayuda a los desarrolladores a almacenar objetos JSON y usarlos como una REST API en su aplicación.
  * [JSONing](https://jsoning.com/api/) — Crea una API REST falsa desde un objeto JSON, y personaliza códigos de estado HTTP, cabeceras y cuerpos de respuesta.
  * [konghq.com](https://konghq.com/) — Mercado de APIs y potentes herramientas de API públicas y privadas. En el nivel gratuito, algunas funciones como monitoreo, alertas y soporte son limitadas.
  * [Kreya](https://kreya.app) — Cliente GUI gratuito para gRPC para llamar y probar APIs gRPC. Puede importar APIs gRPC vía server reflection.
  * [Lightly](https://www.lightly.ai/) — Mejora tus modelos de machine learning usando los datos correctos. Usa datasets de hasta 1.000 muestras gratis.
  * [LoginLlama](https://loginllama.app) - API de seguridad de inicio de sesión para detectar accesos fraudulentos y sospechosos y notificar a tus clientes. Gratis para 1.000 inicios de sesión al mes.
  * [MailboxValidator](https://www.mailboxvalidator.com) — Servicio de verificación de email usando conexión real al servidor de correo para confirmar emails válidos. El plan gratuito de API tiene 100 verificaciones al mes.
  * [Market Data API](https://www.marketdata.app) - Proporciona datos financieros en tiempo real e históricos para acciones, opciones, fondos mutuos y más. El nivel Free Forever de la API permite 100 solicitudes diarias de API sin coste.
  * [Meteosource Weather API](https://www.meteosource.com/) — API meteorológico global para datos meteorológicos actuales y pronosticados. Los pronósticos se basan en una combinación de modelos meteorológicos mediante aprendizaje automático para lograr una mejor precisión. El plan gratuito incluye 400 llamadas por día.
  * [microlink.io](https://microlink.io/) – Convierte cualquier sitio web en datos como normalización de metadatos, vistas previas de enlaces atractivas, capacidades de scraping o capturas de pantalla como servicio. 50 solicitudes por día, gratis todos los días.
  * [Mindee](https://developers.mindee.com) – Mindee es un software OCR potente y una plataforma API-first que ayuda a los desarrolladores a automatizar los flujos de trabajo de aplicaciones estandarizando la capa de procesamiento de documentos mediante el reconocimiento de datos clave usando visión por computadora y aprendizaje automático. El nivel gratuito ofrece 500 páginas por mes.
  * [Mintlify](https://mintlify.com) — Estándar moderno para documentación de APIs. Componentes UI hermosos y fáciles de mantener, búsqueda dentro de la aplicación y playground interactivo. Gratis para 1 editor.
  * [MockAPI](https://www.mockapi.io/) — MockAPI es una herramienta simple que te permite crear rápidamente APIs simuladas, generar datos personalizados y realizar operaciones usando una interfaz RESTful. MockAPI está pensado para prototipado, pruebas y aprendizaje. Un proyecto/2 recursos por proyecto gratis.
  * [Mockfly](https://www.mockfly.dev/) — Mockfly es una herramienta de desarrollo confiable para simulación de APIs y gestión de feature flags. Genera y controla APIs simuladas rápidamente con una interfaz intuitiva. El nivel gratuito ofrece 500 solicitudes por día.
  * [Mocki](https://mocki.io) - Una herramienta que te permite crear APIs simuladas GraphQL y REST sincronizadas con un repositorio de GitHub. Las APIs REST simples son gratuitas para desarrollar y usar sin registro.
  * [Mocko.dev](https://mocko.dev/) — Proxiza tu API, elige qué endpoints simular en la nube e inspecciona el tráfico, gratis. Acelera tu desarrollo y pruebas de integración.
  * [Mocky](https://designer.mocky.io/) - Una aplicación web sencilla para generar respuestas HTTP personalizadas para simular solicitudes HTTP. También disponible como [código abierto](https://github.com/julien-lafont/Mocky).
  * [Mock N Roll](https://mpcknroll.me/) - Servicio gratuito de Mocks API: una herramienta potente para simular respuestas reales de API sin demoras de backend. Perfecto para desarrolladores frontend, testers QA y equipos DevOps. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
  * [microenv.com](https://microenv.com) — Crea APIs REST falsas para desarrolladores con la posibilidad de generar código y una app en un contenedor docker.
  * [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — Herramienta gratuita y sencilla para verificar tu dirección IP de salida en múltiples nodos y entender cómo aparece tu IP en diferentes regiones y servicios globales. Útil para probar herramientas de división DNS basadas en reglas como Control D.
  * [Namekit](https://namekit.app/) - Descubrimiento de dominios impulsado por IA: encuentra nombres disponibles y de precio estándar al instante. Consultas diarias gratis.
  * [News API](https://newsapi.org) — Busca noticias en la web con código y obtén resultados en JSON. Los desarrolladores obtienen 100 consultas gratis cada día. Los artículos tienen un retraso de 24 horas.
  * [numlookupapi.com](https://numlookupapi.com) - API gratuita de validación de números de teléfono: 100 solicitudes gratuitas/mes.
  * [OCR.Space](https://ocr.space/) — Una API OCR que analiza imágenes y archivos PDF y devuelve los resultados de texto en formato JSON. 25,000 solicitudes por mes gratis y un límite de tamaño de archivo de 1MB.
  * [OpenAPI3 Designer](https://openapidesigner.com/) — Crea visualmente definiciones Open API 3 de forma gratuita.
  * [parsehub.com](https://parsehub.com/) — Extrae datos de sitios dinámicos, convierte sitios web dinámicos en APIs, cinco proyectos gratis.
  * [Parseur](https://parseur.com) — 20 páginas gratis/mes: Extrae datos de PDFs, emails. Impulsado por IA. Acceso completo a la API.
  * [PDFBolt](https://pdfbolt.com) - API de generación de PDFs enfocada en desarrolladores y diseñada pensando en la privacidad. Ofrece documentación inspirada en Stripe e incluye 500 conversiones de PDF gratis por mes.
  * [pdfEndpoint.com](https://pdfendpoint.com) - Convierte HTML o URLs a PDF fácilmente mediante una API. Cien conversiones por mes gratis.
  * [PDF-API.io](https://pdf-api.io) - API de automatización de PDF, editor visual de plantillas o conversión de HTML a PDF, integración de datos dinámicos y renderizado de PDF mediante API. El plan gratuito incluye una plantilla y 100 PDFs/mes.
  * [Pixela](https://pixe.la/) - Servicio gratuito de base de datos daystream. Todas las operaciones se realizan por API. También es posible la visualización con mapas de calor y gráficos de líneas.
  * [Postman](https://postman.com) — Simplifica los flujos de trabajo y crea mejores APIs más rápido con Postman, una plataforma de colaboración para el desarrollo de APIs. Usa la App de Postman gratis para siempre. Las funciones en la nube de Postman también son gratis para siempre con ciertos límites.
  * [Insomnia](https://insomnia.rest) - Cliente API de código abierto para diseñar y probar APIs, soporta REST y GraphQL.
  * [PrefectCloud](https://www.prefect.io/cloud/) — Plataforma completa para la automatización del flujo de datos. El plan gratuito incluye 5 flujos de trabajo desplegados y 500 minutos de créditos de computación sin servidor por mes.
  * [Preset Cloud](https://preset.io/) - Servicio alojado de Apache Superset. Gratis para equipos de hasta 5 usuarios, con dashboards y gráficos ilimitados, generador de gráficos sin código y editor colaborativo de SQL.
  * [PromptLoop](https://www.promptloop.com/) - PromptLoop ofrece scraping web con IA 10 veces más fácil, casi sin tiempo de adopción, ahorra más del 85% del tiempo en flujos de trabajo existentes y opera 4 veces más rápido que la investigación manual sin compromisos, e incluye un endpoint API REST para todas las tareas de investigación. Los primeros 1,000 créditos son gratis cada mes.
  * [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — Una lista de APIs públicas gratuitas.
  * [Rapidapi](https://rapidapi.com/) - El mayor hub de APIs del mundo. Millones de desarrolladores encuentran y conectan con miles de APIs, desarrollo de APIs usando retos divertidos (¡con soluciones!) y ejemplos interactivos.
  * [RequestBin.com](https://requestbin.com) — Crea un endpoint gratuito al que puedes enviar solicitudes HTTP. Cualquier solicitud HTTP enviada a ese endpoint será registrada con la carga útil y cabeceras asociadas, para que puedas observar recomendaciones de webhooks y otros servicios.
  * [reqres.in](https://reqres.in) - REST-API gratuita alojada lista para responder a tus solicitudes AJAX.
  * [Roboflow](https://roboflow.com) - Crea y despliega un modelo de visión por computadora personalizado sin experiencia previa en machine learning. El nivel gratuito incluye 30 créditos por mes.
  * [ROBOHASH](https://robohash.org/) - Servicio web para generar imágenes únicas y geniales a partir de cualquier texto.
  * [Scraper's Proxy](https://scrapersproxy.com) — API proxy HTTP sencilla para scraping. Haz scraping de forma anónima sin preocuparte por restricciones, bloqueos o captchas. Primeros 100 scrapes exitosos por mes gratis, incluido renderizado de javascript (más disponibles si contactas con soporte).
  * [ScrapingAnt](https://scrapingant.com/) — API de scraping con Chrome sin cabeza y servicio de proxies verificados gratis. Renderizado de JavaScript, proxies rotativos premium, evita CAPTCHAs. 10,000 créditos API gratuitos.
  * [Simplescraper](https://simplescraper.io) — Activa tu webhook después de cada operación. El plan gratuito incluye 100 créditos de scrape en la nube.
  * [Select Star](https://www.selectstar.com/) - Plataforma inteligente de descubrimiento de datos que analiza y documenta automáticamente tus datos. Nivel gratuito light con 2 fuentes de datos, hasta 1,000 tablas y 25 usuarios.
  * [Sheetson](https://sheetson.com) - Convierte al instante cualquier Google Sheets en una API RESTful. Plan gratuito disponible, incluyendo 1,000 filas gratis por hoja.
  * [Shipyard](https://www.shipyardapp.com) — Plataforma de orquestación de datos low-code para la nube. Construye con plantillas low-code y tu propio código (Python, Node.js, Bash, SQL). Nuestro plan gratuito para desarrolladores ofrece 10 horas de tiempo de ejecución cada mes para un usuario, suficiente para automatizar múltiples flujos de trabajo.
  * [Siterelic](https://siterelic.com/) - La API de Siterelic te permite tomar capturas de pantalla, auditar sitios web, escanear TLS, buscar DNS, probar TTFB y más. El plan gratuito ofrece 100 solicitudes API por mes.
  * [SerpApi](https://serpapi.com/) - API de scraping de motores de búsqueda en tiempo real. Devuelve resultados estructurados en JSON para Google, YouTube, Bing, Baidu, Walmart y muchas otras máquinas. El plan gratuito incluye 100 llamadas API exitosas por mes.
  * [SmartParse](https://smartparse.io) - SmartParse es una plataforma de migración de datos y de CSV a API que ofrece herramientas de desarrollo para ahorrar tiempo y costos. El nivel gratuito incluye 300 unidades de procesamiento por mes, cargas en navegador, cuarentena de datos, interruptores de circuito y alertas de trabajo.
  * [Sofodata](https://www.sofodata.com/) - Crea APIs RESTful seguras a partir de archivos CSV. Sube un archivo CSV y accede instantáneamente a los datos vía API permitiendo un desarrollo de aplicaciones más rápido. El plan gratuito incluye 2 APIs y 2,500 llamadas API por mes. No necesitas tarjeta de crédito.
  * [Sqlable](https://sqlable.com/) - Colección de herramientas SQL online gratuitas, incluyendo formateador y validador SQL, tester de expresiones regulares SQL, generador de datos falsos y playgrounds interactivos de bases de datos.
  * [Stoplight](https://stoplight.io/) - SaaS para diseñar y documentar APIs de forma colaborativa. El plan gratuito ofrece herramientas gratuitas de diseño, simulación y documentación.
  * [Supportivekoala](https://supportivekoala.com/) — Permite autogenerar imágenes a partir de tu entrada mediante plantillas. El plan gratuito permite crear hasta 50 imágenes por mes.
  * [Svix](https://www.svix.com/) - Webhooks como servicio. Envía hasta 50,000 mensajes/mes gratis.
  * [Tavily AI](https://tavily.com/) - API para búsqueda online e insights rápidos e investigación integral, con capacidad de organización de los resultados de investigación. 1,000 solicitudes/mes en el nivel gratuito sin necesidad de tarjeta de crédito.
  * [The IP API](https://theipapi.com/) - API de geolocalización de IP con 1,000 solicitudes gratis/día. Proporciona información sobre la ubicación de una dirección IP, incluyendo país, ciudad, región y más.
  * [TinyMCE](https://www.tiny.cloud) - API de edición de texto enriquecido. Las funciones principales son gratis para uso ilimitado.
  * [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - Ofrece plan gratuito de API meteorológica. Proporciona pronósticos precisos y actualizados con cobertura global, datos históricos y soluciones de monitoreo meteorológico.
  * [Treblle](https://www.treblle.com) - Treblle ayuda a los equipos a construir, lanzar y gobernar APIs. Con agregación avanzada de logs de API, observabilidad, documentación y depuración. Obtienes todas las funciones gratis, pero hay un límite de hasta 250,000 solicitudes por mes en el nivel gratuito.
  * [UniRateAPI](https://unirateapi.com) – Tasas de cambio en tiempo real para más de 590 monedas y criptomonedas. Llamadas API ilimitadas en el plan gratuito, perfecto para desarrolladores y apps de finanzas.
  * [vatcheckapi.com](https://vatcheckapi.com) - API simple y gratuita de validación de números de IVA. 150 validaciones gratuitas por mes.
  * [WeatherXu](https://weatherxu.com/) — Datos meteorológicos globales incluyendo condiciones actuales, pronósticos horarios y diarios, y alertas meteorológicas vía API. Integra modelos de IA y sistemas de ML para analizar y combinar múltiples modelos meteorológicos y ofrecer mayor precisión en los pronósticos. El nivel gratuito incluye 10,000 llamadas API/mes.
  * [Webhook Store](https://www.openwebhook.io) - Herramienta para almacenar webhooks de terceros y depurarlos en localhost (estilo ngrok). Open source y autoalojable. Dominio personal gratuito *username*.github.webhook.store, dominios públicos gratuitos *anything*.webhook.store.
  * [WebScraping.AI](https://webscraping.ai) - API simple de Web Scraping con parsing integrado, renderizado Chrome y proxies. Dos mil llamadas API gratuitas al mes.
  * [Weights & Biases](https://wandb.ai) — Plataforma MLOps orientada a desarrolladores. Construye mejores modelos más rápido con seguimiento de experimentos, versionado de datasets y gestión de modelos. Nivel gratuito solo para proyectos personales, con 100 GB de almacenamiento incluidos.
  * [What The Diff](https://whatthediff.ai) - Asistente de revisión de código impulsado por IA. El plan gratuito tiene un límite de 25,000 tokens mensuales (~10 PRs).
  * [wolfram.com](https://wolfram.com/language/) — Algoritmos integrados basados en conocimiento en la nube.
  * [wrapapi.com](https://wrapapi.com/) — Convierte cualquier sitio web en una API parametrizada. 30,000 llamadas API al mes.
  * [Zenscrape](https://zenscrape.com/web-scraping-api) — API de scraping web con navegadores sin cabeza, IPs residenciales y precios directos. Mil llamadas API gratis al mes y créditos extra para estudiantes y ONGs.
  * [Zipcodebase](https://zipcodebase.com) - API gratuita de códigos postales, acceso a datos de códigos postales a nivel mundial. 5,000 solicitudes gratuitas/mes.
  * [Zipcodestack](https://zipcodestack.com) - API gratuita de códigos postales y validación de códigos postales. Diez mil solicitudes gratuitas/mes.
  * [Zuplo](https://zuplo.com/) - Plataforma gratuita de gestión de APIs para diseñar, construir y desplegar APIs en el Edge. Añade autenticación con API Key, limitación de tasas, documentación para desarrolladores y monetización a cualquier API en minutos. Nativo OpenAPI y totalmente programable con APIs web estándar y Typescript. El plan gratuito ofrece hasta 10 proyectos, entornos edge de producción ilimitados, 1M de solicitudes mensuales y 10GB de salida.

**[⬆️ Volver al inicio](#table-of-contents)**

## Repositorios de Artefactos

  * [Artifactory](https://jfrog.com/start-free/) - Un repositorio de artefactos que soporta numerosos formatos de paquetes como Maven, Docker, Cargo, Helm, PyPI, CocoaPods y GitLFS. Incluye la herramienta de escaneo de paquetes XRay y la herramienta de CI/CD Pipelines (anteriormente Shippable) con un nivel gratuito de 2,000 minutos CI/CD por mes.
  * [central.sonatype.org](https://central.sonatype.org) — El repositorio de artefactos por defecto para Apache Maven, SBT y otros sistemas de build.
  * [cloudrepo.io](https://cloudrepo.io) - Repositorios Maven y PyPi en la nube, privados y públicos. Gratis para proyectos de código abierto.
  * [cloudsmith.io](https://cloudsmith.io) — Servicio de repositorio centralizado, seguro y sencillo para Java/Maven, RedHat, Debian, Python, Ruby, Vagrant y más. Nivel gratuito + gratis para open source.
  * [jitpack.io](https://jitpack.io/) — Repositorio Maven para proyectos JVM y Android en GitHub, gratis para proyectos públicos.
  * [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Hosting de repositorios fácil de usar para paquetes Maven, RPM, DEB, PyPi, NPM y RubyGem (tiene nivel gratuito).
  * [repsy.io](https://repsy.io) — 1 GB de repositorio Maven privado/público gratis.
  * [Gemfury](https://gemfury.com) — Repositorios de artefactos privados y públicos para Maven, PyPi, NPM, Go Module, Nuget, APT y RPM. Gratis para proyectos públicos.
  * [paperspace](https://www.paperspace.com/) — Construye y escala modelos de IA, desarrolla, entrena y despliega aplicaciones de IA, plan gratuito: proyectos públicos, 5Gb de almacenamiento, instancias básicas.
  * [RepoForge](https://repoforge.io) - Repositorio privado en la nube para paquetes Python, Debian, NPM y registros Docker. Plan gratuito para proyectos open source/públicos.
  * [RepoFlow](https://repoflow.io) - RepoFlow simplifica la gestión de paquetes con soporte para npm, PyPI, Docker, Go, Helm y más. Pruébalo gratis con 10GB de almacenamiento, 10GB de ancho de banda, 100 paquetes y usuarios ilimitados en la nube, o autoalojado solo para uso personal.

**[⬆️ Volver al inicio](#table-of-contents)**

## Herramientas para Equipos y Colaboración
  * [3Cols](https://3cols.com/) - Un gestor de fragmentos de código en la nube gratuito para uso personal y colaborativo.
  * [Bitwarden](https://bitwarden.com) — La manera más fácil y segura para que individuos, equipos y organizaciones almacenen, compartan y sincronicen datos sensibles.
  * [Braid](https://www.braidchat.com/) — App de chat diseñada para equipos. Gratis para grupos de acceso público, usuarios ilimitados, historial e integraciones. También ofrece una versión open source autoalojable.
  * [cally.com](https://cally.com/) — Encuentra el momento y la fecha perfecta para una reunión. Fácil de usar, funciona muy bien para grupos pequeños y grandes.
  * [Calendly](https://calendly.com) — Calendly es la herramienta para conectar y agendar reuniones. El plan gratuito proporciona 1 conexión de calendario por usuario y sesiones ilimitadas. También se ofrecen aplicaciones de escritorio y móviles.
  * [Discord](https://discord.com/) — Chatea en salas públicas/privadas. Texto en Markdown, voz, vídeo y capacidades de compartir pantalla. Gratis para usuarios ilimitados.
  * [Fibo](https://fibo.dev) - Herramienta gratuita en línea de scrum poker en tiempo real para equipos ágiles que permite a miembros ilimitados estimar puntos de historia para una planificación más rápida.
  * [Telegram](https://telegram.org/) — Telegram es para todos los que quieren mensajería y llamadas rápidas y confiables. Los usuarios de negocios y equipos pequeños pueden aprovechar los grupos grandes, nombres de usuario, apps de escritorio y potentes opciones para compartir archivos.
  * [DevToolLab](https://devtoollab.com) — Herramientas de desarrollo online que ofrecen acceso gratuito a todas las herramientas básicas, con la posibilidad de guardar automáticamente una entrada por herramienta, velocidad de procesamiento estándar y soporte comunitario.
  * [Dubble](https://dubble.so/) — Creador gratuito de guías paso a paso. Toma capturas de pantalla, documenta procesos y colabora con tu equipo. También soporta grabación de pantalla asíncrona.
  * [Duckly](https://duckly.com/) — Habla y colabora en tiempo real con tu equipo. Pair programming con IDE, compartición de terminal, voz, vídeo y pantalla. Gratis para equipos pequeños.
  * [Dyte](https://dyte.io) - El SDK de audio y video en vivo más amigable para desarrolladores, con plugins colaborativos para aumentar la productividad y el compromiso. El nivel gratuito incluye 10,000 minutos mensuales de uso de video/audio en vivo.
  * [evernote.com](https://evernote.com/) — Herramienta para organizar información. Comparte tus notas y trabaja en equipo.
  * [Fibery](https://fibery.io/) — Plataforma de espacio de trabajo conectado. Gratis para usuarios individuales, hasta 2 GB de espacio en disco.
  * [flock.com](https://flock.com) — Una forma más rápida para que tu equipo se comunique. Mensajes, canales, usuarios, aplicaciones e integraciones ilimitadas gratis.
  * [Gather](https://www.gather.town/) - Una mejor manera de reunirse en línea. Centrado en espacios totalmente personalizables, Gather hace que pasar tiempo con tus comunidades sea tan fácil como en la vida real. Gratis hasta 10 usuarios concurrentes.
  * [gokanban.io](https://gokanban.io) - Tablero Kanban basado en sintaxis, sin registro para uso rápido. Gratis sin limitaciones.
  * [flat.social](https://flat.social) - Espacios interactivos personalizables para reuniones de equipo y eventos sociales. Reuniones ilimitadas, gratis hasta 8 usuarios concurrentes.
  * [GitDailies](https://gitdailies.com) - Informes diarios de la actividad de Commits y Pull Requests de tu equipo en GitHub. Incluye visualizador de Push, sistema de reconocimiento entre pares y constructor de alertas personalizado. El plan gratuito permite usuarios ilimitados, tres repositorios y 3 configuraciones de alertas.
  * [gitter.im](https://gitter.im/) — Chat para GitHub. Salas públicas y privadas ilimitadas, gratis para equipos de hasta 25 usuarios.
  * [Hackmd.io](https://hackmd.io/) - Herramienta de colaboración y escritura en tiempo real para documentos/archivos en formato markdown. Como Google Docs, pero para archivos markdown. Número ilimitado de "notas" gratis, pero el número de colaboradores (invitados) para notas privadas y plantillas [será limitado](https://hackmd.io/pricing).
  * [hangouts.google.com](https://hangouts.google.com/) — Un solo lugar para todas tus conversaciones, gratis, necesitas una cuenta de Google.
  * [HeySpace](https://hey.space) - Herramienta de gestión de tareas con chat, calendario, línea de tiempo y videollamadas. Gratis hasta 5 usuarios.
  * [helplightning.com](https://www.helplightning.com/) — Asistencia por video con realidad aumentada. Gratis sin analíticas, cifrado ni soporte.
  * [ideascale.com](https://ideascale.com/) — Permite a los clientes enviar ideas y votar, gratis para 25 miembros en 1 comunidad.
  * [Igloo](https://www.igloosoftware.com/) — Portal interno para compartir documentos, blogs, calendarios, etc. Gratis hasta 10 usuarios.
  * [Keybase](https://keybase.io/) — Keybase es una alternativa FOSS a Slack; mantiene seguros los chats y archivos de todos, desde familias hasta comunidades y empresas.
  * [Google Meet](https://meet.google.com/) — Utiliza Google Meet para las necesidades de reuniones de video en línea de tu empresa. Meet ofrece reuniones en línea seguras y fáciles de unir.
  * [/meet for Slack](https://meetslack.com) - Inicia reuniones de Google directamente desde Slack usando /meet en cualquier canal, grupo o DM. Gratis sin limitaciones.
  * [Livecycle](https://www.livecycle.io/) — Livecycle es una plataforma de colaboración inclusiva que facilita los flujos de trabajo para equipos de producto multifuncionales y proyectos de código abierto.
  * [Lockitbot](https://www.lockitbot.com/) — Reserva y bloquea recursos compartidos dentro de Slack como salas, entornos de desarrollo, servidores, etc. Gratis hasta 2 recursos.
  * [MarkUp](https://www.markup.io/) — MarkUp te permite recopilar comentarios directamente sobre tus sitios web, PDFs e imágenes.
  * [Proton Pass](https://proton.me/pass) — Gestor de contraseñas con alias de correo integrados, autenticador 2FA, uso compartido y passkeys. Disponible en web, extensión de navegador, app móvil y escritorio.
  * [Visual Debug](https://visualdebug.com) - Herramienta visual de feedback para mejorar la comunicación cliente-desarrollador.
  * [meet.jit.si](https://meet.jit.si/) — Videoconferencias y compartir pantalla con un solo clic, gratis.
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — Microsoft Teams es un centro digital basado en chat que reúne conversaciones, contenido y aplicaciones en un solo lugar y experiencia. Gratis hasta 500k usuarios.
  * [Miro](https://miro.com/) - Pizarra colaborativa escalable, segura, multiplataforma y lista para empresas para equipos distribuidos. Con plan freemium.
  * [nootiz](https://www.nootiz.com/) - Herramienta para recopilar y gestionar feedback visual en cualquier sitio web.
  * [Notion](https://www.notion.so/) - Notion es una aplicación de toma de notas y colaboración con soporte para markdown que integra tareas, wikis y bases de datos. La empresa describe la app como un espacio de trabajo todo en uno para notas, gestión de proyectos y tareas. Además de apps multiplataforma, se puede acceder vía la mayoría de navegadores web.
  * [Nuclino](https://www.nuclino.com) - Wiki ligera y colaborativa para el conocimiento, documentos y notas del equipo. Plan gratuito con todas las funciones esenciales, hasta 50 elementos y 5GB de almacenamiento.
  * [OnlineInterview.io](https://onlineinterview.io/) - Plataforma gratuita para entrevistas de código con videochat integrado, pizarra y editor de código online donde puedes compilar y ejecutar tu código en el navegador. Puedes crear una sala de entrevista remota con un solo clic.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - Aplicación simple de hojas de tiempo y seguimiento de tiempo para equipos. El plan gratuito permite seguimiento de tiempo y generación de informes para hasta 10 usuarios.
  * [PageShare.dev](https://www.pageshare.dev) - Añade capacidades de revisión visual a los Pull Requests de GitHub sin necesidad de desplegar sitios web. Gratis hasta 10 páginas al mes y 100MB de almacenamiento en total.
  * [Pendulums](https://pendulums.io/) - Pendulums es una herramienta gratuita de seguimiento de tiempo que ayuda a gestionar tu tiempo de manera más eficiente con una interfaz fácil de usar y estadísticas valiosas.
  * [Pumble](https://pumble.com) - App gratuita de chat para equipos. Usuarios y historial de mensajes ilimitados, gratis para siempre.
  * [Raindrop.io](https://raindrop.io) - App privada y segura de marcadores para macOS, Windows, Android, iOS y Web. Marcadores y colaboración ilimitados gratis.
  * [element.io](https://element.io/) — Herramienta de comunicación descentralizada y open-source construida sobre Matrix. Chats grupales, mensajes directos, transferencias de archivos cifradas, chats de voz y video, e integración fácil con otros servicios.
  * [Rocket.Chat](https://rocket.chat/) - Plataforma de comunicación open-source con características Omnicanal, Federación Matrix, Puente con otras apps, mensajería ilimitada e historial completo.
  * [seafile.com](https://www.seafile.com/) — Almacenamiento privado o en la nube, compartición de archivos, sincronización y discusiones. La versión en la nube solo ofrece 1 GB.
  * [Sema](https://www.semasoftware.com/) - Herramienta gratuita de portafolio para desarrolladores que consolida y toma capturas de contribuciones en varios repositorios en un solo informe.
  * [Screen Sharing via Browser](https://screensharing.net) - Herramienta gratuita para compartir pantalla, comparte tu pantalla con colaboradores directamente desde el navegador, sin descargas ni registros. Gratis.
  * [Slab](https://slab.com/) — Servicio moderno de gestión de conocimiento para equipos. Gratis hasta 10 usuarios.
  * [slack.com](https://slack.com/) — Gratis para usuarios ilimitados con algunas limitaciones de funciones.
  * [Spectrum](https://spectrum.chat/) - Crea comunidades públicas o privadas gratis.
  * [StatusPile](https://www.statuspile.com/) - Una página de estado de páginas de estado. ¿Puedes rastrear las páginas de estado de tus proveedores upstream?
  * [Stickies](https://stickies.app/) - App de colaboración visual para lluvias de ideas, curación de contenido y notas. Gratis hasta 3 Muros, usuarios ilimitados y 1 GB de almacenamiento.
  * [Stacks](https://betterstacks.com/) - Espacio de trabajo de contenido con notas, enlaces y almacenamiento de archivos integrados para navegar la sobrecarga de información. Plan personal gratis para siempre.
  * [talky.io](https://talky.io/) — Videollamadas grupales gratuitas. Anónimo. Peer‑to‑peer. Sin plugins, registro ni pagos requeridos.
  * [Teamhood](https://teamhood.com/) - Software gratuito de gestión de proyectos, tareas e incidencias. Soporta Kanban con Swimlanes e implementación completa de Scrum. Incluye seguimiento de tiempo. Gratis para cinco usuarios y tres portafolios de proyectos.
  * [Teamplify](https://teamplify.com) - Mejora los procesos de desarrollo de equipo con Analíticas de Equipo y Daily Standup Inteligente. Incluye gestión completa de ausencias para equipos remote-first. Gratis para grupos pequeños de hasta 5 usuarios.
  * [Tefter](https://tefter.io) - Aplicación de marcadores con una potente integración con Slack. Gratis para equipos open-source.
  * [TeleType](https://teletype.oorja.io/) — Comparte terminales, voz, código, pizarra y más. No requiere inicio de sesión para colaboración cifrada de extremo a extremo para desarrolladores.
  * [TimeCamp](https://www.timecamp.com/) - Software gratuito de seguimiento de tiempo para usuarios ilimitados. Fácil integración con herramientas de PM como Jira, Trello, Asana, etc.
  * [Huly](https://huly.io/) - Plataforma de gestión de proyectos todo en uno (alternativa a Linear, Jira, Slack, Notion, Motion): usuarios ilimitados, 10GB de almacenamiento por espacio de trabajo, 10GB de tráfico de video(audio).
  * [Teamcamp](https://www.teamcamp.app) - Aplicación de gestión de proyectos todo en uno para empresas de desarrollo de software.
  * [twist.com](https://twist.com) — Aplicación de comunicación para equipos amigable con la asincronía donde las conversaciones se mantienen organizadas y en tema. Hay planes Gratuito e Ilimitado. Se ofrecen descuentos para equipos elegibles.
  * [tldraw.com](https://tldraw.com) — Herramienta gratuita y open-source de pizarras y diagramas con flechas inteligentes, ajuste, notas adhesivas y exportación SVG. Modo multijugador para edición colaborativa. Extensión oficial gratuita para VS Code también disponible.
  * [BookmarkOS.com](https://bookmarkos.com) - Gestor de marcadores todo en uno, gestor de pestañas y tareas en un escritorio online personalizable con colaboración por carpetas. Gratis.
  * [typetalk.com](https://www.typetalk.com/) — Comparte y discute ideas con tu equipo a través de mensajería instantánea en la web o en tu móvil.
  * [Tugboat](https://tugboat.qa) - Previsualiza cada pull request, automatizado y bajo demanda. Gratis para todos, nivel Nano gratuito para ONGs.
  * [whereby.com](https://whereby.com/) — Videoconferencias con un solo clic, gratis (anteriormente conocido como appear.in).
  * [windmill.dev](https://windmill.dev/) - Windmill es una plataforma open-source para desarrolladores para construir rápidamente automatizaciones de múltiples pasos y apps internas de grado producción a partir de scripts mínimos en Python y Typescript. Como usuario gratuito, puedes crear y ser miembro de hasta tres espacios de trabajo no premium.
  * [vadoo.tv](https://vadoo.tv/) — Hosting y marketing de videos simplificados. Sube videos con un solo clic. Graba, administra, comparte y más. El plan gratuito permite hasta 10 videos, 1 GB de almacenamiento y 10 GB de ancho de banda/mes.
  * [userforge.com](https://userforge.com/) - Personas online interconectadas, historias de usuario y mapeo de contexto. Ayuda a mantener diseño y desarrollo sincronizados, gratis hasta 3 personas y dos colaboradores.
  * [wistia.com](https://wistia.com/) — Hosting de videos con analíticas de visualización, entrega HD y herramientas de marketing para entender a tus visitantes, 25 videos y reproductor con marca Wistia.
  * [wormhol.org](https://www.wormhol.org/) — Servicio sencillo para compartir archivos. Comparte archivos ilimitados de hasta 5GB con tantos usuarios como desees.
  * [Wormhole](https://wormhole.app/) - Comparte archivos de hasta 5GB con cifrado de extremo a extremo durante hasta 24 horas. Para archivos de más de 5 GB, utiliza transferencia peer-to-peer para enviar tus archivos directamente.
  * [zoom.us](https://zoom.us/) — Videoconferencias y conferencias web seguras con complementos disponibles. El plan gratuito está limitado a 40 minutos.
  * [Zulip](https://zulip.com/) — Chat en tiempo real con un modelo de hilos único similar al correo electrónico. El plan gratuito incluye 10,000 mensajes de historial de búsqueda y almacenamiento de archivos hasta 5 GB. Además, ofrece una versión open-source auto hospedable.
  * [robocorp.com](https://robocorp.com) - Stack open-source para potenciar Automation Ops. Prueba las funciones en la nube e implementa automatización simple gratis. Trabajo de robot 240 min/mes, 10 ejecuciones de Asistente, 100 MB de almacenamiento.
  * [Fleep.io](https://fleep.io/) — Fleep, una alternativa a Slack. Tiene un plan gratuito para equipos pequeños con historial completo de mensajes, conversaciones ilimitadas 1:1, 1 conversación grupal y 1 GB de almacenamiento de archivos.
  * [Chanty.com](https://chanty.com/) — Chanty es otra alternativa a Slack. Plan gratis para siempre para equipos pequeños (hasta 10) con conversaciones públicas y privadas ilimitadas, historial de búsqueda, llamadas 1:1 ilimitadas, mensajes de voz ilimitados, diez integraciones y 20 GB de almacenamiento por equipo.
  * [ruttl.com](https://ruttl.com/) — La mejor herramienta de feedback todo en uno para recopilar comentarios digitales y revisar sitios web, PDFs e imágenes.
  * [Mattermost](https://mattermost.com/) — Colaboración segura para equipos técnicos. Plan gratuito con canales, playbooks, tableros, usuarios ilimitados, 10GB de almacenamiento y más.
  * [Webvizio](https://webvizio.com) — Herramienta de feedback de sitios web, software de revisión de sitios y reporte de bugs para agilizar la colaboración en desarrollo web directamente sobre sitios y apps en vivo, imágenes, PDFs y archivos de diseño.
  * [Pullflow](https://pullflow.com) — Pullflow ofrece una plataforma mejorada con IA para colaboración en revisión de código en GitHub, Slack y VS Code.
  * [Webex](https://www.webex.com/) — Videoreuniones con plan gratuito que ofrece 40 minutos por reunión con hasta 100 asistentes.
  * [RingCentral](https://www.ringcentral.com/) — Videoreuniones con plan gratuito que ofrece 50 minutos por reunión con hasta 100 participantes.
  * [GitBook](https://www.gitbook.com/) — Plataforma para capturar y documentar conocimiento técnico — desde docs de producto hasta bases de conocimiento internas y APIs. Plan gratuito para desarrolladores individuales.
  * [transfernow](https://www.transfernow.net/) — Interfaz más simple, rápida y segura para transferir y compartir archivos. Envía fotos, videos y otros archivos grandes sin suscripción obligatoria.
  * [paste.sh](https://paste.sh/) — Sitio simple de pegado basado en JavaScript y Crypto.
  * [Revolt.chat](https://revolt.chat/) — Una alternativa OpenSource a [Discord](https://discord.com/), que respeta tu privacidad. También tiene la mayoría de funciones propietarias de Discord gratis. Revolt es una aplicación todo en uno, segura y rápida, 100% gratis. Todas las funciones son gratuitas. También cuenta con soporte para plugins (oficiales y no oficiales) a diferencia de la mayoría de las apps de chat convencionales.
  * [Tencent RTC](https://trtc.io/) — Tencent Real-Time Communication (TRTC) ofrece soluciones para llamadas grupales de audio/video. 10,000 minutos gratis/mes durante el primer año.
  * [Pastefy](https://pastefy.app/) - Pastebin bonito y simple con cifrado opcional en el cliente, pastes multitab, API, editor resaltado y más.
  * [SiteDots](https://sitedots.com/) - Comparte feedback para proyectos web directamente en tu sitio, sin emulación, canvas ni soluciones alternativas. Nivel gratuito completamente funcional.

**[⬆️ Volver al inicio](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Hosting para sitios Drupal. Nivel gratuito para desarrolladores. También disponibles herramientas de desarrollo gratis (como Acquia Dev Desktop).
  * [Contentful](https://www.contentful.com/) — CMS sin cabeza. APIs de gestión y entrega de contenido en la nube. Incluye un espacio Community gratuito con cinco usuarios, 25K registros, 48 tipos de contenido, 2 idiomas.
  * [Cosmic](https://www.cosmicjs.com/) — CMS sin cabeza y kit de herramientas API. Planes personales gratuitos para desarrolladores.
  * [Crystallize](https://crystallize.com) — PIM sin cabeza con soporte para ecommerce. API GraphQL integrada. La versión gratuita incluye usuarios ilimitados, 1000 artículos de catálogo, 5 GB/mes de ancho de banda y 25k/mes de llamadas a la API.
  * [DatoCMS](https://www.datocms.com/) - Ofrece plan gratuito para proyectos pequeños. DatoCMS es un CMS basado en GraphQL. En el nivel básico tienes 100k llamadas/mes.
  * [Directus](https://directus.io) — CMS sin cabeza. Plataforma completamente gratuita y open-source para gestionar activos y contenido de bases de datos en local o en la nube. Sin limitaciones ni muros de pago.
  * [FrontAid](https://frontaid.io/) — CMS sin cabeza que almacena contenido JSON directamente en tu repositorio Git. Sin restricciones.
  * [kontent.ai](https://www.kontent.ai) - Plataforma Content-as-a-Service que ofrece todos los beneficios de un CMS sin cabeza, empoderando al mismo tiempo a los marketers. El plan para desarrolladores ofrece dos usuarios con proyectos ilimitados, dos entornos para cada uno, 500 elementos de contenido, dos idiomas con API de entrega y gestión, y soporte para elementos personalizados. Puedes usar planes más detallados según tus necesidades.
  * [Prismic](https://www.prismic.io/) — CMS sin cabeza. Interfaz de gestión de contenido con API completamente alojada y escalable. El plan Community permite llamadas API ilimitadas, documentos, tipos personalizados, activos e idiomas para un usuario. Todo lo que necesitas para tu próximo proyecto. Hay planes gratuitos más grandes para proyectos de Open Content/Open Source.
  * [Sanity.io](https://www.sanity.io/) - Plataforma para contenido estructurado con entorno de edición open-source y almacenamiento de datos en tiempo real alojado. Proyectos ilimitados. Usuarios admin ilimitados, tres usuarios no admin, dos datasets, 500K solicitudes de API CDN, 10GB de ancho de banda y 5GB de activos incluidos gratis por proyecto.
  * [sensenet](https://sensenet.com) - CMS sin cabeza orientado a API, brindando soluciones de nivel empresarial para empresas de todos los tamaños. El plan Developer ofrece tres usuarios, 500 elementos de contenido, tres roles integrados, 25+5 tipos de contenido, API REST totalmente accesible, generación de vistas previas de documentos y edición en Office Online.
  * [TinaCMS](https://tina.io/) — Reemplazo de Forestry.io. CMS sin cabeza open-source respaldado por Git que soporta Markdown, MDX y JSON. La oferta básica es gratis con dos usuarios disponibles.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - Gatsby es el framework rápido y flexible que hace divertido construir sitios web con cualquier CMS, API o base de datos. ¡Construye y despliega sitios sin cabeza que atraigan más tráfico, conviertan mejor y generen más ingresos!
  * [Hygraph](https://hygraph.com/) - Ofrece plan gratuito para proyectos pequeños. API primero en GraphQL. Pásate de soluciones heredadas al CMS sin cabeza nativo en GraphQL y entrega API omnicanal primero.
  * [Squidex](https://squidex.io/) - Ofrece un nivel gratuito para proyectos pequeños. API / GraphQL primero. Código abierto y basado en event sourcing (versiona cada cambio automáticamente).
  * [InstaWP](https://instawp.com/) - Lanza un sitio de WordPress en unos segundos. Un nivel gratuito con 5 sitios activos, 500 MB de espacio y expiración del sitio en 48 horas.
  * [Storyblok](https://www.storyblok.com) - Un CMS Headless para desarrolladores y marketers que funciona con todos los frameworks modernos. El nivel Community (gratuito) ofrece API de gestión, editor visual, diez fuentes, tipos de campo personalizados, internacionalización (idiomas/locales ilimitados), gestor de activos (hasta 2500 activos), servicio de optimización de imágenes, consultas de búsqueda, Webhook + 250GB de tráfico/mes incluidos.
  * [WPJack](https://wpjack.com) - ¡Configura WordPress en cualquier nube en menos de 5 minutos! El nivel gratuito incluye 1 servidor, 2 sitios, certificados SSL gratuitos y cron jobs ilimitados. Sin límites de tiempo ni caducidad—tu web, a tu manera.

**[⬆️ Volver al inicio](#table-of-contents)**

## Generación de Código

  * [Appinvento](https://appinvento.io/) — AppInvento es un constructor de aplicaciones sin código gratuito. En el código backend generado automáticamente, los usuarios tienen acceso completo al código fuente y APIs y rutas ilimitadas, permitiendo una integración extensa. El plan gratuito incluye tres proyectos, cinco tablas y un complemento de Google.
  * [Cody AI](https://sourcegraph.com/cody) - Cody es un asistente de codificación con IA que utiliza inteligencia artificial y una comprensión profunda de tu código para ayudarte a escribir y entender código más rápido. Cody da a los desarrolladores la opción de elegir modelos LLM (incluida inferencia local), soporta varios IDEs, todos los lenguajes populares, y tiene un plan gratuito. El plan gratuito ofrece 20 mensajes de chat (usando Claude 3 Sonnet como LLM) y 500 autocompletados (usando Starcoder 16b) cada mes.
  * [DhiWise](https://www.dhiwise.com/) — Convierte diseños de Figma en aplicaciones dinámicas de Flutter y React de forma fluida con la innovadora tecnología de generación de código de DhiWise, optimizando tu flujo de trabajo y ayudándote a crear experiencias móviles y web excepcionales más rápido que nunca.
  * [Codeium](https://www.codeium.com/) — Codeium es una herramienta gratuita de autocompletado de código con IA. Soporta más de 20 lenguajes de programación (Python, JavaScript, Java, TypeScript, PHP, C/C++, Go, etc.) e integra con todos los IDEs web y de escritorio principales.
  * [Fern](https://buildwithfern.com) - Escribe definiciones de API y utilízalas para generar SDKs/bibliotecas cliente en lenguajes populares como TypeScript, Python, Java, Go y más. Soporte completo para OpenAPI. El nivel gratuito genera código para hasta 20 endpoints.
  * [Metalama](https://www.postsharp.net/metalama) - Solo para C#. Metalama genera el boilerplate del código sobre la marcha durante la compilación para que tu código fuente permanezca limpio. Es gratis para proyectos open source, y el nivel gratuito comercialmente amigable incluye tres aspectos.
  * [Supermaven](https://www.supermaven.com/) — Supermaven es un plugin rápido de autocompletado de código con IA para VSCode, JetBrains y Neovim. El nivel gratuito ofrece autocompletados en línea ilimitados.
  * [tabnine.com](https://www.tabnine.com/) — Tabnine ayuda a los desarrolladores a crear mejor software más rápido proporcionando ideas aprendidas de todo el código del mundo. Plugin disponible.
  * [v0.dev](https://v0.dev/) — v0 utiliza modelos de IA para generar código a partir de simples indicaciones de texto. Genera código React listo para copiar y pegar basado en shadcn/ui y Tailwind CSS que puedes usar en tus proyectos. Cada generación consume mínimo 30 créditos. Empiezas con 1200 créditos y recibes 200 créditos gratuitos cada mes.

**[⬆️ Volver al inicio](#table-of-contents)**

## Calidad de Código

  * [beanstalkapp.com](https://beanstalkapp.com/) — Un flujo de trabajo completo para escribir, revisar y desplegar código, una cuenta gratuita para un usuario y un repositorio con 100 MB de almacenamiento.
  * [browserling.com](https://www.browserling.com/) — Pruebas interactivas en vivo de compatibilidad de navegadores, solo 3 minutos de sesión gratuitos con MS IE 9 bajo Vista a 1024 x 768 de resolución.
  * [codacy.com](https://www.codacy.com/) — Revisiones automatizadas de código para PHP, Python, Ruby, Java, JavaScript, Scala, CSS y CoffeeScript, gratis para repositorios públicos y privados ilimitados.
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - Herramienta automatizada de revisión de Infrastructure as Code para DevOps que se integra con GitHub, Bitbucket y GitLab (incluso autohospedado). Además de los lenguajes estándar, también analiza Ansible, Terraform, CloudFormation, Kubernetes y más. (gratuito open source)
  * [CodeBeat](https://codebeat.co) — Plataforma de revisión de código automatizada disponible para muchos lenguajes. Gratis para siempre para repositorios públicos con integración con Slack y correo electrónico.
  * [codeclimate.com](https://codeclimate.com/) — Revisión de código automatizada, gratis para Open Source y repositorios privados de organizaciones ilimitados (hasta 4 colaboradores). También gratuito para estudiantes e instituciones.
  * [codecov.io](https://codecov.io/) — Herramienta de cobertura de código (SaaS), gratis para Open Source y un repo privado gratis.
  * [CodeFactor](https://www.codefactor.io) — Revisión de código automatizada para Git. La versión gratuita incluye usuarios ilimitados, repositorios públicos y un repo privado.
  * [coderabbit.ai](https://coderabbit.ai) — Herramienta de revisión de código con IA que se integra con GitHub/GitLab. El nivel gratuito incluye 200 archivos/hora, 3 revisiones por hora y 50 conversaciones/hora. Gratis para siempre para proyectos open source.
  * [codescene.io](https://codescene.io/) - CodeScene prioriza la deuda técnica en función de cómo los desarrolladores trabajan con el código y visualiza factores organizacionales como el acoplamiento de equipos y el dominio del sistema. Gratis para Open Source.
  * [CodSpeed](https://codspeed.io) - Automatiza el seguimiento de rendimiento en tus pipelines de CI. Detecta regresiones de rendimiento antes del despliegue, gracias a métricas precisas y consistentes. Gratis para siempre para proyectos Open Source.
  * [coveralls.io](https://coveralls.io/) — Muestra informes de cobertura de pruebas, gratis para Open Source.
  * [dareboost](https://dareboost.com) - 5 informes de análisis gratuitos al mes para rendimiento web, accesibilidad y seguridad.
  * [deepcode.ai](https://www.deepcode.ai) — DeepCode encuentra bugs, vulnerabilidades de seguridad, problemas de rendimiento y API basados en IA. La velocidad de análisis de DeepCode permite analizar tu código en tiempo real y entregar resultados al guardar en tu IDE. Soporta Java, C/C++, JavaScript, Python y TypeScript. Integraciones con GitHub, BitBucket y GitLab. Gratis para open source y repos privados y hasta 30 desarrolladores.
  * [deepscan.io](https://deepscan.io) — Análisis estático avanzado para encontrar automáticamente errores de ejecución en código JavaScript, gratis para Open Source.
  * [DeepSource](https://deepsource.io/) - DeepSource analiza continuamente los cambios en el código fuente, encontrando y corrigiendo problemas categorizados en seguridad, rendimiento, anti-patrones, riesgos de bugs, documentación y estilo. Integración nativa con GitHub, GitLab y Bitbucket.
  * [DiffText](https://difftext.com) - Encuentra instantáneamente las diferencias entre dos bloques de código. Completamente gratis de usar.
  * [eversql.com](https://www.eversql.com/) — EverSQL - La plataforma #1 para optimización de bases de datos. Obtén información crítica sobre tu base de datos y consultas SQL automáticamente.
  * [gerrithub.io](https://review.gerrithub.io/) — Revisión de código Gerrit para repositorios de GitHub de forma gratuita.
  * [gocover.io](https://gocover.io/) — Cobertura de código para cualquier paquete de [Go](https://golang.org/).
  * [goreportcard.com](https://goreportcard.com/) — Calidad de código para proyectos Go, gratis para Open Source.
  * [gtmetrix.com](https://gtmetrix.com/) — Informes y recomendaciones detalladas para optimizar sitios web.
  * [holistic.dev](https://holistic.dev/) - El analizador estático de código #1 para optimización de Postgresql. Servicio de detección automática de problemas de rendimiento, seguridad y arquitectura en bases de datos.
  * [houndci.com](https://houndci.com/) — Comenta en los commits de GitHub sobre la calidad del código, gratis para Open Source.
  * [Moderne.io](https://app.moderne.io) — Refactorización automática de código fuente. Moderne ofrece migraciones de frameworks, análisis de código con remediación y transformación de código a gran escala, para que los desarrolladores puedan dedicar su tiempo a crear cosas nuevas en vez de mantener las antiguas. Gratis para Open Source.
  * [reviewable.io](https://reviewable.io/) — Revisión de código para repositorios GitHub, gratis para repos públicos o personales.
  * [parsers.dev](https://parsers.dev/) - Parsers de árboles de sintaxis abstracta y compiladores de representación intermedia como servicio.
  * [scan.coverity.com](https://scan.coverity.com/) — Análisis estático de código para Java, C/C++, C# y JavaScript, gratis para Open Source.
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — Plataforma de inspección continua, gratis para Open Source.
  * [semanticdiff.com](https://app.semanticdiff.com/) — Diff consciente del lenguaje de programación para pull requests y commits de GitHub, gratis para repositorios públicos.
  * [shields.io](https://shields.io) — Insignias de metadatos de calidad para proyectos open source.
  * [sonarcloud.io](https://sonarcloud.io) — Análisis automatizado de código fuente para Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy y más lenguajes, gratis para Open Source.
  * [SourceLevel](https://sourcelevel.io/) — Revisión de código automatizada y analíticas de equipo. Gratis para Open Source y organizaciones de hasta 5 colaboradores.
  * [webceo.com](https://www.webceo.com/) — Herramientas SEO pero también verificaciones de código y para diferentes tipos de dispositivos.
  * [zoompf.com](https://zoompf.com/) — Soluciona el rendimiento de tus sitios web, análisis detallado.

**[⬆️ Volver al inicio](#table-of-contents)**

## Búsqueda y Navegación de Código

  * [libraries.io](https://libraries.io/) — Búsqueda y notificaciones de actualización de dependencias para 32 gestores de paquetes diferentes, gratis para open source.
  * [Namae](https://namae.dev/) - Busca en varios sitios como GitHub, Gitlab, Heroku, Netlify y muchos más la disponibilidad del nombre de tu proyecto.
  * [searchcode.com](https://searchcode.com/) — Búsqueda de código basada en texto, gratis para Open Source.
  * [tickgit.com](https://www.tickgit.com/) — Encuentra comentarios `TODO` (y otros marcadores) para identificar áreas del código que vale la pena mejorar.
  * [CodeKeep](https://codekeep.io) - Google Keep para fragmentos de código. Organiza, descubre y comparte fragmentos de código, con una potente herramienta de captura de pantalla de código con plantillas predefinidas y una función de vinculación.

**[⬆️ Volver al inicio](#table-of-contents)**

## CI y CD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLint lleva pruebas automatizadas de accesibilidad web a tu flujo de desarrollo. Gratis para open source y propósitos educativos.
  * [appcircle.io](https://appcircle.io) — Plataforma móvil DevOps de nivel empresarial que automatiza la construcción, pruebas y publicación en tienda de apps móviles para un ciclo de lanzamiento más rápido y eficiente. Gratis para 30 minutos de construcción por build, 20 builds mensuales y 1 build concurrente.
  * [appveyor.com](https://www.appveyor.com/) — Servicio CD para Windows, gratis para Open Source.
  * [LocalOps](https://localops.co/) - Despliega tu app en AWS/GCP/Azure en menos de 30 minutos. Configura entornos estándar en cualquier nube, con automatización de despliegue continuo y observabilidad avanzada. El plan gratuito permite 1 usuario y 1 entorno de app.
  * [Argonaut](https://argonaut.dev/) - Despliega apps e infraestructura en tu nube en minutos. Soporte para despliegues personalizados y de terceros en Kubernetes y entornos Lambda. El nivel gratuito permite apps y despliegues ilimitados para 5 dominios y 2 usuarios.
  * [bitrise.io](https://www.bitrise.io/) — CI/CD para apps móviles, nativas o híbridas. Con 200 builds gratis/mes, 10 min por build y dos miembros de equipo. Proyectos OSS obtienen 45 min por build, +1 concurrencia y tamaño de equipo ilimitado.
  * [buddy.works](https://buddy.works/) — CI/CD con cinco proyectos gratuitos y una ejecución concurrente (120 ejecuciones/mes).
  * [Buildkite](https://buildkite.com) CI Pipelines gratis para 3 usuarios y 5k minutos de trabajo/mes. Test Analytics nivel gratuito para desarrolladores incluye 100k ejecuciones de pruebas/mes, con más inclusiones gratuitas para proyectos open source.
  * [bytebase.com](https://www.bytebase.com/) — CI/CD y DevOps para bases de datos. Gratis para menos de 20 usuarios y 10 instancias de base de datos.
  * [CircleCI](https://circleci.com/) — Plan gratuito completo con todas las funciones incluidas en un servicio CI/CD alojado para repositorios de GitHub, GitLab y BitBucket. Varias clases de recursos, Docker, Windows, Mac OS, ejecutores ARM, runners locales, división de pruebas, Docker Layer Caching y otras funciones avanzadas de CI/CD. Gratis hasta 6000 minutos/mes de ejecución, colaboradores ilimitados, 30 jobs paralelos en proyectos privados y hasta 80,000 minutos de construcción gratuitos para proyectos Open Source.
  * [cirrus-ci.org](https://cirrus-ci.org) - Gratis para repositorios públicos de GitHub.
  * [cirun.io](https://cirun.io) - Gratis para repositorios públicos de GitHub.
  * [codefresh.io](https://codefresh.io) — Plan Free-for-Life: 1 build, un entorno, servidores compartidos, repos públicos ilimitados.
  * [codemagic.io](https://codemagic.io/) - 500 minutos de construcción gratis/mes.
  * [codeship.com](https://codeship.com/) — 100 builds privados/mes, cinco proyectos privados, ilimitado para Open Source.
  * [deploybot.com](https://www.deploybot.com/) — 1 repositorio con diez despliegues, gratis para Open Source.
  * [deployhq.com](https://www.deployhq.com/) — 1 proyecto con diez despliegues diarios (30 minutos de build/mes).
  * [drone](https://cloud.drone.io/) - Drone Cloud permite a los desarrolladores ejecutar pipelines de entrega continua en múltiples arquitecturas, incluyendo x86 y Arm (tanto 32 como 64 bits), todo en un solo lugar.
  * [LayerCI](https://layerci.com) — CI para proyectos full stack. Un entorno de vista previa full stack con 5GB de memoria y 3 CPUs.
  * [semaphoreci.com](https://semaphoreci.com/) — Gratis para Open Source, 100 builds privados al mes.
  * [Squash Labs](https://www.squash.io/) — crea una VM para cada rama y hace que tu app esté disponible desde una URL única. Repos públicos y privados ilimitados, hasta 2 GB de tamaño de VM.
  * [styleci.io](https://styleci.io/) — Solo para repositorios públicos de GitHub.
  * [Mergify](https://mergify.io) — Automatización de flujo de trabajo y merge queue para GitHub — Gratis para repositorios públicos de GitHub.
  * [Make](https://www.make.com/en) — Herramienta de automatización de flujos de trabajo que te permite conectar apps y automatizar procesos usando UI. Soporta muchas apps y las APIs más populares. Gratis para repositorios públicos de GitHub y nivel gratuito con 100 Mb, 1000 operaciones y 15 minutos de intervalo mínimo.
  * [Spacelift](https://spacelift.io/) - Plataforma de gestión para Infrastructure as Code. Características del plan gratuito: colaboración IaC, registro de módulos Terraform, integración ChatOps, cumplimiento de recursos continuo con Open Policy Agent, SSO con SAML 2.0 y acceso a pools de workers públicos: hasta 200 minutos/mes.
  * [microtica.com](https://microtica.com/) - Entornos de startup con componentes de infraestructura listos para usar, despliega apps en AWS gratis y soporta cargas productivas. El nivel gratuito incluye 1 entorno (en tu cuenta AWS), 2 servicios Kubernetes, 100 minutos de build al mes y 20 despliegues mensuales.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud acelera tus monorepos en CI con características como almacenamiento en caché remoto, distribución de tareas entre máquinas e incluso división automatizada de tus ejecuciones de pruebas e2e. Incluye un plan gratuito para hasta 30 colaboradores con 150,000 créditos generosos incluidos.
* [blacksmith](https://www.blacksmith.sh/) - Runners de rendimiento gestionados para GitHub Actions que proporcionan 3,000 minutos gratuitos por mes, sin necesidad de tarjeta de crédito.
* [Terramate](https://terramate.io/) - Terramate es una plataforma de orquestación y gestión para herramientas de Infraestructura como Código (IaC) como Terraform, OpenTofu y Terragrunt. Gratis para hasta 2 usuarios incluyendo todas las funciones.
* [Terrateam](https://terrateam.io) - Automatización de Terraform orientada a GitOps con flujos de trabajo impulsados por pull requests, aislamiento de proyectos mediante runners autohospedados y ejecuciones en capas para operaciones ordenadas. Gratis para hasta 3 usuarios.

**[⬆️ Volver al inicio](#table-of-contents)**

## Pruebas

* [Applitools.com](https://applitools.com/) — Validación visual inteligente para aplicaciones web, móviles nativas y de escritorio. Se integra con casi todas las soluciones de automatización (como Selenium y Karma) y runners remotos (Sauce Labs, Browser Stack). Gratis para código abierto. Un nivel gratuito para un solo usuario con checkpoints limitados por semana.
* [Appetize](https://appetize.io) — Prueba tus apps de Android e iOS en este emulador de teléfonos/tabletas Android basado en la nube y simuladores de iPhone/iPad directamente en tu navegador. El nivel gratuito incluye dos sesiones concurrentes con 30 minutos de uso por mes. Sin límite en el tamaño de la app.
* [Apptim](https://apptim.com) — Herramienta de pruebas móviles que permite a personas sin conocimientos de ingeniería de rendimiento evaluar el desempeño y experiencia de usuario (UX) de una app. La versión de escritorio usando tu propio dispositivo es 100% GRATUITA, con pruebas ilimitadas tanto en iOS como en Android.
* [Argos](https://argos-ci.com) - Pruebas visuales Open Source para desarrolladores. Proyectos ilimitados, con 5,000 capturas de pantalla por mes. Gratis para proyectos de código abierto.
* [Bencher](https://bencher.dev/) - Suite de herramientas de benchmarking continuo para detectar regresiones de rendimiento en CI. Gratis para todos los proyectos públicos.
* [browserstack.com](https://www.browserstack.com/) — Pruebas manuales y automáticas en navegadores, [gratis para Open Source](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Herramienta ligera de automatización de pruebas para aplicaciones web. Es fácil de aprender y no requiere programación. Puedes ejecutar pruebas ilimitadas en tu propio ordenador gratis. También obtienes monitorización en la nube e integración CI/CD por una tarifa mensual adicional.
* [Checkly](https://checklyhq.com) - Monitoreo sintético orientado a código para DevOps modernos. Monitorea tus APIs y apps a una fracción del precio de los proveedores tradicionales. Impulsado por un flujo de trabajo Monitoring as Code y Playwright. Generoso nivel gratuito para desarrolladores.
* [checkbot.io](https://www.checkbot.io/) — Extensión de navegador que prueba si tu sitio web sigue más de 50 buenas prácticas de SEO, velocidad y seguridad. Nivel gratuito para sitios web pequeños.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - Herramienta gratuita para desarrolladores y testers de API para comprobar si una API tiene habilitado CORS para un dominio dado e identificar carencias. Obtén información accionable.
* [cypress.io](https://www.cypress.io/) - Pruebas rápidas, fáciles y confiables para cualquier cosa que se ejecute en un navegador. Cypress Test Runner es siempre gratuito y open-source sin restricciones ni limitaciones. Cypress Dashboard es gratis para proyectos open-source hasta 5 usuarios.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - Crea pruebas Cypress/modelos POM potenciados por IA en tu navegador. Es open-source, excepto la parte de IA. Gratis para cinco creaciones de pruebas mensuales con scripts autoreparables, email y pruebas visuales.
* [everystep-automation.com](https://www.everystep-automation.com/) — Graba y reproduce todos los pasos realizados en un navegador web y crea scripts, gratuito con menos opciones.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Las herramientas de Chaos Engineering de Gremlin permiten inyectar fallos de manera segura en tus sistemas para encontrar debilidades antes de que causen problemas a clientes. Gremlin Free da acceso a ataques de Apagado y CPU en hasta 5 hosts o contenedores.
* [gridlastic.com](https://www.gridlastic.com/) — Pruebas Selenium Grid con un plan gratuito de hasta 4 nodos selenium simultáneos/10 inicios de grid/4,000 minutos de prueba al mes.
* [katalon.com](https://katalon.com) - Plataforma de pruebas que puede ayudar a equipos de todos los tamaños y niveles de madurez, incluyendo Katalon Studio, TestOps (+ Visual Testing gratis), TestCloud y Katalon Recorder.
* [Keploy](https://keploy.io/) - Keploy es un toolkit de pruebas funcionales para desarrolladores. Al grabar llamadas API genera pruebas E2E para APIs (KTests) y mocks o stubs (KMocks). Es gratis para proyectos Open Source.
* [knapsackpro.com](https://knapsackpro.com) - Acelera tus pruebas con paralelización óptima del suite de pruebas en cualquier proveedor de CI. Divide pruebas Ruby y JavaScript en nodos CI paralelos para ahorrar tiempo. Plan gratis para hasta 10 minutos de archivos de pruebas y plan ilimitado gratis para proyectos Open Source.
* [lambdatest.com](https://www.lambdatest.com/) — Pruebas manuales, visuales, de captura de pantalla y automatizadas en navegadores con selenium y cypress, [gratis para Open Source](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - Crea automáticamente pruebas de API y carga analizando el tráfico de red. Simula hasta 50 usuarios concurrentes durante hasta 60 minutos gratis mensualmente.
* [lost-pixel.com](https://lost-pixel.com) - Pruebas de regresión visual integrales para tus historias de Storybook, Ladle, Histoire y aplicaciones web. Miembros de equipo ilimitados, totalmente gratis para open-source, 7,000 snapshots/mes.
* [octomind.dev](https://www.octomind.dev/) - Pruebas UI Playwright autogeneradas, ejecutadas y mantenidas con generación de casos de prueba asistida por IA.
* [percy.io](https://percy.io) - Añade pruebas visuales a cualquier app web, sitio estático, guía de estilos o librería de componentes. Miembros de equipo ilimitados, app demo y proyectos ilimitados, 5,000 snapshots/mes.
* [preflight.com](https://preflight.com) - Pruebas web automatizadas sin código. Graba pruebas en tu navegador que resisten cambios en la UI y ejecútalas en máquinas Windows. ¿Puedes integrarlo con tu CI/CD? El plan gratuito incluye 50 ejecuciones de pruebas mensuales con video, sesiones HTML y más.
* [qase.io](https://qase.io) - Sistema de gestión de pruebas para equipos de desarrollo y QA. Gestiona casos de prueba, compón ejecuciones, realiza pruebas, rastrea defectos y mide impacto. El nivel gratuito incluye todas las funciones principales, con 500 MB para adjuntos y hasta 3 usuarios.
* [Repeato](https://repeato.app/) Herramienta de automatización de pruebas móviles sin código basada en visión por computadora e IA. Funciona para apps nativas, flutter, react-native, web, ionic y muchos más frameworks. El plan gratuito está limitado a 10 pruebas para iOS y 10 para Android, pero incluye la mayoría de las funciones de los planes de pago, incluyendo ejecuciones ilimitadas de pruebas.
* [Requestly](https://requestly.com/) Extensión open-source de Chrome para interceptar, redirigir y simular peticiones HTTP. Incluye [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/) y [Session Recording](https://requestly.com/products/session-book/). Redirige URLs, modifica cabeceras HTTP, simula APIs, inyecta JS personalizado, modifica peticiones GraphQL, genera endpoints API simulados, graba sesiones con logs de red y consola. Crea hasta 10 reglas en el nivel gratuito. Gratis para open-source.
* [seotest.me](https://seotest.me/) — Probador de SEO on-page gratuito. 10 rastreos de sitio web gratis por día. Recursos útiles para aprender SEO y recomendaciones sobre cómo mejorar el SEO on-page para cualquier sitio sin importar la tecnología.
* [snippets.uilicious.com](https://snippets.uilicious.com) - Es como CodePen pero para pruebas cross-browser. UI-licious te permite escribir pruebas como historias de usuario y ofrece una plataforma gratuita - UI-licious Snippets - que permite ejecutar pruebas ilimitadas en Chrome sin registro para hasta 3 minutos por ejecución. ¿Encontraste un bug? Puedes copiar la URL única de tu prueba para mostrarle a tus desarrolladores exactamente cómo reproducir el bug.
* [TestCollab](https://testcollab.com) - Software de gestión de pruebas fácil de usar, su plan gratuito incluye integración con Jira, proyectos ilimitados, importación de casos de prueba usando CSV/XLSx, seguimiento de tiempo y 1 GB de almacenamiento de archivos.
* [testingbot.com](https://testingbot.com/) — Pruebas de navegador y dispositivos con Selenium, [gratis para Open Source](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - Un panel para publicar resultados de pruebas automatizadas y un framework para implementar pruebas manuales como código usando GitHub. El servicio es [gratis para Open Source](https://github.com/marketplace/testspace-com) y permite 450 resultados mensuales.
* [tesults.com](https://www.tesults.com) — Reportes de resultados de pruebas y gestión de casos de prueba. Se integra con frameworks de prueba populares. Desarrolladores de software Open Source, individuos, educadores y pequeños equipos pueden solicitar ofertas gratuitas y con descuento más allá de los proyectos básicos gratuitos.
* [UseWebhook.com](https://usewebhook.com) - Captura e inspecciona webhooks desde tu navegador. Redirecciona a localhost o reproduce desde el historial. Uso gratuito.
* [Vaadin](https://vaadin.com) — Construye interfaces escalables en Java o TypeScript y usa las herramientas integradas, componentes y sistema de diseño para iterar más rápido, diseñar mejor y simplificar el proceso de desarrollo. Proyectos ilimitados con cinco años de mantenimiento gratuito.
* [websitepulse.com](https://www.websitepulse.com/tools/) — Varias herramientas gratuitas de red y servidor.
* [webhook-test.com](https://webhook-test.com) - Depura e inspecciona webhooks y peticiones HTTP con una URL única durante la integración. Completamente gratis, puedes crear URLs ilimitadas y recibir recomendaciones.
* [webhook.site](https://webhook.site) - Verifica webhooks, peticiones HTTP salientes o correos electrónicos con una URL personalizada. Una URL temporal y dirección de correo siempre gratuitas.
* [webhookbeam.com](https://webhookbeam.com) - Configura webhooks y monitoréalos mediante notificaciones push y correos electrónicos.

**[⬆️ Volver al inicio](#table-of-contents)**

## Seguridad y PKI

* [aikido.dev](https://www.aikido.dev) — Plataforma appsec todo en uno que cubre SCA, SAST, CSPM, DAST, Secrets, IaC, Malware, escaneo de contenedores, EOL,... El plan gratuito incluye dos usuarios, escaneo de 10 repos, 1 nube, 2 contenedores y 1 dominio.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — Descubre sistemas comprometidos en tu red.
* [Altcha.org](https://altcha.org/anti-spam) - Filtro de spam para sitios web y APIs impulsado por procesamiento de lenguaje natural y aprendizaje automático. El plan gratuito incluye 200 solicitudes diarias por dominio.
* [atomist.com](https://atomist.com/) — Una forma más rápida y conveniente de automatizar diversas tareas de desarrollo. Ahora en beta.
* [cloudsploit.com](https://cloudsploit.com/) — Auditoría y monitoreo de seguridad y cumplimiento para Amazon Web Services (AWS)
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — Indicadores de compromiso (IOC) de alta confianza dirigidos a infraestructura de nube pública, una parte disponible en github (https://github.com/unknownhad/AWSAttacks). Lista completa disponible vía API.
* [CodeNotary.io](https://www.codenotary.io/) — Plataforma Open Source con pruebas indelebles para notarizar código, archivos, directorios o contenedores.
* [crypteron.com](https://www.crypteron.com/) — Plataforma de seguridad cloud-first, amigable para desarrolladores, que previene brechas de datos en aplicaciones .NET y Java.
* [CyberChef](https://gchq.github.io/CyberChef/) — Aplicación web simple e intuitiva para analizar y decodificar/codificar datos sin herramientas complejas ni lenguajes de programación. Como una navaja suiza de la criptografía y el cifrado. Todas las funciones son gratuitas, sin límite. Open source si prefieres autohospedar.
* [DAS](https://signup.styra.com/) — Styra DAS Free, gestión de políticas de ciclo completo para crear, desplegar y gestionar autorización con Open Policy Agent (OPA).
* [Datree](https://www.datree.io/) — Herramienta CLI Open Source para prevenir errores de configuración en Kubernetes asegurando que los manifiestos y Helm charts sigan buenas prácticas y las políticas de tu organización.
* [Dependabot](https://dependabot.com/) Actualizaciones automáticas de dependencias para Ruby, JavaScript, Python, PHP, Elixir, Rust, Java (Maven y Gradle), .NET, Go, Elm, Docker, Terraform, Git Submodules y GitHub Actions.
* [DJ Checkup](https://djcheckup.com) — Escanea tu sitio Django en busca de fallos de seguridad con esta herramienta gratuita y automatizada. Forkeada de Pony Checkup.
* [Doppler](https://doppler.com/) — Gestor universal de secretos para aplicaciones y configuración, con soporte para sincronización con varios proveedores cloud. Gratis para cinco usuarios con controles de acceso básicos.
* [Dotenv](https://dotenv.org/) — Sincroniza tus archivos .env, rápida y seguramente. Deja de compartir tus archivos .env por canales inseguros como Slack y correo, y nunca pierdas un archivo importante otra vez. Gratis para hasta 3 compañeros de equipo.
* [GitGuardian](https://www.gitguardian.com) — Mantén secretos fuera de tu código fuente con detección y remediación automática de secretos. Escanea tus repos git para más de 350 tipos de secretos y archivos sensibles – Gratis para individuos y equipos de hasta 25 desarrolladores.
* [Have I been pwned?](https://haveibeenpwned.com) — API REST para obtener información sobre brechas de datos.
* [hostedscan.com](https://hostedscan.com) — Escáner de vulnerabilidades online para aplicaciones web, servidores y redes. Diez escaneos gratis al mes.
* [Infisical](https://infisical.com/) — Plataforma open source que te permite gestionar secretos de desarrollador en tu equipo e infraestructura: desde desarrollo local hasta servicios de staging/producción de terceros. Gratis hasta 5 desarrolladores.
* [Internet.nl](https://internet.nl) — Test para estándares modernos de Internet como IPv6, DNSSEC, HTTPS, DMARC, STARTTLS y DANE.
* [keychest.net](https://keychest.net) - Gestión de expiración de SSL y compra de certificados con base de datos CT integrada.
* [letsencrypt.org](https://letsencrypt.org/) — Autoridad certificadora SSL gratuita con certificados confiables por todos los navegadores principales.
* [meterian.io](https://www.meterian.io/) - Monitorea proyectos Java, Javascript, .NET, Scala, Ruby y NodeJS para vulnerabilidades de seguridad en dependencias. Gratis para un proyecto privado, proyectos ilimitados para open source.
* [Mozilla Observatory](https://observatory.mozilla.org/) — Encuentra y corrige vulnerabilidades de seguridad en tu sitio.
* [opswat.com](https://www.opswat.com/) — Monitoreo de seguridad de computadores, dispositivos, aplicaciones y configuraciones. Gratis para 25 usuarios y 30 días de historial.
* [openapi.security](https://openapi.security/) - Herramienta gratuita para comprobar rápidamente la seguridad de cualquier API basada en OpenAPI/Swagger. No requiere registro.
* [pixee.ai](https://pixee.ai) - Ingeniero de Seguridad de Producto Automatizado como bot gratuito de GitHub que envía PRs a tu base de código Java para resolver vulnerabilidades automáticamente. Próximamente otros lenguajes.
* [pyup.io](https://pyup.io) — Monitorea dependencias Python en busca de vulnerabilidades y actualízalas automáticamente. Gratis para un proyecto privado, proyectos ilimitados para open source.
* [qualys.com](https://www.qualys.com/community-edition) — Encuentra vulnerabilidades en aplicaciones web, auditoría de riesgos OWASP.
* [report-uri.io](https://report-uri.io/) — Reporte de violaciones CSP y HPKP.
* [ringcaptcha.com](https://ringcaptcha.com/) — Herramientas para usar el número de teléfono como ID, disponible gratuitamente.
* [seclookup.com](https://www.seclookup.com/) - APIs de Seclookup pueden enriquecer indicadores de amenazas de dominio en SIEM, proveer información integral de dominios y mejorar la detección y respuesta de amenazas. Obtén 50K búsquedas gratis [aquí](https://account.seclookup.com/).
* [snyk.io](https://snyk.io) — Puede encontrar y corregir vulnerabilidades conocidas en tus dependencias open-source. Pruebas y remediaciones ilimitadas para proyectos open-source. Limitado a 200 pruebas/mes para proyectos privados.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — Análisis intenso de la configuración de cualquier servidor web SSL.
* [SOOS](https://soos.io) - Scans SCA gratuitos e ilimitados para proyectos open-source. Detecta y corrige amenazas de seguridad antes del lanzamiento. Protege tus proyectos con una solución simple y efectiva.
* [StackHawk](https://www.stackhawk.com/) Automatiza el escaneo de aplicaciones en tu pipeline para encontrar y corregir bugs de seguridad antes de producción. Escaneos y entornos ilimitados para una sola app.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Chequeo de seguridad web y escáner de malware gratuito.
* [Protectumus](https://protectumus.com) - Chequeo de seguridad web gratuito, antivirus para sitios y firewall de servidor (WAF) para PHP. Notificaciones por email para usuarios registrados en el nivel gratuito.
* [TestTLS.com](https://testtls.com) - Test de un servicio SSL/TLS para configuración segura de servidor, certificados, cadenas, etc. No limitado a HTTPS.
* [threatconnect.com](https://threatconnect.com) — Inteligencia de amenazas: diseñado para investigadores individuales, analistas y organizaciones que empiezan en inteligencia de amenazas cibernéticas. Gratis hasta 3 usuarios.
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — Escaneo automático de vulnerabilidades. El plan gratuito permite escaneos XSS semanales.
* [Ubiq Security](https://ubiqsecurity.com/) — Cifra y descifra datos con tres líneas de código y gestión automática de claves. Gratis para una aplicación y hasta 1,000,000 de cifrados por mes.
* [Virgil Security](https://virgilsecurity.com/) — Herramientas y servicios para implementar cifrado de extremo a extremo, protección de base de datos, seguridad IoT y más en tu solución digital. Gratis para apps con hasta 250 usuarios.
* [Vulert](https://vulert.com) - Vulert monitoriza continuamente tus dependencias open-source en busca de nuevas vulnerabilidades, recomienda soluciones, sin requerir instalación ni acceso a tu base de código. Gratis para proyectos open-source.
* [Escape GraphQL Quickscan](https://escape.tech/) - Escaneo de seguridad de tus endpoints GraphQL en un clic. Gratis, no requiere login.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - Busca entre 20 millones de secretos expuestos en repos públicos de GitHub, gists, issues y comentarios gratis.
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - Toolkit SSL todo-en-uno con varias funciones como generador de clave privada y CSR, decodificador de certificados SSL, comparador de certificados y pedidos de certificados SSL. Ofrecemos a los usuarios la posibilidad de generar Certificados SSL gratuitos de Let's Encrypt, Google Trust y BuyPass usando registros CNAME en lugar de TXT.
**[⬆️ Volver al inicio](#table-of-contents)**

## Autenticación, Autorización y Gestión de Usuarios

  * [Aserto](https://www.aserto.com) - Autorización de grano fino como servicio para aplicaciones y APIs. Gratis hasta 1000 MAUs y 100 instancias de autorizador.
  * [asgardeo.io](https://wso2.com/asgardeo) - Integración sin problemas de SSO, MFA, autenticación sin contraseña y más. Incluye SDKs para apps frontend y backend. Gratis hasta 1000 MAUs y cinco proveedores de identidad.
  * [Auth0](https://auth0.com/) — SSO alojado. El plan gratuito incluye 25,000 MAUs, conexiones sociales ilimitadas, dominio personalizado y más.
  * [Authgear](https://www.authgear.com) - Lleva autenticación sin contraseña, OTPs, 2FA, SSO a tus apps en minutos. Todo el Front-end incluido. Gratis hasta 5000 MAUs.
  * [Authress](https://authress.io/) — Inicio de sesión y control de acceso, proveedores de identidad ilimitados para cualquier proyecto. Facebook, Google, Twitter y más. Las primeras 1000 llamadas a la API son gratis.
  * [Authy](https://authy.com) - Autenticación de dos factores (2FA) en varios dispositivos, con copias de seguridad. Reemplazo directo de Google Authenticator. Gratis hasta 100 autenticaciones exitosas.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - Sistema completo de gestión de autorización para crear, probar y desplegar políticas de acceso. Autorización y control de acceso de grano fino, gratis hasta 100 principales activos mensuales.
  * [Clerk](https://clerk.com) — Gestión de usuarios, autenticación, 2FA/MFA, componentes de UI preconstruidos para inicio de sesión, registro, perfiles de usuario y más. Gratis hasta 10,000 usuarios activos mensuales.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak Identity and Access Management como servicio. Gratis hasta 100 usuarios y un realm.
  * [Corbado](https://www.corbado.com/) — Añade autenticación con passkey primero a apps nuevas o existentes. Gratis para MAUs ilimitados.
  * [Descope](https://www.descope.com/) — Flujos de autenticación altamente personalizables, con enfoque sin código y API/SDK, gratis 7,500 usuarios activos/mes, 50 tenants (hasta 5 tenants SAML/SSO).
  * [duo.com](https://duo.com/) — Autenticación de dos factores (2FA) para sitio web o app. Gratis para diez usuarios, todos los métodos de autenticación, integraciones ilimitadas, tokens de hardware.
  * [Kinde](https://kinde.com/) - Autenticación simple y robusta que puedes integrar con tu producto en minutos. Todo lo que necesitas para comenzar con 7,500 MAU gratis.
  * [logintc.com](https://www.logintc.com/) — Autenticación de dos factores (2FA) por notificaciones push, gratis para diez usuarios, VPN, sitios web y SSH.
  * [MojoAuth](https://mojoauth.com/) - MojoAuth facilita la implementación de autenticación sin contraseña en tu web, móvil o cualquier aplicación en minutos.
  * [Okta](https://developer.okta.com/signup/) — Gestión de usuarios, autenticación y autorización. Gratis hasta 100 usuarios activos mensuales.
  * [onelogin.com](https://www.onelogin.com/) — Identidad como Servicio (IDaaS), proveedor de identidad SSO, Cloud SSO IdP, tres apps de empresa y cinco personales, usuarios ilimitados.
  * [Ory](https://ory.sh/) - Plataforma de seguridad gestionada AuthN/AuthZ/OAuth2.0/Zero Trust. Cuentas para desarrolladores gratis para siempre con todas las funciones de seguridad, miembros de equipo ilimitados, 200 usuarios activos diarios y 25k/mes de comprobaciones de permisos.
  * [Permit.io](https://permit.io) - Plataforma de autorización como servicio que habilita RBAC, ABAC y ReBAC para microservicios escalables con actualizaciones en tiempo real y UI de políticas sin código. Nivel gratuito de 1000 usuarios activos mensuales.
  * [Phase Two](https://phasetwo.io) - Keycloak Gestión de Identidad y Acceso Open Source. Realm gratis hasta 1000 usuarios, hasta 10 conexiones SSO, aprovechando el contenedor mejorado de Keycloak de Phase Two que incluye la extensión [Organization](https://phasetwo.io/product/organizations/).
  * [SSOJet](https://ssojet.com/) - Añade SSO empresarial sin reconstruir tu autenticación. El plan gratuito incluye usuarios activos mensuales ilimitados, organizaciones ilimitadas, 2 conexiones SSO y 2 SCIM.
  * [Stytch](https://www.stytch.com/) - Plataforma todo en uno que proporciona APIs y SDKs para autenticación y prevención de fraude. El plan gratuito incluye 10,000 usuarios activos mensuales, organizaciones ilimitadas, 5 conexiones SSO o SCIM y 1,000 tokens M2M.
  * [Stack Auth](https://stack-auth.com) — Autenticación open-source fácil de implementar. La solución más amigable para desarrolladores, lista en cinco minutos. Autoalojable gratis, o versión SaaS gestionada con 10k usuarios activos mensuales gratis.
  * [SuperTokens](https://supertokens.com/) - Autenticación de usuarios open source que se integra de forma nativa en tu app, permitiéndote comenzar rápidamente mientras controlas la experiencia del usuario y del desarrollador. Gratis hasta 5000 MAUs.
  * [Warrant](https://warrant.dev/) — Servicio de autorización y control de acceso de nivel empresarial para tus apps. El nivel gratuito incluye 1 millón de solicitudes API mensuales y 1,000 reglas de autorización.
  * [ZITADEL Cloud](https://zitadel.com) — Gestión de usuarios y acceso lista para usar, con soporte para casos multi-tenant (B2B). Gratis hasta 25,000 solicitudes autenticadas, con todas las funciones de seguridad (sin muro de pago para OTP, sin contraseña, políticas, etc).
  * [PropelAuth](https://propelauth.com) — Vende a empresas de cualquier tamaño de inmediato con unas pocas líneas de código, gratis hasta 200 usuarios y 10k correos transaccionales (con marca de agua: "Powered by PropelAuth").
  * [Logto](https://logto.io/) - Desarrolla, asegura y gestiona identidades de usuario de tu producto - tanto para autenticación como para autorización. Gratis hasta 5,000 MAUs con opción open-source autoalojada disponible.
  * [WorkOS](https://workos.com/) - Gestión de usuarios y autenticación gratis hasta 1 millón de MAUs. Soporte para email + contraseña, auth social, Magic Auth, MFA y más.


**[⬆️ Volver al inicio](#table-of-contents)**

## Distribución y Feedback de Apps Móviles

  * [TestApp.io](https://testapp.io) - Plataforma para asegurar que tus apps móviles funcionan como deben. Plan gratuito: una app, analíticas, versiones e instalaciones ilimitadas y recolección de feedback.
  * [Loadly](https://loadly.io) - Servicio de distribución de apps beta iOS & Android completamente gratuito con descargas ilimitadas, descargas de alta velocidad y subidas ilimitadas.
  * [Diawi](https://www.diawi.com) - Despliega apps iOS & Android directamente a los dispositivos. Plan gratuito: subidas de apps, enlaces protegidos por contraseña, expiración de 1 día, diez instalaciones.
  * [InstallOnAir](https://www.installonair.com) - Distribuye apps iOS & Android por el aire. Plan gratuito: subidas ilimitadas, enlaces privados, expiración de 2 días para invitados, 60 días para usuarios registrados.
  * [GetUpdraft](https://www.getupdraft.com) - Distribuye apps móviles para pruebas. El plan gratuito incluye un proyecto de app, tres versiones de app, 500 MB de almacenamiento y 100 instalaciones de app por mes.
  * [Appho.st](https://appho.st) - Plataforma de alojamiento para apps móviles. El plan gratuito incluye cinco apps, 50 descargas mensuales y un tamaño máximo de archivo de 100 MB.

**[⬆️ Volver al inicio](#table-of-contents)**

## Sistema de Gestión

  * [bitnami.com](https://bitnami.com/) — Despliega apps preparadas en IaaS. Gestión de 1 instancia micro de AWS gratis
  * [Esper](https://esper.io) — MDM y MAM para dispositivos Android con DevOps. Cien dispositivos gratis con una licencia de usuario y 25 MB de almacenamiento de aplicaciones.
  * [jamf.com](https://www.jamf.com/) — Gestión de dispositivos para iPads, iPhones y Macs, tres dispositivos gratis
  * [Miradore](https://miradore.com) — Servicio de gestión de dispositivos. Mantén tu flota de dispositivos actualizada y segura, dispositivos ilimitados gratis. El plan gratuito ofrece funciones básicas.
  * [moss.sh](https://moss.sh) - Ayuda a los desarrolladores a desplegar y gestionar sus apps y servidores web. Gratis hasta 25 despliegues git por mes
  * [runcloud.io](https://runcloud.io/) - Gestión de servidores enfocado principalmente en proyectos PHP. Gratis para hasta 1 servidor.
  * [ploi.io](https://ploi.io/) - Herramienta de gestión de servidores para administrar y desplegar fácilmente tus servidores y sitios. Gratis para un servidor.
  * [xcloud.host](https://xcloud.host) — Plataforma de gestión y despliegue de servidores con una interfaz amigable. Nivel gratis disponible para un servidor.
  * [serveravatar.com](https://serveravatar.com) — Administra y monitorea servidores web basados en PHP con configuraciones automáticas. Gratis para un servidor.

**[⬆️ Volver al inicio](#table-of-contents)**

## Mensajería y Streaming

  * [Ably](https://www.ably.com/) - Servicio de mensajería en tiempo real con presencia, persistencia y entrega garantizada. El plan gratis incluye 3 millones de mensajes por mes, 100 conexiones pico y 100 canales pico.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ como servicio. Plan Little Lemur: máx 1 millón de mensajes/mes, máx 20 conexiones concurrentes, máx 100 colas, máx 10,000 mensajes en cola, múltiples nodos en diferentes AZ's.
  * [courier.com](https://www.courier.com/) — API única para push, in-app, email, chat, SMS y otros canales de mensajería con gestión de plantillas y más. El plan gratis incluye 10,000 mensajes/mes.
  * [engagespot.co](https://engagespot.co/) — Infraestructura de notificaciones multicanal para desarrolladores con bandeja de entrada in-app preconstruida y editor de plantillas sin código. Plan gratis incluye 10,000 mensajes/mes.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - Conecta tus dispositivos MQTT al broker de mensajería IoT nativo en la nube. Gratis para conectar hasta 100 dispositivos (sin tarjeta de crédito requerida) para siempre.
  * [knock.app](https://knock.app) – Infraestructura de notificaciones para desarrolladores. Envía a múltiples canales como in-app, email, SMS, Slack y push con una sola llamada de API. El plan gratis incluye 10,000 mensajes/mes.
  * [NotificationAPI.com](https://www.notificationapi.com/) — Añade notificaciones de usuario a cualquier software en 5 minutos. El plan gratis incluye 10,000 notificaciones/mes + 100 SMS y llamadas automáticas.
  * [Novu.co](https://novu.co) — Infraestructura open-source de notificaciones para desarrolladores. Componentes y APIs simples para gestionar todos los canales de comunicación en un solo lugar: Email, SMS, Directo, In-App y Push. El plan gratuito incluye 30,000 notificaciones/mes con 90 días de retención.
  * [pusher.com](https://pusher.com/) — Servicio de mensajería en tiempo real. Gratis hasta 100 conexiones simultáneas y 200,000 mensajes/día.
  * [scaledrone.com](https://www.scaledrone.com/) — Servicio de mensajería en tiempo real. Gratis hasta 20 conexiones simultáneas y 100,000 eventos/día.
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) como servicio. Global, AWS, GCP y Azure. Gratis para siempre con tamaño de mensaje de 4k, 50 conexiones activas y 5GB de datos por mes.
  * [pubnub.com](https://www.pubnub.com/) - Mensajería en Swift, Kotlin y React con 1 millón de transacciones cada mes. Las transacciones pueden contener múltiples mensajes.
  * [eyeson API](https://developers.eyeson.team/) - API de comunicación por video basada en WebRTC (SFU, MCU) para construir plataformas de video. Permite inyección de datos en tiempo real, layouts de video, grabaciones, UI web alojada totalmente funcional (quickstart) o paquetes para UIs personalizadas. Tiene [nivel gratis para desarrolladores](https://apiservice.eyeson.com/api-pricing) con 1000 minutos de reunión al mes.
  * [webpushr](https://www.webpushr.com/) - Notificaciones web push - Gratis hasta 10k suscriptores, notificaciones push ilimitadas, mensajería en navegador.
  * [httpSMS](https://httpsms.com) - Envía y recibe SMS usando tu teléfono Android como gateway SMS. Gratis para enviar y recibir hasta 200 mensajes por mes.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - Broker MQTT sin servidor, escalable y seguro en segundos. 1M minutos de sesión/mes gratis para siempre (sin tarjeta requerida).
  * [Pocket Alert](https://pocketalert.app) - Envía notificaciones push a tus dispositivos iOS y Android. Integra fácilmente vía API o Webhooks y mantén control total sobre tus alertas. Plan gratis: 50 mensajes al día a 1 dispositivo y 1 aplicación.
  * [SuprSend](https://www.suprsend.com/) - SuprSend es una infraestructura de notificaciones que optimiza las notificaciones de tu producto con un enfoque API-first. Crea y entrega notificaciones transaccionales, crons y de engagement en múltiples canales con una sola API. El plan gratis te da 10,000 notificaciones por mes, incluyendo diferentes nodos de workflow como resúmenes, lotes, multicanal, preferencias, tenants, broadcasts y más.

**[⬆️ Volver al inicio](#table-of-contents)**

## Gestión de Logs

  * [bugfender.com](https://bugfender.com/) — Gratis hasta 100k líneas de logs/día con 24 horas de retención
  * [logentries.com](https://logentries.com/) — Gratis hasta 5 GB/mes con siete días de retención
  * [loggly.com](https://www.loggly.com/) — Gratis para un solo usuario, 200MB/día con siete días de retención
  * [logz.io](https://logz.io/) — Gratis hasta 1 GB/día, un día de retención
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Servicio de gestión de logs impulsado por Manage Engine. Plan gratuito ofrece 50 GB de almacenamiento con 15 días de retención y 7 días de búsqueda.
  * [papertrailapp.com](https://papertrailapp.com/) — 48 horas de búsqueda, siete días de archivo, 50 MB/mes
  * [sematext.com](https://sematext.com/logsene) — Gratis hasta 500 MB/día, siete días de retención
  * [sumologic.com](https://www.sumologic.com/) — Gratis hasta 500 MB/día, siete días de retención
  * [logflare.app](https://logflare.app/) — Gratis hasta 12,960,000 entradas por app por mes, 3 días de retención
  * [logtail.com](https://logtail.com/) — Gestión de logs compatible con SQL basada en ClickHouse. Gratis hasta 1 GB por mes, tres días de retención.
  * [logzab.com](https://logzab.com/) — Sistema de gestión de auditoría. Gratis 1,000 logs de actividad de usuario por mes, 1 mes de retención, para hasta 5 proyectos.
  * [openobserve.ai](https://openobserve.ai/) - 200 GB de ingesta/mes gratis, 15 días de retención
**[⬆️ Volver al inicio](#table-of-contents)**

## Gestión de Traducciones

  * [crowdin.com](https://crowdin.com/) — Proyectos ilimitados, cadenas ilimitadas y colaboradores para Open Source
  * [gitlocalize.com](https://gitlocalize.com) - Gratis e ilimitado para repositorios privados y públicos
  * [Lecto](https://lecto.ai/) - API de Traducción Automática con nivel gratuito (30 solicitudes gratis, 1000 caracteres traducidos por solicitud). Integrado con el plugin Loco Translate de Wordpress.
  * [lingohub.com](https://lingohub.com/) — Gratis hasta 3 usuarios, siempre gratis para Open Source
  * [localazy.com](https://localazy.com) - Gratis para 1000 cadenas en el idioma fuente, idiomas ilimitados, colaboradores ilimitados, ofertas para startups y open source
  * [Localeum](https://localeum.com) - Gratis hasta 1000 cadenas, un usuario, idiomas ilimitados, proyectos ilimitados
  * [localizely.com](https://localizely.com/) — Gratis para Open Source
  * [Loco](https://localise.biz/) — Gratis hasta 2000 traducciones, traductores ilimitados, diez idiomas/proyecto, 1000 recursos traducibles/proyecto
  * [oneskyapp.com](https://www.oneskyapp.com/) — Edición gratuita limitada para hasta 5 usuarios, gratis para Open Source
  * [POEditor](https://poeditor.com/) — Gratis hasta 1000 cadenas
  * [SimpleLocalize](https://simplelocalize.io/) - Gratis hasta 100 claves de traducción, cadenas ilimitadas, idiomas ilimitados, ofertas para startups
  * [Texterify](https://texterify.com/) - Gratis para un solo usuario
  * [Tolgee](https://tolgee.io) - Oferta SaaS gratuita con traducciones limitadas, versión autoalojada siempre gratuita
  * [transifex.com](https://www.transifex.com/) — Gratis para Open Source
  * [Translation.io](https://translation.io) - Gratis para Open Source
  * [Translized](https://translized.com) - Gratis hasta 1000 cadenas, un usuario, idiomas ilimitados, proyectos ilimitados
  * [webtranslateit.com](https://webtranslateit.com/) — Gratis hasta 500 cadenas
  * [weblate.org](https://weblate.org/) — Gratis para proyectos libres con hasta 10,000 fuentes de cadena para el nivel gratuito y autoalojado ilimitado en las instalaciones.
  * [Free PO editor](https://pofile.net/free-po-editor) — Gratis para todos
  * [Lingo.dev](https://lingo.dev) – CLI de código abierto potenciada por IA para localización web y móvil. Usa tu propio LLM, o utiliza 10,000 palabras gratis cada mes a través del motor de localización gestionado por Lingo.dev.

**[⬆️ Volver al inicio](#table-of-contents)**

## Monitorización

  * [UptimeObserver.com](https://uptimeobserver.com) - Obtén 20 monitores de disponibilidad con intervalos de 5 minutos y una página de estado personalizable, incluso para uso comercial. Disfruta de notificaciones ilimitadas y en tiempo real por correo electrónico y Telegram. No necesitas tarjeta de crédito para comenzar.
  * [Pingmeter.com](https://pingmeter.com/) - 5 monitores de disponibilidad con intervalo de 10 minutos. Monitoriza SSH, HTTP, HTTPS y cualquier puerto TCP personalizado.
  * [alerty.ai](https://www.alerty.ai) - APM y monitorización gratuita para tu FE, BE, DB y más + ejecuciones de agente gratuitas.
  * [appdynamics.com](https://www.appdynamics.com/) — Gratis para métricas de 24 horas, agentes de gestión de rendimiento de aplicaciones limitados a un Java, un .NET, un PHP y un Node.js
  * [appneta.com](https://www.appneta.com/) — Gratis con retención de datos de 1 hora
  * [appspector.com](https://appspector.com/) - Control de misión para depuración remota de iOS/Android/Flutter. Gratis para bajo uso de tráfico (64MB de logs).
  * [assertible.com](https://assertible.com) — Pruebas y monitorización automatizada de APIs. Planes gratuitos para equipos e individuos.
  * [bleemeo.com](https://bleemeo.com) - Gratis para 3 servidores, 5 monitores de disponibilidad, usuarios ilimitados, dashboards ilimitados, reglas de alerta ilimitadas.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - Encuentra el historial de Core Web Vitals para una URL o un sitio web.
  * [checklyhq.com](https://checklyhq.com) - Monitorización E2E/Sintética de código abierto y monitorización profunda de API para desarrolladores. Plan gratuito con un usuario y 10k ejecuciones de comprobación de API/red y 1.5k de navegador.
  * [cloudsploit.com](https://cloudsploit.com) — Monitorización de seguridad y configuración de AWS. Gratis: escaneos bajo demanda ilimitados, usuarios ilimitados, cuentas almacenadas ilimitadas. Suscripción: escaneo automatizado, acceso API, etc.
  * [cronitor.io](https://cronitor.io/) - Información de rendimiento y monitorización de disponibilidad para trabajos cron, sitios web, APIs y más. Nivel gratuito con cinco monitores.
  * [datadoghq.com](https://www.datadoghq.com/) — Gratis para hasta 5 nodos
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — Monitorización para trabajos cron. Un monitor gratis, más si refieres a otros para que se registren
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60 monitores de disponibilidad, intervalo de 5 minutos. Alertas por Email, Slack.
  * [economize.cloud](https://economize.cloud) — Economize ayuda a desmitificar los costes de infraestructura cloud organizando los recursos cloud para optimizar y reportar lo mismo. Gratis hasta $5,000 gastados en Google Cloud Platform cada mes.
  * [elastic.co](https://www.elastic.co/solutions/apm) — Información instantánea sobre el rendimiento para desarrolladores JS. Gratis con retención de datos de 24 horas
  * [fivenines.io](https://fivenines.io/) — Monitorización de servidores Linux con dashboards en tiempo real y alertas — gratis para siempre para hasta 5 servidores monitorizados con intervalos de 60 segundos. No se requiere tarjeta de crédito.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud es una plataforma de observabilidad componible que integra métricas y logs con Grafana. Gratis: 3 usuarios, diez dashboards, 100 alertas, almacenamiento de métricas en Prometheus y Graphite (10,000 series, 14 días de retención), almacenamiento de logs en Loki (50 GB de logs, 14 días de retención)
  * [healthchecks.io](https://healthchecks.io) — Monitoriza tus trabajos cron y tareas en segundo plano. Gratis para hasta 20 comprobaciones.
  * [Hydrozen.io](https://hydrozen.io) — Monitorización de disponibilidad y páginas de estado, plan gratuito: 10 monitores de disponibilidad, 5 monitores de latido, 1 monitor de dominio y 1 página de estado gratis.
  * [incidenthub.cloud](https://incidenthub.cloud/) — Agregador de páginas de estado cloud y SaaS - 20 monitores y 2 canales de notificación (Slack y Discord) gratis para siempre.
  * [inspector.dev](https://www.inspector.dev) - Un dashboard completo de monitorización en tiempo real en menos de un minuto con un plan gratuito para siempre.
  * [instrumentalapp.com](https://instrumentalapp.com) - Monitorización de aplicaciones y servidores fácil de usar y visualmente atractiva con hasta 500 métricas y 3 horas de visibilidad de datos gratis
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Test de velocidad independiente y test de latencia de handshake TLS contra Digital Ocean
  * [letsmonitor.org](https://letsmonitor.org) - Monitorización SSL, gratis para hasta 5 monitores
  * [linkok.com](https://linkok.com) - Comprobador de enlaces rotos online, gratis para sitios web pequeños de hasta 100 páginas, completamente gratis para proyectos open-source.
  * [loader.io](https://loader.io/) — Herramientas de pruebas de carga gratuitas con limitaciones
  * [MonitorMonk](https://monitormonk.com) - Monitorización minimalista de disponibilidad con hermosas páginas de estado. El plan Forever Free ofrece monitorización HTTPS, de palabra clave, SSL y de tiempo de respuesta para 10 sitios web o endpoints de API, y proporciona 2 dashboards/páginas de estado.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata es una herramienta open-source para recopilar métricas en tiempo real. ¡Es un producto en crecimiento y también puede encontrarse en GitHub!
  * [newrelic.com](https://www.newrelic.com) — Plataforma de observabilidad de New Relic diseñada para ayudar a los ingenieros a crear un software más perfecto. Desde monolitos hasta serverless, puedes instrumentar todo y luego analizar, depurar y optimizar toda tu pila de software. El plan gratuito ofrece 100GB/mes de ingesta de datos gratis, un usuario de acceso completo gratis y usuarios primarios ilimitados gratis.
  * [Middleware.io](https://middleware.io/) - Plataforma de observabilidad Middleware que proporciona visibilidad completa en tus apps y stack, para que puedas monitorizar y diagnosticar problemas a escala. Tienen un plan gratuito para siempre para la comunidad de desarrollo que permite monitorización de logs para hasta 1M de eventos de logs, monitorización de infraestructura y APM para hasta 2 hosts.
  * [nixstats.com](https://nixstats.com) - Gratis para un servidor. Notificaciones por email, página de estado pública, intervalo de 60 segundos y más.
  * [OnlineOrNot.com](https://onlineornot.com/) - OnlineOrNot proporciona monitorización de disponibilidad para sitios web y APIs, monitorización para trabajos cron y tareas programadas. También proporciona páginas de estado. Las primeras cinco comprobaciones con intervalo de 3 minutos son gratis. El nivel gratuito envía alertas por Slack, Discord y Email.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — Comprueba si un sitio web está bloqueado en China por el Gran Cortafuegos. Identifica la contaminación DNS comparando resultados DNS e información ASN detectada por servidores en China frente a servidores en Estados Unidos.
  * [opsgenie.com](https://www.opsgenie.com/) — Potente sistema de alertas y gestión de guardias para operar servicios siempre activos. Gratis para hasta 5 usuarios.
  * [paessler.com](https://www.paessler.com/) — Potente solución de monitorización de infraestructura y red, incluyendo alertas, capacidades de visualización avanzadas e informes básicos. Gratis para hasta 100 sensores.
  * [pagecrawl.io](https://pagecrawl.io/) -  Monitoriza cambios en sitios web, gratis para hasta 6 monitores con comprobaciones diarias.
  * [syagent.com](https://syagent.com/) — Servicio gratuito no comercial de monitorización de servidores, alertas y métricas.
  * [pagerly.io](https://pagerly.io/) -  Gestiona guardias en Slack (se integra con Pagerduty, OpsGenie). Gratis para hasta 1 equipo (un equipo se refiere a una guardia)
  * [pagertree.com](https://pagertree.com/) - Interfaz sencilla para alertas y gestión de guardias. Gratis hasta 5 usuarios.
  * [phare.io](https://phare.io/) - Monitorización de disponibilidad gratis para hasta 100,000 eventos para proyectos y páginas de estado ilimitadas.
  * [pingbreak.com](https://pingbreak.com/) — Servicio moderno de monitorización de disponibilidad. Comprueba URLs ilimitadas y recibe notificaciones de caídas vía Discord, Slack o email.
  * [pingpong.one](https://pingpong.one/) — Plataforma avanzada de páginas de estado con monitorización. El nivel gratuito incluye una página de estado pública personalizable con subdominio SSL. El plan Pro se ofrece gratis a proyectos open-source y ONGs.
  * [robusta.dev](https://home.robusta.dev/) — Potente monitorización de Kubernetes basada en Prometheus. Usa tu propio Prometheus o instala el paquete todo en uno. El nivel gratuito incluye hasta 20 nodos Kubernetes. Alertas vía Slack, Microsoft Teams, Discord y más. Integraciones con PagerDuty, OpsGenie, VictorOps, DataDog y muchas otras herramientas.
  * [sematext.com](https://sematext.com/) — Gratis para métricas de 24 horas, servidores ilimitados, diez métricas personalizadas, 500,000 puntos de datos de métricas personalizadas, dashboards ilimitados, usuarios, etc.
  * [sitemonki.com](https://sitemonki.com/) — Monitorización de sitios web, dominios, Cron y SSL, 5 monitores en cada categoría gratis
  * [sitesure.net](https://sitesure.net) - Monitorización de sitios web y cron - 2 monitores gratis
  * [skylight.io](https://www.skylight.io/) — Gratis para los primeros 100,000 requests (sólo Rails)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — API de Monitorización de Rendimiento, comprueba Ping, DNS, etc.
  * [stathat.com](https://www.stathat.com/) — Empieza con diez estadísticas gratis, sin expiración
  * [statuscake.com](https://www.statuscake.com/) — Monitorización de sitios web, tests ilimitados gratis con limitaciones
  * [statusgator.com](https://statusgator.com/) — Monitorización de páginas de estado, 3 monitores gratis
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — Monitorización de servidores, monitorización de disponibilidad, monitorización de DNS y dominios. Monitoriza 10 servidores, 10 disponibilidades y 10 dominios gratis.
  * [thousandeyes.com](https://www.thousandeyes.com/) — Monitorización de red y experiencia de usuario. 3 ubicaciones y 20 feeds de datos de servicios web principales gratis
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — Monitorización gratuita para cinco sitios web, intervalos de 60 segundos, página de estado pública.
  * [zenduty.com](https://www.zenduty.com/) — Plataforma integral de gestión de incidentes, alertas, gestión de guardias y orquestación de respuesta para operaciones de red, SRE y equipos DevOps. Gratis hasta 5 usuarios.
  * [instatus.com](https://instatus.com) - Obtén una hermosa página de estado en 10 segundos. Gratis para siempre con suscriptores y equipos ilimitados.
  * [Squadcast.com](https://squadcast.com) - Squadcast es un software integral de gestión de incidentes diseñado para ayudarte a fomentar las mejores prácticas de SRE. Plan gratis para siempre disponible para hasta 10 usuarios.
  * [RoboMiri.com](https://robomiri.com/) - RoboMiri es un monitor de disponibilidad estable que ofrece una amplia gama de monitores: cronjob, palabra clave, sitio web, puerto, ping. Veinticinco comprobaciones de disponibilidad con intervalos de 3 minutos gratis. Alertas por llamada telefónica, SMS, correo electrónico y Webhooks.
  * [Better Stack](https://betterstack.com/better-uptime) - Monitorización de disponibilidad, gestión de incidentes, programación/alertas de guardias y páginas de estado en un solo producto. El plan gratuito incluye diez monitores con frecuencia de comprobación de 3 minutos y páginas de estado.
  * [Pulsetic](https://pulsetic.com) - 10 monitores, 6 meses de histórico de disponibilidad/logs, páginas de estado ilimitadas y dominios personalizados incluidos. Para siempre y alertas por email ilimitadas gratis. No necesitas tarjeta de crédito.
  * [Wachete](https://www.wachete.com) - Monitoriza cinco páginas, comprobaciones cada 24 horas.
  * [Xitoring.com](https://xitoring.com/) — Monitorización de disponibilidad: 20 gratis, monitorización de servidores Linux y Windows: 5 gratis, página de estado: 1 gratis - App móvil, múltiples canales de notificación y mucho más.
  * [Servervana](https://servervana.com) - Monitorización avanzada de disponibilidad con soporte para grandes proyectos y equipos. Ofrece monitorización HTTP, monitorización basada en navegador, monitorización DNS, monitorización de dominios, páginas de estado y más. El nivel gratuito incluye 10 monitores HTTP, 1 monitor DNS y una página de estado.

**[⬆️ Volver al inicio](#table-of-contents)**

## Gestión de Errores y Excepciones
  * [CatchJS.com](https://catchjs.com/) - Seguimiento de errores de JavaScript con capturas de pantalla y registro de clics. Gratis para proyectos de código abierto.
  * [bugsnag.com](https://www.bugsnag.com/) — Gratis hasta 2,000 errores/mes después del periodo de prueba inicial.
  * [elmah.io](https://elmah.io/) — Registro de errores y monitoreo de tiempo de actividad para desarrolladores web. Suscripción Small Business gratuita para proyectos de código abierto.
  * [Embrace](https://embrace.io/) — Monitoreo de aplicaciones móviles. Gratis para equipos pequeños con hasta 1 millón de sesiones de usuario por año.
  * [exceptionless](https://exceptionless.com) — Informes en tiempo real de errores, características, registros y más. Gratis para 3,000 eventos por mes/1 usuario. De código abierto y fácil de autohospedar para uso ilimitado.
  * [GlitchTip](https://glitchtip.com/) — Seguimiento de errores simple y de código abierto. Compatible con SDKs de Sentry de código abierto. 1000 eventos por mes gratis, o puedes autohospedarlo sin límites.
  * [honeybadger.io](https://www.honeybadger.io) - Monitoreo de excepciones, tiempo de actividad y cron. Gratis para equipos pequeños y proyectos de código abierto (12,000 errores/mes).
  * [memfault.com](https://memfault.com) — Plataforma en la nube para observabilidad y depuración de dispositivos. 100 dispositivos gratis para [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp) y [Laird](https://app.memfault.com/register-laird).
  * [rollbar.com](https://rollbar.com/) — Monitoreo de excepciones y errores, plan gratuito con 5,000 errores/mes, usuarios ilimitados, retención de 30 días.
  * [sentry.io](https://sentry.io/) — Sentry rastrea excepciones de aplicaciones en tiempo real y tiene un plan gratuito pequeño. Gratis para 5,000 errores por mes/1 usuario, uso sin restricciones si se autohospeda.
  * [Axiom](https://axiom.co/) — Almacena hasta 0.5 TB de registros con retención de 30 días. Incluye integraciones con plataformas como Vercel y consultas avanzadas de datos con notificaciones por email/Discord.
  * [Semaphr](https://semaphr.com) — Kill switch todo en uno gratuito para tus aplicaciones móviles.
  * [Jam](https://jam.dev) - Informes de errores amigables para desarrolladores en un solo clic. Plan gratuito con jams ilimitados.
  * [Whitespace](https://whitespace.dev) – Informes de errores en un clic directamente en tu navegador. Plan gratuito con grabaciones ilimitadas para uso personal.

**[⬆️ Volver al inicio](#table-of-contents)**

## Búsqueda

  * [algolia.com](https://www.algolia.com/) — Solución de búsqueda alojada con tolerancia a errores tipográficos, relevancia y librerías de UI para crear experiencias de búsqueda fácilmente. El plan gratuito "Build" incluye 1M de documentos y 10K búsquedas/mes. También ofrece [búsqueda de documentación para desarrolladores](https://docsearch.algolia.com/) gratis.
  * [bonsai.io](https://bonsai.io/) — 1 GB de memoria y 1 GB de almacenamiento gratis.
  * [CommandBar](https://www.commandbar.com/) - Barra de búsqueda unificada como servicio, widget/plugin web que permite a tus usuarios buscar contenido, navegación, funciones, etc. dentro de tu producto, lo que ayuda en la descubribilidad. Gratis hasta 1,000 usuarios activos mensuales, comandos ilimitados.
  * [Orama Cloud](https://orama.com/pricing) — 3 índices gratis, 100K documentos/índice, búsquedas full-text/vector/híbridas ilimitadas, 60 días de analíticas.
  * [searchly.com](http://www.searchly.com/) — 2 índices gratuitos y 20 MB de almacenamiento.
  * [easysitesearch.com](https://easysitesearch.com/) — Widget de búsqueda y API, con indexación automatizada basada en web crawler. Búsquedas ilimitadas gratis, hasta 50 subpáginas.

**[⬆️ Volver al inicio](#table-of-contents)**

## Educación y Desarrollo Profesional

  * [FreeCodeCamp](https://www.freecodecamp.org/) - Plataforma de código abierto que ofrece cursos y certificaciones gratuitas en Análisis de Datos, Seguridad Informática, Desarrollo Web y más.
  * [The Odin Project](https://www.theodinproject.com/) - Plataforma gratuita y de código abierto con un currículo enfocado en JavaScript y Ruby para desarrollo web.
  * [Plantillas de Currículum Vitae Profesionales Gratis & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - Plataforma gratuita con muchas plantillas de CV de profesionales experimentados, listas para clonar, editar completamente y descargar, optimizadas para ATS.
  * [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - Cursos cortos gratuitos de expertos líderes en la industria para obtener experiencia práctica con las últimas herramientas y técnicas de IA generativa en una hora o menos.
  * [LabEx](https://labex.io) - Desarrolla habilidades en Linux, DevOps, Ciberseguridad, Programación, Ciencia de Datos y más a través de laboratorios interactivos y proyectos reales.
  * [Roadmap.sh](https://roadmap.sh) - Mapas de aprendizaje gratuitos que cubren todos los aspectos del desarrollo, desde Blockchain hasta Diseño UX.
  * [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - Ofrece cursos gratuitos alineados a certificaciones en temas como ciberseguridad, redes y Python.
  * [MIT OpenCourseWare](https://ocw.mit.edu/) - MIT OpenCourseWare es una publicación en línea de materiales de más de 2,500 cursos de MIT, compartiendo conocimiento libremente con estudiantes y educadores en todo el mundo. El canal de Youtube se puede encontrar en [@mitocw](https://www.youtube.com/@mitocw/featured)
  * [W3Schools](https://www.w3schools.com/) - Ofrece tutoriales gratuitos sobre tecnologías de desarrollo web como HTML, CSS, JavaScript y más.
  * [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - Guías en línea gratuitas para aprender HTML/CSS, JavaScript y SQL desde nivel básico hasta avanzado.
  * [Full Stack Open](https://fullstackopen.com/en/) – Curso universitario gratuito sobre desarrollo web moderno con React, Node.js, GraphQL, TypeScript y más. Completamente online y a tu propio ritmo.
  * [edX](https://www.edx.org/) - Ofrece acceso a más de 4,000 cursos gratuitos en línea de 250 instituciones líderes, incluyendo Harvard y MIT, especializándose en informática, ingeniería y ciencia de datos.
  * [Django-tutorial.dev](https://django-tutorial.dev) - Guías en línea gratuitas para aprender Django como su primer framework y ofrece un backlink dofollow gratuito a los artículos escritos por los usuarios.

**[⬆️ Volver al inicio](#table-of-contents)**

## Email

  * [10minutemail](https://10minutemail.com) - Email temporal gratis para pruebas.
  * [AhaSend](https://ahasend.com) - Servicio de email transaccional, gratis para 1,000 emails por mes, con dominios ilimitados, miembros de equipo, webhooks y rutas de mensajes en el plan gratuito.
  * [AnonAddy](https://anonaddy.com) - Reenvío anónimo de emails de código abierto, crea alias de email ilimitados gratis.
  * [Antideo](https://www.antideo.com) — 10 solicitudes de API por hora para verificación de email, IP y validación de número de teléfono en el nivel gratuito. No requiere tarjeta de crédito.
  * [Brevo](https://www.brevo.com/) — 9,000 emails/mes, 300 emails/día gratis.
  * [OneSignal](https://onesignal.com/) — 10,000 emails/mes, no requiere tarjeta de crédito.
  * [Bump](https://bump.email/) - 10 direcciones de email Bump gratuitas, un dominio personalizado.
  * [Burnermail](https://burnermail.io/) – 5 direcciones de email Burner gratis, 1 buzón, 7 días de historial de buzón.
  * [Buttondown](https://buttondown.email/) — Servicio de newsletter. Hasta 100 suscriptores gratis.
  * [CloudMailin](https://www.cloudmailin.com/) - Email entrante vía HTTP POST y saliente transaccional - 10,000 emails gratis/mes.
  * [Contact.do](https://contact.do/) — Formulario de contacto en un enlace (bitly para formularios de contacto).
  * [debugmail.io](https://debugmail.io/) — Servidor de correo de pruebas fácil de usar para desarrolladores.
  * [DNSExit](https://dnsexit.com/) - Hasta 2 direcciones de email bajo tu dominio gratis con 100MB de almacenamiento. Soporte IMAP, POP3, SMTP, SPF/DKIM.
  * [EmailLabs.io](https://emaillabs.io/en) — Envía hasta 9,000 emails gratis cada mes, hasta 300 emails diarios.
  * [EmailOctopus](https://emailoctopus.com) - Hasta 2,500 suscriptores y 10,000 emails al mes gratis.
  * [EmailJS](https://www.emailjs.com/) – No es un servidor de email completo; es solo un cliente de email que puedes usar para enviar emails directamente desde el cliente sin exponer tus credenciales, el nivel gratuito tiene 200 solicitudes mensuales, 2 plantillas de email, solicitudes de hasta 50Kb, historial de contactos limitado.
  * [EtherealMail](https://ethereal.email) - Ethereal es un servicio SMTP falso, principalmente dirigido a usuarios de Nodemailer y EmailEngine (pero no limitado a ellos). Es un servicio de email anti-transaccional completamente gratuito donde los mensajes nunca se entregan.
  * [Temp-Mail.org](https://temp-mail.org/en/) - Generador de email temporal/desechable utilizando una variedad de dominios. La dirección de email se refresca cada vez que se recarga la página. Es completamente gratis y no tiene ningún precio por sus servicios.
  * [TempMailDetector.com](https://tempmaildetector.com/) - Verifica hasta 200 emails al mes gratis y comprueba si un email es temporal o no.
  * [Emailvalidation.io](https://emailvalidation.io) - 100 verificaciones de email gratis por mes.
  * [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - Generador alemán de email temporal/desechable. Soporta 10 dominios, permitiéndote crear direcciones ilimitadas. (incluye anuncios), pero fuera de eso, es completamente gratis.
  * [forwardemail.net](https://forwardemail.net) — Reenvío de correo gratuito para dominios personalizados. Crea y reenvía una cantidad ilimitada de direcciones de email con tu nombre de dominio (**nota**: Debes pagar si usas los TLD .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work debido a spam)
  * [Imitate Email](https://imitate.email) - Servidor de email sandbox para probar la funcionalidad de email en build/qa y ci/cd. Las cuentas gratuitas obtienen 15 emails al día para siempre.
  * [ImprovMX](https://improvmx.com) – Reenvío de emails gratuito.
  * [EForw](https://www.eforw.com) – Reenvío de emails gratuito para un dominio. Recibe y envía emails desde tu dominio.
  * [Inboxes App](https://inboxesapp.com) — Crea hasta 3 emails temporales al día y elimínalos cuando termines desde una práctica extensión de Chrome. Perfecto para probar flujos de registro.
  * [inboxkitten.com](https://inboxkitten.com/) - Buzón de email temporal/desechable gratuito, con auto-eliminación de emails de hasta 3 días. Código abierto y se puede autohospedar.
  * [mail-tester.com](https://www.mail-tester.com/) — Prueba si la configuración DNS/SPF/DKIM/DMARC del email es correcta, 20 gratis/mes.
  * [dkimvalidator.com](https://dkimvalidator.com/) - Prueba si la configuración DNS/SPF/DKIM/DMARC del email es correcta, servicio gratuito de roundsphere.com.
  * [mailcatcher.me](https://mailcatcher.me/) — Captura emails y los muestra a través de una interfaz web.
  * [mailchannels.com](https://www.mailchannels.com) - API de correo electrónico con integraciones REST API y SMTP, gratis hasta 3,000 emails/mes.
  * [Mailcheck.ai](https://www.mailcheck.ai/) - Evita que los usuarios se registren con direcciones de email temporales, 120 solicitudes/hora (~86,400 por mes).
  * [Mailchimp](https://mailchimp.com/) — 500 suscriptores y 1,000 emails/mes gratis.
  * [Maildroppa](https://maildroppa.com) - Hasta 100 suscriptores y emails ilimitados, así como automatizaciones gratis.
  * [MailerLite.com](https://www.mailerlite.com) — 1,000 suscriptores/mes, 12,000 emails/mes gratis.
  * [MailerSend.com](https://www.mailersend.com) — API de email, SMTP, 3,000 emails/mes gratis para emails transaccionales.
  * [mailinator.com](https://www.mailinator.com/) — Sistema de email público y gratuito donde puedes usar cualquier buzón que quieras.
  * [Mailjet](https://www.mailjet.com/) — 6,000 emails/mes gratis (límite de envío diario de 200 emails).
  * [Mailnesia](https://mailnesia.com) - Email temporal/desechable gratis, que visita automáticamente el enlace de registro.
  * [mailsac.com](https://mailsac.com) - API gratuita para pruebas de email temporal, alojamiento público gratuito de email, captura de salida, email a slack/websocket/webhook (límite de 1,500 API mensuales).
  * [Mailtrap.io](https://mailtrap.io/) — Servidor SMTP falso para desarrollo, plan gratuito con una bandeja de entrada, 100 mensajes, sin miembros de equipo, dos emails/segundo, sin reglas de reenvío.
  * [Mail7.io](https://www.mail7.io/) — Direcciones de email temporales gratis para desarrolladores de QA. Crea direcciones de email instantáneamente usando la interfaz web o la API.
  * [Momentary Email](https://www.momentaryemail.com/) — Direcciones de email temporales gratis. Lee los emails entrantes en el sitio web o mediante un feed RSS.
  * [Mutant Mail](https://www.mutantmail.com/) – 10 IDs de email gratis, 1 dominio, 1 buzón. Un solo buzón para todos los IDs de email.
  * [Outlook.com](https://outlook.live.com/owa/) - Email personal y calendario gratuito.
  * [Parsio.io](https://parsio.io) — Analizador de emails gratuito (Reenvía el email, extrae los datos, envíalos a tu servidor).
  * [pepipost.com](https://pepipost.com) — 30,000 emails gratis el primer mes, luego los primeros 100 emails/día gratis.
  * [Plunk](https://useplunk.com) - 3,000 emails/mes gratis.
  * [Postmark](https://postmarkapp.com/) - 100 emails/mes gratis, resúmenes DMARC semanales ilimitados.
  * [Proton Mail](https://proton.me/mail) - Servicio de email seguro gratuito con cifrado de extremo a extremo incorporado. 1GB de almacenamiento gratis.
  * [Queuemail.dev](https://queuemail.dev) — API de entrega de email confiable. Nivel gratuito (10,000 emails/mes). Envía de forma asíncrona. Usa varios servidores SMTP. Listas negras, registros, seguimiento, webhooks y más.
  * [QuickEmailVerification](https://quickemailverification.com) — Verifica 100 emails diarios gratis en el nivel gratuito junto con otras APIs gratuitas como Detector DEA, Búsqueda DNS, Detector SPF y más.
* [Resend](https://resend.com) - API de correos electrónicos transaccionales para desarrolladores. 3,000 correos/mes, 100 correos/día gratis, un dominio personalizado.
* [Sender](https://www.sender.net) Hasta 15,000 correos/mes, hasta 2,500 suscriptores.
* [Sendpulse](https://sendpulse.com) — 500 suscriptores/mes, 15,000 correos/mes gratis.
* [SimpleLogin](https://simplelogin.io/) – Solución de alias/redirección de correo electrónico de código abierto y autohospedable. Gratis 5 alias, ancho de banda ilimitado, respuestas/envíos ilimitados. Gratis para personal educativo (estudiantes, investigadores, etc.).
* [Substack](https://substack.com) — Servicio de boletines ilimitados y gratuito. Empieza a pagar cuando cobras por él.
* [Sweego](https://www.sweego.io/) - API europea de correos electrónicos transaccionales para desarrolladores. 500 correos/día gratis.
* [Takeout](https://takeout.bysourfruit.com) - Servicio de correo electrónico en constante actualización que facilita el envío de correos. Quinientos correos electrónicos transaccionales/mes gratis.
* [temp-mail.io](https://temp-mail.io) — Servicio gratuito de correo temporal desechable con múltiples correos simultáneos y reenvío.
* [tinyletter.com](https://tinyletter.com/) — 5,000 suscriptores/mes gratis.
* [Touchlead](https://touchlead.app) - Herramienta multipropósito de automatización de marketing, con gestión de leads, creador de formularios y automatización. Gratis para un número limitado de leads y automatizaciones.
* [trashmail.com](https://www.trashmail.com) - Direcciones de correo desechables gratuitas con reenvío y expiración automática de la dirección.
* [Tuta](https://tuta.com/) - Proveedor de servicio de correo electrónico seguro y gratuito con cifrado de extremo a extremo integrado, sin anuncios, sin rastreo. 1GB de almacenamiento gratis, un calendario (Tuta también tiene un [plan de pago](https://tuta.com/pricing).). Tuta es también parcialmente [código abierto](https://github.com/tutao/tutanota), por lo que puedes autohospedar.
* [Verifalia](https://verifalia.com/email-verification-api) — API de verificación de correo en tiempo real con confirmación de buzón y detector de correos desechables; 25 verificaciones gratuitas/día.
* [verimail.io](https://verimail.io/) — Servicio de verificación de correo por lotes y API. 100 verificaciones gratuitas/mes.
* [Zoho](https://www.zoho.com) — Comenzó como proveedor de correo electrónico pero ahora ofrece un conjunto de servicios, algunos de los cuales tienen planes gratuitos. Lista de servicios con planes gratuitos:
   - [Email](https://zoho.com/mail) Gratis para 5 usuarios. 5GB/usuario y límite de adjuntos de 25MB, un dominio.
   - [Zoho Assist](https://www.zoho.com/assist) — El plan gratuito para siempre de Zoho Assist incluye una licencia de soporte remoto concurrente y acceso a 5 licencias de computadoras desatendidas por duración ilimitada, disponible tanto para uso profesional como personal.
   - [Sprints](https://zoho.com/sprints) Gratis para 5 usuarios, 5 proyectos y 500MB de almacenamiento.
   - [Docs](https://zoho.com/docs) — Gratis para 5 usuarios con límite de carga de 1GB y 5GB de almacenamiento. Zoho Office Suite (Writer, Sheets y Show) viene incluido.
   - [Projects](https://zoho.com/projects) — Gratis para 3 usuarios, 2 proyectos y límite de adjuntos de 10MB. El mismo plan aplica para [Bugtracker](https://zoho.com/bugtracker).
   - [Connect](https://zoho.com/connect) — Colaboración en equipo gratis para 25 usuarios con tres grupos, tres apps personalizadas, 3 tableros, 3 manuales y 10 integraciones junto con canales, eventos y foros.
   - [Meeting](https://zoho.com/meeting) — Reuniones con hasta 3 participantes y 10 asistentes en seminarios web.
   - [Vault](https://zoho.com/vault) — Gestión de contraseñas accesible para individuos.
   - [Showtime](https://zoho.com/showtime) — Otro software de reuniones para capacitación en sesiones remotas de hasta 5 asistentes.
   - [Notebook](https://zoho.com/notebook) — Una alternativa gratuita a Evernote.
   - [Wiki](https://zoho.com/wiki) — Gratis para tres usuarios con 50MB de almacenamiento, páginas ilimitadas, copias de seguridad en zip, RSS y Atom feed, controles de acceso y CSS personalizable.
   - [Subscriptions](https://zoho.com/subscriptions) — Gestión de facturación recurrente gratis para 20 clientes/suscripciones y 1 usuario con todo el alojamiento de pagos realizado por Zoho. Se almacenan las últimas 40 métricas de suscripción.
   - [Checkout](https://zoho.com/checkout) — Gestión de facturación de productos con 3 páginas y hasta 50 pagos.
   - [Desk](https://zoho.com/desk) — Gestión de soporte al cliente con tres agentes, base de conocimientos privada y tickets por correo. Se integra con [Assist](https://zoho.com/assist) para un técnico remoto y 5 computadoras desatendidas.
   - [Cliq](https://zoho.com/cliq) — Software de chat para equipos con 100GB de almacenamiento, usuarios ilimitados, 100 usuarios por canal y SSO.
   - [Campaigns](https://zoho.com/campaigns) - Email Marketing.
   - [Forms](https://zoho.com/forms) - Creador de Formularios.
   - [Sign](https://zoho.com/sign) - Firmas sin papel.
   - [Surveys](https://zoho.com/surveys) - Encuestas en línea.
   - [Bookings](https://zoho.com/bookings) - Programación de citas.
* [Maileroo](https://maileroo.com) - Relé SMTP y API de correo para desarrolladores. 5,000 correos mensuales, dominios ilimitados, verificación de correos gratuita, monitoreo de listas negras, mail tester y más.

**[⬆️ Volver arriba](#table-of-contents)**

## Plataformas de gestión de Feature Toggles

* [ConfigCat](https://configcat.com) - ConfigCat es un servicio de feature flags centrado en desarrolladores con tamaño de equipo ilimitado, excelente soporte y precio razonable. Plan gratuito hasta 10 flags, dos entornos, 1 producto y 5 millones de solicitudes al mes.
* [Flagsmith](https://flagsmith.com) - Lanza funciones con confianza; gestiona feature flags en aplicaciones web, móviles y del lado del servidor. Usa nuestra API alojada, despliega en tu propia nube privada o ejecuta on-premise.
* [GrowthBook](https://growthbook.io) - Proveedor de feature flags y pruebas A/B de código abierto con motor de análisis estadístico bayesiano integrado. Gratis para hasta 3 usuarios, flags y experimentos ilimitados.
* [Hypertune](https://www.hypertune.com) - Feature flags tipados, pruebas A/B, analítica y configuración de apps, con control de versiones estilo Git y evaluación local síncrona en memoria. Gratis para hasta 5 miembros del equipo con flags y tests A/B ilimitados.
* [Molasses](https://www.molasses.app) - Potentes feature flags y pruebas A/B. Gratis hasta 3 entornos con cinco flags cada uno.
* [Toggled.dev](https://www.toggled.dev) - Plataforma de gestión de toggles de características lista para empresas, escalable y multirregional. Plan gratis hasta 10 flags, dos entornos, solicitudes ilimitadas. SDK, panel de análisis, calendario de lanzamientos, notificaciones por Slack y todas las demás funciones incluidas en el plan gratuito ilimitado.
* [Statsig](https://www.statsig.com) - Plataforma robusta para gestión de funcionalidades, pruebas A/B, analítica y más. Su generoso plan gratuito ofrece asientos, flags, experimentos y configuraciones dinámicas ilimitadas, admitiendo hasta 1 millón de eventos por mes.
* [Abby](https://www.tryabby.com) - Feature flags y pruebas A/B de código abierto. Configuración como código y SDKs completamente tipados en Typescript. Fuerte integración con frameworks como Next.js y React. Nivel gratuito generoso y opciones de escalado económicas.

**[⬆️ Volver arriba](#table-of-contents)**

## Fuentes

* [dafont](https://www.dafont.com/) - Las fuentes presentadas en este sitio web son propiedad de sus autores y son freeware, shareware, versiones demo o dominio público.
* [Everything Fonts](https://everythingfonts.com/) - Ofrece múltiples herramientas; @font-face, conversor de unidades, Font Hinter y Font Submitter.
* [Font Squirrel](https://www.fontsquirrel.com/) - Fuentes freeware licenciadas para trabajo comercial. Tipografías seleccionadas a mano y presentadas en un formato fácil de usar.
* [Google Fonts](https://fonts.google.com/) - Muchas fuentes gratuitas, fáciles y rápidas de instalar en un sitio web vía descarga o enlace al CDN de Google.
* [FontGet](https://www.fontget.com/) - Tiene una variedad de fuentes disponibles para descargar y ordenadas por etiquetas.
* [Fontshare](https://www.fontshare.com/) - Servicio de fuentes gratuito. Colección creciente de fuentes profesionales, 100% gratis para uso personal y comercial.
* [Befonts](https://befonts.com/) - Proporciona varias fuentes únicas para uso personal o comercial.
* [Font of web](https://fontofweb.com/) - Identifica todas las fuentes usadas en un sitio web y cómo se utilizan.
* [Bunny](https://fonts.bunny.net) Alternativa a Google Fonts orientada a la privacidad.
* [FontsKey](https://www.fontskey.com/) - Ofrece fuentes gratuitas y comerciales para uso personal y permite ingresar texto para filtrado rápido.
* [fonts.xz.style](https://fonts.xz.style/) servicio gratuito y de código abierto para entregar familias tipográficas a sitios web usando CSS.
* [Fontsensei](https://fontsensei.com/) Google Fonts open source etiquetadas por usuarios. Con etiquetas para fuentes CJK (Chino, Japonés, Coreano).

**[⬆️ Volver arriba](#table-of-contents)**

## Formularios

* [Feathery](https://feathery.io) - Potente creador de formularios amigable para desarrolladores. Construya flujos de registro, inicio de sesión, onboarding de usuario, pagos, aplicaciones financieras complejas y más. El plan gratuito permite hasta 250 envíos/mes y cinco formularios activos.
* [Form-Data](https://form-data.com) - Backend de formularios sin código. Filtro de spam, notificación por correo y autorespuesta, webhooks, zapier, redirecciones, AJAX o POST, y más. El plan gratuito ofrece formularios ilimitados, 20 envíos/mes y 2,000 envíos adicionales con la insignia de Form-Data.
* [FabForm](https://fabform.io/) - Plataforma backend de formularios para desarrolladores inteligentes. El plan gratuito permite 250 envíos por mes. GUI moderna y amigable. Se integra con Google Sheets, Airtable, Slack, Email y otros.
* [Form.taxi](https://form.taxi/) — Endpoint para envíos de formularios HTML. Con notificaciones, bloqueadores de spam y procesamiento de datos conforme a GDPR. Plan gratuito para uso básico.
* [Formcarry.com](https://formcarry.com) - Endpoint HTTP POST para formularios, el plan gratis permite 100 envíos mensuales.
* [formingo.co](https://www.formingo.co/)- Formularios HTML fáciles para sitios estáticos. Puedes empezar gratis sin crear una cuenta. El plan gratuito permite 500 envíos mensuales y un correo de respuesta personalizable.
* [FormKeep.com](https://www.formkeep.com/) - Formularios ilimitados con 50 envíos mensuales, protección contra spam, notificación por correo y diseñador drag-and-drop que puede exportar HTML. Características adicionales: reglas de campos personalizadas, equipos e integraciones con Google Sheets, Slack, ActiveCampaign y Zapier.
* [formlets.com](https://formlets.com/) — Formularios en línea, páginas de formulario ilimitadas/mes, 100 envíos/mes, notificaciones por correo.
* [formspark.io](https://formspark.io/) -  Servicio de formulario a correo electrónico, el plan gratuito permite formularios ilimitados, 250 envíos al mes y soporte por el equipo de atención al cliente.
* [Formspree.io](https://formspree.io/) — Envía correos usando una petición HTTP POST. El nivel gratuito limita a 50 envíos por formulario al mes.
* [Formsubmit.co](https://formsubmit.co/) — Endpoints fáciles para tus formularios HTML. Gratis para siempre. No se requiere registro.
* [Formlick.com](https://formlick.com) - Alternativa a Typeform con oferta de por vida. Los usuarios pueden crear 1 formulario gratis y recibir envíos ilimitados. En premium, formularios y envíos ilimitados.
* [getform.io](https://getform.io/) - Plataforma backend de formularios para diseñadores y desarrolladores, 1 formulario, 50 envíos, una subida de archivo, 100MB de almacenamiento.
* [HeroTofu.com](https://herotofu.com/) - Backend para formularios con detección de bots y archivo cifrado. Reenvía envíos vía UI a correo, Slack o Zapier. Usa tu propio frontend. No requiere código del lado del servidor. El plan gratuito da formularios ilimitados y 100 envíos al mes.
* [HeyForm.net](https://heyform.net/) - Creador de formularios online drag and drop. El nivel gratuito permite crear formularios y recibir envíos ilimitados. Incluye plantillas, anti-spam y 100MB de almacenamiento de archivos.
* [Tally.so](https://tally.so/) - El 99% de todas las funciones son gratuitas. El plan gratis permite: formularios ilimitados, envíos ilimitados, notificaciones por correo, lógica de formularios, cobros, subida de archivos, página de agradecimiento personalizada y más.
* [Hyperforms.app](https://hyperforms.app/) — Crea un formulario a correo y más en segundos y sin backend. La cuenta personal permite hasta 50 envíos mensuales gratis.
* [Kwes.io](https://kwes.io/) - Endpoint de formularios con muchas funciones. Ideal para sitios estáticos. El plan gratis incluye 1 sitio web con hasta 50 envíos mensuales.
* [Pageclip](https://pageclip.co/) - El plan gratuito permite un sitio, un formulario y 1,000 envíos mensuales.
* [Qualtrics Survey](https://qualtrics.com/free-account) — Crea formularios y encuestas profesionales con esta herramienta de primera clase. 50+ plantillas de encuestas de expertos. Cuenta gratuita limitada a 1 encuesta activa, 100 respuestas/encuesta y 8 tipos de respuestas.
* [Screeb](https://screeb.app/) - Encuestas in-app y analítica de producto para descifrar el comportamiento de usuario. Plan gratis para siempre con 500 usuarios activos mensuales, respuestas y eventos ilimitados, muchas integraciones, exportación e informes periódicos.
* [smartforms.dev](https://smartforms.dev/) - Backend de formularios potente y fácil para tu web, plan gratuito para siempre permite 50 envíos al mes, 250MB de almacenamiento, integración Zapier, exportación CSV/JSON, redirección personalizada, página de respuesta personalizada, bot de Telegram y Slack, notificación a un correo.
* [Survicate](https://survicate.com/) — Recoge feedback de todas las fuentes y envía encuestas de seguimiento con una sola herramienta. Analiza automáticamente el feedback y extrae información con IA. Encuestas gratis por correo, web, en producto o móvil, creador de encuestas IA y 25 respuestas mensuales.
* [staticforms.xyz](https://www.staticforms.xyz/) - Integra formularios HTML fácilmente sin código del lado del servidor gratis. Al enviar el formulario, se enviará un correo con el contenido a tu dirección registrada.
* [stepFORM.io](https://stepform.io) - Creador de formularios y quizzes. El plan gratis tiene cinco formularios, hasta 3 pasos por formulario y 50 respuestas mensuales.
* [Typeform.com](https://www.typeform.com/) — Incluye formularios bellamente diseñados en sitios web. El plan gratuito permite solo diez campos por formulario y 100 respuestas mensuales.
* [WaiverStevie.com](https://waiverstevie.com) - Plataforma de firma electrónica con API REST. Puedes recibir notificaciones por webhooks. El plan gratis pone marca de agua en los documentos firmados pero permite sobres y firmas ilimitadas.
* [Web3Forms](https://web3forms.com) - Formularios de contacto para sitios estáticos y JAMStack sin escribir código backend. El plan gratis permite formularios ilimitados, dominios ilimitados y 250 envíos por mes.
  * [WebAsk](https://webask.io) - Constructor de encuestas y formularios. El plan gratuito permite tres encuestas por cuenta, 100 respuestas mensuales y diez elementos por encuesta.
  * [Wufoo](https://www.wufoo.com/) - Formularios rápidos para usar en sitios web. El plan gratuito tiene un límite de 100 envíos al mes.
  * [formpost.app](https://formpost.app) - Servicio gratuito e ilimitado de Formulario a Correo Electrónico. Configura redirecciones personalizadas, respuestas automáticas, webhooks, etc. de forma gratuita.
  * [Formester.com](https://formester.com) - Comparte e incrusta formularios de apariencia única en tu sitio web, sin límites en la cantidad de formularios creados ni restricciones de funciones según el plan. Obtén hasta 100 envíos cada mes de forma gratuita.
  * [SimplePDF.eu](https://simplepdf.eu/embed) - Inserta un editor de PDF en tu sitio web y convierte cualquier PDF en un formulario rellenable. El plan gratuito permite PDFs ilimitados con tres envíos por PDF.
  * [forms.app](https://forms.app/) — Crea formularios en línea con potentes funciones como lógica condicional, calculadora de puntuación automática e IA. Recoge hasta 100 respuestas con el plan gratuito, incrusta tus formularios en un sitio web o úsalos con un enlace.
  * [Qualli](https://usequalli.com) - Encuestas dentro de la app, diseñadas para móviles. Usa Qualli AI para crear las preguntas perfectas. Puedes probarlo en nuestro plan gratuito, hasta 500 MAU, crear formularios y desencadenadores ilimitados.
  * [Sprig](https://sprig.com/) - 1 encuesta en producto o encuesta con reproducción al mes, con análisis de IA potenciada por GPT.
  * [feedback.fish](https://feedback.fish/) - El plan gratuito permite recoger 25 envíos de comentarios en total. Fácil integración con componentes React y Vue proporcionados.
  * [Vidhook](https://vidhook.io/) - Recoge comentarios utilizando encuestas atractivas con altas tasas de respuesta. El plan gratuito incluye 1 encuesta activa, 25 respuestas por encuesta y plantillas personalizables.

**[⬆️ Volver arriba](#table-of-contents)**

## Generative AI

  * [Zenable](https://zenable.io) - Corrige automáticamente las salidas de herramientas como Cursor, Windsurf y Copilot para cumplir con los estándares de calidad y cumplimiento de tu empresa usando guardrails construidos con Policy as Code. El nivel gratuito incluye 100 llamadas de herramientas por día al servidor MCP y 25 revisiones automáticas de pull requests gratis al día a través de la app de GitHub.
  * [Keywords AI](https://keywordsai.co) - La mejor plataforma de monitoreo de LLM. Un formato para llamar a más de 200 LLMs con 2 líneas de código. ¡10,000 solicitudes gratuitas cada mes y $0 por las funciones de la plataforma!
  * [Portkey](https://portkey.ai/) - Panel de control para aplicaciones Gen AI con un conjunto de observabilidad y una puerta de enlace AI. Envía y registra hasta 10,000 solicitudes gratis cada mes.
  * [Braintrust](https://www.braintrustdata.com/) - Evaluaciones, playground de prompts y gestión de datos para Gen AI. El plan gratuito ofrece hasta 1,000 filas de evaluaciones privadas por semana.
  * [Findr](https://www.usefindr.com/) - Búsqueda universal que te permite buscar en todas tus aplicaciones a la vez. Asistente de búsqueda que responde preguntas usando tu información. El plan gratuito ofrece búsqueda unificada ilimitada y 5 consultas diarias de copiloto.
  * [ReportGPT](https://ReportGPT.app) - Asistente de escritura potenciado por IA. Toda la plataforma es gratuita siempre que uses tu propia clave API.
  * [Clair](https://askclair.ai/) - Referencia clínica AI. Los estudiantes tienen acceso gratuito a la suite profesional de herramientas, que incluye Búsqueda Abierta, Resumen Clínico, Revisión Médica, Interacciones de Medicamentos, Códigos ICD-10 y Stewardship. Además, hay una prueba gratuita para la suite profesional.
  * [Langtrace](https://langtrace.ai) - Permite a los desarrolladores rastrear, evaluar, gestionar prompts y conjuntos de datos, y depurar problemas relacionados con el rendimiento de una aplicación LLM. Crea rastreos estándar de open telemetry para cualquier LLM, lo que ayuda con la observabilidad y funciona con cualquier cliente de observabilidad. El plan gratuito ofrece 50,000 rastreos/mes.
  * [LangWatch](https://langwatch.ai) - Plataforma LLMOps que ayuda a los equipos de IA a medir, monitorear y optimizar aplicaciones LLM en cuanto a confiabilidad, eficiencia de costos y rendimiento. Con un potente componente DSPy, permite colaboración fluida entre ingenieros y equipos no técnicos para ajustar y llevar productos GenAI a producción. El plan gratuito incluye todas las funciones de la plataforma, 1,000 rastreos/mes y 1 optimizador de flujo de trabajo DSPy. [#opensource](https://github.com/langwatch/langwatch)
  * [Comet Opik](https://www.comet.com/site/products/opik/) - Evalúa, prueba y lanza aplicaciones LLM a lo largo de los ciclos de vida de desarrollo y producción. [#opensource](https://github.com/comet-ml/opik/)
  * [Langfuse](https://langfuse.com/) - Plataforma open-source de ingeniería LLM que ayuda a los equipos a depurar, analizar e iterar colaborativamente en sus aplicaciones LLM. El plan gratuito para siempre incluye 50,000 observaciones por mes y todas las funciones de la plataforma. [#opensource](https://github.com/langfuse/langfuse)
  * [Pollinations.AI](https://pollinations.ai/) - IA de generación de imágenes fácil de usar, gratuita y con API libre disponible. No requiere registro ni claves API, y varias opciones para integrar en un sitio web o flujo de trabajo. [#opensource](https://github.com/pollinations/pollinations)
  * [Othor AI](https://othor.ai/) - Alternativa nativa de IA, rápida, sencilla y segura a soluciones populares de inteligencia de negocios como Tableau, Power BI y Looker. Othor utiliza LLMs para ofrecer soluciones personalizadas de BI en minutos. El plan Free Forever ofrece un workspace con cinco conexiones de fuentes de datos para un usuario, sin límites en analítica. [#opensource](https://github.com/othorai/othor.ai)
  * [OpenRouter](https://openrouter.ai/models?q=free) - Ofrece varios modelos de IA gratuitos, incluidos DeepSeek R1, V3, Llama y Moonshot AI. Estos modelos sobresalen en procesamiento de lenguaje natural y son adecuados para diversas necesidades de desarrollo. Ten en cuenta que, aunque estos modelos son gratuitos, están sujetos a límites de uso. Además, OpenRouter ofrece modelos de pago para requisitos más avanzados, como Claude, OpenAI, Grok, Gemini y Nova.

**[⬆️ Volver arriba](#table-of-contents)**

## CDN y Protección

  * [bootstrapcdn.com](https://www.bootstrapcdn.com/) — CDN para bootstrap, bootswatch y fontawesome.io
  * [cdnjs.com](https://cdnjs.com/) — Simple. Rápido. Confiable. Distribución de contenido al máximo nivel. cdnjs es un servicio CDN gratuito y de código abierto confiado por más del 11% de todos los sitios web, potenciado por Cloudflare.
  * [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Libraries es una red de distribución de contenido para las bibliotecas JavaScript de código abierto más populares.
  * [Stellate](https://stellate.co/) - Stellate es un CDN ultrarrápido y confiable para tu API GraphQL y gratuito para dos servicios.
  * [jsdelivr.com](https://www.jsdelivr.com/) — Un CDN gratuito, rápido y confiable de código abierto. Compatible con npm, GitHub, WordPress, Deno y más.
  * [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — El CDN de Microsoft Ajax aloja bibliotecas JavaScript populares de terceros como jQuery y te permite agregarlas fácilmente a tu aplicación web.
  * [ovh.ie](https://www.ovh.ie/ssl-gateway/) — Protección DDoS gratuita y certificado SSL
  * [Skypack](https://www.skypack.dev/) — CDN JavaScript 100% nativo para módulos ES. Gratis para 1 millón de solicitudes por dominio al mes.
  * [raw.githack.com](https://raw.githack.com/) — Un reemplazo moderno de **rawgit.com** que simplemente aloja archivos usando Cloudflare.
  * [section.io](https://www.section.io/) — Una forma sencilla de desplegar y gestionar una solución completa de Varnish Cache. Supuestamente gratuito para siempre para un sitio.
  * [statically.io](https://statically.io/) — CDN para repositorios Git (GitHub, GitLab, Bitbucket), recursos relacionados con WordPress e imágenes.
  * [toranproxy.com](https://toranproxy.com/) — Proxy para Packagist y GitHub. Nunca falla CD. Gratis para uso personal, un desarrollador, sin soporte.
  * [UNPKG](https://unpkg.com/) — CDN para todo lo que hay en npm.
  * [weserv](https://images.weserv.nl/) — Un servicio de caché y redimensionamiento de imágenes. Manipula imágenes al vuelo con caché global.
  * [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — Protección DDoS gratuita.
  * [Gcore](https://gcorelabs.com/) Red global de distribución de contenido, 1 TB y 1 millón de solicitudes al mes gratis y alojamiento DNS gratuito.
  * [CacheFly](https://portal.cachefly.com/signup/free2023) - Hasta 5 TB al mes de tráfico CDN gratuito, 19 Core PoPs, 1 dominio y SSL universal.

**[⬆️ Volver arriba](#table-of-contents)**

## PaaS

  * [anvil.works](https://anvil.works) - Desarrollo de aplicaciones web solo con Python. Nivel gratuito con aplicaciones ilimitadas y tiempos de espera de 30 segundos.
  * [appwrite](https://appwrite.io) - Proyectos ilimitados sin pausa de proyectos (soporta websockets) y servicio de autenticación. 1 base de datos, 3 buckets, 5 funciones por proyecto en el nivel gratuito.
  * [configure.it](https://www.configure.it/) — Plataforma de desarrollo de aplicaciones móviles, gratis para dos proyectos, funciones limitadas pero sin límites de recursos.
  * [codenameone.com](https://www.codenameone.com/) — Cadena de herramientas de desarrollo móvil multiplataforma y open source para desarrolladores Java/Kotlin. Gratis para uso comercial con un número ilimitado de proyectos.
  * [deco.cx](https://www.deco.cx/en/dev) - Plataforma frontend nativa de edge con un CMS visual autogenerado desde código TypeScript. Pruebas A/B integradas, segmentación de contenido y analíticas en tiempo real. Perfecto para sitios de e-commerce de alto contenido y empresas. Gratis hasta 5,000 vistas/mes o proyectos personales/open source.
  * [Deno Deploy](https://deno.com/deploy) - Sistema distribuido que ejecuta JavaScript, TypeScript y WebAssembly en el edge mundialmente. El nivel gratuito incluye 100,000 solicitudes por día y 100 GiB de transferencia de datos al mes.
  * [domcloud.co](https://domcloud.co) – Servicio de hosting Linux que provee CI/CD con GitHub, SSH y base de datos MariaDB/Postgres. La versión gratuita tiene 1 GB de almacenamiento y 1 GB de red/mes y está limitada a un dominio gratuito.
  * [encore.dev](https://encore.dev/) — Framework backend que usa análisis estático para proveer infraestructura automática, código sin boilerplate y más. Incluye hosting en la nube gratuito para proyectos de hobby.
  * [flightcontrol.dev](https://flightcontrol.dev/) - Despliega servicios web, bases de datos y más en tu propia cuenta de AWS con un flujo de trabajo estilo Git push. Nivel gratuito para usuarios con 1 desarrollador en repositorios personales de GitHub. Los costos de AWS se facturan a través de AWS, pero puedes usar créditos y el nivel gratuito de AWS.
  * [gigalixir.com](https://gigalixir.com/) - Gigalixir ofrece una instancia gratuita que nunca duerme y una base de datos PostgreSQL en el nivel gratuito limitada a 2 conexiones, 10,000 filas y sin backups para aplicaciones Elixir/Phoenix.
  * [Glitch](https://glitch.com/) — Hosting público gratuito con funciones de compartir código y colaboración en tiempo real. El plan gratuito tiene un límite de 1000 horas/mes.
  * [leapcell](https://leapcell.io/) - Plataforma de aplicaciones distribuidas confiable, que brinda todo lo necesario para soportar tu rápido crecimiento. El plan gratuito incluye 100,000 invocaciones de servicio, 10,000 tareas asíncronas y 100,000 comandos Redis.
  * [pipedream.com](https://pipedream.com) - Plataforma de integración creada para desarrolladores. Desarrolla cualquier flujo de trabajo basado en cualquier disparador. Los flujos de trabajo son código que puedes ejecutar [gratis](https://docs.pipedream.com/pricing/). Sin servidores ni recursos en la nube que administrar.
  * [pythonanywhere.com](https://www.pythonanywhere.com/) — Hosting en la nube para aplicaciones Python. La cuenta para principiantes es gratuita, 1 aplicación web Python en el dominio your-username.pythonanywhere.com, 512 MB de almacenamiento privado y una base de datos MySQL.
  * [ampt.dev](https://getampt.com/) - Ampt permite a los equipos crear, desplegar y escalar aplicaciones JavaScript en AWS sin configuraciones complicadas ni administrar infraestructura. El plan Preview gratuito incluye 500 invocaciones por hora, 2,500 invocaciones diarias y 50,000 invocaciones mensuales. Los dominios personalizados solo están permitidos en los planes de pago.
  * [Koyeb](https://www.koyeb.com) - Koyeb es una plataforma serverless amigable para desarrolladores para desplegar apps globalmente. Ejecuta fácilmente contenedores Docker, aplicaciones web y APIs con despliegue basado en git, autoescalado nativo, red edge global y malla de servicios integrada. La instancia gratuita permite desplegar un servicio web en Frankfurt, Alemania o Washington, D.C., EE.UU. Base de datos Postgres gestionada gratuita disponible en Frankfurt (Alemania), Washington, D.C. (EE.UU.) y Singapur. 512 MB de memoria, 2 GB de almacenamiento y 0.1 CPU.
  * [Napkin](https://www.napkin.io/) - FaaS con 500Mb de memoria, tiempo de espera por defecto de 15 segundos y 5,000 llamadas API gratis al mes, limitadas a 5 llamadas/segundo.
  * [Meteor Cloud](https://www.meteor.com/cloud) — Galaxy hosting. Plataforma PaaS de Meteor para apps Meteor incluye hosting MongoDB compartido gratuito y SSL automático.
  * [Northflank](https://northflank.com) — Crea y despliega microservicios, jobs y bases de datos gestionadas con una potente UI, API y CLI. Escalado fluido de contenedores desde control de versiones y registros Docker externos. El nivel gratuito incluye dos servicios, dos cron jobs y una base de datos.
  * [YepCode](https://yepcode.io) - Plataforma todo-en-uno para conectar APIs y servicios en un entorno serverless. Ofrece toda la agilidad de las herramientas NoCode pero con el poder del código. El nivel gratuito incluye [1.000 yeps](https://yepcode.io/pricing/).
  * [WunderGraph](https://cloud.wundergraph.com) - Plataforma open-source que permite construir, desplegar y gestionar APIs modernas rápidamente. CI/CD integrado, integración con GitHub y HTTPS automático. Hasta 3 proyectos, 1 GB de salida, 300 minutos de build por mes en el [plan gratuito](https://wundergraph.com/pricing)
  * [Zeabur](https://zeabur.com) - Despliega tus servicios con un solo clic. Gratis para tres servicios, con US$ 5 de créditos gratis al mes.
  * [mogenius](https://mogenius.com) - Crea, despliega y ejecuta servicios en Kubernetes fácilmente. El nivel gratuito soporta conectar un Kubernetes local con mogenius, permitiendo a desarrolladores individuales crear un entorno de pruebas similar a producción en su máquina.
  * [genezio](https://genezio.com/) - Proveedor de funciones serverless que ofrece 1 millón de llamadas a funciones, 100GB de ancho de banda y 10 cron jobs al mes gratis, exclusivamente para uso no comercial o académico.

**[⬆️ Volver arriba](#table-of-contents)**

## BaaS

  * [Activepieces](https://www.activepieces.com) - Crea flujos de automatización para conectar varias apps juntas en el backend de tu aplicación. Por ejemplo, envía un mensaje de Slack o añade una fila en Google Sheets cuando se dispare un evento en tu app. Gratis hasta 5,000 tareas al mes.
  * [back4app.com](https://www.back4app.com) - Back4App es un backend flexible, escalable y fácil de usar basado en Parse Platform.
  * [backendless.com](https://backendless.com/) — BaaS para web y móvil, con 1 GB de almacenamiento de archivos gratis, 50,000 notificaciones push al mes y 1,000 objetos de datos en la tabla.
  * [bismuth.cloud](https://www.bismuth.cloud/) — Nuestra IA inicia tu API de Python en nuestro runtime de funciones y almacenamiento alojado, constrúyela y hospédala gratis en nuestro editor online o localmente con tus herramientas favoritas.
  * [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — El programa de desarrolladores de BMC provee documentación y recursos para construir e implementar innovaciones digitales para tu empresa. Acceso a un sandbox personal y completo que incluye la plataforma, SDK y una biblioteca de componentes que pueden usarse para construir y personalizar apps.
  * [connectycube.com](https://connectycube.com) - Mensajes ilimitados de chat, llamadas p2p de voz y video, adjuntos de archivos y notificaciones push. Gratis para apps de hasta 1,000 usuarios.
  * [convex.dev](https://convex.dev/) - Backend reactivo como servicio, alojando tus datos (documentos con relaciones y transacciones ACID serializables), funciones serverless y WebSockets para transmitir actualizaciones a varios clientes. Gratis para proyectos pequeños: hasta 1M de registros, 5M de llamadas a funciones mensuales.
  * [darklang.com](https://darklang.com/) - Lenguaje alojado combinado con editor e infraestructura. Accesible durante la beta, se planea un nivel gratuito generoso tras la beta.
  * [Firebase](https://firebase.com) — Firebase te ayuda a construir y ejecutar apps exitosas. El Plan Spark gratuito ofrece Autenticación, Hosting, Firebase ML, Realtime Database, Cloud Storage, Testlab. Las funciones de A/B Testing, Analytics, App Distribution, App Indexing, Cloud Messaging (FCM), Crashlytics, Dynamic Links, In-App Messaging, Performance Monitoring, Predictions y Remote Config siempre son gratuitas.
  * [Flutter Flow](https://flutterflow.io) — Construye la interfaz UI de tu app Flutter sin escribir una sola línea de código. También tiene integración con Firebase. El plan gratuito incluye acceso total al UI Builder y plantillas gratuitas.
  * [getstream.io](https://getstream.io/) — Construye chat, mensajería, video, audio y feeds escalables en tu app en pocas horas en lugar de semanas.
  * [hasura.io](https://hasura.io/) — Hasura amplía tus bases de datos existentes donde sea que estén alojadas y provee una API GraphQL instantánea que puede ser accedida de forma segura para web, móvil e integraciones de datos. Gratis para 1GB/mes de datos transferidos.
  * [nhost.io](https://nhost.io) - Backend serverless para aplicaciones web y móviles. El plan gratuito incluye PostgreSQL, GraphQL (Hasura), Autenticación, Almacenamiento y Funciones Serverless.
  * [onesignal.com](https://onesignal.com/) — Notificaciones push ilimitadas gratuitas. 10,000 envíos de email al mes, con contactos ilimitados y acceso a Auto Warm Up.
  * [paraio.com](https://paraio.com) — API de backend con autenticación flexible, búsqueda full-text y caché. Gratis para una app, 1GB de datos de app.
  * [pubnub.com](https://www.pubnub.com/) — Notificaciones push gratuitas para hasta 1 millón de mensajes/mes y 100 dispositivos activos diarios
  * [pushbots.com](https://pushbots.com/) — Servicio de notificaciones push. Gratis para hasta 1.5 millones de notificaciones/mes
  * [pushcrew.com](https://pushcrew.com/) — Servicio de notificaciones push. Notificaciones ilimitadas para hasta 2,000 suscriptores
  * [pusher.com](https://pusher.com/beams) — Notificaciones push gratuitas e ilimitadas para 2000 usuarios activos mensuales. Una sola API para dispositivos iOS y Android.
  * [quickblox.com](https://quickblox.com/) — Backend de comunicación para mensajería instantánea, videollamadas, llamadas de voz y notificaciones push
  * [restspace.io](https://restspace.io/) - Configura un servidor con servicios para autenticación, datos, archivos, API de correo electrónico, plantillas y más, luego compón en pipelines y transforma datos.
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — Crea aplicaciones rápidamente con herramientas de arrastrar y soltar. Personaliza tu modelo de datos con clics. Ve más allá con código Apex. Integra con cualquier cosa usando potentes APIs. Mantente protegido con seguridad de nivel empresarial. Personaliza la UI con clics o cualquier framework web de vanguardia. El Programa de Desarrolladores gratuito da acceso a toda la plataforma Lightning.
  * [simperium.com](https://simperium.com/) — Mueve datos en todas partes de forma instantánea y automática, multiplataforma, envío y almacenamiento ilimitado de datos estructurados, máx. 2,500 usuarios/mes
  * [Supabase](https://supabase.com) — La alternativa open source a Firebase para construir backends. El plan gratuito ofrece Autenticación, Base de Datos Realtime y Almacenamiento de Objetos.
  * [tyk.io](https://tyk.io/) — Gestión de APIs con autenticación, cuotas, monitoreo y analíticas. Oferta cloud gratuita
  * [zapier.com](https://zapier.com/) — Conecta las apps que usas para automatizar tareas. Cinco zaps cada 15 minutos y 100 tareas/mes
  * [IFTTT](https://ifttt.com) — Automatiza tus apps y dispositivos favoritos. Gratis 2 applets
  * [Integrately](https://integrately.com) — Automatiza tareas tediosas con un solo clic. Gratis 100 tareas, tiempo de actualización cada 15 minutos, cinco automatizaciones activas, webhooks.
  * [LeanCloud](https://leancloud.app/) — Backend móvil. 1 GB de almacenamiento de datos, instancia de 256 MB, 3K solicitudes API/día y 10K notificaciones push/día gratis. (La API es muy similar a Parse Platform)
  * [Claw.cloud](https://run.claw.cloud) - Plataforma PaaS que ofrece $5/mes en créditos gratuitos para usuarios con una cuenta GitHub de más de 180 días. Perfecto para alojar aplicaciones, bases de datos y más. ([Enlace de registro con crédito gratis](https://ap-southeast-1.run.claw.cloud/signin)).

**[⬆️ Volver al inicio](#table-of-contents)**

## Plataforma Low-code

  * [appsmith](https://www.appsmith.com/) — Proyecto low-code para construir paneles de administración, herramientas internas y dashboards. Se integra con más de 15 bases de datos y cualquier API.
  * [Basedash](https://www.basedash.com) — Plataforma low-code para construir paneles de administración internos y dashboards. Soporta bases de datos SQL y APIs REST.
  * [BudiBase](https://budibase.com/) — Budibase es una plataforma low-code open source para crear aplicaciones internas en minutos. Soporta PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s
  * [Clappia](https://www.clappia.com) — Plataforma low-code diseñada para construir aplicaciones de procesos de negocio con apps móviles y web personalizables. Ofrece interfaz de arrastrar y soltar, soporte offline, seguimiento de ubicación en tiempo real e integración con diversos servicios de terceros.
  * [DronaHQ](https://www.dronahq.com/) — DronaHQ - una plataforma low-code que ayuda a equipos de ingeniería y product managers a construir herramientas internas, recorridos de usuario personalizados, experiencias digitales, automatizaciones, paneles de administración personalizados y apps operacionales 10 veces más rápido.
  * [lil'bots](https://www.lilbots.io/) - Escribe y ejecuta scripts en línea utilizando APIs integradas gratuitas como OpenAI, Anthropic, Firecrawl y otras. Ideal para construir agentes IA, herramientas internas y compartir con el equipo. El nivel gratuito incluye acceso completo a APIs, asistente de codificación IA y 10,000 créditos de ejecución/mes.
  * [Mendix](https://www.mendix.com/) — Desarrollo rápido de aplicaciones para empresas, entornos sandbox ilimitados accesibles para usuarios totales, 0.5 GB de almacenamiento y 1 GB de RAM por app. Además, Studio y Studio Pro IDEs están permitidos en el plan gratuito.
  * [outsystems.com](https://www.outsystems.com/) — PaaS de desarrollo web empresarial para on-premise o cloud, la oferta gratuita de "entorno personal" permite código ilimitado y hasta 1 GB de base de datos
  * [ReTool](https://retool.com/) — Plataforma low-code para crear aplicaciones internas. Retool es altamente configurable. Si puedes escribirlo en JavaScript y una API, puedes hacerlo en Retool. El plan gratuito permite hasta cinco usuarios por mes, apps y conexiones API ilimitadas.
  * [Superblocks](https://superblocks.com/) — Plataforma de aplicaciones empresariales abierta diseñada para desarrolladores y equipos semi-técnicos. Usa IA para generar, editar visualmente y extender con código. Gobierno centralizado con integraciones, autenticación, permisos y logs de auditoría.
  * [ToolJet](https://www.tooljet.com/) — Framework low-code extensible para crear aplicaciones de negocio. Conecta bases de datos, almacenamiento cloud, endpoints GraphQL, API, Airtable, etc., y crea apps con constructor de aplicaciones drag-and-drop.
  * [UI Bakery](https://uibakery.io) — Plataforma low-code que permite construir aplicaciones web personalizadas más rápido. Soporta la creación de UI con arrastrar y soltar y alto nivel de personalización con JavaScript, Python y SQL. Disponible en soluciones cloud y autohospedadas. Gratis para hasta 5 usuarios.
  * [manubes](https://www.manubes.com) - Potente plataforma cloud no-code enfocada en la gestión de producción industrial. Gratis para un usuario con 1 millón de actividades de workflow al mes ([también disponible en alemán](https://www.manubes.de)).

**[⬆️ Volver al inicio](#table-of-contents)**

## Alojamiento Web

  * [Alwaysdata](https://www.alwaysdata.com/) — 100 MB de alojamiento web gratuito con soporte para MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, servidores web personalizados, acceso vía FTP, WebDAV y SSH; buzón de correo, lista de correo e instalador de apps incluidos.
  * [Awardspace.com](https://www.awardspace.com) — Alojamiento web gratuito + un dominio corto gratuito, PHP, MySQL, instalador de apps, envío de email y sin anuncios.
  * [Bohr](https://bohr.io) — Gratis para proyectos no comerciales + Plataforma de despliegue y desarrollo centrada en el desarrollador que minimiza la infraestructura y acelera la configuración.
  * [Bubble](https://bubble.io/) — Programación visual para crear apps web y móviles sin código, gratis con branding de Bubble.
  * [dAppling Network](https://www.dappling.network/) - Plataforma de alojamiento web descentralizado para frontends Web3 enfocada en aumentar el uptime y la seguridad y proporcionar un punto de acceso adicional para los usuarios.
  * [DigitalOcean](https://www.digitalocean.com/pricing) - Crea y despliega tres sitios estáticos gratis en el nivel App Platform Starter.
  * [Drive To Web](https://drv.tw) — Aloja directamente en la web desde Google Drive y OneDrive. Solo sitios estáticos. Gratis para siempre. Un sitio por cuenta de Google/Microsoft.
  * [Fenix Web Server](https://preview.fenixwebserver.com) - Aplicación de escritorio para desarrolladores para alojar sitios localmente y compartirlos públicamente (en tiempo real). Trabaja como quieras, usando su hermosa interfaz, API y/o CLI.
  * [Fern](https://buildwithfern.com) - Crea y aloja un sitio de documentación basado en Markdown en el plan gratuito de Fern. Incluso puedes autogenerar una referencia API para tu sitio a partir de archivos de definición API. El sitio se aloja en _yoursite_.docs.buildwithfern.com.
  * [Free Hosting](https://freehostingnoads.net/) — Alojamiento gratuito con PHP 5, Perl, CGI, MySQL, FTP, gestor de archivos, correo POP, subdominios gratuitos, alojamiento de dominios gratuito, editor de zona DNS, estadísticas del sitio, soporte en línea gratuito y muchas más funciones que no ofrecen otros hosts gratuitos.
  * [Freehostia](https://www.freehostia.com) — FreeHostia ofrece servicios de alojamiento gratuitos incluyendo un panel de control de la industria y la instalación con un solo clic de más de 50 apps gratuitas. Configuración instantánea. Sin anuncios forzados.
  * [HelioHost](https://heliohost.org) — Alojamiento web gratuito sin fines de lucro con panel de control Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, correo IMAP/POP3/SMTP, ancho de banda ilimitado, subdominios gratuitos, 1000 MB de almacenamiento gratis con opción a upgrade.
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — Despliega hasta 100 sitios estáticos gratis, dominios personalizados con SSL, 100 GB de ancho de banda mensual, más de 260 ubicaciones Cloudflare CDN.
  * [Lecturify](https://www.lecturify.net/index.en.html) - Alojamiento web con acceso SFPT para subir y descargar archivos, PHP disponible.
  * [Neocities](https://neocities.org) — Sitios estáticos, 1 GB de almacenamiento gratis con 200 GB de ancho de banda.
  * [Netlify](https://www.netlify.com/) — Construye, despliega y aloja sitios/apps estáticos gratis para 100 GB de datos y 100 GB/mes de ancho de banda.
  * [pantheon.io](https://pantheon.io/) — Alojamiento Drupal y WordPress, DevOps automatizado e infraestructura escalable. Gratis para desarrolladores y agencias. Sin dominio personalizado.
  * [readthedocs.org](https://readthedocs.org/) — Alojamiento gratuito de documentación con versionado, generación de PDF y más
  * [render.com](https://render.com) — Nube unificada para construir y ejecutar apps y sitios con SSL gratuito, CDN global, redes privadas, auto-despliegues desde Git y planes completamente gratuitos para servicios web, bases de datos y páginas web estáticas.
  * [SourceForge](https://sourceforge.net/) — Encuentra, crea y publica software open source gratis
  * [surge.sh](https://surge.sh/) — Publicación web estática para desarrolladores front-end. Sitios ilimitados con soporte para dominio personalizado
  * [telegra.ph](https://telegra.ph/) Crea páginas web fácilmente usando Quill
  * [tilda.cc](https://tilda.cc/) — Un sitio, 50 páginas, 50 MB de almacenamiento, solo los bloques principales predefinidos entre 170+ disponibles, sin fuentes, sin favicon y sin dominio personalizado
  * [Vercel](https://vercel.com/) — Construye, despliega y aloja apps web con SSL gratis, CDN global y URLs de vista previa únicas cada vez que haces `git push`. Perfecto para Next.js y otros generadores de sitios estáticos.
  * [Versoly](https://versoly.com/) — Constructor de sitios web enfocado en SaaS - sitios web ilimitados, más de 70 bloques, cinco plantillas, CSS personalizado, favicon, SEO y formularios. Sin dominio personalizado.
  * [Qoddi](https://qoddi.com) - Servicio PaaS similar a Heroku con un enfoque centrado en el desarrollador y todas las funciones incluidas. Nivel gratuito para activos estáticos, staging y apps de desarrollo.
  * [FreeFlarum](https://freeflarum.com/) - Alojamiento gratuito de Flarum impulsado por la comunidad para hasta 250 usuarios (donar para quitar la marca de agua del pie de página).
  * [MDB GO](https://mdbgo.com/) - Alojamiento gratuito para un proyecto con dos semanas de TTL de contenedor, 500 MB de RAM por proyecto, SFTP - 1G de espacio en disco.
  * [Patr Cloud](https://patr.cloud/) — Plataforma cloud fácil de usar, entre sus servicios pagos ofrece alojar tres sitios estáticos gratis.
  * [Serv00.com](https://serv00.com/) — 3 GB de alojamiento web gratuito con backups diarios (7 días). Soporta: trabajos Crontab, acceso SSH, repositorios (GIT, SVN y Mercurial), soporte: MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R y muchos más.
  - [Sevalla](https://sevalla.com/) - Plataforma de alojamiento diseñada para simplificar el despliegue y la gestión de aplicaciones, bases de datos y sitios web estáticos - límite de 1 GB por sitio, 100 GB de ancho de banda gratis, 600 minutos de compilación gratuitos, 100 sitios por cuenta.

**[⬆️ Volver al inicio](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Resolver DNS público gratuito, rápido y seguro (encripta tu consulta DNS), proporcionado por Cloudflare. Útil para saltarse el bloqueo DNS de tu proveedor de internet, prevenir el espionaje de consultas DNS y [para bloquear contenido adulto y malware](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families). También se puede usar [vía API](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). Nota: Solo es un resolver DNS, no un host de DNS.
  * [1984.is](https://www.1984.is/product/freedns/) — Servicio DNS gratuito con API y muchas otras funciones DNS gratuitas incluidas.
  * [cloudns.net](https://www.cloudns.net/) — Hosting DNS gratuito para hasta 1 dominio con 50 registros
  * [deSEC](https://desec.io) - Hosting DNS gratuito con soporte API, diseñado pensando en la seguridad. Funciona con software open source y es soportado por [SSE](https://www.securesystems.de/).
  * [dns.he.net](https://dns.he.net/) — Servicio de hosting DNS gratuito con soporte de DNS dinámico
  * [Zonomi](https://zonomi.com/) — Servicio de hosting DNS gratuito con propagación instantánea. Plan gratuito: 1 zona DNS (nombre de dominio) con hasta 10 registros DNS.
  * [dnspod.com](https://www.dnspod.com/) — Hosting DNS gratuito.
  * [duckdns.org](https://www.duckdns.org/) — DDNS gratuito con hasta 5 dominios en el nivel gratuito. Con guías de configuración para varias instalaciones.
  * [Dynv6.com](https://dynv6.com/) — Servicio DDNS gratuito con [soporte API](https://dynv6.com/docs/apis) y gestión de muchos tipos de registros dns (como CNAME, MX, SPF, SRV, TXT y otros).
  * [freedns.afraid.org](https://freedns.afraid.org/) — Hosting DNS gratuito. También ofrece subdominios gratuitos basados en numerosos [dominios públicos contribuidos por usuarios](https://freedns.afraid.org/domain/registry/). Obtén subdominios gratis desde el menú "Subdomains" tras registrarte.
  * [luadns.com](https://www.luadns.com/) — Hosting DNS gratuito, tres dominios, todas las funciones con límites razonables
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — DNS gratuito. Sin límite en la cantidad de dominios
  * [nextdns.io](https://nextdns.io) - Firewall basado en DNS, 300K consultas gratuitas mensuales
  * [noip.at](https://noip.at/) — Servicio DDNS gratuito sin registro, seguimiento, logs o publicidad. Sin límite de dominios.
  * [noip](https://www.noip.com/) — Servicio DNS dinámico que permite hasta 3 hostnames gratis con confirmación cada 30 días
  * [sslip.io](https://sslip.io/) — Servicio DNS gratuito que, al consultarse con un nombre de host que contiene una IP incrustada, devuelve esa IP.
  * [zilore.com](https://zilore.com/en/dns) — Hosting DNS gratuito para 5 dominios.
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — Hosting DNS gratuito con soporte para DNS dinámico.
  * [zonewatcher.com](https://zonewatcher.com) — Backups automáticos y monitoreo de cambios DNS. Un dominio gratis
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Hosting DNS gratuito por Huawei
  * [Hetzner](https://www.hetzner.com/dns-console) – Hosting DNS gratuito de Hetzner con soporte API.
  * [Glauca](https://docs.glauca.digital/hexdns/) – Hosting DNS gratuito para hasta 3 dominios y soporte DNSSEC
  * [VolaryDDNS](https://volaryddns.net) - DDNS gratuito de alto rendimiento sin suscripciones ni publicidad
**[⬆️ Volver al inicio](#table-of-contents)**

## Dominio

  * [pp.ua](https://nic.ua/) — Subdominios pp.ua gratis.
  * [us.kg](https://nic.us.kg/) - Subdominios us.kg gratis.

**[⬆️ Volver al inicio](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — Compatible con AWS S3 - APIs, operaciones de interfaz, CLI y otros métodos de carga, sube y almacena archivos de las redes IPFS y Arweave de manera segura, conveniente y eficiente. Los usuarios registrados pueden obtener 6 GB de almacenamiento IPFS y 300MB de almacenamiento Arweave gratis. Cualquier carga de archivos Arweave menor de 150 KB es gratuita.
  * [backblaze.com](https://www.backblaze.com/b2/) — Almacenamiento en la nube Backblaze B2. 10 GB de almacenamiento de objetos (similar a Amazon S3) gratis por tiempo ilimitado.
  * [filebase.com](https://filebase.com/) - Almacenamiento de objetos compatible con S3, potenciado por Blockchain. 5 GB de almacenamiento gratis por duración ilimitada.
  * [Tebi](https://tebi.io/) - Almacenamiento de objetos compatible con S3. 25 GB de almacenamiento gratis y 250GB de transferencia de salida.
  * [Idrive e2](https://www.idrive.com/e2/) - Almacenamiento de objetos compatible con S3. 10 GB de almacenamiento gratis y 10 GB de ancho de banda de descarga por mes.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - Almacenamiento de objetos compatible con S3. 15 GB de almacenamiento gratis y 15 GB de descargas por mes.

**[⬆️ Volver al inicio](#table-of-contents)**

## Servicios de Datos Gestionados

  * [Aiven](https://aiven.io/) - Aiven ofrece planes gratuitos de PostgreSQL, MySQL y Redis en su plataforma de datos open source. Nodo único, 1 CPU, 1GB RAM, y para PostgreSQL y MySQL, 5GB de almacenamiento. Migración fácil a planes superiores o entre nubes.
  * [airtable.com](https://airtable.com/) — Parece una hoja de cálculo, pero es una base de datos relacional, bases ilimitadas, 1,200 filas/base y 1,000 solicitudes API/mes.
  * [Astra](https://www.datastax.com/products/datastax-astra/) — Cassandra nativo en la nube como servicio con [80GB de nivel gratuito](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — API/backend sin servidor en JavaScript y servicio de base de datos NoSQL fácil de usar con funciones, consultas tipo MongoDB, búsquedas clave/valor, sistema de trabajos, mensajes en tiempo real, colas de trabajo, potente CLI y gestor de datos web. Plan gratuito con 5GB de almacenamiento y 60 llamadas API por minuto. Incluye 2 desarrolladores. No requiere tarjeta de crédito.
  * [CrateDB](https://crate.io/) - Base de datos SQL distribuida de código abierto para analíticas en tiempo real. [Nivel gratuito CRFREE](https://crate.io/lp-crfree): Un nodo con 2 CPUs, 2 GiB de memoria, 8 GiB de almacenamiento. Un cluster por organización, no se requiere método de pago.
  * [Upstash](https://upstash.com/) — Redis sin servidor con nivel gratuito hasta 10,000 solicitudes por día, 256MB de tamaño máximo de base de datos y 20 conexiones simultáneas.
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - despliega un cluster de base de datos totalmente gestionado, nivel gratuito para siempre, construido para desarrolladores que crean la próxima generación de aplicaciones desde IoT hasta IA.
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — nivel gratuito otorga 512 MB.
  * [redsmin.com](https://www.redsmin.com/) — Servicio de monitoreo y administración en tiempo real para Redis, monitoreo para 1 instancia Redis gratis.
  * [redislabs](https://redislabs.com/try-free/) - Instancia redis gratuita de 30MB.
  * [MemCachier](https://www.memcachier.com/) — Servicio gestionado de Memcache. Gratis hasta 25MB, 1 Proxy Server y analíticas básicas.
  * [scalingo.com](https://scalingo.com/) — Principalmente un PaaS pero ofrece un nivel gratuito de 128MB a 192MB de MySQL, PostgreSQL o MongoDB.
  * [SeaTable](https://seatable.io/) — Base de datos flexible tipo hoja de cálculo creada por el equipo de Seafile. Tablas ilimitadas, 2,000 filas, versionado de 1 mes, hasta 25 miembros de equipo.
  * [skyvia.com](https://skyvia.com/) — Plataforma de datos en la nube con un nivel gratuito y todos los planes completamente gratuitos mientras esté en beta.
  * [StackBy](https://stackby.com/) — Una herramienta que combina la flexibilidad de hojas de cálculo, el poder de las bases de datos y las integraciones con tus aplicaciones de negocio favoritas. El plan gratuito incluye usuarios ilimitados, diez stacks y un archivo adjunto de 2GB por stack.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB es un RDBMS HTAP distribuido compatible con MySQL y de código abierto. TiDB Serverless provee 5GB de almacenamiento en filas, 5GB de almacenamiento en columnas y 50 millones de Unidades de Solicitud (RUs) gratis cada mes.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso es la experiencia de desarrollo SQLite en una base de datos Edge. Turso provee un plan gratuito para siempre, 9 GB de almacenamiento total, hasta 500 bases de datos, hasta 3 ubicaciones, 1 billón de lecturas de filas por mes y soporte para desarrollo local con SQLite.
  * [InfluxDB](https://www.influxdata.com/) — Base de datos de series temporales, gratis hasta 3MB/5 minutos de escrituras, 30MB/5 minutos de lecturas y 10,000 series de cardinalidad.
  * [restdb.io](https://restdb.io/) - Servicio rápido y sencillo de base de datos NoSQL en la nube. Con restdb.io obtienes esquema, relaciones, API REST automática (con consultas tipo MongoDB), y una eficiente interfaz de administración multiusuario para trabajar con datos. El plan gratuito permite 3 usuarios, 2500 registros y 1 solicitud API por segundo.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — El nivel gratuito ofrece 50 millones de RUs y 10 GiB de almacenamiento (equivale a $15) gratis por mes. ([¿Qué son las Request Units?](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Base de datos de grafos nativa gestionada / plataforma de analítica con lenguaje de consulta Cypher y API REST. Límites en el tamaño del grafo (50k nodos, 175k relaciones).
  * [Neon](https://neon.tech/) — PostgreSQL gestionado, 0.5 GB de almacenamiento (total), 1 proyecto, 10 ramas, bases de datos ilimitadas, rama principal siempre disponible (auto suspensión tras 5 minutos), 20 horas de tiempo activo por mes (total) para cómputo de ramas no principales.
  * [Prisma Postgres](https://prisma.io/postgres) - Postgres alojado ultrarrápido basado en unikernels y corriendo en metal puro, 1GB de almacenamiento, 10 bases de datos, integrado con Prisma ORM.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — Base de datos de grafos nativa gestionada con API GraphQL. Limitado a 1 MB de transferencia de datos diaria.
  * [Tinybird](https://tinybird.co) - ClickHouse gestionado sin servidor, con ingesta de datos sin conexión vía HTTP y permite publicar consultas SQL como APIs HTTP gestionadas. Sin límite de tiempo en el nivel gratuito, 10GB de almacenamiento + 1000 solicitudes API al día.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — Base de datos de grafos nativa gestionada / plataforma de analítica con lenguaje de consulta de grafos tipo SQL y API REST. Una instancia gratuita con dos vCPU, 8GB de memoria y 50GB de almacenamiento que entra en suspensión tras 1 hora de inactividad.
  * [TerminusCMS](https://terminusdb.com/pricing) — Servicio gratuito gestionado para TerminusDB, base de datos documental y de grafos escrita en Prolog y Rust. Gratis para desarrollo, servicio de pago para despliegues empresariales y soporte.
  * [filess.io](https://filess.io) - filess.io es una plataforma donde puedes crear dos bases de datos de hasta 10 MB por base de datos de los siguientes SGBD gratis: MySQL, MariaDB, MongoDB y PostgreSQL.
  * [xata.io](https://xata.io) - Xata es una base de datos sin servidor con búsqueda y analítica potentes integradas. Una API, múltiples librerías cliente type-safe y optimizada para tu flujo de trabajo de desarrollo. El nivel gratuito para siempre es suficiente para desarrolladores aficionados e incluye tres unidades Xata, consulta el sitio web para la definición de unidad.
  * [8base.com](https://www.8base.com/) - 8base es una plataforma de desarrollo low-code full-stack construida para desarrolladores JavaScript, basada en MySQL, GraphQL y backend como servicio sin servidor. Te permite empezar a crear aplicaciones web rápidamente usando un constructor de apps UI y escalar rápido. El nivel gratuito incluye filas: 2,500, almacenamiento: 500, computación sin servidor: 1Gb/h, y usuarios de app cliente: 5.
  * [Nile](https://www.thenile.dev/) — Plataforma Postgres para apps B2B. Bases de datos ilimitadas, siempre disponible sin apagados, 1GB de almacenamiento (total), 50 millones de tokens de consulta, autoescalado, embeddings vectoriales ilimitados.

**[⬆️ Volver al inicio](#table-of-contents)**

## Túneles, WebRTC, Servidores WebSocket y Otros Ruteadores

  * [Pinggy](https://pinggy.io) — URLs públicas para localhost con un solo comando, sin descargas requeridas. Túneles HTTPS / TCP / TLS. El plan gratuito tiene duración de túnel de 60 minutos.
  * [conveyor.cloud](https://conveyor.cloud/) — Extensión de Visual Studio para exponer IIS Express a la red local o mediante túnel a una URL pública.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi es un servicio VPN alojado que te permite extender redes tipo LAN de forma segura a equipos distribuidos con un plan gratis que permite redes ilimitadas de hasta 5 personas.
  * [Mirna Sockets](https://mirna.cloud/) - Plataforma gratuita de Socket como Servicio que te da una URL wss:// al desplegar tu código de servidor Web Socket y permite monitorear su rendimiento.
  * [localhost.run](https://localhost.run/) — Expón servidores locales a través de un túnel a una URL pública.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — Expón servidores locales a través de un túnel a una URL pública. Versión alojada gratis y [código abierto](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — Expón servidores locales a través de un túnel a una URL pública.
  * [cname.dev](https://cname.dev/) — Servicio proxy inverso dinámico gratuito y seguro.
  * [serveo](https://serveo.net/) — Expón servidores locales a Internet. Sin instalación ni registro. Subdominio gratis, sin límites.
  * [Radmin VPN](https://www.radmin-vpn.com/) — Conecta múltiples computadoras vía VPN habilitando una red tipo LAN. Peers ilimitados. (Alternativa a Hamachi)
  * [segment.com](https://segment.com/) — Hub para traducir y enrutar eventos a otros servicios de terceros. 100,000 eventos/mes gratis.
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — VPN sin configuración, usando el protocolo open source WireGuard. Instalación en MacOS, iOS, Windows, Linux y Android. Plan gratuito para uso personal con 100 dispositivos y tres usuarios.
  * [webhookrelay.com](https://webhookrelay.com) — Gestiona, depura, distribuye y proxifica todos tus webhooks a destinos públicos o internos (por ejemplo, localhost). También expón servidores en una red privada a través de un túnel obteniendo un endpoint HTTP público (`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — Desarrolla, prueba y monitoriza tus webhooks desde cualquier lugar. 100K solicitudes y 100K intentos por mes con retención de tres días.
  * [Xirsys](https://www.xirsys.com/pricing/) — Uso ilimitado de STUN + 500 MB de ancho de banda TURN mensual, ancho de banda limitado, una región geográfica.
  * [ZeroTier](https://www.zerotier.com) — Ethernet virtual gestionado como servicio FOSS. Redes cifradas de extremo a extremo ilimitadas de hasta 25 clientes en el plan gratuito. Clientes para escritorio/móvil/NA; interfaz web para configuración de reglas de ruteo personalizadas y aprobación de nuevos nodos cliente en redes privadas.
  * [LocalXpose](https://localxpose.io) — Proxy inverso que permite exponer tus servidores locales a Internet. El plan gratuito tiene duración de túnel de 15 minutos.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - Publica servicios locales en ejecución a través de un túnel a una URL pública personalizada y protégelos con control de acceso. Gratis para 5 servicios en un cluster.
  * [Expose](https://expose.dev/) - Expón sitios locales a través de túneles seguros. El plan gratuito incluye servidor en la UE, subdominios aleatorios y usuarios individuales.
  * [btunnel](https://www.btunnel.in/) — Expón localhost y servidor tcp local a Internet. El plan gratuito incluye servidor de archivos, cabeceras http de solicitud y respuesta personalizadas, protección por autenticación básica y tiempo de espera de túnel de 1 hora.

**[⬆️ Volver al inicio](#table-of-contents)**

## Seguimiento de Incidencias y Gestión de Proyectos

  * [acunote.com](https://www.acunote.com/) — Software gratuito de gestión de proyectos y SCRUM para hasta 5 miembros del equipo.
  * [asana.com](https://asana.com/) — Gratis para proyectos privados con colaboradores.
  * [Backlog](https://backlog.com) — Todo lo que tu equipo necesita para lanzar grandes proyectos en una sola plataforma. El plan gratuito ofrece 1 proyecto con diez usuarios y 100MB de almacenamiento.
  * [Basecamp](https://basecamp.com/personal) - Listas de tareas, gestión de hitos, mensajería tipo foro, compartición de archivos y seguimiento de tiempo. Hasta 3 proyectos, 20 usuarios y 1GB de espacio de almacenamiento.
  * [bitrix24.com](https://www.bitrix24.com/) — Intranet y herramienta de gestión de proyectos. El plan gratuito tiene 5GB para usuarios ilimitados.
  * [cacoo.com](https://cacoo.com/) — Diagramas online en tiempo real: flujogramas, UML, redes. Máx. 15 usuarios/diagrama, 25 hojas gratis.
  * [Chpokify](https://chpokify.com/) — Planning Poker basado en equipos que ahorra tiempo en la estimación de sprints. Gratis hasta 5 usuarios, integraciones gratis con Jira, videollamadas ilimitadas, equipos ilimitados, sesiones ilimitadas.
  * [clickup.com](https://clickup.com/) — Gestión de proyectos. Gratis, versión premium con almacenamiento en la nube. Disponibles aplicaciones móviles e integraciones con Git.
  * [Clockify](https://clockify.me) - Aplicación de seguimiento de tiempo y hojas de horas que te permite registrar horas de trabajo en proyectos. Usuarios ilimitados, gratis para siempre.
  * [Cloudcraft](https://cloudcraft.co/) — Diseña un diagrama de arquitectura profesional en minutos con el diseñador visual de Cloudcraft, optimizado para AWS con componentes inteligentes que muestran datos en vivo. El plan gratuito tiene diagramas privados ilimitados para un solo usuario.
  * [Codegiant](https://codegiant.io) — Gestión de proyectos con alojamiento de repositorios y CI/CD. El plan gratuito ofrece repositorios, proyectos y documentos ilimitados con 5 miembros de equipo. 500 minutos de CI/CD por mes. 30,000 minutos de ejecución de código serverless por mes y 1GB de almacenamiento de repositorio.
  * [Confluence](https://www.atlassian.com/software/confluence) - Herramienta de colaboración de contenido de Atlassian para ayudar a los equipos a colaborar y compartir conocimiento eficientemente. Plan gratuito para hasta 10 usuarios.
  * [contriber.com](https://www.contriber.com/) — Plataforma de gestión de proyectos personalizable, plan inicial gratuito, cinco espacios de trabajo.
* [Crosswork](https://crosswork.app/) - Plataforma versátil de gestión de proyectos. Gratis para hasta 3 proyectos, usuarios ilimitados, 1 GB de almacenamiento.
* [diagrams.net](https://app.diagrams.net/) — Diagramas en línea almacenados localmente en Google Drive, OneDrive o Dropbox. Gratis con todas las funciones y niveles de almacenamiento.
* [freedcamp.com](https://freedcamp.com/) - tareas, discusiones, hitos, seguimiento de tiempo, calendario, archivos y gestor de contraseñas. Plan gratuito con proyectos, usuarios y almacenamiento de archivos ilimitados.
* [easyretro.io](https://www.easyretro.io/) — Herramienta de retrospectiva de sprint simple e intuitiva. El plan gratuito tiene tres tableros públicos y una encuesta por tablero al mes.
* [GForge](https://gforge.com) — Conjunto de herramientas para la gestión de proyectos y seguimiento de incidencias para proyectos complejos con opciones on-premise y SaaS. El plan gratuito SaaS ofrece los primeros cinco usuarios gratis y es gratis para proyectos Open Source.
* [gleek.io](https://www.gleek.io) — Herramienta gratuita de descripción a diagramas para desarrolladores. Crea diagramas UML informales de clases, objetos o de relaciones de entidad usando tus palabras clave.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector genera una lista de cambios entre dos esquemas GraphQL. Cada diferencia está explicada y marcada como breaking, non-breaking o peligrosa.
* [huboard.com](https://huboard.com/) — Gestión instantánea de proyectos para tus issues de GitHub, gratis para Open Source.
* [Hygger](https://hygger.io) — Plataforma de gestión de proyectos. El plan gratuito ofrece usuarios, proyectos y tableros ilimitados con 100 MB de almacenamiento.
* [Instabug](https://instabug.com) — SDK integral de reporte de bugs y feedback in-app para aplicaciones móviles. Plan gratuito hasta 1 app y un miembro.
* [WishKit](https://wishkit.io) — Recoge feedback de usuarios dentro de tu app iOS/macOS y prioriza funciones según votos. Plan gratuito hasta 1 app.
* [Ilograph](https://www.ilograph.com/) — Diagramas interactivos que permiten a los usuarios ver su infraestructura desde múltiples perspectivas y niveles de detalle. Los diagramas pueden expresarse en código. El nivel gratuito permite diagramas privados ilimitados con hasta 3 espectadores.
* [Jira](https://www.atlassian.com/software/jira) — Herramienta avanzada de gestión de proyectos de desarrollo usada en muchos entornos corporativos. Plan gratuito para hasta 10 usuarios.
* [kanbanflow.com](https://kanbanflow.com/) — Gestión de proyectos basada en tableros. Gratis, versión premium con más opciones.
* [kanbantool.com](https://kanbantool.com/) — Gestión de proyectos basada en tableros Kanban. El plan gratuito tiene dos tableros y dos usuarios, sin adjuntos ni archivos.
* [kan.bn](https://kan.bn/) - Una app kanban poderosa y flexible que te ayuda a organizar el trabajo, seguir el progreso y entregar resultados, todo en un solo lugar. Plan gratuito hasta 1 usuario para tableros, listas y tarjetas ilimitadas.
* [Kitemaker.co](https://kitemaker.co) - Colabora en todas las fases del desarrollo de producto y haz seguimiento del trabajo en Slack, Discord, Figma y Github. Usuarios y espacios ilimitados. Plan gratuito hasta 250 elementos de trabajo.
* [Kiter.app](https://www.kiter.app/) - Permite a cualquiera organizar su búsqueda de empleo y hacer seguimiento de entrevistas, oportunidades y contactos. Potente app web y extensión de Chrome. Completamente gratis.
* [Kumu.io](https://kumu.io/) — Mapas de relaciones con animación, decoraciones, filtros, agrupamiento, importaciones desde hojas de cálculo, etc. El nivel gratuito permite proyectos públicos ilimitados. Tamaño de gráfico ilimitado. Proyectos privados gratuitos para estudiantes. El modo sandbox está disponible si prefieres no dejar tu archivo en línea públicamente (subir, editar, descargar, descartar).
* [Linear](https://linear.app/) — Seguimiento de incidencias con interfaz simplificada. Gratis para miembros ilimitados, tamaño de archivo hasta 10 MB, 250 incidencias (excluyendo archivo).
* [leiga.com](https://www.leiga.com/) — Leiga es un producto SaaS que usa IA para gestionar automáticamente tus proyectos, ayudando a tu equipo a mantenerse enfocado y liberar potencial, asegurando que tus proyectos progresen según lo planeado. Gratis para hasta 10 usuarios, 20 campos personalizados, 2GB de almacenamiento, grabación de video con IA limitada a 5 min/video, 20 automatizaciones por usuario/mes.
* [Lucidchart](https://www.lucidchart.com/) - Herramienta de diagramas online con funciones de colaboración. Plan gratuito con tres documentos editables, 100 plantillas profesionales y funciones básicas de colaboración.
* [MeisterTask](https://www.meistertask.com/) — Gestión de tareas online para equipos. Gratis hasta 3 proyectos y miembros de proyecto ilimitados.
* [MeuScrum](https://www.meuscrum.com/en) - Herramienta scrum online gratuita con tablero kanban.
* [nTask](https://www.ntaskmanager.com/) — Software de gestión de proyectos que permite a tus equipos colaborar, planificar, analizar y gestionar tareas diarias. El plan esencial es gratis para siempre con 100 MB de almacenamiento y cinco usuarios/equipos. Espacios de trabajo, reuniones, asignaciones, hojas de tiempo y seguimiento de incidencias ilimitados.
* [Ora](https://ora.pm/) - Gestión ágil de tareas y colaboración en equipo. Gratis para hasta 3 usuarios y archivos limitados a 10 MB.
* [pivotaltracker.com](https://www.pivotaltracker.com/) — Gratis para proyectos públicos ilimitados y dos proyectos privados con tres usuarios activos (lectura-escritura) y usuarios pasivos ilimitados (solo lectura).
* [plan.io](https://plan.io/) — Gestión de proyectos con hosting de repositorios y más opciones. Gratis para dos usuarios con diez clientes y 500MB de almacenamiento.
* [Plane](https://plane.so/) - Plane es una herramienta simple, extensible y open-source para la gestión de proyectos y productos. Gratis para miembros ilimitados, hasta 5MB de archivos, 1000 incidencias.
* [planitpoker.com](https://www.planitpoker.com/) — Herramienta gratuita de planning poker online (herramienta de estimación).
* [point.poker](https://www.point.poker/) - Planning Poker online (herramienta de estimación por consenso). Gratis para usuarios, equipos, sesiones, rondas y votos ilimitados. No necesitas registrarte.
* [ScrumFast](https://www.scrumfast.com) - Tablero Scrum con interfaz muy intuitiva, gratis hasta 5 usuarios.
* [Shake](https://www.shakebugs.com/) - Herramienta de reporte de bugs y feedback in-app para apps móviles. Plan gratuito, diez reportes de bugs por app/mes.
* [Shortcut](https://shortcut.com/) - Plataforma de gestión de proyectos. Gratis para hasta 10 usuarios para siempre.
* [Tadum](https://tadum.app) - App de agendas y actas para reuniones recurrentes, gratis para equipos de hasta 10.
* [taiga.io](https://taiga.io/) — Plataforma de gestión de proyectos para startups y desarrolladores ágiles, gratis para Open Source.
* [Tara AI](https://tara.ai/) — Servicio simple de gestión de sprints. El plan gratuito tiene tareas, sprints y espacios de trabajo ilimitados sin límite de usuarios.
* [targetprocess.com](https://www.targetprocess.com/) — Gestión visual de proyectos, desde Kanban y Scrum hasta cualquier proceso operativo. Gratis para usuarios ilimitados, hasta 1,000 entidades de datos {[más detalles](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — Listas de tareas colaborativas en tiempo real y esquemas de equipo. El plan gratuito tiene un espacio de trabajo con tareas y proyectos ilimitados; 1GB de almacenamiento de archivos; 1 semana de historial de proyectos; y cinco asistentes por videollamada.
* [taskulu.com](https://taskulu.com/) — Gestión de proyectos basada en roles. Gratis hasta 5 usuarios. Integración con GitHub/Trello/Dropbox/Google Drive.
* [Teaminal](https://www.teaminal.com) - Herramienta de standup, retro y planificación de sprint para equipos remotos. Gratis hasta 15 usuarios.
* [teamwork.com](https://teamwork.com/) — Gestión de proyectos y chat de equipo. Gratis para cinco usuarios y dos proyectos. Planes premium disponibles.
* [teleretro.com](https://www.teleretro.com/) — Herramienta de retrospectiva simple y divertida con icebreakers, gifs y emojis. El plan gratuito incluye tres retros y miembros ilimitados.
* [testlio.com](https://testlio.com/) — Plataforma de seguimiento de incidencias, gestión de pruebas y beta testing. Gratis para uso privado.
* [terrastruct.com](https://terrastruct.com/) — Generador de diagramas online específico para arquitectura de software. Nivel gratuito hasta 4 capas por diagrama.
* [todoist.com](https://todoist.com/) — Gestión colaborativa e individual de tareas. El plan gratuito incluye: 5 proyectos activos, cinco usuarios por proyecto, subida de archivos de hasta 5MB, tres filtros y una semana de historial de actividad.
* [trello.com](https://trello.com/) — Gestión de proyectos basada en tableros. Tableros personales ilimitados, 10 tableros de equipo.
* [Tweek](https://tweek.so/) — Calendario semanal de tareas y gestión simple de tareas.
* [ubertesters.com](https://ubertesters.com/) — Plataforma de pruebas, integración y crowdtesters, 2 proyectos, cinco miembros.
* [Wikifactory](https://wikifactory.com/) — Servicio de diseño de productos con proyectos, VCS y gestión de incidencias. El plan gratuito ofrece proyectos y colaboradores ilimitados y 3GB de almacenamiento.
* [Yodiz](https://www.yodiz.com/) — Desarrollo ágil y seguimiento de incidencias. Gratis hasta 3 usuarios, proyectos ilimitados.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — YouTrack hospedado gratis (InCloud) para proyectos FOSS y privados (gratis para tres usuarios). Incluye seguimiento de tiempo y tableros ágiles.
* [zenhub.com](https://www.zenhub.com) — La única solución de gestión de proyectos dentro de GitHub. Gratis para repos públicos, OSS y organizaciones sin fines de lucro.
* [zenkit.com](https://zenkit.com) — Herramienta de gestión de proyectos y colaboración. Gratis para hasta 5 miembros, 5 GB en adjuntos.
* [Zube](https://zube.io) — Gestión de proyectos con plan gratuito para 4 proyectos y 4 usuarios. Integración con GitHub disponible.
* [Toggl](https://toggl.com/) — Proporciona dos herramientas de productividad gratuitas. [Toggl Track](https://toggl.com/track/) para gestión y seguimiento del tiempo con un plan gratuito que ofrece seguimiento y reportes diseñados para freelancers. Incluye registros ilimitados, proyectos, clientes, etiquetas, reportes y más. Y [Toggl Plan](https://toggl.com/plan/) para planificación de tareas con plan gratuito para desarrolladores individuales con tareas, hitos y cronogramas ilimitados.
* [Sflow](https://sflow.io) — sflow.io es una herramienta de gestión de proyectos creada para desarrollo ágil de software, marketing, ventas y soporte al cliente, especialmente para subcontratación y colaboración inter-organizacional. Plan gratuito hasta 3 proyectos y cinco miembros.
* [Pulse.red](https://pulse.red) — App gratuita minimalista para seguimiento de tiempo y hojas de horas para proyectos.

**[⬆️ Volver arriba](#table-of-contents)**

## Almacenamiento y Procesamiento de Medios

* [AndroidFileHost](https://androidfilehost.com/) - Plataforma gratuita para compartir archivos con velocidad, ancho de banda, cantidad de archivos, descargas, etc. ilimitados. Principalmente orientada a archivos relacionados con desarrollo Android como APK, ROM personalizadas y modificaciones, etc. Pero también acepta otros tipos de archivos.
* [borgbase.com](https://www.borgbase.com/) — Hosting de backups externo simple y seguro para Borg Backup. 10 GB de espacio de backup gratis y dos repositorios.
* [icedrive.net](https://www.icedrive.net/) - Servicio de almacenamiento en la nube simple. 10 GB de almacenamiento gratis.
* [sync.com](https://www.sync.com/) - Servicio de almacenamiento en la nube de extremo a extremo. 5 GB de almacenamiento gratis.
* [pcloud.com](https://www.pcloud.com/) - Servicio de almacenamiento en la nube. Hasta 10 GB de almacenamiento gratis.
* [sirv.com](https://sirv.com/) — CDN inteligente de imágenes con optimización y redimensionamiento al vuelo. El nivel gratuito incluye 500 MB de almacenamiento y 2 GB de ancho de banda.
* [cloudimage.io](https://www.cloudimage.io/en/home) — Servicio completo de optimización de imágenes y CDN con más de 1500 puntos de presencia en el mundo. Variedad de funciones de redimensionamiento, compresión y marca de agua. Plugins open source para imágenes responsive, creación de imágenes 360 y edición de imágenes. Plan mensual gratuito con 25GB de tráfico CDN, 25GB de almacenamiento en caché y transformaciones ilimitadas.
* [cloudinary.com](https://cloudinary.com/) — Subida de imágenes, potentes manipulaciones, almacenamiento y entrega para sitios y apps, con librerías para Ruby, Python, Java, PHP, Objective-C y más. El nivel gratuito incluye 25 créditos mensuales. Un crédito equivale a 1,000 transformaciones de imágenes, 1 GB de almacenamiento o 1 GB de uso de CDN.
* [embed.ly](https://embed.ly/) — Ofrece APIs para incrustar medios en páginas web, escalado de imágenes responsive y extracción de elementos de una web. Gratis hasta 5,000 URLs/mes a 15 solicitudes/segundo.
* [filestack.com](https://www.filestack.com/) — Selector, transformación y entrega de archivos, gratis para 250 archivos, 500 transformaciones y 3 GB de ancho de banda.
* [file.io](https://www.file.io) - 2 GB de almacenamiento de archivos. Un archivo se elimina automáticamente tras una descarga. API REST para interactuar con el almacenamiento. Límite de una solicitud por minuto.
* [freetools.site](https://freetools.site/) — Herramientas online gratuitas. Convierte o edita documentos, imágenes, audio, video y más.
* [GoFile.io](https://gofile.io/) - Plataforma gratuita de almacenamiento y compartición de archivos que puede usarse vía UI web y API. Tamaño de archivo, ancho de banda y descargas ilimitados. Pero se elimina cuando un archivo está inactivo (sin descarga por más de diez días).
* [gumlet.com](https://www.gumlet.com/) — Hosting, procesamiento y streaming de imágenes y videos vía CDN. Generoso nivel gratuito de 250 GB/mes para videos y 30 GB/mes para imágenes.
* [image-charts.com](https://www.image-charts.com/) — Generación ilimitada de gráficos de imágenes con marca de agua.
* [Imgbot](https://github.com/marketplace/imgbot) — Imgbot es un robot amigable que optimiza tus imágenes y te ahorra tiempo. Imágenes optimizadas significan archivos más pequeños sin sacrificar calidad. Es gratis para open source.
* [ImgBB](https://imgbb.com/) — ImgBB es un servicio de hosting de imágenes ilimitado. Arrastra y suelta tu imagen en cualquier parte de la pantalla. Límite de 32 MB por imagen. Recibe enlaces directos, BBCode y miniaturas HTML tras subir. Inicia sesión para ver el historial de subidas.
* [imgen](https://www.jitbit.com/imgen/) - API gratuita e ilimitada para generación de imágenes de portada social, sin marca de agua.
* [imgix](https://www.imgix.com/) - Caché, gestión y CDN de imágenes. Plan gratuito incluye 1000 imágenes de origen, transformaciones infinitas y 100 GB de ancho de banda.
* [kraken.io](https://kraken.io/) — Optimización de imágenes para rendimiento web como servicio, plan gratuito hasta 1 MB por archivo.
* [kvstore.io](https://www.kvstore.io/) — Servicio de almacenamiento clave-valor. El nivel gratuito permite 100 llaves, 1KB/llave, 100 solicitudes/hora.
* [npoint.io](https://www.npoint.io/) — Almacenamiento JSON con edición colaborativa de esquemas.
* [nitropack.io](https://nitropack.io/) - Acelera la velocidad de tu sitio en piloto automático con optimización de frontend completa (caché, imágenes, código, CDN). Gratis hasta 5,000 vistas de página/mes.
* [otixo.com](https://www.otixo.com/) — Encripta, comparte, copia y mueve todos tus archivos en la nube desde un solo lugar. El plan básico ofrece transferencias ilimitadas con tamaño máximo de archivo de 250 MB y permite cinco archivos cifrados.
* [packagecloud.io](https://packagecloud.io/) — Repositorios de paquetes hospedados para YUM, APT, RubyGem y PyPI. Planes gratuitos limitados y planes para open source disponibles bajo solicitud.
* [getpantry.cloud](https://getpantry.cloud/) — API simple de almacenamiento de datos JSON perfecta para proyectos personales, hackathons y apps móviles.
* [Pinata IPFS](https://pinata.cloud) — Pinata es la forma más sencilla de subir y gestionar archivos en IPFS. Interfaz fácil de usar y API IPFS. 1 GB de almacenamiento gratis, con acceso a API.
* [placekitten.com](https://placekitten.com/) — Servicio rápido y simple para obtener imágenes de gatitos como placeholders.
* [plot.ly](https://plot.ly/) — Grafica y comparte tus datos. El nivel gratuito incluye archivos públicos ilimitados y diez archivos privados.
* [podio.com](https://podio.com/) — Puedes usar Podio con un equipo de hasta cinco personas y probar las funciones del Plan Básico, excepto la gestión de usuarios.
* [QRME.SH](https://qrme.sh) - Generador masivo de códigos QR rápido y bonito – sin login, sin marca de agua, sin anuncios. Hasta 100 URLs por exportación masiva.
* [QuickChart](https://quickchart.io) — Genera gráficos de imagen, gráficos y códigos QR embebibles.
* [redbooth.com](https://redbooth.com) — Sincronización de archivos P2P, gratis para hasta 2 usuarios.
* [resmush.it](https://resmush.it) — reSmush.it es una API GRATUITA que provee optimización de imágenes. Implementada en los CMS más comunes como WordPress, Drupal o Magento. Es la API de optimización de imágenes más utilizada con más de siete mil millones de imágenes tratadas, y sigue siendo gratuita.
* [Shotstack](https://shotstack.io) - API para generar y editar video a escala. Gratis hasta 20 minutos de video renderizado al mes.
* [tinypng.com](https://tinypng.com/) — API para comprimir y redimensionar imágenes PNG y JPEG, ofrece 500 compresiones gratis al mes.
* [transloadit.com](https://transloadit.com/) — Manejo de subidas de archivos y codificación de video, audio, imágenes y documentos. Gratis para open source, ONGs y estudiantes vía GitHub Student Developer Pack. Aplicaciones comerciales obtienen 2 GB gratis para prueba.
* [twicpics.com](https://www.twicpics.com) - Imágenes responsivas como servicio. Proporciona un CDN de imágenes, una API de procesamiento de medios y una librería frontend para automatizar la optimización de imágenes. El servicio es gratuito hasta 3GB de tráfico/por mes.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare ofrece una pipeline de medios con el kit de herramientas definitivo basado en algoritmos de vanguardia. Todas las funciones están disponibles para los desarrolladores absolutamente gratis: API y UI de subida de archivos, CDN de imágenes y servicios de origen, entrega adaptativa y compresión inteligente. El plan gratuito incluye 3000 subidas, 3 GB de tráfico y 3 GB de almacenamiento.
* [imagekit.io](https://imagekit.io) – CDN de imágenes con optimización automática, transformación en tiempo real y almacenamiento que puedes integrar en tu configuración existente en minutos. El plan gratuito incluye hasta 20GB de ancho de banda por mes.
* [internxt.com](https://internxt.com) – Internxt Drive es un servicio de almacenamiento de archivos con conocimiento cero basado en privacidad absoluta y seguridad sin concesiones. ¡Regístrate y obtén 10 GB gratis, para siempre!
* [degoo.com](https://degoo.com/) – Almacenamiento en la nube basado en IA con hasta 20 GB gratis, tres dispositivos, 5 GB de bono por referidos (90 días de inactividad de la cuenta).
* [MConverter.eu](https://mconverter.eu/) – Convertidor de archivos en lote. Soporta muchos formatos de archivo, incluidos nuevos como [AVIF](https://mconverter.eu/convert/to/avif/). Extrae todos los fotogramas de imagen de videos. Gratis hasta diez archivos de 100MB por día, procesados en tandas de dos.
* [ImageEngine](https://imageengine.io/) – ImageEngine es un CDN global de imágenes fácil de usar. Configuración en menos de 60 segundos. Soporte para AVIF y JPEGXL, plugins para WordPress, Magento, React, Vue y más. Solicita tu cuenta gratuita de desarrollador [aquí](https://imageengine.io/developer-program/).
* [DocsParse](https://docsparse.com/) – Procesamiento de PDFs e Imágenes potenciado por IA GPT, convirtiéndolos en datos estructurados en formatos JSON, CSV, EXCEL. 30 créditos gratis cada mes.
* [VaocherApp Generador de Códigos QR](https://www.vaocherapp.com/qr-code-generator) – Crea fácilmente códigos QR personalizados para tarjetas de regalo, vales y promociones. Soporta estilo, color y logotipo personalizados...
* [LibreQR](https://libreqr.com) — Generador de códigos QR gratuito enfocado en la privacidad y sin rastreo. Gratis de usar y sin recolección de datos.


**[⬆️ Volver al inicio](#table-of-contents)**

## Diseño y UI

* [AllTheFreeStock](https://allthefreestock.com) - una lista curada de imágenes, audios y videos de stock gratuitos.
* [Float UI](https://floatui.com/) - herramienta gratuita de desarrollo web para crear sitios web modernos y responsivos con un diseño elegante, incluso para no diseñadores.
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Design Landing Page ofrece una plantilla construida con los componentes de movimiento de Ant Motion. Tiene una plantilla de página principal rica, descarga el paquete de código de la plantilla y puede usarse rápidamente. También puedes usar el editor para construir rápidamente tu propia página dedicada.
* [Backlight](https://backlight.dev/) — Con la colaboración entre desarrolladores y diseñadores como objetivo, Backlight es una plataforma de codificación completa donde los equipos construyen, documentan, publican, escalan y mantienen sistemas de diseño. El plan gratuito permite hasta 3 editores trabajando en un sistema de diseño con visualizadores ilimitados.
* [BoxySVG](https://boxy-svg.com/app) — Una aplicación web instalable gratuita para dibujar SVGs y exportar en SVG, PNG, jpeg y otros formatos.
* [Carousel Hero](https://carouselhero.com/) - Herramienta gratuita en línea para crear carruseles para redes sociales.
* [Circum Icons](https://circumicons.com) - Iconos open-source consistentes como SVG para React, Vue y Svelte.
* [clevebrush.com](https://www.cleverbrush.com/) — Aplicación gratuita de diseño gráfico / collage de fotos. Además, ofrecen integración de pago como componente.
* [cloudconvert.com](https://cloudconvert.com/) — Convierte cualquier cosa a cualquier cosa. 208 formatos soportados incluyendo videos y gifs.
* [CodeMyUI](https://codemyui.com) - Colección seleccionada de inspiración en diseño web y UI con fragmentos de código.
* [ColorKit](https://colorkit.co/) - Crea paletas de colores en línea o inspírate con las mejores paletas.
* [coolors](https://coolors.co/) - Generador de paletas de color. Gratis.
* [CMYK Pantone](https://www.cmyktopantone.com/) - Convierte fácilmente valores CMYK al color Pantone más cercano y otros modelos de color en segundos, gratis.
* [Branition](https://branition.com/colors) - Paletas de color seleccionadas a mano ideales para marcas.
* [css-gradient.com](https://www.css-gradient.com/) - Herramienta gratuita para generar rápidamente gradientes CSS personalizados para todos los navegadores. En formato RGB y HEX.
* [easyvectors.com](https://easyvectors.com/) — EasyVectors.com es un stock gratuito de arte vectorial SVG. Descarga los mejores gráficos vectoriales totalmente gratis.
* [figma.com](https://www.figma.com) — Herramienta de diseño colaborativa online para equipos; el plan gratuito incluye archivos y visualizadores ilimitados, con un máximo de 2 editores y tres proyectos.
* [Flyon UI](https://flyonui.com/)- La librería de componentes más fácil para Tailwind CSS.
* [framer.com](https://www.framer.com/) - Framer te ayuda a iterar y animar ideas de interfaz para tu próxima app, sitio web o producto—comenzando con layouts potentes. Para cualquiera que valide Framer como herramienta profesional de prototipado: visualizadores ilimitados, hasta 2 editores y hasta 3 proyectos.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU Fotos de stock con modelo/propiedad libres de preocupaciones para uso comercial
* [Gradientos](https://www.gradientos.app) - Hace que elegir un gradiente sea rápido y fácil.
* [Icon Horse](https://icon.horse) – Obtén el favicon de más alta resolución para cualquier sitio web desde nuestra simple API.
* [Iconoir](https://iconoir.com) – Librería de iconos open-source con miles de iconos, soportando React, React Native, Flutter, Vue, Figma y Framer.
* [Icons8](https://icons8.com) — Iconos, ilustraciones, fotos, música y herramientas de diseño. El plan gratuito ofrece formatos limitados en baja resolución. Enlaza a Icons8 cuando uses sus recursos.
* [landen.co](https://www.landen.co) — Genera, edita y publica sitios web y landing pages hermosos para tu startup. Todo sin código. El plan gratuito permite tener un sitio web, totalmente personalizable y publicado en la web.
* [Quant Ux](https://quant-ux.com/) - Quant Ux es una herramienta de prototipado y diseño. - Es completamente gratuita y también open source.
* [lensdump.com](https://lensdump.com/) - Hosting gratuito de imágenes en la nube.
* [Lorem Picsum](https://picsum.photos/) - Herramienta gratuita, fácil de usar, para placeholders con estilo. Tras la URL, añade el tamaño de imagen deseado (ancho & alto), y obtendrás una imagen aleatoria.
* [LottieFiles](https://lottiefiles.com/) - La plataforma online más grande para el formato de animación más pequeño del mundo para diseñadores, desarrolladores y más. Accede a herramientas y plugins de animación Lottie para Android, iOS y Web.
* [MagicPattern](https://www.magicpattern.design/tools) — Colección de generadores y herramientas de fondos en CSS & SVG para gradientes, patrones y blobs.
* [marvelapp.com](https://marvelapp.com/) — Diseño, prototipado y colaboración, plan gratuito limitado a un usuario y un proyecto.
* [Mindmup.com](https://www.mindmup.com/) — Mapas mentales ilimitados gratis y almacenados en la nube. Tus mapas mentales están disponibles en todas partes, al instante, desde cualquier dispositivo.
* [Mockplus iDoc](https://www.mockplus.com/idoc) - Mockplus iDoc es una potente herramienta de colaboración y traspaso de diseño. El plan gratuito incluye tres usuarios y cinco proyectos con todas las funciones disponibles.
* [mockupmark.com](https://mockupmark.com/create/free) — Crea mockups realistas de camisetas y ropa para redes sociales y E-commerce, 40 mockups gratis.
* [Mossaik](https://mossaik.app) - Generador gratuito de imágenes SVG con diferentes herramientas como ondas, blobs y patrones.
* [movingpencils.com](https://movingpencils.com) — Editor vectorial rápido basado en navegador. Completamente gratis.
* [Octopus.do](https://octopus.do) — Constructor visual de mapas de sitio. Construye la estructura de tu web en tiempo real y compártela rápidamente para colaborar con tu equipo o clientes.
* [Pencil](https://github.com/evolus/pencil) - Herramienta de diseño open source usando Electron.
* [Penpot](https://penpot.app) - Herramienta web open source para diseño y prototipado. Soporta SVG. Completamente gratis.
* [pexels.com](https://www.pexels.com/) - Fotos de stock gratuitas para uso comercial. Tiene una API gratuita que permite buscar fotos por palabras clave.
* [photopea.com](https://www.photopea.com) — Editor de diseño avanzado y gratuito online con interfaz similar a Adobe Photoshop, soporta PSD, XCF y Sketch (Adobe Photoshop, Gimp y Sketch App).
* [pixlr.com](https://pixlr.com/) — Editor gratuito en línea a la altura de los comerciales.
* [Plasmic](https://www.plasmic.app/) - Herramienta de diseño web y constructor de páginas rápida, fácil de usar y robusta que se integra en tu código. Construye páginas responsivas o componentes complejos; amplía opcionalmente con código; y publica en sitios y apps en producción.
* [Pravatar](https://pravatar.cc/) - Genera un avatar falso aleatorio/placeholder cuya URL puede ser enlazada directamente en tu web/app.
* [Proto.io](https://www.proto.io) - Crea prototipos UI totalmente interactivos sin codificar. El plan gratuito está disponible cuando finaliza la prueba gratis. El plan gratuito incluye un usuario, un proyecto, cinco prototipos, 100MB de almacenamiento online y vista previa en la app proto.io.
* [resizeappicon.com](https://resizeappicon.com/) — Servicio simple para redimensionar y gestionar tus iconos de app.
* [Rive](https://rive.app) — Crea y exporta animaciones bellas a cualquier plataforma. Gratis para individuos para siempre. El servicio es un editor que también aloja todos los gráficos en sus servidores. Proporcionan runtimes para muchas plataformas para ejecutar representaciones hechas con Rive.
* [storyset.com](https://storyset.com/) — Crea increíbles ilustraciones personalizadas gratuitas para tu proyecto usando esta herramienta.
* [smartmockups.com](https://smartmockups.com/) — Crea mockups de productos, 200 mockups gratuitos.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — Previsualiza los cambios de tu tema en diferentes componentes y layouts.
* [Tailark](https://tailark.com/) - Colección de bloques UI modernos, responsivos y preconstruidos para sitios web de marketing.
* [tabler-icons.io](https://tabler-icons.io/) — Más de 1500 iconos SVG editables gratuitos para copiar y pegar.
* [tweakcn](https://tweakcn.com/) — Temas hermosos para shadcn/ui. Personaliza colores, tipografía y más en tiempo real.
* [UI Avatars](https://ui-avatars.com/) - Genera avatares con iniciales a partir de nombres. Las URLs pueden enlazarse directamente en tu web/app. Soporta parámetros de configuración vía URL.
* [unDraw](https://undraw.co/) - Colección en constante actualización de imágenes SVG hermosas que puedes usar completamente gratis y sin atribución.
* [unsplash.com](https://unsplash.com/) - Fotos de stock gratuitas para fines comerciales y no comerciales (licencia do-whatever-you-want).
* [vectr.com](https://vectr.com/) — Aplicación gratuita de diseño para Web + Escritorio.
* [walkme.com](https://www.walkme.com/) — Plataforma de guía y compromiso de clase empresarial, plan gratuito con tres recorridos de hasta 5 pasos cada uno.
* [Webflow](https://webflow.com) - Constructor de sitios web WYSIWYG con animaciones y hosting. Gratis para dos proyectos.
* [Updrafts.app](https://updrafts.app) - Constructor de sitios web WYSIWYG para diseños basados en tailwindcss. Gratis para uso no comercial.
* [whimsical.com](https://whimsical.com/) - Diagramas de flujo, wireframes, notas adhesivas y mapas mentales colaborativos. Crea hasta 4 tableros gratis.
* [Zeplin](https://zeplin.io/) — Plataforma de colaboración entre diseñadores y desarrolladores. Muestra diseños, recursos y guías de estilo. Gratis para un proyecto.
* [Pixelixe](https://pixelixe.com/) — Crea y edita gráficos e imágenes atractivos y únicos en línea.
* [Responsively App](https://responsively.app) - Herramienta gratuita para desarrolladores para crear aplicaciones web responsivas de forma más rápida y precisa.
* [SceneLab](https://scenelab.io) - Editor gráfico de mockups en línea con una colección en expansión de plantillas de diseño gratuitas.
* [xLayers](https://xlayers.dev) - Previsualiza y convierte archivos de diseño Sketch a Angular, React, Vue, LitElement, Stencil, Xamarin y más (gratis y open source en https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — Constructor de páginas web responsivas, potentes y optimizadas SEO basado en GrapesJS Framework. Gratis para las primeras cinco páginas, dominios personalizados ilimitados, todas las funciones y uso sencillo.
* [Mastershot](https://mastershot.app) - Editor de vídeo completamente gratuito basado en navegador. Sin marca de agua, opciones de exportación hasta 1080p.
* [Unicorn Platform](https://unicornplatform.com/) - Constructor de landing pages con hosting sencillo. Un sitio web gratis.
* [SVGmix.com](https://www.svgmix.com/) - Gran repositorio con más de 300K iconos SVG gratuitos, colecciones y logotipos de marca. Incluye un sencillo editor vectorial en el navegador para edición rápida de archivos.
* [svgrepo.com](https://www.svgrepo.com/) - Explora, busca y encuentra los iconos o vectores que mejor se adapten a tus proyectos usando varias librerías vectoriales. Descarga vectores SVG gratuitos para uso comercial.
* [haikei.app](https://www.haikei.app/) - Haikei es una app web para generar formas, fondos y patrones SVG únicos, listos para usar en tus herramientas y flujo de trabajo de diseño.
* [Canva](https://canva.com) - Herramienta de diseño online gratuita para crear contenido visual.
* [Superdesigner](https://superdesigner.co) - Colección de herramientas de diseño gratuitas para crear fondos, patrones, formas, imágenes y más únicos con solo unos clics.
* [TeleportHQ](https://teleporthq.io/) - Plataforma low-code de diseño y desarrollo Front-end. TeleportHQ es la plataforma colaborativa para crear y publicar sitios web estáticos headless al instante. Tres proyectos gratis, colaboradores ilimitados y exportación de código gratuita.
* [vector.express](https://vector.express) — Convierte tus vectores AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS y SVG rápida y fácilmente.
* [Vertopal](https://www.vertopal.com) - Vertopal es una plataforma gratuita en línea para convertir archivos a varios formatos. Incluye conversores para desarrolladores como JPG a SVG, GIF a APNG, PNG a WEBP, JSON a XML, etc.
* [okso.app](https://okso.app) - Aplicación de dibujo online minimalista. Permite crear bocetos rápidos y notas visuales. Exporta bocetos a PNG, JPG, SVG y WEBP. También instalable como PWA. Gratis para todos (sin registro necesario).
* [Wdrfree SVG](https://wdrfree.com/free-svg) - Archivos SVG gratuitos en blanco y negro para corte.
* [Lucide](https://lucide.dev) - Kit gratuito de iconos SVG personalizables y consistentes.
* [Logo.dev](https://www.logo.dev) - API de logotipos de empresas con más de 44M marcas, tan fácil como llamar a una URL. Las primeras 10,000 llamadas a la API son gratis.
* [MDBootstrap](https://mdbootstrap.com/) - Gratis para uso personal y comercial. UI Kits de Bootstrap, Angular, React y Vue con más de 700 componentes, plantillas impresionantes, instalación en 1 min, tutoriales extensos y una comunidad colosal.
* [TW Elements](https://tw-elements.com/) - Componentes Bootstrap gratuitos recreados con Tailwind CSS, pero con mejor diseño y más funcionalidades.
* [DaisyUI](https://daisyui.com/) -- Gratis. "Usa Tailwind CSS pero escribe menos nombres de clases", ofrece componentes como botones.
  * [Scrollbar.app](https://scrollbar.app) -- Aplicación web gratuita y simple para diseñar barras de desplazamiento personalizadas para la web.
  * [css.glass](https://css.glass/) -- Aplicación web gratuita para crear diseños glassmórficos usando CSS.
  * [hypercolor.dev](https://hypercolor.dev/) -- Una colección seleccionada de degradados de color Tailwind CSS, además de generadores para crear los tuyos propios.
  * [iconify.design](https://icon-sets.iconify.design/) -- Una colección de más de 100 paquetes de íconos con una interfaz unificada. Permite buscar íconos entre paquetes y exportar íconos individuales como SVG o para frameworks web populares.
  * [NextUI](https://nextui.org/) -- Gratis. Biblioteca UI de React & Next.js hermosa, rápida y moderna.
  * [Glyphs](https://glyphs.fyi/) -- Gratis, los íconos más poderosos de la web, sistema de diseño totalmente editable y verdaderamente open source.
  * [ShadcnUI](https://ui.shadcn.com/) -- Componentes bellamente diseñados que puedes copiar y pegar en tus aplicaciones. Accesible. Personalizable. Código abierto.
  * [HyperUI](https://www.hyperui.dev/) -- Componentes Tailwind CSS gratuitos y de código abierto.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- Genera íconos únicos para todo un año en un solo clic, absolutamente GRATIS.
  * [Image BG Blurer](https://imagebgblurer.com/) -- Genera un marco de fondo difuminado para una imagen, usando esa imagen como fondo, para Notion, Trello, Jira y más herramientas.
  * [Webstudio](https://webstudio.is/) -- Alternativa open source a Webflow. El plan gratuito ofrece sitios web ilimitados en su dominio. Cinco sitios web con dominios personalizados. Diez mil vistas de página/mes. 2 GB de almacenamiento de activos.
  * [Nappy](https://nappy.co/) -- Fotos hermosas de personas negras y marrones, gratis. Para uso comercial y personal.
  * [Tailkits](https://tailkits.com/) -- Colección seleccionada de plantillas, componentes y herramientas Tailwind, además de generadores útiles para código, grids, sombras de caja y más.
  * [Tailcolors](https://tailcolors.com/) -- Una hermosa paleta de colores de Tailwind CSS v4. Previsualiza y copia instantáneamente la clase de color perfecta de Tailwind CSS.
  * [Excalidraw](https://excalidraw.com/) -- Aplicación web gratuita para dibujar documentos en línea, con soporte gratuito para guardar localmente y exportar.
  * [Lunacy](https://icons8.com/lunacy) -- Herramienta gratuita de diseño gráfico con soporte offline, recursos incorporados (íconos, fotos, ilustraciones), y colaboración en tiempo real. El nivel gratuito incluye 10 documentos en la nube, historial de 30 días, recursos en baja resolución y herramientas básicas de diseño.

**[⬆️ Volver al inicio](#table-of-contents)**

## Inspiración de Diseño

  * [awwwards.](https://www.awwwards.com/) - [Mejores sitios web] Una vitrina de los mejores sitios web diseñados (votados por diseñadores).
  * [Behance](https://www.behance.net/) - [Vitrina de diseño] Un lugar donde los diseñadores muestran su trabajo. Filtrable con categorías para proyectos de UI/UX.
  * [dribbble](https://dribbble.com/) - [Vitrina de diseño] Inspiración de diseño única, generalmente no de aplicaciones reales.
  * [Landings](https://landings.dev/) - [Capturas de pantalla web] Encuentra las mejores páginas de destino para tu inspiración de diseño según tus preferencias.
  * [Lapa Ninja](https://www.lapa.ninja/) - [Landing page / UI Kits / Capturas web] Lapa Ninja es una galería con los mejores 6025 ejemplos de landing pages, libros gratuitos para diseñadores y kits UI gratuitos de toda la web.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [Diseños de landing page] Capturas de pantalla de landing pages actualizadas frecuentemente. Incluye capturas de escritorio, tablet y móvil.
  * [Mobbin](https://mobbin.design/) - [Capturas móviles] Ahorra horas de investigación de UI & UX con nuestra biblioteca de más de 50,000 capturas de pantalla de apps móviles totalmente buscables.
  * [Uiland Design](https://uiland.design/) - [Capturas móviles] Explora diseños UI móviles y web de empresas líderes en África y el mundo.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [Capturas móviles] Biblioteca de inspiración de diseño con los mejores patrones UI/UX (iOS y Android) para que diseñadores, desarrolladores y creadores de productos consulten.
  * [Page Flows](https://pageflows.com/) - [Videos y capturas móviles/web] Videos de flujos completos en muchas apps móviles y web. También incluye capturas de pantalla. Muy buscable e indexado.
  * [Screenlane](https://screenlane.com/) - [Capturas móviles] Inspírate y mantente al día con las últimas tendencias de diseño UI para web y apps móviles. Filtrable por patrón y app.
  * [scrnshts](https://scrnshts.club/) - [Capturas móviles] Una colección seleccionada de las mejores capturas de diseño de la tienda de apps.
  * [Refero](https://refero.design/) - [Capturas web] Colección etiquetada y buscable de referencias de diseño de grandes aplicaciones web.


**[⬆️ Volver al inicio](#table-of-contents)**

## Visualización de Datos en Mapas

  * [IP Geolocation](https://ipgeolocation.io/) — Plan DEVELOPER gratuito disponible con 30K solicitudes/mes.
  * [carto.com](https://carto.com/) — Crea mapas y APIs geoespaciales a partir de tus datos y datos públicos.
  * [Clockwork Micro](https://clockworkmicro.com/) — Herramientas de mapas que funcionan como un reloj. Cincuenta mil consultas mensuales gratuitas (tiles de mapas, db2vector, elevación).
  * [developers.arcgis.com](https://developers.arcgis.com) — APIs y SDKs para mapas, almacenamiento de datos geoespaciales, análisis, geocodificación, enrutamiento y más para web, escritorio y móvil. Dos millones de tiles base gratuitos, 20,000 geocodificaciones no almacenadas, 20,000 rutas simples, 5,000 cálculos de tiempo de conducción y 5GB de almacenamiento gratuito de tiles+datos por mes.
  * [Foursquare](https://developer.foursquare.com/) - Descubrimiento de ubicaciones, búsqueda de lugares y contenido contextual mediante Places API y Pilgrim SDK.
  * [geoapify.com](https://www.geoapify.com/) - Tiles de mapas vectoriales y rasterizados, geocodificación, lugares, rutas, APIs de isolíneas. Tres mil solicitudes gratuitas/día.
  * [geocod.io](https://www.geocod.io/) — Geocodificación vía API o carga CSV. Dos mil quinientas consultas gratuitas/día.
  * [geocodify.com](https://geocodify.com/) — Geocodificación y geoparsing vía API o carga CSV. 10k consultas gratuitas/mes.
  * [geojs.io](https://www.geojs.io/) - API de consulta de geolocalización por IP REST/JSON/JSONP altamente disponible.
  * [giscloud.com](https://www.giscloud.com/) — Visualiza, analiza y comparte datos geográficos en línea.
  * [graphhopper.com](https://www.graphhopper.com/) Se ofrece un paquete para desarrolladores gratis para Routing, Route Optimization, Distance Matrix, Geocoding y Map Matching.
  * [here](https://developer.here.com/) — APIs y SDKs para mapas y apps sensibles a la ubicación. 250k transacciones/mes gratis.
  * [locationiq.com](https://locationiq.com/) — APIs de geocodificación, mapas y enrutamiento. Cinco mil solicitudes/día gratis.
  * [mapbox.com](https://www.mapbox.com/) — Mapas, servicios geoespaciales y SDKs para mostrar datos de mapas.
  * [maptiler.com](https://www.maptiler.com/cloud/) — Mapas vectoriales, servicios y SDKs para visualización de mapas. Tiles vectoriales gratuitos con actualizaciones semanales y cuatro estilos de mapas.
  * [nominatim.org](https://nominatim.org/) — Servicio gratuito de geocodificación de OpenStreetMap, provee búsqueda de direcciones global y geocodificación inversa.
  * [nextbillion.ai](https://nextbillion.ai/) - Servicios relacionados con mapas: Geocodificación, navegación (dirección, enrutamiento, optimización de rutas, matriz de distancias), SDKs de mapas (vector, estático, móvil). [Gratis con cuota especificada](https://nextbillion.ai/pricing) para cada servicio.
  * [opencagedata.com](https://opencagedata.com) — API de geocodificación que agrega OpenStreetMap y otras fuentes geográficas abiertas. Dos mil quinientas consultas gratuitas/día.
  * [osmnames](https://osmnames.org/) — Geocodificación, resultados de búsqueda ordenados por la popularidad de la página de Wikipedia relacionada.
  * [positionstack](https://positionstack.com/) - Geocodificación gratuita para lugares y coordenadas globales. 25,000 solicitudes por mes para uso personal.
  * [stadiamaps.com](https://stadiamaps.com/) — Tiles de mapas, enrutamiento, navegación y otras APIs geoespaciales. Dos mil quinientas visualizaciones y solicitudes de API gratuitas/día para uso no comercial y pruebas.
  * [maps.stamen.com](http://maps.stamen.com/) - Tiles y hospedaje de mapas gratuitos.
  * [ipstack](https://ipstack.com/) - Localiza e identifica visitantes de sitios web por dirección IP.
  * [Geokeo api](https://geokeo.com) - API de geocodificación con corrección de idioma y más. Cobertura mundial. 2,500 consultas diarias gratuitas.

**[⬆️ Volver al inicio](#table-of-contents)**

## Sistema de Construcción de Paquetes

  * [build.opensuse.org](https://build.opensuse.org/) — Servicio de construcción de paquetes para múltiples distribuciones (SUSE, EL, Fedora, Debian, etc.).
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Servicio de construcción de RPM basado en Mock para Fedora y EL.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Servicio de construcción para Ubuntu y Debian.

**[⬆️ Volver al inicio](#table-of-contents)**

## IDE y Edición de Código

  * [3v4l](https://3v4l.org/) - Consola PHP en línea y sitio para compartir fragmentos, ejecuta tu código en más de 300 versiones de PHP.
  * [Android Studio](https://developer.android.com/studio) — Android Studio ofrece las herramientas más rápidas para crear apps en cualquier tipo de dispositivo Android. IDE de código abierto gratis para todos y el mejor para desarrollo de apps Android. ¡Disponible para Windows, Mac, Linux e incluso ChromeOS!
  * [AndroidIDE](https://m.androidide.com/) — Un IDE de código abierto para desarrollar aplicaciones Android reales basadas en Gradle directamente en dispositivos Android.
  * [Apache Netbeans](https://netbeans.apache.org/) — Entorno de desarrollo, plataforma de herramientas y framework de aplicaciones.
  * [apiary.io](https://apiary.io/) — Diseño colaborativo de APIs con mock instantáneo y documentación generada (Gratis para blueprints ilimitados y usuarios ilimitados con una cuenta de administrador y documentación hospedada).
  * [BBEdit](https://www.barebones.com/) - BBEdit es un editor popular y extensible para macOS. El Modo Gratis proporciona un [conjunto de funciones principales potente](https://www.barebones.com/products/bbedit/comparison.html) y un camino de actualización a funciones avanzadas.
  * [Binder](https://mybinder.org/) - Convierte un repositorio Git en una colección de notebooks interactivos. Es un servicio público gratuito.
  * [BlueJ](https://bluej.org) — Un entorno de desarrollo Java gratuito diseñado para principiantes, utilizado por millones en todo el mundo. Respaldado por Oracle y GUI simple para ayudar a principiantes.
  * [Bootify.io](https://bootify.io/) - Generador de apps Spring Boot con base de datos personalizada y API REST.
  * [Brackets](http://brackets.io/) - Brackets es un editor de texto open source diseñado específicamente para desarrollo web. Es liviano, fácil de usar y altamente personalizable.
  * [cacher.io](https://www.cacher.io) — Organizador de fragmentos de código con etiquetas y soporte para más de 100 lenguajes de programación.
  * [Code::Blocks](https://codeblocks.org) — IDE gratuito para Fortran y C/C++. Open Source y disponible para Windows, macOS y Linux.
  * [Cody](https://sourcegraph.com/cody) - Asistente de codificación IA gratis que puede escribir (bloques de código, autocompletar, tests unitarios), entender (conocimiento de toda tu base de código), corregir y encontrar tu código. Disponible para VS Code, JetBrains y en línea.
  * [codiga.io](https://codiga.io/) — Asistente de codificación que permite buscar, definir y reutilizar fragmentos de código directamente en tu IDE. Gratis para individuos y pequeñas organizaciones.
  * [codesnip.com.br](https://codesnip.com.br) — Administrador simple de fragmentos de código con categorías, búsqueda y etiquetas. Gratis e ilimitado.
  * [cocalc.com](https://cocalc.com/) — (anteriormente SageMathCloud en cloud.sagemath.com) — Cálculo colaborativo en la nube. Acceso por navegador a Ubuntu completo con colaboración integrada y mucho software libre para matemáticas, ciencia, ciencia de datos, preinstalado: Python, LaTeX, Jupyter Notebooks, SageMath, scikitlearn, etc.
  * [code.cs50.io](https://code.cs50.io/) - Visual Studio Code para CS50 es una aplicación web que adapta GitHub Codespaces para estudiantes y profesores.
  * [codepen.io](https://codepen.io/) — CodePen es un playground para el desarrollo frontend web.
  * [codesandbox.io](https://codesandbox.io/) — Playground online para React, Vue, Angular, Preact y más.
  * [Components.studio](https://webcomponents.dev/) - Codifica componentes en aislamiento, visualízalos en historias, pruébalos y publícalos en npm.
  * [Eclipse Che](https://www.eclipse.org/che/) - IDE web y nativo de Kubernetes para equipos de desarrollo con soporte multilenguaje. Open Source y dirigido por la comunidad. Instancia online hospedada por Red Hat disponible en [workspaces.openshift.com](https://workspaces.openshift.com/).
  * [fakejson.com](https://fakejson.com/) — FakeJSON te ayuda a generar datos falsos rápidamente usando su API. Haz una solicitud API describiendo lo que quieres y cómo lo quieres. La API devuelve todo en JSON. Acelera el proceso de salida al mercado para ideas y finge hasta que lo logres.
  * [GetVM](https://getvm.io) — Linux instantáneo gratuito y IDEs en barra lateral de Chrome. El nivel gratuito incluye 5 VMs por día.
  * [GitPod](https://www.gitpod.io) — Entornos de desarrollo instantáneos y listos para codificar para proyectos de GitHub. El nivel gratuito incluye 50 horas/mes.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE es un IDE completo en la nube. Soporte multilenguaje, contenedor basado en Linux a través de una terminal web completamente funcional, reenvío de puertos, URL personalizada, colaboración y chat en tiempo real, enlace para compartir, soporte para Git/Subversion. Hay muchas más funciones (el nivel gratuito incluye 1GB de RAM y 10GB de almacenamiento por contenedor, 5 espacios de contenedores).
  * [JDoodle](https://www.jdoodle.com) — Compilador y editor en línea para más de 60 lenguajes de programación con un plan gratuito para compilación de código REST API hasta 200 créditos por día.
  * [jetbrains.com](https://jetbrains.com/products.html) — Herramientas de productividad, IDEs y herramientas de despliegue (como [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/), etc). Licencia gratuita para estudiantes, profesores, proyectos Open Source y grupos de usuarios.
  * [jsbin.com](https://jsbin.com) — JS Bin es otro entorno de pruebas y sitio para compartir código de frontend web (HTML, CSS y JavaScript. También soporta Markdown, Jade y Sass).
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle es un entorno de pruebas y sitio para compartir código de frontend web, con soporte para colaboración.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) Algunos endpoints REST API que devuelven datos ficticios en formato JSON. El código fuente también está disponible si deseas ejecutar el servidor localmente.
  * [Lazarus](https://www.lazarus-ide.org/) — Lazarus es un IDE multiplataforma compatible con Delphi para desarrollo rápido de aplicaciones.
  * [MarsCode](https://www.marscode.com/) - Un IDE gratuito basado en la nube potenciado por IA.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - Microservicio pequeño para simular APIs y generar datos JSON ficticios.
  * [mockable.io](https://www.mockable.io/) — Mockable es un servicio sencillo y configurable para simular APIs RESTful o servicios web SOAP. Este servicio en línea te permite definir rápidamente endpoints REST API o SOAP y hacer que devuelvan datos en JSON o XML.
  * [mockaroo](https://mockaroo.com/) — Mockaroo te permite generar datos de prueba realistas en formatos CSV, JSON, SQL y Excel. También puedes crear simulaciones para APIs backend.
  * [Mocklets](https://mocklets.com) - Simulador de API HTTP que ayuda a simular APIs para un desarrollo paralelo más rápido y pruebas más completas, con un nivel gratuito de por vida.
  * [Paiza](https://paiza.cloud/en/) — Desarrolla aplicaciones web en el navegador sin necesidad de configurar nada. El plan gratuito ofrece un servidor con 24 horas de vida y 4 horas de tiempo de ejecución por día con 2 núcleos de CPU, 2 GB de RAM y 1 GB de almacenamiento.
  * [Prepros](https://prepros.io/) - Prepros puede compilar Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript y TypeScript listo para usar, recarga tus navegadores y facilita el desarrollo y prueba de tus sitios web para que puedas enfocarte en perfeccionarlos. También puedes agregar tus propias herramientas con solo unos clics.
  * [Replit](https://replit.com/) — Un entorno de codificación en la nube para varios lenguajes de programación.
  * [SoloLearn](https://code.sololearn.com) — Un entorno de pruebas de programación en la nube ideal para ejecutar fragmentos de código. Soporta varios lenguajes de programación. No se requiere registro para ejecutar código, pero sí es necesario para guardar código en su plataforma. También ofrece cursos gratuitos para principiantes y programadores de nivel intermedio.
  * [stackblitz.com](https://stackblitz.com/) — IDE de código en línea/nube para crear, editar y desplegar apps full-stack. Soporta cualquier framework popular basado en NodeJs, tanto frontend como backend. Enlace corto para crear un nuevo proyecto: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text es un editor de texto popular, versátil y altamente personalizable usado para tareas de codificación y edición de texto.
  * [Visual Studio Code](https://code.visualstudio.com/) - Editor de código redefinido y optimizado para construir y depurar aplicaciones web y en la nube modernas. Desarrollado por Microsoft.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — IDE completamente funcional con miles de extensiones, desarrollo de apps multiplataforma (extensiones de Microsoft disponibles para descarga para iOS y Android), desarrollo de escritorio, web y en la nube, soporte multilenguaje (C#, C++, JavaScript, Python, PHP y más).
  * [VSCodium](https://vscodium.com/) - Distribución binaria impulsada por la comunidad, sin telemetría/seguimiento, y con licencia libre del editor VSCode de Microsoft.
  * [wakatime.com](https://wakatime.com/) — Métricas de auto-cuantificación sobre tu actividad de codificación usando plugins para editores de texto, plan limitado gratis.
  * [Wave Terminal](https://waveterm.dev/) - Wave es un terminal de código abierto y multiplataforma para flujos de trabajo fluidos. Renderiza cualquier cosa en línea. Guarda sesiones e historial. Impulsado por estándares web abiertos. MacOS y Linux.
  * [WebComponents.dev](https://webcomponents.dev/) — IDE en el navegador para programar web components en aislamiento con 58 plantillas disponibles, soporte para historias y pruebas.
  * [PHPSandbox](https://phpsandbox.io/) — Entorno de desarrollo online para PHP.
  * [WebDB](https://webdb.app) - IDE de base de datos eficiente y gratuito. Incluye descubrimiento de servidores, ERD, generador de datos, IA, gestor de estructura NoSQL, versionado de base de datos y muchas más funciones.
  * [Zed](https://zed.dev/) - Zed es un editor de código de alto rendimiento y multijugador de los creadores de Atom y Tree-sitter.
  * [OneCompiler](https://onecompiler.com/) - Compilador online gratuito que soporta más de 70 lenguajes incluyendo Java, Python, C++, JavaScript.


**[⬆️ Volver al inicio](#table-of-contents)**

## Analítica, Eventos y Estadísticas

  * [Dwh.dev](https://dwh.dev) - Solución de observabilidad de datos en la nube (Snowflake). Gratis para uso personal.
  * [Hightouch](https://hightouch.com/) - Hightouch es una plataforma Reverse ETL que te ayuda a sincronizar datos de clientes desde tu almacén de datos hasta tu CRM, herramientas de marketing y soporte. El nivel gratuito ofrece un destino para sincronizar datos.
  * [Avo](https://avo.app/) — Flujo de trabajo simplificado para el lanzamiento de analítica. Plan de seguimiento fuente única de la verdad, biblioteca de seguimiento de analítica type-safe, depuradores integrados y observabilidad de datos para detectar todos los problemas antes de lanzar. Gratis para dos miembros del espacio de trabajo y 1 hora de retroceso de observabilidad de datos.
  * [Branch](https://www.branch.io) — Plataforma de analítica móvil. El nivel gratuito ofrece hasta 10K usuarios de apps móviles con deep-linking y otros servicios.
  * [Census](https://www.getcensus.com/) — Plataforma de Reverse ETL y analítica operativa. Sincroniza 10 campos desde tu almacén de datos a más de 60 SaaS como Salesforce, Zendesk o Amplitude.
  * [Clicky](https://clicky.com) — Plataforma de analítica web. Plan gratuito para un sitio web con 3000 vistas analizadas.
  * [Databox](https://databox.com) — Business Insights & Analytics combinando otras plataformas de analítica y BI. Plan gratuito ofrece 3 usuarios, dashboards y fuentes de datos. 11M de registros históricos de datos.
  * [Hitsteps.com](https://hitsteps.com/) — 2,000 páginas vistas por mes para 1 sitio web
  * [amplitude.com](https://amplitude.com/) — 1 millón de eventos mensuales, hasta 2 aplicaciones
  * [GoatCounter](https://www.goatcounter.com/) — GoatCounter es una plataforma de analítica web open-source disponible como servicio alojado (gratis para uso no comercial) o como app autoalojada. Busca ofrecer analítica web fácil de usar y significativa, amigable con la privacidad, como alternativa a Google Analytics o Matomo. El nivel gratuito es para uso no comercial e incluye sitios ilimitados, seis meses de retención de datos y 100k páginas vistas/mes.
  * [Google Analytics](https://analytics.google.com/) — Google Analytics
  * [MetricsWave](https://metricswave.com) — Alternativa a Google Analytics amigable con la privacidad para desarrolladores. El plan gratuito permite 20k páginas vistas por mes sin tarjeta de crédito.
  * [Expensify](https://www.expensify.com/) — Reporte de gastos, flujo de trabajo gratuito de aprobación de reportes personales
  * [getinsights.io](https://getinsights.io) - Analítica enfocada en la privacidad, sin cookies, gratis hasta 3k eventos/mes.
  * [heap.io](https://heap.io) — Captura automáticamente cada acción del usuario en apps iOS o web. Gratis hasta 10K sesiones mensuales.
  * [Hotjar](https://hotjar.com) — Analítica y reportes web. El plan gratuito permite 2000 páginas vistas/día. Cien capturas/día (capacidad máxima: 300). Se pueden almacenar tres mapas de calor durante 365 días. Miembros ilimitados en el equipo. También encuestas y widgets de feedback en la app y de forma independiente, con capturas de pantalla. El nivel gratuito permite crear 3 encuestas y 3 widgets de feedback y recoger 20 respuestas por mes.
  * [Keen](https://keen.io/) — Analítica personalizada para recolección, análisis y visualización de datos. 1,000 eventos/mes gratis
  * [Yandex.Datalens](https://datalens.yandex.com/) — Servicio de visualización y análisis de datos de Yandex Cloud. El servicio se ofrece sin costo. Sin restricciones en el número de usuarios y consultas.
  * [Yandex.Metrica](https://metrica.yandex.com/) — Analítica ilimitada gratuita
  * [Mixpanel](https://mixpanel.com/) — 100,000 usuarios rastreados mensualmente, historial de datos ilimitado y asientos ilimitados, residencia de datos en EE.UU. o UE
  * [Moesif](https://www.moesif.com) — Analítica de API para REST y GraphQL. (Gratis hasta 500,000 llamadas API/mes)
  * [optimizely.com](https://www.optimizely.com) — Solución de pruebas A/B, plan inicial gratuito, un sitio web, 1 app iOS y 1 app Android
  * [Microsoft PowerBI](https://powerbi.com) — Business Insights & Analytics de Microsoft. El plan gratuito ofrece uso limitado con 1 millón de licencias de usuario.
  * [Row Zero](https://rowzero.io) - Hoja de cálculo ultrarrápida y conectada. Conecta directamente a bases de datos, S3 y APIs. Importa, analiza, grafica y comparte millones de filas al instante. Tres libros de trabajo gratuitos (para siempre).
  * [sematext.com](https://sematext.com/cloud/) — Gratis hasta 50 K acciones/mes, 1 día de retención de datos, dashboards, usuarios ilimitados, etc.
  * [Similar Web](https://similarweb.com) — Analítica para apps web y móviles. El plan gratuito ofrece cinco resultados por métrica, un mes de datos de apps móviles y 3 meses de datos de sitio web.
  * [StatCounter](https://statcounter.com/) — Analítica de visitantes web. Plan gratuito para analizar los 500 visitantes más recientes.
  * [Statsig](https://statsig.com) - Plataforma todo-en-uno para analítica, flags de características y pruebas A/B. Gratis hasta 1m de eventos medidos por mes.
  * [Tableau Developer Program](https://www.tableau.com/developer) — Innova, crea y haz que Tableau funcione a la perfección para tu organización. El programa gratuito para desarrolladores da una licencia de sandbox personal para Tableau Online. La versión es la última pre-lanzamiento para que los Data Devs puedan probar cada función de esta excelente plataforma.
  * [usabilityhub.com](https://usabilityhub.com/) — Prueba diseños y maquetas con personas reales y rastrea visitantes. Gratis para un usuario, tests ilimitados
  * [woopra.com](https://www.woopra.com/) — Plataforma gratuita de analítica de usuarios para 500K acciones, 90 días de retención de datos, más de 30 integraciones con un clic.
  * [counter.dev](https://counter.dev) — Analítica web simple y por ende amigable con la privacidad. Gratuito o paga lo que desees mediante donación.
  * [PostHog](https://posthog.com) - Suite completa de analítica de producto gratis hasta 1 millón de eventos rastreados por mes. También ofrece encuestas en la app ilimitadas con 250 respuestas/mes.
  * [Uptrace](https://uptrace.dev) - Herramienta de trazado distribuido que ayuda a los desarrolladores a detectar fallos y cuellos de botella de rendimiento. Tiene plan gratuito, ofrece suscripción Personal gratuita para proyectos open-source y tiene versión de código abierto.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Clarity es una herramienta gratuita y fácil de usar que captura cómo usan realmente las personas tu sitio.
  * [Beampipe.io](https://beampipe.io) - Beampipe es analítica web simple y centrada en la privacidad. Gratis hasta 5 dominios y 10k páginas vistas mensuales.
  * [Aptabase](https://aptabase.com) — Analítica Open Source, amigable con la privacidad y simple para apps móviles y de escritorio. SDKs para Swift, Kotlin, React Native, Flutter, Electron y muchos más. Gratis hasta 20,000 eventos por mes.
  * [Trackingplan](https://www.trackingplan.com/) - Detecta automáticamente problemas de analítica digital, datos de marketing y píxeles, mantiene los planes de seguimiento actualizados y fomenta la colaboración fluida. Despliega en tu entorno de producción con tráfico real o añade cobertura de analítica a tus pruebas de regresión sin escribir código.
  * [LogSpot](https://logspot.io) - Plataforma completa y unificada de analítica web y de producto, incluyendo widgets de analítica embebibles y robots automatizados (slack, telegram y webhooks). El plan gratuito incluye 10,000 eventos al mes.
  * [Umami](https://umami.is/) - Alternativa simple, rápida, enfocada en la privacidad y de código abierto a Google Analytics.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - Alternativa gratuita, ligera y enfocada en la privacidad a Google Analytics. Páginas vistas ilimitadas, visitantes ilimitados, mapas de calor de página y seguimiento de objetivos ilimitados. Gratis hasta 3 dominios y 600 reproducciones de sesión por dominio.
  * [AppFit](https://appfit.io) - AppFit es una herramienta integral de analítica y gestión de producto diseñada para facilitar la gestión fluida, multiplataforma, de analítica y actualizaciones de producto. El plan gratuito incluye 10,000 eventos al mes, diario de producto e insights semanales.
  * [Seline](https://seline.so) - Seline es una analítica sencilla y privada para sitios web y productos. Sin cookies, ligera, independiente. El plan gratuito incluye 3,000 eventos por mes y acceso a todas las funciones, como el dashboard, recorridos de usuario, embudos y más.
  * [Peasy](https://peasy.so) - Peasy es una herramienta de analítica ligera y centrada en la privacidad para sitios web y productos. El plan gratuito incluye 3,000 eventos por mes.
  * [Rybbit](https://rybbit.io) - Alternativa open-source y sin cookies a Google Analytics que es 10 veces más intuitiva. El plan gratuito tiene 3,000 eventos mensuales. 

**[⬆️ Volver al inicio](#table-of-contents)**

## Grabación de Sesiones de Visitantes

  * [Reactflow.com](https://www.reactflow.com/) — Por sitio: 1,000 páginas vistas/día, tres mapas de calor, tres widgets, seguimiento de errores gratis
  * [OpenReplay.com](https://www.openreplay.com) - Reproducción de sesión open-source con herramientas para desarrolladores para reproducir bugs, sesión en vivo para soporte en tiempo real y suite de analítica de producto. Mil sesiones/mes con acceso a todas las funciones y retención de 7 días.
  * [LogRocket.com](https://www.logrocket.com) - 1,000 sesiones/mes con 30 días de retención, seguimiento de errores, modo en vivo
  * [FullStory.com](https://www.fullstory.com) — 1,000 sesiones/mes con un mes de retención de datos y tres asientos de usuario. Más información [aquí](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — Por sitio: 1,050 páginas vistas/mes, mapas de calor ilimitados, datos almacenados por tres meses
  * [inspectlet.com](https://www.inspectlet.com/) — 2,500 sesiones/mes gratis para un sitio web
  * [Microsoft Clarity](https://clarity.microsoft.com/) - Grabación de sesiones completamente gratis con "sin límites de tráfico", sin límites de proyectos y sin muestreo
  * [mouseflow.com](https://mouseflow.com/) — 500 sesiones/mes gratis para un sitio web
  * [mousestats.com](https://www.mousestats.com/) — 100 sesiones/mes gratis para un sitio web
  * [smartlook.com](https://www.smartlook.com/) — paquetes gratuitos para apps web y móviles (1500 sesiones/mes), tres mapas de calor, un embudo, historial de datos de 1 mes
  * [howuku.com](https://howuku.com) — Rastrea interacción, engagement y eventos de usuario. Gratis hasta 5,000 visitas/mes
  * [UXtweak.com](https://www.uxtweak.com/) — Graba y observa cómo los visitantes usan tu sitio web o app. Gratis por tiempo ilimitado para proyectos pequeños

**[⬆️ Volver al inicio](#table-of-contents)**
## API y SDK de Verificación Internacional de Números Móviles

  * [numverify](https://numverify.com/) — Validación global de números de teléfono y API JSON de consulta. 100 solicitudes de API/mes.
  * [veriphone](https://veriphone.io/) — Verificación global de números de teléfono en una API JSON gratuita, rápida y confiable. 1000 solicitudes/mes.

**[⬆️ Volver arriba](#table-of-contents)**

## Integración de Pagos y Facturación

  * [Qonversion](http://qonversion.io/) - Plataforma todo en uno para gestión de suscripciones multiplataforma que ofrece analíticas, pruebas A/B, Apple Search Ads, configuraciones remotas y herramientas de crecimiento para optimizar compras dentro de la app y monetización. Compatible con iOS, Android, React Native, Flutter, Unity, Cordova, Stripe y web. Gratis hasta $10k de ingresos mensuales rastreados.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – Ajusta automáticamente los precios según la ubicación del visitante para expandir tu negocio globalmente y llegar a nuevos mercados (paridad de poder adquisitivo). El plan gratuito incluye 7.500 solicitudes de API/mes.
  * [Glassfy](https://glassfy.io/) – Infraestructura de suscripciones dentro de la app, eventos de suscripción en tiempo real y herramientas de monetización listas para usar en iOS, Android, Stripe y Paddle. Gratis hasta $10k de ingresos mensuales.
  * [Adapty.io](https://adapty.io/) – Solución integral con SDK de código abierto para la integración de suscripciones móviles in-app en iOS, Android, React Native, Flutter, Unity o web app. Gratis hasta $10k de ingresos mensuales.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — Proporciona datos de mercado de criptomonedas incluyendo las tasas de cambio más recientes de criptomonedas y monedas fiduciarias. El nivel gratuito ofrece 10K créditos de llamadas/mes.
  * [CurrencyFreaks](https://currencyfreaks.com/) — Proporciona tasas de cambio actuales e históricas. Plan DEVELOPER gratuito disponible con 1000 solicitudes/mes.
  * [CoinGecko](https://www.coingecko.com/en/api) — Proporciona datos de mercado de criptomonedas incluyendo tasas de cambio de criptomonedas actuales y datos históricos. La API demo tiene un límite estable de 30 llamadas/min y un tope mensual de 10.000 llamadas.
  * [CurrencyApi](https://currencyapi.net/) — Tasas de cambio en vivo para monedas físicas y criptomonedas, entregadas en JSON y XML. El nivel gratuito ofrece 1.250 solicitudes de API/mes.
  * [currencylayer](https://currencylayer.com/) — Tasas de cambio confiables y conversión de divisas para tu negocio, 100 solicitudes de API/mes gratis.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - Una API de conversión de divisas JSON fácil de usar. El nivel gratuito se actualiza una vez al día con un límite de 1.500 solicitudes/mes.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — Ayuda a los comerciantes a prevenir el fraude en pagos y contracargos. Plan Micro gratuito disponible con 500 consultas/mes.
  * [FxRatesAPI](https://fxratesapi.com) — Proporciona tasas de cambio en tiempo real e históricas. El nivel gratuito requiere atribución.
  * [Moesif API Monetization](https://www.moesif.com/) - Genera ingresos de APIs mediante facturación basada en uso. Conéctate con Stripe, Chargebee, etc. El nivel gratuito ofrece 30.000 eventos/mes.
  * [Nami ML](https://www.namiml.com/) - Plataforma completa para compras y suscripciones dentro de la app en iOS y Android, incluyendo muros de pago sin código, CRM y analíticas. Gratis para todas las funciones base para operar un negocio IAP.
  * [RevenueCat](https://www.revenuecat.com/) — Backend alojado para compras y suscripciones dentro de la app (iOS y Android). Gratis hasta $2.5k/mes en ingresos rastreados.
  * [vatlayer](https://vatlayer.com/) — Validación instantánea de números de IVA y API de tasas de IVA de la UE, gratis 100 solicitudes de API/mes.
  * [Currencyapi](https://currencyapi.com) — API gratuita de conversión de moneda y datos de tasas de cambio. Gratis 300 solicitudes por mes, 10 solicitudes por minuto para uso privado.

**[⬆️ Volver arriba](#table-of-contents)**

## Relacionados con Docker

  * [canister.io](https://canister.io/) — 20 repositorios privados gratuitos para desarrolladores, 30 repositorios privados gratuitos para equipos para construir y almacenar imágenes Docker.
  * [Container Registry Service](https://container-registry.com/) - Solución de gestión de contenedores basada en Harbor. El nivel gratuito ofrece 1 GB de almacenamiento para repositorios privados.
  * [Docker Hub](https://hub.docker.com) — Un repositorio privado gratuito y repositorios públicos ilimitados para construir y almacenar imágenes Docker.
  * [Play with Docker](https://labs.play-with-docker.com/) — Un entorno simple, interactivo y divertido para aprender Docker.
  * [quay.io](https://quay.io/) — Construye y almacena imágenes de contenedores con repositorios públicos ilimitados y gratuitos.
  * [ttl.sh](https://ttl.sh/) - Registro de imágenes Docker anónimo y efímero.

**[⬆️ Volver arriba](#table-of-contents)**

## Relacionados con Vagrant

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Alojamiento de cajas Vagrant.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — Un índice público alternativo de cajas.

**[⬆️ Volver arriba](#table-of-contents)**

## Sitios de Blogging para Desarrolladores

  * [BearBlog](https://bearblog.dev/) - Blog minimalista y creador de sitios web impulsado por Markdown.
  * [Dev.to](https://dev.to/) - Donde los programadores comparten ideas y se ayudan a crecer.
  * [Hashnode](https://hashnode.com/) — Software de blogging sin complicaciones para desarrolladores.
  * [Medium](https://medium.com/) — Reflexiona más sobre lo que te importa.
  * [AyeDot](https://ayedot.com/) — Comparte tus ideas, conocimientos e historias con el mundo gratis en forma de miniblogs multimedia cortos y modernos.

**[⬆️ Volver arriba](#table-of-contents)**

## Plataformas de Comentarios
  * [GraphComment](https://graphcomment.com/) - GraphComment es una plataforma de comentarios que te ayuda a construir una comunidad activa a partir de la audiencia de tu sitio web.
  * [Utterances](https://utteranc.es/) - Widget de comentarios ligero basado en issues de GitHub. Usa issues de GitHub para comentarios en blogs, wikis y más.
  * [Disqus](https://disqus.com/) - Disqus es una plataforma comunitaria usada por cientos de miles de sitios en la web.
  * [Remarkbox](https://www.remarkbox.com/) - Plataforma de comentarios open source alojada, paga lo que quieras por "Un moderador en algunos dominios con control completo sobre comportamiento y apariencia".
  * [IntenseDebate](https://intensedebate.com/) - Un sistema de comentarios con muchas funciones para WordPress, Tumblr, Blogger y muchas otras plataformas web.

**[⬆️ Volver arriba](#table-of-contents)**

## APIs de Captura de Pantallas

  * [ApiFlash](https://apiflash.com) — API de captura de pantallas basada en AWS Lambda y Chrome. Maneja capturas de página completa, temporización y dimensiones de viewport.
  * [microlink.io](https://microlink.io/) – Convierte cualquier sitio web en datos, como normalización de metadatos, vistas previas de enlaces atractivas, capacidades de scraping o capturas de pantalla como servicio. 250 solicitudes/día gratis cada día.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - API de captura de pantallas que utiliza una llamada sencilla para generar capturas de cualquier sitio web. Escalable y alojada en Google Cloud. Ofrece 100 capturas gratuitas por mes.
  * [screenshotlayer.com](https://screenshotlayer.com/) — Captura instantáneas altamente personalizables de cualquier sitio web. Gratis 100 instantáneas/mes.
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — Captura 100 instantáneas/mes, png, gif y jpg, incluyendo capturas de página completa, no solo de la página principal.
  * [PhantomJsCloud](https://PhantomJsCloud.com) — Automatización de navegador y renderizado de páginas. El nivel gratuito ofrece hasta 500 páginas/día. Nivel gratuito desde 2017.
  * [Webshrinker.com](https://webshrinker.com) — Web Shrinker proporciona capturas de sitios web y servicios de inteligencia de dominios por API. Gratis 100 solicitudes/mes.
  * [Screenshots](https://screenshotson.click) — Tu API para capturas de pantalla. Con opciones altamente personalizables para la captura. Gratis 100 capturas/mes.

**[⬆️ Volver arriba](#table-of-contents)**

## Relacionado con Flutter y Construcción de Apps IOS sin Mac

  * [FlutLab](https://flutlab.io/) - FlutLab es un IDE online moderno para Flutter y el mejor lugar para crear, depurar y construir proyectos multiplataforma. Construye apps iOS (sin Mac) y Android con Flutter.
  * [CodeMagic](https://codemagic.io/) - Codemagic es una solución CI/CD totalmente alojada y gestionada para apps móviles. Puedes construir, probar y desplegar con una herramienta CI/CD basada en GUI. El nivel gratuito ofrece 500 minutos gratis/mes y una instancia Mac Mini con 2.3 GHz y 8 GB de RAM.
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlow es una interfaz de arrastrar y soltar basada en navegador para construir apps móviles usando Flutter.

**[⬆️ Volver arriba](#table-of-contents)**

## Emulación de hardware basada en navegador escrita en Javascript

  * [JsLinux](https://bellard.org/jslinux) — una máquina virtual x86 realmente rápida capaz de ejecutar Linux y Windows 2k.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — una máquina virtual OpenRISC capaz de ejecutar Linux con soporte de red.
  * [v86](https://copy.sh/v86) — una máquina virtual x86 capaz de ejecutar Linux y otros sistemas operativos directamente en el navegador.

**[⬆️ Volver arriba](#table-of-contents)**

## Gestión de Privacidad
  * [Bearer](https://www.bearer.sh/) - Ayuda a implementar privacidad por diseño mediante auditorías y flujos de trabajo continuos para que las organizaciones cumplan con el RGPD y otras normativas. El nivel gratuito está limitado a equipos pequeños y solo versión SaaS.
  * [Osano](https://www.osano.com/) - Plataforma de gestión de consentimiento y cumplimiento con todo, desde representación RGPD hasta banners de cookies. El nivel gratuito ofrece funciones básicas.
  * [Iubenda](https://www.iubenda.com/) - Políticas de privacidad y cookies y gestión de consentimiento. El nivel gratuito ofrece política de privacidad y cookies limitada así como banners de cookies.
  * [Cookiefirst](https://cookiefirst.com/) - Banners de cookies, auditoría y solución de gestión de consentimiento multilingüe. El nivel gratuito ofrece un escaneo único y un solo banner.
  * [Ketch](https://www.ketch.com/) - Herramienta de gestión de consentimiento y marco de privacidad. El nivel gratuito ofrece la mayoría de las funciones con un recuento limitado de visitantes.
  * [Concord](https://www.concord.tech/) - Plataforma completa de privacidad de datos, que incluye gestión de consentimiento, manejo de solicitudes de privacidad (DSARs) y mapeo de datos. El nivel gratuito incluye funciones básicas de gestión de consentimiento y también ofrecen un plan más avanzado gratis para proyectos open source verificados.

**[⬆️ Volver al inicio](#table-of-contents)**

## Misceláneos

  * [BackgroundStyler.com](https://backgroundstyler.com) - Crea capturas de pantalla estéticas de tu código, texto o imágenes para compartir en redes sociales.
  * [BinShare.net](https://binshare.net) - Crea y comparte código o binarios. Disponible para compartir como una imagen atractiva, p. ej. para publicaciones en Twitter / Facebook o como un enlace, p. ej. para chats o foros.
  * [Blynk](https://blynk.io) — Un SaaS con API para controlar, construir y evaluar dispositivos IoT. Plan de desarrollador gratuito con 5 dispositivos, almacenamiento en la nube y de datos gratis. También hay aplicaciones móviles disponibles.
  * [Bricks Note Calculator](https://free.getbricks.app/) - una aplicación de toma de notas (PWA) con una potente calculadora multilínea incorporada.
  * [Carbon.now.sh](https://carbon.now.sh) - crea y comparte fragmentos de código en un formato de imagen tipo captura de pantalla estética. Normalmente se usa para compartir o mostrar fragmentos de código de forma estética en Twitter o publicaciones de blogs.
  * [Code Time](https://www.software.com/code-time) - una extensión para el seguimiento de tiempo y métricas de codificación en VS Code, Atom, IntelliJ, Sublime Text y más.
  * [Codepng](https://www.codepng.app) - Crea instantáneas excelentes de tu código fuente para compartir en redes sociales.
  * [CodeToImage](https://codetoimage.com/) - Crea capturas de pantalla de código o texto para compartir en redes sociales.
  * [Cronhooks](https://cronhooks.io/) - Programa webhooks únicos o recurrentes. El plan gratuito permite 5 programaciones ad-hoc.
  * [cron-job.org](https://cron-job.org) - Servicio online de cronjobs. Trabajos ilimitados sin cargo.
  * [datelist.io](https://datelist.io) - Sistema de reservas/citas online. Gratis hasta 5 reservas al mes, incluye 1 calendario.
  * [Domain Forward](https://domain-forward.com/) - Una herramienta sencilla para redirigir cualquier URL o dominio. Gratis hasta 5 dominios y 200k solicitudes por mes.
  * [Elementor](https://elementor.com) — Constructor de sitios web para WordPress. Plan gratuito disponible con más de 40 widgets básicos.
  * [Exif Editor](https://exifeditor.io/) — Visualiza, edita, elimina y analiza metadatos de imágenes/fotos directamente en el navegador, incluyendo ubicación GPS y metadatos.
  * [Format Express](https://www.format-express.dev) - Formato instantáneo online para JSON / XML / SQL.
  * [FOSSA](https://fossa.com/) - Gestión escalable y de extremo a extremo para código de terceros, cumplimiento de licencias y vulnerabilidades.
  * [Hook Relay](https://www.hookrelay.dev/) - Añade soporte de webhooks a tu app sin complicaciones: colas listas para usar, reintentos con backoff y registro de logs. El plan gratuito ofrece 100 entregas por día, retención de 14 días y 3 endpoints de hooks.
  * [Hosting Checker](https://hostingchecker.co) - Consulta información de hosting como ASN, ISP, ubicación y más para cualquier dominio, web o IP. También incluye varias herramientas relacionadas con hosting y DNS.
  * [http2.pro](https://http2.pro) — Prueba de preparación para el protocolo HTTP/2 y API de detección de soporte HTTP/2 del cliente.
  * [kandi](https://kandi.openweaver.com/) — Impulsa el desarrollo de aplicaciones: crea funciones personalizadas, casos de uso y aplicaciones completas más rápido mediante fragmentos de código y reutilización de librerías open source.
  * [Base64 decoder/encoder](https://devpal.co/base64-decode/) — Herramienta online gratuita para decodificar y codificar datos.
  * [newreleases.io](https://newreleases.io/) - Recibe notificaciones por correo, Slack, Telegram, Discord y webhooks personalizados sobre nuevas versiones de GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo y Docker Hub.
  * [OnlineExifViewer](https://onlineexifviewer.com/) — Visualiza datos EXIF online al instante de una foto, incluyendo ubicación GPS y metadatos.
  * [PDFMonkey](https://www.pdfmonkey.io/) — Gestiona plantillas PDF en un panel, llama a la API con datos dinámicos y descarga tu PDF. Ofrece 300 documentos gratuitos al mes.
  * [Pika Code Screenshots](https://pika.style/templates/code-image) — Crea capturas de pantalla hermosas y personalizables de fragmentos de código y VSCode usando la extensión.
  * [QuickType.io](https://quicktype.io/) - Genera automáticamente modelos/clases/tipos/interfaces y serializadores desde JSON, esquemas y GraphQL para trabajar con datos de forma rápida y segura en cualquier lenguaje de programación. Convierte JSON en código tipado hermoso en cualquier lenguaje.
  * [RandomKeygen](https://randomkeygen.com/) - Herramienta gratuita, amigable para móviles, que ofrece una variedad de claves y contraseñas aleatorias para asegurar cualquier aplicación, servicio o dispositivo.
  * [ray.so](https://ray.so/) - Crea imágenes hermosas de tus fragmentos de código.
  * [readme.com](https://readme.com/) — Documentación hermosa hecha fácil, gratis para Open Source.
  * [redirection.io](https://redirection.io/) — Herramienta SaaS para la gestión de redirecciones HTTP para empresas, marketing y SEO.
  * [redirect.ing](https://redirect.ing/) - Redirección de dominios rápida y segura sin gestionar servidores ni certificados SSL. El plan gratuito incluye 10 nombres de host y 100.000 solicitudes al mes.
  * [redirect.pizza](https://redirect.pizza/) - Gestiona redirecciones fácilmente con soporte HTTPS. El plan gratuito incluye 10 orígenes y 100.000 accesos al mes.
  * [ReqBin](https://reqbin.com/) — Envía solicitudes HTTP online. Métodos populares: GET, POST, PUT, DELETE y HEAD. Soporta encabezados y autenticación por token. Incluye sistema básico de login para guardar tus solicitudes.
  * [Smartcar API](https://smartcar.com) - Una API para autos que permite localizar, obtener nivel de combustible, batería, odómetro, abrir/cerrar puertas, etc.
  * [snappify](https://snappify.com) - Permite a desarrolladores crear visuales impresionantes. Desde fragmentos de código hermosos hasta presentaciones técnicas completas. El plan gratuito incluye hasta 3 snaps a la vez con descargas ilimitadas y 5 explicaciones de código con IA por mes.
  * [Sunrise and Sunset](https://sunrisesunset.io/api/) - Obtén horarios de salida y puesta de sol para una longitud y latitud dadas.
  * [superfeedr.com](https://superfeedr.com/) — Feeds en tiempo real compatibles con PubSubHubbub, exportación, análisis. Gratis con menos personalización.
  * [SurveyMonkey.com](https://www.surveymonkey.com) — Crea encuestas online. Analiza los resultados online. El plan gratuito solo permite 10 preguntas y 100 respuestas por encuesta.
  * [Tiledesk](https://tiledesk.com) - Crea chatbots y apps conversacionales. Llévalos a omnicanal: desde tu web (widget de chat en vivo) hasta WhatsApp. Plan gratuito con chatbots ilimitados.
  * [Versionfeeds](https://versionfeeds.com) — Feeds RSS personalizados para lanzamientos de tu software favorito. Ten las últimas versiones de lenguajes de programación, librerías o herramientas favoritas en un solo feed. (Los primeros 3 feeds son gratuitos)
  * [videoinu](https://videoinu.com) — Crea y edita grabaciones de pantalla y otros videos online.
  * [Webacus](https://webacus.dev) — Accede a una amplia gama de herramientas gratuitas para desarrolladores para codificar, decodificar y manipular datos.

**[⬆️ Volver al inicio](#table-of-contents)**

## Herramientas de Escritorio Remoto

  * [Getscreen.me](https://getscreen.me) —  Gratis para 2 dispositivos, sin límites en número ni duración de sesiones.
  * [Apache Guacamole™](https://guacamole.apache.org/) — Gateway de escritorio remoto sin cliente, de código abierto.
  * [RemSupp](https://remsupp.com) — Soporte bajo demanda y acceso permanente a dispositivos (2 sesiones/día gratis).
  * [RustDesk](https://rustdesk.com/) - Infraestructura de escritorio remoto/virtual de código abierto para todos.
  * [AnyDesk](https://anydesk.com) —  Gratis para 3 dispositivos, sin límites en número ni duración de sesiones.

**[⬆️ Volver al inicio](#table-of-contents)**

## Desarrollo de Juegos

  * [itch.io](https://itch.io/game-assets) — Assets gratuitos/pagos como sprites, tile sets y paquetes de personajes.
  * [Gamefresco.com](https://gamefresco.com/) — Descubre, recopila y comparte assets gratuitos de juegos de artistas de todo el mundo.
  * [GameDevMarket](https://gamedevmarket.net) — Assets gratuitos/pagos como 2D, 3D, audio, GUI.
  * [OpenGameArt](https://opengameart.org) — Assets de juegos open source como música, sonidos, sprites y gifs.
  * [CraftPix](https://craftpix.net) — Assets gratuitos/pagos como 2D, 3D, audio, GUI, fondos, iconos, tile sets, kits de juego.
  * [Game Icons](https://game-icons.net/) - Iconos SVG/PNG personalizables gratuitos bajo licencia CC-BY.
  * [LoSpec](https://lospec.com/) — Herramientas online para crear pixel art y otro arte digital restrictivo, con muchos tutoriales/listas de paletas para tus juegos.
  * [ArtStation](https://www.artstation.com/) - Marketplace para assets 2D, 3D y audios gratuitos/pagos, iconos, tile sets, kits de juego. También puede usarse para mostrar tu portafolio artístico.
  * [Rive](https://rive.app/community/) - Assets de la comunidad, así como crear tus propios assets de juego usando su plan gratuito.
  * [Poly Pizza](https://poly.pizza/) - Assets 3D low poly gratuitos.
  * [3Dassets.one](https://3dassets.one/) - Más de 8,000 modelos 3D gratuitos/pagos y materiales PBR para crear texturas.
  * [Kenney](https://www.kenney.nl/assets/) - Assets de juegos 2D, 3D, audio y UI gratuitos (licencia CC0 1.0 Universal).
  * [Poliigon](https://www.poliigon.com/) - Texturas gratuitas y de pago (con resolución variable), modelos, HDRIs y pinceles. Ofrece plugins gratis para exportar a software como Blender.
  * [Freesound](https://freesound.org/) - Biblioteca colaborativa de sonidos gratuita con diferentes licencias CC.

**[⬆️ Volver al inicio](#table-of-contents)**

## Otros Recursos Gratuitos

  * [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - Herramientas siempre gratuitas para desarrolladores web que incluyen minificador/desminificador CSS, optimizador de imágenes, redimensionador de imágenes, convertidor de mayúsculas/minúsculas, validador CSS, compilador JavaScript, editor HTML, etc.
  * [ElevateAI](https://www.elevateai.com) - Obtén hasta 200 horas de transcripción de audio gratis cada mes.
  * [get.localhost.direct](https://get.localhost.direct) — Un mejor certificado SSL público CA firmado Wildcard para desarrollo en localhost con soporte para subdominios.
  * [Framacloud](https://degooglisons-internet.org/en/) — Una lista de software libre/gratis y SaaS por la organización francesa sin ánimo de lucro [Framasoft](https://framasoft.org/en/).
  * [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — Un hub de software gratuito y open source para desarrolladores.
  * [GitHub Education](https://education.github.com/pack) — Colección de servicios gratuitos para estudiantes. Se requiere registro.
  * [Markdown Tools](https://markdowntools.com) - Herramientas para convertir HTML, CSV, PDF, JSON y archivos Excel a y desde Markdown.
  * [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Obtén un sandbox gratuito, herramientas y otros recursos que necesitas para construir soluciones para la plataforma Microsoft 365. La suscripción es de 90 días de [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) (Windows excluido) y es renovable. Se renueva si eres activo en el desarrollo (medido usando datos de telemetría y algoritmos).
  * [Pyrexp](https://pythonium.net/regex) — Probador y visualizador gratuito de expresiones regulares basado en la web para depurar regex.
  * [RedHat for Developers](https://developers.redhat.com) — Acceso gratuito a productos de Red Hat, incluyendo RHEL, OpenShift, CodeReady, etc. exclusivamente para desarrolladores. Solo plan individual. También se ofrecen ebooks gratuitos como referencia.
  * [smsreceivefree.com](https://smsreceivefree.com/) — Proporciona números de teléfono temporales y desechables gratis.
  * [sandbox.httpsms.com](https://sandbox.httpsms.com) — Envía y recibe SMS de prueba gratis.
  * [SimpleBackups.com](https://simplebackups.com/) — Servicio de automatización de backups para servidores y bases de datos (MySQL, PostgreSQL, MongoDB) almacenados directamente en proveedores de almacenamiento en la nube (AWS, DigitalOcean y Backblaze). Ofrece un plan gratuito para 1 backup.
  * [SnapShooter](https://snapshooter.com/) — Solución de backup para DigitalOcean, AWS, LightSail, Hetzner y Exoscale, con soporte para backups directos de bases de datos, sistemas de archivos y aplicaciones en almacenamiento tipo s3. Ofrece un plan gratuito con backups diarios para un recurso.
  * [Themeselection](https://themeselection.com/) — Selección de plantillas de panel de administración, temas HTML y UI Kits de alta calidad, modernos, profesionales y fáciles de usar para crear tus aplicaciones más rápido.
  * [Web.Dev](https://web.dev/measure/) — Herramienta gratuita que te permite ver el rendimiento de tu web y mejorar el SEO para obtener un mejor ranking en motores de búsqueda.
  * [SmallDev.tools](https://smalldev.tools/) — Una herramienta gratuita para desarrolladores que permite codificar/decodificar varios formatos, minificar HTML/CSS/Javascript, embellecer, generar conjuntos de datos falsos/de prueba en JSON/CSV y muchos otros formatos y muchas más funciones. Con una interfaz agradable.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — Añade importación de CSV y Excel a tu aplicación web en minutos. Brinda a tus usuarios una experiencia de importación de datos agradable y robusta. Comienza gratis sin necesidad de tarjeta de crédito e integra UseCSV hoy mismo. Puedes crear importadores ilimitados y subir archivos de hasta 100Mb.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — Más de 100 botones que puedes usar en tu proyecto.
  * [WrapPixel](https://www.wrappixel.com/) — Descarga plantillas de panel de administración de alta calidad, gratuitas y premium, creadas con Angular, React, VueJs, NextJS y NuxtJS.
  * [Utils.fun](https://utils.fun/en) — Todas las herramientas diarias y de desarrollo offline basadas en la capacidad de cómputo del navegador, incluyendo generación de marcas de agua, grabación de pantalla, codificación y decodificación, encriptación y desencriptación, y formateo de código, son completamente gratuitas y no suben ningún dato a la nube para su procesamiento.
  * [It tools](it-tools.tech) - Herramientas útiles para desarrolladores y personas que trabajan en IT.
  * [Free Code Tools](https://freecodetools.org/) — Herramientas de código efectivas y 100% gratuitas. Editor Markdown, minificador/embellecedor de código, generador de código QR, generador de Open Graph, generador de tarjetas de Twitter, y más.
  * [regex101](https://regex101.com/) — Gratuito, este sitio web te permite probar y depurar expresiones regulares (regex). Proporciona un editor y probador de regex, así como documentación útil y recursos para aprender regex.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — Más de 100 herramientas de desarrollo incluyendo formateadores, minificadores y convertidores.
  * [AdminMart](https://adminmart.com/) — Plantillas de panel de administración y sitios web de alta calidad, gratuitas y premium, creadas con Angular, Bootstrap, React, VueJs, NextJS y NuxtJS.
  * [Glob tester](https://globster.xyz/) — Un sitio web que te permite diseñar y probar patrones glob. También proporciona recursos para aprender patrones glob.
  * [SimpleRestore](https://simplerestore.io) - Restauración de copias de seguridad MySQL sin complicaciones. Restaura respaldos MySQL a cualquier base de datos remota sin necesidad de código ni servidor.
  * [360Converter](https://www.360converter.com/) - Sitio web útil y gratuito para convertir: Video a Texto && Audio a Texto && Voz a Texto && Audio en tiempo real a Texto && Video de YouTube a Texto && añadir subtítulos a videos. Puede ser útil para una conversión de video corta o en un breve tutorial de YouTube :)
  * [QRCodeBest](https://qrcode.best/) - Crea códigos QR personalizados con 13 plantillas, total privacidad y branding personal. Incluye píxeles de seguimiento, categorización de proyectos y asientos ilimitados para equipos en QRCode.Best.
  * [PostPulse](https://PostPulseAI.com) - Potencia tu presencia online, mejora tu SEO y el ranking de tu sitio con publicaciones mensuales elaboradas por IA en dominios optimizados para SEO. El plan gratuito te permite publicar manualmente una publicación en nuestro sitio cada mes.
  * [PageTools](https://pagetools.co/) - Ofrece un conjunto de herramientas potenciadas por IA, siempre gratuitas, para ayudarte a generar políticas esenciales para sitios web, crear biografías, publicaciones y páginas web para redes sociales con una interfaz de un solo clic.
  * [MySQL Visual Explain](https://mysqlexplain.com) - Visualizador gratuito y fácil de entender de la salida de MySQL EXPLAIN para optimizar consultas lentas.
  * [Killer Coda](https://killercoda.com/)  - Entorno interactivo en tu navegador para estudiar Linux, Kubernetes, Contenedores, Programación, DevOps, Redes.
  * [Axonomy App](https://axonomy-app.com/) - Herramienta gratuita para crear, gestionar y compartir tus facturas con tus clientes. 10 facturas gratis al mes.
  * [Table Format Converter](https://www.tableformatconverter.com) - Herramienta gratuita para convertir datos de tablas a diferentes formatos, como CSV, HTML, JSON, Markdown y más.


**[⬆️ Volver al inicio](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---