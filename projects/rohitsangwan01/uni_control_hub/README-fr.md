# UniControlHub

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)
![Downloads](https://img.shields.io/github/downloads/rohitsangwan01/uni_control_hub/total.svg)

<p align="center">
  <img src="https://github.com/user-attachments/assets/41c886c0-f08c-4186-bc98-153aa2769d13" height=150 />
</p>

UniControlHub : Connectez Vos Appareils Sans Effort

UniControlHub révolutionne votre interaction avec votre environnement numérique en offrant une expérience de contrôle fluide et intuitive sur plusieurs appareils. Inspiré par la commodité et la fluidité de l’Universal Control d’Apple, UniControlHub étend cette fonctionnalité innovante au-delà de l’écosystème Apple. Avec une seule souris et un clavier, vous pouvez naviguer et gérer vos appareils sans effort, UniControlHub garantit un espace de travail cohérent et productif. Conçu avec Flutter pour une expérience utilisateur fluide et réactive, cette application est l’outil ultime pour améliorer la productivité et simplifier votre vie numérique.

![macOS](https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Linux](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)

<a href="https://buymeacoffee.com/rohitsangwan" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


## Pour Commencer

Téléchargez l’application pour votre plateforme depuis la section [Release](https://github.com/rohitsangwan01/uni_control_hub/releases)

### MacOS

- Installez libusb : `brew install libusb`

### Windows

- Installez `Microsoft Visual C++ 2015-2022` pour votre OS [x86](https://aka.ms/vs/17/release/vc_redist.x86.exe) ou [x64](https://aka.ms/vs/17/release/vc_redist.x64.exe).

- Si votre appareil Android n’est pas détecté, assurez-vous d’avoir les [drivers](https://github.com/libusb/libusb/wiki/Windows#driver-installation) libusb installés.

### Linux

Assurez-vous que `libqt5dbus5` est installé

Sur les systèmes basés sur Ubuntu/Debian, exécutez :

```bash
sudo apt update
sudo apt install libqt5dbus5
```

Sur Fedora/RHEL/CentOS, exécutez :

```bash
sudo dnf install qt5-qtbase
```

Sur Arch Linux, exécutez :

```bash
sudo pacman -S qt5-base
```

## Plates-formes prises en charge

| Plate-forme | Bluetooth | USB | ADB |
| ----------- | --------- | --- | --- |
| IOS         | ✅        | ❌  | ❌  |
| Android     | ⏳        | ✅  | ✅  |

## Capture d'écran

<p align="start">
  <img src="https://github.com/rohitsangwan01/uni_control_hub/assets/59526499/7b2b87c3-4501-490b-a205-0e3815c4b583" height=400 />
</p>

## Démo

[![](http://markdown-videos-api.jorgenkh.no/youtube/KYsqdJkG2N0)](https://youtu.be/KYsqdJkG2N0)

## Dépannage

- Sur MacOS, l’application demandera les permissions `Accessibilité` et `Bluetooth` sur MacOS, (Après mise à jour, l’application peut de nouveau demander la permission Accessibilité, même si elle est déjà accordée, essayez de retirer l’application d’Accessibilité et relancez-la)
- Pour utiliser le mode UHID pour Android, assurez-vous que `ADB` est installé (non requis pour le mode AOA)
- Pour la connexion Desktop et IOS, assurez-vous que le Bluetooth est activé
- Après avoir connecté un appareil Android, cliquez sur le bouton rafraîchir

## Guide du développeur

Cette section vous guide à travers la configuration et l’exécution de UniControlHub à des fins de développement.

#### Prérequis :

- Installez la dernière version de [Flutter](https://flutter-ko.dev/get-started/install) pour votre système d’exploitation. Vous pouvez trouver les instructions sur le site officiel de Flutter.
- Suivez le guide d’installation de [Flutter](https://flutter-ko.dev/get-started/install) pour votre plateforme. Vous pouvez ignorer les étapes spécifiques à Android ou iOS si vous ne développez pas pour ces plateformes.

#### Exécution/Débogage de l’application :

- Une fois Flutter configuré, exécutez `flutter pub get` pour télécharger les dépendances, puis `flutter run` pour lancer l’application

## Sponsor

Si vous trouvez ce projet utile, envisagez de le sponsoriser ! Votre soutien aide à maintenir le développement actif, à ajouter de nouvelles fonctionnalités et à améliorer la stabilité. Vous pouvez également partager vos idées ou vos retours dans les [Discussions](https://github.com/rohitsangwan01/uni_control_hub/discussions). Merci pour votre soutien ! 🚀

[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/rohitsangwan01)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/rohitsangwan)

## Notes supplémentaires :

UniControlHub utilise le [serveur Synergy](https://github.com/symless/synergy-core) pour le partage multiplateforme du clavier et de la souris. Vous pouvez trouver plus d'informations sur [Synergy](https://symless.com/synergy) sur leur site web.

Nous accueillons les contributions à UniControlHub ! Si vous trouvez un bug ou avez une demande de fonctionnalité, veuillez ouvrir un ticket sur notre dépôt GitHub.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---