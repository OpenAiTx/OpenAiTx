## 🚀 چرا این ماژول را ساختم

*متوجه شدم بسیاری از افراد یا کی‌باکس‌های لو رفته را می‌فروشند یا برای ماژول‌هایی پول می‌دهند که ادعا می‌کنند Play Integrity قوی را پاس می‌کنند اما فقط کی‌باکس‌های لو رفته ارائه می‌دهند. من این ماژول را ساختم تا به شما **کی‌باکس‌های واقعی و کاربردی** را به صورت کاملاً **رایگان** بدهم، بدون هزینه پنهان، بدون کلاهبرداری، فقط **دسترسی قانونی** همراه با چندین قابلیت مفید. 🚫🔑*

<div align="center">
  <a href="https://github.com/MeowDump/Integrity-Box/releases" target="_blank">
    <img src="https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/download.png" alt="Download Button" width="600" />
  </a>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/catppuccin/catppuccin/main/assets/footers/gray0_ctp_on_line.svg?sanitize=true" alt="Catppuccin Footer" />
</p>

`برای مشاهده کلیک کنید`

<details>
<summary><strong>ℹ️ اطلاعات ماژول</strong></summary>

> **این ماژول قابلیت‌های زیر را ارائه می‌دهد:**  

- ✅ به‌روزرسانی `keybox.xml`  
- 🗽 به‌روزرسانی `target.txt` بر اساس وضعیت TEE شما  
- 🥷 تغییر حالت‌های Shamiko (از طریق سوییچ ماژول)
- 👻 تغییر حالت‌های NoHello (از طریق سوییچ ماژول)  
- 🛠️ اضافه کردن تمامی بسته‌های شناسایی رام سفارشی در **مسیر SusFS**  
- ⛔ غیرفعال‌سازی EU injector به صورت پیش‌فرض  
- ⛔ غیرفعال‌سازی spoofing رام Pixel  
- 🔐 جعل وضعیت رمزنگاری   
- 🔑 جعل کلید انتشار رام  
- 😋 جعل وضعیت SE Linux  
- 🕵️ شناسایی فعالیت غیرعادی جهت کمک به اشکال‌زدایی مشکلات  
- 🎨 قابلیت‌های بیشتر، در [WebUI](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/9.jpg) بررسی کنید

</details>

<details>
<summary><strong>🗽 پیش‌نیازها</strong></summary>

> لطفاً پیش از استفاده، مطمئن شوید که **ماژول‌های زیر را نصب کرده‌اید**:

- [**Play Integrity Fork**](https://github.com/osm0sis/PlayIntegrityFork/releases)
- [**Tricky Store**](https://github.com/5ec1cff/TrickyStore/releases)

</details>

<details>
<summary><strong>❓ پرسش‌های متداول (FAQ)</strong></summary>

<details>
<summary><strong>آیا Meow Assistant بدافزار است؟</strong></summary>

### 🛡️ امضا و امنیت اپلیکیشن

در نسخه‌های اولیه، برنامه با **کلید تست** امضا شده بود که باعث شد برخی ابزارهای امنیتی آن را به عنوان برنامه‌ای بالقوه خطرناک شناسایی کنند.

از **ماژول نسخه ۳ به بعد**، برنامه با **کلید انتشار خصوصی** امضا می‌شود.  
🔒 با این که **تغییری در عملکرد ایجاد نشده**، استفاده از کلید مناسب مشکل را برطرف کرده است و دیگر **گزارش شناسایی اشتباه** وجود ندارد.

### 🐾 هدف Meow Assistant

**Meow Assistant** جهت افزایش کاربری و شفافیت ساخته شده است.

این برنامه هنگام انجام موارد زیر **پیام پاپ‌آپ** نمایش می‌دهد:

- ✅ وقتی روی هر گزینه‌ای در **WebView** کلیک کنید  
- ⚙️ زمانی که هر اسکریپتی را از طریق **دکمه Action** اجرا کنید

این کار به شما کمک می‌کند از اقدامات اجرا شده مطلع شوید و تجربه کاربری بهتری داشته باشید.

<img src="https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/meowassistant.png" alt="Meow Helper" width="100%">

</details>

</details>

<details>
<summary><strong>🔍 مشکل دارید؟ اینجا کلیک کنید</strong></summary>

- نمی‌توانید به برنامه‌ها دسترسی روت بدهید؟ ماژول IntegrityBox را `غیرفعال` کنید، shamiko/nohello به حالت `blacklist mode` می‌روند و روت را آشکار می‌کنند  
- [Shamiko](https://t.me/LSPosed/292) با magisk delta (ماسک kitsune) کار نمی‌کند  
- [Shamiko](https://t.me/LSPosed/292) فقط با [Zygisk Next](https://github.com/Dr-TSNG/ZygiskNext/releases) کار می‌کند  
- اگر Play Integrity برای شما پاس نمی‌شود، روت را به‌درستی پنهان کنید. اگر از رام سفارشی استفاده می‌کنید مطمئن شوید spoofing داخلی gms را غیرفعال کرده‌اید. چطور آن را غیرفعال کنیم؟ بستگی به رام شما دارد. به گروه پشتیبانی رام خود بپیوندید و بپرسید `چطور آن را غیرفعال کنم`.  
- اگر با magisk رسمی مشکل یکپارچگی دارید، به [Magisk Alpha](https://t.me/magiskalpha/683) مهاجرت کنید.  

</details>

<details>
<summary><strong>🔗 پشتیبانی</strong></summary>

[![گروه پشتیبانی](https://ziadoua.github.io/m3-Markdown-Badges/badges/Telegram/telegram1.svg "Join our Telegram Group")](https://t.me/+NCWzd1G--UNmNDY1)  
[![حمایت مالی PayPal](https://ziadoua.github.io/m3-Markdown-Badges/badges/PayPal/paypal1.svg "Donate via PayPal")](https://paypal.me/TempMeow)

</details>

<details>
<summary><strong>🎨 پیش‌نمایش</strong></summary>

1. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/1.png)  
2. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/2.png)  
3. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/3.png)  
4. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/4.png)  
5. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/5.gif)  
6. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/6.gif)  
7. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/7.gif)  
8. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/8.png)  
9. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/9.jpg)  
10. ![](https://raw.githubusercontent.com/MeowDump/Integrity-Box/main/DUMP/10.png)

</details>

<details>
<summary><strong>📊 آمار پروژه</strong></summary>

[![GitHub Stars](https://m3-markdown-badges.vercel.app/stars/7/1/MeowDump/Integrity-Box)](https://github.com/MeowDump/Integrity-Box/stargazers)  
[![GitHub Issues](https://m3-markdown-badges.vercel.app/issues/1/1/MeowDump/Integrity-Box)](https://github.com/MeowDump/Integrity-Box/issues)  
[![GitHub Release](https://ziadoua.github.io/m3-Markdown-Badges/badges/Github/github3.svg)](https://github.com/MeowDump/Integrity-Box/releases)

</details>

_من این کد را در ابتدا در Notepad نوشتم و خیلی در GitHub فعال نبودم. اینجا بارگذاری می‌کنم تا شفافیت حفظ شود. آزادانه کد را بررسی کنید._

`اشکال‌زدایی خوبی داشته باشید!`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---