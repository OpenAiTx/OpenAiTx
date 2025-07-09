<div align="center">
<h2>One-Step Diffusion für detailreiche und zeitlich konsistente Video-Super-Resolution</h2>

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
        <img src="https://img.shields.io/badge/💡-Projektseite-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Erklärvideo-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Erklärvideo-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Visuelle Ergebnisse">

</p>
## ⏰ Update

- **2025.07.08**: Der Inferenz-Code und die vortrainierten Gewichte sind verfügbar.
- **2025.06.24**: Die Projektseite ist verfügbar, einschließlich eines kurzen 2-minütigen Erklärungsvideos, weiterer visueller Ergebnisse und relevanter Forschungen.
- **2025.06.17**: Das Repository ist veröffentlicht.

:star: Wenn DLoRAL für Ihre Videos oder Projekte hilfreich ist, freuen wir uns über einen Stern für dieses Repo. Vielen Dank! :hugs:

😊 Sie möchten vielleicht auch unsere verwandten Arbeiten ansehen:

1. **OSEDiff (NIPS2024)** [Paper](https://arxiv.org/abs/2406.08177) | [Code](https://github.com/cswry/OSEDiff/)  

   Echtzeit-Bild-SR-Algorithmus, der in der OPPO Find X8-Serie eingesetzt wurde.

2. **PiSA-SR (CVPR2025)** [Paper](https://arxiv.org/pdf/2412.03017) | [Code](https://github.com/csslc/PiSA-SR) 

   Pionierhafte Erforschung des Dual-LoRA-Paradigmas in der Bild-SR.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repo](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Eine kuratierte Liste von Ressourcen für Video-Super-Resolution (VSR) mit Diffusionsmodellen.
## 👀 TODO
- [x] Inferenzcode veröffentlichen.
- [ ] Colab- und Huggingface-Oberfläche für bequeme Tests (Demnächst!).
- [ ] Trainingscode veröffentlichen.
- [ ] Trainingsdaten veröffentlichen.


## 🌟 Überblick Framework

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Training**: Ein dynamisches zweistufiges Trainingsschema wechselt zwischen der Optimierung der zeitlichen Kohärenz (Konsistenzphase) und der Verfeinerung hochfrequenter räumlicher Details (Verbesserungsphase) mit sanfter Verlustinterpolation, um Stabilität zu gewährleisten.

**Inferenz**: Während der Inferenz werden sowohl C-LoRA als auch D-LoRA in das eingefrorene Diffusion-UNet zusammengeführt, wodurch eine einstufige Verbesserung von minderwertigen Eingaben zu hochwertigen Ausgaben ermöglicht wird.
## 🔧 Abhängigkeiten und Installation

1. Repository klonen
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Abhängige Pakete installieren
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Modelle herunterladen 
#### Abhängige Modelle
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> ablegen in **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> ablegen in **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> ablegen in **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> ablegen in **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> ablegen in **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Jeder Pfad kann nach den eigenen Anforderungen angepasst werden, und die entsprechenden Änderungen sollten auch in der Befehlszeile und im Code vorgenommen werden.
## 🖼️ Schnelle Inferenz
Für Super-Resolution von realen Videos:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /pfad/zum/stable-diffusion-2-1-base     \
--ram_ft_path /pfad/zur/DAPE.pth     \
--ram_path '/pfad/zur/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/pfad/zum/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /pfad/zum/model_checkpoint.pkl     \
--stages 1     \
-i /pfad/zu/eingabe_videos/     \
-o /pfad/zu/ergebnisse
```

### Zitate
Wenn unser Code Ihre Forschung oder Arbeit unterstützt, ziehen Sie bitte in Erwägung, unsere Publikation zu zitieren.
Die folgenden BibTeX-Referenzen können verwendet werden:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun und Shuaizheng Liu und Rongyuan Wu und Zhengqiang Zhang und Lei Zhang},
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