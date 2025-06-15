# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 หากคุณชอบโปรเจกต์ของเรา กรุณากดดาว ⭐ บน GitHub เพื่อรับข่าวสารล่าสุด</h5>
**MemoryOS** ได้รับการออกแบบมาเพื่อเป็นระบบปฏิบัติการหน่วยความจำสำหรับ AI ตัวแทนส่วนบุคคล ช่วยให้การโต้ตอบมีความต่อเนื่อง เป็นส่วนบุคคล และรับรู้บริบทมากขึ้น โดยได้รับแรงบันดาลใจจากหลักการจัดการหน่วยความจำในระบบปฏิบัติการ และใช้โครงสร้างจัดเก็บแบบลำดับชั้นซึ่งมี 4 โมดูลหลัก ได้แก่ การจัดเก็บ (Storage), การอัปเดต (Updating), การดึงข้อมูล (Retrieval), และการสร้าง (Generation) เพื่อให้ได้การจัดการหน่วยความจำที่ครอบคลุมและมีประสิทธิภาพ บน LoCoMo benchmark โมเดลนี้สามารถเพิ่มค่าเฉลี่ยของ F1 และ BLEU-1 ได้ถึง **49.11%** และ **46.18%** ตามลำดับ

## 📣 ข่าวล่าสุด
*   *<mark>[ใหม่]</mark>* 🔥  **[2025-06-15]**:🛠️ เปิดโอเพนซอร์ส **MemoryOS-MCP** แล้ว! สามารถตั้งค่าบนไคลเอนต์เอเจนต์เพื่อการผสานรวมและปรับแต่งได้อย่างไร้รอยต่อ [👉 查看](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: เปิดตัวเวอร์ชันแรกของ **MemoryOS**! รองรับหน่วยความจำบุคลิกภาพระยะสั้น กลาง และยาว พร้อมอัปเดตโปรไฟล์ผู้ใช้และความรู้โดยอัตโนมัติ

## เดโม
[![Watch the video](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## สถาปัตยกรรมระบบ
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## โครงสร้างโปรเจกต์

```
memoryos/
├── __init__.py            # เริ่มต้นแพ็กเกจ MemoryOS
├── __pycache__/           # โฟลเดอร์แคชของ Python (สร้างอัตโนมัติ)
├── long_term.py           # จัดการหน่วยความจำระยะยาว (โปรไฟล์ผู้ใช้, ความรู้)
├── memoryos.py            # คลาสหลักของ MemoryOS ควบคุมทุกองค์ประกอบ
├── mid_term.py            # จัดการหน่วยความจำระยะกลาง สรุปการโต้ตอบระยะสั้น
├── prompts.py             # รวบรวม prompt ที่ใช้กับ LLM (เช่น สรุป วิเคราะห์)
├── retriever.py           # ดึงข้อมูลที่เกี่ยวข้องจากทุกชั้นหน่วยความจำ
├── short_term.py          # จัดการหน่วยความจำระยะสั้นสำหรับการโต้ตอบล่าสุด
├── updater.py             # ประมวลผลการอัปเดตหน่วยความจำ รวมถึงการเลื่อนข้อมูลระหว่างชั้น
└── utils.py               # ฟังก์ชันอรรถประโยชน์ที่ใช้ทั่วไลบรารี
```

## วิธีการทำงาน

1.  **เริ่มต้นระบบ:** `Memoryos` จะถูกตั้งค่าด้วย user id, assistant id, API key, พาธจัดเก็บข้อมูล และการตั้งค่าความจุ/เกณฑ์ต่าง ๆ โดยจะสร้างที่จัดเก็บแยกสำหรับผู้ใช้และผู้ช่วยแต่ละคน
2.  **เพิ่มความทรงจำ:** อินพุตของผู้ใช้และคำตอบของตัวแทนจะถูกเพิ่มเป็นคู่ QA ซึ่งจะถูกเก็บในหน่วยความจำระยะสั้นก่อน
3.  **ประมวลผลระยะสั้นสู่ระยะกลาง:** เมื่อหน่วยความจำระยะสั้นเต็ม โมดูล `Updater` จะประมวลผลการโต้ตอบเหล่านี้ สรุปออกเป็นเซกเมนต์ที่มีความหมายและเก็บในหน่วยความจำระยะกลาง
4.  **วิเคราะห์ระยะกลาง & อัปเดต LPM:** เซกเมนต์หน่วยความจำระยะกลางจะสะสม “ความร้อน” (heat) ตามความถี่ในการเข้าชมและความยาวการโต้ตอบ เมื่อความร้อนเกินเกณฑ์ จะมีการวิเคราะห์เนื้อหา:
    *   ดึงข้อมูลเชิงลึกของโปรไฟล์ผู้ใช้เพื่ออัปเดตโปรไฟล์ระยะยาว
    *   ข้อเท็จจริงเฉพาะของผู้ใช้จะถูกเพิ่มในฐานความรู้ระยะยาวของผู้ใช้
    *   ข้อมูลที่เกี่ยวข้องสำหรับผู้ช่วยจะถูกเพิ่มในฐานความรู้ระยะยาวของผู้ช่วย
5.  **สร้างคำตอบ:** เมื่อได้รับคำถามผู้ใช้:
    *   โมดูล `Retriever` จะดึงบริบทที่เกี่ยวข้องจากประวัติระยะสั้น เซกเมนต์ระยะกลาง โปรไฟล์และความรู้ของผู้ใช้ รวมถึงฐานความรู้ของผู้ช่วย
    *   ใช้บริบททั้งหมดนี้ร่วมกับคำถามของผู้ใช้ในการสร้างคำตอบที่สอดคล้องและมีข้อมูลผ่าน LLM

## MemoryOS_PYPI เริ่มต้นใช้งาน

### ข้อกำหนดเบื้องต้น

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### การติดตั้ง

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### การใช้งานเบื้องต้น

```python

import os
from memoryos import Memoryos

# --- การตั้งค่าพื้นฐาน ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # เปลี่ยนเป็นคีย์ของคุณ
BASE_URL = ""  # ไม่บังคับ: หากใช้ OpenAI endpoint แบบกำหนดเอง
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS Simple Demo")
    
    # 1. เริ่มต้น MemoryOS
    print("Initializing MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("MemoryOS initialized successfully!\n")
    except Exception as e:
        print(f"Error: {e}")
        return

    # 2. เพิ่มข้อมูลความทรงจำเบื้องต้น
    print("Adding some memories...")
    
    memo.add_memory(
        user_input="Hi! I'm Tom, I work as a data scientist in San Francisco.",
        agent_response="Hello Tom! Nice to meet you. Data science is such an exciting field. What kind of data do you work with?"
    )
     
    test_query = "What do you remember about my job?"
    print(f"User: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"Assistant: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP เริ่มต้นใช้งาน
### 🔧 เครื่องมือหลัก

#### 1. `add_memory`
บันทึกเนื้อหาการสนทนาระหว่างผู้ใช้และผู้ช่วย AI ลงในระบบหน่วยความจำ เพื่อสร้างประวัติการสนทนาและบริบทที่ต่อเนื่อง

#### 2. `retrieve_memory`
ดึงบทสนทนาเดิม ความชื่นชอบ และข้อมูลความรู้ที่เกี่ยวข้องจากระบบหน่วยความจำตามคำถาม ช่วยให้ผู้ช่วย AI เข้าใจความต้องการและพื้นหลังของผู้ใช้

#### 3. `get_user_profile`
รับโปรไฟล์ผู้ใช้ที่สร้างจากการวิเคราะห์บทสนทนาเดิม รวมถึงลักษณะนิสัย ความสนใจ และพื้นความรู้ที่เกี่ยวข้อง

### 1. ติดตั้ง dependencies
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. การตั้งค่า

แก้ไข `config.json`：
```json
{
  "user_id": "your_user_id",
  "openai_api_key": "your_openai_api_key",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. เริ่มต้นเซิร์ฟเวอร์
```bash
python server_new.py --config config.json
```
### 4. ทดสอบ
```bash
python test_comprehensive.py
```
### 5. ตั้งค่าบน Cline และลูกค้าอื่น ๆ
คัดลอกไฟล์ mcp.json ไปให้ถูกที่ และตรวจสอบว่า path ของไฟล์ถูกต้อง
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#ควรเปลี่ยนเป็น Python interpreter ของ virtual environment ที่คุณใช้
```
## การมีส่วนร่วม

ยินดีรับข้อเสนอแนะและ pull request ทุกประเภท!

## การอ้างอิง
หากต้องการอ่านรายละเอียดเพิ่มเติม กรุณาคลิกที่นี่: [อ่านฉบับเต็ม](https://arxiv.org/abs/2506.06326)

หากคุณพบว่าโปรเจกต์นี้เป็นประโยชน์ กรุณาอ้างอิงบทความของเรา:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## ติดต่อเรา
百家AI เป็นกลุ่มวิจัยที่ได้รับการดูแลโดยรองศาสตราจารย์ Bai Ting จากมหาวิทยาลัย Beijing University of Posts and Telecommunications มุ่งมั่นสร้างสมองที่อัดแน่นด้วยอารมณ์และความทรงจำที่เป็นเลิศสำหรับมนุษย์บนพื้นฐานซิลิคอน<br>
ความร่วมมือและข้อเสนอแนะ: baiting@bupt.edu.cn<br>
ขอเชิญติดตามบัญชีทางการ百家Agentใน WeChat Official Account และกลุ่ม WeChat เพื่อแลกเปลี่ยนความรู้ร่วมกัน!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="百家Agent公众号" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="微信群二维码" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---