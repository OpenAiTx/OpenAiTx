<h1 align="center">TexGaussian: Generación de Material PBR de Alta Calidad mediante Splatting Gaussiano 3D Basado en Octree</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Los materiales de Renderizado Basado en Física (PBR) juegan un papel crucial en los gráficos modernos, permitiendo renderizado fotorrealista a través de diversos mapas de entorno. Desarrollar un algoritmo efectivo y eficiente capaz de generar automáticamente materiales PBR de alta calidad, en lugar de texturas RGB para mallas 3D, puede agilizar significativamente la creación de contenido 3D. La mayoría de los métodos existentes aprovechan modelos de difusión 2D preentrenados para la síntesis de imágenes multivista, lo que a menudo conduce a una grave inconsistencia entre las texturas generadas y las mallas 3D de entrada. Este artículo presenta TexGaussian, un método novedoso que utiliza Splatting Gaussiano 3D alineado por octantes para la generación rápida de materiales PBR. Específicamente, colocamos cada Gaussiana 3D en el nodo hoja más fino del octree construido a partir de la malla 3D de entrada para renderizar imágenes multivista no solo para el mapa de albedo sino también para rugosidad y metalicidad. Además, nuestro modelo se entrena de manera regresiva en lugar de denoising por difusión, siendo capaz de generar el material PBR para una malla 3D en un solo proceso feed-forward. Experimentos extensos en benchmarks públicos demuestran que nuestro método sintetiza materiales PBR visualmente más atractivos y funciona más rápido que los métodos previos tanto en escenarios incondicionales como condicionados por texto, mostrando mejor consistencia con la geometría dada.

## 📦 Instalación

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# una versión modificada de gaussian splatting (+ rendering de profundidad y alfa)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# otras dependencias
pip3 install -r requirements.txt
```

## 🤖 Modelos Preentrenados

Proporcionamos los siguientes modelos preentrenados:

| Modelo | Descripción | Parámetros | Descarga |
| --- | --- | --- | --- |
| TexGaussian-bench | Modelo incondicional de textura RGB entrenado en ShapeNet bench | 70M | [Descargar](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Modelo incondicional de textura RGB entrenado en ShapeNet car | 70M | [Descargar](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Modelo incondicional de textura RGB entrenado en ShapeNet chair | 70M | [Descargar](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Modelo incondicional de textura RGB entrenado en ShapeNet table | 70M | [Descargar](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Modelo PBR condicionado por texto entrenado en Objaverse | 295M | [Descargar](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inferencia

### Material PBR
Para la generación de material PBR condicionado por texto, ejecuta
```bash
bash inference_for_PBR_material.sh
```
Después del horneado de textura y material, obtendrás dos mapas, uno es el mapa de albedo y otro es el mapa de material PBR. Específicamente, el mapa de material PBR contiene tres canales, donde el canal verde representa el valor de rugosidad y el canal azul representa el valor de metalicidad. Para realizar el renderizado PBR de las texturas y mapas de materiales generados, recomendamos usar [este script de renderizado](https://github.com/ymxbj/BlenderToolboxPBR) escrito con bpy.

Además, recomendamos a todos imitar el estilo del texto del dataset Cap3D y crear sus propios prompts para mejores resultados de generación. El dataset Cap3D se puede descargar [aquí](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### Textura RGB
Para la generación incondicional de texturas RGB, que solo funciona para 4 categorías específicas: bench, car, chair, table, ejecuta
```bash
bash inference_for_RGB_texture.sh
```
Después del horneado de textura, obtendrás un mapa de albedo.

## 🏋️‍♂️ Entrenamiento
Para Objaverse:
```bash
bash train_for_objaverse.sh
```

Para ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Liberar código de entrenamiento e inferencia
- [x] Liberar modelo preentrenado incondicional solo albedo en el dataset ShapeNet
- [x] Liberar modelo preentrenado PBR condicionado por texto en el dataset Objaverse
- [ ] Liberar dataset y herramientas para el dataset

## 📚Agradecimientos

Este trabajo se basa en muchas investigaciones y proyectos open-source increíbles, ¡muchas gracias a todos los autores por compartir!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) y [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Citación

Si este trabajo te resulta útil, por favor considera citar nuestro artículo:

1. Versión arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Versión CVPR
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun y Liu, Jialun y Hu, Jiakui y Wu, Chenming y Wu, Jinbo y Liu, Xing y Zhao, Chen y Ding, Errui y Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---