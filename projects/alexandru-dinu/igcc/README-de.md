
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Interaktives GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!HINWEIS]
> Das Original-Repository von Andy Balaam ist hier: https://codeberg.org/andybalaam/igcc.
> In diesem Fork habe ich einige Refaktorierungen vorgenommen und versucht, die Nutzung zu erleichtern.

> [!WARNUNG]
> Dieses Projekt ist ein hackiger Versuch, in bestimmten Fällen eine kürzere Feedback-Schleife beim Arbeiten mit C/C++ zu erreichen, und ist offensichtlich nicht für ernsthafte Einsätze gedacht.

Das Interactive GCC (`igcc`) ist eine Read-Eval-Print-Loop (REPL) für C/C++. Es funktioniert, indem eine Basis-Quelldatei mit Benutzerbefehlen manipuliert wird, kompiliert die Quelle nach jeder Änderung, führt das resultierende Binary aus und sammelt dessen stdout & stderr.
Mehrzeilige (Block-)Eingaben werden unterstützt, sodass Sie mehrere Zeilen auf einmal hinzufügen und den Compiler nur einmal aufrufen können (siehe Beispiele unten).

Sie können verschiedene Header-Dateien einbinden. Der Einfachheit halber ist ein Standard-Header enthalten: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Außerdem ist `using namespace std;` standardmäßig nicht verfügbar, kann aber explizit hinzugefügt werden (siehe Beispiel unten).

Verschiedene Aspekte von `igcc` können konfiguriert werden, siehe [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Erste Schritte
Der einfachste Weg, um loszulegen, ist die Verwendung von [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Alternativ können Sie auch `uv` verwenden:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
Und für Entwickler:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Verfügbare Argumente:
<!-- MDUP:BEG uv run igcc --help -->
```
usage: igcc [-h] [-I INCLUDE [INCLUDE ...]] [-L LIBDIR [LIBDIR ...]]
            [-l LIB [LIB ...]]

options:
  -h, --help            show this help message and exit
  -I INCLUDE [INCLUDE ...]
                        Add INCLUDE to the list of directories to be searched
                        for header files.
  -L LIBDIR [LIBDIR ...]
                        Add LIBDIR to the list of directories to be searched
                        for library files.
  -l LIB [LIB ...]      Search the library LIB when linking.
```
<!-- MDUP:END -->

Der Code wird mit GCC (`g++`) kompiliert und die Ergebnisse (sofern vorhanden) werden angezeigt.
Geben Sie `.h` für Hilfe ein:
```
$ igcc
[1]> .h
.h  Show this help message
.e  Show the last compile errors/warnings
.l  List the code you have entered
.L  List the whole program as given to the compiler
.r  Redo undone command
.u  Undo previous command
.q  Quit
```

## Beispiele
```
$ igcc
[1]> int a = 5;
[2]> a += 2;
[3]> using namespace std;
[4]> cout << a << endl;
7

[5]> int b = 17;
[6]> a *= b;
[7]> cout << a << ", " << b << endl;
119, 17

[8]> .L
#include "boilerplate.h"
using namespace std;

int main(void) {
    int a = 5;
    a += 2;
    cout << a << endl;
    int b = 17;
    a *= b;
    cout << a << ", " << b << endl;

    return 0;
}
```

**Mehrzeilige Eingabe** wird unterstützt (siehe `multiline_marker` in der Konfiguration). Der Vorteil besteht darin, mehrere Compileraufrufe zu vermeiden.
```
$ igcc
[1]> .m
... for (int i = 0; i < 10; i++) {
...   std::cout << i << " ";
... }
... std::cout << "\n";
... .m
0 1 2 3 4 5 6 7 8 9
```
Sie können Kopfzeilen einfügen:

```
$ igcc
[1]> #include <vector>
[2]> std::vector<int> xs{1,2,3};
[3]> xs.push_back(17);
[4]> .m
... for (auto x : xs) {
...   std::cout << x << " ";
... }
... .m
1 2 3 17
```
Bibliotheken können gelinkt werden:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

Sie können Befehle auch **rückgängig machen**:
```
$ igcc
[1]> int x = 2
 Compile error - type .e to see it

[2]> .e
<stdin>: In function ‘int main()’:
<stdin>:7:5: error: expected ‘,’ or ‘;’ before ‘return’
<stdin>:5:9: warning: unused variable ‘x’ [-Wunused-variable]

[2]> .u
Undone `int x = 2`
[1]> int x = 2;
[2]> .L
#include "boilerplate.h"


int main(void) {
    int x = 2;

    return 0;
}
```

... oder **wiederholen** zuvor rückgängig gemachte Befehle:
```
$ igcc
[1]> int x = 2;
[2]> std::cout << x;
2
[3]> .u
Undone `std::cout << x;`
[2]> .L
#include "boilerplate.h"


int main(void) {
    int x = 2;

    return 0;
}
[2]> .r
Redone `std::cout << x;`
2
[3]> .L
#include "boilerplate.h"


int main(void) {
    int x = 2;
    std::cout << x;

    return 0;
}
```

## Zukünftige Arbeiten
Siehe https://github.com/alexandru-dinu/igcc/issues

## Ähnliche Projekte
- https://github.com/BenBrock/reple: "Replay-basierte" REPLs für kompilierte Sprachen
- https://github.com/root-project/cling: Der cling C++ Interpreter


## Danksagungen
- [IGCC-Homepage](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge-Seite](http://sourceforge.net/projects/igcc/)
- [Andy Balaams Homepage](http://www.artificialworlds.net)
- [Andy Balaams Blog](http://www.artificialworlds.net/blog)
- Andy Balaam ist erreichbar unter axis3x3 at users dot sourceforge dot net
- IGCC ist Copyright (C) 2009 Andy Balaam
- IGCC ist Freie Software, veröffentlicht unter den Bedingungen der GNU General Public License Version 3
- IGCC wird OHNE JEGLICHE GARANTIE bereitgestellt


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---