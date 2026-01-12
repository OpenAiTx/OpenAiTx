# GOT-OCR-2-GUI

## [Ver versión en inglés aquí](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/README-en.md)

🛑 Soporte detenido, actualizaciones futuras serán esporádicas

![img.png](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/img.png)

## Sobre este proyecto

Pesos del modelo: [Sitio espejo](https://hf-mirror.com/stepfun-ai/GOT-OCR2_0), [Sitio original](https://huggingface.co/stepfun-ai/GOT-OCR2_0)  
GitHub original: [GOT-OCR2.0](https://github.com/Ucas-HaoranWei/GOT-OCR2.0/)   
Este proyecto fue desarrollado en Windows, personalmente no he usado ni manejo Linux, no puedo garantizar que funcione correctamente en Linux, si deseas desplegarlo en Linux  
puedes consultar este [issue](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/3)  
Parte del código proviene de: [ GLM4 ](https://chatglm.cn/main/alltoolsdetail?lang=zh), [Deepseek](https://www.deepseek.com/)

Por favor, regálanos una estrella

## Pendientes

- [x] Localización del contenido del registro
- [ ] Soporte para nuevo modelo stepfun-ai/GOT-OCR-2.0-hf
- [ ] Optimizar la lógica de manejo de errores relacionados con PDF
- [x] Soporte para modelos GGUF, con la esperanza de acelerar la inferencia (gracias a la ayuda del [issue #19](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/19))
- [ ] Mejorar el soporte para modelos GGUF
- [x] Nuevo modo de renderizado: optimizar rendimiento, soportar más formatos de salida
- [ ] Eliminar/ocultar el renderizador antiguo

## Cómo usar

Si no tienes las carpetas mencionadas aquí, **crea una nueva**

### Elige una rama

#### Alpha

La rama con actualizaciones más rápidas, los cambios más recientes se suben aquí.  
El código a veces no está probado.  
Muy inestable, a veces ni siquiera funciona.

#### main

Una rama relativamente estable, pero puede carecer de algunas características nuevas.

### Dependencias

Este entorno ha sido probado para funcionar correctamente bajo **python 3.11.9**

#### torch

Desde la [página oficial de torch](https://pytorch.org/get-started/locally/) selecciona la versión de **GPU** adecuada para ti e instala torch  
Anteriormente usaba Stable 2.4.1 + cu124  
Actualmente uso Stable 2.0.1 + cu118, lo que puede resolver `1 Torch is not compiled with Flash Attention`, sin haber encontrado otros problemas

#### PyMuPDF

En pruebas, si se instala directamente desde `requirements.txt` da el error `ModuleNotFoundError: No module named 'frontend'`  
pero si se instala por separado no ocurre, la razón exacta no está clara  
Además, si aún aparece `ModuleNotFoundError`, primero desinstala `fitz` y `PyMuPDF`, luego reinstálalos; en pruebas, `pip install -U PyMuPDF`  
no funciona para resolverlo

```commandline
pip install fitz
pip install PyMuPDF
```
#### Instalación usando `pip`


```commandline
pip install -r requirements.txt
```
Además, alguien mencionó que tuvo problemas de conflicto al instalar dependencias usando `requirements.txt`, pero aquí no he encontrado ningún problema,  
`pipdeptree` tampoco muestra ningún conflicto, el `requirements.txt` es directamente de mi entorno virtual con `pip freeze`, por lo que en teoría no debería haber problema.  
Pero dado que efectivamente surgió este problema, aquí proporciono un `requirements-noversion.txt` sin números de versión, puedes probarlo:  
Para más información, consulta este [issue #4](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/4)  


```commandline
pip install -r requirements-noversion.txt
```
#### Otros

- [Edge WebDriver](https://developer.microsoft.com/zh-cn/microsoft-edge/tools/webdriver/?form=MA13LH#downloads)
  , descarga el paquete comprimido y colócalo en la carpeta `edge_driver`

> ¿No debería tener todo el mundo Edge en sus computadoras? ¿Verdad? Esto viene preinstalado...  
> La estructura de archivos debería ser:
> ```
> GOT-OCR-2-GUI
> └─edge_driver
>    ├─msedgedriver.exe
>    └─...
> ```

### Descargar archivos de modelo

Con cualquiera de los modelos listados a continuación se puede ejecutar OCR, pero para activar la carga automática de modelos, es necesario tener el modelo `Safetensors`  
El soporte para modelos GGUF aún no está completo, por ahora puedes probarlo en la pestaña GGUF de forma independiente

#### Safetensors

1. Descarga a la carpeta `models`  
2. No olvides descargar todos los archivos  
3. Si es un nuevo modelo `GOT-OCR-2-HF` (actualmente no soportado), descárgalo a la carpeta `models-hf` (aunque aún no se ha añadido soporte para este)

- La estructura de archivos debería ser:


```
GOT-OCR-2-GUI
└─models
   ├─config.json
   ├─generation_config.json
   ├─got_vision_b.py
   ├─model.safetensors
   ├─modeling_GOT.py
   ├─qwen.tiktoken
   ├─render_tools.py
   ├─special_tokens_map.json
   ├─tokenization_qwen.py
   └─tokenizer_config.json
```
#### GGUF

El modelo GGUF es compatible con `got.cpp`  
Descarga el modelo desde el repositorio `MosRat/got.cpp`, coloca `Encode.onnx` en `gguf\Encoder.onnx` y el resto de los modelos Decoder GGUF en `gguf\decoders`

### Comenzar

1. Si quieres usar la línea de comandos, usa `CLI.py`  
2. Si prefieres la interfaz gráfica, usa `GUI.py`  
3. Si quieres modificar la configuración, usa `Config Manager.py`  
4. Si deseas ejecutar operaciones automatizadas de renderizado, usa `Renderer.py`, que renderizará automáticamente todas las imágenes `.jpg` y `.png` en la carpeta `imgs`

> Los usuarios de la GUI pueden ignorar esto, pero los que usen la CLI deben poner las imágenes para OCR en la carpeta `imgs` (la CLI actualmente solo detecta imágenes `.jpg` y `.png`)

## Soporte de localización

- Puedes encontrar archivos `.json` de varios idiomas en la carpeta `Locales`; los archivos de idioma para CLI y GUI se almacenan por separado  
- Dentro de la subcarpeta `gui`, además del archivo `idioma.json`, hay una carpeta `instructions` que contiene tutoriales integrados para la GUI nombrados como `idioma.md`  
- Para cambiar el soporte de idioma, solo edita el valor `'language'` en `config.json`; las opciones disponibles corresponden a los nombres de archivo sin extensión de los archivos `idioma.json`  
- Para agregar soporte de idiomas, en la CLI solo necesitas añadir un nuevo archivo `idioma.json` (recomiendo usar un archivo existente como base), en la GUI también necesitas el archivo complementario `idioma.md`  
- Puedes usar `Config Manager.py` para gestionar idiomas y otros archivos de configuración

## Precauciones

- Si el script se cierra inesperadamente, intenta ejecutarlo con `cmd` usando `python +nombre_del_archivo`; a mí me ha ocurrido el cierre inesperado y no sé por qué  
- No borres `markdown-it.js` en la carpeta `result`, ¡de lo contrario la exportación a PDF fallará!

> Si accidentalmente lo borras, puedes encontrar una copia de seguridad en la carpeta `scripts`, solo cópiala de nuevo

- Asegúrate de tener instalada la versión GPU de `torch`, porque el script usa `device_map='cuda'`

## Preguntas frecuentes

- P: CLI.py: error: the following arguments are required: --path/-P  
- R: Usa PowerShell; en CMD aparece este bug y aún no se ha encontrado la causa  
---  
- P: ¿Qué es un “archivo HTML local”? ¿Acaso hay archivos HTML que no estén guardados localmente?  
- R: Aunque el archivo HTML generado por el modelo se guarda localmente, usa scripts externos, por lo que aún necesita conexión a internet para abrirlo. Por eso descargué los scripts externos, como se mencionó antes


  `mardown-it.js`. Esto se hace principalmente para evitar fallos en la exportación a PDF debido a problemas de red.
---
- P: ¿Por qué falla la carga de mi modelo?
- R: Revisa si te falta algún archivo. Los archivos del modelo descargados desde Baidu Cloud parecen estar incompletos, te recomiendo descargarlos desde Huggingface como se mencionó antes.
---
- P: ¿Tienes alguna recomendación para desplegar este proyecto?
- R: Consulta este [issue #5](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/5)
---
- P: ¿Dónde puedo encontrar la documentación de ayuda?
- R: Para usuarios GUI, puedes encontrarla en la pestaña `说明`. Para usuarios CLI, puedes usar `.\CLI.py --help` para ver la ayuda generada automáticamente por argparse, o `.\CLI.py --detailed-help` para una ayuda más detallada.

## Historial de Estrellas

[![Gráfico de Historial de Estrellas](https://api.star-history.com/svg?repos=XJF2332/GOT-OCR-2-GUI&type=Date)](https://star-history.com/#XJF2332/GOT-OCR-2-GUI&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---