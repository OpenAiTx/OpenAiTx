# AI Screenshot Translator (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Wprowadzenie

To narzędzie umożliwia **proste wykonywanie zrzutów ekranu**, przesyłanie obrazu do modelu AI w celu rozpoznania tekstu i jego tłumaczenia, a wynik tłumaczenia wyświetlany jest w osobnym oknie w interaktywnym formacie HTML.

Narzędzie obsługuje **definiowane przez użytkownika skróty klawiszowe, zarządzanie wieloma oknami wyników oraz działanie w zasobniku systemowym**, co znacznie zwiększa efektywność tłumaczeń w codziennej pracy i nauce.

**Cechy narzędzia**: 1. Tłumaczenie zrzutów ekranu, uruchamiane skrótem klawiszowym; 2. Tłumaczenie i przypinanie zrzutów, swobodne przeciąganie, skalowanie, możliwość tworzenia wielu grup przypiętych tłumaczeń; 3. Formuły można przełączać na oryginalny tekst w celu łatwego kopiowania; 4. Własny interfejs API

**Problemy do rozwiązania**: 1. Obecnie dostępne na rynku narzędzia do tłumaczenia całych dokumentów są zbyt rozbudowane; 2. Przy kopiowaniu tekstu z plików PDF czasami bloki formuł są nieczytelne lub nie można ich skopiować; 3. W przypadku PDF-ów zeskanowanych jako obrazy nie można kopiować tekstu

# Demonstracja

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Prezentacja okien

Okno tłumaczenia:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Okno konfiguracji:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Bardziej szczegółowy opis opcji konfiguracyjnych można znaleźć w samym programie lub na stronie [Wskazówki](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Instalacja

Możesz pobrać kod źródłowy i uruchomić go samodzielnie albo przejść do sekcji [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases), aby pobrać plik wykonywalny.

### 1. Sklonuj repozytorium

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Utwórz środowisko wirtualne i uruchom

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Plan aktualizacji

- ~~Nowe okno GUI do konfiguracji API, optymalizacja ręcznej edycji pliku yaml na automatyczne generowanie przez program (zrealizowano w v0.3.0)~~
- Dodanie systemu przechowywania obrazów i formuł, ułatwiającego późniejsze wykorzystanie (planowane na v0.4)
- (Więcej funkcji — zapraszamy do zgłaszania issue lub współpracy przez PR)

# Inne

- Ikona programu pochodzi z [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Podziękowania dla Gemini 2.5 Flash i DeepSeek-V3-0324 za pomoc w znajdowaniu błędów

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---