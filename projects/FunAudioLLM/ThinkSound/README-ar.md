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
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
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
  فإن وضع نجمة ⭐ على GitHub سيكون محل تقدير كبير!
</p>

---

## هيكلية المستودع
يستضيف مستودع **ThinkSound** على GitHub مشروعين مرتبطين على فرعين منفصلين:

| الفرع | المشروع | التوثيق |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — توليد Any2Audio موحد مع مطابقة تدفق موجهة بواسطة التفكير التسلسلي (CoT) | هذا الملف: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — عمل لاحق (ICLR 2026) لتحويل الفيديو إلى صوت باستخدام CoT-RL متعدد الأبعاد | **`README.md`** على فرع [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) |

بالنسبة لـ **ThinkSound**، استخدم فرع **`master`** (هذا الملف README). بالنسبة لـ **PrismAudio**، انتقل إلى **`prismaudio`** واتبع **`README.md`** هناك.

---

**ThinkSound** هو إطار موحد لتوليد Any2Audio مع مطابقة تدفق موجهة بواسطة التفكير التسلسلي (CoT).

تنفيذ PyTorch لتوليد وتحرير الصوت متعدد الوسائط: توليد أو تحرير الصوت من الفيديو أو النص أو الصوت، مدعوم بالتفكير خطوة بخطوة من نماذج اللغة الكبيرة متعددة الوسائط (MLLMs).

![عرض توضيحي](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 الأخبار
- **2026.03.24** &nbsp; 🔥 تم إصدار **PrismAudio** في نفس المستودع على فرع [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) — راجع **`README.md`** هناك للإعداد والنماذج.
- **2026.01.26** &nbsp; 🎉 تم قبول PrismAudio في **المؤتمر الرئيسي ICLR 2026** (الشفرة/الوثائق على `prismaudio`).
- **2025.11.25** &nbsp; 🔥 [عرض PrismAudio التجريبي عبر الإنترنت](http://prismaudio-project.github.io/) أصبح متاحاً.
- **2025.11.25** &nbsp; 🔥 [ورقة PrismAudio](https://arxiv.org/pdf/2511.18833) على arXiv — CoT-RL متعدد الأبعاد لتحويل الفيديو إلى صوت.
- **2025.09.19** &nbsp; 🎉 تم قبول **ThinkSound** في **المؤتمر الرئيسي NeurIPS 2025**!
- **2025.09.01** &nbsp; تم فتح مصدر مجموعة بيانات AudioCoT وهي متاحة الآن على [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)!
- **2025.07.17** &nbsp; 🧠 تمكين التخصيص: كود التدريب والتخصيص متاح الآن للجمهور مع تعليمات واضحة لمساعدتك على تخصيص وتوسيع ThinkSound ببياناتك الخاصة.
- **2025.07.15** &nbsp; 📦 التثبيت والاستخدام أصبح أسهل: الاعتماديات متوفرة على PyPI لإعداد سهل عبر الأنظمة؛ نصوص `.bat` للويندوز لأتمتة إنشاء البيئة وتشغيل السكريبتات.
- **2025.07.08** &nbsp;  🔧 تحديث رئيسي: تم تخفيف وزن النموذج وتحسين استهلاك الذاكرة وGPU، ويدعم الآن توليد صوتي عالي الإنتاجية على نطاق واسع!
- **2025.07.01** &nbsp; عرض تجريبي عبر الإنترنت على [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و[ModelScope](https://modelscope.cn/studios/iic/ThinkSound) لتجربة تفاعلية!
- **2025.07.01** &nbsp; تم إصدار سكريبتات الاستدلال وواجهة الويب؛ 
- **2025.06** &nbsp; تم إصدار [ورقة ThinkSound](https://arxiv.org/pdf/2506.21448) على arXiv!
- **2025.06** &nbsp; [العرض التجريبي عبر الإنترنت](http://thinksound-project.github.io/) متاح الآن - جربه الآن!

---


<div align="center">

### المتابعة: PrismAudio (نفس المستودع، فرع `prismaudio`)


**PrismAudio** هو الجيل التالي من ThinkSound (ICLR 2026)، تم تطويره تحت اسم جديد ولكن تم الاحتفاظ به في هذا المستودع على الفرع **`prismaudio`**. التثبيت، نقاط التحقق، والاستشهاد العلمي موجودة في **[`README.md` على ذلك الفرع](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**.

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) أو افتح الفرع على GitHub.

</div>

---


## 🚀 الميزات

- **Any2Audio**: توليد الصوت من أي وسائط — فيديو، نص، صوت، أو مزيج منها.
- **أفضل أداء في تحويل الفيديو إلى صوت**: يحقق نتائج متقدمة على عدة معايير فيديو إلى صوت (V2A).
- **الاستدلال القائم على سلسلة الأفكار (CoT)**: استدلال سلسلة الأفكار لتوليد صوت تركيبي وقابل للتحكم عبر MLLMs.
- **تحرير تفاعلي مركز على الكائنات**: تحسين أو تعديل أحداث صوتية محددة بالنقر على كائنات بصرية أو باستخدام تعليمات نصية.
- **إطار موحد**: نموذج أساس واحد يدعم التوليد، التحرير، وسير العمل التفاعلي.

---

## ✨ نظرة عامة على الطريقة

يقوم ThinkSound بتقسيم عملية توليد وتحرير الصوت إلى ثلاث مراحل تفاعلية، جميعها موجهة باستدلال سلسلة الأفكار (CoT) القائم على MLLM:

1. **توليد Foley:** توليد خلفيات صوتية أساسية متوافقة دلاليًا وزمنيًا من الفيديو.
2. **التحسين المركز على الكائن:** تحسين أو إضافة أصوات لكائنات يحددها المستخدم عبر النقر أو تحديد مناطق في الفيديو.
3. **تحرير الصوت المستهدف:** تعديل الصوت الناتج باستخدام تعليمات لغوية طبيعية عالية المستوى.

![نظرة عامة على ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- يتم استخدام مجموعة بيانات مشروحة على نطاق واسع بسلسلة الأفكار (**AudioCoT**) لتدريب كل من وحدة الاستدلال ونموذج الصوت الأساسي الموحد.
![مخطط AudioCoT](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ البدء السريع

**تحضير البيئة:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
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


## 📄 الرخصة

تم إصدار هذا المشروع بموجب رخصة أباتشي 2.0.

> **ملاحظة:**
> الكود والنماذج ومجموعة البيانات **لأغراض البحث والتعليم فقط**.
> **الاستخدام التجاري غير مسموح به.**
> للحصول على ترخيص تجاري، يرجى التواصل مع المؤلفين.

**📦 المكونات الخارجية**

* **Stable Audio Open VAE** (من تطوير Stability AI):
  يحتوي هذا المستودع على VAE تم تدريبه من [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/)، بموجب [رخصة مجتمع Stability AI](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md).
  **الاستخدام التجاري وإعادة التوزيع يتطلبان إذنًا مسبقًا من Stability AI.**

* 📘 **جميع الشفرات والنماذج الأخرى** تم إصدارها بموجب رخصة أباتشي 2.0.

---

## الشكر والتقدير

شكر خاص إلى:

* **stable-audio-tools** (من Stability AI):
  لتوفير إطار عمل سهل الاستخدام لتوليد الصوت، بالإضافة إلى وحدة VAE والأوزان.
* **MMAudio**:
  لتنفيذ العمود الفقري لـ MM-DiT في مجال الصوت.

---


## 📖 الاستشهاد

إذا وجدت مشروعنا مفيدًا في بحثك أو عملك، يرجى الاستشهاد بورقتنا البحثية:

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
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---