# 🖼️ ابزارهای پردازش تصویر HEIC

مجموعه‌ای از ابزارهای پایتون برای پردازش فایل‌های HEIC (High Efficiency Image Container) با تمرکز بر استخراج محتوای HDR و تبدیل به فرمت EXR.

## 🛠️ مرور ابزارها

### 1. gain_map_extract.py
استخراج تمام اجزای فایل‌های HEIC شامل:
- تصاویر پایه
- نقشه‌های افزایش HDR (gain map)
- نقشه‌های عمق
- متادیتای کامل (EXIF، XMP، پروفایل‌های ICC)

### 2. heic_to_exr.py
تبدیل فایل‌های HEIC به فرمت OpenEXR:
- ترکیب تصویر پایه و نقشه افزایش به HDR EXR با استفاده از روش اپل
- حفظ کامل دامنه دینامیکی
- حفظ متادیتا تا حد امکان
- پشتیبانی از پردازش دسته‌ای
### 3. merge_to_exr.sh
اسکریپت شل برای پردازش دسته‌ای:
- خودکارسازی تبدیل HEIC به EXR
- مدیریت چندین فایل
- ارائه بازخورد پیشرفت
- حفظ ساختار پوشه‌ها

## 🔧 نصب

### پیش‌نیازها
- پایتون 3.8 یا بالاتر
- pip (مدیر بسته پایتون)
- Git (برای کلون کردن مخزن)

### macOS
```bash
# اگر Homebrew نصب نیست آن را نصب کنید
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# نصب پایتون و وابستگی‌های OpenEXR
brew install python3 openexr

# مخزن را کلون کنید
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# ایجاد و فعال‌سازی محیط مجازی
python3 -m venv venv
source venv/bin/activate

# نصب وابستگی‌های پایتون
pip install -r requirements.txt
```

### لینوکس (اوبونتو/دبیان)
```bash
# نصب وابستگی‌های سیستمی
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# کلون کردن مخزن
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# ایجاد و فعال‌سازی محیط مجازی
python3 -m venv venv
source venv/bin/activate

# نصب وابستگی‌های پایتون
pip install -r requirements.txt
```

### ویندوز
```powershell
# نصب پایتون از https://www.python.org/downloads/
# نصب گیت از https://git-scm.com/download/win

# کلون کردن مخزن
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# ایجاد و فعال‌سازی محیط مجازی
python -m venv venv
.\venv\Scripts\activate

# نصب وابستگی‌های پایتون
pip install -r requirements.txt
```

## 📋 نیازمندی‌ها
تمام بسته‌های مورد نیاز پایتون در فایل requirements.txt فهرست شده‌اند:
- Pillow: کتابخانه پردازش تصویر
- pillow-heif: پشتیبانی از فایل‌های HEIC
- numpy: عملیات عددی
- defusedxml: تجزیه امن XML

وابستگی‌های سیستمی (نصب از طریق مدیر بسته):
- OpenEXR و OpenImageIO (oiiotool) برای مدیریت فایل‌های EXR

## 💻 نحوه استفاده
### استخراج نقشه بهره
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### تبدیل HEIC به EXR
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### پردازش دسته‌ای
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 فایل‌های خروجی

### خروجی‌های gain_map_extract.py:
- تصویر پایه: `{filename}_base.tiff`
- نقشه‌های بهره: `{filename}_gain_map_{id}.tiff`
- نقشه‌های عمق: `{filename}_depth_{index}.tiff`
- فراداده: `{filename}_metadata.json`

### خروجی‌های heic_to_exr.py:
- فایل HDR EXR: `{filename}.exr`

## 🔍 استفاده پیشرفته

### مدیریت فراداده
- داده‌های باینری به صورت base64 کدگذاری می‌شوند
- پروفایل‌های ICC حفظ می‌شوند
- داده‌های EXIF تا حد امکان نگهداری می‌شوند

### پردازش HDR
- نقشه‌های گین به درستی مقیاس‌بندی می‌شوند
- فضای رنگی خطی حفظ می‌شود
- دامنه دینامیکی کامل در خروجی EXR حفظ می‌شود

## ⚠️ محدودیت‌های شناخته شده
- برخی واریانت‌های HEIC ممکن است به طور کامل پشتیبانی نشوند
- استخراج نقشه عمق محدود به دستگاه‌های پشتیبانی‌شده است
- پشتیبانی OpenEXR در ویندوز ممکن است به پیکربندی اضافی نیاز داشته باشد
## 🤝 مشارکت
مشارکت‌ها خوش‌آمدند! لطفاً در صورت تمایل یک Pull Request ارسال کنید.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---