# ⚡ Sink

**Un acortador de enlaces simple / rápido / seguro con análisis, ejecutado 100% en Cloudflare.**

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

## ✨ Características

- **Acortamiento de URL:** Comprime tus URLs a su longitud mínima.
- **Analítica:** Supervisa la analítica de tus enlaces y obtén estadísticas útiles.
- **Serverless:** Despliega sin necesidad de servidores tradicionales.
- **Slug Personalizado:** Soporte para slugs personalizados y sensibilidad a mayúsculas/minúsculas.
- **🪄 Slug por IA:** Aprovecha la IA para generar slugs.
- **Expiración de Enlaces:** Configura fechas de expiración para tus enlaces.

## 🪧 Demo

Prueba la demo en [Sink.Cool](https://sink.cool/dashboard). Inicia sesión usando el Site Token a continuación:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Capturas de pantalla</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Tecnologías Utilizadas

- **Framework**: [Nuxt](https://nuxt.com/)
- **Base de Datos**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Motor de Analítica**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **Componentes UI**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Estilos:** [Tailwind CSS](https://tailwindcss.com/)
- **Despliegue**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Hoja de Ruta [WIP]

Agradecemos tus contribuciones y PRs.

- [x] Extensión de Navegador
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Extensión Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Atajos de Apple
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] App para iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Gestión de enlaces mejorada (con Cloudflare D1)
- [ ] Mejoras de Analítica (Soporte para combinar condiciones de filtro)
- [ ] Optimización de desempeño del Panel (Carga infinita)
- [ ] Pruebas Unitarias

## 🏗️ Despliegue

> Tutorial en video: [Ver aquí](https://www.youtube.com/watch?v=MkU23U2VE9E)

Actualmente soportamos despliegue en [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (recomendado) y [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Configuración

[Documentación de Configuración](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Documentación de API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Actualmente no soportamos MCP Server nativo, pero contamos con documentación OpenAPI y puedes utilizar el siguiente método para soportar MCP.

> Sustituye el nombre de dominio en `OPENAPI_SPEC_URL` por tu propio dominio.
>
> El `API_KEY` es el mismo que `NUXT_SITE_TOKEN` en las variables de entorno.

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

## ☕ Patrocina

1. [Sígueme en X(Twitter)](https://404.li/kai).
2. [Conviértete en patrocinador en GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---