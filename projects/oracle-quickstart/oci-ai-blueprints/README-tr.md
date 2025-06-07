# OCI AI Blueprints

**OCI AI Blueprints platformu ile AI iş yüklerini dağıtın, ölçeklendirin ve izleyin; GPU ile entegrasyon sürenizi haftalardan dakikalara indirin.**

OCI AI Blueprints, Kubernetes Engine (OKE) üzerinde Generative AI iş yüklerini dağıtmak ve yönetmek için kodsuz, sadeleştirilmiş bir çözümdür. Yönlendirilmiş donanım önerileri, önceden paketlenmiş yazılım yığınları ve kullanıma hazır gözlemlenebilirlik araçları sunarak, OCI AI Blueprints yapay zeka uygulamalarınızı hızlı ve verimli bir şekilde çalıştırmanıza yardımcı olur—altyapı kararları, yazılım uyumluluğu ve MLOps en iyi uygulamalarıyla uğraşmadan.

[![OCI AI Blueprints'i Kurun](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## İçindekiler

**Başlarken**

- [AI Blueprints'i Kurun](./GETTING_STARTED_README.md)
- [AI Blueprints Portalı ve API'ye Erişim](docs/usage_guide.md)

**OCI AI Blueprints Hakkında**

- [OCI AI Blueprints nedir?](docs/about.md)
- [Neden OCI AI Blueprints kullanılmalı?](docs/about.md)
- [Özellikler](docs/about.md)
- [Blueprint Listesi](#blueprints)
- [SSS](docs/about.md)
- [Destek & İletişim](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API Referansı**

- [API Referans Dokümantasyonu](docs/api_documentation.md)

**Ek Kaynaklar**

- [Özel Blueprint Yayınlama](./docs/custom_blueprints)
- [Güncellemeleri Yükleme](docs/installing_new_updates.md)
- [IAM Politikaları](docs/iam_policies.md)
- [Depo İçeriği](docs/about.md)
- [Bilinen Sorunlar](docs/known_issues.md)

## Başlarken

OCI AI Blueprints'i aşağıdaki butona tıklayarak yükleyin:

[![OCI AI Blueprints'i Kurun](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprintler

Blueprintler, temel Terraform şablonlarının ötesine geçer. Her blueprint:

- Doğrulanmış donanım önerileri sunar (örn. en uygun şekiller, CPU/GPU yapılandırmaları),
- Farklı GenAI kullanım senaryoları için özelleştirilmiş uçtan uca uygulama yığınları içerir ve
- İzleme, günlükleme ve otomatik ölçeklendirme kutudan çıktığı gibi yapılandırılmıştır.

OCI AI Blueprints'i kiralamanızdaki bir OKE kümesine yükledikten sonra, bu önceden oluşturulmuş blueprintleri dağıtabilirsiniz:

| Blueprint                                                                                     | Açıklama                                                                                                                                |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md) | NVIDIA GPU şekilleri ve vLLM çıkarım motoru ile otomatik ölçeklendirme kullanarak Llama 2/3/3.1 7B/8B modellerini dağıtın.              |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | Performans karşılaştırması için A100 üzerinde MLCommons kuantize Llama-2 70B LoRA ince ayarını çalıştırın.                              |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | Herhangi bir veri setiyle özel veya HuggingFace modellerinde LoRA ince ayarı. Esnek hiperparametre ayarı dahildir.                      |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | Yoğun hesaplama iş yüklerine başlamadan önce donanımın hazır olup olmadığını sağlamak için kapsamlı GPU performans değerlendirmesi.      |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | Mistral, Gemma ve daha fazlası gibi modellerle CPU tabanlı çıkarımı test etmek için Ollama'yı kullanın.                                 |
| [**Multi-node Inference with RDMA and vLLM**](./docs/sample_blueprints/multi-node-inference/) | H100 düğümlerinde vLLM ve LeaderWorkerSet ile birden fazla düğümde RDMA kullanarak Llama-405B boyutlu LLM'leri dağıtın.                 |
| [**Autoscaling Inference with vLLM**](./docs/sample_blueprints/auto_scaling/)                 | KEDA ile otomatik ölçeklendirme sayesinde, çıkarım gecikmesi gibi uygulama metriklerini kullanarak çoklu GPU ve düğümlere ölçekleyin.   |
| [**LLM Inference with MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                | Nvidia’nın çoklu örnek GPU'ları ile bir GPU'nun bir kısmına LLM dağıtın ve bunları vLLM ile sunun.                                      |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                             | İş kuyruğundan yararlanın ve ekipler arasında kaynak kotaları ile adil paylaşımı zorunlu kılın.                                         |

## Destek & İletişim

Herhangi bir sorunuz, sorununuz veya geri bildiriminiz varsa, [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) veya [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com) ile iletişime geçebilirsiniz.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---