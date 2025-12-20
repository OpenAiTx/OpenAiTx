
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![Wersja testowa](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![Licencja: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![Wspierane kompilatory](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)
[![Zapytaj DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/till213/SkyDolly)
![Testy jednostkowe](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - Czarna owca dla Twoich nagrań lotów.

## O programie
Sky Dolly łączy się z uruchomioną instancją Flight Simulator 2020 i rejestruje różne zmienne symulacji, do odtwarzania.

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

Połączenie odbywa się za pomocą SimConnect, standardowego API wprowadzonego wraz z Flight Simulator X do łączenia z symulatorem lotu.

Zobacz także [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md).

## Funkcje
- Nagrywanie / Pauza / Odtwarzanie
- Loty w formacji (wiele samolotów, odtwarzanie podczas nagrywania, "lot z formacją", przesunięcie czasowe)
- Ustawialna częstotliwość próbkowania nagrania: stała lub zmienna ("auto")
- Regulowana prędkość odtwarzania ("zwolnione tempo", "timelapse"), pętla odtwarzania
- Pozycja, prędkość i podstawowe zmienne sterowania lotem (lotki, ster kierunku, klapy, podwozie, ...) są rejestrowane
- Architektura wtyczek z różnymi wtyczkami importu/eksportu (CSV, GPX, IGC, KML)
- Moduł lokalizacji z ponad 100 domyślnymi lokalizacjami oraz funkcją importu/eksportu
- Trwałość oparta na bazie danych (SQLite) ("dziennik lotów")

Obejrzyj zwiastun (preview) wydania na [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I):

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Więcej filmów stworzonych za pomocą Sky Dolly znajdziesz także w [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md). Nowe i nadchodzące funkcje znajdują się w [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md).

## Podstawowe użycie

- Rozpocznij lot
- Kliknij "Nagrywaj" (klawisz R)
- Możesz wstrzymać nagrywanie (klawisz P)
- Zatrzymaj nagrywanie (klawisz R) i kliknij "Odtwórz" (spacja)
- Dostosuj prędkość odtwarzania i wybierz pozycję odtwarzania także podczas odtwarzania
- Nagrania lotów są automatycznie zapisywane w "dzienniku lotów"
- Wybierz lot w dzienniku lotów i naciśnij "Załaduj" (lub kliknij dwukrotnie wiersz), aby załadować zapisany lot

### Nagrywanie i odtwarzanie lotów w formacji

#### Nagrywanie

- Przełącz się do modułu "Formacja" (klawisz F2)
- Kliknij "Nagrywaj" (klawisz R)
- Każdy nagrany samolot zostaje dodany do bieżącego lotu
- Podczas odtwarzania istniejących samolotów z "automatyczną" częstotliwością próbkowania nadal możesz zmienić częstotliwość próbkowania nagrania

#### Pozycja

- Ostatnio nagrany samolot staje się "samolotem użytkownika" (śledzonym przez kamerę w symulatorze lotu)
- Wybierz pozycję względem bieżącego "samolotu użytkownika" przed nagrywaniem

#### Odtwarzanie

- Po prostu kliknij "Odtwórz", "Pauza" i przewijaj linię czasu, tak jak w przypadku lotu pojedynczego samolotu
- Zmień "samolot użytkownika" (również podczas odtwarzania), aby "przeskakiwać z kokpitu do kokpitu"
- Przejmij kontrolę nad "samolotem użytkownika", wybierając opcję "Przejmij kontrolę" lub "Lataj z formacją"

#### Zarządzanie formacjami

- Możesz usunąć pojedyncze samoloty z lotu ("formacji")
- Musi być co najmniej jeden samolot na lot, więc ostatni samolot nie może zostać usunięty
- Dodaj przesunięcie czasowe do wybranego samolotu ("synchronizacja lotów formacji multiplayer")
- Aby rozpocząć nowy lot pojedynczym samolotem, wróć do modułu "Dziennik lotów" (klawisz F1) i kliknij "Nagrywaj" (klawisz R)

Dlaczego nie spróbujesz jednej z prowadzonych ["Tell Tours"](https://github.com/till213/Tell-Tours)? :)

## Pobierz

Przejdź do [Wydania](https://github.com/till213/SkyDolly/releases) i pobierz najnowsze wydanie.

Najnowsze (pre-)wydanie: **Sky Dolly 0.19.2**

Oblicz i porównaj swój sum kontrolny z [opublikowanymi sumami SHA-256](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md), aby zweryfikować integralność pobranej kopii.

## Budowanie

Zapoznaj się z dokumentacją [BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md).

## Powiązane projekty

- https://github.com/nguyenquyhy/Flight-Recorder - Aplikacja do nagrywania i odtwarzania lotów oparta na .Net
- https://github.com/saltysimulations/saltyreplay/ - Nagrywanie i odtwarzanie z interfejsem webowym
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - Rejestruje lot i generuje "powtórki" w formacie KML dla Google Earth
- https://github.com/Elephant42/FS_Tool - Proste narzędzie pozwalające ustawić lokalizację samolotu i tempo symulacji
- https://github.com/pyviator/msfs-geoshot - Wykonuje zrzuty ekranu i automatycznie je "geotaguje"
- https://github.com/ijl20/msfs_logger_replay - Rejestrator IGC i odtwarzanie (dla FSX)
- https://joinfs.net/ - Umożliwia synchronizację lotów wieloosobowych między różnymi symulatorami lotu (MSFS, Prepar3D/FSX, XPlane). Zapewnia także rejestrator lotów z nagrywaniem lotów w formacji ("overdub").
- https://github.com/paulalexandrow/a32nx-webremote - WebRemote dla FlyByWire A32NX: sterowanie funkcjami kokpitu FBW A320 z użyciem FSUIPC7
- https://flightloganalyzer.com/ - FlightLog Analyzer analizuje dziennik lotów MSFS i umożliwia eksport CSV czytany przez Sky Dolly
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSave automatycznie (lub na żądanie) zapisuje plany lotów
- https://github.com/mracko/MSFS-Landing-Inspector - Analizuje jakość lądowania
- [Punkty zainteresowania (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Punkty zainteresowania, lotniska i miasta 3D w Microsoft Flight Simulator.

## Inne przydatne zasoby

- https://obsproject.com/ - Aplikacja do nagrywania ekranu / transmisji
- https://sqlitebrowser.org/ - Przeglądaj pliki bazy danych dziennika Sky Dolly (*.sdlog), wykonuj własne zapytania SQL


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-20

---