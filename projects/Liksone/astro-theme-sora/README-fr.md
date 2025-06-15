<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Un thème de blog Astro</p>
<p>Sora signifie « ciel », symbolisant des possibilités infinies et une créativité vaste</p>
<p>Si vous aimez ce thème, n'hésitez pas à laisser une 🌟Star !</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# Aperçu

[Mon Blog](https://blog.liks.space)

## Qui utilise

N'hésitez pas à soumettre une [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) pour présenter votre site web.

# Commencer

1. Installer le thème

   - Installer [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Entrez dans le dossier du projet et lancez `pnpm dev` pour démarrer le projet

2. Configurer le thème

   Modifiez le fichier de configuration `theme.config.ts` pour personnaliser le thème. Voir [Configuration](#配置).

3. Éditer les articles

   Éditez dans le dossier `src/content/`, le format Markdown est supporté.

4. Déployer le site

   Exécutez `pnpm build` pour construire le site, le résultat se trouve dans le dossier `dist/`. Vous pouvez lancer `pnpm preview` pour prévisualiser localement le site.

   Déployez votre site sur votre propre serveur, ou consultez la [documentation Astro](https://docs.astro.build/en/guides/deploy/) pour le déployer sur des plateformes d'hébergement telles que Vercel, Netlify, GitHub Pages, etc.

<!-- # Documentation -->

# Configuration

Le fichier de configuration est `theme.config.ts`.

## Informations du site

```typescript
site: {
  // Adresse du site
  url: "https://blog.liks.space",
  // Titre du site
  title: "Sora",
  // Nom de l'administrateur
  author: "Liks",
  // Description du site
  description: "Un thème de blog construit avec Astro",
  // Icône du site
  // Prend en charge les formats SVG, PNG, ICO
  // Chemin du fichier local dans le dossier public/
  favicon: "/images/favicon.ico",
}
```

## Paramètres globaux

```typescript
global: {
  // Avatar
  // Chemin du fichier local dans le dossier src/images/
  avatar: "avatar.jpg",
  // Activer RSS
  rss: true,
  // Activer le support multilingue (en développement)
  i18n: true,
}
```

## Barre de navigation

```typescript
nav: [
  {
    // Nom de la page
    name: "Archives",
    // Adresse de la page
    url: "/archives",
  },
  {
    name: "Catégories",
    url: "/categories",
  },
  {
    name: "Tags",
    url: "/tags",
  },
  {
    name: "À propos",
    url: "/about",
  },
  ...
];
```

## Pied de page

```typescript
footer: {
  // Copyright
  copyright: {
    // Date de création
    time: "2024 - 2025",
    // Propriétaire
    owner: "Liks",
  },
  // Enregistrement (spécifique à la Chine)
  beian: {
    // Enregistrement ICP
    icp: {
      // Activer
      enabled: false,
      // Numéro d'enregistrement
      number: "京 ICP 备 12345678 号",
    },
    // Enregistrement de la police
    police: {
      // Activer
      enabled: false,
      // Numéro d'enregistrement
      number: "京公网安备 12345678901234 号",
      // URL d'enregistrement
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Page d'accueil

```typescript
index: {
  // Réseaux sociaux
  social: [
    {
      // Nom
      name: "GitHub",
      // Activer
      enabled: true,
      // URL
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Supporte BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Page d'article

```typescript
post: {
  // Licence
  copyright: {
    // Licence CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // URL de la licence
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Parrainage

```typescript
sponsor: {
  // Activer
  enabled: true,
  // QR code Alipay
  alipay: {
    // Activer
    enabled: true,
    // Chemin du fichier local dans le dossier src/images/
    image: "alipay.png",
  },
  // QR code WeChat
  wechat: {
    enabled: false,
  },
  // Afficher la liste des sponsors
  list: true,
}
```

## Commentaires

```typescript
comment: {
  // Activer
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Adresse du serveur backend
    server: "https://artalk.example.com",
    // Nom du site
    site: "Sora",
  },
}
```

## Outils

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Activer
    enabled: false,
    // Adresse du serveur
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Licence

[Licence Publique Générale GNU v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Remerciements

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