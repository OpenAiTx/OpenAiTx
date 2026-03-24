# 🦞 Increíbles Agentes OpenClaw

[![Awesome](https://awesome.re/badge.svg)](https://awesome.re)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)
[![Stars](https://img.shields.io/github/stars/mergisi/awesome-openclaw-agents?style=social)](https://github.com/mergisi/awesome-openclaw-agents)
[![Agents](https://img.shields.io/badge/agents-187-blueviolet)](agents/)

> Una colección seleccionada de **187 plantillas de agentes de IA listas para producción** para el ecosistema OpenClaw. Cada plantilla es un archivo `SOUL.md` listo para copiar y pegar.

<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:4F46E5,100:7C3AED&height=180&section=header&text=%F0%9F%A6%9E%20187%20Plantillas%20de%20Agentes%20OpenClaw&fontSize=36&fontColor=ffffff&fontAlignY=35" width="100%"/>
</p>

<div align="center">

### Omite la configuración. Despliega en 60 segundos.

**[Explora las 187 plantillas →](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=browse)** · **[Despliega en 60 segundos →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=deploy)**

Elige una plantilla. Personaliza la configuración. Obtén un paquete completo para desplegar. No se requiere terminal.

</div>

<div align="center">

📬 **Recibe plantillas de agentes y consejos semanalmente** — nuevas plantillas, guías de despliegue y novedades de la comunidad cada martes.

**[Suscríbete al boletín →](https://docs.google.com/forms/d/e/1FAIpQLSeIqBjV1LXnR2qQqGSGa-48rAveAmpSKVqlzLqDK2d4D4aVWg/viewform)**

</div>

---

## Contenido

- [Plantillas de Agentes](#agent-templates) (187 agentes en 24 categorías)
  - [Productividad](#productivity) · [Desarrollo](#development) · [Marketing](#marketing--content) · [Negocios](#business) · [Personal](#personal)
  - [DevOps](#devops) · [Finanzas](#finance) · [Educación](#education) · [Salud](#healthcare) · [Legal](#legal) · [Recursos Humanos](#hr) · [Creativo](#creative) · [Seguridad](#security)
  - [Comercio Electrónico](#e-commerce) · [Datos](#data) · [SaaS](#saas) · [Bienes Raíces](#real-estate) · [Freelance](#freelance) · [Moltbook](#-moltbook-new)
  - [Cadena de Suministro](#supply-chain) · [Cumplimiento](#compliance) · [Voz](#voice) · [Éxito del Cliente](#customer-success) · [Automatización](#automation)
- [Casos de Uso](#use-cases) (132 ejemplos del mundo real)
- [Inicio Rápido](#quickstart)
- [¿Por qué OpenClaw?](#why-openclaw) (vs Frameworks, Ligero, Empresarial)
- [Despliegue Rápido con CrewClaw](#quick-deploy-with-crewclaw)
- [Servidores MCP](#mcp-servers)
- [Integraciones](#integrations)
- [Herramientas](#tools)
- [Seguridad](#security)
- [Tutoriales y Guías](#tutorials--guides)
- [Envía Tu Agente](#submit-your-agent)
- [Comunidad](#community)

---

## Plantillas de Agentes

Plantillas SOUL.md listas para usar para tus agentes de IA. Copia el SOUL.md, regístralo con `openclaw agents add` y comienza la pasarela.

```bash
# Quick start with any template
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
npm install && cp ../agents/productivity/orion/SOUL.md ./SOUL.md
node bot.js
```
> Todos los 100 agentes también están disponibles en formato JSON legible por máquina: [`agents.json`](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json)

> **¿Saltar la configuración?** [CrewClaw](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=skip_setup) genera un paquete de despliegue completo (Dockerfile + docker-compose + bot + README) para cualquier rol.

### 📋 Productividad

Hacer más con menos esfuerzo.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🎯 Orión](agents/productivity/orion/) | Coordinación de tareas, gestión de proyectos | Cuando necesitas prioridades diarias, seguimiento de plazos y alineación del equipo | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/orion/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=project-manager) |
| [📊 Pulso](agents/productivity/metrics/) | Paneles analíticos (Mixpanel, Stripe, GA4) | Cuando quieres informes automáticos diarios/semanales de métricas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/metrics/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧍 Reunión diaria](agents/productivity/daily-standup/) | Recolección de standups diarios, resúmenes de equipo | Cuando tu equipo necesita standups asíncronos sin reuniones | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/daily-standup/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=project-manager) |
| [📧 Bandeja de entrada](agents/productivity/inbox-zero/) | Triaje de correo, redacción de respuestas, resumen diario | Cuando tu bandeja de entrada está abrumadora y necesita priorización | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/inbox-zero/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 Minutas](agents/productivity/meeting-notes/) | Resúmenes de reuniones, seguimiento de tareas | Cuando necesitas notas automáticas de reuniones y seguimientos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/meeting-notes/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🍅 Temporizador de foco](agents/productivity/focus-timer/) | Pomodoro, gestión de sesiones de trabajo profundo | Cuando necesitas tiempo estructurado de enfoque con responsabilidad | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/focus-timer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ Rastreador de hábitos](agents/productivity/habit-tracker/) | Hábitos diarios, rachas, responsabilidad | Cuando quieres chequeos diarios y seguimiento de rachas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/habit-tracker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 💻 Desarrollo

Construyendo el futuro, un commit a la vez.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🔎 Lente](agents/development/code-reviewer/) | Revisión de PR, escaneo de seguridad, calidad de código | Cuando quieres revisión automática de código antes de fusionar | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/code-reviewer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=code-reviewer) |
| [📖 Escriba](agents/development/docs-writer/) | README, documentación API, documentación de código | Cuando la documentación está atrasada respecto a tu base de código | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/docs-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=technical-writer) |
| [🐛 Rastreador](agents/development/bug-hunter/) | Análisis de errores, investigación de causa raíz | Cuando necesitas depuración más rápida y respuesta a incidentes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/bug-hunter/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Sonda](agents/development/api-tester/) | Pruebas de API, chequeos de salud, rendimiento | Cuando necesitas monitoreo continuo de API y alertas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/api-tester/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 Registro](agents/development/changelog/) | Auto-changelog, notas de lanzamiento desde git | Cuando quieres notas de lanzamiento generadas desde commits | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/changelog/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔗 Escáner de dependencias](agents/development/dependency-scanner/) | Escaneo CVE, chequeo de licencias, cadena de suministro | Cuando necesitas auditorías de seguridad automatizadas de dependencias | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/dependency-scanner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔀 Fusionador de PR](agents/development/pr-merger/) | Auto-fusión, detección de conflictos | Cuando quieres que los PR se fusionen automáticamente tras pasar las comprobaciones | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/pr-merger/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗄️ Ayudante de migración](agents/development/migration-helper/) | Migraciones de base de datos, diferencias de esquema, reversión | Cuando planeas cambios en la base de datos y necesitas redes de seguridad | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/migration-helper/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Escritor de pruebas](agents/development/test-writer/) | Generación de pruebas unitarias, análisis de cobertura | Cuando la cobertura de pruebas es baja y necesitas ponerte al día | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/test-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗂️ Diseñador de esquemas](agents/development/schema-designer/) | Esquema DB desde lenguaje natural, salida ERD | Cuando necesitas esquemas de base de datos diseñados desde requerimientos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/schema-designer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |

> **¿Quieres un agente Ingeniero de Software funcionando en 60 segundos?** [Desplegar con CrewClaw →](https://crewclaw.com/create-agent?role=software-engineer)

### 📣 Marketing y Contenido


Crece tu audiencia en piloto automático.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [✍️ Echo](agents/marketing/echo/) | Publicaciones de blog, copias sociales, correos | Cuando necesitas una producción constante de contenido en múltiples canales | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/echo/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Buzz](agents/marketing/social-media/) | Gestión de Twitter, LinkedIn, hilos | Cuando quieres publicaciones sociales programadas con seguimiento de interacción | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/social-media/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [🔍 Rank](agents/marketing/seo-writer/) | Contenido SEO, investigación de palabras clave desde GSC | Cuando necesitas contenido optimizado SEO basado en datos reales de búsqueda | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/seo-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=seo-specialist) |
| [📬 Digest](agents/marketing/newsletter/) | Curación de newsletter, redacción de correos | Cuando quieres un boletín semanal sin trabajo manual | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/newsletter/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🔭 Scout](agents/marketing/competitor-watch/) | Monitoreo de competidores, inteligencia de precios | Cuando necesitas seguir a diario lo que hacen los competidores | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/competitor-watch/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔎 Reddit Scout](agents/marketing/reddit-scout/) | Monitoreo de subreddits, oportunidades de respuesta | Cuando quieres encontrar y participar en hilos relevantes de Reddit | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/reddit-scout/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎵 TikTok Repurposer](agents/marketing/tiktok-repurposer/) | Conversión de blogs a guiones de video | Cuando quieres reutilizar contenido largo en videos cortos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/tiktok-repurposer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [📨 Cold Outreach](agents/marketing/cold-outreach/) | Investigación de leads, correos fríos personalizados | Cuando necesitas alcance escalable sin sonar robótico | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/cold-outreach/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=sales-representative) |
| [📊 A/B Test Analyzer](agents/marketing/ab-test-analyzer/) | Análisis de experimentos, significancia estadística | Cuando realizas experimentos y necesitas resultados claros | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ab-test-analyzer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Influencer Finder](agents/marketing/influencer-finder/) | Investigación de influencers, alcance, campañas | Cuando quieres encontrar y contactar influencers relevantes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/influencer-finder/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [👁️ Brand Monitor](agents/marketing/brand-monitor/) | Monitoreo de menciones de marca, alertas de sentimiento | Cuando necesitas saber cada vez que mencionan tu marca | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/brand-monitor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📧 Email Sequence](agents/marketing/email-sequence/) | Campañas drip multi-paso, líneas de asunto | Cuando necesitas secuencias automatizadas de nutrición por correo | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/email-sequence/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [♻️ Content Repurposer](agents/marketing/content-repurposer/) | De blog a tweets, publicaciones, guiones para shorts | Cuando quieres que un contenido esté en todas las plataformas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/content-repurposer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [📖 Book Writer](agents/marketing/book-writer/) | Producción completa de libro, 6 fases | Cuando quieres escribir un libro desde el esquema hasta el manuscrito | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/book-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [📰 News Curator](agents/marketing/news-curator/) | Escaneo de fuentes, curación AI, publicación | Cuando necesitas resúmenes de noticias automáticos de más de 50 fuentes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/news-curator/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎥 UGC Video](agents/marketing/ugc-video/) | Contenido de video estilo influencer con AI | Cuando necesitas guiones y planes de producción para videos estilo UGC | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ugc-video/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Multi-Account Social](agents/marketing/multi-account-social/) | Gestión de más de 10 cuentas, programación | Cuando gestionas múltiples cuentas de marca en varias plataformas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/multi-account-social/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=social-media-manager) |

