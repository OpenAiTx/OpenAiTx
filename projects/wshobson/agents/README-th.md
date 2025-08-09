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

ชุดรวมที่ครอบคลุมของซับเอเจนต์ AI เฉพาะทางสำหรับ [Claude Code](https://docs.anthropic.com/en/docs/claude-code) ที่ออกแบบมาเพื่อเสริมประสิทธิภาพการพัฒนาด้วยความเชี่ยวชาญในแต่ละสาขา

## ภาพรวม

คลังนี้ประกอบด้วยซับเอเจนต์เฉพาะทาง 58 ตัว ที่ขยายขีดความสามารถของ Claude Code โดยแต่ละซับเอเจนต์เป็นผู้เชี่ยวชาญในโดเมนเฉพาะ สามารถเรียกใช้งานโดยอัตโนมัติตามบริบทหรือเรียกใช้งานโดยตรงเมื่อจำเป็น ทุกเอเจนต์ถูกตั้งค่าด้วยโมเดล Claude ที่เหมาะสมตามความซับซ้อนของงาน เพื่อประสิทธิภาพและความคุ้มค่า

## ซับเอเจนต์ที่มีให้ใช้งาน

### การพัฒนา & สถาปัตยกรรม
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - ออกแบบ RESTful APIs, ขอบเขต microservice และโครงร่างฐานข้อมูล
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - สร้างคอมโพเนนต์ React, พัฒนารูปแบบตอบสนอง และจัดการ state ฝั่ง client
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - สร้างการออกแบบอินเทอร์เฟซ, wireframe และระบบดีไซน์
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - พัฒนาแอป React Native หรือ Flutter พร้อมการเชื่อมต่อ native
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - ออกแบบ GraphQL schema, resolver และ federation
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - ตรวจสอบการเปลี่ยนแปลงโค้ดเพื่อความสอดคล้องและรูปแบบทางสถาปัตยกรรม

### ผู้เชี่ยวชาญภาษา
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - เขียนโค้ด Python ตามหลัก idiomatic พร้อมฟีเจอร์ขั้นสูงและการปรับแต่ง
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - เขียนโค้ด Go ตามหลัก idiomatic ด้วย goroutine, channel และ interface
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - เขียน Rust ตามหลัก idiomatic ด้วยรูปแบบ ownership, lifetime และ trait implementation
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - เขียนโค้ด C ประสิทธิภาพสูงด้วยการจัดการหน่วยความจำและ system call ที่ถูกต้อง
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - เขียนโค้ด C++ ตามหลัก idiomatic ด้วยฟีเจอร์สมัยใหม่, RAII, smart pointer และอัลกอริทึม STL
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - เชี่ยวชาญ JavaScript สมัยใหม่ด้วย ES6+, รูปแบบ async และ Node.js API
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - เชี่ยวชาญ TypeScript ด้วยชนิดข้อมูลขั้นสูง, generic และความปลอดภัยของชนิดข้อมูล
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - เขียนโค้ด PHP ตามหลัก idiomatic พร้อมฟีเจอร์สมัยใหม่และการปรับแต่งประสิทธิภาพ
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - เชี่ยวชาญ Java สมัยใหม่ด้วย stream, concurrency และการปรับแต่ง JVM
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - เขียนโค้ด Elixir ตามหลัก idiomatic ด้วยรูปแบบ OTP, functional programming และเฟรมเวิร์ก Phoenix
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - เขียนโค้ด C# สมัยใหม่ด้วยฟีเจอร์ขั้นสูงและการปรับแต่ง .NET
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - เชี่ยวชาญการพัฒนา Scala สำหรับองค์กรด้วย functional programming, ระบบกระจาย และการประมวลผล big data
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - สร้างเกม Unity ด้วยสคริปต์ที่ปรับแต่งและการปรับประสิทธิภาพ
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - เชี่ยวชาญการพัฒนา plugin เซิร์ฟเวอร์ Minecraft ด้วย Bukkit, Spigot และ Paper API
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - พัฒนาแอปพลิเคชัน iOS แบบ native ด้วย Swift/SwiftUI
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - เขียน query SQL ที่ซับซ้อน, ปรับแต่งแผนการประมวลผล และออกแบบ schema แบบ normalized

### โครงสร้างพื้นฐาน & ปฏิบัติการ
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - แก้ไขปัญหาใน production, วิเคราะห์ log และแก้ไขความล้มเหลวในการ deploy
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - ตั้งค่า pipeline CI/CD, คอนเทนเนอร์ Docker และการ deploy บนคลาวด์
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - ออกแบบโครงสร้าง AWS/Azure/GCP และปรับแต่งค่าใช้จ่ายคลาวด์
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - ปรับแต่ง query SQL, ออกแบบ index ที่มีประสิทธิภาพ และจัดการ migration ฐานข้อมูล
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - จัดการการดำเนินงานฐานข้อมูล, สำรองข้อมูล, replication และ monitoring
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - เขียน module Terraform ขั้นสูง, จัดการ state file และปฏิบัติตามหลักการ IaC ที่ดีที่สุด
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - รับมือเหตุการณ์ใน production ด้วยความเร่งด่วนและแม่นยำ
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - แก้ไขปัญหาเครือข่าย, ตั้งค่า load balancer และวิเคราะห์รูปแบบการรับส่งข้อมูล
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - ผู้เชี่ยวชาญด้าน Developer Experience ที่ปรับปรุงเครื่องมือ, การตั้งค่า และ workflow

### คุณภาพ & ความปลอดภัย
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - ผู้เชี่ยวชาญตรวจสอบโค้ดที่เน้นความปลอดภัยในการตั้งค่าและความน่าเชื่อถือใน production
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - ตรวจสอบโค้ดเพื่อหาช่องโหว่และรับรองความสอดคล้องกับ OWASP
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - สร้างชุดทดสอบที่ครอบคลุมด้วย unit, integration และ e2e tests
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - วิเคราะห์ประสิทธิภาพของแอปพลิเคชัน ปรับปรุงจุดคอขวด และใช้กลยุทธ์แคช
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - ผู้เชี่ยวชาญด้านการดีบักสำหรับข้อผิดพลาด การทดสอบล้มเหลว และพฤติกรรมที่ไม่คาดคิด
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - ค้นหาล็อกและฐานโค้ดเพื่อหารูปแบบข้อผิดพลาด stack traces และความผิดปกติ
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - ผู้เชี่ยวชาญด้านการค้นหาข้อมูลบนเว็บโดยใช้เทคนิคขั้นสูงและการสังเคราะห์

### Data & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - ผู้เชี่ยวชาญด้านการวิเคราะห์ข้อมูลสำหรับ SQL, BigQuery และข้อมูลเชิงลึก
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - สร้าง ETL pipeline, data warehouse และสถาปัตยกรรมสตรีมมิ่ง
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - สร้างแอปพลิเคชัน LLM, ระบบ RAG และ prompt pipeline
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - สร้าง ML pipeline, บริการโมเดล และวิศวกรรมฟีเจอร์
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - สร้าง ML pipeline, ติดตามการทดลอง และ registry โมเดล
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - ปรับแต่ง prompt สำหรับ LLMs และระบบ AI

### Specialized Domains
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - สร้าง OpenAPI/Swagger spec และเขียนคู่มือสำหรับนักพัฒนา
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - เชื่อมต่อ Stripe, PayPal และผู้ให้บริการชำระเงิน
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - สร้างแบบจำลองทางการเงิน ทดสอบกลยุทธ์การเทรด และวิเคราะห์ข้อมูลตลาด
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - ตรวจสอบความเสี่ยงของพอร์ต R-multiples และขีดจำกัดสถานะ
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - refactor ฐานโค้ดเก่าและปรับปรุงอย่างค่อยเป็นค่อยไป
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - จัดการ context ระหว่างเอเจนต์หลายตัวและงานที่ใช้เวลานาน

### Documentation
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - สร้างเอกสารทางเทคนิคที่ครอบคลุมจากฐานโค้ดที่มีอยู่
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - สร้างแผนภาพ Mermaid สำหรับ flowchart, sequence, ERD และ architecture
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - สร้างคู่มืออ้างอิงทางเทคนิคและเอกสาร API ที่ละเอียด
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - สร้างบทแนะนำทีละขั้นตอนและเนื้อหาเพื่อการศึกษาโดยอ้างอิงจากโค้ด

### Business & Marketing
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - วิเคราะห์เมตริก สร้างรายงาน และติดตาม KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - เขียนบทความบล็อก เนื้อหาสื่อสังคม และจดหมายข่าวอีเมล
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - ร่างอีเมลแนะนำตัว อีเมลติดตามผล และเทมเพลตข้อเสนอ
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - จัดการทิกเก็ตซัพพอร์ต คำตอบ FAQ และอีเมลลูกค้า
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - ร่างนโยบายความเป็นส่วนตัว ข้อกำหนดการให้บริการ ข้อจำกัดความรับผิด และประกาศทางกฎหมาย

## การกำหนดโมเดล

Subagent ทั้ง 58 ตัวถูกตั้งค่าด้วยโมเดล Claude ที่เฉพาะเจาะจงตามความซับซ้อนของงาน:

### 🚀 Haiku (รวดเร็วและคุ้มค่า) - 9 ตัวช่วย
**โมเดล:** `haiku`
- `data-scientist` - สร้างคำสั่ง SQL และวิเคราะห์ข้อมูล
- `api-documenter` - เอกสาร OpenAPI/Swagger
- `reference-builder` - สร้างข้อมูลอ้างอิงทางเทคนิคและเอกสาร API อย่างละเอียด
- `business-analyst` - ติดตามตัวชี้วัดและ KPI
- `content-marketer` - บทความบล็อกและโซเชียลมีเดีย
- `customer-support` - ข้อร้องเรียนและคำถามที่พบบ่อย
- `sales-automator` - อีเมลขายและข้อเสนอ
- `search-specialist` - ค้นคว้าเว็บและรวบรวมข้อมูล
- `legal-advisor` - นโยบายความเป็นส่วนตัวและเอกสารการปฏิบัติตามข้อกำหนด

### ⚡ Sonnet (สมดุลประสิทธิภาพ) - 36 ตัวช่วย
**โมเดล:** `sonnet`

**การพัฒนาและภาษาโปรแกรม:**
- `python-pro` - เขียนโปรแกรม Python ด้วยฟีเจอร์ขั้นสูง
- `javascript-pro` - JavaScript สมัยใหม่และ Node.js
- `typescript-pro` - TypeScript ขั้นสูงพร้อมระบบชนิดข้อมูล
- `golang-pro` - การใช้ concurrent และรูปแบบที่ถูกต้องใน Go
- `rust-pro` - ความปลอดภัยหน่วยความจำและโปรแกรมระบบด้วย Rust
- `c-pro` - เขียนโปรแกรม C และระบบฝังตัว
- `cpp-pro` - C++ สมัยใหม่พร้อม STL และเทมเพลต
- `php-pro` - PHP สมัยใหม่ด้วยฟีเจอร์ขั้นสูง
- `java-pro` - Java สมัยใหม่พร้อม stream และ concurrent
- `elixir-pro` - Elixir พร้อมรูปแบบ OTP และ Phoenix
- `csharp-pro` - C# สมัยใหม่พร้อมเฟรมเวิร์ก .NET และรูปแบบการออกแบบ
- `scala-pro` - Scala สำหรับองค์กร พร้อม Apache Pekko, Akka, Spark, และ ZIO/Cats Effect
- `unity-developer` - พัฒนาเกม Unity และปรับแต่งประสิทธิภาพ
- `minecraft-bukkit-pro` - พัฒนา Minecraft plugin ด้วย Bukkit/Spigot/Paper
- `ios-developer` - พัฒนา iOS แบบ native ด้วย Swift/SwiftUI
- `frontend-developer` - สร้างคอมโพเนนต์ React และ UI
- `ui-ux-designer` - ออกแบบอินเทอร์เฟซและ wireframes
- `backend-architect` - ออกแบบ API และไมโครเซอร์วิส
- `mobile-developer` - สร้างแอป React Native/Flutter
- `sql-pro` - ปรับแต่ง SQL ที่ซับซ้อน
- `graphql-architect` - สร้าง schema และ resolver ของ GraphQL

**โครงสร้างพื้นฐานและการดำเนินงาน:**
- `devops-troubleshooter` - แก้ไขปัญหาในระบบผลิต
- `deployment-engineer` - การทำงานของ CI/CD pipelines
- `database-optimizer` - การปรับแต่งคิวรี
- `database-admin` - การดำเนินงานฐานข้อมูล
- `terraform-specialist` - โค้ดโครงสร้างพื้นฐาน (Infrastructure as Code)
- `network-engineer` - การกำหนดค่าเครือข่าย
- `dx-optimizer` - ประสบการณ์นักพัฒนา
- `data-engineer` - การทำงานของ ETL pipelines

**คุณภาพ & การสนับสนุน:**
- `test-automator` - การสร้างชุดทดสอบ
- `code-reviewer` - การวิเคราะห์คุณภาพโค้ด
- `debugger` - การตรวจสอบข้อผิดพลาด
- `error-detective` - การวิเคราะห์ log
- `ml-engineer` - การปรับใช้โมเดล ML
- `legacy-modernizer` - การย้ายเฟรมเวิร์กเก่าไปใหม่
- `payment-integration` - การเชื่อมต่อระบบชำระเงิน
- `mermaid-expert` - แผนภาพ Mermaid และเอกสารภาพ

### 🧠 Opus (ความสามารถสูงสุด) - 13 ตัวแทน
**โมเดล:** `opus`
- `ai-engineer` - แอปพลิเคชัน LLM และระบบ RAG
- `security-auditor` - การวิเคราะห์ช่องโหว่
- `performance-engineer` - การปรับแต่งแอปพลิเคชัน
- `incident-responder` - การจัดการเหตุการณ์ในระบบผลิตจริง
- `mlops-engineer` - โครงสร้างพื้นฐาน ML
- `architect-reviewer` - ความสอดคล้องทางสถาปัตยกรรม
- `cloud-architect` - การออกแบบโครงสร้างพื้นฐานระบบคลาวด์
- `prompt-engineer` - การปรับแต่ง prompt สำหรับ LLM
- `context-manager` - การประสานงานระหว่างตัวแทนหลายตัว
- `quant-analyst` - การสร้างแบบจำลองทางการเงิน
- `risk-manager` - การจัดการความเสี่ยงของพอร์ตการลงทุน
- `docs-architect` - เอกสารทางเทคนิคแบบครบถ้วนจากฐานโค้ด
- `tutorial-engineer` - เนื้อหาสอนทีละขั้นตอนและเนื้อหาการศึกษา

## การติดตั้ง

subagent เหล่านี้จะใช้งานได้อัตโนมัติเมื่อวางไว้ในไดเรกทอรี `~/.claude/agents/`

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

## เมื่อไหร่ควรใช้เอเจนต์ตัวไหน

### 🏗️ การวางแผน & สถาปัตยกรรม
- **backend-architect**: การออกแบบ API, สคีมาฐานข้อมูล, สถาปัตยกรรมระบบ
- **frontend-developer**: การวางแผน UI/UX, สถาปัตยกรรมคอมโพเนนต์
- **ui-ux-designer**: การออกแบบอินเทอร์เฟซ, ไวร์เฟรม, ระบบดีไซน์, การวิจัยผู้ใช้
- **cloud-architect**: การออกแบบโครงสร้างพื้นฐาน, การวางแผนขยายระบบ

### 🔧 การนำไปใช้ & การพัฒนา  
- **python-pro**: งานพัฒนาโดยใช้ Python
- **golang-pro**: งานพัฒนาโดยใช้ Go
- **rust-pro**: การพัฒนาโดยใช้ Rust, ความปลอดภัยของหน่วยความจำ, การเขียนโปรแกรมระบบ
- **c-pro**: การเขียนโปรแกรม C, ระบบฝังตัว, โค้ดประสิทธิภาพสูง
- **javascript-pro**: JavaScript สมัยใหม่, รูปแบบ async, โค้ด Node.js/เบราว์เซอร์
- **typescript-pro**: TypeScript ขั้นสูง, generics, การอนุมานชนิด, รูปแบบองค์กร
- **java-pro**: การพัฒนา Java สมัยใหม่, streams, concurrency, Spring Boot
- **elixir-pro**: การพัฒนา Elixir, รูปแบบ OTP, เฟรมเวิร์ก Phoenix, การเขียนโปรแกรมฟังก์ชันนัล
- **csharp-pro**: การพัฒนา C# สมัยใหม่, .NET เฟรมเวิร์ก, รูปแบบองค์กร
- **scala-pro**: Scala สำหรับองค์กรพร้อมโปรแกรมฟังก์ชันนัล, Apache Pekko/Akka actors, Apache Spark, ZIO/Cats Effect, สถาปัตยกรรม reactive
- **unity-developer**: การพัฒนาเกม Unity, การเขียนสคริปต์ C#, การเพิ่มประสิทธิภาพ
- **minecraft-bukkit-pro**: การพัฒนา Minecraft plugin, ระบบ event, ฟีเจอร์ฝั่งเซิร์ฟเวอร์
- **ios-developer**: การพัฒนา iOS แบบ native ด้วย Swift/SwiftUI
- **sql-pro**: คำสั่งฐานข้อมูล, การออกแบบสคีมา, การปรับแต่งคำสั่งค้นหา
- **mobile-developer**: การพัฒนา React Native/Flutter

### 🛠️ การปฏิบัติการ & การบำรุงรักษา
- **devops-troubleshooter**: ปัญหาในการผลิต, ปัญหาการ deploy
- **incident-responder**: เหตุขัดข้องร้ายแรงที่ต้องการการตอบสนองทันที
- **database-optimizer**: ประสิทธิภาพคำสั่งค้นหา, กลยุทธ์การทำดัชนี
- **database-admin**: กลยุทธ์สำรองข้อมูล, การจำลองข้อมูล, การจัดการผู้ใช้, การกู้คืนจากภัยพิบัติ
- **terraform-specialist**: โครงสร้างพื้นฐานเป็นโค้ด, โมดูล Terraform, การจัดการ state
- **network-engineer**: การเชื่อมต่อเครือข่าย, ตัวบาลานซ์โหลด, SSL/TLS, การดีบั๊ก DNS

### 📊 การวิเคราะห์ & การเพิ่มประสิทธิภาพ
- **performance-engineer**: คอขวดของแอปพลิเคชัน, การเพิ่มประสิทธิภาพ
- **security-auditor**: การสแกนหาช่องโหว่, การตรวจสอบความสอดคล้อง
- **data-scientist**: การวิเคราะห์ข้อมูล, การค้นหาข้อมูลเชิงลึก, การรายงาน
- **mlops-engineer**: โครงสร้างพื้นฐาน ML, การติดตามการทดลอง, การจัดเก็บโมเดล, การทำ pipeline อัตโนมัติ

### 🧪 การประกันคุณภาพ
- **code-reviewer**: คุณภาพของโค้ด, ความปลอดภัยของการตั้งค่า, ความน่าเชื่อถือในการใช้งานจริง
- **test-automator**: กลยุทธ์การทดสอบ, การสร้างชุดทดสอบ
- **debugger**: การตรวจสอบข้อบกพร่อง, การแก้ไขข้อผิดพลาด
- **error-detective**: การวิเคราะห์บันทึก, การรู้จำรูปแบบข้อผิดพลาด, การวิเคราะห์หาสาเหตุหลัก
- **search-specialist**: การวิจัยเว็บเชิงลึก, การวิเคราะห์คู่แข่ง, การตรวจสอบข้อเท็จจริง

### 📚 เอกสาร
- **api-documenter**: ข้อกำหนด OpenAPI/Swagger, เอกสาร API
- **docs-architect**: เอกสารทางเทคนิคอย่างครอบคลุม, คู่มือสถาปัตยกรรม, คู่มือระบบ
- **reference-builder**: ข้อมูลอ้างอิง API อย่างละเอียด, คู่มือการตั้งค่า, เอกสารพารามิเตอร์
- **tutorial-engineer**: บทช่วยสอนทีละขั้นตอน, เส้นทางการเรียนรู้, เนื้อหาเพื่อการศึกษา

### 💼 ธุรกิจและกลยุทธ์
- **business-analyst**: KPI, รูปแบบรายได้, การคาดการณ์การเติบโต, เมตริกส์สำหรับนักลงทุน
- **risk-manager**: ความเสี่ยงของพอร์ต, กลยุทธ์ป้องกันความเสี่ยง, R-multiples, การกำหนดขนาดสถานะ
- **content-marketer**: เนื้อหา SEO, บทความบล็อก, โซเชียลมีเดีย, แคมเปญอีเมล
- **sales-automator**: อีเมลแนะนำตัว, ติดตามผล, ข้อเสนอ, การบ่มเพาะลูกค้า
- **customer-support**: ตั๋วสนับสนุน, คำถามที่พบบ่อย, เอกสารช่วยเหลือ, การแก้ไขปัญหา
- **legal-advisor** - ร่างนโยบายความเป็นส่วนตัว, เงื่อนไขการให้บริการ, ข้อจำกัดความรับผิดชอบ, และประกาศทางกฎหมาย

## แนวทางปฏิบัติที่ดีที่สุด

### 🎯 การมอบหมายงาน
1. **ให้ Claude Code มอบหมายงานโดยอัตโนมัติ** - ตัวแทนหลักวิเคราะห์บริบทและเลือกตัวแทนที่เหมาะสมที่สุด
2. **ระบุข้อกำหนดให้ชัดเจน** - รวมข้อจำกัด, สแต็กเทคโนโลยี และข้อกำหนดด้านคุณภาพ
3. **เชื่อมั่นในความเชี่ยวชาญของตัวแทน** - ตัวแทนแต่ละรายถูกปรับแต่งให้เหมาะกับโดเมนของตน

### 🔄 เวิร์กโฟลว์แบบหลายตัวแทน
4. **เริ่มต้นด้วยคำขอระดับสูง** - ให้ตัวแทนประสานงานงานที่ซับซ้อนหลายขั้นตอน
5. **ให้ข้อมูลบริบทระหว่างตัวแทน** - ตรวจสอบให้แน่ใจว่าตัวแทนมีข้อมูลพื้นฐานที่จำเป็น
6. **ทบทวนจุดเชื่อมต่อการผสาน** - ตรวจสอบว่าผลลัพธ์ของตัวแทนแต่ละรายทำงานร่วมกันอย่างไร

### 🎛️ การควบคุมอย่างชัดเจน
7. **ใช้การเรียกใช้งานอย่างชัดเจนเมื่อมีความต้องการเฉพาะ** - เมื่อต้องการมุมมองจากผู้เชี่ยวชาญเฉพาะด้าน
8. **ผสมผสานตัวแทนหลายรายอย่างมีกลยุทธ์** - ผู้เชี่ยวชาญแต่ละรายสามารถตรวจสอบงานของกันและกันได้
9. **ร้องขอลักษณะการทบทวนเฉพาะทาง** - "ให้ security-auditor ทบทวนการออกแบบ API ของ backend-architect"

### 📈 การเพิ่มประสิทธิภาพ
10. **ติดตามประสิทธิผลของตัวแทน** - เรียนรู้ว่าตัวแทนใดเหมาะกับกรณีใช้งานของคุณที่สุด
11. **ปรับปรุงงานที่ซับซ้อนด้วยการวนซ้ำ** - ใช้ข้อเสนอแนะจากเอเจนต์เพื่อปรับข้อกำหนดให้เหมาะสม  
12. **ใช้จุดแข็งของเอเจนต์** - จับคู่งานตามความซับซ้อนให้ตรงกับความสามารถของเอเจนต์  

## การร่วมพัฒนา  

เพื่อเพิ่มซับเอเจนต์ใหม่:  
1. สร้างไฟล์ `.md` ใหม่โดยยึดตามรูปแบบด้านบน  
2. ใช้ชื่อภาษาอังกฤษตัวพิมพ์เล็กและคั่นด้วยขีดกลาง  
3. เขียนคำอธิบายให้ชัดเจนว่าเมื่อใดควรใช้ซับเอเจนต์นี้  
4. ระบุคำแนะนำเฉพาะไว้ใน system prompt  

## การแก้ไขปัญหา  

### ปัญหาทั่วไป  

**เอเจนต์ไม่ถูกเรียกใช้อัตโนมัติ:**  
- ตรวจสอบให้แน่ใจว่าคำขอของคุณระบุโดเมนอย่างชัดเจน (เช่น "ปัญหาประสิทธิภาพ" → performance-engineer)  
- ระบุประเภทงานให้ชัดเจน (เช่น "ตรวจทานโค้ด" → code-reviewer)  

**เลือกเอเจนต์ไม่ตรงตามที่คาดไว้:**  
- ให้ข้อมูลบริบทเกี่ยวกับเทคโนโลยีและข้อกำหนดของคุณเพิ่มเติม  
- ใช้การเรียกใช้งานแบบระบุเอเจนต์หากต้องการเอเจนต์เฉพาะ  

**เอเจนต์หลายตัวให้คำแนะนำขัดแย้งกัน:**  
- นี่เป็นเรื่องปกติ - ผู้เชี่ยวชาญแต่ละสายอาจมีลำดับความสำคัญต่างกัน  
- ขอคำอธิบายเพิ่มเติม: "ช่วยปรับคำแนะนำของ security-auditor และ performance-engineer ให้สอดคล้องกัน"  

**เอเจนต์ดูเหมือนไม่มีบริบท:**  
- ให้ข้อมูลพื้นหลังในคำขอของคุณ  
- อ้างอิงการสนทนาหรือรูปแบบที่เคยใช้มาก่อน  

### ขอความช่วยเหลือ  

หากเอเจนต์ไม่ทำงานตามที่คาดหวัง:  
1. ตรวจสอบคำอธิบายเอเจนต์ในไฟล์แต่ละตัว  
2. ลองใช้ภาษาที่เฉพาะเจาะจงมากขึ้นในคำขอ  
3. ใช้การเรียกใช้งานแบบระบุเอเจนต์เพื่อทดสอบเอเจนต์เฉพาะ  
4. ให้ข้อมูลเพิ่มเติมเกี่ยวกับโปรเจกต์และเป้าหมายของคุณ  

## ใบอนุญาต

โครงการนี้ได้รับอนุญาตภายใต้สัญญาอนุญาต MIT - ดูไฟล์ [LICENSE](LICENSE) สำหรับรายละเอียด

## เรียนรู้เพิ่มเติม

- [เอกสารประกอบ Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [เอกสารประกอบ Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code บน GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---