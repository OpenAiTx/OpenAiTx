# مكتبة اكتشاف AprilTag المستقلة

هذه حزمة أدوات للتعرف على علامات AprilTag في الكاميرا، مبنية على مكتبة pupil-apriltags، وتُستخدم لاكتشاف وتتبع علامات AprilTag.

<!-- احتفظ بهذه الروابط. ستقوم الترجمات بالتحديث تلقائيًا مع ملف README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## المكتبات المطلوبة

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## التثبيت

1. تأكد من تثبيت بيئة Python
2. ثبّت المتطلبات اللازمة:

```bash
pip install opencv-python numpy pupil-apriltags
```

## طريقة الاستخدام

### الاستخدام الأساسي

```python
import cv2
from apriltag import Detector, DetectorOptions

# إنشاء الكاشف
options = DetectorOptions(
    families="tag36h11",  # عائلة العلامة
    border=1,             # حجم إطار العلامة
    nthreads=4,           # عدد الخيوط
    quad_decimate=1.0,    # معامل تقليل حجم الصورة
    quad_blur=0.0,        # معامل التمويه الغاوسي
    refine_edges=True     # تحسين الحواف
)
detector = Detector(options)

# قراءة الصورة
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# اكتشاف علامات AprilTag
detections = detector.detect(gray)

# عرض نتائج الاكتشاف
for detection in detections:
    print(f"عائلة العلامة: {detection.tag_family}, المعرف: {detection.tag_id}")
    print(f"الموقع: {detection.center}")
    print(f"زوايا العلامة: {detection.corners}")
```

### رسم نتائج الاكتشاف

```python
import numpy as np
from apriltag import draw_detection_results

# مصفوفة معاملات الكاميرا ومعاملات التشوه
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# رسم نتائج الاكتشاف
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# عرض النتائج
cv2.imshow("اكتشاف AprilTag", result_img)
cv2.waitKey(0)
```

### تشغيل سكربت الاختبار

تم توفير سكربت اختبار بسيط للتحقق من وظيفة اكتشاف AprilTag:

```bash
python test_apriltag.py
```

سيتم فتح الكاميرا الافتراضية للحاسوب واكتشاف علامات AprilTag في الوقت الفعلي. اضغط على زر "q" للخروج.

## العائلات المدعومة للعلامات

مكتبة pupil-apriltags تدعم العائلات التالية من العلامات:
- tag36h11 (الافتراضي)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## ملاحظات

- لتحسين الأداء، يمكن ضبط إعدادات DetectorOptions
- للأجهزة ذات الموارد المحدودة، يمكن زيادة معامل quad_decimate لتقليل تعقيد الحسابات
- تأكد من أن حجم علامة AprilTag المستخدمة يطابق قيمة tag_size في الكود
- رسم المحاور ثلاثية الأبعاد يتطلب معاملات كاميرا دقيقة

## الميزات

- دعم اكتشاف علامات AprilTag في الوقت الحقيقي باستخدام كاميرات USB
- حساب وعرض وضعية العلامة ثلاثية الأبعاد (الموقع والاتجاه)
- دعم حفظ الصور الأصلية والموسومة
- قابلية التخصيص الكاملة للإعدادات ومعاملات الكاميرا
- يتضمن أداة كاملة لمعايرة الكاميرا
- لا يعتمد على ROS، إصدار بايثون مستقل عن الحزمة الأصلية لROS

## خطوات التثبيت

### 1. تثبيت مكتبة AprilTag C

مكتبة AprilTag C مطلوبة. الرجاء اتباع الخطوات التالية للتثبيت:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
يجب على مستخدمي Windows تجميع المكتبة بأنفسهم أو تحميل الملفات التنفيذية المجمعة مسبقاً والتأكد من وجود `apriltag.dll` في متغير PATH للنظام أو في المجلد الحالي.

### 2. تثبيت متطلبات Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## دليل الاستخدام

### البداية السريعة (موصى بها)

أسهل طريقة للاستخدام هي تشغيل الأداة المدمجة، والتي توفر قائمة تفاعلية ترشدك عبر جميع الخطوات:

```bash
python apriltag_tool.py
```

ستوفر لك الأداة خيارات قائمة:
1. إنشاء لوحة معايرة شبكية
2. معايرة الكاميرا
3. اكتشاف AprilTag
4. عرض دليل المساعدة

كل ما عليك هو اتباع التعليمات في القائمة لإكمال العملية بالكامل.

### معايرة الكاميرا

قبل استخدام كشف AprilTag، يُنصح بإجراء معايرة للكاميرا للحصول على معاملات دقيقة:

```bash
# أولاً، أنشئ لوحة معايرة شبكية
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# اطبع لوحة الشبكة وقِس حجم المربعات الفعلي، ثم قم بالمعايرة
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

شرح المعاملات:

**أداة إنشاء لوحة الشبكة (create_chessboard.py):**
- `--size`: عدد نقاط الزوايا الداخلية للوحة الشبكة، العرضxالارتفاع (الافتراضي: 9x6)
- `--square`: حجم المربع بالبكسل (الافتراضي: 100)
- `--output`: مسار ملف الإخراج (الافتراضي: chessboard.png)
- `--dpi`: دقة الصورة الناتجة (الافتراضي: 300)، تؤثر على حجم الطباعة

**برنامج معايرة الكاميرا (camera_calibration.py):**
- `--size`: عدد نقاط الزوايا الداخلية للوحة الشبكة، العرضxالارتفاع (الافتراضي: 9x6)
- `--square`: حجم المربع بوحدة المتر (الافتراضي: 0.025)
- `--output`: مسار ملف الإخراج (الافتراضي: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: معرف جهاز الكاميرا (الافتراضي: 0)
- `--width`: عرض التقاط الكاميرا (الافتراضي: 1280)
- `--height`: ارتفاع التقاط الكاميرا (الافتراضي: 720)
- `--samples`: عدد العينات المطلوبة للمعايرة (الافتراضي: 20)
- `--preview`: معاينة نتيجة التصحيح بعد إتمام المعايرة

خطوات المعايرة:
1. أنشئ واطبع لوحة الشبكة للمعايرة
2. قِس الحجم الفعلي للمربعات (بوحدة المتر)
3. شغّل برنامج المعايرة وضع لوحة الشبكة أمام الكاميرا، واجمع عينات من زوايا متعددة
4. سيقوم البرنامج تلقائياً باكتشاف لوحة الشبكة وجمع العينات، أو يمكنك الضغط على زر 's' لحفظ الإطار الحالي يدوياً
5. بعد جمع العينات الكافية، سيحسب البرنامج معاملات الكاميرا تلقائياً ويحفظها في الملف المحدد

### اكتشاف AprilTag

بعد إكمال المعايرة، يمكنك تشغيل برنامج اكتشاف AprilTag:
```bash
python apriltag_detector.py
```

### الاستخدام المتقدم

```bash
python apriltag_detector.py [مسار ملف الإعدادات] --camera معرف_الكاميرا --width العرض --height الارتفاع --camera_info ملف_معلمات_الكاميرا
```

شرح المعاملات:
- `مسار ملف الإعدادات`: مسار ملف إعدادات AprilTag (الافتراضي: `config/vision/tags_36h11_all.json`)
- `--camera`: معرف جهاز الكاميرا (الافتراضي: 0)
- `--camera_info`: مسار ملف معلمات الكاميرا الداخلية (الافتراضي: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: عرض التقاط الكاميرا (الافتراضي: 1280)
- `--height`: ارتفاع التقاط الكاميرا (الافتراضي: 720)

### التحكم عبر لوحة المفاتيح

- `q`: إنهاء البرنامج

## شرح ملفات الإعدادات

يمكنك ضبط كافة إعدادات النظام في ملف `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // عائلة العلامات
        "size": 0.05,              // الحجم الفيزيائي للعلامة (بالمتر)
        "threads": 2,              // عدد خيوط المعالجة
        "max_hamming": 0,          // الحد الأعلى لمسافة هامنج
        "z_up": true,              // المحور Z للأعلى
        "decimate": 1.0,           // معامل تصغير الصورة
        "blur": 0.8,               // معامل التمويه
        "refine_edges": 1,         // تحسين الحواف
        "debug": 0                 // تفعيل وضع التصحيح
    },

    "Camera": {
        "device_id": 0,            // معرف جهاز الكاميرا
        "width": 1280,             // دقة عرض الكاميرا
        "height": 720,             // دقة ارتفاع الكاميرا
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // ملف معايرة الكاميرا
    },

    "Archive": {
        "enable": true,            // تفعيل أرشفة البيانات
        "preview": true,           // عرض نافذة المعاينة
        "save_raw": false,         // حفظ الصور الأصلية
        "save_pred": false,        // حفظ صور النتائج المتوقعة
        "path": "./data/table_tracking"  // مسار حفظ البيانات
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // قائمة معرفات العلامات المرجعية
        "moving_tags": [4, 5, 6],            // قائمة معرفات العلامات المتحركة
        "require_initialization": true,       // هل يتطلب التهيئة؟
        "tag_positions": {                    // مواقع العلامات المسبقة (إن وجدت)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

من خلال تعديل ملف الإعدادات يمكنك:
1. ضبط معلمات كاشف AprilTag
2. إعداد معلمات الكاميرا (معرف الجهاز، الدقة، ملف المعايرة)
3. إعداد خيارات أرشفة البيانات
4. تخصيص معرفات العلامات المرجعية والمتحركة
5. التحكم في الحاجة إلى التهيئة (ضبط `require_initialization` إلى `false` لتخطي التهيئة)
6. تعيين مواقع العلامات مسبقاً

### طريقة الاستخدام

الأمر بسيط جداً، فقط شغّل النظام بالأمر التالي:

```
python table_tracking.py
```

إذا رغبت في استخدام ملف إعدادات مخصص:

```
python table_tracking.py --config مسار_ملف_الإعدادات_المخصص
```

بعد تشغيل النظام، يمكنك الضغط على زر 'i' في أي وقت لبدء التهيئة يدوياً.

## الأسئلة الشائعة

1. **تعذر العثور على مكتبة apriltag**
   
   تأكد من تثبيت مكتبة apriltag بشكل صحيح وأن ملفات المكتبة متوفرة في النظام.

2. **تعذر فتح الكاميرا**
   
   تحقق من صحة معرف الكاميرا، ومن عدم استخدامها من قبل برنامج آخر.

3. **نتائج الكشف غير دقيقة**
   
   تأكد من معايرة الكاميرا بشكل صحيح، وأن حجم العلامة في ملف الإعدادات مطابق للواقع.

## شرح بنية الملفات

```
apriltag_standalone/
├── apriltag.py              # الكود الأساسي لمكتبة كشف AprilTag
├── apriltag_detector.py     # البرنامج الرئيسي لكشف AprilTag
├── apriltag_tool.py         # قائمة أدوات التكامل
├── camera_calibration.py    # برنامج معايرة الكاميرا
├── create_chessboard.py     # أداة توليد لوحة الشطرنج
├── configs.py               # معالجة ملفات الإعدادات
├── config/                  # مجلد الإعدادات
│   ├── camera/              # إعدادات الكاميرا
│   │   └── HSK_200W53_1080P.yaml  # ملف معلمات الكاميرا
│   └── vision/              # إعدادات الرؤية
│       └── tags_36h11_all.json # إعدادات AprilTag
├── README.md                # ملف التوثيق
└── requirements.txt         # متطلبات بايثون
```

## الشرح التقني

هذا المشروع عبارة عن نسخة مستقلة من حزمة كشف AprilTag الخاصة بـ ROS، حيث تمت إزالة الاعتمادية على ROS مع الحفاظ على الوظائف الأساسية.
التقنيات المستخدمة:

- OpenCV: معالجة الصور، معايرة الكاميرا وتقدير الوضعية
- مكتبة AprilTag C: كشف العلامات
- SciPy: تحويلات مصفوفات الدوران والكواتيرنيون

## الرخصة

هذا المشروع مرخص تحت رخصة MIT

## شرح الميزات الجديدة

### تتبع متعدد العلامات ومعالجة الحجب

يدعم النظام الآن الميزات التالية:

1. **تهيئة عبر التصوير**: عند بدء النظام، يتم تلقائياً التقاط صورة للتهيئة وتسجيل العلاقة بين مواقع العلامات، بما في ذلك:
   - مواقع العلامات المرجعية الثابتة (المعرفات 0-3)
   - العلاقة النسبية بين عدة علامات متحركة (افتراضياً المعرفات 4 و5 و6)

2. **معالجة الحجب**: بعد التهيئة، حتى لو تم حجب بعض العلامات:
   - إذا تم حجب علامة مرجعية، يمكن للنظام تقدير موقع العلامة المحجوبة باستخدام العلامات المرجعية المرئية الأخرى
   - إذا تم حجب علامة متحركة، يمكن تقدير موقعها باستخدام العلامات المتحركة الأخرى المرئية

3. **تتبع متعدد العلامات**: يدعم تتبع عدة علامات متحركة في نفس الوقت، افتراضياً للمعرفات 4 و5 و6
   - إذا كانت المواقع النسبية للعلامات المتحركة ثابتة، يكفي ظهور علامة واحدة مرئية لتقدير مواقع الباقي
   - يمكنك تخصيص معرفات العلامات المتحركة من خلال ملف الإعدادات

### شرح ملف الإعدادات

يمكنك ضبط كافة إعدادات النظام في ملف `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // قائمة معرفات العلامات المرجعية
        "moving_tags": [4, 5, 6],            // قائمة معرفات العلامات المتحركة
        "require_initialization": true,       // هل يتطلب التهيئة؟
        "tag_positions": {                    // مواقع العلامات المسبقة (إن وجدت)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

من خلال تعديل ملف الإعدادات يمكنك:
1. تخصيص معرفات العلامات المرجعية والمتحركة
2. التحكم في الحاجة إلى التهيئة (ضبط `require_initialization` إلى `false` لتخطي التهيئة)
3. تعيين مواقع العلامات مسبقاً

### طريقة الاستخدام

1. تشغيل النظام بالإعدادات الافتراضية:
   ```
   python table_tracking.py
   ```

2. تشغيل النظام بملف إعدادات مخصص:
   ```
   python table_tracking.py --config مسار_ملف_الإعدادات_المخصص
   ```

3. تهيئة يدوية: أثناء تشغيل النظام اضغط على زر 'i'

### متطلبات التشغيل

تأكد من أن جميع العلامات مرئية أثناء التهيئة، حيث يسجل النظام العلاقات النسبية بين العلامات. بعد التهيئة، حتى إذا تم حجب بعض العلامات، يستطيع النظام تقدير مواقع جميع العلامات بشكل صحيح.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---