<div align="center">
<h2>One-Step Diffusion voor Detailrijke en Tijdelijk Consistente Video Super-Resolutie</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>The Hong Kong Polytechnic University, <sup>2</sup>OPPO Research Institute
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Visuele Resultaten">

</p>

## ⏰ Update

- **2025.07.08**: De inferentiecode en vooraf getrainde gewichten zijn beschikbaar.
- **2025.06.24**: De projectpagina is beschikbaar, inclusief een korte uitlegvideo van 2 minuten, meer visuele resultaten en relevante onderzoeken.
- **2025.06.17**: De repo is uitgebracht.

:star: Als DLoRAL nuttig is voor jouw video's of projecten, geef deze repo dan een ster. Bedankt! :hugs:

😊 Je wilt misschien ook onze relevante werken bekijken:

1. **OSEDiff (NIPS2024)** [Paper](https://arxiv.org/abs/2406.08177) | [Code](https://github.com/cswry/OSEDiff/)  

   Real-time Image SR-algoritme dat is toegepast op de OPPO Find X8-serie.

2. **PiSA-SR (CVPR2025)** [Paper](https://arxiv.org/pdf/2412.03017) | [Code](https://github.com/csslc/PiSA-SR) 

   Pionierende verkenning van het Dual-LoRA paradigma in Image SR.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repo](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Een samengestelde lijst van bronnen voor Video Super-Resolution (VSR) met behulp van Diffusion Models.
## 👀 TODO
- [x] Inferencecode vrijgeven.
- [ ] Colab en Huggingface UI voor gemakkelijk testen (Binnenkort!).
- [ ] Trainingscode vrijgeven.
- [ ] Trainingsdata vrijgeven.


## 🌟 Overzicht Framework

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Training**: Een dynamisch dual-stage trainingsschema wisselt af tussen het optimaliseren van temporele coherentie (consistentiefase) en het verfijnen van hoge-frequentie ruimtelijke details (versterkingsfase) met soepele verliesinterpolatie om stabiliteit te waarborgen.

**Inferentie**: Tijdens inferentie worden zowel C-LoRA als D-LoRA samengevoegd in de bevroren diffusion UNet, waardoor eenmalige verbetering van lage-kwaliteit invoer naar hoge-kwaliteit uitvoer mogelijk wordt gemaakt.
## 🔧 Afhankelijkheden en Installatie

1. Repo klonen
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Afhankelijke pakketten installeren
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Modellen downloaden
#### Afhankelijke Modellen
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> plaats in **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> plaats in **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> plaats in **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> plaats in **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> plaats in **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Elk pad kan naar eigen wens worden aangepast, en de bijbehorende wijzigingen moeten ook worden doorgevoerd in de opdrachtregel en de code.
## 🖼️ Snelle Inferentie
Voor Super-Resolutie van Video’s uit de Praktijk:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /pad/naar/stable-diffusion-2-1-base     \
--ram_ft_path /pad/naar/DAPE.pth     \
--ram_path '/pad/naar/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/pad/naar/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /pad/naar/model_checkpoint.pkl     \
--stages 1     \
-i /pad/naar/input_videos/     \
-o /pad/naar/results
```

### Citaten
Als onze code uw onderzoek of werk helpt, overweeg dan om ons artikel te citeren.
De volgende zijn BibTeX-referenties:

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