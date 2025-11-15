
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Pre-Release](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Vorabversion)](https://github.com/till213/skydolly/releases)
![Lizenz: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20Lizenz-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Unterstützte Compiler](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compiler-GCC%2C%20clang%2C%20MSVC-informational)

![Unit-Tests](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - Das schwarze Schaf für Ihre Flugaufzeichnungen.

## Über
Sky Dolly verbindet sich mit einer laufenden Flight Simulator 2020-Instanz und zeichnet verschiedene Simulationsvariablen zur Wiedergabe auf.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

Die Verbindung erfolgt über SimConnect, eine Standard-API, die mit Flight Simulator X eingeführt wurde, um mit dem Flugsimulator zu kommunizieren.

Siehe auch [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Funktionen
- Aufnehmen / Pause / Abspielen
- Formationsflüge (mehrere Flugzeuge, Wiedergabe während der Aufnahme, "Fliegen in Formation", Zeitversatz)
- Einstellbare Aufnahme-Samplerate: fest oder variabel ("auto")
- Einstellbare Wiedergabegeschwindigkeit ("Zeitlupe", "Zeitraffer"), Wiedergabeschleife
- Position, Geschwindigkeit und grundlegende Steuerungsvariablen (Querruder, Seitenruder, Klappen, Fahrwerk, ...) werden aufgezeichnet
- Plugin-Architektur mit verschiedenen Import/Export-Plugins (CSV, GPX, IGC, KML)
- Standortmodul mit über 100 Standardstandorten und Import/Export-Funktion
- Datenbankbasierte Persistenz (SQLite) ("Flugbuch")

Sehen Sie sich den (Vorschau-)Release-Trailer auf [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I) an:

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Weitere mit Sky Dolly erstellte Videos finden Sie auch unter [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Neue und kommende Funktionen finden Sie im [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Grundlegende Verwendung

- Flug starten
- Klicken Sie auf "Aufnehmen" (Taste R)
- Sie können die Aufnahme pausieren (Taste P)
- Aufnahme beenden (Taste R) und auf "Abspielen" (Leertaste) klicken
- Wiedergabegeschwindigkeit und Wiedergabeposition auch während der Wiedergabe anpassen
- Aufgezeichnete Flüge werden automatisch im "Flugbuch" gespeichert
- Wählen Sie einen Flug im Flugbuch aus und drücken Sie "Laden" (oder doppelklicken Sie auf die Zeile), um den gespeicherten Flug zu laden

### Formation-Aufnahme & Wiedergabe

#### Aufnahme

- Wechsle zum Modul "Formation" (Taste F2)
- Klicke auf "Aufnehmen" (Taste R)
- Jedes aufgezeichnete Flugzeug wird zum aktuellen Flug hinzugefügt
- Während bestehende Flugzeuge während der Aufnahme mit "Auto"-Abtastrate wiedergegeben werden, kannst du dennoch die Aufnahme-Abtastrate ändern

#### Position

- Das zuletzt aufgezeichnete Flugzeug wird zum "Benutzerflugzeug" (wird von der Kamera im Flugsimulator verfolgt)
- Wähle eine Position relativ zum aktuellen "Benutzerflugzeug" vor der Aufnahme

#### Wiedergabe

- Einfach auf "Abspielen", "Pause" klicken und in der Zeitleiste suchen, genau wie bei einem Einzelflug
- Ändere das "Benutzerflugzeug" (auch während der Wiedergabe), um "von Cockpit zu Cockpit zu springen"
- Übernehme die Kontrolle über das "Benutzerflugzeug", indem du entweder "Kontrolle übernehmen" oder die Option "Mit Formation fliegen" wählst

#### Verwaltung von Formationen

- Du kannst einzelne Flugzeuge aus einem Flug ("Formation") löschen
- Es muss mindestens ein Flugzeug pro Flug vorhanden sein, daher kann das letzte Flugzeug nicht gelöscht werden
- Füge dem ausgewählten Flugzeug einen Zeitversatz hinzu ("Synchronisation des Multiplayer-Formationsflugs")
- Um einen neuen Einzel-Flug zu starten, wechsle zurück zum Modul "Logbuch" (Taste F1) und klicke auf "Aufnehmen" (Taste R)

Warum probierst du es nicht mit einer der geführten ["Tell Tours"](https://github.com/till213/Tell-Tours)? :)

## Download

Gehe zu [Releases](https://github.com/till213/SkyDolly/releases) und lade die neueste Version herunter.

Neueste (Vor-)Version: **Sky Dolly 0.19.2**

Berechne und vergleiche deine Prüfsumme mit den [veröffentlichten SHA-256-Prüfsummen](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), um die Integrität deiner heruntergeladenen Kopie zu überprüfen.

## Build

Siehe die [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md) Dokumentation.

## Verwandte Projekte

- https://github.com/nguyenquyhy/Flight-Recorder - Eine auf .Net basierende Anwendung zur Flugaufzeichnung und -wiedergabe
- https://github.com/saltysimulations/saltyreplay/ - Eine Aufnahme- und Wiedergabeanwendung mit Web-Benutzeroberfläche
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Zeichnet den Flug auf und erzeugt Google Earth (KML-Format) "Wiedergaben"
- https://github.com/Elephant42/FS_Tool - Ein einfaches Tool, mit dem sich die Flugzeugposition und die Simulationsrate einstellen lassen
- https://github.com/pyviator/msfs-geoshot - Macht Screenshots und versieht diese automatisch mit Geotags
- https://github.com/ijl20/msfs_logger_replay - IGC-Logger und Wiedergabe (für FSX)
- https://joinfs.net/ - Ermöglicht die Synchronisierung von Mehrspielerflügen über verschiedene Flugsimulatoren hinweg (MSFS, Prepar3D/FSX, XPlane). Bietet auch einen Flugrekorder mit Formationsflug-Aufzeichnung ("Overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote für FlyByWire's A32NX: Steuerung der Cockpitfunktionen des FBW A320, unter Verwendung von FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analysiert das MSFS-Logbuch und bietet einen CSV-Export, der von Sky Dolly gelesen werden kann
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave speichert automatisch (oder auf Anfrage) Flugpläne
- https://github.com/mracko/MSFS-Landing-Inspector - Analysiert Ihre Landungsleistung
- [Points of Interest (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Sehenswürdigkeiten, Flughäfen und 3D-Städte in Microsoft Flight Simulator.

## Weitere nützliche Ressourcen

- https://obsproject.com/ - Anwendung für Bildschirmaufnahme / Übertragung
- https://sqlitebrowser.org/ - Durchsuchen Sie die Sky Dolly Logbuchdatenbank (*.sdlog), führen Sie eigene SQL-Abfragen aus


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---