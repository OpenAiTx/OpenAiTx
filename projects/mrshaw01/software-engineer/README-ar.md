<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mrshaw01&project=software-engineer&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <h1>مهندس برمجيات</h1>
  <p>
    <img src="https://img.shields.io/github/actions/workflow/status/mrshaw01/software-engineer/pre-commit.yml?branch=main&label=pre-commit&logo=pre-commit&logoColor=white" alt="حالة pre-commit">
  </p>

  <p>
    <img src="https://img.shields.io/github/last-commit/mrshaw01/software-engineer" alt="آخر التزام">
    <img src="https://img.shields.io/github/issues/mrshaw01/software-engineer" alt="المشاكل">
    <img src="https://img.shields.io/github/issues-pr/mrshaw01/software-engineer" alt="طلبات السحب">
  </p>
</div>

مجموعة مختارة وعالية الجودة من مصادر التعلم التي تركز على **بايثون** وقريباً **C/C++**، مصممة لبناء أساس قوي في هندسة البرمجيات وفهم على مستوى الأنظمة.

## هيكل المستودع

```text
.
├── python-basic/           # Essential Python syntax, data types, and operations
├── python-advanced/        # Decorators, threading, logging, JSON, and more
├── python-OOP/             # Deep dive into Python's object-oriented programming
├── cpp-basic/              # Fundamentals of C++: syntax, memory, pointers, etc.
├── cpp-advanced/           # Advanced C++: RAII, noexcept, smart pointers, RVO, etc.
├── cpp-OOP/                # Object-oriented programming in C++
├── CUDA/                   # GPU programming with CUDA (host & device code)
├── MPI/                    # Message Passing Interface programming and demos
├── docs/                   # System-level notes on performance, Python-C++ interop, mixed precision, etc.
└── README.md               # Project overview (this file)
```
## كيفية الاستخدام

يحتوي كل مجلد مرقم على ملف `README.md` يشرح المفاهيم، بالإضافة إلى ملفات `.py` قابلة للتشغيل. على سبيل المثال:


```bash
cd python-advanced/08-decorators
python basic_function_decorator.py
```
بعض السكريبتات تتطلب مكتبات خارجية (مثل `numpy`، `scipy`، `torch`).

جميع الشيفرات متوافقة مع **بايثون 3.7+** ومكتوبة لتكون **بسيطة، مركزة، وقابلة للاختبار**.

## النقاط البارزة

### بايثون

- **إتقان البرمجة الكائنية**: الفئات، الوراثة، الميتا-كلاس، واصفات (`python-OOP/`)
- **مواضيع متقدمة**: الديكوريتر، مدراء السياق، التخزين المؤقت للدوال، التزامن
- **هياكل البيانات**: القوائم، التابعات، القواميس، المجموعات مع أمثلة عملية

### ++C

- **أساسيات ++C**: الصياغة، الدوال، المؤشرات، الهياكل، النطاق، التعدادات (`cpp-basic/`)
- **البرمجة الحديثة في ++C**: إدارة الموارد (RAII)، المؤشرات الذكية، دلالات النقل، المحاذاة، إرجاع القيم المحسنة (`cpp-advanced/`)
- **البرمجة الكائنية في ++C**: الفئات، محددات الوصول، الوراثة، تعدد الأشكال، القوالب

### الأنظمة والأداء

- **برمجة CUDA**: نموذج المضيف/الجهاز، إطلاق النواة، إدارة الذاكرة (`CUDA/`)
- **برمجة MPI**: برامج موزعة عملية، عمليات مصفوفية، وتشغيلات التحقق (`MPI/`)
- **التوثيق**: الربط بين بايثون و++C، التعامل مع GIL، ضبط CUDA، التدريب بدقة مختلطة (`docs/`)

## فلسفة التعلم

- أمثلة صغيرة ومجزأة — لا دفاتر أكواد مزدحمة
- فصل واضح بين المفهوم، الشيفرة، والتعليق
- تركيز على التصميم، الأداء، وسهولة الصيانة
- بناء المعرفة تدريجيًا — مثالي للمتعلمين الجادين والمحترفين

## تاريخ النجوم

<a href="https://www.star-history.com/#mrshaw01/software-engineer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=mrshaw01/software-engineer&type=Date" />
 </picture>
</a>

## 🤝 المساهمات

وجدت خطأ أو خطأ مطبعي أو ترغب في إضافة شيء؟ افتح طلب دمج — جميع المساهمات مرحب بها.

<p align="center">
  <a href="https://github.com/mrshaw01/software-engineer/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=mrshaw01/software-engineer" />
  </a>
</p>

## 📄 الرخصة

رخصة MIT — مجانية للاستخدام والتعديل والمشاركة لأغراض التعلم والتعليم.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---