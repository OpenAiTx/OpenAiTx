# MemoryOS
<div align="center">
  <img src="https://raw.githubusercontent.com/BAI-LAB/MemoryOS/main/logo_1.png" alt="logo" width="400"/>
</div>
<p align="center">
  <a href="https://arxiv.org/abs/2506.06326">
    <img src="https://img.shields.io/badge/Arxiv-paper-red" alt="Mem0 Discord">
  </a>
  <a href="https://github.com/user-attachments/assets/d195e740-1249-4eb1-962a-2c0d99a38c39">
    <img src="https://img.shields.io/badge/Wechat-群二维码-green" alt="Mem0 PyPI - Downloads">
  </a>
  <a href="https://youtu.be/y9Igs0FnX_M" target="blank">
    <img src="https://img.shields.io/badge/Demo-Video-red" alt="Npm package">
  </a>
    <a href="https://www.apache.org/licenses/LICENSE-2.0" target="_blank">
    <img src="https://img.shields.io/badge/License-Apache_2.0-blue" alt="License: Apache 2.0">
  </a>
</p>

<h5 align="center"> 🎉 إذا أعجبك مشروعنا، يرجى دعمنا بنجمة ⭐ على GitHub للحصول على آخر التحديثات.</h5>
**MemoryOS** صُمم لتوفير نظام تشغيل ذاكرة لوكلاء الذكاء الاصطناعي المخصصين، مما يمكّن من تفاعلات أكثر ترابطاً وشخصية ووعياً بالسياق. مستلهماً من مبادئ إدارة الذاكرة في أنظمة التشغيل، يعتمد بنية تخزين هرمية مع أربعة وحدات أساسية: التخزين، التحديث، الاسترجاع، والتوليد، لتحقيق إدارة ذاكرة شاملة وفعّالة. على معيار LoCoMo، حقق النموذج متوسط تحسين بمقدار **49.11%** و **46.18%** في درجات F1 و BLEU-1.







