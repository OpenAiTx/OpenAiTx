# Streaker <img alt="Streaker Logo" align="right" width=40 height=40 alt="Capture d'écran" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/./.github/icons/icon.svg">

Application de barre de menu multiplateforme pour le suivi des séries et statistiques de contributions GitHub avec notification de rappel

[![ci](https://github.com/jamieweavis/streaker/actions/workflows/ci.yml/badge.svg)](https://github.com/jamieweavis/streaker/actions)
[![downloads](https://img.shields.io/github/downloads/jamieweavis/streaker/total.svg)](https://github.com/jamieweavis/streaker/releases)
[![version](https://img.shields.io/github/release/jamieweavis/streaker.svg)](https://github.com/jamieweavis/streaker/releases)
[![license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/jamieweavis/streaker/blob/main/LICENSE)

<img width="716" alt="Capture d'écran" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/screenshot.png">

## Installation

Téléchargez la dernière version de Streaker depuis la page **[GitHub releases](https://github.com/jamieweavis/streaker/releases)** (ou consultez la section **[Développement](#development)** pour le compiler vous-même).

## Fonctionnalités

- Statistiques de contributions dans la barre de menu
  - Série
    - Meilleure
    - Actuelle
    - Précédente
  - Contributions
    - Maximum (jour)
    - Aujourd'hui
    - Total (année)
- L'icône de la barre de menu change selon le statut des contributions
  - Vide - vous n'avez pas contribué aujourd'hui
  - Rempli - vous avez contribué aujourd'hui
  - Couronne - vous êtes actuellement sur votre meilleure série
- Trois thèmes d'icônes pour la barre de menu
  - Flamme
  - Carreau
  - Octocat
- Notification de rappel pour ne pas perdre votre série

### Icônes de la barre de menu

#### Mode clair

| État | Flamme | Tuile | Octocat |
| ----- | ----- | ---- | ------- |
| En attente | <img width="20" alt="Flamme Vide" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac.svg"> | <img width="20" alt="Tuile Vide" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac.svg"> | <img width="20" alt="Octocat Vide" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac.svg"> |
| Contribué | <img width="20" alt="Flamme Contribuée" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac.svg"> | <img width="20" alt="Tuile Contribuée" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac.svg"> | <img width="20" alt="Octocat Contribué" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac.svg"> |
| En série | <img width="20" alt="Flamme Couronne" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac.svg"> | <img width="20" alt="Tuile En série" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac.svg"> | <img width="20" alt="Octocat En série" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac.svg"> |

#### Mode sombre

| État | Flamme | Tuile | Octocat |
| ----- | ----- | ---- | ------- |
| En attente | <img width="20" alt="Flamme Vide" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-flame-mac-white.svg"> | <img width="20" alt="Tuile Vide" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-tile-mac-white.svg"> | <img width="20" alt="Octocat Vide" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/pending-octocat-mac-white.svg"> |
| Contribué | <img width="20" alt="Flamme Contribuée" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-flame-mac-white.svg"> | <img width="20" alt="Tuile Contribuée" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-tile-mac-white.svg"> | <img width="20" alt="Octocat Contribué" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/contributed-octocat-mac-white.svg"> |
| En série | <img width="20" alt="Flamme Couronne" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-flame-mac-white.svg"> | <img width="20" alt="Tuile En série" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-tile-mac-white.svg"> | <img width="20" alt="Octocat En série" src="https://raw.githubusercontent.com/jamieweavis/streaker/main/.github/icons/streaking-octocat-mac-white.svg"> |

## Développement

### Prérequis

- [Node.js](https://github.com/nodejs/node) (>=22.x.x)
- [pnpm](https://github.com/pnpm/pnpm) (>=10.x.x)

### Pour commencer

Clonez le dépôt et installez les dépendances :

```sh
git clone https://github.com/jamieweavis/streaker.git

cd streaker

pnpm install
```

Emballez l'application pour votre plateforme actuelle :
```bash
pnpm package
```
_L'application empaquetée sera maintenant dans le répertoire `out/`_

Exécutez l'application en mode développement :

```bash
pnpm start
```
*Seul le processus de rendu prend actuellement en charge le rechargement à chaud, les modifications dans `src/main/` nécessiteront un redémarrage*

## Liens associés

- [Streaker CLI](https://github.com/jamieweavis/streaker-cli) - Application en ligne de commande pour le suivi des séries de contributions et des statistiques GitHub avec graphique de contribution ASCII
- [Contribution](https://github.com/jamieweavis/contribution) - Analyseur de graphique de contribution GitHub qui calcule la série de contributions et les statistiques de commits à partir de la page de graphique de contribution d'un utilisateur GitHub



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-11

---