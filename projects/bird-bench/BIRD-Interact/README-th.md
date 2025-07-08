# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>


<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## 🧸 ภาพรวม

BIRD-INTERACT คือชุดทดสอบแบบอินเทอร์แอคทีฟสำหรับแปลงข้อความเป็น SQL ซึ่ง **นิยามใหม่ของการประเมิน Text-to-SQL ผ่านมุมมองของการโต้ตอบแบบไดนามิก**
สภาพแวดล้อมนี้ผสมผสานฐานความรู้แบบลำดับชั้น เอกสารประกอบฐานข้อมูล และซิมูเลเตอร์ผู้ใช้งานที่ขับเคลื่อนด้วยฟังก์ชัน เพื่อจำลองสภาพแวดล้อมองค์กรที่แท้จริง ครอบคลุมการดำเนินการ **CRUD** อย่างสมบูรณ์
มีโหมดทดสอบที่เข้มข้น 2 แบบ ได้แก่ (1) **Conversational Interaction** แบบพาสซีฟ และ (2) **Agentic Interaction** แบบแอคทีฟ ครอบคลุม 600 งานที่มีการใส่คำอธิบาย (annotated) รวมถึง Business Intelligence (BI), การดำเนินการ CRUD และอื่นๆ โดยแต่ละงานจะมีกรณีทดสอบที่สามารถรันได้จริง
การประเมินทั่วไปจะเกิดการโต้ตอบระหว่างโมเดลกับซิมูเลเตอร์ผู้ใช้ 1,968-5,496 รอบ ในขณะที่โมเดลที่มีเหตุผลล้ำสมัยในปัจจุบันสามารถแก้ไขงานได้เพียง **≈24%** และ **≈18%** เท่านั้น ซึ่งเน้นให้เห็นถึงความท้าทายของชุดทดสอบนี้

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ โหมดการประเมินสองรูปแบบ

BIRD-INTERACT รองรับโหมดการประเมินสองรูปแบบดังที่กล่าวไว้ข้างต้น:

   - **c-Interact**: Conversational Interaction ซึ่งเป็นโหมดพาสซีฟและมีขั้นตอนการทำงานที่ตายตัว สามารถดูโค้ดและรายละเอียดเพิ่มเติมได้ใน `bird_interact_conv`
   - **a-Interact**: Agentic Interaction ซึ่งเป็นโหมดแอคทีฟแบบ embodied โดยขั้นตอนการทำงานจะเป็นแบบไดนามิกและนำโดยโมเดล สามารถดูโค้ดและรายละเอียดเพิ่มเติมได้ใน `bird_interact_agent`


### 🐣 เวอร์ชัน Lite

เราเปิดตัวเวอร์ชัน Lite ของ BIRD-INTERACT ชื่อว่า `bird-interact-lite-exp` ซึ่งประกอบด้วยงานคุณภาพสูงจากสถานการณ์จริงจำนวน 270 งาน สำหรับ PostgreSQL โดยเฉพาะ เหมาะสำหรับการทดลองใช้งานอย่างรวดเร็ว

### 🦜 เวอร์ชันเต็ม

BIRD-INTERACT เวอร์ชันเต็ม `bird-interact-full` เป็นชุดทดสอบที่ครอบคลุม ซึ่งมีงานสำหรับ PostgreSQL จำนวน 600 งาน ครอบคลุมการดำเนินการ SQL และคำถามผู้ใช้หลากหลายรูปแบบ เวอร์ชันเต็มจะเปิดตัวเร็วๆ นี้

### ผลการทดสอบโมเดลบน BIRD-INTERACT Lite

#### 1. **ประสิทธิภาพ c-Interact**
| อันดับ | ชื่อโมเดล         | Normalized Reward | ระดับ        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 Excellent Chat |
| 2    | GPT-4o             | 30.33 | 💎 Good Chat      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 Good Chat      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ Standard       |
| 5    | DeepSeek-R1        | 21.74 | ✨ Standard       |
| 6    | Qwen3              | 20.33 | ⚪ Basic          |
| 7    | DeepSeek-V3        | 15.85 | ⚪ Basic          |

#### 2. **ประสิทธิภาพ a-Interact**
| อันดับ | ชื่อโมเดล         | Budget Parameters* | Avg Turns/Task | Avg Cost (USD)/Task | Normalized Reward | ระดับ            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 Excellent Interaction |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 Good Interaction      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 Good Interaction      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ Standard              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ Standard              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ Basic                 |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ Basic                 |

> \* Budget Parameters: Starting Budget/User Patience Budget วัดโดยใช้สกุลเงินเสมือน *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> ดูรายละเอียดเพิ่มเติมได้ที่ [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)

### Interaction-Time Scaling (ITS)

