<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

ที่เก็บข้อมูลนี้ประกอบด้วยโค้ดและข้อมูลสำหรับ SynLogic ซึ่งเป็นเฟรมเวิร์กการสังเคราะห์ข้อมูลการให้เหตุผลเชิงตรรกะที่ครอบคลุม สามารถสร้างข้อมูลการให้เหตุผลที่หลากหลายและตรวจสอบได้ในปริมาณมาก ผลงานของเรานี้ตอบโจทย์ช่องว่างสำคัญของข้อมูลฝึกสอนด้านการให้เหตุผลเชิงตรรกะที่มีคุณภาพสูง สำหรับการพัฒนาความสามารถในการให้เหตุผลทั่วไปในแบบจำลองภาษาขนาดใหญ่ (LLMs)

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## ข่าวสาร
- **[2025/07/07]** :fire: เราได้ให้คำแนะนำในการใช้ข้อมูล SynLogic เพื่อฝึก RL ด้วยเฟรมเวิร์ก Verl ดูรายละเอียดได้ที่ [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) 

- **[2025/06/03]** :fire: ปล่อยโมเดลที่ฝึกแล้วบน Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: เราตื่นเต้นที่ได้ปล่อยทรัพยากรสำหรับงานวิจัย "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 ภาพรวม

**SynLogic** คือเฟรมเวิร์กการสังเคราะห์ข้อมูลและชุดข้อมูลที่ครอบคลุม ซึ่ง:
- 📊 **ครอบคลุม 35 งานการให้เหตุผลเชิงตรรกะที่หลากหลาย** เช่น Sudoku, Game of 24, Cipher, Arrow Maze และอื่นๆ อีกมาก
- 🎯 **รองรับการสังเคราะห์ข้อมูลที่ควบคุมความยากได้** ด้วยพารามิเตอร์ที่ปรับได้สำหรับแต่ละงาน
- ✅ **ให้รางวัลที่ตรวจสอบได้** ด้วยการตรวจสอบตามกฎสำหรับการฝึก RL
- 🚀 **ทำผลงานได้ SOTA** ในหมู่ชุดข้อมูลโอเพ่นซอร์ส เหนือกว่า DeepSeek-R1-Distill-Qwen-32B ถึง 6 คะแนนใน BBEH

### คุณสมบัติเด่น
- **การสร้างข้อมูลขนาดใหญ่ที่ปรับระดับความยากได้**: สังเคราะห์ข้อมูลได้ไม่จำกัดพร้อมระดับความยากที่ควบคุมได้
- **ครอบคลุมงานอย่างครบถ้วน**: 35 งานการให้เหตุผลเชิงตรรกะแบบเฉพาะพร้อมตัวสร้างและตัวตรวจสอบที่ปรับแต่งได้
- **พร้อมสำหรับ RL**: ตัวอย่างทั้งหมดสามารถตรวจสอบด้วยกฎง่ายๆ เหมาะกับการเรียนรู้แบบเสริมแรง
- **ถ่ายโอนข้ามโดเมน**: มีความสามารถทั่วไปที่แข็งแกร่งต่อโดเมนคณิตศาสตร์และโค้ดดิ้ง

## 🚀 เริ่มต้นอย่างรวดเร็ว

### การติดตั้ง
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### สร้างข้อมูลตัวอย่าง (ตัวอย่าง Arrow Maze)
```bash
# ตัวอย่างอย่างรวดเร็วกับ Arrow Maze
bash games/tasks/arrow_maze/run.sh

# หรือกำหนดพารามิเตอร์เอง
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### สำหรับการฝึก RL

เราให้คำแนะนำอย่างละเอียดสำหรับการใช้ข้อมูล SynLogic ในการฝึก reinforcement learning ดูคำแนะนำแบบละเอียดสำหรับการเชื่อมต่อ SynLogic กับเฟรมเวิร์ก Verl ได้ที่ [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md)

## :rocket: ทรัพยากร

### ชุดข้อมูล
| ชื่อชุดข้อมูล | คำอธิบาย | ลิงก์ |
|:------------:|:------------|:----:|
| **SynLogic** | ชุดข้อมูล | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### โมเดล


| ชื่อโมเดล | คำอธิบาย | ลิงก์ |
|:-----------|:------------|:----:|
| **SynLogic-7B** | โมเดล 7B ที่ฝึกด้วย SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | โมเดล 32B ที่ฝึกด้วย SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | โมเดล 32B ที่ฝึกด้วยข้อมูลผสม SynLogic, Math, Coding | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 การอัปเดตในอนาคต
เรากำลังดำเนินการขยาย SynLogic ด้วยงานการให้เหตุผลเชิงตรรกะที่หลากหลายมากขึ้น

ติดตามคลังเก็บของเราเพื่อรับข่าวสารและการอัปเดตล่าสุด!

## การอ้างอิง
โปรดอ้างถึงบทความของเราหากคุณพบว่างานวิจัยของเรามีประโยชน์:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---