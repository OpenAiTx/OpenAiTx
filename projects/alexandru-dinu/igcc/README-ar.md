<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# GCC التفاعلي

[![الاختبارات](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![المساهمة](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![نمط الكود: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!ملاحظة]
> المستودع الأصلي من Andy Balaam موجود هنا: https://codeberg.org/andybalaam/igcc.

> في هذا التفرع، قمت ببعض إعادة الهيكلة وحاولت جعل الاستخدام أسهل.

> [!تحذير]
> هذا المشروع هو محاولة عشوائية للحصول على حلقة تغذية راجعة أقصر عند العمل مع C/C++ في بعض الحالات ومن الواضح أنه غير مخصص لأي استخدام جاد.

جي سي سي التفاعلي (`igcc`) هو حلقة قراءة-تقييم-طباعة (REPL) للغة C/C++. يعمل عن طريق التلاعب بملف مصدر أساسي بواسطة أوامر المستخدم، ويقوم بترجمة المصدر بعد كل تعديل، ثم ينفذ الملف التنفيذي الناتج ويجمع المخرجات القياسية والخطأ القياسي.

يتم دعم الإدخال متعدد الأسطر (الكتل)، بحيث يمكنك إضافة عدة أسطر دفعة واحدة واستدعاء المترجم مرة واحدة فقط (أمثلة أدناه).

يمكنك تضمين ملفات الترويسات المختلفة. لراحتك، يتم تضمين ترويسة افتراضية: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h). أيضًا، عبارة `using namespace std;` غير متوفرة بشكل افتراضي، لكن يمكنك إضافتها صراحة (مثال أدناه).

يمكن تهيئة جوانب متعددة من `igcc`، انظر [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml).

## بدء الاستخدام
أسهل طريقة للبدء هي استخدام [pipx](https://pipx.pypa.io/stable/):
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
بدلاً من ذلك، يمكنك أيضًا استخدام `uv`:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
وللمطور:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```
المعلمات المتاحة:
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

سيتم ترجمة الكود باستخدام GCC (`g++`) وسيتم عرض النتائج (إذا وجدت).
اكتب `.h` للمساعدة:
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

## أمثلة
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

يتم دعم **الإدخال متعدد الأسطر** (تحقق من `multiline_marker` في الإعدادات). الفائدة هي تجنب عمليات استدعاء المترجم المتعددة.
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
يمكنك تضمين العناوين:

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
يمكن ربط المكتبات:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
يمكنك أيضًا **التراجع** عن الأوامر:

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
... أو **إعادة** الأوامر التي تم التراجع عنها مسبقًا:

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

## الأعمال المستقبلية
انظر https://github.com/alexandru-dinu/igcc/issues

## مشاريع مشابهة
- https://github.com/BenBrock/reple: "REPLs قائمة على إعادة التشغيل" للغات المترجمة
- https://github.com/root-project/cling: مترجم cling للغة ++C


## الشكر والتقدير
- [الصفحة الرئيسية لـ IGCC](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [صفحة IGCC على Sourceforge](http://sourceforge.net/projects/igcc/)
- [الصفحة الشخصية لـ Andy Balaam](http://www.artificialworlds.net)
- [مدونة Andy Balaam](http://www.artificialworlds.net/blog)
- يمكن التواصل مع Andy Balaam عبر axis3x3 على users dot sourceforge dot net
- IGCC حقوق النشر (C) 2009 لـ Andy Balaam
- IGCC برنامج مجاني صدر بموجب شروط رخصة جنو العمومية العامة الإصدار الثالث
- IGCC يأتي بدون أي ضمان


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---