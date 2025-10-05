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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
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
  หากคุณพบว่าโปรเจ็กต์นี้มีประโยชน์,<br>
  การให้ดาว ⭐ บน GitHub จะได้รับการชื่นชมเป็นอย่างยิ่ง!
</p>

---

**ThinkSound** คือกรอบงานการสร้างเสียง Any2Audio แบบรวมศูนย์ โดยใช้การจับคู่การไหลที่ถูกชี้นำด้วยเหตุผล Chain-of-Thought (CoT)

การใช้งาน PyTorch สำหรับการสร้างและแก้ไขเสียงมัลติโหมด: สร้างหรือแก้ไขเสียงจากวิดีโอ ข้อความ และเสียง โดยขับเคลื่อนด้วยกระบวนการคิดทีละขั้นจากโมเดลภาษาใหญ่หลายโหมด (MLLMs)

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ข่าวสาร
- **2025.09.19** &nbsp; 🎉 ThinkSound ได้รับการตอบรับเข้าสู่ **NeurIPS 2025 Main Conference**!
- **2025.09.01** &nbsp; 🔥 ขณะนี้ชุดข้อมูล AudioCoT เปิดให้ใช้งานแบบโอเพ่นซอร์สแล้วบน [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 เปิดใช้งานการปรับแต่ง: โค้ดการฝึกและปรับแต่งมีให้ใช้งานสาธารณะ พร้อมคำแนะนำการใช้งานที่ชัดเจนเพื่อให้คุณปรับแต่งและขยาย ThinkSound ด้วยข้อมูลของคุณเอง
- **2025.07.15** &nbsp; 📦 ติดตั้งและใช้งานง่ายขึ้น: ขึ้นกับ PyPI เพื่อการตั้งค่าแบบข้ามแพลตฟอร์ม; สคริปต์ Windows `.bat` อัตโนมัติการสร้างสภาพแวดล้อมและการรันสคริปต์
- **2025.07.08** &nbsp;  🔧 อัปเดตครั้งใหญ่: โมเดลเบาลงและเพิ่มประสิทธิภาพการใช้หน่วยความจำและ GPU รองรับการสร้างเสียงประสิทธิภาพสูงในขนาดใหญ่!
- **2025.07.01** &nbsp; 🔥เดโมออนไลน์บน [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) และ [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) เพื่อประสบการณ์แบบโต้ตอบ!
- **2025.07.01** &nbsp; 🔥เผยแพร่สคริปต์อินเฟอเรนซ์และอินเทอร์เฟซเว็บ;
- **2025.06** &nbsp; 🔥[งานวิจัย ThinkSound](https://arxiv.org/pdf/2506.21448) เผยแพร่บน arXiv!
- **2025.06** &nbsp; 🔥[เดโมออนไลน์](http://thinksound-project.github.io/) เปิดให้ใช้งานแล้ว - ลองเลย!

---


## 🚀 คุณสมบัติเด่น

- **Any2Audio**: สร้างเสียงจากมัลติโหมดใดก็ได้ — วิดีโอ ข้อความ เสียง หรือผสมกัน
- **Video-to-Audio SOTA**: ทำผลลัพธ์ระดับแนวหน้าในหลายมาตรฐาน V2A
- **CoT-Driven Reasoning**: กระบวนการคิดแบบ Chain-of-Thought สำหรับการสร้างเสียงเชิงองค์ประกอบและควบคุมผ่าน MLLMs
- **Interactive Object-centric Editing**: ปรับแต่งหรือแก้ไขเสียงเหตุการณ์เฉพาะโดยคลิกที่วัตถุภาพหรือใช้คำสั่งข้อความ
- **Unified Framework**: โมเดลรากฐานเดียวรองรับการสร้าง แก้ไข และเวิร์กโฟลว์เชิงโต้ตอบ

---

## ✨ ภาพรวมวิธีการ

ThinkSound แยกกระบวนการสร้างและแก้ไขเสียงออกเป็น 3 ขั้นตอนโต้ตอบ โดยทั้งหมดขับเคลื่อนด้วยกระบวนการคิดแบบ Chain-of-Thought ด้วย MLLM:

1. **การสร้างเสียง Foley:** สร้างบรรยากาศเสียงพื้นฐานที่สอดคล้องกับเนื้อหาและเวลา จากวิดีโอ
2. **การปรับแต่งวัตถุเฉพาะ:** ปรับแต่งหรือเพิ่มเสียงให้กับวัตถุที่ผู้ใช้ระบุผ่านการคลิกหรือกำหนดพื้นที่ในวิดีโอ
3. **การแก้ไขเสียงแบบเจาะจง:** แก้ไขเสียงที่สร้างขึ้นโดยใช้คำสั่งภาษาธรรมชาติระดับสูง

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- ชุดข้อมูลขนาดใหญ่ที่มีการใส่คำอธิบายแบบ Chain-of-Thought (**AudioCoT**) ถูกใช้ในการฝึกทั้งโมดูลเหตุผลและโมเดลเสียงรากฐานแบบรวม
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


## 🏋️ ฝึกอบรมโมเดล

ดู [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO & แผนในอนาคต
* - [ ] ปล่อยโมเดลพื้นฐานที่ทรงพลังมากขึ้น ครอบคลุมหลายโดเมน เพื่อสร้างประสบการณ์การสร้างเสียงโฟลีย์ที่น่าสนใจและสมจริงยิ่งขึ้น
* - [ ] เพิ่มการรองรับรูปแบบข้อมูลและงานปลายทางเพิ่มเติม
* - [ ] ปล่อยโมเดลในขนาดที่แตกต่างกัน
* - [x] เปิดซอร์สชุดข้อมูล AudioCoT และระบบอัตโนมัติ
* - [x] ปล่อยสคริปต์สำหรับฝึกอบรมโมเดล ThinkSound
* - [x] README สำหรับเริ่มต้นใช้งาน Windows ที่เหมาะสำหรับมือใหม่
---


## 📄 ใบอนุญาต

โปรเจกต์นี้เผยแพร่ภายใต้ใบอนุญาต Apache 2.0

> **หมายเหตุ:**
> โค้ด โมเดล และชุดข้อมูลนี้มีไว้สำหรับ **การวิจัยและการศึกษาเท่านั้น**
> **ไม่อนุญาตให้ใช้เชิงพาณิชย์**
> หากต้องการใช้เชิงพาณิชย์ กรุณาติดต่อผู้เขียน

**📦 ส่วนประกอบจากบุคคลที่สาม**

* **Stable Audio Open VAE** (โดย Stability AI):
  ที่เก็บนี้รวม VAE ที่ปรับแต่งจาก [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) ซึ่งได้รับอนุญาตภายใต้ [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)
  **การใช้และแจกจ่ายเชิงพาณิชย์ต้องได้รับอนุญาตล่วงหน้าจาก Stability AI**

* 📘 **โค้ดและโมเดลอื่น ๆ ทั้งหมด** เผยแพร่ภายใต้ใบอนุญาต Apache 2.0

---

## คำขอบคุณ

ขอขอบคุณเป็นอย่างสูงแก่:

* **stable-audio-tools** (โดย Stability AI):
สำหรับการจัดเตรียมเฟรมเวิร์กที่ใช้งานง่ายสำหรับการสร้างเสียง รวมถึงโมดูล VAE และน้ำหนักโมเดล
* **MMAudio**:
  สำหรับการนำโครงสร้างหลัก MM-DiT มาใช้ในโดเมนเสียง

---

## 📖 การอ้างอิง

หากคุณพบว่า ThinkSound มีประโยชน์ในการวิจัยหรือการทำงานของคุณ โปรดอ้างอิงงานวิจัยของเรา:

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

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---