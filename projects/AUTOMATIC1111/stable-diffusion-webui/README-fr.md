# Interface web Stable Diffusion  
Une interface web pour Stable Diffusion, implémentée avec la bibliothèque Gradio.  

![](https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/screenshot.png)  

## Fonctionnalités  
[Présentation détaillée des fonctionnalités avec images](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features) :  
- Modes txt2img et img2img originaux  
- Script d'installation et d'exécution en un clic (mais vous devez toujours installer python et git)  
- Outpainting  
- Inpainting  
- Croquis en couleur  
- Matrice de prompts  
- Mise à l’échelle Stable Diffusion  
- Attention, spécifiez les parties du texte auxquelles le modèle doit prêter plus d’attention  
    - un homme en `((smoking))` - prêtera plus d’attention au smoking  
    - un homme en `(smoking:1.21)` - syntaxe alternative  
    - sélectionnez le texte et appuyez sur `Ctrl+Up` ou `Ctrl+Down` (ou `Command+Up` ou `Command+Down` si vous êtes sur MacOS) pour ajuster automatiquement l’attention au texte sélectionné (code contribué par un utilisateur anonyme)  
- Bouclage, exécutez le traitement img2img plusieurs fois  
- Tracé X/Y/Z, une façon de dessiner un graphique tridimensionnel d’images avec différents paramètres  
- Inversion textuelle  
    - ayez autant d’embeddings que vous le souhaitez et utilisez les noms que vous voulez pour eux  
    - utilisez plusieurs embeddings avec différents nombres de vecteurs par token  
    - fonctionne avec des nombres flottants en demi-précision  
    - entraînez les embeddings sur 8 Go (des rapports indiquent aussi que 6 Go fonctionnent)  
- Onglet Extras avec :  
    - GFPGAN, réseau neuronal qui corrige les visages  
    - CodeFormer, outil de restauration de visage en alternative à GFPGAN  
    - RealESRGAN, réseau neuronal pour mise à l’échelle  
    - ESRGAN, réseau neuronal pour mise à l’échelle avec beaucoup de modèles tiers  
    - SwinIR et Swin2SR ([voir ici](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), réseaux neuronaux pour mise à l’échelle  
    - LDSR, mise à l’échelle super résolution par diffusion latente  
- Options de redimensionnement du rapport d’aspect  
- Sélection de la méthode d’échantillonnage  
    - Ajustez les valeurs eta du sampleur (multiplicateur de bruit)  
    - Options avancées de réglage du bruit  
- Interruption du traitement à tout moment  
- Support des cartes vidéo 4 Go (des rapports indiquent aussi que 2 Go fonctionnent)  
- Correction des seeds pour les lots  
- Validation en direct de la longueur des tokens du prompt  
- Paramètres de génération  
     - les paramètres utilisés pour générer les images sont sauvegardés avec l’image  
     - dans des chunks PNG pour PNG, dans EXIF pour JPEG  
     - possibilité de glisser l’image vers l’onglet info PNG pour restaurer les paramètres de génération et les copier automatiquement dans l’interface  
     - peut être désactivé dans les paramètres  
     - glisser-déposer une image/paramètres-texte dans la zone de prompt  
- Bouton Lire les Paramètres de Génération, charge les paramètres dans la zone de prompt de l’interface  
- Page de paramètres  
- Exécution de code python arbitraire depuis l’interface (doit être lancé avec `--allow-code` pour activer)  
- Astuces au survol pour la plupart des éléments UI  
- Possibilité de changer les valeurs par défaut/mix/max/step des éléments UI via un fichier de configuration texte  
- Support du tuilage, case à cocher pour créer des images pouvant être tuilées comme des textures  
- Barre de progression et aperçu de génération d’image en direct  
    - Peut utiliser un réseau neuronal séparé pour produire des aperçus avec presque aucune exigence en VRAM ou calcul  
- Prompt négatif, un champ texte supplémentaire permettant de lister ce que vous ne voulez pas voir dans l’image générée  
- Styles, une façon de sauvegarder une partie du prompt et de l’appliquer facilement via un menu déroulant plus tard  
- Variations, une façon de générer la même image mais avec de petites différences  
- Redimensionnement des seeds, une façon de générer la même image mais à une résolution légèrement différente  
- Interrogateur CLIP, un bouton qui tente de deviner le prompt d’après une image  
- Édition de prompt, une façon de changer le prompt en cours de génération, par exemple commencer par une pastèque et passer à une fille anime en cours de route  
- Traitement par lots, traitement d’un groupe de fichiers en utilisant img2img  
- Alternative img2img, méthode Euler inversée de contrôle de l’attention croisée  
- Correction haute résolution, option de commodité pour produire des images haute résolution en un clic sans distorsions habituelles  
- Rechargement des checkpoints à chaud  
- Fusionneur de checkpoints, un onglet qui permet de fusionner jusqu’à 3 checkpoints en un seul  
- [Scripts personnalisés](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) avec de nombreuses extensions de la communauté  
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), une façon d’utiliser plusieurs prompts à la fois  
     - séparez les prompts avec `AND` en majuscules  
     - supporte aussi les poids pour les prompts : `un chat :1.2 AND un chien AND un pingouin :2.2`  
