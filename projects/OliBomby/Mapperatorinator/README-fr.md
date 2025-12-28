# Mapperatorinator

Essayez le modèle génératif [ici](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), ou MaiMod [ici](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Découvrez une démonstration vidéo [ici](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator est un cadre multi-modèles qui utilise des entrées de spectrogrammes pour générer des beatmaps osu! entièrement fonctionnelles pour tous les modes de jeu et [aider à modder les beatmaps](#maimod-the-ai-driven-modding-tool).
L’objectif de ce projet est de générer automatiquement des beatmaps osu! de qualité classable à partir de n’importe quelle chanson avec un haut degré de personnalisation.

Ce projet est construit sur [osuT5](https://github.com/gyataro/osuT5) et [osu-diffusion](https://github.com/OliBomby/osu-diffusion). En développant cela, j’ai passé environ 2500 heures de calcul GPU à travers 142 sessions sur ma 4060 Ti et des instances 4090 louées sur vast.ai.

#### Utilisez cet outil de manière responsable. Mentionnez toujours l’utilisation de l’IA dans vos beatmaps.

## Installation

Les instructions ci-dessous vous permettent de générer des beatmaps sur votre machine locale, alternativement vous pouvez l’exécuter dans le cloud avec le [notebook colab](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Cloner le dépôt

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Optionnel) Créer un environnement virtuel

Utilisez Python 3.10, les versions ultérieures pourraient ne pas être compatibles avec les dépendances.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Installer les dépendances

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Pour les GPU NVIDIA) ou [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Pour les GPU AMD sous Linux)
- [PyTorch](https://pytorch.org/get-started/locally/) : Assurez-vous de suivre le guide de démarrage afin d’installer `torch` et `torchaudio` avec le support GPU. Sélectionnez la version correcte de la plateforme de calcul que vous avez installée à l’étape précédente.

- ainsi que les dépendances Python restantes :

```sh
pip install -r requirements.txt
```

## Interface Web (Recommandée)

Pour une expérience plus conviviale, envisagez d'utiliser l'interface Web. Elle offre une interface graphique pour configurer les paramètres de génération, lancer le processus et surveiller la sortie.

### Lancer l'interface graphique

Naviguez jusqu'au répertoire cloné `Mapperatorinator` dans votre terminal et exécutez :

```sh
python web-ui.py
```
Cela démarrera un serveur web local et ouvrira automatiquement l’interface utilisateur dans une nouvelle fenêtre.

### Utilisation de l’interface graphique

- **Configurer :** Définissez les chemins d’entrée/sortie à l’aide des champs de formulaire et des boutons « Parcourir ». Ajustez les paramètres de génération comme le mode de jeu, la difficulté, le style (année, ID du mappeur, descripteurs), le timing, les fonctionnalités spécifiques (hitsounds, super timing), et plus encore, en reflétant les options de la ligne de commande. (Remarque : si vous fournissez un `beatmap_path`, l’interface déterminera automatiquement le `audio_path` et le `output_path` à partir de celui-ci, vous pouvez donc laisser ces champs vides)
- **Démarrer :** Cliquez sur le bouton « Démarrer l’inférence » pour lancer la génération de la beatmap.
- **Annuler :** Vous pouvez arrêter le processus en cours en utilisant le bouton « Annuler l’inférence ».
- **Ouvrir la sortie :** Une fois terminé, utilisez le bouton « Ouvrir le dossier de sortie » pour accéder rapidement aux fichiers générés.

L’interface Web agit comme une interface pratique autour du script `inference.py`. Pour des options avancées ou un dépannage, référez-vous aux instructions en ligne de commande.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Inférence en ligne de commande

Pour les utilisateurs qui préfèrent la ligne de commande ou ont besoin d’accéder à des configurations avancées, suivez les étapes ci-dessous. **Remarque :** Pour une interface graphique plus simple, veuillez consulter la section [Interface Web (Recommandée)](#web-ui-recommended) ci-dessus.

Exécutez `inference.py` en passant quelques arguments pour générer des beatmaps. Pour cela, utilisez la [syntaxe d’override Hydra](https://hydra.cc/docs/advanced/override_grammar/basic/). Consultez `configs/inference_v29.yaml` pour tous les paramètres disponibles.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```
Exemple :

```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## CLI interactive
Pour ceux qui préfèrent un flux de travail basé sur le terminal mais souhaitent une configuration guidée, le script CLI interactif est une excellente alternative à l'interface Web.

### Lancer la CLI
Naviguez vers le répertoire cloné. Vous devrez peut-être d'abord rendre le script exécutable.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### Utilisation de la CLI
Le script vous guidera à travers une série d'invites pour configurer tous les paramètres de génération, tout comme l'interface Web.

Il utilise une interface codée par couleur pour plus de clarté.
Il propose un menu avancé à sélection multiple pour choisir les descripteurs de style en utilisant les flèches et la barre d'espace.
Après avoir répondu à toutes les questions, il affichera la commande finale pour votre examen.
Vous pouvez alors confirmer pour l'exécuter directement ou annuler et copier la commande pour une utilisation manuelle.

## Conseils de génération

- Vous pouvez modifier `configs/inference_v29.yaml` et y ajouter vos arguments au lieu de les taper dans le terminal à chaque fois.
- Tous les descripteurs disponibles se trouvent [ici](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Fournissez toujours un argument d'année entre 2007 et 2023. Si vous le laissez inconnu, le modèle pourrait générer un style incohérent.
- Fournissez toujours un argument de difficulté. Si vous le laissez inconnu, le modèle pourrait générer une difficulté incohérente.
- Augmentez le paramètre `cfg_scale` pour accroître l'efficacité des arguments `mapper_id` et `descriptors`.
- Vous pouvez utiliser l'argument `negative_descriptors` pour guider le modèle à éviter certains styles. Cela ne fonctionne que si `cfg_scale > 1`. Assurez-vous que le nombre de descripteurs négatifs est égal au nombre de descripteurs.
- Si le style de votre chanson et le style de beatmap souhaité ne correspondent pas bien, le modèle pourrait ne pas suivre vos instructions. Par exemple, il est difficile de générer une beatmap à SR élevé et SV élevé pour une chanson calme.
- Si vous avez déjà les timings et les temps de kiai pour une chanson, vous pouvez les fournir au modèle pour augmenter grandement la vitesse et la précision d'inférence : utilisez les arguments `beatmap_path` et `in_context=[TIMING,KIAI]`.
- Pour remapper uniquement une partie de votre beatmap, utilisez les arguments `beatmap_path`, `start_time`, `end_time` et `add_to_beatmap=true`.
- Pour générer une difficulté invitée pour une beatmap, utilisez les arguments `beatmap_path` et `in_context=[GD,TIMING,KIAI]`.
- Pour générer des hitsounds pour une beatmap, utilisez les arguments `beatmap_path` et `in_context=[NO_HS,TIMING,KIAI]`.
- Pour générer uniquement le timing pour une chanson, utilisez les arguments `super_timing=true` et `output_type=[TIMING]`.

## MaiMod : l’outil de modding piloté par IA

MaiMod est un outil de modding pour les beatmaps osu! qui utilise les prédictions de Mapperatorinator pour détecter des fautes et incohérences potentielles que d’autres outils automatiques comme [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier) ne peuvent pas détecter.
Il peut détecter des problèmes tels que :
- Décalage incorrect ou motifs rythmiques erronés
- Points de timing inexactes
- Positions incohérentes des objets ou placements de nouveau combo
- Formes étranges de sliders
- Hitsounds ou volumes incohérents

Vous pouvez essayer MaiMod [ici](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb), ou l’exécuter localement :
Pour exécuter MaiMod localement, vous devez installer Mapperatorinator. Ensuite, lancez le script `mai_mod.py`, en spécifiant le chemin de votre beatmap avec l’argument `beatmap_path`.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Cela affichera les suggestions de modding dans la console, que vous pourrez ensuite appliquer manuellement à votre beatmap.  
Les suggestions sont ordonnées chronologiquement et regroupées par catégories.  
La première valeur dans le cercle indique le « surprisal », qui est une mesure de la surprise que le modèle a trouvée pour le problème, afin que vous puissiez prioriser les problèmes les plus importants.  

Le modèle peut faire des erreurs, surtout sur les problèmes à faible surprisal, donc vérifiez toujours les suggestions avant de les appliquer à votre beatmap.  
L’objectif principal est de vous aider à réduire l’espace de recherche des problèmes potentiels, afin que vous n’ayez pas à vérifier manuellement chaque objet de frappe dans votre beatmap.  

### Interface graphique MaiMod  
Pour lancer l’interface web MaiMod, vous devrez installer Mapperatorinator.  
Ensuite, exécutez le script `mai_mod_ui.py`. Cela démarrera un serveur web local et ouvrira automatiquement l’interface dans une nouvelle fenêtre :

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Vue d'ensemble

### Tokenisation

Mapperatorinator convertit les beatmaps osu! en une représentation intermédiaire d'événements pouvant être directement convertie vers et depuis des tokens.  
Elle inclut les objets à frapper, les hitsounds, les vitesses des sliders, les nouveaux combos, les points de timing, les temps kiai, et les vitesses de défilement taiko/mania.

Voici un petit exemple du processus de tokenisation :

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Pour économiser sur la taille du vocabulaire, les événements temporels sont quantifiés à des intervalles de 10 ms et les coordonnées de position sont quantifiées sur une grille de 32 pixels.

### Architecture du modèle  
Le modèle est essentiellement une couche autour du modèle [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration), avec des embeddings d'entrée personnalisés et une fonction de perte spécifique.  
La taille du modèle s'élève à 219 millions de paramètres.  
Ce modèle s'est avéré plus rapide et plus précis que T5 pour cette tâche.

Le schéma général des entrées et sorties du modèle est le suivant :

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Le modèle utilise des trames de spectrogrammes Mel comme entrée de l'encodeur, avec une trame par position d'entrée. La sortie du décodeur à chaque étape est une distribution softmax sur un vocabulaire discret et prédéfini d'événements. Les sorties sont rares, les événements ne sont nécessaires que lorsqu'un objet à frapper apparaît, au lieu d'annoter chaque trame audio.

### Format d'entraînement multitâche

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Avant le token SOS, il y a des tokens additionnels qui facilitent la génération conditionnelle. Ces tokens incluent le mode de jeu, la difficulté, l'ID du mappeur, l'année et d'autres métadonnées.  
Pendant l'entraînement, ces tokens ne sont pas accompagnés d'étiquettes, ils ne sont donc jamais produits par le modèle.  
Aussi pendant l'entraînement, il y a une chance aléatoire qu'un token de métadonnée soit remplacé par un token 'inconnu', ce qui permet en inférence d'utiliser ces tokens 'inconnus' pour réduire la quantité de métadonnées à fournir au modèle.

### Génération longue sans couture

La longueur de contexte du modèle est de 8,192 secondes. Cela ne suffit évidemment pas pour générer une beatmap complète, donc nous devons diviser la chanson en plusieurs fenêtres et générer la beatmap en petites parties.  
Pour s'assurer que la beatmap générée n'ait pas de jointures visibles entre les fenêtres, nous utilisons un recouvrement de 90 % et générons les fenêtres de manière séquentielle.  
Chaque fenêtre de génération, sauf la première, commence avec le décodeur pré-rempli jusqu'à 50 % de la fenêtre de génération avec des tokens des fenêtres précédentes.
Nous utilisons un processeur de logits pour nous assurer que le modèle ne peut pas générer de jetons temporels qui se trouvent dans les 50 % premiers de la fenêtre de génération.  
De plus, les 40 % derniers de la fenêtre de génération sont réservés pour la fenêtre suivante. Tous les jetons temporels générés dans cette plage sont traités comme des jetons EOS.  
Cela garantit que chaque jeton généré est conditionné par au moins 4 secondes de jetons précédents et 3,3 secondes d’audio futur à anticiper.  

Pour éviter la dérive des décalages lors de longues générations, des décalages aléatoires ont été ajoutés aux événements temporels dans le décodeur pendant l’entraînement.  
Cela l’oblige à corriger les erreurs de synchronisation en écoutant plutôt les attaques dans l’audio, et produit un décalage constamment précis.  

### Coordonnées affinées avec diffusion  

Les coordonnées de position générées par le décodeur sont quantifiées sur une grille de 32 pixels, donc par la suite nous utilisons la diffusion pour débruiter les coordonnées jusqu’aux positions finales.  
Pour cela, nous avons entraîné une version modifiée de [osu-diffusion](https://github.com/OliBomby/osu-diffusion) spécialisée uniquement sur les 10 % derniers du programme de bruit, et acceptant les jetons métadonnées plus avancés que Mapperatorinator utilise pour la génération conditionnelle.  

Puisque le modèle Mapperatorinator produit la SV des sliders, la longueur requise du slider est fixe quel que soit la forme du chemin des points de contrôle.  
Par conséquent, nous essayons de guider le processus de diffusion pour créer des coordonnées qui correspondent aux longueurs de sliders requises.  
Nous faisons cela en recalculant les positions finales du slider après chaque étape du processus de diffusion en fonction de la longueur requise et du chemin actuel des points de contrôle.  
Cela signifie que le processus de diffusion n’a pas de contrôle direct sur les positions finales du slider, mais peut toujours les influencer en modifiant le chemin des points de contrôle.  

### Post-traitement  

Mapperatorinator effectue un post-traitement supplémentaire pour améliorer la qualité du beatmap généré :  

- Affiner les coordonnées de position avec la diffusion.  
- Réajuster les événements temporels au tick le plus proche en utilisant les diviseurs de snap générés par le modèle.  
- Ajuster les chevauchements positionnels quasi parfaits.  
- Convertir les événements des colonnes mania en coordonnées X.  
- Générer les chemins des sliders pour les roulements de tambour taiko.  
- Corriger les grandes différences entre la longueur requise du slider et la longueur du chemin des points de contrôle.  

### Générateur de super timing  

Le générateur de super timing est un algorithme qui améliore la précision et l’exactitude du timing généré en inférant le timing de toute la chanson 20 fois et en faisant la moyenne des résultats.  
Cela est utile pour les chansons avec un BPM variable, ou les chansons avec des changements de BPM. Le résultat est presque parfait, avec seulement parfois une section nécessitant un ajustement manuel.  

## Entraînement  

L’instruction ci-dessous crée un environnement d’entraînement sur votre machine locale.  

### 1. Cloner le dépôt  

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Créer un jeu de données

Créez votre propre jeu de données en utilisant l'[application console Mapperator](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Elle nécessite un [jeton client OAuth osu!](https://osu.ppy.sh/home/account/edit) pour vérifier les beatmaps et obtenir des métadonnées supplémentaires. Placez le jeu de données dans un répertoire `datasets` à côté du répertoire `Mapperatorinator`.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Optionnel) Configuration de Weight & Biases pour la journalisation
Créez un compte sur [Weight & Biases](https://wandb.ai/site) et obtenez votre clé API depuis les paramètres de votre compte.
Ensuite, définissez la variable d'environnement `WANDB_API_KEY`, afin que le processus d'entraînement sache qu'il doit enregistrer avec cette clé.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Créer un conteneur docker
L'entraînement dans votre venv est également possible, mais nous recommandons d'utiliser Docker sur WSL pour de meilleures performances.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Configurer les paramètres et commencer l'entraînement

Toutes les configurations se trouvent dans `./configs/train/default.yaml`.  
Assurez-vous de définir correctement `train_dataset_path` et `test_dataset_path` vers votre jeu de données, ainsi que les indices de début et de fin des ensembles de cartes pour la séparation train/test.  
Le chemin est local au conteneur Docker, donc si vous avez placé votre jeu de données nommé `cool_dataset` dans le répertoire `datasets`, alors ce sera `/workspace/datasets/cool_dataset`.  

Je recommande de créer un fichier de configuration personnalisé qui remplace la configuration par défaut, afin de conserver un enregistrement de votre configuration d'entraînement pour la reproductibilité.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. Affinage LoRA

Vous pouvez également affiner un modèle pré-entraîné avec [LoRA](https://arxiv.org/abs/2106.09685) pour l’adapter à un style ou un mode de jeu spécifique.
Pour ce faire, adaptez `configs/train/lora.yaml` à vos besoins et lancez la configuration d’entraînement `lora` :

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Paramètres LoRA importants à considérer :
- `pretrained_path` : Chemin ou dépôt HF du modèle de base à affiner.
- `r` : Rang des matrices LoRA. Des valeurs plus élevées augmentent la capacité du modèle mais aussi la mémoire utilisée.
- `lora_alpha` : Facteur d'échelle pour les mises à jour LoRA.
- `total_steps` : Nombre total d'étapes d'entraînement. Ajustez-le en fonction de la taille de votre jeu de données.
- `enable_lora` : Indique s'il faut utiliser LoRA ou un affinage complet du modèle.

Lors de l'inférence, vous pouvez spécifier les poids LoRA à utiliser avec l'argument `lora_path`.
Cela peut être un chemin local ou un dépôt Hugging Face.

## Voir aussi
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Crédits

Remerciements particuliers à :
1. Les auteurs de [osuT5](https://github.com/gyataro/osuT5) pour leur code d'entraînement.
2. L'équipe Hugging Face pour leurs [outils](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) et [Richard Nagyfi](https://github.com/sedthh) pour l'échange d'idées.
4. [Marvin](https://github.com/minetoblend) pour avoir fait don de crédits d'entraînement.
5. La communauté osu! pour les beatmaps.

## Travaux associés

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) par Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) par kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) par OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) par gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) par sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) par jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---