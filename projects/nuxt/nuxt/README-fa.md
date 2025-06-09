[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# ناکست

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

ناکس یک فریم‌ورک رایگان و متن‌باز است که روشی شهودی و قابل گسترش برای ایجاد برنامه‌ها و وب‌سایت‌های فول‌استک، ایمن از نظر نوع، با عملکرد بالا و در سطح تولید با Vue.js ارائه می‌دهد.

این فریم‌ورک ویژگی‌های متعددی را ارائه می‌دهد که ساخت برنامه‌های وب سریع، سازگار با SEO و مقیاس‌پذیر را آسان می‌کند، از جمله:
- رندر سمت سرور، تولید سایت استاتیک، رندر هیبرید و رندر سمت Edge
- مسیردهی خودکار همراه با تقسیم کد و پیش‌بارگذاری
- واکشی داده و مدیریت وضعیت
- بهینه‌سازی سئو و تعریف متاتگ‌ها
- وارد کردن خودکار کامپوننت‌ها، کامپوزبل‌ها و ابزارها
- تایپ‌اسکریپت بدون نیاز به پیکربندی
- توسعه فول‌استک با دایرکتوری server/
- قابل گسترش با [بیش از ۲۰۰ ماژول](https://nuxt.com/modules)
- استقرار روی انواع [سکوی میزبانی](https://nuxt.com/deploy)
- ...[و خیلی بیشتر](https://nuxt.com) 🚀

### فهرست مطالب

- 🚀 [شروع سریع](#getting-started)
- 💻 [توسعه Vue](#vue-development)
- 📖 [مستندات](#documentation)
- 🧩 [ماژول‌ها](#modules)
- ❤️  [مشارکت](#contribute)
- 🏠 [توسعه محلی](#local-development)
- 🛟 [پشتیبانی حرفه‌ای](#professional-support)
- 🔗 [ما را دنبال کنید](#follow-us)
- ⚖️ [مجوز](#license)

---

## <a name="getting-started">🚀 شروع سریع</a>

از دستور زیر برای ایجاد یک پروژه ابتدایی جدید استفاده کنید. این دستور پروژه‌ای با همه فایل‌ها و وابستگی‌های لازم ایجاد می‌کند:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> [nuxt.new](https://nuxt.new) را نیز امتحان کنید: یک پروژه استارتر ناکست را در CodeSandbox، StackBlitz یا به صورت محلی باز کنید و در عرض چند ثانیه شروع به کار کنید.

## <a name="vue-development">💻 توسعه Vue</a>

ساده، شهودی و قدرتمند؛ ناکست به شما اجازه می‌دهد کامپوننت‌های Vue را به روشی منطقی بنویسید. هر کار تکراری به‌صورت خودکار انجام می‌شود تا بتوانید با اطمینان روی نوشتن اپلیکیشن فول‌استک Vue خود تمرکز کنید.

نمونه‌ای از فایل `app.vue`:

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 مستندات</a>

توصیه اکید می‌کنیم که [مستندات ناکست](https://nuxt.com/docs) را مرور کنید تا سطح دانش خود را ارتقا دهید. این یک منبع عالی برای یادگیری بیشتر درباره فریم‌ورک است و همه موضوعات از شروع تا مباحث پیشرفته را پوشش می‌دهد.

## <a name="modules">🧩 ماژول‌ها</a>

[فهرست ماژول‌های ما](https://nuxt.com/modules) را کشف کنید تا پروژه ناکست خود را با ماژول‌هایی که توسط تیم و جامعه ناکست ساخته شده‌اند، تقویت کنید.

## <a name="contribute">❤️ مشارکت</a>

ما شما را دعوت می‌کنیم تا در بهبود ناکست مشارکت کنید 💚

راه‌هایی برای همکاری:
- **گزارش باگ:** اگر با باگ یا مشکلی مواجه شدید، لطفاً [راهنمای گزارش باگ](https://nuxt.com/docs/community/reporting-bugs) را مطالعه کنید تا نحوه ارسال گزارش را بیاموزید.
- **پیشنهادات:** ایده‌ای برای ارتقای ناکست دارید؟ مشتاق شنیدن آن هستیم! [راهنمای مشارکت](https://nuxt.com/docs/community/contribution) را برای ارسال پیشنهادات خود ببینید.
- **سوالات:** اگر سوالی دارید یا به کمک نیاز دارید، [راهنمای دریافت کمک](https://nuxt.com/docs/community/getting-help) منابع لازم را در اختیار شما قرار می‌دهد.

## <a name="local-development">🏠 توسعه محلی</a>

برای مشارکت در فریم‌ورک و مستندات، دستورالعمل [راه‌اندازی محیط توسعه محلی](https://nuxt.com/docs/community/framework-contribution#setup) را دنبال کنید.

## <a name="professional-support">🛟 پشتیبانی حرفه‌ای</a>

- ممیزی فنی و مشاوره: [متخصصین ناکست](https://nuxt.com/enterprise/support)
- توسعه سفارشی و بیشتر: [شرکای آژانس ناکست](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 ما را دنبال کنید</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ مجوز</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---