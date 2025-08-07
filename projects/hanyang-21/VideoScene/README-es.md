<p align="center">
  <h1 align="center">VideoScene: Destilando un Modelo de Difusión de Video para Generar Escenas 3D en un Solo Paso</h1>
  <p align="center">
    <a href="https://hanyang-21.github.io/">Hanyang Wang</a><sup>*</sup>,
    <a href="https://liuff19.github.io/">Fangfu Liu</a><sup>*</sup>,
    <a href="https://github.com/hanyang-21/VideoScene">Jiawei Chi</a>,
    <a href="https://duanyueqi.github.io/">Yueqi Duan</a>
    <br>
    <sup>*</sup>Contribución Igual.
    <br>
    Universidad de Tsinghua
  </p>
  <h3 align="center">Destacado CVPR 2025 🔥</h3>
  <h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2403.20309-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2504.01956) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://hanyang-21.github.io/VideoScene)
<a><img src='https://img.shields.io/badge/License-MIT-blue'></a>
<a href='https://mp.weixin.qq.com/s/u6OUo5mHKPG6I3yYJPMC8Q'><img src='https://img.shields.io/badge/%E5%BE%AE%E4%BF%A1-%E4%B8%AD%E6%96%87%E4%BB%8B%E7%BB%8D-green'></a>

</h5>
  <!-- <h3 align="center"><a href="https://arxiv.org/abs/">Paper</a> | <a href="">Project Page</a> | <a href="">Pretrained Models</a> </h3> -->
<!--   <div align="center">
    <a href="https://news.ycombinator.com/item?id=41222655">
      <img
        alt="Featured on Hacker News"
        src="https://hackerbadge.vercel.app/api?id=41222655&type=dark"
      />
    </a>
  </div> -->

</p>

<div align="center">
VideoScene es un modelo de difusión de video en un solo paso que cierra la brecha del video al 3D.
</div>
</br>


https://github.com/user-attachments/assets/dca733b1-b78f-49ac-ae47-5d1b1e8a689b

Basado en [ReconX](https://github.com/liuff19/ReconX), VideoScene ha logrado un avance en versión turbo.



## Instalación

Para comenzar, clona este proyecto, crea un entorno virtual conda usando Python 3.10+ e instala los requisitos:

1. Clona VideoScene.
```bash
git clone https://github.com/hanyang-21/VideoScene
cd VideoScene
```
2. Crea el entorno, aquí mostramos un ejemplo usando conda.

```bash
conda create -y -n videoscene python=3.10
conda activate videoscene
pip install torch==2.1.2 torchvision==0.16.2 torchaudio==2.1.2 --index-url https://download.pytorch.org/whl/cu118
pip install -r requirements.txt
```

3. Opcional, compilar los kernels de cuda para RoPE (como en CroCo v2).
```bash
# NoPoSplat relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd src/model/encoder/backbone/croco/curope/
python setup.py build_ext --inplace
cd ../../../../../..
```

## Adquisición de Conjuntos de Datos

### RealEstate10K y ACID

Nuestro VideoScene usa los mismos conjuntos de datos de entrenamiento que pixelSplat. A continuación citamos las [instrucciones detalladas](https://github.com/dcharatan/pixelsplat?tab=readme-ov-file#acquiring-datasets) de pixelSplat para obtener conjuntos de datos.

> pixelSplat fue entrenado usando versiones de los conjuntos de datos RealEstate10k y ACID que fueron divididos en fragmentos de ~100 MB para su uso en sistemas de archivos de clústeres de servidores. Pequeños subconjuntos de los conjuntos de datos Real Estate 10k y ACID en este formato pueden encontrarse [aquí](https://drive.google.com/drive/folders/1joiezNCyQK2BvWMnfwHJpm2V77c7iYGe?usp=sharing). Para usarlos, simplemente descomprímelos en una carpeta `datasets` recién creada en el directorio raíz del proyecto.

> Si quieres convertir versiones descargadas de los conjuntos de datos Real Estate 10k y ACID a nuestro formato, puedes usar los [scripts aquí](https://github.com/dcharatan/real_estate_10k_tools). Contáctanos (pixelSplat) si deseas las versiones completas de nuestros conjuntos de datos procesados, que son aproximadamente 500 GB y 160 GB para Real Estate 10k y ACID respectivamente.

## Descarga de puntos de control

* descarga nuestros [pesos preentrenados](https://wisemodel.cn/models/hanyang/VideoScene/file) (`VideoScene/checkpoints/model.safetensors` y `VideoScene/checkpoints/prompt_embeds.pt`), y guárdalos en `checkpoints`.

* para entradas de imagen personalizadas, obtén los modelos preentrenados NoPoSplat [aquí](https://huggingface.co/botaoye/NoPoSplat/resolve/main/mixRe10kDl3dv_512x512.ckpt), y guárdalos en `checkpoints/noposplat`.

* para los conjuntos de datos RealEstate10K, obtén los modelos preentrenados MVSplat [aquí](https://drive.google.com/drive/folders/14_E_5R6ojOWnLSrSVLVEMHnTiKsfddjU), y guárdalos en `checkpoints/mvsplat`.

## Ejecución del Código

### Demo Gradio
En esta demo, puedes ejecutar VideoScene en tu máquina para generar un video con vistas de entrada no posadas.

* selecciona pares de imágenes que representen la misma escena y pulsa "RUN" para obtener un video de la escena.


```bash
python -m noposplat.src.app \
    checkpointing.load=checkpoints/noposplat/mixRe10kDl3dv_512x512.ckpt \
    test.video=checkpoints/model.safetensors

# also "bash demo.sh"
```
* el video generado se almacenará en `outputs/gradio`

### Inferencia

Para generar videos en los conjuntos de datos RealEstate10K, usamos un modelo preentrenado [MVSplat](https://github.com/donydchen/mvsplat),

* ejecute lo siguiente:

```bash
# re10k
python -m mvsplat.src.main +experiment=re10k \
checkpointing.load=checkpoints/mvsplat/re10k.ckpt \
mode=test \
dataset/view_sampler=evaluation \
dataset.view_sampler.index_path=mvsplat/assets/evaluation_index_re10k_video.json \
test.save_video=true \
test.save_image=false \
test.compute_scores=false \
test.video=checkpoints/model.safetensors

# also "bash inference.sh"
```

* el video generado se almacenará en `outputs/test`


## BibTeX

```bibtex
@misc{wang2025videoscenedistillingvideodiffusion,
      title={VideoScene: Distilling Video Diffusion Model to Generate 3D Scenes in One Step}, 
      author={Hanyang Wang and Fangfu Liu and Jiawei Chi and Yueqi Duan},
      year={2025},
      eprint={2504.01956},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2504.01956}, 
}
```

## Agradecimientos

Este proyecto se desarrolla con varios repositorios fantásticos: [ReconX](https://github.com/liuff19/ReconX), [MVSplat](https://github.com/donydchen/mvsplat), [NoPoSplat](https://github.com/cvg/NoPoSplat), [CogVideo](https://github.com/THUDM/CogVideo), y [CogvideX-Interpolation](https://github.com/feizc/CogvideX-Interpolation). ¡Muchas gracias a estos proyectos por sus excelentes contribuciones!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---