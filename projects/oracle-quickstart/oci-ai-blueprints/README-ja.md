# OCI AI Blueprints

**OCI AI Blueprintsプラットフォームを使ってAIワークロードのデプロイ、スケール、監視を行い、GPUのオンボーディング時間を数週間から数分に短縮します。**

OCI AI Blueprintsは、Kubernetes Engine (OKE)上で生成AIワークロードをデプロイおよび管理するためのシンプルなノーコードソリューションです。推奨ハードウェア構成、事前パッケージ化されたソフトウェアスタック、すぐに使える可観測性ツールを提供し、インフラストラクチャの選定、ソフトウェア互換性、MLOpsのベストプラクティスに苦労することなく、AIアプリケーションを迅速かつ効率的に稼働させることができます。

[![OCI AI Blueprintsをインストール](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## 目次

**はじめに**

- [AI Blueprintsのインストール](./GETTING_STARTED_README.md)
- [AI BlueprintsポータルとAPIへのアクセス](docs/usage_guide.md)

**OCI AI Blueprintsについて**

- [OCI AI Blueprintsとは？](docs/about.md)
- [なぜOCI AI Blueprintsを使うのか？](docs/about.md)
- [特徴](docs/about.md)
- [Blueprints一覧](#blueprints)
- [FAQ](docs/about.md)
- [サポート・お問い合わせ](https://github.com/oracle-quickstart/oci-ai-blueprints/blob/vkammari/doc_improvements/docs/about/README.md#frequently-asked-questions-faq)

**APIリファレンス**

- [APIリファレンスドキュメント](docs/api_documentation.md)

**追加リソース**

- [カスタムBlueprintsの公開](./docs/custom_blueprints)
- [アップデートのインストール](docs/installing_new_updates.md)
- [IAMポリシー](docs/iam_policies.md)
- [リポジトリ内容](docs/about.md)
- [既知の問題](docs/known_issues.md)

## はじめに

以下のボタンをクリックしてOCI AI Blueprintsをインストールしてください。

[![OCI AI Blueprintsをインストール](https://raw.githubusercontent.com/oracle-quickstart/oci-ai-blueprints/refs/heads/main/docs/images/install.svg)](./GETTING_STARTED_README.md)

## Blueprints

Blueprintsは単なるTerraformテンプレートを超えたものです。各Blueprintは以下を提供します。

- 検証済みのハードウェア推奨（最適なシェイプやCPU/GPU構成など）
- さまざまなGenAIユースケースに合わせたエンドツーエンドのアプリケーションスタック
- 監視・ログ・オートスケーリングがすぐに利用可能な設定済み

OCI AI BlueprintsをテナンシーのOKEクラスターにインストールした後、以下の事前構築されたBlueprintsをデプロイできます。

| Blueprint                                                                                     | 説明                                                                                                                                            |
| --------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- |
| [**LLM & VLM Inference with vLLM**](docs/sample_blueprints/llm_inference_with_vllm/README.md) | NVIDIA GPUシェイプとvLLM推論エンジンを用い、Llama 2/3/3.1 7B/8Bモデルをオートスケーリングでデプロイします。                                  |
| [**Fine-Tuning Benchmarking**](./docs/sample_blueprints/lora-benchmarking)                    | MLCommonsの量子化済みLlama-2 70B LoRAファインチューニングをA100上で実行し、パフォーマンスベンチマークを行います。                            |
| [**LoRA Fine-Tuning**](./docs/sample_blueprints/lora-fine-tuning)                             | 任意のデータセットを使用してカスタムまたはHuggingFaceモデルのLoRAファインチューニング。柔軟なハイパーパラメーターチューニングも含みます。      |
| [**Health Check**](./docs/sample_blueprints/gpu-health-check)                                 | 集中的な計算ワークロードを開始する前に、GPU性能を包括的に評価し、最適なハードウェア準備を確認します。                                        |
| [**CPU Inference**](./docs/sample_blueprints/cpu-inference)                                   | Ollamaを活用し、Mistral、GemmaなどのモデルでCPUベースの推論をテストします。                                                                  |
| [**Multi-node Inference with RDMA and vLLM**](./docs/sample_blueprints/multi-node-inference/) | H100ノードとvLLM、LeaderWorkerSetを用い、RDMAで複数ノードにまたがるLlama-405B規模LLMをデプロイします。                                     |
| [**Autoscaling Inference with vLLM**](./docs/sample_blueprints/auto_scaling/)                 | KEDAによるオートスケーリングでLLMを提供。推論レイテンシ等のアプリケーション指標に基づき複数GPU・ノードにスケールします。                   |
| [**LLM Inference with MIG**](./docs/sample_blueprints/mig_multi_instance_gpu/)                | NvidiaのマルチインスタンスGPUを使ってGPUの一部でLLMをデプロイし、vLLMで提供します。                                                        |
| [**Job Queuing**](./docs/sample_blueprints/teams)                                             | ジョブキューイングを活用し、チーム間でリソースクォータやフェアシェアを強制できます。                                                        |

## サポート・お問い合わせ

ご質問・問題・フィードバック等は[vishnu.kammari@oracle.com](mailto:vishnu.kammari@oracle.com) または [grant.neuman@oracle.com](mailto:grant.neuman@oracle.com)までご連絡ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---