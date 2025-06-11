# ML トレーニング参照アーキテクチャ＆テスト <!-- omit from toc -->

> **警告**
> 現在、このリポジトリは特にテストケースセクションに焦点を当てた大規模なリファクタリングを進めています。以前のディレクトリ構造や非推奨のテストケースを使用したい場合は、[v1.1.0](https://github.com/aws-samples/awsome-distributed-training/releases/tag/v1.1.0) を参照してください。

このリポジトリには、[Amazon SageMaker Hyperpod](https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod.html)、[AWS ParallelCluster](https://docs.aws.amazon.com/parallelcluster/latest/ug/what-is-aws-parallelcluster.html)、[AWS Batch](https://docs.aws.amazon.com/batch/latest/userguide/what-is-batch.html)、および [Amazon EKS](https://docs.aws.amazon.com/eks/latest/userguide/getting-started-console.html) を用いた分散モデル学習のための参照アーキテクチャとテストケースが含まれています。テストケースは、さまざまなタイプとサイズのモデル、異なるフレームワークおよび並列化最適化（Pytorch DDP/FSDP、MegatronLM、NemoMegatronなど）をカバーしています。

このディレクトリの主な構成は以下の通りです：

```bash
reference-architectures/
|-- 1.architectures/               # 参照アーキテクチャのCloudFormationテンプレート
|-- 2.ami_and_containers/          # AMIおよびコンテナイメージ作成用スクリプト
|-- 3.test_cases/                  # 参照テストケースおよびベンチマークスクリプト
|-- 4.validation_observability/    # パフォーマンス測定やトラブルシューティングツール
`-- ...
```

**注意**：アーキテクチャは、参照テンプレート `1.architectures/0.s3/` および `1.architectures/1.vpc_network/` を使用して作成された S3 バケットおよび VPC と連携するよう設計されています。_参照アーキテクチャをデプロイする前に、これら2つのテンプレートを必ずデプロイすることを強く推奨します。_

## 0. ワークショップ

以下のワークショップに従って、AWS上でモデルをトレーニングできます。各ワークショップには複数のテストケースの例や、LLMトレーニング用クラスタの運用に関する情報が含まれています。

| 名前                                                                                     | コメント                                                       |
| ---------------------------------------------------------------------------------------- | -------------------------------------------------------------- |
| [Amazon SageMaker HyperPod](https://catalog.workshops.aws/sagemaker-hyperpod/en-US)       | SageMaker HyperPodのワークショップ。デプロイとモニタリング手順を示す |
| [AWS ParallelCluster](https://catalog.workshops.aws/ml-on-aws-parallelcluster)           | HyperPodと類似のワークショップだがParallelCluster用             |
| [Amazon SageMaker HyperPod EKS](https://catalog.workshops.aws/sagemaker-hyperpod-eks)     | SageMaker HyperPod EKSのワークショップ。デプロイとモニタリング手順を示す |

## 1. アーキテクチャ

アーキテクチャは `1.architectures` にあり、ユーティリティおよびサービス関連のアーキテクチャで構成されています。

| 名前                                                                                  | カテゴリ | 用途                                                      |
| ------------------------------------------------------------------------------------- | -------- | --------------------------------------------------------- |
| [`0.s3`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/0.s3)                                   | ストレージ  | S3バケットを作成                                         |
| [`1.vpc_network`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/1.vpc_network)                 | ネットワーク  | サブネット付きのVPCを作成し必要なリソースを構築          |
| [`2.aws-parallelcluster`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/2.aws-parallelcluster) | コンピュート  | GPUおよびカスタムシリコン学習用クラスタテンプレート       |
| [`3.aws-batch`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/3.aws-batch)                     | コンピュート  | 分散学習用AWS Batchテンプレート                           |
| [`4.amazon-eks`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/4.amazon-eks)                   | コンピュート  | Amazon EKSでのトレーニング用マニフェストファイル           |
| [`5.sagemaker-hyperpod`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/5.sagemaker-hyperpod)   | コンピュート  | 分散学習用SageMaker HyperPodテンプレート                   |

今後さらに追加予定です。新しいもの（例：Rayなど）を自由に追加してください。また、EFAおよび推奨環境変数の[ドキュメント](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-cheatsheet.md)も見つけられます。

## 2. カスタムAmazonマシンイメージ

カスタムマシンイメージは、[Packer](www.packer.io) を使用してAWS ParallelCluster、Amazon EKS、通常のEC2向けに構築可能です。これらのイメージはAnsibleロールとプレイブックに基づいています。

## 3. テストケース

テストケースはフレームワーク別に整理されており、さまざまな分散学習シナリオをカバーしています。各テストケースには、分散学習ジョブを実行するために必要なスクリプトと設定が含まれています。

### PyTorch テストケース
- [`FSDP/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/FSDP) - Fully Sharded Data Parallelトレーニング例
- [`megatron-lm/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/megatron-lm) - Megatron-LM分散学習例
- [`nemo-launcher/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-launcher) - NeMo Launcher分散学習例（NeMoバージョン1.0専用）
- [`nemo-run/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/nemo-run) - NeMoフレームワーク分散学習例（NeMoバージョン2.0以降対応）
- [`neuronx-distributed/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/neuronx-distributed) - AWS Trainium分散学習例
- [`mosaicml-composer/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/mosaicml-composer) - MosaicML Composer例
- [`picotron/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/picotron) - PicoTron分散学習例
- [`torchtitan/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/torchtitan) - TorchTitan例
- [`cpu-ddp/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/cpu-ddp) - CPUベースのDistributed Data Parallel例
- [`bionemo/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/pytorch/bionemo) - BioNeMo分散学習例

### JAX テストケース
- [`jax/`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/3.test_cases/jax) - PaxMLを使用したJAXベースの分散学習例

各テストケースには以下が含まれます：
- トレーニングスクリプトおよび設定
- コンテナ定義（該当する場合）
- 各種クラスタタイプ用の起動スクリプト
- パフォーマンスモニタリングおよび検証ツール

## 4. 検証スクリプト

ユーティリティスクリプトやマイクロベンチマーク例は `4.validation_observability/` に配置されています。EFA Prometheusエクスポーターはこの[ディレクトリ](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter) にあります。

| 名前                                                                                      | コメント                                                      |
| ----------------------------------------------------------------------------------------- | ------------------------------------------------------------- |
| [`1.pytorch-env-validation`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/1.pytorch-env-validation) | PyTorch環境の検証                                           |
| [`3.efa-node-exporter`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/3.efa-node-exporter)           | Amazon EFA監視モジュール付きノードエクスポーター              |
| [`4.prometheus-grafana`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/4.prometheus-grafana)         | SageMaker Hyperpodクラスタの監視用デプロイメント資産          |
| [`5.nsight`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/4.validation_and_observability/5.nsight)                                 | Nvidia Nsight Systemsを用いたワークロードプロファイリング方法 |
| [`efa-versions.py`](https://raw.githubusercontent.com/aws-samples/awsome-distributed-training/main/1.architectures/efa-versions.py)                                  | Nvidiaライブラリ、ドライバーおよびEFAドライバーのバージョン取得 |

## 5. CI

統合テストは[pytest](https://docs.pytest.org)で記述されています。以下を実行してください：

```bash
pytest .
```

または標準出力をキャプチャせず、すべてのDockerイメージやその他のアーティファクトを保持してテストを実行することもできます。

```bash
pytest -s --keep-artifacts=t
```

## 6. 貢献者

構築、レビュー、テストに貢献いただいたすべての方に感謝します。

[![Contributors](https://contrib.rocks/image?repo=aws-samples/awsome-distributed-training)](https://github.com/aws-samples/awsome-distributed-training/graphs/contributors)

## 7. スター履歴

[![Star History Chart](https://api.star-history.com/svg?repos=aws-samples/awsome-distributed-training&type=Date)](https://star-history.com/#aws-samples/awsome-distributed-training&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---