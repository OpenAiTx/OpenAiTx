
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

[Claude Code](https://docs.anthropic.com/en/docs/claude-code) ৰ বাবে উৎপাদন-প্ৰস্তুত slash command সমূহ, যি বুদ্ধিমান স্বচালিতকৰণৰ জৰিয়তে উন্নয়নক দ্ৰুত কৰে।

**৫২টা কমাণ্ড** তলত সংগঠিত:
- **🤖 ৱাৰ্কফ্ল'**: জটিল কামৰ বাবে বহু-উপ-এজেন্ট সমন্বয়
- **🔧 টুল**: নিৰ্দিষ্ট কাৰ্যৰ বাবে একক-উদ্দেশ্যৰ সহায়ক

### 🤝 ক্ল'ড ক'ড ছাবএজেন্টৰ প্ৰয়োজন

এই আদেশসমূহ [ক্ল'ড ক'ড ছাবএজেন্ট](https://github.com/wshobson/agents)ৰ সৈতে সমন্বয় ক্ষমতাৰ বাবে কাম কৰে।

## স্থাপন

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## উপলব্ধ আজ্ঞাসমূহ

- **🤖 ৱাৰ্কফ্ল’চ** - জটিল কাৰ্যৰ বাবে বহু উপ-এজেন্ট সমন্বয় কৰক
- **🔧 টুলছ** - নিৰ্দিষ্ট অপাৰেশ্যনৰ বাবে এক-মুখী আজ্ঞা

## ব্যৱহাৰ

আজ্ঞাসমূহ `tools/` আৰু `workflows/` ডাইৰেক্টৰীত সংগঠিত। ডাইৰেক্টৰীৰ প্ৰিফিক্সৰ সৈতে ব্যৱহাৰ কৰক:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**টোকা:** যদি আপুনি প্ৰিফিক্স নোহোৱাকৈ কমাণ্ড ব্যৱহাৰ কৰিবলৈ পচন্দ কৰে, তেন্তে আপুনি ডিৰেক্টৰীসমূহ ফ্লেটেন কৰিব পাৰে:
```bash
cp tools/*.md .
cp workflows/*.md .
```
ক্লড ক'ডে স্বয়ংক্ৰিয়ভাৱে প্ৰাসংগিক কমাণ্ডসমূহ পৰিপ্ৰেক্ষিত অনুসৰি প্ৰস্তাৱ কৰে।

## 🤖 ৱৰ্কফ্ল'সমূহ

জটিল কাৰ্যৰ বাবে বহু-উপ-এজেন্ট সমন্বয়:

### ফিচাৰ বিকাশ
- **[ফিচাৰ-বিকাশ](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - বেকএণ্ড, ফ্ৰন্টএণ্ড, পৰীক্ষা, আৰু ডিপ্লয়মেন্ট উপ-এজেন্টে সম্পূৰ্ণ ফিচাৰ নিৰ্মাণ কৰে
- **[সম্পূৰ্ণ-সমীক্ষা](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - বহুবিধ সমীক্ষা উপ-এজেন্টে বিস্তৃত ক'ড বিশ্লেষণ প্ৰদান কৰে
- **[চতুৰ-সমাধান](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - সমস্যাসমূহ বিশ্লেষণ কৰি উপযুক্ত বিশেষজ্ঞ উপ-এজেন্টলৈ প্ৰেৰণ কৰে

### বিকাশ প্ৰক্ৰিয়া
- **[গিট-ৱৰ্কফ্ল'](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - শাখা কৌশল আৰু PR টেম্পলেটৰ সৈতে কাৰ্যকৰী Git ৱৰ্কফ্ল' কাৰ্যকৰী কৰে
- **[এজেন্ট-উন্নয়ন](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - প্ৰম্পট অপ্টিমাইজেশনৰ দ্বাৰা উপ-এজেন্টৰ কার্যক্ষমতা বৃদ্ধি কৰে
- **[লেগাচি-আধুনিকীকৰণ](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - বিশেষ উপ-এজেন্ট ব্যৱহাৰ কৰি লেগাচি ক'ডবেছ আধুনিকীকৰণ কৰে
- **[এমএল-পাইপলাইন](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - ডাটা আৰু এমএল ইঞ্জিনিয়াৰ উপ-এজেন্টৰে এমএল পাইপলাইন সৃষ্টি কৰে
- **[বহু-প্লেটফৰ্ম](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - সমন্বিত উপ-এজেন্টৰ সৈতে ক্রছ-প্লেটফৰ্ম এপ নির্মাণ কৰে
- **[ৱৰ্কফ্ল'-স্বয়ংক্ৰিয়](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, মনিটৰিং, আৰু ডিপ্লয়মেন্ট ৱৰ্কফ্ল' স্বয়ংক্ৰিয় কৰে

### উপ-এজেন্ট-সমন্বিত ৱৰ্কফ্ল'
- **[সম্পূৰ্ণ-ষ্টেক-ফিচাৰ](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - বেকএণ্ড, ফ্ৰন্টএণ্ড, আৰু ম'বাইল উপ-এজেন্টৰ সৈতে বহু-প্লেটফৰ্ম ফিচাৰ
- **[নিরাপত্তা-শক্তিশালীকৰণ](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - বিশেষ উপ-এজেন্টৰ সৈতে নিৰাপত্তা-প্ৰথম বাস্তৱায়ন
- **[ডাটা-ভিত্তিক-ফিচাৰ](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ডাটা বিজ্ঞান উপ-এজেন্টৰ সৈতে এমএল-চালিত ফিচাৰ
- **[দক্ষতা-অপ্টিমাইজেশ্বন](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - দক্ষতা উপ-এজেন্টৰ সৈতে সম্পূৰ্ণ অপ্টিমাইজেশ্বন
- **[ঘটনা-প্ৰতিক্ৰিয়া](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - অপ্স উপ-এজেন্টৰে প্ৰডাকশ্যন ঘটনা সমাধান

## 🔧 টুল (একমাত্ৰ উদ্দেশ্যৰ কমাণ্ড)

### AI & মেচিন লাৰ্নিং
- **[AI-সহায়ক](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - প্ৰডাকশ্যন-তৈয়াৰী AI সহায়ক আৰু চাটবট নিৰ্মাণ কৰক
- **[AI-সমীক্ষা](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML ক'ডবেছৰ বাবে বিশেষ সমীক্ষা
- **[ল্যাংচেইন-এজেন্ট](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - আধুনিক পেটাৰ্নৰে LangChain/LangGraph এজেন্ট সৃষ্টি কৰক
- **[এমএল-পাইপলাইন](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps সহ সম্পূৰ্ণ এমএল পাইপলাইন সৃষ্টি কৰক
- **[প্ৰম্পট-অপ্টিমাইজ](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - কার্যক্ষমতা আৰু গুণগত মানৰ বাবে AI প্ৰম্পট অপ্টিমাইজ কৰক

### স্থাপত্য & ক'ড গুণমান
- **[ক'ড-ব্যাখ্যা](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - জটিল ক'ডৰ বিস্তৃত ব্যাখ্যা উত্পন্ন কৰক
- **[ক'ড-মাইগ্ৰেট](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - ভাষা, ফ্ৰেমৱাৰ্ক, অথবা সংস্কৰণৰ মাজত ক'ড স্থানান্তৰ কৰক
- **[পুনঃগঠন-স্বচ্ছ](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - ৰক্ষণাবেক্ষণযোগ্যতা আৰু কার্যক্ষমতাৰ বাবে ক'ড পুনঃগঠন কৰক

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - প্ৰযুক্তিগত ঋণ বিশ্লেষণ আৰু প্ৰাধান্য দিয়ক

### ডাটা & ডাটাবেইচ
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - বিস্তৃত ডাটা পাইপলাইন স্থাপত্য ডিজাইন কৰক
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - বিস্তৃত ডাটা বৈধতা ব্যৱস্থা প্ৰয়োগ কৰক
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - উন্নত ডাটাবেইচ মাইগ্ৰেশ্যন কৌশল

### ডেভঅপ্স & অবকাঠামো
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - ডিপ্লয়মেন্ট কনফিগাৰেচন আৰু চেকলিষ্ট তৈয়াৰ কৰক
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - উন্নত কণ্টেইনাৰ অপ্টিমাইজেশ্যন কৌশল
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - প্ৰডাকশ্যন-গ্ৰেড কুবাৰনেটিছ ডিপ্লয়মেন্ট
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - বিস্তৃত মনিটৰিং আৰু অভিজ্ঞান স্থাপন কৰক
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - সেৱা স্তৰ উদ্দেশ্য (SLOs) প্ৰয়োগ কৰক
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - উন্নয়ন আৰু অপাৰেচনেল ৱৰ্কফ্ল’ স্বয়ংক্ৰিয় কৰক

### উন্নয়ন & পৰীক্ষণ
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - উন্নয়ন আৰু পৰীক্ষণৰ বাবে বাস্তব API মক সৃষ্টি কৰক
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - সম্পূৰ্ণ ইম্প্লিমেণ্টেশ্যন ষ্টেকৰ সৈতে প্ৰডাকশ্যন-প্ৰস্তুত API এণ্ডপইণ্ট সৃষ্টি কৰক
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - ফ্ৰেমৱৰ্ক চিনাক্তকৰণৰ সৈতে বিস্তৃত টেষ্ট ছুইট সৃষ্টি কৰক

### নিৰাপত্তা & অনুগত্য
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - বিস্তৃত প্রবেশযোগ্যতা পৰীক্ষণ আৰু সংশোধন
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - বিধিমালাৰ অনুগত্য নিশ্চিত কৰক (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - স্বয়ংক্ৰিয় সংশোধনৰ সৈতে বিস্তৃত নিৰাপত্তা স্কেনিং

### ডিবাগিং & বিশ্লেষণ
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - উন্নত ডিবাগিং আৰু ট্রেছিং কৌশল
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - ত্ৰুটি পেটাৰ্ণৰ গভীৰ বিশ্লেষণ আৰু সমাধান কৌশল
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - প্ৰডাকশ্যন ত্ৰুটি অনুসন্ধান আৰু নিৰ্ণয় কৰক
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - সু-সংগঠিত GitHub/GitLab ইশ্যু সৃষ্টি কৰক

### নিৰ্ভৰশীলতা & কনফিগাৰেচন
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - এপ্লিকেশ্যন কনফিগাৰেচন বৈধতা আৰু পৰিচালনা কৰক
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - নিৰাপত্তা আৰু লাইচেন্সিংৰ বাবে নিৰ্ভৰশীলতা পৰীক্ষা কৰক
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - প্ৰকল্পৰ নিৰ্ভৰশীলতা নিৰাপদভাৱে আপগ্ৰেড কৰক

### ডকুমেণ্টেচন & সহযোগিতা
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - বিস্তৃত ডকুমেন্টেচন তৈয়াৰ কৰক
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - কার্যকরী Git ৱৰ্কফ্ল’ প্ৰয়োগ কৰক
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - গুণগত মান পৰীক্ষাৰ সৈতে পুল ৰিকুৱেষ্ট উন্নত কৰক

### ব্যয় অপ্টিমাইজেশন
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - ক্লাউড আৰু ইনফ্ৰাস্ট্ৰাকচাৰ ব্যয় অপ্টিমাইজ কৰক

### অনবোর্ডিং আৰু ছেটআপ
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - নতুন দলৰ সদস্যৰ বাবে উন্নয়ন পৰিৱেশ ছেটআপ কৰক

### চাব-এজেন্ট টুলসমূহ
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - বিশেষ চাব-এজেন্টৰ সৈতে বহুমুখী কোড পৰ্যালোচনা
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - ডিবাগাৰ আৰু পাৰফৰ্মেন্স চাব-এজেন্টৰ সৈতে গভীৰ ডিবাগিং
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - একাধিক চাব-এজেন্টৰ সৈতে সম্পূৰ্ণ-ষ্টেক অপ্টিমাইজেশন
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - প্ৰজেক্টৰ প্ৰসংগ চাব-এজেন্ট ব্যৱহাৰ কৰি সংৰক্ষণ কৰক
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - ধাৰাবাহিকতাৰ বাবে সংৰক্ষিত প্ৰসংগ পুনৰুদ্ধাৰ কৰক

## বৈশিষ্ট্যসমূহ

- উৎপাদন-প্ৰস্তুত কাৰ্য্যন্বয়
- ফ্ৰেমৱৰ্ক স্বয়ং-চিনাক্তকৰণ
- নিৰাপত্তা শ্রেষ্ঠ অনুশীলনসমূহ
- অন্তর্নিহিত মনিটৰিং আৰু পৰীক্ষা
- কমাণ্ডসমূহ সুশৃঙ্খলভাৱে একেলগে কাম কৰে

## কমাণ্ডৰ সংখ্যা

**মুঠ: ৫২টা উৎপাদন-প্ৰস্তুত স্লেশ কমাণ্ড** সংগঠিত হৈছে:

### 🤖 ৱৰ্কফ্ল’ (১৪টা কমাণ্ড)

- বৈশিষ্ট্য উন্নয়ন আৰু পৰ্যালোচনা (৩টা কমাণ্ড) 
- উন্নয়ন প্ৰক্ৰিয়া স্বয়ংক্ৰিয়কৰণ (৬টা কমাণ্ড)
- চাব-এজেন্ট দ্বাৰা সংগঠিত ৱৰ্কফ্ল’ (৫টা কমাণ্ড)

### 🔧 টুলসমূহ (৩৮টা কমাণ্ড)

- AI & মেচিন লাৰ্নিং (৫টা কমাণ্ড)
- স্থাপত্য আৰু কোড গুণ (৪টা কমাণ্ড)
- ডাটা আৰু ডেটাবেজ (৩টা কমাণ্ড)
- ডেভঅপছ আৰু ইনফ্ৰাস্ট্ৰাকচাৰ (৬টা কমাণ্ড)
- উন্নয়ন আৰু পৰীক্ষা (৩টা কমাণ্ড)
- নিৰাপত্তা আৰু সংহতি (৩টা কমাণ্ড)
- ডিবাগিং আৰু বিশ্লেষণ (৪টা আদেশ)
- নিৰ্ভৰশীলতা আৰু কনফিগাৰেচন (৩টা আদেশ)
- নথিপত্ৰ আৰু সহযোগিতা (১টা আদেশ)
- অনবোর্ডিং আৰু ছেটআপ (১টা আদেশ)
- সাবএজেন্ট-নির্দিষ্ট টুলছ (৫টা আদেশ)

## ব্যৱহাৰৰ উদাহৰণ

### 🤖 ৱৰ্কফ্ল' উদাহৰণ

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

### 🔧 টুলৰ উদাহৰণসমূহ (একমাত্ৰ উদ্দেশ্যৰ আদেশ)

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

## উন্নত কমাণ্ডসমূহ

### সুৰক্ষা আৰু ডেভঅপছ

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

স্বয়ংক্ৰিয় সমাধানসহ বিস্তৃত সুৰক্ষা স্কেনিং।

- **বহু-টুল স্কেনিং**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **স্বয়ংক্ৰিয় সমাধান**: সাধাৰণ দুর্বলতাৰ স্বয়ংক্ৰিয় সমাধান
- **CI/CD সংহতি**: GitHub Actions/GitLab CI-ৰ বাবে সুৰক্ষা গেট
- **কণ্টেইনাৰ স্কেনিং**: ইমেজ দুর্বলতা বিশ্লেষণ
- **গোপন তথ্য সনাক্তকৰণ**: GitLeaks আৰু TruffleHog সংহতি

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

উন্নত কণ্টেইনাৰ অপ্টিমাইজেশ্বন কৌশলসমূহ।

- **স্মাৰ্ট অপ্টিমাইজেশ্বন**: বিশ্লেষণ কৰি উন্নতিৰ পৰামৰ্শ দিয়ে
- **বহু-স্তৰীয় বিল্ড**: ফ্ৰেমৱৰ্ক-নির্দিষ্ট অপ্টিমাইজ Dockerfile
- **আধুনিক টুল**: BuildKit, Bun, UV-ৰ দ্বাৰা দ্ৰুত বিল্ড
- **সুৰক্ষা বৃদ্ধি**: Distroless image, non-root ব্যৱহাৰকাৰী
- **Cross-Command সংহতি**: /api-scaffold আউটপুটৰ সৈতে কাম কৰে

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

উৎপাদন-স্তৰৰ Kubernetes ডিপ্লয়মেন্ট।

- **উন্নত প্যাটাৰ্ন**: Pod Security Standards, Network Policies, OPA
- **GitOps প্ৰস্তুত**: FluxCD আৰু ArgoCD কনফিগাৰেশন
- **অবজাৰ্ভেবিলিটি**: Prometheus ServiceMonitor, OpenTelemetry
- **স্বয়ংক্ৰিয় স্কেলিং**: HPA, VPA, আৰু cluster autoscaler কনফিগ
- **Service Mesh**: Istio/Linkerd সংহতি

### ফ্ৰণ্টএণ্ড আৰু ডাটা

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

উন্নত ডেটাবেজ মাইগ্ৰেশন কৌশলসমূহ।

- **বহুৰূপী ডাটাবেছ**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **শূন্য-ডাউনটাইম**: ব্লু-গ্ৰীণ ডিপ্লয়মেণ্ট, ৰোলিং মাইগ্ৰেশ্যন
- **ইভেন্ট সোর্সিং**: CDC ৰ বাবে Kafka/Kinesis সংহতি
- **ক্ৰছ-প্লেটফৰ্ম**: পলিগ্লট পৰ্সিষ্টেন্স সম্বোধন কৰে
- **মনিটৰিং**: মাইগ্ৰেশ্যন স্বাস্থ্য পৰীক্ষা আৰু ৰোলবেক

## ৱাৰ্কফ্ল' আৰু টুলৰ সংমিশ্ৰণ

বাস্তৱিক শক্তি আহে পূৰ্ণ বিকাশ চক্রৰ বাবে ৱাৰ্কফ্ল' আৰু টুলৰ সংমিশ্ৰণৰ পৰা:

### উদাহৰণ: এটা নতুন ফিচাৰ নিৰ্মাণ

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

### উদাহৰণ: লিগেচী ক'ড আধুনিকীকৰণ

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

## কমাণ্ড অৰ্কেষ্ট্ৰেছন পেটাৰ্নসমূহ

কমাণ্ডসমূহ এককভাৱে ব্যৱহাৰ কৰিব পাৰি বা শক্তিশালী পেটাৰ্নত সংযোগ কৰিব পাৰি:

### অনুক্ৰমিক কাৰ্য্যন্বয়
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### সমান্তৰাল বিশ্লেষণ
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### পৰ্যায়ক্রমে সংশোধন
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### আন্ত-ডোমেইন সমন্বয়
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## ৱৰ্কফ্ল' আৰু টুল ব্যৱহাৰৰ সময়

### 🔀 ৱৰ্কফ্ল' & উপ-এজেণ্ট টুল
- **সমস্যা সমাধান**: অভিযোজিতভাৱে সমস্যা বিশ্লেষণ আৰু সমাধান কৰক
- **বহু দৃষ্টিভংগী**: বিশেষজ্ঞ উপ-এজেণ্ট সমন্বয় কৰক
- **জটিল কাৰ্য**: বহুত ধাপৰ প্ৰক্ৰিয়া, বহুমুখী ক্ষেত্ৰত
- **অজ্ঞাত সমাধান**: উপ-এজেণ্টে পদ্ধতি নিৰ্ধাৰণ কৰক

### 🛠️ বিশেষ টুল
- **ইনফ্ৰাস্ট্ৰাকচাৰ ছেটআপ**: পৰিৱেশ সংৰচনা কৰক
- **ক'ড সৃষ্টি**: নিৰ্দিষ্ট ইমপ্লিমেণ্টেশ্যন তৈয়াৰ কৰক
- **বিশ্লেষণ**: কেৱল ৰিপ'ৰ্ট উৎপাদন, সমাধান নহয়
- **ডোমেইন কাৰ্য**: অতি বিশেষজ্ঞ অপাৰেশ্যন

**উদাহৰণ:**
- "ইউজাৰ অথেণ্টিকেশ্যন চিস্টেম ইমপ্লিমেণ্ট কৰক" → `/workflows:feature-development`
- "ষ্টেকত পাৰফৰ্মেন্স সমস্যাৰ সমাধান কৰক" → `/workflows:smart-fix`
- "লেগাচি মন'লিথ আধুনিকীকৰণ কৰক" → `/workflows:legacy-modernize`

### 🔧 টুল ব্যৱহাৰ কৰক যেতিয়া:
- **বিশেষ দক্ষতাৰ প্ৰয়োজন** - এটা স্পষ্ট, নিবদ্ধ কাৰ্য, একেটা ক্ষেত্ৰত
- **নির্দিষ্ট নিয়ন্ত্ৰণৰ ইচ্ছা** - বিশেষ ইমপ্লিমেণ্টেশ্যনৰ বিৱৰণ নিৰ্দেশ দিয়াৰ ইচ্ছা
- **ম্যানুৱেল ৱৰ্কফ্ল'ৰ অংশ** - বিদ্যমান প্ৰক্ৰিয়াত সংযোগ
- **গভীৰ বিশেষীকৰণ প্ৰয়োজন** - বিশেষজ্ঞ-স্তৰৰ ইমপ্লিমেণ্টেশ্যন লাগে
- **বিদ্যমান কামত আধাৰিত** - পূৰ্বৰ আউটপুট উন্নয়ন/সংশোধন

**উদাহৰণ:**
- "কুবাৰনেটিছ মেনিফেষ্ট তৈয়াৰ কৰক" → `/tools:k8s-manifest`
- "সুৰক্ষা অসুৰক্ষা স্কেন কৰক" → `/tools:security-scan`
- "API ডকুমেণ্টেশ্যন উৎপাদন কৰক" → `/tools:doc-generate`

## কমাণ্ড ফৰ্মেট

স্লেছ কমাণ্ড হৈছে সৰল মাৰ্কডাউন ফাইল, য'ত:
- ফাইলনেম কমাণ্ড নাম হয় (যেনে, `tools/api-scaffold.md` → `/tools:api-scaffold`)
- ফাইলৰ বিষয়বস্তু হ'ল প্ৰম্প্ট/নির্দেশনা, যি ইনভোক কৰোঁতে চলোৱা হয়
- `$ARGUMENTS` প্লেছহ'ল্ডাৰ ব্যৱহাৰ কৰক, ইউজাৰৰ ইনপুটৰ বাবে

## শ্ৰেষ্ঠ অনুশীলনসমূহ

### আদেশ বাছনি
- **Claude Code-এ স্বয়ংক্ৰিয়ভাৱে পৰামৰ্শ দিয়ক** - প্ৰসংগ বিশ্লেষণ কৰে আৰু সৰ্বোত্তম আদেশ বাছনি কৰে
- **জটিল কামৰ বাবে workflow ব্যৱহাৰ কৰক** - উপ-এজেন্টে বহু-ডোমেইন ৰূপায়ণ সমন্বয় কৰে
- **নিশ্চিত কামৰ বাবে tools ব্যৱহাৰ কৰক** - লক্ষ্যযুক্ত উন্নয়নৰ বাবে নিৰ্দিষ্ট আদেশ প্ৰয়োগ কৰক

### কার্যকৰী ব্যৱহাৰ
- **সম্পূৰ্ণ প্ৰসংগ আগবঢ়াওক** - টেক ষ্টেক, সীমাবদ্ধতা, আৰু দাবীসমূহ অন্তর্ভুক্ত কৰক
- **কৌশলগতভাৱে আদেশ সংযোগ কৰক** - Workflow → Tools → Refinements
- **পূৰ্বৱৰ্তী আউটপুটৰ ওপৰত নিৰ্মাণ কৰক** - আদেশসমূহ একেলগে কাম কৰিবলৈ ডিজাইন কৰা হৈছে

## অৱদান

1. `workflows/` বা `tools/`-ত `.md` ফাইল সৃষ্টি কৰক
2. lowercase-hyphen-names ব্যৱহাৰ কৰক
3. ব্যৱহাৰকাৰীৰ ইনপুটৰ বাবে `$ARGUMENTS` অন্তর্ভুক্ত কৰক

## সমস্যাসমূহ সমাধান

**Command not found**: 
- ফাইলসমূহ `~/.claude/commands/tools/` বা `~/.claude/commands/workflows/`-ত আছে নেকি পৰীক্ষা কৰক
- সঠিক prefix ব্যৱহাৰ কৰক: `/tools:command-name` বা `/workflows:command-name`
- অথবা prefix নাথাকিলে directory flatten কৰক: `cp tools/*.md . && cp workflows/*.md .`

**Workflow ধীৰ**: স্বাভাবিক - বহু উপ-এজেন্ট সমন্বয় কৰে

**Generic output**: আপোনাৰ tech stack সম্পৰ্কে অধিক বিশদ প্ৰসংগ যোগ কৰক

**Integration issues**: ফাইল পথ আৰু আদেশ ক্ৰম যাচাই কৰক

## কার্যক্ষমতা পৰামর্শ

**Command Selection:**
- **Workflows**: জটিল বৈশিষ্ট্যৰ বাবে বহু-উপ-এজেন্ট সমন্বয়
- **Tools**: নিৰ্দিষ্ট কামৰ বাবে একক-উদ্দেশ্য অপাৰেচন
- **Simple edits**: মুখ্য এজেন্টৰ সৈতে থাকক

**Optimization:**
- পৰিচিত সমস্যাৰ বাবে tools-এ আৰম্ভ কৰক
- আগতীয়াকৈ বিশদ দাবীসমূহ আগবঢ়াওক
- আগৰ কমাণ্ড আউটপুটসমূহৰ ওপৰত নিৰ্মাণ কৰক
- সংশোধন কৰাৰ আগতে ৱাৰ্কফ্লোসমূহ সম্পূৰ্ণ হোৱাটো নিশ্চিত কৰক

### নতুন ৱাৰ্কফ্লো যোগ কৰা:
- সাব-এজেন্ট অৰ্কেষ্ট্ৰেশ্বন আৰু ডেলিগেশ্বন যুক্তিত কেন্দ্ৰীভূত হওক
- কিহা বিশেষ সাব-এজেন্ট ব্যৱহাৰ কৰিব আৰু কেতিয়া ব্যৱহাৰ কৰিব, স্পষ্টভাৱে উল্লেখ কৰক
- সাব-এজেন্টসমূহৰ মাজত সমন্বয়ৰ ধৰণ সংজ্ঞায়িত কৰক

### নতুন টুল যোগ কৰা:
- সম্পূৰ্ণ, প্ৰডাকশ্যন-ৰেডি ইমপ্লিমেণ্টেশ্বনসমূহ অন্তর্ভুক্ত কৰক
- বিষয়বস্তুৰ গঠন স্পষ্ট বিভাগ আৰু কাৰ্য্যযোগ্য আউটপুটৰ সৈতে কৰক
- উদাহৰণ, উৎকৃষ্ট অনুশীলন আৰু সংহতি বিন্দুসমূহ অন্তর্ভুক্ত কৰক

## অধিক জানক

- [Claude Code Documentation](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Commands Documentation](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Subagents Documentation](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) - এই কমাণ্ডসমূহত ব্যৱহৃত বিশেষ সাব-এজেন্টসমূহ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---