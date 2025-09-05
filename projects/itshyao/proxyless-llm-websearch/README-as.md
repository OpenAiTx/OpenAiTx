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
# 🧠 প্ৰক্সি নালগাকৈ LLM ৱেব অনুসন্ধান ইঞ্জিন

এটা প্ৰক্সি নালগাকৈ বহুসন্ধান ইঞ্জিন LLM ৱেব সন্ধান সঁজুলি, URL সমল বিশ্লেষণ আৰু ৱেবপৃষ্ঠা স্ক্ৰাপিং সমৰ্থিত, **LangGraph** আৰু **LangGraph-MCP** সংযোগে মডুলাৰ ইন্টেলিজেন্ট চেইন ৰূপায়িত। ডাঙৰ ভাষা মডেলৰ বাহ্যিক জ্ঞান আহৰণৰ ক্ষেত্ৰত বিশেষকৈ ডিজাইন কৰা, **Playwright + Crawl4AI** ৱেবপৃষ্ঠা আহৰণ আৰু বিশ্লেষণ সমৰ্থিত, এছিঙ্ক্ৰনাস কনকাৰেন্সি, সমল টুকুৰা-বিভাজন আৰু পুনৰ বিন্যাস ফিল্টাৰ সমৰ্থিত।

## 🚀 আপডেট লগ

- 🔥 ২০২৫-০৯-০৫: **langgraph-mcp** সমৰ্থিত
- 🔥 ২০২৫-০৯-০৩: নতুন Docker ডিপ্লয়, অন্তৰ্ভুক্ত ইন্টেলিজেন্ট ৰিৰেংকাৰ, কাষ্টম টেক্সট স্লাইছাৰ আৰু ৰিৰেংকাৰ সমৰ্থিত

## ✨ বৈশিষ্ট্যৰ তালিকা

- 🌐 **প্ৰক্সি-ৰ প্ৰয়োজন নাই**: Playwright ৰ জৰিয়তে ভাৰতীয় ব্ৰাউজাৰ কনফিগাৰ কৰি, প্ৰক্সি নোহোৱাকৈও ৱেব চাৰ্চ কৰিব পাৰি।
- 🔍 **বহু সন্ধান ইঞ্জিনৰ সমৰ্থন**: Bing, Quark, Baidu, Sogou আদি মুখ্য সন্ধান ইঞ্জিনৰ সমৰ্থন, তথ্যৰ উৎসৰ বৈচিত্র্য বৃদ্ধি।
- 🤖 **উদ্দেশ্য চিনাক্তকৰণ**: ব্যৱস্থাই ব্যৱহাৰকাৰীৰ ইনপুটৰ আধাৰত, স্বয়ংক্ৰিয়ভাৱে নিৰ্ণয় কৰে ৱেব চাৰ্চ কৰিব নে URL বিশ্লেষণ।
- 🔄 **প্ৰশ্ন বিভাজন**: ব্যৱহাৰকাৰীৰ সন্ধান উদ্দেশ্য অনুসৰি, প্ৰশ্নক বহু উপ-কাৰ্যত বিভাজন কৰি, একে একে সম্পাদন কৰে, ফলত সন্ধানৰ প্ৰাসংগিকতা আৰু দক্ষতা বৃদ্ধি হয়।
- ⚙️ **বুদ্ধিমত্তা স্থাপত্য**: **LangGraph**-ৰ আধাৰত সিল কৰা **"web_search"** আৰু **"link_parser"**।
- 🏃‍♂️ **অ্যাসিঙ্ক্ৰ'নাস সমান্তৰাল কাৰ্য প্ৰক্ৰিয়া**: অ্যাসিঙ্ক্ৰ'নাস সমান্তৰাল কাৰ্য সমৰ্থন, বহুমান সন্ধান কাৰ্য দক্ষতাৰে প্ৰক্ৰিয়া কৰিব পাৰি।
- 📝 **বিষয়বস্তু প্ৰক্ৰিয়া উন্নয়ন**:

  - ✂️ **বিষয়বস্তু খণ্ডীকৰণ**: ৱেবপৃষ্ঠাৰ দীঘল বিষয়বস্তু ভাগ ভাগ কৰি।

  - 🔄 **বিষয়বস্তু পুনৰ বিন্যাস**: বুদ্ধিমত্তাৰে পুনৰ বিন্যাস, তথ্যৰ প্ৰাসংগিকতা বৃদ্ধি।

  - 🚫 **বিষয়বস্তু বাছনি**: অপ্রাসংগিক বা পুনৰাবৃত্ত বিষয়বস্তু স্বয়ংক্ৰিয়ভাৱে আঁতৰাই।
