# ⚡ Sink

**یک کوتاه‌کننده لینک ساده / سریع / امن با تحلیل‌گر، ۱۰۰٪ اجرا شده بر بستر Cloudflare.**

<a href="https://trendshift.io/repositories/10421" target="_blank">
  <img
    src="https://trendshift.io/api/badge/repositories/10421"
    alt="ccbikai/Sink | Trendshift"
    width="250"
    height="55"
  />
</a>
<a href="https://news.ycombinator.com/item?id=40843683" target="_blank">
  <img
    src="https://hackernews-badge.vercel.app/api?id=40843683"
    alt="Featured on Hacker News"
    width="250"
    height="55"
  />
</a>
<a href="https://hellogithub.com/repository/57771fd91d1542c7a470959b677a9944" target="_blank">
  <img
    src="https://abroad.hellogithub.com/v1/widgets/recommend.svg?rid=57771fd91d1542c7a470959b677a9944&claim_uid=qi74Zp23wYKeAVB&theme=neutral"
    alt="Featured｜HelloGitHub"
    width="250"
    height="55"
  />
</a>
<a href="https://www.uneed.best/tool/sink" target="_blank">
  <img
    src="https://www.uneed.best/POTW1.png"
    alt="Uneed Badge"
    width="250"
    height="55"
  />
</a>

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="DeepWiki" height="20"/>](https://deepwiki.com/ccbikai/Sink)
![Cloudflare](https://img.shields.io/badge/Cloudflare-F69652?style=flat&logo=cloudflare&logoColor=white)
![Nuxt](https://img.shields.io/badge/Nuxt-00DC82?style=flat&logo=nuxtdotjs&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-06B6D4?style=flat&logo=tailwindcss&logoColor=white)
![shadcn/ui](https://img.shields.io/badge/shadcn/ui-000000?style=flat&logo=shadcnui&logoColor=white)

![Hero](https://raw.githubusercontent.com/ccbikai/Sink/master/public/image.png)

----

## ✨ قابلیت‌ها

- **کوتاه‌سازی URL:** آدرس‌های اینترنتی خود را به حداقل طول ممکن فشرده کنید.
- **تحلیل‌گر:** آمار و داده‌های تحلیلی لینک‌هایتان را مشاهده کنید.
- **بدون سرور:** بدون نیاز به سرور سنتی مستقر کنید.
- **شناسه سفارشی:** پشتیبانی از شناسه (اسلاگ) سفارشی و حساس به حروف کوچک و بزرگ.
- **🪄 اسلاگ هوشمند:** تولید اسلاگ توسط هوش مصنوعی.
- **انقضای لینک:** تعیین تاریخ انقضا برای لینک‌ها.

## 🪧 دمو

دمو را در [Sink.Cool](https://sink.cool/dashboard) تجربه کنید. با استفاده از توکن سایت زیر وارد شوید:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>تصاویر محیط کاربری</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 فناوری‌های استفاده‌شده

- **فریم‌ورک:** [Nuxt](https://nuxt.com/)
- **پایگاه داده:** [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **موتور تحلیل:** [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **کامپوننت‌های رابط کاربری:** [shadcn-vue](https://www.shadcn-vue.com/)
- **استایل‌دهی:** [Tailwind CSS](https://tailwindcss.com/)
- **استقرار:** [Cloudflare](https://www.cloudflare.com/)

## 🚗 نقشه راه [در حال توسعه]

از مشارکت و PRهای شما استقبال می‌کنیم.

- [x] افزونه مرورگر
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] افزونه Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] میانبرهای اپل
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] اپلیکیشن iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] مدیریت پیشرفته لینک (با Cloudflare D1)
- [ ] ارتقاء تحلیل‌گر (پشتیبانی از ادغام شرایط فیلتر)
- [ ] بهینه‌سازی عملکرد داشبورد (بارگذاری بی‌نهایت)
- [ ] تست واحد

## 🏗️ استقرار

> آموزش ویدیویی: [اینجا ببینید](https://www.youtube.com/watch?v=MkU23U2VE9E)

در حال حاضر از استقرار روی [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (توصیه‌شده) و [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md) پشتیبانی می‌کنیم.

## ⚒️ پیکربندی

[مستندات پیکربندی](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[مستندات API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

در حال حاضر از MCP Server بومی پشتیبانی نمی‌کنیم، اما مستندات OpenAPI را داریم و می‌توانید با روش زیر از MCP پشتیبانی کنید.

> نام دامنه موجود در `OPENAPI_SPEC_URL` را با دامنه خودتان جایگزین کنید.
>
> مقدار `API_KEY` همان `NUXT_SITE_TOKEN` در متغیرهای محیطی است.

```json
{
  "mcpServers": {
    "sink": {
      "command": "uvx",
      "args": [
        "mcp-openapi-proxy"
      ],
      "env": {
        "OPENAPI_SPEC_URL": "https://sink.cool/_docs/openapi.json",
        "API_KEY": "SinkCool",
        "TOOL_WHITELIST": "/api/link/create"
      }
    }
  }
}
```

## 🙋🏻 سوالات متداول

[سوالات متداول](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 اعتبارها

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ حمایت

1. [من را در X(توییتر) دنبال کنید](https://404.li/kai).
2. [حامی من در گیت‌هاب شوید](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---