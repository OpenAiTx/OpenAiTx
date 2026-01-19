
<div align="right">
  <details>
    <summary >🌐 زبان</summary>
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

# تطابق جریان در پای‌تورچ

این مخزن شامل یک پیاده‌سازی ساده از مقاله [تطابق جریان برای مدل‌سازی مولد](https://arxiv.org/abs/2210.02747) با استفاده از پای‌تورچ است.

## مثال تطابق جریان دو‌بعدی

تصویر متحرک زیر نگاشت یک توزیع گاوسی منفرد به یک توزیع شطرنجی را نشان می‌دهد که میدان بردار به صورت تصویری نمایش داده شده است.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

و این یک مثال دیگر از دیتاست moons است.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## شروع به کار

مخزن را کلون کنید و محیط پایتون را راه‌اندازی کنید.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

اطمینان حاصل کنید که Python 3.12+ نصب شده باشد.
`uv` را نصب کنید:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```
سپس، محیط را راه‌اندازی کنید:


```bash
uv sync
```

## تطبیق جریان شرطی [Lipman+ 2023]

این پیاده‌سازی اصلی مقاله CFM است [1]. برخی اجزای کد از [2] و [3] اقتباس شده‌اند.

### داده‌ست‌های مصنوعی دو بعدی

می‌توانید مدل‌های CFM را روی داده‌ست‌های مصنوعی دو بعدی مانند `checkerboard` و `moons` آموزش دهید. نام داده‌ست را با گزینه `--dataset` مشخص کنید. پارامترهای آموزش از پیش در اسکریپت تعیین شده‌اند و تصویرسازی نتایج آموزش در پوشه `outputs/` ذخیره می‌شود. نقاط بازیابی مدل (checkpoints) گنجانده نشده‌اند چرا که با تنظیمات پیش‌فرض به راحتی قابل بازتولید هستند.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

بردارهای میدان و نمونه‌های تولیدشده، مانند آن‌هایی که به صورت GIF در بالای این README نمایش داده شده‌اند، اکنون در مسیر `outputs/cfm/` قابل دسترسی هستند.

### دیتاست‌های تصویری

شما همچنین می‌توانید مدل‌های CFM شرطی بر کلاس را بر روی دیتاست‌های محبوب طبقه‌بندی تصویر آموزش دهید. هم نمونه‌های تولیدشده و هم نقاط بررسی مدل در مسیر `outputs/cfm` ذخیره خواهند شد. برای مشاهده فهرست دقیقی از پارامترهای آموزش، دستور `uv run scripts/train_flow_matching_on_image.py --help` را اجرا کنید.

برای آموزش یک CFM شرطی بر کلاس روی دیتاست MNIST، دستور زیر را اجرا کنید:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```
پس از آموزش، اکنون می‌توانید نمونه‌ها را با استفاده از موارد زیر تولید کنید:


```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
اکنون باید بتوانید نمونه‌های تولید شده را در مسیر `outputs/cfm/mnist/` مشاهده کنید.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## جریان تصحیح‌شده [Liu+ 2023]

این یک پیاده‌سازی از مدل Reflow (به طور خاص 2-Rectified Flow) از مقاله جریان تصحیح‌شده [2] است.

### داده‌های مصنوعی دوبعدی

ما Reflow را بر روی مجموعه داده‌های مصنوعی دوبعدی پیاده‌سازی کرده‌ایم، همانند CFM. برای آموزش reflow، باید نقاط بازیابی‌شده CFM را مشخص کنید، چرا که reflow یک مدل تقطیری است.

برای مثال، برای آموزش روی مجموعه داده `checkerboard` با یک نقطه بازیابی‌شده CFM:


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```
نتایج آموزش، شامل تصویری‌سازی میدان برداری و نمونه‌های تولید شده، در پوشه `outputs/reflow/` ذخیره می‌شوند.

### مقایسه فرآیند نمونه‌گیری بین CFM و Reflow

برای مقایسه CFM و Reflow روی داده‌های دوبعدی، اجرا کنید:


```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```

تصاویر GIF حاصل را می‌توانید در پوشه‌ی `outputs/comparisons/` پیدا کنید. در زیر یک نمونه مقایسه از دو روش در مجموعه داده‌ی `checkerboard` آمده است:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## منابع

- [1] لیپمن، یارون و همکاران. "تطابق جریان برای مدل‌سازی مولد." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] لیو، زینگچائو و همکاران. "جریان مستقیم و سریع: یادگیری تولید و انتقال داده با جریان اصلاح‌شده." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---