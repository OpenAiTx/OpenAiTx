# AI Novel Editor

AI-wspomagany edytor powieści oparty na PyQt6, oferujący inteligentne uzupełnianie, zarządzanie projektami, organizację koncepcji oraz inne profesjonalne narzędzia do pisania.

## Instalacja

1. Sklonuj projekt
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Utwórz środowisko wirtualne
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Zainstaluj zależności
```bash
pip install -r requirements.txt
```
4. Uruchomienie programu
```bash
python src/main.py
```

## Główne funkcje

### Zarządzanie projektami
- Hierarchiczna struktura dokumentów (Dzieło > Rozdział > Scena)
- Import i eksport projektów (obsługa formatów TEXT, MARKDOWN, DOCX, PDF, HTML)
- Automatyczna kopia zapasowa i kontrola wersji
- Zarządzanie wieloma projektami

### Funkcja AI do uzupełniania
- Trzy tryby uzupełniania: automatyczne uzupełnianie, ręczne uzupełnianie (zalecane: naciśnij tab raz, aby wywołać, ponownie tab, aby zastosować uzupełnienie), wyłączone uzupełnianie
- Trzy tryby kontekstu:
  - Tryb szybki: lekki kontekst, szybka reakcja
  - Tryb zrównoważony: średni kontekst, równowaga jakości i prędkości
  - Tryb globalny: pełny kontekst projektu, najlepszy efekt
- Obsługa wielu usług AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq i inne
### Zarządzanie konspektem
- Wizualna struktura drzewa konspektu
- Przeciąganie do sortowania i zmiany poziomu
- Szybka nawigacja po dokumencie
- Analiza konspektu i sugestie optymalizacji

### Konfiguracja API
- Ujednolicone centrum konfiguracji AI
- Wstępnie ustawione konfiguracje wielu dostawców
- Funkcja testowania połączenia
- Zapisywanie, import i eksport konfiguracji

### Ustawienia inteligentnego autouzupełniania
- Regulowane opóźnienie wyzwalania
- Ograniczenie długości uzupełniania
- Konfiguracja długości kontekstu
- Obsługa odpowiedzi strumieniowych

### Edycja promptów
- Wbudowane różne szablony pisania
- Niestandardowe szablony promptów
- Zarządzanie kategoriami szablonów
- Konfiguracja szablonów specyficznych dla trybu
### Funkcje interfejsu
- Jasny i ciemny motyw
- Trójkolumnowy układ (drzewo projektu, edytor, panel koncepcji)
- Składany pasek boczny
- Tryb pełnoekranowego pisania
- Tryb skupienia (zdanie, akapit, maszyna do pisania, tryb zen, tryb immersyjny)

### Wyszukiwanie i zamiana
- Wyszukiwanie tekstu w całym projekcie
- Obsługa wyrażeń regularnych
- Funkcja zamiany zbiorczej
- Zaawansowane opcje wyszukiwania

### Zarządzanie koncepcjami
- Automatyczne wykrywanie postaci, miejsc, przedmiotów
- Zarządzanie relacjami między koncepcjami
- System tagów i kategorii
- Szybkie wstawianie koncepcji

## Skróty klawiszowe
- `Ctrl+N`: Nowy projekt
- `Ctrl+O`: Otwórz projekt
- `Ctrl+S`: Zapisz dokument
- `F11`: Tryb pełnoekranowy
- `Tab`: Ręczne wywołanie autouzupełniania AI (w trybie ręcznym)
- `Ctrl+F`: Szukaj
- `Ctrl+H`: Znajdź i zamień
- `Ctrl+Shift+H`: Zaawansowane znajdowanie i zamienianie


## Wymagania systemowe

- Python 3.8+
- PyQt6
- System operacyjny: Windows, macOS, Linux

## Autor

**inliver**
- E-mail: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---