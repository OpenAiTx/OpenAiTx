# SLT - Un plugin pour le langage Common Lisp pour la gamme d’IDE Jetbrains

![GitHub release (latest by date)](https://img.shields.io/github/v/release/Enerccio/SLT)
[![Version](https://img.shields.io/jetbrains/plugin/v/21132-slt.svg)](https://plugins.jetbrains.com/plugin/21132-slt)
![JetBrains plugins](https://img.shields.io/jetbrains/plugin/d/21132)
![GitHub Release Date](https://img.shields.io/github/release-date/Enerccio/SLT)
![OSS Lifecycle](https://img.shields.io/osslifecycle/Enerccio/SLT)
![GitHub](https://img.shields.io/github/license/Enerccio/SLT)
![GitHub lisp counter](https://img.shields.io/github/search/Enerccio/SLT/lisp)
[![0.1.0](https://badgen.net/github/milestones/enerccio/SLT/1)](https://github.com/enerccio/SLT/milestone/1)
[![0.2.0](https://badgen.net/github/milestones/enerccio/SLT/2)](https://github.com/enerccio/SLT/milestone/2)
[![0.3.0](https://badgen.net/github/milestones/enerccio/SLT/4)](https://github.com/enerccio/SLT/milestone/4)
[![0.4.0](https://badgen.net/github/milestones/enerccio/SLT/5)](https://github.com/enerccio/SLT/milestone/5)
[![0.5.0](https://badgen.net/github/milestones/enerccio/SLT/6)](https://github.com/enerccio/SLT/milestone/6)
![GitHub all releases](https://img.shields.io/github/downloads/Enerccio/SLT/total)
![GitHub last commit](https://img.shields.io/github/last-commit/Enerccio/SLT)
![GitHub commit activity](https://img.shields.io/github/commit-activity/m/Enerccio/SLT)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/Enerccio/SLT)
![Lines of code](https://img.shields.io/tokei/lines/github/Enerccio/SLT)
![GitHub top language](https://img.shields.io/github/languages/top/Enerccio/SLT)
[![(want-to-support-me? T NIL)](https://img.shields.io/liberapay/receives/Enerccio.svg?logo=liberapay)](https://liberapay.com/Enerccio)
![Liberapay patrons](https://img.shields.io/liberapay/patrons/Enerccio)
[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpledges&style=flat)](https://patreon.com/enerccio)[![Support me on Patreon](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Denerccio%26type%3Dpatrons&style=flat)](https://patreon.com/enerccio)
![Maintenance](https://img.shields.io/maintenance/yes/2023)
![GitHub issues](https://img.shields.io/github/issues/Enerccio/SLT)
![GitHub branch checks state](https://img.shields.io/github/checks-status/Enerccio/SLT/master)

[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/SLT_IDE?style=social)](https://old.reddit.com/r/SLT_IDE/)
![GitHub forks](https://img.shields.io/github/forks/Enerccio/SLT?style=social)
![GitHub Repo stars](https://img.shields.io/github/stars/Enerccio/SLT?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/Enerccio/SLT?style=social)
[![Join the chat at https://gitter.im/SLT-Plugin/community](https://badges.gitter.im/SLT-Plugin/Lobby.svg)](https://gitter.im/SLT-Plugin/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
![GitHub Discussions](https://img.shields.io/github/discussions/Enerccio/SLT)

![Image](https://raw.githubusercontent.com/Enerccio/SLT/master/src/main/resources/logo/logo.svg)

**CE PLUGIN EST EXPÉRIMENTAL et peut planter à tout moment ! Merci de signaler tous les bugs !**

Ce plugin apporte un support pour Common Lisp dans les IDE JetBrains.  
Il utilise un protocole SLIME/Swank modifié pour communiquer avec l’interpréteur Lisp fournissant  
des fonctionnalités IDE pour Common Lisp.

# Guide d’installation et d’utilisation (relativement) détaillé

Vous pouvez désormais télécharger le plugin depuis le marketplace ! https://plugins.jetbrains.com/plugin/21132-slt

https://github.com/Enerccio/SLT/wiki/User-Guide

## Prérequis

1) IDE basé sur Intellij - testé sur `Intellij Idea Community/Ultimate` mais devrait fonctionner sur tous les IDE majeurs  
   1) Les versions supportées vont de 2022.2 et plus récentes  

Optionnellement (voir plus bas - guide) :

1) Un des interprètes LISP supportés installé :  
   * [Steel Bank Common Lisp](https://www.sbcl.org/)  
   * [Armed Bear Common Lisp](https://armedbear.common-lisp.dev/)  
   * [Clozure Common Lisp](https://ccl.clozure.com/)  
   * [Allegro CL](https://franz.com/products/allegro-common-lisp/)  
   * [CMUCL](https://www.cons.org/cmucl/)  
2) [Quicklisp](https://www.quicklisp.org/beta/) installé

(Toutes les fonctionnalités ne fonctionnent pas avec tous les interprètes, voir [FEATURES.md](https://raw.githubusercontent.com/Enerccio/SLT/master/FEATURES.md) pour plus d’infos !)

## Pour commencer

Voir https://github.com/Enerccio/SLT/wiki/User-Guide#plugin-installation

## Options du plugin

- Voir le guide ci-dessus pour le SDK  
- Pour changer les couleurs https://github.com/Enerccio/SLT/wiki/User-Guide#change-colors-of-elements  
- Pour changer l’indentation https://github.com/Enerccio/SLT/wiki/User-Guide#change-indentation-settings

## Compilation du source

Clonez le dépôt et modifiez gradle.properties pour votre IDE.  
Puis utilisez gradle pour construire le plugin.  
Vous pouvez aussi ouvrir ce projet dans Intellij Idea.

## Fonctionnalités prévues / objectifs

* [x] Publication sur marketplace quand les fonctionnalités seront suffisantes  
* [x] Indentation automatique  
* [x] REPL  
  * [x] Inspection du retour REPL  
* [x] Débogage interactif  
* [x] Aide aux arguments (Ctrl+P)  
* [x] Inspection  
  * [x] Inspection basique  
  * [x] Actions  
  * [x] Inspecteur de symboles  
  * [ ] Évaluation lors de l’inspection  
* [x] Points d’arrêt  
* [x] Documentation  
  * [x] Intégration Hyperspec  
* [x] Expansion de macro (toutes, 1, normale)  
* [x] Recherche de fonction par nom de symbole  
* [x] Recherche de symboles
* [x] Références arrière  
* [x] Accolades arc-en-ciel  
* [ ] Refactorisation  
  * [x] Extraction de lambda en fonction  
* [ ] Liste des paquets quicklisp installés / paquets ASDF  
* [ ] Liste des formes top niveau modifiées qui restent à évaluer  
* [ ] Créer réellement un IDE, c’est-à-dire un plugin avec dépendances en une seule application, pas un plugin  
* [x] Support SDK  
    * pas un vrai SDK car cela n’est disponible que dans Intellij et pas dans (par exemple) PyCharm, donc  
      ceci est implémenté manuellement.  
    * [x] Télécharger SBCL et quicklisp pour l’utilisateur  
* [x] Téléchargement automatique de l’interpréteur lisp et quicklisp  
* [x] Support de différents interprètes lisp  

## Licence  

Ce projet est sous licence [Apache License v2](https://raw.githubusercontent.com/Enerccio/SLT/master/LICENSE.txt).  

# Comment aider ?  

* Veuillez installer le plugin et l’essayer !  
* Signalez tous les bugs pour que je puisse tous les corriger. Cliquez [ici](https://github.com/enerccio/SLT/issues/new) pour signaler.  
* Si vous aimez le projet, pensez à lui attribuer une étoile ou à en parler autour de vous  
* Ce projet est open source, donc si vous avez des connaissances et souhaitez implémenter quelque chose, vous pouvez forker le dépôt puis créer une PR !  

## Dons  

Si vous en avez envie, vous pouvez faire un don pour soutenir mon travail via [Liberapay](https://liberapay.com/Enerccio/donate) ou  
[Patreon](https://www.patreon.com/enerccio).  

# Que signifie SLT ?  

SLT - Speech Language Therapy. Le seul remède pour LISP !  

Aussi, acronyme inversé pour Superior Lisp Tooling !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---