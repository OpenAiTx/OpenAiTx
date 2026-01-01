
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

AI-wspomagany edytor powieści oparty na PyQt6, oferujący inteligentne uzupełnianie, zarządzanie projektami, organizację koncepcji i inne profesjonalne narzędzia pisarskie.

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

3. Instalacja zależności
```bash
pip install -r requirements.txt
```

4. Uruchom program
```bash
python src/main.py
```

## Główne funkcje

### Zarządzanie projektami
- Hierarchiczna struktura dokumentów (Dzieło > Rozdział > Scena)
- Import i eksport projektów (obsługa formatów TEXT, MARKDOWN, DOCX, PDF, HTML)
- Automatyczne kopie zapasowe i kontrola wersji
- Zarządzanie wieloma projektami

### Funkcje AI uzupełniania
- Trzy tryby uzupełniania: automatyczne, ręczne (zalecane: jedno naciśnięcie Tab wywołuje, kolejne stosuje uzupełnienie), wyłączone
- Trzy tryby kontekstu:
  - Tryb szybki: lekki kontekst, szybka odpowiedź
  - Tryb zrównoważony: średni kontekst, balans jakości i prędkości
  - Tryb globalny: pełny kontekst projektu, najlepszy efekt
- Obsługa wielu usług AI: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq itp.

### Zarządzanie konspektem
- Wizualna struktura drzewa konspektu
- Przeciąganie do sortowania i zmiany poziomów
- Szybka nawigacja po dokumencie
- Analiza konspektu i sugestie optymalizacyjne

### Konfiguracja API
- Centralne miejsce konfiguracji AI
- Wstępnie ustawione konfiguracje dla wielu dostawców
- Funkcja testowania połączenia
- Zapisywanie, import i eksport konfiguracji

### Ustawienia inteligentnego uzupełniania
- Regulowane opóźnienie wyzwalania
- Ograniczenie długości uzupełnień
- Konfiguracja długości kontekstu
- Obsługa odpowiedzi strumieniowych

### Edycja promptów
- Wbudowane szablony do pisania
- Własne szablony promptów
- Zarządzanie kategoriami szablonów
- Konfiguracja szablonów dla poszczególnych trybów

### Funkcje interfejsu
- Podwójny motyw: jasny i ciemny
- Układ trzykolumnowy (drzewo projektu, edytor, panel pojęć)
- Składany pasek boczny
- Tryb pełnoekranowego pisania
- Tryb skupienia (zdania, akapity, maszyna do pisania, tryb zen, tryb immersyjny)

### Wyszukiwanie i zamiana
- Wyszukiwanie tekstu w całym projekcie
- Obsługa wyrażeń regularnych
- Funkcja masowej zamiany
- Zaawansowane opcje wyszukiwania

### Zarządzanie pojęciami
- Automatyczne wykrywanie postaci, miejsc, przedmiotów
- Zarządzanie relacjami pojęć
- System etykiet i kategorii
- Szybkie wstawianie pojęć

## Skróty klawiaturowe

- `Ctrl+N`: Nowy projekt
- `Ctrl+O`: Otwórz projekt
- `Ctrl+S`: Zapisz dokument
- `F11`: Tryb pełnoekranowy
- `Tab`: Ręczne wywołanie autouzupełniania AI (w trybie ręcznym)
- `Ctrl+F`: Znajdź
- `Ctrl+H`: Znajdź i zamień
- `Ctrl+Shift+H`: Zaawansowane znajdź i zamień


## Wymagania systemowe

- Python 3.8+
- PyQt6
- System operacyjny: Windows, macOS, Linux

## Autor

**inliver**
- Email: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---