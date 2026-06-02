# EbookDownloader
Un outil pour télécharger des livres électroniques achetés auprès de différents éditeurs.

![Aperçu](https://raw.githubusercontent.com/RythenGlyth/EbookDownloader/master/preview.png)

## Table des matières
- [Éditeurs supportés (sites web)](#supported-publishers-websites)
- [Installation automatique](#automatic-installation)
- [Installation manuelle](#manual-installation)
- [Exécution](#running)
- [Sauvegarde des identifiants](#saving-credentials-to-avoid-entering-them-every-time-optional)
- [Bildungslogin (Cornelsen / Westermann)](#bildungslogin)

## Éditeurs supportés (sites web)
| Éditeur | Site web | Meilleure qualité | Texte sélectionnable | Hyperliens | Notes |
| --- | --- | --- | --- | --- | --- |
| Cornelsen ("Nouvelle méthode") | cornelsen.de | PDF sans perte | &check; | &check; |  |
| Cornelsen ("Ancienne méthode") | cornelsen.de | Composition d’image (8617px x 11792px) | &check; | &cross; |  |
| Cornelsen.CH | ebooks.cornelsen.ch | PDF sans perte | &check; | &cross; |  |
| Cornelsen | scook.de | Composition d’image (?) | &cross; | &cross; | |
| Allango Klett | allango.net | PDF sans perte | &check; | ? | [1] |
| Klett | klett.de | Composition d’image (3072px x 4096px) | &check; | &check; | |
| Westermann | westermann.de | Composition d’image (2244px x 3071px) | &check; | &cross; | |
| C.C.BUCHNER | click-and-study.de | Composition d’image (1658px x 2211px) | &check; | &cross; | |
| C.C.BUCHNER | click-and-teach.de | Composition d’image (1658px x 2211px) | &check; | &cross; | |
| Book2Look | book2look.com | PDF sans perte | &check; | ? | [2] |
| kiosquemag | kiosquemag.com | Composition d’image (?) | &cross; | &cross; | |
| Helbling Media App | helbling.com | PDF sans perte | &check; | &cross; | |

[1]: Le site permet de télécharger des fichiers non possédés

[2]: Pas de compte nécessaire, uniquement l’identifiant du livre

## Installation automatique
Dans un premier temps, clonez ou téléchargez le dépôt.

L’outil utilise des bibliothèques de traitement d’image et doit être exécuté avec nodejs, donc certaines dépendances sont requises.

Vous pouvez soit utiliser les scripts d’installation (`init.bat` pour Windows, `init.sh` pour les distributions basées sur Debian) soit procéder à une installation manuelle. Les scripts d’installation téléchargeront toutes les dépendances pour vous. Pour les exécuter, double-cliquez sur le fichier `.bat` sous Windows ou lancez le fichier `.sh` dans le terminal sous Linux après avoir ajouté les permissions d’exécution au fichier `.sh`.

## Installation manuelle  
Au départ, clonez ou téléchargez le dépôt. Ensuite, suivez les instructions spécifiques au système d’exploitation ci-dessous :  

### Windows  
1. Téléchargez `unifont-15.0.01.ttf` depuis http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf et placez-le à la racine du projet  
1. Installez `ffmpeg` et mettez l’exécutable ffmpeg (nommé `ffmpeg`) à la racine du projet ou ajoutez-le à votre variable d’environnement PATH, si vous avez besoin d’aide, vous pouvez suivre [ce tutoriel](https://phoenixnap.com/kb/ffmpeg-windows)  
1. Installez `mutool` et mettez l’exécutable mutool (nommé `mutool`) à la racine du projet ou ajoutez-le à votre variable d’environnement PATH, vous pouvez trouver les builds les plus récents [ici](https://mupdf.com/releases). Cherchez les versions pour `windows`. (requis uniquement pour book2look et cornelsen.ch)  
1. Installez `nodejs` et `npm` si ce n’est pas déjà fait, vous pouvez trouver de l’aide [ici](https://phoenixnap.com/kb/install-node-js-npm-on-windows)  
1. Lancez `npm install`  
1. Facultativement, installez `image magick` et placez l’exécutable magick (nommé `magick`) à la racine du projet ou ajoutez-le à votre variable d’environnement PATH (requis uniquement pour la "ancienne méthode" cornelsen)  

### Linux  
1. Lancez `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`  
1. Installez les paquets `ffmpeg`, `nodejs`, `mutool`/`mupdf-tools`/`mupdf` (requis pour book2look et cornelsen.ch) et éventuellement `imagemagick` (requis uniquement pour la "ancienne méthode" cornelsen) avec votre gestionnaire de paquets préféré  
1. Lancez `npm install`  

### Linux/Darwin avec Nix  
- Si vous avez nix-direnv, lancez `direnv allow` pour obtenir toutes les dépendances  
- Sinon, lancez `nix-shell`.  
- Lancez `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"`  

## Exécution  
Complétez l’installation en lançant `npm install` dans le répertoire du projet et  
démarrez le programme en exécutant `npm start` depuis le répertoire du projet.  

## Sauvegarder les identifiants pour éviter de les saisir à chaque fois (optionnel)  
Vous pouvez sauvegarder vos identifiants dans un fichier `config.json` pour éviter de les saisir à chaque démarrage du programme. Pour ce faire, créez un fichier nommé `config.json` à la racine du projet et ajoutez le contenu suivant :

```json
{
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    },
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    }
    [...]
}
```
  
Remplacez toutes les crochets par vos données. Les clés des éditeurs sont : `cornelsen`, `klett`, `allango`, `scook`, `westermann`, `clicknstudy`, `clicknteach`, `kiosquemag`, `cornelsench`, `book2look`, `helbling`

## Bildungslogin

Cornelsen, Click-n-Study, Klett et Westermann prennent en charge la connexion par token, permettant la connexion avec des comptes Bildungslogin.

### Cornelsen

1. Ouvrez Bildungslogin et connectez-vous  
1. Allez dans les outils de développement de stockage (SHIFT+F9, ou alternativement appuyez sur CTRL+SHIFT+I et cliquez sur l’onglet Stockage).  
1. Ouvrez le livre  
1. Sélectionnez Stockage local dans les outils de développement (il peut être nécessaire aussi de sélectionner le site web dedans)  
1. Faites défiler le tableau qui s’ouvre jusqu’à trouver `id_token`. Ce doit être une longue chaîne alphanumérique.  
1. Copiez-le. (Double-cliquez, puis ctrl+c)  
1. Utilisez-le comme mot de passe, et utilisez `token` comme nom d’utilisateur.  

### Click-and-Study

1. Ouvrez Bildungslogin et connectez-vous  
1. Ouvrez le livre  
1. Allez dans les outils de développement de stockage (SHIFT+F9, ou alternativement appuyez sur CTRL+SHIFT+I et cliquez sur l’onglet Stockage).  
1. Sélectionnez Cookies dans les outils de développement (il peut être nécessaire aussi de sélectionner le site web dedans)  
1. Faites défiler le tableau qui s’ouvre jusqu’à trouver `CASSID`. Il doit y avoir une chaîne alphanumérique après.  
1. Copiez cela (les caractères à l’apparence aléatoire). (Double-cliquez, puis ctrl+c)  
1. Utilisez-le comme mot de passe, et utilisez `token` comme nom d’utilisateur.  

### Klett

1. Ouvrez Bildungslogin et connectez-vous  
1. Ouvrez le livre  
1. Allez dans les outils de développement de stockage (SHIFT+F9, ou alternativement appuyez sur CTRL+SHIFT+I et cliquez sur l’onglet Stockage).  
1. Sélectionnez Cookies dans les outils de développement (il peut être nécessaire aussi de sélectionner le site web dedans)  
1. Faites défiler le tableau qui s’ouvre jusqu’à trouver `SESSION`. Il doit y avoir une chaîne alphanumérique après.  
1. Copiez cela (les caractères à l’apparence aléatoire). (Double-cliquez, puis ctrl+c)  
1. Utilisez-le comme mot de passe, et utilisez **l’URL du lecteur de livre sur lequel vous êtes** comme nom d’utilisateur.  

### Westermann

1. Ouvrez Bildungslogin et connectez-vous  
1. Ouvrez le livre  
1. Allez dans les outils de développement Réseau (CTRL+SHIFT+E, ou alternativement appuyez sur CTRL+SHIFT+I et cliquez sur l’onglet Réseau).  
1. Cochez `Conserver les journaux` (probablement dans le menu Engrenage, vraisemblablement en haut à droite quelque part)  
1. Rechargez la page  
1. Saisissez `/api/user` dans le champ "Filtrer les URL" des outils de développement  
1. Cliquez sur la première entrée qui *ne* dit *pas* OPTIONS  
1. Un petit volet latéral devrait s’ouvrir. Cliquez sur son onglet En-têtes  
1. Saisissez `auth` dans son champ "Filtrer les en-têtes" (si disponible)  
1. Faites défiler vers le bas jusqu’à trouver une longue chaîne de lettres et de chiffres  
1. Copiez-la et collez-la dans un document texte  
1. Recopiez-la de là, mais assurez-vous de NE PAS sélectionner la partie "Authorization: Bearer ", uniquement la longue chaîne à la fin.  
1. Utilisez-la comme mot de passe, et utilisez `token` comme nom d’utilisateur.  

## Contribution  

N’hésitez pas à créer des issues et des pull requests pour contribuer au projet.  

## Avertissement  
Ce projet est uniquement à des fins éducatives. Le projet n’est pas responsable de toute mauvaise utilisation du logiciel. Selon votre juridiction, il peut être illégal d’utiliser ce logiciel pour télécharger des livres électroniques sans le consentement de l’éditeur. Dans d’autres juridictions, il peut être légal de télécharger des livres électroniques uniquement pour un usage personnel. Veuillez vérifier les lois locales avant d’utiliser ce logiciel.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---