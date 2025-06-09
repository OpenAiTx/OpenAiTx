# ⚡ Sink

**Prosty / Szybki / Bezpieczny skracacz linków z analizą, w 100% oparty na Cloudflare.**

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

## ✨ Funkcje

- **Skracanie URL:** Kompresuj swoje adresy URL do minimalnej długości.
- **Analiza:** Monitoruj analitykę linków i zbieraj cenne statystyki.
- **Serverless:** Wdrażaj bez potrzeby tradycyjnych serwerów.
- **Personalizowany Slug:** Obsługa spersonalizowanych slugów i rozróżniania wielkości liter.
- **🪄 AI Slug:** Wykorzystaj AI do generowania slugów.
- **Wygasanie linków:** Ustaw datę wygaśnięcia dla swoich linków.

## 🪧 Demo

Wypróbuj demo na [Sink.Cool](https://sink.cool/dashboard). Zaloguj się używając poniższego Site Token:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Zrzuty ekranu</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Wykorzystane technologie

- **Framework**: [Nuxt](https://nuxt.com/)
- **Baza danych**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Silnik analityczny**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **Komponenty UI**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Stylowanie:** [Tailwind CSS](https://tailwindcss.com/)
- **Wdrażanie**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Roadmap [WIP]

Zapraszamy do współtworzenia i przesyłania PR.

- [x] Rozszerzenie przeglądarki
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Rozszerzenie Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Skróty Apple
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] Aplikacja iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Zaawansowane zarządzanie linkami (z Cloudflare D1)
- [ ] Ulepszenia analityki (Wsparcie dla łączenia warunków filtrów)
- [ ] Optymalizacja wydajności dashboardu (ładowanie nieskończone)
- [ ] Testy jednostkowe

## 🏗️ Wdrażanie

> Samouczek wideo: [Obejrzyj tutaj](https://www.youtube.com/watch?v=MkU23U2VE9E)

Obecnie wspieramy wdrażanie na [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (zalecane) oraz [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Konfiguracja

[Dokumentacja konfiguracji](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Dokumentacja API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Obecnie nie wspieramy natywnego MCP Server, ale mamy dokumentację OpenAPI i można użyć poniższej metody do obsługi MCP.

> Zamień nazwę domeny w `OPENAPI_SPEC_URL` na swoją własną.
>
> `API_KEY` jest taki sam jak `NUXT_SITE_TOKEN` w zmiennych środowiskowych.

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

## 💖 Podziękowania

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Sponsoruj

1. [Obserwuj mnie na X(Twitter)](https://404.li/kai).
2. [Zostań sponsorem na GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---