# Memvid - Pamięć AI oparta na wideo 🧠📹

**Lekka, przełomowa technologia pamięci AI na dużą skalę**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid rewolucjonizuje zarządzanie pamięcią AI poprzez kodowanie danych tekstowych do postaci wideo, umożliwiając **błyskawiczne wyszukiwanie semantyczne** wśród milionów fragmentów tekstu z **czasem odpowiedzi poniżej sekundy**. W przeciwieństwie do tradycyjnych baz wektorowych, które pochłaniają ogromne ilości RAMu i miejsca na dysku, Memvid kompresuje Twoją bazę wiedzy do kompaktowych plików wideo, zachowując natychmiastowy dostęp do każdej informacji.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Najważniejsze cechy

- 🎥 **Wideo jako baza danych**: Przechowuj miliony fragmentów tekstu w jednym pliku MP4
- 🔍 **Wyszukiwanie semantyczne**: Znajduj istotne treści za pomocą zapytań w języku naturalnym
- 💬 **Wbudowany czat**: Interfejs konwersacyjny z odpowiedziami uwzględniającymi kontekst
- 📚 **Obsługa PDF**: Bezpośredni import i indeksowanie dokumentów PDF
- 🚀 **Szybkie wyszukiwanie**: Przeszukiwanie dużych zbiorów w czasie poniżej sekundy
- 💾 **Wydajna kompresja**: 10x mniejszy rozmiar w porównaniu do tradycyjnych baz danych
- 🔌 **Dowolny LLM**: Współpraca z OpenAI, Anthropic lub lokalnymi modelami
- 🌐 **Offline-First**: Po wygenerowaniu wideo nie wymaga internetu
- 🔧 **Proste API**: Wystarczą 3 linie kodu, by zacząć

## 🎯 Zastosowania

- **📖 Biblioteki cyfrowe**: Indeksuj tysiące książek w jednym pliku wideo
- **🎓 Materiały edukacyjne**: Twórz przeszukiwalne wspomnienia wideo z materiałów kursowych
- **📰 Archiwa prasowe**: Kompresuj lata artykułów do łatwych w obsłudze baz wideo
- **💼 Wiedza korporacyjna**: Buduj firmowe bazy wiedzy z możliwością wyszukiwania
- **🔬 Prace naukowe**: Błyskawiczne wyszukiwanie semantyczne w literaturze naukowej
- **📝 Notatki osobiste**: Zamień swoje notatki w przeszukiwalnego asystenta AI

## 🚀 Dlaczego Memvid?

### Przełomowa innowacja
- **Wideo jako baza danych**: Przechowuj miliony fragmentów tekstu w jednym pliku MP4
- **Natychmiastowy dostęp**: Wyszukiwanie semantyczne w czasie poniżej sekundy w ogromnych zbiorach danych
- **10x wydajniejsza kompresja**: Kompresja wideo znacząco zmniejsza zajętość pamięci
- **Zero infrastruktury**: Brak serwerów baz danych – tylko pliki, które możesz kopiować gdziekolwiek
- **Offline-First**: Działa całkowicie offline po wygenerowaniu plików wideo

### Lekka architektura
- **Minimalne zależności**: Kluczowa funkcjonalność w ~1000 liniach Pythona
- **Przyjazny CPU**: Działa wydajnie bez wymagań GPU
- **Przenośność**: Jeden plik wideo zawiera całą Twoją bazę wiedzy
- **Strumieniowanie**: Pliki wideo mogą być przesyłane z chmury

## 📦 Instalacja

### Szybka instalacja
```bash
pip install memvid
```

### Obsługa PDF
```bash
pip install memvid PyPDF2
```

### Zalecana konfiguracja (środowisko wirtualne)
```bash
# Utwórz nowy katalog projektu
mkdir my-memvid-project
cd my-memvid-project

# Utwórz środowisko wirtualne
python -m venv venv

# Aktywuj je
# Na macOS/Linux:
source venv/bin/activate
# Na Windows:
venv\Scripts\activate

# Instalacja memvid
pip install memvid

# Obsługa PDF:
pip install PyPDF2
```

## 🎯 Szybki start

### Podstawowe użycie
```python
from memvid import MemvidEncoder, MemvidChat

# Utwórz pamięć wideo z fragmentów tekstu
chunks = ["Ważny fakt 1", "Ważny fakt 2", "Szczegóły wydarzenia historycznego"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Rozmowa z pamięcią
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Co wiesz o wydarzeniach historycznych?")
print(response)
```

### Tworzenie pamięci z dokumentów
```python
from memvid import MemvidEncoder
import os

# Wczytaj dokumenty
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Dodaj pliki tekstowe
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Zbuduj zoptymalizowane wideo
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Więcej FPS = więcej fragmentów na sekundę
    frame_size=512  # Większe klatki = więcej danych na klatkę
)
```

### Zaawansowane wyszukiwanie i pobieranie
```python
from memvid import MemvidRetriever

# Inicjalizacja wyszukiwarki
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Wyszukiwanie semantyczne
results = retriever.search("algorytmy uczenia maszynowego", top_k=5)
for chunk, score in results:
    print(f"Wynik: {score:.3f} | {chunk[:100]}...")

# Pobierz okno kontekstu
context = retriever.get_context("wyjaśnij sieci neuronowe", max_tokens=2000)
print(context)
```

### Interaktywny interfejs czatu
```python
from memvid import MemvidInteractive

# Uruchom interaktywny interfejs czatu
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Otwiera interfejs webowy pod adresem http://localhost:7860
```

