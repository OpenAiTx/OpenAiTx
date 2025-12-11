<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# इंटरएक्टिव GCC

[![tests](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml/badge.svg)](https://github.com/alexandru-dinu/igcc/actions/workflows/main.yml)
[![contrib](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat)](https://github.com/alexandru-dinu/igcc/issues)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

> [!NOTE]
> एंडी बालाॅम का मूल रिपॉजिटरी यहाँ है: https://codeberg.org/andybalaam/igcc.

> इस fork में, मैंने कुछ पुनर्संगठन किया है और इसे उपयोग में आसान बनाने की कोशिश की है।

> [!WARNING]
> यह प्रोजेक्ट कुछ मामलों में C/C++ के साथ काम करते समय फीडबैक लूप को छोटा करने का एक तात्कालिक प्रयास है और जाहिर है कि इसे किसी गंभीर उपयोग के लिए नहीं बनाया गया है।

इंटरएक्टिव GCC (`igcc`) C/C++ के लिए एक रीड-इवैल-प्रिंट लूप (REPL) है। यह यूज़र कमांड्स के साथ एक बेस सोर्स फ़ाइल को संशोधित करके काम करता है, प्रत्येक संशोधन के बाद सोर्स को संकलित करता है, फिर उत्पन्न बाइनरी को चलाता है और उसके stdout और stderr को एकत्र करता है।
मल्टी-लाइन (ब्लॉक) इनपुट समर्थित है, जिससे आप एक बार में कई लाइनें जोड़ सकते हैं और केवल एक बार कंपाइलर को बुला सकते हैं (नीचे उदाहरण देखें)।

आप विभिन्न हेडर फ़ाइलें शामिल कर सकते हैं। सुविधा के लिए, एक डिफ़ॉल्ट हेडर शामिल है: [`boilerplate.h`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/boilerplate.h)। साथ ही, `using namespace std;` डिफ़ॉल्ट रूप से उपलब्ध नहीं है, लेकिन आप इसे स्पष्ट रूप से जोड़ सकते हैं (नीचे उदाहरण देखें)।

`igcc` के विभिन्न पहलुओं को कॉन्फ़िगर किया जा सकता है, देखें [`config.yaml`](https://github.com/alexandru-dinu/igcc/blob/main/igcc/assets/config.yaml)।

## शुरुआत कैसे करें
शुरुआत करने का सबसे आसान तरीका है [pipx](https://pipx.pypa.io/stable/) का उपयोग करना:
```
pipx install git+https://github.com/alexandru-dinu/igcc.git
```
वैकल्पिक रूप से, आप `uv` का भी उपयोग कर सकते हैं:
```
uv tool run git+https://github.com/alexandru-dinu/igcc
```
और डेवलपमेंट के लिए:
```
git clone https://github.com/alexandru-dinu/igcc.git
cd igcc
uv sync
```
उपलब्ध तर्क:
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

कोड को GCC (`g++`) के साथ संकलित किया जाएगा और परिणाम (यदि कोई है) प्रदर्शित किए जाएंगे।
मदद के लिए `.h` टाइप करें:
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

## उदाहरण
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

**मल्टी-लाइन इनपुट** समर्थित है (कॉन्फ़िग से `multiline_marker` देखें)। इसका लाभ यह है कि कई बार कंपाइलर कॉल करने से बचा जा सकता है।
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
आप हेडर शामिल कर सकते हैं:

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
लाइब्रेरीज़ को जोड़ा जा सकता है:

```
$ igcc -lpthread
[  1]> #include <pthread.h>
[  2]> pthread_t thr;
[  3]> const char* msg = "Hello, World!";
[  4]> // assuming print_msg is defined somewhere
[  5]> int ret = pthread_create(&thr, NULL, print_msg, (void*) msg); pthread_join(thr, NULL);
Hello, World!
```
आप कमांड को **पूर्ववत्** भी कर सकते हैं:

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

... या पहले पूर्ववत किए गए कमांड को **फिर से करें**:
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

## भविष्य का कार्य
देखें https://github.com/alexandru-dinu/igcc/issues

## समान परियोजनाएँ
- https://github.com/BenBrock/reple: संकलित भाषाओं के लिए "Replay-based" REPLs
- https://github.com/root-project/cling: क्लिंग C++ इंटरप्रेटर


## श्रेय
- [IGCC होम पेज](http://www.artificialworlds.net/wiki/IGCC/IGCC)
- [IGCC Sourceforge पेज](http://sourceforge.net/projects/igcc/)
- [एंडी बालाॅम का होम पेज](http://www.artificialworlds.net)
- [एंडी बालाॅम का ब्लॉग](http://www.artificialworlds.net/blog)
- एंडी बालाॅम से संपर्क axis3x3 at users dot sourceforge dot net पर किया जा सकता है
- IGCC कॉपीराइट (C) 2009 एंडी बालाॅम
- IGCC मुक्त सॉफ़्टवेयर है, जो GNU General Public License संस्करण 3 की शर्तों के तहत जारी किया गया है
- IGCC के साथ कोई वारंटी नहीं आती है


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---