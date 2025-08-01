# تقلب‌بابا

> [!NOTE]  
> از آخرین نسخه macOS و Windows استفاده کنید، نسخه‌های قدیمی‌تر پشتیبانی محدودی دارند

> [!NOTE]  
> در حین تست، اگر سوالی بپرسید، پاسخ نمی‌دهد؛ شما باید نقش مصاحبه‌گر را شبیه‌سازی کنید تا سوال بپرسد و سپس پاسخ خواهد داد

یک دستیار هوش مصنوعی بلادرنگ که در طول تماس‌های ویدیویی، مصاحبه‌ها، ارائه‌ها و جلسات با استفاده از ضبط صفحه و تحلیل صدا، کمک زمینه‌ای ارائه می‌دهد.

## ویژگی‌ها

- **دستیار هوش مصنوعی زنده**: کمک بلادرنگ مبتنی بر Google Gemini 2.0 Flash Live
- **ضبط صفحه و صدا**: تحلیل آنچه می‌بینید و می‌شنوید برای پاسخ‌های زمینه‌ای
- **پروفایل‌های متعدد**: مصاحبه، تماس فروش، جلسه کاری، ارائه، مذاکره
- **لایه شفاف**: پنجره همیشه در بالا که می‌توان آن را هرجا قرار داد
- **حالت عبور کلیک**: شفاف کردن پنجره نسبت به کلیک‌ها هنگام نیاز
- **چندسکویی**: قابل اجرا روی macOS، Windows و Linux (فعلاً فقط برای تست، استفاده نکنید)

## راه‌اندازی

1. **دریافت کلید API جمینی**: به [Google AI Studio](https://aistudio.google.com/apikey) مراجعه کنید
2. **نصب وابستگی‌ها**: `npm install`
3. **اجرای برنامه**: `npm start`

## نحوه استفاده

1. کلید API جمینی خود را در پنجره اصلی وارد کنید
2. پروفایل و زبان خود را در تنظیمات انتخاب کنید
3. روی "شروع جلسه" کلیک کنید تا آغاز شود
4. پنجره را با کلیدهای میانبر جابه‌جا کنید
5. هوش مصنوعی بر اساس صفحه شما و سوالات مصاحبه‌گر به طور بلادرنگ کمک می‌کند

## کلیدهای میانبر

- **جابه‌جایی پنجره**: `Ctrl/Cmd + کلیدهای جهت‌دار` - جابه‌جا کردن پنجره
- **عبور کلیک**: `Ctrl/Cmd + M` - فعال/غیرفعال کردن رویدادهای ماوس
- **بستن/بازگشت**: `Ctrl/Cmd + \` - بستن پنجره یا بازگشت
- **ارسال پیام**: `Enter` - ارسال متن به هوش مصنوعی

## ضبط صدا

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) برای صدای سیستم 
- **Windows**: ضبط صدای لوپ‌بک
- **Linux**: ورودی میکروفون

## نیازمندی‌ها

- سیستم‌عامل سازگار با Electron (macOS، Windows، Linux)
- کلید API جمینی
- دسترسی ضبط صفحه
- دسترسی به میکروفون/صدا

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---