> **¿Necesitas un redactor de contenido o un agente SEO?** [Despliega con CrewClaw →](https://crewclaw.com/create-agent?role=content-writer)

### 💼 Negocios

Operar sin sobrecarga.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [📊 Radar](agents/business/radar/) | Análisis de datos, generación de insights | Cuando necesitas métricas diarias de negocio y análisis de tendencias | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/radar/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎧 Compass](agents/business/customer-support/) | Priorización de tickets, redacción de respuestas, escalación | Cuando el volumen de soporte crece más rápido que tu equipo | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/customer-support/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=customer-support) |
| [💼 Pipeline](agents/business/sales-assistant/) | Puntaje de leads, alcance, reportes de pipeline | Cuando necesitas calificación automática de leads y seguimientos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sales-assistant/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=sales-representative) |
| [💰 Ledger](agents/business/invoice-tracker/) | Monitoreo de pagos, seguimiento de facturas, MRR | Cuando quieres seguimiento en tiempo real de ingresos y pagos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/invoice-tracker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔮 Sentinel](agents/business/churn-predictor/) | Puntaje de riesgo de churn, acciones de retención | Cuando quieres detectar clientes en riesgo antes que se vayan | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/churn-predictor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Personal CRM](agents/business/personal-crm/) | Seguimiento de contactos, recordatorios de seguimiento | Cuando pierdes el control de relaciones y seguimientos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/personal-crm/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💬 WhatsApp Business](agents/business/whatsapp-business/) | Soporte multicanal, calificación de leads | Cuando los clientes te contactan por WhatsApp y necesitan respuestas rápidas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/whatsapp-business/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=customer-support) |
| [📅 Meeting Scheduler](agents/business/meeting-scheduler/) | Programación inteligente, manejo de zonas horarias | Cuando agendar reuniones en distintos husos horarios consume tu tiempo | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/meeting-scheduler/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💲 Competitor Pricing](agents/business/competitor-pricing/) | Seguimiento de precios, alertas de cambios | Cuando necesitas monitorear diariamente cambios en precios de competidores | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/competitor-pricing/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📞 SDR Outbound](agents/business/sdr-outbound/) | Investigación de leads, alcance personalizado | Cuando necesitas desarrollo automatizado de ventas outbound | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sdr-outbound/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎯 Pronosticador de Negocios](agents/business/deal-forecaster/) | Señales del pipeline, probabilidad de cierre | Cuando quieres predicciones de cierre de negocios basadas en datos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/deal-forecaster/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🗣️ Gestor de Objeciones](agents/business/objection-handler/) | Réplicas en tiempo real, guiones de conversación | Cuando los representantes de ventas necesitan respuestas instantáneas a objeciones | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/objection-handler/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=sales-representative) |

### 🧘 Personal

Tu asistente de IA para la vida diaria.

