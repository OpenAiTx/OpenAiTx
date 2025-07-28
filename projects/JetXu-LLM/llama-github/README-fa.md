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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[سند تفصیلی] https://deepwiki.com/JetXu-LLM/llama-github

[![نسخه PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![تعداد دانلودها](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![مجوز](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

llama-github یک ابزار قدرتمند است که به شما کمک می‌کند با استفاده از Agentic RAG مرتبط‌ترین قطعه‌کدها، مشکلات (issues) و اطلاعات مخزن را از گیت‌هاب بر اساس پرسش‌های خود بازیابی کرده و آن‌ها را به زمینه دانشی ارزشمند تبدیل کنید. این ابزار، چت‌بات‌های LLM، عامل‌های هوش مصنوعی و عامل‌های توسعه‌دهنده خودکار را قادر می‌سازد تا وظایف پیچیده برنامه‌نویسی را حل کنند. چه یک توسعه‌دهنده باشید که به دنبال راه‌حل‌های سریع است یا یک مهندس که عامل‌های پیشرفته توسعه‌دهنده هوش مصنوعی را پیاده‌سازی می‌کند، llama-github این کار را آسان و کارآمد می‌سازد.

اگر این پروژه را دوست دارید یا فکر می‌کنید پتانسیل دارد، لطفاً به آن یک ⭐️ بدهید. حمایت شما بزرگ‌ترین انگیزه ماست!

## معماری
![معماری سطح بالا](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## نصب

```
pip install llama-github
```

## نحوه استفاده

در اینجا یک مثال ساده از نحوه استفاده از llama-github آمده است:

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
برای استفاده‌های پیشرفته‌تر و مثال‌های بیشتر، لطفاً به [مستندات](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) مراجعه کنید.

## ویژگی‌های کلیدی

- **🔍 بازیابی هوشمند از گیت‌هاب**: با بهره‌گیری از قدرت llama-github، قطعات کد مرتبط، مشکلات (issues) و اطلاعات مخزن را بر اساس پرسش کاربر از گیت‌هاب استخراج کنید. تکنیک‌های پیشرفته بازیابی ما تضمین می‌کند که سریع و کارآمدترین اطلاعات را بیابید.

- **⚡ کش کردن مخزن‌ها (Repository Pool Caching)**: llama-github دارای مکانیزم نوآورانه کش مخزن است. با کش کردن مخزن‌ها (شامل فایل‌های README، ساختار، کد و مشکلات) در میان نخ‌ها، llama-github کارایی بازیابی جستجو در گیت‌هاب را به طور چشمگیری افزایش داده و مصرف توکن‌های API گیت‌هاب را به حداقل می‌رساند. با اطمینان llama-github را در محیط‌های تولید چندنخی استفاده کنید و مطمئن باشید بهترین عملکرد را با صرفه‌جویی در منابع خواهید داشت.

- **🧠 تحلیل سوالات مبتنی بر LLM**: با استفاده از مدل‌های زبانی پیشرفته، سوالات کاربر را تحلیل کرده و استراتژی‌ها و معیارهای جستجوی بسیار موثری تولید کنید. llama-github پرسش‌های پیچیده را هوشمندانه تجزیه می‌کند تا مرتبط‌ترین اطلاعات را از شبکه وسیع مخازن گیت‌هاب بازیابی نمایید.

- **📚 تولید زمینه جامع**: با ترکیب بی‌وقفه اطلاعات استخراج‌شده از گیت‌هاب با توان استدلال مدل‌های زبانی پیشرفته، پاسخ‌های غنی و مرتبط با زمینه ایجاد کنید. llama-github در پاسخگویی به پیچیده‌ترین و طولانی‌ترین سوالات نیز عالی عمل می‌کند و پاسخ‌هایی جامع و پرمحتوا با زمینه گسترده برای پشتیبانی از نیازهای توسعه شما ارائه می‌دهد.

- **🚀 برتری در پردازش ناهمزمان**: llama-github از پایه برای بهره‌برداری کامل از برنامه‌نویسی ناهمزمان طراحی شده است. با پیاده‌سازی دقیق مکانیزم‌های ناهمزمان در سراسر کد، llama-github می‌تواند درخواست‌های متعدد را به طور همزمان مدیریت کند و عملکرد کلی را به طور چشمگیری افزایش دهد. تفاوت را احساس کنید؛ llama-github بدون افت سرعت یا کیفیت، بارهای کاری زیاد را با کارایی مدیریت می‌کند.

- **🔧 ادغام انعطاف‌پذیر با LLM**: به راحتی llama-github را با ارائه‌دهندگان مختلف LLM، مدل‌های embedding و مدل‌های reranking ادغام کنید تا قابلیت‌های کتابخانه را متناسب با نیاز خود سفارشی نمایید. معماری قابل توسعه ما اجازه می‌دهد عملکرد llama-github را شخصی‌سازی و ارتقا دهید تا به راحتی با محیط توسعه منحصر به فرد شما هماهنگ شود.

- **🔒 گزینه‌های احراز هویت قدرتمند**: llama-github هم از توکن‌های دسترسی شخصی و هم از احراز هویت برنامه گیت‌هاب پشتیبانی می‌کند، بنابراین شما امکان ادغام آن را در تنظیمات مختلف توسعه خواهید داشت. چه توسعه‌دهنده فردی باشید و چه در یک سازمان کار کنید، llama-github با مکانیزم‌های احراز هویت ایمن و قابل اعتماد از شما پشتیبانی می‌کند.

- **🛠️ ثبت رویدادها و مدیریت خطاها**: ما اهمیت عملکرد روان و عیب‌یابی آسان را درک می‌کنیم. به همین دلیل llama-github به مکانیزم‌های جامع ثبت رویدادها (logging) و مدیریت خطا مجهز شده است. رفتار کتابخانه را عمیقاً مشاهده کنید، مشکلات را سریع تشخیص دهید و فرآیند توسعه‌ای پایدار و قابل اعتماد را حفظ نمایید.

## 🤖 دستیار بررسی PR مبتنی بر هوش مصنوعی ما: LlamaPReview را امتحان کنید

اگر llama-github برای شما مفید است، احتمالاً به دستیار بررسی PR گیت‌هاب مبتنی بر هوش مصنوعی ما به نام LlamaPReview نیز علاقه‌مند خواهید شد. این ابزار برای تکمیل جریان کاری توسعه شما و افزایش کیفیت کد طراحی شده است.

### ویژگی‌های کلیدی LlamaPReview:
- 🚀 نصب با یک کلیک، بدون نیاز به پیکربندی، اجرا به طور خودکار
- 💯 هم‌اکنون رایگان برای استفاده - بدون نیاز به کارت اعتباری یا اطلاعات پرداخت
- 🧠 بررسی خودکار PR توسط هوش مصنوعی با درک عمیق کد
- 🌐 پشتیبانی از چندین زبان برنامه‌نویسی

**LlamaPReview با استفاده از بازیابی زمینه پیشرفته و تحلیل مبتنی بر LLM از llama-github**، بررسی‌های کد هوشمند و آگاه به زمینه ارائه می‌دهد. مثل این است که یک توسعه‌دهنده ارشد، با آگاهی کامل از مخزن شما، هر PR را به طور خودکار بررسی کند!

👉 [همین حالا LlamaPReview را نصب کنید](https://github.com/marketplace/llamapreview/) (رایگان)

با استفاده از llama-github برای بازیابی زمینه و LlamaPReview برای بررسی کد، می‌توانید محیط توسعه‌ای قدرتمند و مجهز به هوش مصنوعی ایجاد کنید.

## چشم‌انداز و نقشه راه

### چشم‌انداز

چشم‌انداز ما این است که به یک ماژول کلیدی در آینده راهکارهای توسعه مبتنی بر هوش مصنوعی تبدیل شویم، و با ادغام بی‌وقفه با گیت‌هاب، به LLMها کمک کنیم تا وظایف پیچیده کدنویسی را به طور خودکار حل کنند.

![معماری چشم‌انداز](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### نقشه راه

برای مشاهده جزئیات نقشه راه پروژه، لطفاً به [Project Roadmap](https://github.com/users/JetXu-LLM/projects/2) مراجعه کنید.

## تقدیر و تشکر

مایلیم از پروژه‌های متن‌باز زیر به خاطر حمایت و مشارکت‌شان سپاسگزاری کنیم:

- **[LangChain](https://github.com/langchain-ai/langchain)**: برای فراهم کردن چارچوب پایه‌ای که قدرت‌دهنده قابلیت‌های prompt و پردازش LLM در llama-github است.
- **[Jina.ai](https://github.com/jina-ai/reader)**: برای ارائه API سرویس s.jina.ai و مدل‌های reranker و embedding متن‌باز که دقت و مرتبط بودن زمینه‌های تولیدشده در llama-github را افزایش می‌دهد.

مشارکت‌های آن‌ها نقش اساسی در توسعه llama-github داشته و قویاً توصیه می‌کنیم برای راهکارهای نوآورانه بیشتر به پروژه‌هایشان سر بزنید.

## مشارکت

ما از مشارکت در llama-github استقبال می‌کنیم! لطفاً برای اطلاعات بیشتر [راهنمای مشارکت](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) ما را ببینید.

## مجوز

این پروژه تحت مجوز Apache 2.0 ارائه شده است. جزئیات بیشتر را در فایل [LICENSE](LICENSE) ببینید.

## تماس

اگر سوال، پیشنهاد یا بازخوردی دارید، لطفاً با ما از طریق [ایمیل Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com) در ارتباط باشید.

---

از این که llama-github را انتخاب کرده‌اید سپاسگزاریم! امیدواریم این کتابخانه تجربه توسعه مبتنی بر هوش مصنوعی شما را بهبود بخشیده و به شما کمک کند برنامه‌های قدرتمندی را به راحتی بسازید.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---