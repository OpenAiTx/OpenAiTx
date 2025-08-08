
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

# دستورهای اسلش Claude Code

دستورهای اسلش آماده تولید برای [Claude Code](https://docs.anthropic.com/en/docs/claude-code) که توسعه را از طریق اتوماسیون هوشمند تسریع می‌کند.

**۵۲ دستور** سازماندهی شده به صورت:
- **🤖 جریان‌های کاری**: هماهنگی چند زیرعامل برای وظایف پیچیده
- **🔧 ابزارها**: ابزارهای تک منظوره برای عملیات خاص

### 🤝 نیازمند زیرعامل‌های Claude Code

این دستورها با [زیرعامل‌های Claude Code](https://github.com/wshobson/agents) برای قابلیت‌های هماهنگی کار می‌کنند.

## نصب

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## دستورات موجود

- **🤖 جریان‌های کاری** - هماهنگی چندین زیرعامل برای وظایف پیچیده
- **🔧 ابزارها** - دستورات تک‌منظوره برای عملیات خاص

## نحوه استفاده

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code به طور خودکار بر اساس زمینه، دستورات مرتبط را پیشنهاد می‌دهد.

## 🤖 جریان‌های کاری

هماهنگی چند زیرعامل برای وظایف پیچیده:

### توسعه ویژگی
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - زیرعامل‌های بک‌اند، فرانت‌اند، تست و استقرار ویژگی‌های کامل را می‌سازند
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - چندین زیرعامل بررسی، تحلیل جامع کد را ارائه می‌دهند
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - مسائل را تحلیل و به زیرعامل متخصص مناسب واگذار می‌کند

### فرآیندهای توسعه
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - پیاده‌سازی جریان‌های کاری مؤثر گیت با استراتژی شاخه‌بندی و قالب PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - بهبود عملکرد زیرعامل‌ها از طریق بهینه‌سازی پرامپت
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - مدرن‌سازی کدهای قدیمی با استفاده از زیرعامل‌های تخصصی
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - ساخت پایپ‌لاین‌های ML با زیرعامل‌های مهندسی داده و یادگیری ماشین
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - ساخت اپلیکیشن‌های چندسکویی با هماهنگی زیرعامل‌ها
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - خودکارسازی CI/CD، مانیتورینگ و جریان‌های استقرار

### جریان‌های کاری هماهنگ با زیرعامل
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - ویژگی‌های چندسکویی با زیرعامل‌های بک‌اند، فرانت‌اند و موبایل
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - پیاده‌سازی با رویکرد امنیتی و زیرعامل‌های تخصصی
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ویژگی‌های مبتنی بر ML با زیرعامل‌های علم داده
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - بهینه‌سازی سرتاسری با زیرعامل‌های عملکرد
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - رفع رخدادهای تولید با زیرعامل‌های عملیات

## 🔧 ابزارها (دستورات تک‌منظوره)

### هوش مصنوعی و یادگیری ماشین
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - ساخت دستیار هوشمند و چت‌بات آماده تولید
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - بررسی تخصصی برای کدهای AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - ساخت عوامل LangChain/LangGraph با الگوهای مدرن
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - ساخت پایپ‌لاین ML سرتاسری با MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - بهینه‌سازی پرامپت‌های AI برای عملکرد و کیفیت

### معماری و کیفیت کد
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - تولید توضیحات دقیق برای کد پیچیده
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - مهاجرت کد بین زبان‌ها، فریم‌ورک‌ها یا نسخه‌ها
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - بازآرایی کد برای نگهداری‌پذیری و عملکرد بهتر
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - تحلیل و اولویت‌بندی بدهی فنی

### داده و پایگاه داده
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - طراحی معماری پایپ‌لاین داده مقیاس‌پذیر
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - پیاده‌سازی سیستم‌های جامع اعتبارسنجی داده
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - استراتژی‌های پیشرفته مهاجرت پایگاه داده

### DevOps و زیرساخت
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - تولید پیکربندی و چک‌لیست استقرار
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - استراتژی‌های پیشرفته بهینه‌سازی کانتینر
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - استقرار Kubernetes در سطح تولید
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - راه‌اندازی مانیتورینگ و مشاهده‌پذیری جامع
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - پیاده‌سازی اهداف سطح سرویس (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - خودکارسازی جریان‌های توسعه و عملیات

### توسعه و تست
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - ایجاد ماک API واقعی برای توسعه و تست
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - تولید اندپوینت‌های API آماده تولید با پیاده‌سازی کامل
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - ساخت مجموعه تست جامع با شناسایی فریم‌ورک

### امنیت و انطباق
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - تست جامع دسترس‌پذیری و رفع مشکلات
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - اطمینان از تطابق با مقررات (GDPR، HIPAA، SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - اسکن امنیتی جامع با رفع خودکار

### اشکال‌زدایی و تحلیل
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - استراتژی‌های پیشرفته اشکال‌زدایی و ردیابی
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - تحلیل عمیق الگوهای خطا و راهکارها
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - ردیابی و تشخیص خطاهای تولید
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - ایجاد issue ساختاریافته برای GitHub/GitLab

### وابستگی و پیکربندی
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - اعتبارسنجی و مدیریت پیکربندی برنامه
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - بررسی وابستگی‌ها از نظر امنیت و مجوز
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - ارتقاء ایمن وابستگی‌های پروژه

### مستندسازی و همکاری
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - تولید مستندات جامع
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - پیاده‌سازی جریان‌های مؤثر گیت
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - بهبود Pull Request با بررسی کیفیت

### بهینه‌سازی هزینه
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - بهینه‌سازی هزینه‌های زیرساخت و ابر

### راه‌اندازی و پذیرش اعضا
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - راه‌اندازی محیط توسعه برای اعضای جدید تیم

### ابزار زیرعامل
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - بازبینی کد با دیدگاه‌های مختلف و زیرعامل‌های تخصصی
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - اشکال‌زدایی عمیق با زیرعامل اشکال‌زدا و عملکرد
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - بهینه‌سازی فول‌استک با چندین زیرعامل
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - ذخیره زمینه پروژه با زیرعامل مدیریت زمینه
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - بازیابی زمینه ذخیره شده برای تداوم

## ویژگی‌ها

- پیاده‌سازی‌های آماده تولید
- شناسایی خودکار فریم‌ورک
- بهترین شیوه‌های امنیتی
- مانیتورینگ و تست داخلی

- دستورات به‌صورت یکپارچه با هم کار می‌کنند

## تعداد دستورات

**مجموع: ۵۲ دستور اسلش آماده تولید** سازمان‌دهی شده در:

### 🤖 جریان‌های کاری (۱۴ دستور)

- توسعه ویژگی و بازبینی (۳ دستور)
- اتوماسیون فرآیند توسعه (۶ دستور)
- جریان‌های کاری ارکستره شده توسط زیرعامل (۵ دستور)

### 🔧 ابزارها (۳۸ دستور)

- هوش مصنوعی و یادگیری ماشین (۵ دستور)
- معماری و کیفیت کد (۴ دستور)
- داده و پایگاه داده (۳ دستور)
- DevOps و زیرساخت (۶ دستور)
- توسعه و تست (۳ دستور)
- امنیت و انطباق (۳ دستور)
- اشکال‌زدایی و تحلیل (۴ دستور)
- وابستگی‌ها و پیکربندی (۳ دستور)
- مستندسازی و همکاری (۱ دستور)
- راه‌اندازی و آماده‌سازی (۱ دستور)
- ابزارهای ویژه زیرعامل (۵ دستور)

## نمونه‌های استفاده

### 🤖 نمونه‌های جریان کاری

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

### 🔧 نمونه ابزارها (دستورات تک‌منظوره)

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
## دستورات پیشرفته

### امنیت و توسعه عملیات (DevOps)

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

اسکن امنیتی جامع با اصلاح خودکار مشکلات.

- **اسکن چند ابزاری**: Bandit، Safety، Trivy، Semgrep، ESLint Security، Snyk
- **رفع خودکار**: آسیب‌پذیری‌های رایج به طور خودکار اصلاح می‌شوند
- **یکپارچه‌سازی با CI/CD**: گیت‌های امنیتی برای GitHub Actions و GitLab CI
- **اسکن کانتینر**: تحلیل آسیب‌پذیری تصاویر
- **شناسایی اسرار**: یکپارچه‌سازی GitLeaks و TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

استراتژی‌های پیشرفته بهینه‌سازی کانتینر.

- **بهینه‌سازی هوشمند**: تحلیل و ارائه پیشنهادات بهبود
- **ساخت چندمرحله‌ای**: Dockerfileهای بهینه‌شده ویژه فریم‌ورک‌ها
- **ابزارهای مدرن**: BuildKit، Bun، UV برای ساخت سریع‌تر
- **سخت‌سازی امنیتی**: تصاویر Distroless، کاربران غیر ریشه‌ای
- **یکپارچه با دستورات دیگر**: کار با خروجی‌های /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

استقرار Kubernetes در سطح تولید.

- **الگوهای پیشرفته**: استانداردهای امنیتی Pod، سیاست‌های شبکه، OPA
- **آماده GitOps**: پیکربندی FluxCD و ArgoCD
- **قابلیت مشاهده**: Prometheus ServiceMonitors، OpenTelemetry
- **مقیاس‌پذیری خودکار**: پیکربندی HPA، VPA و مقیاس‌ساز خوشه
- **مش سرویس**: یکپارچه‌سازی Istio/Linkerd

### فرانت‌اند و داده

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

استراتژی‌های پیشرفته مهاجرت پایگاه داده.

- **چند پایگاه داده‌ای**: PostgreSQL، MySQL، MongoDB، DynamoDB
- **بدون توقف**: استقرار blue-green، مهاجرت غلتان
- **منبع رویداد**: یکپارچه‌سازی Kafka/Kinesis برای CDC
- **چندسکویی**: مدیریت ماندگاری چندزبانه
- **پایش**: بررسی سلامت مهاجرت و بازگشت به عقب

## ترکیب گردش کارها و ابزارها

قدرت واقعی از ترکیب گردش کارها و ابزارها برای چرخه توسعه کامل حاصل می‌شود:

### مثال: ساخت یک ویژگی جدید


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

### مثال: مدرن‌سازی کدهای قدیمی

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

## الگوهای ارکستراسیون دستور

دستورات می‌توانند به صورت فردی یا در الگوهای قدرتمند ترکیبی استفاده شوند:

### اجرای متوالی
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### تحلیل موازی
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### پالایش تدریجی
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### ادغام بین دامنه‌ای
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## چه زمانی از Workflowها و چه زمانی از ابزارها استفاده کنیم

### 🔀 Workflowها و ابزارهای Subagent
- **حل مسئله**: تحلیل و رفع مشکلات به صورت تطبیقی
- **دیدگاه‌های متعدد**: هماهنگی بین Subagentهای متخصص
- **وظایف پیچیده**: فرآیندهای چندمرحله‌ای در حوزه‌های مختلف
- **راه‌حل‌های نامشخص**: اجازه دهید Subagentها رویکرد را تعیین کنند

### 🛠️ ابزارهای تخصصی
- **راه‌اندازی زیرساخت**: پیکربندی محیط‌ها
- **تولید کد**: ایجاد پیاده‌سازی‌های خاص
- **تحلیل**: تولید گزارش بدون رفع مشکلات
- **وظایف دامنه‌ای**: عملیات بسیار تخصصی

**مثال‌ها:**
- "سیستم احراز هویت کاربر را پیاده‌سازی کن" → `/feature-development`
- "رفع مشکلات عملکردی در سراسر استک" → `/smart-fix`
- "مدرن‌سازی مونولیت قدیمی" → `/legacy-modernize`

### 🔧 ابزارها را زمانی استفاده کنید که:
- **نیاز به تخصص خاص** - وظیفه‌ای واضح و متمرکز در یک حوزه
- **کنترل دقیق مورد نیاز است** - می‌خواهید جزئیات پیاده‌سازی را تعیین کنید
- **بخشی از جریان کاری دستی** - ادغام با فرآیندهای موجود
- **نیاز به تخصص عمیق** - پیاده‌سازی در سطح متخصص
- **ساخت بر پایه کار قبلی** - بهبود یا اصلاح خروجی‌های قبلی

**مثال‌ها:**
- "مانیفست‌های Kubernetes بساز" → `/k8s-manifest`
- "اسکن آسیب‌پذیری‌های امنیتی" → `/security-scan`
- "تولید مستندات API" → `/doc-generate`

## قالب دستورات

دستورات اسلش فایل‌های ساده مارک‌داون هستند که:
- نام فایل، نام دستور می‌شود (مثلاً `api-scaffold.md` → `/api-scaffold`)
- محتوای فایل همان دستورالعمل/پرومپتی است که اجرا می‌شود
- از جایگزین `$ARGUMENTS` برای ورودی کاربر استفاده کنید

## بهترین شیوه‌ها

### انتخاب دستور
- **اجازه دهید Claude Code به طور خودکار پیشنهاد دهد** - زمینه را تحلیل و بهترین دستور را انتخاب می‌کند
- **استفاده از Workflowها برای وظایف پیچیده** - هماهنگی Subagentها برای پیاده‌سازی چنددامنه‌ای
- **استفاده از ابزارها برای وظایف متمرکز** - اعمال دستورات خاص برای بهبود هدفمند

### استفاده مؤثر
- **ارائه زمینه جامع** - شامل استک فنی، محدودیت‌ها و نیازمندی‌ها باشد
- **زنجیره‌سازی دستورات به صورت راهبردی** - Workflowها → ابزارها → اصلاحات
- **ساخت بر پایه خروجی‌های قبلی** - دستورات برای همکاری طراحی شده‌اند

## مشارکت

1. ایجاد فایل `.md` در پوشه‌ی `workflows/` یا `tools/`
2. استفاده از نام‌های کوچک و با خط فاصله
3. قراردادن `$ARGUMENTS` برای ورودی کاربر

## رفع اشکال

**دستور پیدا نشد**: بررسی کنید که فایل‌ها در مسیر `~/.claude/commands/` باشند

**Workflowها کند هستند**: طبیعی است - هماهنگی چند Subagent را انجام می‌دهند

**خروجی عمومی**: زمینه خاص‌تری از استک فنی خود ارائه دهید

**مشکلات ادغام**: مسیر فایل‌ها و ترتیب دستورات را بررسی کنید

## نکات عملکردی

**انتخاب دستور:**
- **Workflowها**: هماهنگی چند Subagent برای ویژگی‌های پیچیده
- **ابزارها**: عملیات تک‌منظوره برای وظایف خاص
- **ویرایش‌های ساده**: با عامل اصلی ادامه دهید

**بهینه‌سازی:**
- با ابزارها برای مشکلات شناخته‌شده شروع کنید
- نیازمندی‌های دقیق را از ابتدا ارائه دهید
- بر خروجی دستورات قبلی بنا کنید
- اجازه دهید Workflowها پیش از اصلاح کامل شوند

### افزودن Workflow جدید:
- تمرکز بر منطق هماهنگی و واگذاری بین Subagentها
- تعیین کنید کدام Subagent تخصصی، به چه ترتیب استفاده شوند
- الگوهای هماهنگی بین Subagentها را تعریف کنید

### افزودن ابزار جدید:
- پیاده‌سازی کامل و آماده تولید ارائه دهید
- ساختاردهی محتوا با بخش‌های واضح و خروجی‌های قابل اقدام
- شامل مثال‌ها، بهترین شیوه‌ها و نقاط ادغام باشد

## اطلاعات بیشتر

- [مستندات Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [مستندات دستورات اسلش](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [مستندات Subagentها](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [گیت‌هاب Claude Code](https://github.com/anthropics/claude-code)
- [مجموعه Subagentهای Claude Code](https://github.com/wshobson/agents) - Subagentهای تخصصی مورد استفاده این دستورات


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---