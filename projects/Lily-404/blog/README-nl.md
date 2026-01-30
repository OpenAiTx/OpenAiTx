
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Jimmy's Blog

Een minimalistisch persoonlijk blogsysteem gebouwd op Next.js 15+.

## Technische Stack

- **Framework**: Next.js 13+ (App Router)
- **Stijl**: Tailwind CSS
- **Pictogrammen**: Lucide Icons
- **Thema**: Ondersteunt schakelen tussen donkere/lichte modus
- **Deploy**: Vercel

## Functiekenmerken

- 📝 Ondersteuning voor Markdown-artikelen
- 🌓 Schakelen tussen donker/licht thema
- 📱 Responsief ontwerp
- ⚡ Snelle laadtijden
- 📅 Artikel tijdlijnweergave
- 🔐 Online beheerderspaneel (direct artikelen aanmaken via GitHub API)

## Projectstructuur

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Installatie en uitvoering

1. Project klonen

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Afhankelijkheden installeren

```bash
npm install
```

3. De ontwikkelserver uitvoeren

```bash
npm run dev
```

4. Productieversie bouwen

```bash
npm run build
```

## Nieuwe Artikel Toevoegen

### Methode 1: Online Beheerinterface (Aanbevolen)

1. Ga naar de `/admin` pagina
2. Log in met het beheerderswachtwoord
3. Vul de artikelinformatie in en dien in
4. Het artikel wordt automatisch aangemaakt via de GitHub API, Vercel zal automatisch herdeployen

### Methode 2: Handmatig Bestand Toevoegen

1. Maak een nieuw Markdown-bestand aan in de map `content/posts`
2. Bestandsnaam formaat: xxx.md
3. Voeg metadata toe aan het begin van het bestand:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Voeg een notitie toe

1. Maak een nieuw Markdown-bestand aan in de map `content/notes`
2. Bestandsnaam formaat: `YYYY-MM-DD-titel.md`
3. Voeg metadata toe aan het begin van het bestand:

```markdown
---
date: YYYY-MM-DD
---
```

## Configuratie van het beheerderspaneel

Het beheerderspaneel maakt gebruik van GitHub OAuth voor authenticatie; alleen de eigenaar of medewerkers van de repository hebben toegang.

### 1. GitHub OAuth App aanmaken

1. Ga naar [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Klik op "New OAuth App"
3. Vul de informatie in:
   - **Application name**: `Jimmy Blog Admin` (of een willekeurige naam)
   - **Homepage URL**: `https://jouw-domein.com` (productie) of `http://localhost:3000` (lokaal)
   - **Authorization callback URL**: 
     - Productie: `https://jouw-domein.com/api/auth/github/callback`
     - Lokaal: `http://localhost:3000/api/auth/github/callback`
4. Klik op "Register application"
5. Noteer de **Client ID**
6. Klik op "Generate a new client secret" en noteer de **Client secret**

### 2. Omgevingsvariabelen configureren

Voeg de volgende omgevingsvariabelen toe in de Vercel-projectinstellingen:

- `GITHUB_CLIENT_ID`: Je GitHub OAuth App Client ID
- `GITHUB_CLIENT_SECRET`: Je GitHub OAuth App Client Secret
- `GITHUB_OWNER`: GitHub gebruikersnaam (standaard: `Lily-404`, voor gebruikersautorisatie)
- `GITHUB_REPO`: Naam van de repository (standaard: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth callback URL (optioneel, standaard automatisch gegenereerd)
- `NEXT_PUBLIC_BASE_URL`: Je website-URL (voor het genereren van de callback URL; verplicht in productie)
  - Productie: `https://www.jimmy-blog.top`
  - Lokaal: `http://localhost:3000`

### 3. Lokale ontwikkelconfiguratie

Maak een `.env.local` bestand aan in de hoofdmap van het project:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Productieomgeving Configuratie (Vercel)

Zorg ervoor dat je in de Vercel-projectinstellingen het volgende instelt:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Let op**: 
- Het `.env.local` bestand is toegevoegd aan `.gitignore` en wordt niet gecommit naar Git
- Zorg er bij lokale ontwikkeling voor dat de callback-URL van de OAuth App is ingesteld op `http://localhost:3000/api/auth/github/callback`
- **In productie moet `NEXT_PUBLIC_BASE_URL` worden ingesteld op `https://www.jimmy-blog.top`**
- De callback-URL van de OAuth App in productie moet worden ingesteld op: `https://www.jimmy-blog.top/api/auth/github/callback`

## Deployen

Het project is geconfigureerd voor Vercel deployment en ondersteunt automatische deployment. Je hoeft alleen de code naar de GitHub repository te pushen; Vercel bouwt en deployed automatisch.

### Voordelen van het gebruik van het beheer dashboard

- ✅ Geen lokale ontwikkelomgeving nodig
- ✅ Voeg overal en altijd artikelen toe
- ✅ Automatisch Vercel herdeploy triggeren
- ✅ Volledig gratis (GitHub OAuth en Vercel vallen binnen het gratis quotum)
- ✅ Veilig (GitHub OAuth authenticatie, alleen repo-eigenaar/medewerkers hebben toegang)
- ✅ Geen wachtwoordbeheer nodig, inloggen met GitHub account

## Bijdragen

Issues en Pull Requests zijn welkom!

## Licentie

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---