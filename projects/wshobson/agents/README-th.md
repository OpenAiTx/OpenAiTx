<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ชุดรวม Claude Code Subagents

คอลเลกชันชุดรวมของซับเอเจนต์ AI เฉพาะทางสำหรับ [Claude Code](https://docs.anthropic.com/en/docs/claude-code) ออกแบบมาเพื่อยกระดับเวิร์กโฟลว์การพัฒนาด้วยความเชี่ยวชาญเฉพาะด้าน

## ภาพรวม

ที่เก็บนี้ประกอบด้วยซับเอเจนต์เฉพาะทาง 61 ตัวที่ช่วยขยายขีดความสามารถของ Claude Code แต่ละซับเอเจนต์เป็นผู้เชี่ยวชาญในสาขาเฉพาะทาง ถูกเรียกใช้อัตโนมัติตามบริบทหรือเรียกใช้โดยตรงเมื่อจำเป็น ทุกเอเจนต์ถูกกำหนดค่าด้วยโมเดล Claude ตามความซับซ้อนของงานเพื่อประสิทธิภาพและความคุ้มค่าสูงสุด

## ซับเอเจนต์ที่มีให้ใช้งาน

### การพัฒนาและสถาปัตยกรรม
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - ออกแบบ RESTful APIs, ขอบเขตไมโครเซอร์วิส และสคีมาฐานข้อมูล
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - สร้างคอมโพเนนต์ React, ออกแบบเลย์เอาต์ที่ตอบสนอง และจัดการสถานะฝั่งลูกค้า
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - สร้างดีไซน์อินเทอร์เฟซ, ไวร์เฟรม และระบบดีไซน์
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - พัฒนาแอป React Native หรือ Flutter พร้อมการผสานงานกับ native
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - ออกแบบ GraphQL schema, resolver และ federation
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - ตรวจสอบการเปลี่ยนแปลงโค้ดเพื่อความสอดคล้องและรูปแบบทางสถาปัตยกรรม

### ผู้เชี่ยวชาญด้านภาษา
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - เขียนโค้ด Python อย่างมีประสิทธิภาพด้วยฟีเจอร์ขั้นสูงและการปรับแต่ง
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - เขียนโค้ด Ruby อย่างมีประสิทธิภาพด้วย metaprogramming, รูปแบบ Rails, การพัฒนา gem และเฟรมเวิร์กทดสอบ
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - เขียนโค้ด Go อย่างมีประสิทธิภาพด้วย goroutine, channel และ interface
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - เขียนโค้ด Rust อย่างเหมาะสมด้วยรูปแบบ ownership, lifetime และการ implement trait
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - เขียนโค้ด C อย่างมีประสิทธิภาพด้วยการจัดการหน่วยความจำและ system call ที่ถูกต้อง
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - เขียนโค้ด C++ อย่างเหมาะสมด้วยฟีเจอร์สมัยใหม่, RAII, smart pointer และอัลกอริทึม STL
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - เชี่ยวชาญ JavaScript สมัยใหม่ด้วย ES6+, รูปแบบ async และ Node.js API
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - เชี่ยวชาญ TypeScript ด้วย type ขั้นสูง, generic และความปลอดภัยของ type ที่เข้มงวด
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - เขียนโค้ด PHP อย่างเหมาะสมด้วยฟีเจอร์สมัยใหม่และการปรับปรุงประสิทธิภาพ
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - เชี่ยวชาญ Java สมัยใหม่ด้วย stream, concurrency และการปรับแต่ง JVM
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - เขียนโค้ด Elixir อย่างเหมาะสมด้วยรูปแบบ OTP, การเขียนโปรแกรมเชิงฟังก์ชัน และเฟรมเวิร์ก Phoenix
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - เขียนโค้ด C# สมัยใหม่ด้วยฟีเจอร์ขั้นสูงและการปรับแต่ง .NET
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - เชี่ยวชาญการพัฒนา Scala ระดับองค์กรด้วยการเขียนโปรแกรมเชิงฟังก์ชัน, ระบบกระจาย และการประมวลผลข้อมูลขนาดใหญ่
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - เชี่ยวชาญการพัฒนา Flutter ด้วย Dart, widget และการผสานงานกับแพลตฟอร์ม
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - สร้างเกม Unity ด้วยสคริปต์ที่ปรับแต่งและการปรับปรุงประสิทธิภาพ
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - เชี่ยวชาญการพัฒนา Minecraft server plugin ด้วย Bukkit, Spigot และ Paper API
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - พัฒนาแอปพลิเคชัน iOS แบบ native ด้วย Swift/SwiftUI
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - เขียนคำสั่ง SQL ที่ซับซ้อน, ปรับแต่ง execution plan และออกแบบ schema ที่ normalized

### โครงสร้างพื้นฐานและการดำเนินงาน
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - แก้ไขปัญหาใน production, วิเคราะห์ log และแก้ไขการ deploy ที่ล้มเหลว
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - กำหนดค่า CI/CD pipeline, คอนเทนเนอร์ Docker และการ deploy บนคลาวด์
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - ออกแบบโครงสร้าง AWS/Azure/GCP และปรับแต่งค่าใช้จ่ายคลาวด์
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - ปรับแต่งคำสั่ง SQL, ออกแบบ index ประสิทธิภาพสูง และจัดการ migration ฐานข้อมูล
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - จัดการงานฐานข้อมูล, การสำรองข้อมูล, การ replication และการมอนิเตอร์
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - เขียนโมดูล Terraform ขั้นสูง, จัดการ state file และใช้งานแนวทาง IaC ที่ดีที่สุด
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - รับมือกับเหตุการณ์ใน production อย่างรวดเร็วและแม่นยำ
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - แก้ไขปัญหาเครือข่าย, กำหนดค่า load balancer และวิเคราะห์รูปแบบการจราจร
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - ผู้เชี่ยวชาญด้านประสบการณ์นักพัฒนาที่ปรับปรุงเครื่องมือ, การตั้งค่า และเวิร์กโฟลว์

### คุณภาพ & ความปลอดภัย
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - ผู้เชี่ยวชาญด้านการรีวิวโค้ดโดยเน้นความปลอดภัยในการกำหนดค่าและความเสถียรระดับโปรดักชัน
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - ตรวจสอบโค้ดหาช่องโหว่และรับรองการปฏิบัติตามมาตรฐาน OWASP
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - สร้างชุดทดสอบที่ครอบคลุมทั้ง unit, integration และ e2e
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - วิเคราะห์ประสิทธิภาพ ปรับปรุงจุดคอขวด และวางแผนกลยุทธ์แคช
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - ผู้เชี่ยวชาญด้านการดีบักข้อผิดพลาด, การทดสอบล้มเหลว และพฤติกรรมที่ไม่คาดคิด
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - ค้นหา log และ codebase เพื่อหาลักษณะข้อผิดพลาด, stack trace และความผิดปกติ
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - ผู้เชี่ยวชาญการค้นคว้าเว็บด้วยเทคนิคการค้นหาขั้นสูงและการสังเคราะห์ข้อมูล

### ข้อมูล & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - ผู้เชี่ยวชาญการวิเคราะห์ข้อมูลสำหรับ SQL, BigQuery และข้อมูลเชิงลึก
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - สร้าง ETL pipeline, data warehouse และสถาปัตยกรรม streaming
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - สร้างแอป LLM, ระบบ RAG และ prompt pipeline
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - สร้าง ML pipeline, การให้บริการโมเดล และวิศวกรรมฟีเจอร์
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - สร้าง ML pipeline, ติดตามการทดลอง และจัดการ registry โมเดล
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - ปรับแต่ง prompt สำหรับ LLM และระบบ AI

### โดเมนเฉพาะทาง
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - สร้างสเปค OpenAPI/Swagger และเขียนเอกสารสำหรับนักพัฒนา
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - เชื่อมต่อ Stripe, PayPal และตัวประมวลผลการชำระเงิน
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - สร้างโมเดลการเงิน, ทดสอบกลยุทธ์เทรดย้อนหลัง และวิเคราะห์ข้อมูลตลาด
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - ตรวจสอบความเสี่ยงพอร์ต, R-multiple และขีดจำกัดสถานะ
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - รีแฟกเตอร์โค้ดเก่าและดำเนินการปรับปรุงอย่างค่อยเป็นค่อยไป
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - จัดการบริบทข้ามหลาย agent และงานที่ใช้เวลานาน

### เอกสารประกอบ
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - สร้างเอกสารเทคนิคอย่างครบถ้วนจาก codebase ที่มีอยู่
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - สร้างไดอะแกรม Mermaid สำหรับ flowchart, sequence, ERD และสถาปัตยกรรม
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - สร้างเอกสารอ้างอิงทางเทคนิคและ API ที่ครบถ้วน
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - สร้างบทเรียนทีละขั้นตอนและเนื้อหาการสอนจากโค้ด

### ธุรกิจ & การตลาด
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - วิเคราะห์ตัวชี้วัด, สร้างรายงาน และติดตาม KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - เขียนบล็อก, เนื้อหาโซเชียลมีเดีย และจดหมายข่าว
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - ร่างอีเมลหาลูกค้า, ติดตามผล และเทมเพลตข้อเสนอ
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - จัดการตั๋วซัพพอร์ต, คำถามที่พบบ่อย และอีเมลลูกค้า
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - ร่างนโยบายความเป็นส่วนตัว, เงื่อนไขการให้บริการ, ข้อสงวนสิทธิ์ และประกาศทางกฎหมาย

## การมอบหมายโมเดล

ตัวแทนย่อยทั้ง 59 ตัวถูกกำหนดค่าโดยใช้โมเดล Claude ที่เหมาะสมตามความซับซ้อนของงาน:

### 🚀 Haiku (รวดเร็ว & ประหยัดค่าใช้จ่าย) - 9 ตัวแทน
**โมเดล:** `haiku`
- `data-scientist` - คำสั่ง SQL และการวิเคราะห์ข้อมูล
- `api-documenter` - เอกสาร OpenAPI/Swagger
- `reference-builder` - การอ้างอิงทางเทคนิคและเอกสาร API แบบละเอียด
- `business-analyst` - การติดตามตัวชี้วัดและ KPI
- `content-marketer` - บทความบล็อกและโซเชียลมีเดีย
- `customer-support` - ตั๋วสนับสนุนและคำถามที่พบบ่อย
- `sales-automator` - อีเมลขายและข้อเสนอ
- `search-specialist` - การค้นคว้าเว็บและรวบรวมข้อมูล
- `legal-advisor` - นโยบายความเป็นส่วนตัวและเอกสารการปฏิบัติตามกฎหมาย

### ⚡ Sonnet (สมดุลด้านประสิทธิภาพ) - 37 ตัวแทน
**โมเดล:** `sonnet`

**การพัฒนา & ภาษาโปรแกรม:**
- `python-pro` - พัฒนา Python ด้วยฟีเจอร์ขั้นสูง
- `ruby-pro` - พัฒนา Ruby ด้วย metaprogramming, รูปแบบ Rails และการสร้าง gem
- `javascript-pro` - JavaScript สมัยใหม่และ Node.js
- `typescript-pro` - TypeScript ขั้นสูงด้วยระบบ type
- `golang-pro` - Go concurrency และรูปแบบ idiomatic
- `rust-pro` - ความปลอดภัยหน่วยความจำของ Rust และระบบโปรแกรมมิ่ง
- `c-pro` - การเขียนโปรแกรม C และระบบฝังตัว
- `cpp-pro` - C++ สมัยใหม่ด้วย STL และ template
- `php-pro` - PHP สมัยใหม่พร้อมฟีเจอร์ขั้นสูง
- `java-pro` - Java สมัยใหม่ด้วย streams และ concurrency
- `elixir-pro` - Elixir พร้อมรูปแบบ OTP และ Phoenix
- `csharp-pro` - C# สมัยใหม่ด้วย .NET frameworks และรูปแบบ
- `scala-pro` - Scala ระดับองค์กรด้วย Apache Pekko, Akka, Spark และ ZIO/Cats Effect
- `flutter-expert` - พัฒนา Flutter ด้วยการจัดการ state และอนิเมชัน
- `unity-developer` - พัฒนาเกม Unity และการปรับแต่งประสิทธิภาพ
- `minecraft-bukkit-pro` - พัฒนา Minecraft plugin ด้วย Bukkit/Spigot/Paper
- `ios-developer` - พัฒนา iOS แบบ native ด้วย Swift/SwiftUI
- `frontend-developer` - คอมโพเนนต์ React และ UI
- `ui-ux-designer` - การออกแบบอินเทอร์เฟซและ wireframe
- `backend-architect` - การออกแบบ API และ microservices
- `mobile-developer` - แอป React Native/Flutter
- `sql-pro` - การปรับแต่ง SQL ที่ซับซ้อน
- `graphql-architect` - สคีมา GraphQL และตัวแก้ไขรีซอลเวอร์

**โครงสร้างพื้นฐาน & การดำเนินงาน:**
- `devops-troubleshooter` - การดีบักในสภาพแวดล้อมโปรดักชัน
- `deployment-engineer` - การตั้งค่า CI/CD pipeline
- `database-optimizer` - การเพิ่มประสิทธิภาพคิวรี
- `database-admin` - การดำเนินงานฐานข้อมูล
- `terraform-specialist` - โค้ดโครงสร้างพื้นฐาน (Infrastructure as Code)
- `network-engineer` - การกำหนดค่าเครือข่าย
- `dx-optimizer` - ประสบการณ์นักพัฒนา
- `data-engineer` - การจัดการ ETL pipeline

**คุณภาพ & การสนับสนุน:**
- `test-automator` - การสร้างชุดทดสอบ
- `code-reviewer` - การวิเคราะห์คุณภาพโค้ด
- `debugger` - การสืบสวนข้อผิดพลาด
- `error-detective` - การวิเคราะห์ log
- `ml-engineer` - การปรับใช้โมเดล ML
- `legacy-modernizer` - การย้ายเฟรมเวิร์ก
- `payment-integration` - การประมวลผลการชำระเงิน
- `mermaid-expert` - แผนภาพ Mermaid และเอกสารภาพ
- `flutter-expert` - การพัฒนา Flutter

### 🧠 Opus (ศักยภาพสูงสุด) - 13 เอเจนต์
**โมเดล:** `opus`
- `ai-engineer` - แอปพลิเคชัน LLM และระบบ RAG
- `security-auditor` - การวิเคราะห์ช่องโหว่
- `performance-engineer` - การเพิ่มประสิทธิภาพแอปพลิเคชัน
- `incident-responder` - การจัดการเหตุการณ์ในโปรดักชัน
- `mlops-engineer` - โครงสร้างพื้นฐาน ML
- `architect-reviewer` - ความสอดคล้องด้านสถาปัตยกรรม
- `cloud-architect` - การออกแบบโครงสร้างพื้นฐานคลาวด์
- `prompt-engineer` - การเพิ่มประสิทธิภาพ prompt LLM
- `context-manager` - การประสานงานหลายเอเจนต์
- `quant-analyst` - การสร้างแบบจำลองทางการเงิน
- `risk-manager` - การจัดการความเสี่ยงพอร์ตโฟลิโอ
- `docs-architect` - เอกสารเทคนิคเชิงลึกจากโค้ดเบส
- `tutorial-engineer` - คู่มือแบบทีละขั้นตอนและเนื้อหาการศึกษา

## การติดตั้ง
ซับเอเจนต์เหล่านี้จะพร้อมใช้งานโดยอัตโนมัติเมื่อถูกวางไว้ในไดเรกทอรี `~/.claude/agents/`


```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## การใช้งาน

### การเรียกใช้อัตโนมัติ
Claude Code จะมอบหมายงานไปยังซับเอเจนต์ที่เหมาะสมโดยอัตโนมัติตามบริบทของงานและคำอธิบายของซับเอเจนต์นั้น

### การเรียกใช้อย่างชัดเจน
ระบุชื่อซับเอเจนต์ในคำขอของคุณ:
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## ตัวอย่างการใช้งาน

### งานของเอเจนต์เดี่ยว
```bash
# Code quality and review
"Use code-reviewer to analyze this component for best practices"
"Have code-reviewer scrutinize these configuration changes"
"Have security-auditor check for OWASP compliance issues"

# Development tasks  
"Get backend-architect to design a user authentication API"
"Use frontend-developer to create a responsive dashboard layout"

# Infrastructure and operations
"Have devops-troubleshooter analyze these production logs"
"Use cloud-architect to design a scalable AWS architecture"
"Get network-engineer to debug SSL certificate issues"
"Use database-admin to set up backup and replication"

# Data and AI
"Get data-scientist to analyze this customer behavior dataset"
"Use ai-engineer to build a RAG system for document search"
"Have mlops-engineer set up MLflow experiment tracking"

# Business and marketing
"Have business-analyst create investor deck with growth metrics"
"Use content-marketer to write SEO-optimized blog post"
"Get sales-automator to create cold email sequence"
"Have customer-support draft FAQ documentation"
```

### เวิร์กโฟลว์แบบหลายเอเจนต์

ซับเอเจนต์เหล่านี้ทำงานร่วมกันอย่างไร้รอยต่อ และสำหรับการจัดการที่ซับซ้อนยิ่งขึ้น คุณสามารถใช้ชุดคำสั่ง **[Claude Code Commands](https://github.com/wshobson/commands)** ซึ่งมีคำสั่ง slash ที่สร้างไว้ล่วงหน้า 52 รายการ เพื่อใช้ซับเอเจนต์เหล่านี้ในเวิร์กโฟลว์ที่ซับซ้อน

```bash
# Feature development workflow
"Implement user authentication feature"
# Automatically uses: backend-architect → frontend-developer → test-automator → security-auditor

# Performance optimization workflow  
"Optimize the checkout process performance"
# Automatically uses: performance-engineer → database-optimizer → frontend-developer

# Production incident workflow
"Debug high memory usage in production"
# Automatically uses: incident-responder → devops-troubleshooter → error-detective → performance-engineer

# Network connectivity workflow
"Fix intermittent API timeouts"
# Automatically uses: network-engineer → devops-troubleshooter → performance-engineer

# Database maintenance workflow
"Set up disaster recovery for production database"
# Automatically uses: database-admin → database-optimizer → incident-responder

# ML pipeline workflow
"Build end-to-end ML pipeline with monitoring"
# Automatically uses: mlops-engineer → ml-engineer → data-engineer → performance-engineer

# Product launch workflow
"Launch new feature with marketing campaign"
# Automatically uses: business-analyst → content-marketer → sales-automator → customer-support
```

### เวิร์กโฟลว์ขั้นสูงด้วยคำสั่ง Slash

สำหรับการจัดการซับเอเจนต์หลายตัวอย่างมีประสิทธิภาพมากขึ้น ให้ใช้ [คลังคำสั่ง (Commands repository)](https://github.com/wshobson/commands) ที่เป็นคู่มือ:

```bash
# Complex feature development (8+ subagents)
/full-stack-feature Build user dashboard with real-time analytics

# Production incident response (5+ subagents) 
/incident-response Database connection pool exhausted

# ML infrastructure setup (6+ subagents)
/ml-pipeline Create recommendation engine with A/B testing

# Security-focused implementation (7+ subagents)
/security-hardening Implement OAuth2 with zero-trust architecture
```

## รูปแบบซับเอเจนต์

แต่ละซับเอเจนต์จะมีโครงสร้างดังนี้:
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```

### การกำหนดค่าของโมเดล

ณ Claude Code v1.0.64, ซับเอเจนต์สามารถระบุได้ว่าควรใช้โมเดล Claude รุ่นใด ซึ่งช่วยให้สามารถมอบหมายงานตามความซับซ้อนอย่างประหยัดต้นทุน:

- **ความซับซ้อนต่ำ (Haiku)**: งานง่าย ๆ เช่น การวิเคราะห์ข้อมูลพื้นฐาน การสร้างเอกสาร และการตอบกลับมาตรฐาน
- **ความซับซ้อนปานกลาง (Sonnet)**: งานพัฒนา การรีวิวโค้ด การทดสอบ และงานวิศวกรรมมาตรฐาน  
- **ความซับซ้อนสูง (Opus)**: งานสำคัญ เช่น การตรวจสอบความปลอดภัย การรีวิวสถาปัตยกรรม การตอบสนองเหตุการณ์ และวิศวกรรม AI/ML

โมเดลที่มีให้เลือก (ใช้ชื่อแบบย่อ ณ Claude Code v1.0.64):
- `haiku` - รวดเร็วและประหยัดสำหรับงานง่าย ๆ
- `sonnet` - สมดุลทั้งประสิทธิภาพสำหรับงานพัฒนาส่วนใหญ่
- `opus` - มีความสามารถสูงสุดสำหรับการวิเคราะห์ที่ซับซ้อนและงานสำคัญ

หากไม่ได้ระบุโมเดล ซับเอเจนต์จะใช้โมเดลเริ่มต้นของระบบ

## รูปแบบการประสานงานของเอเจนต์

Claude Code จะประสานงานเอเจนต์โดยอัตโนมัติด้วยรูปแบบทั่วไปเหล่านี้:

### ลำดับเวิร์กโฟลว์
```
User Request → Agent A → Agent B → Agent C → Result

Example: "Build a new API feature"
backend-architect → frontend-developer → test-automator → security-auditor
```

### Parallel Execution
```
User Request → Agent A + Agent B (simultaneously) → Merge Results

Example: "Optimize application performance" 
performance-engineer + database-optimizer → Combined recommendations
```

### การแยกแขนงตามเงื่อนไข
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### การทบทวนและการตรวจสอบ
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```

## เมื่อไรควรใช้เอเจนต์ตัวไหน

### 🏗️ การวางแผน & สถาปัตยกรรม
- **backend-architect**: การออกแบบ API, สคีมาฐานข้อมูล, สถาปัตยกรรมระบบ
- **frontend-developer**: การวางแผน UI/UX, สถาปัตยกรรมคอมโพเนนต์
- **ui-ux-designer**: การออกแบบอินเทอร์เฟซ, ไวร์เฟรม, ระบบการออกแบบ, การวิจัยผู้ใช้
- **cloud-architect**: การออกแบบโครงสร้างพื้นฐาน, การวางแผนรองรับการขยายตัว

### 🔧 การพัฒนา & การลงมือทำ  
- **python-pro**: งานพัฒนาเฉพาะทาง Python
- **ruby-pro**: เมตาโปรแกรมมิ่ง Ruby, แอปพลิเคชัน Rails, การพัฒนา gem, การทดสอบ RSpec/Minitest
- **golang-pro**: งานพัฒนาเฉพาะทาง Go
- **rust-pro**: งานพัฒนาเฉพาะทาง Rust, ความปลอดภัยของหน่วยความจำ, การเขียนโปรแกรมระบบ
- **c-pro**: การเขียนโปรแกรม C, ระบบฝังตัว, โค้ดที่เน้นประสิทธิภาพสูง
- **javascript-pro**: JavaScript สมัยใหม่, รูปแบบ async, โค้ด Node.js/เบราว์เซอร์
- **typescript-pro**: TypeScript ขั้นสูง, เจเนอริก, การอนุมานประเภท, รูปแบบองค์กร
- **java-pro**: การพัฒนา Java สมัยใหม่, สตรีม, การประมวลผลพร้อมกัน, Spring Boot
- **elixir-pro**: การพัฒนา Elixir, รูปแบบ OTP, เฟรมเวิร์ก Phoenix, การเขียนโปรแกรมเชิงฟังก์ชัน
- **csharp-pro**: การพัฒนา C# สมัยใหม่, เฟรมเวิร์ก .NET, รูปแบบองค์กร
- **scala-pro**: Scala สำหรับองค์กรกับ functional programming, Apache Pekko/Akka actors, Apache Spark, ZIO/Cats Effect, สถาปัตยกรรม reactive
- **flutter-expert**: การพัฒนา Flutter, Dart, การจัดการสถานะ, แอนิเมชัน, การ deploy ข้ามแพลตฟอร์ม
- **unity-developer**: การพัฒนาเกม Unity, การเขียนสคริปต์ C#, การปรับประสิทธิภาพ
- **minecraft-bukkit-pro**: การพัฒนา plugin Minecraft, ระบบ event, ฟีเจอร์ฝั่งเซิร์ฟเวอร์
- **ios-developer**: การพัฒนา iOS แบบ native ด้วย Swift/SwiftUI
- **sql-pro**: คำสั่งฐานข้อมูล, การออกแบบสคีมา, การปรับ query ให้มีประสิทธิภาพ
- **mobile-developer**: การพัฒนา React Native/Flutter

### 🛠️ ปฏิบัติการ & การบำรุงรักษา
- **devops-troubleshooter**: ปัญหาในการผลิต, ปัญหาการ deploy
- **incident-responder**: เหตุขัดข้องสำคัญที่ต้องการการตอบสนองทันที
- **database-optimizer**: ประสิทธิภาพ query, กลยุทธ์การทำดัชนี
- **database-admin**: กลยุทธ์สำรองข้อมูล, การ replication, การจัดการผู้ใช้, การกู้คืนจากภัยพิบัติ
- **terraform-specialist**: Infrastructure as Code, โมดูล Terraform, การจัดการสถานะ
- **network-engineer**: การเชื่อมต่อเครือข่าย, load balancer, SSL/TLS, การดีบัก DNS

### 📊 การวิเคราะห์ & การเพิ่มประสิทธิภาพ
- **performance-engineer**: การวิเคราะห์จุดคอขวดของแอปพลิเคชัน, การเพิ่มประสิทธิภาพ
- **security-auditor**: การสแกนช่องโหว่, การตรวจสอบความสอดคล้อง
- **data-scientist**: การวิเคราะห์ข้อมูล, การค้นหา insight, การจัดทำรายงาน
- **mlops-engineer**: โครงสร้างพื้นฐาน ML, การติดตามการทดลอง, การลงทะเบียนโมเดล, ระบบอัตโนมัติของ pipeline

### 🧪 การประกันคุณภาพ
- **code-reviewer**: คุณภาพของโค้ด, ความปลอดภัยของการตั้งค่า, ความน่าเชื่อถือในระบบ production
- **test-automator**: กลยุทธ์การทดสอบ, การสร้างชุดทดสอบ
- **debugger**: การสืบสวนข้อบกพร่อง, การแก้ไขข้อผิดพลาด
- **error-detective**: การวิเคราะห์ log, การรู้จักรูปแบบข้อผิดพลาด, การวิเคราะห์สาเหตุหลัก
- **search-specialist**: การวิจัยเว็บเชิงลึก, การวิเคราะห์คู่แข่ง, การตรวจสอบข้อเท็จจริง

### 📚 เอกสารประกอบ
- **api-documenter**: สเปค OpenAPI/Swagger, เอกสารประกอบ API
- **docs-architect**: เอกสารเทคนิคอย่างครอบคลุม, คู่มือสถาปัตยกรรม, คู่มือระบบ
- **reference-builder**: เอกสารอ้างอิง API ที่ละเอียด, คู่มือการตั้งค่า, เอกสารพารามิเตอร์
- **tutorial-engineer**: บทแนะนำทีละขั้นตอน, เส้นทางการเรียนรู้, เนื้อหาเพื่อการศึกษา

### 💼 ธุรกิจ & กลยุทธ์
- **business-analyst**: ตัวชี้วัด KPI, รูปแบบรายได้, การคาดการณ์การเติบโต, ตัวชี้วัดนักลงทุน
- **risk-manager**: ความเสี่ยงของพอร์ต, กลยุทธ์ป้องกันความเสี่ยง, R-multiples, ขนาดสถานะ
- **content-marketer**: เนื้อหา SEO, โพสต์บล็อก, โซเชียลมีเดีย, แคมเปญอีเมล
- **sales-automator**: อีเมลหาลูกค้าใหม่, การติดตามผล, ข้อเสนอ, การดูแลลีด
- **customer-support**: ตั๋วสนับสนุน, FAQ, เอกสารช่วยเหลือ, การแก้ไขปัญหา
- **legal-advisor** - ร่างนโยบายความเป็นส่วนตัว, ข้อกำหนดการใช้บริการ, ข้อจำกัดความรับผิด, และประกาศทางกฎหมาย

## แนวทางปฏิบัติที่ดีที่สุด

### 🎯 การมอบหมายงาน
1. **ให้ Claude Code มอบหมายงานโดยอัตโนมัติ** - ตัวแทนหลักวิเคราะห์บริบทและเลือกตัวแทนที่เหมาะสมที่สุด
2. **ระบุข้อกำหนดอย่างชัดเจน** - รวมข้อจำกัด, เทคโนโลยีที่ใช้, และข้อกำหนดคุณภาพ
3. **เชื่อมั่นในความเชี่ยวชาญของตัวแทน** - ตัวแทนแต่ละรายได้รับการปรับให้เหมาะกับโดเมนของตน

### 🔄 เวิร์กโฟลว์แบบหลายตัวแทน
4. **เริ่มต้นด้วยคำขอระดับสูง** - ให้ตัวแทนประสานงานงานหลายขั้นตอนที่ซับซ้อน
5. **ให้ข้อมูลพื้นฐานระหว่างตัวแทน** - ตรวจสอบให้แน่ใจว่าตัวแทนมีข้อมูลพื้นฐานที่จำเป็น
6. **ตรวจสอบจุดเชื่อมต่อการรวมระบบ** - ตรวจสอบวิธีการทำงานร่วมกันของผลลัพธ์จากตัวแทนแต่ละราย

### 🎛️ การควบคุมโดยตรง
7. **ใช้การเรียกใช้งานโดยตรงตามความต้องการเฉพาะ** - เมื่อคุณต้องการมุมมองจากผู้เชี่ยวชาญเฉพาะทาง
8. **ผสมผสานตัวแทนหลายตัวอย่างมีกลยุทธ์** - ผู้เชี่ยวชาญแต่ละรายสามารถตรวจสอบผลงานกันและกัน
9. **ร้องขอรูปแบบการตรวจสอบเฉพาะ** - "ให้ security-auditor ตรวจสอบการออกแบบ API ของ backend-architect"

### 📈 การเพิ่มประสิทธิภาพ
10. **ติดตามประสิทธิผลของเอเจนต์** - เรียนรู้ว่าเอเจนต์ใดเหมาะสมที่สุดกับกรณีการใช้งานของคุณ
11. **ปรับปรุงงานที่ซับซ้อนอย่างต่อเนื่อง** - ใช้ข้อเสนอแนะจากเอเจนต์เพื่อปรับแต่งข้อกำหนด
12. **ใช้จุดแข็งของเอเจนต์** - จับคู่ความซับซ้อนของงานกับความสามารถของเอเจนต์

## การมีส่วนร่วม

เพื่อเพิ่มซับเอเจนต์ใหม่:
1. สร้างไฟล์ `.md` ใหม่ตามรูปแบบข้างต้น
2. ใช้ชื่อที่เป็นตัวพิมพ์เล็กและคั่นด้วยขีดกลาง
3. เขียนคำอธิบายให้ชัดเจนว่าควรใช้ซับเอเจนต์เมื่อใด
4. รวมคำแนะนำเฉพาะไว้ใน system prompt

## การแก้ไขปัญหา

### ปัญหาทั่วไป

**เอเจนต์ไม่ถูกเรียกใช้งานโดยอัตโนมัติ:**
- ตรวจสอบว่าคำขอของคุณระบุโดเมนอย่างชัดเจน (เช่น "ปัญหาด้านประสิทธิภาพ" → performance-engineer)
- ระบุประเภทของงานอย่างชัดเจน (เช่น "ตรวจสอบโค้ด" → code-reviewer)

**การเลือกเอเจนต์ที่ไม่คาดคิด:**
- ให้รายละเอียดเพิ่มเติมเกี่ยวกับเทคโนโลยีและข้อกำหนดของคุณ
- ใช้การเรียกใช้งานแบบเจาะจงหากคุณต้องการเอเจนต์เฉพาะ

**เอเจนต์หลายตัวให้คำแนะนำขัดแย้งกัน:**
- สิ่งนี้เป็นเรื่องปกติ - ผู้เชี่ยวชาญต่างสายอาจมีลำดับความสำคัญแตกต่างกัน
- ขอคำชี้แจง: "ช่วยประสานข้อแนะนำจาก security-auditor และ performance-engineer"

**เอเจนต์ดูเหมือนไม่มีบริบท:**
- ให้ข้อมูลพื้นหลังในคำขอของคุณ
- อ้างอิงบทสนทนาหรือรูปแบบที่มีการกำหนดไว้ก่อนหน้า

### การขอความช่วยเหลือ

หากเอเจนต์ไม่ทำงานตามที่คาดหวัง:
1. ตรวจสอบคำอธิบายของเอเจนต์ในแต่ละไฟล์
2. ลองใช้ภาษาที่เฉพาะเจาะจงมากขึ้นในคำขอของคุณ
3. ใช้การเรียกใช้งานแบบเจาะจงเพื่อทดสอบเอเจนต์แต่ละตัว
4. ให้ข้อมูลเพิ่มเติมเกี่ยวกับโปรเจกต์และเป้าหมายของคุณ

## ใบอนุญาต

โปรเจกต์นี้ได้รับอนุญาตภายใต้ใบอนุญาต MIT - ดูไฟล์ [LICENSE](LICENSE) สำหรับรายละเอียด

## เรียนรู้เพิ่มเติม

- [เอกสารประกอบ Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [เอกสารประกอบ Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---