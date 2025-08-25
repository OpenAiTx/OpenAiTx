# BPCells

BPCells est un package pour l'analyse à haute performance de cellules uniques sur de grands ensembles de données RNA-seq et ATAC-seq.  
Il peut effectuer la normalisation et l'ACP d'un ensemble de données de 1,3M de cellules en 4 minutes avec 2 Go de RAM, ou créer des matrices de pics scATAC-seq à partir de coordonnées de fragments avec un temps CPU 50x inférieur à ArchR ou SnapATAC2.  
BPCells peut même gérer l'ensemble complet du recensement humain CELLxGENE, exécutant une ACP en pleine précision sur une matrice de 44M de cellules x 60k gènes en 6 heures sur un ordinateur portable ou moins d'une heure sur un serveur. Voir notre [page de benchmarks](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html) pour les détails.

BPCells fournit :

  - Stockage efficace des ensembles de données de cellules uniques via une compression bitpacking  
  - Traitement rapide des données RNA-seq et ATAC-seq avec support disque, propulsé par C++  
  - Analyse en aval telle que les gènes marqueurs et le clustering  
  - Interopérabilité avec AnnData, ensembles de données 10x, matrices creuses R, et GRanges  
  - Scalabilité démontrée jusqu’à 44M de cellules sur un ordinateur portable  

De plus, BPCells expose son infrastructure optimisée de traitement des données pour une utilisation dans la montée en charge d'outils tiers d'analyse de cellules uniques (par ex. Seurat)

## [En savoir plus sur notre site web](https://bnprks.github.io/BPCells/)

