# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
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

## 🧸 Visión general

BIRD-INTERACT, un benchmark interactivo de texto a SQL, **re-imagina la evaluación Text-to-SQL mediante la lente de interacciones dinámicas**.
El entorno combina una base de conocimiento jerárquica, documentación de base de datos y un simulador de usuario basado en funciones para recrear entornos empresariales auténticos en operaciones **CRUD** completas.
Ofrece dos modos de prueba rigurosos: (1) **Interacción Conversacional** pasiva y (2) **Interacción Agéntica** activa, abarcando 600 tareas anotadas, incluyendo Inteligencia de Negocios (BI), operaciones CRUD, etc., cada una protegida por casos de prueba ejecutables.
Las evaluaciones típicas desencadenan entre 1,968 y 5,496 turnos de interacción entre el modelo y el simulador de usuario, mientras que los modelos de razonamiento de última generación actualmente resuelven solo **≈24%** y **≈18%** de las tareas, lo que subraya el desafío del benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dos modos de evaluación

BIRD-INTERACT soporta dos modos de evaluación como se menciona arriba:

   - **c-Interact**: Interacción Conversacional, que es un modo pasivo y el flujo de trabajo es fijo. El código e información detallada se puede encontrar en `bird_interact_conv`.
   - **a-Interact**: Interacción Agéntica, que es un modo activo encarnado donde el flujo de trabajo es dinámico y dirigido por los modelos. El código e información detallada se puede encontrar en `bird_interact_agent`.


### 🐣 Versión Lite

Estamos lanzando una versión lite de BIRD-INTERACT, `bird-interact-lite-exp`, que incluye 270 tareas de alta calidad del mundo real específicamente para PostgreSQL. Este es un buen punto de partida para experimentación rápida. 

### 🦜 Versión Completa

La versión completa de BIRD-INTERACT, `bird-interact-full`, es un benchmark integral que incluye 600 tareas para PostgreSQL. Cubre una amplia gama de operaciones SQL y consultas de usuario. La versión completa estará disponible próximamente.

### Resultados de desempeño de modelos en BIRD-INTERACT Lite

#### 1. Desempeño de **c-Interact**
| Rank | Nombre del Modelo   | Recompensa Normalizada | Nivel              |
|:------:|---------------------|:---------------------:|:------------------:|
| 1    | o3-mini              | 33.04                 | 🏆 Chat Excelente  |
| 2    | GPT-4o               | 30.33                 | 💎 Chat Bueno      |
| 3    | Gemini-2.0-flash     | 27.41                 | 💎 Chat Bueno      |
| 4    | Claude-3.7-sonnet    | 26.60                 | ✨ Estándar        |
| 5    | DeepSeek-R1          | 21.74                 | ✨ Estándar        |
| 6    | Qwen3                | 20.33                 | ⚪ Básico          |
| 7    | DeepSeek-V3          | 15.85                 | ⚪ Básico          |

#### 2. Desempeño de **a-Interact**
| Rank | Nombre del Modelo   | Parámetros de Presupuesto* | Prom. Turnos/Tarea | Prom. Costo (USD)/Tarea | Recompensa Normalizada | Nivel                   |
|:------:|---------------------|:--------------------------:|:-------------------:|:------------------------:|:----------------------:|:------------------------:|
| 1    | Claude-3.7-sonnet    | 6/6                        | 15.4                | $0.6668                  | 29.19                  | 🏆 Interacción Excelente |
| 2    | o3-mini              | 6/6                        | 7.8                 | $0.0754                  | 21.07                  | 💎 Interacción Buena     |
| 3    | DeepSeek-V3          | 6/6                        | 15.6                | $0.0629                  | 19.19                  | 💎 Interacción Buena     |
| 4    | Qwen3                | 6/6                        | 12.5                | $0.0278                  | 18.74                  | ✨ Estándar              |
| 5    | GPT-4o               | 6/6                        | 15.3                | $0.4594                  | 18.37                  | ✨ Estándar              |
| 6    | Gemini-2.0-flash     | 6/6                        | 13.2                | $0.0337                  | 17.26                  | ⚪ Básico                |
| 7    | DeepSeek-R1          | 6/6                        | 12.0                | $0.0931                  | 17.07                  | ⚪ Básico                |