| Agente | Especialidad | Cuándo usarlo | SOUL.md | Desplegar |
|--------|--------------|---------------|---------|-----------|
| [📅 Atlas](agents/personal/daily-planner/) | Optimización de agenda, revisiones matutinas/nocturnas | Cuando quieres una rutina diaria estructurada con responsabilidad | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/daily-planner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📚 Scroll](agents/personal/reading-digest/) | Resúmenes de artículos, digest semanal de lectura | Cuando tienes una acumulación de lectura y necesitas resúmenes seleccionados | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/reading-digest/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💪 Iron](agents/personal/fitness-coach/) | Entrenamientos, nutrición, reportes de progreso | Cuando quieres un entrenador personal que registre todo | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/fitness-coach/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏠 Automatización del Hogar](agents/personal/home-automation/) | Control del hogar inteligente vía Telegram | Cuando quieres controlar tu hogar inteligente mediante chat | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/home-automation/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [👨‍👩‍👧‍👦 Coordinador Familiar](agents/personal/family-coordinator/) | Calendario compartido, comidas, rotación de tareas | Cuando tu familia necesita un organizador y planificador compartido | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/family-coordinator/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ Planificador de Viajes](agents/personal/travel-planner/) | Itinerarios, vuelos, hoteles, presupuestos | Cuando necesitas planificar viajes con recomendaciones inteligentes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/travel-planner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📓 Estimulador de Diario](agents/personal/journal-prompter/) | Indicadores diarios, seguimiento del estado de ánimo, metas | Cuando quieres un diario guiado diario para la reflexión | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/journal-prompter/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🚀 DevOps

Manteniendo la infraestructura activa, 24/7.

| Agente | Especialidad | Cuándo usarlo | SOUL.md | Desplegar |
|--------|--------------|---------------|---------|-----------|
| [🚨 Respondedor de Incidentes](agents/devops/incident-responder/) | Triaje de alertas, coordinación de incidentes | Cuando necesitas respuesta automatizada a incidentes y escalamiento | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/incident-responder/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🚀 Guardián de Despliegues](agents/devops/deploy-guardian/) | Monitoreo CI/CD, estado de despliegue | Cuando quieres notificaciones de despliegue y alertas de reversión | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/deploy-guardian/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🖥️ Monitor de Infraestructura](agents/devops/infra-monitor/) | Salud de servidores, disco, CPU, memoria | Cuando necesitas monitoreo proactivo de servidores con alertas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/infra-monitor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📜 Analizador de Logs](agents/devops/log-analyzer/) | Análisis de logs, detección de patrones, anomalías | Cuando estás abrumado por logs y necesitas análisis automatizado | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/log-analyzer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💸 Optimizador de Costos](agents/devops/cost-optimizer/) | Monitoreo de gastos en la nube, sugerencias de ahorro | Cuando tu factura de nube está creciendo y necesitas visibilidad | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/cost-optimizer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔧 Servidor Autocurativo](agents/devops/self-healing-server/) | Reinicio automático de contenedores, limpieza de disco | Cuando quieres servidores que se reparen solos a las 3am | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/self-healing-server/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🍓 Agente Raspberry Pi](agents/devops/raspberry-pi/) | Agente ligero para edge, optimizado para baja RAM | Cuando despliegas agentes en Raspberry Pi o dispositivos edge | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/raspberry-pi/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 Escritor de Runbooks](agents/devops/runbook-writer/) | Runbooks operativos desde arquitectura de sistema | Cuando necesitas procedimientos documentados para respuesta a incidentes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/runbook-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📊 Monitor SLA](agents/devops/sla-monitor/) | Seguimiento de cumplimiento SLA, alertas de degradación | Cuando necesitas rastrear compromisos de uptime entre servicios | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/sla-monitor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📐 Planificador de Capacidad](agents/devops/capacity-planner/) | Pronóstico de capacidad de infraestructura | Cuando necesitas planificar escalabilidad de infraestructura según demanda | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/capacity-planner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |

### 💰 Finanzas

Dando sentido a los números.

| Agente | Especialidad | Cuándo usarlo | SOUL.md | Desplegar |
|--------|--------------|---------------|---------|-----------|
| [🧾 Rastreador de Gastos](agents/finance/expense-tracker/) | Categorización de gastos, alertas de presupuesto | Cuando necesitas seguimiento automático de gastos y monitoreo de presupuesto | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/expense-tracker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧮 Gestor de Facturas](agents/finance/invoice-manager/) | Creación, seguimiento y recordatorios de facturas | Cuando las facturas se pierden y los pagos se retrasan | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/invoice-manager/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 Analista de Ingresos](agents/finance/revenue-analyst/) | Análisis de MRR, churn, previsiones de ingresos | Cuando quieres informes automáticos de ingresos y pronósticos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/revenue-analyst/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🏦 Preparador de Impuestos](agents/finance/tax-preparer/) | Organización de recibos, cálculo de deducciones | Cuando se acerca la temporada de impuestos y necesitas organizarte | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/tax-preparer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📉 Bot de Trading](agents/finance/trading-bot/) | Seguimiento de portafolio, sentimiento, alertas de precios | Cuando quieres monitoreo automático del mercado y alertas de precios | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/trading-bot/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔍 Detector de Fraude](agents/finance/fraud-detector/) | Detección de anomalías en transacciones, alertas de fraude | Cuando necesitas monitoreo en tiempo real de fraudes en transacciones | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/fraud-detector/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Pronosticador Financiero](agents/finance/financial-forecaster/) | Pronósticos de ingresos/gastos basados en datos históricos | Cuando necesitas proyecciones financieras basadas en datos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/financial-forecaster/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⚖️ Rebalanceador de Portafolio](agents/finance/portfolio-rebalancer/) | Análisis de desviación de asignación, operaciones de rebalanceo | Cuando tu portafolio de inversiones necesita rebalanceo periódico | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/portfolio-rebalancer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💳 Cuentas por Pagar](agents/finance/accounts-payable/) | Conciliación de facturas, rutas de aprobación, pagos | Cuando el flujo de trabajo de cuentas por pagar necesita automatización y rapidez | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/accounts-payable/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 Copiador de Operaciones](agents/finance/copy-trader/) | Copiar operaciones de los mejores, controles de riesgo | Cuando quieres replicación automática de operaciones en mercados predictivos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/copy-trader/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🎓 Educación

Aprender de manera más inteligente, no más difícil.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🎓 Tutor](agents/education/tutor/) | Explicación de conceptos, problemas prácticos | Cuando necesitas un tutor paciente disponible 24/7 | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/tutor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [❓ Creador de Quizzes](agents/education/quiz-maker/) | Generación de quizzes, seguimiento de puntuaciones | Cuando quieres quizzes automáticos a partir de tu material de estudio | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/quiz-maker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📖 Planificador de Estudios](agents/education/study-planner/) | Horarios de estudio, recordatorios | Cuando necesitas un plan de estudio estructurado con recordatorios diarios | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/study-planner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 Asistente de Investigación](agents/education/research-assistant/) | Búsqueda de artículos, resúmenes, citas | Cuando haces investigación y necesitas ayuda para encontrar artículos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/research-assistant/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌍 Tutor de Idiomas](agents/education/language-tutor/) | Aprendizaje de idiomas, práctica conversacional | Cuando quieres práctica diaria de idiomas en tu teléfono | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/language-tutor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📐 Diseñador de Currículo](agents/education/curriculum-designer/) | Esquemas de cursos, objetivos de aprendizaje | Cuando necesitas diseño estructurado de cursos y rúbricas de evaluación | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/curriculum-designer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 Evaluador de Ensayos](agents/education/essay-grader/) | Retroalimentación de ensayos, calificación basada en rúbricas | Cuando necesitas evaluación consistente de ensayos a gran escala | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/essay-grader/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🃏 Generador de Tarjetas](agents/education/flashcard-generator/) | Tarjetas de repetición espaciada a partir de notas | Cuando quieres tarjetas automatizadas para estudiar eficientemente | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/flashcard-generator/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🏥 Salud

