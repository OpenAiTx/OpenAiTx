
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
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

# บล็อกของจิมมี่

ระบบบล็อกส่วนตัวแบบมินิมอล สร้างด้วย Next.js 15+ รองรับการสร้างเนื้อหาออนไลน์และการดีพลอยแบบ Static

## เทคโนโลยีที่ใช้

- **เฟรมเวิร์ก**: Next.js 15+ (App Router)
- **ภาษา**: TypeScript
- **สไตล์**: Tailwind CSS
- **ไอคอน**: Lucide Icons
- **เนื้อหา**: Markdown + Gray Matter + Remark
- **การยืนยันตัวตน**: GitHub OAuth
- **การปรับใช้**: Vercel

## คุณลักษณะ

### ฝั่งผู้อ่าน

- 📝 การเรนเดอร์บทความ Markdown + GFM (รวมทั้งการแสดงสูตรคณิตศาสตร์)
- 🏷️ การกรองแท็ก, การแบ่งหน้า, การจัดเก็บ (ตามปี/แท็ก)
- 📚 ระบบนำทางสารบัญบทความ (TOC) และการคัดลอกโค้ดบล็อกในคลิกเดียว
- 📱 เลย์เอาต์ตอบสนองและการสลับธีมสีเข้ม/สว่าง
- 🔥 แผนที่ความร้อนปฏิทินการสร้างสรรค์แบบลอย (บทความ + บันทึก)
- 📡 ส่งออกการสมัคร RSS (`/rss.xml`)

### ฝั่งสร้างสรรค์ (แผงควบคุมผู้ดูแล)

- 🔐 การเข้าสู่ระบบ GitHub OAuth (ตรวจสอบสิทธิ์เจ้าของ/ผู้ร่วมงาน)
- ✍️ การสร้าง, แก้ไข, ลบบทความ/บันทึกออนไลน์
- 🆔 กำหนดไฟล์ ID เอง + หลบหลีกความขัดแย้งอัตโนมัติ
- 👀 โหมดการเขียน 3 แบบ: แก้ไข / แสดงตัวอย่าง / แบ่งหน้าจอ
- 📊 แผงสถิติการสร้างสรรค์ (ยอดรวม, ผลิตรายสัปดาห์/เดือน, แท็กยอดนิยม)

### ฝั่งวิศวกรรม

- ⚡ การเรนเดอร์หน้าแบบสแตติกหลายหน้า (`force-static`) เพื่อเพิ่มประสิทธิภาพและความเสถียร
- 🧭 sitemap และ robots ในตัว
- 🧩 แคชการอ่านเนื้อหาและโครงสร้าง API แบบโมดูลาร์

## โครงสร้างโปรเจกต์

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

## การเพิ่มบทความใหม่

### วิธีที่หนึ่ง: ผ่านระบบหลังบ้านออนไลน์ (แนะนำ)

1. เข้าถึงหน้่า `/admin`
2. ใช้ GitHub OAuth เพื่อเข้าสู่ระบบ
3. กรอกข้อมูลบทความและส่งข้อมูล
4. บทความจะถูกสร้างโดยอัตโนมัติผ่าน GitHub API และ Vercel จะปรับใช้ใหม่โดยอัตโนมัติ

### วิธีที่สอง: เพิ่มไฟล์ด้วยตนเอง

1. สร้างไฟล์ Markdown ใหม่ในไดเรกทอรี `content/posts`
2. รูปแบบการตั้งชื่อไฟล์: `xxx.md`
3. เพิ่มข้อมูลเมตาที่ส่วนหัวของไฟล์:

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

## การตั้งค่าหน้าแอดมิน

หน้าแอดมินใช้ GitHub OAuth สำหรับการยืนยันตัวตน เฉพาะเจ้าของหรือผู้ร่วมงานของรีโปเท่านั้นที่สามารถเข้าถึงได้

### 1. สร้าง GitHub OAuth App

