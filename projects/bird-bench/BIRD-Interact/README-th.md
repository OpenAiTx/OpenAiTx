
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

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

## ข่าวสาร
- [2025-08-22] **แก้ไขข้อบกพร่อง**: ในโค้ด Bird-Interact-Agent เราได้แก้ไขข้อผิดพลาดที่เมื่อประเมิน SQL ในเฟสที่ 2 SQL ที่ถูกเก็บไว้จากเฟสที่ 1 ไม่สามารถรันได้สำเร็จ ส่งผลให้ความสำเร็จของเฟสที่ 2 ลดลง ข้อบกพร่องนี้มีผลเฉพาะกับงานที่ SQL ในเฟสแรกมีการดำเนินการกับฐานข้อมูล เช่น CREATE table เป็นต้น

## 🧸 ภาพรวม

BIRD-INTERACT เป็นชุดข้อมูลทดสอบแบบ interactive สำหรับ text-to-SQL ซึ่ง **นิยามใหม่การประเมิน Text-to-SQL ผ่านมุมมองของการโต้ตอบแบบไดนามิก**.
สภาพแวดล้อมนี้ผสมผสานฐานความรู้แบบลำดับชั้น เอกสารฐานข้อมูล และซิมูเลเตอร์ผู้ใช้งานที่ขับเคลื่อนด้วยฟังก์ชั่น เพื่อจำลองสภาพแวดล้อมองค์กรจริงในกระบวนการ **CRUD** อย่างครบถ้วน.
มีโหมดทดสอบที่เข้มงวด 2 แบบ: (1) **Conversational Interaction** แบบ passive และ (2) **Agentic Interaction** แบบ active ครอบคลุมงานที่มีการใส่คำอธิบาย 600 งาน เช่น Business Intelligence (BI), การดำเนินการ CRUD ฯลฯ โดยแต่ละงานมี test cases ที่รันได้จริงดูแล.
การประเมินทั่วไปจะเกิดการโต้ตอบระหว่างโมเดลกับซิมูเลเตอร์ผู้ใช้ 1,968-5,496 รอบ ขณะที่โมเดล reasoning ระดับสูงสุดยังแก้ไขงานได้เพียง **≈24%** และ **≈18%** ของงานทั้งหมด ซึ่งสะท้อนถึงความท้าทายของชุดข้อมูลนี้

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ โหมดการประเมิน 2 รูปแบบ

BIRD-INTERACT รองรับโหมดการประเมิน 2 รูปแบบดังที่กล่าวข้างต้น:

   - **c-Interact**: Conversational Interaction เป็นโหมด passive ที่ workflow ถูกกำหนดตายตัว โค้ดและข้อมูลรายละเอียดอยู่ใน `bird_interact_conv`.
   - **a-Interact**: Agentic Interaction เป็นโหมด embodied active ที่ workflow มีความไดนามิกและนำโดยโมเดล โค้ดและข้อมูลรายละเอียดอยู่ใน `bird_interact_agent`.


### 🐣 เวอร์ชัน Lite

เรากำลังเปิดตัวเวอร์ชัน Lite ของ BIRD-INTERACT, `bird-interact-lite-exp` ซึ่งประกอบด้วย 270 งานคุณภาพสูงจากสถานการณ์จริงสำหรับ PostgreSQL เหมาะสำหรับการทดลองอย่างรวดเร็ว

### 🦜 เวอร์ชันเต็ม

เวอร์ชันเต็มของ BIRD-INTERACT, `bird-interact-full` เป็นเกณฑ์วัดผลที่ครอบคลุม 600 งานสำหรับ PostgreSQL ครอบคลุมการดำเนินการ SQL และคำถามของผู้ใช้อย่างหลากหลาย เวอร์ชันเต็มกำลังจะเปิดตัวเร็วๆ นี้

### ผลการทดสอบโมเดลบน BIRD-INTERACT Lite

#### 1. **c-Interact** ประสิทธิภาพ
| อันดับ | ชื่อโมเดล         | คะแนน Normalized Reward | ระดับ        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04 | 🏆 แชทยอดเยี่ยม |
| 2    | GPT-4o             | 30.33 | 💎 แชทดีมาก      |
| 3    | Gemini-2.0-flash   | 27.41 | 💎 แชทดีมาก      |
| 4    | Claude-3.7-sonnet  | 26.60 | ✨ มาตรฐาน       |
| 5    | DeepSeek-R1        | 21.74 | ✨ มาตรฐาน       |
| 6    | Qwen3              | 20.33 | ⚪ พื้นฐาน       |
| 7    | DeepSeek-V3        | 15.85 | ⚪ พื้นฐาน       |

#### 2. **a-Interact** ประสิทธิภาพ
| อันดับ | ชื่อโมเดล         | พารามิเตอร์งบประมาณ* | ขั้นตอนเฉลี่ย/งาน | ค่าใช้จ่ายเฉลี่ย (USD)/งาน | คะแนน Normalized Reward | ระดับ            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 ปฏิสัมพันธ์ยอดเยี่ยม |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 ปฏิสัมพันธ์ดีมาก      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 ปฏิสัมพันธ์ดีมาก      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ มาตรฐาน              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ มาตรฐาน              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ พื้นฐาน               |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ พื้นฐาน               |

> \* พารามิเตอร์งบประมาณ: งบประมาณเริ่มต้น/งบประมาณความอดทนของผู้ใช้ วัดด้วยสกุลเงินเสมือน *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> ดูรายละเอียดเพิ่มเติมที่ [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)

