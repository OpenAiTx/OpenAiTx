# OCI AI Blueprints

**Stellen Sie KI-Workloads mit der OCI AI Blueprints-Plattform bereit, skalieren und überwachen Sie diese und reduzieren Sie Ihre GPU-Onboarding-Zeit von Wochen auf Minuten.**

OCI AI Blueprints ist eine schlanke No-Code-Lösung für die Bereitstellung und Verwaltung von Generative-AI-Workloads auf dem Kubernetes Engine (OKE). Durch vorgegebene Hardware-Empfehlungen, vorinstallierte Software-Stacks und sofort einsatzbereite Observability-Tools hilft OCI AI Blueprints Ihnen dabei, Ihre KI-Anwendungen schnell und effizient auszuführen – ohne sich mit der Komplexität von Infrastrukturentscheidungen, Softwarekompatibilität und MLOps Best Practices auseinandersetzen zu müssen.

[![OCI AI Blueprints installieren](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Inhaltsverzeichnis

**Erste Schritte**

- [AI Blueprints installieren](./GETTING_STARTED_README.md)
- [Zugriff auf AI Blueprints Portal und API](docs/usage_guide.md)

**Über OCI AI Blueprints**

- [Was ist OCI AI Blueprints?](docs/about.md)
- [Warum OCI AI Blueprints verwenden?](docs/about.md)
- [Funktionen](docs/about.md)
- [Liste der Blueprints](#blueprints)
- [FAQ](docs/about.md)
- [Support & Kontakt](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API-Referenz**

- [API-Referenzdokumentation](docs/api_documentation.md)

**Weitere Ressourcen**

- [Eigene Blueprints veröffentlichen](./docs/custom_blueprints)
- [Updates installieren](docs/installing_new_updates.md)
- [IAM-Richtlinien](docs/iam_policies.md)
- [Repository-Inhalte](docs/about.md)
- [Bekannte Probleme](docs/known_issues.md)

## Erste Schritte

Installieren Sie OCI AI Blueprints, indem Sie auf die folgende Schaltfläche klicken:

[![OCI AI Blueprints installieren](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Blueprints gehen über einfache Terraform-Templates hinaus. Jeder Blueprint:

- Bietet validierte Hardware-Empfehlungen (z. B. optimale Shapes, CPU/GPU-Konfigurationen),
- Enthält durchgängige Anwendungs-Stacks, die für verschiedene GenAI-Anwendungsfälle angepasst sind, und
- Wird mit vorkonfiguriertem Monitoring, Logging und Auto-Scaling geliefert.

Nachdem Sie OCI AI Blueprints auf einem OKE-Cluster in Ihrer Tenancy installiert haben, können Sie diese vorgefertigten Blueprints bereitstellen:

| Blueprint                                                                                     | Beschreibung                                                                                                                                |
| --------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inferenz mit vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md)   | Llama 2/3/3.1 7B/8B Modelle mit NVIDIA GPU-Shapes und der vLLM-Inferenz-Engine mit Auto-Scaling bereitstellen.                              |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | MLCommons quantisiertes Llama-2 70B LoRA Finetuning auf A100 für Performance-Benchmarking ausführen.                                        |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | LoRA-Fine-Tuning von eigenen oder HuggingFace-Modellen mit beliebigen Datensätzen. Enthält flexibles Hyperparameter-Tuning.                |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | Umfassende Bewertung der GPU-Leistung, um optimale Hardware-Bereitschaft vor Beginn rechenintensiver Workloads sicherzustellen.             |
| [**CPU-Inferenz**](./docs/sample_blueprints/cpu-inference)                                    | Nutzen Sie Ollama, um CPU-basierte Inferenz mit Modellen wie Mistral, Gemma und weiteren zu testen.                                         |
| [**Multi-Node-Inferenz mit RDMA und vLLM**](./docs/sample_blueprints/multi-node-inference/)   | Llama-405B große LLMs über mehrere Nodes mit RDMA unter Verwendung von H100-Nodes mit vLLM und LeaderWorkerSet bereitstellen.               |
| [**Autoscaling Inferenz mit vLLM**](./docs/sample_blueprints/auto_scaling/)                   | LLMs mit Auto-Scaling über KEDA bereitstellen, das auf Basis von Anwendungsmetriken wie Inferenz-Latenz auf mehrere GPUs und Nodes skaliert.|
| [**LLM-Inferenz mit MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                  | LLMs auf einem Teil einer GPU mit Nvidias Multi-Instance-GPUs bereitstellen und mit vLLM bedienen.                                          |
| [**Job-Queuing**](./docs/sample_blueprints/teams)                                             | Nutzen Sie Job-Queuing und setzen Sie Ressourcenkontingente und Fair-Share-Regeln zwischen Teams durch.                                     |

## Support & Kontakt

Wenn Sie Fragen, Probleme oder Feedback haben, wenden Sie sich an [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) oder [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---