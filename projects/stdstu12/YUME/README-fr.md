<div align="center">
<img src=assets/yume.png width="20%"/>
</div>

# Yume : Un modèle de génération de monde interactif

Yume est un projet à long terme visant à créer un monde interactif, réaliste et dynamique à partir de texte, d’images ou de vidéos.


<div align="center">




[![page du projet](https://img.shields.io/badge/Project-Page-2ea44f)](https://stdstu12.github.io/YUME-Project/)&nbsp;
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2507.17744-b31b1b.svg)](https://arxiv.org/abs/2507.17744)&nbsp;
[![modèle](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue)](https://huggingface.co/stdstu123/Yume-I2V-540P)&nbsp;
[![YouTube](https://badges.aleen42.com/src/youtube.svg)](https://www.youtube.com/watch?v=51VII_iJ1EM)&nbsp;

</div>

- Une recette de distillation pour video DiT.
- Code d’entraînement de type [FramePack-Like](https://github.com/lllyasviel/FramePack).
- Méthode de génération vidéo longue avec support de l’échantillonnage DDP/FSDP.



## 🔧 Installation
Le code est testé sur Python 3.10.0, CUDA 12.1 et A100.
```
./env_setup.sh fastvideo
pip install -r requirements.txt
```
Vous devez exécuter `pip install .` après chaque modification de code, ou alternativement, vous pouvez copier les fichiers modifiés directement dans votre environnement virtuel. Par exemple, si j'ai modifié `wan/image2video.py` et que mon environnement virtuel est `yume`, je peux copier le fichier dans :  
`envs/yume/lib/python3.10/site-packages/wan/image2video.py`.  

## 🚀 Inférence  

### ODE  
Pour la génération image-vidéo, nous utilisons `--jpg_dir="./jpg"` pour spécifier le répertoire des images d'entrée et `--caption_path="./caption.txt"` pour fournir les entrées de conditionnement textuel, où chaque ligne correspond à une instance de génération contrôlant une sortie vidéo de 2 secondes.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_jpg.sh 
```
Nous envisageons également de générer des vidéos en utilisant les données de `./val`, où `--test_data_dir="./val"` spécifie l'emplacement des données d'exemple.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample.sh 
```
### SDE
Nous effectuons un échantillonnage TTS, où `args.sde` contrôle l'utilisation de l'échantillonnage basé sur la SDE.
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_tts.sh 
```
Pour des résultats optimaux, nous recommandons de maintenir la distance réelle, le taux de changement angulaire (vitesse de rotation) et la vitesse de rotation de la vue dans une plage de 0,1 à 10.

Lignes directrices clés pour l’ajustement :
1. Lors de l’exécution de la caméra immobile (·), réduisez la valeur de la distance réelle
2. Lors de l’exécution de la personne immobile, diminuez les valeurs du taux de changement angulaire et de la vitesse de rotation de la vue

Notez que ces paramètres (distance réelle, taux de changement angulaire et vitesse de rotation de la vue) impactent les résultats de génération. Comme approche alternative, vous pouvez envisager de supprimer entièrement ces paramètres pour une opération simplifiée.



## 🎯 Entraînement & Distillation  
Pour l’entraînement du modèle, nous utilisons `args.MVDT` pour lancer le cadre MVDT, qui nécessite au moins 16 GPU A100. Charger T5 sur le CPU peut aider à économiser la mémoire GPU. Nous utilisons `args.Distil` pour activer la distillation adversariale.

```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/finetune/finetune.sh
```

## 🧱 Préparation du jeu de données
Veuillez consulter https://github.com/Lixsp11/sekai-codebase pour télécharger le jeu de données. Pour le format des données traitées, référez-vous à `./test_video`.
```
path_to_processed_dataset_folder/
├── Keys_None_Mouse_Down/ 
│   ├── video_id.mp4
│   ├── video_id.txt
├── Keys_None_Mouse_Up
│──  ...
└── Keys_S_Mouse_·
```
Le contenu du fichier TXT fourni enregistre soit les paramètres de contrôle du mouvement de la caméra, soit les données de keyframe d’animation, avec les définitions de champ suivantes :
```
Start Frame: 2 #Starting frame number (begins at frame 2 at origin video)

End Frame: 50 #Ending frame number

Duration: 49 frames #Total duration

Keys: W #Keyboard input

Mouse: ↓ #Mouse action
```
Dans `scripts/finetune/finetune.sh`, `args.root_dir` représente le `path_to_processed_dataset_folder`, et `args.root_dir` représente le chemin complet vers le dataset Sekai.


## 📑 Plan de Développement
- Traitement du dataset
  - [ ] Fournir des datasets traités
- Mise à jour du code
  - [ ] Support fp8
  - [ ] Meilleures méthodes de distillation
- ​​Mise à jour du modèle
  - [ ] Modèles quantifiés et distillés
  - [ ] Modèles pour génération en résolution 720p​

## 🤝 Contribution
Nous accueillons toutes les contributions.


## Remerciements
Nous avons appris et réutilisé du code des projets suivants :
- [FastVideo](https://github.com/hao-ai-lab/FastVideo)
- [diffusers](https://github.com/huggingface/diffusers)
- [HunyuanVideo-I2V](https://github.com/Tencent-Hunyuan/HunyuanVideo-I2V)
- [Wan2.1](https://github.com/Wan-Video/Wan2.1)
- [Skywork-Reward-V2](https://github.com/SkyworkAI/Skywork-Reward-V2)
- [MDT](https://github.com/sail-sg/MDT)
- [AddSR](https://github.com/NJU-PCALab/AddSR)

## Citation
Si vous utilisez Yume pour vos recherches, veuillez citer notre article :

```bibtex
@article{mao2025yume,
  title={Yume: An Interactive World Generation Model},
  author={Mao, Xiaofeng and Lin, Shaoheng and Li, Zhen and Li, Chuanhao and Peng, Wenshuo and He, Tong and Pang, Jiangmiao and Chi, Mingmin and Qiao, Yu and Zhang, Kaipeng},
  journal={arXiv preprint arXiv:2507.17744},
  year={2025}
}

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-09

---