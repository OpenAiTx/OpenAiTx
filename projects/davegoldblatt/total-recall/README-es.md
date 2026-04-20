# Total Recall

Un sistema de memoria para Claude Code que recuerda lo que importa y olvida lo que no.

## El Problema

Claude Code olvida todo entre sesiones. Cada vez que empiezas una nueva conversación, es como hablar con alguien con amnesia. Terminas repitiéndote:

- "Ya intentamos ese enfoque, no funcionó."
- "No toques el archivo de autenticación."
- "Prefiero tabulaciones en lugar de espacios."
- "El nombre del cliente es Sarah, no Sara."

Esto se vuelve cansado rápido.

## Qué Hace Total Recall

Le da a Claude Code un bloc de notas que se mantiene entre sesiones, pero un bloc *quisquilloso*. No todo entra. Antes de que algo se guarde permanentemente, debe pasar una prueba simple: **¿importará esto mañana?**

¿Una preferencia que tendrás por meses? Guardada. ¿Una decisión que tomaste y por qué? Guardada. ¿El hecho de que hiciste una prueba hace cinco minutos? No guardado. El sistema se mantiene limpio para que Claude no tenga que buscar entre basura para encontrar lo relevante.

## Cómo Funciona

Piénsalo como una cocina con cuatro áreas de almacenamiento:

**Mostrador** (`CLAUDE.local.md`): Las cosas que usas todos los días. Se carga automáticamente, cada sesión. Mantenido pequeño a propósito, alrededor de una página de texto.

**Despensa** (`memory/registers/`): Organizada por categoría. Tus preferencias, decisiones clave, detalles del proyecto, personas con las que trabajas. Claude revisa aquí cuando necesita algo específico.

**Cuaderno diario** (`memory/daily/`): Notas rápidas con fecha de cada día. Todo se escribe aquí primero. Tú decides después qué vale la pena conservar permanentemente.

**Armario de almacenamiento** (`memory/archive/`): Cosas viejas que ya terminaron o están obsoletas. Aún se pueden buscar, pero nunca se cargan automáticamente.

La idea clave: **las notas van primero al cuaderno diario, luego tú promocionas las que quieres conservar.** Claude no decide solo qué es suficientemente importante para recordar permanentemente. Tú decides.

## Inicio Rápido

### Instalar como plugin (recomendado)

```
/plugin marketplace add davegoldblatt/recall-marketplace
/plugin install recall@recall-marketplace
```

### O instalar de forma independiente

```
git clone https://github.com/davegoldblatt/total-recall.git
cd total-recall
./install.sh /path/to/your/project
```

Después de la instalación, reinicia Claude Code o ejecuta `/hooks` para activar.

## Uso

Aquí está tu día a día:

**Claude nota algo que vale la pena recordar.** Lo escribe en tu cuaderno diario y te lo dice. No tienes que hacer nada.

**Quieres que Claude recuerde algo.** Solo di "recuerda esto" o usa el comando de escritura:

```
/recall-write Dave prefers concise error messages, no stack traces in prod
```

**Fin del día (o cuando sea).** Revisa lo acumulado y promociona lo bueno:

```
/recall-promote
```

**Encuentra algo de la semana pasada.** Busca en todo:

```
/recall-search authentication decision
```
**Tú corriges a Claude.** La corrección se actualiza en todas partes a la vez: cuaderno diario, registros y contador. El mismo error no volverá a ocurrir.

### Todos los Comandos

| Comando | Qué hace |
|---|---|
| `/recall-init` | Configura las carpetas de memoria por primera vez |
| `/recall-write <nota>` | Guarda una nota (verifica si vale la pena conservarla, sugiere dónde) |
| `/recall-log <nota>` | Nota rápida en el cuaderno diario, sin preguntas |
| `/recall-search <consulta>` | Busca en todo |
| `/recall-promote` | Revisa notas diarias, mueve las importantes a registros |
| `/recall-status` | Revisión de salud. ¿Todo funciona? |
| `/recall-maintain` | Limpia entradas obsoletas o duplicadas |
| `/recall-forget <consulta>` | Marca algo como desactualizado |
| `/recall-context` | Muestra qué memoria tiene Claude cargada ahora |

Si se instala como plugin, los comandos tienen espacio de nombres: `/recall:recall-write` en vez de `/recall-write`.

## La Puerta de Escritura

Esta es la idea central. Antes de que algo se promueva a memoria permanente, debe pasar al menos una de estas pruebas:

1. **¿Cambiará cómo se comporta Claude la próxima vez?** (una preferencia, un límite, un patrón)
2. **¿Es un compromiso en el que alguien confía?** (una fecha límite, un entregable, un seguimiento)
3. **¿Es una decisión que vale la pena recordar el razonamiento?** (por qué escogiste X sobre Y)
4. **¿Es un hecho estable que volverá a surgir?** (no algo que cambiará mañana)
5. **¿Dijiste explícitamente "recuerda esto"?**

Si ninguna es cierta, se queda en el cuaderno diario y eventualmente se elimina. Esto mantiene la memoria ligera. Sin cajón de basura.

## Cuando Ocurren Correcciones

Si le dices a Claude que se equivocó, no solo dice "lo siento" y sigue. Actualiza el cuaderno diario, el registro relevante y el contador, todo en un solo paso. La información antigua se marca como reemplazada (no se elimina) para dejar un rastro de qué cambió y cuándo.

## Qué se Carga Automáticamente

Solo dos cosas, cada sesión:

| Qué | Dónde | Cómo |

