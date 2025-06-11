# ML 訓練參考架構與測試 <!-- omit from toc -->

> **警告**
> 我們目前正在對此存放庫進行重大重構，特別是測試案例部分。如果您偏好使用先前的目錄結構與已棄用的測試案例，請參考 [v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0)。

此存放庫包含使用 [Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html)、[AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html)、[AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html) 及 [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html) 進行分散式模型訓練的參考架構與測試案例。測試案例涵蓋不同類型及大小的模型，以及不同框架與平行優化（Pytorch DDP/FSDP、MegatronLM、NemoMegatron...）。

此目錄的主要組件為：

```bash
reference-architectures/
|-- 1.architectures/               # 參考架構的 CloudFormation 範本
|-- 2.ami_and_containers/          # 建立 AMI 與容器映像的腳本
|-- 3.test_cases/                  # 參考測試案例及/或基準測試腳本
|-- 4.validation_observability/    # 性能測量或故障排除工具
`-- ...
```

**注意**：架構設計需搭配使用透過參考範本 `1.architectures/0.s3/` 與 `1.architectures/1.vpc_network/` 所建立的 S3 儲存桶與 VPC。_強烈建議您在部署任何參考架構之前，先部署這兩個範本。_

## 0. 工作坊

您可以參考以下工作坊在 AWS 上訓練模型。每個工作坊均包含數個測試案例範例及操作大型語言模型訓練叢集的重點資訊。

| 名稱                                                                           | 備註                                                         |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------ |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)   | SageMaker HyperPod 工作坊，展示如何部署與監控               |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster) | 與 HyperPod 類似的工作坊，但使用 ParallelCluster             |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)   | SageMaker HyperPod EKS 工作坊，展示如何部署與監控            |

## 1. 架構

架構位於 `1.architectures`，包含工具與服務相關架構。

| 名稱                                                               | 類別     | 用途                                               |
| ------------------------------------------------------------------ | -------- | -------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | 儲存     | 建立 S3 儲存桶                                     |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | 網路     | 建立含子網路與所需資源的 VPC                        |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | 計算     | GPU 與自訂矽晶片訓練叢集範本                        |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | 計算     | 用於分散式訓練的 AWS Batch 範本                      |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | 計算     | 用於 Amazon EKS 訓練的 Manifest 檔案                 |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | 計算     | 用於分散式訓練的 SageMaker HyperPod 範本             |

未來會有更多，歡迎新增（例如 Ray？）。您也可以找到 [EFA 文件](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md) 及推薦的環境變數。

## 2. 自訂 Amazon 機器映像

可使用 [Packer](https://www.packer.io) 為 AWS ParallelCluster、Amazon EKS 與純 EC2 建立自訂機器映像。這些映像基於 Ansible 角色與劇本。

## 3. 測試案例

測試案例依框架組織，涵蓋各種分散式訓練場景。每個測試案例包含執行分散式訓練工作所需的腳本與設定。

### PyTorch 測試案例
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - 完整分片資料平行訓練範例
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM 分散式訓練範例
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - NeMo Launcher 分散式訓練範例。此測試案例僅適用 NeMo 版本 1.0。
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMo 框架分散式訓練範例。此測試案例適用 NeMo 版本 2.0 以上。
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium 分散式訓練範例
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer 範例
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron 分散式訓練範例
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan 範例
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - 基於 CPU 的分散式資料平行範例
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo 分散式訓練範例

### JAX 測試案例
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - 使用 PaxML 的 JAX 分散式訓練範例

每個測試案例包含：
- 訓練腳本與設定
- 容器定義（如適用）
- 不同叢集類型的啟動腳本
- 性能監控與驗證工具

## 4. 驗證腳本

工具腳本與微基準測試範例位於 `4.validation_scripts/`。EFA Prometheus 匯出器可於此 [目錄](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) 找到。

| 名稱                                                                                    | 備註                                                         |
| --------------------------------------------------------------------------------------- | ------------------------------------------------------------ |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | 驗證您的 PyTorch 環境                                        |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | 搭載 Amazon EFA 監控模組的節點匯出器                         |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | 用於監控 SageMaker Hyperpod 叢集的部署資產                   |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | 展示如何使用 Nvidia Nsight Systems 進行工作負載分析          |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | 取得 Nvidia 函式庫、驅動與 EFA 驅動版本                       |

## 5. 持續整合 (CI)

整合測試使用 [pytest](https://docs.pytest.org) 撰寫。只需執行：

```bash
pytest .
```

或可執行測試同時不捕捉標準輸出，並保留所有 Docker 映像與其他產物。

```bash
pytest -s --keep-artifacts=t
```

## 6. 貢獻者

感謝所有貢獻者的建立、審查與測試。

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. 星標歷史

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---