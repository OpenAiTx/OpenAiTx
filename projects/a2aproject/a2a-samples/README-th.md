# ตัวอย่าง Agent2Agent (A2A)

<div style="text-align: right;">
  <details>
    <summary>🌐 ภาษา</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

ที่เก็บนี้มีตัวอย่างโค้ดและเดโมซึ่งใช้ [โปรโตคอล Agent2Agent (A2A)](https://goo.gle/a2a)

## ที่เก็บที่เกี่ยวข้อง

- [A2A](https://github.com/a2aproject/A2A) - ข้อกำหนดและเอกสารของ A2A
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - เครื่องมือ UI สำหรับตรวจสอบเอเจนต์ที่เปิดใช้งาน A2A

## การมีส่วนร่วม

ยินดีต้อนรับทุกการมีส่วนร่วม! ดู [คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)

## การขอความช่วยเหลือ

โปรดใช้ [หน้ารายงานปัญหา](https://github.com/a2aproject/a2a-samples/issues) เพื่อให้ข้อเสนอแนะ ติชม หรือแจ้งบั๊ก

## ข้อสงวนสิทธิ์

ที่เก็บนี้ไม่ได้เป็นผลิตภัณฑ์ที่ได้รับการสนับสนุนอย่างเป็นทางการจาก Google โค้ดในที่เก็บนี้มีไว้เพื่อวัตถุประสงค์ในการสาธิตเท่านั้น

สำคัญ: โค้ดตัวอย่างที่ให้มานี้มีไว้เพื่อการสาธิตและแสดงให้เห็นกลไกของโปรโตคอล Agent-to-Agent (A2A) เมื่อสร้างแอปพลิเคชันสำหรับใช้งานจริง จำเป็นต้องถือว่าเอเจนต์ใดๆ ที่อยู่นอกเหนือการควบคุมของคุณโดยตรงเป็นสิ่งที่อาจไม่น่าเชื่อถือ

ข้อมูลทั้งหมดที่ได้รับจากเอเจนต์ภายนอก รวมถึงแต่ไม่จำกัดเพียง AgentCard ของเอเจนต์ ข้อความ สิ่งประดิษฐ์ และสถานะงาน ควรได้รับการจัดการในฐานะอินพุตที่ไม่น่าเชื่อถือ ตัวอย่างเช่น เอเจนต์ที่เป็นอันตรายอาจให้ AgentCard ที่มีข้อมูลที่สร้างขึ้นในฟิลด์ของตน (เช่น คำอธิบาย ชื่อ skills.description) หากนำข้อมูลนี้ไปใช้โดยไม่ผ่านกระบวนการทำความสะอาดเพื่อสร้างพรอมต์ให้กับ Large Language Model (LLM) อาจทำให้แอปพลิเคชันของคุณเสี่ยงต่อการโจมตีแบบ prompt injection การไม่ตรวจสอบและทำความสะอาดข้อมูลนี้ก่อนใช้งานอาจก่อให้เกิดช่องโหว่ด้านความปลอดภัยในแอปพลิเคชันของคุณ

นักพัฒนาต้องรับผิดชอบในการใช้มาตรการรักษาความปลอดภัยที่เหมาะสม เช่น การตรวจสอบอินพุตและการจัดการข้อมูลรับรองอย่างปลอดภัยเพื่อปกป้องระบบและผู้ใช้ของตนเอง


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---