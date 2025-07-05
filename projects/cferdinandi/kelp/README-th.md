# Kelp

ไลบรารี UI สำหรับผู้ที่รัก HTML ขับเคลื่อนด้วย CSS สมัยใหม่และ Web Components

**[อ่านเอกสาร &rarr;](https://kelpui.com)**

_**หมายเหตุ:** Kelp กำลังอยู่ระหว่างการพัฒนาในช่วงอัลฟา คุณสามารถนำไปใช้ ทดลอง และรายงานบั๊กได้ตามต้องการ แต่โปรดเข้าใจว่าสิ่งต่าง ๆ อาจมีการเปลี่ยนแปลงได้ตลอดเวลา_



## เริ่มต้นอย่างรวดเร็ว

Kelp ใช้งานได้โดยไม่ต้องมีขั้นตอนการ build

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) คือวิธีที่เร็วและง่ายที่สุดในการเริ่มต้น แต่หากคุณต้องการ คุณสามารถ [ดาวน์โหลดไฟล์จาก GitHub](https://github.com/cferdinandi/kelp) ได้เช่นกัน

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp ใช้ semantic versioning คุณสามารถเลือกเวอร์ชันหลัก เวอร์ชันรอง หรือเวอร์ชันแพตช์จาก CDN ได้ด้วยไวยากรณ์ `@1.2.3` คุณสามารถดูเวอร์ชันทั้งหมดที่มีได้ที่ [releases](https://github.com/cferdinandi/kelp/tags)



## ตัวอย่างสาธิต

ไฟล์ `index.html` ที่มีมาให้ เป็นตัวอย่างรวมทุกฟีเจอร์และคอมโพเนนต์ของ Kelp ในไฟล์เดียว

ในขณะที่ยังอยู่ในช่วงเบต้า Kelp จะไม่มีขั้นตอนคอมไพล์ Web component ใช้ ES imports และต้องการเซิร์ฟเวอร์โลคัลในการรัน

ใช้เซิร์ฟเวอร์ที่คุณถนัด หรือใช้ `http-server` ที่ให้มาโดยรัน `npm run dev`

```bash
npm install
npm run dev
```

เมื่อ Kelp ใกล้ถึงเวอร์ชัน v1 จะมีขั้นตอนคอมไพล์เพื่อไม่ต้องทำแบบนี้อีกต่อไป



## การทดสอบ

Kelp ใช้...

- [Playwright](https://playwright.dev) สำหรับการทดสอบ
- [Biome](https://biomejs.dev) สำหรับ linting และ formatting
- กระบวนการ continuous integration ในการ deploy และ PR

```bash
# รันทดสอบ
npm run test

# รัน linter
npm run lint
```



## ใบอนุญาต

ใช้ฟรีภายใต้ [Kelp Commons License](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md) นอกจากนี้ยังมี [ตัวเลือกใบอนุญาตเชิงพาณิชย์](/license/) ให้เลือกด้วย

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---