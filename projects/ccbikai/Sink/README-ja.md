# ⚡ Sink

**シンプル / 高速 / セキュアなリンク短縮サービス、アナリティクス機能付き。100% Cloudflare 上で稼働。**

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

## ✨ 特徴

- **URL短縮:** URLを最小限の長さに圧縮します。
- **アナリティクス:** リンクの解析・統計情報を確認できます。
- **サーバーレス:** 従来型サーバー不要でデプロイ可能。
- **カスタマイズ可能なスラッグ:** パーソナライズしたスラッグや大文字小文字の区別に対応。
- **🪄 AIスラッグ:** AIによるスラッグ生成を活用。
- **リンク有効期限:** リンクの有効期限設定が可能。

## 🪧 デモ

[Sink.Cool](https://sink.cool/dashboard) でデモを体験できます。下記のサイトトークンでログインしてください。

```txt
Site Token: SinkCool
```

<details>
  <summary><b>スクリーンショット</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 使用技術

- **フレームワーク**: [Nuxt](https://nuxt.com/)
- **データベース**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **アナリティクスエンジン**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **UIコンポーネント**: [shadcn-vue](https://www.shadcn-vue.com/)
- **スタイリング:** [Tailwind CSS](https://tailwindcss.com/)
- **デプロイ:** [Cloudflare](https://www.cloudflare.com/)

## 🚗 ロードマップ [WIP]

皆様からの貢献やPRを歓迎します。

- [x] ブラウザ拡張
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Raycast拡張
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Appleショートカット
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] iOSアプリ
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] 高度なリンク管理（Cloudflare D1対応）
- [ ] アナリティクス強化（フィルター条件の統合対応）
- [ ] ダッシュボードパフォーマンス最適化（無限ローディング）
- [ ] ユニットテスト

## 🏗️ デプロイ

> 動画チュートリアル: [こちらで視聴](https://www.youtube.com/watch?v=MkU23U2VE9E)

現在、[Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md)（推奨）および[Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md)へのデプロイをサポートしています。

## ⚒️ 設定

[設定ドキュメント](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[APIドキュメント](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

現在、ネイティブMCPサーバーには未対応ですが、OpenAPIドキュメントを用意しており、以下の方法でMCPをサポートできます。

> `OPENAPI_SPEC_URL` のドメイン名を自身のドメイン名に置き換えてください。
>
> `API_KEY` は環境変数の `NUXT_SITE_TOKEN` と同じです。

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

## 🙋🏻 よくある質問

[よくある質問](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 クレジット

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ スポンサー

1. [X(Twitter)でフォロー](https://404.li/kai)
2. [GitHubでスポンサーになる](https://github.com/sponsors/ccbikai)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---