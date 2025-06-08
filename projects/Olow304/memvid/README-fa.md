# Memvid - حافظه مبتنی بر ویدیو برای هوش مصنوعی 🧠📹

**راهکار سبک و تحول‌آفرین برای حافظه هوش مصنوعی در مقیاس وسیع**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid مدیریت حافظه هوش مصنوعی را با رمزگذاری داده‌های متنی به ویدیو متحول می‌کند و امکان **جستجوی معنایی فوق‌العاده سریع** در میان میلیون‌ها قطعه متن با **زمان بازیابی زیر یک ثانیه** را فراهم می‌سازد. برخلاف پایگاه‌های داده برداری سنتی که منابع زیادی از RAM و فضای ذخیره‌سازی را مصرف می‌کنند، Memvid پایگاه دانش شما را به فایل‌های ویدیویی فشرده تبدیل می‌کند و در عین حال دسترسی فوری به هر اطلاعاتی را حفظ می‌کند.

## 🎥 دمو

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e

## ✨ قابلیت‌های کلیدی

- 🎥 **ویدیو به عنوان پایگاه داده**: ذخیره میلیون‌ها قطعه متن در یک فایل MP4
- 🔍 **جستجوی معنایی**: یافتن محتوای مرتبط با استفاده از پرسش‌های زبان طبیعی
- 💬 **چت داخلی**: رابط مکالمه با پاسخ‌های مبتنی بر زمینه
- 📚 **پشتیبانی از PDF**: واردسازی و ایندکس مستقیم اسناد PDF
- 🚀 **بازیابی سریع**: جستجوی زیر یک ثانیه در مجموعه داده‌های عظیم
- 💾 **ذخیره‌سازی بهینه**: فشرده‌سازی تا ۱۰ برابر نسبت به پایگاه داده‌های سنتی
- 🔌 **مدل‌های LLM قابل اتصال**: سازگار با OpenAI، Anthropic یا مدل‌های محلی
- 🌐 **آفلاین بودن**: پس از تولید ویدیو نیازی به اینترنت نیست
- 🔧 **API ساده**: شروع کار تنها با ۳ خط کد

## 🎯 موارد استفاده

- **📖 کتابخانه‌های دیجیتال**: ایندکس هزاران کتاب در یک فایل ویدیویی
- **🎓 محتوای آموزشی**: ایجاد خاطرات ویدیویی قابل جستجو از مواد درسی
- **📰 آرشیو اخبار**: فشرده‌سازی سال‌ها مقاله به پایگاه داده ویدیویی قابل مدیریت
- **💼 دانش شرکتی**: ساخت پایگاه دانش قابل جستجوی سراسر سازمان
- **🔬 مقالات پژوهشی**: جستجوی معنایی سریع در ادبیات علمی
- **📝 یادداشت‌های شخصی**: تبدیل یادداشت‌های خود به دستیار هوش مصنوعی قابل جستجو

## 🚀 چرا Memvid؟

### نوآوری تحول‌آفرین
- **ویدیو به عنوان پایگاه داده**: ذخیره میلیون‌ها قطعه متن در یک فایل MP4
- **بازیابی فوری**: جستجوی معنایی زیر یک ثانیه در مجموعه داده‌های عظیم
- **۱۰ برابر بهره‌وری ذخیره‌سازی**: فشرده‌سازی ویدیویی به‌شدت حجم حافظه را کاهش می‌دهد
- **بدون زیرساخت**: بدون سرور پایگاه داده، فقط فایل‌هایی که می‌توانید هر جا کپی کنید
- **کاملاً آفلاین**: پس از تولید ویدیوها، کاملاً به صورت آفلاین کار می‌کند

### معماری سبک
- **وابستگی‌های حداقلی**: عملکرد اصلی در حدود ۱۰۰۰ خط پایتون
- **مناسب پردازنده**: بدون نیاز به GPU و با کارایی بالا روی CPU
- **قابل حمل**: کل پایگاه دانش شما در یک فایل ویدیویی
- **قابل پخش جریانی**: ویدیوها را می‌توان از فضای ابری پخش کرد

