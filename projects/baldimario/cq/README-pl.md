
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Wydajny silnik zapytań SQL dla plików CSV

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Lekki, szybki procesor zapytań SQL napisany w C, umożliwiający wykonywanie zapytań SQL bezpośrednio na plikach CSV bez potrzeby używania bazy danych. Pełna dokumentacja znajduje się w katalogu /doc.

 ![cq w działaniu](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Dokumentacja

- Pierwsze kroki: `doc/GettingStarted.md`
- Instalacja: `doc/Installation.md`
- Interfejs wiersza poleceń: `doc/CLI.md`
- **TUI (Interfejs Użytkownika Terminala)**: `doc/TUI.md`
- Architektura: `doc/Architecture.md`
- Testowanie: `doc/Testing.md`
- Plan rozwoju: `doc/Roadmap.md`
- Współpraca: `doc/Contributing.md`

## Szybki start

Budowanie: `make`

### Wiersz poleceń

Uruchom przykładowe zapytanie:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Terminal UI

Uruchom interaktywny TUI:
`./build/cqtui data/`

Funkcje:
- Przeglądanie i otwieranie plików CSV jako tabel
- Interaktywne wykonywanie zapytań SQL
- Interfejs z wieloma kartami dla wielu tabel
- Nawigacja za pomocą klawiatury
- Brak zewnętrznych zależności

## Przykładowe pliki SQL

Repozytorium zawiera przykładowe pliki SQL w katalogu assets/ (example_between.sql, example_aggregation.sql itp.). Szczegóły w assets/.

## Przegląd danych i funkcji

- Szczegółowe sekcje dotyczące typów danych, formatów dat, formatu CSV i innych znajdują się w folderze /doc.

## Licencja

Licencja MIT. Szczegóły w pliku LICENSE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---