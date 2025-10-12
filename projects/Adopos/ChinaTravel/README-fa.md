<center>
  <h1>ChinaTravel: یک معیار دنیای واقعی برای عامل‌های زبانی در برنامه‌ریزی سفر چینی
</h1>
</center>

مخزن رسمی کد برای مقاله "ChinaTravel: یک معیار دنیای واقعی برای عامل‌های زبانی در برنامه‌ریزی سفر چینی".

<!-- | [صفحه وب](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [مقاله](https://arxiv.org/abs/2412.13682) | [داده‌ها(Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![صفحه وب](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![مقاله](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![داده‌ها(Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![رقابت(TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![رقابت(TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![نمای کلی](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 چالش برنامه‌ریزی سفر IJCAI 2025 (TPC@IJCAI)

با افتخار اعلام می‌کنیم که ChinaTravel به عنوان معیار رسمی برای **چالش برنامه‌ریزی سفر (TPC) @ IJCAI 2025** انتخاب شده است!

**وب‌سایت رسمی رقابت**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

شرکت‌کنندگان دعوت می‌شوند تا عامل‌های نوآورانه‌ای را توسعه دهند که بتوانند سناریوهای واقعی برنامه‌ریزی سفر را تحت محدودیت‌های پیچیده مدیریت کنند. این رقابت روش‌های پیشرفته در پژوهش عامل‌های زبانی را به نمایش خواهد گذاشت.

## 📝 تغییرات

### 2025.09
1. راه‌حل قهرمانانه مسیر DSL TPC@IJCAI2025 بارگذاری شد. از [@evergreenee](https://github.com/evergreenee) برای مشارکت‌شان سپاسگزاریم.  


### 2025.06

1. رفع خطا در جمع‌آوری ارزیابی کد دانش عمومی. 
2. اصلاح خط لوله عامل خالص عصبی
3. رفع مشکل load_datasets از huggingface
4. به‌روزرسانی مدیریت استثناها در تأیید نحوی


### 2025.05

1. به‌روزرسانی لاگ‌ها برای نسخه‌ی جدید.
2. ارائه‌ی کد ارزیابی برای TPC.

### 2025.04

1. بارگذار داده‌ی محلی اضافه شد. کاربران اکنون می‌توانند کوئری‌های سفارشی را به صورت محلی بارگذاری کنند. هنگام تعیین مقدار غیرپیش‌فرض برای splits_name (مثلاً "abc") در "run_exp.py"، سیستم به طور خودکار فایل‌های مربوطه را از evaluation/default_splits/abc.txt بارگذاری می‌کند، جایی که فایل TXT شامل نام فایل‌های کوئری هدف است.
2. طبقه‌بندی محدودیت‌ها به صورت جزئی. مستندات جزئی را در [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md) ببینید.
3. معرفی مبنای LLM-modulo
   پیاده‌سازی پایپ‌لاین LLM-modulo با یک تأییدکننده نمادین ground-truth.
   براساس روش‌شناسی از:
   مقاله: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   پایگاه کد: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. پشتیبانی از استنتاج LLMهای محلی با Qwen3-8B/4B.

## 🚀 شروع سریع

### ⚙️ راه‌اندازی

1. یک محیط conda بسازید و وابستگی‌ها را نصب کنید:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

۲. پایگاه داده را دانلود کرده و آن را در پوشه "chinatravel/environment/" استخراج کنید

لینک‌های دانلود: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU)، [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

۳. مدل‌های متن‌باز LLM را دانلود کنید (اختیاری).

```bash
bash download_llm.sh
```

۴. توکنایزرها را دانلود کنید.

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ اجرا

ما از deepseek (رابط برنامه‌نویسی رسمی از deepseek)، gpt-4o (chatgpt-4o-latest)، glm4-plus، و استنتاج‌های محلی با Qwen (Qwen3-8B)، llama، mistral (Mistral-7B-Instruct-v0.3) و غیره پشتیبانی می‌کنیم.

```bash
export OPENAI_API_KEY=""

python run_exp.py --splits easy --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits medium --agent LLMNeSy --llm deepseek --oracle_translation
python run_exp.py --splits human --agent LLMNeSy --llm deepseek --oracle_translation

python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B --oracle_translation


python run_exp.py --splits human --agent LLMNeSy --llm deepseek 
python run_exp.py --splits human --agent LLMNeSy --llm Qwen3-8B 


python run_exp.py --splits human --agent LLM-modulo --llm deepseek --refine_steps 10 --oracle_translation
python run_exp.py --splits human --agent LLM-modulo --llm Qwen3-8B --refine_steps 10 --oracle_translation
```

**توجه**:

- فلگ `--oracle_translation` دسترسی به داده‌های واقعی دارای توضیحات را فعال می‌کند، شامل:

  - `hard_logic_py`: کد قابل اجرا برای تأیید در زبان DSL
  - `hard_logic_nl`: توضیحات مربوط به محدودیت‌ها
  - ساختار نمونه‌ی توضیحات:

  ```python
  {
    "hard_logic_py": [
      "
      total_cost=0 
      for activity in allactivities(plan):
          total_cost+=activity_cost(activity)
              total_cost += innercity_transport_cost(activity_transports(activity))
      result=(total_cost<=1000)
      ", 
      "
      innercity_transport_set=set()
      for activity in allactivities(plan):
          if activity_transports(activity)!=[]:              
              innercity_transport_set.add(innercity_transport_type(activity_transports(activity)))
      result=(innercity_transport_set<={'taxi'})
      "
    ], 
    "hard_logic_nl": ["总预算为1800元", "市内交通选择taxi"], 
  }
  ```
- روش LLM-modulo برای فرایند پالایش نمادین خود به حالت oracle_translation **نیاز دارد**

### 📊 ارزیابی

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```
در TPC@IJCAI2025، کد ارزیابی در فایل `eval_tpc.py` ارائه شده است. می‌توانید کد ارزیابی را به صورت زیر اجرا کنید:


```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 مستندات

[محیط](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[محدودیت‌ها](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ توسعه پیشرفته

### 1. توسعه الگوریتم عامل خودتان

برای توسعه الگوریتم عامل خودتان، باید کلاس `BaseAgent` را از `chinatravel/agent/base.py` به ارث ببرید و منطق الگوریتم خود را به تابع `init_agent` در `chinatravel/agent/load_model.py` اضافه کنید. ما یک نمونه عامل خالی به نام `TPCAgent` ارائه کرده‌ایم.

مراحل:

- **ارث‌بری از کلاس `BaseAgent`**: یک فایل پایتون جدید در مسیر `chinatravel/agent` ایجاد کنید و کلاس عامل خود را با ارث‌بری از `BaseAgent` تعریف نمایید.

```python:chinatravel/agent/your_agent.py
from .base import BaseAgent

class YourAgent(BaseAgent):
    def __init__(self, **kwargs):
        super().__init__(**kwargs)
        # Initialization logic

    def act(self, observation):
        # Implement the decision - making logic of the agent
        pass
```
- **کد را به تابع init_agent اضافه کنید**: فایل chinatravel/agent/load_model.py را باز کنید و پشتیبانی از عامل جدید خود را به تابع init_agent اضافه نمایید.


```python:
def init_agent(kwargs):
    # ... existing code ...
    elif kwargs["method"] == "YourMethodName":
        agent = YourAgent(
            **kwargs
        )
    # ... existing code ...
    return agent
```

### ۲. توسعه مدل زبانی بزرگ محلی خود

برای توسعه مدل زبانی بزرگ محلی (LLM) خود، باید کلاس AbstractLLM را از chinatravel/agent/llms.py ارث‌بری کرده و کد استنتاج مدل LLM محلی مربوطه را در llms.py اضافه کنید. ما یک مثال خالی از LLM به نام TPCLLM ارائه داده‌ایم.
مراحل:

- **ارث‌بری از کلاس AbstractLLM**: کلاس LLM خود را در فایل chinatravel/agent/llms.py تعریف کنید و از AbstractLLM ارث‌بری نمایید.

```python
class YourLLM(AbstractLLM):
    def __init__(self):
        super().__init__()
        # Initialization logic
        self.name = "YourLLMName"

    def _get_response(self, messages, one_line, json_mode):
        # Implement the response logic of the LLM
        response = "Your LLM response"
        if json_mode:
            # Handle JSON mode
            pass
        elif one_line:
            # Handle one - line mode
            response = response.split("\n")[0]
        return response
```

- **کد را به تابع init_agent اضافه کنید**: فایل chinatravel/agent/load_model.py را باز کنید و پشتیبانی از مدل زبانی جدید خود را در تابع init_llm اضافه نمایید.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. اجرای کد خود با استفاده از اسکریپت‌های آزمایشی

پس از تکمیل توسعه بالا، می‌توانید از اسکریپت‌های آزمایشی برای اجرای کد خود استفاده کنید.

نمونه‌ای از اجرا:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
نتایج در پوشه `results/YourMethodName_YourLLMName_xxx` ذخیره خواهند شد، به عنوان مثال: `results/TPCAgent_TPCLLM`.

## ✉️ تماس

در صورت وجود هرگونه مشکل، لطفاً با [جی-جینگ شائو](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn)، [بو-ون ژانگ](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn)، [شیائو-ون یانگ](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn) تماس بگیرید.

## 📌 ارجاع

اگر مقاله یا منابع مرتبط ما برای پژوهش شما ارزشمند بودند، لطفاً از ما ارجاع دهید.


```
@misc{shao2024chinatravelrealworldbenchmarklanguage,
      title={ChinaTravel: A Real-World Benchmark for Language Agents in Chinese Travel Planning}, 
      author={Jie-Jing Shao and Xiao-Wen Yang and Bo-Wen Zhang and Baizhi Chen and Wen-Da Wei and Guohao Cai and Zhenhua Dong and Lan-Zhe Guo and Yu-feng Li},
      year={2024},
      eprint={2412.13682},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2412.13682}, 
}
```
[English](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=th) | [Français](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=de) | [Español](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=it) | [Русский](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ru) | [Português](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=Adopos&project=ChinaTravel&lang=as)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-12

---