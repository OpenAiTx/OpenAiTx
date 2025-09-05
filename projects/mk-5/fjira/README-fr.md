# Fjira - Chercheur flou et application TUI pour Jira.

<img src="https://raw.githubusercontent.com/mk-5/fjira/master/fjira.png" alt="drawing" width="256"/>

[![Mentionné dans Awesome Go](https://awesome.re/badge-flat.svg)](https://github.com/avelino/awesome-go)
![Test](https://github.com/mk-5/fjira/actions/workflows/tests.yml/badge.svg)
[![Licence : AGPL v3](https://img.shields.io/badge/License-AGPL%20v3-blue.svg)](https://github.com/mk-5/fjira/blob/master/LICENSE)
![Version GitHub (la plus récente)](https://img.shields.io/github/v/release/mk-5/fjira)
[![Go Report Card](https://goreportcard.com/badge/github.com/mk-5/fjira)](https://goreportcard.com/report/github.com/mk-5/fjira)
[![Référence Go](https://pkg.go.dev/badge/github.com/mk-5/fjira.svg)](https://pkg.go.dev/github.com/mk-5/fjira)
[![codecov](https://codecov.io/gh/mk-5/fjira/branch/master/graph/badge.svg?token=MJBTMYGQQW)](https://codecov.io/gh/mk-5/fjira)

## Introduction

Fjira est un outil en ligne de commande puissant conçu pour simplifier vos interactions avec Jira. Que vous soyez développeur,
chef de projet, ou simplement un passionné de Jira, Fjira rationalise votre flux de travail, rendant les tâches Jira plus efficaces que jamais.

![Démonstration Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo.gif)

## Fonctionnalités clés

- **Interface de recherche floue :** Recherchez facilement des projets et des tickets Jira.
- **Contrôle des assignations :** Changez rapidement les assignés d’un ticket sans naviguer dans l’interface Jira.
- **Mise à jour des statuts :** Modifiez les statuts des tickets Jira directement depuis votre terminal.
- **Commentaires efficaces :** Ajoutez facilement des commentaires aux tickets Jira.
- **Support multi-espace de travail :** Gérez plusieurs espaces Jira sans effort.
- **Recherches personnalisées :** Utilisez le langage de requête Jira (JQL) pour des recherches sur mesure.
- **Accès direct en CLI :** Accédez aux tickets Jira directement depuis la ligne de commande.
- **Compatibilité multiplateforme :** Fonctionne parfaitement sur macOS, Linux et Windows.

## Installation

### macOS


```shell
brew tap mk-5/mk-5
brew install fjira
```

### Linux

#### Ubuntu/Snap

```shell
snap install fjira
```
#### Deb

Visitez [https://github.com/mk-5/fjira/releases/latest](https://github.com/mk-5/fjira/releases/latest), et récupérez la
dernière version publiée.


```shell
sudo dpkg -i fjira_0.4.0_linux_amd64.deb
```

#### AUR

```sh
yay -S fjira
```

#### Binaire

```shell
tar -xvzf fjira_0.4.0_Linux_x86_64.tar.gz
cp fjira /usr/local/bin/fjira
```

### Windows

```shell
choco install fjira
```

### Construire à partir des sources

```shell
make
./out/bin/fjira
```

## Utilisation

```text
Usage:
  fjira [flags]
  fjira [command]

Available Commands:
  [issueKey]  Open a Jira issue directly from the CLI
  completion  Generate the autocompletion script for the specified shell
  filters     Search using Jira filters
  help        Help about any command
  jql         Search using custom JQL queries
  version     Print the version number of fjira
  workspace   Switch to a different workspace

Flags:
  -h, --help             help for fjira
  -p, --project string   Open a project directly from CLI

Additional help topics:
  fjira            Open a fuzzy finder for projects as a default action

Use "fjira [command] --help" for more information about a command.
```

## Pour Commencer

L'utilisation du CLI Fjira est simple. Il suffit de lancer fjira dans votre terminal.

```shell
fjira
```

## Espaces de travail

La première fois que vous lancez Fjira, il vous demandera l’URL de l’API Jira et le jeton.

![Premier lancement de Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_first_run.gif)

Les espaces de travail Fjira stockent les données de configuration Jira dans un simple fichier YAML situé à `~/.fjira`. Vous pouvez basculer entre
plusieurs espaces de travail en utilisant la commande `fjira workspace`.

```shell
fjira workspace
```
Pour créer un nouvel espace de travail, utilisez la commande suivante :


```shell
fjira workspace --new abc
```

Vous pouvez modifier un espace de travail existant en utilisant l’option `--edit` :

```shell
fjira workspace --edit abc
```

### Type de jeton Jira

Fjira prend en charge à la fois Jira Server et Jira Cloud, qui utilisent différents types de jetons pour l'autorisation. L'outil vous invitera
à sélectionner le type de jeton approprié lors de la configuration de l'espace de travail.

```shell
? Jira Token Type:

1. api token
2. personal token

Enter a number (Default is 1):
```

### Configuration YAML

Si vous préférez une approche manuelle, vous avez la possibilité d'ajouter des configurations d'espace de travail en créant un fichier `fjira.yaml` dans le répertoire `~/.fjira/`.  
Pour votre commodité, un fichier de configuration exemple est disponible ici : [fjira.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/fjira.yaml)

## Recherche de projets

La vue par défaut lorsque vous lancez `fjira` est l'écran de recherche de projets.

```shell
fjira
```

## Ouverture d'un projet spécifique

Vous pouvez ouvrir un projet directement depuis la CLI :

```shell
fjira --project=PROJ
```

Cela permettra de passer l'écran de recherche de projet et de vous emmener directement à l'écran de recherche des problèmes.

## Ouvrir un problème directement

Pour ouvrir un problème directement depuis la CLI :

```shell
fjira PROJ-123
```

Fjira sautera tous les écrans intermédiaires et vous mènera directement à la vue du problème.

![Vue du problème Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_issue.png)

## Vue des tableaux

Fjira propose également une vue de type tableau. Après avoir ouvert un projet, appuyez sur F4 pour accéder à cette vue.

![Vue du tableau Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_board_view.png)

## Requêtes JQL personnalisées

Vous pouvez créer et exécuter des requêtes JQL personnalisées avec Fjira :

```shell
fjira jql
```

![Fjira Custom JQL](https://raw.githubusercontent.com/mk-5/fjira/master/demo_custom_jql.png)

## My Jira Filters

You can search using your stored (favourites) Jira Filters:

```shell
fjira filters
```

![Filtres Fjira](https://raw.githubusercontent.com/mk-5/fjira/master/demo_filters.png)

## Schéma de couleurs personnalisé

Adaptez le schéma de couleurs fjira à vos préférences en créant un fichier personnalisé `~/.fjira/colors.yml`. Ce fichier
vous permet de personnaliser les couleurs selon votre style unique.
Référez-vous au fichier exemple, situé ici : [colors.yml](https://raw.githubusercontent.com/mk-5/fjira/master/assets/colors.yml)

## Feuille de route (À FAIRE)

- Étendre la documentation
- Créer & Supprimer des filtres Jira
- Supporter des gestionnaires de paquets Linux supplémentaires (Apt, AUR, YUM)
- Introduire plus de fonctionnalités Jira

## Motivation

Fjira a été conçu pour la commodité personnelle, né d’un désir d’efficacité et d’un amour pour les outils en terminal.
Souvent, on se retrouve dans la situation « Je dois juste faire passer le ticket 123 au statut suivant. » Bien que
l’ouverture de Jira, la localisation du ticket sur le tableau, et la navigation dans la fenêtre du ticket Jira soient
parfaitement acceptables, cela prend quand même pas mal de temps.

Fjira vous permet d’exécuter ces tâches directement depuis le terminal, là où vous travaillez probablement déjà ! 😄

Si Fjira améliore votre expérience Jira comme cela a été le cas pour moi, merci de lui attribuer une étoile sur GitHub. 🌟 Cela me donnera
de l’énergie pour un futur travail.

N’hésitez pas à contribuer à ce projet et à façonner son avenir ! Vos retours et contributions sont très
appréciés.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---