Interaction-Time Scaling (ITS) คือความสามารถของโมเดลในการเพิ่มประสิทธิภาพสุดท้ายอย่างต่อเนื่องผ่านการโต้ตอบหลายรอบ หากประสิทธิภาพอินเทอร์แอคทีฟนี้สูงกว่าประสิทธิภาพที่คาดหวังของโมเดลในการตอบคำถามที่ถูกกำหนดอย่างชัดเจนในหนึ่งรอบ เราถือว่าโมเดลนั้นเป็นไปตาม **ITS law** เมื่อความอดทนของผู้ใช้เพิ่มขึ้นและจำนวนรอบการโต้ตอบสะสมมากขึ้น ประสิทธิภาพก็จะพัฒนาขึ้นเรื่อยๆ แสดงให้เห็นว่าโมเดลสามารถรักษาการสื่อสารที่มีประสิทธิภาพในบทสนทนายาวได้ ปัจจุบันพบว่า claude-3-7-sonnet เป็นโมเดลเดียวที่สอดคล้องกับ ITS law

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 รายละเอียดชุดข้อมูล

### คำอธิบายชุดข้อมูล

- **Database:** ฐานข้อมูล PostgreSQL ฉบับสมบูรณ์สามารถดาวน์โหลดได้จาก [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) ดูรายละเอียดเพิ่มเติมได้ในหัวข้อ [Quick Eval](#quick-eval)
- **data:** แต่ละอินสแตนซ์ของข้อมูลประกอบด้วยส่วนสำคัญดังนี้:
   - `selected_database`: ชื่อฐานข้อมูล  
   - `query`: คำถามของผู้ใช้ที่ไม่มีความกำกวม  
   - `amb_user_query`: คำถามของผู้ใช้ที่มีการใส่ความกำกวม
   - `user_query_ambiguity`: ความกำกวมที่ถูกใส่เข้าไปในคำถามของผู้ใช้
   - `non_critical_ambiguity`: ความกำกวมที่ไม่สำคัญ เช่น การเรียงลำดับ, limit ฯลฯ
   - `knowledge_ambiguity`: ความคลุมเครือที่เกิดจากความรู้ภายนอกที่ถูกปิดบัง  
   - `sol_sql`: โซลูชัน SQL ที่เป็น ground truth  
   - `preprocess_sql`: คำสั่ง SQL ที่ต้องรันก่อนดำเนินการโซลูชันหรือการทำนาย  
   - `clean_up_sql`: คำสั่ง SQL ที่ต้องรันหลังจากทดสอบเพื่อลบการเปลี่ยนแปลงที่เกิดขึ้นในฐานข้อมูล  
   - `test_cases`: ชุด test case สำหรับตรวจสอบความถูกต้องของ SQL ที่ได้รับการแก้ไข  
   - `follow_up`: คำถามติดตามที่มีการติดป้ายกำกับ  
   - `external_knowledge`: ความรู้ภายนอกที่เกี่ยวข้องกับภารกิจเฉพาะนี้

- **evaluation:** โค้ดสำหรับการประเมินผลมีอยู่ในไดเรกทอรี [`./evaluation`](./evaluation)
- **Curated by:** ทีม BIRD & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### การใช้งานชุดข้อมูล

เพื่อหลีกเลี่ยงการรั่วไหลของข้อมูลโดยการดึงข้อมูลอัตโนมัติ เราไม่ได้รวม sql คำตอบ GT และ test case ไว้ในข้อมูลด้วย  
กรุณาส่งอีเมลมาที่ [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) พร้อมแท็ก `[bird-interact-lite GT&Test Cases]` ในหัวข้อ เพื่อรับชุดข้อมูลฉบับเต็ม ซึ่งจะถูกส่งให้อัตโนมัติ


<!-- ### ใช้งานชุดข้อมูลจาก HuggingFace

คุณสามารถดาวน์โหลดชุดข้อมูลจาก HuggingFace โดยใช้คำสั่งต่อไปนี้:
```bash
from datasets import load_dataset
# โหลดเวอร์ชัน flash ของชุดข้อมูล
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# โหลดเวอร์ชันเต็มของชุดข้อมูล (เร็วๆ นี้)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```

หรือคุณสามารถใช้สคริปต์ที่เตรียมไว้เพื่อดาวน์โหลดชุดข้อมูลเวอร์ชันเต็มและแยกออกเป็นแต่ละ dialect
```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # ไฟล์ JSONL อินพุต (อาจเว้นว่างได้หากต้องการดาวน์โหลดจาก HuggingFace)
  --output_folder path/to/output_dir # โฟลเดอร์ปลายทางสำหรับไฟล์ที่แยก
``` -->

## โครงสร้างโฟลเดอร์
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
รายละเอียดเกี่ยวกับการใช้งาน **a-interact** สามารถดูได้ที่ `./bird_interact_agent/README.md` และ **c-interact** สามารถดูได้ที่ `./bird_interact_conv/README.md`


## 📋 รายการสิ่งที่ต้องทำ

- [x] ปล่อยเวอร์ชัน lite, bird-interact-lite (270)
- [x] ปล่อยเวอร์ชันสนทนา, bird-interact-conv
- [x] ปล่อยเวอร์ชัน agent, bird-interact-agent
- [ ] ปล่อยเวอร์ชันเต็ม bird-interact-full (600)
- [ ] SFT / RL และ User Simulator

## จัดทำโดย:
ทีม BIRD & Google Cloud

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---