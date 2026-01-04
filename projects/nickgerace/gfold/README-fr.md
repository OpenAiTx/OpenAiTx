# gfold

[![latest release tag](https://img.shields.io/github/v/tag/nickgerace/gfold?sort=semver&logo=git&logoColor=white&label=version&style=for-the-badge&color=blue)](https://github.com/nickgerace/gfold/releases/latest)
[![crates.io version](https://img.shields.io/crates/v/gfold?style=for-the-badge&logo=rust&color=orange)](https://crates.io/crates/gfold)
[![build status](https://img.shields.io/github/actions/workflow/status/nickgerace/gfold/ci.yml?branch=main&style=for-the-badge&logo=github&logoColor=white)](https://github.com/nickgerace/gfold/actions)
[![calver](https://img.shields.io/badge/calver-YYYY.MM.MICRO-cyan.svg?style=for-the-badge)](https://calver.org)

`gfold` est un outil en ligne de commande qui vous aide à suivre plusieurs dépôts Git.

[![Un GIF montrant gfold en action](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)](https://raw.githubusercontent.com/nickgerace/gfold/main/assets/demo.gif)

Si vous préférez utiliser le mode d'affichage classique par défaut, et éviter de définir l'option à chaque fois, vous pouvez la configurer dans le fichier de configuration (voir la section **Usage**).

## Annonce (février 2025)

Toutes les versions suivent désormais le schéma de versionnage [CalVer](https://calver.org/), à partir de `2025.2.1`.
Ce changement est compatible à la fois en avant et en arrière avec le schéma de versionnage [Semantic Versioning](https://semver.org/spec/v2.0.0.html), utilisé depuis la première version jusqu'à la version `4.6.0`.

*Aucune action de la part de l'utilisateur final n'est requise spécifiquement pour ce changement de schéma de versionnage.*

Cette annonce sera finalement retirée de ce [README](https://raw.githubusercontent.com/nickgerace/gfold/main/./README.md) et sera déplacée dans le [CHANGELOG](https://raw.githubusercontent.com/nickgerace/gfold/main/./CHANGELOG.md).

## Description

Cette application affiche des informations pertinentes pour plusieurs dépôts Git dans un ou plusieurs répertoires.
Elle ne fait que lire le système de fichiers et n'écrit jamais dedans.
Bien que cet outil puisse sembler limité en portée et en but, cela est intentionnel.

Par défaut, `gfold` examine chaque dépôt Git via une traversée depuis le répertoire de travail courant.
Si vous souhaitez cibler un autre répertoire, vous pouvez passer son chemin (relatif ou absolu) en premier argument ou changer le chemin par défaut dans le fichier de configuration.

Après la traversée, `gfold` utilise [rayon](https://github.com/rayon-rs/rayon) pour effectuer une analyse concurrente en lecture seule de tous les dépôts Git détectés.
L'analyse est réalisée en utilisant la bibliothèque [git2-rs](https://github.com/rust-lang/git2-rs).

## Usage

Fournissez l'option `-h/--help` pour voir toutes les options d'utilisation de cette application.

```shell
# Operate in the current working directory or in the location provided by a config file, if one exists.
gfold

# Operate in the parent directory.
gfold ..

# Operate in the home directory (first method).
gfold $HOME

# Operate in the home directory (second method).
gfold ~/

# Operate with an absolute path.
gfold /this/is/an/absolute/path

# Operate with a relative path.
gfold ../../this/is/a/relative/path

# Operate with three paths.
gfold ~/src ~/projects ~/code
```

### Fichier de configuration

Si vous vous retrouvez à fournir fréquemment les mêmes arguments, vous pouvez créer et utiliser un fichier de configuration.  
`gfold` n’est pas livré avec un fichier de configuration par défaut et les fichiers de configuration sont entièrement optionnels.

Comment cela fonctionne-t-il ?  
Lors de l’exécution, `gfold` recherchera un fichier de configuration aux emplacements suivants (dans l’ordre) :

- `$XDG_CONFIG_HOME/gfold.toml`  
- `$XDG_CONFIG_HOME/gfold/config.toml`  
- `$HOME/.config/gfold.toml`

`$XDG_CONFIG_HOME` fait référence à la variable d’environnement littérale `XDG_CONFIG_HOME`, mais utilisera par défaut le chemin spécifique au système d’exploitation approprié si elle n’est pas définie (voir [`user_dirs`](https://github.com/uncenter/user_dirs) pour plus d’informations).

Si un fichier de configuration est trouvé, `gfold` le lira et utilisera les options spécifiées à l’intérieur.

Pour créer un fichier de configuration, vous pouvez utiliser le flag `--dry-run` pour afficher un TOML valide.  
Voici un exemple de workflow de création de fichier de configuration sur macOS, Linux et plateformes similaires :

```shell
gfold -d classic -c never ~/ --dry-run > $HOME/.config/gfold.toml
```

Voici le contenu du fichier de configuration résultant :

```toml
paths = ['/home/neloth']
display_mode = 'Classic'
color_mode = 'Never'
```
Disons que vous avez créé un fichier de configuration, mais que vous souhaitez exécuter `gfold` avec des paramètres entièrement différents _et_ vous voulez vous assurer de ne pas hériter accidentellement des options du fichier de configuration.  
Dans ce cas, vous pouvez ignorer votre fichier de configuration en utilisant l’option `-i`.



```shell
gfold -i
```

Vous pouvez restaurer le fichier de configuration à ses valeurs par défaut en utilisant le même indicateur.

```shell
gfold -i > $HOME/.config/gfold.toml
```

De plus, vous pouvez ignorer le fichier de configuration existant, configurer des options spécifiques et utiliser les valeurs par défaut pour les options non spécifiées, le tout en une seule fois.
Voici un exemple où nous voulons utiliser le mode d'affichage classique et remplacer tous les autres paramètres par leurs valeurs par défaut :

```shell
gfold -i -d classic > $HOME/.config/gfold.toml
```

Vous pouvez sauvegarder un fichier de configuration et suivre son historique avec `git`.  
Sur macOS, Linux et la plupart des systèmes, vous pouvez lier le fichier à un dépôt `git`.  

```shell
ln -s <path-to-repository>/gfold.toml $HOME/.config/gfold.toml
```

Vous pouvez maintenant mettre à jour le fichier de configuration dans votre dépôt et inclure le lien dans votre flux de configuration de l’environnement.

## Installation

[![Statut du packaging](https://repology.org/badge/vertical-allrepos/gfold.svg)](https://repology.org/project/gfold/versions)

### Homebrew (macOS et Linux)

Vous pouvez utiliser [Homebrew](https://brew.sh) pour installer `gfold` en utilisant la [formule core](https://formulae.brew.sh/formula/gfold).

Cependant, vous pouvez rencontrer un conflit de nommage sur macOS si [coreutils](https://formulae.brew.sh/formula/coreutils) est installé via `brew`.
Consultez la section [dépannage](#troubleshooting-and-known-issues) pour une solution et plus d’informations.

```shell
brew install gfold
```

### Arch Linux

Vous pouvez utiliser [pacman](https://wiki.archlinux.org/title/Pacman) pour installer `gfold` depuis le [dépôt extra](https://archlinux.org/packages/extra/x86_64/gfold/).

```shell
pacman -S gfold
```

### Nix et NixOS

Vous pouvez installer `gfold` depuis [nixpkgs](https://github.com/NixOS/nixpkgs/blob/master/pkgs/applications/version-management/gfold/default.nix) :

```shell
nix-env --install gfold
```

Si vous utilisez [flakes](https://nixos.wiki/wiki/Flakes), vous pouvez installer en utilisant directement la commande `nix`.

```shell
nix profile install "nixpkgs#gfold"
```

### Cargo

Vous pouvez utiliser [cargo](https://crates.io) pour installer la [crate](https://crates.io/crates/gfold) sur presque toutes les plateformes.

```shell
cargo install gfold
```
Utilisez le drapeau `--locked` si vous souhaitez que Cargo utilise `Cargo.lock`.


```shell
cargo install --locked gfold
```

Maintenir la crate à jour est facile avec [cargo-update](https://crates.io/crates/cargo-update).

```shell
cargo install cargo-update
cargo install-update -a
```

### Télécharger un binaire

Si vous ne souhaitez pas utiliser l'une des méthodes d'installation ci-dessus et ne voulez pas cloner le dépôt, vous pouvez télécharger un binaire depuis la page [releases](https://github.com/nickgerace/gfold/releases).
Pour un exemple sur la façon de procéder, consultez le guide [installation manuelle](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md).

### Compiler depuis les sources

Si vous souhaitez un exemple sur la façon de compiler depuis les sources, consultez le guide [installation manuelle](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/MANUAL_INSTALL.md).

### Obsolète : Tap Homebrew (macOS uniquement)

Le [tap situé à nickgerace/homebrew-nickgerace](https://github.com/nickgerace/homebrew-nickgerace/blob/main/Formula/gfold.rb) a été abandonné.
Veuillez utiliser le paquet Homebrew core mentionné ci-dessus à la place.

### Méthode d'installation préférée non listée ?

Veuillez [ouvrir une issue](https://github.com/nickgerace/gfold/issues/new) !

## Compatibilité

`gfold` est destiné à être exécuté sur _n'importe quelle_ cible Rust 🦀 de niveau un.
Veuillez [ouvrir une issue](https://github.com/nickgerace/gfold/issues) si votre plateforme n'est pas prise en charge.

## Dépannage et problèmes connus

Si vous rencontrez un comportement inattendu ou un bug et souhaitez voir plus de détails, veuillez exécuter avec une verbosité accrue.

```shell
gfold -vvv
```

Si le problème persiste, veuillez [signaler un problème](https://github.com/nickgerace/gfold/issues).
Veuillez joindre les journaux pertinents de l'exécution avec _les parties sensibles masquées_ afin d'aider à résoudre votre problème.

### Collision Coreutils sur macOS

Si `fold` de [GNU Coreutils](https://www.gnu.org/software/coreutils/) est installé sur macOS via `brew`, il sera nommé `gfold`.
Vous pouvez éviter cette collision avec des alias shell, des fonctions shell, et/ou des modifications du `PATH`.
Voici un exemple avec le `o` retiré de `gfold` :

```shell
alias gfld=$HOME/.cargo/bin/gfold
```

## Communauté

Pour plus d'informations et pour remercier les utilisateurs ainsi que la "communauté" au sens large, veuillez consulter le fichier **[COMMUNITY THANKS](https://raw.githubusercontent.com/nickgerace/gfold/main/./docs/COMMUNITY_THANKS.md)**.

- [Packages pour NixOS, Arch Linux et plus](https://repology.org/project/gfold/versions)
- ["Cent binaires Rust"](https://www.wezm.net/v2/posts/2020/100-rust-binaries/page2/), un article présentant `gfold`
- [nvim-gfold.lua](https://github.com/AckslD/nvim-gfold.lua), un plugin `neovim` pour `gfold` _([annonce sur Reddit](https://www.reddit.com/r/neovim/comments/t209wy/introducing_nvimgfoldlua/))_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-04

---