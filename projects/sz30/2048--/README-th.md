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


[English](https://raw.githubusercontent.com/sz30/2048--/main/README.md) | [简体中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/sz30/2048--/main/README.zh-TW.md)

# 🎮 2048++

เวอร์ชันที่ได้รับการพัฒนาของเกม 2048 คลาสสิก มาพร้อมฟีเจอร์สนุกๆ เพิ่มเติม! นี่คือโปรเจกต์เล็กๆ ที่ผมทำขึ้นในเวลาว่าง—หวังว่าจะทำให้คุณสนุกนะ!

## 🎯 แนะนำเกม

2048 เป็นเกมรวมเลขที่เล่นง่ายแต่ติดใจ บนตาราง 4x4 เลื่อนขึ้น ลง ซ้าย หรือขวา เพื่อรวมตัวเลขที่เหมือนกัน เป้าหมาย? ไปให้ถึง 2048 (แต่ถ้าอยากได้คะแนนสูงกว่านั้นก็เล่นต่อได้!)

**วิธีเล่น:**
- ใช้ปุ่มลูกศรหรือปุ่ม WASD เพื่อเลื่อนแผ่นตัวเลข
- เมื่อแผ่นตัวเลขสองแผ่นที่มีตัวเลขเหมือนกันชนกัน จะถูกรวมเป็นแผ่นเดียว
- หลังจากแต่ละการเลื่อน จะมี 2 หรือ 4 ปรากฏขึ้นแบบสุ่มในช่องว่าง
- เกมจะจบเมื่อไม่สามารถขยับแผ่นตัวเลขได้อีกต่อไป

## ✨ ฟีเจอร์พิเศษ

### 1. ฟังก์ชันย้อนกลับ (Undo)
- ขยับผิด? ไม่ต้องกังวล!
- แค่กดปุ่ม "Undo" เพื่อย้อนกลับหนึ่งขั้นตอน
- คุณสามารถย้อนกลับได้ไม่จำกัดครั้ง ย้อนกลับไปถึงจุดเริ่มต้นเลยก็ได้
- ไม่ต้องกลัวว่าจะกดพลาดจนเกมพังอีกต่อไป!

### 2. โหมดโกงลับ (Cheat Mode)
- ใส่รหัสลับ: ←←→→ →→←← (ซ้าย ซ้าย ขวา ขวา ขวา ขวา ซ้าย ซ้าย)
- แผ่นตัวเลขทั้งหมดจะกลายเป็น 128 โดยอัตโนมัติ!
- เป็นอีสเตอร์เอ้กสำหรับความสนุก
- ทิป: โกงได้สนุก แต่ระวังอย่าใช้บ่อยเกินไปนะ! 😉

## 🎯 ตัวอย่างการเล่น

🎯 เล่นได้ที่นี่: [2048.765431.xyz](https://2048.765431.xyz/)
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
- `2048.py`: เซิร์ฟเวอร์ backend เขียนด้วย Flask จัดการตรรกะเกมและคำขอ API
- `script.js`: ตรรกะเกมฝั่ง frontend รวมถึงการเคลื่อนไหว แอนิเมชัน และฟีเจอร์พิเศษ
- `styles.css`: รูปแบบของเกม เพื่อให้ทุกอย่างดูสวยงามและตอบสนองได้ดี
- `index.html`: หน้าเว็บหลักที่รวมทุกอย่างเข้าด้วยกัน

## 🚀 เริ่มต้นใช้งาน

**วิธีที่ 1: ดาวน์โหลด Release**
1. ดาวน์โหลด release ล่าสุด
2. ตรวจสอบว่าคุณติดตั้ง Python 3.x แล้ว
3. ติดตั้ง dependencies: `pip install flask`
4. รัน: `python 2048.py`
5. เปิดเว็บเบราว์เซอร์และไปที่: [http://localhost:9969](http://localhost:9969)

**วิธีที่ 2: โคลนจาก GitHub**
```bash
git clone https://github.com/sz30/2048.git
cd 2048
pip install flask
python 2048.py
```

## 🎨 การปรับแต่ง

อยากปรับให้เป็นสไตล์ของคุณเองใช่ไหม? ปรับแต่ง `styles.css` เพื่อเปลี่ยนลุคใหม่ หรือเข้าไปที่ `script.js` เพื่อเปลี่ยนรูปแบบการเล่น โค้ดทั้งหมดมีคอมเมนต์ไว้อย่างดีเพื่อให้ง่ายต่อการแก้ไข!

## 📝 สัญญาอนุญาต

สัญญาอนุญาต GPL-2.0

## 🤝 การมีส่วนร่วม

กำลังอัปเดตอยู่! ยินดีต้อนรับ Issue และ Pull Request อย่างมาก—มาร่วมกันทำให้เกมนี้เจ๋งยิ่งขึ้นไปอีก!


## 🙏 คำขอบคุณ

ขอขอบคุณสปอนเซอร์ดังต่อไปนี้ที่สนับสนุนโปรเจ็กต์นี้:
- [IDC.REST](https://idc.rest/) ให้บริการเซิร์ฟเวอร์
- [Serv00](https://www.serv00.com/) ให้บริการเซิร์ฟเวอร์

---
_อัปเดตล่าสุด: มิ.ย. 2025_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---