## 📦 نصب

### نصب سریع
```bash
pip install memvid
```

### برای پشتیبانی از PDF
```bash
pip install memvid PyPDF2
```

### راه‌اندازی پیشنهادی (محیط مجازی)
```bash
# ایجاد یک پوشه پروژه جدید
mkdir my-memvid-project
cd my-memvid-project

# ایجاد محیط مجازی
python -m venv venv

# فعال‌سازی محیط
# در macOS/Linux:
source venv/bin/activate
# در ویندوز:
venv\Scripts\activate

# نصب memvid
pip install memvid

# برای پشتیبانی از PDF:
pip install PyPDF2
```

## 🎯 شروع سریع

### استفاده پایه
```python
from memvid import MemvidEncoder, MemvidChat

# ایجاد حافظه ویدیویی از قطعات متن
chunks = ["واقعیت مهم ۱", "واقعیت مهم ۲", "جزئیات رویداد تاریخی"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# گفتگو با حافظه خود
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("درباره رویدادهای تاریخی چه می‌دانی؟")
print(response)
```

### ساخت حافظه از اسناد
```python
from memvid import MemvidEncoder
import os

# بارگذاری اسناد
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# افزودن فایل‌های متنی
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# ساخت ویدیوی بهینه‌شده
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # فریم بر ثانیه بیشتر = قطعات بیشتر در هر ثانیه
    frame_size=512  # فریم بزرگتر = داده بیشتر در هر فریم
)
```

### جستجو و بازیابی پیشرفته
```python
from memvid import MemvidRetriever

# مقداردهی اولیه بازیاب
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# جستجوی معنایی
results = retriever.search("الگوریتم‌های یادگیری ماشین", top_k=5)
for chunk, score in results:
    print(f"امتیاز: {score:.3f} | {chunk[:100]}...")

# دریافت پنجره زمینه
context = retriever.get_context("توضیح شبکه‌های عصبی", max_tokens=2000)
print(context)
```

### رابط چت تعاملی
```python
from memvid import MemvidInteractive

# اجرای رابط کاربری چت تعاملی
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # اجرای رابط وب در http://localhost:7860
```

### تست با file_chat.py
اسکریپت `examples/file_chat.py` راهی جامع برای آزمایش Memvid با اسناد خودتان فراهم می‌کند:

```bash
# پردازش یک پوشه اسناد
python examples/file_chat.py --input-dir /path/to/documents --provider google

# پردازش فایل‌های خاص
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# استفاده از فشرده‌سازی H.265 (نیازمند Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# قطعه‌بندی سفارشی برای اسناد بزرگ
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# بارگذاری حافظه موجود
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### مثال کامل: گفتگو با یک کتاب PDF
```bash
# 1. ایجاد یک پوشه جدید و راه‌اندازی محیط
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # در ویندوز: venv\Scripts\activate

# 2. نصب وابستگی‌ها
pip install memvid PyPDF2

# 3. ایجاد book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# فایل PDF شما
book_pdf = "book.pdf"  # مسیر فایل PDF را جایگزین کنید

# ساخت حافظه ویدیویی
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# گفتگو با کتاب
api_key = os.getenv("OPENAI_API_KEY")  # اختیاری: برای پاسخ‌های هوش مصنوعی
```
```markdown
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# ۴. اجرا کردن
export OPENAI_API_KEY="your-api-key"  # اختیاری
python book_chat.py
```

## 🛠️ پیکربندی پیشرفته

### جاسازی‌های سفارشی
```python
from sentence_transformers import SentenceTransformer

# استفاده از مدل جاسازی سفارشی
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### بهینه‌سازی ویدیو
```python
# برای فشرده‌سازی حداکثری
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # فریم‌های بیشتر در ثانیه
    frame_size=256,  # فریم‌های کوچکتر
    video_codec='h265',  # فشرده‌سازی بهتر
    crf=28  # کیفیت فشرده‌سازی (عدد کمتر = کیفیت بهتر)
)
```

