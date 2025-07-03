# 🎶 ThinkSound

<p align="center">
  หากคุณพบว่าโปรเจกต์นี้มีประโยชน์ การให้ดาว ⭐ บน GitHub จะเป็นสิ่งที่น่าชื่นชมอย่างยิ่ง!
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

---

**ThinkSound** คือเฟรมเวิร์กการสร้างเสียง Any2Audio แบบรวมศูนย์ พร้อมการนำทางด้วยการจับคู่โฟลว์ที่ขับเคลื่อนด้วย Chain-of-Thought (CoT) reasoning

การใช้งานบน PyTorch สำหรับการสร้างเสียงและแก้ไขเสียงแบบมัลติโหมด: สร้างหรือแก้ไขเสียงจากวิดีโอ ข้อความ และเสียง โดยขับเคลื่อนด้วยการให้เหตุผลแบบทีละขั้นตอนจาก Multimodal Large Language Models (MLLMs)

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ข่าวสาร
- **2025.07** &nbsp; 🔥เดโมออนไลน์บน [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) และ [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) สำหรับประสบการณ์แบบอินเตอร์แอคทีฟ!
- **2025.07** &nbsp; 🔥ปล่อยสคริปต์ inference และอินเทอร์เฟซเว็บ;
- **2025.06** &nbsp; 🔥[งานวิจัย ThinkSound](https://arxiv.org/pdf/2506.21448) เผยแพร่บน arXiv!
- **2025.06** &nbsp; 🔥[เดโมออนไลน์](http://thinksound-project.github.io/) เปิดให้ใช้งานแล้ว - ทดลองได้เลย!

---

## 🚀 คุณสมบัติเด่น

- **Any2Audio**: สร้างเสียงจากมัลติโหมดใดๆ — วิดีโอ ข้อความ เสียง หรือผสมกัน
- **Video-to-Audio SOTA**: ได้ผลลัพธ์ชั้นนำในหลายเกณฑ์วัด V2A
- **CoT-Driven Reasoning**: การให้เหตุผลแบบ Chain-of-Thought เพื่อการสร้างเสียงเชิงประกอบและควบคุมได้ด้วย MLLMs
- **Interactive Object-centric Editing**: ปรับแต่งหรือแก้ไขเสียงเฉพาะเหตุการณ์โดยคลิกที่วัตถุในภาพหรือใช้คำสั่งข้อความ
- **Unified Framework**: โมเดลรากฐานเดียวรองรับการสร้าง แก้ไข และเวิร์กโฟลว์แบบอินเตอร์แอคทีฟ

---

## ✨ ภาพรวมวิธีการ

ThinkSound แยกกระบวนการสร้างและแก้ไขเสียงออกเป็น 3 ขั้นตอนที่มีปฏิสัมพันธ์กัน โดยทุกขั้นตอนได้รับการนำทางจากการให้เหตุผลแบบ Chain-of-Thought (CoT) บนพื้นฐาน MLLM:

1. **Foley Generation:** สร้างซาวด์สเคปพื้นฐานที่ตรงกับความหมายและเวลา จากวิดีโอ
2. **Object-Centric Refinement:** ปรับแต่งหรือเพิ่มเสียงให้กับวัตถุที่ผู้ใช้ระบุโดยคลิกหรือเลือกบริเวณในวิดีโอ
3. **Targeted Audio Editing:** แก้ไขเสียงที่สร้างขึ้นโดยใช้คำสั่งภาษาแบบธรรมชาติในระดับสูง

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- ใช้ชุดข้อมูลขนาดใหญ่ที่มีการใส่คำอธิบาย CoT (**AudioCoT**) เพื่อฝึกโมดูลให้เหตุผลและโมเดลรากฐานเสียงแบบรวม
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ เริ่มต้นอย่างรวดเร็ว

**เตรียมสภาพแวดล้อม:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# ดาวน์โหลดน้ำหนักพรีเทรน https://huggingface.co/liuhuadai/ThinkSound ไปยังไดเรกทอรี ckpts/
# น้ำหนักโมเดลสามารถดาวน์โหลดได้จาก https://www.modelscope.cn/models/iic/ThinkSound เช่นกัน
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**ทำให้ไฟล์สคริปต์รันได้**
```bash
chmod +x scripts/demo.sh
```

**เรียกใช้สคริปต์**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```

### การใช้งานผ่านเว็บอินเทอร์เฟซ

สำหรับประสบการณ์แบบอินเตอร์แอคทีฟ ให้เปิดใช้งานเว็บอินเทอร์เฟซ Gradio:

```bash
python app.py
```

---
## 📝 TODO

- ☐ เผยแพร่สคริปต์การฝึกสำหรับโมเดล ThinkSound
- ☐ โอเพนซอร์สชุดข้อมูล AudioCoT และระบบอัตโนมัติ
- ☐ จัดเตรียมเอกสารรายละเอียดและการอ้างอิง API
- ☐ เพิ่มการรองรับโมดาลิตีและงานดาวน์สตรีมเพิ่มเติม

---

## 📄 ลิขสิทธิ์

โปรเจกต์นี้ถูกเผยแพร่ภายใต้ [สัญญาอนุญาต Apache 2.0](LICENSE)

> **หมายเหตุ:**  
> โค้ด, โมเดล และชุดข้อมูลนี้ **สำหรับวัตถุประสงค์ด้านการวิจัยและการศึกษาเท่านั้น**  
> **ไม่อนุญาตให้ใช้ในเชิงพาณิชย์**
>
> หากต้องการขออนุญาตใช้งานเชิงพาณิชย์ กรุณาติดต่อผู้เขียน

---

## 📖 การอ้างอิง

หากคุณพบว่า ThinkSound มีประโยชน์ในงานวิจัยหรือการทำงานของคุณ กรุณาอ้างอิงบทความของเรา:

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

✨ สามารถ [เปิด issue](https://github.com/liuhuadai/ThinkSound/issues) หรือ ติดต่อเราทางอีเมล ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) หากคุณมีคำถามหรือข้อเสนอแนะ!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---