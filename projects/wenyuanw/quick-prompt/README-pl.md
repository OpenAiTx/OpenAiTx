# Quick Prompt

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

Potężne rozszerzenie do przeglądarki, skoncentrowane na zarządzaniu promptami oraz szybkim wprowadzaniu tekstu. Pomaga użytkownikom tworzyć, zarządzać i organizować bazę promptów oraz błyskawicznie wstawiać zapisane treści Prompt do dowolnego pola tekstowego na stronie, zwiększając efektywność pracy.

> Ponieważ wtyczka do przeglądarki działa tylko w środowisku webowym, udostępniono otwarty [plugin Raycast](https://github.com/wenyuanw/quick-prompt-raycast) o identycznej funkcjonalności, kompatybilny z formatem danych rozszerzenia, umożliwiający bezproblemową migrację za pomocą tych samych danych JSON.

## ✨ Funkcje

- 📚 **Zarządzanie promptami**: Wygodne tworzenie, edytowanie i zarządzanie własną biblioteką promptów
- 🚀 **Szybkie wprowadzanie**: W dowolnym polu tekstowym na stronie wywołaj selektor promptów wpisując `/p`
- ⌨️ Obsługa konfigurowalnych skrótów klawiszowych do otwierania selektora promptów i zapisywania zaznaczonego tekstu jako promptu
- 📑 Obsługa zapisywania zaznaczonego tekstu jako prompt poprzez menu kontekstowe (prawy przycisk myszy)
- 🎯 Obsługa własnych promptów, w tym kategoryzacji, tytułu, treści, tagów i zmiennych
- 🧑‍💻 **Wsparcie zmiennych**: Możliwość używania zmiennych w formacie `{{nazwa_zmiennej}}` w promptach i podawania ich wartości podczas użycia
- 💾 **Kopia zapasowa danych**: Eksport i import bazy promptów, łatwa migracja i kopia zapasowa między urządzeniami
- 🔗 **Synchronizacja w chmurze**: Możliwość synchronizacji bazy promptów z bazą Notion lub Gitee/GitHub Gist
- 🔍 Wyszukiwanie i filtrowanie promptów
- 🌙 Automatyczne dostosowanie do trybu jasnego/ciemnego systemu

## 🚀 Sposób użycia

1. **Szybkie wywołanie**: Wprowadź `/p` w dowolnym polu tekstowym, aby wywołać selektor promptów
2. **Otwieranie selektora skrótem**: Użyj `Ctrl+Shift+P` (Windows/Linux) lub `Command+Shift+P` (macOS), by otworzyć selektor promptów
3. **Wybieranie promptu**: Kliknij na żądany prompt w wyskakującym selektorze, a zostanie automatycznie wstawiony do bieżącego pola tekstowego
4. **Szybkie zapisywanie promptu**: Po zaznaczeniu tekstu użyj `Ctrl+Shift+S` (Windows/Linux) lub `Command+Shift+S` (macOS), aby szybko zapisać go jako prompt
5. **Zapisywanie z menu kontekstowego**: Po zaznaczeniu tekstu kliknij prawym przyciskiem i wybierz "Zapisz ten prompt", aby dodać zaznaczoną treść do promptów
6. **Eksport bazy promptów**: Na stronie zarządzania kliknij przycisk "Eksportuj", aby zapisać wszystkie prompty w pliku JSON na dysku
7. **Import bazy promptów**: Na stronie zarządzania kliknij przycisk "Importuj", aby dodać prompty z pliku JSON z dysku (możliwość łączenia lub nadpisywania obecnych promptów)

## 📸 Podgląd interfejsu

Quick Prompt oferuje intuicyjny i przyjazny interfejs, dzięki któremu łatwo zarządzasz i używasz promptów.

### Selektor promptów

![提示词选择器](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![提示词选择器](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Użyj skrótu `/p` lub skrótu klawiszowego, aby szybko wywołać selektor promptów w dowolnym polu tekstowym i wygodnie wybrać oraz wstawić potrzebny prompt.

### Strona zarządzania promptami

![提示词管理](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Na stronie zarządzania możesz tworzyć nowe prompty, edytować istniejące, dodawać tagi oraz zarządzać kategoriami. Interfejs jest przejrzysty i prosty w obsłudze.

### Zapisywanie przez menu kontekstowe

![Zapisywanie przez menu kontekstowe](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Wystarczy zaznaczyć dowolny tekst na stronie internetowej, kliknąć prawym przyciskiem, aby szybko zapisać go jako prompt, zwiększając efektywność pracy.

### Wprowadzanie zmiennych prompta

![Okno zmiennych prompta](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompty obsługują konfigurację zmiennych, po wybraniu pojawia się okno do wprowadzenia odpowiednich wartości.

## ⚙️ Konfiguracja niestandardowa

1. Kliknij ikonę rozszerzenia, a następnie przycisk "Zarządzaj promptami"
2. Na stronie zarządzania możesz:
   - Dodawać nowe prompty
   - Edytować istniejące prompty
   - Usuwać niepotrzebne prompty
   - Dodawać tagi do promptów w celu kategoryzacji
   - Eksportować bazę promptów do backupu
   - Importować wcześniej zapisany backup bazy promptów

## 📦 Instrukcja instalacji

### Instalacja ze sklepu aplikacji

Rozszerzenie dostępne jest w Chrome Web Store! [Kliknij tutaj, aby pobrać i zainstalować](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Pobierz z GitHub Releases

1. Wejdź na [stronę GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Pobierz najnowszą wersję gotowej paczki rozszerzenia
3. Rozpakuj pobrany plik
4. Postępuj zgodnie z instrukcją poniżej, aby zainstalować gotowe rozszerzenie

### Kompilacja ze źródeł

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
2. Włącz "Tryb dewelopera"
3. Kliknij "Załaduj rozpakowane rozszerzenie"
4. Wybierz katalog `.output/chrome-mv3/` projektu

#### Firefox
1. Otwórz `about:debugging`
2. Kliknij "Ten Firefox"
3. Kliknij "Tymczasowo załaduj dodatek"
4. Wybierz plik `manifest.json` w katalogu `.output/firefox-mv2/` projektu

## 📄 Licencja

MIT

## 🤝 Przewodnik po kontrybucji

Zapraszamy do zgłaszania Pull Requests i Issues!

1. Forknij to repozytorium
2. Utwórz swoją gałąź funkcjonalności (`git checkout -b feature/amazing-feature`)
3. Zatwierdź swoje zmiany (`git commit -m 'Add some amazing feature'`)
4. Wypchnij na gałąź (`git push origin feature/amazing-feature`)
5. Otwórz Pull Request

## 👏 Lista współtwórców

Dziękujemy wszystkim deweloperom, którzy przyczynili się do projektu!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---