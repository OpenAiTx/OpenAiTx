# 🛡️ Paquete Inicial para Ingeniería de Detección

![Discord](https://img.shields.io/discord/1332993005359202345?logo=discord)

> **Una lista con criterio de recursos esenciales para aspirantes a Ingenieros de Detección.**

El objetivo de este paquete inicial es proporcionar una selección curada de recursos para ayudarte a comenzar en la ingeniería de detección sin sentirte abrumado. Esta lista se basa en la experiencia personal con varias tecnologías de detección. ¡Espero que sea útil! 🚀

---

### 💬 **Únete al Discord**

[Conéctate con otros para discutir todo sobre detección de amenazas e ingeniería de seguridad.](https://discord.gg/HAVyDtUunu)

---

## 📖 Contenido <!-- omit in toc -->

<!-- TOC -->

- [🔍 Entendiendo las Técnicas de Atacantes](#-entendiendo-las-técnicas-de-atacantes)
- [📜 Conociendo las Reglas de Detección](#-conociendo-las-reglas-de-detección)
- [🛠️ Poniéndolo a Prueba Tú Mismo](#-poniéndolo-a-prueba-tú-mismo)
  - [🔒 Detección en Endpoints](#-detección-en-endpoints)
  - [🌐 Detección en Red](#-detección-en-red)
  - [📂 Detección de Contenido de Archivos](#-detección-de-contenido-de-archivos)
  - [📊 SIEM (Gestión de Información y Eventos de Seguridad)](#-siem-gestión-de-información-y-eventos-de-seguridad)
  - [⚙️ SOAR (Orquestación, Automatización y Respuesta de Seguridad)](#-soar-orquestación-automatización-y-respuesta-de-seguridad)
  - [🎭 Emulación de Adversarios](#-emulación-de-adversarios)
- [📚 Conceptos Útiles](#-conceptos-útiles)
- [🧪 Laboratorios y Entrenamiento](#-laboratorios-y-entrenamiento)
- [📖 Lecturas Adicionales y Proyectos Interesantes](#-lecturas-adicionales-y-proyectos-interesantes)
- [🌟 Listas Asombrosas](#-listas-asombrosas)
<!-- /TOC -->

---

## 🔍 Entendiendo las Técnicas de Atacantes

> **Ve cómo los atacantes logran sus objetivos.**
- [MITRE ATT&CK](https://attack.mitre.org/) - La base de conocimiento número 1 de tácticas y técnicas de adversarios.  
- [Top 10 ATT&CK Techniques](https://top-attack-techniques.mitre-engenuity.org/) - Una página personalizable para mostrar las técnicas ATT&CK más comunes.  
- [Hacking the Cloud](https://hackingthe.cloud/) - Una colección de recursos para entender técnicas de ataque enfocadas en la nube.  
- [The DFIR Report](https://thedfirreport.com/) - Incidentes del mundo real analizados y descritos con la mentalidad de un defensor. Un favorito personal.  

---

## 📜 Conociendo las Reglas de Detección

> **Repositorios de ejemplo que muestran cómo se estructuran y aplican las detecciones.**

- [Sigma](https://github.com/SigmaHQ/sigma) - El formato genérico de firmas de detección.  
- [Splunk Detection Rules](https://research.splunk.com/detections/) - Una colección de reglas de detección para Splunk.  
- [Elastic Detection Rules](https://github.com/elastic/detection-rules/tree/main/rules) - Una colección de reglas de detección para Elastic.  
- [Detection Studio](https://detection.studio/) - Convierte reglas Sigma a otras sintaxis de reglas de detección.  

---

## 🛠️ Pruébalo Tú Mismo

> **Herramientas para experimentar que son de código abierto o tienen un elemento de uso gratuito.**

#### 🔒 Detección en Endpoints

- [Aurora](https://www.nextron-systems.com/aurora/) - Un agente que puede ejecutar reglas Sigma. Carga tus reglas Sigma y crea alertas a partir de tus registros de eventos.  
- [Velociraptor](https://github.com/Velocidex/velociraptor) - Una herramienta de análisis forense digital y respuesta a incidentes que mejora la visibilidad en tus endpoints.  
- [Falco](https://github.com/falcosecurity/falco) - Una herramienta de seguridad en tiempo de ejecución nativa para la nube que detecta amenazas dentro de contenedores.  
- [Sysmon](https://learn.microsoft.com/en-us/sysinternals/downloads/sysmon) - Un monitor simple del sistema Windows.  
- [Osquery](https://www.osquery.io/) - Un framework de instrumentación del sistema operativo.  

#### 🌐 Detección en Red

- [Suricata](https://suricata.io/) - Reglas de detección diseñadas para interrogar el tráfico de red en busca de actividad sospechosa.  

#### 📂 Detección de Contenido de Archivos

- [YARA](https://github.com/virustotal/yara) - Reglas de detección para identificar y clasificar muestras de malware.  

#### 📊 SIEM (Gestión de Información y Eventos de Seguridad)

- [Elastic Stack (ELK)](https://www.elastic.co/elastic-stack) - Un conjunto de herramientas para búsqueda, registro y análisis.
- [Wazuh](https://wazuh.com/) - Una plataforma de monitoreo de seguridad de código abierto.

#### ⚙️ SOAR (Orquestación, Automatización y Respuesta de Seguridad)

- [Tines](https://www.tines.com/) - Una plataforma de automatización sin código para equipos de seguridad. Ideal para automatizar cualquier cosa, rápidamente. Tiene un nivel gratuito.

#### 🎭 Emulación de Adversarios

- [Adversary Emulation Library](https://github.com/center-for-threat-informed-defense/adversary_emulation_library) - Una biblioteca de planes de emulación de adversarios.
- [MITRE Caldera](https://github.com/mitre/caldera) - Una plataforma automatizada de emulación de adversarios.
- [Stratus Red Team](https://github.com/DataDog/stratus-red-team) - Una herramienta para emulación de adversarios en la nube.
- [Atomic Red Team](https://github.com/redcanaryco/atomic-red-team) - Una biblioteca de pruebas simples de emulación de adversarios.
- [TTPForge](https://github.com/facebookincubator/TTPForge) - Una herramienta para crear y gestionar TTPs.

---

## 📚 Conceptos Útiles

- [Detection Engineering Behavior Maturity Model](https://www.elastic.co/security-labs/elastic-releases-debmm) - un enfoque estructurado para que los equipos de seguridad maduren consistentemente sus procesos y comportamientos desde Elastic.
- [Alerting Detection Strategy (ADS) Framework](https://github.com/palantir/alerting-detection-strategy-framework/blob/master/ADS-Framework.md) - Un marco sencillo para construir estrategias de detección de Palantir.
- [Summiting the Pyramid](https://center-for-threat-informed-defense.github.io/summiting-the-pyramid/?utm_source=ctidio&utm_medium=shortlink) - Basado en la 'pirámide del dolor', este trabajo define lo que realmente significa tener una detección robusta.
- [Capability Abstraction](https://posts.specterops.io/capability-abstraction-fbeaeeb26384) - Uno de mis artículos favoritos - 'Capability Abstraction' de SpecterOps. Explora conceptos similares al proyecto 'summiting the pyramid' mencionado anteriormente.

---

## 🧪 Laboratorios y Entrenamiento

- [Blue Team Labs Online](https://blueteamlabs.online/) - Una plataforma para entrenamiento práctico de equipos azules.
- [ACE Responder](https://www.aceresponder.com/) - Una plataforma realista e inmersiva para defensores cibernéticos existentes y nuevos por igual.

---

## 📖 Lecturas Adicionales y Proyectos Interesantes

> **Una selección cuidada de materiales que me han inspirado.**

- [Detections.ai](https://detections.ai/) - Una plataforma impulsada por IA y comunidad para compartir y mejorar reglas de detección. Usa el código de invitación `StarterPack`.
- [ACEResponder](https://x.com/ACEResponder) - Una cuenta de X que comparte técnicas de atacantes de forma visual.

- [Detect FYI](https://detect.fyi/) - Una publicación de Medium centrada exclusivamente en la ingeniería de detección.
- [Detection Engineering Weekly](https://www.detectionengineering.net/) - Un boletín semanal sobre ingeniería de detección.
- [EDR Telemetry](https://www.edr-telemetry.com/) - Un recurso que compara herramientas EDR populares entre sí.
- [MITRE ATLAS](https://atlas.mitre.org/matrices/ATLAS) - ATT&CK, pero para IA.
- [Prioritizing Detection Engineering](https://medium.com/starting-up-security/prioritizing-detection-engineering-b60b46d55051) - Un artículo bien escrito de Ryan McGeehan sobre cómo pensar en priorizar tus esfuerzos de ingeniería de detección.
- [How Google Does It](https://cloud.google.com/transform/how-google-does-it-modernizing-threat-detection) - Cómo Google realiza la detección de amenazas a gran escala.
- Blogs destacados de proveedores de seguridad para defensores:
  - [SpecterOps Blog](https://posts.specterops.io/)
  - [Google Threat Analysis Group Blog](https://blog.google/threat-analysis-group/)
  - [CrowdStrike Counter Adversary Operations Blog](https://www.crowdstrike.com/en-us/blog/category.counter-adversary-operations/)
  - [Palo Alto Networks Unit 42 Blog](https://unit42.paloaltonetworks.com/unit-42-all-articles/)
  - [Recorded Future Blog](https://www.recordedfuture.com/blog)
  - [SEKOIA Threat Research Blog](https://blog.sekoia.io/category/threat-research/)
  - [Wiz Research Blog](https://www.wiz.io/blog/tag/research)

---

## 🌟 Listas Geniales

> **Si deseas más recursos, consulta estas listas geniales.**

- [Awesome Kubernetes Threat Detection](https://github.com/jatrost/awesome-kubernetes-threat-detection) - Una lista de recursos para la detección de amenazas en Kubernetes.
- [Awesome Threat Intel Blogs](https://github.com/signalscorps/awesome-threat-intel-blogs) - Una lista seleccionada de blogs y publicaciones de inteligencia de amenazas.
- [Awesome Detection Engineering](https://github.com/infosecB/awesome-detection-engineering) - Una lista seleccionada de recursos de ingeniería de detección.
- [Awesome Threat Detection](https://github.com/0x4D31/awesome-threat-detection) - Una colección de recursos de detección de amenazas.
- [Awesome Detection Engineer](https://github.com/st0pp3r/awesome-detection-engineer) - Una lista de recursos para ingenieros de detección.
- [Blue Team Tools](https://github.com/A-poc/BlueTeam-Tools) - Una colección de herramientas para equipos azules.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---