
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

# أوامر الشَرطة المائلة لـ Claude Code

أوامر شرطة مائلة جاهزة للإنتاج لـ [Claude Code](https://docs.anthropic.com/en/docs/claude-code) تُسرّع التطوير عبر الأتمتة الذكية.

**52 أمرًا** مُنظمة كالتالي:
- **🤖 سير العمل**: تنسيق متعدد للوكلاء الفرعيين للمهام المعقدة
- **🔧 أدوات**: أدوات ذات غرض واحد للعمليات المحددة

### 🤝 يتطلب وكلاء Claude Code الفرعيين

تعمل هذه الأوامر مع [وكلاء Claude Code الفرعيين](https://github.com/wshobson/agents) للحصول على قدرات التنسيق.

## التثبيت

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## الأوامر المتاحة

- **🤖 سير العمل** - تنظيم عدة وكلاء فرعيين للمهام المعقدة
- **🔧 الأدوات** - أوامر مخصصة لغرض واحد لعمليات محددة

## طريقة الاستخدام

يتم تنظيم الأوامر في مجلدات `tools/` و `workflows/`. استخدمها مع بادئة اسم المجلد:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**ملاحظة:** إذا كنت تفضل استخدام الأوامر بدون بادئات، يمكنك تسطيح الأدلة:
```bash
cp tools/*.md .
cp workflows/*.md .
```
يقوم Claude Code باقتراح الأوامر ذات الصلة تلقائيًا بناءً على السياق.

## 🤖 سير العمل

تنسيق متعدد للوكلاء الفرعيين للمهام المعقدة:

### تطوير المزايا
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - وكلاء فرعيون للواجهة الخلفية، الأمامية، الاختبار والنشر لبناء مزايا كاملة
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - وكلاء مراجعة متعددون يقدمون تحليلًا شاملاً للكود
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - يحلل المشكلات ويوجهها إلى الوكلاء الفرعيين المختصين المناسبين

### عمليات التطوير
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - تنفيذ سير عمل فعال لـ Git مع استراتيجيات التفريع وقوالب PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - تحسين أداء الوكلاء الفرعيين من خلال تحسين التعليمات
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - تحديث قواعد الأكواد القديمة باستخدام وكلاء فرعيين متخصصين
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - إنشاء خطوط ML مع وكلاء هندسة البيانات والذكاء الاصطناعي
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - بناء تطبيقات متعددة المنصات من خلال تنسيق الوكلاء الفرعيين
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - أتمتة سير العمل CI/CD، المراقبة، والنشر

### سير العمل المنسق بواسطة الوكلاء الفرعيين
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - مزايا متعددة المنصات مع وكلاء فرعيين للواجهة الخلفية، الأمامية، والجوال
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - تنفيذ يركز على الأمان باستخدام وكلاء فرعيين متخصصين
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - مزايا مدعومة بالذكاء الاصطناعي مع وكلاء فرعيين لعلم البيانات
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - تحسين شامل للأداء مع وكلاء فرعيين للأداء
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - حل الحوادث الإنتاجية مع وكلاء فرعيين للعمليات

## 🔧 أدوات (أوامر أحادية الغرض)

### الذكاء الاصطناعي وتعلم الآلة
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - بناء مساعدين ذكاء اصطناعي وروبوتات دردشة جاهزة للإنتاج
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - مراجعة متخصصة لقواعد كود الذكاء الاصطناعي/تعلم الآلة
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - إنشاء وكلاء LangChain/LangGraph بأنماط حديثة
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - إنشاء خطوط ML شاملة مع MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - تحسين التعليمات البرمجية للذكاء الاصطناعي للأداء والجودة

### البنية وجودة الكود
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - توليد شروحات مفصلة للكود المعقد
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - نقل الكود بين اللغات أو الأطر أو الإصدارات
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - إعادة هيكلة الكود لتحسين القابلية للصيانة والأداء

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - تحليل وتحديد أولويات الدين التقني

### البيانات وقواعد البيانات
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - تصميم هياكل خطوط البيانات القابلة للتوسع
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - تنفيذ أنظمة تحقق بيانات شاملة
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - استراتيجيات متقدمة لترحيل قواعد البيانات

### التطوير والبنية التحتية
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - إنشاء تكوينات وقوائم مراجعة للنشر
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - استراتيجيات متقدمة لتحسين الحاويات
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - عمليات نشر Kubernetes عالية الجودة للإنتاج
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - إعداد مراقبة ورصد شاملين
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - تنفيذ أهداف مستوى الخدمة (SLOs)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - أتمتة سير العمل التطويري والتشغيلي

### التطوير والاختبار
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - إنشاء نماذج API واقعية للتطوير والاختبار
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - إنشاء نقاط نهاية API جاهزة للإنتاج مع مكدس التنفيذ الكامل
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - إنشاء مجموعات اختبار شاملة مع كشف إطار العمل

### الأمن والامتثال
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - اختبار وإصلاحات شاملة لقابلية الوصول
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - ضمان الامتثال التنظيمي (GDPR، HIPAA، SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - فحص أمني شامل مع التصحيح التلقائي

### التصحيح والتحليل
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - استراتيجيات متقدمة للتصحيح والتتبع
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - تحليل عميق لأنماط الأخطاء واستراتيجيات حلها
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - تتبع وتشخيص أخطاء الإنتاج
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - إنشاء قضايا GitHub/GitLab منظمة بشكل جيد

### الاعتمادات والتكوين
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - التحقق من تكوين التطبيق وإدارته
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - تدقيق الاعتمادات من أجل الأمن والتراخيص
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - ترقية اعتمادات المشروع بأمان

### التوثيق والتعاون
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - إنشاء توثيق شامل
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - تنفيذ سير عمل Git فعال
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - تحسين طلبات الدمج بفحوصات الجودة

### تحسين التكلفة
- **[تحسين-التكلفة](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - تحسين تكاليف السحابة والبنية التحتية

### الإعداد والانضمام
- **[الانضمام](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - إعداد بيئات التطوير للأعضاء الجدد في الفريق

### أدوات الوكلاء الفرعيين
- **[مراجعة-متعددة-الوكلاء](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - مراجعة الكود من عدة وجهات نظر باستخدام وكلاء فرعيين متخصصين
- **[تصحيح-ذكي](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - تصحيح عميق باستخدام وكيل تصحيح الأداء والأخطاء
- **[تحسين-متعدد-الوكلاء](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - تحسين شامل عبر جميع الطبقات باستخدام عدة وكلاء فرعيين
- **[حفظ-السياق](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - حفظ سياق المشروع باستخدام وكيل إدارة السياق الفرعي
- **[استعادة-السياق](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - استعادة السياق المحفوظ لضمان الاستمرارية

## الميزات

- تطبيقات جاهزة للإنتاج
- الكشف التلقائي عن الإطار البرمجي
- أفضل ممارسات الأمان
- مراقبة واختبار مدمج
- تعمل الأوامر معًا بسلاسة

## عدد الأوامر

**الإجمالي: 52 أمر جاهز للإنتاج** مصنفة ضمن:

### 🤖 سير العمل (14 أمرًا)

- تطوير الميزات والمراجعة (3 أوامر)
- أتمتة عملية التطوير (6 أوامر)
- سير العمل المنسق بواسطة الوكلاء الفرعيين (5 أوامر)

### 🔧 الأدوات (38 أمرًا)

- الذكاء الاصطناعي وتعلم الآلة (5 أوامر)
- الهندسة وجودة الكود (4 أوامر)
- البيانات وقواعد البيانات (3 أوامر)
- التطوير والبنية التحتية (6 أوامر)
- التطوير والاختبار (3 أوامر)
- الأمان والامتثال (3 أوامر)
- التصحيح والتحليل (٤ أوامر)
- الاعتمادات والتكوين (٣ أوامر)
- التوثيق والتعاون (أمر واحد)
- الإعداد والتهيئة (أمر واحد)
- أدوات خاصة بالوكلاء الفرعيين (٥ أوامر)

## أمثلة الاستخدام

### 🤖 أمثلة سير العمل

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

### 🔧 أمثلة على الأدوات (أوامر ذات غرض واحد)

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

## أوامر محسّنة

### الأمن و DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

فحص أمني شامل مع تصحيح تلقائي.

- **فحص متعدد الأدوات**: Bandit، Safety، Trivy، Semgrep، ESLint Security، Snyk
- **إصلاحات تلقائية**: معالجة تلقائية للثغرات الشائعة
- **تكامل CI/CD**: بوابات أمان لـ GitHub Actions/GitLab CI
- **فحص الحاويات**: تحليل ثغرات الصور
- **كشف الأسرار**: تكامل GitLeaks و TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

استراتيجيات تحسين الحاويات المتقدمة.

- **تحسين ذكي**: تحليل واقتراح تحسينات
- **بناء متعدد المراحل**: ملفات Docker مخصصة حسب الإطار
- **أدوات حديثة**: BuildKit، Bun، UV للبناء السريع
- **تعزيز الأمان**: صور بدون نظام تشغيل، مستخدمين بدون صلاحيات الجذر
- **تكامل بين الأوامر**: يعمل مع نتائج /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

نشر Kubernetes بمستوى الإنتاج.

- **أنماط متقدمة**: معايير أمان البود، سياسات الشبكة، OPA
- **جاهز لـ GitOps**: إعدادات FluxCD و ArgoCD
- **الرصد والمراقبة**: Prometheus ServiceMonitors، OpenTelemetry
- **التوسع التلقائي**: إعدادات HPA، VPA، وموسع الكتلة
- **شبكة الخدمة**: تكامل Istio/Linkerd

### الواجهة الأمامية والبيانات

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

استراتيجيات ترحيل قواعد البيانات المتقدمة.

- **متعدد قواعد البيانات**: PostgreSQL، MySQL، MongoDB، DynamoDB
- **عدم توقف الخدمة**: عمليات النشر الأزرق-الأخضر، الترقيات التدريجية
- **تسجيل الأحداث**: تكامل Kafka/Kinesis من أجل مراقبة تغييرات البيانات
- **عبر المنصات**: يدعم الحفظ متعدد اللغات
- **المراقبة**: فحوصات صحة الترحيل وإمكانية الرجوع للخلف

## دمج سير العمل والأدوات

القوة الحقيقية تأتي من دمج سير العمل والأدوات لدورة تطوير كاملة:

### مثال: بناء ميزة جديدة

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

### مثال: تحديث الشيفرة القديمة

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

## أنماط تنسيق الأوامر

يمكن استخدام الأوامر بشكل فردي أو تجميعها في أنماط قوية:

### التنفيذ التسلسلي
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### التحليل المتوازي
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### التحسين التكراري
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### التكامل عبر المجالات
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## متى تستخدم سير العمل مقابل الأدوات

### 🔀 سير العمل وأدوات الوكلاء الفرعيين
- **حل المشكلات**: تحليل وإصلاح المشكلات بشكل تكيفي
- **وجهات نظر متعددة**: تنسيق وكلاء فرعيين متخصصين
- **مهام معقدة**: عمليات متعددة الخطوات عبر مجالات مختلفة
- **حلول غير معروفة**: دع الوكلاء الفرعيين يحددون النهج

### 🛠️ الأدوات المتخصصة
- **إعداد البنية التحتية**: تكوين البيئات
- **توليد التعليمات البرمجية**: إنشاء تطبيقات محددة
- **التحليل**: إنشاء تقارير بدون إصلاحات
- **مهام المجال**: عمليات متخصصة للغاية

**أمثلة:**
- "تنفيذ نظام مصادقة المستخدم" → `/workflows:feature-development`
- "إصلاح مشاكل الأداء عبر المنظومة" → `/workflows:smart-fix`
- "تحديث المنظومة القديمة" → `/workflows:legacy-modernize`

### 🔧 استخدم الأدوات عندما:
- **الحاجة لخبرة محددة** - مهمة واضحة ومركزة في مجال واحد
- **الرغبة في التحكم الدقيق** - ترغب في توجيه تفاصيل التنفيذ المحددة
- **جزء من سير عمل يدوي** - التكامل مع العمليات الحالية
- **الحاجة لتخصص عميق** - الحاجة لتنفيذ على مستوى الخبراء
- **البناء على عمل موجود** - تحسين أو تعديل المخرجات السابقة

**أمثلة:**
- "إنشاء ملفات Kubernetes" → `/tools:k8s-manifest`
- "مسح الثغرات الأمنية" → `/tools:security-scan`
- "توليد وثائق API" → `/tools:doc-generate`

## تنسيق الأمر

أوامر السلاش هي ملفات ماركداون بسيطة حيث:
- اسم الملف يصبح اسم الأمر (مثال: `tools/api-scaffold.md` → `/tools:api-scaffold`)
- محتوى الملف هو التعليمات/المطالبة التي يتم تنفيذها عند الاستدعاء
- استخدم عنصر نائب `$ARGUMENTS` لإدخال المستخدم

## أفضل الممارسات

### اختيار الأمر
- **دع Claude Code يقترح تلقائيًا** - يحلل السياق ويختار الأوامر المثلى
- **استخدم سير العمل للمهام المعقدة** - الوكلاء الفرعيون ينسقون تنفيذات متعددة المجالات
- **استخدم الأدوات للمهام المركزة** - تطبيق أوامر محددة لتحسينات مستهدفة

### الاستخدام الفعّال
- **قدم سياقًا شاملاً** - تضمين تقنية التنفيذ والقيود والمتطلبات
- **سلسل الأوامر بشكل استراتيجي** - سير العمل → أدوات → تحسينات
- **ابنِ على المخرجات السابقة** - تم تصميم الأوامر للعمل معًا

## المساهمة

1. أنشئ ملف `.md` في `workflows/` أو `tools/`
2. استخدم أسماء بحروف صغيرة مع شرطات
3. أدرج `$ARGUMENTS` لإدخال المستخدم

## استكشاف الأخطاء وإصلاحها

**الأمر غير موجود**:
- تحقق من وجود الملفات في `~/.claude/commands/tools/` أو `~/.claude/commands/workflows/`
- استخدم البادئة الصحيحة: `/tools:command-name` أو `/workflows:command-name`
- أو قم بتسطيح الدلائل إذا كنت تفضل عدم وجود بادئات: `cp tools/*.md . && cp workflows/*.md .`

**بطء سير العمل**: طبيعي - فهي تنسق عدة وكلاء فرعيين

**مخرجات عامة**: أضف سياقًا أكثر تحديدًا حول تقنية التنفيذ الخاصة بك

**مشاكل التكامل**: تحقق من مسارات الملفات وتسلسل الأوامر

## نصائح الأداء

**اختيار الأمر:**
- **سير العمل**: تنسيق متعدد الوكلاء الفرعيين للميزات المعقدة
- **الأدوات**: عمليات ذات غرض واحد للمهام المحددة
- **تعديلات بسيطة**: ابق مع الوكيل الرئيسي

**التحسين:**
- ابدأ بالأدوات للمشاكل المعروفة
- قدم متطلبات مفصلة منذ البداية
- البناء على مخرجات الأوامر السابقة
- السماح بإكمال سير العمل قبل إجراء التعديلات

### إضافة سير عمل جديد:
- التركيز على منطق تنظيم وتفويض العوامل الفرعية
- تحديد أي العوامل الفرعية المتخصصة يجب استخدامها وبأي ترتيب
- تعريف أنماط التنسيق بين العوامل الفرعية

### إضافة أداة جديدة:
- تضمين تطبيقات كاملة وجاهزة للإنتاج
- تنظيم المحتوى بأقسام واضحة ومخرجات قابلة للتنفيذ
- تضمين أمثلة وأفضل الممارسات ونقاط التكامل

## لمعرفة المزيد

- [توثيق Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [توثيق أوامر Slash](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [توثيق العوامل الفرعية](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code على GitHub](https://github.com/anthropics/claude-code)
- [مجموعة Claude Code Subagents](https://github.com/wshobson/agents) - العوامل الفرعية المتخصصة المستخدمة في هذه الأوامر


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---