<div align="center">
<h2>Detay Zengin ve Zamansal Olarak Tutarlı Video Süper-Çözünürlüğü için Tek Adımlı Difüzyon</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>Hong Kong Politeknik Üniversitesi, <sup>2</sup>OPPO Araştırma Enstitüsü
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Görsel Sonuçlar">

</p>
## ⏰ Güncelleme

- **2025.07.08**: Çıkarım kodu ve önceden eğitilmiş ağırlıklar mevcut.
- **2025.06.24**: Proje sayfası yayında, 2 dakikalık kısa bir açıklama videosu, daha fazla görsel sonuç ve ilgili araştırmalar dahil.
- **2025.06.17**: Depo yayınlandı.

:star: Eğer DLoRAL videolarınıza veya projelerinize yardımcı olduysa, lütfen bu depoya yıldız verin. Teşekkürler! :hugs:

😊 İlgili çalışmalarımıza da göz atmak isteyebilirsiniz:

1. **OSEDiff (NIPS2024)** [Makale](https://arxiv.org/abs/2406.08177) | [Kod](https://github.com/cswry/OSEDiff/)  

   OPPO Find X8 serisinde uygulanan gerçek zamanlı Görüntü SR algoritması.

2. **PiSA-SR (CVPR2025)** [Makale](https://arxiv.org/pdf/2412.03017) | [Kod](https://github.com/csslc/PiSA-SR) 

   Görüntü SR'de Dual-LoRA paradigmasının öncü keşfi.

3. **Video Süper-Çözünürlük için Harika Diffusion Modelleri** [Repo](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Diffusion Modelleri kullanarak Video Süper-Çözünürlük (VSR) için derlenmiş bir kaynak listesi.
## 👀 YAPILACAKLAR
- [x] Çıkarım kodunu yayınla.
- [ ] Kolay test için Colab ve Huggingface arayüzü (Yakında!).
- [ ] Eğitim kodunu yayınla.
- [ ] Eğitim verisini yayınla.


## 🌟 Genel Bakış Çerçevesi

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Eğitim**: Dinamik bir çift aşamalı eğitim şeması, zamansal tutarlılığı optimize etme (tutarlılık aşaması) ile yüksek frekanslı uzamsal detayları iyileştirme (geliştirme aşaması) arasında geçiş yapar ve istikrarı sağlamak için yumuşak kayıp enterpolasyonu uygular.

**Çıkarım**: Çıkarım sırasında, hem C-LoRA hem de D-LoRA donmuş difüzyon UNet’ine birleştirilir ve düşük kaliteli girdilerin yüksek kaliteli çıktılara tek adımda iyileştirilmesini sağlar.
## 🔧 Bağımlılıklar ve Kurulum

1. Depoyu klonlayın
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Bağımlı paketleri yükleyin
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Modelleri İndirin
#### Bağımlı Modeller
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base** dizinine koyun
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> **/path/to/DLoRAL/preset_models/bert-base-uncased** dizinine koyun
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth** dizinine koyun
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> **/path/to/DLoRAL/preset/models/DAPE.pth** dizinine koyun
* [Önceden Eğitilmiş Ağırlıklar](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> **/path/to/DLoRAL/preset/models/checkpoints/model.pkl** dizinine koyun

Her yol kendi gereksinimlerinize göre değiştirilebilir ve ilgili değişiklikler komut satırına ve koda da uygulanmalıdır.
## 🖼️ Hızlı Çıkarım
Gerçek Dünya Video Süper-Çözünürlüğü için:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```
### Atıflar
Kodumuz araştırmanızda veya çalışmalarınızda yardımcı olursa, lütfen makalemizi kaynak olarak göstermeyi düşünün.
Aşağıda BibTeX referansları verilmiştir:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---