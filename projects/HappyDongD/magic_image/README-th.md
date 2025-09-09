
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# วาดภาพด้วยเวทมนตร์ AI

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![ใบอนุญาต](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

แอปพลิเคชันวาดภาพ AI ที่พัฒนาด้วย Next.js มีฟีเจอร์หลักดังนี้:
- 🎨 รองรับโมเดล AI หลายประเภท (Sora, DALL-E, GPT, GEMINI ฯลฯ) และสามารถเพิ่มโมเดลที่กำหนดเอง
- 🖼️ มีฟังก์ชันสร้างภาพจากข้อความและภาพต่อภาพ รองรับการอ้างอิงหลายภาพและการแก้ไขแบบแบ่งพื้นที่
- 🔐 เก็บข้อมูลและคีย์ API ทั้งหมดไว้ในเครื่อง เพื่อความปลอดภัยและความเป็นส่วนตัว
- 💻 รองรับทั้งเวอร์ชันเว็บและแพ็กเกจแอปเดสก์ท็อป ใช้งานได้ข้ามแพลตฟอร์ม

## ทดลองใช้งานออนไลน์

ที่อยู่สำหรับเข้าใช้งาน: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### ภาพตัวอย่างแอปพลิเคชัน

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="ภาพตัวอย่างแอปพลิเคชัน 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="ภาพตัวอย่างแอปพลิเคชัน 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="ภาพตัวอย่างแอปพลิเคชัน 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="ภาพตัวอย่างแอปพลิเคชัน 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="ภาพตัวอย่างแอปพลิเคชัน 3" width="800" style="margin-bottom: 20px"/>
</div>

## คุณสมบัติและจุดเด่น

- 🎨 รองรับโมเดล AI หลากหลาย
  - โมเดล GPT Sora_Image
  - โมเดล GPT 4o_Image
  - โมเดล GPT Image 1
  - โมเดล DALL-E 3
  - โมเดล GEMINI
  - 🆕 โมเดลที่กำหนดเอง (รองรับการเพิ่มโมเดลส่วนตัว)
- 🔄 สลับโมเดลได้หลายแบบ
  - รองรับการสลับระหว่างโมเดลต่าง ๆ ได้อย่างรวดเร็ว
  - แต่ละโมเดลมีตัวเลือกการตั้งค่าเฉพาะตัว
- ✍️ ฟีเจอร์สร้างภาพจากข้อความ
  - รองรับการกำหนดคำสั่งเอง
  - เลือกอัตราส่วนภาพได้
  - รองรับขนาดภาพหลากหลาย
- 🖼️ ฟีเจอร์ภาพต่อภาพ
  - รองรับการแก้ไขภาพ
  - รองรับการแก้ไขแบบมาสก์พื้นที่
  - รองรับการปรับคุณภาพภาพ
  - รองรับการอ้างอิงหลายภาพ (อัพโหลดหลายภาพพร้อมกัน)
- 🔒 ความปลอดภัยของข้อมูล
  - รูปภาพที่สร้างและประวัติทั้งหมดจะถูกเก็บไว้เฉพาะในเบราว์เซอร์ของเครื่องคุณ
  - รองรับการกำหนดค่า API proxy แบบกำหนดเอง
  - รองรับการตั้งค่า API Key
- 📱 การออกแบบ UI
  - ส่วนติดต่อผู้ใช้สมัยใหม่
  - ประสบการณ์การใช้งานที่ลื่นไหล
  - แสดงผลในรูปแบบ Markdown
  - รองรับการไฮไลท์โค้ด
- 🖥️ รองรับหลายแพลตฟอร์ม
  - รองรับการแพ็คเกจเป็นแอปเดสก์ท็อป (Windows, macOS, Linux)
  - รองรับการใช้งานแบบออฟไลน์ (ต้องตั้งค่า API)
  
## เทคโนโลยีที่ใช้

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (แพ็คเกจแอปเดสก์ท็อป)

## การพัฒนาบนเครื่อง

1. โคลนโปรเจกต์
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. ติดตั้งไลบรารีที่จำเป็น

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. เริ่มต้นเซิร์ฟเวอร์สำหรับการพัฒนา

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. เข้าถึง [http://localhost:3000](http://localhost:3000)

## การแพ็กเกจแอปพลิเคชันเดสก์ท็อป

โปรเจกต์นี้ใช้ Tauri สำหรับการแพ็กเกจแอปพลิเคชันเดสก์ท็อป รองรับระบบ Windows, macOS และ Linux

### การเตรียมสภาพแวดล้อม

ก่อนแพ็กเกจแอปพลิเคชันเดสก์ท็อป ต้องติดตั้งไลบรารีต่อไปนี้:

1. **ติดตั้ง Rust**:
   - เข้าไปที่ [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - ทำตามคำแนะนำเพื่อติดตั้ง Rust และ Cargo

2. **ไลบรารีของระบบ**:
   - **Windows**: ติดตั้ง [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: ติดตั้ง Xcode Command Line Tools (`xcode-select --install`)
   - **Linux**: ติดตั้งไลบรารีที่เกี่ยวข้อง ดูรายละเอียดที่ [Tauri Documentation](https://tauri.app/v1/guides/getting-started/prerequisites)

### โหมดพัฒนา


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### สร้างแอปพลิเคชันเดสก์ท็อป


```bash
# 构建桌面应用安装包
npm run desktop
```
หลังจากสร้างเสร็จแล้ว คุณจะพบไฟล์ติดตั้งสำหรับระบบที่สอดคล้องกันในไดเรกทอรี `src-tauri/target/release/bundle`

## การปรับใช้บน Vercel

1. Fork โปรเจคนี้ไปยังบัญชี GitHub ของคุณ

2. สร้างโปรเจคใหม่บน [Vercel](https://vercel.com)

3. นำเข้า repository GitHub ของคุณ

4. คลิกเพื่อปรับใช้

## คำแนะนำการใช้งาน

1. ใช้งานครั้งแรกต้องตั้งค่า API Key
   - คลิกที่ "การตั้งค่าคีย์" มุมขวาบน
   - กรอก API Key และที่อยู่ฐาน
   - คลิกบันทึก
   - หรือสามารถตั้งค่าอย่างรวดเร็วผ่านพารามิเตอร์ URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     หมายเหตุ: อักขระพิเศษใน URL ต้องเข้ารหัส URL

2. เลือกโหมดการสร้าง
   - สร้างภาพจากข้อความ: สร้างภาพจากคำอธิบาย
   - สร้างภาพจากภาพ: อัปโหลดภาพเพื่อแก้ไข

3. ตั้งค่าพารามิเตอร์การสร้าง
   - เลือกรุ่น AI (รุ่นในระบบหรือรุ่นที่กำหนดเอง)
   - ตั้งค่าสัดส่วนภาพ
   - ปรับคุณภาพภาพ (โหมดสร้างภาพจากภาพ)

4. การจัดการรุ่นที่กำหนดเอง
   - คลิกไอคอนการตั้งค่าข้างกล่องเลือกรุ่น
   - เพิ่มรุ่นใหม่: กรอกชื่อรุ่น ค่า และเลือกประเภทของรุ่น
   - แก้ไขรุ่น: คลิกปุ่มแก้ไขของรุ่นที่มีอยู่
   - ลบรุ่น: คลิกปุ่มลบของรุ่นที่มีอยู่
   - เลือกรุ่น: คลิกปุ่มเครื่องหมายบวกของรุ่นเพื่อเลือกใช้ทันที

5. คำอธิบายประเภทของรุ่น
   - รูปแบบ DALL-E: ใช้อินเทอร์เฟซสร้างภาพ (/v1/images/generations)
   - รูปแบบ OpenAI: ใช้อินเทอร์เฟซแชท (/v1/chat/completions)

6. สร้างภาพ
   - กรอกคำแนะนำ
   - คลิกปุ่ม "สร้างภาพ"
   - รอให้สร้างเสร็จสิ้น

7. การจัดการภาพ
   - ดูประวัติย้อนหลัง
   - ดาวน์โหลดภาพที่สร้างขึ้น
   - แก้ไขภาพที่มีอยู่

## ข้อควรระวัง

- ภาพและประวัติที่สร้างขึ้นทั้งหมดจะถูกเก็บไว้ในเบราว์เซอร์ของคุณเท่านั้น
- การใช้โหมดส่วนตัวหรือเปลี่ยนอุปกรณ์อาจทำให้ข้อมูลสูญหาย
- โปรดดาวน์โหลดและสำรองภาพสำคัญไว้ทันเวลา
- การตั้งค่า API จะถูกจัดเก็บอย่างปลอดภัยในเบราว์เซอร์ของคุณ และจะไม่ถูกอัปโหลดไปยังเซิร์ฟเวอร์
- เว็บไซต์ HTTPS ที่โหลดทรัพยากร HTTP จะถูกเบราว์เซอร์บล็อก แอปจะเปลี่ยนอินเทอร์เฟซ HTTP เป็น HTTPS โดยอัตโนมัติ

## แนวทางการมีส่วนร่วม

ขอเชิญส่ง Issue และ Pull Request เพื่อช่วยปรับปรุงโปรเจกต์

## ใบอนุญาต

โปรเจกต์นี้ใช้ใบอนุญาต [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0)

ตามใบอนุญาตนี้ คุณสามารถ:
- ✅ ใช้เชิงพาณิชย์: สามารถใช้ซอฟต์แวร์เพื่อการค้า
- ✅ แก้ไข: สามารถแก้ไขซอร์สโค้ดซอฟต์แวร์
- ✅ แจกจ่าย: สามารถแจกจ่ายซอฟต์แวร์
- ✅ ใช้ส่วนตัว: สามารถใช้ซอฟต์แวร์ส่วนตัว
- ✅ อนุญาตสิทธิบัตร: ใบอนุญาตนี้ยังให้สิทธิบัตร

แต่คุณต้องปฏิบัติตามเงื่อนไขต่อไปนี้:
- 📝 ใบอนุญาตและประกาศลิขสิทธิ์: ต้องแนบใบอนุญาตและประกาศลิขสิทธิ์ต้นฉบับ
- 📝 ประกาศการเปลี่ยนแปลง: ต้องประกาศการเปลี่ยนแปลงที่สำคัญต่อโค้ดต้นฉบับ
- 📝 ประกาศเครื่องหมายการค้า: ห้ามใช้เครื่องหมายการค้าของผู้ร่วมพัฒนา

---

## ขอชวนเลี้ยงกาแฟ

หากโปรเจกต์นี้เป็นประโยชน์กับคุณ ขอเชิญเลี้ยงกาแฟ ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="รหัสรับชำระเงิน WeChat" width="300" />
  <p>ขอชวนเลี้ยงกาแฟ</p>
</div>

## ช่องทางการติดต่อ

หากคุณมีคำถามหรือข้อเสนอแนะใด ๆ สามารถติดต่อฉันผ่าน WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="ช่องทางติดต่อ WeChat" width="300" />
  <p>สแกนคิวอาร์โค้ดเพื่อเพิ่ม WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---