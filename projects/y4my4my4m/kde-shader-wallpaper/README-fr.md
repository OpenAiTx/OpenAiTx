# Plugin de Fond d'Écran Shader Plasma6

**Shader Wallpaper** est un plugin de fond d'écran Plasma6 qui permet des fonds d'écran dynamiques pilotés par des shaders pour le bureau KDE.

---

> **Note pour les utilisateurs de Plasma5 :**\
> Veuillez vous référer à la [branche Plasma5](https://github.com/y4my4my4m/kde-shader-wallpaper/tree/plasma5) pour la compatibilité.

---

## Fonctionnalités

- Exécutez des shaders personnalisés comme fond d'écran de votre bureau
- Installation, mise à jour et suppression faciles
- Prise en charge complète de Plasma6
- Développement continu avec des mises à jour fréquentes de fonctionnalités et corrections de bugs

### Notes

Voici quelques shaders compatibles avec les écrans OLED :
```
Grey_Liquid
HSV_to_RGB
RGB_Noise_in_Movement
Raymarching_Basic
VDJ.frag
Wiggle_Worm
```
---

## Installation

### Installer depuis la source

1. **Cloner le dépôt :**

   ```bash
   git clone https://github.com/y4my4my4m/kde-shader-wallpaper.git
   ```

2. **Supprimez toute installation précédente :**

   ```bash
   rm -rf ~/.local/share/plasma/wallpapers/online.knowmad.shaderwallpaper/
   ```

3. **Installer le paquet :**

   ```bash
   kpackagetool6 -t Plasma/Wallpaper -i kde-shader-wallpaper/package
   ```

### Mise à niveau

```bash
kpackagetool6 -t Plasma/Wallpaper --upgrade kde-shader-wallpaper/package
```

### Désinstallation

Vous pouvez désinstaller via les Paramètres du Bureau KDE, ou exécuter :

```bash
kpackagetool6 -t Plasma/Wallpaper --remove online.knowmad.shaderwallpaper
```

---

## Guide du développeur

Pour créer des shaders personnalisés ou contribuer, veuillez lire le [Guide du développeur](https://raw.githubusercontent.com/y4my4my4m/kde-shader-wallpaper/master/README_DEV.md).

---

## Répertoire & Support

- **GitHub :** [y4my4my4m/kde-shader-wallpaper](https://github.com/y4my4my4m/kde-shader-wallpaper)
- **KDE Store :** [Version Plasma6](https://store.kde.org/p/2143912)
- **KDE Store :** [Version Plasma5](https://store.kde.org/p/1413010/)
- **Twitter (X) :** [@y4my4my4m](https://twitter.com/y4my4my4m)

Pour les problèmes, demandes de tirage ou questions générales, veuillez contacter via [GitHub Issues](https://github.com/y4my4my4m/kde-shader-wallpaper/issues) ou Twitter.

---

## Notes

- La personnalisation des shaders via GUI reviendra dans les futures versions.
- Les imports depuis Shadertoy.com ne sont pas pris en charge actuellement dans la version Plasma6 en raison des exigences de compilation des shaders.
- Les performances peuvent varier selon le matériel et la complexité du shader, mais la plupart des shaders sont économes en ressources.
- Après avoir modifié les fichiers shader, redémarrez l’application KDE Wallpaper QtQuick (`pkill plasmashell` puis redémarrez).

---

## Vidéos :

### v1.2 utilisant iGPU (et kvantum) dans VirtualBox :

[![ShaderWallpaperVideoPreviewV1.2](https://cdn-cf-east.streamable.com/image/1g7muc_first.jpg?Expires=1599641820&Signature=kBzPch9XeiD3AieRh4sXd84JdQIknV2KK1m~w7KtXcO-5LH~JCeG8Wngq2p45Z521BWfd2jxpaujTV3618h91u4EnBSzMDRskpxPuSQ4x9uihB0gQ7u4OZjfLt3g-dXLa69Vh6V8~NCDuqo6v3G24vlQND-GArKa~lDPQvnNj2qt-cOIuFLyO0cBwJG4MTu-9C2zOe2wjR2s-cj8IAi4PweeMpJqeKZepDpe9grl8Wry8s3ahP9hZfUyCBs53LnWsEbfe2Ze01j6Bo07gXXb5rAQXYvfI7WxIDX2S7L5f33OxxJNxa4v1Jeg-aAsrW9Ij-86b9qtfsjN1IE6wUOzpQ__&Key-Pair-Id=APKAIEYUVEN4EVB2OKEQ)](https://streamable.com/1g7muc)

### v1.0 :
[![ShaderWallpaperVideoPreviewV1.0](https://cdn-cf-east.streamable.com/image/yeqam9.jpg?Expires=1599641220&Signature=NCZXLhg5owCeCiBx8wg7FIO2oOZ~6y9b-we72JE0icG9Cw649dYPPRqDzuOnXsvOEe0omZhhlckbcdLZg6QKbMm9R6UUkN3g-hs4Y8WAJcWIXrantAsWlg309a2vu-gIkHV06eOYczdC3BBzprRHLh8BuKGRQyIAvxLYyf25mWexhPVrZHvrXsl-PFWN1tH~LLL14vD1oaoysupJxnF26qLVv1nAGB-AzYn7GVAcnJmpOPUbKz~jl2Z6iWy1fgJYu~Dym5Hxphc21-XIOHSqXYjkZFDslyevRJVcfqAsnfOzsm3GwRmBQ8hYB5wO5lpp4DnAUuDjtzY9d5sB025U0Q__&Key-Pair-Id=APKAIEYUVEN4EVB2OKEQ)](https://streamable.com/yeqam9)

---

### Screenshots:

[![ShaderWallpaperPreviewImage](https://images.pling.com/img/00/00/58/32/49/1413010/ef67e0df43137d0d42b81afe700e83aa9cf2c911ab4619aa6ba072894a404c658546.png)](https://images.pling.com/img/00/00/58/32/49/1413010/ef67e0df43137d0d42b81afe700e83aa9cf2c911ab4619aa6ba072894a404c658546.png)

[![ShaderWallpaperPreviewImage2](https://images.pling.com/img/00/00/58/32/49/1413010/95ec8cf5ca97eac0504faa68b297355964a9c6d4e1e1e161609997356b9a6d75fe6d.png)](https://images.pling.com/img/00/00/58/32/49/1413010/95ec8cf5ca97eac0504faa68b297355964a9c6d4e1e1e161609997356b9a6d75fe6d.png)

[![ShaderWallpaperPreviewImage3](https://images.pling.com/img/00/00/58/32/49/1413010/67b57155b2a2a2cd63f6d5545af2f6da3f5298c081c5ab05a72f6c17aa56aee79afd.png)](https://images.pling.com/img/00/00/58/32/49/1413010/67b57155b2a2a2cd63f6d5545af2f6da3f5298c081c5ab05a72f6c17aa56aee79afd.png)

[![ShaderWallpaperPreviewImage4](https://images.pling.com/img/00/00/58/32/49/1413010/b5026604b9009c3541e25b98bbaa0450d17a52ceee878f8b44383bb5e3570c3f251d.png)](https://images.pling.com/img/00/00/58/32/49/1413010/b5026604b9009c3541e25b98bbaa0450d17a52ceee878f8b44383bb5e3570c3f251d.png)

---

## Donations:
[![ko-fi](https://www.ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/I2I525V5R)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---