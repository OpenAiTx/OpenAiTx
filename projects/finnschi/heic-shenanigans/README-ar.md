# 🖼️ أدوات معالجة صور HEIC

مجموعة من أدوات بايثون لمعالجة ملفات HEIC (حاوية الصور عالية الكفاءة)، مع التركيز على استخراج محتوى HDR وتحويله إلى EXR.

## 🛠️ نظرة عامة على الأدوات

### 1. gain_map_extract.py
يستخرج جميع المكونات من ملفات HEIC بما في ذلك:
- الصور الأساسية
- خرائط الكسب HDR
- خرائط العمق
- البيانات الوصفية الكاملة (EXIF، XMP، ملفات ICC)

### 2. heic_to_exr.py
يحوّل ملفات HEIC إلى تنسيق OpenEXR:
- يدمج الصورة الأساسية وخريطة الكسب في ملف EXR عالي الديناميكية باستخدام طريقة آبل
- يحافظ على النطاق الديناميكي الكامل
- يحتفظ بالبيانات الوصفية قدر الإمكان
- يدعم المعالجة الدُفعية
### 3. merge_to_exr.sh
سكريبت شيل لمعالجة الدُفعات:
- يقوم بأتمتة تحويل HEIC إلى EXR
- يتعامل مع ملفات متعددة
- يوفر تغذية راجعة عن التقدم
- يحافظ على هيكلية الدليل

## 🔧 التثبيت

### المتطلبات المسبقة
- بايثون 3.8 أو أحدث
- pip (مدير حزم بايثون)
- Git (لاستنساخ المستودع)

### macOS
```bash
# تثبيت Homebrew إذا لم يكن مثبتاً مسبقاً
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# تثبيت بايثون واعتمادات OpenEXR
brew install python3 openexr

# استنساخ المستودع
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# إنشاء وتفعيل البيئة الافتراضية
python3 -m venv venv
source venv/bin/activate

# تثبيت تبعيات بايثون
pip install -r requirements.txt
```

### لينكس (أوبونتو/ديبيان)
```bash
# تثبيت التبعيات النظامية
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# استنساخ المستودع
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# إنشاء وتفعيل البيئة الافتراضية
python3 -m venv venv
source venv/bin/activate

# تثبيت تبعيات بايثون
pip install -r requirements.txt
```

### ويندوز
```powershell
# تثبيت بايثون من https://www.python.org/downloads/
# تثبيت Git من https://git-scm.com/download/win

# استنساخ المستودع
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# إنشاء وتفعيل البيئة الافتراضية
python -m venv venv
.\venv\Scripts\activate

# تثبيت تبعيات بايثون
pip install -r requirements.txt
```

## 📋 المتطلبات
جميع حزم بايثون المطلوبة مدرجة في requirements.txt:
- Pillow: مكتبة معالجة الصور
- pillow-heif: دعم ملفات HEIC
- numpy: العمليات العددية
- defusedxml: تحليل XML آمن

تبعيات النظام (يتم تثبيتها عبر مدير الحزم):
- OpenEXR و OpenImageIO (oiiotool) لمعالجة ملفات EXR

## 💻 طريقة الاستخدام
### استخراج خريطة الكسب
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### تحويل HEIC إلى EXR
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### المعالجة الدُفعية
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 ملفات الإخراج

### مخرجات gain_map_extract.py:
- الصورة الأساسية: `{filename}_base.tiff`
- خرائط الكسب: `{filename}_gain_map_{id}.tiff`
- خرائط العمق: `{filename}_depth_{index}.tiff`
- بيانات التعريف: `{filename}_metadata.json`

### مخرجات heic_to_exr.py:
- ملف HDR EXR: `{filename}.exr`

## 🔍 استخدام متقدم

### معالجة البيانات الوصفية
- يتم ترميز البيانات الثنائية بصيغة base64
- يتم الحفاظ على ملفات ICC
- يتم الاحتفاظ ببيانات EXIF حيثما أمكن

### معالجة HDR
- يتم تحجيم خرائط الكسب بشكل صحيح
- يتم الحفاظ على مساحة الألوان الخطية
- يتم الحفاظ على النطاق الديناميكي الكامل في مخرجات EXR

## ⚠️ القيود المعروفة
- قد لا تكون بعض أنواع HEIC مدعومة بالكامل
- استخراج خريطة العمق يقتصر على الأجهزة المدعومة
- قد يتطلب دعم OpenEXR في ويندوز إعدادات إضافية
## 🤝 المساهمة
المساهمات مرحب بها! لا تتردد في تقديم طلب سحب (Pull Request).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---