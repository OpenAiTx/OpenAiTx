<div align="center">

<img alt="LOGO" src="https://raw.githubusercontent.com/fishaudio/Bert-VITS2/master/avatars.githubusercontent.com/u/122017386" width="256" height="256" />

# Bert-VITS2

VITS2 Backbone พร้อม bert หลายภาษา

สำหรับคู่มือด่วน กรุณาอ้างอิงที่ `webui_preprocess.py`.

简易教程请参见 `webui_preprocess.py`。

## 【项目推介】
# FishAudio ได้เปิดตัว TTS แบบ autoregressive ใหม่ [Fish-Speech](https://github.com/fishaudio/fish-speech) ซึ่งมีประสิทธิภาพในระดับ SOTA ที่เปิดเผยในปัจจุบัน และยังมีการดูแลรักษาอย่างต่อเนื่อง แนะนำให้ใช้โปรเจกต์นี้เป็นตัวแทนของ BV2/GSV โปรเจกต์นี้จะไม่ถูกดูแลในระยะสั้น
## วิดีโอตัวอย่าง: https://www.bilibili.com/video/BV18E421371Q
## วิดีโอสไลด์เทคนิค: https://www.bilibili.com/video/BV1zJ4m1K7cj
## โปรดทราบ แนวคิดหลักของโปรเจกต์นี้มาจาก [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS) ซึ่งเป็นโปรเจกต์ tts ที่ดีมาก
## ตัวอย่างสาธิตของ MassTTS คือ [ai版峰哥锐评峰哥本人,并找回了在金三角失落的腰子](https://www.bilibili.com/video/BV1w24y1c7z9)

[//]: # (## โปรเจกต์นี้ไม่มีความเกี่ยวข้องใดๆ กับ [PlayVoice/vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41;)

[//]: # ()
[//]: # (คลังนี้มาจากเพื่อนที่แชร์วิดีโอ ai峰哥 ซึ่งผมประทับใจกับผลลัพธ์ หลังจากลอง MassTTS พบว่า fs มีความแตกต่างในคุณภาพเสียงกับ vits และ pipeline การฝึกซ้อมซับซ้อนกว่ามาก จึงทำตามแนวคิดโดยใช้ bert)

## นักเดินทาง/นักบุกเบิก/กัปตัน/ด็อกเตอร์/เซนเซย์/นักล่าปีศาจ/เมียวเมียวลู/V ควรศึกษารหัสด้วยตนเองเพื่อเรียนรู้การฝึกอบรม

### ห้ามใช้โปรเจกต์นี้ในกิจกรรมที่ขัดต่อ "รัฐธรรมนูญแห่งสาธารณรัฐประชาชนจีน" "ประมวลกฎหมายอาญาแห่งสาธารณรัฐประชาชนจีน" "กฎหมายว่าด้วยการบริหารความสงบเรียบร้อยของสาธารณรัฐประชาชนจีน" และ "ประมวลกฎหมายแพ่งแห่งสาธารณรัฐประชาชนจีน"
### ห้ามใช้ในวัตถุประสงค์ทางการเมืองใดๆ
#### วิดีโอ: https://www.bilibili.com/video/BV1hp4y1K78E
#### ตัวอย่าง: https://www.bilibili.com/video/BV1TF411k78w
## เอกสารอ้างอิง
+ [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)
+ [jaywalnut310/vits](https://github.com/jaywalnut310/vits)
+ [p0p4k/vits2_pytorch](https://github.com/p0p4k/vits2_pytorch)
+ [svc-develop-team/so-vits-svc](https://github.com/svc-develop-team/so-vits-svc)
+ [PaddlePaddle/PaddleSpeech](https://github.com/PaddlePaddle/PaddleSpeech)
+ [emotional-vits](https://github.com/innnky/emotional-vits)
+ [fish-speech](https://github.com/fishaudio/fish-speech)
+ [Bert-VITS2-UI](https://github.com/jiangyuxiaoxiao/Bert-VITS2-UI)
## ขอบคุณผู้ร่วมพัฒนาทุกท่านที่ทุ่มเทแรงกายแรงใจ
<a href="https://github.com/fishaudio/Bert-VITS2/graphs/contributors" target="_blank">
  <img src="https://contrib.rocks/image?repo=fishaudio/Bert-VITS2"/>
</a>

[//]: # (# โค้ดทั้งหมดในโปรเจกต์นี้มีการอ้างอิงอย่างชัดเจน ส่วนโค้ด bert มาจากแนวคิดของ [AI峰哥]&#40;https://www.bilibili.com/video/BV1w24y1c7z9&#41; ไม่มีความเกี่ยวข้องกับ [vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41; ยินดีให้ทุกคนตรวจสอบโค้ด พร้อมทั้งประณามพฤติกรรม [การแอบอ้างและการเปิดกล่องของนักพัฒนา]&#40;https://www.bilibili.com/read/cv27101514/&#41; อย่างรุนแรง)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---