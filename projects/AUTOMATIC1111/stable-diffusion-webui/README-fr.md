# Interface Web Stable Diffusion
Une interface web pour Stable Diffusion, implémentée avec la bibliothèque Gradio.

![](screenshot.png)

## Fonctionnalités
[Présentation détaillée des fonctionnalités avec images](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features) :
- Modes originaux txt2img et img2img
- Script d'installation et d'exécution en un clic (il faut quand même installer Python et Git)
- Outpainting
- Inpainting
- Color Sketch (croquis en couleur)
- Matrice de prompts
- Upscale Stable Diffusion
- Attention, spécification des parties du texte auxquelles le modèle doit prêter plus d'attention
    - un homme en `((smoking))` - mettra plus d'attention sur "smoking"
    - un homme en `(smoking:1.21)` - syntaxe alternative
    - sélectionnez du texte et appuyez sur `Ctrl+Up` ou `Ctrl+Down` (ou `Command+Up` ou `Command+Down` sur MacOS) pour ajuster automatiquement l'attention sur le texte sélectionné (code contribué par un utilisateur anonyme)
- Loopback, traitement img2img plusieurs fois
- Tracé X/Y/Z, pour générer un graphe 3D d'images avec différents paramètres
- Textual Inversion
    - autant d'embeddings que souhaité et noms personnalisés
    - utilisation de multiples embeddings avec différents nombres de vecteurs par token
    - fonctionne avec des nombres à virgule flottante en demi-précision
    - entraînement des embeddings sur 8 Go (aussi des retours de fonctionnement sur 6 Go)
- Onglet "Extras" avec :
    - GFPGAN, réseau de neurones pour corriger les visages
    - CodeFormer, outil de restauration du visage en alternative à GFPGAN
    - RealESRGAN, upscaler neuronal
    - ESRGAN, upscaler neuronal avec de nombreux modèles tiers
    - SwinIR et Swin2SR ([voir ici](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), upscalers neuronaux
    - LDSR, super résolution par diffusion latente
- Options de redimensionnement du ratio d'aspect
- Sélection de la méthode d'échantillonnage
    - Ajustement de la valeur eta du sampler (multiplicateur de bruit)
    - Options avancées de configuration du bruit
- Interruption du traitement à tout moment
- Prise en charge de cartes vidéo 4 Go (retours aussi sur 2 Go)
- Graines correctes pour les lots
- Validation en direct de la longueur des tokens du prompt
- Paramètres de génération
     - les paramètres utilisés pour générer une image sont enregistrés avec cette image
     - dans les chunks PNG pour PNG, dans l'EXIF pour JPEG
     - glisser l'image dans l'onglet PNG info pour restaurer les paramètres de génération et les copier automatiquement dans l'UI
     - désactivable dans les paramètres
     - glisser-déposer une image/texte-paramètres dans la boîte de prompt
- Bouton "Lire les paramètres de génération", charge les paramètres du prompt dans l'UI
- Page de paramètres
- Exécution de code Python arbitraire depuis l'UI (doit être lancé avec `--allow-code` pour activer)
- Astuces au survol de la souris pour la plupart des éléments UI
- Possibilité de modifier les valeurs par défaut/min/max/pas pour les éléments UI via un fichier de config texte
- Prise en charge du tiling, case à cocher pour générer des images carrelables comme des textures
- Barre de progression et aperçu en direct de la génération d'image
    - Possibilité d'utiliser un réseau de neurones séparé pour les aperçus, avec très peu de VRAM ou de calcul requis
- Négatif prompt, un champ texte supplémentaire pour spécifier ce que vous ne voulez pas voir dans l'image générée
- Styles, possibilité d'enregistrer une partie du prompt et de l'appliquer facilement via un menu déroulant
- Variations, générer la même image avec de petites différences
- Redimensionnement de graine, générer la même image à une résolution légèrement différente
- CLIP interrogator, bouton pour deviner le prompt à partir d'une image
- Édition de prompt, possibilité de changer le prompt en cours de génération, par exemple commencer avec une pastèque puis passer à une fille anime en cours de route
- Traitement par lots, traitement d'un groupe de fichiers via img2img
- Img2img Alternative, méthode inversée d'Euler pour le contrôle cross-attention
- Correction haute résolution, option pratique pour produire des images haute résolution en un clic sans les distorsions habituelles
- Rechargement des checkpoints à la volée
- Fusion de checkpoints, onglet permettant de fusionner jusqu'à 3 checkpoints en un seul
- [Scripts personnalisés](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) avec de nombreuses extensions communautaires
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), possibilité d'utiliser plusieurs prompts simultanément
     - séparez les prompts avec un `AND` majuscule
     - prend aussi en charge les poids de prompt : `un chat :1.2 AND un chien AND un pingouin :2.2`
