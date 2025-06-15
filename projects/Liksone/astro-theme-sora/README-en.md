<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>An Astro blog theme</p>
<p>Sora means "sky vault", symbolizing infinite possibilities and vast creativity</p>
<p>If you like this theme, consider giving it a 🌟Star!</p>
<p><strong>Simplified Chinese</strong> | <a href="/README.en.md">English</a></p>
</div>

# Preview

[My Blog](https://blog.liks.space)

## Who's Using

Feel free to open an [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) to showcase your website.

# Getting Started

1. Install the theme

   - Install [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Enter the project directory and run `pnpm dev` to start the project

2. Configure the theme

   Edit the configuration file `theme.config.ts` to customize the theme. See [Configuration](#configuration) for details.

3. Edit posts

   Edit in the `src/content/` directory. Markdown format is supported.

4. Deploy the site

   Run `pnpm build` to build the site. The build output will be in the `dist/` directory. You can run `pnpm preview` to preview your site locally.

   Deploy the site to your own server, or refer to the [Astro Documentation](https://docs.astro.build/en/guides/deploy/) to deploy the site to platforms such as Vercel, Netlify, GitHub Pages, etc.

<!-- # Documentation -->

# Configuration

The configuration file is `theme.config.ts`.

## Site Information

```typescript
site: {
  // Website URL
  url: "https://blog.liks.space",
  // Website title
  title: "Sora",
  // Site owner name
  author: "Liks",
  // Website description
  description: "A blog theme built with Astro",
  // Website icon
  // Supports SVG, PNG, ICO formats
  // Local file path under public/ directory
  favicon: "/images/favicon.ico",
}
```

## Global Settings

```typescript
global: {
  // Avatar
  // Local file path under src/images/ directory
  avatar: "avatar.jpg",
  // Enable RSS
  rss: true,
  // Enable multilingual support (in development)
  i18n: true,
}
```

## Navigation Bar

```typescript
nav: [
  {
    // Page name
    name: "Archives",
    // Page URL
    url: "/archives",
  },
  {
    name: "Categories",
    url: "/categories",
  },
  {
    name: "Tags",
    url: "/tags",
  },
  {
    name: "About",
    url: "/about",
  },
  ...
];
```

## Footer

```typescript
footer: {
  // Copyright
  copyright: {
    // Site founding time
    time: "2024 - 2025",
    // Copyright owner
    owner: "Liks",
  },
  // ICP Filing (China only)
  beian: {
    // ICP Filing
    icp: {
      // Enable
      enabled: false,
      // Filing number
      number: "Beijing ICP No. 12345678",
    },
    // Public Security Filing
    police: {
      // Enable
      enabled: false,
      // Filing number
      number: "Beijing Public Security No. 12345678901234",
      // Filing website
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Homepage

```typescript
index: {
  // Social media
  social: [
    {
      // Name
      name: "GitHub",
      // Enable
      enabled: true,
      // URL
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Supports BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Post Page

```typescript
post: {
  // Copyright License
  copyright: {
    // CC License
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // License URL
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Sponsor

```typescript
sponsor: {
  // Enable
  enabled: true,
  // Alipay QR code
  alipay: {
    // Enable
    enabled: true,
    // Local file path under src/images/ directory
    image: "alipay.png",
  },
  // WeChat QR code
  wechat: {
    enabled: false,
  },
  // Show sponsor list
  list: true,
```
```

## Comments

```typescript
comment: {
  // Enable
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Backend server address
    server: "https://artalk.example.com",
    // Site name
    site: "Sora",
  },
}
```

## Tools

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Enable
    enabled: false,
    // Server address
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# License

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Acknowledgments

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [Zhilu's Blog](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)

```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---