<h1 align="center">TexGaussian: Hochwertige PBR-Materialien mittels Octree-basierter 3D-Gaussian Splatting erzeugen</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Physically Based Rendering (PBR)-Materialien spielen eine entscheidende Rolle in der modernen Grafik und ermöglichen fotorealistisches Rendering in vielfältigen Umgebungen. Die Entwicklung eines effektiven und effizienten Algorithmus, der in der Lage ist, automatisch hochwertige PBR-Materialien anstelle von RGB-Texturen für 3D-Meshes zu generieren, kann die Erstellung von 3D-Inhalten erheblich vereinfachen. Die meisten bestehenden Methoden nutzen vortrainierte 2D-Diffusionsmodelle für die Multi-View-Bildsynthese, was häufig zu starken Inkonsistenzen zwischen den generierten Texturen und den Eingabe-3D-Meshes führt. In dieser Arbeit präsentieren wir TexGaussian, eine neuartige Methode, die octant-ausgerichtetes 3D-Gaussian Splatting für die schnelle PBR-Materialgenerierung verwendet. Konkret platzieren wir jedes 3D-Gaussian auf dem feinsten Blattknoten des Octrees, der aus dem Eingabe-3D-Mesh erstellt wurde, um Multi-View-Bilder nicht nur für die Albedo-Map, sondern auch für Roughness und Metallic zu rendern. Darüber hinaus wird unser Modell regressionsbasiert anstelle von Diffusions-Denoising trainiert und ist in der Lage, das PBR-Material für ein 3D-Mesh in einem einzigen Feed-Forward-Prozess zu erzeugen. Umfangreiche Experimente auf öffentlich verfügbaren Benchmarks zeigen, dass unsere Methode visuell ansprechendere PBR-Materialien synthetisiert und schneller läuft als bisherige Methoden – sowohl in unbedingten als auch in text-konditionalen Szenarien –, was eine bessere Übereinstimmung mit der gegebenen Geometrie zeigt.

## 📦 Installation

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# modifiziertes Gaussian Splatting (+ Depth, Alpha Rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# weitere Abhängigkeiten
pip3 install -r requirements.txt
```

## 🤖 Vorgefertigte Modelle

Wir stellen die folgenden vortrainierten Modelle bereit:

| Modell | Beschreibung | Parameter | Download |
| --- | --- | --- | --- |
| TexGaussian-bench | Unbedingtes RGB-Texturmodell, trainiert auf ShapeNet bench | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Unbedingtes RGB-Texturmodell, trainiert auf ShapeNet car | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Unbedingtes RGB-Texturmodell, trainiert auf ShapeNet chair | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Unbedingtes RGB-Texturmodell, trainiert auf ShapeNet table | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Text-konditionales PBR-Materialmodell, trainiert auf Objaverse | 295M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Inferenz

### PBR-Material
Für die textkonditionierte PBR-Materialgenerierung führen Sie aus:
```bash
bash inference_for_PBR_material.sh
```
Nach dem Backen von Textur und Material erhalten Sie zwei Maps, eine ist die Albedo-Map und die andere ist die PBR-Material-Map. Genauer gesagt enthält die PBR-Material-Map drei Kanäle, wobei der grüne Kanal den Roughness-Wert und der blaue Kanal den Metallic-Wert repräsentiert. Für das PBR-Rendering der generierten Textur- und Material-Maps empfehlen wir dieses [Render-Skript](https://github.com/ymxbj/BlenderToolboxPBR), geschrieben in bpy.

Außerdem empfehlen wir jedem, den Stil der Textbeschreibung des Cap3D-Datensatzes zu imitieren und eigene Prompts zu erstellen, um bessere Ergebnisse zu erzielen. Der Cap3D-Datensatz kann [hier](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true) heruntergeladen werden.

### RGB-Textur
Für die unbedingte RGB-Texturgenerierung, die nur für die folgenden 4 Kategorien funktioniert: bench, car, chair, table, führen Sie aus:
```bash
bash inference_for_RGB_texture.sh
```
Nach dem Textur-Backen erhalten Sie eine Albedo-Map.

## 🏋️‍♂️ Training
Für Objaverse:
```bash
bash train_for_objaverse.sh
```

Für ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Trainings- und Inferenz-Code veröffentlichen
- [x] Unbedingtes, nur Albedo betreffendes, vortrainiertes Modell auf ShapeNet-Datensatz veröffentlichen
- [x] Text-konditioniertes PBR-vortrainiertes Modell auf Objaverse-Datensatz veröffentlichen
- [ ] Datensatz und Datensatz-Toolkits veröffentlichen

## 📚 Danksagung

Diese Arbeit basiert auf vielen großartigen Forschungsarbeiten und Open-Source-Projekten. Vielen Dank an alle Autoren fürs Teilen!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) und [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Zitation

Wenn Sie diese Arbeit hilfreich finden, zitieren Sie bitte unser Paper:

1. arXiv-Version
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun und Liu, Jialun und Hu, Jiakui und Wu, Chenming und Wu, Jinbo und Liu, Xing und Zhao, Chen und Ding, Errui und Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR-Version
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun und Liu, Jialun und Hu, Jiakui und Wu, Chenming und Wu, Jinbo und Liu, Xing und Zhao, Chen and Ding, Errui and Lian, Zhouhui},
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