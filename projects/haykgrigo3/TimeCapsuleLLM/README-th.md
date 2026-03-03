<div align="right">
  <details>
<summary>🌐 ภาษา</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*แบบจำลองภาษาที่ได้รับการฝึกฝน**ตั้งแต่ต้น**โดยเฉพาะกับข้อมูลจากสถานที่และช่วงเวลาบางยุค เพื่อช่วยลดอคติสมัยใหม่และเลียนแบบน้ำเสียง คำศัพท์ และโลกทัศน์ของยุคนั้น*

ลองจินตนาการว่าหากโมเดล AI ไม่ได้แค่แสร้งเป็นประวัติศาสตร์ แต่เป็นจริง ๆ

v0 และ v0.5 สร้างบนพื้นฐาน [nanoGPT โดย Andrej Karpathy](https://github.com/karpathy/nanoGPT) สคริปต์ฝึกหลักและสถาปัตยกรรมโมเดลเป็นผลงานของเขา

v1 สร้างบน [Phi 1.5 โดย Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 สร้างบน llamaforcausallm

[ลิงก์ Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## สถานะการวิจัย
โครงการนี้เริ่มต้นและพัฒนาอย่างอิสระ

ขณะนี้ดำเนินการภายใต้การกำกับดูแลทางวิชาการ โดยมีความร่วมมือวิจัยกับ Muhlenberg College

## การอ้างอิง

หากคุณใช้ชุดข้อมูลหรือโมเดลนี้ในงานวิชาการ กรุณาอ้างอิงว่า:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  พฤติกรรมของโมเดล & ข้อจำกัด

### **v0**  

คำสั่งในช่วงแรกแสดงให้เห็นว่าโมเดลตอบสนองด้วยภาษาและพฤติกรรมในยุค 1800  
ตัวอย่าง: คำสั่ง: "Who art Henry?" และมันตอบว่า "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- ไม่มีการกล่าวถึงแนวคิดสมัยใหม่  
- คำศัพท์ส่วนใหญ่ถูกต้องตามยุคสมัย  
- ประโยคส่วนใหญ่ไม่สมเหตุสมผล (เป็นไปตามที่คาดไว้สำหรับข้อมูลฝึก ~187MB)

### **v0.5** 

มีความก้าวหน้าสำคัญจาก v0  
- สไตล์การเขียนแบบวิกตอเรีย, เครื่องหมายวรรคตอนถูกต้อง, ประโยคส่วนใหญ่มีไวยากรณ์ถูกต้อง  
- อัตราการหลอนข้อมูลจริงยังสูง  
- เสียงรบกวนจาก OCR (“Digitized by Google”) ยังปรากฏในผลลัพธ์

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

เป็นโมเดลแรกที่สามารถระลึกและเชื่อมโยงเหตุการณ์ประวัติศาสตร์จริงกับบุคคลจริงจากชุดข้อมูลได้

ตัวอย่าง: คำสั่ง: "It was the year of our Lord 1834" 

ผลลัพธ์: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

ตอนแรกฉันคิดว่าการประท้วงอาจเกิดขึ้นโดยบังเอิญในปีเดียวกัน แต่ลองดูสิ: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

ฝึกโดยใช้ตัวอย่าง 15GB จากชุดข้อมูล 90GB ของ v2  
โมเดลฝึกเพียง 10K ขั้นตอนเท่านั้น

มีปัญหาการแปลงโทเคนทำให้ผลลัพธ์มีลักษณะดังนี้:

ชาร์ลส์ ดิกเกนส์ คือใคร?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

แก้ไขแล้ว:

"ใครคือ Charles Dickens? งานของเขาทำให้เกิดความตื่นเต้นที่ยอดเยี่ยมมากขึ้นในบทละครของเขา ในฟาร์มของบริษัทใหญ่หรือไม่? ฉันยังไม่ได้อ้างจาก Jack Pickett หรือเปล่า? คุณไม่ทราบหรือว่าพวกเขาเป็นสายพันธุ์ที่วิ่งเหยาะ ๆ หรือเลื่อยหน้าอกของตนเอง หรือว่าจะต้องทำอะไรในช่วงเวลาที่ Jackson กำลังมองออกไปที่หน้าต่าง? ความสำเร็จของชาวอังกฤษคืออะไร และลูกชายของเขายังไม่ได้ค้นพบให้ฉัน ซึ่งจะทำให้สามารถบรรลุเป้าหมายที่หนักเช่นนั้นได้? คุณเคยเดินทางไปบนถนนเก่า หรือที่ลมสมอที่ปลายเรือของเรา ซึ่งคุณต้องจากเราไปหรือไม่? ความจริงก็คือ ไม่ว่าจะลมจะพัดขึ้นมาจากทุ่งในคืนวันเสาร์หรือเที่ยงวัน หรือไปทางเหนือหรือทิศอื่น เราจะถูกบังคับให้บรรยายถึงอุปสรรคที่แข็งแกร่ง ด้วยผลกระทบเช่นเดียวกับปัจจุบัน ในสถานการณ์นี้ อย่างน้อย ก็ไม่มากเกินไปที่จะกล่าวว่าเราได้ออกจากห้องนั้นแล้ว ฉันเชื่อว่ามีสำเนาสามฉบับใน 'Five Hundred-fold' ให้ใช้อ้างอิง เป็นหมายเลขแรกของผู้อ่านของเราที่ต้องการ..."

### **v2mini-eval2**

ฝึกด้วยตัวอย่าง 15GB เดียวกับที่ใช้ฝึก eval1
โมเดลถูกฝึกเพียง 10K ขั้นตอนเท่านั้น

PROMPT:Charles Darwin

Charles DarwinECCEMACY. ท่านครับ — กรณีต่อไปนี้น่าสนใจสำหรับฉัน : — ฉันอยู่ในลอนดอนสองสัปดาห์ และได้รับผลกระทบมากจากโรคไขข้อกำเริบ การโจมตีครั้งแรกเกิดขึ้นหนึ่งสัปดาห์ก่อนที่ฉันจะพบคุณ และครั้งที่สองเมื่อฉันพบคุณ และครั้งที่สามเมื่อฉันพบคุณ และครั้งที่สามในเวลาเดียวกัน การโจมตีครั้งที่สองของโรคเกาต์นั้น ไม่ได้มีอาการไข้ร่วมด้วย แต่มีปัสสาวะไหลมากขึ้น และมีการขับปัสสาวะมากขึ้น การโจมตีครั้งที่สามเกิดขึ้นหนึ่งชั่วโมงหลังจากที่ฉันพบคุณ และตามด้วยการกลับมาของอาการเกาต์ และการกลับมาของเกาต์อย่างรวดเร็ว การโจมตีครั้งที่สี่ก็มีไข้ร่วมด้วย แต่ไม่เสมอไปที่จะมีอาการไข้ การโจมตีครั้งที่สามของเกาต์เกิดขึ้นสองสัปดาห์หลังจากคุณป่วย และครั้งที่สี่ตามด้วยอาการเกาต์ การโจมตีครั้งที่สี่เกิดขึ้นสองสัปดาห์หลังจากคุณถูกโจมตี และมีความรู้สึก

### **v2**

ฝึกด้วยชุดข้อมูล 90GB (112GB แบบโทเคน)
ฝึกถึง 182K ขั้นตอน

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  ชุดข้อมูล

### **v2**

- 90GB(ข้อมูลดิบ) ของข้อความลอนดอนช่วงปี 1800-1875
- 136,344 เอกสาร
- ชุดข้อมูลโทเคนเต็มสามารถดูได้ที่นี่: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### สถิติอคติ 
  ![อคติเรื่องสรรพนาม](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![อคติทางภูมิศาสตร์](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![อคติทางเวลา](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

ดู [รายงานอคติ v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) สำหรับข้อมูลเพิ่มเติม


## วิธีการใช้งาน

โปรเจกต์นี้มุ่งเน้นไปที่การรวบรวมข้อมูลประวัติศาสตร์ เตรียมข้อมูลสำหรับการฝึกสอน และการสร้างตัวตัดคำ ฉันจะไม่อธิบายกระบวนการฝึกสอน LLM ทั้งหมด สำหรับส่วนนั้นโปรดดู nanoGPT โดย Andrej Karpathy

### ขั้นตอนที่ 1: รวบรวมและเตรียมข้อความประวัติศาสตร์

- รวบรวมไฟล์ .txt ของหนังสือสาธารณสมบัติ เอกสาร ฯลฯ จากช่วงเวลาที่คุณเลือก (เช่น ลอนดอน 1800-1850)
- เก็บไว้ภายในกรอบเวลา/สถานที่ที่คุณเลือก
- ทำความสะอาดไฟล์ข้อความโดยใช้สคริปต์หรือเอาส่วนหัว/ท้ายจาก Project Gutenberg ออก รวมถึงคำอธิบายสมัยใหม่หรือข้อผิดพลาดจาก OCR

### ขั้นตอนที่ 2: สร้างตัวตัดคำที่กำหนดเอง

- รัน train_tokenizer.py หรือ train_tokenizer_hf.py กับข้อมูลที่ผ่านการทำความสะอาดแล้ว
- จะได้ไฟล์ vocab.json และ merges.txt
- ไฟล์เหล่านี้กำหนดคำศัพท์และกฎการรวมคำสำหรับโมเดลของคุณ

### ขั้นตอนที่ 3: ฝึกสอนโมเดลของคุณ

- ดูวิธีฝึกสอนที่ [nanoGPT โดย Andrej Karpathy](https://github.com/karpathy/nanoGPT) หรือคู่มือสถาปัตยกรรมที่คุณเลือก

# คำถามที่พบบ่อย

## Selective Temporal Training คืออะไร?

Selective Temporal Training (STT) คือวิธีการเรียนรู้ของเครื่องที่ข้อมูลฝึกสอนทั้งหมดจะถูกคัดเลือกมาโดยเฉพาะให้ตรงกับช่วงเวลาทางประวัติศาสตร์ที่ต้องการ เพื่อจำลองภาษาและความรู้ในยุคนั้นโดยไม่ถูกรบกวนจากแนวคิดสมัยใหม่ ตัวอย่างเช่น โมเดลปัจจุบัน (v0.5) ได้รับการฝึกสอนด้วยข้อมูลจากปี 1800-1875 เท่านั้น ไม่ได้ fine-tune แต่ฝึกจากศูนย์ ทำให้ผลลัพธ์สะท้อนสไตล์ภาษาและบริบทประวัติศาสตร์ของยุคนั้นอย่างแท้จริง

## ทำไมไม่ใช้ fine-tuning หรือ LoRA?

สำหรับโปรเจกต์นี้ ฉันต้องการสร้างโมเดลภาษาโดยปราศจากอคติจากยุคปัจจุบัน ถ้าฉัน fine-tune โมเดลอย่าง GPT-2 มันถูกฝึกไว้แล้วและข้อมูลเหล่านั้นจะไม่หายไป ถ้าฝึกจากศูนย์ โมเดลภาษาจะไม่แกล้งเป็นของเก่า แต่มันจะเป็นของเก่าจริง เป้าหมายตอนนี้คือสร้างบางอย่างที่ใช้เหตุผลโดยอิงจากความรู้ในหนังสือลอนดอนที่ตีพิมพ์ระหว่างปี 1800 ถึง 1875 เท่านั้น

## ใช้ข้อมูลประเภทใดในการฝึกสอน?

ฉันใช้หนังสือ เอกสารทางกฎหมาย หนังสือพิมพ์ และงานเขียนอื่น ๆ จากลอนดอนช่วงปี 1800–1875 รายการที่ฉันแนบไว้ (สำหรับ v0) มีประมาณ 200 รายการ แต่สำหรับการฝึกครั้งแรกฉันใช้เพียง 50 ไฟล์ ขนาดประมาณ ~187 MB คุณสามารถดูรายชื่อเอกสารได้ที่:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

ขนาดชุดข้อมูล:
- v0: ~187MB
- v0.5: ~435MB
- v1: ~6.25GB
- v2mini-eval1: 15GB ( -> ตัวอย่างจาก 90GB ของ v2)
- v2: 90GB

## ขนาดของโมเดลมีขนาดเท่าไร ?

v0: 16M พารามิเตอร์

v0.5: 123 guidance พารามิเตอร์

v1: 700M พารามิเตอร์

v2mini-eval1: 300M พารามิเตอร์

v2mini-eval2: 200M พารามิเตอร์

v2: 1.2B พารามิเตอร์

## สเปคการฝึกสอน ? 

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM เช่าใช้งาน

### v2mini-eval1/eval2
GPU: A100 SXM เช่าใช้งาน

### v2
GPU: H100 SXM เช่าใช้งาน

## คำขอบคุณ

ขอขอบคุณ [ดร. Hamed Yaghoobian](https://hamedyaghoobian.com) สำหรับการดูแลด้านวิชาการ คำแนะนำในการกำหนดกรอบการวิจัยและการประเมินผล รวมถึงการช่วยเหลือในการฝึกสอน tokenizer และการเตรียมชุดข้อมูลสำหรับรุ่น v2 ความคิดเห็นและประสบการณ์ของเขามีส่วนสำคัญในการปรับปรุงการนำเสนอผลงานนี้










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---