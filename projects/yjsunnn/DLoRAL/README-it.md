<div align="center">
<h2>Diffusione One-Step per la Super-Risoluzione Video Ricca di Dettagli e Temporalmente Consistente</h2>

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
        <img src="https://img.shields.io/badge/💡-Pagina%20del%20Progetto-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Video%20Dimostrativo-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/Spiegazione%202--Minuti-brightgreen?logo=YouTube&logoColor=white">
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Risultati Visivi">

</p>
## ⏰ Aggiornamento

- **2025.07.08**: Il codice di inferenza e i pesi pre-addestrati sono disponibili.
- **2025.06.24**: La pagina del progetto è disponibile, includendo un breve video esplicativo di 2 minuti, più risultati visivi e ricerche correlate.
- **2025.06.17**: Il repository è stato rilasciato.

:star: Se DLoRAL è utile per i tuoi video o progetti, ti preghiamo di lasciare una stella a questo repository. Grazie! :hugs:

😊 Potresti anche voler consultare i nostri lavori correlati:

1. **OSEDiff (NIPS2024)** [Paper](https://arxiv.org/abs/2406.08177) | [Code](https://github.com/cswry/OSEDiff/)  

   Algoritmo SR di immagini in tempo reale che è stato applicato alla serie OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Paper](https://arxiv.org/pdf/2412.03017) | [Code](https://github.com/csslc/PiSA-SR) 

   Esplorazione pionieristica del paradigma Dual-LoRA nella SR di immagini.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repo](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Una lista curata di risorse per la Video Super-Resolution (VSR) utilizzando Modelli di Diffusione.
## 👀 TODO
- [x] Rilasciare il codice di inferenza.
- [ ] Colab e interfaccia Huggingface per test convenienti (Presto!).
- [ ] Rilasciare il codice di addestramento.
- [ ] Rilasciare i dati di addestramento.


## 🌟 Panoramica del Framework

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Addestramento**: Uno schema di addestramento dinamico a doppio stadio alterna tra l’ottimizzazione della coerenza temporale (fase di consistenza) e il perfezionamento dei dettagli spaziali ad alta frequenza (fase di miglioramento) con un’interpolazione fluida della perdita per garantire la stabilità.

**Inferenza**: Durante l’inferenza, sia C-LoRA che D-LoRA vengono fusi nell’UNet di diffusione congelato, consentendo il miglioramento in un solo passaggio degli input di bassa qualità in output di alta qualità.
## 🔧 Dipendenze e Installazione

1. Clona il repository
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Installa i pacchetti dipendenti
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Scarica i Modelli 
#### Modelli Dipendenti
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> inserire in **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> inserire in **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> inserire in **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> inserire in **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pesi Preaddestrati](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> inserire in **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Ogni percorso può essere modificato secondo le proprie esigenze, e le modifiche corrispondenti devono essere applicate anche alla riga di comando e al codice.
## 🖼️ Inferenza Rapida
Per la Super-Risoluzione Video nel Mondo Reale:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /percorso/al/modello-stable-diffusion-2-1-base     \
--ram_ft_path /percorso/al/DAPE.pth     \
--ram_path '/percorso/al/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/percorso/al/modello-stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /percorso/al/model_checkpoint.pkl     \
--stages 1     \
-i /percorso/agli/input_videos/     \
-o /percorso/ai/risultati
```
### Citazioni
Se il nostro codice è utile per la tua ricerca o il tuo lavoro, ti preghiamo di citare il nostro articolo.
Di seguito sono riportati i riferimenti BibTeX:

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