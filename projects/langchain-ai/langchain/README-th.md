<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="โลโก้ LangChain" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![บันทึกการปล่อยเวอร์ชัน](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - License](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub star chart](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Open Issues](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Open in Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Open in Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> กำลังมองหาไลบรารี JS/TS อยู่ใช่ไหม? ดูได้ที่ [LangChain.js](https://github.com/langchain-ai/langchainjs)

LangChain คือเฟรมเวิร์กสำหรับสร้างแอปพลิเคชันที่ขับเคลื่อนด้วย LLM ช่วยให้คุณเชื่อมโยงคอมโพเนนต์ที่ทำงานร่วมกันได้และอินทิเกรชันของบุคคลที่สาม เพื่อให้ง่ายต่อการพัฒนาแอปพลิเคชัน AI — พร้อมทั้งรองรับการเปลี่ยนแปลงของเทคโนโลยีในอนาคต

```bash
pip install -U langchain
```

หากต้องการเรียนรู้เพิ่มเติมเกี่ยวกับ LangChain โปรดดูที่
[เอกสาร](https://python.langchain.com/docs/introduction/) หากคุณกำลังมองหาการปรับแต่งขั้นสูงหรือการจัดการเอเจนต์ ดูที่
[LangGraph](https://langchain-ai.github.io/langgraph/) เฟรมเวิร์กสำหรับสร้างเวิร์กโฟลว์เอเจนต์ที่ควบคุมได้ของเรา

## ทำไมต้องใช้ LangChain?

LangChain ช่วยให้นักพัฒนาสร้างแอปพลิเคชันที่ขับเคลื่อนโดย LLM ผ่านอินเทอร์เฟซมาตรฐานสำหรับโมเดล, การฝัง, เวกเตอร์สโตร์ และอื่นๆ

ใช้ LangChain สำหรับ:
- **การเสริมข้อมูลแบบเรียลไทม์** เชื่อมต่อ LLM กับแหล่งข้อมูลที่หลากหลายและระบบภายนอก/ภายในได้อย่างง่ายดาย โดยอาศัยไลบรารีอินทิเกรชันจำนวนมากของ LangChain กับผู้ให้บริการโมเดล, เครื่องมือ, เวกเตอร์สโตร์, ตัวดึงข้อมูล และอื่นๆ
- **การทำงานร่วมกันของโมเดล** เปลี่ยนโมเดลไปมาได้ง่ายขณะทีมวิศวกรของคุณทดลองหาโมเดลที่ดีที่สุดสำหรับความต้องการของแอปพลิเคชัน เมื่ออุตสาหกรรมเปลี่ยนแปลงอย่างรวดเร็ว LangChain จะช่วยให้คุณปรับตัวได้ไวด้วยโครงสร้างนามธรรมโดยไม่สูญเสียความต่อเนื่อง

## ระบบนิเวศของ LangChain
แม้ว่าเฟรมเวิร์ก LangChain จะสามารถใช้งานเดี่ยวได้ แต่ยังสามารถผสานรวมกับผลิตภัณฑ์ LangChain อื่นๆ ได้อย่างไร้รอยต่อ มอบชุดเครื่องมือครบวงจรให้นักพัฒนาในการสร้างแอป LLM

เพื่อยกระดับการพัฒนาแอป LLM ของคุณ ควรใช้ LangChain ร่วมกับ:

- [LangSmith](http://www.langchain.com/langsmith) - มีประโยชน์สำหรับการประเมินเอเจนต์และการตรวจสอบการทำงาน แก้ไขการทำงานของแอป LLM ที่มีประสิทธิภาพต่ำ ประเมินเส้นทางของเอเจนต์ มองเห็นการทำงานใน production และปรับปรุงประสิทธิภาพอย่างต่อเนื่อง
- [LangGraph](https://langchain-ai.github.io/langgraph/) - สร้างเอเจนต์ที่จัดการงานซับซ้อนได้อย่างน่าเชื่อถือด้วย LangGraph เฟรมเวิร์กจัดการเอเจนต์ระดับล่างของเรา LangGraph มีสถาปัตยกรรมที่ปรับแต่งได้ หน่วยความจำระยะยาว และเวิร์กโฟลว์ที่มีมนุษย์ร่วมตัดสินใจ — บริษัทชั้นนำอย่าง LinkedIn, Uber, Klarna และ GitLab ไว้วางใจใช้งานใน production
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - ปรับใช้และขยายขีดความสามารถของเอเจนต์ได้อย่างง่ายดายด้วยแพลตฟอร์มที่ออกแบบมาเฉพาะสำหรับเวิร์กโฟลว์ที่ใช้เวลานานและมีสถานะ ค้นหา นำกลับมาใช้ใหม่ กำหนดค่า และแชร์เอเจนต์ข้ามทีม — และปรับแต่งได้รวดเร็วด้วยการสร้างต้นแบบแบบภาพใน
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/)

## แหล่งข้อมูลเพิ่มเติม
- [บทเรียน](https://python.langchain.com/docs/tutorials/): ตัวอย่างแนะนำแบบง่ายๆ สำหรับเริ่มต้นใช้งาน LangChain
- [คู่มือวิธีใช้](https://python.langchain.com/docs/how_to/): โค้ดตัวอย่างสั้นๆ สำหรับหัวข้อต่างๆ เช่น การเรียกใช้เครื่องมือ, กรณีใช้งาน RAG และอื่นๆ
- [คู่มือเชิงแนวคิด](https://python.langchain.com/docs/concepts/): อธิบายแนวคิดหลักเบื้องหลังเฟรมเวิร์ก LangChain
- [API Reference](https://python.langchain.com/api_reference/): คู่มืออ้างอิงโดยละเอียดสำหรับใช้งานแพ็กเกจหลักและอินทิเกรชันของ LangChain

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---