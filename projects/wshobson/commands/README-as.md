
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# Claude Code Slash Commands

[Claude Code](https://docs.anthropic.com/en/docs/claude-code) ৰ বাবে প্ৰডাকশ্যন-ৰেডি স্লেশ কমাণ্ডসমূহ, যি বুদ্ধিমান স্বয়ংক্ৰিয়কৰণৰ জৰিয়তে উন্নয়ন তীব্ৰ কৰে।

**৫২টা কমাণ্ড** সংৰক্ষিত হৈছে:
- **🤖 ৱাৰ্কফ্ল’**: জটিল কাৰ্য্যৰ বাবে বহু-উপ-এজেন্ট সমন্বয়
- **🔧 টুলছ**: নিৰ্দিষ্ট কাৰ্য্যৰ বাবে এক-কামৰ সহায়ক উপকৰণ

### 🤝 Claude Code Subagents প্রয়োজন

এই কমাণ্ডসমূহ [Claude Code Subagents](https://github.com/wshobson/agents) ৰ সৈতে কাম কৰে, যাৰ দ্বাৰা সমন্বয়ৰ সক্ষমতা থাকে।

## ইনষ্টলেশ্যন

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## উপলব্ধ আদেশসমূহ

- **🤖 ৱৰ্কফ্ল’জ** - জটিল কামৰ বাবে বহুবিধ উপ-এজেন্ট সমন্বয় কৰক
- **🔧 সঁজুলি** - নিৰ্দিষ্ট কাৰ্যৰ বাবে একক উদ্দেশ্যৰ আদেশ

## ব্যৱহাৰ

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
ক্লড ক'ডে স্বতঃস্ফূর্তভাৱে প্ৰাসংগিক কমাণ্ডসমূহ পৰামৰ্শ দিয়ে পৰিপ্ৰেক্ষিতৰ আধাৰত।

## 🤖 ৱৰ্কফ্ল'চ

জটিল কামৰ বাবে বহু-সাবএজেন্ট অর্কেষ্ট্ৰেচন:

### ফিচাৰ ডেভেলপমেণ্ট
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - বেকএণ্ড, ফ্ৰণ্টএণ্ড, টেষ্টিং, আৰু ডিপ্লয়মেণ্ট সাবএজেন্টে সম্পূৰ্ণ ফিচাৰ নিৰ্মাণ কৰে
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - বহুতো ৰিভিউ সাবএজেন্টে বিস্তৃত ক'ড বিশ্লেষণ প্ৰদান কৰে
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - সমস্যাৰ বিশ্লেষণ কৰে আৰু উপযুক্ত বিশেষজ্ঞ সাবএজেন্টলৈ দায়িত্ব দিয়ে

### ডেভেলপমেণ্ট প্ৰক্ৰিয়া
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - শাখা কৌশল আৰু PR টেম্প্লেটসহ ফলপ্ৰসূ Git ৱৰ্কফ্ল' প্ৰয়োগ কৰে
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - প্ৰম্প্ট অপ্টিমাইজেশ্যনৰ জৰিয়তে সাবএজেন্টৰ কাৰ্যক্ষমতা বৃদ্ধি কৰে
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - বিশেষজ্ঞ সাবএজেন্ট ব্যৱহাৰ কৰি লিগেচী ক'ডবেচ আধুনিক কৰে
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - ডাটা আৰু ML ইঞ্জিনিয়াৰিং সাবএজেন্টৰ সৈতে ML পাইপলাইন সৃষ্টি কৰে
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - সমন্বিত সাবএজেন্টৰ সহায়ত বহু-প্লেটফৰ্ম এপ নিৰ্মাণ কৰে
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, মনিটৰিং, আৰু ডিপ্লয়মেণ্ট ৱৰ্কফ্ল' স্বয়ংক্ৰিয় কৰে

### সাবএজেন্ট-অর্কেষ্ট্ৰেটেড ৱৰ্কফ্ল'চ
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - বেকএণ্ড, ফ্ৰণ্টএণ্ড, আৰু ম'বাইল সাবএজেন্টসহ বহু-প্লেটফৰ্ম ফিচাৰ
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - বিশেষজ্ঞ সাবএজেন্টৰ সৈতে সুৰক্ষা-প্ৰথম ব্যৱস্থাপন
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ডাটা চায়েন্স সাবএজেন্টৰ সৈতে ML-চালিত ফিচাৰ
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - কাৰ্যক্ষমতা সাবএজেন্টৰ সৈতে সম্পূৰ্ণ অপ্টিমাইজেশ্যন
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - অপচ সাবএজেন্টৰ সহায়ত উৎপাদন ঘটনাৰ সমাধান

## 🔧 টুলছ (এক-উদ্দেশ্য কমাণ্ডসমূহ)

### AI & মেছিন লাৰ্নিং
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - উৎপাদন-উপযোগী AI সহায়ক আৰু চেটবট নিৰ্মাণ কৰক
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML ক'ডবেচৰ বাবে বিশেষায়িত ৰিভিউ
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - আধুনিক পেটাৰ্ণৰে LangChain/LangGraph এজেন্ট সৃষ্টি কৰক
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps সহ সম্পূৰ্ণ ML পাইপলাইন সৃষ্টি কৰক
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - কাৰ্যক্ষমতা আৰু গুণমানৰ বাবে AI প্ৰম্প্ট অপ্টিমাইজ কৰক

### স্থাপত্য & ক'ড গুণমান
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - জটিল ক'ডৰ বিস্তৃত ব্যাখ্যা সৃষ্টি কৰক
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - ভাষা, ফ্ৰেমৱর্ক, বা সংস্কৰণৰ মাজত ক'ড স্থানান্তৰ কৰক
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - ৰক্ষণাবেক্ষণ আৰু কাৰ্যক্ষমতাৰ বাবে ক'ড ৰিফেক্টৰ কৰক
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - প্ৰযুক্তিগত দেনা বিশ্লেষণ আৰু অগ্ৰাধিকাৰ দিয়ক

### ডাটা & ডাটাবেচ
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - স্কেলযোগ্য ডাটা পাইপলাইন স্থাপত্য ডিজাইন কৰক
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - বিস্তৃত ডাটা ভেলিডেচন ব্যৱস্থা প্ৰয়োগ কৰক
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - উন্নত ডাটাবেচ স্থানান্তৰ কৌশল

### ডেভঅপছ & অবকাঠামো
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - ডিপ্লয়মেণ্ট কনফিগাৰেচন আৰু চেকলিষ্ট সৃষ্টি কৰক
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - উন্নত কণ্টেইনাৰ অপ্টিমাইজেশ্যন কৌশল
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - উৎপাদন-উপযোগী Kubernetes ডিপ্লয়মেণ্ট
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - বিস্তৃত মনিটৰিং আৰু অৱজার্ভেবিলিটি স্থাপন কৰক
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Service Level Objectives (SLOs) প্ৰয়োগ কৰক
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - ডেভেলপমেণ্ট আৰু অপাৰেচনেল ৱৰ্কফ্ল' স্বয়ংক্ৰিয় কৰক

### ডেভেলপমেণ্ট & টেষ্টিং
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - ডেভেলপমেণ্ট আৰু টেষ্টিঙৰ বাবে বাস্তৱ API মক সৃষ্টি কৰক
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - সম্পূৰ্ণ ইমপ্লিমেণ্টেশ্যন ষ্টেকসহ উৎপাদন-উপযোগী API এণ্ডপইণ্ট সৃষ্টি কৰক
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - ফ্ৰেমৱর্ক চিনাক্তকৰণ সহ বিস্তৃত টেষ্ট ছুইট সৃষ্টি কৰক

### সুৰক্ষা & সামঞ্জস্যতা
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - বিস্তৃত এক্সেছিবিলিটি টেষ্টিং আৰু সংশোধন
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - নিয়ম-নীতি (GDPR, HIPAA, SOC2) নিশ্চিত কৰক
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - স্বয়ংক্ৰিয় সমাধানসহ বিস্তৃত সুৰক্ষা স্কেন

### ডিবাগিং & বিশ্লেষণ
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - উন্নত ডিবাগিং আৰু ট্ৰেছিং কৌশল
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - ত্ৰুটিৰ গভীৰ পেটাৰ্ণ বিশ্লেষণ আৰু সমাধান কৌশল
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - উৎপাদন ত্ৰুটি ট্ৰেছ আৰু নিৰ্ণয় কৰক
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - ভালদৰে গঠিত GitHub/GitLab ইশ্যু সৃষ্টি কৰক

### নিৰ্ভৰশীলতা & কনফিগাৰেচন
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - এপ্লিকেচন কনফিগাৰেচন যাচাই আৰু পৰিচালনা কৰক
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - নিৰ্ভৰশীলতাৰ সুৰক্ষা আৰু লাইচেঞ্চিংৰ বাবে অডিট কৰক
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - প্ৰকল্পৰ নিৰ্ভৰশীলতা নিৰাপদভাৱে উন্নীত কৰক

### ডকুমেণ্টেচন & সহযোগিতা
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - বিস্তৃত ডকুমেণ্টেচন সৃষ্টি কৰক
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - ফলপ্ৰসূ Git ৱৰ্কফ্ল' প্ৰয়োগ কৰক
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - গুণমান পৰীক্ষাসহ পুল ৰিকুৱেষ্ট উন্নত কৰক

### ব্যয় অপ্টিমাইজেশ্যন
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - ক্লাউড আৰু অবকাঠামো ব্যয় অপ্টিমাইজ কৰক

### অনবোর্ডিং & ছেটআপ
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - নতুন দলেৰ সদস্যৰ বাবে ডেভেলপমেণ্ট পৰিৱেশ স্থাপন কৰক

### সাবএজেন্ট টুলছ
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - বিশেষজ্ঞ সাবএজেন্টৰ সৈতে বহু-পৰিপ্ৰেক্ষিত ক'ড ৰিভিউ
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - ডিবাগাৰ আৰু কাৰ্যক্ষমতা সাবএজেন্টৰ সৈতে গভীৰ ডিবাগিং
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - বহুতো সাবএজেন্টৰ সৈতে সম্পূৰ্ণ ষ্টেক অপ্টিমাইজেশ্যন
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - context-manager সাবএজেন্ট ব্যৱহাৰ কৰি প্ৰকল্পৰ পৰিপ্ৰেক্ষিত সংৰক্ষণ কৰক
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - ধারাবাহিকতাৰ বাবে সংৰক্ষিত পৰিপ্ৰেক্ষিত পুনৰুদ্ধাৰ কৰক

## ফিচাৰসমূহ

- উৎপাদন-উপযোগী ইমপ্লিমেণ্টেশ্যনসমূহ
- ফ্ৰেমৱর্ক স্বয়ংক্ৰিয় চিনাক্তকৰণ
- সুৰক্ষাৰ সৰ্বোত্তম অনুশীলনসমূহ
- অন্তৰ্নিহিত মনিটৰিং আৰু টেষ্টিং

- নিৰ্দেশসমূহে একেলগে নিৰৱচ্ছিন্নভাৱে কাম কৰে

## নিৰ্দেশনা গণনা

**মুঠ: ৫২ টা উৎপাদনৰ বাবে সাজু থকা ছ্লাশ কমাণ্ড** তলত সংগঠিত:

### 🤖 ৱাৰ্কফ্ল' (১৪ টা নিৰ্দেশনা)

- ফিচাৰ ডেভেলপমেণ্ট আৰু ৰিভিউ (৩ টা নিৰ্দেশনা)
- ডেভেলপমেণ্ট প্ৰক্ৰিয়া স্বয়ংক্ৰিয়কৰণ (৬ টা নিৰ্দেশনা)
- ছাবএজেণ্ট-সমন্বিত ৱাৰ্কফ্ল' (৫ টা নিৰ্দেশনা)

### 🔧 টুলছ (৩৮ টা নিৰ্দেশনা)

- AI & মেচিন লাৰ্নিং (৫ টা নিৰ্দেশনা)
- আৰ্হি & ক'ড গুণ (৪ টা নিৰ্দেশনা)
- ডাটা & ডেটাবেছ (৩ টা নিৰ্দেশনা)
- ডেভঅ'পছ & ইনফ্ৰাস্ট্ৰাকচাৰ (৬ টা নিৰ্দেশনা)
- ডেভেলপমেণ্ট & টেষ্টিং (৩ টা নিৰ্দেশনা)
- ছিকিউৰিটি & কমপ্লায়েঞ্চ (৩ টা নিৰ্দেশনা)
- ডিবাগিং & বিশ্লেষণ (৪ টা নিৰ্দেশনা)
- ডিপেণ্ডেন্সি & কনফিগাৰেচন (৩ টা নিৰ্দেশনা)
- ডকুমেণ্টেচন & সহযোগিতা (১ টা নিৰ্দেশনা)
- অনব'ৰ্ডিং & ছেটআপ (১ টা নিৰ্দেশনা)
- ছাবএজেণ্ট-নির্দিষ্ট টুলছ (৫ টা নিৰ্দেশনা)

## ব্যৱহাৰৰ উদাহৰণ

### 🤖 ৱাৰ্কফ্ল'ৰ উদাহৰণ

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

### 🔧 টুলৰ উদাহৰণসমূহ (একমাত্ৰ উদ্দেশ্যৰ আদেশ)

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

## উন্নত আদেশসমূহ

### সুৰক্ষা আৰু ডেভঅপছ

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

স্বয়ংক্ৰিয় সমাধান সহ বিস্তৃত সুৰক্ষা স্কেনিং।

- **বহু-সঁজুলি স্কেনিং**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **স্বয়ংক্ৰিয় সমাধান**: সাধাৰণ দুর্বলতাসমূহ স্বয়ংক্ৰিয়ভাৱে সমাধান কৰা হয়
- **CI/CD সংহতি**: GitHub Actions/GitLab CI-ৰ বাবে সুৰক্ষা গেট
- **কণ্টেইনাৰ স্কেনিং**: ইমেজ দুর্বলতা বিশ্লেষণ
- **গোপনীয়তা চিনাক্তকৰণ**: GitLeaks আৰু TruffleHog সংহতি

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

উন্নত কণ্টেইনাৰ অপ্টিমাইজেশ্যন কৌশল।

- **চতুৰ অপ্টিমাইজেশ্যন**: বিশ্লেষণ কৰে আৰু উন্নতিৰ পৰামৰ্শ দিয়ে
- **বহু-স্তৰীয় নিৰ্মাণ**: ফ্ৰেমৱৰ্ক-নির্দিষ্ট অপ্টিমাইজ Dockerfile
- **আধুনিক সঁজুলি**: BuildKit, Bun, UV-এ দ্রুত নিৰ্মাণৰ বাবে
- **সুৰক্ষা দৃঢ়ীকৰণ**: Distroless ইমেজ, non-root ব্যৱহাৰকাৰী
- **আদেশ সংহতি**: /api-scaffold আউটপুটৰ সৈতে কাম কৰে

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

উৎপাদন-স্তৰৰ Kubernetes ডিপ্লয়মেন্ট।

- **উন্নত প্যাটাৰ্ণ**: Pod Security Standards, Network Policies, OPA
- **GitOps-Redy**: FluxCD আৰু ArgoCD কনফিগাৰেচন
- **পৰ্যবেক্ষণযোগ্যতা**: Prometheus ServiceMonitors, OpenTelemetry
- **স্বয়ং-স্কেলিং**: HPA, VPA, আৰু ক্লাষ্টাৰ autoscaler কনফিগ
- **Service Mesh**: Istio/Linkerd সংহতি

### ফ্ৰণ্টএণ্ড আৰু ডাটা

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

উন্নত ডেটাবেচ মাইগ্ৰেশ্যন কৌশল।

- **বহু-ডেটাবেচ**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **শূন্য-ডাউনটাইম**: Blue-green ডিপ্লয়মেন্ট, rolling migration
- **ইভেন্ট সোর্সিং**: CDC-ৰ বাবে Kafka/Kinesis সংহতি
- **Cross-Platform**: Polyglot persistence সমলায়
- **মনিটৰিং**: মাইগ্ৰেশ্যন স্বাস্থ্য পৰীক্ষা আৰু rollback

## ৱাৰ্কফ্ল’ আৰু সঁজুলিৰ সংহতি

পূর্ণ বিকাশ চক্রৰ বাবে ৱাৰ্কফ্ল’ আৰু সঁজুলিৰ সংহতিৰ আসল শক্তি:

### উদাহৰণ: নতুন ফিচাৰ নিৰ্মাণ

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

### উদাহৰণ: লিগেচী ক'ড আধুনিকীকৰণ

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

## কমাণ্ড অৰ্কেষ্ট্ৰেছন পেটাৰ্নসমূহ

কমাণ্ডসমূহ এককভাৱে ব্যৱহাৰ কৰিব পাৰি বা শক্তিশালী পেটাৰ্নত সংযোগ কৰিব পাৰি:

### অনুক্ৰমিক কাৰ্য্যন্বয়
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### সমান্তৰাল বিশ্লেষণ
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### পৰ্যায়ক্রমে সংশোধন
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### আন্ত-ডোমেইন সমন্বয়
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## কেতিয়া ৱাৰ্কফ্ল' বনাম টুল ব্যৱহাৰ কৰিব

### 🔀 ৱাৰ্কফ্ল' & চাব-এজেন্ট টুলসমূহ
- **সমস্যা-সমাধান**: পৰিস্থিতিৰ ওপৰত ভিত্তি কৰি সমস্যা বিশ্লেষণ আৰু সমাধান
- **বহু দৃষ্টিভংগী**: বিশেষজ্ঞ চাব-এজেন্টসমূহৰ সমন্বয় সাধন
- **জটিল কাম**: একাধিক ধাপৰ প্ৰক্ৰিয়া, বহু ড’মেইনত
- **অজ্ঞাত সমাধান**: চাব-এজেন্টসমূহক পদ্ধতি নিৰ্ধাৰণ কৰিবলৈ দিয়ক

### 🛠️ বিশেষ টুলসমূহ
- **ইনফ্ৰাষ্ট্ৰাকচাৰ ছেটআপ**: পৰিবেশ কনফিগাৰ কৰা
- **ক'ড জেনেৰেচন**: নিৰ্দিষ্ট ইমপ্লিমেণ্টেচন সৃষ্টি কৰা
- **বিশ্লেষণ**: মাৰামতি নকৰাকৈ ৰিপৰ্ট উৎপাদন
- **ড’মেইন টাস্ক**: অতি বিশেষজ্ঞ অপাৰেশ্যনসমূহ

**উদাহৰণসমূহ:**
- "ইউজাৰ অথেণ্টিকেচন ছিষ্টেম ইমপ্লিমেণ্ট কৰক" → `/feature-development`
- "ষ্টেক জুৰি পাৰফৰ্মেন্স সমস্যা সমাধান কৰক" → `/smart-fix`
- "লিগেচি মন’লিথ আধুনিক কৰক" → `/legacy-modernize`

### 🔧 টুল ব্যৱহাৰ কৰক কেতিয়া:
- **বিশেষজ্ঞ জ্ঞানৰ প্ৰয়োজন** - এটা ড’মেইনত স্পষ্ট, কেন্দ্ৰীভূত কাম
- **নিয়ন্ত্ৰণৰ প্ৰয়োজন** - নিৰ্দিষ্ট ইমপ্লিমেণ্টেচন ডিটেইল নিৰ্দেশনা দিব বিচৰা
- **ম্যানুৱেল ৱাৰ্কফ্ল' অংশ** - বিদ্যমান প্ৰক্ৰিয়াত সংহত
- **গভীৰ বিশেষীকৰণ** - বিশেষজ্ঞ-স্তৰৰ ইমপ্লিমেণ্টেচন দৰকাৰ
- **বিদ্যমান কামত উন্নতি** - আগৰ আউটপুট উন্নত/সংশোধন

**উদাহৰণসমূহ:**
- "Kubernetes manifest বনাওক" → `/k8s-manifest`
- "Security vulnerability স্কেন কৰক" → `/security-scan`
- "API documentation জেনেৰেট কৰক" → `/doc-generate`

## কমাণ্ড ফৰ্মেট

Slash কমাণ্ড হৈছে সাধাৰণ মাৰ্কডাউন ফাইল, য'ত:
- ফাইলনেমটো কমাণ্ড নাম হয় (উদা: `api-scaffold.md` → `/api-scaffold`)
- ফাইলৰ ভিতৰৰটো হৈছে প্ৰম্পট/নির্দেশনা যি এক্সিকিউট হয়
- `$ARGUMENTS` প্লেচহোল্ডাৰ ব্যৱহাৰ কৰক ইউজাৰ ইনপুটৰ বাবে

## শ্ৰেষ্ঠ অনুশীলন

### কমাণ্ড বাছনি
- **Claude Code-এ সজাকৈ বাছি দিব** - পৰিপ্ৰেক্ষিত বিশ্লেষণ কৰি উত্তম কমাণ্ড নিৰ্বাচন কৰে
- **জটিল কামৰ বাবে ৱাৰ্কফ্ল' ব্যৱহাৰ কৰক** - চাব-এজেন্টে বহু-ড’মেইন ইমপ্লিমেণ্টেচন সমন্বয় কৰে
- **লক্ষ্যভেদী কামৰ বাবে টুল ব্যৱহাৰ কৰক** - নিৰ্দিষ্ট উন্নতিৰ বাবে স্পষ্ট কমাণ্ড প্ৰয়োগ কৰক

### কার্যকৰী ব্যৱহাৰ
- **সম্পূৰ্ণ পৰিপ্ৰেক্ষিত দিয়ক** - টেক ষ্টেক, সীমাবদ্ধতা, আৰু প্ৰয়োজনীয়তা অন্তর্ভুক্ত কৰক
- **কৌশলগতভাৱে কমাণ্ড চেইন কৰক** - ৱাৰ্কফ্ল' → টুল → সংশোধন
- **আগৰ আউটপুটৰ ওপৰত নিৰ্মাণ কৰক** - কমাণ্ডসমূহ ইন্টেগ্ৰেচনৰ বাবে ডিজাইন কৰা

## অৱদান আগবঢ়োৱা

1. `workflows/` বা `tools/`-ত `.md` ফাইল সৃষ্টি কৰক
2. লোয়াৰকেছ-হাইফেন-নেম ব্যৱহাৰ কৰক
3. ইউজাৰ ইনপুটৰ বাবে `$ARGUMENTS` অন্তর্ভুক্ত কৰক

## সমস্যাৰ সমাধান

**কমাণ্ড পোৱা নগ'ল**: ফাইলসমূহ `~/.claude/commands/`-ত আছে নেকি চাওক

**ৱাৰ্কফ্ল' ধীৰ**: স্বাভাবিক - বহু চাব-এজেন্ট সমন্বয় কৰে

**সাধাৰণ আউটপুট**: আপোনাৰ টেক ষ্টেকৰ অধিক স্পষ্ট তথ্য যোগ কৰক

**ইন্টেগ্ৰেচন সমস্যা**: ফাইল পথ আৰু কমাণ্ড অনুক্ৰম যাচাই কৰক

## কাৰ্যক্ষমতা টিপছ

**কমাণ্ড বাছনি:**
- **ৱাৰ্কফ্ল'**: জটিল ফিচাৰৰ বাবে বহু চাব-এজেন্ট সমন্বয়
- **টুল**: নিৰ্দিষ্ট কামৰ বাবে একমাত্ৰ উদ্দেশ্য
- **সহজ সম্পাদনা**: মুখ্য এজেন্টৰ সৈতে থাকক

**অপ্টিমাইজেচন:**
- জনা সমস্যা থাকিলে টুলৰ পৰা আৰম্ভ কৰক
- আৰম্ভণিতেই বিস্তৃত প্ৰয়োজনীয়তা দিয়ক
- আগৰ কমাণ্ড আউটপুটৰ ওপৰত নিৰ্মাণ কৰক
- সংশোধন আগতে ৱাৰ্কফ্ল' সম্পূৰ্ণ হ’ব দিয়া

### নতুন ৱাৰ্কফ্ল' যোগ কৰা:
- চাব-এজেন্ট অর্কেষ্ট্ৰেচন আৰু ডেলিগেশ্যন লজিকত কেন্দ্ৰীভূত থাকক
- কোন বিশেষ চাব-এজেন্ট ব্যৱহাৰ কৰিব আৰু ক্ৰমানুসাৰী কি হ’ব নিৰ্ধাৰণ কৰক
- চাব-এজেন্টসমূহৰ মাজত সমন্বয় পেটাৰ্ন সংজ্ঞায়িত কৰক

### নতুন টুল যোগ কৰা:
- সম্পূৰ্ণ, প্ৰডাকশ্যন-ৰেডি ইমপ্লিমেণ্টেচনসমূহ অন্তর্ভুক্ত কৰক
- স্পষ্ট বিভাগ আৰু কাৰ্যকৰী আউটপুটৰ সৈতে সামগ্ৰী গঠন কৰক
- উদাহৰণ, শ্ৰেষ্ঠ অনুশীলন, আৰু ইন্টেগ্ৰেচন পইণ্ট অন্তর্ভুক্ত কৰক

## অধিক জানক

- [Claude Code Documentation](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Commands Documentation](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Subagents Documentation](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) - এই কমাণ্ডসমূহত ব্যৱহৃত বিশেষ চাব-এজেন্টসমূহ



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---