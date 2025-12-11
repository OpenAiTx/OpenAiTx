
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
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

# GCC Interaktif

[![tes](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![kontribusi](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Gaya kode: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!CATATAN]
> Repo asli dari Andy Balaam ada di sini: https://codeberg.org/andybalaam/igcc.
> Dalam fork ini, saya telah melakukan beberapa refactoring dan mencoba membuatnya lebih mudah digunakan.

> [!WARNING]
> Proyek ini merupakan upaya eksperimental untuk mendapatkan loop umpan balik yang lebih singkat saat bekerja dengan C/C++ dalam beberapa kasus dan jelas tidak dimaksudkan untuk penggunaan serius.

GCC Interaktif (`igcc`) adalah read-eval-print loop (REPL) untuk C/C++. Cara kerjanya adalah memanipulasi file sumber dasar dengan perintah pengguna, mengompilasi sumber setelah setiap modifikasi, kemudian mengeksekusi binary hasilnya dan mengumpulkan stdout & stderr.
Input multi-baris (blok) didukung, sehingga Anda dapat menambahkan beberapa baris sekaligus dan hanya memanggil compiler sekali (contoh di bawah).

Anda dapat menyertakan berbagai file header. Untuk kenyamanan, header default sudah disertakan: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Selain itu, `using namespace std;` tidak tersedia secara default, tetapi Anda dapat menambahkannya secara eksplisit (contoh di bawah).

Berbagai aspek dari `igcc` dapat dikonfigurasi, lihat [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Memulai
Cara termudah untuk memulai adalah dengan menggunakan [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Sebagai alternatif, Anda juga dapat menggunakan `uv`:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
Dan untuk pengembang:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Argumen yang tersedia:
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

Kode akan dikompilasi dengan GCC (`g++`) dan hasilnya (jika ada) akan ditampilkan.
Ketik `.h` untuk bantuan:
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

## Contoh
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

**Input multi-baris** didukung (periksa `multiline_marker` dari konfigurasi). Keuntungannya adalah menghindari pemanggilan kompilator berulang kali.
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
Anda dapat menyertakan header:

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

Lib dapat ditautkan:
```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

Anda juga dapat **membatalkan** perintah:
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

... atau **ulangi** perintah yang sebelumnya dibatalkan:
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
## Pekerjaan di masa depan
Lihat https://github.com/alexandru-dinu/igcc/issues

## Proyek serupa
- https://github.com/BenBrock/reple: REPL berbasis "Replay" untuk bahasa terkompilasi
- https://github.com/root-project/cling: Interpreter cling untuk C++


## Kredit
- [Halaman utama IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [Halaman IGCC di Sourceforge](http://sourceforge.net/projects/igcc/)
- [Halaman utama Andy Balaam](http://www.artificialworlds.net)
- [Blog Andy Balaam](http://www.artificialworlds.net/blog)
- Andy Balaam dapat dihubungi di axis3x3 di users titik sourceforge titik net
- IGCC adalah Hak Cipta (C) 2009 Andy Balaam
- IGCC adalah perangkat lunak bebas yang dirilis di bawah ketentuan GNU General Public License versi 3
- IGCC datang TANPA JAMINAN



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---