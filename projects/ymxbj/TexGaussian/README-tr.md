<h1 align="center">TexGaussian: Sekizli Ağaç Tabanlı 3D Gaussian Splatting ile Yüksek Kaliteli PBR Malzeme Üretimi</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Fiziksel Tabanlı Görselleştirme (PBR) malzemeleri, modern grafiklerde önemli bir rol oynar ve çeşitli çevre haritalarında fotogerçekçi görselleştirmeye olanak tanır. 3B ağlar için RGB doku yerine otomatik olarak yüksek kaliteli PBR malzemeleri üretebilen etkili ve verimli bir algoritma geliştirmek, 3B içerik oluşturmayı önemli ölçüde kolaylaştırabilir. Mevcut yöntemlerin çoğu, çoklu görünüşlü görüntü sentezi için önceden eğitilmiş 2B difüzyon modellerinden yararlanır ve bu da çoğunlukla üretilen dokular ile giriş 3B ağlar arasında ciddi tutarsızlıklara yol açar. Bu makale, hızlı PBR malzeme üretimi için sekizli ağaç hizalı 3D Gaussian Splatting kullanan yeni bir yöntem olan TexGaussian’ı sunmaktadır. Özellikle, her bir 3B Gaussian’ı, giriş 3B ağdan oluşturulan sekizli ağacın en ince yaprak düğümüne yerleştiriyoruz ve bu sayede yalnızca albedo haritası için değil, aynı zamanda roughness (pürüzlülük) ve metalik için de çoklu görünüşlü görüntüler oluşturuyoruz. Ayrıca, modelimiz difüzyon gürültü giderme yerine regresyon yöntemiyle eğitildiğinden, tek bir ileri besleme işleminde 3B ağ için PBR malzemesi üretebilmektedir. Kamuya açık benchmark’lar üzerinde yapılan kapsamlı deneyler, yöntemimizin hem koşulsuz hem de metin koşullu senaryolarda daha görsel olarak tatmin edici PBR malzemeleri sentezlediğini ve önceki yöntemlerden daha hızlı çalıştığını göstermektedir. Ayrıca, verilen geometrilerle daha iyi bir tutarlılık sergiler.

## 📦 Kurulum

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# modifiye edilmiş gaussian splatting (+ derinlik, alfa işleme)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# diğer bağımlılıklar
pip3 install -r requirements.txt
```

## 🤖 Önceden Eğitilmiş Modeller

Aşağıdaki önceden eğitilmiş modelleri sunuyoruz:

| Model | Açıklama | Parametre | İndirme |
| --- | --- | --- | --- |
| TexGaussian-bench | ShapeNet bench üzerinde eğitilmiş koşulsuz RGB doku modeli | 70M | [İndir](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | ShapeNet car üzerinde eğitilmiş koşulsuz RGB doku modeli | 70M | [İndir](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | ShapeNet chair üzerinde eğitilmiş koşulsuz RGB doku modeli | 70M | [İndir](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | ShapeNet table üzerinde eğitilmiş koşulsuz RGB doku modeli | 70M | [İndir](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Objaverse üzerinde eğitilmiş metin koşullu PBR malzeme modeli | 295M | [İndir](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Çıkarım (Inference)

### PBR Malzemesi
Metin koşullu PBR malzeme üretimi için şunu çalıştırın:
```bash
bash inference_for_PBR_material.sh
```
Doku ve malzeme pişirme işlemi sonrası iki harita elde edeceksiniz: biri albedo haritası, diğeri PBR malzeme haritasıdır. Özellikle, PBR malzeme haritası üç kanallıdır; yeşil kanal pürüzlülük (roughness) değerini, mavi kanal ise metalik değerini temsil eder. Oluşturulan doku ve malzeme haritalarının PBR görselleştirmesini yapmak için bpy ile yazılmış [bu görselleştirme scriptini](https://github.com/ymxbj/BlenderToolboxPBR) kullanmanızı öneririz.

Ayrıca, Cap3D veri setinin metin tarzını taklit ederek kendi istemlerinizi (prompt) oluşturmanızı ve daha iyi üretim sonuçları için kullanmanızı öneriyoruz. Cap3D veri setini [buradan](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true) indirebilirsiniz.

### RGB Doku
Koşulsuz RGB doku üretimi için (yalnızca şu dört kategori için çalışır: bench, car, chair, table), şunu çalıştırın:
```bash
bash inference_for_RGB_texture.sh
```
Doku pişirme işlemi sonrası bir albedo haritası elde edeceksiniz.

## 🏋️‍♂️ Eğitim
Objaverse için:
```bash
bash train_for_objaverse.sh
```

ShapeNet için:
```bash
bash train_for_shapenet.sh
```

## 🚧 YAPILACAKLAR
- [x] Eğitim ve çıkarım kodunu yayınla
- [x] ShapeNet veri seti üzerinde koşulsuz yalnızca albedo önceden eğitilmiş modeli yayınla
- [x] Objaverse veri seti üzerinde metin koşullu PBR önceden eğitilmiş modeli yayınla
- [ ] Veri seti ve veri seti araçlarını yayınla

## 📚 Teşekkür

Bu çalışma, birçok harika araştırma ve açık kaynak projeye dayanmaktadır; tüm yazarlara paylaşımları için teşekkür ederiz!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) ve [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Atıf

Bu çalışmanın size faydalı olduğunu düşünüyorsanız, lütfen makalemizi atıf olarak gösterin:

1. arXiv sürümü
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR sürümü
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