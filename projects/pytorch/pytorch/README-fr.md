![Logo PyTorch](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch est un paquet Python qui fournit deux fonctionnalités de haut niveau :
- Calcul de tenseurs (comme NumPy) avec une forte accélération GPU
- Réseaux de neurones profonds construits sur un système d'autograd basé sur une bande (tape-based)

Vous pouvez réutiliser vos paquets Python préférés tels que NumPy, SciPy et Cython pour étendre PyTorch si nécessaire.

L’état de santé de notre branche principale (signaux d’intégration continue) peut être consulté sur [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [En savoir plus sur PyTorch](#more-about-pytorch)
  - [Une bibliothèque de tenseurs prête pour le GPU](#a-gpu-ready-tensor-library)
  - [Réseaux de neurones dynamiques : autograd basé sur une bande](#dynamic-neural-networks-tape-based-autograd)
  - [Python d’abord](#python-first)
  - [Expériences impératives](#imperative-experiences)
  - [Rapide et léger](#fast-and-lean)
  - [Extensions sans douleur](#extensions-without-pain)
- [Installation](#installation)
  - [Binaires](#binaries)
    - [Plateformes NVIDIA Jetson](#nvidia-jetson-platforms)
  - [Depuis les sources](#from-source)
    - [Prérequis](#prerequisites)
      - [Support NVIDIA CUDA](#nvidia-cuda-support)
      - [Support AMD ROCm](#amd-rocm-support)
      - [Support GPU Intel](#intel-gpu-support)
    - [Obtenir le code source de PyTorch](#get-the-pytorch-source)
    - [Installer les dépendances](#install-dependencies)
    - [Installer PyTorch](#install-pytorch)
      - [Ajuster les options de compilation (optionnel)](#adjust-build-options-optional)
  - [Image Docker](#docker-image)
    - [Utilisation d’images pré-construites](#using-pre-built-images)
    - [Construire l’image soi-même](#building-the-image-yourself)
  - [Générer la documentation](#building-the-documentation)
    - [Générer un PDF](#building-a-pdf)
  - [Versions précédentes](#previous-versions)
- [Premiers pas](#getting-started)
- [Ressources](#resources)
- [Communication](#communication)
- [Versions et contribution](#releases-and-contributing)
- [L’équipe](#the-team)
- [Licence](#license)

<!-- tocstop -->

## En savoir plus sur PyTorch

[Apprenez les bases de PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

À un niveau granulaire, PyTorch est une bibliothèque composée des éléments suivants :

| Composant | Description |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Une bibliothèque de tenseurs comme NumPy, avec un fort support GPU |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Une bibliothèque de différentiation automatique basée sur une bande qui prend en charge toutes les opérations différentiables sur les tenseurs dans torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Une pile de compilation (TorchScript) pour créer des modèles sérialisables et optimisables à partir de code PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Une bibliothèque de réseaux de neurones profondément intégrée à autograd, conçue pour une flexibilité maximale |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Multiprocessing Python, mais avec partage magique de la mémoire des tenseurs torch entre processus. Utile pour le chargement des données et l’entraînement Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader et autres fonctions utilitaires pour plus de commodité |

En général, PyTorch est utilisé soit comme :

- Un remplacement de NumPy pour utiliser la puissance des GPU.
- Une plateforme de recherche en deep learning offrant flexibilité maximale et rapidité.

Plus de détails :

### Une bibliothèque de tenseurs prête pour le GPU

Si vous utilisez NumPy, alors vous avez utilisé des tenseurs (a.k.a. ndarray).

![Illustration de tenseur](./docs/source/_static/img/tensor_illustration.png)

PyTorch fournit des tenseurs qui peuvent résider soit sur le CPU soit sur le GPU et accélère
les calculs de manière considérable.

Nous proposons une large variété de routines sur les tenseurs pour accélérer et répondre à vos besoins scientifiques :
découpage, indexation, opérations mathématiques, algèbre linéaire, réductions.
Et elles sont rapides !

### Réseaux de neurones dynamiques : autograd basé sur une bande

PyTorch a une façon unique de construire les réseaux de neurones : en utilisant et rejouant un magnétophone.

La plupart des frameworks comme TensorFlow, Theano, Caffe et CNTK ont une vision statique du monde.
Il faut construire un réseau de neurones et réutiliser la même structure encore et encore.
Changer le comportement du réseau signifie repartir de zéro.

Avec PyTorch, nous utilisons une technique appelée auto-différentiation en mode inverse, qui vous permet
de modifier arbitrairement le comportement de votre réseau sans aucun délai ni surcoût. Notre inspiration vient
de plusieurs articles de recherche sur ce sujet, ainsi que de travaux passés et actuels tels que
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org), etc.

Bien que cette technique ne soit pas propre à PyTorch, c’en est l’une des implémentations les plus rapides à ce jour.
Vous obtenez le meilleur de la vitesse et de la flexibilité pour vos recherches les plus folles.

![Graphe dynamique](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python d’abord

PyTorch n’est pas une simple liaison Python vers un framework C++ monolithique.
Il est conçu pour être profondément intégré à Python.
Vous pouvez l’utiliser naturellement comme vous le feriez avec [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org), etc.
Vous pouvez écrire vos nouvelles couches de réseau de neurones directement en Python, en utilisant vos bibliothèques préférées,
et utiliser des paquets comme [Cython](https://cython.org/) et [Numba](http://numba.pydata.org/).
Notre objectif est de ne pas réinventer la roue là où ce n’est pas nécessaire.

### Expériences impératives

PyTorch est conçu pour être intuitif, linéaire dans la réflexion et facile à utiliser.
Lorsque vous exécutez une ligne de code, elle s’exécute immédiatement. Il n’y a pas de vision asynchrone du monde.
Lorsque vous entrez dans un débogueur ou recevez des messages d’erreur et des traces de pile, leur compréhension est directe.
La trace de pile indique exactement où votre code a été défini.
Nous espérons que vous ne passerez jamais des heures à déboguer votre code à cause de mauvaises traces ou d’engins d’exécution asynchrones et opaques.

### Rapide et léger

PyTorch a un surcoût de framework minimal. Nous intégrons des bibliothèques d’accélération
telles que [Intel MKL](https://software.intel.com/mkl) et NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) pour maximiser la vitesse.
Au cœur, ses backends de tenseur et de réseau de neurones CPU et GPU
sont matures et éprouvés depuis des années.

Ainsi, PyTorch est très rapide — que vous exécutiez de petits ou de grands réseaux de neurones.

L’utilisation de la mémoire sous PyTorch est extrêmement efficace comparée à Torch ou à d’autres alternatives.
Nous avons écrit des allocateurs de mémoire personnalisés pour le GPU afin de garantir que
vos modèles de deep learning soient aussi économes en mémoire que possible.
Cela vous permet d’entraîner des modèles plus grands qu’auparavant.

### Extensions sans douleur

Écrire de nouveaux modules de réseau de neurones ou interfacer avec l’API Tensor de PyTorch a été conçu pour être simple
et avec un minimum d’abstractions.

Vous pouvez écrire de nouvelles couches de réseau en Python en utilisant l’API torch
[ou vos bibliothèques préférées basées sur NumPy comme SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Si vous souhaitez écrire vos couches en C/C++, nous fournissons une API d’extension pratique, efficace et sans boilerplate.
Aucun code wrapper n’est nécessaire. Voir [un tutoriel ici](https://pytorch.org/tutorials/advanced/cpp_extension.html) et [un exemple ici](https://github.com/pytorch/extension-cpp).


## Installation

### Binaires
Les commandes pour installer les binaires via Conda ou pip wheels sont disponibles sur notre site web : [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### Plateformes NVIDIA Jetson

Des roues Python pour les Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX et Jetson AGX Orin de NVIDIA sont disponibles [ici](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) et le conteneur L4T est publié [ici](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Elles nécessitent JetPack 4.2 et supérieur, et [@dusty-nv](https://github.com/dusty-nv) ainsi que [@ptrblck](https://github.com/ptrblck) les maintiennent.


### Depuis les sources

#### Prérequis
Si vous installez depuis les sources, vous aurez besoin de :
- Python 3.9 ou supérieur
- Un compilateur prenant en charge entièrement C++17, tel que clang ou gcc (gcc 9.4.0 ou plus récent requis sous Linux)
- Visual Studio ou Visual Studio Build Tool (Windows uniquement)

\* L’intégration continue de PyTorch utilise Visual C++ BuildTools, qui sont inclus dans Visual Studio Enterprise,
Professional ou Community Editions. Vous pouvez aussi installer les outils de build depuis
https://visualstudio.microsoft.com/visual-cpp-build-tools/. Les outils de build *ne sont pas*
inclus par défaut dans Visual Studio Code.

Un exemple de configuration d’environnement est présenté ci-dessous :

* Linux :

```bash
$ source <CONDA_INSTALL_DIR>/bin/activate
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
```

* Windows :

```bash
$ source <CONDA_INSTALL_DIR>\Scripts\activate.bat
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
$ call "C:\Program Files\Microsoft Visual Studio\<VERSION>\Community\VC\Auxiliary\Build\vcvarsall.bat" x64
```

##### Support NVIDIA CUDA
Si vous souhaitez compiler avec le support CUDA, [sélectionnez une version prise en charge de CUDA dans notre matrice de support](https://pytorch.org/get-started/locally/), puis installez :
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 ou supérieur
- [Compilateur](https://gist.github.com/ax3l/9489132) compatible avec CUDA

Note : Vous pouvez consulter la [matrice de support cuDNN](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) pour les versions cuDNN supportées avec les différentes versions CUDA, pilotes CUDA et matériels NVIDIA.

Si vous souhaitez désactiver le support CUDA, exportez la variable d’environnement `USE_CUDA=0`.
D’autres variables d’environnement utiles peuvent être trouvées dans `setup.py`.

Si vous compilez pour les plateformes Jetson de NVIDIA (Jetson Nano, TX1, TX2, AGX Xavier), les instructions d’installation de PyTorch pour Jetson Nano sont [disponibles ici](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Support AMD ROCm
Si vous souhaitez compiler avec le support ROCm, installez
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) version 4.0 ou supérieure
- ROCm est actuellement uniquement pris en charge pour les systèmes Linux.

Par défaut, le système de build s’attend à ce que ROCm soit installé dans `/opt/rocm`. Si ROCm est installé dans un autre répertoire, la variable d’environnement `ROCM_PATH` doit être définie sur ce répertoire. Le système de build détecte automatiquement l’architecture GPU AMD. Optionnellement, l’architecture GPU AMD peut être explicitement définie avec la variable d’environnement `PYTORCH_ROCM_ARCH` [Architecture GPU AMD](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Pour désactiver le support ROCm, exportez la variable d’environnement `USE_ROCM=0`.
D’autres variables d’environnement utiles peuvent être trouvées dans `setup.py`.

##### Support GPU Intel
Si vous souhaitez compiler avec le support GPU Intel, suivez ces
- [Instructions des prérequis PyTorch pour GPU Intel](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html).
- Le GPU Intel est pris en charge sous Linux et Windows.

Pour désactiver le support GPU Intel, exportez la variable d’environnement `USE_XPU=0`.
D’autres variables d’environnement utiles peuvent être trouvées dans `setup.py`.

#### Obtenir le code source de PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# si vous mettez à jour un dépôt existant
git submodule sync
git submodule update --init --recursive
```

#### Installer les dépendances

**Commun**

```bash
conda install cmake ninja
# Exécutez cette commande depuis le dossier PyTorch après avoir cloné le code source selon la section “Obtenir le code source de PyTorch” ci-dessus
pip install -r requirements.txt
```

**Sous Linux**

```bash
pip install mkl-static mkl-include
# CUDA uniquement : ajouter le support LAPACK pour le GPU si nécessaire
# installation de magma : exécutez avec un environnement conda actif. spécifiez la version CUDA à installer
.ci/docker/common/install_magma_conda.sh 12.4

# (optionnel) Si vous utilisez torch.compile avec inductor/triton, installez la version correspondante de triton
# Depuis le dossier pytorch après clonage
# Pour le support GPU Intel, veuillez explicitement `export USE_XPU=1` avant d’exécuter la commande.
make triton
```

**Sous MacOS**

```bash
# Ajouter ce paquet uniquement sur les machines processeur intel x86
pip install mkl-static mkl-include
# Ajouter ces paquets si torch.distributed est nécessaire
conda install pkg-config libuv
```

**Sous Windows**

```bash
pip install mkl-static mkl-include
# Ajouter ces paquets si torch.distributed est nécessaire.
# Le support du package distributed sous Windows est une fonctionnalité prototype sujette à modifications.
conda install -c conda-forge libuv=1.39
```

#### Installer PyTorch
**Sous Linux**

Si vous compilez pour AMD ROCm, exécutez d’abord cette commande :
```bash
# Exécutez ceci uniquement si vous compilez pour ROCm
python tools/amd_build/build_amd.py
```

Installer PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**Sous macOS**

```bash
python3 setup.py develop
```

**Sous Windows**

Si vous souhaitez compiler du code python hérité, veuillez consulter [Compilation de code hérité et CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Compilations CPU uniquement**

Dans ce mode, les calculs PyTorch s’exécutent sur votre CPU, pas votre GPU.

```cmd
python setup.py develop
```

Note sur OpenMP : L’implémentation OpenMP souhaitée est Intel OpenMP (iomp). Pour lier iomp, vous devez télécharger manuellement la bibliothèque et configurer l’environnement de build en ajustant `CMAKE_INCLUDE_PATH` et `LIB`. Les instructions [ici](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) montrent comment configurer MKL et Intel OpenMP. Sans ces configurations pour CMake, le runtime OpenMP de Microsoft Visual C (vcomp) sera utilisé.

**Compilation basée sur CUDA**

Dans ce mode, les calculs PyTorch utiliseront votre GPU via CUDA pour des calculs plus rapides.

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) est nécessaire pour compiler PyTorch avec CUDA.
NVTX fait partie de la distribution CUDA, où il est appelé "Nsight Compute". Pour l’installer sur une CUDA déjà installée, relancez l’installation CUDA et cochez la case correspondante.
Assurez-vous que CUDA avec Nsight Compute est installé après Visual Studio.

Actuellement, VS 2017/2019 et Ninja sont supportés comme générateurs CMake. Si `ninja.exe` est détecté dans `PATH`, Ninja sera utilisé par défaut, sinon VS 2017/2019.
<br/> Si Ninja est sélectionné comme générateur, la dernière version de MSVC sera sélectionnée comme toolchain sous-jacente.

Des bibliothèques additionnelles telles que
[Magma](https://developer.nvidia.com/magma), [oneDNN, aussi appelé MKLDNN ou DNNL](https://github.com/oneapi-src/oneDNN), et [Sccache](https://github.com/mozilla/sccache) sont souvent nécessaires. Veuillez consulter le [helper d’installation](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) pour les installer.

Vous pouvez vous référer au script [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) pour d’autres configurations de variables d’environnement.

```cmd
cmd

:: Définissez les variables d’environnement après avoir téléchargé et décompressé le paquet mkl,
:: sinon CMake renverra une erreur `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Votre dossier}\mkl\include
set LIB={Votre dossier}\mkl\lib;%LIB%

:: Lisez attentivement la section précédente avant de continuer.
:: [Optionnel] Pour forcer le toolset sous-jacent utilisé par Ninja et Visual Studio avec CUDA, exécutez le bloc suivant.
:: L’invite "Visual Studio 2019 Developer Command Prompt" sera lancée automatiquement.
:: Assurez-vous d’avoir CMake >= 3.12 avant cela si vous utilisez le générateur Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Optionnel] Pour surcharger le compilateur hôte CUDA
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Compilations GPU Intel**

Dans ce mode, PyTorch avec le support GPU Intel sera compilé.

Veuillez vous assurer que [les prérequis communs](#prerequisites) ainsi que [les prérequis pour GPU Intel](#intel-gpu-support) sont correctement installés et que les variables d’environnement sont configurées avant de commencer la compilation. Pour le support des outils de build, `Visual Studio 2022` est requis.

PyTorch peut alors être compilé avec la commande suivante :

```cmd
:: Commandes CMD :
:: Définir CMAKE_PREFIX_PATH pour aider à trouver les paquets correspondants
:: %CONDA_PREFIX% ne fonctionne qu’après `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Ajuster les options de compilation (optionnel)

Vous pouvez ajuster la configuration des variables cmake optionnellement (sans compiler d’abord), en procédant ainsi. Par exemple, ajuster les répertoires prédétectés pour CuDNN ou BLAS peut se faire
avec cette étape.

Sous Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # ou cmake-gui build
```

Sous macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # ou cmake-gui build
```

### Image Docker

#### Utilisation d’images pré-construites

Vous pouvez également récupérer une image docker pré-construite depuis Docker Hub et l’exécuter avec docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Veuillez noter que PyTorch utilise la mémoire partagée pour partager les données entre processus, donc si le multiprocessing torch est utilisé (par exemple
pour les data loaders multithreadés) la taille de segment mémoire partagée par défaut du conteneur n’est pas suffisante, et vous
devez augmenter la taille de la mémoire partagée avec les options de ligne de commande `--ipc=host` ou `--shm-size` à `nvidia-docker run`.

#### Construire l’image soi-même

**REMARQUE :** Doit être construit avec une version de docker > 18.06

Le `Dockerfile` est fourni pour construire des images avec le support CUDA 11.1 et cuDNN v8.
Vous pouvez passer la variable make `PYTHON_VERSION=x.y` pour spécifier quelle version de Python doit être utilisée par Miniconda, ou la laisser non définie pour utiliser la valeur par défaut.

```bash
make -f docker.Makefile
# les images sont taguées comme docker.io/${votre_nom_utilisateur_docker}/pytorch
```

Vous pouvez aussi passer la variable d’environnement `CMAKE_VARS="..."` pour spécifier des variables CMake supplémentaires à transmettre à CMake lors de la compilation.
Voir [setup.py](./setup.py) pour la liste des variables disponibles.

```bash
make -f docker.Makefile
```

### Générer la documentation

Pour générer la documentation sous différents formats, vous aurez besoin de [Sphinx](http://www.sphinx-doc.org)
et du thème pytorch_sphinx_theme2.

Avant de générer la documentation localement, assurez-vous que `torch` est
installé dans votre environnement. Pour de petites corrections, vous pouvez installer la
version nightly comme décrit dans [Premiers pas](https://pytorch.org/get-started/locally/).

Pour des corrections plus complexes, comme l’ajout d’un nouveau module et des docstrings pour
ce module, il peut être nécessaire d’installer torch [depuis les sources](#from-source).
Voir [Directives pour les docstrings](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
pour les conventions de docstring.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Exécutez `make` pour obtenir la liste de tous les formats de sortie disponibles.

Si vous obtenez une erreur katex exécutez `npm install katex`.  Si cela persiste, essayez
`npm install -g katex`

> [!NOTE]
> Si vous avez installé `nodejs` avec un gestionnaire de paquets différent (par exemple,
> `conda`) alors `npm` installera probablement une version de `katex` qui n’est pas
> compatible avec votre version de `nodejs` et la génération de la doc échouera.
> Une combinaison de versions connue pour fonctionner est `node@6.13.1` et
> `katex@0.13.18`. Pour installer cette dernière avec `npm`, exécutez
> ```npm install -g katex@0.13.18```

> [!NOTE]
> Si vous voyez une erreur d’incompatibilité numpy, exécutez :
> ```
> pip install 'numpy<2'
> ```

Si vous modifiez les dépendances utilisées par l’IC, éditez le fichier
`.ci/docker/requirements-docs.txt`.

#### Générer un PDF

Pour compiler un PDF de toute la documentation PyTorch, assurez-vous d’avoir
`texlive` et LaTeX installés. Sous macOS, vous pouvez les installer via :

```
brew install --cask mactex
```

Pour créer le PDF :

1. Exécutez :

   ```
   make latexpdf
   ```

   Cela générera les fichiers nécessaires dans le répertoire `build/latex`.

2. Naviguez dans ce répertoire et exécutez :

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Cela produira un `pytorch.pdf` avec le contenu souhaité. Exécutez cette
   commande une fois de plus afin de générer la table des matières
   et l’index corrects.

> [!NOTE]
> Pour visualiser la table des matières, passez en mode **Table des matières**
> dans votre lecteur PDF.


### Versions précédentes

Les instructions d’installation et binaires pour les versions précédentes de PyTorch sont disponibles
sur [notre site web](https://pytorch.org/get-started/previous-versions).


## Premiers pas

Trois liens pour commencer :
- [Tutoriels : pour comprendre et utiliser PyTorch](https://pytorch.org/tutorials/)
- [Exemples : du code PyTorch facile à comprendre dans tous les domaines](https://github.com/pytorch/examples)
- [La référence de l’API](https://pytorch.org/docs/)
- [Glossaire](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Ressources

* [PyTorch.org](https://pytorch.org/)
* [Tutoriels PyTorch](https://pytorch.org/tutorials/)
* [Exemples PyTorch](https://github.com/pytorch/examples)
* [Modèles PyTorch](https://pytorch.org/hub/)
* [Intro à l’apprentissage profond avec PyTorch par Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Intro au machine learning avec PyTorch par Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Réseaux de neurones profonds avec PyTorch sur Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch Blog](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Communication
* Forums : Discuter d’implémentations, de la recherche, etc. https://discuss.pytorch.org
* GitHub Issues : Rapports de bugs, suggestions de fonctionnalités, problèmes d’installation, RFC, idées, etc.
* Slack : Le [Slack PyTorch](https://pytorch.slack.com/) accueille principalement des utilisateurs et développeurs PyTorch de niveau intermédiaire à avancé pour chat général, discussions en ligne, collaborations, etc. Si vous êtes débutant et cherchez de l’aide, le principal canal est [les forums PyTorch](https://discuss.pytorch.org). Pour une invitation Slack, remplissez ce formulaire : https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Newsletter : Sans bruit, une newsletter email unidirectionnelle avec les annonces importantes concernant PyTorch. Inscrivez-vous ici : https://eepurl.com/cbG0rv
* Page Facebook : Annonces importantes à propos de PyTorch. https://www.facebook.com/pytorch
* Pour les guides de marque, veuillez consulter notre site : [pytorch.org](https://pytorch.org/)

## Versions et contribution

En général, PyTorch a trois versions mineures par an. Merci de nous signaler tout bug en [créant une issue](https://github.com/pytorch/pytorch/issues).

Nous apprécions toute contribution. Si vous prévoyez de proposer des corrections de bugs, faites-le sans discussion préalable.

Si vous envisagez de contribuer de nouvelles fonctionnalités, fonctions utilitaires ou extensions au cœur du projet, ouvrez d’abord une issue pour discuter de la fonctionnalité avec nous.
Envoyer une PR sans discussion pourrait conduire à un refus, car nous pourrions orienter le cœur du projet dans une direction différente de ce que vous imaginez.

Pour en savoir plus sur la contribution à PyTorch, consultez notre [page de contribution](CONTRIBUTING.md). Pour plus d’informations sur les versions de PyTorch, voir [page des versions](RELEASE.md).

## L’équipe

PyTorch est un projet communautaire avec de nombreux ingénieurs et chercheurs talentueux qui y contribuent.

PyTorch est actuellement maintenu par [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), et [Nikita Shulga](https://github.com/malfet), avec des contributions majeures venant de centaines d’individus talentueux sous diverses formes.
Une liste non exhaustive, mais croissante, inclut : [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Remarque : Ce projet n’est pas lié à [hughperkins/pytorch](https://github.com/hughperkins/pytorch) portant le même nom. Hugh est un contributeur précieux à la communauté Torch et a beaucoup aidé sur Torch et PyTorch.

## Licence

PyTorch possède une licence de type BSD, comme indiqué dans le fichier [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---