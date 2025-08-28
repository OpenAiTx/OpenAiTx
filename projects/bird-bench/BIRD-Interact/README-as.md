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

## বাতৰি
- [2025-08-22] **বাগ সংশোধন**: Bird-Interact-Agent কোডত, আমি এটা বাগ সংশোধন কৰিলোঁ য'ত phase-2 SQL মূল্যায়নৰ সময়ত, সংৰক্ষিত phase-1 SQL সফলভাৱে সম্পাদন কৰিব পৰা নাছিল, ফলস্বৰূপ Phase-2 ৰ সফলতাৰ হাৰ কমি গৈছিল। এই বাগ কেৱল সেইবোৰ টাস্কত প্ৰভাৱিত কৰে য'ত phase1 sql-এ ডেটাবেইচত কিছুমান কাৰ্য কৰে, যেনে CREATE table, আদিৰ দৰে।

## 🧸 পৰিসৰ

BIRD-INTERACT, এটা ইন্টাৰেক্টিভ টেক্সট-টু-SQL বেঞ্চমাৰ্ক, **dynamic interaction-ৰ lens-এ Text-to-SQL মূল্যায়নক পুনৰ কল্পনা কৰে**।
এই environment-এ এটা hierarchical knowledge base, database documentation আৰু এটা function-driven user simulator-ৰ সংমিশ্ৰণ কৰি সম্পূৰ্ণ **CRUD** অপাৰেশ্যনৰ সৈতে authentic enterprise environment পুনৰুত্পাদন কৰে।
ই দুটা কঠোৰ পৰীক্ষা মোড প্ৰদান কৰে: (1) প্যাসিভ **Conversational Interaction** আৰু (2) এক্টিভ **Agentic Interaction**, ৬০০ টা annotated task-ৰ বিস্তাৰত Business Intelligence (BI), CRUD অপাৰেশ্যন আৰু আদি, প্ৰতিটো executable test case-ৰে সুৰক্ষিত।
সাধাৰণ মূল্যায়নত ১,৯৬৮-৫,৪৯৬ interaction turn মডেল আৰু user simulator-ৰ মাজত সংঘটিত হয়, আৰু state-of-the-art reasoning model-সমূহ বৰ্তমান কেৱল **≈২৪%** আৰু **≈১৮%** task সমাধান কৰে, যাৰ ফলত এই বেঞ্চমাৰ্কৰ challenge স্পষ্ট হয়।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/workflow.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

### ✅ দুটা মূল্যায়ন মোড

BIRD-INTERACT-এ ওপৰত উল্লেখ কৰা দুটা মূল্যায়ন মোড সমৰ্থন কৰে:

   - **c-Interact**: Conversational Interaction যি এটা প্যাসিভ মোড আৰু workflow নিৰ্দিষ্ট। কোড আৰু বিস্তৃত তথ্য `bird_interact_conv`-ত পোৱা যাব।
   - **a-Interact**: Agentic Interaction যি embodied active মোড আৰু workflow dynamic আৰু মডেল-ৰে নেতৃত্ব হয়। কোড আৰু বিস্তৃত তথ্য `bird_interact_agent`-ত পোৱা যাব।


### 🐣 লাইট সংস্কৰণ

আমিবোৰে BIRD-INTERACT ৰ এটা লাইট সংস্কৰণ, `bird-interact-lite-exp`, মুক্তি দিছে, য'ত PostgreSQL ৰ বাবে ২৭০ টা উচ্চ-গুণগত মানৰ বাস্তৱিক কাৰ্য আছে। এইটো তৎকালিক পৰীক্ষাৰ বাবে ভাল আৰম্ভণি।

### 🦜 সম্পূৰ্ণ সংস্কৰণ

