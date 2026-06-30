<p align="center">
  <img src="https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/cover.jpg" alt="claudex — un terminal, seis proveedores, trae tu propia clave" width="100%">
</p>

# claudex

> **Usa Claude Code desde un solo terminal con múltiples cuentas + múltiples proveedores (Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter…) Trae tus propias claves.**

`claudex` está construido sobre los propios mecanismos de anulación de env `ANTHROPIC_BASE_URL` / `CLAUDE_CONFIG_DIR` de [Claude Code](https://www.anthropic.com/claude-code) — **sin proxy, sin router**. Con un solo comando agregas un nuevo alias `claudeX`: ingresas tu clave API, eliges proveedor + modelo, listo.

[Versión en inglés abajo ↓](#english)

---

## 🇹🇷 Turco

### ¿Por qué?

- Usar proveedores compatibles con Anthropic como DeepSeek / Z.ai / MiniMax que son **mucho más baratos o gratuitos** a través de Claude Code
- Gestionar múltiples cuentas API con **facturación separada** (ej. personal + empresa) en un solo terminal con `CLAUDE_CONFIG_DIR` aislados
- Todo dentro del propio mundo UI/skill/MCP/agent de Claude Code, solo cambia el modelo + la clave en el backend

> ⚠️ **Esta herramienta NO está diseñada para compartir una suscripción Anthropic Pro/Max entre múltiples usuarios ni para evadir límites de tasa por cuenta.** Anthropic prohíbe esto en sus [Términos de consumidor](https://www.anthropic.com/legal/consumer-terms) y [Política de uso](https://www.anthropic.com/legal/aup). `claudex` solo gestiona **cuentas de proveedores autorizadas por separado** / claves API como perfiles independientes.

### Requisitos previos

| Requerido | Cómo instalar |
|---|---|
| Node.js 20+ | https://nodejs.org/ |
| Claude Code | `npm install -g @anthropic-ai/claude-code` |
| zsh o bash | Por defecto en macOS / Linux |

### Instalación (30 segundos)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` lanzamiento pronto. Por ahora `git clone`.

### Primer perfil (guiado)

```bash
claudex quickstart
```

Z.ai → MiniMax → OpenRouter avanzan en ese orden. En cada uno:
- Muestra la URL de la clave (registro → crear clave API)
- Pegas la clave (secreta)
- "Quiero saltar" → enter → se omite
Al terminar `source ~/.zshrc` → al escribir `claude-zai` (o `claude-minimax`, `claude-or`) comienza Claude Code.

### ¿Qué modelo debo elegir?

```bash
claudex recommend
```
Interactivo: "¿Qué quieres hacer?" → 8 casos de uso (código rápido / refactorización / contexto largo / visión / …). Muestra las 3 mejores sugerencias con su justificación, y escribe el comando que vas a ejecutar.

O no interactivo:

```bash
claudex recommend coding-fast --json
```

### Árbol de decisión

```
Ücretsiz?
├── Süresiz ücretsiz model → claudex add <name> --provider zai
├── 32 ücretsiz modelin biri → claudex add <name> --provider openrouter
└── Trial (Kasım 7 2026'a kadar) → claudex add <name> --provider minimax

Ucuz ödemeli?
└── DeepSeek (~10x Sonnet'ten ucuz) → claudex add <name> --provider deepseek

Birden fazla ayrı-faturalı Anthropic API hesabı (kişisel/şirket/proje izolasyonu)?
└── claudex add <name> --provider anthropic --no-share
```
### Todos los comandos


```bash
claudex init                       # ilk kurulum (~/.claudex + shell rc block)
claudex quickstart                 # 3 ücretsiz sağlayıcı için kılavuzlu setup
claudex recommend [<intent>]       # ne yapmak istediğine göre top-3 model önerisi
claudex add <isim> [-p <provider>] # yeni alias (interactive)
claudex validate <isim>            # 1-token ping ile key + model doğrula
claudex list                       # tüm profilleri listele
claudex remove <isim>              # alias kaldır
claudex providers [info <id>]      # sağlayıcı kataloğu
claudex export <isim> [-o file]    # redacted JSON template (key olmadan)
claudex import <file>              # template'i yükle, key sor, profil oluştur
claudex doctor                     # kurulum sağlığı
claudex --lang en                  # İngilizce output
```

### Proveedores incluidos

| ID | Nivel | Sitio | Predeterminado |
|----|------|------|---------|
| `anthropic` | Oficial | https://console.anthropic.com | (predeterminado) |
| `zai` | **GRATIS PARA SIEMPRE** | https://z.ai | GLM-4.7-Flash |
| `minimax` | **PRUEBA GRATUITA** (7 de noviembre de 2026) | https://platform.minimax.io | M2.7 |
| `deepseek` | Pago económico | https://platform.deepseek.com | deepseek-v4-pro |
| `moonshot` | Pago (experto en contexto largo) | https://platform.moonshot.ai | Kimi K2.5 |
| `openrouter` | 32 modelos gratuitos | https://openrouter.ai | qwen3-coder:free |

Todos tienen endpoints **compatibles con Anthropic** — no se requiere proxy. Detalles → [docs/PROVIDERS.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/PROVIDERS.md).

### ¿Cómo funciona?

Claude Code revisa 5 variables de entorno:
- `CLAUDE_CONFIG_DIR` — dónde se guardan sesiones, historial, estado del usuario
- `ANTHROPIC_BASE_URL` — endpoint API (por defecto: api.anthropic.com)
- `ANTHROPIC_AUTH_TOKEN` — clave del endpoint
- `ANTHROPIC_MODEL`, `ANTHROPIC_SMALL_FAST_MODEL` — modelos principal + pequeño

`claudex add` genera una función shell para cada perfil. La función lee la clave desde `.env`, configura las variables de entorno, llama al binario `claude`. La clave no aparece en argv ni en el historial.

### Estructura de archivos

```
~/.claudex/
├── profiles/<isim>/
│   ├── .env                # API key (mode 0600)
│   └── (CLAUDE_CONFIG_DIR — symlink veya isolated)
├── generated/aliases.sh    # ~/.zshrc tarafından source edilir
└── backups/                # her rc edit'inde otomatik backup
```

Compartición con el existente `~/.claude/`: por defecto se crea un **symlink** a agents/commands/skills/plugins/CLAUDE.md/settings.json/mcp.json → misma herramienta en todos los perfiles. Perfil completamente aislado con `--no-share`.

### Seguridad

- Las claves en `~/.claudex/profiles/<nombre>/.env`, modo 0600
- Ninguna clave se comitea en el repositorio `claudex` (auto `.gitignore`)
- Detalles → [docs/SECURITY.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/SECURITY.md)

### Añadir nuevo proveedor

Agrega una entrada JSON en [`src/templates/providers.json`](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/src/templates/providers.json), abre un PR. Código no cambia. Detalles → [CONTRIBUTING.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/CONTRIBUTING.md).

### Hoja de ruta (v0.3+)

- `claudex bench` — comparar latencia/costo de perfiles
- Secretos cifrados en macOS Keychain (opt-in)
- Seguimiento de costos — conteo de tokens desde logs de Claude Code
- Autocompletado (zsh/bash/fish)
- Modo proxy claude-code-router para proveedores no compatibles con Anthropic (Groq, Gemini directo)

### Aviso legal

`claudex` es una herramienta **independiente** y de código abierto. No está respaldada ni aprobada por Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter ni ningún otro proveedor. Cumplir con los términos de uso del proveedor es tu responsabilidad.

---

## English

### Why?

- Use **much cheaper or free** Anthropic-compatible providers (DeepSeek, Z.ai, MiniMax, OpenRouter…) through Claude Code
- Manage multiple **separately-billed** API accounts (e.g., personal + company) in one terminal with isolated `CLAUDE_CONFIG_DIR`s
- Everything stays in Claude Code's UI/skills/MCP/agent ecosystem — only the model + key behind it changes

> ⚠️ **This is NOT a way to share or duplicate an Anthropic Pro/Max subscription across users, nor to circumvent per-account rate limits.** Anthropic's [Consumer Terms](https://www.anthropic.com/legal/consumer-terms) and [Usage Policy](https://www.anthropic.com/legal/aup) prohibit that. `claudex` only manages **separately authorized** provider accounts / API keys as independent profiles.

### Prerequisites

- Node.js 20+ — https://nodejs.org/
- Claude Code — `npm install -g @anthropic-ai/claude-code`
- zsh o bash

### Instalación (30 segundos)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` publicación próximamente. Por ahora: git clone.

### Primer perfil (guiado)

```bash
claudex quickstart
```
Te guía a través de Z.ai → MiniMax → OpenRouter (omite cualquiera). Cuando termines: `source ~/.zshrc`, luego `claude-zai` (o `claude-minimax`, `claude-or`) lanza Claude Code con el nuevo modelo.

### ¿Qué modelo?


```bash
claudex recommend
```
Interactivo: "¿Qué quieres hacer?" → 8 casos de uso (codificación rápida / refactorización / contexto largo / visión / …). Muestra los 3 principales con justificación y el comando de instalación.

No interactivo:

```bash
claudex recommend coding-fast --json
```

### Árbol de decisión

```
Free?
├── Forever-free model → claudex add <name> --provider zai
├── One of 32 free models → claudex add <name> --provider openrouter
└── Trial (until Nov 7 2026) → claudex add <name> --provider minimax

Cheap paid?
└── DeepSeek (~10x cheaper than Sonnet) → claudex add <name> --provider deepseek

Multiple separately-billed Anthropic API accounts (personal/company/project isolation)?
└── claudex add <name> --provider anthropic --no-share
```

### Comandos

```bash
claudex init                        # initial setup (~/.claudex + shell rc block)
claudex quickstart                  # guided setup of 3 free providers
claudex recommend [<intent>]        # top-3 model suggestions per use case
claudex add <name> [-p <provider>]  # add an alias (interactive)
claudex validate <name>             # ping the provider with a 1-token test
claudex list                        # list all profiles
claudex remove <name>               # remove alias
claudex providers [info <id>]       # provider catalog
claudex export <name> [-o file]     # redacted JSON template (no key)
claudex import <file>               # load template, prompt for key
claudex doctor                      # health check
claudex --lang tr                   # Turkish output
```

### Descargo de responsabilidad

`claudex` es una herramienta independiente de código abierto. **No está afiliada, respaldada ni patrocinada por Anthropic, Z.ai, MiniMax, DeepSeek, Moonshot, OpenRouter u otro proveedor.** El cumplimiento de los términos de servicio de cada proveedor es su responsabilidad.

### Licencia

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---