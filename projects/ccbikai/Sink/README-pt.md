# ⚡ Sink

**Um Encurtador de Links Simples / Rápido / Seguro com Analytics, 100% rodando na Cloudflare.**

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

## ✨ Funcionalidades

- **Encurtamento de URL:** Comprime suas URLs ao tamanho mínimo.
- **Analytics:** Monitore os dados dos links e obtenha estatísticas valiosas.
- **Serverless:** Implante sem necessidade de servidores tradicionais.
- **Slug Personalizável:** Suporte a slugs personalizados e diferenciação entre maiúsculas e minúsculas.
- **🪄 AI Slug:** Utilize IA para gerar slugs.
- **Expiração de Link:** Defina datas de expiração para seus links.

## 🪧 Demo

Experimente a demonstração em [Sink.Cool](https://sink.cool/dashboard). Faça login usando o Site Token abaixo:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Screenshots</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Tecnologias Utilizadas

- **Framework**: [Nuxt](https://nuxt.com/)
- **Banco de Dados**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Motor de Analytics**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **Componentes UI**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Estilização:** [Tailwind CSS](https://tailwindcss.com/)
- **Deploy**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Roadmap [WIP]

Suas contribuições e PRs são bem-vindos.

- [x] Extensão de Navegador
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Extensão Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Atalhos Apple
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] App iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Gerenciamento Aprimorado de Links (com Cloudflare D1)
- [ ] Melhorias em Analytics (Suporte para mesclar condições de filtro)
- [ ] Otimização de Performance do Dashboard (Carregamento infinito)
- [ ] Testes Unitários

## 🏗️ Deploy

> Tutorial em vídeo: [Assista aqui](https://www.youtube.com/watch?v=MkU23U2VE9E)

Atualmente suportamos deploy para [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (recomendado) e [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Configuração

[Documentação de Configuração](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Documentação da API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Atualmente não suportamos MCP Server nativo, mas temos documentação OpenAPI, e você pode usar o método abaixo para suportar MCP.

> Substitua o nome de domínio em `OPENAPI_SPEC_URL` pelo seu próprio domínio.
>
> O `API_KEY` é o mesmo que o `NUXT_SITE_TOKEN` nas variáveis de ambiente.

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

## 💖 Créditos

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Seja um patrocinador

1. [Siga-me no X(Twitter)](https://404.li/kai).
2. [Torne-se um patrocinador no GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---