BIRD-INTERACT ৰ সম্পূৰ্ণ সংস্কৰণ, `bird-interact-full`, এটা বিস্তৃত বেঞ্চমাৰ্ক, য'ত PostgreSQL ৰ বাবে ৬০০ টা কাৰ্য অন্তর্ভুক্ত। ই SQL অপাৰেশ্যন আৰু ব্যৱহাৰকাৰীৰ প্ৰশ্নসমূহৰ বিস্তৃত পৰিসৰ আৱৰি থাকে। সম্পূৰ্ণ সংস্কৰণ শীঘ্ৰে আহি আছে।

### BIRD-INTERACT Lite ত মডেলৰ কাৰ্যক্ষমতাৰ ফলাফল

#### ১. **c-Interact** কাৰ্যক্ষমতা
| Rank | Model Name         | Normalized Reward | Level        |
|:------:|--------------------|:-------:|:--------------:|
| ১    | o3-mini            | ৩৩.০৪ | 🏆 উৎকৃষ্ট চ্যাট |
| ২    | GPT-4o             | ৩০.৩৩ | 💎 ভাল চ্যাট      |
| ৩    | Gemini-2.0-flash   | ২৭.৪১ | 💎 ভাল চ্যাট      |
| ৪    | Claude-3.7-sonnet  | ২৬.৬০ | ✨ মানদণ্ড       |
| ৫    | DeepSeek-R1        | ২১.৭৪ | ✨ মানদণ্ড       |
| ৬    | Qwen3              | ২০.৩৩ | ⚪ মৌলিক          |
| ৭    | DeepSeek-V3        | ১৫.৮৫ | ⚪ মৌলিক          |

#### ২. **a-Interact** কাৰ্যক্ষমতা
| Rank | Model Name         | Budget Parameters* | Avg Steps/Task | Avg Cost (USD)/Task | Normalized Reward | Level            |
|:------:|--------------------|:-------------------:|:----------------:|:---------------------:|:-------------------:|:---------------------:|
| ১    | Claude-3.7-sonnet  | ৬/৬ | ১৫.৪ | $০.৬৬৬৮ | ২৯.১৯ | 🏆 উৎকৃষ্ট ইন্টাৰেকশন |
| ২    | o3-mini            | ৬/৬ | ৭.৮ | $০.০৭৫৪ | ২১.০৭ | 💎 ভাল ইন্টাৰেকশন      |
| ৩    | DeepSeek-V3        | ৬/৬ | ১৫.৬ | $০.০৬২৯ | ১৯.১৯ | 💎 ভাল ইন্টাৰেকশন      |
| ৪    | Qwen3              | ৬/৬ | ১২.৫ | $০.০২৭৮ | ১৮.৭৪ | ✨ মানদণ্ড              |
| ৫    | GPT-4o             | ৬/৬ | ১৫.৩ | $০.৪৫৯৪ | ১৮.৩৭ | ✨ মানদণ্ড              |
| ৬    | Gemini-2.0-flash   | ৬/৬ | ১৩.২ | $০.০৩৩৭ | ১৭.২৬ | ⚪ মৌলিক                 |
| ৭    | DeepSeek-R1        | ৬/৬ | ১২.০ | $০.০৯৩১ | ১৭.০৭ | ⚪ মৌলিক                 |

> \* বাজেট পেৰামিটাৰ: আৰম্ভনি বাজেট/ ব্যৱহাৰকাৰীৰ ধৈৰ্য বাজেট, আমাৰ কল্পনা মুদ্ৰা *bird-coin* দ্বাৰা মাপি লোৱা হয় <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/materials/bird-coin.png" style="height: 1em; vertical-align: middle;">। অধিক তথ্যৰ বাবে [bird_interact_agent/README.md](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/bird_interact_agent/README.md#task-setting) চাওক।

### ইন্টাৰেকশ্যন-টাইম স্কেলিং (ITS)

