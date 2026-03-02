# Ejemplo: Por favor, ayúdame a organizar mi carpeta de trabajo

https://github.com/user-attachments/assets/48743a51-705a-4c66-9fdb-4d7147f8098b


[简体中文](https://raw.githubusercontent.com/caiqinghua/Open-Claude-Cowork/main/README_ZH.md)

# Claude Cowork

Un **asistente de IA de escritorio** que te ayuda con **programación, gestión de archivos y cualquier tarea que puedas describir**.

Es **totalmente compatible con la misma configuración exacta que Claude Code**, lo que significa que puedes ejecutarlo con **cualquier modelo de lenguaje grande compatible con Anthropic**.

**✨ No se requiere suscripción a Claude Max** - Soporta cualquier modelo API compatible con Anthropic, incluyendo Zhipu GLM 4.7, MiniMax 2.1, Moonshot Kimi, DeepSeek y más.

> No es solo una interfaz gráfica.  
> Un verdadero socio de colaboración con IA.  
> No necesitas aprender el SDK de Claude Agent — solo crea tareas y elige rutas de ejecución.


---

## ✨ ¿Por qué Claude Cowork?

Claude Code es poderoso — pero **solo se ejecuta en la terminal**.

Eso significa:
- ❌ Sin retroalimentación visual para tareas complejas
- ❌ Difícil de seguir múltiples sesiones
- ❌ Los resultados de las herramientas son incómodos de inspeccionar

**Open Claude Cowork resuelve estos problemas:**

- 🖥️ Se ejecuta como una **aplicación de escritorio nativa**
- 🤖 Actúa como tu **socio de colaboración con IA** para cualquier tarea
- 🔁 Reutiliza tu **`~/.claude/settings.json` existente**
- 🧠 **100% compatible** con Claude Code

Si Claude Code funciona en tu máquina —  
**Open Claude Cowork también funciona.**

---

## 🚀 Inicio Rápido

> **💡 Consejo:** Esta aplicación es completamente compatible con la configuración de Claude Code. No se necesita suscripción a Claude Max: puedes usar Zhipu GLM, MiniMax, Kimi, DeepSeek o cualquier otro modelo API compatible con Anthropic.

Antes de usar Open Claude Cowork, asegúrate de que Claude Code esté instalado y configurado correctamente.

### Opción 1: Descargar una Versión

👉 [Ir a Releases](https://github.com/caiqinghua/open-claude-cowork/releases)

---

### Opción 2: Compilar desde el Código Fuente

#### Requisitos Previos

- [Bun](https://bun.sh/) o Node.js 22+
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code) instalado y autenticado

```bash
# Clone the repository
git clone https://github.com/caiqinghua/open-claude-cowork.git
cd open-claude-cowork

# Install dependencies
bun install

# Configure environment (copy .env.example to .env)
cp .env.example .env

# Run in development mode
bun run dev

# Or build production binaries
bun run dist:mac    # macOS
bun run dist:win    # Windows
bun run dist:linux  # Linux
```

---

## 🧠 Capacidades Principales

### 🤖 Socio de Colaboración con IA — No Solo una GUI

Open Claude Cowork es tu socio de IA que puede:

* **Escribir y editar código** — en cualquier lenguaje de programación
* **Gestionar archivos** — crear, mover y organizar
* **Crear presentaciones PPT** — generar contenido y estructura de presentaciones
* **Análisis de temas** — análisis profundo de temas y direcciones de investigación
* **Escritura de artículos** — redactar diversos tipos de artículos y documentos
* **Hacer cualquier cosa** — siempre que puedas describirlo en lenguaje natural

---

### 📂 Gestión de Sesiones

* Crear sesiones con **directorios de trabajo personalizados**
* Reanudar cualquier conversación previa
* Historial completo de sesiones locales (almacenado en SQLite)
* Eliminación segura y persistencia automática

---

### 🎯 Salida de Transmisión en Tiempo Real

* **Salida de transmisión token por token**
* Ver el proceso de razonamiento de Claude
* Renderizado Markdown con código resaltado por sintaxis
* Llamadas a herramientas visualizadas con indicadores de estado

---

### 🔐 Control de Permisos de Herramientas

* Se requiere aprobación explícita para acciones sensibles
* Permitir o denegar por herramienta
* Paneles de decisión interactivos
* Control total sobre lo que Claude puede hacer

---

## 🔁 Totalmente compatible con Claude Code

Open Claude Cowork **comparte configuración con Claude Code**.

Reutiliza directamente:

text
~/.claude/settings.json


Esto significa:

* Mismas claves API
* Misma URL base
* Mismos modelos
* Mismo comportamiento

**Modelos soportados incluyen:**
- Zhipu GLM 4.7
- MiniMax 2.1
- Moonshot Kimi
- DeepSeek
- Todos los demás modelos compatibles con la API de Anthropic

> Configura Claude Code una vez — úsalo en todas partes.

---

## 🔧 Solución de problemas

### Error del módulo better-sqlite3

Si encuentras un error como:

```
Error: The module was compiled against a different Node.js version using
NODE_MODULE_VERSION 127. This version of Node.js requires NODE_MODULE_VERSION 140.
```

Esto sucede porque Electron incluye su propia versión de Node.js y los módulos nativos deben ser recompilados para ella.

**Solución:**

```bash
# Install electron-rebuild as a dev dependency
npm install --save-dev electron-rebuild

# Rebuild better-sqlite3 for Electron
npx electron-rebuild -f -w better-sqlite3

# Run the app again
bun run dev
```
Esto asegura que los módulos nativos se compilen contra la versión de Node.js de Electron y no contra la versión de Node.js de tu sistema.

---

## 🧩 Descripción de la Arquitectura

| Capa             | Tecnología                     |
| ---------------- | ------------------------------ |
| Framework        | Electron 39                    |
| Frontend         | React 19, Tailwind CSS 4       |
| Gestión de Estado| Zustand                        |
| Base de Datos    | better-sqlite3 (modo WAL)      |
| IA               | @anthropic-ai/claude-agent-sdk |
| Construcción     | Vite, electron-builder         |

---

## 🛠 Desarrollo

bash
# Iniciar servidor de desarrollo (recarga en caliente)
bun run dev

# Verificación de tipos / compilación
bun run build


---

## 🗺 Hoja de Ruta

Funciones planeadas:

* Configuración GUI para modelos y claves API
* 🚧 Más funciones próximamente

---

## 🤝 Contribuciones


Se aceptan pull requests.

1. Haz un fork de este repositorio
2. Crea tu rama de características
3. Realiza un commit de tus cambios
4. Abre un Pull Request

---

## ⭐ Palabras Finales

Si alguna vez has querido:

* Un compañero de colaboración de IA persistente en el escritorio
* Una visión visual de cómo funciona Claude
* Gestión conveniente de sesiones entre proyectos

Este proyecto está hecho para ti.

👉 **Si te ayuda, por favor dale una Estrella.**

---

## Licencia

MIT





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-02

---