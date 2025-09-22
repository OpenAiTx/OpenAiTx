
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

## ⚠️ ประกาศ  
โปรดทราบว่าก่อนกระบวนการประเมินผลของคุณ เมื่อ Docker กำลังโหลดฐานข้อมูล อาจเกิดข้อผิดพลาดเป็นครั้งคราวเนื่องจากความไม่สอดคล้องของสภาพแวดล้อม (ข้อผิดพลาดเหล่านี้จะไม่หยุดกระบวนการแต่จะปรากฏในบันทึกของ Docker) ผลที่ตามมาคือบางฐานข้อมูลอาจโหลดไม่สำเร็จ ทำให้ฐานข้อมูลว่างเปล่า ซึ่งจะส่งผลให้ผลการประเมินต่ำผิดปกติ  
👉 ดังนั้นเราขอแนะนำให้ตรวจสอบบันทึก Docker สำหรับข้อผิดพลาด **ก่อนดำเนินการประเมิน** และตรวจสอบให้แน่ใจว่าฐานข้อมูลทั้งหมดถูกโหลดสำเร็จ

## 📰 ข่าวสาร

- [2025-08-26] 🚀 เราตื่นเต้นที่จะประกาศเปิดตัวชุด **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)**!  
เป็นชุดที่ท้าทาย — LLM ที่ดีที่สุดสามารถทำสำเร็จได้เพียง **16.33%** โดยมีแค่ **10.0%** ในส่วน `c-interact` และ `a-interact`  
👉 สำหรับรายละเอียดเพิ่มเติม โปรดเยี่ยมชม [เว็บไซต์โครงการ](https://bird-interact.github.io/) ของเรา

- [2025-08-26] 📬 เราจะส่ง **Ground Truth & Test cases** ให้กับรายชื่อผู้รับเมลของเราภายในสัปดาห์นี้  
หากต้องการเข้าถึงก่อน กรุณาส่งอีเมลตามคำแนะนำบนเว็บไซต์เพื่อรับ **ดาวน์โหลดอัตโนมัติ**  

- [2025-08-26] 💾 นอกจากนี้ เรายังเปิดตัวเวอร์ชัน SQLite ของ **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** เพื่อความสะดวกในการวิจัยในเครื่อง  
เวอร์ชันเต็มของ **LiveSQLBench-Base** และ **-Large** กำลังจะมาเร็วๆ นี้!

- [2025-08-22] **แก้ไขบั๊ก**: ในโค้ด Bird-Interact-Agent เราได้แก้ไขบั๊กที่เมื่อประเมิน phase-2 SQL แล้ว ไม่สามารถรัน phase-1 SQL ที่เก็บไว้ได้สำเร็จ ส่งผลให้อัตราความสำเร็จของ Phase-2 ลดลง บั๊กนี้จะเกิดกับงานที่ phase1 sql มีการดำเนินการกับฐานข้อมูล เช่น CREATE table เป็นต้น

## 🧸 ภาพรวม

BIRD-INTERACT เป็นชุดวัดผล text-to-SQL แบบโต้ตอบ ที่ **ออกแบบใหม่การประเมิน Text-to-SQL ผ่านมุมมองการปฏิสัมพันธ์แบบไดนามิก**
สภาพแวดล้อมนี้ผสมผสานฐานความรู้แบบลำดับชั้น เอกสารประกอบฐานข้อมูล และซิมูเลเตอร์ผู้ใช้ที่ขับเคลื่อนด้วยฟังก์ชัน เพื่อจำลองสภาพแวดล้อมองค์กรที่แท้จริง พร้อมรองรับการดำเนินการ **CRUD** อย่างครบถ้วน
มันมีโหมดทดสอบที่เข้มงวดสองแบบ: (1) **Conversational Interaction** แบบรับ และ (2) **Agentic Interaction** แบบรุก ครอบคลุม 600 งานที่มีการใส่หมายเหตุ เช่น Business Intelligence (BI), การดำเนินการ CRUD ฯลฯ โดยแต่ละงานมีกรณีทดสอบที่สามารถรันได้คอยป้องกัน
การประเมินผลทั่วไปจะเกิดการโต้ตอบระหว่างโมเดลกับตัวจำลองผู้ใช้ 1,968-5,496 ครั้ง ในขณะที่โมเดลการให้เหตุผลระดับสูงสุดในปัจจุบันแก้ไขงานได้เพียง **≈24%** และ **≈18%** เท่านั้น ซึ่งเน้นให้เห็นถึงความท้าทายของเบนช์มาร์กนี้

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ โหมดการประเมินผลสองแบบ

BIRD-INTERACT รองรับโหมดการประเมินผลสองแบบดังที่กล่าวข้างต้น:

   - **c-Interact**: Conversational Interaction ซึ่งเป็นโหมดรับ การทำงานถูกกำหนดไว้แล้ว สามารถดูโค้ดและข้อมูลรายละเอียดได้ใน `bird_interact_conv`
   - **a-Interact**: Agentic Interaction ซึ่งเป็นโหมดรุกแบบมีตัวตน โดยขั้นตอนการทำงานมีความไดนามิกและนำโดยโมเดล ดูโค้ดและข้อมูลรายละเอียดได้ใน `bird_interact_agent`


### 🐣 เวอร์ชัน Lite

เรากำลังปล่อยเวอร์ชัน Lite ของ BIRD-INTERACT คือ `bird-interact-lite-exp` ซึ่งมี 270 งานจริงคุณภาพสูงสำหรับ PostgreSQL เป็นจุดเริ่มต้นที่ดีสำหรับการทดลองอย่างรวดเร็ว

### 🦜 เวอร์ชันเต็ม

เวอร์ชันเต็มของ BIRD-INTERACT `bird-interact-full` เป็นเบนช์มาร์กที่ครอบคลุม โดยมี 600 งานสำหรับ PostgreSQL ครอบคลุมการดำเนินการ SQL และคำถามของผู้ใช้หลากหลายประเภท เวอร์ชันเต็มจะปล่อยเร็วๆ นี้

### ผลการทดสอบประสิทธิภาพของโมเดลบน BIRD-INTERACT Lite

#### 1. ประสิทธิภาพ **c-Interact**
| ลำดับ | ชื่อโมเดล            | รางวัลปกติ | ระดับ        |
|:------:|--------------------|:-------:|:--------------:|
| 1    | o3-mini            | 33.04   | 🏆 แชทยอดเยี่ยม  |
| 2    | GPT-4o             | 30.33   | 💎 แชทดี         |
| 3    | Gemini-2.0-flash   | 27.41   | 💎 แชทดี         |
| 4    | Claude-3.7-sonnet  | 26.60   | ✨ มาตรฐาน       |
| 5    | DeepSeek-R1        | 21.74   | ✨ มาตรฐาน       |
| 6    | Qwen3              | 20.33   | ⚪ ขั้นพื้นฐาน    |
| 7    | DeepSeek-V3        | 15.85   | ⚪ ขั้นพื้นฐาน    |

#### 2. ประสิทธิภาพ **a-Interact**
| ลำดับ | ชื่อโมเดล            | พารามิเตอร์งบประมาณ* | ขั้นตอนเฉลี่ย/งาน | ค่าใช้จ่ายเฉลี่ย (USD)/งาน | รางวัลปกติ | ระดับ            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 การโต้ตอบยอดเยี่ยม |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 การโต้ตอบดี         |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 การโต้ตอบดี         |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ มาตรฐาน              |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ มาตรฐาน              |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ พื้นฐาน              |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ พื้นฐาน              |

> \* พารามิเตอร์งบประมาณ: งบประมาณเริ่มต้น/งบประมาณความอดทนของผู้ใช้ วัดโดยสกุลเงินเสมือน *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">. ดูรายละเอียดเพิ่มเติมได้ที่ [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting)

### การปรับขนาดเวลาการโต้ตอบ (ITS)

การปรับขนาดเวลาการโต้ตอบ (ITS) หมายถึงความสามารถของโมเดลในการเพิ่มประสิทธิภาพสูงสุดอย่างต่อเนื่องผ่านการโต้ตอบหลายรอบ เมื่อประสิทธิภาพแบบโต้ตอบนี้สูงกว่าแบบทดสอบเดียวที่ระบุไว้อย่างสมบูรณ์ เราจะกล่าวว่าโมเดลนั้นเป็นไปตาม **กฎ ITS** เมื่อความอดทนผู้ใช้เพิ่มขึ้นและจำนวนรอบโต้ตอบสะสมขึ้น ประสิทธิภาพยังคงเพิ่มขึ้น แสดงให้เห็นว่าโมเดลสามารถสื่อสารได้อย่างมีประสิทธิภาพต่อเนื่องในบทสนทนายาว ขณะนี้พบเพียง claude-3-7-sonnet ที่เป็นไปตามกฎ ITS

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 รายละเอียดชุดข้อมูล

### รายละเอียดชุดข้อมูล

- **ฐานข้อมูล:** สามารถดาวน์โหลดฐานข้อมูล PostgreSQL ฉบับสมบูรณ์ได้จาก [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) ดูรายละเอียดเพิ่มเติมในหัวข้อ [Quick Eval](#quick-eval)
- **ข้อมูล:** ตัวอย่างข้อมูลแต่ละชุดประกอบด้วยส่วนหลักดังนี้:
   - `selected_database`: ชื่อฐานข้อมูล  
   - `query`: ข้อความค้นหาของผู้ใช้ที่ไม่มีความกำกวม  
   - `amb_user_query`: ข้อความค้นหาของผู้ใช้ที่มีการเติมความกำกวม  
   - `user_query_ambiguity`: ความกำกวมที่เติมเข้าไปในข้อความค้นหาผู้ใช้  
   - `non_critical_ambiguity`: ความกำกวมที่ไม่สำคัญ เช่น ลำดับ, การจำกัดผลลัพธ์ ฯลฯ  
   - `knowledge_ambiguity`: ความกำกวมที่เกิดจากความรู้ภายนอกที่ถูกปกปิด  
   - `sol_sql`: คำตอบ SQL ที่เป็นจริง  
   - `preprocess_sql`: คำสั่ง SQL ที่ต้องรันก่อนดำเนินการคำตอบหรือการทำนาย  
   - `clean_up_sql`: คำสั่ง SQL ที่ใช้หลังทดสอบเพื่อย้อนคืนค่าที่เปลี่ยนแปลงในฐานข้อมูล  
   - `test_cases`: ชุดกรณีทดสอบสำหรับตรวจสอบ SQL ที่ทำนาย  
   - `follow_up`: คำถามติดตามที่มีการติดป้ายกำกับ  
   - `external_knowledge`: ความรู้ภายนอกที่เกี่ยวข้องกับงานเฉพาะ

- **การประเมินผล:** โค้ดสำหรับประเมินผลอยู่ในไดเรกทอรี [`./evaluation`](./evaluation)
- **ดูแลจัดทำโดย:** ทีม BIRD และ Google Cloud
- **สัญญาอนุญาต:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **การ์ดข้อมูลชุดข้อมูล HuggingFace:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### การใช้งานชุดข้อมูล

เพื่อหลีกเลี่ยงการรั่วไหลของข้อมูลโดยการดึงข้อมูลอัตโนมัติ เราจะไม่รวม sql คำตอบ GT และกรณีทดสอบไว้พร้อมกับข้อมูล
กรุณาส่งอีเมลไปที่ [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) โดยใส่แท็ก `[bird-interact-lite GT&Test Cases]` ในหัวข้อ เพื่อรับชุดเต็ม ซึ่งจะถูกส่งให้อัตโนมัติ


<!-- ### ใช้ชุดข้อมูลจาก HuggingFace

คุณสามารถดาวน์โหลดชุดข้อมูลจาก HuggingFace ด้วยคำสั่งดังต่อไปนี้:
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
รายละเอียดเกี่ยวกับการใช้งาน **a-interact** สามารถดูได้ที่ `./bird_interact_agent/README.md` และสำหรับ **c-interact** สามารถดูได้ที่ `./bird_interact_conv/README.md`

## 📋 รายการงานที่ต้องทำ

- [x] ปล่อยเวอร์ชัน lite, bird-interact-lite (270).
- [x] ปล่อยเวอร์ชันสนทนา, bird-interact-conv.
- [x] ปล่อยเวอร์ชัน agent, bird-interact-agent.
- [x] ปล่อยเวอร์ชันเต็ม bird-interact-full (600).
- [ ] SFT / RL กับ User Simulator

## สร้างโดย:
ทีม BIRD & Google Cloud







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---