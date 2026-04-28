<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - محرك استعلامات SQL عالي الأداء لملفات CSV

 [![البناء والتجربة عبر الأنظمة (باستخدام نظام zig build)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

معالج استعلامات SQL خفيف وسريع مكتوب بلغة C يمكّنك من تنفيذ استعلامات SQL مباشرة على ملفات CSV دون الحاجة إلى قاعدة بيانات. للاطلاع على التوثيق الكامل، راجع مجلد /doc.

 ![cq أثناء العمل](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)


## التوثيق

- البدء: `doc/GettingStarted.md`
- التثبيت: `doc/Installation.md`
- واجهة سطر الأوامر: `doc/CLI.md`
- **واجهة المستخدم الطرفية (TUI)**: `doc/TUI.md`
- الهيكلية: `doc/Architecture.md`
- الاختبار: `doc/Testing.md`
- خارطة الطريق: `doc/Roadmap.md`
- المساهمة: `doc/Contributing.md`

## البدء السريع

البناء: `make`

### سطر الأوامر

تشغيل استعلام تجريبي:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### واجهة المستخدم الطرفية

تشغيل واجهة المستخدم التفاعلية:
`./build/cqtui data/`

الميزات:
- تصفح وفتح ملفات CSV كجداول
- تنفيذ استعلامات SQL بشكل تفاعلي
- واجهة متعددة الألسنة لعدة جداول
- تنقل عبر لوحة المفاتيح
- لا توجد تبعيات خارجية

## ملفات SQL نموذجية

يحتوي المستودع على ملفات SQL تجريبية ضمن assets/ (مثل example_between.sql, example_aggregation.sql، وغيرها). راجع assets/ للمزيد من التفاصيل.

## نظرة عامة على البيانات والميزات

- راجع مجلد /doc لأقسام مفصلة حول أنواع البيانات، صيغ التواريخ، تنسيق CSV، والمزيد.

## الترخيص

ترخيص MIT. راجع ملف LICENSE للحصول على التفاصيل.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---