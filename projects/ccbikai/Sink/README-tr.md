# ⚡ Sink

**Basit / Hızlı / Güvenli Link Kısaltıcı, Analitik ile birlikte, %100 Cloudflare üzerinde çalışır.**

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

## ✨ Özellikler

- **URL Kısaltma:** URL’lerinizi minimum uzunluğa sıkıştırın.
- **Analitik:** Link analitiklerini izleyin ve anlamlı istatistikler toplayın.
- **Sunucusuz:** Geleneksel sunuculara ihtiyaç duymadan dağıtım yapın.
- **Özelleştirilebilir Slug:** Kişiselleştirilmiş slug ve büyük/küçük harf duyarlılığı desteği.
- **🪄 Yapay Zeka Slug:** Slug üretiminde yapay zekadan faydalanın.
- **Link Süre Sonu:** Linkleriniz için son kullanma tarihi belirleyin.

## 🪧 Demo

Demosunu [Sink.Cool](https://sink.cool/dashboard) adresinde deneyimleyin. Aşağıdaki Site Token ile giriş yapabilirsiniz:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Ekran Görüntüleri</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Kullanılan Teknolojiler

- **Çatı**: [Nuxt](https://nuxt.com/)
- **Veritabanı**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Analitik Motoru**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **UI Bileşenleri**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Stil:** [Tailwind CSS](https://tailwindcss.com/)
- **Dağıtım**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Yol Haritası [WIP]

Katkılarınızı ve PR’larınızı bekliyoruz.

- [x] Tarayıcı Eklentisi
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Raycast Eklentisi
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Apple Kestirmeleri
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] iOS Uygulaması
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Gelişmiş Link Yönetimi (Cloudflare D1 ile)
- [ ] Analitik Geliştirmeleri (Filtre koşullarının birleştirilmesi desteği)
- [ ] Panel Performans Optimizasyonu (Sonsuz yükleme)
- [ ] Birim Testi

## 🏗️ Dağıtım

> Video eğitimi: [Buradan izleyin](https://www.youtube.com/watch?v=MkU23U2VE9E)

Şu anda [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (önerilen) ve [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md) üzerine dağıtımı destekliyoruz.

## ⚒️ Yapılandırma

[Yapılandırma Dokümanı](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[API Dokümanı](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Şu anda yerel MCP Sunucusu desteğimiz yok, fakat OpenAPI dokümantasyonumuz mevcut ve aşağıdaki yöntemle MCP desteği sağlayabilirsiniz.

> `OPENAPI_SPEC_URL` içindeki alan adını kendi alan adınızla değiştirin.
>
> `API_KEY` ortam değişkenlerindeki `NUXT_SITE_TOKEN` ile aynıdır.

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

## 🙋🏻 SSS

[SSS](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 Katkıda Bulunanlar

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Sponsor

1. [X(Twitter) Üzerinden Takip Edin](https://404.li/kai).
2. [GitHub üzerinden sponsor olun](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---