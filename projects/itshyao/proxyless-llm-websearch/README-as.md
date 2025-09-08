<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# 🧠 প্ৰক্সি নোহোৱা LLM ৱেব অনুসন্ধান ইঞ্জিন

এটা প্ৰক্সি নোহোৱা বহুবিধ অনুসন্ধান ইঞ্জিন LLM ৱেব অনুসন্ধান সঁজুলি, যি URL সমল বিশ্লেষণ আৰু ৱেবপৃষ্ঠা স্ক্ৰলিং সমৰ্থন কৰে, **LangGraph** আৰু **LangGraph-MCP**-ৰ সংযোগে মডুলাৰ ইন্টেলিজেন্ট চেইন ব্যৱস্থা প্ৰদান কৰে। বৃহৎ ভাষা মডেলৰ বাহ্যিক জ্ঞান আহৰণৰ ক্ষেত্ৰত ব্যৱহাৰৰ বাবে বিশেষ ৰূপে ডিজাইন কৰা, **Playwright + Crawl4AI**-ৰ সহায়ত ৱেব সমল আহৰণ আৰু বিশ্লেষণ সমৰ্থন কৰে, একেসময়ত একাধিক অনুৰোধ, সমল টুকুৰা আৰু পুনঃবিন্যাস ফিল্টাৰ সমৰ্থন কৰে।

## 🚀 আপডেট লগ

- 🔥 ২০২৫-০৯-০৫: **langgraph-mcp** সমৰ্থন যোগ কৰা হ'ল
- 🔥 ২০২৫-০৯-০৩: নতুনকৈ Docker ব্যৱস্থা, অন্তৰ্ভুক্ত ইন্টেলিজেন্ট পুনঃবিন্যাসক, কাষ্টম টেক্সট টুকুৰা আৰু পুনঃবিন্যাসক সমৰ্থন

## ✨ বৈশিষ্ট্যৰ সংক্ষিপ্ত তালিকা

- 🌐 **প্ৰক্সি বিচাৰি কাম নহয়**: Playwright কনফিগাৰেশ্যনযোগে দেশীয় ব্ৰাউজাৰ সমৰ্থন, প্ৰক্সি নোহোৱাকৈয়ো ৱেব অনুসন্ধান কৰিব পাৰি।
- 🔍 **বহু অনুসন্ধান ইঞ্জিন সমৰ্থন**: Bing, Quark, Baidu, Sogou আদি প্ৰধান অনুসন্ধান ইঞ্জিনসমূহ সমৰ্থিত, তথ্য উৎসৰ বৈচিত্ৰতা বৃদ্ধি কৰে।
- 🤖 **উদ্দেশ্য চিনাক্তকৰণ**: ব্যৱহাৰকাৰীৰ ইনপুট অনুসৰি, স্বয়ংক্ৰিয়ভাৱে ৱেব অনুসন্ধান নে URL বিশ্লেষণ কৰিব লাগে তাৰ সিদ্ধান্ত গ্ৰহণ কৰে।
- 🔄 **প্ৰশ্ন বিভাজন**: ব্যৱহাৰকাৰীৰ অনুসন্ধান উদ্দেশ্য অনুসৰি, প্ৰশ্নক একাধিক উপ-কাৰ্যত বিভাজন কৰি, পৰ্যায়ক্রমে সম্পাদন কৰে, ফলত অনুসন্ধান সম্পৰ্কীয়তা আৰু কাৰ্যক্ষমতা বৃদ্ধি পায়।
- ⚙️ **ইন্টেলিজেন্ট এজেন্ট স্থাপত্য**: **LangGraph** ভিত্তিত সংযোজিত **"web_search"** আৰু **"link_parser"**।
- 🏃‍♂️ **অ্যাসিংক্ৰোনাছ সমান্তৰাল কাৰ্য প্ৰক্ৰিয়া**: অ্যাসিংক্ৰোনাছ সমান্তৰাল কাৰ্য সমৰ্থিত, বহু অনুসন্ধান কাৰ্য দক্ষতাৰে সম্পাদন কৰিব পাৰি।
- 📝 **সামগ্ৰী প্ৰক্ৰিয়াকৰণ উন্নতকৰণ**:

  - ✂️ **সামগ্ৰী খণ্ডন**: ৱেবপৃষ্ঠা দীঘলীয়া অংশসমূহ পৰ্যায়ভাগে বিভাজন কৰে।

  - 🔄 **সামগ্ৰী পুনৰবিন্যাস**: বুদ্ধিমত্তাৰে পুনৰবিন্যাস, তথ্য সম্পৰ্কীয়তা বৃদ্ধি কৰে।

  - 🚫 **সামগ্ৰী পৰিস্কাৰ**: অনুপযুক্ত বা পুনৰাবৃত্ত সামগ্ৰী স্বয়ংক্ৰিয়ভাৱে বেছি পেলায়।
