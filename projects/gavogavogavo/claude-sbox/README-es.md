# claude-sbox

Una habilidad de [Claude Code](https://code.claude.com) que enseña a Claude a escribir código idiomático de [s&box](https://sbox.game) — componentes C#, UI Razor, física y redes — sin recurrir a los patrones de Unity.

s&box es el motor de juego Source 2 de Facepunch con una capa de scripting en C#. Su API, ciclo de vida y modelo de red *no se parecen en nada* a los de Unity, lo que significa que Claude estándar alucina constantemente: `void Start()`, `GetComponent<T>()` en el sentido de Unity, `Physics.Raycast`, `[SerializeField]`, `StartCoroutine` — todo mal en s&box. Esta habilidad se carga cuando escribes código s&box y redirige a Claude hacia las APIs correctas, verificadas contra el esquema exportado del motor.

---

## Instalar

**Personal (disponible en todos tus proyectos):**

```bash
mkdir -p ~/.claude/skills
git clone https://github.com/gavogavogavo/claude-sbox ~/.claude/skills/sbox
```

**Local del proyecto (solo este juego):**

```bash
cd my-sbox-game
mkdir -p .claude/skills
git clone https://github.com/gavogavogavo/claude-sbox .claude/skills/sbox
```

Claude Code detecta cambios en archivos de habilidades en tiempo real. Sin embargo, si `~/.claude/skills/` no existía cuando inició tu sesión de Claude Code (es decir, esta es tu primera habilidad personal), necesitas **reiniciar Claude Code** después de crear el directorio con `mkdir` para que el observador registre el nuevo directorio.

> **¿Por qué el nombre del directorio `sbox` (y no `claude-sbox`)?** El campo `name:` en el frontmatter de `SKILL.md` es `sbox`, que se convierte en el comando slash `/sbox`. Clonar en `~/.claude/skills/sbox/` mantiene el nombre del directorio y el nombre de invocación sincronizados.

---

## Verifica que funcione

En cualquier sesión de Claude Code, escribe:

```
/sbox
```

El enrutador se carga. Alternativamente, haga una pregunta desencadenante y observe cómo Claude busca un archivo de referencia:

```
How do I write a networked player controller in s&box?
```
Claude debería abrir `references/core-concepts.md`, `references/networking.md` y/o `references/patterns-and-examples.md` antes de responder — *esa es la señal de que la habilidad está funcionando*. Si responde de memoria sin leer un archivo, algo está mal; consulte [Solución de problemas](#troubleshooting).

---

## Qué contiene

`SKILL.md` es un enrutador, no una referencia. Cuando Claude necesita detalle, abre uno de estos:

| Archivo | Líneas | Cubre |
|---|---:|---|
| `SKILL.md` | 271 | Enrutador + tabla de traducción Unity→s&box + las diez reglas |
| `references/core-concepts.md` | 575 | Sistema de escenas, GameObjects, Componentes, ciclo de vida, `[Property]`, prefabs, eventos de escena, `GameObjectSystem`, async |
| `references/components-builtin.md` | 729 | 144 componentes integrados — renderizadores, cuerpos rígidos, colisionadores, `CharacterController`, `CameraComponent`, luces, audio, UI, `NavMeshAgent`, `PlayerController`, partículas, post-procesamiento |
| `references/ui-razor.md` | 834 | Paneles Razor, SCSS, diseño flexbox, controles integrados (Botón / Entrada de texto / Desplegable / Control deslizante / Cuadrícula virtual), `NavigationHost`, transiciones |
| `references/networking.md` | 672 | Lobbies, `Connection`, `[Sync]` + `SyncFlags`, `[Rpc.Broadcast/Host/Owner]`, propiedad, `INetworkListener`, `INetworkSpawn`, datos snapshot, servidores dedicados |
| `references/input-and-physics.md` | 597 | Sistema de entrada, API constructor `SceneTrace`, `PhysicsWorld`, colisión, `Vector3`/`Rotation`/`Angles`/`Transform`/`BBox`/`Ray`/`Capsule`, `TimeSince`/`TimeUntil`, `Gizmo.Draw` |
| `references/api-schema-core.md` | 930 | Firmas públicas completas para los ~50 tipos más usados |
| `references/api-schema-extended.md` | 2753 | Índice organizado por espacio de nombres de 738 tipos adicionales para descubrimiento |
| `references/patterns-and-examples.md` | 1056 | 10 ejemplos completos ejecutables (Salud + `IDamageable`, `CharacterController` en primera persona, arma hitscan, gestor de juego en red, jugador con `[Sync]`/RPCs, HUD Razor, granada con cuerpo rígido, máquina de estados AI NavMeshAgent, generador de prefabs, recogida con disparador) |

Cada firma de API en cada archivo de referencia está verificada contra el esquema exportado del motor s&box (`raw/api-schema.json`, ~1,850 tipos en 61 espacios de nombres). El esquema es la única fuente de verdad — si la documentación y el esquema difieren, gana el esquema.

---

## Actualización


```bash
cd ~/.claude/skills/sbox
git pull
```

Claude Code recarga los archivos de habilidades modificados dentro de la sesión actual.

---

## Regenerar desde la fuente

Los usuarios finales no necesitan esto. Para los mantenedores que desean reconstruir los archivos de referencia contra una versión más nueva del motor s&box:

```bash
./scripts/fetch-raw.sh         # clones Facepunch/sbox-docs into raw/sbox-docs
# manually place raw/api-schema.json (see docs/DESIGN.md)
node scripts/build_extended.js # rebuilds references/api-schema-extended.md
```

El flujo completo de construcción — incluyendo cómo se curó cada archivo de referencia, el ciclo de verificación del esquema y las advertencias conocidas — está documentado en [`docs/DESIGN.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/DESIGN.md) y [`docs/BUILD_LOG.md`](https://raw.githubusercontent.com/gavogavogavo/claude-sbox/main/docs/BUILD_LOG.md).

---

## Solución de problemas

**Claude no activa la habilidad en preguntas sobre s&box.**
Verifique que el directorio esté en `~/.claude/skills/sbox/` (no en `~/.claude/skills/claude-sbox/` o `~/.claude/skills/sbox-skill/`). El nombre del directorio debe coincidir con el `name:` en el frontmatter. También intente invocarlo explícitamente con `/sbox` para confirmar que está instalado.

**Claude responde preguntas sobre s&box sin abrir un archivo de referencia.**
Eso significa que está alucinando a partir de la memoria muscular de Unity — el fallo exacto que esta habilidad existe para evitar. O la habilidad no se está cargando, o la descripción no coincide. Intente `/sbox` para forzar la carga, luego reintente la pregunta.

**La habilidad se está cargando pero sugiere APIs que no compilan.**
Abra un issue con el código sugerido y el archivo de referencia del que Claude dice que proviene. Cada firma enviada debe ser verificada por el esquema; las regresiones son errores.

**Lo cloné en `~/.claude/skills/claude-sbox/` — ¿y ahora qué?**
O renombre el directorio a `sbox`, o cambie el campo `name:` en `SKILL.md` a `claude-sbox` para que coincida. Lo mismo aplica para instalaciones locales al proyecto.

---

## Contribuciones

Se aceptan issues y PRs. Antes de enviar:

- **Verifique las nuevas firmas de API contra `raw/api-schema.json`.** El esquema es la verdad fundamental. Si no puede encontrar un método en el esquema, no lo agregue.
- **Mantenga `SKILL.md` por debajo de 500 líneas.** Es un enrutador — los detalles de referencia viven en `references/`. Si puede responder una pregunta sobre s&box usando solo `SKILL.md` sin abrir un archivo de referencia, el enrutador tiene demasiado detalle.
- **Actualice `CHANGELOG.md`** para cualquier cambio visible al usuario.
- **Mantenga el estilo de prosa existente** — conciso, denso, escrito para Claude y no para un lector de tutorial.

---

## Licencia

MIT — vea [LICENSE](LICENSE).

Este proyecto no está afiliado ni respaldado por Facepunch o Anthropic. s&box es un producto de Facepunch Studios. Claude Code y el formato Agent Skills son productos de Anthropic.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---