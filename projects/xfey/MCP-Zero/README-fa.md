## MCP-Zero: کشف فعال ابزار برای عامل‌های خودران LLM

<div style="display: flex; align-items: center; gap: 10px; margin-bottom: 10px;">
  <!-- <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/robot.png" alt="MCP-Zero Robot" width="24" height="24"> -->
  <a href="https://arxiv.org/abs/2506.01056">
    <img src="https://img.shields.io/badge/Paper-arXiv-red">
  </a>
  <a href="https://arxiv.org/abs/2506.01056">
    https://arxiv.org/abs/2506.01056
  </a>
</div>


از توجه شما به MCP-Zero متشکریم! 🤗

ما اکنون کد مرتبط با مقاله را به صورت متن‌باز منتشر کرده‌ایم. ما به به‌روزرسانی کار خود، بررسی کاربرد آن در صنعت و گسترش این پروژه ادامه خواهیم داد.


<div align="center">
  <img src="https://raw.githubusercontent.com/xfey/MCP-Zero/master/assets/fig1.png" alt="MCP-Zero workflow">
  <p>استفاده از MCP-Zero برای ساخت زنجیره ابزارها به طور فعال برای "آماده کردن یک وعده غذایی عالی"</p>
</div>


### روش: MCP-Zero

```
MCP-zero/
├── experiment_apibank.py       # آزمایش‌ها: APIBank
├── experiment_mcptools.py      # آزمایش‌ها: mcp_tools (آزمون needle)
├── matcher.py                  # کد برای تطبیق شباهت
├── prompt_guide/               # پرامپت‌ها برای روش ما
├── reformatter.py              # قالب‌بندی‌کننده json برای توضیحات ابزار
├── sampler.py                  # انتخابگر برای انتخاب ابزار هدف
├── test_cases.jsonl            # مورد آزمایشی برای matcher
├── test_matcher.py             # تست واحد برای matcher
└── utils.py                    # ابزارها: grid_search
```

ما اکنون کد مربوط به مقاله را منتشر کرده‌ایم. کد موجود در مقاله قابلیت‌های بازیابی را پیاده‌سازی کرده و در آزمایش‌ها به نتایج ملموسی دست یافته است.

در کارهای آینده، ما متعهد به کاربرد MCP-zero در صنعت هستیم، بنابراین نیاز به مشارکت ماژول‌های دیگری نیز وجود دارد، مانند استقرار پویا سرورهای MCP، استقرار محیط برای آزمون GAIA و غیره. ما به بهبود کار خود ادامه خواهیم داد و از توجه شما به این پروژه سپاسگزاریم. با دادن ستاره🌟 به من اطلاع دهید که به‌روز هستید :D



### مجموعه داده: MCP-tools

- **Google Drive**: [لینک دانلود](https://drive.google.com/file/d/1RjBGU-AGdHdhUABoeYSztbfQlD0hjUBn/view?usp=sharing)
- **لینک Huggingface**: به زودی
- **فایل را قرار دهید در**: `./MCP-tools/mcp_tools_with_embedding.json`


**معرفی**: مجموعه داده‌ای شامل تمام ابزارهای فیلتر شده (۳۰۸ سرور و ۲٬۷۹۷ ابزار در مجموع) از مخزن رسمی MCP.

**ساختار داده**:
```
{
  "server_name": string, // نام سرور MCP، استخراج‌شده یا استنتاج‌شده از README
  "server_summary": string, // خلاصه‌ای از هدف و قابلیت‌های سرور، بر اساس تمام بخش‌های مرتبط README
  "server_description": string, // توضیحات از متادیتا.
  "description_embedding": float[3072], // بردار embedding توضیحات سرور توسط text-embedding-3-large
  "summary_embedding": float[3072], // بردار embedding خلاصه سرور توسط text-embedding-3-large
  "tools": [
    {
      "name": string, // نام تابع/ابزار
      "description": string, // توضیح مختصر از عملکرد ابزار
      "description_embedding": float[3072], // بردار embedding توضیح ابزار توسط text-embedding-3-large
      "parameter": { // دیکشنری پارامترهای ورودی، در صورت تعریف صریح درج می‌شود
        "param1": "(type) description1",
        "param2": "(Optional, type) description2"
      }
    }
  ]
}
```

**ساخت مجموعه داده توسط خودتان**: اگر می‌خواهید مجموعه داده سفارشی برای سرورهای MCP بسازید، می‌توانید از کد موجود در پوشه `MCP-tools/build_data` پیروی کنید.

```
MCP-tools/
├── build_data
│   ├── get_server_summary.py       # کد استخراج داده ساختاریافته از فایل ReadMe سرور MCP
│   ├── run_vllm.sh                 # استقرار مدل Qwen2.5-72B-Instruct با VLLM
│   └── server_summary.prompt       # پرامپت استخراج مجموعه داده
└── download_data.md
```


### استناد

> استناد من را خوشحال می‌کند.
> 
>   --شکسپیر
>   ~~(فقط برای شوخی :D)~~

```bibtex
@article{fei2025mcp,
  title={MCP-Zero: Active Tool Discovery for Autonomous LLM Agents},
  author={Fei, Xiang and Zheng, Xiawu and Feng, Hao},
  journal={arXiv preprint arXiv:2506.01056},
``` 
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-06

---