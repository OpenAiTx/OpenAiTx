
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

# Etkileşimli GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> Andy Balaam tarafından oluşturulan orijinal depo burada: https://codeberg.org/andybalaam/igcc.
> Bu çatallamada, biraz yeniden yapılandırma yaptım ve kullanımı daha kolay hale getirmeye çalıştım.

> [!UYARI]
> Bu proje, bazı durumlarda C/C++ ile çalışırken daha kısa bir geri bildirim döngüsü elde etmek için yapılan geçici bir denemedir ve açıkça ciddi bir şey için tasarlanmamıştır.

Etkileşimli GCC (`igcc`), C/C++ için bir read-eval-print loop (REPL)'dir. Kullanıcı komutlarıyla bir temel kaynak dosyasını değiştirerek çalışır, her değişiklikten sonra kaynağı derler, ardından ortaya çıkan ikili dosyayı çalıştırır ve stdout & stderr çıktısını toplar.
Çok satırlı (blok) girdi desteklenir, böylece bir seferde birden fazla satır ekleyebilir ve derleyiciyi yalnızca bir kez çağırabilirsiniz (aşağıda örnekler var).

Çeşitli başlık dosyalarını dahil edebilirsiniz. Kolaylık olması için varsayılan bir başlık dosyası dahil edilmiştir: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). Ayrıca, `using namespace std;` varsayılan olarak mevcut değildir, ancak bunu açıkça ekleyebilirsiniz (aşağıda örnek var).

`igcc`'nin çeşitli yönleri yapılandırılabilir, bkz. [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## Başlarken
Başlamak için en kolay yol [pipx](https://pipx.pypa.io/stable/) kullanmaktır:
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
Alternatif olarak, `uv` de kullanabilirsiniz:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
Ve geliştirici için:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

Kullanılabilir argümanlar:
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

Kod GCC (`g++`) ile derlenecek ve sonuçlar (varsa) görüntülenecektir.
Yardım için `.h` yazın:
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

## Örnekler
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

**Çok satırlı giriş** desteklenmektedir (ayarı `multiline_marker` config'den kontrol edin). Bunun faydası, birden fazla derleyici çağrısından kaçınmaktır.
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
Başlıklar ekleyebilirsiniz:

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

Kitaplıklar bağlanabilir:
```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
Ayrıca komutları **geri alabilirsiniz**:

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

... veya daha önce geri alınan komutları **yeniden yapın**:
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

## Gelecek çalışmalar
Bkz. https://github.com/alexandru-dinu/igcc/issues

## Benzer projeler
- https://github.com/BenBrock/reple: Derlenmiş diller için "Replay-based" REPL'ler
- https://github.com/root-project/cling: Cling C++ yorumlayıcısı


## Katkıda Bulunanlar
- [IGCC ana sayfası](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge sayfası](http://sourceforge.net/projects/igcc/)
- [Andy Balaam'ın ana sayfası](http://www.artificialworlds.net)
- [Andy Balaam'ın blogu](http://www.artificialworlds.net/blog)
- Andy Balaam'a axis3x3 kullanıcı adıyla users nokta sourceforge nokta net adresinden ulaşılabilir
- IGCC'nin telif hakkı (C) 2009 Andy Balaam'a aittir
- IGCC, GNU Genel Kamu Lisansı sürüm 3 koşulları altında yayımlanan Özgür Yazılımdır
- IGCC, HİÇBİR GARANTİ ile gelmez


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---