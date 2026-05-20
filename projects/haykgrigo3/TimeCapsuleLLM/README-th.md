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

## เข้าร่วม Vintage LLM Discord

หากคุณสนใจใน **โมเดลภาษาทางประวัติศาสตร์**, **ชุดข้อมูลที่เจาะจงตามยุคเวลา**, หรืออนาคตของโปรเจกต์อย่าง **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** เชิญเข้าร่วมชุมชนของเราได้เลย

เราจะใช้เซิร์ฟเวอร์นี้เพื่อพูดคุยแลกเปลี่ยนไอเดีย, แบ่งปันความคืบหน้า และเชื่อมต่อกับผู้ที่กำลังพัฒนาในสายนี้

[เข้าร่วม Discord](https://discord.gg/JeWkk4z5)

##  พฤติกรรมของโมเดล & ข้อจำกัด

### **v0**  

พรอมต์ในระยะแรกแสดงให้เห็นว่าโมเดลตอบสนองด้วยภาษาและพฤติกรรมแบบยุค 1800  
ตัวอย่าง: พรอมต์: "Who art Henry?" และมันตอบว่า "I know that man, I have did not a black, the storm." 

![ตัวอย่างผลลัพธ์ TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- ไม่มีการกล่าวถึงแนวคิดสมัยใหม่  
- คำศัพท์ส่วนใหญ่ตรงกับยุคนั้น  
- ประโยคโดยมากไม่สอดคล้องกัน (คาดการณ์ได้จากข้อมูลฝึกสอน ~187MB)

### **v0.5-london** 

เป็นการพัฒนาครั้งสำคัญจาก v0  
- สไตล์การเขียนแบบยุควิกตอเรีย, มีเครื่องหมายวรรคตอนถูกต้อง, ประโยคส่วนใหญ่ถูกไวยากรณ์  
- ยังมีอัตราการแต่งข้อมูลสูง  
- ยังมีเสียงรบกวนจาก OCR (“Digitized by Google”) ในผลลัพธ์

![ตัวอย่างผลลัพธ์ TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

เป็นโมเดลแรกที่สามารถจดจำและเชื่อมโยงเหตุการณ์ประวัติศาสตร์จริงกับบุคคลจริงในชุดข้อมูล

ตัวอย่าง: พรอมต์: "It was the year of our Lord 1834" 

ผลลัพธ์: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

ตอนแรกฉันคิดว่าอาจมีการประท้วงเกิดขึ้นโดยบังเอิญในปีเดียวกัน แต่ลองดูสิ่งนี้: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

ฝึกด้วยตัวอย่างขนาด 15GB จากชุดข้อมูล 90GB ของ v2
โมเดลถูกฝึกเพียง 10,000 สเต็ปเท่านั้น

มีปัญหาเกี่ยวกับการทำโทเคนที่ทำให้ผลลัพธ์ออกมาดูแบบนี้:

คำสั่ง:
Charles Dickens คือใคร?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

แก้ไขแล้ว:

"Charles Dickens คือใคร? งานของเขาที่สร้างความตื่นเต้นยอดเยี่ยมนั้นมีมากขึ้นในบทละครของเขาหรือในฟาร์มของ Great Company หรือไม่? ฉันยังไม่ได้อ้างอิงจาก Jack Pickett อีกหรือ? คุณไม่รู้หรือว่าพวกเขาเป็นพวกที่วิ่งพล่าน หรือเอามือเลื่อยอกตัวเอง หรืออะไรก็ตามที่ควรทำในเวลาที่แจ็คสันกำลังมองออกไปทางหน้าต่าง? ความสำเร็จของชาวอังกฤษคืออะไร และสิ่งที่ลูกชายของเขายังไม่ค้นพบกับฉัน ซึ่งจะช่วยให้บรรลุเป้าหมายอันหนักหนานั้น? คุณเคยเดินทางเข้าสู่ถนนสายเก่าหรือไม่ หรือไปที่ท่าเรือที่ปลายเรือของเรา ซึ่งคุณต้องจากเราไป? ข้อเท็จจริงก็คือ ไม่ว่าลมจะพัดขึ้นมาจากที่ราบในคืนวันเสาร์หรือเที่ยงวัน หรือพัดไปทางเหนือ หรืออื่นใด เราจะถูกบังคับให้ต้องบรรยายถึงอุปสรรคที่น่ากลัว ด้วยผลลัพธ์เช่นเดียวกับปัจจุบัน ในสถานการณ์นี้ อย่างน้อย ก็ไม่เกินไปที่จะพูดว่าเราทิ้งห้องนั้นไปแล้ว ฉันเชื่อว่ามีสามฉบับใน 'Five Hundred-fold' ให้ใช้อ้างอิง ในฐานะหมายเลขแรกของผู้อ่านเราที่ต้องการ[t o]..."

### **v2mini-eval2-london**

ฝึกด้วยชุดข้อมูลตัวอย่าง 15GB เดียวกันกับที่ใช้ฝึก eval1
โมเดลนี้ฝึกเพียง 10,000 สเต็ปเท่านั้น

PROMPT:Charles Darwin

Charles DarwinECCEMACY. ท่านครับ — กรณีต่อไปนี้น่าสนใจสำหรับผม: — ผมอยู่ที่ลอนดอนสองสัปดาห์ และได้รับผลกระทบจากอาการปวดข้อรูมาติกส์ การโจมตีรูมาติกส์ครั้งแรกเกิดขึ้นหนึ่งสัปดาห์ก่อนผมเจอคุณ และครั้งที่สองในวันที่ผมเจอคุณ และครั้งที่สามก็ในเวลาเดียวกันนั้น อย่างไรก็ตาม การโจมตีของเกาต์ครั้งที่สองไม่ได้มาพร้อมกับอาการไข้ แต่มีปัสสาวะเพิ่มขึ้นและการขับปัสสาวะมากขึ้น การโจมตีครั้งที่สามเกิดขึ้นหนึ่งชั่วโมงหลังจากที่ผมเจอคุณ และตามมาด้วยการกลับมาของอาการเกาต์และการกลับมาอย่างรวดเร็วของเกาต์ การโจมตีครั้งที่สี่ก็มาพร้อมกับไข้แต่ไม่เสมอไปที่มีอาการไข้ การโจมตีเกาต์ครั้งที่สามเกิดขึ้นสองสัปดาห์หลังจากที่คุณป่วย และครั้งที่สี่ตามมาด้วยอาการเกาต์ การโจมตีครั้งที่สี่เกิดขึ้นสองสัปดาห์หลังจากคุณถูกโจมตี และมาพร้อมกับความรู้สึก

### **v2-london**

ฝึกด้วยชุดข้อมูล 90GB (112GB หลังแปลงเป็นโทเคน)
ฝึกถึง 182,000 สเต็ป

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **มีอะไรต่อไป?**

- เริ่มพัฒนา TimeCapsuleLLM v3 แล้ว
- ขยายขนาดชุดข้อมูลและครอบคลุมพื้นที่กว้างขึ้น
- ขยายจากลอนดอนไปยังเมืองอื่น ๆ เพิ่มเติม

การดำเนินงานนี้เป็นความร่วมมือกับนักวิจัยจาก University College London (UCL) และกำลังหารือการมีส่วนร่วมจากสถาบันอื่นเพิ่มเติม


## ชุดข้อมูล

### **v2**

- 90GB(ดิบ) ของข้อความลอนดอนช่วงปี 1800-1875
- 136,344 เอกสาร
- ชุดข้อมูลที่แปลงเป็นโทเคนสมบูรณ์สามารถดูได้ที่: https://huggingface.co/datasets/postgrammar/london-llm-1800

### สถิติเกี่ยวกับอคติ  
![อคติด้านสรรพนาม](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![อคติด้านภูมิศาสตร์](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![อคติด้านเวลา](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

ดูข้อมูลเพิ่มเติมได้ที่ [v2 bias report](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json)

-

## วิธีการใช้งาน

โปรเจกต์นี้มุ่งเน้นการคัดเลือกข้อมูลประวัติศาสตร์ เตรียมข้อมูลเพื่อการฝึก และการสร้าง tokenizer ที่เหมาะสม ไม่ได้ครอบคลุมกระบวนการฝึก LLM ทั้งหมด หากต้องการรายละเอียดเพิ่มเติมให้ดูที่ nanoGPT โดย Andrej Karpathy

### ขั้นตอนที่ 1: รวบรวมและเตรียมข้อความประวัติศาสตร์

- รวบรวมไฟล์ .txt ของหนังสือหรือเอกสารสาธารณสมบัติ จากช่วงเวลาที่เลือก (เช่น ลอนดอน 1800-1875)
- เก็บไฟล์เหล่านั้นให้อยู่ในช่วงเวลา/สถานที่ที่เลือก  
- ทำความสะอาดไฟล์ข้อความโดยใช้สคริปต์หรือเอาหัวเรื่อง/ท้ายเรื่องของ Project Gutenberg, คำอธิบายสมัยใหม่ หรือข้อผิดพลาดของ OCR ออกด้วยตนเอง

### ขั้นตอนที่ 2: สร้าง Tokenizer แบบกำหนดเอง

- รัน train_tokenizer.py หรือ train_tokenizer_hf.py กับข้อมูลที่ทำความสะอาดแล้ว
- จะได้ไฟล์ vocab.json และ merges.txt
- ไฟล์เหล่านี้กำหนดคำศัพท์และกฎการรวมสำหรับโมเดลของคุณ

### ขั้นตอนที่ 3: ฝึกโมเดลของคุณ

- ดูรายละเอียดกระบวนการฝึกที่ [nanoGPT โดย Andrej Karpathy](https://github.com/karpathy/nanoGPT) หรือดูเอกสารของสถาปัตยกรรมที่คุณเลือก

# คำถามที่พบบ่อย

## Selective Temporal Training คืออะไร?

Selective Temporal Training (STT) คือกระบวนการทางแมชชีนเลิร์นนิงที่ข้อมูลฝึกทั้งหมดถูกคัดเลือกมาเฉพาะให้ตรงกับช่วงเวลาประวัติศาสตร์ที่กำหนดไว้ เพื่อจำลองภาษาและความรู้ของยุคนั้นโดยปราศจากอิทธิพลจากแนวคิดสมัยใหม่ ตัวอย่างเช่น โมเดลปัจจุบัน (v0.5) ได้รับการฝึกโดยใช้ข้อมูลเฉพาะปี 1800-1875 ไม่ได้ใช้วิธี fine-tune แต่ฝึกจากศูนย์ ทำให้ผลลัพธ์ที่ได้สะท้อนรูปแบบภาษาและบริบททางประวัติศาสตร์ของช่วงเวลานั้น

## ทำไมไม่ใช้แค่ fine-tuning หรือ LoRA?


สำหรับโปรเจกต์นี้ ฉันกำลังพยายามสร้างโมเดลภาษาให้ปราศจากอคติสมัยใหม่ หากฉันทำการฟายน์จูนโมเดลอย่าง GPT-2 มันก็ถูกพรีเทรนมาแล้วและข้อมูลนั้นจะไม่หายไป หากฉันฝึกจากศูนย์ โมเดลภาษาจะไม่แกล้งทำตัวเก่า แต่มันจะเป็นเช่นนั้นจริงๆ เป้าหมายของโปรเจกต์ตอนนี้คือสร้างบางสิ่งที่สามารถให้เหตุผลโดยอิงจากความรู้ในหนังสือลอนดอนที่ตีพิมพ์ระหว่างปี 1800 ถึง 1875 เท่านั้น

## คุณใช้ข้อมูลประเภทใดในการฝึกโมเดล?

ฉันใช้หนังสือ เอกสารทางกฎหมาย หนังสือพิมพ์ และงานเขียนอื่นๆ จากลอนดอนช่วงปี 1800–1875 รายการที่ฉันแนบไว้ (สำหรับ v0) มีประมาณ 200 ไฟล์ แต่สำหรับการฝึกครั้งแรกฉันใช้เพียง 50 ไฟล์ ขนาดประมาณ ~187 MB คุณสามารถดูรายชื่อเอกสารได้ที่:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

ขนาดชุดข้อมูล:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (ตัวอย่างจาก v2 ขนาด 90GB)
- v2: 90GB

## โมเดลมีขนาดเท่าไรบ้าง?

v0: 16M พารามิเตอร์

v0.5: 123M พารามิเตอร์

v1: 700M พารามิเตอร์

v2mini-eval1: 300M พารามิเตอร์

v2mini-eval2: 200M พารามิเตอร์

v2: 1.2B พารามิเตอร์

## ข้อมูลการฝึกอบรม?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM เช่า

### v2mini-eval1/eval2

GPU: A100 SXM เช่าใช้งาน

### v2
GPU: H100 SXM เช่าใช้งาน

## งานที่เกี่ยวข้อง

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - LLM ขนาด 13B พารามิเตอร์ที่ได้รับการฝึกด้วยข้อความ 260B โทเคนก่อนปี 1930 พร้อม Q&A และมี [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base) เวอร์ชันด้วย
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - LLM ขนาด 1.4B พารามิเตอร์ที่ได้รับการฝึกด้วยข้อความช่วงปี 1800-1899 พร้อม Q&A และมี [160M](https://huggingface.co/zakarth/violet-160m-chat) เวอร์ชันด้วย
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - LLM ขนาด 340M พารามิเตอร์ที่ได้รับการฝึกด้วยข้อความมากกว่า 28,000 รายการระหว่างปี 1837-1899 พร้อม Q&A

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - ตระกูล LLM ขนาด 4B พารามิเตอร์บนสถาปัตยกรรม Qwen3 ที่ฝึกใหม่จากศูนย์ด้วยข้อมูลประวัติศาสตร์ 80B โทเคนจนถึง knowledge-cutoffs 1913,1929,1933,1939,1946

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT เป็นการปรับแต่ง Mistral-Hermes 2 ด้วยข้อความยุคต้นสมัยใหม่ 11,000 ชิ้นในภาษาอังกฤษ ฝรั่งเศส และละติน ส่วนใหญ่มาจาก EEBO และ Gallica

## คำขอบคุณ

ขอขอบคุณ [ดร. Hamed Yaghoobian](https://hamedyaghoobian.com) สำหรับการดูแลด้านวิชาการ คำแนะนำในการกำหนดกรอบและประเมินงานวิจัย และความช่วยเหลือในการฝึก tokenizer และจัดเตรียมชุดข้อมูลสำหรับการออก v2 ข้อเสนอแนะและประสบการณ์ของท่านมีส่วนสำคัญในการปรับปรุงการนำเสนอผลงานนี้











































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---