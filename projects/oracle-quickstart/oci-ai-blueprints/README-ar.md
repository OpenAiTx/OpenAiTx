# مخططات الذكاء الاصطناعي في OCI

**قم بنشر وتوسيع ومراقبة أحمال عمل الذكاء الاصطناعي باستخدام منصة مخططات الذكاء الاصطناعي في OCI، وقلل وقت بدء تشغيل وحدات معالجة الرسومات (GPU) من أسابيع إلى دقائق.**

تعد مخططات الذكاء الاصطناعي في OCI حلاً مبسطًا وبدون كود لنشر وإدارة أحمال عمل الذكاء الاصطناعي التوليدي على محرك Kubernetes (OKE). من خلال توفير توصيات الأجهزة المثلى، وحزم البرمجيات الجاهزة، وأدوات المراقبة والتتبع الجاهزة، تساعدك مخططات الذكاء الاصطناعي في OCI على تشغيل تطبيقات الذكاء الاصطناعي بسرعة وكفاءة—دون الحاجة إلى التعامل مع تعقيدات قرارات البنية التحتية، وتوافق البرمجيات، وأفضل ممارسات عمليات تعلم الآلة (MLOps).

[![تثبيت مخططات الذكاء الاصطناعي في OCI](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## جدول المحتويات

**البدء**

- [تثبيت مخططات الذكاء الاصطناعي](./GETTING_STARTED_README.md)
- [الوصول إلى بوابة وواجهة برمجة تطبيقات مخططات الذكاء الاصطناعي](docs/usage_guide.md)

**حول مخططات الذكاء الاصطناعي في OCI**

- [ما هي مخططات الذكاء الاصطناعي في OCI؟](docs/about.md)
- [لماذا استخدام مخططات الذكاء الاصطناعي في OCI؟](docs/about.md)
- [الميزات](docs/about.md)
- [قائمة المخططات](#blueprints)
- [الأسئلة الشائعة](docs/about.md)
- [الدعم والتواصل](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**مرجع واجهة برمجة التطبيقات (API)**

- [توثيق مرجع واجهة برمجة التطبيقات](docs/api_documentation.md)

**موارد إضافية**

- [نشر مخططات مخصصة](./docs/custom_blueprints)
- [تثبيت التحديثات](docs/installing_new_updates.md)
- [سياسات IAM](docs/iam_policies.md)
- [محتويات المستودع](docs/about.md)
- [المشكلات المعروفة](docs/known_issues.md)

## البدء

قم بتثبيت مخططات الذكاء الاصطناعي في OCI بالنقر على الزر أدناه:

[![تثبيت مخططات الذكاء الاصطناعي في OCI](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## المخططات

تتجاوز المخططات مجرد قوالب Terraform الأساسية. كل مخطط:

- يقدم اقتراحات أجهزة تم التحقق منها (مثل الأشكال المثلى، وتكوينات CPU/GPU)،
- يتضمن حزم تطبيقات متكاملة مخصصة لحالات استخدام الذكاء الاصطناعي التوليدي المختلفة،
- ويأتي مع مراقبة وتسجيل وتوسعة تلقائية معدة مسبقاً.

بعد تثبيت مخططات الذكاء الاصطناعي في OCI على عنقود OKE في حيازتك، يمكنك نشر هذه المخططات الجاهزة:

| المخطط                                                                                                   | الوصف                                                                                                                                |
| -------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| [**استدلال LLM & VLM مع vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md)               | نشر نماذج Llama 2/3/3.1 7B/8B باستخدام أشكال GPU من NVIDIA ومحرك استدلال vLLM مع التوسعة التلقائية.                               |
| [**اختبار الأداء للتدريب الدقيق**](./docs/sample_blueprints/lora-benchmarking)                          | تشغيل تدريب LoRA على نموذج Llama-2 70B بكمية منخفضة باستخدام MLCommons على A100 لاختبار الأداء.                                     |
| [**التدريب الدقيق LoRA**](./docs/sample_blueprints/lora-fine-tuning)                                    | تدريب دقيق باستخدام LoRA للنماذج المخصصة أو نماذج HuggingFace باستخدام أي مجموعة بيانات. يتضمن ضبط مرن للمعاملات.                 |
| [**فحص الصحة**](./docs/sample_blueprints/gpu-health-check)                                              | تقييم شامل لأداء GPU لضمان جاهزية الأجهزة المثلى قبل البدء في أي عبء عمل حسابي مكثف.                                                |
| [**الاستدلال باستخدام CPU**](./docs/sample_blueprints/cpu-inference)                                    | استخدام Ollama لاختبار الاستدلال المعتمد على CPU مع نماذج مثل Mistral وGemma وغيرها.                                                 |
| [**الاستدلال متعدد العقد مع RDMA وvLLM**](./docs/sample_blueprints/multi-node-inference/)                | نشر نماذج Llama-405B كبيرة الحجم عبر عدة عقد باستخدام RDMA على عقد H100 مع vLLM وLeaderWorkerSet.                                    |
| [**الاستدلال مع التوسعة التلقائية باستخدام vLLM**](./docs/sample_blueprints/auto_scaling/)              | خدمة نماذج LLM مع التوسعة التلقائية باستخدام KEDA، الذي يتوسع إلى عدة وحدات GPU وعقد باستخدام مقاييس التطبيق مثل زمن الاستدلال.      |
| [**استدلال LLM باستخدام MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                        | نشر نماذج LLM على جزء من وحدة GPU باستخدام وحدات GPU متعددة الحالات من Nvidia وخدمتها عبر vLLM.                                     |
| [**جدولة المهام**](./docs/sample_blueprints/teams)                                                      | الاستفادة من جدولة المهام وفرض حصص الموارد والتوزيع العادل بين الفرق.                                                                 |

## الدعم والتواصل

إذا كان لديك أي أسئلة أو مشكلات أو ملاحظات، تواصل مع [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) أو [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---