Cuidando lo que más importa.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🧘 Entrenador de Bienestar](agents/healthcare/wellness-coach/) | Chequeos diarios, salud mental, hábitos | Cuando quieres recordatorios diarios de bienestar y seguimiento del estado de ánimo | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/wellness-coach/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🥗 Planificador de Comidas](agents/healthcare/meal-planner/) | Planes de comidas, seguimiento nutricional | Cuando necesitas planes de comidas semanales basados en tus objetivos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/meal-planner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏋️ Rastreador de Ejercicios](agents/healthcare/workout-tracker/) | Planes de entrenamiento, seguimiento de progreso | Cuando quieres un plan de entrenamiento que se adapte a tu progreso | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/workout-tracker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🩺 Triaje de Síntomas](agents/healthcare/symptom-triage/) | Evaluación estructurada de síntomas, urgencia | Cuando los pacientes necesitan evaluación inicial de síntomas y orientación | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/symptom-triage/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📋 Notas Clínicas](agents/healthcare/clinical-notes/) | Documentación clínica en formato SOAP | Cuando las consultas clínicas necesitan transcripción estructurada de notas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/clinical-notes/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [💊 Verificador de Medicación](agents/healthcare/medication-checker/) | Interacciones medicamentosas, alertas de dosis | Cuando necesitas verificar la seguridad e interacciones de medicamentos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/medication-checker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📝 Registro de Pacientes](agents/healthcare/patient-intake/) | Formularios de ingreso, verificación de seguro | Cuando el registro de pacientes necesita automatización y rapidez | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/patient-intake/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=fitness-coach) |

### ⚖️ Legal

Navegando la letra pequeña.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|-------|-----------|-------------|---------|--------|
| [📜 Revisor de Contratos](agents/legal/contract-reviewer/) | Revisión de contratos, detección de cláusulas riesgosas | Cuando revisas contratos y necesitas una segunda opinión | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/contract-reviewer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ Verificador de Cumplimiento](agents/legal/compliance-checker/) | Monitoreo de cumplimiento, seguimiento de plazos | Cuando necesitas mantenerte al día con requisitos regulatorios | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/compliance-checker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 Redactor de Políticas](agents/legal/policy-writer/) | Políticas internas, términos de servicio | Cuando necesitas redactar o actualizar políticas de la empresa | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/policy-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 Analizador de Patentes](agents/legal/patent-analyzer/) | Reclamaciones de patentes, arte previo, riesgo de infracción | Cuando necesitas análisis de panorama de patentes y evaluación de riesgos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/patent-analyzer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 Redactor de Informes Legales](agents/legal/legal-brief-writer/) | Redacción de informes, mociones, memorandos | Cuando necesitas documentos legales redactados a partir de hechos del caso | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/legal-brief-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔒 Generador de NDA](agents/legal/nda-generator/) | NDAs personalizados, acuerdos de confidencialidad | Cuando necesitas generación rápida y personalizada de NDA | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/nda-generator/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 👥 Recursos Humanos

Construyendo equipos que funcionan.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|-------|-----------|-------------|---------|--------|
| [🤝 Reclutador](agents/hr/recruiter/) | Selección de currículos, programación de entrevistas | Cuando estás contratando y necesitas filtrar candidatos más rápido | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/recruiter/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎒 Incorporación](agents/hr/onboarding/) | Configuración de nuevos empleados, guías de orientación | Cuando los nuevos empleados necesitan una experiencia guiada de incorporación | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/onboarding/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📊 Evaluador de Desempeño](agents/hr/performance-reviewer/) | Recopilación de feedback, resúmenes de evaluaciones | Cuando es temporada de evaluaciones y necesitas feedback estructurado | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/performance-reviewer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 Selector de Currículos](agents/hr/resume-screener/) | Puntuación de currículos, clasificación de candidatos | Cuando estás filtrando grandes volúmenes de solicitantes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/resume-screener/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🚪 Entrevista de Salida](agents/hr/exit-interview/) | Entrevistas de salida estructuradas, análisis de retención | Cuando necesitas entender por qué los empleados se van | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/exit-interview/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎁 Asesor de Beneficios](agents/hr/benefits-advisor/) | Preguntas y respuestas sobre beneficios, guía de políticas | Cuando los empleados tienen preguntas sobre beneficios y políticas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/benefits-advisor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💰 Benchmark de Compensación](agents/hr/compensation-benchmarker/) | Datos salariales, análisis de tarifas de mercado | Cuando necesitas recomendaciones de compensación basadas en datos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/compensation-benchmarker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎨 Creatividad

Haciéndolo bello y atractivo.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|-------|-----------|-------------|---------|--------|
| [🎨 Diseñador de Marca](agents/creative/brand-designer/) | Guías de marca, paletas de colores | Cuando estás construyendo o renovando la identidad de tu marca | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/brand-designer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 Guionista de Video](agents/creative/video-scripter/) | Guiones de video, esquemas, listas de tomas | Cuando necesitas contenido de video pero odias escribir guiones | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/video-scripter/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎙️ Productor de Podcast](agents/creative/podcast-producer/) | Planificación de episodios, notas del programa | Cuando gestionas un podcast y necesitas ayuda con la planificación | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/podcast-producer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🧑‍💻 Investigador UX](agents/creative/ux-researcher/) | Encuestas a usuarios, análisis de feedback | Cuando necesitas insights de usuarios sin contratar un investigador | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ux-researcher/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [✏️ Redactor Publicitario](agents/creative/copywriter/) | Copia para anuncios, páginas de destino, secuencias de email | Cuando necesitas texto enfocado en conversiones rápido | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/copywriter/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🖼️ Diseñador de Miniaturas](agents/creative/thumbnail-designer/) | Conceptos de miniaturas para YouTube/redes sociales | Cuando necesitas ideas de miniaturas que detengan el scroll | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/thumbnail-designer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [📢 Redactor de Anuncios](agents/creative/ad-copywriter/) | Variantes de anuncios para Google, Meta, LinkedIn | Cuando necesitas texto para pruebas A/B en múltiples plataformas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ad-copywriter/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 Guionista de Storyboard](agents/creative/storyboard-writer/) | Storyboards visuales, listas de tomas | Cuando necesitas planificación de preproducción para contenido de video | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/storyboard-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |

### 🔒 Seguridad

Protegiendo lo que has construido.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🛡️ Escáner de Vulnerabilidades](agents/security/vuln-scanner/) | Escaneo de vulnerabilidades, priorización de correcciones | Cuando necesitas escaneo continuo de seguridad de tu stack | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/vuln-scanner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔐 Auditor de Accesos](agents/security/access-auditor/) | Revisión de permisos, detección de accesos excesivos | Cuando necesitas auditar quién tiene acceso a qué | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/access-auditor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [👁️ Monitor de Amenazas](agents/security/threat-monitor/) | Monitoreo de fuentes de amenazas, alertas relevantes | Cuando quieres advertencias tempranas sobre amenazas que apuntan a tu stack | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/threat-monitor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📓 Registrador de Incidentes](agents/security/incident-logger/) | Documentación de incidentes de seguridad | Cuando necesitas seguimiento estructurado de incidentes y análisis post-mortem | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/incident-logger/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔒 Endurecedor de Seguridad](agents/security/security-hardener/) | Auditoría SOUL.md, endurecimiento de gateway | Cuando quieres reforzar la configuración de tu agente y gateway | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/security-hardener/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🎣 Detector de Phishing](agents/security/phishing-detector/) | Análisis de phishing en emails, escaneo de URLs | Cuando tu equipo necesita detección automática de phishing | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/phishing-detector/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |

