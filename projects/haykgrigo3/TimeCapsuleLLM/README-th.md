
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

##  พฤติกรรมของโมเดล & ข้อจำกัด

### **v0**  

การใช้งานแรกเริ่มแสดงให้เห็นว่าโมเดลตอบสนองด้วยภาษายุค 1800 และพฤติกรรมแบบโบราณ  
ตัวอย่าง: คำถาม: "Who art Henry?" และมันตอบว่า "I know that man, I have did not a black, the storm." 

![ตัวอย่างผลลัพธ์ TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- ไม่มีการกล่าวถึงแนวคิดสมัยใหม่  
- ส่วนใหญ่ใช้คำศัพท์ที่ถูกต้องตามยุคสมัย  
- ประโยคส่วนใหญ่ไม่สมเหตุสมผล (คาดการณ์ได้สำหรับข้อมูลฝึก ~187MB)

### **v0.5** 

มีการปรับปรุงอย่างมีนัยสำคัญจาก v0  
- สไตล์การเขียนแบบวิคตอเรียน, การใช้เครื่องหมายวรรคตอนถูกต้อง, ประโยคส่วนใหญ่ถูกหลักไวยากรณ์  
- อัตราการจินตนาการข้อเท็จจริงยังสูง  
- มีเสียงรบกวนจาก OCR (“Digitized by Google”) ปรากฏในผลลัพธ์

![ตัวอย่างผลลัพธ์ TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

โมเดลแรกที่สามารถระลึกและเชื่อมโยงเหตุการณ์ทางประวัติศาสตร์จริงกับบุคคลจริงจากชุดข้อมูล

ตัวอย่าง: คำถาม: "It was the year of our Lord 1834" 

ผลลัพธ์: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

ทีแรกฉันคิดว่าอาจมีการประท้วงเกิดขึ้นโดยบังเอิญในปีเดียวกัน แต่ลองดูภาพนี้: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### เหตุผลที่สิ่งนี้สำคัญ:

นี่คือตัวอย่างแรกที่หนึ่งในโมเดลของฉันเชื่อมโยงปีเข้ากับทั้งเหตุการณ์ประวัติศาสตร์จริงและบุคคลที่เกี่ยวข้องกับเหตุการณ์นั้น (Lord Palmerston) โมเดลก่อนหน้า (v0 และ v0.5) สามารถเลียนแบบสไตล์การเขียนในศตวรรษที่ 19 ได้แต่จะจินตนาการเหตุการณ์, บุคคล และข้อเท็จจริงอยู่เสมอ สิ่งนี้แสดงว่าโมเดลเริ่มจดจำข้อมูลจากชุดข้อมูลแล้ว

## แผนงานในอนาคต


- มีข้อความเกือบ 175,000 รายการที่เผยแพร่ในลอนดอนระหว่างปี 1800-1875 บน Internet Archive 
- ฉันวางแผนที่จะขยายคลังข้อมูลและทำความสะอาดเพิ่มเติมเพื่อเพิ่มความสามารถในการให้เหตุผล
- ขยายไปยังภูมิภาคและช่วงเวลาต่าง ๆ เพื่อสร้างโมเดลประวัติศาสตร์เพิ่มเติม


## วิธีการใช้งาน

โปรเจกต์นี้เน้นการรวบรวมข้อมูลประวัติศาสตร์, เตรียมข้อมูลสำหรับการฝึก และสร้างตัวตัดคำ ฉันจะไม่กล่าวถึงขั้นตอนการฝึก LLM ทั้งหมด สำหรับเรื่องนั้นให้ดู nanoGPT โดย Andrej Karpathy

### ขั้นตอนที่ 1: รวบรวมและเตรียมข้อความประวัติศาสตร์ 

- รวบรวมไฟล์ .txt ของหนังสือ, เอกสาร ฯลฯ ที่เป็นสาธารณสมบัติจากช่วงเวลาที่คุณเลือก (เช่น ลอนดอน 1800-1850) 
- เก็บไฟล์เหล่านั้นไว้ในช่วงเวลา/สถานที่ที่เลือก  
- ทำความสะอาดไฟล์ข้อความโดยใช้สคริปต์หรือเอาส่วนหัว/ส่วนท้ายจาก Project Gutenberg ออกด้วยมือ, หมายเหตุสมัยใหม่ หรือข้อผิดพลาด OCR

### ขั้นตอนที่ 2: สร้างตัวตัดคำแบบกำหนดเอง

- รัน train_tokenizer.py หรือ train_tokenizer_hf.py กับข้อมูลที่ผ่านการทำความสะอาด
- จะได้ไฟล์ vocab.json และ merges.txt
- ไฟล์เหล่านี้กำหนดคำศัพท์และกฎการรวมคำสำหรับโมเดลของคุณ

### ขั้นตอนที่ 3: ฝึกโมเดลของคุณ 

- ดู [nanoGPT โดย Andrej Karpathy](https://github.com/karpathy/nanoGPT) สำหรับขั้นตอนการฝึกหรือคู่มือสถาปัตยกรรมที่คุณเลือก

# คำถามที่พบบ่อย

## Selective Temporal Training คืออะไร ?

Selective Temporal Training (STT) คือแนวทางด้านแมชชีนเลิร์นนิงที่รวบรวมข้อมูลการฝึกทั้งหมดให้ตรงกับช่วงเวลาประวัติศาสตร์ที่กำหนด โดยทำเพื่อจำลองภาษาและความรู้ของยุคนั้นโดยไม่ปะปนกับแนวคิดสมัยใหม่ ตัวอย่างเช่น โมเดลปัจจุบันที่ฉันมี (v0.5) ถูกฝึกด้วยข้อมูลจากปี 1800-1875 โดยเฉพาะ ไม่ใช่การปรับแต่งแต่เป็นการฝึกใหม่ทั้งหมด ผลลัพธ์จึงสะท้อนรูปแบบภาษาและบริบททางประวัติศาสตร์ของช่วงเวลานั้น

## ทำไมไม่ใช้การปรับแต่งหรือ LoRA?

สำหรับโปรเจกต์นี้ ฉันต้องการสร้างโมเดลภาษาที่ไม่มีอคติสมัยใหม่ หากปรับแต่ง GPT-2 ข้อมูลที่ถูกฝึกไว้ก่อนก็ยังคงอยู่และไม่สามารถลบออกได้ หากฝึกจากศูนย์ โมเดลภาษาจะไม่แกล้งทำเป็นโบราณแต่จะเป็นแบบนั้นจริง ๆ เป้าหมายของโปรเจกต์นี้คือสร้างบางสิ่งที่ให้เหตุผลโดยใช้ความรู้จากหนังสือลอนดอนที่ตีพิมพ์ระหว่างปี 1800 ถึง 1875 เท่านั้น

## ใช้ข้อมูลประเภทใดในการฝึก?

ฉันใช้หนังสือ, เอกสารกฎหมาย, หนังสือพิมพ์ และงานเขียนอื่น ๆ จากลอนดอนปี 1800–1875 รายการที่ฉันแนบไว้ (สำหรับ v0) มีประมาณ 200 รายการ แต่สำหรับการฝึกครั้งแรกฉันใช้แค่ 50 ไฟล์ประมาณ ~187 MB คุณสามารถดูรายชื่อเอกสารได้ที่:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt
ขนาดของชุดข้อมูล:
v0: ~187MB
v0.5: ~435MB
v1: ~6.25GB

## โมเดลมีขนาดเท่าไร ?

V0: 16M พารามิเตอร์

V0.5: 123M พารามิเตอร์

V1: 700M พารามิเตอร์

# สเปคการฝึกสอน ?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

# V1
GPU: A100 เช่าใช้บริการ

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---