- Pas de limite de tokens pour les prompts (Stable Diffusion original autorise jusqu’à 75 tokens)  
- Intégration DeepDanbooru, crée des tags style danbooru pour les prompts anime  
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), augmentation majeure de vitesse pour certaines cartes : (ajoutez `--xformers` aux arguments de la ligne de commande)  
- via extension : [Onglet Historique](https://github.com/yfszzx/stable-diffusion-webui-images-browser) : visualisez, dirigez et supprimez les images facilement depuis l’interface  
- Option génération infinie  
- Onglet entraînement  
     - options hyperréseaux et embeddings  
     - Prétraitement des images : découpage, miroir, autotagging via BLIP ou deepdanbooru (pour anime)  
- Clip skip  
- Hyperréseaux  
- Loras (comme les hyperréseaux mais plus esthétiques)  
- Interface séparée où vous pouvez choisir, avec aperçu, quels embeddings, hyperréseaux ou Loras ajouter à votre prompt  
- Possibilité de charger un VAE différent depuis l’écran des paramètres  
- Temps estimé de complétion dans la barre de progression  
- API  
- Support du modèle [inpainting dédié](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) par RunwayML  
- via extension : [Dégradés Esthétiques](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), une manière de générer des images avec une esthétique spécifique en utilisant les embeddings d’images clip (implémentation de [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))  
- Support de [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - voir [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) pour les instructions  
- Support d’[Alt-Diffusion](https://arxiv.org/abs/2211.06679) - voir [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) pour les instructions  
- Maintenant sans aucune lettre interdite !  
- Chargement des checkpoints au format safetensors  
- Restriction de résolution assouplie : les dimensions de l’image générée doivent être un multiple de 8 au lieu de 64  
- Maintenant avec une licence !  
- Réorganisation des éléments dans l’interface depuis l’écran des paramètres  
- Support de [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)  

## Installation et Exécution  
Assurez-vous que les [dépendances](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) requises sont respectées et suivez les instructions disponibles pour :  
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (recommandé)  
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPUs.  
- [Processeurs Intel, GPUs Intel (intégrés et dédiés)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (page wiki externe)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (page wiki externe)

Alternativement, utilisez des services en ligne (comme Google Colab) :

- [Liste des services en ligne](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Installation sur Windows 10/11 avec GPU NVidia utilisant le paquet de version
1. Téléchargez `sd.webui.zip` depuis [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) et extrayez son contenu.
2. Exécutez `update.bat`.
3. Exécutez `run.bat`.
> Pour plus de détails, voir [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Installation automatique sur Windows
1. Installez [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Une version plus récente de Python ne supporte pas torch), en cochant "Add Python to PATH".
2. Installez [git](https://git-scm.com/download/win).
3. Téléchargez le dépôt stable-diffusion-webui, par exemple en lançant `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Exécutez `webui-user.bat` depuis l’Explorateur Windows en tant qu’utilisateur normal, non administrateur.

### Installation automatique sur Linux
1. Installez les dépendances :
```bash
# Debian-based:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat-based:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-based:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-based:
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
yay -S python311 # do not confuse with python3.11 package

# Only for 3.11
# Then set up env variable in launch script
export python_cmd="python3.11"
# or in webui-user.sh
python_cmd="python3.11"
```
2. Naviguez vers le répertoire dans lequel vous souhaitez installer l'interface web et exécutez la commande suivante :
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

Trouvez les instructions [ici](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Contribution
Voici comment ajouter du code à ce dépôt : [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Documentation

La documentation a été déplacée de ce README vers le [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) du projet.

Pour permettre à Google et autres moteurs de recherche d'explorer le wiki, voici un lien vers le [wiki explorables (non destiné aux humains)](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Crédits
Les licences pour le code emprunté se trouvent dans l'écran `Settings -> Licenses`, ainsi que dans le fichier `html/licenses.html`.

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
- Optimisation de la couche Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, idée originale pour l'édition de prompt.
- Optimisation de la couche Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (à l'origine http://github.com/lstein/stable-diffusion)
- Optimisation sub-quadratique de la couche Cross Attention - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (nous n'utilisons pas son code, mais ses idées).
- Idée pour l'upscale SD - https://github.com/jquesnelle/txt2imghd
- Génération de bruit pour outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Idée et emprunt de code du CLIP interrogator - https://github.com/pharmapsychotic/clip-interrogator
- Idée pour Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogateur pour diffuseurs anime https://github.com/KichangKim/DeepDanbooru
- Échantillonnage en précision float32 depuis un UNet float16 - marunine pour l'idée, Birch-san pour l'exemple d'implémentation Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (étoile), Aleksander Holynski (étoile), Alexei A. Efros (pas d'étoile) - https://github.com/timothybrooks/instruct-pix2pix
- Conseils de sécurité - RyotaK
- Échantillonneur UniPC - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Redémarrage de l'échantillonnage - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Script Gradio initial - posté sur 4chan par un utilisateur Anonyme. Merci à cet utilisateur Anonyme.
- (Vous)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---