# ⚡ Sink

**Простой / Быстрый / Безопасный сокращатель ссылок с аналитикой, полностью работает на Cloudflare.**

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

## ✨ Возможности

- **Сокращение URL:** Сжимайте ваши ссылки до минимальной длины.
- **Аналитика:** Отслеживайте аналитику ссылок и получайте полезную статистику.
- **Serverless:** Развертывание без необходимости традиционных серверов.
- **Настраиваемый слаг:** Поддержка персонализированных слагов и учета регистра.
- **🪄 AI-слаг:** Используйте ИИ для генерации слагов.
- **Истечение срока действия ссылок:** Устанавливайте срок действия ваших ссылок.

## 🪧 Демо

Опробуйте демо на [Sink.Cool](https://sink.cool/dashboard). Войдите с использованием Site Token ниже:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Скриншоты</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Используемые технологии

- **Фреймворк**: [Nuxt](https://nuxt.com/)
- **База данных**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Аналитический движок**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **UI-компоненты**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Стилизация:** [Tailwind CSS](https://tailwindcss.com/)
- **Развертывание**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Дорожная карта [WIP]

Мы приветствуем ваши идеи и PR.

- [x] Расширение для браузера
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Расширение для Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Ярлыки Apple
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] Приложение для iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Улучшенное управление ссылками (с Cloudflare D1)
- [ ] Улучшения аналитики (Поддержка объединения условий фильтрации)
- [ ] Оптимизация производительности дашборда (бесконечная подгрузка)
- [ ] Unit-тесты

## 🏗️ Развертывание

> Видеоинструкция: [Смотреть здесь](https://www.youtube.com/watch?v=MkU23U2VE9E)

В настоящее время поддерживается развертывание на [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (рекомендуется) и [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Конфигурация

[Документация по настройке](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Документация по API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

В настоящее время мы не поддерживаем нативный MCP Server, но у нас есть документация по OpenAPI, и вы можете использовать следующий способ для поддержки MCP.

> Замените доменное имя в `OPENAPI_SPEC_URL` на ваше собственное.
>
> `API_KEY` совпадает с `NUXT_SITE_TOKEN` в переменных окружения.

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

## 🙋🏻 Часто задаваемые вопросы

[FAQ](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 Благодарности

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Поддержка

1. [Подпишитесь на меня в X(Twitter)](https://404.li/kai).
2. [Станьте спонсором на GitHub](https://github.com/sponsors/ccbikai).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---