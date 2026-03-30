
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Projektbeschreibung](#project-description)
- [Systemanforderungen:](#os-requirements)
- [FAQs](#faqs)
- [Fahrplan](#roadmap)
- [Screenshots](#screenshots)

## Projektbeschreibung

Elucidate ist eine Windows-GUI-Oberfläche für die Kommandozeilenanwendung SnapRAID.

*Dieses Projekt setzt die Zusammenführung der großartigen Arbeit fort, die von mir und anderen Mitwirkenden geleistet wurde.

## Systemanforderungen

- Windows-Betriebssystem
- .Net Runtime 4.8.0
- SnapRaid Version 11.5 oder niedriger
- 10MB freier Speicherplatz auf dem Ziellaufwerk

## FAQs

**F**: Was ist SnapRAID?<br/>
**A**: SnapRAID ist eine softwarebasierte Snapshot-Parity-Engine für Windows- und Linux-Betriebssysteme. Auf der grundlegendsten Ebene bietet sie Schutz für die Inhalte eines Dateisystems unter ihrer Verwaltung, indem sie die Hashes der einzelnen Dateien berechnet und die Ergebnisse in einer Paritätsdatei speichert. Im Falle eines vollständigen Festplattenausfalls kann diese Paritätsdatei verwendet werden, um die verlorenen Daten wiederherzustellen. Für vollständige Details besuchen Sie SnapRAIDs [offiziellen Vergleich von Dateischutzsystemen.](http://snapraid.sourceforge.net/compare.html)

**F**: Warum eine GUI, die Kommandozeile funktioniert doch!<br/>
**A**: Das übergeordnete Ziel ist es, eine funktionsreiche GUI mit zusätzlichen Verwaltungsfunktionen zu schaffen, die dem Benutzer helfen, eine funktionierende SnapRAID-Umgebung zu pflegen. Manchmal sind ‚Point-and-Click‘-Lösungen für Anfänger einfacher zu bedienen. Die technische Dokumentation und die hohe Konfigurierbarkeit von SnapRAID können abschreckend wirken für diejenigen, die es ausprobieren möchten!

**F**: Ich bin immer noch unsicher, gibt es mehr?<br/>
**A**: Ja, schauen Sie sich die [Dokumentation](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) für Bilder etc. an.

**F**: Was sind also die „größeren Ziele“?<br/>
**A**: Siehe die __Roadmap__ unten für eine vollständige Übersicht.

## Roadmap

- [x] Phase I
  - [x] Versuch, den Mindest-Support der neuesten SnapRAID-Version zu gewährleisten. - __Laufend.__
  - [x] Benutzerfreundlichkeit
  - [x] SnapRAID hat drei Befehle, machen wir sie für Anfänger einfach zugänglich
  - [x] Fortschrittsanzeige(n)
  - [x] Logging "Interaktiv" und direkt ins Log
  - [x] Automatischer Start beim Benutzerlogin
  - [x] Tool-Tipps zur Orientierung •	

- [x] Phase II Phase II Funktionswünsche
  - [x] Pause, Priorität ändern, Abbrechen.
  - [x] Befehls-Erweiterung – „Erlaube zusätzliche Parameter zu den verwendeten Standardwerten.“
  - [x] Zeitplanung 
    - Entfernt, verwende die Befehlszeile
  - [x] Grafische Ansicht(en) der gesicherten Daten.

- [ ] Phase III (Neustart ab 2017-03)
  - [x] Neuer Compiler und .Net 4.7.x	
  - [x] Befehlszeilenschnittstelle
  - [ ] Neues Layout über Krypton Toolkit / Navigator / usw. 
    - In Bearbeitung
  - [ ] Übersetzungen 
  - [x] Neue Befehle
  - [ ] Mailer mit Statusberichten
  - [ ] Dokumentiere Testschritte
    - In Bearbeitung
  - [ ] Zur Dokumentation hinzufügen / Bilder aktualisieren
    - In Bearbeitung
  - [ ] Berichterstattung von Fehlern in das _Windows EventLog_ hinzufügen
  - [x] _ExceptionLess_ für Online-Meldung von Ausnahmen hinzufügen
  - [x] Anzeigen, was wiederhergestellt werden konnte. 

- [ ] Phase IV (neue SnapRAID-Befehle?) 
  - [ ] Erweiterte Hilfe mit Laufwerkswiederherstellung – interaktive Anleitungen usw.
  - [ ] Den Benutzer informieren, wenn seine SnapRAID-Version veraltet ist
  - [ ] Die SnapRAID-Protokolle interpretieren (wird von den folgenden Änderungen genutzt)
  - [ ] Den Status des Arrays nach Ausführung eines Befehls bereitstellen
  - [ ] Den Sync-Befehl ändern, um ein initiales Diff einzuschließen
  - [ ] Den Sync-Befehl ändern, um eine Warnung auszugeben, wenn das Diff Probleme über einem Schwellenwert gemeldet hat
  - [ ] Benutzerkonfigurierbare Einstellungen für Sync-Schwellenwerte hinzufügen


## Screenshots

![Startansicht](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Einstellungsformular](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Können Sie helfen?
- Tester gesucht (Alle .Net-Plattformen)
- Kann bei der Übersetzung helfen
- Hilfe- / Benutzeroberflächenanleitungen
- Alle weiteren Ideen :-)
- Entwickler für die Ideen


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---