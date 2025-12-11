
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-CN">সৰল চীনীয়া</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=zh-TW">পৰম্পৰাগত চীনীয়া</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fr">ফৰাচী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=es">স্পেনী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=pl">প'লিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=fa">ফাৰ্ছী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=tr">টুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=id">ইণ্ডোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=alexandru-dinu&project=igcc&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ইণ্টাৰেক্টিভ GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> Andy Balaam ৰ মূল ৰেপ'টো ইয়াত আছে: https://codeberg.org/andybalaam/igcc.
> এই ফৰ্কটোত, মই কিছু পুনঃগঠন কৰিছো আৰু ব্যৱহাৰ কৰিবলৈ সহজ কৰি তুলিবলৈ চেষ্টা কৰিছো।

> [!WARNING]
> এই প্ৰকল্পটো C/C++ লৈ কাম কৰাৰ সময়ত কিছু ক্ষেত্ৰত feedback loop টো সৰু কৰাৰ এটা হেকি প্ৰচেষ্টা, আৰু স্পষ্টকৈ কোনো গম্ভীৰ কামৰ বাবে উদ্দেশ্য কৰা হোৱা নাই।

ইনটাৰেক্টিভ GCC (`igcc`) হৈছে C/C++ ৰ বাবে read-eval-print loop (REPL)। ই এটা বেছিক উৎস ফাইলক ব্যৱহাৰকাৰীৰ নিৰ্দেশনাৰে পৰিবৰ্তন কৰে, প্ৰতিটো পৰিবৰ্তনৰ পিছত উৎস ফাইলটো কম্পাইল কৰে, তাৰপিছত উৎপন্ন বাইনেৰিটো চলায় আৰু তাৰ stdout & stderr সংগ্ৰহ কৰে।
মাল্টি-লাইন (ব্লক) ইনপুট সমৰ্থিত, অৰ্থাৎ আপুনি একে সময়তে একাধিক শাৰী যোগ কৰিব পাৰে আৰু কেৱল এটা বাৰ compiler আহ্বান কৰিব পাৰে (তলত উদাহৰণ দিয়া হৈছে)।

আপুনি বিভিন্ন হেডাৰ ফাইল অন্তর্ভুক্ত কৰিব পাৰে। সুবিধাৰ বাবে, এটা ডিফল্ট হেডাৰ অন্তর্ভুক্ত কৰা হৈছে: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h)। লগতে, `using namespace std;` ডিফল্টভাৱে উপলব্ধ নহয়, কিন্তু আপুনি স্পষ্টকৈ যোগ কৰিব পাৰে (তলত উদাহৰণ দিয়া হৈছে)।

`igcc` ৰ বিভিন্ন দিশ কনফিগাৰ কৰিব পাৰি, চাওক [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml)।

## আৰম্ভণি
আৰম্ভ কৰাৰ সৰ্বাধিক সহজ উপায় হৈছে [pipx](https://pipx.pypa.io/stable/) ব্যৱহাৰ কৰা:
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
বিকল্পভাৱে, আপুনি `uv` ব্যৱহাৰ কৰিবও পাৰে:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
আৰু বিকাশৰ বাবে:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```
উপলব্ধ আৰ্গছসমূহ:
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
কোডটো GCC (`g++`) ৰ সহায়ত সংকলন কৰা হ'ব আৰু ফলাফলসমূহ (যদি থাকে) প্ৰদর্শন কৰা হ'ব।
সহায়ৰ বাবে `.h` টাইপ কৰক:


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

## উদাহৰণসমূহ
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

**বহু-শাৰী ইনপুট** সমৰ্থিত (config ৰ পৰা `multiline_marker` পৰীক্ষা কৰক)। ইয়াৰ সুবিধা হৈছে বহু compiler কল এৰাই চলিব পাৰি।
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
আপুনি শীৰ্ষকসমূহ অন্তর্ভুক্ত কৰিব পাৰে:

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

লাইব্ৰেৰীসমূহ সংযোগ কৰিব পৰা যায়:
```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

আপুনি আদেশসমূহ **পুনৰাই আগৰ অৱস্থালৈ আনিব** পাৰে:
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

... অথবা পূৰ্বে বাতিল কৰা নিৰ্দেশসমূহ পুনৰ কৰক (**redo**):
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

## ভৱিষ্যতৰ কাম
https://github.com/alexandru-dinu/igcc/issues চাওক

## সদৃশ প্ৰকল্পসমূহ
- https://github.com/BenBrock/reple: কম্পাইল কৰা ভাষাসমূহৰ বাবে "Replay-based" REPLs
- https://github.com/root-project/cling: cling C++ ইন্টাৰপ্ৰিটাৰ

## ক্ৰেডিটসমূহ
- [IGCC গৃহ পৃষ্ঠা](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge পৃষ্ঠা](http://sourceforge.net/projects/igcc/)
- [Andy Balaam ৰ গৃহ পৃষ্ঠা](http://www.artificialworlds.net)
- [Andy Balaam ৰ ব্লগ](http://www.artificialworlds.net/blog)
- Andy Balaam ক axis3x3 at users dot sourceforge dot net ত যোগাযোগ কৰিব পাৰি
- IGCC কপিৰাইট (C) ২০০৯ Andy Balaam
- IGCC মুক্ত ছফ্টৱেৰ, যি GNU General Public License সংস্কৰণ ৩ ৰ অধীনত মুক্তি দিয়া হৈছে
- IGCC ত কোনো ধৰণৰ WARRANTY নাই



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---