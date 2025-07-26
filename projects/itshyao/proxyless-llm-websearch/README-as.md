
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

# 🧠 প্ৰক্সী নালাগা LLM ৱেব চাৰ্চ ইঞ্জিন

এটা প্ৰক্সী নালাগা বহু-চাৰ্চ ইঞ্জিন LLM ৱেব সন্ধান সঁজুলি, যি URL সামগ্ৰী বিশ্লেষণ আৰু ৱেবপেজ স্ক্ৰেপিং সমৰ্থন কৰে, LangGraphৰ সৈতে সংযোগ কৰি মডুলাৰ ইন্টেলিজেন্ট এজেন্ট চেইন গঠন কৰে। বৃহৎ ভাষা মডেলৰ বাহ্যিক জ্ঞান আহৰণৰ ক্ষেত্ৰত বিশেষকৈ ডিজাইন কৰা, **Playwright + Crawl4AI** ৱেবপেজ লাভ আৰু বিশ্লেষণ সমৰ্থন কৰে, এছিঙ্ক্ৰোনাস কনকাৰেণ্ট, সামগ্ৰী চপিং আৰু পুনৰ-ব্যৱস্থা/ফিল্টাৰ সমৰ্থিত।

## ✨ বৈশিষ্ট্যৰ চমু পৰিচয়

- 🌐 **প্ৰক্সী নালাগে**: Playwright ব্যৱহাৰ কৰি দেশীয় ব্ৰাউজাৰৰ সহায়ত, প্ৰক্সী নালাগেও ৱেব চাৰ্চ কৰিব পাৰি।
- 🔍 **বহু চাৰ্চ ইঞ্জিন সমৰ্থন**: Bing, Quark, Baidu, Sogou আদি মুখ্য চাৰ্চ ইঞ্জিনসমূহ সমৰ্থিত, তথ্যৰ উৎসৰ বহুত্ব বৃদ্ধি।
- 🤖 **ইচ্ছা চিনাক্তকৰণ**: ব্যৱস্থাই ব্যৱহাৰকাৰীৰ ইনপুট সামগ্ৰীৰ আধাৰত স্বয়ংক্ৰিয়ভাৱে নিৰ্ধাৰণ কৰিব পাৰে, ৱেব চাৰ্চ কৰিব নে URL বিশ্লেষণ।
- 🔄 **কুয়েরি বিভাজন**: ব্যৱহাৰকাৰীৰ চাৰ্চ ইচ্ছাৰ ওপৰত আধাৰিতকৈ কুয়েরি একাধিক উপ-কাৰ্যত বিভক্ত কৰি, ক্ৰমে সম্পাদন, যাতে সন্ধানৰ সম্পৰ্কীয়তা আৰু দক্ষতা বৃদ্ধি পায়।
- ⚙️ **ইন্টেলিজেন্ট এজেন্ট স্থাপত্য**: **LangGraph** ভিত্তিক **"web_search"** আৰু **"link_parser"**।
- 🏃‍♂️ **এছিঙ্ক্ৰোনাস কনকাৰেণ্ট টাস্ক প্ৰসেছিং**: এছিঙ্ক্ৰোনাস কনকাৰেণ্ট টাস্ক সমৰ্থন, বহু চাৰ্চ টাস্ক একেলগে উচ্চদক্ষতাৰে প্ৰসেছ কৰিব পাৰে।
- 📝 **সামগ্ৰী প্ৰসেছিং অপ্টিমাইজেশ্বন**:

  - ✂️ **সামগ্ৰী চপিং**: ৱেবপেজৰ দীঘল সামগ্ৰী অংশ ভাগত বিভক্ত কৰে।

  - 🔄 **সামগ্ৰী পুনৰ-ব্যৱস্থা**: ইন্টেলিজেন্ট পুনৰ-শ্ৰেণীবিন্যাস, তথ্যৰ সম্পৰ্কীয়তা বৃদ্ধি।

  - 🚫 **সামগ্ৰী ফিল্টাৰ**: অপ্রয়োজনীয় বা পুনৰাবৃত্ত সামগ্ৰী স্বয়ংক্ৰিয়ভাৱে আঁতৰাই দিয়ে।
