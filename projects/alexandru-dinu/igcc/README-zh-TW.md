<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# 互動式 GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!注意]
> Andy Balaam 的原始倉庫在這裡：https://codeberg.org/andybalaam/igcc。

> 在這個分支中，我進行了一些重構，並嘗試讓它更容易使用。

> [!WARNING]
> 這個專案是一個為了在某些情況下縮短 C/C++ 開發時回饋迴圈的嘗試，明顯並不適用於任何嚴肅用途。

互動式 GCC（`igcc`）是一個 C/C++ 的讀取-求值-輸出迴圈（REPL）。它透過根據使用者命令操作基礎原始碼檔案，在每次修改後編譯該原始碼，然後執行產生的二進位檔，並收集其 stdout 與 stderr。
支援多行（區塊）輸入，因此你可以一次新增多行，僅需呼叫一次編譯器（如下例所示）。

你可以包含各種標頭檔。為了方便，預設已包含一個標頭檔：[ `boilerplate.h` ](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h)。另外，`using namespace std;` 預設未啟用，但你可以明確加入（如下例）。

`igcc` 的多項設定可調整，請參見 [ `config.yaml` ](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml)。

## 入門指南
最簡單的入門方式是使用 [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
或者，您也可以使用 `uv`:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
針對開發人員：
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

可用參數：
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

程式碼將使用 GCC（`g++`）進行編譯，並顯示結果（如有）。
輸入 `.h` 以獲取說明：
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

## 範例
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

**多行輸入**已支援（請參考配置中的 `multiline_marker`）。其優點是可避免多次編譯器呼叫。
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
您可以包含標題：

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
庫可以被連結：

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

您也可以**復原**指令：
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

……或**重做**先前已復原的指令：
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

## 未來工作
請參閱 https://github.com/alexandru-dinu/igcc/issues

## 類似專案
- https://github.com/BenBrock/reple：「重播式」REPL，適用於編譯型語言
- https://github.com/root-project/cling：cling C++ 直譯器


## 致謝
- [IGCC 主頁](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge 專頁](http://sourceforge.net/projects/igcc/)
- [Andy Balaam 主頁](http://www.artificialworlds.net)
- [Andy Balaam 部落格](http://www.artificialworlds.net/blog)
- 可透過 axis3x3 於 users dot sourceforge dot net 聯絡 Andy Balaam
- IGCC 版權所有 (C) 2009 Andy Balaam
- IGCC 為自由軟體，依據 GNU 通用公共授權條款第 3 版發布
- IGCC 不提供任何保證


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---