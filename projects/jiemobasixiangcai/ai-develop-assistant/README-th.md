# 🚀 MCP AI开发助手

> เครื่องมือ MCP สำหรับช่วยนักพัฒนา AI ในการวิเคราะห์ความต้องการแบบอัจฉริยะและออกแบบสถาปัตยกรรม

## ✨ คุณสมบัติหลัก

- **การชี้แจงความต้องการอัจฉริยะ**: ระบุประเภทโครงการโดยอัตโนมัติ สร้างคำถามที่ตรงประเด็น
- **การจัดการแบบรับรู้สาขา**: ติดตามเป้าหมายโครงการ การออกแบบฟังก์ชัน ความชอบทางเทคนิค การออกแบบ UI ฯลฯ
- **การสร้างสถาปัตยกรรมอัตโนมัติ**: สร้างข้อเสนอแนะสถาปัตยกรรมเทคนิคจากความต้องการที่ครบถ้วน
- **การจัดเก็บอย่างถาวร**: บันทึกผลการวิเคราะห์โดยอัตโนมัติ รองรับการส่งออกเอกสาร

## 📁 การตั้งค่าอย่างรวดเร็ว

### การตั้งค่ารุ่นเก่า
1. **โคลนโค้ด**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **แนะนำให้ใช้ virtual environment**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **ติดตั้ง dependencies**
   ```bash
   pip install -r requirements.txt
   ```

4. **ตำแหน่งไฟล์ config**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **เพิ่มการตั้งค่า**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **รีสตาร์ท Claude Desktop**

### การตั้งค่ารุ่นใหม่
#### 🔧 เครื่องมือหลัก
1. **start_new_project** - เริ่มโครงการใหม่
2. **create_requirement_blueprint** - สร้าง Blueprint ความต้องการ
3. **requirement_clarifier** - รับข้อเสนอแนะการชี้แจงความต้องการ
4. **save_clarification_tasks** - บันทึกงานชี้แจง
5. **update_branch_status** - อัปเดตสถานะสาขา
6. **requirement_manager** - ตัวจัดการเอกสารความต้องการ
7. **check_architecture_prerequisites** - ตรวจสอบเงื่อนไขเบื้องต้นของสถาปัตยกรรม
8. **get_architecture_design_prompt** - รับข้อเสนอแนะการออกแบบสถาปัตยกรรม
9. **save_generated_architecture** - บันทึกสถาปัตยกรรมที่สร้างขึ้น
10. **export_final_document** - ส่งออกเอกสารฉบับสมบูรณ์
11. **view_requirements_status** - ดูสถานะความต้องการ

#### การตั้งค่า (เชื่อมต่อโดยตรงแบบ remote ให้คัดลอกไปยังเครื่องมือของคุณ แล้วแทนที่ MCP_STORAGE_DIR ด้วยไดเรกทอรีในเครื่องของคุณ)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 ขั้นตอนการใช้งาน

### ขั้นตอนพื้นฐาน

1. **การชี้แจงความต้องการ**
   ```
   requirement_clarifier("我要做一个在线教育平台")
   ```

2. **การจัดการความต้องการ**
   ```
   requirement_manager("目标用户：学生和教师", "项目概述")
   ```

3. **ดูสถานะ**
   ```
   view_requirements_status()
   ```
4. **ออกแบบสถาปัตยกรรม**
   ```
   architecture_designer("สถาปัตยกรรมแพลตฟอร์มการศึกษาออนไลน์")
   ```

5. **ส่งออกเอกสาร**
   ```
   export_final_document()
   ```

## 🚀 เริ่มต้นใช้งาน

### เริ่มต้นอย่างรวดเร็ว
1. **กำหนดค่า Claude Desktop** (ดูวิธีการกำหนดค่าด้านบน)
2. **รีสตาร์ท Claude Desktop**
3. **เริ่มการวิเคราะห์ความต้องการอัจฉริยะ**：
   ```
   requirement_clarifier("อธิบายแนวคิดโครงการของคุณ")
   ```
4. **ทำตามคำแนะนำอัจฉริยะของ AI** เพื่อปรับแต่งแต่ละสาขาความต้องการอย่างเป็นขั้นตอน
5. **ส่งออกเอกสารฉบับสมบูรณ์**：
   ```
   export_final_document()
   ```

### แนวปฏิบัติที่ดีที่สุด
- 💬 **เชื่อมั่นในการจัดการสาขาของ AI**: ให้ AI แนะนำคุณจนเสร็จสิ้นทุกสาขาความต้องการ
- 🎯 **แสดงความชอบอย่างชัดเจน**: ระบุความชอบของคุณอย่างชัดเจนในเรื่องการเลือกเทคโนโลยี สไตล์ UI ฯลฯ
- 📊 **ตรวจสอบสถานะเป็นระยะ**: ใช้ `view_requirements_status` เพื่อติดตามความคืบหน้า
- 🤖 **อนุญาตให้ AI ตัดสินใจเมื่อเหมาะสม**: สำหรับส่วนที่ไม่แน่ใจ สามารถบอกว่า "ใช้วิธีมาตรฐาน"

---

**🎯 ตอนนี้คุณมีผู้ช่วยพัฒนา AI อัจฉริยะอย่างแท้จริง ที่จะจดจำทุกรายละเอียดและนำทางคุณจนวิเคราะห์ความต้องการได้ครบถ้วน!**

## 💬 กลุ่มพูดคุย

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="กลุ่มพูดคุย">
<br>
กลุ่มพูดคุย
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---