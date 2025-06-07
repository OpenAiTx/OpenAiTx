<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="لوگوی LangChain" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![یادداشت‌های انتشار](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - License](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![نمودار ستاره‌های گیت‌هاب](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![مسائل باز](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![باز کردن در Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="باز کردن در Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![توییتر](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!توجه]
> به دنبال کتابخانه JS/TS هستید؟ به [LangChain.js](https://github.com/langchain-ai/langchainjs) مراجعه کنید.

LangChain یک چارچوب برای ساخت برنامه‌های مبتنی بر مدل‌های زبانی بزرگ (LLM) است. این ابزار به شما کمک می‌کند تا اجزای قابل همکاری و ادغام‌های شخص ثالث را به هم متصل کنید تا توسعه برنامه‌های هوش مصنوعی را ساده‌تر نمایید — و در عین حال تصمیمات خود را در مقابل تغییرات فناوری پایه، آینده‌نگرانه کنید.

```bash
pip install -U langchain
```

برای آشنایی بیشتر با LangChain، به 
[مستندات](https://python.langchain.com/docs/introduction/) مراجعه کنید. اگر به دنبال سفارشی‌سازی پیشرفته‌تر یا ارکستراسیون ایجنت‌ها هستید، به 
[LangGraph](https://langchain-ai.github.io/langgraph/) سر بزنید، چارچوب ما برای ساخت جریان‌های کاری ایجنت قابل کنترل.

## چرا از LangChain استفاده کنیم؟

LangChain به توسعه‌دهندگان کمک می‌کند تا از طریق یک رابط استاندارد برای مدل‌ها، امبدینگ‌ها، ذخیره‌گاه‌های برداری و موارد دیگر، برنامه‌هایی مبتنی بر LLM بسازند. 

استفاده از LangChain برای:
- **افزایش داده‌های بلادرنگ**. اتصال ساده LLMها به منابع داده متنوع و سیستم‌های خارجی / داخلی، با بهره‌گیری از کتابخانه گسترده ادغام‌های LangChain با ارائه‌دهندگان مدل، ابزارها، ذخیره‌گاه‌های برداری، بازیاب‌ها و موارد دیگر.
- **قابلیت همکاری مدل‌ها**. تعویض مدل‌ها در زمان نیاز تیم مهندسی برای یافتن بهترین گزینه متناسب با نیازهای برنامه شما. با تغییر مرزهای صنعت، به سرعت سازگار شوید — انتزاعات LangChain به شما امکان می‌دهد بدون از دست دادن شتاب، حرکت کنید.

## اکوسیستم LangChain
در حالی که چارچوب LangChain می‌تواند به طور مستقل استفاده شود، همچنین با هر محصول LangChain یکپارچگی کامل دارد و به توسعه‌دهندگان مجموعه کاملی از ابزارها هنگام ساخت برنامه‌های LLM ارائه می‌دهد.

برای بهبود توسعه برنامه LLM خود، LangChain را با موارد زیر همراه کنید:

- [LangSmith](http://www.langchain.com/langsmith) - مفید برای ارزیابی ایجنت و مشاهده‌پذیری. اجرای برنامه‌های LLM با عملکرد ضعیف را اشکال‌زدایی کنید، مسیرهای ایجنت را ارزیابی کنید، در تولید دید پیدا کنید و عملکرد را به مرور زمان بهبود دهید.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - ایجنت‌هایی بسازید که بتوانند وظایف پیچیده را به طور قابل اعتماد مدیریت کنند با LangGraph، چارچوب ارکستراسیون ایجنت سطح پایین ما. LangGraph معماری قابل سفارشی‌سازی، حافظه بلندمدت و جریان‌های کاری انسان-در-حلقه ارائه می‌دهد — و در تولید توسط شرکت‌هایی مانند LinkedIn، Uber، Klarna و GitLab مورد اعتماد است.
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - ایجنت‌ها را به راحتی با پلتفرم استقرار ویژه برای جریان‌های کاری طولانی مدت و با حالت مقیاس‌بندی و استقرار دهید. ایجنت‌ها را در سراسر تیم‌ها کشف، استفاده مجدد، پیکربندی و به اشتراک بگذارید — و با نمونه‌سازی بصری در [LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/) به سرعت تکرار کنید.

## منابع تکمیلی
- [آموزش‌ها](https://python.langchain.com/docs/tutorials/): راهنمایی‌های ساده با مثال‌های عملی برای شروع کار با LangChain.
- [راهنماهای نحوه انجام](https://python.langchain.com/docs/how_to/): قطعه کدهای سریع و کاربردی برای موضوعاتی مانند فراخوانی ابزار، موارد کاربرد RAG و موارد دیگر.
- [راهنماهای مفهومی](https://python.langchain.com/docs/concepts/): توضیح مفاهیم کلیدی پشت چارچوب LangChain.
- [مراجع API](https://python.langchain.com/api_reference/): مرجع دقیق برای پیمایش بسته‌های پایه و ادغام‌ها برای LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---