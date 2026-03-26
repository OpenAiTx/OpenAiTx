<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# لاما-گیت‌هاب

[سند جزئیات] https://deepwiki.com/JetXu-LLM/llama-github

[![نسخه PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![دانلودها](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![مجوز](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

لاما-گیت‌هاب یک ابزار قدرتمند است که به شما کمک می‌کند (بر اساس Agentic RAG) مرتبط‌ترین قطعه کدها، مسائل و اطلاعات مخزن را از گیت‌هاب بر اساس جستجوی شما بازیابی کند و آن‌ها را به زمینه دانشی ارزشمند تبدیل می‌کند. این ابزار، چت‌بات‌های LLM، عامل‌های هوش مصنوعی و عامل‌های Auto-dev را توانمند می‌سازد تا وظایف پیچیده کدنویسی را حل کنند. چه یک توسعه‌دهنده باشید که به دنبال راه‌حل سریع است یا یک مهندس که عامل‌های پیشرفته Auto Dev AI را پیاده‌سازی می‌کند، لاما-گیت‌هاب این کار را آسان و کارآمد می‌سازد.

اگر این پروژه را دوست دارید یا معتقدید که پتانسیل دارد، لطفاً به آن یک ⭐️ بدهید. حمایت شما بزرگترین انگیزه ماست!

## معماری
![معماری سطح بالا](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## نصب

```
pip install llama-github
```

هدف اجرای فعلی که نگهداری می‌شود: پایتون `3.10+`.

## نحوه استفاده

در اینجا یک مثال ساده از نحوه استفاده از llama-github آورده شده است:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` یک لیست از دیکشنری‌های زمینه را برمی‌گرداند. هر آیتم حداقل شامل `context` و `url` است.

برای استفاده پیشرفته‌تر و مثال‌ها، لطفاً به [مستندات](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) مراجعه کنید. مثال‌های قابل اجرا و کم هزینه نیز در [`examples/`](examples) موجود هستند.

## ویژگی‌های کلیدی

- **🔍 بازیابی هوشمند GitHub**: با قدرت llama-github، قطعات کد مرتبط، مسائل و اطلاعات مخزن را بر اساس پرسش‌های کاربر از GitHub دریافت کنید. تکنیک‌های پیشرفته بازیابی ما تضمین می‌کنند که سریع و کارآمدترین اطلاعات را پیدا کنید.

- **⚡ کش مخزن‌های Repository Pool**: Llama-github دارای مکانیزم نوآورانه کش مخزن است. با کش کردن مخزن‌ها (شامل READMEها، ساختارها، کدها و مسائل) میان رشته‌ها، llama-github بازدهی بازیابی جستجوی GitHub را به طور چشمگیری افزایش داده و مصرف توکن‌های API را به حداقل می‌رساند.

- **🧠 تحلیل پرسش مبتنی بر LLM**: از مدل‌های زبان پیشرفته برای تحلیل پرسش‌های کاربر و تولید راهبردها و معیارهای جستجوی موثر بهره ببرید. Llama-github پرسش‌های پیچیده را هوشمندانه شکسته و تضمین می‌کند که مرتبط‌ترین اطلاعات را از شبکه گسترده مخزن‌های GitHub دریافت کنید.

- **📚 تولید زمینه جامع**: پاسخ‌های غنی و مرتبط با زمینه را با ترکیب اطلاعات بازیابی‌شده از GitHub و قابلیت‌های استدلال مدل‌های زبان پیشرفته تولید کنید. Llama-github در پاسخ به پرسش‌های پیچیده و طولانی عالی عمل می‌کند و پاسخ‌های جامع و عمیقی ارائه می‌دهد که زمینه وسیعی را برای نیازهای توسعه شما فراهم می‌کند.

- **🚀 برتری پردازش ناهمزمان**: Llama-github از پایه برای بهره‌گیری کامل از برنامه‌نویسی ناهمزمان ساخته شده است. با مکانیزم‌های ناهمزمان دقیقی که در سراسر کد پیاده‌سازی شده، llama-github می‌تواند چندین درخواست را به طور همزمان مدیریت کند و عملکرد کلی را به طور چشمگیری افزایش دهد.

- **🔧 ادغام انعطاف‌پذیر LLM**: به راحتی llama-github را با ارائه‌دهندگان مختلف LLM، مدل‌های embedding، مدل‌های reranking یا یک مدل چت سازگار با LangChain ادغام کنید تا قابلیت‌های کتابخانه را مطابق نیازهای خاص خود تنظیم نمایید.

- **🔒 گزینه‌های احراز هویت قدرتمند**: Llama-github از هر دو توکن دسترسی شخصی و احراز هویت GitHub App پشتیبانی می‌کند و امکان ادغام آن با محیط‌های توسعه مختلف را به شما می‌دهد. چه توسعه‌دهنده فردی باشید یا در محیط سازمانی کار کنید، llama-github با مکانیزم‌های احراز هویت امن و قابل اعتماد، پاسخگوی نیاز شماست.

- **🛠️ لاگ‌گیری و مدیریت خطا**: ما اهمیت عملیات روان و رفع ایراد آسان را درک می‌کنیم. به همین دلیل llama-github مجهز به مکانیزم‌های جامع لاگ‌گیری و مدیریت خطا است. بینش عمیقی نسبت به رفتار کتابخانه کسب کنید، مشکلات را سریع تشخیص دهید و جریان توسعه‌ای پایدار و قابل اعتماد داشته باشید.

## 🤖 دستیار بررسی PR مبتنی بر هوش مصنوعی ما: LlamaPReview را امتحان کنید

اگر llama-github را مفید می‌دانید، ممکن است به دستیار بررسی PR مبتنی بر هوش مصنوعی ما، LlamaPReview نیز علاقه‌مند باشید. این ابزار برای تکمیل جریان کاری توسعه شما و ارتقای کیفیت کد طراحی شده است.

### ویژگی‌های کلیدی LlamaPReview:
- 🚀 نصب با یک کلیک، بدون نیاز به تنظیمات، اجرای کاملاً خودکار
- 💯 فعلاً رایگان - بدون نیاز به کارت اعتباری یا اطلاعات پرداخت
- 🧠 بررسی خودکار PR با هوش مصنوعی و درک عمیق کد
- 🌐 پشتیبانی از چندین زبان برنامه‌نویسی

**LlamaPReview از بازیابی زمینه پیشرفته llama-github و تحلیل مبتنی بر LLM** برای ارائه بررسی‌های هوشمند و مبتنی بر زمینه بهره می‌برد. این ابزار مانند داشتن یک توسعه‌دهنده ارشد است که با زمینه کامل مخزن شما، هر PR را به صورت خودکار بررسی می‌کند!

👉 [LlamaPReview را همین حالا نصب کنید](https://github.com/marketplace/llamapreview/) (رایگان)

با استفاده از llama-github برای بازیابی زمینه و LlamaPReview برای بررسی کد، می‌توانید محیط توسعه قدرتمند و مبتنی بر هوش مصنوعی ایجاد کنید.

## چشم‌انداز و نقشه راه


### چشم‌انداز

چشم‌انداز ما تبدیل شدن به یک ماژول کلیدی در آینده راه‌حل‌های توسعه مبتنی بر هوش مصنوعی است که با ادغام بی‌وقفه با گیت‌هاب، به LLMها در حل خودکار وظایف پیچیده کدنویسی قدرت می‌بخشد.

![معماری چشم‌انداز](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### نقشه راه

برای مشاهده تاریخی نقشه راه اولیه، لطفاً به [چشم‌انداز و نقشه راه](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md) مراجعه کنید.

## تقدیر و تشکر

مایلیم مراتب سپاس خود را از پروژه‌های متن‌باز زیر بابت حمایت و مشارکت‌شان اعلام کنیم:

- **[LangChain](https://github.com/langchain-ai/langchain)**: برای فراهم کردن چارچوبی بنیادی که قابلیت‌های پرسش و پردازش LLM را در llama-github تقویت می‌کند.
- **[Jina.ai](https://github.com/jina-ai/reader)**: برای ارائه API s.jina.ai و مدل‌های متن‌باز رنکر و جاسازی که دقت و ارتباط زمینه‌های تولید شده در llama-github را افزایش می‌دهند.

مشارکت‌های آنان نقشی اساسی در توسعه llama-github داشته و توصیه می‌کنیم پروژه‌هایشان را برای راه‌حل‌های نوآورانه بیشتر بررسی نمایید.

## مشارکت

ما از مشارکت در llama-github استقبال می‌کنیم! لطفاً برای اطلاعات بیشتر به [راهنمای مشارکت](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) ما مراجعه فرمایید.

## مجوز

این پروژه تحت شرایط مجوز آپاچی ۲.۰ ارائه شده است. برای جزئیات بیشتر به فایل [LICENSE](LICENSE) مراجعه کنید.

## تماس

اگر سوال، پیشنهاد یا بازخوردی دارید، لطفاً با ما از طریق [ایمیل Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) تماس بگیرید.

---

از اینکه llama-github را انتخاب کرده‌اید سپاسگزاریم! امیدواریم این کتابخانه تجربه توسعه هوش مصنوعی شما را بهبود بخشد و به شما در ساخت برنامه‌های قدرتمند با سهولت کمک کند.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---