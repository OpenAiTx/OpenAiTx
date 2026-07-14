
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Código de Claude reescrito como un script bash. ~1,500 líneas. Cero paquetes npm.

## Por qué

El Claude Code original tiene ~380,000 líneas de TypeScript con 266 dependencias de npm. Esto hace el mismo trabajo central en bash usando solo `curl` y `jq`.

## Características

- **Transmisión en tiempo real** vía pipe FIFO: el texto aparece a medida que Claude lo genera
- **6 herramientas**: Bash, Leer, Editar, Escribir, Glob, Grep
- **Encadenamiento de herramientas** — hasta 25 llamadas de herramientas por turno
- **Solicitud de permisos** — pregunta antes de ejecutar comandos no seguros (`y/n/a`)
- **Carga de CLAUDE.md** — lee instrucciones del proyecto desde archivos CLAUDE.md en el árbol de directorios
- **Contexto compatible con Git** — rama, estado y commits recientes en el prompt del sistema
- **Guardar/reanudar sesión** — guarda automáticamente al salir, reanuda con `--resume <id>`
- **Reintento con retroceso exponencial** — reintentos exponenciales en límites de tasa 429/529
- **Seguimiento de costos** — totales por turno y por sesión
- **Spinner** — con los verbos originales del spinner (Clauding, Flibbertigibbeting, etc.)
- **Comandos de barra** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Modo pipe** — `echo "explica esto" | ./claude.sh`

## Instalación

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Dependencias

- `curl`
- `jq`
- Opcional: `rg` (ripgrep) para una mejor búsqueda
- Opcional: `python3` para la herramienta de edición

Las versiones en tiempo de ejecución están fijadas en `.tool-versions`. Instálalas con [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Uso

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Variables de Entorno

| Variable | Predeterminado | Descripción |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (obligatorio) | Tu clave API de Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Modelo a utilizar |
| `CLAUDE_MAX_TOKENS` | `8192` | Máximo de tokens de salida |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | URL base de la API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Modo de permiso: `ask`, `allow` o `deny` |

### Comandos

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### Reanudar una sesión

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Arquitectura

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Cómo Funciona

1. Leer la entrada del usuario
2. Construir la solicitud JSON con `jq` (mensajes, herramientas, prompt del sistema)
3. Transmitir la respuesta vía `curl` a través de una tubería FIFO
4. Analizar eventos SSE línea por línea, imprimir deltas de texto en tiempo real
5. Cuando lleguen bloques tool_use, ejecutar las herramientas
6. Alimentar los resultados de las herramientas como mensajes
7. Repetir hasta que Claude deje de llamar herramientas

## Comparación

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Líneas de código | ~1,500 | ~380,000 |
| Dependencias | curl, jq | 266 paquetes npm |
| Tamaño binario | 0 (script) | ~200MB node_modules |
| Tiempo de inicio | Instantáneo | ~500ms |

### Pruebas

Las pruebas usan [bats](https://github.com/bats-core/bats-core) (Sistema Automatizado de Pruebas Bash):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---