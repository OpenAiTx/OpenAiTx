<h1 align="center">TexGaussian: การสร้างวัสดุ PBR คุณภาพสูงด้วย Octree-based 3D Gaussian Splatting</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

วัสดุ Physically Based Rendering (PBR) มีบทบาทสำคัญในกราฟิกยุคใหม่ ช่วยให้เรนเดอร์ภาพสมจริงได้ในหลากหลายสภาพแวดล้อม การพัฒนาอัลกอริทึมที่มีประสิทธิภาพและสามารถสร้างวัสดุ PBR คุณภาพสูงโดยอัตโนมัติแทนที่การใช้เพียงเท็กซ์เจอร์ RGB สำหรับเมช 3 มิติ จะช่วยลดขั้นตอนการสร้างคอนเทนต์ 3D ลงอย่างมาก วิธีส่วนใหญ่ในปัจจุบันใช้โมเดล diffusion 2D ที่ผ่านการเทรนล่วงหน้าสำหรับการสร้างภาพหลายมุมมอง ซึ่งมักทำให้เกิดความไม่สอดคล้องกันอย่างรุนแรงระหว่างเท็กซ์เจอร์ที่สร้างขึ้นและเมช 3 มิติที่ป้อนเข้า บทความนี้นำเสนอ TexGaussian วิธีใหม่ที่ใช้ Octant-aligned 3D Gaussian Splatting สำหรับการสร้างวัสดุ PBR อย่างรวดเร็ว โดยเฉพาะ เราจะวาง 3D Gaussian แต่ละอันไว้ที่โหนดใบไม้ที่ละเอียดที่สุดของ octree ที่สร้างจากเมช 3 มิติที่ป้อนเข้า เพื่อเรนเดอร์ภาพหลายมุมมองไม่เพียงแต่สำหรับ albedo map แต่ยังรวมถึง roughness และ metallic ด้วย นอกจากนี้ โมเดลของเรายังถูกฝึกในลักษณะ regression แทน diffusion denoising ซึ่งสามารถสร้างวัสดุ PBR สำหรับเมช 3 มิติได้ในขั้นตอน feed-forward เดียว การทดลองมากมายบน benchmark สาธารณะพบว่าวิธีของเราสังเคราะห์วัสดุ PBR ที่ดูดีขึ้นและทำงานได้เร็วกว่าเดิมทั้งในกรณี unconditional และ text-conditional โดยมีความสอดคล้องกับ geometry ที่กำหนดมากกว่า

## 📦 การติดตั้ง

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# gaussian splatting ที่ถูกปรับแต่ง (+ depth, alpha rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# dependencies อื่นๆ
pip3 install -r requirements.txt
```

## 🤖 โมเดลที่เทรนไว้ล่วงหน้า

เรามีโมเดลที่ผ่านการเทรนล่วงหน้าต่อไปนี้ให้ใช้งาน:

| โมเดล | คำอธิบาย | พารามิเตอร์ | ดาวน์โหลด |
| --- | --- | --- | --- |
| TexGaussian-bench | โมเดลเท็กซ์เจอร์ RGB แบบ unconditional ที่ฝึกกับ ShapeNet bench | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | โมเดลเท็กซ์เจอร์ RGB แบบ unconditional ที่ฝึกกับ ShapeNet car | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | โมเดลเท็กซ์เจอร์ RGB แบบ unconditional ที่ฝึกกับ ShapeNet chair | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | โมเดลเท็กซ์เจอร์ RGB แบบ unconditional ที่ฝึกกับ ShapeNet table | 70M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | โมเดลวัสดุ PBR แบบ text conditional ที่ฝึกกับ Objaverse | 295M | [Download](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 การอินเฟอเรนซ์

### วัสดุ PBR
สำหรับการสร้างวัสดุ PBR แบบ text conditional ให้รัน
```bash
bash inference_for_PBR_material.sh
```
หลังจากการ bake เท็กซ์เจอร์และวัสดุ คุณจะได้แผนที่สองชุด คือ albedo map และ PBR material map โดยเฉพาะ PBR material map จะมีสาม channel ซึ่ง channel สีเขียวแทนค่า roughness และ channel สีฟ้าแทนค่า metallic หากต้องการเรนเดอร์ PBR ด้วยเท็กซ์เจอร์และแผนที่วัสดุที่สร้างขึ้น แนะนำให้ใช้ [สคริปต์เรนเดอร์นี้](https://github.com/ymxbj/BlenderToolboxPBR) ที่เขียนด้วย bpy

ยิ่งไปกว่านั้น แนะนำให้ทุกคนนำรูปแบบ prompt ของ Cap3D dataset มาใช้หรือสร้าง prompt ของตนเองเพื่อผลลัพธ์ที่ดียิ่งขึ้น ชุดข้อมูล Cap3D สามารถดาวน์โหลดได้ [ที่นี่](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true)

### เท็กซ์เจอร์ RGB
สำหรับการสร้างเท็กซ์เจอร์ RGB แบบ unconditional (ใช้ได้กับ 4 หมวด: bench, car, chair, table) ให้รัน
```bash
bash inference_for_RGB_texture.sh
```
หลังจาก bake เท็กซ์เจอร์ คุณจะได้ albedo map หนึ่งชุด

## 🏋️‍♂️ การฝึกโมเดล
สำหรับ Objaverse:
```bash
bash train_for_objaverse.sh
```

สำหรับ ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] ปล่อยโค้ดการฝึกและอินเฟอเรนซ์
- [x] ปล่อยโมเดล albedo-only แบบ unconditional ที่เทรนล่วงหน้ากับชุดข้อมูล ShapeNet
- [x] ปล่อยโมเดล PBR แบบ text-conditional ที่เทรนล่วงหน้ากับชุดข้อมูล Objaverse
- [ ] ปล่อยชุดข้อมูลและเครื่องมือจัดการชุดข้อมูล

## 📚Acknowledgement

งานนี้พัฒนาต่อยอดจากผลงานวิจัยและโปรเจกต์โอเพ่นซอร์สที่ยอดเยี่ยมมากมาย ขอขอบคุณผู้เขียนทุกท่านที่แบ่งปัน!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) และ [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Citation

หากงานนี้เป็นประโยชน์กับคุณ กรุณาอ้างอิงผลงานของเรา:

1. arXiv version
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR version
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---