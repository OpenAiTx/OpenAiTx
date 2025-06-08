<h1 align="center">TexGaussian: Genereren van hoogwaardige PBR-materialen via octree-gebaseerde 3D Gaussian Splatting</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Physically Based Rendering (PBR) materialen spelen een cruciale rol in moderne graphics, waardoor fotorealistische rendering mogelijk wordt over diverse omgevingskaarten. Het ontwikkelen van een effectieve en efficiënte algoritme dat automatisch hoogwaardige PBR-materialen kan genereren in plaats van RGB-texturen voor 3D-meshes, kan de 3D-contentcreatie aanzienlijk stroomlijnen. De meeste bestaande methoden maken gebruik van voorgetrainde 2D-diffusiemodellen voor multiview-beeldsynthese, wat vaak leidt tot ernstige inconsistentie tussen de gegenereerde texturen en de ingevoerde 3D-meshes. Dit artikel presenteert TexGaussian, een nieuwe methode die gebruikmaakt van octant-uitgelijnde 3D Gaussian Splatting voor snelle PBR-materiaalgeneratie. Specifiek plaatsen we elke 3D Gaussian op het fijnste bladknooppunt van de octree, opgebouwd uit de ingevoerde 3D-mesh, om multiview-beelden te renderen, niet alleen voor de albedo-map maar ook voor ruwheid en metallic. Bovendien wordt ons model getraind op regressie in plaats van diffusiestoring, waardoor het in staat is om het PBR-materiaal voor een 3D-mesh in één enkele feed-forward stap te genereren. Uitgebreide experimenten op publiek beschikbare benchmarks tonen aan dat onze methode visueel aantrekkelijkere PBR-materialen syntheseert en sneller werkt dan eerdere methoden, zowel in onvoorwaardelijke als tekst-voorwaardelijke scenario's, wat een betere consistentie met de gegeven geometrie oplevert.

## 📦 Installatie

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# een aangepaste gaussian splatting (+ diepte, alpha rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# overige afhankelijkheden
pip3 install -r requirements.txt
```

## 🤖 Voorgetrainde Modellen

Wij bieden de volgende voorgetrainde modellen aan:

| Model | Beschrijving | Params | Download |
| --- | --- | --- | --- |
| TexGaussian-bench | Onvoorwaardelijk RGB-textuurmodel getraind op ShapeNet bench | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Onvoorwaardelijk RGB-textuurmodel getraind op ShapeNet car | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Onvoorwaardelijk RGB-textuurmodel getraind op ShapeNet chair | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Onvoorwaardelijk RGB-textuurmodel getraind op ShapeNet table | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Tekst-voorwaardelijk PBR-materiaalmodel getraind op Objaverse | 295M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inference

### PBR Materiaal
Voor tekst-voorwaardelijke PBR-materiaal generatie, voer uit
```bash
bash inference_for_PBR_material.sh
```
Na texture- en materiaalbaking krijg je twee maps, één is de albedo map en de andere is de PBR-materiaalmap. Specifiek bevat de PBR-materiaalmap drie kanalen, waarbij het groene kanaal de ruwheidswaarde vertegenwoordigt en het blauwe kanaal de metallic waarde weergeeft. Voor het uitvoeren van PBR-rendering van de gegenereerde texture- en materiaalmaps, raden we aan om [dit render-script](https://github.com/ymxbj/BlenderToolboxPBR) geschreven in bpy te gebruiken.

Daarnaast raden wij aan om de stijl van de tekst van de Cap3D-dataset te imiteren en eigen prompts te maken voor betere generatieresultaten. De Cap3D-dataset kan [hier](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true) worden gedownload.

### RGB Textuur
Voor onvoorwaardelijke RGB-textuurgeneratie, die alleen werkt voor de specifieke 4 categorieën: bench, car, chair, table, voer uit
```bash
bash inference_for_RGB_texture.sh
```
Na texture baking krijg je één albedo map.

## 🏋️‍♂️ Training
Voor Objaverse:
```bash
bash train_for_objaverse.sh
```

Voor ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Release training- en inference-code
- [x] Release onvoorwaardelijk albedo-only voorgetraind model op ShapeNet Dataset
- [x] Release tekst-voorwaardelijk PBR voorgetraind model op Objaverse Dataset
- [ ] Release dataset en dataset toolkits

## 📚Dankwoord

Dit werk is gebaseerd op vele fantastische onderzoeksprojecten en open-source projecten, veel dank aan alle auteurs voor het delen!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) en [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Referentie

Als je dit werk nuttig vindt, overweeg dan om ons artikel te citeren:

1. arXiv versie
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR versie
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
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