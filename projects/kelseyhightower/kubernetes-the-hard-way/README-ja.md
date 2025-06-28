# Kubernetes The Hard Way

このチュートリアルは、Kubernetesを手動でセットアップする方法を案内します。このガイドは、Kubernetesクラスタを自動で構築する完全自動化ツールを探している方には向いていません。Kubernetes The Hard Wayは学習に最適化されており、Kubernetesクラスタをブートストラップするために必要な各作業を理解できるよう、あえて手順を詳細に追っていきます。

> このチュートリアルの結果は、本番環境向けとは見なされず、コミュニティからのサポートも限定的かもしれませんが、学習を止める理由にはなりません！

## 著作権

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />この作品は <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">クリエイティブ・コモンズ 表示-非営利-継承 4.0 国際 ライセンス</a> の下に提供されています。

## 対象読者

このチュートリアルの対象は、Kubernetesの基本を理解し、コアコンポーネントがどのように組み合わさって動作するかを知りたい方です。

## クラスターの詳細

Kubernetes The Hard Wayでは、すべてのコントロールプレーンコンポーネントが1つのノード上で動作し、2つのワーカーノードが存在する基本的なKubernetesクラスタのブートストラップ手順を案内します。これにより、コアコンセプトを学習するには十分です。

コンポーネントのバージョン:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## ラボ

このチュートリアルには、同一ネットワークに接続された4台のARM64またはAMD64ベースの仮想／物理マシンが必要です。

* [前提条件](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [ジャンプボックスのセットアップ](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [コンピュートリソースのプロビジョニング](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [CAのプロビジョニングとTLS証明書の生成](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [認証用Kubernetes設定ファイルの生成](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [データ暗号化設定とキーの生成](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [etcdクラスタのブートストラップ](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Kubernetesコントロールプレーンのブートストラップ](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Kubernetesワーカーノードのブートストラップ](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [リモートアクセス用kubectlの設定](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Podネットワークルートのプロビジョニング](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [スモークテスト](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [クリーンアップ](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---