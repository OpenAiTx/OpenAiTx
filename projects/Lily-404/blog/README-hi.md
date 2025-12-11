
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# जिमी का ब्लॉग

एक सरल व्यक्तिगत ब्लॉग सिस्टम, जो Next.js 15+ पर आधारित है।

## तकनीकी स्टैक

- **फ्रेमवर्क**: Next.js 13+ (ऐप राउटर)
- **स्टाइलिंग**: Tailwind CSS
- **आइकन**: Lucide Icons
- **थीम**: डार्क/लाइट मोड स्विचिंग सपोर्ट
- **डिप्लॉयमेंट**: Vercel

## फ़ीचर्स

- 📝 मार्कडाउन लेख सपोर्ट
- 🌓 डार्क/लाइट थीम स्विचिंग
- 📱 रिस्पॉन्सिव डिज़ाइन
- ⚡ तेज़ लोडिंग
- 📅 लेख टाइमलाइन डिस्प्ले

## परियोजना संरचना

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

## इंस्टॉल और रन करें

1. प्रोजेक्ट क्लोन करें

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. निर्भरता स्थापित करें

```bash
npm install
```
3. डेवलपमेंट सर्वर चलाएँ


```bash
npm run dev
```

4. उत्पादन संस्करण का निर्माण

```bash
npm run build
```

## नई लेख जोड़ें

1. `content/posts` डायरेक्टरी में नया मार्कडाउन फ़ाइल बनाएँ
2. फ़ाइल का नामकरण प्रारूप: xxx.md`
3. फ़ाइल के शीर्ष पर मेटाडेटा जोड़ें:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## नई नोट जोड़ें

1. `content/notes` निर्देशिका में नया Markdown फ़ाइल बनाएं
2. फ़ाइल नामकरण प्रारूप: `YYYY-MM-DD-title.md`
3. फ़ाइल के शीर्ष भाग में मेटाडेटा जोड़ें:

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