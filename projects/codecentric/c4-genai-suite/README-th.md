# c4 GenAI Suite

แอปพลิเคชันแชทบอท AI พร้อมการผสานรวม Model Context Provider (MCP) ขับเคลื่อนด้วย Langchain และรองรับการใช้งานกับโมเดลภาษาขนาดใหญ่ (LLMs) และโมเดล Embedding ทุกรูปแบบ

ผู้ดูแลระบบสามารถสร้างผู้ช่วยที่มีความสามารถแตกต่างกันได้โดยเพิ่มส่วนขยาย เช่น บริการ RAG (Retrieval-Augmented Generation) หรือเซิร์ฟเวอร์ MCP แอปพลิเคชันนี้สร้างขึ้นด้วยเทคโนโลยีสมัยใหม่ รวมถึง React, NestJS และ Python FastAPI สำหรับบริการ REI-S

ผู้ใช้สามารถโต้ตอบกับผู้ช่วยได้ผ่านอินเทอร์เฟซที่ใช้งานง่าย ขึ้นอยู่กับการกำหนดค่าของผู้ช่วย ผู้ใช้อาจสามารถถามคำถาม อัปโหลดไฟล์ของตนเอง หรือใช้ฟีเจอร์อื่น ๆ ผู้ช่วยจะโต้ตอบกับผู้ให้บริการ LLM ต่าง ๆ เพื่อให้ตอบกลับตามส่วนขยายที่กำหนดไว้ ข้อมูลบริบทที่ได้จากส่วนขยายที่กำหนดค่าจะช่วยให้ผู้ช่วยสามารถตอบคำถามเฉพาะทางและให้ข้อมูลที่เกี่ยวข้องได้

แอปพลิเคชันนี้ถูกออกแบบมาให้เป็นโมดูลาร์และขยายต่อได้ง่าย ช่วยให้ผู้ใช้สามารถสร้างผู้ช่วยที่มีความสามารถต่าง ๆ ได้ด้วยการเพิ่มส่วนขยาย

