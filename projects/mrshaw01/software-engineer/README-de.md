<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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
  <h1>Softwareentwickler</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="pre-commit status">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="Letzter Commit">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="Probleme">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="Pull Requests">
  </p>
</div>

Eine kuratierte, hochwertige Sammlung von Lernressourcen mit Schwerpunkt auf **Python** und bald auch **C/C++**, konzipiert, um solide Softwareentwicklungsgrundlagen und Systemverständnis zu vermitteln.

## Repository-Struktur

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
## Verwendung

Jeder nummerierte Ordner enthält eine `README.md`, die die Konzepte erklärt, sowie ausführbare `.py`-Dateien. Zum Beispiel:


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
Einige Skripte erfordern Drittanbieter-Bibliotheken (z. B. `numpy`, `scipy`, `torch`).

Der gesamte Code ist mit **Python 3.7+** kompatibel und wurde **minimal, fokussiert und testbar** geschrieben.

## Highlights

### Python

- **OOP-Beherrschung**: Klassen, Vererbung, Metaklassen, Deskriptoren (`python-OOP/`)
- **Fortgeschrittene Themen**: Dekoratoren, Kontextmanager, Funktions-Caching, Nebenläufigkeit
- **Datenstrukturen**: Listen, Tupel, Dicts, Sets mit praxisnaher Anwendung

### C++

- **C++-Grundlagen**: Syntax, Funktionen, Zeiger, Structs, Gültigkeitsbereich, Enums (`cpp-basic/`)
- **Modernes C++**: RAII, Smart Pointer, Move Semantik, Alignment, RVO (`cpp-advanced/`)
- **C++ OOP**: Klassen, Zugriffsspezifizierer, Vererbung, Polymorphismus, Templates

### Systeme & Performance

- **CUDA-Programmierung**: Host/Device-Modell, Kernel-Start, Speicherverwaltung (`CUDA/`)
- **MPI-Programmierung**: Praktische verteilte Programme, Matrixoperationen und Validierungsläufe (`MPI/`)
- **Dokus**: Python-C++-Schnittstellen, GIL-Handhabung, CUDA-Optimierung, Mixed-Precision-Training (`docs/`)

## Lernphilosophie

- Kleine, modulare Beispiele — keine überladenen Notebooks
- Klare Trennung zwischen Konzept, Code und Kommentar
- Fokus auf Design, Performance und Wartbarkeit
- Baut Wissen schrittweise auf — ideal für ernsthafte Lernende und Profis

## Sternverlauf

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 Beiträge

Fehler gefunden, Tippfehler entdeckt oder möchtest du etwas erweitern? Öffne einen PR — alle Beiträge sind willkommen.

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 Lizenz

MIT-Lizenz — frei zur Nutzung, Anpassung und Weitergabe für Lern- und Lehrzwecke.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---