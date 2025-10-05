<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
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
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  যদি আপুনি এই প্ৰকল্পটো উপকাৰী বুলি ভাবেন,<br>
  GitHub-ত এটা ষ্টাৰ ⭐ দিয়া অতি মূল্যবান হ'ব!
</p>

---

**ThinkSound** হৈছে এটা একত্ৰ Any2Audio উৎপাদন ফ্ৰেমৱৰ্ক যি Flow Matching-Chain-of-Thought (CoT) reasoning-এৰে পথ পৰিচালনা কৰে।

মাল্টিমডাল অডিঅ’ উত্পাদন আৰু সম্পাদনাৰ বাবে PyTorch ৰূপায়ন: ভিডিঅ’, পাঠ্য আৰু অডিঅ’ৰ পৰা অডিঅ’ উত্পাদন বা সম্পাদনা কৰক, Multimodal Large Language Models (MLLMs)ৰ ধাপ-ধাপে যুক্তি-কৰ্মৰ শক্তিত।

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 বাতৰি
- **2025.09.19** &nbsp; 🎉 ThinkSound **NeurIPS 2025 Main Conference**-ত গ্ৰহণ কৰা হৈছে!
- **2025.09.01** &nbsp; 🔥 আমাৰ AudioCoT ডেটাছেট এতিয়া মুক্ত আৰু [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)-ত উপলব্ধ!
- **2025.07.17** &nbsp; 🧠 Finetuning সক্ৰিয়: প্ৰশিক্ষণ আৰু finetuning কোড এতিয়া ৰাজহুৱা, স্পষ্ট ব্যৱহাৰ নিৰ্দেশনাসহ আপোনাৰ নিজৰ ডেটাৰ সৈতে ThinkSound ক কাষ্টমাইজ আৰু সম্প্রসাৰিত কৰিবলৈ সহায় কৰে।
- **2025.07.15** &nbsp; 📦 সহজ ইনষ্টলেশ্যন আৰু ব্যৱহাৰযোগ্যতা: PyPI-ৰ dependencies সহজ cross-platform setup-ৰ বাবে; Windows `.bat` script-এ environment সৃষ্টি আৰু script চলোৱা automate কৰে।
- **2025.07.08** &nbsp;  🔧 বৃহৎ আপডেট: মডেল lightweight কৰা আৰু memory আৰু GPU ব্যৱহাৰ optimized, এতিয়া বৃহৎ পৰিসৰত উচ্চ-প্ৰবাহ অডিঅ’ উত্পাদন সমৰ্থন কৰে!
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) আৰু [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)-ত অনলাইন ডেম’ ইন্টাৰেক্টিভ অভিজ্ঞতাৰ বাবে!
- **2025.07.01** &nbsp; 🔥Inference script আৰু web interface মুক্ত কৰা হৈছে;
- **2025.06** &nbsp; 🔥[ThinkSound paper](https://arxiv.org/pdf/2506.21448) arXiv-ত মুক্ত কৰা হৈছে!
- **2025.06** &nbsp; 🔥[Online Demo](http://thinksound-project.github.io/) লাইভ — এতিয়াই চেষ্টা কৰক!

---


## 🚀 বৈশিষ্ট্যসমূহ

- **Any2Audio**: যিকোনো modality — ভিডিঅ’, পাঠ্য, অডিঅ’ বা তাৰে সংমিশ্ৰণৰ পৰা অডিঅ’ উত্পাদন।
- **Video-to-Audio SOTA**: বহু V2A বেঞ্চমাৰ্কত state-of-the-art ফলাফল লাভ কৰে।
- **CoT-Driven Reasoning**: MLLMs-ৰ জড়িয়তে সংগঠনমূলক আৰু নিয়ন্ত্ৰণযোগ্য অডিঅ’ উত্পাদনৰ বাবে Chain-of-Thought reasoning।
- **Interactive Object-centric Editing**: দৃশ্যমান object-ত ক্লিক বা পাঠ্য নিৰ্দেশনা ব্যৱহাৰ কৰি নিৰ্দিষ্ট sound event সম্পাদনা বা refinement কৰক।
- **Unified Framework**: এটা মৌলিক মডেলে উত্পাদন, সম্পাদনা আৰু ইন্টাৰেক্টিভ workflow সমৰ্থন কৰে।

---

## ✨ পদ্ধতিৰ সংক্ষিপ্ত বিবৰণ

ThinkSound-এ অডিঅ’ উত্পাদন আৰু সম্পাদনাক তিনিটা ইন্টাৰেক্টিভ পৰ্যায়ত বিভক্ত কৰে, সকলো MLLM-ভিত্তিক Chain-of-Thought (CoT) reasoning-এ নিৰ্দেশিত:

1. **Foley Generation:** ভিডিঅ’ৰ পৰা মৌলিক, অৰ্থবোধক আৰু সময়িকভাৱে সংহত soundscape উত্পাদন।
2. **Object-Centric Refinement:** ভিডিঅ’ত ক্লিক বা অঞ্চলৰ জড়িয়তে ব্যৱহাৰকাৰী-নির্দিষ্ট object-ৰ বাবে sound refinement বা যোগ কৰক।
3. **Targeted Audio Editing:** উচ্চ-স্তৰৰ প্ৰাকৃতিক ভাষা নিৰ্দেশনাৰে উত্পাদিত অডিঅ’ সম্পাদনা কৰক।

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- বৃহৎ পৰিসৰৰ CoT-annotated ডেটাছেট (**AudioCoT**) reasoning module আৰু unified audio foundation model উভয়ক প্ৰশিক্ষণ দিয়াৰ বাবে ব্যৱহাৰ কৰা হৈছে।
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ দ্ৰুত আৰম্ভণি

**পৰিবেশ প্ৰস্তুতি:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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


## 🏋️ মডেলটো প্ৰশিক্ষণ দিয়ক

চাওক [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---

## 📝 TODO আৰু ভবিষ্যতৰ পৰিকল্পনা
* - [ ] বহুতো ক্ষেত্ৰত অধিক শক্তিশালী ফাউণ্ডেশ্যন মডেল মুক্তি দিয়ক, যাতে অধিক আকৰ্ষণীয় আৰু ডুব দিয়া ফoley সৃষ্টি কৰিব পাৰি
* - [ ] অতিৰিক্ত মোডালিটী আৰু ডাউনস্ট্ৰিম টাস্ক সমৰ্থন যোগ কৰক
* - [ ] ভিন্ন স্কেলত মডেল মুক্তি দিয়ক
* - [x] AudioCoT ডেটাসেট আৰু স্বচালিত পাইপলাইন ওপেন-ছৰ্চ কৰক
* - [x] ThinkSound মডেলৰ প্ৰশিক্ষণ স্ক্ৰিপ্ট মুক্তি দিয়ক
* - [x] আৰম্ভনিবাহী Windows কুইক-স্টাৰ্ট README
---


## 📄 অনুমতি পত্ৰ

এই প্ৰকল্পটো Apache 2.0 License অধীনত মুক্তি কৰা হৈছে।

> **টোকা:**
> কোড, মডেল আৰু ডেটাসেট **গৱেষণা আৰু শিক্ষা উদ্দেশ্যৰ বাবে**।
> **ব্যৱসায়িক ব্যৱহাৰ অনুমোদিত নহয়।**
> ব্যৱসায়িক অনুমতিৰ বাবে, অনুগ্ৰহ কৰি লেখকসকলৰ সৈতে যোগাযোগ কৰক।

**📦 তৃতীয় পক্ষৰ উপাদানসমূহ**

* **Stable Audio Open VAE** (Stability AI দ্বাৰা):
  এই ৰিপ'জিটৰিটোত [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) ৰ পৰা ফাইন-টিউন কৰা VAE অন্তর্ভুক্ত আছে, যি [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) অধীনত লাইসেন্স কৰা হৈছে।
  **ব্যৱসায়িক ব্যৱহাৰ আৰু পুনৰ্বিতৰণৰ বাবে Stability AI ৰ পূৰ্ব অনুমতি আৱশ্যক।**

* 📘 **বাকী সকলো কোড আৰু মডেল** Apache License 2.0 অধীনত মুক্তি কৰা হৈছে।

---

## কৃতজ্ঞতা

ধন্যবাদ জ্ঞাপন:

* **stable-audio-tools** (Stability AI দ্বাৰা):
অডিঅ' প্ৰজন্মৰ বাবে সহজ ব্যৱহাৰযোগ্য ফ্ৰেমৱৰ্ক, লগতে VAE মডিউল আৰু ৱেইট উপলব্ধ কৰোৱাৰ বাবে।
* **MMAudio**:
  অডিঅ' ক্ষেত্ৰত MM-DiT বেকব'নৰ ৰূপায়ণৰ বাবে।

---

## 📖 উদ্ধৃতি

যদি আপুনি ThinkSound আপোনাৰ গৱেষণা বা কামত সহায়ক বুলি পোৱা যায়, অনুগ্ৰহ কৰি আমাৰ প্ৰবন্ধ উদ্ধৃত কৰক:

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
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-04

---