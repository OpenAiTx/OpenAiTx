# AI Partner Chat

Un proyecto de Claude Skills que convierte a la IA en tu compañero de conversación personalizado.

## Introducción al proyecto

AI Partner Chat ofrece una experiencia de conversación personalizada y con conciencia contextual integrando el perfil del usuario, el perfil de la IA y notas personales vectorizadas. Esta habilidad permite que la IA recuerde y cite tus ideas, preferencias y conocimientos previos, creando una interacción más coherente y personalizada.

## Funciones principales

### 🎭 Sistema de doble perfil
- **Perfil del usuario**: define tu trasfondo, especialización, intereses y preferencias de comunicación
- **Perfil de la IA**: personaliza el rol, estilo de comunicación y modo de interacción de la IA

### 📝 Recuperación inteligente de notas
- Indexa automáticamente tus notas en Markdown
- Recupera inteligentemente registros históricos relevantes según el contenido de la conversación
- Cita naturalmente en la conversación tus ideas y notas previas

### 💬 Conversación personalizada
- Genera respuestas personalizadas basadas en tus perfiles y notas
- Mantiene la coherencia contextual en la conversación
- Cita tus ideas de manera natural como un amigo, no de forma mecánica "basada en registros"

## Escenarios de uso

Cuando necesitas:
- Comunicación personalizada, no respuestas genéricas
- Respuestas con conciencia contextual, la IA recuerda tu trasfondo
- La IA recuerda y cita tus ideas y notas previas
- Experiencia de conversación continua, no un nuevo inicio cada vez

## Instalación y uso

### Instalar la habilidad

Copia este proyecto en la carpeta `.claude/skills/` dentro de tu directorio de trabajo:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Uso de habilidades

En Claude Code, envíe la siguiente instrucción para habilitar esta habilidad:

```
遵循 ai-partner-chat 对话
```

El agente de IA hará automáticamente:
- Leer la configuración de habilidades y las instrucciones
- Crear la estructura de directorios necesaria (`notes/`, `config/`, `vector_db/`, etc.)
- Inicializar según tus necesidades

### Proceso de inicialización

#### Método 1: Permitir que la IA cree y configure automáticamente

La primera vez que uses, simplemente indica a la IA:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

El agente de IA hará lo siguiente:
1. Analizará el contenido de las notas en el directorio `notes/`
2. Creará una base de datos vectorial inteligentemente segmentada según el formato de las notas
3. Inferirá tu contexto y preferencias basándose en el contenido de las notas
4. Generará y actualizará automáticamente `config/user-persona.md`
5. Recomendará y creará `config/ai-persona.md` según tus características

#### Método 2: Configuración manual del perfil

Si deseas definir el perfil por ti mismo:
1. El agente de IA creará automáticamente archivos de perfil desde una plantilla en el directorio `config/`
2. Podrás editar manualmente estos archivos para personalizar el perfil
3. Luego indica al IA que realice el procesamiento vectorial

### Comenzar la conversación

Después de la configuración, para usar solo necesitas enviar:

```
遵循 ai-partner-chat 对话
```

La IA hará:
- Leerá tu perfil para comprender tu contexto
- Recuperará notas históricas relevantes
- Generará respuestas personalizadas y contextualmente conscientes

## Estructura del proyecto

### Estructura del paquete de habilidades (ubicado en `.claude/skills/ai-partner-chat/`)

```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Directorio de datos del usuario (ubicado en el directorio raíz del proyecto)

El agente de IA creará la siguiente estructura en el directorio raíz de tu proyecto:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Importante**: Los datos del usuario están separados del paquete de habilidades, facilitando la copia de seguridad y la migración.

## Flujo de trabajo

1. **Cargar perfil**: Leer el perfil del usuario y el perfil de IA para entender el contexto de la interacción  
2. **Recuperar notas**: Según la consulta del usuario, recuperar las notas más relevantes desde la base de datos vectorial  
3. **Construir contexto**: Integrar la información del perfil, las notas relacionadas y el historial de conversación  
4. **Generar respuesta**: Crear respuestas personalizadas y naturales basadas en el contexto  

## Características destacadas

### 🤖 Fragmentación inteligente del agente IA  
El sistema analizará el formato real de cada nota y generará dinámicamente la estrategia de fragmentación más adecuada, en lugar de usar plantillas predefinidas. Esto significa que, sin importar el formato de tus notas, serán procesadas de manera óptima.

### 🎯 Citas naturales  
La IA introducirá tu información pasada de forma natural, como si la recordara, sin decir de forma rígida "según el registro", sino integrándola fluidamente en la conversación.

### 📦 Datos independientes  
Todos tus datos (notas, perfil, base vectorial) se almacenan en el directorio raíz del proyecto, facilitando la copia de seguridad, migración o compartir entre diferentes habilidades.

## Mejores prácticas

### Diseño del perfil  
- **Claro y específico**: Un perfil vago genera respuestas genéricas  
- **Incluir ejemplos**: Mostrar en el perfil de IA el modo de interacción deseado  
- **Actualización periódica**: Optimizar el perfil continuamente según la calidad de la conversación  

### Gestión de notas  
- **Formato libre**: El sistema puede adaptarse a cualquier estructura de nota  
- **Contenido rico**: Notas profundas mejoran la efectividad de la recuperación  
- **Actualización oportuna**: Recuerda añadir las nuevas notas al índice  

### Experiencia conversacional  
- **Citas naturales**: Solo citar notas cuando realmente sean relevantes  
- **Mantener fluidez**: No permitir que las citas interrumpan el ritmo natural de la conversación  
- **Enfocarse en calidad**: Priorizar conexiones significativas sobre cantidad  

## Mantenimiento y actualización

### Agregar nueva nota
Después de colocar la nueva nota en el directorio `notes/`, informe a la IA:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

El agente de IA analizará automáticamente las nuevas notas y actualizará el índice.

### Actualizar perfil
Puedes editar directamente los archivos de perfil en el directorio `config/`, o indicarle a la IA:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Reconstruir índice
Cuando la estructura de las notas cambia significativamente, informe a la IA:

```
请重新初始化向量数据库
```

El agente de IA volverá a analizar todas las notas y reconstruirá el índice.

## Notas importantes

- **Primera ejecución**: Cuando el agente de IA cree la base de datos vectorial por primera vez, descargará automáticamente el modelo de incrustación (aproximadamente 4.3GB), por favor espere pacientemente
- **Entorno Python**: El agente de IA creará automáticamente un entorno virtual e instalará las dependencias necesarias
- **Almacenamiento de datos**: Todos los datos (notas, perfiles, base de datos vectorial) se almacenan en el directorio raíz del proyecto, no en el directorio del paquete de habilidades
- **Ubicación de la habilidad**: Asegúrese de que el paquete de habilidades esté en el directorio `.claude/skills/ai-partner-chat/`

## Más información

Para documentación técnica detallada e instrucciones de uso, consulte el archivo `SKILL.md`.

---

Haz que la IA sea un verdadero compañero de conversación que te entienda, y no solo una herramienta.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-18

---