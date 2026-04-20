<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  หากคุณพบว่าโปรเจกต์นี้มีประโยชน์,<br>
  การให้ดาว ⭐ บน GitHub จะเป็นที่ชื่นชมอย่างยิ่ง!
</p>

---

## โครงสร้างของ Repository
ที่เก็บ GitHub **ThinkSound** นี้เป็นที่รวมสองโปรเจกต์ที่เกี่ยวข้องกันอยู่บนสาขาแยกต่างหาก:

| สาขา | โปรเจกต์ | เอกสารประกอบ |
|------|----------|--------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — การสร้าง Any2Audio แบบรวมด้วยการจับคู่โฟลว์ที่นำโดย CoT | ไฟล์นี้: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — งานต่อยอด (ICLR 2026) สำหรับ video-to-audio ด้วย CoT-RL หลายมิติ | **`README.md`** ในสาขา [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

สำหรับ **ThinkSound** ให้ใช้สาขา **`master`** (README นี้) สำหรับ **PrismAudio** ให้ checkout สาขา **`prismaudio`** และอ่าน **`README.md`** ที่นั่น

---

**ThinkSound** คือกรอบการสร้าง Any2Audio แบบรวมด้วยการจับคู่โฟลว์ที่นำโดยการให้เหตุผลแบบ Chain-of-Thought (CoT)

การใช้งาน PyTorch สำหรับสร้างและแก้ไขเสียงแบบมัลติโหมด: สร้างหรือแก้ไขเสียงจากวิดีโอ ข้อความ และเสียง ด้วยการให้เหตุผลทีละขั้นจาก Multimodal Large Language Models (MLLMs)

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ข่าวสาร
- **2026.03.24** &nbsp; 🔥 **PrismAudio** เปิดตัวใน repo เดียวกันบนสาขา [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — ดู **`README.md`** ที่นั่นสำหรับการติดตั้งและโมเดล
- **2026.01.26** &nbsp; 🎉 PrismAudio ได้รับการตอบรับเข้าสู่ **ICLR 2026 Main Conference** (code/docs อยู่ที่ `prismaudio`)
- **2025.11.25** &nbsp; 🔥 [PrismAudio Demo ออนไลน์](http://prismaudio-project.github.io/) เปิดให้ใช้งานแล้ว
- **2025.11.25** &nbsp; 🔥 [PrismAudio paper](https://arxiv.org/pdf/2511.18833) บน arXiv — CoT-RL หลายมิติสำหรับ video-to-audio
- **2025.09.19** &nbsp; 🎉 **ThinkSound** ได้รับการตอบรับเข้าสู่ **NeurIPS 2025 Main Conference**!
- **2025.09.01** &nbsp; ชุดข้อมูล AudioCoT เปิดโอเพนซอร์สแล้วและมีให้ใช้งานที่ [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 เปิดใช้งานการ finetuning: โค้ดสำหรับเทรนและ finetune พร้อมใช้งานสาธารณะ พร้อมคำแนะนำใช้งานที่ชัดเจนเพื่อปรับแต่งและขยาย ThinkSound ด้วยข้อมูลของคุณเอง
- **2025.07.15** &nbsp; 📦 การติดตั้งและใช้งานง่ายขึ้น: dependency บน PyPI สำหรับการตั้งค่าข้ามแพลตฟอร์มง่าย ๆ; สคริปต์ Windows `.bat` อัตโนมัติสร้าง environment และรันสคริปต์
- **2025.07.08** &nbsp;  🔧 อัปเดตครั้งใหญ่: โมเดลน้ำหนักเบาขึ้นและปรับแต่งการใช้หน่วยความจำและ GPU รองรับการสร้างเสียงแบบ throughput สูงในระดับใหญ่!
- **2025.07.01** &nbsp; เดโมออนไลน์ที่ [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) และ [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) เพื่อประสบการณ์แบบ interactive!
- **2025.07.01** &nbsp; เปิดตัวสคริปต์ inference และเว็บอินเทอร์เฟซ;
- **2025.06** &nbsp; [ThinkSound paper](https://arxiv.org/pdf/2506.21448) เผยแพร่บน arXiv!
- **2025.06** &nbsp; [เดโมออนไลน์](http://thinksound-project.github.io/) เปิดให้ใช้งานแล้ว - ลองเลย!

---


<div align="center">

### งานต่อยอด: PrismAudio (repo เดียวกัน, สาขา `prismaudio`)


**PrismAudio** คือผู้สืบทอดของ ThinkSound (ICLR 2026) ที่พัฒนาภายใต้ชื่อใหม่ แต่ยังคงอยู่ในที่เก็บนี้บน branch **`prismaudio`** การติดตั้ง, checkpoints, และการอ้างอิง อยู่ใน **[`README.md` บนสาขานั้น](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) หรือเปิด branch นี้บน GitHub

</div>

---


## 🚀 คุณสมบัติ

- **Any2Audio**: สร้างเสียงจากรูปแบบอินพุตใดก็ได้ — วิดีโอ, ข้อความ, เสียง หรือการผสมผสานกัน
- **Video-to-Audio SOTA**: ได้ผลลัพธ์ระดับ state-of-the-art ในหลายมาตรฐาน V2A
- **CoT-Driven Reasoning**: การให้เหตุผลแบบ Chain-of-Thought สำหรับการสร้างเสียงที่ประกอบและควบคุมได้ด้วย MLLMs
- **Interactive Object-centric Editing**: ปรับแต่งหรือแก้ไขเหตุการณ์เสียงเฉพาะโดยคลิกที่วัตถุในภาพหรือใช้คำสั่งข้อความ
- **Unified Framework**: โมเดลรากฐานเดียวรองรับการสร้าง, แก้ไข และเวิร์กโฟลว์แบบโต้ตอบ

---

## ✨ ภาพรวมวิธีการ

ThinkSound แยกการสร้างและแก้ไขเสียงออกเป็น 3 ขั้นตอนแบบโต้ตอบ ทั้งหมดขับเคลื่อนโดยการให้เหตุผลแบบ Chain-of-Thought (CoT) ที่อิงกับ MLLM:

1. **Foley Generation:** สร้างซาวด์สเคปพื้นฐานที่สอดคล้องกันในเชิงความหมายและเวลา จากวิดีโอ
2. **Object-Centric Refinement:** ปรับแต่งหรือเพิ่มเสียงสำหรับวัตถุที่ผู้ใช้กำหนดผ่านการคลิกหรือเลือกบริเวณในวิดีโอ
3. **Targeted Audio Editing:** แก้ไขเสียงที่สร้างขึ้นโดยใช้คำสั่งภาษาธรรมชาติระดับสูง

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- มีชุดข้อมูลขนาดใหญ่ที่มีการใส่คำอธิบาย CoT (**AudioCoT**) สำหรับฝึกทั้งโมดูลให้เหตุผลและโมเดลเสียงรากฐานแบบรวม
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ เริ่มต้นอย่างรวดเร็ว

**การเตรียมสภาพแวดล้อม:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **เคล็ดลับสำหรับ Windows:**  
> ผู้ใช้ Windows สามารถรัน `setup_windows.bat` (หรือดับเบิลคลิกไฟล์นี้) เพื่อสร้างสภาพแวดล้อม conda ติดตั้งทุก dependency (รวมถึง FFmpeg) และดาวน์โหลดโมเดลที่ผ่านการฝึกมาแล้วโดยอัตโนมัติ — ไม่ต้องตั้งค่าด้วยตนเอง  
> ตรวจสอบให้แน่ใจว่าได้ติดตั้ง `conda` และ `git` และทั้งสองอยู่ใน PATH ของระบบก่อนรันสคริปต์นี้


### ▶️ รันเดโม

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

คุณสามารถใช้สคริปต์ `.bat` ที่ให้มาแทนได้:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**หมายเหตุ:**

* `<path-to-your-demo-video>`: เส้นทางไปยังวิดีโอตัวอย่างของคุณ
* `[use-half]` (ไม่บังคับ): เพิ่ม use-half ต่อท้ายเพื่อเปิดใช้งานการดึงคุณลักษณะแบบ half precision

---

### 📦 การทำนายแบบกลุ่ม

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

ใช้สคริปต์ `.bat` ที่เทียบเท่า:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**หมายเหตุ:**

* `<video_path>`: เส้นทางไปยังไดเรกทอรีหลักที่มีไฟล์วิดีโอ .mp4 ทั้งหมดที่จะประมวลผล (วิดีโอทั้งหมดต้องมีระยะเวลาเท่ากัน)
* `<csv_path>`: ไฟล์ CSV ที่มีข้อความพรอมต์สำหรับแต่ละวิดีโอ (ดูรูปแบบได้ที่ `demo_test.csv`)
* `<save_path>` (ไม่บังคับ): ตำแหน่งที่จะบันทึกไฟล์เสียงที่สร้างขึ้น ค่าเริ่มต้นคือ `results/features`
* `[use-half]` (ไม่บังคับ): เพิ่ม use-half ต่อท้ายเพื่อเปิดใช้งานการสกัดคุณลักษณะด้วยความแม่นยำครึ่งหนึ่ง

---


### การใช้งานผ่านเว็บอินเทอร์เฟซ

สำหรับประสบการณ์แบบโต้ตอบ ให้เปิดใช้งาน Gradio web interface:


```bash
python app.py
```

## 🏋️ ฝึกสอนโมเดล

ดูที่ [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 ใบอนุญาต

โปรเจกต์นี้เผยแพร่ภายใต้ใบอนุญาต Apache 2.0

> **หมายเหตุ:**
> โค้ด โมเดล และชุดข้อมูลนี้ **สำหรับการวิจัยและการศึกษาเท่านั้น**
> **ไม่อนุญาตให้ใช้เชิงพาณิชย์**
> หากต้องการขออนุญาตใช้เชิงพาณิชย์ กรุณาติดต่อผู้เขียน

**📦 คอมโพเนนต์จากบุคคลที่สาม**

* **Stable Audio Open VAE** (โดย Stability AI):
  ที่เก็บนี้รวม VAE ที่ปรับแต่งแล้วจาก [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) ซึ่งอยู่ภายใต้ [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)
  **การใช้เชิงพาณิชย์และการแจกจ่ายซ้ำต้องได้รับอนุญาตล่วงหน้าจาก Stability AI**

* 📘 **โค้ดและโมเดลอื่น ๆ ทั้งหมด** เผยแพร่ภายใต้ Apache License 2.0

---

## คำขอบคุณ

ขอขอบคุณเป็นอย่างยิ่งแก่:

* **stable-audio-tools** (โดย Stability AI):
สำหรับเฟรมเวิร์กที่ใช้งานง่ายสำหรับการสร้างเสียง ตลอดจนโมดูล VAE และน้ำหนักโมเดล
* **MMAudio**:
  สำหรับการพัฒนา MM-DiT backbone ในด้านเสียง

---


## 📖 การอ้างอิง

หากคุณพบว่าโครงการของเรามีประโยชน์ในการวิจัยหรือการทำงานของคุณ กรุณาอ้างอิงบทความของเรา:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---