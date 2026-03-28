
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Wine GUI mit Zenity - Spielen und Teilen!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Was ist WineZGUI

WineZGUI (ausgesprochen Wine-Zee-Goo-Eee) ist ein Wine-Frontend, um Windows-Spiele mit Wine einfach zu spielen. Es handelt sich um eine Sammlung von Bash-Skripten für das Wine-Prefix-Management und die Linux-Desktop-Integration, um das Spielen mit Wine durch Zenity zu erleichtern. Es ermöglicht das schnelle Starten von Direkt-Play- (nicht installierten) EXE-Anwendungen oder -Spielen aus Dateimanagern wie Nautilus und erlaubt das Erstellen eines separaten Wine-Prefix für jede Windows-EXE-Datei.

## Warum WineZGUI?

1. Startet Windows-Spiele oder EXE-Dateien aus dem Dateimanager
2. Erstellt Anwendungsshortcuts für einen einfacheren Zugriff.
3. Konzentriert sich auf das Spielen und nicht auf das Einrichten von Prefixes.
4. Sichert und stellt Prefixes zur späteren Nutzung wieder her.
5. Erstellt Spielpakete zum Teilen (Prefix+Spiel)

## Wie es funktioniert

1. Wenn eine Windows-Binärdatei oder EXE mit WineZGUI geöffnet wird,
2. Erstellt es ein neues Prefix (kopiert Vorlage) und ein Desktop-Shortcut mit dem EXE-Dateinamen.
3. Wenn der Nutzer das Skript startet, wird die EXE ausgeführt.
4. Handelt es sich um ein Setup, wird die installierte EXE erkannt und Shortcuts im Spiele-Menü erstellt.

## Wie man ein Spiel oder Programm auf einem anderen Laufwerk oder Verzeichnis ausführt

Öffnen Sie Ihr Terminal und geben Sie Folgendes ein:

`flatpak override --user --filesystem=/pfad/zu/ihrem/laufwerk io.github.fastrizwaan.WineZGUI`

### WineZGUI installieren

WineZGUI ist als Flatpak auf Flathub verfügbar:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

Flathub WineZGUI kann nur auf Desktop-, Dokumente-, Downloads-, Musik-, Bilder- und Videos-Verzeichnisse zugreifen. Um auf Dateien aus anderen Orten oder von anderen eingebundenen Partitionen oder Laufwerken zuzugreifen, kopieren Sie sie entweder in die genannten Verzeichnisse (Downloads usw.) oder es muss eine Leseberechtigung vergeben werden, was mit der Flatseal-App oder über die Kommandozeile `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI` möglich ist.

Ich empfehle dringend die Flatpak-Version zu nutzen, da die distributionsbasierte Wine-Version (wine-staging) ständig aktualisiert wird und Spiele dadurch oft nicht mehr funktionieren. Die Nutzung von wine-stable aus Flathub ist besser oder verwenden Sie wine-stable 5.0 oder 7.0 aus den Distro-Paketen.

#### Installieren Sie WineZGUI Flatpak auf [unterstützten Linux-Distributionen](https://flatpak.org/setup/)

WineZGUI ist in flatpak-wine von mir selbst gepackt. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) mein anderes Flatpak, jetzt veraltet [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)


### INSTALLATION auf einem Linux-System, siehe [Anforderungen](https://github.com/fastrizwaan/WineZGUI#requirements)

Die Einrichtung erfolgt sofort, da nur wenige Dateien in bestimmte Verzeichnisse kopiert werden.

##### Version 0.99.13

Quellcode herunterladen [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) oder `git tag 0.99.13` verwenden

##### Verwendung von tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Entwicklungsversion

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Deinstallation von WineZGUI

##### Flatpak-Deinstallation

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### System deinstallieren

Führen Sie `uninstall` aus dem gleichen Installationsquellverzeichnis aus

```
sudo ./setup --uninstall
```

## Anforderungen

`wine` - Hauptprogramm

`winetricks` - erforderliches wine-Zusatzskript

`perl‑image‑exiftool` - zum Extrahieren des Anwendungs-/Spielenamens

`icoutils` - um das Icon aus der exe-Datei zu extrahieren

`gnome-terminal` - (optional) um auf das Prefix-Verzeichnis in der Shell zuzugreifen

## Anforderungen unter Linux OS installieren

### Flatpak-unterstützte Distributionen

Hole dir [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases), das alle Abhängigkeiten enthält. Nützlich für Distributionen, die wine nicht paketieren.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Laufzeitabhängigkeiten:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### XBOX-kompatible Controller

Erstellen und installieren Sie Kernel-Treiber für Xbox 360-kompatible Controller von https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---