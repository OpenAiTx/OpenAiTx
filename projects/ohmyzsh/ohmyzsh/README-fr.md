<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh est un framework open source, animé par la communauté, pour gérer votre configuration [zsh](https://www.zsh.org/).

Ça a l’air ennuyeux. Essayons encore.

**Oh My Zsh ne fera pas de vous un développeur 10x... mais vous pourriez avoir cette impression.**

Une fois installé, votre shell terminal deviendra la star du quartier _ou remboursé !_ À chaque frappe sur votre invite de commande, vous profiterez de centaines de plugins puissants et de magnifiques thèmes. Des inconnus viendront vous voir dans les cafés et vous demanderont, _« c’est incroyable ! Êtes-vous un génie ? »_

Enfin, vous commencerez à recevoir l’attention que vous avez toujours estimé mériter. ...ou alors, vous utiliserez le temps gagné pour commencer à passer plus souvent le fil dentaire. 😬

Pour en savoir plus, visitez [ohmyz.sh](https://ohmyz.sh), suivez [@ohmyzsh](https://x.com/ohmyzsh) sur X (anciennement Twitter), et rejoignez-nous sur [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (anciennement Twitter) Suivre](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Suivre](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Serveur Discord](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Table des matières</summary>

- [Démarrage](#getting-started)
  - [Compatibilité des systèmes d’exploitation](#operating-system-compatibility)
  - [Prérequis](#prerequisites)
  - [Installation de base](#basic-installation)
    - [Inspection manuelle](#manual-inspection)
- [Utilisation de Oh My Zsh](#using-oh-my-zsh)
  - [Plugins](#plugins)
    - [Activation des plugins](#enabling-plugins)
    - [Utilisation des plugins](#using-plugins)
  - [Thèmes](#themes)
    - [Sélection d’un thème](#selecting-a-theme)
  - [FAQ](#faq)
- [Sujets avancés](#advanced-topics)
  - [Installation avancée](#advanced-installation)
    - [Répertoire personnalisé](#custom-directory)
    - [Installation non-interactive](#unattended-install)
    - [Installation depuis un dépôt forké](#installing-from-a-forked-repository)
    - [Installation manuelle](#manual-installation)
  - [Problèmes d’installation](#installation-problems)
  - [Plugins et thèmes personnalisés](#custom-plugins-and-themes)
  - [Activer GNU ls sur macOS et freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Ignorer les alias](#skip-aliases)
  - [Invite git asynchrone](#async-git-prompt)
- [Obtenir les mises à jour](#getting-updates)
  - [Verbosité des mises à jour](#updates-verbosity)
  - [Mises à jour manuelles](#manual-updates)
- [Désinstaller Oh My Zsh](#uninstalling-oh-my-zsh)
- [Comment contribuer à Oh My Zsh ?](#how-do-i-contribute-to-oh-my-zsh)
  - [Ne nous envoyez pas de thèmes](#do-not-send-us-themes)
- [Contributeurs](#contributors)
- [Suivez-nous](#follow-us)
- [Boutique](#merchandise)
- [Licence](#license)
- [À propos de Planet Argon](#about-planet-argon)

</details>

## Démarrage

### Compatibilité des systèmes d’exploitation

| Système        | Statut |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Prérequis

- [Zsh](https://www.zsh.org) doit être installé (v4.3.9 ou plus récent fonctionne, mais nous préférons 5.0.8 ou plus). S’il n’est pas préinstallé (exécutez `zsh --version` pour vérifier), consultez les instructions du wiki ici : [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` ou `wget` doit être installé
- `git` doit être installé (recommandé : v2.4.11 ou supérieur)

### Installation de base

Oh My Zsh s’installe en exécutant l’une des commandes suivantes dans votre terminal. Vous pouvez installer via la ligne de commande avec `curl`, `wget` ou un outil similaire.

| Méthode    | Commande                                                                                           |
| :--------- | :------------------------------------------------------------------------------------------------- |
| **curl**   | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`  |
| **wget**   | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`    |
| **fetch**  | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`  |

Alternativement, l’installeur est aussi en miroir hors de GitHub. L’utilisation de cette URL peut être nécessaire si vous êtes dans un pays comme la Chine ou l’Inde (pour certains FAI), qui bloque `raw.githubusercontent.com` :

| Méthode    | Commande                                           |
| :--------- | :------------------------------------------------- |
| **curl**   | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"`  |
| **wget**   | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`    |
| **fetch**  | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"`  |

_Remarque : tout `.zshrc` existant sera renommé en `.zshrc.pre-oh-my-zsh`. Après l’installation, vous pouvez déplacer dans le nouveau `.zshrc` la configuration que vous souhaitez conserver._

#### Inspection manuelle

Il est recommandé d’inspecter le script d’installation de projets que vous ne connaissez pas encore. Vous pouvez le faire en téléchargeant d’abord le script d’installation, en le lisant pour vérifier qu’il vous paraît normal, puis en l’exécutant :

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Si l’URL ci-dessus expire ou échoue, vous devrez peut-être remplacer l’URL par `https://install.ohmyz.sh` pour obtenir le script.

## Utilisation de Oh My Zsh

### Plugins

Oh My Zsh est livré avec une tonne de plugins dont vous pouvez profiter. Vous pouvez jeter un œil dans le répertoire [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) et/ou sur le [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) pour voir ce qui est disponible actuellement.

#### Activation des plugins

Une fois que vous avez repéré un plugin (ou plusieurs) que vous souhaitez utiliser avec Oh My Zsh, vous devez les activer dans le fichier `.zshrc`. Vous trouverez le fichier zshrc dans votre répertoire `$HOME`. Ouvrez-le avec votre éditeur de texte favori et vous verrez un emplacement pour lister tous les plugins que vous souhaitez charger.

```sh
vi ~/.zshrc
```

Par exemple, cela pourrait ressembler à ceci :

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Remarque : les plugins sont séparés par des espaces (espaces, tabulations, retours à la ligne, etc.). **N’utilisez pas** de virgules entre eux, cela casserait le fonctionnement._

#### Utilisation des plugins

Chaque plugin intégré inclut un **README** qui le documente. Ce README indique les alias (si le plugin en ajoute) et les fonctionnalités supplémentaires fournies par ce plugin.

### Thèmes

Nous l’admettons. Au début de l’aventure Oh My Zsh, nous avons peut-être eu un peu trop la folie des thèmes. Nous avons maintenant plus de cent cinquante thèmes inclus. La plupart disposent de [captures d’écran](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) sur le wiki (nous travaillons à la mise à jour !). Allez les découvrir !

#### Sélection d’un thème

_Le thème de Robby est celui par défaut. Ce n’est pas le plus sophistiqué. Ce n’est pas le plus simple. C’est simplement le bon (pour lui)._

Une fois que vous avez trouvé un thème que vous souhaitez utiliser, vous devez éditer le fichier `~/.zshrc`. Vous verrez une variable d’environnement (en majuscules) ressemblant à :

```sh
ZSH_THEME="robbyrussell"
```

Pour utiliser un autre thème, il suffit de changer la valeur par le nom du thème souhaité. Par exemple :

```sh
ZSH_THEME="agnoster" # (celui-ci est l’un des plus stylés)
# voir https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> Il arrive souvent que vous voyiez une capture d’écran d’un thème zsh, que vous l’essayiez, et que le rendu ne soit pas le même chez vous.
>
> C’est parce que beaucoup de thèmes nécessitent l’installation d’une [Police Powerline](https://github.com/powerline/fonts) ou d’une [Nerd Font](https://github.com/ryanoasis/nerd-fonts) pour s’afficher correctement. Sans elles, ces thèmes afficheront des symboles étranges dans l’invite. Consultez [la FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) pour plus d’informations.
>
> À noter également : les thèmes ne contrôlent que l’apparence de votre invite de commande, c’est-à-dire le texte affiché avant ou après votre curseur, là où vous tapez vos commandes. Les thèmes ne contrôlent pas, par exemple, les couleurs de la fenêtre du terminal (appelées _schéma de couleurs_) ou la police du terminal. Ce sont des paramètres à changer dans votre émulateur de terminal. Pour plus d’informations, voir [qu’est-ce qu’un thème zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Ouvrez une nouvelle fenêtre de terminal et votre invite devrait ressembler à ceci :

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Si vous n’avez pas trouvé de thème qui vous convient, jetez un œil au wiki pour [en voir plus](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Si vous vous sentez joueur, vous pouvez laisser l’ordinateur en choisir un au hasard à chaque nouvelle ouverture de terminal.

```sh
ZSH_THEME="random" # (...pourvu que ce soit pie... pourvu que ce soit pie...)
```

Et si vous souhaitez choisir un thème au hasard parmi une liste de vos thèmes favoris :

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Si vous savez uniquement quels thèmes vous n’aimez pas, vous pouvez les ajouter de la même façon à une liste à ignorer :

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Si vous avez d’autres questions ou problèmes, vous trouverez peut-être une solution dans notre [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Sujets avancés

Si vous aimez mettre les mains dans le cambouis, ces sections devraient vous intéresser.

### Installation avancée

Certains utilisateurs peuvent vouloir installer Oh My Zsh manuellement, ou changer le chemin par défaut ou d’autres paramètres acceptés par l’installeur (ces paramètres sont aussi documentés en haut du script d’installation).

#### Répertoire personnalisé

L’emplacement par défaut est `~/.oh-my-zsh` (caché dans votre dossier personnel, accessible via `cd ~/.oh-my-zsh`)

Si vous souhaitez changer le répertoire d’installation avec la variable d’environnement `ZSH`, soit en exécutant `export ZSH=/votre/chemin` avant l’installation, soit en la définissant avant la fin du pipeline d’installation comme ceci :

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Installation non-interactive

Si vous exécutez le script d’installation de Oh My Zsh dans le cadre d’une installation automatisée, vous pouvez passer l’option `--unattended` au script `install.sh`. Cela aura pour effet de ne pas essayer de changer le shell par défaut, et n’exécutera pas `zsh` à la fin de l’installation.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Si vous êtes en Chine, en Inde ou dans un autre pays qui bloque `raw.githubusercontent.com`, vous devrez peut-être remplacer l’URL par `https://install.ohmyz.sh` pour l’installation.

#### Installation depuis un dépôt forké

Le script d’installation accepte aussi ces variables pour permettre l’installation d’un autre dépôt :

- `REPO` (défaut : `ohmyzsh/ohmyzsh`) : au format `propriétaire/dépôt`. Si vous définissez cette variable, l’installeur cherchera un dépôt à `https://github.com/{propriétaire}/{dépôt}`.

- `REMOTE` (défaut : `https://github.com/${REPO}.git`) : l’URL complète du clone git. Utilisez ce paramètre si vous souhaitez installer depuis un fork qui n’est pas sur GitHub (GitLab, Bitbucket...) ou cloner en SSH au lieu de HTTPS (`git@github.com:user/project.git`).

  _REMARQUE : incompatible avec la variable `REPO`. Ce paramètre a la priorité._

- `BRANCH` (défaut : `master`) : utilisez ce paramètre pour changer la branche par défaut qui sera extraite lors du clonage. Cela peut être utile pour tester une Pull Request, ou si vous voulez utiliser une branche autre que `master`.

Par exemple :

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Installation manuelle

##### 1. Cloner le dépôt <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Optionnellement_, sauvegarder votre fichier `~/.zshrc` existant <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Créer un nouveau fichier de configuration zsh <!-- omit in toc -->

Vous pouvez créer un nouveau fichier de configuration zsh en copiant le modèle que nous avons inclus pour vous.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Changer votre shell par défaut <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Vous devez fermer puis rouvrir votre session utilisateur pour voir ce changement.

##### 5. Initialiser votre nouvelle configuration zsh <!-- omit in toc -->

Dès que vous ouvrez une nouvelle fenêtre de terminal, zsh devrait se charger avec la configuration Oh My Zsh.

### Problèmes d’installation

Si vous rencontrez des problèmes lors de l’installation, voici quelques corrections courantes.

- Vous devrez _peut-être_ modifier votre `PATH` dans `~/.zshrc` si vous ne trouvez pas certaines commandes après être passé à `oh-my-zsh`.
- Si vous avez installé manuellement ou changé l’emplacement d’installation, vérifiez la variable d’environnement `ZSH` dans `~/.zshrc`.

### Plugins et thèmes personnalisés

Si vous souhaitez remplacer certains comportements par défaut, ajoutez simplement un nouveau fichier (se terminant par `.zsh`) dans le répertoire `custom/`.

Si vous avez plusieurs fonctions qui vont bien ensemble, vous pouvez les placer dans un fichier `XYZ.plugin.zsh` dans le répertoire `custom/plugins/` puis activer ce plugin.

Si vous souhaitez remplacer la fonctionnalité d’un plugin distribué avec Oh My Zsh, créez un plugin du même nom dans le répertoire `custom/plugins/` et il sera chargé à la place de celui dans `plugins/`.

### Activer GNU ls sur macOS et freeBSD

<a name="enable-gnu-ls"></a>

Le comportement par défaut dans Oh My Zsh est d’utiliser `ls` version BSD sur macOS et FreeBSD. Si GNU `ls` est installé (en tant que commande `gls`), vous pouvez choisir de l’utiliser à la place. Pour cela, utilisez la configuration basée sur zstyle avant de sourcer `oh-my-zsh.sh` :

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Remarque : ceci n’est pas compatible avec `DISABLE_LS_COLORS=true`_

### Ignorer les alias

<a name="remove-directories-aliases"></a>

Si vous souhaitez ignorer les alias par défaut de Oh My Zsh (ceux définis dans les fichiers `lib/*`) ou les alias de plugins, vous pouvez utiliser les paramètres suivants dans votre fichier `~/.zshrc`, **avant que Oh My Zsh ne soit chargé**. Notez qu’il existe plusieurs façons d’ignorer les alias, selon vos besoins.

```sh
# Ignorer tous les alias, dans les fichiers lib et les plugins activés
zstyle ':omz:*' aliases no

# Ignorer tous les alias dans les fichiers lib
zstyle ':omz:lib:*' aliases no
# Ignorer uniquement les alias définis dans le fichier lib directories.zsh
zstyle ':omz:lib:directories' aliases no

# Ignorer tous les alias de plugins
zstyle ':omz:plugins:*' aliases no
# Ignorer uniquement les alias du plugin git
zstyle ':omz:plugins:git' aliases no
```

Vous pouvez combiner ces options, les portées plus spécifiques ayant priorité :

```sh
# Ignorer tous les alias de plugins, sauf pour le plugin git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Une version précédente de cette fonctionnalité utilisait ce paramètre, qui a été supprimé :

```sh
zstyle ':omz:directories' aliases no
```

À la place, vous pouvez désormais utiliser :

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Remarque <!-- omit in toc -->

> Cette fonctionnalité est actuellement en phase de test et peut évoluer à l’avenir. Elle n’est pas non plus compatible avec les gestionnaires de plugins tels que zpm ou zinit, qui ne sourcent pas le script d’initialisation (`oh-my-zsh.sh`) où cette fonctionnalité est implémentée.

> Elle ne gère pas non plus actuellement les « alias » définis comme fonctions. Par exemple `gccd`, `ggf` ou `ggl` du plugin git.

### Invite git asynchrone

Les fonctions d’invite asynchrones sont une fonctionnalité expérimentale (incluse le 3 avril 2024) qui permet à Oh My Zsh d’afficher les informations d’invite de manière asynchrone. Cela peut améliorer les performances de l’invite, mais peut ne pas bien fonctionner dans certaines configurations. Nous espérons que ce ne sera pas un problème, mais si vous constatez des dysfonctionnements, vous pouvez désactiver cette fonctionnalité en ajoutant la ligne suivante à votre fichier .zshrc, avant de sourcer Oh My Zsh :

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Si votre problème est que l’invite git n’apparaît plus, vous pouvez essayer de la forcer avec la configuration suivante avant de sourcer `oh-my-zsh.sh`. Si cela ne fonctionne toujours pas, merci d’ouvrir une issue avec votre cas.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Obtenir les mises à jour

Par défaut, une vérification de mise à jour vous sera proposée toutes les 2 semaines. Vous pouvez choisir d’autres modes de mise à jour en ajoutant une ligne à votre fichier `~/.zshrc`, **avant que Oh My Zsh ne soit chargé** :

1. Mise à jour automatique sans confirmation :

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Juste un rappel toutes les quelques jours, s’il y a des mises à jour disponibles :

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Pour désactiver complètement les mises à jour automatiques :

   ```sh
   zstyle ':omz:update' mode disabled
   ```

REMARQUE : vous pouvez contrôler la fréquence de vérification des mises à jour avec le paramètre suivant :

```sh
# Vérifie les mises à jour tous les 7 jours
zstyle ':omz:update' frequency 7
# Vérifie les mises à jour à chaque ouverture du terminal (non recommandé)
zstyle ':omz:update' frequency 0
```

### Verbosité des mises à jour

Vous pouvez aussi limiter la verbosité des mises à jour avec ces paramètres :

```sh
zstyle ':omz:update' verbose default # invite de mise à jour par défaut

zstyle ':omz:update' verbose minimal # seulement quelques lignes

zstyle ':omz:update' verbose silent # seulement les erreurs
```

### Mises à jour manuelles

Si vous souhaitez mettre à jour à tout moment (peut-être qu’un nouveau plugin vient d’être publié et que vous ne voulez pas attendre une semaine ?), il suffit d’exécuter :

```sh
omz update
```

> [!NOTE]
> Si vous voulez automatiser ce processus dans un script, appelez directement le script `upgrade`, comme ceci :
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Voir plus d’options dans la [FAQ : Comment mettre à jour Oh My Zsh ?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **L’UTILISATION DE `omz update --unattended` A ÉTÉ SUPPRIMÉE, CAR ELLE AVAIT DES EFFETS DE BORD.**

Magique ! 🎉

## Désinstaller Oh My Zsh

Oh My Zsh ne convient pas à tout le monde. Vous allez nous manquer, mais nous voulons que la séparation soit facile.

Pour désinstaller `oh-my-zsh`, exécutez simplement `uninstall_oh_my_zsh` depuis la ligne de commande. Cela supprimera Oh My Zsh et restaurera votre configuration précédente de `bash` ou `zsh`.

## Comment contribuer à Oh My Zsh ?

Avant de participer à notre charmante communauté, veuillez lire le [code de conduite](CODE_OF_CONDUCT.md).

Je suis loin d’être un expert [Zsh](https://www.zsh.org/) et je suppose qu’il y a bien des façons d’améliorer les choses – si vous avez des idées pour rendre la configuration plus facile à maintenir (et plus rapide), n’hésitez pas à forker et à envoyer des pull requests !

Nous avons aussi besoin de personnes pour tester les pull requests. Parcourez [les issues ouvertes](https://github.com/ohmyzsh/ohmyzsh/issues) et aidez où vous le pouvez.

Voir [Contributing](CONTRIBUTING.md) pour plus de détails.

### Ne nous envoyez pas de thèmes

Nous avons (plus que) suffisamment de thèmes pour le moment. Merci d’ajouter votre thème à la page wiki des [thèmes externes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

## Contributeurs

Oh My Zsh dispose d’une communauté dynamique d’utilisateurs heureux et de contributeurs talentueux. Sans tout le temps et l’aide de nos contributeurs, Oh My Zsh ne serait pas aussi génial.

Merci infiniment !

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Suivez-nous

Nous sommes présents sur les réseaux sociaux :

- [@ohmyzsh](https://x.com/ohmyzsh) sur X (anciennement Twitter). Suivez-nous !
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) pokez-nous.
- [Instagram](https://www.instagram.com/_ohmyzsh/) taguez-nous sur vos publications Oh My Zsh !
- [Discord](https://discord.gg/ohmyzsh) pour discuter avec nous !

## Boutique

Nous avons des [autocollants, t-shirts et mugs disponibles](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) pour afficher votre amour de Oh My Zsh. Encore une fois, vous deviendrez la star du quartier !

## Licence

Oh My Zsh est publié sous licence [MIT](LICENSE.txt).

## À propos de Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh a été lancé par l’équipe de [Planet Argon](https://www.planetargon.com/?utm_source=github), une [agence de développement Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). Découvrez [nos autres projets open source](https://www.planetargon.com/open-source?utm_source=github).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---