
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# क्लॉड कोड स्लैश कमांड्स

[Claude Code](https://docs.anthropic.com/en/docs/claude-code) के लिए प्रोडक्शन-रेडी स्लैश कमांड्स, जो बुद्धिमान स्वचालन के माध्यम से विकास को तेज करते हैं।

**52 कमांड्स** इस प्रकार व्यवस्थित हैं:
- **🤖 वर्कफ्लो**: जटिल कार्यों के लिए मल्टी-सबएजेंट ऑर्केस्ट्रेशन
- **🔧 उपकरण**: विशिष्ट कार्यों के लिए एकल-उद्देश्यीय यूटिलिटीज

### 🤝 क्लॉड कोड सबएजेंट्स आवश्यक हैं

ये कमांड्स [Claude Code Subagents](https://github.com/wshobson/agents) के साथ ऑर्केस्ट्रेशन क्षमताओं के लिए काम करते हैं।

## इंस्टॉलेशन

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## उपलब्ध कमांड्स

- **🤖 वर्कफ़्लोज़** - जटिल कार्यों के लिए कई उप-एजेंट्स का संयोजन करें
- **🔧 टूल्स** - विशिष्ट कार्यों के लिए एकल-उद्देश्यीय कमांड्स

## उपयोग

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
क्लॉड कोड स्वचालित रूप से संदर्भ के आधार पर प्रासंगिक कमांड सुझाता है।

## 🤖 वर्कफ़्लो

जटिल कार्यों के लिए मल्टी-सबएजेंट ऑर्केस्ट्रेशन:

### फीचर डेवलपमेंट
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - बैकएंड, फ्रंटएंड, टेस्टिंग, और डिप्लॉयमेंट सबएजेंट्स द्वारा संपूर्ण फीचर्स का निर्माण
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - कई रिव्यू सबएजेंट्स द्वारा व्यापक कोड विश्लेषण
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - समस्याओं का विश्लेषण करता है और उपयुक्त विशेषज्ञ सबएजेंट्स को सौंपता है

### डेवलपमेंट प्रक्रियाएँ
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - ब्रांचिंग रणनीतियों और PR टेम्पलेट्स के साथ प्रभावी Git वर्कफ़्लो लागू करता है
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - प्रॉम्प्ट ऑप्टिमाइज़ेशन के माध्यम से सबएजेंट प्रदर्शन को बढ़ाता है
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - विशेष सबएजेंट्स की सहायता से लेगेसी कोडबेस को आधुनिक बनाता है
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - डेटा और ML इंजीनियरिंग सबएजेंट्स के साथ ML पाइपलाइनों का निर्माण करता है
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - समन्वित सबएजेंट्स के साथ क्रॉस-प्लेटफ़ॉर्म ऐप्स बनाता है
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, मॉनिटरिंग, और डिप्लॉयमेंट वर्कफ़्लो को स्वचालित करता है

### सबएजेंट-ऑर्केस्ट्रेटेड वर्कफ़्लो
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - बैकएंड, फ्रंटएंड और मोबाइल सबएजेंट्स के साथ मल्टी-प्लेटफ़ॉर्म फीचर्स
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - विशेष सबएजेंट्स के साथ सुरक्षा-प्रथम कार्यान्वयन
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - डेटा साइंस सबएजेंट्स के साथ ML-संचालित फीचर्स
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - प्रदर्शन सबएजेंट्स के साथ एंड-टू-एंड ऑप्टिमाइज़ेशन
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - ऑप्स सबएजेंट्स के साथ प्रोडक्शन इनसिडेंट समाधान

## 🔧 टूल्स (एकल-उद्देश्य कमांड्स)

### AI और मशीन लर्निंग
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - प्रोडक्शन-रेडी AI असिस्टेंट्स और चैटबॉट्स बनाएं
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML कोडबेस के लिए विशेष समीक्षा
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - आधुनिक पैटर्न के साथ LangChain/LangGraph एजेंट बनाएं
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps के साथ एंड-टू-एंड ML पाइपलाइनों का निर्माण करें
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - प्रदर्शन और गुणवत्ता के लिए AI प्रॉम्प्ट्स का ऑप्टिमाइजेशन करें

### आर्किटेक्चर और कोड गुणवत्ता
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - जटिल कोड की विस्तृत व्याख्या उत्पन्न करें
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - कोड को विभिन्न भाषाओं, फ्रेमवर्क्स, या संस्करणों में माइग्रेट करें
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - अनुरक्षणीयता और प्रदर्शन के लिए कोड का रिफैक्टर करें
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - तकनीकी कर्ज का विश्लेषण और प्राथमिकता निर्धारण

### डेटा और डेटाबेस
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - स्केलेबल डेटा पाइपलाइन आर्किटेक्चर डिज़ाइन करें
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - व्यापक डेटा सत्यापन प्रणालियाँ लागू करें
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - उन्नत डेटाबेस माइग्रेशन रणनीतियाँ

### देवऑप्स और इन्फ्रास्ट्रक्चर
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - डिप्लॉयमेंट कॉन्फ़िगरेशन और चेकलिस्ट बनाएं
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - उन्नत कंटेनर ऑप्टिमाइजेशन रणनीतियाँ
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - प्रोडक्शन-ग्रेड Kubernetes डिप्लॉयमेंट्स
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - व्यापक मॉनिटरिंग और ऑब्जर्वेबिलिटी सेटअप करें
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - सेवा स्तर उद्देश्यों (SLOs) को लागू करें
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - विकास और परिचालन वर्कफ़्लो को स्वचालित करें

### विकास और परीक्षण
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - विकास और परीक्षण के लिए यथार्थवादी API मॉक बनाएं
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - संपूर्ण इम्प्लीमेंटेशन स्टैक के साथ प्रोडक्शन-रेडी API एंडपॉइंट्स बनाएं
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - फ्रेमवर्क डिटेक्शन के साथ व्यापक टेस्ट सूट बनाएं

### सुरक्षा और अनुपालन
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - व्यापक एक्सेसिबिलिटी टेस्टिंग और सुधार
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - नियामक अनुपालन सुनिश्चित करें (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - स्वचालित सुधार के साथ व्यापक सुरक्षा स्कैनिंग

### डिबगिंग और विश्लेषण
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - उन्नत डिबगिंग और ट्रेसिंग रणनीतियाँ
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - गहन त्रुटि पैटर्न विश्लेषण और समाधान रणनीतियाँ
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - प्रोडक्शन त्रुटियों का ट्रेस और निदान करें
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - सुव्यवस्थित GitHub/GitLab इश्यू बनाएं

### डिपेंडेंसी और कॉन्फ़िगरेशन
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - एप्लिकेशन कॉन्फ़िगरेशन को मान्य और प्रबंधित करें
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - सुरक्षा और लाइसेंसिंग के लिए डिपेंडेंसी का ऑडिट करें
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - प्रोजेक्ट डिपेंडेंसी को सुरक्षित रूप से अपग्रेड करें

### दस्तावेज़ीकरण और सहयोग
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - व्यापक दस्तावेज़ीकरण उत्पन्न करें
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - प्रभावी Git वर्कफ़्लो लागू करें
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - गुणवत्ता जांच के साथ पुल रिक्वेस्ट्स को बेहतर बनाएं

### लागत अनुकूलन
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - क्लाउड और इन्फ्रास्ट्रक्चर लागत को ऑप्टिमाइज करें

### ऑनबोर्डिंग और सेटअप
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - नए टीम सदस्यों के लिए विकास परिवेश सेटअप करें

### सबएजेंट टूल्स
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - विशेषज्ञ सबएजेंट्स के साथ बहु-दृष्टिकोण कोड समीक्षा
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - डिबगर और प्रदर्शन सबएजेंट्स के साथ गहन डिबगिंग
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - कई सबएजेंट्स के साथ फुल-स्टैक ऑप्टिमाइजेशन
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - context-manager सबएजेंट का उपयोग कर प्रोजेक्ट संदर्भ सहेजें
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - निरंतरता के लिए सेव्ड संदर्भ पुनर्स्थापित करें

## विशेषताएँ

- प्रोडक्शन-रेडी इम्प्लीमेंटेशन
- फ्रेमवर्क ऑटो-डिटेक्शन
- सुरक्षा सर्वोत्तम प्रथाएँ
- अंतर्निर्मित मॉनिटरिंग और परीक्षण

- कमांड्स बिना किसी रुकावट के एक साथ काम करते हैं

## कमांड गिनती

**कुल: 52 प्रोडक्शन-तैयार स्लैश कमांड्स** जिन्हें इस प्रकार व्यवस्थित किया गया है:

### 🤖 वर्कफ्लो (14 कमांड्स)

- फीचर डेवलपमेंट और समीक्षा (3 कमांड्स) 
- डेवलपमेंट प्रोसेस ऑटोमेशन (6 कमांड्स)
- सबएजेंट-ऑर्केस्ट्रेटेड वर्कफ्लो (5 कमांड्स)

### 🔧 टूल्स (38 कमांड्स)

- एआई और मशीन लर्निंग (5 कमांड्स)
- आर्किटेक्चर और कोड क्वालिटी (4 कमांड्स)
- डेटा और डेटाबेस (3 कमांड्स)
- देवऑप्स और इन्फ्रास्ट्रक्चर (6 कमांड्स)
- डेवलपमेंट और टेस्टिंग (3 कमांड्स)
- सुरक्षा और अनुपालन (3 कमांड्स)
- डिबगिंग और विश्लेषण (4 कमांड्स)
- डिपेंडेंसीज और कॉन्फ़िगरेशन (3 कमांड्स)
- डाक्यूमेंटेशन और सहयोग (1 कमांड)
- ऑनबोर्डिंग और सेटअप (1 कमांड)
- सबएजेंट-विशिष्ट टूल्स (5 कमांड्स)

## उपयोग के उदाहरण

### 🤖 वर्कफ़्लो उदाहरण

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

### 🔧 उपकरण उदाहरण (एकल-उद्देश्यीय कमांड)

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
## उन्नत कमांड्स

### सुरक्षा और डेवऑप्स

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

स्वचालित समाधान के साथ व्यापक सुरक्षा स्कैनिंग।

- **मल्टी-टूल स्कैनिंग**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **स्वचालित सुधार**: सामान्य कमजोरियों का ऑटो-सुधार
- **CI/CD एकीकरण**: GitHub Actions/GitLab CI के लिए सुरक्षा गेट्स
- **कंटेनर स्कैनिंग**: इमेज कमजोरियों का विश्लेषण
- **सीक्रेट डिटेक्शन**: GitLeaks और TruffleHog एकीकरण

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

उन्नत कंटेनर ऑप्टिमाइज़ेशन रणनीतियाँ।

- **स्मार्ट ऑप्टिमाइज़ेशन**: विश्लेषण करता है और सुधार के सुझाव देता है
- **मल्टी-स्टेज बिल्ड्स**: फ्रेमवर्क-विशिष्ट ऑप्टिमाइज़्ड डॉकरफाइल्स
- **आधुनिक टूल्स**: तेज बिल्ड्स के लिए BuildKit, Bun, UV
- **सुरक्षा सुदृढ़ीकरण**: Distroless इमेजेज, नॉन-रूट उपयोगकर्ता
- **क्रॉस-कमांड एकीकरण**: /api-scaffold आउटपुट्स के साथ काम करता है

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

प्रोडक्शन-ग्रेड क्यूबरनेट्स डिप्लॉयमेंट्स।

- **उन्नत पैटर्न्स**: पाड सुरक्षा मानक, नेटवर्क पॉलिसीज, OPA
- **GitOps तैयार**: FluxCD और ArgoCD कॉन्फ़िगरेशन
- **अवलोकन**: Prometheus ServiceMonitors, OpenTelemetry
- **ऑटो-स्केलिंग**: HPA, VPA, और क्लस्टर ऑटोस्केलर कॉन्फ़िग्स
- **सर्विस मेष**: Istio/Linkerd एकीकरण

### फ्रंटएंड और डेटा

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

उन्नत डाटाबेस माइग्रेशन रणनीतियाँ।

- **मल्टी-डाटाबेस**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **शून्य-डाउनटाइम**: ब्लू-ग्रीन डिप्लॉयमेंट्स, रोलिंग माइग्रेशन
- **इवेंट सोर्सिंग**: CDC के लिए Kafka/Kinesis एकीकरण
- **क्रॉस-प्लेटफॉर्म**: पॉलीग्लॉट परसिस्टेंस को संभालता है
- **मॉनिटरिंग**: माइग्रेशन हेल्थ चेक्स और रोलबैक

## वर्कफ़्लोज़ और टूल्स का संयोजन

वास्तविक शक्ति वर्कफ़्लोज़ और टूल्स को जोड़कर पूर्ण विकास चक्रों में आती है:

### उदाहरण: एक नई सुविधा बनाना


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

### उदाहरण: विरासत कोड का आधुनिकीकरण

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

## कमांड ऑर्केस्ट्रेशन पैटर्न

कमांड्स को व्यक्तिगत रूप से या शक्तिशाली पैटर्न में संयोजित करके उपयोग किया जा सकता है:

### अनुक्रमिक निष्पादन
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### समानांतर विश्लेषण
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### पुनरावृत्त परिष्करण
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### क्रॉस-डोमेन एकीकरण
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## वर्कफ़्लोज़ बनाम टूल्स का उपयोग कब करें

### 🔀 वर्कफ़्लोज़ और सबएजेंट टूल्स
- **समस्या-समाधान**: अनुकूल तरीके से समस्याओं का विश्लेषण और समाधान करें
- **अनेक दृष्टिकोण**: विशेषज्ञ सबएजेंट्स का समन्वय करें
- **जटिल कार्य**: विभिन्न क्षेत्रों में बहु-चरणीय प्रक्रियाएँ
- **अज्ञात समाधान**: सबएजेंट्स को दृष्टिकोण निर्धारित करने दें

### 🛠️ विशेषज्ञ टूल्स
- **इन्फ्रास्ट्रक्चर सेटअप**: वातावरण कॉन्फ़िगर करें
- **कोड जेनरेशन**: विशिष्ट कार्यान्वयन बनाएँ
- **विश्लेषण**: बिना समाधान के रिपोर्ट तैयार करें
- **डोमेन कार्य**: अत्यधिक विशेषज्ञ संचालन

**उदाहरण:**
- "यूज़र ऑथेंटिकेशन सिस्टम लागू करें" → `/feature-development`
- "स्टैक में प्रदर्शन समस्याएँ ठीक करें" → `/smart-fix`
- "लीगेसी मोनोलिथ को आधुनिक बनाएं" → `/legacy-modernize`

### 🔧 टूल्स का उपयोग कब करें:
- **विशिष्ट विशेषज्ञता आवश्यक** - एक डोमेन में स्पष्ट, केंद्रित कार्य
- **सटीक नियंत्रण वांछित** - विशिष्ट कार्यान्वयन विवरण निर्देशित करना है
- **मैन्युअल वर्कफ़्लो का हिस्सा** - मौजूदा प्रक्रियाओं में एकीकृत करना
- **गहरी विशेषज्ञता चाहिए** - विशेषज्ञ-स्तर का कार्यान्वयन चाहिए
- **मौजूदा कार्य पर निर्माण** - पिछले आउटपुट को बढ़ाना या परिष्कृत करना

**उदाहरण:**
- "कुबेरनेट्स मैनिफ़ेस्ट बनाएँ" → `/k8s-manifest`
- "सुरक्षा कमजोरियों के लिए स्कैन करें" → `/security-scan`
- "API डाक्यूमेंटेशन जेनरेट करें" → `/doc-generate`

## कमांड प्रारूप

स्लैश कमांड साधारण मार्कडाउन फाइलें होती हैं जहाँ:
- फ़ाइलनाम कमांड नाम बन जाता है (जैसे, `api-scaffold.md` → `/api-scaffold`)
- फ़ाइल की सामग्री ही प्रम्प्ट/निर्देश बनती है जो निष्पादित होते हैं
- उपयोगकर्ता इनपुट के लिए `$ARGUMENTS` प्लेसहोल्डर का उपयोग करें

## सर्वोत्तम अभ्यास

### कमांड चयन
- **Claude Code को स्वतः सुझाव देने दें** - संदर्भ का विश्लेषण करता है और सर्वोत्तम कमांड चुनता है
- **जटिल कार्यों के लिए वर्कफ़्लोज़ का उपयोग करें** - सबएजेंट्स बहु-डोमेन कार्यान्वयन का समन्वय करते हैं
- **केंद्रित कार्यों के लिए टूल्स का उपयोग करें** - लक्षित सुधार हेतु विशिष्ट कमांड लागू करें

### प्रभावी उपयोग
- **व्यापक संदर्भ दें** - तकनीकी स्टैक, सीमाएँ और आवश्यकताएँ शामिल करें
- **कमांड्स को रणनीतिक रूप से जोड़ें** - वर्कफ़्लोज़ → टूल्स → परिष्करण
- **पिछले आउटपुट पर निर्माण करें** - कमांड्स एक-दूसरे के साथ काम करने हेतु डिज़ाइन किए गए हैं

## योगदान देना

1. `workflows/` या `tools/` में `.md` फ़ाइल बनाएं
2. लोअरकेस-हाइफ़न-नेम्स का उपयोग करें
3. उपयोगकर्ता इनपुट के लिए `$ARGUMENTS` शामिल करें

## समस्या निवारण

**कमांड नहीं मिला**: जांचें कि फाइलें `~/.claude/commands/` में हैं

**वर्कफ़्लोज़ धीमे हैं**: सामान्य है - वे कई सबएजेंट्स का समन्वय करते हैं

**सामान्य आउटपुट**: अपने टेक स्टैक के बारे में अधिक विशिष्ट संदर्भ जोड़ें

**इंटीग्रेशन समस्याएँ**: फ़ाइल पथ और कमांड अनुक्रम सत्यापित करें

## प्रदर्शन सुझाव

**कमांड चयन:**
- **वर्कफ़्लोज़**: जटिल फीचर्स के लिए बहु-सबएजेंट समन्वय
- **टूल्स**: विशिष्ट कार्यों के लिए एकल-उद्देश्य संचालन
- **सरल संपादन**: मुख्य एजेंट के साथ बने रहें

**सुधार:**
- ज्ञात समस्याओं के लिए टूल्स से शुरू करें
- शुरुआत में ही विस्तृत आवश्यकताएँ दें
- पिछले कमांड आउटपुट पर निर्माण करें
- संशोधन से पहले वर्कफ़्लोज़ को पूरा होने दें

### नया वर्कफ़्लो जोड़ना:
- सबएजेंट ऑर्केस्ट्रेशन और डेलीगेशन लॉजिक पर ध्यान दें
- यह निर्दिष्ट करें कि कौन से विशेषज्ञ सबएजेंट्स का उपयोग करना है और किस क्रम में
- सबएजेंट्स के बीच समन्वय पैटर्न परिभाषित करें

### नया टूल जोड़ना:
- संपूर्ण, प्रोडक्शन-तैयार कार्यान्वयन शामिल करें
- सामग्री को स्पष्ट अनुभागों और क्रियाशील आउटपुट के साथ संरचित करें
- उदाहरण, सर्वोत्तम अभ्यास, और इंटीग्रेशन बिंदु शामिल करें

## और जानें

- [Claude Code डाक्यूमेंटेशन](https://docs.anthropic.com/en/docs/claude-code)
- [स्लैश कमांड डाक्यूमेंटेशन](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [सबएजेंट्स डाक्यूमेंटेशन](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code गिटहब](https://github.com/anthropics/claude-code)
- [Claude Code Subagents संग्रह](https://github.com/wshobson/agents) - इन कमांड्स द्वारा प्रयुक्त विशेषज्ञ सबएजेंट्स



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---