- [Prépublication BioRxiv](https://www.biorxiv.org/content/10.1101/2025.03.27.645853v1)  
- [Documentation Python](https://bnprks.github.io/BPCells/python/index.html)  
- [Benchmarks](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)  
- [Exemple d'analyse multiomique](https://bnprks.github.io/BPCells/articles/pbmc3k.html)  
- [Comment fonctionne BPCells](https://bnprks.github.io/BPCells/articles/web-only/how-it-works.html)  
- [Articles supplémentaires](https://bnprks.github.io/BPCells/articles/index.html)  
- [Documentation des fonctions](https://bnprks.github.io/BPCells/reference/index.html)  
- [Actualités](https://bnprks.github.io/BPCells/news/index.html)  

## Installation R  
Nous recommandons d’installer BPCells directement depuis github :

```R
remotes::install_github("bnprks/BPCells/r")
```
Avant l'installation, vous devez avoir la bibliothèque HDF5 installée et accessible sur votre système.
HDF5 peut être installé à partir du gestionnaire de paquets de votre choix. Voir les instructions spécifiques au système d'exploitation ci-dessous.


Pour les utilisateurs Mac et Windows rencontrant des difficultés pour installer depuis github, consultez notre page [R-universe](https://bnprks.r-universe.dev/BPCells)
pour les instructions d'installation des paquets binaires précompilés. Ces paquets binaires suivent automatiquement la dernière branche principale de github.

BPCells est disponible via conda grâce à [@mfansler](https://github.com/mfansler) de l'équipe Conda Forge R (voir [issue #241](https://github.com/bnprks/BPCells/issues/241) pour plus de détails).
Tout problème avec le paquet bioconda doit être signalé sur [bioconda-recipes](https://github.com/bioconda/bioconda-recipes/). Les mises à jour de version sont gérées par l'équipe bioconda.

<details>
<summary>Cliquez ici pour les informations d'installation spécifiques au système d'exploitation pour les installations basées sur github</summary>
<div>

### Linux
L'obtention de la dépendance HDF5 est généralement assez simple sur Linux

- apt : `sudo apt-get install libhdf5-dev` 
- yum : `sudo yum install hdf5-devel`
- conda : `conda install -c conda-forge hdf5` 
  - Remarque : les utilisateurs Linux devraient préférer le gestionnaire de paquets de leur distribution (ex. `apt` ou `yum`) lorsque c'est possible,
    car cela semble offrir une expérience d'installation légèrement plus fiable.

### Windows
Compiler des paquets R à partir des sources sous Windows nécessite l'installation de [R tools for Windows](https://cran.r-project.org/bin/windows/Rtools/). Voir [Issue #9](https://github.com/bnprks/BPCells/issues/9) pour plus de détails.

### MacOS
Pour MacOS, l'installation de HDF5 via homebrew semble être la plus fiable : `brew install hdf5`.

**Dépannage spécifique Mac** :

- **Macs avec CPU ARM** : une erreur courante est d'avoir une installation HDF5 basée sur ARM mais une installation R basée sur x86. 
  Cela provoquera des erreurs lorsque BPCells tentera d'accéder à HDF5 lors de l'installation. 
    - Vérifiez votre installation R
  en exécutant `sessionInfo()`, et vérifiez si "Platform" indique ARM ou x86. 
    - L'option la plus simple est d'utiliser
  R ARM car homebrew installera par défaut une version hdf5 ARM
    - Il est [possible](https://codetinkering.com/switch-homebrew-arm-x86/) (quoique complexe) d'installer une copie x86 de homebrew afin d'accéder à une version x86 de hdf5
- **Macs anciens (10.14 Mojave ou plus anciens)** : Le compilateur par défaut sur les anciens Macs ne supporte pas les fonctionnalités C++17 nécessaires du système de fichiers. Voir [issue #3](https://github.com/bnprks/BPCells/issues/3#issuecomment-1375238635) pour

  conseils pour configurer un compilateur plus récent via homebrew.

### Compilateurs supportés
Dans la plupart des cas, vous aurez déjà un compilateur approprié. BPCells recommande
gcc >=9.1, ou clang >= 9.0. 
Cela correspond aux versions de fin 2018 et plus récentes. 
Les versions plus anciennes peuvent fonctionner dans certains cas à condition qu'elles
aient un support C++17 de base, mais elles ne sont pas officiellement supportées.

</div>
</details>
<details>
<summary>Cliquez ici pour des informations de dépannage pour les installations basées sur github</summary>

### Dépannage général de l'installation
BPCells essaie d'afficher des messages d'erreur informatifs lors de la compilation pour aider à diagnostiquer le problème. Pour un ensemble d'informations plus
verbeux, exécutez `Sys.setenv(BPCELLS_DEBUG_INSTALL="true")` avant `remotes::install_github("bnprks/BPCells/r")`. Si vous ne parvenez toujours pas à résoudre le problème avec ces informations supplémentaires, n'hésitez pas à créer un problème sur Github, en
veillant à utiliser une [section réductible](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections) pour le journal d'installation verbeux.

</details>

## Installation Python

BPCells peut être installé directement via pip :

```shell
python -m pip install bpcells
```
## Contribution
BPCells est un projet open source, et nous accueillons les contributions de qualité. Si vous
êtes intéressé à contribuer et avez de l'expérience avec C++, ainsi qu'avec Python
ou R, n'hésitez pas à nous contacter avec des idées que vous souhaitez implémenter vous-même.
Nous sommes heureux de fournir des conseils pour vous aider à démarrer, dans la limite du temps disponible.

Si vous ne connaissez pas C++, il vous sera difficile de contribuer du code,
mais des rapports de bogues détaillés avec
[exemples reproductibles](https://reprex.tidyverse.org/articles/reprex-dos-and-donts.html)
sont toujours un excellent moyen d'aider. Les issues Github sont le meilleur forum pour cela.

Si vous maintenez un paquet d'analyse de cellule unique et souhaitez utiliser BPCells pour
améliorer votre évolutivité, nous sommes heureux de vous conseiller. Quelques laboratoires
ont déjà essayé, avec un succès prometteur. Le courriel est le meilleur moyen de nous contacter
pour cela (consultez le fichier `DESCRIPTION` sur github pour les coordonnées). Les développeurs Python
sont les bienvenus, bien que le paquet python actuel soit encore en statut expérimental.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---