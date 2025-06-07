# واجهة الويب لـ Stable Diffusion
واجهة ويب لـ Stable Diffusion، تم تنفيذها باستخدام مكتبة Gradio.

![](screenshot.png)

## الميزات
[عرض تفصيلي للميزات مع الصور](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- أوضاع txt2img و img2img الأصلية
- برنامج تثبيت وتشغيل بنقرة واحدة (لكن يجب عليك تثبيت بايثون و git أولاً)
- التلوين خارج الحدود (Outpainting)
- الرسم داخل الصورة (Inpainting)
- رسم الألوان (Color Sketch)
- مصفوفة الأوامر (Prompt Matrix)
- تكبير Stable Diffusion
- الانتباه، تحديد أجزاء من النص يجب أن يوليها النموذج اهتمامًا أكبر
    - رجل يرتدي `((بدلة رسمية))` - سيولي اهتمامًا أكبر للبدلة الرسمية
    - رجل يرتدي `(بدلة رسمية:1.21)` - صياغة بديلة
    - حدد النص واضغط `Ctrl+Up` أو `Ctrl+Down` (أو `Command+Up` أو `Command+Down` على MacOS) لضبط الانتباه تلقائيًا للنص المحدد (الكود مقدم من مستخدم مجهول)
- التكرار العكسي (Loopback)، تشغيل معالجة img2img عدة مرات
- رسم ثلاثي الأبعاد X/Y/Z، طريقة لرسم مخطط ثلاثي الأبعاد للصور بمعاملات مختلفة
- الانقلاب النصي (Textual Inversion)
    - يمكنك الحصول على عدد غير محدود من التضمينات واستخدام أي أسماء تريدها لها
    - استخدام عدة تضمينات بعدد متجهات مختلف لكل رمز
    - يعمل مع أرقام النقطة العائمة بنصف الدقة
    - تدريب التضمينات على ذاكرة 8GB (مع تقارير عن عملها على 6GB أيضًا)
- تبويب الإضافات يحتوي على:
    - GFPGAN، شبكة عصبونية لإصلاح الوجوه
    - CodeFormer، أداة لاستعادة الوجوه كبديل لـ GFPGAN
    - RealESRGAN، شبكة عصبونية للتكبير
    - ESRGAN، شبكة عصبونية للتكبير مع العديد من النماذج الخارجية
    - SwinIR و Swin2SR ([انظر هنا](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092))، شبكات عصبية للتكبير
    - LDSR، تكبير فائق الدقة باستخدام الانتشار الكامن
- خيارات نسبة الأبعاد لتغيير الحجم
- اختيار طريقة التوليد (Sampling method)
    - ضبط قيم eta للمولد (مضاعف الضوضاء)
    - خيارات إعداد ضوضاء متقدمة
- إيقاف المعالجة في أي وقت
- دعم لبطاقات الرسومات بسعة 4GB (مع تقارير عن عمله على 2GB)
- بذور صحيحة للدفعات
- التحقق الفوري لطول رموز الأمر النصي
- معاملات التوليد
     - المعاملات المستخدمة لتوليد الصور تحفظ مع الصورة
     - في أجزاء PNG لصور PNG، وفي EXIF لصور JPEG
     - يمكن سحب الصورة إلى تبويب معلومات PNG لاستعادة معاملات التوليد ونسخها تلقائيًا إلى واجهة المستخدم
     - يمكن تعطيلها من الإعدادات
     - سحب وإفلات صورة/معاملات نصية إلى مربع الأمر
- زر قراءة معاملات التوليد، يقوم بتحميل المعاملات من مربع الأمر إلى الواجهة
- صفحة الإعدادات
- تشغيل أي كود بايثون من الواجهة (يجب التشغيل مع `--allow-code` للتفعيل)
- تلميحات عند المرور بالفأرة لمعظم عناصر الواجهة
- إمكانية تغيير القيم الافتراضية/الحد الأدنى/الحد الأقصى/خطوة عناصر الواجهة عبر إعدادات نصية
- دعم التبليط، اختيار لإنشاء صور يمكن تبليطها كخامات
- شريط تقدم ومعاينة توليد الصورة مباشرة
    - يمكن استخدام شبكة عصبونية منفصلة لإنتاج معاينات مع استهلاك ضئيل لذاكرة VRAM أو قدرة الحوسبة
- أمر سلبي، حقل نصي إضافي يسمح لك بتحديد ما لا تريد رؤيته في الصورة المولدة
- الأنماط، طريقة لحفظ جزء من الأمر النصي وتطبيقه بسهولة لاحقًا عبر قائمة منسدلة
- المتغيرات، طريقة لتوليد نفس الصورة مع اختلافات طفيفة
- تغيير حجم البذرة، طريقة لتوليد نفس الصورة بدقة مختلفة قليلاً
- أداة CLIP interrogator، زر يحاول تخمين الأمر من صورة
- تحرير الأمر النصي أثناء التوليد، مثل بدء توليد بطيخ ثم التبديل إلى شخصية أنمي في منتصف العملية
- معالجة دفعات، معالجة مجموعة من الملفات باستخدام img2img
- بديل img2img، طريقة Euler العكسية للتحكم في الانتباه المتقاطع
- إصلاح الدقة العالية، خيار لراحة المستخدم لإنتاج صور عالية الدقة بضغطة واحدة بدون التشوهات المعتادة
- إعادة تحميل نقاط الاستعادة أثناء التشغيل
- دمج نقاط الاستعادة، تبويب يسمح بدمج حتى 3 نقاط استعادة في واحدة
- [برمجيات مخصصة](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) مع العديد من الإضافات من المجتمع
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/)، طريقة لاستخدام أوامر نصية متعددة دفعة واحدة
     - افصل الأوامر النصية باستخدام `AND` بالأحرف الكبيرة
     - يدعم أيضًا الأوزان للأوامر: `قطة :1.2 AND كلب AND بطريق :2.2`
