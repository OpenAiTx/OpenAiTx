![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim คือเฟรมเวิร์กสำหรับการจำลองจาก AgiBot ซึ่งมอบความสามารถในการสร้างข้อมูลและเกณฑ์การประเมินที่มีประสิทธิภาพให้กับนักพัฒนาเพื่อเร่งกระบวนการพัฒนาเทคโนโลยี embodied intelligence Genie Sim ได้สร้างท่อส่งข้อมูลแบบปิดที่ครบถ้วน ครอบคลุมการสร้างเทรจ็กทอรี การฝึกโมเดล การประเมินผล และการตรวจสอบการใช้งานจริง ผู้ใช้สามารถตรวจสอบประสิทธิภาพของอัลกอริทึมและปรับแต่งโมเดลได้อย่างรวดเร็วผ่านเครื่องมือจำลองที่มีประสิทธิภาพนี้ ไม่ว่าจะเป็นงานหยิบจับที่เรียบง่ายหรืองานที่ซับซ้อน Genie Sim สามารถมอบสภาพแวดล้อมการจำลองที่สมจริงและเกณฑ์การประเมินที่แม่นยำ ช่วยให้นักพัฒนาสามารถพัฒนาและปรับปรุงเทคโนโลยีหุ่นยนต์ได้อย่างมีประสิทธิภาพ

Genie Sim Benchmark ในฐานะเวอร์ชันโอเพนซอร์สสำหรับการประเมินผลของ Genie Sim มุ่งเน้นไปที่การให้การทดสอบประสิทธิภาพที่แม่นยำและสนับสนุนการปรับแต่งสำหรับโมเดล AI แบบ embodied

# 2. คุณสมบัติ
- การตั้งค่าและอินเทอร์เฟซการจำลองที่ยืดหยุ่นและใช้งานง่าย
- เกณฑ์การประเมินและงานจำลองสำหรับงาน manipulation กว่า 10 รูปแบบ
- ความสามารถในการควบคุมระยะไกลผ่าน VR และคีย์บอร์ด
- บันทึกและเล่นซ้ำท่าทางของข้อต่อทั้งหมดและตำแหน่งปลาย effector
- สภาพแวดล้อมและแอสเซท 3D กว่า 550 รายการที่มีความสมจริงสูงและถูกต้องตามฟิสิกส์
- เกณฑ์การประเมินมาตรฐานเพื่อวัดประสิทธิภาพของโมเดล AI แบบ embodied
- ผลลัพธ์การประเมินมีความคลาดเคลื่อนระหว่างการจำลองและโลกจริงน้อยกว่า 5% บนโมเดล GO-1
- รองรับโมเดล baseline UniVLA ในการประเมินผลการจำลอง

# 3. อัปเดต
- [25/6/2025] v2.1
  - เพิ่มงาน manipulation อีก 10 รายการสำหรับ Agibot World Challenge 2025 รวมถึงแอสเซทการจำลองทั้งหมด
  - เปิดซอร์สชุดข้อมูลสังเคราะห์สำหรับ 10 งาน manipulation บน Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - ผสานนโยบาย UniVLA และรองรับการประเมินการอนุมานโมเดลในการจำลอง
  - อัปเดต SDK ตัวแก้ปัญหา IK ซึ่งรองรับการแก้ปัญหา IK ข้ามรูปร่างสำหรับหุ่นยนต์อื่น ๆ
  - ปรับปรุงเฟรมเวิร์กการสื่อสารและเพิ่มความเร็วการทำงานของการจำลองขึ้น 2 เท่า
  - อัปเดตเฟรมเวิร์กการประเมินอัตโนมัติสำหรับงานที่ซับซ้อนและไกลขึ้น

# 4. เนื้อหา

## 4.1 บทนำ
เกณฑ์การประเมินการจำลอง embodied intelligence ใน Genie Sim ถูกออกแบบมาเพื่อประเมินและขับเคลื่อนการพัฒนาโมเดล AI แบบ embodied โดยเกณฑ์เหล่านี้นำเสนอสิ่งแวดล้อมที่สมจริง งานที่หลากหลาย และเมตริกมาตรฐานในการวัดประสิทธิภาพของระบบหุ่นยนต์ AI ซึ่งช่วยลดความจำเป็นในการใช้ฮาร์ดแวร์ราคาแพงและการทดสอบในโลกจริง หลีกเลี่ยงสถานการณ์ทดสอบที่เสี่ยงและอันตราย และเร่งกระบวนการฝึกและประเมินผลของเอเจนต์ AI

## 4.2 เริ่มต้นใช้งาน
โปรดดูที่ [หน้านี้](https://agibot-world.com/sim-evaluation/docs/#/v2) สำหรับการติดตั้ง คู่มือผู้ใช้ และการอ้างอิง API

## 4.3 การสนับสนุน
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 รายการ TODO
- [x] ปล่อยงาน manipulation แบบ long-horizon เพิ่มเติม
- [x] เพิ่มฉากและแอสเซทสำหรับแต่ละงาน benchmark
- [x] รองรับโมเดล baseline ของ Agibot World Challenge
- [ ] เครื่องมือจัดเลย์เอาต์ฉากและสร้างเทรจ็กทอรี manipulation ให้ทั่วไป

## 4.5 คำถามที่พบบ่อย
- วิธีปิดเซิร์ฟเวอร์ isaac sim เมื่อเกิดข้อผิดพลาด ทำให้โปรเซสไม่ตอบสนอง?
  ฆ่าโปรเซสใน terminal โดยใช้ `pkill -9 -f raise_standalone_sim`
- วิธีเลือกโหมดเรนเดอร์ต่าง ๆ?
  โหมดเรนเดอร์เริ่มต้นคือ `RaytracedLighting(RealTime)` สำหรับงานที่มีวัตถุโปร่งใส ให้ใช้ `RealTimePathTracing(RealTime-2.0)` เพื่อแสดงความสัมพันธ์เชิงมุมมองของวัตถุ

## 4.6 ใบอนุญาตและการอ้างอิง
ข้อมูลและโค้ดทั้งหมดใน repo นี้อยู่ภายใต้ Mozilla Public License 2.0
โปรดพิจารณาอ้างอิงงานของเราดังต่อไปนี้หากเป็นประโยชน์กับงานวิจัยของคุณ
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 การอ้างอิง
1. PDDL Parser (2020). Version 1.1. [Source code]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [Source code]. https://github.com/StanfordVL/bddl
3. CUROBO [Source code]. https://github.com/NVlabs/curobo
4. Isaac Lab [Source code]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Source code]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---