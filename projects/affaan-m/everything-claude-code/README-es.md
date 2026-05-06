**Language:** English | [Português (Brasil)](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/pt-BR/README.md) | [简体中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/zh-TW/README.md) | [日本語](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ja-JP/README.md) | [한국어](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ko-KR/README.md) | [Türkçe](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/tr/README.md)

# Everything Claude Code

![Everything Claude Code — the performance system for AI agent harnesses](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/assets/hero.png)

[![Stars](https://img.shields.io/github/stars/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/stargazers)
[![Forks](https://img.shields.io/github/forks/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/network/members)
[![Contributors](https://img.shields.io/github/contributors/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/graphs/contributors)
[![npm ecc-universal](https://img.shields.io/npm/dw/ecc-universal?label=ecc-universal%20weekly%20downloads&logo=npm)](https://www.npmjs.com/package/ecc-universal)
[![npm ecc-agentshield](https://img.shields.io/npm/dw/ecc-agentshield?label=ecc-agentshield%20weekly%20downloads&logo=npm)](https://www.npmjs.com/package/ecc-agentshield)
[![GitHub App Install](https://img.shields.io/badge/GitHub%20App-150%20installs-2ea44f?logo=github)](https://github.com/marketplace/ecc-tools)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Shell](https://img.shields.io/badge/-Shell-4EAA25?logo=gnu-bash&logoColor=white)
![TypeScript](https://img.shields.io/badge/-TypeScript-3178C6?logo=typescript&logoColor=white)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![Go](https://img.shields.io/badge/-Go-00ADD8?logo=go&logoColor=white)
![Java](https://img.shields.io/badge/-Java-ED8B00?logo=openjdk&logoColor=white)
![Perl](https://img.shields.io/badge/-Perl-39457E?logo=perl&logoColor=white)
![Markdown](https://img.shields.io/badge/-Markdown-000000?logo=markdown&logoColor=white)

> **140K+ stars** | **21K+ forks** | **170+ contributors** | **12+ language ecosystems** | **Anthropic Hackathon Winner**

---

<div align="center">

**Language / 语言 / 語言 / Dil**

[**English**](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.md) | [Português (Brasil)](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/pt-BR/README.md) | [简体中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/zh-TW/README.md) | [日本語](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ja-JP/README.md) | [한국어](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ko-KR/README.md)
 | [Türkçe](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/tr/README.md)

</div>

---

**The performance optimization system for AI agent harnesses. From an Anthropic hackathon winner.**

Not just configs. A complete system: skills, instincts, memory optimization, continuous learning, security scanning, and research-first development. Production-ready agents, skills, hooks, rules, MCP configurations, and legacy command shims evolved over 10+ months of intensive daily use building real products.

Funciona con **Claude Code**, **Codex**, **Cursor**, **OpenCode**, **Gemini** y otros entornos de agentes de IA.

ECC v2.0.0-rc.1 añade la historia pública del operador Hermes sobre esa capa reutilizable: comienza con la [guía de configuración de Hermes](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/HERMES-SETUP.md), luego revisa las [notas de la versión rc.1](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/releases/2.0.0-rc.1/release-notes.md) y la [arquitectura cross-harness](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/architecture/cross-harness.md).

---

## Las Guías

Este repositorio contiene solo el código bruto. Las guías explican todo.

<table>
<tr>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2012378465664745795">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/guides/shorthand-guide.png" alt="La Guía Rápida de Everything Claude Code" />
</a>
</td>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2014040193557471352">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/guides/longform-guide.png" alt="La Guía Extendida de Everything Claude Code" />
</a>
</td>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2033263813387223421">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/security/security-guide-header.png" alt="La Guía Rápida de Seguridad Agente" />
</a>
</td>
</tr>
<tr>
<td align="center"><b>Guía Rápida</b><br/>Configuración, fundamentos, filosofía. <b>Léelo primero.</b></td>
<td align="center"><b>Guía Extendida</b><br/>Optimización de tokens, persistencia de memoria, evaluaciones, paralelización.</td>
<td align="center"><b>Guía de Seguridad</b><br/>Vectores de ataque, sandboxing, sanitización, CVEs, AgentShield.</td>
</tr>
</table>

| Tema | Lo que Aprenderás |
|-------|-------------------|
| Optimización de Tokens | Selección de modelo, reducción del prompt del sistema, procesos en segundo plano |
| Persistencia de Memoria | Hooks que guardan/cargan contexto entre sesiones automáticamente |
| Aprendizaje Continuo | Extracción automática de patrones de sesiones en habilidades reutilizables |
| Bucles de Verificación | Punto de control vs evaluaciones continuas, tipos de calificadores, métricas pass@k |
| Paralelización | Worktrees de Git, método en cascada, cuándo escalar instancias |
| Orquestación de Subagentes | El problema del contexto, patrón iterativo de recuperación |

---

## Novedades

### v2.0.0-rc.1 — Renovación de la Interfaz, Flujos de Trabajo del Operador y ECC 2.0 Alpha (Abr 2026)

- **Interfaz del panel de control** — Nueva aplicación de escritorio basada en Tkinter (`ecc_dashboard.py` o `npm run dashboard`) con alternancia de tema oscuro/claro, personalización de fuente y logotipo del proyecto en el encabezado y la barra de tareas.
- **Superficie pública sincronizada con el repositorio en vivo** — metadatos, conteos de catálogo, manifiestos de plugins y documentación de instalación ahora coinciden con la superficie OSS real: 48 agentes, 182 habilidades y 68 adaptadores de comandos heredados.
- **Expansión de flujos de trabajo de operador y salientes** — `brand-voice`, `social-graph-ranker`, `connections-optimizer`, `customer-billing-ops`, `ecc-tools-cost-audit`, `google-workspace-ops`, `project-flow-ops` y `workspace-surface-audit` completan la línea de operadores.
- **Herramientas de medios y lanzamiento** — `manim-video`, `remotion-video-creation` y superficies de publicación social mejoradas integran explicadores técnicos y contenido de lanzamiento en el mismo sistema.
- **Crecimiento del marco y superficie del producto** — `nestjs-patterns`, superficies de instalación Codex/OpenCode más ricas y empaquetado cruzado expandido mantienen el repositorio usable más allá de Claude Code solo.
- **ECC 2.0 alpha está en el árbol** — el prototipo del plano de control en Rust en `ecc2/` ahora se compila localmente y expone comandos `dashboard`, `start`, `sessions`, `status`, `stop`, `resume` y `daemon`. Es usable como alpha, aún no una versión general.
- **Fortalecimiento del ecosistema** — AgentShield, controles de costos de ECC Tools, trabajo en el portal de facturación y renovaciones del sitio web continúan desplegándose alrededor del plugin central sin derivar en silos separados.

### v1.9.0 — Instalación Selectiva y Expansión de Lenguajes (Mar 2026)

- **Arquitectura de instalación selectiva** — Canal de instalación guiado por manifiestos con `install-plan.js` y `install-apply.js` para instalación dirigida de componentes. El almacén de estado rastrea lo instalado y permite actualizaciones incrementales.
- **6 nuevos agentes** — `typescript-reviewer`, `pytorch-build-resolver`, `java-build-resolver`, `java-reviewer`, `kotlin-reviewer`, `kotlin-build-resolver` amplían la cobertura de lenguaje a 10 idiomas.
- **Nuevas habilidades** — `pytorch-patterns` para flujos de trabajo de aprendizaje profundo, `documentation-lookup` para investigación de referencia API, `bun-runtime` y `nextjs-turbopack` para toolchains modernos de JS, además de 8 habilidades de dominio operativo y `mcp-server-patterns`.
- **Infraestructura de sesión y estado** — Almacén de estado SQLite con CLI de consulta, adaptadores de sesión para grabación estructurada, base para evolución de habilidades para auto-mejora.
- **Revisión de orquestación** — Puntuación de auditoría del harness hecha determinista, estado de orquestación y compatibilidad de lanzadores reforzados, prevención de bucle de observador con guardia de 5 capas.
- **Fiabilidad del observador** — Corrección de explosión de memoria con limitación y muestreo en cola, corrección de acceso al sandbox, lógica de inicio perezoso y guardia de reentrancia.
- **12 ecosistemas de lenguajes** — Nuevas reglas para Java, PHP, Perl, Kotlin/Android/KMP, C++ y Rust se unen a reglas existentes para TypeScript, Python, Go y comunes.
- **Contribuciones de la comunidad** — Traducciones al coreano y chino, optimización del hook biome, habilidades de procesamiento de video, habilidades operativas, instalador PowerShell, soporte para IDE Antigravity.
- **Fortalecimiento de CI** — 19 correcciones de fallos en tests, aplicación de conteo de catálogo, validación de manifiesto de instalación y suite de tests completamente verde.

### v1.8.0 — Sistema de Rendimiento del Harness (Mar 2026)

- **Lanzamiento centrado en el harness** — ECC ahora se enmarca explícitamente como un sistema de rendimiento para harness de agentes, no solo un paquete de configuración.
- **Revisión de confiabilidad de hooks** — Fallback raíz en SessionStart, resúmenes de sesión en fase Stop y hooks basados en scripts reemplazando líneas únicas frágiles en línea.
- **Controles de ejecución de hooks** — `ECC_HOOK_PROFILE=minimal|standard|strict` y `ECC_DISABLED_HOOKS=...` para control en tiempo de ejecución sin editar archivos de hooks.
- **Nuevos comandos de harness** — `/harness-audit`, `/loop-start`, `/loop-status`, `/quality-gate`, `/model-route`.
- **NanoClaw v2** — enrutamiento de modelos, carga en caliente de habilidades, rama/búsqueda/exportación/compactación/métricas de sesión.
- **Paridad entre harnesses** — comportamiento ajustado entre Claude Code, Cursor, OpenCode y app/CLI de Codex.
- **997 tests internos pasados** — suite completa en verde tras refactorización de hooks/tiempo de ejecución y actualizaciones de compatibilidad.

### v1.7.0 — Expansión multiplataforma y creador de presentaciones (Feb 2026)

- **Soporte para app Codex + CLI** — Soporte directo de Codex basado en `AGENTS.md`, orientación del instalador y documentación de Codex  
- **Habilidad `frontend-slides`** — Constructor de presentaciones HTML sin dependencias con guía de conversión a PPTX y reglas estrictas de ajuste de viewport  
- **5 nuevas habilidades genéricas de negocios/contenido** — `article-writing`, `content-engine`, `market-research`, `investor-materials`, `investor-outreach`  
- **Cobertura de herramientas ampliada** — Soporte ajustado para Cursor, Codex y OpenCode para que el mismo repositorio funcione perfectamente en todos los principales entornos  
- **992 pruebas internas** — Validación y cobertura de regresión ampliada en plugins, hooks, habilidades y empaquetado  

### v1.6.0 — CLI Codex, AgentShield y Marketplace (Feb 2026)

- **Soporte para CLI Codex** — Nuevo comando `/codex-setup` genera `codex.md` para compatibilidad con OpenAI Codex CLI  
- **7 nuevas habilidades** — `search-first`, `swift-actor-persistence`, `swift-protocol-di-testing`, `regex-vs-llm-structured-text`, `content-hash-cache-pattern`, `cost-aware-llm-pipeline`, `skill-stocktake`  
- **Integración AgentShield** — La habilidad `/security-scan` ejecuta AgentShield directamente desde Claude Code; 1282 pruebas, 102 reglas  
- **GitHub Marketplace** — App ECC Tools en GitHub disponible en [github.com/marketplace/ecc-tools](https://github.com/marketplace/ecc-tools) con niveles gratis/pro/enterprise  
- **Más de 30 PRs de la comunidad fusionados** — Contribuciones de 30 colaboradores en 6 idiomas  
- **978 pruebas internas** — Suite de validación ampliada en agentes, habilidades, comandos, hooks y reglas  

### v1.4.1 — Corrección de errores (Feb 2026)

- **Corrección de pérdida de contenido en importación de instinct** — `parse_instinct_file()` dejaba caer silenciosamente todo el contenido después del frontmatter (secciones Acción, Evidencia, Ejemplos) durante `/instinct-import`. ([#148](https://github.com/affaan-m/everything-claude-code/issues/148), [#161](https://github.com/affaan-m/everything-claude-code/pull/161))  

### v1.4.0 — Reglas multilingües, asistente de instalación y PM2 (Feb 2026)

- **Asistente interactivo de instalación** — Nueva habilidad `configure-ecc` provee configuración guiada con detección de fusión/sobrescritura  
- **PM2 y orquestación multiagente** — 6 nuevos comandos (`/pm2`, `/multi-plan`, `/multi-execute`, `/multi-backend`, `/multi-frontend`, `/multi-workflow`) para gestionar flujos de trabajo complejos con múltiples servicios  
- **Arquitectura de reglas multilingüe** — Reglas reestructuradas de archivos planos a directorios `common/` + `typescript/` + `python/` + `golang/`. Instala solo los idiomas que necesites  
- **Traducciones al chino (zh-CN)** — Traducción completa de todos los agentes, comandos, habilidades y reglas (más de 80 archivos)  
- **Soporte para GitHub Sponsors** — Patrocina el proyecto vía GitHub Sponsors  
- **CONTRIBUTING.md mejorado** — Plantillas detalladas para cada tipo de contribución  

### v1.3.0 — Soporte para plugin OpenCode (Feb 2026)

- **Integración completa de OpenCode** — 12 agentes, 24 comandos, 16 habilidades con soporte de hooks mediante el sistema de plugins de OpenCode (más de 20 tipos de eventos)  
- **3 herramientas personalizadas nativas** — run-tests, check-coverage, security-audit  
- **Documentación LLM** — `llms.txt` para documentación completa de OpenCode  

### v1.2.0 — Comandos y habilidades unificados (Feb 2026)

- **Soporte para Python/Django** — Patrones, seguridad, TDD y habilidades de verificación para Django  
- **Habilidades para Java Spring Boot** — Patrones, seguridad, TDD y verificación para Spring Boot
- **Gestión de sesiones** — comando `/sessions` para el historial de sesiones  
- **Aprendizaje continuo v2** — aprendizaje basado en instinto con puntuación de confianza, importación/exportación, evolución  

Consulta el registro completo de cambios en [Releases](https://github.com/affaan-m/everything-claude-code/releases).  

---  

## Inicio rápido  

Pon en marcha todo en menos de 2 minutos:  

### Elige solo un camino  

La mayoría de los usuarios de Claude Code deberían usar exactamente una ruta de instalación:  

- **Recomendado por defecto:** instala el plugin Claude Code, luego copia solo las carpetas de reglas que realmente quieras.  
- **Usa el instalador manual solo si** quieres un control más detallado, quieres evitar completamente la ruta del plugin, o tu compilación de Claude Code tiene problemas para resolver la entrada del marketplace autoalojado.  
- **No combines métodos de instalación.** La configuración rota más común es: primero `/plugin install`, luego `install.sh --profile full` o `npx ecc-install --profile full`.  

Si ya combinaste múltiples instalaciones y las cosas parecen duplicadas, ve directamente a [Reiniciar / Desinstalar ECC](#reset--uninstall-ecc).  

### Ruta de bajo contexto / sin hooks  

Si los hooks te parecen demasiado globales o solo quieres las reglas, agentes, comandos y habilidades básicas del flujo de trabajo de ECC, omite el plugin y usa el perfil manual mínimo:

```bash
./install.sh --profile minimal --target claude
```

```powershell
.\install.ps1 --profile minimal --target claude
# or
npx ecc-install --profile minimal --target claude
```

Este perfil excluye intencionalmente `hooks-runtime`.

Si desea el perfil core normal pero necesita desactivar los hooks, use:

```bash
./install.sh --profile core --without baseline:hooks --target claude
```

Agrega hooks más tarde solo si deseas la aplicación en tiempo de ejecución:

```bash
./install.sh --target claude --modules hooks-runtime
```

### Encuentre primero los componentes correctos

Si no está seguro de qué perfil ECC o componente instalar, consulte al asesor empaquetado de cualquier proyecto:

```bash
npx ecc consult "security reviews" --target claude
```
Devuelve componentes coincidentes, perfiles relacionados y comandos de vista previa/instalación. Use el comando de vista previa antes de instalar si desea inspeccionar el plan de archivos exacto.

### Paso 1: Instalar el Plugin (Recomendado)

> NOTA: El plugin es conveniente, pero el instalador OSS a continuación sigue siendo la ruta más confiable si su compilación de Claude Code tiene problemas para resolver entradas del mercado autoalojado.


```bash
# Add marketplace
/plugin marketplace add https://github.com/affaan-m/everything-claude-code

# Install plugin
/plugin install everything-claude-code@everything-claude-code
```

### Nota sobre Nombres + Migración

ECC ahora tiene tres identificadores públicos, y no son intercambiables:

- Repositorio fuente en GitHub: `affaan-m/everything-claude-code`
- Identificador del mercado/plugin de Claude: `everything-claude-code@everything-claude-code`
- Paquete npm: `ecc-universal`

Esto es intencional. Las instalaciones de plugins/mercado de Anthropic se basan en un identificador canónico del plugin, por lo que ECC estandarizó en `everything-claude-code@everything-claude-code` para mantener el nombre en el listado, `/plugin install`, `/plugin list` y la documentación del repo alineados a una única superficie pública de instalación. Las publicaciones antiguas pueden aún mostrar el apodo corto anterior; esa forma abreviada está obsoleta. Por separado, el paquete npm se mantuvo como `ecc-universal`, por lo que las instalaciones npm y las del mercado usan nombres diferentes intencionalmente.

### Paso 2: Instalar Reglas (Requerido)

> ADVERTENCIA: **Importante:** Los plugins de Claude Code no pueden distribuir `rules` automáticamente.
>
> Si ya instalaste ECC mediante `/plugin install`, **no ejecutes `./install.sh --profile full`, `.\install.ps1 --profile full` ni `npx ecc-install --profile full` después**. El plugin ya carga habilidades, comandos y ganchos de ECC. Ejecutar el instalador completo después de una instalación por plugin copia esas mismas superficies en tus directorios de usuario y puede crear habilidades duplicadas además de comportamiento duplicado en tiempo de ejecución.
>
> Para instalaciones por plugin, copia manualmente solo los directorios `rules/` que quieras bajo `~/.claude/rules/ecc/`. Comienza con `rules/common` más un paquete de idioma o framework que realmente uses. No copies todos los directorios de reglas a menos que explícitamente quieras todo ese contexto en Claude.
>
> Usa el instalador completo solo cuando hagas una instalación totalmente manual de ECC en lugar de la vía del plugin.
>
> Si tu configuración local de Claude fue borrada o reiniciada, eso no significa que necesites recomprar ECC. Empieza con `node scripts/ecc.js list-installed`, luego ejecuta `node scripts/ecc.js doctor` y `node scripts/ecc.js repair` antes de reinstalar algo. Eso usualmente restaura archivos gestionados por ECC sin reconstruir tu configuración. Si el problema es acceso a cuenta o mercado para ECC Tools, maneja la recuperación de facturación/cuenta por separado.

```bash
# Clone the repo first
git clone https://github.com/affaan-m/everything-claude-code.git
cd everything-claude-code

# Install dependencies (pick your package manager)
npm install        # or: pnpm install | yarn install | bun install

# Plugin install path: copy only ECC rules into an ECC-owned namespace
mkdir -p ~/.claude/rules/ecc
cp -R rules/common ~/.claude/rules/ecc/
cp -R rules/typescript ~/.claude/rules/ecc/

# Fully manual ECC install path (use this instead of /plugin install)
# ./install.sh --profile full
```

```powershell
# Windows PowerShell

# Plugin install path: copy only ECC rules into an ECC-owned namespace
New-Item -ItemType Directory -Force -Path "$HOME/.claude/rules/ecc" | Out-Null
Copy-Item -Recurse rules/common "$HOME/.claude/rules/ecc/"
Copy-Item -Recurse rules/typescript "$HOME/.claude/rules/ecc/"

# Fully manual ECC install path (use this instead of /plugin install)
# .\install.ps1 --profile full
# npx ecc-install --profile full
```

Para instrucciones de instalación manual, consulte el README en la carpeta `rules/`. Al copiar reglas manualmente, copie todo el directorio del lenguaje (por ejemplo `rules/common` o `rules/golang`), no los archivos dentro de él, para que las referencias relativas sigan funcionando y los nombres de archivo no colisionen.

### Instalación completamente manual (Alternativa)

Utilice esto solo si está omitiendo intencionalmente la ruta del complemento:

```bash
./install.sh --profile full
```

```powershell
.\install.ps1 --profile full
# or
npx ecc-install --profile full
```
Si eliges esta ruta, detente ahí. No ejecutes también `/plugin install`.

### Restablecer / Desinstalar ECC

Si ECC parece duplicado, intrusivo o roto, no sigas reinstalándolo encima de sí mismo.

- **Ruta del plugin:** elimina el plugin de Claude Code, luego borra las carpetas de reglas específicas que copiaste manualmente bajo `~/.claude/rules/ecc/`.
- **Ruta del instalador manual / CLI:** desde la raíz del repositorio, vista previa de la eliminación primero:


```bash
node scripts/uninstall.js --dry-run
```

Luego elimine los archivos gestionados por ECC:

```bash
node scripts/uninstall.js
```

También puedes usar el envoltorio del ciclo de vida:

```bash
node scripts/ecc.js list-installed
node scripts/ecc.js doctor
node scripts/ecc.js repair
node scripts/ecc.js uninstall --dry-run
```

ECC solo elimina los archivos registrados en su estado de instalación. No eliminará archivos no relacionados que no haya instalado.

Si usaste métodos combinados, limpia en este orden:

1. Elimina la instalación del complemento Claude Code.
2. Ejecuta el comando de desinstalación de ECC desde la raíz del repositorio para eliminar los archivos gestionados por el estado de instalación.
3. Borra cualquier carpeta de reglas adicional que copiaste manualmente y que ya no desees.
4. Reinstala una vez, usando una sola ruta.

### Paso 3: Comenzar a usar

```bash
# Skills are the primary workflow surface.
# Existing slash-style command names still work while ECC migrates off commands/.

# Plugin install uses the canonical namespaced form
/everything-claude-code:plan "Add user authentication"

# Manual install keeps the shorter slash form:
# /plan "Add user authentication"

# Check available commands
/plugin list everything-claude-code@everything-claude-code
```

**¡Eso es todo!** Ahora tienes acceso a 48 agentes, 182 habilidades y 68 adaptadores de comandos heredados.

### Interfaz gráfica del panel de control

Lanza el panel de control de escritorio para explorar visualmente los componentes de ECC:

```bash
npm run dashboard
# or
python3 ./ecc_dashboard.py
```

**Características:**
- Interfaz con pestañas: Agentes, Habilidades, Comandos, Reglas, Configuración
- Alternar tema oscuro/claro
- Personalización de fuente (familia y tamaño)
- Logo del proyecto en el encabezado y la barra de tareas
- Búsqueda y filtrado en todos los componentes

### Los comandos multi-modelo requieren configuración adicional

> ADVERTENCIA: los comandos `multi-*` **no** están cubiertos por la instalación base del plugin/reglas mencionada arriba.
>
> Para usar `/multi-plan`, `/multi-execute`, `/multi-backend`, `/multi-frontend` y `/multi-workflow`, también debe instalar el entorno de ejecución `ccg-workflow`.
>
> Inicialícelo con `npx ccg-workflow`.
>
> Ese entorno proporciona las dependencias externas que estos comandos esperan, incluyendo:
> - `~/.claude/bin/codeagent-wrapper`
> - `~/.claude/.ccg/prompts/*`
>
> Sin `ccg-workflow`, estos comandos `multi-*` no funcionarán correctamente.

---

## Soporte multiplataforma

Este plugin ahora soporta completamente **Windows, macOS y Linux**, junto con una integración estrecha en los principales IDEs (Cursor, OpenCode, Antigravity) y entornos CLI. Todos los hooks y scripts han sido reescritos en Node.js para máxima compatibilidad.

### Detección del gestor de paquetes

El plugin detecta automáticamente su gestor de paquetes preferido (npm, pnpm, yarn o bun) con la siguiente prioridad:

1. **Variable de entorno**: `CLAUDE_PACKAGE_MANAGER`
2. **Configuración del proyecto**: `.claude/package-manager.json`
3. **package.json**: campo `packageManager`
4. **Archivo de bloqueo**: detección desde package-lock.json, yarn.lock, pnpm-lock.yaml o bun.lockb
5. **Configuración global**: `~/.claude/package-manager.json`
6. **Alternativa**: primer gestor de paquetes disponible

Para establecer su gestor de paquetes preferido:

```bash
# Via environment variable
export CLAUDE_PACKAGE_MANAGER=pnpm

# Via global config
node scripts/setup-package-manager.js --global pnpm

# Via project config
node scripts/setup-package-manager.js --project bun

# Detect current setting
node scripts/setup-package-manager.js --detect
```

O use el comando `/setup-pm` en Claude Code.

### Controles de ejecución de hooks

Use las banderas de ejecución para ajustar la estricta o deshabilitar hooks específicos temporalmente:

```bash
# Hook strictness profile (default: standard)
export ECC_HOOK_PROFILE=standard

# Comma-separated hook IDs to disable
export ECC_DISABLED_HOOKS="pre:bash:tmux-reminder,post:edit:typecheck"

# Cap SessionStart additional context (default: 8000 chars)
export ECC_SESSION_START_MAX_CHARS=4000

# Disable SessionStart additional context entirely for low-context/local-model setups
export ECC_SESSION_START_CONTEXT=off
```

---

## What's Inside

This repo is a **Claude Code plugin** - install it directly or copy components manually.

```
everything-claude-code/
|-- .claude-plugin/   # Plugin and marketplace manifests
|   |-- plugin.json         # Plugin metadata and component paths
|   |-- marketplace.json    # Marketplace catalog for /plugin marketplace add
|
|-- agents/           # 36 specialized subagents for delegation
|   |-- planner.md           # Feature implementation planning
|   |-- architect.md         # System design decisions
|   |-- tdd-guide.md         # Test-driven development
|   |-- code-reviewer.md     # Quality and security review
|   |-- security-reviewer.md # Vulnerability analysis
|   |-- build-error-resolver.md
|   |-- e2e-runner.md        # Playwright E2E testing
|   |-- refactor-cleaner.md  # Dead code cleanup
|   |-- doc-updater.md       # Documentation sync
|   |-- docs-lookup.md       # Documentation/API lookup
|   |-- chief-of-staff.md    # Communication triage and drafts
|   |-- loop-operator.md     # Autonomous loop execution
|   |-- harness-optimizer.md # Harness config tuning
|   |-- cpp-reviewer.md      # C++ code review
|   |-- cpp-build-resolver.md # C++ build error resolution
|   |-- go-reviewer.md       # Go code review
|   |-- go-build-resolver.md # Go build error resolution
|   |-- python-reviewer.md   # Python code review
|   |-- database-reviewer.md # Database/Supabase review
|   |-- typescript-reviewer.md # TypeScript/JavaScript code review
|   |-- java-reviewer.md     # Java/Spring Boot code review
|   |-- java-build-resolver.md # Java/Maven/Gradle build errors
|   |-- kotlin-reviewer.md   # Kotlin/Android/KMP code review
|   |-- kotlin-build-resolver.md # Kotlin/Gradle build errors
|   |-- rust-reviewer.md     # Rust code review
|   |-- rust-build-resolver.md # Rust build error resolution
|   |-- pytorch-build-resolver.md # PyTorch/CUDA training errors
|
|-- skills/           # Workflow definitions and domain knowledge
|   |-- coding-standards/           # Language best practices
|   |-- clickhouse-io/              # ClickHouse analytics, queries, data engineering
|   |-- backend-patterns/           # API, database, caching patterns
|   |-- frontend-patterns/          # React, Next.js patterns
|   |-- frontend-slides/            # HTML slide decks and PPTX-to-web presentation workflows (NEW)
|   |-- article-writing/            # Long-form writing in a supplied voice without generic AI tone (NEW)
|   |-- content-engine/             # Multi-platform social content and repurposing workflows (NEW)
|   |-- market-research/            # Source-attributed market, competitor, and investor research (NEW)
|   |-- investor-materials/         # Pitch decks, one-pagers, memos, and financial models (NEW)
|   |-- investor-outreach/          # Personalized fundraising outreach and follow-up (NEW)
|   |-- continuous-learning/        # Legacy v1 Stop-hook pattern extraction
|   |-- continuous-learning-v2/     # Instinct-based learning with confidence scoring
|   |-- iterative-retrieval/        # Progressive context refinement for subagents
|   |-- strategic-compact/          # Manual compaction suggestions (Longform Guide)
|   |-- tdd-workflow/               # TDD methodology
|   |-- security-review/            # Security checklist
|   |-- eval-harness/               # Verification loop evaluation (Longform Guide)
|   |-- verification-loop/          # Continuous verification (Longform Guide)
|   |-- videodb/                   # Video and audio: ingest, search, edit, generate, stream (NEW)
|   |-- golang-patterns/            # Go idioms and best practices
|   |-- golang-testing/             # Go testing patterns, TDD, benchmarks
|   |-- cpp-coding-standards/         # C++ coding standards from C++ Core Guidelines (NEW)
|   |-- cpp-testing/                # C++ testing with GoogleTest, CMake/CTest (NEW)
|   |-- django-patterns/            # Django patterns, models, views (NEW)
|   |-- django-security/            # Django security best practices (NEW)
|   |-- django-tdd/                 # Django TDD workflow (NEW)
|   |-- django-verification/        # Django verification loops (NEW)
|   |-- laravel-patterns/           # Laravel architecture patterns (NEW)
|   |-- laravel-security/           # Laravel security best practices (NEW)
|   |-- laravel-tdd/                # Laravel TDD workflow (NEW)
|   |-- laravel-verification/       # Laravel verification loops (NEW)
|   |-- python-patterns/            # Python idioms and best practices (NEW)
|   |-- python-testing/             # Python testing with pytest (NEW)
|   |-- springboot-patterns/        # Java Spring Boot patterns (NEW)
|   |-- springboot-security/        # Spring Boot security (NEW)
|   |-- springboot-tdd/             # Spring Boot TDD (NEW)
|   |-- springboot-verification/    # Spring Boot verification (NEW)
|   |-- configure-ecc/              # Interactive installation wizard (NEW)
|   |-- security-scan/              # AgentShield security auditor integration (NEW)
|   |-- java-coding-standards/     # Java coding standards (NEW)
|   |-- jpa-patterns/              # JPA/Hibernate patterns (NEW)
|   |-- postgres-patterns/         # PostgreSQL optimization patterns (NEW)
|   |-- nutrient-document-processing/ # Document processing with Nutrient API (NEW)
|   |-- docs/examples/project-guidelines-template.md  # Template for project-specific skills
|   |-- database-migrations/         # Migration patterns (Prisma, Drizzle, Django, Go) (NEW)
|   |-- api-design/                  # REST API design, pagination, error responses (NEW)
|   |-- deployment-patterns/         # CI/CD, Docker, health checks, rollbacks (NEW)
|   |-- docker-patterns/            # Docker Compose, networking, volumes, container security (NEW)
|   |-- e2e-testing/                 # Playwright E2E patterns and Page Object Model (NEW)
|   |-- content-hash-cache-pattern/  # SHA-256 content hash caching for file processing (NEW)
|   |-- cost-aware-llm-pipeline/     # LLM cost optimization, model routing, budget tracking (NEW)
|   |-- regex-vs-llm-structured-text/ # Decision framework: regex vs LLM for text parsing (NEW)
|   |-- swift-actor-persistence/     # Thread-safe Swift data persistence with actors (NEW)
|   |-- swift-protocol-di-testing/   # Protocol-based DI for testable Swift code (NEW)
|   |-- search-first/               # Research-before-coding workflow (NEW)
|   |-- skill-stocktake/            # Audit skills and commands for quality (NEW)
|   |-- liquid-glass-design/         # iOS 26 Liquid Glass design system (NEW)
|   |-- foundation-models-on-device/ # Apple on-device LLM with FoundationModels (NEW)
|   |-- swift-concurrency-6-2/       # Swift 6.2 Approachable Concurrency (NEW)
|   |-- perl-patterns/             # Modern Perl 5.36+ idioms and best practices (NEW)
|   |-- perl-security/             # Perl security patterns, taint mode, safe I/O (NEW)
|   |-- perl-testing/              # Perl TDD with Test2::V0, prove, Devel::Cover (NEW)
|   |-- autonomous-loops/           # Autonomous loop patterns: sequential pipelines, PR loops, DAG orchestration (NEW)
|   |-- plankton-code-quality/      # Write-time code quality enforcement with Plankton hooks (NEW)
|
|-- commands/         # Maintained slash-entry compatibility; prefer skills/
|   |-- plan.md             # /plan - Implementation planning
|   |-- code-review.md      # /code-review - Quality review
|   |-- build-fix.md        # /build-fix - Fix build errors
|   |-- refactor-clean.md   # /refactor-clean - Dead code removal
|   |-- quality-gate.md     # /quality-gate - Verification gate
|   |-- learn.md            # /learn - Extract patterns mid-session (Longform Guide)
|   |-- learn-eval.md       # /learn-eval - Extract, evaluate, and save patterns (NEW)
|   |-- checkpoint.md       # /checkpoint - Save verification state (Longform Guide)
|   |-- setup-pm.md         # /setup-pm - Configure package manager
|   |-- go-review.md        # /go-review - Go code review (NEW)
|   |-- go-test.md          # /go-test - Go TDD workflow (NEW)
|   |-- go-build.md         # /go-build - Fix Go build errors (NEW)
|   |-- skill-create.md     # /skill-create - Generate skills from git history (NEW)
|   |-- instinct-status.md  # /instinct-status - View learned instincts (NEW)
|   |-- instinct-import.md  # /instinct-import - Import instincts (NEW)
|   |-- instinct-export.md  # /instinct-export - Export instincts (NEW)
|   |-- evolve.md           # /evolve - Cluster instincts into skills
|   |-- prune.md            # /prune - Delete expired pending instincts (NEW)
|   |-- pm2.md              # /pm2 - PM2 service lifecycle management (NEW)
|   |-- multi-plan.md       # /multi-plan - Multi-agent task decomposition (NEW)
|   |-- multi-execute.md    # /multi-execute - Orchestrated multi-agent workflows (NEW)
|   |-- multi-backend.md    # /multi-backend - Backend multi-service orchestration (NEW)
|   |-- multi-frontend.md   # /multi-frontend - Frontend multi-service orchestration (NEW)
|   |-- multi-workflow.md   # /multi-workflow - General multi-service workflows (NEW)
|   |-- sessions.md         # /sessions - Session history management
|   |-- test-coverage.md    # /test-coverage - Test coverage analysis
|   |-- update-docs.md      # /update-docs - Update documentation
|   |-- update-codemaps.md  # /update-codemaps - Update codemaps
|   |-- python-review.md    # /python-review - Python code review (NEW)
|-- legacy-command-shims/   # Opt-in archive for retired shims such as /tdd and /eval
|   |-- tdd.md              # /tdd - Prefer the tdd-workflow skill
|   |-- e2e.md              # /e2e - Prefer the e2e-testing skill
|   |-- eval.md             # /eval - Prefer the eval-harness skill
|   |-- verify.md           # /verify - Prefer the verification-loop skill
|   |-- orchestrate.md      # /orchestrate - Prefer dmux-workflows or multi-workflow
|
|-- rules/            # Always-follow guidelines (copy to ~/.claude/rules/ecc/)
|   |-- README.md            # Structure overview and installation guide
|   |-- common/              # Language-agnostic principles
|   |   |-- coding-style.md    # Immutability, file organization
|   |   |-- git-workflow.md    # Commit format, PR process
|   |   |-- testing.md         # TDD, 80% coverage requirement
|   |   |-- performance.md     # Model selection, context management
|   |   |-- patterns.md        # Design patterns, skeleton projects
|   |   |-- hooks.md           # Hook architecture, TodoWrite
|   |   |-- agents.md          # When to delegate to subagents
|   |   |-- security.md        # Mandatory security checks
|   |-- typescript/          # TypeScript/JavaScript specific
|   |-- python/              # Python specific
|   |-- golang/              # Go specific
|   |-- swift/               # Swift specific
|   |-- php/                 # PHP specific (NEW)
|
|-- hooks/            # Trigger-based automations
|   |-- README.md                 # Hook documentation, recipes, and customization guide
|   |-- hooks.json                # All hooks config (PreToolUse, PostToolUse, Stop, etc.)
|   |-- memory-persistence/       # Session lifecycle hooks (Longform Guide)
|   |-- strategic-compact/        # Compaction suggestions (Longform Guide)
|
|-- scripts/          # Cross-platform Node.js scripts (NEW)
|   |-- lib/                     # Shared utilities
|   |   |-- utils.js             # Cross-platform file/path/system utilities
|   |   |-- package-manager.js   # Package manager detection and selection
|   |-- hooks/                   # Hook implementations
|   |   |-- session-start.js     # Load context on session start
|   |   |-- session-end.js       # Save state on session end
|   |   |-- pre-compact.js       # Pre-compaction state saving
|   |   |-- suggest-compact.js   # Strategic compaction suggestions
|   |   |-- evaluate-session.js  # Extract patterns from sessions
|   |-- setup-package-manager.js # Interactive PM setup
|
|-- tests/            # Test suite (NEW)
|   |-- lib/                     # Library tests
|   |-- hooks/                   # Hook tests
|   |-- run-all.js               # Run all tests
|
|-- contexts/         # Dynamic system prompt injection contexts (Longform Guide)
|   |-- dev.md              # Development mode context
|   |-- review.md           # Code review mode context
|   |-- research.md         # Research/exploration mode context
|
|-- examples/         # Example configurations and sessions
|   |-- CLAUDE.md             # Example project-level config
|   |-- user-CLAUDE.md        # Example user-level config
|   |-- saas-nextjs-CLAUDE.md   # Real-world SaaS (Next.js + Supabase + Stripe)
|   |-- go-microservice-CLAUDE.md # Real-world Go microservice (gRPC + PostgreSQL)
|   |-- django-api-CLAUDE.md      # Real-world Django REST API (DRF + Celery)
|   |-- laravel-api-CLAUDE.md     # Real-world Laravel API (PostgreSQL + Redis) (NEW)
|   |-- rust-api-CLAUDE.md        # Real-world Rust API (Axum + SQLx + PostgreSQL) (NEW)
|
|-- mcp-configs/      # MCP server configurations
|   |-- mcp-servers.json    # GitHub, Supabase, Vercel, Railway, etc.
|
|-- ecc_dashboard.py  # Desktop GUI dashboard (Tkinter)
|
|-- assets/           # Assets for dashboard
|   |-- images/
|       |-- ecc-logo.png
|
|-- marketplace.json  # Self-hosted marketplace config (for /plugin marketplace add)
```

---

## Herramientas del Ecosistema

### Creador de Habilidades

Dos formas de generar habilidades Claude Code desde tu repositorio:

#### Opción A: Análisis Local (Incorporado)

Usa el comando `/skill-create` para análisis local sin servicios externos:

```bash
/skill-create                    # Analyze current repo
/skill-create --instincts        # Also generate instincts for continuous-learning-v2
```

Esto analiza tu historial de git localmente y genera archivos SKILL.md.

#### Opción B: Aplicación de GitHub (Avanzado)

Para funciones avanzadas (más de 10k commits, PRs automáticos, compartir en equipo):

[Instalar Aplicación de GitHub](https://github.com/apps/skill-creator) | [ecc.tools](https://ecc.tools)

```bash
# Comment on any issue:
/skill-creator analyze

# Or auto-triggers on push to default branch
```

Ambas opciones crean:
- **Archivos SKILL.md** - Habilidades listas para usar en Claude Code
- **Colecciones Instinct** - Para continuous-learning-v2
- **Extracción de patrones** - Aprende de tu historial de commits

### AgentShield — Auditor de Seguridad

> Construido en el Hackathon Claude Code (Cerebral Valley x Anthropic, feb 2026). 1282 pruebas, 98% de cobertura, 102 reglas de análisis estático.

Escanea tu configuración de Claude Code en busca de vulnerabilidades, configuraciones erróneas y riesgos de inyección.

```bash
# Quick scan (no install needed)
npx ecc-agentshield scan

# Auto-fix safe issues
npx ecc-agentshield scan --fix

# Deep analysis with three Opus 4.6 agents
npx ecc-agentshield scan --opus --stream

# Generate secure config from scratch
npx ecc-agentshield init
```

**Qué escanea:** CLAUDE.md, settings.json, configuraciones MCP, hooks, definiciones de agentes y habilidades en 5 categorías — detección de secretos (14 patrones), auditoría de permisos, análisis de inyección de hooks, perfilado de riesgos del servidor MCP y revisión de configuración de agentes.

**La bandera `--opus`** ejecuta tres agentes Claude Opus 4.6 en una cadena rojo-azul-auditor. El atacante encuentra cadenas de explotación, el defensor evalúa protecciones y el auditor sintetiza ambos en una evaluación de riesgos priorizada. Razonamiento adversarial, no solo coincidencia de patrones.

**Formatos de salida:** Terminal (clasificación por colores A-F), JSON (pipelines CI), Markdown, HTML. Código de salida 2 en hallazgos críticos para puertas de compilación.

Usa `/security-scan` en Claude Code para ejecutarlo, o añádelo al CI con la [Acción de GitHub](https://github.com/affaan-m/agentshield).

[GitHub](https://github.com/affaan-m/agentshield) | [npm](https://www.npmjs.com/package/ecc-agentshield)

### Aprendizaje Continuo v2

El sistema de aprendizaje basado en instinto aprende automáticamente tus patrones:

```bash
/instinct-status        # Show learned instincts with confidence
/instinct-import <file> # Import instincts from others
/instinct-export        # Export your instincts for sharing
/evolve                 # Cluster related instincts into skills
```

Consulte `skills/continuous-learning-v2/` para la documentación completa.  
Mantenga `continuous-learning/` solo cuando desee explícitamente el flujo de habilidad aprendida con gancho de detención de la versión heredada v1.

---

## Requisitos

### Versión del CLI de Claude Code

**Versión mínima: v2.1.0 o superior**

Este plugin requiere Claude Code CLI v2.1.0+ debido a cambios en cómo el sistema de plugins maneja los ganchos.

Verifique su versión:
```bash
claude --version
```

### Importante: Comportamiento de Carga Automática de Hooks

> ADVERTENCIA: **Para Colaboradores:** NO agregue un campo `"hooks"` a `.claude-plugin/plugin.json`. Esto es comprobado por una prueba de regresión.

Claude Code v2.1+ **carga automáticamente** `hooks/hooks.json` de cualquier plugin instalado por convención. Declararlo explícitamente en `plugin.json` causa un error de detección de duplicados:

```
Duplicate hooks file detected: ./hooks/hooks.json resolves to already-loaded file
```

**Historial:** Esto ha causado ciclos repetidos de corrección/reversión en este repositorio ([#29](https://github.com/affaan-m/everything-claude-code/issues/29), [#52](https://github.com/affaan-m/everything-claude-code/issues/52), [#103](https://github.com/affaan-m/everything-claude-code/issues/103)). El comportamiento cambió entre versiones de Claude Code, lo que llevó a confusión. Ahora tenemos una prueba de regresión para evitar que esto se reintroduzca.

---

## Instalación

### Opción 1: Instalar como Plugin (Recomendado)

La forma más fácil de usar este repositorio: instalar como un plugin de Claude Code:

```bash
# Add this repo as a marketplace
/plugin marketplace add https://github.com/affaan-m/everything-claude-code

# Install the plugin
/plugin install everything-claude-code@everything-claude-code
```
O agrégalo directamente a tu `~/.claude/settings.json`:


```json
{
  "extraKnownMarketplaces": {
    "ecc": {
      "source": {
        "source": "github",
        "repo": "affaan-m/everything-claude-code"
      }
    }
  },
  "enabledPlugins": {
    "everything-claude-code@everything-claude-code": true
  }
}
```
Esto le da acceso instantáneo a todos los comandos, agentes, habilidades y hooks.

> **Nota:** El sistema de plugins de Claude Code no soporta la distribución de `rules` mediante plugins ([limitación upstream](https://code.claude.com/docs/en/plugins-reference)). Necesita instalar las reglas manualmente:
>
> ```bash
> # Clonar el repositorio primero
> git clone https://github.com/affaan-m/everything-claude-code.git
>
> # Opción A: Reglas a nivel de usuario (aplica a todos los proyectos)
> mkdir -p ~/.claude/rules/ecc
> cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/typescript ~/.claude/rules/ecc/   # elija su stack
> cp -r everything-claude-code/rules/python ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/golang ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/php ~/.claude/rules/ecc/
>
> # Opción B: Reglas a nivel de proyecto (aplica solo al proyecto actual)
> mkdir -p .claude/rules/ecc
> cp -r everything-claude-code/rules/common .claude/rules/ecc/
> cp -r everything-claude-code/rules/typescript .claude/rules/ecc/     # elija su stack
> ```

---

### Opción 2: Instalación Manual

Si prefiere control manual sobre lo que se instala:


```bash
# Clone the repo
git clone https://github.com/affaan-m/everything-claude-code.git

# Copy agents to your Claude config
cp everything-claude-code/agents/*.md ~/.claude/agents/

# Copy rules directories (common + language-specific)
mkdir -p ~/.claude/rules/ecc
cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/typescript ~/.claude/rules/ecc/   # pick your stack
cp -r everything-claude-code/rules/python ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/golang ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/php ~/.claude/rules/ecc/

# Copy skills first (primary workflow surface)
# Recommended (new users): core/general skills only
mkdir -p ~/.claude/skills/ecc
cp -r everything-claude-code/.agents/skills/* ~/.claude/skills/ecc/
cp -r everything-claude-code/skills/search-first ~/.claude/skills/ecc/

# Optional: add niche/framework-specific skills only when needed
# for s in django-patterns django-tdd laravel-patterns springboot-patterns; do
# cp -r everything-claude-code/skills/$s ~/.claude/skills/ecc/
# done

# Optional: keep maintained slash-command compatibility during migration
mkdir -p ~/.claude/commands
cp everything-claude-code/commands/*.md ~/.claude/commands/

# Retired shims live in legacy-command-shims/commands/.
# Copy individual files from there only if you still need old names such as /tdd.
```

#### Instalar hooks

No copie el archivo bruto del repositorio `hooks/hooks.json` en `~/.claude/settings.json` o `~/.claude/hooks/hooks.json`. Ese archivo está orientado a plugins/repositorios y está destinado a ser instalado mediante el instalador ECC o cargado como un plugin, por lo que la copia directa no es un método de instalación manual compatible.

Utilice el instalador para instalar solo el entorno de ejecución del hook de Claude para que las rutas de los comandos se reescriban correctamente:

```bash
# macOS / Linux
bash ./install.sh --target claude --modules hooks-runtime
```

```powershell
# Windows PowerShell
pwsh -File .\install.ps1 --target claude --modules hooks-runtime
```

Eso escribe los hooks resueltos en `~/.claude/hooks/hooks.json` y deja intacto cualquier `~/.claude/settings.json` existente.

Si instalaste ECC mediante `/plugin install`, no copies esos hooks en `settings.json`. Claude Code v2.1+ ya carga automáticamente el plugin `hooks/hooks.json`, y duplicarlos en `settings.json` causa ejecuciones duplicadas y conflictos de hooks multiplataforma.

Nota para Windows: el directorio de configuración de Claude es `%USERPROFILE%\\.claude`, no `~/claude`.

#### Configurar MCPs

Las instalaciones de plugins de Claude intencionalmente no habilitan automáticamente las definiciones de servidor MCP incluidas en ECC. Esto evita nombres excesivamente largos de herramientas MCP en gateways estrictos de terceros mientras mantiene disponible la configuración manual de MCP.

Usa el comando `/mcp` de Claude Code o la configuración MCP gestionada por CLI para cambios en vivo del servidor Claude Code. Usa `/mcp` para deshabilitaciones en tiempo de ejecución de Claude Code; Claude Code persiste esas elecciones en `~/.claude.json`.

Para acceso MCP local al repositorio, copia las definiciones de servidor MCP deseadas de `mcp-configs/mcp-servers.json` a un `.mcp.json` con alcance al proyecto.

Si ya ejecutas tus propias copias de MCPs incluidos en ECC, configura:

```bash
export ECC_DISABLED_MCPS="github,context7,exa,playwright,sequential-thinking,memory"
```

Los flujos de instalación gestionados por ECC y sincronización de Codex omitirán o eliminarán esos servidores agrupados en lugar de volver a agregar duplicados. `ECC_DISABLED_MCPS` es un filtro de instalación/sincronización de ECC, no un interruptor en vivo de Claude Code.

**Importante:** Reemplace los marcadores de posición `YOUR_*_HERE` con sus claves API reales.

---

## Conceptos clave

### Agentes

Los subagentes manejan tareas delegadas con un alcance limitado. Ejemplo:

```markdown
---
name: code-reviewer
description: Reviews code for quality, security, and maintainability
tools: ["Read", "Grep", "Glob", "Bash"]
model: opus
---

You are a senior code reviewer...
```

### Habilidades

Las habilidades son la superficie principal del flujo de trabajo. Se pueden invocar directamente, sugerir automáticamente y reutilizar por agentes. ECC aún mantiene `commands/` durante la migración, mientras que los adaptadores de nombres cortos retirados viven bajo `legacy-command-shims/` solo para inclusión explícita. El desarrollo de nuevos flujos de trabajo debe comenzar primero en `skills/`.

```markdown
# TDD Workflow

1. Define interfaces first
2. Write failing tests (RED)
3. Implement minimal code (GREEN)
4. Refactor (IMPROVE)
5. Verify 80%+ coverage
```

### Hooks

Los hooks se activan en eventos de herramientas. Ejemplo: advertir sobre console.log:

```json
{
  "matcher": "tool == \"Edit\" && tool_input.file_path matches \"\\\\.(ts|tsx|js|jsx)$\"",
  "hooks": [{
    "type": "command",
    "command": "#!/bin/bash\ngrep -n 'console\\.log' \"$file_path\" && echo '[Hook] Remove console.log' >&2"
  }]
}
```

### Reglas

Las reglas son pautas que se siguen siempre, organizadas en directorios `common/` (independientes del lenguaje) + específicos para cada lenguaje:

```
rules/
  common/          # Universal principles (always install)
  typescript/      # TS/JS specific patterns and tools
  python/          # Python specific patterns and tools
  golang/          # Go specific patterns and tools
  swift/           # Swift specific patterns and tools
  php/             # PHP specific patterns and tools
```

Consulta [`rules/README.md`](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/rules/README.md) para detalles de instalación y estructura.

---

## ¿Qué Agente Debo Usar?

¿No sabes por dónde empezar? Usa esta referencia rápida. Las habilidades son la superficie canónica del flujo de trabajo; las entradas slash mantenidas siguen disponibles para flujos de trabajo basados en comandos.

| Quiero... | Usa esta superficie | Agente usado |
|--------------|-----------------|------------|
| Planear una nueva función | `/everything-claude-code:plan "Añadir autenticación"` | planificador |
| Diseñar arquitectura del sistema | `/everything-claude-code:plan` + agente arquitecto | arquitecto |
| Escribir código con pruebas primero | habilidad `tdd-workflow` | guía-tdd |
| Revisar código que acabo de escribir | `/code-review` | revisor-código |
| Arreglar una compilación fallida | `/build-fix` | resolvedor-error-compilación |
| Ejecutar pruebas de extremo a extremo | habilidad `e2e-testing` | ejecutor-e2e |
| Encontrar vulnerabilidades de seguridad | `/security-scan` | revisor-seguridad |
| Eliminar código muerto | `/refactor-clean` | limpiador-refactor |
| Actualizar documentación | `/update-docs` | actualizador-docs |
| Revisar código Go | `/go-review` | revisor-go |
| Revisar código Python | `/python-review` | revisor-python |
| Revisar código TypeScript/JavaScript | *(invocar `typescript-reviewer` directamente)* | revisor-typescript |
| Auditar consultas a base de datos | *(delegado automáticamente)* | revisor-base-datos |

### Flujos de Trabajo Comunes

Las formas slash abajo se muestran donde siguen siendo parte de la superficie de comandos mantenida. Los adaptadores de nombres cortos retirados como `/tdd` y `/eval` viven en `legacy-command-shims/` para opt-in explícito únicamente.

**Iniciar una nueva función:**
```
/everything-claude-code:plan "Add user authentication with OAuth"
                                              → planner creates implementation blueprint
tdd-workflow skill                            → tdd-guide enforces write-tests-first
/code-review                                  → code-reviewer checks your work
```

**Corrección de un error:**
```
tdd-workflow skill                            → tdd-guide: write a failing test that reproduces it
                                              → implement the fix, verify test passes
/code-review                                  → code-reviewer: catch regressions
```

**Preparándose para la producción:**
```
/security-scan                                → security-reviewer: OWASP Top 10 audit
e2e-testing skill                             → e2e-runner: critical user flow tests
/test-coverage                                → verify 80%+ coverage
```

---

## FAQ

<details>
<summary><b>How do I check which agents/commands are installed?</b></summary>

```bash
/plugin list everything-claude-code@everything-claude-code
```

Esto muestra todos los agentes, comandos y habilidades disponibles del plugin.
</details>

<details>
<summary><b>Mis hooks no funcionan / Veo errores de "Archivo de hooks duplicado"</b></summary>

Este es el problema más común. **NO agregue un campo `"hooks"` a `.claude-plugin/plugin.json`.** Claude Code v2.1+ carga automáticamente `hooks/hooks.json` de los plugins instalados. Declararlo explícitamente causa errores de detección de duplicados. Vea [#29](https://github.com/affaan-m/everything-claude-code/issues/29), [#52](https://github.com/affaan-m/everything-claude-code/issues/52), [#103](https://github.com/affaan-m/everything-claude-code/issues/103).
</details>

<details>
<summary><b>¿Puedo usar ECC con Claude Code en un endpoint de API personalizado o gateway de modelo?</b></summary>

Sí. ECC no codifica de forma fija los ajustes de transporte alojados por Anthropic. Se ejecuta localmente a través de la interfaz CLI/plugin normal de Claude Code, por lo que funciona con:

- Claude Code alojado por Anthropic
- Configuraciones oficiales de gateway de Claude Code usando `ANTHROPIC_BASE_URL` y `ANTHROPIC_AUTH_TOKEN`
- Endpoints personalizados compatibles que hablen la API de Anthropic que Claude Code espera

Ejemplo mínimo:

```bash
export ANTHROPIC_BASE_URL=https://your-gateway.example.com
export ANTHROPIC_AUTH_TOKEN=your-token
claude
```
Si su gateway reasigna nombres de modelos, configure eso en Claude Code en lugar de en ECC. Los hooks, habilidades, comandos y reglas de ECC son independientes del proveedor del modelo una vez que la CLI `claude` ya está funcionando.

Referencias oficiales:  
- [Documentación del gateway LLM de Claude Code](https://docs.anthropic.com/en/docs/claude-code/llm-gateway)  
- [Documentación de configuración de modelos de Claude Code](https://docs.anthropic.com/en/docs/claude-code/model-config)  

</details>  

<details>  
<summary><b>Mi ventana de contexto se está reduciendo / Claude se está quedando sin contexto</b></summary>  

Demasiados servidores MCP consumen tu contexto. Cada descripción de herramienta MCP consume tokens de tu ventana de 200k, potencialmente reduciéndola a ~70k. El contexto de SessionStart está limitado a 8000 caracteres por defecto; redúcelo con `ECC_SESSION_START_MAX_CHARS=4000` o desactívalo con `ECC_SESSION_START_CONTEXT=off` para configuraciones con modelos locales o poco contexto.  

**Solución:** Desactiva MCPs no usados en Claude Code con `/mcp`. Claude Code guarda esas elecciones de tiempo de ejecución en `~/.claude.json`; `.claude/settings.json` y `.claude/settings.local.json` no son interruptores confiables para MCPs ya cargados.  

Mantén menos de 10 MCPs activados y menos de 80 herramientas activas.  
</details>  

<details>  
<summary><b>¿Puedo usar solo algunos componentes (por ejemplo, solo agentes)?</b></summary>  

Sí. Usa la Opción 2 (instalación manual) y copia solo lo que necesites:  


```bash
# Just agents
cp everything-claude-code/agents/*.md ~/.claude/agents/

# Just rules
mkdir -p ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
```

Cada componente es completamente independiente.
</details>

<details>
<summary><b>¿Funciona esto con Cursor / OpenCode / Codex / Antigravity?</b></summary>

Sí. ECC es multiplataforma:
- **Cursor**: Configuraciones pre-traducidas en `.cursor/`. Véase [Soporte para Cursor IDE](#cursor-ide-support).
- **Gemini CLI**: Soporte experimental local por proyecto vía `.gemini/GEMINI.md` y tuberías compartidas del instalador.
- **OpenCode**: Soporte completo de plugins en `.opencode/`. Véase [Soporte para OpenCode](#opencode-support).
- **Codex**: Soporte de primera clase tanto para la app macOS como CLI, con guardias de deriva del adaptador y fallback SessionStart. Véase PR [#257](https://github.com/affaan-m/everything-claude-code/pull/257).
- **Antigravity**: Configuración estrechamente integrada para flujos de trabajo, habilidades y reglas aplanadas en `.agent/`. Véase [Guía de Antigravity](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ANTIGRAVITY-GUIDE.md).
- **Entornos no nativos**: Ruta de fallback manual para Grok e interfaces similares. Véase [Guía de Adaptación Manual](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/MANUAL-ADAPTATION-GUIDE.md).
- **Claude Code**: Nativo — este es el objetivo principal.
</details>

<details>
<summary><b>¿Cómo contribuyo con una nueva habilidad o agente?</b></summary>

Véase [CONTRIBUTING.md](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/CONTRIBUTING.md). La versión corta:
1. Haz un fork del repositorio
2. Crea tu habilidad en `skills/your-skill-name/SKILL.md` (con frontmatter YAML)
3. O crea un agente en `agents/your-agent.md`
4. Envía un PR con una descripción clara de lo que hace y cuándo usarlo
</details>

---

## Ejecutando pruebas

El plugin incluye un conjunto completo de pruebas:

```bash
# Run all tests
node tests/run-all.js

# Run individual test files
node tests/lib/utils.test.js
node tests/lib/package-manager.test.js
node tests/hooks/hooks.test.js
```

---

## Contribuir

**Se agradecen y fomentan las contribuciones.**

Este repositorio está pensado para ser un recurso comunitario. Si tienes:
- Agentes o habilidades útiles
- Hooks ingeniosos
- Mejores configuraciones MCP
- Reglas mejoradas

¡Por favor contribuye! Consulta [CONTRIBUTING.md](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/CONTRIBUTING.md) para las directrices.

### Ideas para Contribuciones

- Habilidades específicas de lenguaje (Rust, C#, Kotlin, Java) — Go, Python, Perl, Swift y TypeScript ya incluidos
- Configuraciones específicas de frameworks (Rails, FastAPI) — Django, NestJS, Spring Boot y Laravel ya incluidos
- Agentes DevOps (Kubernetes, Terraform, AWS, Docker)
- Estrategias de pruebas (diferentes frameworks, regresión visual)
- Conocimiento específico del dominio (ML, ingeniería de datos, móvil)

### Notas sobre el Ecosistema Comunitario

Estos no están incluidos con ECC y no son auditados por este repositorio, pero vale la pena conocerlos si exploras el ecosistema más amplio de habilidades Claude Code:

- [claude-seo](https://github.com/AgriciDaniel/claude-seo) — Colección de habilidades y agentes enfocados en SEO
- [claude-ads](https://github.com/AgriciDaniel/claude-ads) — Colección de auditoría de anuncios y flujos de trabajo de crecimiento pagado
- [claude-cybersecurity](https://github.com/AgriciDaniel/claude-cybersecurity) — Colección de habilidades y agentes orientados a la seguridad

---

## Soporte de Cursor IDE

ECC proporciona soporte para Cursor IDE con hooks, reglas, agentes, habilidades, comandos y configuraciones MCP adaptadas para la estructura de proyectos de Cursor.

### Inicio Rápido (Cursor)

```bash
# macOS/Linux
./install.sh --target cursor typescript
./install.sh --target cursor python golang swift php
```

```powershell
# Windows PowerShell
.\install.ps1 --target cursor typescript
.\install.ps1 --target cursor python golang swift php
```
### Qué Incluye

| Componente | Cantidad | Detalles |
|------------|----------|----------|
| Eventos de Hook | 15 | sessionStart, beforeShellExecution, afterFileEdit, beforeMCPExecution, beforeSubmitPrompt, y 10 más |
| Scripts de Hook | 16 | Scripts delgados de Node.js que delegan a `scripts/hooks/` mediante un adaptador compartido |
| Reglas | 34 | 9 comunes (alwaysApply) + 25 específicos de lenguaje (TypeScript, Python, Go, Swift, PHP) |
| Agentes | 48 | `.cursor/agents/ecc-*.md` cuando están instalados; prefijados para evitar colisiones con agentes de usuario o marketplace |
| Habilidades | Compartidas + Empaquetadas | `.cursor/skills/` para adiciones traducidas |
| Comandos | Compartidos | `.cursor/commands/` si están instalados |
| Configuración MCP | Compartida | `.cursor/mcp.json` si está instalado |

### Notas sobre la Carga de Cursor

ECC no instala `AGENTS.md` raíz en `.cursor/`. Cursor trata archivos `AGENTS.md` anidados como contexto de directorio, por lo que copiar la identidad del repositorio ECC en un proyecto anfitrión contaminaría ese proyecto.

El comportamiento nativo de carga de Cursor puede variar según la versión de Cursor. ECC instala agentes como `.cursor/agents/ecc-*.md`; si tu versión de Cursor no expone agentes de proyecto, esos archivos aún funcionan como definiciones de referencia explícitas en lugar de contexto global oculto de prompt.

### Arquitectura de Hook (Patrón Adaptador DRY)

Cursor tiene **más eventos de hook que Claude Code** (20 vs 8). El módulo `.cursor/hooks/adapter.js` transforma el JSON de entrada estándar de Cursor al formato de Claude Code, permitiendo reutilizar `scripts/hooks/*.js` existentes sin duplicación.


```
Cursor stdin JSON → adapter.js → transforms → scripts/hooks/*.js
                                              (shared with Claude Code)
```

Hooks clave:
- **beforeShellExecution** — Bloquea servidores de desarrollo fuera de tmux (salida 2), revisión de git push
- **afterFileEdit** — Formateo automático + chequeo de TypeScript + advertencia de console.log
- **beforeSubmitPrompt** — Detecta secretos (patrones sk-, ghp_, AKIA) en las solicitudes
- **beforeTabFileRead** — Bloquea que Tab lea archivos .env, .key, .pem (salida 2)
- **beforeMCPExecution / afterMCPExecution** — Registro de auditoría MCP

### Formato de Reglas

Las reglas de cursor usan frontmatter YAML con `description`, `globs` y `alwaysApply`:

```yaml
---
description: "TypeScript coding style extending common rules"
globs: ["**/*.ts", "**/*.tsx", "**/*.js", "**/*.jsx"]
alwaysApply: false
---
```

---

## Aplicación Codex para macOS + Soporte CLI

ECC ofrece **soporte Codex de primera clase** tanto para la aplicación macOS como para la CLI, con una configuración de referencia, un suplemento AGENTS.md específico para Codex y habilidades compartidas.

### Inicio rápido (Aplicación Codex + CLI)

```bash
# Run Codex CLI in the repo — AGENTS.md and .codex/ are auto-detected
codex

# Automatic setup: sync ECC assets (AGENTS.md, skills, MCP servers) into ~/.codex
npm install && bash scripts/sync-ecc-to-codex.sh
# or: pnpm install && bash scripts/sync-ecc-to-codex.sh
# or: yarn install && bash scripts/sync-ecc-to-codex.sh
# or: bun install && bash scripts/sync-ecc-to-codex.sh

# Or manually: copy the reference config to your home directory
cp .codex/config.toml ~/.codex/config.toml
```
El script de sincronización fusiona de forma segura los servidores ECC MCP en tu `~/.codex/config.toml` existente usando una estrategia **solo de adición** — nunca elimina ni modifica tus servidores existentes. Ejecuta con `--dry-run` para previsualizar los cambios, o `--update-mcp` para actualizar forzosamente los servidores ECC a la configuración recomendada más reciente.

Para Context7, ECC usa el nombre canónico de sección de Codex `[mcp_servers.context7]` mientras sigue lanzando el paquete `@upstash/context7-mcp`. Si ya tienes una entrada heredada `[mcp_servers.context7-mcp]`, `--update-mcp` la migra al nombre de sección canónico.

App de Codex para macOS:
- Abre este repositorio como tu espacio de trabajo.
- El archivo raíz `AGENTS.md` se detecta automáticamente.
- `.codex/config.toml` y `.codex/agents/*.toml` funcionan mejor si se mantienen locales al proyecto.
- El `.codex/config.toml` de referencia intencionalmente no fija `model` ni `model_provider`, así Codex usa su valor predeterminado actual a menos que lo sobreescribas.
- Opcional: copia `.codex/config.toml` a `~/.codex/config.toml` para valores predeterminados globales; mantén los archivos de roles multi-agente locales al proyecto a menos que también copies `.codex/agents/`.

### Qué Incluye

| Componente | Cantidad | Detalles |
|------------|----------|----------|
| Configuración | 1 | `.codex/config.toml` — aprobaciones a nivel superior/sandbox/búsqueda_web, servidores MCP, notificaciones, perfiles |
| AGENTS.md | 2 | Raíz (universal) + `.codex/AGENTS.md` (suplemento específico de Codex) |
| Habilidades | 32 | `.agents/skills/` — SKILL.md + agents/openai.yaml por habilidad |
| Servidores MCP | 6 | GitHub, Context7, Exa, Memory, Playwright, Sequential Thinking (7 con Supabase vía sincronización `--update-mcp`) |
| Perfiles | 2 | `strict` (sandbox solo lectura) y `yolo` (aprobación automática completa) |
| Roles de Agentes | 3 | `.codex/agents/` — explorer, reviewer, docs-researcher |

### Habilidades

Las habilidades en `.agents/skills/` son cargadas automáticamente por Codex:

Las habilidades canónicas de Anthropic como `claude-api`, `frontend-design` y `skill-creator` intencionalmente no se reempaquetan aquí. Instala esas desde [`anthropics/skills`](https://github.com/anthropics/skills) cuando quieras las versiones oficiales.

| Habilidad | Descripción |
|----------|-------------|
| agent-introspection-debugging | Depurar comportamiento del agente, enrutamiento y límites de prompt |
| agent-sort | Ordenar catálogos de agentes y superficies de asignación |
| api-design | Patrones de diseño REST API |
| article-writing | Escritura de formato largo a partir de notas y referencias de voz |
| backend-patterns | Diseño API, base de datos, caché |
| brand-voice | Perfiles de estilo de escritura derivados de contenido real |
| bun-runtime | Bun como runtime, gestor de paquetes, empaquetador y corredor de pruebas |
| coding-standards | Estándares universales de codificación |
| content-engine | Contenido social nativo de la plataforma y reutilización |

| crosspost | Distribución de contenido multiplataforma en X, LinkedIn, Threads |
| deep-research | Investigación multisource con síntesis y atribución de fuentes |
| dmux-workflows | Orquestación multiagente usando el gestor de paneles tmux |
| documentation-lookup | Documentación actualizada de librerías y frameworks vía Context7 MCP |
| e2e-testing | Pruebas E2E con Playwright |
| eval-harness | Desarrollo guiado por evaluación |
| everything-claude-code | Convenciones y patrones de desarrollo para el proyecto |
| exa-search | Búsqueda neuronal vía Exa MCP para web, código, investigación empresarial |
| fal-ai-media | Generación unificada de medios para imágenes, video y audio |
| frontend-patterns | Patrones React/Next.js |
| frontend-slides | Presentaciones HTML, conversión PPTX, exploración de estilo visual |
| investor-materials | Presentaciones, memorandos, modelos y resúmenes ejecutivos |
| investor-outreach | Contacto personalizado, seguimientos y textos introductorios |
| market-research | Investigación de mercado y competencia con atribución de fuentes |
| mcp-server-patterns | Construcción de servidores MCP con SDK Node/TypeScript |
| nextjs-turbopack | Next.js 16+ y empaquetado incremental Turbopack |
| product-capability | Traducción de objetivos de producto en mapas de capacidades delimitados |
| security-review | Lista de verificación completa de seguridad |
| strategic-compact | Gestión de contexto |
| tdd-workflow | Desarrollo guiado por pruebas con cobertura >80% |
| verification-loop | Construcción, prueba, lint, typecheck, seguridad |
| video-editing | Flujos de edición de video asistidos por IA con FFmpeg y Remotion |
| x-api | Integración API X/Twitter para publicación y analíticas |

### Limitación clave

Codex **aún no proporciona paridad en la ejecución de hooks al estilo Claude**. La aplicación de ECC allí es basada en instrucciones vía `AGENTS.md`, sobreescrituras opcionales `model_instructions_file` y configuraciones de sandbox/aprobación.

### Soporte Multiagente

Las versiones actuales de Codex soportan flujos de trabajo multiagente estables.

- Habilitar `features.multi_agent = true` en `.codex/config.toml`
- Definir roles bajo `[agents.<nombre>]`
- Apuntar cada rol a un archivo bajo `.codex/agents/`
- Usar `/agent` en la CLI para inspeccionar o dirigir agentes secundarios

ECC incluye tres configuraciones de roles de ejemplo:

| Rol | Propósito |
|------|---------|
| `explorer` | Recolección de evidencia del código en modo solo lectura antes de las ediciones |
| `reviewer` | Revisión de corrección, seguridad y pruebas faltantes |
| `docs_researcher` | Verificación de documentación y API antes de la publicación/cambios en la documentación |

---

## Soporte OpenCode

ECC ofrece **soporte completo para OpenCode** incluyendo plugins y hooks.

### Inicio rápido

```bash
# Install OpenCode
npm install -g opencode

# Run in the repository root
opencode
```
La configuración se detecta automáticamente desde `.opencode/opencode.json`.

### Paridad de Funciones

| Función | Claude Code | OpenCode | Estado |
|---------|-------------|----------|--------|
| Agentes | APROBADO: 48 agentes | APROBADO: 12 agentes | **Claude Code lidera** |
| Comandos | APROBADO: 68 comandos | APROBADO: 31 comandos | **Claude Code lidera** |
| Habilidades | APROBADO: 182 habilidades | APROBADO: 37 habilidades | **Claude Code lidera** |
| Hooks | APROBADO: 8 tipos de eventos | APROBADO: 11 eventos | **¡OpenCode tiene más!** |
| Reglas | APROBADO: 29 reglas | APROBADO: 13 instrucciones | **Claude Code lidera** |
| Servidores MCP | APROBADO: 14 servidores | APROBADO: Completo | **Paridad total** |
| Herramientas Personalizadas | APROBADO: A través de hooks | APROBADO: 6 herramientas nativas | **OpenCode es mejor** |

### Soporte de Hooks vía Plugins

El sistema de plugins de OpenCode es MÁS sofisticado que Claude Code con más de 20 tipos de eventos:

| Hook de Claude Code | Evento de Plugin de OpenCode |
|---------------------|------------------------------|
| PreToolUse | `tool.execute.before` |
| PostToolUse | `tool.execute.after` |
| Stop | `session.idle` |
| SessionStart | `session.created` |
| SessionEnd | `session.deleted` |

**Eventos adicionales de OpenCode**: `file.edited`, `file.watcher.updated`, `message.updated`, `lsp.client.diagnostics`, `tui.toast.show`, y más.

### Entradas Slash Mantenidas

| Comando | Descripción |
|---------|-------------|
| `/plan` | Crear plan de implementación |
| `/code-review` | Revisar cambios de código |
| `/build-fix` | Corregir errores de compilación |
| `/refactor-clean` | Eliminar código muerto |
| `/learn` | Extraer patrones de la sesión |
| `/checkpoint` | Guardar estado de verificación |
| `/quality-gate` | Ejecutar la puerta de verificación mantenida |

| `/update-docs` | Actualizar documentación |
| `/update-codemaps` | Actualizar mapas de código |
| `/test-coverage` | Analizar cobertura |
| `/go-review` | Revisión de código Go |
| `/go-test` | Flujo de trabajo TDD en Go |
| `/go-build` | Corregir errores de compilación en Go |
| `/python-review` | Revisión de código Python (PEP 8, hints de tipo, seguridad) |
| `/multi-plan` | Planificación colaborativa multi-modelo |
| `/multi-execute` | Ejecución colaborativa multi-modelo |
| `/multi-backend` | Flujo de trabajo multi-modelo enfocado en backend |
| `/multi-frontend` | Flujo de trabajo multi-modelo enfocado en frontend |
| `/multi-workflow` | Flujo de trabajo completo de desarrollo multi-modelo |
| `/pm2` | Generar automáticamente comandos de servicio PM2 |
| `/sessions` | Gestionar historial de sesiones |
| `/skill-create` | Generar habilidades desde git |
| `/instinct-status` | Ver instintos aprendidos |
| `/instinct-import` | Importar instintos |
| `/instinct-export` | Exportar instintos |
| `/evolve` | Agrupar instintos en habilidades |
| `/promote` | Promover instintos del proyecto a ámbito global |
| `/projects` | Listar proyectos conocidos y estadísticas de instintos |
| `/prune` | Eliminar instintos pendientes expirados (TTL 30d) |
| `/learn-eval` | Extraer y evaluar patrones antes de guardar |
| `/setup-pm` | Configurar gestor de paquetes |
| `/harness-audit` | Auditar fiabilidad del entorno, preparación de evaluación y postura de riesgo |
| `/loop-start` | Iniciar patrón de ejecución controlada de bucle agente |
| `/loop-status` | Inspeccionar estado activo del bucle y puntos de control |
| `/quality-gate` | Ejecutar chequeos de puerta de calidad para rutas o repositorio completo |
| `/model-route` | Dirigir tareas a modelos según complejidad y presupuesto |

### Instalación del Plugin

**Opción 1: Usar directamente**
```bash
cd everything-claude-code
opencode
```

**Opción 2: Instalar como paquete npm**
```bash
npm install ecc-universal
```

Luego añada a su `opencode.json`:
```json
{
  "plugin": ["ecc-universal"]
}
```

Esa entrada del plugin npm habilita el módulo de plugin OpenCode publicado por ECC (hooks/eventos y herramientas de plugin).
No añade **automáticamente** el catálogo completo de comandos/agentes/instrucciones de ECC a la configuración de tu proyecto.

Para la configuración completa de ECC OpenCode, haz uno de los siguientes:
- ejecuta OpenCode dentro de este repositorio, o
- copia los recursos de configuración empaquetados en `.opencode/` a tu proyecto y conecta las entradas `instructions`, `agent` y `command` en `opencode.json`

### Documentación

- **Guía de Migración**: `.opencode/MIGRATION.md`
- **README del Plugin OpenCode**: `.opencode/README.md`
- **Reglas Consolidadas**: `.opencode/instructions/INSTRUCTIONS.md`
- **Documentación LLM**: `llms.txt` (documentación completa de OpenCode para LLMs)

---

## Paridad de Funciones entre Herramientas

ECC es el **primer plugin que maximiza todas las principales herramientas de codificación AI**. Así se compara cada herramienta:

| Función | Claude Code | Cursor IDE | Codex CLI | OpenCode |
|---------|-------------|------------|-----------|----------|
| **Agentes** | 48 | Compartidos (AGENTS.md) | Compartidos (AGENTS.md) | 12 |
| **Comandos** | 68 | Compartidos | Basados en instrucciones | 31 |
| **Habilidades** | 182 | Compartidas | 10 (formato nativo) | 37 |
| **Eventos de Hook** | 8 tipos | 15 tipos | Ninguno aún | 11 tipos |
| **Scripts de Hook** | 20+ scripts | 16 scripts (adaptador DRY) | N/A | Hooks de plugin |
| **Reglas** | 34 (comunes + idioma) | 34 (frontmatter YAML) | Basadas en instrucciones | 13 instrucciones |
| **Herramientas Personalizadas** | Via hooks | Via hooks | N/A | 6 herramientas nativas |
| **Servidores MCP** | 14 | Compartidos (mcp.json) | 7 (fusionados automáticamente vía parser TOML) | Completo |
| **Formato Configuración** | settings.json | hooks.json + rules/ | config.toml | opencode.json |
| **Archivo de Contexto** | CLAUDE.md + AGENTS.md | AGENTS.md | AGENTS.md | AGENTS.md |
| **Detección de Secretos** | Basado en hook | hook beforeSubmitPrompt | Basado en sandbox | Basado en hook |
| **Auto-Formato** | Hook PostToolUse | Hook afterFileEdit | N/A | Hook file.edited |
| **Versión** | Plugin | Plugin | Configuración de referencia | 2.0.0-rc.1 |

**Decisiones arquitectónicas clave:**
- **AGENTS.md** en la raíz es el archivo universal entre herramientas (lo leen las 4 herramientas)
- El **patrón adaptador DRY** permite a Cursor reutilizar los scripts de hook de Claude Code sin duplicación
- **Formato de habilidades** (SKILL.md con frontmatter YAML) funciona en Claude Code, Codex y OpenCode  
- La falta de hooks en Codex se compensa con `AGENTS.md`, anulaciones opcionales de `model_instructions_file` y permisos de sandbox  

---

## Antecedentes  

He estado usando Claude Code desde su despliegue experimental. Gané el hackathon Anthropic x Forum Ventures en septiembre de 2025 con [@DRodriguezFX](https://x.com/DRodriguezFX) — construí [zenith.chat](https://zenith.chat) completamente usando Claude Code.  

Estas configuraciones están probadas en combate en múltiples aplicaciones de producción.  

---

## Optimización de tokens  

El uso de Claude Code puede ser costoso si no se gestiona el consumo de tokens. Estas configuraciones reducen significativamente los costos sin sacrificar la calidad.  

### Configuraciones recomendadas  

Añadir a `~/.claude/settings.json`:

```json
{
  "model": "sonnet",
  "env": {
    "MAX_THINKING_TOKENS": "10000",
    "CLAUDE_AUTOCOMPACT_PCT_OVERRIDE": "50"
  }
}
```
| Configuración | Predeterminado | Recomendado | Impacto |
|--------------|---------------|-------------|---------|
| `model` | opus | **sonnet** | ~60% reducción de costos; maneja más del 80% de las tareas de codificación |
| `MAX_THINKING_TOKENS` | 31,999 | **10,000** | ~70% reducción en el costo oculto de pensamiento por solicitud |
| `CLAUDE_AUTOCOMPACT_PCT_OVERRIDE` | 95 | **50** | Compacta antes — mejor calidad en sesiones largas |

Cambie a Opus solo cuando necesite un razonamiento arquitectónico profundo:

```
/model opus
```
### Comandos Diarios de Flujo de Trabajo

| Comando | Cuándo Usar |
|---------|-------------|
| `/model sonnet` | Predeterminado para la mayoría de tareas |
| `/model opus` | Arquitectura compleja, depuración, razonamiento profundo |
| `/clear` | Entre tareas no relacionadas (libre, reinicio instantáneo) |
| `/compact` | En puntos lógicos de ruptura de tareas (investigación hecha, hito completado) |
| `/cost` | Monitorear el gasto de tokens durante la sesión |

### Compactación Estratégica

La habilidad `strategic-compact` (incluida en este plugin) sugiere `/compact` en puntos lógicos en lugar de depender de la auto-compactación al 95% del contexto. Vea `skills/strategic-compact/SKILL.md` para la guía completa de decisiones.

**Cuándo compactar:**
- Después de la investigación/exploración, antes de la implementación
- Después de completar un hito, antes de comenzar el siguiente
- Después de depurar, antes de continuar con el trabajo de la función
- Después de un enfoque fallido, antes de intentar uno nuevo

**Cuándo NO compactar:**
- A mitad de la implementación (perderá nombres de variables, rutas de archivos, estado parcial)

### Gestión de la Ventana de Contexto

**Crítico:** No habilite todos los MCP a la vez. Cada descripción de herramienta MCP consume tokens de su ventana de 200k, potencialmente reduciéndola a ~70k.

- Mantenga menos de 10 MCP habilitados por proyecto
- Mantenga menos de 80 herramientas activas
- Use `/mcp` para deshabilitar servidores MCP de Claude Code no usados; esas elecciones en tiempo de ejecución persisten en `~/.claude.json`
- Use `ECC_DISABLED_MCPS` solo para filtrar configuraciones MCP generadas por ECC durante los flujos de instalación/sincronización

### Advertencia de Costos de Equipos de Agentes

Equipos de Agentes crean múltiples ventanas de contexto. Cada compañero consume tokens de forma independiente. Úselo solo para tareas donde el paralelismo aporte un valor claro (trabajo multi-módulo, revisiones paralelas). Para tareas secuenciales simples, los subagentes son más eficientes en tokens.

---

## ADVERTENCIA: Notas Importantes


### Optimización de Tokens

¿Alcanzando los límites diarios? Consulta la **[Guía de Optimización de Tokens](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/token-optimization.md)** para configuraciones recomendadas y consejos de flujo de trabajo.

Victorias rápidas:

```json
// ~/.claude/settings.json
{
  "model": "sonnet",
  "env": {
    "MAX_THINKING_TOKENS": "10000",
    "CLAUDE_AUTOCOMPACT_PCT_OVERRIDE": "50",
    "CLAUDE_CODE_SUBAGENT_MODEL": "haiku"
  }
}
```
Usa `/clear` entre tareas no relacionadas, `/compact` en puntos de ruptura lógicos y `/cost` para monitorear gastos.

### Personalización

Estas configuraciones funcionan para mi flujo de trabajo. Deberías:
1. Comenzar con lo que resuene
2. Modificar para tu stack
3. Eliminar lo que no uses
4. Agregar tus propios patrones

---

## Proyectos Comunitarios

Proyectos construidos sobre o inspirados en Everything Claude Code:

| Proyecto | Descripción |
|---------|-------------|
| [EVC](https://github.com/SaigonXIII/evc) | Espacio de trabajo para agentes de marketing — 42 comandos para operadores de contenido, gobernanza de marca y publicación multicanal. [Vista visual](https://saigonxiii.github.io/evc). |

¿Construiste algo con ECC? Abre un PR para añadirlo aquí.

---

## Patrocinadores

Este proyecto es gratuito y de código abierto. Los patrocinadores ayudan a mantenerlo y hacerlo crecer.

[**Conviértete en Patrocinador**](https://github.com/sponsors/affaan-m) | [Niveles de Patrocinio](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/SPONSORS.md) | [Programa de Patrocinio](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/SPONSORING.md)

---

## Historial de Estrellas

[![Gráfico de Historial de Estrellas](https://api.star-history.com/svg?repos=affaan-m/everything-claude-code&type=Date)](https://star-history.com/#affaan-m/everything-claude-code&Date)

---

## Enlaces


- **Guía Rápida (Empieza Aquí):** [La Guía Rápida para Todo el Código Claude](https://x.com/affaanmustafa/status/2012378465664745795)
- **Guía Detallada (Avanzada):** [La Guía Detallada para Todo el Código Claude](https://x.com/affaanmustafa/status/2014040193557471352)
- **Guía de Seguridad:** [Guía de Seguridad](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./the-security-guide.md) | [Hilo](https://x.com/affaanmustafa/status/2033263813387223421)
- **Seguir:** [@affaanmustafa](https://x.com/affaanmustafa)

---

## Licencia

MIT - Usa libremente, modifica según necesites, contribuye si puedes.

---

**Marca este repositorio con una estrella si te ayuda. Lee ambas guías. Construye algo grandioso.**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---