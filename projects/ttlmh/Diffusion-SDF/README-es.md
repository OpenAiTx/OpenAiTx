# Diffusion-SDF: De texto a forma mediante difusión voxelizada

Creado por [Muheng Li](https://ttlmh.github.io/), [Yueqi Duan](https://duanyueqi.github.io/), [Jie Zhou](https://scholar.google.com/citations?user=6a79aPwAAAAJ&hl=en&authuser=1), y [Jiwen Lu](https://scholar.google.com/citations?user=TN8uDQoAAAAJ&hl=en&authuser=1).

![intro](https://raw.githubusercontent.com/ttlmh/Diffusion-SDF/master/media/intro.png)

We propose a new generative 3D modeling framework called **Diffusion-SDF** for the challenging task of text-to-shape synthesis. Previous approaches lack flexibility in both 3D data representation and shape generation, thereby failing to generate highly diversified 3D shapes conforming to the given text descriptions. To address this, we propose a SDF autoencoder together with the Voxelized Diffusion model to learn and generate representations for voxelized signed distance fields (SDFs) of 3D shapes. Specifically, we design a novel UinU-Net architecture that implants a local-focused inner network inside the standard U-Net architecture, which enables better reconstruction of patch-independent SDF representations. We extend our approach to further text-to-shape tasks including text-conditioned shape completion and manipulation. Experimental results show that Diffusion-SDF is capable of generating both high-quality and highly diversified 3D shapes that conform well to the given text descriptions. Diffusion-SDF has demonstrated its superiority compared to previous state-of-the-art text-to-shape approaches.

![intro](https://raw.githubusercontent.com/ttlmh/Diffusion-SDF/master/media/pipeline.gif)

[[Página del Proyecto]](https://ttlmh.github.io/DiffusionSDF/) [[arXiv]](https://arxiv.org/abs/2212.03293)

## Código

### Instalación
Para configurar el entorno Diffusion-SDF, puede usar el archivo `diffusionsdf.yml` proporcionado para crear un entorno Conda. Siga los siguientes pasos:
1. Clone el repositorio:
```
git clone https://github.com/ttlmh/Diffusion-SDF.git
```
2. Crea el entorno Conda usando el archivo YAML proporcionado y actívalo:
```
conda env create -f diffusionsdf.yml
conda activate diffusionsdf
```

### Descargar Modelos Preentrenados
Descargue el archivo del modelo auto-codificador SDF (vae_epoch-120.pth: [Baidu Disk](https://pan.baidu.com/s/1z0eh8SXSrn8tbq5epo0r6Q?pwd=f1cv) / [Google Drive](https://drive.google.com/file/d/18MxWYf6IItYOxUzdM5LiWb8dr9zSwA-2/view?usp=sharing)) y el archivo del modelo de Difusión Voxelizada (voxdiff-uinu.ckpt: [Baidu Disk](https://pan.baidu.com/s/1Emu5kFVaYbuKIkdCKlghXQ?pwd=q1wv) / [Google Drive](https://drive.google.com/file/d/1yeB0dJGZvIXdF1V1DhI-fRz6CKnGbIwJ/view?usp=sharing))) desde los enlaces anteriores. Coloque los archivos de modelo descargados en el directorio ```./ckpt``` .

---

## Inferencia

### Generación de Forma desde Texto
Para generar formas 3D a partir de descripciones de texto usando Diffusion-SDF, ejecute:

```
python txt2sdf.py --prompt "a revolving chair" --save_obj
```
La forma 3D generada se guardará como renderizados GIF y archivos OBJ en `outputs/`.

### Completado de Forma Condicionado por Texto
Dada una forma 3D parcial/incompleta (como un archivo `.h5` SDF) y un texto de indicación, Diffusion-SDF puede completar las regiones faltantes:

```bash
# Axial cut: mask out the bottom half along the Z axis
python shape_completion.py \
    --input_sdf path/to/partial.h5 \
    --prompt "a wooden chair" \
    --mask_axis z --mask_ratio 0.5

# SDF-value based masking (mask voxels with SDF >= threshold)
python shape_completion.py \
    --input_sdf path/to/shape.h5 \
    --prompt "a dining table" \
    --mask_type threshold --mask_value 0.0
```
Los resultados (representaciones GIF y archivos OBJ opcionales) se guardan en `outputs/shape_completion/`.

### Manipulación de formas condicionada por texto
Dada una forma 3D existente y un texto de entrada, Diffusion-SDF modifica la forma mediante el enfoque SDEdit: codificando la forma en el espacio latente, añadiendo ruido hasta un paso temporal elegido, y luego eliminando el ruido con el nuevo texto de entrada:

```bash
# Moderate manipulation (50% noise strength)
python shape_manipulation.py \
    --input_sdf path/to/shape.h5 \
    --prompt "a chair with a cushion" \
    --strength 0.5

# Strong manipulation (75% noise strength — more creative freedom)
python shape_manipulation.py \
    --input_sdf path/to/shape.h5 \
    --prompt "a modern minimalist chair" \
    --strength 0.75
```
Los resultados se guardan en `outputs/shape_manipulation/`, incluyendo una renderización de la forma original para comparación.

---

## Entrenamiento

### Preparación de Datos

El entrenamiento requiere dos cosas: archivos SDF voxelizados para las formas 3D, y descripciones textuales de Text2Shape.

#### Paso 0 — Descargar ShapeNet Core v1

Regístrese y descargue [ShapeNet Core v1](https://shapenet.org/) y extráigalo en algún lugar (por ejemplo, `data/ShapeNetCore.v1/`).

#### Paso 1 — Precalcular volúmenes SDF de 64³

ShapeNet proporciona mallas triangulares; el autoencoder y el modelo de difusión necesitan campos de distancia firmada voxelizados en una cuadrícula de 64³, almacenados como archivos HDF5. Seguimos la misma cadena de preprocesamiento que [SDFusion](https://github.com/yccyenchicheng/SDFusion):

```bash
# Install system dependencies (Ubuntu/Debian)
sudo apt-get install freeglut3-dev libtbb-dev

# Clone SDFusion and run their SDF generation scripts
# (see SDFusion repo for the full launcher scripts)
cd preprocess
bash launch_create_sdf_shapenet.sh \
    --shapenet_root data/ShapeNetCore.v1 \
    --out_root data/ShapeNet/sdf
```

El diseño de salida esperado es:
```
data/ShapeNet/
  sdf/
    <synset_id>/          e.g. 03001627 (chair), 04379243 (table)
      <model_id>/
        pc_sdf_sample.h5  float32 array of shape (262144,) = 64³ SDF values
```

La clave HDF5 es `pc_sdf_sample` y el arreglo se almacena plano (262144 = 64×64×64 elementos).

#### Paso 2 — Preparar los captions de Text2Shape

[Text2Shape](http://text2shape.stanford.edu/) proporciona descripciones en lenguaje natural solo para las **sillas** y **mesas** de ShapeNet. Otras categorías se entrenarán de forma incondicional (caption vacío).

```bash
# Download the caption CSV
mkdir -p data/ShapeNet/text
wget http://text2shape.stanford.edu/dataset/captions.tablechair.csv \
    -O data/ShapeNet/text/captions.tablechair.csv

# Convert to captions.json and generate train/val/test splits
python preprocess/prepare_text2shape.py --data_root data/ShapeNet
```

Esto produce:
```
data/ShapeNet/
  text/
    captions.tablechair.csv   (raw Text2Shape CSV)
    captions.json             {model_id: [caption, ...]}
  train_models.json           [model_id, ...]
  val_models.json
  test_models.json
```

Si tienes los archivos JSON de división oficial de ShapeNet, pásalos con `--shapenet_split_dir` para usar las divisiones canónicas en lugar de una división aleatoria:

```bash
python preprocess/prepare_text2shape.py \
    --data_root data/ShapeNet \
    --shapenet_split_dir data/ShapeNet/splits
```

### Paso 1 — Entrenar el Autoencoder SDF
Entrena el autoencoder variacional por parches que codifica volúmenes SDF de 64³ en un espacio latente compacto de 8³:

```bash
# Single GPU
python train_ae.py --data_root data/ShapeNet --cat all

# Resume from a checkpoint
python train_ae.py --data_root data/ShapeNet \
    --resume ckpt/vae_epoch-120.pth --start_epoch 121

# Multi-GPU (DDP via torchrun)
torchrun --nproc_per_node=4 train_ae.py --data_root data/ShapeNet --dist_train
```

Los puntos de control se guardan en `./ckpt/` como `vae_epoch-{N}.pth`.

### Paso 2 — Entrenar el Modelo de Difusión Voxelizado
Después de entrenar el AE, entrena el modelo de difusión 3D condicionado por texto usando PyTorch Lightning:

```bash
# Single GPU
python main.py --config configs/voxdiff-uinu.yaml

# Resume from a checkpoint
python main.py --config configs/voxdiff-uinu.yaml --resume /path/to/checkpoint.ckpt

# Multi-GPU
python main.py --config configs/voxdiff-uinu.yaml --gpus 0,1,2,3
```

Los puntos de control se guardan en `logs/<run_name>/checkpoints/`.

## Agradecimientos
Nuestro código se basa en [Stable-Diffusion](https://github.com/CompVis/stable-diffusion) y [AutoSDF](https://github.com/yccyenchicheng/AutoSDF).

## Citación
Si encuentra nuestro trabajo útil en su investigación, por favor considere citar:

```
@inproceedings{li2023diffusionsdf,
  author={Li, Muheng and Duan, Yueqi and Zhou, Jie and Lu, Jiwen},
  title={Diffusion-SDF: Text-to-Shape via Voxelized Diffusion},
  booktitle={Proceedings of the IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
  year={2023}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-13

---