
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">انگلیسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">ژاپنی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">کره‌ای</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">هندی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">تایلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">فرانسوی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">آلمانی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">اسپانیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">ایتالیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">روسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">پرتغالی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">هلندی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">لهستانی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">عربی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">ترکی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">ویتنامی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">اندونزیایی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PPTAgent: تولید و ارزیابی ارائه‌ها فراتر از تبدیل متن به اسلاید
<p align="center">
  📄 <a href="https://arxiv.org/abs/2501.03936" target="_blank">مقاله</a> &nbsp; | &nbsp;
  🤗 <a href="https://huggingface.co/datasets/Forceless/Zenodo10K" target="_blank">داده‌مجموعه</a> &nbsp; | &nbsp;
  📝 <a href="./DOC.md" target="_blank">مستندات</a> &nbsp; | &nbsp;
  🙏 <a href="#citation-" target="_blank">ارجاع</a> &nbsp; | &nbsp;
  <a href="https://deepwiki.com/icip-cas/PPTAgent" target="_blank"><img src="https://deepwiki.com/icon.png" alt="Ask DeepWiki"> DeepWiki</a>
</p>

ما PPTAgent را معرفی می‌کنیم؛ سیستمی نوآورانه که به طور خودکار از روی اسناد، ارائه تولید می‌کند. این سامانه با الهام از روش‌های انسان‌محور در تولید ارائه، از یک فرآیند دو مرحله‌ای برای تضمین کیفیت کلی بهره می‌برد. همچنین، **PPTEval** را معرفی می‌کنیم؛ چارچوب ارزیابی جامعی که ارائه‌ها را در ابعاد مختلف می‌سنجد.

> [!TIP]
> 🚀 به سرعت با ایمیج داکر آماده ما شروع کنید - [دستورالعمل‌های Docker را ببینید](DOC.md/#docker-)

## ویدیوی دمو 🎥

https://github.com/user-attachments/assets/c3935a98-4d2b-4c46-9b36-e7c598d14863

## ویژگی‌های متمایز ✨

- **تولید محتوای پویا**: اسلایدهایی با متن و تصویر یکپارچه تولید می‌کند
- **یادگیری مرجع هوشمند**: از ارائه‌های موجود بدون نیاز به حاشیه‌نویسی دستی بهره می‌برد
- **ارزیابی جامع کیفیت**: ارائه‌ها را با معیارهای مختلف کیفیت ارزیابی می‌کند

## مطالعه موردی 💡

- #### [آیفون ۱۶ پرو](https://www.apple.com/iphone-16-pro/)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0001.jpg" alt="تصویر۱" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0002.jpg" alt="تصویر۲" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0003.jpg" alt="تصویر۳" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0004.jpg" alt="تصویر۴" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0005.jpg" alt="تصویر۵" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0006.jpg" alt="تصویر۶" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/iphone16pro/0007.jpg" alt="تصویر۷" width="200"/>

</div>

- #### [ساخت ایجنت‌های مؤثر](https://www.anthropic.com/research/building-effective-agents)

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0001.jpg" alt="تصویر۱" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0002.jpg" alt="تصویر۲" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0003.jpg" alt="تصویر۳" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0004.jpg" alt="تصویر۴" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0005.jpg" alt="تصویر۵" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0006.jpg" alt="تصویر۶" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0007.jpg" alt="تصویر۷" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0008.jpg" alt="تصویر۸" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0009.jpg" alt="تصویر۹" width="200"/>

<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/build_effective_agents/0010.jpg" alt="图片10" width="200"/>

</div>

## PPTAgent 🤖

PPTAgent از یک رویکرد دو مرحله‌ای پیروی می‌کند:
1. **مرحله تحلیل**: استخراج و یادگیری از الگوهای ارائه‌های مرجع
2. **مرحله تولید**: توسعه ساختارهای سازمان‌یافته و تولید اسلایدهای بصری منسجم

جریان کاری سیستم ما در زیر نشان داده شده است:


![جریان کاری PPTAgent](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig2.jpg)

## PPTEval ⚖️

PPTEval ارائه‌ها را در سه بعد ارزیابی می‌کند:
- **محتوا**: بررسی دقت و ارتباط اسلایدها.
- **طراحی**: ارزیابی جذابیت بصری و یکنواختی.
- **انسجام**: اطمینان از جریان منطقی ایده‌ها.

جریان کاری PPTEval در زیر نشان داده شده است:
<p align="center">
<img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/fig3.jpg" alt="جریان کاری PPTEval" style="width:70%;"/>
</p>


## استناد 🙏

اگر این پروژه برای شما مفید بود، لطفاً از متن زیر برای استناد استفاده کنید:
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