### 🛒 Comercio Electrónico

Vender más, gestionar menos.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🏷️ Listador de Productos](agents/ecommerce/product-lister/) | Optimización de listados, títulos SEO | Cuando necesitas listados optimizados de productos en varios mercados | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/product-lister/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [⭐ Respondedor de Reseñas](agents/ecommerce/review-responder/) | Respuesta automática a reseñas de clientes | Cuando las reseñas necesitan respuestas rápidas y consistentes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/review-responder/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=customer-support) |
| [📦 Rastreador de Inventario](agents/ecommerce/inventory-tracker/) | Monitoreo de stock, alertas de reorden | Cuando necesitas prevenir agotados y exceso de inventario | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/inventory-tracker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💲 Optimizador de Precios](agents/ecommerce/pricing-optimizer/) | Precios dinámicos, seguimiento de competencia | Cuando quieres precios que se ajusten a las condiciones del mercado | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/pricing-optimizer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🛒 Carrito Abandonado](agents/ecommerce/abandoned-cart/) | Recuperación de carritos, secuencias de recuperación | Cuando estás perdiendo ventas por carritos abandonados | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/abandoned-cart/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🔍 Investigador de Dropshipping](agents/ecommerce/dropshipping-researcher/) | Investigación continua de productos, análisis de proveedores | Cuando necesitas descubrimiento constante de productos para dropshipping | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/dropshipping-researcher/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |

> **¿Tienes una tienda Shopify o Amazon?** [Despliega un agente de Comercio Electrónico →](https://crewclaw.com/create-agent?role=customer-support)

### 📊 Datos

Convertir datos en bruto en decisiones.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🔄 Pipeline ETL](agents/data/etl-pipeline/) | Monitoreo de pipeline, alertas de fallos, reintentos | Cuando tus pipelines de datos necesitan monitoreo automatizado | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/etl-pipeline/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧹 Limpiador de Datos](agents/data/data-cleaner/) | Chequeos de calidad, deduplicación, normalización | Cuando tus datos están desordenados y necesitan limpieza automática | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/data-cleaner/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Generador de Reportes](agents/data/report-generator/) | Reportes automáticos desde múltiples fuentes | Cuando los interesados necesitan reportes regulares sin trabajo manual | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/report-generator/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🗃️ Asistente SQL](agents/data/sql-assistant/) | Ayuda con SQL, optimización de consultas, exploración de esquemas | Cuando necesitas un copiloto SQL para consultas complejas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/sql-assistant/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 Constructor de Paneles](agents/data/dashboard-builder/) | Paneles de métricas, mantenimiento | Cuando necesitas creación y actualización automática de paneles | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/dashboard-builder/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🚨 Detector de Anomalías](agents/data/anomaly-detector/) | Detección de anomalías en métricas, alertas estadísticas | Cuando necesitas alertas automáticas sobre patrones inusuales de datos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/anomaly-detector/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 Analizador de Encuestas](agents/data/survey-analyzer/) | Sentimiento, temas, desglose NPS | Cuando tienes datos de encuestas que necesitan análisis estructurado | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/survey-analyzer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |

> **¿Necesitas un agente Analista de Datos?** [Despliega con CrewClaw →](https://crewclaw.com/create-agent?role=data-analyst)

### ☁️ SaaS

Haciendo crecer tu producto, reteniendo a tus usuarios.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🚀 Flujo de Incorporación](agents/saas/onboarding-flow/) | Incorporación de usuarios, seguimiento de activación | Cuando los usuarios nuevos no alcanzan su momento aha | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/onboarding-flow/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=project-manager) |
| [💡 Solicitud de Funcionalidades](agents/saas/feature-request/) | Recolección de solicitudes, priorización, votación | Cuando las solicitudes de funciones están dispersas en canales | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/feature-request/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=project-manager) |
| [🔮 Prevención de Churn](agents/saas/churn-prevention/) | Prevención proactiva de churn, puntuación de salud | Cuando los usuarios se van y no sabes por qué | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/churn-prevention/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Análisis de Uso](agents/saas/usage-analytics/) | Uso del producto, seguimiento de adopción de funciones | Cuando necesitas entender cómo usan los usuarios tu producto | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/usage-analytics/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📝 Notas de Lanzamiento](agents/saas/release-notes/) | Notas de lanzamiento automáticas desde git y PRs | Cuando escribir notas de lanzamiento es una tarea que nadie quiere hacer | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/release-notes/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=technical-writer) |

### 🏡 Bienes Raíces

Encontrando ofertas, cerrando más rápido.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🏡 Explorador de Listados](agents/real-estate/listing-scout/) | Monitoreo de propiedades, alertas de bajadas de precio | Cuando quieres alertas instantáneas de nuevos listados y bajadas de precio | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/listing-scout/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 Analizador de Mercado](agents/real-estate/market-analyzer/) | Análisis de mercado, informes comparables | Cuando necesitas comparables de mercado y análisis de tendencias automatizados | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/market-analyzer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎯 Calificador de Leads](agents/real-estate/lead-qualifier/) | Puntuación de leads, secuencias de seguimiento | Cuando los leads llegan más rápido de lo que puedes calificarlos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/lead-qualifier/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎬 Video de Propiedad](agents/real-estate/property-video/) | Videos de listados, tours virtuales, staging | Cuando necesitas contenido de video de propiedades a gran escala | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/property-video/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [🏢 Bienes Raíces Comerciales](agents/real-estate/commercial-re/) | Análisis CRE, tasas de capitalización, seguimiento de ofertas | Cuando necesitas análisis de inversión en propiedades comerciales | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/commercial-re/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🧑‍💻 Freelance

Trabaja más inteligente, factura más.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [📝 Redactor de Propuestas](agents/freelance/proposal-writer/) | Generación de propuestas, cálculo de tarifas | Cuando pasas demasiado tiempo escribiendo propuestas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/proposal-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=content-writer) |
| [⏱️ Rastreador de Tiempo](agents/freelance/time-tracker/) | Seguimiento de tiempo, facturación, utilización | Cuando pierdes horas facturables por mal seguimiento del tiempo | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/time-tracker/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤝 Gestor de Clientes](agents/freelance/client-manager/) | CRM de clientes, seguimiento de contratos | Cuando manejas múltiples clientes y plazos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/client-manager/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=project-manager) |

> **¿Freelancer?** [Despliega un agente Asistente Personal →](https://crewclaw.com/create-agent?role=personal-assistant)

### 🤖 Moltbook `NUEVO`

Red social de agentes de IA — la presencia de tu agente en la capa social agente a agente.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🤖 Community Manager](agents/moltbook/community-manager/) | Publicar actualizaciones, interactuar, generar karma | Cuando quieres que tu agente mantenga una presencia social en Moltbook | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/community-manager/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [🔭 Scout](agents/moltbook/scout/) | Escaneo de feeds, monitoreo de palabras clave, resúmenes | Cuando quieres monitorear Moltbook en busca de discusiones y oportunidades relevantes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/scout/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [📈 Growth Agent](agents/moltbook/growth-agent/) | Crecimiento de seguidores, gestión de submolt, estrategia | Cuando quieres aumentar la influencia y base de seguidores de tu agente en Moltbook | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/growth-agent/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?integrations=moltbook) |

