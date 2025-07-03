# Tome - หนังสือเวทมนตร์ AI สุดมหัศจรรย์

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>แอปเดสก์ท็อปมหัศจรรย์ที่นำพลังของ LLMs และ MCP มาไว้ในมือทุกคน</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 ดาวน์โหลดแอป Tome สำหรับเดสก์ท็อป: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome คือแอปเดสก์ท็อปที่ให้ **ทุกคน** สามารถใช้เวทมนตร์ของ LLMs และ MCP ได้ เพียงดาวน์โหลด Tome เชื่อมต่อ LLM ที่เป็นของคุณเอง ไม่ว่าจะเป็นแบบ local หรือ remote และเชื่อมต่อกับ MCP server หลายพันตัว เพื่อสร้างหนังสือเวทมนตร์ AI ส่วนตัวของคุณเอง

🫥 ต้องการให้ทุกอย่างอยู่ในเครื่องคุณเองและเป็นส่วนตัว 100%? ใช้ Ollama และ Qwen3 ร่วมกับ MCP server ที่อยู่ในเครื่องเท่านั้น เพื่อร่ายเวทมนตร์ในจักรวาลส่วนตัวของคุณ ⚡ หากต้องการโมเดล cloud ล่าสุดพร้อม MCP server แบบ remote ที่ทันสมัยที่สุดก็สามารถทำได้ ขึ้นอยู่กับคุณ!

🏗️ นี่คือเวอร์ชันทดลองทางเทคนิค (Technical Preview) โปรดเข้าใจว่าอาจจะยังไม่สมบูรณ์ [เข้าร่วมกับเราบน Discord](https://discord.gg/9CH6us29YA) เพื่อแบ่งปันเคล็ดลับ เทคนิค และแจ้งปัญหาต่าง ๆ กดดาว repo นี้เพื่อรับข่าวสารอัปเดตและฟีเจอร์ใหม่ ๆ!

## 🪄 ฟีเจอร์เด่น

- 🧙 **ประสบการณ์ที่ง่ายและเหมาะกับผู้เริ่มต้น**
  - เพียงดาวน์โหลด ติดตั้ง Tome และเชื่อมต่อ LLM ที่คุณต้องการ
  - ไม่ต้องยุ่งกับ JSON, Docker, python หรือ node
- 🤖 **รองรับโมเดล AI หลากหลาย**
  - **Remote**: Google Gemini, OpenAI, หรือ endpoint ที่รองรับ OpenAI API
  - **Local**: Ollama, LM Studio, Cortex, หรือ endpoint ที่รองรับ OpenAI API
- 🔮 **รองรับ MCP ขั้นสูง**
  - มี UI สำหรับติดตั้ง ลบ เปิด/ปิด MCP server
  - รองรับ MCP server จาก npm, uvx, node, python ในตัว
- 🏪 **เชื่อมต่อกับ [Smithery.ai](https://smithery.ai) registry**
  - มี MCP server ให้เลือกติดตั้งได้มากมายเพียงคลิกเดียว
- ✏️ **ปรับแต่ง context windows และ temperature ได้**
- 🧰 **รองรับเครื่องมือและ reasoning models ในตัว**
  - UI มีการแสดงผลแยกเครื่องมือและข้อความการคิดอย่างชัดเจน

## เดโม

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# เริ่มต้นใช้งาน

## ความต้องการ

- MacOS หรือ Windows (Linux กำลังจะมาเร็ว ๆ นี้!)
- ผู้ให้บริการ LLM ที่คุณเลือก: [Ollama](https://ollama.com/) หรือ [Gemini API key](https://aistudio.google.com/app/apikey) ใช้งานง่าย/ฟรี
- [ดาวน์โหลด Tome เวอร์ชันล่าสุด](https://github.com/runebookai/tome/releases)

## เริ่มใช้งานอย่างรวดเร็ว

1. ติดตั้ง [Tome](https://github.com/runebookai/tome/releases)
2. เชื่อมต่อผู้ให้บริการ LLM ที่คุณต้องการ - OpenAI, Ollama และ Gemini ตั้งค่าไว้ให้แล้ว หรือจะเพิ่มผู้ให้บริการเช่น LM Studio โดยใช้ URL http://localhost:1234/v1 ก็ได้
3. เปิดแท็บ MCP ใน Tome และติดตั้ง [MCP server](https://github.com/modelcontextprotocol/servers) ตัวแรกของคุณ (Fetch เป็นตัวที่เริ่มต้นได้ง่าย เพียงวาง `uvx mcp-server-fetch` ในช่อง server)
4. สนทนากับโมเดลที่ขับเคลื่อนด้วย MCP ของคุณ! ลองขอให้มันดึงข่าวเด่นใน Hacker News มาให้

# วิสัยทัศน์

เราต้องการให้ LLMs และ MCP แบบ local เข้าถึงได้สำหรับทุกคน เรากำลังสร้างเครื่องมือที่ช่วยให้คุณสร้างสรรค์กับ LLMs ไม่ว่าคุณจะเป็นวิศวกร นักทดลอง นักเล่น หรือใครก็ตาม

## หลักการสำคัญ

- **Tome เน้น local ก่อน:** คุณควบคุมได้ว่าข้อมูลของคุณจะไปที่ไหน
- **Tome สำหรับทุกคน:** คุณไม่จำเป็นต้องจัดการกับภาษาโปรแกรม ตัวจัดการแพ็คเกจ หรือไฟล์ config แบบ json

## สิ่งที่กำลังจะตามมา

เราได้รับฟีดแบคที่ยอดเยี่ยมมากมายในช่วงไม่กี่สัปดาห์นับตั้งแต่เปิดตัว Tome แต่เรายังมีแผนใหญ่สำหรับอนาคต เราต้องการให้ LLMs ออกจากกล่องแชท และเรามีฟีเจอร์อีกมากมายที่กำลังจะมาเพื่อช่วยให้ทุกคนทำสิ่งนั้นได้

- งานตามเวลา: LLMs ควรทำสิ่งที่เป็นประโยชน์แม้คุณจะไม่ได้อยู่หน้าคอมพิวเตอร์
- การเชื่อมต่อกับเครื่องมือโดยตรง: MCP server เป็นวิธีที่ดีในการเข้าถึงเครื่องมือและข้อมูล แต่เราต้องการเพิ่มการเชื่อมต่อที่ทรงพลังมากขึ้นเพื่อโต้ตอบกับ LLMs อย่างโดดเด่น
- สร้างแอป: เราเชื่อว่าในระยะยาว ประสบการณ์ที่ดีที่สุดจะไม่อยู่แค่ในกล่องแชท เรามีแผนจะเพิ่มเครื่องมือเพิ่มเติมเพื่อให้คุณสร้างแอปพลิเคชันและเวิร์กโฟลว์ที่ทรงพลังได้
- ??? บอกเราว่าคุณอยากเห็นอะไร! เข้าร่วมชุมชนของเราผ่านลิงก์ด้านล่าง เรายินดีรับฟังความคิดเห็นจากคุณ

# ชุมชน

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---