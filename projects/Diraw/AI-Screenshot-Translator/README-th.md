# AI เครื่องมือแปลข้อความจากภาพหน้าจอ (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# แนะนำ

เครื่องมือนี้ช่วยให้คุณสามารถ**จับภาพหน้าจออย่างง่ายดาย** แล้วส่งภาพไปยังโมเดล AI เพื่อทำการรู้จำข้อความและแปลภาษา จากนั้นจะแสดงผลลัพธ์การแปลในรูปแบบ HTML ที่สามารถโต้ตอบได้ในหน้าต่างแยกต่างหาก

เครื่องมือนี้รองรับ**การตั้งค่าปุ่มลัดเพื่อเรียกใช้งาน การจัดการผลลัพธ์แบบหลายหน้าต่าง และการทำงานใน System Tray** ซึ่งช่วยเพิ่มประสิทธิภาพในการแปลภาษาในชีวิตประจำวันและการเรียนรู้ได้อย่างมาก

**จุดเด่นของเครื่องมือ**: 1. แปลภาพหน้าจอ เรียกใช้งานด้วยปุ่มลัด; 2. การจับภาพแปลแบบแปะชิ้นและลากย้าย/ปรับขนาดได้อย่างอิสระ สามารถสร้างกลุ่มแปลหลายกลุ่ม; 3. สูตรคณิตศาสตร์สามารถสลับเป็นข้อความต้นฉบับเพื่อคัดลอกได้สะดวก; 4. ตั้งค่า API เองได้

**ปัญหาที่ต้องการแก้ไข**: 1. ซอฟต์แวร์แปลเอกสารทั้งฉบับในท้องตลาดปัจจุบันมีความซับซ้อนเกินไป; 2. หากเลือกคัดลอกข้อความจาก PDF ไปแปล บางครั้งสูตรคณิตศาสตร์จะไม่ตรงหรือคัดลอกไม่ได้; 3. PDF ที่เป็นภาพสแกนไม่สามารถคัดลอกข้อความได้

# สาธิต

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# ตัวอย่างหน้าต่าง

หน้าต่างแปลภาษา:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

หน้าต่างตั้งค่า:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

สำหรับรายละเอียดเพิ่มเติมเกี่ยวกับตัวเลือกการตั้งค่าสามารถดูได้ในซอฟต์แวร์หรือที่หน้าเว็บ [提示](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# การติดตั้ง

คุณสามารถเลือกดาวน์โหลดซอร์สโค้ดเพื่อรันเอง หรือไปที่หน้า [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) เพื่อดาวน์โหลดไฟล์โปรแกรมสำเร็จรูป

### 1. โคลนโปรเจกต์

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. สร้าง Virtual Environment และรันโปรแกรม

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# แผนการอัปเดต

- ~~เพิ่มหน้าต่าง GUI สำหรับตั้งค่า API และปรับปรุงกระบวนการตั้งค่าไฟล์ yaml ให้โปรแกรมสร้างอัตโนมัติ (เสร็จใน v0.3.0)~~
- เพิ่มระบบจัดเก็บภาพและสูตรคณิตศาสตร์ เพื่อให้เรียกใช้งานในอนาคตได้สะดวก (คาดว่าเสร็จใน v0.4)
- (ฟีเจอร์อื่น ๆ สามารถเสนอผ่าน issue หรือร่วมพัฒนา PR ได้)

# อื่น ๆ

- ไอคอนของโปรแกรมมาจาก [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- ขอบคุณ Gemini 2.5 Flash และ DeepSeek-V3-0324 ที่ช่วยหาข้อผิดพลาด (bug)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---