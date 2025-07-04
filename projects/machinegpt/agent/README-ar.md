![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

إطار عمل عالي السرعة ومستقل لوكلاء الذكاء الاصطناعي مكتوب بلغة بايثون، يستفيد من حزمة OpenAI Python SDK لفهم الأوامر بلغة طبيعية، وتوليد وتنفيذ الشيفرة بشكل ديناميكي، وإدارة بيئة التشغيل الخاصة به بسهولة تامة. يتميز بتثبيت التبعيات تلقائيًا، وتكوين بيئة آمنة، وتسجيل هيكلي للسجلات، وواجهة إضافات بسيطة لدمج أدوات بايثون قوية—وكل ذلك تحت رخصة أباتشي 2.0 المرنة.

## ⭐ سجل النجوم

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>

## 🔧 إعداد البيئة

### البيئة الافتراضية لبايثون
قبل إعداد المشروع، يُوصى بإنشاء بيئة افتراضية. اتبع الخطوات التالية:

تعرف على البيئات الافتراضية: [دليل تغليف بايثون](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

إنشاء وتفعيل البيئة الافتراضية:

**ويندوز:**

```
py -m venv .venv
.venv\Scripts\activate
```

**ماك/لينكس:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### إعداد المشروع
يتطلب هذا المشروع مفتاح API من OpenAI ليعمل. لتوفيره، أنشئ ملف .env في الدليل الجذري بالمحتوى التالي:
```
OPENAI_API_KEY=
```
بدلاً من ذلك، يمكنك نسخ ملف .env.example وتحديث المفتاح:
```
cp .env.example .env
```

## 🧠 البدء
لتشغيل الوكيل، ببساطة نفذ:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ المساهمات

المساهمات، الاقتراحات، تقارير وتصحيحات الأخطاء مرحب بها!

للمميزات أو المكونات أو الامتدادات الجديدة، يرجى فتح قضية ومناقشتها قبل إرسال طلب دمج.

## 💖 هذا المشروع قائم في وضعه الحالي بفضل جميع من ساهم فيه
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---