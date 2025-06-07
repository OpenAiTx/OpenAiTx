# OCI AI Blueprints

**Wdrażaj, skaluj i monitoruj obciążenia AI dzięki platformie OCI AI Blueprints, skracając czas wdrożenia GPU z tygodni do minut.**

OCI AI Blueprints to uproszczone, bezkodowe rozwiązanie do wdrażania i zarządzania obciążeniami Generative AI na Kubernetes Engine (OKE). Dzięki dostarczaniu sprawdzonych rekomendacji sprzętowych, gotowych stosów oprogramowania oraz narzędzi do obserwowalności dostępnych od razu po wdrożeniu, OCI AI Blueprints pozwala szybko i efektywnie uruchomić aplikacje AI — bez zmagań z zawiłościami decyzji infrastrukturalnych, kompatybilności oprogramowania czy najlepszych praktyk MLOps.

[![Zainstaluj OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Spis Treści

**Pierwsze kroki**

- [Instalacja AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [Dostęp do portalu i API AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**O OCI AI Blueprints**

- [Czym jest OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Dlaczego warto używać OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Funkcje](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Lista Blueprintów](#blueprints)
- [FAQ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Wsparcie i kontakt](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Dokumentacja API**

- [Dokumentacja referencyjna API](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**Dodatkowe zasoby**

- [Publikowanie własnych Blueprintów](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [Instalacja aktualizacji](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [Polityki IAM](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [Zawartość repozytorium](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Znane problemy](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## Pierwsze kroki

Zainstaluj OCI AI Blueprints, klikając poniższy przycisk:

[![Zainstaluj OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Blueprints

Blueprinty to coś więcej niż podstawowe szablony Terraform. Każdy blueprint:

- Oferuje zweryfikowane rekomendacje sprzętowe (np. optymalne kształty, konfiguracje CPU/GPU),
- Zawiera kompleksowe stosy aplikacyjne dostosowane do różnych zastosowań GenAI,
- Posiada wbudowane narzędzia monitorowania, logowania oraz autoskalowania.

Po zainstalowaniu OCI AI Blueprints na klastrze OKE w Twojej dzierżawie możesz wdrażać te gotowe blueprinty:

| Blueprint                                                                                          | Opis                                                                                                                                           |
| -------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | Wdrażaj modele Llama 2/3/3.1 7B/8B wykorzystując kształty GPU NVIDIA i silnik inferencyjny vLLM z autoskalowaniem.                            |
| [**Fine-Tuning Benchmarking**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking)                    | Uruchamiaj MLCommons quantized Llama-2 70B LoRA finetuning na A100 do benchmarkingu wydajności.                                                |
| [**LoRA Fine-Tuning**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning)                             | Fine-tuning LoRA na własnych lub modelach HuggingFace z dowolnym zbiorem danych. Zawiera elastyczne dostrajanie hiperparametrów.              |
| [**Health Check**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check)                                 | Kompleksowa ocena wydajności GPU, aby zapewnić gotowość sprzętu przed rozpoczęciem wymagających obliczeniowo zadań.                           |
| [**CPU Inference**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference)                                   | Wykorzystaj Ollama do testowania inferencji na CPU z modelami takimi jak Mistral, Gemma i innymi.                                             |
| [**Multi-node Inference with RDMA and vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/) | Wdrażaj modele Llama-405B na wielu węzłach z RDMA, wykorzystując węzły H100 z vLLM i LeaderWorkerSet.                                         |
| [**Autoscaling Inference with vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/)                 | Serwuj modele LLM z autoskalowaniem dzięki KEDA, skalując na wiele GPU i węzłów na podstawie metryk aplikacyjnych, np. opóźnienia inferencji. |
| [**LLM Inference with MIG**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/)                | Wdrażaj modele LLM na części GPU dzięki technologii Nvidia Multi-Instance GPU i obsługuj je przez vLLM.                                       |
| [**Job Queuing**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams)                                             | Skorzystaj z kolejkowania zadań oraz egzekwuj limity zasobów i sprawiedliwy podział pomiędzy zespołami.                                      |

## Wsparcie i kontakt

W przypadku pytań, problemów lub sugestii skontaktuj się z [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) lub [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---