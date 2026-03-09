# Incrustaciones Temporales de Espectros de Superficie para la Representación y Análisis de la Tierra (TESSERA) [CVPR2026]
<div align="center">
    <a href="#readme-top">
        <img src="https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/banner.png" alt="Banner">
    </a>
    <br />
    <p align="center">
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">Reportar Errores 🛠️</a> &nbsp;&nbsp;•&nbsp;&nbsp;
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">Solicitar Funcionalidades 💡</a>
    </p>
</div>

<!--  ![Version](https://img.shields.io/badge/version-alpha-red) -->
![Versión PyPI](https://img.shields.io/pypi/v/geotessera?label=PyPI%20version&color=blue)
![Licencia](https://img.shields.io/badge/License-MIT-blue.svg)


# Tabla de Contenidos

  - Aprendiendo sobre TESSERA
      - [Introducción](#introducción)
      - [Artículos](#artículos)
      - [Podcast](https://www.satellite-image-deep-learning.com/p/tessera-a-temporal-foundation-model)
      - [Presentaciones](#presentaciones)
      - [Licencia](#licencia)
  - Usando TESSERA
      - [Política de Uso Aceptable](#política-de-uso-aceptable)
      - [Acceso a Incrustaciones Precalculadas](#acceso-a-incrustaciones-precalculadas)
      - [Creando Tus Propias Incrustaciones](#creando-tus-propias-incrustaciones)
      - [Tareas Posteriores](#tareas-posteriores)
      - [Grupo de Usuarios de TESSERA](#grupo-de-usuarios-de-tessera)
  - Información adicional
      - [Equipo](#equipo)
      - [Contacto](#contacto)
      - [Citación](#citación)
      - [Agradecimientos](#agradecimientos)
      - [Historial de Estrellas](#historial-de-estrellas)

# Aprendiendo sobre TESSERA
## Introducción

La teledetección satelital permite una amplia gama de aplicaciones posteriores, incluyendo el mapeo de hábitats, la contabilidad de carbono y estrategias para la conservación y el uso sostenible del suelo. Sin embargo, las series temporales satelitales son voluminosas y a menudo están corruptas por nubes, lo que dificulta su uso: la capacidad de la comunidad científica para extraer conocimientos prácticos está a menudo limitada por la escasez de conjuntos de datos etiquetados para entrenamiento y la carga computacional de procesar datos temporales. La idea clave detrás de nuestro trabajo, atribuida a [Dr. Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/), es que forzar la alineación de incrustaciones de auto-codificador derivadas de dos muestras aleatorias libres de nubes de series temporales satelitales usando [Barlow Twins](https://proceedings.mlr.press/v139/zbontar21a/zbontar21a.pdf) resulta en una incrustación que representa toda la serie temporal, incluyendo las observaciones faltantes.

Esta idea es la clave detrás de TESSERA, un modelo base abierto que preserva señales espectro-temporales por píxel en representaciones latentes de 128 dimensiones a resolución de 10 metros a nivel global. Utiliza aprendizaje auto-supervisado para resumir petabytes de datos de observación terrestre. Comparamos nuestro trabajo con modelos específicos de última generación y otros modelos base en cinco tareas posteriores diversas y encontramos que TESSERA iguala o supera de cerca estas referencias. Al preservar señales fenológicas temporales que típicamente se pierden en enfoques convencionales, TESSERA permite nuevas perspectivas sobre la dinámica de ecosistemas, sistemas agrícolas alimentarios y detección de cambios ambientales. Además, nuestra implementación de código abierto apoya la reproducibilidad y extensibilidad, mientras que el diseño que preserva la privacidad permite a los investigadores mantener la soberanía de los datos.

Hasta donde sabemos, TESSERA es sin precedentes en su facilidad de uso, escala y precisión: ningún otro modelo base proporciona salidas listas para análisis, es abierto y ofrece cobertura global anual a resolución de 10 m usando solo características espectro-temporales a nivel de píxel.

Aquí algunos resultados de visualización del mapa de representación de TESSERA (usando los primeros tres canales como RGB):

![repr_demo](https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/repr_demo.png)

## Artículos
Aquí están las publicaciones y preprints relacionados con TESSERA, listados cronológicamente:
* Lisaius, M. C., Blake, A., Keshav, S., & Atzberger, C. (2024). Uso de Barlow Twins para crear representaciones a partir de series temporales de teledetección corruptas por nubes. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing, 17, 13162–13168. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing. https://doi.org/10.1109/JSTARS.2024.3426044

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav (2025), [TESSERA: Embeddings Temporales de Espectros Superficiales para Representación y Análisis de la Tierra](https://arxiv.org/abs/2506.20380), Próxima publicación, CVPR 2026. Reimpresión en ArXiv. https://arxiv.org/abs/2506.20380

* Lisaius, M. C., Blake, A., Atzberger, C., & Keshav, S. (2026). Hacia una mejor clasificación de tipos de cultivo: un enfoque compacto de incrustaciones adecuado para campos pequeños. Aceptado en Proceedings of the ISPRS Conference 2026. Sociedad Internacional de Fotogrametría y Teledetección.

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav, (2026) [Aplicaciones del modelo base geoespacial TESSERA a diversas tareas de mapeo ambiental](http://ssrn.com/abstract=6142416), preprint SSRN. http://ssrn.com/abstract=6142416
  
* Young, R., & Keshav, S. (2026). Interpolación de estimaciones de biomasa GEDI con cuantificación calibrada de incertidumbre, preprint arXiv. https://doi.org/10.48550/ArXiv.2601.16834
  
* Lisaius, M. C., Keshav, S., Blake, A., & Atzberger, C. (2026). Clasificación de tipos de cultivo basada en incrustaciones en la cuenca del maní de Senegal (arXiv:2601.16900). Preprint ArXiv. https://doi.org/10.48550/arXiv.2601.16900

* Ball, J.G.C, Wicklein J.A., Feng, Z., Knezevic, J., Jaffer, S., Atzberger, C., Dalponte, M., y Coomes, D. Los modelos base geoespaciales permiten un mapeo eficiente de especies arbóreas en bosques montanos templados, BioArxiv, https://doi.org/10.64898/2026.02.23.707022

## Presentaciones

* [Resumen de TESSERA en seminario AI for Good](https://www.youtube.com/live/9yrpwFrwbGY), Frank Feng, 22 de enero de 2026
* [TESSERA: incrustaciones globales por píxel precalculadas FAIR para representación y análisis de la Tierra](https://www.grss-ieee.org/event/tessera-precomputed-fair-global-pixel-embeddings-for-earth-representation-and-analysis/) Charla IEEE GRSS, Frank Feng, 12 de diciembre de 2025
* [Resumen de 2 diapositivas (PPTX)](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) para CRI Flash Talks, S. Keshav, 7 de octubre de 2025
* Resumen del modelo base (PPTX) para reunión de grupos de ecología, Universidad de Cambridge, DAB, James Ball, 6 de octubre de 2025
* [Presentación general de TESSERA con enfoque en aplicaciones ecológicas](https://www.dropbox.com/scl/fi/8xvanw3kk586lp1ld31kd/maryland_talk_slides.pdf?rlkey=osyhtk1kc2pcj81iel0u32lub&st=6kedpwv6&dl=0) (PDF) Universidad de Maryland, Frank Feng, 1 de octubre de 2025
* [Presentación general de TESSERA](https://www.dropbox.com/scl/fi/0rsq4wkao3c7fgwljd8ec/JCU-tesserav2.pptx?rlkey=ccutcxgwi068c09n20t1yi549&st=13if23b3&dl=0) (PPTX) Universidad James Cook, S. Keshav, 29 de septiembre de 2025
* [Presentación general de TESSERA](https://www.dropbox.com/scl/fi/1p7nabvlvie8fzyomkx7w/dab_talk_slides.pdf?rlkey=ym3d44o80mbrdkasyzct9kzi5&st=ozvwczs7&dl=0) Universidad de Cambridge, DAB, Frank Feng, 20 de mayo de 2025
* [Aprendizaje auto-supervisado para observación terrestre](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) (PPTX) S. Keshav, Exeter, abril 2025

## Licencia

El software TESSERA se publica bajo la licencia estándar MIT. Los embeddings y los pesos del modelo se publican bajo la licencia [CC0](https://creativecommons.org/publicdomain/zero/1.0/): esencialmente,  
pueden ser utilizados libremente tanto para fines comerciales como no comerciales. Aunque no requerimos legalmente atribución,  
sí la solicitamos.

# Uso de TESSERA

<a id="global-embeddings-access"></a>

## Acceso a Embeddings usando GeoTessera (recomendado)

Hemos generado embeddings para todo el globo a resolución de 10m para 2024.  
Estos pueden descargarse y usarse para aplicaciones posteriores, ahorrando tiempo y recursos computacionales significativos, usando  
la biblioteca [GeoTessera](https://github.com/ucam-eo/geotessera).  
Progresivamente ampliaremos la cobertura hacia atrás año por año hasta 2017. El mapa de cobertura actual está abajo:

<img src="https://github.com/ucam-eo/tessera-coverage-map/blob/main/map.png"> 

## Grupo de Usuarios de TESSERA

Los usuarios interesados están invitados a unirse a nuestros grupos de discusión en [Zulip](https://eeg.zulipchat.com/login/).


# Creando Tus Propios Embeddings

Si deseas usar nuestro software para crear tus propios embeddings, por favor sigue las instrucciones abajo. Ten en cuenta que esta es una tarea computacionalmente desafiante y necesitarás acceso a recursos computacionales y de almacenamiento significativos.  

## Requisitos de Hardware

### 1. Requisitos de Almacenamiento

Ejecutar esta línea de procesamiento requiere un espacio de almacenamiento sustancial. Aunque el pipeline limpia algunos archivos intermedios tras el procesamiento, los archivos crudos descargados de Sentinel-2 y Sentinel-1 seguirán ocupando un espacio considerable en disco. Por ejemplo, procesar un área de 100km×100km desde 2022 para generar un mapa de Representación TESSERA (resolución 10m) requiere al menos 1TB de almacenamiento.

### 2. Requisitos de Memoria

Usamos datos preprocesados, inicialmente desde Microsoft Planetary Computer. Sin embargo, la siguiente generación de embeddings usará OPERA de ASF DAAC. En cualquiera de los casos, la mayoría del preprocesamiento geográfico ya está realizado. Aun así, recomendamos tener al menos 128GB de RAM.

### 3. CPU y GPU

El pipeline no tiene requisitos estrictos para CPU y GPU, pero más núcleos de CPU y GPUs más potentes pueden acelerar significativamente la inferencia. Al procesar un área de 110km×110km desde 2022, nuestras pruebas usando una CPU de 128 núcleos y una sola GPU NVIDIA A30 para inferencia (CPU y GPU manejando cada uno el 50% de la inferencia) tomaron aproximadamente 10 horas para completarse.

### 4. Sistema Operativo

Para la canalización de preprocesamiento de datos, soportamos casi todos los sistemas Linux. Para Windows, recomendamos usar WSL. Actualmente no soportamos MacOS.

Para la parte de inferencia del modelo, solo lo hemos probado en Linux y Windows WSL, y funcionan correctamente.

## Preprocesamiento de Datos

### Visión General
_**Recomendamos encarecidamente que revise rápidamente todo el tutorial antes de ejecutar la canalización.**_

En este paso, apilamos un año completo de datos Sentinel-1 y Sentinel-2 a lo largo de la dimensión temporal para generar un compuesto. Para Sentinel-2, la forma del compuesto es (T,H,W,B), donde T es el número de observaciones válidas en ese año, y B es el número de bandas (seleccionamos 10 bandas). Para Sentinel-1, extraemos datos de órbita ascendente y descendente. Tomando la órbita ascendente como ejemplo, la forma del compuesto es (T',H,W,B'), donde T' es el número de observaciones ascendentes válidas en ese año, y B' es 2 porque solo obtenemos las bandas VV y VH.

Inicialmente obtuvimos los datos Sentinel-1 y Sentinel-2 del Planetary Computer de Microsoft:
- Fuente de datos Sentinel-1: https://planetarycomputer.microsoft.com/dataset/sentinel-1-rtc
- Fuente de datos Sentinel-2: https://planetarycomputer.microsoft.com/dataset/sentinel-2-l2a

La nueva generación de embeddings usará OPERA del ASF DAAC:
- Fuente de datos Sentinel-1:  https://registry.opendata.aws/nasa-operal2rtc-s1v1/
- Fuente de datos Sentinel-2: https://registry.opendata.aws/sentinel-2-l2a-cogs/

Actualmente, nuestra canalización solo acepta entrada en formato TIFF. La resolución del TIFF ROI de entrada puede variar (por ejemplo, 30m), pero la canalización **siempre generará salidas Sentinel-1 y Sentinel-2 en la `RESOLUCIÓN` configurada** (por defecto 10m) manteniendo la **extensión/límites del ROI idénticos**. Para áreas válidas del ROI dentro del TIFF, el valor es 1; de lo contrario, es 0. Si solo tiene un shapefile, no hay problema - proporcionamos un script `convert_shp_to_tiff.py`.

### Descargar Código Fuente

Primero, cree un directorio de trabajo vacío:

```bash
mkdir tessera_project
cd tessera_project
git clone https://github.com/ucam-eo/tessera.git
```

Para facilitar la operación del pipeline, recomendamos colocar el directorio de salida de datos al mismo nivel que `tessera_infer` y `tessera_preprocessing`:

```
tessera_project
 ┣ tessera_infer
 ┣ tessera_preprocessing
 ┣ my_data
   ┣ roi.shp (your shapefile)
   ┗ roi.tiff (we recommend generating this using convert_shp_to_tiff.py)
```

El archivo `roi.tiff` se puede generar usando `convert_shp_to_tiff.py` ubicado en `tessera_preprocessing/convert_shp_to_tiff.py`. Para usarlo, simplemente especifique la ruta a su archivo shapefile en la función principal, y generará un TIFF con el mismo nombre en el mismo directorio.

⚠️Aviso: _Si su ROI es relativamente grande, por ejemplo 100 km × 100 km, recomendamos encarecidamente predividir el TIFF en secciones más pequeñas no mayores a 20 km × 20 km. Luego procese cada archivo TIFF pequeño secuencialmente en la tubería. Un ROI excesivamente grande puede causar problemas con los proveedores de mosaicos backend_

### Entorno de Python

Necesitamos algunos paquetes de procesamiento geográfico (afortunadamente, no usaremos GDAL, ya que configurar el entorno es una pesadilla) y algunos paquetes de aprendizaje automático (PyTorch, pero tendrá que instalarlo usted mismo ya que el hardware de cada computadora es diferente). Hemos incluido algunos paquetes comunes en `requirements.txt`, que puede instalar de la siguiente manera:

```bash
pip install -r requirements.txt
```
Nota: Si se encuentra en un entorno gestionado, es posible que necesite instalar primero un venv, utilizando
```bash
python3 -m venv venv
source venv/bin/activate
```

### Configuración del Script

Primero, navega a la carpeta `tessera_preprocessing`:

```bash
cd tessera_preprocessing
```

Luego edite el archivo s1_s2_downloader.sh para apuntar al archivo TIFF de ROI, los directorios de salida y temporales, y la fuente de datos:

```bash
# === Basic Configuration ===
INPUT_TIFF="/absolute/path/to/your/data_dir/roi.tiff"
OUT_DIR="/absolute/path/to/your/data_dir"

export TEMP_DIR="/absolute/path/to/your/temp_dir"     # Temporary file directory

mkdir -p "$OUT_DIR"

# Python environment path
PYTHON_ENV="/absolute/path/to/your/python_env/bin/python"

# === Sentinel-1 & Sentinel-2 Processing Configuration ===
YEAR=2022 # Range [2017-2025]
RESOLUTION=10.0  # Output resolution (meters). ROI TIFF can be any resolution; extent is preserved.

# === Data Source Configuration ===
# mpc: Microsoft Planetary Computer (sentinel-1-rtc, sentinel-2-l2a)
# aws: AWS Open Data backends (S1=OPERA RTC-S1 via ASF/CMR + ASF Earthdata Cloud COGs, S2=Earth-search Sentinel-2 L2A COGs)
DATA_SOURCE="mpc"   # choices: mpc/aws
```

Nota: `RESOLUTION` controla el tamaño de píxel de salida. La tubería mantiene los límites de la ROI fijos y remuestrea la máscara de ROI en la cuadrícula de salida.

### Credenciales AWS (solo necesarias cuando `DATA_SOURCE="aws"`)
Sentinel-2 en Earth-search es público y **no requiere credenciales**.

Sentinel-1 OPERA RTC-S1 se accede a través de ASF Earthdata Cloud (COG sobre HTTPS). Necesita un token de Earthdata Login:
- **Cree una cuenta Earthdata**: a través de [NASA Earthdata Login](https://urs.earthdata.nasa.gov/home).
- **Apruebe la Aplicación**: Después de registrar su cuenta, puede ir a la pestaña de Aplicaciones y agregar Alaska Satellite Facility Data Access a la lista de aplicaciones aprobadas.
- **Obtenga un token EDL Bearer / JWT** haciendo clic en **Generate Token** y guárdelo localmente (no lo comprometa).

Recomendado (simple + explícito):

```bash
nano ~/.edl_bearer_token
# paste token, save+exit (Ctrl-O Enter, then Ctrl-X)
chmod 600 ~/.edl_bearer_token
```

El descargador AWS S1 usará este token para leer COGs desde ASF Earthdata Cloud.

Si desea obtener credenciales temporales de S3 (avanzado; usualmente no requerido para este pipeline), consulte la guía de ASF:
- `https://cumulus.asf.alaska.edu/s3credentialsREADME`

Debajo de la configuración anterior, hay algunas configuraciones adicionales que puede modificar según el rendimiento de su computadora.

Primero, otorgue permiso a `s1_s2_downloader.sh`:

```bash
chmod +x s1_s2_downloader.sh
```

Luego, podemos ejecutar:

```bash
bash s1_s2_downloader.sh
```

Debido a las condiciones de la red, el procesamiento de algunos mosaicos puede agotar el tiempo de espera. Nuestro script incluye una gestión sofisticada de los tiempos de espera para evitar estos problemas. Sin embargo, a veces algunos mosaicos pueden fallar. Ejecutar el comando anterior nuevamente suele resolver esto.

Si todos los datos de Sentinel-1 y Sentinel-2 se generan correctamente, pueden apilarse a lo largo de la dimensión temporal. Para este paso, usamos dos ejecutables generados en Rust, lo que lo hace muy rápido. Puedes abrir `s1_s2_stacker.sh` y editar lo siguiente:

```bash
# === Basic Configuration ===
BASE_DIR="/absolute/path/to/your/data_dir"
OUT_DIR="${BASE_DIR}/data_processed"
DOWNSAMPLE_RATE=1
```
Normalmente, no modificamos `DOWNSAMPLE_RATE`, lo que evita que realice cualquier reducción de muestreo durante el apilamiento. El `BASE_DIR` en el fragmento anterior es el mismo que el `OUT_DIR` que modificaste en `s1_s2_downloader.sh`.

De manera similar, da permiso a `s1_s2_stacker.sh`:


```bash
chmod +x s1_s2_stacker.sh
```

Luego puedes ejecutar el apilamiento:

```bash
bash s1_s2_stacker.sh
```

Después del éxito, obtendrás algunos archivos `.npy` en `/absolute/path/to/your/data_dir/data_processed`. Usualmente, estos archivos `.npy` son bastante grandes, por lo que los fragmentaremos en unidades más pequeñas y manejables.

Ejecuta:

```bash
python dpixel_retiler.py \
    --tiff_path /absolute/path/to/your/data_dir/roi.tif \
    --d_pixel_dir /absolute/path/to/your/data_dir/data_processed \
    --patch_size 500 \
    --out_dir /absolute/path/to/your/data_dir/retiled_d_pixel \
    --num_workers 16 \
    --overwrite \
    --block_size 2000
```

Puede cambiar los valores anteriores de `patch_size` y `block_size` usted mismo. La configuración anterior es una configuración recomendada para un TIFF con una forma de (5000,5000) y una resolución de 10m.

Si el código anterior se ejecuta sin problemas, puede obtener algunas subcarpetas en `my_data/retiled_d_pixel`.

## Inferencia

### Visión general

Una vez que se complete el preprocesamiento de datos, podemos comenzar la inferencia. Antes de continuar, verifique si hay subcarpetas en la carpeta `my_data/retiled_d_pixel` como:
```
retiled_d_pixel
 ┣ 0_3500_500_4000
 ┣ 0_4000_500_4500
 ┣ 0_4500_500_5000
 ┣ 0_5000_500_5500
 ┣ 0_5500_500_6000
 ┣ 0_6000_500_6500
```
Cada subcarpeta debe contener los siguientes archivos:

```
0_3500_500_4000
 ┣ bands.npy
 ┣ doys.npy
 ┣ masks.npy
 ┣ roi.tiff
 ┣ sar_ascending.npy
 ┣ sar_ascending_doy.npy
 ┣ sar_descending.npy
 ┗ sar_descending_doy.npy
```

Si estos archivos existen, puedes comenzar la inferencia. De lo contrario, verifica si el primer paso se completó con éxito.

La inferencia requiere PyTorch. Dado que cada sistema puede tener versiones de CUDA ligeramente diferentes, no podemos proporcionar un entorno Python encapsulado en Docker como hicimos para el preprocesamiento de datos. Afortunadamente, el entorno Python para la inferencia es mucho más sencillo de configurar que para el preprocesamiento de datos, ya que no utiliza paquetes de procesamiento geográfico como GDAL o SNAP.

### Preparación de Pytorch

Si no has instalado Pytorch, puedes consultar los pasos a continuación. De lo contrario, puedes ignorar esta sección.

Primero, verifica la versión de CUDA de tu sistema:

```bash
nvidia-smi
```

Luego visite https://pytorch.org/ y seleccione la versión adecuada para instalar según su versión de CUDA, por ejemplo:

```bash
pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu128
```

### Peso del Modelo

A continuación, descargue los pesos del modelo desde [Google Drive](https://drive.google.com/drive/folders/18RPptbUkCIgUfw1aMdMeOrFML_ZVMszn?usp=sharing) y coloque el archivo `.pt` en el directorio `tessera_infer/checkpoints`:

```
tessera_infer
 ┗ checkpoints
     ┗ best_model_fsdp_20250427_084307.pt
 ┗ configs
 ┗ src
```

_**Tenga en cuenta que el punto de control mencionado anteriormente es un modelo en etapa inicial, que genera de forma nativa incrustaciones en float32. Por lo tanto, este modelo no es el que se usa para generar las incrustaciones int8 en la biblioteca geotessera. Pronto implementaremos el punto de control específico que se utilizó para crear las incrustaciones geotessera en la tubería completa.**_

### Configurar script Bash

Para simplificar la configuración de inferencia, proporcionamos `tessera_infer/infer_all_tiles.sh`. Solo necesita editar algunos parámetros:

a. Directorio base de datos:
```bash
BASE_DATA_DIR="your_data_directory"
```
Esta es su carpeta de almacenamiento de datos, igual que `BASE_DATA_DIR` en el bash anterior, por ejemplo, `/maps/usr/tessera_project/my_data`

b. Entorno de Python:
```bash
export PYTHON_ENV="your_python_path"
```
Escriba aquí la ruta absoluta a su entorno de Python, por ejemplo, `/home/user/anaconda3/envs/tessera_env/bin/python`

c. División CPU/GPU:
```bash
CPU_GPU_SPLIT="1:1"  # Format: CPU:GPU ratio
```
El script soporta inferencia simultánea utilizando tanto CPU como GPU. Esta proporción especifica la proporción de `retiled_patches` que cada dispositivo manejará. El valor predeterminado es 1:1 (división equitativa). Para inferencia solo con GPU, configúrelo en 0:1.

d. Configuraciones relacionadas con la CPU

```bash
MAX_CONCURRENT_PROCESSES_CPU=20
```
Número máximo de procesos de CPU para la inferencia por mosaicos. Por ejemplo, si se establece en 20, procesará 20 mosaicos simultáneamente.

```bash
AVAILABLE_CORES=$((TOTAL_CPU_CORES / 2)) # Use 50% of the cores
```
Número de núcleos de CPU a utilizar. ¡Por favor, modifique este valor si es necesario para evitar consumir demasiados recursos de CPU!

e. Configuraciones relacionadas con la GPU:
```bash
MAX_CONCURRENT_PROCESSES_GPU=1
```
Número máximo de procesos GPU para inferencia. Si el sistema tiene solo 1 GPU, configúrelo en 1.

```bash
GPU_BATCH_SIZE=1024  # Larger for GPU, if this takes too much memory, reduce it
```
Número de muestras a procesar a la vez durante la inferencia con PyTorch. Si este valor consume demasiada memoria GPU o causa un error OOM en la GPU, reduzca este valor en consecuencia.

f. Otras Configuraciones
Existen otros parámetros disponibles para configuración. Ajústelos según sea necesario.

### Iniciar Inferencia

Una vez que todo esté listo, navegue a la carpeta `tessera_infer`:

```bash
cd tessera_infer
```

Luego da permiso a `infer_all_tiles.sh`:

```bash
chmod +x infer_all_tiles.sh
```

Luego ejecútalo:

```bash
bash infer_all_tiles.sh
```
Si tiene éxito, debería ver registros como:


```
(base) zf281@daintree:/scratch/zf281/tessera_project/tessera_infer$ bash infer_all_tiles.sh
[INFO] Total CPU cores: 256, Using: 192
[INFO] CPU:GPU split ratio = 1:1 (total: 2)

==== SETUP DIRECTORIES ====
[SUCCESS] Created necessary directories

==== SCANNING TILES ====
[INFO] Tile directory: /scratch/zf281/jovana/retiled_d_pixel
[INFO] Output directory: /scratch/zf281/jovana/representation_retiled
[SUCCESS] Found 226 tiles total
[INFO] Sample tiles:
  - 0_3500_500_4000
  - 0_4000_500_4500
  - 0_4500_500_5000
  - ...
```

Al mismo tiempo, se generará una carpeta `logs` en la carpeta `tessera_infer` con un registro más detallado para cada proceso de CPU y GPU.

### Combinar Mapa de Representación Final

La inferencia generalmente toma mucho tiempo, dependiendo del tamaño de su ROI y del rendimiento del hardware. Una vez completado, puede encontrar muchos archivos `.npy` en `my_data/representation_retiled`:

```
representation_retiled
 ┣ 0_3500_500_4000.npy
 ┣ 0_4000_500_4500.npy
 ┣ 0_4500_500_5000.npy
 ┣ 0_5000_500_5500.npy
 ┣ 0_5500_500_6000.npy
 ┣ 0_6000_500_6500.npy
 ┣ 0_6500_500_7000.npy
 ┣ 0_7000_500_7500.npy
 ┣ 1000_0_1500_500.npy
 ┣ 1000_1000_1500_1500.npy
 ┣ 1000_1500_1500_2000.npy
 ┣ 1000_2000_1500_2500.npy
```

El paso final es unirlos usando `tessera_infer/stitch_tiled_representation.py`:

```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /path/to/d_pixel_retiled \
--representation_retiled_path /path/to/representation_retiled \
--downstream_tiff /path/to/downstream.tiff \
--out_dir /path/to/output_directory
```
Por ejemplo:


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /maps/usr/tessera_project/my_data/d_pixel_retiled \
--representation_retiled_path /maps/usr/tessera_project/my_data/representation_retiled \
--downstream_tiff /maps/usr/tessera_project/my_data/downstream.tiff \
--out_dir /maps/usr/tessera_project/my_data
```
Finalmente, obtendrás un mapa de representación ensamblado en el directorio `my_data` con la forma (H,W,128), donde H y W coinciden con tu `roi.tiff` inicial. El mapa de representación es un arreglo de NumPy. Si deseas convertirlo a TIFF para visualizarlo en software como QGIS, puedes usar el script `tessera_infer/convert_npy2tiff.py`. Simplemente modifica la función principal con:


```python
npy_path = "/maps/usr/tessera_project/my_data/stitched_representation.npy"  # Change to the actual npy file path
ref_tiff_path = "/maps/usr/tessera_project/my_data/roi.tiff"  # Change to the actual reference tiff file path
out_dir = "/maps/usr/tessera_project/my_data/"  # Change to the actual output directory
```

## Tareas descendentes

Si desea reproducir las tareas descendentes del artículo, puede visitar https://github.com/ucam-eo/tessera-downstream-task. Allí se proporcionan muchos ejemplos.

# Información adicional

## Equipo

### Facultad de Cambridge
* [S. Keshav](https://svr-sk818-web.cl.cam.ac.uk/keshav/wiki/index.php/Main_Page)
* [Anil Madhavapeddy](https://anil.recoil.org)
* [Sadiq Jaffer](https://toao.com)
* [David Coomes](https://www.plantsci.cam.ac.uk/directory/david-coomes)

### Postdoctorado
* James Ball
  
### Doctorado
* Madeleine Lisaius
* Zhengpeng (Frank) Feng
* Robin Young
* Jovana Knezevic

### Pregrado
* Zejia Yang (estudiante de Parte II, trabajando con Frank Feng en el preentrenamiento MAE de extractores de características espaciales)

### Pasantes
* Kenzy Soror (U. Waterloo, trabajando con Robin Young)
* Artyom Gabtraupov (U. Waterloo, trabajando con Robin Young)
* Gabriel Mahler (U. Cambridge, trabajando con Anil Madhavapeddy y Silviu Petrovan en [hábitats y seguimiento de erizos](https://anil.recoil.org/ideas/hedgehog-mapping))
* Leyu Pan (Imperial College, trabajando con Frank Feng en incrustaciones de texto generadas a partir de OSM)

### Colaboradores
* [Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/?originalSubdomain=at), dClimate Labs
* [Andrew Blake](https://en.wikipedia.org/wiki/Andrew_Blake_(computer_scientist)), Mantle Labs

### Visitantes
* Silja Sormunnen, Universidad Aalto, Finlandia
* Isabel Mansley (U. Edinburgh, trabajando con David Coomes y Anil Madhavapeddy en [mapeo de hábitats en Escocia](https://anil.recoil.org/ideas/cairngorms-connect-habitats)

## Contacto

Por favor, dirija sus preguntas técnicas a Frank Feng (zf281@cam.ac.uk) o hágalas en nuestro [foro Zulip](https://eeg.zulipchat.com/login/). Las preguntas no técnicas pueden enviarse al Prof. S. Keshav (sk818@cam.ac.uk).

## Cita

Si utiliza TESSERA en su investigación, cite el [artículo de arXiv](https://arxiv.org/abs/2506.20380):

```bibtex
@misc{feng2025tesseratemporalembeddingssurface,
      title={TESSERA: Temporal Embeddings of Surface Spectra for Earth Representation and Analysis}, 
      author={Zhengpeng Feng et al.},
      year={2025},
      eprint={2506.20380},
      archivePrefix={arXiv},
      primaryClass={cs.LG},
      url={https://arxiv.org/abs/2506.20380}, 
}
```

## Agradecimientos
Nos gustaría expresar nuestro agradecimiento a UKRI y al equipo del superordenador [DAWN](https://www.hpc.cam.ac.uk/d-w-n) en Cambridge, por su generoso apoyo en este proyecto. También reconocemos el apoyo de [AMD](https://www.amd.com/en.html), [Vultr](https://www.vultr.com/), la [Instalación de Computación de Alto Rendimiento Dirac](https://dirac.ac.uk), el [Microsoft AI For Good Lab](https://www.microsoft.com/en-us/research/group/ai-for-good-research-lab/), el Dr. Robert Sansom, [dClimate](https://www.dclimate.net/) y [Amazon Web Services (AWS)](https://aws.amazon.com/) bajo su programa AWS Open Data (https://opendata.aws/). Este trabajo no habría sido posible sin su apoyo, recursos computacionales y asistencia técnica. 

## Historial de Estrellas
[![Gráfico de Historial de Estrellas](https://api.star-history.com/svg?repos=ucam-eo/tessera&type=Date)](https://www.star-history.com/#ucam-eo/tessera&Date)

## AUP

### Términos de Uso y Directrices Éticas de TESSERA

### Licencia

Los datos y embeddings de TESSERA están disponibles bajo la **Licencia Internacional Creative Commons 0 [CC-0](https://creativecommons.org/public-domain/cc0/)**.  
Esto significa que usted es libre de:

* **Compartir** — copiar y redistribuir el material en cualquier medio o formato
* **Adaptar** — remezclar, transformar y construir sobre el material para cualquier propósito, incluso comercialmente

### Propósito y Usos Previsto

TESSERA fue desarrollado para avanzar la investigación científica y apoyar la monitorización ambiental, conservación, agricultura sostenible y la comprensión de los sistemas terrestres. Diseñamos esta herramienta para permitir:

* Investigación científica y educación
* Monitorización ambiental y conservación
* Análisis agrícola y de seguridad alimentaria
* Investigación sobre el cambio climático y planificación de adaptación
* Uso sostenible de la tierra y gestión de recursos
* Aplicaciones de interés público que beneficien a la sociedad y al medio ambiente

### Directrices Éticas

Aunque la licencia CC0 permite un uso amplio, alentamos fuertemente a los usuarios a considerar las implicaciones éticas de su trabajo. Estas directrices éticas son consultivas y no imponen restricciones legalmente exigibles. Solicitamos que los usuarios:

**Actúen con Responsabilidad:**
* Consideren las implicaciones de privacidad al analizar ubicaciones específicas
* Respeten los derechos y la dignidad de las comunidades afectadas
* Sean conscientes de posibles preocupaciones de doble uso

**Sean Transparentes:**
* Representar con precisión las características de los datos (resolución anual, resolución espacial de 10 m)  
* Reconocer las limitaciones en sus aplicaciones  
* No tergiversar las capacidades de TESSERA  

**Apoyar el Impacto Positivo:**  
* Considerar cómo su trabajo contribuye al beneficio social  
* Involucrarse con las comunidades afectadas cuando sea apropiado  
* Compartir hallazgos que avancen el conocimiento público  

### Características de los Datos  

Los usuarios deben entender que TESSERA proporciona:  
* **Resolución temporal anual** — los datos representan resúmenes anuales, no monitoreo en tiempo real o de alta frecuencia  
* **Resolución espacial de 10 metros** — adecuada para análisis a escala de paisaje  
* **Incrustaciones espectro-temporales** — representaciones comprimidas, no imágenes sin procesar  

Por favor, represente con precisión estas características en su trabajo.  

### Normas Comunitarias  

Fomentamos el uso responsable y damos la bienvenida a los comentarios de la comunidad. Si tiene inquietudes sobre aplicaciones potenciales o sugerencias para mejorar estas directrices, por favor contáctenos.  

Nos reservamos el derecho de actualizar estas directrices basándonos en la opinión de la comunidad y consideraciones emergentes, aunque dichas actualizaciones no afectan retroactivamente la licencia CC-0 bajo la cual se liberan los datos.  

### Contacto  

Para preguntas o comentarios: Email sk818@cam.ac.uk  

---  

*Última actualización: 25 de febrero de 2026*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---