### پردازش توزیع‌شده
```python
# پردازش موازی دیتاست‌های بزرگ
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 رفع اشکال

### مشکلات رایج

**ModuleNotFoundError: No module named 'memvid'**
```bash
# مطمئن شوید که از پایتون صحیح استفاده می‌کنید
which python  # باید مسیر محیط مجازی شما را نشان دهد
# اگر نه، محیط مجازی را فعال کنید:
source venv/bin/activate  # در ویندوز: venv\Scripts\activate
```

**ImportError: PyPDF2 برای پشتیبانی PDF نیاز است**
```bash
pip install PyPDF2
```

**مشکلات کلید API LLM**
```bash
# کلید API خود را تنظیم کنید (یکی از https://platform.openai.com دریافت کنید)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# یا در ویندوز:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**پردازش PDFهای بزرگ**
```python
# برای PDFهای بسیار بزرگ، از اندازه‌های کوچکتر برای chunk استفاده کنید
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 مشارکت

ما از مشارکت استقبال می‌کنیم! لطفاً راهنمای [مشارکت](CONTRIBUTING.md) را برای جزییات ببینید.

```bash
# اجرای تست‌ها
pytest tests/

# اجرا با پوشش
pytest --cov=memvid tests/

# قالب‌بندی کد
black memvid/
```

## 🆚 مقایسه با راه‌حل‌های سنتی

| ویژگی | Memvid | پایگاه داده برداری | پایگاه داده سنتی |
|-------|--------|-------------------|------------------|
| کارایی ذخیره‌سازی | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| پیچیدگی راه‌اندازی | ساده | پیچیده | پیچیده |
| جستجوی معنایی | ✅ | ✅ | ❌ |
| استفاده آفلاین | ✅ | ❌ | ✅ |
| قابل حمل بودن | مبتنی بر فایل | مبتنی بر سرور | مبتنی بر سرور |
| مقیاس‌پذیری | میلیون‌ها | میلیون‌ها | میلیاردها |
| هزینه | رایگان | $$$$ | $$$ |


## 📚 مثال‌ها

دایرکتوری [examples/](examples/) را برای موارد زیر بررسی کنید:
- ساخت حافظه از dumps ویکی‌پدیا
- ایجاد پایگاه دانش شخصی
- پشتیبانی چندزبانه
- به‌روزرسانی حافظه در زمان واقعی
- یکپارچگی با LLMهای محبوب

## 🆘 دریافت کمک

- 📖 [مستندات](https://github.com/olow304/memvid/wiki) - راهنماهای جامع
- 💬 [بحث‌ها](https://github.com/olow304/memvid/discussions) - پرسش سوالات
- 🐛 [ردیاب مشکلات](https://github.com/olow304/memvid/issues) - گزارش اشکالات
- 🌟 [نمایش و معرفی](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - به اشتراک‌گذاری پروژه‌های شما

## 🔗 لینک‌ها

- [مخزن گیت‌هاب](https://github.com/olow304/memvid)
- [پکیج PyPI](https://pypi.org/project/memvid)
- [تغییرات نسخه‌ها](https://github.com/olow304/memvid/releases)


## 📄 مجوز

مجوز MIT - برای جزییات به فایل [LICENSE](LICENSE) مراجعه کنید.

## 🙏 تقدیر و تشکر

ساخته شده توسط [Olow304](https://github.com/olow304) و جامعه Memvid.

ساخته شده با ❤️ با استفاده از:
- [sentence-transformers](https://www.sbert.net/) - جاسازی‌های پیشرفته برای جستجوی معنایی
- [OpenCV](https://opencv.org/) - پردازش تصویر و ویدیو
- [qrcode](https://github.com/lincolnloop/python-qrcode) - تولید QR کد
- [FAISS](https://github.com/facebookresearch/faiss) - جستجوی مشابهت بهینه
- [PyPDF2](https://github.com/py-pdf/pypdf) - استخراج متن PDF

تشکر ویژه از تمامی مشارکت‌کنندگان که به بهبود Memvid کمک می‌کنند!

---

**آماده‌اید مدیریت حافظه هوش مصنوعی خود را متحول کنید؟ Memvid را نصب کنید و شروع به ساخت کنید!** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---