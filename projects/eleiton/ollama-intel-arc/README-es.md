# Ejecuta Ollama, Stable Diffusion y Reconocimiento Automático de Voz con tu GPU Intel Arc

[[Blog](https://blog.eleiton.dev/posts/llm-and-genai-in-docker/)]

Despliega fácilmente una solución basada en Docker que utiliza [Open WebUI](https://github.com/open-webui/open-webui) como tu interfaz de IA amigable  
y [Ollama](https://github.com/ollama/ollama) para integrar Modelos de Lenguaje Grandes (LLM).

Adicionalmente, puedes ejecutar contenedores docker de [ComfyUI](https://github.com/comfyanonymous/ComfyUI) o [SD.Next](https://github.com/vladmandic/sdnext) para  
optimizar las capacidades de Stable Diffusion.

También puedes ejecutar un contenedor docker opcional con [OpenAI Whisper](https://github.com/openai/whisper) para realizar tareas de Reconocimiento Automático de Voz (ASR).

Todos estos contenedores han sido optimizados para GPUs Intel Arc Series en sistemas Linux utilizando [Intel® Extension for PyTorch](https://github.com/intel/intel-extension-for-pytorch).

![captura de pantalla](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui.png)

## Servicios
1. Ollama  
   * Ejecuta llama.cpp y Ollama con IPEX-LLM en tu computadora Linux con GPU Intel Arc.  
   * Construido siguiendo las directrices de [Intel](https://github.com/intel/ipex-llm/blob/main/docs/mddocs/DockerGuides/README.md).  
   * Usa la imagen oficial de docker [Intel ipex-llm](https://hub.docker.com/r/intelanalytics/ipex-llm-inference-cpp-xpu) como contenedor base.
   * Utiliza las versiones más recientes de los paquetes requeridos, priorizando características avanzadas sobre la estabilidad.  
   * Expone el puerto `11434` para conectar otras herramientas a tu servicio Ollama.

2. Open WebUI  
   * Usa la distribución oficial de Open WebUI.  
   * `WEBUI_AUTH` está desactivado para uso sin autenticación.  
   * Las banderas `ENABLE_OPENAI_API` y `ENABLE_OLLAMA_API` están configuradas en apagado y encendido, respectivamente, permitiendo interacciones solo vía Ollama.
   * `ENABLE_IMAGE_GENERATION` está activado, permitiéndote generar imágenes desde la interfaz.
   * `IMAGE_GENERATION_ENGINE` está configurado en automatic1111 (SD.Next es compatible).

3. ComfyUI
   * La interfaz gráfica, API y backend de modelo de difusión más poderosa y modular con interfaz de nodos/gráficos.
   * Usa como contenedor base la oficial [Intel® Extension for PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu)

4. SD.Next
   * Todo en uno para imagen generativa AI basada en Automatic1111
   * Usa como contenedor base la oficial [Intel® Extension for PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu)
   * Usa una versión personalizada del [docker file](https://github.com/vladmandic/sdnext/blob/dev/configs/Dockerfile.ipex) de SD.Next, haciéndolo compatible con la imagen Intel Extension for Pytorch.

5. OpenAI Whisper
   * Reconocimiento de voz robusto mediante supervisión débil a gran escala
   * Utiliza como contenedor base la oficial [Extensión Intel® para PyTorch](https://pytorch-extension.intel.com/installation?platform=gpu)

## Configuración
Ejecute los siguientes comandos para iniciar su instancia de Ollama con Open WebUI
```bash
$ git clone https://github.com/eleiton/ollama-intel-arc.git
$ cd ollama-intel-arc
$ podman compose up
```

Además, si desea ejecutar una o más de las herramientas de generación de imágenes, ejecute estos comandos en una terminal diferente:

Para ComfyUI
```bash
$ podman compose -f docker-compose.comfyui.yml up
```

Para SD.Next
```bash
$ podman compose -f docker-compose.sdnext.yml up
```

Si desea ejecutar Whisper para el reconocimiento automático de voz, ejecute este comando en una terminal diferente:
```bash
$ podman compose -f docker-compose.whisper.yml up
```

## Validar
Ejecute el siguiente comando para verificar que su instancia de Ollama esté activa y funcionando
```bash
$ curl http://localhost:11434/
Ollama is running
```
Al usar Open WebUI, debería ver esta salida parcial en su consola, indicando que su GPU arc fue detectada
```bash
[ollama-intel-arc] | Found 1 SYCL devices:
[ollama-intel-arc] | |  |                   |                                       |       |Max    |        |Max  |Global |                     |
[ollama-intel-arc] | |  |                   |                                       |       |compute|Max work|sub  |mem    |                     |
[ollama-intel-arc] | |ID|        Device Type|                                   Name|Version|units  |group   |group|size   |       Driver version|
[ollama-intel-arc] | |--|-------------------|---------------------------------------|-------|-------|--------|-----|-------|---------------------|
[ollama-intel-arc] | | 0| [level_zero:gpu:0]|                     Intel Arc Graphics|  12.71|    128|    1024|   32| 62400M|         1.6.32224+14|
```

## Uso de la Generación de Imágenes
* Abre tu navegador web en http://localhost:7860 para acceder a la página web de SD.Next.
* Para los propósitos de esta demostración, usaremos el modelo [DreamShaper](https://civitai.com/models/4384/dreamshaper).
* Sigue estos pasos:
* Descarga el modelo `dreamshaper_8` haciendo clic en su imagen (1).
* Espera a que se descargue (~2GB de tamaño) y luego selecciónalo en el menú desplegable (2).
* (Opcional) Si quieres quedarte en la interfaz de SD.Next, siéntete libre de explorar (3).
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/sd.next.png)
* Para más información sobre el uso de SD.Next, consulta la [documentación](https://vladmandic.github.io/sdnext-docs/) oficial.
* Abre tu navegador web en http://localhost:4040 para acceder a la página web de Open WebUI.
* Ve a la página de [configuración](http://localhost:4040/admin/settings) de administrador.
* Ve a la sección de Imagen (1)
* Asegúrate de que todas las configuraciones estén correctas y valídalas presionando el botón de actualizar (2)
* (Opcional) Guarda cualquier cambio si hiciste alguno. (3)
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui-settings.png)
* Para más información sobre el uso de Open WebUI, consulta la [documentación](https://docs.openwebui.com/) oficial.
* Eso es todo, regresa a la página principal de Open WebUI y comienza a chatear. Asegúrate de seleccionar el botón `Image` para indicar que quieres generar Imágenes.
![screenshot](https://raw.githubusercontent.com/eleiton/ollama-intel-arc/main/resources/open-webui-chat.png)

## Uso del Reconocimiento Automático de Voz
* Este es un ejemplo de un comando para transcribir archivos de audio:
```bash
  podman exec -it  whisper-ipex whisper https://www.lightbulblanguages.co.uk/resources/ge-audio/hobbies-ge.mp3 --device xpu --model small --language German --task transcribe
```
* Respuesta:
```bash
  [00:00.000 --> 00:08.000]  Ich habe viele Hobbys. In meiner Freizeit mache ich sehr gerne Sport, wie zum Beispiel Wasserball oder Radfahren.
  [00:08.000 --> 00:13.000]  Außerdem lese ich gerne und lerne auch gerne Fremdsprachen.
  [00:13.000 --> 00:19.000]  Ich gehe gerne ins Kino, höre gerne Musik und treffe mich mit meinen Freunden.
  [00:19.000 --> 00:22.000]  Früher habe ich auch viel Basketball gespielt.
  [00:22.000 --> 00:26.000]  Im Frühling und im Sommer werde ich viele Radtouren machen.
  [00:26.000 --> 00:29.000]  Außerdem werde ich viel schwimmen gehen.
  [00:29.000 --> 00:33.000]  Am liebsten würde ich das natürlich im Meer machen.
```
* Este es un ejemplo de un comando para traducir archivos de audio:
```bash
  podman exec -it  whisper-ipex whisper https://www.lightbulblanguages.co.uk/resources/ge-audio/hobbies-ge.mp3 --device xpu --model small --language German --task translate
```
* Respuesta:
```bash
  [00:00.000 --> 00:02.000]  I have a lot of hobbies.
  [00:02.000 --> 00:05.000]  In my free time I like to do sports,
  [00:05.000 --> 00:08.000]  such as water ball or cycling.
  [00:08.000 --> 00:10.000]  Besides, I like to read
  [00:10.000 --> 00:13.000]  and also like to learn foreign languages.
  [00:13.000 --> 00:15.000]  I like to go to the cinema,
  [00:15.000 --> 00:16.000]  like to listen to music
  [00:16.000 --> 00:19.000]  and meet my friends.
  [00:19.000 --> 00:22.000]  I used to play a lot of basketball.
  [00:22.000 --> 00:26.000]  In spring and summer I will do a lot of cycling tours.
  [00:26.000 --> 00:29.000]  Besides, I will go swimming a lot.
  [00:29.000 --> 00:33.000]  Of course, I would prefer to do this in the sea.
```
* Para usar tus propios archivos de audio en lugar de archivos web, colócalos en la carpeta `~/whisper-files` y accede a ellos así:
```bash
  podman exec -it  whisper-ipex whisper YOUR_FILE_NAME.mp3 --device xpu --model small --task translate
```

## Actualización de los contenedores
Si hay nuevas actualizaciones en la imagen docker [ipex-llm-inference-cpp-xpu](https://hub.docker.com/r/intelanalytics/ipex-llm-inference-cpp-xpu) o en la imagen docker Open WebUI, es posible que desee actualizar sus contenedores para mantenerse al día.

Antes de cualquier actualización, asegúrese de detener sus contenedores
```bash
$ podman compose down 
```

Luego, simplemente ejecute un comando pull para recuperar las imágenes `latest`.
```bash
$ podman compose pull
```
Después de eso, puedes ejecutar compose up para iniciar tus servicios nuevamente.


```bash
$ podman compose up
```

## Conexión manual a su contenedor Ollama
Puede conectarse directamente a su contenedor Ollama ejecutando estos comandos:

```bash
$ podman exec -it ollama-intel-arc /bin/bash
$ /llm/ollama/ollama -v
```

## Mi entorno de desarrollo:
* Core Ultra 7 155H
* Intel® Arc™ Graphics (Meteor Lake-P)
* Fedora 41

## Referencias 
* [Documentación de Open WebUI](https://docs.openwebui.com/)
* [Docker - Etiquetas de Intel ipex-llm](https://hub.docker.com/r/intelanalytics/ipex-llm-serving-xpu/tags)
* [Docker - Extensión Intel para pytorch](https://hub.docker.com/r/intel/intel-extension-for-pytorch/tags)
* [GitHub - Etiquetas de Intel ipex-llm](https://github.com/intel/ipex-llm/tags)
* [GitHub - Extensión Intel para pytorch](https://github.com/intel/intel-extension-for-pytorch/tags)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---