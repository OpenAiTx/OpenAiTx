# ⚡ Sink

**Un accorciatore di link semplice / veloce / sicuro con analitiche, 100% su Cloudflare.**

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

## ✨ Funzionalità

- **Accorciamento URL:** Comprimi i tuoi URL alla lunghezza minima.
- **Analitiche:** Monitora le statistiche dei link e raccogli dati utili.
- **Serverless:** Distribuzione senza la necessità di server tradizionali.
- **Slug personalizzabile:** Supporto per slug personalizzati e sensibilità alle maiuscole.
- **🪄 AI Slug:** Sfrutta l’AI per generare slug.
- **Scadenza link:** Imposta una data di scadenza per i tuoi link.

## 🪧 Demo

Prova la demo su [Sink.Cool](https://sink.cool/dashboard). Accedi usando il Site Token qui sotto:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Screenshots</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Tecnologie utilizzate

- **Framework**: [Nuxt](https://nuxt.com/)
- **Database**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Motore Analitico**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **Componenti UI**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Stilizzazione:** [Tailwind CSS](https://tailwindcss.com/)
- **Deploy:** [Cloudflare](https://www.cloudflare.com/)

## 🚗 Roadmap [WIP]

Accettiamo volentieri contributi e PR.

- [x] Estensione browser
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Estensione Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Apple Shortcuts
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] App iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Gestione avanzata dei link (con Cloudflare D1)
- [ ] Miglioramenti alle analitiche (supporto per l’unione di condizioni di filtro)
- [ ] Ottimizzazione delle prestazioni della dashboard (caricamento infinito)
- [ ] Unit test

## 🏗️ Deploy

> Video tutorial: [Guarda qui](https://www.youtube.com/watch?v=MkU23U2VE9E)

Attualmente supportiamo il deploy su [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (raccomandato) e [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Configurazione

[Documentazione configurazione](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Documentazione API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Attualmente non supportiamo nativamente MCP Server, ma abbiamo una documentazione OpenAPI e puoi usare il seguente metodo per supportare MCP.

> Sostituisci il nome di dominio in `OPENAPI_SPEC_URL` con il tuo dominio.
>
> L’`API_KEY` è la stessa del `NUXT_SITE_TOKEN` nelle variabili d’ambiente.

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

## 💖 Crediti

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Sponsor

1. [Seguimi su X(Twitter)](https://404.li/kai).
2. [Diventa sponsor su GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---