<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <h1>Inżynier Oprogramowania</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="status pre-commit">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="Ostatni commit">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="Zgłoszenia">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="Pull Requesty">
  </p>
</div>

Starannie wyselekcjonowana, wysokiej jakości kolekcja materiałów edukacyjnych skoncentrowanych na **Pythonie** oraz wkrótce **C/C++**, zaprojektowana, by budować solidne podstawy inżynierii oprogramowania i zrozumienie na poziomie systemowym.

## Struktura repozytorium

```text
.
├── python-basic/           # Essential Python syntax, data types, and operations
├── python-advanced/        # Decorators, threading, logging, JSON, and more
├── python-OOP/             # Deep dive into Python's object-oriented programming
├── cpp-basic/              # Fundamentals of C++: syntax, memory, pointers, etc.
├── cpp-advanced/           # Advanced C++: RAII, noexcept, smart pointers, RVO, etc.
├── cpp-OOP/                # Object-oriented programming in C++
├── CUDA/                   # GPU programming with CUDA (host & device code)
├── MPI/                    # Message Passing Interface programming and demos
├── docs/                   # System-level notes on performance, Python-C++ interop, mixed precision, etc.
└── README.md               # Project overview (this file)
```
## Jak używać

Każdy ponumerowany folder zawiera plik `README.md` wyjaśniający koncepcje oraz uruchamialne pliki `.py`. Na przykład:


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
Niektóre skrypty wymagają bibliotek zewnętrznych (np. `numpy`, `scipy`, `torch`).

Cały kod jest kompatybilny z **Python 3.7+** i napisany tak, aby był **minimalny, skoncentrowany i testowalny**.

## Najważniejsze cechy

### Python

- **Mistrzostwo OOP**: Klasy, dziedziczenie, metaklasy, deskryptory (`python-OOP/`)
- **Zaawansowane zagadnienia**: Dekoratory, menedżery kontekstu, cache funkcji, współbieżność
- **Struktury danych**: Listy, krotki, słowniki, zbiory z praktycznym zastosowaniem

### C++

- **Podstawy C++**: Składnia, funkcje, wskaźniki, struktury, zakres, wyliczenia (`cpp-basic/`)
- **Nowoczesny C++**: RAII, inteligentne wskaźniki, semantyka przenoszenia, wyrównanie, RVO (`cpp-advanced/`)
- **C++ OOP**: Klasy, specyfikatory dostępu, dziedziczenie, polimorfizm, szablony

### Systemy i wydajność

- **Programowanie CUDA**: Model host/urządzenie, uruchamianie kerneli, zarządzanie pamięcią (`CUDA/`)
- **Programowanie MPI**: Praktyczne programy rozproszone, operacje na macierzach, walidacja (`MPI/`)
- **Dokumentacja**: Interfejsowanie Python-C++, obsługa GIL, tuning CUDA, trening z mieszana precyzją (`docs/`)

## Filozofia nauki

- Małe, modułowe przykłady — bez przeładowanych notebooków
- Wyraźny podział na koncepcję, kod i komentarz
- Nacisk na projektowanie, wydajność i łatwość utrzymania
- Stopniowe budowanie wiedzy — idealne dla ambitnych uczniów i profesjonalistów

## Historia gwiazdek

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 Wkład

Znalazłeś błąd, literówkę lub chcesz coś rozbudować? Otwórz PR — każdy wkład jest mile widziany.

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 Licencja

Licencja MIT — możesz swobodnie używać, adaptować i dzielić się w celach nauki i nauczania.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---