# Interfaz web de Stable Diffusion
Una interfaz web para Stable Diffusion, implementada usando la biblioteca Gradio.

![](https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/screenshot.png)

## Características
[Demostración detallada de características con imágenes](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Modos originales txt2img y img2img
- Script de instalación y ejecución con un clic (pero aún debe instalar python y git)
- Outpainting
- Inpainting
- Boceto en color
- Matriz de prompts
- Escalado de Stable Diffusion
- Atención, especificar partes del texto a las que el modelo debe prestar más atención
    - un hombre en un `((esmoquin))` - prestará más atención al esmoquin
    - un hombre en un `(esmoquin:1.21)` - sintaxis alternativa
    - seleccionar texto y presionar `Ctrl+Arriba` o `Ctrl+Abajo` (o `Command+Arriba` o `Command+Abajo` si usas MacOS) para ajustar automáticamente la atención al texto seleccionado (código aportado por usuario anónimo)
- Bucle, ejecutar procesamiento img2img múltiples veces
- Gráfico X/Y/Z, una manera de dibujar un gráfico tridimensional de imágenes con diferentes parámetros
- Inversión textual
    - tener tantos embeddings como quieras y usar cualquier nombre para ellos
    - usar múltiples embeddings con diferente número de vectores por token
    - funciona con números de punto flotante de media precisión
    - entrenar embeddings en 8GB (también reportes de funcionamiento con 6GB)
- Pestaña Extras con:
    - GFPGAN, red neuronal que corrige caras
    - CodeFormer, herramienta de restauración facial como alternativa a GFPGAN
    - RealESRGAN, red neuronal para escalado
    - ESRGAN, red neuronal para escalado con muchos modelos de terceros
    - SwinIR y Swin2SR ([ver aquí](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), redes neuronales para escalado
    - LDSR, escalado super resolución por difusión latente
- Opciones para cambiar proporción de aspecto al redimensionar
- Selección de método de muestreo
    - Ajustar valores eta del muestreador (multiplicador de ruido)
    - Opciones avanzadas de configuración de ruido
- Interrumpir el procesamiento en cualquier momento
- Soporte para tarjetas de video de 4GB (también reportes de funcionamiento con 2GB)
- Semillas correctas para lotes
- Validación en vivo de longitud de tokens del prompt
- Parámetros de generación
     - parámetros usados para generar imágenes se guardan con la imagen
     - en chunks PNG para PNG, en EXIF para JPEG
     - se puede arrastrar la imagen a la pestaña de información PNG para restaurar parámetros de generación y copiarlos automáticamente a la UI
     - puede desactivarse en la configuración
     - arrastrar y soltar imagen/parámetros-texto al cuadro de prompt
- Botón Leer Parámetros de Generación, carga parámetros en el cuadro de prompt en la UI
- Página de configuración
- Ejecutar código python arbitrario desde la UI (debe correr con `--allow-code` para habilitar)
- Sugerencias al pasar el mouse sobre la mayoría de elementos UI
- Posibilidad de cambiar valores por defecto/máximos/mínimos/pasos para elementos UI vía archivo de configuración de texto
- Soporte para teselado, una casilla para crear imágenes que se puedan teselar como texturas
- Barra de progreso y vista previa en vivo de generación de imagen
    - Puede usar una red neuronal separada para producir vistas previas con casi ningún requerimiento de VRAM o cálculo
- Prompt negativo, un campo de texto extra que permite listar lo que no quieres ver en la imagen generada
- Estilos, una forma de guardar parte del prompt y aplicarlo fácilmente luego vía menú desplegable
- Variaciones, una forma de generar la misma imagen pero con pequeñas diferencias
- Redimensionamiento por semilla, una forma de generar la misma imagen pero con resolución ligeramente diferente
- Interrogador CLIP, un botón que intenta adivinar el prompt a partir de una imagen
- Edición de prompt, una forma de cambiar el prompt a mitad de generación, por ejemplo para empezar haciendo una sandía y cambiar a chica anime a mitad del proceso
- Procesamiento por lotes, procesar un grupo de archivos usando img2img
- Alternativa img2img, método Euler inverso de control de atención cruzada
- Corrección de alta resolución, opción cómoda para producir imágenes de alta resolución en un clic sin distorsiones habituales
- Recarga de checkpoints en caliente
- Fusionador de checkpoints, una pestaña que permite fusionar hasta 3 checkpoints en uno
- [Scripts personalizados](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) con muchas extensiones de la comunidad
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), una forma de usar múltiples prompts a la vez
     - separar prompts usando `AND` en mayúsculas
     - también soporta pesos para prompts: `un gato :1.2 AND un perro AND un pingüino :2.2`
- Sin límite de tokens para prompts (Stable Diffusion original permite hasta 75 tokens)
- Integración DeepDanbooru, crea etiquetas estilo danbooru para prompts de anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), gran aumento de velocidad para tarjetas selectas: (agregar `--xformers` a los argumentos de línea de comandos)
- vía extensión: [Pestaña Historial](https://github.com/yfszzx/stable-diffusion-webui-images-browser): ver, dirigir y eliminar imágenes cómodamente dentro de la UI
- Opción de generar para siempre
- Pestaña de entrenamiento
     - opciones para hypernetworks y embeddings
     - Preprocesamiento de imágenes: recorte, espejado, etiquetado automático usando BLIP o deepdanbooru (para anime)
- Clip skip
- Hypernetworks
- Loras (igual que Hypernetworks pero más bonitos)
- Una UI separada donde puedes elegir, con vista previa, qué embeddings, hypernetworks o Loras añadir a tu prompt
- Se puede seleccionar cargar un VAE distinto desde la pantalla de configuración
- Tiempo estimado de finalización en barra de progreso
- API
- Soporte para [modelo dedicado de inpainting](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) por RunwayML
- vía extensión: [Gradientes Estéticos](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), una forma de generar imágenes con una estética específica usando embeddings de imágenes clip (implementación de [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Soporte para [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - ver [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) para instrucciones
- Soporte para [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - ver [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) para instrucciones
- Ahora sin letras malas!
- Carga de checkpoints en formato safetensors
- Restricción de resolución relajada: las dimensiones de la imagen generada deben ser múltiplos de 8 en lugar de 64
- ¡Ahora con licencia!
- Reordenar elementos en la UI desde la pantalla de configuración
- Soporte para [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Instalación y ejecución
Asegúrate de cumplir con las [dependencias](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) requeridas y sigue las instrucciones disponibles para:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (recomendado)
- GPUs [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs).
- [CPUs Intel, GPUs Intel (integradas y discretas)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (página wiki externa)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (página wiki externa)

Alternativamente, use servicios en línea (como Google Colab):

- [Lista de Servicios en Línea](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Instalación en Windows 10/11 con GPUs NVidia usando paquete de lanzamiento
1. Descargue `sd.webui.zip` desde [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) y extraiga su contenido.
2. Ejecute `update.bat`.
3. Ejecute `run.bat`.
> Para más detalles vea [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Instalación Automática en Windows
1. Instale [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (la versión más reciente de Python no soporta torch), marcando "Add Python to PATH".
2. Instale [git](https://git-scm.com/download/win).
3. Descargue el repositorio stable-diffusion-webui, por ejemplo ejecutando `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Ejecute `webui-user.bat` desde el Explorador de Windows como un usuario normal, sin privilegios de administrador.

### Instalación Automática en Linux
1. Instale las dependencias:
```bash
# Debian-based:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat-based:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-based:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-based:
sudo pacman -S wget git python3
```
Si su sistema es muy nuevo, necesita instalar python3.11 o python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # do not confuse with python3.11 package

# Only for 3.11
# Then set up env variable in launch script
export python_cmd="python3.11"
# or in webui-user.sh
python_cmd="python3.11"
```
2. Navegue al directorio donde desea que se instale la interfaz web y ejecute el siguiente comando:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
O simplemente clona el repositorio donde quieras:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```
3. Ejecuta `webui.sh`.
4. Consulta `webui-user.sh` para opciones.
### Instalación en Apple Silicon

Encuentra las instrucciones [aquí](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Contribuciones
Aquí se explica cómo agregar código a este repositorio: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Documentación

La documentación se trasladó de este README al [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) del proyecto.

Para que Google y otros motores de búsqueda rastreen el wiki, aquí hay un enlace al (no para humanos) [wiki rastreable](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Créditos
Las licencias para el código prestado se pueden encontrar en la pantalla `Settings -> Licenses`, y también en el archivo `html/licenses.html`.

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
- Optimización de capa de Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, idea original para edición de prompts.
- Optimización de capa de Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (originalmente http://github.com/lstein/stable-diffusion)
- Optimización sub-cuadrática de capa de Cross Attention - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (no usamos su código, pero sí sus ideas).
- Idea para escalado SD - https://github.com/jquesnelle/txt2imghd
- Generación de ruido para outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Idea y código prestado del interrogador CLIP - https://github.com/pharmapsychotic/clip-interrogator
- Idea para Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogador para anime diffusers https://github.com/KichangKim/DeepDanbooru
- Muestreo en precisión float32 desde un UNet float16 - marunine por la idea, Birch-san por la implementación ejemplo en Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (estrella), Aleksander Holynski (estrella), Alexei A. Efros (sin estrella) - https://github.com/timothybrooks/instruct-pix2pix
- Consejos de seguridad - RyotaK
- Muestreador UniPC - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Reinicio de muestreo - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Script inicial de Gradio - publicado en 4chan por un usuario Anónimo. Gracias usuario Anónimo.
- (Tú)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---