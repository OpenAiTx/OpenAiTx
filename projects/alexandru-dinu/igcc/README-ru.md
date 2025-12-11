
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# Интерактивный GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> Оригинальный репозиторий от Andy Balaam находится здесь: https://codeberg.org/andybalaam/igcc.
> В этой ветке я провёл рефакторинг и попытался сделать использование проще.

> [!WARNING]
> Этот проект — это кустарная попытка сократить цикл обратной связи при работе с C/C++ в некоторых случаях, и, очевидно, не предназначен для серьёзного применения.

Интерактивный GCC (`igcc`) — это цикл чтения-вычисления-вывода (REPL) для C/C++. Он работает путём модификации базового исходного файла по пользовательским командам, компилирует исходник после каждого изменения, затем выполняет полученный бинарник и собирает его stdout и stderr.
Поддерживается многострочный (блочный) ввод, так что вы можете добавить несколько строк за раз и вызвать компилятор только один раз (примеры ниже).

Вы можете подключать различные заголовочные файлы. Для удобства по умолчанию подключается заголовок [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Также `using namespace std;` по умолчанию недоступно, но вы можете явно добавить его (пример ниже).

Различные аспекты `igcc` можно настраивать, см. [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Начало работы
Самый простой способ начать — использовать [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
В качестве альтернативы, вы также можете использовать `uv`:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
А для разработчика:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Доступные аргументы:
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

Код будет скомпилирован с помощью GCC (`g++`), и результаты (если таковые имеются) будут отображены.
Введите `.h` для справки:
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

## Примеры
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

Поддерживается **многострочный ввод** (см. `multiline_marker` в конфигурации). Преимущество — избегание множественных вызовов компилятора.
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
Вы можете включать заголовки:

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
Библиотеки можно подключать:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
Вы также можете **отменить** команды:

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

... или **повторить** ранее отменённые команды:
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

## Будущая работа
См. https://github.com/alexandru-dinu/igcc/issues

## Похожие проекты
- https://github.com/BenBrock/reple: REPL с "воспроизведением" для компилируемых языков
- https://github.com/root-project/cling: Интерпретатор C++ cling


## Благодарности
- [Домашняя страница IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [Страница IGCC на Sourceforge](http://sourceforge.net/projects/igcc/)
- [Домашняя страница Энди Балаама](http://www.artificialworlds.net)
- [Блог Энди Балаама](http://www.artificialworlds.net/blog)
- Связаться с Энди Балаамом можно по адресу axis3x3 на users точка sourceforge точка net
- IGCC © 2009 Энди Балаам
- IGCC — свободное ПО, распространяемое на условиях версии 3 GNU General Public License
- IGCC ПОСТАВЛЯЕТСЯ БЕЗ КАКИХ-ЛИБО ГАРАНТИЙ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---