<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>ธีมบล็อก Astro</p>
<p>Sora หมายถึง "ท้องฟ้า" เป็นสัญลักษณ์ของความเป็นไปได้ที่ไร้ขีดจำกัดและความคิดสร้างสรรค์ที่กว้างใหญ่</p>
<p>หากคุณชื่นชอบธีมนี้ อย่าลืมกด 🌟Star!</p>
<p><strong>简体中文</strong> | <a href="/README.en.md">English</a></p>
</div>

# ตัวอย่าง

[My Blog](https://blog.liks.space)

## ใครกำลังใช้งาน

ยินดีต้อนรับให้ส่ง [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) เพื่อแสดงเว็บไซต์ของคุณ

# เริ่มต้น

1. ติดตั้งธีม

   - ติดตั้ง [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - เข้าสู่ไดเรกทอรีโปรเจกต์ รัน `pnpm dev` เพื่อเริ่มโปรเจกต์

2. ตั้งค่าธีม

   แก้ไขไฟล์ตั้งค่า `theme.config.ts` เพื่อปรับแต่งธีม ดูรายละเอียดที่ [การตั้งค่า](#配置)

3. แก้ไขบทความ

   แก้ไขในไดเรกทอรี `src/content/` รองรับรูปแบบ Markdown

4. ดีพลอยเว็บไซต์

   รัน `pnpm build` เพื่อสร้างเว็บไซต์ ไฟล์ที่สร้างจะอยู่ในไดเรกทอรี `dist/` สามารถรัน `pnpm preview` เพื่อดูตัวอย่างเว็บไซต์บนเครื่อง

   สามารถดีพลอยเว็บไซต์ไปยังเซิร์ฟเวอร์ของตนเอง หรือดูคำแนะนำจาก [เอกสาร Astro](https://docs.astro.build/en/guides/deploy/) สำหรับดีพลอยไปยัง Vercel, Netlify, GitHub Pages ฯลฯ

<!-- # 文档 -->

# การตั้งค่า

ไฟล์ตั้งค่าคือ `theme.config.ts`

## ข้อมูลเว็บไซต์

```typescript
site: {
  // ที่อยู่เว็บไซต์
  url: "https://blog.liks.space",
  // ชื่อเว็บไซต์
  title: "Sora",
  // ชื่อเจ้าของ
  author: "Liks",
  // คำอธิบายเว็บไซต์
  description: "A blog theme built with Astro",
  // ไอคอนเว็บไซต์
  // รองรับ SVG, PNG, ICO
  // เส้นทางไฟล์ภายในไดเรกทอรี public/
  favicon: "/images/favicon.ico",
}
```

## การตั้งค่าทั่วไป

```typescript
global: {
  // รูปโปรไฟล์
  // เส้นทางไฟล์ภายในไดเรกทอรี src/images/
  avatar: "avatar.jpg",
  // เปิดใช้งาน RSS
  rss: true,
  // เปิดใช้งานหลายภาษา (อยู่ระหว่างการพัฒนา)
  i18n: true,
}
```

## แถบนำทาง

```typescript
nav: [
  {
    // ชื่อหน้า
    name: "คลังบทความ",
    // ที่อยู่หน้า
    url: "/archives",
  },
  {
    name: "หมวดหมู่",
    url: "/categories",
  },
  {
    name: "แท็ก",
    url: "/tags",
  },
  {
    name: "เกี่ยวกับ",
    url: "/about",
  },
  ...
];
```

## ส่วนท้าย

```typescript
footer: {
  // ลิขสิทธิ์
  copyright: {
    // ปีที่เริ่มสร้าง
    time: "2024 - 2025",
    // เจ้าของลิขสิทธิ์
    owner: "Liks",
  },
  // การจดทะเบียน (สำหรับจีน)
  beian: {
    // จดทะเบียน ICP
    icp: {
      // เปิดใช้งาน
      enabled: false,
      // หมายเลขจดทะเบียน
      number: "京 ICP 备 12345678 号",
    },
    // จดทะเบียนตำรวจ
    police: {
      // เปิดใช้งาน
      enabled: false,
      // หมายเลขจดทะเบียน
      number: "京公网安备 12345678901234 号",
      // เว็บไซต์จดทะเบียน
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## หน้าแรก

```typescript
index: {
  // โซเชียลมีเดีย
  social: [
    {
      // ชื่อ
      name: "GitHub",
      // เปิดใช้งาน
      enabled: true,
      // ที่อยู่
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

รองรับ BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu

## หน้าบทความ

```typescript
post: {
  // ใบอนุญาตลิขสิทธิ์
  copyright: {
    // ใบอนุญาต CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // ที่อยู่ใบอนุญาต
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## การสนับสนุน

```typescript
sponsor: {
  // เปิดใช้งาน
  enabled: true,
  // คิวอาร์โค้ด Alipay
  alipay: {
    // เปิดใช้งาน
    enabled: true,
    // เส้นทางไฟล์ภายในไดเรกทอรี src/images/
    image: "alipay.png",
  },
  // คิวอาร์โค้ด WeChat
  wechat: {
    enabled: false,
  },
  // แสดงรายชื่อผู้สนับสนุน
  list: true,
}
```

## ความคิดเห็น

```typescript
comment: {
  // เปิดใช้งาน
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // ที่อยู่เซิร์ฟเวอร์ฝั่งหลังบ้าน
    server: "https://artalk.example.com",
    // ชื่อเว็บไซต์
    site: "Sora",
  },
}
```

## เครื่องมือ

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // เปิดใช้งาน
    enabled: false,
    // ที่อยู่เซิร์ฟเวอร์
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# ใบอนุญาต

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# ขอบคุณ

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