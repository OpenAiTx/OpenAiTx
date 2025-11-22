# インタラクティブGCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> 元のリポジトリはAndy Balaamによるものです: https://codeberg.org/andybalaam/igcc.
> このフォークでは、リファクタリングを行い、より使いやすくしようと試みています。

> [!WARNING]
> 本プロジェクトは、C/C++作業時のフィードバックループを短縮するためのハッキーな試みであり、真剣な用途には明らかに適していません。

インタラクティブGCC（`igcc`）はC/C++のリード・イバル・プリントループ（REPL）です。ユーザーコマンドでベースのソースファイルを操作し、変更ごとにソースをコンパイルし、生成されたバイナリを実行して標準出力と標準エラー出力を収集します。
複数行（ブロック）入力に対応しており、一度に複数行を追加してコンパイラを一度だけ呼び出すことができます（以下の例参照）。

様々なヘッダーファイルをインクルード可能です。便宜上、デフォルトのヘッダーとして [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h) が含まれています。また、`using namespace std;` はデフォルトでは利用できませんが、明示的に追加することも可能です（以下の例参照）。

`igcc` の様々な設定は [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml) を参照してください。

## はじめに
最も簡単な始め方は [pipx](https://pipx.pypa.io/stable/) を使うことです:
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
または、`pip` を使用することもできます（専用の仮想環境を推奨します）。

これで REPL を次のコマンドで起動できます：
```
igcc
```
利用可能な引数:

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
コードはGCC（`g++`）でコンパイルされ、結果（ある場合）が表示されます。  
ヘルプは`.h`と入力してください：  


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

## 例
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

**複数行入力**がサポートされています（設定の`multiline_marker`を確認してください）。利点は複数回のコンパイラ呼び出しを回避できることです。
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

ヘッダーを含めることができます：
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
ライブラリはリンク可能です:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

コマンドを**元に戻す**こともできます:
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

... または以前に取り消したコマンドを**やり直す**:
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

## 将来の作業
https://github.com/alexandru-dinu/igcc/issues を参照してください

## 類似プロジェクト
- https://github.com/BenBrock/reple: コンパイル言語向けの「リプレイベース」REPL
- https://github.com/root-project/cling: cling C++インタープリタ


## クレジット
- [IGCC ホームページ](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge ページ](http://sourceforge.net/projects/igcc/)
- [Andy Balaam のホームページ](http://www.artificialworlds.net)
- [Andy Balaam のブログ](http://www.artificialworlds.net/blog)
- Andy Balaam への連絡は axis3x3 at users dot sourceforge dot net で可能です
- IGCC は 2009 年 Andy Balaam に著作権があります
- IGCC は GNU 一般公衆利用許諾契約書バージョン3の条件の下でリリースされたフリーソフトウェアです
- IGCC は無保証で提供されます


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-22

---