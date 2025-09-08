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

[क्लॉड कोड](https://docs.anthropic.com/en/docs/claude-code) के लिए प्रोडक्शन-रेडी स्लैश कमांड्स, जो बुद्धिमान ऑटोमेशन के माध्यम से विकास को तेज करती हैं।

**52 कमांड्स** इस प्रकार संगठित हैं:
- **🤖 वर्कफ़्लो**: जटिल कार्यों के लिए मल्टी-सबएजेंट ऑर्केस्ट्रेशन
- **🔧 टूल्स**: विशिष्ट ऑपरेशनों के लिए सिंगल-पर्पज़ यूटिलिटीज


### 🤝 क्लॉड कोड सबएजेंट्स की आवश्यकता है

ये कमांड [क्लॉड कोड सबएजेंट्स](https://github.com/wshobson/agents) के साथ ऑर्केस्ट्रेशन क्षमताओं के लिए काम करती हैं।

## इंस्टॉलेशन

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## उपलब्ध कमांड्स

- **🤖 वर्कफ़्लो** - जटिल कार्यों के लिए कई सबएजेंट्स का समन्वयन करें
- **🔧 टूल्स** - विशिष्ट कार्यों के लिए एकल-उद्देश्यीय कमांड्स

## उपयोग

कमांड्स `tools/` और `workflows/` डायरेक्टरी में व्यवस्थित हैं। इन्हें डायरेक्टरी प्रीफ़िक्स के साथ उपयोग करें:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**नोट:** यदि आप बिना उपसर्गों के कमांड्स का उपयोग करना पसंद करते हैं, तो आप निर्देशिकाओं को समतल कर सकते हैं:
```bash
cp tools/*.md .
cp workflows/*.md .
```

Claude Code स्वचालित रूप से संदर्भ के आधार पर प्रासंगिक कमांड का सुझाव देता है।

## 🤖 वर्कफ्लो

जटिल कार्यों के लिए मल्टी-सबएजेंट ऑर्केस्ट्रेशन:

### फीचर डेवलपमेंट
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - बैकएंड, फ्रंटएंड, टेस्टिंग और डिप्लॉयमेंट सबएजेंट्स पूरी फीचर बनाते हैं
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - कई समीक्षा सबएजेंट्स व्यापक कोड विश्लेषण प्रदान करते हैं
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - समस्याओं का विश्लेषण करता है और उपयुक्त विशेषज्ञ सबएजेंट्स को सौंपता है

### डेवलपमेंट प्रोसेस
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - शाखा रणनीतियों और PR टेम्पलेट्स के साथ प्रभावी Git वर्कफ्लो लागू करता है
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - सबएजेंट प्रदर्शन को प्रॉम्प्ट ऑप्टिमाइजेशन के माध्यम से बढ़ाता है
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - विशेष सबएजेंट्स की मदद से लेगेसी कोडबेस को आधुनिक बनाता है
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - डेटा और ML इंजीनियरिंग सबएजेंट्स के साथ ML पाइपलाइन बनाता है
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - समन्वित सबएजेंट्स के साथ क्रॉस-प्लेटफार्म ऐप्स बनाता है
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, मॉनिटरिंग, और डिप्लॉयमेंट वर्कफ्लो को स्वचालित करता है

### सबएजेंट-ऑर्केस्ट्रेटेड वर्कफ्लो
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - बैकएंड, फ्रंटएंड, और मोबाइल सबएजेंट्स के साथ मल्टी-प्लेटफार्म फीचर
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - विशेष सबएजेंट्स के साथ सुरक्षा-प्रथम कार्यान्वयन
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - डेटा साइंस सबएजेंट्स के साथ ML-संचालित फीचर्स
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - प्रदर्शन सबएजेंट्स के साथ एंड-टू-एंड ऑप्टिमाइजेशन
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - संचालन सबएजेंट्स के साथ प्रोडक्शन घटना समाधान

## 🔧 उपकरण (एकल-उद्देश्य कमांड)

### एआई और मशीन लर्निंग
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - प्रोडक्शन-तैयार एआई असिस्टेंट्स और चैटबॉट्स बनाएं
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - एआई/एमएल कोडबेस के लिए विशेष समीक्षा
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - आधुनिक पैटर्न के साथ LangChain/LangGraph एजेंट्स बनाएं
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps के साथ एंड-टू-एंड ML पाइपलाइन बनाएं
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - प्रदर्शन और गुणवत्ता के लिए एआई प्रॉम्प्ट्स को ऑप्टिमाइज़ करें

### आर्किटेक्चर और कोड गुणवत्ता
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - जटिल कोड की विस्तृत व्याख्याएं उत्पन्न करें
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - कोड को भाषाओं, फ्रेमवर्क या संस्करणों के बीच माइग्रेट करें
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - रखरखाव और प्रदर्शन के लिए कोड को रिफैक्टर करें
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - तकनीकी ऋण का विश्लेषण और प्राथमिकता निर्धारण करें

### डेटा और डेटाबेस
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - स्केलेबल डेटा पाइपलाइन संरचनाओं का डिजाइन करें
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - व्यापक डेटा सत्यापन प्रणालियाँ लागू करें
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - उन्नत डेटाबेस माइग्रेशन रणनीतियाँ

### देवऑप्स और इंफ्रास्ट्रक्चर
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - परिनियोजन कॉन्फ़िगरेशन और चेकलिस्ट उत्पन्न करें
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - उन्नत कंटेनर अनुकूलन रणनीतियाँ
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - प्रोडक्शन-ग्रेड क्यूबरनेट्स डिप्लॉयमेंट्स
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - व्यापक निगरानी और ऑब्ज़रवेबिलिटी सेटअप करें
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - सेवा स्तर उद्देश्य (SLOs) लागू करें
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - विकास और संचालन वर्कफ़्लो स्वचालित करें

### विकास और परीक्षण
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - विकास और परीक्षण के लिए यथार्थवादी API मॉक बनाएं
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - पूर्ण कार्यान्वयन स्टैक के साथ प्रोडक्शन-रेडी API एंडपॉइंट्स उत्पन्न करें
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - फ्रेमवर्क डिटेक्शन के साथ व्यापक टेस्ट सूट बनाएं

### सुरक्षा और अनुपालन
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - व्यापक अभिगम्यता परीक्षण और सुधार
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - नियामक अनुपालन सुनिश्चित करें (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - स्वचालित समाधान के साथ व्यापक सुरक्षा स्कैनिंग

### डीबगिंग और विश्लेषण
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - उन्नत डीबगिंग और ट्रेसिंग रणनीतियाँ
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - गहन त्रुटि पैटर्न विश्लेषण और समाधान रणनीतियाँ
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - प्रोडक्शन त्रुटियों का पता लगाएँ और निदान करें
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - सुव्यवस्थित GitHub/GitLab समस्याएँ बनाएं

### निर्भरता और कॉन्फ़िगरेशन
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - एप्लिकेशन कॉन्फ़िगरेशन का सत्यापन और प्रबंधन करें
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - सुरक्षा और लाइसेंसिंग के लिए निर्भरताओं का ऑडिट करें
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - परियोजना निर्भरताओं का सुरक्षित रूप से उन्नयन करें

### दस्तावेज़ीकरण और सहयोग
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - व्यापक दस्तावेज़ उत्पन्न करें
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - प्रभावी Git वर्कफ़्लो लागू करें
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - गुणवत्ता जांच के साथ पुल अनुरोधों को बेहतर बनाएं

### लागत अनुकूलन
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - क्लाउड और इन्फ्रास्ट्रक्चर लागत का अनुकूलन करें

### ऑनबोर्डिंग और सेटअप
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - नए टीम सदस्यों के लिए डेवलपमेंट वातावरण सेटअप करें

### सबएजेंट टूल्स
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - विशेष सबएजेंट्स के साथ बहु-दृष्टिकोण कोड समीक्षा
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - डिबगर और प्रदर्शन सबएजेंट्स के साथ गहन डिबगिंग
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - कई सबएजेंट्स के साथ फुल-स्टैक अनुकूलन
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - प्रोजेक्ट संदर्भ को संदर्भ-प्रबंधक सबएजेंट द्वारा सुरक्षित करें
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - निरंतरता के लिए सहेजा गया संदर्भ पुनर्स्थापित करें

## विशेषताएँ

- प्रोडक्शन-रेडी इम्प्लीमेंटेशन
- फ्रेमवर्क ऑटो-डिटेक्शन
- सुरक्षा सर्वोत्तम प्रथाएँ
- बिल्ट-इन मॉनिटरिंग और टेस्टिंग
- कमांड्स आपस में निर्बाध रूप से कार्य करते हैं

## कमांड गणना

**कुल: 52 प्रोडक्शन-रेडी स्लैश कमांड्स** जिन्हें इस प्रकार संगठित किया गया है:

### 🤖 वर्कफ़्लो (14 कमांड्स)

- फीचर डेवलपमेंट और समीक्षा (3 कमांड्स)
- डेवलपमेंट प्रोसेस ऑटोमेशन (6 कमांड्स)
- सबएजेंट-आर्केस्ट्रेटेड वर्कफ़्लो (5 कमांड्स)

### 🔧 टूल्स (38 कमांड्स)

- एआई और मशीन लर्निंग (5 कमांड्स)
- आर्किटेक्चर और कोड गुणवत्ता (4 कमांड्स)
- डेटा और डेटाबेस (3 कमांड्स)
- देवऑप्स और इन्फ्रास्ट्रक्चर (6 कमांड्स)
- डेवलपमेंट और टेस्टिंग (3 कमांड्स)
- सुरक्षा और अनुपालन (3 कमांड्स)
- डिबगिंग और विश्लेषण (4 कमांड)
- निर्भरता और कॉन्फ़िगरेशन (3 कमांड)
- दस्तावेज़ीकरण और सहयोग (1 कमांड)
- ऑनबोर्डिंग और सेटअप (1 कमांड)
- सबएजेंट-विशिष्ट उपकरण (5 कमांड)

## उपयोग उदाहरण

### 🤖 वर्कफ़्लो उदाहरण

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

### 🔧 उपकरण उदाहरण (एकल-उद्देश्यीय कमांड)

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

## उन्नत कमांड्स

### सुरक्षा और देवऑप्स

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

स्वचालित सुधार के साथ व्यापक सुरक्षा स्कैनिंग।

- **मल्टी-टूल स्कैनिंग**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **स्वचालित सुधार**: सामान्य कमजोरियों का स्वचालित समाधान
- **CI/CD एकीकरण**: GitHub Actions/GitLab CI के लिए सुरक्षा गेट्स
- **कंटेनर स्कैनिंग**: इमेज कमजोरियों का विश्लेषण
- **सीक्रेट डिटेक्शन**: GitLeaks और TruffleHog एकीकरण

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

एडवांस्ड कंटेनर ऑप्टिमाइजेशन रणनीतियाँ।

- **स्मार्ट ऑप्टिमाइजेशन**: विश्लेषण करता है और सुधार सुझाता है
- **मल्टी-स्टेज बिल्ड्स**: फ्रेमवर्क-विशिष्ट ऑप्टिमाइज्ड Dockerfiles
- **आधुनिक टूल्स**: तेज बिल्ड के लिए BuildKit, Bun, UV
- **सुरक्षा सख्ती**: Distroless इमेज, गैर-रूट उपयोगकर्ता
- **क्रॉस-कमांड एकीकरण**: /api-scaffold आउटपुट्स के साथ कार्य करता है

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

प्रोडक्शन-ग्रेड Kubernetes डिप्लॉयमेंट्स।

- **एडवांस्ड पैटर्न्स**: Pod सुरक्षा मानक, नेटवर्क नीतियाँ, OPA
- **GitOps रेडी**: FluxCD और ArgoCD कॉन्फ़िगरेशन
- **ऑब्ज़र्वेबिलिटी**: Prometheus ServiceMonitors, OpenTelemetry
- **ऑटो-स्केलिंग**: HPA, VPA, और क्लस्टर ऑटोस्केलर कॉन्फ़िग्स
- **सर्विस मेष**: Istio/Linkerd एकीकरण

### फ्रंटएंड और डेटा

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

उन्नत डेटाबेस माइग्रेशन रणनीतियाँ।

- **मल्टी-डेटाबेस**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **शून्य-डाउनटाइम**: ब्लू-ग्रीन डिप्लॉयमेंट्स, रोलिंग माइग्रेशन
- **इवेंट सोर्सिंग**: CDC के लिए Kafka/Kinesis एकीकरण
- **क्रॉस-प्लेटफ़ॉर्म**: पॉलीग्लॉट परसिस्टेंस को संभालता है
- **मॉनिटरिंग**: माइग्रेशन हेल्थ चेक और रोलबैक

## वर्कफ्लो और टूल्स का संयोजन

असली शक्ति वर्कफ्लो और टूल्स को जोड़कर पूर्ण विकास चक्र बनाने में आती है:

### उदाहरण: नई विशेषता बनाना

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

### उदाहरण: विरासत कोड का आधुनिकीकरण

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

## कमांड ऑर्केस्ट्रेशन पैटर्न

कमांड्स को व्यक्तिगत रूप से या शक्तिशाली पैटर्न में संयोजित करके उपयोग किया जा सकता है:

### अनुक्रमिक निष्पादन
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### समानांतर विश्लेषण
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### पुनरावृत्त परिष्करण
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### क्रॉस-डोमेन एकीकरण
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## वर्कफ़्लो और टूल्स का उपयोग कब करें

### 🔀 वर्कफ़्लो & सबएजेंट टूल्स
- **समस्या समाधान**: मुद्दों का अनुकूलन करके विश्लेषण और समाधान करें
- **कई दृष्टिकोण**: विशेषज्ञ सबएजेंट्स का समन्वय करें
- **जटिल कार्य**: कई डोमेन में बहु-चरणीय प्रक्रियाएँ
- **अज्ञात समाधान**: सबएजेंट्स को तरीका तय करने दें

### 🛠️ विशिष्ट टूल्स
- **इन्फ्रास्ट्रक्चर सेटअप**: वातावरण को कॉन्फ़िगर करें
- **कोड जनरेशन**: विशिष्ट कार्यान्वयन बनाएं
- **विश्लेषण**: रिपोर्ट तैयार करें बिना सुधार के
- **डोमेन कार्य**: अत्यधिक विशिष्ट संचालन

**उदाहरण:**
- "यूज़र ऑथेंटिकेशन सिस्टम लागू करें" → `/workflows:feature-development`
- "स्टैक में प्रदर्शन समस्याएँ ठीक करें" → `/workflows:smart-fix`
- "लीगेसी मोनोलिथ को आधुनिक बनाएं" → `/workflows:legacy-modernize`

### 🔧 टूल्स का उपयोग कब करें:
- **विशेष विशेषज्ञता आवश्यक** - एक डोमेन में स्पष्ट, केंद्रित कार्य
- **सटीक नियंत्रण चाहिए** - विशिष्ट कार्यान्वयन विवरण निर्देशित करना है
- **मैन्युअल वर्कफ़्लो का हिस्सा** - मौजूदा प्रक्रियाओं में एकीकृत करना
- **गहरी विशेषज्ञता चाहिए** - विशेषज्ञ स्तर का कार्यान्वयन आवश्यक है
- **मौजूदा कार्य पर निर्माण** - पिछले आउटपुट को बढ़ाना या परिष्कृत करना

**उदाहरण:**
- "कुबेरनेट्स मैनिफेस्ट बनाएं" → `/tools:k8s-manifest`
- "सुरक्षा कमजोरियों के लिए स्कैन करें" → `/tools:security-scan`
- "एपीआई डोक्यूमेंटेशन जनरेट करें" → `/tools:doc-generate`

## कमांड प्रारूप

स्लैश कमांड साधारण मार्कडाउन फाइलें होती हैं जहाँ:
- फाइल का नाम कमांड नाम बन जाता है (जैसे, `tools/api-scaffold.md` → `/tools:api-scaffold`)
- फाइल की सामग्री वह प्रॉम्प्ट/निर्देश होते हैं जो कमांड के समय निष्पादित होते हैं
- उपयोगकर्ता इनपुट के लिए `$ARGUMENTS` प्लेसहोल्डर का उपयोग करें

## सर्वोत्तम प्रथाएँ

### कमांड चयन
- **ऑटोमेटिकली Claude Code से सुझाव लें** - संदर्भ का विश्लेषण करता है और सर्वोत्तम कमांड चुनता है
- **जटिल कार्यों के लिए वर्कफ़्लो का उपयोग करें** - उपएजेंट्स बहु-डोमेन कार्यान्वयन का समन्वय करते हैं
- **केंद्रित कार्यों के लिए टूल्स का उपयोग करें** - लक्षित सुधारों के लिए विशिष्ट कमांड लागू करें

### प्रभावी उपयोग
- **सम्पूर्ण संदर्भ प्रदान करें** - टेक स्टैक, सीमाएं और आवश्यकताएँ शामिल करें
- **कमांड्स को रणनीतिक रूप से जोड़ें** - वर्कफ़्लो → टूल्स → परिष्करण
- **पिछले आउटपुट पर निर्माण करें** - कमांड्स एक साथ काम करने के लिए डिज़ाइन किए गए हैं

## योगदान

1. `workflows/` या `tools/` में `.md` फ़ाइल बनाएं
2. लोअरकेस-हाइफ़न-नामों का प्रयोग करें
3. उपयोगकर्ता इनपुट के लिए `$ARGUMENTS` शामिल करें

## समस्या निवारण

**कमांड नहीं मिला**: 
- फ़ाइलें `~/.claude/commands/tools/` या `~/.claude/commands/workflows/` में हैं या नहीं जांचें
- सही उपसर्ग का उपयोग करें: `/tools:command-name` या `/workflows:command-name`
- या अगर बिना उपसर्ग पसंद है तो डायरेक्टरी फ्लैटन करें: `cp tools/*.md . && cp workflows/*.md .`

**वर्कफ़्लो धीमे हैं**: सामान्य है - वे कई उपएजेंट्स का समन्वय करते हैं

**सामान्य आउटपुट**: अपने टेक स्टैक के बारे में अधिक विशिष्ट संदर्भ जोड़ें

**इंटीग्रेशन समस्याएँ**: फ़ाइल पथ और कमांड अनुक्रम सत्यापित करें

## प्रदर्शन सुझाव

**कमांड चयन:**
- **वर्कफ़्लो**: जटिल फीचर्स के लिए बहु-उपएजेंट समन्वय
- **टूल्स**: विशिष्ट कार्यों के लिए एकल-उद्देश्य संचालन
- **सरल संपादन**: मुख्य एजेंट के साथ ही रहें

**ऑप्टिमाइज़ेशन:**
- ज्ञात समस्याओं के लिए टूल्स से शुरू करें
- शुरुआत में ही विस्तृत आवश्यकताएँ प्रदान करें
- पिछले कमांड आउटपुट्स पर निर्माण करें
- संशोधन से पहले वर्कफ़्लो को पूर्ण होने दें

### नया वर्कफ़्लो जोड़ना:
- सबएजेंट ऑर्केस्ट्रेशन और डेलीगेशन लॉजिक पर ध्यान दें
- किन विशिष्ट सबएजेंट्स का उपयोग करना है और किस क्रम में, निर्दिष्ट करें
- सबएजेंट्स के बीच समन्वय पैटर्न परिभाषित करें

### नया टूल जोड़ना:
- पूरी तरह से तैयार, प्रोडक्शन-रेडी इम्प्लीमेंटेशन शामिल करें
- सामग्री को स्पष्ट अनुभागों और कार्रवाई योग्य आउटपुट्स के साथ व्यवस्थित करें
- उदाहरण, सर्वोत्तम प्रथाएँ, और इंटीग्रेशन पॉइंट्स शामिल करें

## और अधिक जानें

- [Claude कोड डॉक्युमेंटेशन](https://docs.anthropic.com/en/docs/claude-code)
- [स्लैश कमांड्स डॉक्युमेंटेशन](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [सबएजेंट्स डॉक्युमेंटेशन](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude कोड GitHub](https://github.com/anthropics/claude-code)
- [Claude कोड सबएजेंट्स कलेक्शन](https://github.com/wshobson/agents) - इन कमांड्स द्वारा उपयोग किए जाने वाले विशिष्ट सबएजेंट्स


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---