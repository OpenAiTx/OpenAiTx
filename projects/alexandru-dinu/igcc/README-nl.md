
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Interactieve GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!LET OP]
> De originele repo van Andy Balaam is hier: https://codeberg.org/andybalaam/igcc.
> In deze fork heb ik wat refactoring gedaan en geprobeerd het gebruiksgemak te vergroten.

> [!WAARSCHUWING]
> Dit project is een geïmproviseerde poging om een kortere feedbackloop te krijgen bij het werken met C/C++ in sommige gevallen en het is duidelijk niet bedoeld voor serieuze toepassingen.

Interactieve GCC (`igcc`) is een read-eval-print loop (REPL) voor C/C++. Het werkt door een basisbronbestand te manipuleren met gebruikerscommando's, compileert de bron na elke wijziging, voert het resulterende binaire bestand uit en verzamelt stdout & stderr.
Meerdere regels (blok) invoer worden ondersteund, zodat je meerdere regels tegelijk kunt toevoegen en de compiler slechts één keer hoeft aan te roepen (zie voorbeelden hieronder).

Je kunt verschillende headerbestanden includen. Voor het gemak is een standaardheader toegevoegd: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Ook is `using namespace std;` standaard niet beschikbaar, maar je kunt dit expliciet toevoegen (zie voorbeeld hieronder).

Verschillende aspecten van `igcc` kunnen worden geconfigureerd, zie [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Aan de slag
De makkelijkste manier om te beginnen is door [pipx](https://pipx.pypa.io/stable/) te gebruiken:
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Als alternatief kun je ook `uv` gebruiken:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
En voor ontwikkeling:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Beschikbare argumenten:
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
<!-- MDUP:EINDE -->

De code wordt gecompileerd met GCC (`g++`) en de resultaten (indien aanwezig) worden weergegeven.
Typ `.h` voor hulp:
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

## Voorbeelden
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

**Invoer op meerdere regels** wordt ondersteund (controleer `multiline_marker` in de configuratie). Het voordeel is dat meerdere aanroepen van de compiler worden vermeden.
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
Je kunt kopteksten opnemen:

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
Libs kunnen worden gelinkt:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
Je kunt ook opdrachten **ongedaan maken**:

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

... of **opnieuw uitvoeren** van eerder ongedaan gemaakte opdrachten:
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

## Toekomstig werk
Zie https://github.com/alexandru-dinu/igcc/issues

## Vergelijkbare projecten
- https://github.com/BenBrock/reple: "Replay-based" REPLs voor gecompileerde talen
- https://github.com/root-project/cling: De cling C++ interpreter


## Credits
- [IGCC startpagina](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge pagina](http://sourceforge.net/projects/igcc/)
- [Andy Balaam's startpagina](http://www.artificialworlds.net)
- [Andy Balaam's blog](http://www.artificialworlds.net/blog)
- Andy Balaam is bereikbaar via axis3x3 at users dot sourceforge dot net
- IGCC is Copyright (C) 2009 Andy Balaam
- IGCC is Vrije Software uitgebracht onder de voorwaarden van de GNU General Public License versie 3
- IGCC wordt geleverd ZONDER GARANTIE


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---