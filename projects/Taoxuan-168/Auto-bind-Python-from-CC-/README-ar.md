
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

ربط بايثون تلقائياً من CC++
===================

> مشروع بسيط وسهل الاستخدام وقابل للتخصيص لتحويل كود C/C++ تلقائياً إلى كود بايثون وإنشاء حزمة whl

> تم استنساخ هذا المشروع من:
https://github.com/Neutree/c_cpp_project_framework
وجزء كود التجميع مطابق تماماً للمستودع الأصلي

> كود مرجعي للربط التلقائي باستخدام pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## البدء السريع

* 1. استنساخ هذا المستودع والدخول إلى دليل /examples/demo
استخدم الأمر python project.py menuconfig للدخول إلى واجهة رسومية لإعداد أداة البناء وسلسلة الأدوات واختيار تجميع ملف whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> حيث أن x86 مخصص للبناء على الجهاز المحلي، و arm64 مخصص للبناء على MaixCam2، و RISCV64 للبناء على MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. اكتب دالة C/C++ وملف رأس hpp، ويجب أن يكون اسم ملف الحزمة whl مطابقًا لاسم الملف لتسهيل التعرف التلقائي:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
اكتب تعليق @modul للدالة المقابلة، يليها مسار الدالة:
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
السطر الأول هو مقدمة الدالة، @param هو شرح المعاملات، @return هو شرح قيمة الإرجاع (يمكن أن يكون فارغًا)
إذا كنت تحتاج فقط إلى التجميع والتعبئة كملف whl فلا حاجة لتعديل main.cpp
استخدم python project build لبدء التجميع وتعبئة ملف whl
بعد تثبيت ملف whl الذي تم تجميعه يمكنك استدعاءه مباشرة:
```Python
import add
add.test.add(1,1)
```
ملاحظة:
-   كل ملف رأس يمثل اسم وحدة، ويشير إلى الوحدة التي يجب استيرادها، على سبيل المثال add.hpp يقابل import add، ويجب أن يبدأ اسم الوحدة بـ add
-   تشغيل cpp_bind_python.py مباشرةً سيولد فقط ملف cpp المرتبط، وإضافة الوسيط --doc DOC يمكن أن تولد التوثيق تلقائياً من التعليقات

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---