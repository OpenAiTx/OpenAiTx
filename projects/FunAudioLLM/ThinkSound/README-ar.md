<h1 align="center">ثينك ساوند</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  إذا وجدت هذا المشروع مفيدًا،<br>
  سيكون من الرائع وضع نجمة ⭐ على GitHub!
</p>

---

**ثينك ساوند** هو إطار موحد لتوليد الصوت من أي مدخلات (Any2Audio) باستخدام مطابقة التدفق الموجهة بواسطة استدلال سلسلة الأفكار (CoT).
تنفيذ PyTorch لتوليد وتحرير الصوت متعدد الوسائط: توليد أو تحرير الصوت من الفيديو أو النص أو الصوت، مدعوم بخطوات تفكير متسلسلة من نماذج اللغة الكبيرة متعددة الوسائط (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 الأخبار
- **2025.11.25** &nbsp; 🔥[عرض PrismAudio التجريبي المباشر](http://prismaudio-project.github.io/) متوفر الآن - جربه الآن!
- **2025.11.25** &nbsp; 🔥[ورقة PrismAudio](https://arxiv.org/pdf/2511.18833) صدرت على arXiv، أول إطار CoT-RL متعدد الأبعاد لتوليد الصوت من الفيديو!
- **2025.09.19** &nbsp; 🎉 تم قبول ThinkSound في **المؤتمر الرئيسي NeurIPS 2025**!
- **2025.09.01** &nbsp; مجموعة بيانات AudioCoT مفتوحة المصدر ومتاحة الآن على [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 تفعيل التخصيص: الشيفرات الخاصة بالتدريب والتخصيص متاحة الآن مع تعليمات واضحة لمساعدتك على تخصيص وتوسيع ThinkSound ببياناتك الخاصة.
- **2025.07.15** &nbsp; 📦 تبسيط التثبيت وسهولة الاستخدام: الاعتماديات متوفرة على PyPI لإعداد عبر الأنظمة بسهولة؛ سكريبتات Windows `.bat` لأتمتة إنشاء البيئة وتشغيل السكريبتات.
- **2025.07.08** &nbsp;  🔧 تحديث رئيسي: تم تخفيف وزن النموذج وتحسين استخدام الذاكرة ومعالج الرسوميات، يدعم الآن توليد صوت عالي الإنتاجية على نطاق واسع!
- **2025.07.01** &nbsp; عرض تجريبي مباشر على [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) لتجربة تفاعلية!
- **2025.07.01** &nbsp; إصدار سكريبتات الاستدلال وواجهة الويب؛ 
- **2025.06** &nbsp; [ورقة ThinkSound](https://arxiv.org/pdf/2506.21448) صدرت على arXiv!
- **2025.06** &nbsp; [العرض التجريبي المباشر](http://thinksound-project.github.io/) متوفر الآن - جربه الآن!

---


## 🚀 الميزات

- **Any2Audio**: توليد الصوت من أي نوع من الوسائط — فيديو أو نص أو صوت أو مزيج منها.
- **الريادة في تحويل الفيديو إلى صوت**: يحقق نتائج متقدمة على العديد من معايير V2A.
- **تفكير مدفوع بسلسلة التفكير**: توليد صوت تركيبي وتحكمي مدفوع بسلسلة التفكير عبر MLLMs.
- **تحرير تفاعلي مركز على الكائنات**: تنقيح أو تحرير أحداث صوتية محددة بالنقر على كائنات مرئية أو باستخدام تعليمات نصية.
- **إطار موحد**: نموذج أساسي واحد يدعم التوليد والتحرير وسير العمل التفاعلي.

---

## ✨ نظرة عامة على الطريقة

يقوم ThinkSound بتقسيم توليد وتحرير الصوت إلى ثلاث مراحل تفاعلية، جميعها موجهة بتفكير سلسلة التفكير المعتمد على MLLM:

1. **توليد Foley:** إنشاء مشاهد صوتية أساسية متوافقة دلالياً وزمنياً مع الفيديو.
2. **تنقيح مركز على الكائنات:** تنقيح أو إضافة أصوات لكائنات يحددها المستخدم عبر النقر أو تحديد مناطق في الفيديو.
3. **تحرير صوتي موجه:** تعديل الصوت الناتج باستخدام تعليمات لغة طبيعية عالية المستوى.


![نظرة عامة على ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- يتم استخدام مجموعة بيانات كبيرة الحجم مشروحة بطريقة السلسلة الفكرية (**AudioCoT**) لتدريب كل من وحدة الاستدلال ونموذج الأساس الموحد للصوت.
![مسار عمل AudioCoT](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ البداية السريعة

**تحضير البيئة:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **نصيحة لمستخدمي ويندوز:**  
> يمكن لمستخدمي ويندوز ببساطة تشغيل `setup_windows.bat` (أو النقر المزدوج عليه) لإنشاء بيئة conda تلقائيًا، وتثبيت جميع التبعيات (بما في ذلك FFmpeg)، وتنزيل النموذج المدرب مسبقًا — دون الحاجة للإعداد اليدوي.  
> تأكد من أن `conda` و `git` مثبتان ومتوفران في متغير PATH الخاص بالنظام قبل تشغيل السكربت.


### ▶️ تشغيل العرض التجريبي

#### **لينكس/ماكOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **ويندوز**

يمكنك بدلاً من ذلك استخدام البرنامج النصي `.bat` المرفق:


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**ملاحظة:**

* `<مسار-فيديو-العرض-التوضيحي-الخاص-بك>`: مسار فيديو واحد
* `[use-half]` (اختياري): أضف use-half في النهاية لتفعيل استخراج الميزات بدقة نصفية.

---

### 📦 الاستدلال على دفعات

#### **لينكس/ماك أو إس**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **ويندوز**

استخدم سكربت `.bat` المكافئ:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**ملاحظة:**

* `<video_path>`: مسار الدليل الجذري الذي يحتوي على جميع ملفات الفيديو .mp4 المراد معالجتها (يجب أن تكون جميع الفيديوهات بنفس المدة).
* `<csv_path>`: ملف CSV يحتوي على مطالبات نصية لكل فيديو (انظر `demo_test.csv` لمعرفة التنسيق).
* `<save_path>` (اختياري): مكان حفظ الصوت الناتج. الافتراضي هو `results/features`.
* `[use-half]` (اختياري): أضف use-half في النهاية لتمكين استخراج الميزات بنصف الدقة.

---


### استخدام الواجهة الويب

للحصول على تجربة تفاعلية، قم بتشغيل واجهة Gradio على الويب:


```bash
python app.py
```


## 🏋️ تدريب النموذج

راجع [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 المهام المستقبلية وخطط العمل
* - [ ] إصدار نموذج أساسي أكثر قوة يغطي مجالات متعددة لتوفير إنشاء فولي أكثر جاذبية وانغماسًا
* - [ ] إضافة دعم لأنماط إضافية ومهام لاحقة
* - [ ] إصدار نماذج بمقاييس مختلفة
* - [x] فتح مصدر مجموعة بيانات AudioCoT وخط الأنابيب المؤتمت
* - [x] إصدار نصوص التدريب لنماذج ThinkSound
* - [x] ملف README للبدء السريع في ويندوز للمبتدئين
---


## 📄 الترخيص

تم إصدار هذا المشروع بموجب ترخيص أباتشي 2.0.

> **ملاحظة:**
> الكود، النماذج، ومجموعة البيانات **لأغراض البحث والتعليم فقط**.
> **الاستخدام التجاري غير مسموح به.**
> للحصول على ترخيص تجاري، يرجى التواصل مع المؤلفين.

**📦 المكونات الخارجية**

* **Stable Audio Open VAE** (بواسطة Stability AI):
  يتضمن هذا المستودع نموذج VAE مضبوط بدقة من [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/)، ومرخص بموجب [ترخيص مجتمع Stability AI](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **الاستخدام التجاري وإعادة التوزيع يتطلبان إذنًا مسبقًا من Stability AI.**

* 📘 **جميع الكودات والنماذج الأخرى** تم إصدارها بموجب ترخيص أباتشي 2.0.

---

## الشكر والتقدير

شكراً جزيلاً لـ:

* **stable-audio-tools** (من قبل Stability AI):
لتوفير إطار عمل سهل الاستخدام لتوليد الصوت، بالإضافة إلى وحدة VAE والأوزان.
* **MMAudio**:
  لتنفيذ العمود الفقري MM-DiT في مجال الصوت.

---

## 📖 الاقتباس

إذا وجدت ThinkSound مفيداً في بحثك أو عملك، يرجى اقتباس ورقتنا:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-07

---