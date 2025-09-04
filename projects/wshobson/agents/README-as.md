<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Claude Code Subagents Collection

[Claude Code](https://docs.anthropic.com/en/docs/claude-code)ৰ বাবে বিশেষভাৱে নিৰ্মিত কৃত্ৰিম বুদ্ধিমত্তাৰ উপ-এজেন্টৰ এক বিস্তৃত সংহতি, যি উন্নয়ন কার্যপদ্ধতি উন্নত কৰিবলৈ ক্ষেত্ৰ-নির্দিষ্ট দক্ষতা আগবঢ়ায়।

## পৰ্যালোচনা

এই ৰেপ'জিট'ৰীত Claude Code'ৰ সক্ষমতা বৃদ্ধি কৰা ৭৬ টা বিশেষ উপ-এজেন্ট আছে। প্ৰতিটো উপ-এজেন্ট কোনো এখন নিৰ্দিষ্ট ক্ষেত্ৰত বিশেষজ্ঞ, পৰিপ্ৰেক্ষিতৰ ভিত্তিত স্বয়ংক্ৰিয়ভাৱে আহ্বান কৰা হয় বা প্ৰয়োজন অনুসৰি স্পষ্টভাৱে আহ্বান কৰিব পাৰি। সকলো এজেন্ট নিৰ্দিষ্ট Claude মডেলৰ সৈতে সংৰূপিত, কাৰ্যৰ জটিলতাৰ ভিত্তিত সৰ্বাধিক কার্যক্ষমতা আৰু খৰচ-দক্ষতাৰ বাবে।

## উপলব্ধ উপ-এজেন্টসমূহ

### উন্নয়ন আৰু স্থাপত্য
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - RESTful API, মাইক্র’চাৰ্ভিচ সীমা, আৰু ডাটাবেছ স্কিমা ডিজাইন কৰক
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - React কম্প’নেন্ট নিৰ্মাণ কৰক, প্ৰতিত্তিক লেআউট বাস্তৱায়ন কৰক, আৰু ক্লায়েন্ট-পক্ষৰ ষ্টেট পৰিচালনা কৰক
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - ইণ্টাৰফেছ ডিজাইন, ৱায়াৰফ্ৰেইম, আৰু ডিজাইন ছিষ্টেম সৃষ্টি কৰক
- **[ui-visual-validator](https://raw.githubusercontent.com/wshobson/agents/main/ui-visual-validator.md)** - UI পৰিবর্তনসমূহে উদ্দেশ্য সফল হৈছে নে নাই, কঠোৰ স্ক্ৰিনশ্বট বিশ্লেষণৰ মাধ্যমে নিশ্চিত কৰক
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - React Native বা Flutter এপ্লিকেশ্যন দেশীয় ইন্টিগ্ৰেশ্যন সহ উন্নয়ন কৰক
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - GraphQL স্কিমা, ৰিজল্ভাৰ, আৰু ফেডাৰেশ্যন ডিজাইন কৰক
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - স্থাপত্যগত একৰূপতা আৰু ধাৰণা পৰীক্ষা কৰি ক’ড পৰিবৰ্তনসমূহ ৰিভিউ কৰে

### ভাষা বিশেষজ্ঞ
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - উন্নত বৈশিষ্ট্য আৰু অপ্টিমাইজেচনৰ সৈতে আদর্শ Python ক’ড লিখক
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - মেটাপ্ৰগ্ৰামিং, Rails ধাৰণা, gem উন্নয়ন, আৰু টেস্টিং ফ্ৰেমৱৰ্কৰ সৈতে আদর্শ Ruby ক’ড লিখক
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - goroutine, channel, আৰু interface সহ আদর্শ Go ক’ড লিখক
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - ownership pattern, lifetime, আৰু trait বাস্তৱায়নৰ সৈতে আদর্শ Rust লিখক
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - উপযুক্ত মেমৰি পৰিচালনা আৰু system call সহ দক্ষ C ক’ড লিখক
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - আধুনিক বৈশিষ্ট্য, RAII, স্মাৰ্ট pointer, আৰু STL এলগৰিদম সহ আদর্শ C++ ক’ড লিখক
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - আধুনিক JavaScript, ES6+, async pattern, আৰু Node.js APIত দক্ষতা অর্জন কৰক
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - উন্নত টাইপ, generic, আৰু কঠোৰ টাইপ নিৰাপত্তাৰ সৈতে TypeScriptত দক্ষতা অর্জন কৰক
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - আধুনিক বৈশিষ্ট্য আৰু কাৰ্যক্ষমতা অপ্টিমাইজেচন সহ আদর্শ PHP ক’ড লিখক
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - stream, concurrency, আৰু JVM অপ্টিমাইজেচন সহ আধুনিক Javaত দক্ষতা অর্জন কৰক
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - OTP pattern, functional programming, আৰু Phoenix framework সহ আদর্শ Elixir ক’ড লিখক
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - উন্নত বৈশিষ্ট্য আৰু .NET অপ্টিমাইজেচন সহ আধুনিক C# ক’ড লিখক
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - functional programming, distributed system, আৰু big data processing সহ উদ্যোগিক Scala উন্নয়নত দক্ষতা
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - Dart, widget, আৰু platform integration সহ Flutter উন্নয়নত দক্ষতা
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - Unity গেম উন্নয়ন কৰক অপ্টিমাইজড স্ক্ৰিপ্ট আৰু কাৰ্যক্ষমতা টিউনিং সহ
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Bukkit, Spigot, আৰু Paper API সহ Minecraft ছাৰ্ভাৰ প্লাগইন উন্নয়নত দক্ষতা
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Swift/SwiftUIৰ সহায়ত দেশীয় iOS এপ্লিকেশ্যন উন্নয়ন কৰক
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - জটিল SQL কোয়েরি লিখক, execution plan অপ্টিমাইজ কৰক, আৰু normalised schema ডিজাইন কৰক

### অৱকাঠামো আৰু অপাৰেশ্যন
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - উৎপাদন সমস্যাৰ সমাধান, লগ বিশ্লেষণ, আৰু ডিপ্লয়মেন্ট বিফলতা সমাধান
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - CI/CD pipeline, Docker container, আৰু cloud ডিপ্লয়মেন্ট কনফিগাৰ কৰক
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - AWS/Azure/GCP অৱকাঠামো ডিজাইন কৰক আৰু cloud খৰচ অপ্টিমাইজ কৰক
- **[hybrid-cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/hybrid-cloud-architect.md)** - AWS/Azure/GCP আৰু OpenStack অন-প্ৰিমিছত hybrid cloud অৱকাঠামো ডিজাইন কৰক
- **[kubernetes-architect](https://raw.githubusercontent.com/wshobson/agents/main/kubernetes-architect.md)** - Kubernetes মূলভূত cloud-native অৱকাঠামো আৰু GitOps নীতিৰে AWS/Azure/GCP আৰু hybrid environmentত ডিজাইন কৰক।
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - SQL কোয়েরি অপ্টিমাইজ কৰক, দক্ষ index ডিজাইন কৰক, আৰু ডাটাবেছ মাইগ্ৰেশ্যন হেণ্ডল কৰক
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - ডাটাবেছ অপাৰেশ্যন, বেকআপ, ৰেপ্লিকেশ্যন, আৰু মনিটৰিং পৰিচালনা কৰক
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - উন্নত Terraform মডিউল লিখক, state file পৰিচালনা কৰক, আৰু IaC উৎকৃষ্ট অনুশীলন বাস্তৱায়ন কৰক
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - উৎপাদন ঘটনা তৎকাল আৰু নিখুঁতভাৱে পৰিচালনা কৰে
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - নেটৱৰ্ক সংযোগৰ সমস্যা সমাধান, ল'ড বেলেন্সাৰ কনফিগাৰ কৰা, আৰু ট্ৰাফিক পেটাৰ্ন বিশ্লেষণ কৰা
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - ডেভেলপাৰ এক্সপিৰিয়েন্স বিশেষজ্ঞ যি টুলিং, ছেটআপ, আৰু ৱাৰ্কফ্ল' উন্নত কৰে

### গুণমান আৰু সুৰক্ষা
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - গভীৰ কনফিগাৰেশ্যন সুৰক্ষা আৰু প্ৰডাকশ্যন বিশ্বাসযোগ্যতা সহ ক'ড পৰ্যালোচনা বিশেষজ্ঞ
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - কোডত দুর্বলতা পৰীক্ষা আৰু OWASP অনুগততা নিশ্চিত কৰা
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - ইউনিট, ইন্টেগ্ৰেশ্যন, আৰু e2e টেষ্ট সহ ব্যাপক টেষ্ট ছুইট সৃষ্টি কৰা
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - এপ্লিকেশ্যন প্ৰ'ফাইল কৰা, বটলনেক অনুকূল কৰা, আৰু কেচিং কৌশল ব্যৱহাৰ কৰা
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - ত্ৰুটি, টেষ্ট বিফলতা, আৰু অপ্রত্যাশিত ব্যৱহাৰৰ বাবে ডিবাগিং বিশেষজ্ঞ
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - ত্ৰুটি পেটাৰ্ন, ষ্টেক ট্রেইচ, আৰু অস্বাভাবিকতা বিচাৰি লগ আৰু কোডবেছ অনুসন্ধান কৰা
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - উন্নত অনুসন্ধান কৌশল আৰু সংশ্লেষণ ব্যৱহাৰ কৰি ৱেব অনুসন্ধান বিশেষজ্ঞ

### ডাটা আৰু AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - SQL কুৱেৰী, BigQuery কাৰ্যকলাপ, আৰু ডাটা অন্তর্দৃষ্টি বিশ্লেষণৰ বাবে বিশেষজ্ঞ
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - ETL পাইপলাইন, ডাটা ৱাৰহাউচ, আৰু ষ্ট্ৰিমিং আর্কিটেকচাৰ নিৰ্মাণ কৰা
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - LLM এপ্লিকেশ্যন, RAG ছিষ্টেম, আৰু প্ৰম্পট পাইপলাইন নিৰ্মাণ কৰা
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - ML পাইপলাইন, মডেল ছাৰ্ভিং, আৰু ফিচাৰ ইঞ্জিনিয়াৰিং বাস্তবায়ন কৰা
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - ML পাইপলাইন, এক্সপেৰিমেন্ট ট্ৰেকিং, আৰু মডেল ৰেজিষ্ট্ৰী নিৰ্মাণ কৰা
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - LLM আৰু AI ছিষ্টেমৰ বাবে প্ৰম্পট অনুকূল কৰে

### বিশেষ ক্ষেত্ৰ
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - OpenAPI/Swagger স্পেছ সৃষ্টি আৰু ডেভেলপাৰ ডকুমেন্টেচন লিখা
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - Stripe, PayPal, আৰু পেমেন্ট প্ৰচেসৰ একত্ৰিকৰণ
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - অৰ্থিক মডেল নিৰ্মাণ, ট্রেডিং কৌশল ব্যাকটেষ্ট, আৰু বজাৰ ডাটা বিশ্লেষণ
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - পোর্টফোলিও ৰিস্ক, R-মাল্টিপল, আৰু পজিশন সীমা মনিটৰ কৰা
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - লেগেচি কোডবেছ পুনৰগঠন আৰু ধীৰে আধুনিকীকৰণ বাস্তবায়ন
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - বহু এজেন্ট আৰু দীঘলীয়া টাস্কত কণ্টেক্স্ট পৰিচালনা কৰে

### ডকুমেন্টেচন
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - বিদ্যমান কোডবেছৰ পৰা ব্যাপক প্ৰযুক্তিগত ডকুমেন্টেচন সৃষ্টি কৰে
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - Flowchart, sequence, ERD, আৰু architecture ৰ বাবে Mermaid ডায়াগ্ৰাম সৃষ্টি কৰা
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - বিস্তৃত প্ৰযুক্তিগত ৰেফাৰেন্স আৰু API ডকুমেন্টেচন সৃষ্টি কৰা
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - কোডৰ পৰা ধাপে ধাপে টিউটোৰিয়েল আৰু শিক্ষামূলক বিষয়বস্তু সৃষ্টি কৰা

### ব্যৱসায় আৰু বিপণন
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - মেট্ৰিক বিশ্লেষণ, ৰিপৰ্ট সৃষ্টি, আৰু KPI ট্ৰেক কৰা
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - ব্লগ প'ষ্ট, ছোসিয়েল মিডিয়া বিষয়বস্তু, আৰু ইমেইল নিউজলেটাৰ লিখা
- **[hp-pro](https://raw.githubusercontent.com/wshobson/agents/main/hp-pro.md)** - নিযুক্তি, অনবোর্ডিং/অফবোর্ডিং, PTO আৰু ছুটি, কাৰ্যক্ষমতা, নীতিমালা, আৰু কৰ্মচাৰী সম্পৰ্কৰ বাবে অংশীদাৰ।
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - ঠাণ্ডা ইমেইল, ফল'আপ, আৰু প্ৰস্তাৱ টেম্পলেট খচৰা কৰা
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - সহায় সম্বন্ধীয় টিকেট, FAQ উত্তৰ, আৰু গ্ৰাহক ইমেইল হেণ্ডেল কৰা
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - গোপনীয়তা নীতি, সেৱাৰ শর্ত, অস্বীকাৰীকৰণ আৰু আইনী বিজ্ঞপ্তি খচৰা কৰে

### SEO আৰু বিষয়বস্তু অপ্টিমাইজেচন
- **[seo-content-auditor](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-auditor.md)** - প্ৰদান কৰা বিষয়বস্তুৰ গুণ, E-E-A-T সংকেত, আৰু SEOৰ উৎকৃষ্ট অনুশীলনসমূহ বিশ্লেষণ কৰে
- **[seo-meta-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/seo-meta-optimizer.md)** - অপ্টিমাইজ কৰা মেটা শিৰোনাম, বিৱৰণ, আৰু URLৰ পৰামৰ্শ তৈয়াৰ কৰে
- **[seo-keyword-strategist](https://raw.githubusercontent.com/wshobson/agents/main/seo-keyword-strategist.md)** - কিওৱৰ্ড ব্যৱহাৰ বিশ্লেষণ, ঘনত্ব গণনা, অৰ্থসম্পন্ন ভিন্নতা পৰামৰ্শ
- **[seo-structure-architect](https://raw.githubusercontent.com/wshobson/agents/main/seo-structure-architect.md)** - বিষয়বস্তুৰ গঠন, হেডাৰ শ্রেণীবিভাগ, আৰু স্কিমা মাৰ্কআপ অপ্টিমাইজ কৰে
- **[seo-snippet-hunter](https://raw.githubusercontent.com/wshobson/agents/main/seo-snippet-hunter.md)** - বিষয়বস্তুৰ ফিচাৰ্ড স্নিপেট আৰু SERP বৈশিষ্ট্যৰ বাবে ফৰ্মেট কৰে
- **[seo-content-refresher](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-refresher.md)** - পুরণি উপাদান চিনাক্ত কৰে আৰু বিষয়বস্তু আপডেটৰ পৰামৰ্শ দিয়ে
- **[seo-cannibalization-detector](https://raw.githubusercontent.com/wshobson/agents/main/seo-cannibalization-detector.md)** - একাধিক পৃষ্ঠাৰ কিওৱৰ্ডৰ ওভাৰলেপ আৰু দ্বন্দ্ব বিশ্লেষণ কৰে
- **[seo-authority-builder](https://raw.githubusercontent.com/wshobson/agents/main/seo-authority-builder.md)** - বিষয়বস্তুৰ E-E-A-T সংকেত আৰু বিশ্বাস সূচক বিশ্লেষণ কৰে
- **[seo-content-writer](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-writer.md)** - কিওৱৰ্ড আৰু সংক্ষিপ্ত ভিত্তিত SEO-অপ্টিমাইজ কৰা বিষয়বস্তু লিখে
- **[seo-content-planner](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-planner.md)** - বিষয়বস্তুৰ আউটলাইন, বিষয় ক্লাষ্টাৰ, আৰু কেলেণ্ডাৰ তৈয়াৰ কৰে

## মডেল নিয়োগ

সমূহ ৭৬টা উপ-এজেন্ট নিদিষ্ট Claude মডেলৰ সৈতে কাৰ্য জটিলতাৰ ভিত্তিত সংৰূপিত কৰা হৈছে:

### 🚀 Haiku (দ্ৰুত আৰু খৰচ-দক্ষ) - ১৫টা এজেন্ট
**Model:** `haiku`
- `data-scientist` - SQL প্ৰশ্ন আৰু তথ্য বিশ্লেষণ
- `api-documenter` - OpenAPI/Swagger ডকুমেন্টেশনৰ খচৰা
- `reference-builder` - বিস্তৃত প্ৰযুক্তিগত ৰেফাৰেন্স আৰু API ডকুমেন্টেশনৰ খচৰা
- `business-analyst` - মেট্ৰিক্স আৰু KPI অনুসৰণ
- `content-marketer` - ব্লগ পোষ্ট আৰু ছ'চিয়েল মিডিয়া
- `customer-support` - সহায় টিকিট আৰু FAQs
- `sales-automator` - ঠাণ্ডা ইমেইল আৰু প্ৰস্তাৱ
- `search-specialist` - ৱেব গৱেষণা আৰু তথ্য সংগ্ৰহ
- `legal-advisor` - গোপনীয়তা নীতি আৰু অনুগত নথি
- `seo-meta-optimizer` - মেটা শিৰোনাম আৰু বিৱৰণ অপ্টিমাইজ
- `seo-keyword-strategist` - কিওৱৰ্ড ঘনত্ব আৰু অৰ্থ বিশ্লেষণ
- `seo-structure-architect` - বিষয়বস্তুৰ গঠন আৰু স্কিমা মাৰ্কআপ
- `seo-snippet-hunter` - ফিচাৰ্ড স্নিপেট ফৰ্মেটিং
- `seo-content-refresher` - বিষয়বস্তুৰ নতুনত্ব আপডেট
- `seo-cannibalization-detector` - কিওৱৰ্ড ওভাৰলেপ চিনাক্তকৰণ
- `seo-content-planner` - বিষয়বস্তু কেলেণ্ডাৰ আৰু আউটলাইন

### ⚡ Sonnet (সমতুল্য কার্যক্ষমতা) - ৪৫টা এজেন্ট
**Model:** `sonnet`

**উন্নয়ন আৰু ভাষাসমূহ:**
- `python-pro` - উন্নত বৈশিষ্ট্যৰে Python উন্নয়ন
- `ruby-pro` - Metaprogramming, Rails পেটাৰ্ন আৰু gem উন্নয়নসহ Ruby উন্নয়ন
- `javascript-pro` - আধুনিক JavaScript আৰু Node.js
- `typescript-pro` - টাইপ ছিস্টেমসহ উন্নত TypeScript
- `golang-pro` - Go concurrency আৰু শুদ্ধ পেটাৰ্ন
- `rust-pro` - Rust memory safety আৰু systems programming
- `c-pro` - C প্ৰগ্ৰামিং আৰু এম্বেডেড ছিস্টেম
- `cpp-pro` - আধুনিক C++ STL আৰু template সহ
- `php-pro` - আধুনিক PHP উন্নত বৈশিষ্ট্যৰে
- `java-pro` - আধুনিক Java stream আৰু concurrency সহ
- `elixir-pro` - Elixir OTP পেটাৰ্ন আৰু Phoenix সহ
- `csharp-pro` - আধুনিক C# .NET framework আৰু পেটাৰ্ন সহ
- `scala-pro` - Enterprise Scala Apache Pekko, Akka, Spark, আৰু ZIO/Cats Effect সহ
- `flutter-expert` - Flutter উন্নয়ন, state management আৰু animation সহ
- `unity-developer` - Unity গেম উন্নয়ন আৰু optimization
- `minecraft-bukkit-pro` - Bukkit/Spigot/Paper সহ Minecraft plugin উন্নয়ন
- `ios-developer` - Swift/SwiftUI সহ নেটিভ iOS উন্নয়ন
- `frontend-developer` - React component আৰু UI
- `ui-ux-designer` - Interface design আৰু wireframe
- `ui-visual-validator` - Screenshot বিশ্লেষণ দ্বাৰা কঠোৰ UI validation
- `backend-architect` - API design আৰু microservices
- `mobile-developer` - React Native/Flutter এপ
- `sql-pro` - জটিল SQL optimization
- `graphql-architect` - GraphQL schema আৰু resolver

**ইনফ্ৰাস্ট্ৰাকচাৰ আৰু অপাৰেশ্যন:**
- `devops-troubleshooter` - প্ৰডাকশ্বন debugging
- `deployment-engineer` - CI/CD pipeline
- `database-optimizer` - Query optimization
- `database-admin` - Database অপাৰেশ্যন
- `terraform-specialist` - Infrastructure as Code
- `network-engineer` - Network configuration
- `dx-optimizer` - Developer experience
- `data-engineer` - ETL pipeline

**গুণমান আৰু সহায়:**
- `test-automator` - Test suite নিৰ্মাণ
- `code-reviewer` - Code quality বিশ্লেষণ
- `debugger` - ত্ৰুটি অনুসন্ধান
- `error-detective` - লগ বিশ্লেষণ
- `ml-engineer` - এমএল মডেল ডিপ্লয়মেন্ট
- `legacy-modernizer` - ফ্ৰেমৱৰ্ক মাইগ্ৰেচন
- `payment-integration` - পেমেন্ট প্ৰসেছিং
- `mermaid-expert` - মাৰ্মেইড ডায়াগ্ৰাম আৰু ভিজ্যুয়েল ডকুমেণ্টেচন
- `flutter-expert` - ফ্লাটাৰ ডেভেলপমেন্ট
- `seo-content-auditor` - বিষয়বস্তুৰ গুণমান আৰু E-E-A-T বিশ্লেষণ
- `seo-authority-builder` - অথৰিটি সংকেত অপ্টিমাইজেচন
- `seo-content-writer` - এছ.ই.অ' অপ্টিমাইজড বিষয়বস্তু সৃষ্টি

### 🧠 Opus (সৰ্বাধিক সক্ষমতা) - ১৫ গৰাকী এজেন্ট
**মডেল:** `opus`
- `ai-engineer` - এলএলএম এপ্লিকেশ্যন আৰু RAG চিস্টেম
- `security-auditor` - দূৰ্বলতা বিশ্লেষণ
- `performance-engineer` - এপ্লিকেশ্যন অপ্টিমাইজেচন
- `incident-responder` - প্ৰডাকচন ইনচিডেন্ট হেণ্ডলিং
- `mlops-engineer` - এমএল ইনফ্ৰাস্ট্ৰাকচাৰ
- `architect-reviewer` - স্থাপত্যগত একৰূপতা
- `cloud-architect` - ক্লাউড ইনফ্ৰাস্ট্ৰাকচাৰ ডিজাইন
- `prompt-engineer` - এলএলএম প্ৰম্পট অপ্টিমাইজেচন
- `context-manager` - বহু-এজেন্ট সমন্বয়
- `quant-analyst` - বিত্তীয় মডেলিং
- `risk-manager` - পোর্টফোলিঅ' ৰিস্ক পৰিচালনা
- `docs-architect` - ক'ডবেইচৰ পৰা বিস্তৃত প্ৰযুক্তিগত ডকুমেণ্টেচন
- `tutorial-engineer` - ধাপে-ধাপে টিউটোৰিয়েল আৰু শিক্ষামূলক বিষয়বস্তু

## স্থাপন

এই উপ-এজেন্টসমূহ `~/.claude/agents/` ডাইৰেক্টৰীত থৈ দিলে স্বয়ংক্ৰিয়ভাৱে উপলব্ধ হয়।

```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## ব্যৱহাৰ

### স্বচালিত আহ্বান
Claude Code টিয়ে কামৰ পৰিপ্ৰেক্ষিত আৰু উপ-এজেন্টৰ বিবৰণৰ আধাৰত স্বয়ংক্ৰিয়ভাৱে উপযুক্ত উপ-এজেন্টলৈ দায়িত্ব প্ৰদান কৰিব।

### স্পষ্ট আহ্বান
আপোনাৰ অনুৰোধত উপ-এজেন্টৰ নাম উল্লেখ কৰক:
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## ব্যৱহাৰৰ উদাহৰণ

### একক এজেন্ট টাস্কসমূহ
```bash
# Code quality and review
"Use code-reviewer to analyze this component for best practices"
"Have code-reviewer scrutinize these configuration changes"
"Have security-auditor check for OWASP compliance issues"

# Development tasks  
"Get backend-architect to design a user authentication API"
"Use frontend-developer to create a responsive dashboard layout"

# Infrastructure and operations
"Have devops-troubleshooter analyze these production logs"
"Use cloud-architect to design a scalable AWS architecture"
"Get network-engineer to debug SSL certificate issues"
"Use database-admin to set up backup and replication"

# Data and AI
"Get data-scientist to analyze this customer behavior dataset"
"Use ai-engineer to build a RAG system for document search"
"Have mlops-engineer set up MLflow experiment tracking"

# Business and marketing
"Have business-analyst create investor deck with growth metrics"
"Use content-marketer to write SEO-optimized blog post"
"Get sales-automator to create cold email sequence"
"Have customer-support draft FAQ documentation"
```

### বহু-এজেন্ট ৱাৰ্কফ্ল'সমূহ

এই চাব-এজেন্টসমূহে একেলগে সু-সংগতভাৱে কাম কৰে, আৰু অধিক জটিল সংগঠনৰ বাবে, আপুনি **[Claude Code Commands](https://github.com/wshobson/commands)** সংগ্ৰহ ব্যৱহাৰ কৰিব পাৰে, যি ৫২টা প্ৰি-বিল্ট ছ্লেশ কমাণ্ড প্ৰদান কৰে, যিয়ে এই চাব-এজেন্টসমূহক উন্নত ৱাৰ্কফ্ল'সমূহত ব্যৱহাৰ কৰে।

```bash
# Feature development workflow
"Implement user authentication feature"
# Automatically uses: backend-architect → frontend-developer → test-automator → security-auditor

# Performance optimization workflow  
"Optimize the checkout process performance"
# Automatically uses: performance-engineer → database-optimizer → frontend-developer

# Production incident workflow
"Debug high memory usage in production"
# Automatically uses: incident-responder → devops-troubleshooter → error-detective → performance-engineer

# Network connectivity workflow
"Fix intermittent API timeouts"
# Automatically uses: network-engineer → devops-troubleshooter → performance-engineer

# Database maintenance workflow
"Set up disaster recovery for production database"
# Automatically uses: database-admin → database-optimizer → incident-responder

# ML pipeline workflow
"Build end-to-end ML pipeline with monitoring"
# Automatically uses: mlops-engineer → ml-engineer → data-engineer → performance-engineer

# Product launch workflow
"Launch new feature with marketing campaign"
# Automatically uses: business-analyst → content-marketer → sales-automator → customer-support
```

### স্লেশ কমাণ্ডৰ সৈতে উন্নত ৱাৰ্কফ্ল'সমূহ

অধিক জটিল বহু-উপ-এজেন্ট সমন্বয়ৰ বাবে, সংগী [Commands repository](https://github.com/wshobson/commands) ব্যৱহাৰ কৰক:

```bash
# Complex feature development (8+ subagents)
/full-stack-feature Build user dashboard with real-time analytics

# Production incident response (5+ subagents) 
/incident-response Database connection pool exhausted

# ML infrastructure setup (6+ subagents)
/ml-pipeline Create recommendation engine with A/B testing

# Security-focused implementation (7+ subagents)
/security-hardening Implement OAuth2 with zero-trust architecture
```

## উপ-এজেন্ট ফৰ্মেট

প্ৰত্যেকটো উপ-এজেন্টে এই গঠন অনুসৰণ কৰে:
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```

### মডেল কনফিগাৰেচন

Claude Code v1.0.64-ৰ পৰা, উপ-এজেন্টে নিৰ্দিষ্ট কৰিব পাৰে তেওঁলোকে কোনটো Claude মডেল ব্যৱহাৰ কৰিব। এইটো জটিলতাৰ আধাৰত খৰচ-প্ৰভাৱশালী টাস্ক ডেলেগেশ্যন সম্ভৱ কৰে:

- **নিম্ন জটিলতা (Haiku)**: সহজ টাস্ক যেনে মৌলিক ডাটা বিশ্লেষণ, ডকুমেন্টেশ্যন প্ৰস্তুতি, আৰু মানক উত্তৰ
- **মধ্যম জটিলতা (Sonnet)**: ডেভেলপমেন্ট টাস্ক, কোড পৰ্যালোচনা, পৰীক্ষণ, আৰু মানক ইঞ্জিনিয়াৰিং কাম  
- **উচ্চ জটিলতা (Opus)**: গুৰত্বপূৰ্ণ টাস্ক যেনে সুৰক্ষা অডিটিং, স্থাপত্য পৰ্যালোচনা, ঘটনা প্ৰতিক্ৰিয়া, আৰু AI/ML ইঞ্জিনিয়াৰিং

উপলব্ধ মডেলসমূহ (Claude Code v1.0.64-ৰ মতে সহজ নাম ব্যৱহাৰ কৰি):
- `haiku` - সহজ টাস্কৰ বাবে দ্ৰুত আৰু খৰচ-প্ৰভাৱশালী
- `sonnet` - অধিকাংশ ডেভেলপমেন্ট কামৰ বাবে সু-সমতল কাৰ্যক্ষমতা
- `opus` - জটিল বিশ্লেষণ আৰু গুৰত্বপূৰ্ণ টাস্কৰ বাবে আটাইতকৈ সক্ষম

যদি কোনো মডেল নিৰ্দিষ্ট কৰা নহয়, উপ-এজেন্টে ব্যৱস্থাৰ ডিফল্ট মডেল ব্যৱহাৰ কৰিব।

## এজেন্ট অৰ্কেষ্ট্ৰেচন পেটাৰ্ন

Claude Code-এ স্বয়ংক্ৰিয়ভাৱে সাধাৰণ পেটাৰ্ন ব্যৱহাৰ কৰি এজেন্টসমূহ সমন্বয় কৰে:

### ক্ৰমবদ্ধ ৱৰ্কফ্লো
```
User Request → Agent A → Agent B → Agent C → Result

Example: "Build a new API feature"
backend-architect → frontend-developer → test-automator → security-auditor
```

### Parallel Execution
```
User Request → Agent A + Agent B (simultaneously) → Merge Results

Example: "Optimize application performance" 
performance-engineer + database-optimizer → Combined recommendations
```

### শর্তাধীন শাখাবিভাজন
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### পৰ্যালোচনা আৰু প্ৰমাণীকৰণ
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```
## কোন সময় কোন এজেন্ট ব্যৱহাৰ কৰিব

### 🏗️ পৰিকল্পনা আৰু স্থাপত্য
- **backend-architect**: API ডিজাইন, ডেটাবেছ স্কিমা, চিষ্টেম স্থাপত্য
- **frontend-developer**: UI/UX পৰিকল্পনা, কম্পোনেণ্ট স্থাপত্য
- **ui-ux-designer**: ইণ্টাৰফেচ ডিজাইন, ৱায়াৰফ্ৰেম, ডিজাইন চিষ্টেম, ব্যৱহাৰকাৰী গৱেষণা
- **cloud-architect**: অবকাঠামো ডিজাইন, স্কেলেবিলিটি পৰিকল্পনা

### 🔧 কাৰ্য্যন্বয়ন আৰু ডেভেলপমেণ্ট  
- **python-pro**: পাইথন-নির্দিষ্ট ডেভেলপমেণ্ট টাস্ক
- **ruby-pro**: ৰুবি মেটাপ্ৰগ্ৰামিং, ৰেইলছ এপ্লিকেশ্বন, জেম ডেভেলপমেণ্ট, RSpec/Minitest টেষ্টিং
- **golang-pro**: গো-নির্দিষ্ট ডেভেলপমেণ্ট টাস্ক
- **rust-pro**: ৰাষ্ট-নির্দিষ্ট ডেভেলপমেণ্ট, মেমৰি সেফটি, চিষ্টেম প্ৰগ্ৰামিং
- **c-pro**: চি প্ৰগ্ৰামিং, এম্বেডেড চিষ্টেম, কাৰ্যক্ষমতা-গুরুত্বপূর্ণ ক’ড
- **javascript-pro**: আধুনিক জাভাস্ক্ৰিপ্ট, এছিং পেটাৰ্ন, Node.js/ব্ৰাউজাৰ ক’ড
- **typescript-pro**: উন্নত টাইপস্ক্ৰিপ্ট, জেনেৰিক্স, টাইপ ইনফাৰেঞ্চ, উদ্যোগ পেটাৰ্ন
- **java-pro**: আধুনিক জাভা ডেভেলপমেণ্ট, ষ্ট্ৰিমছ, কনকাৰেন্সি, Spring Boot
- **elixir-pro**: এলিক্সিৰ ডেভেলপমেণ্ট, OTP পেটাৰ্ন, Phoenix ফ্ৰেমৱৰ্ক, ফাংচনেল প্ৰগ্ৰামিং
- **csharp-pro**: আধুনিক C# ডেভেলপমেণ্ট, .NET ফ্ৰেমৱৰ্ক, উদ্যোগ পেটাৰ্ন
- **scala-pro**: উদ্যোগ স্কালা ফাংচনেল প্ৰগ্ৰামিং, Apache Pekko/Akka actors, Apache Spark, ZIO/Cats Effect, ৰিঅ্যাক্টিভ স্থাপত্য
- **flutter-expert**: ফ্লাটাৰ ডেভেলপমেণ্ট, ডার্ট, ষ্টেট মেনেজমেণ্ট, এনিমেশ্বন, ক্ৰছ-প্লাটফৰ্ম ডিপ্লয়মেণ্ট
- **unity-developer**: ইউনিটি গেম ডেভেলপমেণ্ট, C# স্ক্ৰিপ্টিং, কাৰ্যক্ষমতা অপ্টিমাইজেশ্বন
- **minecraft-bukkit-pro**: মাইনক্ৰাফ্ট প্লাগিন ডেভেলপমেণ্ট, ইভেণ্ট চিষ্টেম, ছাৰ্ভাৰ-ছাইড ফিচাৰ
- **ios-developer**: নেটিভ iOS ডেভেলপমেণ্ট উইথ Swift/SwiftUI
- **sql-pro**: ডেটাবেছ কুৱেৰী, স্কিমা ডিজাইন, কুৱেৰী অপ্টিমাইজেশ্বন
- **mobile-developer**: React Native/Flutter ডেভেলপমেণ্ট

### 🛠️ অপাৰেশ্বন আৰু মেইনটেনেন্স
- **devops-troubleshooter**: প্ৰডাকচন সমস্যাবোৰ, ডিপ্লয়মেণ্ট সমস্যাবোৰ
- **incident-responder**: তৎকালিক প্ৰতিক্ৰিয়া প্ৰয়োজন হোৱা গুৰুত্বপূর্ণ আউটেজ
- **database-optimizer**: কুৱেৰী কাৰ্যক্ষমতা, ইনডেক্সিং পেটাৰ্ন
- **database-admin**: বেকআপ পেটাৰ্ন, ৰেপ্লিকেশ্বন, ব্যৱহাৰকাৰী মেনেজমেণ্ট, দুৰ্যোগ পুনৰুদ্ধাৰ
- **terraform-specialist**: Infrastructure as Code, Terraform মডিউল, ষ্টেট মেনেজমেণ্ট
- **network-engineer**: নেটৱৰ্ক সংযোগ, লোড বেলেঞ্চাৰ, SSL/TLS, DNS ডিবাগিং

### 📊 বিশ্লেষণ আৰু অপ্টিমাইজেশ্বন
- **performance-engineer**: এপ্লিকেশ্বন বটলনেক, অপ্টিমাইজেশ্বন
- **security-auditor**: ভল্নাৰেবিলিটি স্কেনিং, কম্প্লায়েন্স চেক
- **data-scientist**: ডেটা বিশ্লেষণ, ইনছাইট, ৰিপৰ্টিং

- **mlops-engineer**: এমএল অৱসাংগঠন, পৰীক্ষাৰ অভিযান, মডেল ৰেজিষ্ট্ৰী, পাইপলাইন স্বয়ংক্ৰিয়কৰণ

### 🧪 গুণমান আশ্বাস
- **code-reviewer**: কোৰ গুণমান, সংৰক্ষণ সুৰক্ষা, উৎপাদনৰ নিৰ্ভৰযোগ্যতা
- **test-automator**: পৰীক্ষা কৌশল, পৰীক্ষা ছুটিৰ সৃষ্টি
- **debugger**: বাগ তদন্ত, ত্ৰুটি সমাধান
- **error-detective**: লগ বিশ্লেষণ, ত্ৰুটি ধাৰণা চিনাক্তকৰণ, মূল কাৰণ বিশ্লেষণ
- **search-specialist**: গভীৰ ৱেব গৱেষণা, প্ৰতিযোগিতামূলক বিশ্লেষণ, তথ্য যাচাই

### 📚 নথিপত্ৰ
- **api-documenter**: OpenAPI/Swagger স্পেক, API নথিপত্ৰ
- **docs-architect**: বিস্তৃত প্ৰযুক্তিগত নথিপত্ৰ, স্থাপত্য গাইড, প্ৰণালী ম্যানুৱেল
- **reference-builder**: বিস্তৃত API ৰেফাৰেঞ্চ, সংৰক্ষণ গাইড, পৰামিতি নথিপত্ৰ
- **tutorial-engineer**: ধাপে ধাপে টিউটোৰিয়েল, শিক্ষাৰ পথ, শিক্ষামূলক সামগ্ৰী

### 💼 ব্যৱসায় & কৌশল
- **business-analyst**: KPI, আয় মডেল, বৃদ্ধিৰ পূৰ্বানুমান, বিনিয়োগকাৰী সূচক
- **risk-manager**: পোর্টফোলিঅ' ঝুঁকি, হেজিং কৌশল, R-মাল্টিপল, পজিশন মাপ
- **content-marketer**: SEO সামগ্ৰী, ব্লগ পোষ্ট, ছ'চিয়েল মিডিয়া, ই-মেইল অভিযান
- **sales-automator**: ঠাণ্ডা ই-মেইল, অনুসৰণ, প্ৰস্তাৱ, লীড পোষণ
- **customer-support**: সহায় টিকিট, FAQs, সহায় নথিপত্ৰ, সমস্যাৰ সমাধান
- **legal-advisor** - গোপনীয়তা নীতি, সেৱাৰ শর্ত, অস্বীকাৰ, আৰু আইনগত বিজ্ঞপ্তি খসড়া কৰা

## উৎকৃষ্ট অনুশীলনসমূহ

### 🎯 কাৰ্য ভাগ-বতৰা
1. **Claude Code-এ স্বয়ংক্ৰিয়ভাৱে ভাগ-বতৰা কৰক** - মুখ্য এজেন্টে প্ৰসংগ বিশ্লেষণ কৰি উৎকৃষ্ট এজেন্ট নিৰ্বাচন কৰে
2. **আৱশ্যকতাবোৰ স্পষ্টকৈ উল্লেখ কৰক** - সীমাবদ্ধতা, প্ৰযুক্তি স্তূপ, আৰু গুণমানৰ আৱশ্যকতা অন্তৰ্ভুক্ত কৰক
3. **এজেন্টৰ দক্ষতাত বিশ্বাস কৰক** - প্ৰতিটো এজেন্ট নিজৰ ক্ষেত্ৰত অনুকূলিত

### 🔄 বহু-এজেন্টৰ কৰ্মপ্রবাহ
4. **উচ্চ-স্তৰৰ অনুৰোধৰে আৰম্ভ কৰক** - এজেন্টে জটিল বহু-ধাপীয়া কাৰ্য সমন্বয় কৰে
5. **এজেন্টসমূহৰ মাজত প্ৰসংগ আগবঢ়াওক** - এজেন্টে প্ৰয়োজনীয় পটভূমি তথ্য পাব পাৰে
6. **সংযোগ বিন্দু পৰ্যালোচনা কৰক** - ভিন্ন এজেন্টৰ আউটপুটৰ সমন্বয় পৰীক্ষা কৰক

### 🎛️ স্পষ্ট নিয়ন্ত্ৰণ
7. **বিশেষ প্ৰয়োজনৰ বাবে স্পষ্ট আহ্বান ব্যৱহাৰ কৰক** - আপোনাৰ বিশেষজ্ঞৰ দৃষ্টিভংগী বিচাৰোতে
8. **বহু এজেন্ট কৌশলগতভাৱে সংযুক্ত কৰক** - ভিন্ন বিশেষজ্ঞে পৰস্পৰৰ কামৰ মান যাচাই কৰিব পাৰে
9. **নির্দিষ্ট পৰ্যালোচনা ধাৰণা অনুৰোধ কৰক** - "security-auditor-এ backend-architect-ৰ API ডিজাইন পৰ্যালোচনা কৰক"

### 📈 অপ্টিমাইজেচন
10. **এজেন্টৰ কার্যক্ষমতা মনিটৰ কৰক** - আপোনাৰ ব্যৱহাৰ ক্ষেত্ৰসমূহৰ বাবে কোন এজেন্ট ভাল কাম কৰে শিকক
11. **জটিল কাৰ্যসমূহত পুনৰাবৃত্তি কৰক** - এজেন্টৰ ফিডব্যাক ব্যৱহাৰ কৰি দাবীসমূহ উন্নত কৰক
12. **এজেন্টৰ শক্তিসমূহ সদ্ব্যৱহাৰ কৰক** - কাৰ্যৰ জটিলতা এজেন্টৰ সক্ষমতাৰ সৈতে মিলাওক

## অৱদান

এটা নতুন সাবএজেন্ট যোগ কৰিবলৈ:
1. ওপৰৰ ফৰ্মেট অনুসৰি এটা নতুন `.md` ফাইল সৃষ্টি কৰক
2. সৰু আখৰ আৰু হাইফেন-দ্বারা বিভাজিত নাম ব্যৱহাৰ কৰক
3. সাবএজেন্ট কেতিয়া ব্যৱহাৰ কৰিব লাগে তাৰ স্পষ্ট বৰ্ণনা লিখক
4. চিস্টেম প্ৰম্পটত নিৰ্দিষ্ট নিৰ্দেশনা অন্তর্ভুক্ত কৰক

## সমস্যাৰ সমাধান

### সাধাৰণ সমস্যা

**এজেন্ট স্বচালিতভাৱে আহ্বান নহয়:**
- আপোনাৰ অনুৰোধত স্পষ্টকৈ ডোমেইন উল্লেখ কৰক (যেনে, "performance issue" → performance-engineer)
- কাৰ্যৰ ধৰণ স্পষ্টকৈ উল্লেখ কৰক (যেনে, "review code" → code-reviewer)

**অপ্ৰত্যাশিত এজেন্ট নিৰ্বাচন:**
- আপোনাৰ টেক ষ্টেক আৰু দাবীসমূহৰ বিষয়ে অধিক প্ৰসংগ দিয়ক
- যদি আপোনাৰ বিশেষ এজেন্টৰ প্ৰয়োজন, স্পষ্ট আহ্বান ব্যৱহাৰ কৰক

**একাধিক এজেন্টে বিপৰীত পৰামর্শ প্ৰদান কৰে:**
- এইটো স্বাভাবিক - বিভিন্ন বিশেষজ্ঞৰ ভিন্ন প্ৰাধান্য থাকিব পাৰে
- স্পষ্টীকৰণ বিচাৰক: "security-auditor আৰু performance-engineer ৰ পৰামর্শ মিলাওক"

**এজেন্টে প্ৰসংগৰ অভাৱ অনুভৱ কৰে:**
- আপোনাৰ অনুৰোধত পটভূমি তথ্য দিয়ক
- পূৰ্বৰ আলোচনাবোৰ বা প্ৰতিষ্ঠিত ধাৰণাবোৰ উল্লেখ কৰক

### সহায়তা পাবলৈ

যদি এজেন্টবোৰ আশা অনুসৰি কাম নকৰে:
1. তেওঁলোকৰ নিজ নিজ ফাইলত এজেন্টৰ বৰ্ণনা চাওক
2. আপোনাৰ অনুৰোধত অধিক নিৰ্দিষ্ট ভাষা চেষ্টা কৰক
3. নিৰ্দিষ্ট এজেন্ট পৰীক্ষা কৰিবলৈ স্পষ্ট আহ্বান ব্যৱহাৰ কৰক
4. আপোনাৰ প্ৰকল্প আৰু লক্ষ্যসমূহৰ বিষয়ে অধিক প্ৰসংগ দিয়ক

## লাইচেন্স

এই প্ৰকল্পটো MIT লাইচেন্সৰ অধীনত লাইচেন্স কৰা হৈছে - অধিক তথ্যৰ বাবে [LICENSE](LICENSE) ফাইলটো চাওক।

## অধিক জানক

- [Claude Code ডকুমেন্টেশ্যন](https://docs.anthropic.com/en/docs/claude-code)
- [Subagents ডকুমেন্টেশ্যন](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---