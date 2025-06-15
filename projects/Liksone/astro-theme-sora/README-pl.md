<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Motyw bloga Astro</p>
<p>Sora oznacza „nieboskłon”, symbolizuje nieskończone możliwości i szeroką kreatywność</p>
<p>Jeśli podoba Ci się ten motyw, zostaw 🌟Star!</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# Podgląd

[Mój blog](https://blog.liks.space)

## Kto używa

Zachęcamy do zgłoszenia [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml), aby zaprezentować swoją stronę.

# Rozpoczęcie

1. Instalacja motywu

   - Zainstaluj [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Wejdź do katalogu projektu, uruchom `pnpm dev`, aby wystartować projekt

2. Konfiguracja motywu

   Edytuj plik konfiguracyjny `theme.config.ts`, aby dostosować motyw. Szczegóły w [Konfiguracja](#配置).

3. Edycja artykułów

   Edytuj w katalogu `src/content/`, obsługiwany jest format Markdown.

4. Wdrażanie strony

   Uruchom `pnpm build`, aby zbudować stronę, pliki wynikowe znajdziesz w katalogu `dist/`. Możesz uruchomić `pnpm preview`, aby obejrzeć stronę lokalnie.

   Wdróż stronę na własnym serwerze lub skorzystaj z [dokumentacji Astro](https://docs.astro.build/en/guides/deploy/), aby wdrożyć na Vercel, Netlify, GitHub Pages lub inne platformy hostingowe.

<!-- # 文档 -->

# Konfiguracja

Plik konfiguracyjny to `theme.config.ts`.

## Informacje o stronie

```typescript
site: {
  // Adres strony
  url: "https://blog.liks.space",
  // Tytuł strony
  title: "Sora",
  // Nazwa autora
  author: "Liks",
  // Opis strony
  description: "A blog theme built with Astro",
  // Ikona strony
  // Obsługa formatów SVG, PNG, ICO
  // Ścieżka do pliku lokalnego w katalogu public/
  favicon: "/images/favicon.ico",
}
```

## Ustawienia globalne

```typescript
global: {
  // Avatar
  // Ścieżka do pliku lokalnego w katalogu src/images/
  avatar: "avatar.jpg",
  // Włącz RSS
  rss: true,
  // Włącz obsługę wielu języków (w trakcie rozwoju)
  i18n: true,
}
```

## Pasek nawigacyjny

```typescript
nav: [
  {
    // Nazwa strony
    name: "Archiwum",
    // Adres strony
    url: "/archives",
  },
  {
    name: "Kategorie",
    url: "/categories",
  },
  {
    name: "Tagi",
    url: "/tags",
  },
  {
    name: "O mnie",
    url: "/about",
  },
  ...
];
```

## Stopka

```typescript
footer: {
  // Prawa autorskie
  copyright: {
    // Czas utworzenia strony
    time: "2024 - 2025",
    // Właściciel praw autorskich
    owner: "Liks",
  },
  // Rejestracja (tylko dla Chin)
  beian: {
    // Rejestracja ICP
    icp: {
      // Włącz
      enabled: false,
      // Numer rejestracyjny
      number: "京 ICP 备 12345678 号",
    },
    // Rejestracja policyjna
    police: {
      // Włącz
      enabled: false,
      // Numer rejestracyjny
      number: "京公网安备 12345678901234 号",
      // Adres strony rejestracyjnej
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Strona główna

```typescript
index: {
  // Media społecznościowe
  social: [
    {
      // Nazwa
      name: "GitHub",
      // Włącz
      enabled: true,
      // Adres URL
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Obsługuje BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Strona artykułu

```typescript
post: {
  // Licencja praw autorskich
  copyright: {
    // Licencja CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Adres licencji
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Wsparcie

```typescript
sponsor: {
  // Włącz
  enabled: true,
  // Kod QR Alipay
  alipay: {
    // Włącz
    enabled: true,
    // Ścieżka do pliku lokalnego w katalogu src/images/
    image: "alipay.png",
  },
  // Kod QR WeChat
  wechat: {
    enabled: false,
  },
  // Wyświetl listę sponsorów
  list: true,
}
```

## Komentarze

```typescript
comment: {
  // Włączone
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Adres serwera backend
    server: "https://artalk.example.com",
    // Nazwa strony
    site: "Sora",
  },
}
```

## Narzędzia

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Włączone
    enabled: false,
    // Adres serwera
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Licencja

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Podziękowania

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