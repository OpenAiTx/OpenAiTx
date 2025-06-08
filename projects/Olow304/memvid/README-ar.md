# Memvid - ذاكرة الذكاء الاصطناعي القائمة على الفيديو 🧠📹

**الحل الخفيف الثوري لذاكرة الذكاء الاصطناعي على نطاق واسع**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

تُحدث Memvid ثورة في إدارة ذاكرة الذكاء الاصطناعي من خلال ترميز البيانات النصية إلى مقاطع فيديو، مما يتيح **بحثًا دلاليًا فائق السرعة** عبر ملايين المقاطع النصية مع **أوقات استرجاع أقل من الثانية**. على عكس قواعد البيانات التقليدية القائمة على المتجهات والتي تستهلك كميات ضخمة من الذاكرة والتخزين، تضغط Memvid قاعدة معرفتك إلى ملفات فيديو مدمجة مع الحفاظ على الوصول الفوري إلى أي معلومة.

## 🎥 العرض التوضيحي

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ الميزات الرئيسية

- 🎥 **الفيديو كقاعدة بيانات**: تخزين ملايين المقاطع النصية في ملف MP4 واحد
- 🔍 **بحث دلالي**: العثور على المحتوى المناسب باستخدام الاستعلامات الطبيعية
- 💬 **دردشة مدمجة**: واجهة محادثة مع استجابات مدركة للسياق
- 📚 **دعم PDF**: استيراد وفهرسة مستندات PDF مباشرة
- 🚀 **استرجاع سريع**: بحث أقل من ثانية عبر مجموعات بيانات ضخمة
- 💾 **تخزين فعال**: ضغط حتى 10 أضعاف مقارنة بقواعد البيانات التقليدية
- 🔌 **نماذج LLM قابلة للتوصيل**: يعمل مع OpenAI، Anthropic أو النماذج المحلية
- 🌐 **أوفلاين أولًا**: لا يتطلب اتصالًا بالإنترنت بعد توليد الفيديو
- 🔧 **واجهة برمجة تطبيقات بسيطة**: البدء في العمل بـ 3 أسطر فقط من الشيفرة

## 🎯 حالات الاستخدام

- **📖 المكتبات الرقمية**: فهرسة آلاف الكتب في ملف فيديو واحد
- **🎓 المحتوى التعليمي**: إنشاء ذاكرة فيديو قابلة للبحث للمواد الدراسية
- **📰 أرشيف الأخبار**: ضغط سنوات من المقالات في قواعد بيانات فيديو قابلة للإدارة
- **💼 المعرفة المؤسسية**: بناء قواعد معرفية للشركة قابلة للبحث
- **🔬 الأبحاث العلمية**: بحث دلالي سريع في الأدبيات العلمية
- **📝 الملاحظات الشخصية**: تحويل ملاحظاتك إلى مساعد ذكاء اصطناعي قابل للبحث

## 🚀 لماذا Memvid؟

### ابتكار ثوري
- **الفيديو كقاعدة بيانات**: تخزين ملايين المقاطع النصية في ملف MP4 واحد
- **استرجاع فوري**: بحث دلالي أقل من ثانية عبر بيانات ضخمة
- **كفاءة تخزين 10x**: ضغط الفيديو يقلل بشكل كبير من استهلاك الذاكرة
- **بنية تحتية صفرية**: لا حاجة لخوادم قواعد بيانات، فقط ملفات يمكنك نسخها أينما شئت
- **أوفلاين أولًا**: يعمل بالكامل بدون إنترنت بمجرد توليد الفيديوهات

### بنية خفيفة الوزن
- **اعتمادية دنيا**: الوظائف الأساسية في ~1000 سطر بايثون فقط
- **صديق للمعالج**: يعمل بكفاءة دون الحاجة إلى معالج رسومي (GPU)
- **قابلية النقل**: ملف فيديو واحد يحتوي على كل قاعدة معرفتك
- **قابل للبث**: يمكن بث مقاطع الفيديو من تخزين سحابي

