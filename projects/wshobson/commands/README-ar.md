<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# أوامر سلاش كلود كود

أوامر سلاش جاهزة للإنتاج لـ [Claude Code](https://docs.anthropic.com/en/docs/claude-code) تسرّع التطوير من خلال الأتمتة الذكية.

**52 أمرًا** منظمة كما يلي:
- **🤖 سير العمل**: تنسيق متعدد للوكلاء الفرعيين للمهام المعقدة
- **🔧 الأدوات**: أدوات أحادية الغرض لعمليات محددة

### 🤝 يتطلب وكلاء كلود كود الفرعيين

تعمل هذه الأوامر مع [وكلاء كلود كود الفرعيين](https://github.com/wshobson/agents) لإمكانيات التنسيق.

## التثبيت


```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## الأوامر المتاحة

- **🤖 سير العمل** - تنسيق عدة وكلاء فرعيين لمهام معقدة
- **🔧 الأدوات** - أوامر ذات غرض واحد لعمليات محددة

## كيفية الاستخدام

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
يقوم Claude Code تلقائيًا باقتراح الأوامر ذات الصلة بناءً على السياق.

## 🤖 سير العمل

تنسيق متعدد للوكلاء الفرعيين للمهام المعقدة:

### تطوير الميزات
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - وكلاء فرعيون للواجهة الخلفية والواجهة الأمامية والاختبار والنشر لبناء ميزات كاملة
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - عدة وكلاء فرعيين للمراجعة يقدمون تحليلًا شاملاً للكود
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - يحلل المشاكل ويوزع المهام على الوكلاء المتخصصين المناسبين

### عمليات التطوير
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - تنفيذ سير عمل Git فعال مع استراتيجيات التفرع وقوالب طلبات الدمج
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - تحسين أداء الوكلاء الفرعيين من خلال تحسين التعليمات
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - تحديث قواعد الكود القديمة باستخدام وكلاء متخصصين
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - إنشاء خطوط ML باستخدام وكلاء هندسة البيانات والذكاء الاصطناعي
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - بناء تطبيقات متعددة المنصات مع تنسيق الوكلاء الفرعيين
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - أتمتة سير عمل CI/CD والمراقبة والنشر

### سير العمل المنسقة بواسطة الوكلاء الفرعيين
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - ميزات متعددة المنصات مع وكلاء فرعيين للواجهة الخلفية والأمامية والجوال
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - تنفيذ يركز على الأمان مع وكلاء متخصصين
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ميزات مدعومة بالتعلم الآلي مع وكلاء علوم البيانات
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - تحسين شامل للأداء مع وكلاء الأداء
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - حل الحوادث الإنتاجية مع وكلاء العمليات

## 🔧 الأدوات (أوامر ذات غرض واحد)

### الذكاء الاصطناعي وتعلم الآلة
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - بناء مساعدين ودردشات ذكاء اصطناعي جاهزة للإنتاج
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - مراجعة متخصصة لقواعد كود الذكاء الاصطناعي/تعلم الآلة
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - إنشاء وكلاء LangChain/LangGraph بأنماط حديثة
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - إنشاء خطوط ML متكاملة مع عمليات MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - تحسين التعليمات للذكاء الاصطناعي من حيث الأداء والجودة

### الهندسة المعمارية وجودة الكود
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - توليد شرح تفصيلي للكود المعقد
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - ترحيل الكود بين اللغات أو الأطر أو الإصدارات
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - إعادة هيكلة الكود لتحسين القابلية للصيانة والأداء
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - تحليل وأولوية الدين التقني

### البيانات وقواعد البيانات
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - تصميم بنى خطوط بيانات قابلة للتوسع
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - تنفيذ أنظمة تحقق من البيانات شاملة
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - استراتيجيات متقدمة لترحيل قواعد البيانات

### العمليات والبنية التحتية
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - توليد تكوينات وقوائم تدقيق للنشر
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - استراتيجيات متقدمة لتحسين الحاويات
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - نشر Kubernetes بمستوى إنتاجي
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - إعداد مراقبة ورصد شاملين
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - تنفيذ أهداف مستوى الخدمة (SLOs)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - أتمتة سير العمل التطويري والتشغيلي

### التطوير والاختبار
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - إنشاء نماذج API واقعية للتطوير والاختبار
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - توليد نقاط نهاية API جاهزة للإنتاج بكامل المكدس التطبيقي
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - إنشاء مجموعات اختبار شاملة مع كشف الأطر

### الأمان والامتثال
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - اختبار وإصلاح شامل لإمكانية الوصول
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - ضمان الامتثال التنظيمي (GDPR، HIPAA، SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - فحص أمني شامل مع تصحيح تلقائي

### التصحيح والتحليل
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - استراتيجيات متقدمة لتصحيح وتتبع الأخطاء
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - تحليل عميق لأنماط الأخطاء واستراتيجيات الحل
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - تتبع وتشخيص أخطاء الإنتاج
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - إنشاء مسائل GitHub/GitLab منظمة جيدًا

### التبعيات والتكوين
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - التحقق من صحة وإدارة تكوين التطبيق
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - تدقيق التبعيات للأمان والتراخيص
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - ترقية تبعيات المشروع بأمان

### التوثيق والتعاون
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - توليد توثيق شامل
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - تنفيذ سير عمل Git فعال
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - تعزيز طلبات الدمج بفحوصات الجودة

### تحسين التكلفة
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - تحسين تكاليف السحابة والبنية التحتية

### الإعداد والانضمام
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - إعداد بيئات التطوير للأعضاء الجدد في الفريق

### أدوات الوكيل الفرعي
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - مراجعة كود من عدة وجهات نظر مع وكلاء متخصصين
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - تصحيح عميق مع وكلاء التصحيح والأداء
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - تحسين كامل المكدس مع عدة وكلاء فرعيين
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - حفظ سياق المشروع باستخدام وكيل إدارة السياق
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - استعادة السياق المحفوظ لاستمرارية العمل

## الميزات

- تطبيقات جاهزة للإنتاج
- اكتشاف تلقائي للأطر
- أفضل ممارسات الأمان
- مراقبة واختبار مدمجان

- تعمل الأوامر معًا بسلاسة

## عدد الأوامر

**الإجمالي: 52 أمر سلاش جاهز للإنتاج** مصنفة إلى:

### 🤖 سير العمل (14 أمرًا)

- تطوير الميزات والمراجعة (3 أوامر) 
- أتمتة عمليات التطوير (6 أوامر)
- سير عمل منظم بواسطة الوكلاء الفرعيين (5 أوامر)

### 🔧 الأدوات (38 أمرًا)

- الذكاء الاصطناعي وتعلم الآلة (5 أوامر)
- الهندسة وجودة الكود (4 أوامر)
- البيانات وقواعد البيانات (3 أوامر)
- العمليات البرمجية والبنية التحتية (6 أوامر)
- التطوير والاختبار (3 أوامر)
- الأمان والامتثال (3 أوامر)
- تصحيح الأخطاء والتحليل (4 أوامر)
- الاعتمادات والتكوين (3 أوامر)
- التوثيق والتعاون (أمر واحد)
- الإعداد والتجهيز (أمر واحد)
- أدوات خاصة بالوكلاء الفرعيين (5 أوامر)

## أمثلة الاستخدام

### 🤖 أمثلة سير العمل

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

### 🔧 أمثلة على الأدوات (أوامر ذات غرض واحد)

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
## الأوامر المحسنة

### الأمان و DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

فحص أمني شامل مع إصلاح تلقائي.

- **فحص متعدد الأدوات**: Bandit، Safety، Trivy، Semgrep، ESLint Security، Snyk
- **إصلاحات تلقائية**: معالجة تلقائية للثغرات الشائعة
- **تكامل مع CI/CD**: بوابات أمان لـ GitHub Actions/GitLab CI
- **فحص الحاويات**: تحليل ثغرات الصور
- **كشف الأسرار**: تكامل مع GitLeaks و TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

استراتيجيات متقدمة لتحسين الحاويات.

- **تحسين ذكي**: يحلل ويقترح التحسينات
- **بناء متعدد المراحل**: ملفات Docker محسنة لإطارات عمل محددة
- **أدوات حديثة**: BuildKit، Bun، UV لبناء أسرع
- **تعزيز الأمان**: صور Distroless، مستخدمون غير الجذر
- **تكامل مع أوامر أخرى**: يعمل مع مخرجات /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

نشر Kubernetes بمستوى إنتاجي.

- **أنماط متقدمة**: معايير أمان البود، سياسات الشبكة، OPA
- **جاهزية GitOps**: إعدادات FluxCD و ArgoCD
- **قابلية المراقبة**: Prometheus ServiceMonitors، OpenTelemetry
- **التوسع التلقائي**: إعدادات HPA، VPA، و cluster autoscaler
- **خدمة Mesh**: تكامل Istio/Linkerd

### الواجهة الأمامية والبيانات

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

استراتيجيات متقدمة لترحيل قواعد البيانات.

- **دعم عدة قواعد بيانات**: PostgreSQL، MySQL، MongoDB، DynamoDB
- **بدون توقف**: نشر أزرق-أخضر، ترحيل متدرج
- **مصدر الحدث**: تكامل Kafka/Kinesis لـ CDC
- **عبر المنصات**: معالجة تعدد أنواع قواعد البيانات
- **المراقبة**: فحوصات صحة الترحيل والتراجع

## دمج تدفقات العمل والأدوات

تتمثل القوة الحقيقية في دمج تدفقات العمل والأدوات لدورات تطوير شاملة:

### مثال: بناء ميزة جديدة


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

### مثال: تحديث الشيفرة القديمة

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

## أنماط تنسيق الأوامر

يمكن استخدام الأوامر بشكل فردي أو تجميعها في أنماط قوية:

### التنفيذ التسلسلي
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### التحليل المتوازي
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### التحسين التكراري
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### التكامل عبر المجالات
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## متى تستخدم سير العمل مقابل الأدوات

### 🔀 سير العمل وأدوات الوكلاء الفرعيين
- **حل المشكلات**: تحليل وإصلاح القضايا بشكل تكيفي
- **وجهات نظر متعددة**: تنسيق وكلاء فرعيين متخصصين
- **مهام معقدة**: عمليات متعددة الخطوات عبر المجالات
- **حلول غير معروفة**: دع الوكلاء الفرعيين يحددون النهج

### 🛠️ أدوات متخصصة
- **إعداد البنية التحتية**: تهيئة البيئات
- **توليد الشيفرة**: إنشاء تطبيقات محددة
- **التحليل**: إنشاء تقارير بدون إصلاحات
- **مهام المجال**: عمليات متخصصة للغاية

**أمثلة:**
- "تنفيذ نظام مصادقة المستخدمين" → `/feature-development`
- "إصلاح مشاكل الأداء عبر المكدس" → `/smart-fix`
- "تحديث النظام الأحادي القديم" → `/legacy-modernize`

### 🔧 استخدم الأدوات عندما:
- **الحاجة لخبرة محددة** - مهمة واضحة ومركزة في مجال واحد
- **الرغبة في التحكم الدقيق** - ترغب في توجيه تفاصيل التنفيذ بالتحديد
- **جزء من سير عمل يدوي** - دمج في العمليات الحالية
- **تخصص عميق مطلوب** - تحتاج لتنفيذ على مستوى الخبراء
- **البناء على عمل قائم** - تحسين أو صقل المخرجات السابقة

**أمثلة:**
- "إنشاء ملفات Kubernetes" → `/k8s-manifest`
- "مسح الثغرات الأمنية" → `/security-scan`
- "توليد وثائق API" → `/doc-generate`

## صيغة الأوامر

أوامر السلاش هي ملفات ماركداون بسيطة حيث:
- اسم الملف يصبح اسم الأمر (مثلاً، `api-scaffold.md` → `/api-scaffold`)
- محتوى الملف هو التعليمات/المطالبة التي تُنفذ عند الاستدعاء
- استخدم متغير `$ARGUMENTS` كعنصر نائب لإدخال المستخدم

## أفضل الممارسات

### اختيار الأوامر
- **دع Claude Code يقترح تلقائيًا** - يحلل السياق ويختار الأوامر المثلى
- **استخدم سير العمل للمهام المعقدة** - الوكلاء الفرعيون ينسقون تنفيذات متعددة المجالات
- **استخدم الأدوات للمهام المركزة** - تطبيق أوامر محددة لتحسينات مستهدفة

### الاستخدام الفعّال
- **قدّم سياقًا شاملاً** - أدرج التقنيات، والقيود، والمتطلبات
- **سلسل الأوامر بشكل استراتيجي** - سير العمل → أدوات → تحسينات
- **البناء على المخرجات السابقة** - صُممت الأوامر للعمل سوياً

## المساهمة

1. أنشئ ملف `.md` في `workflows/` أو `tools/`
2. استخدم أسماء بحروف صغيرة مع واصلات
3. أدرج `$ARGUMENTS` لإدخال المستخدم

## استكشاف الأخطاء وإصلاحها

**لم يتم العثور على الأمر**: تحقق أن الملفات موجودة في `~/.claude/commands/`

**سير العمل بطيء**: طبيعي - فهي تنسق عدة وكلاء فرعيين

**مخرجات عامة**: أضف سياقًا أكثر تحديدًا حول تقنيتك

**مشكلات التكامل**: تحقق من مسارات الملفات وتسلسل الأوامر

## نصائح الأداء

**اختيار الأوامر:**
- **سير العمل**: تنسيق عدة وكلاء فرعيين للميزات المعقدة
- **الأدوات**: عمليات مخصصة لمهام محددة
- **تعديلات بسيطة**: ابق مع الوكيل الرئيسي

**تحسين الأداء:**
- ابدأ بالأدوات للمشاكل المعروفة
- قدم متطلبات مفصلة منذ البداية
- البناء على مخرجات الأوامر السابقة
- دع سير العمل ينتهي قبل إجراء التعديلات

### إضافة سير عمل جديد:
- ركز على منطق تنسيق وتفويض الوكلاء الفرعيين
- حدد أي وكلاء فرعيين متخصصين يجب استخدامهم وبأي ترتيب
- عرّف أنماط التنسيق بين الوكلاء الفرعيين

### إضافة أداة جديدة:
- أدرج تطبيقات كاملة وجاهزة للإنتاج
- نظّم المحتوى بأقسام واضحة ومخرجات قابلة للتنفيذ
- أدرج أمثلة وأفضل الممارسات ونقاط التكامل

## تعلّم المزيد

- [توثيق Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [توثيق أوامر السلاش](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [توثيق الوكلاء الفرعيين](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [مجموعة وكلاء Claude Code الفرعيين](https://github.com/wshobson/agents) - وكلاء فرعيون متخصصون تستخدمهم هذه الأوامر



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---