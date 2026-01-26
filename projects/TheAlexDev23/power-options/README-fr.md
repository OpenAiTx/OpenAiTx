<div align="center">
    <img src="https://raw.githubusercontent.com/TheAlexDev23/power-options/main/icon.png" width=120>
    <h1>
        Options d'Alimentation
    </h1>
    <a href="https://discord.gg/KyZt97MvdU">
        <img src="https://img.shields.io/badge/Discord-%235865F2.svg?style=for-the-badge&logo=discord&logoColor=white">
    </a>
    <a href="https://www.paypal.com/paypalme/AlexanderKarpukhin2">
        <img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white">
    </a>
</div>

<br/>

Application Linux GUI tout-en-un ultra-rapide pour la gestion simple et avancée
de l'alimentation sur n'importe quel appareil.

Options d'Alimentation peut remplacer n'importe quelle application d'économie d'énergie,
y compris TLP, auto-cpufreq, cpupower-gui, etc. Options d'Alimentation couvre tous les
paramètres d'économie d'énergie les plus courants et ajoute des options supplémentaires
absentes de toute autre application.

Lors de l'installation, Options d'Alimentation analysera le système et générera
intelligemment une large gamme de profils basés sur les résultats. Ces profils
sont grandement optimisés et ne devraient pas nécessiter d'intervention, sauf si
l'utilisateur souhaite un contrôle plus poussé.

La plupart des applications ne permettent que deux profils : Profil Batterie et
Profil Secteur. Ceci est sous-optimal pour les occasions où l'on souhaite un
contrôle plus grand. C'est ce qui a conduit à la création du système de profils
utilisé par ce programme :
- L'utilisateur peut avoir autant de profils qu'il le souhaite
- L'utilisateur choisit quels profils seront sélectionnés pour la Batterie et le Secteur.
- L'utilisateur peut temporairement outrepasser la sélection du profil pour un autre jusqu'à
  ce qu'il retire cette substitution.
- L'utilisateur peut définir une substitution persistante qui sera conservée au redémarrage.

## Interfaces/Frontends Disponibles

On peut simplement installer le démon et éditer manuellement les fichiers de configuration
car ils sont écrits en TOML. Mais la plus grande force de ce programme
réside dans les interfaces GUI qu'il fournit, car presque aucun autre outil d'économie d'énergie ne le fait
en possède une et utilise des fichiers de configuration.

### Interface native GTK

Simple, légère et native avec une interface simple. Recommandée pour la plupart
des utilisateurs.

![gtk-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/gtk-slideshow.gif)

### Interface WebKit

Options plus avancées et contrôle accru. Moins légère. Recommandée pour
les utilisateurs avancés et ceux qui souhaitent utiliser power-options en tandem avec
une autre solution de gestion d'alimentation.

