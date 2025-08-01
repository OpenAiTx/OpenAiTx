<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PPTAgent: পাঠ্য-টু-স্লাইডছৰ সীমা পাৰ হৈ প্ৰেজেন্টেশ্যন সৃষ্টি আৰু মূল্যায়ন
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">প্ৰবন্ধ</a> &nbsp; | &nbsp;
  🤗 <a href="https://huggingface.co/datasets/Forceless/Zenodo10K" target="_blank">ডেটাছেট</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">ডকুমেণ্টেশ্যন</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">উদ্ধৃতি</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

আমি PPTAgent উপস্থাপন কৰিছোঁ, এটা উদ্ভাৱনী প্ৰণালী যিয়ে স্বয়ংক্ৰিয়ভাৱে ডকুমেণ্টৰ পৰা প্ৰেজেন্টেশ্যন সৃষ্টি কৰে। মানুহৰ প্ৰেজেন্টেশ্যন তৈয়াৰ কৰাৰ পদ্ধতিৰ পৰা অনুপ্ৰাণিত হৈ, আমাৰ প্ৰণালীয়ে দুটা পদক্ষেপত কাম কৰে যাতে সামগ্ৰিক গুণগত মান নিশ্চিত হয়। ইয়াৰ উপৰিও, আমি **PPTEval** উপস্থাপন কৰিছোঁ, এটা বিস্তৃত মূল্যায়ন কাঠামো যিয়ে বিভিন্ন দিশত প্ৰেজেন্টেশ্যনসমূহ মূল্যায়ন কৰে।

> [!TIP]
> 🚀 আমাৰ প্ৰি-বিল্ট Docker ইমেজৰ সহায়ত দ্রুত আৰম্ভ কৰক - [Docker নিৰ্দেশনা চাওক](DOC.md/#docker-)

## ডেমো ভিডিঅ’ 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## বিশেষ বৈশিষ্ট্যসমূহ ✨

- **ডাইনেমিক সামগ্রী সৃষ্টি**: পাঠ্য আৰু চিত্ৰ একত্ৰিত কৰি স্লাইড সৃষ্টি কৰে
- **চতুৰ Référence শিক্ষণ**: মানৱীয় টীকা নালাগি বিদ্যমান প্ৰেজেন্টেশ্যন ব্যৱহাৰ কৰে
- **সমগ্ৰ গুণগত মূল্যায়ন**: বহুবিধ গুণগত মানদণ্ডত প্ৰেজেন্টেশ্যন মূল্যায়ন কৰে

## কেইটামান কেছ ষ্টাডী 💡

- #### [Iphone 16 Pro](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="ছবি1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="ছবি2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="ছবি3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="ছবি4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="ছবি5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="ছবি6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="ছবি7" width="200"/>

</div>

- #### [কাৰ্যকৰী এজেন্ট গঠন কৰক](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="ছবি1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="ছবি2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="ছবি3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="ছবি4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="ছবি5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="ছবি6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="ছবি7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="ছবি8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="ছবি9" width="200"/>


<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="图片10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent-এ দুখন পৰ্যায়ৰ পদ্ধতি অনুসৰণ কৰে:
1. **বিশ্লেষণ পৰ্যায়**: উল্লেখযোগ্য উপস্থাপনাসমূহৰ পৰা ধাৰণা উলিয়ায় আৰু শিকে
2. **উৎপাদন পৰ্যায়**: গঠনমূলক খাকঁ আঁকে আৰু দৃশ্যগতভাৱে একত্ৰিত স্লাইড তৈয়াৰ কৰে

আমাৰ প্ৰণালীৰ কৰ্মপ্ৰবাহ তলত দৰ্শোৱা হৈছে:


![PPTAgent Workflow](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEval-এ উপস্থাপনাসমূহক তিনি দিশত মূল্যাংকন কৰে:
- **বিষয়বস্তু**: স্লাইডসমূহৰ সঠিকতা আৰু প্ৰাসংগিকতা পৰীক্ষা কৰে।
- **ডিজাইন**: দৃশ্যগত আকৰ্ষণ আৰু একৰূপতা মূল্যাংকন কৰে।
- **সামঞ্জস্য**: চিন্তাধাৰাৰ যৌক্তিক প্ৰবাহ নিশ্চিত কৰে।

PPTEval-ৰ কৰ্মপ্ৰবাহ তলত দৰ্শোৱা হৈছে:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval Workflow" style="width:70%;"/>
</p>


## উদ্ধৃতি 🙏

আপুনি যদি এই প্ৰকল্পটো সহায়ক বুলি পায়, অনুগ্ৰহ কৰি তলত দিয়া উদ্ধৃতি ব্যৱহাৰ কৰক:
```bibtex
@article{zheng2025pptagent,
  title={PPTAgent: Generating and Evaluating Presentations Beyond Text-to-Slides},
  author={Zheng, Hao and Guan, Xinyan and Kong, Hao and Zheng, Jia and Zhou, Weixiang and Lin, Hongyu and Lu, Yaojie and He, Ben and Han, Xianpei and Sun, Le},
  journal={arXiv preprint arXiv:2501.03936},
  year={2025}
}
```

[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---