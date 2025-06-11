# 3D Gaussian Splatting สำหรับการเรนเดอร์ Radiance Field แบบเรียลไทม์ - การใช้งาน C++ และ CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

การใช้งาน C++ และ CUDA ประสิทธิภาพสูงของ 3D Gaussian Splatting ซึ่งสร้างขึ้นบนพื้นฐานของ [gsplat](https://github.com/nerfstudio-project/gsplat) rasterization backend

## ข่าวสาร
- **[2025-06-10]**: แก้ไขปัญหาบางอย่าง เรากำลังลดช่องว่างกับค่าเมตริกของ gsplat อย่างไรก็ตามยังมีความไม่ตรงกันเล็กน้อย
- **[2025-06-04]**: เพิ่มกลยุทธ์ MCMC พร้อมตัวเลือกบรรทัดคำสั่ง `--max-cap` สำหรับควบคุมจำนวน Gaussian สูงสุด
- **[2025-06-03]**: เปลี่ยนไปใช้ Gsplat backend และอัปเดตใบอนุญาต
- **[2024-05-27]**: อัปเดตเป็น LibTorch 2.7.0 เพื่อความเข้ากันได้และประสิทธิภาพที่ดีขึ้น มีการแก้ไขการจัดการสถานะ optimizer ที่ทำให้เกิดการเปลี่ยนแปลงครั้งใหญ่
- **[2024-05-26]**: เป้าหมายปัจจุบันของ repo นี้คือการเปลี่ยนไปใช้ใบอนุญาตแบบเปิดกว้าง มีการทำงานหลักเพื่อแทนที่ rasterizer ด้วยการใช้งาน gsplat

## เมตริก
ในปัจจุบัน การใช้งานนี้ยังไม่สามารถทำผลลัพธ์เทียบเท่ากับ gsplat-mcmc ได้ แต่กำลังอยู่ระหว่างการพัฒนา  
เป็นเรื่องของเวลาในการแก้ไขข้อบกพร่อง ความช่วยเหลือยินดีต้อนรับ :) เมตริกสำหรับกลยุทธ์ mcmc มีดังนี้:

| ฉาก       | รอบ         | PSNR          | SSIM         | LPIPS        | เวลา/ภาพ      | จำนวน Gaussians |
| --------- | ----------- | ------------- | ------------ | ------------ | -------------- | --------------- |
| garden    | 30000       | 27.112114     | 0.854833     | 0.157624     | 0.304765       | 1000000         |
| bicycle   | 30000       | 25.047745     | 0.767729     | 0.254825     | 0.293618       | 1000000         |
| stump     | 30000       | 26.554749     | 0.784203     | 0.263013     | 0.296536       | 1000000         |
| bonsai    | 30000       | 32.534199     | 0.948675     | 0.246924     | 0.436188       | 1000000         |
| counter   | 30000       | 29.187017     | 0.915823     | 0.242159     | 0.441259       | 1000000         |
| kitchen   | 30000       | 31.680832     | 0.933897     | 0.154965     | 0.449078       | 1000000         |
| room      | 30000       | 32.211632     | 0.930754     | 0.273719     | 0.413519       | 1000000         |
| **ค่าเฉลี่ย** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**   | **1000000**     |

## ชุมชนและการสนับสนุน