### Testowanie przy użyciu file_chat.py
Skrypt `examples/file_chat.py` umożliwia kompleksowe testowanie Memvid na własnych dokumentach:

```bash
# Przetwórz katalog dokumentów
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Przetwórz konkretne pliki
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Użyj kompresji H.265 (wymaga Dockera)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Niestandardowy podział dużych dokumentów na fragmenty
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Wczytaj istniejącą pamięć
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Kompletny przykład: rozmowa z książką PDF
```bash
# 1. Utwórz nowy katalog i środowisko
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Na Windows: venv\Scripts\activate

# 2. Instaluj zależności
pip install memvid PyPDF2

# 3. Utwórz book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Twój plik PDF
book_pdf = "book.pdf"  # Podmień na ścieżkę do swojego PDF

# Tworzenie pamięci wideo
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Rozmowa z książką
api_key = os.getenv("OPENAI_API_KEY")  # Opcjonalne: dla odpowiedzi AI
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Uruchom
export OPENAI_API_KEY="twoj-klucz-api"  # Opcjonalnie
python book_chat.py
```

## 🛠️ Zaawansowana konfiguracja

### Własne embeddingi
```python
from sentence_transformers import SentenceTransformer

# Użyj niestandardowego modelu embedding
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Optymalizacja wideo
```python
# Maksymalna kompresja
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Więcej klatek na sekundę
    frame_size=256,  # Mniejsze klatki
    video_codec='h265',  # Lepsza kompresja
    crf=28  # Jakość kompresji (niższa = lepsza jakość)
)
```

### Przetwarzanie rozproszone
```python
# Przetwarzanie dużych zbiorów danych równolegle
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Rozwiązywanie problemów

### Typowe problemy

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Upewnij się, że używasz odpowiedniego Pythona
which python  # Powinno pokazać ścieżkę do twojego środowiska wirtualnego
# Jeśli nie, aktywuj środowisko wirtualne:
source venv/bin/activate  # Na Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 jest wymagany do obsługi PDF**
```bash
pip install PyPDF2
```

**Problemy z kluczem API LLM**
```bash
# Ustaw swój klucz API (zdobądź go na https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Lub na Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Przetwarzanie dużych plików PDF**
```python
# Dla bardzo dużych PDF-ów użyj mniejszych rozmiarów fragmentów
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Współtworzenie

Zapraszamy do współpracy! Szczegóły znajdziesz w naszym [Przewodniku dla Współtwórców](CONTRIBUTING.md).

```bash
# Uruchom testy
pytest tests/

# Uruchom z pokryciem
pytest --cov=memvid tests/

# Formatuj kod
black memvid/
```

## 🆚 Porównanie z tradycyjnymi rozwiązaniami

| Funkcja              | Memvid | Bazy wektorowe | Tradycyjne bazy danych |
|----------------------|--------|---------------|-----------------------|
| Wydajność przechowywania   | ⭐⭐⭐⭐⭐ | ⭐⭐  | ⭐⭐⭐ |
| Złożoność konfiguracji      | Prosta | Złożona | Złożona |
| Wyszukiwanie semantyczne    | ✅      | ✅     | ❌    |
| Użycie offline              | ✅      | ❌     | ✅    |
| Przenośność                 | Plikowa | Serwerowa | Serwerowa |
| Skalowalność                | Miliony | Miliony | Miliardy |
| Koszt                       | Darmowe | $$$$   | $$$   |

## 📚 Przykłady

Sprawdź katalog [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) gdzie znajdziesz:
- Budowanie pamięci z dumpów Wikipedii
- Tworzenie osobistej bazy wiedzy
- Wsparcie dla wielu języków
- Aktualizacje pamięci w czasie rzeczywistym
- Integrację z popularnymi LLM

## 🆘 Pomoc

- 📖 [Dokumentacja](https://github.com/olow304/memvid/wiki) - Kompleksowe przewodniki
- 💬 [Dyskusje](https://github.com/olow304/memvid/discussions) - Zadawaj pytania
- 🐛 [Zgłaszanie błędów](https://github.com/olow304/memvid/issues) - Zgłaszaj błędy
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Podziel się swoimi projektami

## 🔗 Linki

- [Repozytorium GitHub](https://github.com/olow304/memvid)
- [Pakiet PyPI](https://pypi.org/project/memvid)
- [Lista zmian](https://github.com/olow304/memvid/releases)

## 📄 Licencja

Licencja MIT - szczegóły w pliku [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE).

## 🙏 Podziękowania

Stworzone przez [Olow304](https://github.com/olow304) oraz społeczność Memvid.

Zbudowane z ❤️ dzięki:
- [sentence-transformers](https://www.sbert.net/) - Najnowocześniejsze embeddingi do wyszukiwania semantycznego
- [OpenCV](https://opencv.org/) - Wizja komputerowa i przetwarzanie wideo
- [qrcode](https://github.com/lincolnloop/python-qrcode) - Generowanie kodów QR
- [FAISS](https://github.com/facebookresearch/faiss) - Wydajne wyszukiwanie podobieństwa
- [PyPDF2](https://github.com/py-pdf/pypdf) - Ekstrakcja tekstu z PDF

Szczególne podziękowania dla wszystkich współtwórców, którzy pomagają rozwijać Memvid!

---

**Gotowy, by zrewolucjonizować zarządzanie pamięcią AI? Zainstaluj Memvid i zacznij budować!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---