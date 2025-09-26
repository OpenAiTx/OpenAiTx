
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![รองรับ Python](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

เกมจำลองปัญญาประดิษฐ์บนเทอร์มินัล

## วิธีการใช้งาน

คุณสามารถดาวน์โหลดแอปพลิเคชันที่สามารถรันได้จาก [release ล่าสุด](https://github.com/luyiourwong/Terminara/releases/latest)

ไฟล์บีบอัดแบบเต็มประกอบด้วยไฟล์ที่สามารถรันได้และไฟล์ตั้งค่าโลกเริ่มต้น คุณสามารถดาวน์โหลดเฉพาะไฟล์ที่สามารถรันได้หากคุณกำลังอัปเดตเกมเป็นเวอร์ชันล่าสุด

| ระบบปฏิบัติการ | เวอร์ชัน                                   |
|-----------------|---------------------------------------------|
| Windows         | Windows 10, Windows 11                      |
| Linux           | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS           | macOS 13, macOS 14, macOS 15, macOS 26      |

<details>
<summary><strong>การรันแบบแมนนวล</strong></summary>

### การติดตั้ง

1.  **โคลน repository:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```
2.  **สร้างสภาพแวดล้อมเสมือน:**

    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    บน Windows ให้ใช้ `.venv\Scripts\activate`

3.  **ติดตั้ง dependencies:**
    ```bash
    pip install -e .
    ```

### เริ่มต้นวิธีที่ 1: ใช้คำสั่งที่ติดตั้งแล้ว (แนะนำ)
หลังจากติดตั้งเสร็จ ให้รันเกมด้วย:
```bash
terminara
```

### วิธีเริ่มต้นวิธีที่ 2: การดำเนินการโดยตรง
วิธีข้ามแพลตฟอร์ม
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
บน Windows ให้ใช้ `terminara\main.py`

สำหรับข้อมูลเพิ่มเติม ดูที่ [Contribute & Develop Guide](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)
</details>

## การตั้งค่า AI

หลังจากเริ่มแอปพลิเคชันแล้ว คุณจะต้องกำหนดค่าการตั้งค่า AI จากเมนูหลัก

![การตั้งค่า AI](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

คุณจำเป็นต้องกรอกข้อมูลในช่องต่อไปนี้: (OpenAI compatibility API)
- **Host**: จุดเชื่อมต่อ API หากเว้นว่างไว้จะใช้จุดเชื่อมต่อ OpenAI เริ่มต้น
- **API Key**: รหัส API สำหรับบริการ AI ของคุณ
- **Model**: รุ่นที่คุณต้องการใช้

คลิก "Apply" เพื่อบันทึกการตั้งค่า

### ตัวอย่าง

#### 1. [OpenAI](https://platform.openai.com/) (ค่าเริ่มต้น)
- **Host**: (เว้นว่างไว้)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## การตั้งค่าโลก

### การจัดเก็บค่าคอนฟิก
การตั้งค่าโลกจะถูกจัดเก็บไว้ในไดเรกทอรี `terminara/data/worlds` (ในรุ่นเต็ม)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### การสร้างโลกใหม่
มีตัวอย่างโลก [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json) คุณสามารถทำตาม [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) เพื่อสร้างโลกใหม่

## ลิงก์

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Repository](https://github.com/luyiourwong/Terminara)
- [คู่มือการมีส่วนร่วม & พัฒนา](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## ใบอนุญาต

โปรเจกต์นี้ใช้ใบอนุญาต [MIT License](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---