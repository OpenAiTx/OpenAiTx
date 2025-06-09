# ⚡ Sink

**一個簡單／快速／安全的短網址服務，帶有分析功能，100% 運行於 Cloudflare。**

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

## ✨ 功能特色

- **網址縮短：** 將您的網址壓縮至最短長度。
- **數據分析：** 監控連結數據，獲取有價值的統計資料。
- **無伺服器架構：** 無需傳統伺服器即可部署。
- **自訂短碼：** 支援個人化短碼與大小寫敏感。
- **🪄 AI短碼：** 利用 AI 產生短碼。
- **連結有效期：** 可為連結設定到期日。

## 🪧 線上展示

體驗演示：[Sink.Cool](https://sink.cool/dashboard)。請使用下方的站點 Token 登入：

```txt
Site Token: SinkCool
```

<details>
  <summary><b>螢幕截圖</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 技術棧

- **框架**：[Nuxt](https://nuxt.com/)
- **資料庫**：[Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **分析引擎**：[Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **UI 元件**：[shadcn-vue](https://www.shadcn-vue.com/)
- **樣式**：[Tailwind CSS](https://tailwindcss.com/)
- **部署**：[Cloudflare](https://www.cloudflare.com/)

## 🚗 開發規劃 [進行中]

歡迎您的貢獻與 PR。

- [x] 瀏覽器擴充功能
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Raycast 擴充
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Apple 捷徑
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] iOS App
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] 進階連結管理（支援 Cloudflare D1）
- [ ] 數據分析增強（支援條件過濾合併）
- [ ] 儀表板效能優化（無限滾動載入）
- [ ] 單元測試

## 🏗️ 部署

> 視頻教學：[觀看這裡](https://www.youtube.com/watch?v=MkU23U2VE9E)

目前支援部署到 [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md)（推薦）與 [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md)。

## ⚒️ 設定

[設定文件](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[API 文件](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

目前尚未原生支援 MCP Server，但我們有 OpenAPI 文件，您可以透過以下方式支援 MCP。

> 將 `OPENAPI_SPEC_URL` 的網域名稱換成您自己的。
>
> `API_KEY` 與環境變數中的 `NUXT_SITE_TOKEN` 相同。

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

## 🙋🏻 常見問題

[常見問題](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 鳴謝

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ 贊助

1. [追蹤我於 X(Twitter)](https://404.li/kai)。
2. [在 GitHub 上成為贊助者](https://github.com/sponsors/ccbikai)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---