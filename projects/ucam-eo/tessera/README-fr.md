# Embeddings Temporels des Spectres de Surface pour la Représentation et l'Analyse de la Terre (TESSERA) [CVPR2026]
<div align="center">
    <a href="#readme-top">
        <img src="https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/banner.png" alt="Bannière">
    </a>
    <br />
    <p align="center">
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">Signaler des Bugs 🛠️</a> &nbsp;&nbsp;•&nbsp;&nbsp;
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">Demander des Fonctionnalités 💡</a>
    </p>
</div>

<!--  ![Version](https://img.shields.io/badge/version-alpha-red) -->
![Version PyPI](https://img.shields.io/pypi/v/geotessera?label=Version%20PyPI&color=blue)
![Licence](https://img.shields.io/badge/License-MIT-blue.svg)


# Table des Matières

  - En apprendre plus sur TESSERA
      - [Introduction](#introduction)
      - [Articles](#Papers)
      - [Podcast](https://www.satellite-image-deep-learning.com/p/tessera-a-temporal-foundation-model)
      - [Présentations](#presentations)
      - [Licence](#License)
  - Utilisation de TESSERA
      - [Politique d'Utilisation Acceptable](#AUP)
      - [Accès aux Embeddings Pré-calculés](#global-embeddings-access)
      - [Créer Vos Propres Embeddings](#creating-your-own-embeddings)
      - [Tâches en Aval](#downstream-tasks)
      - [Groupe d'Utilisateurs TESSERA](#tessera-users-group)
  - Informations complémentaires
      - [Équipe](#team)
      - [Contact](#contact)
      - [Citation](#citation)
      - [Remerciements](#acknowledgments)
      - [Historique des Étoiles](#star-history)

# En apprendre plus sur TESSERA
## Introduction

La télédétection par satellite permet une large gamme d'applications en aval, notamment la cartographie des habitats, le comptage du carbone, et les stratégies de conservation et d'utilisation durable des terres. Cependant, les séries temporelles satellitaires sont volumineuses et souvent corrompues par les nuages, ce qui les rend difficiles à exploiter : la capacité de la communauté scientifique à extraire des informations exploitables est souvent limitée par la rareté des ensembles de données d'entraînement étiquetés et la charge computationnelle liée au traitement des données temporelles. L'idée clé de notre travail, due à [Dr. Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/), est que forcer l'alignement des embeddings d'auto-encodeurs dérivés de deux échantillons aléatoires sans nuages de séries temporelles satellitaires en utilisant [Barlow Twins](https://proceedings.mlr.press/v139/zbontar21a/zbontar21a.pdf) aboutit à un embedding représentant l'ensemble de la série temporelle, y compris les observations manquantes.

Cette idée est au cœur de TESSERA, un modèle fondation ouvert qui préserve les signaux spectral-temporels par pixel dans des représentations latentes de 128 dimensions à une résolution de 10 mètres à l'échelle mondiale. Il utilise l'apprentissage auto-supervisé pour résumer des pétaoctets de données d'observation de la Terre. Nous comparons notre travail avec des modèles spécifiques à la tâche à la pointe et d'autres modèles fondation dans cinq tâches en aval diverses et constatons que TESSERA égalise ou dépasse ces références. En préservant les signaux phénologiques temporels habituellement perdus dans les approches conventionnelles, TESSERA permet de nouvelles perspectives sur la dynamique des écosystèmes, les systèmes alimentaires agricoles et la détection des changements environnementaux. De plus, notre implémentation open-source soutient la reproductibilité et l'extensibilité, tandis que le design préservant la vie privée permet aux chercheurs de maintenir la souveraineté des données.

À notre connaissance, TESSERA est sans précédent par sa facilité d'utilisation, son échelle et sa précision : aucun autre modèle fondation ne fournit des sorties prêtes à l'analyse, est ouvert, et offre une couverture globale annuelle à 10 m de résolution en utilisant uniquement des caractéristiques spectral-temporelles au niveau pixel.

Voici quelques résultats de visualisation de la carte de représentation TESSERA (en utilisant les trois premiers canaux comme RGB) :

![repr_demo](https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/repr_demo.png)

## Articles
Voici les publications et prépublications liées à TESSERA, listées chronologiquement :
* Lisaius, M. C., Blake, A., Keshav, S., & Atzberger, C. (2024). Utilisation de Barlow Twins pour créer des représentations à partir de séries temporelles de télédétection corrompues par les nuages. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing, 17, 13162–13168. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing. https://doi.org/10.1109/JSTARS.2024.3426044

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav (2025), [TESSERA : Temporal Embeddings of Surface Spectra for Earth Representation and Analysis](https://arxiv.org/abs/2506.20380), À paraître, CVPR 2026. Reprise ArXiv. https://arxiv.org/abs/2506.20380

* Lisaius, M. C., Blake, A., Atzberger, C., & Keshav, S. (2026). Vers une meilleure classification des types de cultures : une approche compacte d’embedding adaptée aux petits champs. Accepté dans les actes de la Conférence ISPRS 2026. Société Internationale de Photogrammétrie et de Télédétection.

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav, (2026) [Applications du modèle fondation géospatial TESSERA à diverses tâches de cartographie environnementale](http://ssrn.com/abstract=6142416), prépublication SSRN. http://ssrn.com/abstract=6142416
  
* Young, R., & Keshav, S. (2026). Interpolation des estimations de biomasse GEDI avec quantification calibrée de l'incertitude, prépublication arXiv. https://doi.org/10.48550/ArXiv.2601.16834
  
* Lisaius, M. C., Keshav, S., Blake, A., & Atzberger, C. (2026). Classification des types de cultures basée sur l’embedding dans le bassin arachidier du Sénégal (arXiv:2601.16900). Prépublication ArXiv. https://doi.org/10.48550/arXiv.2601.16900

* Ball, J.G.C, Wicklein J.A. , Feng, Z., Knezevic, J., Jaffer, S., Atzberger, C., Dalponte, M., et Coomes, D. Les modèles fondation géospatiaux permettent une cartographie efficace des espèces d’arbres dans les forêts tempérées de montagne, BioArxiv, https://doi.org/10.64898/2026.02.23.707022

## Présentations

* [Présentation de TESSERA lors du séminaire AI for Good](https://www.youtube.com/live/9yrpwFrwbGY), Frank Feng, 22 janvier 2026
* [TESSERA : embeddings globaux FAIR pré-calculés par pixel pour la représentation et l'analyse de la Terre](https://www.grss-ieee.org/event/tessera-precomputed-fair-global-pixel-embeddings-for-earth-representation-and-analysis/) Conférence IEEE GRSS, Frank Feng, 12 décembre 2025
* [Résumé en 2 diapositives (PPTX)](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) pour CRI Flash Talks, S. Keshav, 7 octobre 2025
* Présentation du modèle fondation (PPTX) pour la réunion des groupes d'écologie, Université de Cambridge, DAB, James Ball, 6 octobre 2025
* [Présentation de TESSERA axée sur les applications écologiques](https://www.dropbox.com/scl/fi/8xvanw3kk586lp1ld31kd/maryland_talk_slides.pdf?rlkey=osyhtk1kc2pcj81iel0u32lub&st=6kedpwv6&dl=0) (PDF) Université du Maryland, Frank Feng, 1er octobre 2025
* [Présentation de TESSERA](https://www.dropbox.com/scl/fi/0rsq4wkao3c7fgwljd8ec/JCU-tesserav2.pptx?rlkey=ccutcxgwi068c09n20t1yi549&st=13if23b3&dl=0) (PPTX) Université James Cook, S. Keshav, 29 septembre 2025
* [Présentation de TESSERA](https://www.dropbox.com/scl/fi/1p7nabvlvie8fzyomkx7w/dab_talk_slides.pdf?rlkey=ym3d44o80mbrdkasyzct9kzi5&st=ozvwczs7&dl=0) Université de Cambridge, DAB, Frank Feng, 20 mai 2025
* [Apprentissage auto-supervisé pour l'observation de la Terre](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) (PPTX) S. Keshav, Exeter, avril 2025

## Licence

Le logiciel TESSERA est publié sous la licence MIT standard. Les embeddings et les poids des modèles sont publiés sous la licence [CC0](https://creativecommons.org/publicdomain/zero/1.0/) : essentiellement,  
ils peuvent être utilisés librement à des fins commerciales et non commerciales. Bien que nous n'exigions pas légalement d'attribution,  
nous la demandons toutefois.

# Utilisation de TESSERA

<a id="global-embeddings-access"></a>

## Accès aux Embeddings via GeoTessera (recommandé)

Nous avons généré des embeddings pour le globe entier à une résolution de 10m pour 2024.  
Ils peuvent être téléchargés et utilisés pour des applications en aval, économisant un temps et des ressources computationnelles importants, en utilisant  
la bibliothèque [GeoTessera](https://github.com/ucam-eo/geotessera).  
Nous étendrons progressivement la couverture vers les années précédentes jusqu’en 2017. La carte de couverture actuelle est ci-dessous :

<img src="https://github.com/ucam-eo/tessera-coverage-map/blob/main/map.png"> 

## Groupe d’Utilisateurs TESSERA

Les utilisateurs intéressés sont invités à rejoindre nos groupes de discussion [Zulip](https://eeg.zulipchat.com/login/).


# Création de Vos Propres Embeddings

Si vous souhaitez utiliser notre logiciel pour créer vos propres embeddings, veuillez suivre les instructions ci-dessous. Notez qu’il s’agit d’une tâche computationnellement exigeante et que vous aurez besoin d’un accès à des ressources computationnelles et de stockage significatives.

## Exigences Matérielles

### 1. Exigences de Stockage

L’exécution de ce pipeline nécessite un espace de stockage important. Bien que le pipeline supprime certains fichiers intermédiaires après traitement, les fichiers bruts Sentinel-2 et Sentinel-1 téléchargés occuperont néanmoins un espace disque considérable. Par exemple, traiter une zone de 100km×100km de 2022 pour produire une carte de représentation TESSERA (résolution 10m) nécessite au moins 1 To de stockage.

### 2. Exigences en Mémoire

Nous utilisons des données prétraitées, initialement issues de Microsoft Planetary Computer. Cependant, la prochaine génération d’embeddings utilisera OPERA de ASF DAAC. Dans les deux cas, la majorité du prétraitement géospatial a déjà été effectué. Nous recommandons néanmoins d’avoir au moins 128 Go de RAM.

### 3. CPU et GPU

Le pipeline n’a pas d’exigences strictes en CPU et GPU, mais plus de cœurs CPU et des GPU plus puissants peuvent considérablement accélérer l’inférence. Lors du traitement d’une zone de 110km×110km en 2022, nos tests utilisant un CPU 128 cœurs et un seul GPU NVIDIA A30 pour l’inférence (CPU et GPU traitant chacun 50 % de l’inférence) ont pris environ 10 heures pour se terminer.

### 4. Système d'exploitation

Pour le pipeline de prétraitement des données, nous supportons presque tous les systèmes Linux. Pour Windows, nous recommandons d'utiliser WSL. Nous ne supportons pas MacOS pour le moment.

Pour la partie inférence du modèle, nous l'avons seulement testée sous Linux et Windows WSL, et cela fonctionne.

## Prétraitement des données

### Vue d'ensemble
_**Nous recommandons vivement de parcourir rapidement l'ensemble du tutoriel avant d'exécuter le pipeline.**_

À cette étape, nous empilons une année complète de données Sentinel-1 et Sentinel-2 selon la dimension temporelle pour générer un composite. Pour Sentinel-2, la forme du composite est (T,H,W,B), où T est le nombre d'observations valides dans l'année, et B est le nombre de bandes (nous avons sélectionné 10 bandes). Pour Sentinel-1, nous avons extrait les données des orbites ascendantes et descendantes. En prenant l'orbite ascendante comme exemple, la forme du composite est (T',H,W,B'), où T' est le nombre d'observations ascendantes valides dans l'année, et B' est 2 car nous n'obtenons que les bandes VV et VH.

Nous avons initialement obtenu les données Sentinel-1 et Sentinel-2 depuis le Planetary Computer de Microsoft :
- Source des données Sentinel-1 : https://planetarycomputer.microsoft.com/dataset/sentinel-1-rtc
- Source des données Sentinel-2 : https://planetarycomputer.microsoft.com/dataset/sentinel-2-l2a

La nouvelle génération d'embeddings utilisera OPERA de ASF DAAC : 
- Source des données Sentinel-1 :  https://registry.opendata.aws/nasa-operal2rtc-s1v1/ 
- Source des données Sentinel-2 : https://registry.opendata.aws/sentinel-2-l2a-cogs/

Actuellement, notre pipeline n'accepte que des entrées au format TIFF. La résolution du TIFF de la zone d'intérêt (ROI) peut varier (par exemple, 30m), mais le pipeline **générera toujours des sorties Sentinel-1 et Sentinel-2 à la `RESOLUTION` configurée** (par défaut 10m) tout en conservant **l'étendue/les limites de la ROI identiques**. Pour les zones valides de la ROI dans le TIFF, la valeur est 1 ; sinon, c'est 0. Si vous avez seulement un shapefile, cela convient aussi - nous fournissons un script `convert_shp_to_tiff.py`.

### Télécharger le code source

Commencez par créer un répertoire de travail vide :

```bash
mkdir tessera_project
cd tessera_project
git clone https://github.com/ucam-eo/tessera.git
```
Pour faciliter l'exploitation du pipeline, nous recommandons de placer le répertoire de sortie des données au même niveau que `tessera_infer` et `tessera_preprocessing` :


```
tessera_project
 ┣ tessera_infer
 ┣ tessera_preprocessing
 ┣ my_data
   ┣ roi.shp (your shapefile)
   ┗ roi.tiff (we recommend generating this using convert_shp_to_tiff.py)
```

Le fichier `roi.tiff` peut être généré en utilisant `convert_shp_to_tiff.py` situé dans `tessera_preprocessing/convert_shp_to_tiff.py`. Pour l’utiliser, spécifiez simplement le chemin vers votre fichier shapefile dans la fonction principale, et il produira un TIFF portant le même nom dans le même répertoire.

⚠️Avis : _Si votre ROI est relativement grand, par exemple 100 km × 100 km, nous recommandons fortement de pré-découper le TIFF en sections plus petites ne dépassant pas 20 km × 20 km. Traitez ensuite chaque petit fichier TIFF séquentiellement dans la chaîne de traitement. Un ROI excessivement grand peut provoquer des problèmes avec les fournisseurs de tuiles en backend_

### Environnement Python

Nous avons besoin de certains paquets de traitement géographique (heureusement, nous n’utiliserons pas GDAL, car configurer cet environnement est un cauchemar) et de quelques paquets d’apprentissage automatique (PyTorch, mais vous devrez l’installer vous-même car le matériel varie selon les ordinateurs). Nous avons mis quelques paquets courants dans `requirements.txt`, que vous pouvez installer comme suit :

```bash
pip install -r requirements.txt
```
Remarque : Si vous êtes dans un environnement géré, vous devrez peut-être d'abord installer un venv, en utilisant 
```bash
python3 -m venv venv
source venv/bin/activate
```

### Configuration du script

Tout d’abord, naviguez vers le dossier `tessera_preprocessing` :

```bash
cd tessera_preprocessing
```

Puis modifiez le fichier s1_s2_downloader.sh pour indiquer le fichier TIFF de la ZOI, les répertoires de sortie et temporaires, ainsi que la source des données :

```bash
# === Basic Configuration ===
INPUT_TIFF="/absolute/path/to/your/data_dir/roi.tiff"
OUT_DIR="/absolute/path/to/your/data_dir"

export TEMP_DIR="/absolute/path/to/your/temp_dir"     # Temporary file directory

mkdir -p "$OUT_DIR"

# Python environment path
PYTHON_ENV="/absolute/path/to/your/python_env/bin/python"

# === Sentinel-1 & Sentinel-2 Processing Configuration ===
YEAR=2022 # Range [2017-2025]
RESOLUTION=10.0  # Output resolution (meters). ROI TIFF can be any resolution; extent is preserved.

# === Data Source Configuration ===
# mpc: Microsoft Planetary Computer (sentinel-1-rtc, sentinel-2-l2a)
# aws: AWS Open Data backends (S1=OPERA RTC-S1 via ASF/CMR + ASF Earthdata Cloud COGs, S2=Earth-search Sentinel-2 L2A COGs)
DATA_SOURCE="mpc"   # choices: mpc/aws
```

Note : `RESOLUTION` contrôle la taille des pixels de sortie. Le pipeline maintient les limites du ROI fixes et rééchantillonne le masque ROI dans la grille de sortie.

### Identifiants AWS (nécessaires uniquement lorsque `DATA_SOURCE="aws"`)
Sentinel-2 sur Earth-search est public et **ne nécessite pas d’identifiants**.

Sentinel-1 OPERA RTC-S1 est accessible via ASF Earthdata Cloud (COG via HTTPS). Vous avez besoin d’un jeton Earthdata Login :
- **Créez un compte Earthdata** : via [NASA Earthdata Login](https://urs.earthdata.nasa.gov/home).
- **Approuvez l’application** : Après avoir enregistré votre compte, vous pouvez aller dans l’onglet Applications et ajouter Alaska Satellite Facility Data Access à la liste des applications approuvées.
- **Obtenez un jeton EDL Bearer / JWT** en cliquant sur **Generate Token** et stockez-le localement (ne pas le committer).

Recommandé (simple + explicite) :

```bash
nano ~/.edl_bearer_token
# paste token, save+exit (Ctrl-O Enter, then Ctrl-X)
chmod 600 ~/.edl_bearer_token
```

Le téléchargeur AWS S1 utilisera ce jeton pour lire les COGs depuis ASF Earthdata Cloud.

Si vous souhaitez récupérer des identifiants S3 temporaires (avancé ; généralement non requis pour ce pipeline), consultez les instructions ASF :
- `https://cumulus.asf.alaska.edu/s3credentialsREADME`

En dessous de la configuration ci-dessus, il y a des configurations supplémentaires que vous pouvez modifier en fonction des performances de votre ordinateur.

Tout d'abord, donnez la permission à `s1_s2_downloader.sh` :

```bash
chmod +x s1_s2_downloader.sh
```

Ensuite, nous pouvons exécuter :

```bash
bash s1_s2_downloader.sh
```

En raison des conditions réseau, le traitement de certaines tuiles peut expirer. Notre script inclut une gestion sophistiquée des délais d'attente pour éviter ces problèmes. Cependant, parfois, certaines tuiles peuvent encore échouer. Exécuter à nouveau la commande ci-dessus résout généralement cela.

Si toutes les données Sentinel-1 et Sentinel-2 sont générées correctement, elles peuvent être empilées selon la dimension temporelle. Pour cette étape, nous utilisons deux exécutables générés en Rust, ce qui la rend très rapide. Vous pouvez ouvrir `s1_s2_stacker.sh` et modifier ce qui suit :

```bash
# === Basic Configuration ===
BASE_DIR="/absolute/path/to/your/data_dir"
OUT_DIR="${BASE_DIR}/data_processed"
DOWNSAMPLE_RATE=1
```

Normalement, nous ne modifions pas `DOWNSAMPLE_RATE`, ce qui l'empêche d'effectuer un sous-échantillonnage lors de l'empilement. Le `BASE_DIR` dans l'extrait ci-dessus est le même que le `OUT_DIR` que vous avez modifié dans `s1_s2_downloader.sh`.

De même, donnez la permission à `s1_s2_stacker.sh` :

```bash
chmod +x s1_s2_stacker.sh
```

Ensuite, vous pouvez exécuter l'empilement :

```bash
bash s1_s2_stacker.sh
```

Après réussite, vous obtiendrez des fichiers `.npy` dans `/absolute/path/to/your/data_dir/data_processed`. Généralement, ces fichiers `.npy` sont assez volumineux, nous allons donc les découper en unités plus petites et plus maniables.

Exécutez :

```bash
python dpixel_retiler.py \
    --tiff_path /absolute/path/to/your/data_dir/roi.tif \
    --d_pixel_dir /absolute/path/to/your/data_dir/data_processed \
    --patch_size 500 \
    --out_dir /absolute/path/to/your/data_dir/retiled_d_pixel \
    --num_workers 16 \
    --overwrite \
    --block_size 2000
```

Vous pouvez modifier vous-même les valeurs de `patch_size` et `block_size` ci-dessus. La configuration ci-dessus est une configuration recommandée pour un TIFF de forme (5000,5000) et une résolution de 10m.

Si le code ci-dessus s'exécute sans problème, vous pouvez obtenir des sous-dossiers dans `my_data/retiled_d_pixel`.

## Inférence

### Aperçu

Une fois le prétraitement des données terminé, nous pouvons commencer l'inférence. Avant de continuer, veuillez vérifier s'il y a des sous-dossiers dans le dossier `my_data/retiled_d_pixel` comme :
```
retiled_d_pixel
 ┣ 0_3500_500_4000
 ┣ 0_4000_500_4500
 ┣ 0_4500_500_5000
 ┣ 0_5000_500_5500
 ┣ 0_5500_500_6000
 ┣ 0_6000_500_6500
```
Chaque sous-dossier doit contenir les fichiers suivants :

```
0_3500_500_4000
 ┣ bands.npy
 ┣ doys.npy
 ┣ masks.npy
 ┣ roi.tiff
 ┣ sar_ascending.npy
 ┣ sar_ascending_doy.npy
 ┣ sar_descending.npy
 ┗ sar_descending_doy.npy
```

Si ces fichiers existent, vous pouvez commencer l'inférence. Sinon, vérifiez si la première étape s'est déroulée avec succès.

L'inférence nécessite PyTorch. Étant donné que chaque système peut avoir des versions CUDA légèrement différentes, nous ne pouvons pas fournir un environnement Python encapsulé dans Docker comme nous l'avons fait pour le prétraitement des données. Heureusement, l'environnement Python pour l'inférence est beaucoup plus simple à configurer que pour le prétraitement des données, car il n'utilise pas de packages de traitement géographique tels que GDAL ou SNAP.

### Préparation de Pytorch

Si vous n'avez pas installé Pytorch, vous pouvez vous référer aux étapes ci-dessous. Sinon, vous pouvez ignorer cette section.

Tout d'abord, vérifiez la version CUDA de votre système :

```bash
nvidia-smi
```

Puis rendez-vous sur https://pytorch.org/ et sélectionnez la version appropriée à installer en fonction de votre version CUDA, par exemple :

```bash
pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu128
```

### Poids du modèle

Ensuite, téléchargez les poids du modèle depuis [Google Drive](https://drive.google.com/drive/folders/18RPptbUkCIgUfw1aMdMeOrFML_ZVMszn?usp=sharing) et placez le fichier `.pt` dans le répertoire `tessera_infer/checkpoints` :

```
tessera_infer
 ┗ checkpoints
     ┗ best_model_fsdp_20250427_084307.pt
 ┗ configs
 ┗ src
```

_**Notez que le point de contrôle mentionné ci-dessus est un modèle en phase précoce, qui génère nativement des embeddings en float32. Par conséquent, ce modèle n’est pas celui utilisé pour générer les embeddings en int8 dans la bibliothèque geotessera. Nous déploierons bientôt le point de contrôle spécifique qui a été utilisé pour créer les embeddings geotessera dans l’ensemble du pipeline.**_

### Configurer le script Bash

Pour simplifier la configuration de l’inférence, nous fournissons `tessera_infer/infer_all_tiles.sh`. Vous n’avez qu’à modifier quelques paramètres :

a. Répertoire de données de base :
```bash
BASE_DATA_DIR="your_data_directory"
```
Ceci est votre dossier de stockage de données, identique à `BASE_DATA_DIR` dans le bash précédent, par exemple, `/maps/usr/tessera_project/my_data`

b. Environnement Python :
```bash
export PYTHON_ENV="your_python_path"
```
Écrivez ici le chemin absolu vers votre environnement Python, par exemple, `/home/user/anaconda3/envs/tessera_env/bin/python`

c. Répartition CPU/GPU :
```bash
CPU_GPU_SPLIT="1:1"  # Format: CPU:GPU ratio
```
Le script prend en charge l'inférence simultanée utilisant à la fois le CPU et le GPU. Ce ratio spécifie la proportion de `retiled_patches` que chaque appareil traitera. La valeur par défaut est 1:1 (répartition équitable). Pour une inférence uniquement GPU, définissez à 0:1.

d. Paramètres liés au CPU

```bash
MAX_CONCURRENT_PROCESSES_CPU=20
```
Nombre maximum de processus CPU pour l'inférence de tuiles. Par exemple, si réglé sur 20, il traitera 20 tuiles simultanément.

```bash
AVAILABLE_CORES=$((TOTAL_CPU_CORES / 2)) # Use 50% of the cores
```
Nombre de cœurs CPU à utiliser. Veuillez modifier cette valeur si nécessaire pour éviter de consommer trop de ressources CPU !

e. Paramètres liés au GPU :
```bash
MAX_CONCURRENT_PROCESSES_GPU=1
```
Nombre maximal de processus GPU pour l'inférence. Si le système ne dispose que d'un seul GPU, réglez ceci sur 1.

```bash
GPU_BATCH_SIZE=1024  # Larger for GPU, if this takes too much memory, reduce it
```
Nombre d'échantillons à traiter simultanément lors de l'inférence PyTorch. Si cette valeur consomme trop de mémoire GPU ou provoque une erreur OOM sur le GPU, veuillez la réduire en conséquence.

f. Autres Paramètres
D'autres paramètres sont disponibles pour la configuration. Veuillez les ajuster selon vos besoins.

### Démarrer l'Inference

Une fois tout prêt, rendez-vous dans le dossier `tessera_infer` :

```bash
cd tessera_infer
```

Puis donnez la permission à `infer_all_tiles.sh` :

```bash
chmod +x infer_all_tiles.sh
```

Ensuite, exécutez-le :

```bash
bash infer_all_tiles.sh
```

Si cela réussit, vous devriez voir des journaux comme :

```
(base) zf281@daintree:/scratch/zf281/tessera_project/tessera_infer$ bash infer_all_tiles.sh
[INFO] Total CPU cores: 256, Using: 192
[INFO] CPU:GPU split ratio = 1:1 (total: 2)

==== SETUP DIRECTORIES ====
[SUCCESS] Created necessary directories

==== SCANNING TILES ====
[INFO] Tile directory: /scratch/zf281/jovana/retiled_d_pixel
[INFO] Output directory: /scratch/zf281/jovana/representation_retiled
[SUCCESS] Found 226 tiles total
[INFO] Sample tiles:
  - 0_3500_500_4000
  - 0_4000_500_4500
  - 0_4500_500_5000
  - ...
```

En même temps, un dossier `logs` sera généré dans le dossier `tessera_infer` avec des journaux plus détaillés pour chaque processus CPU et GPU.

### Assembler la Carte de Représentation Finale

L'inférence prend généralement beaucoup de temps, selon la taille de votre ROI et les performances matérielles. Une fois terminée, vous pouvez trouver de nombreux fichiers `.npy` dans `my_data/representation_retiled` :

```
representation_retiled
 ┣ 0_3500_500_4000.npy
 ┣ 0_4000_500_4500.npy
 ┣ 0_4500_500_5000.npy
 ┣ 0_5000_500_5500.npy
 ┣ 0_5500_500_6000.npy
 ┣ 0_6000_500_6500.npy
 ┣ 0_6500_500_7000.npy
 ┣ 0_7000_500_7500.npy
 ┣ 1000_0_1500_500.npy
 ┣ 1000_1000_1500_1500.npy
 ┣ 1000_1500_1500_2000.npy
 ┣ 1000_2000_1500_2500.npy
```
La dernière étape consiste à les assembler à l'aide de `tessera_infer/stitch_tiled_representation.py` :


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /path/to/d_pixel_retiled \
--representation_retiled_path /path/to/representation_retiled \
--downstream_tiff /path/to/downstream.tiff \
--out_dir /path/to/output_directory
```
Par exemple :


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /maps/usr/tessera_project/my_data/d_pixel_retiled \
--representation_retiled_path /maps/usr/tessera_project/my_data/representation_retiled \
--downstream_tiff /maps/usr/tessera_project/my_data/downstream.tiff \
--out_dir /maps/usr/tessera_project/my_data
```
Enfin, vous obtiendrez une carte de représentation assemblée dans le répertoire `my_data` avec la forme (H,W,128), où H et W correspondent à votre `roi.tiff` initial. La carte de représentation est un tableau NumPy. Si vous souhaitez la convertir en TIFF pour la visualiser dans un logiciel comme QGIS, vous pouvez utiliser le script `tessera_infer/convert_npy2tiff.py`. Modifiez simplement la fonction principale avec :


```python
npy_path = "/maps/usr/tessera_project/my_data/stitched_representation.npy"  # Change to the actual npy file path
ref_tiff_path = "/maps/usr/tessera_project/my_data/roi.tiff"  # Change to the actual reference tiff file path
out_dir = "/maps/usr/tessera_project/my_data/"  # Change to the actual output directory
```

## Tâches en aval

Si vous souhaitez reproduire les tâches en aval présentées dans l'article, vous pouvez visiter https://github.com/ucam-eo/tessera-downstream-task. De nombreux exemples y sont fournis.

# Informations supplémentaires

## Équipe

### Faculté de Cambridge
* [S. Keshav](https://svr-sk818-web.cl.cam.ac.uk/keshav/wiki/index.php/Main_Page)
* [Anil Madhavapeddy](https://anil.recoil.org)
* [Sadiq Jaffer](https://toao.com)
* [David Coomes](https://www.plantsci.cam.ac.uk/directory/david-coomes)

### Postdoctorant
* James Ball
  
### Doctorants
* Madeleine Lisaius
* Zhengpeng (Frank) Feng
* Robin Young
* Jovana Knezevic

### Étudiants de premier cycle
* Zejia Yang (étudiant Part II, travaillant avec Frank Feng sur le pré-entraînement MAE des extracteurs de caractéristiques spatiales)

### Stagiaires
* Kenzy Soror (U. Waterloo, travaillant avec Robin Young)
* Artyom Gabtraupov (U. Waterloo, travaillant avec Robin Young)
* Gabriel Mahler (U. Cambridge, travaillant avec Anil Madhavapeddy et Silviu Petrovan sur les [habitats et le suivi des hérissons](https://anil.recoil.org/ideas/hedgehog-mapping))
* Leyu Pan (Imperial College, travaillant avec Frank Feng sur les embeddings textuels générés à partir d’OSM)

### Collaborateurs
* [Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/?originalSubdomain=at), dClimate Labs
* [Andrew Blake](https://en.wikipedia.org/wiki/Andrew_Blake_(computer_scientist)), Mantle Labs

### Visiteurs
* Silja Sormunnen, Université Aalto, Finlande
* Isabel Mansley (U. Edinburgh, travaillant avec David Coomes et Anil Madhavapeddy sur la [cartographie des habitats en Écosse](https://anil.recoil.org/ideas/cairngorms-connect-habitats)

## Contact

Veuillez adresser vos questions techniques à Frank Feng (zf281@cam.ac.uk) ou les poser sur notre [forum Zulip](https://eeg.zulipchat.com/login/). Les questions non techniques peuvent être envoyées au Prof. S. Keshav (sk818@cam.ac.uk).

## Citation

Si vous utilisez TESSERA dans vos recherches, veuillez citer l’[article arXiv](https://arxiv.org/abs/2506.20380) :

```bibtex
@misc{feng2025tesseratemporalembeddingssurface,
      title={TESSERA: Temporal Embeddings of Surface Spectra for Earth Representation and Analysis}, 
      author={Zhengpeng Feng et al.},
      year={2025},
      eprint={2506.20380},
      archivePrefix={arXiv},
      primaryClass={cs.LG},
      url={https://arxiv.org/abs/2506.20380}, 
}
```

## Remerciements
Nous souhaitons exprimer notre gratitude à UKRI et à l'équipe du superordinateur [DAWN](https://www.hpc.cam.ac.uk/d-w-n) de Cambridge, pour leur soutien généreux dans ce projet. Nous remercions également le soutien de [AMD](https://www.amd.com/en.html), [Vultr](https://www.vultr.com/), de la [Dirac High Performance Computing Facility](https://dirac.ac.uk), du [Microsoft AI For Good Lab](https://www.microsoft.com/en-us/research/group/ai-for-good-research-lab/), du Dr Robert Sansom, de [dClimate](https://www.dclimate.net/), et d'[Amazon Web Services (AWS)](https://aws.amazon.com/) dans le cadre de leur programme AWS Open Data (https://opendata.aws/). Ce travail n'aurait pas été possible sans leur soutien, leurs ressources informatiques et leur assistance technique. 

## Historique des Étoiles
[![Graphique de l'Historique des Étoiles](https://api.star-history.com/svg?repos=ucam-eo/tessera&type=Date)](https://www.star-history.com/#ucam-eo/tessera&Date)

## AUP

### Conditions d'Utilisation et Directives Éthiques de TESSERA

### Licence

Les données et embeddings TESSERA sont mis à disposition sous la **Licence Creative Commons 0 Internationale [CC-0](https://creativecommons.org/public-domain/cc0/)**.  
Cela signifie que vous êtes libre de :

* **Partager** — copier et redistribuer le matériel sur tout support ou format
* **Adapter** — remixer, transformer et construire sur le matériel pour toute finalité, même commerciale

### Objectif et Usages Prévus

TESSERA a été développé pour faire progresser la recherche scientifique et soutenir la surveillance environnementale, la conservation, l'agriculture durable et la compréhension des systèmes terrestres. Nous avons conçu cet outil pour permettre :

* La recherche scientifique et l’éducation
* La surveillance environnementale et la conservation
* L’analyse agricole et de la sécurité alimentaire
* La recherche sur le changement climatique et la planification de l’adaptation
* L’utilisation durable des terres et la gestion des ressources
* Des applications d’intérêt public bénéficiant à la société et à l’environnement

### Directives Éthiques

Bien que la licence CC0 autorise un usage large, nous encourageons vivement les utilisateurs à considérer les implications éthiques de leur travail. Ces directives éthiques sont consultatives et n’imposent pas de restrictions légalement contraignantes. Nous demandons aux utilisateurs de :

**Agir de manière responsable :**
* Prendre en compte les implications sur la vie privée lors de l’analyse de lieux spécifiques
* Respecter les droits et la dignité des communautés concernées
* Être attentif aux préoccupations potentielles d’usage double

**Être transparent :**
* Représenter avec précision les caractéristiques des données (résolution annuelle, résolution spatiale de 10 m)  
* Reconnaître les limites dans vos applications  
* Ne pas déformer les capacités de TESSERA  

**Soutenir un Impact Positif :**  
* Considérer comment votre travail contribue au bénéfice sociétal  
* Impliquer les communautés concernées lorsque c’est approprié  
* Partager les résultats qui font avancer les connaissances publiques  

### Caractéristiques des Données  

Les utilisateurs doivent comprendre que TESSERA fournit :  
* **Résolution temporelle annuelle** — les données représentent des résumés annuels, pas une surveillance en temps réel ou à haute fréquence  
* **Résolution spatiale de 10 mètres** — adaptée à l’analyse à l’échelle du paysage  
* **Incorporations spatio-temporelles spectrales** — représentations compressées, pas d’images brutes  

Veuillez représenter ces caractéristiques avec exactitude dans votre travail.  

### Normes Communautaires  

Nous encourageons une utilisation responsable et accueillons les retours de la communauté. Si vous avez des préoccupations concernant des applications potentielles ou des suggestions pour améliorer ces directives, veuillez nous contacter.  

Nous nous réservons le droit de mettre à jour ces directives en fonction des retours de la communauté et des considérations émergentes, bien que ces mises à jour n’affectent pas rétroactivement la licence CC-0 sous laquelle les données sont publiées.  

### Contact  

Pour questions ou retours : Email sk818@cam.ac.uk  

---  

*Dernière mise à jour : 25 février 2026*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---