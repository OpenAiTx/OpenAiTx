
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
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

# GCC Interactif

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> Le dépôt original d’Andy Balaam se trouve ici : https://codeberg.org/andybalaam/igcc.
> Dans ce fork, j'ai effectué quelques refactorisations et essayé de le rendre plus facile à utiliser.

> [!AVERTISSEMENT]
> Ce projet est une tentative bricolée pour obtenir une boucle de rétroaction plus courte lors du travail avec C/C++ dans certains cas, et il n'est évidemment pas destiné à un usage sérieux.

GCC interactif (`igcc`) est une boucle read-eval-print (REPL) pour C/C++. Il fonctionne en manipulant un fichier source de base via les commandes utilisateur, compile la source après chaque modification, puis exécute le binaire résultant et collecte sa sortie standard et son erreur standard.
L'entrée multi-lignes (bloc) est prise en charge, vous pouvez donc ajouter plusieurs lignes d'un coup et invoquer le compilateur une seule fois (exemples ci-dessous).

Vous pouvez inclure divers fichiers d'en-tête. Pour plus de commodité, un en-tête par défaut est inclus : [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). De plus, `using namespace std;` n'est pas disponible par défaut, mais vous pouvez l'ajouter explicitement (exemple ci-dessous).

Divers aspects de `igcc` peuvent être configurés, voir [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Pour commencer
La façon la plus simple de commencer est d'utiliser [pipx](https://pipx.pypa.io/stable/) :
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Vous pouvez également utiliser `uv` :
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
Et pour le développement :
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Arguments disponibles :
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

Le code sera compilé avec GCC (`g++`) et les résultats (le cas échéant) seront affichés.
Tapez `.h` pour obtenir de l'aide :
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
## Exemples

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
**L'entrée multi-lignes** est prise en charge (vérifiez `multiline_marker` dans la configuration). L'avantage est d'éviter plusieurs appels au compilateur.

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
Vous pouvez inclure des en-têtes :

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

Les bibliothèques peuvent être liées :
```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

Vous pouvez également **annuler** les commandes :
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

... ou **refaire** des commandes précédemment annulées :
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
## Travaux futurs
Voir https://github.com/alexandru-dinu/igcc/issues

## Projets similaires
- https://github.com/BenBrock/reple : REPL "basés sur la relecture" pour les langages compilés
- https://github.com/root-project/cling : L'interpréteur C++ cling

## Crédits
- [Page d'accueil IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [Page Sourceforge d'IGCC](http://sourceforge.net/projects/igcc/)
- [Page personnelle d'Andy Balaam](http://www.artificialworlds.net)
- [Blog d'Andy Balaam](http://www.artificialworlds.net/blog)
- Andy Balaam peut être contacté à axis3x3 chez users point sourceforge point net
- IGCC est Copyright (C) 2009 Andy Balaam
- IGCC est un logiciel libre publié sous les termes de la Licence Publique Générale GNU version 3
- IGCC est fourni SANS AUCUNE GARANTIE




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---