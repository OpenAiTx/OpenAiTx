# جریان‌های کاری LlamaIndex

[![تست واحد](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![وضعیت پوشش](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![مشارکت‌کنندگان GitHub](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)

[![PyPI - دانلودها](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![دیسکورد](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![توییتر](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![ردیت](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

جریان‌های کاری LlamaIndex یک چارچوب برای سازمان‌دهی و زنجیره‌سازی سیستم‌های پیچیده‌ای از مراحل و رویدادها هستند.

## با جریان‌های کاری چه چیزی می‌توانید بسازید؟

جریان‌های کاری زمانی می‌درخشند که نیاز به سازمان‌دهی فرآیندهای پیچیده و چندمرحله‌ای دارید که شامل مدل‌های هوش مصنوعی، APIها و تصمیم‌گیری می‌شوند. در اینجا چند نمونه از مواردی که می‌توانید بسازید آورده شده است:

- **عوامل هوش مصنوعی** - ساخت سیستم‌های هوشمندی که می‌توانند استدلال کنند، تصمیم بگیرند و در چندین مرحله اقدام انجام دهند
- **خطوط لوله پردازش اسناد** - ساخت سیستم‌هایی که اسناد را دریافت، تحلیل، خلاصه و از مراحل پردازشی مختلف عبور می‌دهند
- **برنامه‌های هوش مصنوعی چندمدلی** - هماهنگی بین مدل‌های مختلف هوش مصنوعی (مدل‌های زبانی بزرگ، مدل‌های بینایی و غیره) برای حل وظایف پیچیده
- **دستیاران پژوهشی** - توسعه جریان‌های کاری که می‌توانند جستجو، تحلیل، ترکیب اطلاعات و ارائه پاسخ‌های جامع را انجام دهند
- **سیستم‌های تولید محتوا** - ایجاد خطوط لوله‌ای که محتوا را تولید، بازبینی، ویرایش و با تأیید انسانی منتشر می‌کنند
- **اتوماسیون پشتیبانی مشتری** - ساخت سیستم‌های مسیریابی هوشمند که می‌توانند درخواست‌های مشتری را درک، دسته‌بندی و به آن‌ها پاسخ دهند

معماری مبتنی بر رویداد و اولویت‌دهی به عملیات ناهمزمان (async-first) این امکان را فراهم می‌کند که جریان‌های کاری بسازید که بتوانند بین قابلیت‌های مختلف مسیردهی کنند، الگوهای پردازش موازی را پیاده‌سازی کنند، بر دنباله‌های پیچیده حلقه بزنند و وضعیت را در چندین مرحله حفظ کنند - تمام ویژگی‌هایی که برای آماده‌سازی برنامه‌های هوش مصنوعی خود برای محیط عملیاتی نیاز دارید.
## ویژگی‌های کلیدی

- **اولویت با async** - گردش‌کارها بر اساس قابلیت async پایتون ساخته شده‌اند - مراحل به صورت توابع async هستند که رویدادهای ورودی را از یک صف asyncio پردازش می‌کنند و رویدادهای جدیدی را به صف‌های دیگر ارسال می‌نمایند. این همچنین به این معناست که گردش‌کارها بهترین عملکرد را در برنامه‌های async شما مانند FastAPI، Jupyter Notebooks و غیره دارند.
- **مبتنی بر رویداد** - گردش‌کارها از مراحل و رویدادها تشکیل شده‌اند. سازماندهی کد شما بر اساس رویدادها و مراحل باعث می‌شود درک و تست آن آسان‌تر شود.
- **مدیریت وضعیت** - هر اجرای یک گردش‌کار به صورت مستقل است، به این معنی که می‌توانید یک گردش‌کار را اجرا کنید، اطلاعات را در آن ذخیره نمایید، وضعیت گردش‌کار را سریال‌سازی کرده و بعداً ادامه دهید.
- **قابلیت مشاهده‌پذیری** - گردش‌کارها به طور خودکار برای مشاهده‌پذیری ابزارسازی شده‌اند، به این معنا که می‌توانید بلافاصله از ابزارهایی مانند `Arize Phoenix` و `OpenTelemetry` استفاده کنید.

## شروع سریع

بسته را نصب کنید:

```bash
pip install llama-index-workflows
```

و اولین گردش‌کار خود را ایجاد کنید:

```python
import asyncio
from pydantic import BaseModel, Field
from workflows import Context, Workflow, step
from workflows.events import Event, StartEvent, StopEvent

class MyEvent(Event):
    msg: list[str]

class RunState(BaseModel):
    num_runs: int = Field(default=0)

class MyWorkflow(Workflow):
    @step
    async def start(self, ctx: Context[RunState], ev: StartEvent) -> MyEvent:
        async with ctx.store.edit_state() as state:
            state.num_runs += 1

            return MyEvent(msg=[ev.input_msg] * state.num_runs)

    @step
    async def process(self, ctx: Context[RunState], ev: MyEvent) -> StopEvent:
        data_length = len("".join(ev.msg))
        new_msg = f"Processed {len(ev.msg)} times, data length: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```python
    # [اختیاری] یک شیء context به جریان کاری ارائه دهید
    ctx = Context(workflow)
    result = await workflow.run(input_msg="سلام، دنیا!", ctx=ctx)
    print("نتیجه جریان کاری:", result)

    # اجرای مجدد با همان context وضعیت را حفظ خواهد کرد
    result = await workflow.run(input_msg="سلام، دنیا!", ctx=ctx)
    print("نتیجه جریان کاری:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

در مثال بالا
- مراحلی که یک `StartEvent` را می‌پذیرند ابتدا اجرا خواهند شد.
- مراحلی که یک `StopEvent` بازمی‌گردانند جریان کاری را خاتمه می‌دهند.
- رویدادهای میانی توسط کاربر تعریف می‌شوند و می‌توانند برای انتقال اطلاعات بین مراحل استفاده شوند.
- شیء `Context` نیز برای به اشتراک‌گذاری اطلاعات بین مراحل استفاده می‌شود.

برای مثال‌های بیشتر از استفاده با `llama-index` [مستندات کامل](https://docs.llamaindex.ai/en/stable/understanding/workflows/) را مشاهده کنید!

## مثال‌های بیشتر

- [مرور ویژگی‌های پایه](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [ساخت یک عامل برای فراخوانی توابع با `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [استخراج سند به صورت تعاملی با حضور انسان در حلقه](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- قابلیت مشاهده‌پذیری
  - [مقدمه‌ای بر OpenTelemetry + ابزارسازی](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## بسته‌های مرتبط

- [Workflowهای Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---