ইন্টাৰেকশ্যন-টাইম স্কেলিং (ITS) মানে হৈছে এটা মডেলৰ বহু-পৰ্যায় ইন্টাৰেকশ্যনৰ জৰিয়তে তাৰ চূড়ান্ত কাৰ্যক্ষমতা অব্যাহতভাৱে বৃদ্ধি কৰাৰ ক্ষমতা। যেতিয়া এই ইন্টাৰেকটিভ কাৰ্যক্ষমতা মডেলৰ আদৰ্শ এক-পৰ্যায় কাৰ্যক্ষমতাক সম্পূর্ণভাৱে নিৰ্ধাৰিত, অস্পষ্ট নোহোৱা কাৰ্যত অতিক্ৰম কৰে, তেতিয়া আমি কওঁ যে ই **ITS আইন** মানে। ব্যৱহাৰকাৰীৰ ধৈৰ্য বৃদ্ধি পালে আৰু ইন্টাৰেকশ্যন পৰ্যায় বৃদ্ধি পালে, কাৰ্যক্ষমতা বৃদ্ধি হ'ব থাকে, যাৰ দ্বাৰা মডেলে দীঘলীয়া সংলাপত কাৰ্যকৰী যোগাযোগ বজাই ৰাখিব পাৰে। বৰ্তমান সময়ত কেৱল claude-3-7-sonnet কে ITS আইন মানে বুলি পাওঁ।

<p align="center">
  <img src="https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/materials/interaction_scaling_law.png" 
       style="width: 100%; min-width: 100px; display: block; margin: auto; ">
</p>

## 📦 ডেটাচেটৰ বিবৰণ

### ডেটাচেটৰ বিৱৰণ

