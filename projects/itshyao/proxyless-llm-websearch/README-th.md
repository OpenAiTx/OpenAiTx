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
# 🧠 เครื่องมือค้นหา LLM บนเว็บโดยไม่ต้องใช้ Proxy

เครื่องมือค้นหาเว็บสำหรับ LLM หลายแหล่ง โดยไม่ต้องใช้ Proxy รองรับการแยกวิเคราะห์เนื้อหา URL และการรวบรวมข้อมูลเว็บ ผสานการทำงาน **LangGraph** และ **LangGraph-MCP** เพื่อสร้างสายงานตัวแทนแบบโมดูลาร์ ออกแบบมาสำหรับการเรียกใช้ความรู้ภายนอกใน LLM รองรับ **Playwright + Crawl4AI** สำหรับการดึงข้อมูลและแยกวิเคราะห์หน้าเว็บ รองรับการประมวลผลแบบอะซิงโครนัส การแบ่งเนื้อหา และการกรอง/เรียงลำดับใหม่

## 🚀 บันทึกการอัปเดต

- 🔥 2025-09-05: รองรับ **langgraph-mcp**
- 🔥 2025-09-03: เพิ่มการติดตั้งแบบ Docker, ตัวจัดเรียงอัจฉริยะในตัว, รองรับการปรับแต่งตัวแบ่งข้อความและตัวจัดเรียงใหม่

## ✨ คุณสมบัติเด่น

- 🌐 **ไม่ต้องใช้พร็อกซี**: รองรับการค้นหาข้อมูลออนไลน์โดยไม่ต้องใช้พร็อกซี ด้วยการตั้งค่าเบราว์เซอร์ภายในประเทศผ่าน Playwright
- 🔍 **รองรับหลายเสิร์ชเอนจิน**: สนับสนุน Bing, Quark, Baidu, Sogou และเสิร์ชเอนจินหลักอื่น ๆ เพิ่มความหลากหลายของแหล่งข้อมูล
- 🤖 **การตรวจจับเจตนา**: ระบบสามารถวิเคราะห์ข้อความของผู้ใช้ เพื่อแยกแยะว่าต้องการค้นหาข้อมูลออนไลน์หรือแค่แปล URL
- 🔄 **การแยกส่วนคำค้น**: แยกคำค้นตามเจตนาของผู้ใช้เป็นหลาย ๆ งานย่อย และดำเนินการตามลำดับเพื่อเพิ่มความเกี่ยวข้องและประสิทธิภาพ
- ⚙️ **สถาปัตยกรรมอัจฉริยะ**: พัฒนาบน **LangGraph** ครอบคลุม**「web_search」** และ **「link_parser」**
- 🏃‍♂️ **รองรับงานแบบประมวลผลพร้อมกัน (Asynchronous)**: รองรับการประมวลผลงานค้นหาหลายงานพร้อมกันอย่างมีประสิทธิภาพ
- 📝 **การปรับปรุงการประมวลผลเนื้อหา**:

  - ✂️ **แบ่งชิ้นเนื้อหา**: แบ่งเนื้อหายาวของหน้าเว็บออกเป็นส่วน ๆ

  - 🔄 **จัดเรียงเนื้อหาใหม่**: จัดลำดับเนื้อหาอย่างชาญฉลาดเพื่อเพิ่มความเกี่ยวข้อง

  - 🚫 **กรองเนื้อหา**: กรองเนื้อหาที่ซ้ำซ้อนหรือไม่เกี่ยวข้องโดยอัตโนมัติ
- 🌐 **รองรับหลายแพลตฟอร์ม**:
  - 🐳 **รองรับการติดตั้งผ่าน Docker**: เริ่มต้นด้วยคลิกเดียว สร้างบริการ backend ได้อย่างรวดเร็ว

  - 🖥️ ให้บริการ API backend ด้วย FastAPI สามารถเชื่อมต่อกับระบบใดก็ได้

  - 🌍 ให้บริการ Gradio Web UI สำหรับสร้างแอปพลิเคชันที่มองเห็นผลลัพธ์ได้รวดเร็ว

  - 🧩[ **รองรับปลั๊กอินเบราว์เซอร์**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension): รองรับ Edge พร้อมปลั๊กอินแปล URL อัจฉริยะ ส่งคำขอวิเคราะห์เว็บและดึงเนื้อหาโดยตรงจากเบราว์เซอร์


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ เริ่มต้นอย่างรวดเร็ว

### โคลนโปรเจกต์

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### ติดตั้ง dependencies

```
pip install -r requirements.txt
python -m playwright install
```

### การกำหนดค่าตัวแปรสภาพแวดล้อม

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

### Langgraph-Agent

#### สาธิต

```shell
python agent/demo.py
```

#### การให้บริการ API

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

#### Gradio

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

#### เริ่มต้นบริการ MCP

```
python mcp/websearch.py
```

#### ตัวอย่างสาธิต

```
python mcp/demo.py
```

#### การให้บริการ API

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

#### docker

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### โมดูลที่กำหนดเอง

#### การแบ่งบล็อกแบบกำหนดเอง

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

#### การจัดเรียงใหม่แบบกำหนดเอง

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

## 🔍 เปรียบเทียบกับการทดสอบค้นหาออนไลน์

เราได้เปรียบเทียบโปรเจกต์กับ API ออนไลน์หลักหลายตัว เพื่อประเมินประสิทธิภาพในการแก้ปัญหาที่ซับซ้อน

### 🔥 ชุดข้อมูล

- ชุดข้อมูลนำมาจาก [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) ที่เผยแพร่โดยอาลีบาบา มีคำถามยาก 680 ข้อ ครอบคลุมด้านการศึกษา, การประชุมวิชาการ, เกม ฯลฯ
- ชุดข้อมูลประกอบด้วยคำถามทั้งภาษาอังกฤษและจีน

### 🧑‍🏫 ผลการเปรียบเทียบ

| เครื่องมือค้นหา/ระบบ   | ✅ ถูกต้อง | ❌ ไม่ถูกต้อง | ⚠️ ถูกต้องบางส่วน |
| -------------------- | --------- | ----------- | ------------------ |
| **火山方舟**          | 5.00%     | 72.21%      | 22.79%             |
| **百炼**              | 9.85%     | 62.79%      | 27.35%             |
| **ของเรา**           | 19.85%    | 47.94%      | 32.06%             |
## 🙏 ขอบคุณ

ฟังก์ชันบางส่วนของโปรเจกต์นี้ได้รับแรงบันดาลใจและสนับสนุนจากโครงการโอเพ่นซอร์สดังต่อไปนี้ ขอขอบคุณมา ณ ที่นี้

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph)：ใช้สำหรับสร้างเฟรมเวิร์กเชื่อมโยงตัวแทนแบบโมดูลาร์ ช่วยให้สร้างระบบตัวแทนที่ซับซ้อนได้อย่างรวดเร็ว
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai)：เครื่องมือวิเคราะห์เนื้อหาเว็บที่ทรงพลัง ช่วยการดึงข้อมูลและแยกข้อมูลจากเว็บได้อย่างมีประสิทธิภาพ
- 🌐 [Playwright](https://github.com/microsoft/playwright)：เครื่องมืออัตโนมัติสำหรับเบราว์เซอร์สมัยใหม่ รองรับการดึงข้อมูลและทดสอบข้ามเบราว์เซอร์
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters)：สำหรับการสร้าง MCP แบบหลายเชน


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---