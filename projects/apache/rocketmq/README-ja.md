## Apache RocketMQ

[![Build Status][maven-build-image]][maven-build-url]
[![CodeCov][codecov-image]][codecov-url]
[![Maven Central][maven-central-image]][maven-central-url]
[![Release][release-image]][release-url]
[![License][license-image]][license-url]
[![Average Time to Resolve An Issue][percentage-of-issues-still-open-image]][percentage-of-issues-still-open-url]
[![Percentage of Issues Still Open][average-time-to-resolve-an-issue-image]][average-time-to-resolve-an-issue-url]
[![Twitter Follow][twitter-follow-image]][twitter-follow-url]

**[Apache RocketMQ](https://rocketmq.apache.org) は低遅延、高性能、高信頼性、兆単位の容量、柔軟なスケーラビリティを備えた分散メッセージングおよびストリーミングプラットフォームです。**


以下のような多様な機能を提供します：

* パブリッシュ/サブスクライブ、リクエスト/リプライ、ストリーミングなどのメッセージングパターン
* 金融グレードのトランザクションメッセージ
* [DLedger Controller](https://raw.githubusercontent.com/apache/rocketmq/develop/docs/en/controller/quick_start.md) に基づく組み込みのフォールトトレランスおよび高可用性構成オプション
* 組み込みのメッセージトレーシング機能、opentracingもサポート
* 多様なビッグデータおよびストリーミングエコシステムとの統合
* 時間またはオフセットによるメッセージの遡及性
* 同一キュー内での信頼性の高いFIFOおよび厳密な順序付けメッセージング
* 効率的なプルおよびプッシュ消費モデル
* 単一キューでの百万単位のメッセージ蓄積能力
* gRPC、MQTT、JMS、OpenMessagingなどの複数のメッセージングプロトコル
* 柔軟な分散スケールアウト展開アーキテクチャ
* 超高速バッチメッセージ交換システム
* SQLやタグなどの多様なメッセージフィルター機構
* 分離テストおよびクラウド分離クラスター用のDockerイメージ
* 構成、メトリクス、監視のための機能豊富な管理ダッシュボード
* 認証と認可
* ソースおよびシンク向けの無料オープンソースコネクター
* 軽量リアルタイムコンピューティング
----------


## クイックスタート

この段落では、RocketMQをさまざまな方法でインストールする手順を案内します。
ローカル開発およびテストのために、各コンポーネントにつき1つのインスタンスのみが作成されます。

### RocketMQをローカルで実行する

RocketMQは主要なすべてのオペレーティングシステムで動作し、Java JDKバージョン8以上のインストールのみが必要です。
確認するには、`java -version`を実行してください：
```shell
$ java -version
java version "1.8.0_121"
```
Windowsユーザーは、[こちら](https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip)をクリックして5.3.3 RocketMQバイナリリリースをダウンロードし、  
ローカルディスク（例：`D:\rocketmq`）に展開してください。  
macOSおよびLinuxユーザーは、以下のコマンドを実行してください：  


```shell
# Download release from the Apache mirror
$ wget https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip

# Unpack the release
$ unzip rocketmq-all-5.3.3-bin-release.zip
```

ターミナルを準備し、解凍した `bin` ディレクトリに移動します:
```shell
$ cd rocketmq-all-5.3.3-bin-release/bin
```

**1) NameServerの起動**

NameServerは`0.0.0.0:9876`で待機します。ローカルマシンで他のプロセスがこのポートを使用していないことを確認し、以下の操作を行ってください。

macOSおよびLinuxユーザーの場合：
```shell
### start Name Server
$ nohup sh mqnamesrv &

### check whether Name Server is successfully started
$ tail -f ~/logs/rocketmqlogs/namesrv.log
The Name Server boot success...
```

Windowsユーザーの場合、まず環境変数を設定する必要があります：
- デスクトップで、コンピューターアイコンを右クリックします。
- コンテキストメニューから「プロパティ」を選択します。
- 「システムの詳細設定」リンクをクリックします。
- 「環境変数」をクリックします。
- 環境変数 `ROCKETMQ_HOME="D:\rocketmq"` を追加します。

次に、rocketmqのディレクトリに移動し、タイプして実行します：
```shell
$ mqnamesrv.cmd
The Name Server boot success...
```

**2) ブローカーの起動**

macOSおよびLinuxユーザー向け：
```shell
### start Broker
$ nohup sh bin/mqbroker -n localhost:9876 &

### check whether Broker is successfully started, eg: Broker's IP is 192.168.1.2, Broker's name is broker-a
$ tail -f ~/logs/rocketmqlogs/broker.log
The broker[broker-a, 192.169.1.2:10911] boot success...
```

