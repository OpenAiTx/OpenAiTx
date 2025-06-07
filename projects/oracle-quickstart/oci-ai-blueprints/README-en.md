# OCI AI Blueprints

**Deploy, scale, and monitor AI workloads with the OCI AI Blueprints platform, and reduce your GPU onboarding time from weeks to minutes.**

OCI AI Blueprints is a streamlined, no-code solution for deploying and managing Generative AI workloads on Kubernetes Engine (OKE). By providing opinionated hardware recommendations, pre-packaged software stacks, and out-of-the-box observability tooling, OCI AI Blueprints helps you get your AI applications running quickly and efficiently—without wrestling with the complexities of infrastructure decisions, software compatibility, and MLOps best practices.

[![Install OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Table of Contents

**Getting Started**

- [Install AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)
- [Access AI Blueprints Portal and API](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/usage_guide.md)

**About OCI AI Blueprints**

- [What is OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Why use OCI AI Blueprints?](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Features](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [List of Blueprints](#blueprints)
- [FAQ](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Support & Contact](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API Reference**

- [API Reference Documentation](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/api_documentation.md)

**Additional Resources**

- [Publish Custom Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/custom_blueprints)
- [Installing Updates](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/installing_new_updates.md)
- [IAM Policies](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/iam_policies.md)
- [Repository Contents](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/about.md)
- [Known Issues](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/known_issues.md)

## Getting Started

Install OCI AI Blueprints by clicking on the button below:

[![Install OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/GETTING_STARTED_README.md)

## Blueprints

Blueprints go beyond basic Terraform templates. Each blueprint:

- Offers validated hardware suggestions (e.g., optimal shapes, CPU/GPU configurations),
- Includes end-to-end application stacks customized for different GenAI use cases, and
- Comes with monitoring, logging, and auto-scaling configured out of the box.

After you install OCI AI Blueprints to an OKE cluster in your tenancy, you can deploy these pre-built blueprints:

| Blueprint                                                                                     | Description                                                                                                                              |
| --------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/llm_inference_with_vllm/README.md) | Deploy Llama 2/3/3.1 7B/8B models using NVIDIA GPU shapes and the vLLM inference engine with auto-scaling.                               |
| [**Fine-Tuning Benchmarking**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-benchmarking)                    | Run MLCommons quantized Llama-2 70B LoRA finetuning on A100 for performance benchmarking.                                                |
| [**LoRA Fine-Tuning**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/lora-fine-tuning)                             | LoRA fine-tuning of custom or HuggingFace models using any dataset. Includes flexible hyperparameter tuning.                             |
| [**Health Check**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/gpu-health-check)                                 | Comprehensive evaluation of GPU performance to ensure optimal hardware readiness before initiating any intensive computational workload. |
| [**CPU Inference**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/cpu-inference)                                   | Leverage Ollama to test CPU-based inference with models like Mistral, Gemma, and more.                                                   |
| [**Multi-node Inference with RDMA and vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/multi-node-inference/) | Deploy Llama-405B sized LLMs across multiple nodes with RDMA using H100 nodes with vLLM and LeaderWorkerSet.                             |
| [**Autoscaling Inference with vLLM**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/auto_scaling/)                 | Serve LLMs with auto-scaling using KEDA, which scales to multiple GPUs and nodes using application metrics like inference latency.       |
| [**LLM Inference with MIG**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/mig_multi_instance_gpu/)                | Deploy LLMs to a fraction of a GPU with Nvidia’s multi-instance GPUs and serve them with vLLM.                                           |
| [**Job Queuing**](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/main/docs/sample_blueprints/teams)                                             | Take advantage of job queuing and enforce resource quotas and fair sharing between teams.                                                |

## Support & Contact

If you have any questions, issues, or feedback, contact [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) or [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---