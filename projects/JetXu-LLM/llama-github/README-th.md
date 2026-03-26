
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# llama-github

[เอกสารรายละเอียด] https://deepwiki.com/JetXu-LLM/llama-github

[![PyPI version](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![ดาวน์โหลด](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![สัญญาอนุญาต](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github เป็นเครื่องมือที่มีประสิทธิภาพซึ่งช่วยให้คุณดึงข้อมูลโค้ดที่เกี่ยวข้องที่สุด (โดยใช้ Agentic RAG) เช่น ตัวอย่างโค้ด ปัญหา และข้อมูลของ repository จาก GitHub ตามคำถามของคุณ โดยเปลี่ยนข้อมูลเหล่านั้นเป็นบริบทความรู้ที่มีค่า มันช่วยให้ LLM Chatbots, AI Agents และ Auto-dev Agents สามารถแก้ไขงานโค้ดที่ซับซ้อนได้ ไม่ว่าคุณจะเป็นนักพัฒนาที่ต้องการทางแก้ไขอย่างรวดเร็ว หรือวิศวกรที่กำลังพัฒนา AI Agents Auto Dev ขั้นสูง llama-github ก็ทำให้ทุกอย่างง่ายและมีประสิทธิภาพ
หากคุณชอบโปรเจกต์นี้หรือเชื่อว่ามีศักยภาพ กรุณาให้ดาว ⭐️ แก่เรา การสนับสนุนของคุณคือแรงบันดาลใจที่ยิ่งใหญ่ที่สุดของเรา!

## สถาปัตยกรรม
![สถาปัตยกรรมระดับสูง](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## การติดตั้ง

```
pip install llama-github
```

เป้าหมายรันไทม์ที่ดูแลปัจจุบัน: Python `3.10+`.

## การใช้งาน

นี่คือตัวอย่างง่ายๆ ของวิธีการใช้ llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` จะคืนค่ารายการของดิกชันนารีคอนเท็กซ์ แต่ละรายการจะมีอย่างน้อย `context` และ `url`

สำหรับการใช้งานขั้นสูงและตัวอย่างเพิ่มเติม โปรดดูที่ [เอกสารประกอบ](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md) ตัวอย่างที่รันได้และต้นทุนต่ำมีให้ใน [`examples/`](examples)

## คุณสมบัติหลัก

- **🔍 การดึงข้อมูล GitHub อัจฉริยะ**: ใช้พลังของ llama-github เพื่อดึงโค้ด ตัวอย่างปัญหา และข้อมูลรีโพซิทอรีที่เกี่ยวข้องจาก GitHub ตามคำค้นหาของผู้ใช้ เทคนิคการดึงขั้นสูงของเราช่วยให้คุณค้นหาข้อมูลสำคัญได้อย่างรวดเร็วและมีประสิทธิภาพ

- **⚡ การแคชพูลรีโพซิทอรี**: Llama-github มีกลไกแคชพูลรีโพซิทอรีที่เป็นนวัตกรรมใหม่ โดยการแคชรีโพซิทอรี (รวมถึง README โครงสร้าง โค้ด และปัญหา) ข้ามเธรด llama-github จะช่วยเร่งประสิทธิภาพการค้นหา GitHub และลดการใช้โทเคนของ GitHub API อย่างมาก

- **🧠 การวิเคราะห์คำถามด้วย LLM**: ใช้โมเดลภาษาล้ำสมัยในการวิเคราะห์คำถามของผู้ใช้และสร้างกลยุทธ์และเกณฑ์การค้นหาที่มีประสิทธิภาพสูง Llama-github จะแยกวิเคราะห์คำค้นหาที่ซับซ้อนอย่างชาญฉลาด เพื่อให้แน่ใจว่าคุณจะได้ข้อมูลที่เกี่ยวข้องที่สุดจากเครือข่ายรีโพซิทอรีอันมหาศาลของ GitHub

- **📚 การสร้างบริบทที่ครอบคลุม**: สร้างคำตอบที่มีเนื้อหาและบริบทที่เกี่ยวข้อง โดยผสมผสานข้อมูลที่ดึงมาจาก GitHub เข้ากับความสามารถในการให้เหตุผลของโมเดลภาษา Llama-github เชี่ยวชาญในการตอบคำถามที่ซับซ้อนและยาว ช่วยให้คุณได้รับคำตอบที่ละเอียดพร้อมบริบทที่ครบถ้วน

- **🚀 ประสิทธิภาพการประมวลผลแบบอะซิงโครนัส**: Llama-github ถูกสร้างขึ้นเพื่อใช้ศักยภาพของโปรแกรมมิ่งแบบอะซิงโครนัสอย่างเต็มที่ ด้วยกลไกที่ละเอียดอ่อนที่ถูกฝังไว้ทั่วทั้งโค้ดเบส Llama-github สามารถจัดการคำขอพร้อมกันได้หลายรายการ เพิ่มประสิทธิภาพโดยรวมอย่างมาก

- **🔧 การผสานรวม LLM ที่ยืดหยุ่น**: ผสาน llama-github เข้ากับผู้ให้บริการ LLM ที่หลากหลาย โมเดลฝัง โมเดล rerank หรือโมเดลแชทที่เข้ากันได้กับ LangChain ได้อย่างง่ายดาย เพื่อปรับความสามารถของไลบรารีให้ตรงกับความต้องการของคุณ

- **🔒 ตัวเลือกการยืนยันตัวตนที่แข็งแกร่ง**: Llama-github รองรับทั้งโทเคนส่วนบุคคลและการยืนยันตัวตนด้วย GitHub App ให้คุณผสานรวมในสภาพแวดล้อมการพัฒนาที่หลากหลาย ไม่ว่าคุณจะเป็นนักพัฒนาเดี่ยวหรือทำงานในองค์กร llama-github ก็พร้อมให้คุณด้วยกลไกการยืนยันตัวตนที่ปลอดภัยและเชื่อถือได้

- **🛠️ การบันทึกและจัดการข้อผิดพลาด**: เราเข้าใจถึงความสำคัญของการทำงานที่ราบรื่นและการแก้ไขปัญหาที่ง่ายดาย นั่นคือเหตุผลที่ llama-github มาพร้อมกับกลไกการบันทึกและจัดการข้อผิดพลาดที่ครบถ้วน ให้คุณเข้าใจพฤติกรรมของไลบรารี แก้ปัญหาได้อย่างรวดเร็ว และรักษาการพัฒนาที่มั่นคง

## 🤖 ทดลองผู้ช่วยรีวิว PR ด้วย AI: LlamaPReview

หากคุณพบว่า llama-github มีประโยชน์ คุณอาจสนใจผู้ช่วยรีวิว PR บน GitHub ที่ขับเคลื่อนด้วย AI ของเรา LlamaPReview ถูกออกแบบมาเพื่อเสริมเวิร์กโฟลว์พัฒนาและยกระดับคุณภาพโค้ด

### คุณสมบัติเด่นของ LlamaPReview:
- 🚀 ติดตั้งด้วยคลิกเดียว ไม่ต้องตั้งค่า รันอัตโนมัติเต็มรูปแบบ
- 💯 ใช้ฟรีขณะนี้ - ไม่ต้องใช้บัตรเครดิตหรือข้อมูลชำระเงิน
- 🧠 รีวิว PR อัตโนมัติด้วย AI ที่เข้าใจโค้ดเชิงลึก
- 🌐 รองรับหลายภาษาโปรแกรม

**LlamaPReview ใช้การดึงบริบทและการวิเคราะห์ด้วย LLM ขั้นสูงของ llama-github** เพื่อให้รีวิวโค้ดที่ชาญฉลาดและเข้าใจบริบท เหมือนมีนักพัฒนาอาวุโสที่รู้ทุกอย่างในรีโพซิทอรีของคุณรีวิว PR อัตโนมัติทุกครั้ง!

👉 [ติดตั้ง LlamaPReview ตอนนี้](https://github.com/marketplace/llamapreview/) (ฟรี)

โดยใช้ llama-github สำหรับดึงบริบทและ LlamaPReview สำหรับรีวิวโค้ด คุณจะสร้างสภาพแวดล้อมพัฒนาที่เสริมพลังด้วย AI ได้อย่างแท้จริง

## วิสัยทัศน์และแผนพัฒนา


### วิสัยทัศน์

วิสัยทัศน์ของเราคือการเป็นโมดูลสำคัญในอนาคตของโซลูชันการพัฒนาที่ขับเคลื่อนด้วย AI โดยผสานรวมกับ GitHub อย่างไร้รอยต่อเพื่อเสริมศักยภาพ LLMs ในการแก้ไขงานเขียนโค้ดที่ซับซ้อนโดยอัตโนมัติ

![สถาปัตยกรรมวิสัยทัศน์](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### โรดแมป

สำหรับมุมมองประวัติศาสตร์ของโรดแมปก่อนหน้านี้ กรุณาเยี่ยมชม [วิสัยทัศน์และโรดแมป](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md)

## คำขอบคุณ

เราขอขอบคุณโครงการโอเพนซอร์สดังต่อไปนี้สำหรับการสนับสนุนและการมีส่วนร่วม:

- **[LangChain](https://github.com/langchain-ai/langchain)**: สำหรับการให้โครงสร้างพื้นฐานที่เสริมสร้างความสามารถในการสั่งและประมวลผล LLM ใน llama-github
- **[Jina.ai](https://github.com/jina-ai/reader)**: สำหรับการให้บริการ s.jina.ai API และโมเดล reranker และ embedding แบบโอเพนซอร์สที่ช่วยเพิ่มความแม่นยำและเกี่ยวข้องของเนื้อหาที่สร้างใน llama-github

การมีส่วนร่วมของพวกเขามีความสำคัญต่อการพัฒนา llama-github และเราขอแนะนำให้คุณตรวจสอบโครงการของพวกเขาสำหรับโซลูชันนวัตกรรมเพิ่มเติม

## การมีส่วนร่วม

เรายินดีต้อนรับการมีส่วนร่วมใน llama-github! กรุณาดู [แนวทางการมีส่วนร่วม](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) ของเราเพื่อข้อมูลเพิ่มเติม

## ใบอนุญาต

โครงการนี้ได้รับอนุญาตภายใต้ข้อกำหนดของใบอนุญาต Apache 2.0 ดูไฟล์ [LICENSE](LICENSE) สำหรับรายละเอียดเพิ่มเติม

## ติดต่อ

หากคุณมีคำถาม ข้อเสนอแนะ หรือความคิดเห็น กรุณาติดต่อเราได้ที่ [อีเมลของ Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com)

---

ขอบคุณที่เลือกใช้ llama-github! เราหวังว่าห้องสมุดนี้จะช่วยเสริมประสบการณ์การพัฒนา AI ของคุณและช่วยให้คุณสร้างแอปพลิเคชันที่ทรงพลังได้อย่างง่ายดาย


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---