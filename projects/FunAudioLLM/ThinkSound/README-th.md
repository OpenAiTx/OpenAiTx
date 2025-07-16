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
  หากคุณพบว่าโปรเจกต์นี้มีประโยชน์<br>
  ขอขอบคุณเป็นอย่างยิ่งหากกดดาว ⭐ บน GitHub!
</p>

---

**ThinkSound** คือเฟรมเวิร์ก Any2Audio แบบรวมศูนย์สำหรับการสร้างเสียง โดยขับเคลื่อนด้วยเทคนิค flow matching และ Chain-of-Thought (CoT) reasoning

เป็นการใช้งาน PyTorch สำหรับสร้างและแก้ไขเสียงแบบมัลติโหมด: สร้างหรือแก้ไขเสียงจากวิดีโอ ข้อความ และเสียง โดยอาศัยการให้เหตุผลทีละขั้นจาก Multimodal Large Language Models (MLLMs)

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ข่าวสาร
- **2025.07.15** &nbsp; 📦 ติดตั้งและใช้งานง่ายขึ้น: ขึ้นกับแพ็กเกจ PyPI เพื่อความสะดวกในการติดตั้งข้ามแพลตฟอร์ม; สคริปต์ Windows `.bat` สร้าง environment และรันสคริปต์ให้อัตโนมัติ
- **2025.07.08** &nbsp;  🔧 อัปเดตใหญ่: ลดขนาดโมเดลและปรับการใช้งานหน่วยความจำ/การ์ดจอ GPU ให้เหมาะสม รองรับการสร้างเสียงปริมาณมากได้แล้ว!
- **2025.07.01** &nbsp; 🔥เดโมออนไลน์บน [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) และ [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) สำหรับประสบการณ์แบบ interactive!
- **2025.07.01** &nbsp; 🔥ปล่อยสคริปต์ inference และเว็บอินเตอร์เฟซ;
- **2025.06** &nbsp; 🔥[เผยแพร่บทความ ThinkSound](https://arxiv.org/pdf/2506.21448) บน arXiv!
- **2025.06** &nbsp; 🔥[เดโมออนไลน์](http://thinksound-project.github.io/) พร้อมให้ลองใช้งานแล้ว!

---


## 🚀 คุณสมบัติเด่น

- **Any2Audio**: สร้างเสียงจากมัลติโหมดใด ๆ — วิดีโอ, ข้อความ, เสียง หรือผสมผสานกัน
- **Video-to-Audio SOTA**: ได้ผลลัพธ์ระดับ state-of-the-art บน benchmark V2A หลายรายการ
- **CoT-Driven Reasoning**: การให้เหตุผลแบบ Chain-of-Thought สำหรับการสร้างเสียงแบบประกอบและควบคุมได้ผ่าน MLLMs
- **Interactive Object-centric Editing**: ปรับแต่งหรือแก้ไขเสียงเฉพาะเหตุการณ์ในภาพด้วยการคลิกวัตถุในวิดีโอหรือใช้คำสั่งข้อความ
- **Unified Framework**: โมเดลรากฐานเดียว รองรับทั้งการสร้าง แก้ไข และเวิร์กโฟลว์แบบโต้ตอบ

---

## ✨ ภาพรวมวิธีการ

ThinkSound แบ่งการสร้างและแก้ไขเสียงออกเป็น 3 ขั้นตอนแบบโต้ตอบ โดยได้รับคำแนะนำจาก Chain-of-Thought reasoning ของ MLLM:

1. **Foley Generation:** สร้างเสียงพื้นฐานที่สอดคล้องทั้งความหมายและเวลา จากวิดีโอ
2. **Object-Centric Refinement:** ปรับแต่งหรือเติมเสียงให้วัตถุที่ระบุโดยผู้ใช้ ด้วยการคลิกหรือระบุบริเวณในวิดีโอ
3. **Targeted Audio Editing:** แก้ไขเสียงที่สร้างขึ้นด้วยคำสั่งภาษาธรรมชาติระดับสูง

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- ชุดข้อมูลขนาดใหญ่ที่มี CoT annotation (**AudioCoT**) ถูกใช้ฝึกทั้งโมดูล reasoning และโมเดลพื้นฐานเสียงแบบรวมศูนย์
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ เริ่มต้นใช้งานอย่างรวดเร็ว

**เตรียมสภาพแวดล้อม:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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
---

## 📝 สิ่งที่ต้องทำ & แผนในอนาคต
* - [ ] ปล่อยสคริปต์ฝึกสอนสำหรับโมเดล ThinkSound (คาดว่าจะก่อน 20/07/2025)
* - [ ] โอเพ่นซอร์สชุดข้อมูล AudioCoT และระบบอัตโนมัติ (คาดว่าจะก่อน 23/07/2025)
* - [ ] จัดเตรียมอิมเมจสภาพแวดล้อมที่พร้อมใช้งาน (คาดว่าจะก่อน 23/07/2025)
* - [ ] ปล่อยโมเดลพื้นฐานที่ทรงพลังมากขึ้น ครอบคลุมหลายโดเมน เพื่อสร้างเสียงโฟลีย์ที่น่าสนใจและสมจริงยิ่งขึ้น (คาดว่าภายในสิ้นเดือนสิงหาคม 2025)
* - [ ] เพิ่มการรองรับโมดาลิตี้และงานปลายทางเพิ่มเติม (คาดว่าก่อนสิ้นเดือนกรกฎาคม 2025)
* - [ ] ปล่อยโมเดลในหลายขนาด (คาดว่าก่อนสิ้นเดือนกรกฎาคม 2025)
* - [x] README สำหรับเริ่มต้นอย่างรวดเร็วบน Windows ที่เหมาะกับผู้เริ่มต้น
---


## 📄 ใบอนุญาต

โปรเจกต์นี้เผยแพร่ภายใต้ใบอนุญาต Apache 2.0

> **หมายเหตุ:**
> โค้ด โมเดล และชุดข้อมูลนี้ **ใช้สำหรับงานวิจัยและการศึกษาเท่านั้น**
> **ไม่อนุญาตให้ใช้ในเชิงพาณิชย์**
> หากต้องการใช้เชิงพาณิชย์ กรุณาติดต่อผู้เขียน

**📦 ส่วนประกอบจากบุคคลที่สาม**

* **Stable Audio Open VAE** (โดย Stability AI):
  โครงการนี้มี VAE ที่ผ่านการปรับแต่งจาก [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) ภายใต้ใบอนุญาต [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)
  **การใช้งานเชิงพาณิชย์และการแจกจ่ายซ้ำต้องได้รับอนุญาตล่วงหน้าจาก Stability AI**

* 📘 **โค้ดและโมเดลอื่น ๆ ทั้งหมด** เผยแพร่ภายใต้ Apache License 2.0

---

## คำขอบคุณ

ขอขอบคุณอย่างยิ่งต่อ:

* **stable-audio-tools** (โดย Stability AI):
สำหรับการจัดเตรียมเฟรมเวิร์กที่ใช้งานง่ายสำหรับการสร้างเสียง รวมถึงโมดูล VAE และเวทน้ำหนัก
* **MMAudio**:
  สำหรับการนำโครงสร้าง MM-DiT มาใช้ในงานด้านเสียง

---

## 📖 การอ้างอิง

หาก ThinkSound มีประโยชน์ในงานวิจัยหรือการทำงานของคุณ กรุณาอ้างอิงบทความของเรา:


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
```
---

## 📬 ติดต่อ

✨ โปรดอย่าลังเลที่จะ [เปิด issue](https://github.com/liuhuadai/ThinkSound/issues) หรือ ติดต่อเราทางอีเมล ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) หากคุณมีคำถามหรือข้อเสนอแนะ!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---