
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# 🧠 प्रॉक्सी रहित LLM वेब खोज इंजन

एक प्रॉक्सी के बिना चलने वाला मल्टी-सर्च इंजन LLM वेब रिट्रीवल टूल, जो URL सामग्री विश्लेषण और वेब क्रॉलिंग को सपोर्ट करता है, और LangGraph के साथ मॉड्यूलर एजेंट चेनिंग को सक्षम करता है। यह बाहरी ज्ञान एक्सेस की LLM आवश्यकताओं के लिए डिज़ाइन किया गया है, जो **Playwright + Crawl4AI** वेब पेज फेचिंग व पार्सिंग, असिंक क्रॉनिक करेंसी, कंटेंट स्लाइसिंग और रीऑर्डर-फिल्टरिंग को सपोर्ट करता है।

## ✨ विशेषताओं का संक्षिप्त परिचय

- 🌐 **प्रॉक्सी की आवश्यकता नहीं**: Playwright के माध्यम से लोकल ब्राउज़र कॉन्फ़िगरेशन से नेटवर्क खोज बिना प्रॉक्सी के संभव।
- 🔍 **मल्टी-सर्च इंजन सपोर्ट**: Bing, Quark, Baidu, Sogou आदि प्रमुख सर्च इंजन सपोर्ट, जिससे सूचना स्रोतों की विविधता बढ़ती है।
- 🤖 **इरादे की पहचान**: सिस्टम उपयोगकर्ता इनपुट के आधार पर स्वतः तय कर सकता है कि वेब सर्च करनी है या URL पार्स करना है।
- 🔄 **क्वेरी डीकंपोजिशन**: यूज़र के सर्च इरादे के अनुसार क्वेरी को कई सब-टास्क में विभाजित कर क्रमशः निष्पादित किया जाता है, जिससे सर्च की प्रासंगिकता और कार्यक्षमता बढ़ती है।
- ⚙️ **एजेंट आर्किटेक्चर**: **LangGraph** पर आधारित **"web_search"** और **"link_parser"** एन्कैप्सुलेटेड हैं।
- 🏃‍♂️ **असिंक क्रॉनिक करेंसी टास्क प्रोसेसिंग**: असिंक क्रॉनिक करेंसी के साथ कई सर्च टास्क कुशलता से संभाले जा सकते हैं।
- 📝 **कंटेंट प्रोसेसिंग ऑप्टिमाइज़ेशन**:

  - ✂️ **कंटेंट स्लाइसिंग**: लंबे वेबपेज को अनुच्छेदों में विभाजित करता है।

  - 🔄 **कंटेंट रीऑर्डरिंग**: स्मार्ट रीऑर्डरिंग से सूचना की प्रासंगिकता बढ़ती है।

  - 🚫 **कंटेंट फ़िल्टरिंग**: अप्रासंगिक या डुप्लीकेट सामग्री को स्वतः हटा देता है।
- 🌐 **मल्टी-प्लेटफ़ॉर्म सपोर्ट**:

  - 🖥️ FastAPI बैकएंड API उपलब्ध, जिससे इसे किसी भी सिस्टम में इंटीग्रेट किया जा सकता है।

  - 🌍 Gradio Web UI उपलब्ध, जिससे त्वरित विज़ुअल एप्लिकेशन डिप्लॉयमेंट संभव है।
  
  - 🧩[ **ब्राउज़र एक्सटेंशन सपोर्ट**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge के लिए सपोर्ट, स्मार्ट URL पार्सिंग प्लगइन उपलब्ध, जिससे ब्राउज़र में ही वेबपेज विश्लेषण और सामग्री एक्सट्रैक्शन संभव है।
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ त्वरित प्रारंभ

### 1. रिपॉजिटरी क्लोन करें

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. निर्भरता स्थापित करें

```
pip install -r requirements.txt
python -m playwright install
```

### 3. त्वरित प्रारंभ

#### पर्यावरण चर कॉन्फ़िगरेशन

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### डेमो

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

#### बैकएंड एपीआई

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

#### ग्रेडियो_डेमो

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 ऑनलाइन वेब सर्च परीक्षण की तुलना

हमने इस परियोजना की तुलना कुछ प्रमुख ऑनलाइन API के साथ की, और जटिल समस्याओं में इसके प्रदर्शन का मूल्यांकन किया।

### 🔥 डाटासेट

- डाटासेट अलीबाबा द्वारा जारी [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) से लिया गया है, जिसमें 680 उच्च स्तरीय प्रश्न शामिल हैं, जो शिक्षा, शैक्षणिक सम्मेलन, गेमिंग आदि कई क्षेत्रों को कवर करता है।
- डाटासेट में चीनी और अंग्रेजी दोनों भाषाओं के प्रश्न शामिल हैं।

### 🧑‍🏫 तुलना परिणाम

| सर्च इंजन/सिस्टम  | ✅ सही | ❌ गलत | ⚠️ आंशिक रूप से सही |
| -------------- | --------- | ----------- | ------------------- |
| **हुओशान फांगझोउ**   | 5.00%     | 72.21%      | 22.79%              |
| **बाईलियन**       | 9.85%     | 62.79%      | 27.35%              |
| **हमारा** | 19.85%    | 47.94%      | 32.06%              |

## 🙏 आभार

इस परियोजना की कुछ कार्यक्षमताओं को निम्नलिखित ओपन-सोर्स प्रोजेक्ट्स के समर्थन और प्रेरणा से लाभ मिला है, इसके लिए विशेष धन्यवाद:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): मॉड्यूलर इंटेलिजेंट एजेंट लिंक फ्रेमवर्क के निर्माण के लिए।
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): शक्तिशाली वेब पेज सामग्री विश्लेषण उपकरण।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---