## 📦 التثبيت

### التثبيت السريع
```bash
pip install memvid
```

### لدعم ملفات PDF
```bash
pip install memvid PyPDF2
```

### الإعداد الموصى به (بيئة افتراضية)
```bash
# إنشاء دليل مشروع جديد
mkdir my-memvid-project
cd my-memvid-project

# إنشاء بيئة افتراضية
python -m venv venv

# تفعيل البيئة
# على macOS/Linux:
source venv/bin/activate
# على Windows:
venv\Scripts\activate

# تثبيت memvid
pip install memvid

# لدعم ملفات PDF:
pip install PyPDF2
```

## 🎯 البدء السريع

### الاستخدام الأساسي
```python
from memvid import MemvidEncoder, MemvidChat

# إنشاء ذاكرة فيديو من مقاطع نصية
chunks = ["معلومة هامة 1", "معلومة هامة 2", "تفاصيل حدث تاريخي"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# المحادثة مع ذاكرتك
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("ماذا تعرف عن الأحداث التاريخية؟")
print(response)
```

### بناء الذاكرة من المستندات
```python
from memvid import MemvidEncoder
import os

# تحميل المستندات
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# إضافة ملفات نصية
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# بناء فيديو محسن
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # معدل إطارات أعلى = مزيد من المقاطع في الثانية
    frame_size=512  # إطارات أكبر = مزيد من البيانات في كل إطار
)
```

### البحث والاسترجاع المتقدم
```python
from memvid import MemvidRetriever

# تهيئة أداة الاسترجاع
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# بحث دلالي
results = retriever.search("خوارزميات التعلم الآلي", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# الحصول على نافذة سياقية
context = retriever.get_context("اشرح الشبكات العصبية", max_tokens=2000)
print(context)
```

### واجهة الدردشة التفاعلية
```python
from memvid import MemvidInteractive

# تشغيل واجهة الدردشة التفاعلية
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # يفتح الواجهة على http://localhost:7860
```

### الاختبار باستخدام file_chat.py
يوفر السكريبت `examples/file_chat.py` طريقة شاملة لاختبار Memvid مع مستنداتك الخاصة:

```bash
# معالجة دليل من المستندات
python examples/file_chat.py --input-dir /path/to/documents --provider google

# معالجة ملفات محددة
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# استخدام ضغط H.265 (يتطلب Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# تقسيم مخصص للوثائق الكبيرة
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# تحميل ذاكرة موجودة
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### مثال كامل: الدردشة مع كتاب PDF
```bash
# 1. أنشئ مجلدًا جديدًا وقم بإعداد البيئة
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # على Windows: venv\Scripts\activate

# 2. تثبيت الاعتمادات
pip install memvid PyPDF2

# 3. أنشئ book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# ملف PDF الخاص بك
book_pdf = "book.pdf"  # استبدل بمسار ملف PDF الخاص بك

# بناء ذاكرة الفيديو
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# الدردشة مع الكتاب
api_key = os.getenv("OPENAI_API_KEY")  # اختياري: لاستجابات الذكاء الاصطناعي
```
```markdown
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. تشغيله
export OPENAI_API_KEY="your-api-key"  # اختياري
python book_chat.py
```

## 🛠️ إعدادات متقدمة

### تضمينات مخصصة
```python
from sentence_transformers import SentenceTransformer

# استخدم نموذج تضمين مخصص
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### تحسين الفيديو
```python
# لأقصى ضغط ممكن
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # عدد إطارات أعلى في الثانية
    frame_size=256,  # إطارات أصغر
    video_codec='h265',  # ضغط أفضل
    crf=28  # جودة الضغط (كلما قل الرقم زادت الجودة)
)
```