- 🌐 **বহুমুখী প্লাটফৰ্ম সমৰ্থন**:
  - 🐳 **Docker স্থাপনা সমৰ্থিত**: এক ক্লিকে আৰম্ভ, দ্রুত backend সেৱা গঠন।

  - 🖥️ FastAPI backend ইণ্টাৰফেছ উপলব্ধ, যিকোনো ব্যৱস্থাত সংযোজন কৰিব পাৰি।

  - 🌍 Gradio Web UI উপলব্ধ, দ্রুত ভিজুৱেলাইজড এপ্লিকেশ্যন ৰূপে স্থাপন কৰিব পাৰি।

  - 🧩[ **ব্ৰাউজাৰ প্লাগইন সমৰ্থন**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge সমৰ্থিত, বুদ্ধিমত্তা URL বিশ্লেষণ প্লাগইন, ব্ৰাউজাৰত সোজাসুজি ৱেব বিশ্লেষণ আৰু সামগ্ৰী আহৰণ অনুৰোধ প্ৰেৰণ কৰিব পাৰি।


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ তৎকাল আৰম্ভণি

### ৰিপজিটৰি ক্লোন কৰক

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### নিৰ্ভৰশীলতা স্থাপন কৰক

```
pip install -r requirements.txt
python -m playwright install
```

### পৰিৱেশ পৰিৱৰ্তনশীল সংৰূপণ

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

### Langgraph-এজেন্ট

#### ডেম’

```shell
python agent/demo.py
```

#### API SERVE

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

#### গ্ৰাডিঅ’

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

#### MCP সেৱা আৰম্ভ কৰক

```
python mcp/websearch.py
```

#### ডেম'

```
python mcp/demo.py
```

#### API SERVE

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

#### ডকৰ

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### কাষ্টম মডিউল

#### কাষ্টম ব্লক বিভাজন

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

#### কাষ্টম পুনৰ-বিন্যাস

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

## 🔍 অনলাইন নেটৱৰ্ক সন্ধান পৰীক্ষাৰ সৈতে তুলনা

আমাৰো প্ৰকল্পক কিছুমান মুখ্য অনলাইন API ৰ সৈতে তুলনা কৰা হৈছে, আৰু ইয়াৰ জটিল সমস্যাৰ ক্ষেত্ৰত কাৰ্যক্ষমতা মূল্যায়ন কৰা হৈছে।

### 🔥 ডেটাচেট

- ডেটাচেট আহিল আলীয়ে প্ৰকাশ কৰা [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) ৰ পৰা, য'ত ৬৮০ টা উচ্চ-জটিলতা প্রশ্ন আছে, শিক্ষা, একাডেমিক সম্মিলনী, গেম আদিত ক্ষেত্ৰত আচ্ছাদিত।
- ডেটাচেটত চীন আৰু ইংৰাজী দুয়ো ভাষাৰ প্রশ্ন আছে।

### 🧑‍🏫 তুলনাৰ ফলাফল

| সন্ধান ইঞ্জিন/চিস্টেম   | ✅ সঠিক | ❌ ভুল | ⚠️ আংশিক সঠিক |
| --------------------- | ------- | ------ | -------------- |
| **ভলকান আর্ক**        | ৫.০০%   | ৭২.২১% | ২২.৭৯%         |
| **বৈলিয়ান**          | ৯.৮৫%   | ৬২.৭৯% | ২৭.৩৫%         |
| **আমাৰ**              | ১৯.৮৫%  | ৪৭.৯৪% | ৩২.০৬%         |
## 🙏 কৃতজ্ঞতা

এই প্ৰকল্পৰ কিছু ফিচাৰ তলত উল্লেখ কৰা কিছুমান মুক্ত উৎস প্ৰকল্পৰ সহায় আৰু অনুপ্ৰেৰণা ৰ পৰা লাভ হৈছে, তাৰ বাবে কৃতজ্ঞতা জ্ঞাপন।

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): মডুলাৰ ইন্টেলিজেন্ট চেইন ফ্রেমৱৰ্ক নিৰ্মাণৰ বাবে, জটিল ইন্টেলিজেন্ট চিস্টেম দ্রুত গঢ়ি তুলিবলৈ সহায়।
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): শক্তিশালী ৱেব কন্টেন্ট বিশ্লেষণ টুল, উচ্চ কার্যক্ষম ৱেব স্ক্ৰ্যাপিং আৰু ডেটা নিষ্কাশনৰ সহায়।
- 🌐 [Playwright](https://github.com/microsoft/playwright): আধুনিক ব্ৰাউজাৰ অটোমেশন টুল, বহু-ব্ৰাউজাৰ ৱেব স্ক্ৰ্যাপিং আৰু টেষ্ট অটোমেশ্যন সমৰ্থন।
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): বহু চেইন প্ৰক্ৰিয়াৰ MCP নিৰ্মাণৰ বাবে ব্যৱহৃত।



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---