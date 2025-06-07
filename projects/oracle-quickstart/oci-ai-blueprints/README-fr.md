# OCI AI Blueprints

**Déployez, mettez à l’échelle et surveillez vos charges de travail IA avec la plateforme OCI AI Blueprints, et réduisez votre temps d’intégration GPU de plusieurs semaines à quelques minutes.**

OCI AI Blueprints est une solution simplifiée et sans code pour le déploiement et la gestion de charges de travail d’IA générative sur Kubernetes Engine (OKE). En fournissant des recommandations matérielles validées, des piles logicielles pré-emballées et des outils d’observabilité prêts à l’emploi, OCI AI Blueprints vous aide à lancer rapidement et efficacement vos applications IA — sans avoir à gérer la complexité des choix d’infrastructure, de la compatibilité logicielle et des meilleures pratiques MLOps.

[![Installer OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Table des matières

**Démarrage**

- [Installer AI Blueprints](./GETTING_STARTED_README.md)
- [Accéder au portail et à l’API AI Blueprints](docs/usage_guide.md)

**À propos d’OCI AI Blueprints**

- [Qu’est-ce qu’OCI AI Blueprints ?](docs/about.md)
- [Pourquoi utiliser OCI AI Blueprints ?](docs/about.md)
- [Fonctionnalités](docs/about.md)
- [Liste des Blueprints](#blueprints)
- [FAQ](docs/about.md)
- [Support & Contact](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**Référence API**

- [Documentation de référence de l’API](docs/api_documentation.md)

**Ressources complémentaires**

- [Publier des Blueprints personnalisés](./docs/custom_blueprints)
- [Installation des mises à jour](docs/installing_new_updates.md)
- [Politiques IAM](docs/iam_policies.md)
- [Contenu du dépôt](docs/about.md)
- [Problèmes connus](docs/known_issues.md)

## Démarrage

Installez OCI AI Blueprints en cliquant sur le bouton ci-dessous :

[![Installer OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Les blueprints vont au-delà des simples modèles Terraform. Chaque blueprint :

- Offre des suggestions matérielles validées (par exemple, formes optimales, configurations CPU/GPU),
- Inclut des piles applicatives complètes personnalisées pour différents cas d’usage GenAI, et
- Est livré avec une supervision, une journalisation et une mise à l’échelle automatique configurées dès l’installation.

Après avoir installé OCI AI Blueprints sur un cluster OKE dans votre tenancy, vous pouvez déployer ces blueprints préconçus :

| Blueprint                                                                                     | Description                                                                                                                                              |
| --------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md) | Déployez les modèles Llama 2/3/3.1 7B/8B en utilisant des formes GPU NVIDIA et le moteur d’inférence vLLM avec mise à l’échelle automatique.              |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | Lancez un finetuning LoRA quantifié Llama-2 70B MLCommons sur A100 pour des tests de performance.                                                        |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | Finetuning LoRA de modèles personnalisés ou HuggingFace avec n’importe quel jeu de données. Inclut une optimisation flexible des hyperparamètres.         |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | Évaluation complète des performances GPU pour garantir une disponibilité matérielle optimale avant tout calcul intensif.                                  |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | Utilisez Ollama pour tester l’inférence basée sur CPU avec des modèles comme Mistral, Gemma, et plus encore.                                             |
| [**Multi-node Inference with RDMA and vLLM**](./docs/sample_blueprints/multi-node-inference/) | Déployez des LLMs de taille Llama-405B sur plusieurs nœuds avec RDMA à l’aide de nœuds H100, vLLM et LeaderWorkerSet.                                     |
| [**Autoscaling Inference with vLLM**](./docs/sample_blueprints/auto_scaling/)                 | Servez des LLMs avec mise à l’échelle automatique via KEDA, qui répartit sur plusieurs GPU et nœuds selon des métriques applicatives comme la latence.    |
| [**LLM Inference with MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                | Déployez des LLMs sur une fraction de GPU grâce aux GPUs multi-instance Nvidia et servez-les avec vLLM.                                                  |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                             | Profitez de la file d’attente des tâches et appliquez des quotas de ressources et une répartition équitable entre les équipes.                           |

## Support & Contact

Si vous avez des questions, des problèmes ou des retours, contactez [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) ou [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---