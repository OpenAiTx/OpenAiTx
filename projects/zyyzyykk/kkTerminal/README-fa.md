# kkTerminal

> kkTerminal، یک ترمینال برای اتصال SSH تحت وب  
> نویسنده: [zyyzyykk](https://github.com/zyyzyykk/)  
> کد منبع: https://github.com/zyyzyykk/kkTerminal  
> آدرس Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general  
> پیش‌نمایش: https://ssh.kkbpro.com/  
> زمان بروزرسانی: 2025-03-15  
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ ادغام سریع

استفاده از تگ `iframe` در صفحات HTML برای ادغام سریع:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 استقرار با Docker

1. دریافت ایمیج:

```bash
docker pull zyyzyykk/kkterminal
```

2. ایجاد و اجرای کانتینر با نگاشت پورت: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. سفارشی‌سازی واژه هنری: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. دسترسی در مرورگر: `http://server-ip:3000/`

### 🛸 پیش‌نمایش

از وبسایت زیر بازدید کنید: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**پیش‌نمایش ماژول‌های بیشتر**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 توضیحات عملکرد

1. kkTerminal یک ترمینال برای اتصال SSH تحت وب است. روی آیکن ترمینال در گوشه بالا سمت چپ کلیک کرده و تنظیمات اتصال را انتخاب کنید تا ارتباط SSH برقرار شود.

2. پشتیبانی از استفاده از تگ `iframe` در صفحات وب برای ادغام سریع در سایت‌های شخص ثالث

3. پشتیبانی از سفارشی‌سازی تنظیمات ترمینال از طریق [پارامترهای URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. پشتیبانی از بین‌المللی‌سازی و امکان تغییر زبان بین چینی و انگلیسی

5. پشتیبانی از استقرار محلی روی PC، هنگام اجرا به صورت خودکار پنجره مرورگر را باز می‌کند

6. پشتیبانی از اندازه پنجره تطبیقی و ورودی چینی

7. پشتیبانی از تنظیمات ترجیحات سفارشی، امکان انتخاب رنگ پس‌زمینه/پیش‌زمینه، اندازه فونت، سبک نمایش مکان‌نما، فعال‌سازی TCode برای ترمینال و غیره

8. پشتیبانی از راه‌اندازی مجدد: پس از تغییر تنظیمات اتصال SSH یا تنظیمات ترجیحی، به صورت خودکار راه‌اندازی مجدد می‌شود یا پس از قطع ارتباط SSH می‌توان به صورت دستی راه‌اندازی مجدد کرد

9. پشتیبانی از کپی و چسباندن:

   - کپی: مشابه ترمینال `Git`، انتخاب متن به صورت خودکار آن را کپی می‌کند

   - چسباندن: مشابه ترمینال `Cmd`، با راست کلیک چسباندن انجام می‌شود (نیاز به مجوز مرورگر دارد)

9. پشتیبانی از مدیریت فایل، باز کردن ماژول مدیریت فایل برای مشاهده، استخراج، بارگذاری و دانلود فایل‌ها/پوشه‌ها

10. پشتیبانی از عملیات کلیدهای میانبر مانند انتخاب چندتایی/همه فایل‌ها، کپی و چسباندن، برش، تغییر انتخاب، باز کردن و غیره

11. پشتیبانی از مرور و ویرایش فایل، ویرایش فایل و ذخیره آن در سرور راه دور با استفاده از `ctrl+s`

12. پشتیبانی از [TCode (کد ترمینال)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md)، که می‌تواند گردش کار خودکار مشابه اسکریپت‌های Shell را از طریق TCode سفارشی ایجاد کند

13. پشتیبانی از ضبط عملیات و همگام‌سازی ابری

14. پشتیبانی از عملکردهای همکاری، نظارت و Docker

### 👨‍💻 سوابق بروزرسانی

##### zyyzyykk/kkterminal:3.6.0: آخرین

- افزودن عملکرد همکاری پیشرفته
- افزودن عملکرد نظارت پیشرفته
- افزودن عملکرد Docker پیشرفته
- بهینه‌سازی حجم بسته و نمایش وب‌سایت

##### zyyzyykk/kkterminal:3.5.6:

- پشتیبانی از پارامترهای بیشتر URL
- افزودن درصد اندازه متن و تصویر در ویرایشگر
- بهینه‌سازی نمایش وب‌سایت

##### zyyzyykk/kkterminal:3.5.3:

- افزودن پارامتر URL برای سفارشی‌سازی تنظیمات ترمینال
- رفع باگ راه‌اندازی مجدد چند پنجره‌ای
- افزودن ضبط عملیات و عملکرد همگام‌سازی ابری
- بازنویسی برخی منطق‌های کد

[**سوابق بروزرسانی تاریخی**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 معماری

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ درباره این پروژه

کاربران گرامی،

با کمال تأسف اعلام می‌کنم که به دلیل محدودیت زمانی و انرژی، دیگر قادر به نگهداری `kkTerminal` در آینده نخواهم بود.

اگر به `kkTerminal` علاقه دارید یا مایل به ادامه نگهداری آن هستید، لطفاً با من تماس بگیرید یا یک issue ثبت کنید.

اگر باگ یا مشکلی پیدا کردید یا مایل به توسعه ویژگی‌های جدید بودید، لطفاً issue ایجاد کنید.

در پایان، از حمایت شما از `kkTerminal` سپاسگزارم و صمیمانه آرزو دارم که `kkTerminal` واقعاً به شما کمک کند.

با احترام،  
[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 ستاره‌ها

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---