1. ไปที่ [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. คลิก "New OAuth App"
3. กรอกข้อมูลดังนี้:
   - **Application name**: `Jimmy Blog Admin` (หรือชื่อใดก็ได้)
   - **Homepage URL**: `https://โดเมนของคุณ.com` (สำหรับโปรดักชั่น) หรือ `http://localhost:3000` (สำหรับพัฒนาในเครื่อง)
   - **Authorization callback URL**:
     - โปรดักชั่น: `https://โดเมนของคุณ.com/api/auth/github/callback`
     - พัฒนาในเครื่อง: `http://localhost:3000/api/auth/github/callback`
4. คลิก "Register application"
5. จดบันทึก **Client ID**
6. คลิก "Generate a new client secret" แล้วบันทึก **Client secret**

### 2. ตั้งค่าสิ่งแวดล้อม

เพิ่มตัวแปรสิ่งแวดล้อมต่อไปนี้ใน Vercel Project Settings:

- `GITHUB_CLIENT_ID`: Client ID ของ GitHub OAuth App ของคุณ
- `GITHUB_CLIENT_SECRET`: Client Secret ของ GitHub OAuth App ของคุณ
- `GITHUB_OWNER`: ชื่อผู้ใช้ GitHub (ค่าเริ่มต้น: `Lily-404` สำหรับตรวจสอบสิทธิ์ผู้ใช้)
- `GITHUB_REPO`: ชื่อรีโป (ค่าเริ่มต้น: `blog`)
- `GITHUB_REDIRECT_URI`: OAuth Callback URL (ไม่บังคับ ค่าเริ่มต้นจะสร้างให้อัตโนมัติ)
- `NEXT_PUBLIC_BASE_URL`: URL เว็บไซต์ของคุณ (ใช้สำหรับสร้าง Callback URL โปรดักชั่นต้องตั้งค่านี้)
  - โปรดักชั่น: `https://www.jimmy-blog.top`
  - พัฒนาในเครื่อง: `http://localhost:3000`

### 3. การตั้งค่าสำหรับพัฒนาในเครื่อง

สร้างไฟล์ `.env.local` ในโฟลเดอร์รากของโปรเจกต์:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. การตั้งค่าสภาพแวดล้อมการผลิต (Vercel)

ในหน้าการตั้งค่าโปรเจกต์ Vercel ให้ตรวจสอบการตั้งค่า:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```

⚠️ **ข้อควรระวัง**: 
- ไฟล์ `.env.local` ถูกเพิ่มไว้ใน `.gitignore` แล้ว จะไม่ถูกส่งขึ้น Git
- ขณะพัฒนาในเครื่อง ให้แน่ใจว่าได้ตั้งค่า OAuth App callback URL เป็น `http://localhost:3000/api/auth/github/callback`
- **ในสภาพแวดล้อมจริงต้องตั้งค่า `NEXT_PUBLIC_BASE_URL` เป็น `https://www.jimmy-blog.top`**
- สำหรับ Production ให้ตั้งค่า OAuth App callback URL เป็น: `https://www.jimmy-blog.top/api/auth/github/callback`

## การปรับใช้ (Deploy)

โปรเจกต์ได้ตั้งค่าให้ใช้ Vercel สำหรับการปรับใช้อัตโนมัติ เพียงแค่ push โค้ดขึ้น GitHub Repository ระบบจะ build และ deploy ให้อัตโนมัติ

### ข้อดีของการใช้แผงควบคุมผู้ดูแล (Admin Panel)

- ✅ ไม่ต้องใช้สภาพแวดล้อมการพัฒนาในเครื่อง
- ✅ สามารถเพิ่มบทความได้ทุกที่ทุกเวลา
- ✅ กระตุ้นการ deploy ใหม่บน Vercel อัตโนมัติ
- ✅ ฟรีทั้งหมด (GitHub OAuth และ Vercel อยู่ในโควต้าฟรี)
- ✅ ปลอดภัย (ยืนยันตัวตนผ่าน GitHub OAuth เฉพาะเจ้าของ/ผู้ร่วมงานที่เข้าถึงได้)
- ✅ ไม่ต้องจำรหัสผ่าน ใช้บัญชี GitHub ในการเข้าสู่ระบบ
- ✅ รองรับการแก้ไขเนื้อหาออนไลน์ (ทั้งใหม่และของเดิม)
- ✅ จัดการปัญหา file ID ซ้ำโดยอัตโนมัติ ลดความเสี่ยง overwrite และไม่ต้องเปลี่ยนชื่อไฟล์เอง
- ✅ มีสถิติการสร้างเนื้อหาในแผงหลังบ้าน สะดวกต่อการบริหารและวางแผนเนื้อหา

## การวิเคราะห์โปรเจกต์และแผนในอนาคต

- เอกสารวิเคราะห์โปรเจกต์: [`docs/project-analysis.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/project-analysis.md)
- เอกสารแผนอนาคต: [`docs/future-roadmap.md`](https://raw.githubusercontent.com/Lily-404/blog/main/docs/future-roadmap.md)

## การมีส่วนร่วม

ยินดีต้อนรับทุก Issue และ Pull Request!

## ใบอนุญาต

MIT License


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---