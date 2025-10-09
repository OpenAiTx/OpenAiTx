<div align="center">
<img src=assets/yume.png width="20%"/>
</div>

# Yume: Un Modelo de Generación de Mundos Interactivo

Yume es un proyecto a largo plazo que tiene como objetivo crear un mundo interactivo, realista y dinámico mediante la entrada de texto, imágenes o videos.


<div align="center">




[![project page](https://img.shields.io/badge/Project-Page-2ea44f)](https://stdstu12.github.io/YUME-Project/)&nbsp;
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2507.17744-b31b1b.svg)](https://arxiv.org/abs/2507.17744)&nbsp;
[![model](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue)](https://huggingface.co/stdstu123/Yume-I2V-540P)&nbsp;
[![YouTube](https://badges.aleen42.com/src/youtube.svg)](https://www.youtube.com/watch?v=51VII_iJ1EM)&nbsp;

</div>

- Recetas de destilación para video DiT.
- Código de entrenamiento tipo [FramePack-Like](https://github.com/lllyasviel/FramePack).
- Método de generación de video largo con soporte para muestreo DDP/FSDP.



## 🔧 Instalación
El código ha sido probado en Python 3.10.0, CUDA 12.1 y A100.
```
./env_setup.sh fastvideo
pip install -r requirements.txt
```
Necesita ejecutar `pip install .` después de cada modificación del código, o alternativamente, puede copiar los archivos modificados directamente en su entorno virtual. Por ejemplo, si modifiqué `wan/image2video.py` y mi entorno virtual es `yume`, puedo copiar el archivo a:  
`envs/yume/lib/python3.10/site-packages/wan/image2video.py`.

## 🚀 Inferencia

### EDO  
Para la generación de imágenes a video, usamos `--jpg_dir="./jpg"` para especificar el directorio de imágenes de entrada y `--caption_path="./caption.txt"` para proporcionar entradas de condicionamiento de texto, donde cada línea corresponde a una instancia de generación que controla una salida de video de 2 segundos.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_jpg.sh 
```
También consideramos generar videos utilizando los datos de `./val`, donde `--test_data_dir="./val"` especifica la ubicación de los datos de ejemplo.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample.sh 
```
### SDE
Realizamos muestreo TTS, donde `args.sde` controla si se utiliza el muestreo basado en SDE.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_tts.sh 
```
Para obtener resultados óptimos, recomendamos mantener la distancia real, la tasa de cambio angular (velocidad de giro) y la velocidad de rotación de la vista dentro del rango de 0.1 a 10.

Pautas clave de ajuste:
1. Al ejecutar Cámara permanece quieta (·), reduzca el valor de distancia real
2. Al ejecutar Persona permanece quieta, disminuya tanto la tasa de cambio angular como los valores de velocidad de rotación de la vista

Tenga en cuenta que estos parámetros (distancia real, tasa de cambio angular y velocidad de rotación de la vista) sí afectan los resultados de la generación. Como enfoque alternativo, puede considerar eliminar estos parámetros por completo para una operación simplificada.

## 🎯 Entrenamiento y destilación
Para el entrenamiento del modelo, usamos `args.MVDT` para lanzar el marco MVDT, que requiere al menos 16 GPUs A100. Cargar T5 en la CPU puede ayudar a conservar la memoria de la GPU. Empleamos `args.Distil` para habilitar la destilación adversarial.



```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/finetune/finetune.sh
```

## 🧱 Preparación del Conjunto de Datos
Por favor, consulte https://github.com/Lixsp11/sekai-codebase para descargar el conjunto de datos. Para el formato de datos procesados, consulte `./test_video`.
```
path_to_processed_dataset_folder/
├── Keys_None_Mouse_Down/ 
│   ├── video_id.mp4
│   ├── video_id.txt
├── Keys_None_Mouse_Up
│──  ...
└── Keys_S_Mouse_·
```
El contenido proporcionado en el archivo TXT registra ya sea parámetros de control de movimiento de cámara o datos de fotogramas clave de animación, con las siguientes definiciones de campos:
```
Start Frame: 2 #Starting frame number (begins at frame 2 at origin video)

End Frame: 50 #Ending frame number

Duration: 49 frames #Total duration

Keys: W #Keyboard input

Mouse: ↓ #Mouse action
```
En `scripts/finetune/finetune.sh`, `args.root_dir` representa la `ruta_a_la_carpeta_del_dataset_procesado`, y `args.root_dir` representa la ruta completa al dataset Sekai.


## 📑 Plan de Desarrollo
- Procesamiento del dataset
  - [ ] Proveer datasets procesados
- Actualización de código
  - [ ] Soporte fp8
  - [ ] Mejores métodos de destilación
- Actualización del modelo
  - [ ] Modelos cuantizados y destilados
  - [ ] Modelos para generación en resolución 720p​

## 🤝 Contribuciones
Damos la bienvenida a todas las contribuciones.


## Agradecimientos
Aprendimos y reutilizamos código de los siguientes proyectos:
- [FastVideo](https://github.com/hao-ai-lab/FastVideo)
- [diffusers](https://github.com/huggingface/diffusers)
- [HunyuanVideo-I2V](https://github.com/Tencent-Hunyuan/HunyuanVideo-I2V)
- [Wan2.1](https://github.com/Wan-Video/Wan2.1)
- [Skywork-Reward-V2](https://github.com/SkyworkAI/Skywork-Reward-V2)
- [MDT](https://github.com/sail-sg/MDT)
- [AddSR](https://github.com/NJU-PCALab/AddSR)

## Citación
Si utiliza Yume para su investigación, por favor cite nuestro artículo:

```bibtex
@article{mao2025yume,
  title={Yume: An Interactive World Generation Model},
  author={Mao, Xiaofeng and Lin, Shaoheng and Li, Zhen and Li, Chuanhao and Peng, Wenshuo and He, Tong and Pang, Jiangmiao and Chi, Mingmin and Qiao, Yu and Zhang, Kaipeng},
  journal={arXiv preprint arXiv:2507.17744},
  year={2025}
}

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-09

---