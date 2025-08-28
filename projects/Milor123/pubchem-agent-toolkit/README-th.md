
<div align="center"><p><a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=hi"><img src="https://img.shields.io/badge/हिन्दी-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=fa"><img src="https://img.shields.io/badge/فارسی-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=Milor123&project=pubchem-agent-toolkit&lang=id"><img src="https://img.shields.io/badge/Bahasa Indonesia-white" alt="version"></a> </p></div>

# เซิร์ฟเวอร์ PubChem MCP ที่ได้รับการปรับปรุงสำหรับผู้ช่วย AI

🧪 เซิร์ฟเวอร์ MCP ที่ล้ำหน้า แข็งแกร่ง และเน้นความเป็นส่วนตัว ซึ่งช่วยให้ผู้ช่วย AI สามารถค้นหาและเข้าถึงข้อมูลสารเคมีจาก PubChem ได้อย่างชาญฉลาด

เซิร์ฟเวอร์ PubChem MCP นี้ทำหน้าที่เป็นสะพานที่ทรงพลังระหว่างผู้ช่วย AI (เช่นใน AnythingLLM) และฐานข้อมูลสารเคมีขนาดใหญ่ของ PubChem โดยใช้ Model Context Protocol (MCP) เพื่อให้โมเดล AI สามารถค้นหาสารเคมีอย่างชาญฉลาดและยืดหยุ่น รวมทั้งเรียกดูคุณสมบัติต่าง ๆ ได้โดยอัตโนมัติ

---

## ✨ คุณสมบัติหลัก

นี่ไม่ใช่แค่ตัวห่อหุ้ม PubChem ทั่วไป เซิร์ฟเวอร์นี้ถูกสร้างขึ้นใหม่ทั้งหมดเพื่อให้มีความแข็งแกร่งและชาญฉลาดอย่างมาก:

-   **🧠 การค้นหาแบบสำรองอัจฉริยะ**: หากการค้นหาด้วยชื่อสามัญ (เช่น "Vitamin D") ล้มเหลว เซิร์ฟเวอร์จะทำการค้นหาเชิงลึกในฐานข้อมูลสาร PubChem Substance โดยอัตโนมัติ เพื่อค้นหาสารที่ถูกต้อง ซึ่งช่วยเพิ่มอัตราความสำเร็จสำหรับคำถามที่คลุมเครืออย่างมาก
-   **🛡️ การจัดการข้อผิดพลาดและการลองใหม่ที่แข็งแกร่ง**: เซิร์ฟเวอร์ถูกออกแบบให้รับมือกับข้อผิดพลาด API ได้อย่างราบรื่น หากพบข้อผิดพลาด "Server Busy" จาก PubChem จะรอและลองใหม่โดยอัตโนมัติ เพื่อให้แน่ใจว่าคำถามของคุณสำเร็จแม้ในช่วงที่มีการใช้งานสูง
-   **🔒 รองรับพร็อกซี่ Tor แบบเลือกใช้**: คุณสามารถควบคุมความเป็นส่วนตัวได้เต็มที่ ตั้งค่าในไฟล์ `config.ini` เพื่อส่งคำขอทั้งหมดผ่านเครือข่าย Tor (ผ่าน SOCKS5 หรือ HTTP proxy) เพื่อป้องกันไม่ให้ IP ของคุณถูกเปิดเผย เซิร์ฟเวอร์นี้ปลอดภัยโดยค่าเริ่มต้น และจะ **ไม่เคย** เปิดเผย IP ของคุณหากการเชื่อมต่อพร็อกซี่ล้มเหลว
-   **🔎 ค้นหาสารเดี่ยวและหลายสาร**: รองรับคำขอทั้งสำหรับสารเดียวหรือหลายสารในข้อความเดียวอย่างไร้รอยต่อ
-   **🧪 ดึงข้อมูลคุณสมบัติอย่างละเอียด**: เข้าถึงคุณสมบัติสำคัญ เช่น IUPAC Name, สูตรโมเลกุล, น้ำหนักโมเลกุล และที่สำคัญ **Monoisotopic Mass**

---

---

### 🚀 ไม่ต้องติดตั้ง: ทดลองใช้งานจริงบน Smithery.ai

