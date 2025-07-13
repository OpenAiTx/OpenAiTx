# 🖼️ เครื่องมือประมวลผลภาพ HEIC

ชุดเครื่องมือ Python สำหรับประมวลผลไฟล์ HEIC (High Efficiency Image Container) โดยเน้นการสกัดเนื้อหา HDR และแปลงเป็นไฟล์ EXR

## 🛠️ ภาพรวมของเครื่องมือ

### 1. gain_map_extract.py
สกัดองค์ประกอบทั้งหมดจากไฟล์ HEIC รวมถึง:
- ภาพพื้นฐาน
- แผนที่ HDR gain
- แผนที่ความลึก
- ข้อมูลเมตาทั้งหมด (EXIF, XMP, โปรไฟล์ ICC)

### 2. heic_to_exr.py
แปลงไฟล์ HEIC เป็นรูปแบบ OpenEXR:
- รวมภาพพื้นฐานและ gain map เป็น HDR EXR โดยใช้วิธีของ Apple
- รักษาช่วงไดนามิกเต็มรูปแบบ
- คงข้อมูลเมตาไว้หากเป็นไปได้
- รองรับการประมวลผลแบบแบทช์
### 3. merge_to_exr.sh
สคริปต์เชลล์สำหรับประมวลผลแบบกลุ่ม:
- ทำการแปลงไฟล์ HEIC เป็น EXR โดยอัตโนมัติ
- จัดการไฟล์หลายไฟล์
- แสดงสถานะความคืบหน้า
- รักษาโครงสร้างไดเรกทอรี

## 🔧 การติดตั้ง

### ข้อกำหนดเบื้องต้น
- Python 3.8 ขึ้นไป
- pip (ตัวจัดการแพ็กเกจของ Python)
- Git (สำหรับโคลนรีโพซิทอรี)

### macOS
```bash
# ติดตั้ง Homebrew หากยังไม่ได้ติดตั้ง
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# ติดตั้ง Python และไลบรารีที่จำเป็นสำหรับ OpenEXR
brew install python3 openexr

# โคลนรีโพซิทอรี
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# สร้างและเปิดใช้งาน virtual environment
python3 -m venv venv
source venv/bin/activate

# ติดตั้ง Python dependencies
pip install -r requirements.txt
```

### Linux (Ubuntu/Debian)
```bash
# ติดตั้ง system dependencies
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# โคลนรีโพซิทอรี
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# สร้างและเปิดใช้งาน virtual environment
python3 -m venv venv
source venv/bin/activate

# ติดตั้งไลบรารี Python ที่จำเป็น
pip install -r requirements.txt
```

### Windows
```powershell
# ติดตั้ง Python จาก https://www.python.org/downloads/
# ติดตั้ง Git จาก https://git-scm.com/download/win

# โคลนรีโพซิทอรี
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# สร้างและเปิดใช้งานสภาพแวดล้อมเสมือน
python -m venv venv
.\venv\Scripts\activate

# ติดตั้งไลบรารี Python ที่จำเป็น
pip install -r requirements.txt
```

## 📋 ข้อกำหนด
แพ็คเกจ Python ที่จำเป็นทั้งหมดระบุไว้ใน requirements.txt:
- Pillow: ไลบรารีประมวลผลภาพ
- pillow-heif: รองรับไฟล์ HEIC
- numpy: การคำนวณเชิงตัวเลข
- defusedxml: การแปลง XML อย่างปลอดภัย

ระบบ dependencies (ติดตั้งผ่านตัวจัดการแพ็คเกจ):
- OpenEXR และ OpenImageIO (oiiotool) สำหรับจัดการไฟล์ EXR

## 💻 วิธีใช้งาน
### การแยก Gain Map
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### การแปลง HEIC เป็น EXR
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### การประมวลผลแบบกลุ่ม
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 ไฟล์ผลลัพธ์

### ไฟล์ที่ได้จาก gain_map_extract.py:
- ภาพฐาน: `{filename}_base.tiff`
- Gain maps: `{filename}_gain_map_{id}.tiff`
- Depth maps: `{filename}_depth_{index}.tiff`
- ข้อมูลเมตา: `{filename}_metadata.json`

### heic_to_exr.py ผลลัพธ์ที่ได้:
- ไฟล์ HDR EXR: `{filename}.exr`

## 🔍 การใช้งานขั้นสูง

### การจัดการข้อมูลเมตา
- ข้อมูลไบนารีจะถูกเข้ารหัสแบบ base64
- โปรไฟล์ ICC จะถูกรักษาไว้
- ข้อมูล EXIF จะถูกเก็บรักษาไว้เท่าที่เป็นไปได้

### การประมวลผล HDR
- แผนที่ Gain จะถูกปรับสเกลอย่างเหมาะสม
- จะรักษาพื้นที่สีเชิงเส้น (Linear color space) ไว้
- ช่วงไดนามิกแบบเต็มจะถูกรักษาไว้ในผลลัพธ์ EXR

## ⚠️ ข้อจำกัดที่ทราบ
- บางรูปแบบของ HEIC อาจไม่ได้รับการสนับสนุนอย่างสมบูรณ์
- การดึงข้อมูลแผนที่ความลึกจำกัดเฉพาะอุปกรณ์ที่รองรับเท่านั้น
- การรองรับ OpenEXR บน Windows อาจต้องมีการกำหนดค่าพิเศษเพิ่มเติม
## 🤝 การมีส่วนร่วม
ยินดีต้อนรับการมีส่วนร่วม! กรุณาส่ง Pull Request ได้ตามต้องการ



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---