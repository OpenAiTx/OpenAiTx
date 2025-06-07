<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## สารบัญ

1. [บทนำ](#1-บทนำ)
2. [สรุปโมเดล](#2-สรุปโมเดล)
3. [ดาวน์โหลดโมเดล](#3-ดาวน์โหลดโมเดล)
4. [ผลการประเมิน](#4-ผลการประเมิน)
5. [เว็บไซต์แชท & แพลตฟอร์ม API](#5-เว็บไซต์แชท--แพลตฟอร์ม-api)
6. [วิธีรันโมเดลในเครื่อง](#6-วิธีรันโมเดลในเครื่อง)
7. [สัญญาอนุญาต](#7-สัญญาอนุญาต)
8. [การอ้างอิง](#8-การอ้างอิง)
9. [ติดต่อ](#9-ติดต่อ)


## 1. บทนำ

เราขอเสนอ DeepSeek-V3 ซึ่งเป็นโมเดลภาษาแบบ Mixture-of-Experts (MoE) ประสิทธิภาพสูง มีพารามิเตอร์รวม 671 พันล้าน โดยมี 37 พันล้านพารามิเตอร์ที่ถูกเปิดใช้งานต่อโทเคน
เพื่อให้เกิดการอนุมานที่มีประสิทธิภาพและการฝึกโมเดลที่คุ้มค่า DeepSeek-V3 ได้นำสถาปัตยกรรม Multi-head Latent Attention (MLA) และ DeepSeekMoE ซึ่งได้รับการตรวจสอบอย่างละเอียดใน DeepSeek-V2 มาใช้
นอกจากนี้ DeepSeek-V3 ยังเป็นผู้บุกเบิกกลยุทธ์สมดุลโหลดแบบไม่ใช้ auxiliary loss และกำหนดวัตถุประสงค์การฝึกแบบทำนายหลายโทเคน (multi-token prediction) เพื่อประสิทธิภาพที่แข็งแกร่งยิ่งขึ้น
เราได้ฝึก DeepSeek-V3 ล่วงหน้าด้วยข้อมูลหลากหลายและคุณภาพสูงกว่า 14.8 ล้านล้านโทเคน จากนั้นจึงเข้าสู่ขั้นตอนการปรับจูนแบบกำกับดูแลและการเรียนรู้แบบเสริมแรง (Supervised Fine-Tuning และ Reinforcement Learning) เพื่อใช้ศักยภาพของโมเดลอย่างเต็มที่
ผลการประเมินอย่างครอบคลุมแสดงให้เห็นว่า DeepSeek-V3 มีประสิทธิภาพเหนือกว่าโมเดลโอเพ่นซอร์สอื่น ๆ และมีสมรรถนะใกล้เคียงกับโมเดลแบบปิดชั้นนำ
แม้จะมีสมรรถนะยอดเยี่ยม DeepSeek-V3 ใช้เวลา GPU H800 เพียง 2.788 ล้านชั่วโมงในการฝึกเต็มรูปแบบ
นอกจากนี้ กระบวนการฝึกยังมีความเสถียรอย่างมาก
ตลอดกระบวนการฝึก ไม่พบการสูญเสียที่ไม่สามารถกู้คืนได้หรือการย้อนกลับใด ๆ
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. สรุปโมเดล

---

**สถาปัตยกรรม: กลยุทธ์สมดุลโหลดและวัตถุประสงค์การฝึกใหม่ล่าสุด**

- บนพื้นฐานของสถาปัตยกรรมที่มีประสิทธิภาพของ DeepSeek-V2 เราเป็นผู้บุกเบิกกลยุทธ์สมดุลโหลดแบบไม่ใช้ auxiliary loss ซึ่งช่วยลดการเสื่อมประสิทธิภาพที่เกิดจากการบังคับให้สมดุลโหลด
- เราได้ศึกษาวัตถุประสงค์ Multi-Token Prediction (MTP) และพิสูจน์ว่ามีประโยชน์ต่อประสิทธิภาพโมเดล
    ทั้งยังสามารถนำไปใช้กับ speculative decoding เพื่อเร่งการอนุมานได้

---

**การฝึกก่อน: สู่ประสิทธิภาพการฝึกสูงสุด**

- เราออกแบบเฟรมเวิร์กฝึกแบบ FP8 mixed precision และเป็นครั้งแรกที่ยืนยันความเป็นไปได้และประสิทธิผลของการฝึก FP8 บนโมเดลขนาดใหญ่มาก
- ด้วยการออกแบบร่วมกันระหว่างอัลกอริทึม เฟรมเวิร์ก และฮาร์ดแวร์ เราแก้ปัญหาคอขวดด้านการสื่อสารในการฝึก MoE ข้ามโหนด ทำให้เกิด computation-communication overlap แทบเต็ม 100%
  สิ่งนี้ช่วยเพิ่มประสิทธิภาพการฝึกอย่างมากและลดต้นทุน ทำให้สามารถขยายขนาดโมเดลได้โดยไม่เพิ่มค่าใช้จ่าย
- ด้วยต้นทุนเพียง 2.664 ล้านชั่วโมง GPU H800 เราสามารถฝึก DeepSeek-V3 ล่วงหน้าด้วยข้อมูล 14.8T โทเคน ซึ่งสร้างโมเดลฐานโอเพ่นซอร์สที่แข็งแกร่งที่สุดในปัจจุบัน ส่วนการฝึกต่อหลังฝึกก่อนใช้เวลาเพียง 0.1 ล้านชั่วโมง GPU

---

**หลังการฝึก: การกลั่นความรู้จาก DeepSeek-R1**

- เราเสนอวิธีการใหม่สำหรับการกลั่นความสามารถด้านเหตุผลจากโมเดล Long-Chain-of-Thought (CoT) โดยเฉพาะจากหนึ่งในซีรีส์ DeepSeek R1 ลงสู่ LLM มาตรฐานโดยเฉพาะ DeepSeek-V3 โดย pipeline นี้ผสานแบบแผนการตรวจสอบและไตร่ตรองของ R1 ลงใน DeepSeek-V3 ได้อย่างสวยงาม และช่วยยกระดับสมรรถนะด้านเหตุผลได้อย่างชัดเจน ขณะเดียวกันยังสามารถควบคุมรูปแบบและความยาวของผลลัพธ์จาก DeepSeek-V3 ได้

---


## 3. ดาวน์โหลดโมเดล

<div align="center">

| **โมเดล** | **#พารามิเตอร์รวม** | **#พารามิเตอร์ที่เปิดใช้งาน** | **ความยาวบริบท** | **ดาวน์โหลด** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | 671B | 37B | 128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | 671B | 37B |  128K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> ขนาดรวมของโมเดล DeepSeek-V3 บน Hugging Face คือ 685B ซึ่งรวม 671B น้ำหนักโมเดลหลัก และ 14B น้ำหนักโมดูล Multi-Token Prediction (MTP)

เพื่อให้ได้ประสิทธิภาพและความยืดหยุ่นที่ดีที่สุด เราร่วมมือกับชุมชนโอเพ่นซอร์สและผู้ผลิตฮาร์ดแวร์เพื่อมอบทางเลือกในการรันโมเดลในเครื่องหลายแบบ ดูวิธีการในส่วนที่ 6: [วิธีรันโมเดลในเครื่อง](#6-วิธีรันโมเดลในเครื่อง)

สำหรับนักพัฒนาที่ต้องการเจาะลึก แนะนำให้ดู [README_WEIGHTS.md](./README_WEIGHTS.md) สำหรับรายละเอียดน้ำหนักโมเดลหลักและโมดูล Multi-Token Prediction (MTP) หมายเหตุว่าการรองรับ MTP ยังอยู่ระหว่างการพัฒนาในชุมชน ยินดีต้อนรับทุกข้อเสนอแนะและการมีส่วนร่วม

## 4. ผลการประเมิน
### โมเดลฐาน
#### Benchmarks มาตรฐาน

<div align="center">


|  | Benchmark (Metric) | # Shots | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | สถาปัตยกรรม | - | MoE | Dense | Dense | MoE |
| | # พารามิเตอร์ที่เปิดใช้งาน | - | 21B | 72B | 405B | 37B |
| | # พารามิเตอร์รวม | - | 236B | 72B | 405B | 671B |
| English | Pile-test (BPB) | - | 0.606 | 0.638 | **0.542** | 0.548 |
| | BBH (EM) | 3-shot | 78.8 | 79.8 | 82.9 | **87.5** |
| | MMLU (Acc.) | 5-shot | 78.4 | 85.0 | 84.4 | **87.1** |
| | MMLU-Redux (Acc.) | 5-shot | 75.6 | 83.2 | 81.3 | **86.2** |
| | MMLU-Pro (Acc.) | 5-shot | 51.4 | 58.3 | 52.8 | **64.4** |
| | DROP (F1) | 3-shot | 80.4 | 80.6 | 86.0 | **89.0** |
| | ARC-Easy (Acc.) | 25-shot | 97.6 | 98.4 | 98.4 | **98.9** |
| | ARC-Challenge (Acc.) | 25-shot | 92.2 | 94.5 | **95.3** | **95.3** |
| | HellaSwag (Acc.) | 10-shot | 87.1 | 84.8 | **89.2** | 88.9 |
| | PIQA (Acc.) | 0-shot | 83.9 | 82.6 | **85.9** | 84.7 |
| | WinoGrande (Acc.) | 5-shot | **86.3** | 82.3 | 85.2 | 84.9 |
| | RACE-Middle (Acc.) | 5-shot | 73.1 | 68.1 | **74.2** | 67.1 |
| | RACE-High (Acc.) | 5-shot | 52.6 | 50.3 | **56.8** | 51.3 |
| | TriviaQA (EM) | 5-shot | 80.0 | 71.9 | 82.7 | **82.9** |
| | NaturalQuestions (EM) | 5-shot | 38.6 | 33.2 | **41.5** | 40.0 |
| | AGIEval (Acc.) | 0-shot | 57.5 | 75.8 | 60.6 | **79.6** |
| Code | HumanEval (Pass@1) | 0-shot | 43.3 | 53.0 | 54.9 | **65.2** |
| | MBPP (Pass@1) | 3-shot | 65.0 | 72.6 | 68.4 | **75.4** |
| | LiveCodeBench-Base (Pass@1) | 3-shot | 11.6 | 12.9 | 15.5 | **19.4** |
| | CRUXEval-I (Acc.) | 2-shot | 52.5 | 59.1 | 58.5 | **67.3** |
| | CRUXEval-O (Acc.) | 2-shot | 49.8 | 59.9 | 59.9 | **69.8** |
| Math | GSM8K (EM) | 8-shot | 81.6 | 88.3 | 83.5 | **89.3** |
| | MATH (EM) | 4-shot | 43.4 | 54.4 | 49.0 | **61.6** |
| | MGSM (EM) | 8-shot | 63.6 | 76.2 | 69.9 | **79.8** |
| | CMath (EM) | 3-shot | 78.7 | 84.5 | 77.3 | **90.7** |
| Chinese | CLUEWSC (EM) | 5-shot | 82.0 | 82.5 | **83.0** | 82.7 |
| | C-Eval (Acc.) | 5-shot | 81.4 | 89.2 | 72.5 | **90.1** |
| | CMMLU (Acc.) | 5-shot | 84.0 | **89.5** | 73.7 | 88.8 |
| | CMRC (EM) | 1-shot | **77.4** | 75.8 | 76.0 | 76.3 |
| | C3 (Acc.) | 0-shot | 77.4 | 76.7 | **79.7** | 78.6 |
| | CCPM (Acc.) | 0-shot | **93.0** | 88.5 | 78.6 | 92.0 |
| Multilingual | MMMLU-non-English (Acc.) | 5-shot | 64.0 | 74.8 | 73.8 | **79.4** |

</div>

> [!NOTE]
> คะแนนที่ดีที่สุดแสดงเป็นตัวหนา คะแนนที่ต่างกันไม่เกิน 0.3 ถือว่าอยู่ในระดับเดียวกัน DeepSeek-V3 มีสมรรถนะดีที่สุดใน benchmark ส่วนใหญ่ โดยเฉพาะงานด้านคณิตศาสตร์และโค้ด
> รายละเอียดเพิ่มเติมโปรดดูในเปเปอร์

#### Context Window
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

ผลการประเมินบนชุดทดสอบ ``Needle In A Haystack`` (NIAH) พบว่า DeepSeek-V3 มีประสิทธิภาพดีในทุกความยาวหน้าต่างบริบทสูงสุดถึง **128K**

### โมเดลแชท
#### Benchmarks มาตรฐาน (โมเดลใหญ่กว่า 67B)
<div align="center">

| | **Benchmark (Metric)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | สถาปัตยกรรม | MoE | MoE | Dense | Dense | - | - | MoE |
| | # พารามิเตอร์ที่เปิดใช้งาน | 21B | 21B | 72B | 405B | - | - | 37B |
| | # พารามิเตอร์รวม | 236B | 236B | 72B | 405B | - | - | 671B |
| English | MMLU (EM) | 78.2 | 80.6 | 85.3 | **88.6** | **88.3** | 87.2 | **88.5** |
| | MMLU-Redux (EM) | 77.9 | 80.3 | 85.6 | 86.2 | **88.9** | 88.0 | **89.1** |
| | MMLU-Pro (EM) | 58.5 | 66.2 | 71.6 | 73.3 | **78.0** | 72.6 | 75.9 |
| | DROP (3-shot F1) | 83.0 | 87.8 | 76.7 | 88.7 | 88.3 | 83.7 | **91.6** |
| | IF-Eval (Prompt Strict) | 57.7 | 80.6 | 84.1 | 86.0 | **86.5** | 84.3 | 86.1 |
| | GPQA-Diamond (Pass@1) | 35.3 | 41.3 | 49.0 | 51.1 | **65.0** | 49.9 | 59.1 |
| | SimpleQA (Correct) | 9.0 | 10.2 | 9.1 | 17.1 | 28.4 | **38.2** | 24.9 |
| | FRAMES (Acc.) | 66.9 | 65.4 | 69.8 | 70.0 | 72.5 | **80.5** | 73.3 |
| | LongBench v2 (Acc.) | 31.6 | 35.4 | 39.4 | 36.1 | 41.0 | 48.1 | **48.7** |
| Code | HumanEval-Mul (Pass@1) | 69.3 | 77.4 | 77.3 | 77.2 | 81.7 | 80.5 | **82.6** |
| | LiveCodeBench (Pass@1-COT) | 18.8 | 29.2 | 31.1 | 28.4 | 36.3 | 33.4 | **40.5** |
| | LiveCodeBench (Pass@1) | 20.3 | 28.4 | 28.7 | 30.1 | 32.8 | 34.2 | **37.6** |
| | Codeforces (Percentile) | 17.5 | 35.6 | 24.8 | 25.3 | 20.3 | 23.6 | **51.6** |
| | SWE Verified (Resolved) | - | 22.6 | 23.8 | 24.5 | **50.8** | 38.8 | 42.0 |
| | Aider-Edit (Acc.) | 60.3 | 71.6 | 65.4 | 63.9 | **84.2** | 72.9 | 79.7 |
| | Aider-Polyglot (Acc.) | - | 18.2 | 7.6 | 5.8 | 45.3 | 16.0 | **49.6** |
| Math | AIME 2024 (Pass@1) | 4.6 | 16.7 | 23.3 | 23.3 | 16.0 | 9.3 | **39.2** |
| | MATH-500 (EM) | 56.3 | 74.7 | 80.0 | 73.8 | 78.3 | 74.6 | **90.2** |
| | CNMO 2024 (Pass@1) | 2.8 | 10.8 | 15.9 | 6.8 | 13.1 | 10.8 | **43.2** |
| Chinese | CLUEWSC (EM) | 89.9 | 90.4 | **91.4** | 84.7 | 85.4 | 87.9 | 90.9 |
| | C-Eval (EM) | 78.6 | 79.5 | 86.1 | 61.5 | 76.7 | 76.0 | **86.5** |
| | C-SimpleQA (Correct) | 48.5 | 54.1 | 48.4 | 50.4 | 51.3 | 59.3 | **64.8** |

</div>

> [!NOTE]
> ทุกโมเดลถูกประเมินโดยจำกัดความยาวผลลัพธ์ที่ 8K ชุด benchmark ที่มีตัวอย่างน้อยกว่า 1000 จะทดสอบซ้ำหลายรอบที่ค่าอุณหภูมิต่างกันเพื่อให้ได้ผลลัพธ์ที่มั่นคง DeepSeek-V3 เป็นโมเดลโอเพ่นซอร์สที่มีสมรรถนะดีที่สุด และยังแข่งขันได้กับโมเดลปิดชั้นนำ


####  การประเมินการสร้างผลลัพธ์แบบ Open Ended

<div align="center">



| โมเดล | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | 76.2 | 50.5 |
| Qwen2.5-72B-Instruct | 81.2 | 49.1 |
| LLaMA-3.1 405B | 69.3 | 40.5 |
| GPT-4o-0513 | 80.4 | 51.1 |
| Claude-Sonnet-3.5-1022 | 85.2 | 52.0 |
| DeepSeek-V3 | **85.5** | **70.0** |

</div>

> [!NOTE]
> การประเมินบทสนทนาภาษาอังกฤษแบบ open-ended สำหรับ AlpacaEval 2.0 ใช้ metric อัตราชนะควบคุมความยาว


## 5. เว็บไซต์แชท & แพลตฟอร์ม API
คุณสามารถแชทกับ DeepSeek-V3 ได้ที่เว็บไซต์ทางการของ DeepSeek: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

เรายังมี API ที่ใช้งานร่วมกับ OpenAI ได้ที่ DeepSeek Platform: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. วิธีรันโมเดลในเครื่อง

DeepSeek-V3 สามารถปรับใช้ในเครื่องด้วยฮาร์ดแวร์และซอฟต์แวร์โอเพ่นซอร์สดังนี้

1. **DeepSeek-Infer Demo**: เรามี demo ที่เรียบง่ายและเบาสำหรับอนุมานแบบ FP8 และ BF16
2. **SGLang**: รองรับโมเดล DeepSeek-V3 อย่างเต็มรูปแบบทั้งโหมด BF16 และ FP8 อนุมาน พร้อม Multi-Token Prediction [เร็วๆ นี้](https://github.com/sgl-project/sglang/issues/2591)
3. **LMDeploy**: รองรับอนุมาน FP8 และ BF16 อย่างมีประสิทธิภาพสำหรับใช้งานในเครื่องและระบบ cloud
4. **TensorRT-LLM**: ปัจจุบันรองรับอนุมาน BF16 และ quantization INT4/8 โดย FP8 จะรองรับเร็ว ๆ นี้
5. **vLLM**: รองรับโมเดล DeepSeek-V3 ในโหมด FP8 และ BF16 สำหรับ tensor parallelism และ pipeline parallelism
6. **LightLLM**: รองรับการปรับใช้แบบ single-node หรือ multi-node สำหรับ FP8 และ BF16 อย่างมีประสิทธิภาพ
7. **AMD GPU**: สามารถรัน DeepSeek-V3 บน AMD GPU ผ่าน SGLang ในโหมด BF16 และ FP8
8. **Huawei Ascend NPU**: รองรับการรัน DeepSeek-V3 บนอุปกรณ์ Huawei Ascend

เนื่องจากเฟรมเวิร์กของเราใช้การฝึกแบบ FP8 เป็นหลัก เราจึงแจกจ่ายเฉพาะน้ำหนัก FP8 หากคุณต้องการน้ำหนักแบบ BF16 สำหรับการทดลอง สามารถใช้สคริปต์แปลงที่เตรียมไว้เพื่อแปลงได้

ตัวอย่างการแปลงน้ำหนัก FP8 เป็น BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Hugging Face Transformers ยังไม่รองรับโดยตรง

### 6.1 อนุมานด้วย DeepSeek-Infer Demo (ตัวอย่างเท่านั้น)

#### ข้อกำหนดระบบ

> [!NOTE] 
> รองรับเฉพาะ Linux และ Python 3.10 เท่านั้น ไม่รองรับ Mac และ Windows

Dependencies:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### การเตรียมน้ำหนักโมเดล & โค้ด Demo

ก่อนอื่น clone DeepSeek-V3 GitHub repository:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

เข้าไปที่โฟลเดอร์ `inference` และติดตั้ง dependencies ตาม `requirements.txt` แนะนำให้ใช้ package manager เช่น `conda` หรือ `uv` เพื่อสร้าง virtual environment ใหม่และติดตั้ง dependencies

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

ดาวน์โหลดน้ำหนักโมเดลจาก Hugging Face และนำไปไว้ในโฟลเดอร์ `/path/to/DeepSeek-V3`

#### การแปลงน้ำหนักโมเดล

แปลงน้ำหนักโมเดล Hugging Face เป็นรูปแบบเฉพาะ:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### การรัน

หลังจากนั้นคุณสามารถแชทกับ DeepSeek-V3 ได้:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

หรือทำ batch inference จากไฟล์ที่กำหนด:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 อนุมานด้วย SGLang (แนะนำ)

[SGLang](https://github.com/sgl-project/sglang) รองรับ [MLA optimizations](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations), [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models), FP8 (W8A8), FP8 KV Cache และ Torch Compile มอบประสิทธิภาพ latency และ throughput สูงสุดในบรรดาเฟรมเวิร์กโอเพ่นซอร์ส

[SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) รองรับการรัน DeepSeek-V3 บน **NVIDIA และ AMD GPU** อย่างเต็มรูปแบบ จึงเป็นโซลูชันที่ยืดหยุ่นและแข็งแกร่ง

SGLang ยังรองรับ [multi-node tensor parallelism](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208) ให้คุณรันโมเดลนี้บนหลายเครื่องที่เชื่อมต่อเครือข่าย

Multi-Token Prediction (MTP) อยู่ระหว่างพัฒนา ติดตามความคืบหน้าได้ที่ [optimization plan](https://github.com/sgl-project/sglang/issues/2591)

ดูวิธีรันจากทีม SGLang ได้ที่: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 อนุมานด้วย LMDeploy (แนะนำ)
[LMDeploy](https://github.com/InternLM/lmdeploy) เฟรมเวิร์กอนุมานและเสิร์ฟประสิทธิภาพสูงสำหรับ LLM ตอนนี้รองรับ DeepSeek-V3 ทั้งโหมด offline pipeline และ online deployment สามารถทำงานร่วมกับ PyTorch ได้อย่างไร้รอยต่อ

ดูขั้นตอนอย่างละเอียดสำหรับการรัน DeepSeek-V3 กับ LMDeploy ได้ที่: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 อนุมานด้วย TRT-LLM (แนะนำ)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) รองรับ DeepSeek-V3 แล้ว พร้อมตัวเลือกความละเอียด BF16 และ INT4/INT8 แบบ weight-only โดย FP8 จะรองรับเร็ว ๆ นี้ สามารถเข้าใช้งาน branch พิเศษของ TRTLLM สำหรับ DeepSeek-V3 ได้ที่: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3 


### 6.5 อนุมานด้วย vLLM (แนะนำ)

[vLLM](https://github.com/vllm-project/vllm) v0.6.6 รองรับอนุมาน DeepSeek-V3 สำหรับโหมด FP8 และ BF16 ทั้งบน NVIDIA และ AMD GPU vLLM มี pipeline parallelism ให้คุณรันบนหลายเครื่องที่เชื่อมต่อเครือข่าย คู่มือโดยละเอียดดูได้ที่ [vLLM instructions](https://docs.vllm.ai/en/latest/serving/distributed_serving.html) และติดตาม [enhancement plan](https://github.com/vllm-project/vllm/issues/11539) ได้เช่นกัน

### 6.6 อนุมานด้วย LightLLM (แนะนำ)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) v1.0.1 รองรับ tensor parallel deployment แบบ single-machine และ multi-machine สำหรับ DeepSeek-R1 (FP8/BF16) และมีการปรับใช้แบบ mixed-precision พร้อมโหมด quantization เพิ่มเติมอย่างต่อเนื่อง ดูรายละเอียดที่ [LightLLM instructions](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html) นอกจากนี้ LightLLM ยังมี PD-disaggregation สำหรับ DeepSeek-V2 และกำลังพัฒนา PD-disaggregation สำหรับ DeepSeek-V3

### 6.7 การอนุมานแนะนำกับ AMD GPU

ด้วยความร่วมมือกับทีม AMD เราสนับสนุน AMD GPU แบบ Day-One บน SGLang พร้อมรองรับ FP8 และ BF16 อย่างเต็มรูปแบบ ดูคำแนะนำโดยละเอียดที่ [SGLang instructions](#63-inference-with-lmdeploy-recommended)

### 6.8 การอนุมานแนะนำกับ Huawei Ascend NPU
เฟรมเวิร์ก [MindIE](https://www.hiascend.com/en/software/mindie) จากชุมชน Huawei Ascend ได้ปรับ DeepSeek-V3 เวอร์ชัน BF16 สำเร็จแล้ว ดูวิธีใช้งานบน Ascend NPU ได้ที่ [instructions here](https://modelers.cn/models/MindIE/deepseekv3)


## 7. สัญญาอนุญาต
ซอร์สโค้ดนี้อยู่ภายใต้ [MIT License](LICENSE-CODE) การใช้โมเดล DeepSeek-V3 Base/Chat ต้องเป็นไปตาม [Model License](LICENSE-MODEL) DeepSeek-V3 ทุกเวอร์ชัน (Base และ Chat) รองรับการใช้งานเชิงพาณิชย์

## 8. การอ้างอิง
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. ติดต่อ
หากมีคำถาม โปรดแจ้ง issue หรืออีเมลหาเราได้ที่ [service@deepseek.com](service@deepseek.com)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---