
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Vertaalstatus](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Doneer](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Een Netwerkhulpmiddel

Auteur: Siddhartha Das

Een eenvoudige applicatie gemaakt voor elementary OS om essentiële informatie te bieden over netwerkgerelateerde aspecten. De informatie wordt gepresenteerd in de volgende tabbladen.<br>
1. Mijn Info: Biedt basis- en gedetailleerde informatie over de netwerkaart van het apparaat<br>
2. Gebruik: Toont netwerkdatagebruik in twee weergaven - historisch gebruik en huidig gebruik<br>
3. Snelheid: Controleer Upload- en Downloadsnelheden en verkrijg route-tijden naar een host<br>
4. Poorten: Geeft informatie over actieve poorten en de applicatie die deze gebruikt op het lokale apparaat<br>
5. Apparaten: Bewaakt, waarschuwt en geeft informatie over andere apparaten die verbonden zijn met het netwerk<br>

Bekijk de Nutty-website voor details over functies, sneltoetsen, installatiehandleidingen voor Ubuntu en andere ondersteunde distributies, enz. : <br>
https://babluboy.github.io/nutty/

## Bouwen, Testen en Installeren vanuit Bron

Je hebt de volgende afhankelijkheden nodig om te bouwen:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

En deze afhankelijkheden om uit te voeren:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Soms wordt vnstat niet gestart bij installatie, gebruik het juiste init-systeemcommando om de vnstat-daemon te starten, d.w.z. `sudo systemctl enable vnstat`

Voer `meson build` uit om de build-omgeving te configureren en voer `ninja test` uit om te bouwen

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

Om te installeren, gebruik `sudo ninja install`, voer daarna uit met `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
Om te deïnstalleren, ga naar de build-directory en voer uit

```
sudo ninja uninstall
```

### Installatie vanuit Deb-pakket

Om Nutty te installeren vanuit het `.deb`-pakket, zorg ervoor dat je alle bovenstaande uitvoeringsafhankelijkheden van Nutty hebt geïnstalleerd (bouwhulpmiddelen zijn niet nodig). Voer daarna het onderstaande commando uit
```bash
sudo dpkg -i <deb-package-name>.deb
```
  
En om Nutty te verwijderen die via het `.deb`-pakket is geïnstalleerd, voer uit
```bash
sudo apt autoremove com.github.babluboy.nutty
```
Als je zelf direct het `.deb`-pakket van Nutty wilt bouwen, installeer dan de bovenstaande bouwafhankelijkheden en voer vervolgens uit

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