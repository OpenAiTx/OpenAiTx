# 交互式 GCC

[![测试](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![贡献](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![代码风格: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!注意]
> Andy Balaam 的原始仓库在这里：https://codeberg.org/andybalaam/igcc。
> 在此分支中，我做了一些重构并尝试使其更易使用。

> [!警告]
> 该项目是一个在某些情况下为 C/C++ 获得更短反馈循环的临时方案，显然不适用于任何严肃用途。

交互式 GCC (`igcc`) 是一个 C/C++ 的读-求值-输出循环（REPL）。它通过操作一个基础源文件及用户命令工作，在每次修改后编译源代码，然后执行生成的二进制文件并收集其标准输出和标准错误。
支持多行（块）输入，因此你可以一次添加多行并只调用一次编译器（下面有示例）。

你可以包含各种头文件。为了方便，默认包含了一个头文件：[`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h)。此外，默认不提供 `using namespace std;`，但你可以显式添加（下面有示例）。

`igcc` 的各个方面都可以配置，详见 [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml)。

## 快速入门
最简单的开始方式是使用 [pipx](https://pipx.pypa.io/stable/)：
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
或者，您也可以直接使用 `pip`（建议使用专用虚拟环境）。

现在您可以通过以下命令运行 REPL：
```
igcc
```

可用参数：
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
代码将使用 GCC（`g++`）编译，结果（如果有）将会显示。  
输入 `.h` 获取帮助：  


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

## 示例
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

**支持多行输入**（请检查配置中的 `multiline_marker`）。其优点是避免多次调用编译器。
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
你可以包含标题：

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

库可以被链接：
```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
您也可以**撤销**命令：

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

... 或 **重做** 之前撤销的命令：
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

## 未来工作
请参见 https://github.com/alexandru-dinu/igcc/issues

## 类似项目
- https://github.com/BenBrock/reple：“基于重放”的编译语言REPL
- https://github.com/root-project/cling：Cling C++解释器


## 致谢
- [IGCC 主页](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge 页面](http://sourceforge.net/projects/igcc/)
- [Andy Balaam 主页](http://www.artificialworlds.net)
- [Andy Balaam 博客](http://www.artificialworlds.net/blog)
- 可通过 axis3x3 ＠ users dot sourceforge dot net 联系 Andy Balaam
- IGCC 版权归 Andy Balaam 所有，版权所有 © 2009
- IGCC 是根据 GNU 通用公共许可证第3版条款发布的自由软件
- IGCC 不提供任何保证


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---