
<h2 align="center"> <a href="https://arxiv.org/abs/2412.09606">Feat2GS: Explorando modelos visuales fundamentales con Gaussian Splatting</a>
</h2>

<h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2412.09606-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2412.09606) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://fanegg.github.io/Feat2GS/)  [![youtube](https://img.shields.io/badge/Video-E33122?logo=Youtube)](https://youtu.be/4fT5lzcAJqo?si=_fCSIuXNBSmov2VA)  [![Gradio](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Demo-orange)](https://huggingface.co/spaces/endless-ai/Feat2GS)  [![X](https://img.shields.io/badge/@Yue%20Chen-black?logo=X)](https://twitter.com/faneggchen)  [![Bluesky](https://img.shields.io/badge/@Yue%20Chen-white?logo=Bluesky)](https://bsky.app/profile/fanegg.bsky.social)

[Yue Chen](https://fanegg.github.io/),
[Xingyu Chen](https://rover-xingyu.github.io/),
[Anpei Chen](https://apchenstu.github.io/),
[Gerard Pons-Moll](https://virtualhumans.mpi-inf.mpg.de/),
[Yuliang Xiu](https://xiuyuliang.cn/)
</h5>

<div align="center">
Este repositorio es la implementación oficial de Feat2GS, un marco unificado para explorar la "conciencia de textura y geometría" de los modelos visuales fundamentales. La síntesis de vistas novedosas sirve como un proxy efectivo para la evaluación 3D.
</div>
<br>

https://github.com/user-attachments/assets/07ebb8e1-6001-47bf-bf74-984b0032cc17


## Actualizaciones

- [10 de julio de 2025] Añadida una nueva evaluación de las características del codificador y decodificador VGGT. Ver los resultados [aquí](https://raw.githubusercontent.com/fanegg/Feat2GS/main/assets/Feat2GS_Benchmark.pdf).

## Comenzar

### Instalación
1. Clonar Feat2GS y descargar el modelo preentrenado desde [DUSt3R](https://github.com/naver/dust3r)/[MASt3R](https://github.com/naver/mast3r).
```bash
git clone https://github.com/fanegg/Feat2GS.git
cd Feat2GS/submodules/mast3r/
mkdir -p checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/DUSt3R/DUSt3R_ViTLarge_BaseDecoder_512_dpt.pth -P checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/MASt3R/MASt3R_ViTLarge_BaseDecoder_512_catmlpdpt_metric.pth -P checkpoints/
cd ../../
```
2. Crear el entorno, aquí mostramos un ejemplo usando conda.

```bash
conda create -n feat2gs python=3.11 cmake=3.14.0
conda activate feat2gs
pip install "torch==2.5.1" "torchvision==0.20.1" "numpy<2" --index-url https://download.pytorch.org/whl/cu121  # use the correct version of cuda for your system
cd Feat2GS/
pip install -r requirements.txt
pip install submodules/simple-knn
```
3. Opcional pero altamente recomendado, compilar los kernels de cuda para RoPE (como en CroCo v2).

```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd submodules/mast3r/dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../../../
```

4. (Opcional) siga [esta instrucción](https://github.com/cvlab-columbia/zero123?tab=readme-ov-file#novel-view-synthesis-1) para instalar los requisitos para probar [Zero123](https://github.com/cvlab-columbia/zero123).

### Uso
1. Preparación de datos (Proporcionamos nuestros conjuntos de datos de evaluación e inferencia: [enlace](https://drive.google.com/file/d/1PLTFcvJfiPucrB-pIwfp5QG-AIHcJdjN/view?usp=drive_link))
```bash
  cd <data_root>/Feat2GS/
```

> Si desea construir conjuntos de datos personalizados, por favor siga y edite:
> ```
> build_dataset/0_create_json.py ## crear dataset_split.json para dividir el conjunto de entrenamiento/prueba
> build_dataset/1_create_feat2gs_dataset.py ## usar dataset_split.json para crear el conjunto de datos
> ```


2. Evaluar Modelos Fundamentales Visuales:

  | Paso | Descripción (enlace al comando) |
  |------|-------------|
  | (1)  | [Inicialización DUSt3R y extracción de características](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L245-L250) |
  | (2)  | [Lectura 3DGS de características y optimización conjunta de la pose](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L253-L262) |
  | (3)  | [Inicialización de pose de prueba](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L265-L270) |
  | (4)  | [Renderizar vista de prueba para evaluación](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L273-L282) |
  | (5)  | [Métrica](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L298-L301) |
  | (Opcional)  | [Renderizar video con trayectoria generada](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L304-L315) |

```bash
  # Run evaluation for all datasets, all VFM features, all probing modes
  bash scripts/run_feat2gs_eval_parallel.sh

  # (Example) Run evaluation for a single scene, DINO feature, Geometry mode
  bash scripts/run_feat2gs_eval.sh
```
> [!NOTA]
> Para ejecutar experimentos en paralelo, añadimos una función de **bloqueo de GPU** para asegurar que solo se ejecute un experimento de evaluación por GPU. Una vez que un experimento termina, la GPU se desbloquea automáticamente. **Si se interrumpe con `Ctrl+C`, la GPU no se desbloqueará automáticamente.** Para solucionar esto, elimine manualmente los archivos `.lock` en su `LOCK_DIR`. Para desactivar esta función, comente estas líneas en el script:
    [L4-L5](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L4-L5),
    [L9-L22](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L9-L22),
    [L223-L233](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L223-L233),
    [L330-L331](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L330-L331).

  | Configuración | Operación |
  |--------------|------------------|
  | GPU | Editar en [`<AVAILABLE_GPUS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L7) |
  | Dataset | Editar en [`<SCENES[$Dataset]>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L105-L111) |
  | Escena | Editar en [`<SCENES_$Dataset>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L31-L99) |
  | Modelo de Fundación Visual | Editar en [`<FEATURES>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L120-L162) |
  | Modo de Sondeo | Editar en [`<MODELS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L181-L188) |
  | Modo Solo Inferencia | Comentar STEP (3)(4)(5) en [`execute_command`](https://github.com/fanegg/Feat2GS/blob/main/scripts/run_feat2gs_eval_parallel.sh#L325-L327) |

```bash
  # Evaluate Visual Foundation Models on DTU dataset
  bash scripts/run_feat2gs_eval_dtu_parallel.sh

  # Run InstantSplat for evaluation
  bash scripts/run_instantsplat_eval_parallel.sh
```
3. Después del entrenamiento, renderice video RGB/profundidad/normal con la trayectoria generada.


```bash
  # If render depth/normal, set RENDER_DEPTH_NORMAL=true
  # Set type of generated trjectory by editing <TRAJ_SCENES>
  bash scripts/run_video_render.sh

  # Render video on DTU dataset
  bash scripts/run_video_render_dtu.sh
```
### 🎮 Demostración interactiva

#### 🚀 Inicio rápido
1. **Imágenes de entrada**
* Sube 2 o más imágenes de la misma escena desde diferentes vistas
* Para mejores resultados, asegúrate de que las imágenes tengan buena superposición

2. **Paso 1: Inicialización de DUSt3R y extracción de características**
* Haz clic en "EJECUTAR Paso 1" para procesar tus imágenes
* Este paso estima la nube de puntos inicial de DUSt3R y las posiciones de la cámara, y extrae características DUSt3R para cada píxel

3. **Paso 2: Lectura 3DGS desde características**
* Establece el número de iteraciones de entrenamiento, un número mayor conduce a mejor calidad pero mayor tiempo (por defecto: 2000, máximo: 8000) 
* Haz clic en "EJECUTAR Paso 2" para optimizar el modelo 3D

4. **Paso 3: Renderizado de video**
* Elige una trayectoria de cámara
* Haz clic en "EJECUTAR Paso 3" para generar un video de tu modelo 3D

```bash
gradio demo.py
```

#### 💡 Consejos
* El tiempo de procesamiento depende de la resolución y cantidad de imágenes
* Para un rendimiento óptimo, pruebe en GPUs de alta gama (A100/4090)
* Use el ratón para interactuar con modelos 3D:
  - Botón izquierdo: Rotar
  - Rueda de desplazamiento: Zoom
  - Botón derecho: Desplazar


## Agradecimientos

Este trabajo está basado en muchos trabajos de investigación y proyectos de código abierto increíbles, ¡muchas gracias a todos los autores por compartir!

- [Gaussian-Splatting](https://github.com/graphdeco-inria/gaussian-splatting) y [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [gsplat](https://github.com/nerfstudio-project/gsplat)
- [DUSt3R](https://github.com/naver/dust3r) y [MASt3R](https://github.com/naver/mast3r)
- [InstantSplat](https://github.com/NVlabs/InstantSplat)
- [Probe3D](https://github.com/mbanani/probe3d)
- [FeatUp](https://github.com/mhamilton723/FeatUp)
- [Shape of Motion](https://github.com/vye16/shape-of-motion/)
- [Splatt3R](https://github.com/btsmart/splatt3r)
- [VGGT](https://github.com/facebookresearch/vggt)

## Citación
Si encuentra nuestro trabajo útil para su investigación, por favor considere dar una estrella :star: y citar el siguiente artículo :pencil:.

```bibTeX
@inproceedings{chen2025feat2gs,
  title={Feat2gs: Probing visual foundation models with gaussian splatting},
  author={Chen, Yue and Chen, Xingyu and Chen, Anpei and Pons-Moll, Gerard and Xiu, Yuliang},
  booktitle={Proceedings of the Computer Vision and Pattern Recognition Conference},
  pages={6348--6361},
  year={2025}
}
```

## Contacto

Para comentarios, preguntas o consultas de prensa, por favor contacte a [Yue Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:faneggchen@gmail.com) y [Xingyu Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:roverxingyu@gmail.com).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-10

---