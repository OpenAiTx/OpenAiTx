# سينجان (SinGAN)

[المشروع](https://tamarott.github.io/SinGAN.htm) | [أركايف](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [مواد إضافية](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [محاضرة (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191)
### التطبيق الرسمي بـ pytorch للورقة: "سينجان: تعلم نموذج توليدي من صورة طبيعية واحدة"
#### جائزة أفضل ورقة ICCV 2019 (جائزة مار)

## عينات عشوائية من *صورة واحدة*
باستخدام سينجان، يمكنك تدريب نموذج توليدي من صورة طبيعية واحدة، ثم توليد عينات عشوائية من الصورة المُعطاة، على سبيل المثال:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)

## تطبيقات سينجان
يمكن استخدام سينجان أيضًا في مجموعة من مهام معالجة الصور، على سبيل المثال:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
يتم ذلك عن طريق حقن صورة في النموذج المدرب مسبقًا. راجع القسم 4 في [ورقتنا](https://arxiv.org/pdf/1905.01164.pdf) لمزيد من التفاصيل.

### الاقتباس
إذا استخدمت هذا الكود في بحثك، يرجى اقتباس ورقتنا:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## الكود

### تثبيت المتطلبات

```
python -m pip install -r requirements.txt
```

تم اختبار هذا الكود مع بايثون 3.6، وتورش 1.4

يرجى الملاحظة: الكود يدعم حاليًا تورش 1.4 أو أقدم فقط بسبب نظام التحسين المستخدم.

لإصدارات تورش الأحدث، يمكنك تجربة هذا المستودع: https://github.com/kligvasser/SinGAN (قد لا تكون النتائج متطابقة مع التطبيق الرسمي).

### التدريب
لتدريب نموذج سينجان على صورتك الخاصة، ضع صورة التدريب المطلوبة تحت Input/Images، ثم نفذ

```
python main_train.py --input_name <input_file_name>
```

سيقوم ذلك أيضًا باستخدام النموذج المدرب الناتج لتوليد عينات عشوائية بدءًا من أوسع مقياس (n=0).

لتشغيل هذا الكود على جهاز بدون وحدة معالجة رسومات، حدد `--not_cuda` عند استدعاء `main_train.py`

### عينات عشوائية
لتوليد عينات عشوائية من أي مقياس توليدي ابتدائي، يجب أولاً تدريب نموذج سينجان على الصورة المطلوبة (كما هو موضح أعلاه)، ثم نفذ

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

تنبيه: لاستخدام النموذج الكامل، حدد مقياس بدء التوليد بـ 0، وللبدء من المقياس الثاني، حدده 1، وهكذا.

### عينات عشوائية بأحجام عشوائية
لتوليد عينات عشوائية بأحجام عشوائية، يجب أولاً تدريب نموذج سينجان على الصورة المطلوبة (كما هو موضح أعلاه)، ثم نفذ

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

### تحريك صورة واحدة

لتوليد تحريك قصير من صورة واحدة، نفذ

```
python animation.py --input_name <input_file_name> 
```

سيبدأ ذلك تلقائيًا مرحلة تدريب جديدة بوضع حشو الضوضاء.

### التناسق اللوني (Harmonization)

لمواءمة كائن ملصق مع صورة (انظر المثال في الشكل 13 في [ورقتنا](https://arxiv.org/pdf/1905.01164.pdf))، يرجى أولاً تدريب نموذج سينجان على صورة الخلفية المطلوبة (كما هو موضح أعلاه)، ثم احفظ صورة المرجع الملصقة ببساطة وقناعها الثنائي تحت "Input/Harmonization" (انظر الصور المحفوظة كمثال). نفذ الأمر

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

يرجى الملاحظة أن مقياس الحقن المختلف سينتج تأثيرات تناسق مختلفة. أوسع مقياس حقن يساوي 1.

### التحرير

لتحرير صورة (انظر المثال في الشكل 12 في [ورقتنا](https://arxiv.org/pdf/1905.01164.pdf))، يرجى أولاً تدريب نموذج سينجان على الصورة غير المعدلة المطلوبة (كما هو موضح أعلاه)، ثم احفظ التعديل البسيط كصورة مرجعية تحت "Input/Editing" مع خريطة ثنائية مقابلة (انظر الصور المحفوظة كمثال). نفذ الأمر

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
```
سيتم حفظ كل من المخرجات المقنعة وغير المقنعة.
هنا أيضًا، سيؤدي استخدام مقياس حقن مختلف إلى إنتاج تأثيرات تحرير مختلفة. أكبر مقياس حقن يساوي 1.

###  التحويل من رسم إلى صورة

لنقل رسم إلى صورة واقعية (انظر المثال في الشكل 11 في [ورقتنا البحثية](https://arxiv.org/pdf/1905.01164.pdf))، يرجى أولًا تدريب نموذج SinGAN على الصورة المطلوبة (كما هو موضح أعلاه)، ثم احفظ الرسم الخاص بك تحت "Input/Paint"، وقم بتشغيل الأمر التالي

```
python paint2image.py --input_name <اسم ملف صورة التدريب> --ref_name <اسم ملف صورة الرسم> --paint_start_scale <مقياس الحقن>
```
هنا أيضًا، سيؤدي استخدام مقياس حقن مختلف إلى إنتاج تأثيرات تحرير مختلفة. أكبر مقياس حقن يساوي 1.

خيار متقدم: حدد quantization_flag ليكون True، لإعادة تدريب *مستوى الحقن فقط* من النموذج، للحصول على نسخة بكمية ألوان محددة من الصور المولدة والمكبّرة من المقياس السابق. بالنسبة لبعض الصور، قد يؤدي ذلك إلى نتائج أكثر واقعية.

### رفع الدقة الفائقة (Super Resolution)
لرفع دقة صورة، يرجى تشغيل:
```
python SR.py --input_name <اسم ملف الصورة منخفضة الدقة>
```
سيقوم هذا تلقائيًا بتدريب نموذج SinGAN ليوافق عامل تكبير 4x (إذا لم يكن موجودًا بالفعل).
لعوامل تكبير أخرى، يرجى تحديد ذلك باستخدام المعامل `--sr_factor` عند استدعاء الدالة.
يمكن تحميل نتائج SinGAN على مجموعة بيانات BSD100 من مجلد 'Downloads'.

## بيانات ووظائف إضافية

### مسافة فريشيت لصور مفردة (SIFID score)
لحساب SIFID بين الصور الحقيقية وعينات الصور المزيفة المقابلة لها، يرجى تشغيل:
```
python SIFID/sifid_score.py --path2real <مسار الصور الحقيقية> --path2fake <مسار الصور المزيفة>
```  
تأكد من أن اسم ملف كل صورة مزيفة مطابق لاسم ملف صورتها الحقيقية المقابلة. يجب حفظ الصور بصيغة `.jpg`.

### نتائج رفع الدقة الفائقة
يمكن تحميل نتائج رفع الدقة الفائقة (SR) الخاصة بـ SinGAN على مجموعة بيانات BSD100 من مجلد 'Downloads'.

### دراسة المستخدم
يمكن العثور على البيانات المستخدمة في دراسة المستخدم في مجلد Downloads.

مجلد real: 50 صورة حقيقية، تم اختيارها عشوائيًا من [قاعدة بيانات الأماكن](http://places.csail.mit.edu/)

مجلد fake_high_variance: عينات عشوائية بدءًا من n=N لكل من الصور الحقيقية

مجلد fake_mid_variance: عينات عشوائية بدءًا من n=N-1 لكل من الصور الحقيقية

لمزيد من التفاصيل يرجى مراجعة القسم 3.1 في [ورقتنا البحثية](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---