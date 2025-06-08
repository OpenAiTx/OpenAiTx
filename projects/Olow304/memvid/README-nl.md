# Memvid - Video-Based AI Memory 🧠📹

**De lichtgewicht, baanbrekende oplossing voor AI-geheugen op schaal**

[![PyPI versie](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![Licentie: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid revolutioneert AI-geheugenbeheer door tekstgegevens te coderen in video's, waardoor **bliksemsnelle semantische zoekopdrachten** mogelijk zijn over miljoenen tekstfragmenten met **ophaal­tijden van minder dan een seconde**. In tegenstelling tot traditionele vectordatabases die enorme hoeveelheden RAM en opslag verbruiken, comprimeert Memvid je kennisbank in compacte videobestanden terwijl directe toegang tot elk stukje informatie behouden blijft.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Belangrijkste Functies

- 🎥 **Video-als-Database**: Sla miljoenen tekstfragmenten op in één MP4-bestand
- 🔍 **Semantische Zoekopdracht**: Vind relevante inhoud met natuurlijke taalqueries
- 💬 **Ingebouwde Chat**: Conversationele interface met contextbewuste antwoorden
- 📚 **PDF-ondersteuning**: Direct importeren en indexeren van PDF-documenten
- 🚀 **Snelle Ophaling**: Zoek in minder dan een seconde in enorme datasets
- 💾 **Efficiënte Opslag**: 10x compressie in vergelijking met traditionele databases
- 🔌 **Koppelbare LLM's**: Werkt met OpenAI, Anthropic of lokale modellen
- 🌐 **Offline-First**: Geen internet nodig na videogenereatie
- 🔧 **Eenvoudige API**: Begin met slechts 3 regels code

## 🎯 Gebruikstoepassingen

- **📖 Digitale Bibliotheken**: Indexeer duizenden boeken in één videobestand
- **🎓 Educatieve Inhoud**: Maak doorzoekbare videogeheugens van cursusmateriaal
- **📰 Nieuwsarchieven**: Comprimeer jaren aan artikelen tot beheersbare videodatabases
- **💼 Bedrijfskennis**: Bouw bedrijfsbrede doorzoekbare kennisbanken
- **🔬 Wetenschappelijke Artikelen**: Snelle semantische zoekopdrachten door wetenschappelijke literatuur
- **📝 Persoonlijke Notities**: Maak van je notities een doorzoekbare AI-assistent

## 🚀 Waarom Memvid?

### Baanbrekende Innovatie
- **Video als Database**: Sla miljoenen tekstfragmenten op in één MP4-bestand
- **Directe Ophaling**: Semantische zoekopdrachten in minder dan een seconde in enorme datasets
- **10x Opslagefficiëntie**: Videocompressie vermindert het geheugengebruik drastisch
- **Geen Infrastructuur Nodig**: Geen databaseservers, alleen bestanden die je overal kunt kopiëren
- **Offline-First**: Werkt volledig offline zodra video's zijn gegenereerd

### Lichtgewicht Architectuur
- **Minimale Afhankelijkheden**: Kernfunctionaliteit in ~1000 regels Python
- **CPU-vriendelijk**: Draait efficiënt zonder GPU-vereisten
- **Draagbaar**: Eén videobestand bevat je volledige kennisbank
- **Streambaar**: Video's kunnen vanuit cloudopslag gestreamd worden

## 📦 Installatie

### Snelle Installatie
```bash
pip install memvid
```

### Voor PDF-ondersteuning
```bash
pip install memvid PyPDF2
```

### Aanbevolen Setup (Virtuele Omgeving)
```bash
# Maak een nieuwe projectdirectory aan
mkdir my-memvid-project
cd my-memvid-project

# Maak een virtuele omgeving aan
python -m venv venv

# Activeer deze
# Op macOS/Linux:
source venv/bin/activate
# Op Windows:
venv\Scripts\activate

# Installeer memvid
pip install memvid

# Voor PDF-ondersteuning:
pip install PyPDF2
```

## 🎯 Snel Starten

### Basisgebruik
```python
from memvid import MemvidEncoder, MemvidChat

# Maak video-geheugen van tekstfragmenten
chunks = ["Belangrijk feit 1", "Belangrijk feit 2", "Details over historisch evenement"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Chat met je geheugen
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Wat weet je over historische gebeurtenissen?")
print(response)
```

### Geheugen Bouwen uit Documenten
```python
from memvid import MemvidEncoder
import os

# Laad documenten
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Voeg tekstbestanden toe
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Bouw geoptimaliseerde video
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Hogere FPS = meer fragmenten per seconde
    frame_size=512  # Grotere frames = meer data per frame
)
```

### Geavanceerd Zoeken & Ophalen
```python
from memvid import MemvidRetriever

# Initialiseer retriever
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Semantische zoekopdracht
results = retriever.search("machine learning algoritmen", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# Haal contextvenster op
context = retriever.get_context("leg neurale netwerken uit", max_tokens=2000)
print(context)
```

### Interactieve Chatinterface
```python
from memvid import MemvidInteractive

# Start interactieve chat UI
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Opent webinterface op http://localhost:7860
```

### Testen met file_chat.py
Het script `examples/file_chat.py` biedt een uitgebreide manier om Memvid te testen met je eigen documenten:

```bash
# Verwerk een map met documenten
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Specifieke bestanden verwerken
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Gebruik H.265-compressie (vereist Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Aangepaste chunking voor grote documenten
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Bestaand geheugen laden
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Compleet Voorbeeld: Chatten met een PDF-boek
```bash
# 1. Maak een nieuwe map aan en stel omgeving in
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Op Windows: venv\Scripts\activate

# 2. Installeer afhankelijkheden
pip install memvid PyPDF2

# 3. Maak book_chat.py aan
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Je PDF-bestand
book_pdf = "book.pdf"  # Vervang door het pad naar jouw PDF

# Bouw video-geheugen
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Chat met het boek
api_key = os.getenv("OPENAI_API_KEY")  # Optioneel: voor AI-antwoorden
```python
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Voer het uit
export OPENAI_API_KEY="your-api-key"  # Optioneel
python book_chat.py
```

## 🛠️ Geavanceerde Configuratie

### Aangepaste Embeddings
```python
from sentence_transformers import SentenceTransformer

# Gebruik aangepast embedding model
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Video Optimalisatie
```python
# Voor maximale compressie
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Meer frames per seconde
    frame_size=256,  # Kleinere frames
    video_codec='h265',  # Betere compressie
    crf=28  # Compressiekwaliteit (lager = betere kwaliteit)
)
```

### Gedistribueerde Verwerking
```python
# Verwerk grote datasets parallel
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Problemen Oplossen

### Veelvoorkomende Problemen

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Zorg dat je de juiste Python gebruikt
which python  # Moet het pad naar je virtuele omgeving tonen
# Zo niet, activeer je virtuele omgeving:
source venv/bin/activate  # Op Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 is vereist voor PDF-ondersteuning**
```bash
pip install PyPDF2
```

**LLM API sleutel Problemen**
```bash
# Stel je API-sleutel in (verkrijgbaar op https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Of op Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Grote PDF Verwerking**
```python
# Voor zeer grote PDF's, gebruik kleinere chunkgroottes
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Bijdragen

Bijdragen zijn welkom! Zie onze [Contributie Gids](CONTRIBUTING.md) voor details.

```bash
# Voer tests uit
pytest tests/

# Voer uit met coverage
pytest --cov=memvid tests/

# Formatteer code
black memvid/
```

## 🆚 Vergelijking met Traditionele Oplossingen

| Functie | Memvid | Vector DB's | Traditionele DB's |
|---------|--------|-------------|-------------------|
| Opslagefficiëntie | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| Installatiecomplexiteit | Eenvoudig | Complex | Complex |
| Semantisch Zoeken | ✅ | ✅ | ❌ |
| Offline Gebruik | ✅ | ❌ | ✅ |
| Draagbaarheid | Bestand-gebaseerd | Server-gebaseerd | Server-gebaseerd |
| Schaalbaarheid | Miljoenen | Miljoenen | Miljarden |
| Kosten | Gratis | $$$$ | $$$ |


## 📚 Voorbeelden

Bekijk de [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) map voor:
- Geheugen bouwen uit Wikipedia dumps
- Een persoonlijke kennisbank maken
- Meertalige ondersteuning
- Real-time geheugenupdates
- Integratie met populaire LLMs

## 🆘 Hulp Nodig

- 📖 [Documentatie](https://github.com/olow304/memvid/wiki) - Uitgebreide handleidingen
- 💬 [Discussies](https://github.com/olow304/memvid/discussions) - Stel vragen
- 🐛 [Issue Tracker](https://github.com/olow304/memvid/issues) - Meld bugs
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Deel je projecten

## 🔗 Links

- [GitHub Repository](https://github.com/olow304/memvid)
- [PyPI Package](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)


## 📄 Licentie

MIT Licentie - zie het [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) bestand voor details.

## 🙏 Dankbetuigingen

Gemaakt door [Olow304](https://github.com/olow304) en de Memvid-community.

Gemaakt met ❤️ met behulp van:
- [sentence-transformers](https://www.sbert.net/) - State-of-the-art embeddings voor semantisch zoeken
- [OpenCV](https://opencv.org/) - Computer vision en videobewerking
- [qrcode](https://github.com/lincolnloop/python-qrcode) - QR code generatie
- [FAISS](https://github.com/facebookresearch/faiss) - Efficiënt zoeken naar gelijkenis
- [PyPDF2](https://github.com/py-pdf/pypdf) - PDF-tekstextractie

Speciale dank aan alle bijdragers die Memvid beter maken!

---

**Klaar om je AI-geheugenbeheer te revolutioneren? Installeer Memvid en begin met bouwen!** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---