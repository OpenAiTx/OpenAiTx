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

ขอต้อนรับสู่ตัวอย่างโค้ดและการสาธิตอย่างเป็นทางการสำหรับ [โปรโตคอล Agent2Agent (A2A)](https://goo.gle/a2a)

เรารู้สึกยินดีที่คุณมาเยี่ยมชม! ไม่ว่าคุณจะกำลังสำรวจสถาปัตยกรรมหลายเอเจนต์เป็นครั้งแรก หรือกำลังสร้างเครือข่ายเอเจนต์ที่สามารถทำงานร่วมกันขั้นสูง ที่เก็บนี้ให้แหล่งข้อมูลการเรียนรู้ที่เรียบง่าย น่าสนใจ และเข้าถึงได้ เพื่อเร่งการพัฒนาของคุณ

## ทำไมต้อง Agent2Agent?

ในโลกที่มีกรอบและระบบนิเวศ AI หลากหลาย เอเจนต์จำเป็นต้องมีภาษากลางในการสื่อสาร ทำงานร่วมกัน และมอบหมายงานอย่างปลอดภัย โปรโตคอล A2A กำหนดมาตรฐานเปิดสำหรับการทำงานร่วมกันของหลายเอเจนต์

ตัวอย่างของเราสาธิตว่าปัญหาหลายเอเจนต์ที่ซับซ้อนสามารถแก้ไขได้อย่างง่ายดายข้ามภาษาและแอปพลิเคชันโฮสต์ต่าง ๆ

## เริ่มต้นอย่างรวดเร็ว

เริ่มต้นใช้งานทันทีโดยเปิดตัวเอเจนต์ Helloworld และสื่อสารกับมันผ่าน Python CLI host ของเรา

1. **เริ่ม Agent Server**:
   เปิดเทอร์มินัลและเริ่มเซิร์ฟเวอร์เอเจนต์ Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```
2. **เรียกใช้ Host Client**:
   เปิดเทอร์มินัลที่สองและเรียกใช้ CLI client เพื่อส่งงานไปยัง agent:


   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## โครงสร้างที่เก็บซอร์สโค้ด (Repository Structure)

ที่เก็บซอร์สโค้ดถูกจัดแบ่งเป็นไดเรกทอรีย่อยหลักตามภาษาโปรแกรม:

| ไดเรกทอรี | คำอธิบาย |
| --- | --- |
| [samples](/samples) | ตัวอย่างหลักของ A2A จัดเรียงตามภาษาโปรแกรม |
| [samples/python](/samples/python) | สาธิตการใช้งานเอเจนต์ภาษา Python ด้วย A2A Python SDK |
| [samples/go](/samples/go) | สาธิตการใช้งานเอเจนต์ภาษา Go ด้วย A2A Go SDK |
| [samples/dotnet](/samples/dotnet) | สาธิตการใช้งานเอเจนต์ภาษา C# ด้วย A2A .NET SDK |
| [samples/java](/samples/java) | สาธิตการใช้งานเอเจนต์ภาษา Java ด้วย A2A Java SDK |
| [samples/js](/samples/js) | สาธิตการใช้งานเอเจนต์ Node.js ด้วย A2A JavaScript SDK |

## การมีส่วนร่วม

เรายินดีและสนับสนุนทุกการมีส่วนร่วม ไม่ว่าคุณจะมีทักษะในระดับใด! หากคุณมีไอเดียสำหรับตัวอย่างใหม่ๆ การแก้ไขบั๊ก หรือปรับปรุงเอกสาร กรุณาอ่าน [คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) ของเรา

## การขอความช่วยเหลือ

เรามุ่งมั่นที่จะสร้างชุมชนที่เป็นมิตรและสนับสนุน หากคุณมีคำถาม ข้อเสนอแนะ หรือพบปัญหาใด ๆ กรุณาติดต่อเราที่ [หน้ารายงานปัญหา](https://github.com/a2aproject/a2a-samples/issues)

## ที่เก็บซอร์สโค้ดที่เกี่ยวข้อง

| ที่เก็บ | หมวดหมู่ | คำอธิบาย |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | ข้อกำหนดหลัก | เอกสารและข้อกำหนดของ A2A |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | เครื่องมือ | เครื่องมือ UI สำหรับตรวจสอบเอเจนต์ที่รองรับ A2A |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | ทดสอบ | ชุดทดสอบสำหรับตรวจสอบความถูกต้องตามโปรโตคอล A2A |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | ทดสอบ | ชุดเครื่องมือสำหรับตรวจสอบความเข้ากันได้ข้าม SDK และเวอร์ชันต่าง ๆ โดยใช้โมเดล multi-hop และโปรโตคอลรับส่งหลากหลายรูปแบบ |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | SDK ภาษา Python อย่างเป็นทางการสำหรับ A2A |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | SDK ภาษา Go อย่างเป็นทางการสำหรับ A2A |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | SDK ภาษา Java อย่างเป็นทางการสำหรับ A2A |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | SDK Node.js/JavaScript อย่างเป็นทางการสำหรับ A2A |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | SDK ภาษา C#/.NET อย่างเป็นทางการสำหรับ A2A |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | SDK ภาษา Rust อย่างเป็นทางการสำหรับ A2A |

## ข้อจำกัดความรับผิดชอบ

**สำคัญ:** ตัวอย่างโค้ดที่ให้ไว้มีไว้เพื่อการสาธิตและอธิบายกลไกของ
โปรโตคอล Agent-to-Agent (A2A) เมื่อสร้างแอปพลิเคชันในสภาพการใช้งานจริง สิ่งสำคัญคือการปฏิบัติต่อเอเจนต์ใด ๆ ที่ดำเนินการนอกเหนือการควบคุมโดยตรงของคุณเป็นหน่วยที่อาจไม่น่าไว้วางใจ

ข้อมูลทั้งหมดที่ได้รับจากเอเจนต์ภายนอก—including แต่ไม่จำกัดเพียง AgentCard, ข้อความ,
สิ่งประดิษฐ์, และสถานะงาน—ควรได้รับการจัดการในฐานะข้อมูลที่ไม่น่าไว้วางใจ ตัวอย่างเช่น เอเจนต์ที่เป็นอันตราย
อาจให้ AgentCard ที่มีข้อมูลที่ถูกสร้างขึ้นในช่องต่าง ๆ (เช่น คำอธิบาย, ชื่อ,
skills.description) หากข้อมูลนี้ถูกใช้โดยไม่ผ่านการตรวจสอบเพื่อสร้างพรอมต์ให้กับโมเดลภาษาใหญ่ (LLM)
อาจทำให้แอปพลิเคชันของคุณเสี่ยงต่อการโจมตีด้วยการฉีดพรอมต์ หากไม่ตรวจสอบและทำความสะอาดข้อมูลนี้อย่างถูกต้องก่อนใช้งาน
อาจทำให้เกิดช่องโหว่ด้านความปลอดภัยในแอปพลิเคชันของคุณ

> นักพัฒนาต้องรับผิดชอบในการนำมาตรการรักษาความปลอดภัยที่เหมาะสมมาใช้ เช่น การตรวจสอบข้อมูลนำเข้า
> และการจัดการข้อมูลรับรองอย่างปลอดภัยเพื่อปกป้องระบบและผู้ใช้งานของตน




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---