# EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 เปเปอร์](https://arxiv.org/abs/2506.05554)  |  [🎥 โฮมเพจ](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 โค้ด](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 ไฮไลท์

- **🎯 การสังเคราะห์มุมกล้องสุดขั้ว (Extreme Viewpoint Synthesis)**: สร้างวิดีโอ 4D คุณภาพสูงที่มีการเคลื่อนไหวของกล้องตั้งแต่ -90° ถึง 90°
- **🔧 Depth Watertight Mesh**: ตัวแทนเรขาคณิตแบบใหม่ที่จำลองทั้งบริเวณที่มองเห็นและบริเวณที่ถูกบัง
- **⚡ สถาปัตยกรรมขนาดเบา**: มีพารามิเตอร์ที่ฝึกได้เพียง 1% (140M) ของ backbone video diffusion 14B
- **🎭 ไม่ต้องฝึกด้วยหลายมุมกล้อง**: กลยุทธ์การมาส์กแบบใหม่ช่วยตัดความจำเป็นในการใช้ชุดข้อมูลหลายมุมกล้องที่มีต้นทุนสูง
- **🏆 ประสิทธิภาพระดับแนวหน้า**: เหนือกว่าวิธีปัจจุบัน โดยเฉพาะในมุมกล้องสุดขั้ว

## 🎬 ผลลัพธ์เดโม

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D แปลงวิดีโอโมโนคูลาร์ให้กลายเป็นประสบการณ์ 4D ที่ควบคุมกล้องได้ พร้อมผลลัพธ์ที่สอดคล้องกับฟิสิกส์แม้ในมุมมองสุดขั้ว*

## 🏗️ ภาพรวมของเฟรมเวิร์ก

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

เฟรมเวิร์กของเราประกอบด้วยองค์ประกอบหลัก 3 ส่วน:

1. **🔺 การสร้าง Depth Watertight Mesh**: สร้าง prior ทางเรขาคณิตที่แข็งแกร่งซึ่งจำลองทั้งบริเวณที่มองเห็นและถูกบังอย่างชัดเจน
2. **🎭 กลยุทธ์มาส์กจำลอง**: สร้างข้อมูลสำหรับฝึกที่มีประสิทธิภาพจากวิดีโอโมโนคูลาร์โดยไม่ต้องใช้ชุดข้อมูลหลายมุมกล้อง
3. **⚙️ Lightweight LoRA Adapter**: ผสานข้อมูลเรขาคณิตเข้ากับโมเดล video diffusion ที่ผ่านการฝึกมาก่อนอย่างมีประสิทธิภาพ

## 🚀 เริ่มต้นอย่างรวดเร็ว

### การติดตั้ง

```bash
# โคลน repository
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# สร้างสภาพแวดล้อม conda
conda create -n ex4d python=3.10
conda activate ex4d
# ติดตั้ง PyTorch (แนะนำเวอร์ชัน 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# ติดตั้ง Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# ติดตั้ง dependencies และ diffsynth
pip install -e .
# ติดตั้ง depthcrafter สำหรับการประมาณความลึก (ทำตามคำแนะนำการติดตั้งของ DepthCrafter เพื่อเตรียม checkpoints)
git clone https://github.com/Tencent/DepthCrafter.git
```

### ดาวน์โหลดโมเดลที่ฝึกไว้ล่วงหน้า
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### ตัวอย่างการใช้งาน
#### 1. การสร้าง DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. การสร้าง EX-4D (ต้องใช้ VRAM 48GB)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>วิดีโอต้นฉบับ</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>วิดีโอผลลัพธ์</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| วิธีการ | FID (Extreme) ↓ | FVD (Extreme) ↓ | คะแนน VBench ↑ |
|---------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (ของเรา)** | **55.42** | **823.61** | **0.450** | -->

### ผลการศึกษาจากผู้ใช้

- **70.7%** ของผู้เข้าร่วมชื่นชอบ EX-4D มากกว่าวิธีพื้นฐาน
- ประสิทธิภาพเหนือกว่าในด้านความสอดคล้องทางกายภาพและคุณภาพมุมมองที่รุนแรง
- พัฒนาการที่เห็นได้ชัดเมื่อมุมกล้องมีความสุดขีดมากขึ้น

## 🎯 การประยุกต์ใช้งาน

- **🎮 เกม**: สร้างฉากภาพยนตร์ 3D ที่สมจริงจากวิดีโอ 2D
- **🎬 การผลิตภาพยนตร์**: สร้างมุมกล้องใหม่สำหรับงานหลังการถ่ายทำ
- **🥽 VR/AR**: สร้างประสบการณ์วิดีโอมุมมองอิสระ
- **📱 โซเชียลมีเดีย**: สร้างการเคลื่อนไหวของกล้องที่มีความไดนามิกสำหรับการสร้างคอนเทนต์
- **🏢 สถาปัตยกรรม**: จำลองพื้นที่จากหลายมุมมอง

<!-- ## 📈 Benchmarks -->

<!-- ### การประเมินช่วงมุมมอง

| ช่วง | เล็ก (0°→30°) | ใหญ่ (0°→60°) | สุดขีด (0°→90°) | เต็ม (-90°→90°) |
|------|----------------|---------------|-----------------|-----------------|
| คะแนน FID | 44.19 | 50.30 | 55.42 | - |
| ช่องว่างประสิทธิภาพ | +9.1% ดีกว่า | +8.9% ดีกว่า | +11.3% ดีกว่า | +15.5% ดีกว่า | -->

<!-- *ช่องว่างประสิทธิภาพเมื่อเปรียบเทียบกับวิธีอันดับสองในแต่ละหมวดหมู่* -->

## ⚠️ ข้อจำกัด

- **ขึ้นกับการประเมินความลึก**: ประสิทธิภาพขึ้นอยู่กับคุณภาพการประมาณความลึกจากภาพเดี่ยว
- **ต้นทุนการประมวลผล**: ต้องใช้การประมวลผลสูงสำหรับวิดีโอความละเอียดสูง
- **พื้นผิวสะท้อนแสง**: มีความท้าทายกับวัสดุที่สะท้อนหรือโปร่งใส

## 🔮 งานวิจัยในอนาคต
- [ ] การปรับแต่งให้สามารถอนุมานแบบเรียลไทม์ (3DGS / 4DGS)
- [ ] รองรับความละเอียดสูงขึ้น (1K, 2K)
- [ ] เทคนิคการปรับแต่งตาข่ายประสาท

## 🙏 คำขอบคุณ

ขอขอบคุณโปรเจกต์ [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) ที่ให้เฟรมเวิร์ก diffusion พื้นฐาน

## 📚 การอ้างอิง

หากท่านพบว่างานของเรามีประโยชน์ โปรดพิจารณาอ้างอิงดังนี้:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---