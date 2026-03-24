<div align="center">

# UniSH: Unificando la Reconstrucción de Escena y Humano en una Pasada Feed-Forward


**Mengfei Li**<sup>1</sup>, **Peng Li**<sup>1</sup>, **Zheng Zhang**<sup>2</sup>, **Jiahao Lu**<sup>1</sup>, **Chengfeng Zhao**<sup>1</sup>, **Wei Xue**<sup>1</sup>,
<br>
**Qifeng Liu**<sup>1</sup>, **Sida Peng**<sup>3</sup>, **Wenxiao Zhang**<sup>1</sup>, **Wenhan Luo**<sup>1</sup>, **Yuan Liu**<sup>1†</sup>, **Yike Guo**<sup>1†</sup>

<sup>1</sup>HKUST, <sup>2</sup>BUPT, <sup>3</sup>ZJU

<br>

<a href="https://arxiv.org/abs/2601.01222" target="_blank"><img src="https://img.shields.io/badge/arXiv-Paper-b31b1b.svg" alt="arXiv"></a>
<a href="https://murphylmf.github.io/UniSH/" target="_blank"><img src="https://img.shields.io/badge/Project-Page-orange" alt="Project Page"></a>
<a href="https://huggingface.co/spaces/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Spaces-yellow" alt="Hugging Face Demo"></a>
<a href="https://huggingface.co/Murphyyyy/UniSH" target="_blank"><img src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue" alt="Hugging Face Model"></a>
<a href="LICENSE" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-green.svg" alt="License"></a>

</div>

---

### TL;DR
Dado un video monocular como entrada, nuestro UniSH es capaz de reconstruir conjuntamente la escena y el humano en una sola pasada feed-forward, permitiendo una estimación efectiva de la geometría de la escena, parámetros de la cámara y parámetros SMPL.


<video src="static/teaser_video_final.mp4" autoplay loop muted playsinline width="100%"></video>

<img src="https://raw.githubusercontent.com/murphylmf/UniSH/main/static/teaser.svg" width="100%" style="background-color: white;">

## 🛠️ Instalación

Proporcionamos un método de instalación **sin sudo** que funciona en la mayoría de servidores Linux (incluidos los sin interfaz gráfica).

### Paso 1: Clonar el Repositorio

```bash
git clone https://github.com/murphylmf/UniSH.git
cd UniSH
```

### Paso 2: Crear entorno Conda
Esto instala Python, compiladores del sistema y controladores OpenGL.

```bash
conda env create -f environment.yml
conda activate unish
```

### Paso 3: Compilar Dependencias
Este script compila PyTorch3D, MMCV y SAM2 desde el código fuente utilizando los compiladores instalados en el Paso 2.

El entorno ha sido probado en **CUDA 12.1** y **CUDA 11.8**. Puede especificar la versión de CUDA pasándola como argumento al script de instalación.

```bash
# Default (Auto-detect or 12.1)
bash install.sh

# For CUDA 11.8
bash install.sh 11.8

# For CUDA 12.1
bash install.sh 12.1
```

### Paso 4: Descargar modelos SMPL
Por favor, descargue los modelos [SMPL](https://smpl.is.tue.mpg.de/) y colóquelos en la carpeta `body_models`.
La estructura del directorio debe estar organizada de la siguiente manera:

```text
UniSH/
├── body_models/
│   └── smpl/
│       └── smpl/
│           ├── SMPL_FEMALE.pkl
│           ├── SMPL_MALE.pkl
│           └── SMPL_NEUTRAL.pkl
```

## 🚀 Inicio Rápido (Inferencia)

### Ejecutar Inferencia
Ejecute el siguiente comando para reconstruir la escena y el humano a partir del video:

```bash
python inference.py --output_dir inference_results/example --video_path examples/example_video.mp4 
```

Por favor, consulte `inference.py` para obtener más información sobre parámetros adicionales.

## 📝 Cita

Si encuentra este código útil para su investigación, por favor considere citar nuestro artículo:

```bibtex
@misc{li2026unishunifyingscenehuman,
      title={UniSH: Unifying Scene and Human Reconstruction in a Feed-Forward Pass}, 
      author={Mengfei Li and Peng Li and Zheng Zhang and Jiahao Lu and Chengfeng Zhao and Wei Xue and Qifeng Liu and Sida Peng and Wenxiao Zhang and Wenhan Luo and Yuan Liu and Yike Guo},
      year={2026},
      eprint={2601.01222},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2601.01222}, 
}
```

## 🙏 Agradecimientos

Reconocemos las excelentes contribuciones de los siguientes proyectos:

* [GVHMR](https://github.com/zju3dv/GVHMR)
* [BEDLAM](https://bedlam.is.tue.mpg.de/)
* [SMPL](https://smpl.is.tue.mpg.de/)
* [VGGT](https://github.com/facebookresearch/vggt)
* [Pi3](https://github.com/yyfz/Pi3)
* [MoGe2](https://github.com/microsoft/moge)

## 📄 Licencia
Este proyecto está licenciado bajo la Licencia Apache 2.0. Consulte [LICENSE](LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---