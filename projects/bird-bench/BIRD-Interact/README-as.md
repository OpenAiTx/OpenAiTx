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
অনুগ্ৰহ কৰি মনত ৰাখিব, আপোনাৰ মূল্যায়ন প্ৰক্ৰিয়াৰ আগতে, যেতিয়া Docker-এ ডেটাবেছসমূহ লোড কৰে, পৰিৱেশৰ অসামঞ্জস্যতাৰ বাবে কেতিয়াবা ত্ৰুটি দেখা দিব পাৰে (এইবোৰে প্ৰক্ৰিয়া সামৰণি নিদিয়ে, কিন্তু Docker লগত দেখা যাব)। ফলস্বৰূপ, কিছুমান ডেটাবেছ সঠিকভাৱে লোড নহ’ব পাৰে, যাৰ ফলত খালী ডেটাবেছ হ’ব পাৰে। ইয়াৰ ফলত মূল্যায়নৰ ফলাফল অস্বাভাৱিকভাৱে কম হ’ব পাৰে।  
👉 সেয়া বাবে, আমি দৃঢ়ভাৱে পৰামৰ্শ দিছোঁ যাতে মূল্যায়ন চলোৱাৰ আগতে **Docker লগত কোনো ত্ৰুটি আছে নে নাই** পৰীক্ষা কৰক আৰু সকলো ডেটাবেছ সফলতাৰে লোড হৈছে নে নাই নিশ্চিত কৰক।

