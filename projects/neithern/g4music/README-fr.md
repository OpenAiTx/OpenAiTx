<img align="left" alt="Logo du projet" src="https://raw.githubusercontent.com/neithern/g4music/master/data/icons/hicolor/scalable/apps/app.svg" />

# Gapless
Écoutez votre musique avec élégance.

<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/window.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/albums.png" width="1134"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playing.png" width="462"/>
<img src="https://gitlab.gnome.org/neithern/screenshots/-/raw/main/g4music/playlist.png" width="466"/>

Gapless (alias : G4Music) est un lecteur de musique léger écrit en GTK4, axé sur les grandes collections musicales.

## Fonctionnalités
- Prend en charge la plupart des types de fichiers musicaux, Samba et tout autre protocole distant (dépend de GIO et GStreamer).
- Chargement et analyse rapides de milliers de fichiers musicaux en quelques secondes, surveillance des modifications locales.
- Faible consommation mémoire pour les grandes collections musicales avec pochettes d’album (intégrées et externes), pas de caches de vignettes à stocker.
- Regroupement et tri par album/artiste/titre, lecture aléatoire, recherche en texte intégral.
- Interface utilisateur adaptative fluide pour différents écrans (Bureau, Tablette, Mobile).
- Pochette floutée gaussienne en arrière-plan, suit le mode clair/sombre de GNOME.
- Prise en charge de la création et de l’édition de listes de lecture, glisser la pochette pour changer l’ordre ou ajouter à une autre liste.
- Prise en charge du glisser-déposer avec d’autres applications.
- Prise en charge du visualiseur de pics audio.
- Prise en charge de la lecture sans interruption (gapless).
- Prise en charge de la normalisation du volume avec ReplayGain.
- Prise en charge de la sortie audio spécifiée.
- Prise en charge du contrôle MPRIS.

## Installation depuis Flathub
<a href="https://flathub.org/apps/com.github.neithern.g4music">
<img src="https://flathub.org/assets/badges/flathub-badge-en.png" width="240"/></a>

## Installation depuis Snapcraft (non officiel)
<a href="https://snapcraft.io/g4music">
<img alt="Obtenez-le sur le Snap Store" src="https://camo.githubusercontent.com/ab077b20ad9938c23fbdac223ab101df5ed27329bbadbe7f98bfd62d5808f0a7/68747470733a2f2f736e617063726166742e696f2f7374617469632f696d616765732f6261646765732f656e2f736e61702d73746f72652d626c61636b2e737667" data-canonical-src="https://snapcraft.io/static/images/badges/en/snap-store-black.svg" width="240" style="max-width: 100%;"> 

## Dépendances FreeBSD

```bash
pkg install vala meson libadwaita gstreamer1-plugins-all gettext gtk4
```

## Comment construire 
Il est écrit en Vala, code simple et propre, avec peu de dépendances tierces :

1. Cloner le code depuis gitlab.
2. Installer vala, les paquets de développement de gtk4, libadwaita, gstreamer.
3. Exécuter dans le répertoire du projet :

    `meson setup build --buildtype=release`

    `meson install -C build`

## Journal des modifications
Consultez les [tags de version](https://gitlab.gnome.org/neithern/g4music/-/tags) pour le journal des modifications.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---