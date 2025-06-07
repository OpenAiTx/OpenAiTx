# DeepSeek-R1
<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-R1" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/" target="_blank"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/" target="_blank"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20R1-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai" target="_blank"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5" target="_blank"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true" target="_blank"><img alt="WeChat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai" target="_blank"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE"><img alt="License"
    src="https://img.shields.io/badge/License-MIT-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Paper Link</b>👁️</a>
</div>

## 1. معرفی

ما اولین نسل مدل‌های استدلال خود، DeepSeek-R1-Zero و DeepSeek-R1 را معرفی می‌کنیم.
مدل DeepSeek-R1-Zero، مدلی است که بدون استفاده از تنظیم دقیق نظارت‌شده (SFT) و فقط با یادگیری تقویتی (RL) در مقیاس وسیع آموزش داده شده و عملکرد چشمگیری در استدلال از خود نشان داده است.
با بهره‌گیری از RL، DeepSeek-R1-Zero به طور طبیعی رفتارهای استدلالی قدرتمند و جالبی را به نمایش گذاشته است.
با این حال، DeepSeek-R1-Zero با چالش‌هایی مانند تکرار بی‌پایان، خوانایی ضعیف و اختلاط زبان‌ها روبه‌رو است. برای رفع این مشکلات و بهبود بیشتر عملکرد استدلالی،
مدل DeepSeek-R1 را معرفی می‌کنیم که داده‌های شروع سرد را پیش از RL وارد فرایند می‌کند.
DeepSeek-R1 در وظایف ریاضی، کدنویسی و استدلال، عملکردی هم‌تراز با OpenAI-o1 ارائه می‌دهد.
برای حمایت از جامعه تحقیقاتی، ما DeepSeek-R1-Zero، DeepSeek-R1 و شش مدل چگال استخراج‌شده از DeepSeek-R1 بر پایه Llama و Qwen را به صورت متن‌باز ارائه داده‌ایم. مدل DeepSeek-R1-Distill-Qwen-32B در مقایسه با OpenAI-o1-mini در بنچمارک‌های مختلف عملکرد بهتری دارد و نتایج جدیدی برای مدل‌های چگال ثبت می‌کند.

