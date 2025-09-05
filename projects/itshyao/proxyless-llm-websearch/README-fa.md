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
# 🧠 موتور جستجوی شبکه LLM بدون نیاز به پراکسی

ابزاری برای جستجوی شبکه LLM با چند موتور جستجو بدون نیاز به پراکسی، با پشتیبانی از تجزیه محتوای URL و خزیدن صفحات وب، مبتنی بر **LangGraph** و **LangGraph-MCP** جهت پیاده‌سازی زنجیره عامل‌های ماژولار. طراحی‌شده برای فراخوانی دانش خارجی توسط مدل‌های زبان بزرگ، با پشتیبانی از دریافت و تجزیه صفحات وب توسط **Playwright + Crawl4AI**، قابلیت همزمانی غیرهمزمان، برش و فیلتر مجدد محتوا.

## 🚀 گزارش بروزرسانی‌ها

- 🔥 2025-09-05: پشتیبانی از **langgraph-mcp**
- 🔥 2025-09-03: افزودن استقرار Docker، مرتب‌ساز هوشمند داخلی، پشتیبانی از برش‌دهنده و مرتب‌ساز متن سفارشی

## ✨ مرور ویژگی‌ها

- 🌐 **بدون نیاز به پروکسی**: با پیکربندی Playwright مرورگرهای داخلی را پشتیبانی می‌کند و بدون نیاز به پروکسی می‌توانید جستجوی اینترنتی انجام دهید.
- 🔍 **پشتیبانی از موتورهای جستجوی متعدد**: از موتورهای جستجوی Bing، Quark، Baidu، Sogou و دیگر موتورهای اصلی پشتیبانی می‌کند تا تنوع منابع اطلاعاتی افزایش یابد.
- 🤖 **شناسایی نیت**: سیستم می‌تواند بر اساس محتوای ورودی کاربر، به طور خودکار تشخیص دهد که آیا باید جستجوی اینترنتی انجام شود یا آدرس URL را تجزیه کند.
- 🔄 **تقسیم‌بندی پرس‌وجو**: بر اساس نیت جستجوی کاربر، پرس‌وجو را به طور خودکار به چندین زیرکار تقسیم و به ترتیب اجرا می‌کند تا ارتباط و کارایی جستجو افزایش یابد.
- ⚙️ **معماری عامل هوشمند**: بر پایه **LangGraph**، مؤلفه‌های **«web_search»** و **«link_parser»** بسته‌بندی شده‌اند.
- 🏃‍♂️ **پردازش وظایف همزمان و غیرهمگام**: از پردازش وظایف همزمان و غیرهمگام پشتیبانی می‌کند تا چندین وظیفه جستجو را به طور مؤثر مدیریت کند.
- 📝 **بهینه‌سازی پردازش محتوا**:

  - ✂️ **برش محتوا**: محتوای طولانی صفحات وب را به بخش‌های جداگانه تقسیم می‌کند.

  - 🔄 **بازآرایی محتوا**: با بازچینی هوشمند، ارتباط اطلاعات را افزایش می‌دهد.

  - 🚫 **فیلتر محتوا**: به طور خودکار محتوای غیرمرتبط یا تکراری را حذف می‌کند.
- 🌐 **پشتیبانی چندسکویی**:
  - 🐳 **پشتیبانی از استقرار Docker**: راه‌اندازی با یک کلیک، ساخت سریع سرویس بک‌اند.

  - 🖥️ ارائه رابط بک‌اند FastAPI، قابل ادغام در هر سیستمی.

  - 🌍 ارائه رابط وب Gradio، قابل استقرار سریع به عنوان برنامه دیداری.

  - 🧩[ **پشتیبانی افزونه مرورگر**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): پشتیبانی از Edge، ارائه افزونه هوشمند تجزیه URL، ارسال مستقیم درخواست تجزیه صفحات و استخراج محتوا در مرورگر.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ شروع سریع

### کلون کردن مخزن

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### نصب وابستگی‌ها

```
pip install -r requirements.txt
python -m playwright install
```

### پیکربندی متغیرهای محیطی