Windowsユーザー向け:
```shell
$ mqbroker.cmd -n localhost:9876
The broker[broker-a, 192.169.1.2:10911] boot success...
```

### DockerでRocketMQを実行する

Dockerコンテナ内の自分のマシンでRocketMQを実行できます。  
`host` ネットワークを使用して、コンテナ内のリッスンポートを公開します。

**1) NameServerを起動する**

```shell
$ docker run -it --net=host apache/rocketmq ./mqnamesrv
```

**2) ブローカーの起動**

```shell
$ docker run -it --net=host --mount type=bind,source=/tmp/store,target=/home/rocketmq/store apache/rocketmq ./mqbroker -n localhost:9876
```

### KubernetesでRocketMQを実行する

[Kubernetes Operator](https://github.com/apache/rocketmq-operator)を使用して、Kubernetesクラスター内でRocketMQクラスターを実行することもできます。
操作を開始する前に、マシンに`kubectl`および関連するkubeconfigファイルがインストールされていることを確認してください。

**1) CRDのインストール**
```shell
### install CRDs
$ git clone https://github.com/apache/rocketmq-operator
$ cd rocketmq-operator && make deploy

### check whether CRDs is successfully installed
$ kubectl get crd | grep rocketmq.apache.org
brokers.rocketmq.apache.org                 2022-05-12T09:23:18Z
consoles.rocketmq.apache.org                2022-05-12T09:23:19Z
nameservices.rocketmq.apache.org            2022-05-12T09:23:18Z
topictransfers.rocketmq.apache.org          2022-05-12T09:23:19Z

### check whether operator is running
$ kubectl get pods | grep rocketmq-operator
rocketmq-operator-6f65c77c49-8hwmj   1/1     Running   0          93s
```

**2) クラスターインスタンスの作成**
```shell
### create RocketMQ cluster resource
$ cd example && kubectl create -f rocketmq_v1alpha1_rocketmq_cluster.yaml

### check whether cluster resources is running
$ kubectl get sts
NAME                 READY   AGE
broker-0-master      1/1     107m
broker-0-replica-1   1/1     107m
name-service         1/1     107m
```

