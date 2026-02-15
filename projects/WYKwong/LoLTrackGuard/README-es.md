## 🛡️ LoLTrackGuard: Detección de Comportamiento Automatizado en LoL

**LoLTrackGuard** es un sistema ligero para detectar comportamientos sospechosos del ratón en vídeos de juego de *League of Legends*. Combina la detección del cursor basada en YOLOv8 con un autoencoder LSTM para identificar anomalías en los patrones de movimiento del cursor — sin necesidad de registros del juego ni herramientas invasivas.

- 🎯 Entrada: vídeo de juego 1080p 30FPS
- 🖱️ Paso 1: Detectar posiciones del cursor usando un modelo YOLO entrenado
- 📐 Paso 2: Extraer y normalizar características de movimiento (velocidad, aceleración, etc.)
- 🧠 Paso 3: Introducir en autoencoder LSTM para puntuar anomalías
- 📊 Salida: CSV con puntuaciones de anomalías por segundo

Entrenado con datos reales de jugadores profesionales, LoLTrackGuard ofrece una forma no intrusiva de detectar posibles comportamientos automatizados en grabaciones de juego.

---

## 📁 Estructura del Proyecto

```bash
LoLTrackGuard-MAIN/
├── cursor_templates/                # Cursor icon PNGs with transparency (for FakeDataGenerator)
├── extension/                       # C++/CUDA Acceleration Module
│   ├── setup.py                     # Build script
│   └── src/                         # C++ and CUDA source files
├── model/                           # Trained LSTM models for anomaly detection
│   ├── detection_model.keras        # Default trained LSTM model
│   ├── detection_model2.keras       # Alternate model versions
│   └── detection_model3.keras
├── mouse_positions/                # Output CSVs from cursorDetector with raw mouse position data
├── pipeline/                       # Core logic scripts
│   ├── analyzer.py                 # Runs analysis using a trained model
│   ├── cursorDetector.py          # Detects cursor in videos using YOLO and outputs CSV
│   ├── cursorDetector_accelerated.py # High-Performance version (C++/Numba)
│   ├── dataModifier.py            # Extracts motion features and normalizes them
│   └── modelTrainer.py            # Trains LSTM anomaly detection model
├── utils/                          # Resource files and utility scripts
│   ├── cursorDetector_x.pt        # Primary YOLOv8 model for cursor detection
│   ├── FakeDataGenerator.py       # Script to generate synthetic training data for YOLO
│   └── universal_scaler.joblib    # Saved standardizer for feature normalization
├── train_pipeline.py               # Full training pipeline: from video to trained model
├── analyze_pipeline.py             # Full analysis pipeline: from video to anomaly scores
├── requirements.txt                # Python dependencies
└── README.md                       # Project documentation
```

---

## ⚙️ Project Setup

### 1. Install Git LFS (for large model files)

```bash
# Install Git LFS from: https://git-lfs.github.com/
git lfs install
```

### 2. Instalar dependencias

```bash
pip install -r requirements.txt
```

---

## 🔍 Cómo Usar: Pipeline de Análisis (`analyze_pipeline.py`)

### 🎯 Propósito

Detectar anomalías en el movimiento del ratón a partir de grabaciones de juego usando un modelo preentrenado.

> ⚠️ **Importante:** Tu video de entrada **debe estar en 1080p 30 FPS** para asegurar una detección adecuada del cursor y la alineación de características.

### 🚀 Ejecutar

```bash
python analyze_pipeline.py
```

### 📊 Flujo

```
1. Select a video file (e.g. MP4 screen recording with visible cursor)
2. Run YOLOv8 to detect and record mouse positions (X, Y, time)
3. Automatically extract movement features (velocity, acceleration, etc.)
4. Apply the pre-trained scaler to normalize features
5. Feed sequences into LSTM autoencoder
6. Calculate reconstruction error for each 1-second action
7. Save anomaly scores to CSV
```

### 📂 Salida

- `analysis_results/`: Contiene archivos CSV que enumeran el error de reconstrucción por acción  
- Cada fila corresponde a una secuencia de 1 segundo (30 cuadros), indicando el nivel de anomalía


## 🧠 Entrena Tu Propio Modelo

Si deseas entrenar tu propio modelo autoencoder LSTM:

1. Usa `pipeline/dataModifier.py` para extraer características de tus archivos CSV de posición del ratón en bruto.
2. Usa `utils/universal_scaler.joblib` para normalizar los vectores de características.
3. Usa `pipleline/modelTrainer.py` para entrenar un nuevo modelo con las secuencias procesadas.

> 💡 **Consejo**: Asegúrate de que tus videos de entrada estén consistentemente en **1080p 30 FPS**.

---

## 🧪 Cómo Funciona Esto

