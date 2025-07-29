# Plugin IntelliJ pour Pebble [![Gitter](https://badges.gitter.im/bjansen/pebble-intellij.svg)](https://gitter.im/bjansen/pebble-intellij) [![GitHub Actions](https://github.com/bjansen/pebble-intellij/workflows/Java%20CI/badge.svg?branch=master)](https://github.com/bjansen/pebble-intellij/actions) [![GitHub release](https://img.shields.io/github/release/bjansen/pebble-intellij.svg)](https://plugins.jetbrains.com/plugin/9407-pebble) [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=pebble-intellij&metric=coverage)](https://sonarcloud.io/dashboard?id=pebble-intellij)

Ce plugin fournit un support pour le [moteur de templates Pebble](https://github.com/PebbleTemplates/pebble) dans  
IntelliJ IDEA 2017.3 et versions ultérieures.

<p align="center">
  <img src="https://github.com/bjansen/pebble-intellij/raw/master/images/plugin.png" 
       width="594" alt="Plugin IntelliJ pour Pebble"/>
<p>

## Fonctionnalités

* parseur/lexer<sup>1</sup> et coloration syntaxique (supporte les délimiteurs personnalisés)
* modèles dynamiques pour les tags intégrés
* appariement des accolades, pliage de code et commentaires
* gestionnaire de guillemets
* navigation (méthodes et champs, fichiers inclus)
* complétion de code
* mise en évidence des références inconnues
* support des variables et fonctions introduites par [pebble-spring](https://github.com/PebbleTemplates/pebble/wiki/spring-integration)
* [plus à venir](https://github.com/bjansen/pebble-intellij/issues?utf8=%E2%9C%93&q=is%3Aissue%20is%3Aopen%20label%3At-feature)

<sup>1</sup>: *Les opérateurs personnalisés ne sont pas encore supportés*.

## Installation

Ce plugin est disponible dans le [dépôt de plugins](https://plugins.jetbrains.com/idea/plugin/9407-pebble) de JetBrains,  
depuis votre IDE, allez dans `Preferences > Plugins` et saisissez `pebble` dans la barre de recherche.

## Mélanger Pebble et d’autres langages

Pour faire reconnaître deux langages dans un même fichier, par exemple HTML  
et Pebble, allez dans `Preferences > Languages & Frameworks > Template Data Languages`  
et sélectionnez le langage de données `HTML` sur le répertoire contenant vos templates Pebble :

![Paramètres des langages de données des templates](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/settings.png)

Cela activera des fonctionnalités telles que la coloration syntaxique, la complétion de code, la navigation,  
les expansions Emmet, etc.

## Utilisation de la complétion de code

Pour utiliser la complétion de code, vous devez informer le plugin du type  
de `foo`. Cela peut être fait en utilisant les annotations `@pebvariable`, comme dans les plugins JSP, FreeMarker  
et Velocity :

![Complétion de code](https://raw.githubusercontent.com/bjansen/pebble-intellij/master/images/completion.png)

Les annotations `@pebvariable` peuvent être facilement ajoutées aux templates via le modèle dynamique `var`. Elles doivent  
respecter cette syntaxe :

    {# @pebvariable name="<nom>" type="<type>" #}

Pour que la complétion fonctionne correctement avec l’attribut `type`, vos fichiers `.peb` doivent être placés  
dans une [racine de contenu](https://www.jetbrains.com/help/idea/content-roots.html) (par exemple `src/main/resources`).  
Sinon, les classes définies dans vos propres fichiers sources ne seront pas suggérées.

## Versions nocturnes

Les builds snapshot sont disponibles via le CI Actions :  
 * allez sur https://github.com/bjansen/pebble-intellij/actions  
 * cliquez sur le build le plus récent  
 * descendez en bas de la page, dans la section `Artifacts` cliquez sur `pebble-intellij-development`  
 * cela téléchargera un fichier zip qui peut être installé dans votre IDE en utilisant [Installer un plugin depuis un fichier](https://www.jetbrains.com/help/idea/managing-plugins.html#install_plugin_from_disk)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---