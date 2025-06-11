# KVzip: การบีบอัดแคช KV แบบไม่ขึ้นกับคำถามด้วยการสร้างบริบทใหม่

[[Paper](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## มีอะไรใหม่?
- KVzip บีบอัดแคช KV เพื่อรองรับ **คำถามในอนาคตที่หลากหลาย**
- [ขึ้นกับบริบท] บรรลุการ **ลดขนาดแคช KV 3–4 เท่า** และ **ลดเวลาในการถอดรหัสลง 2 เท่า** โดยมีการลดประสิทธิภาพเพียงเล็กน้อย
- [ไม่ขึ้นกับบริบท] พัฒนาการบีบอัด KV ในระดับหัว [DuoAttention](https://github.com/mit-han-lab/duo-attention) โดยใช้เพียง **การผ่านหน้าเดียวไม่กี่ครั้งภายในหนึ่งนาที** สำหรับการปรับแต่งคะแนนความสำคัญในระดับหัว (เร็วขึ้น 100 เท่า)
- รัน demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### การทดสอบประสิทธิภาพในสภาพแวดล้อมไม่ขึ้นกับคำถาม
- งานทดสอบ: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294)  
- โมเดล: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## การติดตั้ง
เราใช้ CUDA 12.1 และ Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- หากต้องการใช้การควอนไทซ์จาก [QServe](https://github.com/mit-han-lab/omniserve) กรุณาปฏิบัติตาม [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model)
### ชุดข้อมูล
- กรุณาดาวน์โหลดชุดข้อมูล SCBench ที่ผ่านการประมวลผลแล้วจาก [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link)
- หากคุณดาวน์โหลดไฟล์ที่แตกไฟล์แล้ว ให้ย้ายโฟลเดอร์ scbench ไปยังที่ต้องการ
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## เริ่มต้นอย่างรวดเร็ว
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # เตรียมแคช KV + การให้คะแนนความสำคัญ
kv.prune(ratio=0.3)  # อัตราการบีบอัด, กำจัด KV 70%

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # การสืบค้นที่มีประสิทธิภาพ
    print(q, output)
```
- โมเดลที่รองรับถูกระบุไว้ใน [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py) รวมถึง **LLaMA3, Qwen2.5/3, Gemma3**
- ตั้งค่า `load_score=True` เพื่อขจัดภาระในการบีบอัด ซึ่งจะเปิดใช้การลบ KV แบบไม่ขึ้นกับบริบท โดยแลกกับอัตราบีบอัดที่ `ratio=0.6`
- หลังการสร้างผลลัพธ์ คู่ KV ที่สอดคล้องกับคำถามและโทเค็นที่สร้างจะถูกคัดเลือกเพื่อลบออกจากแคชสำหรับการประมวลผลต่อไป ตั้งค่า `update_cache=True` เพื่อเปิดใช้งานการสืบค้นแบบหลายรอบ โดยเก็บประวัติการโต้ตอบทั้งหมดไว้ตลอดการสืบค้น

## การวัดประสิทธิภาพหน่วยความจำและเวลาในการคำนวณ
### การลบ KV ขึ้นกับบริบท
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- โค้ดข้างต้นยังเปรียบเทียบผลลัพธ์ที่สร้างด้วยแคช KV เต็มและแคช KV ที่ถูกตัดแต่ง
- สำหรับการทดสอบอย่างรวดเร็ว ใช้ `-d squad` สำหรับการทดสอบบริบทยาว ใช้ `-d scbench_kv`
  - ชื่อชุดข้อมูลที่ใช้ได้: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py)
  - ชื่อโมเดลที่ใช้ได้: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py) เช่น llama3.1-8b, qwen2.5-7b (หรือ Qwen/Qwen2.5-7B-Instruct-1M)
- เราปรับแต่งเคอร์เนล CUDA จาก [AdaKV](https://github.com/FFY0/AdaKV/tree/main) โดยรองรับการจัดสรรงบประมาณหัวแบบไม่สม่ำเสมอ
  - ปัจจุบัน โค้ดของเราไม่มีเคอร์เนลที่ปรับแต่งสำหรับ Gemma3 ซึ่งใช้แคช KV แบบสถิต จึงยังไม่มีประสิทธิภาพที่เพิ่มขึ้นจริง แต่สามารถประเมินประสิทธิภาพของโมเดลได้โดยใช้การลดความสนใจด้วยการเลือกตัวอย่าง KV (`--kv_type retain`)


### การลบ KV ไม่ขึ้นกับบริบท (ไม่มีภาระการบีบอัดขณะรัน)
- ใช้แฟล็ก `--level head` พร้อม `--ratio 0.6` (แนะนำ)
  - เราจะลบคู่ KV ทั้งหมดที่เกี่ยวข้องกับหัวเฉพาะในขณะที่ยังคงเก็บระบบพรอมต์และคู่ KV ของคำถามไว้
  - คะแนนหัวที่คำนวณล่วงหน้ามีให้สำหรับ LLaMA3.1-8B และ Qwen2.5-7/14B ใน `./utils/head_score`
- หากต้องการคำนวณคะแนนหัวสำหรับโมเดลอื่น:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - ผลลัพธ์จะถูกบันทึกใน `./utils/head_score`
  - หากทำงานกับงานเขียนโค้ด แนะนำให้รันคำสั่งเพิ่มเติมกับ `-d scbench_repoqa` เพื่อให้โมเดลใช้คะแนนหัวสูงสุดจากทั้งภาษาธรรมชาติและภาษาโค้ด ซึ่งจะช่วยปรับปรุงประสิทธิภาพ
- คะแนนเหล่านี้สามารถนำไปใช้ร่วมกับเครื่องมือสืบค้นที่ปรับแต่งของ [DuoAttention](https://github.com/mit-han-lab/duo-attention) โดยการแทนที่ข้อมูลคะแนนหัวด้วยของเราได้อย่างราบรื่น


## การประเมินผล
- เพื่อสร้างคำตอบของโมเดลด้วยอัตราการบีบอัด KV ตั้งแต่ 0.1 ถึง 1.0:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - ผลลัพธ์จะถูกบันทึกใน `./results/[data_name]`
  - ชุดข้อมูลที่รองรับระบุไว้ใน `data/load.py`
- เพื่อคำนวณเมตริกการประเมินจากผลลัพธ์ที่สร้าง:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## การนำไปใช้กับโมเดลใหม่
เพื่อรวม KVzip สำหรับโมเดลใหม่ คุณจะต้องอัปเดตไฟล์ต่อไปนี้:
- `attention/attn.py`  
  แก้ไขตรรกะการส่งผ่านความสนใจตามความจำเป็น ในบางกรณีอาจต้องอัปเดต kvcache.py และ score.py ด้วย
- `model/monkeypatch.py`  
  ทำการแพตช์แบบมังกี้เฉพาะโมเดลสำหรับการรวมระบบ
- `model/template.py`   
  กำหนดพรอมต์ระบบและแม่แบบการจัดรูปแบบแชทของโมเดล


## การอ้างอิง
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## ใบอนุญาต
MIT License

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---