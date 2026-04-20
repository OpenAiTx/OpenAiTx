<h1 align="center">থিঙ্কছাউণ্ড</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">ইংৰাজী</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">সৰল চাইনীজ</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">পৰম্পৰাগত চাইনীজ</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">স্পেনী</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">ফৰাচী</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">জাপানী</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-অনলাইন%20অভিজ্ঞতা-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  যদি আপুনি এই প্ৰকল্পটো উপযুক্ত বুলি ভাবে,<br>
  GitHub-ত এটা তৰাৰ ⭐ দান অনুকূল হ'ব!
</p>

---

## ৰিপ'জিটৰীৰ বিন্যাস
এই **ThinkSound** GitHub ৰিপ’জিটৰীখনে দুটা সম্পৰ্কিত প্ৰজেক্টক পৃথক শাখাত সংৰক্ষণ কৰিছে:

| শাখা | প্ৰজেক্ট | নথিপত্ৰ |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — একত্ৰিত Any2Audio উত্পাদন CoT-নির্দেশিত flow matching সহ | এই ফাইল: **`README.md`** |
| **`prismaudio`** | **PrismAudio** — video-to-audio ত multi-dimensional CoT-RL ৰ ওপৰত কৰা পৰৱৰ্তী কাম (ICLR 2026) | **`README.md`** [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) শাখাত |

**ThinkSound**-ৰ বাবে, **`master`** শাখা ব্যৱহাৰ কৰক (এই README)। **PrismAudio**-ৰ বাবে, **`prismaudio`** checkout কৰক আৰু তাত **`README.md`** অনুসৰণ কৰক।

---

**ThinkSound** হৈছে এক একত্ৰিত Any2Audio উত্পাদন কাঠামো য’ত Chain-of-Thought (CoT) যুক্তি দ্বাৰা flow matching কৰা হয়।

