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
  การให้ดาว ⭐ บน GitHub จะได้รับการขอบคุณเป็นอย่างยิ่ง!
</p>

---

**ThinkSound** คือเฟรมเวิร์กการสร้างเสียง Any2Audio แบบครบวงจร ที่ใช้ flow matching และได้รับการชี้นำโดย Chain-of-Thought (CoT) reasoning

การใช้งาน PyTorch สำหรับสร้างเสียงและแก้ไขเสียงแบบมัลติโหมด: สร้างหรือแก้ไขเสียงจากวิดีโอ ข้อความ และเสียง โดยขับเคลื่อนด้วยการให้เหตุผลทีละขั้นตอนจาก Multimodal Large Language Models (MLLMs)

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ข่าวสาร
- **2025.07.17** &nbsp; 🧠 รองรับ Finetuning: โค้ดสำหรับการฝึกและปรับแต่งเปิดให้ใช้งานสาธารณะ พร้อมคำแนะนำใช้งานชัดเจน ช่วยให้คุณปรับแต่งและขยาย ThinkSound ด้วยข้อมูลของคุณเอง
- **2025.07.15** &nbsp; 📦 ติดตั้งและใช้งานง่ายขึ้น: มี dependencies บน PyPI สำหรับการติดตั้งข้ามแพลตฟอร์ม; สคริปต์ Windows `.bat` ช่วยสร้างสภาพแวดล้อมและรันโค้ดโดยอัตโนมัติ
- **2025.07.08** &nbsp;  🔧 อัปเดตใหญ่: โมเดลเบาขึ้น ใช้หน่วยความจำและ GPU อย่างมีประสิทธิภาพ รองรับการสร้างเสียงปริมาณมาก!
- **2025.07.01** &nbsp; 🔥เดโมออนไลน์บน [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) และ [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) สำหรับประสบการณ์โต้ตอบ!
- **2025.07.01** &nbsp; 🔥ปล่อยสคริปต์ inference และอินเทอร์เฟซเว็บแล้ว;
- **2025.06** &nbsp; 🔥[เผยแพร่บทความ ThinkSound](https://arxiv.org/pdf/2506.21448) บน arXiv!
- **2025.06** &nbsp; 🔥[เดโมออนไลน์](http://thinksound-project.github.io/) เปิดให้ลองใช้งานแล้ว!

---


## 🚀 คุณสมบัติเด่น

- **Any2Audio**: สร้างเสียงจากมัลติโหมดใดๆ — วิดีโอ ข้อความ เสียง หรือผสมผสานกัน
- **Video-to-Audio SOTA**: ทำผลงานล้ำสมัยบน benchmark V2A หลายชุด
- **CoT-Driven Reasoning**: เหตุผลแบบ Chain-of-Thought เพื่อการสร้างเสียงเชิงประกอบและควบคุมได้ผ่าน MLLMs
- **Interactive Object-centric Editing**: ปรับแต่งหรือแก้ไขเสียงเจาะจงเหตุการณ์ด้วยการคลิกที่วัตถุในภาพหรือใช้คำสั่งข้อความ
- **Unified Framework**: โมเดลหลักเดียวรองรับการสร้าง แก้ไข และเวิร์กโฟลว์แบบโต้ตอบ

---

## ✨ ภาพรวมวิธีการ

ThinkSound แบ่งกระบวนการสร้างและแก้ไขเสียงออกเป็น 3 ขั้นตอนโต้ตอบกัน โดยทั้งหมดขับเคลื่อนด้วย Chain-of-Thought (CoT) reasoning จาก MLLM:

1. **Foley Generation:** สร้างซาวด์สเคปพื้นฐานที่สอดคล้องกับความหมายและเวลา จากวิดีโอ
2. **Object-Centric Refinement:** ปรับแต่งหรือเพิ่มเสียงให้วัตถุที่ผู้ใช้ระบุ ผ่านการคลิกหรือเลือกบริเวณในวิดีโอ
3. **Targeted Audio Editing:** แก้ไขเสียงที่สร้างขึ้นด้วยคำสั่งภาษาธรรมชาติระดับสูง

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- ชุดข้อมูลขนาดใหญ่ที่มีการใส่ annotation แบบ CoT (**AudioCoT**) ใช้ฝึกทั้งโมดูล reasoning และโมเดลเสียงหลักแบบครบวงจร
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ เริ่มต้นอย่างรวดเร็ว

**การเตรียมสภาพแวดล้อม:**
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
## 🏋️ ฝึกสอนโมเดล

ดู [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 สิ่งที่ต้องทำ & แผนในอนาคต
* - [ ] เปิดโอเพ่นซอร์สชุดข้อมูล AudioCoT และระบบอัตโนมัติ (คาดว่าจะเสร็จก่อน 23/07/2025)
* - [ ] ปล่อยโมเดลฐานที่ทรงพลังยิ่งขึ้นครอบคลุมหลากหลายโดเมน เพื่อสร้างเสียงฟoleyที่น่าสนใจและสมจริงยิ่งขึ้น (คาดว่าภายในสิ้นเดือนสิงหาคม 2025)
* - [ ] เพิ่มการรองรับมัลติโหมดและงานปลายน้ำเพิ่มเติม (คาดว่าจะเสร็จก่อนสิ้นเดือนกรกฎาคม 2025)
* - [ ] ปล่อยโมเดลในหลายขนาด (คาดว่าจะเสร็จก่อนสิ้นเดือนกรกฎาคม 2025)
* - [x] ปล่อยสคริปต์สำหรับฝึกสอนโมเดล ThinkSound
* - [x] README แนะนำเริ่มต้นสำหรับ Windows ที่ใช้งานง่าย
---


## 📄 ใบอนุญาต

โปรเจกต์นี้เผยแพร่ภายใต้ Apache 2.0 License

> **หมายเหตุ:**
> โค้ด, โมเดล และชุดข้อมูลนี้ **สำหรับการวิจัยและการศึกษาเท่านั้น**
> **ไม่อนุญาตให้ใช้ในเชิงพาณิชย์**
> หากต้องการใช้งานเชิงพาณิชย์ กรุณาติดต่อผู้เขียน

**📦 ส่วนประกอบของบุคคลที่สาม**

* **Stable Audio Open VAE** (โดย Stability AI):
  ที่เก็บนี้รวม VAE ที่ปรับแต่งจาก [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/), ภายใต้ [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)
  **การใช้งานเชิงพาณิชย์และการแจกจ่ายซ้ำต้องได้รับอนุญาตล่วงหน้าจาก Stability AI**

* 📘 **โค้ดและโมเดลอื่น ๆ ทั้งหมด** เผยแพร่ภายใต้ Apache License 2.0

---

## คำขอบคุณ

ขอขอบคุณเป็นอย่างยิ่งต่อ:

* **stable-audio-tools** (โดย Stability AI):
สำหรับการจัดเตรียมเฟรมเวิร์กที่ใช้งานง่ายสำหรับการสร้างเสียง รวมถึงโมดูล VAE และเวทน้ำหนัก
* **MMAudio**:
  สำหรับการนำโครงสร้าง MM-DiT มาใช้ในโดเมนเสียง

---

## 📖 การอ้างอิง

หากคุณพบว่า ThinkSound มีประโยชน์ในการวิจัยหรือการทำงาน กรุณาอ้างอิงบทความของเรา:



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

✨ หากคุณมีคำถามหรือข้อเสนอแนะใด ๆ โปรด [เปิด issue](https://github.com/liuhuadai/ThinkSound/issues) หรือ ติดต่อเราทางอีเมล ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) ได้เลย!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---