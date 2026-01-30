
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# Jimmys Blog

Ein minimalistisches persönliches Blogsystem, basierend auf Next.js 15+ gebaut.

## Technologiestack

- **Framework**: Next.js 13+ (App Router)
- **Styling**: Tailwind CSS
- **Icons**: Lucide Icons
- **Thema**: Unterstützung für Dunkel-/Hellmodus-Umschaltung
- **Bereitstellung**: Vercel

## Funktionen und Eigenschaften

- 📝 Unterstützung für Markdown-Artikel
- 🌓 Dunkel-/Hellmodus-Umschaltung
- 📱 Responsives Design
- ⚡ Schnelles Laden
- 📅 Anzeige der Artikeltimeline
- 🔐 Online-Administrationsbereich (Direktes Erstellen von Artikeln über GitHub API)

## Projektstruktur

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

## Installation und Ausführung

1. Projekt klonen

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Abhängigkeiten installieren

```bash
npm install
```

3. Starten des Entwicklungsservers

```bash
npm run dev
```

4. Erstellung der Produktionsversion

```bash
npm run build
```

## Neue Artikel hinzufügen

### Methode 1: Online-Verwaltungs-Backend (empfohlen)

1. Besuchen Sie die Seite `/admin`
2. Melden Sie sich mit dem Admin-Passwort an
3. Füllen Sie die Artikeldaten aus und senden Sie sie ab
4. Der Artikel wird automatisch über die GitHub API erstellt, Vercel wird automatisch neu bereitgestellt

### Methode 2: Manuelles Hinzufügen von Dateien

1. Erstellen Sie eine neue Markdown-Datei im Verzeichnis `content/posts`
2. Dateinamenformat: xxx.md`
3. Fügen Sie am Anfang der Datei Metadaten hinzu:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Notiz hinzufügen

1. Erstellen Sie eine neue Markdown-Datei im Verzeichnis `content/notes`
2. Dateibenennungsformat: `YYYY-MM-DD-title.md`
3. Fügen Sie Metadaten am Anfang der Datei hinzu:

```markdown
---
date: YYYY-MM-DD
---
```

## Verwaltung des Admin-Backends konfigurieren

Das Admin-Backend verwendet GitHub OAuth zur Authentifizierung. Nur Repository-Eigentümer oder Mitwirkende haben Zugriff.

### 1. Erstellen einer GitHub OAuth App

1. Gehe zu [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Klicke auf "New OAuth App"
3. Fülle die Informationen aus:
   - **Application name**: `Jimmy Blog Admin` (oder beliebiger Name)
   - **Homepage URL**: `https://deine-domain.com` (Produktivumgebung) oder `http://localhost:3000` (lokale Entwicklung)
   - **Authorization callback URL**: 
     - Produktivumgebung: `https://deine-domain.com/api/auth/github/callback`
     - Lokale Entwicklung: `http://localhost:3000/api/auth/github/callback`
4. Klicke auf "Register application"
5. Notiere die **Client ID**
6. Klicke auf "Generate a new client secret" und notiere das **Client secret**

### 2. Umgebungsvariablen konfigurieren

Füge im Vercel-Projekt folgende Umgebungsvariablen hinzu:

- `GITHUB_CLIENT_ID`: Deine GitHub OAuth App Client ID
- `GITHUB_CLIENT_SECRET`: Dein GitHub OAuth App Client Secret
- `GITHUB_OWNER`: GitHub-Benutzername (Standard: `Lily-404`, zur Benutzerrechteprüfung)
- `GITHUB_REPO`: Repository-Name (Standard: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth Callback-URL (optional, wird standardmäßig automatisch generiert)
- `NEXT_PUBLIC_BASE_URL`: Deine Website-URL (zur Generierung der Callback-URL, in Produktion erforderlich)
  - Produktion: `https://www.jimmy-blog.top`
  - Lokale Entwicklung: `http://localhost:3000`

### 3. Lokale Entwicklung konfigurieren

Erstelle im Projektstamm die Datei `.env.local`:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Produktionsumgebungskonfiguration (Vercel)

Stellen Sie in den Vercel-Projekteinstellungen sicher, dass Sie Folgendes festlegen:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Hinweis**: 
- Die Datei `.env.local` wurde zu `.gitignore` hinzugefügt und wird nicht in Git übernommen
- Stelle bei der lokalen Entwicklung sicher, dass die Callback-URL der OAuth-App auf `http://localhost:3000/api/auth/github/callback` gesetzt ist
- **In der Produktionsumgebung muss `NEXT_PUBLIC_BASE_URL` auf `https://www.jimmy-blog.top` gesetzt werden**
- Die Callback-URL der OAuth-App für die Produktion sollte sein: `https://www.jimmy-blog.top/api/auth/github/callback`

## Deployment

Das Projekt ist für die Bereitstellung mit Vercel konfiguriert und unterstützt automatisches Deployment. Einfach den Code ins GitHub-Repository pushen, Vercel baut und deployed automatisch.

### Vorteile der Nutzung des Admin-Backends

- ✅ Keine lokale Entwicklungsumgebung erforderlich
- ✅ Artikel können jederzeit und überall hinzugefügt werden
- ✅ Automatisches Auslösen des Vercel-Re-Deployments
- ✅ Komplett kostenlos (GitHub OAuth und Vercel im kostenlosen Kontingent)
- ✅ Sicher (GitHub OAuth-Authentifizierung, nur Repository-Besitzer/Kollaborateure haben Zugriff)
- ✅ Kein Passwort-Management notwendig, Login mit GitHub-Account

## Beitrag

Beiträge sind willkommen! Bitte Issues und Pull Requests einreichen.

## Lizenz

MIT-Lizenz


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---