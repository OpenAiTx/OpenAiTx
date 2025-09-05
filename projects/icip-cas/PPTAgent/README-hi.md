<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# PPTAgent: प्रस्तुतियों का निर्माण और मूल्यांकन, केवल टेक्स्ट-टू-स्लाइड्स से आगे
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">पेपर</a> &nbsp; | &nbsp;
  🤗 <a href="#open-source-" target="_blank">ओपन सोर्स</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">प्रलेखन</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">संदर्भ</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> डीपविकि</a>
</p>

हम प्रस्तुत करते हैं PPTAgent, एक नवोन्मेषी प्रणाली जो दस्तावेज़ों से स्वतः प्रस्तुति तैयार करती है। मानव प्रस्तुति निर्माण विधियों से प्रेरित होकर, हमारी प्रणाली उत्कृष्टता सुनिश्चित करने के लिए दो-चरणीय प्रक्रिया अपनाती है। इसके अतिरिक्त, हम **PPTEval** पेश करते हैं, एक व्यापक मूल्यांकन ढांचा जो प्रस्तुति को कई आयामों में परखता है।

> [!TIP]
> 🚀 हमारी पूर्वनिर्मित Docker इमेज के साथ शीघ्र शुरुआत करें - [Docker निर्देश देखें](DOC.md/#docker-)

## ओपन सोर्स 🤗
हमने **PPTAgent कोड मॉडल** और डेटासेट जारी किए हैं: [PPTAgent-Coder](https://huggingface.co/Forceless/PPTAgent-coder-3B), [Zenodo10k](https://huggingface.co/datasets/Forceless/Zenodo10K), और [pptagent-code26k](https://huggingface.co/datasets/Forceless/pptagent-code26k)।

## डेमो वीडियो 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## विशिष्ट विशेषताएँ ✨

- **डायनामिक कंटेंट जेनरेशन**: टेक्स्ट और छवियों के साथ सहजता से स्लाइड बनाता है
- **स्मार्ट रेफरेंस लर्निंग**: मैनुअल एनोटेशन के बिना मौजूदा प्रस्तुतियों का लाभ उठाता है
- **व्यापक गुणवत्ता मूल्यांकन**: कई गुणवत्ता मीट्रिक के जरिए प्रस्तुति का मूल्यांकन करता है

## केस स्टडी 💡

- #### [आईफोन 16 प्रो](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="चित्र1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="चित्र2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="चित्र3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="चित्र4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="चित्र5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="चित्र6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="चित्र7" width="200"/>

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

PPTEval तीन आयामों में प्रस्तुतियों का मूल्यांकन करता है:
- **सामग्री**: स्लाइड्स की सटीकता और प्रासंगिकता की जांच करता है।
- **डिज़ाइन**: दृश्य आकर्षण और निरंतरता का मूल्यांकन करता है।
- **संगति**: विचारों के तार्किक प्रवाह को सुनिश्चित करता है।

PPTEval की कार्यप्रणाली नीचे दर्शाई गई है:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="PPTEval Workflow" style="width:70%;"/>
</p>


## संदर्भ 🙏

यदि आपको यह परियोजना उपयोगी लगे, तो कृपया इसे निम्नलिखित रूप से संदर्भित करें:
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