
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Documentation](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Licence](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Téléchargements](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (simulation pour un futur test.yaml)
[//]: # ([![Statut du test]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Une application Rust qui convertit des images de conteneur (Docker, etc.) en dépôts Git. Chaque couche du conteneur est représentée comme un commit Git, préservant l’historique et la structure de l’image d’origine.

![Démonstration d’OCI2Git convertissant l’image nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Fonctionnalités

- Analyse des images Docker et extraction des informations de couche
- Création d’un dépôt Git où chaque couche d’image est représentée comme un commit
- Prise en charge des couches vides (ENV, WORKDIR, etc.) comme commits vides
- Extraction complète des métadonnées au format Markdown
- Architecture extensible pour la prise en charge de différents moteurs de conteneur

## Cas d’utilisation

### Différenciation des couches
Pour le dépannage des problèmes de conteneur, vous pouvez utiliser les puissantes fonctionnalités de comparaison de Git pour identifier exactement ce qui a changé entre deux couches. En exécutant `git diff` entre des commits, les ingénieurs peuvent voir précisément quels fichiers ont été ajoutés, modifiés ou supprimés, ce qui facilite grandement la compréhension de l’impact de chaque instruction Dockerfile et la localisation des modifications problématiques.
![Exemple de diff de couche](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Traçabilité de l’origine
Grâce à `git blame`, les développeurs peuvent rapidement déterminer quelle couche a introduit un fichier ou une ligne de code spécifique. Ceci est particulièrement utile lors du diagnostic de problèmes avec des fichiers de configuration ou des dépendances. Au lieu d’inspecter manuellement chaque couche, vous pouvez immédiatement retracer l’origine de n’importe quel fichier jusqu’à sa couche source et l’instruction Dockerfile correspondante.

### Suivi du cycle de vie d’un fichier
OCI2Git vous permet de suivre le parcours d’un fichier spécifique à travers l’historique de l’image du conteneur. Vous pouvez observer quand un fichier a été créé, comment il a été modifié à travers les couches, et s’il a éventuellement été supprimé. Cette vue complète aide à comprendre l’évolution d’un fichier sans avoir à suivre manuellement les changements sur des dizaines de couches potentielles.

Pour suivre l’historique d’un fichier dans votre image de conteneur — y compris sa première apparition, ses modifications ou sa suppression — vous pouvez utiliser ces commandes Git après conversion :

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
Ces commandes facilitent la traçabilité de l'historique complet de n'importe quel fichier à travers les couches du conteneur, sans la complexité d'extraire et de comparer manuellement les archives tar des couches.

### Analyse Multi-Couches
Parfois, les comparaisons les plus pertinentes proviennent de l'examen des changements à travers plusieurs couches non consécutives. Avec OCI2Git, vous pouvez utiliser les outils de comparaison de Git pour analyser l'évolution des composants sur plusieurs étapes de construction, identifiant des motifs invisibles en regardant uniquement les couches adjacentes.

### Exploration des Couches
En utilisant `git checkout` pour passer à un commit spécifique, vous pouvez examiner le système de fichiers du conteneur tel qu'il existait à cette couche. Cela permet aux développeurs d'inspecter l'état précis des fichiers et répertoires à n'importe quel moment du processus de création de l'image, fournissant un contexte précieux lors du débogage ou de l'examen du comportement du conteneur.
![Checkout to previous commit](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Analyse Multi-Images

Lorsqu'on travaille avec plusieurs images de conteneurs partageant une ascendance commune, OCI2Git crée intelligemment des branches uniquement lorsque les images divergent réellement. Cela permet d'analyser plusieurs images liées dans un seul dépôt tout en conservant leur histoire commune.


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

OCI2Git détecte automatiquement les couches partagées entre les images et crée une structure de branches qui reflète leur base commune. L’historique Git affichera :
- Un tronc commun contenant toutes les couches partagées
- Des branches séparées qui ne divergent que lorsque les images sont réellement différentes
- Une visualisation claire des endroits où les images partagent un ancêtre commun et où elles deviennent uniques
- Gestion intelligente des doublons : si la même image exacte est traitée deux fois, l’algorithme le détecte avant le commit final des métadonnées et évite de créer une branche en double

Cette approche est particulièrement utile pour :
- **Analyse de familles d’images** : Comprendre comment les différentes variantes d’une image (différentes versions, architectures ou configurations) sont liées
- **Impact de l’image de base** : Visualiser précisément comment les modifications apportées à une image de base affectent plusieurs images dérivées
- **Opportunités d’optimisation** : Identifier les composants partagés qui pourraient être mieux exploités entre les variantes d’images

![Structure du dépôt multi-image montrant la base partagée et les branches divergentes](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Cas d’utilisation supplémentaires

- **Audit de sécurité** : Identifier précisément quand des paquets ou des configurations vulnérables ont été introduits et les relier à des instructions de build spécifiques.
- **Optimisation d’image** : Analyser la structure des couches pour trouver des opérations redondantes ou des fichiers volumineux à consolider, afin de réduire la taille de l’image.
- **Gestion des dépendances** : Suivre quand des dépendances ont été ajoutées, mises à jour ou supprimées tout au long de l’historique de l’image.
- **Amélioration du processus de build** : Examiner la composition des couches pour optimiser les instructions Dockerfile, améliorer le cache et réduire la taille de l’image.
- **Comparaison inter-images** : Convertir plusieurs images apparentées en dépôts Git et utiliser les outils de comparaison Git pour analyser leurs différences et points communs.

## Installation

### Gestionnaires de paquets

#### macOS / Linux (Homebrew)

```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Téléchargez et installez le paquet .deb depuis la [dernière version](https://github.com/virviil/oci2git/releases/latest) :

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Binaires précompilés

Téléchargez le binaire approprié pour votre plateforme depuis la [dernière version](https://github.com/virviil/oci2git/releases/latest) :

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Depuis Crates.io

```bash
cargo install oci2git
```

### Depuis la source

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Utilisation

```bash
oci2git [OPTIONS] <IMAGE>
```
Arguments :
  `<IMAGE>`  Nom de l'image à convertir (par exemple, 'ubuntu:latest') ou chemin vers une archive tar lors de l'utilisation du moteur tar

Options :
  `-o, --output <o>`  Répertoire de sortie pour le dépôt Git [par défaut : ./container_repo]
  `-e, --engine <ENGINE>`  Moteur de conteneur à utiliser (docker, nerdctl, tar) [par défaut : docker]
  `-h, --help`            Afficher l'aide
  `-V, --version`         Afficher la version

Variables d'environnement :
  `TMPDIR`  Définissez cette variable d'environnement pour modifier l'emplacement par défaut utilisé pour le traitement intermédiaire des données. Cela dépend de la plateforme (par exemple, `TMPDIR` sous Unix/macOS, `TEMP` ou `TMP` sous Windows).

## Exemples

Utilisation du moteur Docker (par défaut) :

```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

Utilisation d’une archive d’image déjà téléchargée :
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
Le moteur tar attend une archive tar au format OCI valide, généralement créée avec `docker save` :

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Cela créera un dépôt Git dans `./ubuntu-repo` contenant :
- `Image.md` - Métadonnées complètes sur l'image au format Markdown
- `rootfs/` - Le contenu du système de fichiers du conteneur

L'historique Git reflète l'historique des couches du conteneur :
- Le premier commit contient uniquement le fichier `Image.md` avec toutes les métadonnées
- Chaque commit suivant représente une couche de l'image originale
- Les commits incluent la commande Dockerfile comme message de commit

## Structure du dépôt

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Prérequis

- Édition Rust 2021
- Docker CLI (pour la prise en charge du moteur Docker)
- Git

## Licence

MIT

[documentation]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---