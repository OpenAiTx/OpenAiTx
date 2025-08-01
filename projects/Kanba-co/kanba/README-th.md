
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# โอเพ่นซอร์ส ทางเลือกที่เบาและเหมือน Trello สำหรับนักสร้างสรรค์และอินดี้แฮกเกอร์

เน้นความเรียบง่าย ความเร็ว และการขยายขนาดได้
สร้างด้วยเทคโนโลยีสมัยใหม่: Tailwind CSS, shadcn/ui, Supabase, การเชื่อมต่อ Stripe
รองรับโปรเจกต์ไม่จำกัด การทำงานร่วมกันเป็นทีม โหมดกลางวัน/กลางคืน และประสบการณ์ผู้ใช้ที่ลื่นไหล
เหมาะสำหรับนักพัฒนาเดี่ยวและทีมขนาดเล็กที่ต้องการควบคุมเต็มที่โดยไม่มีความซับซ้อนที่ไม่จำเป็น

## 🌟 หากคุณพบว่าโปรเจกต์นี้มีประโยชน์ โปรดกดดาวให้ด้วย! เพื่อช่วยให้คนอื่นค้นพบโปรเจกต์นี้เช่นกัน

# คู่มือการดีพลอย

## ภาพรวม
แอปพลิเคชันนี้เปลี่ยนมาใช้ API routes ของ Next.js ในเครื่อง แทน Supabase Edge Functions สำหรับการเชื่อมต่อ Stripe ช่วยให้ดีพลอยง่ายขึ้น และสามารถใช้ไฟล์ .env ปกติในการตั้งค่าได้

## การตั้งค่าตัวแปรสภาพแวดล้อม

### 1. สร้างไฟล์ .env.local
คัดลอก `.env.example` ไปเป็น `.env.local` แล้วกรอกค่าจริงของคุณลงไป:

```bash
cp .env.example .env.local
```

### 2. ตัวแปรสภาพแวดล้อมที่จำเป็น

#### การตั้งค่า Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL ของโปรเจกต์ Supabase ของคุณ
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - คีย์ anonymous ของ Supabase ของคุณ
- `SUPABASE_SERVICE_ROLE_KEY` - คีย์ service role ของ Supabase (ใช้เฉพาะฝั่งเซิร์ฟเวอร์)

#### การตั้งค่า Stripe (ไม่บังคับ)
- `STRIPE_SECRET_KEY` - คีย์ลับ Stripe ของคุณ (ใช้เฉพาะฝั่งเซิร์ฟเวอร์)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - คีย์ publishable ของ Stripe ของคุณ
- `STRIPE_WEBHOOK_SECRET` - คีย์ webhook ลับของ Stripe

#### การตั้งค่าไซต์
- `NEXT_PUBLIC_SITE_URL` - URL ของเว็บไซต์ของคุณ (สำหรับ production)
- `NEXTAUTH_URL` - URL ของเว็บไซต์ของคุณ (เหมือนกับด้านบน)
- `NEXTAUTH_SECRET` - คีย์ลับแบบสุ่มสำหรับ NextAuth

## การพัฒนาในเครื่อง

1. ติดตั้ง dependency:
```bash
npm install
```

2. ตั้งค่าตัวแปรสภาพแวดล้อมของคุณใน `.env.local`

3. รันเซิร์ฟเวอร์สำหรับการพัฒนา:
```bash
npm run dev
```

4. ทดสอบ Stripe webhooks ในเครื่องโดยใช้ Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## การปรับใช้งานจริง


### การปรับใช้บน Vercel

1. **ปรับใช้ไปยัง Vercel:**
```bash
npx vercel
```
2. **ตัวแปรสภาพแวดล้อม:**
   เพิ่มตัวแปรสภาพแวดล้อมทั้งหมดผ่านแดชบอร์ด Vercel หรือ CLI

3. **ตั้งค่า Stripe Webhook:**
   - ชี้ webhook ไปที่: `https://your-domain.vercel.app/api/stripe/webhook`

## จุดเชื่อมต่อ API

แอปพลิเคชันนี้ใช้เส้นทาง API ภายในเหล่านี้:

- `POST /api/stripe/checkout` - สร้างเซสชัน Stripe checkout
- `POST /api/stripe/webhook` - จัดการอีเวนต์ Stripe webhook

## ข้อดีของเส้นทาง API ภายใน

1. **การดีพลอยที่ง่ายกว่า** - ไม่ต้องดีพลอยฟังก์ชัน edge แยกต่างหาก
2. **ตัวแปรสภาพแวดล้อม** - รองรับไฟล์ .env มาตรฐาน
3. **การดีบักที่ดีกว่า** - สามารถดีบักในเครื่องได้ง่ายขึ้น
4. **การผสานรวมกับเฟรมเวิร์ก** - ผสานรวมกับ Next.js ได้ดีกว่า
5. **ไม่ผูกขาดกับผู้ให้บริการ** - สามารถดีพลอยบนแพลตฟอร์มใดก็ได้ที่รองรับ Next.js

## การแก้ไขปัญหา

1. **ปัญหา Webhook:**
   - ตรวจสอบให้แน่ใจว่า `STRIPE_WEBHOOK_SECRET` ตรงกับ webhook endpoint ใน Stripe ของคุณ
   - ตรวจสอบบันทึก webhook ในแดชบอร์ด Stripe
   - ตรวจสอบว่า URL webhook ถูกต้อง

2. **ตัวแปรสภาพแวดล้อม:**
   - ตรวจสอบให้แน่ใจว่าตั้งค่าตัวแปรที่ต้องการครบ
   - ตรวจสอบการสะกดชื่อของตัวแปร
   - ตรวจสอบว่า Supabase service role key มีสิทธิ์ที่เหมาะสม

3. **ปัญหา CORS:**
   - เส้นทาง API รวม header CORS ที่เหมาะสมไว้แล้ว
   - ตรวจสอบให้แน่ใจว่าโดเมนของคุณอยู่ใน whitelist หากจำเป็น

## หมายเหตุด้านความปลอดภัย

- อย่าเปิดเผย `STRIPE_SECRET_KEY` หรือ `SUPABASE_SERVICE_ROLE_KEY` กับฝั่ง client เด็ดขาด
- ใช้ prefix `NEXT_PUBLIC_` เฉพาะกับตัวแปรฝั่ง client เท่านั้น
- หมุนเวียน webhook secrets ของคุณเป็นประจำ
- ตรวจสอบการส่งมอบ webhook ในแดชบอร์ด Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---