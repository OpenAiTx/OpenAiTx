<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">ইংৰাজী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">সৰল চীনী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">পৰম্পৰাগত চীনী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">জাপানী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">কোৰিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">হিন্দী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">থাই</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">ফৰাচী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">জাৰ্মান</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">স্পেনিছ</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">ইটালিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">ৰাছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">পৰ্তুগীজ</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">ডাচ</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">পোলিশ</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">আৰবী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">ফাৰ্ছী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">তুৰ্কী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">ভিয়েটনামী</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">ইণ্ডোনেছিয়ান</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PPTAgent: পাঠ-টু-স্লাইডছৰ সীমা অতিক্ৰম কৰি প্ৰেজেন্টেশ্বন সৃষ্টি আৰু মূল্যায়ন
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">প্ৰবন্ধ</a> &nbsp; | &nbsp;
  🤗 <a href="#open-source-" target="_blank">উন্মুক্ত উৎস</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">দস্তাবেজ</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">উদ্ধৃতি</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="DeepWikiত সোধক"> DeepWiki</a>
</p>


আমি PPTAgent প্ৰস্তুত কৰি দিছোঁ, যি এটা উদ্ভাৱনী পৰিসৰ যি স্বয়ংক্ৰিয়ভাৱে নথিপত্ৰৰ পৰা প্ৰেজেন্টেশ্বন সৃষ্টি কৰে। মানুহে প্ৰেজেন্টেশ্বন তৈয়াৰ কৰাৰ পদ্ধতিৰ পৰা অনুপ্ৰেৰণা লৈ, আমাৰ পৰিসৰে গুণগত মানৰ উৎকৃষ্টতা নিশ্চিত কৰিবলৈ দুটা পৰ্যায়ৰ প্ৰক্ৰিয়া ব্যৱহাৰ কৰে। ইয়াৰ উপৰিও, আমি **PPTEval** পৰিচয় কৰাইছোঁ, যি এটা বিস্তৃত মূল্যায়ন কাঠামো যি বহুমাত্ৰিক দিশত প্ৰেজেন্টেশ্বনসমূহৰ মূল্যায়ন কৰে।

> [!TIP]
> 🚀 আগতিয়াকৈ সাজু কৰা আমাৰ Docker image-ৰে তৎকালিক আৰম্ভ কৰক - [Docker নিৰ্দেশনা চাওক](DOC.md/#docker-)

## মুক্ত উৎস 🤗
আমি **PPTAgent code model** আৰু datasetবোৰ মুক্ত কৰি দিছোঁ: [PPTAgent-Coder](https://huggingface.co/Forceless/PPTAgent-coder-3B), [Zenodo10k](https://huggingface.co/datasets/Forceless/Zenodo10K), আৰু [pptagent-code26k](https://huggingface.co/datasets/Forceless/pptagent-code26k)।

## ডেমো ভিডিঅ' 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## বৈশিষ্ট্যৰ বৈচিত্ৰ্য ✨

- **ডাইনামিক সামগ্ৰী সৃষ্টি**: পাঠ আৰু ছবি একত্ৰিত কৰি slide তৈয়াৰ কৰে
- **বুদ্ধিমত্তা সম্পন্ন Reference Learning**: বিদ্যমান প্ৰেজেন্টেশ্বন ব্যৱহাৰ কৰে, ম্যানুৱেল টীকাকৰণৰ প্ৰয়োজন নোহোৱা
- **বিস্তৃত গুণগত মান মূল্যায়ন**: বহুমাত্ৰিক গুণগত মান সূচকৰে প্ৰেজেন্টেশ্বন মূল্যায়ন কৰে

## কেইটা অধ্যয়ন 💡

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

- #### [Build Effective Agents](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="图片8" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="图片9" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="图片10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent follows a two-phase approach:
1. **Analysis Phase**: Extracts and learns from patterns in reference presentations
2. **Generation Phase**: Develops structured outlines and produces visually cohesive slides

Our system's workflow is illustrated below:


![PPTAgent Workflow](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEval তিনিটা দিশত প্ৰেজেণ্টেশ্বনসমূহ মূল্যায়ন কৰে:
- **বিষয়বস্তু**: স্লাইডসমূহৰ সঠিকতা আৰু প্ৰাসংগিকতা পৰীক্ষা কৰা হয়।
- **ডিজাইন**: দৃশ্যমান আকৰ্ষণ আৰু একৰূপতা মূল্যায়ন কৰা হয়।
- **সম্বদ্ধতা**: চিন্তাধাৰাৰ যুক্তিসংগত প্ৰবাহ নিশ্চিত কৰা হয়।

PPTEval-ৰ কাৰ্যপদ্ধতি তলত দেখুওৱা হৈছে:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval Workflow" style="width:70%;"/>
</p>


## উদ্ধৃতি 🙏

যদি আপুনি এই প্ৰকল্পটো সহায়ক বুলি ভাবেন, অনুগ্ৰহ কৰি ইয়াক উদ্ধৃত কৰিবলৈ তলৰটো ব্যৱহাৰ কৰক:
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---