```
# 百炼llm
OPENAI_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
OPENAI_API_KEY=sk-xxx
MODEL_NAME=qwen-plus-latest

# 百炼embedding
EMBEDDING_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
EMBEDDING_API_KEY=sk-xxx
EMBEDDING_MODEL_NAME=text-embedding-v4

# 百炼reranker
RERANK_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
RERANK_API_KEY=sk-xxx
RERANK_MODEL=gte-rerank-v2
```

### Langgraph-Agent

#### دمو

```shell
python agent/demo.py
```

#### سرویس‌دهی API

```shell
python agent/api_serve.py
```

```python
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气",
  "engine": "bing",
  "split": {
    "chunk_size": 512,
    "chunk_overlap": 128
  },
  "rerank": {
    "top_k": 5
  }
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

#### گریدیو

```
python agent/gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

#### docker

```
docker-compose -f docker-compose-ag.yml up -d --build
```

### Langgrph-MCP

#### راه‌اندازی سرویس MCP

```
python mcp/websearch.py
```

#### دمو

```
python mcp/demo.py
```

#### ارائه API

```
python mcp/api_serve.py
```

```
import requests

url = "http://localhost:8800/search"

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

#### داکر

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### ماژول سفارشی

#### تقسیم‌بندی سفارشی

```
from typing import Optional, List

class YourSplitter:
    def __init__(self, text: str, chunk_size: int = 512, chunk_overlap: int = 128):
        self.text = text
        self.chunk_size = chunk_size
        self.chunk_overlap = chunk_overlap

    def split_text(self, text: Optional[str] = None) -> List:
        # TODO: implement splitting logic
        return ["your chunk"]
```

#### بازچینش سفارشی

```
from typing import List, Union, Tuple

class YourReranker:
    async def get_reranked_documents(
        self,
        query: Union[str, List[str]],
        documents: List[str],
    ) -> Union[
        Tuple[List[str]],
        Tuple[List[int]],
    ]:
        return ["your chunk"], ["chunk index"]
```

## 🔍 مقایسه با آزمون‌های جستجوی آنلاین

ما پروژه را با برخی از APIهای آنلاین اصلی مقایسه کردیم و عملکرد آن را در مسائل پیچیده ارزیابی نمودیم.

### 🔥 مجموعه داده

- مجموعه داده از [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) که توسط علی منتشر شده، گرفته شده است و شامل ۶۸۰ سوال دشوار است که حوزه‌های آموزش، کنفرانس‌های علمی، بازی و غیره را پوشش می‌دهد.
- مجموعه داده شامل سوالات به زبان چینی و انگلیسی است.

### 🧑‍🏫 نتایج مقایسه

| موتور جستجو/سیستم  | ✅ درست | ❌ نادرست | ⚠️ تا حدودی درست |
| ------------------ | ------- | -------- | --------------- |
| **آتش‌فشان فنگ‌ژو** | ۵.۰۰٪   | ۷۲.۲۱٪   | ۲۲.۷۹٪          |
| **بای‌لیان**       | ۹.۸۵٪   | ۶۲.۷۹٪   | ۲۷.۳۵٪          |
| **ما**             | ۱۹.۸۵٪  | ۴۷.۹۴٪   | ۳۲.۰۶٪          |
## 🙏 تقدیر و تشکر

برخی از قابلیت‌های این پروژه مرهون پشتیبانی و الهام از پروژه‌های متن‌باز زیر است؛ بدین وسیله تشکر می‌نماییم:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): برای ساخت چارچوب زنجیره عامل‌های ماژولار، که به راه‌اندازی سریع سامانه‌های عامل پیچیده کمک می‌کند.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): ابزار قدرتمند برای تجزیه و تحلیل محتوای صفحات وب، جهت کمک به استخراج داده و خزیدن موثر صفحات وب.
- 🌐 [Playwright](https://github.com/microsoft/playwright): ابزار مدرن خودکارسازی مرورگر که پشتیبان خزیدن صفحات وب و تست خودکار بین مرورگری است.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): برای ساخت MCP چند زنجیره‌ای.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---