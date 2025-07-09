<div align="center">
<h2>Jednoetapowa dyfuzja dla szczegółowego i czasowo spójnego super-rozdzielczości wideo</h2>

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
        <img src="https://img.shields.io/badge/💡-Strona%20projektu-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Film%20Demonstracyjny-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--minutowy%20wyjaśniacz-brightgreen?logo=YouTube&logoColor=white">
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Wyniki wizualne">

</p>

## ⏰ Aktualizacje

- **2025.07.08**: Kod do inferencji oraz wytrenowane wagi są dostępne.
- **2025.06.24**: Strona projektu jest dostępna, zawiera krótki 2-minutowy film wyjaśniający, więcej wyników wizualnych oraz powiązane badania.
- **2025.06.17**: Repozytorium zostało udostępnione.

:star: Jeśli DLoRAL jest pomocny w Twoich filmach lub projektach, prosimy o oznaczenie tego repozytorium gwiazdką. Dziękujemy! :hugs:

😊 Możesz również sprawdzić nasze powiązane prace:

1. **OSEDiff (NIPS2024)** [Artykuł](https://arxiv.org/abs/2406.08177) | [Kod](https://github.com/cswry/OSEDiff/)  

   Algorytm do SR obrazów w czasie rzeczywistym, który został zastosowany w serii OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Artykuł](https://arxiv.org/pdf/2412.03017) | [Kod](https://github.com/csslc/PiSA-SR) 

   Pionierska eksploracja paradygmatu Dual-LoRA w SR obrazów.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repozytorium](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Wyselekcjonowana lista zasobów dotyczących super-rozdzielczości wideo (VSR) z użyciem modeli dyfuzyjnych.
## 👀 DO ZROBIENIA
- [x] Udostępnienie kodu do wnioskowania.
- [ ] Colab i interfejs Huggingface dla wygodnych testów (Wkrótce!).
- [ ] Udostępnienie kodu treningowego.
- [ ] Udostępnienie danych treningowych.


## 🌟 Przegląd Frameworka

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**Trening**: Dynamiczny, dwustopniowy schemat treningowy naprzemiennie optymalizuje spójność czasową (etap konsystencji) oraz ulepsza szczegóły przestrzenne o wysokiej częstotliwości (etap ulepszania), z płynną interpolacją straty w celu zapewnienia stabilności.

**Wnioskowanie**: Podczas wnioskowania zarówno C-LoRA, jak i D-LoRA są scalane z zamrożonym modelem diffusion UNet, umożliwiając jednokrokowe ulepszanie danych wejściowych niskiej jakości do wyjść wysokiej jakości.
## 🔧 Zależności i instalacja

1. Sklonuj repozytorium
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Zainstaluj wymagane pakiety
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Pobierz modele
#### Wymagane modele
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> umieść w **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> umieść w **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> umieść w **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> umieść w **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> umieść w **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Każda ścieżka może być zmieniona zgodnie z własnymi wymaganiami, a odpowiednie zmiany powinny zostać również zastosowane w linii poleceń oraz w kodzie.
## 🖼️ Szybka Infernencja
Dla rzeczywistej super-rozdzielczości wideo:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /ścieżka/do/stable-diffusion-2-1-base     \
--ram_ft_path /ścieżka/do/DAPE.pth     \
--ram_path '/ścieżka/do/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/ścieżka/do/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /ścieżka/do/model_checkpoint.pkl     \
--stages 1     \
-i /ścieżka/do/input_videos/     \
-o /ścieżka/do/results
```
### Cytowania
Jeśli nasz kod pomógł w Twoich badaniach lub pracy, prosimy o cytowanie naszej publikacji.
Poniżej znajdują się odnośniki BibTeX:

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