<!---
Copyright 2020 The HuggingFace Team. All rights reserved.

تحت مجوز آپاچی نسخه ۲.۰ (مجوز)؛
شما نمی‌توانید از این فایل استفاده کنید مگر طبق شرایط مجوز.
شما می‌توانید یک نسخه از مجوز را در آدرس زیر دریافت کنید:

    http://www.apache.org/licenses/LICENSE-2.0

مگر در مواردی که طبق قوانین لازم‌الاجرا یا به صورت مکتوب توافق شده باشد، نرم‌افزار
توزیع‌شده تحت این مجوز به صورت "همان‌گونه که هست" ارائه می‌شود،
بدون هیچ‌گونه ضمانت، چه به صورت صریح و چه ضمنی.
برای مشاهده مجوز مربوط به مجوزها و محدودیت‌ها به مجوز مراجعه کنید.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="کتابخانه ترنسفورمرز هاجینگ‌فیس" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="چک‌پوینت‌ها در هاب" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="بیلد" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="گیت‌هاب" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="مستندات" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="انتشار گیت‌هاب" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>مدل‌های پیش‌آموزش دیده پیشرفته برای استنتاج و آموزش</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

ترنسفورمرز یک کتابخانه از مدل‌های پیش‌آموزش دیده متنی، بینایی کامپیوتری، صوتی، ویدئویی و چندوجهی برای استنتاج و آموزش است. از ترنسفورمرز برای ریزتنظیم مدل‌ها بر داده‌های خود، ساخت برنامه‌های استنتاج و استفاده در موارد هوش مصنوعی مولد در چندین حوزه استفاده کنید.

