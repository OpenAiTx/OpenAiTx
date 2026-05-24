<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">

  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Kup mi kawę na ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Prosty eksplorator plików, który powstał, ponieważ chciałem nauczyć się języka Rust.
  <br>
  Jest niezależny od systemu operacyjnego i zoptymalizowany pod kątem wydajności.
</p>

<br/><br/>

Wydajność została osiągnięta dzięki ["jwalk"](https://crates.io/crates/jwalk/versions) oraz ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver nie używa buforowania ścieżek do dostępu do plików i folderów, więc wydajność wynika z Rust, szybkości dysku i mocy procesora.

⁉️ Pamiętaj, że to oprogramowanie jest nadal w fazie rozwoju i może zawierać błędy!
<br/><br/>

# Linki
- <a href="#basic-features">Podstawowe funkcje</a>
- <a href="#advanced-features">Zaawansowane funkcje</a>
- <a href="#dependencies-if-not-working-instantly">Zależności</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Implementacja FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">Znane problemy</a>
- <a href="#-todos">Zadania</a>
- <a href="#user-interface">Interfejs użytkownika</a>

## Podstawowe funkcje
- Nawiguj po katalogach jak zwykle
- Kopiuj i wklejaj, usuwaj, twórz i zmieniaj nazwy plików oraz folderów
- Przełączaj się między trybem siatki, listy oraz kolumn Millera
- Zamykaj okienka naciskając esc
- Przechodź bezpośrednio do katalogu za pomocą Ctrl / Cmd + G, wpisując ścieżkę
- Sortuj elementy w trybie listy według rozmiaru, nazwy lub daty modyfikacji

## Zaawansowane funkcje
- Kompresuj pliki i foldery
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Rozpakuj archiwa
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Nawiguj do katalogu skrótem LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Skonfiguruj ścieżki samodzielnie w ustawieniach
- Utwórz plik klawiszem F6
- Utwórz folder klawiszem F7
- Widok dwupanelowy
  - Szukaj plików klawiszem F8
  - Skopiuj aktualnie zaznaczony element do drugiego panelu klawiszem F5
  - Przenieś aktualnie zaznaczony element do drugiego panelu klawiszem LShift + F5
- Przeciągnij i upuść pliki do eksploratora, aby skopiować je do bieżącego katalogu
- Zmień nazwę wielu wybranych elementów naraz skrótem Ctrl / Cmd + LShift + M
  - Uruchom zmianę nazw wielu plików skrótem Ctrl / Cmd + Enter
- Szybki podgląd pliku -> Zaznacz katalog lub plik i naciśnij spację.
  - Obsługiwane pliki: wszystkie obrazy (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Pozostałe elementy wyświetlą małą kafelkę z informacjami (ścieżka, rozmiar, data modyfikacji)
- Natychmiastowa nawigacja -> Zacznij pisać, a pozycje katalogu będą automatycznie filtrowane, co czasami <br/>
  znacznie przyspiesza przejście do wybranej lokalizacji

## Zależności (jeśli nie działa od razu)

<details>
<summary>Kliknij, aby rozwinąć</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Architektura
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ Integracja FTP (sshfs)
<details>
  <summary>Rozwiń, aby zobaczyć</summary>
  <br/>
  Wymagane zależności (należy zainstalować osobno):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Nieobsługiwane **_jeszcze_** |

  ### Instalacja:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ Obsługa języków
- Angielski
  - Opcja wyboru języka już wkrótce ...
</details>

## ⚠️ Znane problemy:
- Przeciąganie i upuszczanie poza okno nie zawsze działa na systemie Linux
- Na Windows możesz musieć zainstalować [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Uprawnienia w systemie ms-windows są trochę nietypowe
  - Jeśli masz problem ze skopiowaniem elementów lub czymś podobnym, możesz musieć uruchomić program jako administrator
- Może pojawić się problem wymagający instalacji openssl1.1 na systemach Linux, jeśli program się nie uruchamia

## 📝 Do zrobienia:
- Wiele języków
- Ulubione
- Dostęp do usług przechowywania online (Google drive itp.)

## Interfejs użytkownika

### Styl listy
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### Styl siatki
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### Widok kolumnowy Millera
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### Widok dwóch paneli
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## Jak się przyczynić
Przygotuj swoje środowisko do tworzenia aplikacji tauri v1: [Wymagania wstępne Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Gdy to będzie gotowe, wystarczy wykonać ```git clone https://github.com/RickyDane/CoDriver``` lub ```gh repo clone RickyDane/CoDriver``` w wybranej lokalizacji na swoim komputerze.
</br></br>
Powinieneś móc uruchomić ```cargo tauri dev``` w katalogu głównym projektu, aby zacząć budować i uruchamiać CoDriver.
</br>
Upewnij się, że masz zainstalowany tauri-cli: ```cargo install tauri-cli```
</br>

## Podpisywanie wydań

Artefakty wydań dla systemu macOS muszą być podpisane i zatwierdzone, aby Gatekeeper nie zgłaszał, że zainstalowana aplikacja jest uszkodzona. Zobacz [Podpisywanie i zatwierdzanie macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md), aby uzyskać wymagane sekrety GitHub Actions oraz polecenia weryfikacyjne.

## Historia gwiazdek

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Wykres historii gwiazdek" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Inne oprogramowanie firm trzecich
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---