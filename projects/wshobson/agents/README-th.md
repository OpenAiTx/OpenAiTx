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

# คอลเลกชัน Claude Code Subagents

ชุดรวบรวมซับเอเจนต์ AI เฉพาะทางสำหรับ [Claude Code](https://docs.anthropic.com/en/docs/claude-code) ที่ออกแบบมาเพื่อเสริมสร้างเวิร์กโฟลว์การพัฒนาด้วยความเชี่ยวชาญเฉพาะด้าน

## ภาพรวม

รีโพซิทอรีนี้ประกอบด้วยซับเอเจนต์เฉพาะทาง 57 ตัว ที่ขยายความสามารถของ Claude Code ซับเอเจนต์แต่ละตัวเป็นผู้เชี่ยวชาญในแต่ละสาขา ซึ่งจะถูกเรียกใช้อัตโนมัติตามบริบทหรือเรียกใช้งานโดยตรงเมื่อจำเป็น เอเจนต์ทั้งหมดถูกกำหนดค่าด้วยโมเดล Claude ที่แตกต่างกันตามความซับซ้อนของงาน เพื่อประสิทธิภาพและความคุ้มค่าสูงสุด

## ซับเอเจนต์ที่มีให้ใช้งาน

### การพัฒนา & สถาปัตยกรรม
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - ออกแบบ RESTful APIs, ขอบเขตไมโครเซอร์วิส และสคีมาฐานข้อมูล
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - สร้างคอมโพเนนต์ React, ออกแบบเลย์เอาต์ที่ตอบสนองได้ และจัดการสถานะฝั่งลูกค้า
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - สร้างดีไซน์อินเทอร์เฟซ, ไวร์เฟรม และระบบการออกแบบ
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - พัฒนาแอป React Native หรือ Flutter พร้อมการเชื่อมต่อกับ native
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - ออกแบบสคีมา GraphQL, รีโซลเวอร์ และการเฟเดอเรชั่น
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - ตรวจสอบการเปลี่ยนแปลงโค้ดเพื่อความสอดคล้องและรูปแบบทางสถาปัตยกรรม

### ผู้เชี่ยวชาญภาษาโปรแกรม
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - เขียนโค้ด Python ที่ถูกต้องตามหลัก พร้อมฟีเจอร์ขั้นสูงและการปรับแต่งประสิทธิภาพ
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - เขียนโค้ด Go ที่ถูกต้องตามหลัก พร้อม goroutines, channels และ interfaces
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - เขียนโค้ด Rust ที่ถูกต้องตามหลัก พร้อมรูปแบบ ownership, lifetimes และการ implement traits
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - เขียนโค้ด C ที่มีประสิทธิภาพ พร้อมการจัดการหน่วยความจำและ system calls ที่ถูกต้อง
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - เขียนโค้ด C++ ที่ถูกต้องตามหลัก พร้อมฟีเจอร์สมัยใหม่, RAII, smart pointers และอัลกอริทึม STL
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - เชี่ยวชาญ JavaScript สมัยใหม่ด้วย ES6+, รูปแบบ async และ Node.js APIs
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - เชี่ยวชาญ TypeScript ด้วยชนิดข้อมูลขั้นสูง, generics และความปลอดภัยของชนิดข้อมูลแบบเข้มงวด
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - เขียนโค้ด PHP ที่ถูกต้องตามหลัก พร้อมฟีเจอร์สมัยใหม่และการปรับแต่งประสิทธิภาพ
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - เชี่ยวชาญ Java สมัยใหม่ด้วย streams, concurrency และการปรับแต่ง JVM
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - เขียนโค้ด Elixir ที่ถูกต้องตามหลัก พร้อมรูปแบบ OTP, การเขียนโปรแกรมเชิงฟังก์ชัน และเฟรมเวิร์ก Phoenix
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - เขียนโค้ด C# สมัยใหม่ด้วยฟีเจอร์ขั้นสูงและการปรับแต่ง .NET
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - สร้างเกม Unity ด้วยสคริปต์ที่ปรับแต่งและการปรับปรุงประสิทธิภาพ
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - เชี่ยวชาญการพัฒนา Minecraft server plugin ด้วย Bukkit, Spigot และ Paper APIs
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - พัฒนาแอป iOS แบบ native ด้วย Swift/SwiftUI
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - เขียน SQL query ที่ซับซ้อน, ปรับแต่ง execution plan และออกแบบสคีมาที่ normalized

### โครงสร้างพื้นฐาน & การปฏิบัติการ
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - แก้ไขปัญหาการทำงานจริง, วิเคราะห์ log และแก้ไขความล้มเหลวในการ deploy
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - กำหนดค่า CI/CD pipeline, คอนเทนเนอร์ Docker และการ deploy บนคลาวด์
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - ออกแบบโครงสร้างพื้นฐาน AWS/Azure/GCP และปรับแต่งค่าใช้จ่ายคลาวด์
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - ปรับแต่ง SQL query, ออกแบบ index ที่มีประสิทธิภาพ และจัดการ migration ฐานข้อมูล
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - ดูแลการดำเนินงานฐานข้อมูล, การสำรองข้อมูล, การจำลองข้อมูล และการมอนิเตอร์
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - เขียนโมดูล Terraform ขั้นสูง, จัดการไฟล์สถานะ และนำแนวทาง IaC ที่ดีที่สุดไปใช้
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - รับมือกับเหตุการณ์การทำงานจริงด้วยความเร่งด่วนและแม่นยำ
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - แก้ไขปัญหาการเชื่อมต่อเครือข่าย, กำหนดค่าโหลดบาลานเซอร์ และวิเคราะห์รูปแบบทราฟฟิก
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - ผู้เชี่ยวชาญด้าน Developer Experience ที่ปรับปรุงเครื่องมือ, การตั้งค่า และเวิร์กโฟลว์

### คุณภาพ & ความปลอดภัย
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - ตรวจสอบโค้ดโดยผู้เชี่ยวชาญด้วยโฟกัสด้านความปลอดภัยในการกำหนดค่าและความน่าเชื่อถือในการทำงานจริง
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - ตรวจสอบโค้ดหาช่องโหว่และรับรองความสอดคล้องกับ OWASP
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - สร้างชุดทดสอบที่ครอบคลุมด้วยการทดสอบแบบหน่วย, การรวมระบบ, และ e2e
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - วิเคราะห์ประสิทธิภาพแอปพลิเคชัน, ปรับปรุงจุดคอขวด, และดำเนินกลยุทธ์แคช
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - ผู้เชี่ยวชาญด้านดีบักสำหรับข้อผิดพลาด, การทดสอบล้มเหลว, และพฤติกรรมผิดปกติ
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - ค้นหาแพทเทิร์นข้อผิดพลาด, สแต็คเทรซ, และความผิดปกติในล็อกและโค้ด
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - ผู้เชี่ยวชาญการวิจัยเว็บด้วยเทคนิคการค้นหาขั้นสูงและการสังเคราะห์ข้อมูล

### Data & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - ผู้เชี่ยวชาญวิเคราะห์ข้อมูลสำหรับ SQL, BigQuery และอินไซต์ข้อมูล
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - สร้าง ETL pipeline, คลังข้อมูล, และสถาปัตยกรรมสตรีมมิ่ง
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - สร้างแอปพลิเคชัน LLM, ระบบ RAG และ prompt pipeline
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - สร้าง ML pipeline, การให้บริการโมเดล, และวิศวกรรมฟีเจอร์
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - สร้าง ML pipeline, การติดตามการทดลอง, และรีจิสทรีโมเดล
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - ปรับแต่ง prompt สำหรับ LLM และระบบ AI

### Specialized Domains
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - สร้างสเปค OpenAPI/Swagger และเขียนเอกสารสำหรับนักพัฒนา
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - รวม Stripe, PayPal และโปรเซสเซอร์การชำระเงิน
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - สร้างโมเดลการเงิน, ทดสอบกลยุทธ์เทรดย้อนหลัง, และวิเคราะห์ข้อมูลตลาด
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - ตรวจสอบความเสี่ยงในพอร์ต, R-multiple และขีดจำกัดสถานะ
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - รีแฟคเตอร์โค้ดระบบเก่าและดำเนินการปรับปรุงทีละขั้น
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - จัดการบริบทระหว่างหลายเอเจนต์และงานระยะยาว

### Documentation
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - สร้างเอกสารเทคนิคที่ครอบคลุมจากโค้ดที่มีอยู่แล้ว
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - สร้างเอกสารอ้างอิงทางเทคนิคและเอกสาร API อย่างละเอียด
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - สร้างบทเรียนทีละขั้นและเนื้อหาการสอนจากโค้ด

### Business & Marketing
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - วิเคราะห์เมตริก, สร้างรายงาน, และติดตาม KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - เขียนบล็อก, เนื้อหาสื่อสังคม, และจดหมายข่าว
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - ร่างอีเมลติดต่อลูกค้าใหม่, ติดตามผล, และแม่แบบข้อเสนอ
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - จัดการตั๋วซัพพอร์ต, ตอบคำถามที่พบบ่อย, และอีเมลลูกค้า
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - ร่างนโยบายความเป็นส่วนตัว, ข้อกำหนดการใช้บริการ, ข้อสงวนสิทธิ์ และประกาศทางกฎหมาย

## การมอบหมายโมเดล

เอเจนต์ย่อยทั้ง 57 ตัวถูกกำหนดค่าให้ใช้โมเดล Claude ที่เหมาะสมตามความซับซ้อนของงาน:

### 🚀 Haiku (รวดเร็วและคุ้มค่า) - 9 เอเจนต์
**โมเดล:** `haiku`
- `data-scientist` - การเขียนคำสั่ง SQL และวิเคราะห์ข้อมูล
- `api-documenter` - เอกสาร OpenAPI/Swagger
- `reference-builder` - เอกสารอ้างอิงทางเทคนิคและ API อย่างละเอียด
- `business-analyst` - การติดตามตัวชี้วัดและ KPI
- `content-marketer` - โพสต์บล็อกและโซเชียลมีเดีย
- `customer-support` - ทิกเก็ตสนับสนุนและคำถามที่พบบ่อย
- `sales-automator` - อีเมลติดต่อและข้อเสนองานขาย
- `search-specialist` - การวิจัยเว็บไซต์และรวบรวมข้อมูล
- `legal-advisor` - นโยบายความเป็นส่วนตัวและเอกสารการปฏิบัติตามกฎ

### ⚡ Sonnet (ประสิทธิภาพสมดุล) - 35 เอเจนต์
**โมเดล:** `sonnet`

**การพัฒนา & ภาษา:**
- `python-pro` - การพัฒนา Python พร้อมฟีเจอร์ขั้นสูง
- `javascript-pro` - JavaScript สมัยใหม่และ Node.js
- `typescript-pro` - TypeScript ขั้นสูงกับระบบประเภท
- `golang-pro` - Go concurrency และแพทเทิร์นที่เป็นแบบฉบับ
- `rust-pro` - Rust เพื่อความปลอดภัยด้านหน่วยความจำและระบบ
- `c-pro` - การเขียนโปรแกรม C และระบบฝังตัว
- `cpp-pro` - C++ สมัยใหม่กับ STL และเทมเพลต
- `php-pro` - PHP สมัยใหม่พร้อมฟีเจอร์ขั้นสูง
- `java-pro` - Java สมัยใหม่กับ stream และ concurrency
- `elixir-pro` - Elixir พร้อม OTP patterns และ Phoenix
- `csharp-pro` - C# สมัยใหม่กับ .NET frameworks และ patterns
- `unity-developer` - การพัฒนาเกม Unity และเพิ่มประสิทธิภาพ
- `minecraft-bukkit-pro` - การพัฒนา Minecraft plugin กับ Bukkit/Spigot/Paper
- `ios-developer` - การพัฒนา iOS แบบ native ด้วย Swift/SwiftUI
- `frontend-developer` - React components และ UI
- `ui-ux-designer` - การออกแบบอินเทอร์เฟซและ wireframe
- `backend-architect` - การออกแบบ API และ microservices
- `mobile-developer` - แอป React Native/Flutter
- `sql-pro` - การเพิ่มประสิทธิภาพ SQL ที่ซับซ้อน
- `graphql-architect` - สคีมาและ resolver ของ GraphQL

**โครงสร้างพื้นฐาน & การปฏิบัติการ:**
- `devops-troubleshooter` - การดีบักระบบ production
- `deployment-engineer` - การสร้าง pipeline CI/CD
- `database-optimizer` - การเพิ่มประสิทธิภาพคำสั่ง query
- `database-admin` - การปฏิบัติการฐานข้อมูล
- `terraform-specialist` - โครงสร้างพื้นฐานแบบโค้ด
- `network-engineer` - การกำหนดค่าเครือข่าย
- `dx-optimizer` - ประสบการณ์นักพัฒนา
- `data-engineer` - กระบวนการ ETL

**คุณภาพ & การสนับสนุน:**
- `test-automator` - การสร้างชุดทดสอบ
- `code-reviewer` - การวิเคราะห์คุณภาพโค้ด
- `debugger` - การตรวจสอบข้อผิดพลาด
- `error-detective` - การวิเคราะห์ log
- `ml-engineer` - การปรับใช้โมเดล ML
- `legacy-modernizer` - การย้ายเฟรมเวิร์ก
- `payment-integration` - การประมวลผลการชำระเงิน

### 🧠 Opus (ขีดความสามารถสูงสุด) - 13 ตัวแทน
**โมเดล:** `opus`
- `ai-engineer` - แอปพลิเคชัน LLM และระบบ RAG
- `security-auditor` - การวิเคราะห์ช่องโหว่
- `performance-engineer` - การเพิ่มประสิทธิภาพแอปพลิเคชัน
- `incident-responder` - การรับมือเหตุการณ์ในระบบโปรดักชั่น
- `mlops-engineer` - โครงสร้างพื้นฐาน ML
- `architect-reviewer` - ความสอดคล้องทางสถาปัตยกรรม
- `cloud-architect` - การออกแบบโครงสร้างพื้นฐานคลาวด์
- `prompt-engineer` - การปรับแต่งพรอมต์ LLM
- `context-manager` - การประสานงานระหว่างหลายตัวแทน
- `quant-analyst` - การสร้างแบบจำลองทางการเงิน
- `risk-manager` - การจัดการความเสี่ยงพอร์ตโฟลิโอ
- `docs-architect` - สร้างเอกสารเทคนิคเชิงลึกจากโค้ดเบส
- `tutorial-engineer` - คู่มือทีละขั้นตอนและเนื้อหาการเรียนรู้

## การติดตั้ง

ซับเอเจนต์เหล่านี้จะพร้อมใช้งานโดยอัตโนมัติเมื่อวางไว้ในไดเรกทอรี `~/.claude/agents/`

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

## เมื่อไหร่ควรใช้เอเจนต์ไหน

### 🏗️ การวางแผน & สถาปัตยกรรม
- **backend-architect**: การออกแบบ API, สคีมาฐานข้อมูล, สถาปัตยกรรมระบบ
- **frontend-developer**: การวางแผน UI/UX, สถาปัตยกรรมคอมโพเนนต์
- **ui-ux-designer**: การออกแบบอินเทอร์เฟซ, ไวร์เฟรม, ระบบดีไซน์, การวิจัยผู้ใช้
- **cloud-architect**: การออกแบบโครงสร้างพื้นฐาน, การวางแผนการปรับขยาย

### 🔧 การพัฒนา & การลงมือทำ  
- **python-pro**: งานพัฒนาที่เกี่ยวข้องกับ Python โดยเฉพาะ
- **golang-pro**: งานพัฒนาที่เกี่ยวข้องกับ Go โดยเฉพาะ
- **rust-pro**: งานพัฒนา Rust, ความปลอดภัยของหน่วยความจำ, การเขียนโปรแกรมระบบ
- **c-pro**: การเขียนโปรแกรม C, ระบบฝังตัว, โค้ดที่เน้นประสิทธิภาพสูง
- **javascript-pro**: JavaScript สมัยใหม่, รูปแบบ async, โค้ด Node.js/เบราว์เซอร์
- **typescript-pro**: TypeScript ขั้นสูง, generics, การอนุมานชนิดข้อมูล, รูปแบบองค์กร
- **java-pro**: Java สมัยใหม่, stream, การประมวลผลพร้อมกัน, Spring Boot
- **elixir-pro**: การพัฒนา Elixir, รูปแบบ OTP, เฟรมเวิร์ก Phoenix, การเขียนโปรแกรมเชิงฟังก์ชัน
- **csharp-pro**: การพัฒนา C# สมัยใหม่, .NET เฟรมเวิร์ก, รูปแบบองค์กร
- **unity-developer**: การพัฒนาเกม Unity, การเขียนสคริปต์ C#, การเพิ่มประสิทธิภาพ
- **minecraft-bukkit-pro**: การพัฒนา plugin Minecraft, ระบบ event, ฟีเจอร์ฝั่งเซิร์ฟเวอร์
- **ios-developer**: การพัฒนา iOS แบบ native ด้วย Swift/SwiftUI
- **sql-pro**: การเขียน query ฐานข้อมูล, ออกแบบสคีมา, การปรับแต่ง query
- **mobile-developer**: การพัฒนา React Native/Flutter

### 🛠️ การปฏิบัติการ & การบำรุงรักษา
- **devops-troubleshooter**: ปัญหาใน production, ปัญหา deployment
- **incident-responder**: การหยุดชะงักที่วิกฤต ต้องการการตอบสนองทันที
- **database-optimizer**: ประสิทธิภาพ query, กลยุทธ์ indexing
- **database-admin**: กลยุทธ์สำรองข้อมูล, การจำลองข้อมูล, การจัดการผู้ใช้, การกู้คืนจากภัยพิบัติ
- **terraform-specialist**: Infrastructure as Code, โมดูล Terraform, การจัดการ state
- **network-engineer**: การเชื่อมต่อเครือข่าย, load balancer, SSL/TLS, การดีบัก DNS

### 📊 การวิเคราะห์ & การเพิ่มประสิทธิภาพ
- **performance-engineer**: คอขวดของแอปพลิเคชัน, การเพิ่มประสิทธิภาพ
- **security-auditor**: การสแกนหาช่องโหว่, การตรวจสอบความสอดคล้อง
- **data-scientist**: การวิเคราะห์ข้อมูล, การสรุปข้อมูล, การจัดทำรายงาน
- **mlops-engineer**: โครงสร้างพื้นฐาน ML, การติดตามการทดลอง, model registry, การทำ pipeline อัตโนมัติ

### 🧪 การประกันคุณภาพ
- **code-reviewer**: คุณภาพของโค้ด, ความปลอดภัยในการกำหนดค่า, ความน่าเชื่อถือในระบบโปรดักชั่น
- **test-automator**: กลยุทธ์การทดสอบ, การสร้างชุดทดสอบ
- **debugger**: การสืบสวนบั๊ก, การแก้ไขข้อผิดพลาด
- **error-detective**: การวิเคราะห์ล็อก, การรู้จำรูปแบบข้อผิดพลาด, การวิเคราะห์สาเหตุหลัก
- **search-specialist**: การค้นคว้าเว็บเชิงลึก, การวิเคราะห์คู่แข่ง, การตรวจสอบข้อเท็จจริง

### 📚 เอกสารประกอบ
- **api-documenter**: สเปค OpenAPI/Swagger, เอกสาร API
- **docs-architect**: เอกสารเทคนิคอย่างครบถ้วน, คู่มือสถาปัตยกรรม, คู่มือระบบ
- **reference-builder**: อ้างอิง API แบบละเอียด, คู่มือการกำหนดค่า, เอกสารพารามิเตอร์
- **tutorial-engineer**: บทเรียนทีละขั้นตอน, เส้นทางการเรียนรู้, เนื้อหาการศึกษา

### 💼 ธุรกิจ & กลยุทธ์
- **business-analyst**: KPIs, รูปแบบรายได้, การคาดการณ์การเติบโต, ตัวชี้วัดนักลงทุน
- **risk-manager**: ความเสี่ยงพอร์ตโฟลิโอ, กลยุทธ์ป้องกันความเสี่ยง, R-multiples, การกำหนดขนาดสถานะ
- **content-marketer**: เนื้อหา SEO, บทความบล็อก, โซเชียลมีเดีย, แคมเปญอีเมล
- **sales-automator**: อีเมลขายเย็น, การติดตามผล, ข้อเสนอ, การบ่มเพาะลีด
- **customer-support**: ตั๋วสนับสนุน, คำถามที่พบบ่อย, เอกสารช่วยเหลือ, การแก้ปัญหา
- **legal-advisor** - ร่างนโยบายความเป็นส่วนตัว, ข้อกำหนดการให้บริการ, ข้อจำกัดความรับผิด, และประกาศทางกฎหมาย

## แนวทางปฏิบัติที่ดีที่สุด

### 🎯 การมอบหมายงาน
1. **ให้ Claude Code มอบหมายงานโดยอัตโนมัติ** - เอเจนต์หลักวิเคราะห์บริบทและเลือกเอเจนต์ที่เหมาะสมที่สุด
2. **ระบุความต้องการให้ชัดเจน** - ระบุข้อจำกัด, เทคโนโลยีที่ใช้, และข้อกำหนดคุณภาพ
3. **เชื่อมั่นในความเชี่ยวชาญของเอเจนต์** - เอเจนต์แต่ละตัวเหมาะสมที่สุดสำหรับโดเมนของตน

### 🔄 เวิร์กโฟลว์หลายเอเจนต์
4. **เริ่มต้นด้วยคำขอระดับสูง** - ให้เอเจนต์ประสานงานงานที่ซับซ้อนหลายขั้นตอน
5. **ให้ข้อมูลบริบทระหว่างเอเจนต์** - ให้แน่ใจว่าเอเจนต์ได้รับข้อมูลพื้นหลังที่จำเป็น
6. **ตรวจสอบจุดบูรณาการ** - ตรวจสอบว่าเอาต์พุตของเอเจนต์ต่าง ๆ ทำงานร่วมกันได้อย่างไร

### 🎛️ การควบคุมอย่างชัดเจน
7. **ใช้การเรียกใช้งานโดยตรงเมื่อจำเป็น** - เมื่อต้องการมุมมองจากผู้เชี่ยวชาญเฉพาะด้าน
8. **ผสมผสานเอเจนต์หลายตัวอย่างมีกลยุทธ์** - ผู้เชี่ยวชาญแต่ละด้านช่วยตรวจสอบงานของกันและกัน
9. **ขอรูปแบบการตรวจสอบเฉพาะ** - "ให้ security-auditor ตรวจสอบการออกแบบ API ของ backend-architect"

### 📈 การเพิ่มประสิทธิภาพ
10. **ติดตามประสิทธิภาพของเอเจนต์** - เรียนรู้ว่าเอเจนต์ใดเหมาะสมกับกรณีใช้งานของคุณที่สุด
11. **ปรับปรุงงานที่ซับซ้อนอย่างต่อเนื่อง** - ใช้ข้อเสนอแนะจากเอเจนต์เพื่อปรับแต่งข้อกำหนด
12. **ใช้จุดแข็งของเอเจนต์** - จับคู่ความซับซ้อนของงานกับความสามารถของเอเจนต์

## การมีส่วนร่วม

ในการเพิ่มซับเอเจนต์ใหม่:
1. สร้างไฟล์ `.md` ใหม่โดยใช้รูปแบบข้างต้น
2. ใช้ชื่อที่เป็นตัวพิมพ์เล็กและคั่นด้วยขีดกลาง
3. เขียนคำอธิบายอย่างชัดเจนว่าเมื่อใดควรใช้ซับเอเจนต์นั้น
4. ระบุคำแนะนำเฉพาะในพรอมต์ของระบบ

## การแก้ไขปัญหา

### ปัญหาทั่วไป

**เอเจนต์ไม่ถูกเรียกใช้อัตโนมัติ:**
- ตรวจสอบให้แน่ใจว่าคำขอของคุณระบุโดเมนอย่างชัดเจน (เช่น "ปัญหาด้านประสิทธิภาพ" → performance-engineer)
- ระบุประเภทของงานให้ชัดเจน (เช่น "ตรวจสอบโค้ด" → code-reviewer)

**การเลือกเอเจนต์ที่ไม่คาดคิด:**
- ให้ข้อมูลเพิ่มเติมเกี่ยวกับเทคสแต็กและความต้องการของคุณ
- ใช้การเรียกอย่างชัดเจนหากต้องการเอเจนต์เฉพาะ

**มีหลายเอเจนต์ให้คำแนะนำที่ขัดแย้งกัน:**
- ถือว่าเป็นเรื่องปกติ - ผู้เชี่ยวชาญแต่ละคนอาจให้ความสำคัญต่างกัน
- ขอคำชี้แจง: "กรุณาสรุปคำแนะนำจาก security-auditor และ performance-engineer"

**เอเจนต์ดูเหมือนไม่มีบริบท:**
- ให้ข้อมูลพื้นหลังในคำขอของคุณ
- อ้างอิงถึงการสนทนาก่อนหน้านี้หรือรูปแบบที่กำหนดไว้แล้ว

### การขอความช่วยเหลือ

หากเอเจนต์ทำงานไม่เป็นไปตามที่คาดหวัง:
1. ตรวจสอบคำอธิบายเอเจนต์ในแต่ละไฟล์
2. ลองใช้ภาษาที่เฉพาะเจาะจงมากขึ้นในคำขอของคุณ
3. ใช้การเรียกอย่างชัดเจนเพื่อทดสอบเอเจนต์เฉพาะ
4. ให้ข้อมูลเพิ่มเติมเกี่ยวกับโปรเจกต์และเป้าหมายของคุณ

## ใบอนุญาต

โครงการนี้ได้รับอนุญาตภายใต้สัญญาอนุญาต MIT - ดูไฟล์ [LICENSE](LICENSE) สำหรับรายละเอียด

## เรียนรู้เพิ่มเติม

- [เอกสารประกอบ Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [เอกสารประกอบ Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code บน GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---