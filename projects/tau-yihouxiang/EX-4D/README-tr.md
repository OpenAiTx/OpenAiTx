# EX-4D: Derinlik Sızdırmaz Mesh ile Aşırı Bakış Açılı 4D Video Sentezi

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Makale](https://arxiv.org/abs/2506.05554)  |  [🎥 Ana Sayfa](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Kod](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Öne Çıkanlar

- **🎯 Aşırı Bakış Açısı Sentezi**: -90° ile 90° arasında kamera hareketleriyle yüksek kaliteli 4D videolar üretir
- **🔧 Derinlik Sızdırmaz Mesh**: Hem görünen hem de gizli bölgeleri modelleyen yeni bir geometrik temsil
- **⚡ Hafif Mimari**: 14B video difüzyon omurgasının yalnızca %1’i kadar (140M) eğitilebilir parametre
- **🎭 Çoklu Görüş Eğitimi Yok**: Yenilikçi maskeleme stratejisi, pahalı çoklu görüş veri seti ihtiyacını ortadan kaldırır
- **🏆 Son Teknoloji Performans**: Özellikle aşırı kamera açılarında mevcut yöntemleri geride bırakır

## 🎬 Demo Sonuçları

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D, monoküler videoları, aşırı bakış açıları altında fiziksel olarak tutarlı sonuçlarla kamera kontrollü 4D deneyimlere dönüştürür.*

## 🏗️ Çerçeve Genel Bakış

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Çerçevemiz üç ana bileşenden oluşur:

1. **🔺 Derinlik Sızdırmaz Mesh Oluşturma**: Hem görünen hem de gizli bölgeleri açıkça modelleyen sağlam bir geometrik öncelik oluşturur
2. **🎭 Simüle Edilmiş Maskeleme Stratejisi**: Çoklu görüş veri setleri olmadan monoküler videolardan etkili eğitim verisi üretir
3. **⚙️ Hafif LoRA Adaptörü**: Geometrik bilgiyi önceden eğitilmiş video difüzyon modelleriyle verimli bir şekilde entegre eder

## 🚀 Hızlı Başlangıç

### Kurulum

```bash
# Depoyu klonlayın
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Conda ortamı oluşturun
conda create -n ex4d python=3.10
conda activate ex4d
# PyTorch'u kurun (2.x önerilir)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Nvdiffrast'ı kurun
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Bağımlılıkları ve diffsynth'i kurun
pip install -e .
# Derinlik tahmini için depthcrafter kurun. (Checkpoint hazırlığı için DepthCrafter'ın kurulum talimatlarını takip edin.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Önceden Eğitilmiş Modeli İndir
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Örnek Kullanım
#### 1. DW-Mesh Rekonstrüksiyonu
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D Üretimi (48GB VRAM gereklidir)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Girdi Video</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Çıktı Video</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Yöntem | FID (Aşırı) ↓ | FVD (Aşırı) ↓ | VBench Skoru ↑ |
|--------|---------------|--------------|---------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Bizim)** | **55.42** | **823.61** | **0.450** | -->

### Kullanıcı Çalışması Sonuçları

- Katılımcıların **%70.7**’si EX-4D’yi temel yöntemlere tercih etti
- Fiziksel tutarlılık ve aşırı bakış açısı kalitesinde üstün performans
- Kamera açıları daha aşırı hale geldikçe anlamlı iyileşme


## 🎯 Uygulamalar

- **🎮 Oyun**: 2D görüntülerden sürükleyici 3D oyun sinematikleri oluşturma
- **🎬 Film Prodüksiyonu**: Post-prodüksiyon için yeni kamera açıları üretme
- **🥽 VR/AR**: Serbest bakış açılı video deneyimleri oluşturma
- **📱 Sosyal Medya**: İçerik üretimi için dinamik kamera hareketleri üretme
- **🏢 Mimarlık**: Mekanları çoklu bakış açısından görselleştirme

<!-- ## 📈 Karşılaştırmalar -->

<!-- ### Bakış Açısı Aralığı Değerlendirmesi

| Aralık | Küçük (0°→30°) | Büyük (0°→60°) | Aşırı (0°→90°) | Tam (-90°→90°) |
|--------|----------------|---------------|----------------|---------------|
| FID Skoru | 44.19 | 50.30 | 55.42 | - |
| Performans Farkı | %9.1 daha iyi | %8.9 daha iyi | %11.3 daha iyi | %15.5 daha iyi | -->

<!-- *Her kategoride ikinci en iyi yönteme kıyasla performans farkı.* -->

## ⚠️ Sınırlamalar

- **Derinlik Bağımlılığı**: Performans tek gözlü derinlik tahmininin kalitesine bağlıdır
- **Hesaplama Maliyeti**: Yüksek çözünürlüklü videolar için önemli hesaplama gerektirir
- **Yansıtıcı Yüzeyler**: Yansıtıcı veya şeffaf malzemelerde zorluklar

## 🔮 Gelecek Çalışmalar
- [ ] Gerçek zamanlı çıkarım optimizasyonu (3DGS / 4DGS)
- [ ] Daha yüksek çözünürlük desteği (1K, 2K)
- [ ] Nöral ağ tabanlı mesh iyileştirme teknikleri

## 🙏 Teşekkürler

Temel difüzyon altyapısını sağladığı için [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) projesine teşekkür ederiz.

## 📚 Atıf

Çalışmamızı faydalı bulursanız, lütfen aşağıdaki şekilde atıf yapınız:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---