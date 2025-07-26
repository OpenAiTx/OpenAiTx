
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

# 🧠 محرك بحث LLM عبر الإنترنت بدون وكيل

أداة استرجاع شبكي متعددة محركات البحث للـ LLM لا تتطلب وكيل، تدعم تحليل محتوى الروابط والزحف على صفحات الويب، ومبنية على LangGraph لتحقيق سلاسل وكلاء ذكية بشكل معياري. مصممة خصيصاً لسيناريوهات استخدام المعرفة الخارجية لنماذج اللغة الكبيرة، وتدعم **Playwright + Crawl4AI** لجلب وتحليل صفحات الويب، مع دعم التنفيذ المتزامن والتقطيع وإعادة ترتيب وتصفية المحتوى.

## ✨ لمحة عن الميزات

- 🌐 **بدون وكيل**: يمكن البحث عبر الإنترنت بدون وكيل من خلال إعداد Playwright على متصفح محلي داخل الصين.
- 🔍 **دعم عدة محركات بحث**: يدعم Bing، Quark، Baidu، Sogou وغيرها من محركات البحث الرئيسية، لتعزيز تنوع مصادر المعلومات.
- 🤖 **التعرف على النوايا**: يستطيع النظام تحديد ما إذا كان يجب إجراء بحث على الإنترنت أو تحليل رابط URL بناءً على إدخال المستخدم.
- 🔄 **تحليل الاستعلام**: بناءً على نية البحث للمستخدم، يتم تقسيم الاستعلام تلقائيًا إلى عدة مهام فرعية وتنفيذها تدريجيًا، مما يحسن الصلة والكفاءة.
- ⚙️ **هيكلية الوكيل الذكي**: مبني على **LangGraph** مع تغليف **"web_search"** و **"link_parser"** كوكلاء.
- 🏃‍♂️ **إدارة المهام المتزامنة**: يدعم تنفيذ المهام بشكل متزامن، مما يتيح معالجة فعالة لعدة استعلامات بحث.
- 📝 **تحسين معالجة المحتوى**:

  - ✂️ **تقطيع المحتوى**: تقسيم محتوى صفحات الويب الطويلة إلى مقاطع.

  - 🔄 **إعادة ترتيب المحتوى**: إعادة ترتيب ذكي للمحتوى لزيادة صلته بالمعلومات.

  - 🚫 **تصفية المحتوى**: إزالة تلقائية للمحتوى غير ذي الصلة أو المكرر.
- 🌐 **دعم متعدد المنصات**:

  - 🖥️ يوفر واجهة خلفية FastAPI يمكن دمجها مع أي نظام.

  - 🌍 يوفر واجهة Gradio Web UI لسهولة النشر كتطبيق مرئي.
  
  - 🧩[ **دعم الإضافات للمتصفح**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): يدعم Edge ويوفر إضافة ذكية لتحليل الروابط، لطلب تحليل واستخلاص محتوى صفحات الويب مباشرة من المتصفح.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ البدء السريع

### 1. استنساخ المستودع

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. تثبيت الاعتمادات

```
pip install -r requirements.txt
python -m playwright install
```

### 3. البدء السريع

#### إعداد متغيرات البيئة

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### عرض توضيحي

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

#### واجهة برمجة التطبيقات الخلفية

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

#### عرض غريديو

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 مقارنة مع اختبارات البحث الشبكي عبر الإنترنت

قمنا بمقارنة المشروع مع بعض واجهات برمجة التطبيقات (API) الرئيسية على الإنترنت، لتقييم أدائه في مواجهة المشكلات المعقدة.

### 🔥 مجموعة البيانات

- تم أخذ مجموعة البيانات من [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) الصادرة عن علي بابا، وتحتوي على 680 سؤالًا عالي الصعوبة، تغطي مجالات مثل التعليم والمؤتمرات الأكاديمية والألعاب وغيرها.
- مجموعة البيانات تتضمن أسئلة باللغتين الصينية والإنجليزية.

### 🧑‍🏫 نتائج المقارنة

| محرك البحث/النظام | ✅ صحيح | ❌ غير صحيح | ⚠️ صحيح جزئيًا |
| ---------------- | ------- | ---------- | -------------- |
| **火山方舟**     | 5.00%   | 72.21%     | 22.79%         |
| **百炼**         | 9.85%   | 62.79%     | 27.35%         |
| **Our** | 19.85%  | 47.94%     | 32.06%         |

## 🙏 الشكر والتقدير

يعتمد هذا المشروع جزئيًا على دعم وإلهام المشاريع مفتوحة المصدر التالية، ونشكرهم جزيل الشكر:

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): لبناء إطار ربط العوامل الذكية المعيارية.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): أداة قوية لتحليل محتوى صفحات الويب.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---