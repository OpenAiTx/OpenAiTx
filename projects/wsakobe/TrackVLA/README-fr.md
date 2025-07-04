<p align="center">
<h1 align="center"><strong>TrackVLA : Suivi Visuel Incarné en Environnement Naturel</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Shaoan Wang</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Jiazhao Zhang</a>&emsp;
    Minghan Li&emsp;
    Jiahang Liu&emsp;
    Anqi Li&emsp; <br>
    Kui Wu&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Fangwei Zhong</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Junzhi Yu</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Zhizheng Zhang</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>He Wang</a>&emsp;
    <br>
    Université de Pékin&emsp; 
    Galbot&emsp; <br>
    Université Beihang&emsp;
    Université Normale de Pékin&emsp;
    Académie de Pékin d’Intelligence Artificielle&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Projet](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Vidéo](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 À propos
<strong><em>TrackVLA</em></strong> est un modèle vision-langage-action capable de reconnaissance d'objet et de suivi visuel simultanés, entraîné sur un jeu de données de 1,7 million d'échantillons. Il démontre une robustesse dans le suivi, un suivi longue durée et une généralisation inter-domaines dans divers environnements complexes.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Actualités

* [02/07/25] : L’EVT-Bench est désormais disponible.

## 💡 Installation
1. **Préparation de l'environnement conda**

   D'abord, vous devez installer [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). Une fois conda installé, créez un nouvel environnement :
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Installation de habitat-sim via conda**
   
   Vous devez installer habitat-sim v0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Installer habitat-lab depuis la source**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Préparer les jeux de données**

    Téléchargez le jeu de données Habitat Matterport 3D (HM3D) depuis [ici](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) et Matterport3D (MP3D) depuis [ici](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Déplacez ensuite le jeu de données dans `data/scene_datasets`. La structure du jeu de données est la suivante :
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    Ensuite, exécutez le code suivant pour obtenir les données pour les avatars humanoïdes :
      ```
      python download_humanoid_data.py
      ```


## 🧪 Évaluation
  Exécutez le script avec :

    bash eval.sh

  Les résultats seront enregistrés dans le dossier SAVE_PATH spécifié, qui inclura un répertoire de logs et un répertoire vidéo. Pour suivre les résultats pendant le processus d’évaluation, exécutez :
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Pour arrêter l'évaluation, utilisez :

    bash kill_eval.sh


## 📝 Liste des tâches à faire
- [x] Publication de l'article arXiv en mai 2025.
- [x] Publication de EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Publication du jeu de données à grande échelle pour le suivi visuel incarné.
- [ ] Publication du checkpoint et du code de TrackVLA.

## ✉️ Contact
Pour toute question, n'hésitez pas à envoyer un email à wangshaoan@stu.pku.edu.cn. Nous vous répondrons dès que possible.


## 🔗 Citation
Si notre travail vous est utile, veuillez le citer comme suit :

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Licence
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Licence Creative Commons" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Ce travail est sous licence <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---