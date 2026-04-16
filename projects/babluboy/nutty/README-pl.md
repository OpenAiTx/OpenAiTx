
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# Nutty [![Status tłumaczenia](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Status kompilacji](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Status Snap](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Wspieraj](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Narzędzie sieciowe

Autor: Siddhartha Das

Prosta aplikacja stworzona dla elementary OS, która dostarcza podstawowych informacji dotyczących aspektów sieciowych. Informacje prezentowane są w następujących zakładkach.<br>
1. Moje informacje: Zapewnia podstawowe i szczegółowe dane dotyczące karty sieciowej urządzenia<br>
2. Użycie: Dostarcza dane o wykorzystaniu sieci w dwóch widokach – zużycie historyczne oraz bieżące zużycie<br>
3. Szybkość: Sprawdź prędkości wysyłania i pobierania oraz uzyskaj czasy tras do hosta<br>
4. Porty: Dostarcza informacji o aktywnych portach i aplikacjach z nich korzystających na lokalnym urządzeniu<br>
5. Urządzenia: Monitoruje, ostrzega i podaje informacje o innych urządzeniach podłączonych do sieci<br>

Sprawdź stronę Nutty, aby uzyskać szczegóły dotyczące funkcji, skrótów klawiszowych, przewodników instalacji dla Ubuntu i innych wspieranych dystrybucji itp.: <br>
https://babluboy.github.io/nutty/

## Kompilacja, testowanie i instalacja ze źródeł

Aby zbudować, potrzebujesz następujących zależności:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Aby uruchomić, wymagane są poniższe zależności:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Czasami vnstat nie uruchamia się automatycznie po instalacji, użyj odpowiedniego polecenia systemu init, aby włączyć demona vnstat, np. `sudo systemctl enable vnstat`

Uruchom `meson build`, aby skonfigurować środowisko budowania, a następnie `ninja test`, aby zbudować

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
Aby zainstalować, użyj `sudo ninja install`, a następnie uruchom polecenie `com.github.babluboy.nutty`


```
sudo ninja install
com.github.babluboy.nutty
```
Aby odinstalować, przejdź do katalogu build i uruchom

```
sudo ninja uninstall
```

### Instalacja z pakietu Deb

Aby zainstalować Nutty z pakietu `.deb`, upewnij się, że masz zainstalowane wszystkie powyższe zależności wykonawcze Nutty (nie są potrzebne zależności do budowania). Następnie uruchom poniższe polecenie
```bash
sudo dpkg -i <deb-package-name>.deb
```
  
Aby odinstalować Nutty zainstalowany za pomocą pakietu `.deb`, uruchom
```bash
sudo apt autoremove com.github.babluboy.nutty
```
Jeśli chcesz samodzielnie bezpośrednio zbudować pakiet `.deb` Nutty, zainstaluj powyższe zależności do budowania, a następnie uruchom

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