بیش از ۵۰۰ هزار [چک‌پوینت مدل](https://huggingface.co/models?library=transformers&sort=trending) در [هاب هاجینگ‌فیس](https://huggingface.com/models) وجود دارد که می‌توانید استفاده کنید.

امروز [هاب](https://huggingface.com/) را بررسی کنید تا یک مدل پیدا کنید و با ترنسفورمرز کار خود را فوراً شروع کنید.

## نصب

ترنسفورمرز با Python 3.9+، [PyTorch](https://pytorch.org/get-started/locally/) 2.1+، [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ و [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+ کار می‌کند.

یک محیط مجازی با [venv](https://docs.python.org/3/library/venv.html) یا [uv](https://docs.astral.sh/uv/) ایجاد و فعال کنید؛ uv یک مدیر بسته و پروژه پایتون مبتنی بر Rust است.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

ترنسفورمرز را در محیط مجازی خود نصب کنید.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

اگر مایل به دریافت آخرین تغییرات در کتابخانه هستید یا می‌خواهید مشارکت کنید، ترنسفورمرز را از سورس نصب کنید. با این حال، نسخه *جدیدترین* ممکن است پایدار نباشد. اگر با خطایی مواجه شدید، می‌توانید یک [issue](https://github.com/huggingface/transformers/issues) باز کنید.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## شروع سریع

با API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial) بلافاصله با ترنسفورمرز شروع به کار کنید. `Pipeline` یک کلاس استنتاج سطح بالا است که از وظایف متنی، صوتی، تصویری و چندوجهی پشتیبانی می‌کند. این کلاس پیش‌پردازش ورودی را انجام می‌دهد و خروجی مناسب را بازمی‌گرداند.

یک پایپ‌لاین نمونه‌سازی کنید و مدل مورد استفاده را برای تولید متن مشخص کنید. مدل دانلود و کش می‌شود تا به راحتی بتوانید مجدداً از آن استفاده کنید. در نهایت، متنی را برای مدل ارسال کنید.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

برای چت با یک مدل، الگوی استفاده مشابه است. تنها تفاوت این است که باید یک تاریخچه چت (ورودی به `Pipeline`) بین خود و سیستم بسازید.

> [!TIP]
> شما همچنین می‌توانید مستقیماً از خط فرمان با مدل چت کنید.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "شما یک ربات شوخ‌طبع و حاضر جواب هستید که هالیوود در سال ۱۹۸۶ تصور کرده است."},
    {"role": "user", "content": "سلام، می‌تونی چند کار سرگرم‌کننده در نیویورک پیشنهاد بدی؟"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

برای مشاهده نحوه کارکرد `Pipeline` برای حوزه‌ها و وظایف مختلف، مثال‌های زیر را گسترش دهید.

<details>
<summary>شناسایی خودکار گفتار</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>رده‌بندی تصویر</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>پاسخ به پرسش تصویری</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="What is in the image?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## چرا باید از ترنسفورمرز استفاده کنم؟

1. مدل‌های پیشرفته و آسان برای استفاده:
    - عملکرد بالا در درک و تولید زبان طبیعی، بینایی کامپیوتری، صوت، ویدئو و وظایف چندوجهی.
    - سد ورود پایین برای پژوهشگران، مهندسان و توسعه‌دهندگان.
    - تنها سه کلاس برای یادگیری با انتزاع‌های کاربرپسند کم.
    - یک API یکپارچه برای استفاده از تمامی مدل‌های پیش‌آموزش دیده.

1. هزینه محاسبات پایین‌تر، ردپای کربنی کمتر:
    - به اشتراک‌گذاری مدل‌های آموزش‌دیده به جای آموزش از ابتدا.
    - کاهش زمان محاسباتی و هزینه‌های تولید.
    - ده‌ها معماری مدل با بیش از ۱ میلیون چک‌پوینت پیش‌آموزش دیده در همه حوزه‌ها.

1. انتخاب چارچوب مناسب برای هر بخش از چرخه عمر مدل:
    - آموزش مدل‌های پیشرفته تنها در ۳ خط کد.
    - انتقال یک مدل میان چارچوب‌های PyTorch/JAX/TF2.0 به دلخواه.
    - انتخاب چارچوب مناسب برای آموزش، ارزیابی و تولید.

1. سفارشی‌سازی آسان مدل یا مثال متناسب با نیازهای شما:
    - برای هر معماری مثال‌هایی جهت بازتولید نتایج نویسندگان اصلی ارائه شده است.
    - ساختار داخلی مدل‌ها تا حد ممکن شفاف ارائه شده است.
    - فایل‌های مدل می‌توانند مستقل از کتابخانه برای آزمایش‌های سریع استفاده شوند.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="هاب سازمانی هاجینگ‌فیس" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## چرا نباید از ترنسفورمرز استفاده کنم؟

- این کتابخانه یک جعبه ابزار ماژولار برای ساخت شبکه‌های عصبی نیست. کد فایل‌های مدل عمداً با انتزاع‌های اضافی بازنویسی نشده است تا پژوهشگران بتوانند سریعاً بر روی هر مدل بدون ورود به لایه‌های انتزاعی اضافی/فایل‌های دیگر تکرار و آزمایش کنند.
- API آموزش برای کار با مدل‌های PyTorch ارائه شده توسط ترنسفورمرز بهینه شده است. برای حلقه‌های یادگیری ماشین عمومی، باید از کتابخانه دیگری مانند [Accelerate](https://huggingface.co/docs/accelerate) استفاده کنید.
- [اسکریپت‌های نمونه](https://github.com/huggingface/transformers/tree/main/examples) تنها *مثال* هستند. ممکن است به صورت آماده برای مورد استفاده خاص شما کار نکنند و نیاز به تطبیق کد برای کاربرد خود دارید.

## ۱۰۰ پروژه با استفاده از ترنسفورمرز

ترنسفورمرز صرفاً یک ابزار برای استفاده از مدل‌های پیش‌آموزش دیده نیست، بلکه جامعه‌ای از پروژه‌ها حول آن و هاب هاجینگ‌فیس است. ما می‌خواهیم ترنسفورمرز به توسعه‌دهندگان، پژوهشگران، دانشجویان، اساتید، مهندسان و هر فرد دیگری کمک کند تا پروژه رؤیایی خود را بسازند.

برای جشن گرفتن ۱۰۰ هزار ستاره ترنسفورمرز، می‌خواستیم با صفحه [awesome-transformers](./awesome-transformers.md) به پروژه‌های شگفت‌انگیز جامعه که با ترنسفورمرز ساخته شده‌اند بپردازیم.

اگر مالک یا کاربر پروژه‌ای هستید که فکر می‌کنید باید در این فهرست باشد، لطفاً یک PR باز کنید تا اضافه شود!

## مدل‌های نمونه

می‌توانید اکثر مدل‌های ما را مستقیماً در صفحات مدل [هاب](https://huggingface.co/models) تست کنید.

برای مشاهده مدل‌های نمونه حوزه‌های مختلف، هر بخش را گسترش دهید.

<details>
<summary>صوت</summary>

- رده‌بندی صوت با [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- شناسایی خودکار گفتار با [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- تشخیص واژه کلیدی با [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- تولید گفتار به گفتار با [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- متن به صوت با [MusicGen](https://huggingface.co/facebook/musicgen-large)
- متن به گفتار با [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>بینایی کامپیوتری</summary>

- تولید ماسک خودکار با [SAM](https://huggingface.co/facebook/sam-vit-base)
- تخمین عمق با [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- رده‌بندی تصویر با [DINO v2](https://huggingface.co/facebook/dinov2-base)
- تشخیص نقاط کلیدی با [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- تطبیق نقاط کلیدی با [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- شناسایی اشیاء با [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- تخمین وضعیت بدن با [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- بخش‌بندی سراسری با [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- رده‌بندی ویدئو با [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>چندوجهی</summary>

- صوت یا متن به متن با [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- پاسخ به پرسش متنی اسناد با [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- تصویر یا متن به متن با [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- شرح تصویر با [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- درک اسناد مبتنی بر OCR با [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- پاسخ به پرسش جدولی با [TAPAS](https://huggingface.co/google/tapas-base)
- درک و تولید چندوجهی یکپارچه با [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- بینایی به متن با [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- پاسخ به پرسش تصویری با [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- بخش‌بندی اشاره بصری با [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>پردازش زبان طبیعی (NLP)</summary>

- تکمیل واژه مخفی با [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- تشخیص موجودیت نام‌دار با [Gemma](https://huggingface.co/google/gemma-2-2b)
- پاسخ به پرسش با [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- خلاصه‌سازی با [BART](https://huggingface.co/facebook/bart-large-cnn)
- ترجمه با [T5](https://huggingface.co/google-t5/t5-base)
- تولید متن با [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- رده‌بندی متن با [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## ارجاع

اکنون یک [مقاله](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) برای کتابخانه 🤗 Transformers داریم که می‌توانید به آن ارجاع دهید:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---