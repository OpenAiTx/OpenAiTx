<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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
# 🧠 محرك بحث الويب LLM بدون الحاجة إلى وكيل

أداة استرجاع عبر الإنترنت متعددة محركات البحث للـ LLM بدون الحاجة إلى وكيل، تدعم تحليل محتوى الروابط واستخلاص صفحات الويب، وتجمع بين **LangGraph** و **LangGraph-MCP** لتنفيذ سلسلة وكلاء ذكية بشكل معياري. مصممة خصيصاً لاستدعاء المعرفة الخارجية لنماذج اللغة الكبيرة، وتدعم جلب وتحليل صفحات الويب عبر **Playwright + Crawl4AI**، مع دعم للتنفيذ المتزامن، وتجزئة المحتوى وإعادة ترتيبه وتصفية النتائج.

## 🚀 سجل التحديثات

- 🔥 2025-09-05: دعم **langgraph-mcp**
- 🔥 2025-09-03: إضافة نشر عبر Docker، إعادة ترتيب ذكية مدمجة، دعم تقسيم النصوص وإعادة الترتيب المخصصة

## ✨ نظرة عامة على الميزات

- 🌐 **لا حاجة للوكيل**: من خلال إعداد Playwright لدعم المتصفح المحلي، يمكن إجراء البحث على الإنترنت بدون الحاجة للوكيل.
- 🔍 **دعم محركات بحث متعددة**: يدعم Bing، Quark، Baidu، Sogou وغيرها من محركات البحث الرئيسية، مما يعزز تنوع مصادر المعلومات.
- 🤖 **تعرف على النوايا**: يستطيع النظام تلقائيًا تحديد ما إذا كان الإدخال من المستخدم يتطلب بحثًا على الإنترنت أو تحليل عنوان URL.
- 🔄 **تفكيك الاستعلامات**: وفقًا لنوايا البحث لدى المستخدم، يتم تلقائيًا تقسيم الاستعلام إلى عدة مهام فرعية وتنفيذها بالتتابع، مما يزيد من فعالية وارتباط البحث.
- ⚙️ **بنية الذكاء الاصطناعي**: مبنية على **LangGraph** وتغلف **"web_search"** و **"link_parser"**.
- 🏃‍♂️ **معالجة المهام المتزامنة غير المتزامنة**: يدعم معالجة المهام بشكل متزامن وغير متزامن بكفاءة عالية لعدة مهام بحثية.
- 📝 **تحسين معالجة المحتوى**:

  - ✂️ **تقطيع المحتوى**: تقسيم محتوى صفحات الويب الطويلة إلى فقرات.

  - 🔄 **إعادة ترتيب المحتوى**: إعادة ترتيب ذكي لتحسين ارتباط المعلومات.

  - 🚫 **تصفية المحتوى**: إزالة المحتوى غير المتعلق أو المكرر تلقائيًا.
- 🌐 **دعم متعدد المنصات**:
  - 🐳 **دعم النشر عبر Docker**: تشغيل بنقرة واحدة لبناء خدمة خلفية بسرعة.

  - 🖥️ يوفر واجهة خلفية FastAPI، يمكن دمجها في أي نظام.

  - 🌍 يوفر واجهة ويب Gradio، للنشر السريع كتطبيق مرئي.

  - 🧩[ **دعم إضافات المتصفح**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): يدعم Edge ويوفر إضافة لتحليل عناوين URL الذكية، لتنفيذ تحليل صفحات الويب واستخلاص المحتوى مباشرة من المتصفح.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ البدء السريع

### استنساخ المستودع

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### تثبيت الاعتمادات

```
pip install -r requirements.txt
python -m playwright install
```

### تكوين متغيرات البيئة

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

### وكيل Langgraph

#### العرض التوضيحي

```shell
python agent/demo.py
```

#### خدمة واجهة برمجة التطبيقات (API SERVE)

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

#### جراديو

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

#### بدء خدمة MCP

```
python mcp/websearch.py
```

#### عرض توضيحي

```
python mcp/demo.py
```

#### خدمة API

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

#### دوكر

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### الوحدات المخصصة

#### تقسيم مخصص

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

#### إعادة ترتيب مخصص

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

## 🔍 مقارنة مع اختبارات البحث عبر الإنترنت

قمنا بمقارنة المشروع مع بعض واجهات برمجة التطبيقات (API) الرائجة عبر الإنترنت، لتقييم أدائه في مواجهة الأسئلة المعقدة.

### 🔥 مجموعة البيانات

- تم جمع البيانات من [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) الصادرة عن شركة علي بابا، وتحتوي على 680 سؤالًا عالي الصعوبة، تغطي مجالات التعليم، المؤتمرات الأكاديمية، الألعاب وغيرها.
- تتضمن مجموعة البيانات أسئلة باللغة الصينية والإنجليزية.

### 🧑‍🏫 نتائج المقارنة

| محرك البحث/النظام  | ✅ صحيح | ❌ غير صحيح | ⚠️ صحيح جزئيًا |
| ------------------ | ------- | ---------- | -------------- |
| **火山方舟**       | 5.00%   | 72.21%     | 22.79%         |
| **百炼**           | 9.85%   | 62.79%     | 27.35%         |
| **Our**            | 19.85%  | 47.94%     | 32.06%         |
## 🙏 الشكر والتقدير

استفادت بعض وظائف المشروع من دعم وإلهام المشاريع مفتوحة المصدر التالية، ونود تقديم الشكر الخاص لها:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): يستخدم لبناء إطار عمل روابط الوكلاء الذكية بشكل معياري، ويساعد في إنشاء أنظمة وكلاء معقدة بسرعة.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): أداة قوية لتحليل محتوى صفحات الويب، تدعم استخراج البيانات وجمع صفحات الإنترنت بكفاءة.
- 🌐 [Playwright](https://github.com/microsoft/playwright): أداة حديثة لأتمتة المتصفحات، تدعم جمع بيانات الصفحات واختبارات الأتمتة عبر جميع أنواع المتصفحات.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters): تُستخدم لبناء معالجة MCP متعددة السلاسل.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---