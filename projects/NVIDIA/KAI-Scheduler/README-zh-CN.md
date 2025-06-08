[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler 是一个强大、高效且可扩展的 [Kubernetes 调度器](https://kubernetes.io/zh-cn/docs/concepts/scheduling-eviction/kube-scheduler/)，专为优化 AI 和机器学习工作负载的 GPU 资源分配而设计。

KAI Scheduler 能够管理大规模 GPU 集群，包括数千个节点和高吞吐量的工作负载，使其成为广泛且高需求环境的理想选择。
KAI Scheduler 允许 Kubernetes 集群管理员动态地为工作负载分配 GPU 资源。

KAI Scheduler 支持整个 AI 生命周期，从需要最少资源的小型交互式作业到大型训练和推理，都可在同一集群中完成。
它确保不同使用者之间资源分配最优且公平。
KAI Scheduler 可以与集群中已安装的其他调度器并行运行。

## 主要特性
* [批量调度](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md)：确保一组中的所有 pod 要么同时调度，要么全部不调度。
* 紧凑打包与分散调度：通过最小化碎片（紧凑打包）或提高弹性和负载均衡（分散调度）优化节点使用率。
* [工作负载优先级](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md)：在队列内高效地为工作负载分级排序。
* [分层队列](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md)：通过两级队列层级灵活地管理组织内的工作负载。
* [资源分配](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm)：可为每个队列自定义配额、超额权重、限制和优先级。
* [公平性策略](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies)：通过主导资源公平（DRF）和队列间的资源回收，确保资源分配公平。
* 工作负载整合：智能重新分配运行中的工作负载，减少碎片并提升集群利用率。
* [弹性工作负载](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md)：在定义的最小和最大 pod 数量范围内动态扩缩工作负载。
* 动态资源分配（DRA）：通过 Kubernetes ResourceClaims 支持特定厂商的硬件资源（如 NVIDIA 或 AMD 的 GPU）。
* [GPU 共享](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md)：允许多个工作负载高效共享单个或多个 GPU，最大化资源利用率。
* 云与本地部署支持：完全兼容动态云基础设施（包括如 Karpenter 的自动扩缩）以及静态本地部署。

## 前置条件
在安装 KAI Scheduler 之前，请确保你已具备：

- 一个正在运行的 Kubernetes 集群
- 已安装 [Helm](https://helm.sh/docs/intro/install) CLI
- 已安装 [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator)，以便调度请求 GPU 资源的工作负载

## 安装
KAI Scheduler 将安装在 `kai-scheduler` 命名空间中。提交工作负载时请确保使用专用命名空间。

### 安装方式
KAI Scheduler 可通过以下方式安装：

- **从生产环境安装（推荐）**
- **从源码构建（自行编译）**

#### 从生产环境安装
在 [releases](https://github.com/NVIDIA/KAI-Scheduler/releases) 页面找到最新的发布版本。
将 `<VERSION>` 替换为所需的版本后，运行以下命令：
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### 从源码构建
请按照[这里](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)的说明操作

## 快速开始
要开始使用 KAI Scheduler 调度工作负载，请参阅 [快速开始示例](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)

## 路线图

### 2025 年主要优先级概览
* 重构代码库以增强厂商中立性
* 支持 Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* 研究与 Kueue 的集成可能性 https://github.com/NVIDIA/KAI-Scheduler/issues/68
* 为 pod-group 增加拓扑感知调度支持 https://github.com/NVIDIA/KAI-Scheduler/issues/66
* 支持每个工作负载的最小运行时间
* 支持每个工作负载的最大运行时间（支持延迟重新入队）
* 在 KAI 默认安装包中增加更多 PriorityClasses
* 支持 JobSet
* 支持 LWS (LeaderWorkerSet)
* 添加 pod 和 pod-group 抢占的指标统计
* 解耦优先级与抢占功能

### 长期目标
* 支持每个队列的时间衰减
* 超大规模集群改进
* 支持推理工作负载的整合，以实现集群碎片整理
* 支持 n 层分层队列
* 推理工作负载的平滑滚动发布（新版本更新时支持队列临时超额）

## 社区、讨论与支持

我们非常欢迎你的参与！以下是与我们联系的最佳方式：

### Slack
首先加入 [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf)，然后访问 [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) 频道。

### 双周社区会议  
**时间：** 每隔一周的周一，17:00 CEST  
[转换为你的时区](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [添加到你的日历](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [会议记录与议程](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### 邮件列表  
加入 [kai-scheduler 邮件列表](https://groups.google.com/g/kai-scheduler) 以获取双周会议的最新信息。

### 技术问题与功能请求  
如有 bug、功能建议或技术支持，请提交 [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose)。这有助于我们跟踪请求并高效响应。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---