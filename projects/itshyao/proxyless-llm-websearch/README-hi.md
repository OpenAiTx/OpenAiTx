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
# 🧠 बिना प्रॉक्सी के LLM वेब खोज इंजन

एक ऐसा मल्टी-सर्च इंजन LLM वेब रिट्रीवल टूल जो प्रॉक्सी की आवश्यकता नहीं रखता है, URL सामग्री विश्लेषण और वेब पेज क्रॉलिंग का समर्थन करता है, **LangGraph** और **LangGraph-MCP** के संयोजन से मॉड्यूलर एजेंट चेन को लागू करता है। यह बड़े भाषा मॉडल की बाहरी ज्ञान कॉलिंग के लिए बनाया गया है, जो **Playwright + Crawl4AI** वेब पेज प्राप्ति और विश्लेषण, असिंक्रोनस कॉन्करेंसी, कंटेंट स्लाइसिंग और री-रैंकिंग फिल्टरिंग को सपोर्ट करता है।

## 🚀 अपडेट लॉग

- 🔥 2025-09-05: **langgraph-mcp** का समर्थन
- 🔥 2025-09-03: नया Docker तैनाती, इन-बिल्ट इंटेलिजेंट री-रेंकर, कस्टम टेक्स्ट स्प्लिटर और री-रेंकर का समर्थन

## ✨ फीचर सूची

- 🌐 **कोई प्रॉक्सी आवश्यक नहीं**: Playwright कॉन्फ़िगरेशन द्वारा घरेलू ब्राउज़र समर्थन के साथ, बिना प्रॉक्सी के भी नेटवर्क खोज की जा सकती है।
- 🔍 **मल्टी-सर्च इंजन समर्थन**: Bing, Quark, Baidu, Sogou आदि प्रमुख सर्च इंजन का समर्थन, जिससे सूचना स्रोतों की विविधता बढ़ती है।
- 🤖 **इंटेंट पहचान**: सिस्टम उपयोगकर्ता के इनपुट के आधार पर स्वतः पहचानता है कि नेटवर्क खोज करनी है या URL को पार्स करना है।
- 🔄 **क्वेरी डिकंपोजिशन**: उपयोगकर्ता की खोज इच्छा के अनुसार क्वेरी को कई उप-कार्यों में स्वतः विभाजित कर क्रमवार निष्पादित करता है, जिससे खोज की प्रासंगिकता और दक्षता बढ़ती है।
- ⚙️ **इंटेलिजेंट एजेंट आर्किटेक्चर**: **LangGraph** पर आधारित **"web_search"** और **"link_parser"** का समावेश।
- 🏃‍♂️ **असिंक्रोनस और समवर्ती कार्य प्रबंधन**: असिंक्रोनस और समवर्ती कार्यों का समर्थन, जिससे कई खोज कार्यों को कुशलता से संभाला जा सकता है।
- 📝 **सामग्री प्रसंस्करण अनुकूलन**:

  - ✂️ **सामग्री स्लाइसिंग**: वेबपेज की लंबी सामग्री को खंडों में विभाजित करना।

  - 🔄 **सामग्री पुन: क्रमबद्ध करना**: बुद्धिमानी से पुन: क्रमबद्ध कर सूचना की प्रासंगिकता बढ़ाना।

  - 🚫 **सामग्री छंटाई**: स्वतः अप्रासंगिक या दोहराई गई सामग्री को हटाना।
- 🌐 **मल्टी-प्लेटफॉर्म समर्थन**:
  - 🐳 **Docker तैनाती का समर्थन**: एक क्लिक से प्रारंभ करें, बैकएंड सेवा का त्वरित निर्माण।

  - 🖥️ FastAPI बैकएंड इंटरफेस प्रदान करें, जिसे किसी भी सिस्टम में एकीकृत किया जा सकता है।

  - 🌍 Gradio Web UI प्रदान करें, जिसे त्वरित रूप से विज़ुअल एप्लिकेशन के रूप में तैनात किया जा सकता है।

  - 🧩[ **ब्राउज़र प्लगइन समर्थन**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): Edge का समर्थन, स्मार्ट URL पार्सिंग प्लगइन प्रदान करता है, जिससे ब्राउज़र में ही वेबपेज पार्सिंग और सामग्री निष्कर्षण अनुरोध किया जा सकता है।


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ त्वरित प्रारंभ

### रिपॉजिटरी क्लोन करें

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### निर्भरता स्थापित करें

```
pip install -r requirements.txt
python -m playwright install
```

### पर्यावरण वेरिएबल कॉन्फ़िगरेशन

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

### लैंगग्राफ-एजेंट

#### डेमो

```shell
python agent/demo.py
```

#### एपीआई सेवा

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

#### ग्रैडियो

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

#### MCP सेवा प्रारंभ करें

```
python mcp/websearch.py
```

#### डेमो

```
python mcp/demo.py
```

#### एपीआई सर्व करें

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

#### डॉकर

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### कस्टम मॉड्यूल

#### कस्टम ब्लॉकिंग

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

#### कस्टम पुनः क्रमबद्धीकरण

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

## 🔍 ऑनलाइन नेटवर्क खोज परीक्षण की तुलना

हमने परियोजना की तुलना कुछ मुख्यधारा के ऑनलाइन API से की, और जटिल समस्याओं पर इसकी प्रदर्शन का मूल्यांकन किया।

### 🔥 डेटा सेट

- डेटा सेट अलीबाबा द्वारा जारी [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) से लिया गया है, जिसमें 680 उच्च कठिनाई के प्रश्न हैं, जो शिक्षा, शैक्षिक सम्मेलन, गेम आदि कई क्षेत्रों को कवर करते हैं।
- डेटा सेट में चीनी और अंग्रेजी दोनों भाषाओं के प्रश्न शामिल हैं।

### 🧑‍🏫 तुलना परिणाम

| सर्च इंजन/सिस्टम   | ✅ सही | ❌ गलत | ⚠️ आंशिक रूप से सही |
| ----------------- | ------ | ------ | ------------------ |
| **हुओशान फांगझोउ**| 5.00%  | 72.21% | 22.79%             |
| **बाइलियन**       | 9.85%  | 62.79% | 27.35%             |
| **हमारा**         | 19.85% | 47.94% | 32.06%             |
## 🙏 आभार

इस परियोजना के कुछ कार्यक्षमता निम्नलिखित ओपन सोर्स परियोजनाओं के समर्थन और प्रेरणा से लाभान्वित हुए हैं, इसके लिए विशेष आभार:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): मॉड्यूलर एजेंट लिंक फ्रेमवर्क के निर्माण के लिए, जो जटिल एजेंट सिस्टम को जल्दी बनाने में मदद करता है।
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): शक्तिशाली वेब सामग्री विश्लेषण उपकरण, जो कुशल वेब स्क्रैपिंग और डेटा निष्कर्षण में सहायक है।
- 🌐 [Playwright](https://github.com/microsoft/playwright): आधुनिक ब्राउज़र ऑटोमेशन उपकरण, जो क्रॉस-ब्राउज़र वेब स्क्रैपिंग और परीक्षण ऑटोमेशन को सपोर्ट करता है।
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): मल्टी-चेन प्रोसेसिंग MCP के निर्माण के लिए।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---