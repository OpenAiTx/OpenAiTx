# OCI2Git

Une application Rust qui convertit les images de conteneurs (Docker, etc.) en dépôts Git. Chaque couche de conteneur est représentée comme un commit Git, préservant l'historique et la structure de l'image originale.

![Démonstration de OCI2Git convertissant l'image nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Fonctionnalités

- Analyse des images Docker et extraction des informations de couche
- Création d’un dépôt Git où chaque couche d’image est représentée par un commit
- Prise en charge des couches vides (ENV, WORKDIR, etc.) comme commits vides
- Extraction complète des métadonnées au format Markdown
- Architecture extensible pour supporter différents moteurs de conteneurs

## Cas d’utilisation

### Différence entre couches
Lors du dépannage de problèmes de conteneur, vous pouvez utiliser la puissante fonctionnalité de diff de Git pour identifier exactement ce qui a changé entre deux couches. En exécutant `git diff` entre les commits, les ingénieurs peuvent voir précisément quels fichiers ont été ajoutés, modifiés ou supprimés, ce qui facilite grandement la compréhension de l’impact de chaque instruction Dockerfile et la localisation des changements problématiques.
![Exemple de différence entre couches](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Suivi de l’origine
Avec `git blame`, les développeurs peuvent rapidement déterminer quelle couche a introduit un fichier ou une ligne de code spécifique. Ceci est particulièrement utile lors du diagnostic de problèmes avec des fichiers de configuration ou des dépendances. Plutôt que d’inspecter manuellement chaque couche, vous pouvez immédiatement retracer l’origine de n’importe quel fichier jusqu’à sa couche source et l’instruction Dockerfile correspondante.

### Suivi du cycle de vie des fichiers
OCI2Git vous permet de suivre le parcours d’un fichier spécifique tout au long de l’historique de l’image du conteneur. Vous pouvez observer quand un fichier a été créé initialement, comment il a été modifié à travers les couches, et s’il a été éventuellement supprimé. Cette vue complète aide à comprendre l’évolution d’un fichier sans avoir à suivre manuellement les changements à travers potentiellement des dizaines de couches.

Pour suivre l’historique d’un fichier dans votre image de conteneur — y compris quand il est apparu, a été modifié ou supprimé — vous pouvez utiliser ces commandes Git après conversion :

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
OCI2Git détecte automatiquement les couches partagées entre les images et crée une structure en branches qui reflète leur base commune. L’historique Git affichera :
- Un tronc commun contenant toutes les couches partagées
- Des branches séparées qui divergent uniquement lorsque les images diffèrent réellement
- Une visualisation claire de l’endroit où les images partagent une ascendance commune vs. où elles deviennent uniques
- Gestion intelligente des doublons : si la même image est traitée deux fois, l’algorithme le détecte avant le commit final des métadonnées et évite de créer une branche en double

Cette approche est particulièrement précieuse pour :
- **Analyse des familles d’images** : Comprendre comment différentes variantes d’une image (différentes versions, architectures ou configurations) sont liées entre elles
- **Impact de l’image de base** : Voir précisément comment les modifications d’une image de base affectent plusieurs images dérivées
- **Opportunités d’optimisation** : Identifier les composants partagés qui pourraient être mieux exploités entre les variantes d’images

![Structure de dépôt multi-images montrant la base partagée et les branches divergentes](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Cas d’utilisation supplémentaires

- **Audit de sécurité** : Identifier précisément quand des paquets ou configurations vulnérables ont été introduits et retracer leur origine dans des instructions de build spécifiques.
- **Optimisation des images** : Analyser la structure des couches pour repérer les opérations redondantes ou les fichiers volumineux à consolider, aidant à réduire la taille des images.
- **Gestion des dépendances** : Surveiller quand les dépendances ont été ajoutées, mises à jour ou supprimées dans l’historique des images.
- **Amélioration du processus de build** : Examiner la composition des couches pour optimiser les instructions Dockerfile afin d’améliorer la mise en cache et réduire la taille des images.
- **Comparaison inter-images** : Convertir plusieurs images liées en dépôts Git et utiliser les outils de comparaison Git pour analyser leurs différences et points communs.

## Installation

### Depuis les sources


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Depuis Crates.io

```bash
cargo install oci2git
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
## Exigences

- Rust édition 2021
- CLI Docker (pour le support du moteur Docker)
- Git

## Licence

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---