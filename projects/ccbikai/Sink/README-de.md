# ⚡ Sink

**Ein Einfacher / Schneller / Sicherer Link-Shortener mit Analytics, läuft zu 100% auf Cloudflare.**

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

## ✨ Funktionen

- **URL-Verkürzung:** Komprimiere deine URLs auf minimale Länge.
- **Analytics:** Überwache Link-Analysen und sammle aussagekräftige Statistiken.
- **Serverlos:** Bereitstellung ohne klassische Server.
- **Anpassbarer Slug:** Unterstützung für personalisierte Slugs und Groß-/Kleinschreibung.
- **🪄 KI-Slug:** KI-gestützte Generierung von Slugs.
- **Link-Ablauf:** Lege Ablaufdaten für deine Links fest.

## 🪧 Demo

Teste die Demo unter [Sink.Cool](https://sink.cool/dashboard). Melde dich mit dem untenstehenden Site Token an:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Screenshots</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Verwendete Technologien

- **Framework**: [Nuxt](https://nuxt.com/)
- **Datenbank**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Analytics Engine**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **UI-Komponenten**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Styling:** [Tailwind CSS](https://tailwindcss.com/)
- **Bereitstellung**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Roadmap [WIP]

Wir freuen uns über deine Beiträge und PRs.

- [x] Browser-Erweiterung
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Raycast-Erweiterung
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Apple Shortcuts
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] iOS-App
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Verbesserte Linkverwaltung (mit Cloudflare D1)
- [ ] Verbesserungen der Analytics (Unterstützung für das Zusammenführen von Filterbedingungen)
- [ ] Dashboard-Performance-Optimierung (Endloses Laden)
- [ ] Unit-Tests

## 🏗️ Bereitstellung

> Video-Tutorial: [Hier ansehen](https://www.youtube.com/watch?v=MkU23U2VE9E)

Wir unterstützen derzeit die Bereitstellung auf [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (empfohlen) und [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Konfiguration

[Konfigurationsdokumentation](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[API-Dokumentation](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Wir unterstützen derzeit keinen nativen MCP-Server, aber wir haben eine OpenAPI-Dokumentation, und du kannst die folgende Methode nutzen, um MCP zu unterstützen.

> Ersetze den Domainnamen in `OPENAPI_SPEC_URL` durch deine eigene Domain.
>
> Der `API_KEY` ist derselbe wie der `NUXT_SITE_TOKEN` in den Umgebungsvariablen.

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

## 🙋🏻 FAQs

[FAQs](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 Danksagungen

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Sponsor

1. [Folge mir auf X(Twitter)](https://404.li/kai).
2. [Werde Sponsor auf GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---