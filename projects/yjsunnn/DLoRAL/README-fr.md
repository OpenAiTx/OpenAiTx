<div align="center">
<h2>Diffusion en une étape pour la super-résolution vidéo riche en détails et cohérente temporellement</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>The Hong Kong Polytechnic University, <sup>2</sup>Institut de Recherche OPPO
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Page%20Projet-or">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Vidéo%20Démo-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/Explication%202--Min-vertclair?logo=YouTube&logoColor=white">
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Résultats Visuels">

</p>
## ⏰ Mise à jour

- **2025.07.08** : Le code d'inférence et les poids pré-entraînés sont disponibles.
- **2025.06.24** : La page du projet est disponible, incluant une brève vidéo explicative de 2 minutes, plus de résultats visuels et des recherches pertinentes.
- **2025.06.17** : Le dépôt est publié.

:star: Si DLoRAL est utile pour vos vidéos ou projets, merci de donner une étoile à ce dépôt. Merci ! :hugs:

😊 Vous pouvez également consulter nos travaux connexes :

1. **OSEDiff (NIPS2024)** [Article](https://arxiv.org/abs/2406.08177) | [Code](https://github.com/cswry/OSEDiff/)  

   Algorithme SR d'image en temps réel qui a été appliqué à la série OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Article](https://arxiv.org/pdf/2412.03017) | [Code](https://github.com/csslc/PiSA-SR) 

   Exploration pionnière du paradigme Dual-LoRA en SR d'image.

3. **Awesome Diffusion Models for Video Super-Resolution** [Dépôt](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Une liste organisée de ressources pour la Super-Résolution Vidéo (VSR) utilisant les modèles de diffusion.
## 👀 À FAIRE
- [x] Publier le code d'inférence.
- [ ] Interface Colab et Huggingface pour des tests pratiques (Bientôt !).
- [ ] Publier le code d'entraînement.
- [ ] Publier les données d'entraînement.


## 🌟 Présentation du Cadre

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="Cadre DLoRAL">

</p>

**Entraînement** : Un schéma d'entraînement dynamique à deux étapes alterne entre l’optimisation de la cohérence temporelle (étape de cohérence) et l’amélioration des détails spatiaux à haute fréquence (étape d’amélioration), avec une interpolation douce de la perte pour assurer la stabilité.

**Inférence** : Lors de l’inférence, C-LoRA et D-LoRA sont fusionnés dans le UNet de diffusion gelé, permettant une amélioration en une seule étape des entrées de faible qualité en sorties de haute qualité.
## 🔧 Dépendances et Installation

1. Cloner le dépôt
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Installer les paquets dépendants
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Télécharger les modèles 
#### Modèles dépendants
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> à placer dans **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> à placer dans **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> à placer dans **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> à placer dans **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Poids pré-entraînés](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> à placer dans **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Chaque chemin peut être modifié selon vos propres besoins, et les modifications correspondantes doivent également être appliquées à la ligne de commande et au code.
## 🖼️ Inférence rapide
Pour la super-résolution vidéo en conditions réelles :

```
python src/test_DLoRAL.py     \
--pretrained_model_path /chemin/vers/stable-diffusion-2-1-base     \
--ram_ft_path /chemin/vers/DAPE.pth     \
--ram_path '/chemin/vers/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/chemin/vers/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /chemin/vers/model_checkpoint.pkl     \
--stages 1     \
-i /chemin/vers/vidéos_d'entrée/     \
-o /chemin/vers/résultats
```
### Citations
Si notre code aide vos recherches ou votre travail, veuillez envisager de citer notre article.
Les références BibTeX suivantes sont fournies :

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