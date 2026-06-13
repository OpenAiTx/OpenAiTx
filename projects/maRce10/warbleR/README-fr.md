warbleR : Simplifiez l’analyse bioacoustique
================

🌐 **Langues :**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (简体)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (繁體)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[한국어](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[हिन्दी](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polski](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[العربية](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkçe](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Tiếng Việt](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Bahasa Indonesia](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md est généré à partir de README.Rmd. Veuillez éditer ce fichier -->
<!-- badges: start -->

[![cycle de vie](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![statut](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Statut du projet : Actif Le projet a atteint un état stable et utilisable
et il est activement
développé.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![Licence : GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![Badge_CRAN_Status](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Téléchargements](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
couverture](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="logo warbleR" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) est destiné à
faciliter l'analyse de la structure des signaux acoustiques animaux dans
R. Les utilisateurs peuvent collecter des enregistrements aviaires en accès libre ou entrer leurs propres
données dans un flux de travail qui facilite la visualisation spectrographique et la
mesure des paramètres acoustiques.
[warbleR](https://cran.r-project.org/package=warbleR) utilise les
outils fondamentaux d'analyse sonore du package seewave, et propose de nouveaux
outils pour l'analyse de la structure acoustique. Ces outils sont disponibles pour
l'analyse en lot des signaux acoustiques.

Les principales fonctionnalités du package sont :

- Divers outils pour mesurer la structure acoustique
- L'utilisation de boucles pour appliquer des tâches sur les signaux acoustiques référencés dans
  un tableau de sélection
- La production d'images dans le répertoire de travail avec des spectrogrammes pour
  permettre aux utilisateurs d'organiser les données et de vérifier les analyses acoustiques

Le package propose des fonctions pour :

- Explorer et télécharger des enregistrements [Xeno‐Canto](https://xeno-canto.org/)
- Explorer, organiser et manipuler plusieurs fichiers audio
- Détecter automatiquement les signaux (en fréquence et en temps) (mais consultez le package R
  [ohun](https://docs.ropensci.org/ohun/) pour une implémentation plus complète
  et conviviale)
- Créer des spectrogrammes d'enregistrements complets ou de signaux individuels
- Exécuter différentes mesures de la structure des signaux acoustiques
- Évaluer la performance des méthodes de mesure
- Cataloguer les signaux
- Caractériser différents niveaux structurels dans les signaux acoustiques
- Analyse statistique de la coordination des duos
- Consolider les bases de données et les tableaux d'annotations

La plupart des fonctions permettent la parallélisation des tâches, ce qui
répartit les tâches entre plusieurs processeurs afin d'améliorer la puissance de calcul
efficacité. Des outils pour évaluer la performance de l'analyse à chaque
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

Le package comprend plusieurs vignettes expliquant ses principales fonctionnalités. La
[Introduction à
warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
présente un aperçu des fonctionnalités du package. La vignette
[Format des données
d’annotation](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
fournit une description détaillée du format requis pour les annotations
en entrée. Il existe également trois [vignettes supplémentaires du
package](https://marce10.github.io/warbleR/articles/) avec des exemples sur
la façon d’organiser les fonctions dans un flux de travail d’analyse acoustique.

Une description complète du package (bien que légèrement obsolète) peut être trouvée
dans cet [article de
journal](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Autres packages

Les packages [seewave](https://cran.r-project.org/package=seewave) et
[tuneR](https://cran.r-project.org/package=seewave) offrent une grande
variété de fonctions pour l’analyse et la manipulation acoustique. Ils travaillent principalement
sur des objets wave déjà importés dans l’environnement R. Le
package [baRulho](https://cran.r-project.org/package=baRulho) se concentre sur
la quantification de la dégradation des signaux acoustiques induite par l’habitat avec des
entrées et sorties de données similaires à celles de
[warbleR](https://cran.r-project.org/package=warbleR). Le package
[Rraven](https://cran.r-project.org/package=Rraven) facilite
l’échange de données entre R et le [logiciel d’analyse sonore Raven
](https://www.ravensoundsoftware.com/) ([Cornell Lab of
Ornithology](https://www.birds.cornell.edu/home)) et peut être très
utile pour incorporer Raven comme outil d’annotation dans un flux de travail
d’analyse acoustique sous R. Le package
[ohun](https://docs.ropensci.org/ohun/) permet la détection automatisée
d’événements sonores, fournissant des fonctions pour diagnostiquer et optimiser les routines de
détection. [dynaSpec](https://cran.r-project.org/package=seewave) permet
de créer des spectrogrammes dynamiques (c’est-à-dire des vidéos de spectrogrammes).

## Citation

Veuillez citer [warbleR](https://cran.r-project.org/package=warbleR) comme suit :

Araya-Salas, M. et Smith-Vidaurre, G. (2017), *warbleR : un package R pour
faciliter l’analyse des signaux acoustiques animaux*. Methods Ecol Evol. 8,
184-191.

REMARQUE : veuillez également citer les packages
[tuneR](https://cran.r-project.org/package=tuneR) et
[seewave](https://cran.r-project.org/package=seewave) si vous
utilisez des fonctions de création de spectrogrammes ou de mesure acoustique



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---