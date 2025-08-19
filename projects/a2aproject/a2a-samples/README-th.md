# ตัวอย่าง Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="ลองใช้ใน Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ภาษาไทย</a>
    </div>
  </details>
</div>

คลังข้อมูลนี้ประกอบด้วยตัวอย่างโค้ดและเดโมที่ใช้ [Agent2Agent (A2A) Protocol](https://goo.gle/a2a)

## คลังข้อมูลที่เกี่ยวข้อง

- [A2A](https://github.com/a2aproject/A2A) - ข้อกำหนดและเอกสารของ A2A
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK ภาษา Python สำหรับ A2A
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - เครื่องมือ UI สำหรับตรวจสอบ Agent ที่รองรับ A2A

## การมีส่วนร่วม

ยินดีรับข้อเสนอแนะ! ดูที่ [คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md)

## การขอความช่วยเหลือ

โปรดใช้ [หน้าปัญหา](https://github.com/a2aproject/a2a-samples/issues) เพื่อเสนอข้อคิดเห็น ข้อเสนอแนะ หรือแจ้งข้อบกพร่อง

## ข้อจำกัดความรับผิดชอบ

คลังข้อมูลนี้ไม่ได้เป็นผลิตภัณฑ์ที่ได้รับการสนับสนุนอย่างเป็นทางการจาก Google โค้ดในคลังนี้มีไว้เพื่อการสาธิตเท่านั้น

สำคัญ: โค้ดตัวอย่างที่ให้ไว้มีไว้เพื่อการสาธิตและแสดงกลไกของโปรโตคอล Agent-to-Agent (A2A) เมื่อสร้างแอปพลิเคชันสำหรับใช้งานจริง จำเป็นต้องพิจารณาว่า Agent ใด ๆ ที่ดำเนินการนอกเหนือจากการควบคุมโดยตรงของคุณอาจเป็นสิ่งที่ไม่น่าไว้วางใจ

ข้อมูลทั้งหมดที่ได้รับจาก Agent ภายนอก—รวมถึงแต่ไม่จำกัดเฉพาะ AgentCard, ข้อความ, สิ่งประดิษฐ์ และสถานะงาน—ควรถือว่าเป็นข้อมูลที่ไม่น่าไว้วางใจ ตัวอย่างเช่น Agent ที่เป็นอันตรายอาจให้ AgentCard ที่มีข้อมูลที่ถูกปรับแต่งในฟิลด์ต่าง ๆ (เช่น คำอธิบาย, ชื่อ, skills.description) หากข้อมูลนี้ถูกนำไปใช้โดยไม่ผ่านการกรองเพื่อสร้าง prompt สำหรับ Large Language Model (LLM) อาจทำให้แอปพลิเคชันของคุณเสี่ยงต่อการโจมตีแบบ prompt injection ได้ การไม่ตรวจสอบและกรองข้อมูลเหล่านี้ก่อนนำไปใช้ อาจทำให้เกิดช่องโหว่ด้านความปลอดภัยในแอปพลิเคชันของคุณ

นักพัฒนามีหน้าที่ในการใช้มาตรการรักษาความปลอดภัยที่เหมาะสม เช่น การตรวจสอบข้อมูลและการจัดการข้อมูลลับอย่างปลอดภัย เพื่อปกป้องระบบและผู้ใช้ของตน


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---