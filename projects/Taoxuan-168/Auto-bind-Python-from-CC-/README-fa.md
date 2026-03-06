<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

اتصال خودکار پایتون از ++CC
===================

> یک پروژه کافی ساده و قابل تنظیم برای تبدیل خودکار کدهای C/C++ به کد پایتون و تولید بسته whl

> این پروژه از این آدرس کلون شده است:
https://github.com/Neutree/c_cpp_project_framework
و بخش کامپایل کد با مخزن اصلی یکسان نگه داشته شده است


> بخش کد مرجع برای اتصال خودکار pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## شروع سریع

* 1. این مخزن را کلون کنید و وارد دایرکتوری /examples/demo شوید
با استفاده از python project.py menuconfig وارد رابط گرافیکی شده و ابزار کامپایل و همچنین بسته‌بندی فایل whl را پیکربندی کنید
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> که در آن x86 برای کامپایل محلی، arm64 برای کامپایل MaixCam2 و RISCV64 برای کامپایل MaiCam/Pro است
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. یک تابع C/C++ و همچنین فایل هدر hpp بنویسید، نام فایل باید مشابه فایل whl باشد تا شناسایی خودکار راحت‌تر شود:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
برای تابع مربوطه @modul را بنویسید و مسیر تابع را در ادامه ذکر کنید:
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
در خط اول توضیح تابع قرار دارد، @param برای معرفی پارامترها است، @return برای معرفی مقدار بازگشتی (می‌تواند خالی باشد)
اگر فقط نیاز به کامپایل و بسته‌بندی به صورت فایل whl دارید، نیازی به تغییر main.cpp نیست
برای شروع کامپایل و بسته‌بندی فایل whl کافی است از python project build استفاده کنید
پس از نصب فایل whl کامپایل‌شده، می‌توانید مستقیماً آن را فراخوانی کنید:
```Python
import add
add.test.add(1,1)
```
توجه:
-   یک فایل هدر نمایانگر یک نام ماژول است، به معنی ماژولی که باید import شود؛ برای مثال add.hpp معادل import add است و نام ماژول باید با add شروع شود.
-   اجرای مستقیم cpp_bind_python.py تنها فایل cpp بایند شده را تولید می‌کند؛ با افزودن پارامتر --doc DOC می‌توان به صورت خودکار مستندات را از توضیحات تولید کرد.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---