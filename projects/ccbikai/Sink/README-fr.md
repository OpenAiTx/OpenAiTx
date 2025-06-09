# ⚡ Sink

**Un raccourcisseur de liens simple / rapide / sécurisé avec analyses, fonctionnant à 100% sur Cloudflare.**

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

## ✨ Fonctionnalités

- **Raccourcissement d’URL :** Réduisez vos URL à leur longueur minimale.
- **Analyses :** Surveillez les analyses de liens et collectez des statistiques pertinentes.
- **Serverless :** Déployez sans besoin de serveurs traditionnels.
- **Slug personnalisable :** Prise en charge de slugs personnalisés et de la sensibilité à la casse.
- **🪄 Slug IA :** Utilisez l’IA pour générer des slugs.
- **Expiration des liens :** Définissez des dates d’expiration pour vos liens.

## 🪧 Démo

Testez la démo sur [Sink.Cool](https://sink.cool/dashboard). Connectez-vous avec le jeton du site ci-dessous :

```txt
Jeton du site : SinkCool
```

<details>
  <summary><b>Captures d’écran</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Technologies utilisées

- **Framework** : [Nuxt](https://nuxt.com/)
- **Base de données** : [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Moteur d’analyses** : [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **Composants UI** : [shadcn-vue](https://www.shadcn-vue.com/)
- **Style :** [Tailwind CSS](https://tailwindcss.com/)
- **Déploiement** : [Cloudflare](https://www.cloudflare.com/)

## 🚗 Feuille de route [WIP]

Nous accueillons vos contributions et PR.

- [x] Extension de navigateur
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Extension Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Raccourcis Apple
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] Application iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Gestion améliorée des liens (avec Cloudflare D1)
- [ ] Améliorations des analyses (prise en charge de la fusion des filtres)
- [ ] Optimisation des performances du tableau de bord (chargement infini)
- [ ] Tests unitaires

## 🏗️ Déploiement

> Tutoriel vidéo : [Regarder ici](https://www.youtube.com/watch?v=MkU23U2VE9E)

Nous prenons actuellement en charge le déploiement sur [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (recommandé) et [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Configuration

[Documentation de configuration](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Documentation API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Nous ne prenons pas encore en charge le serveur MCP natif, mais nous avons une documentation OpenAPI, et vous pouvez utiliser la méthode suivante pour prendre en charge MCP.

> Remplacez le nom de domaine dans `OPENAPI_SPEC_URL` par votre propre nom de domaine.
>
> La `API_KEY` est identique à la `NUXT_SITE_TOKEN` dans les variables d’environnement.

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

## 💖 Remerciements

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Sponsor

1. [Suivez-moi sur X(Twitter)](https://404.li/kai).
2. [Devenez sponsor sur GitHub](https://github.com/sponsors/ccbikai).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---