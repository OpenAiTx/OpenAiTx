<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - เอนจินประมวลผล SQL ประสิทธิภาพสูงสำหรับไฟล์ CSV

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

โปรเซสเซอร์ SQL ที่มีน้ำหนักเบาและรวดเร็ว เขียนด้วยภาษา C ที่ช่วยให้สามารถรันคำสั่ง SQL กับไฟล์ CSV ได้โดยตรงโดยไม่ต้องใช้ฐานข้อมูล สำหรับเอกสารประกอบฉบับเต็ม ดูที่ไดเรกทอรี /doc

 ![cq ขณะทำงาน](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)


## เอกสารประกอบ

- เริ่มต้นใช้งาน: `doc/GettingStarted.md`
- การติดตั้ง: `doc/Installation.md`
- ส่วนติดต่อบรรทัดคำสั่ง: `doc/CLI.md`
- **TUI (ส่วนติดต่อผู้ใช้ในเทอร์มินัล)**: `doc/TUI.md`
- สถาปัตยกรรม: `doc/Architecture.md`
- การทดสอบ: `doc/Testing.md`
- แผนงาน: `doc/Roadmap.md`
- การมีส่วนร่วม: `doc/Contributing.md`

## เริ่มต้นอย่างรวดเร็ว

สร้างโปรแกรม: `make`

### บรรทัดคำสั่ง

เรียกใช้งานตัวอย่างคำสั่ง:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### ส่วนติดต่อผู้ใช้ในเทอร์มินัล

เปิดใช้งาน TUI แบบโต้ตอบ:
`./build/cqtui data/`

คุณสมบัติ:
- เรียกดูและเปิดไฟล์ CSV เป็นตาราง
- สั่งรัน SQL แบบโต้ตอบ
- รองรับหลายแท็บสำหรับหลายตาราง
- นำทางด้วยแป้นพิมพ์
- ไม่ต้องติดตั้งโปรแกรมเสริม

## ตัวอย่างไฟล์ SQL

ที่เก็บนี้มีตัวอย่างไฟล์ SQL อยู่ใน assets/ (example_between.sql, example_aggregation.sql ฯลฯ) ดูรายละเอียดที่ assets/

## ภาพรวมข้อมูล & คุณสมบัติ

- ดูโฟลเดอร์ /doc สำหรับรายละเอียดเกี่ยวกับประเภทข้อมูล รูปแบบวันที่ รูปแบบ CSV และอื่น ๆ

## ใบอนุญาต

ใบอนุญาต MIT ดูไฟล์ LICENSE สำหรับรายละเอียด


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---