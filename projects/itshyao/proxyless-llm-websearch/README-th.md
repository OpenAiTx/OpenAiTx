
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# 🧠 LLM เสิร์ชเอนจินบนเว็บที่ไม่ต้องใช้ Proxy

เครื่องมือค้นหาบนเว็บ LLM แบบไม่ต้องใช้ Proxy รองรับหลายเสิร์ชเอนจิน สามารถแยกวิเคราะห์เนื้อหา URL และเก็บข้อมูลจากเว็บ ผสานการทำงานแบบโมดูลาร์ด้วย LangGraph ออกแบบมาเพื่อใช้สำหรับ LLM ที่ต้องเข้าถึงความรู้ภายนอก รองรับ **Playwright + Crawl4AI** สำหรับดึงและแยกเนื้อหาเว็บ รองรับการประมวลผลแบบอะซิงโครนัส, การแบ่งเนื้อหา และการกรอง/เรียงลำดับใหม่

## ✨ คุณสมบัติเด่น

- 🌐 **ไม่ต้องใช้ Proxy**: กำหนดค่า Playwright ให้รองรับเบราว์เซอร์ในประเทศ ใช้งานค้นหาเว็บได้โดยไม่ต้องใช้ Proxy
- 🔍 **รองรับหลายเสิร์ชเอนจิน**: รองรับ Bing, Quark, Baidu, Sogou และเสิร์ชเอนจินหลักอื่นๆ เพื่อความหลากหลายของแหล่งข้อมูล
- 🤖 **ตรวจจับเจตนา**: ระบบสามารถตัดสินใจอัตโนมัติจากอินพุตของผู้ใช้ ว่าจะค้นหาเว็บหรือวิเคราะห์ URL
- 🔄 **แยกย่อยคำค้นหา**: แยกคำค้นหาออกเป็นงานย่อยตามเจตนาของผู้ใช้ แล้วดำเนินการตามลำดับ เพื่อเพิ่มความเกี่ยวข้องและประสิทธิภาพในการค้นหา
- ⚙️ **สถาปัตยกรรม Agent**: สร้างบน **LangGraph** ห่อหุ้ม**「web_search」**และ**「link_parser」**
- 🏃‍♂️ **ประมวลผลงานแบบอะซิงโครนัส**: รองรับการประมวลผลงานพร้อมกันแบบอะซิงโครนัส เพิ่มประสิทธิภาพการจัดการงานค้นหาหลายรายการ
- 📝 **เพิ่มประสิทธิภาพการจัดการเนื้อหา**:

  - ✂️ **แบ่งเนื้อหา**: ตัดเนื้อหาเว็บยาวๆ ออกเป็นส่วนๆ

  - 🔄 **เรียงลำดับเนื้อหาใหม่**: เรียงเนื้อหาอัจฉริยะ เพิ่มความเกี่ยวข้องของข้อมูล

  - 🚫 **กรองเนื้อหา**: ตัดเนื้อหาที่ไม่เกี่ยวข้องหรือซ้ำซ้อนโดยอัตโนมัติ
- 🌐 **รองรับหลายแพลตฟอร์ม**:

  - 🖥️ มี API ฝั่ง FastAPI สำหรับนำไปใช้ในระบบใดก็ได้

  - 🌍 มี Gradio Web UI สำหรับใช้งานแบบแอปพลิเคชันวิดเจ็ต

  - 🧩[ **รองรับปลั๊กอินเบราว์เซอร์**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): รองรับ Edge พร้อมปลั๊กอินวิเคราะห์ URL อัจฉริยะ ส่งคำขอแยกและดึงเนื้อหาเว็บโดยตรงในเบราว์เซอร์
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ เริ่มต้นอย่างรวดเร็ว

### 1. โคลนคลังโค้ด

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. ติดตั้งไลบรารีที่จำเป็น

```
pip install -r requirements.txt
python -m playwright install
```

### 3. เริ่มต้นอย่างรวดเร็ว

#### การกำหนดค่าตัวแปรสภาพแวดล้อม

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### สาธิต

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

#### API ฝั่งเซิร์ฟเวอร์

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

#### gradio_demo

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 เปรียบเทียบกับการทดสอบค้นหาข้อมูลออนไลน์

เราได้นำโปรเจกต์นี้ไปเปรียบเทียบกับ API ออนไลน์ชั้นนำบางตัว เพื่อประเมินประสิทธิภาพเมื่อเผชิญกับคำถามที่ซับซ้อน

### 🔥 ชุดข้อมูล

- ชุดข้อมูลมาจากที่อาลีบาบาเผยแพร่ [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) ประกอบด้วยคำถามความยากสูง 680 ข้อ ครอบคลุมทั้งด้านการศึกษา การประชุมวิชาการ เกม ฯลฯ
- ชุดข้อมูลนี้รวมทั้งคำถามภาษาจีนและอังกฤษ

### 🧑‍🏫 ผลการเปรียบเทียบ

| เสิร์ชเอนจิน/ระบบ  | ✅ ถูกต้อง | ❌ ไม่ถูกต้อง | ⚠️ ถูกต้องบางส่วน |
| -------------- | --------- | ----------- | ------------------- |
| **火山方舟**   | 5.00%     | 72.21%      | 22.79%              |
| **百炼**       | 9.85%     | 62.79%      | 27.35%              |
| **Our** | 19.85%    | 47.94%      | 32.06%              |

## 🙏 ขอบคุณ

ฟังก์ชันบางส่วนของโปรเจกต์นี้ได้รับแรงบันดาลใจและการสนับสนุนจากโครงการโอเพ่นซอร์สดังต่อไปนี้ ขอขอบคุณมา ณ ที่นี้

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph): สำหรับสร้างเฟรมเวิร์กโมดูลาร์สำหรับสายงานเอเจนต์อัจฉริยะ
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai): เครื่องมือแยกวิเคราะห์เนื้อหาเว็บที่ทรงพลัง

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---