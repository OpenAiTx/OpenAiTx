# ⚡ Sink

**Een eenvoudige / snelle / veilige linkverkorter met analytics, 100% draaiend op Cloudflare.**

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

## ✨ Functionaliteiten

- **URL-verkorting:** Verkort je URL's tot de minimale lengte.
- **Analytics:** Monitor linkstatistieken en verzamel waardevolle inzichten.
- **Serverless:** Deploy zonder traditionele servers.
- **Aanpasbare Slug:** Ondersteuning voor gepersonaliseerde slugs en hoofdlettergevoeligheid.
- **🪄 AI Slug:** Gebruik AI om slugs te genereren.
- **Linkverval:** Stel vervaldatums in voor je links.

## 🪧 Demo

Bekijk de demo op [Sink.Cool](https://sink.cool/dashboard). Log in met de onderstaande Site Token:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Schermafbeeldingen</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Gebruikte technologieën

- **Framework**: [Nuxt](https://nuxt.com/)
- **Database**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Analytics Engine**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **UI-componenten**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Styling:** [Tailwind CSS](https://tailwindcss.com/)
- **Deploy:** [Cloudflare](https://www.cloudflare.com/)

## 🚗 Roadmap [WIP]

We verwelkomen je bijdragen en PR's.

- [x] Browserextensie
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Raycast-extensie
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Apple Shortcuts
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] iOS App
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Verbeterd linkbeheer (met Cloudflare D1)
- [ ] Analytics verbeteringen (ondersteuning voor samenvoegen van filtervoorwaarden)
- [ ] Dashboard prestatie-optimalisatie (oneindig laden)
- [ ] Unittests

## 🏗️ Deployment

> Videotutorial: [Bekijk hier](https://www.youtube.com/watch?v=MkU23U2VE9E)

We ondersteunen momenteel deployment naar [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (aanbevolen) en [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Configuratie

[Configuratie Docs](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[API Docs](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

We ondersteunen momenteel geen native MCP Server, maar we hebben OpenAPI-documentatie, en je kunt de volgende methode gebruiken om MCP te ondersteunen.

> Vervang de domeinnaam in `OPENAPI_SPEC_URL` door je eigen domeinnaam.
>
> De `API_KEY` is hetzelfde als de `NUXT_SITE_TOKEN` in de omgevingsvariabelen.

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

## 🙋🏻 Veelgestelde vragen

[Veelgestelde vragen](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 Credits

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Sponsor

1. [Volg mij op X(Twitter)](https://404.li/kai).
2. [Word sponsor op GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---