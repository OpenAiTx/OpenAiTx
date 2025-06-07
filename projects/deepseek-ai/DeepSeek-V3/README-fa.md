<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-V3" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20V3-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true"><img alt="Wechat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-CODE"><img alt="Code License"
    src="https://img.shields.io/badge/Code_License-MIT-f5de53?&color=f5de53"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V3/blob/main/LICENSE-MODEL"><img alt="Model License"
    src="https://img.shields.io/badge/Model_License-Model_Agreement-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://arxiv.org/pdf/2412.19437"><b>Paper Link</b>👁️</a>
</div>

## فهرست مطالب

1. [مقدمه](#1-مقدمه)
2. [خلاصه مدل](#2-خلاصه-مدل)
3. [دریافت مدل‌ها](#3-دریافت-مدلها)
4. [نتایج ارزیابی](#4-نتایج-ارزیابی)
5. [وبسایت چت و بستر API](#5-وبسایت-چت--بستر-api)
6. [نحوه اجرای محلی](#6-نحوه-اجرای-محلی)
7. [مجوز](#7-مجوز)
8. [ارجاع](#8-ارجاع)
9. [تماس](#9-تماس)


## 1. مقدمه

ما DeepSeek-V3 را معرفی می‌کنیم، یک مدل زبانی Mixture-of-Experts (MoE) قدرتمند با ۶۷۱ میلیارد پارامتر کل و ۳۷ میلیارد پارامتر فعال برای هر توکن.  
برای دستیابی به استنتاج کارآمد و آموزش مقرون‌به‌صرفه، DeepSeek-V3 از معماری‌های Multi-head Latent Attention (MLA) و DeepSeekMoE بهره می‌گیرد که در DeepSeek-V2 به طور کامل اعتبارسنجی شده‌اند.  
علاوه بر این، DeepSeek-V3 برای اولین بار یک استراتژی توازن بار بدون زیان کمکی (auxiliary-loss-free) را پیاده‌سازی کرده و هدف آموزشی پیش‌بینی چندتوکنی را برای عملکرد بهتر اتخاذ می‌کند.  
ما DeepSeek-V3 را بر روی ۱۴.۸ تریلیون توکن متنوع و با کیفیت بالا پیش‌آموزش داده‌ایم و سپس مراحل Fine-Tuning تحت نظارت و یادگیری تقویتی را برای بهره‌برداری کامل از توانمندی‌های مدل انجام داده‌ایم.  
ارزیابی‌های جامع نشان می‌دهد که DeepSeek-V3 از سایر مدل‌های متن‌باز پیشی می‌گیرد و به عملکرد مدل‌های پیشتاز متن‌بسته نزدیک می‌شود.  
علی‌رغم عملکرد عالی، آموزش کامل DeepSeek-V3 تنها به ۲.۷۸۸ میلیون ساعت GPU مدل H800 نیاز دارد.  
افزون بر این، فرایند آموزش آن به طرز چشمگیری پایدار است.  
در طول فرایند آموزش، هیچ جهش غیرقابل بازیابی در زیان رخ نداد و هیچ بازگشتی انجام نشد.
<p align="center">
  <img width="80%" src="figures/benchmark.png">
</p>

## 2. خلاصه مدل

---

**معماری: استراتژی نوآورانه توازن بار و هدف آموزشی**

- بر پایه معماری کارآمد DeepSeek-V2، ما استراتژی بدون زیان کمکی را برای توازن بار ابداع کردیم که افت عملکرد ناشی از توازن بار را به حداقل می‌رساند.
- ما هدف پیش‌بینی چندتوکنی (MTP) را بررسی و اثبات کردیم که برای عملکرد مدل سودمند است.  
    همچنین می‌تواند برای رمزگشایی پیش‌بینانه و تسریع استنتاج به کار رود.

---

**پیش‌آموزش: به سوی کارایی نهایی آموزش**

- ما چارچوب آموزش با دقت ترکیبی FP8 را طراحی کردیم و برای اولین بار امکان‌پذیری و کارایی آموزش FP8 را بر روی مدلی در این مقیاس بسیار بزرگ اعتبارسنجی کردیم.  
- از طریق هم‌طراحی الگوریتم، چارچوب و سخت‌افزار، گلوگاه ارتباطی در آموزش MoE بین نودها را رفع کردیم و تقریباً همپوشانی کامل محاسبه-ارتباط را به دست آوردیم.  
  این امر به طور قابل توجهی کارایی آموزش ما را افزایش داده و هزینه آموزش را کاهش داده است، به طوری که می‌توانیم اندازه مدل را بدون سربار اضافی افزایش دهیم.  
- با هزینه اقتصادی تنها ۲.۶۶۴ میلیون ساعت GPU مدل H800، پیش‌آموزش DeepSeek-V3 را بر روی ۱۴.۸ تریلیون توکن کامل کردیم و قوی‌ترین مدل پایه متن‌باز فعلی را تولید نمودیم. مراحل آموزشی پس از پیش‌آموزش تنها به ۰.۱ میلیون ساعت GPU نیاز دارند.

---

**پس‌آموزش: تقطیر دانش از DeepSeek-R1**

-   ما روشی نوآورانه برای تقطیر قابلیت‌های استدلالی از مدل زنجیره تفکر (CoT) بلند، به‌ویژه یکی از مدل‌های سری DeepSeek R1، به LLMهای استاندارد، به ویژه DeepSeek-V3، معرفی کردیم. خط لوله ما به طور زیبا الگوهای تأیید و بازتاب R1 را در DeepSeek-V3 ادغام کرده و عملکرد استدلالی آن را به طور قابل توجهی بهبود می‌بخشد. در عین حال، کنترل بر سبک و طول خروجی DeepSeek-V3 را نیز حفظ می‌کنیم.

---


## 3. دریافت مدل‌ها

<div align="center">

| **مدل** | **تعداد کل پارامترها** | **تعداد پارامتر فعال** | **طول کانتکست** | **دریافت** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-V3-Base | ۶۷۱B | ۳۷B | ۱۲۸K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3-Base)   |
| DeepSeek-V3   | ۶۷۱B | ۳۷B | ۱۲۸K   | [🤗 Hugging Face](https://huggingface.co/deepseek-ai/DeepSeek-V3)   |

</div>

> [!NOTE]
> مجموع حجم مدل‌های DeepSeek-V3 در Hugging Face معادل ۶۸۵ میلیارد پارامتر است که شامل ۶۷۱ میلیارد پارامتر وزن مدل اصلی و ۱۴ میلیارد پارامتر وزن ماژول پیش‌بینی چندتوکنی (MTP) می‌باشد.

برای اطمینان از عملکرد و انعطاف‌پذیری بهینه، ما با جوامع متن‌باز و فروشندگان سخت‌افزار همکاری کرده‌ایم تا چندین روش برای اجرای مدل به صورت محلی فراهم کنیم. برای راهنمایی گام به گام، به بخش ۶: [نحوه اجرای محلی](#6-نحوه-اجرای-محلی) مراجعه نمایید.

برای توسعه‌دهندگانی که به دنبال جزئیات بیشتر هستند، توصیه می‌کنیم [README_WEIGHTS.md](./README_WEIGHTS.md) را برای اطلاعات مربوط به وزن‌های مدل اصلی و ماژول‌های پیش‌بینی چندتوکنی (MTP) مطالعه کنید. لطفاً توجه داشته باشید که پشتیبانی از MTP در حال توسعه فعال توسط جامعه است و از مشارکت‌ها و بازخورد شما استقبال می‌شود.

## 4. نتایج ارزیابی
### مدل پایه
#### معیارهای استاندارد

<div align="center">


|  | معیار (متریک) | تعداد نمونه | DeepSeek-V2 | Qwen2.5 72B | LLaMA3.1 405B | DeepSeek-V3 |
|---|-------------------|----------|--------|-------------|---------------|---------|
| | معماری | - | MoE | Dense | Dense | MoE |
| | تعداد پارامتر فعال | - | ۲۱B | ۷۲B | ۴۰۵B | ۳۷B |
| | تعداد کل پارامتر | - | ۲۳۶B | ۷۲B | ۴۰۵B | ۶۷۱B |
| انگلیسی | Pile-test (BPB) | - | ۰.۶۰۶ | ۰.۶۳۸ | **۰.۵۴۲** | ۰.۵۴۸ |
| | BBH (EM) | ۳ نمونه | ۷۸.۸ | ۷۹.۸ | ۸۲.۹ | **۸۷.۵** |
| | MMLU (دقت) | ۵ نمونه | ۷۸.۴ | ۸۵.۰ | ۸۴.۴ | **۸۷.۱** |
| | MMLU-Redux (دقت) | ۵ نمونه | ۷۵.۶ | ۸۳.۲ | ۸۱.۳ | **۸۶.۲** |
| | MMLU-Pro (دقت) | ۵ نمونه | ۵۱.۴ | ۵۸.۳ | ۵۲.۸ | **۶۴.۴** |
| | DROP (F1) | ۳ نمونه | ۸۰.۴ | ۸۰.۶ | ۸۶.۰ | **۸۹.۰** |
| | ARC-Easy (دقت) | ۲۵ نمونه | ۹۷.۶ | ۹۸.۴ | ۹۸.۴ | **۹۸.۹** |
| | ARC-Challenge (دقت) | ۲۵ نمونه | ۹۲.۲ | ۹۴.۵ | **۹۵.۳** | **۹۵.۳** |
| | HellaSwag (دقت) | ۱۰ نمونه | ۸۷.۱ | ۸۴.۸ | **۸۹.۲** | ۸۸.۹ |
| | PIQA (دقت) | بدون نمونه | ۸۳.۹ | ۸۲.۶ | **۸۵.۹** | ۸۴.۷ |
| | WinoGrande (دقت) | ۵ نمونه | **۸۶.۳** | ۸۲.۳ | ۸۵.۲ | ۸۴.۹ |
| | RACE-Middle (دقت) | ۵ نمونه | ۷۳.۱ | ۶۸.۱ | **۷۴.۲** | ۶۷.۱ |
| | RACE-High (دقت) | ۵ نمونه | ۵۲.۶ | ۵۰.۳ | **۵۶.۸** | ۵۱.۳ |
| | TriviaQA (EM) | ۵ نمونه | ۸۰.۰ | ۷۱.۹ | ۸۲.۷ | **۸۲.۹** |
| | NaturalQuestions (EM) | ۵ نمونه | ۳۸.۶ | ۳۳.۲ | **۴۱.۵** | ۴۰.۰ |
| | AGIEval (دقت) | بدون نمونه | ۵۷.۵ | ۷۵.۸ | ۶۰.۶ | **۷۹.۶** |
| کد | HumanEval (Pass@1) | بدون نمونه | ۴۳.۳ | ۵۳.۰ | ۵۴.۹ | **۶۵.۲** |
| | MBPP (Pass@1) | ۳ نمونه | ۶۵.۰ | ۷۲.۶ | ۶۸.۴ | **۷۵.۴** |
| | LiveCodeBench-Base (Pass@1) | ۳ نمونه | ۱۱.۶ | ۱۲.۹ | ۱۵.۵ | **۱۹.۴** |
| | CRUXEval-I (دقت) | ۲ نمونه | ۵۲.۵ | ۵۹.۱ | ۵۸.۵ | **۶۷.۳** |
| | CRUXEval-O (دقت) | ۲ نمونه | ۴۹.۸ | ۵۹.۹ | ۵۹.۹ | **۶۹.۸** |
| ریاضی | GSM8K (EM) | ۸ نمونه | ۸۱.۶ | ۸۸.۳ | ۸۳.۵ | **۸۹.۳** |
| | MATH (EM) | ۴ نمونه | ۴۳.۴ | ۵۴.۴ | ۴۹.۰ | **۶۱.۶** |
| | MGSM (EM) | ۸ نمونه | ۶۳.۶ | ۷۶.۲ | ۶۹.۹ | **۷۹.۸** |
| | CMath (EM) | ۳ نمونه | ۷۸.۷ | ۸۴.۵ | ۷۷.۳ | **۹۰.۷** |
| چینی | CLUEWSC (EM) | ۵ نمونه | ۸۲.۰ | ۸۲.۵ | **۸۳.۰** | ۸۲.۷ |
| | C-Eval (دقت) | ۵ نمونه | ۸۱.۴ | ۸۹.۲ | ۷۲.۵ | **۹۰.۱** |
| | CMMLU (دقت) | ۵ نمونه | ۸۴.۰ | **۸۹.۵** | ۷۳.۷ | ۸۸.۸ |
| | CMRC (EM) | ۱ نمونه | **۷۷.۴** | ۷۵.۸ | ۷۶.۰ | ۷۶.۳ |
| | C3 (دقت) | بدون نمونه | ۷۷.۴ | ۷۶.۷ | **۷۹.۷** | ۷۸.۶ |
| | CCPM (دقت) | بدون نمونه | **۹۳.۰** | ۸۸.۵ | ۷۸.۶ | ۹۲.۰ |
| چندزبانه | MMMLU-non-English (دقت) | ۵ نمونه | ۶۴.۰ | ۷۴.۸ | ۷۳.۸ | **۷۹.۴** |

</div>

> [!NOTE]
> بهترین نتایج به صورت بولد نشان داده شده‌اند. امتیازهایی که اختلاف آن‌ها بیش از ۰.۳ نباشد در یک سطح در نظر گرفته می‌شوند. DeepSeek-V3 در اغلب معیارها، به ویژه در ریاضیات و کدنویسی بهترین عملکرد را دارد.
> برای جزئیات بیشتر ارزیابی، مقاله ما را مطالعه نمایید.

#### پنجره کانتکست
<p align="center">
  <img width="80%" src="figures/niah.png">
</p>

نتایج ارزیابی در تست «سوزن در انبار کاه» (NIAH). DeepSeek-V3 در تمام طول‌های پنجره کانتکست تا **۱۲۸K** عملکرد خوبی دارد.

### مدل چت
#### معیارهای استاندارد (مدل‌های بزرگ‌تر از ۶۷B)
<div align="center">

| | **معیار (متریک)** | **DeepSeek V2-0506** | **DeepSeek V2.5-0905** | **Qwen2.5 72B-Inst.** | **Llama3.1 405B-Inst.** | **Claude-3.5-Sonnet-1022** | **GPT-4o 0513** | **DeepSeek V3** |
|---|---------------------|---------------------|----------------------|---------------------|----------------------|---------------------------|----------------|----------------|
| | معماری | MoE | MoE | Dense | Dense | - | - | MoE |
| | تعداد پارامتر فعال | ۲۱B | ۲۱B | ۷۲B | ۴۰۵B | - | - | ۳۷B |
| | تعداد کل پارامتر | ۲۳۶B | ۲۳۶B | ۷۲B | ۴۰۵B | - | - | ۶۷۱B |
| انگلیسی | MMLU (EM) | ۷۸.۲ | ۸۰.۶ | ۸۵.۳ | **۸۸.۶** | **۸۸.۳** | ۸۷.۲ | **۸۸.۵** |
| | MMLU-Redux (EM) | ۷۷.۹ | ۸۰.۳ | ۸۵.۶ | ۸۶.۲ | **۸۸.۹** | ۸۸.۰ | **۸۹.۱** |
| | MMLU-Pro (EM) | ۵۸.۵ | ۶۶.۲ | ۷۱.۶ | ۷۳.۳ | **۷۸.۰** | ۷۲.۶ | ۷۵.۹ |
| | DROP (۳ نمونه F1) | ۸۳.۰ | ۸۷.۸ | ۷۶.۷ | ۸۸.۷ | ۸۸.۳ | ۸۳.۷ | **۹۱.۶** |
| | IF-Eval (Prompt Strict) | ۵۷.۷ | ۸۰.۶ | ۸۴.۱ | ۸۶.۰ | **۸۶.۵** | ۸۴.۳ | ۸۶.۱ |
| | GPQA-Diamond (Pass@1) | ۳۵.۳ | ۴۱.۳ | ۴۹.۰ | ۵۱.۱ | **۶۵.۰** | ۴۹.۹ | ۵۹.۱ |
| | SimpleQA (Correct) | ۹.۰ | ۱۰.۲ | ۹.۱ | ۱۷.۱ | ۲۸.۴ | **۳۸.۲** | ۲۴.۹ |
| | FRAMES (دقت) | ۶۶.۹ | ۶۵.۴ | ۶۹.۸ | ۷۰.۰ | ۷۲.۵ | **۸۰.۵** | ۷۳.۳ |
| | LongBench v2 (دقت) | ۳۱.۶ | ۳۵.۴ | ۳۹.۴ | ۳۶.۱ | ۴۱.۰ | ۴۸.۱ | **۴۸.۷** |
| کد | HumanEval-Mul (Pass@1) | ۶۹.۳ | ۷۷.۴ | ۷۷.۳ | ۷۷.۲ | ۸۱.۷ | ۸۰.۵ | **۸۲.۶** |
| | LiveCodeBench (Pass@1-COT) | ۱۸.۸ | ۲۹.۲ | ۳۱.۱ | ۲۸.۴ | ۳۶.۳ | ۳۳.۴ | **۴۰.۵** |
| | LiveCodeBench (Pass@1) | ۲۰.۳ | ۲۸.۴ | ۲۸.۷ | ۳۰.۱ | ۳۲.۸ | ۳۴.۲ | **۳۷.۶** |
| | Codeforces (درصد) | ۱۷.۵ | ۳۵.۶ | ۲۴.۸ | ۲۵.۳ | ۲۰.۳ | ۲۳.۶ | **۵۱.۶** |
| | SWE Verified (Resolved) | - | ۲۲.۶ | ۲۳.۸ | ۲۴.۵ | **۵۰.۸** | ۳۸.۸ | ۴۲.۰ |
| | Aider-Edit (دقت) | ۶۰.۳ | ۷۱.۶ | ۶۵.۴ | ۶۳.۹ | **۸۴.۲** | ۷۲.۹ | ۷۹.۷ |
| | Aider-Polyglot (دقت) | - | ۱۸.۲ | ۷.۶ | ۵.۸ | ۴۵.۳ | ۱۶.۰ | **۴۹.۶** |
| ریاضی | AIME 2024 (Pass@1) | ۴.۶ | ۱۶.۷ | ۲۳.۳ | ۲۳.۳ | ۱۶.۰ | ۹.۳ | **۳۹.۲** |
| | MATH-500 (EM) | ۵۶.۳ | ۷۴.۷ | ۸۰.۰ | ۷۳.۸ | ۷۸.۳ | ۷۴.۶ | **۹۰.۲** |
| | CNMO 2024 (Pass@1) | ۲.۸ | ۱۰.۸ | ۱۵.۹ | ۶.۸ | ۱۳.۱ | ۱۰.۸ | **۴۳.۲** |
| چینی | CLUEWSC (EM) | ۸۹.۹ | ۹۰.۴ | **۹۱.۴** | ۸۴.۷ | ۸۵.۴ | ۸۷.۹ | ۹۰.۹ |
| | C-Eval (EM) | ۷۸.۶ | ۷۹.۵ | ۸۶.۱ | ۶۱.۵ | ۷۶.۷ | ۷۶.۰ | **۸۶.۵** |
| | C-SimpleQA (درست) | ۴۸.۵ | ۵۴.۱ | ۴۸.۴ | ۵۰.۴ | ۵۱.۳ | ۵۹.۳ | **۶۴.۸** |

</div>

> [!NOTE]
> تمام مدل‌ها در پیکربندی‌ای ارزیابی شده‌اند که طول خروجی را به ۸K محدود می‌کند. معیارهایی با کمتر از ۱۰۰۰ نمونه چندین بار با تنظیمات دمای مختلف آزمایش شده‌اند تا نتایج نهایی مقاوم حاصل شود. DeepSeek-V3 بهترین مدل متن‌باز است و همچنین عملکرد رقابتی با مدل‌های پیشتاز متن‌بسته دارد.


####  ارزیابی تولید بازمتن

<div align="center">



| مدل | Arena-Hard | AlpacaEval 2.0 |
|-------|------------|----------------|
| DeepSeek-V2.5-0905 | ۷۶.۲ | ۵۰.۵ |
| Qwen2.5-72B-Instruct | ۸۱.۲ | ۴۹.۱ |
| LLaMA-3.1 405B | ۶۹.۳ | ۴۰.۵ |
| GPT-4o-051۳ | ۸۰.۴ | ۵۱.۱ |
| Claude-Sonnet-3.5-1022 | ۸۵.۲ | ۵۲.۰ |
| DeepSeek-V3 | **۸۵.۵** | **۷۰.۰** |

</div>

> [!NOTE]
> ارزیابی مکالمه بازمتن به زبان انگلیسی. برای AlpacaEval 2.0 از نرخ پیروزی کنترل‌شده بر اساس طول به عنوان معیار استفاده می‌شود.


## 5. وبسایت چت و بستر API
شما می‌توانید با DeepSeek-V3 در وبسایت رسمی DeepSeek چت کنید: [chat.deepseek.com](https://chat.deepseek.com/sign_in)

ما همچنین API سازگار با OpenAI را در بستر DeepSeek ارائه می‌کنیم: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. نحوه اجرای محلی

DeepSeek-V3 را می‌توان به صورت محلی با استفاده از سخت‌افزارها و نرم‌افزارهای متن‌باز زیر پیاده‌سازی کرد:

1. **دموی DeepSeek-Infer**: دموی ساده و سبک برای استنتاج FP8 و BF16 فراهم کرده‌ایم.
2. **SGLang**: پشتیبانی کامل از مدل DeepSeek-V3 در هر دو حالت استنتاج BF16 و FP8، با پیش‌بینی چندتوکنی [به زودی](https://github.com/sgl-project/sglang/issues/2591).
3. **LMDeploy**: استنتاج کارآمد FP8 و BF16 برای پیاده‌سازی محلی و ابری را فراهم می‌کند.
4. **TensorRT-LLM**: در حال حاضر از استنتاج BF16 و کوانتیزاسیون INT4/8 پشتیبانی می‌کند، پشتیبانی از FP8 به زودی ارائه می‌شود.
5. **vLLM**: پشتیبانی از مدل DeepSeek-V3 با حالت‌های FP8 و BF16 برای موازی‌سازی تانسوری و خط لوله‌ای.
6. **LightLLM**: پشتیبانی از پیاده‌سازی کارآمد تک نود یا چند نود برای FP8 و BF16.
7. **AMD GPU**: اجرای مدل DeepSeek-V3 روی GPUهای AMD از طریق SGLang در هر دو حالت BF16 و FP8.
8. **Huawei Ascend NPU**: اجرای DeepSeek-V3 روی دستگاه‌های Huawei Ascend پشتیبانی می‌شود.

از آنجا که آموزش FP8 به طور بومی در چارچوب ما پیاده‌سازی شده است، تنها وزن‌های FP8 ارائه می‌شوند. اگر به وزن‌های BF16 برای آزمایش نیاز دارید، می‌توانید از اسکریپت تبدیل ارائه شده جهت انجام تبدیل استفاده نمایید.

نمونه تبدیل وزن‌های FP8 به BF16:

```shell
cd inference
python fp8_cast_bf16.py --input-fp8-hf-path /path/to/fp8_weights --output-bf16-hf-path /path/to/bf16_weights
```

> [!NOTE]
> Transformers هاجینگ‌فیس هنوز به طور مستقیم پشتیبانی نمی‌شود.

### 6.1 استنتاج با دموی DeepSeek-Infer (فقط نمونه)

#### نیازمندی‌های سیستم

> [!NOTE] 
> فقط لینوکس با پایتون ۳.۱۰. مک و ویندوز پشتیبانی نمی‌شوند.

وابستگی‌ها:
```pip-requirements
torch==2.4.1
triton==3.0.0
transformers==4.46.3
safetensors==0.4.5
```
#### آماده‌سازی وزن‌های مدل و کد دمو

ابتدا مخزن گیت‌هاب DeepSeek-V3 را کلون کنید:

```shell
git clone https://github.com/deepseek-ai/DeepSeek-V3.git
```

به پوشه `inference` رفته و وابستگی‌های موجود در `requirements.txt` را نصب کنید. بهترین روش استفاده از یک مدیر بسته مانند `conda` یا `uv` برای ایجاد محیط مجازی جدید و نصب وابستگی‌هاست.

```shell
cd DeepSeek-V3/inference
pip install -r requirements.txt
```

وزن‌های مدل را از Hugging Face دانلود کرده و در پوشه `/path/to/DeepSeek-V3` قرار دهید.

#### تبدیل وزن‌های مدل

وزن‌های مدل Hugging Face را به فرمت مخصوص تبدیل کنید:

```shell
python convert.py --hf-ckpt-path /path/to/DeepSeek-V3 --save-path /path/to/DeepSeek-V3-Demo --n-experts 256 --model-parallel 16
```

#### اجرا

اکنون می‌توانید با DeepSeek-V3 چت کنید:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --interactive --temperature 0.7 --max-new-tokens 200
```

یا استنتاج دسته‌ای روی یک فایل داده شده:

```shell
torchrun --nnodes 2 --nproc-per-node 8 --node-rank $RANK --master-addr $ADDR generate.py --ckpt-path /path/to/DeepSeek-V3-Demo --config configs/config_671B.json --input-file $FILE
```

### 6.2 استنتاج با SGLang (توصیه‌شده)

[SGLang](https://github.com/sgl-project/sglang) هم‌اکنون از [بهینه‌سازی‌های MLA](https://lmsys.org/blog/2024-09-04-sglang-v0-3/#deepseek-multi-head-latent-attention-mla-throughput-optimizations)، [DP Attention](https://lmsys.org/blog/2024-12-04-sglang-v0-4/#data-parallelism-attention-for-deepseek-models)، FP8 (W8A8)، کش FP8 KV و Torch Compile پشتیبانی می‌کند و بهترین عملکرد تأخیر و توان عملیاتی را در میان چارچوب‌های متن‌باز ارائه می‌دهد.

قابل توجه است که [SGLang v0.4.1](https://github.com/sgl-project/sglang/releases/tag/v0.4.1) به طور کامل اجرای DeepSeek-V3 را روی **کارت‌های گرافیک NVIDIA و AMD** پشتیبانی می‌کند و آن را به راهکاری همه‌کاره و قوی بدل می‌سازد.

SGLang همچنین از [موازی‌سازی تانسوری چند نودی](https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3#example-serving-with-2-h208) پشتیبانی می‌کند و امکان اجرای مدل روی چندین ماشین شبکه‌ای را می‌دهد.

پیش‌بینی چندتوکنی (MTP) در دست توسعه است و پیشرفت آن را می‌توانید در [برنامه بهینه‌سازی](https://github.com/sgl-project/sglang/issues/2591) پیگیری کنید.

دستورالعمل‌های راه‌اندازی تیم SGLang در اینجا: https://github.com/sgl-project/sglang/tree/main/benchmark/deepseek_v3

### 6.3 استنتاج با LMDeploy (توصیه‌شده)
[LMDeploy](https://github.com/InternLM/lmdeploy)، چارچوبی منعطف و با عملکرد بالا برای استنتاج و سرویس‌دهی مدل‌های زبانی بزرگ، هم‌اکنون از DeepSeek-V3 پشتیبانی می‌کند. این چارچوب هر دو قابلیت پردازش آفلاین خط لوله‌ای و استقرار آنلاین را فراهم کرده و با گردش کاری مبتنی بر PyTorch یکپارچه می‌شود.

برای راهنمایی گام به گام جهت اجرای DeepSeek-V3 با LMDeploy به اینجا مراجعه نمایید: https://github.com/InternLM/lmdeploy/issues/2960


### 6.4 استنتاج با TRT-LLM (توصیه‌شده)

[TensorRT-LLM](https://github.com/NVIDIA/TensorRT-LLM) اکنون از مدل DeepSeek-V3 پشتیبانی می‌کند و گزینه‌هایی مانند BF16 و INT4/INT8 را برای وزن‌ها ارائه می‌دهد. پشتیبانی از FP8 در حال توسعه است و به‌زودی منتشر خواهد شد. برای تجربه ویژگی‌های جدید، به شاخه اختصاصی TRTLLM برای DeepSeek-V3 مراجعه کنید: https://github.com/NVIDIA/TensorRT-LLM/tree/main/examples/deepseek_v3. 


### 6.5 استنتاج با vLLM (توصیه‌شده)

[vLLM](https://github.com/vllm-project/vllm) نسخه ۰.۶.۶ از استنتاج DeepSeek-V3 در حالت‌های FP8 و BF16 روی کارت‌های NVIDIA و AMD پشتیبانی می‌کند. علاوه بر تکنیک‌های استاندارد، vLLM موازی‌سازی خط لوله‌ای را ارائه می‌کند تا بتوانید مدل را روی چندین ماشین شبکه‌ای اجرا کنید. برای راهنمایی دقیق، به [راهنمای vLLM](https://docs.vllm.ai/en/latest/serving/distributed_serving.html) مراجعه نمایید. همچنین می‌توانید [برنامه بهبود](https://github.com/vllm-project/vllm/issues/11539) را دنبال کنید.

### 6.6 استنتاج با LightLLM (توصیه‌شده)

[LightLLM](https://github.com/ModelTC/lightllm/tree/main) نسخه ۱.۰.۱ از پیاده‌سازی موازی‌سازی تانسوری تک‌ماشینه و چندماشینه برای DeepSeek-R1 (FP8/BF16) پشتیبانی می‌کند و پیاده‌سازی با دقت ترکیبی و حالت‌های کوانتیزاسیون بیشتر در حال ادغام است. برای جزئیات بیشتر به [راهنمای LightLLM](https://lightllm-en.readthedocs.io/en/latest/getting_started/quickstart.html) مراجعه کنید. همچنین، LightLLM پیاده‌سازی PD-disaggregation را برای DeepSeek-V2 ارائه داده و پیاده‌سازی آن برای DeepSeek-V3 در دست توسعه است.

### 6.7 استنتاج توصیه‌شده با کارت‌های گرافیک AMD

در همکاری با تیم AMD، پشتیبانی روز اول برای کارت‌های گرافیک AMD با استفاده از SGLang و سازگاری کامل برای هر دو دقت FP8 و BF16 فراهم شده است. برای راهنمایی دقیق، به [راهنمای SGLang](#63-inference-with-lmdeploy-recommended) مراجعه نمایید.

### 6.8 استنتاج توصیه‌شده با NPUهای Huawei Ascend
چارچوب [MindIE](https://www.hiascend.com/en/software/mindie) از جامعه Huawei Ascend نسخه BF16 مدل DeepSeek-V3 را با موفقیت تطبیق داده است. برای راهنمایی گام به گام روی Ascend NPU به [اینجا](https://modelers.cn/models/MindIE/deepseekv3) مراجعه نمایید.


## 7. مجوز
این مخزن کد تحت [مجوز MIT](LICENSE-CODE) منتشر شده است. استفاده از مدل‌های پایه/چت DeepSeek-V3 مشمول [مجوز مدل](LICENSE-MODEL) می‌باشد. مجموعه DeepSeek-V3 (شامل Base و Chat) از استفاده تجاری پشتیبانی می‌کند.

## 8. ارجاع
```
@misc{deepseekai2024deepseekv3technicalreport,
      title={DeepSeek-V3 Technical Report}, 
      author={DeepSeek-AI},
      year={2024},
      eprint={2412.19437},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2412.19437}, 
}
```

## 9. تماس
در صورت داشتن هرگونه سؤال، لطفاً issue ثبت کنید یا با ما در [service@deepseek.com](service@deepseek.com) تماس بگیرید.


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---