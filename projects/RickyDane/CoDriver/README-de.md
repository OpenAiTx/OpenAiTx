
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Kauf mir einen Kaffee bei ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Ein einfacher Dateiexplorer, der entstand, weil ich die Rust-Sprache lernen wollte.
  <br>
  Er ist betriebssystemunabhängig und für Optimierung ausgelegt.
</p>

<br/><br/>

Die Leistung wird durch ["jwalk"](https://crates.io/crates/jwalk/versions) und ["Tauri"](https://tauri.app/) erreicht.
<br/><br/>
CoDriver verwendet kein Pfad-Caching zum Zugriff auf Dateien und Ordner, daher wird die Leistung durch Rust, die Geschwindigkeit der Festplatte und die CPU-Leistung erzielt.

⁉️ Beachten Sie, dass diese Software noch in der Entwicklung ist und Fehler enthalten kann!
<br/><br/>

# Links
- <a href="#basic-features">Grundfunktionen</a>
- <a href="#advanced-features">Erweiterte Funktionen</a>
- <a href="#dependencies-if-not-working-instantly">Abhängigkeiten</a>
- <a href="#%EF%B8%8F-ftp-sftp-integration">FTP / SFTP-Integration</a>
- <a href="#%EF%B8%8F-known-issues">Bekannte Probleme</a>
- <a href="#-todos">Todos</a>
- <a href="#user-interface">Benutzeroberfläche</a>

## Grundfunktionen
- Navigieren Sie durch Verzeichnisse wie gewohnt
- Kopieren & Einfügen, löschen, erstellen und umbenennen von Dateien und Ordnern
- Wechseln Sie zwischen Raster-, Listen- und Miller-Spaltenmodus
- Schließen Sie Popups mit Esc
- Springen Sie direkt zu einem Verzeichnis mit Strg / Cmd + G, indem Sie einen Pfad eingeben
- Sortieren Sie Elemente im Listenmodus nach Größe, Name oder zuletzt geändert

## Erweiterte Funktionen
- Dateien und Ordner komprimieren
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Archive entpacken
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Navigieren Sie zu einem Verzeichnis mit dem Shortcut LAlt + 1 / 2 / 3 | (macOS Option + 1 / 2 / 3)
  - Konfigurieren Sie die Pfade selbst in den Einstellungen
- Datei erstellen mit F6
- Ordner erstellen mit F7
- Dual-Panel Ansicht
  - Suche nach Dateien mit F8
  - Kopieren Sie das aktuell ausgewählte Element in das andere Panel mit F5
  - Verschieben Sie das aktuell ausgewählte Element in das andere Panel mit LShift + F5
- Ziehen Sie Dateien per Drag & Drop in den Explorer, um sie in das aktuelle Verzeichnis zu kopieren
- Mehrfach-Umbenennen Ihrer Auswahl mit Strg / Cmd + LShift + M
  - Mehrfach-Umbenennen ausführen mit Strg / Cmd + Enter
- Schnelle Dateivorschau -> Verzeichniseintrag auswählen und die Leertaste drücken.
  - Unterstützte Dateien: alle Bilddateien (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Alle anderen Elemente zeigen eine kleine Kachel mit einigen Informationen darüber an. (Pfad, Größe, zuletzt geändert)
- Sofortige Navigation -> Beginnen Sie zu tippen und filtern Sie automatisch die Verzeichniseinträge, was es manchmal <br/>
  viel schneller macht, zu einem gewünschten Ort zu navigieren

## Abhängigkeiten (Falls es nicht sofort funktioniert)

<details>
<summary>Erweitern zum Anzeigen</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Arch
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ FTP / SFTP-Integration

CoDriver bietet vollständig native, sofort einsatzbereite Unterstützung für FTP- und SFTP-Remote-Verbindungen. Keine externen Abhängigkeiten, FUSE-Layer oder `sshfs`-Mounts erforderlich! Verbinden Sie Ihre Remote-Server einfach direkt im Seitenleisten-Panel.

## 🏴‍☠️ Sprachunterstützung
- Englisch
  - Option zur Auswahl zwischen verschiedenen Sprachen kommt bald ...

## ⚠️ Bekannte Probleme:
- Drag & Drop außerhalb des Fensters funktioniert derzeit unter Linux nicht immer
- Unter Windows müssen Sie möglicherweise das [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) installieren
- Berechtigungen unter ms-windows sind etwas seltsam
  - Sie müssen das Programm eventuell als Administrator ausführen, wenn Probleme beim Kopieren von Elementen oder Ähnlichem auftreten
- Es kann sein, dass Sie openssl1.1 auf Linux-Systemen installieren müssen, falls das Programm nicht startet

## 📝 ToDos:
- Mehrere Sprachen
- Favoriten
- Zugriff auf Online-Speicherdienste (Google Drive, etc.)

## Benutzeroberfläche
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## Wie man beiträgt
Richten Sie Ihre Maschine für die Entwicklung von Tauri v1-Anwendungen ein: [Tauri Voraussetzungen](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Wenn dies erledigt ist, führen Sie einfach ```git clone https://github.com/RickyDane/CoDriver``` oder ```gh repo clone RickyDane/CoDriver``` an einem Ort auf Ihrem Rechner aus.
</br></br>
Sie sollten in der Lage sein, ```cargo tauri dev``` im Root-Verzeichnis dieses Projekts auszuführen, um mit dem Bauen und Starten von CoDriver zu beginnen.
</br>
Stellen Sie sicher, dass tauri-cli installiert ist: ```cargo install tauri-cli```
</br>

## Release-Signierung

macOS-Release-Artefakte müssen signiert und notariell beglaubigt werden, damit Gatekeeper nicht meldet, dass die installierte App beschädigt ist. Siehe [macOS-Signierung und Notarisierung](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) für benötigte GitHub Actions Secrets und Verifizierungskommandos.

## Star History

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Andere Drittanbieter-Software
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---