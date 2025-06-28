# free-for.dev

開発者やオープンソースの著者は、現在多くのサービスで無料枠が提供されていますが、それらすべてを見つけて情報に基づいた意思決定を行うには時間がかかります。

これは、ソフトウェア（SaaS、PaaS、IaaS など）およびその他の無料開発者向けサービスのリストです。

このリストの範囲は、インフラストラクチャ開発者（システム管理者、DevOps 実践者など）が有用と考えるものに限定しています。すべての無料サービスを愛していますが、トピックに沿っていることが望ましいです。時にはグレーゾーンとなることもあるため、このリストは主観的です。もしあなたの貢献が受け入れられなくても気を悪くしないでください。

このリストは、1600人以上の人々によるプルリクエスト、レビュー、アイデア、および作業の結果です。あなたも[Pull Requests](https://github.com/ripienaar/free-for-dev)を送ることで、さらに多くのサービスを追加したり、提供内容が変更・終了したものを削除することで貢献できます。

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**注意**: このリストは as-a-Service の提供のみを対象とし、セルフホスト型ソフトウェアは対象外です。対象となるには、無料トライアルだけでなく無料枠が提供されている必要があります。時間制限がある場合、最低でも1年間の無料枠が必要です。また、セキュリティの観点から無料枠も考慮していますので、SSO（シングルサインオン）は問題ありませんが、TLSを有料のみで制限しているサービスは受け付けません。

# 目次

  * [主要クラウドプロバイダーの常時無料枠](#major-cloud-providers)
  * [クラウド管理ソリューション](#cloud-management-solutions)
  * [分析、イベント、統計](#analytics-events-and-statistics)
  * [API、データ、ML](#apis-data-and-ml)
  * [アーティファクトリポジトリ](#artifact-repos)
  * [BaaS](#baas)
  * [ローコードプラットフォーム](#low-code-platform)
  * [CDNと保護](#cdn-and-protection)
  * [CIとCD](#ci-and-cd)
  * [CMS](#cms)
  * [コード生成](#code-generation)
  * [コード品質](#code-quality)
  * [コード検索と閲覧](#code-search-and-browsing)
  * [クラッシュ・例外処理](#crash-and-exception-handling)
  * [地図上でのデータ可視化](#data-visualization-on-maps)
  * [マネージドデータサービス](#managed-data-services)
  * [デザインとUI](#design-and-ui)
  * [デザインインスピレーション](#design-inspiration)
  * [開発者向けブログサイト](#dev-blogging-sites)
  * [DNS](#dns)
  * [Docker関連](#docker-related)
  * [ドメイン](#domain)
  * [教育・キャリア開発](#education-and-career-development)
  * [メール](#email)
  * [フィーチャートグル管理プラットフォーム](#feature-toggles-management-platforms)
  * [フォント](#font)
  * [フォーム](#forms)
  * [生成AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDEとコードエディタ](#ide-and-code-editing)
  * [国際モバイル番号認証API・SDK](#international-mobile-number-verification-api-and-sdk)
  * [課題管理・プロジェクト管理](#issue-tracking-and-project-management)
  * [ログ管理](#log-management)
  * [モバイルアプリ配布・フィードバック](#mobile-app-distribution-and-feedback)
  * [管理システム](#management-system)
  * [メッセージング・ストリーミング](#messaging-and-streaming)
  * [その他](#miscellaneous)
  * [モニタリング](#monitoring)
  * [PaaS](#paas)
  * [パッケージビルドシステム](#package-build-system)
  * [決済・請求連携](#payment-and-billing-integration)
  * [プライバシー管理](#privacy-management)
  * [スクリーンショットAPI](#screenshot-apis)
  * [Flutter関連・MacなしでのiOSアプリビルド](#flutter-related-and-building-ios-apps-without-mac)
  * [検索](#search)
  * [セキュリティ・PKI](#security-and-pki)
  * [認証・認可・ユーザー管理](#authentication-authorization-and-user-management)
  * [ソースコードリポジトリ](#source-code-repos)
  * [ストレージ・メディア処理](#storage-and-media-processing)
  * [トンネリング、WebRTC、WebSocketサーバー、その他ルーター](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [テスト](#testing)
  * [チーム・コラボレーションツール](#tools-for-teams-and-collaboration)
  * [翻訳管理](#translation-management)
  * [Vagrant関連](#vagrant-related)
  * [訪問者セッション録画](#visitor-session-recording)
  * [Webホスティング](#web-hosting)
  * [コメントプラットフォーム](#commenting-platforms)
  * [ブラウザベースのハードウェアエミュレーション（JavaScript製）](#browser-based-hardware-emulation-written-in-javascript)
  * [リモートデスクトップツール](#remote-desktop-tools)
  * [ゲーム開発](#game-development)
  * [その他の無料リソース](#other-free-resources)

## 主要クラウドプロバイダー

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 1日あたり28フロントエンドインスタンス時間、1日あたり9バックエンドインスタンス時間
    * Cloud Firestore - 1GBストレージ、1日あたり50,000リード、20,000ライト、20,000デリート
    * Compute Engine - 1つの非プリエンプティブe2-micro、30GB HDD、5GBスナップショットストレージ（特定のリージョン限定）、北米からすべてのリージョン宛（中国・オーストラリア除く）への1GBネットワークエグレス（月次）
    * Cloud Storage - 5GB、1GBネットワークエグレス
    * Cloud Shell - WebベースのLinuxシェル/主要IDE、永続ストレージ5GB。週あたり60時間制限
    * Cloud Pub/Sub - 月あたり10GBメッセージ
    * Cloud Functions - 月あたり200万回呼び出し（バックグラウンドとHTTP呼び出しの両方を含む）
    * Cloud Run - 月あたり200万リクエスト、360,000 GB-秒メモリ、180,000 vCPU-秒計算時間、北米からのネットワークエグレス1GB（月次）
    * Google Kubernetes Engine - 1ゾーンのクラスタに対しクラスタ管理料金無料。各ユーザーノードは標準Compute Engine料金が適用
    * BigQuery - 月あたり1TBクエリ、月あたり10GBストレージ
    * Cloud Build - 1日あたり120ビルド分
    * Cloud Source Repositories - 最大5ユーザー、50GBストレージ、50GBエグレス
    * [Google Colab](https://colab.research.google.com/) - 無料のJupyter Notebooks開発環境
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio（旧Project IDX）。Google Cloud上で動作するオンラインVSCode
    * 詳細なリスト - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 月あたり1TBエグレス、月あたり200万回のFunction呼び出し
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10カスタムメトリクス、10アラーム
* [CodeBuild](https://aws.amazon.com/codebuild/) - 月あたり100分のビルド時間
* [CodeCommit](https://aws.amazon.com/codecommit/) - 5人のアクティブユーザー、50GBのストレージ、および月あたり10,000リクエスト
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 月あたり1つのアクティブパイプライン
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GBのNoSQLデータベース
* [EC2](https://aws.amazon.com/ec2/) - t2.microまたはt3.microのインスタンスを月あたり750時間（12ヶ月間）。月あたり100GBの外部転送
* [EBS](https://aws.amazon.com/ebs/) - 汎用（SSD）またはマグネティックストレージを月あたり30GB（12ヶ月間）
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 月あたり750時間（12ヶ月間）
* [RDS](https://aws.amazon.com/rds/) - db.t2.micro、db.t3.micro、またはdb.t4g.microを月あたり750時間、汎用（SSD）ストレージ20GB、バックアップ用ストレージ20GB（12ヶ月間）
* [S3](https://aws.amazon.com/s3/) - 標準オブジェクトストレージ5GB、20,000回のGetリクエストおよび2,000回のPutリクエスト（12ヶ月間）
* [Glacier](https://aws.amazon.com/glacier/) - 長期オブジェクトストレージ10GB
* [Lambda](https://aws.amazon.com/lambda/) - 月あたり100万リクエスト
* [SNS](https://aws.amazon.com/sns/) - 月あたり100万件の公開
* [SES](https://aws.amazon.com/ses/) - 月あたり3,000通のメッセージ（12ヶ月間）
* [SQS](https://aws.amazon.com/sqs/) - 月あたり100万件のメッセージキューリクエスト
* 詳細なリスト - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1台のB1S Linux VM、1台のB1S Windows VM（12ヶ月間）
  * [App Service](https://azure.microsoft.com/services/app-service/) - 10個のWeb、モバイル、またはAPIアプリ（1日あたり60 CPU分）
  * [Functions](https://azure.microsoft.com/services/functions/) - 月あたり100万リクエスト
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - 高速かつ簡単で効率的な開発テスト環境を提供
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500,000オブジェクト
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 月あたり50,000名の保存ユーザー
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 5名のアクティブユーザー、無制限のプライベートGitリポジトリ
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — オープンソース用にLinux、macOS、Windowsで無制限の分単位利用が可能な10個の無料並列ジョブ
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 1日あたり8,000メッセージ
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 1つの無料パブリックロードバランサーIP（VIP）
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 100万件のプッシュ通知
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - インバウンド15GB（12ヶ月間）＆月あたり5GBの外部転送
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GBストレージ、1,000RUのプロビジョニングスループット
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — 無料SSL、認証/認可、カスタムドメインで静的アプリとサーバーレス関数を構築・デプロイ・ホスト
  * [Storage](https://azure.microsoft.com/services/storage/) - LRSファイルまたはBlobストレージ5GB（12ヶ月間）
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - コンピュータビジョン、翻訳、顔認識、ボット等のAI/ML API（無料枠あり、取引数制限）
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - AIベースの検索・インデックス化サービス、10,000ドキュメントまで無料
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - マネージドKubernetesサービス、クラスタ管理無料
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 月あたり100,000オペレーション
  * 詳細なリスト - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * コンピュート
     - 1/8 OCPUおよび1GBメモリのAMDベースCompute VMを2台
     - 4つのArmベースAmpere A1コアと24GBメモリを1台のVMまたは最大4台のVMとして利用可能
     - [アイドルと見なされた場合](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances)インスタンスは回収されます
  * ブロックボリューム - 2ボリューム、合計200GB（コンピュート用）
  * オブジェクトストレージ - 10GB
  * ロードバランサー - 10Mbpsの1インスタンス
  * データベース - 2DB、各20GB
  * モニタリング - 5億件の取り込みデータポイント、10億件の取得データポイント
  * 帯域幅 - 月あたり10TBの外部転送、x64ベースVMは50Mbpsに制限、ARMベースVMはコア数×500Mbps
  * パブリックIP - VM用IPv4が2つ、ロードバランサー用IPv4が1つ
  * 通知 - 月あたり100万件の配信オプション、月あたり1,000通のメール送信
  * 詳細なリスト - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cloudantデータベース - 1GBのデータストレージ
  * Db2データベース - 100MBのデータストレージ
  * API Connect - 月あたり50,000件のAPIコール
  * アベイラビリティモニタリング - 月あたり300万件のデータポイント
  * ログ分析 - 1日あたり500MBのログ
  * 詳細なリスト - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - 無制限ドメイン用の無料DNS、DDoS保護、CDN、無料SSL、ファイアウォールルールとページルール、WAF、ボット対策、無料アンメータードレートリミティング（ドメインごとに1ルール）、分析、メール転送
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - 最大50ユーザー、24時間のアクティビティログ、3拠点
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - ローカルで実行中のHTTPポートをtrycloudflare.comのランダムなサブドメイン経由でトンネル公開可能。[Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/)も利用可能。アカウント不要。より多くの機能（TCPトンネル、ロードバランシング、VPN）は[Zero Trust](https://www.cloudflare.com/products/zero-trust/)無料プランに含まれます。
  * [Workers](https://developers.cloudflare.com/workers/) - Cloudflareのグローバルネットワーク上でサーバーレスコードを無料デプロイ（1日10万リクエスト）
  * [Workers KV](https://developers.cloudflare.com/kv) - 1日10万回の読み取りリクエスト、1日1,000回の書き込み、削除、リストリクエスト、1GBの保存データ
  * [R2](https://developers.cloudflare.com/r2/) - 月あたり10GB、クラスAオペレーション月100万回、クラスBオペレーション月1,000万回
  * [D1](https://developers.cloudflare.com/d1/) - 1日500万行の読み取り、10万行の書き込み、1GBストレージ
  * [Pages](https://developers.cloudflare.com/pages/) - Cloudflareの高速かつ安全なグローバルネットワークでウェブアプリを開発・デプロイ。月500回のビルド、100個のカスタムドメイン、統合SSL、無制限の席、無制限のプレビューデプロイ、Cloudflare Workers連携によるフルスタック対応
  * [Queues](https://developers.cloudflare.com/queues/) - 月あたり100万オペレーション
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 月あたり1TBの無料（送信）トラフィック

**[⬆️ トップへ戻る](#table-of-contents)**

## クラウド管理ソリューション

* [Brainboard](https://www.brainboard.co) - クラウドインフラストラクチャをエンドツーエンドで視覚的に構築・管理できる共同ソリューション
* [Cloud 66](https://www.cloud66.com/) - 個人プロジェクトは無料（1台のデプロイサーバー、1つの静的サイト含む）。Cloud 66を使えば、サーバー管理の煩わしさなく、どのクラウドでもアプリの構築・デプロイ・成長が可能。
* [Pulumi](https://www.pulumi.com/) — おなじみのプログラミング言語やツールを使ってインフラを構築・デプロイ・管理できる最新のインフラコードプラットフォーム
* [terraform.io](https://www.terraform.io/) — Terraform Cloud。最大500リソースまでのリモートステート管理とチームコラボレーションが無料
* [scalr.com](https://scalr.com/) - ScalrはTerraform Automation and Collaboration（TACO）製品で、Terraformで管理されるインフラや構成のコラボレーションと自動化を強化します。Terraform CLI完全サポート、OPA統合、階層型構成モデル。SSO課金なし。全機能含む。月50回まで無料で利用可能
* [deployment.io](https://deployment.io) - deployment.ioはAWS上でのデプロイを自動化するサービス。無料プランでは開発者（1ユーザー）が無制限の静的サイト、Webサービス、環境をデプロイ可能。月20回のジョブ実行が無料、プレビューと自動デプロイも無料枠に含まれます

**[⬆️ トップへ戻る](#table-of-contents)**

## ソースコードリポジトリ

* [Bitbucket](https://bitbucket.org/) — 最大5ユーザーまでパブリック・プライベートGitリポジトリ無制限、PipelinesによるCI/CD
* [chiselapp.com](https://chiselapp.com/) — パブリック・プライベートFossilリポジトリ無制限
* [codebasehq.com](https://www.codebasehq.com/) — 1つの無料プロジェクト、100MBの容量、2ユーザー
* [Codeberg](https://codeberg.org/) — 無料かつオープンソースプロジェクト向けのパブリック/プライベートGitリポジトリ無制限（コラボレーター無制限）。[Forgejo](https://forgejo.org/)提供。静的サイトホスティングは[Codeberg Pages](https://codeberg.page/)、CI/CDは[Codeberg's CI](https://docs.codeberg.org/ci/)、翻訳ホスティングは[Codeberg Translate](https://translate.codeberg.org/)。パッケージ・コンテナホスティング、プロジェクト管理、課題管理も含む
* [GitGud](https://gitgud.io) — パブリック・プライベートリポジトリ無制限。永年無料。GitLab＆Sapphire提供。CI/CDは提供なし
* [GitHub](https://github.com/) — パブリック・プライベートリポジトリ無制限（コラボレーター無制限）。CI/CD、開発環境、静的ホスティング、パッケージ・コンテナホスティング、プロジェクト管理、AI Copilotを含む
* [gitlab.com](https://about.gitlab.com/) — 最大5名のコラボレーターでパブリック・プライベートGitリポジトリ無制限。CI/CD、静的ホスティング、コンテナレジストリ、プロジェクト管理、課題管理を含む
* [framagit.org](https://framagit.org/) — FramasoftのGitlabベースソフトウェアフォージ。CI、静的ページ、プロジェクトページ、課題管理を含む
* [heptapod.net](https://foss.heptapod.net/) — HeptapodはMercurial対応のGitLab Community Editionフレンドリーフォーク
* [ionicframework.com](https://ionicframework.com/appflow) - Ionicアプリ開発用のリポジトリとツール。ionicリポジトリも提供
* [NotABug](https://notabug.org) — フリーソフトウェアプロジェクト向けの無料コードコラボレーションプラットフォーム。Gitベース
* [OSDN](https://osdn.net/) - オープンソース開発者向けの無料サービス。SVN/Git/Mercurial/Bazaar/CVSリポジトリ提供
  * [Pagure.io](https://pagure.io) — Pagure.ioは、FOSSライセンスプロジェクト向けの無料かつオープンソースのソフトウェアコードコラボレーションプラットフォームで、Gitベースです。
  * [perforce.com](https://www.perforce.com/products/helix-teamhub) — 1GBのクラウドおよびGit、Mercurial、SVNリポジトリが無料です。
  * [pijul.com](https://pijul.com/) - 無制限で無料のオープンソース分散型バージョン管理システムです。その特徴はパッチの理論に基づいており、学習・利用・配布が簡単です。git/hg/svn/darcsの多くの課題を解決します。
  * [plasticscm.com](https://plasticscm.com/) — 個人、OSS、非営利団体向けは無料です。
  * [projectlocker.com](https://projectlocker.com) — 1つの無料プライベートプロジェクト（GitおよびSubversion）、50MBのスペース付き
  * [RocketGit](https://rocketgit.com) — Gitベースのリポジトリホスティング。無制限の公開およびプライベートリポジトリ。
  * [savannah.gnu.org](https://savannah.gnu.org/) - フリーソフトウェアプロジェクト（GNUプロジェクト用）の共同開発管理システムとして機能します。
  * [savannah.nongnu.org](https://savannah.nongnu.org/) - フリーソフトウェアプロジェクト（非GNUプロジェクト用）の共同開発管理システムとして機能します。

**[⬆️ トップに戻る](#table-of-contents)**

## APIs, Data, and ML

  * [JSONGrid](https://jsongrid.com) - 複雑なJSONデータを美しい表形式グリッドで可視化・編集・フィルタリングする無料ツール。リンク経由でJSONデータを保存・共有可能。
  * [Zerosheets](https://zerosheets.com) - Google Sheetsのスプレッドシートを強力なAPIに変換して、プロトタイプ、Webサイト、アプリなどを迅速に開発。月500リクエストまで無料。
  * [IP.City](https://ip.city) — 1日100回までIPジオロケーションリクエストが無料
  * [Abstract API](https://www.abstractapi.com) — IPジオロケーション、性別判定、メールバリデーション等、さまざまな用途のAPIスイート。
  * [Apify](https://www.apify.com/) — 任意のWebサイトのAPI作成やデータ抽出のためのWebスクレイピング＆自動化プラットフォーム。既製スクレイパー、統合プロキシ、カスタムソリューションあり。毎月$5分のプラットフォームクレジット付き無料プランあり。
  * [APITemplate.io](https://apitemplate.io) - シンプルなAPIやZapier・Airtableなどの自動化ツールで画像やPDFドキュメントを自動生成。CSS/HTML不要。無料プランは月50画像、テンプレート3つまで。
  * [APIToolkit.io](https://apitoolkit.io) - APIやバックエンドの動作を完全に把握するためのツール群。API契約の自動検証・監視機能付き。無料プランは1日最大10,000リクエストのサーバーをカバー。
  * [APIVerve](https://apiverve.com) - 120種類以上のAPIに無料で即アクセス。品質・一貫性・信頼性重視。無料プランは月50APIトークンまで。（2025-06-25時点でサービス停止の可能性あり）
  * [Arize AI](https://arize.com/) - モデル監視やデータ品質・性能変動などの根本原因究明を実現する機械学習オブザーバビリティ。2モデルまで無料。
  * [Maxim AI](https://getmaxim.ai/) - AIエージェントのシミュレーション・評価・監視。エンドツーエンドの評価・観測プラットフォームで、信頼性の高いAIエージェントを5倍以上速くデプロイ。インディ開発者や小規模チーム（3席）は永年無料。
  * [Beeceptor](https://beeceptor.com) - 数秒でREST APIをモックし、APIレスポンスを偽装など。1日50リクエスト、パブリックダッシュボード、オープンエンドポイント（ダッシュボードリンクを知っていれば誰でも送信・回答内容を閲覧可能）を無料提供。
  * [BigDataCloud](https://www.bigdatacloud.com/) - IPジオロケーション、リバースジオコーディング、ネットワークインサイト、メール・電話バリデーション、クライアント情報など、モダンWeb向けの高速・高精度・無料（無制限または月10K～50K回）のAPIを提供。
  * [Browse AI](https://www.browse.ai) — Web上のデータ抽出・監視。月1,000クレジット無料（同時1,000リクエスト相当）。
  * [BrowserCat](https://www.browsercat.com) - 自動化・スクレイピング・AIエージェントWebアクセス・画像/PDF生成等のためのヘッドレスブラウザーAPI。月1,000リクエスト無料プランあり。
  * [Calendarific](https://calendarific.com) - 200カ国以上対応の企業向け祝日APIサービス。無料プランは月500回まで。
  * [Canopy](https://www.canopyapi.co/) - Amazon.comの商品、検索、カテゴリデータ用GraphQL API。無料プランは月100回まで。
  * [Clarifai](https://www.clarifai.com) — カスタム顔認識・検出用画像API。AIモデルのトレーニングも可能。無料プランは月1,000回まで。
  * [Cloudmersive](https://cloudmersive.com/) — ドキュメント変換、ウイルススキャンなど幅広いAPIライブラリへのアクセスを提供するユーティリティAPIプラットフォーム。月600回、北米AZのみ、最大ファイルサイズ2.5MB。
  * [Colaboratory](https://colab.research.google.com) — Nvidia Tesla K80 GPUを利用できる無料WebベースのPythonノートブック環境。
  * [CometML](https://www.comet.com/site/) - 実験トラッキング、モデル運用管理、モデルレジストリ、完全なデータリネージに対応したMLOpsプラットフォーム。個人・アカデミックは無料。
  * [Commerce Layer](https://commercelayer.io) - あらゆるフロントエンドから注文を作成・管理できるコンポーザブルコマースAPI。開発者プランは月100注文・1,000SKUまで無料。
  * [Composio](https://composio.dev/) - AIエージェントやLLM向け統合プラットフォーム。エージェント型インターネットで200以上のツールを統合可能。
  * [Conversion Tools](https://conversiontools.io/) - ドキュメント・画像・動画・音声・電子書籍のオンラインファイルコンバーター。REST APIあり。Node.js、PHP、Python用ライブラリ提供。最大50GB（有料プラン）のファイル対応。無料プランはファイルサイズ20MB、変換回数30回/日・300回/月まで。
  * [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - 国・地域・州・都市・郵便番号など幅広い情報を提供するAPIおよびマイクロサービス。無料枠は1日100リクエストまで。
  * [Coupler](https://www.coupler.io/) - アプリ間のデータ同期ツール。ライブダッシュボードやレポートの作成、値の変換・操作、インサイトの収集・バックアップが可能。無料プランは1ユーザー・データ接続・データソース・データ送信先に制限、手動更新が必要。
  * [CraftMyPDF](https://craftmypdf.com) - ドラッグ＆ドロップエディタとシンプルなAPIで再利用可能なテンプレートからPDFを自動生成。無料プランは月100PDF、テンプレート3つまで。
  * [Crawlbase](https://crawlbase.com/) — プロキシ・インフラ・ブラウザ不要でWebサイトをクロール＆スクレイピング。キャプチャ自動解決、ブロック回避。最初の1,000回まで無料。
  * [CurlHub](https://curlhub.io) — APIコールのインスペクション・デバッグ用プロキシサービス。無料プランは月10,000リクエストまで。
  * [CurrencyScoop](https://currencyscoop.com) - フィンテックアプリ向けリアルタイム通貨データAPI。無料プランは月5,000回まで。
  * [Cube](https://cube.dev/) - データエンジニアやアプリ開発者がモダンデータストアからデータにアクセスし、一貫した定義に整理し、すべてのアプリケーションへ配信。Cube Cloudの無料枠は1日1,000クエリまで。
  * [Data Dead Drop](https://datadeaddrop.com) - シンプルで無料のファイル共有。アクセス後にデータは自動消去。ブラウザやCLIからアップロード・ダウンロード可能。
  * [Data Fetcher](https://datafetcher.com) - Airtableと任意のアプリ・APIをノーコードで接続。Airtable内でAPIリクエストを実行できるPostmanライクなUI。多数アプリとの事前統合。無料プランは月100回まで。
  * [Dataimporter.io](https://www.dataimporter.io) - Salesforceへのデータ接続・クリーニング・インポート用ツール。無料プランは月20,000レコードまで。
  * [Datalore](https://datalore.jetbrains.com) - Jetbrains製のPythonノートブック。月10GBストレージ、120時間実行可能。
  * [Data Miner](https://dataminer.io/) - WebページからCSVやExcelへのデータ抽出ができるブラウザ拡張機能（Google Chrome、MS Edge用）。無料プランは月500ページ。
  * [Datapane](https://datapane.com) - Pythonでインタラクティブなレポートを作成し、PythonスクリプトやJupyterノートブックをセルフサービスツールとしてデプロイできるAPI。
  * [DB-IP](https://db-ip.com/api/free) - 1IPあたり1日1,000リクエストの無料IPジオロケーションAPI。CC-BY 4.0ライセンスのliteデータベースも無料。
  * [DB Designer](https://www.dbdesigner.net/) — クラウド型DBスキーマ設計・モデリングツール。無料スタータープランはDBモデル2つ、各モデル10テーブルまで。
  * [DeepAR](https://developer.deepar.ai) — 1つのSDKでどのプラットフォームにも対応するAR顔フィルター。無料プランは月間アクティブユーザー（MAU）10人・最大4顔追跡まで。
  * [Deepnote](https://deepnote.com) - Jupyter互換・リアルタイム共同作業・クラウド実行対応の新しいデータサイエンスノートブック。無料枠は無制限の個人プロジェクト、無制限の基本マシン（5GB RAM/2vCPU）、3人までのチーム。
  * [Disease.sh](https://disease.sh/) — Covid-19関連アプリ構築用の正確なデータを提供する無料API。
  * [Doczilla](https://www.doczilla.app/) — HTML/CSS/JSコードから直接スクリーンショットやPDFを生成するSaaS API。無料プランは月250ドキュメント。
  * [Doppio](https://doppio.sh/) — 高度なレンダリング技術でPDF・スクリーンショットを生成＆プライベート保存するマネージドAPI。無料プランは月400枚まで。
  * [drawDB](https://drawdb.app/) — 無料・オープンソースのオンラインDBダイアグラムエディタ。サインアップ不要。
  * [dreamfactory.com](https://dreamfactory.com/) — モバイル・Web・IoTアプリ用のオープンソースREST APIバックエンド。任意のSQL/NoSQL DB、ファイルストレージ、外部サービスを接続すると、REST APIプラットフォームを自動生成。ライブドキュメントやユーザー管理も。
  * [Duply.co](https://duply.co) — APIやURLから動的画像を生成。テンプレートを一度作成すれば再利用可能。無料枠は20クレジット。
  * [DynamicDocs](https://advicement.io) - LaTeXテンプレートを使ってJSONからPDFドキュメントを生成するAPI。無料プランは月50回APIコールとテンプレートライブラリアクセス。
  * [Efemarai](https://efemarai.com) - MLモデルやデータのテスト・デバッグプラットフォーム。任意の計算グラフを可視化。ローカル利用は無料。
  * [ERD Lab](https://www.erdlab.io) —  開発者向け無料クラウドER図（エンティティリレーション図）ツール。無料トライアルは2プロジェクト・各10テーブル。
  * [ExtendsClass](https://extendsclass.com/rest-client-online.html) - 無料WebベースのHTTPクライアントでHTTPリクエスト送信可能。
  * [Export SDK](https://exportsdk.com) - ドラッグ＆ドロップテンプレートエディタ付きPDF生成API。SDKやノーコード統合も提供。無料プランは月250ページ、ユーザー無制限、テンプレート3つまで。
  * [file.coffee](https://file.coffee/) - 1ファイル最大15MB（アカウント登録で30MB）まで保存できるプラットフォーム。
  * [Financial Data](https://financialdata.net/) - 株式市場・金融データAPI。無料プランは1日300リクエスト。
  * [FormatJSONOnline.com](https://formatjsononline.com) - JSONデータを即座に整形・検証・比較・圧縮できる無料ブラウザツール。
  * [FraudLabs Pro](https://www.fraudlabspro.com) — クレジットカード決済詐欺を検出する取引スクリーニングREST API。入力パラメータに基づく詐欺傾向を網羅検出。無料Microプランは月500トランザクション。
  * [GeoDataSource](https://www.geodatasource.com) — 緯度経度座標から都市名を検索できるロケーション検索サービス。無料APIは月500回まで。
  * [Geolocated.io](https://geolocated.io) — 複数大陸サーバー対応のIPジオロケーションAPI。1日2,000回まで無料プランあり。
  * [Glitterly](https://glitterly.app/) - ベーステンプレートから動的画像をプログラム生成。Restful APIやノーコード統合も対応。無料枠は月50画像・テンプレート5つまで。
  * [Hex](https://hex.tech/) - ノートブック・データアプリ・ナレッジライブラリ向け共同作業型データプラットフォーム。無料コミュニティ枠は5プロジェクトまで。
  * [Hook0](https://www.hook0.com/) - オンライン製品が簡単にWebhookを提供できるオープンソースWebhooks-as-a-service（WaaS）。無料で1日100イベント・7日間の履歴保持。
  * [Hoppscotch](https://hoppscotch.io) - 無料・高速・美しいAPIリクエストビルダー。
  * [huggingface.co](https://huggingface.co) - Pytorch、TensorFlow、JAX用NLPモデルの構築・トレーニング・デプロイが可能。無料枠は月30,000インプット文字まで。
  * [Hybiscus](https://hybiscus.dev/) - シンプルな宣言型APIでPDFレポート作成。14日間の無料枠はシングルページレポート50件、配色やフォントのカスタマイズも可能。
  * [Invantive Cloud](https://cloud.invantive.com/) — Exact Online、Twinfield、ActiveCampaign、Vismaなど70以上の（クラウド）プラットフォームにInvantive SQLまたはOData4（主にPower BI/Power Query）で接続。データ複製・交換も。開発者・導入コンサルタントは無料。特定プラットフォームはデータ量制限付きで無料。
  * [ipaddress.sh](https://ipaddress.sh) — 公開IPアドレスをさまざまな[形式](https://about.ipaddress.sh/)で取得できるシンプルサービス。
  * [ip-api](https://ip-api.com) — IPジオロケーションAPI。非商用利用は無料、APIキー不要。同一IPからは1分間あたり45回制限。
  * [ipbase.com](https://ipbase.com) - IPジオロケーションAPI。月150リクエストまで永久無料プラン。
  * [IP Geolocation](https://ipgeolocation.io/) — IPジオロケーションAPI。開発者向け永久無料プランで1日1,000リクエスト制限。
  * [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — Abstract提供のIPジオロケーションAPI。無料枠は1,000回。
  * [IPLocate](https://www.iplocate.io) — IPジオロケーションAPI。1日1,000回まで無料。プロキシ/VPN/ホスティング検出、ASNデータ、IP-企業情報等も提供。IP to Country、IP to ASNのCSV/MMDBデータベースも無料DL可能。
  * [IP2Location](https://www.ip2location.com) — フリーミアムIPジオロケーションサービス。LITEデータベースは無料DL可。サーバーにインポートして都市・座標・ISP情報をローカル照会可能。
  * [IP2Location.io](https://www.ip2location.io/) — フリーミアム・高速・高信頼性のIPジオロケーションAPI。都市・座標・ISP等のデータ取得。無料プランは月50,000クレジット。500件のWHOIS・ホストドメイン検索も無料。ドメイン登録情報や特定IPのホストドメインを調査可能。有料プランで機能拡張。
  * [ipapi](https://ipapi.co/) - Kloudend, Inc提供のIPアドレス位置API。AWS上で稼働し、フォーチュン500企業も利用。無料枠は月30,000回（1日1,000回）、サインアップ不要。
  * [ipapi.is](https://ipapi.is/) - 開発者による開発者のためのIPアドレスAPI。最高のホスティング検出機能。サインアップ不要で1,000回まで無料。
  * [IPinfo](https://ipinfo.io/) — 高速・高精度・無料（最大月50,000回）のIPアドレスデータAPI。ジオロケーション、企業、キャリア、IPレンジ、ドメイン、アビューズ連絡先等のAPI提供。すべての有料APIを無料試用可。
  * [IPQuery](https://ipquery.io) — 開発者向けの無制限IP API、レートリミットや料金なし。
  * [IPTrace](https://iptrace.io) — 信頼性の高いIPジオロケーションデータを1ヶ月50,000回まで無料で提供するシンプルなAPI。
  * [JSON2Video](https://json2video.com) - 動画マーケティングやSNS動画の自動化API。プログラムまたはノーコードで利用可能。
  * [JSON IP](https://getjsonip.com) — クライアントのパブリックIPアドレスを返すサービス。無料枠は登録不要。CORS対応、クライアントサイドJSから直接取得可能。クライアントやサーバーIP変化の監視等に有用。リクエスト無制限。
  * [JSON Serve](https://jsonserve.com/) — 開発者がJSONオブジェクトを保存し、REST APIとしてアプリで利用できる無料サービス。
  * [JSONing](https://jsoning.com/api/) — JSONオブジェクトから偽のREST APIを作成し、HTTPステータスコード・ヘッダー・レスポンスボディもカスタマイズ可能。
  * [konghq.com](https://konghq.com/) — APIマーケットプレイスと高機能なプライベート/パブリックAPIツール。無料枠はモニタリング、アラート、サポート等が制限。
  * [Kreya](https://kreya.app) — gRPC APIを呼び出し・テストする無料gRPC GUIクライアント。サーバーリフレクション経由でgRPC APIをインポート可能。
  * [Lightly](https://www.lightly.ai/) — 適切なデータで機械学習モデルの性能向上。最大1,000サンプルまで無料利用可能。
  * [LoginLlama](https://loginllama.app) - 不正・疑わしいログインを検出し顧客に通知するログインセキュリティAPI。月1,000件まで無料。
  * [MailboxValidator](https://www.mailboxvalidator.com) — 本物のメールサーバー接続を利用したメールアドレス検証サービス。無料APIプランは月100件まで検証可能。
  * [Market Data API](https://www.marketdata.app) - 株式・オプション・投資信託などのリアルタイム・過去金融データを提供。Free Forever APIプランは1日100回のAPIリクエストが無料。
* [Meteosource Weather API](https://www.meteosource.com/) — 世界中の天気データに対応したAPI。現在および予測気象データを提供。予報は複数の気象モデルを機械学習で組み合わせ、高精度を実現。無料プランは1日400回まで利用可能。
* [microlink.io](https://microlink.io/) – 任意のウェブサイトをデータ化（メタタグ正規化、美しいリンクプレビュー、スクレイピング、スクリーンショットサービスなど）。毎日50リクエスト無料。
* [Mindee](https://developers.mindee.com) – 強力なOCRソフトウェアおよびAPIファーストのプラットフォーム。コンピュータビジョンと機械学習による主要情報のデータ認識で、アプリケーションのワークフローを自動化。無料枠は月500ページ。
* [Mintlify](https://mintlify.com) — 最新のAPIドキュメント標準。美しくメンテナンスしやすいUIコンポーネント、アプリ内検索、インタラクティブなプレイグラウンドを提供。1名の編集者まで無料。
* [MockAPI](https://www.mockapi.io/) — APIのモック作成、カスタムデータ生成、RESTfulインターフェースによる操作が手軽に可能。プロトタイピング、テスト、学習向け。1プロジェクトにつき2リソースまで無料。
* [Mockfly](https://www.mockfly.dev/) — APIモックとフィーチャーフラグ管理用の開発ツール。直感的なインターフェースでモックAPIを素早く生成・管理。無料プランは1日500リクエスト。
* [Mocki](https://mocki.io) - GitHubリポジトリと同期したGraphQLおよびREST APIのモック作成ツール。シンプルなREST APIはサインアップ不要で無料開発・利用可能。
* [Mocko.dev](https://mocko.dev/) — APIプロキシ、クラウドでモック化するエンドポイント選択やトラフィック検査が無料。開発や統合テストを高速化。
* [Mocky](https://designer.mocky.io/) - HTTPリクエストのモック用カスタムHTTPレスポンス生成Webアプリ。[オープンソース](https://github.com/julien-lafont/Mocky)としても利用可能。
* [Mock N Roll](https://mpcknroll.me/) - 無料のモックAPIサービス。本物のAPIレスポンスを遅延なくシミュレート。フロントエンド開発・QA・DevOps向け。[リポジトリ](https://github.com/haerulmuttaqin/mocknroll-web)。
* [microenv.com](https://microenv.com) — Dockerコンテナ内でコードやアプリを自動生成できる、開発者向けのフェイクREST API生成サービス。
* [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — 複数ノードを通してエグジットIPアドレスをチェックし、地域やサービスごとのIP表示を確認できる無料ツール。Control DなどのDNS分割ツールのテストに便利。
* [Namekit](https://namekit.app/) - AIによるドメイン発見。即時に利用可能な標準価格のドメイン名を無料で毎日検索可能。
* [News API](https://newsapi.org) — コードでウェブニュース検索、JSON結果を取得。開発者は1日100クエリまで無料。記事は24時間遅延あり。
* [numlookupapi.com](https://numlookupapi.com) - 無料の電話番号バリデーションAPI。月100リクエスト無料。
* [OCR.Space](https://ocr.space/) — 画像やPDFファイルを解析し、テキスト結果をJSONで返すOCR API。月25,000リクエストまで、1MBファイルサイズ制限あり。
* [OpenAPI3 Designer](https://openapidesigner.com/) — Open API 3定義を無料でビジュアル作成。
* [parsehub.com](https://parsehub.com/) — 動的サイトからデータ抽出、API化。5プロジェクト無料。
* [Parseur](https://parseur.com) — PDFやメールからデータ抽出（AI搭載）。月20ページまで無料、API全機能利用可能。
* [PDFBolt](https://pdfbolt.com) - 開発者向けのPDF生成API。Stripe風ドキュメント。月500回の無料PDF変換。
* [pdfEndpoint.com](https://pdfendpoint.com) - シンプルなAPIでHTMLやURLをPDF変換。月100回まで無料。
* [PDF-API.io](https://pdf-api.io) - PDF自動化API、ビジュアルテンプレートエディタやHTML→PDF、動的データ統合対応。無料プランはテンプレート1つ、月100PDFまで。
* [Pixela](https://pixe.la/) - 無料のデイストリームDBサービス。全操作はAPI経由。ヒートマップや折れ線グラフで可視化も可能。
* [Postman](https://postman.com) — API開発コラボプラットフォーム。Postmanアプリは永年無料。クラウド機能も一部制限で無料。
* [Insomnia](https://insomnia.rest) - RESTやGraphQLに対応したオープンソースAPIクライアント。
* [PrefectCloud](https://www.prefect.io/cloud/) — データフロー自動化プラットフォーム。無料プランは5ワークフロー、月500分サーバレス実行枠。
* [Preset Cloud](https://preset.io/) - Apache Supersetホスティング。最大5ユーザー、無制限ダッシュボード・グラフ、ノーコードチャートビルダー、コラボSQLエディタを永年無料。
* [PromptLoop](https://www.promptloop.com/) - AIによるWebスクレイピング自動化。REST API対応。月1,000クレジット無料。
* [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — 無料公開APIのリスト。
* [Rapidapi](https://rapidapi.com/) - 世界最大級のAPIハブ。数千のAPI検索・接続、API開発用チャレンジや例も提供。
* [RequestBin.com](https://requestbin.com) — 無料のエンドポイント作成。HTTPリクエスト送信時にペイロードやヘッダーを記録、webhookや各種サービスの挙動観察に便利。
* [reqres.in](https://reqres.in) - AJAXリクエストに応答する無料ホスト型REST API。
* [Roboflow](https://roboflow.com) - 機械学習経験不要でカスタム画像認識モデルを作成・デプロイ。無料枠は月30クレジット。
* [ROBOHASH](https://robohash.org/) - 任意のテキストからユニークでクールな画像を生成するWebサービス。
* [Scraper's Proxy](https://scrapersproxy.com) — シンプルなHTTPプロキシAPIで匿名スクレイピング。月100回まで無料（JavaScriptレンダリング対応、追加枠は要問合せ）。
* [ScrapingAnt](https://scrapingant.com/) — ヘッドレスChromeによるスクレイピングAPI、無料のプロキシサービス。JavaScript対応、回転プロキシ、CAPTCHA回避。1万APIクレジット無料。
* [Simplescraper](https://simplescraper.io) — 各操作後webhookをトリガー。無料プランは100クラウドスクレイプクレジット。
* [Select Star](https://www.selectstar.com/) - データ自動分析・ドキュメント化のインテリジェントデータ発見プラットフォーム。無料ライト枠はデータソース2件、最大1,000テーブル、25ユーザー。
* [Sheetson](https://sheetson.com) - GoogleスプレッドシートをRESTful API化。無料プランはシートあたり1,000行まで。
* [Shipyard](https://www.shipyardapp.com) — クラウド向けローコードデータオーケストレーション。テンプレートやPython/Node.js/Bash/SQL混在でワークフロー構築。無料開発者プランは毎月10時間実行（1ユーザー）。
* [Siterelic](https://siterelic.com/) - スクリーンショット取得、Web監査、TLS/DNS/TTFBテスト等のAPI。無料プランは月100リクエスト。
* [SerpApi](https://serpapi.com/) - 検索エンジンのリアルタイムスクレイピングAPI。Google, YouTube, Bing, Baidu等に対応。無料プランは月100成功APIコール。
* [SmartParse](https://smartparse.io) - CSV→APIやデータ移行の開発者向けツール。無料枠は月300処理ユニット、ブラウザアップロード、データ検疫、サーキットブレーカー、ジョブ通知等。
* [Sofodata](https://www.sofodata.com/) - CSVファイルからRESTful APIを即作成。APIで高速開発可能。無料枠は2API・月2,500コール。クレジットカード不要。
* [Sqlable](https://sqlable.com/) - SQLフォーマッタ・バリデータ、SQL正規表現テスター、ダミーデータ生成、DBプレイグラウンド等の無料SQLツール群。
* [Stoplight](https://stoplight.io/) - API設計・ドキュメント作成SaaS。無料プランは設計・モック・ドキュメントツールを提供。
* [Supportivekoala](https://supportivekoala.com/) — テンプレートから入力に応じた画像を自動生成。無料プランは月50枚まで。
* [Svix](https://www.svix.com/) - Webhooks as a Service。月50,000メッセージ送信まで無料。
* [Tavily AI](https://tavily.com/) - オンライン検索・インサイト・研究API。研究結果の整理も可能。無料プランは月1,000リクエスト、クレカ不要。
* [The IP API](https://theipapi.com/) - IPジオロケーションAPI。1日1,000リクエスト無料。国・都市・地域等のIP情報を取得。
* [TinyMCE](https://www.tiny.cloud) - リッチテキストエディタAPI。コア機能は無制限で無料利用可能。
* [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - 天気APIの無料プラン。高精度な世界気象予報、過去データ、監視機能を提供。
* [Treblle](https://www.treblle.com) - API開発・運用支援。高度なログ集約、オブザーバビリティ、ドキュメント、デバッグ機能。全機能無料（無料枠は月25万リクエストまで）。
* [UniRateAPI](https://unirateapi.com) – 590以上の通貨・暗号のリアルタイム為替レート。無料プランはAPIコール無制限、開発や金融アプリに最適。
* [vatcheckapi.com](https://vatcheckapi.com) - シンプルで無料のVAT番号バリデーションAPI。月150回無料。
* [WeatherXu](https://weatherxu.com/) — 世界中の現在気象、予報、警報をAPIで提供。AI・MLモデルによる高精度予報。無料プランは月10,000コール。
* [Webhook Store](https://www.openwebhook.io) - サードパーティwebhookの保存・ローカルデバッグツール（ngrok風）。オープンソース・セルフホスト可。無料パーソナルドメイン *username*.github.webhook.store、無料パブリックドメイン *anything*.webhook.store。
* [WebScraping.AI](https://webscraping.ai) - 解析・Chromeレンダリング・プロキシ内蔵のシンプルなWebスクレイピングAPI。月2,000回無料。
* [Weights & Biases](https://wandb.ai) — 開発者向けMLOpsプラットフォーム。実験追跡、データセットバージョン管理、モデル管理でモデル開発効率化。個人プロジェクトは無料（100GBストレージ付）。
* [What The Diff](https://whatthediff.ai) - AIによるコードレビュー支援。無料プランは月25,000トークン（約10 PR）。
* [wolfram.com](https://wolfram.com/language/) — クラウドで知識ベースのアルゴリズムを利用可能。
* [wrapapi.com](https://wrapapi.com/) — 任意のウェブサイトをパラメータ化API化。月3万コール無料。
* [Zenscrape](https://zenscrape.com/web-scraping-api) — ヘッドレスブラウザ・住宅IP対応のWebスクレイピングAPI。月1,000回無料、学生・非営利向け追加枠あり。
* [Zipcodebase](https://zipcodebase.com) - 世界中の郵便番号データにアクセスできる無料Zip Code API。月5,000回無料。
* [Zipcodestack](https://zipcodestack.com) - 無料Zip Code APIおよび郵便番号バリデーション。月1万回まで無料。
* [Zuplo](https://zuplo.com/) - API管理プラットフォーム。APIキー認証、レート制限、ドキュメント、収益化などを数分で追加可能。OpenAPIネイティブ・TypeScript対応。無料プランは最大10プロジェクト、無制限の本番エッジ環境、月100万リクエスト、10GBエグレス。

**[⬆️ トップへ戻る](#table-of-contents)**

## Artifact Repos

* [Artifactory](https://jfrog.com/start-free/) - Maven、Docker、Cargo、Helm、PyPI、CocoaPods、GitLFSなど多数のパッケージフォーマットをサポートするアーティファクトリポジトリ。パッケージスキャンXRayとCI/CDツールPipelines（旧Shippable）付き。月2,000分のCI/CD無料枠。
* [central.sonatype.org](https://central.sonatype.org) — Apache Maven、SBT、その他ビルドシステムのデフォルトアーティファクトリポジトリ。
* [cloudrepo.io](https://cloudrepo.io) - クラウド型のプライベート・パブリックMaven/PyPiリポジトリ。オープンソースプロジェクトは無料。
* [cloudsmith.io](https://cloudsmith.io) — Java/Maven、RedHat、Debian、Python、Ruby、Vagrant等に対応したセキュアな集中リポジトリサービス。無料枠あり、OSSは無料。
* [jitpack.io](https://jitpack.io/) — GitHub上のJVM・Androidプロジェクト用Mavenリポジトリ。公開プロジェクトは無料。
* [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Maven、RPM、DEB、PyPi、NPM、RubyGemパッケージのホスティングを簡単に提供（無料枠あり）。
* [repsy.io](https://repsy.io) — 1GB無料のプライベート/パブリックMavenリポジトリ。
* [Gemfury](https://gemfury.com) — Maven、PyPi、NPM、Go Module、Nuget、APT、RPMリポジトリ向けのプライベート/パブリックアーティファクトリポ。公開プロジェクトは無料。
* [paperspace](https://www.paperspace.com/) — AIモデルの構築・スケーリング、開発・トレーニング・デプロイ。無料プランは公開プロジェクト、5GBストレージ、ベーシックインスタンス。
* [RepoForge](https://repoforge.io) - Python、Debian、NPMパッケージ、Dockerレジストリ用プライベートクラウドホスト型リポジトリ。OSS/公開プロジェクトは無料。
* [RepoFlow](https://repoflow.io) - npm、PyPI、Docker、Go、Helmなどをサポートするパッケージ管理を簡素化。クラウド10GBストレージ・10GB帯域・100パッケージ・無制限ユーザー、セルフホストは個人利用のみ無料。

**[⬆️ トップへ戻る](#table-of-contents)**

## チーム・コラボレーション向けツール
* [3Cols](https://3cols.com/) - 個人・チーム利用向けの無料クラウドコードスニペット管理ツール。
* [Bitwarden](https://bitwarden.com) — 個人・チーム・企業向けの機密データ保存・共有・同期の最も簡単かつ安全な方法。
* [Braid](https://www.braidchat.com/) — チーム向けチャットアプリ。パブリックグループは無制限ユーザー・履歴・連携が無料。OSS版セルフホストも提供。
* [cally.com](https://cally.com/) — 会議に最適な時間・日付を簡単に調整。小規模・大規模どちらにも最適。
* [Calendly](https://calendly.com) — 会議接続・スケジューリングツール。無料プランは1ユーザー1カレンダー連携・無制限セッション。デスクトップ・モバイルアプリも提供。
* [Discord](https://discord.com/) — パブリック/プライベートルームでチャット。Markdownテキスト、音声・ビデオ・画面共有も可能。ユーザー無制限で無料。
* [Fibo](https://fibo.dev) - アジャイルチーム向けの無料オンラインリアルタイムスクラムポーカー。ストーリーポイント見積もりが無制限メンバーで利用可能。
* [Telegram](https://telegram.org/) — 高速・信頼性のあるメッセージング・通話アプリ。大規模グループ、ユーザー名、デスクトップアプリ、ファイル共有も強力でビジネスや小規模チームにも最適。
* [DevToolLab](https://devtoollab.com) — 基本的な開発者ツールを全て無料で利用可能。各ツールで1件まで自動保存、標準処理速度、コミュニティサポート付き。
* [Dubble](https://dubble.so/) — 無料のステップバイステップガイド作成ツール。スクリーンショット、プロセス記録、チームとの共同編集。非同期画面録画も対応。
* [Duckly](https://duckly.com/) — チームでリアルタイム通話・コラボ。IDE・ターミナル共有、音声・ビデオ・画面共有。小規模チームは無料。
* [Dyte](https://dyte.io) - 開発者向けのライブビデオ・音声SDK。生産性向上プラグインも付属。無料枠は月10,000分。
* [evernote.com](https://evernote.com/) — 情報整理ツール。ノート共有・共同作業も可能。
* [Fibery](https://fibery.io/) — 連携型ワークスペースプラットフォーム。1ユーザーまで無料、2GBストレージ。
  * [flock.com](https://flock.com) — チームのコミュニケーションをより速くするツール。無制限のメッセージ、チャンネル、ユーザー、アプリ＆統合が無料。
  * [Gather](https://www.gather.town/) - オンラインでのより良いミーティング体験。完全にカスタマイズ可能なスペースを中心に、Gatherはコミュニティでの時間を現実と同じくらい簡単にします。最大10人の同時ユーザーまで無料。
  * [gokanban.io](https://gokanban.io) - シンタックスベース、登録不要のカンバンボード。制限なしで無料利用可能。
  * [flat.social](https://flat.social) - チームミーティングや懇親会用のインタラクティブでカスタマイズ可能なスペース。無制限のミーティング、最大8人の同時ユーザーまで無料。
  * [GitDailies](https://gitdailies.com) - チームのGitHubでのコミットやプルリクエストの活動を日次レポート。Push可視化、ピア認識システム、カスタムアラートビルダーを含む。無料プランで無制限ユーザー、3リポジトリ、3アラート設定。
  * [gitter.im](https://gitter.im/) — GitHub向けチャット。無制限のパブリック/プライベートルーム、最大25人のチームまで無料。
  * [Hackmd.io](https://hackmd.io/) - Markdown形式のドキュメント/ファイル用リアルタイム共同編集＆執筆ツール。Google DocsのMarkdown版。無制限の「ノート」が無料だが、プライベートノート＆テンプレートの共同編集者（招待者）数は[制限あり](https://hackmd.io/pricing)。
  * [hangouts.google.com](https://hangouts.google.com/) — すべての会話を1か所で、無料、Googleアカウントが必要
  * [HeySpace](https://hey.space) - チャット、カレンダー、タイムライン、ビデオ通話付きタスク管理ツール。最大5ユーザーまで無料。
  * [helplightning.com](https://www.helplightning.com/) — 拡張現実を用いたビデオサポート。アナリティクス、暗号化、サポートなしで無料利用可。
  * [ideascale.com](https://ideascale.com/) — クライアントがアイデア投稿・投票できるプラットフォーム。1コミュニティ25人まで無料。
  * [Igloo](https://www.igloosoftware.com/) — ドキュメント、ブログ、カレンダー等の社内ポータル。最大10ユーザーまで無料。
  * [Keybase](https://keybase.io/) — SlackのFOSS代替。ファミリーからコミュニティ、企業まで全員のチャット＆ファイルを安全に保護。
  * [Google Meet](https://meet.google.com/) — ビジネス向けオンラインビデオ会議。安全で簡単に参加できるオンライン会議を提供。
  * [/meet for Slack](https://meetslack.com) - Slackの任意のチャンネル、グループ、DMで/meetを使ってGoogle会議を直接開始。無制限で無料。
  * [Livecycle](https://www.livecycle.io/) — クロスファンクショナルなプロダクトチームやOSSプロジェクトのための包括的コラボレーションプラットフォーム。
  * [Lockitbot](https://www.lockitbot.com/) — Slack内で部屋、開発環境、サーバーなどの共有リソースの予約・ロック。最大2リソースまで無料。
  * [MarkUp](https://www.markup.io/) — Webサイト、PDF、画像上で直接フィードバック収集が可能。
  * [Proton Pass](https://proton.me/pass) — メールエイリアス内蔵パスワードマネージャー。2FA認証、共有、パスキー対応。Web/拡張/モバイル/デスクトップに対応。
  * [Visual Debug](https://visualdebug.com) - クライアントと開発者のコミュニケーションを改善するビジュアルフィードバックツール。
  * [meet.jit.si](https://meet.jit.si/) — ワンクリックでのビデオ会話と画面共有、無料。
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — 会話、コンテンツ、アプリを1つの体験でまとめるチャットベースのデジタルハブ。最大50万人まで無料。
  * [Miro](https://miro.com/) - 分散チーム向け、スケーラブルで安全なホワイトボード。フリーミアムプランあり。
  * [nootiz](https://www.nootiz.com/) - あらゆるWebサイト上でビジュアルフィードバックを収集・管理するためのツール。
  * [Notion](https://www.notion.so/) - タスク、Wiki、DB統合、Markdown対応のノート＆コラボアプリ。クロスプラットフォームアプリ＆Webアクセス可。
  * [Nuclino](https://www.nuclino.com) - チームの知識、ドキュメント、ノート用の軽量コラボWiki。主要機能が揃う無料プラン（最大50項目、5GBストレージ）。
  * [OnlineInterview.io](https://onlineinterview.io/) - ビデオチャット、描画ボード、オンラインコードエディタ統合の無料コーディング面接プラットフォーム。ワンクリックで面接ルーム作成。
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - シンプルなチーム用タイムシート＆タイムトラッキングアプリ。無料で最大10ユーザーのタイムトラッキング＆レポート作成機能。
  * [PageShare.dev](https://www.pageshare.dev) - Webサイトのデプロイ不要でGitHubプルリクエストにビジュアルレビュー機能追加。月10ページ・合計100MBストレージまで無料。
  * [Pendulums](https://pendulums.io/) - 使いやすいインターフェースと有益な統計で時間管理をサポートする無料タイムトラッキングツール。
  * [Pumble](https://pumble.com) - 無料のチームチャットアプリ。無制限ユーザー＆メッセージ履歴、永久無料。
  * [Raindrop.io](https://raindrop.io) - macOS/Windows/Android/iOS/Web向けのプライベート＆安全なブックマークアプリ。無制限のブックマーク＆コラボが無料。
  * [element.io](https://element.io/) — Matrixベースの分散型OSSコミュニケーションツール。グループチャット、DM、暗号化ファイル転送、音声＆ビデオチャット、他サービスとの連携容易。
  * [Rocket.Chat](https://rocket.chat/) - オムニチャネル機能、Matrix連携、他アプリとのBridge、無制限メッセージ＆履歴のOSSコミュニケーションプラットフォーム。
  * [seafile.com](https://www.seafile.com/) — プライベートまたはクラウドストレージ、ファイル共有、同期、ディスカッション。クラウド版は1GBのみ。
  * [Sema](https://www.semasoftware.com/) - 複数リポジトリの貢献を一つのレポートに統合・スナップショットできる無料開発者ポートフォリオツール。
  * [Screen Sharing via Browser](https://screensharing.net) - ダウンロードや登録不要で、ブラウザから画面を無料共有できるツール。
  * [Slab](https://slab.com/) — チーム向けの最新ナレッジマネジメントサービス。最大10ユーザーまで無料。
  * [slack.com](https://slack.com/) — 一部機能制限ありで無制限ユーザー無料
  * [Spectrum](https://spectrum.chat/) - パブリックまたはプライベートコミュニティを無料作成。
  * [StatusPile](https://www.statuspile.com/) - ステータスページのステータスページ。上流プロバイダのステータスを追跡可能？
  * [Stickies](https://stickies.app/) - ブレインストーミング、コンテンツキュレーション、メモ用ビジュアルコラボアプリ。最大3ウォール、無制限ユーザー、1GBストレージ無料。
  * [Stacks](https://betterstacks.com/) - ノート、リンク、ファイルストレージ統合の情報整理ワークスペース。永久無料パーソナルプラン。
  * [talky.io](https://talky.io/) — 匿名＆P2Pの無料グループビデオチャット。プラグイン、登録、支払い不要。
  * [Teamhood](https://teamhood.com/) - プロジェクト、タスク、課題追跡の無料ソフト。カンバン＆スクラム対応。タイムトラッキング統合。最大5ユーザー・3ポートフォリオまで無料。
  * [Teamplify](https://teamplify.com) - チーム分析＆スマートデイリースタンドアップで開発プロセスを改善。フル機能の休暇管理も。最大5ユーザーの小規模グループは無料。
  * [Tefter](https://tefter.io) - 高機能Slack連携付きブックマークアプリ。OSSチームは無料。
  * [TeleType](https://teletype.oorja.io/) — ターミナル、音声、コード、ホワイトボード等を共有。開発者向けエンドツーエンド暗号化コラボ、サインイン不要。
  * [TimeCamp](https://www.timecamp.com/) - 無制限ユーザーの無料タイムトラッキングソフト。Jira、Trello、Asana等PMツールと簡単連携。
  * [Huly](https://huly.io/) - オールインワンのプロジェクト管理（Linear、Jira、Slack、Notion、Motionの代替）。無制限ユーザー、ワークスペースごとに10GBストレージ、10GBビデオ(音声)トラフィック。
  * [Teamcamp](https://www.teamcamp.app) - ソフトウェア開発会社向けオールインワンプロジェクト管理アプリ。
  * [twist.com](https://twist.com) — 会話が整理される非同期チームコミュニケーションアプリ。無料＆無制限プランあり。該当チーム向け割引あり。
  * [tldraw.com](https://tldraw.com) — 無料OSSホワイトボード＆図作成ツール。インテリジェント矢印、スナッピング、付箋、SVGエクスポート機能。共同編集のマルチプレイヤーモード。VS Code公式拡張も無料。
  * [BookmarkOS.com](https://bookmarkos.com) - 無料のオールインワンブックマーク・タブ・タスク管理。フォルダコラボ対応のカスタマイズ可能なオンラインデスクトップ。
  * [typetalk.com](https://www.typetalk.com/) — Webやモバイルでチームとアイデアを即時メッセージで共有・議論
  * [Tugboat](https://tugboat.qa) - プルリクごとに自動＆オンデマンドでプレビュー。すべて無料、非営利向けナノティアあり。
  * [whereby.com](https://whereby.com/) — ワンクリックでの無料ビデオ会話（旧appear.in）
  * [windmill.dev](https://windmill.dev/) - Python/Typescriptスクリプトから本番グレードの自動化＆内部アプリを迅速構築できるOSS開発者プラットフォーム。無料ユーザーは最大3つの非プレミアムワークスペースを作成・参加可能。
  * [vadoo.tv](https://vadoo.tv/) — シンプルな動画ホスティング＆マーケ。ワンクリックアップロード。録画・管理・共有等。無料プランは最大10動画、1GBストレージ、月10GB帯域。
  * [userforge.com](https://userforge.com/) - オンラインでペルソナ・ユーザーストーリー・コンテキストマッピングを連携。最大3ペルソナ・2コラボレーターまで無料。
  * [wistia.com](https://wistia.com/) — ビュー解析、HD配信、マーケティングツール付き動画ホスティング。25動画、Wistiaロゴプレイヤー。
  * [wormhol.org](https://www.wormhol.org/) — シンプルなファイル共有サービス。最大5GBのファイルを無制限の相手と共有可能。
  * [Wormhole](https://wormhole.app/) - 最大5GBまでのファイルを24時間エンドツーエンド暗号化で共有。5GB超はP2P転送。
  * [zoom.us](https://zoom.us/) — セキュアなビデオ＆Web会議。無料プランは40分まで。
  * [Zulip](https://zulip.com/) — 独自のメールライクなスレッドモデルのリアルタイムチャット。無料プランで1万件検索履歴・5GBファイル保存。OSS版もあり。
  * [robocorp.com](https://robocorp.com) - Automation Ops向けOSSスタック。クラウド機能＆シンプル自動化を無料体験。ロボット作業240分/月、アシスタント10回、100MBストレージ。
  * [Fleep.io](https://fleep.io/) — Slack代替のFleep。フルメッセージ履歴、無制限1:1会話、1グループ、1GBストレージの無料プラン。
  * [Chanty.com](https://chanty.com/) — Slack代替のChanty。小規模チーム（最大10人）向け無料永年プラン。無制限のパブリック/プライベート会話、検索履歴、1:1音声通話、音声メッセージ、10連携、20GB/チーム。
  * [ruttl.com](https://ruttl.com/) — Webサイト・PDF・画像のデジタルフィードバック＆レビューを一括収集できる最良のツール。
  * [Mattermost](https://mattermost.com/) — 技術チーム向けセキュアコラボ。無制限チャンネル、プレイブック、ボード、ユーザー、10GBストレージ等の無料プラン。
  * [Webvizio](https://webvizio.com) — Webサイトフィードバック・レビュー・バグ報告ツール。WebサイトやWebアプリ、画像、PDF、デザインファイル上でのタスクコラボを効率化。
  * [Pullflow](https://pullflow.com) — GitHub、Slack、VS Code連携のAI強化コードレビューコラボプラットフォーム。
  * [Webex](https://www.webex.com/) — 無料プランで最大100人・40分/回のビデオ会議。
  * [RingCentral](https://www.ringcentral.com/) — 無料プランで最大100人・50分/回のビデオ会議。
  * [GitBook](https://www.gitbook.com/) — 技術知識の記録・ドキュメント化プラットフォーム（プロダクトドキュメントから社内ナレッジ、APIまで）。開発者向け無料プラン。
  * [transfernow](https://www.transfernow.net/) — 最もシンプル・高速・安全なファイル転送サービス。写真・動画等の大容量ファイルをサブスク不要で送信可能。
  * [paste.sh](https://paste.sh/) — JavaScriptとCryptoベースのシンプルなペーストサイト。
  * [Revolt.chat](https://revolt.chat/) — [Discord](https://discord.com/)のOSS代替でプライバシー重視。Discordの多くの独自機能が無料。すべての機能が無料で、（公式・非公式の）プラグインもサポート。
  * [Tencent RTC](https://trtc.io/) — Tencentのリアルタイム音声/ビデオ通話ソリューション。最初の1年間は月1万分無料。
  * [Pastefy](https://pastefy.app/) - クライアント暗号化、マルチタブペースト、API、強調エディタなどを備えた美しくシンプルなPastebin。
  * [SiteDots](https://sitedots.com/) - Webサイトプロジェクトのフィードバックを直接Webサイト上で共有。エミュレーションやキャンバス等不要。完全無料プランあり。

**[⬆️ Topに戻る](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Drupalサイト用ホスティング。開発者向け無料ティアあり。Acquia Dev Desktop等の無料開発ツールも提供。
  * [Contentful](https://www.contentful.com/) — ヘッドレスCMS。クラウド上のコンテンツ管理・配信API。無料のコミュニティスペース（5ユーザー、25,000レコード、48コンテンツタイプ、2ロケール）付き。
  * [Cosmic](https://www.cosmicjs.com/) — ヘッドレスCMS＆APIツールキット。開発者向け無料パーソナルプラン。
  * [Crystallize](https://crystallize.com) — EC対応ヘッドレスPIM。組み込みGraphQL API。無料版で無制限ユーザー、カタログ1,000点、月5GB帯域、月25,000 APIコール。
  * [DatoCMS](https://www.datocms.com/) - 小規模プロジェクト向け無料ティアあり。GraphQLベースCMS。下位ティアで月100,000コール。
  * [Directus](https://directus.io) — ヘッドレスCMS。オンプレまたはクラウドで資産やDBコンテンツを管理する完全無料＆OSSプラットフォーム。制限・有料壁なし。
  * [FrontAid](https://frontaid.io/) — JSONコンテンツをGitリポジトリに直接保存するヘッドレスCMS。制限なし。
  * [kontent.ai](https://www.kontent.ai) - マーケターにも強いContent-as-a-Service型ヘッドレスCMS。開発者プランは2ユーザー、無制限プロジェクト（各2環境）、500コンテンツ、2言語、Delivery/Management API、カスタム要素対応。さらに詳細なプランも有り。
  * [Prismic](https://www.prismic.io/) — ヘッドレスCMS。フルホスト＆スケーラブルなAPI。コミュニティプランは無制限APIコール、ドキュメント、カスタムタイプ、アセット、ロケールを1ユーザーで利用可。OSS/オープンコンテンツ向けにより大きな無料プランも。
  * [Sanity.io](https://www.sanity.io/) - OSSエディタ環境＆リアルタイムホステッドデータストアの構造化コンテンツプラットフォーム。無制限プロジェクト、無制限管理者、非管理者3人、2データセット、月50万API CDNリクエスト、10GB帯域、5GBアセットが各プロジェクト無料。
  * [sensenet](https://sensenet.com) - 企業向けAPIファースト型ヘッドレスCMS。開発者プランは3ユーザー、500コンテンツ、3ビルトインロール、25＋5コンテンツタイプ、REST API、ドキュメントプレビュー生成、Office Online編集。
  * [TinaCMS](https://tina.io/) — Forestry.ioの後継。Markdown/MDX/JSON対応のOSS Git連携ヘッドレスCMS。ベーシックは2ユーザー無料。
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - あらゆるCMS、API、DBと組み合わせて楽しくWebサイト構築できる高速・柔軟なフレームワーク。ヘッドレスWebサイトを構築＆デプロイしてトラフィック増・CV向上・収益UP！
  * [Hygraph](https://hygraph.com/) - 小規模プロジェクト向け無料ティアあり。GraphQLファーストAPI。レガシーCMSからGraphQLネイティブのヘッドレスCMSに移行し、APIファーストでオムニチャネル配信。
  * [Squidex](https://squidex.io/) - 小規模プロジェクト向けの無料プランを提供。API / GraphQL ファースト。オープンソースでイベントソーシングに基づいており（すべての変更を自動でバージョン管理）。
  * [InstaWP](https://instawp.com/) - 数秒でWordPressサイトを立ち上げ可能。無料プランは5つのアクティブサイト、500MBのストレージ、48時間のサイト有効期限付き。
  * [Storyblok](https://www.storyblok.com) - あらゆる最新フレームワークに対応した開発者とマーケター向けのヘッドレスCMS。コミュニティ（無料）プランには、管理API、ビジュアルエディタ、10ソース、カスタムフィールドタイプ、国際化（言語/ロケール無制限）、アセットマネージャ（最大2500アセット）、画像最適化サービス、検索クエリ、Webhook、月間250GBのトラフィックが含まれます。
  * [WPJack](https://wpjack.com) - 5分以内で任意のクラウド上にWordPressをセットアップ可能！無料プランには1サーバー、2サイト、無料SSL証明書、無制限のcronジョブが含まれます。時間制限や有効期限なし—あなたのウェブサイトを自由に運用できます。

**[⬆️ Back to Top](#table-of-contents)**

## コード生成

  * [Appinvento](https://appinvento.io/) — AppInventoは無料のノーコードアプリビルダーです。自動生成されるバックエンドコードでは、ユーザーはソースコードや無制限のAPI・ルートへの完全なアクセスが可能で、幅広い統合ができます。無料プランには3プロジェクト、5テーブル、Googleアドオンが含まれます。
  * [Cody AI](https://sourcegraph.com/cody) - CodyはAIとコードベースの深い理解によって、より速くコードを書き理解する手助けをするコーディングAIアシスタントです。Codyは開発者に複数のLLM（ローカル推論も含む）を選択肢として提供し、さまざまなIDEに対応、主要なプログラミング言語全てをサポートし、無料プランもあります。無料プランでは、開発者は月20回のチャットメッセージ（LLMはClaude 3 Sonnet）、月500回のオートコンプリート（Starcoder 16b使用）が利用可能です。
  * [DhiWise](https://www.dhiwise.com/) — DhiWiseの革新的なコード生成技術で、FigmaデザインをダイナミックなFlutter & Reactアプリケーションへシームレスに変換。ワークフローを最適化し、これまでにない速さでモバイル・Web体験を構築できます。
  * [Codeium](https://www.codeium.com/) — CodeiumはAIによるコード補完ツール。Python、JavaScript、Java、TypeScript、PHP、C/C++、Goなど20以上のプログラミング言語をサポートし、主要なスタンドアロンやWeb IDEに統合可能。無料。
  * [Fern](https://buildwithfern.com) - API定義を書いて、TypeScript、Python、Java、Goなど人気の言語でSDK/クライアントライブラリを生成。OpenAPI完全対応。無料プランは最大20エンドポイントまでコード生成可能。
  * [Metalama](https://www.postsharp.net/metalama) - C#専用。Metalamaはコンパイル時にコードのボイラープレートを自動生成し、ソースコードをクリーンに保ちます。オープンソースプロジェクトは無料、商用利用にも優しい無料枠（3アスペクトまで）。
  * [Supermaven](https://www.supermaven.com/) — SupermavenはVSCode、JetBrains、Neovim向けの高速AIコード補完プラグイン。無料プランで無制限のインライン補完を提供。
  * [tabnine.com](https://www.tabnine.com/) — Tabnineは全世界のコードから学習した知見を使い、開発者のソフトウェア開発をより速く、より良く支援。プラグイン有り。
  * [v0.dev](https://v0.dev/) — v0はAIモデルを使い、シンプルなテキストプロンプトからコードを生成。shadcn/uiとTailwind CSSに基づいたReactコードを生成し、そのままコピー＆ペーストしてプロジェクトで利用可能。各生成には最低30クレジット必要。初期で1200クレジット、毎月200クレジット無料付与。

**[⬆️ Back to Top](#table-of-contents)**

## コード品質

  * [beanstalkapp.com](https://beanstalkapp.com/) — コードの記述・レビュー・デプロイまで一貫したワークフロー。1ユーザー・1リポジトリ（100MBストレージ）まで無料。
  * [browserling.com](https://www.browserling.com/) — ライブ・インタラクティブなクロスブラウザテスト。無料ではMS IE 9（Vista、1024x768解像度）で3分間のセッションのみ。
  * [codacy.com](https://www.codacy.com/) — PHP、Python、Ruby、Java、JavaScript、Scala、CSS、CoffeeScript向け自動コードレビュー。公開・非公開リポジトリ無制限で無料。
  * [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - DevOps向けインフラストラクチャコード自動レビュー。GitHub、Bitbucket、GitLab（セルフホストも）と統合。Ansible、Terraform、CloudFormation、Kubernetesなど標準以外の言語も解析。（オープンソース無料）
  * [CodeBeat](https://codebeat.co) — 多言語対応の自動コードレビュープラットフォーム。Slack・メール連携付きで公開リポジトリは永久無料。
  * [codeclimate.com](https://codeclimate.com/) — 自動コードレビュー。オープンソースと組織所有のプライベートリポジトリ（4名まで）で無制限無料。学生・教育機関も無料。
  * [codecov.io](https://codecov.io/) — SaaS型コードカバレッジツール。オープンソースと1つのプライベートリポジトリで無料。
  * [CodeFactor](https://www.codefactor.io) — Git向け自動コードレビュー。無料版は無制限ユーザー、公開リポジトリ、1つのプライベートリポジトリが利用可能。
  * [coderabbit.ai](https://coderabbit.ai) — GitHub/GitLab連携のAIコードレビューツール。無料枠は1時間あたり200ファイル、3回のレビュー、50回の会話。オープンソースは永久無料。
  * [codescene.io](https://codescene.io/) - 開発者の作業状況に基づき技術的負債の優先順位付けや、チームカップリング・システム熟練度などの組織的要素を可視化。オープンソースは無料。
  * [CodSpeed](https://codspeed.io) - CIパイプライン内のパフォーマンス追跡を自動化。デプロイ前にパフォーマンス退行を検出。オープンソースプロジェクトは永久無料。
  * [coveralls.io](https://coveralls.io/) — テストカバレッジレポートの表示。オープンソースは無料。
  * [dareboost](https://dareboost.com) - Webパフォーマンス・アクセシビリティ・セキュリティの無料分析レポートを月5回まで。
  * [deepcode.ai](https://www.deepcode.ai) — AIによるバグ・セキュリティ脆弱性・パフォーマンス・API問題の検出。保存時リアルタイム解析。Java、C/C++、JavaScript、Python、TypeScript対応。GitHub、BitBucket、GitLab連携。オープンソース・プライベートリポジトリ・30名まで無料。
  * [deepscan.io](https://deepscan.io) — JavaScriptコードのランタイムエラーを自動検出する高度な静的解析。オープンソースは無料。
  * [DeepSource](https://deepsource.io/) - セキュリティ・パフォーマンス・アンチパターン・バグリスク・ドキュメント・スタイルなどを継続的に解析。GitHub、GitLab、Bitbucketとネイティブ統合。
  * [DiffText](https://difftext.com) - 2つのコードブロックの差分を即座に比較。完全無料。
  * [eversql.com](https://www.eversql.com/) — データベース最適化プラットフォーム。データベースとSQLクエリのインサイトを自動で取得。
  * [gerrithub.io](https://review.gerrithub.io/) — GitHubリポジトリ用Gerritコードレビューを無料で提供。
  * [gocover.io](https://gocover.io/) — 任意の[Go](https://golang.org/)パッケージ向けのコードカバレッジ。
  * [goreportcard.com](https://goreportcard.com/) — Goプロジェクトのコード品質を評価。オープンソースは無料。
  * [gtmetrix.com](https://gtmetrix.com/) — サイト最適化のための詳細レポートと推奨事項を提供。
  * [holistic.dev](https://holistic.dev/) - PostgreSQL最適化のためのNo.1静的コード解析サービス。パフォーマンス・セキュリティ・アーキテクト上の課題を自動検出。
  * [houndci.com](https://houndci.com/) — GitHubコミットにコード品質コメントを自動投稿。オープンソースは無料。
  * [Moderne.io](https://app.moderne.io) — 自動ソースコードリファクタリング。フレームワーク移行・コード解析・リメディエーション、圧倒的なコード変換を大規模に提供。開発者は保守より新しい構築に集中可能。オープンソースは無料。
  * [reviewable.io](https://reviewable.io/) — GitHubリポジトリ用コードレビュー。パブリック・個人リポジトリで無料。
  * [parsers.dev](https://parsers.dev/) - 抽象構文木パーサーおよび中間表現コンパイラをサービスとして提供
  * [scan.coverity.com](https://scan.coverity.com/) — Java、C/C++、C#、JavaScript向け静的コード解析。オープンソースは無料。
  * [scrutinizer-ci.com](https://scrutinizer-ci.com/) — 継続的検査プラットフォーム。オープンソースは無料。
  * [semanticdiff.com](https://app.semanticdiff.com/) — プログラミング言語対応のGitHubプルリク・コミット差分表示。公開リポジトリは無料。
  * [shields.io](https://shields.io) — オープンソースプロジェクト向けの品質メタデータバッジ。
  * [sonarcloud.io](https://sonarcloud.io) — Java、JavaScript、C/C++、C#、VB.NET、PHP、Objective-C、Swift、Python、Groovyなど多数言語の自動ソースコード解析。オープンソースは無料。
  * [SourceLevel](https://sourcelevel.io/) — 自動コードレビュー＆チーム分析。オープンソースと5名までの組織で無料。
  * [webceo.com](https://www.webceo.com/) — SEOツールですがコード検証や様々なデバイス対応も可能。
  * [zoompf.com](https://zoompf.com/) — Webサイトのパフォーマンス問題を詳細分析し修正。

**[⬆️ Back to Top](#table-of-contents)**

## コード検索・ブラウジング

  * [libraries.io](https://libraries.io/) — 32種のパッケージマネージャ向け検索・依存関係更新通知。オープンソースは無料。
  * [Namae](https://namae.dev/) - GitHub、Gitlab、Heroku、Netlify等でプロジェクト名の空き状況を検索。
  * [searchcode.com](https://searchcode.com/) — テキストベースの包括的コード検索。オープンソースは無料。
  * [tickgit.com](https://www.tickgit.com/) — `TODO`コメント（や他のマーカー）を可視化し、改善すべきコード領域を特定。
  * [CodeKeep](https://codekeep.io) - Google Keepのコードスニペット版。強力なコードスクリーンショットツールやリンク機能で、スニペットの整理・発見・共有が可能。

**[⬆️ Back to Top](#table-of-contents)**

## CIとCD

  * [AccessLint](https://github.com/marketplace/accesslint) — AccessLintは自動ウェブアクセシビリティテストを開発ワークフローに組み込みます。オープンソースおよび教育目的では無料。
  * [appcircle.io](https://appcircle.io) — エンタープライズ向けモバイルDevOpsプラットフォーム。ビルド、テスト、ストア公開の自動化でリリースサイクルを高速化。無料は1ビルド最大30分、月20回ビルド、同時1ビルドまで。
  * [appveyor.com](https://www.appveyor.com/) — Windows向けCDサービス。オープンソースは無料。
  * [LocalOps](https://localops.co/) - AWS/GCP/Azureへ30分以内でアプリをデプロイ。標準化されたアプリ環境とCI/CD自動化、監視機能付き。無料プランは1ユーザー・1アプリ環境。
  * [Argonaut](https://argonaut.dev/) - クラウド上に数分でアプリとインフラをデプロイ。Kubernetes・Lambda環境でのカスタム・サードパーティデプロイ対応。無料枠で5ドメイン・2ユーザーまで無制限のアプリとデプロイ。
  * [bitrise.io](https://www.bitrise.io/) — モバイルアプリ（ネイティブ/ハイブリッド）向けCI/CD。月200ビルド、1ビルド10分、2名まで無料。OSSプロジェクトは45分ビルド、+1並列、チーム無制限。
  * [buddy.works](https://buddy.works/) — 5プロジェクト・1同時実行（120回/月）まで無料のCI/CD。
  * [Buildkite](https://buildkite.com) CIパイプラインは3ユーザー・月5,000ジョブ分無料。テストアナリティクスはデベロッパー向けに月100,000回まで無料。OSSはさらに無料枠あり。
  * [bytebase.com](https://www.bytebase.com/) — データベースCI/CD・DevOps。20ユーザー・10データベースインスタンスまで無料。
  * [CircleCI](https://circleci.com/) — GitHub、GitLab、BitBucketリポジトリ対応のホステッドCI/CDサービス。複数リソースクラス、Docker、Windows、Mac OS、ARM、ローカルランナー、テスト分割、Dockerレイヤキャッシュ等の高度な機能全て無料プランで利用可。月6,000分実行・コラボレーター無制限・プライベート最大30並列・OSSは最大80,000分無料。
  * [cirrus-ci.org](https://cirrus-ci.org) - 公開GitHubリポジトリは無料。
  * [cirun.io](https://cirun.io) - 公開GitHubリポジトリは無料。
  * [codefresh.io](https://codefresh.io) — Free-for-Lifeプラン：1ビルド、1環境、共用サーバ、公開リポジトリ無制限。
  * [codemagic.io](https://codemagic.io/) - 月500分ビルド無料。
  * [codeship.com](https://codeship.com/) — 月100回のプライベートビルド、5つのプライベートプロジェクト、OSSは無制限。
  * [deploybot.com](https://www.deploybot.com/) — 1リポジトリ・10デプロイまで無料。OSSは無料。
  * [deployhq.com](https://www.deployhq.com/) — 1プロジェクト・1日10回デプロイ（30分/月ビルド）。
  * [drone](https://cloud.drone.io/) - x86/Arm（32/64ビット）対応のCDパイプライン。マルチアーキテクチャ対応。
  * [LayerCI](https://layerci.com) — フルスタック用CI。1つのプレビュー環境（5GBメモリ・3CPU）無料。
  * [semaphoreci.com](https://semaphoreci.com/) — オープンソースは無料。プライベートは月100ビルドまで。
  * [Squash Labs](https://www.squash.io/) — ブランチ毎にVMを作成し、アプリを固有URLで公開。公開・非公開リポジトリ無制限。最大2GB VMサイズ。
  * [styleci.io](https://styleci.io/) — 公開GitHubリポジトリのみ対応。
  * [Mergify](https://mergify.io) — GitHub向けワークフロー自動化・マージキュー。公開リポジトリは無料。
  * [Make](https://www.make.com/en) — UIでアプリ連携・ワークフロー自動化。多くのアプリ・APIに対応。公開GitHubリポジトリは無料。無料枠は100MB、1000オペレーション、最小15分間隔。
  * [Spacelift](https://spacelift.io/) - インフラストラクチャコード管理プラットフォーム。無料プランでIaCコラボレーション、Terraformモジュールレジストリ、ChatOps連携、OPA準拠リソース管理、SAML 2.0 SSO、パブリックワーカープール（最大月200分）利用可。
  * [microtica.com](https://microtica.com/) - スタートアップ向け環境を用意し、AWS上に無料でアプリをデプロイ。プロダクションワークロードもサポート。無料枠は1環境（自身のAWSアカウント）、2つのKubernetesサービス、月100分ビルド、月20回デプロイ。
* [Nx Cloud](https://nx.dev/ci) - Nx Cloudは、リモートキャッシュ、マシン間でのタスク分散、e2eテストランの自動分割などの機能により、CI上でモノレポを高速化します。最大30人のコントリビューターまで使える無料プランには、15万クレジットが含まれています。
* [blacksmith](https://www.blacksmith.sh/) - GitHub Actions向けのマネージドパフォーマンスランナー。月3,000分まで無料、クレジットカード不要。
* [Terramate](https://terramate.io/) - Terramateは、Terraform、OpenTofu、TerragruntなどのIaCツール向けのオーケストレーション・管理プラットフォームです。全機能込みで2ユーザーまで無料。
* [Terrateam](https://terrateam.io) - GitOpsファーストのTerraform自動化。プルリクエスト駆動のワークフロー、セルフホストランナーによるプロジェクト分離、順序付けされたレイヤードラン。3ユーザーまで無料。

**[⬆️ Back to Top](#table-of-contents)**

## テスト

* [Applitools.com](https://applitools.com/) — Web、ネイティブモバイル、デスクトップアプリのスマートなビジュアルバリデーション。ほぼすべての自動化ソリューション（SeleniumやKarma等）やリモートランナー（Sauce Labs、Browser Stack等）と統合可能。オープンソースは無料。1ユーザー・週あたりチェックポイント制限付きの無料ティアあり。
* [Appetize](https://appetize.io) — Android/iOSアプリをクラウドベースのAndroid端末エミュレータやiPhone/iPadシミュレータ上でブラウザから直接テスト可能。無料ティアで同時2セッション・月30分利用可能。アプリサイズ制限なし。
* [Apptim](https://apptim.com) — パフォーマンスエンジニアリング知識がなくてもアプリの性能やUXを評価できるモバイルテストツール。デスクトップ版（自身のデバイス利用）はiOS/Androidとも無制限・完全無料。
* [Argos](https://argos-ci.com) - 開発者向けオープンソースのビジュアルテスト。プロジェクト無制限、月5,000スクリーンショット。オープンソースプロジェクトは無料。
* [Bencher](https://bencher.dev/) - CIパフォーマンスの退行を検知する継続的ベンチマークツール群。パブリックプロジェクトは全て無料。
* [browserstack.com](https://www.browserstack.com/) — 手動・自動ブラウザテスト、[オープンソースは無料](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - Webアプリ向けの軽量テスト自動化ツール。習得が簡単でコーディング不要。自身のPCで無制限テスト実行が無料。クラウド監視やCI/CD連携は追加月額。
* [Checkly](https://checklyhq.com) - モダンDevOps向けのコードファーストな合成監視。APIやアプリの監視が従来サービスより低コスト。Monitoring as CodeとPlaywrightベース。開発者向けに寛大な無料枠。
* [checkbot.io](https://www.checkbot.io/) — 50以上のSEO・速度・セキュリティベストプラクティスを検証するブラウザ拡張。小規模サイト向け無料ティアあり。
* [CORS-Tester](https://cors-error.dev/cors-tester/) - 開発者やAPIテスター向けのCORS対応状況チェック無料ツール。実用的なインサイトも取得可能。
* [cypress.io](https://www.cypress.io/) - あらゆるブラウザで高速・簡単・信頼性あるテスト。Cypress Test Runnerは常に無料・オープンソース、制限なし。Cypress Dashboardはオープンソースプロジェクトなら5ユーザーまで無料。
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - ブラウザ上でAIによるCypressテスト/POMモデルを作成。AI部分以外はオープンソース。自己修復スクリプト、Eメール、ビジュアルテストなど含め、月5回まで無料作成。
* [everystep-automation.com](https://www.everystep-automation.com/) — ブラウザ操作を記録・再生し、スクリプトを生成。無料版は一部機能制限あり。
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Chaos Engineeringツールで、障害を安全・確実に注入しシステムの脆弱性を発見。Gremlin Freeは最大5ホスト/コンテナでShutdown・CPU攻撃が利用可能。
* [gridlastic.com](https://www.gridlastic.com/) — Selenium Gridテスト、同時最大4ノード/10回グリッド起動/4,000分/月まで無料プランあり。
* [katalon.com](https://katalon.com) - 規模やテスト成熟度を問わず活用できるテストプラットフォーム。Katalon Studio、TestOps（＋Visual Testing無料）、TestCloud、Katalon Recorderなどを提供。
* [Keploy](https://keploy.io/) - 開発者向けの機能テストツールキット。APIコールを記録しE2Eテスト（KTests）やモック/スタブ（KMocks）を生成。オープンソースプロジェクトは無料。
* [knapsackpro.com](https://knapsackpro.com) - CI上でテストスイートを最適並列化して高速化。Ruby、JavaScriptテストを並列CIノードで分割。10分間のテストファイルまで無料、オープンソースは無制限無料。
* [lambdatest.com](https://www.lambdatest.com/) — 手動・ビジュアル・スクリーンショット・自動ブラウザテスト（Selenium/Cypress）、[オープンソースは無料](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - ネットワークトラフィックを解析しAPI/負荷テストを自動生成。月50ユーザー・最大60分まで無料シミュレーション。
* [lost-pixel.com](https://lost-pixel.com) - Storybook, Ladle, HistoireストーリーやWebアプリの包括的ビジュアルリグレッションテスト。メンバー無制限、オープンソース完全無料、月7,000スナップショット。
* [octomind.dev](https://www.octomind.dev/) - AI支援テストケース生成による自動Playwright UIテスト作成・実行・保守
* [percy.io](https://percy.io) - あらゆるWebアプリ、静的サイト、スタイルガイド、コンポーネントライブラリにビジュアルテストを追加。チームメンバー・プロジェクト無制限、デモアプリ、月5,000スナップショット。
* [preflight.com](https://preflight.com) - ノーコードWeb自動テスト。UI変更に強いテストをブラウザで記録、Windows上で実行可能。CI/CD連携可。無料プランは月50回テスト実行（ビデオ・HTMLセッション等含む）。
* [qase.io](https://qase.io) - Dev/QAチーム向けテスト管理システム。テストケース管理・実行・欠陥追跡・影響測定。無料ティアは全機能、添付500MB・3ユーザーまで利用可。
* [Repeato](https://repeato.app/) ノーコードのモバイルアプリ自動テストツール。ネイティブ、Flutter、React Native、Web、Ionic等に対応。iOS/Android各10テストまで無料（実行回数無制限）、有料プランのほとんどの機能を利用可能。
* [Requestly](https://requestly.com/) オープンソースのChrome拡張。HTTPリクエストのインターセプト・リダイレクト・モックが可能。[デバッガ](https://requestly.com/products/web-debugger/)、[モックサーバ](https://requestly.com/products/mock-server/)、[APIクライアント](https://requestly.com/products/api-client/)、[セッション記録](https://requestly.com/products/session-book/)など搭載。URLリダイレクト、ヘッダー変更、APIモック、カスタムJS注入、GraphQLリクエスト編集、モックAPI生成、ネットワーク・コンソールログ付きセッション記録。無料枠は10ルールまで。オープンソースは無料。
* [seotest.me](https://seotest.me/) — 無料オンページSEOテスト。1日10サイトまでクロール。学習リソースやSEO改善アドバイスあり。技術に関係なく利用可能。
* [snippets.uilicious.com](https://snippets.uilicious.com) - コードペンのようにブラウザテスト用スニペットを作成。UI-licious Snippetsでテストをユーザーストーリー形式で記述、Chrome上で無制限実行（1回3分・サインアップ不要）。バグ再現用URLのコピーも可能。
* [TestCollab](https://testcollab.com) - 使いやすいテスト管理ソフト。無料プランはJira連携、プロジェクト無制限、CSV/XLSxインポート、タイムトラッキング、1GBファイルストレージ対応。
* [testingbot.com](https://testingbot.com/) — Seleniumブラウザ・デバイステスト、[オープンソースは無料](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - 自動テスト結果公開用ダッシュボード、および手動テストをコードとして実装するフレームワーク。サービスは[オープンソースは無料](https://github.com/marketplace/testspace-com)、月450件まで。
* [tesults.com](https://www.tesults.com) — テスト結果レポート・テストケース管理。主要テストフレームワークと連携。OSS開発者・個人・教育・小規模チーム向けに無料または割引提供。
* [UseWebhook.com](https://usewebhook.com) - Webhookのキャプチャ・検証ツール。ローカル転送や履歴からのリプレイも可能。無料利用可。
* [Vaadin](https://vaadin.com) — Java/TypeScriptでスケーラブルなUI構築。統合ツール・コンポーネント・デザインシステムで開発効率化。プロジェクト無制限・5年間無料保守。
* [websitepulse.com](https://www.websitepulse.com/tools/) — 各種無料ネットワーク・サーバーツール。
* [webhook-test.com](https://webhook-test.com) - 統合時にWebhookやHTTPリクエストをユニークURLでデバッグ・検証。完全無料、URL無制限作成・推奨事項受信可。
* [webhook.site](https://webhook.site) - Webhookや外部HTTPリクエスト、メールをカスタムURLで検証。テンポラリURLとメールアドレスは常に無料。
* [webhookbeam.com](https://webhookbeam.com) - Webhookのセットアップとプッシュ通知・メールでの監視。

**[⬆️ Back to Top](#table-of-contents)**

## セキュリティ・PKI

* [aikido.dev](https://www.aikido.dev) — SCA、SAST、CSPM、DAST、Secrets、IaC、マルウェア、コンテナスキャン、EOLなどをカバーするオールインワンAppSecプラットフォーム。無料プランは2ユーザー、10リポジトリ、1クラウド、2コンテナ、1ドメインまで。
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — ネットワーク内の侵害システムを検出
* [Altcha.org](https://altcha.org/anti-spam) - 自然言語処理と機械学習で動作するWebサイト・API向けスパムフィルター。無料プランはドメインごと200リクエスト/日。
* [atomist.com](https://atomist.com/) — 各種開発作業をより迅速・便利に自動化。現在ベータ版。
* [cloudsploit.com](https://cloudsploit.com/) — AWSセキュリティ・コンプライアンス監査・監視
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — パブリッククラウド向け高信頼IOC（侵害指標）。[一部はGitHub](https://github.com/unknownhad/AWSAttacks)で提供。全リストはAPIで取得可。
* [CodeNotary.io](https://www.codenotary.io/) — コード・ファイル・ディレクトリ・コンテナの改ざん防止証明を提供するオープンソースプラットフォーム
* [crypteron.com](https://www.crypteron.com/) — クラウド向け・開発者フレンドリーな.NET/Javaアプリのデータ漏洩防止セキュリティプラットフォーム
* [CyberChef](https://gchq.github.io/CyberChef/) — 複雑なツールや言語不要でデータ解析・エンコード/デコードできる直感的Webアプリ。暗号・エンコの万能ナイフ。全機能無料・制限なし。セルフホスト用OSSもあり。
* [DAS](https://signup.styra.com/) — Styra DAS Free。OPA( Open Policy Agent )認可のためのポリシー管理をフルライフサイクルで提供。
* [Datree](https://www.datree.io/) — KubernetesマニフェストやHelmチャートがベストプラクティスや組織ポリシーに従っているかを検証するオープンソースCLIツール
* [Dependabot](https://dependabot.com/) Ruby、JavaScript、Python、PHP、Elixir、Rust、Java（Maven/Gradle）、.NET、Go、Elm、Docker、Terraform、Gitサブモジュール、GitHub Actions向け自動依存関係更新。
* [DJ Checkup](https://djcheckup.com) — Djangoサイトのセキュリティ脆弱性を自動検査できる無料ツール。Pony Checkup由来。
* [Doppler](https://doppler.com/) — 複数クラウド連携可能なアプリケーションシークレット・コンフィグ管理。5ユーザーまで基本的なアクセス制御が無料。
* [Dotenv](https://dotenv.org/) — .envファイルを素早く安全に同期。Slackやメール等の非安全経路で.envファイル共有を防止。3人まで無料。
* [GitGuardian](https://www.gitguardian.com) — 自動シークレット検出と修復でソースコードから機密情報漏洩を防止。350種以上のシークレット・ファイルをスキャン。個人や25人以下のチームは無料。
* [Have I been pwned?](https://haveibeenpwned.com) — 流出情報取得用REST API。
* [hostedscan.com](https://hostedscan.com) — Webアプリ、サーバ、ネットワークのオンライン脆弱性スキャン。月10回まで無料。
* [Infisical](https://infisical.com/) — チームやインフラ全体で開発者シークレットを管理できるOSSプラットフォーム。ローカル開発から本番/サードパーティサービスまで対応。5人まで無料。
* [Internet.nl](https://internet.nl) — IPv6, DNSSEC, HTTPS, DMARC, STARTTLS, DANEなど最新インターネット標準のテスト
* [keychest.net](https://keychest.net) - CTデータベース統合のSSL有効期限管理・証明書購入
* [letsencrypt.org](https://letsencrypt.org/) — 全主要ブラウザ対応の無料SSL認証局
* [meterian.io](https://www.meterian.io/) - Java、Javascript、.NET、Scala、Ruby、NodeJSプロジェクトの依存脆弱性監視。1つのプライベートプロジェクトは無料、OSSは無制限。
* [Mozilla Observatory](https://observatory.mozilla.org/) — サイトのセキュリティ脆弱性を検出・修正
* [opswat.com](https://www.opswat.com/) — PC、デバイス、アプリ、構成のセキュリティ監視。25ユーザー・30日分履歴まで無料。
* [openapi.security](https://openapi.security/) - OpenAPI/Swagger APIのセキュリティ診断無料ツール。サインアップ不要。
* [pixee.ai](https://pixee.ai) - Javaコードベースの脆弱性を自動解決する無料GitHubボット。今後他言語も対応予定。
* [pyup.io](https://pyup.io) — Python依存の脆弱性監視・自動アップデート。1つのプライベートプロジェクトは無料、OSSは無制限。
* [qualys.com](https://www.qualys.com/community-edition) — Webアプリ脆弱性検出・OWASPリスク監査
* [report-uri.io](https://report-uri.io/) — CSP・HPKP違反レポート
* [ringcaptcha.com](https://ringcaptcha.com/) — 電話番号をIDとして利用するための各種ツール。無料プランあり。
* [seclookup.com](https://www.seclookup.com/) - SIEM等でドメイン脅威インジケータ拡充、網羅的ドメイン情報取得、脅威検知・対応改善API。5万回無料 [ここから](https://account.seclookup.com/)。
* [snyk.io](https://snyk.io) — OSS依存の既知脆弱性検出・修正。OSSプロジェクトは無制限、プライベートは月200回まで。
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — あらゆるSSL Webサーバの詳細設定解析
* [SOOS](https://soos.io) - OSSプロジェクト向けSCAスキャンが無料・無制限。リリース前に脅威検知・修正。
* [StackHawk](https://www.stackhawk.com/) パイプライン全体でアプリスキャン自動化、本番前にバグ検知・修正。1アプリ・スキャン/環境無制限。
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - Webサイトの無料セキュリティチェック・マルウェアスキャン
* [Protectumus](https://protectumus.com) - PHP用の無料Webサイトセキュリティ診断、サイトアンチウイルス、サーバーファイアウォール（WAF）。無料ユーザー向けにメール通知。
* [TestTLS.com](https://testtls.com) - SSL/TLSサービスのセキュア設定・証明書・チェーン等のテスト。HTTPS以外も対応。
* [threatconnect.com](https://threatconnect.com) — サイバー脅威インテリジェンス。個人研究者・分析者・入門組織向け。3ユーザーまで無料。
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — 自動脆弱性スキャン。無料プランは週1回XSSスキャン可。
* [Ubiq Security](https://ubiqsecurity.com/) — 3行のコードでデータ暗号化/復号、自動鍵管理。1アプリ・月100万暗号化まで無料。
* [Virgil Security](https://virgilsecurity.com/) — エンドツーエンド暗号化、DB保護、IoTセキュリティ等の各種ツール/サービス。250ユーザーまで無料。
* [Vulert](https://vulert.com) - オープンソース依存の脆弱性を継続監視し、修正案を提示。コードベースへのインストール・アクセス不要。OSSプロジェクトは無料。
* [Escape GraphQL Quickscan](https://escape.tech/) - GraphQLエンドポイントのワンクリックセキュリティスキャン。無料、ログイン不要。
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - 公開GitHubリポジトリ・gist・issue・コメント内の2,000万件超機密情報を無料検索
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - プライベートキー・CSR生成、証明書デコーダ、証明書マッチャー、SSL証明書発注等の各種SSLツール。CNAMEレコード利用でLet's Encrypt、Google Trust、BuyPassの無料SSL証明書発行も可能。
**[⬆️ Back to Top](#table-of-contents)**

## 認証、認可、およびユーザー管理

  * [Aserto](https://www.aserto.com) - アプリケーションおよびAPI向けのきめ細かい認可を提供するサービス。最大1000 MAUおよび100認可インスタンスまで無料。
  * [asgardeo.io](https://wso2.com/asgardeo) - SSO、MFA、パスワードレス認証などのシームレスな統合。フロントエンドおよびバックエンドアプリ向けSDK付き。最大1000 MAUおよび5つのIDプロバイダーまで無料。
  * [Auth0](https://auth0.com/) — ホスト型SSO。無料プランには25,000 MAU、無制限のソーシャル接続、カスタムドメイン等を含む。
  * [Authgear](https://www.authgear.com) - パスワードレス、OTP、2FA、SSOを数分でアプリに導入。全フロントエンド込み。最大5,000 MAUまで無料。
  * [Authress](https://authress.io/) — 認証ログインとアクセス制御、あらゆるプロジェクト向け無制限のIDプロバイダー。Facebook、Google、Twitter等対応。最初の1,000 APIコールが無料。
  * [Authy](https://authy.com) - 複数デバイス対応の二要素認証（2FA）とバックアップ。Google Authenticatorのドロップイン代替。最大100回の認証まで無料。
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - アクセスポリシーの作成、テスト、デプロイのための完全な認可管理システム。きめ細かい認可とアクセス制御、最大100 MAUまで無料。
  * [Clerk](https://clerk.com) — ユーザー管理、認証、2FA/MFA、サインイン・サインアップ・ユーザープロファイル等のUIコンポーネントを提供。最大10,000 MAUまで無料。
  * [Cloud-IAM](https://www.cloud-iam.com/) — KeycloakのID/アクセス管理をサービスとして提供。最大100ユーザーと1つのレルムまで無料。
  * [Corbado](https://www.corbado.com/) — 新規または既存アプリにパスキー優先認証を追加。無制限MAUで無料。
  * [Descope](https://www.descope.com/) — 高度にカスタマイズ可能なAuthNフロー。ノーコードおよびAPI/SDK提供。7,500アクティブユーザー/月、50テナント（最大5 SAML/SSOテナント）まで無料。
  * [duo.com](https://duo.com/) — ウェブサイトやアプリ向け二要素認証（2FA）。10ユーザーまで全認証方式・無制限統合・ハードウェアトークン無料。
  * [Kinde](https://kinde.com/) - 数分でプロダクトに統合できるシンプルかつ堅牢な認証。7,500 MAUまで無料で必要な機能をすべて提供。
  * [logintc.com](https://www.logintc.com/) — プッシュ通知による二要素認証（2FA）、VPN、ウェブサイト、SSHに対応。10ユーザーまで無料。
  * [MojoAuth](https://mojoauth.com/) - ウェブやモバイルなどのアプリでパスワードレス認証を数分で実装可能。
  * [Okta](https://developer.okta.com/signup/) — ユーザー管理、認証、認可。最大100 MAUまで無料。
  * [onelogin.com](https://www.onelogin.com/) — IDaaS、SSO IDプロバイダー、クラウドSSO IdP、3社内アプリと5個人アプリ、無制限ユーザーまで無料。
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/ゼロトラストのマネージドセキュリティプラットフォーム。全セキュリティ機能付き開発者アカウントが無料、無制限のチームメンバー、200 DAU、25,000/月のパーミッションチェック。
  * [Permit.io](https://permit.io) - RBAC、ABAC、ReBACをリアルタイム更新・ノーコードポリシーUIで実現する認可aaSプラットフォーム。1,000 MAUまで無料。
  * [Phase Two](https://phasetwo.io) - KeycloakのOSS ID/アクセス管理。最大1,000ユーザー、10 SSO接続まで無料。Phase TwoのKeycloak拡張コンテナと[Organization](https://phasetwo.io/product/organizations/)拡張を活用。
  * [SSOJet](https://ssojet.com/) - 既存の認証を再構築せずにエンタープライズSSOを追加。無料プランは無制限MAU、無制限組織、2 SSO＆2 SCIM接続を含む。
  * [Stytch](https://www.stytch.com/) - 認証と不正防止API/SDKのオールインワンプラットフォーム。無料プランは10,000 MAU、無制限組織、5 SSO/SCIM接続、1,000 M2Mトークンを含む。
  * [Stack Auth](https://stack-auth.com) — 開発者フレンドリーなOSS認証ソリューション。5分で開始可能。セルフホストは無料、または10,000 MAU無料のSaaS版あり。
  * [SuperTokens](https://supertokens.com/) - アプリにネイティブ統合可能なOSSユーザー認証。迅速に導入しつつユーザー・開発者体験を制御。最大5,000 MAUまで無料。
  * [Warrant](https://warrant.dev/) — アプリ向けホスト型エンタープライズ認可・アクセス制御サービス。無料枠は月1,000,000 APIリクエストと1,000認可ルール。
  * [ZITADEL Cloud](https://zitadel.com) — ターンキーなユーザー＆アクセス管理。マルチテナント（B2B）利用対応。25,000認証リクエストまで無料、全セキュリティ機能利用可（OTPやパスワードレス、ポリシー等に追加課金なし）。
  * [PropelAuth](https://propelauth.com) — 数行のコードで即座に企業向け販売。200ユーザーおよび10,000トランザクションメール（PropelAuthロゴ付き）まで無料。
  * [Logto](https://logto.io/) - 認証・認可のためのユーザーID管理。最大5,000 MAUまで無料、OSSセルフホスト版も有。
  * [WorkOS](https://workos.com/) - 最大100万MAUまで無料のユーザー管理・認証。メール＋パスワード、ソーシャル認証、マジック認証、MFA等対応。


**[⬆️ Back to Top](#table-of-contents)**

## モバイルアプリ配布とフィードバック

  * [TestApp.io](https://testapp.io) - モバイルアプリの動作検証プラットフォーム。無料プラン：1アプリ、分析、無制限バージョン＆インストール、フィードバック収集。
  * [Loadly](https://loadly.io) - iOS & Androidベータアプリ配布サービス。無制限ダウンロード・高速ダウンロード・無制限アップロードを完全無料で提供。
  * [Diawi](https://www.diawi.com) - iOS & Androidアプリを端末に直接配布。無料プラン：アプリアップロード、パスワード付きリンク、1日有効、10回インストールまで。
  * [InstallOnAir](https://www.installonair.com) - iOS & AndroidアプリOTA配布。無料プラン：無制限アップロード、プライベートリンク、ゲストは2日間有効、登録ユーザーは60日間有効。
  * [GetUpdraft](https://www.getupdraft.com) - テスト用モバイルアプリ配布。無料プランは1アプリプロジェクト、3バージョン、500MBストレージ、月100インストール。
  * [Appho.st](https://appho.st) - モバイルアプリホスティングプラットフォーム。無料プランは5アプリ、月50ダウンロード、最大ファイルサイズ100MB。

**[⬆️ Back to Top](#table-of-contents)**

## 管理システム

  * [bitnami.com](https://bitnami.com/) — IaaS上で準備済みアプリのデプロイ。1台のAWSマイクロインスタンスの管理が無料
  * [Esper](https://esper.io) — Android端末向けMDM/MAM。1ユーザーライセンス・25MBアプリストレージで100台まで無料。
  * [jamf.com](https://www.jamf.com/) — iPad、iPhone、Mac向けデバイス管理。3台まで無料
  * [Miradore](https://miradore.com) — デバイス管理サービス。デバイス群の最新状態を管理し、無制限デバイスを無料で保護。無料プランは基本機能を提供。
  * [moss.sh](https://moss.sh) - ウェブアプリ/サーバーのデプロイ・管理支援。月25回までのgitデプロイが無料
  * [runcloud.io](https://runcloud.io/) - 主にPHPプロジェクト向けサーバー管理。1サーバーまで無料。
  * [ploi.io](https://ploi.io/) - サーバー＆サイトの簡単管理・デプロイツール。1サーバーまで無料。
  * [xcloud.host](https://xcloud.host) — 使いやすいUIのサーバー管理・デプロイプラットフォーム。1サーバーの無料枠あり。
  * [serveravatar.com](https://serveravatar.com) — PHP系ウェブサーバーを自動設定で管理・監視。1サーバーまで無料。

**[⬆️ Back to Top](#table-of-contents)**

## メッセージング・ストリーミング

  * [Ably](https://www.ably.com/) - プレゼンス・永続性・確実な配信を備えたリアルタイイムメッセージング。無料プランは月300万メッセージ、100同時接続、100チャンネルまで。
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ as a Service。Little Lemurプラン：月100万メッセージ、20同時接続、100キュー、10,000キューイングメッセージ、異AZ複数ノード
  * [courier.com](https://www.courier.com/) — プッシュ、アプリ内、メール、チャット、SMS等のマルチチャネルAPI。無料プランは月10,000メッセージ。
  * [engagespot.co](https://engagespot.co/) — 開発者向けマルチチャネル通知基盤。アプリ内受信箱＆ノーコードテンプレートエディタ付き。無料プランは月10,000メッセージ。
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - MQTTデバイスをクラウドネイティブIoTメッセージングブローカーに接続。100台まで永年無料（クレカ不要）。
  * [knock.app](https://knock.app) – 開発者向け通知基盤。アプリ内・メール・SMS・Slack・プッシュ等マルチチャネルAPI。無料プランは月10,000メッセージ。
  * [NotificationAPI.com](https://www.notificationapi.com/) — 5分で通知機能追加。無料プランは月10,000通知＋SMS＆自動通話各100回。
  * [Novu.co](https://novu.co) — 開発者向けOSS通知インフラ。メール、SMS、ダイレクト、アプリ内、プッシュ等の管理API。無料プランは月30,000通知/90日保持。
  * [pusher.com](https://pusher.com/) — リアルタイムメッセージング。最大100同時接続・20万メッセージ/日まで無料
  * [scaledrone.com](https://www.scaledrone.com/) — リアルタイムメッセージング。最大20同時接続・10万イベント/日まで無料
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io)のSaaS。グローバル・AWS・GCP・Azure対応。4kメッセージサイズ、50アクティブ接続、5GB/月まで永年無料。
  * [pubnub.com](https://www.pubnub.com/) - Swift、Kotlin、React対応メッセージング。月100万トランザクション無料。トランザクションは複数メッセージ可。
  * [eyeson API](https://developers.eyeson.team/) - WebRTC(SFU, MCU)ベースのビデオ通信API。リアルタイムデータ注入、ビデオレイアウト、録画、ホスト型Web UI/カスタムUI用パッケージ有。 [開発者向け無料枠](https://apiservice.eyeson.com/api-pricing)は月1,000ミーティング分。
  * [webpushr](https://www.webpushr.com/) - ウェブプッシュ通知。最大10,000購読者、無制限プッシュ通知、ブラウザ内メッセージ無料
  * [httpSMS](https://httpsms.com) - Android端末をSMSゲートウェイとしてSMS送受信。月200通まで送受信無料。
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - スケーラブル・セキュアなサーバーレスMQTTブローカー。1Mセッション分/⽉が永年無料（クレカ不要）。
  * [Pocket Alert](https://pocketalert.app) - iOS/Android端末へのプッシュ通知。API/Webhooks統合可、通知を完全制御。無料プランは1デバイス・1アプリに1日50メッセージ。
  * [SuprSend](https://www.suprsend.com/) - APIファーストで通知を効率化する通知基盤。トランザクション・定時・エンゲージメント通知を単一APIでマルチチャネル配信。無料プランは月10,000通知、ダイジェスト・バッチ・マルチチャネル・プリファレンス・テナント・ブロードキャスト等各種ワークフローノード含む。

**[⬆️ Back to Top](#table-of-contents)**

## ログ管理

  * [bugfender.com](https://bugfender.com/) — 1日10万ログ行/24時間保持まで無料
  * [logentries.com](https://logentries.com/) — 月5GB/7日間保持まで無料
  * [loggly.com](https://www.loggly.com/) — 1ユーザー・1日200MB/7日保持まで無料
  * [logz.io](https://logz.io/) — 1日1GB/1日間保持まで無料
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Manage Engine提供のログ管理サービス。無料プランは50GBストレージ、15日間保持、7日間検索。
  * [papertrailapp.com](https://papertrailapp.com/) — 48時間検索、7日間アーカイブ、月50MBまで無料
  * [sematext.com](https://sematext.com/logsene) — 1日500MB/7日間保持まで無料
  * [sumologic.com](https://www.sumologic.com/) — 1日500MB/7日間保持まで無料
  * [logflare.app](https://logflare.app/) — アプリごとに月12,960,000エントリ、3日間保持まで無料
  * [logtail.com](https://logtail.com/) — ClickHouseベースのSQL互換ログ管理。月1GB/3日間保持まで無料。
  * [logzab.com](https://logzab.com/) — 監査証跡管理システム。月1,000ユーザーアクティビティログ/1ヶ月保持/5プロジェクトまで無料。
  * [openobserve.ai](https://openobserve.ai/) - 月200GBインジェスト/15日間保持まで無料
**[⬆️ 上に戻る](#table-of-contents)**

## 翻訳管理

  * [crowdin.com](https://crowdin.com/) — オープンソース向けに無制限のプロジェクト、無制限の文字列、無制限の共同作業者
  * [gitlocalize.com](https://gitlocalize.com) - プライベートおよびパブリックリポジトリの両方で無料・無制限
  * [Lecto](https://lecto.ai/) - 無料枠ありの機械翻訳API（30件の無料リクエスト、1リクエストあたり1000文字まで翻訳）。Loco Translate Wordpressプラグインと統合。
  * [lingohub.com](https://lingohub.com/) — 最大3ユーザーまで無料、オープンソースは常に無料
  * [localazy.com](https://localazy.com) - 1000件のソース言語文字列まで無料、無制限の言語、無制限の貢献者、スタートアップ・オープンソース向けディールあり
  * [Localeum](https://localeum.com) - 最大1000文字列、1ユーザー、無制限の言語、無制限のプロジェクトまで無料
  * [localizely.com](https://localizely.com/) — オープンソースは無料
  * [Loco](https://localise.biz/) — 最大2000翻訳まで無料、無制限の翻訳者、プロジェクトあたり10言語、プロジェクトあたり1000翻訳可能アセット
  * [oneskyapp.com](https://www.oneskyapp.com/) — 最大5ユーザーまでの限定無料エディション、オープンソースは無料
  * [POEditor](https://poeditor.com/) — 最大1000文字列まで無料
  * [SimpleLocalize](https://simplelocalize.io/) - 最大100翻訳キーまで無料、無制限の文字列、無制限の言語、スタートアップ向けディールあり
  * [Texterify](https://texterify.com/) - 1ユーザーまで無料
  * [Tolgee](https://tolgee.io) - 限定翻訳付きの無料SaaS提供、自己ホスティング版は永遠に無料
  * [transifex.com](https://www.transifex.com/) — オープンソースは無料
  * [Translation.io](https://translation.io) - オープンソースは無料
  * [Translized](https://translized.com) - 最大1000文字列、1ユーザー、無制限の言語、無制限のプロジェクトまで無料
  * [webtranslateit.com](https://webtranslateit.com/) — 最大500文字列まで無料
  * [weblate.org](https://weblate.org/) — 無料枠はリブレプロジェクト向けで最大10,000文字列ソースまで、自己ホスティング版は無制限でオンプレミス利用可能
  * [Free PO editor](https://pofile.net/free-po-editor) — 誰でも無料で利用可能
  * [Lingo.dev](https://lingo.dev) – ウェブ＆モバイルローカライズ向けのオープンソースAI搭載CLI。独自のLLMを持ち込むことも、Lingo.dev管理のローカライズエンジンで毎月10,000語まで無料利用可能。

**[⬆️ 上に戻る](#table-of-contents)**

## モニタリング

  * [UptimeObserver.com](https://uptimeobserver.com) - 20件のアップタイムモニター（5分間隔）とカスタマイズ可能なステータスページを商用利用でも利用可能。無制限・リアルタイムのメール・Telegram通知も。クレジットカード不要で開始。
  * [Pingmeter.com](https://pingmeter.com/) - 5件のアップタイムモニター（10分間隔）。SSH、HTTP、HTTPS、任意のTCPポート監視。
  * [alerty.ai](https://www.alerty.ai) - FE、BE、DB等の無料APM＆モニタリング＋無料エージェント実行
  * [appdynamics.com](https://www.appdynamics.com/) — 24時間のメトリクスは無料、Java/.NET/PHP/Node.js各1つまでAPMエージェント利用可
  * [appneta.com](https://www.appneta.com/) — 1時間のデータ保持で無料
  * [appspector.com](https://appspector.com/) - リモートiOS/Android/Flutterデバッグ用ミッションコントロール。小規模トラフィック（64MBのログ）まで無料
  * [assertible.com](https://assertible.com) — API自動テスト＆モニタリング。個人・チーム向け無料プランあり
  * [bleemeo.com](https://bleemeo.com) - 3サーバー、5アップタイムモニター、無制限ユーザー、無制限ダッシュボード、無制限アラートルールまで無料
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - URLやウェブサイトのCore Web Vitals履歴を検索
  * [checklyhq.com](https://checklyhq.com) - 開発者向けオープンソースE2E/シンセティックモニタリング＆API監視。1ユーザー、API＆ネットワーク10,000回/ブラウザ1,500回チェック実行まで無料プランあり
  * [cloudsploit.com](https://cloudsploit.com) — AWSセキュリティ＆設定モニタリング。無料はオンデマンドスキャン・無制限ユーザー・無制限アカウント保存可。有料は自動スキャン・API利用など
  * [cronitor.io](https://cronitor.io/) - cronジョブ、ウェブサイト、APIなどのパフォーマンスインサイト＆アップタイム監視。無料枠は5モニター
  * [datadoghq.com](https://www.datadoghq.com/) — 最大5ノードまで無料
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — cronジョブ監視。1つ無料モニター、紹介登録で追加可能
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60件のアップタイムモニター、5分間隔。Eメール・Slack通知
  * [economize.cloud](https://economize.cloud) — クラウドリソースの最適化とレポートを支援。GCPの月間$5,000利用分まで無料
  * [elastic.co](https://www.elastic.co/solutions/apm) — JS開発者向け即時パフォーマンスインサイト。24時間データ保持で無料
  * [fivenines.io](https://fivenines.io/) — Linuxサーバーモニタリング（リアルタイムダッシュボード＆アラート）– 5サーバーまで60秒間隔で永年無料。クレカ不要
  * [Grafana Cloud](https://grafana.com/products/cloud/) - メトリクス・ログをGrafanaと統合した観測基盤。無料枠：3ユーザー、10ダッシュボード、100アラート、Prometheus/Graphiteでのメトリクス保存（10,000系列・14日保持）、Lokiでのログ保存（50GB・14日保持）
  * [healthchecks.io](https://healthchecks.io) — cronジョブ・バックグラウンドタスクの監視。最大20チェックまで無料
  * [Hydrozen.io](https://hydrozen.io) — アップタイム監視＆ステータスページ。無料枠：アップタイム監視10件、ハートビート監視5件、ドメイン監視1件、ステータスページ1件
  * [incidenthub.cloud](https://incidenthub.cloud/) — クラウド・SaaSのステータスページ集約。20モニター・2通知チャネル（Slack/Discord）まで永年無料
  * [inspector.dev](https://www.inspector.dev) - 1分以内に使えるリアルタイム監視ダッシュボード、永年無料プランあり
  * [instrumentalapp.com](https://instrumentalapp.com) - 最大500メトリクス＆3時間可視性での美麗かつ使いやすいアプリ＆サーバーモニタリング、無料
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Digital Ocean対しての独立速度テスト＆TLSハンドシェイク遅延テスト
  * [letsmonitor.org](https://letsmonitor.org) - SSL監視、最大5モニターまで無料
  * [linkok.com](https://linkok.com) - オンラインリンク切れチェッカー。最大100ページの小規模ウェブサイトは無料、オープンソースプロジェクトは完全無料
  * [loader.io](https://loader.io/) — 無料の負荷テストツール（制限あり）
  * [MonitorMonk](https://monitormonk.com) - ミニマリストなアップタイム監視＆美麗なステータスページ。Forever FreeプランはHTTPS, キーワード, SSL, レスポンスタイム監視を10サイト/APIエンドポイント、2ダッシュボード/ステータスページで提供
  * [netdata.cloud](https://www.netdata.cloud/) — オープンソースのリアルタイムメトリクス収集ツール。GitHubでも入手可
  * [newrelic.com](https://www.newrelic.com) — エンジニア向け観測プラットフォーム。無料枠は月100GBデータ取込、フルアクセスユーザー1人、プライマリーユーザー無制限
  * [Middleware.io](https://middleware.io/) - ミドルウェア観測基盤。Devコミュニティ向け永年無料プランで100万件ログイベントまでのログ監視、最大2ホストのインフラ/APM監視
  * [nixstats.com](https://nixstats.com) - 1サーバー無料。メール通知、公的ステータスページ、60秒間隔など
  * [OnlineOrNot.com](https://onlineornot.com/) - ウェブサイト＆APIのアップタイム監視、cronジョブ・スケジュールタスク監視、ステータスページも提供。最初の5チェック（3分間隔）が無料。Slack/Discord/メールで通知
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — グレートファイアウォールによる中国でのウェブサイトブロック状況を検証。中国と米国のDNS結果・ASN情報を比較
  * [opsgenie.com](https://www.opsgenie.com/) — 常時稼働サービス向け強力なアラート＆オンコール管理。5ユーザーまで無料
  * [paessler.com](https://www.paessler.com/) — 強力なインフラ・ネットワーク監視、アラート、可視化、基本レポート。最大100センサーまで無料
  * [pagecrawl.io](https://pagecrawl.io/) - ウェブサイト変更監視、最大6モニター・毎日チェックまで無料
  * [syagent.com](https://syagent.com/) — 非商用向け無料サーバーモニタリングサービス、アラート＆メトリクス
  * [pagerly.io](https://pagerly.io/) - Slack上でオンコール管理（Pagerduty, OpsGenie統合）。1チーム（1つのオンコール）まで無料
  * [pagertree.com](https://pagertree.com/) - シンプルなアラート＆オンコール管理。5ユーザーまで無料
  * [phare.io](https://phare.io/) - アップタイム監視は100,000イベントまで、無制限のプロジェクト＆ステータスページで無料
  * [pingbreak.com](https://pingbreak.com/) — モダンなアップタイム監視。無制限URL監視、Discord/Slack/メールでダウンタイム通知
  * [pingpong.one](https://pingpong.one/) — 高度なステータスページ＆モニタリング。無料枠はカスタマイズ可能な公開ステータスページ1つ（SSLサブドメイン付）。プロプランはオープンソース・非営利に無料提供
  * [robusta.dev](https://home.robusta.dev/) — Prometheusベースの強力なKubernetes監視。独自Prometheus利用またはバンドル版導入可。無料枠はKubernetesノード20台まで。Slack/Teams/Discord等で通知。PagerDuty/OpsGenie/VictorOps/DataDog他と連携
  * [sematext.com](https://sematext.com/) — 24時間メトリクス無料、サーバー無制限、カスタムメトリクス10件、データポイント50万件、ダッシュボード・ユーザー等無制限
  * [sitemonki.com](https://sitemonki.com/) — ウェブサイト・ドメイン・Cron・SSL監視。各カテゴリで5モニターまで無料
  * [sitesure.net](https://sitesure.net) - ウェブサイト＆cron監視、2モニターまで無料
  * [skylight.io](https://www.skylight.io/) — 最初の100,000リクエスト（Railsのみ）まで無料
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — パフォーマンス監視API。Ping、DNS等チェック
  * [stathat.com](https://www.stathat.com/) — 10統計まで無料、期間無制限
  * [statuscake.com](https://www.statuscake.com/) — ウェブサイト監視、無制限テストが無料（制限あり）
  * [statusgator.com](https://statusgator.com/) — ステータスページ監視、3モニターまで無料
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — サーバー・アップタイム・DNS・ドメイン監視。10サーバー、10アップタイム、10ドメインまで無料
  * [thousandeyes.com](https://www.thousandeyes.com/) — ネットワーク＆ユーザー体験監視。3地点・主要Webサービス20データフィードまで無料
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — 5ウェブサイトまで60秒間隔で無料監視、公開ステータスページ
  * [zenduty.com](https://www.zenduty.com/) — インシデント管理・アラート・オンコール管理・レスポンスオーケストレーション。5ユーザーまで無料
  * [instatus.com](https://instatus.com) - 10秒で美しいステータスページ作成。無制限サブ・無制限チームで永年無料
  * [Squadcast.com](https://squadcast.com) - SREベストプラクティス推進用のエンドツーエンド・インシデント管理ソフトウェア。10ユーザーまで永年無料プランあり
  * [RoboMiri.com](https://robomiri.com/) - cronjob、キーワード、ウェブサイト、ポート、ping監視など多彩なアップタイム監視。3分間隔チェックで25件まで無料。電話・SMS・メール・Webhook通知
  * [Better Stack](https://betterstack.com/better-uptime) - アップタイム監視、インシデント管理、オンコールスケジューリング＆アラート、ステータスページが一体化。無料プランは10モニター（3分間隔）とステータスページ含む
  * [Pulsetic](https://pulsetic.com) - 10モニター、6ヶ月分の履歴・ログ、無制限ステータスページ、カスタムドメイン等を永久無料＆無制限メールアラート。クレカ不要
  * [Wachete](https://www.wachete.com) - 5ページ監視、24時間ごとチェック
  * [Xitoring.com](https://xitoring.com/) — アップタイム監視20件無料、Linux/Windowsサーバー監視5件無料、ステータスページ1件無料。モバイルアプリ・多様な通知チャネルなど
  * [Servervana](https://servervana.com) - 大規模プロジェクトやチーム対応の高度なアップタイム監視。HTTP、ブラウザ、DNS、ドメイン監視、ステータスページ等対応。無料枠はHTTP監視10件、DNS監視1件、ステータスページ1件

**[⬆️ 上に戻る](#table-of-contents)**

## クラッシュおよび例外処理
* [CatchJS.com](https://catchjs.com/) - JavaScriptのエラー追跡、スクリーンショットおよびクリックトレイル付き。オープンソースプロジェクトは無料。
* [bugsnag.com](https://www.bugsnag.com/) — 初回トライアル後、月2,000エラーまで無料
* [elmah.io](https://elmah.io/) — ウェブ開発者向けエラーロギングと稼働監視。オープンソースプロジェクト向けにSmall Businessサブスクリプションが無料。
* [Embrace](https://embrace.io/) — モバイルアプリ監視。年間最大100万ユーザーセッションまで小規模チームは無料。
* [exceptionless](https://exceptionless.com) — リアルタイムエラー、機能、ログレポート等。月3,000イベント/1ユーザーまで無料。オープンソースでセルフホストも容易、無制限利用可。
* [GlitchTip](https://glitchtip.com/) — シンプルなオープンソースエラー追跡。オープンソースSentry SDKと互換。月1,000イベントまで無料、セルフホストなら無制限。
* [honeybadger.io](https://www.honeybadger.io) - 例外、稼働、cron監視。小規模チームやオープンソースプロジェクトは無料（月12,000エラーまで）。
* [memfault.com](https://memfault.com) — クラウドデバイスの可観測性・デバッグプラットフォーム。[Nordic](https://app.memfault.com/register-nordic)、[NXP](https://app.memfault.com/register-nxp)、[Laird](https://app.memfault.com/register-laird)デバイス各100台まで無料。
* [rollbar.com](https://rollbar.com/) — 例外・エラー監視。無料プランで月5,000エラー、無制限ユーザー、30日間保存
* [sentry.io](https://sentry.io/) — Sentryはアプリの例外をリアルタイムで追跡し、小規模無料プランあり。月5,000エラー/1ユーザーまで無料、セルフホスト時は無制限。
* [Axiom](https://axiom.co/) — 最大0.5TBのログを30日間保存可能。Vercel等との連携や、メール/Discord通知付きの高度なデータクエリ機能を含む。
* [Semaphr](https://semaphr.com) — モバイルアプリ向けの無料オールインワンキルスイッチ。
* [Jam](https://jam.dev) - 開発者向けワンクリックバグレポート。無料プランで無制限のJam利用可。
* [Whitespace](https://whitespace.dev) – ブラウザ内ワンクリックバグレポート。個人利用で無制限録画の無料プラン。

**[⬆️ トップに戻る](#table-of-contents)**

## 検索

* [algolia.com](https://www.algolia.com/) — タイポ耐性・関連性・UIライブラリ付きのホステッド検索ソリューション。無料「Build」プランは1Mドキュメント、月10K検索まで。開発者向け[ドキュメント検索](https://docsearch.algolia.com/)も無料提供。
* [bonsai.io](https://bonsai.io/) — 無料1GBメモリ、1GBストレージ
* [CommandBar](https://www.commandbar.com/) - 統合検索バーのSaaS。Web UIウィジェット/プラグインで、ユーザーがプロダクト内のコンテンツ・ナビ・機能等を検索可能、発見性向上に。月間1,000MAU、無制限コマンドまで無料。
* [Orama Cloud](https://orama.com/pricing) — 無料で3インデックス、インデックス毎10万ドキュメント、無制限全文/ベクトル/ハイブリッド検索、60日間の分析
* [searchly.com](http://www.searchly.com/) — 無料で2インデックス、20MBストレージ
* [easysitesearch.com](https://easysitesearch.com/) — 検索ウィジェットとAPI、自動Webクローラーインデックス。最大50サブページまで無制限検索無料。

**[⬆️ トップに戻る](#table-of-contents)**

## 教育とキャリア開発

* [FreeCodeCamp](https://www.freecodecamp.org/) - オープンソースプラットフォーム。データ分析・情報セキュリティ・Web開発等の無料コースと認定資格を提供。
* [The Odin Project](https://www.theodinproject.com/) - JavaScriptやRubyに特化したWeb開発カリキュラムを提供する無料オープンソースプラットフォーム。
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - 経験豊富なプロフェッショナル用レジュメテンプレート多数、完全編集・ダウンロード可、ATS最適化済みの無料プラットフォーム。
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - 業界トップ専門家による最新生成AIツール・技術の実践無料ショートコース。1時間以内で受講可能。
* [LabEx](https://labex.io) - Linux、DevOps、サイバーセキュリティ、プログラミング、データサイエンス等のスキルを、インタラクティブラボと実プロジェクトで習得。
* [Roadmap.sh](https://roadmap.sh) - ブロックチェーンからUXデザインまで、開発分野全般を網羅した無料学習ロードマップ。
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - サイバーセキュリティ、ネットワーキング、Python等の無料認定対応コースを提供。
* [MIT OpenCourseWare](https://ocw.mit.edu/) - MITの2,500超の講義資料を無料公開。世界中の学習者・教育者に知識を共有。[YouTubeチャンネル](https://www.youtube.com/@mitocw/featured)もあり。
* [W3Schools](https://www.w3schools.com/) - HTML、CSS、JavaScript等のWeb開発技術の無料チュートリアル。
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - HTML/CSS、JavaScript、SQLの基礎・上級を学べる無料オンラインガイド。
* [Full Stack Open](https://fullstackopen.com/en/) – React、Node.js、GraphQL、TypeScript等のモダンWeb開発を学べる大学レベルの無料オンライン自己学習コース。
* [edX](https://www.edx.org/) - ハーバードやMIT含む250以上の機関による4,000超の無料オンラインコース。コンピュータサイエンス、エンジニアリング、データサイエンス等に特化。
* [Django-tutorial.dev](https://django-tutorial.dev) - 初めてのフレームワークとしてDjangoを学べる無料オンラインガイド。ユーザー投稿記事には無料dofollowバックリンクも付与。

**[⬆️ トップに戻る](#table-of-contents)**

## メール

* [10minutemail](https://10minutemail.com) - テスト用の無料一時メール。
* [AhaSend](https://ahasend.com) - トランザクションメールサービス。無料プランは月1,000通、無制限ドメイン・チームメンバー・Webhook・メッセージルート付き。
* [AnonAddy](https://anonaddy.com) - オープンソースの匿名メール転送。無制限エイリアス作成が無料。
* [Antideo](https://www.antideo.com/) — 無料ティアはメール認証・IP・電話番号検証APIが1時間10回まで。クレジットカード不要。
* [Brevo](https://www.brevo.com/) — 月9,000通、1日300通まで無料。
* [OneSignal](https://onesignal.com/) — 月10,000通まで無料。クレジットカード不要。
* [Bump](https://bump.email/) - 無料で10個のBumpメールアドレス、1カスタムドメイン。
* [Burnermail](https://burnermail.io/) – 無料で5つのバーナーメールアドレス、1メールボックス、7日間のメール履歴。
* [Buttondown](https://buttondown.email/) — ニュースレターサービス。100購読者まで無料。
* [CloudMailin](https://www.cloudmailin.com/) - HTTP POST経由受信・トランザクション送信対応、月1万通まで無料。
* [Contact.do](https://contact.do/) — リンクで使えるコンタクトフォーム（コンタクトフォームのbitly版）。
* [debugmail.io](https://debugmail.io/) — 開発者向けのテスト用メールサーバー。
* [DNSExit](https://dnsexit.com/) - 独自ドメインで2メールアドレスまで、100MBストレージ無料。IMAP、POP3、SMTP、SPF/DKIM対応。
* [EmailLabs.io](https://emaillabs.io/en) — 毎月最大9,000通、1日最大300通まで無料送信。
* [EmailOctopus](https://emailoctopus.com) - 最大2,500購読者、月10,000通まで無料。
* [EmailJS](https://www.emailjs.com/) – メールサーバ全体ではなく、クライアントから直接メール送信できるクライアント。無料ティアは月200リクエスト、2テンプレート、リクエスト上限50KB、履歴制限。
* [EtherealMail](https://ethereal.email) - EtherealはNodemailerやEmailEngine利用者向けの偽SMTPサービス（他用途も可）。完全無料のアンチトランザクションメールサービスで、実際には配信されません。
* [Temp-Mail.org](https://temp-mail.org/en/) - 様々なドメインを利用できる無料の一時/使い捨てメール生成。ページリロードごとにアドレスが更新。完全無料で価格設定なし。
* [TempMailDetector.com](https://tempmaildetector.com/) - 月200件まで無料で一時メールかどうか判定可能。
* [Emailvalidation.io](https://emailvalidation.io) - 月100件まで無料メール認証。
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - ドイツ製一時/使い捨てメール生成。10ドメイン対応、無制限アドレス作成可能（広告あり）。価格設定なく完全無料。
* [forwardemail.net](https://forwardemail.net) — 独自ドメイン向け無料メール転送。ドメイン名で無制限のメールアドレス作成・転送可（**注意**：.casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work TLDはスパム対策のため有料）。
* [Imitate Email](https://imitate.email) - ビルド/QAやCI/CD環境でのメール機能テスト用サンドボックスメールサーバー。無料アカウントは1日15通まで。
* [ImprovMX](https://improvmx.com) – 無料メール転送サービス。
* [EForw](https://www.eforw.com) – 1ドメイン向け無料メール転送。受信・送信両対応。
* [Inboxes App](https://inboxesapp.com) — 1日最大3つまで一時メール作成、Chrome拡張で完結削除可能。サインアップフローのテストに最適。
* [inboxkitten.com](https://inboxkitten.com/) - 無料の一時/使い捨てメールインボックス、最大3日間自動削除。オープンソース、セルフホスト可。
* [mail-tester.com](https://www.mail-tester.com) — メールのDNS/SPF/DKIM/DMARC設定テスト、月20回まで無料。
* [dkimvalidator.com](https://dkimvalidator.com/) - メールのDNS/SPF/DKIM/DMARC設定テスト。roundsphere.comによる無料サービス。
* [mailcatcher.me](https://mailcatcher.me/) — メールをキャッチしWebインターフェースで閲覧。
* [mailchannels.com](https://www.mailchannels.com) - REST APIとSMTP連携のメールAPI、月3,000通まで無料。
* [Mailcheck.ai](https://www.mailcheck.ai/) - 一時メールアドレスでの登録防止、1時間120リクエスト（約86,400/月）。
* [Mailchimp](https://mailchimp.com/) — 500購読者、月1,000通まで無料。
* [Maildroppa](https://maildroppa.com) - 無料で最大100購読者、無制限メール送信・自動化。
* [MailerLite.com](https://www.mailerlite.com) — 月1,000購読者、12,000通まで無料。
* [MailerSend.com](https://www.mailersend.com) — メールAPI、SMTP、トランザクションメール月3,000通まで無料。
* [mailinator.com](https://www.mailinator.com/) — 任意のインボックスが使える無料の公開メールシステム。
* [Mailjet](https://www.mailjet.com/) — 月6,000通まで無料（1日200通送信上限）。
* [Mailnesia](https://mailnesia.com) - 無料の一時/使い捨てメール、登録リンクの自動訪問機能。
* [mailsac.com](https://mailsac.com) - 一時メールテスト用無料API、公開メールホスティング、送信キャプチャ、メール→Slack/Websocket/Webhook（API月1,500制限）。
* [Mailtrap.io](https://mailtrap.io/) — 開発用偽SMTPサーバー。無料プランは1インボックス、100メッセージ、チーム不可、2通/秒、転送ルールなし。
* [Mail7.io](https://www.mail7.io/) — QA開発者向け無料一時メールアドレス。Web UIまたはAPIで即作成。
* [Momentary Email](https://www.momentaryemail.com/) — 無料一時メールアドレス。WebやRSSで受信メール閲覧可。
* [Mutant Mail](https://www.mutantmail.com/) – 無料10メールID、1ドメイン、1メールボックス。全メールIDを1ボックスで受信。
* [Outlook.com](https://outlook.live.com/owa/) - 無料の個人用メール&カレンダー。
* [Parsio.io](https://parsio.io) — 無料メールパーサー（メール転送、データ抽出、サーバー送信可）。
* [pepipost.com](https://pepipost.com) — 初月3万通無料、その後は1日100通まで無料。
* [Plunk](https://useplunk.com) - 月3,000通まで無料。
* [Postmark](https://postmarkapp.com/) - 月100通まで無料、無制限DMARC週次ダイジェスト。
* [Proton Mail](https://proton.me/mail) - 無料の安全なメールアカウントサービス。エンドツーエンド暗号化内蔵。1GBストレージ無料。
* [Queuemail.dev](https://queuemail.dev) — 信頼性の高いメール配信API。無料ティア（月10,000通）。非同期送信、複数SMTPサーバ利用可。ブロックリスト、ログ、トラッキング、Webhook等。
* [QuickEmailVerification](https://quickemailverification.com) — 無料ティアで1日100通メール認証。他にもDEA検出・DNSルックアップ・SPF検出API等を無料提供。
* [Resend](https://resend.com) - 開発者向けトランザクションメールAPI。月3,000通、1日100通まで無料、カスタムドメイン1つ利用可能。
* [Sender](https://www.sender.net) 月15,000通、最大2,500購読者まで無料
* [Sendpulse](https://sendpulse.com) — 月500購読者、月15,000通まで無料
* [SimpleLogin](https://simplelogin.io/) – オープンソースでセルフホスト可能なメールエイリアス/転送ソリューション。無料で5エイリアス、帯域無制限、返信/送信無制限。教育関係者（学生、研究者等）は無制限で無料。
* [Substack](https://substack.com) — 無制限の無料ニュースレターサービス。有料化した場合のみ手数料が発生。
* [Sweego](https://www.sweego.io/) - ヨーロッパ拠点の開発者向けトランザクションメールAPI。1日500通まで無料。
* [Takeout](https://takeout.bysourfruit.com) - 送信が簡単な常に最新のメールサービス。月500通のトランザクションメールが無料。
* [temp-mail.io](https://temp-mail.io) — 複数メール同時利用・転送可能な無料使い捨て一時メールサービス
* [tinyletter.com](https://tinyletter.com/) — 月5,000購読者まで無料
* [Touchlead](https://touchlead.app) - リード管理、フォーム作成、オートメーション等を備えた多目的マーケティング自動化ツール。リード数・自動化数が制限された無料プラン有り
* [trashmail.com](https://www.trashmail.com) - 転送および自動アドレス有効期限付きの無料使い捨てメールアドレス
* [Tuta](https://tuta.com/) - エンドツーエンド暗号化・広告無し・トラッキング無しの安全な無料メールアカウントサービス。1GBストレージ、カレンダー1つ無料。（[有料プラン](https://tuta.com/pricing)も有り）。Tutaは[一部オープンソース](https://github.com/tutao/tutanota)でもあり、セルフホスト可能。
* [Verifalia](https://verifalia.com/email-verification-api) — メールボックス確認・使い捨てメール検出機能付きリアルタイムメール検証API。1日25通まで無料検証。
* [verimail.io](https://verimail.io/) — バルク・APIメール検証サービス。月100件まで無料検証
* [Zoho](https://www.zoho.com) — 元はメールプロバイダーだが、現在は多様なサービスを展開し、一部に無料プラン有。無料プラン提供サービス一覧 :
   - [Email](https://zoho.com/mail) 5ユーザー無料。ユーザーごと5GB、添付25MB、ドメイン1つ。
   - [Zoho Assist](https://www.zoho.com/assist) — 永久無料プランは同時リモートサポート1ライセンス、5台の無人コンピュータに無期限アクセス（商用・個人用）。
   - [Sprints](https://zoho.com/sprints) 5ユーザー、5プロジェクト、500MBストレージ無料。
   - [Docs](https://zoho.com/docs) — 5ユーザー、1GBアップロード制限、5GBストレージ。Zoho Office Suite（Writer, Sheets, Show）同梱。
   - [Projects](https://zoho.com/projects) — 3ユーザー、2プロジェクト、10MB添付まで無料。[Bugtracker](https://zoho.com/bugtracker)も同条件。
   - [Connect](https://zoho.com/connect) — 25ユーザー、3グループ、3カスタムアプリ、3ボード、3マニュアル、10連携、チャネル・イベント・フォーラム含むチームコラボが無料。
   - [Meeting](https://zoho.com/meeting) — 最大3名の会議・10名のウェビナー参加者。
   - [Vault](https://zoho.com/vault) — 個人向けパスワード管理。
   - [Showtime](https://zoho.com/showtime) — 最大5名のリモートセッショントレーニング用会議ソフト。
   - [Notebook](https://zoho.com/notebook) — Evernoteの無料代替。
   - [Wiki](https://zoho.com/wiki) — 3ユーザー、50MBストレージ、無制限ページ、zipバックアップ、RSS・Atomフィード、アクセス制御、カスタマイズCSS無料。
   - [Subscriptions](https://zoho.com/subscriptions) — 定期課金管理が20顧客/サブスクリプション、1ユーザーまで無料。決済はZohoがホスティング。直近40件の指標保存。
   - [Checkout](https://zoho.com/checkout) — 3ページ・最大50決済までの製品課金管理。
   - [Desk](https://zoho.com/desk) — 3エージェント、プライベートナレッジベース、メールチケットのカスタマーサポート。1リモート技術者・5台無人PC連携可（[Assist](https://zoho.com/assist)連携）。
   - [Cliq](https://zoho.com/cliq) — 100GBストレージ、無制限ユーザー、1チャンネル100ユーザー、SSO対応のチームチャット。
   - [Campaigns](https://zoho.com/campaigns) - メールマーケティング
   - [Forms](https://zoho.com/forms) - フォーム作成
   - [Sign](https://zoho.com/sign) - ペーパーレス署名
   - [Surveys](https://zoho.com/surveys) - オンラインアンケート
   - [Bookings](https://zoho.com/bookings) - 予約管理
* [Maileroo](https://maileroo.com) - 開発者向けSMTPリレー＆メールAPI。月5,000通、無制限ドメイン、無料メール検証、ブラックリスト監視、メールテスター等。

**[⬆️ トップへ戻る](#table-of-contents)**

## フィーチャートグル管理プラットフォーム

* [ConfigCat](https://configcat.com) - 開発者中心のフィーチャーフラグサービス。チームサイズ無制限、優れたサポート、リーズナブルな価格。無料プランで10フラグ、2環境、1プロダクト、月5百万リクエストまで。
* [Flagsmith](https://flagsmith.com) - フィーチャーフラグをウェブ・モバイル・サーバーアプリで一元管理。ホストAPI利用・プライベートクラウド配備・オンプレミス運用対応。
* [GrowthBook](https://growthbook.io) - ベイズ統計分析エンジン内蔵、オープンソースのフィーチャーフラグ＆ABテスト提供。3ユーザー、無制限フラグ・実験まで無料。
* [Hypertune](https://www.hypertune.com) - 型安全なフィーチャーフラグ、ABテスト、分析、アプリ設定、Git風バージョン管理、同期インメモリ・ローカル評価。チーム5名まで無制限フラグ・ABテスト無料。
* [Molasses](https://www.molasses.app) - 強力なフィーチャーフラグとABテスト。3環境まで各5フラグ無料。
* [Toggled.dev](https://www.toggled.dev) - エンタープライズ対応・スケーラブル・多地域対応のフィーチャートグル管理プラットフォーム。無料で10フラグ、2環境、リクエスト無制限。SDK、分析ダッシュボード、リリースカレンダー、Slack通知など全機能が無料プランに含まれる。
* [Statsig](https://www.statsig.com) - フィーチャー管理、ABテスト、分析等に強力なプラットフォーム。太っ腹な無料プランは無制限のシート・フラグ・実験・動的設定、月100万イベントまで対応。
* [Abby](https://www.tryabby.com) - オープンソースのフィーチャーフラグ＆ABテスト。コードとしての設定＆完全型付きTypeScript SDK。Next.jsやReactなどのフレームワークとも強力連携。無料枠が広くスケールも低価格。

**[⬆️ トップへ戻る](#table-of-contents)**

## フォント

* [dafont](https://www.dafont.com/) - サイト掲載フォントは著作者所有で、フリーウェア、シェアウェア、デモ、パブリックドメイン等。
* [Everything Fonts](https://everythingfonts.com/) - @font-face、単位変換、ヒンター、投稿ツールなど複数ツール提供。
* [Font Squirrel](https://www.fontsquirrel.com/) - 商用利用可能なフリーウェアフォント。厳選フォントを使いやすい形で提供。
* [Google Fonts](https://fonts.google.com/) - 多数の無料フォントをダウンロードまたはGoogle CDNリンクで簡単導入。
* [FontGet](https://www.fontget.com/) - 多様なフォントをタグ分けで整理・提供、ダウンロード可能。
* [Fontshare](https://www.fontshare.com/) - 無料フォントサービス。プロ品質フォントが増加中、個人・商用100%無料。
* [Befonts](https://befonts.com/) - 個人・商用利用可能なユニークフォント多数。
* [Font of web](https://fontofweb.com/) - サイトで使用されている全フォントと使用状況を特定可能。
* [Bunny](https://fonts.bunny.net) プライバシー重視のGoogle Fonts
* [FontsKey](https://www.fontskey.com/) - 無料・商用有料フォントを個人利用向けに提供、テキスト入力による素早い絞り込み可。
* [fonts.xz.style](https://fonts.xz.style/) 無料・オープンソースでCSS経由でウェブフォント配信。
* [Fontsensei](https://fontsensei.com/) オープンソース化されたGoogleフォントをユーザーがタグ付け。CJK（中・日・韓）フォントタグあり。

**[⬆️ トップへ戻る](#table-of-contents)**

## フォーム

* [Feathery](https://feathery.io) - 強力で開発者フレンドリーなフォームビルダー。サインアップ/ログイン、オンボーディング、決済、複雑な金融アプリ等を構築可能。無料プランで月250件送信・5フォームまで。
* [Form-Data](https://form-data.com) - ノーコードフォームバックエンド。スパム対策、メール通知、自動返信、Webhook、Zapier、リダイレクト、AJAX/POST等。無料で無制限フォーム、月20件送信、Form-Dataバッジ付きで追加2,000件。
* [FabForm](https://fabform.io/) - インテリジェント開発者向けフォームバックエンド。無料で月250件送信。モダンGUI。Google Sheets、Airtable、Slack、メール等と連携。
* [Form.taxi](https://form.taxi/) — HTMLフォーム送信エンドポイント。通知、スパムブロック、GDPR準拠データ処理。基本利用が無料。
* [Formcarry.com](https://formcarry.com) - HTTP POSTフォームエンドポイント、無料で月100件送信。
* [formingo.co](https://www.formingo.co/)- 静的サイト向け簡単HTMLフォーム。アカウント登録不要で無料開始。無料で月500件送信・カスタム返信先メールアドレス。
* [FormKeep.com](https://www.formkeep.com/) - 無制限フォーム、月50件送信、スパム対策、メール通知、HTMLエクスポート可能なドラッグ＆ドロップデザイナー。カスタムフィールド、チーム、Google Sheets・Slack・ActiveCampaign・Zapier連携等も。
* [formlets.com](https://formlets.com/) — オンラインフォーム、無制限単一ページフォーム/月、月100件送信、メール通知。
* [formspark.io](https://formspark.io/) - フォームtoメールサービス。無料で無制限フォーム・月250件送信、カスタマーサポート有。
* [Formspree.io](https://formspree.io/) — HTTP POSTリクエストでメール送信。無料枠はフォームごと月50件送信まで。
* [Formsubmit.co](https://formsubmit.co/) — HTMLフォーム用簡単エンドポイント。永久無料。登録不要。
* [Formlick.com](https://formlick.com) - Typeform代替。無料で1フォーム作成・無制限送信。プレミアムでフォーム・送信数無制限。
* [getform.io](https://getform.io/) - デザイナー・開発者向けフォームバックエンド、1フォーム、50件送信、単一ファイルアップロード、100MBストレージ。
* [HeroTofu.com](https://herotofu.com/) - ボット検知・暗号化アーカイブ対応フォームバックエンド。UI経由でメール・Slack・Zapier転送。フロントエンドは自作可。無料で無制限フォーム・月100件送信。
* [HeyForm.net](https://heyform.net/) - ドラッグ＆ドロップ型オンラインフォームビルダー。無料で無制限フォーム・無制限送信、テンプレート・スパム対策・100MBストレージ付き。
* [Tally.so](https://tally.so/) - 99%の機能が無料。無制限フォーム・無制限送信・メール通知・フォームロジック・決済・ファイルアップロード・カスタムサンクスページ等。
* [Hyperforms.app](https://hyperforms.app/) — 数秒でフォームtoメール等が作れる、バックエンド不要。個人アカウントで月50件送信無料。
* [Kwes.io](https://kwes.io/) - 高機能フォームエンドポイント。静的サイトと相性良。無料で1サイト・月50件送信。
* [Pageclip](https://pageclip.co/) - 無料で1サイト・1フォーム・月1,000件送信。
* [Qualtrics Survey](https://qualtrics.com/free-account) — 一流ツールでプロ級フォーム・アンケート作成。50+テンプレート。無料で1アンケート・各100回答・8回答タイプ。
* [Screeb](https://screeb.app/) - アプリ内アンケート・プロダクト分析。永久無料で月500MAU・無制限回答・無制限イベント・多彩な連携・エクスポート・定期レポート。
* [smartforms.dev](https://smartforms.dev/) - 強力・簡単なウェブサイト向けフォームバックエンド。永久無料で月50件送信・250MBストレージ・Zapier連携・CSV/JSONエクスポート・カスタムリダイレクト・カスタム応答ページ・Telegram/Slackボット・単一メール通知。
* [Survicate](https://survicate.com/) — 全チャネルからフィードバック収集・フォローアップアンケート送信。AIで自動分析・インサイト抽出。無料でメール・ウェブ・アプリ・モバイルアンケート・AIサーベイ作成・月25回答。
* [staticforms.xyz](https://www.staticforms.xyz/) - HTMLフォームをサーバーサイドコード無しで簡単連携。送信後、内容が登録アドレスへメール送信される。
* [stepFORM.io](https://stepform.io) - クイズ＆フォームビルダー。無料で5フォーム・各3ステップ・月50件回答。
* [Typeform.com](https://www.typeform.com/) — 美しいデザインのフォームをサイトに掲載。無料プランは1フォーム10フィールド・月100回答まで。
* [WaiverStevie.com](https://waiverstevie.com) - REST API対応電子署名プラットフォーム。Webhook通知可。無料プランは透かし付きだが無制限封筒＋署名可。
* [Web3Forms](https://web3forms.com) - 静的＆JAMStackサイト用コンタクトフォーム。バックエンド不要。無料で無制限フォーム・無制限ドメイン・月250件送信。
* [WebAsk](https://webask.io) - アンケートおよびフォームビルダー。無料プランでは、アカウントごとに3つのアンケート、月間100件の回答、アンケートごとに10個の要素が利用可能です。
* [Wufoo](https://www.wufoo.com/) - ウェブサイトで使用できるクイックフォーム。無料プランは毎月100件の送信制限があります。
* [formpost.app](https://formpost.app) - 無制限で使える無料のフォームからメールへのサービス。カスタムリダイレクト、自動応答、Webhookなども無料で設定可能。
* [Formester.com](https://formester.com) - 独自デザインのフォームをウェブサイトで共有・埋め込み可能。作成できるフォーム数や機能に制限なし。月間100件まで無料で回答を受け取れます。
* [SimplePDF.eu](https://simplepdf.eu/embed) - PDFエディターをウェブサイトに埋め込み、あらゆるPDFを入力可能フォームへ変換。無料プランではPDF数無制限、PDFごとに3件の送信が可能です。
* [forms.app](https://forms.app/) — 条件分岐や自動スコア計算、AIなどの強力な機能でオンラインフォームを作成。無料プランで100件まで回答を収集、フォームをウェブサイトへ埋め込みやリンク利用可能。
* [Qualli](https://usequalli.com) - モバイル向けインアプリアンケート。Qualli AIで最適な質問を作成。無料プランで500 MAUまで試用でき、フォーム・トリガーは無制限で作成可能。
* [Sprig](https://sprig.com/) - 月1件のインプロダクトアンケートまたはリプレイ付きアンケートを利用可能。GPT搭載AI分析付き。
* [feedback.fish](https://feedback.fish/) - 無料プランで合計25件までフィードバック収集が可能。ReactやVueコンポーネントの提供で簡単に統合できます。
* [Vidhook](https://vidhook.io/) - 高い回答率の魅力的なアンケートでフィードバックを収集。無料プランで1つのアクティブアンケート、アンケートごとに25件の回答、カスタマイズ可能なテンプレートが利用可能。

**[⬆️ 上部へ戻る](#table-of-contents)**

## 生成AI

* [Zenable](https://zenable.io) - Cursor、Windsurf、Copilotなどのツールの出力を、Policy as Codeで構築されたガードレールを利用して、企業の品質・コンプライアンス基準に自動修正。無料枠でMCPサーバーへのツールコールが1日100回、GitHub App経由の自動プルリクエストレビューが1日25回まで。
* [Keywords AI](https://keywordsai.co) - 最高のLLM監視プラットフォーム。2行のコードで200以上のLLMを呼び出す共通フォーマット。毎月10,000回の無料リクエスト、プラットフォーム機能も無料！
* [Portkey](https://portkey.ai/) - Gen AIアプリのコントロールパネル、観測スイートとAIゲートウェイ付き。毎月10,000リクエストまで無料送信・ログ化可能。
* [Braintrust](https://www.braintrustdata.com/) - Gen AI向け評価、プロンプト実験場、データ管理。無料プランで週1,000件のプライベート評価行を利用可能。
* [Findr](https://www.usefindr.com/) - あらゆるアプリを一括検索できるユニバーサルサーチ。情報を使って質問に答えるサーチアシスタント。無料プランで統合サーチ無制限、1日5回のコパイロットクエリ。
* [ReportGPT](https://ReportGPT.app) - AI搭載ライティングアシスタント。自身のAPIキー持ち込みでプラットフォーム全体を無料で利用可能。
* [Clair](https://askclair.ai/) - 臨床AIリファレンス。学生はOpen Search、Clinical Summary、Med Review、Drug Interactions、ICD-10 Codes、Stewardshipを含むプロフェッショナルツールスイートに無料でアクセス可能。プロフェッショナルスイートの無料トライアルもあり。
* [Langtrace](https://langtrace.ai) - 開発者がLLMアプリケーションのパフォーマンスに関するプロンプトやデータセットのトレース・評価・管理・デバッグを可能に。任意のLLMのオープンテレメトリ標準トレースを生成し、観測性クライアントと連携。無料プランで月5万トレース。
* [LangWatch](https://langwatch.ai) - AIチーム向けLLMOpsプラットフォーム。LLMアプリの信頼性、コスト効率、パフォーマンスを計測・監視・最適化。強力なDSPyコンポーネントでエンジニアと非技術チームの協業を実現し、GenAIプロダクトのチューニング・実運用を支援。無料プランで全機能、月1,000トレース、1ワークフローDSPyオプティマイザーを利用可能。[#opensource](https://github.com/langwatch/langwatch)
* [Comet Opik](https://www.comet.com/site/products/opik/) - 開発・本番ライフサイクルを通じてLLMアプリを評価・テスト・出荷。[#opensource](https://github.com/comet-ml/opik/)
* [Langfuse](https://langfuse.com/) - チームでLLMアプリを協働でデバッグ・分析・反復できるオープンソースのLLMエンジニアリングプラットフォーム。無料プランは月5万観測件数と全機能を利用可能。[#opensource](https://github.com/langfuse/langfuse)
* [Pollinations.AI](https://pollinations.ai/) - 使いやすい無料の画像生成AI、無料API付き。サインアップやAPIキー不要、ウェブサイトやワークフローへの統合オプション多数。[#opensource](https://github.com/pollinations/pollinations)
* [Othor AI](https://othor.ai/) - LLMを活用したビジネスインテリジェンス（BI）ソリューション。Tableau、Power BI、Lookerなどの人気BIのAIネイティブな高速・シンプル・安全な代替。Free Foreverプランで、1ユーザー・1ワークスペース・5データソース接続、分析無制限。[#opensource](https://github.com/othorai/othor.ai)
* [OpenRouter](https://openrouter.ai/models?q=free) - DeepSeek R1、V3、Llama、Moonshot AIなど多様な無料AIモデルを提供。自然言語処理に優れ、幅広い開発ニーズに対応。無料利用にはレート制限あり。さらにClaude、OpenAI、Grok、Gemini、Novaなどの有料モデルも提供。

**[⬆️ 上部へ戻る](#table-of-contents)**

## CDNと保護

* [bootstrapcdn.com](https://www.bootstrapcdn.com/) — bootstrap、bootswatch、fontawesome.io用CDN
* [cdnjs.com](https://cdnjs.com/) — シンプル・高速・信頼性抜群。Cloudflareが提供する、全ウェブサイトの11%以上で利用されている無料・オープンソースのCDNサービス。
* [developers.google.com](https://developers.google.com/speed/libraries/) — Google Hosted Librariesは、人気のオープンソースJavaScriptライブラリのCDN
* [Stellate](https://stellate.co/) - GraphQL API向けの高速・信頼性の高いCDN。2サービスまで無料。
* [jsdelivr.com](https://www.jsdelivr.com/) — npm、GitHub、WordPress、Deno等をサポートする無料・高速・信頼性の高いオープンソースCDN。
* [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — jQueryなどのサードパーティJavaScriptライブラリをホストするMicrosoft Ajax CDN
* [ovh.ie](https://www.ovh.ie/ssl-gateway/) — 無料のDDoS保護とSSL証明書
* [Skypack](https://www.skypack.dev/) — 100%ネイティブESモジュールJavaScript CDN。1ドメインあたり月100万リクエストまで無料。
* [raw.githack.com](https://raw.githack.com/) — Cloudflareを利用した**rawgit.com**のモダンな代替サービス
* [section.io](https://www.section.io/) — Varnish Cacheソリューションを簡単に構築・管理。1サイトまで永久無料とされています
* [statically.io](https://statically.io/) — Gitリポジトリ（GitHub、GitLab、Bitbucket）、WordPress関連アセット、画像用CDN
* [toranproxy.com](https://toranproxy.com/) — PackagistやGitHub用プロキシ。CD失敗知らず。個人利用・1開発者・サポートなしで無料
* [UNPKG](https://unpkg.com/) — npm上の全てのパッケージ用CDN
* [weserv](https://images.weserv.nl/) — 世界規模のキャッシュ付き画像キャッシュ＆リサイズサービス。画像のオンザフライ加工が可能。
* [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — 無料DDoS保護
* [Gcore](https://gcorelabs.com/) グローバルCDN、月1TB・100万リクエスト無料、無料DNSホスティング
* [CacheFly](https://portal.cachefly.com/signup/free2023) - 月5TBまで無料CDNトラフィック、19コアPoP、1ドメイン、ユニバーサルSSL。

**[⬆️ 上部へ戻る](#table-of-contents)**

## PaaS

* [anvil.works](https://anvil.works) - PythonだけでWebアプリ開発。無料枠でアプリ数無制限・30秒タイムアウト。
* [appwrite](https://appwrite.io) - 無制限のプロジェクト、プロジェクトの一時停止なし（WebSocket対応）、認証サービス。無料枠でプロジェクトごとにデータベース1つ、バケット3つ、関数5つ。
* [configure.it](https://www.configure.it/) — モバイルアプリ開発プラットフォーム。2プロジェクトまで無料、機能制限ありだがリソース制限なし
* [codenameone.com](https://www.codenameone.com/) — Java/Kotlin開発者向けのオープンソース・クロスプラットフォーム・モバイルアプリ開発ツールチェーン。商用利用も含めプロジェクト数無制限で無料
* [deco.cx](https://www.deco.cx/en/dev) - TypeScriptコードから自動生成されるビジュアルCMS付きエッジネイティブフロントエンドプラットフォーム。A/Bテスト、コンテンツセグメント、リアルタイム分析内蔵。コンテンツ重視・エンタープライズ向けECサイトに最適。月5,000PVまたはOSS/個人プロジェクトまで無料。
* [Deno Deploy](https://deno.com/deploy) - 世界中のエッジでJavaScript、TypeScript、WebAssemblyを実行。無料枠で1日100,000リクエスト、月100GiBデータ転送。
* [domcloud.co](https://domcloud.co) – GitHub連携CI/CD、SSH、MariaDB/Postgres DBを提供するLinuxホスティングサービス。無料版はストレージ1GB、ネットワーク1GB/月、無料ドメイン限定。
* [encore.dev](https://encore.dev/) — 静的解析で自動インフラ構築やボイラープレート不要コードなどを提供するバックエンドフレームワーク。ホビープロジェクト向けに無料クラウドホスティング付き。
* [flightcontrol.dev](https://flightcontrol.dev/) - Gitプッシュ型ワークフローでWebサービスやDBを自身のAWSアカウントにデプロイ。個人GitHubリポジトリで1開発者まで無料枠。AWS費用はAWS経由で請求（クレジットやAWS無料枠利用可）。
* [gigalixir.com](https://gigalixir.com/) - Elixir/Phoenixアプリ向け、スリープしない無料インスタンス1つと、接続2件・1万行・バックアップなしの無料PostgreSQL DBを提供。
* [Glitch](https://glitch.com/) — コード共有・リアルタイムコラボ可能な無料公開ホスティング。無料プランは月1,000時間制限。
* [leapcell](https://leapcell.io/) - 分散アプリケーションを迅速に成長させるための信頼性の高いプラットフォーム。無料プランで10万サービス呼び出し、1万非同期タスク、10万Redisコマンド。
* [pipedream.com](https://pipedream.com) - 開発者向けインテグレーションプラットフォーム。あらゆるトリガーに基づくワークフローを開発可能。[無料で](https://docs.pipedream.com/pricing/)ワークフローを実行。サーバやクラウドリソース管理不要。
* [pythonanywhere.com](https://www.pythonanywhere.com/) — クラウドPythonアプリホスティング。ビギナーアカウントは無料、1つのPythonウェブアプリ（your-username.pythonanywhere.comドメイン）、512MBプライベートファイルストレージ、MySQL DB1つ
* [ampt.dev](https://getampt.com/) - チームでAWS上にJavaScriptアプリを簡単構築・デプロイ・スケール。無料プレビュープランで1時間500回、1日2,500回、月5万回呼び出し。カスタムドメインは有料プランのみ。
* [Koyeb](https://www.koyeb.com) - Dockerコンテナ、Webアプリ、APIをグローバル展開できるサーバレスプラットフォーム。git連携デプロイ、自動スケール、エッジネットワーク、サービスメッシュ・ディスカバリ内蔵。無料インスタンスはフランクフルト（独）またはワシントンD.C.（米）にデプロイ可。無料管理Postgres DB（独・米・シンガポール）、512MBメモリ、2GBストレージ、0.1CPU。
* [Napkin](https://www.napkin.io/) - FaaS、500MBメモリ、15秒デフォルトタイムアウト、月5,000回無料APIコール（5回/秒制限）。
* [Meteor Cloud](https://www.meteor.com/cloud) — Meteorアプリ向けPaaS「Galaxy」ホスティング。無料MongoDB共有ホスティング・自動SSL付き。
* [Northflank](https://northflank.com) — 強力なUI・API・CLIでマイクロサービス・ジョブ・DBを構築・デプロイ。バージョン管理や外部Dockerレジストリからコンテナをシームレスにスケール。無料枠でサービス2つ、Cronジョブ2つ、DB1つ。
* [YepCode](https://yepcode.io) - APIやサービスをサーバレス環境で接続できるオールインワンプラットフォーム。NoCodeの俊敏性と、プログラミング言語利用のパワーを両立。無料枠で[1,000yeps](https://yepcode.io/pricing/)。
* [WunderGraph](https://cloud.wundergraph.com) - モダンAPIの高速構築・出荷・管理を可能にするオープンソースプラットフォーム。CI/CD、GitHub連携、自動HTTPS標準装備。[無料プラン](https://wundergraph.com/pricing)で3プロジェクト、1GBエグレス、月300分ビルドタイム。
* [Zeabur](https://zeabur.com) - ワンクリックでサービスをデプロイ。無料で3サービス、月5米ドル分の無料クレジット。
* [mogenius](https://mogenius.com) - Kubernetes上で簡単にサービス構築・デプロイ・実行。無料枠はローカルKubernetesとmogeniusを接続し、個人開発者が本番類似のテスト環境を自マシン上で構築可能。
* [genezio](https://genezio.com/) - サーバレスファンクションプロバイダー。月100万ファンクションコール、100GB帯域、Cronジョブ10件が無料。非商用・学術利用限定。

**[⬆️ 上部へ戻る](#table-of-contents)**

## BaaS

* [Activepieces](https://www.activepieces.com) - アプリのバックエンドで複数アプリを連携させる自動フローを構築。例：イベント発生時にSlackへ通知やGoogle Sheetsに行追加。月5,000タスクまで無料。
* [back4app.com](https://www.back4app.com) - Parse Platformベースの使いやすく柔軟・スケーラブルなバックエンド。
* [backendless.com](https://backendless.com/) — モバイル＆Web向けBaaS。ファイルストレージ1GB無料、プッシュ通知月5万回、テーブル内データオブジェクト1,000件。
* [bismuth.cloud](https://www.bismuth.cloud/) — AIがPython APIのブートストラップとホスト型ストレージを提供。オンラインエディタやローカルツールで無料構築・ホスト可能。
* [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — エンタープライズ向けデジタルイノベーション構築・展開用ドキュメント・リソース提供。プラットフォーム・SDK・コンポーネントライブラリを含む包括的なパーソナルサンドボックスへのアクセス。
* [connectycube.com](https://connectycube.com) - 無制限チャット、P2P音声・ビデオ通話、ファイル添付、プッシュ通知。1,000ユーザーまでのアプリは無料。
* [convex.dev](https://convex.dev/) - データ（リレーション・シリアライズ可能なACIDトランザクション付きドキュメント）、サーバレス関数、WebSocketによるストリーミング更新をホストするリアクティブBaaS。小規模プロジェクトは無料（最大100万レコード、月5百万関数コール）。
* [darklang.com](https://darklang.com/) - ホスト型言語とエディタ・インフラが一体化。ベータ期間中アクセス可能、ベータ後も太っ腹な無料枠予定。
* [Firebase](https://firebase.com) — アプリ構築・運用を支援。無料Sparkプランで認証・ホスティング・Firebase ML・リアルタイムDB・Cloud Storage・Testlabが利用可能。A/Bテスト、アナリティクス、アプリ配布・インデックス・クラウドメッセージング（FCM）、Crashlytics、Dynamic Links、In-App Messaging、パフォーマンス計測、予測、リモートコンフィグは常時無料。
* [Flutter Flow](https://flutterflow.io) — コードを書かずにFlutterアプリのUIを構築。Firebase連携も可能。無料プランでUIビルダー・無料テンプレートをフル活用可能。
* [getstream.io](https://getstream.io/) — 数時間でスケーラブルなアプリ内チャット・メッセージング・ビデオ/オーディオ・フィードを構築可能
* [hasura.io](https://hasura.io/) — 既存DBを拡張し、どこにホストされていても即座に安全なGraphQL APIを提供。月1GBデータパススルーまで無料。
* [nhost.io](https://nhost.io) - Web・モバイルアプリ向けサーバレスBaaS。無料プランでPostgreSQL、GraphQL（Hasura）、認証、ストレージ、サーバレス関数付き。
* [onesignal.com](https://onesignal.com/) — プッシュ通知無制限無料。メール送信は月1万件まで、コンタクト数無制限、Auto Warm Up機能利用可。
* [paraio.com](https://paraio.com) — 柔軟な認証・全文検索・キャッシュ付きのバックエンドサービスAPI。アプリ1つ・アプリデータ1GBまで無料。
  * [pubnub.com](https://www.pubnub.com/) — 最大100万メッセージ/月、100台のアクティブデバイスまで無料のプッシュ通知
  * [pushbots.com](https://pushbots.com/) — プッシュ通知サービス。最大150万プッシュ/月まで無料
  * [pushcrew.com](https://pushcrew.com/) — プッシュ通知サービス。2,000人の購読者まで無制限の通知
  * [pusher.com](https://pusher.com/beams) — 月間2,000アクティブユーザーまで無料・無制限のプッシュ通知。iOSとAndroidデバイス向けの単一API。
  * [quickblox.com](https://quickblox.com/) — インスタントメッセージング、ビデオ・音声通話、プッシュ通知のための通信バックエンド
  * [restspace.io](https://restspace.io/) - 認証、データ、ファイル、メールAPI、テンプレートなどのサービスでサーバーを構成し、それらをパイプラインに組み合わせてデータを変換。
  * [Salesforce Developer Program](https://developer.salesforce.com/signup) — ドラッグ＆ドロップツールでアプリを高速構築。クリックでデータモデルをカスタマイズ。Apexコードでさらに拡張。強力なAPIであらゆるものと統合。エンタープライズグレードのセキュリティで保護。クリックや最新WebフレームワークでUIをカスタマイズ。無料開発者プログラムでLightning Platformの全機能にアクセス可能。
  * [simperium.com](https://simperium.com/) — データを即時・自動で多プラットフォームに移動、構造化データの送信・保存は無制限、最大2,500ユーザー/月
  * [Supabase](https://supabase.com) — バックエンド構築のためのオープンソースFirebase代替。無料プランは認証、リアルタイムデータベース＆オブジェクトストレージを提供。
  * [tyk.io](https://tyk.io/) — 認証、クォータ、モニタリング、分析を備えたAPI管理。無料クラウド提供
  * [zapier.com](https://zapier.com/) — アプリ間連携でタスク自動化。15分ごとに5つのZap、100タスク/月無料
  * [IFTTT](https://ifttt.com) — お気に入りのアプリやデバイスを自動化。無料で2つのアプレット
  * [Integrately](https://integrately.com) — ワンクリックで面倒な作業を自動化。100タスク、15分の更新間隔、5つのアクティブ自動化、Webhookが無料。
  * [LeanCloud](https://leancloud.app/) — モバイルバックエンド。1GBのデータストレージ、256MBインスタンス、3,000APIリクエスト/日、10,000プッシュ/日が無料。（APIはParse Platformと非常によく似ています）
  * [Claw.cloud](https://run.claw.cloud) - 180日以上前に作成されたGitHubアカウント保有者向けに月額5ドル分の無料クレジットを提供するPaaSプラットフォーム。アプリやデータベースなどのホスティングに最適。([無料クレジット付き登録リンク](https://ap-southeast-1.run.claw.cloud/signin))。

**[⬆️ Back to Top](#table-of-contents)**

## ローコードプラットフォーム

  * [appsmith](https://www.appsmith.com/) — 管理パネル、社内ツール、ダッシュボードを構築できるローコードプロジェクト。15以上のデータベースや任意のAPIと統合可能。
  * [Basedash](https://www.basedash.com) — 社内管理パネルやダッシュボードを構築するローコードプラットフォーム。SQLデータベースとREST APIをサポート。
  * [BudiBase](https://budibase.com/) — Budibaseはオープンソースのローコードプラットフォームで、社内アプリを数分で作成可能。PostgreSQL、MySQL、MSSQL、MongoDB、Rest API、Docker、K8sをサポート
  * [Clappia](https://www.clappia.com) — カスタマイズ可能なモバイル・Webアプリで業務プロセスアプリを構築するためのローコードプラットフォーム。ドラッグ＆ドロップインターフェース、オフライン対応、リアルタイム位置追跡、多様なサードパーティ連携などを提供
  * [DronaHQ](https://www.dronahq.com/) — エンジニアリングチームやプロダクトマネージャーが社内ツールやカスタムユーザージャーニー、デジタル体験、オートメーション、カスタム管理パネル、運用アプリを10倍速く構築できるローコードプラットフォーム。
  * [lil'bots](https://www.lilbots.io/) - OpenAI、Anthropic、Firecrawlなどの無料内蔵APIを活用してオンラインでスクリプト作成・実行。AIエージェントや社内ツール構築、チーム共有に最適。無料枠でAPI全機能、AIコーディングアシスタント、月10,000実行クレジット。
  * [Mendix](https://www.mendix.com/) — エンタープライズ向け高速アプリ開発。無制限のサンドボックス環境（合計ユーザー対応、アプリごと0.5GBストレージ、1GB RAM）。Studio/Studio Pro IDEも無料枠で利用可能。
  * [outsystems.com](https://www.outsystems.com/) — オンプレミスまたはクラウド向けエンタープライズWeb開発PaaS。無料の「パーソナル環境」では無制限のコードと最大1GBデータベースが利用可能。
  * [ReTool](https://retool.com/) — 社内アプリケーション構築のためのローコードプラットフォーム。Retoolは高い拡張性を誇り、JavaScriptとAPIで作れるものはRetoolでも作成可能。無料枠は月5ユーザー、アプリ・API接続は無制限。
  * [Superblocks](https://superblocks.com/) — 開発者・技術志向チーム向けのオープンエンタープライズアプリプラットフォーム。AIで生成・編集・拡張、中央管理の統合・認証・権限・監査ログも対応。
  * [ToolJet](https://www.tooljet.com/) — ビジネスアプリ構築のための拡張性あるローコードフレームワーク。データベース、クラウドストレージ、GraphQL、API、Airtableなどと接続し、ドラッグ＆ドロップでアプリ作成。
  * [UI Bakery](https://uibakery.io) — カスタムWebアプリを高速構築できるローコードプラットフォーム。ドラッグ＆ドロップUI構築と、JavaScript/Python/SQLによる高度なカスタマイズ。クラウド・セルフホストの両対応。最大5ユーザーまで無料。
  * [manubes](https://www.manubes.com) - 工業生産管理に特化した強力なノーコードクラウドプラットフォーム。1ユーザー、月100万ワークフローアクティビティまで無料（[ドイツ語版](https://www.manubes.de)もあり）。

**[⬆️ Back to Top](#table-of-contents)**

## Webホスティング

  * [Alwaysdata](https://www.alwaysdata.com/) — 100MBの無料Webホスティング。MySQL、PostgreSQL、CouchDB、MongoDB、PHP、Python、Ruby、Node.js、Elixir、Java、Deno、カスタムWebサーバー対応。FTP、WebDAV、SSHアクセス、メールボックス、メーリングリスト、アプリインストーラー付き。
  * [Awardspace.com](https://www.awardspace.com) — 無料Webホスティング+無料短縮ドメイン、PHP、MySQL、アプリインストーラー、メール送信、広告なし。
  * [Bohr](https://bohr.io) — 非商用プロジェクトは無料。インフラ管理の手間を最小化しセットアップを加速する開発者向けデプロイ＆開発プラットフォーム。
  * [Bubble](https://bubble.io/) — ノーコードでWeb・モバイルアプリを構築できるビジュアルプログラミング、Bubbleブランド付きで無料
  * [dAppling Network](https://www.dappling.network/) - Web3フロントエンド向けの分散型Webホスティングプラットフォーム。アップタイムとセキュリティ向上、追加のユーザーアクセスポイントを提供。
  * [DigitalOcean](https://www.digitalocean.com/pricing) - App Platform Starterティアで3つの静的サイトを無料で構築・デプロイ可能。
  * [Drive To Web](https://drv.tw) — Google Drive & OneDriveから直接Web公開。静的サイト専用。永久無料。Google/Microsoftアカウントごとに1サイト。
  * [Fenix Web Server](https://preview.fenixwebserver.com) - サイトをローカルでホストし、リアルタイムで公開共有できる開発者向けデスクトップアプリ。UI、API、CLIすべてに対応。
  * [Fern](https://buildwithfern.com) - Fernの無料プランでMarkdownベースのドキュメントサイトを構築・ホスト。API定義ファイルからAPIリファレンスも自動生成可能。_yoursite_.docs.buildwithfern.com で公開。
  * [Free Hosting](https://freehostingnoads.net/) — PHP5、Perl、CGI、MySQL、FTP、ファイルマネージャ、POPメール、無料サブドメイン、無料ドメインホスティング、DNSゾーンエディタ、サイト統計、無料オンラインサポートなど、多数の機能を広告なしで提供。
  * [Freehostia](https://www.freehostia.com) — 業界最高のコントロールパネルと50以上の無料アプリのワンクリックインストールを含む無料ホスティング。即時セットアップ。強制広告なし。
  * [HelioHost](https://heliohost.org) — 非営利の無料Webホスティング。Pleskコントロールパネル、PHP、Node.js、Python、Django、Flask、.NET、Perl、CGI、MySQL、PostgreSQL、SQLite、IMAP/POP3/SMTPメール、無制限帯域、無料サブドメイン、無料で1000MBストレージ（アップグレード可能）。
  * [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — 最大100個の静的サイトを無料デプロイ、カスタムドメイン＋SSL、月100GB帯域、260以上のCloudflare CDNロケーション。
  * [Lecturify](https://www.lecturify.net/index.en.html) - SFPTアクセスでファイルアップロード・ダウンロード可能なWebホスティング、PHP対応。
  * [Neocities](https://neocities.org) — 静的、1GBの無料ストレージ＋200GB帯域
  * [Netlify](https://www.netlify.com/) — 静的サイト/アプリのビルド・デプロイ・ホスティング。100GBデータ・100GB/月帯域まで無料。
  * [pantheon.io](https://pantheon.io/) — Drupal・WordPressホスティング、自動DevOps、スケーラブルインフラ。開発者・代理店向け無料。カスタムドメイン不可。
  * [readthedocs.org](https://readthedocs.org/) — バージョン管理、PDF生成などを備えた無料ドキュメントホスティング
  * [render.com](https://render.com) — 無料SSL、グローバルCDN、プライベートネットワーク、Gitからの自動デプロイ、Webサービス・DB・静的Webページ向け完全無料プラン。
  * [SourceForge](https://sourceforge.net/) — オープンソースソフトウェアの検索、作成、公開が無料
  * [surge.sh](https://surge.sh/) — フロントエンド開発者向け静的Web公開。無制限サイト、カスタムドメイン対応
  * [telegra.ph](https://telegra.ph/) Quillを使って簡単にWebページ作成
  * [tilda.cc](https://tilda.cc/) — 1サイト、50ページ、50MBストレージ、170+ブロック中主要のみ、フォント・ファビコン・カスタムドメインなし
  * [Vercel](https://vercel.com/) — 無料SSL、グローバルCDN、`git push`ごとに一意のプレビュURLでWebアプリをビルド・デプロイ・ホスト。Next.jsや静的サイトジェネレータに最適。
  * [Versoly](https://versoly.com/) — SaaS向けサイトビルダー。無制限Webサイト、70+ブロック、5テンプレート、カスタムCSS、ファビコン、SEO、フォーム。カスタムドメイン不可。
  * [Qoddi](https://qoddi.com) - Heroku類似のPaaS、開発者志向の全機能込み。静的アセット・ステージング・開発者アプリ向け無料枠。
  * [FreeFlarum](https://freeflarum.com/) - 最大250ユーザーまでのFlarum無料ホスティング（寄付でフッターのウォーターマーク除去）。
  * [MDB GO](https://mdbgo.com/) - 1プロジェクトにつき2週間のコンテナTTL、1プロジェクトあたり500MB RAM、SFTP、1GBディスクスペースの無料ホスティング。
  * [Patr Cloud](https://patr.cloud/) — 使いやすいクラウドプラットフォーム。有料サービスの中に3つの静的サイトを無料でホスト可能。
  * [Serv00.com](https://serv00.com/) — 3GBの無料Webホスティング＋毎日バックアップ（7日）。Crontabジョブ、SSH、リポジトリ（GIT、SVN、Mercurial）、MySQL、PostgreSQL、MongoDB、PHP、Node.js、Python、Ruby、Java、Perl、TCL/TK、Lua、Erlang、Rust、Pascal、C、C++、D、Rなど多数の言語に対応。
  - [Sevalla](https://sevalla.com/) - アプリ、データベース、静的Webサイトのデプロイ管理を簡素化するホスティングプラットフォーム。1GBサイト制限、月100GB無料帯域、月600無料ビルド分、1アカウント100サイト。

**[⬆️ Back to Top](#table-of-contents)**

## DNS

  * [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Cloudflare提供の無料パブリックDNSリゾルバ（高速・安全、DNSクエリの暗号化）。プロバイダーのDNSブロック回避やDNSスパイ防止、[アダルト・マルウェアコンテンツのブロック](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families)にも有用。[API経由利用も可能](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests)。DNSリゾルバのみでDNSホスティングは不可。
  * [1984.is](https://www.1984.is/product/freedns/) — API付き無料DNSサービス。他にも多くの無料DNS機能を提供。
  * [cloudns.net](https://www.cloudns.net/) — 最大1ドメイン・50レコードまで無料DNSホスティング
  * [deSEC](https://desec.io) - セキュリティ重視で設計されたAPI対応の無料DNSホスティング。オープンソースソフトウェアで運用、[SSE](https://www.securesystems.de/)が支援。
  * [dns.he.net](https://dns.he.net/) — ダイナミックDNS対応の無料DNSホスティング
  * [Zonomi](https://zonomi.com/) — 即時DNS伝播の無料DNSホスティング。無料プラン：1DNSゾーン（ドメイン名）、最大10レコード。
  * [dnspod.com](https://www.dnspod.com/) — 無料DNSホスティング。
  * [duckdns.org](https://www.duckdns.org/) — 無料DDNS、無料枠で最大5ドメイン。各種セットアップ用ガイドあり。
  * [Dynv6.com](https://dynv6.com/) — [API対応](https://dynv6.com/docs/apis)・多種類DNSレコード（CNAME、MX、SPF、SRV、TXT等）管理可能な無料DDNSサービス。
  * [freedns.afraid.org](https://freedns.afraid.org/) — 無料DNSホスティング。多数のユーザー[提供ドメイン](https://freedns.afraid.org/domain/registry/)を利用した無料サブドメインも提供。登録後「Subdomains」メニューから取得可能。
  * [luadns.com](https://www.luadns.com/) — 無料DNSホスティング、3ドメイン、全機能制限付きで利用可能
  * [namecheap.com](https://www.namecheap.com/domains/freedns/) — 無料DNS。ドメイン数制限なし
  * [nextdns.io](https://nextdns.io) - DNSファイアウォール、月30万クエリ無料
  * [noip.at](https://noip.at/) — 登録・追跡・ログ・広告なしの無料DDNSサービス。ドメイン無制限。
  * [noip](https://www.noip.com/) — ダイナミックDNSサービス。30日ごとに確認が必要だが、最大3ホスト名まで無料
  * [sslip.io](https://sslip.io/) — ホスト名にIPアドレスを埋め込むと、そのIPを返す無料DNSサービス。
  * [zilore.com](https://zilore.com/en/dns) — 最大5ドメインまで無料DNSホスティング。
  * [zoneedit.com](https://www.zoneedit.com/free-dns/) — ダイナミックDNS対応の無料DNSホスティング。
  * [zonewatcher.com](https://zonewatcher.com) — DNS自動バックアップ＆変更監視。1ドメイン無料
  * [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – Huaweiによる無料DNSホスティング
  * [Hetzner](https://www.hetzner.com/dns-console) – HetznerによるAPI対応無料DNSホスティング。
  * [Glauca](https://docs.glauca.digital/hexdns/) – 最大3ドメイン・DNSSEC対応の無料DNSホスティング
  * [VolaryDDNS](https://volaryddns.net) - サブスクリプションや広告なしの高性能無料DDNS
**[⬆️ Back to Top](#table-of-contents)**

## ドメイン

  * [pp.ua](https://nic.ua/) — 無料の pp.ua サブドメイン。
  * [us.kg](https://nic.us.kg/) - 無料の us.kg サブドメイン。

**[⬆️ Back to Top](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — AWS S3 互換 - API、インターフェース操作、CLI、その他のアップロード方法に対応。IPFS および Arweave ネットワークから安全・便利・効率的にファイルのアップロードと保存が可能。登録ユーザーは 6GB の IPFS ストレージと 300MB の Arweave ストレージが無料。150KB 未満の Arweave ファイルアップロードは無料。
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 クラウドストレージ。無期限で 10 GB（Amazon S3 互換）のオブジェクトストレージが無料
  * [filebase.com](https://filebase.com/) - ブロックチェーンベースの S3 互換オブジェクトストレージ。無期限で 5 GB の無料ストレージ。
  * [Tebi](https://tebi.io/) - S3 互換オブジェクトストレージ。25 GB の無料ストレージと 250GB のアウトバウンド転送。
  * [Idrive e2](https://www.idrive.com/e2/) - S3 互換オブジェクトストレージ。毎月 10 GB の無料ストレージと 10 GB のダウンロード帯域幅。
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3 互換オブジェクトストレージ。毎月 15 GB の無料ストレージと 15 GB のダウンロード。

**[⬆️ Back to Top](#table-of-contents)**

## マネージドデータサービス

  * [Aiven](https://aiven.io/) - Aiven はオープンソースデータプラットフォームで PostgreSQL、MySQL、Redis の無料プランを提供。シングルノード、1CPU、1GB RAM、PostgreSQL と MySQL は 5GB ストレージ。より大規模なプランや他クラウドへの移行も簡単。
  * [airtable.com](https://airtable.com/) — スプレッドシートのような見た目だがリレーショナルデータベース。ベース数無制限、1,200行/ベース、1,000 APIリクエスト/月
  * [Astra](https://www.datastax.com/products/datastax-astra/) — クラウドネイティブ Cassandra as a Service、[80GB の無料枠](https://www.datastax.com/products/datastax-astra/pricing)
  * [codehooks.io](https://codehooks.io/) — JavaScript サーバーレス API/バックエンドと NoSQL データベースの簡単なサービス。関数、MongoDB 風クエリ、キーバリュー検索、ジョブシステム、リアルタイムメッセージ、ワーカキュー、強力な CLI と Web UI 付属。無料プランは 5GB ストレージ、60/API コール/分、開発者2名まで。クレジットカード不要。
  * [CrateDB](https://crate.io/) - 分散型オープンソース SQL データベースでリアルタイム分析向け。[無料枠 CRFREE](https://crate.io/lp-crfree)：2CPU、2GiB メモリ、8GiB ストレージの 1 ノード。1 組織につき 1 クラスター、支払い方法不要。
  * [Upstash](https://upstash.com/) — サーバーレス Redis、無料枠は 1 日あたり 10,000 リクエスト、最大データベースサイズ 256MB、20 同時接続
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - 永久無料枠のフルマネージドデータベースクラスター（IoT から AI まで対応）
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — 無料枠で 512 MB
  * [redsmin.com](https://www.redsmin.com/) — Redis のオンラインリアルタイム監視・管理サービス、1 インスタンスの監視が無料
  * [redislabs](https://redislabs.com/try-free/) - 無料 30MB Redis インスタンス
  * [MemCachier](https://www.memcachier.com/) — マネージド Memcache サービス。最大 25MB、1 プロキシサーバー、基本分析が無料
  * [scalingo.com](https://scalingo.com/) — 主に PaaS だが、MySQL、PostgreSQL、MongoDB の 128MB 〜 192MB 無料枠あり
  * [SeaTable](https://seatable.io/) — Seafile チームによる柔軟なスプレッドシート型データベース。テーブル数無制限、2,000 行、1 ヶ月バージョン管理、最大 25 チームメンバー。
  * [skyvia.com](https://skyvia.com/) — クラウドデータプラットフォーム、無料枠あり、ベータ版中はすべてのプランが完全無料
  * [StackBy](https://stackby.com/) — スプレッドシートの柔軟性、データベースの強力さ、ビジネスアプリとの統合を一つに。無料プランはユーザー無制限、10 スタック、スタックあたり 2GB 添付ファイル。
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — オープンソースの MySQL 互換分散 HTAP RDBMS。TiDB Serverless は毎月 5GB の行ストレージ、5GB の列ストレージ、5,000 万 Request Units (RU) を無料で提供。
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso はエッジデータベースの SQLite 開発体験。永久無料スタータープラン、合計 9GB ストレージ、最大 500 データベース、最大 3 ロケーション、月 10 億行リード、SQLite によるローカル開発サポート。
  * [InfluxDB](https://www.influxdata.com/) — 時系列データベース、3MB/5分 書き込み、30MB/5分 読み出し、1万系列まで無料
  * [restdb.io](https://restdb.io/) - 高速でシンプルな NoSQL クラウドデータベースサービス。スキーマ、リレーション、自動 REST API（MongoDB 風クエリ）、多人数管理 UI。無料プランは 3 ユーザー、2,500 レコード、1 秒間に 1 API リクエスト。
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — 無料枠は毎月 5,000 万 RU と 10 GiB ストレージ（15ドル相当）。([Request Units とは](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — Cypher クエリ言語と REST API を備えたマネージドグラフ DBMS/分析プラットフォーム。グラフサイズ制限（ノード 5 万、リレーション 17.5 万）。
  * [Neon](https://neon.tech/) — マネージド PostgreSQL、合計 0.5 GB ストレージ、1 プロジェクト、10 ブランチ、無制限データベース、常時利用可能なプライマリブランチ（5分後自動サスペンド）、非プライマリ計算リソースは合計月 20 時間まで。
  * [Prisma Postgres](https://prisma.io/postgres) - 超高速ホスト型 Postgres（ユニカーネル上、ベアメタル稼働）、1GB ストレージ、10 データベース、Prisma ORM 統合。
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — GraphQL API 搭載のマネージドネイティブグラフ DBMS。1 日あたり 1 MB データ転送まで。
  * [Tinybird](https://tinybird.co) - サーバーレス運用の ClickHouse、HTTP 経由でコネクションレスなデータ投入、SQL クエリを HTTP API として公開。無料枠は期間無制限、10GB ストレージ＋1,000 APIリクエスト/日。
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — SQL ライクなグラフクエリ言語と REST API を備えたマネージドグラフ DBMS/分析プラットフォーム。無料インスタンスは 2 vCPU、8GB メモリ、50GB ストレージ、1 時間の非アクティブでスリープ。
  * [TerminusCMS](https://terminusdb.com/pricing) — Prolog と Rust で書かれたドキュメント＆グラフ DB TerminusDB のマネージド無料サービス。開発用は無料、エンタープライズ導入・サポートは有料。
  * [filess.io](https://filess.io) - MySQL、MariaDB、MongoDB、PostgreSQL のいずれかで最大 10 MB/データベースのデータベースを 2 つまで無料で作成可能。
  * [xata.io](https://xata.io) - サーバーレスデータベース、強力な検索＆分析搭載。1 API、複数型安全クライアントライブラリ、開発フロー最適化。永久無料枠はホビーユーザー向け、3 ユニット付属（ユニット定義は公式参照）。
  * [8base.com](https://www.8base.com/) - MySQL・GraphQL ベース、サーバーレスバックエンドのフルスタックローコード開発プラットフォーム。UIアプリビルダーで迅速構築・スケールが可能。無料枠は行数 2,500、ストレージ 500、サーバーレス計算 1Gb/h、クライアントアプリユーザー 5。
  * [Nile](https://www.thenile.dev/) — B2B アプリ向けの Postgres プラットフォーム。データベース無制限、常時利用可能、合計 1GB ストレージ、5,000 万クエリトークン、自動スケーリング、ベクター埋め込み無制限



**[⬆️ Back to Top](#table-of-contents)**

## トンネリング、WebRTC、Web ソケットサーバーおよびその他のルーター

  * [Pinggy](https://pinggy.io) — コマンド一つでローカルホストに公開URLを付与、ダウンロード不要。HTTPS / TCP / TLS トンネル。無料プランは 60 分のトンネル寿命。
  * [conveyor.cloud](https://conveyor.cloud/) — Visual Studio 拡張機能で IIS Express をローカルネットワークやトンネル経由で公開URLに。
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi は LAN のようなネットワークを分散チームへ安全に拡張するホスト型 VPN サービス。無料プランは最大 5 人で無制限ネットワーク可能
  * [Mirna Sockets](https://mirna.cloud/) - デプロイ時に wss:// URL を取得できる無料ソケット as a Service プラットフォーム。パフォーマンス監視も可。
  * [localhost.run](https://localhost.run/) — ローカルで動作するサーバーをトンネル経由で公開URL化。
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — ローカルサーバーをトンネル経由で公開URL化。無料ホストバージョン、[オープンソース](https://github.com/localtunnel/localtunnel)。
  * [ngrok.com](https://ngrok.com/) — ローカルサーバーをトンネル経由で公開URL化。
  * [cname.dev](https://cname.dev/) — 無料かつ安全な動的リバースプロキシサービス。
  * [serveo](https://serveo.net/) — ローカルサーバーをインターネットに公開。インストール・登録不要。無料サブドメイン、制限なし。
  * [Radmin VPN](https://www.radmin-vpn.com/) — 複数コンピュータを VPN で接続し LAN のようなネットワークに。ピア無制限。（Hamachi の代替）
  * [segment.com](https://segment.com/) — イベントをサードパーティサービスへ転送・ルーティングするハブ。10 万イベント/月無料
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — ゼロ構成 VPN、オープンソース WireGuard プロトコル利用。MacOS/iOS/Windows/Linux/Android に対応。個人利用無料プランは 100 台・3 ユーザーまで。
  * [webhookrelay.com](https://webhookrelay.com) — Webhook の管理・デバッグ・ファンアウト・プロキシを公的または内部（localhost など）宛先へ。プライベートネットワークのサーバーをトンネル経由で公開 HTTP エンドポイント化も可能（`https://yoursubdomain.webrelay.io <----> http://localhost:8080`）。
  * [Hookdeck](https://hookdeck.com/pricing) — どこからでも Webhook の開発・テスト・監視。月 10 万リクエスト＆10 万試行、3 日間保持。
  * [Xirsys](https://www.xirsys.com/pricing/) — STUN 無制限利用＋毎月 500 MB TURN 帯域、帯域制限あり、単一地域。
  * [ZeroTier](https://www.zerotier.com) — FOSS 管理型仮想イーサネット as a Service。無料プランはクライアント 25 台までエンドツーエンド暗号化ネットワーク無制限。デスクトップ/モバイルクライアント、Web UI でカスタムルーティングや新規ノード承認も可。
  * [LocalXpose](https://localxpose.io) — ローカルホストサーバーをインターネットへ公開するリバースプロキシ。無料プランは 15 分のトンネル寿命。
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - ローカル稼働サービスをトンネルでカスタムURLに公開、アクセス制御付きで保護。1 クラスタにつき 5 サービスまで無料。
  * [Expose](https://expose.dev/) - ローカルサイトを安全なトンネルで公開。無料プランは EU サーバー、ランダムサブドメイン、シングルユーザー。
  * [btunnel](https://www.btunnel.in/) — ローカルホストやローカル TCP サーバーをインターネットへ公開。無料プランはファイルサーバー、カスタム HTTP ヘッダー、ベーシック認証、1 時間トンネルタイムアウト。

**[⬆️ Back to Top](#table-of-contents)**

## 課題管理・プロジェクト管理

  * [acunote.com](https://www.acunote.com/) — 最大 5 名のチームメンバーで利用できる無料プロジェクト管理・SCRUM ソフトウェア
  * [asana.com](https://asana.com/) — コラボレーター付きのプライベートプロジェクトは無料
  * [Backlog](https://backlog.com) — チームのための全てを 1 つにまとめたプロジェクト管理プラットフォーム。無料プランは 1 プロジェクト、10 ユーザー、100MB ストレージ。
  * [Basecamp](https://basecamp.com/personal) - ToDo リスト、マイルストーン管理、掲示板メッセージ、ファイル共有、タイムトラッキング。最大 3 プロジェクト、20 ユーザー、1GB ストレージ。
  * [bitrix24.com](https://www.bitrix24.com/) — 社内イントラネット・プロジェクト管理ツール。無料プランは無制限ユーザーで 5GB。
  * [cacoo.com](https://cacoo.com/) — オンラインリアルタイム図作成（フローチャート、UML、ネットワーク）。無料は最大 15 ユーザー/図、25 シート。
  * [Chpokify](https://chpokify.com/) — チームベースのプランニングポーカーでスプリント見積もりを効率化。最大 5 ユーザー、Jira 連携、ビデオ通話・チーム・セッション無制限。
  * [clickup.com](https://clickup.com/) — プロジェクト管理。無料、プレミアムはクラウドストレージ付。モバイルアプリや Git 連携も利用可能。
  * [Clockify](https://clockify.me) - 作業時間をプロジェクトごとに記録できるタイムトラッカー＆タイムシートアプリ。ユーザー無制限、永久無料。
  * [Cloudcraft](https://cloudcraft.co/) — AWS 最適化のビジュアルデザイナーで数分でプロ建築図作成。無料プランは 1 ユーザー用でプライベート図無制限。
  * [Codegiant](https://codegiant.io) — プロジェクト管理、リポジトリホスティング＆CI/CD。無料プランはリポジトリ・プロジェクト・ドキュメント無制限＆5チームメンバー、月 500 CI/CD 分、月 30,000 サーバーレス実行分、1GB リポジトリストレージ。
  * [Confluence](https://www.atlassian.com/software/confluence) - Atlassian のコンテンツコラボレーションツール。最大 10 ユーザーまで無料プラン。
  * [contriber.com](https://www.contriber.com/) — カスタマイズ可能なプロジェクト管理プラットフォーム。無料スタータープラン、5 ワークスペース
* [Crosswork](https://crosswork.app/) - 多目的なプロジェクト管理プラットフォーム。最大3プロジェクト、無制限ユーザー、1GBストレージまで無料。
* [diagrams.net](https://app.diagrams.net/) — オンラインダイアグラムをGoogle Drive、OneDrive、Dropboxにローカル保存。全機能・全ストレージレベルで無料
* [freedcamp.com](https://freedcamp.com/) - タスク、ディスカッション、マイルストーン、タイムトラッキング、カレンダー、ファイル、パスワードマネージャー。無制限プロジェクト・ユーザー・ファイルストレージの無料プラン。
* [easyretro.io](https://www.easyretro.io/) — シンプルで直感的なスプリント回顧ツール。無料プランは、3つの公開ボードと、ボードごとに月1回のアンケート付き。
* [GForge](https://gforge.com) — 複雑なプロジェクト向けのプロジェクト管理・課題追跡ツールセット。オンプレミス・SaaSの選択可能。SaaSの無料プランは最初の5ユーザー無料＆オープンソースプロジェクトは無料。
* [gleek.io](https://www.gleek.io) — 開発者向けの説明文からダイアグラムを生成する無料ツール。キーワードを使って非公式のUMLクラス、オブジェクト、ER図を作成。
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspectorは2つのGraphQLスキーマ間の変更リストを出力。各差分は詳細に説明され、破壊的/非破壊的/危険とマークされます。
* [huboard.com](https://huboard.com/) — GitHubイシュー向けの即時プロジェクト管理、オープンソースは無料
* [Hygger](https://hygger.io) — プロジェクト管理プラットフォーム。無料プランは無制限ユーザー、プロジェクト、ボード、100MBストレージ。
* [Instabug](https://instabug.com) — モバイルアプリ向け包括的バグレポート＆インアプリフィードバックSDK。1アプリ・1メンバーまで無料プランあり。
* [WishKit](https://wishkit.io) — iOS/macOSアプリのインアプリユーザーフィードバック収集と、ユーザー投票による機能優先順位付け。1アプリまで無料プラン。
* [Ilograph](https://www.ilograph.com/)  — インフラを複数の視点・詳細レベルで可視化できるインタラクティブダイアグラム。コードでチャート表現可能。無料枠は無制限のプライベートダイアグラム（最大3ビューアまで）。
* [Jira](https://www.atlassian.com/software/jira) — 多くの企業環境で使われる高度なソフトウェア開発プロジェクト管理ツール。10ユーザーまで無料プラン。
* [kanbanflow.com](https://kanbanflow.com/) — ボードベースのプロジェクト管理。無料、有料版は追加オプションあり
* [kanbantool.com](https://kanbantool.com/) — カンバンボード型プロジェクト管理。無料プランは2ボード・2ユーザー、添付・ファイルなし。
* [kan.bn](https://kan.bn/) - 強力で柔軟なカンバンアプリ。作業整理、進捗トラッキング、成果物納品を一括管理。1ユーザーで無制限ボード・リスト・カードが無料。
* [Kitemaker.co](https://kitemaker.co) - Slack, Discord, Figma, Githubと連携しながら全開発プロセスを一括管理。無制限ユーザー・スペース。250ワークアイテムまで無料プラン。
* [Kiter.app](https://www.kiter.app/) - 誰でも就職活動を整理し、面接・求人・コネクションを管理できるWebアプリ＆Chrome拡張。完全無料。
* [Kumu.io](https://kumu.io/)  — アニメーション・装飾・フィルタ・クラスタリング・スプレッドシート取込等付きのリレーションマップ。無料枠は無制限公開プロジェクト。グラフサイズ無制限。学生はプライベートプロジェクトも無料。ファイルを公開したくない場合のサンドボックスモードも利用可（アップロード、編集、ダウンロード、破棄）。
* [Linear](https://linear.app/) — 洗練されたUIのイシュートラッカー。無制限メンバー、ファイルアップロード最大10MB、250イシュー（アーカイブ除く）まで無料
* [leiga.com](https://www.leiga.com/) — LeigaはAIで自動プロジェクト管理し、チームの集中力と潜在能力を最大化、計画通り進行を支援。10ユーザー、20カスタムフィールド、2GBストレージ、AIビデオ録画5分/本、オートメーション20回/ユーザー/月まで無料。
* [Lucidchart](https://www.lucidchart.com/) - コラボレーション機能付きオンラインダイアグラムツール。3つの編集可能ドキュメント、100のプロテンプレート、基本的な協業機能で無料プラン。
* [MeisterTask](https://www.meistertask.com/) — チーム向けオンラインタスク管理。3プロジェクト・無制限メンバーまで無料。
* [MeuScrum](https://www.meuscrum.com/en) - 無料オンラインスクラムツール（カンバンボード付き）
* [nTask](https://www.ntaskmanager.com/) — チームのコラボ・計画・分析・日常タスク管理用プロジェクト管理ソフト。エッセンシャルプランは100MBストレージ・5ユーザー/チームで永久無料。無制限ワークスペース、会議、割当、タイムシート、イシュートラッキング。
* [Ora](https://ora.pm/) - アジャイルタスク管理＆チームコラボレーション。3ユーザーまで無料、ファイルは10MB制限。
* [pivotaltracker.com](https://www.pivotaltracker.com/) — 無制限パブリックプロジェクトと2つのプライベートプロジェクト（合計3アクティブユーザー（書き込み可能）・無制限パッシブユーザー（読み取り専用））まで無料。
* [plan.io](https://plan.io/) — リポジトリホスティング付きプロジェクト管理。2ユーザー・10顧客・500MBストレージまで無料
* [Plane](https://plane.so/) - シンプルかつ拡張可能なオープンソースプロジェクト＆プロダクト管理ツール。無制限メンバー、最大5MBファイルアップロード、1000イシューまで無料。
* [planitpoker.com](https://www.planitpoker.com/) — 無料オンラインプランニングポーカー（見積もりツール）
* [point.poker](https://www.point.poker/) - オンラインプランニングポーカー（合意形成型見積もりツール）。無制限ユーザー・チーム・セッション・ラウンド・投票が無料。登録不要。
* [ScrumFast](https://www.scrumfast.com) - 直感的なUIのスクラムボード、5ユーザーまで無料。
* [Shake](https://www.shakebugs.com/) - モバイルアプリ向けインアプリバグレポート＆フィードバックツール。無料プランはアプリごとに月10件のバグレポート。
* [Shortcut](https://shortcut.com/) - プロジェクト管理プラットフォーム。10ユーザーまで永久無料。
* [Tadum](https://tadum.app) - 定例会議向けアジェンダ・議事録アプリ。10人までのチームは無料。
* [taiga.io](https://taiga.io/) — スタートアップやアジャイル開発者向けプロジェクト管理プラットフォーム、オープンソースは無料
* [Tara AI](https://tara.ai/) — シンプルなスプリント管理サービス。無制限タスク・スプリント・ワークスペース、ユーザー制限なしで無料。
* [targetprocess.com](https://www.targetprocess.com/) — カンバンやスクラムからあらゆる業務プロセスまで対応するビジュアルプロジェクト管理。無制限ユーザー、最大1,000データエンティティまで無料 {[詳細はこちら](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — リアルタイム共同タスクリスト＆チームアウトライン。無料プランはワークスペース1つ、無制限タスク・プロジェクト、1GBファイルストレージ、1週間のプロジェクト履歴、ビデオ会議5人まで。
* [taskulu.com](https://taskulu.com/) — ロールベースのプロジェクト管理。5ユーザーまで無料。GitHub/Trello/Dropbox/Google Drive連携。
* [Teaminal](https://www.teaminal.com) - リモートチーム向けスタンドアップ、レトロ、スプリント計画ツール。15ユーザーまで無料。
* [teamwork.com](https://teamwork.com/) — プロジェクト管理＆チームチャット。5ユーザー・2プロジェクトまで無料。プレミアムプランもあり。
* [teleretro.com](https://www.teleretro.com/) — アイスブレイクやGIF・絵文字付きのシンプルで楽しい回顧ツール。無料プランは3レトロ・無制限メンバー。
* [testlio.com](https://testlio.com/) — 課題管理・テスト管理・ベータテストプラットフォーム。私的利用は無料
* [terrastruct.com](https://terrastruct.com/) — ソフトウェアアーキテクチャ専用オンラインダイアグラム作成。無料枠はダイアグラム1枚につき4レイヤーまで。
* [todoist.com](https://todoist.com/) — 協業・個人タスク管理。無料プランは: アクティブプロジェクト5つ、プロジェクトごとに5ユーザー、5MBまでのファイルアップロード、3つのフィルター、1週間のアクティビティ履歴。
* [trello.com](https://trello.com/) — ボード型プロジェクト管理。無制限パーソナルボード、チームボード10個。
* [Tweek](https://tweek.so/) — シンプルな週次ToDoカレンダー＆タスク管理。
* [ubertesters.com](https://ubertesters.com/) — テストプラットフォーム・統合・クラウドテスター、2プロジェクト・5メンバーまで
* [Wikifactory](https://wikifactory.com/) — プロダクト設計サービス（プロジェクト・VCS・イシュー管理付き）。無料プランは無制限プロジェクト・コラボレーター、3GBストレージ。
* [Yodiz](https://www.yodiz.com/) — アジャイル開発＆課題管理。3ユーザー・無制限プロジェクトまで無料。
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — FOSSプロジェクト・プライベートプロジェクト向け無料ホスト型YouTrack（InCloud）（3ユーザーまで無料）。タイムトラッキング・アジャイルボード付き
* [zenhub.com](https://www.zenhub.com) — GitHub内唯一のプロジェクト管理ソリューション。パブリックリポジトリ、OSS、非営利団体は無料
* [zenkit.com](https://zenkit.com) — プロジェクト管理・コラボレーションツール。5メンバー・5GB添付まで無料。
* [Zube](https://zube.io) — プロジェクト管理、無料プランは4プロジェクト・4ユーザー。GitHub連携可能。
* [Toggl](https://toggl.com/) — 2つの無料生産性ツールを提供。[Toggl Track](https://toggl.com/track/)はフリーランス向けのタイムトラッキング＆レポーティングアプリで、無制限の記録・プロジェクト・クライアント・タグ・レポートが無料。[Toggl Plan](https://toggl.com/plan/)はソロ開発者向けタスク計画、無制限タスク・マイルストーン・タイムラインが無料。
* [Sflow](https://sflow.io) — sflow.ioはアジャイルソフトウェア開発、マーケティング、営業、カスタマーサポート向けのプロジェクト管理ツールで、特に外注や組織横断型プロジェクトに最適。3プロジェクト・5メンバーまで無料。
* [Pulse.red](https://pulse.red) — プロジェクト用の無料ミニマルタイムトラッカー＆タイムシートアプリ。

**[⬆️ 上へ戻る](#table-of-contents)**

## ストレージ・メディア処理

* [AndroidFileHost](https://androidfilehost.com/) - 無制限の速度・帯域・ファイル数・ダウンロード数で利用できる無料ファイル共有プラットフォーム。主にAndroid開発関連（APKビルド・カスタムROM・改造など）向けだが、他のファイルも受け入れられる模様。
* [borgbase.com](https://www.borgbase.com/) — Borg Backup用のシンプルかつ安全なオフサイトバックアップホスティング。10GBの無料バックアップスペースと2リポジトリ。
* [icedrive.net](https://www.icedrive.net/) - シンプルなクラウドストレージサービス。10GB無料ストレージ
* [sync.com](https://www.sync.com/) - エンドツーエンド暗号化のクラウドストレージサービス。5GB無料ストレージ
* [pcloud.com](https://www.pcloud.com/) - クラウドストレージサービス。最大10GB無料ストレージ
* [sirv.com](https://sirv.com/) — スマート画像CDN、リアルタイム画像最適化＆リサイズ。無料枠は500MBストレージ・2GB帯域。
* [cloudimage.io](https://www.cloudimage.io/en/home) — 世界中に1500以上のPoPを持つ画像最適化＆CDNサービス。様々な画像リサイズ・圧縮・透かし機能。レスポンシブ画像・360度画像・画像編集用オープンソースプラグインあり。月額無料プランはCDNトラフィック25GB、キャッシュストレージ25GB、変換は無制限。
* [cloudinary.com](https://cloudinary.com/) — 画像アップロード、強力な画像操作、ストレージ、配信。Ruby, Python, Java, PHP, Objective-C等ライブラリあり。無料枠は毎月25クレジット（1クレジット=画像変換1,000回、1GBストレージ、1GB CDN利用）。
* [embed.ly](https://embed.ly/) — Webページへのメディア埋め込みAPI、レスポンシブ画像スケーリング、ページ要素抽出。5,000URL/月・15リクエスト/秒まで無料
* [filestack.com](https://www.filestack.com/) — ファイルピッカー、変換、配信。250ファイル・500変換・3GB帯域まで無料
* [file.io](https://www.file.io) - 2GBファイルストレージ。ファイルは1回ダウンロード後自動削除。REST APIでストレージ操作可。1分1回までのレート制限。
* [freetools.site](https://freetools.site/) — 無料オンラインツール。ドキュメント・画像・音声・動画等の変換・編集が可能。
* [GoFile.io](https://gofile.io/) - 無料ファイル共有・ストレージプラットフォーム。Web UI・APIどちらでも利用可能。ファイルサイズ・帯域・ダウンロード数無制限。ただし10日以上ダウンロードがないファイルは削除される。
* [gumlet.com](https://www.gumlet.com/) — 画像・動画ホスティング、処理、CDN配信。動画は月250GB、画像は月30GBまでの無料枠が充実。
* [image-charts.com](https://www.image-charts.com/) — 透かし付きで無制限に画像チャートを生成可能
* [Imgbot](https://github.com/marketplace/imgbot) — Imgbotは画像を最適化してファイルサイズを削減するフレンドリーロボット。品質を維持しつつサイズ削減。オープンソースは無料。
* [ImgBB](https://imgbb.com/) — ImgBBは無制限画像ホスティングサービス。画面上どこでもドラッグ＆ドロップでアップロード。1枚32MB制限。アップロード後はダイレクト画像リンク、BBCode、HTMLサムネイル取得可。ログインで履歴確認可。
* [imgen](https://www.jitbit.com/imgen/) - 無制限・透かし無しのソーシャルカバー画像生成API
* [imgix](https://www.imgix.com/) - 画像キャッシュ・管理・CDN。無料プランは1000オリジン画像、無制限変換、100GB帯域
* [kraken.io](https://kraken.io/) — ウェブパフォーマンス向上のための画像最適化サービス。無料プランは1MBまでのファイル
* [kvstore.io](https://www.kvstore.io/) — キー・バリュー型ストレージサービス。無料枠は100キー、1KB/キー、100コール/時
* [npoint.io](https://www.npoint.io/) — コラボスキーマ編集付きJSONストア
* [nitropack.io](https://nitropack.io/) - サイトのフロントエンド最適化（キャッシュ・画像＆コード最適化・CDN）を自動化。月5,000PVまで無料
* [otixo.com](https://www.otixo.com/) — クラウドストレージファイルの暗号化・共有・コピー・移動を一元管理。ベーシックプランは無制限転送、最大250MB/ファイル、暗号化ファイル5つまで
* [packagecloud.io](https://packagecloud.io/) — YUM、APT、RubyGem、PyPI用ホスト型パッケージリポジトリ。リクエストにより無料・OSSプランあり
* [getpantry.cloud](https://getpantry.cloud/) — 個人プロジェクト、ハッカソン、モバイルアプリに最適なシンプルJSONデータストレージAPI！
* [Pinata IPFS](https://pinata.cloud) — IPFSへのファイルアップロード・管理が簡単なPinata。UIとIPFS APIで使いやすい。1GBストレージ無料、API利用可。
* [placekitten.com](https://placekitten.com/) — プレースホルダー用子猫画像を素早くシンプルに取得できるサービス
* [plot.ly](https://plot.ly/) — データのグラフ化・共有。無料枠は無制限公開ファイル・10個のプライベートファイル
* [podio.com](https://podio.com/) — 最大5人チームでベーシックプランの機能（ユーザー管理除く）を体験可能
* [QRME.SH](https://qrme.sh) - ログイン不要・透かし無し・広告無しの高速・美麗な一括QRコード生成。バルクエクスポートは最大100URL。
* [QuickChart](https://quickchart.io) — 埋め込み用画像チャート・グラフ・QRコードを生成
* [redbooth.com](https://redbooth.com) — P2Pファイル同期、2ユーザーまで無料
* [resmush.it](https://resmush.it) — reSmush.itは画像最適化を提供する無料API。WordPress、Drupal、Magento等で実装済。70億枚以上の画像を無料で最適化済み。
* [Shotstack](https://shotstack.io) - 大規模な動画生成・編集API。月20分までのレンダリング動画が無料
* [tinypng.com](https://tinypng.com/) — PNG/JPEG画像の圧縮・リサイズAPI、毎月500回まで無料
* [transloadit.com](https://transloadit.com/) — ファイルアップロード・動画/音声/画像/ドキュメントのエンコードを処理。オープンソース・慈善団体・学生はGitHub Student Developer Pack経由で無料。商用アプリは2GBまで無料お試し
* [twicpics.com](https://www.twicpics.com) - レスポンシブ画像をサービスとして提供。画像CDN、メディア処理API、フロントエンドライブラリによる画像最適化の自動化を実現。月間3GBのトラフィックまで無料。
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcareは、最先端のアルゴリズムに基づいた究極のツールキットを備えたメディアパイプラインを提供します。全ての機能が開発者向けに完全無料で利用可能：ファイルアップロードAPI＆UI、画像CDNとオリジンサービス、アダプティブデリバリー、スマート圧縮。無料枠は3,000件のアップロード、3GBのトラフィック、3GBのストレージ。
* [imagekit.io](https://imagekit.io) – 既存のセットアップに数分で統合できる自動最適化、リアルタイム変換、ストレージ付きの画像CDN。無料プランは月間最大20GBの帯域幅を含む。
* [internxt.com](https://internxt.com) – Internxt Driveは完全なプライバシーと妥協のないセキュリティに基づくゼロ知識ファイルストレージサービス。サインアップで10GBを永年無料でもらえます！
* [degoo.com](https://degoo.com/) – AIベースのクラウドストレージ、最大20GB、3台のデバイス、5GBの紹介ボーナス付き（90日間アカウント非アクティブで制限）。
* [MConverter.eu](https://mconverter.eu/) – ファイルをまとめて変換。新しい[AVIF](https://mconverter.eu/convert/to/avif/)など多くのファイル形式に対応。動画から全画像フレームの抽出も可能。1日最大10ファイル（各100MB）まで無料、2ファイルずつバッチ処理。
* [ImageEngine](https://imageengine.io/) – 簡単に使えるグローバル画像CDN。60秒未満でセットアップ可能。AVIFとJPEGXLサポート、WordPress・Magento・React・Vueプラグインなど。無料開発者アカウントは[こちら](https://imageengine.io/developer-program/)。
* [DocsParse](https://docsparse.com/) – GPT搭載AIによるPDFや画像の構造化データ（JSON, CSV, EXCEL）への変換。毎月30クレジット分無料。
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – ギフトカード、ギフトバウチャー、プロモーション向けカスタムQRコードを簡単作成。カスタムスタイリング、色、ロゴ対応。
* [LibreQR](https://libreqr.com) — プライバシー重視＆追跡なしの無料QRコードジェネレーター。データ収集なしで自由に利用可能。


**[⬆️ トップに戻る](#table-of-contents)**

## デザインとUI

* [AllTheFreeStock](https://allthefreestock.com) - 無料ストック画像、音声、動画の厳選リスト。
* [Float UI](https://floatui.com/) - ノンデザイナーでもモダンでレスポンシブなWebサイトを素早く作成できる無料Web開発ツール。
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Motionのモーションコンポーネントで構築されたテンプレート。豊富なホームページテンプレートとテンプレートコードパッケージをダウンロードしてすぐ利用可能。エディターで独自ページも素早く作成可能。
* [Backlight](https://backlight.dev/) — 開発者とデザイナーの協働を重視した、デザインシステム構築・ドキュメント化・公開・管理のための完全なコーディングプラットフォーム。無料プランは1つのデザインシステムを3人の編集者＋無制限の閲覧者で利用可能。
* [BoxySVG](https://boxy-svg.com/app) — SVG描画＆SVG, PNG, JPEG等へのエクスポートができる無料インストール型Webアプリ。
* [Carousel Hero](https://carouselhero.com/) - SNS用カルーセルを無料でオンライン作成。
* [Circum Icons](https://circumicons.com) - SVG形式でReact, Vue, Svelte向けの一貫性あるオープンソースアイコン。
* [clevebrush.com](https://www.cleverbrush.com/) — 無料グラフィックデザイン/フォトコラージュアプリ。コンポーネントとしての有料組み込みも提供。
* [cloudconvert.com](https://cloudconvert.com/) — 何でも何かに変換。動画やGIFを含む208種の形式対応。
* [CodeMyUI](https://codemyui.com) - コードスニペット付きのWebデザイン＆UIインスピレーション厳選コレクション。
* [ColorKit](https://colorkit.co/) - オンラインでカラーパレットを作成、人気パレットからインスピレーションも得られる。
* [coolors](https://coolors.co/) - カラーパレット自動生成ツール。無料。
* [CMYK Pantone](https://www.cmyktopantone.com/) - CMYK値から最も近いPantone色や他カラーモデルに即座に無料変換。
* [Branition](https://branition.com/colors) - ブランドに最適な手作業厳選カラーパレット。
* [css-gradient.com](https://www.css-gradient.com/) - カスタムCSSグラデーションを素早く無料生成。RGB・HEX対応。
* [easyvectors.com](https://easyvectors.com/) — 無料SVGベクターアート素材サイト。高品質ベクターグラフィックが完全無料ダウンロード可。
* [figma.com](https://www.figma.com) — オンライン共同デザインツール。無料枠は無制限のファイル＆閲覧者、最大2名の編集者＆3プロジェクト。
* [Flyon UI](https://flyonui.com/)- Tailwind CSS用の最も簡単なコンポーネントライブラリ。
* [framer.com](https://www.framer.com/) - 次アプリ・Web・製品のUIアイデアを強力なレイアウトで反復・アニメーション化。プロトタイピング検証向けは無制限閲覧者、2名までの編集者、3プロジェクトまで無料。
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — FFCU モデル・プロパティリリース済みストック写真。
* [Gradientos](https://www.gradientos.app) - グラデーションの選択を素早く簡単に。
* [Icon Horse](https://icon.horse) – 任意のWebサイトの最高解像度ファビコンをシンプルAPIで取得。
* [Iconoir](https://iconoir.com) – 数千点のアイコン収録オープンソースアイコンライブラリ。React, React Native, Flutter, Vue, Figma, Framer対応。
* [Icons8](https://icons8.com) — アイコン、イラスト、写真、音楽、デザインツール。無料プランは低解像度＆限定形式。利用時はIcons8へのリンク必須。
* [landen.co](https://www.landen.co) — コード不要で美しいWebサイト・ランディングページを作成・編集・公開。無料枠は1サイト、完全カスタマイズ＆公開可能。
* [Quant Ux](https://quant-ux.com/) - プロトタイピング＆デザインツール。完全無料＆オープンソース。
* [lensdump.com](https://lensdump.com/) - 無料クラウド画像ホスティング。
* [Lorem Picsum](https://picsum.photos/) - 無料スタイリッシュなプレースホルダー画像生成ツール。URLに幅・高さを追加でランダム画像取得。
* [LottieFiles](https://lottiefiles.com/) - 世界最大のLottieアニメーションプラットフォーム。Android, iOS, Web用Lottieアニメーションツール＆プラグイン提供。
* [MagicPattern](https://www.magicpattern.design/tools) — CSS＆SVG背景ジェネレーター＆グラデーション・パターン・ブロブ用ツール集。
* [marvelapp.com](https://marvelapp.com/) — デザイン・プロトタイピング・コラボレーション。無料プランは1ユーザー・1プロジェクト制限。
* [Mindmup.com](https://www.mindmup.com/) — 無制限マインドマップを無料でクラウド保存。どの端末からでも即座に利用可能。
* [Mockplus iDoc](https://www.mockplus.com/idoc) - 強力なデザインコラボレーション＆ハンドオフツール。無料プランは3ユーザー・5プロジェクト、全機能利用可能。
* [mockupmark.com](https://mockupmark.com/create/free) — SNS・EC用リアルなTシャツ・衣類モックアップ40種無料作成。
* [Mossaik](https://mossaik.app) - 波・ブロブ・パターンなど様々なツールを備えた無料SVG画像ジェネレーター。
* [movingpencils.com](https://movingpencils.com) — 高速・ブラウザベースのベクターエディタ。完全無料。
* [Octopus.do](https://octopus.do) — ビジュアルサイトマップビルダー。リアルタイムでサイト構造作成＆チーム・顧客と共有可能。
* [Pencil](https://github.com/evolus/pencil) - Electronベースのオープンソースデザインツール。
* [Penpot](https://penpot.app) - Webベース・オープンソースのデザイン＆プロトタイピングツール。SVG対応。完全無料。
* [pexels.com](https://www.pexels.com/) - 商用利用可能な無料ストック写真。キーワード検索APIも無料提供。
* [photopea.com](https://www.photopea.com) — Adobe Photoshop風UIの無料高機能オンラインデザインエディタ。PSD・XCF・Sketch（Photoshop, Gimp, Sketch App）対応。
* [pixlr.com](https://pixlr.com/) — 商用レベルの無料オンライン画像エディタ。
* [Plasmic](https://www.plasmic.app/) - コードベース統合型、レスポンシブページや複雑コンポーネントも作成できる高速・簡単・堅牢なWebデザイン＆ページビルダー。
* [Pravatar](https://pravatar.cc/) - Web/アプリで直接リンク可能なランダム/プレースホルダー用フェイクアバター生成。
* [Proto.io](https://proto.io) - コーディング不要の完全インタラクティブUIプロトタイプ作成。無料トライアル終了後も無料枠あり（1ユーザー、1プロジェクト、5プロトタイプ、100MBストレージ、プロト.appプレビュー）。
* [resizeappicon.com](https://resizeappicon.com/) — アプリアイコンのリサイズと管理ができるシンプルサービス。
* [Rive](https://rive.app) — あらゆるプラットフォーム向け美しいアニメーションを作成・配信。個人利用は永年無料。エディタ＆グラフィックホスティング提供。多プラットフォーム用ランタイムもあり。
* [storyset.com](https://storyset.com/) — プロジェクト向けに無料カスタマイズイラストを作成可能。
* [smartmockups.com](https://smartmockups.com/) — 製品モックアップ作成、200種無料モックアップ。
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — 様々なコンポーネントやレイアウトでテーマの変更をリアルタイムにプレビュー。
* [Tailark](https://tailark.com/) - モダン＆レスポンシブなマーケティングサイト向けプリビルドUIブロック集。
* [tabler-icons.io](https://tabler-icons.io/) — 1500以上のコピー＆ペースト可能なSVG編集対応アイコン。
* [tweakcn](https://tweakcn.com/) — shadcn/ui用の美しいテーマ集。カラー・タイポグラフィなどをリアルタイムカスタマイズ。
* [UI Avatars](https://ui-avatars.com/) - 名前からイニシャル入りアバター生成。URLで直接利用可。URLパラメータで設定も可能。
* [unDraw](https://undraw.co/) - 帰属不要で完全無料・常時更新の美麗SVG画像コレクション。
* [unsplash.com](https://unsplash.com/) - 商用・非商用利用可能な無料ストック写真（完全自由ライセンス）。
* [vectr.com](https://vectr.com/) — Web＋デスクトップ対応の無料デザインアプリ。
* [walkme.com](https://www.walkme.com/) — エンタープライズ向けガイダンス＆エンゲージメントプラットフォーム。無料プランは最大3本・5ステップ/本までのウォークスルー。
* [Webflow](https://webflow.com) - アニメーション＆Webホスティング付きWYSIWYGサイトビルダー。無料は2プロジェクトまで。
* [Updrafts.app](https://updrafts.app) - tailwindcssベースデザインのWYSIWYGサイトビルダー。非商用利用は無料。
* [whimsical.com](https://whimsical.com/) - 共同作業用フローチャート、ワイヤーフレーム、付箋、マインドマップ。4つまで無料ボード作成可。
* [Zeplin](https://zeplin.io/) — デザイナー＆開発者向けコラボプラットフォーム。デザイン・アセット・スタイルガイドを共有。1プロジェクトまで無料。
* [Pixelixe](https://pixelixe.com/) — 魅力的でユニークなグラフィックや画像をオンラインで作成・編集。
* [Responsively App](https://responsively.app) - レスポンシブWebアプリ開発をより速く・正確にする無料開発ツール。
* [SceneLab](https://scenelab.io) - 無料デザインテンプレートが増え続けるオンラインモックアップグラフィックエディタ。
* [xLayers](https://xlayers.dev) - SketchデザインファイルをAngular, React, Vue, LitElement, Stencil, Xamarin等にプレビュー・変換（完全無料＆オープンソース：[GitHub](https://github.com/xlayers/xlayers)）。
* [Grapedrop](https://grapedrop.com/) — GrapesJSフレームワークベースのレスポンシブ・高機能・SEO最適化Webページビルダー。最初の5ページまで無料、カスタムドメイン無制限、全機能利用可。
* [Mastershot](https://mastershot.app) - 完全無料のブラウザベース動画編集。ウォーターマークなし、最大1080pエクスポート。
* [Unicorn Platform](https://unicornplatform.com/) - ホスティング付きの簡単ランディングページビルダー。1サイトまで無料。
* [SVGmix.com](https://www.svgmix.com/) - 30万点以上の無料SVGアイコン・コレクション・ブランドロゴの大規模リポジトリ。ブラウザ上の簡易ベクター編集プログラム付き。
* [svgrepo.com](https://www.svgrepo.com/) - 多様なベクターライブラリから最適なアイコン・ベクターを探してプロジェクト利用。商用利用可の無料SVGベクターをダウンロード。
* [haikei.app](https://www.haikei.app/) - デザインツールやワークフローですぐ使えるユニークなSVG形状・背景・パターンを生成できるWebアプリ。
* [Canva](https://canva.com) - 無料オンラインデザインツールでビジュアルコンテンツ作成。
* [Superdesigner](https://superdesigner.co) - 数クリックで背景・パターン・形・画像などユニークなデザインを作成できる無料ツール集。
* [TeleportHQ](https://teleporthq.io/) - ローコードフロントエンドデザイン＆開発プラットフォーム。3プロジェクト・無制限コラボレーター・無料コードエクスポート。
* [vector.express](https://vector.express) — AI、CDR、DWG、DXF、EPS、HPGL、PDF、PLT、PS、SVGベクターを高速簡単変換。
* [Vertopal](https://www.vertopal.com) - 多様な形式への無料ファイル変換プラットフォーム。JPG→SVG、GIF→APNG、PNG→WEBP、JSON→XML等の開発者向け変換も対応。
* [okso.app](https://okso.app) - ミニマルなオンラインお絵描きアプリ。素早いスケッチやビジュアルメモ作成、PNG・JPG・SVG・WEBP出力可、PWAとしてインストール可。全員無料・登録不要。
* [Wdrfree SVG](https://wdrfree.com/free-svg) - 白黒の無料SVGカットファイル。
* [Lucide](https://lucide.dev) - カスタマイズ可能・一貫性ある無料SVGアイコンツールキット。
* [Logo.dev](https://www.logo.dev) - 4,400万以上のブランド対応の会社ロゴAPI。最初の10,000APIコール無料。
* [MDBootstrap](https://mdbootstrap.com/) - 無料で商用利用可能なBootstrap, Angular, React, Vue UIキット（700以上のコンポーネント、テンプレート、1分インストール、豊富なチュートリアル＆巨大コミュニティ）。
* [TW Elements](https://tw-elements.com/) - Tailwind CSSで再現した無料Bootstrapコンポーネント。デザイン性・機能性UP。
* [DaisyUI](https://daisyui.com/) -- 無料。「Tailwind CSSを使いながらクラス名を減らす」ボタンなどのコンポーネント提供。
* [Scrollbar.app](https://scrollbar.app) -- ウェブ用のカスタムスクロールバーをデザインするためのシンプルな無料ウェブアプリ。
* [css.glass](https://css.glass/) -- CSSを使用してグラスモーフィックデザインを作成するための無料ウェブアプリ。
* [hypercolor.dev](https://hypercolor.dev/) -- Tailwind CSSカラグラデーションの厳選コレクション。独自のジェネレーターで自分だけのグラデーションも作成可能。
* [iconify.design](https://icon-sets.iconify.design/) -- 100以上のアイコンパックを統一インターフェースで提供。パック横断検索やSVG、人気ウェブフレームワーク形式でのエクスポートが可能。
* [NextUI](https://nextui.org/) -- 無料。美しく、高速でモダンなReact & Next.js用UIライブラリ。
* [Glyphs](https://glyphs.fyi/) -- 無料、ウェブ上で最も強力なアイコン、完全編集可能で真にオープンソースのデザインシステム。
* [ShadcnUI](https://ui.shadcn.com/) -- コピー&ペーストで利用可能な美しくデザインされたコンポーネント。アクセシブル、カスタマイズ可能、オープンソース。
* [HyperUI](https://www.hyperui.dev/) -- 無料でオープンソースなTailwind CSSコンポーネント。
* [Calendar Icons Generator](https://calendariconsgenerator.app/) -- 1クリックで1年分のユニークなアイコンを無料で生成。
* [Image BG Blurer](https://imagebgblurer.com/) -- Notion、Trello、Jiraなどのツール向けに、画像ソースを背景ぼかしとして利用するフレームを生成。
* [Webstudio](https://webstudio.is/) -- Webflowのオープンソース代替。無料プランでは自社ドメインで5サイト、1万ページビュー/月、2GBアセットストレージ。
* [Nappy](https://nappy.co/) -- 黒人や褐色人種の美しい写真を無料提供。商用・個人利用可。
* [Tailkits](https://tailkits.com/) -- Tailwindのテンプレート・コンポーネント・ツールの厳選コレクション。コードジェネレーターやグリッド、ボックスシャドウなど便利なツールも。
* [Tailcolors](https://tailcolors.com/) -- 美しいTailwind CSS v4カラーパレット。即時プレビュー＆最適なクラスをコピー可能。
* [Excalidraw](https://excalidraw.com/) -- 無料のオンライン描画ドキュメントウェブページ。ローカル保存やエクスポート対応。
* [Lunacy](https://icons8.com/lunacy) -- オフライン対応の無料グラフィックデザインツール。内蔵アセット（アイコン・写真・イラスト）やリアルタイム共同編集対応。無料枠は10クラウドドキュメント、30日履歴、低解像度アセット、基本ツール付属。

**[⬆️ 上へ戻る](#table-of-contents)**

## デザインインスピレーション

* [awwwards.](https://www.awwwards.com/) - 【トップウェブサイト】デザイナーによる投票で選ばれた最高のウェブサイト集。
* [Behance](https://www.behance.net/) - 【デザインショーケース】デザイナーが作品を公開する場。UI/UXプロジェクトカテゴリで絞り込み可能。
* [dribbble](https://dribbble.com/) - 【デザインショーケース】独自のデザインインスピレーション。実アプリ由来でないものが多い。
* [Landings](https://landings.dev/) - 【ウェブスクリーンショット】好みに合わせてデザインインスピレーションとなる最高のランディングページを探せる。
* [Lapa Ninja](https://www.lapa.ninja/) - 【ランディングページ/UIキット/ウェブスクリーンショット】6025点の優れたランディングページ例や、デザイナー向け無料書籍・UIキット集。
* [LovelyLanding.net](https://www.lovelylanding.net/) - 【ランディングページデザイン】頻繁に更新されるランディングページのスクリーンショット。デスクトップ・タブレット・モバイル表示含む。
* [Mobbin](https://mobbin.design/) - 【モバイルスクリーンショット】5万枚以上の完全検索可能なモバイルアプリUI/UXスクリーンショット集で、調査時間を大幅短縮。
* [Uiland Design](https://uiland.design/) - 【モバイルスクリーンショット】アフリカおよび世界の主要企業のモバイル/Web UIデザインを探求。
* [Mobile Patterns](https://www.mobile-patterns.com/) - 【モバイルスクリーンショット】デザイナー・開発者・プロダクト制作者向け、最高のUI/UXパターン（iOS/Android）インスピレーションライブラリ。
* [Page Flows](https://pageflows.com/) - 【モバイル/ウェブ動画・スクリーンショット】多数のモバイル・ウェブアプリのフルフロー動画とスクリーンショット。検索性・インデックス性が高い。
* [Screenlane](https://screenlane.com/) - 【モバイルスクリーンショット】最新のWeb & モバイルUIデザイントレンドのインスピレーション。パターンやアプリで絞り込み可。
* [scrnshts](https://scrnshts.club/) - 【モバイルスクリーンショット】厳選されたアプリストアデザインスクリーンショット集。
* [Refero](https://refero.design/) - 【ウェブスクリーンショット】優れたウェブアプリからタグ付け・検索可能なデザインリファレンス集。

**[⬆️ 上へ戻る](#table-of-contents)**

## 地図上でのデータ可視化

* [IP Geolocation](https://ipgeolocation.io/) — 30,000リクエスト/月の無料DEVELOPERプラン。
* [carto.com](https://carto.com/) — 自分や公開データから地図や地理空間APIを作成。
* [Clockwork Micro](https://clockworkmicro.com/) — 時計のように動作する地図ツール。月50,000クエリ（マップタイル、db2vector、標高）が無料。
* [developers.arcgis.com](https://developers.arcgis.com) — マップ、地理空間データストレージ、分析、ジオコーディング、ルーティング等のAPIとSDK。月間200万ベースマップタイル、20,000ノンストアジオコード、20,000単純ルート、5,000ドライブタイム計算、5GB無料タイル＋データストレージ。
* [Foursquare](https://developer.foursquare.com/) - 場所APIおよびPilgrim SDKによるロケーション発見、施設検索、コンテキスト認識コンテンツ。
* [geoapify.com](https://www.geoapify.com/) - ベクター＆ラスタータイル、ジオコーディング、プレイス、ルーティング、アイソラインAPI。1日3,000リクエスト無料。
* [geocod.io](https://www.geocod.io/) — APIまたはCSVアップロードによるジオコーディング。1日2,500クエリ無料。
* [geocodify.com](https://geocodify.com/) — APIまたはCSVアップロードによるジオコーディング＆ジオパース。月10,000クエリ無料。
* [geojs.io](https://www.geojs.io/) - 高可用性REST/JSON/JSONP IPジオロケーション検索API。
* [giscloud.com](https://www.giscloud.com/) — ジオデータをオンラインで可視化、分析、共有。
* [graphhopper.com](https://www.graphhopper.com/) ルーティング・ルート最適化・距離行列・ジオコーディング・マップマッチング用の無料開発者パッケージあり。
* [here](https://developer.here.com/) — マップやロケーション対応アプリのためのAPI・SDK。月25万トランザクション無料。
* [locationiq.com](https://locationiq.com/) — ジオコーディング、マップ、ルーティングAPI。1日5,000リクエスト無料。
* [mapbox.com](https://www.mapbox.com/) — マップ、地理空間サービス、マップデータ表示用SDK。
* [maptiler.com](https://www.maptiler.com/cloud/) — ベクターマップ、マップサービス、マップ可視化SDK。週次更新の無料ベクタタイルと4種のマップスタイル。
* [nominatim.org](https://nominatim.org/) — OpenStreetMapの無料ジオコーディングサービス。グローバル住所検索と逆ジオコーディング機能を提供。
* [nextbillion.ai](https://nextbillion.ai/) - ジオコーディング、ナビゲーション（経路案内、ルーティング、ルート最適化、距離行列）、地図SDK（ベクター、静的、モバイルSDK）など地図関連サービス。各サービスごとに[指定クォータの無料枠](https://nextbillion.ai/pricing)。
* [opencagedata.com](https://opencagedata.com) — OpenStreetMap等のオープンジオソース集約ジオコーディングAPI。1日2,500クエリ無料。
* [osmnames](https://osmnames.org/) — ジオコーディング。検索結果は関連Wikipediaページの人気度でランク付け。
* [positionstack](https://positionstack.com/) - 世界中の地名・座標向け無料ジオコーディング。個人利用で月25,000リクエスト。
* [stadiamaps.com](https://stadiamaps.com/) — マップタイル、ルーティング、ナビゲーション等のジオ空間API。非商用・テスト用途で1日2,500マップビュー＆APIリクエスト無料。
* [maps.stamen.com](http://maps.stamen.com/) - 無料マップタイル＆タイルホスティング。
* [ipstack](https://ipstack.com/) - IPアドレスからウェブサイト訪問者を特定・位置情報取得。
* [Geokeo api](https://geokeo.com) - 言語補正対応ジオコーディングAPI等。世界中をカバー。1日2,500クエリ無料。

**[⬆️ 上へ戻る](#table-of-contents)**

## パッケージビルドシステム

* [build.opensuse.org](https://build.opensuse.org/) — 複数ディストロ（SUSE、EL、Fedora、Debian等）向けパッケージビルドサービス。
* [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — FedoraとEL用のMockベースRPMビルドサービス。
* [help.launchpad.net](https://help.launchpad.net/Packaging) — UbuntuおよびDebian向けビルドサービス。

**[⬆️ 上へ戻る](#table-of-contents)**

## IDEおよびコードエディタ

* [3v4l](https://3v4l.org/) - 300以上のPHPバージョンでコードを実行できる無料オンラインPHPシェル＆スニペット共有サイト
* [Android Studio](https://developer.android.com/studio) — Android向けアプリ開発のための高速ツールを提供。オープンソースIDEは誰でも無料で利用可能。Windows、Mac、Linux、ChromeOS対応。
* [AndroidIDE](https://m.androidide.com/) — Androidデバイス上で本格的なGradleベースAndroidアプリを開発できるオープンソースIDE。
* [Apache Netbeans](https://netbeans.apache.org/) — 開発環境、ツーリングプラットフォーム、アプリケーションフレームワーク。
* [apiary.io](https://apiary.io/) — 協業API設計、APIモック・ドキュメント自動生成（APIブループリント無制限・ユーザー無制限・管理者1人＆ホストドキュメント付きで無料）。
* [BBEdit](https://www.barebones.com/) - macOS向け人気の拡張可能エディタ。無料モードで[強力なコア機能](https://www.barebones.com/products/bbedit/comparison.html)を利用でき、上位機能へのアップグレードも可能。
* [Binder](https://mybinder.org/) - Gitリポジトリをインタラクティブなノートブック集に変換。無料の公共サービス。
* [BlueJ](https://bluej.org) — 初心者向けに設計された無料Java開発環境。全世界で数百万人が利用。Oracle提供＆シンプルGUI。
* [Bootify.io](https://bootify.io/) - カスタムDBやREST API付きSpring Bootアプリ生成。
* [Brackets](http://brackets.io/) - ウェブ開発向けに設計されたオープンソーステキストエディタ。軽量・使いやすく・高いカスタマイズ性。
* [cacher.io](https://www.cacher.io) — ラベル付け・100以上のプログラミング言語対応のコードスニペット管理ツール。
* [Code::Blocks](https://codeblocks.org) — 無料Fortran & C/C++ IDE。オープンソースでWindows、macOS、Linux対応。
* [Cody](https://sourcegraph.com/cody) - コード作成（ブロック、補完、単体テスト）、理解（全コードベース知識）、修正、検索可能な無料AIコーディングアシスタント。VS Code、JetBrains、オンラインで利用可。
* [codiga.io](https://codiga.io/) — IDEから直接コードスニペットを検索・定義・再利用できるコーディングアシスタント。個人・小規模組織は無料。
* [codesnip.com.br](https://codesnip.com.br) — カテゴリ・検索・タグ付きのシンプルなコードスニペット管理。無料・無制限。
* [cocalc.com](https://cocalc.com/) — （旧SageMathCloud）— クラウド上で協業計算。Ubuntu環境をブラウザで利用可能。Python、LaTeX、Jupyter、SageMath、scikitlearnなど数学・科学・データサイエンス用ソフト多数プリインストール。
* [code.cs50.io](https://code.cs50.io/) - GitHub Codespacesを学生・教師向けに適応したWebアプリVisual Studio Code for CS50。
* [codepen.io](https://codepen.io/) — フロントエンド開発用のプレイグラウンド。
* [codesandbox.io](https://codesandbox.io/) — React、Vue、Angular、Preactなどのオンラインプレイグラウンド。
* [Components.studio](https://webcomponents.dev/) - コンポーネントを単体でコーディング、ストーリーで可視化、テストしnpm公開も可能。
* [Eclipse Che](https://www.eclipse.org/che/) - 開発チーム向けWebベース＆KubernetesネイティブIDE。多言語対応オープンソース。Red Hat提供の[workspaces.openshift.com](https://workspaces.openshift.com/)でオンライン利用可。
* [fakejson.com](https://fakejson.com/) — APIで素早くフェイクデータ生成。リクエスト内容に応じてJSONで返答。アイデア検証や市場投入を加速。
* [GetVM](https://getvm.io) — 無料でLinuxとIDEを即座にChromeサイドバーで実行。無料枠で1日5台まで。
* [GitPod](https://www.gitpod.io) — GitHubプロジェクト向けのインスタントでコーディング可能な開発環境。無料プランは月50時間利用可能。
* [ide.goorm.io](https://ide.goorm.io) goormIDEはクラウド上のフル機能IDEです。マルチ言語対応、Linuxベースのコンテナ、フル機能のWebターミナル、ポートフォワーディング、カスタムURL、リアルタイム共同作業とチャット、共有リンク、Git/Subversion対応など、多数の機能を備えています（無料プランは1コンテナあたり1GB RAMと10GBストレージ、5コンテナスロット）。
* [JDoodle](https://www.jdoodle.com) — 60以上のプログラミング言語に対応したオンラインコンパイラ＆エディタ。REST APIによるコードコンパイルは無料プランで1日200クレジットまで。
* [jetbrains.com](https://jetbrains.com/products.html) — 生産性ツール、IDEおよびデプロイツール（[IntelliJ IDEA](https://www.jetbrains.com/idea/)、[PyCharm](https://www.jetbrains.com/pycharm/)等）。学生、教員、オープンソース及びユーザーグループ向けに無料ライセンスを提供。
* [jsbin.com](https://jsbin.com) — JS BinはフロントエンドWeb（HTML, CSS, JavaScript）のプレイグラウンド兼コード共有サイト。Markdown、Jade、Sassもサポート。
* [jsfiddle.net](https://jsfiddle.net/) — JS FiddleはフロントエンドWeb向けのプレイグラウンド＆コード共有サイトで、協働作業もサポート。
* [JSONPlaceholder](https://jsonplaceholder.typicode.com/) — JSON形式でダミーデータを返すREST APIエンドポイント。ローカルでサーバを実行したい場合はソースコードも利用可能。
* [Lazarus](https://www.lazarus-ide.org/) — LazarusはDelphi互換のクロスプラットフォームIDEで、迅速なアプリケーション開発が可能。
* [MarsCode](https://www.marscode.com/) - 無料のAI搭載クラウドベースIDE。
* [micro-jaymock](https://micro-jaymock.now.sh/) - ダミーJSONデータ生成用の小型APIモッキングマイクロサービス。
* [mockable.io](https://www.mockable.io/) — RESTful APIやSOAP Webサービスのモック作成ができるシンプルな構成サービス。REST APIやSOAPエンドポイントを素早く定義し、JSONまたはXMLデータを返せます。
* [mockaroo](https://mockaroo.com/) — CSV、JSON、SQL、Excel形式でリアルなテストデータを生成可能。バックエンドAPIのモックも作成可能。
* [Mocklets](https://mocklets.com) - 高速な並列開発や包括的なテストのためのHTTPベースのモックAPIシミュレータ。永久無料プランあり。
* [Paiza](https://paiza.cloud/en/) — ブラウザでWebアプリを開発。セットアップ不要。無料プランは、1台のサーバを24時間有効（1日4時間稼働）、2CPUコア・2GB RAM・1GBストレージ付きで利用可能。
* [Prepros](https://prepros.io/) - Sass、Less、Stylus、Pug/Jade、Haml、Slim、CoffeeScript、TypeScriptのコンパイル、ブラウザ自動リロード、簡単なWebサイト開発・テストをサポート。独自ツールの追加も数クリックで可能。
* [Replit](https://replit.com/) — 様々なプログラミング言語に対応したクラウドコーディング環境。
* [SoloLearn](https://code.sololearn.com) — コードスニペット実行に適したクラウドプログラミングプレイグラウンド。多言語対応。コード実行は登録不要、保存は要登録。初心者・中級者向け無料コースも提供。
* [stackblitz.com](https://stackblitz.com/) — オンライン/クラウド型のコードIDE。フルスタックアプリの作成、編集、デプロイが可能。NodeJs系の主要フロントエンド＆バックエンドフレームワーク対応。新規プロジェクト作成ショートリンク：[https://node.new](https://node.new)。
* [Sublime Text](https://www.sublimetext.com/) - コーディングやテキスト編集に使われる人気・高機能・カスタマイズ性の高いテキストエディタ。
* [Visual Studio Code](https://code.visualstudio.com/) - モダンWebやクラウドアプリ開発に最適化されたコードエディタ。Microsoft製。
* [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — 拡張機能多数のフル機能IDE。クロスプラットフォームアプリ開発（iOS/Android用Microsoft拡張のダウンロード対応）、デスクトップ、Web、クラウド開発、多言語対応（C#, C++, JavaScript, Python, PHP等）。
* [VSCodium](https://vscodium.com/) - テレメトリ/トラッキングなし、コミュニティ主導のVSCode無償バイナリ配布。
* [wakatime.com](https://wakatime.com/) — テキストエディタプラグインを使ったコーディング活動の自己分析。無料プランあり。
* [Wave Terminal](https://waveterm.dev/) - オープンソースかつクロスプラットフォームのターミナル。インラインレンダリング、セッション＆履歴保存。Web標準準拠。MacOS/Linux対応。
* [WebComponents.dev](https://webcomponents.dev/) — 58種類のテンプレート、ストーリーやテスト対応、Webコンポーネントを単独でコーディングできるブラウザIDE。
* [PHPSandbox](https://phpsandbox.io/) — PHPのオンライン開発環境
* [WebDB](https://webdb.app) - 無料の高効率データベースIDE。サーバ検出、ERD、データ生成、AI、NoSQL構造管理、DBバージョン管理など多数機能を搭載。
* [Zed](https://zed.dev/) - AtomとTree-sitterの開発者による高性能マルチプレイヤーコードエディタ。
* [OneCompiler](https://onecompiler.com/) - Java、Python、C++、JavaScriptなど70以上の言語対応の無料オンラインコンパイラ。

**[⬆️ Back to Top](#table-of-contents)**

## 分析・イベント・統計

* [Dwh.dev](https://dwh.dev) - データクラウド可観測性ソリューション（Snowflake）。個人利用は無料。
* [Hightouch](https://hightouch.com/) - データウェアハウスからCRMやマーケティング、サポートツールへ顧客データを同期するReverse ETLプラットフォーム。無料プランは1つの送信先にデータ同期可能。
* [Avo](https://avo.app/) — シンプル化されたアナリティクスリリースワークフロー。単一ソースのトラッキングプラン、型安全な分析トラッキングライブラリ、アプリ内デバッガ、データ可観測性。無料は2名ワークスペース・1時間のデータ可観測性ルックバックまで。
* [Branch](https://www.branch.io) — モバイル分析プラットフォーム。無料プランは最大10,000モバイルアプリユーザー、ディープリンク他サービス対応。
* [Census](https://www.getcensus.com/) — Reverse ETL & オペレーショナルアナリティクスプラットフォーム。データウェアハウスからSalesforce、Zendesk、Amplitudeなど60以上のSaaSへ10フィールド同期可能。
* [Clicky](https://clicky.com) — ウェブサイト分析プラットフォーム。無料プランは1サイト・3,000ビュー分析まで。
* [Databox](https://databox.com) — 複数の分析・BIプラットフォームを統合したビジネスインサイト＆アナリティクス。無料プランは3ユーザー、ダッシュボード＆データソース、1,100万件の履歴データまで。
* [Hitsteps.com](https://hitsteps.com/) — 1サイトあたり月2,000ページビューまで
* [amplitude.com](https://amplitude.com/) — 月1,000,000イベント、最大2アプリまで
* [GoatCounter](https://www.goatcounter.com/) — オープンソースWebアナリティクス。ホスティングサービス（非商用は無料）またはセルフホスト可。Google AnalyticsやMatomoの代替となる使いやすくプライバシーに配慮した分析。無料枠は非商用・無制限サイト・6ヶ月データ保存・月10万PVまで。
* [Google Analytics](https://analytics.google.com/) — Google Analytics
* [MetricsWave](https://metricswave.com) — 開発者向けプライバシー重視のGoogle Analytics代替。無料プランはクレカ不要で月2万PVまで。
* [Expensify](https://www.expensify.com/) — 経費報告、個人向け承認ワークフロー無料
* [getinsights.io](https://getinsights.io) - プライバシー重視・Cookie不要の分析。月3,000イベントまで無料。
* [heap.io](https://heap.io) — iOSまたはWebアプリの全ユーザーアクションを自動キャプチャ。月1万セッションまで無料。
* [Hotjar](https://hotjar.com) — ウェブサイト分析とレポート。無料プランは日2,000PV、日100スナップショット（最大300）、3件のヒートマップ（365日保存）、無制限チームメンバー。アプリ内/独立のアンケート・フィードバックウィジェットも3件ずつ作成可能、月20件の回答収集。
* [Keen](https://keen.io/) — データ収集、分析、可視化のためのカスタム分析。月1,000イベント無料
* [Yandex.Datalens](https://datalens.yandex.com/) — Yandex Cloudのデータ可視化・分析サービス。完全無料。ユーザー数・リクエスト数無制限。
* [Yandex.Metrica](https://metrica.yandex.com/) — 無制限無料アナリティクス
* [Mixpanel](https://mixpanel.com/) — 月間10万トラッキングユーザー、無制限データ履歴・シート、米/EUデータレジデンシー
* [Moesif](https://www.moesif.com) — RESTおよびGraphQL向けAPI分析。（月50万APIコールまで無料）
* [optimizely.com](https://www.optimizely.com) — A/Bテストソリューション。無料スタータープランは1サイト、1 iOS、1 Androidアプリまで
* [Microsoft PowerBI](https://powerbi.com) — Microsoftのビジネスインサイト＆アナリティクス。無料プランは1百万ユーザーライセンスで限定利用可。
* [Row Zero](https://rowzero.io) - 超高速・接続型スプレッドシート。DB、S3、APIに直結。数百万行を即時インポート・分析・グラフ化・共有。3つのワークブックが永久無料。
* [sematext.com](https://sematext.com/cloud/) — 月50,000アクション、1日データ保存、無制限ダッシュボード・ユーザー等無料。
* [Similar Web](https://similarweb.com) — Web＆モバイルアプリ向け分析。無料プランは各指標ごとに5件、モバイルアプリ1か月分、ウェブサイト3か月分のデータ。
* [StatCounter](https://statcounter.com/) — ウェブサイト閲覧者分析。最新500訪問分の分析が無料。
* [Statsig](https://statsig.com) - 分析・フィーチャーフラグ・A/Bテストのオールインワンプラットフォーム。月100万イベントまで無料。
* [Tableau Developer Program](https://www.tableau.com/developer) — イノベーションやカスタム開発のための開発者向け。無料の開発者プログラムでTableau Onlineの個人用サンドボックスライセンスが付与。バージョンは最新のプレリリース版。
* [usabilityhub.com](https://usabilityhub.com/) — 実ユーザーによるデザイン・モックテスト＆訪問者追跡。1ユーザー・無制限テストが無料
* [woopra.com](https://www.woopra.com/) — 無料ユーザー分析プラットフォーム。50万アクション、90日データ保存、30以上のワンクリック統合。
* [counter.dev](https://counter.dev) — シンプルでプライバシー重視のWebアナリティクス。無料または任意寄付。
* [PostHog](https://posthog.com) - 月100万イベントまで無料のプロダクト分析スイート。アプリ内アンケートも無制限・月250回答対応。
* [Uptrace](https://uptrace.dev) - 分散トレーシングツール。無料プランあり。OSSプロジェクトにはPersonalサブスクリプション無償提供。OSS版もあり。
* [Microsoft Clarity](https://clarity.microsoft.com/) - 実ユーザーのサイト利用状況を記録する無料ツール。
* [Beampipe.io](https://beampipe.io) - シンプル＆プライバシー重視のWebアナリティクス。最大5ドメイン・月1万PVまで無料。
* [Aptabase](https://aptabase.com) — オープンソース・プライバシー重視・シンプルなモバイル＆デスクトップアプリ分析。Swift, Kotlin, React Native, Flutter, Electron等のSDKあり。月2万イベントまで無料。
* [Trackingplan](https://www.trackingplan.com/) - デジタル分析やマーケデータ・ピクセルの問題を自動検知し、トラッキングプランを最新維持、円滑なコラボを促進。プロダクション環境や回帰テストでノーコード導入可。
* [LogSpot](https://logspot.io) - 埋め込み分析ウィジェットや自動ロボット（slack、telegram、webhook）を含む統合型Web/プロダクト分析プラットフォーム。無料プランは月1万イベント。
* [Umami](https://umami.is/) - シンプル・高速・プライバシー重視のオープンソースGoogle Analytics代替。
* [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - 無料の軽量プライバシー重視Google Analytics代替。無制限PV・訪問者・ヒートマップ・ゴール追跡。3ドメイン・各600セッションリプレイまで無料。
* [AppFit](https://appfit.io) - 分析とプロダクト管理ツール。クロスプラットフォーム対応。無料プランは月1万イベント、プロダクトジャーナル、週次インサイト付き。
* [Seline](https://seline.so) - シンプル＆プライベートなウェブ/プロダクト分析。Cookieレス・軽量・独立。無料プランは月3,000イベント・全機能利用可（ダッシュボード、ユーザージャーニー、ファネル等）。
* [Peasy](https://peasy.so) - 軽量・プライバシー重視のウェブ/プロダクト分析ツール。無料プランは月3,000イベント。
* [Rybbit](https://rybbit.io) - オープンソース＆CookieレスのGoogle Analytics代替。直感的で無料プランは月3,000イベント。

**[⬆️ Back to Top](#table-of-contents)**

## 訪問セッションレコーディング

* [Reactflow.com](https://www.reactflow.com/) — 1サイトあたり日1,000PV、3ヒートマップ、3ウィジェット、無料バグトラッキング
* [OpenReplay.com](https://www.openreplay.com) - 開発者向けデバッグツール付きオープンソースセッションリプレイ。リアルタイムサポート用ライブセッション、プロダクト分析スイート。月1,000セッション、全機能・7日保存。
* [LogRocket.com](https://www.logrocket.com) - 月1,000セッション・30日保存、エラートラッキング、ライブモード
* [FullStory.com](https://www.fullstory.com) — 月1,000セッション・1ヶ月保存・3ユーザーシート。詳細は[こちら](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition)。
* [hotjar.com](https://www.hotjar.com/) — 1サイトあたり月1,050PV、ヒートマップ無制限、データ3ヶ月保存
* [inspectlet.com](https://www.inspectlet.com/) — 1サイトあたり月2,500セッション無料
* [Microsoft Clarity](https://clarity.microsoft.com/) - セッション録画が完全無料。「トラフィック制限なし」、プロジェクト制限なし、サンプリングなし
* [mouseflow.com](https://mouseflow.com/) — 1サイトあたり月500セッション無料
* [mousestats.com](https://www.mousestats.com/) — 1サイトあたり月100セッション無料
* [smartlook.com](https://www.smartlook.com/) — Web/モバイルアプリ用無料パッケージ（月1,500セッション）、3ヒートマップ、1ファネル、1ヶ月履歴
* [howuku.com](https://howuku.com) — ユーザーインタラクション、エンゲージメント、イベント追跡。月5,000訪問まで無料
* [UXtweak.com](https://www.uxtweak.com/) — Webサイト/アプリの訪問者利用状況の録画と視聴。小規模プロジェクトは無制限無料

**[⬆️ Back to Top](#table-of-contents)**
## 国際モバイル番号認証APIおよびSDK

  * [numverify](https://numverify.com/) — グローバルな電話番号のバリデーションおよびルックアップ用のJSON API。月100回のAPIリクエストまで無料
  * [veriphone](https://veriphone.io/) — グローバルな電話番号認証を行う無料・高速・信頼性の高いJSON API。月1000回までリクエスト無料

**[⬆️ トップに戻る](#table-of-contents)**

## 決済・請求統合

  * [Qonversion](http://qonversion.io/) - 分析、A/Bテスト、Apple Search Ads、リモート設定、成長ツールを提供するオールインワンのクロスプラットフォームサブスクリプション管理プラットフォーム。iOS、Android、React Native、Flutter、Unity、Cordova、Stripe、Webに対応。月間トラッキング収益$10,000まで無料。
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – 訪問者の所在地に基づき価格を自動調整することで、ビジネスをグローバルに展開し新たな市場（購買力平価）にリーチ。無料プランは月7,500回のAPIリクエストを含む。
  * [Glassfy](https://glassfy.io/) – iOS、Android、Stripe、Paddle上でのアプリ内サブスクリプション基盤、リアルタイム購読イベント、即時導入可能なマネタイズツール。月間収益$10,000まで無料。
  * [Adapty.io](https://adapty.io/) – iOS、Android、React Native、Flutter、Unity、Webアプリ向けにオープンソースSDK付きのモバイルアプリ内サブスクリプション統合のワンストップソリューション。月間収益$10,000まで無料。
  * [CoinMarketCap](https://coinmarketcap.com/api/) — 暗号通貨市場データと最新の仮想通貨・法定通貨為替レートを提供。無料ティアで月10,000コールクレジット。
  * [CurrencyFreaks](https://currencyfreaks.com/) — 現在および過去の為替レートを提供。開発者向け無料プランで月1,000リクエスト。
  * [CoinGecko](https://www.coingecko.com/en/api) — 暗号通貨市場データ、最新の仮想通貨為替レート・過去データを提供。デモAPIは30回/分の安定したレートリミットと月10,000回の上限。
  * [CurrencyApi](https://currencyapi.net/) — 物理通貨・暗号通貨のライブ為替レート（JSONとXML対応）。無料ティアは月1,250APIリクエスト。
  * [currencylayer](https://currencylayer.com/) — ビジネス向け信頼性の高い為替レート・通貨換算API。月100回まで無料。
  * [exchangerate-api.com](https://www.exchangerate-api.com) - 使いやすい為替換算JSON API。無料ティアは1日1回更新・月1,500リクエストまで。
  * [FraudLabsPRO](https://www.fraudlabspro.com) — 決済詐欺やチャージバックの防止を支援。マイクロプランは月500クエリまで無料。
  * [FxRatesAPI](https://fxratesapi.com) — リアルタイム・過去の為替レートを提供。無料ティアは帰属表示が必要。
  * [Moesif API Monetization](https://www.moesif.com/) - 使用量ベースの課金でAPIから収益化。Stripe、Chargebee等と連携。無料ティアは月30,000イベント。
  * [Nami ML](https://www.namiml.com/) - iOS/Android向けアプリ内課金・サブスクリプションの完全プラットフォーム。ノーコード課金画面、CRM、分析を含む。IAP事業運営の基本機能は全て無料。
  * [RevenueCat](https://www.revenuecat.com/) — アプリ内課金・サブスクリプション用ホスト型バックエンド（iOS/Android対応）。月間追跡収益$2,500まで無料。
  * [vatlayer](https://vatlayer.com/) — 即時VAT番号検証・EU VATレートAPI。月100回まで無料。
  * [Currencyapi](https://currencyapi.com) — 無料の為替換算・為替レートデータAPI。月300リクエスト、1分あたり10リクエスト（個人利用）。

**[⬆️ トップに戻る](#table-of-contents)**

## Docker関連

  * [canister.io](https://canister.io/) — 開発者向けに20個、チーム向けに30個の無料プライベートリポジトリでDockerイメージの構築・保存が可能
  * [Container Registry Service](https://container-registry.com/) - Harborベースのコンテナ管理ソリューション。無料ティアはプライベートリポジトリ用に1GBのストレージ。
  * [Docker Hub](https://hub.docker.com) — 無料のプライベートリポジトリ1つと無制限のパブリックリポジトリでDockerイメージの構築・保存が可能
  * [Play with Docker](https://labs.play-with-docker.com/) — Dockerを学べるシンプルでインタラクティブな楽しいプレイグラウンド。
  * [quay.io](https://quay.io/) — 無制限の無料パブリックリポジトリでコンテナイメージを構築・保存
  * [ttl.sh](https://ttl.sh/) - 匿名かつ一時的なDockerイメージレジストリ

**[⬆️ トップに戻る](#table-of-contents)**

## Vagrant関連

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud。Vagrant boxホスティング。
  * [Vagrantbox.es](https://www.vagrantbox.es/) — 代替のパブリックBoxインデックス

**[⬆️ トップに戻る](#table-of-contents)**

## Devブログサイト

  * [BearBlog](https://bearblog.dev/) - ミニマリストかつMarkdown対応のブログ・Webサイトビルダー。
  * [Dev.to](https://dev.to/) - プログラマーがアイデアを共有し、互いに成長を助け合う場。
  * [Hashnode](https://hashnode.com/) — 開発者のための手間いらずのブログソフトウェア!
  * [Medium](https://medium.com/) — あなたにとって大切なことについてより深く考えるための場所。
  * [AyeDot](https://ayedot.com/) — アイデア・知識・ストーリーを現代的なマルチメディア短編ミニブログとして無料で世界に発信。

**[⬆️ トップに戻る](#table-of-contents)**

## コメントプラットフォーム
  * [GraphComment](https://graphcomment.com/) - Webサイトのオーディエンスからアクティブなコミュニティを構築するコメントプラットフォーム。
  * [Utterances](https://utteranc.es/) - GitHub Issues上で動作する軽量コメントウィジェット。ブログコメントやWikiページ等にGitHub Issuesを活用！
  * [Disqus](https://disqus.com/) - 世界中の数十万サイトで利用されているネットワーク型コミュニティプラットフォーム。
  * [Remarkbox](https://www.remarkbox.com/) - オープンソースのホスト型コメントプラットフォーム。動作や外観を完全制御でき、複数ドメイン・1人のモデレーターで「支払いは任意」。
  * [IntenseDebate](https://intensedebate.com/) - WordPress、Tumblr、Blogger、他多くのウェブサイトプラットフォーム向けの高機能コメントシステム。

**[⬆️ トップに戻る](#table-of-contents)**

## スクリーンショットAPI

  * [ApiFlash](https://apiflash.com) — AWS LambdaとChromeベースのスクリーンショットAPI。全ページ・タイミング・ビューポートサイズのキャプチャ対応。
  * [microlink.io](https://microlink.io/) – 任意のWebサイトをデータ化（メタタグ正規化、美しいリンクプレビュー、スクレイピング、スクリーンショットサービス等）。1日250リクエストまで無料。
  * [ScreenshotAPI.net](https://screenshotapi.net/) - シンプルなAPIコールで任意のWebサイトのスクリーンショットを生成。Google Cloud上でスケール対応・ホスティング。月100回無料。
  * [screenshotlayer.com](https://screenshotlayer.com/) — 任意のWebサイトのカスタマイズ可能なスナップショット取得。月100枚無料
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — 月100枚までPNG/GIF/JPG形式でスナップショット取得。全ページキャプチャ対応、ホームページ限定ではない
  * [PhantomJsCloud](https://PhantomJsCloud.com) — ブラウザ自動化・ページレンダリング。無料ティアで1日最大500ページ。2017年から無料提供中。
  * [Webshrinker.com](https://webshrinker.com) — Web ShrinkerはWebサイトスクリーンショットとドメインインテリジェンスAPIサービスを提供。月100回まで無料。
  * [Screenshots](https://screenshotson.click) — スクリーンショットAPI。高度にカスタマイズ可能なキャプチャオプション。月100枚まで無料。

**[⬆️ トップに戻る](#table-of-contents)**

## Flutter関連 & Mac不要でのiOSアプリ構築

  * [FlutLab](https://flutlab.io/) - FlutLabはモダンなFlutterオンラインIDE。クロスプラットフォームプロジェクトの作成・デバッグ・ビルドに最適。Mac不要でiOS/AndroidアプリをFlutterでビルド可能。
  * [CodeMagic](https://codemagic.io/) - Codemagicはモバイルアプリ向けの完全ホスト型CI/CD。GUIベースのCI/CDツールでビルド・テスト・デプロイ可能。無料ティアは月500分・2.3GHz/8GB RAMのMac Miniインスタンス付き。
  * [FlutterFlow](https://flutterflow.io/) - FlutterFlowはブラウザベースのドラッグ＆ドロップインターフェイスでFlutterによるモバイルアプリ構築が可能。

**[⬆️ トップに戻る](#table-of-contents)**

## Javascriptで書かれたブラウザベースのハードウェアエミュレーション

  * [JsLinux](https://bellard.org/jslinux) — 非常に高速なx86仮想マシン。LinuxやWindows 2kの実行が可能。
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — OpenRISC仮想マシン。ネットワーク対応のLinux実行が可能。
  * [v86](https://copy.sh/v86) — x86仮想マシン。Linuxや他のOSをブラウザ上で直接実行可能。

**[⬆️ トップに戻る](#table-of-contents)**

## プライバシー管理
  * [Bearer](https://www.bearer.sh/) - 監査や継続的ワークフローでプライバシー・バイ・デザインを実現し、GDPR等への準拠を支援。無料ティアは小規模チームとSaaS版のみ利用可能。
  * [Osano](https://www.osano.com/) - 同意管理とコンプライアンスプラットフォーム。GDPR代理やクッキーバナーなどを網羅。無料ティアは基本機能を提供。
  * [Iubenda](https://www.iubenda.com/) - プライバシー・クッキーポリシー及び同意管理。無料ティアはプライバシーポリシー・クッキーポリシー・バナーが制限付きで利用可能。
  * [Cookiefirst](https://cookiefirst.com/) - クッキーバナー・監査・多言語同意管理ソリューション。無料ティアは1回限りのスキャンと1つのバナーを提供。
* [Ketch](https://www.ketch.com/) - 同意管理およびプライバシーフレームワークツール。フリーティアでは、ほとんどの機能が利用でき、訪問者数に制限があります。
* [Concord](https://www.concord.tech/) - 同意管理、プライバシーリクエスト対応（DSAR）、データマッピングを含む完全なデータプライバシープラットフォーム。フリーティアには主要な同意管理機能が含まれており、検証済みのオープンソースプロジェクトにはより高度なプランも無料で提供されています。

**[⬆️ Topに戻る](#table-of-contents)**

## その他

* [BackgroundStyler.com](https://backgroundstyler.com) - コード、テキスト、画像の美しいスクリーンショットを作成し、SNSで共有できます。
* [BinShare.net](https://binshare.net) - コードやバイナリを作成・共有。Twitter/Facebook投稿用の画像や、チャット/フォーラム用のリンクとして共有可能。
* [Blynk](https://blynk.io) — API付きSaaSでIoTデバイスの制御・構築・評価が可能。無料開発者プランは5台のデバイス、無料クラウド＆データストレージ付き。モバイルアプリも利用可能。
* [Bricks Note Calculator](https://free.getbricks.app/) - 強力なマルチライン計算機を内蔵したノートアプリ（PWA）。
* [Carbon.now.sh](https://carbon.now.sh) - コードスニペットを美しいスクリーンショット形式の画像で作成・共有。Twitterやブログ投稿でよく使用されます。
* [Code Time](https://www.software.com/code-time) - VS Code、Atom、IntelliJ、Sublime Textなどで使える時間管理とコーディングメトリクス拡張機能。
* [Codepng](https://www.codepng.app) - ソースコードから優れたスナップショットを作成し、SNSで共有できます。
* [CodeToImage](https://codetoimage.com/) - コードやテキストのスクリーンショットを作成し、SNSで共有できます。
* [Cronhooks](https://cronhooks.io/) - 単発または定期的なWebhookのスケジューリング。無料プランでは5つのアドホックスケジュールが可能。
* [cron-job.org](https://cron-job.org) - オンラインcronジョブサービス。無制限のジョブが無料で利用可能。
* [datelist.io](https://datelist.io) - オンライン予約／アポイントメント管理システム。月5件まで無料、1カレンダー付き。
* [Domain Forward](https://domain-forward.com/) - 任意のURLやドメインを転送できるシンプルなツール。最大5ドメイン、月20万リクエストまで無料。
* [Elementor](https://elementor.com) — WordPressウェブサイトビルダー。40種類以上の基本ウィジェットを備えた無料プランあり。
* [Exif Editor](https://exifeditor.io/) — 画像/写真のメタデータ（GPS位置情報やメタデータ含む）をインブラウザで即座に閲覧・編集・削除・解析可能。
* [Format Express](https://www.format-express.dev) - JSON / XML / SQLを即時にオンラインで整形。
* [FOSSA](https://fossa.com/) - サードパーティコード、ライセンスコンプライアンス、脆弱性を包括的に管理できるスケーラブルなプラットフォーム。
* [Hook Relay](https://www.hookrelay.dev/) - アプリにWebhook機能を簡単追加。キューイング、リトライ、ロギングを自動化。無料プランは1日100配信、14日間保持、3フックエンドポイント。
* [Hosting Checker](https://hostingchecker.co) - 任意のドメイン、ウェブサイト、IPアドレスのASN、ISP、ロケーションなどのホスティング情報をチェック。他にも複数のホスティング・DNS関連ツールを提供。
* [http2.pro](https://http2.pro) — HTTP/2プロトコル対応テストとクライアントHTTP/2サポート検出API。
* [kandi](https://kandi.openweaver.com/) — アプリ開発を迅速化。カスタム機能、ユースケース、アプリ全体をコードスニペットやOSSライブラリ再利用で素早く構築。
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — データのエンコード/デコード用オンライン無料ツール。
* [newreleases.io](https://newreleases.io/) - GitHub、GitLab、Bitbucket、PyPI、Maven、NPM、Yarn、Gems、Packagist、NuGet、Cargo、Docker Hubなどの新リリースをメールやSlack、Telegram、Discord、Webhookで通知。
* [OnlineExifViewer](https://onlineexifviewer.com/) — 写真のEXIFデータ（GPS位置情報やメタデータ含む）をオンライン即時表示。
* [PDFMonkey](https://www.pdfmonkey.io/) — ダッシュボードでPDFテンプレート管理、APIで動的データ呼び出し・PDFダウンロード。月300ドキュメントまで無料。
* [Pika Code Screenshots](https://pika.style/templates/code-image) — コードスニペットやVSCodeから美しくカスタマイズ可能なスクリーンショットを作成する拡張機能。
* [QuickType.io](https://quicktype.io/) - JSON、スキーマ、GraphQLからモデル／クラス／型／インターフェースやシリアライザーを自動生成。あらゆる言語にタイプセーフなコードを高速変換。
* [RandomKeygen](https://randomkeygen.com/) - アプリやサービス、デバイスのセキュリティ向けに様々なランダムキーやパスワードを生成する無料モバイルフレンドリーなツール。
* [ray.so](https://ray.so/) - コードスニペットの美しい画像を作成。
* [readme.com](https://readme.com/) — 美しいドキュメントを簡単作成。オープンソース向けに無料提供。
* [redirection.io](https://redirection.io/) — 企業、マーケティング、SEO向けのHTTPリダイレクト管理SaaSツール。
* [redirect.ing](https://redirect.ing/) - サーバーやSSL証明書管理不要で高速・安全なドメイン転送。無料プランは10ホスト名、月10万リクエスト。
* [redirect.pizza](https://redirect.pizza/) - HTTPS対応のリダイレクト管理が簡単。無料プランは10ソース、月10万ヒット。
* [ReqBin](https://reqbin.com/) — オンラインでHTTPリクエストを送信。GET、POST、PUT、DELETE、HEADなどが利用可能。ヘッダーやトークン認証もサポート。リクエスト保存用の基本的なログインシステム付き。
* [Smartcar API](https://smartcar.com) - 車の位置、燃料・バッテリー残量、走行距離、ドアのロック/アンロックなどを取得できるAPI。
* [snappify](https://snappify.com) - 美しいコードスニペットや技術プレゼンを作成できる開発者向けビジュアル生成サービス。無料プランは同時3スナップ、無制限ダウンロード、月5回AIコード解説。
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - 指定した経度・緯度の「日の出・日の入り」時刻を取得するAPI。
* [superfeedr.com](https://superfeedr.com/) — リアルタイムPubSubHubbub準拠フィード、エクスポート、解析。無料版はカスタマイズ制限あり。
* [SurveyMonkey.com](https://www.surveymonkey.com) — オンラインアンケート作成と結果分析。無料プランは1アンケート10問・100回答まで。
* [Tiledesk](https://tiledesk.com) - チャットボットや会話型アプリを作成。ウェブサイト（ライブチャットウィジェット）からWhatsAppまでオムニチャネル対応。無料プランで無制限チャットボット利用可。
* [Versionfeeds](https://versionfeeds.com) — お気に入りソフトウェアのリリース専用カスタムRSSフィード。言語やライブラリの最新バージョンを一つのフィードで取得（最初の3フィード無料）
* [videoinu](https://videoinu.com) — 画面録画や各種動画をオンラインで作成・編集。
* [Webacus](https://webacus.dev) — エンコーディング、デコーディング、データ加工など多彩な無料開発ツールを提供。

**[⬆️ Topに戻る](#table-of-contents)**

## リモートデスクトップツール

* [Getscreen.me](https://getscreen.me) — 2台まで無料、セッション数・時間無制限
* [Apache Guacamole™](https://guacamole.apache.org/) — オープンソースのクライアントレスリモートデスクトップゲートウェイ
* [RemSupp](https://remsupp.com) — オンデマンドサポートとデバイス恒久アクセス（無料は1日2セッションまで）
* [RustDesk](https://rustdesk.com/) - 誰でも使えるオープンソースの仮想/リモートデスクトップ基盤！
* [AnyDesk](https://anydesk.com) — 3台まで無料、セッション数・時間無制限

**[⬆️ Topに戻る](#table-of-contents)**

## ゲーム開発

* [itch.io](https://itch.io/game-assets) — 無料/有料のスプライト、タイルセット、キャラクターパック等のアセット。
* [Gamefresco.com](https://gamefresco.com/) — 世界中のゲームアーティストによる無料ゲームアセットを発見・収集・共有。
* [GameDevMarket](https://gamedevmarket.net) — 無料/有料の2D・3D・オーディオ・GUIアセット。
* [OpenGameArt](https://opengameart.org) — 音楽・効果音・スプライト・GIFなどのオープンソースゲームアセット。
* [CraftPix](https://craftpix.net) — 無料/有料の2D・3D・オーディオ・GUI・背景・アイコン・タイルセット・ゲームキット。
* [Game Icons](https://game-icons.net/) - CC-BYライセンスのスタイラブルSVG/PNGアイコンを無料提供。
* [LoSpec](https://lospec.com/) — ピクセルアートや制限付きデジタルアート作成のためのオンラインツール。ゲーム用のチュートリアルやパレットリストも多数。
* [ArtStation](https://www.artstation.com/) - 無料/有料の2D・3Dアセット、音声、アイコン、タイルセット、ゲームキットのマーケットプレイス。アートポートフォリオの公開にも利用可能。
* [Rive](https://rive.app/community/) - コミュニティアセットや、無料プランで独自のゲームアセット作成も可能。
* [Poly Pizza](https://poly.pizza/) - 無料のローポリ3Dアセット
* [3Dassets.one](https://3dassets.one/) - 8,000点以上の無料/有料3DモデルおよびPBRマテリアル、テクスチャ作成用素材。
* [Kenney](https://www.kenney.nl/assets/) - 無料（CC0 1.0 Universal）2D・3D・音声・UIゲームアセット。
* [Poliigon](https://www.poliigon.com/) - 解像度可変の無料/有料テクスチャ、モデル、HDRI、ブラシ。Blender等へのエクスポート用無料プラグインも提供。
* [Freesound](https://freesound.org/) - さまざまなCCライセンスで提供される無料の共同サウンドライブラリ。

**[⬆️ Topに戻る](#table-of-contents)**

## その他の無料リソース

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - CSS最小化/復元、画像最適化・リサイズ、ケース変換、CSSバリデータ、JavaScriptコンパイラ、HTMLエディタなどWeb開発者向け常時無料ツール。
* [ElevateAI](https://www.elevateai.com) - 毎月最大200時間分の音声文字起こしを無料で利用可能。
* [get.localhost.direct](https://get.localhost.direct) — サブドメイン対応のパブリックCA署名付き `*.localhost.direct` ワイルドカードSSL証明書をローカル開発向けに提供。
* [Framacloud](https://degooglisons-internet.org/en/) — フランスの非営利団体[Framasoft](https://framasoft.org/en/)によるFLOSSおよびSaaSの一覧。
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — 開発者向け無料・オープンソースソフトウェアのハブ。
* [GitHub Education](https://education.github.com/pack) — 学生向け無料サービス集。登録が必要。
* [Markdown Tools](https://markdowntools.com) - HTML、CSV、PDF、JSON、ExcelファイルをMarkdownへ、またはMarkdownから変換するためのツール。
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Microsoft 365プラットフォーム向けの無料サンドボックスやツールなどを提供。サブスクリプションは90日間の[Microsoft 365 E5](https://www.microsoft.com/microsoft-365/enterprise/e5)（Windowsは除く）で、開発活動があれば自動更新。
* [Pyrexp](https://pythonium.net/regex) — Webベースの正規表現テスター＆ビジュアライザー。正規表現のデバッグに最適。
* [RedHat for Developers](https://developers.redhat.com) — 開発者限定でRHEL、OpenShift、CodeReadyなどRed Hat製品に無料アクセス。個人プランのみ。無料の参考電子書籍も提供。
* [smsreceivefree.com](https://smsreceivefree.com/) — 無料の一時・使い捨て電話番号を提供。
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — テスト用SMSの送受信が無料。
* [SimpleBackups.com](https://simplebackups.com/) — サーバーやデータベース（MySQL、PostgreSQL、MongoDB）をクラウドストレージ（AWS、DigitalOcean、Backblaze）に直接バックアップ自動化。無料プランは1バックアップまで。
* [SnapShooter](https://snapshooter.com/) — DigitalOcean、AWS、LightSail、Hetzner、Exoscale向けバックアップソリューション。s3ベースストレージへのDB・FS・アプリの直接バックアップも対応。無料プランは1リソースの毎日バックアップ。
* [Themeselection](https://themeselection.com/) — 高品質・モダン・プロフェッショナルで使いやすい無料管理ダッシュボードテンプレート、HTMLテーマ、UIキットを提供、アプリ開発を高速化！
* [Web.Dev](https://web.dev/measure/) — ウェブサイトのパフォーマンスやSEO改善点を無料で可視化・分析し、検索エンジンのランクアップに役立つツール。
  * [SmallDev.tools](https://smalldev.tools/) — 開発者向けの無料ツールで、様々なフォーマットのエンコード／デコード、HTML/CSS/Javascriptの圧縮、整形、JSON/CSVおよびその他多数のフォーマットによる偽データ・テストデータセットの生成など、多くの機能を魅力的なインターフェースで提供します。
  * [UseCSV by Layercode](https://layercode.com/usecsv) — 数分でウェブアプリにCSVやExcelのインポート機能を追加できます。ユーザーに快適で堅牢なデータインポート体験を提供。クレジットカード情報不要で無料で開始でき、すぐにUseCSVの統合を始められます。無制限にインポーターを作成でき、最大100MBまでのファイルをアップロード可能です。
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — プロジェクトで使用できる100種類以上のボタンを提供します。
  * [WrapPixel](https://www.wrappixel.com/) — Angular、React、VueJs、NextJS、NuxtJSで作成された高品質な無料・有料の管理ダッシュボードテンプレートをダウンロード可能！
  * [Utils.fun](https://utils.fun/en) — ブラウザの計算能力を活用した、透かし生成、画面録画、エンコード・デコード、暗号化・復号化、コード整形など、オフラインで日常・開発に使えるすべてのツールが完全無料。クラウドにデータをアップロードすることはありません。
  * [It tools](it-tools.tech) - 開発者やIT関連の仕事をする人に役立つツール集。
  * [Free Code Tools](https://freecodetools.org/) — 100％無料の効果的なコードツール。Markdownエディタ、コード圧縮・整形、QRコード生成、Open Graphジェネレーター、Twitterカードジェネレーターなど。
  * [regex101](https://regex101.com/) — 無料で正規表現（regex）のテスト・デバッグができるウェブサイト。エディターとテスターの他、学習用ドキュメントやリソースも充実。
  * [Kody Tools](https://www.kodytools.com/dev-tools) — フォーマッター、ミニファイア、コンバーターなど100以上の開発ツールを提供。
  * [AdminMart](https://adminmart.com/) — Angular、Bootstrap、React、VueJs、NextJS、NuxtJSで作成された高品質な無料・有料の管理ダッシュボードおよびウェブサイトテンプレート。
  * [Glob tester](https://globster.xyz/) — グロブパターンの設計・テストができるウェブサイト。学習リソースも提供。
  * [SimpleRestore](https://simplerestore.io) - 面倒な手間なしでMySQLバックアップを復元。コードやサーバー不要で任意のリモートデータベースにMySQLバックアップを復元可能。
  * [360Converter](https://www.360converter.com/) - 動画→テキスト、音声→テキスト、スピーチ→テキスト、リアルタイム音声→テキスト、YouTube動画→テキスト、動画字幕追加などに使える無料変換サイト。ショート動画やYouTubeチュートリアルの変換に便利かもしれません:)
  * [QRCodeBest](https://qrcode.best/) - 13種類のテンプレート、完全なプライバシー管理、個人ブランディング対応のカスタムQRコードを作成。トラッキングピクセル、プロジェクト分類、チームメンバー無制限などの機能を提供。
  * [PostPulse](https://PostPulseAI.com) - オンラインでの存在感向上、SEO・サイトランキング強化のため、AIで作成した投稿を毎月SEO最適化ドメインに配信。無料プランでは毎月1件、手動で当サイトに投稿可能。
  * [PageTools](https://pagetools.co/) - 主要なウェブサイトポリシー生成、SNS用プロフィール・投稿・ウェブページ作成など、ワンクリックで使えるAI搭載ツールを永久無料で提供。
  * [MySQL Visual Explain](https://mysqlexplain.com) - わかりやすく無料で使えるMySQL EXPLAIN出力の可視化ツール。遅いクエリの最適化に最適。
  * [Killer Coda](https://killercoda.com/)  - ブラウザ上でLinux、Kubernetes、コンテナ、プログラミング、DevOps、ネットワークを学べるインタラクティブなプレイグラウンド。
  * [Axonomy App](https://axonomy-app.com/) - 無料で請求書を作成・管理・共有できるツール。月10件まで無料。
  * [Table Format Converter](https://www.tableformatconverter.com) - CSV、HTML、JSON、Markdownなど、様々なフォーマットへ表データを変換できる無料ツール。


**[⬆️ Topに戻る](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---