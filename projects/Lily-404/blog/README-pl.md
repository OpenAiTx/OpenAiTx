
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# Blog Jimmy'ego

Minimalistyczny system blogowy dla jednej osoby, zbudowany w oparciu o Next.js 15+, wspiera tworzenie online oraz statyczne wdrażanie.

## Stos technologiczny

- **Framework**: Next.js 15+ (App Router)
- **Język**: TypeScript
- **Styl**: Tailwind CSS
- **Ikony**: Lucide Icons
- **Treść**: Markdown + Gray Matter + Remark
- **Uwierzytelnianie**: GitHub OAuth
- **Wdrożenie**: Vercel

## Funkcje i cechy

### Po stronie czytelnika

- 📝 Renderowanie artykułów Markdown + GFM (w tym wyświetlanie wzorów matematycznych)
- 🏷️ Filtrowanie po tagach, stronicowanie, archiwizacja (wg roku/tagu)
- 📚 Nawigacja po spisie treści (TOC) oraz kopiowanie bloków kodu jednym kliknięciem
- 📱 Responsywny layout i przełączanie motywu jasny/ciemny
- 🔥 Unoszący się kalendarz aktywności twórczej (artykuły + notatki)
- 📡 Wyjście RSS do subskrypcji (`/rss.xml`)

### Po stronie twórcy (panel administracyjny)

- 🔐 Logowanie przez GitHub OAuth (weryfikacja uprawnień właściciela/współpracownika)
- ✍️ Tworzenie, edycja i usuwanie artykułów/notatek online
- 🆔 Własny plik ID + automatyczne unikanie konfliktów
- 👀 Tryby pisania: edycja / podgląd / podzielony ekran
- 📊 Panel statystyk twórczości (łącznie, tygodniowo/miesięcznie, popularne tagi)

### Po stronie inżynierskiej

- ⚡ Wielostronicowa statyczna generacja (`force-static`) dla wydajności i stabilności
- 🧭 Wbudowany sitemap oraz robots
- 🧩 Buforowanie odczytu treści i modułowa struktura API

## Struktura projektu

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

## Instalacja i uruchomienie

1. Sklonuj projekt

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Instalacja zależności

```bash
npm install
```

3. Uruchomienie serwera deweloperskiego

```bash
npm run dev
```

4. Budowanie wersji produkcyjnej

```bash
npm run build
```

## Dodawanie nowych artykułów

### Metoda pierwsza: Zarządzanie online przez panel administracyjny (zalecana)

1. Wejdź na stronę `/admin`
2. Zaloguj się przez GitHub OAuth
3. Wypełnij informacje o artykule i prześlij
4. Artykuł zostanie automatycznie utworzony przez API GitHub, Vercel automatycznie wdroży ponownie

### Metoda druga: Ręczne dodanie pliku

1. Utwórz nowy plik Markdown w katalogu `content/posts`
2. Format nazwy pliku: `xxx.md`
3. Dodaj metadane na początku pliku:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Dodaj notatkę

1. Utwórz nowy plik Markdown w katalogu `content/notes`
2. Format nazwy pliku: `YYYY-MM-DD-title.md`
3. Dodaj metadane na początku pliku:

```markdown
---
date: YYYY-MM-DD
---
```

## Konfiguracja panelu administracyjnego

Panel administracyjny używa GitHub OAuth do uwierzytelniania, dostęp mają tylko właściciele repozytorium lub współpracownicy.

### 1. Utwórz aplikację GitHub OAuth

1. Wejdź na [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Kliknij "New OAuth App"
3. Wypełnij informacje:
   - **Application name**: `Jimmy Blog Admin` (lub dowolna nazwa)
   - **Homepage URL**: `https://twojadomena.com` (środowisko produkcyjne) lub `http://localhost:3000` (lokalne środowisko)
   - **Authorization callback URL**: 
     - Produkcja: `https://twojadomena.com/api/auth/github/callback`
     - Lokalnie: `http://localhost:3000/api/auth/github/callback`
4. Kliknij "Register application"
5. Zanotuj **Client ID**
6. Kliknij "Generate a new client secret" i zanotuj **Client secret**

### 2. Konfiguracja zmiennych środowiskowych

Dodaj poniższe zmienne środowiskowe w ustawieniach projektu Vercel:

- `GITHUB_CLIENT_ID`: Twój Client ID aplikacji GitHub OAuth
- `GITHUB_CLIENT_SECRET`: Twój Client Secret aplikacji GitHub OAuth
- `GITHUB_OWNER`: Nazwa użytkownika GitHub (domyślnie: `Lily-404`, używane do weryfikacji uprawnień)
- `GITHUB_REPO`: Nazwa repozytorium (domyślnie: `blog`)
- `GITHUB_REDIRECT_URI`: URL callback OAuth (opcjonalnie, domyślnie generowany automatycznie)
- `NEXT_PUBLIC_BASE_URL`: URL Twojej strony (do generowania callback URL, produkcja musi być ustawiona)
  - Produkcja: `https://www.jimmy-blog.top`
  - Lokalnie: `http://localhost:3000`

### 3. Konfiguracja do lokalnego rozwoju

Utwórz plik `.env.local` w katalogu głównym projektu:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Konfiguracja środowiska produkcyjnego (Vercel)

W ustawieniach projektu Vercel upewnij się, że zostały ustawione:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **Uwaga**: 
- Plik `.env.local` został dodany do `.gitignore` i nie będzie przesyłany do Git
- Podczas lokalnej pracy upewnij się, że URL zwrotny OAuth App ustawiony jest na `http://localhost:3000/api/auth/github/callback`
- **W środowisku produkcyjnym należy ustawić `NEXT_PUBLIC_BASE_URL` na `https://www.jimmy-blog.top`**
- URL zwrotny OAuth App w produkcji powinien być ustawiony na: `https://www.jimmy-blog.top/api/auth/github/callback`

## Wdrażanie

Projekt jest skonfigurowany do wdrażania na Vercel, wspiera automatyczne wdrażanie. Wystarczy przesłać kod do repozytorium GitHub, a Vercel automatycznie zbuduje i wdroży aplikację.

### Zalety korzystania z panelu administracyjnego

- ✅ Brak potrzeby lokalnego środowiska programistycznego
- ✅ Możliwość dodawania artykułów z dowolnego miejsca i czasu
- ✅ Automatyczne wyzwalanie ponownego wdrożenia Vercel
- ✅ Całkowicie za darmo (GitHub OAuth i Vercel mieszczą się w darmowych limitach)
- ✅ Bezpieczne (weryfikacja GitHub OAuth, dostęp tylko dla właściciela repozytorium/współpracowników)
- ✅ Brak konieczności zarządzania hasłami, logowanie za pomocą konta GitHub
- ✅ Możliwość edycji istniejących treści online (nie tylko dodawania nowych)
- ✅ Automatyczne rozwiązywanie konfliktów ID plików, unikając nadpisywania i ręcznego zmieniania nazw
- ✅ Statystyki twórczości w panelu administracyjnym, ułatwiające stałą działalność contentową

## Analiza projektu i plany na przyszłość

- Dokument analizy projektu: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- Dokument planów na przyszłość: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## Wkład

Zapraszamy do zgłaszania Issue i Pull Requestów!

## Licencja

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---