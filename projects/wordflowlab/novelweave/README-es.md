# NovelWeave - Extensión de VSCode para Escritura de Novelas con IA

[English](#) | [简体中文](https://raw.githubusercontent.com/wordflowlab/novelweave/main/README.zh-CN.md)

> 🌟 Transforma tu experiencia de escritura de novelas con asistencia impulsada por IA, metodología estructurada e integración fluida en VSCode.
>
> Basado en la metodología comprobada de [novel-writer](https://github.com/wordflowlab/novel-writer), NovelWeave trae herramientas profesionales de creación de novelas directamente a tu flujo de trabajo en VSCode.

## ✨ Características Clave

- 📝 **Metodología de Siete Pasos** - Flujo de trabajo de creación de novelas basado en especificaciones
- 🎨 **Interfaz Visual** - Barra lateral intuitiva, paneles webview y chat de IA integrado
- 🤖 **Soporte Multi-IA** - Claude 4, GPT-4, Gemini Pro y más de 400 modelos de IA
- 🧠 **Habilidades de Agente** - Sistema modular de conocimiento de IA para experiencia especializada en escritura
- 📊 **Gestión de Proyectos** - Seguimiento de capítulos, perfiles de personajes, hilos argumentales
- 🔌 **Comandos Slash** - Soporte completo para el sistema de comandos de novel-writer
- ✅ **Aseguramiento de Calidad** - Seguimiento de trama, gestión de cronograma, validación de consistencia
- 🌐 **Multiplataforma** - Funciona en Windows, macOS y Linux

## 🚀 Inicio Rápido

### 1. Instalación

Instala NovelWeave desde el Marketplace de VSCode:

```bash
# Search "NovelWeave" in VSCode Extensions
# Or install via command:
code --install-extension novelweave.novelweave
```

### 2. Crea tu Primer Proyecto de Novela

1. Abre VSCode y haz clic en el ícono de NovelWeave en la barra de actividades
2. Haz clic en "Nuevo Proyecto" para iniciar un proyecto de novela
3. Elige tu modelo de IA y configura los ajustes
4. ¡Comienza a escribir con la asistencia de la IA!

### 3. Usa la Metodología de Siete Pasos

NovelWeave implementa la metodología probada de creación de novelas en siete pasos:

```
1. /constitution  → Establish core creative principles
2. /specify       → Define story requirements
3. /clarify       → Resolve ambiguities through Q&A
4. /plan          → Design technical implementation
5. /tasks         → Break down into actionable steps
6. /write         → Execute the actual writing
7. /analyze       → Validate quality and consistency
```

## 📚 Metodología de Siete Pasos

### Paso 1: `/constitution` - Constitución Creativa

Define tus principios de escritura innegociables, directrices de estilo y valores fundamentales que guiarán toda tu novela.

### Paso 2: `/specify` - Especificación de la Historia

Como un documento de requisitos de producto (PRD), define exactamente qué historia quieres crear, público objetivo y criterios de éxito.

### Paso 3: `/clarify` - Aclaraciones Críticas

La IA identifica ambigüedades en tu especificación y genera hasta 5 preguntas clave para eliminar confusiones antes de escribir.

### Paso 4: `/plan` - Plan Creativo

Transforma requisitos abstractos en soluciones técnicas concretas: estructura de capítulos, arcos de personajes, construcción del mundo y línea temporal de la trama.

### Paso 5: `/tasks` - Desglose de Tareas

Descompone el plan en tareas de escritura ejecutables con prioridades y dependencias claras.

### Paso 6: `/write` - Ejecutar Escritura

Escribe basado en tu lista de tareas, siguiendo tus principios de constitución y plan creativo.

### Paso 7: `/analyze` - Validación Integral

Valida la consistencia de la trama, precisión de la línea temporal, desarrollo de personajes y adherencia a tus principios creativos.

> 📖 **Metodología Detallada**: Aprende más en la [documentación de novel-writer](https://github.com/wordflowlab/novel-writer)

## 🔧 NovelWeave vs novel-writer CLI

| Característica         | novel-writer CLI       | NovelWeave VSCode                   |
| ---------------------- | ---------------------- | ---------------------------------- |
| **Interfaz**           | Línea de comandos      | Interfaz gráfica                   |
| **Instalación**        | `npm install -g`       | Marketplace de VSCode              |
| **Integración AI**     | Básica                 | Chat AI completo y asistencia     |
| **Gestión de Proyectos** | Sistema de archivos    | Espacio de trabajo VSCode + paneles UI |
| **Comandos Slash**       | ✅                     | ✅                                   |
| **Seguimiento Visual**   | ❌                     | ✅ (Trama, personajes, línea de tiempo) |
| **Curva de Aprendizaje** | Se requiere familiaridad con CLI | Interfaz intuitiva                   |
| **Ideal para**           | Escritores con conocimientos técnicos | Todos los escritores, especialmente usuarios de VSCode |

**¡Funcionan juntos!** Usa novel-writer CLI para automatización y scripts, mientras que NovelWeave proporciona la interfaz visual y la interacción con IA.

## 🎯 Casos de Uso

- **Novelas de larga duración** - Gestiona tramas complejas con más de 100 capítulos
- **Escritura de series web** - Actualizaciones diarias consistentes con ayuda de IA
- **Guiones y libretos** - Narrativa estructurada con gestión de escenas
- **Fan Fiction** - Mantén la consistencia con el material original
- **Escritura creativa** - Cualquier proyecto narrativo se beneficia de metodología estructurada

## 📖 Características en Detalle

### Sistema de Habilidades del Agente

El innovador sistema de **Habilidades del Agente** de NovelWeave proporciona a tu asistente IA módulos de conocimiento especializados que pueden activarse bajo demanda:

- **Habilidades incorporadas** - Experiencia profesional en escritura incluyendo:
    - Conocimiento de géneros (Romance, Misterio, Fantasía)
    - Técnicas de escritura (Diálogo, Estructura de escenas)
    - Control de calidad (Verificación de consistencia, detección de requisitos)
- **Habilidades de proyecto** - Comparte directrices específicas del equipo en `.agent/skills/`
- **Habilidades personales** - Tu propia biblioteca de conocimientos reutilizable
- **Activación inteligente** - La IA selecciona automáticamente habilidades relevantes según tu tarea
- **Habilidades personalizadas** - Crea tus propios módulos de especialización con Markdown sencillo

> 📖 **Aprende más**: Consulta la [Guía de usuario de Habilidades del Agente](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) para instrucciones detalladas.

### Asistente de Escritura Potenciado por IA

- **Continuación inteligente** - La IA sugiere los siguientes párrafos según tu estilo
- **Voz de personajes** - Mantén personalidades consistentes de los personajes
- **Sugerencias de trama** - La IA ayuda a resolver agujeros de trama y problemas de ritmo
- **Análisis de estilo** - Retroalimentación sobre estilo de escritura y legibilidad

### Organización del Proyecto

- **Gestión de Capítulos** - Navegar y organizar capítulos en la barra lateral  
- **Perfiles de Personajes** - Rastrear desarrollo y relaciones de personajes  
- **Construcción de Mundo** - Gestionar escenarios, reglas y lore  
- **Hilos de la Trama** - Visualizar y seguir múltiples historias  

### Aseguramiento de Calidad

- **Verificación de Consistencia** - Validar rasgos de personajes, cronología y hechos  
- **Seguimiento de la Trama** - Asegurar que todos los hilos argumentales se resuelvan  
- **Gestión de Cronología** - Validación de precisión cronológica  
- **Consistencia de Estilo** - Mantener tu voz única de escritura  

## 🆕 Novedades

### v0.13.0 (Última)

- 🧠 **Sistema de Habilidades del Agente** - Arquitectura modular de conocimiento IA  
    - 14 habilidades profesionales integradas de escritura  
    - Sistema de tres niveles: Extensión, Proyecto y Habilidades Personales  
    - Autoactivación inteligente basada en el contexto de la tarea  
    - Interfaz completa para explorar, gestionar y crear habilidades personalizadas  
- ✅ Herramientas mejoradas de aseguramiento de calidad  
- 📚 Documentación completa y guías de mejores prácticas  

### v1.0

- ✅ Implementación completa de la metodología de siete pasos  
- ✅ Soporte para múltiples modelos de IA (más de 400 modelos)  
- ✅ Interfaz visual de gestión de proyectos  
- ✅ Seguimiento integrado de trama y personajes  
- ✅ Asistencia en escritura IA en tiempo real  
- ✅ Compatibilidad total con comandos slash para escritores de novelas  

## 💡 Mejores Prácticas

1. **Comienza con la Constitución** - Define tus principios antes de escribir  
2. **Usa Clarify Liberalmente** - Resuelve ambigüedades temprano para evitar reescrituras  
3. **Confía en el Proceso** - Sigue los siete pasos para obtener los mejores resultados
4. **Iterar** - Regresa a pasos anteriores a medida que tu historia evoluciona  
5. **Rastrear Consistentemente** - Actualiza los rastreadores después de cada capítulo importante  

## 🔗 Recursos Relacionados  

### Documentación  

- 📖 [Guía de Usuario de Habilidades de Agente](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) - Aprende a usar y crear Habilidades  
- 🛠️ [Guía para Desarrolladores de Habilidades de Agente](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-developer-guide.md) - Arquitectura técnica y API  
- ✍️ [Mejores Prácticas para Escribir Habilidades](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/writing-skills-best-practices.md) - Crea Habilidades de alta calidad  

### Comunidad y Herramientas  

- 📦 [Herramienta CLI novel-writer](https://github.com/wordflowlab/novel-writer) - Compañero de línea de comandos  
- 📖 [Metodología de Siete Pasos](https://github.com/wordflowlab/novel-writer/blob/main/METHODOLOGY.md) - Guía detallada de metodología  
- 💬 [Discord de la Comunidad](#) - Únete a otros escritores que usan NovelWeave  
- 📺 [Tutoriales en Video](#) - Mira guías paso a paso  

## 🤝 Contribuciones  

¡Damos la bienvenida a las contribuciones! Consulta nuestra [Guía de Contribución](https://raw.githubusercontent.com/wordflowlab/novelweave/main/CONTRIBUTING.md) para más detalles.  

## 📄 Licencia  

Licencia MIT - consulta el archivo [LICENSE](LICENSE) para más detalles.  

## 🙏 Agradecimientos  

- Construido sobre la arquitectura de [NovelWeave](https://github.com/NovelWeave-Org/novelweave)  
- Metodología de [novel-writer](https://github.com/wordflowlab/novel-writer)  
- Inspirado en los principios de [Spec Kit](https://github.com/sublayerapp/spec-kit)  

---  

**NovelWeave** - Donde la IA se encuentra con la maestría en narración ✨📚  

Hecho con ❤️ para escritores de todo el mundo


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---