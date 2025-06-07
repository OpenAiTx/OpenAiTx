# نقشه‌های راه هوش مصنوعی OCI

**با استفاده از پلتفرم نقشه‌های راه هوش مصنوعی OCI، بارهای کاری هوش مصنوعی را مستقر، مقیاس‌پذیر و پایش کنید و زمان راه‌اندازی GPU خود را از هفته‌ها به چند دقیقه کاهش دهید.**

نقشه‌های راه هوش مصنوعی OCI یک راهکار ساده و بدون کدنویسی برای استقرار و مدیریت بارهای کاری هوش مصنوعی مولد بر روی Kubernetes Engine (OKE) است. با ارائه توصیه‌های سخت‌افزاری از پیش تعیین‌شده، بسته‌های نرم‌افزاری آماده و ابزارهای نظارتی خارج از جعبه، نقشه‌های راه OCI به شما کمک می‌کند تا برنامه‌های هوش مصنوعی خود را به سرعت و با کارایی بالا راه‌اندازی کنید—بدون درگیری با پیچیدگی‌های تصمیم‌گیری زیرساخت، سازگاری نرم‌افزار و بهترین رویه‌های MLOps.

[![نصب نقشه‌های راه هوش مصنوعی OCI](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## فهرست مطالب

**شروع کار**

- [نصب نقشه‌های راه هوش مصنوعی](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [دسترسی به پورتال و API نقشه‌های راه هوش مصنوعی](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**درباره نقشه‌های راه هوش مصنوعی OCI**

- [نقشه‌های راه هوش مصنوعی OCI چیست؟](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [چرا از نقشه‌های راه هوش مصنوعی OCI استفاده کنیم؟](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [ویژگی‌ها](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [لیست نقشه‌های راه](#blueprints)
- [سؤالات متداول](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [پشتیبانی و تماس](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**مستندات مرجع API**

- [مستندات مرجع API](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**منابع تکمیلی**

- [انتشار نقشه‌های راه سفارشی](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [نصب به‌روزرسانی‌ها](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [سیاست‌های IAM](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [محتوای مخزن](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [مشکلات شناخته‌شده](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## شروع کار

برای نصب نقشه‌های راه هوش مصنوعی OCI روی دکمه زیر کلیک کنید:

[![نصب نقشه‌های راه هوش مصنوعی OCI](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## نقشه‌های راه

نقشه‌های راه فراتر از قالب‌های پایه تررافرم هستند. هر نقشه راه:

- پیشنهادات سخت‌افزاری تأییدشده (مانند شکل‌های بهینه، پیکربندی‌های CPU/GPU) ارائه می‌دهد،
- شامل پشته‌های نرم‌افزاری انتها به انتها متناسب با کاربردهای مختلف GenAI است و
- با نظارت، لاگ‌گیری و مقیاس‌پذیری خودکار از پیش پیکربندی شده ارائه می‌شود.

پس از نصب نقشه‌های راه هوش مصنوعی OCI روی یک خوشه OKE در اجاره خود، می‌توانید این نقشه‌های راه آماده را مستقر کنید:

| نقشه راه                                                                                                     | توضیحات                                                                                                                       |
| ------------------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------- |
| [**استنتاج LLM و VLM با vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | استقرار مدل‌های Llama 2/3/3.1 7B/8B با استفاده از GPUهای NVIDIA و موتور استنتاج vLLM با مقیاس‌پذیری خودکار.               |
| [**ارزیابی عملکرد Fine-Tuning**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking) | اجرای MLCommons quantized Llama-2 70B LoRA finetuning روی A100 برای بنچمارک عملکرد.                                          |
| [**Fine-Tuning با LoRA**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning) | Fine-tuning مدل‌های سفارشی یا HuggingFace با هر دیتاست. شامل تنظیم انعطاف‌پذیر هایپرپارامترها.                              |
| [**بررسی سلامت**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check) | ارزیابی جامع عملکرد GPU برای اطمینان از آمادگی سخت‌افزار قبل از شروع هر بار کاری محاسباتی سنگین.                            |
| [**استنتاج مبتنی بر CPU**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference) | استفاده از Ollama برای تست استنتاج مبتنی بر CPU با مدل‌هایی مانند Mistral، Gemma و غیره.                                    |
| [**استنتاج چندگره با RDMA و vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/) | استقرار مدل‌های Llama-405B در چندین گره با RDMA با استفاده از نودهای H100، vLLM و LeaderWorkerSet.                           |
| [**استنتاج با مقیاس‌پذیری خودکار و vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/) | سرو LLMها با مقیاس‌پذیری خودکار با KEDA، که بر اساس متریک‌های برنامه مانند تاخیر استنتاج به چند GPU و گره مقیاس می‌دهد.     |
| [**استنتاج LLM با MIG**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/) | استقرار LLMها بر روی بخشی از GPU با استفاده از multi-instance GPUهای Nvidia و سرو آنها با vLLM.                             |
| [**صف‌بندی شغل**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams) | بهره‌گیری از صف‌بندی شغل و اعمال سهمیه منابع و تقسیم منصفانه بین تیم‌ها.                                                    |

## پشتیبانی و تماس

در صورت داشتن هرگونه سؤال، مشکل یا بازخورد، با [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) یا [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com) تماس بگیرید.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---