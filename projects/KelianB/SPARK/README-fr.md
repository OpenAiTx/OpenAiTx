<p align="center">
    <h1 align="center">SPARK : Capture de visage monoculaire personnalisée en temps réel et auto-supervisée</h1>
    <p align="center">
        <a href="mailto://kelian.baert@gmail.com"><strong>Kelian Baert</strong></a>
        ·
        <a href="https://sbharadwajj.github.io/"><strong>Shrisha Bharadwaj</strong></a>
        ·
        <a href="https://www.linkedin.com/in/fabien-castan/"><strong>Fabien Castan</strong></a>
        ·
        <a href="https://www.linkedin.com/in/benoitmaujean/"><strong>Benoit Maujean</strong></a>
        ·
        <a href="https://people.irisa.fr/Marc.Christie/"><strong>Marc Christie</strong></a>
        ·
        <a href="https://vabrevaya.github.io/"><strong>Victoria Fernandez Abrevaya</strong></a>
        ·
        <a href="https://boukhayma.github.io/"><strong>Adnane Boukhayma</strong></a>
    </p>
    <p align="center">
        <a href="https://technicolor.com">Technicolor</a> | <a href="https://is.mpg.de/">Institut Max Planck</a> | <a href="https://www.inria.fr/en/inria-centre-rennes-university">INRIA Rennes</a>
        <br>
        <strong>Articles de la conférence SIGGRAPH Asia 2024</strong>
    </p>
    <p align="center">
        <a href="https://kelianb.github.io/SPARK/" style="padding-left: 0.5rem;">
            <img src="https://img.shields.io/badge/Project-Page-blue?style=flat&logo=Google%20chrome&logoColor=blue" alt="Page du projet">
        </a>
        <a href="https://dl.acm.org/doi/10.1145/3680528">
            <img src="https://img.shields.io/badge/Paper-red" alt="PDF">
        </a>
        <a href="https://arxiv.org/abs/2409.07984">
            <img src="https://img.shields.io/badge/Arxiv-red" alt="PDF arxiv">
        </a>
    </p>
    <p align="center">
        <img src="https://raw.githubusercontent.com/KelianB/SPARK/main/assets/teaser.webp" width="98%" />
    </p>
</p>

## Citation

Si vous trouvez notre code ou article utile, veuillez citer comme suit :

```bibtex
@inproceedings{baert2024spark,
  title = {{SPARK}: Self-supervised Personalized Real-time Monocular Face Capture},
  author = {Baert, Kelian and Bharadwaj, Shrisha and Castan, Fabien and Maujean, Benoit and Christie, Marc and Abrevaya, Victoria and Boukhayma, Adnane},
  year = {2024},
  month = dec,
  booktitle = {SIGGRAPH Asia 2024 Conference Proceedings},
  articleno = {113},
  doi = {10.1145/3680528.3687704},
  isbn = {979-8-4007-1131-2/24/12},
  publisher = {Association for Computing Machinery},
  address = {New York, NY, USA},
  numpages = {12},
  url = {https://kelianb.github.io/SPARK/},
}
```
## Installation

<details>
    <summary>Détails</summary>

- Créez l'environnement en utilisant [setup.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./setup.sh).
- Exécutez [TrackerAdaptation/setup_submodules.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./TrackerAdaptation/setup_submodules.sh). Cela peut prendre quelques minutes.
- Liez FLAME de MultiFLARE à EMOCA : `ln TrackerAdaptation/submodules/EMOCA/assets/FLAME/geometry/generic_model.pkl MultiFLARE/assets/flame/flame2020.pkl`
    - Ceci équivaut à télécharger [FLAME](https://flame.is.tue.mpg.de/download.php) (version 2020), à le décompresser et à copier `generic_model.pkl` dans `./MultiFLARE/assets/flame/flame2020.pkl`.
- Obtenez le modèle de texture Basel Face Model adapté à FLAME. Malheureusement, nous ne sommes pas autorisés à distribuer cet espace de texture car la licence ne le permet pas. Veuillez donc utiliser l’outil de ce [répertoire](https://github.com/TimoBolkart/BFM_to_FLAME) pour convertir l’espace de texture vers FLAME. Placez le fichier de modèle de texture résultant dans `TrackerAdaptation/submodules/EMOCA/assets/FLAME/texture/FLAME_albedo_from_BFM.npz`.

SPARK a été testé avec des GPU NVIDIA RTX A5000 (24GB) ou RTX A4000 (16GB). Il est possible d’entraîner sur des GPU avec moins de mémoire en réduisant la taille du batch.

</details>

## Jeu de données

Veuillez vous référer au dépôt [MonoFaceCompute](https://github.com/KelianB/MonoFaceCompute) pour prétraiter vos propres données.

## Utilisation

SPARK est une approche en deux étapes. D’abord, exécutez [MultiFLARE](./MultiFLARE/) pour reconstruire un avatar facial 3D à partir de plusieurs vidéos. Ensuite, utilisez [TrackerAdaptation](./TrackerAdaptation/) pour adapter un tracker facial 3D existant à votre avatar pour un suivi en temps réel via l’apprentissage par transfert.

<details>
    <summary>Détails</summary>

### 1. MultiFLARE


```bash
cd MultiFLARE
python train.py --config configs/example.txt

# Export neutral mesh
python export_mesh.py --config configs/example.txt --resume 3000 --out_dir /tmp/example_mesh --tex_type albedo
```
Nous conseillons de commencer à partir du fichier de configuration exemple fourni et de modifier `input_dir`, `train_dir` et `output_dir`. Pour une liste complète de tous les paramètres, veuillez consulter [arguments.py](https://raw.githubusercontent.com/KelianB/SPARK/main/./MultiFLARE/arguments.py) ou la sortie de `python train.py --help`. Les paramètres peuvent être passés soit dans le fichier de configuration, soit en arguments de ligne de commande.

### 2. AdaptationSuivi


```bash
cd TrackerAdaptation
# DECA encoder + MultiFLARE decoder
python train.py --config configs/example_deca.txt
# EMOCA encoder + MultiFLARE decoder
python train.py --config configs/example_emoca.txt
# SMIRK encoder + MultiFLARE decoder (recommended!)
python train.py --config configs/example_smirk.txt
# EMOCA encoder + EMOCA decoder (baseline)
python train.py --config configs/example_emoca_baseline.txt

# Quantitative eval
python evaluate.py --config configs/example_smirk.txt --tracker_resume 3000 --frame_interval 5 --num_frames 64

# Visualization videos
python make_comparison_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 5 6 --n_frames 1000 --smooth_crops --framerate 24
python make_overlay_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 2 --out test_beard --texture /path/to/texture.png --n_frames 1000 --smooth_crops --framerate 24
```

</details>

## Informations sur la licence

Le code dans ce dépôt est soumis à plusieurs licences.

1. **Code original** (Technicolor Group & INRIA Rennes)
   - Tout le code dans ce dépôt, sauf indication contraire, est sous licence [CC BY-NC-SA](./LICENSE).

2. **Code tiers** (Institut Max Planck pour les systèmes intelligents)
   - Emplacement : `./MultiFLARE/flame`, `./MultiFLARE/flare`, `./TrackerAdaptation/submodules`
   - Ces répertoires contiennent du code de l’Institut Max Planck, avec quelques modifications. Veuillez lire attentivement la [Licence MPI](./LICENSE_MPI) et noter que celle-ci est uniquement disponible pour des **fins de recherche scientifique non commerciale**.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---