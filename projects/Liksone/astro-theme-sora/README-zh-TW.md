<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>一款 Astro 部落格主題</p>
<p>Sora 意為「穹」，象徵著無限的可能性和廣闊的創造力</p>
<p>喜歡這個主題，不妨點個 🌟Star！</p>
<p><strong>簡體中文</strong> | <a href="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/README.en.md">English</a></p>
</div>

# 預覽

[My Blog](https://blog.liks.space)

## 誰在使用

歡迎提交一個 [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) 來展示自己的网站。

# 開始

1. 安裝主題

   - 安裝 [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - 進入專案目錄，運行 `pnpm dev` 啟動專案

2. 配置主題

   修改配置檔 `theme.config.ts` 來自訂主題。詳見[配置](#配置)。

3. 編輯文章

   在 `src/content/` 目錄中編輯，支援 Markdown 格式。

4. 部署網站

   運行 `pnpm build` 建置網站，建置產物在 `dist/` 目錄。可運行 `pnpm preview` 在本地預覽網站。

   自行部署網站至伺服器，或者參考 [Astro 文件](https://docs.astro.build/en/guides/deploy/)部署網站至 Vercel、Netlify、GitHub Pages 等託管平台。

<!-- # 文件 -->

# 配置

配置檔為 `theme.config.ts`。

## 網站資訊

```typescript
site: {
  // 網站地址
  url: "https://blog.liks.space",
  // 網站標題
  title: "Sora",
  // 站長名稱
  author: "Liks",
  // 網站簡介
  description: "A blog theme built with Astro",
  // 網站圖示
  // 支援 SVG、PNG、ICO 格式
  // 位於 public/ 目錄內的本地檔案路徑
  favicon: "/images/favicon.ico",
}
```

## 全域設定

```typescript
global: {
  // 頭像
  // 位於 src/images/ 目錄內的本地檔案路徑
  avatar: "avatar.jpg",
  // 啟用 RSS
  rss: true,
  // 啟用多語言支援（開發中）
  i18n: true,
}
```

## 導覽列

```typescript
nav: [
  {
    // 頁面名稱
    name: "歸檔",
    // 頁面地址
    url: "/archives",
  },
  {
    name: "分類",
    url: "/categories",
  },
  {
    name: "標籤",
    url: "/tags",
  },
  {
    name: "關於",
    url: "/about",
  },
  ...
];
```

## 頁腳

```typescript
footer: {
  // 版權
  copyright: {
    // 建站時間
    time: "2024 - 2025",
    // 版權所有者
    owner: "Liks",
  },
  // 備案（中國特供）
  beian: {
    // ICP 備案
    icp: {
      // 啟用
      enabled: false,
      // 備案號
      number: "京 ICP 備 12345678 號",
    },
    // 公安備案
    police: {
      // 啟用
      enabled: false,
      // 備案號
      number: "京公網安備 12345678901234 號",
      // 備案網址
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## 首頁

```typescript
index: {
  // 社群媒體
  social: [
    {
      // 名稱
      name: "GitHub",
      // 啟用
      enabled: true,
      // 網址
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

支援 BiliBili、Email、Facebook、GitHub、Instagram、QQ、Telegram、Twitter/X、YouTube、微博、小紅書、知乎。

## 文章頁

```typescript
post: {
  // 版權許可
  copyright: {
    // CC 授權
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // 授權網址
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## 贊助

```typescript
sponsor: {
  // 啟用
  enabled: true,
  // 支付寶二維碼
  alipay: {
    // 啟用
    enabled: true,
    // 位於 src/images/ 目錄內的本地檔案路徑
    image: "alipay.png",
  },
  // 微信二維碼
  wechat: {
    enabled: false,
  },
  // 顯示贊助名單
  list: true,
}
```

## 評論

```typescript
comment: {
  // 啟用
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // 後端伺服器地址
    server: "https://artalk.example.com",
    // 站點名稱
    site: "Sora",
  },
}
```

## 工具

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // 啟用
    enabled: false,
    // 伺服器地址
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# 授權

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# 致謝

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [紙鹿摸魚處](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---