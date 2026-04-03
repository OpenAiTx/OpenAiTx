
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">Assamees</a>
      </div>
    </div>
  </details>
</div>

# Jimmy's Blog

Een minimalistisch persoonlijk blogsysteem gebouwd met Next.js 15+, dat online creatie en statische implementatie ondersteunt.

## Technische stack

- **Framework**: Next.js 15+ (App Router)
- **Taal**: TypeScript
- **Stijl**: Tailwind CSS
- **Pictogrammen**: Lucide Icons
- **Inhoud**: Markdown + Gray Matter + Remark
- **Authenticatie**: GitHub OAuth
- **Deploy**: Vercel

## Functiekenmerken

### Lezerszijde

- 📝 Markdown + GFM artikelrendering (inclusief wiskundige formules)
- 🏷️ Label-filtering, paginering, archivering (per jaar/label)
- 📚 Artikelinhoudsopgave (TOC) en éénklik kopiëren van codeblokken
- 📱 Responsieve lay-out en donker/licht thema wisseling
- 🔥 Zwevende creatiekalender-heatmap (artikelen + notities)
- 📡 RSS-feed uitvoer (`/rss.xml`)

### Creatiekant (beheeromgeving)

- 🔐 GitHub OAuth login (eigenaar/medewerker rechtencontrole)
- ✍️ Artikelen/notities online aanmaken, bewerken, verwijderen
- 🆔 Aangepaste bestand-ID + automatische conflictvermijding
- 👀 Bewerken / Voorbeeld / Gesplitst scherm drie schrijfmodi
- 📊 Creatiestatistiekpaneel (totaal, week/maand output, populaire labels)

### Engineeringzijde

- ⚡ Multi-pagina statische output (`force-static`) voor betere prestaties en stabiliteit
- 🧭 Ingebouwde sitemap en robots
- 🧩 Inhoudscache en modulaire API-structuur

## Projectstructuur

```
.
├── app/               # 页面、API 路由、Server Actions
│   ├── api/           # 接口（OAuth、统计、校验、Markdown 等）
│   ├── actions/       # 内容管理相关服务端动作
│   ├── posts/         # 文章详情页
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

## Nieuwe artikelen toevoegen

### Methode 1: Online beheerderspaneel (aanbevolen)

1. Ga naar de pagina `/admin`
2. Log in met GitHub OAuth
3. Vul de artikelgegevens in en dien in
4. Het artikel wordt automatisch aangemaakt via de GitHub API, Vercel zal automatisch opnieuw worden gedeployed

### Methode 2: Handmatig bestanden toevoegen

1. Maak een nieuw Markdown-bestand aan in de map `content/posts`
2. Bestandsnaam formaat: `xxx.md`
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
- Het `.env.local` bestand is toegevoegd aan `.gitignore` en wordt niet meegecommit naar Git
- Zorg er bij lokale ontwikkeling voor dat de callback-URL van de OAuth App is ingesteld op `http://localhost:3000/api/auth/github/callback`
- **In de productieomgeving moet `NEXT_PUBLIC_BASE_URL` worden ingesteld op `https://www.jimmy-blog.top`**
- De callback-URL van de OAuth App in productie moet zijn: `https://www.jimmy-blog.top/api/auth/github/callback`

## Deployen

Het project is geconfigureerd voor deployment via Vercel en ondersteunt automatische deployment. Je hoeft alleen de code naar de GitHub repository te pushen, waarna Vercel automatisch bouwt en deployt.

### Voordelen van het gebruik van de beheeromgeving

- ✅ Geen lokale ontwikkelomgeving nodig
- ✅ Artikelen toevoegen waar en wanneer je wilt
- ✅ Vercel wordt automatisch opnieuw gedeployed
- ✅ Volledig gratis (GitHub OAuth en Vercel vallen binnen het gratis quotum)
- ✅ Veilig (GitHub OAuth verificatie, alleen repository eigenaar/collaborators hebben toegang)
- ✅ Geen wachtwoordbeheer nodig, inloggen met GitHub-account
- ✅ Online bewerken van bestaande content mogelijk (niet alleen nieuw aanmaken)
- ✅ Automatische afhandeling van bestand-ID conflicten, voorkomt overschrijven en handmatig hernoemen
- ✅ Beheeromgeving bevat statistieken over creatie, handig voor continu contentbeheer

## Projectanalyse en toekomstplannen

- Projectanalyse-document: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Future roadmap-document: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Bijdragen

Issues en Pull Requests zijn welkom!

## Licentie

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---