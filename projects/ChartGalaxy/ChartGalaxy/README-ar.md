![شعار ChartGalaxy](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## مجموعة البيانات
> 📦 **[👉 للوصول إلى مجموعة بيانات ChartGalaxy الكاملة على Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

نظرًا لقيود التخزين، ندرج فقط مجموعة من الأمثلة التمثيلية.
يحتوي هذا المستودع على الكود المرتبط بمقالة "ChartGalaxy: مجموعة بيانات لفهم وتوليد الرسوم البيانية المعلوماتية".

## 🔥 الأخبار
**2025.5**:  🎉🎉 لقد أصدرنا النسخة الأولى من مجموعتنا للبيانات، والتي تتضمن 1,151,087 رسمًا بيانيًا معلوماتيًا اصطناعيًا و104,519 رسمًا بيانيًا حقيقيًا، تغطي 75 نوعًا من الرسوم البيانية و330 تنويعًا.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![صورة أمثلة](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 News -->

## المقدمة

### حول

ChartGalaxy هي مجموعة بيانات ضخمة تضم رسومًا بيانية معلوماتية اصطناعية وحقيقية مع جداول بيانات، تدعم التطبيقات في فهم الرسوم البيانية المعلوماتية، وتوليد الأكواد، وتوليد الرسوم البيانية. تعالج مجموعة البيانات هذه التحدي المتمثل في أن مجموعات البيانات الحالية تقتصر في الغالب على الرسوم البيانية البسيطة، ولا تعكس النطاق الواسع لأنماط التصميم والتخطيطات التي تُعد من الخصائص الرئيسية للرسوم البيانية المعلوماتية.

### الإحصائيات

- **الحجم**: 1,255,606 رسمًا بيانيًا معلوماتيًا (1,151,087 اصطناعي + 104,519 حقيقي)
- **المحتوى**: كل رسم بياني معلوماتي مقترن بجدول البيانات المستخدم في إنشائه
- **أنواع الرسوم البيانية**: 75 نوعًا من الرسوم البيانية مع 330 تنويعًا
- **قوالب التخطيط**: 68 قالب تخطيط

### جمع وإنشاء البيانات

تم بناء ChartGalaxy من خلال:

1. **جمع الرسوم البيانية المعلوماتية الحقيقية**: تم جمع الرسوم البيانية من 19 موقعًا غنيًا بالرسوم البيانية وذات سمعة عالية، مثل Pinterest وVisual Capitalist وStatista وInformation is Beautiful.

2. **إنشاء رسوم بيانية معلوماتية اصطناعية**: باتباع عملية هيكلة استقرائية تشمل:
   - تحديد 75 نوعًا من الرسوم البيانية (مثل الرسوم العمودية) و330 تنويعًا يعكس أنماط العناصر البصرية المختلفة
   - استخراج 68 قالب تخطيط يحدد العلاقات المكانية بين العناصر
   - توليد الرسوم البيانية الاصطناعية برمجيًا بناءً على هذه الأنماط

## 🎯 التطبيقات

يتم توضيح فائدة ChartGalaxy من خلال ثلاثة تطبيقات تمثيلية:

### 1. 🧠 فهم الرسوم البيانية المعلوماتية

الضبط الدقيق على ChartGalaxy يحسن أداء النماذج الأساسية في فهم الرسوم البيانية المعلوماتية.

### 2. 💻 توليد أكواد الرسوم البيانية المعلوماتية

معيار لتقييم توليد أكواد LVLMs للرسوم البيانية المعلوماتية. يقيم المعيار مدى التشابه بين الرسوم البيانية التي تم توليدها بواسطة كود D3.js المولد وتلك الحقيقية على مستويين من الدقة: المستوى العالي (تشابه بصري عام) والمستوى المنخفض (متوسط التشابه عبر عناصر SVG الدقيقة).

#### نظرة عامة

يقيم المعيار توليد أكواد الرسوم البيانية على مستويين:
- **المستوى المنخفض**: تشابه بين العناصر الفردية في SVG المولد والمرجعي
- **المستوى العالي**: تقييم شامل لجودة الشكل البصري والوظائف

#### التثبيت

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### الاستخدام

1. قم بضبط الإعدادات في `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # قم بإلغاء التعليق عن النماذج التي ترغب في تقييمها
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. شغّل المعيار:
   ```bash
   python main.py
   ```

#### هيكلية البيانات

يجب أن يحتوي كل مجلد رسم بياني في `data_root_dir` على:
- `chart.svg`: الرسم البياني الأصلي بصيغة SVG

سيقوم النظام بتوليد:
- `convert_chart.html`: عرض HTML للرسم البياني المرجعي
- `convert_chart.png`: لقطة شاشة PNG للرسم البياني المرجعي
- `convert_chart.json`: بنية العناصر للرسم البياني المرجعي
- مخرجات خاصة بكل نموذج في مجلدات فرعية

#### النتائج

يتم حفظ النتائج في مجلدات فرعية خاصة بكل نموذج مع:
- ملفات HTML/PNG المولدة
- مقاييس التقييم بصيغة JSON
- سجلات مفصلة في `log_dir`
  

### 3. 🖼️ توليد الرسوم البيانية المعلوماتية بناءً على المثال

طريقة تعتمد على الأمثلة لتحويل البيانات الجدولية التي يقدمها المستخدم إلى رسم بياني معلوماتي يتماشى مع التخطيط والنمط البصري لرسم بياني مثال. أظهرت الدراسات أن هذه الطريقة تتفوق على GPT-Image-1 من حيث الدقة، والجماليات، والإبداع.


## التواصل
- chartgalaxy@163.com

## روابط المقالات

### 📌 المقالة الرئيسية (هذا المستودع)

- **[ChartGalaxy: مجموعة بيانات لفهم وتوليد الرسوم البيانية المعلوماتية](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### مقالات ذات صلة

- **[OrionBench: معيار لاكتشاف الرسوم البيانية والكائنات القابلة للتعرف البشري في الرسوم المعلوماتية](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: معيار للإجابة على الأسئلة متعددة الوسائط في الرسوم البيانية المعلوماتية](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 الاستشهاد
إذا استخدمت ChartGalaxy في بحثك، يرجى الاستشهاد بها:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---