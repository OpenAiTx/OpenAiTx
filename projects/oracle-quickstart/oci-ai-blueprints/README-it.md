# OCI AI Blueprints

**Distribuisci, scala e monitora carichi di lavoro AI con la piattaforma OCI AI Blueprints, riducendo il tempo di onboarding delle GPU da settimane a minuti.**

OCI AI Blueprints è una soluzione semplificata e senza codice per il deployment e la gestione di carichi di lavoro Generative AI su Kubernetes Engine (OKE). Fornendo raccomandazioni hardware mirate, stack software preconfezionati e strumenti di osservabilità pronti all’uso, OCI AI Blueprints ti aiuta ad avviare rapidamente ed efficientemente le tue applicazioni AI—senza doverti confrontare con le complessità delle decisioni infrastrutturali, compatibilità software e best practice MLOps.

[![Installa OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Indice

**Per iniziare**

- [Installa AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [Accedi al Portale e API di AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**Informazioni su OCI AI Blueprints**

- [Cos’è OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Perché usare OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Funzionalità](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Elenco dei Blueprint](#blueprints)
- [FAQ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Supporto e Contatti](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Riferimento API**

- [Documentazione di riferimento API](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**Risorse aggiuntive**

- [Pubblica Blueprint personalizzati](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [Installazione degli aggiornamenti](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [Policy IAM](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [Contenuti del repository](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Problemi noti](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## Per iniziare

Installa OCI AI Blueprints cliccando sul pulsante qui sotto:

[![Installa OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Blueprint

I Blueprint vanno oltre i semplici template Terraform. Ogni blueprint:

- Offre suggerimenti hardware validati (ad esempio, shape ottimali, configurazioni CPU/GPU),
- Include stack applicativi end-to-end personalizzati per diversi casi d’uso GenAI,
- Include monitoraggio, logging e auto-scaling configurati pronti all’uso.

Dopo aver installato OCI AI Blueprints su un cluster OKE nella tua tenancy, puoi distribuire questi blueprint preconfigurati:

| Blueprint                                                                                                     | Descrizione                                                                                                                                |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------ |
| [**LLM & VLM Inference con vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | Distribuisci modelli Llama 2/3/3.1 7B/8B utilizzando shape GPU NVIDIA e il motore di inferenza vLLM con auto-scaling.                     |
| [**Benchmarking Fine-Tuning**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking)                    | Esegui MLCommons quantizzato Llama-2 70B LoRA fine-tuning su A100 per benchmarking delle performance.                                      |
| [**Fine-Tuning LoRA**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning)                             | Fine-tuning LoRA di modelli custom o HuggingFace usando qualsiasi dataset. Include tuning flessibile degli iperparametri.                 |
| [**Health Check**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check)                                 | Valutazione completa delle performance GPU per garantire la massima efficienza hardware prima di avviare carichi di lavoro intensivi.      |
| [**Inferenza CPU**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference)                                   | Sfrutta Ollama per testare l’inferenza su CPU con modelli come Mistral, Gemma e altri.                                                    |
| [**Inferenza Multi-nodo con RDMA e vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/)    | Distribuisci LLM Llama-405B su più nodi con RDMA usando nodi H100 con vLLM e LeaderWorkerSet.                                             |
| [**Inferenza autoscalata con vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/)                  | Servi LLM con auto-scaling tramite KEDA, che scala su più GPU e nodi utilizzando metriche applicative come la latenza di inferenza.       |
| [**LLM Inference con MIG**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/)                 | Distribuisci LLM su una frazione di GPU con le multi-instance GPU Nvidia e servili con vLLM.                                              |
| [**Job Queuing**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams)                                             | Approfitta della coda dei job e imposta quote di risorse e condivisione equa tra i team.                                                  |

## Supporto e Contatti

Per domande, problemi o feedback, contatta [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) oppure [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---