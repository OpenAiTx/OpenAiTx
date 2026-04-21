
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Jetzt im AppCenter holen"/>
  </a>
</p>

![<center><b>Hauptfenster - Helles Thema</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Bildanmerkung für Elementary OS")

## Übersicht

Kommentieren Sie Ihre Bilder und lassen Sie ein Bild mehr als 1000 Worte sagen.

- Laden Sie ein Bild aus dem Dateisystem, der Zwischenablage oder erstellen Sie einen Screenshot zum Kommentieren.
- Fügen Sie Formen, Sticker, Bilder, Text, Zeichnungen und andere Markierungen hinzu, um Bilddetails hervorzuheben.
- Fügen Sie Lupen hinzu, um Bilddetails zu vergrößern.
- Weichzeichnen Sie Bildbereiche, um Daten unkenntlich zu machen.
- Zuschneiden, Größe ändern und Bilderrahmen hinzufügen.
- Steuern Sie Farben, Linienstärke und Schriftartdetails.
- Zoom-Unterstützung.
- Farbwähler-Unterstützung innerhalb eines geladenen Bildes.
- Unbegrenztes Rückgängig/Wiederherstellen von Änderungen.
- Ziehen und Ablegen von PNG-Kopien des kommentierten Bildes.
- Exportieren in die Bildformate JPEG, PNG, TIFF, BMP, PDF, SVG und WebP.
- Unterstützung für das Kopieren des kommentierten Bildes in die Zwischenablage.
- Druckerunterstützung.

## Installation

### Debian (aus dem Quellcode)

Sie benötigen folgende Abhängigkeiten, um Annotator zu bauen:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

Um Annotator aus dem Quellcode zu installieren, führen Sie `./app install` aus.

Um Annotator auszuführen, starten Sie `com.github.phase1geo.annotator`.

### Ubuntu (PPA)

Sie können das von @PandaJim gepflegte [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) verwenden. Das PPA unterstützt Ubuntu 20.04+. Geben Sie die folgenden Befehle nacheinander ein

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

Wenn Sie Arch Linux verwenden, gibt es ein
[AUR-Paket](https://aur.archlinux.org/packages/annotator/)
`annotator`:

```
% yay -S annotator
```

### Flatpak

Zusätzlich kann Annotator über Flatpak installiert und ausgeführt werden.

Um das elementary Flatpak aus dem Quellcode zu bauen, führen Sie `./app elementary` aus.

Um das Flathub Flatpak aus dem Quellcode zu bauen, führen Sie `./app flathub` aus.

Anschließend können Sie es mit `./app run-flatpak` ausführen.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Im AppCenter erhalten"/>
  </a>
</p>

## Danksagungen

Verwendet `document-edit-symbolic.svg` und `image-crop-symbolic.svg` aus
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic),
unter den Bedingungen der GPL v3.0-Lizenz.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---