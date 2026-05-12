<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=chamanbravo&project=upstat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# آپ‌استت

> ابزار مانیتورینگ وضعیت خودمیزبان ساده و آسان برای استفاده


![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 نسخه نمایشی زنده

امتحان کنید.

سرور دمو (مکان: سنگاپور): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

نام کاربری: `demo`
رمز عبور: `demodemo`

## ⭐ ویژگی‌ها

به امکانات بیشتری نیاز دارد اما فعلاً...

- مانیتورینگ آپ‌تایم برای HTTP(s)
- نمودار وضعیت و تأخیر
- اعلان‌ها از طریق دیسکورد
- بازه‌های ۶۰ ثانیه‌ای
- رابط کاربری واکنش‌گرا، زیبا و سریع
- چندین صفحه وضعیت
- نگاشت صفحات وضعیت به دامنه‌های خاص
- نمودار پینگ
- اطلاعات گواهی
- برنامه وب پیش‌رونده (PWA)
- پشتیبانی از دیتابیس Sqlite و Postgres

و ده‌ها ویژگی کوچک دیگر که اضافه خواهند شد.

## 🔧 نحوه نصب

### 🐳 داکر

برای Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```
برای پستگرس


```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

آپ‌استت اکنون در http://localhost:3000 اجرا می‌شود

> [!مهم]
> قبل از استقرار، مطمئن شوید که مقادیر محیطی را تغییر داده‌اید.

### 💪🏻 بدون داکر

پیش‌نیازها:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (اختیاری)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## فناوری‌های مورد استفاده

- ری‌اکت
- Shadcn
- گولنگ
- پستگرس/اس‌کیوالایت

## 🙌 مشارکت

مشارکت شما را خوش‌آمد می‌گویم! مشارکت‌ها همان چیزی هستند که جامعه متن‌باز را به مکانی شگفت‌انگیز برای یادگیری، الهام گرفتن و خلق تبدیل می‌کنند. هر مشارکتی که انجام دهید **بسیار قدردانی می‌شود**.

اگر پیشنهادی دارید که می‌تواند این پروژه را بهتر کند، لطفاً مخزن را فورک کنید، تغییرات را اعمال کنید و یک درخواست کشش ایجاد کنید. همچنین می‌توانید صرفاً یک ایشو با برچسب "enhancement" باز کنید.
فراموش نکنید به پروژه ستاره بدهید! باز هم ممنون!

1. مخزن را فورک کنید
2. شاخه ویژگی خود را بسازید (`git checkout -b feature/AmazingFeature`)
3. تغییرات خود را کامیت کنید (`git commit -m 'Add some AmazingFeature'`)
4. شاخه را پوش کنید (`git push origin feature/AmazingFeature`)
5. درخواست کشش باز کنید

## مشارکت‌کنندگان

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 مجوز

این پروژه تحت [مجوز MIT](https://opensource.org/license/mit/) منتشر شده است.

## 🖼 تصاویر بیشتر

ایجاد یک مانیتور

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

صفحه مانیتور

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---