- Pas de limite de tokens pour les prompts (la diffusion stable originale limite à 75 tokens)
- Intégration DeepDanbooru, création de tags style danbooru pour les prompts anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), augmentation majeure de la vitesse pour certaines cartes (ajouter `--xformers` aux arguments de ligne de commande)
- via extension : [Onglet Historique](https://github.com/yfszzx/stable-diffusion-webui-images-browser) : visualisez, gérez et supprimez facilement les images dans l'UI
- Option "Générer indéfiniment"
- Onglet Entraînement
     - options pour hypernetworks et embeddings
     - Prétraitement des images : recadrage, effet miroir, autotagging via BLIP ou deepdanbooru (pour l'anime)
- Clip skip
- Hypernetworks
- Loras (identiques aux Hypernetworks mais plus élégants)
- Une UI séparée où vous pouvez choisir, avec aperçu, les embeddings, hypernetworks ou Loras à ajouter à votre prompt
- Possibilité de sélectionner un autre VAE à charger dans les paramètres
- Estimation du temps restant dans la barre de progression
- API
- Prise en charge du [modèle d'inpainting dédié](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) de RunwayML
- via extension : [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), générer des images avec une esthétique spécifique via des embeddings d'images clip (implémentation de [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Prise en charge de [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - voir [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) pour les instructions
- Prise en charge de [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - voir [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) pour les instructions
- Plus aucune lettre interdite !
- Chargement des checkpoints au format safetensors
- Restriction de résolution assouplie : les dimensions de l'image générée doivent être un multiple de 8 (au lieu de 64)
- Licence désormais incluse !
- Réorganisation des éléments de l'UI depuis l'écran des paramètres
- Prise en charge de [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Installation et Exécution
Assurez-vous que les [dépendances requises](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) sont installées et suivez les instructions selon votre matériel :
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (recommandé)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPUs
- [CPUs Intel, GPUs Intel (intégrés et dédiés)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (page wiki externe)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (page wiki externe)

Alternativement, utilisez des services en ligne (comme Google Colab) :

- [Liste des services en ligne](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Installation sur Windows 10/11 avec GPU NVidia via le package de release
1. Téléchargez `sd.webui.zip` depuis [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) et extrayez son contenu.
2. Exécutez `update.bat`.
3. Exécutez `run.bat`.
> Pour plus de détails, voir [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Installation automatique sur Windows
1. Installez [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (les versions plus récentes de Python ne sont pas compatibles avec torch), en cochant "Add Python to PATH".
2. Installez [git](https://git-scm.com/download/win).
3. Téléchargez le dépôt stable-diffusion-webui, par exemple via la commande `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Exécutez `webui-user.bat` depuis l'Explorateur Windows en tant qu'utilisateur normal (non administrateur).

### Installation automatique sur Linux
1. Installez les dépendances :
```bash
# Basé sur Debian :
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Basé sur Red Hat :
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# Basé sur openSUSE :
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Basé sur Arch :
sudo pacman -S wget git python3
```
Si votre système est très récent, vous devez installer python3.11 ou python3.10 :
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # ne pas confondre avec le package python3.11

# Uniquement pour 3.11
# Puis configurez la variable d'environnement dans le script de lancement
export python_cmd="python3.11"
# ou dans webui-user.sh
python_cmd="python3.11"
```
2. Placez-vous dans le dossier où vous souhaitez installer le webui et exécutez la commande suivante :
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Ou clonez simplement le dépôt où vous le souhaitez :
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Exécutez `webui.sh`.
4. Consultez `webui-user.sh` pour les options.
### Installation sur Apple Silicon

Consultez les instructions [ici](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Contribution
Pour savoir comment contribuer à ce dépôt : [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Documentation

La documentation a été déplacée de ce README vers le [wiki du projet](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

Pour permettre à Google et autres moteurs de recherche d'indexer le wiki, voici un lien vers le [wiki crawlable](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) (pas destiné à la lecture humaine).

## Crédits
Les licences des codes utilisés sont disponibles dans l'écran `Paramètres -> Licences`, et aussi dans le fichier `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implémentant
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Idées d'optimisations - https://github.com/basujindal/stable-diffusion
- Optimisation de couche Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, idée originale pour l'édition de prompt.
- Optimisation de couche Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (à l'origine http://github.com/lstein/stable-diffusion)
- Optimisation sub-quadratique de couche Cross Attention - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (nous n'utilisons pas son code, mais ses idées)
- Idée pour SD upscale - https://github.com/jquesnelle/txt2imghd
- Génération de bruit pour outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Idée et code emprunté pour CLIP interrogator - https://github.com/pharmapsychotic/clip-interrogator
- Idée pour Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogateur pour diffuseurs anime https://github.com/KichangKim/DeepDanbooru
- Échantillonnage en précision float32 depuis un UNet float16 - marunine pour l'idée, Birch-san pour l'exemple d'implémentation Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- Conseil de sécurité - RyotaK
- Échantillonneur UniPC - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Script Gradio initial - posté sur 4chan par un utilisateur anonyme. Merci à l'utilisateur anonyme.
- (Vous)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---