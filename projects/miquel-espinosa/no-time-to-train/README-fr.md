<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=miquel-espinosa&project=no-time-to-train&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# 🚀 No Time to Train!  
### Segmentation d'instances par référence sans entraînement  
[![GitHub](https://img.shields.io/badge/%E2%80%8B-No%20Time%20To%20Train-black?logo=github)](https://github.com/miquel-espinosa/no-time-to-train)
[![Website](https://img.shields.io/badge/🌐-Project%20Page-grey)](https://miquel-espinosa.github.io/no-time-to-train/)
[![arXiv](https://img.shields.io/badge/arXiv-2507.02798-b31b1b)](https://arxiv.org/abs/2507.02798)

**État de l'art (Papers with Code)**

[**_SOTA 1-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-1-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-1-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 10-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-10-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-10-shot?p=no-time-to-train-training-free-reference)

[**_SOTA 30-shot_**](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference) | [![PWC](https://img.shields.io/endpoint.svg?url=https://paperswithcode.com/badge/no-time-to-train-training-free-reference/few-shot-object-detection-on-ms-coco-30-shot)](https://paperswithcode.com/sota/few-shot-object-detection-on-ms-coco-30-shot?p=no-time-to-train-training-free-reference)

</div>

---

> 🚨 **Mise à jour (22 juillet 2025) :** Des instructions pour les jeux de données personnalisés ont été ajoutées !
> 
> 🔔 **Mise à jour (16 juillet 2025) :** Le code a été mis à jour avec des instructions !

---

## 📋 Table des matières

- [🎯 Points forts](#-highlights)
- [📜 Résumé](#-abstract)
- [🧠 Architecture](#-architecture)
- [🛠️ Instructions d'installation](#️-installation-instructions)
  - [1. Cloner le dépôt](#1-clone-the-repository)
  - [2. Créer un environnement conda](#2-create-conda-environment)
  - [3. Installer SAM2 et DinoV2](#3-install-sam2-and-dinov2)
  - [4. Télécharger les jeux de données](#4-download-datasets)
  - [5. Télécharger les checkpoints SAM2 et DinoV2](#5-download-sam2-and-dinov2-checkpoints)
- [📊 Code d'inférence : Reproduire les résultats SOTA 30-shot sur Few-shot COCO](#-inference-code)
  - [0. Créer un ensemble de références](#0-create-reference-set)
  - [1. Remplir la mémoire avec les références](#1-fill-memory-with-references)
  - [2. Post-traiter la mémoire](#2-post-process-memory-bank)
  - [3. Inférence sur les images cibles](#3-inference-on-target-images)
  - [Résultats](#results)
- [🔍 Jeu de données personnalisé](#-custom-dataset)
  - [0. Préparer un jeu de données personnalisé ⛵🐦](#0-prepare-a-custom-dataset)
  - [0.1 Si seules les annotations bbox sont disponibles](#01-if-only-bbox-annotations-are-available)
  - [0.2 Convertir les annotations coco en fichier pickle](#02-convert-coco-annotations-to-pickle-file)
  - [1. Remplir la mémoire avec les références](#1-fill-memory-with-references)
  - [2. Post-traiter la mémoire](#2-post-process-memory-bank)
- [📚 Citation](#-citation)


## 🎯 Points forts
- 💡 **Sans entraînement** : Pas de fine-tuning, pas d'ingénierie de prompt—juste une image de référence.  
- 🖼️ **Basé sur la référence** : Segmentez de nouveaux objets avec seulement quelques exemples.  
- 🔥 **Performance SOTA** : Surpasse les approches sans entraînement précédentes sur COCO, PASCAL VOC et Cross-Domain FSOD.

**Liens :**
- 🧾 [**Article arXiv**](https://arxiv.org/abs/2507.02798)  
- 🌐 [**Site du projet**](https://miquel-espinosa.github.io/no-time-to-train/)  
- 📈 [**Papers with Code**](https://paperswithcode.com/paper/no-time-to-train-training-free-reference)

## 📜 Résumé

> Les performances des modèles de segmentation d'images ont historiquement été limitées par le coût élevé de la collecte de grandes quantités de données annotées. Le modèle Segment Anything (SAM) atténue ce problème initial à travers un paradigme de segmentation promptable et indépendant de la sémantique, mais nécessite encore des invites visuelles manuelles ou des règles complexes de génération d'invites dépendantes du domaine pour traiter une nouvelle image. Afin de réduire ce nouveau fardeau, notre travail s'intéresse à la tâche de segmentation d'objets lorsqu'un petit ensemble d'images de référence est fourni. Notre idée clé est de tirer parti de forts a priori sémantiques, tels qu'appris par les modèles fondamentaux, pour identifier les régions correspondantes entre une image de référence et une image cible. Nous constatons que ces correspondances permettent la génération automatique de masques de segmentation au niveau des instances pour des tâches en aval et nous implémentons nos idées via une méthode multi-étapes, sans entraînement, incorporant (1) la construction d'une mémoire ; (2) l'agrégation des représentations et (3) l'appariement des caractéristiques tenant compte de la sémantique. Nos expériences montrent des améliorations significatives sur les métriques de segmentation, menant à des performances de pointe sur COCO FSOD (36.8% nAP), PASCAL VOC Few-Shot (71.2% nAP50) et surpassant les méthodes sans entraînement existantes sur le benchmark Cross-Domain FSOD (22.4% nAP).

![cdfsod-results-final-comic-sans-min](https://github.com/user-attachments/assets/ab302c02-c080-4042-99fc-0e181ba8abb9)




## 🧠 Architecture

![training-free-architecture-comic-sans-min](https://github.com/user-attachments/assets/d84dd83a-505e-45a0-8ce3-98e1838017f9)


## 🛠️ Instructions d'installation

### 1. Cloner le dépôt

```bash
git clone https://github.com/miquel-espinosa/no-time-to-train.git
cd no-time-to-train
```
### 2. Créer un environnement conda

Nous allons créer un environnement conda avec les paquets requis.

```bash
conda env create -f environment.yml
conda activate no-time-to-train
```
### 3. Installer SAM2 et DinoV2

Nous allons installer SAM2 et DinoV2 à partir du code source.

```bash
pip install -e .
cd dinov2
pip install -e .
cd ..
```
### 4. Télécharger les jeux de données

Veuillez télécharger le jeu de données COCO et le placer dans `data/coco`

### 5. Télécharger les points de contrôle SAM2 et DinoV2

Nous allons télécharger exactement les points de contrôle SAM2 utilisés dans l'article.
(Notez cependant que les points de contrôle SAM2.1 sont déjà disponibles et pourraient offrir de meilleures performances.)


```bash
mkdir -p checkpoints/dinov2
cd checkpoints
wget https://dl.fbaipublicfiles.com/segment_anything_2/072824/sam2_hiera_large.pt
cd dinov2
wget https://dl.fbaipublicfiles.com/dinov2/dinov2_vitl14/dinov2_vitl14_pretrain.pth
cd ../..
```
## 📊 Code d'inférence

⚠️ Avertissement : Ceci est un code de recherche — attendez-vous à un peu de chaos !

### Reproduire les résultats SOTA à 30 essais sur Few-shot COCO

Définissez des variables utiles et créez un dossier pour les résultats :



```bash
CONFIG=./no_time_to_train/new_exps/coco_fewshot_10shot_Sam2L.yaml
CLASS_SPLIT="few_shot_classes"
RESULTS_DIR=work_dirs/few_shot_results
SHOTS=30
SEED=33
GPUS=4

mkdir -p $RESULTS_DIR
FILENAME=few_shot_${SHOTS}shot_seed${SEED}.pkl
```
#### 0. Créer un ensemble de référence


```bash
python no_time_to_train/dataset/few_shot_sampling.py \
        --n-shot $SHOTS \
        --out-path ${RESULTS_DIR}/${FILENAME} \
        --seed $SEED \
        --dataset $CLASS_SPLIT
```
#### 1. Remplir la mémoire avec des références


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode fill_memory \
                              --out_path ${RESULTS_DIR}/memory.ckpt \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --model.init_args.dataset_cfgs.fill_memory.memory_pkl ${RESULTS_DIR}/${FILENAME} \
                              --model.init_args.dataset_cfgs.fill_memory.memory_length $SHOTS \
                              --model.init_args.dataset_cfgs.fill_memory.class_split $CLASS_SPLIT \
                              --trainer.logger.save_dir ${RESULTS_DIR}/ \
                              --trainer.devices $GPUS
```
#### 2. Post-traitement de la banque de mémoire


```bash
python run_lightening.py test --config $CONFIG \
                              --model.test_mode postprocess_memory \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --ckpt_path ${RESULTS_DIR}/memory.ckpt \
                              --out_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --trainer.devices 1
```
#### 3. Inférence sur les images cibles


```bash
python run_lightening.py test --config $CONFIG  \
                              --ckpt_path ${RESULTS_DIR}/memory_postprocessed.ckpt \
                              --model.init_args.test_mode test \
                              --model.init_args.model_cfg.memory_bank_cfg.length $SHOTS \
                              --model.init_args.model_cfg.dataset_name $CLASS_SPLIT \
                              --model.init_args.dataset_cfgs.test.class_split $CLASS_SPLIT \
                              --trainer.logger.save_dir ${RESULTS_DIR}/ \
                              --trainer.devices $GPUS
```
Si vous souhaitez voir les résultats d'inférence en ligne (au fur et à mesure qu'ils sont calculés), décommentez les lignes 1746-1749 dans `no_time_to_train/models/Sam2MatchingBaseline_noAMG.py` [ici](https://github.com/miquel-espinosa/no-time-to-train/blob/main/no_time_to_train/models/Sam2MatchingBaseline_noAMG.py#L1746).
Ajustez le paramètre du seuil de score `score_thr` selon vos besoins pour voir plus ou moins d'instances segmentées.
Les images seront désormais enregistrées dans `results_analysis/few_shot_classes/`. L'image de gauche montre la vérité terrain, celle de droite montre les instances segmentées trouvées par notre méthode sans entraînement.

Notez que dans cet exemple, nous utilisons la division `few_shot_classes`, nous ne devons donc nous attendre qu'à voir des instances segmentées des classes de cette division (et non pas toutes les classes de COCO).

#### Résultats

Après avoir traité toutes les images du jeu de validation, vous devriez obtenir :


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.368

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.342
```
---

## 🔍 Jeu de données personnalisé

Nous fournissons les instructions pour exécuter notre pipeline sur un jeu de données personnalisé. Les formats d'annotation sont toujours au format COCO.

> **TLDR ;** Pour voir directement comment exécuter le pipeline complet sur des *jeux de données personnalisés*, consultez `scripts/matching_cdfsod_pipeline.sh` ainsi que des exemples de scripts pour les jeux de données CD-FSOD (par exemple `scripts/dior_fish.sh`)

### 0. Préparer un jeu de données personnalisé ⛵🐦

Imaginons que nous voulons détecter des **bateaux**⛵ et des **oiseaux**🐦 dans un jeu de données personnalisé. Pour utiliser notre méthode, il nous faudra :
- Au moins 1 image de référence *annotée* pour chaque classe (c'est-à-dire 1 image de référence pour bateau et 1 image de référence pour oiseau)
- Plusieurs images cibles pour trouver des instances des classes souhaitées.

Nous avons préparé un script d'exemple pour créer un jeu de données personnalisé avec des images coco, pour un scénario **1-shot**.
```bash
python scripts/make_custom_dataset.py
```
Cela créera un jeu de données personnalisé avec la structure de dossiers suivante :
```
data/my_custom_dataset/
    ├── annotations/
    │   ├── custom_references.json
    │   ├── custom_targets.json
    │   └── references_visualisations/
    │       ├── bird_1.jpg
    │       └── boat_1.jpg
    └── images/
        ├── 429819.jpg
        ├── 101435.jpg
        └── (all target and reference images)
```
**Visualisation des images de référence (1-shot) :**

| Image de référence 1-shot pour OISEAU 🐦 | Image de référence 1-shot pour BATEAU ⛵ |
|:---------------------------------------:|:----------------------------------------:|
| <img src="https://github.com/user-attachments/assets/e59e580d-a7db-42ac-b386-892af211fc85" alt="bird_1" width="500"/> | <img src="https://github.com/user-attachments/assets/f94ee025-ae37-4a45-9c3e-0cfe8f8cd2bc" alt="boat_1" width="500"/> |


### 0.1 Si seules des annotations bbox sont disponibles

Nous fournissons également un script pour générer des masques de segmentation au niveau instance en utilisant SAM2. Ceci est utile si vous ne disposez que d’annotations de boîtes englobantes pour les images de référence.


```bash
# Download sam_h checkpoint. Feel free to use more recent checkpoints (note: code might need to be adapted)
wget https://dl.fbaipublicfiles.com/segment_anything/sam_vit_h_4b8939.pth -O checkpoints/sam_vit_h_4b8939.pth
# Run automatic instance segmentation from ground truth bounding boxes.
python no_time_to_train/dataset/sam_bbox_to_segm_batch.py \
    --input_json data/my_custom_dataset/annotations/custom_references.json \
    --image_dir data/my_custom_dataset/images \
    --sam_checkpoint checkpoints/sam_vit_h_4b8939.pth \
    --model_type vit_h \
    --device cuda \
    --batch_size 8 \
    --visualize
```
**Images de référence avec masques de segmentation au niveau des instances (générés par SAM2 à partir des boîtes englobantes gt, 1-shot) :**

La visualisation des masques de segmentation générés est enregistrée dans `data/my_custom_dataset/annotations/custom_references_with_SAM_segm/references_visualisations/`.


| Image de référence 1-shot pour OISEAU 🐦 (segmentée automatiquement avec SAM) | Image de référence 1-shot pour BATEAU ⛵ (segmentée automatiquement avec SAM) |
|:---------------------------------:|:----------------------------------:|
| <img src="https://github.com/user-attachments/assets/65d38dc4-1454-43cd-9600-e8efc67b3a82" alt="bird_1_with_SAM_segm" width="500"/> | <img src="https://github.com/user-attachments/assets/43a558ad-50ca-4715-8285-9aa3268843c6" alt="boat_1_with_SAM_segm" width="500"/> |


### 0.2 Convertir les annotations coco en fichier pickle


```bash
python no_time_to_train/dataset/coco_to_pkl.py \
    data/my_custom_dataset/annotations/custom_references_with_segm.json \
    data/my_custom_dataset/annotations/custom_references_with_segm.pkl \
    1
```
### 1. Remplir la mémoire avec des références

Tout d'abord, définissez les variables utiles et créez un dossier pour les résultats. Pour une visualisation correcte des étiquettes, les noms de classes doivent être ordonnés par identifiant de catégorie comme dans le fichier json. Par exemple, `bird` a l'identifiant de catégorie `16`, `boat` a l'identifiant de catégorie `9`. Ainsi, `CAT_NAMES=boat,bird`.


```bash
DATASET_NAME=my_custom_dataset
DATASET_PATH=data/my_custom_dataset
CAT_NAMES=boat,bird
CATEGORY_NUM=2
SHOT=1
YAML_PATH=no_time_to_train/pl_configs/matching_cdfsod_template.yaml
PATH_TO_SAVE_CKPTS=./tmp_ckpts/my_custom_dataset
mkdir -p $PATH_TO_SAVE_CKPTS
```
Exécutez l’étape 1 :

```bash
python run_lightening.py test --config $YAML_PATH \
    --model.test_mode fill_memory \
    --out_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory.pth \
    --model.init_args.dataset_cfgs.fill_memory.root $DATASET_PATH/images \
    --model.init_args.dataset_cfgs.fill_memory.json_file $DATASET_PATH/annotations/custom_references_with_segm.json \
    --model.init_args.dataset_cfgs.fill_memory.memory_pkl $DATASET_PATH/annotations/custom_references_with_segm.pkl \
    --model.init_args.dataset_cfgs.fill_memory.memory_length $SHOT \
    --model.init_args.dataset_cfgs.fill_memory.cat_names $CAT_NAMES \
    --model.init_args.model_cfg.dataset_name $DATASET_NAME \
    --model.init_args.model_cfg.memory_bank_cfg.length $SHOT \
    --model.init_args.model_cfg.memory_bank_cfg.category_num $CATEGORY_NUM \
    --trainer.devices 1
```
### 2. Banque de mémoire post-traitement


```bash
python run_lightening.py test --config $YAML_PATH \
    --model.test_mode postprocess_memory \
    --ckpt_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory.pth \
    --out_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory_postprocessed.pth \
    --model.init_args.model_cfg.dataset_name $DATASET_NAME \
    --model.init_args.model_cfg.memory_bank_cfg.length $SHOT \
    --model.init_args.model_cfg.memory_bank_cfg.category_num $CATEGORY_NUM \
    --trainer.devices 1
```
### 3. Inférence sur les images cibles

Si `ONLINE_VIS` est réglé sur True, les résultats de prédiction seront sauvegardés dans `results_analysis/my_custom_dataset/` et affichés au fur et à mesure de leur calcul. NOTEZ que l'exécution avec la visualisation en ligne est beaucoup plus lente.

N'hésitez pas à modifier le seuil de score `VIS_THR` pour voir plus ou moins d'instances segmentées.

```bash
ONLINE_VIS=True
VIS_THR=0.4
python run_lightening.py test --config $YAML_PATH \
    --model.test_mode test \
    --ckpt_path $PATH_TO_SAVE_CKPTS/$DATASET_NAME\_$SHOT\_refs_memory_postprocessed.pth \
    --model.init_args.model_cfg.dataset_name $DATASET_NAME \
    --model.init_args.model_cfg.memory_bank_cfg.length $SHOT \
    --model.init_args.model_cfg.memory_bank_cfg.category_num $CATEGORY_NUM \
    --model.init_args.model_cfg.test.imgs_path $DATASET_PATH/images \
    --model.init_args.model_cfg.test.online_vis $ONLINE_VIS \
    --model.init_args.model_cfg.test.vis_thr $VIS_THR \
    --model.init_args.dataset_cfgs.test.root $DATASET_PATH/images \
    --model.init_args.dataset_cfgs.test.json_file $DATASET_PATH/annotations/custom_targets.json \
    --model.init_args.dataset_cfgs.test.cat_names $CAT_NAMES \
    --trainer.devices 1
```
### Résultats

Les métriques de performance (avec exactement les mêmes paramètres que les commandes ci-dessus) devraient être :


```
BBOX RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.478

SEGM RESULTS:
  Average Precision  (AP) @[ IoU=0.50:0.95 | area=   all | maxDets=100 ] = 0.458
```
Les résultats visuels sont enregistrés dans `results_analysis/my_custom_dataset/`. Notez que notre méthode fonctionne pour les faux négatifs, c'est-à-dire les images qui ne contiennent aucune instance des classes souhaitées.

*Cliquez sur les images pour agrandir ⬇️*

| Image cible avec des bateaux ⛵ (gauche GT, droite prédictions) | Image cible avec des oiseaux 🐦 (gauche GT, droite prédictions) |
|:----------------------:|:----------------------:|
| ![000000459673](https://github.com/user-attachments/assets/678dc15a-dd3b-49d5-9287-6290da16aa6b) | ![000000407180](https://github.com/user-attachments/assets/fe306e48-af49-4d83-ac82-76fac6c456d1) |

| Image cible avec des bateaux et des oiseaux ⛵🐦 (gauche GT, droite prédictions) | Image cible sans bateaux ni oiseaux 🚫 (gauche GT, droite prédictions) |
|:---------------------------------:|:----------------------------------:|
| ![000000517410](https://github.com/user-attachments/assets/9849b227-7f43-43d7-81ea-58010a623ad5) | ![000000460598](https://github.com/user-attachments/assets/7587700c-e09d-4cf6-8590-3df129c2568e) |


## 📚 Citation

Si vous utilisez ce travail, veuillez nous citer :


```bibtex
@article{espinosa2025notimetotrain,
  title={No time to train! Training-Free Reference-Based Instance Segmentation},
  author={Miguel Espinosa and Chenhongyi Yang and Linus Ericsson and Steven McDonagh and Elliot J. Crowley},
  journal={arXiv preprint arXiv:2507.02798},
  year={2025},
  primaryclass={cs.CV}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---