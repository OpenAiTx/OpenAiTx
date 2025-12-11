<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

# GCC Interativo

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTA]
> O repositório original de Andy Balaam está aqui: https://codeberg.org/andybalaam/igcc.

> Neste fork, fiz algumas refatorações e tentei torná-lo mais fácil de usar.

> [!AVISO]
> Este projeto é uma tentativa improvisada de obter um ciclo de feedback mais curto ao trabalhar com C/C++ em alguns casos e obviamente não é destinado a nada sério.

O GCC Interativo (`igcc`) é um loop de leitura-avaliação-impressão (REPL) para C/C++. Ele funciona manipulando um arquivo fonte base com comandos do usuário, compila o fonte após cada modificação, depois executa o binário resultante e coleta sua saída stdout & stderr.
A entrada multilinha (em bloco) é suportada, então você pode adicionar múltiplas linhas de uma vez e invocar o compilador apenas uma vez (exemplos abaixo).

Você pode incluir vários arquivos de cabeçalho. Para conveniência, um cabeçalho padrão é incluído: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Além disso, `using namespace std;` não está disponível por padrão, mas você pode adicioná-lo explicitamente (exemplo abaixo).

Vários aspectos do `igcc` podem ser configurados, veja [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Primeiros passos
A maneira mais fácil de começar é usando o [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Alternativamente, você também pode usar o `uv`:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
E para desenvolvimento:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Argumentos disponíveis:
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

O código será compilado com GCC (`g++`) e os resultados (se houver) serão exibidos.
Digite `.h` para ajuda:
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

## Exemplos
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

**Entrada multilinha** é suportada (verifique `multiline_marker` na configuração). O benefício é evitar múltiplas chamadas ao compilador.
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
Você pode incluir cabeçalhos:

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
Bibliotecas podem ser vinculadas:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
Você também pode **desfazer** comandos:

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

... ou **refazer** comandos previamente desfeitos:
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

## Trabalhos futuros
Veja https://github.com/alexandru-dinu/igcc/issues

## Projetos similares
- https://github.com/BenBrock/reple: REPLs "baseados em replay" para linguagens compiladas
- https://github.com/root-project/cling: O interpretador cling para C++


## Créditos
- [Página inicial do IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [Página do IGCC no Sourceforge](http://sourceforge.net/projects/igcc/)
- [Página inicial de Andy Balaam](http://www.artificialworlds.net)
- [Blog de Andy Balaam](http://www.artificialworlds.net/blog)
- Andy Balaam pode ser contatado em axis3x3 at users dot sourceforge dot net
- IGCC é Copyright (C) 2009 Andy Balaam
- IGCC é Software Livre lançado sob os termos da Licença Pública Geral GNU versão 3
- IGCC NÃO POSSUI QUALQUER GARANTIA


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---