**نکته: پیش از اجرای مدل‌های سری DeepSeek-R1 به صورت محلی، اکیداً توصیه می‌کنیم بخش [توصیه‌های استفاده](#usage-recommendations) را مطالعه فرمایید.**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. خلاصه مدل

---

**پس‌آموزش: یادگیری تقویتی در مقیاس وسیع بر روی مدل پایه**

- ما یادگیری تقویتی (RL) را به طور مستقیم بر روی مدل پایه بدون وابستگی به تنظیم دقیق نظارت‌شده (SFT) به عنوان مرحله مقدماتی اعمال کردیم. این رویکرد به مدل اجازه می‌دهد تا زنجیره تفکر (CoT) را برای حل مسائل پیچیده کشف کند و در نهایت منجر به توسعه DeepSeek-R1-Zero شد. DeepSeek-R1-Zero قابلیت‌هایی مانند خود-سنجی، بازتاب و تولید زنجیره‌های تفکر طولانی را نشان می‌دهد که نقطه عطفی برای جامعه تحقیقاتی محسوب می‌شود. شایان ذکر است که این اولین تحقیق متن‌باز است که اثبات می‌کند قابلیت‌های استدلالی مدل‌های زبانی بزرگ (LLM) می‌تواند صرفاً با RL و بدون نیاز به SFT تقویت شود. این پیشرفت راه را برای پیشرفت‌های آتی در این حوزه هموار می‌کند.

- ما خط لوله توسعه DeepSeek-R1 را معرفی می‌کنیم. این خط لوله شامل دو مرحله RL برای کشف الگوهای استدلالی بهتر و همراستایی با ترجیحات انسانی و همچنین دو مرحله SFT است که به عنوان بذر قابلیت‌های استدلالی و غیر استدلالی مدل عمل می‌کنند.
    ما باور داریم این خط لوله به صنعت در ساخت مدل‌های بهتر کمک خواهد کرد.

---

**استخراج (Distillation): مدل‌های کوچک نیز می‌توانند قدرتمند باشند**

- ما نشان دادیم که الگوهای استدلالی مدل‌های بزرگ‌تر را می‌توان به مدل‌های کوچک‌تر استخراج کرد و در نتیجه عملکردی بهتر نسبت به الگوهای استدلالی حاصل از RL روی مدل‌های کوچک به دست آورد. DeepSeek-R1 متن‌باز و همچنین API آن به جامعه تحقیقاتی کمک خواهد کرد تا مدل‌های کوچک‌تر بهتری استخراج کنند.
- با استفاده از داده‌های استدلالی تولید شده توسط DeepSeek-R1، چندین مدل چگال که به طور گسترده در جامعه تحقیقاتی استفاده می‌شوند را تنظیم دقیق کردیم. نتایج ارزیابی نشان می‌دهد که مدل‌های چگال کوچک‌تر استخراج‌شده در بنچمارک‌ها عملکرد بسیار خوبی دارند. ما نقاط بازیابی شده 1.5B، 7B، 8B، 14B، 32B و 70B را بر پایه Qwen2.5 و سری Llama3 به صورت متن‌باز در اختیار جامعه قرار می‌دهیم.

## 3. دانلود مدل‌ها

### مدل‌های DeepSeek-R1

<div align="center">

| **مدل** | **تعداد پارامتر کل** | **تعداد پارامتر فعال** | **طول کانتکست** | **دانلود** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

مدل‌های DeepSeek-R1-Zero و DeepSeek-R1 بر پایه DeepSeek-V3-Base آموزش دیده‌اند.
برای جزئیات بیشتر درباره معماری مدل به مخزن [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) مراجعه کنید.

### مدل‌های DeepSeek-R1-Distill

<div align="center">

| **مدل** | **مدل پایه** | **دانلود** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

مدل‌های DeepSeek-R1-Distill بر پایه مدل‌های متن‌باز با استفاده از نمونه‌های تولیدشده توسط DeepSeek-R1 تنظیم دقیق شده‌اند.
پیکربندی و توکنایزر آن‌ها کمی تغییر یافته است. لطفاً برای اجرای این مدل‌ها از تنظیمات ما استفاده نمایید.

## 4. نتایج ارزیابی

### ارزیابی DeepSeek-R1
برای تمام مدل‌های ما، حداکثر طول تولید برابر با 32,768 توکن تنظیم شده است. برای بنچمارک‌هایی که نیاز به نمونه‌گیری دارند، دمای 0.6، مقدار top-p معادل 0.95 و تولید 64 پاسخ برای هر پرسش به منظور برآورد pass@1 استفاده می‌شود.
<div align="center">


| دسته | بنچمارک (معیار) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | معماری | - | - | MoE | - | - | MoE |
| | تعداد پارامتر فعال | - | - | 37B | - | - | 37B |
| | تعداد کل پارامتر | - | - | 671B | - | - | 671B |
| انگلیسی | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| کد | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| ریاضی | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| چینی | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### ارزیابی مدل‌های استخراج‌شده


<div align="center">

| مدل                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
|------------------------------------------|------------------|-------------------|-----------------|----------------------|----------------------|-------------------|
| GPT-4o-0513                          | 9.3              | 13.4              | 74.6            | 49.9                 | 32.9                 | 759               |
| Claude-3.5-Sonnet-1022             | 16.0             | 26.7                 | 78.3            | 65.0                 | 38.9                 | 717               |
| o1-mini                              | 63.6             | 80.0              | 90.0            | 60.0                 | 53.8                 | **1820**          |
| QwQ-32B-Preview                              | 44.0             | 60.0                 | 90.6            | 54.5               | 41.9                 | 1316              |
| DeepSeek-R1-Distill-Qwen-1.5B       | 28.9             | 52.7              | 83.9            | 33.8                 | 16.9                 | 954               |
| DeepSeek-R1-Distill-Qwen-7B          | 55.5             | 83.3              | 92.8            | 49.1                 | 37.6                 | 1189              |
| DeepSeek-R1-Distill-Qwen-14B         | 69.7             | 80.0              | 93.9            | 59.1                 | 53.1                 | 1481              |
| DeepSeek-R1-Distill-Qwen-32B        | **72.6**         | 83.3              | 94.3            | 62.1                 | 57.2                 | 1691              |
| DeepSeek-R1-Distill-Llama-8B         | 50.4             | 80.0              | 89.1            | 49.0                 | 39.6                 | 1205              |
| DeepSeek-R1-Distill-Llama-70B        | 70.0             | **86.7**          | **94.5**        | **65.2**             | **57.5**             | 1633              |

</div>


## 5. وب‌سایت گفتگو و پلتفرم API
شما می‌توانید با DeepSeek-R1 در وب‌سایت رسمی DeepSeek به آدرس: [chat.deepseek.com](https://chat.deepseek.com) گفتگو کنید و گزینه "DeepThink" را فعال نمایید.

همچنین ما API سازگار با OpenAI را در پلتفرم DeepSeek ارائه می‌دهیم: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. نحوه اجرای محلی

### مدل‌های DeepSeek-R1

لطفاً برای اطلاعات بیشتر درباره اجرای مدل DeepSeek-R1 به صورت محلی به مخزن [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) مراجعه فرمایید.

**نکته: پشتیبانی مستقیم از Transformers در Hugging Face هنوز فراهم نشده است.**

### مدل‌های DeepSeek-R1-Distill

مدل‌های DeepSeek-R1-Distill را می‌توان همانند مدل‌های Qwen یا Llama استفاده کرد.

برای مثال، می‌توانید به راحتی با [vLLM](https://github.com/vllm-project/vllm) یک سرویس راه‌اندازی کنید:

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

همچنین می‌توانید به راحتی با [SGLang](https://github.com/sgl-project/sglang) سرویس راه‌اندازی کنید:

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### توصیه‌های استفاده

**توصیه می‌کنیم برای دستیابی به عملکرد مطلوب در استفاده از مدل‌های سری DeepSeek-R1 (از جمله برای بنچمارک‌ها) پیکربندی‌های زیر را رعایت کنید:**

1. دما را در بازه 0.5 تا 0.7 (مقدار پیشنهادی 0.6) تنظیم کنید تا از تکرار بی‌پایان یا خروجی‌های نامنسجم جلوگیری شود.
2. **از افزودن system prompt خودداری کنید؛ همه دستورات باید در داخل user prompt قرار گیرند.**
3. برای مسائل ریاضی، توصیه می‌شود راهنمایی مانند: "لطفاً گام به گام استدلال کنید و پاسخ نهایی را در \boxed{} قرار دهید." به prompt اضافه نمایید.
4. هنگام ارزیابی عملکرد مدل، توصیه می‌شود چندین بار آزمایش انجام داده و میانگین نتایج را محاسبه کنید.

همچنین مشاهده کرده‌ایم که مدل‌های سری DeepSeek-R1 در پاسخ به برخی پرسش‌ها، الگوی تفکر (یعنی خروجی "\<think\>\n\n\</think\>") را نادیده می‌گیرند که می‌تواند بر عملکرد مدل تأثیر منفی بگذارد.
**برای اطمینان از اینکه مدل استدلال کافی انجام می‌دهد، توصیه می‌کنیم مدل را ملزم کنید که پاسخ خود را همواره با "\<think\>\n" آغاز نماید.**

### پرامپت‌های رسمی
در وب‌سایت/اپلیکیشن رسمی DeepSeek، ما از system prompt استفاده نمی‌کنیم اما برای بارگذاری فایل و جستجوی وب دو پرامپت ویژه برای تجربه کاربری بهتر طراحی کرده‌ایم. همچنین دما در وب/اپ برابر با 0.6 است.

برای بارگذاری فایل، لطفاً طبق قالب زیر پرامپت بسازید که {file_name}، {file_content} و {question} ورودی هستند.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

برای جستجوی وب، {search_results}، {cur_date} و {question} ورودی هستند.

برای پرسش به زبان چینی، از این پرامپت استفاده می‌شود:
```
search_answer_zh_template = \
'''# 以下内容是基于用户发送的消息的搜索结果:
{search_results}
在我给你的搜索结果中，每个结果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的数字索引。请在适当的情况下在句子末尾引用上下文。请按照引用编号[citation:X]的格式在答案中对应部分引用上下文。如果一句话源自多个上下文，请列出所有相关的引用编号，例如[citation:3][citation:5]，切记不要将引用集中在最后返回引用编号，而是在答案对应部分列出。
在回答时，请注意以下几点：
- 今天是{cur_date}。
- 并非搜索结果的所有内容都与用户的问题密切相关，你需要结合问题，对搜索结果进行甄别、筛选。
- 对于列举类的问题（如列举所有航班信息），尽量将答案控制在10个要点以内，并告诉用户可以查看搜索来源、获得完整信息。优先提供信息完整、最相关的列举项；如非必要，不要主动告诉用户搜索结果未提供的内容。
- 对于创作类的问题（如写论文），请务必在正文的段落中引用对应的参考编号，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解读并概括用户的题目要求，选择合适的格式，充分利用搜索结果并抽取重要信息，生成符合用户要求、极具思想深度、富有创造力与专业性的答案。你的创作篇幅需要尽可能延长，对于每一个要点的论述要推测用户的意图，给出尽可能多角度的回答要点，且务必信息量大、论述详尽。
- 如果回答很长，请尽量结构化、分段落总结。如果需要分点作答，尽量控制在5个点以内，并合并相关的内容。
- 对于客观类的问答，如果问题的答案非常简短，可以适当补充一到两句相关信息，以丰富内容。
- 你需要根据用户要求和回答内容选择合适、美观的回答格式，确保可读性强。
- 你的回答应该综合多个相关网页来回答，不能重复引用一个网页。
- 除非用户要求，否则你回答的语言需要和用户提问的语言保持一致。

# 用户消息为：
{question}'''
```

برای پرسش به زبان انگلیسی، از این پرامپت استفاده می‌شود:
```
search_answer_en_template = \
'''# The following contents are the search results related to the user's message:
{search_results}
In the search results I provide to you, each result is formatted as [webpage X begin]...[webpage X end], where X represents the numerical index of each article. Please cite the context at the end of the relevant sentence when appropriate. Use the citation format [citation:X] in the corresponding part of your answer. If a sentence is derived from multiple contexts, list all relevant citation numbers, such as [citation:3][citation:5]. Be sure not to cluster all citations at the end; instead, include them in the corresponding parts of the answer.
When responding, please keep the following points in mind:
- Today is {cur_date}.
- Not all content in the search results is closely related to the user's question. You need to evaluate and filter the search results based on the question.
- For listing-type questions (e.g., listing all flight information), try to limit the answer to 10 key points and inform the user that they can refer to the search sources for complete information. Prioritize providing the most complete and relevant items in the list. Avoid mentioning content not provided in the search results unless necessary.
- For creative tasks (e.g., writing an essay), ensure that references are cited within the body of the text, such as [citation:3][citation:5], rather than only at the end of the text. You need to interpret and summarize the user's requirements, choose an appropriate format, fully utilize the search results, extract key information, and generate an answer that is insightful, creative, and professional. Extend the length of your response as much as possible, addressing each point in detail and from multiple perspectives, ensuring the content is rich and thorough.
- If the response is lengthy, structure it well and summarize it in paragraphs. If a point-by-point format is needed, try to limit it to 5 points and merge related content.
- For objective Q&A, if the answer is very brief, you may add one or two related sentences to enrich the content.
- Choose an appropriate and visually appealing format for your response based on the user's requirements and the content of the answer, ensuring strong readability.
- Your answer should synthesize information from multiple relevant webpages and avoid repeatedly citing the same webpage.
- Unless the user requests otherwise, your response should be in the same language as the user's question.

# The user's message is:
{question}'''
```

## 7. مجوز
کد این مخزن و وزن مدل‌ها تحت [مجوز MIT](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE) ارائه شده است.
مدل‌های سری DeepSeek-R1 از استفاده تجاری پشتیبانی می‌کنند و هرگونه تغییر و توسعه مشتق‌شده، از جمله استخراج (distillation) برای آموزش مدل‌های زبانی دیگر، مجاز است. لطفاً توجه داشته باشید:
- مدل‌های DeepSeek-R1-Distill-Qwen-1.5B، DeepSeek-R1-Distill-Qwen-7B، DeepSeek-R1-Distill-Qwen-14B و DeepSeek-R1-Distill-Qwen-32B از [سری Qwen-2.5](https://github.com/QwenLM/Qwen2.5) مشتق شده‌اند که در اصل تحت [مجوز Apache 2.0](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE) منتشر شده‌اند و اکنون با 800 هزار نمونه گردآوری‌شده با DeepSeek-R1 تنظیم دقیق شده‌اند.
- مدل DeepSeek-R1-Distill-Llama-8B از Llama3.1-8B-Base مشتق شده و دارای [مجوز Llama3.1](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE) است.
- مدل DeepSeek-R1-Distill-Llama-70B از Llama3.3-70B-Instruct مشتق شده و دارای [مجوز Llama3.3](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE) است.

## 8. استناد
```bibtex
@misc{deepseekai2025deepseekr1incentivizingreasoningcapability,
      title={DeepSeek-R1: Incentivizing Reasoning Capability in LLMs via Reinforcement Learning}, 
      author={DeepSeek-AI},
      year={2025},
      eprint={2501.12948},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2501.12948}, 
}
```

## 9. تماس
در صورت وجود هرگونه سوال، لطفاً یک issue ثبت کنید یا با ما از طریق [service@deepseek.com](mailto:service@deepseek.com) تماس بگیرید.


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---