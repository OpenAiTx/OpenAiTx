# DeepSeek-R1
<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-R1" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/" target="_blank"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/" target="_blank"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20R1-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai" target="_blank"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5" target="_blank"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true" target="_blank"><img alt="WeChat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai" target="_blank"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE"><img alt="License"
    src="https://img.shields.io/badge/License-MIT-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Paper Link</b>👁️</a>
</div>

## 1. บทนำ

เราขอแนะนำโมเดลการให้เหตุผลรุ่นแรกของเรา ได้แก่ DeepSeek-R1-Zero และ DeepSeek-R1  
DeepSeek-R1-Zero เป็นโมเดลที่ฝึกด้วยการเรียนรู้แบบเสริมกำลัง (RL) ขนาดใหญ่โดยไม่มีการปรับแต่งแบบมีผู้สอน (SFT) เป็นขั้นตอนเบื้องต้น และแสดงประสิทธิภาพที่โดดเด่นด้านการให้เหตุผล  
ด้วยกระบวนการ RL, DeepSeek-R1-Zero ได้แสดงพฤติกรรมการให้เหตุผลที่ทรงพลังและน่าสนใจจำนวนมากโดยธรรมชาติ  
อย่างไรก็ตาม DeepSeek-R1-Zero ยังพบปัญหาบางประการ เช่น การวนซ้ำไม่รู้จบ การอ่านเข้าใจยาก และการปะปนของภาษา เพื่อแก้ไขข้อจำกัดเหล่านี้และยกระดับความสามารถด้านการให้เหตุผล  
เราจึงนำเสนอ DeepSeek-R1 ที่รวมข้อมูล cold-start ก่อนเข้าสู่กระบวนการ RL  
DeepSeek-R1 มีประสิทธิภาพเทียบเท่า OpenAI-o1 ในงานด้านคณิตศาสตร์, โค้ด และงานให้เหตุผล  
เพื่อสนับสนุนชุมชนนักวิจัย เราได้เปิดซอร์ส DeepSeek-R1-Zero, DeepSeek-R1 และโมเดล dense ขนาด 6 ตัว ที่กลั่น (distill) จาก DeepSeek-R1 โดยอิงกับ Llama และ Qwen ซึ่ง DeepSeek-R1-Distill-Qwen-32B มีผลลัพธ์เหนือกว่า OpenAI-o1-mini ในหลาย benchmark และสร้างมาตรฐานใหม่สำหรับโมเดล dense

