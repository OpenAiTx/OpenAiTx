<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 یک پلتفرم قدرتمند و قابل استقرار محلی که برای شناسایی بدون وقفه SQL و حسابرسی کوئری، به طور خاص برای مدیران پایگاه داده (DBA) و توسعه‌دهندگان طراحی شده است. با تمرکز بر حریم خصوصی و کارایی، محیطی شهودی و ایمن برای حسابرسی MYSQL فراهم می‌کند.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![پشتیبانی از پلتفرم](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![زبان برتر گیت‌هاب](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![دانلودها](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ ویژگی‌ها

- **دستیار هوش مصنوعی**: دستیار هوشمند ما پیشنهادات بهینه‌سازی SQL را به صورت بلادرنگ ارائه می‌دهد و عملکرد SQL را ارتقاء می‌بخشد. همچنین تبدیل متن به SQL را پشتیبانی می‌کند و به کاربران اجازه می‌دهد زبان طبیعی وارد کرده و جملات SQL بهینه دریافت کنند.
  
- **حسابرسی SQL**: ساخت تیکت حسابرسی SQL با جریان‌های تأیید و بررسی خودکار نحوی. اعتبارسنجی جملات SQL از لحاظ صحت، امنیت و تطابق با استانداردها. جملات بازگردانی (rollback) برای عملیات DDL/DML به طور خودکار تولید می‌شوند و تاریخچه‌ای جامع برای ردیابی فراهم می‌گردد.

- **حسابرسی کوئری**: حسابرسی کوئری کاربران، محدودسازی منابع داده و پایگاه داده‌ها، و ناشناس‌سازی فیلدهای حساس. سوابق کوئری برای مراجعات بعدی ذخیره می‌شود.

- **قوانین بررسی**: چکر نحوی خودکار ما از مجموعه وسیعی از قوانین بررسی پشتیبانی می‌کند که برای اکثر سناریوهای بررسی خودکار مناسب است.

- **تمرکز بر حریم خصوصی**: Yearning یک راهکار متن‌باز و قابل استقرار محلی است که امنیت پایگاه داده و جملات SQL شما را تضمین می‌کند. مکانیزم‌های رمزنگاری جهت محافظت از داده‌های حساس دارد تا حتی در صورت دسترسی غیرمجاز نیز ایمن باقی بمانند.

- **RBAC (کنترل دسترسی مبتنی بر نقش)**: ایجاد و مدیریت نقش‌ها با مجوزهای خاص، محدودسازی دسترسی به سفارشات کوئری، عملکردهای حسابرسی و سایر عملیات حساس بر اساس نقش کاربری.

> \[!TIP]
> برای اطلاعات بیشتر، به [راهنمای Yearning](https://next.yearning.io) مراجعه کنید.


## ⚙️ نصب

[آخرین نسخه](https://github.com/cookieY/Yearning/releases/latest) را دانلود و استخراج کنید. مطمئن شوید که `./config.toml` را قبل از ادامه پیکربندی کرده‌اید.

### نصب دستی

```bash
## پایگاه داده را مقداردهی اولیه کنید
./Yearning install

## اجرای Yearning
./Yearning run

## راهنما
./Yearning --help
```

### 🚀 استقرار با Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## مقداردهی اولیه پایگاه داده
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## اجرای Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 دستیار هوش مصنوعی

دستیار هوش مصنوعی ما با بهره‌گیری از مدل‌های زبانی بزرگ، پیشنهادات بهینه‌سازی SQL و تبدیل متن به SQL را ارائه می‌دهد. چه از پرامپت‌های پیش‌فرض یا سفارشی استفاده کنید، این دستیار با بهینه‌سازی جملات و تبدیل ورودی زبان طبیعی به کوئری‌های SQL، عملکرد SQL را ارتقاء می‌دهد.

![تبدیل متن به SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 چکر خودکار SQL

چکر خودکار SQL جملات SQL را بر اساس قوانین و نحوی از پیش تعریف‌شده ارزیابی می‌کند. این ابزار اطمینان می‌دهد که جملات با استانداردهای کدنویسی، بهترین رویه‌ها و الزامات امنیتی مطابقت دارند و لایه‌ای قوی از اعتبارسنجی فراهم می‌کند.

![حسابرسی SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 برجسته‌سازی نحوی و تکمیل خودکار SQL

کارایی نگارش کوئری خود را با برجسته‌سازی نحوی SQL و تکمیل خودکار افزایش دهید. این قابلیت‌ها به کاربران کمک می‌کند تا اجزای مختلف یک کوئری SQL مانند کلیدواژه‌ها، نام جداول، نام ستون‌ها و عملگرها را به صورت بصری تشخیص دهند و ساختار کوئری را راحت‌تر بخوانند و درک کنند.

![کوئری SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ رکورد سفارش/کوئری

پلتفرم ما از حسابرسی جملات سفارش و کوئری کاربران پشتیبانی می‌کند. این قابلیت به شما اجازه می‌دهد تمامی عملیات کوئری را از جمله منابع داده، پایگاه‌های داده و مدیریت فیلدهای حساس ردیابی و ثبت کنید تا تطابق با مقررات و قابلیت ردیابی تاریخچه کوئری‌ها تضمین شود.

![رکورد سفارش/کوئری](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Yearning با تمرکز بر این ویژگی‌های کلیدی، تجربه کاربری را ارتقاء می‌دهد، عملکرد SQL را بهینه می‌کند و تطابق و ردیابی قدرتمندی را در عملیات پایگاه داده تضمین می‌کند.

## 🛠️ ابزارهای پیشنهادی

- [Spug - پلتفرم متن‌باز و سبک عملیات اتوماسیون](https://github.com/openspug/spug)

## ☎️ تماس

برای پرسش‌ها، لطفاً به ایمیل زیر پیام دهید: henry@yearning.io
## 📋 مجوز

Yearning تحت مجوز AGPL منتشر شده است. برای جزئیات بیشتر به [LICENSE](LICENSE) مراجعه کنید.

2024 © هنری یی

---

با Yearning، رویکردی ساده، امن و کارآمد برای ممیزی و بهینه‌سازی SQL را تجربه کنید.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---