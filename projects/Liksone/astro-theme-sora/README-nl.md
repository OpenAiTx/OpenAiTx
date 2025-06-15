<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Een Astro blogthema</p>
<p>Sora betekent "hemelgewelf", wat staat voor oneindige mogelijkheden en brede creativiteit</p>
<p>Vind je dit thema leuk? Geef dan gerust een 🌟Ster!</p>
<p><strong>Vereenvoudigd Chinees</strong> | <a href="/README.en.md">Engels</a></p>
</div>

# Voorbeeld

[Mijn Blog](https://blog.liks.space)

## Wie gebruikt het

Voel je vrij om een [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) aan te maken om je eigen website te laten zien.

# Aan de slag

1. Installeer het thema

   - Installeer [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Ga naar de projectmap en voer `pnpm dev` uit om het project te starten

2. Thema configureren

   Pas het configuratiebestand `theme.config.ts` aan om het thema te personaliseren. Zie [Configuratie](#配置).

3. Bewerk artikelen

   Bewerk in de map `src/content/`, ondersteund wordt het Markdown-formaat.

4. Website deployen

   Voer `pnpm build` uit om de website te bouwen; de output staat in de map `dist/`. Je kunt `pnpm preview` uitvoeren om de website lokaal te bekijken.

   Deploy de website zelf op een server, of volg de [Astro documentatie](https://docs.astro.build/en/guides/deploy/) om te deployen naar Vercel, Netlify, GitHub Pages en andere hostingplatforms.

<!-- # Documentatie -->

# Configuratie

Het configuratiebestand is `theme.config.ts`.

## Site-informatie

```typescript
site: {
  // Website-adres
  url: "https://blog.liks.space",
  // Website-titel
  title: "Sora",
  // Naam van de beheerder
  author: "Liks",
  // Websitebeschrijving
  description: "A blog theme built with Astro",
  // Website-icoon
  // Ondersteunt SVG, PNG, ICO formaten
  // Lokale bestandslocatie in de public/ map
  favicon: "/images/favicon.ico",
}
```

## Globale instellingen

```typescript
global: {
  // Profielfoto
  // Lokale bestandslocatie in de map src/images/
  avatar: "avatar.jpg",
  // RSS inschakelen
  rss: true,
  // Meertalige ondersteuning inschakelen (in ontwikkeling)
  i18n: true,
}
```

## Navigatiebalk

```typescript
nav: [
  {
    // Paginanaam
    name: "Archief",
    // Pagina-adres
    url: "/archives",
  },
  {
    name: "Categorieën",
    url: "/categories",
  },
  {
    name: "Tags",
    url: "/tags",
  },
  {
    name: "Over",
    url: "/about",
  },
  ...
];
```

## Voettekst

```typescript
footer: {
  // Copyright
  copyright: {
    // Opgericht sinds
    time: "2024 - 2025",
    // Eigenaar van het recht
    owner: "Liks",
  },
  // ICP registratie (speciaal voor China)
  beian: {
    // ICP registratie
    icp: {
      // Inschakelen
      enabled: false,
      // Registratienummer
      number: "京 ICP 备 12345678 号",
    },
    // Politie registratie
    police: {
      // Inschakelen
      enabled: false,
      // Registratienummer
      number: "京公网安备 12345678901234 号",
      // Registratie website
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Startpagina

```typescript
index: {
  // Sociale media
  social: [
    {
      // Naam
      name: "GitHub",
      // Inschakelen
      enabled: true,
      // Website
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Ondersteunt BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Artikelenpagina

```typescript
post: {
  // Copyright-licentie
  copyright: {
    // CC-licentie
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Licentie-URL
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Sponsoring

```typescript
sponsor: {
  // Inschakelen
  enabled: true,
  // Alipay QR-code
  alipay: {
    // Inschakelen
    enabled: true,
    // Lokale bestandslocatie in de map src/images/
    image: "alipay.png",
  },
  // WeChat QR-code
  wechat: {
    enabled: false,
  },
  // Toon sponsorlijst
  list: true,
}
```

## Reacties

```typescript
comment: {
  // Inschakelen
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Backend serveradres
    server: "https://artalk.example.com",
    // Sitenaam
    site: "Sora",
  },
}
```

## Hulpmiddelen

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Inschakelen
    enabled: false,
    // Serveradres
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Licentie

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Dankbetuigingen

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