## 📣 آخر الأخبار
*   *<mark>[جديد]</mark>* 🔥  **[2025-06-15]**:🛠️ تم إطلاق **MemoryOS-MCP** مفتوح المصدر! الآن قابل للتكوين على عملاء الوكلاء للتكامل والتخصيص السلس. [👉 查看](#memoryos_mcp-getting-started)
*   **[2025-05-30]**: تم إصدار النسخة الأولى من **MemoryOS**! يتضمن ذاكرة شخصية قصيرة، متوسطة، وطويلة الأمد مع تحديث تلقائي لملف المستخدم والمعرفة.

## العرض التوضيحي
[![شاهد الفيديو](https://img.youtube.com/vi/y9Igs0FnX_M/maxresdefault.jpg)](https://youtu.be/y9Igs0FnX_M)

## 	بنية النظام
![image](https://github.com/user-attachments/assets/09200494-03a9-4b7d-9ffa-ef646d9d51f0)

## هيكل المشروع

```
memoryos/
├── __init__.py            # تهيئة حزمة MemoryOS
├── __pycache__/           # مجلد كاش بايثون (يتم توليده تلقائياً)
├── long_term.py           # إدارة الذاكرة الشخصية طويلة الأمد (ملف المستخدم، المعرفة)
├── memoryos.py            # الفئة الرئيسية لـ MemoryOS، تنسق جميع المكونات
├── mid_term.py            # إدارة الذاكرة متوسطة الأمد، دمج التفاعلات قصيرة الأمد
├── prompts.py             # يتضمن التعليمات المستخدمة لتفاعلات LLM (مثل التلخيص، التحليل)
├── retriever.py           # استرجاع المعلومات ذات الصلة من جميع طبقات الذاكرة
├── short_term.py          # إدارة الذاكرة قصيرة الأمد للتفاعلات الحديثة
├── updater.py             # معالجة تحديثات الذاكرة، بما في ذلك ترقية المعلومات بين الطبقات
└── utils.py               # دوال مساعدة مستخدمة عبر المكتبة
```

## كيف يعمل

1.  **التهيئة:** يتم تهيئة `Memoryos` بمعرّفات المستخدم والمساعد، ومفاتيح API، ومسارات تخزين البيانات، وإعدادات السعة/العتبة المختلفة. يتم إنشاء مساحة تخزين مخصصة لكل مستخدم ومساعد.
2.  **إضافة الذكريات:** يتم إضافة مدخلات المستخدم وردود الوكيل كأزواج سؤال وجواب، وتُخزن مبدئياً في الذاكرة قصيرة الأمد.
3.  **المعالجة من الذاكرة قصيرة إلى متوسطة الأمد:** عند امتلاء الذاكرة قصيرة الأمد، يعالج وحدة `Updater` هذه التفاعلات، ويدمجها في مقاطع ذات معنى وتخزينها في الذاكرة متوسطة الأمد.
4.  **تحليل الذاكرة متوسطة الأمد وتحديثات LPM:** تتراكم مقاطع الذاكرة متوسطة الأمد "حرارة" بناءً على عوامل مثل تواتر الزيارة وطول التفاعل. عندما تتجاوز حرارة المقطع عتبة معينة، يتم تحليل محتواه:
    *   يتم استخراج رؤى ملف المستخدم واستخدامها لتحديث ملف المستخدم طويل الأمد.
    *   تضاف حقائق المستخدم المحددة إلى معرفة المستخدم طويلة الأمد.
    *   تضاف المعلومات ذات الصلة للمساعد إلى قاعدة معرفة المساعد طويلة الأمد.
5.  **توليد الاستجابة:** عند استلام استعلام المستخدم:
    *   تسترجع وحدة `Retriever` السياق المناسب من السجل القصير، ومقاطع الذاكرة متوسطة الأمد، وملف المستخدم والمعرفة، وقاعدة معرفة المساعد.
    *   يتم استخدام هذا السياق الشامل مع استعلام المستخدم لتوليد استجابة متماسكة ومستنيرة عبر LLM.

## MemoryOS_PYPI بدء الاستخدام

### المتطلبات الأساسية

*   Python >= 3.10
*   pip install -i https://pypi.org/simple/ MemoryOS-BaiJia

### التثبيت

```bash
conda create -n MemoryOS python=3.10
conda activate MemoryOS
pip install -i https://pypi.org/simple/ MemoryOS-BaiJia
```

### الاستخدام الأساسي

```python

import os
from memoryos import Memoryos

# --- الإعداد الأساسي ---
USER_ID = "demo_user"
ASSISTANT_ID = "demo_assistant"
API_KEY = "YOUR_OPENAI_API_KEY"  # استبدلها بمفتاحك
BASE_URL = ""  # اختياري: إذا كنت تستخدم نقطة نهاية OpenAI مخصصة
DATA_STORAGE_PATH = "./simple_demo_data"
LLM_MODEL = "gpt-4o-mini"

def simple_demo():
    print("MemoryOS عرض توضيحي بسيط")
    
    # 1. تهيئة MemoryOS
    print("جاري تهيئة MemoryOS...")
    try:
        memo = Memoryos(
            user_id=USER_ID,
            openai_api_key=API_KEY,
            openai_base_url=BASE_URL,
            data_storage_path=DATA_STORAGE_PATH,
            llm_model=LLM_MODEL,
            assistant_id=ASSISTANT_ID,
            short_term_capacity=7,  
            mid_term_heat_threshold=5,  
            retrieval_queue_capacity=7,
            long_term_knowledge_capacity=100
        )
        print("تم تهيئة MemoryOS بنجاح!\n")
    except Exception as e:
        print(f"خطأ: {e}")
        return

    # 2. إضافة بعض الذكريات الأساسية
    print("جاري إضافة بعض الذكريات...")
    
    memo.add_memory(
        user_input="مرحباً! أنا توم، أعمل كعالم بيانات في سان فرانسيسكو.",
        agent_response="مرحباً توم! سعيد بلقائك. علم البيانات مجال مثير بالفعل. ما نوع البيانات التي تعمل بها؟"
    )
     
    test_query = "ماذا تتذكر عن عملي؟"
    print(f"المستخدم: {test_query}")
    
    response = memo.get_response(
        query=test_query,
    )
    
    print(f"المساعد: {response}")

if __name__ == "__main__":
    simple_demo()
```
## MemoryOS-MCP بدء الاستخدام
### 🔧 الأدوات الأساسية

#### 1. `add_memory`
يحفظ محتوى الحوار بين المستخدم ومساعد الذكاء الاصطناعي في نظام الذاكرة بهدف بناء سجل حوار دائم وسجل سياقي.

#### 2. `retrieve_memory`
يسترجع الحوارات التاريخية ذات الصلة وتفضيلات المستخدم ومعلومات المعرفة من نظام الذاكرة بناءً على استعلام، مما يساعد مساعد الذكاء الاصطناعي على فهم احتياجات المستخدم وخلفيته.

#### 3. `get_user_profile`
يحصل على ملف المستخدم الناتج من تحليل الحوارات السابقة، بما في ذلك سمات شخصية المستخدم واهتماماته وخلفيته المعرفية ذات الصلة.


### 1. تثبيت التبعيات
```bash
cd memoryos-mcp
pip install -r requirements.txt
```
### 2. التكوين

عدل ملف `config.json`：
```json
{
  "user_id": "معرّف المستخدم الخاص بك",
  "openai_api_key": "مفتاح OpenAI API الخاص بك",
  "openai_base_url": "https://api.openai.com/v1",
  "data_storage_path": "./memoryos_data",
  "assistant_id": "assistant_id",
  "llm_model": "gpt-4o-mini"
}
```
### 3. بدء الخادم
```bash
python server_new.py --config config.json
```
### 4. اختبار
```bash
python test_comprehensive.py
```
### 5. تكوينها على Cline وعملاء آخرين
انسخ ملف mcp.json وتأكد من أن مسار الملف صحيح.
```bash
command": "/root/miniconda3/envs/memos/bin/python"
#يجب تغيير هذا إلى مفسر بايثون في بيئة العمل الافتراضية الخاصة بك
```
## المساهمة

المساهمات مرحب بها! لا تتردد في إرسال مشكلات أو طلبات دمج.

## الاستشهاد
إذا كنت ترغب في قراءة المزيد من التفاصيل، يرجى النقر هنا: [اقرأ الورقة الكاملة](https://arxiv.org/abs/2506.06326)

إذا وجدت هذا المشروع مفيداً، يرجى الاستشهاد بورقتنا:

```bibtex
@misc{kang2025memoryosaiagent,
      title={Memory OS of AI Agent}, 
      author={Jiazheng Kang and Mingming Ji and Zhe Zhao and Ting Bai},
      year={2025},
      eprint={2506.06326},
```
## تواصل معنا
مجموعة ذكاء باي هي مجموعة بحثية تحت إشراف الأستاذة المشاركة باي تينغ في جامعة بكين للبريد والاتصالات، تكرّس جهودها لبناء عقول غنية بالعاطفة وذات ذاكرة فائقة للبشر السيليكونيين.<br>
للتعاون والاقتراحات: baiting@bupt.edu.cn<br>
نرحب بمتابعتكم لحساب باي جا Agent الرسمي على وي تشات والانضمام إلى مجموعة النقاش لمزيد من التواصل!  
<div style="display: flex; justify-content: center; gap: 20px;">
  <img src="https://github.com/user-attachments/assets/42651f49-f1f7-444d-9455-718e13ed75e9" alt="حساب باي جا Agent الرسمي" width="250"/>
  <img src="https://github.com/user-attachments/assets/6b15a873-9e9a-44ee-b0b3-64f488fbd5d8" alt="رمز الاستجابة السريعة لمجموعة وي تشات" width="300"/>
</div>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---