# OCI AI Blueprints

**Implementeer, schaal en monitor AI-werkbelastingen met het OCI AI Blueprints-platform en verkort uw GPU-onboardingtijd van weken tot minuten.**

OCI AI Blueprints is een gestroomlijnde, no-code oplossing voor het implementeren en beheren van Generative AI-werkbelastingen op Kubernetes Engine (OKE). Door het bieden van gefundeerde hardware-aanbevelingen, vooraf verpakte software stacks en direct beschikbare observability-tools, helpt OCI AI Blueprints u om uw AI-toepassingen snel en efficiënt te laten draaien—zonder te hoeven worstelen met de complexiteit van infrastructuurbeslissingen, softwarecompatibiliteit en MLOps best practices.

[![Installeer OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Inhoudsopgave

**Aan de slag**

- [Installeer AI Blueprints](./GETTING_STARTED_README.md)
- [Toegang tot AI Blueprints Portal en API](docs/usage_guide.md)

**Over OCI AI Blueprints**

- [Wat is OCI AI Blueprints?](docs/about.md)
- [Waarom OCI AI Blueprints gebruiken?](docs/about.md)
- [Functies](docs/about.md)
- [Lijst van Blueprints](#blueprints)
- [FAQ](docs/about.md)
- [Support & Contact](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API Referentie**

- [API Referentie Documentatie](docs/api_documentation.md)

**Aanvullende bronnen**

- [Publiceer aangepaste Blueprints](./docs/custom_blueprints)
- [Updates installeren](docs/installing_new_updates.md)
- [IAM-beleidsregels](docs/iam_policies.md)
- [Inhoud van de repository](docs/about.md)
- [Bekende problemen](docs/known_issues.md)

## Aan de slag

Installeer OCI AI Blueprints door op onderstaande knop te klikken:

[![Installeer OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Blueprints gaan verder dan basis Terraform-sjablonen. Elke blueprint:

- Biedt gevalideerde hardware-aanbevelingen (bijv. optimale shapes, CPU/GPU-configuraties),
- Bevat end-to-end applicatiestacks op maat voor verschillende GenAI-gebruiksscenario’s, en
- Wordt geleverd met monitoring, logging en autoscaling die direct zijn geconfigureerd.

Na installatie van OCI AI Blueprints op een OKE-cluster in uw tenancy, kunt u deze vooraf gebouwde blueprints implementeren:

| Blueprint                                                                                     | Beschrijving                                                                                                                                           |
| --------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [**LLM & VLM Inference met vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md)  | Implementeer Llama 2/3/3.1 7B/8B modellen met NVIDIA GPU-shapes en de vLLM inference engine met autoscaling.                                           |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | Voer MLCommons gequantiseerde Llama-2 70B LoRA-finetuning uit op A100 voor prestatiebenchmarks.                                                        |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | LoRA-finetuning van aangepaste of HuggingFace-modellen met elke dataset. Inclusief flexibele hyperparametertuning.                                     |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | Uitgebreide evaluatie van GPU-prestaties om optimale hardwaregereedheid te waarborgen vóór het starten van intensieve rekentaken.                      |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | Gebruik Ollama om CPU-gebaseerde inference te testen met modellen zoals Mistral, Gemma en meer.                                                        |
| [**Multi-node Inference met RDMA en vLLM**](./docs/sample_blueprints/multi-node-inference/)   | Implementeer Llama-405B LLM’s over meerdere nodes met RDMA met H100-nodes, vLLM en LeaderWorkerSet.                                                    |
| [**Autoscaling Inference met vLLM**](./docs/sample_blueprints/auto_scaling/)                  | Bedien LLM’s met autoscaling via KEDA, dat schaalt naar meerdere GPU’s en nodes op basis van applicatiemetrics zoals inference-latency.               |
| [**LLM Inference met MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                 | Implementeer LLM’s op een deel van een GPU met Nvidia’s multi-instance GPU’s en bedien ze met vLLM.                                                    |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                             | Profiteer van job-queuing en handhaaf resource-quota’s en eerlijke verdeling tussen teams.                                                             |

## Support & Contact

Heeft u vragen, problemen of feedback? Neem contact op met [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) of [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---