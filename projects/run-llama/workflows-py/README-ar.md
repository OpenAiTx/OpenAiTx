# سير عمل LlamaIndex

[![اختبار الوحدات](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![حالة التغطية](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![مساهمو GitHub](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)

[![تنزيلات PyPI](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![ديسكورد](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![تويتر](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![ريديت](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

سير عمل LlamaIndex هو إطار عمل لتنظيم وربط أنظمة معقدة من الخطوات والأحداث معًا.

## ماذا يمكنك أن تبني باستخدام سير العمل؟

يتميز سير العمل عندما تحتاج إلى تنظيم عمليات متعددة الخطوات ومعقدة تتضمن نماذج الذكاء الاصطناعي وواجهات برمجة التطبيقات واتخاذ القرار. فيما يلي بعض الأمثلة على ما يمكنك بناؤه:

- **وكلاء الذكاء الاصطناعي** - إنشاء أنظمة ذكية يمكنها الاستنتاج واتخاذ القرارات وتنفيذ الإجراءات عبر خطوات متعددة
- **خطوط معالجة المستندات** - بناء أنظمة تستوعب وتحلل وتلخص وتوجه المستندات عبر مراحل معالجة مختلفة
- **تطبيقات الذكاء الاصطناعي متعددة النماذج** - التنسيق بين نماذج ذكاء اصطناعي مختلفة (نماذج اللغة الكبيرة، نماذج الرؤية، إلخ) لحل مهام معقدة
- **مساعدو البحث** - تطوير سير عمل يمكنه البحث والتحليل وتوليف المعلومات وتقديم إجابات شاملة
- **أنظمة توليد المحتوى** - إنشاء خطوط عمل لإنتاج ومراجعة وتحرير ونشر المحتوى مع وجود موافقة بشرية في الحلقة
- **أتمتة دعم العملاء** - بناء أنظمة توجيه ذكية يمكنها فهم وتصنيف والرد على استفسارات العملاء

تجعل بنية العمل المعتمدة على الأحداث والتزامن السهل من بناء سير عمل يمكنه التوجيه بين قدرات مختلفة، وتنفيذ أنماط المعالجة المتوازية، والتكرار عبر تسلسلات معقدة، والحفاظ على الحالة عبر خطوات متعددة - كل الميزات التي تحتاجها لجعل تطبيقات الذكاء الاصطناعي الخاصة بك جاهزة للإنتاج.
## الميزات الرئيسية

- **البرمجة غير المتزامنة أولاً (async-first)** - يتم بناء سير العمل حول وظائف بايثون غير المتزامنة (async) - الخطوات هي دوال غير متزامنة تعالج الأحداث الواردة من قائمة انتظار asyncio وتصدر أحداثًا جديدة إلى قوائم انتظار أخرى. هذا يعني أيضًا أن سير العمل يعمل بشكل أفضل في تطبيقاتك غير المتزامنة مثل FastAPI ودفاتر Jupyter وغيرها.
- **مدفوع بالأحداث (event-driven)** - يتكون سير العمل من خطوات وأحداث. تنظيم الكود الخاص بك حول الأحداث والخطوات يجعل من السهل فهمه واختباره.
- **إدارة الحالة (state management)** - كل تشغيل لسير العمل مستقل بذاته، مما يعني أنه يمكنك تشغيل سير عمل، حفظ المعلومات بداخله، تسلسل حالة سير العمل واستئنافها لاحقًا.
- **قابلية الرصد (observability)** - يتم تجهيز سير العمل تلقائيًا لقابلية الرصد، مما يعني أنه يمكنك استخدام أدوات مثل `Arize Phoenix` و `OpenTelemetry` مباشرة دون إعداد إضافي.

## البدء السريع

قم بتثبيت الحزمة:

```bash
pip install llama-index-workflows
```

وأنشئ أول سير عمل لك:

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
    # [اختياري] توفير كائن السياق إلى سير العمل
    ctx = Context(workflow)
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("نتيجة سير العمل:", result)

    # إعادة التشغيل بنفس السياق سيحتفظ بالحالة
    result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
    print("نتيجة سير العمل:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

في المثال أعلاه
- الخطوات التي تقبل `StartEvent` سيتم تشغيلها أولاً.
- الخطوات التي تُرجع `StopEvent` ستُنهي سير العمل.
- الأحداث الوسيطة يحددها المستخدم ويمكن استخدامها لنقل المعلومات بين الخطوات.
- يُستخدم كائن `Context` أيضًا لمشاركة المعلومات بين الخطوات.

قم بزيارة [التوثيق الكامل](https://docs.llamaindex.ai/en/stable/understanding/workflows/) لمزيد من الأمثلة باستخدام `llama-index`!

## المزيد من الأمثلة

- [استعراض الميزات الأساسية](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [بناء وكيل استدعاء الدوال باستخدام `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [استخراج المستندات التكراري بمشاركة الإنسان في الحلقة](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- قابلية الملاحظة
  - [مقدمة عن OpenTelemetry + الأدوات](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## الحزم ذات الصلة

- [مهام العمل Typescript](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---