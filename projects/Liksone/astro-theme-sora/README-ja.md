<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Astro ブログテーマ</p>
<p>Sora は「穹」を意味し、無限の可能性と広大な創造力を象徴します</p>
<p>このテーマが気に入ったら、ぜひ 🌟Star を付けてください！</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# プレビュー

[My Blog](https://blog.liks.space)

## 利用者一覧

自分のウェブサイトを紹介したい方は、[Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) を提起してください。

# はじめに

1. テーマのインストール

   - [pnpm](https://pnpm.io/installation) をインストール
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - プロジェクトディレクトリに入り、`pnpm dev` でプロジェクトを起動

2. テーマの設定

   設定ファイル `theme.config.ts` を編集してテーマをカスタマイズします。詳細は[設定](#設定)を参照。

3. 記事の編集

   `src/content/` ディレクトリで編集します。Markdown 形式に対応しています。

4. サイトのデプロイ

   `pnpm build` を実行してサイトをビルド、成果物は `dist/` ディレクトリに生成されます。`pnpm preview` でローカルプレビューが可能です。

   サーバーに自分でデプロイするか、[Astro ドキュメント](https://docs.astro.build/en/guides/deploy/)を参考に Vercel、Netlify、GitHub Pages などのホスティングサービスにデプロイできます。

<!-- # ドキュメント -->

# 設定

設定ファイルは `theme.config.ts` です。

## サイト情報

```typescript
site: {
  // サイトURL
  url: "https://blog.liks.space",
  // サイトタイトル
  title: "Sora",
  // 管理者名
  author: "Liks",
  // サイトの説明
  description: "A blog theme built with Astro",
  // サイトアイコン
  // SVG、PNG、ICO フォーマット対応
  // public/ ディレクトリ内のローカルファイルパス
  favicon: "/images/favicon.ico",
}
```

## グローバル設定

```typescript
global: {
  // アバター
  // src/images/ ディレクトリ内のローカルファイルパス
  avatar: "avatar.jpg",
  // RSS有効化
  rss: true,
  // 多言語サポート有効化（開発中）
  i18n: true,
}
```

## ナビゲーションバー

```typescript
nav: [
  {
    // ページ名
    name: "アーカイブ",
    // ページURL
    url: "/archives",
  },
  {
    name: "カテゴリ",
    url: "/categories",
  },
  {
    name: "タグ",
    url: "/tags",
  },
  {
    name: "概要",
    url: "/about",
  },
  ...
];
```

## フッター

```typescript
footer: {
  // 著作権
  copyright: {
    // 開設年
    time: "2024 - 2025",
    // 所有者
    owner: "Liks",
  },
  // 登録情報（中国向け）
  beian: {
    // ICP 登録
    icp: {
      // 有効化
      enabled: false,
      // 登録番号
      number: "京 ICP 备 12345678 号",
    },
    // 公安登録
    police: {
      // 有効化
      enabled: false,
      // 登録番号
      number: "京公网安备 12345678901234 号",
      // 登録サイトURL
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## ホームページ

```typescript
index: {
  // ソーシャルメディア
  social: [
    {
      // 名称
      name: "GitHub",
      // 有効化
      enabled: true,
      // URL
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

BiliBili、Email、Facebook、GitHub、Instagram、QQ、Telegram、Twitter/X、YouTube、Weibo、小紅書、知乎に対応。

## 記事ページ

```typescript
post: {
  // 著作権ライセンス
  copyright: {
    // CC ライセンス
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // ライセンスURL
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## スポンサー

```typescript
sponsor: {
  // 有効化
  enabled: true,
  // Alipay QRコード
  alipay: {
    // 有効化
    enabled: true,
    // src/images/ ディレクトリ内のローカルファイルパス
    image: "alipay.png",
  },
  // WeChat QRコード
  wechat: {
    enabled: false,
  },
  // スポンサーリスト表示
  list: true,
}
```

## コメント

```typescript
comment: {
  // 有効化
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // バックエンドサーバーアドレス
    server: "https://artalk.example.com",
    // サイト名
    site: "Sora",
  },
}
```

## ツール

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // 有効化
    enabled: false,
    // サーバーアドレス
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```

# ライセンス

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# 謝辞

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---