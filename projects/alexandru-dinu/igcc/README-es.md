# GCC Interactivo

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> El repositorio original de Andy Balaam está aquí: https://codeberg.org/andybalaam/igcc.
> En este fork, he hecho algo de refactorización y tratado de hacerlo más fácil de usar.

> [!WARNING]
> Este proyecto es un intento improvisado de obtener un ciclo de retroalimentación más corto al trabajar con C/C++ en algunos casos y obviamente no está destinado a nada serio.

GCC interactivo (`igcc`) es un bucle de lectura-evaluación-impresión (REPL) para C/C++. Funciona manipulando un archivo base de código fuente con comandos del usuario, compila el código después de cada modificación, luego ejecuta el binario resultante y recoge su stdout y stderr.
Se soporta entrada multilínea (bloques), por lo que puedes añadir varias líneas de una vez e invocar el compilador solo una vez (ejemplos abajo).

Puedes incluir varios archivos de cabecera. Para conveniencia, se incluye un encabezado por defecto: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Además, `using namespace std;` no está disponible por defecto, pero puedes añadirlo explícitamente (ejemplo abajo).

Se pueden configurar varios aspectos de `igcc`, consulta [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Comenzando
La forma más sencilla de comenzar es usar [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Alternativamente, también puedes usar `pip` (se recomienda un entorno virtual dedicado).

Ahora puedes ejecutar el REPL con:
```
igcc
```

Argumentos disponibles:
```
$ igcc --help
usage: igcc [-h] [-I INCLUDE [INCLUDE ...]] [-L LIBDIR [LIBDIR ...]] [-l LIB [LIB ...]]

options:
  -h, --help            show this help message and exit
  -I INCLUDE [INCLUDE ...]
                        Add INCLUDE to the list of directories to be searched for header files.
  -L LIBDIR [LIBDIR ...]
                        Add LIBDIR to the list of directories to be searched for library files.
  -l LIB [LIB ...]      Search the library LIB when linking.
```

El código se compilará con GCC (`g++`) y se mostrarán los resultados (si los hay).
Escriba `.h` para obtener ayuda:

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

## Ejemplos
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
**La entrada de varias líneas** es compatible (ver `multiline_marker` en la configuración). El beneficio es evitar múltiples llamadas al compilador.

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

Puede incluir encabezados:
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

Las bibliotecas pueden ser enlazadas:
```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

También puedes **deshacer** comandos:
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

... o **rehacer** comandos previamente deshechos:
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

## Trabajo futuro
Vea https://github.com/alexandru-dinu/igcc/issues

## Proyectos similares
- https://github.com/BenBrock/reple: REPLs "basados en repetición" para lenguajes compilados
- https://github.com/root-project/cling: El intérprete de C++ cling


## Créditos
- [Página principal de IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [Página de IGCC en Sourceforge](http://sourceforge.net/projects/igcc/)
- [Página principal de Andy Balaam](http://www.artificialworlds.net)
- [Blog de Andy Balaam](http://www.artificialworlds.net/blog)
- Se puede contactar a Andy Balaam en axis3x3 en usuarios punto sourceforge punto net
- IGCC es Copyright (C) 2009 Andy Balaam
- IGCC es Software Libre publicado bajo los términos de la Licencia Pública General GNU versión 3
- IGCC se entrega SIN GARANTÍA


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---