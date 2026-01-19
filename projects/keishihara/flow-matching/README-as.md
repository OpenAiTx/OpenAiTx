
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PyTorch-ত Flow Matching

এই ৰিপ'জিট'ৰিটোত [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747) নামৰ কাগজখনৰ এটা সাধাৰণ PyTorch অনুকৰণ অন্তৰ্ভুক্ত আছে।

## 2D Flow Matching উদাহৰণ

তলৰ gif খনে এটা একক গাউচিয়ান বিতৰণক এটা চেকাৰবোর্ড বিতৰণলৈ মানচিত্ৰণ দেখুৱাইছে, য'ত ভেক্টৰ ক্ষেত্ৰটো দৃশ্যায়িত কৰা হৈছে।

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

আৰু, ইয়াত moons ডেটাচেটৰ আন এটা উদাহৰণ দিয়া হৈছে।

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## আৰম্ভণি

ৰিপজিটৰিটো ক্লোন কৰক আৰু পাইথন পৰিৱেশটো সাজু কৰক।

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

নিশ্চিত কৰক যে আপোনাৰ Python 3.12+ সংস্থাপিত আছে।
`uv` সংস্থাপন কৰক:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
তাৰ পাছত, পৰিৱেশটো ছেট আপ কৰক:


```bash
uv sync
```

## কণ্ডিচনেল ফ্ল' মেচিং [Lipman+ 2023]

এইটো হৈছে মূল CFM পেপাৰৰ বাস্তৱায়ন [1]। কোডৰ কিছুমান অংশ [2] আৰু [3] ৰ পৰা গ্ৰহণ কৰা হৈছে।

### 2D খেলুৱৈ ডেটা ছেটসমূহ

আপুনি `checkerboard` আৰু `moons` যেনে 2D ছিন্থেটিক ডেটা ছেটসমূহত CFM মডেলসমূহ প্ৰশিক্ষণ কৰিব পাৰিব। `--dataset` বিকল্প ব্যৱহাৰ কৰি ডেটা ছেটৰ নাম নিৰ্দেশ কৰক। প্ৰশিক্ষণৰ পৰামিতিসমূহ স্ক্ৰিপ্টত পূৰ্বনিৰ্ধাৰিত, আৰু প্ৰশিক্ষণ ফলাফলৰ ভিজুৱালাইজেচনসমূহ `outputs/` ডাইৰেক্টৰিত সংৰক্ষণ কৰা হয়। মডেল চেকপইণ্টসমূহ সংলগ্ন নহয় কাৰণ সিহঁত ডিফ'ল্ট ছেটিঙৰ সৈতে সহজে পুনৰ উৎপাদন কৰিব পৰা যায়।

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```
ভেক্টৰ ক্ষেত্ৰসমূহ আৰু উৎপন্ন নমুনাসমূহ, যিবোৰ এই README-ৰ ওপৰত GIF হিচাপে প্ৰদৰ্শিত হৈছে, এতিয়া `outputs/cfm/` ডাইৰেক্টৰীত পোৱা যাব।

### চিত্ৰ ডেটা ছেটসমূহ

আপুনি জনপ্ৰিয় চিত্ৰ শ্ৰেণীবিভাজন ডেটা ছেটসমূহত ক্লাছ-সন্ধানী CFM মডেলবোৰো প্ৰশিক্ষণ দিব পাৰে। উৎপন্ন নমুনা আৰু মডেল চেকপইণ্ট দুয়োটা `outputs/cfm` ডাইৰেক্টৰীত সংৰক্ষণ কৰা হ'ব। প্ৰশিক্ষণ পৰামিতিসমূহৰ বিস্তারিত তালিকাৰ বাবে, `uv run scripts/train_flow_matching_on_image.py --help` চলাওক।

MNIST ডেটা ছেটত ক্লাছ-সন্ধানী CFM প্ৰশিক্ষণ দিবৰ বাবে, তলৰটো চলাওক:


```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```
প্ৰশিক্ষণৰ পাছত, আপোনিয়ে এতিয়া নমুনা উত্পন্ন কৰিব পাৰে:


```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

এতিয়া, আপুনি `outputs/cfm/mnist/` ডাইৰেক্টৰীত উৎপন্ন হোৱা নমুনাসমূহ দেখিবলৈ সক্ষম হ’ব।

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## ৰেক্টিফাইড ফ্ল’ [Liu+ 2023]

এইটো হৈছে ৰেক্টিফাইড ফ্ল’ পেপাৰৰ পৰা Reflow মডেলৰ (2-Rectified Flow) এখন ইমপ্লিমেণ্টেশ্বন [2]।

### 2D কৃত্ৰিম তথ্য

আমাৰে 2D কৃত্ৰিম ডেটাছেটসমূহত Reflow ইমপ্লিমেণ্ট কৰা হৈছে, যিটো CFM-ৰ দৰে। Reflow-ট্ৰেইন কৰিবলৈ, আপোনিয়ে CFM-ৰ প্ৰিট্ৰেইনড চেকপইণ্ট নিৰ্দেশ কৰিব লাগিব, কাৰণ reflow হৈছে এখন ডিস্টিলেশ্বন মডেল।

উদাহৰণস্বৰূপে, যদি আপুনি `checkerboard` ডেটাছেটত প্ৰিট্ৰেইনড CFM চেকপইণ্ট ব্যৱহাৰ কৰি ট্ৰেইন কৰে:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

প্ৰশিক্ষণ ফলাফলসমূহ, যাৰ ভিতৰত ভেক্টৰ ক্ষেত্ৰৰ ভিজুৱেলাইজেচন আৰু সৃষ্টি কৰা নমুনাসমূহ আছে, সেইবোৰ `outputs/reflow/` ফোল্ডাৰত সংৰক্ষণ কৰা হয়।

### CFM আৰু Reflow-ৰ মাজত নমুনা প্ৰক্ৰিয়াৰ তুলনা

2d ডেটাসেটসমূহত CFM আৰু Reflow-ৰ তুলনা কৰিবলৈ, এইটো চলাও:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
উৎপন্ন হোৱা GIF সমূহ `outputs/comparisons/` ফোল্ডাৰত পোৱা যাব। তলত `checkerboard` ডেটাসেটত দুইটা পদ্ধতিৰ তুলনাৰ এটা উদাহৰণ দিয়া হৈছে:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## উৎসসমূহ

- [1] লিপমান, ইয়াৰন, আদি। "Generative Modeling ৰ বাবে Flow Matching." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] লিউ, শিংচাও, আদি। "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---