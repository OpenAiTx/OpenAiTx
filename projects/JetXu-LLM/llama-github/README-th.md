
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
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[เอกสารรายละเอียด] https://deepwiki.com/JetXu-LLM/llama-github

[![เวอร์ชัน PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![ดาวน์โหลด](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![สัญญาอนุญาต](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github เป็นเครื่องมือทรงพลังที่ช่วยให้คุณดึงข้อมูลโค้ดที่เกี่ยวข้องที่สุด ปัญหา และข้อมูลรีโพซิทอรีจาก GitHub ตามคำค้นหา (โดยอิงกับ Agentic RAG) แล้วแปลงเป็นบริบทความรู้ที่มีค่า มันช่วยเสริมศักยภาพให้กับแชทบอท LLM, AI Agents และ Auto-dev Agents ในการแก้ปัญหาการเขียนโค้ดที่ซับซ้อน ไม่ว่าคุณจะเป็นนักพัฒนาที่ต้องการคำตอบอย่างรวดเร็วหรือวิศวกรที่นำไปใช้ใน Auto Dev AI Agent ขั้นสูง llama-github จะช่วยให้คุณทำงานได้ง่ายและมีประสิทธิภาพ

หากคุณชอบโปรเจกต์นี้หรือเห็นว่ามีศักยภาพ กรุณากด ⭐️ ให้เราด้วย การสนับสนุนของคุณคือแรงบันดาลใจที่ยิ่งใหญ่ที่สุดของเรา!

## สถาปัตยกรรม
![สถาปัตยกรรมระดับสูง](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## การติดตั้ง
```
pip install llama-github
```

## การใช้งาน

ตัวอย่างง่ายๆ ด้านล่างนี้แสดงวิธีการใช้ llama-github:

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
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
สำหรับการใช้งานขั้นสูงและตัวอย่างเพิ่มเติม กรุณาดูที่ [เอกสารประกอบ](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md)

## คุณสมบัติเด่น

- **🔍 การค้นหาข้อมูล GitHub อัจฉริยะ**: ใช้พลังของ llama-github เพื่อค้นหาชุดโค้ดที่เกี่ยวข้อง ปัญหา และข้อมูลของ repository จาก GitHub ตามคำถามของผู้ใช้ ด้วยเทคนิคการค้นหาขั้นสูง ช่วยให้คุณพบข้อมูลที่สำคัญได้อย่างรวดเร็วและมีประสิทธิภาพ

- **⚡ ระบบแคชพูล Repository**: Llama-github มีระบบแคชพูล repository ที่ล้ำสมัย โดยการแคช repository (รวมถึง README โครงสร้าง โค้ด และปัญหา) ข้ามเธรดต่างๆ llama-github ช่วยเพิ่มประสิทธิภาพการค้นหา GitHub ได้อย่างมากและลดการใช้โควต้าของ GitHub API สามารถนำไปใช้งานในสภาพแวดล้อม production แบบมัลติเธรดได้อย่างมั่นใจ

- **🧠 การวิเคราะห์คำถามด้วย LLM**: ใช้โมเดลภาษาอัจฉริยะวิเคราะห์คำถามผู้ใช้และสร้างกลยุทธ์การค้นหาที่มีประสิทธิภาพสูงสุด llama-github สามารถแยกคำถามที่ซับซ้อนออกเป็นส่วนๆ เพื่อให้มั่นใจว่าคุณจะได้ข้อมูลที่เกี่ยวข้องที่สุดจากเครือข่าย repository ขนาดใหญ่ของ GitHub

- **📚 การสร้างบริบทอย่างครอบคลุม**: สร้างคำตอบที่อุดมด้วยบริบทโดยผสมผสานข้อมูลที่ค้นหาจาก GitHub เข้ากับความสามารถในการให้เหตุผลของโมเดลภาษา Llama-github เชี่ยวชาญในการจัดการกับคำถามที่ซับซ้อนและยาวนาน พร้อมให้คำตอบที่ครอบคลุมและเจาะลึก รวมบริบทที่จำเป็นเพื่อสนับสนุนนักพัฒนา

- **🚀 ความเป็นเลิศด้านการประมวลผลแบบอะซิงโครนัส**: Llama-github ถูกออกแบบมาเพื่อใช้ศักยภาพของการโปรแกรมแบบอะซิงโครนัสอย่างเต็มที่ ด้วยกลไกอะซิงโครนัสที่สร้างขึ้นอย่างพิถีพิถันทั่วทั้งโค้ดเบส llama-github สามารถจัดการคำขอหลายรายการพร้อมกัน เพิ่มประสิทธิภาพโดยรวมอย่างมีนัยสำคัญ สัมผัสประสบการณ์การจัดการปริมาณงานสูงอย่างมีประสิทธิภาพโดยไม่ลดทอนความเร็วหรือคุณภาพ

- **🔧 การเชื่อมต่อ LLM ที่ยืดหยุ่น**: เชื่อมต่อ llama-github กับผู้ให้บริการ LLM ต่างๆ โมเดลฝังข้อมูล และโมเดล reranking ได้อย่างง่ายดาย เพื่อปรับแต่งความสามารถของไลบรารีให้เหมาะกับความต้องการของคุณ สถาปัตยกรรมที่ขยายได้ช่วยให้ปรับแต่งและเพิ่มขีดความสามารถของ llama-github ได้อย่างต่อเนื่อง

- **🔒 ตัวเลือกการยืนยันตัวตนที่แข็งแกร่ง**: Llama-github รองรับทั้ง personal access token และการยืนยันตัวตนแบบ GitHub App ทำให้คุณสามารถนำไปใช้กับสภาพแวดล้อมการพัฒนาที่หลากหลาย ไม่ว่าคุณจะเป็นนักพัฒนาเดี่ยวหรือองค์กร llama-github ก็มีระบบยืนยันตัวตนที่ปลอดภัยและน่าเชื่อถือรองรับ

- **🛠️ ระบบล็อกและจัดการข้อผิดพลาด**: เราเข้าใจถึงความสำคัญของการทำงานที่ราบรื่นและการแก้ไขปัญหาอย่างง่ายดาย ดังนั้น llama-github จึงมาพร้อมกับระบบล็อกและจัดการข้อผิดพลาดที่ครอบคลุม ให้คุณตรวจสอบพฤติกรรมของไลบรารีได้ลึกซึ้ง แก้ไขปัญหาได้อย่างรวดเร็ว และรักษาการพัฒนาให้มั่นคง

## 🤖 ทดลองผู้ช่วยรีวิว PR ด้วย AI: LlamaPReview

หากคุณพบว่า llama-github มีประโยชน์ คุณอาจสนใจผู้ช่วยรีวิว PR บน GitHub ด้วย AI ของเรา LlamaPReview ซึ่งออกแบบมาเพื่อเสริมเวิร์กโฟลว์นักพัฒนาและยกระดับคุณภาพโค้ด

### คุณสมบัติเด่นของ LlamaPReview:
- 🚀 ติดตั้งได้ในคลิกเดียว ไม่ต้องตั้งค่าหรือปรับแต่ง พร้อมใช้งานอัตโนมัติ
- 💯 ใช้ได้ฟรีในขณะนี้ - ไม่ต้องใช้บัตรเครดิตหรือข้อมูลการชำระเงิน
- 🧠 รีวิว PR อัตโนมัติด้วย AI พร้อมความเข้าใจโค้ดอย่างลึกซึ้ง
- 🌐 รองรับหลายภาษาโปรแกรม

**LlamaPReview ใช้การค้นหาบริบทขั้นสูงและการวิเคราะห์ด้วย LLM ของ llama-github** เพื่อให้รีวิวโค้ดที่ชาญฉลาดและเข้าใจบริบท เหมือนมีนักพัฒนาอาวุโสที่เข้าใจ repository ของคุณรีวิว PR ทุกครั้งให้อัตโนมัติ!

👉 [ติดตั้ง LlamaPReview ตอนนี้](https://github.com/marketplace/llamapreview/) (ฟรี)

การใช้ llama-github สำหรับค้นหาบริบทและ LlamaPReview สำหรับรีวิวโค้ด จะช่วยสร้างสภาพแวดล้อมการพัฒนาด้วย AI ที่ทรงพลัง

## วิสัยทัศน์และแผนพัฒนา

### วิสัยทัศน์

วิสัยทัศน์ของเราคือการเป็นโมดูลสำคัญในโซลูชันการพัฒนาแบบขับเคลื่อนด้วย AI ในอนาคต โดยผสานรวมกับ GitHub เพื่อสนับสนุน LLMs ในการแก้ปัญหางานเขียนโค้ดที่ซับซ้อนโดยอัตโนมัติ

![สถาปัตยกรรมวิสัยทัศน์](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### แผนพัฒนา

สำหรับรายละเอียดแผนพัฒนาโปรเจกต์ของเรา กรุณาเยี่ยมชม [แผนพัฒนาโครงการ](https://github.com/users/JetXu-LLM/projects/2)

## คำขอบคุณ

ขอขอบคุณโครงการโอเพ่นซอร์สต่อไปนี้สำหรับการสนับสนุนและมีส่วนร่วม:

- **[LangChain](https://github.com/langchain-ai/langchain)**: สำหรับการมอบเฟรมเวิร์กพื้นฐานที่ช่วยเสริมศักยภาพการ prompt และประมวลผล LLM ใน llama-github
- **[Jina.ai](https://github.com/jina-ai/reader)**: สำหรับการให้ API s.jina.ai และโมเดล reranker กับ embedding แบบโอเพ่นซอร์สที่ช่วยยกระดับความแม่นยำและความเกี่ยวข้องของบริบทที่สร้างขึ้นใน llama-github

การมีส่วนร่วมของพวกเขามีความสำคัญอย่างยิ่งต่อการพัฒนา llama-github และเราขอแนะนำให้ลองใช้งานโครงการเหล่านี้เพื่อโซลูชันที่ล้ำสมัย

## การร่วมพัฒนา

ยินดีต้อนรับการร่วมพัฒนา llama-github! กรุณาดู [แนวทางการร่วมพัฒนา](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) สำหรับข้อมูลเพิ่มเติม

## สัญญาอนุญาต

โปรเจกต์นี้ได้รับอนุญาตตามเงื่อนไขของ Apache 2.0 license ดูข้อมูลเพิ่มเติมได้ที่ [LICENSE](LICENSE)

## ติดต่อ

หากคุณมีคำถาม ข้อเสนอแนะ หรือความคิดเห็น กรุณาติดต่อเราที่ [อีเมลของ Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com)

---

ขอบคุณที่เลือกใช้ llama-github! หวังว่าไลบรารีนี้จะช่วยยกระดับประสบการณ์การพัฒนา AI ของคุณและช่วยให้คุณสร้างแอปพลิเคชันอันทรงพลังได้อย่างง่ายดาย



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---