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
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>
# ویرایشگر رمان AI

ویرایشگر رمان با کمک هوش مصنوعی مبتنی بر PyQt6، ارائه‌دهنده ابزارهای حرفه‌ای نوشتن مانند تکمیل هوشمند، مدیریت پروژه و سازماندهی مفاهیم.

## نصب

1. کلون کردن پروژه
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. ایجاد محیط مجازی
```bash
python -m venv venv
venv\Scripts\activate     # ویندوز
```
استفاده از uv
```bash
uv venv -p 3.11
```
3. نصب وابستگی‌ها
```bash
pip install -r requirements.txt
```
استفاده از uv
```bash
uv sync
```


4. اجرای برنامه
```bash
python -m src
```

## قابلیت‌های اصلی

### مدیریت پروژه
- ساختار سلسله‌مراتبی اسناد (اثر > فصل > صحنه)
- واردات و صادرات پروژه (پشتیبانی از فرمت‌های TEXT، MARKDOWN، DOCX، PDF، HTML)
- پشتیبان‌گیری خودکار و کنترل نسخه
- مدیریت چندین پروژه
### قابلیت تکمیل خودکار AI
- سه حالت تکمیل: تکمیل خودکار، تکمیل دستی (توصیه می‌شود با یک بار فشردن Tab فعال شود و با بار دوم اعمال گردد)، غیرفعال‌سازی تکمیل
- سه حالت زمینه:
  - حالت سریع: زمینه سبک، پاسخگویی سریع
  - حالت متعادل: زمینه متوسط، تعادل بین کیفیت و سرعت
  - حالت سراسری: زمینه کامل پروژه، بهترین نتیجه
- پشتیبانی از چندین سرویس AI: OpenAI، Claude، Tongyi Qianwen، Zhipu AI، DeepSeek، Groq و غیره

### مدیریت نمای کلی (Outline)
- ساختار درختی نمای کلی به صورت بصری
- مرتب‌سازی و تنظیم سطح با کشیدن و رها کردن (Drag & Drop)
- ناوبری سریع اسناد
- تحلیل نمای کلی و پیشنهادات بهینه‌سازی

### پیکربندی API
- مرکز پیکربندی یکپارچه AI
- پیکربندی‌های پیش‌فرض برای چندین ارائه‌دهنده خدمات
- قابلیت تست اتصال
- ذخیره، وارد کردن و صادر کردن پیکربندی‌ها
### تنظیمات تکمیل هوشمند
- تاخیر قابل تنظیم برای فعال‌سازی
- محدودیت طول تکمیل
- پیکربندی طول زمینه
- پشتیبانی از پاسخ‌دهی جریانی

### ویرایشگر کلمات کلیدی (پرومپت)
- قالب‌های نوشتاری داخلی متنوع
- قالب‌های کلمات کلیدی سفارشی
- مدیریت دسته‌بندی قالب‌ها
- پیکربندی قالب‌های خاص هر حالت

### قابلیت‌های رابط کاربری
- دو تم روشن و تیره
- چیدمان سه‌ستونه (درخت پروژه، ویرایشگر، پنل مفاهیم)
- نوار کناری قابل جمع شدن
- حالت نوشتن تمام‌صفحه
- حالت تمرکز (جمله، پاراگراف، ماشین‌تحریر، حالت ذن، حالت غوطه‌وری)

### جستجو و جایگزینی
- جستجوی متن در کل پروژه
- پشتیبانی از عبارات منظم (Regex)
- قابلیت جایگزینی گروهی
- گزینه‌های پیشرفته جستجو

### مدیریت مفاهیم
- شناسایی خودکار نقش‌ها، مکان‌ها، اشیاء
- مدیریت روابط مفاهیم
- سیستم برچسب‌گذاری و دسته‌بندی
- درج سریع مفاهیم

## کلیدهای میانبر

- `Ctrl+N`: ایجاد پروژه جدید
- `Ctrl+O`: باز کردن پروژه
- `Ctrl+S`: ذخیره سند
- `F11`: حالت تمام‌صفحه
- `Tab`: فعال‌سازی دستی تکمیل خودکار AI (در حالت دستی)
- `Ctrl+F`: جستجو
- `Ctrl+H`: جستجو و جایگزینی
- `Ctrl+Shift+H`: جستجو و جایگزینی پیشرفته
## الزامات سیستم

- پایتون 3.8+
- PyQt6
- سیستم عامل: ویندوز، macOS، لینوکس

## نویسنده

**inliver**
- ایمیل: inliverapi@outlook.com  
- گیت‌هاب: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---