- **ডেটাবেছ:** সম্পূৰ্ণ PostgreSQL ডেটাবেছ [Google Drive](https://drive.google.com/file/d/1KABce6czIqL9kMyIX7i-_A0CIQoDnmyW/view) ৰ পৰা ডাউনলোড কৰিব পাৰি। অধিক তথ্যৰ বাবে [Quick Eval](#quick-eval) চিত্ৰটো চাওক।
- **data:** প্ৰত্যেকটা ডেটা ইনষ্টেন্সত তলত উল্লেখ কৰা মুখ্য অংশসমূহ থাকে:
   - `selected_database`: ডেটাবেছৰ নাম।  
   - `query`: স্পষ্ট ইউজাৰ কুৱেৰী।  
   - `amb_user_query`: এম্বিগুইটি সংযুক্ত ইউজাৰ কুৱেৰী।
   - `user_query_ambiguity`: ইউজাৰ কুৱেৰীত সংযুক্ত এম্বিগুইটি।
   - `non_critical_ambiguity`: অ-গুরুত্বপূর্ণ এম্বিগুইটি যেনে order, limit, আদি।
   - `knowledge_ambiguity`: বাহ্যিক জ্ঞান আচ্ছাদিত কৰি সৃষ্টি কৰা এম্বিগুইটি। 
   - `sol_sql`: গ্ৰাউণ্ড ট্ৰুথ SQL সমাধান।  
   - `preprocess_sql`: সমাধান বা প্ৰেডিকশ্যন এক্সিকিউট কৰাৰ আগতে চলাবলগীয়া SQL কুৱেৰী।  
   - `clean_up_sql`: টেষ্ট কেইছৰ পিছত ডেটাবেছত হোৱা পৰিবৰ্তন পুনৰুদ্ধাৰ কৰিবলৈ চলাবলগীয়া SQL কুৱেৰী।  
   - `test_cases`: প্ৰেডিক্ট কৰা SQL সঠিকতাসূচক পৰীক্ষাৰ বাবে কেইটা টেষ্ট কেইছ।
   - `follow_up`: লেবেল কৰা follow up প্ৰশ্ন।
   - `external_knowledge`: নির্দিষ্ট টাস্কত প্ৰাসংগিক বাহ্যিক জ্ঞান।

- **evaluation:** মূল্যায়নৰ কোড [`./evaluation`](./evaluation) ডাইৰেক্টৰিত উপলব্ধ।
- **Curated by:** BIRD Team & Google Cloud
- **License:** [cc-by-sa-4.0](https://creativecommons.org/licenses/by-sa/4.0/)
- **HuggingFace Dataset Card:** [bird-interact-lite](https://huggingface.co/datasets/birdsql/bird-interact-lite)

### ডেটাচেটৰ ব্যৱহাৰ

অটো-ক্রলিংৰ মাধ্যমে ডেটা লিকেজ ৰোধ কৰিবলৈ, আমি GT সমাধান sql আৰু টেষ্ট কেইছ ডেটাৰ লগত সংযুক্ত কৰা নাই।
সম্পূৰ্ণ ছেটৰ বাবে অনুগ্ৰহ কৰি [bird.bench25@gmail.com](https://raw.githubusercontent.com/bird-bench/BIRD-Interact/main/mailto:bird.bench25@gmail.com) ত `[bird-interact-lite GT&Test Cases]` টেগ সহ ইমেইল কৰক, যি স্বয়ংক্ৰিয়ভাৱে প্ৰেৰণ কৰা হ’ব।


<!-- ### HuggingFaceৰ পৰা ডেটাচেট ব্যৱহাৰ কৰক

তলত উল্লেখ কৰা কমাণ্ড ব্যৱহাৰ কৰি HuggingFaceৰ পৰা ডেটাচেট ডাউনলোড কৰিব পাৰি:
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
**a-interact** চলোৱাৰ সম্পূৰ্ণ বিৱৰণ `./bird_interact_agent/README.md`-ত পোৱা যাব; আৰু **c-interact**-ৰ বাবে `./bird_interact_conv/README.md`-ত চাব পাৰি।

## 📰 বাতৰিৰ সংবাদ

🚀 আমি আনন্দিত যে **[BIRD-Interact-Full (600)](https://huggingface.co/datasets/birdsql/bird-interact-full)** ছেট মুক্তি দিয়া হৈছে!  
এইটো কঠিন — শ্ৰেষ্ঠ LLM-সমূহে কেৱল **16.33%** সফলতা হাৰ লাভ কৰিছে, য'ত `c-interact` আৰু `a-interact` অংশত কেৱল **10.0%**।  
👉 অধিক তথ্যৰ বাবে, অনুগ্ৰহ কৰি [project website](https://bird-interact.github.io/) চাওক।

📬 আমি এই সপ্তাহত আমাৰ মেইলিং লিষ্টলৈ **Ground Truth & Test cases** পঠাব।  
যদি আগতীয়াকৈ পাবলৈ ইচ্ছা কৰে, অনুগ্ৰহ কৰি ছাইটত উল্লেখ কৰা অনুসৰি ই-মেইল পঠিওক, যাতে **automatic download** কৰিব পাৰি।  

💾 আন এক গুৰুত্বপূর্ণ বিষয়, আমি SQLite সংস্কৰণৰ **[LiveSQLBench-Lite](https://huggingface.co/datasets/birdsql/livesqlbench-base-lite-sqlite)** মুক্তি দিছে, যাৰ দ্বাৰা স্থানীয়ভাৱে গৱেষণা সহজ হব।  
সম্পূৰ্ণ **LiveSQLBench-Base** আৰু **-Large** সংস্কৰণ শীঘ্ৰেই আহিব!

## 📋 কৰণীয় তালিকা

- [x] লাইট সংস্কৰণ মুক্তি, bird-interact-lite (270)।
- [x] কথোপকথন সংস্কৰণ মুক্তি, bird-interact-conv।
- [x] এজেন্ট সংস্কৰণ মুক্তি, bird-interact-agent।
- [x] সম্পূর্ণ bird-interact-full (600) মুক্তি।
- [ ] SFT / RL ব্যৱহাৰকাৰী সিমুলেটৰ

## নিৰ্মাতা:
BIRD Team & Google Cloud



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---