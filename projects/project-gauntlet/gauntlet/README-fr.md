# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Lanceur d'applications multiplateforme centré sur le web avec plugins basés sur React

> [!WARNING]
> Le lanceur est développé par un seul développeur pendant son temps libre.
> Les changements peuvent être lents mais constants
>
> Il y aura probablement des changements incompatibles qui seront documentés dans le [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Démonstration

Démo légèrement obsolète

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Fonctionnalités

- Priorité aux plugins
  - Les plugins sont écrits en TypeScript
  - API de plugin étendue
      - Créer des vues UI
      - Commandes à usage unique
      - Fournir dynamiquement une liste de commandes à usage unique
      - Afficher un contenu rapide "en ligne" directement sous la barre de recherche principale en fonction de sa valeur
      - Obtenir du contenu du presse-papiers et y ajouter du contenu
  - Les plugins sont distribués sous forme de branche séparée dans un dépôt Git, ce qui signifie que la distribution de plugins ne nécessite aucun serveur central
  - Les IDs de plugins sont simplement des URLs de dépôts Git
  - UI des plugins basée sur [React](https://github.com/facebook/react)
    - Implémentée avec un React Reconciler personnalisé (sans Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno permet d'isoler le code JavaScript des plugins pour une meilleure sécurité
    - Les plugins doivent spécifier explicitement les permissions dont ils ont besoin pour fonctionner
    - Node.js est utilisé pour exécuter les outils de développement de plugins, mais en tant que développeur de plugin vous écrirez toujours du code qui tourne sur Deno
- Conçu dès le départ pour le multiplateforme
- Les commandes et vues peuvent être lancées/ouvertes via des raccourcis globaux personnalisés
- Des alias de recherche personnalisés peuvent être assignés aux commandes ou vues
- Prise en charge de thèmes personnalisés
- Fonctionnalités natives fournies par des plugins intégrés
  - Applications : affiche les applications installées sur le système dans les résultats de recherche
    - Le plugin suit aussi les fenêtres et à quelle application elles appartiennent, donc ouvrir une application déjà ouverte affichera par défaut la fenêtre précédemment créée
      - Tous les systèmes ne sont pas encore pris en charge. Voir [support des fonctionnalités](https://gauntlet.sh/docs/feature-support)
  - Calculatrice : affiche le résultat des opérations mathématiques directement sous la barre de recherche principale
    - Inclut la conversion de devises via les taux de change
    - Propulsé par [Numbat](https://github.com/sharkdp/numbat)
- Classement des résultats de recherche basé sur la "frecency"
   - La "frecency" est une combinaison de fréquence et de récence
   - Plus un élément est utilisé souvent, plus il sera haut dans la liste de résultats, mais les éléments utilisés surtout dans le passé seront classés plus bas que ceux utilisés récemment le même nombre de fois
   - Les résultats sont filtrés par mot via une sous-chaîne

##### Support OS

##### Officiel
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Au mieux
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland n'est pas encore supporté, voir [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Prise en main

### Installer Gauntlet

Voir [Installation](https://gauntlet.sh/docs/installation)

### Raccourci global

La fenêtre principale peut être ouverte avec un raccourci global ou une commande CLI :
- Raccourci global (modifiable dans les paramètres)
  - Windows : <kbd>ALT</kbd> + <kbd>Espace</kbd>
  - Linux X11 : <kbd>Super</kbd> + <kbd>Espace</kbd>
  - Linux Wayland
    - Le raccourci global peut ne pas être pris en charge, voir [support des fonctionnalités](https://gauntlet.sh/docs/feature-support)
    - Veuillez utiliser la commande CLI à la place, et l'invoquer via la méthode spécifique à votre gestionnaire de fenêtres
  - macOS : <kbd>CMD</kbd> + <kbd>Espace</kbd>
- Commande CLI
  - `gauntlet open`

### Installer un plugin

Les plugins s'installent dans l'interface des paramètres. Utilisez l'url du dépôt Git du plugin pour l'installer, par exemple `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Créez votre propre plugin

Voir [Démarrage du développement de plugins](https://gauntlet.sh/docs/plugin-development/getting-started)

## Thématisation

Voir [Thématisation](https://gauntlet.sh/docs/theming)

## Compiler Gauntlet

Vous aurez besoin de :
- NodeJS
- Rust
- Protobuf Compiler
- CMake (non utilisé directement par le projet, mais requis par une dépendance)
- Sous Linux : `libxkbcommon-dev` (note : le nom peut varier selon la distribution utilisée)

### Dev

Pour compiler en mode dev :
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
En mode dev (sans l'option "release"), l'application utilise UNIQUEMENT des dossiers à l'intérieur du répertoire du projet pour stocker l'état ou le cache, afin d'éviter de perturber une installation globale

### Non-packagé

Pour compiler un binaire release non encore packagé :
```bash
npm ci
npm run build
cargo build --release --features release
```

### Packagé
Pour compiler un paquet spécifique à un OS, lancez l'une des commandes suivantes :

macOS :
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows :
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux :
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Mais la publication de la nouvelle version doit se faire via GitHub Actions

## Contribuer

Si vous souhaitez aider au développement de Gauntlet, il y a plus de moyens que simplement contribuer au code :
- Signaler un bug ou un problème d'UI/UX
- Créer un plugin

Pour les problèmes simples, n'hésitez pas à ouvrir une issue ou une PR et à la traiter vous-même.
Pour des changements plus importants, veuillez contacter les créateurs sur Discord (lien d'invitation en haut du README) et en discuter d'abord.

Toutes les contributions sont les bienvenues.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---