![webview-slideshow](https://raw.githubusercontent.com/TheAlexDev23/power-options/main/static/webview-slideshow.gif)

## Fonctionnalités

Power options a été conçu à partir d'une compilation de tous les conseils et
recommandations des plus grands wikis et guides Linux ainsi que d'autres applications
d'économie d'énergie. Quelques exemples incluent :
- https://wiki.archlinux.org/title/Power_management
- https://wiki.gentoo.org/wiki/Power_management/Guide
- https://en.wikipedia.org/wiki/Power_management
- https://github.com/supplantr/ftw
- https://github.com/linrunner/TLP
- https://github.com/AdnanHodzic/auto-cpufreq
- https://github.com/vagnum08/cpupower-gui

Power Option inclut les fonctionnalités suivantes :
- Plus de types de profils que les alternatives
- Peut générer intelligemment des profils en analysant le système de l'utilisateur.
- Options de mise en veille système (suspension, extinction de l'écran)
- Options CPU
- Options individuelles pour chaque cœur CPU. La plupart des outils d'économie
  d'énergie ne proposent pas cette option, qui fut l'une des principales motivations de ce projet.
- Options d'écran
- Options pour désactiver les composants radio (ex : Bluetooth, WiFi, NFC)
- Options réseau. Offre un contrôle BIEN plus étendu que les applications alternatives, mais
  nécessite le rechargement du pilote réseau. Limité aux cartes réseau Intel utilisant
  iwlwifi.
- Options ASPM
- Options PCI
- Options USB
- Options SATA
- Options du noyau
- Paramètres du firmware
- Options audio
- Options GPU
- Paramètres Intel Running Average Power Limit (RAPL)

## Installation

### Recommandé : DistroPack (Interface GTK, Tray & Daemon)

Pour la plupart des utilisateurs, nous recommandons l'installation via [DistroPack](https://distropack.dev), qui fournit des paquets pour Debian/Ubuntu, Fedora/RHEL/Rocky, et Arch Linux avec une gestion automatique des spécificités de chaque distribution.

**Interface GTK :**
Visitez [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-gtk) pour les instructions d'installation spécifiques à votre distribution.

**System Tray :**
Visitez [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-tray) pour les instructions d'installation spécifiques à votre distribution.

**Juste le daemon :**
Visitez [https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon](https://distropack.dev/Install/Package/TheAlexDev23/power-options/power-options-daemon) pour les instructions d'installation spécifiques à votre distribution.

### Arch Linux (AUR)

Pour les utilisateurs d’Arch Linux, des paquets AUR sont également disponibles :

- GTK : `power-options-gtk` (stable) et `power-options-gtk-git` (bleeding edge)
- Webview : `power-options-webview` (stable) et `power-options-webview-git` (bleeding edge)
- System Tray : `power-options-tray` (stable) et `power-options-tray-git` (bleeding edge)
- Juste le daemon : `power-options-daemon` (stable) et `power-options-daemon-git` (bleeding edge)

### Interface Webview (Source ou AUR uniquement)

L'interface webview n'est actuellement pas disponible sur DistroPack et doit être installée soit depuis la source soit via AUR (pour les utilisateurs d’Arch Linux).

**Depuis AUR (Arch Linux uniquement) :**
```bash
yay -S power-options-webview  # or power-options-webview-git for bleeding edge
```
Pour construire, nécessite les bibliothèques de développement `libsoup-3.0-dev`, `libwebkit2gtk-4.1-dev` et  
`libxdo-dev` (ou l'équivalent dans votre distribution)



```bash
# dioxus-cli is required
cargo install dioxus-cli
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-webview.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

### Installation à partir des sources (méthode alternative)

Si vous préférez compiler à partir des sources ou si DistroPack ne prend pas en charge votre distribution :

- GTK : 

Pour la compilation, nécessite les bibliothèques de développement `libgtk4-dev` `libadwaita-1-dev` (ou l'équivalent dans
votre distribution)
```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-gtk.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- L'icône de la barre système :

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-tray.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

- Juste le démon :

```bash
git clone https://github.com/TheAlexDev23/power-options/ --depth=1
cd power-options/scripts
chmod +x *.sh
# Run as local user, will require sudo password
./install-daemon.sh
# If installing for the first time
./setup.sh
# If updating
./update.sh
```

## Dépendances

Pour les dépendances *build*, référez-vous au guide d'installation ci-dessus.

Obligatoires :
- lspci
- lsusb
- acpi

Optionnelles :
- carte réseau compatible iwlwifi pour la configuration réseau
- carte son Intel pour la configuration audio
- GPU Intel/AMD pour la configuration GPU
- xrandr : contrôle de la résolution/taux de rafraîchissement
- brightnessctl : contrôle de la luminosité
- ifconfig : blocage ethernet
- xset : délai d'extinction de l'écran
- xautolock : délai de suspension du système

Frontend Webview :
- webkit2gtk
- dioxus-cli

Frontend GTK :
- yad
- libadwaita

## Mise à jour

Si vous avez installé via DistroPack, votre gestionnaire de paquets devrait gérer
les mises à jour automatiquement (par exemple, `sudo apt update && sudo apt upgrade` pour Debian/Ubuntu,
`sudo dnf update` pour Fedora, ou `sudo pacman -Syu` pour Arch).

Si vous avez installé via l'AUR, votre gestionnaire de paquets devrait gérer
les mises à jour.

Si vous avez installé via des scripts d'installation, il suffit de récupérer les dernières modifications et
de relancer les scripts d'installation ainsi que `./update.sh`. **Important, ne lancez pas
`./uninstall.sh`, `./setup.sh` ou `power-daemon-mgr setup` si vous
voulez garder vos profils**

## Limitations
- La configuration réseau ne fonctionne que sur les cartes Intel et les cartes utilisant iwlwifi
- Le contrôle de la résolution et du taux de rafraîchissement ne fonctionne que sur X11 (les autres options devraient
  cependant fonctionner).
- La configuration audio ne fonctionne que sur les cartes Intel et les cartes utilisant `snd_hda_intel`
  ou `snd_ac97_codec`
- La configuration GPU ne fonctionne que sur les cartes Intel et AMD ou les cartes utilisant les pilotes/modules `i915`,
  `amdgpu` ou `radeon`.
- Les paramètres pour le contrôle de la résolution et du taux de rafraîchissement sont uniquement disponibles sur
  le frontend webview.

## Contribution

Une des façons les plus simples d’aider est d’ouvrir des issues lorsque vous rencontrez des erreurs.
Cela permet aux développeurs de savoir quoi corriger, et aide les futurs utilisateurs ayant le même
problème à trouver une solution.

Linux est un écosystème vaste, il existe des alternatives pour presque tout. Et
bien que power-options ait été conçu pour être utilisé avec les logiciels Linux les plus populaires,
vous pouvez toujours aider en adaptant power-options à d’autres alternatives que vous utilisez
en ouvrant des PR. Par exemple, porter power-options hors de systemd,
ajouter certaines fonctionnalités exclusives à X pour wayland, etc.

La branche `dev` contient presque toujours des fonctionnalités expérimentales qui doivent encore
être fusionnées dans la branche `main`. Si votre matériel supporte ces
fonctionnalités, les développeurs vous seront très reconnaissants si vous pouvez les tester sur votre
système et signaler les problèmes éventuels. L’utilisation du serveur Discord de power-options est
recommandée pour ces cas d’usage.

## Remerciements
- Arch Linux Wiki (https://wiki.archlinux.org)
- TLP (https://github.com/linrunner/TLP)
- Jeu d’icônes Figma Open Source (https://www.figma.com/community/file/1250041133606945841/8-000-free-icons-open-source-icon-set)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-26

---