![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**เปลี่ยน GitHub repository ใดๆ ให้กลายเป็น Docker container พร้อมใช้งานในโปรดักชัน ด้วยการสร้าง Dockerfile อัตโนมัติด้วย AI**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer คือแอปพลิเคชันเว็บที่ขับเคลื่อนด้วย AI ซึ่งสร้าง Dockerfile ที่พร้อมใช้งานในโปรดักชันโดยอัตโนมัติ ด้วยการวิเคราะห์ GitHub repository เพียงวาง URL ของ GitHub แล้วรับ Dockerfile ที่ถูกปรับแต่ง พร้อมเลือก base image อัจฉริยะ จัดการ dependency และปฏิบัติตาม best practices ของ Docker

## 🌟 เข้าถึงอย่างรวดเร็ว

เพียงแค่เปลี่ยน `github.com` เป็น `gitcontainer.com` ใน URL ของ GitHub repository ใดๆ ก็สามารถเข้าถึงหน้าสร้าง Dockerfile สำหรับ repository นั้นได้ทันที

ตัวอย่างเช่น:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ คุณสมบัติ

- **🔄 เข้าถึงผ่าน URL ทันที**: เพียงแค่เปลี่ยน 'github.com' เป็น 'gitcontainer.com' ใน URL ของ GitHub ใดๆ
- **🤖 วิเคราะห์ด้วย AI**: ใช้ OpenAI GPT-4 ในการวิเคราะห์โครงสร้าง repository และสร้าง Dockerfile อัจฉริยะ
- **⚡ สตรีมมิ่งแบบเรียลไทม์**: ดู AI สร้าง Dockerfile ของคุณแบบเรียลไทม์ผ่าน WebSocket streaming
- **🎯 ตรวจจับเทคโนโลยีอัตโนมัติ**: ตรวจจับ stack ของเทคโนโลยีโดยอัตโนมัติ (Python, Node.js, Java, Go, ฯลฯ)
- **🔧 พร้อมใช้งานในโปรดักชัน**: สร้าง Dockerfile ตาม best practices พร้อมความปลอดภัย การ build แบบ multi-stage และการปรับแต่งให้เหมาะสม
- **📋 เพิ่มคำแนะนำเพิ่มเติม**: เพิ่มข้อกำหนดพิเศษสำหรับสภาพแวดล้อมเฉพาะทางได้
- **📄 Docker Compose**: แนะนำไฟล์ docker-compose.yml อัตโนมัติสำหรับแอปพลิเคชันที่ซับซ้อน
- **🎨 UI ทันสมัย**: อินเตอร์เฟซสะอาดตา ตอบสนองเร็ว พร้อม Monaco editor สำหรับเน้นไวยากรณ์
- **📱 รองรับมือถือ**: ทำงานได้อย่างไร้รอยต่อทั้งบนเดสก์ท็อปและมือถือ

## 🚀 เริ่มต้นอย่างรวดเร็ว

### ข้อกำหนดเบื้องต้น

- Python 3.9 ขึ้นไป
- Git
- OpenAI API key

### การติดตั้ง

1. **โคลน repository:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **ติดตั้ง dependencies:**
   ```bash
   pip install -r requirements.txt
   ```

3. **ตั้งค่า environment variables:**
   ```bash
   # สร้างไฟล์ .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **รันแอปพลิเคชัน:**
   ```bash
   python app.py
   ```

5. **เปิดเบราว์เซอร์ของคุณ:**
   ไปที่ `http://localhost:8000`

## 🛠️ ทำงานอย่างไร

1. **ประมวลผล URL**: เข้าถึง repository ใดๆ โดยเปลี่ยน 'github.com' เป็น 'gitcontainer.com' ใน URL
2. **โคลน repository**: Gitcontainer จะโคลน GitHub repository มายังเครื่องโลคัลโดยใช้ Git
3. **วิเคราะห์โค้ด**: ใช้ [gitingest](https://github.com/cyclotruc/gitingest) เพื่อวิเคราะห์โครงสร้าง repository และดึงข้อมูลที่เกี่ยวข้อง
4. **สร้างด้วย AI**: ส่งผลการวิเคราะห์ไปยัง OpenAI GPT-4 พร้อม prompt เฉพาะทางสำหรับสร้าง Dockerfile
5. **ปรับแต่งอย่างชาญฉลาด**: AI จะพิจารณา:
   - การตรวจจับ stack ของเทคโนโลยี
   - การจัดการ dependencies
   - Best practices ด้านความปลอดภัย
   - Multi-stage build เมื่อเป็นประโยชน์
   - การตั้งค่าพอร์ต
   - Environment variables
   - Health checks

## 📁 โครงสร้างโปรเจกต์

```
cyclotruc-gitcontainer/
├── app.py                 # แอปพลิเคชันหลัก FastAPI
├── requirements.txt       # Python dependencies
├── .env                  # Environment variables (สร้างไฟล์นี้)
├── static/               # ไฟล์ assets (icons, CSS)
├── templates/
│   └── index.jinja       # HTML template หลัก
└── tools/                # โมดูลฟังก์ชันหลัก
    ├── __init__.py
    ├── create_container.py  # การสร้าง Dockerfile ด้วย AI
    ├── git_operations.py    # การโคลน GitHub repository
    └── gitingest.py        # การวิเคราะห์ repository
```
## 🔧 การกำหนดค่า

### ตัวแปรสภาพแวดล้อม

| ตัวแปร | คำอธิบาย | จำเป็นหรือไม่ |
|----------|-------------|----------|
| `OPENAI_API_KEY` | คีย์ API ของ OpenAI ของคุณ | ใช่ |
| `PORT` | พอร์ตของเซิร์ฟเวอร์ (ค่าเริ่มต้น: 8000) | ไม่ |
| `HOST` | โฮสต์ของเซิร์ฟเวอร์ (ค่าเริ่มต้น: 0.0.0.0) | ไม่ |

### การใช้งานขั้นสูง

คุณสามารถใช้งานเครื่องมือเหล่านี้ผ่านโปรแกรม:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Clone repository
    clone_result = await clone_repo_tool(github_url)
    
    # วิเคราะห์ด้วย gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # สร้าง Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# การใช้งาน
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 การปรับแต่ง

### การเพิ่มคำสั่งกำหนดเอง

ใช้ฟีเจอร์ "คำสั่งเพิ่มเติม" เพื่อปรับแต่งการสร้าง:

- `"ใช้ Alpine Linux เพื่อลดขนาดของอิมเมจ"`
- `"รวม Redis และ PostgreSQL"`
- `"ปรับแต่งสำหรับการใช้งานในสภาพแวดล้อม production"`
- `"เพิ่มเครื่องมือสำหรับพัฒนาและดีบัก"`

## 📝 ใบอนุญาต

โปรเจกต์นี้อยู่ภายใต้สัญญาอนุญาต MIT License - ดูรายละเอียดได้ในไฟล์ [LICENSE](LICENSE)

## 🙏 ขอขอบคุณ

- **[OpenAI](https://openai.com/)** สำหรับการให้บริการ GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** สำหรับความสามารถในการวิเคราะห์ repository
- **[FastAPI](https://fastapi.tiangolo.com/)** สำหรับเฟรมเวิร์กเว็บที่ยอดเยี่ยม
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** สำหรับการไฮไลต์ซินแท็กซ์ของโค้ด

## 🔗 ลิงก์

- **GitHub Repository**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **เดโม**: ทดลองใช้งานกับ repository ตัวอย่าง
- **ปัญหา**: [รายงานบั๊กหรือขอฟีเจอร์](https://github.com/cyclotruc/gitcontainer/issues)

---

**สร้างด้วย ❤️ โดย [Romain Courtois](https://github.com/cyclotruc)**

*เปลี่ยน repository ใดๆ ให้กลายเป็น container ได้ภายในไม่กี่วินาที!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---