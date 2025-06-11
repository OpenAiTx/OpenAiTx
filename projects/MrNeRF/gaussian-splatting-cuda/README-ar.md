# التوزيع الغاوسي ثلاثي الأبعاد لتصيير مجال الإشعاع في الوقت الحقيقي - تنفيذ C++ و CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

تنفيذ عالي الأداء بلغة C++ وCUDA لتقنية التوزيع الغاوسي ثلاثي الأبعاد، مبني على خلفية التظليل [gsplat](https://github.com/nerfstudio-project/gsplat).

## الأخبار
- **[2025-06-10]**: تم إصلاح بعض المشاكل. نحن نقترب من تحقيق مقاييس gsplat. ومع ذلك، لا يزال هناك بعض الاختلاف الطفيف.
- **[2025-06-04]**: أضيفت استراتيجية MCMC مع خيار سطر الأوامر `--max-cap` للتحكم في الحد الأقصى لعدد التوزيعات الغاوسية.
- **[2025-06-03]**: تم التحول إلى الخلفية Gsplat وتحديث الترخيص.
- **[2024-05-27]**: تم التحديث إلى LibTorch 2.7.0 لتحسين التوافق والأداء. تم معالجة تغييرات كسرية في إدارة حالة المحسن.
- **[2024-05-26]**: الهدف الحالي لهذا المستودع هو الانتقال إلى ترخيص أكثر تساهلاً. تم إجراء عمل كبير لاستبدال المظلل بخلفية gsplat.

## المقاييس
حالياً لا يحقق التنفيذ نتائج مماثلة لـ gsplat-mcmc، لكنه قيد التطوير.
إنها مسألة وقت فقط لإصلاح الخطأ. المساعدة مرحب بها :) المقاييس لاستراتيجية mcmc كما يلي:

| المشهد    | التكرار  | PSNR          | SSIM         | LPIPS        | الوقت لكل صورة | عدد التوزيعات الغاوسية |
| --------- | -------- | ------------- | ------------ | ------------ | -------------- | ----------------------- |
| garden    | 30000    | 27.112114     | 0.854833     | 0.157624     | 0.304765       | 1000000                 |
| bicycle   | 30000    | 25.047745     | 0.767729     | 0.254825     | 0.293618       | 1000000                 |
| stump     | 30000    | 26.554749     | 0.784203     | 0.263013     | 0.296536       | 1000000                 |
| bonsai    | 30000    | 32.534199     | 0.948675     | 0.246924     | 0.436188       | 1000000                 |
| counter   | 30000    | 29.187017     | 0.915823     | 0.242159     | 0.441259       | 1000000                 |
| kitchen   | 30000    | 31.680832     | 0.933897     | 0.154965     | 0.449078       | 1000000                 |
| room      | 30000    | 32.211632     | 0.930754     | 0.273719     | 0.413519       | 1000000                 |
| **المتوسط** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**   | **1000000**             |

## المجتمع والدعم