- لا يوجد حد لعدد الرموز في الأوامر النصية (النسخة الأصلية تسمح بـ 75 رمزًا فقط)
- دمج DeepDanbooru، ينشئ وسومًا بنمط danbooru لأوامر الأنمي
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers)، زيادة كبيرة في السرعة لبعض البطاقات (أضف `--xformers` إلى وسيطات سطر الأوامر)
- عبر إضافة: [تبويب السجل](https://github.com/yfszzx/stable-diffusion-webui-images-browser): عرض، إدارة وحذف الصور بسهولة من داخل الواجهة
- خيار التوليد المستمر
- تبويب التدريب
     - خيارات الشبكات الفائقة والتضمينات
     - معالجة الصور المسبقة: الاقتصاص، العكس، وضع الوسوم تلقائيًا باستخدام BLIP أو deepdanbooru (للانمي)
- تخطي CLIP
- الشبكات الفائقة (Hypernetworks)
- Loras (مشابهة للشبكات الفائقة لكن أجمل)
- واجهة منفصلة يمكنك من خلالها اختيار أي تضمين أو شبكة فائقة أو Lora مع معاينة لإضافتها إلى الأمر النصي
- إمكانية اختيار تحميل VAE مختلف من شاشة الإعدادات
- تقدير وقت الانتهاء في شريط التقدم
- واجهة برمجة التطبيقات (API)
- دعم لنموذج [inpainting المخصص](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) من RunwayML
- عبر إضافة: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients)، طريقة لتوليد صور بجمالية محددة باستخدام تضمينات صور clip (تنفيذ لـ [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- دعم [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - راجع [الويكي](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) للتعليمات
- دعم [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - راجع [الويكي](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) للتعليمات
- الآن بدون أي أحرف سيئة!
- تحميل نقاط الاستعادة بصيغة safetensors
- تخفيف تقييد الدقة: أبعاد الصورة المولدة يجب أن تكون مضاعفات 8 بدلاً من 64
- الآن مع رخصة استخدام!
- إعادة ترتيب عناصر الواجهة من شاشة الإعدادات
- دعم [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## التثبيت والتشغيل
تأكد من توفر [المتطلبات](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) اللازمة واتبع التعليمات المتوفرة لـ:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (موصى به)
- وحدات معالجة الرسومات [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs).
- [معالجات Intel، وحدات معالجة رسومات Intel (مدمجة ومنفصلة)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (صفحة ويكي خارجية)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (صفحة ويكي خارجية)

بدلاً من ذلك، استخدم الخدمات السحابية مثل Google Colab:

- [قائمة الخدمات السحابية](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### التثبيت على Windows 10/11 مع بطاقات NVidia باستخدام حزمة الإصدار
1. حمّل ملف `sd.webui.zip` من [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) واستخرج محتوياته.
2. شغّل `update.bat`.
3. شغّل `run.bat`.
> لمزيد من التفاصيل انظر [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### التثبيت التلقائي على Windows
1. ثبّت [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (الإصدارات الأحدث لا تدعم torch)، وتأكد من تفعيل "Add Python to PATH".
2. ثبّت [git](https://git-scm.com/download/win).
3. حمّل مستودع stable-diffusion-webui، على سبيل المثال عن طريق تنفيذ الأمر:  
   `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`
4. شغّل `webui-user.bat` من مستكشف Windows كمستخدم عادي (ليس كمسؤول).

### التثبيت التلقائي على Linux
1. ثبّت المتطلبات:
```bash
# أنظمة Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# أنظمة Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# أنظمة openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# أنظمة Arch:
sudo pacman -S wget git python3
```
إذا كان نظامك حديثًا جدًا، يجب تثبيت python3.11 أو python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # لا تخلط مع حزمة python3.11

# فقط لـ 3.11
# ثم ضبط متغير البيئة في سكربت التشغيل
export python_cmd="python3.11"
# أو في webui-user.sh
python_cmd="python3.11"
```
2. انتقل إلى الدليل الذي ترغب في تثبيت الواجهة فيه ونفذ الأمر التالي:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
أو فقط قم باستنساخ المستودع في أي مكان تريده:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. شغّل `webui.sh`.
4. تحقق من `webui-user.sh` للخيارات.
### التثبيت على Apple Silicon

ابحث عن التعليمات [هنا](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## المساهمة
كيفية إضافة كود إلى هذا المستودع: [المساهمة](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## التوثيق

تم نقل التوثيق من هذا الملف إلى [ويكي المشروع](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

لأغراض فهرسة Google ومحركات البحث الأخرى للويكي، هذا رابط إلى [الويكي القابل للفهرسة](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## الاعتمادات
تراخيص الأكواد المستعارة يمكن العثور عليها في شاشة `الإعدادات -> التراخيص`، وأيضًا في ملف `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- أفكار للتحسينات - https://github.com/basujindal/stable-diffusion
- تحسين طبقة Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion، الفكرة الأصلية لتحرير الأوامر.
- تحسين طبقة Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (الأصل http://github.com/lstein/stable-diffusion)
- تحسين طبقة Cross Attention شبه رباعية - Alex Birch (https://github.com/Birch-san/diffusers/pull/1)، Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- الانقلاب النصي (Textual Inversion) - Rinon Gal - https://github.com/rinongal/textual_inversion (لا نستخدم كوده، لكننا نستخدم أفكاره).
- فكرة SD upscale - https://github.com/jquesnelle/txt2imghd
- توليد الضوضاء لـ outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- فكرة CLIP interrogator وبعض الكود - https://github.com/pharmapsychotic/clip-interrogator
- فكرة Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - أداة استجواب للأنمي - https://github.com/KichangKim/DeepDanbooru
- التوليد بدقة float32 من UNet بدقة float16 - marunine للفكرة، Birch-san لتطبيق Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- نصائح الأمان - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- إعادة تشغيل التوليد - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- سكربت Gradio الأولي - تم نشره على 4chan بواسطة مستخدم مجهول. شكرًا لك أيها المستخدم المجهول.
- (أنت)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---