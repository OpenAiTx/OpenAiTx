# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Sieciowy, wieloplatformowy launcher aplikacji z wtyczkami opartymi na React

> [!WARNING]
> Launcher jest rozwijany przez jednego dewelopera w wolnym czasie.
> Zmiany mogą pojawiać się wolno, ale systematycznie.
>
> Prawdopodobnie pojawią się zmiany niezgodne wstecznie, które będą dokumentowane w [changelogu](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Nieco nieaktualne demo

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Funkcje

- Wtyczki jako podstawa
  - Wtyczki są pisane w TypeScript
  - Rozbudowane API dla wtyczek
      - Tworzenie widoków UI
      - Komendy jednorazowe (one-shot)
      - Dynamiczne dostarczanie listy jednorazowych komend
      - Renderowanie szybkiej zawartości "inline" bezpośrednio pod głównym paskiem wyszukiwania na podstawie jego wartości
      - Pobieranie i dodawanie zawartości do schowka
  - Wtyczki są dystrybuowane jako oddzielne gałęzie w repozytorium Git, co oznacza, że dystrybucja wtyczek nie wymaga żadnego centralnego
    serwera
  - Identyfikatory wtyczek to po prostu adresy URL repozytoriów Git
  - UI wtyczek oparty na [React](https://github.com/facebook/react)
    - Implementacja na bazie własnego React Reconciler (bez Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno umożliwia sandboxowanie kodu JavaScript wtyczek dla lepszego bezpieczeństwa
    - Wtyczki muszą jawnie określić, jakich uprawnień potrzebują do działania
    - Node.js jest używany do uruchamiania narzędzi dla wtyczek, ale jako deweloper wtyczki zawsze piszesz kod uruchamiany na Deno
- Od początku projektowany z myślą o wieloplatformowości
- Komendy i widoki można uruchamiać/otwierać za pomocą własnych skrótów globalnych
- Dowolny alias wyszukiwania może być przypisany do komend lub widoków
- Obsługa własnych motywów
- Wbudowana funkcjonalność dostarczana jest przez dołączone wtyczki
  - Applications: pokazuje aplikacje zainstalowane w systemie w wynikach wyszukiwania
    - Wtyczka śledzi także okna i do jakiej aplikacji należą, więc otwarcie już uruchomionej aplikacji domyślnie wywoła wcześniej utworzone okno
      - Nie wszystkie systemy są obecnie wspierane. Zobacz [wsparcie funkcji](https://gauntlet.sh/docs/feature-support)
  - Calculator: pokazuje wynik operacji matematycznych bezpośrednio pod głównym paskiem wyszukiwania
    - Obejmuje konwersje walut z wykorzystaniem kursów wymiany
    - Oparte na [Numbat](https://github.com/sharkdp/numbat)
- Sortowanie wyników wyszukiwania oparte na frecency
   - Frecency to połączenie częstotliwości i świeżości użycia
   - Im częściej element jest używany, tym wyżej na liście wyników się pojawi, ale elementy używane często w przeszłości będą niżej niż te używane równie często, ale niedawno
   - Wyniki są dopasowywane per słowo jako podciągi

##### Wsparcie dla systemów operacyjnych

##### Oficjalnie
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Najlepsze możliwe wsparcie
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland nie jest jeszcze wspierany, zobacz [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Pierwsze kroki

### Instalacja Gauntlet

Zobacz [Instalacja](https://gauntlet.sh/docs/installation)

### Globalny skrót klawiszowy

Główne okno można otworzyć za pomocą globalnego skrótu klawiszowego lub polecenia CLI:
- Globalny skrót (można zmienić w Ustawieniach)
  - Windows: <kbd>ALT</kbd> + <kbd>Spacja</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Spacja</kbd>
  - Linux Wayland
    - Globalny skrót może nie być wspierany, zobacz [wsparcie funkcji](https://gauntlet.sh/docs/feature-support)
    - Proszę użyć polecenia CLI i wywołać je przy użyciu odpowiedniej metody menedżera okien
  - macOS: <kbd>CMD</kbd> + <kbd>Spacja</kbd>
- Polecenie CLI
  - `gauntlet open`

### Instalacja wtyczki

Wtyczki instaluje się w ustawieniach UI. Użyj adresu URL repozytorium Git danej wtyczki, np. `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Tworzenie własnej wtyczki

Zobacz [Pierwsze kroki z tworzeniem wtyczek](https://gauntlet.sh/docs/plugin-development/getting-started)

## Motywy

Zobacz [Motywy](https://gauntlet.sh/docs/theming)

## Budowanie Gauntlet

Wymagane:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (nie jest używany bezpośrednio przez projekt, ale jest wymagany przez zależność)
- Na Linuxie: `libxkbcommon-dev` (uwaga: nazwa może się różnić w zależności od dystrybucji)

### Dev

Aby zbudować wersję deweloperską uruchom:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
W dev (bez funkcji "release") aplikacja używa WYŁĄCZNIE katalogów wewnątrz katalogu projektu do przechowywania stanu lub cache, by nie naruszać globalnej instalacji

### Not-yet-packaged

Aby zbudować binarkę niepakietowaną w trybie release, uruchom:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Pakietowane
Aby zbudować pakiet specyficzny dla systemu operacyjnego, uruchom jedno z poniższych:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Ale nowa wersja powinna być wydawana przez GitHub Actions

## Współtworzenie

Jeśli chcesz pomóc w rozwoju Gauntlet, możesz to zrobić na więcej sposobów niż tylko przez kontrybucję kodu:
- Zgłaszanie błędów lub problemów UI/UX
- Tworzenie wtyczek

W przypadku prostych problemów śmiało otwórz issue lub PR i rozwiąż je samodzielnie.
W przypadku większych zmian skontaktuj się najpierw z twórcami na Discordzie (link na górze README) i przedyskutuj temat.

Wszelkie kontrybucje są mile widziane.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---