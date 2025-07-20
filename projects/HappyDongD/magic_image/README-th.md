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

# เวทมนตร์ AI วาดภาพ

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

แอปพลิเคชัน AI วาดภาพที่พัฒนาบน Next.js โดยมีฟีเจอร์หลักดังนี้:
- 🎨 รองรับหลายโมเดล AI (Sora, DALL-E, GPT ฯลฯ) และสามารถเพิ่มโมเดลที่กำหนดเอง
- 🖼️ รองรับฟีเจอร์สร้างภาพจากข้อความและสร้างภาพจากภาพ พร้อมรองรับอ้างอิงหลายภาพและแก้ไขพื้นที่
- 🔐 ข้อมูลและคีย์ API ทั้งหมดถูกจัดเก็บในเครื่องเพื่อความเป็นส่วนตัวและความปลอดภัย
- 💻 รองรับทั้งเว็บและแอปเดสก์ท็อป ใช้งานได้ข้ามแพลตฟอร์ม

## ทดลองใช้งานออนไลน์

ลิงก์เข้าใช้งาน: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### ตัวอย่างภาพแอป

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="应用截图1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="应用截图2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="应用截图3" width="800" style="margin-bottom: 20px"/>
</div>

## คุณลักษณะเด่น

- 🎨 รองรับหลายโมเดล AI
  - โมเดล GPT Sora_Image
  - โมเดล GPT 4o_Image
  - โมเดล GPT Image 1
  - โมเดล DALL-E 3
  - 🆕 โมเดลที่กำหนดเอง (รองรับการเพิ่มโมเดลส่วนตัว)
- ✍️ ฟีเจอร์สร้างภาพจากข้อความ
  - รองรับการกำหนดคำสั่งเอง
  - เลือกอัตราส่วนภาพได้
  - รองรับขนาดภาพหลายรูปแบบ
- 🖼️ ฟีเจอร์สร้างภาพจากภาพ
  - รองรับการแก้ไขภาพ
  - รองรับการแก้ไขพื้นที่ด้วยมาสก์
  - รองรับการปรับคุณภาพภาพ
  - รองรับอ้างอิงหลายภาพ (อัปโหลดหลายรูปพร้อมกัน)
- 🔒 ความปลอดภัยของข้อมูล
  - รูปภาพและประวัติทั้งหมดจะถูกจัดเก็บไว้ในเบราว์เซอร์เครื่องเท่านั้น
  - รองรับการตั้งค่าที่อยู่ API Proxy
  - รองรับการตั้งค่า API Key
- 📱 การออกแบบ UI
  - อินเทอร์เฟซผู้ใช้ทันสมัย
  - ประสบการณ์การใช้งานลื่นไหล
  - รองรับการแสดงผลแบบ Markdown
  - รองรับการไฮไลท์โค้ด
- 🖥️ รองรับข้ามแพลตฟอร์ม
  - รองรับการแพ็กเป็นแอปเดสก์ท็อป (Windows, macOS, Linux)
  - รองรับการใช้งานแบบออฟไลน์ (ต้องตั้งค่า API)

## เทคโนโลยีที่ใช้

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (สำหรับแพ็กแอปเดสก์ท็อป)

## การพัฒนาในเครื่อง

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
    หมายเหตุ: อักขระพิเศษใน URL ต้องถูกเข้ารหัส URL

2. เลือกโหมดการสร้าง
   - สร้างภาพจากข้อความ: สร้างภาพโดยใช้คำบรรยาย
   - สร้างภาพจากภาพ: อัปโหลดภาพเพื่อแก้ไข

3. ตั้งค่าพารามิเตอร์การสร้าง
   - เลือกโมเดล AI (โมเดลในตัวหรือโมเดลกำหนดเอง)
   - ตั้งค่าสัดส่วนของภาพ
   - ปรับคุณภาพของภาพ (ในโหมดสร้างภาพจากภาพ)

