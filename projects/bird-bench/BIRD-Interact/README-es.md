
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

## ⚠️ Anuncio  
Tenga en cuenta que antes de su proceso de evaluación, cuando Docker carga las bases de datos, pueden ocurrir errores ocasionales debido a la inconsistencia del entorno (estos no terminarán el proceso pero aparecerán en los registros de Docker). Como resultado, algunas bases de datos pueden no cargarse correctamente, lo que lleva a bases de datos vacías. Esto causará que los resultados de la evaluación sean anormalmente bajos.  
👉 Por lo tanto, recomendamos encarecidamente revisar los registros de Docker en busca de errores **antes de ejecutar la evaluación** y verificar que todas las bases de datos se hayan cargado correctamente.

## 📰 Noticias

- [2025-08-26] 🚀 ¡Estamos emocionados de anunciar el lanzamiento del conjunto **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Es un desafío — los mejores LLMs sólo logran una tasa de éxito del **16.33%**, con apenas **10.0%** en las partes `c-interact` y `a-interact`.  
👉 Para más detalles, por favor visite nuestro [sitio web del proyecto](https://bird-interact.github.io/).

- [2025-08-26] 📬 Esta semana enviaremos los **Ground Truth & Test cases** a nuestra lista de correo.  
Si desea acceso anticipado, por favor envíe un correo electrónico como se indica en el sitio para una **descarga automática**.  

- [2025-08-26] 💾 Además, hemos lanzado una versión SQLite de **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** para facilitar la investigación local.  
Las versiones completas **LiveSQLBench-Base** y **-Large** llegarán pronto.

- [2025-08-22] **Corrección de error**: En el código de Bird-Interact-Agent, corregimos un error por el cual al evaluar SQL de fase-2, el SQL almacenado de fase-1 no se podía ejecutar correctamente, lo que llevaba a una menor tasa de éxito en la Fase-2. Este error solo afecta aquellas tareas donde el SQL de fase1 realiza algunas operaciones en la base de datos, por ejemplo, CREATE table, etc.

## 🧸 Visión general

BIRD-INTERACT, un benchmark interactivo de texto a SQL, **reimagina la evaluación Text-to-SQL a través del lente de interacciones dinámicas**.
El entorno combina una base de conocimientos jerárquica, documentación de bases de datos y un simulador de usuario basado en funciones para recrear entornos empresariales auténticos a través de operaciones completas **CRUD**.
Ofrece dos modos de prueba rigurosos: (1) **Interacción Conversacional** pasiva y (2) **Interacción Agéntica** activa, abarcando 600 tareas anotadas que incluyen Inteligencia de Negocios (BI), operaciones CRUD, etc., cada una protegida por casos de prueba ejecutables.
Las evaluaciones típicas desencadenan entre 1,968 y 5,496 turnos de interacción entre el modelo y el simulador de usuario, mientras que los modelos de razonamiento más avanzados actualmente resuelven solo **≈24%** y **≈18%** de las tareas, lo que resalta el desafío del benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dos Modos de Evaluación

BIRD-INTERACT admite dos modos de evaluación como se mencionó arriba:

   - **c-Interact**: Interacción Conversacional, que es un modo pasivo y el flujo de trabajo es fijo. El código e información detallada se encuentran en `bird_interact_conv`.
   - **a-Interact**: Interacción Agéntica, que es un modo activo incorporado donde el flujo de trabajo es dinámico y dirigido por modelos. El código e información detallada se encuentran en `bird_interact_agent`.


### 🐣 Versión Lite

Estamos lanzando una versión lite de BIRD-INTERACT, `bird-interact-lite-exp`, que incluye 270 tareas del mundo real de alta calidad específicamente para PostgreSQL. Es un buen punto de partida para experimentos rápidos.

### 🦜 Versión Completa

La versión completa de BIRD-INTERACT, `bird-interact-full`, es un benchmark integral que incluye 600 tareas para PostgreSQL. Cubre una amplia gama de operaciones SQL y consultas de usuario. La versión completa estará disponible pronto.

### Resultados de Rendimiento de Modelos en BIRD-INTERACT Lite

#### 1. Desempeño de **c-Interact**
| Puesto | Nombre del Modelo  | Recompensa Normalizada | Nivel            |
|:------:|--------------------|:-------:|:----------------:|
| 1    | o3-mini            | 33.04 | 🏆 Chat Excelente  |
| 2    | GPT-4o             | 30.33 | 💎 Chat Bueno      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Chat Bueno      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Estándar        |
| 5    | DeepSeek-R1        | 21.74 | ✨ Estándar        |
| 6    | Qwen3              | 20.33 | ⚪ Básico          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Básico          |

#### 2. Desempeño de **a-Interact**
| Puesto | Nombre del Modelo  | Parámetros de Presupuesto* | Prom. Pasos/Tarea | Prom. Costo (USD)/Tarea | Recompensa Normalizada | Nivel                |
|:------:|--------------------|:--------------------------:|:-------------------:|:------------------------:|:----------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Interacción Excelente |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Buena Interacción     |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Buena Interacción     |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Estándar              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Estándar              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Básico                |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Básico                |

> \* Parámetros de presupuesto: Presupuesto inicial / Presupuesto de paciencia del usuario, medido por nuestra moneda virtual *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulta [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) para más detalles.

### Escalado del Tiempo de Interacción (ITS)

Escalado del Tiempo de Interacción (ITS) se refiere a la capacidad de un modelo para aumentar continuamente su rendimiento final mediante interacciones de varios turnos. Cuando este rendimiento interactivo supera el rendimiento idealizado de un solo turno en una tarea completamente especificada y no ambigua, decimos que satisface la **ley ITS**. A medida que crece la paciencia del usuario y se acumulan los turnos de interacción, el rendimiento sigue mejorando, demostrando que el modelo puede mantener una comunicación eficaz durante diálogos prolongados. Actualmente, solo encontramos que claude-3-7-sonnet satisface la ley ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 Detalles del Dataset

### Descripción del Dataset

- **Base de datos:** La base de datos completa de PostgreSQL se puede descargar desde [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view). Consulta la sección [Quick Eval](#quick-eval) para más detalles.
- **data:** Cada instancia de datos contiene las siguientes partes principales:
   - `selected_database`: El nombre de la base de datos.  
   - `query`: La consulta del usuario sin ambigüedad.  
   - `amb_user_query`: La consulta del usuario con ambigüedades inyectadas.
   - `user_query_ambiguity`: Las ambigüedades inyectadas en la consulta del usuario.
   - `non_critical_ambiguity`: Las ambigüedades no críticas como orden, límite, etc.
   - `knowledge_ambiguity`: Las ambigüedades creadas por conocimientos externos enmascarados. 
   - `sol_sql`: La solución SQL de referencia.  
   - `preprocess_sql`: Consultas SQL que se ejecutan antes de ejecutar la solución o predicción.  
   - `clean_up_sql`: Consultas SQL que se ejecutan después de los casos de prueba para revertir cualquier cambio hecho en la base de datos.  
   - `test_cases`: Un conjunto de casos de prueba para validar el SQL corregido predicho.
   - `follow_up`: Las preguntas de seguimiento etiquetadas.
   - `external_knowledge`: El conocimiento externo relacionado con la tarea específica.

- **evaluation:** El código de evaluación está disponible en el directorio [`./evaluation`](./evaluation).
- **Curado por:** Equipo BIRD & Google Cloud
- **Licencia:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Tarjeta de Dataset de HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### Usos del Dataset

Para evitar la fuga de datos por auto-crawling, no incluimos las soluciones GT en SQL ni los casos de prueba junto con los datos.
por favor envía un correo a [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) con el tag `[bird-interact-lite GT&Test Cases]` en el título para obtener el set completo, que será enviado automáticamente.


<!-- ### Usar el Dataset desde HuggingFace

Puedes descargar el dataset de HuggingFace usando el siguiente comando:
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

- [x] Publicar versión ligera, bird-interact-lite (270).
- [x] Publicar versión conversacional, bird-interact-conv.
- [x] Publicar versión agente, bird-interact-agent.
- [x] Publicar versión completa bird-interact-full (600).
- [ ] SFT / RL en Simulador de Usuario

## Creado por:
Equipo BIRD & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---