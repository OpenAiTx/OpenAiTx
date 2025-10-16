<center>
  <h1>ChinaTravel: معيار واقعي لوكلاء اللغة في تخطيط السفر الصيني
</h1>
</center>

المستودع الرسمي للشفرة الخاصة بورقة "ChinaTravel: معيار واقعي لوكلاء اللغة في تخطيط السفر الصيني".

<!-- | [الصفحة الرسمية](https://www.lamda.nju.edu.cn/shaojj/chinatravel/) | [الورقة العلمية](https://arxiv.org/abs/2412.13682) | [مجموعة البيانات (Huggingface)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)| -->

[![الصفحة الرسمية](https://img.shields.io/badge/Webpage-Visit-blue)](https://www.lamda.nju.edu.cn/shaojj/chinatravel/)
[![الورقة العلمية](https://img.shields.io/badge/Paper-View-red)](https://arxiv.org/abs/2412.13682)
[![مجموعة البيانات (Huggingface)](https://img.shields.io/badge/Dataset-Huggingface-yellow)](https://huggingface.co/datasets/LAMDA-NeSy/ChinaTravel)
[![المسابقة (TPC@IJCAI2025)](https://img.shields.io/badge/IJCAI%20Competition-TPC@IJCAI2025-green)](https://chinatravel-competition.github.io/IJCAI2025/)
[![المسابقة (TPC@AIC2025)](https://img.shields.io/badge/AIC%20Competition-TPC@AIC2025-green)](TPC@AIC2025/readme.md)


<!-- 
![نظرة عامة](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/images/overview.png) -->

## 🏆 تحدي تخطيط السفر IJCAI 2025 (TPC@IJCAI)

يسعدنا أن نعلن أن ChinaTravel تم اختياره كمعيار رسمي لتحدي **تخطيط السفر (TPC) @ IJCAI 2025**!

**الموقع الرسمي للمسابقة**:
[https://chinatravel-competition.github.io/IJCAI2025/](https://chinatravel-competition.github.io/IJCAI2025/)

ندعو المشاركين لتطوير وكلاء مبتكرين يمكنهم التعامل مع سيناريوهات تخطيط السفر الواقعية تحت قيود معقدة. ستستعرض هذه المسابقة أحدث الأساليب في أبحاث وكلاء اللغة.

## 📝 سجل التغييرات

### 2025.09
1. رفع الحل الفائز في مسار DSL لـ TPC@IJCAI2025. نشكر [@evergreenee](https://github.com/evergreenee) على مساهماتهم.  


### 2025.06

1. تصحيح جمع الأخطاء في كود التقييم الخاص بالمعرفة العامة.
2. تصحيح مسار وكيل العصبي البحت
3. تصحيح تحميل مجموعات البيانات من huggingface
4. تحديث معالجة الاستثناءات في التحقق من بناء الجملة


### 2025.05

1. سجل التحديثات لأحدث إصدار.
2. توفير كود التقييم لـ TPC.

### 2025.04

1. تمت إضافة محمّل بيانات محلي. يمكن للمستخدمين الآن تحميل الاستعلامات المخصصة محلياً. عند تحديد قيم splits_name غير الافتراضية (مثلاً، "abc") لـ "run_exp.py"، سيقوم النظام تلقائياً بتحميل الملفات المقابلة من evaluation/default_splits/abc.txt، حيث يحتوي ملف TXT على أسماء ملفات الاستعلام المستهدفة.
2. تصنيف القيود بشكل مفصل. راجع الوثائق المفصلة على [Evaluation README](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)
3. تقديم خط الأساس LLM-modulo
   تنفيذ خط أنابيب LLM-modulo مع محقق رمزي موثوق.
   استناداً إلى المنهجية من:
   ورقة: Robust Planning with Compound LLM Architectures: An LLM-Modulo Approach
   قاعدة الكود: https://github.com/Atharva-Gundawar/LLM-Modulo-prompts
4. دعم استدلال LLMs المحلي باستخدام Qwen3-8B/4B.

## 🚀 بدء سريع

### ⚙️ الإعداد

1. أنشئ بيئة conda وقم بتثبيت التبعيات:

```bash
conda create -n chinatravel python=3.9  
conda activate chinatravel  
pip install -r requirements.txt  
```

2. قم بتنزيل قاعدة البيانات وفك ضغطها إلى دليل "chinatravel/environment/"

روابط التنزيل: [Google Drive](https://drive.google.com/drive/folders/1bJ7jA5cfExO_NKxKfi9qgcxEbkYeSdAU)، [NJU Drive](https://box.nju.edu.cn/d/dd83e5a4a9e242ed8eb4/)

3. قم بتنزيل نماذج اللغة المفتوحة المصدر (اختياري).

```bash
bash download_llm.sh
```

4. قم بتنزيل أدوات تقسيم النص (Tokenizers).

```bash
wget https://cdn.deepseek.com/api-docs/deepseek_v3_tokenizer.zip -P chinatravel/local_llm/
unzip chinatravel/local_llm/deepseek_v3_tokenizer.zip -d chinatravel/local_llm/
```

### ▶️ التشغيل

ندعم deepseek (واجهة برمجة التطبيقات الرسمية من deepseek)، gpt-4o (chatgpt-4o-latest)، glm4-plus، والاستدلالات المحلية باستخدام Qwen (Qwen3-8B)، llama، mistral (Mistral-7B-Instruct-v0.3)، وغيرها.

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

**ملاحظة**:

- يتيح العلم `--oracle_translation` الوصول إلى البيانات الحقيقية المشروحة والتي تتضمن:

  - `hard_logic_py`: كود لغة التحقق القابل للتنفيذ (DSL)
  - `hard_logic_nl`: أوصاف القيود المقابلة
  - مثال على هيكل التعليق التوضيحي:

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
- طريقة LLM-modulo **تتطلب** وضع oracle_translation لعملية التحسين الرمزي الخاصة بها

### 📊 التقييم

```bash
python eval_exp.py --splits human --method LLMNeSy_deepseek_oracletranslation
python eval_exp.py --splits human --method LLMNeSy_deepseek
python eval_exp.py --splits human --method LLM-modulo_deepseek_10steps_oracletranslation
python eval_exp.py --splits human --method LLM-modulo_Qwen3-8B_10steps_oracletranslation

```
في TPC@IJCAI2025، يتم توفير كود التقييم في ملف `eval_tpc.py`. يمكنك تشغيل كود التقييم كما يلي:


```bash
python eval_tpc.py --splits tpc_phase1 --method YOUR_METHOD_NAME
```

## 📚 الوثائق

[البيئة](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/environment/readme.md)
[القيود](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/chinatravel/symbol_verification/readme.md)

## 🛠️ التطوير المتقدم

### 1. تطوير خوارزمية الوكيل الخاصة بك

لتطوير خوارزمية الوكيل الخاصة بك، عليك أن ترث فئة `BaseAgent` من `chinatravel/agent/base.py` وتضيف منطق الخوارزمية الخاصة بك إلى دالة `init_agent` في `chinatravel/agent/load_model.py`. نحن نوفر مثال وكيل فارغ يسمى `TPCAgent`.

الخطوات:

- **وراثة فئة `BaseAgent`**: أنشئ ملف بايثون جديد في مجلد `chinatravel/agent` وعرّف فئة الوكيل الخاصة بك، وارثًا من `BaseAgent`.

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

- **أضف الكود إلى دالة init_agent**: افتح ملف chinatravel/agent/load_model.py وأضف الدعم لوكيلك الجديد في دالة init_agent.

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

### 2. تطوير نموذج اللغة الكبير المحلي الخاص بك

لتطوير نموذج لغة كبير محلي (LLM) خاص بك، تحتاج إلى توريث فئة AbstractLLM من ملف chinatravel/agent/llms.py وإضافة كود الاستدلال الخاص بنموذج LLM المحلي في llms.py. نقدم مثالاً فارغاً لنموذج LLM باسم TPCLLM.
الخطوات:

- **وراثة فئة AbstractLLM**:  قم بتعريف فئة نموذج LLM الخاصة بك في ملف chinatravel/agent/llms.py، وارثًا من AbstractLLM.

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

- **أضف الكود إلى دالة init_agent**: افتح ملف chinatravel/agent/load_model.py وأضف دعمًا لنموذج llm الجديد الخاص بك في دالة init_llm.

```python:
def init_llm(kwargs):
    # ... existing code ...
    elif llm_name == "glm4-plus":
        llm = YourLLM()
    # ... existing code ...
    return llm
```

### 3. تشغيل الكود باستخدام سكريبتات التجارب

بعد الانتهاء من التطوير أعلاه، يمكنك استخدام سكريبتات التجارب لتشغيل الكود الخاص بك.

مثال على التشغيل:

```bash
python run_tpc.py --splits easy --agent TPCAgent --llm TPCLLM
python run_exp.py --splits easy --agent YourMethodName --llm YourLLMName
```
سيتم حفظ النتائج في دليل `results/YourMethodName_YourLLMName_xxx`، على سبيل المثال: `results/TPCAgent_TPCLLM`.

## ✉️ التواصل

إذا واجهتك أية مشاكل، يرجى التواصل مع [جيه-جينغ شاو](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/shaojj@lamda.nju.edu.cn)، [بو-وين تشانغ](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/221900200@smail.nju.edu.cn)، [شياو-وين يانغ](https://raw.githubusercontent.com/Adopos/ChinaTravel/main/yangxw@lamda.nju.edu.cn).

## 📌 الاقتباس

إذا كانت ورقتنا البحثية أو الموارد ذات الصلة مفيدة لأبحاثك، نرجو منك ذكرها كمصدر.


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---