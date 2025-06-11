# KVzip: ضغط ذاكرة KV للكاش مستقل عن الاستعلام مع إعادة بناء السياق

[[ورقة بحثية](https://arxiv.org/abs/2505.23416)] [[مدونة](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## ما الجديد؟
- يقوم KVzip بضغط ذاكرة KV للكاش لدعم **استعلامات مستقبلية متنوعة**.
- [معتمد على السياق] تحقيق **تقليل بحجم ذاكرة KV بمقدار 3–4×** و **تقليل زمن فك التشفير بمقدار 2×**، مع أدنى تدهور في الأداء.
- [غير معتمد على السياق] تحسين ضغط KV على مستوى الرؤوس بأسلوب [DuoAttention](https://github.com/mit-han-lab/duo-attention)، باستخدام فقط **بضع تمريرات أمامية خلال دقيقة واحدة** لتحسين درجات أهمية الرؤوس (أسرع 100 مرة).
- تشغيل demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### تقييم الأداء في إعداد مستقل عن الاستعلام
- المهام: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad)، [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack)، [SCBench](https://github.com/microsoft/MInference/tree/main/scbench)، [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- النموذج: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## التثبيت
استخدمنا CUDA 12.1 و Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- لاستخدام التكميم [QServe](https://github.com/mit-han-lab/omniserve)، يرجى اتباع [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### مجموعة البيانات
- يرجى تحميل مجموعة بيانات SCBench المعالجة مسبقًا من [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- إذا قمت بتحميل الملفات غير مضغوطة، فقط انقل مجلد scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## بداية سريعة
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # تعبئة ذاكرة KV + تقييم الأهمية
kv.prune(ratio=0.3)  # نسبة الضغط، التخلص من 70% من KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # استدلال فعال
    print(q, output)
```
- النماذج المدعومة مدرجة في [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)، بما في ذلك **LLaMA3، Qwen2.5/3، Gemma3**.
- ضبط `load_score=True` لإلغاء تحميل ضغط الذاكرة. هذا يتيح التخلص من KV مستقل عن السياق، مع تنازل في نسبة الضغط عند `ratio=0.6`.
- بعد التوليد، يتم التخلص انتقائيًا من أزواج KV المرتبطة بالاستعلامات والرموز المولدة من الكاش للمعالجة اللاحقة. اضبط `update_cache=True` لتمكين الاستدلال متعدد الجولات، مع الاحتفاظ بسجلات التفاعل الكاملة طوال الاستدلال.

## قياس الذاكرة ووقت الحوسبة
### التخلص المعتمد على السياق
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- الكود أعلاه يقارن أيضًا بين المخرجات الناتجة باستخدام ذاكرة KV كاملة مقابل مضغوطة.
- للاختبار السريع، استخدم `-d squad`. للاختبار في سياق طويل، استخدم `-d scbench_kv`.
  - أسماء البيانات المتاحة: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - أسماء النماذج المتاحة: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py)، مثل llama3.1-8b، qwen2.5-7b (أو Qwen/Qwen2.5-7B-Instruct-1M).
- قمنا بتكييف نواة CUDA من [AdaKV](https://github.com/FFY0/AdaKV/tree/main)، تدعم تخصيص ميزانية غير متجانسة للرؤوس.
  - حاليًا، لا يحتوي كودنا على نواة محسنة لـ Gemma3 التي تستخدم ذاكرة KV ثابتة، لذلك لا يحقق الكود كفاءة فعلية. ومع ذلك، يمكن تقييم أداء النموذج باستخدام الانتباه المخفض مع أخذ عينات KV (`--kv_type retain`).


### التخلص غير المعتمد على السياق (بدون تحميل ضغط وقت التشغيل)
- استخدم العلامة `--level head` مع `--ratio 0.6` (موصى به).
  - نقوم بإزالة جميع أزواج KV المرتبطة برأس معين مع الاحتفاظ بأزواج KV الخاصة بنظام المطالبة والاستعلام.
  - درجات الرؤوس المحسوبة مسبقًا متوفرة لـ LLaMA3.1-8B و Qwen2.5-7/14B في `./utils/head_score`.
- لحساب درجات الرؤوس لنماذج أخرى:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - سيتم حفظ النتائج في `./utils/head_score`.
  - إذا كنت تستهدف مهمة ترميز، نوصي أيضًا بتشغيل الأمر مع `-d scbench_repoqa`. هذا يسمح للنموذج باستخدام درجات الرأس القصوى من اللغتين الطبيعية والبرمجية، مما يحسن الأداء.
- يمكن دمج هذه الدرجات بسهولة مع محرك الاستدلال المحسن لـ [DuoAttention](https://github.com/mit-han-lab/duo-attention) عن طريق استبدال بيانات درجات الرأس الخاصة بهم ببياناتنا.


## التقييم
- لتوليد ردود النموذج مع نسب ضغط KV تتراوح من 0.1 إلى 1.0:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - سيتم حفظ النتائج في `./results/[data_name]`.
  - مجموعات البيانات المدعومة مدرجة في `data/load.py`.
- لحساب مقاييس التقييم من النتائج المولدة:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## التطبيق على نماذج جديدة
لدمج KVzip مع نموذج جديد، ستحتاج إلى تحديث الملفات التالية:
- `attention/attn.py`  
  تعديل منطق تمرير الانتباه الأمامي حسب الحاجة. في بعض الحالات، قد يكون مطلوبًا تحديث `kvcache.py` و `score.py`.
- `model/monkeypatch.py`  
  تنفيذ تصحيح القرد الخاص بالنموذج للدمج.
- `model/template.py`   
  تعريف مطالبة نظام النموذج وقوالب تنسيق المحادثة.


## الاقتباس
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## الترخيص
رخصة MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---