> \* Parámetros de Presupuesto: Presupuesto Inicial/Presupuesto de Paciencia del Usuario, medido por nuestra moneda virtual *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulta [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) para más detalles.

### Escalado en Tiempo de Interacción (ITS)

El Escalado en Tiempo de Interacción (ITS) se refiere a la capacidad de un modelo para aumentar continuamente su desempeño final mediante interacciones de múltiples turnos. Cuando este desempeño interactivo supera el desempeño idealizado de turno único del modelo en una tarea completamente especificada y no ambigua, decimos que satisface la **ley ITS**. A medida que la paciencia del usuario crece y se acumulan los turnos de interacción, el desempeño sigue mejorando, demostrando que el modelo puede mantener una comunicación efectiva a lo largo de diálogos extendidos. Actualmente, solo encontramos que claude-3-7-sonnet satisface la ley ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Detalles del Conjunto de Datos

### Descripción del Conjunto de Datos

- **Base de Datos:** La base de datos completa de PostgreSQL se puede descargar desde [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Consulta la sección [Quick Eval](#quick-eval) para más detalles.
- **data:** Cada instancia de datos contiene las siguientes partes principales:
   - `selected_database`: El nombre de la base de datos.  
   - `query`: La consulta de usuario no ambigua.  
   - `amb_user_query`: La consulta de usuario con ambigüedades inyectadas.
   - `user_query_ambiguity`: Las ambigüedades inyectadas en la consulta de usuario.
   - `non_critical_ambiguity`: Las ambigüedades no críticas como orden, límite, etc.
   - `knowledge_ambiguity`: Las ambigüedades creadas por conocimientos externos enmascarados.
   - `sol_sql`: La solución SQL de referencia (ground truth).
   - `preprocess_sql`: Consultas SQL que se ejecutan antes de la solución o predicción.
   - `clean_up_sql`: Consultas SQL que se ejecutan después de los casos de prueba para revertir los cambios realizados en la base de datos.
   - `test_cases`: Un conjunto de casos de prueba para validar el SQL corregido predicho.
   - `follow_up`: Las preguntas de seguimiento etiquetadas.
   - `external_knowledge`: El conocimiento externo relacionado con la tarea específica.

- **evaluación:** El código de evaluación está disponible en el directorio [`./evaluation`](./evaluation).
- **Curado por:** Equipo BIRD & Google Cloud
- **Licencia:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Tarjeta del Dataset en HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Usos del Conjunto de Datos

Para evitar fugas de datos por rastreo automático, no incluimos las soluciones SQL de referencia ni los casos de prueba junto con los datos.
Por favor, envía un correo a [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) con la etiqueta `[bird-interact-lite GT&Test Cases]` en el título para obtener el conjunto completo, que será enviado automáticamente.


<!-- ### Utiliza el Dataset desde HuggingFace

Puedes descargar el dataset desde HuggingFace usando el siguiente comando:
```bash
from datasets import load_dataset
# Cargar la versión lite del dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Cargar la versión completa del dataset (próximamente)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

O puedes usar el script provisto para descargar la versión completa del dataset y dividirlo en diferentes dialectos.
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # Ruta al archivo JSONL de entrada (puede estar vacío si deseas descargar el dataset desde HuggingFace)
  --output_folder path/to/output_dir # carpeta de salida de los archivos divididos
``` -->

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
Los detalles sobre cómo ejecutar **a-interact** pueden encontrarse en `./bird_interact_agent/README.md`; y **c-interact** en `./bird_interact_conv/README.md`.


## 📋 Listas de Tareas

- [x] Publicar la versión lite, bird-interact-lite (270).
- [x] Publicar la versión conversacional, bird-interact-conv.
- [x] Publicar la versión agente, bird-interact-agent.
- [ ] Publicar la versión completa bird-interact-full (600).
- [ ] SFT / RL y un Simulador de Usuario

## Creado por:
Equipo BIRD & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---