মাল্টিম’ডেল অডিঅ’ জেনাৰেশ্বন আৰু সম্পাদনাৰ বাবে PyTorch ইমপ্লিমেন্টেশ্বন: ভিডিঅ’, টেক্সট আৰু অডিঅ’ৰ পৰা অডিঅ’ উত্পাদন বা সম্পাদনা কৰক, Multimodal Large Language Models (MLLMs)-ৰ step-by-step reasoning ৰ সহায়ত।

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 বাতৰি
- **২০২৬.০৩.২৪** &nbsp; 🔥 **PrismAudio** এই একে ৰিপ’ত [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) শাখাত মুক্তি পোৱা হৈছে — তাত **`README.md`** চাওক setup আৰু মডেলৰ বাবে।
- **২০২৬.০১.২৬** &nbsp; 🎉 PrismAudio **ICLR 2026 Main Conference**-লৈ গ্ৰহণ কৰা হৈছে (`prismaudio` ত code/docs)।
- **২০২৫.১১.২৫** &nbsp; 🔥 [অনলাইন PrismAudio ডেমো](http://prismaudio-project.github.io/) উপলব্ধ।
- **২০২৫.১১.২৫** &nbsp; 🔥 [PrismAudio প্ৰবন্ধ](https://arxiv.org/pdf/2511.18833) arXiv-ত — ভিডিঅ’-টু-অডিঅ’ৰ বাবে multi-dimensional CoT-RL।
- **২০২৫.০৯.১৯** &nbsp; 🎉 **ThinkSound** **NeurIPS 2025 Main Conference**-লৈ গ্ৰহণ কৰা হৈছে!
- **২০২৫.০৯.০১** &nbsp; আমাৰ AudioCoT ডেটাসেট এতিয়া ওপেন-ছ’ৰ্চ আৰু [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)-ত উপলব্ধ!
- **২০২৫.০৭.১৭** &nbsp; 🧠 Finetuning সক্ষম: এতিয়া পাব্লিকলি উপলব্ধ training আৰু finetuning code, আপোনাৰ নিজস্ব ডেটাত ThinkSound কাষ্টমাইজ আৰু এক্সটেণ্ড কৰিবলৈ স্পষ্ট নিৰ্দেশ।
- **২০২৫.০৭.১৫** &nbsp; 📦 সাধাৰণ ইনষ্টলেশ্বন আৰু ব্যৱহাৰযোগ্যতা: সহজ cross-platform setup-ৰ বাবে PyPI-ত dependencies; Windows `.bat` script-এ environment creation আৰু script চলোৱা স্বচালিত কৰে।
- **২০২৫.০৭.০৮** &nbsp;  🔧 ডাঙৰ আপডেট: মডেল lightweight কৰা আৰু স্মৃতি আৰু GPU ব্যৱহাৰ অপ্টিমাইজ, এতিয়া বৃহৎ পৰিসৰত high-throughput অডিঅ’ জেনাৰেশ্বন সমৰ্থন কৰে!
- **২০২৫.০৭.০১** &nbsp; অনলাইন ডেমো [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) আৰু [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)-ত ইণ্টাৰেক্টিভ অভিজ্ঞতাৰ বাবে!
- **২০২৫.০৭.০১** &nbsp; inference script আৰু web interface মুক্তি দিয়া হৈছে;
- **২০২৫.০৬** &nbsp; [ThinkSound প্ৰবন্ধ](https://arxiv.org/pdf/2506.21448) arXiv-ত মুক্তি দিয়া হৈছে!
- **২০২৫.০৬** &nbsp; [অনলাইন ডেমো](http://thinksound-project.github.io/) উপলব্ধ - এতিয়া চেষ্টা কৰক!

---


<div align="center">

### পৰৱৰ্তী কাম: PrismAudio (একেই ৰিপ’, `prismaudio` শাখা)


**PrismAudio** হৈছে ThinkSound (ICLR 2026)-ৰ উত্তৰসূৰী, যি এটা নতুন নামৰ অধীনত বিকাশ কৰা হৈছে, কিন্তু এই ৰেপ’জিটৰিত **`prismaudio`** শাখাত সংৰক্ষিত। ইনষ্টলেচন, চেকপইণ্ট, আৰু উদ্ধৃতি **[`README.md` সেই শাখাত](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**-ত উপলব্ধ।

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) অথবা GitHub-ত সেই শাখা খোলক।

</div>

---


## 🚀 বৈশিষ্ট্যাবলী

- **Any2Audio**: যিকোনো মাধ্যমৰ পৰা অডিঅ’ সৃষ্টি কৰক — ভিডিঅ’, পাঠ, অডিঅ’, বা সেইবোৰৰ সংযোগ।
- **Video-to-Audio SOTA**: বহুবিধ V2A বেঞ্চমাৰ্কত উৎকৃষ্টতম ফলাফল লাভ কৰে।
- **CoT-Driven Reasoning**: MLLM-ৰ জৰিয়তে সংযোজিত আৰু নিয়ন্ত্রিত অডিঅ’ সৃষ্টি কাৰ্যৰ বাবে চেইন-অ’ফ-থট যুক্তি।
- **Interactive Object-centric Editing**: দৃশ্যমান বস্তুত ক্লিক কৰি বা পাঠ নিৰ্দেশনা ব্যৱহাৰ কৰি নিৰ্দিষ্ট শব্দ ইভেন্ট সম্পাদনা কৰক।
- **Unified Framework**: এটা মৌলিক মডেলে সৃষ্টি, সম্পাদনা, আৰু আন্তঃকৰ্মপদ্ধতি সমৰ্থন কৰে।

---

## ✨ পদ্ধতিৰ সংক্ষিপ্ত পৰিচয়

ThinkSound-এ অডিঅ’ সৃষ্টি আৰু সম্পাদনাক তিনিটা আন্তঃক্ৰিয়াশীল পৰ্যায়ত বিভক্ত কৰে, সকলো MLLM-ভিত্তিক চেইন-অ’ফ-থট (CoT) যুক্তিৰে নিয়ন্ত্রিত:

1. **Foley Generation:** ভিডিঅ’ৰ পৰা মৌলিক, অৰ্থবোধক আৰু সময়ানুকূল শব্দৰ দৃশ্য সৃষ্টি কৰক।
2. **Object-Centric Refinement:** ভিডিঅ’ত ক্লিক বা অঞ্চল নিৰ্বাচন কৰি ব্যৱহাৰকাৰী নিৰ্ধাৰিত বস্তুৰ বাবে শব্দ উন্নয়ন অথবা সংযোগ কৰক।
3. **Targeted Audio Editing:** উচ্চ-স্তৰৰ প্ৰাকৃতিক ভাষা নিৰ্দেশনাৰ সহায়ত সৃষ্ট অডিঅ’ সম্পাদনা কৰক।

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- এক বৃহৎ-প্ৰমাত্ৰাৰ CoT-এনোটেটেড ডেটাসেট (**AudioCoT**) ব্যৱহাৰ কৰি যুক্তি মডিউল আৰু একত্ৰিত অডিঅ’ মৌলিক মডেল প্ৰশিক্ষণ দিয়া হয়।
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ তৎক্ষণাত আৰম্ভ কৰক

**পৰিবেশ প্রস্তুতি:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```

> ✅ **উইণ্ড'জ টিপ:**  
> উইণ্ড'জ ব্যৱহাৰকাৰীসকলে সহজে `setup_windows.bat` চলাব পাৰে (অথবা ইয়াত ডাবল-ক্লিক কৰিব পাৰে) যাতে স্বয়ংক্ৰিয়ভাৱে কন্ডা পৰিৱেশ সৃষ্টি হয়, সকলো নিৰ্ভৰতা (FFmpeg সহ) সংস্থাপন হয়, আৰু প্ৰি-ট্ৰেইনড মডেল ডাউনলোড হয় — কোনো হস্তচালিত সংস্থাপন প্ৰয়োজন নহয়।  
> স্ক্ৰিপ্ট চলোৱাৰ আগতে আপোনাৰ ব্যৱস্থাত `conda` আৰু `git` সংস্থাপন কৰা আৰু PATH-ত উপলব্ধ হোৱা নিশ্চিত কৰক।


### ▶️ ডেম’ চলাওক

#### **লিনাক্স/ম্যাক’এস**

```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```

#### **Windows**

আপুনি ইয়াৰ বিপৰীতে প্ৰদান কৰা `.bat` স্ক্ৰিপ্ট ব্যৱহাৰ কৰিব পাৰে:

```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```

**টোকা:**

* `<path-to-your-demo-video>`: এটা ভিডিঅ'ৰ পথ
* `[use-half]` (ঐচ্ছিক): আধা প্ৰেছিছন বৈশিষ্ট্য এক্সট্ৰাকশ্যন সক্ৰিয় কৰিবলৈ শেষত use-half যোগ কৰক।

---

### 📦 বেটচ ইনফাৰেন্স

#### **Linux/macOS**

```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```

#### **উইণ্ডোজ**

সমান `.bat` স্ক্ৰিপ্ট ব্যৱহাৰ কৰক:

```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```

**টোকা:**

* `<video_path>`: প্ৰক্ৰিয়া কৰিবলৈ সকলো .mp4 ভিডিঅ' থকা মূল ডাইৰেক্টৰীৰ পথ (সকলো ভিডিঅ'ৰ সময়সীমা সমান হ'ব লাগিব).
* `<csv_path>`: প্ৰত্যেক ভিডিঅ'ৰ বাবে টেক্সট প্ৰম্পট থকা এটা CSV ফাইল (`demo_test.csv`ত ফৰ্মেট চাওক).
* `<save_path>` (ঐচ্ছিক): নিৰ্মিত অডিঅ' সংৰক্ষণ কৰাৰ স্থান. ডিফল্ট `results/features`।
* `[use-half]` (ঐচ্ছিক): আধা প্ৰিসিশন ফিচাৰ এক্সট্ৰাকচন সক্ৰিয় কৰিবলৈ শেষত use-half যোগ কৰক।

---


### ৱেব ইণ্টাৰফেছ ব্যৱহাৰ

ইন্টাৰেক্টিভ অভিজ্ঞতাৰ বাবে, Gradio ৱেব ইণ্টাৰফেছ আৰম্ভ কৰক:

```bash
python app.py
```


## 🏋️ মডেলটো প্ৰশিক্ষণ কৰক

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) চাওক


---


## 📄 লাইচেঞ্চ

এই প্ৰকল্পটো Apache 2.0 লাইচেঞ্চত মুক্তি দিয়া হৈছে।

> **টোকা:**
> কোড, মডেল, আৰু ডেটাছেট **গৱেষণা আৰু শৈক্ষিক উদ্দেশ্যৰ বাবে মাত্ৰ**।
> **বাণিজ্যিক ব্যৱহাৰ অনুমতি নাই।**
> বাণিজ্যিক লাইচেঞ্চৰ বাবে, অনুগ্ৰহ কৰি লেখকসকলৰ সৈতে যোগাযোগ কৰক।

**📦 তৃতীয় পক্ষীয় উপাদানসমূহ**

* **Stable Audio Open VAE** (Stability AI দ্বাৰা):
  এই ৰিপজিটৰীত [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/)ৰ পৰা ফাইন-টিউন কৰা VAE অন্তর্ভুক্ত আছে, [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)ত লাইচেঞ্চ কৰা।
  **বাণিজ্যিক ব্যৱহাৰ আৰু পুনৰ বিতৰণ Stability AIৰ পূৰ্বৰ অনুমতিৰ প্ৰয়োজন।**

* 📘 **অন্য সকলো কোড আৰু মডেল** Apache License 2.0ত মুক্তি দিয়া হৈছে।

---

## কৃতজ্ঞতা

অসংখ্য ধন্যবাদ:

* **stable-audio-tools** (Stability AI দ্বাৰা):
অডিঅ' জেনাৰেশ্যনৰ বাবে সহজে ব্যৱহাৰ কৰিব পৰা ফ্ৰেমৱৰ্ক, লগতে VAE মডিউল আৰু ওজনৰ বাবে।
* **MMAudio**:
  অডিঅ' ডোমেইনত MM-DiT ব্যাকবোনৰ বাস্তৱায়নৰ বাবে।

---

## 📖 উদ্ধৃতি

আপুনি যদি আপোনাৰ গৱেষণা বা কামত আমাৰ প্ৰকল্পটো উপকাৰী বুলি পাইছে, অনুগ্ৰহ কৰি আমাৰ কাগজখন উদ্ধৃতি কৰক:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---