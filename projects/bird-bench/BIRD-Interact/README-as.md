<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=bird-bench&project=BIRD-Interact&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>

</div>

# BIRD-INTERACT 1.0 <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/hku-logo.jpg" alt="HKU Logo" width="50" style="vertical-align:middle;margin-left:10px;"> <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/google-cloud-logo.png" alt="Google Cloud Logo" width="50" style="vertical-align:middle;margin-left:10px;">

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/bird_interact.png" 
       style="width: 30%; min-width: 100px; display: block; margin: auto; border-radius: 15px !important;">
</p>



<div style="display: flex; justify-content: center; align-items: center; gap: 10px;">
  <a href="https://creativecommons.org/licenses/by-sa/4.0/deed.en">
    <img src="https://img.shields.io/badge/License-CC%20By%20SA%204.0-orange.svg" alt="License">
  </a>
  <a href="https://bird-interact.github.io/">
    <img src="https://img.shields.io/badge/Leaderboard-2025-28a745.svg" alt="Leaderboard">
  </a>
  <a href="https://huggingface.co/datasets/birdsql/bird-interact-lite/tree/main">
    <img src="https://img.shields.io/badge/Dataset-HuggingFace-FFD21E.svg" alt="HuggingFace">
  </a>
  <a href="https://www.python.org/downloads/release/python-310/">
    <img src="https://img.shields.io/badge/Python-3.10+-teal.svg" alt="Python">
  </a>
  <a href="https://pypi.org/project/openai/">
    <img src="https://img.shields.io/badge/OpenAI-1.40+-beige.svg" alt="OpenAI">
  </a>
</div>

## ⚠️ ঘোষণা  
অনুগ্ৰহ কৰি মনত ৰাখিব, আপোনাৰ মূল্যাংকন প্ৰক্ৰিয়াৰ আগতে, যেতিয়া Docker-এ ডেটাবেছসমূহ লোড কৰে, পৰিৱেশৰ অসামঞ্জস্যতাত কেতিয়াবা ত্ৰুটি ঘটিব পাৰে (এইবোৰে প্ৰক্ৰিয়া বন্ধ নকৰে, কিন্তু Docker লগত দেখা যায়)। ফলস্বৰূপ, কিছুমান ডেটাবেছ সঠিকভাৱে লোড নহ’ব পাৰে, যাৰ বাবে ডেটাবেছসমূহ খালী হৈ থাকিব। ইয়াৰ ফলত মূল্যাংকনৰ ফলাফল অস্বাভাৱিকভাৱে কম হ’ব।  
👉 সেইবাবে, **মূল্যাংকন চলোৱাৰ আগতে** Docker লগত কোনো ত্ৰুটি আছে নে নাই চাবলৈ আৰু সকলো ডেটাবেছ সফলভাৱে লোড হৈছে নে নাই নিশ্চিত কৰিবলৈ দৃঢ়ভাৱে পৰামৰ্শ দিয়া হৈছে।

## 📰 বাতৰি

