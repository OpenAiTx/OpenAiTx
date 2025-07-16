# Szybka Podpowiedź

<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Potężne rozszerzenie przeglądarki skupiające się na zarządzaniu podpowiedziami i szybkim wprowadzaniu tekstu. Pomaga użytkownikom tworzyć, zarządzać i organizować bazę podpowiedzi oraz błyskawicznie wstawiać przygotowane treści Prompt w dowolnym polu tekstowym na stronie internetowej, zwiększając wydajność pracy.

> Ponieważ wtyczka przeglądarki działa tylko w wersji webowej, udostępniłem także [wtyczkę Raycast](https://github.com/wenyuanw/quick-prompt-raycast) o tych samych funkcjach, kompatybilną z formatem danych rozszerzenia przeglądarki i obsługującą płynne przenoszenie danych JSON.

## ✨ Funkcje

- 📚 **Zarządzanie podpowiedziami**: Wygodne tworzenie, edycja i organizacja własnej bazy podpowiedzi
- 🚀 **Szybkie wprowadzanie**: W każdym polu tekstowym na stronie wpisz `/p`, aby szybko wywołać selektor podpowiedzi
- ⌨️ Obsługa skrótów klawiszowych do otwierania selektora podpowiedzi i zapisywania zaznaczonego tekstu jako podpowiedzi
- 📑 Obsługa menu kontekstowego (prawy przycisk myszy) do bezpośredniego zapisu zaznaczonego tekstu jako podpowiedzi
- 🎯 Obsługa własnych podpowiedzi, w tym kategorie, tytuły, treść, tagi oraz zmienne
- 🧑‍💻 **Obsługa zmiennych**: W podpowiedziach możesz użyć zmiennych w formacie `{{nazwa_zmiennej}}`, a podczas użycia podać ich wartość
- 💾 **Kopia zapasowa danych**: Możliwość eksportu i importu bazy podpowiedzi, ułatwiając migrację i kopie zapasowe między urządzeniami
- 🔗 **Synchronizacja z Notion**: Możliwość synchronizacji bazy podpowiedzi z bazą danych Notion
- 🔍 Obsługa wyszukiwania i filtrowania podpowiedzi
- 🌙 Automatyczne dopasowanie do jasnego i ciemnego motywu systemowego

## ⚠️ Znane problemy

- Na stronie Doubao (doubao.com), po wywołaniu selektora podpowiedzi przez `/p`, w niektórych polach tekstowych `/p` nie zostaje usunięte. Bez obaw, ja i mój stary kompan Cursor pracujemy dniami i nocami nad rozwiązaniem i postaramy się naprawić to jak najszybciej!

## 🚀 Jak używać

1. **Szybkie wywołanie**: Wpisz `/p` w dowolnym polu tekstowym na stronie, aby wywołać selektor podpowiedzi
2. **Skrót klawiszowy do selektora**: Użyj `Ctrl+Shift+P` (Windows/Linux) lub `Command+Shift+P` (macOS), aby otworzyć selektor podpowiedzi
3. **Wybierz podpowiedź**: Kliknij potrzebną podpowiedź w wyświetlonym selektorze; zostanie ona automatycznie wstawiona do bieżącego pola tekstowego
4. **Szybkie zapisywanie podpowiedzi**: Zaznacz dowolny tekst, a następnie użyj `Ctrl+Shift+S` (Windows/Linux) lub `Command+Shift+S` (macOS), aby błyskawicznie zapisać go jako podpowiedź
5. **Zapis przez menu kontekstowe**: Zaznacz tekst, kliknij prawym przyciskiem myszy i wybierz "Zapisz tę podpowiedź", aby dodać zaznaczenie do bazy podpowiedzi
6. **Eksport bazy podpowiedzi**: Na stronie zarządzania kliknij przycisk "Eksportuj", aby zapisać wszystkie podpowiedzi do pliku JSON na dysku
7. **Import bazy podpowiedzi**: Na stronie zarządzania kliknij przycisk "Importuj", aby załadować podpowiedzi z pliku JSON (możesz dodać je do istniejących lub nadpisać bazę)

## 📸 Podgląd interfejsu

Quick Prompt oferuje intuicyjny i przyjazny interfejs do łatwego zarządzania i korzystania z podpowiedzi.

### Selektor podpowiedzi

![Selektor podpowiedzi](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Selektor podpowiedzi](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Użyj skrótu `/p` lub skrótu klawiszowego, aby szybko wywołać selektor podpowiedzi w dowolnym polu tekstowym i wygodnie wybrać oraz wstawić potrzebną podpowiedź.

### Strona zarządzania podpowiedziami

![Zarządzanie podpowiedziami](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Na stronie zarządzania możesz tworzyć nowe podpowiedzi, edytować istniejące, dodawać tagi i zarządzać kategoriami. Interfejs jest przejrzysty i łatwy w obsłudze.

### Zapis przez menu kontekstowe

![Zapis przez menu kontekstowe](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Zaznacz dowolny tekst na stronie, kliknij prawym przyciskiem i natychmiast zapisz go jako podpowiedź, zwiększając efektywność pracy.

### Wprowadzanie zmiennych do podpowiedzi

![Okno zmiennych podpowiedzi](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Podpowiedzi obsługują konfigurowalne zmienne — po wybraniu pojawia się okno do wprowadzenia ich wartości.

## ⚙️ Konfiguracja własna

1. Kliknij ikonę rozszerzenia, a następnie przycisk "Zarządzaj podpowiedziami"
2. Na stronie zarządzania możesz:
   - Dodawać nowe podpowiedzi
   - Edytować istniejące podpowiedzi
   - Usuwać niepotrzebne podpowiedzi
   - Dodawać tagi do podpowiedzi w celu kategoryzacji
   - Eksportować bazę podpowiedzi do kopii zapasowej
   - Importować wcześniej zarchiwizowaną bazę podpowiedzi

## 📦 Instrukcja instalacji

### Instalacja ze sklepu z aplikacjami

Dostępne już w Chrome Web Store! [Kliknij tutaj, aby pobrać i zainstalować](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Pobieranie z GitHub Releases

1. Wejdź na [stronę GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Pobierz najnowszą wersję gotowego pakietu rozszerzenia
3. Rozpakuj pobrany plik
4. Zainstaluj zbudowane rozszerzenie zgodnie z poniższymi instrukcjami

### Budowanie ze źródeł

1. Sklonuj repozytorium
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Instalacja zależności
   ```bash
   pnpm install
   ```
3. Rozwój i budowa

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Instalacja zbudowanego rozszerzenia

#### Chrome / Edge
1. Otwórz stronę zarządzania rozszerzeniami (`chrome://extensions` lub `edge://extensions`)
2. Włącz "Tryb deweloperski"
3. Kliknij "Załaduj rozpakowane rozszerzenie"
4. Wybierz katalog `.output/chrome-mv3/` projektu

#### Firefox
1. Otwórz `about:debugging`
2. Kliknij "Ten Firefox"
3. Kliknij "Tymczasowo załaduj dodatek"
4. Wybierz plik `manifest.json` w katalogu `.output/firefox-mv2/` projektu

## 📄 Licencja

MIT

## 🤝 Przewodnik dla współtwórców

Zachęcamy do zgłaszania Pull Requestów i Issue!

1. Sforkuj to repozytorium
2. Utwórz swoją gałąź funkcjonalności (`git checkout -b feature/amazing-feature`)
3. Zatwierdź swoje zmiany (`git commit -m 'Add some amazing feature'`)
4. Wypchnij na gałąź (`git push origin feature/amazing-feature`)
5. Otwórz Pull Request

## 👏 Lista współtwórców

Dziękujemy wszystkim deweloperom za wkład w projekt!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---