<div align="right">
  <details>
    <summary >🌐 ภาษาอื่น ๆ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=sz30&project=2048-magic&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>


[English](https://raw.githubusercontent.com/sz30/2048-magic/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048-magic/main/README.zh-TW.md)

# 🎮 2048++

เวอร์ชันปรับปรุงของเกม 2048 คลาสสิก ที่มาพร้อมกับฟีเจอร์ใหม่ ๆ เพิ่มความสนุกยิ่งขึ้น! นี่คือโปรเจกต์เล็ก ๆ ที่ผมทำในเวลาว่าง หวังว่าจะทำให้คุณเพลิดเพลิน!

## 🎯 แนะนำเกม

2048 เป็นเกมรวมเลขที่เรียบง่ายแต่ติดใจ บนกระดาน 4x4 ปัดขึ้น ลง ซ้าย หรือขวา เพื่อรวมช่องที่มีเลขเดียวกัน เป้าหมายคือ? ไปให้ถึง 2048 (แต่ถ้าจะไปต่อเพื่อทำคะแนนสูงกว่านั้นก็ได้!)

**วิธีเล่น:**
- ใช้ปุ่มลูกศร หรือ WASD เพื่อเลื่อนตัวเลข
- เมื่อเลขเดียวกันชนกัน จะถูกรวมเป็นหนึ่งช่อง
- หลังจากแต่ละการเคลื่อนที่ จะมีเลข 2 หรือ 4 ใหม่สุ่มโผล่ในช่องว่าง
- เกมจะจบเมื่อไม่สามารถเคลื่อนที่ได้อีก

## ✨ ฟีเจอร์พิเศษ

### 1. ฟังก์ชันย้อนกลับ (Undo)
- เดินผิดก้าว? ไม่ต้องกังวล!
- แค่กดปุ่ม "Undo" เพื่อย้อนกลับหนึ่งขั้นตอน
- สามารถย้อนกลับได้ไม่จำกัด จนถึงจุดเริ่มต้นของเกม
- ไม่ต้องกลัวนิ้วลั่นจะทำลายเกมอีกต่อไป!

### 2. โหมดโกงลับพิเศษ
- ป้อนรหัสวิเศษ: ←←→→ →→←← (ซ้าย ซ้าย ขวา ขวา ขวา ขวา ซ้าย ซ้าย)
- ทุกช่องจะกลายเป็น 128 อย่างน่าอัศจรรย์!
- เป็นอีสเตอร์เอ้กสำหรับความสนุกเท่านั้น
- เคล็ดลับ: โกงได้แต่อย่าทำบ่อยเกินไปนะ! 😉

## 🎯 ตัวอย่างเกม

🎯 เล่นที่นี่: [2048.765431.xyz](https://2048.765431.xyz/)
<img width="1279" alt="demo" src="https://github.com/user-attachments/assets/0df2c956-b6d9-4371-a916-f6ac3ae642be" />



## 📁 โครงสร้างโปรเจกต์
```
2048/
├── static/
│ ├── css/
│ │ └── styles.css # Game styles
│ └── js/
│ └── script.js # Frontend game logic
├── index.html # Main game page
└── 2048.py # Backend server
```
**คำอธิบายไฟล์:**
- `2048.py`: เซิร์ฟเวอร์แบ็กเอนด์ที่เขียนด้วย Flask จัดการตรรกะของเกมและคำขอ API
- `script.js`: ตรรกะเกมฝั่งหน้า รวมทั้งการเคลื่อนไหว แอนิเมชัน และฟีเจอร์พิเศษ
- `styles.css`: สไตล์ของเกม เพื่อให้ดูสวยงามและตอบสนองได้ดี
- `index.html`: หน้าเว็บหลักที่รวบรวมทุกอย่างเข้าด้วยกัน

## 🚀 เริ่มต้นใช้งาน

**วิธีที่ 1: ดาวน์โหลด Release**
1. ดาวน์โหลด Release ล่าสุด
2. ตรวจสอบให้แน่ใจว่าคุณติดตั้ง Python 3.x แล้ว
3. ติดตั้งไลบรารีที่ต้องใช้: `pip install flask`
4. รัน: `python 2048.py`
5. เปิดเบราว์เซอร์ของคุณและไปที่: [http://localhost:9969](http://localhost:9969)

**วิธีที่ 2: โคลนจาก GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```
## 🎨 การปรับแต่ง

อยากปรับให้เป็นสไตล์ของคุณเองใช่ไหม? แก้ไข `styles.css` เพื่อเปลี่ยนรูปลักษณ์ใหม่ หรือเข้าไปที่ `script.js` เพื่อเปลี่ยนรูปแบบการเล่น โค้ดทุกบรรทัดมีคำอธิบายอย่างดีเพื่อให้ง่ายต่อการปรับแต่ง!

## 📝 ใบอนุญาต

ใบอนุญาต GPL-2.0

## 🤝 การมีส่วนร่วม

ยังคงมีการอัปเดตอยู่! ยินดีต้อนรับทุก Issue และ Pull Request—มาร่วมกันทำให้เกมนี้ยอดเยี่ยมยิ่งขึ้นไปอีก!


## 🙏 คำขอบคุณ

ขอขอบคุณผู้สนับสนุนดังต่อไปนี้ที่ให้การสนับสนุนโปรเจกต์นี้:
- [IDC.REST](https://idc.rest/) ให้บริการเซิร์ฟเวอร์
- [Serv00](https://www.serv00.com/) ให้บริการเซิร์ฟเวอร์

---
_อัปเดตล่าสุด: มิ.ย. 2025_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---