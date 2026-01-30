
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# Blog di Jimmy

Un sistema di blog personale minimalista basato su Next.js 15+.

## Stack Tecnologico

- **Framework**: Next.js 13+ (App Router)
- **Stile**: Tailwind CSS
- **Icone**: Lucide Icons
- **Tema**: Supporto per la modalità chiara/scura
- **Distribuzione**: Vercel

## Caratteristiche principali

- 📝 Supporto per articoli Markdown
- 🌓 Cambio tema chiaro/scuro
- 📱 Design responsive
- ⚡ Caricamento rapido
- 📅 Visualizzazione timeline degli articoli
- 🔐 Pannello di amministrazione online (creazione articoli diretta tramite API GitHub)

## Struttura del progetto

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

## Installazione e avvio

1. Clona il progetto

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Installazione delle dipendenze

```bash
npm install
```

3. Avviare il server di sviluppo

```bash
npm run dev
```

4. Compilazione della versione di produzione

```bash
npm run build
```

## Aggiunta di un nuovo articolo

### Metodo 1: Pannello di amministrazione online (consigliato)

1. Accedi alla pagina `/admin`
2. Accedi utilizzando la password amministratore
3. Compila le informazioni dell'articolo e invia
4. L'articolo verrà creato automaticamente tramite GitHub API e Vercel effettuerà il redeploy automatico

### Metodo 2: Aggiunta manuale del file

1. Crea un nuovo file Markdown nella directory `content/posts`
2. Formato del nome file: xxx.md`
3. Aggiungi i metadati nell'intestazione del file:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Aggiungi una nota

1. Crea un nuovo file Markdown nella directory `content/notes`
2. Formato del nome file: `YYYY-MM-DD-title.md`
3. Aggiungi i metadati all'inizio del file:

```markdown
---
date: YYYY-MM-DD
---
```

## Configurazione del pannello di amministrazione

Il pannello di amministrazione utilizza GitHub OAuth per l'autenticazione, solo il proprietario del repository o i collaboratori possono accedere.

### 1. Creare una GitHub OAuth App

1. Vai su [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Clicca su "New OAuth App"
3. Compila le informazioni:
   - **Application name**: `Jimmy Blog Admin` (o qualsiasi altro nome)
   - **Homepage URL**: `https://tuo-dominio.com` (produzione) oppure `http://localhost:3000` (sviluppo locale)
   - **Authorization callback URL**:
     - Produzione: `https://tuo-dominio.com/api/auth/github/callback`
     - Sviluppo locale: `http://localhost:3000/api/auth/github/callback`
4. Clicca su "Register application"
5. Annota il **Client ID**
6. Clicca su "Generate a new client secret" e annota il **Client secret**

### 2. Configurare le variabili d'ambiente

Aggiungi le seguenti variabili d'ambiente nelle impostazioni del progetto Vercel:

- `GITHUB_CLIENT_ID`: Il Client ID della tua GitHub OAuth App
- `GITHUB_CLIENT_SECRET`: Il Client Secret della tua GitHub OAuth App
- `GITHUB_OWNER`: Nome utente GitHub (predefinito: `Lily-404`, usato per la verifica dei permessi utente)
- `GITHUB_REPO`: Nome del repository (predefinito: `blog`)
- `GITHUB_REDIRECT_URI`: URL di callback OAuth (opzionale, generato automaticamente per default)
- `NEXT_PUBLIC_BASE_URL`: URL del tuo sito web (usato per generare l'URL di callback, obbligatorio in produzione)
  - Produzione: `https://www.jimmy-blog.top`
  - Sviluppo locale: `http://localhost:3000`

### 3. Configurazione per lo sviluppo locale

Crea un file `.env.local` nella directory principale del progetto:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Configurazione dell'ambiente di produzione (Vercel)

Nelle impostazioni del progetto Vercel, assicurati di impostare:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Attenzione**:
- Il file `.env.local` è stato aggiunto a `.gitignore` e non verrà inviato su Git
- Durante lo sviluppo locale, assicurati che la Callback URL dell'app OAuth sia impostata su `http://localhost:3000/api/auth/github/callback`
- **In produzione è necessario impostare `NEXT_PUBLIC_BASE_URL` su `https://www.jimmy-blog.top`**
- La Callback URL dell'app OAuth in produzione dovrebbe essere: `https://www.jimmy-blog.top/api/auth/github/callback`

## Deploy

Il progetto è configurato per il deploy su Vercel, supportando il deploy automatico. Basta pushare il codice su un repository GitHub e Vercel costruirà e distribuirà automaticamente.

### Vantaggi dell'utilizzo del pannello di amministrazione

- ✅ Nessun bisogno di ambiente di sviluppo locale
- ✅ Possibilità di aggiungere articoli ovunque e in qualsiasi momento
- ✅ Trigger automatico del redeploy su Vercel
- ✅ Completamente gratuito (GitHub OAuth e Vercel sono gratuiti entro i limiti base)
- ✅ Sicuro (autenticazione OAuth di GitHub, accesso solo per proprietari/collaboratori del repository)
- ✅ Nessuna gestione password, login tramite account GitHub

## Contributi

Sono benvenute Issue e Pull Request!

## Licenza

Licenza MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---