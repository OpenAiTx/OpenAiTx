# KVzip: فشرده‌سازی کش KV مستقل از پرس‌وجو با بازسازی زمینه

[[مقاله](https://arxiv.org/abs/2505.23416)] [[بلاگ](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## چه چیز جدیدی ارائه شده است؟
- KVzip کش KV را فشرده می‌کند تا از **پرس‌وجوهای متنوع آینده** پشتیبانی کند.
- [وابسته به زمینه] دستیابی به **کاهش ۳ تا ۴ برابری در اندازه کش KV** و **کاهش دو برابری تاخیر رمزگشایی** با حداقل افت عملکرد.
- [غیر وابسته به زمینه] بهبود فشرده‌سازی KV در سطح سر (head) به سبک [DuoAttention](https://github.com/mit-han-lab/duo-attention)، تنها با **چند پاس رو به جلو در کمتر از یک دقیقه** برای بهینه‌سازی امتیاز اهمیت سر (۱۰۰ برابر سریع‌تر).
- اجرای demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### بنچمارک در حالت مستقل از پرس‌وجو
- تسک‌ها: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad)، [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack)، [SCBench](https://github.com/microsoft/MInference/tree/main/scbench)، [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- مدل: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## نصب
ما از CUDA 12.1 و Python 3.10 استفاده کردیم
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- برای استفاده از کمیت‌بندی [QServe](https://github.com/mit-han-lab/omniserve) لطفاً به [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model) مراجعه کنید.
### مجموعه داده
- لطفاً مجموعه داده پیش‌پردازش‌شده SCBench را از [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link) دانلود کنید.
- اگر فایل‌ها را از حالت فشرده خارج کردید، کافی است پوشه scbench را جابجا کنید.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## شروع سریع
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # پر کردن کش KV + امتیازدهی اهمیت
kv.prune(ratio=0.3)  # نسبت فشرده‌سازی، حذف ۷۰٪ KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # استنتاج کارآمد
    print(q, output)
```
- مدل‌های پشتیبانی شده در [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py) فهرست شده‌اند، شامل **LLaMA3، Qwen2.5/3، Gemma3**.
- برای حذف سربار فشرده‌سازی، `load_score=True` تنظیم کنید. این امکان حذف KV مستقل از زمینه را فراهم می‌کند، با تبادل نسبت فشرده‌سازی `ratio=0.6`.
- پس از تولید، جفت‌های KV مربوط به پرس‌وجوها و توکن‌های تولید شده به صورت انتخابی از کش حذف می‌شوند. برای فعال کردن استنتاج چندمرحله‌ای، `update_cache=True` را تنظیم کنید تا کل تاریخچه تعامل حفظ شود.

## پروفایل‌گیری حافظه و زمان محاسبات
### حذف وابسته به زمینه
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- کد بالا همچنین خروجی‌های تولید شده با کش KV کامل و فشرده شده را مقایسه می‌کند.
- برای تست سریع، از `-d squad` استفاده کنید. برای تست زمینه بلند، از `-d scbench_kv` استفاده کنید.
  - نام‌های داده موجود: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - نام‌های مدل موجود: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)، مانند llama3.1-8b، qwen2.5-7b (یا Qwen/Qwen2.5-7B-Instruct-1M).
- ما کرنل CUDA را از [AdaKV](https://github.com/FFY0/AdaKV/tree/main) اقتباس کرده‌ایم، که تخصیص بودجه سر غیر یکنواخت را پشتیبانی می‌کند.
  - در حال حاضر، کد ما کرنل بهینه شده برای Gemma3 که از کش KV استاتیک استفاده می‌کند ندارد، بنابراین کد بهبود واقعی کارایی ارائه نمی‌دهد. با این حال، عملکرد مدل می‌تواند با کاهش توجه و نمونه‌برداری KV (`--kv_type retain`) ارزیابی شود.


### حذف مستقل از زمینه (بدون سربار فشرده‌سازی در زمان اجرا)
- از پرچم `--level head` با `--ratio 0.6` (توصیه شده) استفاده کنید.
  - تمام جفت‌های KV مربوط به یک سر خاص حذف می‌شوند در حالی که جفت‌های KV مربوط به سیستم پرامپت و پرس‌وجو حفظ می‌شوند.
  - امتیازهای سر پیش‌محاسبه شده برای LLaMA3.1-8B و Qwen2.5-7/14B در `./utils/head_score` موجود است.
- برای محاسبه امتیازهای سر برای مدل‌های دیگر:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - نتایج در `./utils/head_score` ذخیره خواهد شد.
  - اگر هدف تسک برنامه‌نویسی است، توصیه می‌کنیم فرمان را با `-d scbench_repoqa` نیز اجرا کنید. این امکان استفاده مدل از بیشینه امتیازهای سر از هر دو زبان طبیعی و برنامه‌نویسی را فراهم می‌کند که عملکرد را بهبود می‌بخشد.
- این امتیازها می‌توانند به صورت یکپارچه با موتور بهینه استنتاج [DuoAttention](https://github.com/mit-han-lab/duo-attention) با جایگزینی داده‌های امتیاز سر آنها با امتیازهای ما ادغام شوند.


## ارزیابی
- برای تولید پاسخ‌های مدل با نسبت‌های فشرده‌سازی KV از ۰.۱ تا ۱.۰:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - نتایج در `./results/[data_name]` ذخیره می‌شود.
  - مجموعه داده‌های پشتیبانی شده در `data/load.py` فهرست شده‌اند.
- برای محاسبه معیارهای ارزیابی از نتایج تولید شده:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## اعمال بر روی مدل‌های جدید
برای ادغام KVzip با یک مدل جدید، باید فایل‌های زیر را به‌روزرسانی کنید:
- `attention/attn.py`  
  منطق پاس رو به جلو توجه را در صورت نیاز اصلاح کنید. در برخی موارد، به‌روزرسانی‌های kvcache.py و score.py نیز لازم است.
- `model/monkeypatch.py`  
  پیاده‌سازی پچ‌های اختصاصی مدل برای ادغام.
- `model/template.py`   
  تعریف پرامپت سیستم مدل و قالب‌بندی چت.


## ارجاع
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## مجوز
مجوز MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---