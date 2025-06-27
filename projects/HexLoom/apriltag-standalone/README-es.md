# Biblioteca de Detección Independiente de AprilTag

Este es un paquete de herramientas de reconocimiento de AprilTag basado en la biblioteca pupil-apriltags, utilizado para la detección y el seguimiento de AprilTags en cámaras.

<!-- Mantenga estos enlaces. Las traducciones se actualizarán automáticamente con el README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Bibliotecas necesarias

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Instalación

1. Asegúrese de tener instalado el entorno de Python
2. Instale las dependencias necesarias:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Modo de uso

### Uso básico

```python
import cv2
from apriltag import Detector, DetectorOptions

# Crear el detector
options = DetectorOptions(
    families="tag36h11",  # Familia de etiquetas
    border=1,             # Tamaño del borde de la etiqueta
    nthreads=4,           # Número de hilos
    quad_decimate=1.0,    # Factor de submuestreo de imagen
    quad_blur=0.0,        # Coeficiente de desenfoque gaussiano
    refine_edges=True     # Refinar bordes o no
)
detector = Detector(options)

# Leer imagen
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Detectar AprilTag
detections = detector.detect(gray)

# Mostrar resultados de la detección
for detection in detections:
    print(f"Familia de etiqueta: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Posición: {detection.center}")
    print(f"Esquinas: {detection.corners}")
```

### Dibujar los resultados de la detección

```python
import numpy as np
from apriltag import draw_detection_results

# Matriz intrínseca de la cámara y coeficientes de distorsión
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Dibujar resultados de la detección
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Mostrar resultado
cv2.imshow("Detección AprilTag", result_img)
cv2.waitKey(0)
```

### Ejecutar el script de prueba

Se proporciona un script de prueba simple para verificar la función de detección de AprilTag:

```bash
python test_apriltag.py
```

Esto abrirá la cámara predeterminada del ordenador y detectará AprilTag en tiempo real. Presione la tecla "q" para salir.

## Familias de etiquetas soportadas

La biblioteca pupil-apriltags soporta las siguientes familias de etiquetas:
- tag36h11 (por defecto)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Notas

- Para obtener un mejor rendimiento, puede ajustar los parámetros en DetectorOptions
- Para dispositivos con recursos de cálculo limitados, puede considerar aumentar el parámetro quad_decimate para reducir la complejidad computacional
- Asegúrese de que el tamaño del marcador AprilTag utilizado coincida con el parámetro tag_size en el código
- Dibujar el eje de coordenadas 3D requiere parámetros de cámara precisos

## Características

- Soporta detección de AprilTag en tiempo real con cámara USB
- Calcula y muestra la pose 3D de la etiqueta (posición y orientación)
- Soporta guardar imágenes originales y anotadas
- Configuración y parámetros de cámara totalmente personalizables
- Incluye herramienta completa de calibración de cámara
- No depende de ROS, es una versión independiente en Python puro del paquete original de ROS

## Pasos de instalación

### 1. Instalar la biblioteca C de AprilTag

La biblioteca C de AprilTag es necesaria. Por favor, instale siguiendo los pasos a continuación:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Los usuarios de Windows deben compilar manualmente o descargar el archivo binario precompilado, y asegurarse de que `apriltag.dll` esté en el PATH del sistema o en el directorio actual.

### 2. Instalar las dependencias de Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Guía de uso

### Inicio rápido (recomendado)

La forma más sencilla es ejecutar la herramienta integrada, que proporciona un menú interactivo para guiarle a través de todos los pasos:

```bash
python apriltag_tool.py
```

Esta herramienta proporcionará opciones de menú:
1. Generar tablero de calibración de ajedrez
2. Calibración de cámara
3. Detección de AprilTag
4. Ver documentación de ayuda

Simplemente siga las instrucciones del menú para completar todo el proceso.

### Calibración de cámara

Antes de utilizar la detección de AprilTag, se recomienda calibrar la cámara para obtener parámetros precisos:

```bash
# Primero, genere el tablero de calibración de ajedrez
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Imprima el tablero y mida el tamaño real de los cuadros, luego realice la calibración
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Descripción de parámetros:

**Herramienta de generación de tablero de ajedrez (create_chessboard.py):**
- `--size`: Número de puntos interiores del tablero, ancho x alto (por defecto: 9x6)
- `--square`: Tamaño del cuadro, en píxeles (por defecto: 100)
- `--output`: Ruta del archivo de salida (por defecto: chessboard.png)
- `--dpi`: DPI de la imagen de salida (por defecto: 300), afecta el tamaño de impresión

**Programa de calibración de cámara (camera_calibration.py):**
- `--size`: Número de puntos interiores del tablero, ancho x alto (por defecto: 9x6)
- `--square`: Tamaño del cuadro del tablero, en metros (por defecto: 0.025)
- `--output`: Ruta del archivo de salida (por defecto: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: ID del dispositivo de cámara (por defecto: 0)
- `--width`: Ancho de captura de la cámara (por defecto: 1280)
- `--height`: Altura de captura de la cámara (por defecto: 720)
- `--samples`: Número de muestras requeridas para la calibración (por defecto: 20)
- `--preview`: Previsualización del efecto de calibración al finalizar

Proceso de calibración:
1. Genere e imprima el tablero de calibración de ajedrez
2. Mida el tamaño real de los cuadros (en metros)
3. Ejecute el programa de calibración y coloque el tablero frente a la cámara, recopilando muestras desde diferentes ángulos
4. El programa detectará automáticamente el tablero y recopilará las muestras, también puede presionar la tecla 's' para guardar manualmente el cuadro actual
5. Una vez recolectadas suficientes muestras, el programa calculará automáticamente los parámetros de la cámara y los guardará en el archivo especificado

### Detección de AprilTag

Después de completar la calibración, puede ejecutar el programa de detección de AprilTag:
```bash
python apriltag_detector.py
```

### Uso avanzado

```bash
python apriltag_detector.py [ruta del archivo de configuración] --camera ID_de_cámara --width ancho --height alto --camera_info archivo_de_parámetros_de_cámara
```

Descripción de los parámetros:
- `ruta del archivo de configuración`: Ruta al archivo de configuración de AprilTag (por defecto: `config/vision/tags_36h11_all.json`)
- `--camera`: ID del dispositivo de cámara (por defecto: 0)
- `--camera_info`: Ruta al archivo de parámetros internos de la cámara (por defecto: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Ancho de captura de la cámara (por defecto: 1280)
- `--height`: Alto de captura de la cámara (por defecto: 720)

### Controles por teclado

- `q`: Salir del programa

## Descripción del archivo de configuración

Todas las configuraciones del sistema pueden establecerse en el archivo `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Familia de etiquetas
        "size": 0.05,              // Tamaño físico de la etiqueta (unidad: metros)
        "threads": 2,              // Número de hilos de procesamiento
        "max_hamming": 0,          // Distancia de Hamming máxima
        "z_up": true,              // Eje Z hacia arriba
        "decimate": 1.0,           // Factor de submuestreo de imagen
        "blur": 0.8,               // Factor de desenfoque
        "refine_edges": 1,         // Si refinar los bordes
        "debug": 0                 // Activar modo depuración
    },

    "Camera": {
        "device_id": 0,            // ID del dispositivo de cámara
        "width": 1280,             // Resolución de ancho de la cámara
        "height": 720,             // Resolución de alto de la cámara
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Archivo de parámetros de calibración de cámara
    },

    "Archive": {
        "enable": true,            // Habilitar almacenamiento de datos
        "preview": true,           // Mostrar ventana de previsualización
        "save_raw": false,         // Guardar imagen original
        "save_pred": false,        // Guardar imagen predicha
        "path": "./data/table_tracking"  // Ruta de guardado de datos
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista de IDs de etiquetas de referencia
        "moving_tags": [4, 5, 6],            // Lista de IDs de etiquetas móviles
        "require_initialization": true,       // Si requiere inicialización
        "tag_positions": {                    // Posiciones predefinidas de las etiquetas (si existen)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Modificando el archivo de configuración, se puede:
1. Configurar los parámetros del detector AprilTag
2. Establecer parámetros de la cámara (ID de dispositivo, resolución, archivo de parámetros)
3. Configurar opciones de almacenamiento de datos
4. Personalizar los IDs de etiquetas de referencia y móviles
5. Controlar si se requiere inicialización (establecer `require_initialization` en `false` para omitir el paso de inicialización)
6. Predefinir la información de posición de las etiquetas

### Modo de uso

Muy simple, solo se necesita un comando para iniciar el sistema:

```
python table_tracking.py
```

Si desea usar un archivo de configuración personalizado:

```
python table_tracking.py --config ruta_del_archivo_de_configuración_personalizado
```

Después de iniciar el sistema, puede presionar la tecla 'i' en cualquier momento para activar manualmente el proceso de inicialización.

## Preguntas frecuentes

1. **No se encuentra la biblioteca apriltag**
   
   Asegúrese de haber instalado correctamente la biblioteca apriltag y que el archivo de la biblioteca sea accesible en el sistema.

2. **No se puede abrir la cámara**
   
   Verifique que el ID del dispositivo de cámara sea correcto y que la cámara no esté siendo utilizada por otro programa.

3. **Resultados de detección imprecisos**
   
   Asegúrese de que su cámara esté correctamente calibrada y que el tamaño de la etiqueta en el archivo de configuración sea el correcto.


## Estructura de archivos

```
apriltag_standalone/
├── apriltag.py              # Código principal de la librería de detección AprilTag
├── apriltag_detector.py     # Programa principal de detección de AprilTag
├── apriltag_tool.py         # Menú de herramientas integradas
├── camera_calibration.py    # Programa de calibración de cámara
├── create_chessboard.py     # Herramienta de generación de tablero de ajedrez
├── configs.py               # Manejo de archivos de configuración
├── config/                  # Directorio de configuración
│   ├── camera/              # Configuración de cámara
│   │   └── HSK_200W53_1080P.yaml  # Parámetros de la cámara
│   └── vision/              # Configuración de visión
│       └── tags_36h11_all.json # Configuración de AprilTag
├── README.md                # Documentación
└── requirements.txt         # Dependencias de Python
```

## Descripción técnica

Este proyecto es una versión independiente migrada desde el paquete de detección AprilTag de ROS, eliminando la dependencia de ROS y conservando las funciones principales.
Se utilizan principalmente las siguientes tecnologías:

- OpenCV: Procesamiento de imágenes, calibración de cámara y estimación de pose
- Biblioteca AprilTag en C: Detección de etiquetas
- SciPy: Conversión de matrices de rotación y cuaterniones

## Licencia

Este proyecto se basa en la licencia MIT

## Descripción de nuevas funciones

### Seguimiento multi-etiqueta y gestión de oclusiones

El sistema ahora soporta las siguientes funciones nuevas:

1. **Inicialización por captura de imagen**: Tras iniciar el sistema, se realiza automáticamente una inicialización mediante captura, registrando la relación de posiciones de las etiquetas, incluyendo:
   - Posición de etiquetas de referencia fijas (ID 0-3)
   - Relación de posición relativa entre varias etiquetas móviles (por defecto ID 4,5,6)

2. **Gestión de oclusiones**: Después de la inicialización, incluso si algunas etiquetas están ocultas:
   - Si una etiqueta de referencia está oculta, el sistema puede estimar su posición usando otras etiquetas de referencia visibles
   - Si una etiqueta móvil está oculta, el sistema puede estimar su posición usando otras etiquetas móviles visibles

3. **Seguimiento multi-etiqueta**: Permite seguir varias etiquetas móviles simultáneamente, por defecto soporta ID 4,5,6
   - Si la posición relativa entre las etiquetas móviles es fija, basta con que una esté visible para estimar la posición de las demás
   - Se pueden personalizar los IDs de las etiquetas móviles en el archivo de configuración

### Descripción del archivo de configuración

Todas las configuraciones del sistema pueden establecerse en el archivo `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista de IDs de etiquetas de referencia
        "moving_tags": [4, 5, 6],            // Lista de IDs de etiquetas móviles
        "require_initialization": true,       // Si requiere inicialización
        "tag_positions": {                    // Posiciones predefinidas de las etiquetas (si existen)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Modificando el archivo de configuración, se puede:
1. Personalizar los IDs de las etiquetas de referencia y móviles
2. Controlar si se requiere inicialización (establecer `require_initialization` en `false` para omitir el paso de inicialización)
3. Predefinir la información de posición de las etiquetas

### Modo de uso

1. Iniciar el sistema con la configuración por defecto:
   ```
   python table_tracking.py
   ```

2. Iniciar el sistema con un archivo de configuración personalizado:
   ```
   python table_tracking.py --config ruta_del_archivo_de_configuración_personalizado
   ```

3. Inicialización manual: durante la ejecución del sistema, presione la tecla 'i'

### Requisitos de ejecución

Asegúrese de que todas las etiquetas sean visibles durante la inicialización; el sistema registrará la relación relativa entre las posiciones de las etiquetas. Después de la inicialización, incluso si algunas etiquetas están ocultas, el sistema podrá estimar correctamente la posición de todas las etiquetas.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---