# Memvid - Video-basierte KI-Erinnerung 🧠📹

**Die leichte, bahnbrechende Lösung für KI-Erinnerungen im großen Maßstab**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid revolutioniert das KI-Gedächtnis-Management, indem es Textdaten in Videos kodiert. So wird eine **blitzschnelle semantische Suche** über Millionen von Textausschnitten mit **Abrufzeiten unter einer Sekunde** ermöglicht. Anders als traditionelle Vektor-Datenbanken, die enorme Mengen an RAM und Speicher benötigen, komprimiert Memvid Ihre Wissensbasis in kompakte Videodateien und ermöglicht dennoch den sofortigen Zugriff auf jede Information.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Hauptfunktionen

- 🎥 **Video-als-Datenbank**: Speichern Sie Millionen von Textausschnitten in einer einzigen MP4-Datei
- 🔍 **Semantische Suche**: Finden Sie relevante Inhalte mit natürlichen Sprachabfragen
- 💬 **Integrierter Chat**: Konversationsschnittstelle mit kontextbezogenen Antworten
- 📚 **PDF-Unterstützung**: Direkter Import und Indexierung von PDF-Dokumenten
- 🚀 **Schneller Abruf**: Suchzeiten unter einer Sekunde bei riesigen Datenmengen
- 💾 **Effiziente Speicherung**: 10-fache Komprimierung im Vergleich zu herkömmlichen Datenbanken
- 🔌 **Pluggable LLMs**: Funktioniert mit OpenAI, Anthropic oder lokalen Modellen
- 🌐 **Offline-First**: Nach der Videoerstellung kein Internet erforderlich
- 🔧 **Einfache API**: Starten Sie mit nur 3 Codezeilen

## 🎯 Anwendungsfälle

- **📖 Digitale Bibliotheken**: Indizieren Sie Tausende von Büchern in einer einzigen Videodatei
- **🎓 Lerninhalte**: Erstellen Sie durchsuchbare Videomemories von Kursmaterialien
- **📰 Nachrichtenarchive**: Komprimieren Sie jahrelange Artikel in handhabbare Videodatenbanken
- **💼 Unternehmenswissen**: Bauen Sie unternehmensweite, durchsuchbare Wissensbasen auf
- **🔬 Wissenschaftliche Arbeiten**: Schnelle semantische Suche in wissenschaftlicher Literatur
- **📝 Persönliche Notizen**: Verwandeln Sie Ihre Notizen in einen durchsuchbaren KI-Assistenten

## 🚀 Warum Memvid?

### Bahnbrechende Innovation
- **Video als Datenbank**: Speichern Sie Millionen von Textausschnitten in einer einzigen MP4-Datei
- **Sofortiger Abruf**: Semantische Suche unter einer Sekunde in riesigen Datensätzen
- **10x Speicher-Effizienz**: Videokomprimierung reduziert den Speicherbedarf drastisch
- **Null Infrastruktur**: Keine Datenbankserver, nur Dateien, die Sie überallhin kopieren können
- **Offline-First**: Funktioniert komplett offline, sobald die Videos erstellt wurden

### Leichtgewichtige Architektur
- **Minimale Abhängigkeiten**: Kernfunktionalität in ca. 1000 Zeilen Python
- **CPU-freundlich**: Läuft effizient ohne GPU-Anforderungen
- **Portabel**: Eine einzige Videodatei enthält Ihre gesamte Wissensbasis
- **Streambar**: Videos können aus Cloud-Speichern gestreamt werden

## 📦 Installation

### Schnellinstallation
```bash
pip install memvid
```

### Für PDF-Unterstützung
```bash
pip install memvid PyPDF2
```

### Empfohlene Einrichtung (Virtuelle Umgebung)
```bash
# Neues Projektverzeichnis erstellen
mkdir my-memvid-project
cd my-memvid-project

# Virtuelle Umgebung erstellen
python -m venv venv

# Aktivieren
# Auf macOS/Linux:
source venv/bin/activate
# Auf Windows:
venv\Scripts\activate

# Memvid installieren
pip install memvid

# Für PDF-Unterstützung:
pip install PyPDF2
```

## 🎯 Schnellstart

### Grundlegende Nutzung
```python
from memvid import MemvidEncoder, MemvidChat

# Videogedächtnis aus Textausschnitten erstellen
chunks = ["Wichtige Tatsache 1", "Wichtige Tatsache 2", "Details zu historischen Ereignissen"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Mit Ihrem Gedächtnis chatten
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Was weißt du über historische Ereignisse?")
print(response)
```

### Gedächtnis aus Dokumenten aufbauen
```python
from memvid import MemvidEncoder
import os

# Dokumente laden
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Textdateien hinzufügen
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Optimiertes Video erstellen
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Höhere FPS = mehr Chunks pro Sekunde
    frame_size=512  # Größere Frames = mehr Daten pro Frame
)
```

### Erweiterte Suche & Abruf
```python
from memvid import MemvidRetriever

# Retriever initialisieren
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Semantische Suche
results = retriever.search("machine learning algorithms", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# Kontextfenster erhalten
context = retriever.get_context("explain neural networks", max_tokens=2000)
print(context)
```

