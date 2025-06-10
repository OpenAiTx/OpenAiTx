<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>فرانت‌اند خود را درخشان کنید</strong> ✨
</div>

<div align="center">
  یک فریم‌ورک برای ساخت برنامه‌های وب با Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="موجود در Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="مستندات" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      وب‌سایت
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      شروع سریع
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      مرجع
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      دیسکورد
    </a>
  </h3>
</div>

<div align="center">
  <sub>ساخته شده با ❤︎ توسط
  <a href="https://twitter.com/hayleighdotdev">هیلی تامپسون</a> و
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    مشارکت‌کنندگان
  </a>
</div>

---

## فهرست مطالب

- [امکانات](#features)
- [مثال](#example)
- [فلسفه](#philosophy)
- [نصب](#installation)
- [گام بعدی](#where-next)
- [پشتیبانی](#support)

## امکانات {#features}

- یک API **اعلانی** و تابعی برای ساخت HTML. بدون قالب، بدون ماکرو،
  فقط Gleam.

- معماری الهام‌گرفته از Erlang و Elm برای **مدیریت وضعیت**.

- **مدیریت افکت‌های جانبی** برای کد قابل پیش‌بینی و تست‌پذیر.

- کامپوننت‌های جهانی. **یک بار بنویس، همه‌جا اجرا کن**. ترکیب Elm و Phoenix LiveView.

- **CLI با همه ابزارهای مورد نیاز** که ساختاردهی و ساخت برنامه‌ها را بسیار آسان می‌کند.

- **رندر سمت سرور** برای قالب‌بندی HTML استاتیک.

## مثال {#example}

Lustre با [بیش از ۲۰ مثال](https://hexdocs.pm/lustre/reference/examples.html) ارائه می‌شود!
نمونه‌ای از آن را ببینید:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## فلسفه {#philosophy}

Lustre یک فریم‌ورک _نظر محور_ برای ساخت برنامه‌های وب کوچک تا متوسط است. توسعه فرانت‌اند مدرن دشوار و پیچیده است. بخشی از این پیچیدگی ضروری است، اما بخش زیادی از آن تصادفی است یا ناشی از وجود گزینه‌های بیش از حد زیاد است. Lustre همان فلسفه طراحی Gleam را دارد: تا حد امکان، باید فقط یک راه برای انجام کارها وجود داشته باشد.

این یعنی عرضه با یک سیستم مدیریت وضعیت واحد به صورت پیش‌فرض، مدل‌سازی شده بر اساس Elm و Erlang/OTP. هر برنامه Lustre را باز کنید باید احساس آشنایی داشته باشید.

همچنین ما رویکردهای ساده برای ساخت نماها را به رویکردهای پیچیده ترجیح می‌دهیم. Lustre _راهی_ برای ساخت کامپوننت‌های کپسوله‌شده با وضعیت (چیزی که در Elm کم داشتیم) دارد، اما نباید پیش‌فرض باشد. توابع ساده را به کامپوننت‌های دارای وضعیت ترجیح دهید.

هرجا که کامپوننت‌ها _ضروری_ باشند، از این واقعیت استفاده کنید که کامپوننت‌های Lustre می‌توانند _همه‌جا_ اجرا شوند. Lustre ابزارهایی برای نوشتن کامپوننت‌هایی به شما می‌دهد که می‌توانند درون یک برنامه Lustre، به صورت Web Component مستقل، یا روی سرور با حداقل ران‌تایم برای وصله کردن DOM اجرا شوند. Lustre به این‌ها **کامپوننت‌های جهانی** می‌گوید و آن‌ها با در نظر گرفتن چندین تارگت Gleam نوشته می‌شوند.

## نصب {#installation}

Lustre در [Hex](https://hex.pm/packages/lustre) منتشر شده است! می‌توانید آن را از طریق خط فرمان به پروژه‌های Gleam خود اضافه کنید:

```sh
gleam add lustre
```

Lustre همچنین یک پکیج همراه شامل ابزار توسعه دارد که ممکن است بخواهید نصب کنید:

> **نکته**: سرور توسعه lustre_dev_tools فایل‌های شما را برای تغییرات در کد gleam بررسی می‌کند و می‌تواند مرورگر را به طور خودکار بارگذاری مجدد کند. برای کاربران لینوکس لازم است [inotify-tools]() نصب باشد.

```sh
gleam add --dev lustre_dev_tools
```

## گام بعدی {#where-next}

برای شروع سریع با Lustre، [راهنمای شروع سریع](https://hexdocs.pm/lustre/guide/01-quickstart.html) را ببینید.
اگر ترجیح می‌دهید کد ببینید، پوشه [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
شامل چند برنامه کوچک است که جنبه‌های مختلف این فریم‌ورک را نمایش می‌دهند.

همچنین می‌توانید مستندات و مرجع API را در
[HexDocs](https://hexdocs.pm/lustre) مطالعه کنید.

## پشتیبانی {#support}

Lustre عمدتاً توسط من، [هیلی](https://github.com/hayleigh-dot-dev)،
در کنار دو شغل دیگر توسعه داده می‌شود. اگر دوست دارید از کار من حمایت کنید، می‌توانید [در GitHub اسپانسر من شوید](https://github.com/sponsors/hayleigh-dot-dev).

مشارکت نیز بسیار خوشایند است! اگر باگی مشاهده کردید یا پیشنهادی برای افزودن قابلیت جدید دارید، لطفاً یک issue یا pull request باز کنید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---