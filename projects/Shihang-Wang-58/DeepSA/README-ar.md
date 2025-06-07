[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: متنبئ بإمكانية تخليق المركبات مدعوم بالتعلم العميق

مع التطور المستمر لتقنيات الذكاء الاصطناعي، يتم استخدام المزيد من نماذج التوليد العميق لتوليد الجزيئات. ومع ذلك، غالبًا ما تواجه معظم الجزيئات الجديدة التي يتم توليدها بواسطة نماذج التوليد تحديات كبيرة من حيث إمكانية التخليق.

تم اقتراح DeepSA للتنبؤ بإمكانية تخليق المركبات، ويتميز بمعدل إثراء مبكر أعلى بكثير في التمييز بين الجزيئات التي يصعب تخليقها. يساعد ذلك المستخدمين في اختيار جزيئات أقل تكلفة للتخليق، مما يقلل من وقت اكتشاف وتطوير الأدوية. يمكنك استخدام DeepSA على الخادم الإلكتروني عبر الرابط https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## المتطلبات
يمكن تثبيت التبعيات باستخدام الأمر التالي:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# لإصدار وحدة معالجة الرسومات
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### أخبار 🔔 

* 2024-12، نظرًا لأن [AutoGluon أوقفت دعم إصدار بايثون 3.8](https://github.com/autogluon/autogluon/pull/4512) بدءًا من أكتوبر 2024. لذلك، قمنا بتحديث DeepSA لاستخدام إصدار بايثون 3.12 وقمنا بتحديث سكريبتات التدريب والاستدلال لتتوافق مع أحدث إصدار من AutoGluon. شكرًا لاهتمامكم بـ DeepSA!

* 2023-7، تم إصدار DeepSA_v1.0، نرحب بتقديم الملاحظات على المشاكل!

## البيانات
يمكنك بسهولة تحميل مجموعات بيانات التدريب والاختبار الموسعة من الرابط: https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## الاستخدام للباحثين
إذا كنت ترغب في تدريب نموذجك الخاص، يمكنك تشغيله من سطر الأوامر،

التشغيل:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
إذا كنت ترغب في استخدام النموذج الذي اقترحناه،

التشغيل:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## الخادم الإلكتروني

قمنا بنشر نموذج مدرب مسبقًا على خادم مخصص، وهو متاح للجميع على الرابط https://bailab.siais.shanghaitech.edu.cn/deepsa، لتسهيل استخدام الباحثين في مجال الطب الحيوي لـ DeepSA في أنشطتهم البحثية.

يمكن للمستخدمين رفع ملفات SMILES أو ملفات csv إلى الخادم، ومن ثم يمكنهم الحصول بسرعة على النتائج المتوقعة.

## <span id="citelink">الاستشهاد</span>
إذا وجدت هذا المستودع مفيدًا في بحثك، يرجى الاستشهاد بورقتنا العلمية:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## التواصل
إذا كان لديك أي أسئلة، لا تتردد في التواصل مع شيهانغ وانغ (البريد الإلكتروني: wangshh12022@shanghaitech.edu.cn) أو لين وانغ (البريد الإلكتروني: wanglin3@shanghaitech.edu.cn).

طلبات السحب مرحب بها للغاية!

## الشكر والتقدير
نحن ممتنون للدعم المقدم من منصة الحوسبة عالية الأداء بجامعة شنغهاي للتكنولوجيا.<br/>
شكرًا لكم جميعًا على اهتمامكم بهذا العمل.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---