|---|---|---|
| Las reglas (puerta de escritura, protocolo de corrección) | `rules/total-recall.md` | Claude Code carga todos los archivos de reglas automáticamente |
| Memoria de trabajo / contador | `CLAUDE.local.md` | Claude Code carga esto automáticamente |

Todo lo demás se carga bajo demanda: cuando buscas, cuando es relevante, o al inicio de la sesión mediante hooks.

## Hooks

Dos cosas ocurren automáticamente en segundo plano:

**Cuando inicia una sesión:** Claude recibe un resumen de los ítems abiertos y las notas diarias recientes. Este es el informe de "aquí es donde lo dejamos".

**Antes de que la memoria se compacte:** Se escribe una marca de tiempo en el cuaderno diario para que haya un registro. Esta acción es silenciosa. Claude no la ve, es solo para control administrativo.

Ambos hooks fallan de forma segura. Si algo sale mal, no bloquean el funcionamiento de Claude Code.

Los hooks usan `$CLAUDE_PROJECT_DIR` (modo independiente) o `${CLAUDE_PLUGIN_ROOT}` (plugin) para resolver rutas. No hay análisis de transcripciones. El hook PreCompact solo escribe una marca de tiempo en el registro diario. No lee ni analiza las transcripciones de conversación.

## Arquitectura

Para quienes quieran los detalles técnicos.

```
Conversation (ephemeral, compacted/discarded)
    |
    v  WRITE GATE: "Does this change future behavior?"
    |
Daily Log (memory/daily/YYYY-MM-DD.md)
    All writes land here first. Raw, timestamped.
    |
    v  PROMOTION: user-controlled via /recall-promote
    |
Registers (memory/registers/*.md)
    Structured claims with metadata (confidence, evidence, last_verified)
    |
    v  DISTILLATION: only what's essential for every session
    |
Working Memory (CLAUDE.local.md)
    ~1500 words. Auto-loaded. The persistent "personality."
    |
    v  EXPIRY
    |
Archive (memory/archive/)
    Searchable history. Never auto-loaded.
```

### Mecanismos Clave

**Puerta de Escritura:** Filtra el ruido. Solo pasan hechos que cambian comportamientos, compromisos, decisiones y solicitudes explícitas de "recuerda esto".

**Registro Diario Primero:** Todas las escrituras aterrizan en el registro diario. La promoción a los registros es un paso separado, controlado por el usuario. Esto evita que el modelo solidifique inferencias prematuramente.

**Protocolo de Contradicción:** Nunca sobrescribe en silencio. Las afirmaciones antiguas se marcan como `[obsoletas]` con fecha y razón. Se preserva el patrón de cambio.

**Puerta de Corrección:** Las correcciones humanas tienen la máxima prioridad. Una corrección desencadena escrituras en el registro diario + registro + memoria de trabajo.

### Estructura de Archivos

**Formato de plugin** (instalado mediante `/plugin install`):

```
total-recall/                     # Plugin root
├── .claude-plugin/
│   └── plugin.json               # Plugin manifest
├── skills/                       # Slash commands (namespaced)
│   ├── recall-write/SKILL.md
│   ├── recall-search/SKILL.md
│   └── ...
├── hooks/
│   ├── hooks.json                # Hook configuration
│   ├── session-start.sh
│   └── pre-compact.sh
├── rules/
│   └── total-recall.md           # Protocol (auto-loaded)
└── templates/                    # Scaffolding templates
    ├── SCHEMA.md
    ├── CLAUDE.local.md
    └── registers/
```

**Formato independiente** (instalado vía `install.sh`):

```
your-project/
├── .claude/
│   ├── commands/recall-*.md      # Slash commands
│   ├── rules/total-recall.md     # Protocol (auto-loaded)
│   ├── hooks/*.sh                # Hook scripts
│   └── settings.local.json       # Hook configuration
├── memory/
│   ├── SCHEMA.md
│   ├── daily/YYYY-MM-DD.md
│   ├── registers/*.md
│   └── archive/
├── CLAUDE.md
└── CLAUDE.local.md               # Working memory (gitignored)
```
### Comparado con Otras Herramientas de Memoria

|  | Total Recall | Herramientas de auto-ingesta |
|---|---|---|
| **Qué se guarda** | Solo lo que pasa la puerta de escritura | Todo |
| **Destino predeterminado** | Registro diario (promover después) | Almacenamiento permanente |
| **Costo de contexto** | ~1500 palabras de memoria de trabajo | Crece sin límite |
| **Correcciones** | Se propagan a todos los niveles inmediatamente | Varía |
| **Control del usuario** | La promoción es explícita | Automático |
| **Arquitectura** | 4 niveles con metadatos | Plano o de 2 niveles |

## Privacidad

- Todo es local. Sin llamadas a la red, sin telemetría, sin servicios externos.
- Toda la memoria son archivos markdown simples que puedes leer y editar tú mismo.
- `CLAUDE.local.md` está gitignoreado por defecto (es personal).
- `memory/` está gitignoreado por defecto (puede contener notas personales).
- Los hooks nunca leen tus transcripciones de conversación.
- Para ver exactamente qué está pasando: revisa `hooks/*.sh` y `memory/`. Todo es texto plano.
- Para desinstalar: elimina `memory/`, `CLAUDE.local.md` y las entradas de `.claude/` (o `/plugin uninstall recall`).

## Funciona Junto con Superpowers

Si usas [Superpowers](https://github.com/obra/superpowers), no hay conflictos. Superpowers maneja *cómo* funciona Claude (metodología, TDD, planes). Total Recall maneja *qué* recuerda Claude. Trabajos diferentes, mismo proyecto.

## Licencia

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---