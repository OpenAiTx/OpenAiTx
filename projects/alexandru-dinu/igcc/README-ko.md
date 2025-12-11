
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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

# 인터랙티브 GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> Andy Balaam의 원본 저장소는 다음에서 확인할 수 있습니다: https://codeberg.org/andybalaam/igcc.
> 이 포크에서는 일부 리팩토링을 진행하여 사용하기 쉽게 만들려고 했습니다.

> [!WARNING]
> 이 프로젝트는 C/C++ 작업 시 일부 상황에서 더 짧은 피드백 루프를 얻기 위한 해키(hacky)한 시도이며, 명백히 중요한 용도로 사용하기 위한 것은 아닙니다.

Interactive GCC(`igcc`)는 C/C++용 읽기-평가-출력 루프(REPL)입니다. 사용자 명령으로 기본 소스 파일을 조작하고, 각 변경 후 소스를 컴파일한 다음 생성된 바이너리를 실행하여 stdout 및 stderr을 수집합니다.
다중 줄(블록) 입력을 지원하므로 여러 줄을 한 번에 추가하고 컴파일러를 한 번만 호출할 수 있습니다(아래 예시 참고).

다양한 헤더 파일을 포함할 수 있습니다. 편의를 위해 기본 헤더가 포함되어 있습니다: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). 또한, `using namespace std;`는 기본적으로 제공되지 않으나, 명시적으로 추가할 수 있습니다(아래 예시 참고).

`igcc`의 다양한 측면을 구성할 수 있습니다. 자세한 내용은 [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml)을 참조하십시오.

## 시작하기
가장 쉬운 시작 방법은 [pipx](https://pipx.pypa.io/stable/)를 사용하는 것입니다:
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
또는, `uv`를 사용할 수도 있습니다:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
그리고 개발용:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

사용 가능한 인수:
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

코드는 GCC(`g++`)로 컴파일되며, 결과(있는 경우)가 표시됩니다.
도움말을 보려면 `.h`를 입력하세요:
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

## 예제
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

**멀티라인 입력**이 지원됩니다 (`multiline_marker`를 구성에서 확인). 이점은 여러 번의 컴파일러 호출을 피하는 것입니다.
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

헤더를 포함할 수 있습니다:
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

라이브러리를 연결할 수 있습니다:
```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
명령을 **실행 취소**할 수도 있습니다:

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

... 또는 이전에 취소한 명령을 **다시 실행**합니다:
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
## 향후 작업
https://github.com/alexandru-dinu/igcc/issues 를 참조하세요

## 유사 프로젝트
- https://github.com/BenBrock/reple: 컴파일된 언어용 "리플레이 기반" REPL
- https://github.com/root-project/cling: cling C++ 인터프리터


## 크레딧
- [IGCC 홈 페이지](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC 소스포지 페이지](http://sourceforge.net/projects/igcc/)
- [Andy Balaam의 홈 페이지](http://www.artificialworlds.net)
- [Andy Balaam의 블로그](http://www.artificialworlds.net/blog)
- Andy Balaam는 axis3x3 at users dot sourceforge dot net에서 연락할 수 있습니다
- IGCC는 2009년 Andy Balaam의 저작권입니다
- IGCC는 GNU 일반 공중 사용 허가서 버전 3 조항에 따라 배포되는 자유 소프트웨어입니다
- IGCC는 보증이 없습니다



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---