
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
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Blog Jimmy'ego

Minimalistyczny system blogowy oparty na Next.js 15+.

## Stos technologiczny

- **Framework**: Next.js 13+ (App Router)
- **Stylizacja**: Tailwind CSS
- **Ikona**: Lucide Icons
- **Motyw**: Obsługa przełączania trybu ciemnego/jasnego
- **Wdrożenie**: Vercel

## Cechy funkcjonalne

- 📝 Wsparcie dla artykułów w Markdown
- 🌓 Przełączanie motywu ciemnego/jasnego
- 📱 Responsywny design
- ⚡ Szybkie ładowanie
- 📅 Wyświetlanie osi czasu artykułów

## Struktura projektu

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

## Dodawanie nowego artykułu

1. Utwórz nowy plik Markdown w katalogu `content/posts`
2. Format nazwy pliku: xxx.md`
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

## 部署

项目已配置 Vercel 部署，支持自动部署。只需将代码推送到 GitHub 仓库，Vercel 会自动构建和部署。

## 贡献

欢迎提交 Issue 和 Pull Request！

## 许可证

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---