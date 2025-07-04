![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

เฟรมเวิร์กเอเจนต์ AI สำหรับ Python ที่มีความเร็วสูงและทำงานได้ด้วยตัวเอง โดยใช้ OpenAI Python SDK เพื่อแปลคำสั่งภาษาธรรมชาติ สร้างและรันโค้ดแบบไดนามิก รวมถึงจัดการสภาพแวดล้อมขณะรันงานอย่างไร้อุปสรรค ฟีเจอร์หลักประกอบด้วยการติดตั้งไลบรารีอัตโนมัติ การตั้งค่าสภาพแวดล้อมที่ปลอดภัย การจัดการล็อกแบบมีโครงสร้าง และอินเทอร์เฟซปลั๊กอินที่เรียบง่ายสำหรับฝังเครื่องมือ Python อันทรงพลัง—ทั้งหมดนี้อยู่ภายใต้สัญญาอนุญาตแบบ Apache 2.0

## ⭐ Star History

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 การตั้งค่าสภาพแวดล้อม

### สภาพแวดล้อมเสมือน Python
ก่อนตั้งค่าโปรเจ็กต์ แนะนำให้สร้างสภาพแวดล้อมเสมือน ทำตามขั้นตอนดังนี้:

ศึกษาข้อมูลเกี่ยวกับสภาพแวดล้อมเสมือน: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

สร้างและเปิดใช้งานสภาพแวดล้อมเสมือน:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### การตั้งค่าโปรเจ็กต์
โปรเจ็กต์นี้ต้องใช้ OpenAI API key ในการทำงาน ให้สร้างไฟล์ .env ที่โฟลเดอร์ราก โดยมีเนื้อหาดังนี้:
```
OPENAI_API_KEY=
```
หรือจะคัดลอกไฟล์ .env.example ที่มีมาให้แล้วแก้ไขคีย์ก็ได้:
```
cp .env.example .env
```

## 🧠 เริ่มต้นใช้งาน
เพื่อเริ่มต้นเอเจนต์ ให้รันคำสั่งต่อไปนี้:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ การร่วมพัฒนา

ยินดีรับข้อเสนอแนะ รายงานบั๊ก และการแก้ไขต่างๆ!

สำหรับฟีเจอร์ใหม่ คอมโพเนนต์ หรือส่วนขยาย กรุณาเปิด issue เพื่อพูดคุยก่อนส่ง PR

## 💖 โปรเจ็กต์นี้ดำรงอยู่ในสภาพปัจจุบันได้ด้วยการสนับสนุนจากผู้ร่วมพัฒนาทุกคน
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---