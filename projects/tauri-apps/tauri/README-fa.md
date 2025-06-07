<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## معرفی

تائوری یک فریم‌ورک برای ساخت فایل‌های اجرایی بسیار کوچک و فوق‌العاده سریع برای تمامی پلتفرم‌های دسکتاپ اصلی است. توسعه‌دهندگان می‌توانند هر فریم‌ورک فرانت‌اندی که به HTML، JS و CSS کامپایل می‌شود را برای ساخت رابط کاربری خود یکپارچه کنند. بک‌اند برنامه یک فایل اجرایی مبتنی بر rust با یک API است که فرانت‌اند می‌تواند با آن ارتباط برقرار کند.

رابط کاربری در برنامه‌های تائوری در حال حاضر از [`tao`](https://docs.rs/tao) به‌عنوان کتابخانه مدیریت پنجره در macOS، ویندوز، لینوکس، اندروید و iOS استفاده می‌کند. برای رندر برنامه شما، تائوری از [WRY](https://github.com/tauri-apps/wry) بهره می‌برد، کتابخانه‌ای که رابطی یکپارچه با WebView سیستم ارائه می‌دهد و از WKWebView در macOS و iOS، WebView2 در ویندوز، WebKitGTK در لینوکس و Android System WebView در اندروید استفاده می‌کند.

برای آگاهی بیشتر از جزئیات نحوه کنار هم قرار گرفتن این اجزا، لطفاً به این [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) مراجعه کنید.

## شروع کار

اگر علاقه‌مند به ساخت برنامه تائوری هستید، به [وب‌سایت مستندات](https://tauri.app) مراجعه کنید.

سریع‌ترین راه برای شروع، نصب [پیش‌نیازها](https://v2.tauri.app/start/prerequisites/) برای سیستم خود و ساخت یک پروژه جدید با [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage) است. برای مثال با استفاده از `npm`:

```sh
npm create tauri-app@latest
```

## ویژگی‌ها

لیست ویژگی‌های تائوری شامل موارد زیر (و فراتر از آن) است:

- باندلر داخلی برای ساخت بسته‌های برنامه با فرمت‌هایی مانند `.app`، `.dmg`، `.deb`، `.rpm`، `.AppImage` و نصب‌کننده‌های ویندوز مانند `.exe` (از طریق NSIS) و `.msi` (از طریق WiX).
- بروزرسانی خودکار داخلی (فقط دسکتاپ)
- آیکون‌های سینی سیستم
- اعلان‌های بومی
- پروتکل WebView بومی (تائوری سرور http(s) لوکال هاست برای ارائه محتویات WebView ایجاد نمی‌کند)
- اکشن GitHub برای CI یکپارچه
- افزونه VS Code

### پلتفرم‌ها

تائوری در حال حاضر از توسعه و توزیع در پلتفرم‌های زیر پشتیبانی می‌کند:

| پلتفرم     | نسخه‌ها                                                                                                         |
| :--------- | :------------------------------------------------------------------------------------------------------------- |
| ویندوز     | ۷ به بالا                                                                                                       |
| macOS      | ۱۰.۱۵ به بالا                                                                                                   |
| لینوکس     | webkit2gtk 4.0 برای تائوری نسخه ۱ (مثلاً اوبونتو 18.04). webkit2gtk 4.1 برای تائوری نسخه ۲ (مثلاً اوبونتو 22.04).|
| iOS/iPadOS | ۹ به بالا                                                                                                       |
| اندروید    | ۷ به بالا (در حال حاضر ۸ به بالا)                                                                              |

## مشارکت

پیش از شروع کار روی موضوعی، بهتر است ابتدا بررسی کنید که آیا موضوعی مشابه قبلاً ثبت نشده است. همچنین توصیه می‌شود به سرور دیسکورد مراجعه کرده و با تیم هماهنگ کنید که آیا انجام این کار منطقی است یا شخص دیگری روی آن کار نمی‌کند.

لطفاً پیش از ارسال درخواست pull، حتماً [راهنمای مشارکت](./.github/CONTRIBUTING.md) را مطالعه فرمایید.

از همه کسانی که در توسعه تائوری مشارکت دارند سپاسگزاریم!

### مستندات

مستندسازی در یک سیستم چندزبانه چالش‌برانگیز است. از این رو ما ترجیح می‌دهیم تا حد امکان از مستندسازی درون‌خطی در کد منبع Rust و JS استفاده کنیم. برای اطلاعات بیشتر به مخزن میزبان سایت مستندات مراجعه کنید: <https://github.com/tauri-apps/tauri-docs>

## شرکا

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

برای مشاهده لیست کامل حامیان مالی، لطفاً به [وب‌سایت](https://tauri.app#sponsors) و [Open Collective](https://opencollective.com/tauri) ما مراجعه کنید.

## سازمان

تائوری هدف دارد یک مجموعه پایدار بر پایه اصولی باشد که [جامعه‌های نرم‌افزار آزاد و باز پایدار](https://sfosc.org) را راهبری می‌کند. به همین منظور به عنوان یک برنامه در [Commons Conservancy](https://commonsconservancy.org/) قرار گرفته و می‌توانید از طریق [Open Collective](https://opencollective.com/tauri) به صورت مالی مشارکت کنید.

## مجوزها

کد: (c) 2015 - اکنون - برنامه تائوری در قالب The Commons Conservancy.

MIT یا MIT/Apache 2.0 در صورت کاربرد.

لوگو: CC-BY-NC-ND

- طراحی‌های اولیه لوگوی تائوری توسط [Alve Larsson](https://alve.io/)، [Daniel Thompson-Yvetot](https://github.com/nothingismagick) و [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---