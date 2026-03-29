<h1 align="center"><img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="" width="64" style="vertical-align: middle;">&nbsp; CLI-Anything: Haciendo que TODO el software sea nativo para agentes</h1>

<p align="center">
  <strong>El software de hoy sirve a humanos👨‍💻. Los usuarios del mañana serán agentes🤖.<br>
CLI-Anything: Cerrando la brecha entre los agentes de IA y el software del mundo</strong><br>
</p>

**🌐 [CLI-Hub](https://hkuds.github.io/CLI-Anything/)**: Explora todos los CLIs creados por la comunidad e instala con un solo comando en el **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)**. ¿Quieres añadir el tuyo? [Abre un PR](https://github.com/HKUDS/CLI-Anything/blob/main/CONTRIBUTING.md) — el hub se actualiza al instante.

<p align="center">
  <a href="#-quick-start"><img src="https://img.shields.io/badge/Quick_Start-5_min-blue?style=for-the-badge" alt="Quick Start"></a>
  <a href="https://hkuds.github.io/CLI-Anything/"><img src="https://img.shields.io/badge/CLI_Hub-Browse_%26_Install-ff69b4?style=for-the-badge" alt="CLI Hub"></a>
  <a href="#-demonstrations"><img src="https://img.shields.io/badge/Demos-16_Apps-green?style=for-the-badge" alt="Demos"></a>
  <a href="#-test-results"><img src="https://img.shields.io/badge/Tests-1%2C839_Passing-brightgreen?style=for-the-badge" alt="Tests"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" alt="License"></a>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/python-≥3.10-blue?logo=python&logoColor=white" alt="Python">
  <img src="https://img.shields.io/badge/click-≥8.0-green" alt="Click">
  <img src="https://img.shields.io/badge/pytest-100%25_pass-brightgreen" alt="Pytest">
  <img src="https://img.shields.io/badge/coverage-unit_%2B_e2e-orange" alt="Coverage">
  <img src="https://img.shields.io/badge/output-JSON_%2B_Human-blueviolet" alt="Output">
  <a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/Feishu-Group-E9DBFC?style=flat&logo=feishu&logoColor=white" alt="Feishu"></a>
<a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/WeChat-Group-C5EAB4?style=flat&logo=wechat&logoColor=white" alt="WeChat"></a>
</p>

**Un solo comando**: Prepara cualquier software para agentes como OpenClaw, nanobot, Cursor, Claude Code, etc.&nbsp;&nbsp;[**Documentación en chino**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_CN.md) | [**Documentación en japonés**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_JA.md)

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/cli-typing.gif" alt="Demostración de escritura en CLI-Anything" width="800">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/teaser.png" alt="Vista previa de CLI-Anything" width="800">
</p>

---

## 📰 Noticias
> ¡Gracias a todos los esfuerzos invaluables de la comunidad! Más actualizaciones continuamente en camino todos los días..

- **2026-03-23** 🤖 Lanzada la **meta-habilidad CLI-Hub** — los agentes ahora pueden descubrir e instalar CLIs de forma autónoma a través de [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md). El catálogo se actualiza automáticamente desde `registry.json` mediante GitHub Actions, haciendo que todo el mercado sea nativo para agentes.

- **2026-03-22** 🎵 **MuseScore CLI** fusionado con transposición, exportación y gestión de instrumentos. Las contribuciones de la comunidad continúan expandiendo la cobertura del dominio.

- **2026-03-21** 🔧 Mejoras en infraestructura — refinados arneses de prueba y documentación a través de múltiples CLIs. Compatibilidad mejorada con Windows para varios backends.

- **2026-03-20** 🌐 Añadido CLI de **Novita AI** para acceso a API compatible con OpenAI. Mejoras en metadatos del registro para mejor descubrimiento en el hub.

- **2026-03-19** 📦 Refinamientos en la estructura del paquete a través de los arneses. Mejorada la generación de SKILL.md con mejor documentación de comandos.

- **2026-03-18** 🧪 Expansión de la cobertura de pruebas — escenarios E2E adicionales y validación de casos límite en múltiples CLIs.

- **2026-03-17** 🌐 Lanzado el **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)** — un registro central donde puedes buscar, explorar e instalar cualquier CLI con un solo comando `pip`. Los colaboradores pueden agregar nuevos CLIs o actualizar los existentes simplemente abriendo un PR con una entrada en `registry.json`. El hub se actualiza automáticamente al hacer merge.

<details>
<summary>Noticias anteriores</summary>

- **2026-03-16** 🤖 Añadida la **generación SKILL.md** (Fase 6.5) — cada CLI generado ahora incluye una definición de habilidad AI-descubrible dentro del paquete Python. ReplSkin detecta automáticamente el archivo de habilidad después de `pip install`, y el banner REPL muestra la ruta absoluta para agentes. Incluye `skill_generator.py`, plantilla Jinja2, `package_data` en todos los archivos setup.py, y 51 nuevas pruebas.

- **2026-03-15** 🐾 ¡Soporte para **OpenClaw** desde la comunidad! Fusionada la protección Windows `cygpath` para asegurar que CLI-Anything funcione de forma confiable en entornos bash de Windows. Las contribuciones comunitarias continúan fortaleciendo el soporte multiplataforma.

- **2026-03-14** 🔒 Corregida una vulnerabilidad de inyección de ruta en GIMP Script-Fu y añadida traducción del README al japonés. Requisitos de versión de OpenCode documentados junto con varias mejoras de compatibilidad en Windows.

- **2026-03-13** 🔌 Plugin **Qodercli** oficialmente fusionado como contribución comunitaria con scripts de instalación dedicados. La habilidad Codex ganó un script de instalación para Windows, y URLs de marcador de posición fueron limpiadas en todo el proyecto.

- **2026-03-12** 📦 Integración de la **habilidad Codex** implementada, llevando CLI-Anything a otra plataforma de codificación AI. También se introdujo soporte para Qodercli, y la documentación se actualizó con limitaciones y etiquetas experimentales.

- **2026-03-11** 📞 Añadido el arnés de videoconferencia **Zoom** como la 11ª aplicación soportada. Se lanzaron múltiples correcciones comunitarias para guardado automático en Shotcut, backend de LibreOffice en Windows/macOS, y soporte para OpenCode.

</details>

---

## 🤔 ¿Por qué CLI?

CLI es la interfaz universal tanto para humanos como para agentes AI:


