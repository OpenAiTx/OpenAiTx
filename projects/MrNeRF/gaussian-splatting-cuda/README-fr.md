# 3D Gaussian Splatting pour le rendu en temps réel de champs de radiance - Implémentation C++ et CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Une implémentation haute performance en C++ et CUDA de 3D Gaussian Splatting, basée sur le backend de rastérisation [gsplat](https://github.com/nerfstudio-project/gsplat).

## Actualités
- **[2025-06-10]** : Correction de plusieurs problèmes. Nous réduisons l’écart avec les métriques gsplat. Cependant, un petit décalage subsiste.
- **[2025-06-04]** : Ajout de la stratégie MCMC avec l’option ligne de commande `--max-cap` pour contrôler le nombre maximal de Gaussiens.
- **[2025-06-03]** : Passage au backend Gsplat et mise à jour de la licence.
- **[2024-05-27]** : Mise à jour vers LibTorch 2.7.0 pour une meilleure compatibilité et performance. Les changements majeurs dans la gestion de l’état de l’optimiseur ont été traités.
- **[2024-05-26]** : L’objectif actuel de ce dépôt est d’évoluer vers une licence permissive. Un travail important a été effectué pour remplacer le rasterizer par l’implémentation gsplat.

## Métriques
L’implémentation actuelle n’atteint pas encore les performances de gsplat-mcmc, mais c’est un travail en cours.  
Il ne s’agit que d’une question de temps pour corriger le bug. Toute aide est la bienvenue :)  
Les métriques pour la stratégie mcmc sont les suivantes :

| Scène    | Itération | PSNR          | SSIM         | LPIPS        | Temps par Image | Nombre de Gaussiens |
| -------- | --------- | ------------- | ------------ | ------------ | --------------- | ------------------- |
| garden   | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765        | 1000000             |
| bicycle  | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618        | 1000000             |
| stump    | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536        | 1000000             |
| bonsai   | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188        | 1000000             |
| counter  | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259        | 1000000             |
| kitchen  | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078        | 1000000             |
| room     | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519        | 1000000             |
| **moyenne** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**    | **1000000**         |

## Communauté & Support

Rejoignez notre communauté grandissante pour des discussions, du support et des mises à jour :  
- 💬 **[Communauté Discord](https://discord.gg/TbxJST2BbC)** - Obtenez de l’aide, partagez vos résultats, discutez du développement  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Visitez notre site web pour plus de ressources  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Liste complète de papiers et ressources  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - Suivez pour les dernières mises à jour

## Instructions de Compilation et d’Exécution

### Prérequis logiciels
1. **Linux** (testé avec Ubuntu 22.04) - Windows n’est pas encore supporté  
2. **CMake** 3.24 ou supérieur  
3. **CUDA** 11.8 ou supérieur (peut fonctionner avec des versions inférieures en configuration manuelle)  
4. **Python** avec headers de développement  
5. **LibTorch 2.7.0** - Instructions d’installation ci-dessous  
6. Les autres dépendances sont gérées automatiquement par CMake

### Prérequis matériels
1. **GPU NVIDIA** avec support CUDA  
    - Testé avec succès : RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Problème connu avec RTX 3080Ti sur des datasets volumineux (voir #21)  
2. Capacité de calcul minimale : 8.0

> Si vous réussissez sur un autre matériel, merci de partager votre expérience dans la section Discussions !

### Instructions de compilation

```bash
# Cloner le dépôt avec les sous-modules
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# Télécharger et configurer LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Compiler le projet
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Ce projet utilise **LibTorch 2.7.0** pour des performances et une compatibilité optimales :

- **Performance améliorée** : Optimisation et gestion mémoire améliorées  
- **Stabilité de l’API** : Dernière API PyTorch C++ stable  
- **Compatibilité CUDA** : Meilleure intégration avec CUDA 11.8+  
- **Corrections de bugs** : Problèmes de gestion de l’état de l’optimiseur résolus

### Mise à jour depuis des versions précédentes
1. Téléchargez la nouvelle version de LibTorch en suivant les instructions de compilation  
2. Nettoyez votre dossier de build : `rm -rf build/`  
3. Recompilez le projet

## Jeu de données

Téléchargez le dataset depuis le dépôt original :  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Extrayez-le dans le dossier `data` à la racine du projet.

## Options en ligne de commande

### Options principales

- **`-h, --help`**  
  Affiche l’aide

- **`-d, --data-path [CHEMIN]`**  
  Chemin vers les données d’entraînement (requis)

- **`-o, --output-path [CHEMIN]`**  
  Chemin pour sauvegarder le modèle entraîné (par défaut : `./output`)

- **`-i, --iter [NOMBRE]`**  
  Nombre d’itérations d’entraînement (par défaut : 30000)  
    - L’article suggère 30k, mais 6k-7k donnent souvent de bons résultats préliminaires  
    - Les sorties sont sauvegardées toutes les 7k itérations et à la fin

- **`-f, --force`**  
  Force l’écrasement du dossier de sortie existant

- **`-r, --resolution [NOMBRE]`**  
  Définit la résolution des images d’entraînement

### Options spécifiques à MCMC

- **`--max-cap [NOMBRE]`**  
  Nombre maximal de Gaussiens pour la stratégie MCMC (par défaut : 1000000)  
    - Contrôle la limite supérieure des splats Gaussiens durant l’entraînement  
    - Utile pour les environnements à mémoire limitée

### Exemples d’utilisation

Entraînement basique :  
```bash
./build/gaussian_splatting_cuda -d /chemin/vers/donnees -o /chemin/vers/sortie -i 10000
```

Entraînement MCMC avec nombre limité de Gaussiens :  
```bash
./build/gaussian_splatting_cuda -d /chemin/vers/donnees -o /chemin/vers/sortie -i 10000 --max-cap 500000
```

## Guide de contribution

Vos contributions sont les bienvenues ! Voici comment commencer :

1. **Pour débuter** :  
    - Consultez les issues marquées **good first issues** pour des tâches accessibles aux débutants  
    - Pour de nouvelles idées, ouvrez une discussion ou rejoignez notre [Discord](https://discord.gg/TbxJST2BbC)

2. **Avant de soumettre une PR** :  
    - Appliquez `clang-format` pour un style de code cohérent  
    - Utilisez le hook pre-commit : `cp tools/pre-commit .git/hooks/`  
    - Discutez des nouvelles dépendances dans une issue avant - nous cherchons à minimiser les dépendances

## Remerciements

Cette implémentation s’appuie sur plusieurs projets clés :

- **[gsplat](https://github.com/nerfstudio-project/gsplat)** : Nous utilisons le backend de rastérisation CUDA hautement optimisé de gsplat, qui offre des gains de performance significatifs et une meilleure efficacité mémoire.

- **3D Gaussian Splatting original** : Basé sur le travail pionnier de Kerbl et al.

## Citation

Si vous utilisez ce logiciel dans vos recherches, merci de citer le travail original :

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Licence

Voir le fichier LICENSE pour plus de détails.

---

**Connectez-vous avec nous :**  
- 🌐 Site web : [mrnerf.com](https://mrnerf.com)  
- 📚 Articles : [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord : [Rejoignez notre communauté](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter : Suivez [@janusch_patas](https://twitter.com/janusch_patas) pour les mises à jour du développement

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---