<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Un tema blog Astro</p>
<p>Sora significa "cielo", simboleggiando infinite possibilità e vasta creatività</p>
<p>Se ti piace questo tema, lascia una 🌟Star!</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# Anteprima

[Il Mio Blog](https://blog.liks.space)

## Chi lo sta usando

Se vuoi mostrare il tuo sito, apri una [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml).

# Inizio

1. Installa il tema

   - Installa [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Entra nella directory del progetto ed esegui `pnpm dev` per avviare il progetto

2. Configura il tema

   Modifica il file di configurazione `theme.config.ts` per personalizzare il tema. Vedi [Configurazione](#配置).

3. Modifica gli articoli

   Modifica nella directory `src/content/`, supporta il formato Markdown.

4. Distribuisci il sito

   Esegui `pnpm build` per costruire il sito, i file generati si trovano nella cartella `dist/`. Puoi eseguire `pnpm preview` per visualizzare il sito in locale.

   Distribuisci il sito sul tuo server, oppure segui la [documentazione Astro](https://docs.astro.build/en/guides/deploy/) per pubblicare su Vercel, Netlify, GitHub Pages e altre piattaforme.

<!-- # 文档 -->

# Configurazione

Il file di configurazione è `theme.config.ts`.

## Informazioni sul sito

```typescript
site: {
  // Indirizzo del sito
  url: "https://blog.liks.space",
  // Titolo del sito
  title: "Sora",
  // Nome dell'autore
  author: "Liks",
  // Descrizione del sito
  description: "A blog theme built with Astro",
  // Icona del sito
  // Supporta formati SVG, PNG, ICO
  // Percorso file locale nella cartella public/
  favicon: "/images/favicon.ico",
}
```

## Impostazioni globali

```typescript
global: {
  // Avatar
  // Percorso file locale nella cartella src/images/
  avatar: "avatar.jpg",
  // Abilita RSS
  rss: true,
  // Abilita il supporto multilingua (in sviluppo)
  i18n: true,
}
```

## Barra di navigazione

```typescript
nav: [
  {
    // Nome della pagina
    name: "Archivio",
    // Indirizzo della pagina
    url: "/archives",
  },
  {
    name: "Categorie",
    url: "/categories",
  },
  {
    name: "Tag",
    url: "/tags",
  },
  {
    name: "Informazioni",
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
    // Periodo di attività del sito
    time: "2024 - 2025",
    // Proprietario
    owner: "Liks",
  },
  // Registrazione (solo per la Cina)
  beian: {
    // Registrazione ICP
    icp: {
      // Abilita
      enabled: false,
      // Numero di registrazione
      number: "京 ICP 备 12345678 号",
    },
    // Registrazione polizia
    police: {
      // Abilita
      enabled: false,
      // Numero di registrazione
      number: "京公网安备 12345678901234 号",
      // Sito web di registrazione
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
      // Nome
      name: "GitHub",
      // Abilita
      enabled: true,
      // Indirizzo web
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Supporta BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Pagina dell'articolo

```typescript
post: {
  // Licenza copyright
  copyright: {
    // Licenza CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Indirizzo della licenza
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Sponsorizzazione

```typescript
sponsor: {
  // Abilita
  enabled: true,
  // QR code Alipay
  alipay: {
    // Abilita
    enabled: true,
    // Percorso file locale nella cartella src/images/
    image: "alipay.png",
  },
  // QR code WeChat
  wechat: {
    enabled: false,
  },
  // Mostra la lista dei sostenitori
  list: true,
}
```

## Commenti

```typescript
comment: {
  // Abilita
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Indirizzo del server backend
    server: "https://artalk.example.com",
    // Nome del sito
    site: "Sora",
  },
}
```

## Strumenti

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Abilita
    enabled: false,
    // Indirizzo del server
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Licenza

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Ringraziamenti

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