- [2025-08-26] 🚀 আমি আনন্দিতভাৱে **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** ছেট মুক্তিৰ কথা ঘোষণা কৰিছোঁ!  
এইটো কঠিন — শ্ৰেষ্ঠ LLM-সমূহ মাত্ৰ **16.33%** সফলতাৰ হাৰ অর্জন কৰিছে, `c-interact` আৰু `a-interact` অংশত মাত্ৰ **10.0%**।  
👉 অধিক তথ্যৰ বাবে, অনুগ্ৰহ কৰি আমাৰ [project website](https://bird-interact.github.io/) চাওক।

- [2025-08-26] 📬 আমি এই সপ্তাহত **Ground Truth & Test cases** আমাৰ মেইলিং লিষ্টলৈ প্ৰেৰণ কৰিম।  
যদি আগতীয়াকৈ পাবলৈ ইচ্ছা থাকে, অনুগ্ৰহ কৰি ছাইটত উল্লেখ কৰা অনুসৰি ই-মেইল প্ৰেৰণ কৰক যাতে **স্বয়ংক্রিয় ডাউনলোড** কৰিব পাৰি।  

- [2025-08-26] 💾 আন এটা দিশত, আমি **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** ৰ SQLite সংস্কৰণ মুক্তি দিছোঁ, যাতে স্থানীয়ভাৱে গৱেষণা সহজ হয়।  
সম্পূর্ণ **LiveSQLBench-Base** আৰু **-Large** সংস্কৰণ খুব শীঘ্ৰে আহিব!

- [2025-08-22] **Bug Fix**: Bird-Interact-Agent ক’ডত, আমি এটা bug ঠিক কৰিছোঁ, য’ত phase-2 SQL মূল্যাংকন কৰাৰ সময়ত, সংৰক্ষণ কৰা phase-1 SQL সঠিকভাৱে সম্পাদন কৰিব নোৱাৰিছিল, ফলত Phase-2 ৰ সফলতাৰ হাৰ কম হৈছিল। এই bug কেৱল সেই task-সমূহত প্ৰভাৱিত হৈছিল, য’ত phase1 sql-এ ডেটাবেছত CREATE table আদি দৰে ক্ৰিয়াকলাপ কৰে।

## 🧸 পৰ্যালোচনা

BIRD-INTERACT, এটা আন্তঃকাৰ্য্যশীল পাঠ্য-টু-SQL বেঞ্চমাৰ্ক, **dynamic interaction ৰ দৃষ্টিকোণত পাঠ্য-টু-SQL মূল্যাংকনক পুনৰ চিন্তা কৰে**।
এই পৰিৱেশত এটা স্তৰভিত্তিক জ্ঞানভাণ্ডাৰ, ডেটাবেছ নথিপত্ৰ আৰু ফাংশ্যন-চালিত ব্যৱহাৰকাৰী simulator সংমিশ্ৰণ কৰি, সম্পূৰ্ণ **CRUD** অপাৰেশ্যনসমূহৰ জৰিয়তে প্ৰকৃত উদ্যোগ পৰিৱেশ পুনঃনিমাণ কৰা হয়।
ইয়াত দুটা কঠোৰ পৰীক্ষা ধৰণ আছে: (১) নিষ্ক্ৰিয় **সংলাপমূলক আন্তঃক্ৰিয়া** আৰু (২) সক্ৰিয় **এজেন্টিক আন্তঃক্ৰিয়া**, য’ত ৬০০ টা টীকা দিয়া কাৰ্য অন্তর্ভুক্ত আছে যেনে বিজনেছ ইন্টেলিজেন্স (BI), CRUD অপাৰেশ্যন আৰু আদি, প্রত্যেকটো কাৰ্যৰ নিৰ্বাহযোগ্য পৰীক্ষা কেছ দ্বাৰা সংৰক্ষিত।
প্ৰচলিত মূল্যায়নে মডেল আৰু ব্যৱহাৰকাৰী সিমুলেটৰৰ মাজত ১,৯৬৮-৫,৪৯৬ টা আন্তঃক্ৰিয়া পালা আৰম্ভ কৰে, য’ত আধুনিক যুক্তি মডেলসমূহ বৰ্তমানত কেৱল **≈২৪%** আৰু **≈১৮%** কাৰ্য সমাধান কৰিব পাৰে, এই বেঞ্চমাৰ্কৰ প্ৰত্যাহ্বান স্পষ্ট কৰি তোলে।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ দুটা মূল্যায়ন ধৰণ

BIRD-INTERACT-এ ওপৰত উল্লেখ কৰা দুটা মূল্যায়ন ধৰণ সমৰ্থন কৰে:

   - **c-Interact**: সংলাপমূলক আন্তঃক্ৰিয়া, যি এটা নিষ্ক্ৰিয় ধৰণ আৰু কৰ্মপদ্ধতি স্থিৰ। কোড আৰু বিস্তৃত তথ্য `bird_interact_conv`-ত পোৱা যাব।
   - **a-Interact**: এজেন্টিক আন্তঃক্ৰিয়া, যি এটা সক্ৰিয়, মডেলসমূহে পরিচালিত গতিৰূপ আৰু কৰ্মপদ্ধতি। কোড আৰু বিস্তৃত তথ্য `bird_interact_agent`-ত উপলব্ধ।


### 🐣 লাইট সংস্কৰণ

আমিবোৰ BIRD-INTERACT-ৰ এটা লাইট সংস্কৰণ, `bird-interact-lite-exp`, মুকলি কৰিছো, য’ত PostgreSQL-ৰ বাবে ২৭০ টা উচ্চ মানদণ্ডৰ বাস্তৱ কাৰ্য অন্তর্ভুক্ত। এইটো সোনকালে পৰীক্ষাৰ আৰম্ভণিৰ বাবে যথোপযুক্ত।

### 🦜 পূৰ্ণ সংস্কৰণ

BIRD-INTERACT-ৰ পূৰ্ণ সংস্কৰণ, `bird-interact-full`, এটা বিস্তৃত বেঞ্চমাৰ্ক, য’ত PostgreSQL-ৰ বাবে ৬০০ টা কাৰ্য অন্তর্ভুক্ত। ইয়াত SQL অপাৰেশ্যন আৰু ব্যৱহাৰকাৰী প্ৰশ্নৰ বিস্তৃত পৰিসৰ ঢাকিছে। পূৰ্ণ সংস্কৰণ শীঘ্ৰেই আহি আছে।

### BIRD-INTERACT Lite-ত মডেলৰ কার্যক্ষমতা ফলাফল

#### ১. **c-Interact** কার্যক্ষমতা
| স্থান | মডেল নাম         | স্বাভাবিকীকৃত ৰিওৱাৰ্ড | স্তৰ        |
|:------:|--------------------|:-------:|:--------------:|
| ১    | o3-mini            | ৩৩.০৪ | 🏆 উৎকৃষ্ট সংলাপ |
| ২    | GPT-4o             | ৩০.৩৩ | 💎 ভাল সংলাপ      |
| ৩    | Gemini-2.0-flash   | ২৭.৪১ | 💎 ভাল সংলাপ      |
| ৪    | Claude-3.7-sonnet  | ২৬.৬০ | ✨ মানদণ্ড       |
| ৫    | DeepSeek-R1        | ২১.৭৪ | ✨ মানদণ্ড       |
| ৬    | Qwen3              | ২০.৩৩ | ⚪ মৌলিক          |
| ৭    | DeepSeek-V3        | ১৫.৮৫ | ⚪ মৌলিক          |

#### ২. **a-Interact** কার্যক্ষমতা
| স্থান | মডেল নাম         | বাজেট পেৰামিটাৰ* | প্ৰতি কাৰ্য গড় পদক্ষেপ | প্ৰতি কাৰ্য গড় মূল্য (USD) | স্বাভাবিকীকৃত ৰিওৱাৰ্ড | স্তৰ            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| 1    | Claude-3.7-sonnet  | 6/6 | 15.4 | $0.6668 | 29.19 | 🏆 উৎকৃষ্ট আন্তঃকৰ্ম |
| 2    | o3-mini            | 6/6 | 7.8 | $0.0754 | 21.07 | 💎 ভাল আন্তঃকৰ্ম      |
| 3    | DeepSeek-V3        | 6/6 | 15.6 | $0.0629 | 19.19 | 💎 ভাল আন্তঃকৰ্ম      |
| 4    | Qwen3              | 6/6 | 12.5 | $0.0278 | 18.74 | ✨ মানক               |
| 5    | GPT-4o             | 6/6 | 15.3 | $0.4594 | 18.37 | ✨ মানক               |
| 6    | Gemini-2.0-flash   | 6/6 | 13.2 | $0.0337 | 17.26 | ⚪ মৌলিক              |
| 7    | DeepSeek-R1        | 6/6 | 12.0 | $0.0931 | 17.07 | ⚪ মৌলিক              |

> \* বাজেট পেৰামিটাৰ: আৰম্ভণি বাজেট/ব্যৱহাৰকাৰী ধৈৰ্য্য বাজেট, আমাৰ কল্পিত মুদ্ৰা *bird-coin* ৰে মাপি লোৱা হয় <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">। অধিক তথ্যৰ বাবে [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) চাওক।

### আন্তঃকৰ্ম-সময় স্কেলিং (ITS)

আন্তঃকৰ্ম-সময় স্কেলিং (ITS) মানে হৈছে এখন মডেলৰ বহু-ঘূৰণীয়া আন্তঃকৰ্মৰ জৰিয়তে তেওঁৰ চূড়ান্ত কাৰ্যক্ষমতা অব্যাহতভাৱে বৃদ্ধি কৰাৰ সক্ষমতা। যেতিয়া এই আন্তঃকৰ্ম কাৰ্যক্ষমতা মডেলৰ সৰ্বোচ্চ এক-পটীয়া কাৰ্যক্ষমতাৰ ওপৰত গৈ যায়, তেতিয়া আমি কৈছো যে ই **ITS নিয়ম** পূৰণ কৰে। ব্যৱহাৰকাৰীৰ ধৈৰ্য্য বৃদ্ধি হোৱাৰ লগতে আন্তঃকৰ্মৰ সংখ্যা বৃদ্ধি পালে, কাৰ্যক্ষমতাও বৃদ্ধি পায়, যাৰ দ্বাৰা মডেলটো দীঘলীয়া সংলাপত ব্যৱহাৰকাৰীৰ সৈতে সফলভাৱে যোগাযোগ বজাই ৰাখিব পাৰে। বৰ্তমানে, কেৱল claude-3-7-sonnet-এ ITS নিয়ম পূৰণ কৰে বুলি পোৱা গৈছে।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 ডাটাসেটৰ বিৱৰণ

### ডাটাসেটৰ বৰ্ণনা

- **ডেটাবেইজ:** সম্পূর্ণ PostgreSQL ডেটাবেইজ [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) ৰ পৰা ডাউনলোড কৰিব পাৰি। অধিক তথ্যৰ বাবে [Quick Eval](#quick-eval) চাওক।
- **data:** প্ৰতিটো ডাটা ইনষ্টেন্সত তলৰ মুখ্য অংশসমূহ থাকে:
   - `selected_database`: ডেটাবেইজৰ নাম।  
   - `query`: স্পষ্ট ব্যৱহাৰকাৰী প্ৰশ্ন।  
   - `amb_user_query`: অস্পষ্টতা সংযোজিত ব্যৱহাৰকাৰীৰ প্ৰশ্ন।
   - `user_query_ambiguity`: ব্যৱহাৰকাৰীৰ প্ৰশ্নত সংযোজিত অস্পষ্টতা।
   - `non_critical_ambiguity`: অ-গুরুত্বপূর্ণ অস্পষ্টতা যেনে order, limit, আদি।
   - `knowledge_ambiguity`: বাহ্যিক জ্ঞান গোপন কৰি সৃষ্টি কৰা অস্পষ্টতা। 
   - `sol_sql`: সঠিক উত্তৰ SQL সমাধান।  
   - `preprocess_sql`: সমাধান বা অনুমান চলোৱাৰ আগতে চলাব লগা SQL।  
   - `clean_up_sql`: টেষ্ট কেচৰ পিছত ডেটাবেইজ পুনৰুদ্ধাৰ কৰিবলৈ চলাব লগা SQL।  
   - `test_cases`: অনুমান কৰা SQL যাচাই কৰিবলৈ টেষ্ট কেচৰ সমষ্টি।
   - `follow_up`: লেবেল কৰা অনুগামী প্ৰশ্নসমূহ।
   - `external_knowledge`: নিৰ্দিষ্ট টাস্কৰ সৈতে সম্পৰ্কিত বাহ্যিক জ্ঞান।

- **evaluation:** মূল্যায়ন কোড [`./evaluation`](./evaluation) ডাইৰেক্টৰীত উপলব্ধ।
- **Curated by:** BIRD Team & Google Cloud
- **লাইচেঞ্চ:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace ডেটাছেট কাৰ্ড:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### ডেটাছেট ব্যৱহাৰ

স্বয়ংক্ৰিয়ভাৱে তথ্য সংগ্ৰহ কৰাৰ ফলত ডেটা লীকেজ ৰোধ কৰিবলৈ, আমি ডেটাৰ সৈতে GT সমাধান sql আৰু পৰীক্ষণ কেচসমূহ সংলগ্ন কৰা নাই।
সম্পূৰ্ণ ছেটৰ বাবে, অনুগ্ৰহ কৰি শিৰোনামত `[bird-interact-lite GT&Test Cases]` টেগসহ [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) ই-মেইল কৰক, যি স্বয়ংক্ৰিয়ভাৱে প্ৰেৰণ কৰা হ'ব।


<!-- ### HuggingFace ৰ পৰা ডেটাছেট ব্যৱহাৰ কৰক

আপুনি তলৰ নিৰ্দেশনা অনুসৰি HuggingFace ৰ পৰা ডেটাছেট ডাউনলোড কৰিব পাৰে:
```bash
from datasets import load_dataset
# Load the flash version of the dataset
dataset = load_dataset("birdsql/bird-interact-lite")
print(dataset["lite"][0])

# Load the full version of the dataset (coming soon)
dataset = load_dataset("birdsql/bird-interact-full")
print(dataset["full"][0])
```
অথবা আপুনি আগবঢ়োৱা স্ক্ৰিপ্ট ব্যৱহাৰ কৰি ডেটাসেটৰ সম্পূৰ্ণ সংস্কৰণ ডাউনল'ড কৰিব পাৰে আৰু ইয়াক বিভিন্ন উপভাষালৈ বিভাজন কৰিব পাৰে।

```bash
cd baseline/data
python pull_data.py \
  --schema_path path/to/full_schema.jsonl \
  --input_path path/to/input.jsonl \ # ইনপুট JSONL ফাইলৰ পথ (আপুনি যদি ডেটাসেটটো HuggingFace ৰ পৰা ডাউনলোড কৰিব বিচাৰে, তেন্তে এইটো খালী হ’ব পাৰে)
  --output_folder path/to/output_dir # বিভাজিত ফাইলসমূহৰ আউটপুট ফোল্ডাৰ
```

## ফোল্ডাৰ গঠন
```ultree
.
├── LICENSE
├── README.md
├── bird_interact_conv
│   ├── ...
│   └── README.md
├── bird_interact_agent
│   ├── ...
│   └── README.md
├── evaluation
│   ├── docker-compose.yml
│   ├── env
│   ├── postgre_table_dumps
│   ├── run
│   └── src
├── materials
│   ├── ...
└── requirements.txt
```
**a-interact** চলাবলৈ প্ৰয়োজনীয় বিৱৰণ `./bird_interact_agent/README.md`-ত পোৱা যায়; আৰু **c-interact**-ৰ বিৱৰণ `./bird_interact_conv/README.md`-ত পোৱা যায়।

## 📋 টুডু তালিকা

- [x] লাইট সংস্কৰণ মুক্তি, bird-interact-lite (270)।
- [x] কথোপকথন সংস্কৰণ মুক্তি, bird-interact-conv।
- [x] এজেন্ট সংস্কৰণ মুক্তি, bird-interact-agent।
- [x] সম্পূর্ণ bird-interact-full (600) মুক্তি।
- [ ] SFT / RL আৰু ইউজাৰ ছিমুলেটৰ

## সৃষ্টি কৰিছে:
BIRD Team & Google Cloud








---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---