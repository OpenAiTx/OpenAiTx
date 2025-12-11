
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# บล็อกของ Jimmy

ระบบบล็อกส่วนบุคคลแบบมินิมอลที่สร้างขึ้นด้วย Next.js 15+

## สแต็กเทคโนโลยี

- **เฟรมเวิร์ก**: Next.js 13+ (App Router)
- **สไตล์**: Tailwind CSS
- **ไอคอน**: Lucide Icons
- **ธีม**: รองรับการสลับโหมดมืด/โหมดสว่าง
- **การปรับใช้**: Vercel

## คุณสมบัติเด่น

- 📝 รองรับบทความ Markdown
- 🌓 สลับธีมโหมดมืด/โหมดสว่าง
- 📱 การออกแบบตอบสนอง
- ⚡ โหลดเร็ว
- 📅 แสดงไทม์ไลน์บทความ

## โครงสร้างโปรเจกต์

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

## การติดตั้งและการใช้งาน

1. โคลนโปรเจกต์

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. ติดตั้ง Dependencies

```bash
npm install
```

3. รันเซิร์ฟเวอร์สำหรับการพัฒนา

```bash
npm run dev
```

4. สร้างเวอร์ชันสำหรับการผลิต

```bash
npm run build
```

## เพิ่มบทความใหม่

1. สร้างไฟล์ Markdown ใหม่ในไดเรกทอรี `content/posts`
2. รูปแบบการตั้งชื่อไฟล์: xxx.md`
3. เพิ่มข้อมูลเมตาไว้ที่ส่วนหัวของไฟล์:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## เพิ่มบันทึก

1. สร้างไฟล์ Markdown ใหม่ในไดเรกทอรี `content/notes`
2. รูปแบบการตั้งชื่อไฟล์: `YYYY-MM-DD-title.md`
3. เพิ่มข้อมูลเมตาที่ส่วนหัวของไฟล์:

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