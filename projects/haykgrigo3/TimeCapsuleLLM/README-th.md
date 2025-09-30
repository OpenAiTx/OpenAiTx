
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (เร็ว ๆ นี้)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (เร็ว ๆ นี้)</a> |
        | <a href="#" title="Coming soon">ไทย (เร็ว ๆ นี้)</a> |
        | <a href="#" title="Coming soon">Français (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Deutsch (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Español (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Italiano (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Русский (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Português (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Nederlands (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Polski (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">العربية (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">فارسی (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Türkçe (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (เร็ว ๆ นี้)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (เร็ว ๆ นี้)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*โมเดลภาษาที่ฝึก **ตั้งแต่เริ่มต้น** โดยใช้ข้อมูลเฉพาะจากสถานที่และช่วงเวลาเพื่อลดอคติแบบสมัยใหม่ และจำลองเสียง คำศัพท์ และมุมมองโลกของยุคนั้น*

ลองจินตนาการว่า ถ้าโมเดล AI ไม่ได้แค่แกล้งทำเป็นประวัติศาสตร์ แต่เป็นจริง ๆ

v0 และ v0.5 สร้างขึ้นโดยใช้ [nanoGPT โดย Andrej Karpathy](https://github.com/karpathy/nanoGPT) สคริปต์การฝึกหลักและสถาปัตยกรรมโมเดลเป็นผลงานของเขา

v1 สร้างขึ้นบน [Phi 1.5 โดย Microsoft](https://huggingface.co/microsoft/phi-1_5)

[ลิงก์ Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  พฤติกรรมของโมเดล & ข้อจำกัด

### **v0**  

ข้อความแรก ๆ แสดงให้เห็นว่าโมเดลตอบกลับด้วยภาษาและพฤติกรรมในยุค 1800 
ตัวอย่าง: คำถาม: "Who art Henry?" และมันตอบกลับว่า "I know that man, I have did not a black, the storm." 

![ตัวอย่างผลลัพธ์ TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- ไม่มีการกล่าวถึงแนวคิดสมัยใหม่  
- คำศัพท์ส่วนใหญ่ตรงกับยุคนั้น  
- ประโยคส่วนใหญ่ไม่ปะติดปะต่อ (เป็นสิ่งที่คาดไว้สำหรับข้อมูลฝึก ~187MB)

### **v0.5** 

ปรับปรุงอย่างเห็นได้ชัดจาก v0  
- สไตล์การเขียนยุควิกตอเรีย การใช้เครื่องหมายวรรคตอนถูกต้อง ส่วนใหญ่เป็นประโยคที่ถูกหลักไวยากรณ์  
- อัตราการจินตนาการข้อเท็จจริงยังสูง  
- มีเสียงรบกวนจาก OCR (“Digitized by Google”) ปรากฏในผลลัพธ์

![ตัวอย่างผลลัพธ์ TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

เป็นโมเดลแรกที่สามารถจดจำและเชื่อมโยงเหตุการณ์ทางประวัติศาสตร์จริงกับบุคคลจริงในชุดข้อมูลได้

ตัวอย่าง: คำถาม: "It was the year of our Lord 1834" 

ผลลัพธ์: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

แรก ๆ ฉันคิดว่าอาจจะมีการประท้วงเกิดขึ้นในปีเดียวกันโดยบังเอิญ แต่ลองดูนี่สิ: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### เหตุผลที่เรื่องนี้สำคัญ:

นี่เป็นตัวอย่างแรกที่โมเดลของฉันเชื่อมโยงปีเข้ากับทั้งเหตุการณ์ทางประวัติศาสตร์จริงและบุคคลจริงที่เกี่ยวข้องกับเหตุการณ์นั้น (Lord Palmerston) โมเดลก่อนหน้านี้ (v0 และ v0.5) สามารถเลียนแบบสไตล์การเขียนในศตวรรษที่ 19 ได้ แต่จะจินตนาการเหตุการณ์ บุคคล และข้อเท็จจริงเสมอ สิ่งนี้แสดงให้เห็นว่าโมเดลเริ่มจดจำสิ่งต่าง ๆ จากชุดข้อมูลแล้ว


## แผนงานในอนาคต

- มีข้อความเกือบ 175,000 รายการที่เผยแพร่ในลอนดอนระหว่างปี 1800-1875 บน Internet Archive
- ผมมีแผนที่จะขยายคลังข้อมูลและทำความสะอาดเพิ่มเติมเพื่อเพิ่มความสามารถในการให้เหตุผล
- ขยายไปยังภูมิภาคและช่วงเวลาต่างๆ เพื่อสร้างโมเดลทางประวัติศาสตร์ที่หลากหลายมากขึ้น

## วิธีการใช้งาน

โครงการนี้เน้นการรวบรวมข้อมูลประวัติศาสตร์ เตรียมข้อมูลสำหรับการฝึกฝน และสร้างตัวแบ่งคำ ผมจะไม่ครอบคลุมกระบวนการฝึกฝน LLM ทั้งหมด สำหรับเรื่องนี้โปรดดู nanoGPT โดย Andrej Karpathy

### ขั้นตอนที่ 1: รวบรวมและเตรียมข้อความประวัติศาสตร์

- รวบรวมไฟล์ .txt ของหนังสือ เอกสาร ฯลฯ ที่เป็นสาธารณสมบัติจากช่วงเวลาที่คุณเลือก (เช่น ลอนดอน 1800-1850)
- เก็บข้อมูลไว้ในช่วงเวลา/สถานที่ที่คุณเลือก
- ทำความสะอาดไฟล์ข้อความโดยใช้สคริปต์หรือเอาส่วนหัว/ท้ายออกด้วยมือจาก Project Gutenberg, หมายเหตุสมัยใหม่ หรือข้อผิดพลาด OCR ต่างๆ

### ขั้นตอนที่ 2: สร้างตัวแบ่งคำแบบกำหนดเอง

- รัน train_tokenizer.py หรือ train_tokenizer_hf.py กับข้อมูลที่ทำความสะอาดแล้ว
- จะได้ไฟล์ vocab.json และ merges.txt
- ไฟล์เหล่านี้กำหนดคำศัพท์และกฎการรวมสำหรับโมเดลของคุณ

### ขั้นตอนที่ 3: ฝึกฝนโมเดลของคุณ

- ดู [nanoGPT โดย Andrej Karpathy](https://github.com/karpathy/nanoGPT) สำหรับขั้นตอนการฝึกฝนหรือเอกสารของสถาปัตยกรรมที่คุณเลือก

# คำถามที่พบบ่อย

## Selective Temporal Training คืออะไร?

Selective Temporal Training (STT) เป็นวิธีการเรียนรู้ของเครื่องที่มีการคัดกรองข้อมูลฝึกฝนให้ตรงกับช่วงเวลาทางประวัติศาสตร์ที่เฉพาะเจาะจง เพื่อสร้างแบบจำลองภาษาและความรู้ของยุคนั้นโดยปราศจากอิทธิพลจากแนวคิดสมัยใหม่ ตัวอย่างเช่น โมเดลปัจจุบันที่ผมมี (v0.5) ได้รับการฝึกฝนจากข้อมูลระหว่างปี 1800-1875 เท่านั้น ไม่ได้ปรับแต่งแต่ฝึกฝนจากศูนย์ ส่งผลให้ผลลัพธ์สะท้อนรูปแบบภาษาและบริบททางประวัติศาสตร์ของช่วงเวลานั้น

## ทำไมไม่ใช้การปรับแต่งหรือ LoRA?

สำหรับโครงการนี้ผมต้องการสร้างโมเดลภาษาโดยปราศจากอคติสมัยใหม่ หากผมปรับแต่งโมเดลเช่น GPT-2 มันได้รับการฝึกฝนมาก่อนแล้วและข้อมูลนั้นจะไม่หายไป หากฝึกฝนจากศูนย์ โมเดลภาษาจะไม่แกล้งทำเป็นเก่าแต่มันจะเป็นเช่นนั้นจริงๆ เป้าหมายของโครงการนี้ในตอนนี้คือสร้างโมเดลที่สามารถให้เหตุผลโดยใช้ความรู้จากหนังสือลอนดอนที่ตีพิมพ์ระหว่างปี 1800 ถึง 1875 เท่านั้น

## ใช้ข้อมูลประเภทใดในการฝึกฝน?


ผมใช้หนังสือ เอกสารทางกฎหมาย หนังสือพิมพ์ และงานเขียนอื่น ๆ จากลอนดอนช่วงปี 1800–1875 รายการที่ผมแนบไว้ (สำหรับ v0) มีประมาณ 200 รายการ แต่สำหรับการเทรนครั้งแรกผมใช้เพียง 50 ไฟล์ ประมาณ ~187 MB คุณสามารถดูรายการเอกสารได้ที่:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

ขนาดของชุดข้อมูล:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## โมเดลมีขนาดเท่าไร ?

V0: 16M พารามิเตอร์

V0.5 123M พารามิเตอร์

V1: 700M พารามิเตอร์

# สเปกการเทรน ?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 เช่าใช้บริการ















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---