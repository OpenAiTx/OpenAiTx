
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="Licencia">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Tabla de clasificación">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 📰 Noticias

- [2025-08-26] 🚀 ¡Nos complace anunciar el lanzamiento del conjunto **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Es difícil — los mejores LLM solo alcanzan una tasa de éxito de **16,33%**, con apenas **10,0%** en las porciones `c-interact` y `a-interact`.  
👉 Para más detalles, visita nuestro [sitio web del proyecto](https://bird-interact.github.io/).

- [2025-08-26] 📬 Esta semana enviaremos los **Ground Truth & Casos de prueba** a nuestra lista de correo.  
Si deseas acceso anticipado, envía un correo como se indica en el sitio para una **descarga automática**.  

- [2025-08-26] 💾 Además, hemos lanzado una versión SQLite de **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** para facilitar la investigación local.  
Las versiones completas **LiveSQLBench-Base** y **-Large** estarán disponibles pronto.

- [2025-08-22] **Corrección de error**: En el código Bird-Interact-Agent, corregimos un error donde, al evaluar SQL de la fase-2, el SQL almacenado de la fase-1 no se ejecutaba correctamente, lo que provocaba una menor tasa de éxito en la Fase-2. Este error solo afecta aquellas tareas donde el sql de la fase1 realiza operaciones en la base de datos, por ejemplo, CREATE table, etc.

## 🧸 Descripción general

BIRD-INTERACT, un benchmark interactivo de texto a SQL, **reimagina la evaluación Text-to-SQL a través de la lente de interacciones dinámicas**.
El entorno combina una base de conocimientos jerárquica, documentación de base de datos y un simulador de usuario basado en funciones para recrear entornos empresariales auténticos en operaciones completas **CRUD**.
Ofrece dos modos de prueba rigurosos: (1) **Interacción Conversacional** pasiva y (2) **Interacción Agente** activa, abarcando 600 tareas anotadas incluyendo Inteligencia de Negocios (BI), operaciones CRUD, etc., cada una respaldada por casos de prueba ejecutables.
Las evaluaciones típicas desencadenan entre 1.968 y 5.496 turnos de interacción entre el modelo y el simulador de usuario, mientras que los modelos de razonamiento más avanzados actualmente resuelven solo **≈24%** y **≈18%** de las tareas, lo que destaca el desafío del benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dos modos de evaluación

BIRD-INTERACT soporta dos modos de evaluación como se mencionó anteriormente:

   - **c-Interact**: Interacción conversacional, que es un modo pasivo y el flujo de trabajo está fijado. El código e información detallada se encuentra en `bird_interact_conv`.
   - **a-Interact**: Interacción agente, que es un modo activo incorporado donde el flujo de trabajo es dinámico y dirigido por modelos. El código e información detallada se encuentra en `bird_interact_agent`.


### 🐣 Versión Lite

Estamos lanzando una versión ligera de BIRD-INTERACT, `bird-interact-lite-exp`, que incluye 270 tareas reales de alta calidad específicamente para PostgreSQL. Es un buen punto de partida para experimentación rápida.

### 🦜 Versión Completa

La versión completa de BIRD-INTERACT, `bird-interact-full`, es un benchmark integral que incluye 600 tareas para PostgreSQL. Cubre una amplia gama de operaciones SQL y consultas de usuarios. La versión completa estará disponible pronto.

### Resultados de rendimiento de modelos en BIRD-INTERACT Lite

#### 1. **Desempeño c-Interact**
| Rango | Nombre del modelo  | Recompensa normalizada | Nivel          |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat excelente |
| 2    | GPT-4o             | 30.33 | 💎 Chat bueno      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat bueno      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Estándar        |
| 5    | DeepSeek-R1        | 21.74 | ✨ Estándar        |
| 6    | Qwen3              | 20.33 | ⚪ Básico          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Básico          |

#### 2. **Desempeño a-Interact**
| Rango | Nombre del modelo  | Parámetros de presupuesto* | Prom. pasos/tarea | Prom. coste (USD)/tarea | Recompensa normalizada | Nivel                  |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Interacción excelente |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Interacción buena     |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Interacción buena     |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Estándar              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Estándar              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Básico                |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Básico                |

> \* Parámetros de presupuesto: Presupuesto inicial/Presupuesto de paciencia del usuario, medido por nuestra moneda virtual *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulta [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) para más detalles.

### Escalamiento de Tiempo de Interacción (ITS)

El Escalamiento de Tiempo de Interacción (ITS) se refiere a la capacidad de un modelo para incrementar continuamente su rendimiento final a través de interacciones de múltiples turnos. Cuando este rendimiento interactivo supera el rendimiento idealizado de turno único en una tarea completamente especificada y sin ambigüedades, decimos que satisface la **ley ITS**. A medida que aumenta la paciencia del usuario y se acumulan los turnos de interacción, el rendimiento sigue mejorando, demostrando que el modelo puede mantener una comunicación eficaz durante diálogos prolongados. Actualmente, solo encontramos que claude-3-7-sonnet satisface la ley ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Detalles del conjunto de datos

### Descripción del conjunto de datos

- **Base de datos:** La base de datos completa de PostgreSQL puede descargarse desde [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Consulta la sección [Quick Eval](#quick-eval) para más detalles.
- **data:** Cada instancia de datos contiene las siguientes partes principales:
   - `selected_database`: El nombre de la base de datos.  
   - `query`: La consulta de usuario sin ambigüedades.  
   - `amb_user_query`: La consulta de usuario con ambigüedades inyectadas.
   - `user_query_ambiguity`: Las ambigüedades inyectadas en la consulta del usuario.
   - `non_critical_ambiguity`: Ambigüedades no críticas como orden, límite, etc.
   - `knowledge_ambiguity`: Las ambigüedades creadas por conocimientos externos enmascarados. 
   - `sol_sql`: La solución SQL de referencia.  
   - `preprocess_sql`: Consultas SQL para ejecutar antes de la solución o predicción.  
   - `clean_up_sql`: Consultas SQL para ejecutar después de los casos de prueba y revertir cualquier cambio en la base de datos.  
   - `test_cases`: Un conjunto de casos de prueba para validar el SQL corregido predicho.
   - `follow_up`: Las preguntas de seguimiento etiquetadas.
   - `external_knowledge`: El conocimiento externo relacionado con la tarea específica.

- **evaluación:** El código de evaluación está disponible en el directorio [`./evaluation`](./evaluation).
- **Curado por:** Equipo BIRD y Google Cloud
- **Licencia:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Tarjeta de conjunto de datos en HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Usos del conjunto de datos

Para evitar la filtración de datos mediante rastreo automático, no incluimos las soluciones GT sql y los casos de prueba junto con los datos.
por favor escriba a [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) con la etiqueta `[bird-interact-lite GT&Test Cases]` en el título para recibir el conjunto completo, que será enviado automáticamente.


<!-- ### Utilizar el conjunto de datos de HuggingFace

Puede descargar el conjunto de datos de HuggingFace utilizando el siguiente comando:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
O puedes usar el script proporcionado para descargar la versión completa del conjunto de datos y dividirlo en diferentes dialectos.

```bash
cd baseline/data
python pull_data.py \
  --schema_path ruta/a/full_schema.jsonl \
  --input_path ruta/a/input.jsonl \ # Ruta al archivo JSONL de entrada (puede estar vacío si desea descargar el conjunto de datos de HuggingFace)
  --output_folder ruta/a/output_dir # carpeta de salida de los archivos divididos
```

## Estructura de Carpetas
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
Los detalles sobre cómo ejecutar **a-interact** se pueden encontrar en `./bird_interact_agent/README.md`; y **c-interact** se pueden encontrar en `./bird_interact_conv/README.md`.

## 📋 Listas de tareas

- [x] Lanzar la versión lite, bird-interact-lite (270).
- [x] Lanzar la versión conversacional, bird-interact-conv.
- [x] Lanzar la versión de agente, bird-interact-agent.
- [x] Lanzar bird-interact-full completo (600).
- [ ] SFT / RL para un Simulador de Usuario

## Creado por:
Equipo BIRD & Google Cloud





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---