---
## Apache RocketMQ コミュニティ
* [RocketMQ Streams](https://github.com/apache/rocketmq-streams): Apache RocketMQ に基づく軽量ストリームコンピューティングエンジン。
* [RocketMQ Flink](https://github.com/apache/rocketmq-flink): データストリームとテーブルのソースおよびシンクコネクタをサポートする Apache Flink の Apache RocketMQ コネクタ。
* [RocketMQ APIs](https://github.com/apache/rocketmq-apis): RocketMQ protobuf プロトコル。
* [RocketMQ Clients](https://github.com/apache/rocketmq-clients): gRPC/protobuf ベースの RocketMQ クライアント。
* RocketMQ Remoting ベースのクライアント
	 - [RocketMQ Client CPP](https://github.com/apache/rocketmq-client-cpp)
	 - [RocketMQ Client Go](https://github.com/apache/rocketmq-client-go)
	 - [RocketMQ Client Python](https://github.com/apache/rocketmq-client-python)
	 - [RocketMQ Client Nodejs](https://github.com/apache/rocketmq-client-nodejs)
* [RocketMQ Spring](https://github.com/apache/rocketmq-spring): Apache RocketMQ を Spring Boot と迅速に統合するのを支援するプロジェクト。
* [RocketMQ Exporter](https://github.com/apache/rocketmq-exporter): Prometheus 用の Apache RocketMQ エクスポーター。
* [RocketMQ Operator](https://github.com/apache/rocketmq-operator): Kubernetes 上で Apache RocketMQ クラスターを実行する方法を提供。
* [RocketMQ Docker](https://github.com/apache/rocketmq-docker): Apache RocketMQ の Docker イメージの Git リポジトリ。
* [RocketMQ Dashboard](https://github.com/apache/rocketmq-dashboard): Apache RocketMQ の運用および保守コンソール。
* [RocketMQ Connect](https://github.com/apache/rocketmq-connect): Apache RocketMQ と他システム間でスケーラブルかつ信頼性の高いデータストリーミングを実現するツール。
* [RocketMQ MQTT](https://github.com/apache/rocketmq-mqtt): 新しい MQTT プロトコルアーキテクチャモデルで、これにより Apache RocketMQ は IoT デバイスやモバイルアプリなどの端末からのメッセージをより良くサポート可能。
* [RocketMQ EventBridge](https://github.com/apache/rocketmq-eventbridge): イベント駆動型アプリケーションの構築を容易にする EventBridge。
* [RocketMQ インキュベーティング コミュニティプロジェクト](https://github.com/apache/rocketmq-externals): Apache RocketMQ のインキュベータコミュニティプロジェクトで、[logappender](https://github.com/apache/rocketmq-externals/tree/master/logappender)、[rocketmq-ansible](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-ansible)、[rocketmq-beats-integration](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-beats-integration)、[rocketmq-cloudevents-binding](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-cloudevents-binding) などを含む。
* [RocketMQ Site](https://github.com/apache/rocketmq-site): Apache RocketMQ ウェブサイトのリポジトリ。
* [RocketMQ E2E](https://github.com/apache/rocketmq-e2e): Apache RocketMQ のエンドツーエンド、パフォーマンス、互換性テストを含むテストプロジェクト。


----------
## 学び方とお問い合わせ
* メーリングリスト: <https://rocketmq.apache.org/about/contact/>
* ホーム: <https://rocketmq.apache.org>
* ドキュメント: <https://rocketmq.apache.org/docs/quick-start/>
* イシュー: <https://github.com/apache/rocketmq/issues>
* Rips: <https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal>
* 質問: <https://stackoverflow.com/questions/tagged/rocketmq>
* Slack: <https://rocketmq-invite-automation.herokuapp.com/>


----------



## コントリビューティング
些細な修正から[大きな新機能](https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal)やその他の報酬まで、新しい貢献を常に歓迎しています。詳細は[こちら](http://rocketmq.apache.org/docs/how-to-contribute/)をご覧ください。

----------
## ライセンス
[Apache License, Version 2.0](http://www.apache.org/licenses/LICENSE-2.0.html) 著作権 (C) Apache Software Foundation


----------
## 輸出管理通知
この配布物には暗号化ソフトウェアが含まれています。現在居住している国によっては、
暗号化ソフトウェアの輸入、所持、使用、および/または他国への再輸出に制限がある場合があります。
暗号化ソフトウェアを使用する前に、輸入、所持、使用、および再輸出が許可されているかどうかを確認するために、
自国の法律、規制、および方針を必ず確認してください。詳細は
<http://www.wassenaar.org/> を参照してください。

米国商務省産業安全保障局（BIS）は、
本ソフトウェアを輸出商品管理番号（ECCN）5D002.C.1に分類しています。
これは、非対称アルゴリズムを用いた暗号機能を使用または実行する情報セキュリティソフトウェアに該当します。
Apache Software Foundationのこの配布形態は、
オブジェクトコードおよびソースコードの両方に対して、
ライセンス例外ENCテクノロジーソフトウェア無制限（TSU）例外（BIS輸出管理規則、第740.13節）に基づき
輸出が認められています。

以下は、含まれる暗号化ソフトウェアの詳細です：

本ソフトウェアはApache Commons Crypto (https://commons.apache.org/proper/commons-crypto/) を使用して、
認証およびサービス間でネットワークを介して送信されるデータの暗号化と復号をサポートしています。

[maven-build-image]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml/badge.svg
[maven-build-url]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml
[codecov-image]: https://codecov.io/gh/apache/rocketmq/branch/master/graph/badge.svg
[codecov-url]: https://codecov.io/gh/apache/rocketmq
[maven-central-image]: https://maven-badges.herokuapp.com/maven-central/org.apache.rocketmq/rocketmq-all/badge.svg
[maven-central-url]: http://search.maven.org/#search%7Cga%7C1%7Corg.apache.rocketmq
[release-image]: https://img.shields.io/badge/release-download-orange.svg
[release-url]: https://www.apache.org/licenses/LICENSE-2.0.html
[license-image]: https://img.shields.io/badge/license-Apache%202-4EB1BA.svg
[license-url]: https://www.apache.org/licenses/LICENSE-2.0.html
[average-time-to-resolve-an-issue-image]: http://isitmaintained.com/badge/resolution/apache/rocketmq.svg
[average-time-to-resolve-an-issue-url]: http://isitmaintained.com/project/apache/rocketmq
[percentage-of-issues-still-open-image]: http://isitmaintained.com/badge/open/apache/rocketmq.svg
[percentage-of-issues-still-open-url]: http://isitmaintained.com/project/apache/rocketmq
[twitter-follow-image]: https://img.shields.io/twitter/follow/ApacheRocketMQ?style=social
[twitter-follow-url]: https://twitter.com/intent/follow?screen_name=ApacheRocketMQ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---