**หมายเหตุ: ก่อนใช้งาน DeepSeek-R1 series ในเครื่องของท่าน เราขอแนะนำให้ศึกษาส่วน [ข้อแนะนำการใช้งาน](#usage-recommendations) ก่อน**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. สรุปโมเดล

---

**การฝึกหลังการอบรม: Reinforcement Learning ขนาดใหญ่บนโมเดลฐาน**

-  เรานำ RL มาใช้กับโมเดลฐานโดยตรงโดยไม่ต้องพึ่ง SFT เป็นขั้นตอนเบื้องต้น วิธีนี้ช่วยให้โมเดลสามารถสำรวจ chain-of-thought (CoT) เพื่อแก้ปัญหาซับซ้อน ส่งผลให้เกิด DeepSeek-R1-Zero ซึ่งแสดงความสามารถเช่น การตรวจสอบตนเอง การสะท้อนความคิด และการสร้าง CoT ที่ยาว ซึ่งเป็นหมุดหมายสำคัญของวงการวิจัย และถือเป็นการเปิดตัวงานวิจัยโอเพ่นซอร์สชิ้นแรกที่ยืนยันว่า LLM สามารถถูกขับเคลื่อนความสามารถด้าน reasoning ได้ด้วย RL เพียงอย่างเดียวโดยไม่ต้องมี SFT ความก้าวหน้านี้เป็นการปูทางสู่การพัฒนาต่อไปในอนาคต

-  เรานำเสนอ pipeline ในการพัฒนา DeepSeek-R1 ซึ่ง pipeline นี้ประกอบด้วย 2 ช่วง RL เพื่อค้นหารูปแบบ reasoning ที่ดีขึ้นและปรับให้สอดคล้องกับความต้องการของมนุษย์ รวมถึง 2 ช่วง SFT เพื่อเป็นเมล็ดพันธุ์สำหรับความสามารถ reasoning และ non-reasoning ของโมเดล  
เราเชื่อว่า pipeline นี้จะเป็นประโยชน์ต่ออุตสาหกรรมสำหรับการสร้างโมเดลที่ดีกว่า

---

**Distillation: โมเดลขนาดเล็กก็ทรงพลังได้เช่นกัน**

-  เราแสดงให้เห็นว่ารูปแบบ reasoning ของโมเดลขนาดใหญ่สามารถกลั่น (distill) ไปสู่โมเดลขนาดเล็กได้ ส่งผลให้โมเดลขนาดเล็กมีประสิทธิภาพเหนือกว่ารูปแบบ reasoning ที่ค้นพบผ่าน RL บนโมเดลขนาดเล็ก โดย DeepSeek-R1 ที่เปิดซอร์สรวมถึง API จะเป็นประโยชน์ต่อชุมชนวิจัยในการกลั่นโมเดลขนาดเล็กที่ดียิ่งขึ้นในอนาคต
- โดยใช้ข้อมูล reasoning ที่สร้างจาก DeepSeek-R1 เราได้ fine-tune โมเดล dense หลายตัวที่ได้รับความนิยมในชุมชนวิจัย ผลการประเมินชี้ให้เห็นว่าโมเดล dense ที่กลั่นมีประสิทธิภาพยอดเยี่ยมใน benchmark ต่างๆ เราได้เปิดซอร์ส checkpoint ที่กลั่นแล้ว ได้แก่ 1.5B, 7B, 8B, 14B, 32B, และ 70B โดยอิงกับ Qwen2.5 และ Llama3 series สู่ชุมชน

## 3. ดาวน์โหลดโมเดล

### DeepSeek-R1 Models

<div align="center">

| **Model** | **#Total Params** | **#Activated Params** | **Context Length** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero & DeepSeek-R1 ได้รับการฝึกโดยอิงกับ DeepSeek-V3-Base  
สำหรับรายละเอียดเพิ่มเติมเกี่ยวกับสถาปัตยกรรมโมเดล กรุณาดูที่ [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3)

### DeepSeek-R1-Distill Models

<div align="center">

| **Model** | **Base Model** | **Download** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

DeepSeek-R1-Distill โมเดลได้รับการ fine-tune จากโมเดล open-source โดยใช้ตัวอย่างที่สร้างโดย DeepSeek-R1  
เราได้ปรับค่าคอนฟิกและ tokenizer เล็กน้อย กรุณาใช้การตั้งค่าของเราในการรันโมเดลเหล่านี้

## 4. ผลการประเมิน

### DeepSeek-R1-Evaluation
 สำหรับโมเดลของเรา กำหนดความยาวสูงสุดในการสร้าง (generation length) ที่ 32,768 tokens สำหรับ benchmark ที่ต้องการ sampling เราใช้ค่า temperature $0.6$ ค่า top-p $0.95$ และสร้างคำตอบ 64 ชุดต่อ query เพื่อประเมิน pass@1
<div align="center">


| Category | Benchmark (Metric) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | Architecture | - | - | MoE | - | - | MoE |
| | # Activated Params | - | - | 37B | - | - | 37B |
| | # Total Params | - | - | 671B | - | - | 671B |
| English | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| Code | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Math | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Chinese | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### ผลการประเมินโมเดล Distill


<div align="center">

| Model                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
|------------------------------------------|------------------|-------------------|-----------------|----------------------|----------------------|-------------------|
| GPT-4o-0513                          | 9.3              | 13.4              | 74.6            | 49.9                 | 32.9                 | 759               |
| Claude-3.5-Sonnet-1022             | 16.0             | 26.7                 | 78.3            | 65.0                 | 38.9                 | 717               |
| o1-mini                              | 63.6             | 80.0              | 90.0            | 60.0                 | 53.8                 | **1820**          |
| QwQ-32B-Preview                              | 44.0             | 60.0                 | 90.6            | 54.5               | 41.9                 | 1316              |
| DeepSeek-R1-Distill-Qwen-1.5B       | 28.9             | 52.7              | 83.9            | 33.8                 | 16.9                 | 954               |
| DeepSeek-R1-Distill-Qwen-7B          | 55.5             | 83.3              | 92.8            | 49.1                 | 37.6                 | 1189              |
| DeepSeek-R1-Distill-Qwen-14B         | 69.7             | 80.0              | 93.9            | 59.1                 | 53.1                 | 1481              |
| DeepSeek-R1-Distill-Qwen-32B        | **72.6**         | 83.3              | 94.3            | 62.1                 | 57.2                 | 1691              |
| DeepSeek-R1-Distill-Llama-8B         | 50.4             | 80.0              | 89.1            | 49.0                 | 39.6                 | 1205              |
| DeepSeek-R1-Distill-Llama-70B        | 70.0             | **86.7**          | **94.5**        | **65.2**             | **57.5**             | 1633              |

</div>


## 5. เว็บไซต์แชท & แพลตฟอร์ม API
คุณสามารถสนทนากับ DeepSeek-R1 ได้ที่เว็บไซต์ทางการของ DeepSeek: [chat.deepseek.com](https://chat.deepseek.com) และเปิดปุ่ม "DeepThink"

เรายังให้บริการ API ที่รองรับ OpenAI ที่ DeepSeek Platform: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. วิธีรันบนเครื่องของคุณ

### DeepSeek-R1 Models

กรุณาเยี่ยมชม repo [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) เพื่อดูข้อมูลเพิ่มเติมเกี่ยวกับการใช้งาน DeepSeek-R1 บนเครื่องของคุณ

**หมายเหตุ: Hugging Face Transformers ยังไม่รองรับโดยตรง**

### DeepSeek-R1-Distill Models

DeepSeek-R1-Distill สามารถใช้งานเช่นเดียวกับโมเดล Qwen หรือ Llama

ตัวอย่างเช่น คุณสามารถเริ่มให้บริการได้อย่างง่ายดายด้วย [vLLM](https://github.com/vllm-project/vllm):

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

หรือเริ่มบริการด้วย [SGLang](https://github.com/sgl-project/sglang) ได้ง่ายๆ เช่นกัน

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### ข้อแนะนำการใช้งาน

**เราแนะนำให้ปฏิบัติตามการตั้งค่าต่อไปนี้เมื่อใช้งาน DeepSeek-R1 series รวมถึงการ benchmark เพื่อให้ได้ประสิทธิภาพที่คาดหวัง:**

1. ตั้งค่า temperature อยู่ในช่วง 0.5-0.7 (แนะนำ 0.6) เพื่อป้องกันการวนซ้ำไม่รู้จบหรือผลลัพธ์ที่ไม่ต่อเนื่อง
2. **ไม่ควรเพิ่ม system prompt; คำสั่งทั้งหมดควรอยู่ใน user prompt เท่านั้น**
3. สำหรับโจทย์คณิตศาสตร์ ควรเพิ่มคำสั่งใน prompt เช่น: "โปรดให้เหตุผลทีละขั้นตอน และใส่คำตอบสุดท้ายไว้ใน \boxed{}."
4. เมื่อประเมินประสิทธิภาพโมเดล ควรทดสอบหลายครั้งและหาค่าเฉลี่ยผลลัพธ์

นอกจากนี้ เราสังเกตว่า DeepSeek-R1 series มักข้ามรูปแบบการคิด (เช่น การ output "\<think\>\n\n\</think\>") เมื่อเจอ query บางประเภท ซึ่งอาจส่งผลเสียต่อประสิทธิภาพโมเดล  
**เพื่อให้มั่นใจว่าโมเดลจะให้เหตุผลอย่างรอบคอบ เราแนะนำให้บังคับให้โมเดลเริ่มต้นคำตอบทุกครั้งด้วย "\<think\>\n"**

### Official Prompts
ในเว็บ/แอป DeepSeek อย่างเป็นทางการ เราไม่ใช้ system prompt แต่มี prompt พิเศษ 2 แบบสำหรับอัปโหลดไฟล์และค้นเว็บ เพื่อประสบการณ์ที่ดีขึ้น ทั้งนี้ temperature ในเว็บ/แอปคือ 0.6

สำหรับการอัปโหลดไฟล์ กรุณาสร้าง prompt ตามเทมเพลตนี้ โดย {file_name}, {file_content} และ {question} เป็น argument
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

สำหรับ Web Search, {search_results}, {cur_date}, และ {question} เป็น argument

สำหรับ query ภาษาไทย/จีน เราใช้ prompt นี้:
```
search_answer_zh_template = \
'''# 以下内容是基于用户发送的消息的搜索结果:
{search_results}
在我给你的搜索结果中，每个结果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的数字索引。请在适当的情况下在句子末尾引用上下文。请按照引用编号[citation:X]的格式在答案中对应部分引用上下文。如果一句话源自多个上下文，请列出所有相关的引用编号，例如[citation:3][citation:5]，切记不要将引用集中在最后返回引用编号，而是在答案对应部分列出。
在回答时，请注意以下几点：
- 今天是{cur_date}。
- 并非搜索结果的所有内容都与用户的问题密切相关，你需要结合问题，对搜索结果进行甄别、筛选。
- 对于列举类的问题（如列举所有航班信息），尽量将答案控制在10个要点以内，并告诉用户可以查看搜索来源、获得完整信息。优先提供信息完整、最相关的列举项；如非必要，不要主动告诉用户搜索结果未提供的内容。
- 对于创作类的问题（如写论文），请务必在正文的段落中引用对应的参考编号，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解读并概括用户的题目要求，选择合适的格式，充分利用搜索结果并抽取重要信息，生成符合用户要求、极具思想深度、富有创造力与专业性的答案。你的创作篇幅需要尽可能延长，对于每一个要点的论述要推测用户的意图，给出尽可能多角度的回答要点，且务必信息量大、论述详尽。
- 如果回答很长，请尽量结构化、分段落总结。如果需要分点作答，尽量控制在5个点以内，并合并相关的内容。
- 对于客观类的问答，如果问题的答案非常简短，可以适当补充一到两句相关信息，以丰富内容。
- 你需要根据用户要求和回答内容选择合适、美观的回答格式，确保可读性强。
- 你的回答应该综合多个相关网页来回答，不能重复引用一个网页。
- 除非用户要求，否则你回答的语言需要和用户提问的语言保持一致。

# 用户消息为：
{question}'''
```

สำหรับ query ภาษาอังกฤษ เราใช้ prompt นี้:
```
search_answer_en_template = \
'''# The following contents are the search results related to the user's message:
{search_results}
In the search results I provide to you, each result is formatted as [webpage X begin]...[webpage X end], where X represents the numerical index of each article. Please cite the context at the end of the relevant sentence when appropriate. Use the citation format [citation:X] in the corresponding part of your answer. If a sentence is derived from multiple contexts, list all relevant citation numbers, such as [citation:3][citation:5]. Be sure not to cluster all citations at the end; instead, include them in the corresponding parts of the answer.
When responding, please keep the following points in mind:
- Today is {cur_date}.
- Not all content in the search results is closely related to the user's question. You need to evaluate and filter the search results based on the question.
- For listing-type questions (e.g., listing all flight information), try to limit the answer to 10 key points and inform the user that they can refer to the search sources for complete information. Prioritize providing the most complete and relevant items in the list. Avoid mentioning content not provided in the search results unless necessary.
- For creative tasks (e.g., writing an essay), ensure that references are cited within the body of the text, such as [citation:3][citation:5], rather than only at the end of the text. You need to interpret and summarize the user's requirements, choose an appropriate format, fully utilize the search results, extract key information, and generate an answer that is insightful, creative, and professional. Extend the length of your response as much as possible, addressing each point in detail and from multiple perspectives, ensuring the content is rich and thorough.
- If the response is lengthy, structure it well and summarize it in paragraphs. If a point-by-point format is needed, try to limit it to 5 points and merge related content.
- For objective Q&A, if the answer is very brief, you may add one or two related sentences to enrich the content.
- Choose an appropriate and visually appealing format for your response based on the user's requirements and the content of the answer, ensuring strong readability.
- Your answer should synthesize information from multiple relevant webpages and avoid repeatedly citing the same webpage.
- Unless the user requests otherwise, your response should be in the same language as the user's question.

# The user's message is:
{question}'''
```

## 7. ใบอนุญาต
ซอร์สโค้ดและน้ำหนักโมเดลนี้อยู่ภายใต้ [MIT License](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE)  
DeepSeek-R1 series รองรับการใช้งานเชิงพาณิชย์ อนุญาตให้แก้ไขและสร้างงานดัดแปลงได้ทุกรูปแบบ รวมถึงการ distill เพื่อนำไปฝึก LLM อื่น ๆ โปรดทราบว่า:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B และ DeepSeek-R1-Distill-Qwen-32B ถูกพัฒนาต่อจาก [Qwen-2.5 series](https://github.com/QwenLM/Qwen2.5) ซึ่งมีใบอนุญาต [Apache 2.0 License](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE) และถูก fine-tune ด้วยข้อมูล 800k ตัวอย่างที่คัดสรรโดย DeepSeek-R1
- DeepSeek-R1-Distill-Llama-8B พัฒนาต่อจาก Llama3.1-8B-Base ใต้ใบอนุญาต [Llama3.1 license](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE)
- DeepSeek-R1-Distill-Llama-70B พัฒนาต่อจาก Llama3.3-70B-Instruct ใต้ใบอนุญาต [Llama3.3 license](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE)

## 8. การอ้างอิง
```bibtex
@misc{deepseekai2025deepseekr1incentivizingreasoningcapability,
      title={DeepSeek-R1: Incentivizing Reasoning Capability in LLMs via Reinforcement Learning}, 
      author={DeepSeek-AI},
      year={2025},
      eprint={2501.12948},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2501.12948}, 
}
```

## 9. ติดต่อ
หากมีคำถาม กรุณาแจ้ง issue หรือ ติดต่อเราที่ [service@deepseek.com](mailto:service@deepseek.com)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---