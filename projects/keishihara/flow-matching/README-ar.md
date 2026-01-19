
<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# مطابقة التدفق في بايتورتش

يحتوي هذا المستودع على تنفيذ بسيط في بايتورتش لورقة البحث [مطابقة التدفق للنمذجة التوليدية](https://arxiv.org/abs/2210.02747).

## مثال مطابقة تدفق ثنائي الأبعاد

توضح الصورة المتحركة أدناه تحويل توزيع غاوسي أحادي إلى توزيع لوحة الشطرنج، مع تصوير حقل المتجهات.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

وهنا مثال آخر لمجموعة بيانات الأقمار (moons).

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## البدء

قم باستنساخ المستودع وإعداد بيئة بايثون.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

تأكد من تثبيت بايثون 3.12+ لديك.
ثبّت `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

ثم قم بإعداد البيئة:

```bash
uv sync
```

## المطابقة الشرطية للتدفق [Lipman+ 2023]

هذا هو التنفيذ الأصلي لورقة CFM [1]. تم تكييف بعض مكونات الشيفرة من [2] و [3].

### مجموعات بيانات الألعاب ثنائية الأبعاد

يمكنك تدريب نماذج CFM على مجموعات بيانات تركيبية ثنائية الأبعاد مثل `checkerboard` و `moons`. حدد اسم مجموعة البيانات باستخدام خيار `--dataset`. معلمات التدريب محددة مسبقًا في البرنامج النصي، وتخزين تصورات نتائج التدريب في مجلد `outputs/`. نقاط التحقق للنموذج غير مضمنة حيث يمكن إعادة إنتاجها بسهولة باستخدام الإعدادات الافتراضية.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```
يمكن الآن العثور على حقول المتجهات والعينات المُولَّدة، مثل تلك المعروضة كصور GIF في أعلى ملف README هذا، في دليل `outputs/cfm/`.

### مجموعات بيانات الصور

يمكنك أيضًا تدريب نماذج CFM المشروطة بالفئة على مجموعات بيانات تصنيف الصور الشائعة. سيتم تخزين كل من العينات المُولَّدة ونقاط تحقق النموذج في دليل `outputs/cfm`. للحصول على قائمة مفصلة بمعلمات التدريب، شغّل الأمر `uv run scripts/train_flow_matching_on_image.py --help`.

لتدريب نموذج CFM مشروط بالفئة على مجموعة بيانات MNIST، شغّل الأمر:


```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

بعد الانتهاء من التدريب، يمكنك الآن إنشاء عينات باستخدام:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
الآن، يجب أن تكون قادرًا على رؤية العينات المولدة في دليل `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## التدفق المصحح [Liu+ 2023]

هذا هو تنفيذ نموذج Reflow (وبشكل محدد 2-Rectified Flow) من ورقة التدفق المصحح [2].

### بيانات اصطناعية ثنائية الأبعاد

قمنا بتنفيذ Reflow على مجموعات بيانات اصطناعية ثنائية الأبعاد، تمامًا كما في CFM. لتدريب reflow، يجب عليك تحديد نقاط تحقق CFM المدربة مسبقًا لأن reflow هو نموذج تقطير.

على سبيل المثال، لتدريب مجموعة بيانات `checkerboard` باستخدام نقطة تحقق CFM مدربة مسبقًا:


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

يتم حفظ نتائج التدريب، بما في ذلك تصورات الحقل الاتجاهي والعينات المُنشأة، ضمن مجلد `outputs/reflow/`.

### مقارنة عملية أخذ العينات بين CFM و Reflow

لمقارنة CFM و Reflow على مجموعات البيانات ثنائية الأبعاد، قم بتشغيل:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
يمكن العثور على ملفات GIF الناتجة ضمن مجلد `outputs/comparisons/`. فيما يلي مثال لمقارنة بين الطريقتين في مجموعة بيانات `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## المراجع

- [1] ليبمان، يارون، وآخرون. "مطابقة التدفق للنمذجة التوليدية." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] ليو، شينغتشاو، وآخرون. "التدفق المستقيم والسريع: التعلم لتوليد ونقل البيانات باستخدام التدفق المصحح." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---