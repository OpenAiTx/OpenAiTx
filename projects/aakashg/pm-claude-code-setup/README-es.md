# Configuración de Código PM Claude

[![Estrellas](https://img.shields.io/github/stars/aakashg/pm-claude-code-setup?style=flat-square)](https://github.com/aakashg/pm-claude-code-setup/stargazers)
[![Licencia](https://img.shields.io/github/license/aakashg/pm-claude-code-setup?style=flat-square)](LICENSE)

Una configuración de Claude Code lista para producción para gerentes de producto. Coloca estos archivos en tu proyecto y Claude Code entenderá inmediatamente el trabajo de PM.

Incluye un archivo de contexto `CLAUDE.md`, 6 habilidades de PM y 4 plantillas. Toma 60 segundos configurarlo.

**Esta configuración funciona de forma independiente. El sistema operativo completo para PM va más allá: 41+ habilidades, 7 perspectivas de sub-agentes, una biblioteca completa de contextos, plantillas de lanzamiento y flujos de trabajo de planificación de sprints refinados tras más de 100 iteraciones.**

**[Obtén el sistema operativo completo para PM →](https://www.news.aakashg.com/p/pm-os)**

---

## Qué Incluye

```
pm-claude-code-setup/
├── CLAUDE.md                           # Master context file — drop in your project root
├── templates/
│   ├── prd-template.md                 # Blank PRD structure
│   ├── launch-plan.md                  # Launch planning template
│   ├── okr-template.md                 # OKR scorecard
│   └── sprint-review.md               # Sprint review template
└── .claude/
    └── skills/
        ├── prd-writer/                 # "write a PRD" → structured PRD with clarifying questions
        ├── competitive-analysis/       # "analyze competitor" → smart/weak/implications framework
        ├── launch-checklist/           # "launch checklist" → risk-scaled pre/post launch plan
        ├── metrics-definer/            # "define metrics" → primary, guardrail, and anti-metrics
        ├── sprint-planner/             # "plan sprint" → capacity-checked sprint with risks
        └── user-research/              # "synthesize research" → evidence-ranked findings
```

## Configuración rápida

**Paso 1:** Copie `CLAUDE.md` en la raíz de su proyecto:
```bash
cp CLAUDE.md /path/to/your/project/
```

**Paso 2:** Copie la carpeta skills:
```bash
cp -r .claude/ /path/to/your/project/
```

**Paso 3:** Abre Claude Code en tu proyecto. Se carga automáticamente.

Listo. Claude ahora sabe que eres un PM, sigue tu estilo de escritura y escribe PRDs bajo demanda.

## Qué hace el archivo CLAUDE.md

`CLAUDE.md` es un archivo de configuración ligero — no un manual. Le dice a Claude quién eres, cómo escribir y qué reglas seguir. Completa los campos `[FILL IN]` en la parte superior (~2 minutos), y el resto funciona de inmediato:

- **Tu contexto** — rol, producto, métricas, OKRs, terminología
- **Reglas de escritura** — tono impuesto, palabras prohibidas, estándares de salida
- **Roles de sub-agentes** — 6 revisores en una tabla (ingeniero, diseñador, ejecutivo, escéptico, cliente, analista de datos)
- **Estándares de salida** — preguntas aclaratorias antes de generar, métricas con líneas base, riesgos con mitigaciones
- **Referencia de habilidades** — apunta a `.claude/skills/` sin duplicar su lógica
- **Conexiones MCP** — tus integraciones (Notion, Jira, Slack, etc.)

El archivo es intencionalmente de menos de 60 líneas. Claude sigue mejor instrucciones cortas y específicas que largas.

## Qué hace la habilidad de escritor de PRD

Di "escribe un PRD" o "crea un PRD para [característica]" y Claude:

1. Hace 3-5 preguntas aclaratorias primero (nunca genera a ciegas)
2. Sigue un formato estructurado: hipótesis, problema, solución, métricas, no objetivos
3. Marca la información faltante con marcadores `[NEED: data from X]`
4. Lo mantiene en menos de 2 páginas salvo que pidas más
5. Incluye métricas de éxito con números específicos y límites

## Cómo sacar el máximo provecho de esta configuración

### Encadenar sub-agentes

Escribe un PRD → "Revisar como ingeniero" → arregla huecos → "Revisar como escéptico" → ajusta suposiciones → "Revisar como cliente" → simplifica la propuesta de valor. Tres pasadas, tres minutos, especificación mucho mejor.

### Usa referencias @

No pegues documentos en el chat — señala hacia ellos:

```
Read @templates/prd-template.md and use that structure.
Summarize @meeting-notes/standup-03-04.md into action items.
Compare @competitor-notes/notion.md against @competitor-notes/monday.md.
```

Claude lee el archivo bajo demanda. Tu ventana de contexto se mantiene limpia.

### Usar Modo Plan (Shift+Tab)

Actívalo antes de tareas complejas. Obliga a Claude a esbozar su enfoque antes de ejecutar. Aprobás el plan y luego se ejecuta. Ideal para PRDs con preguntas abiertas, ediciones en múltiples archivos, o cualquier cosa donde "deshacer" sea costoso.

### Configurar Hooks

A diferencia de las instrucciones de CLAUDE.md (consultivas), los hooks se ejecutan de forma determinista:

```
"Write a hook that spell-checks every file after I edit it"
"Write a hook that blocks writes to /templates/"
"Write a hook that runs a word count check — block any PRD over 1500 words"
```
Configura a través de `/hooks` o `.claude/settings.json`. Código de salida 0 = continuar, código de salida 2 = bloquear con retroalimentación.

### Gestión de Sesiones

- **`/clear` entre tareas no relacionadas.** La contaminación del contexto es el asesino número 1 de la calidad.
- **Limita las conversaciones a ~50 intercambios.** La calidad se degrada más allá de esto.
- **Usa traspasos.** Antes de terminar una sesión larga: "Escribe un HANDOFF.md." Siguiente sesión: "Lee @HANDOFF.md y continúa."
- **Ejecuta sesiones paralelas.** Múltiples terminales, cada uno con su propia instancia de Claude y ventana de contexto.
- **Reanuda sesiones.** `claude --continue` para la última sesión, `claude --resume` para elegir de historial.

### Haz que CLAUDE.md se Mejore Solo

Cuando Claude comete un error, corrígelo y luego: "Agrega una regla a CLAUDE.md para que no cometas ese error otra vez." Claude propone la regla, tú la apruebas, él edita el archivo. En la siguiente sesión, la regla se carga automáticamente. Poda trimestralmente.

### Personaliza las Habilidades

Las habilidades vienen con ejemplos genéricos. Reemplázalos con ejemplos reales de tu producto. Un planificador de sprint que conoce la velocidad de tu equipo supera uno genérico siempre.

### Introduce Artefactos Reales

No describas tu hilo de Slack — pégalo. No resumas la entrevista al usuario — pégala transcrita. Las habilidades extraen y estructuran información desordenada; las entradas en crudo producen la mejor salida.

### Referencia Rápida


```
/clear              Reset context (CLAUDE.md reloads automatically)
/hooks              Configure automation hooks
/init               Generate a starter CLAUDE.md from your project
/permissions        Set tool access rules
Shift+Tab           Toggle Plan Mode
Esc                 Cancel current generation
claude --continue   Resume last session
claude --resume     Pick a specific past session
claude -p "prompt"  Non-interactive single prompt
```

---

## ¿Quieres la Configuración Completa?

Esta configuración cubre el flujo de trabajo principal de PM. El sistema operativo completo de PM cubre cada tarea de PM que ejecuto a diario:

- Más de 41 habilidades personalizadas para cada tarea de PM
- 7 perspectivas de sub-agentes (ingeniero, diseñador, ejecutivo, escéptico, cliente, analista de datos, legal)
- Biblioteca de contexto con tus OKRs, terminología y estructura del equipo
- Plantillas para lanzamientos, hojas de ruta, retrospectivas y planificación de sprints
- Ganchos para corrección automática de ortografía y protección de archivos

**[Obtén el sistema operativo completo de PM →](https://www.news.aakashg.com/p/pm-os)**

---

Creado por [Aakash Gupta](https://www.aakashg.com) | [Boletín de Crecimiento de Producto](https://www.news.aakashg.com)

---

## Solución de Problemas

Problemas comunes y sus soluciones.

### Claude parece no seguir mis instrucciones CLAUDE.md

- **Verifica la ubicación del archivo.** CLAUDE.md debe estar en la raíz de tu proyecto (el directorio donde ejecutas `claude`). Claude Code lo carga automáticamente desde el directorio de trabajo.
- **Verifica el tamaño del archivo.** Más allá de ~150 líneas, Claude comienza a ignorar las instrucciones. Poda agresivamente. Mueve el conocimiento del dominio a habilidades.
- **Verifica instrucciones contradictorias.** Reglas contradictorias producen comportamientos impredecibles. Revisa en busca de conflictos.
- **Reinicia la sesión.** Ejecuta `/clear` o inicia una nueva terminal. Claude carga CLAUDE.md al inicio de la sesión.

### Las habilidades no se activan

- **Verifica la ruta.** Las habilidades deben estar en `.claude/skills/<nombre-de-habilidad>/SKILL.md` (la mayúscula y minúscula exacta importa).
- **Verifica el disparador.** El SKILL.md necesita una frase disparadora clara que coincida con cómo preguntas. Si tu SKILL.md dice "se activa cuando el usuario pide escribir un PRD" pero tú dices "redacta una especificación," Claude puede no conectarlos.
- **Prueba con una solicitud explícita.** Intenta: "Usa la habilidad prd-writer para escribir un PRD para X." Si eso funciona pero el lenguaje natural no, refina la descripción del disparador.
- **Verifica que SKILL.md no esté vacío o mal formado.** Ábrelo y verifica que tenga contenido.

### Claude olvida el contexto a mitad de conversación

- **Límites de contexto.** Las conversaciones largas se degradan después de ~50 intercambios. Usa `/clear` y empieza de nuevo con un resumen.
- **Usa transferencias.** Antes de limpiar, haz que Claude escriba un HANDOFF.md resumiendo estado, decisiones y próximos pasos. Inicia la nueva sesión con "Lee @HANDOFF.md y continúa."
- **Evita pegar documentos enormes.** Usa referencias `@` en lugar de pegar documentos enteros en el chat.

### Los hooks no se ejecutan

- **Revisa `.claude/settings.json`.** Los hooks se configuran ahí, no en CLAUDE.md.
- **Revisa códigos de salida.** Los hooks usan salida 0 (proceder) y salida 2 (bloquear + retroalimentación). Otros códigos pueden causar comportamiento inesperado.
- **Revisa permisos.** Los scripts de hook deben ser ejecutables (`chmod +x`).

### Los servidores MCP no se conectan

- **Verifica credenciales.** La mayoría de servidores MCP requieren claves API o tokens OAuth. Confirma que los tuyos estén vigentes.
- **Revisa configuración del servidor.** Las conexiones MCP se configuran en ajustes de Claude Code, no en CLAUDE.md. CLAUDE.md solo documenta para referencia.
- **Reinicia Claude Code.** Las conexiones MCP se inicializan al arrancar.

### "Cambié CLAUDE.md pero nada cambió"

Claude lee CLAUDE.md al iniciar sesión. Las ediciones a mitad de sesión requieren recarga:
1. Ejecuta `/clear` para reiniciar contexto (CLAUDE.md se recarga automáticamente)
2. O inicia una nueva sesión de terminal


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---