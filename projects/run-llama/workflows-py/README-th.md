# LlamaIndex Workflows

[![Unit Testing](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Coverage Status](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub contributors](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - Downloads](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex Workflows เป็นเฟรมเวิร์กสำหรับการจัดลำดับและเชื่อมโยงระบบที่ซับซ้อนของขั้นตอนและเหตุการณ์เข้าด้วยกัน

## คุณสามารถสร้างอะไรกับ Workflows ได้บ้าง?

Workflows โดดเด่นเมื่อคุณต้องการจัดลำดับกระบวนการที่ซับซ้อนหลายขั้นตอนซึ่งเกี่ยวข้องกับโมเดล AI, API และการตัดสินใจ ตัวอย่างเช่นสิ่งที่คุณสามารถสร้างได้มีดังนี้:

- **AI Agents** - สร้างระบบอัจฉริยะที่สามารถให้เหตุผล ตัดสินใจ และดำเนินการต่าง ๆ ได้ในหลายขั้นตอน
- **Document Processing Pipelines** - สร้างระบบที่รับเข้า วิเคราะห์ สรุป และส่งต่อเอกสารผ่านหลายขั้นตอนการประมวลผล
- **Multi-Model AI Applications** - ประสานงานระหว่างโมเดล AI ต่าง ๆ (LLMs, vision models ฯลฯ) เพื่อแก้ไขงานที่ซับซ้อน
- **Research Assistants** - พัฒนา workflows ที่สามารถค้นหา วิเคราะห์ สังเคราะห์ข้อมูล และให้คำตอบที่ครอบคลุม
- **Content Generation Systems** - สร้าง pipeline ที่สร้าง ทบทวน แก้ไข และเผยแพร่เนื้อหาพร้อมการอนุมัติจากมนุษย์ในวงจร
- **Customer Support Automation** - สร้างระบบการจัดเส้นทางอัจฉริยะที่สามารถเข้าใจ จัดหมวดหมู่ และตอบสนองต่อคำถามของลูกค้า

สถาปัตยกรรมแบบ async-first และ event-driven นี้ ทำให้ง่ายต่อการสร้าง workflows ที่สามารถสลับการทำงานระหว่างความสามารถต่าง ๆ, ใช้รูปแบบการประมวลผลแบบขนาน, วนซ้ำตามลำดับที่ซับซ้อน, และคงสถานะข้ามหลายขั้นตอน — ครบทุกฟีเจอร์ที่คุณต้องการเพื่อให้แอปพลิเคชัน AI ของคุณพร้อมใช้งานในระดับ production
## คุณสมบัติเด่น

- **async-first** - เวิร์กโฟลว์ถูกสร้างขึ้นโดยอิงกับฟังก์ชัน async ของ Python - แต่ละขั้นตอนเป็นฟังก์ชัน async ที่ประมวลผลอีเวนต์ขาเข้าจากคิว asyncio และส่งอีเวนต์ใหม่ไปยังคิวอื่นๆ ซึ่งหมายความว่าเวิร์กโฟลว์จะทำงานได้ดีที่สุดในแอป async ของคุณ เช่น FastAPI, Jupyter Notebooks ฯลฯ
- **event-driven** - เวิร์กโฟลว์ประกอบด้วยขั้นตอนและอีเวนต์ การจัดระเบียบโค้ดของคุณโดยอิงกับอีเวนต์และขั้นตอนทำให้ง่ายต่อการทำความเข้าใจและทดสอบ
- **state management** - การรันแต่ละครั้งของเวิร์กโฟลว์จะแยกออกจากกันโดยสมบูรณ์ หมายความว่าคุณสามารถเริ่มเวิร์กโฟลว์ บันทึกข้อมูลภายในเวิร์กโฟลว์นั้น ทำการ serialize สถานะของเวิร์กโฟลว์ และกลับมาทำงานต่อในภายหลังได้
- **observability** - เวิร์กโฟลว์จะถูกติดตั้งเครื่องมือสำหรับตรวจสอบสภาพการทำงานโดยอัตโนมัติ คุณจึงสามารถใช้เครื่องมืออย่าง `Arize Phoenix` และ `OpenTelemetry` ได้ทันที

## เริ่มต้นอย่างรวดเร็ว

ติดตั้งแพ็กเกจ:

```bash
pip install llama-index-workflows
```

และสร้างเวิร์กโฟลว์แรกของคุณ:

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
```
# [optional] ให้ context object กับ workflow
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

# การรันซ้ำด้วย context เดิมจะคงสถานะไว้
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

ในตัวอย่างข้างต้น
- ขั้นตอนที่รับ `StartEvent` จะถูกรันก่อน
- ขั้นตอนที่คืนค่า `StopEvent` จะจบ workflow
- เหตุการณ์กลางเป็นเหตุการณ์ที่ผู้ใช้กำหนดเอง และสามารถใช้ถ่ายทอดข้อมูลระหว่างขั้นตอนได้
- วัตถุ `Context` ก็ถูกใช้เพื่อแบ่งปันข้อมูลระหว่างขั้นตอนเช่นกัน

เยี่ยมชม [เอกสารประกอบฉบับเต็ม](https://docs.llamaindex.ai/en/stable/understanding/workflows/) สำหรับตัวอย่างเพิ่มเติมที่ใช้ `llama-index`!

## ตัวอย่างเพิ่มเติม

- [การสาธิตฟีเจอร์พื้นฐาน](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [การสร้างเอเจนต์เรียกใช้ฟังก์ชันด้วย `llama-index`](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- [การสกัดเอกสารแบบวนรอบโดยมนุษย์ร่วมในกระบวนการ](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/document_processing.ipynb)
- Observability
  - [OpenTelemetry + แนะนำการใช้เครื่องมืออินสตรูเมนต์](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## แพ็กเกจที่เกี่ยวข้อง

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---