### การปรับสเกลเวลาปฏิสัมพันธ์ (ITS)

การปรับสเกลเวลาปฏิสัมพันธ์ (ITS) หมายถึงความสามารถของโมเดลในการเพิ่มประสิทธิภาพปลายทางอย่างต่อเนื่องผ่านการโต้ตอบหลายรอบ เมื่อประสิทธิภาพปฏิสัมพันธ์นี้เหนือกว่าประสิทธิภาพแบบรอบเดียวของโมเดลในงานที่ถูกระบุไว้อย่างสมบูรณ์และชัดเจน จะถือว่าโมเดลนั้นเป็นไปตาม **กฎ ITS** เมื่อความอดทนของผู้ใช้เพิ่มขึ้นและจำนวนรอบการโต้ตอบสะสมมากขึ้น ประสิทธิภาพก็จะเพิ่มขึ้นต่อเนื่อง แสดงว่าโมเดลสามารถสื่อสารได้อย่างมีประสิทธิภาพในบทสนทนาระยะยาว ปัจจุบันพบว่าเฉพาะ claude-3-7-sonnet ที่ผ่านกฎ ITS

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 รายละเอียดชุดข้อมูล

### คำอธิบายชุดข้อมูล

- **ฐานข้อมูล:** ฐานข้อมูล PostgreSQL ฉบับสมบูรณ์สามารถดาวน์โหลดได้จาก [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) ดูรายละเอียดเพิ่มเติมได้ในส่วน [Quick Eval](#quick-eval)
- **data:** แต่ละข้อมูลประกอบด้วยส่วนหลักดังต่อไปนี้:
   - `selected_database`: ชื่อฐานข้อมูล  
   - `query`: คำถามของผู้ใช้ที่ชัดเจน  
   - `amb_user_query`: คำถามผู้ใช้ที่มีการใส่ความคลุมเครือ
   - `user_query_ambiguity`: ความคลุมเครือที่ถูกใส่ในคำถามผู้ใช้
   - `non_critical_ambiguity`: ความคลุมเครือที่ไม่สำคัญ เช่น การเรียงลำดับ, ขีดจำกัด ฯลฯ
   - `knowledge_ambiguity`: ความคลุมเครือที่เกิดจากการปกปิดความรู้ภายนอก 
   - `sol_sql`: คำตอบ SQL ที่เป็นความจริง  
   - `preprocess_sql`: คำสั่ง SQL ที่ต้องทำก่อนรันคำตอบหรือการทำนาย  
   - `clean_up_sql`: คำสั่ง SQL ที่ต้องทำหลังจากทดสอบเพื่อย้อนกลับการเปลี่ยนแปลงที่เกิดขึ้นกับฐานข้อมูล  
   - `test_cases`: ชุดกรณีทดสอบเพื่อยืนยันความถูกต้องของ SQL ที่ได้รับการแก้ไข
   - `follow_up`: คำถามติดตามที่ติดป้ายกำกับไว้
   - `external_knowledge`: ความรู้ภายนอกที่เกี่ยวข้องกับภารกิจเฉพาะ

- **evaluation:** โค้ดสำหรับประเมินอยู่ในโฟลเดอร์ [`./evaluation`](./evaluation)
- **จัดทำโดย:** ทีม BIRD & Google Cloud
- **สัญญาอนุญาต:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### การใช้งานชุดข้อมูล

เพื่อป้องกันข้อมูลรั่วไหลโดยการเก็บข้อมูลอัตโนมัติ เราไม่ใส่ sqls คำตอบ GT และกรณีทดสอบไว้กับข้อมูล
โปรดอีเมล [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) พร้อมแท็ก `[bird-interact-lite GT&Test Cases]` ในหัวเรื่องเพื่อขอชุดเต็ม ซึ่งจะถูกส่งโดยอัตโนมัติ


<!-- ### ใช้ชุดข้อมูลจาก HuggingFace

คุณสามารถดาวน์โหลดชุดข้อมูลจาก HuggingFace ได้โดยใช้คำสั่งต่อไปนี้:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
หรือคุณสามารถใช้สคริปต์ที่ให้มาเพื่อดาวน์โหลดชุดข้อมูลฉบับเต็มและแยกออกเป็นสำเนียงต่าง ๆ

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # เส้นทางไปยังไฟล์ JSONL ข้อมูลเข้า (อาจว่างเปล่าหากต้องการดาวน์โหลดชุดข้อมูลจาก HuggingFace)
  --output_folder path/to/output_dir # โฟลเดอร์ปลายทางของไฟล์ที่ถูกแบ่ง
```

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
รายละเอียดเกี่ยวกับการใช้งาน **a-interact** สามารถดูได้ที่ `./bird_interact_agent/README.md`; และ **c-interact** สามารถดูได้ที่ `./bird_interact_conv/README.md`


## 📋 รายการสิ่งที่ต้องทำ

- [x] เปิดตัวเวอร์ชัน lite, bird-interact-lite (270).
- [x] เปิดตัวเวอร์ชันสนทนา, bird-interact-conv.
- [x] เปิดตัวเวอร์ชัน agent, bird-interact-agent.
- [x] เปิดตัวเวอร์ชันเต็ม bird-interact-full (600).
- [ ] SFT / RL กับ User Simulator

## สร้างโดย:
ทีม BIRD & Google Cloud


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---