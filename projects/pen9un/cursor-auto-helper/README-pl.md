<h1 align="center">Witamy w&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Narzędzie do automatycznego kontynuowania Cursor, automatycznego ponawiania, automatycznego potwierdzania, statystyk zużycia, narzędzia rozszerzające Cursor, narzędzia wspomagające Cursor, narzędzia automatyzujące Cursor, ustawienia motywu Cursor, narzędzie Cursor Auto Continue, Cursor Auto Retry, Cursor Auto Confirm, Cursor Usage Statistics, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor po 25 wywołaniach narzędzi, Limit wywołań narzędzi Cursor🔧🤖🚀
> 

## 🏠 [Strona domowa](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper to narzędzie automatyzujące stworzone specjalnie dla Cursor IDE, które umożliwia wyświetlanie zużycia w czasie rzeczywistym, automatyczne radzenie sobie z limitem 25 rozmów, awariami połączenia sieciowego, potwierdzeniami i innymi scenariuszami, czyniąc pracę dewelopera płynniejszą.

**Wideo prezentacja:** [Demonstracja Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

Jeśli masz wysokiej jakości prompt i dobrze zaplanowane wymagania projektu, ten program pozwala Cursorowi automatycznie zrealizować projekt bez potrzeby interwencji człowieka.

> 🔒 **Kompatybilność wersji:** Aktualnie testowane i rozwijane na Cursor 0.49.6 oraz Cursor 1.0.0, teoretycznie kompatybilne z wersjami Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖Dziennik zmian

- 2025-06-01 Wydano wersję v2.3, dodano funkcję ustawień motywu Cursor, zoptymalizowano stabilność wstrzykiwania kodu, poprawiono wyświetlanie zużycia zgodnie z oficjalnym formatem
- 2025-05-21 Wydano wersję v2.1, przebudowano architekturę, dodano wsparcie dla wielu platform, dodano funkcję wyświetlania zużycia w czasie rzeczywistym itp.
- 2025-04-25 Ukończono wersję v1.0, automatyczne radzenie sobie z limitem 25 rozmów, awariami połączenia sieciowego, potwierdzeniami itp.
- 2025-04-20 Rozpoczęcie projektu

## 🌟 Najlepsze praktyki Cursor Auto Helper

Uwaga: poniższa dokumentacja może być generowana przez AI, takie jak Cursor, wymaga ręcznej weryfikacji i dostosowania.

**KROK 1:** Szczegółowy projekt wymagań systemowych projektu (im bardziej szczegółowo przeanalizowane wymagania, tym wyższa jakość projektu), napisz wysokiej jakości prompt do rozwoju projektu **SYSTEM.md**

**KROK 2:** Na podstawie **SYSTEM.md** wygeneruj wysokiej jakości dokumentację projektową systemu **DESIGN.md**

**KROK 3:** Na podstawie **SYSTEM.md** i **DESIGN.md** wygeneruj wysokiej jakości harmonogram rozwoju projektu **TODOLIST.md**

**KROK 4:** Użyj **Cursor Auto Helper**, wskaż **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, użyj automatycznego kontynuowania promptów, by Cursor automatycznie realizował projekt według harmonogramu, aż do zakończenia

**Cursor Auto Helper automatyczne prompt do kontynuacji:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Proszę ściśle realizować dalszy rozwój funkcjonalności zgodnie z planem rozwoju TODOLIST i na bieżąco aktualizować oraz zapisywać harmonogram rozwoju TODOLIST. Po zakończeniu każdego zadania zapytaj mnie "Czy kontynuować", a po zakończeniu projektu zwróć "Projekt został ukończony"
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Instrukcja obsługi

Zachęcamy do zostawienia gwiazdki (Star) na repozytorium. W przypadku problemów prosimy o zgłoszenie [Issues](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Opis pliku konfiguracyjnego

Plik konfiguracyjny `config.ini` **służy do dostosowania zachowania automatyzacji** (można ustawiać i testować według potrzeb), obsługuje poniższe opcje:

#### Podstawowa konfiguracja
```ini
[common]
log_enable = true     # Czy włączyć logowanie; jeśli nie chcesz zapisywać logów, ustaw na false

[cursor]
path = C:\Path\To\Cursor.exe  # Ścieżka instalacji Cursor IDE; program automatycznie znajdzie ścieżkę do Cursor, jeśli nie znajdzie, pojawi się komunikat, wystarczy zmienić tę opcję
```

#### Konfiguracja akcji automatycznych
Każda automatyczna akcja ma prefiks `nazwa_akcji.`, obsługiwane są następujące pola:

- `type`: typ akcji
  - `click`: kliknięcie przycisku
  - `input_and_submit`: wpisz i wyślij

- `text` / `text_list`: dopasowywana treść tekstowa
  - `text`: pojedynczy ciąg znaków
  - `text_list`: kilka ciągów znaków oddzielonych |, jeśli strona zawiera którykolwiek, akcja zostanie wywołana

- `button_selector`: selektor CSS przycisku do kliknięcia (wymagane tylko dla `click`)
- `button_text`: tekst przycisku (opcjonalnie, dodatkowe ograniczenie)
- `input_box_selector`: selektor CSS pola tekstowego (wymagane dla `input_and_submit`)
- `input_content`: treść do automatycznego wpisania
- `submit_btn_selector`: selektor CSS przycisku wysyłania
- `delay`: opóźnienie przed wykonaniem akcji (ms), może być użyte do oczekiwania na renderowanie strony

##### Przykład konfiguracji
```ini
[auto_actions]
# Automatyczne ponawianie po nieudanym połączeniu
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# po 25 wywołaniach narzędzi
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "Proszę kontynuować"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# Automatyczne potwierdzenie kontynuacji
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Uwaga:**
> 1. Nazwa każdej akcji (np. `action_retry`, `action_continue`) może być dowolna, ale wszystkie pola jednej akcji muszą mieć ten sam prefiks.
> 2. Zaleca się używanie narzędzi deweloperskich przeglądarki do ustalania selektorów CSS, aby zapewnić ich dokładność.
> 3. Po zmianie pliku konfiguracyjnego należy ponownie uruchomić program, aby zmiany zaczęły obowiązywać.

## 🎯 Zastosowania

### 💼 Rozwój długich konwersacji
- Automatycznie obsługuje limit 25 wiadomości w rozmowie, wspiera ciągły rozwój długich konwersacji, automatycznie kontynuuje proces dialogu, zwiększając efektywność pracy.

### 👥 Niestabilna sieć
- Automatycznie wykrywa problemy z siecią, inteligentnie ponawia połączenie, automatycznie wznawia rozmowę, gwarantując ciągłość pracy.

### 🏢 Scenariusze potwierdzeń
- Inteligentnie rozpoznaje sytuacje wymagające potwierdzenia, automatycznie obsługuje okna potwierdzeń, ograniczając konieczność ingerencji ręcznej.

### 📚 Monitorowanie zużycia
- Na bieżąco zlicza liczbę rozmów, monitoruje zużycie Cursor, rejestruje dane dotyczące użycia, optymalizuje efektywność.

Wyświetlanie zużycia w terminalu:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Wyświetlanie zużycia w Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Opis funkcjonalności

### 🤖Automatyczne kontynuowanie długiej rozmowy
- Automatycznie obsługuje limit 25 wiadomości w Cursor, wspiera wieloetapowe, ciągłe konwersacje.

### 🎨 Automatyczne ponawianie połączenia
- Automatycznie wykrywa nieudane połączenia sieciowe, inteligentnie ponawia próby, na bieżąco monitoruje stan połączenia.

### 📱 Automatyczne potwierdzanie komunikatów
- Inteligentnie rozpoznaje różne scenariusze potwierdzeń, automatycznie obsługuje okna potwierdzeń.
- Wspiera dostosowywanie treści potwierdzeń i odpowiedzi, ograniczając potrzebę ingerencji ręcznej.
- Elastyczna konfiguracja reguł, dopasowana do różnorodnych procesów deweloperskich.

### 🛍️ Statystyki użycia
- Na bieżąco zlicza liczbę rozmów i zużycie, automatycznie rejestruje dane.
- Wizualizacja danych o zużyciu, ułatwiająca analizę i optymalizację.
- Obsługa kolorowych logów w terminalu oraz panelu zużycia w IDE, zwiększając użyteczność.

### 💡 System logowania
- Wielopoziomowe logi (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), kolorowe wyjście w terminalu.
- Pliki logów generowane automatycznie według daty, obsługa zapisu do plików i panelu podglądu przez przeciąganie.
- Panel w czasie rzeczywistym ułatwia monitorowanie i analizę przez dewelopera.

### 🔒 Kompatybilność wersji i optymalizacja wydajności
- Rozwijany na bazie Cursor 0.49.6, pełne testy kluczowych funkcji.
- Optymalizacja pod wybrane wersje, na bieżąco dostosowywany do aktualizacji Cursor.
- Wysoka stabilność, dobra kompatybilność, odpowiedni do zastosowań produkcyjnych.

## 🔮Prezentacja efektów

### 🤖 Automatyczne kontynuowanie rozmowy

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Prezentacja automatycznego ukończenia programu przez Cursor

Od wymagań projektowych do pełnej realizacji, bez ingerencji ręcznej:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Autor

👤 **pen9un**

* Strona: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Wsparcie

Jeśli ten projekt okazał się przydatny, zostaw darmową gwiazdkę ⭐️⭐️

## ✨Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Statystyki odwiedzin

![Licznik odwiedzin](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---