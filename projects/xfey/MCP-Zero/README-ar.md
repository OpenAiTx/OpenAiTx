## MCP-Zero: الاكتشاف النشط للأدوات لوكلاء LLM المستقلين

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


شكرًا لاهتمامكم بمشروع MCP-Zero! 🤗

لقد قمنا الآن بإتاحة الكود المصدري المستخدم في الورقة البحثية. سنستمر في تحديث عملنا، واستكشاف تطبيقه في الصناعة، وسنواصل توسيع هذا المشروع.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p>استخدام MCP-Zero لبناء سلاسل الأدوات بشكل استباقي لمهمة "إعداد وجبة رائعة"</p>
</div>


### المنهجية: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # تجارب: APIBank
├── experiment_mcptools.py      # تجارب: mcp_tools (اختبار needle)
├── matcher.py                  # كود لمطابقة التشابه
├── prompt_guide/               # الحوافز لطريقتنا
├── reformatter.py              # منسق json لوصف الأداة
├── sampler.py                  # مُعين لاختيار الأداة المستهدفة
├── test_cases.jsonl            # حالة اختبار للمطابقة
├── test_matcher.py             # اختبار وحدات للمطابقة
└── utils.py                    # أدوات مساعدة: grid_search
```

لقد قمنا الآن بنشر الكود الخاص بالورقة البحثية. الكود في الورقة ينفذ قدرات الاسترجاع ويحقق نتائج ملموسة في التجارب.

في أعمالنا المستقبلية، نحن ملتزمون بتطبيق MCP-zero في الصناعة، لذلك لا بد من إشراك وحدات أخرى، مثل النشر الديناميكي لخوادم MCP، ونشر بيئة اختبار GAIA، إلخ. سنواصل تحسين عملنا، وشكرًا لكم جميعًا على اهتمامكم بهذا العمل. لا تنسَ وضع نجمة🌟 إذا كنت تتابع التحديثات :D



### مجموعة البيانات: MCP-tools

- **Google Drive**: [رابط التحميل](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **رابط Huggingface**: قريبًا
- **ضع الملف في**: `./MCP-tools/mcp_tools_with_embedding.json`


**مقدمة**: مجموعة بيانات تحتوي على جميع الأدوات المفلترة (308 خادم و2797 أداة في المجموع) من المستودع الرسمي لـ MCP.

**هيكل البيانات**:
```
{
  "server_name": string, // اسم خادم MCP، مستخرج أو مستنتج من ملف README
  "server_summary": string, // ملخص لغرض الخادم وقدراته، بناءً على جميع الأجزاء ذات الصلة من README.
  "server_description": string, // الوصف من بيانات التعريف.
  "description_embedding": float[3072], // تضمين وصف الخادم من text-embedding-3-large
  "summary_embedding": float[3072], // تضمين ملخص الخادم من text-embedding-3-large
  "tools": [
    {
      "name": string, // اسم الوظيفة/الأداة
      "description": string, // وصف موجز لما تفعله الأداة
      "description_embedding": float[3072], // تضمين وصف الأداة من text-embedding-3-large
      "parameter": { // قاموس بالمعاملات المدخلة، يُدرج إذا تم تعريفه بشكل صريح
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**بناء مجموعة بياناتك الخاصة**: إذا أردت إنشاء مجموعة بيانات مخصصة لخوادم MCP، يمكنك اتباع الكود الموجود ضمن مجلد `MCP-tools/build_data`.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # كود لاستخلاص البيانات الهيكلية من ملف ReadMe الخاص بخادم MCP
│   ├── run_vllm.sh                 # نشر نموذج Qwen2.5-72B-Instruct باستخدام VLLM
│   └── server_summary.prompt       # الحافز لاستخلاص مجموعة البيانات
└── download_data.md
```


### الاستشهاد

> الاستشهاد يسعدني.
> 
>   --شكسبير
>   ~~(فقط من باب الدعابة :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
```
  السنة={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---