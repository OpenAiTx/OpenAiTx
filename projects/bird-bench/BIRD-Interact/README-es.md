
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

## ⚠️ Aviso  
Tenga en cuenta que antes del proceso de evaluación, cuando Docker carga las bases de datos, pueden ocurrir errores ocasionalmente debido a la inconsistencia del entorno (estos no terminarán el proceso pero aparecerán en los registros de Docker). Como resultado, algunas bases de datos pueden no cargarse correctamente, dando lugar a bases de datos vacías. Esto provocará que los resultados de la evaluación sean anormalmente bajos.  
👉 Por lo tanto, recomendamos encarecidamente revisar los registros de Docker en busca de errores **antes de ejecutar la evaluación** y verificar que todas las bases de datos se hayan cargado correctamente.

👉 Hemos actualizado las **Directrices de envío**, donde se admiten los agentes personalizados. Le invitamos a consultar nuestras directrices detalladas de envío [aquí](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true).

## 📰 Noticias

- [2026-02-08] 🔥🔥🔥 ¡Nuestro **[artículo Bird-Interact](https://huggingface.co/papers/2510.05318)** ha sido aceptado en **ICLR 2026 (Oral)**! ¡Nos vemos en Río 🇧🇷!  

- [2025-11-06] 🐛 **Corrección de error** & 🐳 **Actualización de Docker**: Actualización de la versión de sqlglot a 26.16.4 para solucionar el error de que el analizador SQL no puede analizar correctamente el SQL para el simulador de usuario. Puede solucionar esto reinstalando `pip install sqlglot==26.16.4` en el entorno `bird_interact_eval`. La imagen `bird_interact_eval` también está actualizada, así que puede descargarla y recrear el contenedor `bird_interact_eval`.

- [2025-10-21] 🐳 **Actualización de Docker**: Hemos añadido el docker para Full DB Env. Y hemos subido 3 imágenes de docker (Base/Full DB Env y el entorno de evaluación para ambos `a-Interact` y `c-Interact`) a Docker Hub para facilitar la configuración del entorno. ¡Ya no es necesario descargar los volcados de BD ni construir las imágenes manualmente!

- [2025-10-08] 📝 ¡Nuestro **[artículo Bird-Interact](https://huggingface.co/papers/2510.05318)** ya está disponible públicamente!  
  Presenta los detalles completos, la metodología y la evaluación de nuestro benchmark interactivo text-to-SQL.  
  👉 Descúbrelo y conoce más sobre las ideas detrás de [BIRD-Interact](https://bird-interact.github.io/).

- [2025-08-26] 🚀 ¡Nos complace anunciar el lanzamiento del conjunto **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
Es exigente — los mejores LLMs sólo logran una tasa de éxito de **16.33%**, con apenas **10.0%** en las porciones de `c-interact` y `a-interact`.  
👉 Para más detalles, por favor visite nuestro [sitio web del proyecto](https://bird-interact.github.io/).

- [2025-08-26] 📬 Esta semana enviaremos los **Ground Truth & Test cases** a nuestra lista de correo.  
Si desea acceso anticipado, envíe un correo electrónico según las instrucciones en el sitio para una **descarga automática**.  

- [2025-08-26] 💾 Por otro lado, también hemos lanzado una versión SQLite de **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** para facilitar la investigación local.  
¡Las versiones completas **LiveSQLBench-Base** y **-Large** llegarán pronto!

- [2025-08-22] **Corrección de error**: En el código Bird-Interact-Agent, corregimos un error donde al evaluar SQL de la fase-2, el SQL almacenado de la fase-1 no podía ejecutarse exitosamente, lo que resultaba en una menor tasa de éxito de la Fase-2. Este error solo afecta a aquellas tareas en las que el sql de la fase1 realiza operaciones en la base de datos, por ejemplo, CREATE table, etc.

## 🧸 Descripción general

BIRD-INTERACT, un benchmark interactivo de text-to-SQL, **reimagina la evaluación Text-to-SQL a través de la lente de interacciones dinámicas**.
El entorno combina una base de conocimiento jerárquica, documentación de base de datos y un simulador de usuario basado en funciones para recrear entornos empresariales auténticos con operaciones completas de **CRUD**.
Ofrece dos modos de prueba rigurosos: (1) **Interacción Conversacional** pasiva y (2) **Interacción Agéntica** activa, abarcando 600 tareas anotadas incluyendo Business Intelligence (BI), operaciones CRUD, etc., cada una protegida por casos de prueba ejecutables.
Las evaluaciones típicas desencadenan entre 1,968 y 5,496 turnos de interacción entre el modelo y el simulador de usuario, mientras que los modelos de razonamiento de última generación actualmente resuelven solo **≈24%** y **≈18%** de las tareas, lo que subraya el desafío del benchmark.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ Dos modos de evaluación

BIRD-INTERACT admite dos modos de evaluación como se mencionó arriba:

   - **c-Interact**: Interacción Conversacional, que es un modo pasivo y el flujo de trabajo es fijo. El código y la información detallada se pueden encontrar en `bird_interact_conv`.
   - **a-Interact**: Interacción Agéntica, que es un modo activo incorporado donde el flujo de trabajo es dinámico y dirigido por modelos. El código y la información detallada se pueden encontrar en `bird_interact_agent`.


### 🐣 Versión Lite

Estamos lanzando una versión lite de BIRD-INTERACT, `bird-interact-lite-exp`, que incluye 270 tareas reales de alta calidad específicamente para PostgreSQL. Es un buen punto de partida para experimentación rápida.

### 🦜 Versión Completa

La versión completa de BIRD-INTERACT, `bird-interact-full`, es un benchmark integral que incluye 600 tareas para PostgreSQL. Cubre una amplia gama de operaciones SQL y consultas de usuario. La versión completa estará disponible pronto.

### Resultados de rendimiento de modelos en BIRD-INTERACT-FULL

#### 1. **c-Interact Text-to-SQL** Rendimiento
| Rank | Nombre del modelo  | Recompensa normalizada | Costo promedio (USD)/Tarea | Nivel              |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------:|
| 1    | Gemini-2.5-Pro     | 20.92             | $0.04               | 🏆 Chat Excelente  |
| 2    | O3-Mini            | 20.27             | $0.07               | 🏆 Chat Excelente  |
| 3    | Claude-Sonnet-4    | 18.35             | $0.29               | 💎 Buen Chat       |
| 4    | Qwen-3-Coder-480B  | 17.75             | $0.11               | 💎 Buen Chat       |
| 5    | Deepseek-Chat-V3.1 | 15.15             | $0.12               | ✨ Estándar        |
| 6    | Claude-Sonnet-3.7  | 13.87             | $0.29               | ✨ Estándar        |
| 7    | GPT-5              | 12.58             | $0.08               | ⚪ Básico          |

#### 2. **a-Interact Text-to-SQL** Rendimiento
| Rank | Nombre del Modelo  | Recompensa Normalizada | Costo Promedio (USD)/Tarea | Nivel                    |
|:----:|:-------------------|:-----------------:|:-------------------:|:------------------------:|
| 1    | GPT-5              | 25.52             | $0.24               | 🏆 Interacción Excelente |
| 2    | Claude-Sonnet-4    | 23.28             | $0.51               | 🏆 Interacción Excelente |
| 3    | Claude-Sonnet-3.7  | 17.45             | $0.60               | 💎 Buena Interacción     |
| 4    | Gemini-2.5-Pro     | 17.33             | $0.22               | 💎 Buena Interacción     |
| 5    | O3-Mini            | 16.43             | $0.06               | ✨ Estándar              |
| 6    | Deepseek-Chat-V3.1 | 13.47             | $0.06               | ✨ Estándar              |
| 7    | Qwen-3-Coder-480B  | 10.58             | $0.07               | ⚪ Básico                |

> \* Parámetros de Presupuesto: Presupuesto Inicial/Presupuesto de Paciencia del Usuario, medido por nuestra moneda virtual *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. Consulte [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) para más detalles.

### Escalado de Tiempo de Interacción (ITS)

El Escalado de Tiempo de Interacción (ITS) se refiere a la capacidad de un modelo para aumentar continuamente su rendimiento final a través de interacciones en múltiples turnos. Cuando este rendimiento interactivo supera el rendimiento idealizado de turno único del modelo en una tarea completamente especificada y no ambigua, decimos que cumple la **ley ITS**. A medida que crece la paciencia del usuario y se acumulan los turnos de interacción, el rendimiento sigue mejorando, demostrando que el modelo puede mantener una comunicación efectiva durante un diálogo extendido. Actualmente, solo encontramos que claude-3-7-sonnet cumple la ley ITS.

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## Configuración del Entorno

1. Ejecute los contenedores Docker para la base de datos bird-interact-lite, la base de datos bird-interact-full y el entorno de evaluación:
  
  > Si solo desea evaluar en `bird-interact-lite`, puede comentar el servicio [`postgresql_full`](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) en `docker-compose.yml` para acelerar la configuración del entorno.
  
  Inicie el entorno ejecutando:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   Espere varios minutos para la inicialización de la base de datos.
   
  Puede seguir el progreso de la construcción mediante:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  Si ha finalizado, debería ver los registros sin errores como:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  Si ha creado contenedores antes y desea recrearlos, puede ejecutar el siguiente comando:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   Esto ejecuta 3 contenedores usando imágenes preconstruidas de Docker Hub:
   - `bird_interact_postgresql`: Base de datos PostgreSQL para bird-interact-lite
   - `bird_interact_postgresql_full`: Base de datos PostgreSQL para bird-interact-full
   - `bird_interact_eval`: Entorno de evaluación para ambos `a-Interact` y `c-Interact`.

   Ahora, puedes iniciar el entorno de evaluación ejecutando el siguiente comando:
   ```bash
   docker compose exec bird_interact_eval bash
   ```
2. (Opcional) Construya el entorno manualmente (si desea crear las imágenes desde cero): 
   - Descargue los volcados de la base de datos 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view). Descomprima y renómbrelo como `env/postgre_table_dumps`.
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view). Descomprima y renómbrelo como `env/postgre_table_dumps_full`.
   - Construya el entorno manualmente ejecutando `docker-compose.build.yml`.

      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

3. (Recomendado) Verifique que los contenedores de la base de datos estén construidos y funcionando correctamente.

- Imprima los registros de construcción de los contenedores para asegurarse de que las bases de datos se hayan construido correctamente sin errores:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   Si se producen errores, se imprimirá `"Se produjeron errores durante la importación:"` en los archivos de registro.


-  Verifique si los contenedores de la base de datos están en buen estado.
   
   Use nuestro script de Python proporcionado para verificar los metadatos de la base de datos:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   Resultados esperados:
   - **bird-interact-lite**: 
     - 📈 Bases de datos totales: 18
     - 📋 Tablas totales: 175
     - 🔢 Columnas totales: 2286
     - 📈 Promedio de filas por tabla: 1,038.48
     - 💾 Tamaño total: 207.15 MB (aproximadamente)
   - **bird-interact-full**: 
     - 📈 Bases de datos totales: 22
     - 📋 Tablas totales: 244
     - 🔢 Columnas totales: 2011
     - 📈 Promedio de filas por tabla: 1,121.19
     - 💾 Tamaño total: 272.00 MB (aproximadamente)


## 📦 Detalles del conjunto de datos

### Descripción del conjunto de datos

- **Base de datos:** La base de datos completa de PostgreSQL se puede descargar desde [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) y [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view).
- **data:** Cada instancia de datos contiene las siguientes partes principales:
   - `selected_database`: El nombre de la base de datos.  
   - `query`: La consulta de usuario no ambigua.  
   - `amb_user_query`: La consulta de usuario con ambigüedades inyectadas.
   - `user_query_ambiguity`: Las ambigüedades inyectadas en la consulta de usuario.
   - `non_critical_ambiguity`: Ambigüedades no críticas como orden, límite, etc.
   - `knowledge_ambiguity`: Ambigüedades generadas por conocimientos externos enmascarados. 
   - `sol_sql`: La solución SQL de referencia.  
   - `preprocess_sql`: Consultas SQL para ejecutar antes de la solución o predicción.  
   - `clean_up_sql`: Consultas SQL para ejecutar después de los casos de prueba para revertir los cambios realizados en la base de datos.  
   - `test_cases`: Un conjunto de casos de prueba para validar el SQL corregido predicho.
   - `follow_up`: Las preguntas de seguimiento etiquetadas.
   - `external_knowledge`: El conocimiento externo relacionado con la tarea específica.

- **evaluación:** El código de evaluación está disponible en el directorio [`./evaluation`](./evaluation).
- **Curado por:** Equipo BIRD & Google Cloud
- **Licencia:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **Tarjeta de conjunto de datos en HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  y [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full)
### Usos del Conjunto de Datos

Para evitar la fuga de datos por auto-raspado, no incluimos las soluciones GT sql y los casos de prueba junto con los datos.
por favor envíe un correo electrónico a [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) con la etiqueta `[bird-interact-lite GT&Test Cases]` o `[bird-interact-full GT&Test Cases]` en el título para la verdad base y los casos de prueba del conjunto de datos bird-interact-lite o bird-interact-full, que serán enviados automáticamente.


### Combine los datos públicos con la verdad base y los casos de prueba

Luego use el siguiente script para combinar los datos públicos con la verdad base y los casos de prueba:

Tomando la versión completa como ejemplo:
(1) Ejecute:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
Esto creará un nuevo archivo en `/path/to/bird_interact_data.jsonl` con los datos combinados.

(2) Luego, reemplace los datos públicos originales con los datos combinados:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

Lo mismo para las otras versiones: bird-interact-lite, versión mini, etc. Solo configura las rutas correctas para los datos públicos, la verdad de terreno y los casos de prueba, y luego reemplaza los datos públicos con los datos combinados.




<!-- ### Usar el conjunto de datos de HuggingFace

Puedes descargar el conjunto de datos de HuggingFace usando el siguiente comando:
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
Los detalles sobre cómo ejecutar **a-interact** se pueden encontrar en `./bird_interact_agent/README.md`; y sobre **c-interact** en `./bird_interact_conv/README.md`.

## 📋 Listas de tareas

- [x] Lanzar versión ligera, bird-interact-lite (270).
- [x] Lanzar versión conversacional, bird-interact-conv.
- [x] Lanzar versión agente, bird-interact-agent.
- [x] Lanzar bird-interact-full completa (600).
- [ ] SFT / RL de un Simulador de Usuario

## Reconocimientos
Queremos expresar nuestra sincera gratitud a **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, y al profesor **Shinji Watanabe** por sus fructíferas discusiones y valiosos aportes que ayudaron a mejorar este proyecto.

## Creado por:
Equipo BIRD & Google Cloud








## Registro de cambios

- [2025-11-06] 🐛 **Corrección de errores** & 🐳 **Actualización de Docker**: Se actualizó la versión de sqlglot a 26.16.4 para corregir el error en el que el analizador SQL no podía analizar correctamente el SQL para el simulador de usuario. Puede solucionar esto reinstalando con `pip install sqlglot==26.16.4` en el entorno `bird_interact_eval`. La imagen `bird_interact_eval` también está actualizada, por lo que puede descargarla y recrear el contenedor `bird_interact_eval`.
- [2025-10-21] 🐳 **Actualización de Docker**: Se añadió el docker para el entorno Full DB. Además, subimos 3 imágenes docker (Base/Full DB Env y el entorno de evaluación para ambos `a-Interact` y `c-Interact`) a Docker Hub para facilitar la configuración del entorno. ¡Ya no es necesario descargar los volcados de DB ni construir las imágenes manualmente! Por favor, descargue las imágenes más recientes de Docker Hub y recree los contenedores, por ejemplo usando `docker compose down -v && docker compose pull && docker compose up -d --force-recreate`.
- [2025-08-22]  🐛 **Corrección de errores**: Se corrigió el error que al evaluar SQL de fase-2, el SQL almacenado de fase-1 no podía ejecutarse correctamente, lo que llevaba a una tasa de éxito menor en la Fase-2. Este error solo afecta aquellas tareas donde el SQL de la fase1 realiza algunas operaciones en la base de datos, por ejemplo, CREATE table, etc.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---