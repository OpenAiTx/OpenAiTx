
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# Interaktywny GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> Oryginalne repozytorium Andy Balaam znajduje się tutaj: https://codeberg.org/andybalaam/igcc.
> W tym fork'u przeprowadziłem refaktoryzację i starałem się uczynić go łatwiejszym w użyciu.

> [!WARNING]
> Ten projekt to prowizoryczna próba uzyskania krótszej pętli sprzężenia zwrotnego przy pracy z C/C++ w niektórych przypadkach i oczywiście nie jest przeznaczony do niczego poważnego.

Interaktywny GCC (`igcc`) to pętla odczyt-ewaluacja-wydruk (REPL) dla C/C++. Działa poprzez modyfikowanie bazowego pliku źródłowego za pomocą poleceń użytkownika, kompiluje źródło po każdej modyfikacji, następnie wykonuje powstały plik binarny i zbiera jego stdout oraz stderr.
Obsługiwane jest wejście wieloliniowe (blokowe), dzięki czemu możesz dodać wiele linii na raz i wywołać kompilator tylko raz (przykłady poniżej).

Możesz dołączać różne pliki nagłówkowe. Dla wygody domyślnie dołączany jest nagłówek: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Ponadto `using namespace std;` nie jest domyślnie dostępne, ale możesz jawnie je dodać (przykład poniżej).

Różne aspekty `igcc` można konfigurować, zobacz [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Pierwsze kroki
Najłatwiejszym sposobem na rozpoczęcie jest użycie [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Alternatywnie, możesz również użyć `uv`:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
A dla dewelopera:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Dostępne argumenty:
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

Kod zostanie skompilowany za pomocą GCC (`g++`), a wyniki (jeśli wystąpią) zostaną wyświetlone.
Wpisz `.h`, aby uzyskać pomoc:
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

## Przykłady
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

Obsługa **wieloliniowego wejścia** jest dostępna (sprawdź `multiline_marker` w konfiguracji). Zaleta to unikanie wielokrotnych wywołań kompilatora.
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
Możesz dołączyć nagłówki:

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
Biblioteki mogą być łączone:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
Możesz także **cofnąć** polecenia:

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

... lub **ponów** wcześniej cofnięte polecenia:
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

## Przyszłe prace
Zobacz https://github.com/alexandru-dinu/igcc/issues

## Podobne projekty
- https://github.com/BenBrock/reple: REPL-e oparte na "Replay" dla języków kompilowanych
- https://github.com/root-project/cling: Interpretor C++ cling


## Podziękowania
- [Strona domowa IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [Strona IGCC na Sourceforge](http://sourceforge.net/projects/igcc/)
- [Strona domowa Andy Balaama](http://www.artificialworlds.net)
- [Blog Andy Balaama](http://www.artificialworlds.net/blog)
- Andy Balaam może być kontaktowany pod adresem axis3x3 na users kropka sourceforge kropka net
- IGCC Copyright (C) 2009 Andy Balaam
- IGCC jest Wolnym Oprogramowaniem wydanym na zasadach GNU General Public License wersja 3
- IGCC NIE ZAWIERA ŻADNEJ GWARANCJI


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---