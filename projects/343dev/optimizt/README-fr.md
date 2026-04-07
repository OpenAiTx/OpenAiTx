# @343dev/optimizt

<img align="right" width="176" height="176"
     alt="Logo Optimizt : geste OK avec l'image de la Joconde entre les doigts"
     src="https://raw.githubusercontent.com/343dev/optimizt/main/./docs/logo.png">

[![npm](https://img.shields.io/npm/v/@343dev/optimizt.svg)](https://www.npmjs.com/package/@343dev/optimizt)
[![Docker](https://img.shields.io/docker/v/343dev/optimizt?label=Docker)](https://hub.docker.com/r/343dev/optimizt)

**Optimizt** est un outil en ligne de commande qui aide à préparer les images pour le web.

Il peut compresser les PNG, JPEG, GIF et SVG de manière avec ou sans perte, et créer des versions AVIF et WebP pour les images matricielles.

## Justification

En tant que développeurs frontend, nous devons nous soucier des images : compresser PNG et JPEG, supprimer les parties inutiles des SVG, créer des AVIF et WebP pour les navigateurs modernes, etc. Un jour, nous en avons eu assez d'utiliser une multitude d'applications pour cela, et avons créé un outil qui fait tout ce que nous voulons.

## Utilisation

Installation :

```sh
npm install -g @343dev/optimizt
```

Optimisez !

```sh
optimizt path/to/picture.jpg
```

## Options de la ligne de commande

- `--avif` — créer des versions AVIF des images.
- `--webp` — créer des versions WebP des images.
- `-f, --force` — recréer les versions AVIF et WebP même si elles existent déjà.
- `-l, --lossless` — optimiser sans perte au lieu d’avec perte.
- `-v, --verbose` — afficher une sortie détaillée (par ex. fichiers ignorés).
- `-c, --config` — utiliser un fichier de configuration personnalisé au lieu du défaut.
- `-o, --output` — écrire les résultats dans le répertoire spécifié.
- `-p, --prefix` — ajouter un préfixe aux noms des fichiers optimisés.
- `-s, --suffix` — ajouter un suffixe aux noms des fichiers optimisés.
- `-V, --version` — afficher la version de l’outil.
- `-h, --help` — afficher le message d’aide.

## Exemples d’utilisation

```bash
# optimize a single image
optimizt path/to/picture.jpg

# optimize multiple images losslessly
optimizt --lossless path/to/picture.jpg path/to/another/picture.png

# recursively create AVIF and WebP versions for all images in a directory
optimizt --avif --webp path/to/directory

# recursively optimize JPEG files in the current directory
find . -iname \*.jpg -exec optimizt {} +
```

## Différences entre Lossy et Lossless

### Lossy (par défaut)

Offre le meilleur compromis entre réduction de la taille du fichier et perte minimale de qualité visuelle.

### Lossless (option `--lossless`)

- **AVIF/WebP** : Utilise une compression sans perte.
- **PNG/JPEG/GIF** : Maximise la qualité de l’image au prix de fichiers plus volumineux.
- **SVG** : Les paramètres sont identiques dans les deux modes.

## Configuration

Le traitement des images utilise :

- [sharp](https://github.com/lovell/sharp) pour [JPEG](https://sharp.pixelplumbing.com/api-output#jpeg), [PNG](https://sharp.pixelplumbing.com/api-output#png), [WebP](https://sharp.pixelplumbing.com/api-output#webp), et [AVIF](https://sharp.pixelplumbing.com/api-output#avif).
- [svgo](https://github.com/svg/svgo) pour SVG.
- [gifsicle](https://github.com/kohler/gifsicle) pour GIF.

> [!NOTE]
> En mode Lossless pour JPEG, [Guetzli](https://github.com/google/guetzli) est utilisé. Une optimisation répétée peut dégrader la qualité visuelle.

Les paramètres par défaut sont définis dans [.optimiztrc.cjs](./.optimiztrc.cjs), qui inclut tous les paramètres supportés. Désactivez un paramètre en le réglant à `false`.

Lors de l’utilisation de `--config chemin/vers/.optimiztrc.cjs`, le fichier de configuration spécifié sera utilisé. Si aucun `--config` n’est fourni, Optimizt recherche récursivement depuis le répertoire courant vers le haut le fichier `.optimiztrc.cjs`. Si aucun n’est trouvé, les valeurs par défaut sont appliquées.

## Dépannage

### Erreurs du type « spawn guetzli ENOENT ».

Assurez-vous que l’option npm [ignore-scripts](https://docs.npmjs.com/cli/v6/using-npm/config#ignore-scripts) est désactivée.
Détails : [funbox/optimizt/issues/9](https://github.com/funbox/optimizt/issues/9).

## Docker

### Image pré-construite

```bash
# pull latest
docker pull 343dev/optimizt

# pull specific version
docker pull 343dev/optimizt:9.0.2
```

### Construction manuelle

```bash
# clone repository
git clone https://github.com/343dev/optimizt.git
cd optimizt

# build image
docker build --tag 343dev/optimizt .
```

Alternativement :

```bash
# build directly from GitHub
# ignores .dockerignore (see: https://github.com/docker/cli/issues/2827)
docker build --tag 343dev/optimizt https://github.com/343dev/optimizt.git
```

### Exécuter le Conteneur

```bash
# mount current directory to /src in the container
docker run --rm --volume $(pwd):/src 343dev/optimizt --webp ./image.png
```

## Intégrations

Optimizt fonctionne parfaitement avec :

- [JetBrains IDEs](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/jetbrains.md)
- [Visual Studio Code](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/vscode.md)
- [Sublime Text 3](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/sublime-text.md)
- [GitHub Actions Workflow](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/github.md)

## Articles

- [anuwong.com](https://anuwong.com/blog/2023-08-21-save-tons-of-gbs-with-optimizt/) — Compressez les fichiers avant de les télécharger, économisez des tonnes de Go. 🇹🇭
- [Linux Format, numéro 277 (juillet 2021)](https://www.linuxformat.com/archives?issue=277#:~:text=Kitchen%20Tales%2C%20zFRAG%2C-,Optimizt,-and%20SingleFileZ.) — Optimizt est idéal pour réduire l’empreinte disque des images sans aucune perte de qualité.

## Crédits

La jolie image du projet a été réalisée par [Igor Garybaldi](http://pandabanda.com/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---