<div align="center">

# AerialMegaDepth: Aprendizaje de Reconstrucción Aérea-Terrestre y Síntesis de Vista

[Khiem Vuong](https://www.khiemvuong.com/), [Anurag Ghosh](https://anuragxel.github.io/), [Deva Ramanan*](https://www.cs.cmu.edu/~deva), [Srinivasa Narasimhan*](https://www.cs.cmu.edu/~srinivas), [Shubham Tulsiani*](https://shubhtuls.github.io/)

**CVPR 2025**

[[`arXiv`](https://arxiv.org/abs/2504.13157)]
[[`Página del Proyecto`](https://aerial-megadepth.github.io/)]
[[`Visor Web 3D`](https://aerial-megadepth.github.io/web-viewer/)]
[[`Bibtex`](#citation)]

</div>

## 📢 Noticias
- (5 de sep, 2025): Hemos movido el conjunto completo de datos a HuggingFace para facilitar su descarga. Por favor consulte [data_generation](data_generation) para instrucciones completas.

## Tabla de Contenidos

- [Instalación](#installation)
- [Inicio Rápido](#quick-start)
- [Evaluación](#evaluation)
- [Generación de Datos](#data-generation)
- [Agradecimientos](#acknowledgement)
- [Citación](#citation)
- [Problemas](#issues)


## 📋 Antes de Comenzar...
Dependiendo de lo que le interese:

- 🚀 **Si desea descargar puntos de control preentrenados y ejecutar la demo**: puede continuar leyendo a continuación.

- 🛠️ **Si desea acceder o generar el conjunto de datos usted mismo**: por favor consulte [data_generation](data_generation) para instrucciones completas.

## Instalación

A continuación las instrucciones de configuración (siguiendo principalmente el [repositorio MASt3R](https://github.com/naver/mast3r)). Seguimos la configuración de MASt3R ya que engloba DUSt3R, pero ambos deberían funcionar de manera similar.


1. Clona el repositorio:
```bash
git clone --recursive https://github.com/kvuong2711/aerial-megadepth.git
cd aerial-megadepth/mast3r

# If you already cloned the repository, you can update the submodules:
# git submodule update --init --recursive
```
2. Crear el entorno e instalar las dependencias:
```bash
conda create -n aerialmd python=3.11 cmake=3.14.0
conda activate aerialmd 
conda install pytorch torchvision pytorch-cuda=12.1 -c pytorch -c nvidia  # use the correct version of cuda for your system
pip install -r requirements.txt
pip install -r dust3r/requirements.txt
pip install -r dust3r/requirements_optional.txt
```
3. Opcional, compilar los kernels cuda para RoPE (como en CroCo v2):
```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../
```

## Inicio Rápido
Nuestros puntos de control afinados son totalmente compatibles con la base de código original DUSt3R/MASt3R/MASt3R-SfM - si ya los tienes configurados, ¡puedes simplemente cambiar el punto de control para escenarios aéreo-terrestres!

### Puntos de control

Hay dos opciones para descargar el punto de control DUSt3R y MASt3R afinados en nuestro conjunto de datos AerialMegaDepth:

1. Puedes usar nuestra integración huggingface_hub: los modelos ([aerial-dust3r](https://huggingface.co/kvuong2711/checkpoint-aerial-dust3r) o [aerial-mast3r](https://huggingface.co/kvuong2711/checkpoint-aerial-mast3r)) se descargarán automáticamente.

2. O bien, descarga los puntos de control manualmente (usando [gdown](https://github.com/wkentaro/gdown), instala usando `pip install gdown`):

```bash
# you are inside aerial-megadepth/mast3r
mkdir -p checkpoints/
gdown --fuzzy "https://drive.google.com/open?id=1wSGpYwWeGn99J8dVWNkfefwmWMAH7LFT" -O checkpoints/  # checkpoint-aerial-dust3r.pth
gdown --fuzzy "https://drive.google.com/open?id=1LrRNUQRQZcVzcioyYHYYx9ImypSZpUq2" -O checkpoints/  # checkpoint-aerial-mast3r.pth
```

### Inferencia/Demo
Proporcionamos algunas imágenes de ejemplo en la carpeta [assets](assets) para pruebas rápidas, incluyendo imágenes del [reto ULTRRA](https://sites.google.com/view/ultrra-wacv-2025) y [Accenture-NVS1](https://arxiv.org/pdf/2503.18711).

Cada script (por ejemplo, [demo_dust3r_nongradio.py](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mast3r/demo_dust3r_nongradio.py)) contiene rutas de imágenes predefinidas para demostrar casos de uso típicos. Puedes modificar la variable `image_list` dentro del script para probar diferentes pares. Puedes ejecutar la inferencia usando los siguientes comandos:

- Código demo DUSt3R:
```bash
python demo_dust3r_nongradio.py --weights kvuong2711/checkpoint-aerial-dust3r

# or, if you downloaded the checkpoints manually:
# python demo_dust3r_nongradio.py --weights checkpoints/checkpoint-aerial-dust3r.pth
```

- Código de demostración MASt3R:
```bash
python demo_mast3r_nongradio.py --weights kvuong2711/checkpoint-aerial-mast3r

# or, if you downloaded the checkpoints manually:
# python demo_mast3r_nongradio.py --weights checkpoints/checkpoint-aerial-mast3r.pth
```
![ejemplo de coincidencia](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/assets/figures/matches_figure.png)

## Evaluación

- [ ] **POR HACER:** Los datos de evaluación se publicarán pronto.

Una vez que los datos se descarguen, ejecute el script de evaluación:
```bash
python eval.py \
    --weights checkpoints/checkpoint-aerial-dust3r.pth \
    --eval_data_dir data/eval_data_release
```
Este script (adaptado de [PoseDiffusion](https://github.com/facebookresearch/PoseDiffusion)) reporta RRA y RTA en varios umbrales de grados.

## Generación de Datos
Para instrucciones sobre cómo descargar y/o generar los datos, por favor consulte [data_generation](data_generation).

## Agradecimientos
Esta base de código se construye sobre muchos excelentes proyectos de código abierto, como [MegaDepth](https://www.cs.cornell.edu/projects/megadepth), [DUSt3R](https://github.com/naver/dust3r), [hloc](https://github.com/cvg/Hierarchical-Localization), [COLMAP](https://github.com/colmap/colmap), etc. Agradecemos a los respectivos autores por hacer su trabajo públicamente disponible.

## Citación
Si encuentra nuestro trabajo útil para su investigación, por favor considere citar nuestro artículo:

```bibtex
@inproceedings{vuong2025aerialmegadepth,
  title={AerialMegaDepth: Learning Aerial-Ground Reconstruction and View Synthesis},
  author={Vuong, Khiem and Ghosh, Anurag and Ramanan, Deva and Narasimhan, Srinivasa and Tulsiani, Shubham},
  booktitle={Proceedings of the IEEE/CVF Conference on Computer Vision and Pattern Recognition},
  year={2025},
}
```

## Problemas
Si tienes algún problema/pregunta/sugerencia, no dudes en crear un issue o contactarme directamente a través de [email](https://raw.githubusercontent.com/kvuong2711/aerial-megadepth/main/mailto:kvuong@andrew.cmu.edu).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---