> **NUEVO: integración con Moltbook!** Tu agente ahora puede publicar, interactuar y crecer en la red social de agentes de IA. [Desplegar con Moltbook →](https://crewclaw.com/create-agent?integrations=moltbook)

### 📦 Cadena de Suministro `NUEVO`

Optimizando la logística y operaciones con proveedores.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🚚 Route Optimizer](agents/supply-chain/route-optimizer/) | Rutas de entrega, tráfico, capacidad | Cuando necesitas planificación optimizada de entregas | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/route-optimizer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 Inventory Forecaster](agents/supply-chain/inventory-forecaster/) | Predicción de demanda, puntos de reorden | Cuando necesitas evitar quiebres de stock con pronósticos inteligentes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/inventory-forecaster/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⭐ Vendor Evaluator](agents/supply-chain/vendor-evaluator/) | Evaluación de proveedores, seguimiento de calidad | Cuando necesitas selección y clasificación de proveedores basada en datos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/vendor-evaluator/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=data-analyst) |

### ✅ Cumplimiento `NUEVO`

Manteniéndose al día con las regulaciones.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|--------|--------------|-------------|---------|-----------|
| [🔒 GDPR Auditor](agents/compliance/gdpr-auditor/) | Análisis de brechas GDPR, planes de remediación | Cuando necesitas auditar sistemas para cumplimiento de privacidad de datos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/gdpr-auditor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 SOC2 Preparer](agents/compliance/soc2-preparer/) | Recolección de evidencia, preparación para auditoría | Cuando te preparas para la certificación SOC 2 | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/soc2-preparer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤖 AI Policy Writer](agents/compliance/ai-policy-writer/) | Gobernanza de IA, alineación con la Ley Europea de IA | Cuando necesitas políticas organizacionales para el uso de IA | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/ai-policy-writer/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [⚠️ Risk Assessor](agents/compliance/risk-assessor/) | Evaluación de riesgos, planificación de mitigación | Cuando necesitas evaluación estructurada de riesgos empresariales | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/risk-assessor/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎙️ Voz `NUEVO`

Agentes de voz y teléfono potenciado por IA.

| Agente | Especialidad | Cuándo usar | SOUL.md | Desplegar |
|-------|-----------|-------------|---------|--------|
| [📞 Recepcionista Telefónico](agents/voice/phone-receptionist/) | Manejo de llamadas, enrutamiento, citas | Cuando necesitas cobertura telefónica 24/7 sin personal | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/phone-receptionist/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=customer-support) |
| [📝 Transcriptor de Buzón de Voz](agents/voice/voicemail-transcriber/) | Transcripción, extracción de puntos de acción | Cuando los mensajes de voz necesitan procesamiento y enrutamiento rápido | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/voicemail-transcriber/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎤 Bot de Entrevistas](agents/voice/interview-bot/) | Entrevistas de selección, rúbricas de puntuación | Cuando necesitas selección estructurada de candidatos a gran escala | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/interview-bot/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🤝 Éxito del Cliente `NUEVO`

Manteniendo a los clientes felices y en crecimiento.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|-------|-----------|-------------|---------|--------|
| [📊 Seguimiento NPS](agents/customer-success/nps-followup/) | Recuperación de detractores, alcance personalizado | Cuando los detractores NPS necesitan atención inmediata | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/nps-followup/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=customer-support) |
| [🎯 Guía de Incorporación](agents/customer-success/onboarding-guide/) | Configuración de producto, consejos contextuales | Cuando los nuevos usuarios necesitan incorporación guiada al producto | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/onboarding-guide/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=customer-support) |

### 🔄 Automatización `NUEVO`

Configúralo y olvídalo. Agentes que trabajan mientras duermes.

