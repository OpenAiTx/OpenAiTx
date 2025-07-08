# EX-4D: توليد فيديو رباعي الأبعاد بوجهات نظر متطرفة عبر شبكة مغلقة بالمجسمات ثلاثية الأبعاد

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="شعار EX-4D" width="250">

[📄 الورقة العلمية](https://arxiv.org/abs/2506.05554)  |  [🎥 الصفحة الرئيسية](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 الكود](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 المميزات

- **🎯 توليد بوجهات نظر متطرفة**: إنشاء فيديوهات رباعية الأبعاد عالية الجودة مع حركات كاميرا تتراوح من -90° إلى 90°
- **🔧 شبكة مغلقة بالمجسمات ثلاثية الأبعاد عبر العمق**: تمثيل هندسي مبتكر يقوم بنمذجة المناطق المرئية والمخفية معًا
- **⚡ بنية خفيفة الوزن**: فقط 1% من المعاملات القابلة للتدريب (140 مليون) مقارنةً بعمود الانتشار للفيديو بحجم 14 مليار
- **🎭 بدون تدريب متعدد الزوايا**: استراتيجية إخفاء مبتكرة تلغي الحاجة لمجموعات بيانات متعددة الزوايا المكلفة
- **🏆 أداء رائد**: يتفوق على الأساليب الحالية، خاصة عند زوايا الكاميرا المتطرفة

## 🎬 نتائج العرض التجريبي

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="نتائج العرض التجريبي لـ EX-4D" width="800">
</div>

*يقوم EX-4D بتحويل الفيديوهات أحادية العدسة إلى تجارب رباعية الأبعاد يمكن التحكم بالكاميرا فيها مع نتائج متسقة فيزيائيًا حتى في وجهات النظر المتطرفة.*

## 🏗️ نظرة عامة على الإطار

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="معمارية EX-4D">
</div>

يتكون إطار العمل لدينا من ثلاثة مكونات رئيسية:

1. **🔺 بناء شبكة مغلقة بالمجسمات ثلاثية الأبعاد عبر العمق**: ينشئ أساسًا هندسيًا قويًا يقوم بنمذجة المناطق المرئية والمخفية بشكل صريح
2. **🎭 استراتيجية إخفاء محاكاة**: تولد بيانات تدريب فعالة من فيديوهات أحادية العدسة دون الحاجة لمجموعات بيانات متعددة الزوايا
3. **⚙️ محول LoRA خفيف الوزن**: يدمج المعلومات الهندسية بكفاءة مع نماذج الانتشار المدربة مسبقًا للفيديو

## 🚀 بداية سريعة

### التثبيت

```bash
# استنساخ المستودع
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# إنشاء بيئة conda
conda create -n ex4d python=3.10
conda activate ex4d
# تثبيت PyTorch (يوصى بالإصدار 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# تثبيت Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# تثبيت التبعيات و diffsynth
pip install -e .
# تثبيت depthcrafter لتقدير العمق. (اتبع تعليمات DepthCrafter لإعداد نقاط التحقق.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### تحميل النموذج المدرب مسبقًا
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### مثال على الاستخدام
#### 1. إعادة بناء شبكة DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. توليد EX-4D (مطلوب 48GB VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>فيديو الإدخال</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>فيديو الإخراج</b>
</td>
</tr> 
</table>

<!-- ## 📊 الأداء

### النتائج الكمية
| الطريقة | FID (أقصى) ↓ | FVD (أقصى) ↓ | درجة VBench ↑ |
|---------|--------------|--------------|---------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (الخاص بنا)** | **55.42** | **823.61** | **0.450** | -->

### نتائج دراسة المستخدمين

- **70.7%** من المشاركين فضلوا EX-4D على الطرق الأساسية
- أداء متفوق في التناسق الفيزيائي وجودة وجهات النظر القصوى
- تحسن ملحوظ مع زيادة حدة زوايا الكاميرا

## 🎯 التطبيقات

- **🎮 الألعاب**: إنشاء مشاهد سينمائية ثلاثية الأبعاد غامرة من لقطات ثنائية الأبعاد
- **🎬 إنتاج الأفلام**: توليد زوايا كاميرا جديدة لمرحلة ما بعد الإنتاج
- **🥽 الواقع الافتراضي/المعزز**: إنشاء تجارب فيديو من وجهات نظر حرة
- **📱 وسائل التواصل الاجتماعي**: إنتاج حركات كاميرا ديناميكية لصناعة المحتوى
- **🏢 العمارة**: تصور المساحات من وجهات نظر متعددة

<!-- ## 📈 المعايير -->

<!-- ### تقييم نطاق وجهات النظر

| النطاق | صغير (0°→30°) | كبير (0°→60°) | أقصى (0°→90°) | كامل (-90°→90°) |
|--------|---------------|---------------|----------------|-----------------|
| درجة FID | 44.19 | 50.30 | 55.42 | - |
| فجوة الأداء | +9.1% أفضل | +8.9% أفضل | +11.3% أفضل | +15.5% أفضل | -->

<!-- *فجوة الأداء مقارنة مع ثاني أفضل طريقة في كل فئة.* -->

## ⚠️ القيود

- **الاعتماد على العمق**: يعتمد الأداء على جودة تقدير العمق الأحادي
- **التكلفة الحسابية**: يتطلب حسابات كبيرة لمقاطع الفيديو عالية الدقة
- **الأسطح العاكسة**: توجد تحديات مع المواد العاكسة أو الشفافة

## 🔮 العمل المستقبلي
- [ ] تحسين الاستدلال في الوقت الحقيقي (3DGS / 4DGS)
- [ ] دعم دقات أعلى (1K، 2K)
- [ ] تقنيات تحسين الشبكة العصبية

## 🙏 الشكر والتقدير

نود أن نشكر مشروع [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) لتوفيره إطار الانتشار الأساسي.

## 📚 الاستشهاد

إذا وجدت عملنا مفيدًا، يرجى الاستشهاد به على النحو التالي:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---