# RSS-Master

Anpassung, Filterung und Auswahl von RSS-Quellen mit AI-Zusammenfassung, Überblick und Bewertung. Leistungsoptimierte Version, unterstützt asynchrone Verarbeitung und parallele AI-Zusammenfassung.

### Vorwort

Anfang September begann ich, Inoreader + RSSHub zu verwenden, um für mich interessante RSS-Feeds zu aggregieren und zu abonnieren. In Kombination mit Reeder als Lesewerkzeug versuchte ich, die Informationsquellen meines täglichen Inputs vollständig zu kontrollieren. Nach einem Monat führten die zunehmenden RSS-Quellen und die steigende Anzahl ungelesener Nachrichten zu erheblicher Lesestress. Daher fragte ich mich, ob es eine Möglichkeit gibt, benutzerdefinierte Filterregeln zu erstellen, idealerweise mit AI-Unterstützung, um meine Lesebelastung zu reduzieren.

Inoreader bietet zwar Filterfunktionen, aber nur dafür zu bezahlen erschien mir wenig lohnenswert; NewsBlur verfügt über den „Intelligence Trainer“ für intelligente Klassifikation, aber meine einfachen Tests zeigten kaum spürbare Rückmeldungen, die Intelligenz war kurzfristig nicht erkennbar; Feedly bietet sowohl Filter als auch AI-Funktionen und schien meine Anforderungen gut zu erfüllen. Gerade als ich zögerte, von Inoreader zum kostenpflichtigen Feedly-Nutzer zu wechseln, stieß ich auf diese zwei Projekte:

- [ChatGPT hilft uns, Hacker News zusammenzufassen](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT Benutzerhandbuch](http://yinan.me/rss-gpt-manual-zh.html)

Die Grundidee beider Projekte ist, über GitAction ein Skript auszuführen, das Informationen abruft, sie mit der OpenAI API übersetzt, zusammenfasst und dann in eine Vorlage rendert, die auf GitHub Pages bereitgestellt wird. Die Methode in RSS-GPT entspricht mehr meinen Bedürfnissen: Durch regelmäßiges Ausführen des Skripts wird die RSS-XML-Datei direkt abgerufen, verarbeitet und auf GitHub Pages bereitgestellt, sodass man den Zugriff auf diese XML-Datei erhält und den Reader einfach darauf abonnieren kann.

Da ich eine starke Anforderung an die plattformübergreifende Synchronisation von Inoreader habe und neu hinzugefügte RSS-Quellen in der config-Datei schnell an Inoreader synchronisiert werden sollen, habe ich die Idee von [RSS-GPT](https://github.com/yinan-c/) erweitert und nenne es RSS-Master.

### Funktionsmerkmale

- **Unterstützung paralleler Verarbeitung**: Parallele Verarbeitung von RSS-Quellen und AI-Zusammenfassungen durch asynchrone Programmierung und Thread-Pool, deutlich erhöhte Verarbeitungsgeschwindigkeit
- **Verbessertes Caching-System**: Stabileres Caching zur Vermeidung von Datenverlust und Steigerung der Wiederholungszugriffsleistung
- **Bessere Fehlerbehandlung**: Vollständige Fehlerbehandlung und Protokollierung aller Operationen zur Erhöhung der Stabilität
- **Optimierte HTML-Inhalts-Extraktion**: Intelligente Extraktion von Artikelinhalten, Ignorieren irrelevanter Informationen, Verbesserung der AI-Zusammenfassungsqualität
- **Unterstützung der neuesten OpenAI API**: Vollständige Kompatibilität mit der neuesten OpenAI API-Version
- **Detaillierte Statistik**: Nach Abschluss werden Laufzeit, Erfolgsquote und Kostenstatistiken bereitgestellt
- **Unterstützung für opml-Dateigenerierung**: Und gegenseitige Konvertierung mit config.yml: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **Unterstützung benutzerdefinierter Filterregeln**: Unterstützung der Typen include und exclude, mit den Anwendungsbereichen title und article
- **Anpassbares AI-Modell**: Konfiguration verschiedener OpenAI-Modelle über Umgebungsvariablen
- **Anpassbare Basis-URL**: Konfigurierbare Basis-URL für RSS-Dateizugriffe, erleichtert die Bereitstellung in unterschiedlichen Umgebungen
- **Interaktives Test-Notebook**: Jupyter-Notebook zur Funktionstestung

### Umgebungsvariablen-Konfiguration

Das Projekt unterstützt die Konfiguration folgender Parameter über eine `.env`-Datei:

```
# Erforderliche Parameter
OPENAI_API_KEY=dein_openai_api_schlüssel_hier

# Optionale Parameter
RSS_BASE_URL=https://example.com/rss-feeds/  # Basis-URL für RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAI Modell
LOG_LEVEL=INFO                               # Protokollierungs-Level
PARALLEL_WORKERS=5                           # Anzahl paralleler Prozesse
```

Du kannst die Datei `.env.example` kopieren, in `.env` umbenennen und die Parameter entsprechend anpassen.

### Leistungsverbesserungen

Diese Version bietet im Vergleich zur Originalversion folgende Leistungsverbesserungen:

1. **Parallele Verarbeitung von RSS-Quellen**: Gleichzeitige Verarbeitung mehrerer RSS-Feeds mittels `asyncio`
2. **Parallelisierung der AI-Zusammenfassung**: Verwendung eines Thread-Pools zur parallelen AI-Zusammenfassung mehrerer Artikel
3. **Optimierung der Textverarbeitung**: Verbesserter Algorithmus zur HTML-Inhalts-Extraktion, intelligentere Erfassung der wichtigen Artikelinhalte
4. **Sichere Dateiverarbeitung**: Verwendung sicherer Schreibmechanismen, um Datenverlust bei Programmabstürzen zu vermeiden
5. **Speichernutzung optimiert**: Optimierte Datenstrukturen und Prozessabläufe zur Reduzierung des Speicherverbrauchs

### Gebrauchsanweisung

1. Klone das Projekt lokal
2. Installiere Abhängigkeiten: `pip install -r requirements.txt`
3. Erstelle eine `.env`-Datei und setze den OpenAI API-Schlüssel: `OPENAI_API_KEY=dein_schlüssel`
4. Ändere `resource/config.yml` zur Konfiguration deiner RSS-Feeds
5. Starte die Verarbeitung mit `python main.py`

### Test & Debugging

Das Projekt stellt ein interaktives Test-Notebook `test.ipynb` zur Verfügung, mit dem die Funktionen getestet werden können:

1. Abruf und Analyse von RSS-Feeds
2. Filterfunktionalität
3. AI-Zusammenfassung
4. Caching-Mechanismus
5. Anpassbare Basis-URL
6. Leistungstest

Verwendung:

```bash
# Jupyter installieren
pip install jupyter

# Notebook starten
jupyter notebook test.ipynb
```

### Beispiel für benutzerdefinierte Filterregeln

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          'Cola',
          'Sprite',
          'Fanta',
          'Zitrone',
          'Tee',
          'Papiertaschentücher',
          'Alkohol',
          'Feuchttücher',
          'Servietten',
        ]
```

### Anwendungs-Screenshots

- AI-Zusammenfassung und Überblicksfunktion

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/qiniu.dcts.top/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/qiniu.dcts.top/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Benutzerdefinierte Filterung: Filterung des „什么值得买“ Good Deals-Kanals, empfiehlt nur kürzlich gewünschte Waren wie Limonaden

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/qiniu.dcts.top/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---