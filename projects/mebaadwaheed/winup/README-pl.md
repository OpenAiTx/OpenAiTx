<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Przykłady obrazów

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Upewnij się, że pobierasz Najnowszą Stabilną Wersję (LSR), a nie najnowszą/LFR! Aktualna LSR: 2.4.9

`pip install winup==2.4.9`

**Niesamowicie "Pythoniczny" i potężny framework do budowania pięknych aplikacji desktopowych.**

WinUp to nowoczesny framework UI dla Pythona, który opakowuje moc PySide6 (Qt) w prosty, deklaratywny i przyjazny dla programisty interfejs API. Zaprojektowany, aby umożliwić szybsze tworzenie aplikacji, pisanie czystszego kodu i czerpanie przyjemności z procesu tworzenia.

### ✨ Teraz także z obsługą Web!
WinUp obsługuje teraz również budowanie w pełni interaktywnych, stanowych aplikacji webowych, wykorzystując to samo podejście oparte na Pythonie i komponentach. Moduł web używa FastAPI i WebSockets pod spodem, aby przenieść prostotę WinUp do przeglądarki.

[Dokumentacja Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Zastrzeżenie:** Obsługa web to funkcja opcjonalna. Aby jej użyć, należy zainstalować zależności webowe:
> ```bash
> pip install "winup[web]"
> ```

[Współtworzenie](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Zmiany](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Licencja](LICENSE)

---

## Dlaczego WinUp? (Zamiast czystego PySide6 lub Tkinter)

Tworzenie aplikacji desktopowych w Pythonie może być toporne. WinUp powstał, by to naprawić.

| Funkcja                 | Podejście WinUp ✨                                                              | Czysty PySide6 / Tkinter 😟                                                                     |
| ----------------------- | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------- |
| **Układy**              | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                     |
| **Stylowanie**          | `props={"background-color": "blue", "font-size": "16px"}`                      | Ręczne ciągi QSS, `widget.setStyleSheet(...)`, złożone obiekty stylów.                         |
| **Zarządzanie stanem**  | `state.bind(widget, "prop", "key")`                                            | Ręczne funkcje zwrotne, gettery/settery, `StringVar()`, wszędzie boilerplate.                  |
| **Dwukierunkowe powiązania** | `state.bind_two_way(input_widget, "key")`                                | Nie istnieje. Wymaga ręcznych handlerów `on_change` do aktualizacji stanu i UI.                |
| **Narzędzia developerskie** | **Wbudowany Hot Reload**, profiler kodu, narzędzia okienkowe w zestawie.   | Nie istnieje. Trzeba restartować całą aplikację przy każdej zmianie UI.                        |
| **Struktura kodu**      | Wielokrotnie używalne, samodzielne komponenty z `@component`.                  | Często prowadzi do dużych, monolitycznych klas lub skryptów proceduralnych.                    |

**Krótko mówiąc, WinUp dostarcza "killer features" nowoczesnych frameworków webowych (jak React czy Vue) na desktop, oszczędzając Twój czas i pozwalając Ci skupić się na logice Twojej aplikacji.**

# 🧊 WinUp vs 🧱 PyEdifice (Na prośbę użytkownika Reddita)

| Funkcja                         | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Architektura                  | Styl React + stan          | Styl React + stan                |
| 🌐 Wbudowany routing             | ✅ Tak (`Router(routes={...})`)       | ❌ Brak wbudowanego routingu      |
| ♻️ Hooki cyklu życia             | ✅ `on_mount`, `on_unmount`, itd.     | ⚠️ Ograniczone (`did_mount`, itd.)|
| 🎨 System theming/stylowania     | ✅ Globalne i lokalne motywy          | ❌ Ręczne wstrzykiwanie CSS       |
| 🔲 Opcje układów                 | ✅ Wiersz, Kolumna, Grid, Stack, Flexbox | ⚠️ Głównie Box & HBox/VBox      |
| 🎞️ Animacje                     | ✅ Wbudowane (fade, scale, itd.)      | ❌ Brak wbudowanych               |
| 🔁 Hot Reloading (LHR)           | ✅ Stabilny + szybki (`loadup dev`)   | ⚠️ Eksperymentalny, ograniczone wsparcie |
| 📦 Pakowanie                     | ✅ Z LoadUp (oparty na PyInstallerze) | ❌ Integracja z PyInstaller ręcznie     |
| 🧩 Reużywalność komponentów      | ✅ Wysoka, deklaratywna               | ✅ Wysoka                         |

| 🛠 Narzędzia deweloperskie         | ✅ DevTools zaplanowane, Inspektor wkrótce | ❌ Brak na razie                       |
| 📱 Wsparcie mobilne                | ❌ Jeszcze nie                            | ❌ Nieobsługiwane                      |
| 🧠 Krzywa uczenia                  | ✅ Łatwe dla użytkowników Python+React     | ✅ Łatwe, ale mniej narzędzi           |

> ✅ = Wbudowane lub solidne  
> ⚠️ = Częściowe lub ograniczone  
> ❌ = Całkowicie brakujące
---

## Kluczowe funkcje

*   **Deklaratywny i Pythoniczny UI:** Buduj złożone układy za pomocą prostych obiektów `Row` i `Column` zamiast nieporęcznych układów pudełkowych.
*   **Architektura komponentowa:** Używaj dekoratora `@component`, aby tworzyć modułowe i wielokrotnego użytku widżety UI z prostych funkcji.
*   **Potężny system stylowania:** Stylizuj widżety za pomocą prostych słowników Pythona przy użyciu `props`. Twórz globalne klasy „jak CSS” za pomocą `style.add_style_dict`.
*   **Pełna powłoka aplikacji:** Twórz profesjonalne aplikacje z deklaratywnym API dla `MenuBar`, `ToolBar`, `StatusBar` i `SystemTrayIcon`.
*   **Asynchroniczny uruchamiacz zadań:** Uruchamiaj długotrwałe operacje w tle bez zamrażania UI, używając prostego dekoratora `@tasks.run`.
*   **Wydajność domyślnie:** Zawiera opcjonalny dekorator `@memo` do cache’owania renderowania komponentów i zapobiegania zbędnym obliczeniom.
*   **Zaawansowana rozszerzalność:**
    *   **Fabryka widżetów:** Zastąp dowolny domyślny widżet własną implementacją (np. w C++) za pomocą `ui.register_widget()`.
    *   **Wiele okien:** Twórz i zarządzaj wieloma niezależnymi oknami dla złożonych aplikacji jak palety narzędzi czy odtwarzacze muzyki.
*   **Reaktywne zarządzanie stanem:**
    *   **Jednokierunkowe powiązanie:** Automatycznie aktualizuj UI, gdy dane się zmieniają, używając `state.bind()`.
    *   **Dwukierunkowe powiązanie:** Bez wysiłku synchronizuj widżety wejściowe ze stanem za pomocą `state.bind_two_way()`.
    *   **Subskrypcje:** Uruchamiaj dowolną funkcję w odpowiedzi na zmiany stanu dzięki `state.subscribe()`.
*   **Przyjazne narzędzia dla deweloperów:**
    *   **Hot Reloading:** Zobacz zmiany w UI natychmiast bez ponownego uruchamiania aplikacji.
    *   **Profiler:** Łatwo mierz wydajność dowolnej funkcji za pomocą dekoratora `@profiler.measure()`.
    *   **Narzędzia okien:** Wygodnie centruj, podświetlaj lub zarządzaj oknem aplikacji.
*   **Wbudowany routing:** Łatwo twórz aplikacje wielostronicowe z intuicyjnym, stanowym routerem.
*   **Elastyczna warstwa danych:** Zawiera proste, spójne konektory do SQLite, PostgreSQL, MySQL, MongoDB i Firebase.

---

# Dokumentacja

Poznaj głębiej możliwości WinUp:

## Kluczowe pojęcia
- [**Model komponentów i stylowanie**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Zarządzanie stanem**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Hooki cyklu życia**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Routing**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Pozycjonowanie absolutne (zaawansowane)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Narzędzia deweloperskie
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Profiler wydajności**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoizacja**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Asynchroniczny uruchamiacz zadań**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Komponenty UI
- [**Pełna biblioteka komponentów**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Współtworzenie

WinUp to projekt open-source. Współpraca mile widziana!

## Licencja

Ten projekt jest licencjonowany na MIT License. Zobacz **LICENSE** po więcej informacji.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---