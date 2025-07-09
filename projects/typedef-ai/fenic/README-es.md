<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: el dataframe (re)construido para la inferencia de LLM

[![Versión PyPI](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Versiones de Python](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![Licencia](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Documentación**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic es un framework de DataFrame inspirado en PySpark, creado por typedef.ai, para desarrollar aplicaciones de IA y agentes. Transforma datos estructurados y no estructurados en conocimientos utilizando operaciones de DataFrame familiares, mejoradas con inteligencia semántica. Con soporte nativo para markdown, transcripciones y operadores semánticos, además de inferencia por lotes eficiente en cualquier proveedor de modelos.
## Instalación

fenic es compatible con Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Configuración del proveedor de LLM

fenic requiere una clave API de al menos un proveedor de LLM. Establece la variable de entorno adecuada para el proveedor que elijas:

```bash
# Para OpenAI
export OPENAI_API_KEY="tu-clave-api-de-openai"

# Para Anthropic
export ANTHROPIC_API_KEY="tu-clave-api-de-anthropic"

# Para Google
export GEMINI_API_KEY="tu-clave-api-de-google"
```

## Inicio rápido

La forma más rápida de aprender sobre fenic es revisando los ejemplos.

A continuación se muestra una lista rápida de los ejemplos en este repositorio:

| Ejemplo                                                                 | Descripción                                                                                                                         |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| [¡Hola Mundo!](examples/hello_world)                                    | Introducción a la extracción y clasificación semántica utilizando los operadores principales de fenic a través del análisis de registros de errores.                     |
| [Enriquecimiento](examples/enrichment)                                  | DataFrames de múltiples etapas con extracción de texto basada en plantillas, joins y transformaciones potenciadas por LLM, demostradas mediante el enriquecimiento de registros. |
| [Procesamiento de Transcripciones de Reuniones](examples/meeting_transcript_processing) | Análisis nativo de transcripciones, integración de esquemas Pydantic y agregaciones complejas mostradas a través del análisis de reuniones.                    |
| [Análisis de Noticias](examples/news_analysis)                                 | Analiza y extrae información valiosa de artículos de noticias utilizando operadores semánticos y procesamiento de datos estructurados.                            |
| [Resumen de Podcasts](examples/podcast_summarization)                 | Procesa y resume transcripciones de podcasts con análisis consciente de los interlocutores y extracción de puntos clave.                                     |
| [Unión Semántica](examples/semantic_joins)                                | En lugar de una simple coincidencia difusa, utiliza la potente funcionalidad de unión semántica de fenic para emparejar datos entre tablas.                     |
| [Reconocimiento de Entidades Nombradas](examples/named_entity_recognition)           | Extrae y clasifica entidades nombradas de texto usando extracción y clasificación semántica.                                         |
| [Procesamiento de Markdown](examples/markdown_processing)                     | Procesa y transforma documentos markdown con extracción de datos estructurados y formateo.                                            |
| [Procesamiento de JSON](examples/json_processing)                             | Maneja estructuras de datos JSON complejas con operaciones semánticas y validación de esquemas.                                                 |
| [Agrupación de Retroalimentación](examples/feedback_clustering)                     | Agrupa y analiza retroalimentación usando similitud semántica y operaciones de agrupamiento.                                                     |
| [Extracción de Documentos](examples/document_extraction)                             | Extrae información estructurada de varios formatos de documentos usando operadores semánticos.                                              |

(Siéntete libre de hacer clic en cualquier ejemplo anterior para ir directamente a su carpeta.)
## ¿Por qué usar fenic?

fenic es un framework de DataFrame inspirado en PySpark y con opiniones definidas, diseñado para construir aplicaciones de IA y agentes en producción.

A diferencia de las herramientas de datos tradicionales adaptadas para LLMs, el motor de consultas de fenic está construido desde cero con la inferencia como objetivo principal.

Transforma datos estructurados y no estructurados en insights utilizando operaciones de DataFrame familiares, mejoradas con inteligencia semántica. Con soporte de primera clase para markdown, transcripciones y operadores semánticos, además de inferencia por lotes eficiente en cualquier proveedor de modelos.

fenic aporta la fiabilidad de los pipelines de datos tradicionales a las cargas de trabajo de IA.

### Características clave

#### Diseñado específicamente para la inferencia con LLM

- Motor de consultas diseñado desde cero para cargas de trabajo de IA, no adaptado
- Optimización automática por lotes para llamadas a API
- Lógica de reintento incorporada y limitación de velocidad
- Conteo de tokens y seguimiento de costos

#### Operadores semánticos como ciudadanos de primera clase
- `semantic.analyze_sentiment` - Análisis de sentimiento incorporado
- `semantic.classify` - Clasifica texto con ejemplos few-shot
- `semantic.extract` - Transforma texto no estructurado en datos estructurados con esquemas
- `semantic.group_by` - Agrupa datos por similitud semántica
- `semantic.join` - Une DataFrames según el significado, no solo los valores
- `semantic.map` - Aplica transformaciones en lenguaje natural
- `semantic.predicate` - Crea predicados usando lenguaje natural para filtrar filas
- `semantic.reduce` - Agrega datos agrupados con operaciones LLM

#### Soporte nativo para datos no estructurados

Va más allá de los tipos de datos multimodales típicos (audio, imágenes) al crear tipos especializados para cargas de trabajo centradas en texto:

- Análisis y extracción de Markdown como un tipo de dato de primera clase
- Procesamiento de transcripciones (SRT, formatos genéricos) con reconocimiento de oradores y marcas de tiempo
- Manipulación de JSON con expresiones JQ para datos anidados
- Fragmentación automática de texto con solapamiento configurable para documentos largos

#### Infraestructura lista para producción
- Soporte para múltiples proveedores (OpenAI, Anthropic, Gemini)
- Backends de ejecución local y en la nube
- Manejo de errores y registro de logs integral
- Integración con Pydantic para seguridad de tipos

#### API de DataFrame Familiar

- Operaciones compatibles con PySpark
- Evaluación perezosa y optimización de consultas
- Soporte SQL para consultas complejas
- Integración fluida con pipelines de datos existentes

### ¿Por qué DataFrames para aplicaciones LLM y agénticas?

Las aplicaciones de IA y agénticas son fundamentalmente pipelines y flujos de trabajo, exactamente para lo que fueron diseñadas las APIs de DataFrame. En lugar de reinventar patrones para la transformación, filtrado y agregación de datos, fenic aprovecha décadas de prácticas de ingeniería comprobadas.

#### Arquitectura desacoplada para mejores agentes

fenic crea una separación clara entre tareas de inferencia pesadas e interacciones en tiempo real de los agentes. Al mover el procesamiento por lotes fuera del tiempo de ejecución del agente, se obtiene:

- Agentes más predecibles y responsivos
- Mejor utilización de recursos con llamadas LLM por lotes
- Separación más limpia entre la planificación/orquestación y la ejecución
#### Construido para Todos los Ingenieros

Los DataFrames no son solo para profesionales de datos. El diseño de la API fluida y componible la hace accesible para cualquier ingeniero:

- Encadena operaciones de forma natural: `df.filter(...).semantic.group_by(...)`
- Mezcla estilos imperativos y declarativos sin problemas
- Comienza rápidamente con patrones familiares de pandas/PySpark o SQL

## Soporte

Únete a nuestra comunidad en [Discord](https://discord.gg/GdqF3J7huR) donde puedes conectarte con otros usuarios, hacer preguntas y obtener ayuda con tus proyectos de fenic. ¡Nuestra comunidad siempre está feliz de dar la bienvenida a los recién llegados!

Si encuentras útil fenic, considera darnos una ⭐ en la parte superior de este repositorio. ¡Tu apoyo nos ayuda a crecer y mejorar el framework para todos!

## Contribuciones

¡Damos la bienvenida a contribuciones de todo tipo! Ya sea que te interese escribir código, mejorar la documentación, probar funciones o proponer nuevas ideas, tu ayuda es valiosa para nosotros.

Para los desarrolladores que planean enviar cambios de código, te animamos a abrir primero un issue para discutir tus ideas antes de crear un Pull Request. Esto ayuda a garantizar la alineación con la dirección del proyecto y evita esfuerzos duplicados.

Por favor, consulta nuestras [directrices de contribución](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) para información detallada sobre el proceso de desarrollo y la configuración del proyecto.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---