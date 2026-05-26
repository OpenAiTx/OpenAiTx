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
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Postaw mi kawę na ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Prosty eksplorator plików, który powstał, ponieważ chciałem nauczyć się języka Rust.
  <br>
  Jest niezależny od systemu operacyjnego i zoptymalizowany pod kątem wydajności.
</p>

<br/><br/>

Wydajność jest osiągana dzięki ["jwalk"](https://crates.io/crates/jwalk/versions) oraz ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver nie używa buforowania ścieżek do dostępu do plików i folderów, więc wydajność zapewnia Rust, szybkość dysku i moc procesora.

⁉️ Pamiętaj, że to oprogramowanie jest nadal w fazie rozwoju i może zawierać błędy!
<br/><br/>

# Linki
- <a href="#basic-features">Podstawowe funkcje</a>
- <a href="#advanced-features">Zaawansowane funkcje</a>
- <a href="#dependencies-if-not-working-instantly">Zależności</a>
- <a href="#%EF%B8%8F-ftp-sftp-integration">Integracja FTP / SFTP</a>
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

## 🖥️ Integracja FTP / SFTP

CoDriver zapewnia natywną, gotową do użycia obsługę połączeń zdalnych FTP i SFTP. Nie są wymagane żadne zewnętrzne zależności, warstwy FUSE ani montowania `sshfs`! Po prostu połącz swoje zdalne serwery bezpośrednio w panelu bocznym.

## 🏴‍☠️ Obsługa języków
- Angielski
  - Wkrótce dostępna możliwość wyboru języka ...

## ⚠️ Znane problemy:
- Przeciąganie i upuszczanie poza okno obecnie nie zawsze działa na Linuksie
- Na Windowsie może być konieczna instalacja [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Uprawnienia na ms-windows są trochę dziwne
  - Może być konieczne uruchomienie programu jako administrator, jeśli napotkasz problemy z kopiowaniem elementów lub podobne
- Może wystąpić problem wymagający instalacji openssl1.1 na systemach linux, jeśli program się nie uruchamia

## 📝 Zadania do wykonania:
- Wiele języków
- Ulubione
- Dostęp do usług przechowywania online (Google Drive, itp.)

## Interfejs użytkownika
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## Jak współtworzyć
Skonfiguruj swoją maszynę do tworzenia aplikacji tauri v1: [Wymagania wstępne Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Gdy to zrobisz, po prostu wykonaj ```git clone https://github.com/RickyDane/CoDriver``` lub ```gh repo clone RickyDane/CoDriver``` w wybranej lokalizacji na swoim komputerze.
</br></br>
Powinieneś móc uruchomić ```cargo tauri dev``` w katalogu głównym tego projektu, aby rozpocząć budowę i uruchamianie CoDriver.
</br>
Upewnij się, że masz zainstalowany tauri-cli: ```cargo install tauri-cli```
</br>

## Podpisywanie wydania

Artefakty wydania na macOS muszą być podpisane i poświadczone, aby uniknąć sytuacji, w której Gatekeeper zgłasza, że zainstalowana aplikacja jest uszkodzona. Zobacz [podpisywanie i poświadczanie macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) dla wymaganych sekretów GitHub Actions oraz poleceń weryfikacyjnych.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---