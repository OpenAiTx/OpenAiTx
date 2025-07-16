<h1 align="center">ThinkSound</h1>

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
  فإن إضافة نجمة ⭐ على GitHub ستكون محل تقدير كبير!
</p>

---

**ThinkSound** هو إطار موحد لتوليد Any2Audio مع مطابقة التدفق موجهة بواسطة استدلال سلسلة الأفكار (CoT).

تنفيذ PyTorch لتوليد وتحرير الصوت متعدد الوسائط: توليد أو تعديل الصوت من الفيديو أو النص أو الصوت، مدعوم بالاستدلال خطوة بخطوة من نماذج اللغة الكبيرة متعددة الوسائط (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 الأخبار
- **2025.07.15** &nbsp; 📦 تسهيل التثبيت والاستخدام: الاعتماديات متاحة على PyPI لسهولة الإعداد عبر الأنظمة؛ سكريبتات Windows `.bat` لأتمتة إنشاء البيئة وتشغيل السكريبتات.
- **2025.07.08** &nbsp;  🔧 تحديث رئيسي: تم تخفيف النموذج وتحسين استخدام الذاكرة ووحدة معالجة الرسوميات، ويدعم الآن توليد صوت عالي الإنتاجية على نطاق واسع!
- **2025.07.01** &nbsp; 🔥عرض تجريبي مباشر على [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) لتجربة تفاعلية!
- **2025.07.01** &nbsp; 🔥تم إصدار سكريبتات الاستدلال وواجهة الويب؛ 
- **2025.06** &nbsp; 🔥[ورقة ThinkSound](https://arxiv.org/pdf/2506.21448) نُشرت على arXiv!
- **2025.06** &nbsp; 🔥[العرض التوضيحي المباشر](http://thinksound-project.github.io/) متوفر الآن - جربه بنفسك!

---


## 🚀 الميزات

- **Any2Audio**: توليد صوت من أي وسائط — فيديو، نص، صوت، أو أي مزيج منها.
- **أفضل النتائج في تحويل الفيديو إلى صوت**: تحقيق نتائج متقدمة على العديد من معايير V2A.
- **استدلال مدفوع بـ CoT**: سلسلة أفكار للاستدلال من أجل توليد صوت تركيبي وقابل للتحكم عبر MLLMs.
- **تحرير تفاعلي يركز على الكائنات**: تحسين أو تعديل أحداث صوتية محددة بالنقر على الكائنات المرئية أو باستخدام تعليمات نصية.
- **إطار موحد**: نموذج أساسي واحد يدعم التوليد، والتحرير، وسير العمل التفاعلي.

---

## ✨ نظرة عامة على المنهجية

يقوم ThinkSound بتقسيم عملية توليد وتحرير الصوت إلى ثلاث مراحل تفاعلية، جميعها موجهة باستدلال سلسلة الأفكار (CoT) المعتمد على MLLM:

1. **توليد Foley:** توليد مشاهد صوتية أساسية متوافقة دلاليًا وزمنيًا مع الفيديو.
2. **تحسين يركز على الكائنات:** تحسين أو إضافة أصوات لكائنات يحددها المستخدم عبر النقرات أو المناطق في الفيديو.
3. **تحرير الصوت المستهدف:** تعديل الصوت المولد باستخدام تعليمات لغة طبيعية عالية المستوى.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- مجموعة بيانات مشروحة على نطاق واسع بـ CoT (**AudioCoT**) تُستخدم لتدريب كل من وحدة الاستدلال ونموذج الصوت الأساسي الموحد.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ البدء السريع

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
---

## 📝 المهام المستقبلية وخطط العمل
* - [ ] إصدار نصوص تدريب لنماذج ThinkSound (متوقع قبل 20/07/2025)
* - [ ] فتح مصدر مجموعة بيانات AudioCoT وخط الأنابيب الآلي (متوقع قبل 23/07/2025)
* - [ ] توفير صورة بيئة جاهزة للاستخدام (متوقع قبل 23/07/2025)
* - [ ] إصدار نموذج أساسي أكثر قوة يغطي مجالات متعددة لتوفير تجربة إنشاء مؤثرات صوتية أكثر تفاعلية وغنى (متوقع بنهاية أغسطس 2025)
* - [ ] إضافة دعم لأنماط بيانات إضافية ومهام لاحقة (متوقع قبل نهاية يوليو 2025)
* - [ ] إصدار نماذج بأحجام مختلفة (متوقع قبل نهاية يوليو 2025)
* - [x] دليل البدء السريع للمبتدئين على ويندوز
---


## 📄 الترخيص

تم إصدار هذا المشروع بموجب رخصة أباتشي 2.0.

> **ملاحظة:**
> الكود، النماذج، ومجموعة البيانات **لأغراض البحث والتعليم فقط**.
> **الاستخدام التجاري غير مسموح به.**
> للحصول على ترخيص تجاري، يرجى التواصل مع المؤلفين.

**📦 المكونات الخارجية**

* **Stable Audio Open VAE** (بواسطة Stability AI):
  يتضمن هذا المستودع نموذج VAE مدرب بدقة من [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/)، والمرخص بموجب [رخصة مجتمع Stability AI](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **يتطلب الاستخدام التجاري وإعادة التوزيع إذنًا مسبقًا من Stability AI.**

* 📘 **جميع الأكواد والنماذج الأخرى** تم إصدارها بموجب رخصة أباتشي 2.0.

---

## الشكر والتقدير

جزيل الشكر إلى:

* **stable-audio-tools** (بواسطة Stability AI):
لتوفير إطار عمل سهل الاستخدام لتوليد الصوت، بالإضافة إلى وحدة VAE والأوزان الخاصة بها.
* **MMAudio**:
  لتنفيذهم العمود الفقري MM-DiT في مجال الصوتيات.

---

## 📖 الاستشهاد

إذا وجدت ThinkSound مفيدًا في بحثك أو عملك، يرجى الاستشهاد بورقتنا:


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

## 📬 تواصل معنا

✨ لا تتردد في [فتح قضية](https://github.com/liuhuadai/ThinkSound/issues) أو التواصل معنا عبر البريد الإلكتروني ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) إذا كان لديك أي أسئلة أو اقتراحات!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---