- 🌐 **বহু প্লেটফৰ্ম সমৰ্থন**:

  - 🖥️ FastAPI বেকএণ্ড ইণ্টাৰফেচ আগবঢ়ায়, যিকোনো ব্যৱস্থাত সংযোগ কৰিব পাৰি।

  - 🌍 Gradio Web UI আগবঢ়ায়, দ্ৰুত ভিজুৱেল এপ্লিকেশ্বন হিচাপে ডিপ্লয় কৰিব পাৰি।
  
  - 🧩[ **ব্ৰাউজাৰ প্লাগিন সমৰ্থন**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge সমৰ্থিত, ইন্টেলিজেন্ট URL বিশ্লেষণ প্লাগিন, ব্ৰাউজাৰতেই ৱেবপেজ বিশ্লেষণ আৰু সামগ্ৰী আহৰণ অনুৰোধ কৰিব পাৰে।
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ তৎক্ষণাত আৰম্ভ কৰক

### ১. ৰেপ' ক্লোন কৰক

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. নিৰ্ভৰশীলতা ইনষ্টল কৰক

```
pip install -r requirements.txt
python -m playwright install
```

### ৩. দ্ৰুত আৰম্ভণি

#### পৰিবেশ ভেৰিয়েবল সংৰূপণ

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### ডেম’

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

#### বেকএণ্ড api

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

#### গ্ৰাডিঅ'_ডেমো

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 অনলাইন ৱেব অনুসন্ধান পৰীক্ষাৰ সৈতে তুলনা

আমি এই প্ৰকল্পখন কেইটামান মুখ্য অনলাইন API ৰ সৈতে তুলনা কৰিছো, জটিল প্ৰশ্নৰ ক্ষেত্ৰত ইয়াৰ কাৰ্যক্ষমতা মূল্যায়ন কৰিছো।

### 🔥 ডেটা ছেট

- ডেটা ছেট আলীয়ে প্ৰকাশ কৰা [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) ৰ পৰা আহৰণ কৰা হৈছে, য’ত ৬৮০ টা উচ্চ-জটিলতাৰ প্ৰশ্ন আছে, শিক্ষা, একাডেমিক সন্মিলন, গেম আদি বহুতো ক্ষেত্ৰ আৱৰি লৈছে।
- ডেটা ছেটত চীন আৰু ইংৰাজী ভাষাৰ প্ৰশ্ন আছে।

### 🧑‍🏫 তুলনামূলক ফলাফল

| অনুসন্ধান ইঞ্জিন/চিস্টেম  | ✅ শুদ্ধ | ❌ ভূল | ⚠️ আংশিক শুদ্ধ |
| ----------------------- | ------- | ------ | ------------- |
| **হুয়াশান ফাংঝৌ**     | ৫.০০%   | ৭২.২১% | ২২.৭৯%        |
| **বাই লিয়েন**         | ৯.৮৫%   | ৬২.৭৯% | ২৭.৩৫%        |
| **Our**                | ১৯.৮৫%  | ৪৭.৯৪% | ৩২.০৬%        |

## 🙏 কৃতজ্ঞতা

এই প্ৰকল্পৰ কিছুমান ফিচাৰ নিম্নলিখিত মুক্ত উৎস প্ৰকল্পসমূহৰ সহায় আৰু অনুপ্ৰেৰণাৰ ফলত, কৃতজ্ঞতাৰে উল্লেখ কৰা হ’ল:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): মডুলাৰ ইন্টেলিজেন্ট এজেন্ট চেইন ফ্ৰেমৱৰ্ক গঠন কৰিবলৈ ব্যৱহৃত।
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): শক্তিশালী ৱেব কণ্টেন্ট বিশ্লেষণ টুল।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---