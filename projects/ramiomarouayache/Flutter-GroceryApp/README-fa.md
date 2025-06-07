# استارتر GroceryApp

قالب اپلیکیشن خرید مواد غذایی برای تجربه خرید ساده و سریع. 🛒✨

در صورت مفید بودن، لطفاً به مخزن ستاره ⭐ بدهید.

## طراحی

**برای مشاهده طرح فیگما روی تصویر زیر کلیک کنید:**

[![پیش‌نمایش طراحی](https://raw.githubusercontent.com/ramiomarouayache/Flutter-GroceryApp/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)

## ✨پیش‌نیازها

1. **محیط توسعه:**
   - هر محیط توسعه‌ای با نصب Flutter SDK (مانند VSCode، اندروید استودیو، IntelliJ و غیره)

2. **پایه دانشی:**
   - دانش پایه تا متوسط دارت و فلاتر
   - آشنایی با معماری MVVM
   - آشنایی با مدیریت API
   - مبانی مدیریت وضعیت با استفاده از GetX

## تست
* می‌توانید نسخه پیش‌انتشار برای دستگاه‌های اندرویدی را از اینجا دانلود کنید: [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

## راه‌اندازی
* ابتدا نقطه پایانی محصول، اطلاعات هویتی و پارامترها را در `lib\constants\AppConstants` پیکربندی کنید.
* **یا**، برای تست موفقیت‌آمیز، از نقطه پایانی رایگان زیر (در زمان اشتراک‌گذاری) استفاده کنید.
```dart
class AppConstants {
  // "YOUR_API_PREFIX" را با آدرس پایه API خود جایگزین کنید.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //در صورت وجود

  // برای تست، از آدرس پایه API رایگان نسخه انتشار یافته استفاده کنید
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // نام کامل مالک پروژه
  static const String projectOwnerName = "FULL_NAME";
}
```

## نکات
* برای استفاده از نقاط پایانی API اختصاصی، لایه‌های منطقی را بر اساس مستندات API خود و اصول معماری MVVM شخصی‌سازی کنید.
* برخی تصاویر در نسخه پیش‌انتشار به دلیل محدودیت کپی‌رایت حذف شده‌اند.

## مشارکت

لطفاً این مخزن را فورک کرده و با استفاده از
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls)
مشارکت خود را بازگردانید.

هرگونه مشارکت، چه کوچک چه بزرگ، چه ویژگی‌های اصلی یا رفع اشکال، پذیرفته و ارزشمند است اما با دقت بررسی خواهد شد.

## شروع به کار
این پروژه نقطه شروعی برای یک اپلیکیشن فلاتر است.

چند منبع برای شروع اگر این اولین پروژه فلاتر شماست:

- [آزمایشگاه: اولین اپلیکیشن فلاتر خود را بنویسید](https://flutter.io/docs/get-started/codelab)
- [کتاب آشپزی: نمونه‌های مفید فلاتر](https://flutter.io/docs/cookbook)

## شمارنده بازدیدکنندگان

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="در حال بارگذاری">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---