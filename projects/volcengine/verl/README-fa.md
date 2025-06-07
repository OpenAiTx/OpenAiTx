<div align="center">
 👋 سلام به همه! 
    verl یک کتابخانه آموزش یادگیری تقویتی (RL) است که توسط <b>تیم Seed بایت‌دنس</b> آغاز شده و توسط جامعه verl نگهداری می‌شود.
    <br>
    <br>
</div>

<div align="center">

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="Ask DeepWiki.com" height="20"/>](https://deepwiki.com/volcengine/verl)
[![GitHub Repo stars](https://img.shields.io/github/stars/volcengine/verl)](https://github.com/volcengine/verl/stargazers)
[![Twitter](https://img.shields.io/twitter/follow/verl_project)](https://twitter.com/verl_project)
<a href="https://join.slack.com/t/verlgroup/shared_invite/zt-2w5p9o4c3-yy0x2Q56s_VlGLsJ93A6vA"><img src="https://img.shields.io/badge/Slack-verl-blueviolet?logo=slack&amp"></a>
<a href="https://arxiv.org/pdf/2409.19256"><img src="https://img.shields.io/static/v1?label=EuroSys&message=Paper&color=red"></a>
[![Documentation](https://img.shields.io/badge/documentation-blue)](https://verl.readthedocs.io/en/latest/)
<a href="https://raw.githubusercontent.com/eric-haibin-lin/verl-community/refs/heads/main/WeChat.JPG"><img src="https://img.shields.io/badge/微信-green?logo=wechat&amp"></a>

</div>

![seed logo](https://github.com/user-attachments/assets/c42e675e-497c-4508-8bb9-093ad4d1f216)

<h1 style="text-align: center;">verl: موتور یادگیری تقویتی Volcano برای مدل‌های زبانی بزرگ</h1>

verl یک کتابخانه آموزش RL انعطاف‌پذیر، کارآمد و آماده برای تولید مدل‌های زبانی بزرگ (LLM) است.

verl نسخه متن‌باز مقاله **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)** است.

ویژگی‌های اصلی verl عبارتند از:

- **افزونه‌پذیری آسان الگوریتم‌های متنوع RL**: مدل برنامه‌نویسی کنترل‌کننده هیبریدی امکان نمایش انعطاف‌پذیر و اجرای کارآمد جریان‌های داده پیچیده پس از آموزش را فراهم می‌کند. جریان‌های RL مانند GRPO، PPO را تنها با چند خط کد بسازید.

- **ادغام بی‌دردسر زیرساخت‌های موجود LLM با APIهای ماژولار**: تفکیک وابستگی‌های محاسباتی و داده‌ای، امکان ادغام بی‌دردسر با فریم‌ورک‌های LLM موجود مانند FSDP، Megatron-LM، vLLM، SGLang و غیره را فراهم می‌کند.

- **نگاشت انعطاف‌پذیر دستگاه‌ها**: پشتیبانی از جایگذاری مدل‌ها روی مجموعه‌های مختلف GPU برای استفاده بهینه از منابع و مقیاس‌پذیری در اندازه‌های مختلف خوشه.

- ادغام آماده با مدل‌های محبوب HuggingFace

verl سریع است با:

- **توان عملیاتی پیشرفته**: یکپارچه‌سازی با موتورهای آموزش و استنتاج SOTA LLM و ارائه بالاترین نرخ RL.

- **بازپخش کارآمد مدل بازیگر با 3D-HybridEngine**: حذف افزونگی حافظه و کاهش چشمگیر سربار ارتباطی در انتقال بین فازهای آموزش و تولید.

</p>

## اخبار

- [2025/06] verl با پشتیبانی Megatron مدل‌های MoE بزرگ مانند [DeepSeek-671b و Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html) را فعال می‌کند.
- [2025/06] تیم verl جدیدترین به‌روزرسانی‌های پروژه را در [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) در ۷ ژوئن ارائه خواهد داد. تیم توسعه ما را در پکن ملاقات کنید!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957)، پذیرفته شده در ICML 2025، اکنون در verl پشتیبانی می‌شود! PF-PPO با فیلتر سیگنال‌های پاداش پر نویز و استفاده مجدد از تجربیات با کیفیت بالا از طریق بافر بازپخش، کارایی و استحکام یادگیری سیاست را افزایش می‌دهد.
- [2025/04] در [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=)، [کارگاه SCI-FM](https://open-foundation-model.github.io/) و [LMSys afterparty](https://lu.ma/d23nyynm) آموزش تکنیک‌های جدید پس‌آموزشی و راهنمای برنامه‌نویسی verl را ارائه می‌دهیم. مواد ارائه [اینجا](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25) در دسترس است.
- [2025/04] گزارش فنی [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) منتشر شد! با آموزش verl، Seed-Thinking-v1.5 در آزمون AIME 2024 امتیاز 86.7، در Codeforces امتیاز 55.0 و در GPQA امتیاز 77.3 را کسب کرده و توانایی استدلال عالی را در حوزه‌های STEM و برنامه‌نویسی نشان داده است. این روش فراتر از مسائل استدلال، تعمیم قابل توجهی را در حوزه‌های متنوع نشان می‌دهد.
- [2025/04] مقاله [VAPO](https://arxiv.org/pdf/2504.05118) (PPO تقویت‌شده مبتنی بر ارزش) آخرین روش RL ما برای مدل‌های استدلال را پوشش می‌دهد. این مدل با Qwen-32B-base آموزش دیده و در آزمون AIME 2024 امتیاز 60.4 را کسب کرده و از DAPO-32B پیشی گرفته است.
- [2025/03] verl نسخه v0.3.0.post1 منتشر شد! برای جزئیات به [یادداشت انتشار](https://github.com/volcengine/verl/releases/) مراجعه کنید. این نسخه نسبت به نسخه‌های قبلی [~1.4 برابر سرعت بالاتر](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) دارد.
- [2025/03] [DAPO](https://dapo-sia.github.io/) یک الگوریتم SOTA RL متن‌باز است که با مدل Qwen2.5-32B روی AIME 2024 امتیاز 50 کسب می‌کند و رکورد قبلی DeepSeek's GRPO (DeepSeek-R1-Zero-Qwen-32B) را پشت سر گذاشته است. آموزش DAPO کاملاً با verl انجام شده و کد بازتولید آن هم‌اکنون در `recipe/dapo` در دسترس است.
<details><summary> بیشتر... </summary>
<ul>
  <li>[2025/05] verl در [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) در تاریخ 16-17 می ارائه خواهد شد.</li>
  <li>[2025/05] verl در [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/) ارائه خواهد شد. پاریس می‌بینیمتان!</li>
  <li>[2025/03] مدل برنامه‌نویسی verl را در [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) و [معرفی و به‌روزرسانی verl](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) در [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) در Sunnyvale ارائه کردیم.</li>
  <li>[2025/03] verl(HybridFlow) را در EuroSys 2025 ارائه خواهیم کرد. روتردام می‌بینیمتان!</li>
  <li>[2025/02] نسخه v0.2.0.post2 verl منتشر شد!</li>
  <li>[2025/02] verl را در <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a> ارائه کردیم. سن‌خوزه می‌بینیمتان!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) با عملکرد سطح SOTA روی LLM و VLM منتشر شد. مدل پیش‌نمایش مقیاس RL با verl آموزش دیده و به عملکرد OpenAI O1 روی معیارهای ریاضی (70.0 pass@1 روی AIME) رسیده است.</li>
  <li>[2024/12] verl در Ray Forward 2024 ارائه شد. اسلایدها <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">اینجا</a></li>
  <li>[2024/12] تیم <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> را در NeurIPS 2024 ارائه کرد. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">اسلایدها</a> و <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">ویدیو</a> در دسترس است.</li>
  <li>[2024/10] verl در Ray Summit ارائه شد. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">ویدیوی یوتیوب</a> در دسترس است.</li>
  <li>[2024/08] HybridFlow (verl) به EuroSys 2025 پذیرفته شد.</li>
</ul>   
</details>

## ویژگی‌های کلیدی

- **FSDP**، **FSDP2** و **Megatron-LM** برای آموزش.
- **vLLM**، **SGLang** و **HF Transformers** برای تولید rollout.
- سازگار با Hugging Face Transformers و Modelscope Hub: [Qwen-3](https://github.com/volcengine/verl/blob/main/examples/grpo_trainer/run_qwen3-8b.sh)، Qwen-2.5، Llama3.1، Gemma2، DeepSeek-LLM و غیره
- تنظیم دقیق تحت نظارت (Supervised fine-tuning).
- یادگیری تقویتی با [PPO](examples/ppo_trainer/)، [GRPO](examples/grpo_trainer/)، [ReMax](examples/remax_trainer/)، [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm)، [RLOO](examples/rloo_trainer/)، [PRIME](recipe/prime/)، [DAPO](recipe/dapo/)، [DrGRPO](recipe/drgrpo) و غیره.
  - پشتیبانی از پاداش مبتنی بر مدل و پاداش مبتنی بر تابع (پاداش قابل راستی‌آزمایی) برای ریاضی، [کدنویسی](https://github.com/volcengine/verl/tree/main/recipe/dapo) و غیره
  - پشتیبانی از مدل‌های بینایی-زبان (VLM) و [یادگیری تقویتی چندوجهی](examples/grpo_trainer/run_qwen2_5_vl-7b.sh) با Qwen2.5-vl، Kimi-VL
  - [چند نوبت با فراخوانی ابزار](https://github.com/volcengine/verl/tree/main/examples/sglang_multiturn)
- دستورالعمل‌های هم‌ترازی LLM مانند [Self-play preference optimization (SPPO)](https://github.com/volcengine/verl/tree/main/recipe/sppo)
- Flash attention 2، [بسته‌بندی توالی](examples/ppo_trainer/run_qwen2-7b_seq_balance.sh)، [موازی‌سازی توالی](examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) با DeepSpeed Ulysses، [LoRA](examples/sft/gsm8k/run_qwen_05_peft.sh)، [Liger-kernel](examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- مقیاس‌پذیری تا مدل‌های 671B و صدها GPU با [موازی‌سازی خبره‌ها](https://github.com/volcengine/verl/pull/1467)
- پشتیبانی چند GPU برای [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) برای صرفه‌جویی در حافظه.
- پیگیری آزمایش‌ها با wandb، swanlab، mlflow و tensorboard.

## ویژگی‌ها و تغییرات آینده

- نقشه راه https://github.com/volcengine/verl/issues/710
- بهینه‌سازی DeepSeek 671b با Megatron v0.11 https://github.com/volcengine/verl/issues/708
- rollout چند نوبته و ابزارها با بهینه‌سازی https://github.com/volcengine/verl/issues/1882
- تعامل با محیط https://github.com/volcengine/verl/issues/1172
- لیست تغییرات ناسازگار از نسخه v0.3 https://github.com/volcengine/verl/discussions/943، مقدار پیش‌فرض entropy_coeff صفر است
- Lora برای RL https://github.com/volcengine/verl/pull/1127 

## شروع سریع

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>مستندات</b></a>

**شروع سریع:**

- [نصب](https://verl.readthedocs.io/en/latest/start/install.html)
- [شروع سریع](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [راهنمای برنامه‌نویسی](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO در verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO در verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**اجرای نمونه PPO گام به گام:**

- [آماده‌سازی داده برای پس‌آموزش](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [پیاده‌سازی تابع پاداش برای داده‌ها](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [معماری نمونه PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [توضیح پیکربندی](https://verl.readthedocs.io/en/latest/examples/config.html)

**مبنای الگوریتم‌های قابل بازتولید:**

- [عملکرد RL روی کدنویسی، ریاضی](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**برای توضیح کد و استفاده پیشرفته (گسترش):**

- مربی PPO و کارگران
  - [مربی PPO Ray](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [پشتوانه PyTorch FSDP](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [پشتوانه Megatron-LM](https://verl.readthedocs.io/en/latest/index.html)

- استفاده پیشرفته و توسعه
  - [افزودن مدل با پشتوانه FSDP](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [افزودن مدل با پشتوانه Megatron-LM](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [پشتیبانی rollout چند نوبته](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [ادغام ابزار جستجو](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [ادغام Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [استقرار با استفاده از منابع GPU جداگانه](https://github.com/volcengine/verl/tree/main/examples/split_placement)
  - [گسترش به سایر الگوریتم‌های RL(HF)](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [آموزش طراحی API Ray](https://verl.readthedocs.io/en/latest/advance/placement.html)

**وبلاگ‌های جامعه**

- [SGLang، verl، OpenBMB و دانشگاه Tsinghua: پیشگام RLHF چند نوبته انتها به انتها](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [یادگیری تقویتی از بازخورد انسانی روی GPUهای AMD با verl و ادغام ROCm](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl: یادگیری تقویتی را حرفه‌ای یاد بگیرید](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [بهترین روش توزیع‌شده آموزش GRPO با verl](https://www.volcengine.com/docs/6459/1463942)
- [بررسی مقاله HybridFlow verl](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [افزایش تا ۲۰ برابر توان عملیاتی! تیم مدل بزرگ Doubao چارچوب جدید RLHF را منتشر کرد، اکنون متن‌باز است!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## راهنمای بهینه‌سازی عملکرد

عملکرد برای الگوریتم RL مبتنی بر سیاست بسیار مهم است. ما یک [راهنمای جامع بهینه‌سازی عملکرد](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) برای کمک به بهبود عملکرد نوشته‌ایم.

## ارتقا به vLLM >= v0.8.2

verl اکنون در صورت استفاده از FSDP به عنوان پشتوانه آموزش از vLLM>=0.8.2 پشتیبانی می‌کند. لطفاً برای راهنمای نصب و اطلاعات بیشتر به [این سند](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md) مراجعه کنید. از نسخه vllm 0.7.x اجتناب کنید، زیرا دارای باگ‌هایی است که ممکن است منجر به خطای OOM و دیگر خطاهای غیرمنتظره شود.

## استفاده از آخرین SGLang

SGLang به طور کامل توسط verl پشتیبانی می‌شود و گروه RL SGLang به طور گسترده روی ساخت قابلیت‌های منحصر به فرد شامل RL عاملی چند نوبته، RLHF VLM، RL مبتنی بر سرور و rollout جزئی کار می‌کند. لطفاً برای راهنمای نصب و اطلاعات بیشتر به [این سند](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) مراجعه کنید.

## ارتقا به FSDP2

verl کاملاً پذیرای FSDP2 است! FSDP2 توسط تیم توزیع Torch توصیه می‌شود، نرخ انتقال و مصرف حافظه بهتری دارد و با سایر قابلیت‌ها (مثلاً torch.compile) قابل ترکیب است. برای فعال‌سازی FSDP2 کافی است verl main را اجرا و گزینه‌های زیر را تنظیم کنید:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
علاوه بر این، offloading روی CPU در FSDP2 با انباشت گرادیان سازگار است. می‌توانید آن را برای صرفه‌جویی در حافظه با `actor_rollout_ref.actor.offload_policy=True` فعال کنید. برای جزئیات بیشتر، به https://github.com/volcengine/verl/pull/1026 مراجعه کنید.

## پشتیبانی AMD (هسته ROCm)

verl اکنون از FSDP به عنوان موتور آموزش (پشتیبانی Megatron به‌زودی) و همچنین vLLM و SGLang به عنوان موتورهای استنتاج پشتیبانی می‌کند. برای راهنمای نصب و اطلاعات بیشتر به [این سند](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) و برای راهنمای بهینه‌سازی عملکرد vLLM روی ROCm به [این سند](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst) مراجعه کنید.

## استناد و قدردانی

اگر این پروژه برای شما مفید بود، لطفاً به موارد زیر استناد کنید:

- [HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)
- [A Framework for Training Large Language Models for Code Generation via Proximal Policy Optimization](https://i.cs.hku.hk/~cwu/papers/gmsheng-NL2Code24.pdf)

```bibtex
@article{sheng2024hybridflow,
  title   = {HybridFlow: A Flexible and Efficient RLHF Framework},
  author  = {Guangming Sheng and Chi Zhang and Zilingfeng Ye and Xibin Wu and Wang Zhang and Ru Zhang and Yanghua Peng and Haibin Lin and Chuan Wu},
  year    = {2024},
  journal = {arXiv preprint arXiv: 2409.19256}
}
```

verl با الهام از طراحی Nemo-Aligner، Deepspeed-chat و OpenRLHF ساخته شده است. این پروژه توسط ByteDance، Anyscale، LMSys.org، [تیم Qwen علی‌بابا](https://github.com/QwenLM/)، آزمایشگاه هوش مصنوعی شانگهای، دانشگاه Tsinghua، UC Berkeley، UCLA، UIUC، دانشگاه هنگ‌کنگ، ke.com، [All Hands AI](https://www.all-hands.dev/)، [ModelBest](http://modelbest.cn/)، OpenPipe، آزمایشگاه JD AI، Microsoft Research، [StepFun](https://www.stepfun.com/)، Amazon، LinkedIn، Meituan، [Camel-AI](https://www.camel-ai.org/)، [OpenManus](https://github.com/OpenManus)، شیائومی، Prime Intellect، تحقیقات NVIDIA، [Baichuan](https://www.baichuan-ai.com/home)، [RedNote](https://www.xiaohongshu.com/)، [SwissAI](https://www.swiss-ai.org/)، [Moonshot AI (Kimi)](https://www.moonshot-ai.com/)، بایدو، Snowflake و بسیاری دیگر پذیرفته و گسترش داده شده است.

## پروژه‌های عالی با استفاده از verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): بازتولید دستورالعمل **DeepSeek R1 Zero** برای وظایف استدلال ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): آموزش RL برای Sky-T1-7B توسط تیم NovaSky AI. ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: بررسی و رام‌سازی یادگیری تقویتی صفر برای مدل‌های پایه متن‌باز در محیط‌های واقعی ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): چارچوب آموزش RL **چندوجهی** ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): چارچوب تنظیم RL عامل‌های LLM برای محیط‌های چندعاملی. ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): آموزش RL ناهمزمان با [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): فرآیند تقویت از طریق پاداش‌های ضمنی ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): چارچوب آموزش عامل **استدلال** عمومی ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL با استدلال و **جستجو (فراخوانی ابزار)** مدل‌های LLM به صورت درهم ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): آموزش RL **عامل جستجو** با **نتیجه جستجو/بازیابی** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): یادگیری **استدلال** با **جستجو** برای LLMها از طریق یادگیری تقویتی ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): بازتولید R1 برای **کدنویسی** با پاداش‌های قابل اعتماد ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): سری مدل‌های استدلال باز Skywork ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): مقیاس‌دهی RL یکپارچه با ابزار ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): چارچوب آموزش مقیاس‌پذیر برای عامل‌های LLM/VLM با افق بلند، به همراه الگوریتم جدید **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): پالایش سیاست برای PPO بر اساس قابلیت اطمینان سیگنال‌های پاداش برای RLHF کارآمدتر و مقاوم‌تر.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: مدل اقدام بینایی-زبان عمومی برای **عامل‌های GUI** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): مقیاس‌دهی تحقیق عمیق از طریق یادگیری تقویتی در محیط‌های واقعی ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): آموزش عامل‌های VLM با یادگیری تقویتی چند نوبته ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: یادگیری تقویتی برای استفاده راهبردی از ابزار در LLMها. انتشار کد در دست انجام است...
- [RM-R1](https://arxiv.org/abs/2505.02387): آموزش RL مدل‌های پاداش استدلال ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): چارچوب بازی خودکار بدون داده انسانی برای استدلال![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): یادگیری استدلال تحت راهنمایی خارج از سیاست![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): چارچوب آموزش عامل-ابزار یکپارچه و قابل توسعه بر پایه verl![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): داده DeepMath-103K و سری مدل‌های استدلال ریاضی![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

و بسیاری پروژه عالی دیگر که در [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md) فهرست شده‌اند.
## راهنمای مشارکت

مشارکت شما از جامعه استقبال می‌شود! لطفاً [نقشه راه پروژه](https://github.com/volcengine/verl/issues/710) و [مسائل مناسب شروع](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) را برای مشارکت مشاهده کنید.

### بررسی و قالب‌بندی کد

ما از pre-commit برای بهبود کیفیت کد استفاده می‌کنیم. برای راه‌اندازی pre-commit این دستورات را اجرا کنید:

```bash
pip install pre-commit
pre-commit install
```

برای رفع خطاهای CI محلی، می‌توانید pre-commit را به صورت دستی اجرا کنید:

```bash
pre-commit run
```

### افزودن تست‌های CI

در صورت امکان، لطفاً تست CI برای ویژگی جدید خود اضافه کنید:

1. فایل yml گردش کار مرتبط را بیابید که معمولاً با یک پیکربندی پیش‌فرض `hydra` (مثلاً `ppo_trainer`، `ppo_megatron_trainer`، `sft_trainer` و غیره) مطابقت دارد.
2. الگوهای مسیر مرتبط را به بخش `paths` اضافه کنید اگر قبلاً وارد نشده است.
3. حجم کار اسکریپت تست را به حداقل برسانید (به اسکریپت‌های موجود مراجعه کنید).

## درباره [تیم Seed بایت‌دنس](https://team.doubao.com/)

تیم Seed بایت‌دنس در سال 2023 تأسیس شد و متعهد به توسعه پیشرفته‌ترین مدل‌های پایه هوش مصنوعی در صنعت است. این تیم در تلاش است تا به یک تیم تحقیقاتی سطح جهانی تبدیل شود و سهم مهمی در پیشرفت علم و جامعه داشته باشد. با کانال‌های زیر بیشتر با تیم Seed آشنا شوید 👇
<div>
  <a href="https://team.doubao.com/">
    <img src="https://img.shields.io/badge/Website-%231e37ff?style=for-the-badge&logo=bytedance&logoColor=white"></a>
  <a href="https://github.com/user-attachments/assets/469535a8-42f2-4797-acdf-4f7a1d4a0c3e">
    <img src="https://img.shields.io/badge/WeChat-07C160?style=for-the-badge&logo=wechat&logoColor=white"></a>
 <a href="https://www.xiaohongshu.com/user/profile/668e7e15000000000303157d?xsec_token=ABl2-aqekpytY6A8TuxjrwnZskU-6BsMRE_ufQQaSAvjc%3D&xsec_source=pc_search">
    <img src="https://img.shields.io/badge/Xiaohongshu-%23FF2442?style=for-the-badge&logo=xiaohongshu&logoColor=white"></a>
  <a href="https://www.zhihu.com/org/dou-bao-da-mo-xing-tuan-dui/">
    <img src="https://img.shields.io/badge/zhihu-%230084FF?style=for-the-badge&logo=zhihu&logoColor=white"></a>

</div>
---

ما در حال جذب نیرو هستیم! اگر به فرصت‌های کارآموزی یا تمام‌وقت در حوزه RL برای عامل‌ها علاقه‌مند هستید، [ایمیل](mailto:haibin.lin@bytedance.com) ارسال کنید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---