### 1. Detección del Cursor vía YOLOv8 y Datos Sintéticos

**¿Por qué el Cursor?**  
El objetivo de este proyecto es analizar grabaciones de juego en primera persona de streamers o creadores de contenido. En comparación con el comportamiento del personaje, las trayectorias del cursor del ratón proporcionan una señal más directa y fiable para detectar posibles scripts.

Se recopilaron archivos de **puntero del ratón** y **replicas de juegos** como fondos

Se utilizó `FakeDataGenerator.py` para generar más de **70,000 imágenes sintéticas etiquetadas**:
- Cada cuadro se superpone con una plantilla de cursor seleccionada aleatoriamente
- El tamaño, brillo, saturación y desenfoque global del cursor se aleatorizan

Estas imágenes ruidosas pero etiquetadas se usaron para entrenar un **modelo de detección de objetos basado en YOLOv8** capaz de detectar posiciones del ratón en videos de juego reales.

### 🖼️ Figura 1: Ejemplo de Detección de Cursor
![cursor detection example](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/1.png)
---

### 2. Modelado del Comportamiento mediante Autoencoder LSTM

Para evitar juicios subjetivos al identificar tramposos, se utiliza un **autoencoder LSTM** entrenado únicamente con **datos verificados de humanos** (partidas sin trampas).

El modelo aprende a reconstruir **patrones normales de movimiento del ratón humano**. Durante la inferencia, marca cualquier secuencia con alto **error de reconstrucción** como posibles anomalías, sin requerir definiciones manuales de reglas.

### 🧠 Figura 2: Diagrama del Autoencoder LSTM
![LSTM](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/2.png)

---

### 3. Ingeniería de Características con Datos Reales de Jugadores Profesionales

Se recopilaron **50 repeticiones en primera persona de jugadores profesionales de LoL**, extrayendo más de **1.5 millones de movimientos de ratón**.

Las coordenadas crudas del cursor se procesan usando `dataModifier.py`, que:
- Extrae características diseñadas a partir de datos brutos (X, Y)
- Reemplaza las marcas de tiempo absolutas por deltas temporales
- Calcula velocidad por cuadro, aceleración (X/Y), velocidad angular y distancia de movimiento
- Aplica `universal_scaler.joblib` para normalización

Los movimientos se segmentan en **secuencias de 30 pasos cada una** (1 segundo de movimiento a 30 FPS), representando acciones atómicas del usuario.

Estas más de 500,000 secuencias de acción se usan para entrenar el LSTM.

---

### 4. Evaluación de Resultados mediante Error de Reconstrucción

Tras ejecutar toda la canalización de análisis, el script `analyzer.py` procesa las secuencias de características extraídas usando el autoencoder LSTM entrenado.

Para cada acción (una secuencia de movimiento de ratón de 1 segundo), el modelo calcula un **error de reconstrucción**:

- **Error bajo** → comportamiento similar a patrones humanos aprendidos
- **Error alto** → comportamiento anormal y potencialmente automatizado o asistido

Esto permite una evaluación cuantitativa y objetiva del comportamiento sospechoso en el juego.

Los resultados se guardan en `analysis_results/` como archivos CSV, donde cada fila corresponde a una acción detectada con su puntuación de anomalía asociada.

### 🎮 Figura 3: Movimiento del Ratón de Jugador Profesional (No Visto Durante el Entrenamiento)
![Pro Player Data (Unseen During Training](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/3.png)

### 👤 Figura 4: Movimiento del Ratón del Jugador Regular
![Datos de Jugador Regular](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/4.png)

### ⚠️ Figura 5: Movimiento del Ratón en Juego Sospechoso
![Datos de Juego Sospechoso](https://raw.githubusercontent.com/WYKwong/LoLTrackGuard/main/utils/img/5.png)

---

## 🚀 Modo de Alto Rendimiento (C++/CUDA)

LoLTrackGuard ahora incluye una tubería de procesamiento acelerada.

### Características
- **Aceleración Híbrida**: Usa automáticamente `Numba` (JIT CUDA) y `Threading` si la extensión C++ no está compilada.
- **Decodificación de Video Asíncrona**: Desacopla la lectura de la inferencia.
- **Kernels CUDA Personalizados**: Filtros de preprocesamiento para resaltar candidatos a cursor.

### Configuración (Extensión C++ Opcional)
Para un rendimiento máximo, puedes compilar la extensión nativa en C++:

1. Asegúrate de que `CUDA Toolkit` y `Visual Studio` (MSVC) estén instalados.
2. Configura las rutas de OpenCV en `extension/setup.py`.
3. Ejecuta:
   ```bash
   cd extension
   python setup.py install
   cd ..
   ```

### Uso
Ejecute el detector acelerado:
```bash
python pipeline/cursorDetector_accelerated.py
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-15

---