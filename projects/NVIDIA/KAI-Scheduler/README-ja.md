[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Schedulerは、AIおよび機械学習ワークロード向けにGPUリソース割り当てを最適化する、堅牢で効率的かつスケーラブルな[Kubernetesスケジューラ](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/)です。

何千ものノードを含む大規模なGPUクラスターや高スループットのワークロードを管理できるように設計されており、KAI Schedulerは広範かつ要求の厳しい環境に最適です。
KAI SchedulerはKubernetesクラスター管理者がワークロードにGPUリソースを動的に割り当てることを可能にします。

KAI Schedulerは、小規模で対話的なジョブから、大規模なトレーニングや推論まで、同一クラスター内でAIライフサイクル全体をサポートします。
異なる利用者間でのリソースの公平性を維持しながら、最適なリソース割り当てを保証します。
他のスケジューラと同時にクラスター上で稼働することも可能です。

## 主な特徴
* [バッチスケジューリング](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): グループ内のすべてのPodが同時にスケジューリングされるか、まったくされないことを保証します。
* ビンパッキング&スプレッドスケジューリング: ノードの断片化を最小化（ビンパッキング）またはレジリエンスや負荷分散を向上（スプレッドスケジューリング）させてノード利用を最適化します。
* [ワークロード優先度](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): キュー内でワークロードの優先順位を効果的に管理します。
* [階層型キュー](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): 柔軟な組織管理のために2階層のキューヒエラルキーでワークロードを管理します。
* [リソース分配](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): 各キューごとにクォータ、オーバークォータ時の重み、上限、優先度をカスタマイズ可能です。
* [公平性ポリシー](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): ドミナントリソースフェアネス（DRF）やリソース再取得によってキュー間の公平なリソース分配を保証します。
* ワークロード統合: クラスタ断片化を減らし利用率を高めるため、実行中ワークロードをインテリジェントに再配置します。
* [エラスティックワークロード](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): 定義された最小・最大Pod数の範囲でワークロードを動的にスケーリングします。
* 動的リソース割り当て（DRA）: Kubernetes ResourceClaimsを通じてベンダー固有のハードウェアリソース（例: NVIDIAやAMDのGPU）をサポートします。
* [GPU共有](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): 複数のワークロードが単一または複数のGPUを効率的に共有し、リソース利用率を最大化します。
* クラウド＆オンプレミスサポート: ダイナミックなクラウドインフラ（Karpenterなどのオートスケーラー含む）および静的なオンプレミス展開の両方に完全対応しています。

## 前提条件
KAI Schedulerをインストールする前に、以下を用意してください:

- 稼働中のKubernetesクラスター
- [Helm](https://helm.sh/docs/intro/install) CLIのインストール
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator)のインストール（GPUリソースを要求するワークロードのスケジューリングに必要）

## インストール
KAI Schedulerは`kai-scheduler`ネームスペースにインストールされます。ワークロードを送信する際は専用のネームスペースを使用してください。

### インストール方法
KAI Schedulerは以下の方法でインストールできます:

- **プロダクションから（推奨）**
- **ソースから（自分でビルド）**

#### プロダクションからインストール
[releases](https://github.com/NVIDIA/KAI-Scheduler/releases)ページで最新リリースバージョンを確認してください。
次のコマンドの`<VERSION>`を目的のリリースバージョンに置き換えて実行します:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### ソースからビルド
[こちら](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)の手順に従ってください

## クイックスタート
KAI Schedulerでワークロードのスケジューリングを始めるには、[クイックスタート例](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)をご覧ください

## ロードマップ

### 2025年の主な優先事項の概要
* ベンダーニュートラル性向上のためのコードベースリファクタリング
* Scheduling Gatesのサポート https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Kueueとの統合の可能性調査 https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Pod-groupのトポロジー認識スケジューリングサポート追加 https://github.com/NVIDIA/KAI-Scheduler/issues/66
* ワークロードごとの最小実行時間サポート
* ワークロードごとの最大実行時間サポート（遅延再キューイング付き）
* デフォルトのKAIインストールにより多くのPriorityClassを追加
* JobSetサポート
* LWS（LeaderWorkerSet）サポート
* PodおよびPod-groupプリエンプションのメトリクス追加
* 優先度とプリエンプションの分離

### 長期目標
* キューごとのタイムディケイサポート
* ハイパースケール改善
* クラスター断片化解消のための推論ワークロード統合サポート
* n階層の階層型キューサポート
* 推論ワークロードのグレースフルロールアウト（新リビジョンの更新時に一時的なキューのオーバークォータを利用）

## コミュニティ・ディスカッション・サポート

皆様からのご意見をお待ちしています！以下が主な連絡方法です:

### Slack
まず[CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf)に参加し、[#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler)チャンネルをご覧ください。

### 隔週コミュニティコール  
**開催時刻:** 隔週月曜日 17:00 CEST  
[タイムゾーン変換](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [カレンダーに追加](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [ミーティングノート&アジェンダ](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### メーリングリスト  
[こちら](https://groups.google.com/g/kai-scheduler)からkai-schedulerメーリングリストに参加し、隔週ミーティングの最新情報を受け取れます。

### 技術的な問題・機能リクエスト  
バグ報告、機能提案、技術サポートは[GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose)からお願いします。ご要望の管理と迅速な対応に役立ちます。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---