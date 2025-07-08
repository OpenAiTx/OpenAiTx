<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

این مخزن شامل کد و داده‌های SynLogic است، یک چارچوب جامع سنتز داده‌های استدلال منطقی که داده‌های متنوع و قابل‌تأیید استدلال را در مقیاس وسیع تولید می‌کند. کار ما به شکاف بحرانی موجود در داده‌های آموزش استدلال منطقی با کیفیت بالا برای توسعه قابلیت‌های عمومی استدلال در مدل‌های زبانی بزرگ (LLMs) می‌پردازد.

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## اخبار
- **[۲۰۲۵/۰۷/۰۷]** :fire: راهنمای استفاده از داده‌های SynLogic برای آموزش RL با چارچوب Verl را ارائه کردیم. برای جزئیات به [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) مراجعه کنید.

- **[۲۰۲۵/۰۶/۰۳]** :fire: مدل‌های آموزش‌دیده در Hugging Face منتشر شد:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[۲۰۲۵/۰۵]** :fire: با افتخار منابع مقاله "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond" را منتشر می‌کنیم.

## 📋 نمای کلی

**SynLogic** یک چارچوب سنتز داده و مجموعه داده جامع است که:
- 📊 **۳۵ وظیفه متنوع استدلال منطقی** را پوشش می‌دهد، از جمله سودوکو، بازی ۲۴، رمزنگاری، مارپیچ فلش و موارد دیگر
- 🎯 **امکان سنتز با درجه دشواری قابل کنترل** با پارامترهای قابل تنظیم برای هر وظیفه را فراهم می‌کند
- ✅ **پاداش‌های قابل تأیید** از طریق اعتبارسنجی مبتنی بر قواعد برای آموزش RL ارائه می‌دهد
- 🚀 **به عملکرد SOTA** در میان داده‌مجموعه‌های متن‌باز دست می‌یابد و DeepSeek-R1-Distill-Qwen-32B را با ۶ امتیاز در BBEH پشت سر می‌گذارد

### ویژگی‌های کلیدی
- **تولید داده مقیاس‌پذیر**: سنتز نامحدود با سطوح دشواری قابل کنترل
- **پوشش جامع وظایف**: ۳۵ وظیفه متمایز استدلال منطقی با تولیدکننده‌ها و اعتبارسنج‌های اختصاصی
- **آماده برای RL**: همه مثال‌ها قابل تأیید با قواعد ساده هستند و برای یادگیری تقویتی ایده‌آل‌اند
- **انتقال بین دامنه‌ای**: تعمیم قوی به حوزه‌های ریاضی و کدنویسی

## 🚀 شروع سریع

### نصب
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### تولید داده نمونه (مثال مارپیچ فلش)
```bash
# مثال سریع با مارپیچ فلش
bash games/tasks/arrow_maze/run.sh

# یا با پارامترهای سفارشی
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### برای آموزش RL

ما راهنمای جامعی برای استفاده از داده‌های SynLogic در آموزش یادگیری تقویتی ارائه می‌دهیم. برای راهنمای دقیق ادغام SynLogic با چارچوب Verl به [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) مراجعه کنید.

## :rocket: منابع

### داده‌مجموعه‌ها
| نام داده‌مجموعه | توضیحات | لینک |
|:------------:|:------------|:----:|
| **SynLogic** | داده‌مجموعه | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### مدل‌ها


| نام مدل | توضیحات | لینک |
|:-----------|:------------|:----:|
| **SynLogic-7B** | مدل ۷ میلیارد پارامتری آموزش‌دیده بر SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | مدل ۳۲ میلیارد پارامتری آموزش‌دیده بر SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | مدل ۳۲ میلیارد پارامتری آموزش‌دیده بر داده‌های ترکیبی SynLogic، ریاضی و کدنویسی | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 بروزرسانی‌های آینده
ما به طور فعال در حال گسترش SynLogic با وظایف استدلال منطقی بیشتر هستیم.

برای دریافت آخرین به‌روزرسانی‌ها و نسخه‌ها، مخزن ما را دنبال کنید!

## استناد
در صورتی که کار ما برای شما مفید بود، لطفاً به مقاله ما استناد کنید:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---