<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# سن لوجيك (SynLogic)

يحتوي هذا المستودع على الشيفرة والبيانات الخاصة بـ SynLogic، وهو إطار شامل لتوليد بيانات الاستدلال المنطقي يقوم بإنتاج بيانات استدلال متنوعة وقابلة للتحقق على نطاق واسع. يعالج عملنا الفجوة الحرجة في بيانات تدريب الاستدلال المنطقي عالية الجودة لتطوير قدرات الاستدلال العامة في نماذج اللغة الكبيرة (LLMs).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## الأخبار
- **[2025/07/07]** :fire: نوفر إرشادات لاستخدام بيانات SynLogic لإجراء تدريب التعلم المعزز (RL) باستخدام إطار Verl. راجع [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) لمزيد من التفاصيل. 

- **[2025/06/03]** :fire: تم إصدار النماذج المدربة على Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: يسعدنا إصدار الموارد الخاصة بالورقة العلمية "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 نظرة عامة

**SynLogic** هو إطار لتوليد البيانات ومجموعة بيانات شاملة تهدف إلى:
- 📊 **تغطية 35 مهمة استدلال منطقي متنوعة** تشمل سودوكو، لعبة 24، الشيفرة، متاهة الأسهم، والمزيد
- 🎯 **تمكين توليد بيانات بصعوبة قابلة للتحكم** مع معلمات قابلة للتعديل لكل مهمة
- ✅ **توفير مكافآت قابلة للتحقق** عبر التحقق القائم على القواعد لتدريب التعلم المعزز
- 🚀 **تحقيق أداء رائد (SOTA)** بين مجموعات البيانات مفتوحة المصدر، متفوقًا على DeepSeek-R1-Distill-Qwen-32B بست نقاط على BBEH

### الميزات الرئيسية
- **توليد بيانات قابل للتوسع**: توليد غير محدود مع مستويات صعوبة قابلة للتحكم
- **تغطية شاملة للمهام**: 35 مهمة استدلال منطقي متميزة مع مولدات ومتحققات مخصصة
- **جاهز للتعلم المعزز**: جميع الأمثلة قابلة للتحقق عبر قواعد بسيطة، مما يجعلها مثالية للتعلم المعزز
- **نقل عبر المجالات**: تعميم قوي على مجالات الرياضيات والبرمجة

## 🚀 بداية سريعة

### التثبيت
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### توليد بيانات نموذجية (مثال متاهة الأسهم)
```bash
# مثال سريع مع متاهة الأسهم
bash games/tasks/arrow_maze/run.sh

# أو مع معلمات مخصصة
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### من أجل تدريب التعلم المعزز

نوفر إرشادات شاملة لاستخدام بيانات SynLogic في تدريب التعلم المعزز. راجع [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) للحصول على تعليمات مفصلة حول دمج SynLogic مع إطار Verl.

## :rocket: الموارد

### مجموعات البيانات
| اسم المجموعة | الوصف | الرابط |
|:------------:|:------------|:----:|
| **SynLogic** | مجموعة بيانات | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### النماذج


| اسم النموذج | الوصف | الرابط |
|:-----------|:------------|:----:|
| **SynLogic-7B** | نموذج 7B مدرب على SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | نموذج 32B مدرب على SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | نموذج 32B مدرب على بيانات مختلطة من SynLogic والرياضيات والبرمجة | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 التحديثات المستقبلية
نحن نعمل بنشاط على توسيع SynLogic ليشمل المزيد من مهام الاستدلال المنطقي.

تابع مستودعنا للاطلاع على آخر التحديثات والإصدارات!

## الاستشهاد
يرجى الاستشهاد بورقتنا البحثية إذا وجدت عملنا مفيدًا:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---