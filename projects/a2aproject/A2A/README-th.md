# โปรโตคอล Agent2Agent (A2A)

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="ถาม Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 ภาษา</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>โปรโตคอล Agent2Agent (A2A)</h1>
  </div>
</div>

**โปรโตคอลเปิดที่ช่วยให้การสื่อสารและการทำงานร่วมกันระหว่างแอปพลิเคชันเอเจนต์แบบ opaque เป็นไปได้**

โปรโตคอล Agent2Agent (A2A) ได้แก้ปัญหาสำคัญในวงการ AI: การทำให้เอเจนต์ gen AI ที่สร้างขึ้นจากเฟรมเวิร์กต่าง ๆ โดยบริษัทต่าง ๆ ที่ทำงานบนเซิร์ฟเวอร์แยกกัน สามารถสื่อสารและร่วมมือกันได้อย่างมีประสิทธิภาพ - ในฐานะเอเจนต์ ไม่ใช่แค่เครื่องมือเท่านั้น A2A มุ่งมั่นที่จะให้ภาษากลางสำหรับเอเจนต์ ส่งเสริมระบบนิเวศ AI ที่เชื่อมโยงกันมากขึ้น ทรงพลัง และสร้างสรรค์

ด้วย A2A เอเจนต์สามารถ:

- ค้นพบความสามารถของกันและกัน
- เจรจาวิธีการโต้ตอบ (ข้อความ ฟอร์ม สื่อ)
- ร่วมมือกันอย่างปลอดภัยในงานระยะยาว
- ทำงานโดยไม่เปิดเผยสถานะภายใน หน่วยความจำ หรือเครื่องมือ

## คอร์ส DeepLearning.AI

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

