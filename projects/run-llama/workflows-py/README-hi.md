# LlamaIndex वर्कफ़्लोज़

[![यूनिट टेस्टिंग](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![कवरेज स्थिति](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub योगदानकर्ता](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - डाउनलोड्स](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex वर्कफ़्लोज़ एक ऐसा ढांचा है जो जटिल स्टेप्स और इवेंट्स की प्रणालियों को ऑर्केस्ट्रेट और चेन करने के लिए बनाया गया है।

## वर्कफ़्लोज़ से आप क्या बना सकते हैं?

वर्कफ़्लोज़ तब सबसे अधिक उपयोगी होते हैं जब आपको AI मॉडल्स, API और डिसीजन-मेकिंग को शामिल करने वाली जटिल, बहु-चरणीय प्रक्रियाओं का ऑर्केस्ट्रेशन करना होता है। यहाँ कुछ उदाहरण दिए गए हैं कि आप क्या बना सकते हैं:

- **AI एजेंट्स** - ऐसे बुद्धिमान सिस्टम बनाएं जो तर्क कर सकें, निर्णय ले सकें, और कई चरणों में कार्य कर सकें
- **डॉक्युमेंट प्रोसेसिंग पाइपलाइंस** - ऐसे सिस्टम बनाएं जो दस्तावेज़ों को इनजेस्ट, विश्लेषण, संक्षेप और विभिन्न प्रोसेसिंग चरणों के माध्यम से रूट कर सकें
- **मल्टी-मॉडल AI एप्लिकेशन** - विभिन्न AI मॉडल्स (LLMs, विज़न मॉडल्स आदि) के बीच समन्वय कर जटिल कार्यों को हल करें
- **रिसर्च असिस्टेंट्स** - ऐसे वर्कफ़्लोज़ विकसित करें जो खोज, विश्लेषण, सिंथेसाइज कर सकें और व्यापक उत्तर प्रदान करें
- **सामग्री जनरेशन सिस्टम** - ऐसे पाइपलाइंस बनाएं जो सामग्री उत्पन्न, समीक्षा, संपादित और मानव-अनुमोदन के साथ प्रकाशित कर सकें
- **कस्टमर सपोर्ट ऑटोमेशन** - ऐसे बुद्धिमान रूटिंग सिस्टम बनाएं जो ग्राहक की पूछताछ को समझ, वर्गीकृत और उत्तर दे सकें

असिंक्रोनस-फर्स्ट, इवेंट-ड्रिवन आर्किटेक्चर के कारण आप ऐसे वर्कफ़्लोज़ आसानी से बना सकते हैं जो विभिन्न क्षमताओं के बीच रूट कर सकते हैं, पैरेलल प्रोसेसिंग पैटर्न लागू कर सकते हैं, जटिल अनुक्रमों पर लूप कर सकते हैं, और कई चरणों में स्टेट को बनाए रख सकते हैं - ये सभी फीचर्स आपकी AI एप्लिकेशंस को प्रोडक्शन-रेडी बनाने के लिए आवश्यक हैं।
## मुख्य विशेषताएँ

- **async-first** - वर्कफ़्लो python की async कार्यक्षमता के इर्द-गिर्द बनाए गए हैं - स्टेप्स async फ़ंक्शन होते हैं जो asyncio queue से आने वाली events को प्रोसेस करते हैं और नई events को अन्य queues में भेजते हैं। इसका मतलब यह भी है कि वर्कफ़्लो आपके async ऐप्स जैसे FastAPI, Jupyter Notebooks आदि में सबसे अच्छा काम करते हैं।
- **event-driven** - वर्कफ़्लो steps और events से मिलकर बने होते हैं। अपने कोड को events और steps के इर्द-गिर्द व्यवस्थित करने से उसे समझना और टेस्ट करना आसान हो जाता है।
- **state management** - वर्कफ़्लो का प्रत्येक रन स्व-निहित होता है, यानी आप एक वर्कफ़्लो शुरू कर सकते हैं, उसमें जानकारी सहेज सकते हैं, वर्कफ़्लो की स्थिति को serialize कर सकते हैं और बाद में उसे फिर से शुरू कर सकते हैं।
- **observability** - वर्कफ़्लो अपने आप observability के लिए instrumented होते हैं, यानी आप `Arize Phoenix` और `OpenTelemetry` जैसे टूल्स को तुरंत उपयोग कर सकते हैं।

## त्वरित प्रारंभ

पैकेज इंस्टॉल करें:

```bash
pip install llama-index-workflows
```

और अपना पहला वर्कफ़्लो बनाएं:

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
# [वैकल्पिक] वर्कफ़्लो को एक संदर्भ ऑब्जेक्ट प्रदान करें
ctx = Context(workflow)
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

# उसी संदर्भ के साथ फिर से चलाने पर स्थिति बनी रहेगी
result = await workflow.run(input_msg="Hello, world!", ctx=ctx)
print("Workflow result:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

ऊपर दिए गए उदाहरण में
- वे स्टेप्स जो `StartEvent` स्वीकार करते हैं, सबसे पहले चलेंगे।
- वे स्टेप्स जो `StopEvent` लौटाते हैं, वर्कफ़्लो को समाप्त कर देंगे।
- मध्यवर्ती इवेंट्स उपयोगकर्ता द्वारा परिभाषित होते हैं और इन्हें स्टेप्स के बीच जानकारी पास करने के लिए उपयोग किया जा सकता है।
- `Context` ऑब्जेक्ट का उपयोग भी स्टेप्स के बीच जानकारी साझा करने के लिए किया जाता है।

`llama-index` का उपयोग करने वाले और अधिक उदाहरणों के लिए [पूर्ण प्रलेखन](https://docs.llamaindex.ai/en/stable/understanding/workflows/) देखें!
## और उदाहरण

- [बेसिक फीचर रन-थ्रू](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [`llama-index` के साथ एक फंक्शन कॉलिंग एजेंट बनाना](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- मानव-इन-द-लूप पुनरावृत्त दस्तावेज़ निष्कर्षण
  - [OpenTelemetry + इंस्ट्रुमेंटेशन प्राइमर](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [OpenTelemetry + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## संबंधित पैकेज

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---