เข้าร่วมชุมชนของเราที่กำลังเติบโตเพื่อการสนทนา การสนับสนุน และอัปเดต:  
- 💬 **[ชุมชน Discord](https://discord.gg/TbxJST2BbC)** - ขอความช่วยเหลือ แชร์ผลลัพธ์ และพูดคุยเกี่ยวกับการพัฒนา  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - เยี่ยมชมเว็บไซต์ของเราสำหรับทรัพยากรเพิ่มเติม  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - รายการบทความและทรัพยากรที่ครอบคลุม  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - ติดตามสำหรับอัปเดตล่าสุด  

## คำแนะนำการติดตั้งและใช้งาน

### ซอฟต์แวร์ที่ต้องมี
1. **Linux** (ทดสอบบน Ubuntu 22.04) - ปัจจุบันไม่รองรับ Windows  
2. **CMake** 3.24 ขึ้นไป  
3. **CUDA** 11.8 ขึ้นไป (อาจใช้งานกับเวอร์ชันต่ำกว่าได้ด้วยการตั้งค่าด้วยตนเอง)  
4. **Python** พร้อม development headers  
5. **LibTorch 2.7.0** - คำแนะนำการติดตั้งด้านล่าง  
6. การพึ่งพาอื่น ๆ จะถูกจัดการอัตโนมัติด้วย CMake  

### ฮาร์ดแวร์ที่ต้องมี
1. **NVIDIA GPU** ที่รองรับ CUDA  
    - ทดสอบผ่าน: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - พบปัญหากับ RTX 3080Ti บนชุดข้อมูลขนาดใหญ่ (ดูที่ #21)  
2. ความสามารถในการประมวลผลขั้นต่ำ: 8.0  

> หากคุณใช้งานบนฮาร์ดแวร์อื่นได้สำเร็จ โปรดแชร์ประสบการณ์ของคุณในส่วน Discussions!

### คำสั่งการติดตั้ง

```bash
# โคลนรีโพสิตอรีพร้อมซับโมดูล
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# ดาวน์โหลดและติดตั้ง LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# สร้างโปรเจค
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

โปรเจคนี้ใช้ **LibTorch 2.7.0** เพื่อประสิทธิภาพและความเข้ากันได้ที่ดีที่สุด:

- **ประสิทธิภาพที่ดีขึ้น**: ปรับปรุงการเพิ่มประสิทธิภาพและการจัดการหน่วยความจำ  
- **ความเสถียรของ API**: ใช้ PyTorch C++ API รุ่นล่าสุดที่เสถียร  
- **ความเข้ากันได้กับ CUDA**: การรวมที่ดีขึ้นกับ CUDA 11.8+  
- **แก้ไขข้อผิดพลาด**: แก้ไขปัญหาการจัดการสถานะ optimizer  

### การอัปเกรดจากเวอร์ชันก่อนหน้า
1. ดาวน์โหลด LibTorch เวอร์ชันใหม่ตามคำแนะนำการติดตั้ง  
2. ลบโฟลเดอร์ build: `rm -rf build/`  
3. สร้างโปรเจคใหม่อีกครั้ง  

## ชุดข้อมูล

ดาวน์โหลดชุดข้อมูลจากรีโพสิตอรีต้นฉบับ:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

แตกไฟล์ไปยังโฟลเดอร์ `data` ในโฟลเดอร์โปรเจคหลัก

## ตัวเลือกบรรทัดคำสั่ง

### ตัวเลือกหลัก

- **`-h, --help`**  
  แสดงเมนูช่วยเหลือ

- **`-d, --data-path [PATH]`**  
  เส้นทางไปยังข้อมูลสำหรับฝึกอบรม (จำเป็น)

- **`-o, --output-path [PATH]`**  
  เส้นทางสำหรับบันทึกโมเดลที่ฝึกเสร็จแล้ว (ค่าเริ่มต้น: `./output`)

- **`-i, --iter [NUM]`**  
  จำนวนรอบการฝึกอบรม (ค่าเริ่มต้น: 30000)  
    - งานวิจัยแนะนำ 30k รอบ แต่ 6k-7k รอบมักได้ผลลัพธ์เบื้องต้นที่ดี  
    - ผลลัพธ์จะถูกบันทึกทุก 7k รอบและเมื่อเสร็จสิ้น  

- **`-f, --force`**  
  บังคับเขียนทับโฟลเดอร์ผลลัพธ์ที่มีอยู่

- **`-r, --resolution [NUM]`**  
  กำหนดความละเอียดสำหรับภาพฝึกอบรม

### ตัวเลือกเฉพาะ MCMC

- **`--max-cap [NUM]`**  
  จำนวน Gaussian สูงสุดสำหรับกลยุทธ์ MCMC (ค่าเริ่มต้น: 1000000)  
    - ควบคุมขีดจำกัดสูงสุดของ Gaussian splats ระหว่างการฝึกอบรม  
    - มีประโยชน์สำหรับสภาพแวดล้อมที่มีหน่วยความจำจำกัด  

### ตัวอย่างการใช้งาน

การฝึกอบรมพื้นฐาน:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

การฝึกอบรม MCMC โดยจำกัดจำนวน Gaussians:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## แนวทางการมีส่วนร่วม

เรายินดีรับการมีส่วนร่วม! วิธีเริ่มต้นมีดังนี้:

1. **เริ่มต้น**:  
    - ดูหัวข้อที่ติดป้ายว่า **good first issues** สำหรับงานที่เหมาะกับผู้เริ่มต้น  
    - สำหรับไอเดียใหม่ ๆ เปิดการสนทนาหรือเข้าร่วมใน [Discord](https://discord.gg/TbxJST2BbC)

2. **ก่อนส่ง PR**:  
    - ใช้ `clang-format` เพื่อให้สไตล์โค้ดสอดคล้องกัน  
    - ใช้ pre-commit hook: `cp tools/pre-commit .git/hooks/`  
    - พูดคุยเกี่ยวกับ dependencies ใหม่ใน issue ก่อน - เราตั้งใจลดจำนวน dependencies ให้เหลือน้อยที่สุด

## ขอบคุณ

การใช้งานนี้สร้างขึ้นบนพื้นฐานของโปรเจคสำคัญหลายรายการ:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: เราใช้ gsplat rasterization backend ที่ปรับแต่งด้วย CUDA ประสิทธิภาพสูง ซึ่งให้ประสิทธิภาพและการใช้หน่วยความจำที่ดีกว่า

- **3D Gaussian Splatting ดั้งเดิม**: อิงจากงานวิจัยชั้นนำโดย Kerbl และคณะ

## การอ้างอิง

หากคุณใช้ซอฟต์แวร์นี้ในการวิจัย กรุณาอ้างอิงงานต้นฉบับ:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## ใบอนุญาต

ดูรายละเอียดในไฟล์ LICENSE

---

**เชื่อมต่อกับเรา:**  
- 🌐 เว็บไซต์: [mrnerf.com](https://mrnerf.com)  
- 📚 บทความ: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [เข้าร่วมชุมชนของเรา](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: ติดตาม [@janusch_patas](https://twitter.com/janusch_patas) สำหรับอัปเดตการพัฒนา

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---