เข้าร่วมคอร์สสั้นนี้เกี่ยวกับ [A2A: โปรโตคอล Agent2Agent](https://goo.gle/dlai-a2a) ที่สร้างร่วมกับ Google Cloud และ IBM Research และสอนโดย [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), และ [Sandi Besen](https://github.com/sandijean90)

**สิ่งที่คุณจะได้เรียนรู้:**

- **ทำให้เอเจนต์สอดคล้องกับ A2A:** เปิดเผยเอเจนต์ที่สร้างด้วยเฟรมเวิร์ก เช่น Google ADK, LangGraph หรือ BeeAI ในรูปแบบเซิร์ฟเวอร์ A2A
- **เชื่อมต่อเอเจนต์:** สร้างไคลเอนต์ A2A จากศูนย์หรือใช้การเชื่อมต่อเพื่อเชื่อมต่อกับเอเจนต์ที่สอดคล้องกับ A2A
- **จัดการเวิร์กโฟลว์:** สร้างเวิร์กโฟลว์แบบลำดับและแบบลำดับชั้นของเอเจนต์ที่สอดคล้องกับ A2A
- **ระบบหลายเอเจนต์:** สร้างระบบหลายเอเจนต์ด้านสุขภาพด้วยเฟรมเวิร์กต่าง ๆ และดูว่า A2A ช่วยการร่วมมือได้อย่างไร
- **A2A และ MCP:** เรียนรู้ว่า A2A เสริม MCP ด้วยการทำให้เอเจนต์ร่วมมือกันได้อย่างไร

## ทำไมต้อง A2A?

เมื่อเอเจนต์ AI มีบทบาทมากขึ้น ความสามารถในการทำงานร่วมกันเป็นสิ่งสำคัญสำหรับการสร้างแอปพลิเคชันที่ซับซ้อนและมีฟังก์ชันหลากหลาย A2A มีเป้าหมายที่จะ:

- **ลดการแบ่งแยก:** เชื่อมต่อเอเจนต์ข้ามระบบนิเวศต่าง ๆ
- **สร้างการร่วมมือที่ซับซ้อน:** ให้เอเจนต์เฉพาะทางทำงานร่วมกันในงานที่เอเจนต์เดียวไม่สามารถจัดการได้
- **ส่งเสริมมาตรฐานเปิด:** ผลักดันแนวทางขับเคลื่อนโดยชุมชนเพื่อการสื่อสารของเอเจนต์ ส่งเสริมนวัตกรรมและการนำไปใช้ในวงกว้าง
- **รักษาความ opaque:** ให้เอเจนต์ร่วมมือกันโดยไม่ต้องเปิดเผยหน่วยความจำภายใน โลจิกเฉพาะ หรือการใช้งานเครื่องมือ เพิ่มความปลอดภัยและปกป้องทรัพย์สินทางปัญญา

### คุณสมบัติเด่น

- **การสื่อสารมาตรฐาน:** JSON-RPC 2.0 ผ่าน HTTP(S)
- **การค้นหาเอเจนต์:** ผ่าน "Agent Cards" ที่แสดงความสามารถและข้อมูลการเชื่อมต่อ
- **การโต้ตอบที่ยืดหยุ่น:** รองรับการร้องขอ/ตอบกลับแบบ synchronous, การสตรีม (SSE), และการแจ้งเตือนแบบ asynchronous push
- **การแลกเปลี่ยนข้อมูลที่หลากหลาย:** รองรับข้อความ, ไฟล์, และข้อมูล JSON ที่มีโครงสร้าง
- **พร้อมสำหรับองค์กร:** ออกแบบโดยคำนึงถึงความปลอดภัย, การรับรองตัวตน, และการสังเกตการณ์

## เริ่มต้นใช้งาน

- 📚 **สำรวจเอกสาร:** เยี่ยมชม [เว็บไซต์เอกสาร Agent2Agent Protocol](https://a2a-protocol.org) เพื่อดูภาพรวม, สเปคโปรโตคอลฉบับเต็ม, บทเรียน และคู่มือ
- 📝 **ดูสเปคโปรโตคอล:** [A2A Protocol Specification](https://a2a-protocol.org/latest/specification/)
- ใช้ SDK ต่าง ๆ :
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) ใช้ maven
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) ใช้ [NuGet](https://www.nuget.org/packages/A2A) `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 ใช้ [ตัวอย่าง](https://github.com/a2aproject/a2a-samples) ของเราเพื่อดูการทำงานของ A2A

## การมีส่วนร่วม

เรายินดีต้อนรับการมีส่วนร่วมจากชุมชนเพื่อพัฒนาและต่อยอดโปรโตคอล A2A!

- **คำถาม & การอภิปราย:** เข้าร่วม [GitHub Discussions](https://github.com/a2aproject/A2A/discussions)
- **ปัญหา & ข้อเสนอแนะ:** รายงานปัญหาหรือเสนอปรับปรุงผ่าน [GitHub Issues](https://github.com/a2aproject/A2A/issues)
- **คู่มือการมีส่วนร่วม:** ดู [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) สำหรับรายละเอียดเกี่ยวกับการมีส่วนร่วม
- **ข้อเสนอแนะส่วนตัว:** ใช้ [Google Form](https://goo.gle/a2a-feedback) นี้
- **โปรแกรมพันธมิตร:** ลูกค้า Google Cloud สามารถเข้าร่วมโปรแกรมพันธมิตรผ่าน [ฟอร์มนี้](https://goo.gle/a2a-partner)

## สิ่งที่จะเกิดขึ้นต่อไป

### การปรับปรุงโปรโตคอล

- **การค้นหาเอเจนต์:**
    - กำหนดอย่างเป็นทางการให้รวมรูปแบบการอนุญาตและข้อมูลรับรองที่เป็นทางเลือกไว้ใน `AgentCard`
- **ความร่วมมือระหว่างเอเจนต์:**
    - ศึกษาวิธี `QuerySkill()` สำหรับตรวจสอบทักษะที่ไม่รองรับหรือไม่คาดคิดแบบไดนามิก
- **วงจรชีวิตของงาน & UX:**
    - รองรับการเจรจา UX แบบไดนามิก _ภายใน_ งาน (เช่น ตัวแทนเพิ่มเสียง/วิดีโอกลางการสนทนา)
- **วิธีการของไคลเอนต์ & การขนส่ง:**
    - สำรวจการขยายการรองรับวิธีการที่ไคลเอนต์เริ่มต้น (นอกเหนือจากการจัดการงาน)
    - ปรับปรุงความน่าเชื่อถือของการสตรีมและกลไกการแจ้งเตือนแบบพุช

## เกี่ยวกับ

โปรโตคอล A2A เป็นโครงการโอเพนซอร์สภายใต้ Linux Foundation โดยได้รับการสนับสนุนจาก Google โครงการนี้อยู่ภายใต้ [Apache License 2.0](LICENSE) และเปิดรับการมีส่วนร่วมจากชุมชน


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---