انضم إلى مجتمعنا المتنامي للنقاشات والدعم والتحديثات:
- 💬 **[مجتمع ديسكورد](https://discord.gg/TbxJST2BbC)** - احصل على المساعدة، شارك النتائج، وناقش التطوير
- 🌐 **[mrnerf.com](https://mrnerf.com)** - زور موقعنا للمزيد من الموارد
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - قائمة شاملة بالأوراق والموارد
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - تابع آخر التحديثات

## تعليمات البناء والتنفيذ

### متطلبات البرمجيات
1. **لينكس** (تم الاختبار على أوبونتو 22.04) - نظام ويندوز غير مدعوم حالياً
2. **CMake** نسخة 3.24 أو أعلى
3. **CUDA** نسخة 11.8 أو أعلى (قد تعمل مع إصدارات أقل مع التكوين اليدوي)
4. **بايثون** مع ملفات التطوير headers
5. **LibTorch 2.7.0** - تعليمات الإعداد أدناه
6. يتم التعامل مع باقي التبعيات تلقائياً بواسطة CMake

### متطلبات الأجهزة
1. **بطاقة NVIDIA GPU** مع دعم CUDA
    - تم الاختبار بنجاح: RTX 4090, RTX A5000, RTX 3090Ti, A100
    - مشكلة معروفة مع RTX 3080Ti على مجموعات بيانات كبيرة (راجع #21)
2. الحد الأدنى لقدرة الحوسبة: 8.0

> إذا نجحت في التشغيل على أجهزة أخرى، يرجى مشاركة تجربتك في قسم النقاشات!

### تعليمات البناء

```bash
# استنساخ المستودع مع الوحدات الفرعية
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# تنزيل وإعداد LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# بناء المشروع
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

يستخدم هذا المشروع **LibTorch 2.7.0** لأفضل أداء وتوافق:

- **أداء محسّن**: تحسينات في الأمثل وإدارة الذاكرة
- **ثبات API**: أحدث واجهة برمجة التطبيقات الثابتة لـ PyTorch C++
- **توافق CUDA**: تكامل أفضل مع CUDA 11.8+
- **إصلاحات أخطاء**: معالجة مشاكل إدارة حالة المحسن

### التحديث من الإصدارات السابقة
1. قم بتنزيل نسخة LibTorch الجديدة باستخدام تعليمات البناء أعلاه
2. نظف مجلد البناء: `rm -rf build/`
3. أعد بناء المشروع

## مجموعة البيانات

حمّل مجموعة البيانات من المستودع الأصلي:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

فك الضغط في مجلد `data` في جذر المشروع.

## خيارات سطر الأوامر

### الخيارات الأساسية

- **`-h, --help`**  
  عرض قائمة المساعدة

- **`-d, --data-path [PATH]`**  
  مسار بيانات التدريب (مطلوب)

- **`-o, --output-path [PATH]`**  
  مسار حفظ النموذج المُدرّب (افتراضي: `./output`)

- **`-i, --iter [NUM]`**  
  عدد تكرارات التدريب (افتراضي: 30000)
    - الورقة البحثية تقترح 30 ألف، لكن 6-7 آلاف غالباً ما تعطي نتائج أولية جيدة
    - يتم حفظ النتائج كل 7 آلاف تكرار وعند الانتهاء

- **`-f, --force`**  
  إجبار الكتابة فوق مجلد الإخراج الحالي

- **`-r, --resolution [NUM]`**  
  تعيين دقة صور التدريب

### خيارات خاصة بـ MCMC

- **`--max-cap [NUM]`**  
  الحد الأقصى لعدد التوزيعات الغاوسية لاستراتيجية MCMC (افتراضي: 1000000)
    - يتحكم في الحد الأعلى لتوزيعات الغاوس أثناء التدريب
    - مفيد للبيئات ذات الذاكرة المحدودة

### مثال على الاستخدام

تدريب أساسي:
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

تدريب MCMC مع عدد محدود من التوزيعات:
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## إرشادات المساهمة

نرحب بالمساهمات! إليك كيفية البدء:

1. **البدء**:
    - تحقق من القضايا الموسومة بـ **good first issues** للمهام المناسبة للمبتدئين
    - للأفكار الجديدة، افتح نقاشاً أو انضم إلى [ديسكورد](https://discord.gg/TbxJST2BbC)

2. **قبل تقديم طلب سحب PR**:
    - طبق `clang-format` للحفاظ على نمط الكود الموحد
    - استخدم pre-commit hook: `cp tools/pre-commit .git/hooks/`
    - ناقش التبعيات الجديدة في قضية أولاً - نهدف إلى تقليل التبعيات

## الشكر والتقدير

يعتمد هذا التنفيذ على عدة مشاريع رئيسية:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: نستخدم خلفية التظليل CUDA المحسنة للغاية من gsplat، التي توفر تحسينات كبيرة في الأداء وكفاءة الذاكرة.

- **التوزيع الغاوسي ثلاثي الأبعاد الأصلي**: استناداً إلى العمل الرائد لـ Kerbl وآخرين.

## الاستشهاد

إذا استخدمت هذا البرنامج في أبحاثك، يرجى الاستشهاد بالعمل الأصلي:

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

## الترخيص

راجع ملف LICENSE للتفاصيل.

---

**تواصل معنا:**  
- 🌐 الموقع: [mrnerf.com](https://mrnerf.com)  
- 📚 الأوراق: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 ديسكورد: [انضم إلى مجتمعنا](https://discord.gg/TbxJST2BbC)  
- 🐦 تويتر: تابع [@janusch_patas](https://twitter.com/janusch_patas) لتحديثات التطوير

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---