![short demo video of basic usage](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## คุณสมบัติ

### โมเดลภาษาขนาดใหญ่ (LLM) และโมเดลมัลติโหมด

c4 GenAI Suite รองรับโมเดลหลากหลายรูปแบบโดยตรงอยู่แล้ว และหากยังไม่รองรับโมเดลที่คุณต้องการ ก็สามารถเขียนส่วนขยายเพื่อรองรับได้อย่างง่ายดาย

* โมเดลที่รองรับ OpenAI
* โมเดล Azure OpenAI
* โมเดล Bedrock
* โมเดล Google GenAI
* โมเดลที่รองรับ Ollama
### Retrieval Augmented Generation (RAG)

c4 GenAI Suite ประกอบด้วย REI-S ซึ่งเป็นเซิร์ฟเวอร์สำหรับเตรียมไฟล์เพื่อให้ LLM ใช้งาน

* REI-S, เซิร์ฟเวอร์ RAG ที่ผสานรวมแบบกำหนดเอง
  * Vector stores
    * pgvector
    * Azure AI Search
  * Embedding models
    * Embeddings ที่เข้ากันได้กับ OpenAI
    * Azure OpenAI embeddings
    * Embeddings ที่เข้ากันได้กับ Ollama
  * รูปแบบไฟล์:
    * pdf, docx, pptx, xlsx, ...
    * ถอดเสียงไฟล์เสียง (ผ่าน Whisper)

### Extensions

c4 GenAI Suite ถูกออกแบบมาเพื่อรองรับการขยายฟังก์ชัน การเขียนส่วนขยายทำได้ง่าย รวมถึงการใช้งานเซิร์ฟเวอร์ MCP ที่มีอยู่แล้วก็ทำได้ง่ายเช่นกัน

* เซิร์ฟเวอร์ Model Context Protocol (MCP)
* ระบบ systemprompt ที่กำหนดเอง
* Bing Search
* เครื่องคิดเลข
## เริ่มต้นใช้งาน

### การใช้ Docker-Compose

- รันคำสั่ง `docker compose up` ใน root ของโปรเจค
- เปิด [แอปพลิเคชัน](http://localhost:3333) ในเบราว์เซอร์ โดยข้อมูลเข้าสู่ระบบเริ่มต้นคือ user `admin@example.com` และรหัสผ่าน `secret`

![video showing assistant configuration](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### การใช้ Helm & Kubernetes

สำหรับการปรับใช้งานในสภาพแวดล้อม Kubernetes โปรดดูที่ [README ของ Helm Chart ของเรา](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md)

### การตั้งค่า Assistants และ Extensions

c4 GenAI Suite จะเน้นที่ *assistants*
แต่ละ assistant จะประกอบด้วยชุดของ extension ซึ่งกำหนดโมเดล LLM และเครื่องมือที่สามารถใช้งานได้

- ในพื้นที่ผู้ดูแลระบบ (คลิกที่ชื่อผู้ใช้ด้านซ้ายล่าง) ไปที่ [ส่วน assistants](http://localhost:3333/admin/assistants)
- เพิ่ม assistant ด้วยปุ่มสีเขียว `+` ข้างชื่อหัวข้อ เลือกชื่อและคำอธิบาย
- เลือก assistant ที่สร้างขึ้นแล้วคลิกปุ่มสีเขียว `+ Add Extension`
- เลือกโมเดลและกรอกข้อมูล credential
- ใช้ปุ่ม `Test` เพื่อตรวจสอบการทำงาน และ `save`

ตอนนี้คุณสามารถกลับไปที่ [หน้าสนทนา](http://localhost:3333/chat) (คลิกที่ `c4 GenAI Suite` มุมบนซ้าย) และเริ่มต้นการสนทนาใหม่กับ assistant ของคุณ

> [!TIP]
> `docker-compose` ของเรามี Ollama แบบ local ซึ่งทำงานบน CPU คุณสามารถใช้สำหรับการทดสอบอย่างรวดเร็ว แต่จะทำงานช้าและคุณอาจต้องการใช้โมเดลอื่น หากคุณต้องการใช้ ให้สร้าง extension ของโมเดลดังนี้ใน Assistant ของคุณ
> * Extension: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Model: `llama3.2`

### โปรโตคอลบริบทโมเดล (MCP) [ไม่บังคับ]

ใช้เซิร์ฟเวอร์ MCP ใดๆ ที่มีอินเทอร์เฟซ `sse` พร้อมกับส่วนขยาย `MCP Tools` (หรือใช้ `mcp-tool-as-server` ของเราเป็นพร็อกซีหน้ากับเซิร์ฟเวอร์ MCP แบบ `stdio`)
แต่ละเซิร์ฟเวอร์ MCP สามารถกำหนดค่ารายละเอียดได้เป็นส่วนขยาย

### Retrieval Augmented Generation (RAG) / การค้นหาไฟล์ [ไม่บังคับ]

ใช้เซิร์ฟเวอร์ RAG `REI-S` ของเราเพื่อค้นหาไฟล์ที่ผู้ใช้ให้มา เพียงแค่กำหนดค่าส่วนขยาย `Search Files` สำหรับผู้ช่วย
กระบวนการนี้อธิบายไว้โดยละเอียดใน [ไดเรกทอรีย่อย `services/reis`](services/reis/#example-configuration-in-c4)

## การมีส่วนร่วม & การพัฒนา

* ดู [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) สำหรับแนวทางการมีส่วนร่วม
* สำหรับการเริ่มต้นใช้งานสำหรับนักพัฒนา ดู [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md)

## ส่วนประกอบหลัก

แอปพลิเคชันนี้ประกอบด้วย **Frontend** , **Backend** และบริการ **REI-S**
┌──────────┐
│   ผู้ใช้   │
└─────┬────┘
      │ เข้าถึง
      ▼
┌──────────┐
│ ส่วนหน้า │
└─────┬────┘
      │ เข้าถึง
      ▼
┌──────────┐     ┌─────────────────┐
│ ส่วนหลัง │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ เข้าถึง
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ แบบฝังโมเดล     │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  เวกเตอร์สโตร์  │
└──────────┘     └─────────────────┘
```
### Frontend

Frontend ถูกสร้างขึ้นด้วย React และ TypeScript โดยมีอินเทอร์เฟซที่ใช้งานง่ายสำหรับการโต้ตอบกับ backend และบริการ REI-S ประกอบด้วยฟีเจอร์สำหรับจัดการผู้ช่วย (assistants), ส่วนขยาย (extensions) และฟังก์ชันแชท

> แหล่งที่มา: `/frontend`

### Backend

Backend พัฒนาด้วย NestJS และ TypeScript ทำหน้าที่เป็นชั้น API หลักของแอปพลิเคชัน รับและประมวลผลคำขอจาก frontend และโต้ตอบกับผู้ให้บริการ llm เพื่อรองรับฟังก์ชันแชท Backend ยังจัดการผู้ช่วยและส่วนขยายของพวกเขา ช่วยให้ผู้ใช้สามารถกำหนดค่าและใช้งานโมเดล AI ต่าง ๆ สำหรับการแชทได้

นอกจากนี้ Backend ยังจัดการการยืนยันตัวผู้ใช้ และสื่อสารกับบริการ REI-S สำหรับการจัดทำดัชนีไฟล์และดึงข้อมูลไฟล์

สำหรับการจัดเก็บข้อมูล Backend ใช้ฐานข้อมูล **PostgreSQL**

> แหล่งที่มา: `/backend`

### REI-S

REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) เป็นเซิร์ฟเวอร์ที่พัฒนาด้วย Python ซึ่งให้ความสามารถ RAG (Retrieval-Augmented Generation) เบื้องต้น โดยรองรับการแยกเนื้อหาไฟล์, การจัดทำดัชนี และการค้นหา ช่วยให้แอปพลิเคชันสามารถจัดการชุดข้อมูลขนาดใหญ่ได้อย่างมีประสิทธิภาพ บริการ REI-S ถูกออกแบบมาให้ทำงานร่วมกับ backend ได้อย่างไร้รอยต่อ โดยให้ข้อมูลที่จำเป็นสำหรับฟังก์ชันแชทและการค้นหาไฟล์

REI-S รองรับ Azure AI Search และ pgvector สำหรับการจัดเก็บเวกเตอร์ ช่วยให้สามารถเลือกใช้รูปแบบการดึงข้อมูลที่ยืดหยุ่นและขยายขนาดได้ บริการนี้สามารถกำหนดค่าได้โดยใช้ environment variables เพื่อระบุประเภทของ vector store และรายละเอียดการเชื่อมต่อ

> แหล่งที่มา: `/services/reis`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---