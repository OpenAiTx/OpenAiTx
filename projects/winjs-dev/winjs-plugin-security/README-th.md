
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=winjs-dev&project=winjs-plugin-security&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# winjs-plugin-security

ปลั๊กอินที่ช่วยเพิ่มความปลอดภัยให้กับโปรเจกต์ WinJS โดยเน้นการสร้างคุณสมบัติ SRI (Subresource Integrity)

<p>
  <a href="https://npmjs.com/package/@winner-fed/plugin-security">
   <img src="https://img.shields.io/npm/v/@winner-fed/plugin-security?style=flat-square&colorA=564341&colorB=EDED91" alt="npm version" />
  </a>
  <img src="https://img.shields.io/badge/License-MIT-blue.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="license" />
  <a href="https://npmcharts.com/compare/@winner-fed/plugin-security?minimal=true"><img src="https://img.shields.io/npm/dm/@winner-fed/plugin-security.svg?style=flat-square&colorA=564341&colorB=EDED91" alt="downloads" /></a>
</p>

## คุณสมบัติเด่น

- สร้างคุณสมบัติ SRI ให้กับแท็ก `<script>` และ `<link>` ในไฟล์ HTML โดยอัตโนมัติ
- รองรับอัลกอริทึมแฮช SHA-256, SHA-384, SHA-512 (สามารถกำหนดเองได้)
- เพิ่มแอตทริบิวต์ `crossorigin="anonymous"` อัตโนมัติเพื่อให้ SRI ทำงานได้ถูกต้อง
- ทำงานเฉพาะในโหมด production เท่านั้น โหมดพัฒนา (development) จะถูกข้ามไปโดยอัตโนมัติ

## การติดตั้ง

```bash
pnpm add @winner-fed/plugin-security
```
## วิธีการใช้งาน

เพิ่มการตั้งค่าปลั๊กอินในไฟล์กำหนดค่า `.winrc.ts` ของคุณ:


```typescript
import { defineConfig } from '@winner-fed/winjs';

export default defineConfig({
  plugins: ['@winner-fed/plugin-security'],
  security: {
    sri: true // 启用 SRI 功能
  },
});
```
## ตัวเลือกการกำหนดค่า

### `sri`

- **ประเภท**: `boolean | { algorithm: 'sha256' | 'sha384' | 'sha512' }`
- **ค่าเริ่มต้น**: ต้องตั้งค่าด้วยตนเอง
- **คำอธิบาย**: กำหนดว่าจะเปิดใช้ฟีเจอร์ SRI (Subresource Integrity) หรือไม่ และสามารถกำหนดอัลกอริทึมแฮชได้

เมื่อกำหนดเป็น `true` หรือ `{}` ปลั๊กอินจะ:

1. สแกนไฟล์ HTML ที่ถูกสร้างขึ้นหลังการ build
2. เพิ่มแอตทริบิวต์ `integrity` ให้กับแท็ก `<script>` ที่มีแอตทริบิวต์ `src` ทุกแท็ก
3. เพิ่มแอตทริบิวต์ `integrity` ให้กับแท็ก `<link>` ที่มีแอตทริบิวต์ `href` ทุกแท็ก
4. เพิ่มแอตทริบิวต์ `crossorigin="anonymous"` โดยอัตโนมัติ (ถ้ายังไม่มี)

คุณยังสามารถกำหนดอัลกอริทึมแฮชด้วยรูปแบบอ็อบเจกต์ได้เช่นกัน:


```typescript
security: {
  sri: {
    algorithm: 'sha512' // 可选 'sha256' | 'sha384' | 'sha512'，默认 'sha512'
  }
}
```

## 示例

### 输入 HTML

```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css">
</head>
<body>
  <script src="/assets/app.js"></script>
</body>
</html>
```
### เอาต์พุต HTML (หลังจากเปิดใช้งาน SRI)


```html
<!DOCTYPE html>
<html>
<head>
  <link rel="stylesheet" href="/assets/app.css" integrity="sha512-ABC123..." crossorigin="anonymous">
</head>
<body>
  <script src="/assets/app.js" integrity="sha512-XYZ789..." crossorigin="anonymous"></script>
</body>
</html>
```
## คำแนะนำด้านความปลอดภัย

SRI (Subresource Integrity) เป็นคุณสมบัติด้านความปลอดภัยที่อนุญาตให้เบราว์เซอร์ตรวจสอบความถูกต้องของทรัพยากรที่ได้รับมา (เช่น ทรัพยากรจาก CDN) ว่าไม่ได้ถูกแก้ไขโดยประสงค์ร้าย เมื่อเบราว์เซอร์โหลดทรัพยากร จะคำนวณค่าแฮชของทรัพยากรและเปรียบเทียบกับค่าแฮชที่ระบุในแอตทริบิวต์ `integrity` หากค่าแฮชไม่ตรงกัน เบราว์เซอร์จะปฏิเสธการโหลดทรัพยากรนั้น

สำหรับแท็ก `<script>` ผลลัพธ์คือจะปฏิเสธการรันโค้ดภายในนั้น สำหรับลิงก์ CSS ผลลัพธ์คือจะไม่โหลดสไตล์ภายในนั้น

หากต้องการข้อมูลเพิ่มเติมเกี่ยวกับ SRI สามารถดูได้ที่ [Subresource Integrity - MDN](https://developer.mozilla.org/zh-CN/docs/Web/Security/Subresource_Integrity)

## ข้อควรระวัง

1. ปลั๊กอินนี้จะมีผลเฉพาะขณะ build ผลิตเท่านั้น ในสภาพแวดล้อมการพัฒนาจะถูกข้ามโดยอัตโนมัติ
2. ต้องแน่ใจว่าไฟล์ทรัพยากรสามารถเข้าถึงได้ในไดเรกทอรีเอาต์พุตของการ build
3. แอตทริบิวต์ `integrity` ต้องใช้ร่วมกับ `crossorigin` จึงจะทำงานได้อย่างถูกต้อง

## ใบอนุญาต

MIT




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---