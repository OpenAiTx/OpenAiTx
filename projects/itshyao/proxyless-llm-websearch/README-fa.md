
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🧠 موتور جستجوی LLM بدون نیاز به پراکسی

ابزاری برای بازیابی اطلاعات وب با استفاده از چند موتور جستجو و بدون نیاز به پراکسی، با پشتیبانی از تجزیه محتوای URL و خزیدن صفحات وب، و پیاده‌سازی زنجیره عامل‌های ماژولار با LangGraph. این ابزار برای استفاده مدل‌های زبانی بزرگ در سناریوهای فراخوانی دانش خارجی طراحی شده و از **Playwright + Crawl4AI** برای دریافت و تجزیه صفحات وب، پشتیبانی از پردازش همزمان، برش و بازچینی محتوا بهره می‌برد.

## ✨ مروری بر ویژگی‌ها

- 🌐 **بدون نیاز به پراکسی**: با پیکربندی Playwright و پشتیبانی از مرورگر داخلی، جستجوی وب بدون نیاز به پراکسی ممکن است.
- 🔍 **پشتیبانی از چند موتور جستجو**: پشتیبانی از موتورهای جستجوی Bing، Quark، Baidu، Sogou و سایر موتورهای اصلی برای تنوع منابع اطلاعاتی.
- 🤖 **تشخیص نیت**: سیستم می‌تواند به طور خودکار بر اساس ورودی کاربر تشخیص دهد که باید جستجوی وب انجام شود یا تجزیه URL.
- 🔄 **تقسیم پرس‌وجو**: با توجه به نیت جستجوی کاربر، پرس‌وجو به طور خودکار به چندین زیر وظیفه تقسیم شده و به ترتیب اجرا می‌شود تا ارتباط و کارایی جستجو افزایش یابد.
- ⚙️ **معماری عامل هوشمند**: مبتنی بر **LangGraph** و شامل **«web_search»** و **«link_parser»**.
- 🏃‍♂️ **پردازش وظایف همزمان و غیرهمزمان**: پشتیبانی از انجام همزمان وظایف و جستجوهای متعدد با کارایی بالا.
- 📝 **بهینه‌سازی پردازش محتوا**:

  - ✂️ **برش محتوا**: تقسیم محتوای طولانی صفحات وب به بخش‌های کوچکتر.

  - 🔄 **بازچینی محتوا**: بازچینی هوشمند برای افزایش ارتباط اطلاعات.

  - 🚫 **فیلتر محتوا**: حذف خودکار محتوای نامرتبط یا تکراری.
- 🌐 **پشتیبانی از چند پلتفرم**:

  - 🖥️ ارائه API بک‌اند مبتنی بر FastAPI، قابل ادغام در هر سیستم.

  - 🌍 ارائه رابط کاربری وب Gradio، قابل استقرار سریع به صورت برنامه تصویری.
  
  - 🧩[ **پشتیبانی از افزونه مرورگر**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): پشتیبانی از Edge با افزونه هوشمند تجزیه URL، امکان ارسال درخواست تجزیه و استخراج محتوا مستقیماً در مرورگر.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ شروع سریع

### 1. کلون کردن مخزن

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. نصب وابستگی‌ها

```
pip install -r requirements.txt
python -m playwright install
```

### 3. شروع سریع

#### پیکربندی متغیرهای محیطی

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### دمو

```python
'''
python demo.py
'''

from pools import BrowserPool, CrawlerPool
from agent import ToolsGraph
import asyncio

async def main():
    browser_pool = BrowserPool(pool_size=1)
    crawler_pool = CrawlerPool(pool_size=1)
    
    graph = ToolsGraph(browser_pool, crawler_pool, engine="bing")

    await browser_pool._create_browser_instance(headless=True)
    await crawler_pool._get_instance()

    result = await graph.run("广州今日天气")

    await browser_pool.cleanup()
    await crawler_pool.cleanup()

    print(result)

if __name__ == "__main__":
    asyncio.run(main())
```

#### رابط برنامه‌نویسی کاربردی (API) بک‌اند

```python
'''
python api_serve.py
'''
import requests

url = "http://localhost:8000/search"

data = {
    "question": "广州今日天气"
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### نمایش_گرادیو

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 مقایسه با آزمایش جستجوی آنلاین وب

ما پروژه را با برخی از APIهای آنلاین اصلی مقایسه کردیم و عملکرد آن را در مواجهه با مسائل پیچیده ارزیابی نمودیم.

### 🔥 مجموعه داده

- مجموعه داده از [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) که توسط علی بابا منتشر شده، می‌آید و شامل ۶۸۰ پرسش دشوار است که حوزه‌هایی چون آموزش، کنفرانس‌های علمی، بازی و غیره را پوشش می‌دهد.
- مجموعه داده شامل سوالات به زبان چینی و انگلیسی است.

### 🧑‍🏫 نتایج مقایسه

| موتور جستجو/سیستم | ✅ صحیح | ❌ اشتباه | ⚠️ تاحدی صحیح |
| ----------------- | ------ | -------- | ------------- |
| **آتش‌فشان آرک**   | ۵.۰۰٪  | ۷۲.۲۱٪   | ۲۲.۷۹٪        |
| **بای‌لیان**       | ۹.۸۵٪  | ۶۲.۷۹٪   | ۲۷.۳۵٪        |
| **ما**           | ۱۹.۸۵٪ | ۴۷.۹۴٪   | ۳۲.۰۶٪        |

## 🙏 سپاسگزاری

برخی از قابلیت‌های این پروژه با حمایت و الهام از پروژه‌های متن‌باز زیر توسعه یافته است که از آنها سپاسگزاریم:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): چارچوب ساخت لینک‌های عامل ماژولار.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): ابزار قدرتمند برای تجزیه و تحلیل محتوای صفحات وب.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---