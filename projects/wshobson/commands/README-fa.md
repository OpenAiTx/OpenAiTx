
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

# دستورات اسلش کد کلود

دستورات اسلش آماده برای تولید [Claude Code](https://docs.anthropic.com/en/docs/claude-code) که با اتوماسیون هوشمند توسعه را تسریع می‌بخشند.

**۵۲ دستور** سازمان‌دهی شده به صورت:
- **🤖 جریان‌های کاری**: ارکستراسیون چند-زیرعامل برای وظایف پیچیده
- **🔧 ابزارها**: ابزارهای تک‌منظوره برای عملیات خاص

### 🤝 نیازمند کلود کد ساب‌ایجنت‌ها

این دستورات با [کلود کد ساب‌ایجنت‌ها](https://github.com/wshobson/agents) برای قابلیت‌های ارکستراسیون کار می‌کنند.

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

دستورات در پوشه‌های `tools/` و `workflows/` سازماندهی شده‌اند. آن‌ها را با پیشوند پوشه استفاده کنید:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**توجه:** اگر ترجیح می‌دهید دستورات را بدون پیشوندها استفاده کنید، می‌توانید دایرکتوری‌ها را صاف کنید:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code به طور خودکار بر اساس زمینه، دستورات مرتبط را پیشنهاد می‌دهد.

## 🤖 جریان‌های کاری

ارکستراسیون چند زیرعامل برای وظایف پیچیده:

### توسعه ویژگی
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - زیرعامل‌های بک‌اند، فرانت‌اند، تست و استقرار ویژگی‌های کامل را می‌سازند
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - چند زیرعامل مرور، تحلیل جامع کد را ارائه می‌دهند
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - مسائل را تحلیل و به زیرعامل‌های متخصص مناسب واگذار می‌کند

### فرآیندهای توسعه
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - پیاده‌سازی جریان‌های کاری مؤثر گیت با استراتژی‌های شاخه‌دهی و قالب‌های PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - افزایش عملکرد زیرعامل‌ها از طریق بهینه‌سازی پرامپت
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - مدرن‌سازی کدهای قدیمی با استفاده از زیرعامل‌های تخصصی
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - ایجاد پایپلاین‌های ML با زیرعامل‌های داده و مهندسی ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - ساخت اپ‌های چندسکویی با زیرعامل‌های هماهنگ
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - اتوماسیون جریان‌های کاری CI/CD، پایش و استقرار

### جریان‌های کاری زیرعامل محور
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - ویژگی‌های چندسکویی با زیرعامل‌های بک‌اند، فرانت‌اند و موبایل
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - پیاده‌سازی با اولویت امنیت و زیرعامل‌های تخصصی
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ویژگی‌های مبتنی بر ML با زیرعامل‌های علم داده
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - بهینه‌سازی کامل با زیرعامل‌های عملکرد
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - رفع رخدادهای تولید با زیرعامل‌های عملیات

## 🔧 ابزارها (دستورات تک‌منظوره)

### هوش مصنوعی و یادگیری ماشین
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - ساخت دستیارهای هوش مصنوعی و چت‌بات‌های آماده تولید
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - مرور تخصصی برای کدهای AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - ایجاد عامل‌های LangChain/LangGraph با الگوهای مدرن
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - ساخت پایپلاین‌های کامل ML با MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - بهینه‌سازی پرامپت‌های AI برای عملکرد و کیفیت

### معماری و کیفیت کد
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - تولید توضیحات دقیق برای کدهای پیچیده
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - مهاجرت کد بین زبان‌ها، فریم‌ورک‌ها یا نسخه‌ها
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - بازآرایی کد برای نگهداری‌پذیری و عملکرد

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - تحلیل و اولویت‌بندی بدهی فنی

### داده و پایگاه داده
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - طراحی معماری‌های مقیاس‌پذیر خط لوله داده
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - پیاده‌سازی سیستم‌های جامع اعتبارسنجی داده
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - استراتژی‌های پیشرفته مهاجرت پایگاه داده

### دواپس و زیرساخت
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - تولید پیکربندی‌ها و چک‌لیست‌های استقرار
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - استراتژی‌های پیشرفته بهینه‌سازی کانتینر
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - استقرار کوبرنتیز در سطح تولید
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - راه‌اندازی نظارت و مشاهده‌پذیری جامع
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - پیاده‌سازی اهداف سطح خدمات (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - خودکارسازی فرآیندهای توسعه و عملیاتی

### توسعه و تست
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - ایجاد API Mock واقعی برای توسعه و تست
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - تولید نقاط پایانی API آماده تولید با پشته پیاده‌سازی کامل
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - ایجاد مجموعه تست جامع با شناسایی فریم‌ورک

### امنیت و انطباق
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - تست و رفع اشکال جامع دسترسی‌پذیری
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - اطمینان از انطباق با مقررات (GDPR، HIPAA، SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - اسکن امنیتی جامع با اصلاح خودکار

### اشکال‌زدایی و تحلیل
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - استراتژی‌های پیشرفته اشکال‌زدایی و ردیابی
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - تحلیل عمیق الگوهای خطا و راهکارهای رفع آن‌ها
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - ردیابی و تشخیص خطاهای محیط تولید
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - ایجاد Issueهای ساختارمند در GitHub/GitLab

### وابستگی‌ها و پیکربندی
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - اعتبارسنجی و مدیریت پیکربندی برنامه
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - ممیزی وابستگی‌ها از نظر امنیت و مجوز
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - به‌روزرسانی ایمن وابستگی‌های پروژه

### مستندسازی و همکاری
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - تولید مستندات جامع
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - پیاده‌سازی فرآیندهای مؤثر Git
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - ارتقای Pull Requestها با بررسی کیفیت

### بهینه‌سازی هزینه
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - بهینه‌سازی هزینه‌های زیرساخت و فضای ابری

### راه‌اندازی و پذیرش اعضا
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - راه‌اندازی محیط توسعه برای اعضای جدید تیم

### ابزارهای زیرعامل
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - بازبینی کد از دیدگاه‌های مختلف با زیرعامل‌های تخصصی
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - اشکال‌زدایی عمیق با زیرعامل‌های اشکال‌زدا و عملکرد
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - بهینه‌سازی فول‌استک با چندین زیرعامل
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - ذخیره زمینه پروژه با زیرعامل مدیریت زمینه
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - بازیابی زمینه ذخیره‌شده برای تداوم کار

## ویژگی‌ها

- پیاده‌سازی‌های آماده تولید
- تشخیص خودکار فریم‌ورک
- رعایت بهترین استانداردهای امنیتی
- پایش و تست داخلی
- هماهنگی بی‌نقص فرمان‌ها با یکدیگر

## شمار فرمان‌ها

**مجموع: ۵۲ فرمان اسلش آماده تولید** که سازماندهی شده‌اند به صورت:

### 🤖 جریان‌های کاری (۱۴ فرمان)

- توسعه ویژگی و بازبینی (۳ فرمان)
- اتوماسیون فرآیند توسعه (۶ فرمان)
- جریان‌های کاری با هماهنگی زیرعامل‌ها (۵ فرمان)

### 🔧 ابزارها (۳۸ فرمان)

- هوش مصنوعی و یادگیری ماشین (۵ فرمان)
- معماری و کیفیت کد (۴ فرمان)
- داده و پایگاه داده (۳ فرمان)
- عملیات توسعه و زیرساخت (۶ فرمان)
- توسعه و تست (۳ فرمان)
- امنیت و تطابق (۳ فرمان)
- اشکال‌زدایی و تحلیل (۴ دستور)
- وابستگی‌ها و پیکربندی (۳ دستور)
- مستندسازی و همکاری (۱ دستور)
- راه‌اندازی و آماده‌سازی (۱ دستور)
- ابزارهای ویژه زیرعامل (۵ دستور)

## مثال‌های استفاده

### 🤖 مثال‌های جریان کاری

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

### 🔧 نمونه ابزارها (دستورات تک‌منظوره)

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

## دستورات پیشرفته

### امنیت و DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

اسکن امنیتی جامع با رفع خودکار مشکلات.

- **اسکن چندابزاری**: Bandit، Safety، Trivy، Semgrep، ESLint Security، Snyk
- **رفع خودکار**: آسیب‌پذیری‌های رایج به طور خودکار اصلاح می‌شوند
- **ادغام با CI/CD**: دروازه‌های امنیتی برای GitHub Actions/GitLab CI
- **اسکن کانتینر**: تحلیل آسیب‌پذیری تصاویر
- **شناسایی اسرار**: ادغام GitLeaks و TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

استراتژی‌های پیشرفته بهینه‌سازی کانتینر.

- **بهینه‌سازی هوشمند**: تحلیل و پیشنهاد بهبودها
- **ساخت‌های چندمرحله‌ای**: Dockerfileهای بهینه‌شده برای فریم‌ورک‌های خاص
- **ابزارهای مدرن**: BuildKit، Bun، UV برای ساخت‌های سریع‌تر
- **تقویت امنیت**: تصاویر Distroless، کاربران غیرریشه‌ای
- **ادغام بین دستورات**: هماهنگی با خروجی‌های /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

استقرار Kubernetes در سطح تولید.

- **الگوهای پیشرفته**: استانداردهای امنیتی Pod، سیاست‌های شبکه، OPA
- **آماده برای GitOps**: پیکربندی‌های FluxCD و ArgoCD
- **قابلیت مشاهده**: ServiceMonitorهای Prometheus، OpenTelemetry
- **مقیاس‌پذیری خودکار**: پیکربندی‌های HPA، VPA و autoscaler خوشه
- **مش سرویس**: ادغام Istio/Linkerd

### فرانت‌اند و داده

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

استراتژی‌های پیشرفته مهاجرت پایگاه داده.

- **چند پایگاه داده‌ای**: PostgreSQL، MySQL، MongoDB، DynamoDB
- **بدون توقف سرویس**: استقرار آبی-سبز، مهاجرت‌های تدریجی
- **منبع رویداد**: یکپارچه‌سازی Kafka/Kinesis برای CDC
- **چند سکویی**: مدیریت ماندگاری چندزبانه
- **پایش**: بررسی سلامت مهاجرت و بازگردانی

## ترکیب جریان کاری و ابزارها

قدرت واقعی از ترکیب جریان کاری و ابزارها برای چرخه‌های کامل توسعه حاصل می‌شود:

### مثال: ساخت یک ویژگی جدید

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

### مثال: مدرن‌سازی کدهای قدیمی

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

## الگوهای ارکستراسیون دستور

دستورات می‌توانند به صورت فردی یا در الگوهای قدرتمند ترکیبی استفاده شوند:

### اجرای متوالی
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### تحلیل موازی
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### پالایش تدریجی
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### ادغام بین دامنه‌ای
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## چه زمانی از Workflowها و چه زمانی از ابزارها استفاده کنیم

### 🔀 Workflowها و ابزارهای زیرعامل
- **حل مسئله**: تحلیل و رفع مشکلات به صورت تطبیقی
- **دیدگاه‌های متعدد**: هماهنگی زیرعامل‌های متخصص
- **وظایف پیچیده**: فرآیندهای چندمرحله‌ای در حوزه‌های مختلف
- **راه‌حل‌های نامشخص**: اجازه دهید زیرعامل‌ها رویکرد را تعیین کنند

### 🛠️ ابزارهای تخصصی
- **راه‌اندازی زیرساخت**: پیکربندی محیط‌ها
- **تولید کد**: ایجاد پیاده‌سازی‌های خاص
- **تحلیل**: تولید گزارش بدون رفع مشکل
- **وظایف حوزه‌ای**: عملیات‌های بسیار تخصصی

**نمونه‌ها:**
- "پیاده‌سازی سیستم احراز هویت کاربر" → `/workflows:feature-development`
- "رفع مشکلات عملکردی در کل پشته" → `/workflows:smart-fix`
- "مدرن‌سازی مونولیت قدیمی" → `/workflows:legacy-modernize`

### 🔧 از ابزارها استفاده کنید زمانی که:
- **نیاز به تخصص خاص** - وظیفه‌ای واضح و متمرکز در یک حوزه
- **کنترل دقیق مورد نیاز** - می‌خواهید جزئیات پیاده‌سازی را مشخص کنید
- **بخشی از جریان کاری دستی** - ادغام در فرآیندهای موجود
- **تخصص عمیق لازم است** - نیاز به پیاده‌سازی در سطح کارشناسی
- **ساخت بر پایه کار قبلی** - ارتقاء یا بهبود خروجی‌های قبلی

**نمونه‌ها:**
- "ایجاد manifestهای Kubernetes" → `/tools:k8s-manifest`
- "اسکن آسیب‌پذیری‌های امنیتی" → `/tools:security-scan`
- "تولید مستندات API" → `/tools:doc-generate`

## قالب دستور

دستورات اسلش فایل‌های markdown ساده‌ای هستند که:
- نام فایل تبدیل به نام دستور می‌شود (مثلاً `tools/api-scaffold.md` → `/tools:api-scaffold`)
- محتوای فایل همان دستورالعمل‌هایی است که هنگام فراخوانی اجرا می‌شوند
- از جای‌نگهدار `$ARGUMENTS` برای ورودی کاربر استفاده کنید

## بهترین رویه‌ها

### انتخاب دستور
- **اجازه دهید Claude Code به طور خودکار پیشنهاد دهد** - زمینه را تحلیل کرده و دستورات بهینه را انتخاب می‌کند
- **برای کارهای پیچیده از ورک‌فلوها استفاده کنید** - زیرعامل‌ها پیاده‌سازی‌های چنددامنه‌ای را هماهنگ می‌کنند
- **برای وظایف متمرکز از ابزارها استفاده کنید** - دستورات خاص را برای بهبودهای هدفمند اعمال کنید

### استفاده مؤثر
- **زمینه جامع ارائه دهید** - پشته فناوری، محدودیت‌ها و نیازها را درج کنید
- **دستورات را به صورت راهبردی زنجیره کنید** - ورک‌فلوها → ابزارها → اصلاحات
- **بر خروجی‌های قبلی بنا کنید** - دستورات برای همکاری طراحی شده‌اند

## مشارکت

1. فایل `.md` در `workflows/` یا `tools/` ایجاد کنید
2. نام‌ها را با حروف کوچک و خط فاصله انتخاب کنید
3. متغیر `$ARGUMENTS` را برای ورودی کاربر لحاظ کنید

## رفع اشکال

**دستور یافت نشد**: 
- بررسی کنید فایل‌ها در `~/.claude/commands/tools/` یا `~/.claude/commands/workflows/` باشند
- از پیشوند صحیح استفاده کنید: `/tools:command-name` یا `/workflows:command-name`
- یا اگر پیشوند نمی‌خواهید، دایرکتوری‌ها را صاف کنید: `cp tools/*.md . && cp workflows/*.md .`

**کندی ورک‌فلوها**: طبیعی است - آن‌ها چند زیرعامل را هماهنگ می‌کنند

**خروجی عمومی**: زمینه خاص‌تری درباره پشته فناوری خود اضافه کنید

**مشکلات یکپارچه‌سازی**: مسیر فایل‌ها و ترتیب دستورات را بررسی کنید

## نکات عملکردی

**انتخاب دستور:**
- **ورک‌فلوها**: هماهنگی چند زیرعامل برای ویژگی‌های پیچیده
- **ابزارها**: عملیات تک‌منظوره برای وظایف خاص
- **ویرایش‌های ساده**: با عامل اصلی ادامه دهید

**بهینه‌سازی:**
- با ابزارها برای مشکلات شناخته‌شده شروع کنید
- نیازمندی‌های دقیق را از ابتدا ارائه دهید
- بر اساس خروجی‌های دستورات قبلی کار کنید
- اجازه دهید جریان‌های کاری قبل از اعمال تغییرات کامل شوند

### افزودن یک جریان کاری جدید:
- تمرکز بر منطق ارکستراسیون و واگذاری زیرعامل‌ها
- مشخص کردن اینکه از کدام زیرعامل‌های تخصصی و به چه ترتیبی استفاده شود
- تعریف الگوهای هماهنگی بین زیرعامل‌ها

### افزودن یک ابزار جدید:
- شامل پیاده‌سازی‌های کامل و آماده تولید باشید
- محتوای ساختاریافته با بخش‌های واضح و خروجی‌های قابل اقدام ارائه دهید
- شامل مثال‌ها، بهترین روش‌ها و نقاط ادغام باشید

## اطلاعات بیشتر

- [مستندات Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [مستندات دستورات Slash](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [مستندات زیرعامل‌ها](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code در گیت‌هاب](https://github.com/anthropics/claude-code)
- [مجموعه زیرعامل‌های Claude Code](https://github.com/wshobson/agents) - زیرعامل‌های تخصصی مورد استفاده در این دستورات


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---