| Agente | Especialidad | Cuándo Usar | SOUL.md | Desplegar |
|-------|-----------|-------------|---------|--------|
| [🤝 Agente de Negociación](agents/automation/negotiation-agent/) | Negociación de facturas, cierre de acuerdos | Cuando quieres que la IA negocie tus facturas y contratos | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/negotiation-agent/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 Solicitante de Empleo](agents/automation/job-applicant/) | Solicitudes masivas, personalización de CV | Cuando quieres postular a más de 500 empleos mientras duermes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/job-applicant/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [☀️ Informe Matutino](agents/automation/morning-briefing/) | Correo, calendario, resumen diario de noticias | Cuando quieres un informe diario personalizado listo a las 7AM | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/morning-briefing/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ Raspador de Vuelos](agents/automation/flight-scraper/) | Ofertas de vuelos, alertas de bajada de precios | Cuando quieres encontrar los vuelos más baratos automáticamente | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/flight-scraper/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌙 Programador Nocturno](agents/automation/overnight-coder/) | Codificación autónoma, PRs por la mañana | Cuando quieres que el código se escriba mientras duermes | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/overnight-coder/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💬 Negocios en Discord](agents/automation/discord-business/) | Operaciones comerciales completas vía Discord | Cuando manejas tu negocio a través de Discord | [Ver](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/discord-business/SOUL.md) | [Desplegar →](https://crewclaw.com/create-agent?role=personal-assistant) |

---

## Casos de Uso

**132 casos de uso reales verificados** — lo que la gente realmente está construyendo con agentes OpenClaw.

Desde flujos de trabajo para desarrolladores y automatización DevOps hasta control inteligente del hogar, comercio de criptomonedas, robótica y agentes que modifican su propio código.

**[Explorar los 132 casos de uso →](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/USE-CASES.md)**

Categorías principales: Productividad Personal (14) · Operaciones Comerciales (11) · Flujos de Trabajo para Desarrolladores (10) · Creación de Contenido (10) · Herramientas del Ecosistema (10)

---

## Inicio rápido

Pon en marcha un agente funcional en menos de 5 minutos sin configuración:

```bash
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
cp .env.example .env          # add your API key + Telegram token
cp ../agents/marketing/echo/SOUL.md ./SOUL.md
npm install && node bot.js    # your agent is live on Telegram
```

Consulta la [Guía Rápida](quickstart/) completa con soporte para Docker.

O salta la configuración por completo: **[Despliega con CrewClaw →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=quickstart)** — obtén un paquete de despliegue completo (Dockerfile + docker-compose + bot + README) para cualquier rol.

---

## ¿Por qué OpenClaw?

Cómo se compara OpenClaw con otros frameworks de agentes de IA:

### vs Frameworks de Agentes de IA

| Característica | OpenClaw | AutoGPT | CrewAI | LangChain | MetaGPT |
|----------------|----------|---------|--------|-----------|---------|
| Configuración primero (SOUL.md) | ✅ | ❌ | ❌ | ❌ | ❌ |
| No requiere código | ✅ | ❌ | ❌ | ❌ | ❌ |
| Telegram/Slack/Discord integrado | ✅ | ❌ | ❌ | ❌ | ❌ |
| Orquestación multi-agente | ✅ | ❌ | ✅ | ✅ | ✅ |
| MCP (Protocolo de Contexto de Modelo) | ✅ | ❌ | ❌ | ❌ | ❌ |
| Autoalojado / local | ✅ | ✅ | ✅ | ✅ | ✅ |
| Monitorización de latido | ✅ | ❌ | ❌ | ❌ | ❌ |
| Funciona con Ollama (gratuito) | ✅ | ✅ | ✅ | ✅ | ❌ |
| Plantillas listas para producción | **187** | 0 | 5 | 0 | 3 |
| Despliegue con un comando | ✅ | ❌ | ❌ | ❌ | ❌ |
| Comunicación agente a agente | ✅ | ❌ | ✅ | ✅ | ✅ |
| Tiempo de configuración | ~5 min | ~30 min | ~20 min | ~45 min | ~30 min |

### vs Alternativas Livianas

| Característica | OpenClaw | ZeroClaw | PicoClaw | NanoClaw | memU |
|----------------|----------|----------|----------|----------|------|
| Lenguaje | Node.js | Rust | Go | Python | Python |
| Tamaño binario | ~150MB | ~5MB | ~8MB | ~4K LOC | ~50MB |
| RAM mínima | 512MB | 32MB | 64MB | 128MB | 256MB |
| Multi-agente | ✅ AGENTS.md | ❌ | ❌ | ❌ | ❌ |
| Habilidades/plugins | ✅ 13K+ | ❌ | ❌ | ❌ | ❌ |
| Canales de mensajería | ✅ 25+ | 3 | 2 | 1 | 5 |
| Memoria a largo plazo | Básica | ❌ | ❌ | ❌ | ✅ Grafo de conocimiento |
| Soporte MCP | ✅ | ❌ | ❌ | ❌ | ❌ |
| Plantillas de producción | **187** | 0 | 0 | 0 | 0 |
| Lo mejor para | Equipos completos de agentes | Edge/IoT | Bots de propósito único | Configuraciones mínimas | Asistentes personales |

### vs Soluciones alojadas/empresariales

| Característica | OpenClaw | Claude Code Channels | NemoClaw (NVIDIA) | OpenFang |
|---------------|----------|---------------------|-------------------|----------|
| Código abierto | ✅ MIT | ❌ Propietario | ✅ Apache 2.0 | ✅ MIT |
| Autoalojado | ✅ | ❌ Solo en la nube | ✅ | ✅ |
| Configuración | Archivo de configuración | Clave API | Docker + configuración | Binario Rust |
| Multiagente | ✅ | ❌ | ✅ vía OpenClaw | ✅ 7 "Manos" |
| Modelo de seguridad | Gestionado por usuario | Gestionado por Anthropic | Sandbox de kernel | Aislamiento de procesos |
| Mensajería | ✅ 25+ canales | Telegram, Discord | Vía OpenClaw | 3 canales |
| Costo | Gratis + tarifas de API | Suscripción Claude | Gratis + tarifas de API | Gratis + tarifas de API |
| Lo mejor para | Control total | Usuarios no técnicos | Seguridad empresarial | Usuarios avanzados de Agent OS |

**Resumen:** OpenClaw es primero configuración. Escribe un SOUL.md, ejecuta un comando, tu agente está en vivo. Sin Python, sin cadenas, sin gráficos. Las alternativas ligeras intercambian características por menor tamaño. Las soluciones empresariales añaden capas de seguridad.

---

## Despliegue rápido con CrewClaw

Elige una plantilla, personalízala y obtén un paquete de despliegue completo con [CrewClaw](https://crewclaw.com/create-agent):

```
Your CrewClaw package includes:
├── agents/your-agent/SOUL.md    # Agent configuration
├── Dockerfile                    # Container setup
├── docker-compose.yml            # One-command deploy
├── bot.js                        # Telegram bot (grammy)
├── .env.example                  # API keys template
├── package.json                  # Dependencies
└── README.md                     # Setup instructions
```

Elige cualquiera de las 187 plantillas anteriores o crea un agente personalizado desde cero.

**[Crea tu agente →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta)**

---

## Servidores MCP

Servidores de Protocolo de Contexto de Modelo para ampliar las capacidades del agente.

### Oficial

| Servidor | Descripción | Instalación |
|----------|-------------|-------------|
| [@anthropic/mcp-server-fetch](https://github.com/anthropics/mcp-server-fetch) | Obtención y navegación web | `npx -y @anthropic/mcp-server-fetch` |
| [@anthropic/mcp-server-filesystem](https://github.com/anthropics/mcp-server-filesystem) | Acceso al sistema de archivos | `npx -y @anthropic/mcp-server-filesystem` |

### Comunidad

| Servidor | Descripción |
|----------|-------------|
| mcp-notion | Integración con Notion |
| mcp-google-calendar | Acceso a Google Calendar |
| mcp-github | Operaciones en GitHub |
| mcp-slack | Mensajería Slack |
| mcp-postgres | Consultas PostgreSQL |
| mcp-stripe | Pagos con Stripe |
| mcp-shopify | Gestión de tiendas Shopify |
| mcp-twitter | Publicaciones en Twitter/X |
| mcp-discord | Integración de bots Discord |
| mcp-linear | Seguimiento de incidencias en Linear |

---

## Integraciones

Conecta tus agentes con servicios externos.

### Mensajería

- **Telegram** - Chatea con agentes vía Telegram (integrado en OpenClaw)
- **Slack** - Conexión a espacio de trabajo Slack (integrado en OpenClaw)
- **Discord** - Bot para servidor Discord (integrado en OpenClaw)
- **Email** - Canal de correo electrónico (integrado en OpenClaw)

### Automatización

- **n8n** - Nodos de integración n8n
- **GitHub Actions** - Integración CI/CD
- **Cron / pm2 / systemd** - Programación de agentes siempre activos

---

## Herramientas

Utilidades y ayudantes para trabajar con OpenClaw.

| Herramienta | Descripción |
|-------------|-------------|
| [openclaw CLI](https://crewclaw.com/blog/openclaw-cli-commands-reference) | CLI oficial - referencia completa de comandos |
| [agents.json](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json) | Índice legible por máquina de las 187 plantillas de agentes |
| agent-validator | Valida la sintaxis de SOUL.md |
| mcp-tester | Prueba conexiones al servidor MCP |

---

## Seguridad

Los agentes OpenClaw se ejecutan en tu hardware con acceso a tus archivos y servicios. Sigue estas mejores prácticas:

| Riesgo | Mitigación |
|--------|------------|
| Pasarela expuesta | Vincular solo a `localhost`. Usa túneles SSH para acceso remoto. Nunca expongas el puerto 18789 a internet. |
| Fugas de claves API | Guarda las claves en archivos `.env`. Añade `.env` a `.gitignore`. Rota las claves regularmente. |
| Habilidades maliciosas | Instala solo habilidades de editores verificados en ClawHub. Revisa SKILL.md antes de instalar. |
| Inyección de prompt | Establece reglas estrictas `## Rules` en SOUL.md. Limita el acceso al sistema de archivos. Deshabilita comandos shell para entradas no confiables. |
| Agentes desatendidos | Usa HEARTBEAT.md con límites de alcance. Establece topes de presupuesto. Habilita registro para todas las acciones. |

**Recursos recientes de seguridad:**
- [Guía de Seguridad OpenClaw](https://crewclaw.com/blog/openclaw-security-guide) - Endurecimiento de tu configuración
- [Riesgos de Seguridad OpenClaw 2026](https://crewclaw.com/blog/openclaw-security-risks-2026) - Vulnerabilidades conocidas y soluciones
- [NemoClaw (NVIDIA GTC 2026)](https://crewclaw.com/blog/nvidia-gtc-2026-openclaw-nemoclaw) - Envoltorio de seguridad empresarial
- [Documentación Oficial de Seguridad](https://docs.openclaw.ai/gateway/security) - Configuración de seguridad del gateway

---

## Tutoriales y Guías

Aprende a crear y desplegar agentes.

### Primeros Pasos

- [Cómo Usar OpenClaw: Guía para Principiantes](https://crewclaw.com/blog/how-to-use-openclaw-guide) - Instalación hasta el primer agente en 5 minutos
- [¿Qué es OpenClaw?](https://crewclaw.com/blog/what-is-openclaw-ai-agent-framework) - Guía completa del framework
- [Crea Tu Primer Agente](https://crewclaw.com/blog/how-to-create-ai-agent-openclaw) - No se requiere código
- [Guía de Configuración OpenClaw 2026](https://crewclaw.com/blog/openclaw-setup-guide-2026) - Instalar, configurar, ejecutar
- [Requisitos del Sistema](https://crewclaw.com/blog/openclaw-system-requirements-2026) - Hardware, GPU, VPS, especificaciones Docker
- [Los Mejores Modelos para OpenClaw](https://crewclaw.com/blog/best-models-for-openclaw-2026) - 10 LLM comparados en costo, velocidad, llamadas a herramientas
- [Plantillas SOUL.md](https://crewclaw.com/blog/soul-md-examples-templates) - 10 ejemplos listos para usar

### Multi-Agente y Orquestación

- [Guía de Configuración Multi-Agente](https://crewclaw.com/blog/openclaw-multi-agent-setup-guide) - Ejecuta múltiples agentes juntos
- [Comunicación Agente a Agente](https://crewclaw.com/blog/openclaw-agent-to-agent-communication) - Cómo colaboran los agentes
- [Construye un Equipo de IA](https://crewclaw.com/blog/build-ai-team-workflows) - Flujos de trabajo que funcionan autónomamente

### Casos de Uso

- [¿Qué Puede Hacer OpenClaw?](https://crewclaw.com/blog/what-can-openclaw-do) - 12 casos reales con configuraciones
- [OpenClaw para Negocios](https://crewclaw.com/blog/openclaw-for-business-use-cases) - 25 casos en 8 categorías
- [Guía de Creación de Contenido](https://crewclaw.com/blog/openclaw-content-creation-guide) - Blog, redes sociales, automatización de video
- [Guía de Generación de Leads](https://crewclaw.com/blog/openclaw-lead-generation-guide) - Reddit, Twitter, canal de ventas
- [Automatización de Email](https://crewclaw.com/blog/openclaw-email-automation-guide) - Clasificación de bandeja, respuestas automáticas, seguimientos
- [Integración con Home Assistant](https://crewclaw.com/blog/openclaw-home-assistant-integration) - Control de hogar inteligente

### Integraciones y Automatización

- [Integración con Slack y Telegram](https://crewclaw.com/blog/openclaw-slack-telegram-integration) - Conecta a canales de mensajería

- [Ejecutar con Ollama](https://crewclaw.com/blog/openclaw-ollama-local-agents) - Agentes de IA locales gratuitos  
- [Guía de Automatización](https://crewclaw.com/blog/openclaw-automation-guide) - Construye flujos de trabajo 24/7  
- [Referencia de Comandos CLI](https://crewclaw.com/blog/openclaw-cli-commands-reference) - Hoja de trucos completa  
- [Integración con Google Workspace](https://crewclaw.com/blog/openclaw-google-workspace-integration) - Gmail, Docs, Drive, Calendario  

### Comparaciones  

- [OpenClaw vs CrewAI](https://crewclaw.com/blog/openclaw-vs-crewai) - ¿Cuál es mejor?  
- [OpenClaw vs AutoGen](https://crewclaw.com/blog/openclaw-vs-autogen) - Marco multi-agente de Microsoft  
- [OpenClaw vs LangChain](https://crewclaw.com/blog/openclaw-vs-langchain) - Comparación de frameworks  
- [OpenClaw vs AutoGPT](https://crewclaw.com/blog/openclaw-vs-autogpt) - Diferencias clave  
- [OpenClaw vs ZeroClaw](https://crewclaw.com/blog/openclaw-vs-zeroclaw) - Alternativa ligera en Rust  
- [OpenClaw vs OpenFang](https://crewclaw.com/blog/openclaw-vs-openfang) - Sistema operativo de agentes con 7 manos  
- [OpenClaw vs memU](https://crewclaw.com/blog/openclaw-vs-memu) - IA con memoria a largo plazo  
- [PicoClaw vs OpenClaw](https://crewclaw.com/blog/picoclaw-vs-openclaw) - Alternativa ultra-minimalista  
- [Guía del Repositorio OpenClaw en GitHub](https://crewclaw.com/blog/openclaw-ai-agent-github-guide) - Explicación del repositorio con 250K estrellas  

---  

## Envía Tu Agente  

¿Has creado un agente personalizado? Ponlo aquí listado y en [crewclaw.com/agents](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=submit).  

Cada agente es un sistema operativo completo, no solo un prompt:

```
agents/[category]/[your-agent]/
├── SOUL.md          ← Identity & personality (required)
├── README.md        ← Description & use cases (required)
├── AGENTS.md        ← Operating rules (optional)
├── HEARTBEAT.md     ← Wake-up checklist (optional)
└── WORKING.md       ← Starting task (optional)
```

**Vía PR (recomendado):**

1. Haz un fork de este repositorio  
2. Añade tu carpeta de agente con SOUL.md + README.md (mínimo)  
3. Añade una entrada en `agents.json`  
4. Abre un Pull Request  

**Vía Issue (sin configuración):**

[Envía tu agente →](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md) — pega tus archivos, nosotros lo añadiremos.

Guía completa: [CONTRIBUTING.md](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/CONTRIBUTING.md)

---

## Comunidad

¿Quieres solicitar un agente en su lugar? Usa la plantilla [Solicitud de Agente](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-request.md).

---

## Proyectos Relacionados

- [🦞 CrewClaw](https://crewclaw.com) - Despliega agentes de IA sin configuración. Sin Docker, sin terminal.  
- [OpenClaw](https://github.com/openclaw) - Repositorio oficial de OpenClaw  
- [Anthropic MCP](https://github.com/anthropics/mcp) - Protocolo de Contexto de Modelo  

---

## Historial de Estrellas

[![Gráfico de Historial de Estrellas](https://api.star-history.com/svg?repos=mergisi/awesome-openclaw-agents&type=Date)](https://star-history.com/#mergisi/awesome-openclaw-agents&Date)

---

## Licencia

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)

En la medida permitida por la ley, los colaboradores han renunciado a todos los derechos de autor y derechos conexos sobre esta obra.

---

<p align="center">
  Hecho con 🦞 por la Comunidad OpenClaw
  <br/>
  <a href="https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta">Despliega tu agente con CrewClaw →</a> · <a href="https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md">Envía el tuyo →</a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---