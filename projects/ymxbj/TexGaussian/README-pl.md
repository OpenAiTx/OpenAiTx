<h1 align="center">TexGaussian: Generowanie wysokiej jakości materiałów PBR za pomocą oktalnej projekcji trójwymiarowych splatów Gaussa</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Materiały oparte na fizycznym renderingu (PBR) odgrywają kluczową rolę we współczesnej grafice, umożliwiając fotorealistyczny rendering w różnych środowiskach. Opracowanie skutecznego i wydajnego algorytmu, który automatycznie generuje wysokiej jakości materiały PBR zamiast tekstur RGB dla siatek 3D, może znacząco usprawnić tworzenie treści 3D. Większość istniejących metod wykorzystuje wytrenowane modele dyfuzyjne 2D do syntezy obrazów wielowidokowych, co często prowadzi do poważnych niespójności między generowanymi teksturami a wejściowymi siatkami 3D. W niniejszej pracy przedstawiamy TexGaussian, nową metodę wykorzystującą oktantowo-wyrównane splaty Gaussa 3D do szybkiego generowania materiałów PBR. Konkretnie, umieszczamy każdy splat Gaussa 3D na najdrobniejszym liściu oktalnego drzewa zbudowanego na podstawie wejściowej siatki 3D, aby renderować obrazy wielowidokowe nie tylko dla mapy albedo, ale także dla chropowatości (roughness) i metaliczności (metallic). Ponadto nasz model jest trenowany w trybie regresji zamiast denoisingu dyfuzyjnego, umożliwiając generowanie materiałów PBR dla siatki 3D w pojedynczym przebiegu feed-forward. Szerokie eksperymenty na publicznie dostępnych benchmarkach pokazują, że nasza metoda syntetyzuje bardziej atrakcyjne wizualnie materiały PBR i działa szybciej niż wcześniejsze metody zarówno w scenariuszach bezwarunkowych, jak i tekstowych, wykazując lepszą spójność z zadaną geometrią.

## 📦 Instalacja

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# zmodyfikowany gaussian splatting (+ depth, alpha rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# pozostałe zależności
pip3 install -r requirements.txt
```

## 🤖 Wytrenowane modele

Dostarczamy następujące wytrenowane modele:

| Model | Opis | Parametry | Pobierz |
| --- | --- | --- | --- |
| TexGaussian-bench | Bezwarunkowy model tekstury RGB wytrenowany na ShapeNet bench | 70M | [Pobierz](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Bezwarunkowy model tekstury RGB wytrenowany na ShapeNet car | 70M | [Pobierz](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Bezwarunkowy model tekstury RGB wytrenowany na ShapeNet chair | 70M | [Pobierz](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Bezwarunkowy model tekstury RGB wytrenowany na ShapeNet table | 70M | [Pobierz](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Warunkowy tekstowy model materiału PBR wytrenowany na Objaverse | 295M | [Pobierz](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Wnioskowanie

### Materiał PBR
Aby wygenerować materiał PBR warunkowany tekstem, uruchom
```bash
bash inference_for_PBR_material.sh
```
Po wypaleniu tekstury i materiału otrzymasz dwie mapy: jedna to mapa albedo, a druga to mapa materiału PBR. Konkretnie, mapa materiału PBR zawiera trzy kanały, gdzie zielony kanał reprezentuje wartość chropowatości (roughness), a niebieski kanał reprezentuje wartość metaliczności (metallic). Do renderowania PBR wygenerowanej tekstury i map materiałowych zalecamy użycie [tego skryptu renderującego](https://github.com/ymxbj/BlenderToolboxPBR) napisanego w bpy.

Ponadto zalecamy naśladowanie stylu opisów tekstowych zbioru Cap3D i tworzenie własnych promptów dla lepszych wyników generowania. Zbiór Cap3D można pobrać [tutaj](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### Tekstura RGB
Aby wygenerować bezwarunkową teksturę RGB (działa tylko dla 4 kategorii: bench, car, chair, table), uruchom
```bash
bash inference_for_RGB_texture.sh
```
Po wypaleniu tekstury otrzymasz jedną mapę albedo.

## 🏋️‍♂️ Trening
Dla Objaverse:
```bash
bash train_for_objaverse.sh
```

Dla ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Udostępnij kod treningowy i do wnioskowania
- [x] Udostępnij wytrenowany model bezwarunkowy (tylko albedo) na zbiorze ShapeNet
- [x] Udostępnij wytrenowany model PBR warunkowany tekstem na zbiorze Objaverse
- [ ] Udostępnij zbiór danych i narzędzia do obsługi zbioru

## 📚Podziękowania

Ta praca powstała na bazie wielu znakomitych badań i projektów open-source, wielkie podziękowania dla wszystkich autorów za udostępnienie!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) oraz [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Cytowanie

Jeśli uznasz tę pracę za pomocną, prosimy o cytowanie naszej publikacji:

1. Wersja arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Wersja CVPR
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