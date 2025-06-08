# Memvid - Memoria AI Basata su Video 🧠📹

**La soluzione leggera e rivoluzionaria per la memoria AI su larga scala**

[![Versione PyPI](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![Licenza: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Stile del codice: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid rivoluziona la gestione della memoria AI codificando i dati testuali in video, permettendo una **ricerca semantica ultra-rapida** attraverso milioni di porzioni di testo con **tempi di recupero inferiori al secondo**. A differenza dei tradizionali database vettoriali che consumano enormi quantità di RAM e spazio di archiviazione, Memvid comprime la tua base di conoscenza in file video compatti mantenendo l’accesso istantaneo a qualsiasi informazione.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Caratteristiche Principali

- 🎥 **Video-come-Database**: Archivia milioni di porzioni di testo in un singolo file MP4
- 🔍 **Ricerca Semantica**: Trova contenuti rilevanti usando query in linguaggio naturale
- 💬 **Chat Integrata**: Interfaccia conversazionale con risposte contestuali
- 📚 **Supporto PDF**: Importazione e indicizzazione diretta di documenti PDF
- 🚀 **Recupero Veloce**: Ricerca sotto il secondo su dataset enormi
- 💾 **Archiviazione Efficiente**: Compressione 10x rispetto ai database tradizionali
- 🔌 **LLM Plug-and-Play**: Funziona con OpenAI, Anthropic o modelli locali
- 🌐 **Offline-First**: Nessuna connessione necessaria dopo la generazione del video
- 🔧 **API Semplice**: Inizia con solo 3 righe di codice

## 🎯 Casi d’Uso

- **📖 Biblioteche Digitali**: Indicizza migliaia di libri in un singolo file video
- **🎓 Contenuti Educativi**: Crea ricordi video ricercabili di materiali didattici
- **📰 Archivi di Notizie**: Comprimi anni di articoli in database video gestibili
- **💼 Conoscenza Aziendale**: Crea basi di conoscenza aziendali ricercabili
- **🔬 Articoli Scientifici**: Ricerca semantica rapida nella letteratura scientifica
- **📝 Note Personali**: Trasforma le tue note in un assistente AI ricercabile

## 🚀 Perché Memvid?

### Innovazione Rivoluzionaria
- **Video come Database**: Archivia milioni di porzioni di testo in un singolo file MP4
- **Recupero Istantaneo**: Ricerca semantica sub-secondo su dataset enormi
- **Efficienza di Archiviazione 10x**: La compressione video riduce drasticamente l’uso di memoria
- **Zero Infrastruttura**: Nessun server database, solo file che puoi copiare ovunque
- **Offline-First**: Funziona completamente offline una volta generati i video

### Architettura Leggera
- **Dipendenze Minime**: Funzionalità core in ~1000 righe di Python
- **Adatto alla CPU**: Funziona in modo efficiente senza bisogno di GPU
- **Portabile**: Un solo file video contiene tutta la tua base di conoscenza
- **Streamabile**: I video possono essere trasmessi da storage cloud

## 📦 Installazione

### Installazione Rapida
```bash
pip install memvid
```

### Per il Supporto PDF
```bash
pip install memvid PyPDF2
```

### Setup Consigliato (Ambiente Virtuale)
```bash
# Crea una nuova cartella di progetto
mkdir my-memvid-project
cd my-memvid-project

# Crea un ambiente virtuale
python -m venv venv

# Attivalo
# Su macOS/Linux:
source venv/bin/activate
# Su Windows:
venv\Scripts\activate

# Installa memvid
pip install memvid

# Per il supporto PDF:
pip install PyPDF2
```

## 🎯 Guida Rapida

### Utilizzo Base
```python
from memvid import MemvidEncoder, MemvidChat

# Crea la memoria video da porzioni di testo
chunks = ["Fatto importante 1", "Fatto importante 2", "Dettagli di un evento storico"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Chatta con la tua memoria
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Cosa sai sugli eventi storici?")
print(response)
```

### Creazione della Memoria da Documenti
```python
from memvid import MemvidEncoder
import os

# Carica i documenti
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Aggiungi file di testo
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Costruisci il video ottimizzato
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # FPS più alto = più porzioni al secondo
    frame_size=512  # Frame più grandi = più dati per frame
)
```

### Ricerca & Recupero Avanzati
```python
from memvid import MemvidRetriever

# Inizializza il retriever
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Ricerca semantica
results = retriever.search("algoritmi di machine learning", top_k=5)
for chunk, score in results:
    print(f"Punteggio: {score:.3f} | {chunk[:100]}...")

# Ottieni la finestra contestuale
context = retriever.get_context("spiega le reti neurali", max_tokens=2000)
print(context)
```

### Interfaccia Chat Interattiva
```python
from memvid import MemvidInteractive

# Avvia l’interfaccia chat UI
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Apre l’interfaccia web su http://localhost:7860
```

### Test con file_chat.py
Lo script `examples/file_chat.py` offre un modo completo per testare Memvid con i tuoi documenti:

```bash
# Elabora una cartella di documenti
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Elabora file specifici
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Usa la compressione H.265 (richiede Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Chunking personalizzato per documenti grandi
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Carica una memoria esistente
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Esempio Completo: Chat con un Libro PDF
```bash
# 1. Crea una nuova cartella e imposta l’ambiente
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Su Windows: venv\Scripts\activate

# 2. Installa le dipendenze
pip install memvid PyPDF2

# 3. Crea book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Il tuo file PDF
book_pdf = "book.pdf"  # Sostituisci con il percorso del tuo PDF

# Crea la memoria video
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Chatta con il libro
api_key = os.getenv("OPENAI_API_KEY")  # Opzionale: per risposte AI
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Eseguilo
export OPENAI_API_KEY="your-api-key"  # Facoltativo
python book_chat.py
```

## 🛠️ Configurazione Avanzata

### Embedding Personalizzati
```python
from sentence_transformers import SentenceTransformer

# Usa un modello di embedding personalizzato
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Ottimizzazione Video
```python
# Per la massima compressione
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Più fotogrammi al secondo
    frame_size=256,  # Fotogrammi più piccoli
    video_codec='h265',  # Migliore compressione
    crf=28  # Qualità compressione (più basso = migliore qualità)
)
```

### Elaborazione Distribuita
```python
# Elabora grandi dataset in parallelo
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Risoluzione dei Problemi

### Problemi Comuni

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Assicurati di usare il giusto Python
which python  # Dovrebbe mostrare il percorso del tuo ambiente virtuale
# In caso contrario, attiva il tuo ambiente virtuale:
source venv/bin/activate  # Su Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 è necessario per il supporto PDF**
```bash
pip install PyPDF2
```

**Problemi con la chiave API LLM**
```bash
# Imposta la tua chiave API (ottienila su https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Oppure su Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Elaborazione PDF di grandi dimensioni**
```python
# Per PDF molto grandi, usa dimensioni di chunk più piccole
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Contribuire

Accogliamo volentieri contributi! Consulta la nostra [Guida per Contribuire](CONTRIBUTING.md) per i dettagli.

```bash
# Esegui i test
pytest tests/

# Esegui con copertura
pytest --cov=memvid tests/

# Format del codice
black memvid/
```

## 🆚 Confronto con Soluzioni Tradizionali

| Funzionalità        | Memvid | Vector DBs | DB Tradizionali |
|---------------------|--------|------------|-----------------|
| Efficienza di Storage | ⭐⭐⭐⭐⭐ | ⭐⭐   | ⭐⭐⭐ |
| Complessità di Setup  | Semplice | Complesso | Complesso |
| Ricerca Semantica     | ✅      | ✅        | ❌    |
| Uso Offline           | ✅      | ❌        | ✅    |
| Portabilità           | Basato su file | Basato su server | Basato su server |
| Scalabilità           | Milioni | Milioni | Miliardi |
| Costo                 | Gratis | $$$$    | $$$ |

## 📚 Esempi

Consulta la directory [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) per:
- Costruire una memoria da dump di Wikipedia
- Creare una knowledge base personale
- Supporto multilingue
- Aggiornamenti di memoria in tempo reale
- Integrazione con LLM popolari

## 🆘 Supporto

- 📖 [Documentazione](https://github.com/olow304/memvid/wiki) - Guide complete
- 💬 [Discussioni](https://github.com/olow304/memvid/discussions) - Fai domande
- 🐛 [Issue Tracker](https://github.com/olow304/memvid/issues) - Segnala bug
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Condividi i tuoi progetti

## 🔗 Link

- [Repository GitHub](https://github.com/olow304/memvid)
- [Pacchetto PyPI](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)

## 📄 Licenza

Licenza MIT - vedi il file [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) per i dettagli.

## 🙏 Ringraziamenti

Creato da [Olow304](https://github.com/olow304) e dalla community di Memvid.

Realizzato con ❤️ utilizzando:
- [sentence-transformers](https://www.sbert.net/) - Embedding all’avanguardia per la ricerca semantica
- [OpenCV](https://opencv.org/) - Visione artificiale ed elaborazione video
- [qrcode](https://github.com/lincolnloop/python-qrcode) - Generazione di codici QR
- [FAISS](https://github.com/facebookresearch/faiss) - Ricerca per similarità efficiente
- [PyPDF2](https://github.com/py-pdf/pypdf) - Estrazione testo da PDF

Un ringraziamento speciale a tutti i contributori che aiutano a migliorare Memvid!

---

**Pronto a rivoluzionare la gestione della memoria AI? Installa Memvid e inizia a costruire!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---