<img height="80" width="80" src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/icon/rounded_logo.png"/>

# Jellyflut

Un client jellyfin réalisé en Flutter

C'est une version bêta, ça fonctionne plutôt bien.

## :warning: Nouvelles
 
Le projet est en pause pour le moment. Je n'ai pas beaucoup de temps ni d'intérêt pour ce projet actuellement. Le lecteur vidéo est trop problématique sous Flutter. Je cherche encore des solutions mais pour l'instant, je vais ralentir le développement de cette application.

Je suis toujours ouvert aux PR et les accepterai volontiers.
 
## :gear: Fonctionnalités

Vous pouvez :
- [x] Lire une vidéo
- [x] Lire un livre (epub/CBZ)
  - L’epub est assez limité pour l’instant car c’est juste un parseur combiné à un visualiseur HTML
  - nécessite du travail
- [x] Écouter de la musique
  - Bug sous Linux (à investiguer, ou utiliser un autre paquet pour Linux)
- [x] Regarder des photos
- [x] SQLite pour avoir un journal et sauvegarder l’URL du serveur
- [x] Parcourir tous les fichiers
- [x] ~~LA PLUS GRANDE CHOSE À FAIRE : faire fonctionner le transcodage, pour l’instant je ne sais pas comment vérifier si un fichier peut être lu directement et sinon comment dire à jellyfin de m’envoyer l’URL correcte~~ Ça fonctionne (plus trop, cassé depuis la bêta 3 de la 10.8.0)
  - Ne fonctionne pas correctement sous Windows (semble cassé à cause de la dll libvlc, problème de certificat)
  - Sur ordinateur j’ai ajouté les codecs supportés manuellement. Certains codecs peuvent manquer, si c’est le cas, créez un ticket et je vérifierai si c’est lisible
- [x] Contrôler la musique depuis n’importe quel écran
- [x] Extraire et/ou parser les sous-titres depuis un fichier vidéo
 - Seulement srt distant, ne peut pas parser depuis un fichier mkv (sauf avec VLC)

## Fait
  - [X] Ajouter un bouton de déconnexion et bien le gérer
  - [X] Refaire la page de connexion
  - [x] Animation Hero OK
  - [x] Chargement asynchrone des détails
  - [x] Correction des saccades au retour des détails
  - [x] Responsive (en cours)
  - [x] Navigation avec la croix directionnelle (semble correcte mais le web peut encore sélectionner des éléments en dehors de l'écran sur la page d'accueil)
    - Il reste encore du travail mais vous pouvez naviguer dans 80% de l'application, ce qui est suffisant pour l'instant
  - [x] Gestion de plusieurs utilisateurs et serveurs
  - [x] Meilleure gestion des données lors du redimensionnement pour éviter le rechargement depuis l'API
    - Semble plutôt bien pour le moment, pourrait nécessiter des améliorations futures
  - [X] Thème (sombre/clair)
  - [X] Localisation (ENG,FR,DE)

## À faire
  - [ ] Toujours refactoriser tout
  - [ ] Ajouter des tests unitaires
  - [ ] Corriger "transcodeReasons=0" de jellyfin
  - [ ] Corriger tous les éléments Flutter, accélérer les performances
  - [ ] Mettre l'IPTV au niveau de la version web
    - Le guide fonctionne
    - Peut lire les chaînes IPTV
    - encore besoin d'ajouter l'enregistrement

## Écrans

 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/home.png"/>

### Téléphone

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_1.png"/>
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_phone_2.png"/>
</div>

### Bureau

<div style="display: flex">
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/series_details_desktop.png" height="360" />
 <img src="https://raw.githubusercontent.com/Thomas-Sohier/jellyflut/main/./img/readme/music_details_desktop.png" height="360" />
</div>

## Pour commencer

Cette application devrait fonctionner sur toutes les plateformes mais iOS et MacOS ne sont pas testés.

### Comment tester ?

```bash
  git clone https://github.com/Thomas-Sohier/jellyflut.git
  cd jellyflut
  flutter packages get
  flutter packages upgrade
  flutter run
```

### Comment construire ? (Android)

```bash
  flutter build apk --release
```

### Comment construire ? (Ordinateur, selon la plateforme)

Spécifique à Linux, vous devez installer dep

```bash
  # depend of your distro of course
  sudo apt-get update -y
  sudo apt-get install -y vlc libvlc-dev ninja-build clang libgtk-3-dev
```

```bash
  # enable desktop support at first (shouldn't be necessary but anyway)
  flutter config --enable-windows-desktop
  flutter config --enable-macos-desktop
  flutter config --enable-linux-desktop

  # build the app depending of your platform
  flutter build windows
  flutter build macos
  flutter build linux
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---