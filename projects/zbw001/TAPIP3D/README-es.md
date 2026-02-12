<div align="center">

# TAPIP3D: Seguimiento de Cualquier Punto en Geometría 3D Persistente
<a href="https://arxiv.org/abs/2504.14717"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://tapip3d.github.io'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>

[Bowei Zhang](https://scholar.google.com/citations?user=tYH72AYAAAAJ)<sup>1,2</sup>*, [Lei Ke](https://www.kelei.site/)<sup>1</sup>\*, [Adam W. Harley](https://adamharley.com/)<sup>3</sup>, [Katerina Fragkiadaki](https://www.cs.cmu.edu/~katef/)<sup>1</sup>

<sup>1</sup>Universidad Carnegie Mellon   &nbsp;  <sup>2</sup>Universidad de Pekín &nbsp;  <sup>3</sup>Universidad de Stanford

**NeurIPS 2025**

\* Contribución Igual

<!-- <a href='https://huggingface.co/spaces/your-username/project'><img src='https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Live_Demo-blue'></a> -->

</div>

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/teaser1.gif" width="100%" alt="Resumen TAPIP3D">


---

### 🚀 Noticias
- **(2025.12.28)** 🔥 ¡Hemos actualizado el código de **Entrenamiento** y **Evaluación**! Consulta las nuevas secciones a continuación.

## Resumen
**TAPIP3D** es un método para el seguimiento **feed-forward** a largo plazo de puntos 3D en secuencias monoculares de video RGB y RGB-D. Introduce una representación de nube de características 3D que eleva las características de la imagen a un espacio de coordenadas del mundo persistente, cancelando el movimiento de la cámara y permitiendo una estimación precisa de la trayectoria a través de los fotogramas.

Proporcionamos una [ilustración en video](https://neurips.cc/virtual/2025/loc/san-diego/poster/117634#:~:text=Within%20this%20stabilized%203D%20representation,trained%20checkpoints%20will%20be%20public.) detallada de nuestro TAPIP3D.

## Instalación
### Instalación de dependencias

1. Preparar el entorno
```bash
conda create -n tapip3d python=3.10
conda activate tapip3d

pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 "xformers>=0.0.27" --index-url https://download.pytorch.org/whl/cu124
pip install torch-scatter -f https://data.pyg.org/whl/torch-2.4.1+cu124.html
pip install -r requirements.txt
```

2. Compilar pointops2

```bash
cd third_party/pointops2
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../..
```

3. Compilar megasam
```bash
cd third_party/megasam/base
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../../..
```
### Descarga de puntos de control

Descargue nuestro punto de control del modelo TAPIP3D [aquí](https://huggingface.co/zbww/tapip3d/resolve/main/tapip3d_final.pth) en `checkpoints/tapip3d_final.pth`

Si desea ejecutar TAPIP3D en vídeos monoculares, debe preparar manualmente los siguientes puntos de control para ejecutar MegaSAM:

1. Descargue el punto de control DepthAnything V1 desde [aquí](https://huggingface.co/spaces/LiheYoung/Depth-Anything/resolve/main/checkpoints/depth_anything_vitl14.pth) y colóquelo en `third_party/megasam/Depth-Anything/checkpoints/depth_anything_vitl14.pth`

2. Descargue el punto de control RAFT desde [aquí](https://drive.google.com/drive/folders/1sWDsfuZ3Up38EUQt7-JDTT1HcGHuJgvT) y colóquelo en `third_party/megasam/cvd_opt/raft-things.pth`

Además, los puntos de control de [MoGe](https://wangrc.site/MoGePage/) y [UniDepth](https://github.com/lpiccinelli-eth/UniDepth.git) se descargarán automáticamente al ejecutar la demo. Por favor, asegúrese de que su conexión de red esté disponible.

## Uso de la Demo

Proporcionamos un script de demo simple `inference.py`, junto con datos de entrada de muestra ubicados en el directorio `demo_inputs/`.

El script acepta como entrada un archivo de vídeo `.mp4` o un archivo `.npz`. Si proporciona un archivo `.npz`, debe seguir el siguiente formato:

- `video`: matriz de forma (T, H, W, 3), tipo: uint8
- `depths` (opcional): matriz de forma (T, H, W), tipo: float32
- `intrinsics` (opcional): matriz de forma (T, 3, 3), tipo: float32
- `extrinsics` (opcional): matriz de forma (T, 4, 4), tipo: float32

Para propósitos de demostración, el script utiliza una cuadrícula de 32x32 puntos en el primer fotograma como consultas.

### Inferencia con Vídeo Monocular

Al proporcionar un vídeo como `--input_path`, el script primero ejecuta [MegaSAM](https://github.com/mega-sam/mega-sam) con [MoGe](https://wangrc.site/MoGePage/) para estimar mapas de profundidad y parámetros de cámara. Posteriormente, el modelo procesará estas entradas dentro del marco global.

**Demo 1**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo1.gif" width="100%" alt="Demo 1">

Para ejecutar la inferencia:



```bash
python inference.py --input_path demo_inputs/sheep.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```
Un archivo npz se guardará en `outputs/inference/`. Para visualizar los resultados:


```bash
python visualize.py <result_npz_path>
```

**Demo 2**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo2.gif" width="100%" alt="Demo 2">

```bash
python inference.py --input_path demo_inputs/pstudio.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

**Inferencia con Profundidades y Parámetros de Cámara Conocidos**

Si se proporciona un archivo `.npz` que contiene las cuatro claves (`rgb`, `depths`, `intrinsics`, `extrinsics`), el modelo operará en un marco global alineado, generando trayectorias de puntos en coordenadas del mundo.  
Proporcionamos un archivo `.npz` de ejemplo [aquí](https://huggingface.co/zbww/tapip3d/resolve/main/demo_inputs/dexycb.npz?download=true) y por favor colóquelo en el directorio `demo_inputs/`.

**Demostración 3**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo3.gif" width="100%" alt="Demo 3">

```bash
python inference.py --input_path demo_inputs/dexycb.npz --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

## Entrenamiento y Evaluación

### 1. Preparación del Conjunto de Datos
Por favor, consulte [DATASET.md](https://raw.githubusercontent.com/zbw001/TAPIP3D/main/DATASET.md) para obtener instrucciones sobre la preparación de conjuntos de datos tanto para entrenamiento como para evaluación.

### 2. Entrenamiento
Para iniciar el entrenamiento, ejecute:
```bash
bash scripts/train.sh
```
- `experiment_name`: El nombre de la ejecución que se muestra en **WandB**.
- `experiment_id`: Un identificador único. Volver a ejecutar con el mismo `experiment_id` **reanuda automáticamente** el entrenamiento desde el último punto de control.

### 3. Evaluación
Para evaluar un punto de control, ejecute:
```bash
bash scripts/eval.sh
```
Puedes especificar el modelo a evaluar modificando la variable `checkpoint` en `scripts/eval.sh`.

## Citación
Si encuentras este proyecto útil, por favor considera citar:

```
@article{tapip3d,
  title={TAPIP3D: Tracking Any Point in Persistent 3D Geometry},
  author={Zhang, Bowei and Ke, Lei and Harley, Adam W and Fragkiadaki, Katerina},
  journal={arXiv preprint arXiv:2504.14717},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-12

---