
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

# GCC تعاملی

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!توجه]
> مخزن اصلی از اندی بالام در اینجا قرار دارد: https://codeberg.org/andybalaam/igcc.
> در این شاخه (fork)، من مقداری بازآرایی انجام داده‌ام و سعی کرده‌ام استفاده از آن را آسان‌تر کنم.

> [!هشدار]
> این پروژه یک تلاش غیررسمی برای ایجاد چرخه بازخورد کوتاه‌تر هنگام کار با C/C++ در برخی موارد است و به‌وضوح برای هیچ کار جدی‌ای در نظر گرفته نشده است.

جی‌سی‌سی تعاملی (`igcc`) یک حلقه خواندن-ارزیابی-چاپ (REPL) برای C/C++ است. این برنامه با دستکاری یک فایل مبنا با دستورات کاربر کار می‌کند، پس از هر تغییر فایل را کامپایل می‌کند، سپس فایل اجرایی حاصل را اجرا کرده و خروجی stdout و stderr را جمع‌آوری می‌کند.
ورودی چندخطی (بلوک) پشتیبانی می‌شود، بنابراین می‌توانید چندین خط را همزمان اضافه کنید و فقط یک بار کامپایلر را فراخوانی کنید (نمونه‌ها در ادامه).

شما می‌توانید هدرهای مختلفی را وارد کنید. برای راحتی، یک هدر پیش‌فرض اضافه شده است: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). همچنین، `using namespace std;` به طور پیش‌فرض فعال نیست، اما می‌توانید به طور صریح آن را اضافه کنید (نمونه در ادامه).

جنبه‌های مختلفی از `igcc` قابل پیکربندی هستند، مراجعه کنید به [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## شروع به کار
ساده‌ترین راه برای شروع استفاده، استفاده از [pipx](https://pipx.pypa.io/stable/) است:
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
همچنین می‌توانید از `uv` نیز استفاده کنید:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
و برای توسعه‌دهنده:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```

آرگومان‌های موجود:
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

کد با GCC (`g++`) کامپایل خواهد شد و نتایج (در صورت وجود) نمایش داده می‌شوند.
برای دریافت راهنما `.h` را تایپ کنید:
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

## مثال‌ها
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

ورودی چندخطی (**Multi-line input**) پشتیبانی می‌شود (گزینه `multiline_marker` را در پیکربندی بررسی کنید). مزیت این کار جلوگیری از فراخوانی‌های متعدد کامپایلر است.
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
می‌توانید سربرگ‌ها را اضافه کنید:

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
کتابخانه‌ها می‌توانند لینک شوند:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```

شما همچنین می‌توانید دستورات را **واگردانی** کنید:
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
... یا فرمان‌هایی که قبلاً لغو شده‌اند را **دوباره انجام دهید**:

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

## کارهای آینده
مشاهده کنید https://github.com/alexandru-dinu/igcc/issues

## پروژه‌های مشابه
- https://github.com/BenBrock/reple: رابط REPL مبتنی بر "بازپخش" برای زبان‌های کامپایل شده
- https://github.com/root-project/cling: مفسر cling برای ++C


## اعتبارنامه‌ها
- [صفحه اصلی IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [صفحه IGCC در Sourceforge](http://sourceforge.net/projects/igcc/)
- [صفحه اصلی اندی بالاام](http://www.artificialworlds.net)
- [وبلاگ اندی بالاام](http://www.artificialworlds.net/blog)
- برای تماس با اندی بالاام از axis3x3 در users نقطه sourceforge نقطه net استفاده کنید
- IGCC دارای حق کپی‌رایت (C) ۲۰۰۹ اندی بالاام است
- IGCC نرم‌افزار آزاد است که تحت شرایط مجوز عمومی همگانی گنو نسخه ۳ منتشر شده است
- IGCC بدون هیچگونه ضمانتی ارائه می‌شود


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---