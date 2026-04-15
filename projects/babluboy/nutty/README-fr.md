# Nutty [![État de la traduction](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Statut de la build](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Statut Snap](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Faire un don](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Une utilité réseau

Auteur : Siddhartha Das

Une application simple conçue pour elementary OS afin de fournir des informations essentielles sur les aspects liés au réseau. Les informations sont présentées dans les onglets suivants.<br>
1. Mes infos : Fournit des informations basiques et détaillées sur la carte réseau de l’appareil<br>
2. Utilisation : Fournit l’usage des données réseau en deux vues - usage historique et usage actuel<br>
3. Vitesse : Vérifie les vitesses d’envoi et de téléchargement et obtient les temps de route vers un hôte<br>
4. Ports : Fournit des informations sur les ports actifs et les applications qui les utilisent sur l’appareil local<br>
5. Appareils : Surveille, alerte et fournit des informations sur les autres appareils connectés au réseau<br>

Consultez le site web de Nutty pour les détails sur les fonctionnalités, raccourcis, guides d’installation pour Ubuntu et autres distributions supportées, etc. : <br>
https://babluboy.github.io/nutty/

## Compilation, test et installation depuis la source

Vous aurez besoin des dépendances suivantes pour compiler :
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Et ces dépendances pour exécuter :
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Parfois vnstat ne démarre pas après l’installation, utilisez la commande appropriée du système init pour démarrer le démon vnstat, par ex. `sudo systemctl enable vnstat`

Exécutez `meson build` pour configurer l'environnement de compilation et exécutez `ninja test` pour compiler

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

Pour installer, utilisez `sudo ninja install`, puis exécutez avec `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```

Pour désinstaller, allez dans le répertoire de build et exécutez
```
sudo ninja uninstall
```

### Installation à partir du paquet Deb

Pour installer Nutty à partir du paquet `.deb`, assurez-vous d’avoir installé toutes les dépendances d’exécution mentionnées ci-dessus pour Nutty (pas besoin des dépendances de compilation). Ensuite, exécutez la commande ci-dessous
```bash
sudo dpkg -i <deb-package-name>.deb
```

Et pour désinstaller Nutty installé via un paquet `.deb`, exécutez
```bash
sudo apt autoremove com.github.babluboy.nutty
```

Si vous souhaitez directement construire vous-même le paquet `.deb` de Nutty, installez les dépendances de construction ci-dessus puis lancez
```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---