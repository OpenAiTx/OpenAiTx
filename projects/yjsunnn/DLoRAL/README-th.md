<div align="center">
<h2>การกระจายแบบขั้นตอนเดียวสำหรับการเพิ่มความละเอียดวิดีโอที่คงรายละเอียดสูงและความสอดคล้องของเวลา</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>มหาวิทยาลัยโปลีเทคนิคฮ่องกง, <sup>2</sup>สถาบันวิจัย OPPO
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="ผลลัพธ์การแสดงผล">

</p>

## ⏰ อัปเดต

- **2025.07.08**: โค้ดสำหรับการอนุมานและน้ำหนักที่ผ่านการฝึกไว้ล่วงหน้าพร้อมให้ใช้งานแล้ว
- **2025.06.24**: หน้าของโปรเจกต์เปิดให้เข้าชมแล้ว รวมถึงวิดีโออธิบายสั้น ๆ 2 นาที ผลลัพธ์ภาพเพิ่มเติม และงานวิจัยที่เกี่ยวข้อง
- **2025.06.17**: ปล่อย repo แล้ว

:star: หาก DLoRAL มีประโยชน์กับวิดีโอหรือโปรเจกต์ของคุณ กรุณาช่วยกดดาว repo นี้ด้วย ขอบคุณค่ะ! :hugs:

😊 คุณอาจสนใจผลงานที่เกี่ยวข้องของเราเพิ่มเติม:

1. **OSEDiff (NIPS2024)** [Paper](https://arxiv.org/abs/2406.08177) | [Code](https://github.com/cswry/OSEDiff/)  

   อัลกอริธึม SR ภาพแบบเรียลไทม์ที่ได้นำไปใช้กับ OPPO Find X8 series

2. **PiSA-SR (CVPR2025)** [Paper](https://arxiv.org/pdf/2412.03017) | [Code](https://github.com/csslc/PiSA-SR) 

   การสำรวจแนวคิด Dual-LoRA ในงาน SR ภาพเป็นครั้งแรก

3. **Awesome Diffusion Models for Video Super-Resolution** [Repo](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   รายการรวมแหล่งข้อมูลสำหรับ Video Super-Resolution (VSR) ด้วย Diffusion Models
## 👀 TODO
- [x] ปล่อยโค้ดสำหรับการอินเฟอเรนซ์
- [ ] UI สำหรับ Colab และ Huggingface เพื่อความสะดวกในการทดสอบ (เร็วๆ นี้!)
- [ ] ปล่อยโค้ดสำหรับการฝึกสอน
- [ ] ปล่อยข้อมูลสำหรับการฝึกสอน


## 🌟 ภาพรวมของ Framework

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**การฝึกสอน**: ใช้รูปแบบการฝึกสอนแบบไดนามิกสองขั้น โดยสลับกันระหว่างการเพิ่มประสิทธิภาพของความสอดคล้องในเชิงเวลา (ขั้นตอนความสม่ำเสมอ) และการปรับรายละเอียดเชิงพื้นที่ความถี่สูง (ขั้นตอนการเพิ่มประสิทธิภาพ) พร้อมกับการปรับเปลี่ยน loss อย่างราบรื่นเพื่อให้เกิดเสถียรภาพ

**การอินเฟอเรนซ์**: ในระหว่างการอินเฟอเรนซ์ ทั้ง C-LoRA และ D-LoRA จะถูกรวมเข้ากับ diffusion UNet ที่ถูกแช่แข็ง ทำให้สามารถเพิ่มคุณภาพของอินพุตคุณภาพต่ำเป็นเอาต์พุตคุณภาพสูงได้ในขั้นตอนเดียว
## 🔧 ข้อกำหนดและการติดตั้ง

1. โคลนรีโป
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. ติดตั้งแพ็กเกจที่จำเป็น
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. ดาวน์โหลดโมเดล 
#### โมเดลที่ต้องใช้
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> วางไว้ที่ **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> วางไว้ที่ **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> วางไว้ที่ **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> วางไว้ที่ **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> วางไว้ที่ **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

แต่ละพาธสามารถปรับเปลี่ยนได้ตามความต้องการของแต่ละคน และควรมีการเปลี่ยนแปลงที่สอดคล้องกันในคำสั่งและโค้ดด้วย
## 🖼️ การอนุมานอย่างรวดเร็ว
สำหรับการเพิ่มความละเอียดวิดีโอในโลกแห่งความจริง:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```
### การอ้างอิง
หากโค้ดของเราช่วยในการวิจัยหรือการทำงานของคุณ กรุณาพิจารณาอ้างอิงงานวิจัยของเรา
ด้านล่างนี้คือการอ้างอิงในรูปแบบ BibTeX:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---