สำหรับผู้ที่ยังใหม่กับเซิร์ฟเวอร์ MCP หรือเพียงแค่อยากทดสอบความสามารถของเครื่องมือนี้โดยไม่ต้องตั้งค่าใด ๆ มีเวอร์ชันออนไลน์ให้ใช้งานบน Smithery.ai คุณสามารถสนทนากับเอเจนต์ได้โดยตรงผ่านเบราว์เซอร์

[**<-- ทดลองใช้งาน PubChem Agent สดบน Smithery.ai -->**](https://smithery.ai/server/@Milor123/smithery-pubchem-deploy)

**วิธีเริ่มต้นใช้งาน:**

1.  คลิกที่ลิงก์ด้านบนเพื่อไปยังหน้าของเซิร์ฟเวอร์
2.  ลงชื่อเข้าใช้ด้วยบัญชี **GitHub** หรือ **Google** ของคุณ
3.  คลิกปุ่ม **"Explore capabilities"** เพื่อเปิดอินเทอร์เฟซแชทและเริ่มทดสอบได้ทันที!

> **✅ โมเดลแนะนำสำหรับผลลัพธ์ที่ดีที่สุด**
>
> เพื่อความแม่นยำสูงสุด โดยเฉพาะตัวเลขทศนิยมยาว ๆ ขอแนะนำให้ใช้โมเดลที่มีประสิทธิภาพสูง โดยโมเดลเหล่านี้ผ่านการทดสอบและทำงานได้ยอดเยี่ยมกับเครื่องมือนี้:
>
> *   **Anthropic's Claude 3 Sonnet**
> *   **OpenAI's GPT-4 Turbo** (หรือเวอร์ชันใหม่กว่า เช่น GPT-4o)
>
> เราได้ยืนยันแล้วว่าทั้งสองโมเดลสามารถประมวลผลค่าทศนิยมที่ถูกต้องครบถ้วนตามที่เครื่องมือส่งคืน โดยไม่มีการปัดเศษแต่อย่างใด

---

## 🚀 เริ่มต้นอย่างรวดเร็ว & การติดตั้ง

เซิร์ฟเวอร์นี้ถูกออกแบบมาให้ใช้งานในเครื่องของคุณเอง ไม่ว่าจะเป็นบนเดสก์ท็อปหรือในสภาพแวดล้อม Docker ของ AnythingLLM

### 1. ข้อกำหนดเบื้องต้น

โปรเจกต์นี้ต้องใช้ไลบรารี Python บางตัว ตรวจสอบให้แน่ใจว่าติดตั้งไว้ในสภาพแวดล้อมของคุณแล้ว

สร้างไฟล์ `requirements.txt` โดยมีเนื้อหาดังต่อไปนี้:
```txt
requests
bs4 
mcp 
pubchempy
pandas
PySocks
```
ติดตั้งโดยใช้ `uv` หรือ `pip`:

```bash
uv venv
.venv\Scripts\activate
uv pip install -r requirements.txt
```
*(หมายเหตุ: จำเป็นต้องใช้ `PySocks` เฉพาะกรณีที่คุณวางแผนจะใช้คุณสมบัติพร็อกซี Tor SOCKS5 เท่านั้น)*

### 2. การกำหนดค่า

เซิร์ฟเวอร์จะถูกกำหนดค่าผ่านไฟล์ `config.ini` ซึ่งจะถูก **สร้างขึ้นโดยอัตโนมัติ** เมื่อคุณเรียกใช้งานครั้งแรก ไฟล์นี้จะปรากฏในไดเรกทอรีเดียวกับสคริปต์ `pubchem_server.py`

**ไฟล์ `config.ini` ค่าเริ่มต้น:**
```ini
[proxy]
# Change 'use_proxy' to 'true' to route all requests through a proxy.
# Essential for protecting your privacy if you use Tor.
use_proxy = false

# Defines the proxy type. Options:
#   socks5h  -> (Recommended for Tor) The native SOCKS proxy for Tor. More secure.
#   http     -> An HTTP proxy. If using Tor, requires additional configuration.
proxy_type = socks5h

# The proxy address. THIS IS A CRITICAL SETTING!
#   - If you run this script on your DESKTOP, use: 127.0.0.1
#   - If you run this script inside DOCKER, use: host.docker.internal
host = 127.0.0.1

# The proxy port.
#   9050 -> Default port for Tor's SOCKS proxy.
#   8118 -> Default port for Tor's HTTP proxy (if enabled).
port = 9050
```

### 3. การบูรณาการกับ AnythingLLM

ทำตามเอกสารอย่างเป็นทางการเพื่อเพิ่มสิ่งนี้เป็นเซิร์ฟเวอร์ MCP ที่กำหนดเอง จุดสำคัญคือการชี้ไปที่ `command` ของคุณไปยังไฟล์ปฏิบัติการ Python และสคริปต์ `pubchem_server.py`

**ตัวอย่างสำหรับ AnythingLLM Desktop (`plugins/anythingllm_mcp_servers.json`):**
```json
{
  "mcpServers": {
    "pubchem": {
      "name": "PubChem Server (Enhanced)",
      "transport": "stdio",
      "command": "\"C:\\path\\to\\your\\.venv\\Scripts\\python.exe\" \"C:\\path\\to\\your\\project\\pubchem_server.py\"",
      "cwd": "C:\\path\\to\\your\\project"
    }
  }
}
```
### 3.1 ตัวอย่างการใช้งานกับ AnythingLLM

นี่คือตัวอย่างวิธีการโต้ตอบกับเอเจนต์ การทดสอบเหล่านี้ดำเนินการโดยใช้ AnythingLLM Desktop ที่เชื่อมต่อกับโมเดลภาษาขนาดใหญ่หลายตัวผ่าน OpenRouter

ผลการทดสอบที่สำคัญคือการเลือกโมเดลที่ใช้งาน เรา **ขอแนะนำอย่างยิ่งให้งดใช้โมเดลขนาดเล็กหรือโมเดลที่รันในเครื่อง** สำหรับงานนี้ เนื่องจากโมเดลขนาดเล็กมักประสบปัญหาในการแยกวิเคราะห์ข้อมูลที่เครื่องมือส่งกลับมาอย่างถูกต้อง ส่งผลให้เกิดข้อผิดพลาด เช่น ค่าที่มโนขึ้นเอง รูปแบบข้อมูลผิด หรือที่สำคัญที่สุดคือ **การปัดเศษตัวเลขทศนิยม** ซึ่งขัดแย้งกับวัตถุประสงค์ของเครื่องมือความละเอียดสูงนี้

เพื่อรักษาความถูกต้องของผลลัพธ์ ขอแนะนำให้ตรวจสอบข้อมูลดิบที่ MCP ส่งกลับทุกครั้ง คุณสามารถเรียนรู้วิธีการได้ในหัวข้อถัดไป: [3.2 วิธีตรวจสอบผลลัพธ์ MCP ใน log](#32-how-to-verify-mcp-outputs-in-the-logs)

<img width="837" height="1060" alt="imagen" src="https://github.com/user-attachments/assets/5a16c7a2-d65d-4d64-98dd-f3cb4cae9b22" />

ในทางกลับกัน มีหลายโมเดลที่ให้ผลลัพธ์ยอดเยี่ยม เราได้ผลลัพธ์ที่โดดเด่นจาก **Google's `Gemini 2.5 Flash lite`** ซึ่งมีความแม่นยำสูงในการจัดการตัวเลขทศนิยมยาวและจัดรูปแบบตาราง Markdown ได้ถูกต้อง

Google gemini 2.5 flash lite ทั้งกรณีไม่ใส่ prompt และใส่ prompt ยังคงความแม่นยำของทศนิยม (ในตัวอย่างใช้ค่า temperature ที่ 0.6)

<img width="1089" height="1061" alt="imagen" src="https://github.com/user-attachments/assets/4574efa5-d6d9-49e3-a665-a39a427f09a1" />

สำหรับงานนี้ โดยส่วนตัวผมชื่นชอบ **`Gemini 2.5 Flash lite`** เนื่องจากความแม่นยำและความน่าเชื่อถือที่สม่ำเสมอ

### 3.2 วิธีตรวจสอบผลลัพธ์ MCP ใน log

วิธีที่ดีที่สุดในการยืนยันว่าเอเจนต์ได้รับข้อมูลถูกต้องและ LLM ไม่ทำผิดพลาด คือการตรวจสอบไฟล์ debug log ที่สร้างโดยเซิร์ฟเวอร์ MCP

เซิร์ฟเวอร์นี้ถูกตั้งค่าให้สร้างไฟล์ log อัตโนมัติในโฟลเดอร์ย่อยภายในไดเรกทอรีโปรเจ็กต์ของคุณ ตำแหน่งไฟล์จะเป็น:



```
your-project-folder/
└── logs_mcp/
    └── mcp_debug.log
```

ภายในไฟล์ `mcp_debug.log` คุณจะพบข้อมูล JSON ที่เครื่องมือส่งกลับไปยัง LLM *ก่อน* ที่โมเดลจะประมวลผลข้อมูล คุณสามารถตรวจสอบ JSON นี้ด้วยตัวเองเพื่อยืนยันค่าต่างๆ โดยเฉพาะตัวเลขทศนิยมยาวๆ จากพร็อพเพอร์ตี้อย่าง `monoisotopic_mass` เพื่อให้แน่ใจว่า LLM ไม่ได้ทำให้เกิดข้อผิดพลาดจากการปัดเศษหรือจินตนาการข้อมูลในคำตอบสุดท้าย

---

## 📊 การใช้งาน

เมื่อเชื่อมต่อแล้ว ผู้ช่วย AI ของคุณจะใช้เครื่องมือนี้โดยอัตโนมัติเมื่อถูกถามเกี่ยวกับข้อมูลทางเคมี เครื่องมือหลักที่เปิดให้ใช้งานคือ `search_compounds_by_name`

### ตัวอย่างคำสั่ง

คำสั่งนี้แสดงความสามารถของเครื่องมือในการจัดการรายชื่อสารประกอบที่มีประเภทชื่อแตกต่างกัน และดึงข้อมูลพร็อพเพอร์ตี้หลายรายการออกมา

```
@agent
Please use your PubChem tool to find information on the following compounds:

- Thiamine (Vitamin B1)
- Riboflavin (Vitamin B2)
- Folic Acid
- Hydroxocobalamin

For each compound found, please retrieve the IUPAC Name, Molecular Formula, and Monoisotopic Mass.

Present all the results in a single Markdown table.
```
ตัวแทนจะเรียกใช้เครื่องมือ `search_compounds_by_name` ซึ่งจะค้นหาสารประกอบแต่ละตัวอย่างชาญฉลาด ดึงข้อมูลและส่งกลับไปยัง LLM เพื่อจัดรูปแบบ

---

## 🛠 เครื่องมือ MCP ที่เปิดเผย

### `search_compounds_by_name`

ค้นหาสารประกอบหลายรายการตามชื่อทีละรายการ โดยใช้กลยุทธ์สำรองอัจฉริยะพร้อมการหยุดพักและลองใหม่เพื่อความน่าเชื่อถือสูงสุด

**พารามิเตอร์:**
-   `names` (List[str]): รายชื่อสารประกอบ เช่น `["Aspirin", "Ibuprofen"]`

**ผลลัพธ์:** รายการพจนานุกรม โดยแต่ละพจนานุกรมจะมีข้อมูลของสารประกอบที่พบหรือข้อความแสดงข้อผิดพลาดที่อธิบายเหตุผลที่การค้นหาสำหรับสารประกอบนั้นล้มเหลว

---

## 🙏 คำขอบคุณ

โปรเจกต์นี้ได้รับแรงบันดาลใจและสร้างขึ้นบนพื้นฐานของ [PubChem-MCP-Server](https://github.com/JackKuo666/PubChem-MCP-Server) ต้นฉบับโดย **JackKuo666**

แม้ว่าคลังนี้จะไม่ใช่การ fork โดยตรง แต่โปรเจกต์ต้นฉบับเป็นจุดเริ่มต้นที่สำคัญ รุ่นนี้พัฒนาคอนเซปต์เดิมให้แข็งแกร่งขึ้น เน้นกลยุทธ์การค้นหาอัจฉริยะ และความเป็นส่วนตัวของผู้ใช้ผ่านการเชื่อมต่อ Tor แบบเลือกได้ 🧅

ขอขอบคุณผู้เขียนต้นฉบับสำหรับผลงานอันยอดเยี่ยมและการแบ่งปันแก่ชุมชน

---

## ⚠️ ข้อจำกัดความรับผิดชอบ

เครื่องมือนี้มีไว้เพื่อการวิจัยและการศึกษาเท่านั้น โปรดเคารพข้อกำหนดการใช้งานของ PubChem และใช้งานเครื่องมือนี้อย่างรับผิดชอบ



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---