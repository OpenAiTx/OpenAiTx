
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# อินเทอร์แอคทีฟ GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> รีโปต้นฉบับจาก Andy Balaam อยู่ที่นี่: https://codeberg.org/andybalaam/igcc.
> ใน fork นี้ ฉันได้ปรับปรุงโค้ดบางส่วนและพยายามทำให้ใช้งานง่ายขึ้น

> [!WARNING]
> โปรเจกต์นี้เป็นความพยายามแบบหยาบๆ เพื่อให้ได้ feedback loop ที่สั้นลงเมื่อทำงานกับ C/C++ ในบางกรณี และแน่นอนว่าไม่ได้ออกแบบมาสำหรับงานจริงจัง

Interactive GCC (`igcc`) คือ read-eval-print loop (REPL) สำหรับ C/C++ โดยทำงานโดยการแก้ไขไฟล์ source หลักตามคำสั่งของผู้ใช้ จากนั้นจะคอมไพล์ source หลังจากแต่ละครั้งที่มีการแก้ไข แล้วรัน binary ที่ได้ และรวบรวม stdout & stderr

รองรับการป้อนข้อมูลแบบหลายบรรทัด (block) ดังนั้นคุณสามารถเพิ่มหลายบรรทัดในครั้งเดียวและเรียกใช้งานคอมไพเลอร์เพียงครั้งเดียว (ตัวอย่างด้านล่าง)

คุณสามารถ include header files ต่างๆ ได้ เพื่อความสะดวก มี header เริ่มต้นที่ include ให้: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h) นอกจากนี้ `using namespace std;` ไม่ได้มีมาให้โดยอัตโนมัติ แต่คุณสามารถเพิ่มเองได้โดยตรง (ดูตัวอย่างด้านล่าง)

คุณสามารถปรับแต่งฟีเจอร์ต่างๆ ของ `igcc` ได้ ดูได้ที่ [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml)

## วิธีเริ่มต้น
วิธีที่ง่ายที่สุดในการเริ่มต้นคือใช้ [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
อีกทางเลือกหนึ่ง คุณสามารถใช้ `uv` ได้เช่นกัน:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
และสำหรับนักพัฒนา:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```
อาร์กิวเมนต์ที่ใช้ได้:
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

โค้ดจะถูกคอมไพล์ด้วย GCC (`g++`) และผลลัพธ์ (ถ้ามี) จะแสดงออกมา
พิมพ์ `.h` เพื่อขอความช่วยเหลือ:
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

## ตัวอย่าง
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

**รองรับการป้อนข้อมูลหลายบรรทัด** (ตรวจสอบ `multiline_marker` จาก config) ข้อดีคือช่วยหลีกเลี่ยงการเรียกคอมไพเลอร์หลายครั้ง
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
คุณสามารถใส่หัวข้อได้:

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
ไลบรารีสามารถเชื่อมโยงได้:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
คุณยังสามารถ**ยกเลิก**คำสั่งได้:

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

... หรือ **ทำซ้ำ** คำสั่งที่ถูกยกเลิกไปก่อนหน้านี้:
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

## งานในอนาคต
ดูที่ https://github.com/alexandru-dinu/igcc/issues

## โครงการที่คล้ายกัน
- https://github.com/BenBrock/reple: REPL แบบ "Replay-based" สำหรับภาษาแบบคอมไพล์
- https://github.com/root-project/cling: ตัวอินเทอร์พรีเตอร์ C++ cling


## เครดิต
- [หน้าแรก IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [หน้า Sourceforge ของ IGCC](http://sourceforge.net/projects/igcc/)
- [หน้าแรกของ Andy Balaam](http://www.artificialworlds.net)
- [บล็อกของ Andy Balaam](http://www.artificialworlds.net/blog)
- สามารถติดต่อ Andy Balaam ได้ที่ axis3x3 ที่ users จุด sourceforge จุด net
- IGCC ลิขสิทธิ์ (C) 2009 Andy Balaam
- IGCC เป็นซอฟต์แวร์เสรีที่เผยแพร่ภายใต้เงื่อนไขของ GNU General Public License เวอร์ชัน 3
- IGCC ไม่มีการรับประกันใด ๆ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---