- 🌐 **বহুমুখী সমৰ্থন**:
  - 🐳 **Docker-ৰ দ্বাৰা সমৰ্থন**: এক-ক্লিক আৰম্ভ, পৃষ্ঠভাগ সেৱা সোনকালে নিৰ্মাণ।

  - 🖥️ FastAPI পৃষ্ঠভাগ ইণ্টাৰফেচ উপলব্ধ, যিকোনো ব্যৱস্থাত সংহত কৰিব পাৰি।

  - 🌍 Gradio Web UI উপলব্ধ, দ্ৰুত ভিজ্যুয়েলাইজড এপ্লিকেশ্যন হিচাপে স্থাপন কৰিব পাৰি।

  - 🧩[ **ব্ৰাউজাৰ প্লাগইন সমৰ্থন**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge-ৰ সমৰ্থন, বুদ্ধিমত্তা URL বিশ্লেষণ প্লাগইন, ব্ৰাউজাৰতেই ৱেব বিশ্লেষণ আৰু বিষয়বস্তু আহৰণ অনুৰোধ কৰিব পাৰি।


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ দ্ৰুত আৰম্ভ

### ৰিপ’জিটৰি ক্লোন কৰক

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

## 🔍 অনলাইন নেটৱৰ্ক সন্ধান পৰীক্ষাৰ তুলনাত

আমাৰ প্ৰকল্পটোক কিছুমান মুখ্য অনলাইন API ৰ সৈতে তুলনা কৰা হৈছে, জটিল সমস্যাৰ ক্ষেত্ৰত ইয়াৰ প্ৰদৰ্শন মূল্যায়ন কৰা হৈছে।

### 🔥 তথ্যসেট

- তথ্যসেট আহে আলি-এ প্ৰকাশ কৰা [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) ৰ পৰা, য'ত ৬৮০ টা উচ্চ-জটিলতাৰ প্ৰশ্ন আছে, শিক্ষা, শৈক্ষিক সম্মেলন, গেম আদিৰ বহু ক্ষেত্ৰত আচ্ছাদিত।
- তথ্যসেটত চীন আৰু ইংৰাজী ভাষাৰ প্ৰশ্ন আছে।

### 🧑‍🏫 তুলনামূলক ফলাফল

| সন্ধান ইঞ্জিন/প্ৰণালী  | ✅ শুদ্ধ | ❌ অশুদ্ধ | ⚠️ আংশিকভাবে শুদ্ধ |
| -------------- | --------- | ----------- | ------------------- |
| **ভলকান আর্ক**   | ৫.০০%     | ৭২.২১%      | ২২.৭৯%              |
| **বৈলিয়ান**       | ৯.৮৫%     | ৬২.৭৯%      | ২৭.৩৫%              |
| **আমাৰ** | ১৯.৮৫%    | ৪৭.৯৪%      | ৩২.০৬%              |
## 🙏 কৃতজ্ঞতা

এই প্ৰকল্পৰ কিছুমান ফিচাৰ তলত উল্লেখিত মুক্ত উৎস প্ৰকল্পসমূহৰ সহায় আৰু অনুপ্ৰেৰণা লাভ কৰিছে, তাৰ বাবে বিশেষ কৃতজ্ঞতা:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): মডুলাৰ ইন্টেলিজেন্ট চেইনৰ ফ্ৰেমৱৰ্ক নিৰ্মাণৰ বাবে, জটিল ইন্টেলিজেন্ট চিস্টেম দ্রুত গঢ়ি তুলিবলৈ সহায় কৰে।
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): শক্তিশালী ৱেব কন্টেন্ট বিশ্লেষণ টুল, দক্ষ ৱেব স্ক্ৰেপিং আৰু ডাটা এক্সট্ৰাকশনত সহায় কৰে।
- 🌐 [Playwright](https://github.com/microsoft/playwright): আধুনিক ব্ৰাউজাৰ অটোমেশ্যন টুল, ক্ৰছ-ব্ৰাউজাৰ ৱেব স্ক্ৰেপিং আৰু পৰীক্ষা অটোমেশ্যন সমৰ্থন কৰে।
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): বহু চেইন প্ৰক্ৰিয়াকৰণ MCP নিৰ্মাণৰ বাবে ব্যৱহৃত।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---