# Annotateur

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Téléchargez-le sur AppCenter"/>
  </a>
</p>

![<center><b>Fenêtre Principale - Thème Clair</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Annotation d'Image pour Elementary OS")

## Vue d'ensemble

Annotez vos images et laissez une image parler mille mots.

- Chargez une image depuis le système de fichiers, le presse-papiers, ou créez une capture d'écran à annoter.
- Ajoutez des formes, autocollants, images, texte, dessins, et autres bulles pour mettre en avant les détails de l'image.
- Ajoutez des loupes pour améliorer les détails de l'image.
- Floutez des parties de l'image pour masquer des données.
- Recadrez, redimensionnez et ajoutez des bordures à l'image.
- Contrôlez les couleurs, l'épaisseur des lignes et les détails de la police.
- Support du zoom.
- Sélecteur de couleur intégré dans une image chargée.
- Annulation/refaire illimitée de toute modification.
- Glisser-déposer de copies PNG de l'image annotée.
- Exportez aux formats d'image JPEG, PNG, TIFF, BMP, PDF, SVG et WebP.
- Support de la copie de l'image annotée dans le presse-papiers.
- Support de l'imprimante.

## Installation

### Debian (depuis la source)

Vous aurez besoin des dépendances suivantes pour compiler Annotateur :

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-dev
- libxml2-dev
- libgtk-3-dev
- libhandy-1-dev
- libwebp-dev

Pour installer Annotator depuis les sources, exécutez `./app install`.

Pour lancer Annotator, exécutez `com.github.phase1geo.annotator`.

### Ubuntu (PPA)

Vous pouvez utiliser le [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) maintenu par @PandaJim. Le PPA prend en charge Ubuntu 20.04+. Entrez les commandes suivantes une par une

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

Si vous êtes un utilisateur d'Arch Linux, il existe un
[paquet AUR](https://aur.archlinux.org/packages/annotator/)
`annotator` :

```
% yay -S annotator
```

### Flatpak

De plus, Annotator peut être installé et exécuté via Flatpak.

Pour construire et installer le Flatpak à partir des sources, exécutez `./app flatpak`.

Ensuite, vous pouvez le lancer via : `flatpak run com.github.phase1geo.annotator`.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Obtenez-le sur AppCenter"/>
  </a>
</p>

## Crédits

Incorpore `document-edit-symbolic.svg` et `image-crop-symbolic.svg` de
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic),
sous les termes de la licence GPL v3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-24

---