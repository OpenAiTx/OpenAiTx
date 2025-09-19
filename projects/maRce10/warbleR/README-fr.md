warbleR : Rationaliser l'analyse bioacoustique
================

<!-- README.md est généré à partir de README.Rmd. Veuillez modifier ce fichier -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![Dépendances](https://tinyverse.netlify.com/badge/warbleR)](https://cran.r-project.org/package=warbleR)
[![Statut du projet : Actif Le projet a atteint un état stable et utilisable
et est activement
développé.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licence](https://img.shields.io/badge/licence-GPL--2-blue.svg)](https://www.gnu.org/licenses/gpl-3.0.en.html)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Téléchargements
totaux](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Couverture des tests
Codecov](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
[![R-CMD-check](https://github.com/maRce10/warbleR/workflows/R-CMD-check/badge.svg)](https://github.com/ropensci/baRulho/actions/workflows/R-CMD-check.yaml)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="logo warbleR" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) est conçu pour
faciliter l’analyse de la structure des signaux acoustiques animaux dans
R. Les utilisateurs peuvent collecter des enregistrements aviaires en accès
libre ou entrer leurs propres données dans un flux de travail qui facilite
la visualisation spectrographique et la mesure des paramètres acoustiques.
[warbleR](https://cran.r-project.org/package=warbleR) utilise les outils
fondamentaux d’analyse sonore du package seewave, et propose de nouveaux
outils pour l’analyse de la structure acoustique. Ces outils sont disponibles
pour une analyse par lot des signaux acoustiques.

Les principales fonctionnalités du package sont :

- Divers outils pour mesurer la structure acoustique
- L’utilisation de boucles pour appliquer des tâches à travers les signaux acoustiques référencés dans
  un tableau de sélection
- La production d’images dans le répertoire de travail avec des spectrogrammes pour
  permettre aux utilisateurs d’organiser les données et de vérifier les analyses acoustiques

Le package offre des fonctions pour :

- Explorer et télécharger des enregistrements [Xeno‐Canto](https://xeno-canto.org/)
- Explorer, organiser et manipuler plusieurs fichiers sonores
- Détecter automatiquement les signaux (en fréquence et en temps) (mais consultez le package R
  [ohun](https://docs.ropensci.org/ohun/) pour une implémentation plus complète
  et conviviale)
- Créer des spectrogrammes d’enregistrements complets ou de signaux individuels
- Exécuter différentes mesures de la structure du signal acoustique
- Évaluer la performance des méthodes de mesure
- Cataloguer les signaux
- Caractériser différents niveaux structuraux dans les signaux acoustiques
- Analyse statistique de la coordination des duos
- Consolider les bases de données et les tables d’annotation

La plupart des fonctions permettent la parallélisation des tâches, ce qui
répartit les tâches entre plusieurs processeurs pour améliorer l’efficacité
informatique. Des outils pour évaluer la performance de l’analyse à chaque
étape sont également disponibles.

## Installation

Installez/chargez le package depuis CRAN comme suit :

``` r
install.packages("warbleR")

# load package
library(warbleR)
```

Pour installer la dernière version en développement depuis
[github](https://github.com/) vous aurez besoin du package R
[remotes](https://cran.r-project.org/package=remotes) :

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Utilisation

Le paquet inclut plusieurs vignettes expliquant ses principales fonctionnalités. Le
[Intro à
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
fournit une vue d'ensemble des fonctionnalités du paquet. La vignette
[Format des données
d'annotation](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
donne une description détaillée du format requis pour les annotations
d'entrée. Il existe également trois autres [vignettes du
paquet](https://marce10.github.io/warbleR/articles/) avec des exemples sur
comment organiser les fonctions dans un flux de travail d'analyse acoustique.

Une description complète du paquet (bien que légèrement dépassée) peut être trouvée
dans cet [article de journal](https://doi.org/10.1111/2041-210X.12624).

## Autres paquets

Les paquets [seewave](https://cran.r-project.org/package=seewave) et
[tuneR](https://cran.r-project.org/package=seewave) offrent une grande
variété de fonctions pour l'analyse et la manipulation acoustique. Ils fonctionnent principalement
sur des objets wave déjà importés dans l'environnement R. Le
paquet [baRulho](https://cran.r-project.org/package=baRulho) se concentre sur
la quantification de la dégradation des signaux acoustiques induite par l'habitat avec des entrées
et sorties de données similaires à celles de
[warbleR](https://cran.r-project.org/package=warbleR). Le paquet
[Rraven](https://cran.r-project.org/package=Rraven) facilite
l'échange de données entre R et le [logiciel d'analyse sonore Raven](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) et peut être très
utile pour intégrer Raven comme outil d'annotation dans un flux de travail
d'analyse acoustique sous R. Le paquet
[ohun](https://docs.ropensci.org/ohun/) travaille sur la détection automatisée d'événements sonores, fournissant des fonctions pour diagnostiquer et optimiser les routines de détection. [dynaSpec](https://cran.r-project.org/package=seewave) permet
de créer des spectrogrammes dynamiques (c’est-à-dire des vidéos de spectrogrammes).

## Citation




Veuillez citer [warbleR](https://cran.r-project.org/package=warbleR) comme suit :

Araya-Salas, M. et Smith-Vidaurre, G. (2017), *warbleR : un package R pour
simplifier l'analyse des signaux acoustiques animaux*. Methods Ecol Evol. 8,
184-191.

REMARQUE : veuillez également citer les
packages [tuneR](https://cran.r-project.org/package=tuneR) et
[seewave](https://cran.r-project.org/package=seewave) si vous
utilisez des fonctions de création de spectrogrammes ou de mesures acoustiques



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---