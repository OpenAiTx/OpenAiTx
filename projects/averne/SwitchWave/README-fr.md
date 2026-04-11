# <img src="https://github.com/user-attachments/assets/b81b9503-948e-4cba-b0a1-f5f809588aad" width="48"> SwitchWave
Un lecteur multimédia accéléré matériellement pour la Nintendo Switch, basé sur mpv et FFmpeg.

## Fonctionnalités
- Backend d'accélération matérielle personnalisé pour FFmpeg, avec mise à l'échelle dynamique de la fréquence. Les codecs suivants peuvent être décodés :
    - MPEG1/2/4
    - VC1
    - H.264/AVC (10+ bits non supportés par le matériel)
    - H.265/HEVC (12+ bits non supportés par le matériel)
    - VP8
    - VP9 (10+ bits non supportés par le matériel)
- Backend graphique personnalisé pour mpv utilisant [deko3d](https://github.com/devkitPro/deko3d), supportant :
    - Lecture en 4k60fps
    - Rendu direct (décodage logiciel plus rapide)
    - Shaders de post-traitement personnalisés
- Backend audio personnalisé pour mpv utilisant les API natives Nintendo, supportant les configurations jusqu'au surround 5.1
- Lecture réseau via HTTP/S, Samba, NFS ou SFTP
- Support des disques externes via [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs)
- Interface utilisateur riche et réactive, même en charge élevée

## Captures d'écran

<p float="center">
    <img src="https://github.com/user-attachments/assets/09aed446-148a-4276-8b07-336890c224a3" width="413" />
    <img src="https://github.com/user-attachments/assets/6e354511-47bc-4898-881c-348d5a9e6fbc" width="413" />
    <img src="https://github.com/user-attachments/assets/b86eb7c6-4229-46c6-8709-86d1a6ee8eed" width="413" />
    <img src="https://github.com/user-attachments/assets/70f4be3e-fa1e-434a-b76c-4fb6b671f80e" width="413" />
</p>

## Installation
- Téléchargez la [dernière version](https://github.com/averne/SwitchWave/releases/latest), et extrayez-la à la racine de votre carte SD (attention à fusionner et ne pas écraser les dossiers)
- Les partages réseau peuvent être configurés via l'application, tout comme les paramètres mpv via l'éditeur intégré (reportez-vous au [manuel](https://mpv.io/manual/master/))
- La plupart des paramètres d'exécution importants peuvent être ajustés dynamiquement pendant la lecture via le menu, ou à défaut, la console ([manuel](https://mpv.io/manual/master/#console))

## Compilation

### Docker (recommandé)
```sh
./build-docker.sh
```
Cela construit l'image de la chaîne d'outils et compile tout automatiquement. La sortie se trouvera dans `build/`.

Pour construire avec GIMP 3 au lieu du GIMP 2 par défaut :
```sh
GIMP_VERSION=3 ./build-docker.sh
```
### Manuel
- Configurez un environnement [devkitpro](https://devkitpro.org/wiki/devkitPro_pacman) pour le développement homebrew Switch.
- Installez les paquets suivants : `switch-bzip2`, `switch-dav1d`, `switch-freetype`, `switch-glm`, `switch-harfbuzz`, `switch-libarchive`, `switch-libass`, `switch-libfribidi`, `switch-libjpeg-turbo`, `switch-libpng`, `switch-libwebp`, `switch-curl`, `switch-libssh2`, `switch-mbedtls`, `switch-ntfs-3g` et `switch-lwext4`. De plus, les dépendances de compilation suivantes sont requises : `switch-pkg-config`, `dkp-meson-scripts`, `dkp-toolchain-vars` et [GIMP](https://www.gimp.org/) (2 ou 3).
- Compilez et installez une version GPL de [libusbhsfs](https://github.com/DarkMatterCore/libusbhsfs).
- Compilez et installez [libsmb2](misc/libsmb2/) et [libnfs](misc/libnfs/).
- Configurez, compilez et installez FFmpeg : `make configure-ffmpeg && make build-ffmpeg -j$(nproc)`.
- Configurez, compilez et installez libuam : `make configure-uam && make build-uam`.
- Configurez, compilez et installez mpv : `make configure-mpv && make build-mpv`.
- Enfin, compilez l’application principale et construisez la distribution finale : `make dist -j$(nproc)`.
- Le résultat se trouvera dans `build/`.

## Crédits
- [Behemoth](https://github.com/HookedBehemoth) pour la méthode de remplacement du bouton de capture d’écran.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---