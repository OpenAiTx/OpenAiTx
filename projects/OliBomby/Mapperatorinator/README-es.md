
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Prueba el modelo generativo [aquí](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), o MaiMod [aquí](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Mira una demostración en video [aquí](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator es un marco multi-modelo que utiliza entradas de espectrograma para generar mapas de osu! completamente funcionales para todos los modos de juego y [asistir en el modding de mapas](#maimod-the-ai-driven-modding-tool).
El objetivo de este proyecto es generar automáticamente mapas de osu! de calidad rankeable para cualquier canción, con un alto grado de personalización.

Este proyecto está construido sobre [osuT5](https://github.com/gyataro/osuT5) y [osu-diffusion](https://github.com/OliBomby/osu-diffusion). Para desarrollarlo, dediqué aproximadamente 2500 horas de cómputo GPU en 142 ejecuciones en mi 4060 Ti y alquilando instancias 4090 en vast.ai.

#### Utiliza esta herramienta de manera responsable. Siempre divulga el uso de IA en tus beatmaps.

## Instalación

La siguiente instrucción te permite generar beatmaps en tu máquina local, alternativamente puedes ejecutarlo en la nube con el [colab notebook](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Clona el repositorio

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Opcional) Crear entorno virtual

Utilice Python 3.10, versiones posteriores podrían no ser compatibles con las dependencias.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```
### 3. Instalar dependencias

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Para GPUs NVIDIA) o [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Para GPUs AMD en Linux)
- [PyTorch](https://pytorch.org/get-started/locally/): Asegúrate de seguir la guía para comenzar para instalar `torch` y `torchaudio` con soporte para GPU. Selecciona la versión correcta de la Plataforma de Cómputo que instalaste en el paso anterior.

- y las dependencias restantes de Python:


```sh
pip install -r requirements.txt
```

## Interfaz Web (Recomendada)

Para una experiencia más amigable, considere usar la Interfaz Web. Proporciona una interfaz gráfica para configurar los parámetros de generación, iniciar el proceso y monitorear la salida.

### Iniciar la Interfaz

Navegue al directorio clonado `Mapperatorinator` en su terminal y ejecute:

```sh
python web-ui.py
```
Esto iniciará un servidor web local y abrirá automáticamente la interfaz en una nueva ventana.

### Uso de la GUI

- **Configurar:** Establezca las rutas de entrada/salida usando los campos del formulario y los botones "Examinar". Ajuste los parámetros de generación como modo de juego, dificultad, estilo (año, ID del creador, descriptores), sincronización, características específicas (hitsounds, sincronización avanzada), y más, reflejando las opciones de línea de comandos. (Nota: Si proporciona una `beatmap_path`, la interfaz determinará automáticamente la `audio_path` y la `output_path` a partir de ella, por lo que puede dejar esos campos en blanco)
- **Iniciar:** Haga clic en el botón "Iniciar Inferencia" para comenzar la generación del beatmap.
- **Cancelar:** Puede detener el proceso en curso usando el botón "Cancelar Inferencia".
- **Abrir Salida:** Una vez finalizado, use el botón "Abrir Carpeta de Salida" para acceder rápidamente a los archivos generados.

La interfaz web actúa como un envoltorio conveniente alrededor del script `inference.py`. Para opciones avanzadas o solución de problemas, consulte las instrucciones de línea de comandos.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Inferencia por Línea de Comandos

Para usuarios que prefieren la línea de comandos o necesitan acceso a configuraciones avanzadas, siga los pasos a continuación. **Nota:** Para una interfaz gráfica más sencilla, consulte la sección [Web UI (Recomendado)](#web-ui-recommended) arriba.

Ejecute `inference.py` y pase algunos argumentos para generar beatmaps. Para esto, use la [sintaxis de sobrescritura Hydra](https://hydra.cc/docs/advanced/override_grammar/basic/). Consulte `configs/inference_v29.yaml` para todos los parámetros disponibles.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```
Ejemplo:

```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## CLI interactiva
Para quienes prefieren un flujo de trabajo basado en terminal pero desean una configuración guiada, el script CLI interactivo es una excelente alternativa a la interfaz web.

### Lanzar la CLI
Navega al directorio clonado. Es posible que necesites hacer el script ejecutable primero.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### Uso de la CLI
El script te guiará a través de una serie de indicaciones para configurar todos los parámetros de generación, igual que la interfaz web.

Utiliza una interfaz codificada por colores para mayor claridad.
Ofrece un menú avanzado de selección múltiple para elegir descriptores de estilo usando las teclas de flecha y la barra espaciadora.
Después de responder todas las preguntas, mostrará el comando final para tu revisión.
Luego puedes confirmar para ejecutarlo directamente o cancelar y copiar el comando para uso manual.

## Consejos de Generación

- Puedes editar `configs/inference_v29.yaml` y agregar tus argumentos allí en lugar de escribirlos en la terminal cada vez.
- Todos los descriptores disponibles se pueden encontrar [aquí](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Siempre proporciona un argumento de año entre 2007 y 2023. Si lo dejas desconocido, el modelo podría generar con un estilo inconsistente.
- Siempre proporciona un argumento de dificultad. Si lo dejas desconocido, el modelo podría generar con una dificultad inconsistente.
- Incrementa el parámetro `cfg_scale` para aumentar la efectividad de los argumentos `mapper_id` y `descriptors`.
- Puedes usar el argumento `negative_descriptors` para guiar al modelo alejándolo de ciertos estilos. Esto solo funciona cuando `cfg_scale > 1`. Asegúrate que el número de descriptores negativos sea igual al número de descriptores.
- Si el estilo de tu canción y el estilo deseado del mapa no coinciden bien, el modelo podría no seguir tus indicaciones. Por ejemplo, es difícil generar un mapa de SR alto y SV alto para una canción tranquila.
- Si ya tienes el timing y los tiempos de kiai hechos para una canción, puedes dárselos al modelo para aumentar mucho la velocidad y precisión de la inferencia: Usa los argumentos `beatmap_path` e `in_context=[TIMING,KIAI]`.
- Para remapear solo una parte de tu mapa, usa los argumentos `beatmap_path`, `start_time`, `end_time` y `add_to_beatmap=true`.
- Para generar una dificultad guest para un mapa, usa los argumentos `beatmap_path` e `in_context=[GD,TIMING,KIAI]`.
- Para generar hitsounds para un mapa, usa los argumentos `beatmap_path` e `in_context=[NO_HS,TIMING,KIAI]`.
- Para generar solo timing para una canción, usa los argumentos `super_timing=true` y `output_type=[TIMING]`.

## MaiMod: La Herramienta de Modding Impulsada por IA

MaiMod es una herramienta de modding para mapas de osu! que usa predicciones de Mapperatorinator para encontrar posibles fallos e inconsistencias que no pueden ser detectadas por otras herramientas automáticas de modding como [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier).
Puede detectar problemas como:
- Snapping o patrones rítmicos incorrectos
- Puntos de timing inexactos
- Posiciones inconsistentes de objetos o colocaciones nuevas de combo
- Formas extrañas de sliders
- Hitsounds o volúmenes inconsistentes

Puedes probar MaiMod [aquí](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb), o ejecutarlo localmente:
Para ejecutar MaiMod localmente, necesitarás instalar Mapperatorinator. Luego, ejecuta el script `mai_mod.py`, especificando la ruta de tu mapa con el argumento `beatmap_path`.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Esto imprimirá las sugerencias de modificación en la consola, que luego puedes aplicar manualmente a tu mapa de ritmo.  
Las sugerencias están ordenadas cronológicamente y agrupadas en categorías.  
El primer valor en el círculo indica la 'sorpresa', que es una medida de qué tan inesperado encontró el modelo el problema, para que puedas priorizar los problemas más importantes.  

El modelo puede cometer errores, especialmente en problemas de baja sorpresa, así que siempre verifica dos veces las sugerencias antes de aplicarlas a tu mapa de ritmo.  
El objetivo principal es ayudarte a reducir el espacio de búsqueda de posibles problemas, para que no tengas que revisar manualmente cada objeto de golpe en tu mapa de ritmo.  

### MaiMod GUI  
Para ejecutar la interfaz web de MaiMod, necesitarás instalar Mapperatorinator.  
Luego, ejecuta el script `mai_mod_ui.py`. Esto iniciará un servidor web local y abrirá automáticamente la interfaz en una nueva ventana:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Visión general

### Tokenización

Mapperatorinator convierte los mapas de osu! en una representación intermedia de eventos que puede ser convertida directamente hacia y desde tokens.
Incluye objetos de golpe, sonidos de golpe, velocidades de sliders, nuevos combos, puntos de sincronización, tiempos kiai y velocidades de desplazamiento para taiko/mania.

Aquí hay un pequeño ejemplo del proceso de tokenización:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Para ahorrar en el tamaño del vocabulario, los eventos de tiempo se cuantifican en intervalos de 10 ms y las coordenadas de posición se cuantifican en una cuadrícula de 32 píxeles.

### Arquitectura del modelo
El modelo es básicamente un envoltorio alrededor del modelo [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration), con embeddings de entrada personalizados y función de pérdida.
El tamaño del modelo es de 219 millones de parámetros.
Se encontró que este modelo es más rápido y preciso que T5 para esta tarea.

La visión general de alto nivel de la entrada y salida del modelo es la siguiente:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

El modelo usa marcos de espectrograma Mel como entrada del codificador, con un marco por posición de entrada. La salida del decodificador en cada paso es una distribución softmax sobre un vocabulario discreto y predefinido de eventos. Las salidas son escasas, los eventos solo se requieren cuando ocurre un objeto de golpe, en lugar de anotar cada marco de audio individual.

### Formato de entrenamiento multitarea

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Antes del token SOS hay tokens adicionales que facilitan la generación condicional. Estos tokens incluyen el modo de juego, la dificultad, el ID del mapper, el año y otros metadatos.
Durante el entrenamiento, estos tokens no tienen etiquetas acompañantes, por lo que nunca son generados por el modelo. 
También durante el entrenamiento existe una probabilidad aleatoria de que un token de metadatos sea reemplazado por un token 'desconocido', de modo que durante la inferencia podemos usar estos tokens 'desconocidos' para reducir la cantidad de metadatos que debemos proporcionar al modelo.

### Generación continua sin interrupciones

La longitud de contexto del modelo es de 8.192 segundos. Esto obviamente no es suficiente para generar un mapa completo, por lo que debemos dividir la canción en múltiples ventanas y generar el mapa en partes pequeñas.
Para asegurarnos de que el mapa generado no tenga uniones notorias entre ventanas, usamos una superposición del 90% y generamos las ventanas secuencialmente.
Cada ventana de generación, excepto la primera, comienza con el decodificador prellenado hasta un 50% de la ventana de generación con tokens de las ventanas anteriores.
Utilizamos un procesador logit para asegurarnos de que el modelo no pueda generar tokens de tiempo que estén en el primer 50% de la ventana de generación.  
Además, el último 40% de la ventana de generación está reservado para la siguiente ventana. Cualquier token de tiempo generado en ese rango se trata como tokens EOS.  
Esto asegura que cada token generado esté condicionado por al menos 4 segundos de tokens previos y 3.3 segundos de audio futuro para anticipar.  

Para evitar el desplazamiento del offset durante una generación larga, se han añadido offsets aleatorios a los eventos de tiempo en el decodificador durante el entrenamiento.  
Esto lo obliga a corregir errores de sincronización escuchando los inicios en el audio en su lugar, y resulta en un offset consistentemente preciso.  

### Coordenadas refinadas con difusión  

Las coordenadas de posición generadas por el decodificador se cuantizan en una cuadrícula de 32 píxeles, por lo que luego usamos difusión para eliminar el ruido de las coordenadas hasta las posiciones finales.  
Para esto entrenamos una versión modificada de [osu-diffusion](https://github.com/OliBomby/osu-diffusion) que está especializada solo en el último 10% del programa de ruido, y acepta los tokens de metadatos más avanzados que Mapperatorinator usa para la generación condicional.  

Dado que el modelo Mapperatorinator genera el SV de los sliders, la longitud requerida del slider es fija independientemente de la forma del camino del punto de control.  
Por lo tanto, tratamos de guiar el proceso de difusión para crear coordenadas que se ajusten a las longitudes requeridas del slider.  
Hacemos esto recalculando las posiciones finales del slider después de cada paso del proceso de difusión basándonos en la longitud requerida y el camino actual del punto de control.  
Esto significa que el proceso de difusión no tiene control directo sobre las posiciones finales del slider, pero aún puede influenciarlas cambiando el camino del punto de control.  

### Post-procesamiento  

Mapperatorinator realiza un post-procesamiento adicional para mejorar la calidad del beatmap generado:  

- Refinar coordenadas de posición con difusión.  
- Reajustar eventos de tiempo al tick más cercano usando los divisores de snap generados por el modelo.  
- Ajustar solapamientos posicionales casi perfectos.  
- Convertir eventos de columnas mania a coordenadas X.  
- Generar caminos de sliders para redobles de taiko.  
- Corregir grandes discrepancias en la longitud requerida del slider y la longitud del camino del punto de control.  

### Generador de super sincronización  

El generador de super sincronización es un algoritmo que mejora la precisión y exactitud de la sincronización generada inferiendo la sincronización para toda la canción 20 veces y promediando los resultados.  
Esto es útil para canciones con BPM variable, o canciones con cambios de BPM. El resultado es casi perfecto con solo a veces una sección que necesita ajuste manual.  

## Entrenamiento  

La instrucción a continuación crea un entorno de entrenamiento en tu máquina local.  

### 1. Clona el repositorio  

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Crear conjunto de datos

Crea tu propio conjunto de datos usando la [aplicación de consola Mapperator](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Requiere un [token de cliente OAuth de osu!](https://osu.ppy.sh/home/account/edit) para verificar beatmaps y obtener metadatos adicionales. Coloca el conjunto de datos en un directorio `datasets` junto al directorio `Mapperatorinator`.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Opcional) Configurar Weight & Biases para el registro
Crea una cuenta en [Weight & Biases](https://wandb.ai/site) y obtén tu clave API desde la configuración de tu cuenta.
Luego, establece la variable de entorno `WANDB_API_KEY`, para que el proceso de entrenamiento sepa registrar con esta clave.

```sh
export WANDB_API_KEY=<your_api_key>
```
### 4. Crear contenedor docker
El entrenamiento en tu entorno virtual también es posible, pero recomendamos usar Docker en WSL para un mejor rendimiento.

```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Configurar parámetros y comenzar el entrenamiento

Todas las configuraciones se encuentran en `./configs/train/default.yaml`. 
Asegúrese de establecer la ruta correcta `train_dataset_path` y `test_dataset_path` a su conjunto de datos, así como los índices de inicio y fin del conjunto de mapas para la división train/test.
La ruta es local al contenedor de docker, por lo que si colocó su conjunto de datos llamado `cool_dataset` en el directorio `datasets`, entonces debería ser `/workspace/datasets/cool_dataset`.

Recomiendo crear un archivo de configuración personalizado que sobrescriba la configuración predeterminada, para que tenga un registro de su configuración de entrenamiento para reproducibilidad.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. Afinación LoRA

También puedes afinar un modelo preentrenado con [LoRA](https://arxiv.org/abs/2106.09685) para adaptarlo a un estilo o modo de juego específico.
Para ello, adapta `configs/train/lora.yaml` a tus necesidades y ejecuta la configuración de entrenamiento `lora`:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Parámetros importantes de LoRA a considerar:
- `pretrained_path`: Ruta o repositorio HF del modelo base para ajustar.
- `r`: Rango de las matrices LoRA. Valores más altos aumentan la capacidad del modelo pero también el uso de memoria.
- `lora_alpha`: Factor de escalado para las actualizaciones LoRA.
- `total_steps`: Número total de pasos de entrenamiento. Ajústalo según el tamaño de tu conjunto de datos.
- `enable_lora`: Si usar LoRA o ajuste completo del modelo.

Durante la inferencia, puedes especificar los pesos LoRA a usar con el argumento `lora_path`.
Esto puede ser una ruta local o un repositorio de Hugging Face.

## Ver también
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Créditos

Agradecimientos especiales a:
1. Los autores de [osuT5](https://github.com/gyataro/osuT5) por su código de entrenamiento.
2. El equipo de Hugging Face por sus [herramientas](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) y [Richard Nagyfi](https://github.com/sedthh) por intercambiar ideas.
4. [Marvin](https://github.com/minetoblend) por donar créditos de entrenamiento.
5. La comunidad de osu! por los beatmaps.

## Trabajos relacionados

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) por Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) por kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) por OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) por gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) por sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) por jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---