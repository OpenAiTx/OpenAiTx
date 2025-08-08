
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

# คำสั่ง Slash สำหรับ Claude Code

คำสั่ง Slash สำหรับ [Claude Code](https://docs.anthropic.com/en/docs/claude-code) ที่พร้อมใช้งานในระบบผลิตจริง เพื่อเร่งการพัฒนาด้วยระบบอัตโนมัติอัจฉริยะ

**52 คำสั่ง** แบ่งเป็น:
- **🤖 เวิร์กโฟลว์**: การประสานงานหลายซับเอเจนต์สำหรับงานที่ซับซ้อน
- **🔧 เครื่องมือ**: ยูทิลิตี้เฉพาะทางสำหรับการดำเนินการเฉพาะ

### 🤝 ต้องการ Claude Code Subagents

คำสั่งเหล่านี้ทำงานร่วมกับ [Claude Code Subagents](https://github.com/wshobson/agents) เพื่อความสามารถในการประสานงาน

## การติดตั้ง

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## คำสั่งที่มีให้ใช้งาน

- **🤖 เวิร์กโฟลว์** - ประสานงานซับเอเจนต์หลายตัวสำหรับงานที่ซับซ้อน
- **🔧 เครื่องมือ** - คำสั่งที่มีวัตถุประสงค์เฉพาะสำหรับการดำเนินการเฉพาะทาง

## วิธีการใช้งาน

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code จะแนะนำคำสั่งที่เกี่ยวข้องโดยอัตโนมัติตามบริบท

## 🤖 เวิร์กโฟลว์

การประสานงานหลายซับเอเจนต์สำหรับงานที่ซับซ้อน:

### การพัฒนาฟีเจอร์
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - ซับเอเจนต์สำหรับ backend, frontend, การทดสอบ และการ deploy สร้างฟีเจอร์ที่สมบูรณ์
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - ซับเอเจนต์หลายตัวร่วมกันรีวิวและวิเคราะห์โค้ดอย่างครอบคลุม
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - วิเคราะห์ปัญหาและมอบหมายให้ซับเอเจนต์ผู้เชี่ยวชาญที่เหมาะสม

### กระบวนการพัฒนา
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - นำเวิร์กโฟลว์ Git ที่มีประสิทธิภาพด้วยกลยุทธ์การแตก branch และเทมเพลต PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - เพิ่มประสิทธิภาพซับเอเจนต์ด้วยการปรับแต่ง prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - ปรับปรุงโค้ดเก่าให้ทันสมัยด้วยซับเอเจนต์เฉพาะทาง
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - สร้าง ML pipeline ด้วยซับเอเจนต์ด้าน data และ ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - สร้างแอปข้ามแพลตฟอร์มด้วยการทำงานร่วมของซับเอเจนต์
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - ทำงาน CI/CD, การมอนิเตอร์ และการ deploy อัตโนมัติ

### เวิร์กโฟลว์แบบซับเอเจนต์ประสานงาน
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - ฟีเจอร์ข้ามแพลตฟอร์มด้วยซับเอเจนต์ backend, frontend และ mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - การพัฒนาโดยเน้นความปลอดภัยด้วยซับเอเจนต์เฉพาะทาง
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ฟีเจอร์ขับเคลื่อนด้วย ML และซับเอเจนต์ด้าน data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - การปรับแต่งประสิทธิภาพแบบ end-to-end ด้วยซับเอเจนต์ด้าน performance
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - แก้ไขปัญหาใน production ด้วยซับเอเจนต์สาย ops

## 🔧 เครื่องมือ (คำสั่งเฉพาะทาง)

### AI & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - สร้าง AI assistant และ chatbot พร้อมใช้งานจริง
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - ตรวจสอบโค้ด AI/ML อย่างเชี่ยวชาญ
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - สร้างเอเจนต์ LangChain/LangGraph ด้วยแนวทางสมัยใหม่
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - สร้าง ML pipeline ครบวงจรด้วย MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - ปรับแต่ง prompt AI เพื่อประสิทธิภาพและคุณภาพ

### สถาปัตยกรรม & คุณภาพโค้ด
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - อธิบายโค้ดที่ซับซ้อนอย่างละเอียด
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - ย้ายโค้ดระหว่างภาษา เฟรมเวิร์ก หรือเวอร์ชัน
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - ปรับปรุงโค้ดให้บำรุงรักษาง่ายและมีประสิทธิภาพ
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - วิเคราะห์และจัดลำดับความสำคัญของ tech debt

### ข้อมูล & ฐานข้อมูล
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - ออกแบบสถาปัตยกรรม data pipeline ที่ขยายขนาดได้
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - สร้างระบบตรวจสอบข้อมูลที่ครอบคลุม
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - กลยุทธ์การย้ายฐานข้อมูลขั้นสูง

### DevOps & โครงสร้างพื้นฐาน
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - สร้างคอนฟิกและเช็กลิสต์สำหรับ deployment
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - กลยุทธ์ปรับแต่งคอนเทนเนอร์ขั้นสูง
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - ดีพลอย Kubernetes ระดับโปรดักชัน
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - ติดตั้งระบบมอนิเตอร์และ observability อย่างครบถ้วน
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - สร้าง Service Level Objective (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - ทำงาน dev และ ops อัตโนมัติ

### การพัฒนา & การทดสอบ
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - สร้าง mock API ที่สมจริงสำหรับ dev และ test
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - สร้าง endpoint API พร้อมใช้ทั้ง stack
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - สร้างชุดทดสอบที่ครอบคลุมและตรวจจับ framework อัตโนมัติ

### ความปลอดภัย & การปฏิบัติตาม
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - ทดสอบ accessibility อย่างละเอียดและแก้ไขปัญหา
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - ตรวจสอบการปฏิบัติตามกฎระเบียบ (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - สแกนความปลอดภัยพร้อมแก้ไขอัตโนมัติ

### การดีบัก & วิเคราะห์
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - กลยุทธ์ดีบักและ trace ขั้นสูง
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - วิเคราะห์รูปแบบข้อผิดพลาดเชิงลึกและแนะนำแนวทางแก้ไข
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - ติดตามและวิเคราะห์ข้อผิดพลาดใน production
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - สร้าง issue บน GitHub/GitLab อย่างมีโครงสร้าง

### ด้าน dependency & คอนฟิก
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - ตรวจสอบและจัดการคอนฟิกของแอปพลิเคชัน
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - ตรวจสอบ dependency ด้านความปลอดภัยและลิขสิทธิ์
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - อัปเกรด dependency ของโปรเจกต์อย่างปลอดภัย

### เอกสาร & การทำงานร่วมกัน
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - สร้างเอกสารประกอบโปรเจกต์อย่างละเอียด
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - นำเวิร์กโฟลว์ Git ที่มีประสิทธิภาพไปใช้
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - เพิ่มคุณภาพ pull request ด้วยการตรวจสอบอัตโนมัติ

### การเพิ่มประสิทธิภาพต้นทุน
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - ปรับแต่งค่าใช้จ่ายคลาวด์และโครงสร้างพื้นฐาน

### การเริ่มงาน & ตั้งค่าทีม
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - ตั้งค่าสภาพแวดล้อมสำหรับสมาชิกใหม่ในทีม

### เครื่องมือซับเอเจนต์
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - รีวิวโค้ดจากหลายมุมมองด้วยซับเอเจนต์เฉพาะทาง
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - ดีบักเชิงลึกด้วยซับเอเจนต์ debug และ performance
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - ปรับแต่งทั้ง stack ด้วยซับเอเจนต์หลายตัว
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - บันทึกบริบทโปรเจกต์ด้วย context-manager ซับเอเจนต์
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - กู้คืนบริบทที่บันทึกไว้เพื่อความต่อเนื่อง

## ฟีเจอร์

- พร้อมใช้งานใน production
- ตรวจจับ framework อัตโนมัติ
- แนวปฏิบัติด้านความปลอดภัยที่ดีที่สุด
- มีระบบ monitoring และ testing ในตัว

- คำสั่งทำงานร่วมกันอย่างไร้รอยต่อ

## จำนวนคำสั่ง

**รวม: 52 คำสั่งสแลชที่พร้อมใช้งานจริง** จัดกลุ่มเป็น:

### 🤖 เวิร์กโฟลว์ (14 คำสั่ง)

- การพัฒนาฟีเจอร์ & การรีวิว (3 คำสั่ง)
- ระบบอัตโนมัติในกระบวนการพัฒนา (6 คำสั่ง)
- เวิร์กโฟลว์แบบจัดการด้วยซับเอเจนต์ (5 คำสั่ง)

### 🔧 เครื่องมือ (38 คำสั่ง)

- AI & แมชชีนเลิร์นนิ่ง (5 คำสั่ง)
- สถาปัตยกรรม & คุณภาพโค้ด (4 คำสั่ง)
- ข้อมูล & ฐานข้อมูล (3 คำสั่ง)
- DevOps & โครงสร้างพื้นฐาน (6 คำสั่ง)
- การพัฒนา & การทดสอบ (3 คำสั่ง)
- ความปลอดภัย & การปฏิบัติตามกฎ (3 คำสั่ง)
- การดีบัก & การวิเคราะห์ (4 คำสั่ง)
- การจัดการไลบรารี & คอนฟิก (3 คำสั่ง)
- เอกสาร & การทำงานร่วมกัน (1 คำสั่ง)
- การเริ่มต้นใช้งาน & การตั้งค่า (1 คำสั่ง)
- เครื่องมือเฉพาะสำหรับซับเอเจนต์ (5 คำสั่ง)

## ตัวอย่างการใช้งาน

### 🤖 ตัวอย่างเวิร์กโฟลว์

```bash
# Implement a complete feature
/feature-development Add user authentication with OAuth2

# Comprehensive code review
/full-review Review the authentication module

# Smart issue resolution
/smart-fix Fix performance degradation in API response times

# Modernize legacy system
/legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/incident-response High CPU usage causing service degradation in production
```

### 🔧 ตัวอย่างเครื่องมือ (คำสั่งสำหรับวัตถุประสงค์เดียว)

```bash
# Create a user management API
/api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/error-trace analyze high memory usage in production pods

# Secure container images
/security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/multi-agent-review Review authentication module

# Deep debugging
/smart-debug Investigate memory leak in production workers

# Full-stack optimization
/multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/context-save Save current project state and architectural decisions

# Restore project context
/context-restore Load context from last week's sprint
```

## คำสั่งขั้นสูง

### ความปลอดภัย & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

การสแกนความปลอดภัยแบบครบวงจรพร้อมการแก้ไขอัตโนมัติ

- **การสแกนหลายเครื่องมือ**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **แก้ไขอัตโนมัติ**: ช่องโหว่ทั่วไปได้รับการแก้ไขอัตโนมัติ
- **ผสานกับ CI/CD**: วางเกตความปลอดภัยสำหรับ GitHub Actions/GitLab CI
- **สแกนคอนเทนเนอร์**: วิเคราะห์ช่องโหว่ของอิมเมจ
- **ตรวจจับข้อมูลลับ**: ผสานกับ GitLeaks และ TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

กลยุทธ์เพิ่มประสิทธิภาพคอนเทนเนอร์ขั้นสูง

- **ปรับแต่งอัจฉริยะ**: วิเคราะห์และแนะนำการปรับปรุง
- **Multi-Stage Builds**: Dockerfile ที่เหมาะสมเฉพาะแต่ละเฟรมเวิร์ก
- **เครื่องมือสมัยใหม่**: BuildKit, Bun, UV เพื่อการ build ที่เร็วขึ้น
- **เสริมความปลอดภัย**: อิมเมจ Distroless, ใช้ผู้ใช้ที่ไม่ใช่ root
- **ผสานข้ามคำสั่ง**: ใช้งานร่วมกับผลลัพธ์ /api-scaffold ได้

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

การดีพลอย Kubernetes ระดับโปรดักชัน

- **แพทเทิร์นขั้นสูง**: Pod Security Standards, Network Policies, OPA
- **พร้อมใช้กับ GitOps**: การตั้งค่า FluxCD และ ArgoCD
- **ติดตามและสังเกตการณ์**: Prometheus ServiceMonitors, OpenTelemetry
- **ปรับขนาดอัตโนมัติ**: การตั้งค่า HPA, VPA, และ cluster autoscaler
- **Service Mesh**: ผสานกับ Istio/Linkerd

### ส่วนหน้า & ข้อมูล

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

กลยุทธ์ migration ฐานข้อมูลขั้นสูง

- **หลายฐานข้อมูล**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Blue-green deployment, การ migration แบบ rolling
- **Event Sourcing**: ผสาน Kafka/Kinesis สำหรับ CDC
- **ข้ามแพลตฟอร์ม**: รองรับ polyglot persistence
- **มอนิเตอร์**: ตรวจสอบสุขภาพ migration และ rollback

## ผสานเวิร์กโฟลว์และเครื่องมือ

พลังที่แท้จริงคือการผสานเวิร์กโฟลว์และเครื่องมือเข้าด้วยกันสำหรับวัฏจักรการพัฒนาอย่างสมบูรณ์:

### ตัวอย่าง: การสร้างฟีเจอร์ใหม่

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/test-harness Add integration tests for WebSocket connections
/security-scan Check for WebSocket vulnerabilities
/docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/full-review Review the entire chat feature implementation
```

### ตัวอย่าง: การปรับปรุงโค้ดเก่าให้ทันสมัย

```bash
# 1. Start with the modernization workflow
/legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/deps-upgrade Update all dependencies to latest versions
/refactor-clean Remove deprecated patterns and dead code
/test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/docker-optimize Create multi-stage production build
/k8s-manifest Deploy with zero-downtime strategy
```

## รูปแบบการประสานคำสั่ง

คำสั่งสามารถใช้งานแยกเดี่ยวหรือผสมผสานในรูปแบบที่ทรงพลัง:

### การดำเนินการแบบลำดับ
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### การวิเคราะห์แบบขนาน
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### การปรับปรุงแบบวนซ้ำ
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### การบูรณาการข้ามโดเมน
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## เมื่อไรควรใช้ Workflow กับ Tools

### 🔀 Workflow & Subagent Tools
- **การแก้ปัญหา**: วิเคราะห์และแก้ไขปัญหาอย่างยืดหยุ่น
- **มุมมองหลากหลาย**: ประสานงานกับ subagent ผู้เชี่ยวชาญแต่ละด้าน
- **งานซับซ้อน**: กระบวนการหลายขั้นตอนข้ามหลายโดเมน
- **วิธีแก้ไขที่ไม่แน่นอน**: ให้ subagent เป็นผู้กำหนดแนวทาง

### 🛠️ เครื่องมือเฉพาะทาง
- **ตั้งค่าโครงสร้างพื้นฐาน**: กำหนดสภาพแวดล้อมการทำงาน
- **การสร้างโค้ด**: สร้างโค้ดหรือระบบเฉพาะทาง
- **วิเคราะห์**: สร้างรายงานโดยไม่แก้ไขปัญหา
- **งานเฉพาะทาง**: ปฏิบัติงานที่ต้องใช้ความชำนาญสูง

**ตัวอย่าง:**
- "สร้างระบบยืนยันตัวผู้ใช้" → `/feature-development`
- "แก้ไขปัญหาประสิทธิภาพในทุกเลเยอร์" → `/smart-fix`
- "ปรับปรุงระบบเดิมให้ทันสมัย" → `/legacy-modernize`

### 🔧 ใช้ Tools เมื่อ:
- **ต้องการผู้เชี่ยวชาญเฉพาะทาง** - งานชัดเจนเฉพาะด้านเดียว
- **ต้องการควบคุมรายละเอียด** - ระบุรายละเอียดการทำงานได้เอง
- **เป็นส่วนหนึ่งของกระบวนการด้วยตนเอง** - ผสานเข้ากับกระบวนการที่มีอยู่
- **ต้องการความเชี่ยวชาญสูง** - ต้องการการดำเนินการระดับผู้เชี่ยวชาญ
- **ต่อยอดจากงานเดิม** - พัฒนา/ปรับปรุงจากผลงานก่อนหน้า

**ตัวอย่าง:**
- "สร้าง manifest สำหรับ Kubernetes" → `/k8s-manifest`
- "สแกนหาช่องโหว่ด้านความปลอดภัย" → `/security-scan`
- "สร้างเอกสาร API" → `/doc-generate`

## รูปแบบคำสั่ง

Slash command เป็นไฟล์ markdown ง่ายๆ ที่:
- ชื่อไฟล์จะกลายเป็นชื่อคำสั่ง (เช่น `api-scaffold.md` → `/api-scaffold`)
- เนื้อหาในไฟล์คือคำสั่ง/คำแนะนำที่ทำงานเมื่อเรียกใช้
- ใช้ `$ARGUMENTS` เป็นตัวแทนข้อมูลผู้ใช้

## แนวปฏิบัติที่ดีที่สุด

### การเลือกคำสั่ง
- **ให้ Claude Code แนะนำอัตโนมัติ** - วิเคราะห์บริบทและเลือกคำสั่งที่เหมาะสมที่สุด
- **ใช้ workflow สำหรับงานซับซ้อน** - subagent ประสานงานข้ามหลายโดเมน
- **ใช้ tools สำหรับงานเฉพาะ** - เลือกคำสั่งเฉพาะเพื่อปรับปรุงเป้าหมาย

### การใช้งานอย่างมีประสิทธิภาพ
- **ให้ข้อมูลบริบทครบถ้วน** - ระบุเทคโนโลยี ข้อจำกัด และความต้องการ
- **เชื่อมโยงคำสั่งอย่างมีกลยุทธ์** - Workflow → Tools → ปรับแต่งเพิ่มเติม
- **ต่อยอดจากผลลัพธ์ก่อนหน้า** - คำสั่งถูกออกแบบให้ทำงานร่วมกัน

## การมีส่วนร่วม

1. สร้างไฟล์ `.md` ใน `workflows/` หรือ `tools/`
2. ใช้ชื่อไฟล์ตัวพิมพ์เล็กเชื่อมด้วยขีดกลาง
3. ใส่ `$ARGUMENTS` สำหรับรับข้อมูลผู้ใช้

## การแก้ไขปัญหา

**ไม่พบคำสั่ง**: ตรวจสอบว่าไฟล์อยู่ใน `~/.claude/commands/`

**Workflow ช้า**: ปกติ - เพราะต้องประสานงาน subagent หลายตัว

**ผลลัพธ์ทั่วไปเกินไป**: ให้บริบทเกี่ยวกับเทคโนโลยีที่ใช้ให้ละเอียดขึ้น

**ปัญหาการเชื่อมต่อ**: ตรวจสอบเส้นทางไฟล์และลำดับคำสั่ง

## เคล็ดลับเพิ่มประสิทธิภาพ

**การเลือกคำสั่ง:**
- **Workflow**: ประสาน subagent หลายตัวสำหรับงานซับซ้อน
- **Tools**: งานเฉพาะเจาะจงสำหรับภารกิจเดียว
- **แก้ไขง่าย**: ใช้งานกับ agent หลัก

**การปรับปรุง:**
- เริ่มจาก tools สำหรับปัญหาที่รู้แน่ชัด
- ให้รายละเอียดความต้องการตั้งแต่แรก
- ต่อยอดจากผลลัพธ์คำสั่งก่อนหน้า
- ให้ workflow ทำงานเสร็จก่อนค่อยปรับแก้

### การเพิ่ม Workflow ใหม่:
- เน้นการประสานและกระจายงาน subagent
- ระบุ subagent เฉพาะทางที่จะใช้และลำดับการทำงาน
- กำหนดรูปแบบการประสานงานระหว่าง subagent

### การเพิ่ม Tool ใหม่:
- ใส่ตัวอย่างที่พร้อมใช้งานจริงใน production
- จัดโครงสร้างเนื้อหาให้ชัดเจนและนำไปใช้ได้ทันที
- ใส่ตัวอย่าง แนวปฏิบัติที่ดี และจุดเชื่อมต่อการนำไปใช้

## เรียนรู้เพิ่มเติม

- [เอกสาร Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [เอกสาร Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [เอกสาร Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) - รวม subagent เฉพาะทางที่ใช้ในคำสั่งเหล่านี้



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---