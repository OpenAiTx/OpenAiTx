# Téléchargeur Shape up

## Que fait-il ?
C'est une application CLI simple qui télécharge [l'excellent livre Shape Up gratuit de basecamp](https://basecamp.com/shapeup)
dans un seul fichier HTML autonome.
* utilise des images en base64
* utilise des liens internes au document
* uniquement le strict minimum de CSS

## Pourquoi cela existe-t-il ?
Le livre est actuellement disponible au format HTML, où chaque chapitre est un document et un document PDF où tous
les chapitres sont dans un seul fichier autonome. En lisant le livre, je cherchais un moyen de le lire sur mon liseuse,
mais lire un PDF sur un Kindle est pénible et convertir les PDF en epub ou mobi est au mieux hasardeux. Le logiciel utilisé pour générer
ce PDF en particulier combinait certaines combinaisons de caractères (par exemple "tf") en un seul point de code UTF-8 avec des ligatures. Cela
pose cependant problème à la plupart des logiciels de conversion.

Ainsi, ce projet est né pour télécharger et combiner tous les documents web en un seul fichier autonome sans style.
Vous n'êtes pas censé lire le livre dans ce format HTML - mais il peut servir de base pour des étapes de conversion ultérieures.

Pour convertir le fichier en formats plus utiles, je recommande d'utiliser l'utilitaire `ebook-convert` de calibre :
```bash
$ ebook-convert shape-up.html shape-up.epub \
    --authors "Ryan Singer" \
    --title "Shape Up: Stop Running in Circles and Ship Work that Matters" \
    --book-producer "Basecamp" \
    --publisher "Basecamp" \
    --language "en"
```

## Où puis-je télécharger cette version HTML/EPUB/MOBI en page unique ?
Je ne suis pas tout à fait sûr des implications légales liées à l’hébergement de ces fichiers - c’est pourquoi je ne le fais pas.
Le code pour le télécharger vous-même est ici, mais vous devez l’utiliser vous-même.

## Utilisation
### PHP local

1. [Installer PHP](https://www.php.net/manual/en/install.php)
2. [Installer Composer](https://getcomposer.org/download/)
3. Exécutez `php composer.phar install` (ou `composer install` si composer est installé globalement)
4. Exécutez `php cli.php download:single-html`

Cela créera un fichier `shape-up.html` dans votre répertoire courant.
C’est tout.

### Méthode Docker

Il existe un moyen de ne pas avoir à gérer php du tout. Pour cela, il suffit d’avoir le moteur docker installé.

Utilisation
```
docker run -it --rm -v $(pwd)/output:/app/output thej6s/shape-up-downloader

```
Cela créera un fichier `shape-up.html` dans le répertoire ./output


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---