### المعالجة الموزعة
```python
# معالجة مجموعات بيانات كبيرة بالتوازي
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 استكشاف الأخطاء وإصلاحها

### المشاكل الشائعة

**ModuleNotFoundError: No module named 'memvid'**
```bash
# تأكد أنك تستخدم بايثون الصحيح
which python  # يجب أن يظهر مسار بيئة العمل الافتراضية الخاصة بك
# إذا لم يكن كذلك، فعّل بيئة العمل الافتراضية:
source venv/bin/activate  # على ويندوز: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**مشاكل مفتاح API لـ LLM**
```bash
# عيّن مفتاح API الخاص بك (احصل عليه من https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# أو على ويندوز:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**معالجة ملفات PDF ضخمة**
```python
# للملفات الضخمة جداً، استخدم أحجام قطع أصغر
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 المساهمة

نرحب بمساهماتكم! يرجى مراجعة [دليل المساهمة](CONTRIBUTING.md) للمزيد من التفاصيل.

```bash
# تشغيل الاختبارات
pytest tests/

# تشغيل مع التغطية
pytest --cov=memvid tests/

# تنسيق الكود
black memvid/
```

## 🆚 المقارنة مع الحلول التقليدية

| الميزة            | Memvid | قواعد بيانات المتجهات | قواعد البيانات التقليدية |
|-------------------|--------|----------------------|-------------------------|
| كفاءة التخزين     | ⭐⭐⭐⭐⭐ | ⭐⭐                  | ⭐⭐⭐                    |
| سهولة الإعداد     | بسيط   | معقد                 | معقد                    |
| البحث الدلالي     | ✅     | ✅                   | ❌                      |
| الاستخدام دون اتصال| ✅     | ❌                   | ✅                      |
| قابلية النقل      | ملفية  | قائمة على الخادم     | قائمة على الخادم        |
| قابلية التوسع     | ملايين | ملايين               | مليارات                 |
| التكلفة           | مجاني  | $$$$                 | $$$                     |


## 📚 أمثلة

اطلع على مجلد [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) لمتابعة:
- بناء الذاكرة من تفريغات ويكيبيديا
- إنشاء قاعدة معرفة شخصية
- دعم متعدد اللغات
- تحديثات ذاكرة في الوقت الحقيقي
- التكامل مع نماذج LLM الشهيرة

## 🆘 الحصول على الدعم

- 📖 [التوثيق](https://github.com/olow304/memvid/wiki) - أدلة شاملة
- 💬 [النقاشات](https://github.com/olow304/memvid/discussions) - لطرح الأسئلة
- 🐛 [متتبع المشاكل](https://github.com/olow304/memvid/issues) - للإبلاغ عن الأخطاء
- 🌟 [العرض والمشاركة](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - لمشاركة مشاريعك

## 🔗 الروابط

- [مستودع GitHub](https://github.com/olow304/memvid)
- [حزمة PyPI](https://pypi.org/project/memvid)
- [سجل التغييرات](https://github.com/olow304/memvid/releases)


## 📄 الرخصة

رخصة MIT - انظر ملف [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) للمزيد من التفاصيل.

## 🙏 الشكر والتقدير

تم الإنشاء بواسطة [Olow304](https://github.com/olow304) ومجتمع Memvid.

بُني بحب ❤️ باستخدام:
- [sentence-transformers](https://www.sbert.net/) - تضمينات متقدمة للبحث الدلالي
- [OpenCV](https://opencv.org/) - الرؤية الحاسوبية ومعالجة الفيديو
- [qrcode](https://github.com/lincolnloop/python-qrcode) - توليد رموز QR
- [FAISS](https://github.com/facebookresearch/faiss) - بحث تشابه فعال
- [PyPDF2](https://github.com/py-pdf/pypdf) - استخراج نصوص PDF

شكر خاص لجميع المساهمين الذين ساعدوا في تحسين Memvid!

---

**هل أنت مستعد لإحداث ثورة في إدارة ذاكرة الذكاء الاصطناعي؟ قم بتثبيت Memvid وابدأ البناء الآن!** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---