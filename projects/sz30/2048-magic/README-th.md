<div align="right">
  <details>
    <summary >🌐 ภาษาอื่นๆ</summary>
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

เวอร์ชันเสริมของเกม 2048 สุดคลาสสิก เพิ่มลูกเล่นใหม่ๆ ให้สนุกยิ่งขึ้น! โปรเจกต์เล็กๆ นี้ผมทำขึ้นในเวลาว่าง หวังว่าจะทำให้คุณเพลิดเพลิน!

## 🎯 แนะนำเกม

2048 เป็นเกมผสานเลขที่เรียบง่ายแต่น่าติดใจ ในตาราง 4x4 ปัดขึ้น ลง ซ้าย หรือขวาเพื่อรวมแผ่นตัวเลขที่เหมือนกัน เป้าหมายคืออะไร? ไปให้ถึง 2048 (แต่จริงๆ คุณสามารถเล่นต่อเพื่อทำคะแนนสูงสุดได้เรื่อยๆ)!

**วิธีเล่น:**
- ใช้ปุ่มลูกศรหรือปุ่ม WASD เพื่อเลื่อนแผ่นตัวเลข
- เมื่อแผ่นตัวเลขที่มีค่าเท่ากันชนกัน พวกมันจะถูกรวมเป็นแผ่นเดียว
- หลังจากแต่ละการเคลื่อนที่ จะมีเลข 2 หรือ 4 โผล่ขึ้นมาแบบสุ่มในช่องว่าง
- เกมจะจบเมื่อไม่สามารถขยับได้อีก

## ✨ ฟีเจอร์พิเศษ

### 1. ฟังก์ชันย้อนกลับ (Undo)
- ขยับผิดเหรอ? ไม่ต้องกังวล!
- แค่กดปุ่ม "ย้อนกลับ" เพื่อถอยกลับหนึ่งขั้น
- คุณสามารถย้อนกลับได้ไม่จำกัด จนถึงจุดเริ่มต้นเลยก็ได้
- ไม่ต้องกลัวนิ้วพลาดทำเกมพังอีกต่อไป!

### 2. โหมดโกงลับ (Secret Cheat Mode)
- ใส่ลำดับเวทย์มนตร์: ←←→→ →→←← (ซ้าย ซ้าย ขวา ขวา ขวา ขวา ซ้าย ซ้าย)
- ทุกแผ่นตัวเลขจะกลายเป็น 128 โดยเวทมนตร์!
- เป็นอีสเตอร์เอ้ก ไว้ขำๆ สนุกๆ
- เคล็ดลับ: โกงได้แต่ก็อย่าเยอะไปนะ! 😉

## 🎯 ตัวอย่างเกม

🎯 เล่นที่นี่: [http://2048.ct8.pl](http://2048.ct8.pl:9969/)
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

อยากทำให้เป็นสไตล์ของคุณเองหรือเปล่า? ปรับแต่ง `styles.css` เพื่อเปลี่ยนรูปลักษณ์ หรือเข้าไปที่ `script.js` เพื่อเปลี่ยนรูปแบบการเล่น โค้ดทุกส่วนมีคอมเมนต์อธิบายไว้เพื่อให้ง่ายต่อการปรับแต่ง!

## 📝 ใบอนุญาต

ใบอนุญาต GPL-2.0

## 🤝 การมีส่วนร่วม

ยังคงมีการอัปเดต! ยินดีต้อนรับปัญหาและ Pull Requests มาก ๆ — มาร่วมกันทำให้เกมนี้ยอดเยี่ยมยิ่งขึ้น!

## 🙏 คำขอบคุณ

ขอขอบคุณสปอนเซอร์ดังต่อไปนี้ที่สนับสนุนโครงการนี้:
- [Serv00](https://www.serv00.com/) ให้บริการเซิร์ฟเวอร์

---
_อัปเดตล่าสุด: มิ.ย. 2025_




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---