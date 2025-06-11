# 机器学习训练参考架构与测试 <!-- omit from toc -->

> **警告**
> 我们目前正在对该仓库进行重大重构，特别是测试用例部分。如果您更倾向于使用之前的目录结构和已弃用的测试用例，请参考 [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0)。

本仓库包含使用 [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html)、[AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html)、[AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) 和 [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html) 进行分布式模型训练的参考架构和测试用例。测试用例涵盖不同类型和规模的模型，以及不同框架和并行优化（Pytorch DDP/FSDP、MegatronLM、NemoMegatron 等）。

该目录的主要组件包括：

```bash
reference-architectures/
|-- 1.architectures/               # 参考架构的 CloudFormation 模板
|-- 2.ami_and_containers/          # 创建 AMI 和容器镜像的脚本
|-- 3.test_cases/                  # 参考测试用例和/或基准脚本
|-- 4.validation_observability/    # 用于性能测量或故障排除的工具
`-- ...
```

**注意**：这些架构设计为配合使用通过参考模板 `1.architectures/0.s3/` 和 `1.architectures/1.vpc_network/` 创建的 S3 存储桶和 VPC。_强烈建议在部署任何参考架构之前先部署这两个模板。_

## 0. 研讨会

您可以通过以下研讨会在 AWS 上进行模型训练。每个研讨会都包含多个测试用例示例以及有关大规模语言模型训练集群操作的实用信息。

| 名称                                                                                  | 备注                                                            |
| ------------------------------------------------------------------------------------- | --------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | SageMaker HyperPod 研讨会，展示如何部署和监控                  |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster)         | 类似于 HyperPod 的 ParallelCluster 研讨会                       |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks) | SageMaker HyperPod EKS 研讨会，展示如何部署和监控               |

## 1. 架构

架构位于 `1.architectures` 目录，包含实用工具和服务相关的架构。

| 名称                                                               | 类别    | 用途                                                 |
| ------------------------------------------------------------------ | ------- | ---------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | 存储    | 创建 S3 存储桶                                       |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | 网络    | 创建带子网的 VPC 及所需资源                          |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | 计算    | GPU 和自定义硅片训练的集群模板                        |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | 计算    | 用于分布式训练的 AWS Batch 模板                      |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | 计算    | 用于 Amazon EKS 训练的 Manifest 文件                 |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | 计算    | SageMaker HyperPod 分布式训练模板                     |

更多架构将陆续添加，欢迎自由新增（例如 Ray？）。您还可以找到 [EFA 文档](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) 以及推荐的环境变量。

## 2. 自定义 Amazon 机器映像

可以使用 [Packer](www.packer.io) 构建适用于 AWS ParallelCluster、Amazon EKS 和普通 EC2 的自定义机器映像。这些映像基于 Ansible 角色和剧本。

## 3. 测试用例

测试用例按框架组织，涵盖各种分布式训练场景。每个测试用例包含运行分布式训练作业所需的脚本和配置。

### PyTorch 测试用例
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - 完全分片数据并行训练示例
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM 分布式训练示例
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - NeMo Launcher 分布式训练示例（仅适用于 NeMo 1.0）
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMo 框架分布式训练示例（适用于 NeMo 2.0 及以上版本）
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium 分布式训练示例
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer 示例
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron 分布式训练示例
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan 示例
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - 基于 CPU 的分布式数据并行示例
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo 分布式训练示例

### JAX 测试用例
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - 使用 PaxML 的 JAX 分布式训练示例

每个测试用例包含：
- 训练脚本和配置
- 容器定义（如适用）
- 不同集群类型的启动脚本
- 性能监控和验证工具

## 4. 验证脚本

实用脚本和微基准测试示例位于 `4.validation_scripts/`。EFA Prometheus 导出器可在此 [目录](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 找到。

| 名称                                                                                          | 备注                                                          |
| --------------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | 验证您的 PyTorch 环境                                         |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | 带有 Amazon EFA 监控模块的节点导出器                         |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | 用于监控 SageMaker Hyperpod 集群的部署资源                   |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | 展示如何使用 Nvidia Nsight Systems 对工作负载进行分析       |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | 获取 Nvidia 库、驱动和 EFA 驱动的版本信息                    |

## 5. 持续集成

集成测试使用 [pytest](https://docs.pytest.org) 编写。只需运行：

```bash
pytest .
```

或者，您可以运行测试时不捕获标准输出，并保留所有 Docker 镜像及其他工件：

```bash
pytest -s --keep-artifacts=t
```

## 6. 贡献者

感谢所有贡献者的构建、审查和测试工作。

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. Star 历史

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---