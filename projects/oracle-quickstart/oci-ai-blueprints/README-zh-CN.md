# OCI AI Blueprints

**使用 OCI AI Blueprints 平台部署、扩展和监控 AI 工作负载，将 GPU 上线时间从数周缩短至数分钟。**

OCI AI Blueprints 是一款精简、无代码的解决方案，可在 Kubernetes Engine（OKE）上部署和管理生成式 AI 工作负载。通过提供有主见的硬件推荐、预打包的软件栈以及开箱即用的可观测性工具，OCI AI Blueprints 帮助您快速高效地运行 AI 应用，无需纠结于基础设施决策、软件兼容性和 MLOps 最佳实践。

[![安装 OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## 目录

**入门指南**

- [安装 AI Blueprints](./GETTING_STARTED_README.md)
- [访问 AI Blueprints 门户和 API](docs/usage_guide.md)

**关于 OCI AI Blueprints**

- [什么是 OCI AI Blueprints？](docs/about.md)
- [为什么使用 OCI AI Blueprints？](docs/about.md)
- [功能特性](docs/about.md)
- [Blueprints 列表](#blueprints)
- [常见问题](docs/about.md)
- [支持与联系方式](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**API 参考**

- [API 参考文档](docs/api_documentation.md)

**其他资源**

- [发布自定义 Blueprints](./docs/custom_blueprints)
- [安装更新](docs/installing_new_updates.md)
- [IAM 策略](docs/iam_policies.md)
- [仓库内容](docs/about.md)
- [已知问题](docs/known_issues.md)

## 入门指南

点击下方按钮安装 OCI AI Blueprints：

[![安装 OCI AI Blueprints](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Blueprints 不止于基础的 Terraform 模板。每个 Blueprint：

- 提供经过验证的硬件建议（如最佳形状、CPU/GPU 配置），
- 包含针对不同生成式 AI 用例定制的端到端应用栈，
- 并配备了开箱即用的监控、日志和自动扩展功能。

在您的租户 OKE 集群中安装 OCI AI Blueprints 后，您可以部署以下预构建的 Blueprints：

| Blueprint                                                                                     | 描述                                                                                                                                    |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md) | 使用 NVIDIA GPU 形状和 vLLM 推理引擎自动扩展部署 Llama 2/3/3.1 7B/8B 模型。                                                           |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | 在 A100 上运行 MLCommons 量化 Llama-2 70B LoRA 微调，进行性能基准测试。                                                                |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | 使用任意数据集对自定义或 HuggingFace 模型进行 LoRA 微调。支持灵活的超参数调整。                                                        |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | 全面评估 GPU 性能，确保在启动任何高强度计算工作负载前硬件已准备就绪。                                                                 |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | 利用 Ollama 测试基于 CPU 的推理，支持如 Mistral、Gemma 等模型。                                                                        |
| [**Multi-node Inference with RDMA and vLLM**](./docs/sample_blueprints/multi-node-inference/) | 使用 H100 节点、vLLM 和 LeaderWorkerSet，结合 RDMA 跨多节点部署 Llama-405B 规模 LLM。                                                 |
| [**Autoscaling Inference with vLLM**](./docs/sample_blueprints/auto_scaling/)                 | 通过 KEDA 基于应用指标（如推理延迟）实现 LLM 自动扩展，支持多 GPU 和多节点。                                                          |
| [**LLM Inference with MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                | 利用 Nvidia 多实例 GPU 部署 LLM 至 GPU 的部分资源，并通过 vLLM 服务。                                                                 |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                             | 支持作业排队，强制资源配额，实现团队间公平共享。                                                                                        |

## 支持与联系方式

如有任何问题、意见或反馈，请联系 [vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) 或 [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---