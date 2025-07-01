# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Installation

```
yarn install
```

### Ausführung

```
yarn run serve
```

### Beschreibung

```
Gantt-Diagramm basierend auf Vue-Entwicklung, geeignet für Teams, Aufgabenaufteilung und andere agile Szenarien

Unterstützt Gruppierung
Unterstützt Drag & Drop
Unterstützt Strecken
Unterstützt Prozentanzeige
Unterstützt Zeitspannen: Tag, Woche, Monat
Aktuell ist nur eine Gruppierungsebene implementiert. Um zukünftigen Anforderungen an zwei- oder mehrstufige Gruppierungen gerecht zu werden, wurde beim letzten Commit ein Teil des Codes refaktoriert, um Mehrstufigkeit zu unterstützen. In der aktuellen Version ist diese Funktion aber noch nicht entwickelt.

Vorteile: Beim Drag & Drop, Strecken oder Fortschrittsänderungen werden die Daten nicht in Echtzeit aktualisiert, sondern erst nach Abschluss der Aktion, um die Performance zu optimieren.
          Beim Bearbeiten, Löschen oder Hinzufügen wird keine komplette rekursive Instanzänderung durchgeführt, sondern nur der geänderte Teil angepasst.

Das Projekt wird aktuell für die Komponentenentwicklung neu strukturiert. Zur Nutzung im eigenen Projekt genügt es, die Datei `gant.vue` einzubinden.
Methoden für den Massenimport und -export von Daten sind bereits vorhanden und können einfach kopiert werden!~

```

### Update-Hinweise

- Unterstützung für Bearbeiten
- Unterstützung für Löschen
- Bugfix: vertikales Scrollen nicht möglich (gleichzeitig bidirektionales Scrollen hinzugefügt) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Bugfix durch elementUI verursacht
- Problem mit Zeitspanne [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Es ist derzeit nicht möglich, durch Änderung der Spannen-Konfiguration weitere Zeitspannen wie Stunden hinzuzufügen, da einige Einstellungen beim Initialisieren fest sind. Dies wird in Zukunft als API bereitgestellt.

### Beispiel ansehen

Siehe [Demo](https://ggbeng1.github.io/Gantt/#/)

### Schaubild

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---