### Interaktive Chat-Oberfläche
```python
from memvid import MemvidInteractive

# Interaktive Chat-UI starten
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Öffnet Weboberfläche unter http://localhost:7860
```

### Testen mit file_chat.py
Das Skript `examples/file_chat.py` bietet eine umfassende Möglichkeit, Memvid mit eigenen Dokumenten zu testen:

```bash
# Ein Verzeichnis mit Dokumenten verarbeiten
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Bestimmte Dateien verarbeiten
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# H.265-Komprimierung verwenden (erfordert Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Benutzerdefiniertes Chunking für große Dokumente
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Bestehendes Gedächtnis laden
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Komplettes Beispiel: Chat mit einem PDF-Buch
```bash
# 1. Neues Verzeichnis erstellen und Umgebung einrichten
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Unter Windows: venv\Scripts\activate

# 2. Abhängigkeiten installieren
pip install memvid PyPDF2

# 3. book_chat.py erstellen
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Ihre PDF-Datei
book_pdf = "book.pdf"  # Ersetzen Sie dies durch den Pfad zu Ihrem PDF

# Videogedächtnis aufbauen
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Mit dem Buch chatten
api_key = os.getenv("OPENAI_API_KEY")  # Optional: für KI-Antworten
```markdown
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Ausführen
export OPENAI_API_KEY="dein-api-key"  # Optional
python book_chat.py
```

## 🛠️ Erweiterte Konfiguration

### Eigene Embeddings
```python
from sentence_transformers import SentenceTransformer

# Eigenes Embedding-Modell verwenden
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Video-Optimierung
```python
# Für maximale Kompression
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Mehr Bilder pro Sekunde
    frame_size=256,  # Kleinere Bilder
    video_codec='h265',  # Bessere Kompression
    crf=28  # Kompressionsqualität (je niedriger, desto bessere Qualität)
)
```

### Verteilte Verarbeitung
```python
# Große Datensätze parallel verarbeiten
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Fehlerbehebung

### Häufige Probleme

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Stelle sicher, dass du das richtige Python verwendest
which python  # Sollte den Pfad deiner virtuellen Umgebung anzeigen
# Falls nicht, aktiviere deine virtuelle Umgebung:
source venv/bin/activate  # Unter Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 ist erforderlich für PDF-Unterstützung**
```bash
pip install PyPDF2
```

**LLM API-Schlüssel-Probleme**
```bash
# Setze deinen API-Schlüssel (bekomme einen unter https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Oder unter Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Verarbeitung großer PDFs**
```python
# Für sehr große PDFs kleinere Chunk-Größen verwenden
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Beitrag leisten

Beiträge sind willkommen! Weitere Details findest du in unserem [Beitragsleitfaden](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md).

```bash
# Tests ausführen
pytest tests/

# Mit Coverage ausführen
pytest --cov=memvid tests/

# Code formatieren
black memvid/
```

## 🆚 Vergleich mit traditionellen Lösungen

| Funktion | Memvid | Vektor-DBs | Traditionelle DBs |
|----------|--------|------------|-------------------|
| Speichereffizienz | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| Setup-Komplexität | Einfach | Komplex | Komplex |
| Semantische Suche | ✅ | ✅ | ❌ |
| Offline-Nutzung | ✅ | ❌ | ✅ |
| Portabilität | Dateibasiert | Serverbasiert | Serverbasiert |
| Skalierbarkeit | Millionen | Millionen | Milliarden |
| Kosten | Kostenlos | $$$$ | $$$ |


## 📚 Beispiele

Siehe das Verzeichnis [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) für:
- Aufbau von Speicher aus Wikipedia-Dumps
- Erstellung einer persönlichen Wissensdatenbank
- Mehrsprachige Unterstützung
- Echtzeit-Updates des Speichers
- Integration mit beliebten LLMs

## 🆘 Hilfe erhalten

- 📖 [Dokumentation](https://github.com/olow304/memvid/wiki) - Umfassende Anleitungen
- 💬 [Diskussionen](https://github.com/olow304/memvid/discussions) - Fragen stellen
- 🐛 [Issue Tracker](https://github.com/olow304/memvid/issues) - Fehler melden
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Teile deine Projekte

## 🔗 Links

- [GitHub Repository](https://github.com/olow304/memvid)
- [PyPI-Paket](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 Lizenz

MIT-Lizenz – siehe [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) Datei für Details.

## 🙏 Danksagung

Erstellt von [Olow304](https://github.com/olow304) und der Memvid-Community.

Erstellt mit ❤️ unter Verwendung von:
- [sentence-transformers](https://www.sbert.net/) – Modernste Embeddings für semantische Suche
- [OpenCV](https://opencv.org/) – Computer Vision und Videobearbeitung
- [qrcode](https://github.com/lincolnloop/python-qrcode) – QR-Code-Generierung
- [FAISS](https://github.com/facebookresearch/faiss) – Effiziente Ähnlichkeitssuche
- [PyPDF2](https://github.com/py-pdf/pypdf) – PDF-Text-Extraktion

Besonderer Dank an alle Mitwirkenden, die Memvid besser machen!

---

**Bereit, dein KI-Speichermanagement zu revolutionieren? Installiere Memvid und lege los!** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---