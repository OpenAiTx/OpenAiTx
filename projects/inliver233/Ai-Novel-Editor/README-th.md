<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI Novel Editor

โปรแกรมแก้ไขนวนิยายด้วย AI ที่พัฒนาบนพื้นฐาน PyQt6 ให้บริการเครื่องมือช่วยเขียนแบบมืออาชีพ เช่น การเติมข้อความอัตโนมัติ การจัดการโปรเจกต์ และการจัดระเบียบแนวคิด

## การติดตั้ง

1. โคลนโปรเจกต์
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. สร้างสภาพแวดล้อมเสมือน
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
ใช้ uv
```bash
uv venv -p 3.11
```
3. การติดตั้งไลบรารีที่จำเป็น
```bash
pip install -r requirements.txt
```
การใช้ uv
```bash
uv sync
```

4. การรันโปรแกรม
```bash
python -m src
```

## ฟีเจอร์หลัก

### การจัดการโปรเจกต์
- โครงสร้างเอกสารแบบลำดับชั้น (ผลงาน > บท > ฉาก)
- การนำเข้าและส่งออกโปรเจกต์ (รองรับ TEXT, MARKDOWN, DOCX, PDF, HTML)
- การสำรองข้อมูลอัตโนมัติและการควบคุมเวอร์ชัน
- การจัดการหลายโปรเจกต์
### ฟังก์ชัน AI เติมข้อความอัตโนมัติ
- โหมดเติมข้อความ 3 แบบ: เติมอัตโนมัติ, เติมด้วยตนเอง (แนะนำ กดปุ่ม Tab ครั้งเดียวเพื่อเรียกใช้งาน กดอีกครั้งเพื่อยืนยัน), ปิดการเติมข้อความ
- โหมดบริบท 3 แบบ:
  - โหมดรวดเร็ว: บริบทแบบเบา ตอบสนองรวดเร็ว
  - โหมดสมดุล: บริบทระดับกลาง สมดุลคุณภาพและความเร็ว
  - โหมดทั่วทั้งโปรเจกต์: บริบทโครงการแบบสมบูรณ์ ได้ผลลัพธ์ดีที่สุด
- รองรับบริการ AI หลายประเภท: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq เป็นต้น

### การจัดการโครงร่าง
- โครงสร้างต้นไม้โครงร่างแบบเห็นภาพ
- ลากและวางเพื่อจัดลำดับและปรับระดับชั้น
- นำทางเอกสารได้อย่างรวดเร็ว
- วิเคราะห์โครงร่างและแนะนำการปรับปรุง

### การตั้งค่า API
- ศูนย์กลางการตั้งค่า AI แบบรวมศูนย์
- การตั้งค่าล่วงหน้าสำหรับผู้ให้บริการหลายราย
- ฟังก์ชันทดสอบการเชื่อมต่อ
- บันทึกและนำเข้า/ส่งออกการตั้งค่า
### การตั้งค่าการเติมข้อความอัจฉริยะ
- ปรับแต่งความล่าช้าในการทริกเกอร์ได้
- จำกัดความยาวของการเติมข้อความ
- กำหนดค่าความยาวของบริบท
- รองรับการตอบสนองแบบสตรีม

### การแก้ไขคำสั่ง (Prompt)
- มีเทมเพลตการเขียนหลายแบบในตัว
- กำหนดเทมเพลตคำสั่งเองได้
- จัดการหมวดหมู่เทมเพลต
- กำหนดค่าเทมเพลตตามโหมด

### ฟังก์ชันอินเทอร์เฟซ
- ธีมสว่างและมืด
- เลย์เอาต์สามคอลัมน์ (ต้นไม้โปรเจกต์, ตัวแก้ไข, แผงแนวคิด)
- แถบด้านข้างพับได้
- โหมดเขียนเต็มหน้าจอ
- โหมดโฟกัส (ประโยค, ย่อหน้า, เครื่องพิมพ์ดีด, โหมดเซน, โหมดดื่มด่ำ)

### ค้นหาและแทนที่
- ค้นหาข้อความทั้งโครงการ
- รองรับนิพจน์ทั่วไป (Regular Expression)
- ฟังก์ชันแทนที่แบบกลุ่ม
- ตัวเลือกการค้นหาขั้นสูง

### การจัดการแนวคิด
- ตรวจจับบทบาท สถานที่ และวัตถุโดยอัตโนมัติ
- การจัดการความสัมพันธ์ของแนวคิด
- ระบบแท็กและการจัดหมวดหมู่
- แทรกแนวคิดอย่างรวดเร็ว

## คีย์ลัด

- `Ctrl+N`: สร้างโครงการใหม่
- `Ctrl+O`: เปิดโครงการ
- `Ctrl+S`: บันทึกเอกสาร
- `F11`: โหมดเต็มหน้าจอ
- `Tab`: เรียกใช้การเติมคำโดย AI แบบแมนนวล (ในโหมดแมนนวล)
- `Ctrl+F`: ค้นหา
- `Ctrl+H`: ค้นหาและแทนที่
- `Ctrl+Shift+H`: ค้นหาและแทนที่ขั้นสูง
## ข้อกำหนดของระบบ

- Python 3.8+
- PyQt6
- ระบบปฏิบัติการ: Windows, macOS, Linux

## ผู้เขียน

**inliver**
- อีเมล: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---