<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Ein Astro Blog-Theme</p>
<p>Sora bedeutet „Himmel“, symbolisiert unbegrenzte Möglichkeiten und große Kreativität</p>
<p>Wenn dir dieses Theme gefällt, gib doch einen 🌟Star!</p>
<p><strong>Vereinfachtes Chinesisch</strong> | <a href="/README.en.md">English</a></p>
</div>

# Vorschau

[Mein Blog](https://blog.liks.space)

## Wer nutzt es

Reiche ein [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) ein, um deine eigene Website zu präsentieren.

# Loslegen

1. Theme installieren

   - Installiere [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Wechsle in das Projektverzeichnis und starte das Projekt mit `pnpm dev`

2. Theme konfigurieren

   Passe die Konfigurationsdatei `theme.config.ts` an, um das Theme zu individualisieren. Siehe [Konfiguration](#konfiguration).

3. Artikel bearbeiten

   Bearbeite im Verzeichnis `src/content/`, unterstützt Markdown-Format.

4. Website deployen

   Baue die Website mit `pnpm build`, das Ergebnis befindet sich im Verzeichnis `dist/`. Du kannst die Seite lokal mit `pnpm preview` anzeigen.

   Deploye die Website selbst auf einen Server oder folge der [Astro-Dokumentation](https://docs.astro.build/en/guides/deploy/), um die Website auf Vercel, Netlify, GitHub Pages und anderen Plattformen zu hosten.

<!-- # Dokumentation -->

# Konfiguration

Die Konfigurationsdatei heißt `theme.config.ts`.

## Seiteninformationen

```typescript
site: {
  // Website-Adresse
  url: "https://blog.liks.space",
  // Website-Titel
  title: "Sora",
  // Name des Betreibers
  author: "Liks",
  // Website-Beschreibung
  description: "A blog theme built with Astro",
  // Website-Icon
  // Unterstützt SVG, PNG, ICO Formate
  // Pfad zu einer lokalen Datei im public/ Verzeichnis
  favicon: "/images/favicon.ico",
}
```

## Globale Einstellungen

```typescript
global: {
  // Avatar
  // Pfad zu einer lokalen Datei im src/images/ Verzeichnis
  avatar: "avatar.jpg",
  // RSS aktivieren
  rss: true,
  // Mehrsprachigkeit aktivieren (in Entwicklung)
  i18n: true,
}
```

## Navigationsleiste

```typescript
nav: [
  {
    // Seitenname
    name: "Archiv",
    // Seitenadresse
    url: "/archives",
  },
  {
    name: "Kategorien",
    url: "/categories",
  },
  {
    name: "Tags",
    url: "/tags",
  },
  {
    name: "Über",
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
    // Erstellungszeitraum der Website
    time: "2024 - 2025",
    // Inhaber der Rechte
    owner: "Liks",
  },
  // ICP (nur für China)
  beian: {
    // ICP-Registrierung
    icp: {
      // Aktivieren
      enabled: false,
      // Registrierungsnummer
      number: "京 ICP 备 12345678 号",
    },
    // Polizei-Registrierung
    police: {
      // Aktivieren
      enabled: false,
      // Registrierungsnummer
      number: "京公网安备 12345678901234 号",
      // Registrierungs-Website
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Startseite

```typescript
index: {
  // Soziale Medien
  social: [
    {
      // Name
      name: "GitHub",
      // Aktivieren
      enabled: true,
      // URL
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Unterstützt BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Artikelseite

```typescript
post: {
  // Copyright-Lizenz
  copyright: {
    // CC-Lizenz
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Lizenz-URL
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Sponsoring

```typescript
sponsor: {
  // Aktivieren
  enabled: true,
  // Alipay QR-Code
  alipay: {
    // Aktivieren
    enabled: true,
    // Pfad zu einer lokalen Datei im src/images/ Verzeichnis
    image: "alipay.png",
  },
  // WeChat QR-Code
  wechat: {
    enabled: false,
  },
  // Sponsorenliste anzeigen
  list: true,
}
```

## Kommentare

```typescript
comment: {
  // Aktivieren
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Backend-Server-Adresse
    server: "https://artalk.example.com",
    // Seitenname
    site: "Sora",
  },
}
```

## Werkzeuge

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Aktivieren
    enabled: false,
    // Server-Adresse
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Lizenz

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Danksagung

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