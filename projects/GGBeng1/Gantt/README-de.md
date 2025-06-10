# Gantt

## Installation

```
yarn install
```

### Ausführen

```
yarn run serve
```

### Beschreibung

```
Ein auf Vue entwickeltes Gantt-Diagramm, das für Teamzusammenarbeit, Aufgabenaufteilung und andere agile Szenarien verwendet werden kann.

Unterstützt Gruppierung
Unterstützt Drag & Drop
Unterstützt Strecken
Unterstützt Prozentanzeige
Unterstützt Zeitspannen: Tag, Woche, Monat
Derzeit ist nur eine Gruppierungsstufe implementiert. Um zukünftigen Anforderungen an zwei- oder mehrstufige Gruppierungen gerecht zu werden, wurde ein Teil des Codes beim letzten Commit refaktoriert, um Mehrstufigkeit zu unterstützen, aber diese Version implementiert das Feature noch nicht.

Vorteile: Beim Drag & Drop, Strecken oder Fortschrittsänderungen werden die Daten nicht in Echtzeit aktualisiert, sondern erst nach Abschluss der Aktion – dies reduziert die Performancebelastung.
            Beim Bearbeiten, Löschen und Hinzufügen werden nicht alle Instanzen rekursiv geändert, sondern nur die jeweils betroffenen Teile.

Eine Neuorganisation zur Komponentenentwicklung ist in Vorbereitung. Aktuell genügt es, die Datei `gant.vue` aus diesem Projekt zu importieren, um sie zu nutzen.
Methoden für den Massenimport und -export von Daten sind bereits implementiert und können direkt kopiert werden!~
```

### Update-Hinweise

- Bearbeiten unterstützt
- Löschen unterstützt
- Bugfix: Vertikales Scrollen war nicht möglich (gleichzeitig bidirektionales Scrollen hinzugefügt) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Bugfix: Fehler durch elementUI behoben
- Zum Thema Zeitspanne [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Es ist derzeit nicht möglich, andere Zeitspannen wie Stunden durch Konfigurationsänderungen zu realisieren, da beim Initialisieren einige Einstellungen festgelegt werden. Dies wird in Zukunft als API bereitgestellt.

### Beispiel ansehen

Siehe [Demo](https://ggbeng1.github.io/Gantt/#/)

### Beispielbild

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---