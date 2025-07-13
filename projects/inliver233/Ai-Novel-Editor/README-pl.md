<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>
# AI Novel Editor

Edytor powieści wspomagany przez AI oparty na PyQt6, oferujący inteligentne uzupełnianie, zarządzanie projektami, organizację koncepcji i inne profesjonalne narzędzia do pisania.

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
Użyj uv
```bash
uv venv -p 3.11
```
3. Instalacja zależności
```bash
pip install -r requirements.txt
```
Użycie uv
```bash
uv sync
```

4. Uruchomienie programu
```bash
python -m src
```

## Główne funkcje

### Zarządzanie projektami
- Hierarchiczna struktura dokumentów (Dzieło > Rozdział > Scena)
- Import i eksport projektów (obsługa formatów TEXT, MARKDOWN, DOCX, PDF, HTML)
- Automatyczne tworzenie kopii zapasowych i kontrola wersji
- Zarządzanie wieloma projektami
### Funkcja uzupełniania AI
- Trzy tryby uzupełniania: automatyczne uzupełnianie, ręczne uzupełnianie (zalecane: jedno naciśnięcie tab powoduje wywołanie, kolejne naciśnięcie tab stosuje uzupełnienie), wyłączone uzupełnianie
- Trzy tryby kontekstu:
  - Tryb szybki: lekki kontekst, szybka reakcja
  - Tryb zrównoważony: średni kontekst, równowaga jakości i szybkości
  - Tryb globalny: pełny kontekst projektu, najlepszy efekt
- Wsparcie dla różnych usług AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq i inne

### Zarządzanie konspektem
- Wizualna struktura drzewa konspektu
- Przeciąganie do zmiany kolejności i poziomów
- Szybka nawigacja po dokumencie
- Analiza konspektu i sugestie optymalizacyjne

### Konfiguracja API
- Ujednolicone centrum konfiguracji AI
- Wstępne ustawienia dla wielu dostawców usług
- Funkcja testowania połączenia
- Zapisywanie, import i eksport konfiguracji
### Ustawienia inteligentnego uzupełniania
- Regulowane opóźnienie wyzwalania
- Ograniczenie długości uzupełniania
- Konfiguracja długości kontekstu
- Wsparcie dla odpowiedzi strumieniowych

### Edycja promptów
- Wbudowane różne szablony pisarskie
- Własne szablony promptów
- Zarządzanie kategoriami szablonów
- Konfiguracja szablonów specyficznych dla trybu

### Funkcje interfejsu
- Jasny i ciemny motyw
- Układ trójkolumnowy (drzewo projektu, edytor, panel koncepcji)
- Składany pasek boczny
- Tryb pełnoekranowego pisania
- Tryb skupienia (zdanie, akapit, maszyna do pisania, tryb zen, tryb immersyjny)

### Wyszukiwanie i zamiana
- Wyszukiwanie tekstu w całym projekcie
- Obsługa wyrażeń regularnych
- Funkcja zamiany zbiorczej
- Zaawansowane opcje wyszukiwania

### Zarządzanie pojęciami
- Automatyczne wykrywanie ról, miejsc, przedmiotów
- Zarządzanie relacjami między pojęciami
- System tagów i kategoryzacji
- Szybkie wstawianie pojęć

## Skróty klawiaturowe

- `Ctrl+N`: Nowy projekt
- `Ctrl+O`: Otwórz projekt
- `Ctrl+S`: Zapisz dokument
- `F11`: Tryb pełnoekranowy
- `Tab`: Ręczne wywołanie AI do autouzupełniania (w trybie ręcznym)
- `Ctrl+F`: Znajdź
- `Ctrl+H`: Znajdź i zamień
- `Ctrl+Shift+H`: Zaawansowane znajdowanie i zamienianie
## Wymagania systemowe

- Python 3.8+
- PyQt6
- System operacyjny: Windows, macOS, Linux

## Autor

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---