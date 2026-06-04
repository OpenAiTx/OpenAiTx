# ByeTunes 🎵

**Dites adieu à la synchronisation iTunes !**

ByeTunes est une application iOS native qui vous permet d’injecter de la musique (MP3, M4A, FLAC, WAV) et des sonneries directement dans la bibliothèque média de votre appareil — sans avoir besoin d’une connexion à un ordinateur à chaque synchronisation. Elle communique directement avec la base de données média iOS, vous donnant le pouvoir de gérer votre musique selon vos conditions.

## Fonctionnalités

-   **Injection directe de musique** : Ajoutez des chansons à votre bibliothèque Apple Music sans PC.
-   (DÉSACTIVÉ POUR LE MOMENT) **Gestionnaire de sonneries** : Injectez des sonneries personnalisées (conversion automatique `.m4r` et `.mp3`).
-   **Support des playlists** : Créez et gérez des playlists à la volée.
-   **Pas d’ordinateur nécessaire** (après configuration) : Une fois appairé, vous êtes libre !
-   **Édition des métadonnées** : Récupérées automatiquement depuis iTunes ou Deezer.

## Instructions de compilation

Pour compiler ByeTunes vous-même, vous aurez besoin d’un Mac avec Xcode.

### Prérequis

1.  **Xcode** : Version 15+ recommandée.
2.  **Appareil iOS** : Fonctionnant sous iOS 16.0 ou ultérieur.

### Bibliothèques externes

ByeTunes s’appuie sur `idevice` (une alternative à `libimobiledevice`) pour communiquer avec le système de fichiers interne iOS. **Ces fichiers NE SONT PAS inclus dans ce dépôt** pour des raisons de licence/taille.

Pour compiler l’application, vous devez obtenir ces deux fichiers et les placer dans le répertoire `MusicManager/` :

1.  `libidevice_ffi.a` (bibliothèque statique)
2.  `idevice.h` (fichier d’en-tête)

Vous pouvez trouver idevice et le compiler ici : [https://github.com/jkcoxson/idevice](https://github.com/jkcoxson/idevice)

*Si vous ne disposez pas de ces fichiers, le projet ne compilera pas.*

### Étapes de compilation

1.  Installer Rust :
    ```bash
    curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
    ```
2.  Ajouter l’architecture ios :
    ```bash
    rustup target add aarch64-apple-ios
    ```
    
3.  Installez les outils de ligne de commande Xcode si vous ne les avez pas déjà installés :
    ```bash
    xcode-select --install
    ```
4.  Clonez le dépôt :

    ```bash
    git clone https://github.com/jkcoxson/idevice
    ```
5.  Définir une cible de déploiement :

    ```bash
    export IPHONEOS_DEPLOYMENT_TARGET=xx.x
    ```
6.  Exécutez la commande cargo build :

    ```bash
    cargo build --release --package idevice-ffi --target aarch64-apple-ios
    ```
À l'intérieur du dossier idevice, trouvez : idevice.h et libidevice_ffi.a. Déplacez-les dans le projet Xcode, assurez-vous de créer **Bridging-Header.h**  
À l'intérieur de votre projet Xcode et assurez-vous d'ajouter :

 ```bash
    #import "idevice.h"
```

**Dans Paramètres du projet > Phases de construction > Lier les binaires avec les bibliothèques, assurez-vous que libidevice_ffi.a est listé.**

## Comment utiliser

1. **LocalDevVPN** :
    - Téléchargez LocalDevVPN depuis l’App Store/Altstore PAL https://apps.apple.com/us/app/localdevvpn/id6755608044.
    - Ouvrez-le et appuyez sur Connecter, vous aurez besoin d’une connexion active pour importer le fichier d’appairage dans l’application.

2.  **Appairage** :
    -   Au premier lancement, vous verrez un écran "Importer un fichier d’appairage".
    -   Vous devez obtenir un `fichier d’appairage`.
    -   Téléchargez idevice_pair en vous référant à https://github.com/jkcoxson/idevice_pair .
    -   Générez votre `fichier d’appairage`.
    -   Exportez-le depuis votre ordinateur et envoyez-le par Airdrop/enregistrez-le sur votre iPhone.
    -   Importez-le dans ByeTunes.
      
3.  **Ajouter de la musique** :
    -   Appuyez sur "Ajouter des chansons" et sélectionnez des fichiers dans votre application Fichiers.
    -   Appuyez sur "Injecter dans l’appareil" et regardez la magie opérer.
      
4.  **Sonneries** :
    -   Allez dans l’onglet Sonneries, ajoutez votre fichier, et injectez-le !

## Notes

-   **Applications signées** : Si vous installez via un service de signature (Signulous, AltStore, etc.), l’application inclut une correction (`asCopy: true`) pour garantir que l’importation de fichiers fonctionne correctement sans planter.
-   **Sauvegarde** : Il est toujours conseillé de faire une sauvegarde de votre bibliothèque musicale avant de manipuler l’injection dans la base de données !

## Support et rapport de bugs

Vous avez trouvé un bug ? Nous aimerions le corriger !

1.  **Signaler un problème** : Ouvrez un ticket sur [GitHub Issues](https://github.com/EduAlexxis/ByeTunes/issues).
2.  **Rejoindre la communauté** : Discutez avec nous sur [Discord](https://discord.gg/dDQ4P4SyKJ).
3.  **Joindre les logs de débogage** :
    *   Si vous rencontrez des échecs d’injection, veuillez utiliser les **Options de débogage** sous suppression de la bibliothèque dans les réglages.
    *   Cela inclut un écran "Logs de débogage" où vous pouvez copier les logs de l’application.
    *   Merci de joindre ces logs à votre rapport de problème — ils nous aident à résoudre les problèmes beaucoup plus rapidement !

---
*Créé avec ❤️ par EduAlexxis*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---