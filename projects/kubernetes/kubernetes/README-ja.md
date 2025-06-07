# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes（K8sとも呼ばれる）は、複数のホストにわたる[コンテナ化されたアプリケーション]の管理のためのオープンソースシステムです。アプリケーションのデプロイ、保守、スケーリングのための基本的なメカニズムを提供します。

Kubernetesは、Googleが[Borg]というシステムで大規模な本番ワークロードを運用してきた15年以上の経験と、コミュニティからの最高のアイデアやプラクティスを組み合わせて構築されています。

KubernetesはCloud Native Computing Foundation（[CNCF]）によってホストされています。もしあなたの会社がコンテナパッケージ化、動的スケジューリング、マイクロサービス志向の技術の進化に貢献したい場合は、CNCFへの参加を検討してください。関係者やKubernetesの役割についての詳細は、CNCFの[アナウンスメント]をご覧ください。

----

## K8sの利用を開始するには

[kubernetes.io]のドキュメントをご覧ください。

[Scalable Microservices with Kubernetes]の無料コースを受講できます。

Kubernetesのコードを他のアプリケーションでライブラリとして使用したい場合は、[公開コンポーネントの一覧](https://git.k8s.io/kubernetes/staging/README.md)をご覧ください。`k8s.io/kubernetes`モジュールまたは`k8s.io/kubernetes/...`パッケージのライブラリとしての利用はサポートされていません。

## K8sの開発を始めるには

[コミュニティリポジトリ]には、Kubernetesのソースからのビルド方法、コードやドキュメントへの貢献方法、連絡先など、あらゆる情報が集約されています。

すぐにKubernetesをビルドしたい場合は、以下の2つの方法があります。

##### [Go環境]が動作している場合

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### [Docker環境]が動作している場合

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

詳細は[開発者向けドキュメント]をご覧ください。

## サポート

サポートが必要な場合は、まず[トラブルシューティングガイド]から始め、順を追って問題解決を進めてください。

ご質問がある場合は、[何らかの方法で][communication]ご連絡ください。

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## コミュニティミーティング

[カレンダー](https://www.kubernetes.dev/resources/calendar/)には、Kubernetesコミュニティ内のすべてのミーティングが一か所にまとめられています。

## 導入企業

[ユーザーケーススタディ](https://kubernetes.io/case-studies/)サイトには、さまざまな業界でKubernetesを導入・移行している組織の実際のユースケースが掲載されています。

## ガバナンス

Kubernetesプロジェクトは、私たちのコミュニティと関係者を共通の目標に導くための原則、価値観、ポリシー、プロセスの枠組みによって運営されています。

[Kubernetesコミュニティ](https://github.com/kubernetes/community/blob/master/governance.md)は、私たちの組織体制を学ぶための出発点です。

[Kubernetes Steering community repo](https://github.com/kubernetes/steering)は、Kubernetes Steering CommitteeがKubernetesプロジェクトのガバナンスを監督するために使用しています。

## ロードマップ

[Kubernetes Enhancementsリポジトリ](https://github.com/kubernetes/enhancements)では、Kubernetesのリリース情報や、機能のトラッキング、バックログなどを提供しています。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---