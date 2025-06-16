# AgenticSeek: ทางเลือก Manus แบบส่วนตัวและโลคอล

<p align="center">
<img align="center" src="https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/agentic_seek_logo.png" width="300" height="300" alt="Agentic Seek Logo">
<p>

  English | [中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHS.md) | [繁體中文](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_CHT.md) | [Français](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_FR.md) | [日本語](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_JP.md) | [Português (Brasil)](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_PTBR.md) | [Español](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/README_ES.md)

*ทางเลือก **100% แบบโลคอลสำหรับ Manus AI** ผู้ช่วย AI ที่เปิดใช้งานด้วยเสียงนี้ สามารถท่องเว็บ ออกแบบโค้ด และวางแผนงานได้อย่างอัตโนมัติ โดยเก็บข้อมูลทุกอย่างไว้ในเครื่องของคุณ ออกแบบมาสำหรับโมเดล reasoning แบบโลคอลโดยเฉพาะ ทำงานทั้งหมดบนฮาร์ดแวร์ของคุณ เพื่อความเป็นส่วนตัวอย่างสมบูรณ์ ไม่มีการเชื่อมต่อคลาวด์ใดๆ*

[![Visit AgenticSeek](https://img.shields.io/static/v1?label=Website&message=AgenticSeek&color=blue&style=flat-square)](https://fosowl.github.io/agenticSeek.html) ![License](https://img.shields.io/badge/license-GPL--3.0-green) [![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/8hGDaME3TC) [![Twitter](https://img.shields.io/twitter/url/https/twitter.com/fosowl.svg?style=social&label=Update%20%40Fosowl)](https://x.com/Martin993886460) [![GitHub stars](https://img.shields.io/github/stars/Fosowl/agenticSeek?style=social)](https://github.com/Fosowl/agenticSeek/stargazers)

### ทำไมต้อง AgenticSeek?

* 🔒 โลคอลและเป็นส่วนตัวอย่างแท้จริง - ทุกอย่างทำงานบนเครื่องคุณเอง ไม่มีคลาวด์ ไม่มีการแชร์ข้อมูล ไฟล์ บทสนทนา และการค้นหาของคุณปลอดภัย

* 🌐 ท่องเว็บอัจฉริยะ - AgenticSeek ท่องอินเทอร์เน็ตได้เอง ค้นหา อ่าน ดึงข้อมูล กรอกฟอร์มออนไลน์ — โดยไม่ต้องใช้มือ

* 💻 ผู้ช่วยเขียนโค้ดอัตโนมัติ - ต้องการโค้ด? เขียน ดีบั๊ก และรันโปรแกรม Python, C, Go, Java และอื่นๆ ได้เองโดยไม่ต้องดูแล

* 🧠 เลือกเอเจนต์อัจฉริยะ - คุณถาม ระบบจะเลือกเอเจนต์ที่เหมาะสมที่สุดให้อัตโนมัติ ราวกับมีทีมผู้เชี่ยวชาญอยู่ข้างคุณ

* 📋 วางแผนและดำเนินงานที่ซับซ้อนได้ - ตั้งแต่การวางแผนทริปจนถึงโปรเจกต์ซับซ้อน สามารถแบ่งงานใหญ่เป็นขั้นตอนและใช้หลาย AI agent ทำให้เสร็จ

* 🎙️ เปิดใช้งานด้วยเสียง - ระบบสั่งงานด้วยเสียงและแปลงเสียงเป็นข้อความที่รวดเร็ว ทันสมัย ให้คุณพูดคุยกับมันเหมือน AI ส่วนตัวในหนังไซไฟ (กำลังพัฒนา)

### **เดโม**

> *คุณช่วยค้นหาโปรเจกต์ agenticSeek ดูว่าต้องการทักษะอะไร จากนั้นเปิดไฟล์ CV_candidates.zip แล้วบอกฉันว่าคนไหนเหมาะสมที่สุดกับโปรเจกต์นี้*

https://github.com/user-attachments/assets/b8ca60e9-7b3b-4533-840e-08f9ac426316

หมายเหตุ: เดโมนี้รวมถึงไฟล์ทุกไฟล์ (เช่น CV_candidates.zip) เป็นเรื่องสมมติทั้งหมด เราไม่ใช่องค์กร เราต้องการผู้ร่วมพัฒนาโอเพ่นซอร์ส ไม่ใช่ผู้สมัคร

> 🛠⚠️️ **อยู่ระหว่างการพัฒนาอย่างต่อเนื่อง**

> 🙏 โปรเจกต์นี้เริ่มจากงานอดิเรก ไม่มีแผนโร้ดแมปหรือทุนสนับสนุน ตอนนี้เติบโตเกินคาดและติด GitHub Trending ทุกข้อเสนอแนะและความอดทนของคุณมีค่ามาก

## ข้อกำหนดเบื้องต้น

ก่อนเริ่มต้น ให้ติดตั้งซอฟต์แวร์ต่อไปนี้:

*   **Git:** สำหรับโคลนรีโพซิทอรี [ดาวน์โหลด Git](https://git-scm.com/downloads)
*   **Python 3.10.x:** แนะนำให้ใช้ Python 3.10.x เท่านั้น ใช้เวอร์ชันอื่นอาจเกิดปัญหา dependency [ดาวน์โหลด Python 3.10](https://www.python.org/downloads/release/python-3100/) (เลือก 3.10.x)
*   **Docker Engine & Docker Compose:** สำหรับรันบริการรวม เช่น SearxNG
    *   ติดตั้ง Docker Desktop (รวม Docker Compose V2): [Windows](https://docs.docker.com/desktop/install/windows-install/) | [Mac](https://docs.docker.com/desktop/install/mac-install/) | [Linux](https://docs.docker.com/desktop/install/linux-install/)
    *   หรือ ติดตั้ง Docker Engine และ Docker Compose แยกบน Linux: [Docker Engine](https://docs.docker.com/engine/install/) | [Docker Compose](https://docs.docker.com/compose/install/) (ต้องใช้ Compose V2 เช่น `sudo apt-get install docker-compose-plugin`)

### 1. **โคลนรีโพซิทอรีและตั้งค่า**

```sh
git clone https://github.com/Fosowl/agenticSeek.git
cd agenticSeek
mv .env.example .env
```

### 2. เปลี่ยนค่าภายในไฟล์ .env

```sh
SEARXNG_BASE_URL="http://127.0.0.1:8080"
REDIS_BASE_URL="redis://redis:6379/0"
WORK_DIR="/Users/mlg/Documents/workspace_for_ai"
OLLAMA_PORT="11434"
LM_STUDIO_PORT="1234"
CUSTOM_ADDITIONAL_LLM_PORT="11435"
OPENAI_API_KEY='optional'
DEEPSEEK_API_KEY='optional'
OPENROUTER_API_KEY='optional'
TOGETHER_API_KEY='optional'
GOOGLE_API_KEY='optional'
ANTHROPIC_API_KEY='optional'
```

อัปเดตไฟล์ `.env` ด้วยค่าของคุณเองตามต้องการ:

- **SEARXNG_BASE_URL**: ไม่ต้องเปลี่ยน
- **REDIS_BASE_URL**: ไม่ต้องเปลี่ยน
- **WORK_DIR**: เส้นทางโฟลเดอร์งานบนเครื่อง AgenticSeek จะอ่านและโต้ตอบกับไฟล์เหล่านี้ได้
- **OLLAMA_PORT**: หมายเลขพอร์ตสำหรับบริการ Ollama
- **LM_STUDIO_PORT**: หมายเลขพอร์ตสำหรับ LM Studio
- **CUSTOM_ADDITIONAL_LLM_PORT**: พอร์ตสำหรับ LLM แบบ custom เพิ่มเติม

**API Key สามารถเว้นว่างได้สำหรับผู้ใช้ที่ต้องการรัน LLM ในเครื่อง ซึ่งเป็นจุดประสงค์หลักของโปรเจกต์นี้ หากฮาร์ดแวร์คุณเพียงพอ ให้เว้นว่าง**

### 3. **เริ่มต้น Docker**

ตรวจสอบให้แน่ใจว่าติดตั้ง Docker และกำลังทำงานบนระบบของคุณ สามารถเริ่ม Docker ด้วยคำสั่งต่อไปนี้:

- **บน Linux/macOS:**  
    เปิดเทอร์มินัลแล้วรัน:
    ```sh
    sudo systemctl start docker
    ```
    หรือเปิด Docker Desktop จากเมนูแอปพลิเคชันหากติดตั้งไว้

- **บน Windows:**  
    เปิด Docker Desktop จาก Start menu

ตรวจสอบว่า Docker ทำงานแล้วโดยใช้คำสั่ง:
```sh
docker info
```
หากเห็นข้อมูลของ Docker แสดงว่าพร้อมใช้งาน

ดูตาราง [Local Providers](#list-of-local-providers) ด้านล่างสำหรับสรุป

ขั้นตอนถัดไป: [Run AgenticSeek locally](#start-services-and-run)

*ดูที่ [Troubleshooting](#troubleshooting) หากพบปัญหา*
*หากฮาร์ดแวร์ไม่รองรับ LLM ในเครื่อง ดู [Setup to run with an API](#setup-to-run-with-an-api)*
*สำหรับคำอธิบาย `config.ini` แบบละเอียด ดู [Config Section](#config)*

---

## การตั้งค่าสำหรับรัน LLM ในเครื่อง

**ความต้องการฮาร์ดแวร์:**

ในการรัน LLM ในเครื่อง ต้องมีฮาร์ดแวร์ที่เพียงพอ ขั้นต่ำควรมี GPU ที่รัน Magistral, Qwen หรือ Deepseek 14B ได้ ดู FAQ สำหรับคำแนะนำโมเดล/ประสิทธิภาพโดยละเอียด

**ตั้งค่า local provider ของคุณ**  

เริ่ม local provider เช่น ollama:

```sh
ollama serve
```

ดูรายชื่อ local provider ที่รองรับด้านล่าง

**อัปเดต config.ini**

เปลี่ยนไฟล์ config.ini โดยตั้งค่า provider_name เป็น provider ที่รองรับ และ provider_model เป็น LLM ที่ provider ของคุณรองรับ แนะนำใช้ reasoning model เช่น *Magistral* หรือ *Deepseek*

ดู **FAQ** ท้าย README สำหรับความต้องการฮาร์ดแวร์

```sh
[MAIN]
is_local = True # กำหนดว่ารันโลคอลหรือใช้ provider ระยะไกล
provider_name = ollama # หรือ lm-studio, openai, ฯลฯ
provider_model = deepseek-r1:14b # เลือกโมเดลที่เหมาะสมกับฮาร์ดแวร์
provider_server_address = 127.0.0.1:11434
agent_name = Jarvis # ชื่อ AI ของคุณ
recover_last_session = True # กู้คืน session เดิม
save_session = True # จดจำ session ปัจจุบัน
speak = False # text to speech
listen = False # speech to text เฉพาะ CLI, ยังเป็น experimental
jarvis_personality = False # ใช้บุคลิกแบบ "Jarvis" (experimental)
languages = en zh # รายการภาษา Text to speech จะใช้ภาษาตัวแรกเป็นหลัก
[BROWSER]
headless_browser = True # ปล่อยไว้หากใช้ CLI บน host
stealth_mode = True # ใช้ undetected selenium ลดการถูกจับได้จากเว็บ
```

**คำเตือน**:

- ไฟล์ `config.ini` ไม่รองรับคอมเมนต์  
ห้ามคัดลอกตัวอย่างไปทั้งดุ้น ให้แก้ไขไฟล์จริงโดยไม่ใส่คอมเมนต์

- ห้ามตั้ง provider_name เป็น `openai` หากใช้ LM-studio ให้ตั้งเป็น `lm-studio`

- บาง provider (เช่น lm-studio) ต้องมี `http://` หน้าหมายเลข IP เช่น `http://127.0.0.1:1234`

**รายชื่อ local providers**

| Provider  | Local? | คำอธิบาย                                               |
|-----------|--------|--------------------------------------------------------|
| ollama    | Yes    | รัน LLM ในเครื่องได้ง่ายๆ ด้วย ollama เป็น LLM provider |
| lm-studio | Yes    | รัน LLM ในเครื่องด้วย LM studio (ตั้ง `provider_name` เป็น `lm-studio`)|
| openai    | Yes    | ใช้ API ที่เข้ากันได้กับ openai (เช่น llama.cpp server) |

ขั้นตอนถัดไป: [Start services and run AgenticSeek](#Start-services-and-Run)  

*ดูที่ [Troubleshooting](#troubleshooting) หากพบปัญหา*
*หากฮาร์ดแวร์ไม่รองรับ LLM ในเครื่อง ดู [Setup to run with an API](#setup-to-run-with-an-api)*
*สำหรับคำอธิบาย `config.ini` แบบละเอียด ดู [Config Section](#config)*

## การตั้งค่าสำหรับรันผ่าน API

การตั้งค่านี้ใช้ผู้ให้บริการ LLM บนคลาวด์ คุณต้องมี API key จากบริการที่เลือก

**1. เลือก API Provider และขอ API Key:**

ดู [List of API Providers](#list-of-api-providers) ด้านล่าง เข้าเว็บเพื่อสมัครและรับ API key

**2. ตั้ง API Key เป็น Environment Variable:**


*   **Linux/macOS:**
    เปิดเทอร์มินัลแล้วใช้คำสั่ง `export` แนะนำเพิ่มในไฟล์ profile ของ shell (เช่น `~/.bashrc`, `~/.zshrc`) เพื่อความคงทน
    ```sh
    export PROVIDER_API_KEY="your_api_key_here" 
    # แทนที่ PROVIDER_API_KEY ด้วยชื่อตัวแปรที่ระบุ เช่น OPENAI_API_KEY, GOOGLE_API_KEY
    ```
    ตัวอย่างสำหรับ TogetherAI:
    ```sh
    export TOGETHER_API_KEY="xxxxxxxxxxxxxxxxxxxxxx"
    ```
*   **Windows:**
*   **Command Prompt (ชั่วคราวสำหรับเซสชั่นปัจจุบัน):**
    ```cmd
    set PROVIDER_API_KEY=your_api_key_here
    ```
*   **PowerShell (ชั่วคราวสำหรับเซสชั่นปัจจุบัน):**
    ```powershell
    $env:PROVIDER_API_KEY="your_api_key_here"
    ```
*   **ถาวร:** ค้นหา "environment variables" ในแถบค้นหา Windows คลิก "Edit the system environment variables" จากนั้นคลิกปุ่ม "Environment Variables..." เพิ่ม User variable ใหม่โดยใช้ชื่อที่เหมาะสม (เช่น `OPENAI_API_KEY`) และใส่คีย์ของคุณเป็นค่า

*(ดู FAQ: [How do I set API keys?](#how-do-i-set-api-keys) สำหรับรายละเอียดเพิ่มเติม)*


**3. อัปเดต `config.ini`:**
```ini
[MAIN]
is_local = False
provider_name = openai # หรือ google, deepseek, togetherAI, huggingface
provider_model = gpt-3.5-turbo # หรือ gemini-1.5-flash, deepseek-chat, mistralai/Mixtral-8x7B-Instruct-v0.1 ฯลฯ
provider_server_address = # โดยปกติมักไม่ถูกใช้ หรือเว้นว่างเมื่อ is_local = False สำหรับ API ส่วนใหญ่
# ... การตั้งค่าอื่น ๆ ...
```
*คำเตือน:* ตรวจสอบให้แน่ใจว่าไม่มีช่องว่างต่อท้ายในค่า `config.ini`

**รายชื่อผู้ให้บริการ API**

| Provider     | `provider_name` | Local? | คำอธิบาย                                               | ลิงก์รับ API Key (ตัวอย่าง)                     |
|--------------|-----------------|--------|--------------------------------------------------------|--------------------------------------------------|
| OpenAI       | `openai`        | No     | ใช้โมเดล ChatGPT ผ่าน API ของ OpenAI                   | [platform.openai.com/signup](https://platform.openai.com/signup) |
| Google Gemini| `google`        | No     | ใช้โมเดล Google Gemini ผ่าน Google AI Studio           | [aistudio.google.com/keys](https://aistudio.google.com/keys) |
| Deepseek     | `deepseek`      | No     | ใช้โมเดล Deepseek ผ่าน API ของพวกเขา                   | [platform.deepseek.com](https://platform.deepseek.com) |
| Hugging Face | `huggingface`   | No     | ใช้โมเดลจาก Hugging Face Inference API                | [huggingface.co/settings/tokens](https://huggingface.co/settings/tokens) |
| TogetherAI   | `togetherAI`    | No     | ใช้โมเดลโอเพนซอร์สต่าง ๆ ผ่าน TogetherAI API         | [api.together.ai/settings/api-keys](https://api.together.ai/settings/api-keys) |

*หมายเหตุ:*
*   ไม่แนะนำให้ใช้ `gpt-4o` หรือโมเดล OpenAI อื่น ๆ สำหรับการท่องเว็บขั้นสูงและวางแผนงาน เนื่องจากการปรับแต่ง prompt ในปัจจุบันเหมาะกับ Deepseek มากกว่า
*   งานเขียนโค้ด/คำสั่ง bash อาจมีปัญหากับ Gemini เนื่องจากอาจไม่ทำตามรูปแบบ prompt ที่ปรับให้เหมาะกับ Deepseek อย่างเคร่งครัด
*   `provider_server_address` ใน `config.ini` โดยทั่วไปจะไม่ถูกใช้งานเมื่อ `is_local = False` เพราะ endpoint ของ API มักถูกกำหนดไว้ในไลบรารีของผู้ให้บริการแต่ละราย

ขั้นตอนถัดไป: [เริ่มบริการและรัน AgenticSeek](#Start-services-and-Run)

*ดูหัวข้อ **Known issues** หากคุณพบปัญหา*

*ดูหัวข้อ **Config** สำหรับคำอธิบายไฟล์ config อย่างละเอียด*

---

## เริ่มบริการและรัน

โดยปกติ AgenticSeek จะรันแบบเต็มใน docker

เริ่มบริการที่จำเป็น โดยจะเริ่มทุกบริการจาก docker-compose.yml รวมถึง:
    - searxng
    - redis (จำเป็นสำหรับ searxng)
    - frontend
    - backend (หากใช้ `full`)

```sh
./start_services.sh full # MacOS
start ./start_services.cmd full # Window
```

**คำเตือน:** ขั้นตอนนี้จะดาวน์โหลดและโหลด Docker image ทั้งหมด ซึ่งอาจใช้เวลาสูงสุดถึง 30 นาที หลังจากเริ่มบริการแล้ว กรุณารอจน backend service ทำงานสมบูรณ์ (คุณควรเห็น **backend: "GET /health HTTP/1.1" 200 OK** ใน log) ก่อนส่งข้อความใด ๆ บริการ backend อาจใช้เวลาประมาณ 5 นาทีในการเริ่มต้นในครั้งแรก

ไปที่ `http://localhost:3000/` แล้วคุณควรเห็นหน้าเว็บอินเทอร์เฟซ

*การแก้ปัญหาเมื่อติดขัดการเริ่มบริการ:* หากสคริปต์เหล่านี้ล้มเหลว ตรวจสอบว่า Docker Engine ทำงานอยู่และ Docker Compose (V2, `docker compose`) ได้รับการติดตั้งอย่างถูกต้อง ตรวจสอบข้อความ error ในเทอร์มินัล ดู [FAQ: Help! I get an error when running AgenticSeek or its scripts.](#faq-troubleshooting)

**ทางเลือก:** รันบน host (โหมด CLI):

หากต้องการรันแบบ CLI interface คุณต้องติดตั้งแพ็กเกจบนเครื่อง host:

```sh
./install.sh
./install.bat # windows
```

เริ่มบริการ:

```sh
./start_services.sh # MacOS
start ./start_services.cmd # Window
```

ใช้ CLI: `python3 cli.py`


---

## การใช้งาน

ตรวจสอบให้แน่ใจว่าบริการทั้งหมดรันอยู่ด้วย `./start_services.sh full` และไปที่ `localhost:3000` สำหรับเว็บอินเทอร์เฟซ

คุณยังสามารถใช้ speech to text ได้โดยตั้งค่า `listen = True` ใน config เฉพาะโหมด CLI เท่านั้น

หากต้องการออกจากโปรแกรม เพียงพูด/พิมพ์ว่า `goodbye`

ตัวอย่างการใช้งาน:

> *สร้างเกมงูด้วยภาษา python!*

> *ค้นหาเว็บสำหรับร้านกาแฟยอดนิยมใน Rennes, France และบันทึกรายชื่อ 3 ร้านพร้อมที่อยู่ลงใน rennes_cafes.txt*

> *เขียนโปรแกรม Go เพื่อคำนวณแฟกทอเรียลของตัวเลขหนึ่งตัว บันทึกเป็น factorial.go ใน workspace ของคุณ*

> *ค้นหาไฟล์ JPG ทั้งหมดในโฟลเดอร์ summer_pictures เปลี่ยนชื่อไฟล์ตามวันที่วันนี้ และบันทึกรายชื่อไฟล์ที่เปลี่ยนชื่อแล้วใน photos_list.txt*

> *ค้นหาหนังไซไฟยอดนิยมทางออนไลน์จากปี 2024 และเลือก 3 เรื่องสำหรับดูคืนนี้ บันทึกรายชื่อใน movie_night.txt*

> *ค้นหาเว็บสำหรับข่าว AI ล่าสุดจากปี 2025 เลือก 3 ข่าว และเขียนสคริปต์ Python เพื่อดึงชื่อข่าวและสรุปข่าว บันทึกสคริปต์เป็น news_scraper.py และสรุปข่าวใน ai_news.txt ที่ /home/projects*

> *วันศุกร์ ค้นหาเว็บสำหรับ API ราคาหุ้นฟรี สมัครด้วย supersuper7434567@gmail.com แล้วเขียนสคริปต์ Python เพื่อดึงราคาหุ้นรายวันของ Tesla และบันทึกผลลัพธ์ใน stock_prices.csv*

*โปรดทราบว่าความสามารถในการกรอกฟอร์มยังอยู่ในระยะทดลองและอาจล้มเหลว*

หลังจากคุณพิมพ์คำสั่ง AgenticSeek จะจัดสรร agent ที่เหมาะสมที่สุดสำหรับงานนั้น ๆ

เนื่องจากยังเป็นต้นแบบ ระบบเลือก agent อาจไม่จัดสรร agent ที่ถูกต้องตามคำถามของคุณเสมอไป

ดังนั้น คุณควรระบุให้ชัดเจนว่าต้องการอะไรและอยากให้ AI ดำเนินการอย่างไร เช่น ถ้าต้องการให้ค้นหาเว็บ อย่าพูดว่า:

`Do you know some good countries for solo-travel?`

แต่ให้ถามว่า:

`Do a web search and find out which are the best country for solo-travel`

---

## **ตั้งค่ารัน LLM บนเซิร์ฟเวอร์ของคุณเอง**  

หากคุณมีคอมพิวเตอร์หรือเซิร์ฟเวอร์ที่มีประสิทธิภาพ และต้องการใช้งานจากแล็ปท็อปของคุณ คุณสามารถรัน LLM บนเซิร์ฟเวอร์ระยะไกลโดยใช้ custom llm server ของเรา

บน "server" ที่จะรันโมเดล AI ให้รับ ip address

```sh
ip a | grep "inet " | grep -v 127.0.0.1 | awk '{print $2}' | cut -d/ -f1 # local ip
curl https://ipinfo.io/ip # public ip
```

หมายเหตุ: สำหรับ Windows หรือ macOS ใช้ ipconfig หรือ ifconfig ตามลำดับเพื่อดู IP address

โคลน repository และเข้าโฟลเดอร์ `server/`

```sh
git clone --depth 1 https://github.com/Fosowl/agenticSeek.git
cd agenticSeek/llm_server/
```

ติดตั้ง requirements เฉพาะเซิร์ฟเวอร์:

```sh
pip3 install -r requirements.txt
```

รันสคริปต์เซิร์ฟเวอร์

```sh
python3 app.py --provider ollama --port 3333
```

คุณสามารถเลือกใช้ `ollama` หรือ `llamacpp` เป็นบริการ LLM

จากนั้นที่คอมพิวเตอร์ส่วนตัวของคุณ:

แก้ไขไฟล์ `config.ini` ตั้งค่า `provider_name` เป็น `server` และ `provider_model` เป็น `deepseek-r1:xxb`
ตั้งค่า `provider_server_address` ให้เป็น ip address ของเครื่องที่รันโมเดล

```sh
[MAIN]
is_local = False
provider_name = server
provider_model = deepseek-r1:70b
provider_server_address = x.x.x.x:3333
```

ขั้นตอนถัดไป: [เริ่มบริการและรัน AgenticSeek](#Start-services-and-Run)  

---

## Speech to Text

คำเตือน: speech to text ใช้งานได้เฉพาะในโหมด CLI ขณะนี้

โปรดทราบว่าขณะนี้ speech to text รองรับเฉพาะภาษาอังกฤษ

ฟังก์ชัน speech-to-text ถูกปิดใช้งานโดยค่าเริ่มต้น หากต้องการเปิด ให้ตั้งค่า listen เป็น True ในไฟล์ config.ini:

```
listen = True
```

เมื่อเปิดใช้งาน ฟีเจอร์ speech-to-text จะรอฟัง "trigger keyword" ซึ่งก็คือชื่อของ agent ก่อนเริ่มประมวลผลคำสั่งของคุณ คุณสามารถปรับแต่งชื่อ agent ได้โดยอัปเดตค่า `agent_name` ใน *config.ini*:

```
agent_name = Friday
```

เพื่อให้ระบบรู้จำได้ดีที่สุด ขอแนะนำให้ใช้ชื่อภาษาอังกฤษที่พบได้บ่อย เช่น "John" หรือ "Emma" เป็นชื่อเอเย่นต์

เมื่อคุณเห็นข้อความถอดเสียงเริ่มปรากฏขึ้น ให้พูดชื่อเอเย่นต์ออกมาดัง ๆ เพื่อปลุกระบบ (เช่น "Friday")

พูดคำถามของคุณอย่างชัดเจน

จบคำขอของคุณด้วยวลีเพื่อยืนยันให้ระบบดำเนินการ ตัวอย่างวลียืนยัน ได้แก่:
```
"do it", "go ahead", "execute", "run", "start", "thanks", "would ya", "please", "okay?", "proceed", "continue", "go on", "do that", "go it", "do you understand?"
```

## การตั้งค่า Config

ตัวอย่าง config:
```
[MAIN]
is_local = True
provider_name = ollama
provider_model = deepseek-r1:32b
provider_server_address = http://127.0.0.1:11434 # ตัวอย่างสำหรับ Ollama; ใช้ http://127.0.0.1:1234 สำหรับ LM-Studio
agent_name = Friday
recover_last_session = False
save_session = False
speak = False
listen = False

jarvis_personality = False
languages = en zh # รายการภาษา สำหรับ TTS และอาจใช้สำหรับ routing
[BROWSER]
headless_browser = False
stealth_mode = False
```

**คำอธิบายการตั้งค่า `config.ini`:**

*   **ส่วน `[MAIN]`:**
    *   `is_local`: `True` หากใช้ผู้ให้บริการ LLM ในเครื่อง (Ollama, LM-Studio, เซิร์ฟเวอร์ OpenAI-compatible ภายในเครื่อง) หรือเซิร์ฟเวอร์ที่โฮสต์เอง `False` หากใช้ API บนคลาวด์ (OpenAI, Google ฯลฯ)
    *   `provider_name`: ระบุชื่อผู้ให้บริการ LLM
        *   ตัวเลือกในเครื่อง: `ollama`, `lm-studio`, `openai` (สำหรับเซิร์ฟเวอร์ OpenAI-compatible ภายในเครื่อง), `server` (สำหรับเซิร์ฟเวอร์ที่โฮสต์เอง)
        *   ตัวเลือก API: `openai`, `google`, `deepseek`, `huggingface`, `togetherAI`
    *   `provider_model`: ชื่อหรือรหัสโมเดลสำหรับผู้ให้บริการที่เลือก (เช่น `deepseekcoder:6.7b` สำหรับ Ollama, `gpt-3.5-turbo` สำหรับ OpenAI API, `mistralai/Mixtral-8x7B-Instruct-v0.1` สำหรับ TogetherAI)
    *   `provider_server_address`: ที่อยู่ของผู้ให้บริการ LLM ของคุณ
        *   สำหรับผู้ให้บริการในเครื่อง: เช่น `http://127.0.0.1:11434` สำหรับ Ollama, `http://127.0.0.1:1234` สำหรับ LM-Studio
        *   สำหรับประเภท `server`: ที่อยู่ของเซิร์ฟเวอร์ LLM ที่คุณโฮสต์เอง (เช่น `http://your_server_ip:3333`)
        *   สำหรับ API บนคลาวด์ (`is_local = False`): มักไม่จำเป็นหรือเว้นว่างได้ เพราะ endpoint จะถูกจัดการโดย client library
    *   `agent_name`: ชื่อผู้ช่วย AI (เช่น Friday) ใช้เป็นคำกระตุ้นสำหรับ speech-to-text หากเปิดใช้งาน
    *   `recover_last_session`: `True` เพื่อพยายามกู้สถานะ session ก่อนหน้า, `False` เพื่อเริ่มใหม่
    *   `save_session`: `True` เพื่อบันทึกสถานะ session ปัจจุบันสำหรับการกู้คืนในอนาคต, `False` หากไม่ต้องการ
    *   `speak`: `True` เพื่อเปิดใช้เสียงพูดออก (text-to-speech), `False` เพื่อปิด
    *   `listen`: `True` เพื่อเปิดใช้รับเสียงพูดเข้า (speech-to-text เฉพาะ CLI), `False` เพื่อปิด
    *   `work_dir`: **สำคัญ:** โฟลเดอร์ที่ AgenticSeek จะอ่าน/เขียนไฟล์ **ตรวจสอบให้แน่ใจว่าเส้นทางนี้ถูกต้องและเข้าถึงได้ในระบบของคุณ**
    *   `jarvis_personality`: `True` เพื่อใช้ system prompt แบบ "Jarvis-like" (ทดลองใช้), `False` ใช้ prompt มาตรฐาน
    *   `languages`: รายการภาษาคั่นด้วย comma (เช่น `en, zh, fr`) ใช้สำหรับเลือกเสียง TTS (ค่าเริ่มต้นเป็นตัวแรก) และช่วย LLM router หลีกเลี่ยงภาษาที่มีจำนวนมากหรือคล้ายกันมากเกินไปเพื่อประสิทธิภาพของ router
*   **ส่วน `[BROWSER]`:**
    *   `headless_browser`: `True` เพื่อรันเบราว์เซอร์อัตโนมัติแบบไม่มีหน้าต่าง (แนะนำสำหรับโหมด web หรือ non-interactive) `False` เพื่อแสดงหน้าต่างเบราว์เซอร์ (เหมาะสำหรับ CLI หรือ debugging)
    *   `stealth_mode`: `True` เพื่อเปิดมาตรการให้ browser automation ตรวจจับได้ยากขึ้น อาจต้องติดตั้งส่วนขยายเบราว์เซอร์ (เช่น anticaptcha) ด้วยตนเอง

ส่วนนี้สรุปประเภทผู้ให้บริการ LLM ที่รองรับ ตั้งค่าได้ใน `config.ini`

**ผู้ให้บริการในเครื่อง (รันบนฮาร์ดแวร์ของคุณเอง):**

| Provider Name ใน `config.ini` | `is_local` | คำอธิบาย                                                         | ส่วนการตั้งค่า                                                    |
|-------------------------------|------------|-------------------------------------------------------------------|------------------------------------------------------------------|
| `ollama`                      | `True`     | ใช้ Ollama เพื่อให้บริการ LLM ในเครื่อง                          | [ตั้งค่าสำหรับรัน LLM ในเครื่อง](#setup-for-running-llm-locally-on-your-machine) |
| `lm-studio`                   | `True`     | ใช้ LM-Studio เพื่อให้บริการ LLM ในเครื่อง                       | [ตั้งค่าสำหรับรัน LLM ในเครื่อง](#setup-for-running-llm-locally-on-your-machine) |
| `openai` (สำหรับเซิร์ฟเวอร์ในเครื่อง) | `True`     | เชื่อมต่อกับเซิร์ฟเวอร์ OpenAI-compatible ภายในเครื่อง (เช่น llama.cpp) | [ตั้งค่าสำหรับรัน LLM ในเครื่อง](#setup-for-running-llm-locally-on-your-machine) |
| `server`                      | `False`    | เชื่อมต่อกับ AgenticSeek self-hosted LLM server บนเครื่องอื่น       | [ตั้งค่าสำหรับรัน LLM บนเซิร์ฟเวอร์ของคุณเอง](#setup-to-run-the-llm-on-your-own-server) |

**ผู้ให้บริการ API (บนคลาวด์):**

| Provider Name ใน `config.ini` | `is_local` | คำอธิบาย                              | ส่วนการตั้งค่า                                  |
|-------------------------------|------------|----------------------------------------|------------------------------------------------|
| `openai`                      | `False`    | ใช้ OpenAI official API (เช่น GPT-3.5, GPT-4) | [ตั้งค่าสำหรับรันด้วย API](#setup-to-run-with-an-api) |
| `google`                      | `False`    | ใช้ Google Gemini ผ่าน API             | [ตั้งค่าสำหรับรันด้วย API](#setup-to-run-with-an-api) |
| `deepseek`                    | `False`    | ใช้ Deepseek official API              | [ตั้งค่าสำหรับรันด้วย API](#setup-to-run-with-an-api) |
| `huggingface`                 | `False`    | ใช้ Hugging Face Inference API         | [ตั้งค่าสำหรับรันด้วย API](#setup-to-run-with-an-api) |
| `togetherAI`                  | `False`    | ใช้ TogetherAI API สำหรับโมเดล open ต่าง ๆ | [ตั้งค่าสำหรับรันด้วย API](#setup-to-run-with-an-api) |

---
## การแก้ไขปัญหา

หากคุณพบปัญหา ส่วนนี้จะให้คำแนะนำ

# ปัญหาที่ทราบแล้ว

## ปัญหา ChromeDriver

**ตัวอย่างข้อผิดพลาด:** `SessionNotCreatedException: Message: session not created: This version of ChromeDriver only supports Chrome version XXX`

*   **สาเหตุ:** เวอร์ชัน ChromeDriver ที่ติดตั้ง ไม่ตรงกับเวอร์ชันของเบราว์เซอร์ Google Chrome ที่คุณใช้งาน
*   **วิธีแก้ไข:**
    1.  **ตรวจสอบเวอร์ชัน Chrome:** เปิด Google Chrome ไปที่ `Settings > About Chrome` เพื่อดูเวอร์ชัน (เช่น "Version 120.0.6099.110")
    2.  **ดาวน์โหลด ChromeDriver ให้ตรงเวอร์ชัน:**
        *   สำหรับ Chrome เวอร์ชัน 115 ขึ้นไป: ไปที่ [Chrome for Testing (CfT) JSON Endpoints](https://googlechromelabs.github.io/chrome-for-testing/) หาช่อง "stable" และดาวน์โหลด ChromeDriver สำหรับ OS ของคุณที่ตรงกับ major version ของ Chrome
        *   สำหรับเวอร์ชันเก่ากว่า (ไม่ค่อยพบ): อาจหาได้ที่หน้า [ChromeDriver - WebDriver for Chrome](https://chromedriver.chromium.org/downloads)
        *   ภาพตัวอย่างจาก CfT:
            ![Download Chromedriver specific version from Chrome for Testing page](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)
    3.  **ติดตั้ง ChromeDriver:**
        *   ตรวจสอบให้แน่ใจว่า `chromedriver` (หรือ `chromedriver.exe` บน Windows) ที่ดาวน์โหลดมาอยู่ในโฟลเดอร์ที่มีใน PATH ของระบบ (เช่น `/usr/local/bin` บน Linux/macOS หรือโฟลเดอร์สคริปต์ที่เพิ่มใน PATH บน Windows)
        *   หรือวางไว้ใน root directory ของโปรเจกต์ `agenticSeek`
        *   ตรวจสอบว่า driver สามารถ execute ได้ (เช่น `chmod +x chromedriver` บน Linux/macOS)
    4.  ดูรายละเอียดใน [ChromeDriver Installation](#chromedriver-installation) ในคู่มือการติดตั้งหลัก

หากส่วนนี้ยังไม่สมบูรณ์ หรือพบปัญหา ChromeDriver อื่น ๆ ลองค้นหา [GitHub Issues](https://github.com/Fosowl/agenticSeek/issues) หรือแจ้งปัญหาใหม่

`Exception: Failed to initialize browser: Message: session not created: This version of ChromeDriver only supports Chrome version 113
Current browser version is 134.0.6998.89 with binary path`

สิ่งนี้เกิดขึ้นหากเวอร์ชันของเบราว์เซอร์กับ chromedriver ไม่ตรงกัน

คุณต้องไปดาวน์โหลดเวอร์ชันล่าสุดที่นี่:

https://developer.chrome.com/docs/chromedriver/downloads

หากคุณใช้ Chrome เวอร์ชัน 115 หรือใหม่กว่า ให้ไปที่:

https://googlechromelabs.github.io/chrome-for-testing/

และดาวน์โหลด chromedriver ที่ตรงกับ OS ของคุณ

![alt text](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/media/chromedriver_readme.png)

หากส่วนนี้ยังไม่สมบูรณ์ กรุณาแจ้งปัญหา

##  ปัญหา connection adapters

```
Exception: Provider lm-studio failed: HTTP request failed: No connection adapters were found for '127.0.0.1:1234/v1/chat/completions'` (หมายเหตุ: port อาจแตกต่างกัน)
```

*   **สาเหตุ:** `provider_server_address` ใน `config.ini` สำหรับ `lm-studio` (หรือเซิร์ฟเวอร์ OpenAI-compatible อื่น ๆ) ขาด prefix `http://` หรือชี้ไปยัง port ไม่ถูกต้อง
*   **วิธีแก้ไข:**
    *   ตรวจสอบว่าที่อยู่มี `http://` นำหน้า LM-Studio โดยปกติใช้ `http://127.0.0.1:1234`
    *   ตัวอย่างที่ถูกต้องใน `config.ini`: `provider_server_address = http://127.0.0.1:1234` (หรือ port LM-Studio จริงของคุณ)

## SearxNG Base URL ไม่ได้ระบุ

```
raise ValueError("SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.")
ValueError: SearxNG base URL must be provided either as an argument or via the SEARXNG_BASE_URL environment variable.`
```

## คำถามที่พบบ่อย

**ถาม: ต้องการฮาร์ดแวร์แบบไหน?**  

| ขนาดโมเดล | GPU  | หมายเหตุ                                               |
|-----------|--------|-----------------------------------------------------------|
| 7B        | 8GB Vram | ⚠️ ไม่แนะนำ ประสิทธิภาพต่ำ เพี้ยนบ่อย และ planner agent มักล้มเหลว |
| 14B        | 12 GB VRAM (เช่น RTX 3060) | ✅ ใช้งานงานทั่วไปได้ อาจมีปัญหากับ web browsing และ planning |
| 32B        | 24+ GB VRAM (เช่น RTX 4090) | 🚀 สำเร็จในงานส่วนใหญ่ อาจยังมีข้อจำกัดใน task planning |
| 70B+        | 48+ GB Vram | 💪 ยอดเยี่ยม แนะนำสำหรับงานขั้นสูง                |

**ถาม: พบ error ต้องทำอย่างไร?**  

ตรวจสอบให้แน่ใจว่ารัน local (`ollama serve`), `config.ini` ตรงกับผู้ให้บริการ, และติดตั้ง dependencies ครบ หากยังไม่สำเร็จสามารถแจ้งปัญหาได้

**ถาม: รันแบบ local 100% ได้จริงหรือ?**  

ได้ หากใช้ Ollama, lm-studio หรือ server provider ทุกส่วน (speech to text, LLM, text to speech) จะรันบนเครื่อง ตัวเลือก non-local (OpenAI หรือ API อื่น) เป็นทางเลือกเสริม

**ถาม: ทำไมควรใช้ AgenticSeek ทั้งที่มี Manus?**

AgenticSeek มุ่งเน้นอิสระจากระบบภายนอก ให้คุณควบคุม ความเป็นส่วนตัว และประหยัดค่า api มากกว่า

**ถาม: ใครอยู่เบื้องหลังโปรเจกต์นี้?**

โปรเจกต์นี้สร้างโดยผมและเพื่อนอีกสองคน ซึ่งเป็น maintainer และ contributor จากคอมมูนิตี้โอเพ่นซอร์สบน GitHub เราเป็นกลุ่มคนที่มีใจรัก ไม่ใช่สตาร์ทอัพหรือองค์กรใด

บัญชี AgenticSeek บน X ใด ๆ ที่ไม่ใช่บัญชีส่วนตัวของผม (https://x.com/Martin993886460) ถือว่าเป็นการแอบอ้าง

## มีส่วนร่วม

เรากำลังมองหานักพัฒนาเพื่อช่วยปรับปรุง AgenticSeek! ดู open issues หรือ discussion ได้

[Contribution guide](https://raw.githubusercontent.com/Fosowl/agenticSeek/main/docs/CONTRIBUTING.md)

[![Star History Chart](https://api.star-history.com/svg?repos=Fosowl/agenticSeek&type=Date)](https://www.star-history.com/#Fosowl/agenticSeek&Date)

## ผู้ดูแล:

 > [Fosowl](https://github.com/Fosowl) | เวลาปารีส

 > [antoineVIVIES](https://github.com/antoineVIVIES) | เวลาไทเป

 > [steveh8758](https://github.com/steveh8758) | เวลาไทเป

## ขอบคุณพิเศษ:

 > [tcsenpai](https://github.com/tcsenpai) และ [plitc](https://github.com/plitc) สำหรับการช่วยเหลือด้าน backend dockerization

## ผู้สนับสนุน:

ผู้สนับสนุนรายเดือน 5$ ขึ้นไป ปรากฏที่นี่:
- **tatra-labs**
I'm sorry, but I don't see the technical document content you want translated. Please provide the text for Part 4 of 4, and I'll translate it into Thai for you while preserving the Markdown format and relative paths.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---