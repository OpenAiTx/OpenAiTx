# 🎶 ThinkSound

<p align="center">
  إذا وجدت هذا المشروع مفيدًا، فإن إضافة نجمة ⭐ على GitHub ستكون محل تقدير كبير!
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

---

**ThinkSound** هو إطار موحد لتوليد الصوت من أي مدخل (Any2Audio) مع توجيه مطابقة التدفق (flow matching) بواسطة التفكير المتسلسل (Chain-of-Thought - CoT).

تنفيذ PyTorch لتوليد وتحرير الصوت متعدد الوسائط: توليد أو تعديل الصوت من الفيديو أو النص أو الصوت، مدعومًا بالتفكير خطوة بخطوة من النماذج اللغوية الكبيرة متعددة الوسائط (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 الأخبار
- **2025.07** &nbsp; 🔥 تجربة تفاعلية متاحة الآن على [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) و [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)!
- **2025.07** &nbsp; 🔥 تم إصدار سكريبتات الاستدلال وواجهة الويب؛
- **2025.06** &nbsp; 🔥 تم نشر [ورقة ThinkSound](https://arxiv.org/pdf/2506.21448) على arXiv!
- **2025.06** &nbsp; 🔥 [العرض التوضيحي عبر الإنترنت](http://thinksound-project.github.io/) أصبح متاحًا - جربه الآن!

---

## 🚀 الميزات

- **Any2Audio**: توليد الصوت من أي نوع من المدخلات — فيديو أو نص أو صوت أو أي مجموعة منها.
- **أفضل أداء تحويل فيديو إلى صوت**: يحقق نتائج رائدة على العديد من اختبارات تحويل الفيديو إلى صوت (V2A).
- **التفكير المتسلسل (CoT-Driven Reasoning)**: توليد صوت تركيبي وقابل للتحكم من خلال التفكير المتسلسل بواسطة النماذج اللغوية الكبيرة متعددة الوسائط (MLLMs).
- **تعديل تفاعلي يركز على الكائنات**: تحسين أو تعديل أحداث صوتية محددة من خلال النقر على الكائنات المرئية أو باستخدام تعليمات نصية.
- **إطار موحد**: نموذج أساسي واحد يدعم التوليد والتعديل والعمل التفاعلي.

---

## ✨ نظرة عامة على المنهجية

يقوم ThinkSound بتقسيم عملية توليد وتحرير الصوت إلى ثلاث مراحل تفاعلية، جميعها موجهة بواسطة التفكير المتسلسل (CoT) المستند إلى MLLM:

1. **توليد Foley:** توليد مشاهد صوتية أساسية متوافقة دلاليًا وزمنيًا مع الفيديو.
2. **تحسين يركز على الكائنات:** تحسين أو إضافة أصوات لكائنات يحددها المستخدم عبر النقر أو تحديد مناطق في الفيديو.
3. **تحرير صوتي موجه:** تعديل الصوت المولد باستخدام تعليمات لغوية طبيعية عالية المستوى.

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- يتم استخدام مجموعة بيانات واسعة النطاق مشروحة بالتفكير المتسلسل (**AudioCoT**) لتدريب كل من وحدة التفكير والنموذج الصوتي الموحد.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ البدء السريع

**تحضير البيئة:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# قم بتنزيل الأوزان المدربة مسبقًا من https://huggingface.co/liuhuadai/ThinkSound إلى مجلد ckpts/
# يمكن أيضًا تنزيل أوزان النموذج من https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**اجعل الملف قابلًا للتنفيذ**
```bash
chmod +x scripts/demo.sh
```

**تشغيل السكريبت**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### استخدام واجهة الويب

لتجربة تفاعلية، قم بتشغيل واجهة Gradio على الويب:

```bash
python app.py
```

---
## 📝 المهام

- ☐ إصدار نصوص التدريب لنماذج ThinkSound
- ☐ إتاحة مجموعة بيانات AudioCoT وخط الأنابيب المؤتمت كمصدر مفتوح
- ☐ توفير توثيق مفصل ومرجع API
- ☐ إضافة دعم لأنماط بيانات ومهام نهائية إضافية

---

## 📄 الرخصة

تم إصدار هذا المشروع بموجب [رخصة أباتشي 2.0](LICENSE).

> **ملاحظة:**  
> الكود والنماذج ومجموعة البيانات هي **لأغراض البحث والتعليم فقط**.  
> **الاستخدام التجاري غير مسموح.**
>
> للحصول على ترخيص تجاري، يرجى التواصل مع المؤلفين.

---

## 📖 الاقتباس

إذا وجدت ThinkSound مفيدًا في أبحاثك أو عملك، يرجى الاستشهاد بورقتنا:

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

## 📬 التواصل

✨ لا تتردد في [فتح قضية](https://github.com/liuhuadai/ThinkSound/issues) أو التواصل معنا عبر البريد الإلكتروني ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) إذا كان لديك أي أسئلة أو اقتراحات!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---