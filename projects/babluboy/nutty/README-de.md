
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Übersetzungsstatus](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Spenden](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Ein Netzwerkwerkzeug

Autor: Siddhartha Das

Eine einfache Anwendung, entwickelt für elementary OS, um grundlegende Informationen zu netzwerkbezogenen Aspekten bereitzustellen. Die Informationen werden in folgenden Reitern dargestellt.<br>
1. Meine Info: Bietet grundlegende und detaillierte Informationen zur Netzwerkkarte des Geräts<br>
2. Nutzung: Zeigt die Netzwerknutzung in zwei Ansichten – historische Nutzung und aktuelle Nutzung<br>
3. Geschwindigkeit: Überprüft Upload- und Download-Geschwindigkeiten und ermittelt Routenzeiten zu einem Host<br>
4. Ports: Bietet Informationen zu aktiven Ports und deren verwendenden Anwendungen auf dem lokalen Gerät<br>
5. Geräte: Überwacht, benachrichtigt und liefert Informationen zu anderen Geräten im Netzwerk<br>

Besuchen Sie die Nutty-Website für Details zu Funktionen, Tastenkombinationen, Installationsanleitungen für Ubuntu und andere unterstützte Distributionen usw.:<br>
https://babluboy.github.io/nutty/

## Kompilierung, Test und Installation aus dem Quellcode

Sie benötigen folgende Abhängigkeiten zum Kompilieren:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Und diese Abhängigkeiten zur Ausführung:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Manchmal wird vnstat nach der Installation nicht gestartet, verwenden Sie den passenden Befehl des Init-Systems, um den vnstat-Daemon zu starten, z. B. `sudo systemctl enable vnstat`

Führen Sie `meson build` aus, um die Build-Umgebung zu konfigurieren, und `ninja test`, um zu kompilieren

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

Zur Installation verwenden Sie `sudo ninja install`, anschließend führen Sie aus mit `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
Um zu deinstallieren, gehen Sie in das Build-Verzeichnis und führen Sie aus

```
sudo ninja uninstall
```

### Installation aus dem Deb-Paket

Um Nutty aus dem `.deb`-Paket zu installieren, stellen Sie sicher, dass Sie alle oben genannten Ausführungsabhängigkeiten von Nutty installiert haben (Build-Abhängigkeiten sind nicht erforderlich). Führen Sie dann den folgenden Befehl aus
```bash
sudo dpkg -i <deb-package-name>.deb
```
Und um Nutty zu deinstallieren, das über das `.deb`-Paket installiert wurde, führen Sie aus

```bash
sudo apt autoremove com.github.babluboy.nutty
```
Wenn Sie das `.deb`-Paket von Nutty selbst direkt erstellen möchten, installieren Sie die oben genannten Build-Abhängigkeiten und führen Sie dann aus

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