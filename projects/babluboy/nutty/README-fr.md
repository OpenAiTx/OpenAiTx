
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Statut de traduction](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Statut de build](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Statut Snap](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Faire un don](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Un utilitaire réseau

Auteur : Siddhartha Das

Une application simple conçue pour elementary OS afin de fournir des informations essentielles sur les aspects liés au réseau. Les informations sont présentées sous forme d’onglets comme suit.<br>
1. Mes Infos : Fournit des informations de base et détaillées sur la carte réseau de l’appareil<br>
2. Utilisation : Fournit l’usage des données réseau selon deux vues — historique et utilisation en temps réel<br>
3. Vitesse : Vérifiez les vitesses d’upload et de download et obtenez les temps de routage vers un hôte<br>
4. Ports : Fournit des informations sur les ports actifs et les applications qui les utilisent sur l’appareil local<br>
5. Appareils : Surveille, alerte et fournit des informations sur les autres appareils connectés au réseau<br>

Consultez le site web de Nutty pour plus de détails sur les fonctionnalités, raccourcis, guides d’installation pour Ubuntu et autres distributions supportées, etc. : <br>
https://babluboy.github.io/nutty/

## Compilation, test et installation depuis le code source

Vous aurez besoin des dépendances suivantes pour la compilation :
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Et de ces dépendances pour l’exécution :
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Parfois vnstat n’est pas démarré à l’installation, utilisez la commande appropriée pour démarrer le démon vnstat, c’est-à-dire `sudo systemctl enable vnstat`

Exécutez `meson build` pour configurer l’environnement de compilation puis `ninja test` pour compiler

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---