👉 আমি **Submission Guidelines** আপডেট কৰিছোঁ, য’ত কাষ্টমাইজ্ড এজেন্ট স্কেফল্ডসমূহক সমৰ্থন কৰা হৈছে। অনুগ্ৰহ কৰি আমাৰ বিস্তারিত জমা দিয়াৰ নিৰ্দেশিকা [এই ঠাইত](https://docs.google.com/document/d/1F1DSqHDBzGvXFlWU8iCl9otkqxIefgcH/edit?usp=sharing&ouid=108161566779099489782&rtpof=true&sd=true) চাওক।

## 📰 বাতৰি

- [২০২৬-০৩-২৯] 🔥🔥🔥 **BIRD-Interact-ADK**: আমি মুক্তি দিছোঁ **[BIRD-Interact-ADK](./BIRD-Interact-ADK/)**, এটা Google ADK-ভিত্তিক বাস্তবায়ন য’ত আছে মডুলাৰ ৩-মাইক্রোসাৰ্ভিচ (এজেন্ট, ইউজাৰ ছিমুলেটৰ, আৰু DB Env) স্থাপত্য। আপোনাৰ নিজা এজেন্ট, ইউজাৰ ছিমুলেটৰ বা ডেটাবেছ পৰিবেশ সহজে সলনি কৰিব পাৰিব। সমান্তৰাল এক্সেকিউশ্যন আৰু যিকোনো [LiteLlm-compatible](https://docs.litellm.ai/docs/providers) LLM প্ৰভাইডাৰ সমৰ্থন কৰে। গৱেষণাৰ বাবে এই বাস্তবায়ন ব্যৱহাৰৰ পৰামৰ্শ দিয়া হৈছে।

- [২০২৬-০২-০৮] 🔥🔥🔥 আমাৰ **[Bird-Interact paper](https://huggingface.co/papers/2510.05318)** **ICLR 2026 (Oral)**-ত গ্ৰহণ কৰা হৈছে! ৰিঅ’ত দেখা হ’ব 🇧🇷!  

- [২০২৫-১১-০৬] 🐛 **বাগ ফিক্স** & 🐳 **Docker আপডেট**: sqlglot সংস্কৰণ ২৬.১৬.৪-লৈ আপডেট কৰি ইউজাৰ ছিমুলেটৰৰ বাবে SQL সঠিকভাৱে পাৰ্ছ কৰিব নোৱাৰা বাগটো সমাধান কৰা হৈছে। আপুনি `bird_interact_eval` পৰিবেশত `pip install sqlglot==26.16.4` দ্বাৰা পুনৰ ইনষ্টল কৰি সমাধান কৰিব পাৰে। `bird_interact_eval` ইমেজো আপডেট কৰা হৈছে, সেইবাবে আপুনি পুনৰ টানি নতুন `bird_interact_eval` কণ্টেইনাৰ সৃষ্টি কৰিব পাৰে।

- [২০২৫-১০-২১] 🐳 **Docker আপডেট**: আমি সম্পূৰ্ণ ডেটাবেছ পৰিবেশৰ বাবে Docker যোগ দিছোঁ। আৰু আমি ৩টা Docker ইমেজ (Base/Full DB Env আৰু মূল্যায়ন পৰিবেশ `a-Interact` আৰু `c-Interact` উভয়ৰ বাবে) Docker Hub-ত আপলোড কৰিছোঁ যাতে পৰিবেশ স্থাপন সহজ হয়। DB ডাম্প ডাউনলোড আৰু ইমেজ মেনুৱেলি বনোৱাৰ প্ৰয়োজন নাই!

- [২০২৫-১০-০৮] 📝 আমাৰ **[Bird-Interact paper](https://huggingface.co/papers/2510.05318)** এতিয়া সৰ্বসাধাৰণৰ বাবে উপলব্ধ!  
  ইয়াত সম্পূৰ্ণ বিৱৰণ, পদ্ধতি আৰু আমাৰ ইনটাৰেক্টিভ টেক্সট-টু-SQL বেঞ্চমাৰ্কৰ মূল্যায়ন দিয়া হৈছে।  
  👉 [BIRD-Interact](https://bird-interact.github.io/)ৰ পিছৰ আইডিয়াসমূহ জানিবলৈ চাওক।

- [২০২৫-০৮-২৬] 🚀 আমি **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** চেট মুক্তি দিয়া ঘোষিত কৰিছোঁ!  
এইটো কঠিন — শ্ৰেষ্ঠ LLMসমূহে কেৱল **১৬.৩৩%** সফলতা লাভ কৰিছে, `c-interact` আৰু `a-interact` অংশত কেৱল **১০.০%**।  
👉 অধিক তথ্যৰ বাবে, অনুগ্ৰহ কৰি আমাৰ [প্ৰকল্প ৱেবছাইট](https://bird-interact.github.io/) চাওক।

- [2025-08-26] 📬 আমি এই সপ্তাহত আমাৰ মেইলিং তালিকাত **Ground Truth & Test cases** পঠাব।  
যদি আপুনি আগতীয়াকৈ লাভ কৰিব বিচাৰে, অনুগ্ৰহ কৰি ছাইটত উল্লেখ কৰা নিয়ম অনুসৰি ইমেইল পঠিয়াওক **স্বয়ংক্ৰিয় ডাউনলোড**ৰ বাবে।  

- [2025-08-26] 💾 আন এটা দিশত, আমি **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** ৰ SQLite সংস্কৰণ মুক্তি দিছোঁ, যাতে স্থানীয়ভাৱে গৱেষণা সহজ হয়।  
সম্পূর্ণ **LiveSQLBench-Base** আৰু **-Large** সংস্কৰণ শীঘ্ৰে আহিব!

- [2025-08-22] **বাগ ফিক্স**: Bird-Interact-Agent ক'ডত, আমি এটা বাগ ফিক্স কৰিছোঁ য'ত phase-2 SQL মূল্যায়ন কৰাৰ সময়ত, সংৰক্ষিত phase-1 SQL সফলভাৱে চলিব নোৱাৰে, ফলত Phase-2 ৰ সফলতা হাৰ কম হয়। এই বাগ মাত্ৰ সেই টাস্কসমূহত প্ৰভাৱিত হয় য'ত phase1 sql ডাটাবেইচত কিছুমান প্ৰচলিত অপাৰেশ্যন কৰে, যেনে CREATE table, আদি।

## 🧸 সংক্ষিপ্ত বিৱৰণ

BIRD-INTERACT, এটা ইন্টাৰেক্টিভ টেক্স্ট-টু-SQL বেঞ্চমাৰ্ক, **dynamic interaction ৰ lens ৰে Text-to-SQL মূল্যায়ন পুনৰ কল্পনা কৰে**।
এই পৰিৱেশে এটা হায়াৰাৰ্কিকেল জ্ঞানভিত্তি, ডাটাবেইচ ডকুমেণ্টেশ্যন আৰু ফাংশন-চালিত ইউজাৰ চিমুলেটৰ সংমিশ্ৰণ কৰে, যাতে পূৰ্ণ **CRUD** অপাৰেশ্যনসমূহত প্ৰকৃত এন্টাৰপ্ৰাইজ পৰিৱেশ পুনঃনির্মাণ হয়।
এই বেঞ্চমাৰ্কত দুটা কঠোৰ টেষ্ট মোড আছে: (1) নিষ্ক্ৰিয় **Conversational Interaction** আৰু (2) সক্ৰিয় **Agentic Interaction**, যি 600 টা এনোটেটেড টাস্কৰ বিস্তৃত, Business Intelligence (BI), CRUD অপাৰেশ্যন আদি অন্তৰ্ভুক্ত, আৰু প্ৰতিটো টাস্ক executable test cases ৰে সুৰক্ষিত।
সাধাৰণ মূল্যায়নসমূহত মডেল আৰু ইউজাৰ চিমুলেটৰৰ মাজত 1,968-5,496 interaction turn হয়, আৰু আধুনিক reasoning মডেলসমূহে মাত্ৰ **≈24%** আৰু **≈18%** টাস্ক সফলভাৱে সমাধান কৰে, যাৰ দ্বাৰা বেঞ্চমাৰ্কৰ চেলেঞ্জ স্পষ্ট হয়।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ দুটা মূল্যায়ন মোড

BIRD-INTERACT ত উপৰোক্ত দুটা মূল্যায়ন মোড আছে:

   - **c-Interact**: Conversational Interaction যি এটা নিষ্ক্ৰিয় মোড, আৰু workflow স্থিৰ। ক'ড আৰু বিস্তৃত তথ্য `bird_interact_conv` ত পোৱা যায়।
   - **a-Interact**: Agentic Interaction যি এটা embodied সক্ৰিয় মোড, workflow dynamic আৰু মডেল-নেতৃত্বাধীন। ক'ড আৰু বিস্তৃত তথ্য `bird_interact_agent` ত পোৱা যায়।


### 🐣 Lite সংস্কৰণ

আমি BIRD-INTERACT ৰ lite সংস্কৰণ, `bird-interact-lite-exp`, মুক্তি দিছোঁ, য'ত PostgreSQL ৰ বাবে 270 টা উচ্চ-মানৰ বাস্তৱিক টাস্ক অন্তৰ্ভুক্ত। এইটো তৎক্ষণাত পৰীক্ষাৰ বাবে ভাল আৰম্ভণি।

### 🦜 সম্পূর্ণ সংস্কৰণ

BIRD-INTERACT ৰ সম্পূর্ণ সংস্কৰণ, `bird-interact-full`, এটা বিস্তৃত বেঞ্চমাৰ্ক য'ত PostgreSQL ৰ বাবে 600 টা টাস্ক আছে। ই SQL অপাৰেশ্যন আৰু ইউজাৰ কুৱেৰীৰ বিস্তৃত ক্ষেত্ৰ কভার কৰে। সম্পূর্ণ সংস্কৰণ শীঘ্ৰে আহিব।

### BIRD-INTERACT-FULL ৰ মডেল পাৰফৰ্মেন্স ফলাফল

#### 1. **c-Interact Text-to-SQL** কাৰ্যক্ষমতা
| স্থান | মডেলৰ নাম           | সাধাৰণীকৃত ইনাম     | প্ৰতি কামৰ গড় খৰচ (USD) | স্তৰ                 |
|:----:|:-------------------|:--------------------:|:------------------------:|:---------------------:|
| 1    | Gemini-2.5-Pro     | 20.92                | $0.04                    | 🏆 উৎকৃষ্ট চেট        |
| 2    | O3-Mini            | 20.27                | $0.07                    | 🏆 উৎকৃষ্ট চেট        |
| 3    | Claude-Sonnet-4    | 18.35                | $0.29                    | 💎 ভাল চেট            |
| 4    | Qwen-3-Coder-480B  | 17.75                | $0.11                    | 💎 ভাল চেট            |
| 5    | Deepseek-Chat-V3.1 | 15.15                | $0.12                    | ✨ মানক               |
| 6    | Claude-Sonnet-3.7  | 13.87                | $0.29                    | ✨ মানক               |
| 7    | GPT-5              | 12.58                | $0.08                    | ⚪ প্ৰাথমিক           |

#### 2. **a-Interact Text-to-SQL** কাৰ্যক্ষমতা
| স্থান | মডেলৰ নাম           | সাধাৰণীকৃত ইনাম     | প্ৰতি কামৰ গড় খৰচ (USD) | স্তৰ                       |
|:----:|:-------------------|:--------------------:|:------------------------:|:--------------------------:|
| 1    | GPT-5              | 25.52                | $0.24                    | 🏆 উৎকৃষ্ট ইন্টাৰেকশ্যন    |
| 2    | Claude-Sonnet-4    | 23.28                | $0.51                    | 🏆 উৎকৃষ্ট ইন্টাৰেকশ্যন    |
| 3    | Claude-Sonnet-3.7  | 17.45                | $0.60                    | 💎 ভাল ইন্টাৰেকশ্যন        |
| 4    | Gemini-2.5-Pro     | 17.33                | $0.22                    | 💎 ভাল ইন্টাৰেকশ্যন        |
| 5    | O3-Mini            | 16.43                | $0.06                    | ✨ মানক                   |
| 6    | Deepseek-Chat-V3.1 | 13.47                | $0.06                    | ✨ মানক                   |
| 7    | Qwen-3-Coder-480B  | 10.58                | $0.07                    | ⚪ প্ৰাথমিক               |

> \* বাজেট পেৰামিটাৰ: আৰম্ভণি বাজেট/ব্যৱহাৰকাৰীৰ ধৈৰ্য্য বাজেট, আমাৰ ভাৰ্চুৱেল মুদ্ৰা *bird-coin*s <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;"> দ্বাৰা মাপা হয়। অধিক তথ্যৰ বাবে [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) চাওক।

### ইন্টাৰেকশ্যন-টাইম স্কেলিং (ITS)

ইন্টাৰেকশ্যন-টাইম স্কেলিং (ITS) অৰ্থ হৈছে এখন মডেলৰ বহুমোৰী ইন্টাৰেকশ্যনৰ জৰিয়তে তাৰ চূড়ান্ত কার্যক্ষমতা অব্যাহতভাৱে বৃদ্ধি কৰাৰ সামৰ্থ্য। যেতিয়া এই ইন্টাৰেক্টিভ কার্যক্ষমতাই সম্পূৰ্ণৰূপে নিৰ্দিষ্ট, অসন্দিগ্ধ কামত মডেলৰ আদৰ্শ এক-মোৰী কার্যক্ষমতাক অতিক্ৰম কৰে, তেতিয়া আমি কওঁ যে সেই মডেলটোৱে **ITS নিয়ম** মানে। ব্যৱহাৰকাৰীৰ ধৈৰ্য্য বৃদ্ধি পালে আৰু ইন্টাৰেকশ্যন পালি সংগ্ৰহ হʼলে, কার্যক্ষমতা উন্নত হʼতেই থাকে, যি মডেলটোৱে দীঘল সংলাপত প্ৰভাৱশালী যোগাযোগ বজাই ৰাখিব পাৰে বুলি প্ৰমাণ কৰে। বৰ্তমান আমি কেৱল claude-3-7-sonnet মডেলটোৱেই ITS নিয়ম মানে বুলি পোৱা গৈছে।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## পৰিবেশ স্থাপন

1. bird-interact-lite ডেটাবেছ, bird-interact-full ডেটাবেছ, আৰু মূল্যায়ন পৰিবেশৰ বাবে Docker কন্টেইনাৰ চলাওক:
  
  > যদি আপুনি কেৱল `bird-interact-lite`ত মূল্যায়ন কৰিব বিচাৰে, তেন্তে `docker-compose.yml`ৰ [postgresql_full সেৱা](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/./env/docker-compose.yml#L21-L31) কমেণ্ট আউট কৰিলে পৰিবেশ স্থাপন অধিক দ্ৰুত হʼব।
  
  পৰিবেশ আৰম্ভ কৰিবলৈ এইটো চলাওক:
   ```bash
   cd env
   docker compose pull 
   docker compose up -d
   ```
   ডেটাবেছ আৰম্ভণিৰ বাবে কেইমিনিটমান অপেক্ষা কৰক।

  আপুনি নিৰ্মাণৰ প্ৰগতি তলত দৰ্শন কৰিব পাৰে:
  ```bash
  docker compose logs -f --tail=100 bird_interact_postgresql_full # or bird_interact_postgresql for bird-interact-lite
  ```
  যদি সম্পূৰ্ণ হোৱা থাকে, আপুনি ত্ৰুটিবিহীনভাৱে লগসমূহ চাব লাগিব যেনে:

  ```bash
  bird_interact_postgresql_full  | 2025-10-28 17:58:30.413 HKT [1] LOG:  database system is ready to accept connection
  ```
  
  যদি আপুনি পূৰ্বে containers সৃষ্টি কৰিছে আৰু পুনৰ সৃষ্টি কৰিব বিচাৰে, তেন্তে তলত দিয়া নিৰ্দেশনা চলাব পাৰে:
  ```bash
  docker compose down -v # this cmd removes the containers and the volumes
  docker compose pull   # pull the latest images from Docker Hub
  docker compose up -d --force-recreate # build and start the containers again. --force-recreate means force the recreation of the containers. 
  # Or `docker compose up -d --force-recreate bird_interact_eval` to only recreate the bird_interact_eval container about evalution code environment.
  ```
   
   এইটো ৩টা কণ্টেইনাৰ চলায় যি আগতে নিৰ্মিত ইমেজসমূহ Docker Hub ৰ পৰা ব্যৱহাৰ কৰে:
   - `bird_interact_postgresql`: bird-interact-lite ৰ বাবে PostgreSQL ডেটাবেছ
   - `bird_interact_postgresql_full`: bird-interact-full ৰ বাবে PostgreSQL ডেটাবেছ
   - `bird_interact_eval`: `a-Interact` আৰু `c-Interact` উভয়ৰ বাবে মূল্যাংকন পৰিবেশ।

   এতিয়া, আপুনি তলত দিয়া নিৰ্দেশনা চলাই মূল্যাংকন পৰিবেশ আৰম্ভ কৰিব পাৰিব:
   ```bash
   docker compose exec bird_interact_eval bash
   ```

2. (ঐচ্ছিক) পৰিবেশটো নিজে নিজে নিৰ্মাণ কৰক (যদি আপুনি ছবিসমূহ আৰম্ভণিৰ পৰা নিৰ্মাণ কৰিব বিচাৰে): 
   - ডাটাবেছ ডাম্পসমূহ ডাউনলোড কৰক 
      - [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view)। আনজিপ কৰক আৰু ইয়াক `env/postgre_table_dumps` হিচাপে পুনৰ নামকৰণ কৰক।
      - [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view)। আনজিপ কৰক আৰু ইয়াক `env/postgre_table_dumps_full` হিচাপে পুনৰ নামকৰণ কৰক।
   - `docker-compose.build.yml` চলাই নিজে নিজে পৰিবেশটো নিৰ্মাণ কৰক।
      ```bash
      cd env/
      docker compose -f docker-compose.build.yml build
      docker compose -f docker-compose.build.yml up -d
      ```

৩. (সুপারিশকৃত) পৰীক্ষা কৰক যে ডেটাবেছ কণ্টেইনাৰসমূহ সফলভাৱে নিৰ্মাণ আৰু চলি আছে।

-  কণ্টেইনাৰৰ নিৰ্মাণ লগসমূহ মুদ্ৰণ কৰক যাতে নিশ্চিত কৰিব পৰা যায় যে ডেটাবেছসমূহ কোনো ত্ৰুটি নোহোৱাকৈ সফলভাৱে নিৰ্মাণ হৈছে:
   ```bash 
   docker logs bird_interact_postgresql > build_bird_interact_postgresql.log 2>&1
   docker logs bird_interact_postgresql_full > build_bird_interact_postgresql_full.log 2>&1
   ```
   যদি ত্ৰুটি দেখা দেয়, `"Errors occurred during import:"` লগ ফাইলত ছাপ হ'ব।


-  পৰীক্ষা কৰক যে ডেটাবেচ কন্টেইনাৰসমূহ সুস্থ অৱস্থাত আছে নে নাই।
   
   ডেটাবেচ মেটাডাটা যাচাই কৰিবলৈ আমাৰ প্ৰদান কৰা Python স্ক্ৰিপ্ট ব্যৱহাৰ কৰক:
   ```bash
   docker compose exec bird_interact_eval bash
   cd /app/env
   python check_db_metadata.py --host bird_interact_postgresql
   python check_db_metadata.py --host bird_interact_postgresql_full
   ```
   
   আশা কৰা ফলাফল:
   - **bird-interact-lite**: 
     - 📈 মুঠ ডেটাবেছ: ১৮
     - 📋 মুঠ টেবুল: ১৭৫
     - 🔢 মুঠ কলাম: ২২৮৬
     - 📈 প্ৰতি টেবুলত গড় শাৰীৰ সংখ্যা: ১,০৩৮.৪৮
     - 💾 মুঠ আকাৰ: ২০৭.১৫ এম.বি. (প্ৰায়)
   - **bird-interact-full**: 
     - 📈 মুঠ ডেটাবেছ: ২২
     - 📋 মুঠ টেবুল: ২৪৪
     - 🔢 মুঠ কলাম: ২০১১
     - 📈 প্ৰতি টেবুলত গড় শাৰীৰ সংখ্যা: ১,১২১.১৯
     - 💾 মুঠ আকাৰ: ২৭২.০০ এম.বি. (প্ৰায়)


## 📦 ডেটাসেটৰ বিৱৰণ

### ডেটাসেটৰ বৰ্ণনা

- **ডেটাবেছ:** সম্পূৰ্ণ PostgreSQL ডেটাবেছ [bird-interact-lite](https://drive.google.com/file/d/1QIGQlRKbkqApAOrQXPqFJgUg8rQ7HRRZ/view) আৰু [bird-interact-full](https://drive.google.com/file/d/1V9SFIWebi27JtaDUAScG1xE9ELbYcWLR/view)ৰ পৰা ডাউনলোড কৰিব পাৰি।
- **data:** প্ৰতিটো ডেটা ইনষ্টেন্সত তলত উল্লেখ কৰা মূল অংশসমূহ থাকে:
   - `selected_database`: ডেটাবেছৰ নাম।  
   - `query`: স্পষ্ট ইউজাৰ কুয়েৰি।  
   - `amb_user_query`: অস্পষ্টতা সংযোগ কৰা ইউজাৰ কুয়েৰি।
   - `user_query_ambiguity`: ইউজাৰ কুয়েৰিত সংযোগ কৰা অস্পষ্টতাসমূহ।
   - `non_critical_ambiguity`: অ-গুরুত্বপূর্ণ অস্পষ্টতা যেনে order, limit, আদি।
   - `knowledge_ambiguity`: বাহ্যিক জ্ঞান আৱৃত কৰা অস্পষ্টতা। 
   - `sol_sql`: মূল SQL সমাধান।  
   - `preprocess_sql`: সমাধান বা পূৰ্বানুমান চলোৱাৰ আগতে চলাবলগীয়া SQL কুয়েৰি।  
   - `clean_up_sql`: পৰীক্ষাৰ পিছত ডেটাবেছৰ কোনো পৰিবর্তন উলটাবলগীয়া SQL কুয়েৰি।  
   - `test_cases`: পূৰ্বানুমান সংশোধিত SQL যাচাই কৰিবলৈ পৰীক্ষা কেচসমূহ।
   - `follow_up`: লেবেল কৰা অনুগামী প্ৰশ্নসমূহ।
   - `external_knowledge`: নিৰ্দিষ্ট কামৰ সৈতে সম্পৰ্কিত বাহ্যিক জ্ঞান।

- **evaluation:** মূল্যায়ন ক’ড [`./evaluation`](./evaluation) ডিৰেক্টৰিত উপলব্ধ।
- **Curated by:** BIRD Team & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace ডেটাসেট কাৰ্ড:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)
  আৰু [bird-interact-full](https://huggingface.co/datasets/birdsql/bird-interact-full) PostgreSQLৰ বাবে; আৰু [mini-interact](https://huggingface.co/datasets/birdsql/mini-interact) SQLiteৰ বাবে।
### ডেটাসেট ব্যৱহাৰ

ডাটা স্বয়ংক্ৰিয়ভাৱে সংগ্ৰহ কৰাৰ ফলত ডাটা লিকেজ ৰোধ কৰিবলৈ, আমি GT সমাধান sql আৰু পৰীক্ষা কেছসমূহ ডাটাৰ সৈতে সংলগ্ন কৰা নাই।
অনুগ্ৰহ কৰি [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) ইমেইল কৰক, আৰু বিষয়ত `[bird-interact-lite GT&Test Cases]` অথবা `[bird-interact-full GT&Test Cases]` টেগ ব্যৱহাৰ কৰক, যাতে bird-interact-lite বা bird-interact-full ডেটাসেটৰ বাবে ground truth আৰু test cases স্বয়ংক্ৰিয়ভাৱে প্ৰেৰণ কৰা হ’ব।


### ৰাজহুৱা ডেটা আৰু ground truth আৰু test cases সংলগ্ন কৰক

তাৰ পিছত তলত দিয়া স্ক্ৰিপ্ট ব্যৱহাৰ কৰি ৰাজহুৱা ডেটা, ground truth আৰু test cases সংলগ্ন কৰক:

সম্পূৰ্ণ সংস্কৰণৰ উদাহৰণ হিচাপে ধৰা হ’ল:
(1) চলাও:
```bash
python combine_public_with_gt.py /path/to/bird-interact-full/bird_interact_data.jsonl /path/to/bird_interact_full_gt_kg_testcases_08022.jsonl /path/to/bird_interact_data.jsonl  # bird_interact_full_gt_kg_testcases_08022.jsonl is the data of ground-truth fields, which is obtained by emailing us.
```
এইটো `/path/to/bird_interact_data.jsonl`-ত সংযুক্ত তথ্যৰ সৈতে এটা নতুন ফাইল সৃষ্টি কৰিব। 

(2) তাৰপিছত মূল পাব্লিক তথ্যটো সংযুক্ত তথ্যৰ সৈতে প্ৰতিস্থাপন কৰক:

```bash
cp /path/to/bird_interact_data.jsonl /path/to/bird-interact-full/bird_interact_data.jsonl
```

অন্যান্য সংস্কৰণসমূহৰ ক্ষেত্ৰতো একেই: bird-interact-lite, mini version, আদি। কেৱল public data আৰু ground truth আৰু test cases-ৰ বাবে সঠিক path নিৰ্ধাৰণ কৰক, আৰু তাৰ পিছত public data-টো combined data-ৰে পৰিৱৰ্তন কৰক।




<!-- ### HuggingFace-ৰ পৰা Dataset ব্যৱহাৰ কৰক

নিম্নলিখিত আদেশ ব্যৱহাৰ কৰি আপুনি HuggingFace-ৰ পৰা dataset download কৰিব পাৰে:
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
├── BIRD-Interact-ADK
│   ├── ...
│   └── README.md
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
**a-interact** চলাবলৈ সম্পূৰ্ণ বিৱৰণ `./bird_interact_agent/README.md`-ত পোৱা যাব; **c-interact**-ৰ বাবে `./bird_interact_conv/README.md`-ত পোৱা যাব; আৰু **ADK-ভিত্তিক বাস্তবায়ন** `./BIRD-Interact-ADK/README.md`-ত উপলব্ধ।

## 📋 কৰণীয় সূচীসমূহ

- [x] লাইট সংস্কৰণ মুক্তি, bird-interact-lite (270)।
- [x] কথোপকথন সংস্কৰণ মুক্তি, bird-interact-conv।
- [x] এজেন্ট সংস্কৰণ মুক্তি, bird-interact-agent।
- [x] সম্পূৰ্ণ bird-interact-full (600) মুক্তি।
- [x] ADK-ভিত্তিক বাস্তবায়ন মুক্তি, BIRD-Interact-ADK।
- [ ] SFT / RL এক ব্যৱহাৰকাৰী চিমুলেটৰ

## কৃতজ্ঞতা
আমাৰ আন্তৰিক কৃতজ্ঞতা জ্ঞাপন কৰিব বিচাৰো **Irina Saparina**, **Mohammadreza Pourreza**, **Mehdi Bouzouina**, **Hailong Li**, **Jiatong Shi**, আৰু অধ্যাপক **Shinji Watanabe**-ক, যিসকলে এই প্ৰকল্পখন উন্নত কৰিবলৈ ফলপ্ৰসূ আলোচনা আৰু মূল্যবান দিশ-নিৰ্দেশ প্ৰদান কৰিছে।

## সৃষ্টি কৰিছে:
BIRD দল & Google Cloud







## উদ্ধৃতি

```bibtex
@inproceedings{
huo2026birdinteract,
title={{BIRD}-{INTERACT}: Re-imagining Text-to-{SQL} Evaluation via Lens of Dynamic Interactions},
author={Nan Huo and Xiaohan Xu and Jinyang Li and Per Jacobsson and Shipei Lin and Bowen Qin and Binyuan Hui and Xiaolong Li and Ge Qu and Shuzheng Si and Linheng Han and Edward Alexander and Xintong Zhu and Rui Qin and Ruihan Yu and Yiyao Jin and Feige Zhou and Weihao Zhong and Yun Chen and Hongyu Liu and Chenhao Ma and Fatma Ozcan and Yannis Papakonstantinou and Reynold Cheng},
booktitle={The Fourteenth International Conference on Learning Representations},
year={2026},
url={https://openreview.net/forum?id=nHrYBGujps}
}
```
## পৰিৱর্তন লগ

- [2025-11-06] 🐛 **বাগ ফিক্স** & 🐳 **ডকৰ আপডেট**: sqlglot সংস্কৰণটো 26.16.4লৈ আপডেট কৰা হৈছে যাতে বাগটো ফিক্স হয় য'ত sql parser-এ user simulator-ৰ বাবে SQL সঠিকভাৱে বিশ্লেষণ কৰিব নোৱাৰিছিল। আপুনি `bird_interact_eval` পৰিবেশত `pip install sqlglot==26.16.4` ব্যৱহাৰ কৰি পুনৰ ইনষ্টল কৰি এইটো ঠিক কৰিব পাৰে। `bird_interact_eval` ইমেজো আপডেট কৰা হৈছে, সেয়ে আপুনি ইমেজটো পুল কৰি `bird_interact_eval` কণ্টেইনাৰো পুনৰ সৃষ্টি কৰিব পাৰে।
- [2025-10-21] 🐳 **ডকৰ আপডেট**: Full DB Env-ৰ বাবে ডকৰ যোগ কৰা হৈছে। আৰু আমি ৩টা ডকৰ ইমেজ (Base/Full DB Env আৰু `a-Interact` আৰু `c-Interact` উভয়ৰ বাবে মূল্যায়ন পৰিবেশ) Docker Hub-লৈ পুশ কৰিছোঁ যাতে পৰিবেশ স্থাপন সহজ হয়। DB dump-সমূহ ডাউনলোড আৰু ইমেজসমূহ ম্যানুয়েলি তৈয়াৰ কৰাৰ আৱশ্যকতা নাই! অনুগ্ৰহ কৰি Docker Hub-ৰ পৰা নতুন ইমেজসমূহ পুল কৰক আৰু কণ্টেইনাৰসমূহ পুনৰ সৃষ্টি কৰক, যেনে `docker compose down -v && docker compose pull && docker compose up -d --force-recreate` ব্যৱহাৰ কৰি।
- [2025-08-22]  🐛 **বাগ ফিক্স**: ফিক্স কৰা হৈছে বাগটো য'ত phase-2 SQL মূল্যায়নৰ সময়ত সংৰক্ষিত phase-1 SQL সফলভাৱে এক্সিকিউট কৰিব নোৱাৰিছিল, ফলত Phase-2-ৰ সফলতাৰ হাৰ কম হৈছিল। এই বাগটো কেৱল তেনে টাস্কসমূহক প্ৰভাৱিত কৰে য'ত phase1 sql-এ ডাটাবেছত কিছুমান অপাৰেশ্যন কৰে, যেনে CREATE table, আদি।




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-03

---