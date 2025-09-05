<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
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

# PPTAgent: توليد وتقييم العروض التقديمية بما يتجاوز تحويل النص إلى شرائح
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">ورقة بحثية</a> &nbsp; | &nbsp;
  🤗 <a href="#open-source-" target="_blank">مصدر مفتوح</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">التوثيق</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">الاقتباس</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="اسأل DeepWiki"> DeepWiki</a>
</p>


نقدم لكم PPTAgent، وهو نظام مبتكر يقوم تلقائيًا بإنشاء العروض التقديمية من المستندات. مستلهماً من طرق إعداد العروض البشرية، يستخدم نظامنا عملية من خطوتين لضمان التميز في الجودة الشاملة. بالإضافة إلى ذلك، نقدم **PPTEval**، وهو إطار تقييم شامل يقيم العروض عبر أبعاد متعددة.

> [!TIP]
> 🚀 ابدأ بسرعة باستخدام صورة Docker الجاهزة لدينا - [راجع تعليمات Docker](DOC.md/#docker-)

## مفتوح المصدر 🤗
لقد قمنا بإصدار **نموذج كود PPTAgent** مع مجموعات البيانات: [PPTAgent-Coder](https://huggingface.co/Forceless/PPTAgent-coder-3B)، [Zenodo10k](https://huggingface.co/datasets/Forceless/Zenodo10K)، و [pptagent-code26k](https://huggingface.co/datasets/Forceless/pptagent-code26k).

## فيديو تجريبي 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## ميزات فريدة ✨

- **توليد محتوى ديناميكي**: ينشئ شرائح بدمج سلس للنصوص والصور
- **تعلم مرجعي ذكي**: يستفيد من العروض التقديمية الموجودة دون الحاجة إلى توصيف يدوي
- **تقييم جودة شامل**: يقيم العروض التقديمية عبر عدة معايير جودة

## دراسة حالة 💡

- #### [آيفون 16 برو](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="صورة 1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="صورة 2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="صورة 3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="صورة 4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="صورة 5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="صورة 6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="صورة 7" width="200"/>

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

يقوم PPTEval بتقييم العروض التقديمية عبر ثلاثة أبعاد:
- **المحتوى**: التحقق من دقة وملاءمة الشرائح.
- **التصميم**: تقييم الجاذبية البصرية والاتساق.
- **التماسك**: ضمان التسلسل المنطقي للأفكار.

يظهر سير عمل PPTEval أدناه:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="سير عمل PPTEval" style="width:70%;"/>
</p>


## الاستشهاد 🙏

إذا وجدت هذا المشروع مفيدًا، يرجى استخدام ما يلي للاستشهاد به:
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