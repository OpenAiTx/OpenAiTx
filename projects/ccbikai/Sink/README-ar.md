# ⚡ سينك

**مُختصر روابط بسيط / سريع / آمن مع تحليلات، يعمل 100% على Cloudflare.**

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

## ✨ الميزات

- **اختصار الروابط:** تقليص عناوين URL الخاصة بك إلى أقصر طول ممكن.
- **التحليلات:** راقب تحليلات الروابط واجمع إحصائيات مفيدة.
- **بدون خوادم:** انشر بدون الحاجة إلى خوادم تقليدية.
- **رابط مخصص:** دعم للروابط المخصصة وحساسية حالة الأحرف.
- **🪄 رابط بالذكاء الاصطناعي:** استخدام الذكاء الاصطناعي لتوليد الروابط القصيرة.
- **انتهاء صلاحية الروابط:** تعيين تواريخ انتهاء صلاحية لروابطك.

## 🪧 تجربة العرض

جرب العرض التوضيحي على [Sink.Cool](https://sink.cool/dashboard). سجّل الدخول باستخدام رمز الموقع أدناه:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>صور الشاشة</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 التقنيات المستخدمة

- **الإطار:** [Nuxt](https://nuxt.com/)
- **قاعدة البيانات:** [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **محرك التحليلات:** [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **مكونات الواجهة:** [shadcn-vue](https://www.shadcn-vue.com/)
- **التصميم:** [Tailwind CSS](https://tailwindcss.com/)
- **النشر:** [Cloudflare](https://www.cloudflare.com/)

## 🚗 خارطة الطريق [قيد العمل]

نرحب بمساهماتكم وطلبات السحب.

- [x] إضافة للمتصفح
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] إضافة Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] اختصارات أبل
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] تطبيق iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] إدارة روابط محسّنة (مع Cloudflare D1)
- [ ] تحسينات التحليلات (دعم دمج شروط التصفية)
- [ ] تحسين أداء لوحة التحكم (تحميل لانهائي)
- [ ] اختبارات وحدات

## 🏗️ النشر

> فيديو تعليمي: [شاهد هنا](https://www.youtube.com/watch?v=MkU23U2VE9E)

ندعم حاليًا النشر على [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (موصى به) و[Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ الإعداد

[دليل الإعداد](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 واجهة برمجة التطبيقات

[دليل API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

لا ندعم حاليًا خادم MCP أصلي، لكن لدينا وثائق OpenAPI، ويمكنك استخدام الطريقة التالية لدعم MCP.

> استبدل اسم النطاق في `OPENAPI_SPEC_URL` باسم نطاقك الخاص.
>
> مفتاح `API_KEY` هو نفسه `NUXT_SITE_TOKEN` في متغيرات البيئة.

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

## 🙋🏻 الأسئلة الشائعة

[الأسئلة الشائعة](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 الشكر والتقدير

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ الرعاة

1. [تابعني على X(تويتر)](https://404.li/kai).
2. [كن راعياً على GitHub](https://github.com/sponsors/ccbikai).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---