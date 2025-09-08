
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# คำสั่ง Slash ของ Claude Code

คำสั่ง Slash พร้อมใช้งานจริงสำหรับ [Claude Code](https://docs.anthropic.com/en/docs/claude-code) ที่ช่วยเร่งกระบวนการพัฒนาด้วยระบบอัตโนมัติอัจฉริยะ

**52 คำสั่ง** จัดหมวดหมู่ดังนี้:
- **🤖 เวิร์กโฟลว์**: การประสานงานหลายซับเอเจนต์สำหรับงานที่ซับซ้อน
- **🔧 เครื่องมือ**: ยูทิลิตี้เฉพาะจุดสำหรับการดำเนินงานเฉพาะ

### 🤝 ต้องการ Claude Code Subagents

คำสั่งเหล่านี้ทำงานร่วมกับ [Claude Code Subagents](https://github.com/wshobson/agents) เพื่อความสามารถในการจัดการแบบออร์เคสเตรชั่น

## การติดตั้ง

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## คำสั่งที่มีให้ใช้งาน

- **🤖 เวิร์กโฟลว์** - จัดการซับเอเจนต์หลายตัวสำหรับงานที่ซับซ้อน
- **🔧 เครื่องมือ** - คำสั่งเฉพาะสำหรับการดำเนินงานเฉพาะด้าน

## วิธีการใช้งาน

คำสั่งจะถูกจัดระเบียบไว้ในไดเรกทอรี `tools/` และ `workflows/` ใช้งานโดยใส่คำนำหน้าไดเรกทอรี:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**หมายเหตุ:** หากคุณต้องการใช้คำสั่งโดยไม่ต้องมีคำนำหน้า คุณสามารถแบนโครงสร้างไดเรกทอรี:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code จะแนะนำคำสั่งที่เกี่ยวข้องโดยอัตโนมัติตามบริบท

## 🤖 เวิร์กโฟลว์

การประสานงานซับเอเจนต์หลายตัวสำหรับงานที่ซับซ้อน:

### การพัฒนาฟีเจอร์
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - ซับเอเจนต์ backend, frontend, การทดสอบ และการ deploy สร้างฟีเจอร์สมบูรณ์
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - ซับเอเจนต์รีวิวหลายตัวให้การวิเคราะห์โค้ดอย่างครบถ้วน
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - วิเคราะห์ปัญหาและมอบหมายให้ซับเอเจนต์เฉพาะทางที่เหมาะสม

### กระบวนการพัฒนา
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - ใช้งาน Git workflow ที่มีประสิทธิภาพด้วยกลยุทธ์ branching และเทมเพลต PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - ปรับปรุงประสิทธิภาพซับเอเจนต์ด้วยการปรับแต่ง prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - ปรับปรุงโค้ดเก่าให้ทันสมัยด้วยซับเอเจนต์เฉพาะทาง
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - สร้าง ML pipeline ด้วยซับเอเจนต์ด้านข้อมูลและ ML engineering
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - สร้างแอปพลิเคชันข้ามแพลตฟอร์มด้วยการประสานงานซับเอเจนต์
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - อัตโนมัติ CI/CD, การมอนิเตอร์ และเวิร์กโฟลว์การ deploy

### เวิร์กโฟลว์ที่ประสานงานโดยซับเอเจนต์
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - ฟีเจอร์ข้ามแพลตฟอร์มด้วยซับเอเจนต์ backend, frontend และ mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - การพัฒนาเน้นความปลอดภัยด้วยซับเอเจนต์เฉพาะทาง
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ฟีเจอร์ขับเคลื่อนด้วย ML โดยซับเอเจนต์ด้าน data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - เพิ่มประสิทธิภาพแบบ end-to-end ด้วยซับเอเจนต์ด้าน performance
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - การจัดการเหตุการณ์ใน production ด้วยซับเอเจนต์ ops

## 🔧 เครื่องมือ (คำสั่งเฉพาะทาง)

### AI & แมชชีนเลิร์นนิง
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - สร้าง AI assistant และ chatbot พร้อมใช้งานจริง
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - รีวิวเฉพาะด้านสำหรับ codebase AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - สร้าง LangChain/LangGraph agent ด้วยแพทเทิร์นสมัยใหม่
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - สร้าง ML pipeline แบบครบวงจรด้วย MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - ปรับแต่ง prompt AI เพื่อประสิทธิภาพและคุณภาพ

### สถาปัตยกรรม & คุณภาพโค้ด
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - สร้างคำอธิบายละเอียดสำหรับโค้ดที่ซับซ้อน
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - ย้ายโค้ดระหว่างภาษา เฟรมเวิร์ก หรือเวอร์ชั่นต่าง ๆ
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - รีแฟกเตอร์โค้ดเพื่อความดูแลรักษาและประสิทธิภาพ

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - วิเคราะห์และจัดลำดับความสำคัญของหนี้ทางเทคนิค

### ข้อมูล & ฐานข้อมูล
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - ออกแบบสถาปัตยกรรมสายข้อมูลที่ปรับขนาดได้
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - สร้างระบบตรวจสอบข้อมูลอย่างครอบคลุม
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - กลยุทธ์การย้ายฐานข้อมูลขั้นสูง

### DevOps & โครงสร้างพื้นฐาน
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - สร้างการกำหนดค่าการปรับใช้และเช็คลิสต์
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - กลยุทธ์การเพิ่มประสิทธิภาพคอนเทนเนอร์ขั้นสูง
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - การปรับใช้ Kubernetes ระดับการผลิต
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - ตั้งค่าการมอนิเตอร์และการสังเกตการณ์แบบครบวงจร
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - นำเป้าหมายระดับบริการ (SLOs) มาใช้
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - ทำงานอัตโนมัติสำหรับกระบวนการพัฒนาและปฏิบัติการ

### การพัฒนา & การทดสอบ
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - สร้าง API จำลองที่สมจริงเพื่อใช้ในการพัฒนาและทดสอบ
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - สร้างจุดเชื่อมต่อ API ที่พร้อมใช้ในระดับการผลิตพร้อมชุดการดำเนินงานครบถ้วน
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - สร้างชุดทดสอบแบบครอบคลุมพร้อมการตรวจจับเฟรมเวิร์ก

### ความปลอดภัย & การปฏิบัติตามข้อกำหนด
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - ทดสอบและแก้ไขการเข้าถึงระบบอย่างสมบูรณ์
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - ตรวจสอบการปฏิบัติตามข้อกำหนด (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - สแกนความปลอดภัยแบบครบวงจรพร้อมการแก้ไขอัตโนมัติ

### การดีบั๊ก & การวิเคราะห์
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - กลยุทธ์การดีบั๊กและติดตามขั้นสูง
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - วิเคราะห์รูปแบบข้อผิดพลาดอย่างลึกซึ้งและกลยุทธ์การแก้ไข
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - ติดตามและวินิจฉัยข้อผิดพลาดในการผลิต
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - สร้างประเด็นบน GitHub/GitLab ที่มีโครงสร้างดี

### การพึ่งพา & การกำหนดค่า
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - ตรวจสอบและจัดการการกำหนดค่าแอปพลิเคชัน
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - ตรวจสอบการพึ่งพาเพื่อความปลอดภัยและใบอนุญาต
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - อัปเกรดการพึ่งพาโครงการอย่างปลอดภัย

### เอกสาร & การทำงานร่วมกัน
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - สร้างเอกสารประกอบที่ครอบคลุม
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - ใช้งาน Git workflow อย่างมีประสิทธิภาพ
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - เพิ่มคุณภาพให้กับ pull request ด้วยการตรวจสอบคุณภาพ

### การเพิ่มประสิทธิภาพต้นทุน
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - เพิ่มประสิทธิภาพต้นทุนคลาวด์และโครงสร้างพื้นฐาน

### การเริ่มต้นใช้งานและการตั้งค่า
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - ตั้งค่าสภาพแวดล้อมการพัฒนาสำหรับสมาชิกทีมใหม่

### เครื่องมือซับเอเจนต์
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - ตรวจสอบโค้ดจากหลายมุมมองด้วยซับเอเจนต์เฉพาะทาง
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - ดีบักอย่างลึกด้วยซับเอเจนต์สำหรับดีบักและประสิทธิภาพ
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - ปรับแต่งทั้งสแต็กด้วยซับเอเจนต์หลายตัว
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - บันทึกบริบทโปรเจ็กต์ด้วยซับเอเจนต์จัดการบริบท
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - เรียกคืนบริบทที่บันทึกไว้เพื่อความต่อเนื่อง

## คุณสมบัติ

- การใช้งานพร้อมผลิตจริง
- ตรวจจับเฟรมเวิร์กอัตโนมัติ
- แนวทางปฏิบัติด้านความปลอดภัยที่ดีที่สุด
- การตรวจสอบและทดสอบในตัว
- คำสั่งทำงานร่วมกันอย่างไร้รอยต่อ

## จำนวนคำสั่ง

**รวม: 52 คำสั่งสแลชที่พร้อมผลิตจริง** จัดกลุ่มเป็น:

### 🤖 เวิร์กโฟลว์ (14 คำสั่ง)

- การพัฒนาและตรวจสอบฟีเจอร์ (3 คำสั่ง) 
- การทำงานอัตโนมัติของกระบวนการพัฒนา (6 คำสั่ง)
- เวิร์กโฟลว์ที่จัดการโดยซับเอเจนต์ (5 คำสั่ง)

### 🔧 เครื่องมือ (38 คำสั่ง)

- ปัญญาประดิษฐ์และแมชชีนเลิร์นนิง (5 คำสั่ง)
- สถาปัตยกรรมและคุณภาพโค้ด (4 คำสั่ง)
- ข้อมูลและฐานข้อมูล (3 คำสั่ง)
- ดีโวปส์และโครงสร้างพื้นฐาน (6 คำสั่ง)
- การพัฒนาและทดสอบ (3 คำสั่ง)
- ความปลอดภัยและการปฏิบัติตามข้อกำหนด (3 คำสั่ง)
- การดีบัก & การวิเคราะห์ (4 คำสั่ง)
- การพึ่งพา & การกำหนดค่า (3 คำสั่ง)
- เอกสาร & การทำงานร่วมกัน (1 คำสั่ง)
- การเริ่มต้นใช้งาน & การตั้งค่า (1 คำสั่ง)
- เครื่องมือเฉพาะซับเอเจนต์ (5 คำสั่ง)

## ตัวอย่างการใช้งาน

### 🤖 ตัวอย่างเวิร์กโฟลว์

```bash
# Implement a complete feature
/workflows:feature-development Add user authentication with OAuth2

# Comprehensive code review
/workflows:full-review Review the authentication module

# Smart issue resolution
/workflows:smart-fix Fix performance degradation in API response times

# Modernize legacy system
/workflows:legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/workflows:full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/workflows:security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/workflows:data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/workflows:performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/workflows:incident-response High CPU usage causing service degradation in production
```

### 🔧 ตัวอย่างเครื่องมือ (คำสั่งสำหรับวัตถุประสงค์เดียว)

```bash
# Create a user management API
/tools:api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/tools:multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/tools:prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/tools:data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/tools:error-trace analyze high memory usage in production pods

# Secure container images
/tools:security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/tools:doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/tools:onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/tools:multi-agent-review Review authentication module

# Deep debugging
/tools:smart-debug Investigate memory leak in production workers

# Full-stack optimization
/tools:multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/tools:context-save Save current project state and architectural decisions

# Restore project context
/tools:context-restore Load context from last week's sprint
```

## คำสั่งขั้นสูง

### ความปลอดภัย & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

การสแกนความปลอดภัยแบบครอบคลุมพร้อมการแก้ไขอัตโนมัติ

- **การสแกนหลายเครื่องมือ**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **การแก้ไขอัตโนมัติ**: แก้ไขช่องโหว่ทั่วไปโดยอัตโนมัติ
- **การผสาน CI/CD**: ตั้งเกตความปลอดภัยสำหรับ GitHub Actions/GitLab CI
- **การสแกนคอนเทนเนอร์**: วิเคราะห์ช่องโหว่ของอิมเมจ
- **การตรวจจับความลับ**: ผสานรวม GitLeaks และ TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

กลยุทธ์การปรับแต่งคอนเทนเนอร์ขั้นสูง

- **การปรับแต่งอัจฉริยะ**: วิเคราะห์และแนะนำการปรับปรุง
- **การสร้างหลายขั้นตอน**: Dockerfile ที่ปรับแต่งเฉพาะเฟรมเวิร์ก
- **เครื่องมือสมัยใหม่**: BuildKit, Bun, UV สำหรับการสร้างที่รวดเร็วขึ้น
- **การเสริมความปลอดภัย**: อิมเมจแบบไม่มีดิสโทร, ใช้ผู้ใช้งานที่ไม่ใช่ root
- **การผสานคำสั่งข้ามกัน**: ทำงานร่วมกับผลลัพธ์ /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

การดีพลอย Kubernetes ระดับโปรดักชั่น

- **รูปแบบขั้นสูง**: มาตรฐานความปลอดภัย Pod, นโยบายเครือข่าย, OPA
- **พร้อมสำหรับ GitOps**: การตั้งค่า FluxCD และ ArgoCD
- **การสังเกตการณ์**: Prometheus ServiceMonitors, OpenTelemetry
- **การปรับขนาดอัตโนมัติ**: การตั้งค่า HPA, VPA และ cluster autoscaler
- **Service Mesh**: ผสานรวม Istio/Linkerd

### ส่วนหน้า & ข้อมูล

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

กลยุทธ์การมิเกรตฐานข้อมูลขั้นสูง

- **รองรับหลายฐานข้อมูล**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **ไร้เวลาหยุดทำงาน**: การปรับใช้งานแบบบลู-กรีน, การโยกย้ายแบบโรลลิ่ง
- **แหล่งข้อมูลเหตุการณ์**: การเชื่อมต่อ Kafka/Kinesis สำหรับ CDC
- **ข้ามแพลตฟอร์ม**: รองรับการจัดการข้อมูลหลายภาษา
- **การตรวจสอบ**: การตรวจสอบสุขภาพการโยกย้ายและการย้อนกลับ

## การผสมผสานเวิร์กโฟลว์และเครื่องมือ

พลังที่แท้จริงเกิดจากการผสมผสานเวิร์กโฟลว์และเครื่องมือเพื่อรอบการพัฒนาที่สมบูรณ์:

### ตัวอย่าง: การสร้างฟีเจอร์ใหม่

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/workflows:feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/tools:test-harness Add integration tests for WebSocket connections
/tools:security-scan Check for WebSocket vulnerabilities
/tools:docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/workflows:full-review Review the entire chat feature implementation
```

### ตัวอย่าง: การปรับปรุงโค้ดเก่าให้ทันสมัย

```bash
# 1. Start with the modernization workflow
/workflows:legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/tools:deps-upgrade Update all dependencies to latest versions
/tools:refactor-clean Remove deprecated patterns and dead code
/tools:test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/tools:docker-optimize Create multi-stage production build
/tools:k8s-manifest Deploy with zero-downtime strategy
```

## รูปแบบการประสานคำสั่ง

คำสั่งสามารถใช้งานแยกเดี่ยวหรือผสมผสานในรูปแบบที่ทรงพลัง:

### การดำเนินการแบบลำดับ
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### การวิเคราะห์แบบขนาน
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### การปรับปรุงแบบวนซ้ำ
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### การบูรณาการข้ามโดเมน
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## เมื่อไหร่ควรใช้ Workflow กับ Tools

### 🔀 Workflow & Subagent Tools
- **การแก้ไขปัญหา**: วิเคราะห์และแก้ไขปัญหาอย่างปรับตัวได้
- **มุมมองหลากหลาย**: ประสานงานกับ subagent ผู้เชี่ยวชาญแต่ละด้าน
- **งานที่ซับซ้อน**: กระบวนการหลายขั้นตอนที่ครอบคลุมหลายสาขา
- **วิธีแก้ไขที่ไม่ชัดเจน**: ให้ subagent กำหนดแนวทางการทำงานเอง

### 🛠️ Specialized Tools
- **การตั้งค่าโครงสร้างพื้นฐาน**: กำหนดสภาพแวดล้อมต่าง ๆ
- **สร้างโค้ด**: สร้างการนำไปใช้ที่เฉพาะเจาะจง
- **การวิเคราะห์**: สร้างรายงานโดยไม่แก้ไขปัญหา
- **งานเฉพาะด้าน**: ปฏิบัติการที่มีความเชี่ยวชาญสูง

**ตัวอย่าง:**
- "ติดตั้งระบบยืนยันตัวผู้ใช้" → `/workflows:feature-development`
- "แก้ปัญหาด้านประสิทธิภาพทั่วทั้ง stack" → `/workflows:smart-fix`
- "ปรับปรุงระบบ legacy monolith ให้ทันสมัย" → `/workflows:legacy-modernize`

### 🔧 ใช้ Tools เมื่อ:
- **ต้องการความเชี่ยวชาญเฉพาะทาง** - งานที่ชัดเจนและเน้นในด้านเดียว
- **ต้องการควบคุมอย่างแม่นยำ** - ต้องการกำหนดรายละเอียดการนำไปใช้โดยตรง
- **เป็นส่วนหนึ่งของ workflow แบบ manual** - รวมเข้ากับกระบวนการเดิมที่มีอยู่แล้ว
- **ต้องการความเชี่ยวชาญลึก** - ต้องการการนำไปใช้ในระดับผู้เชี่ยวชาญ
- **ต่อยอดจากงานเดิม** - เพิ่มประสิทธิภาพหรือปรับปรุงผลลัพธ์ก่อนหน้า

**ตัวอย่าง:**
- "สร้าง manifest ของ Kubernetes" → `/tools:k8s-manifest`
- "สแกนหาช่องโหว่ด้านความปลอดภัย" → `/tools:security-scan`
- "สร้างเอกสาร API อัตโนมัติ" → `/tools:doc-generate`

## รูปแบบคำสั่ง

Slash command คือไฟล์ markdown ธรรมดาที่:
- ชื่อไฟล์จะกลายเป็นชื่อคำสั่ง (เช่น `tools/api-scaffold.md` → `/tools:api-scaffold`)
- เนื้อหาในไฟล์คือ prompt/คำแนะนำที่จะถูกใช้งานเมื่อเรียกใช้
- ใช้ `$ARGUMENTS` เป็นตัวแทนสำหรับข้อมูลที่ผู้ใช้ป้อน

## แนวปฏิบัติที่ดีที่สุด

### การเลือกคำสั่ง
- **ให้ Claude Code แนะนำโดยอัตโนมัติ** - วิเคราะห์บริบทและเลือกคำสั่งที่เหมาะสมที่สุด
- **ใช้เวิร์กโฟลว์สำหรับงานที่ซับซ้อน** - ซับเอเจนต์ประสานการดำเนินการข้ามหลายโดเมน
- **ใช้เครื่องมือสำหรับงานเฉพาะจุด** - ใช้คำสั่งเฉพาะเพื่อปรับปรุงเป้าหมาย

### วิธีใช้งานอย่างมีประสิทธิภาพ
- **ให้ข้อมูลบริบทอย่างครบถ้วน** - ระบุเทคโนโลยีที่ใช้ ข้อจำกัด และข้อกำหนด
- **เชื่อมโยงคำสั่งอย่างมีชั้นเชิง** - เวิร์กโฟลว์ → เครื่องมือ → การปรับแต่ง
- **ต่อยอดจากผลลัพธ์ก่อนหน้า** - คำสั่งถูกออกแบบมาให้ทำงานร่วมกัน

## การมีส่วนร่วม

1. สร้างไฟล์ `.md` ใน `workflows/` หรือ `tools/`
2. ใช้ชื่อไฟล์ตัวพิมพ์เล็กและขีดกลาง
3. รวม `$ARGUMENTS` สำหรับข้อมูลที่ผู้ใช้ป้อน

## การแก้ไขปัญหา

**ไม่พบคำสั่ง**: 
- ตรวจสอบว่าไฟล์อยู่ใน `~/.claude/commands/tools/` หรือ `~/.claude/commands/workflows/`
- ใช้คำนำหน้าที่ถูกต้อง: `/tools:command-name` หรือ `/workflows:command-name`
- หรือปรับโครงสร้างไดเรกทอรีหากไม่ต้องการคำนำหน้า: `cp tools/*.md . && cp workflows/*.md .`

**เวิร์กโฟลว์ช้า**: เป็นปกติ - เพราะมีการประสานงานซับเอเจนต์หลายตัว

**ผลลัพธ์ทั่วไป**: เพิ่มข้อมูลบริบทเกี่ยวกับเทคโนโลยีที่ใช้ให้มากขึ้น

**ปัญหาการเชื่อมต่อ**: ตรวจสอบเส้นทางไฟล์และลำดับคำสั่ง

## เคล็ดลับการเพิ่มประสิทธิภาพ

**การเลือกคำสั่ง:**
- **เวิร์กโฟลว์**: ประสานงานซับเอเจนต์หลายตัวสำหรับฟีเจอร์ซับซ้อน
- **เครื่องมือ**: ปฏิบัติการเฉพาะจุดสำหรับงานเฉพาะ
- **การแก้ไขง่ายๆ**: ใช้เอเจนต์หลักเท่านั้น

**การปรับแต่ง:**
- เริ่มด้วยเครื่องมือสำหรับปัญหาที่ทราบอยู่แล้ว
- ให้ข้อกำหนดโดยละเอียดตั้งแต่ต้น
- สร้างต่อจากผลลัพธ์คำสั่งก่อนหน้า
- ให้เวิร์กโฟลว์เสร็จสิ้นก่อนแก้ไข

### การเพิ่มเวิร์กโฟลว์ใหม่:
- เน้นที่ตรรกะการจัดการและมอบหมายงานของซับเอเจนต์
- ระบุว่าจะใช้ซับเอเจนต์เฉพาะทางตัวใดและตามลำดับใด
- กำหนดรูปแบบการประสานงานระหว่างซับเอเจนต์

### การเพิ่มเครื่องมือใหม่:
- รวมการนำไปใช้ที่สมบูรณ์และพร้อมใช้งานจริง
- จัดโครงสร้างเนื้อหาด้วยส่วนที่ชัดเจนและผลลัพธ์ที่นำไปปฏิบัติได้
- รวมตัวอย่าง แนวทางที่ดีที่สุด และจุดเชื่อมต่อการบูรณาการ

## เรียนรู้เพิ่มเติม

- [เอกสารประกอบ Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [เอกสารประกอบ Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [เอกสารประกอบ Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) - ซับเอเจนต์เฉพาะทางที่ใช้กับคำสั่งเหล่านี้


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---