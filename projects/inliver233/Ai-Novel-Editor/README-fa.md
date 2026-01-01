
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">انگلیسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">هندی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">تایلندی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">فرانسوی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">آلمانی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">اسپانیایی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">ایتالیایی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">روسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">پرتغالی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">هلندی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">لهستانی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">عربی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">ترکی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">ویتنامی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">اندونزیایی</a></p>
      </div>
    </div>
  </details>
</div>

# ویرایشگر رمان هوشمند (AI Novel Editor)

ویرایشگر رمان مبتنی بر PyQt6 با پشتیبانی از هوش مصنوعی، ارائه‌دهنده ابزارهای حرفه‌ای مانند تکمیل هوشمند، مدیریت پروژه و سازماندهی مفاهیم.

## نصب

1. پروژه را کلون کنید
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

۲. ایجاد محیط مجازی
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

۳. نصب وابستگی‌ها
```bash
pip install -r requirements.txt
```

4. اجرای برنامه
```bash
python src/main.py
```

## قابلیت‌های اصلی

### مدیریت پروژه
- ساختار سلسله‌مراتبی اسناد (اثر > فصل > صحنه)
- وارد کردن و صادر کردن پروژه (پشتیبانی از فرمت‌های TEXT، MARKDOWN، DOCX، PDF، HTML)
- پشتیبان‌گیری خودکار و کنترل نسخه
- مدیریت چند پروژه‌ای

### قابلیت تکمیل هوشمند AI
- سه حالت تکمیل: تکمیل خودکار، تکمیل دستی (توصیه می‌شود یک بار کلید tab فشار داده شود و بار دیگر برای اعمال تکمیل)، غیرفعال‌سازی تکمیل
- سه حالت زمینه‌ای:
  - حالت سریع: زمینه سبک، پاسخ‌دهی سریع
  - حالت متعادل: زمینه متوسط، تعادل کیفیت و سرعت
  - حالت سراسری: زمینه کامل پروژه، بهترین نتیجه
- پشتیبانی از سرویس‌های مختلف هوش مصنوعی: OpenAI، Claude، Tongyi Qianwen، Zhipu AI، DeepSeek، Groq و غیره

### مدیریت طرح کلی
- ساختار درختی طرح کلی به صورت بصری
- مرتب‌سازی و تنظیم سلسله‌مراتب با کشیدن و رها کردن
- ناوبری سریع در اسناد
- تحلیل طرح کلی و ارائه پیشنهادات بهینه‌سازی

### پیکربندی API
- مرکز پیکربندی یکپارچه هوش مصنوعی
- پیکربندی‌های پیش‌فرض برای چندین ارائه‌دهنده سرویس
- قابلیت تست اتصال
- ذخیره‌سازی و وارد کردن/صادر کردن پیکربندی‌ها

### تنظیمات تکمیل هوشمند
- قابلیت تنظیم تاخیر فعال‌سازی
- محدودیت طول تکمیل
- پیکربندی طول زمینه
- پشتیبانی از پاسخ‌دهی جریانی

### ویرایشگر کلمات کلیدی
- قالب‌های نوشتاری داخلی متعدد
- قالب‌های قابل سفارشی‌سازی کلمات کلیدی
- مدیریت دسته‌بندی قالب‌ها
- پیکربندی قالب‌های مخصوص حالت‌ها

### قابلیت‌های رابط کاربری
- دو تم روشن و تاریک
- چینش سه ستونه (درخت پروژه، ویرایشگر، پنل مفاهیم)
- نوار کناری قابل جمع شدن
- حالت تمام‌صفحه برای نوشتن
- حالت تمرکز (جمله، پاراگراف، ماشین‌تحریر، حالت ذن، حالت غرق)

### جستجو و جایگزینی
- جستجوی متن کل پروژه
- پشتیبانی از عبارات منظم
- قابلیت جایگزینی گروهی
- گزینه‌های جستجوی پیشرفته

### مدیریت مفاهیم
- شناسایی خودکار شخصیت‌ها، مکان‌ها، اشیاء
- مدیریت روابط مفاهیم
- سیستم برچسب‌گذاری و دسته‌بندی
- درج سریع مفاهیم

## کلیدهای میانبر

- `Ctrl+N`: ایجاد پروژه جدید
- `Ctrl+O`: باز کردن پروژه
- `Ctrl+S`: ذخیره سند
- `F11`: حالت تمام‌صفحه
- `Tab`: فعال‌سازی دستی تکمیل خودکار هوشمند (در حالت دستی)
- `Ctrl+F`: جستجو
- `Ctrl+H`: جستجو و جایگزینی
- `Ctrl+Shift+H`: جستجو و جایگزینی پیشرفته


## نیازمندی‌های سیستم

- Python 3.8+
- PyQt6
- سیستم‌عامل: ویندوز، مک، لینوکس

## نویسنده

**inliver**
- ایمیل: inliverapi@outlook.com  
- گیت‌هاب: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---