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

# ทางเลือก Trello แบบโอเพ่นซอร์ส น้ำหนักเบา ออกแบบมาสำหรับนักพัฒนาและผู้สร้างสรรค์อิสระ

เน้นความเรียบง่าย ความเร็ว และความสามารถในการขยายระบบ
สร้างด้วยเทคโนโลยีสมัยใหม่: Tailwind CSS, shadcn/ui, Supabase, เชื่อมต่อ Stripe
รองรับโปรเจกต์ไม่จำกัด การทำงานร่วมกันเป็นทีม โหมดมืด/สว่าง และประสบการณ์ผู้ใช้ที่ลื่นไหล
เหมาะสำหรับนักพัฒนาเดี่ยวและทีมขนาดเล็กที่ต้องการควบคุมระบบได้เต็มที่โดยไม่ซับซ้อนเกินจำเป็น

## 🌟 หากคุณพบว่าโปรเจกต์นี้มีประโยชน์ อย่าลืมกดดาวให้ด้วย! เพื่อช่วยให้คนอื่นค้นพบได้เช่นกัน

# คู่มือการติดตั้งใช้งาน

## ภาพรวม
แอปพลิเคชันนี้ตอนนี้ใช้เส้นทาง API ภายในของ Next.js แทนฟังก์ชัน Supabase Edge สำหรับการเชื่อมต่อ Stripe ซึ่งจะช่วยให้การติดตั้งง่ายขึ้น และสามารถใช้ไฟล์ .env มาตรฐานในการตั้งค่าได้

## การตั้งค่าตัวแปรสภาพแวดล้อม

### 1. สร้างไฟล์ .env.local
คัดลอก `.env.example` ไปยัง `.env.local` และกรอกค่าจริงของคุณ:


```bash
cp .env.example .env.local
```
### 2. ตัวแปรสภาพแวดล้อมที่จำเป็น

#### การตั้งค่า Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL โครงการ Supabase ของคุณ
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - คีย์ anonymous ของ Supabase ของคุณ
- `SUPABASE_SERVICE_ROLE_KEY` - คีย์ service role ของ Supabase (ใช้เฉพาะฝั่งเซิร์ฟเวอร์)

#### การตั้งค่า Stripe (ไม่บังคับ)
- `STRIPE_SECRET_KEY` - คีย์ลับ Stripe ของคุณ (ใช้เฉพาะฝั่งเซิร์ฟเวอร์)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - คีย์เผยแพร่ Stripe ของคุณ
- `STRIPE_WEBHOOK_SECRET` - คีย์ webhook ของ Stripe ของคุณ

#### การตั้งค่าเว็บไซต์
- `NEXT_PUBLIC_SITE_URL` - URL เว็บไซต์ของคุณ (สำหรับ production)
- `NEXTAUTH_URL` - URL เว็บไซต์ของคุณ (เหมือนกับด้านบน)
- `NEXTAUTH_SECRET` - รหัสลับสุ่มสำหรับ NextAuth

## การพัฒนาในเครื่อง

1. ติดตั้ง dependencies:

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
## การนำขึ้นใช้งานในสภาพแวดล้อมการผลิต


### การนำขึ้นใช้งานด้วย Vercel

1. **นำขึ้นใช้งานกับ Vercel:**

```bash
npx vercel
```
2. **ตัวแปรสภาพแวดล้อม:**
   เพิ่มตัวแปรสภาพแวดล้อมทั้งหมดผ่านแดชบอร์ดหรือ CLI ของ Vercel

3. **การตั้งค่า Stripe Webhook:**
   - ชี้ webhook ไปที่: `https://your-domain.vercel.app/api/stripe/webhook`

## API Endpoints

แอปพลิเคชันนี้ใช้เส้นทาง API ภายในเครื่องดังนี้:

- `POST /api/stripe/checkout` - สร้างเซสชันชำระเงินของ Stripe
- `POST /api/stripe/webhook` - จัดการเหตุการณ์ webhook ของ Stripe

## ข้อดีของ Local API Routes

1. **ปรับใช้ได้ง่ายกว่า** - ไม่จำเป็นต้องปรับใช้ edge functions แยกต่างหาก
2. **ตัวแปรสภาพแวดล้อม** - รองรับไฟล์ .env มาตรฐาน
3. **ดีบักได้ดีกว่า** - ดีบักได้ง่ายในเครื่อง
4. **ผสานกับเฟรมเวิร์ก** - ผสานกับ Next.js ได้ดีกว่า
5. **ไม่ผูกกับผู้ให้บริการ** - สามารถปรับใช้กับแพลตฟอร์มใดก็ได้ที่รองรับ Next.js

## แนวทางแก้ไขปัญหา

1. **ปัญหา Webhook:**
   - ตรวจสอบว่า `STRIPE_WEBHOOK_SECRET` ตรงกับ webhook endpoint ของ Stripe
   - ตรวจสอบบันทึก webhook ในแดชบอร์ด Stripe
   - ตรวจสอบว่า URL ของ webhook ถูกต้อง

2. **ตัวแปรสภาพแวดล้อม:**
   - ตรวจสอบว่าตั้งค่าตัวแปรที่จำเป็นครบถ้วน
   - ตรวจสอบข้อผิดพลาดในการพิมพ์ชื่อของตัวแปร
   - ตรวจสอบว่า Supabase service role key มีสิทธิ์ที่เหมาะสม

3. **ปัญหา CORS:**
   - เส้นทาง API มี CORS headers ที่เหมาะสม
   - ตรวจสอบว่าโดเมนของคุณอยู่ใน whitelist หากจำเป็น

## หมายเหตุด้านความปลอดภัย

- อย่าเปิดเผย `STRIPE_SECRET_KEY` หรือ `SUPABASE_SERVICE_ROLE_KEY` ให้กับฝั่งลูกค้า
- ใช้คำนำหน้า `NEXT_PUBLIC_` เฉพาะกับตัวแปรฝั่งลูกค้า
- หมุนเวียน webhook secrets เป็นประจำ
- เฝ้าระวังการส่งมอบ webhook ในแดชบอร์ด Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---