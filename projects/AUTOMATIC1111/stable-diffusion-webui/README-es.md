# Interfaz web de Stable Diffusion

Una interfaz web para Stable Diffusion, implementada utilizando la librería Gradio.

![](screenshot.png)

## Características
[Demostración detallada de características con imágenes](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Modos originales txt2img e img2img
- Script de instalación y ejecución con un solo clic (pero aún debes instalar python y git)
- Outpainting
- Inpainting
- Boceto de color
- Matriz de prompts
- Escalado Stable Diffusion Upscale
- Atención, especifica partes del texto a las que el modelo debe prestar más atención
    - un hombre en un `((smoking))` - prestará más atención al smoking
    - un hombre en un `(smoking:1.21)` - sintaxis alternativa
    - selecciona el texto y presiona `Ctrl+Arriba` o `Ctrl+Abajo` (o `Command+Arriba` o `Command+Abajo` si estás en MacOS) para ajustar automáticamente la atención al texto seleccionado (código contribuido por un usuario anónimo)
- Loopback, ejecuta el procesamiento img2img múltiples veces
- Gráfica X/Y/Z, una manera de dibujar una gráfica tridimensional de imágenes con diferentes parámetros
- Inversión textual
    - ten tantos embeddings como quieras y usa los nombres que prefieras
    - usa múltiples embeddings con diferente cantidad de vectores por token
    - funciona con números de punto flotante de media precisión
    - entrena embeddings en 8GB (también se han reportado 6GB funcionando)
- Pestaña Extras con:
    - GFPGAN, red neuronal que arregla rostros
    - CodeFormer, herramienta de restauración facial como alternativa a GFPGAN
    - RealESRGAN, escalador neuronal
    - ESRGAN, escalador neuronal con muchos modelos de terceros
    - SwinIR y Swin2SR ([ver aquí](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), escaladores neuronales
    - LDSR, superresolución de difusión latente
- Opciones de cambio de relación de aspecto
- Selección de método de muestreo
    - Ajusta los valores eta del muestreador (multiplicador de ruido)
    - Más opciones avanzadas de configuración de ruido
- Interrumpe el procesamiento en cualquier momento
- Soporte para tarjetas de video de 4GB (también se reporta funcionamiento con 2GB)
- Semillas correctas para lotes
- Validación en vivo de longitud de tokens del prompt
- Parámetros de generación
     - los parámetros usados para generar las imágenes se guardan con la imagen
     - en chunks PNG para PNG, en EXIF para JPEG
     - puedes arrastrar la imagen a la pestaña PNG info para restaurar los parámetros de generación y copiarlos automáticamente en la IU
     - se puede desactivar en configuración
     - arrastra y suelta una imagen/texto-parámetros en la caja de prompts
- Botón Leer Parámetros de Generación, carga los parámetros de la caja de prompts a la IU
- Página de configuración
- Ejecuta código Python arbitrario desde la IU (debe ejecutarse con `--allow-code` para habilitarlo)
- Sugerencias al pasar el mouse sobre la mayoría de los elementos de la IU
- Es posible cambiar valores por defecto/mín/máx/paso de los elementos de la IU mediante archivo de configuración de texto
- Soporte de mosaicos, una casilla para crear imágenes que pueden ser usadas como texturas repetibles
- Barra de progreso y vista previa en vivo de la generación de imagen
    - Puede usar una red neuronal separada para producir previsualizaciones con casi nada de requerimiento de VRAM o cómputo
- Prompt negativo, un campo de texto extra que te permite listar lo que no quieres ver en la imagen generada
- Estilos, una forma de guardar partes de prompts y aplicarlos fácilmente desde el menú desplegable después
- Variaciones, una forma de generar la misma imagen pero con pequeñas diferencias
- Redimensionado de semilla, una forma de generar la misma imagen pero con una resolución ligeramente diferente
- Interrogador CLIP, un botón que intenta adivinar el prompt a partir de una imagen
- Edición de prompt, una forma de cambiar el prompt a mitad de la generación, por ejemplo, para empezar haciendo una sandía y cambiar a chica anime a mitad del proceso
- Procesamiento por lotes, procesa un grupo de archivos usando img2img
- Alternativa img2img, método inverso de Euler para control de atención cruzada
- Highres Fix, opción conveniente para producir imágenes de alta resolución en un clic sin distorsiones habituales
- Recarga de checkpoints al vuelo
- Combinador de checkpoints, pestaña que permite combinar hasta 3 checkpoints en uno
- [Scripts personalizados](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) con muchas extensiones de la comunidad
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), una forma de usar múltiples prompts al mismo tiempo
     - separa los prompts usando `AND` en mayúsculas
     - también soporta pesos para los prompts: `un gato :1.2 AND un perro AND un pingüino :2.2`
- Sin límite de tokens para prompts (la versión original de stable diffusion permite hasta 75 tokens)
- Integración DeepDanbooru, crea etiquetas al estilo danbooru para prompts de anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), gran aumento de velocidad para ciertas tarjetas: (añadir `--xformers` a los argumentos de la línea de comandos)
- vía extensión: [Pestaña de Historial](https://github.com/yfszzx/stable-diffusion-webui-images-browser): visualiza, dirige y elimina imágenes cómodamente desde la IU
- Opción de generar indefinidamente
- Pestaña de entrenamiento
     - opciones de hypernetworks y embeddings
     - Preprocesamiento de imágenes: recorte, espejado, autotagging usando BLIP o deepdanbooru (para anime)
- Clip skip
- Hypernetworks
- Loras (igual que Hypernetworks pero más bonitas)
- Una IU separada donde puedes elegir, con previsualización, qué embeddings, hypernetworks o Loras añadir a tu prompt
- Puede seleccionarse cargar un VAE diferente desde la pantalla de configuración
- Tiempo estimado de finalización en la barra de progreso
- API
- Soporte para modelo dedicado de [inpainting](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) de RunwayML
- vía extensión: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), una forma de generar imágenes con una estética específica usando embeddings de imágenes clip (implementación de [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Soporte para [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - ver [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) para instrucciones
- Soporte para [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - ver [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) para instrucciones
- ¡Ahora sin ninguna letra prohibida!
- Cargar checkpoints en formato safetensors
- Restricción de resolución suavizada: las dimensiones de la imagen generada deben ser múltiplos de 8 en vez de 64
- ¡Ahora con licencia!
- Reordenar elementos en la IU desde la pantalla de configuración
- Soporte para [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Instalación y Ejecución
Asegúrate de cumplir con las [dependencias](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) requeridas y sigue las instrucciones disponibles para:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (recomendado)
- GPUs [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs).
- [CPUs Intel, GPUs Intel (integradas y discretas)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (página wiki externa)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (página wiki externa)

Alternativamente, usa servicios en línea (como Google Colab):

- [Lista de servicios en línea](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Instalación en Windows 10/11 con GPUs NVidia usando el paquete de lanzamiento
1. Descarga `sd.webui.zip` desde [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) y extrae su contenido.
2. Ejecuta `update.bat`.
3. Ejecuta `run.bat`.
> Para más detalles, ver [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Instalación automática en Windows
1. Instala [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Versiones más nuevas de Python no son compatibles con torch), marcando "Add Python to PATH".
2. Instala [git](https://git-scm.com/download/win).
3. Descarga el repositorio stable-diffusion-webui, por ejemplo ejecutando `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Ejecuta `webui-user.bat` desde el Explorador de Windows como usuario normal (no administrador).

### Instalación automática en Linux
1. Instala las dependencias:
```bash
# Basado en Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Basado en Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# Basado en openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Basado en Arch:
sudo pacman -S wget git python3
```
Si tu sistema es muy nuevo, necesitas instalar python3.11 o python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # no confundir con el paquete python3.11

# Solo para 3.11
# Luego configura la variable de entorno en el script de lanzamiento
export python_cmd="python3.11"
# o en webui-user.sh
python_cmd="python3.11"
```
2. Navega al directorio donde quieres instalar la webui y ejecuta el siguiente comando:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
O simplemente clona el repositorio donde quieras:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Ejecuta `webui.sh`.
4. Revisa `webui-user.sh` para opciones.
### Instalación en Apple Silicon

Encuentra las instrucciones [aquí](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Contribuir
Así es como puedes añadir código a este repositorio: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Documentación

La documentación se trasladó desde este README al [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) del proyecto.

Con el fin de que Google y otros motores de búsqueda indexen el wiki, aquí tienes un enlace al (no para humanos) [wiki rastreable](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Créditos
Las licencias del código utilizado se pueden encontrar en la pantalla `Settings -> Licenses`, y también en el archivo `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implementando
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Ideas para optimizaciones - https://github.com/basujindal/stable-diffusion
- Optimización de la capa Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, idea original para edición de prompt.
- Optimización de la capa Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (originalmente http://github.com/lstein/stable-diffusion)
- Optimización subcuadrática de la capa Cross Attention - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Inversión textual - Rinon Gal - https://github.com/rinongal/textual_inversion (no usamos su código, pero sí sus ideas).
- Idea para SD upscale - https://github.com/jquesnelle/txt2imghd
- Generación de ruido para outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Idea del interrogador CLIP y parte del código - https://github.com/pharmapsychotic/clip-interrogator
- Idea para Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogador para difusores de anime https://github.com/KichangKim/DeepDanbooru
- Muestreo en precisión float32 desde un UNet en float16 - marunine por la idea, Birch-san por el ejemplo de implementación Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- Consejos de seguridad - RyotaK
- Muestreador UniPC - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Reinicio de muestreo - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Script inicial de Gradio - publicado en 4chan por un usuario Anónimo. Gracias, usuario Anónimo.
- (Tú)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---