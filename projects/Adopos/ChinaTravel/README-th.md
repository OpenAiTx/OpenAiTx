<center>
  <h1>ChinaTravel: ตัวชี้วัดในโลกจริงสำหรับตัวแทนภาษาในการวางแผนท่องเที่ยวจีน
</h1>
</center>

ฐานรหัสอย่างเป็นทางการสำหรับงานวิจัย "ChinaTravel: ตัวชี้วัดในโลกจริงสำหรับตัวแทนภาษาในการวางแผนท่องเที่ยวจีน"

<!-- | [Webpage](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [Paper](https://arxiv.org/abs/2412.13682) | [Dataset(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![Webpage](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![Paper](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![Dataset(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![Competition(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![Competition(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![Overview](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 การแข่งขันวางแผนท่องเที่ยว IJCAI 2025 (TPC@IJCAI)

เราภูมิใจประกาศว่า ChinaTravel ได้รับเลือกให้เป็นตัวชี้วัดอย่างเป็นทางการสำหรับ **การแข่งขันวางแผนท่องเที่ยว (TPC) @ IJCAI 2025**!

**เว็บไซต์การแข่งขันอย่างเป็นทางการ**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

ขอเชิญผู้เข้าร่วมพัฒนาตัวแทนใหม่ ๆ ที่สามารถแก้ปัญหาวางแผนท่องเที่ยวในโลกจริงภายใต้ข้อจำกัดที่ซับซ้อน การแข่งขันนี้จะแสดงให้เห็นแนวทางล้ำสมัยในการวิจัยตัวแทนภาษา

## 📝 ChangeLog

### 2025.09
1. อัพโหลดโซลูชั่นแชมป์ของ TPC@IJCAI2025 DSL track ขอบคุณ [@evergreenee](https://github.com/evergreenee) สำหรับการมีส่วนร่วม  


### 2025.06

1. แก้ไขการรวบรวมข้อผิดพลาดในโค้ดประเมิน commonsense
2. แก้ไข pipeline ของ pure-neuro agent
3. แก้ไข load_datasets จาก huggingface
4. อัปเดตการจัดการข้อยกเว้นในการตรวจสอบไวยากรณ์


### 2025.05

1. อัปเดตบันทึกการเปลี่ยนแปลงสำหรับเวอร์ชันล่าสุด
2. ให้โค้ดสำหรับการประเมิน TPC

### 2025.04

1. เพิ่มตัวโหลดข้อมูลท้องถิ่น ผู้ใช้สามารถโหลดคำค้นหาแบบกำหนดเองในเครื่องได้ ขณะกำหนดค่า splits_name ที่ไม่ใช่ค่าเริ่มต้น (เช่น "abc") สำหรับ "run_exp.py" ระบบจะโหลดไฟล์ที่เกี่ยวข้องโดยอัตโนมัติจาก evaluation/default_splits/abc.txt ซึ่งไฟล์ TXT จะมีชื่อไฟล์ของคำค้นหาเป้าหมาย
2. จำแนกข้อจำกัดอย่างละเอียด ดูเอกสารเพิ่มเติมที่ [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. เปิดตัว baseline แบบ LLM-modulo
   ใช้งาน pipeline LLM-modulo ร่วมกับ symbolic verifier ที่เป็น ground-truth
   อ้างอิงวิธีการจาก:
   งานวิจัย: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   รหัสต้นฉบับ: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. รองรับการอนุมาน LLM ในเครื่องกับ Qwen3-8B/4B

## 🚀 เริ่มต้นอย่างรวดเร็ว

### ⚙️ การตั้งค่า

1. สร้างสภาพแวดล้อม conda และติดตั้ง dependencies:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. ดาวน์โหลดฐานข้อมูลและแตกไฟล์ไปยังไดเรกทอรี "chinatravel/environment/"

ลิงก์ดาวน์โหลด: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU), [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. ดาวน์โหลด LLMs แบบโอเพ่นซอร์ส (ไม่บังคับ)

```bash
bash download_llm.sh
```

4. ดาวน์โหลดตัวแปลงโทเค็น (tokenizers)

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ การรัน

เรารองรับ deepseek (API อย่างเป็นทางการจาก deepseek), gpt-4o (chatgpt-4o-latest), glm4-plus และการอนุมานแบบ local ด้วย Qwen (Qwen3-8B), llama, mistral (Mistral-7B-Instruct-v0.3) ฯลฯ

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**หมายเหตุ**:

- แฟล็ก `--oracle_translation` จะเปิดการเข้าถึงข้อมูลจริงที่มีการใส่คำอธิบายประกอบรวมถึง:

  - `hard_logic_py`: โค้ด DSL สำหรับตรวจสอบการทำงานได้
  - `hard_logic_nl`: คำอธิบายข้อจำกัดที่เกี่ยวข้อง
  - โครงสร้างตัวอย่างของคำอธิบายประกอบ:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- วิธี LLM-modulo **ต้องการ** โหมด oracle_translation สำหรับกระบวนการปรับแต่งเชิงสัญลักษณ์ของมัน

### 📊 การประเมินผล

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```
ในการแข่งขัน TPC@IJCAI2025 โค้ดสำหรับการประเมินผลจะอยู่ในไฟล์ `eval_tpc.py` คุณสามารถรันโค้ดการประเมินผลได้ดังนี้:


```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 เอกสาร

[สภาพแวดล้อม](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[ข้อจำกัด](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ การพัฒนาขั้นสูง

### 1. พัฒนาอัลกอริทึมเอเจนต์ของคุณเอง

หากต้องการพัฒนาอัลกอริทึมเอเจนต์ของคุณเอง คุณต้องสืบทอดคลาส `BaseAgent` จาก `chinatravel/agent/base.py` และเพิ่มตรรกะสำหรับอัลกอริทึมของคุณในฟังก์ชัน `init_agent` ใน `chinatravel/agent/load_model.py` เราได้ให้ตัวอย่างเอเจนต์เปล่าชื่อว่า `TPCAgent`

ขั้นตอน:

- **สืบทอดคลาส `BaseAgent`**: สร้างไฟล์ Python ใหม่ในไดเรกทอรี `chinatravel/agent` และกำหนดคลาสเอเจนต์ของคุณเองโดยสืบทอดจาก `BaseAgent`

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```

- **เพิ่มโค้ดในฟังก์ชัน init_agent**: เปิดไฟล์ chinatravel/agent/load_model.py และเพิ่มการรองรับสำหรับเอเจนต์ใหม่ของคุณในฟังก์ชัน init_agent

```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### 2. พัฒนา LLM ในเครื่องของคุณเอง

ในการพัฒนาโมเดลภาษาขนาดใหญ่ (LLM) ในเครื่องของคุณเอง คุณต้องสืบทอดคลาส AbstractLLM จากไฟล์ chinatravel/agent/llms.py และเพิ่มโค้ดสำหรับการอนุมาน LLM ในเครื่องลงใน llms.py เราได้เตรียมตัวอย่าง LLM เปล่าชื่อ TPCLLM ไว้ให้แล้ว
ขั้นตอน:

- **สืบทอดคลาส AbstractLLM**: กำหนดคลาส LLM ของคุณเองในไฟล์ chinatravel/agent/llms.py โดยสืบทอดจาก AbstractLLM

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **เพิ่มโค้ดในฟังก์ชัน init_agent**: เปิดไฟล์ chinatravel/agent/load_model.py และเพิ่มการรองรับ llm ใหม่ของคุณในฟังก์ชัน init_llm

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. รันโค้ดของคุณโดยใช้สคริปต์ทดลอง

หลังจากพัฒนาตามขั้นตอนข้างต้นแล้ว คุณสามารถใช้สคริปต์ทดลองเพื่อรันโค้ดของคุณได้

ตัวอย่างการรัน:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
ผลลัพธ์จะถูกบันทึกไว้ในไดเรกทอรี `results/YourMethodName_YourLLMName_xxx` เช่น `results/TPCAgent_TPCLLM`

## ✉️ ติดต่อ

หากคุณพบปัญหาใด ๆ กรุณาติดต่อ [Jie-Jing Shao](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn), [Bo-Wen Zhang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn), [Xiao-Wen Yang](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn)

## 📌 การอ้างอิง

หากบทความหรือทรัพยากรที่เกี่ยวข้องของเราเป็นประโยชน์ต่อการวิจัยของคุณ กรุณาอ้างอิงด้วย


```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---