4. การจัดการโมเดลกำหนดเอง
   - คลิกไอคอนตั้งค่าข้างกล่องเลือกโมเดล
   - เพิ่มโมเดลใหม่: กรอกชื่อโมเดล, ค่าโมเดล และเลือกประเภทโมเดล
   - แก้ไขโมเดล: คลิกปุ่มแก้ไขของโมเดลที่มีอยู่
   - ลบโมเดล: คลิกปุ่มลบของโมเดลที่มีอยู่
   - เลือกโมเดล: คลิกปุ่มบวกของโมเดลเพื่อเลือกใช้งานทันที

5. คำอธิบายประเภทโมเดล
   - รูปแบบ DALL-E: ใช้อินเทอร์เฟซสร้างภาพ (/v1/images/generations)
   - รูปแบบ OpenAI: ใช้อินเทอร์เฟซแชท (/v1/chat/completions)

6. สร้างภาพ
   - ป้อนคำแนะนำ
   - คลิกปุ่ม "สร้างภาพ"
   - รอให้สร้างเสร็จสมบูรณ์

7. การจัดการภาพ
   - ดูประวัติการสร้าง
   - ดาวน์โหลดภาพที่สร้าง
   - แก้ไขภาพที่มีอยู่

## ข้อควรระวัง

- ภาพที่สร้างและประวัติทั้งหมดจะถูกเก็บไว้ในเบราว์เซอร์ของคุณเท่านั้น
- การใช้โหมดส่วนตัวหรือเปลี่ยนอุปกรณ์จะทำให้ข้อมูลสูญหาย
- กรุณาดาวน์โหลดและสำรองรูปภาพที่สำคัญทันที
- การตั้งค่า API จะถูกจัดเก็บไว้อย่างปลอดภัยในเบราว์เซอร์ของคุณและจะไม่ถูกอัปโหลดไปยังเซิร์ฟเวอร์
- เว็บไซต์ HTTPS ที่โหลดทรัพยากร HTTP จะถูกเบราว์เซอร์บล็อก แอปจะเปลี่ยน HTTP เป็น HTTPS ให้อัตโนมัติ

## แนวทางการมีส่วนร่วม

ยินดีต้อนรับการส่ง Issue และ Pull Request เพื่อช่วยปรับปรุงโครงการนี้

## สัญญาอนุญาต

โครงการนี้ใช้สัญญาอนุญาต [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0)

ตามสัญญาอนุญาตนี้ คุณสามารถ:
- ✅ ใช้งานเชิงพาณิชย์: สามารถใช้ซอฟต์แวร์ในเชิงพาณิชย์
- ✅ แก้ไข: สามารถแก้ไขซอร์สโค้ดของซอฟต์แวร์
- ✅ แจกจ่าย: สามารถแจกจ่ายซอฟต์แวร์
- ✅ ใช้ส่วนตัว: สามารถใช้ซอฟต์แวร์ส่วนตัว
- ✅ การให้สิทธิ์สิทธิบัตร: สัญญาอนุญาตนี้ยังให้สิทธิ์สิทธิบัตรด้วย

แต่ต้องปฏิบัติตามเงื่อนไขดังต่อไปนี้:
- 📝 ใบอนุญาตและประกาศลิขสิทธิ์: คุณต้องแนบใบอนุญาตและประกาศลิขสิทธิ์ต้นฉบับ
- 📝 ประกาศการเปลี่ยนแปลง: คุณต้องประกาศการเปลี่ยนแปลงสำคัญที่ทำกับโค้ดต้นฉบับ
- 📝 ประกาศเครื่องหมายการค้า: ห้ามใช้เครื่องหมายการค้าของผู้ให้ผลงาน

---

## เลี้ยงกาแฟฉันสักแก้ว

หากโครงการนี้เป็นประโยชน์กับคุณ ยินดีรับกาแฟสักแก้ว ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="微信收款码" width="300" />
  <p>เลี้ยงกาแฟฉันสักแก้ว</p>
</div>

## ช่องทางติดต่อ

หากคุณมีคำถามหรือข้อเสนอแนะ สามารถติดต่อฉันผ่าน WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="微信联系方式" width="300" />
  <p>สแกน QR โค้ดเพื่อเพิ่ม WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---