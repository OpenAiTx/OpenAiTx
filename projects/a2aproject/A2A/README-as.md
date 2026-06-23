# Agent2Agent (A2A) প্ৰটোকল

[![PyPI - Version](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Ask Code Wiki" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 ভাষা</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a_logo/color/SVG/a2a_color.svg" alt="Agent2Agent Protocol Logo" width="100">
    <h1>Agent2Agent (A2A) প্ৰ’ট’কল</h1>
  </div>
</div>

**এটা মুক্ত প্ৰ’ট’কল যি অপাক এজেণ্টিক এপ্লিকেশ্যনৰ মাজত যোগাযোগ আৰু আন্তঃ-কাৰ্যক্ষমতা সক্ষম কৰে।**

Agent2Agent (A2A) প্ৰ’ট’কলে AI ক্ষেত্ৰত এটা গুৰুত্বপূর্ণ সমস্যাৰ সমাধান আনে: বিভিন্ন কোম্পানীয়ে বিভিন্ন ফ্ৰেমৱৰ্কত নিৰ্মিত, পৃথক ছাৰ্ভাৰত চলা জেন AI এজেণ্টসমূহক কার্যকৰীভাৱে যোগাযোগ আৰু সহযোগিতা কৰিবলৈ সক্ষম কৰা - কেৱল এটা টুল হিচাপে নহয়, এজেণ্ট হিচাপে। A2A-ৰ উদ্দেশ্য হৈছে এজেণ্টসমূহৰ বাবে এটা সাধাৰণ ভাষা প্ৰদান কৰা, যিয়ে এটা অধিক আন্তঃসংযুক্ত, শক্তিশালী আৰু উদ্ভাৱনী AI পৰিবেশ গঢ়ি তোলে।

A2A-ৰ সহায়ত, এজেণ্টসমূহে কৰিব পাৰে:

- পৰস্পৰৰ সামৰ্থ্যসমূহ আৱিষ্কাৰ কৰা।
- আন্তঃ-কাৰ্যক্ষমতাৰ পদ্ধতি (পাঠ্য, ফৰ্ম, মিডিয়া) আলোচনা কৰা।
- দীঘলীয়া কামত সুৰক্ষিতভাৱে সহযোগিতা কৰা।
- নিজৰ আভ্যন্তৰীণ অৱস্থা, স্মৃতি, বা টুল প্ৰকাশ নকৰাকৈ কাৰ্য্য কৰা।

## DeepLearning.AI পাঠ্যক্ৰম

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

[Agent2Agent প্ৰ’ট’কল (A2A)](https://goo.gle/dlai-a2a) ৰ ওপৰত এই চুটি পাঠ্যক্ৰমত যোগদান কৰক, যি Google Cloud আৰু IBM Research-ৰ সৈতে সহযোগিতাত নিৰ্মিত, আৰু [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini), আৰু [Sandi Besen](https://github.com/sandijean90) দ্বাৰা শিকোৱা।

**আপুনি কি শিকিব:**

- **এজেণ্টসমূহক A2A-অনুকূল কৰক:** Google ADK, LangGraph, বা BeeAI সদৃশ ফ্ৰেমৱৰ্কত নিৰ্মিত এজেণ্টসমূহক A2A ছাৰ্ভাৰ হিচাপে প্ৰকাশ কৰক।
- **এজেণ্ট সংযোগ কৰক:** A2A-অনুকূল এজেণ্টৰ সৈতে সংযোগ কৰিবলৈ আৰম্ভণিৰ পৰা বা ইন্টেগ্ৰেশ্যনৰ সহায়ত A2A ক্লায়েন্ট নিৰ্মাণ কৰক।
- **ওয়াৰ্কফ্ল’ অৰ্কেষ্ট্ৰেট কৰক:** A2A-অনুকূল এজেণ্টসমূহৰ ক্ৰমবদ্ধ আৰু শৃংখলাবদ্ধ ৱাৰ্কফ্ল’ নিৰ্মাণ কৰক।
- **মাল্টি-এজেণ্ট ছিষ্টেম:** বিভিন্ন ফ্ৰেমৱৰ্ক ব্যৱহাৰ কৰি এটা স্বাস্থ্য সেৱা মাল্টি-এজেণ্ট ছিষ্টেম নিৰ্মাণ কৰক আৰু A2A-এ কেনেকৈ সহযোগিতা সক্ষম কৰে চাওক।
- **A2A আৰু MCP:** A2A-এ কেনেকৈ MCP-ৰ সৈতে সম্পূৰকভাৱে কাম কৰে আৰু এজেণ্টসমূহে পৰস্পৰে সহযোগিতা কেনেকৈ কৰে শিকক।

## কিয় A2A?

AI এজেণ্টসমূহ অধিক সংখ্যাত উপস্থিত হোৱাৰ লগে লগে, তেওঁলোকৰ আন্তঃ-কাৰ্যক্ষমতা বৃহৎ, বহু-কাৰ্যক্ষম এপ্লিকেশ্যন নিৰ্মাণৰ বাবে অত্যাবশ্যক। A2A-ৰ লক্ষ্য হৈছে:

- **বিভাজন ভাঙক:** বিভিন্ন পৰিবেশৰ মাজত এজেণ্ট সংযোগ কৰক।
- **জটিল সহযোগিতা সক্ষম কৰক:** বিশেষজ্ঞ এজেণ্টসমূহক সেইবোৰ কামত একেলগে কৰাবলৈ সক্ষম কৰক, যি এটা এজেণ্টে একাই কৰিব নোৱাৰে।
- **মুক্ত মানদণ্ড উৎসাহিত কৰক:** এজেণ্ট যোগাযোগৰ বাবে এক গোট-চলিত দৃষ্টিভংগী আগবঢ়াওক, উদ্ভাৱন আৰু ব্যাপক গ্ৰহণৰ পথ মুকলি কৰক।
- **অপাকতা সংৰক্ষণ কৰক:** এজেণ্টসমূহে নিজৰ আভ্যন্তৰীণ স্মৃতি, স্বত্বাধিকাৰ যুক্তি, বা নিৰ্দিষ্ট টুলৰ ব্যৱহাৰ বিনিময় নকৰাকৈ সহযোগিতা কৰিব পাৰে, যিয়ে সুৰক্ষা বৃদ্ধি কৰে আৰু মেধাস্বত্ব সংৰক্ষণ কৰে।

### মুখ্য বৈশিষ্ট্যসমূহ

- **মানৱিক সংযোগ:** HTTP(S) ৰ ওপৰত JSON-RPC 2.0।
- **এজেন্ট বিচাৰি উলিওৱা:** "Agent Cards" ৰ জৰিয়তে সক্ষমতা আৰু সংযোগ তথ্যৰ বিৱৰণ।
- **লচকীয়া আন্তঃকৰ্য:** সিঙ্ক্ৰোনাছ অনুৰোধ/প্ৰতিক্ৰিয়া, ষ্ট্ৰিমিং (SSE), আৰু এছিঙ্ক্ৰোনাছ পুশ নোটিফিকেশ্যন সমৰ্থন কৰে।
- **সমৃদ্ধ তথ্য বিনিময়:** পাঠ, ফাইল, আৰু গঠিত JSON তথ্য ব্যৱহাৰ কৰিব পাৰে।
- **উদ্যোগ-উপযোগী:** নিৰাপত্তা, প্ৰমাণীকৰণ, আৰু পৰ্যবেক্ষণৰ দৃষ্টিভংগীৰে ডিজাইন কৰা হৈছে।

## আৰম্ভণি

- 📚 **ডকুমেন্টেশ্যন পৰীক্ষা কৰক:** [Agent2Agent Protocol Documentation Site](https://a2a-protocol.org) চাওক, সম্পূৰ্ণ পৰ্যালোচনাৰ বাবে, প্ৰটোকল স্পেচিফিকেশ্যন, টিউটোৰিয়েল, আৰু গাইডসমূহ উপলব্ধ।
- 📝 **স্পেচিফিকেশ্যন চাওক:** [A2A Protocol Specification](https://a2a-protocol.org/latest/specification/)
- SDK ব্যৱহাৰ কৰক:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) মেভেন ব্যৱহাৰ কৰি
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) ব্যৱহাৰ কৰি `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 আমাৰ [উদাহৰণসমূহ](https://github.com/a2aproject/a2a-samples) ব্যৱহাৰ কৰি A2A ৰ কাৰ্য্য দেখক

## অৱদান আগবঢ়োৱা

আমরা A2A প্ৰটোকল উন্নত আৰু বিকাশ কৰিবলৈ সমুদায়ৰ অৱদানক স্বাগতম জনাওঁ!

- **প্ৰশ্ন আৰু আলোচনা:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) ত যোগদান কৰক।
- **সমস্যা আৰু মতামত:** [GitHub Issues](https://github.com/a2aproject/A2A/issues) ৰ জৰিয়তে সমস্যা জনাওক বা উন্নয়নৰ পৰামৰ্শ দিয়ক।
- **অৱদান গাইড:** কেনেকৈ অৱদান আগবঢ়াব পাৰি তাৰ বাবে [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) চাওক।
- **ব্যক্তিগত মতামত:** এই [Google Form](https://goo.gle/a2a-feedback) ব্যৱহাৰ কৰক।
- **পাৰ্টনাৰ প্ৰগ্ৰাম:** Google Cloud গ্ৰাহকে এই [form](https://goo.gle/a2a-partner) ৰ জৰিয়তে আমাৰ পাৰ্টনাৰ প্ৰগ্ৰামত অংশগ্ৰহণ কৰিব পাৰে।

## আগলৈ কি

### প্ৰটোকল উন্নতি

- **এজেন্ট বিচাৰি উলিওৱা:**
    - `AgentCard` ৰ ভিতৰত অনুমতি পদ্ধতি আৰু ঐচ্ছিক প্ৰমাণপত্ৰৰ অন্তৰ্ভুক্তি আনুষ্ঠানিক কৰক।
- **এজেন্ট সহযোগিতা:**
    - সমৰ্থিত নোহোৱা বা অনুমান নকৰা দক্ষতা চাবৰ বাবে `QuerySkill()` পদ্ধতি অনুসন্ধান কৰক।
- **টাস্ক লাইফচাইকেল আৰু UX:**
    - এটা টাস্কৰ _ভিতৰত_ ডাইনামিক UX আলোচনাৰ বাবে সহায় (যেমন, এজেন্টে কথোপকথনৰ মাজত অডিঅ'/ভিডিঅ' যোগ কৰা)।
- **ক্লায়েন্ট মেথড আৰু ট্ৰান্সপৰ্ট:**
    - ক্লায়েন্টে আৰম্ভ কৰা মেথডৰ সহায় (টাস্ক ব্যৱস্থাপনা বাহিৰে) বিস্তাৰ কৰাৰ সন্ধান কৰা।
    - ষ্ট্ৰিমিংৰ বিশ্বস্ততা আৰু পুশ নোটিফিকেশ্যন ব্যৱস্থাৰ উন্নতি।

## সম্পৰ্কে

A2A প্ৰটোকল হৈছে Linux Foundation-ৰ অধীনত থকা এটা মুক্ত উৎস প্ৰকল্প, যি Google-এ অৱদান আগবঢ়াইছে। এইটো [Apache License 2.0](LICENSE)-ৰ অধীনত লাইচেন্স কৰা হৈছে আৰু সমাজৰ পৰা অৱদান গ্ৰহণ কৰিব পাৰে।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---