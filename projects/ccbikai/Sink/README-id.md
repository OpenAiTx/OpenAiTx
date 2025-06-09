# ⚡ Sink

**Pemendek Tautan Sederhana / Cepat / Aman dengan Analitik, 100% berjalan di Cloudflare.**

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

## ✨ Fitur

- **Pemendekan URL:** Memadatkan URL Anda ke panjang minimal.
- **Analitik:** Pantau analitik tautan dan kumpulkan statistik yang bermanfaat.
- **Serverless:** Deploy tanpa membutuhkan server tradisional.
- **Slug Kustom:** Mendukung slug yang dipersonalisasi dan case-sensitive.
- **🪄 AI Slug:** Memanfaatkan AI untuk menghasilkan slug.
- **Kedaluwarsa Tautan:** Atur tanggal kedaluwarsa untuk tautan Anda.

## 🪧 Demo

Coba demonya di [Sink.Cool](https://sink.cool/dashboard). Masuk menggunakan Site Token di bawah:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Tangkapan Layar</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Teknologi yang Digunakan

- **Framework**: [Nuxt](https://nuxt.com/)
- **Database**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Mesin Analitik**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **Komponen UI**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Styling:** [Tailwind CSS](https://tailwindcss.com/)
- **Deploy**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Roadmap [Sedang Dikerjakan]

Kami menyambut kontribusi dan PR dari Anda.

- [x] Ekstensi Browser
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Ekstensi Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Apple Shortcuts
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] Aplikasi iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Manajemen Tautan yang Ditingkatkan (dengan Cloudflare D1)
- [ ] Peningkatan Analitik (Dukungan untuk penggabungan kondisi filter)
- [ ] Optimasi Performa Dashboard (Infinite loading)
- [ ] Units Test

## 🏗️ Deploy

> Video tutorial: [Tonton di sini](https://www.youtube.com/watch?v=MkU23U2VE9E)

Saat ini kami mendukung deploy ke [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (disarankan) dan [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Konfigurasi

[Dokumentasi Konfigurasi](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Dokumentasi API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Saat ini kami belum mendukung MCP Server native, namun kami memiliki dokumentasi OpenAPI, dan Anda dapat menggunakan metode berikut untuk mendukung MCP.

> Ganti nama domain pada `OPENAPI_SPEC_URL` dengan domain Anda sendiri.
>
> `API_KEY` sama dengan `NUXT_SITE_TOKEN` di variabel lingkungan.

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

## 🙋🏻 FAQ

[FAQ](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 Kredit

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Sponsor

1. [Ikuti Saya di X(Twitter)](https://404.li/kai).
2. [Jadi sponsor di GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---