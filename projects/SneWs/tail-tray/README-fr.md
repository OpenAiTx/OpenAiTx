# Tail Tray
Menu de la barre système Tailscale et interface utilisateur pour Plasma Desktop

**Avertissement** Veuillez noter que je n'ai _aucune_ association avec Tailscale Inc.

Ceci est un projet personnel et n'est en aucun cas approuvé par Tailscale Inc.

### Fonctionnalités
- [X] Contrôlez votre connexion Tailscale depuis la barre système
- [X] Affiche les adresses IP
- [X] Affiche le statut de connexion actuel de vos appareils
- [X] Vue d'ensemble de votre réseau et de l'état du réseau
- [X] Définir et changer votre nœud de sortie Tailscale
- [X] Gestion appropriée des comptes multiples
- [X] Nœuds de sortie Mullvad
- [X] Support des Tail drives - Fonctionne avec le support davfs2 + aide supplémentaire pour configurer davfs2 et le montage, etc.
- [X] Envoyez des fichiers à n'importe quel appareil de votre Tailnet directement depuis le menu de la barre système
- [X] Recevez des notifications et recevez des fichiers de n'importe quel appareil de votre Tailnet vers un emplacement prédéfini sur le disque
- [X] Binaries précompilés pour les principales distributions et support expérimental Windows

### Licence
Licence publique générale GNU v3.0 - voir [LICENSE](LICENSE) pour plus de détails

### Installation
Pour l'instant, la manière la plus simple et la plus fiable d'installer ceci est de le compiler à partir des sources.
Pour cela, veuillez consulter la section Démarrage rapide ci-dessous.

### Prérequis
* Tailscale installé et en fonctionnement - https://tailscale.com
* davfs2 installé et configuré (si vous prévoyez d'utiliser les Tail drives ou d'y accéder. Tail Tray vous aide également à configurer cela automatiquement) - https://wiki.archlinux.org/title/Davfs2

### Architectures supportées
* x86_64
* ARM64
* Toute autre architecture supportée par QT 6 où vous pouvez compiler ce projet et où Tailscale fonctionne

### Démarrage rapide

### Paquets précompilés

 * [Distros basées sur Debian / Ubuntu / Mint](https://github.com/SneWs/tail-tray/releases)
 * [RPMs OpenSUSE & Fedora](https://software.opensuse.org/download.html?project=home%3Aayankov&package=tail-tray)
 * [NixOS](/docs/nix-os.md)
 * [Windows (EXPÉRIMENTAL ! seulement la dernière version instable, et non signée)](https://github.com/SneWs/tail-tray/releases/download/latest/Tail-Tray-Windows.zip)

### Compiler et installer depuis la source
 * [Sur Linux](/docs/build-from-src.md)
 * [Sur Windows](/docs/build-from-src-windows.md)

### Actions scriptables
Pour en savoir plus sur la manière d’écrire et d’utiliser des actions scriptables, veuillez lire le [Guide des actions scriptables](https://raw.githubusercontent.com/SneWs/tail-tray/master/docs/scriptable-actions.md)

### Participer & Signaler des bugs
* Si vous souhaitez participer au développement de ce projet, n’hésitez pas à forker le dépôt et soumettre une pull request.
* Les bugs, on en a tous... Veuillez signaler un problème dans l’onglet issues et nous le résoudrons ensemble.

### Captures d’écran
![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/launcher.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/connected-tray.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/disconnected-tray.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/settings-ui.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/network-status.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/file-sharing.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/devices-ui.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/ui-settings.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives01.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives02.png)

![Capture d’écran](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives03.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---