• **Estructurado y Componible** - Los comandos de texto coinciden con el formato LLM y se encadenan para flujos de trabajo complejos

• **Ligero y Universal** - Sobrecarga mínima, funciona en todos los sistemas sin dependencias

• **Auto-descriptivo** - Las banderas --help proporcionan documentación automática que los agentes pueden descubrir

• **Éxito Comprobado** - Claude Code ejecuta miles de flujos de trabajo reales a través de CLI diariamente

• **Diseño Orientado a Agentes** - La salida JSON estructurada elimina la complejidad de análisis

• **Determinista y Fiable** - Resultados consistentes que permiten un comportamiento predecible del agente

## 🚀 Inicio Rápido

### Requisitos Previos

- **Python 3.10+**
- Software objetivo instalado (por ejemplo, GIMP, Blender, LibreOffice o su propia aplicación)
- Un agente de codificación AI compatible: [Claude Code](#-claude-code) | [OpenClaw](#-openclaw) | [OpenCode](#-opencode) | [Codex](#-codex) | [Qodercli](#-qodercli) | [GitHub Copilot CLI](#-github-copilot-cli) | [Más Plataformas](#-more-platforms-coming-soon)

### Elija Su Plataforma

<details open>
<summary><h4 id="-claude-code">⚡ Claude Code</h4></summary>

**Paso 1: Añadir el Marketplace**

CLI-Anything se distribuye como un plugin marketplace de Claude Code alojado en GitHub.

```bash
# Add the CLI-Anything marketplace
/plugin marketplace add HKUDS/CLI-Anything
```

**Paso 2: Instalar el Complemento**

```bash
# Install the cli-anything plugin from the marketplace
/plugin install cli-anything
```

Eso es todo. El complemento ya está disponible en tu sesión de Claude Code.

> **Nota para usuarios de Windows:** Claude Code ejecuta comandos de shell mediante `bash`. En Windows, instala Git para Windows (incluye `bash` y
`cygpath`) o usa WSL; de lo contrario, los comandos pueden fallar con `cygpath: command not found`.

**Paso 3: Construir una CLI en un solo comando**

```bash
# /cli-anything:cli-anything <software-path-or-repo>
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything:cli-anything ./gimp

# Note: If your Claude Code is under 2.x, use "/cli-anything" instead.
```

Esto ejecuta todo el proceso:
1. 🔍 **Analizar** — Escanea el código fuente, mapea acciones de la GUI a APIs
2. 📐 **Diseñar** — Arquitectura de grupos de comandos, modelo de estado, formatos de salida
3. 🔨 **Implementar** — Construye CLI con Click, REPL, salida JSON, deshacer/rehacer
4. 📋 **Planificar Pruebas** — Crea TEST.md con planes de pruebas unitarias y E2E
5. 🧪 **Escribir Pruebas** — Implementa un conjunto completo de pruebas
6. 📝 **Documentar** — Actualiza TEST.md con resultados
7. 📦 **Publicar** — Crea `setup.py`, instala en PATH

**Paso 4 (Opcional): Refinar y Mejorar el CLI**

Después de la construcción inicial, puedes refinar iterativamente el CLI para ampliar la cobertura y agregar capacidades faltantes:

```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything:refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything:refine ./gimp "I want more CLIs on image batch processing and filters"
```

El comando refine realiza un análisis de brechas entre las capacidades completas del software y la cobertura actual de la CLI, luego implementa nuevos comandos, pruebas y documentación para las brechas identificadas. Puedes ejecutarlo varias veces para expandir la cobertura de forma constante: cada ejecución es incremental y no destructiva.

<details>
<summary><strong>Alternativa: Instalación Manual</strong></summary>

Si prefieres no usar el marketplace:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Copy plugin to Claude Code plugins directory
cp -r CLI-Anything/cli-anything-plugin ~/.claude/plugins/cli-anything

# Reload plugins
/reload-plugins
```

</details>

</details>

<details>
<summary><h4 id="-opencode">⚡ OpenCode (Experimental)</h4></summary>

**Paso 1: Instalar los Comandos**

> **Nota:** Por favor actualice a la última versión de OpenCode. Las versiones antiguas pueden usar una ruta de comandos diferente.

Copie los comandos CLI-Anything **y** `HARNESS.md` a su directorio de comandos de OpenCode:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Global install (available in all projects)
cp CLI-Anything/opencode-commands/*.md ~/.config/opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md ~/.config/opencode/commands/

# Or project-level install
cp CLI-Anything/opencode-commands/*.md .opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md .opencode/commands/
```

> **Nota:** `HARNESS.md` es la especificación metodológica a la que hacen referencia todos los comandos. Debe estar en el mismo directorio que los comandos.

Esto añade 5 comandos slash: `/cli-anything`, `/cli-anything-refine`, `/cli-anything-test`, `/cli-anything-validate` y `/cli-anything-list`.

**Paso 2: Construir una CLI en un Comando**

```bash
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything ./gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender
```

El comando se ejecuta como una subtarea y sigue la misma metodología de 7 fases que Claude Code.

**Paso 3 (Opcional): Refinar y mejorar la CLI**

```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything-refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything-refine ./gimp "batch processing and filters"
```

</details>

<details>
<summary><h4 id="-goose">⚡ Goose (Escritorio / CLI) <sup><code>Experimental</code></sup> <sup><code>Comunidad</code></sup></h4></summary>

**Paso 1: Instalar Goose**

Instale Goose (Escritorio o CLI) usando las instrucciones oficiales de Goose para su SO.

**Paso 2: Configurar un proveedor CLI**

Configure Goose para usar un proveedor CLI como Claude Code, y asegúrese de que CLI esté instalado y autenticado.

**Paso 3: Usar CLI-Anything en una sesión de Goose**

Una vez que Goose esté configurado, inicie una sesión y use los mismos comandos CLI-Anything descritos arriba para Claude Code, por ejemplo:

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
```

> Nota: Cuando Goose se ejecuta a través de un proveedor CLI, utiliza las capacidades y el formato de comandos de ese proveedor.
</details>

<details>

<summary><h4 id="-qodercli">⚡ Qodercli <sup><code>Comunidad</code></sup></h4></summary>

**Paso 1: Registrar el Plugin**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
bash CLI-Anything/qoder-plugin/setup-qodercli.sh
```

Esto registra el plugin cli-anything en `~/.qoder.json`. Inicie una nueva sesión de Qodercli después del registro.

**Paso 2: Usar CLI-Anything desde Qodercli**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```
</details>

<details>

<summary><h4 id="-openclaw">⚡ OpenClaw <sup><code>Comunidad</code></sup></h4></summary>

**Paso 1: Instalar la Habilidad**

CLI-Anything proporciona un archivo `SKILL.md` nativo para OpenClaw. Cópielo en su directorio de habilidades de OpenClaw:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install to the global skills folder
mkdir -p ~/.openclaw/skills/cli-anything
cp CLI-Anything/openclaw-skill/SKILL.md ~/.openclaw/skills/cli-anything/SKILL.md
```

**Paso 2: Construir una CLI**

Ahora puedes invocar la habilidad dentro de OpenClaw:

`@cli-anything build a CLI for ./gimp`

La habilidad sigue la misma metodología de 7 fases que Claude Code y OpenCode.

</details>

<details>

<summary><h4 id="-codex">⚡ Codex <sup><code>Experimental</code></sup> <sup><code>Comunidad</code></sup></h4></summary>

**Paso 1: Instalar la Habilidad**

Ejecuta el instalador incluido:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install the skill
bash CLI-Anything/codex-skill/scripts/install.sh
```

En Windows PowerShell, use:

```powershell
.\CLI-Anything\codex-skill\scripts\install.ps1
```

Esto instala la habilidad en `$CODEX_HOME/skills/cli-anything` (o en `~/.codex/skills/cli-anything` si `CODEX_HOME` no está definido).

Reinicie Codex después de la instalación para que sea detectada.

**Paso 2: Usar CLI-Anything desde Codex**

Describa la tarea en lenguaje natural, por ejemplo:

```text
Use CLI-Anything to build a harness for ./gimp
Use CLI-Anything to refine ./shotcut for picture-in-picture workflows
Use CLI-Anything to validate ./libreoffice
```

La habilidad Codex adapta la misma metodología utilizada por el complemento Claude Code y
los comandos OpenCode, manteniendo sin cambios el formato del arnés Python generado.
</details>

<details>

<summary><h4 id="-github-copilot-cli">⚡ GitHub Copilot CLI <sup><code>Comunidad</code></sup></h4></summary>

**Paso 1: Instalar el complemento**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
cd CLI-Anything
copilot plugin install ./cli-anything-plugin
```

Esto instala el complemento CLI-Anything para GitHub Copilot CLI. El complemento ahora debería estar disponible en su sesión de GitHub Copilot CLI.

**Paso 2: Usar CLI-Anything desde GitHub Copilot CLI**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```

</details>

<details>
<summary><h4 id="-more-platforms-coming-soon">🔮 Más plataformas (próximamente)</h4></summary>

CLI-Anything está diseñado para ser independiente de la plataforma. Se planea soporte para más agentes de codificación IA:

- **Codex** — disponible a través de la habilidad incluida en `codex-skill/`
- **Cursor** — próximamente
- **Windsurf** — próximamente
- **Tu herramienta favorita** — ¡contribuciones bienvenidas! Consulta el directorio `opencode-commands/` para una implementación de referencia.

</details>

### Usa el CLI Generado

Independientemente de la plataforma que usaste para construirlo, el CLI generado funciona de la misma manera:

```bash
# Install to PATH
cd gimp/agent-harness && pip install -e .

# Use from anywhere
cli-anything-gimp --help
cli-anything-gimp project new --width 1920 --height 1080 -o poster.json
cli-anything-gimp --json layer add -n "Background" --type solid --color "#1a1a2e"

# Enter interactive REPL
cli-anything-gimp
```

Cada CLI instalado incluye un [`SKILL.md`](#-skillmd-generation) dentro del paquete de Python (`cli_anything/<software>/skills/SKILL.md`). El banner del REPL muestra automáticamente la ruta absoluta a este archivo para que los agentes de IA sepan exactamente dónde leer la definición de la habilidad. No se necesita configuración adicional — `pip install` hace que la habilidad sea detectable.

---

## 🤖 Potencia Tus Agentes con CLI-Hub

CLI-Hub permite que los agentes descubran e instalen autónomamente los CLI que necesitan — sin intervención humana.

Publicamos una **meta-habilidad** que permite a cualquier agente de IA explorar libremente el catálogo completo de CLI comunitarios y elegir el adecuado para la tarea.

**Instalar con un solo comando:**

```bash
# OpenClaw
openclaw skills install cli-anything-hub

# nanobot
nanobot skills install cli-anything-hub
```

**Luego simplemente solicita a tu agente:**

```
Find appropriate CLI software in CLI-Hub and complete the task: <your task here>
```

El agente explorará el catálogo, instalará el CLI que se ajuste a la tarea y lo usará — todo de forma autónoma.

**Cómo funciona en el fondo:**

1. La meta-habilidad apunta al catálogo en vivo en [`https://hkuds.github.io/CLI-Anything/SKILL.txt`](https://hkuds.github.io/CLI-Anything/SKILL.txt)
2. El agente lee más de 20 CLIs organizados por categoría con comandos `pip install` de una línea
3. El agente instala el CLI que se ajuste a la tarea, luego lee el propio SKILL.md de ese CLI para un uso detallado

El catálogo se actualiza automáticamente cada vez que cambia `registry.json` — los nuevos CLIs comunitarios aparecen automáticamente.

> **Para usuarios de Claude Code:** Copie [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md) en su proyecto o directorio de habilidades para la misma detección automática de CLI.

---

## 💡 Visión de CLI-Anything: Construyendo Software Nativo para Agentes

• 🌐 **Acceso Universal** - Todo software se vuelve instantáneamente controlable por agentes a través de CLI estructurado.

• 🔗 **Integración Sin Fricciones** - Los agentes controlan cualquier aplicación sin APIs, GUI, reconstrucción o envoltorios complejos.

• 🚀 **Ecosistema Preparado para el Futuro** - Transforma software diseñado por humanos en herramientas nativas para agentes con un solo comando.

---

## 🔧 Cuándo Usar CLI-Anything

| Categoría | Cómo ser Nativo para Agentes | Ejemplos Notables |
|----------|------------------------------|-------------------|
| **📂 Repositorios de GitHub** | Transforma cualquier proyecto de código abierto en herramientas controlables por agentes mediante generación automática de CLI | VSCodium, WordPress, Calibre, Zotero, Joplin, Logseq, Penpot, Super Productivity |
| **🤖 Plataformas AI/ML** | Automatiza entrenamiento de modelos, pipelines de inferencia y ajuste de hiperparámetros mediante comandos estructurados | Stable Diffusion WebUI, ComfyUI, Ollama, InvokeAI, Text-generation-webui, Open WebUI, Fooocus, Kohya_ss, AnythingLLM, SillyTavern |
| **📊 Datos y Analítica** | Permite procesamiento programático de datos, visualización y flujos de trabajo de análisis estadístico | JupyterLab, Apache Superset, Metabase, Redash, DBeaver, KNIME, Orange, OpenSearch Dashboards, Lightdash |
| **💻 Herramientas de Desarrollo** | Optimiza edición de código, construcción, pruebas y despliegue mediante interfaces de comando | Jenkins, Gitea, Hoppscotch, Portainer, pgAdmin, SonarQube, ArgoCD, OpenLens, Insomnia, Beekeeper Studio, **[iTerm2](https://iterm2.com)** |
| **🎨 Creativo y Multimedia** | Controla la creación, edición y renderizado de contenido programáticamente | Blender, GIMP, OBS Studio, Audacity, Krita, Kdenlive, Shotcut, Inkscape, Darktable, LMMS, Ardour |
| **🔬 Computación Científica** | Automatiza flujos de investigación, simulaciones y cálculos complejos | ImageJ, FreeCAD, QGIS, ParaView, Gephi, LibreCAD, Stellarium, KiCad, JASP, Jamovi |
| **🏢 Empresarial y Oficina** | Convierte aplicaciones de negocio y herramientas de productividad en sistemas accesibles por agentes | NextCloud, GitLab, Grafana, Mattermost, LibreOffice, AppFlowy, NocoDB, Odoo (Community), Plane, ERPNext |
| **📞 Comunicación y Colaboración** | Automatiza programación de reuniones, gestión de participantes, recuperación de grabaciones e informes mediante CLI estructurado | Zoom, Jitsi Meet, BigBlueButton, Mattermost |
| **📐 Diagramación y Visualización** | Crea y manipula diagramas, flujogramas, diagramas de arquitectura y documentación visual programáticamente | Draw.io (diagrams.net), Mermaid, PlantUML, Excalidraw, yEd |
| **🌐 Red e Infraestructura** | Gestiona servicios de red, DNS, bloqueo de anuncios e infraestructura mediante comandos CLI estructurados | AdGuardHome |
| **🔬 Gráficos y Depuración GPU** | Analiza capturas de frames GPU, inspecciona el estado del pipeline, exporta shaders y diferencia estados de renderizado | RenderDoc |
| **✨ Generación de Contenido con IA** | Genera entregables profesionales (presentaciones, documentos, diagramas, sitios web, informes de investigación) mediante APIs en la nube impulsadas por IA | [AnyGen](https://www.anygen.io), Gamma, Beautiful.ai, Tome |

---

## Características Clave de CLI-Anything

### La Brecha Agente-Software
Los agentes de IA son excelentes razonando pero pésimos usando software profesional real. Las soluciones actuales son automatizaciones de UI frágiles, APIs limitadas o reimplementaciones simplificadas que pierden el 90% de la funcionalidad.

**Solución de CLI-Anything**: Transformar cualquier software profesional en herramientas nativas para agentes sin perder capacidades.

| **Problema Actual** | **Solución de CLI-Anything** |
|----------|----------------------|
| 🤖 "La IA no puede usar herramientas reales" | Integración directa con los backends del software real (Blender, LibreOffice, FFmpeg) — capacidades profesionales completas, sin compromisos |
| 💸 "La automatización UI se rompe constantemente" | Sin capturas de pantalla, sin clics, sin fragilidad RPA. Fiabilidad pura de línea de comandos con interfaces estructuradas |
| 📊 "Los agentes necesitan datos estructurados" | Salida JSON integrada para consumo fluido por agentes + formatos legibles para humanos para depuración |
| 🔧 "Las integraciones personalizadas son caras" | Un plugin Claude genera automáticamente CLI para CUALQUIER base de código mediante una tubería de 7 fases comprobada |
| ⚡ "Brecha entre prototipo y producción" | Más de 1,839 pruebas con validación en software real. Probado en batalla en 16 aplicaciones principales |

---

## 🎯 ¿Qué Puedes Hacer con CLI-Anything?

<table>
<tr>
<td width="33%">

### 🛠️ Deja que los Agentes Manejen Tus Flujos de Trabajo

Profesional o cotidiano — solo lanza la base de código a `/cli-anything`. GIMP, Blender, Shotcut para trabajo creativo. LibreOffice, OBS Studio para tareas diarias. ¿No tienes el código fuente? Encuentra una alternativa de código abierto y lanza *esa*. Obtendrás instantáneamente un CLI completo que tus agentes pueden usar.

</td>
<td width="33%">

### 🔗 Unifica APIs Dispersas en Un Solo CLI

¿Cansado de manejar APIs fragmentadas de servicios web? Alimenta la documentación o manuscritos SDK a `/cli-anything` y tus agentes obtienen un **CLI poderoso y con estado** que envuelve esos endpoints individuales en grupos de comandos coherentes. Una herramienta en lugar de docenas de llamadas API en bruto — capacidades más fuertes mientras ahorras tokens.

</td>
<td width="33%">

### 🚀 Reemplazar o Potenciar Agentes GUI

CLI-Anything puede **reemplazar completamente los enfoques de agentes basados en GUI** — no más capturas de pantalla, no más clics frágiles en píxeles. Pero aquí está la parte divertida: una vez que haces `/cli-anything` a un software GUI, puedes **sintetizar tareas de agente, evaluadores y benchmarks** completamente vía código y terminal — totalmente automatizado, refinable de forma iterativa, mucho más eficiente.

</td>
</tr>
</table>

---

## ✨ ⚙️ Cómo Funciona CLI-Anything

<table>
<tr>
<td width="50%">

### 🏗️ Pipeline Automatizado en 7 Fases
Desde el análisis del código hasta la publicación en PyPI — el plugin maneja diseño de arquitectura, implementación, planificación de pruebas, escritura de pruebas y documentación completamente de forma automática.

</td>
<td width="50%">

### 🎯 Integración Auténtica de Software
Llamadas directas a aplicaciones reales para renderizado real. LibreOffice genera PDFs, Blender renderiza escenas 3D, Audacity procesa audio vía sox. **Cero compromisos**, **Cero implementaciones de juguete**.

</td>
</tr>
<tr>
<td width="50%">

### 🔁 Gestión Inteligente de Sesiones
Estado persistente del proyecto con capacidades de deshacer/rehacer, además de interfaz REPL unificada (ReplSkin) que ofrece una experiencia interactiva consistente en todas las CLIs.

</td>
<td width="50%">

### 📦 Instalación Sin Configuración
Simple pip install -e . pone cli-anything-<software> directamente en PATH. Los agentes descubren herramientas mediante comandos which estándar. Sin configuración, sin envoltorios.

</td>
</tr>
<tr>
<td width="50%">

### 🧪 Pruebas de Nivel de Producción
Validación multinivel: pruebas unitarias con datos sintéticos, pruebas de extremo a extremo con archivos y software reales, además de verificación de subprocesos CLI de comandos instalados.

</td>
<td width="50%">

### 🐍 Arquitectura Limpia del Paquete
Todas las CLI organizadas bajo el espacio de nombres cli_anything.* — sin conflictos, instalables con pip, con nombres consistentes: cli-anything-gimp, cli-anything-blender, etc.

</td>
</tr>
</table>

### 🤖 Generación de SKILL.md

Cada CLI generado incluye un archivo `SKILL.md` dentro del paquete Python en `cli_anything/<software>/skills/SKILL.md`. Esta definición de habilidad autónoma permite que agentes de IA descubran y usen la CLI mediante el sistema de habilidades de Claude Code u otros marcos de agentes.

**Lo que proporciona SKILL.md:**
- **Frontmatter YAML** con nombre y descripción para el descubrimiento de habilidades por agentes
- **Grupos de comandos** con todos los subcomandos disponibles documentados
- **Ejemplos de uso** para flujos de trabajo comunes
- **Guía específica para agentes** sobre salida JSON, manejo de errores y uso programático

Los archivos SKILL.md se generan automáticamente durante la Fase 6.5 del pipeline usando `skill_generator.py`, que extrae metadatos directamente de los decoradores Click de la CLI, setup.py y README. Debido a que el archivo vive dentro del paquete, se instala junto con la CLI vía `pip install` y es detectado automáticamente por el banner REPL — los agentes pueden leer la ruta absoluta mostrada al inicio.

---

## 🎬 Demostraciones

### 🎯 Propósito General
CLI-Anything funciona con cualquier software que tenga base de código — sin restricciones de dominio ni limitaciones arquitectónicas.

### 🏭 Pruebas de Nivel Profesional
Probado en 16 aplicaciones diversas y complejas que abarcan dominios de creatividad, productividad, comunicación, diagramación, generación de imágenes IA, generación de contenido IA, bloqueo de anuncios en red e inferencia local de LLM, dominios antes inaccesibles para agentes de IA.

### 🎨 Cobertura de Dominios Diversos  
Desde flujos creativos (edición de imágenes, modelado 3D, gráficos vectoriales) hasta herramientas de producción (audio, oficina, transmisión en vivo, edición de video).  

### ✅ Generación Completa de CLI  
Cada aplicación recibió interfaces CLI completas y listas para producción — no demos, sino acceso integral a las herramientas preservando todas las capacidades.  

<table>  
<tr>  
<th align="center">Software</th>  
<th align="center">Dominio</th>  
<th align="center">Comando CLI</th>  
<th align="center">Backend</th>  
<th align="center">Pruebas</th>  
</tr>  
<tr>  
<td align="center"><strong>🎨 GIMP</strong></td>  
<td>Edición de Imágenes</td>  
<td><code>cli-anything-gimp</code></td>  
<td>Pillow + GEGL/Script-Fu</td>  
<td align="center">✅ 107</td>  
</tr>  
<tr>  
<td align="center"><strong>🧊 Blender</strong></td>  
<td>Modelado y Renderizado 3D</td>  
<td><code>cli-anything-blender</code></td>  
<td>bpy (scripting en Python)</td>  
<td align="center">✅ 208</td>  
</tr>  
<tr>  
<td align="center"><strong>✏️ Inkscape</strong></td>  
<td>Gráficos Vectoriales</td>  
<td><code>cli-anything-inkscape</code></td>  
<td>Manipulación directa de SVG/XML</td>  
<td align="center">✅ 202</td>  
</tr>  
<tr>  
<td align="center"><strong>🎵 Audacity</strong></td>  
<td>Producción de Audio</td>  
<td><code>cli-anything-audacity</code></td>  
<td>Python wave + sox</td>
<td align="center">✅ 161</td>
</tr>
<tr>
<td align="center"><strong>🌐 Navegador</strong></td>
<td>Automatización de Navegadores</td>
<td><code>cli-anything-browser</code></td>
<td>DOMShell MCP + Árbol de Accesibilidad</td>
<td align="center">✅ <a href="browser/agent-harness/">Nuevo</a></td>
</tr>
<tr>
<td align="center"><strong>📄 LibreOffice</strong></td>
<td>Suite Ofimática (Writer, Calc, Impress)</td>
<td><code>cli-anything-libreoffice</code></td>
<td>Generación ODF + LO sin interfaz</td>
<td align="center">✅ 158</td>
</tr>
<tr>
<td align="center"><strong>📝 <a href="mubu/agent-harness/">Mubu</a></strong></td>
<td>Gestión del Conocimiento y Esquemas</td>
<td><code>cli-anything-mubu</code></td>
<td>Datos locales de Mubu + registros de sincronización</td>
<td align="center">✅ 96</td>
</tr>
<tr>
<td align="center"><strong>📹 OBS Studio</strong></td>
<td>Transmisión en Vivo y Grabación</td>
<td><code>cli-anything-obs-studio</code></td>
<td>Escena JSON + obs-websocket</td>
<td align="center">✅ 153</td>
</tr>
<tr>
<td align="center"><strong>🎞️ Kdenlive</strong></td>
<td>Edición de Video</td>
<td><code>cli-anything-kdenlive</code></td>
<td>MLT XML + renderizador melt</td>
<td align="center">✅ 155</td>
</tr>
<tr>
<td align="center"><strong>🎬 Shotcut</strong></td>
<td>Edición de Video</td>
<td><code>cli-anything-shotcut</code></td>
<td>MLT XML Directo + melt</td>
<td align="center">✅ 154</td>
</tr>
<tr>
<td align="center"><strong>📞 Zoom</strong></td>
<td>Videoconferencias</td>
<td><code>cli-anything-zoom</code></td>
<td>API REST de Zoom (OAuth2)</td>
<td align="center">✅ 22</td>
</tr>
<tr>
<td align="center"><strong>🎵 MuseScore</strong></td>
<td>Notación Musical</td>
<td><code>cli-anything-musescore</code></td>
<td>CLI mscore (MSCX/MusicXML)</td>
<td align="center">✅ 56</td>
</tr>
<tr>
<td align="center"><strong>📐 Draw.io</strong></td>
<td>Diagramación</td>
<td><code>cli-anything-drawio</code></td>
<td>XML mxGraph + CLI draw.io</td>
<td align="center">✅ 138</td>
</tr>
<tr>
<td align="center"><strong>🧜 Editor en Vivo Mermaid</strong></td>
<td>Diagramación</td>
<td><code>cli-anything-mermaid</code></td>
<td>Estado Mermaid + renderizador mermaid.ink</td>
<td align="center">✅ 10</td>
</tr>
<tr>
<td align="center"><strong>✨ AnyGen</strong></td>
<td>Generación de Contenido AI</td>
<td><code>cli-anything-anygen</code></td>
<td>API REST AnyGen (anygen.io)</td>
<td align="center">✅ 50</td>
</tr>
<tr>
<td align="center"><strong>🧠 NotebookLM</strong></td>
<td>Asistente de Investigación AI</td>
<td><code>cli-anything-notebooklm</code></td>
<td>Wrapper CLI de NotebookLM (experimental)</td>
<td align="center">✅ 21</td>
</tr>
<tr>
<td align="center"><strong>🖼️ ComfyUI</strong></td>
<td>Generación de Imágenes AI</td>
<td><code>cli-anything-comfyui</code></td>
<td>API REST de ComfyUI</td>
<td align="center">✅ 70</td>
</tr>
<tr>
<td align="center"><strong>🛡️ AdGuard Home</strong></td>
<td>Bloqueo de Anuncios a Nivel de Red</td>
<td><code>cli-anything-adguardhome</code></td>
<td>API REST de AdGuard Home</td>
<td align="center">✅ 36</td>
</tr>
<tr>
<td align="center"><strong>🦙 Ollama</strong></td>
<td>Inferencia LLM Local</td>
<td><code>cli-anything-ollama</code></td>
<td>API REST de Ollama</td>
<td align="center">✅ 98</td>
</tr>
<tr>
<td align="center"><strong>🎨 Sketch</strong></td>
<td>Diseño de UI</td>
<td><code>sketch-cli</code></td>
<td>sketch-constructor (Node.js)</td>
<td align="center">✅ 19</td>
</tr>
<tr>
<td align="center" colspan="4"><strong>Total</strong></td>
<td align="center"><strong>✅ 1,858</strong></td>
</tr>
</table>

> **100% de tasa de aprobación** en los 1,858 tests — 1,355 tests unitarios + 484 tests de extremo a extremo + 19 tests de Node.js.

---

## 📊 Resultados de las pruebas

Cada entorno CLI se somete a pruebas rigurosas de múltiples capas para garantizar la fiabilidad en producción:

| Capa | Qué prueba | Ejemplo |
|-------|---------------|---------|
| **Tests unitarios** | Cada función principal aisladamente con datos sintéticos | `test_core.py` — creación de proyecto, operaciones de capas, parámetros de filtro |
| **Tests E2E (nativos)** | Pipeline de generación de archivos del proyecto | Estructura ZIP ODF válida, XML MLT correcto, SVG bien formado |
| **Tests E2E (backend real)** | Invocación real del software + verificación de salida | LibreOffice → PDF con bytes mágicos `%PDF-`, Blender → PNG renderizado |
| **Tests de subprocesos CLI** | Comando instalado vía `subprocess.run` | `cli-anything-gimp --json project new` → salida JSON válida |

```
================================ Test Summary ================================
gimp          107 passed  ✅   (64 unit + 43 e2e)
blender       208 passed  ✅   (150 unit + 58 e2e)
inkscape      202 passed  ✅   (148 unit + 54 e2e)
audacity      161 passed  ✅   (107 unit + 54 e2e)
libreoffice   158 passed  ✅   (89 unit + 69 e2e)
mubu           96 passed  ✅   (85 unit + 11 e2e)
obs-studio    153 passed  ✅   (116 unit + 37 e2e)
kdenlive      155 passed  ✅   (111 unit + 44 e2e)
shotcut       154 passed  ✅   (110 unit + 44 e2e)
zoom           22 passed  ✅   (22 unit + 0 e2e)
drawio        138 passed  ✅   (116 unit + 22 e2e)
mermaid        10 passed  ✅   (5 unit + 5 e2e)
anygen         50 passed  ✅   (40 unit + 10 e2e)
notebooklm     21 passed  ✅   (21 unit + 0 e2e)
comfyui        70 passed  ✅   (60 unit + 10 e2e)
adguardhome    36 passed  ✅   (24 unit + 12 e2e)
ollama         98 passed  ✅   (87 unit + 11 e2e)
sketch         19 passed  ✅   (19 jest, Node.js)
renderdoc      59 passed  ✅   (45 unit + 14 e2e)
──────────────────────────────────────────────────────────────────────────────
TOTAL        1,917 passed  ✅   100% pass rate
```

---

## 🏗️ Arquitectura de CLI-Anything

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/architecture.png" alt="Arquitectura de CLI-Anything" width="750">
</p>

### 🎯 Principios de Diseño Central

1. **Integración Auténtica de Software** — El CLI genera archivos de proyecto válidos (ODF, MLT XML, SVG) y delega a aplicaciones reales para la renderización. **Construimos interfaces estructuradas PARA el software, no reemplazos**.

2. **Modelos de Interacción Flexibles** — Cada CLI opera en modos duales: REPL con estado para sesiones interactivas de agentes + interfaz de subcomandos para scripting/pipelines. **Ejecutar comando simple → entrar en modo REPL**.

3. **Experiencia de Usuario Consistente** — Todos los CLIs generados comparten una interfaz REPL unificada (repl_skin.py) con banners personalizados, prompts estilizados, historial de comandos, indicadores de progreso y formato estandarizado.

4. **Diseño Nativo para Agentes** — Bandera --json incorporada en cada comando entrega datos estructurados para consumo por máquinas, mientras que tablas legibles para humanos sirven para uso interactivo. **Los agentes descubren capacidades mediante --help estándar y qué comandos**.

5. **Dependencias Sin Compromisos** — El software real es un requisito estricto — sin alternativas, sin degradación elegante. **Las pruebas fallan (no se omiten) cuando faltan backends, asegurando funcionalidad auténtica**.

---

## 📂 Estructura del Proyecto

```
cli-anything/
├── 📄 README.md                          # You are here
├── 📁 assets/                            # Images and media
│   ├── icon.png                          # Project icon
│   └── teaser.png                        # Teaser figure
│
├── 🔌 cli-anything-plugin/               # The Claude Code plugin
│   ├── HARNESS.md                        # Methodology SOP (source of truth)
│   ├── README.md                         # Plugin documentation
│   ├── QUICKSTART.md                     # 5-minute getting started
│   ├── PUBLISHING.md                     # Distribution guide
│   ├── repl_skin.py                      # Unified REPL interface
│   ├── commands/                         # Plugin command definitions
│   │   ├── cli-anything.md               # Main build command
│   │   ├── refine.md                     # Expand existing harness coverage
│   │   ├── test.md                       # Test runner
│   │   └── validate.md                   # Standards validation
│   └── scripts/
│       └── setup-cli-anything.sh         # Setup script
│
├── 🤖 codex-skill/                      # Codex skill entry point
├── 🎨 gimp/agent-harness/               # GIMP CLI (107 tests)
├── 🧊 blender/agent-harness/            # Blender CLI (208 tests)
├── ✏️ inkscape/agent-harness/            # Inkscape CLI (202 tests)
├── 🎵 audacity/agent-harness/           # Audacity CLI (161 tests)
├── 🌐 browser/agent-harness/            # Browser CLI (DOMShell MCP, new)
├── 📄 libreoffice/agent-harness/        # LibreOffice CLI (158 tests)
├── 📝 mubu/agent-harness/               # Mubu CLI (96 tests)
├── 📹 obs-studio/agent-harness/         # OBS Studio CLI (153 tests)
├── 🎞️ kdenlive/agent-harness/           # Kdenlive CLI (155 tests)
├── 🎬 shotcut/agent-harness/            # Shotcut CLI (154 tests)
├── 📞 zoom/agent-harness/               # Zoom CLI (22 tests)
├── 🎵 musescore/agent-harness/          # MuseScore CLI (56 tests)
├── 📐 drawio/agent-harness/             # Draw.io CLI (138 tests)
├── 🧜 mermaid/agent-harness/            # Mermaid Live Editor CLI (10 tests)
├── ✨ anygen/agent-harness/             # AnyGen CLI (50 tests)
├── 🖼️ comfyui/agent-harness/            # ComfyUI CLI (70 tests)
├── 🧠 notebooklm/agent-harness/         # NotebookLM CLI (experimental, 21 tests)
├── 🛡️ adguardhome/agent-harness/       # AdGuard Home CLI (36 tests)
├── 🦙 ollama/agent-harness/             # Ollama CLI (98 tests)
├── 🎨 sketch/agent-harness/             # Sketch CLI (19 tests, Node.js)
└── 🔬 renderdoc/agent-harness/          # RenderDoc CLI (59 tests)
```
Cada `agent-harness/` contiene un paquete Python instalable bajo `cli_anything.<software>/` con CLI Click, módulos centrales, utilidades (incluyendo `repl_skin.py` y envoltorio backend), y pruebas completas.

---

## 🎯 Comandos del Plugin

| Comando | Descripción |
|---------|-------------|
| `/cli-anything <ruta-o-repo-software>` | Construir arnés CLI completo — las 7 fases |
| `/cli-anything:refine <ruta-software> [enfoque]` | Refinar un arnés existente — ampliar cobertura con análisis de brechas |
| `/cli-anything:test <ruta-o-repo-software>` | Ejecutar pruebas y actualizar TEST.md con resultados |
| `/cli-anything:validate <ruta-o-repo-software>` | Validar contra los estándares HARNESS.md |

### Ejemplos


```bash
# Build a complete CLI for GIMP from local source
/cli-anything /home/user/gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender

# Refine an existing harness — broad gap analysis
/cli-anything:refine /home/user/gimp

# Refine with a specific focus area
/cli-anything:refine /home/user/shotcut "vid-in-vid and picture-in-picture compositing"

# Run tests and update TEST.md
/cli-anything:test /home/user/inkscape

# Validate against HARNESS.md standards
/cli-anything:validate /home/user/audacity
```

---

## 🎮 Demo: Using a Generated CLI

Here's what an agent can do with `cli-anything-libreoffice`:

```bash
# Create a new Writer document
$ cli-anything-libreoffice document new -o report.json --type writer
✓ Created Writer document: report.json

# Add content
$ cli-anything-libreoffice --project report.json writer add-heading -t "Q1 Report" --level 1
✓ Added heading: "Q1 Report"

$ cli-anything-libreoffice --project report.json writer add-table --rows 4 --cols 3
✓ Added 4×3 table

# Export to real PDF via LibreOffice headless
$ cli-anything-libreoffice --project report.json export render output.pdf -p pdf --overwrite
✓ Exported: output.pdf (42,831 bytes) via libreoffice-headless

# JSON mode for agent consumption
$ cli-anything-libreoffice --json document info --project report.json
{
  "name": "Q1 Report",
  "type": "writer",
  "pages": 1,
  "elements": 2,
  "modified": true
}
```

### Modo REPL

```
$ cli-anything-blender
╔══════════════════════════════════════════╗
║       cli-anything-blender v1.0.0       ║
║     Blender CLI for AI Agents           ║
╚══════════════════════════════════════════╝

blender> scene new --name ProductShot
✓ Created scene: ProductShot

blender[ProductShot]> object add-mesh --type cube --location 0 0 1
✓ Added mesh: Cube at (0, 0, 1)

blender[ProductShot]*> render execute --output render.png --engine CYCLES
✓ Rendered: render.png (1920×1080, 2.3 MB) via blender --background

blender[ProductShot]> exit
Goodbye! 👋
```

---

## 📖 El Manual Estándar: HARNESS.md

HARNESS.md es nuestro SOP definitivo para hacer que cualquier software sea accesible mediante agentes a través de generación automática de CLI.

Codifica patrones y metodologías probadas, refinadas mediante procesos de generación automatizada.

El manual destila ideas clave de la construcción exitosa de los 16 arneses diversos y listos para producción.

### Lecciones Críticas

| Lección | Descripción |
|--------|-------------|
| **Usar el software real** | El CLI DEBE llamar a la aplicación real para el renderizado. No sustitutos Pillow para GIMP, ni renderizadores personalizados para Blender. Genera archivos de proyecto válidos → invoca el backend real. |
| **La Brecha de Renderizado** | Las apps GUI aplican efectos en tiempo de renderizado. Si tu CLI manipula archivos de proyecto pero usa una herramienta de exportación ingenua, los efectos se pierden silenciosamente. Solución: renderizador nativo → traducción de filtros → script de renderizado. |
| **Traducción de Filtros** | Al mapear efectos entre formatos (MLT → ffmpeg), cuidado con la fusión de filtros duplicados, el orden entrelazado de streams, diferencias en el espacio de parámetros y efectos no mapeables. |
| **Precisión de Código de Tiempo** | Las tasas de frames no enteras (29.97fps) causan redondeos acumulativos. Usa `round()` no `int()`, aritmética entera para visualización y tolerancia de ±1 frame en pruebas. |
| **Verificación de Salida** | Nunca confíes en que la exportación funcionó porque salió con código 0. Verifica: bytes mágicos, estructura ZIP/OOXML, análisis de píxeles, niveles RMS de audio, comprobaciones de duración. |

> Consulta la metodología completa: [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md)

---

## 📦 Instalación y Uso

### Para Usuarios de Plugins (Claude Code)

```bash
# Add marketplace & install (recommended)
/plugin marketplace add HKUDS/CLI-Anything
/plugin install cli-anything

# Build a CLI for any software with a codebase
/cli-anything <software-name>
```

### Para CLIs generados

```bash
# Install any generated CLI
cd <software>/agent-harness
pip install -e .

# Verify
which cli-anything-<software>

# Use
cli-anything-<software> --help
cli-anything-<software>                    # enters REPL
cli-anything-<software> --json <command>   # JSON output for agents
```

### Ejecutando Pruebas

```bash
# Run tests for a specific CLI
cd <software>/agent-harness
python3 -m pytest cli_anything/<software>/tests/ -v

# Force-installed mode (recommended for validation)
CLI_ANYTHING_FORCE_INSTALLED=1 python3 -m pytest cli_anything/<software>/tests/ -v -s
```

---

## 🤝 Contribuir

¡Damos la bienvenida a las contribuciones! CLI-Anything está diseñado para ser extensible:

- **Nuevos objetivos de software** — Usa el plugin para generar una CLI para cualquier software con base de código, luego envía tu arnés a través de [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md).
- **Mejoras en la metodología** — PRs a `HARNESS.md` que codifiquen nuevas lecciones aprendidas
- **Mejoras en el plugin** — Nuevos comandos, mejoras en fases, mejor validación
- **Cobertura de pruebas** — Más escenarios E2E, casos límite, pruebas de flujo de trabajo

### Limitaciones

- **Requiere modelos base potentes** — CLI-Anything depende de modelos de frontera (p. ej., Claude Opus 4.6, Claude Sonnet 4.6, GPT-5.4) para una generación confiable de arneses. Modelos más débiles o pequeños pueden producir CLIs incompletas o incorrectas que requieren corrección manual significativa.
- **Depende del código fuente disponible** — La tubería de 7 fases analiza y genera a partir del código fuente. Cuando el software objetivo solo proporciona binarios compilados que requieren descompilación, la calidad y cobertura del arnés se degradará sustancialmente.
- **Puede requerir refinamiento iterativo** — Una ejecución única de `/cli-anything` puede no cubrir todas las capacidades. Ejecutar `/refine` una o más veces suele ser necesario para llevar el rendimiento y la cobertura de la CLI a calidad de producción.

### Hoja de ruta

- [ ] Soporte para más categorías de aplicaciones (CAD, DAW, IDE, EDA, herramientas científicas)
- [ ] Suite de benchmarks para tasas de finalización de tareas de agentes
- [ ] Arnéses CLI contribuidos por la comunidad para software interno/personalizado
- [ ] Integración con frameworks de agentes adicionales más allá de Claude Code
- [ ] Soporte para empaquetar APIs de software cerrado y servicios web en CLIs
- [x] Producir SKILL.md junto con la CLI para descubrimiento y orquestación de habilidades del agente

---

## 📖 Documentación

| Documento | Descripción |
|----------|-------------|
| [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md) | El SOP de la metodología — fuente única de verdad |
| [`cli-anything-plugin/README.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/README.md) | Documentación del plugin — comandos, opciones, fases |
| [`cli-anything-plugin/QUICKSTART.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/QUICKSTART.md) | Guía de inicio rápido de 5 minutos |
| [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md) | Guía de distribución y publicación |

Cada arnés generado también incluye:
- `<SOFTWARE>.md` — SOP de arquitectura específica para esa aplicación
- `tests/TEST.md` — Plan de pruebas y documentación de resultados

---

## ⭐ Historial de Estrellas

Si CLI-Anything ayuda a que tu software sea nativo para Agentes, ¡danos una estrella! ⭐

<div align="center">
  <a href="https://star-history.com/#HKUDS/CLI-Anything&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
      <img alt="Gráfico de Historial de Estrellas" src="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
    </picture>
  </a>
</div>

---

## 📄 Licencia

Licencia MIT — libre para usar, modificar y distribuir.

---

<div align="center">

**CLI-Anything** — *Haz cualquier software con una base de código nativa para Agentes.*

<sub>Una metodología para la era de los agentes de IA | 16 demos profesionales de software | 1,839 pruebas aprobadas</sub>

<br>

<img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="Ícono de CLI-Anything" width="80">

</div>

<p align="center">
  <em> ¡Gracias por visitar ✨ CLI-Anything!</em><br><br>
  <img src="https://visitor-badge.laobi.icu/badge?page_id=HKUDS.CLI-Anything&style=for-the-badge&color=00d4ff" alt="Views">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---