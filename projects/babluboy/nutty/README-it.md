
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Un'utilità di rete

Autore: Siddhartha Das

Una semplice applicazione creata per elementary OS per fornire informazioni essenziali sugli aspetti relativi alla rete. Le informazioni sono presentate nelle seguenti schede.<br>
1. Le mie info: Fornisce informazioni di base e dettagliate sulla scheda di rete del dispositivo<br>
2. Utilizzo: Fornisce l'utilizzo dei dati di rete in due visualizzazioni - utilizzo storico e utilizzo attuale<br>
3. Velocità: Controlla le velocità di Upload e Download e ottieni i tempi di percorso verso un host<br>
4. Porte: Fornisce informazioni sulle porte attive e sulle applicazioni che le utilizzano sul dispositivo locale<br>
5. Dispositivi: Monitora, segnala e fornisce informazioni sugli altri dispositivi connessi alla rete<br>

Consulta il sito di Nutty per dettagli su funzionalità, scorciatoie, guide di installazione per Ubuntu e altre distro supportate, ecc. : <br>
https://babluboy.github.io/nutty/

## Compilazione, Test e Installazione dal Sorgente

Avrai bisogno delle seguenti dipendenze per compilare:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

E di queste dipendenze per eseguire:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

A volte vnstat non viene avviato all'installazione, usa il comando del sistema di init appropriato per avviare il demone vnstat, ad esempio `sudo systemctl enable vnstat`

Esegui `meson build` per configurare l'ambiente di build ed esegui `ninja test` per compilare

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

Per installare, usa `sudo ninja install`, quindi esegui con `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```
Per disinstallare, vai nella directory di build ed esegui

```
sudo ninja uninstall
```

### Installazione dal pacchetto Deb

Per installare Nutty dal pacchetto `.deb`, assicurati di aver installato tutte le dipendenze di esecuzione sopra elencate di Nutty (non sono necessarie le dipendenze di build). Quindi esegui il seguente comando
```bash
sudo dpkg -i <deb-package-name>.deb
```

E per disinstallare Nutty installato tramite il pacchetto `.deb` esegui
```bash
sudo apt autoremove com.github.babluboy.nutty
```
Se desideri creare direttamente tu stesso il pacchetto `.deb` di Nutty, installa le dipendenze di build sopra indicate e poi esegui

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