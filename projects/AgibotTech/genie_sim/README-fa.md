![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# ۱. بنچمارک Genie Sim
Genie Sim چارچوب شبیه‌سازی ارائه‌شده توسط AgiBot است که قابلیت‌های کارآمدی برای تولید داده و بنچمارک‌های ارزیابی به توسعه‌دهندگان ارائه می‌دهد تا توسعه هوش تجسم‌یافته را تسریع کنند. Genie Sim یک خط لوله جامع حلقه بسته ایجاد کرده است که شامل تولید مسیر، آموزش مدل، بنچمارک‌گیری و اعتبارسنجی استقرار می‌باشد. کاربران می‌توانند به‌سرعت عملکرد الگوریتم را اعتبارسنجی کرده و مدل‌ها را از طریق این زنجیره ابزار شبیه‌سازی بهینه کنند. چه برای وظایف ساده گرفتن اشیا و چه برای عملیات پیچیده برد بلند، Genie Sim می‌تواند محیط شبیه‌سازی بسیار واقع‌گرایانه و معیارهای ارزیابی دقیقی ارائه دهد و به توسعه‌دهندگان این امکان را می‌دهد که توسعه و تکرار فناوری‌های رباتیک را به‌صورت کارآمد تکمیل کنند.

بنچمارک Genie Sim به‌عنوان نسخه ارزیابی متن‌باز Genie Sim، متعهد به ارائه تست عملکرد دقیق و پشتیبانی از بهینه‌سازی برای مدل‌های هوش تجسم‌یافته است.

# ۲. ویژگی‌ها
- پیکربندی و رابط شبیه‌سازی انعطاف‌پذیر و کاربرپسند
- بنچمارک‌های شبیه‌سازی و وظایف ارزیابی برای بیش از ۱۰ وظیفه دستکاری
- قابلیت کنترل از راه دور مبتنی بر VR و صفحه‌کلید
- ضبط و پخش مجدد تمام مفاصل و وضعیت اندافکتور
- بیش از ۵۵۰ محیط و دارایی سه‌بعدی با دقت فیزیکی بالا
- معیارهای ارزیابی استاندارد برای سنجش عملکرد مدل‌های هوش تجسم‌یافته
- نتایج ارزیابی با خطای کمتر از ۵٪ شبیه‌سازی تا واقعیت بر روی مدل GO-1
- پشتیبانی از مدل پایه UniVLA در ارزیابی شبیه‌سازی

# ۳. به‌روزرسانی‌ها
- [۲۵/۶/۲۰۲۵] نسخه ۲.۱
  - افزودن ۱۰ وظیفه دستکاری جدید برای مسابقه Agibot World Challenge 2025، شامل تمامی دارایی‌های شبیه‌سازی
  - متن‌باز شدن مجموعه داده‌های مصنوعی برای ۱۰ وظیفه دستکاری روی Huggingface
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - یکپارچه‌سازی سیاست UniVLA و پشتیبانی از ارزیابی شبیه‌سازی استنتاج مدل
  - به‌روزرسانی SDK حل‌گر IK که حل IK میان‌تجسمی برای ربات‌های دیگر را پشتیبانی می‌کند
  - بهینه‌سازی چارچوب ارتباطی و افزایش سرعت اجرای شبیه‌سازی تا ۲ برابر
  - به‌روزرسانی چارچوب ارزیابی خودکار برای وظایف پیچیده‌تر برد بلند

# ۴. محتوا

## ۴.۱ مقدمه
بنچمارک‌های شبیه‌سازی هوش تجسم‌یافته در Genie Sim برای ارزیابی و پیشرفت توسعه مدل‌های هوش تجسم‌یافته طراحی شده‌اند. این بنچمارک‌ها محیط‌های واقع‌گرایانه، وظایف متنوع و معیارهای استانداردی برای سنجش عملکرد سیستم‌های رباتیک هوشمند فراهم می‌کنند که نیاز به سخت‌افزار فیزیکی گران‌قیمت و آزمایش‌های دنیای واقعی را کاهش می‌دهند، از سناریوهای پرخطر جلوگیری کرده و فرآیند آموزش و ارزیابی عامل‌های هوش مصنوعی را تسریع می‌کنند.

## ۴.۲ شروع کار
لطفاً برای نصب، راهنمای کاربر و مرجع API به [این صفحه](https://agibot-world.com/sim-evaluation/docs/#/v2) مراجعه کنید.

## ۴.۳ پشتیبانی
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## ۴.۴ لیست کارهای آینده
- [x] انتشار وظایف بنچمارک دستکاری با افق زمانی بلندتر
- [x] صحنه‌ها و دارایی‌های بیشتر برای هر وظیفه بنچمارک
- [x] پشتیبانی از مدل پایه Agibot World Challenge
- [ ] جعبه‌ابزار چیدمان سناریو و تعمیم مسیر دستکاری

## ۴.۵ سوالات متداول
- چگونه سرور isaac sim را هنگام بروز خطا که باعث عدم پاسخگویی فرآیند می‌شود، خاموش کنیم؟
  فرآیند را در ترمینال با دستور `pkill -9 -f raise_standalone_sim` خاتمه دهید.
- چگونه حالت‌های مختلف رندر را انتخاب کنیم؟
  حالت پیش‌فرض رندر `RaytracedLighting(RealTime)` است. برای وظایفی که اشیای شفاف دارند، از حالت `RealTimePathTracing(RealTime-2.0)` برای نمایش صحیح رابطه پرسپکتیو اشیا استفاده کنید.

## ۴.۶ مجوز و استناد
تمام داده‌ها و کدهای موجود در این مخزن تحت مجوز عمومی موزیلا نسخه ۲.۰ هستند.
در صورت استفاده در تحقیقات خود، لطفاً به یکی از روش‌های زیر به ما استناد کنید.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## ۴.۷ منابع
1. PDDL Parser (2020). نسخه ۱.۱. [کد منبع]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. نسخه ۱.x.x [کد منبع]. https://github.com/StanfordVL/bddl
3. CUROBO [کد منبع]. https://github.com/NVlabs/curobo
4. Isaac Lab [کد منبع]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [کد منبع]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---