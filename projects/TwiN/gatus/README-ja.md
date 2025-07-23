
[![Gatus](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/logo-with-dark-text.png)](https://gatus.io)

![test](https://github.com/TwiN/gatus/actions/workflows/test.yml/badge.svg)
[![Go Report Card](https://goreportcard.com/badge/github.com/TwiN/gatus?)](https://goreportcard.com/report/github.com/TwiN/gatus)
[![codecov](https://codecov.io/gh/TwiN/gatus/branch/master/graph/badge.svg)](https://codecov.io/gh/TwiN/gatus)
[![Go version](https://img.shields.io/github/go-mod/go-version/TwiN/gatus.svg)](https://github.com/TwiN/gatus)
[![Docker pulls](https://img.shields.io/docker/pulls/twinproduction/gatus.svg)](https://cloud.docker.com/repository/docker/twinproduction/gatus)
[![Follow TwiN](https://img.shields.io/github/followers/TwiN?label=Follow&style=social)](https://github.com/TwiN)

Gatusは、HTTP、ICMP、TCP、さらにはDNSクエリを使用してサービスを監視できる、開発者向けのヘルスダッシュボードです。
ステータスコード、応答時間、証明書の有効期限、ボディなどの値に対して条件リストを使い、これらのクエリの結果を評価できます。
さらに、それぞれのヘルスチェックはSlack、Teams、PagerDuty、Discord、Twilioなどを通じたアラートと連携可能です。

私は個人的にKubernetesクラスターにデプロイし、コアアプリケーションの状態を監視しています：
https://status.twin.sh/

_マネージドソリューションをお探しですか？[Gatus.io](https://gatus.io)をご覧ください。_

<details>
  <summary><b>クイックスタート</b></summary>



```console
docker run -p 8080:8080 --name gatus twinproduction/gatus:stable
```
GitHub Container Registry を使用することもできます:
```console
docker run -p 8080:8080 --name gatus ghcr.io/twin/gatus:stable
```
詳細については、[Usage](#usage) を参照してください。
</details>

> ❤ このプロジェクトが気に入りましたか？ぜひ [スポンサーになる](https://github.com/sponsors/TwiN) ことをご検討ください。

![Gatus dashboard](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/dashboard-dark.png)

ご意見やご質問がありますか？[ディスカッションを作成](https://github.com/TwiN/gatus/discussions/new)してください。


## 目次
- [目次](#table-of-contents)
- [なぜGatus？](#why-gatus)
- [機能](#features)
- [使用法](#usage)
- [設定](#configuration)
  - [エンドポイント](#endpoints)
  - [外部エンドポイント](#external-endpoints)
  - [条件](#conditions)
    - [プレースホルダー](#placeholders)
    - [関数](#functions)
  - [ストレージ](#storage)
  - [クライアント設定](#client-configuration)
  - [アラート設定](#alerting)
    - [AWS SESアラートの設定](#configuring-aws-ses-alerts)
    - [Discordアラートの設定](#configuring-discord-alerts)
    - [メールアラートの設定](#configuring-email-alerts)
    - [Giteaアラートの設定](#configuring-gitea-alerts)
    - [GitHubアラートの設定](#configuring-github-alerts)
    - [GitLabアラートの設定](#configuring-gitlab-alerts)
    - [Google Chatアラートの設定](#configuring-google-chat-alerts)
    - [Gotifyアラートの設定](#configuring-gotify-alerts)
    - [HomeAssistantアラートの設定](#configuring-homeassistant-alerts)
    - [Ilertアラートの設定](#configuring-ilert-alerts)
    - [Incident.ioアラートの設定](#configuring-incidentio-alerts)
    - [JetBrains Spaceアラートの設定](#configuring-jetbrains-space-alerts)
    - [Matrixアラートの設定](#configuring-matrix-alerts)
    - [Mattermostアラートの設定](#configuring-mattermost-alerts)
    - [Messagebirdアラートの設定](#configuring-messagebird-alerts)
    - [Ntfyアラートの設定](#configuring-ntfy-alerts)
    - [Opsgenieアラートの設定](#configuring-opsgenie-alerts)
    - [PagerDutyアラートの設定](#configuring-pagerduty-alerts)
    - [Pushoverアラートの設定](#configuring-pushover-alerts)
    - [Slackアラートの設定](#configuring-slack-alerts)
    - [Teamsアラートの設定 *(非推奨)*](#configuring-teams-alerts-deprecated)
    - [Teams Workflowアラートの設定](#configuring-teams-workflow-alerts)
    - [Telegramアラートの設定](#configuring-telegram-alerts)
    - [Twilioアラートの設定](#configuring-twilio-alerts)
    - [Zulipアラートの設定](#configuring-zulip-alerts)
    - [カスタムアラートの設定](#configuring-custom-alerts)
    - [デフォルトアラートの設定](#setting-a-default-alert)
  - [メンテナンス](#maintenance)
  - [セキュリティ](#security)
    - [ベーシック認証](#basic-authentication)
    - [OIDC](#oidc)
  - [TLS暗号化](#tls-encryption)
  - [メトリクス](#metrics)
  - [接続性](#connectivity)
  - [リモートインスタンス（実験的）](#remote-instances-experimental)
- [デプロイ](#deployment)
  - [Docker](#docker)
  - [Helm Chart](#helm-chart)
  - [Terraform](#terraform)
- [テストの実行](#running-the-tests)
- [本番環境での使用](#using-in-production)
- [FAQ](#faq)
  - [GraphQLリクエストの送信](#sending-a-graphql-request)
  - [推奨間隔](#recommended-interval)
  - [デフォルトタイムアウト](#default-timeouts)
  - [TCPエンドポイントの監視](#monitoring-a-tcp-endpoint)
  - [UDPエンドポイントの監視](#monitoring-a-udp-endpoint)
  - [SCTPエンドポイントの監視](#monitoring-a-sctp-endpoint)
  - [WebSocketエンドポイントの監視](#monitoring-a-websocket-endpoint)
  - [ICMPを使用したエンドポイントの監視](#monitoring-an-endpoint-using-icmp)
  - [DNSクエリを使用したエンドポイントの監視](#monitoring-an-endpoint-using-dns-queries)
  - [SSHを使用したエンドポイントの監視](#monitoring-an-endpoint-using-ssh)
  - [STARTTLSを使用したエンドポイントの監視](#monitoring-an-endpoint-using-starttls)
  - [TLSを使用したエンドポイントの監視](#monitoring-an-endpoint-using-tls)
  - [ドメインの有効期限監視](#monitoring-domain-expiration)
  - [disable-monitoring-lock](#disable-monitoring-lock)
  - [設定のオンザフライリロード](#reloading-configuration-on-the-fly)
  - [エンドポイントグループ](#endpoint-groups)
  - [Gatusをカスタムパスで公開する](#exposing-gatus-on-a-custom-path)
  - [Gatusをカスタムポートで公開する](#exposing-gatus-on-a-custom-port)
  - [起動遅延の設定](#configuring-a-startup-delay)
  - [設定を小さく保つ方法](#keeping-your-configuration-small)
  - [プロキシクライアント設定](#proxy-client-configuration)
  - [431 Request Header Fields Too Largeエラーの修正方法](#how-to-fix-431-request-header-fields-too-large-error)
  - [バッジ](#badges)
    - [稼働時間](#uptime)
    - [ヘルス](#health)
    - [ヘルス (Shields.io)](#health-shieldsio)
    - [応答時間](#response-time)
    - [応答時間 (チャート)](#response-time-chart)
      - [応答時間バッジの色閾値の変更方法](#how-to-change-the-color-thresholds-of-the-response-time-badge)
  - [API](#api)
    - [生データ](#raw-data)
      - [稼働時間](#uptime-1)
      - [応答時間](#response-time-1)
  - [バイナリとしてのインストール](#installing-as-binary)
  - [ハイレベル設計概要](#high-level-design-overview)


## なぜGatusなのか？
詳細に入る前に、最も一般的な質問に答えたいと思います：
> なぜPrometheusのAlertmanagerやCloudwatch、さらにはSplunkを使わずにGatusを使うのか？

これらはいずれも、エンドポイントを積極的に呼び出しているクライアントがいなければ問題を知らせることができません。
言い換えれば、監視メトリクスは主に既存のトラフィックに依存しているため、
クライアントがすでに問題を経験していない限り通知は届かないということです。

一方でGatusは、各機能のヘルスチェックを設定できるため、
これらの機能を監視し、クライアントに影響が出る前に警告を出すことが可能です。

Gatusを検討すべきサインは、ロードバランサーが今すぐダウンした場合にアラートを受け取れるか自問してみることです。
既存のアラートのいずれかが発動しますか？トラフィックがアプリケーションに届かなければエラーの増加はメトリクスに現れません。
つまり、クライアントがサービスの劣化を通知する側になり、
問題を彼らが知る前に修正作業を進めていることを安心して伝えられない状況に陥ってしまうのです。


## 特徴
Gatusの主な特徴は以下の通りです：

- **非常に柔軟なヘルスチェック条件**：レスポンスステータスのチェックだけで十分なケースもありますが、Gatusはさらに進んでレスポンスタイム、レスポンスボディ、さらにはIPアドレスに条件を追加することが可能です。
- **ユーザー受け入れテストとしての利用**：上記の機能により、このアプリケーションを自動ユーザー受け入れテストの作成に活用できます。
- **設定が非常に簡単**：設定はできるだけ読みやすく設計されているだけでなく、新しいサービスや監視対象のエンドポイントを追加するのも非常に簡単です。
- **アラート機能**：アプリケーションの状態を追跡するための視覚的なダッシュボードは便利ですが、一日中見続けるわけにはいきません。したがって、Slack、Mattermost、Messagebird、PagerDuty、Twilio、Googleチャット、Teamsへの通知が標準対応しており、異なるプロバイダや自動ロールバックを管理するカスタムアプリなど、あらゆるニーズに応じたカスタムアラートプロバイダも設定可能です。
- **メトリクス**
- **低リソース消費**：多くのGoアプリケーションと同様に、このアプリケーションのリソース使用量は非常に小さいです。
- **[バッジ](#badges)**： ![稼働時間7日](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/7d/badge.svg) ![レスポンスタイム24時間](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/24h/badge.svg)
- **ダークモード**

![Gatusダッシュボードの条件](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/dashboard-conditions.png)


## 使用方法

<details>
  <summary><b>クイックスタート</b></summary>


```console
docker run -p 8080:8080 --name gatus twinproduction/gatus
```
GitHub Container Registry を使用することもできます:
```console
docker run -p 8080:8080 --name gatus ghcr.io/twin/gatus
```

独自の設定を作成したい場合は、設定ファイルのマウント方法については [Docker](#docker) を参照してください。
</details>

簡単な例を示します：

```yaml
endpoints:
  - name: website                 # Name of your endpoint, can be anything
    url: "https://twin.sh/health"
    interval: 5m                  # Duration to wait between every status check (default: 60s)
    conditions:
      - "[STATUS] == 200"         # Status must be 200
      - "[BODY].status == UP"     # The json path "$.status" must be equal to UP
      - "[RESPONSE_TIME] < 300"   # Response time must be under 300ms

  - name: make-sure-header-is-rendered
    url: "https://example.org/"
    interval: 60s
    conditions:
      - "[STATUS] == 200"                          # Status must be 200
      - "[BODY] == pat(*<h1>Example Domain</h1>*)" # Body must contain the specified header
```
この例は次のように表示されます：

![Simple example](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/example.png)

デフォルトでは、設定ファイルは `config/config.yaml` にあることが想定されています。

`GATUS_CONFIG_PATH` 環境変数を設定することでカスタムパスを指定できます。

`GATUS_CONFIG_PATH` がディレクトリを指している場合、そのディレクトリとそのサブディレクトリ内のすべての `*.yaml` および `*.yml` ファイルは次のようにマージされます：
- すべてのマップ/オブジェクトはディープマージされます（つまり、あるファイルに `alerting.slack` を定義し、別のファイルに `alerting.pagerduty` を定義することができます）
- すべてのスライス/配列は追加されます（つまり、複数のファイルで `endpoints` を定義でき、各エンドポイントは最終的なエンドポイントリストに追加されます）
- プリミティブ値のパラメータ（例：`metrics`、`alerting.slack.webhook-url` など）は、曖昧さを強制的に避けるために一度だけ定義できます
    - 明確にするために、これは `alerting.slack.webhook-url` を異なる値で2つのファイルに定義できないことも意味します。すべてのファイルは処理される前に1つにマージされます。これは設計によるものです。

> 💡 設定ファイル内で環境変数を使用することもできます（例：`$DOMAIN`、`${DOMAIN}`）
>
> 例については [examples/docker-compose-postgres-storage/config/config.yaml](https://raw.githubusercontent.com/TwiN/gatus/master/.examples/docker-compose-postgres-storage/config/config.yaml) を参照してください。

ローカルでテストしたい場合は、[Docker](#docker)を参照してください。


## 設定
| パラメータ                   | 説明                                                                                                                                  | デフォルト                  |
|:-----------------------------|:-------------------------------------------------------------------------------------------------------------------------------------|:---------------------------|
| `metrics`                    | `/metrics` でメトリクスを公開するかどうか。                                                                                          | `false`                    |
| `storage`                    | [ストレージ設定](#storage)。                                                                                                         | `{}`                       |
| `alerting`                   | [アラート設定](#alerting)。                                                                                                           | `{}`                       |
| `endpoints`                  | [エンドポイント設定](#endpoints)。                                                                                                   | 必須 `[]`                  |
| `external-endpoints`         | [外部エンドポイント設定](#external-endpoints)。                                                                                       | `[]`                       |
| `security`                   | [セキュリティ設定](#security)。                                                                                                     | `{}`                       |
| `disable-monitoring-lock`    | [モニタリングロックを無効にするかどうか](#disable-monitoring-lock)。                                                                  | `false`                    |
| `skip-invalid-config-update` | 無効な設定更新を無視するかどうか。 <br />[設定のリアルタイムリロード](#reloading-configuration-on-the-fly)を参照してください。         | `false`                    |
| `web`                        | Web設定。                                                                                                                           | `{}`                       |
| `web.address`                | 待ち受けアドレス。                                                                                                                   | `0.0.0.0`                  |
| `web.port`                   | 待ち受けポート。                                                                                                                     | `8080`                     |
| `web.read-buffer-size`       | コネクションからリクエストを読み取るためのバッファサイズ。また最大ヘッダーサイズの制限。                                            | `8192`                     |
| `web.tls.certificate-file`   | TLS用のPEM形式の公開証明書ファイル（オプション）。                                                                                     | ``                         |
| `web.tls.private-key-file`   | TLS用のPEM形式の秘密鍵ファイル（オプション）。                                                                                         | ``                         |
| `ui`                         | UI設定。                                                                                                                           | `{}`                       |
| `ui.title`                   | [ドキュメントのタイトル](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/title)。                                            | `Health Dashboard ǀ Gatus` |
| `ui.description`             | ページのメタ記述。                                                                                                                   | `Gatus is an advanced...`. |
| `ui.header`                  | ダッシュボード上部のヘッダー。                                                                                                        | `Health Status`            |
| `ui.logo`                    | 表示するロゴのURL。                                                                                                                  | `""`                       |
| `ui.link`                    | ロゴがクリックされたときに開くリンク。                                                                                               | `""`                       |
| `ui.buttons`                 | ヘッダーの下に表示するボタンのリスト。                                                                                               | `[]`                       |
| `ui.buttons[].name`          | ボタンに表示するテキスト。                                                                                                           | 必須 `""`                  |
| `ui.buttons[].link`          | ボタンがクリックされたときに開くリンク。                                                                                            | 必須 `""`                  |
| `ui.custom-css`              | カスタムCSS。                                                                                                                       | `""`                       |
| `ui.dark-mode`               | デフォルトでダークモードを有効にするかどうか。これはユーザーのOSテーマの優先設定により上書きされます。                             | `true`                     |
| `maintenance`                | [メンテナンス設定](#maintenance)。                                                                                                 | `{}`                       |

より詳細なログを出力したい場合は、`GATUS_LOG_LEVEL` 環境変数を `DEBUG` に設定してください。
逆に、ログを控えめにしたい場合は、上記環境変数を `WARN`、`ERROR`、または `FATAL` に設定できます。
`GATUS_LOG_LEVEL` のデフォルト値は `INFO` です。

### エンドポイント
エンドポイントは監視したいURL、アプリケーション、またはサービスです。各エンドポイントには条件のリストがあり、
指定した間隔で評価されます。条件のいずれかが失敗すると、そのエンドポイントは不健康とみなされます。
その後、エンドポイントが不健康となった際に特定の閾値に達したときにアラートをトリガーするよう設定できます。

| パラメータ                                       | 説明                                                                                                                                     | デフォルト                  |
|:------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------|:---------------------------|
| `endpoints`                                     | 監視するエンドポイントのリスト。                                                                                                       | 必須 `[]`                  |
| `endpoints[].enabled`                           | エンドポイントを監視するかどうか。                                                                                                      | `true`                     |
| `endpoints[].name`                              | エンドポイントの名前。任意の文字列。                                                                                                    | 必須 `""`                  |
| `endpoints[].group`                             | グループ名。ダッシュボード上で複数のエンドポイントをグループ化するために使用。 <br />[エンドポイントグループ](#endpoint-groups)を参照。 | `""`                       |
| `endpoints[].url`                               | リクエストを送信するURL。                                                                                                               | 必須 `""`                  |
| `endpoints[].method`                            | リクエストメソッド。                                                                                                                     | `GET`                      |
| `endpoints[].conditions`                        | エンドポイントの状態を判断する条件。 <br />[条件](#conditions)を参照。                                                                 | `[]`                       |
| `endpoints[].interval`                          | 各ステータスチェック間の待機時間。                                                                                                      | `60s`                      |
| `endpoints[].graphql`                           | ボディをクエリパラメータ（`{"query":"$body"}`）でラップするかどうか。                                                                    | `false`                    |
| `endpoints[].body`                              | リクエストボディ。                                                                                                                       | `""`                       |
| `endpoints[].headers`                           | リクエストヘッダー。                                                                                                                    | `{}`                       |
| `endpoints[].dns`                               | DNSタイプのエンドポイント設定。 <br />[DNSクエリを用いたエンドポイント監視](#monitoring-an-endpoint-using-dns-queries)を参照。            | `""`                       |
| `endpoints[].dns.query-type`                    | クエリタイプ（例：MX）。                                                                                                                 | `""`                       |
| `endpoints[].dns.query-name`                    | クエリ名（例：example.com）。                                                                                                           | `""`                       |
| `endpoints[].ssh`                               | SSHタイプのエンドポイント設定。 <br />[SSHを用いたエンドポイント監視](#monitoring-an-endpoint-using-ssh)を参照。                          | `""`                       |
| `endpoints[].ssh.username`                      | SSHユーザー名（例：example）。                                                                                                          | 必須 `""`                  |
| `endpoints[].ssh.password`                      | SSHパスワード（例：password）。                                                                                                         | 必須 `""`                  |
| `endpoints[].alerts`                            | 該当エンドポイントのすべてのアラートリスト。 <br />[アラート](#alerting)を参照。                                                        | `[]`                       |
| `endpoints[].maintenance-windows`               | 該当エンドポイントのメンテナンスウィンドウのリスト。 <br />[メンテナンス](#maintenance)を参照。                                         | `[]`                       |
| `endpoints[].client`                            | [クライアント設定](#client-configuration)。                                                                                            | `{}`                       |
| `endpoints[].ui`                                | エンドポイントレベルのUI設定。                                                                                                         | `{}`                       |
| `endpoints[].ui.hide-conditions`                | 結果から条件を非表示にするかどうか。この設定は有効になった時点以降に評価された結果のみ条件を非表示にします。                             | `false`                    |
| `endpoints[].ui.hide-hostname`                  | 結果からホスト名を非表示にするかどうか。                                                                                                | `false`                    |
| `endpoints[].ui.hide-port`                      | 結果からポートを非表示にするかどうか。                                                                                                  | `false`                    |
| `endpoints[].ui.hide-url`                       | 結果からURLを非表示にするかどうか。URLにトークンが含まれている場合に便利です。                                                           | `false`                    |
| `endpoints[].ui.dont-resolve-failed-conditions` | UI用に失敗した条件を解決するかどうか。                                                                                                  | `false`                    |
| `endpoints[].ui.badge.response-time`            | レスポンスタイムの閾値リスト。閾値に達するたびにバッジの色が変わります。                                                                | `[50, 200, 300, 500, 750]` |

ボディ（`endpoints[].body`）には以下のプレースホルダーを使用できます：
- `[ENDPOINT_NAME]` (`endpoints[].name` から解決)
- `[ENDPOINT_GROUP]` (`endpoints[].group` から解決)
- `[ENDPOINT_URL]` (`endpoints[].url` から解決)
- `[LOCAL_ADDRESS]`（`192.0.2.1:25` や `[2001:db8::1]:80` のようなローカルIPとポートに解決）
- `[RANDOM_STRING_N]`（長さNの数字と文字のランダム文字列に解決）




### 外部エンドポイント
通常のエンドポイントとは異なり、外部エンドポイントはGatusによって監視されるのではなく、プログラムによってプッシュされます。
これにより、Gatusが通常アクセスできない環境にあるものでも、監視したいものを何でも監視できます。

例えば：
- プライベートネットワークに存在する独自のエージェントを作成し、サービスの状態を公開されたGatusインスタンスにプッシュできます
- Gatusがサポートしていないサービスを監視できます
- Gatusをダッシュボードとして使用しながら、独自の監視システムを実装できます

| パラメーター                     | 説明                                                                                                                   | デフォルト     |
|:-------------------------------|:-----------------------------------------------------------------------------------------------------------------------|:--------------|
| `external-endpoints`           | 監視するエンドポイントのリスト。                                                                                       | `[]`          |
| `external-endpoints[].enabled` | エンドポイントを監視するかどうか。                                                                                     | `true`        |
| `external-endpoints[].name`    | エンドポイントの名前。任意の文字列を指定可能。                                                                         | 必須 `""`     |
| `external-endpoints[].group`   | グループ名。ダッシュボード上で複数のエンドポイントをグループ化するために使用。 <br />[エンドポイントグループ](#endpoint-groups)を参照。 | `""`          |
| `external-endpoints[].token`   | ステータスをプッシュするために必要なベアラートークン。                                                                  | 必須 `""`     |
| `external-endpoints[].alerts`  | 指定したエンドポイントのすべてのアラートのリスト。 <br />[アラート](#alerting)を参照。                                   | `[]`          |

例：
```yaml
external-endpoints:
  - name: ext-ep-test
    group: core
    token: "potato"
    alerts:
      - type: discord
        description: "healthcheck failed"
        send-on-resolved: true
```
外部エンドポイントのステータスをプッシュするには、リクエストは次のようにする必要があります:

```
POST /api/v1/endpoints/{key}/external?success={success}&error={error}&duration={duration}
```
Where:
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` というパターンで、両方の変数内の ` `、`/`、`_`、`,`、`.`、`#` が `-` に置換されます。
  - 上記の例の設定を使用すると、キーは `core_ext-ep-test` となります。
- `{success}` はヘルスチェックが成功したかどうかを示すブール値（`true` または `false`）です。
- `{error}`（オプション）：ヘルスチェック失敗の理由を説明する文字列です。{success} が false の場合はエラーメッセージを含み、チェックが成功した場合は含みません。
- `{duration}`（オプション）：リクエストにかかった時間を示す期間文字列（例：10s）です。

トークンは `Authorization` ヘッダーで `Bearer` トークンとして渡す必要があります。


### Conditions
以下は使用可能な条件の例です：

| Condition                        | 説明                                                    | 合格値                     | 不合格値         |
|:---------------------------------|:-------------------------------------------------------|:---------------------------|------------------|
| `[STATUS] == 200`                | ステータスが200である必要があります                     | 200                        | 201, 404, ...    |
| `[STATUS] < 300`                 | ステータスが300未満である必要があります                  | 200, 201, 299              | 301, 302, ...    |
| `[STATUS] <= 299`                | ステータスが299以下である必要があります                   | 200, 201, 299              | 301, 302, ...    |
| `[STATUS] > 400`                 | ステータスが400より大きい必要があります                   | 401, 402, 403, 404         | 400, 200, ...    |
| `[STATUS] == any(200, 429)`      | ステータスが200か429のいずれかである必要があります       | 200, 429                   | 201, 400, ...    |
| `[CONNECTED] == true`            | ホストへの接続が成功している必要があります               | true                       | false            |
| `[RESPONSE_TIME] < 500`          | 応答時間が500ms未満である必要があります                   | 100ms, 200ms, 300ms        | 500ms, 501ms     |
| `[IP] == 127.0.0.1`              | 対象IPが127.0.0.1である必要があります                    | 127.0.0.1                  | 0.0.0.0          |
| `[BODY] == 1`                    | ボディが1と等しい必要があります                           | 1                          | `{}`, `2`, ...   |
| `[BODY].user.name == john`       | JSONPath `$.user.name` の値が `john` と等しい             | `{"user":{"name":"john"}}` |                  |
| `[BODY].data[0].id == 1`         | JSONPath `$.data[0].id` の値が1と等しい                   | `{"data":[{"id":1}]}`      |                  |
| `[BODY].age == [BODY].id`        | JSONPath `$.age` の値がJSONPath `$.id` と等しい           | `{"age":1,"id":1}`         |                  |
| `len([BODY].data) < 5`           | JSONPath `$.data` の配列の要素数が5未満である             | `{"data":[{"id":1}]}`      |                  |
| `len([BODY].name) == 8`          | JSONPath `$.name` の文字列長が8である                     | `{"name":"john.doe"}`      | `{"name":"bob"}` |
| `has([BODY].errors) == false`    | JSONPath `$.errors` が存在しない                          | `{"name":"john.doe"}`      | `{"errors":[]}`  |
| `has([BODY].users) == true`      | JSONPath `$.users` が存在する                             | `{"users":[]}`             | `{}`             |
| `[BODY].name == pat(john*)`      | JSONPath `$.name` の文字列がパターン `john*` にマッチ    | `{"name":"john.doe"}`      | `{"name":"bob"}` |
| `[BODY].id == any(1, 2)`         | JSONPath `$.id` の値が `1` または `2` と等しい           | 1, 2                       | 3, 4, 5          |
| `[CERTIFICATE_EXPIRATION] > 48h` | 証明書の有効期限が48時間以上先である                     | 49h, 50h, 123h             | 1h, 24h, ...     |
| `[DOMAIN_EXPIRATION] > 720h`     | ドメインの有効期限が720時間以上先である                   | 4000h                      | 1h, 24h, ...     |


#### Placeholders
| プレースホルダー             | 説明                                                                                  | 解決例                                         |
|:----------------------------|:-------------------------------------------------------------------------------------|:-----------------------------------------------|
| `[STATUS]`                  | リクエストのHTTPステータスに解決されます                                            | `404`                                          |
| `[RESPONSE_TIME]`           | リクエストにかかった応答時間（ms単位）に解決されます                                | `10`                                           |
| `[IP]`                      | 対象ホストのIPに解決されます                                                        | `192.168.0.232`                                |
| `[BODY]`                    | レスポンスボディに解決されます。JSONPathをサポートします。                          | `{"name":"john.doe"}`                          |
| `[CONNECTED]`               | 接続が確立できたかどうかに解決されます                                              | `true`                                         |
| `[CERTIFICATE_EXPIRATION]` | 証明書の有効期限までの期間に解決されます（有効な単位は "s", "m", "h"）              | `24h`, `48h`, 0（証明書なしプロトコルの場合） |
| `[DOMAIN_EXPIRATION]`       | ドメインの有効期限までの期間に解決されます（有効な単位は "s", "m", "h"）            | `24h`, `48h`, `1234h56m78s`                    |
| `[DNS_RCODE]`               | DNSレスポンスの状態に解決されます                                                  | `NOERROR`                                      |


#### Functions
| 関数       | 説明                                                                                                                                                              | 例                                |
|:-----------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------|
| `len`      | 指定したパスが配列の場合、その長さを返します。そうでなければ、指定パスのJSONをミニファイし文字列化した文字数を返します。 `[BODY]` プレースホルダーのみ対応。 | `len([BODY].username) > 8`        |
| `has`      | 指定したパスが有効かどうかに応じて `true` または `false` を返します。 `[BODY]` プレースホルダーのみ対応。                                                     | `has([BODY].errors) == false`     |
| `pat`      | パラメータとして渡した文字列をパターンとして評価することを指定します。`==` と `!=` のみ対応。                                                                    | `[IP] == pat(192.168.*)`          |
| `any`      | パラメータとして渡した値のいずれか一つが有効な値であることを指定します。`==` と `!=` のみ対応。                                                                  | `[BODY].ip == any(127.0.0.1, ::1)` |

> 💡 必要な場合にのみ `pat` を使用してください。`[STATUS] == pat(2*)` は `[STATUS] < 300` よりもはるかにコストがかかります。


### Storage
| パラメーター                      | 説明                                                                                                                         | デフォルト   |
|:---------------------------------|:----------------------------------------------------------------------------------------------------------------------------|:------------|
| `storage`                        | ストレージ設定                                                                                                               | `{}`        |
| `storage.path`                   | データを永続化するパス。`sqlite` と `postgres` のみサポート。                                                                | `""`        |
| `storage.type`                   | ストレージの種類。有効なタイプ：`memory`、`sqlite`、`postgres`。                                                             | `"memory"`  |
| `storage.caching`                | ライトスルーキャッシュを使うかどうか。大規模ダッシュボードの読み込み時間を改善します。<br />`storage.type` が `sqlite` または `postgres` の場合のみサポート。 | `false`     |
| `storage.maximum-number-of-results` | エンドポイントが保持できる最大結果数                                                                                         | `100`       |
| `storage.maximum-number-of-events`  | エンドポイントが保持できる最大イベント数                                                                                     | `50`        |

各エンドポイントのヘルスチェック結果および稼働時間や過去イベントのデータは、ダッシュボード上に表示するために永続化される必要があります。
これらのパラメーターで該当するストレージの設定を行います。

- `storage.type` が `memory`（デフォルト）の場合：
```yaml
# Note that this is the default value, and you can omit the storage configuration altogether to achieve the same result.
# Because the data is stored in memory, the data will not survive a restart.
storage:
  type: memory
  maximum-number-of-results: 200
  maximum-number-of-events: 5
```
- `storage.type` が `sqlite` の場合、`storage.path` は空白であってはなりません:
```yaml
storage:
  type: sqlite
  path: data.db
```
[examples/docker-compose-sqlite-storage](.examples/docker-compose-sqlite-storage) の例を参照してください。

- `storage.type` が `postgres` の場合、`storage.path` は接続URLでなければなりません:
```yaml
storage:
  type: postgres
  path: "postgres://user:password@127.0.0.1:5432/gatus?sslmode=disable"
```
See [examples/docker-compose-postgres-storage](.examples/docker-compose-postgres-storage) for an example.


### クライアント設定
多様な環境をサポートするために、監視対象の各エンドポイントはリクエスト送信用のクライアントに対してユニークな設定を持ちます。

| パラメータ                             | 説明                                                                        | デフォルト       |
|:---------------------------------------|:----------------------------------------------------------------------------|:----------------|
| `client.insecure`                      | サーバーの証明書チェーンとホスト名の検証をスキップするかどうか。               | `false`         |
| `client.ignore-redirect`               | リダイレクトを無視する（true）か追従する（false、デフォルト）か。               | `false`         |
| `client.timeout`                       | タイムアウトまでの期間。                                                      | `10s`           |
| `client.dns-resolver`                  | `{proto}://{host}:{port}` 形式でDNSリゾルバーを上書き。                        | `""`            |
| `client.oauth2`                        | OAuth2クライアントの設定。                                                    | `{}`            |
| `client.oauth2.token-url`              | トークンエンドポイントのURL。                                                 | 必須 `""`       |
| `client.oauth2.client-id`              | `Client credentials flow` に使用するクライアントID。                          | 必須 `""`       |
| `client.oauth2.client-secret`          | `Client credentials flow` に使用するクライアントシークレット。                 | 必須 `""`       |
| `client.oauth2.scopes[]`               | `Client credentials flow` に使用する `scopes` のリスト。                       | 必須 `[""]`     |
| `client.proxy-url`                     | クライアントに使用するプロキシのURL。                                        | `""`            |
| `client.identity-aware-proxy`          | Google Identity-Aware-Proxy クライアント設定。                                | `{}`            |
| `client.identity-aware-proxy.audience` | Identity-Aware-Proxyのオーディエンス。（IAP oauth2認証情報のclient-id）        | 必須 `""`       |
| `client.tls.certificate-file`          | mTLS構成用のクライアント証明書のパス（PEM形式）。                             | `""`            |
| `client.tls.private-key-file`          | mTLS構成用のクライアント秘密鍵のパス（PEM形式）。                             | `""`            |
| `client.tls.renegotiation`             | 提供する再ネゴシエーションの種類。（`never`、`freely`、`once`）。              | `"never"`       |
| `client.network`                       | ICMPエンドポイントクライアントに使用するネットワーク（`ip`、`ip4`、`ip6`）。 | `"ip"`          |


> 📝 これらのパラメータの一部はエンドポイントの種類により無視されることがあります。例えば、ICMPリクエスト（ping）には証明書は関係しないため、
> そのタイプのエンドポイントに対して `client.insecure` を `true` に設定しても効果はありません。

このデフォルト設定は以下の通りです：


```yaml
client:
  insecure: false
  ignore-redirect: false
  timeout: 10s
```


この設定は `endpoints[]`、`alerting.mattermost`、および `alerting.custom` の下でのみ利用可能であることに注意してください。

以下は `endpoints[]` の下にクライアント設定がある例です：


```yaml
endpoints:
  - name: website
    url: "https://twin.sh/health"
    client:
      insecure: false
      ignore-redirect: false
      timeout: 10s
    conditions:
      - "[STATUS] == 200"
```
この例は、カスタムDNSリゾルバーを指定する方法を示しています:


```yaml
endpoints:
  - name: with-custom-dns-resolver
    url: "https://your.health.api/health"
    client:
      dns-resolver: "tcp://8.8.8.8:53"
    conditions:
      - "[STATUS] == 200"
```
この例は、`client.oauth2` 設定を使用して `Bearer token` でバックエンドAPIをクエリする方法を示しています:


```yaml
endpoints:
  - name: with-custom-oauth2
    url: "https://your.health.api/health"
    client:
      oauth2:
        token-url: https://your-token-server/token
        client-id: 00000000-0000-0000-0000-000000000000
        client-secret: your-client-secret
        scopes: ['https://your.health.api/.default']
    conditions:
      - "[STATUS] == 200"
```
この例は、`client.identity-aware-proxy` 設定を使用して、Google Identity-Aware-Proxy を使い `Bearer token` でバックエンド API をクエリする方法を示しています:


```yaml
endpoints:
  - name: with-custom-iap
    url: "https://my.iap.protected.app/health"
    client:
      identity-aware-proxy:
        audience: "XXXXXXXX-XXXXXXXXXXXX.apps.googleusercontent.com"
    conditions:
      - "[STATUS] == 200"
```
> 📝 Gatusはトークンを生成するために、その環境内で[gcloudのデフォルト認証情報](https://cloud.google.com/docs/authentication/application-default-credentials)を使用することに注意してください。

この例では、`client.tls`設定を使用してバックエンドAPIに対してmTLSクエリを実行する方法を示します：


```yaml
endpoints:
  - name: website
    url: "https://your.mtls.protected.app/health"
    client:
      tls:
        certificate-file: /path/to/user_cert.pem
        private-key-file: /path/to/user_key.pem
        renegotiation: once
    conditions:
      - "[STATUS] == 200"
```
> 📝 コンテナ内で実行する場合は、証明書とキーをコンテナにボリュームマウントする必要があることに注意してください。

### アラート
GatusはSlackやPagerDutyなど複数のアラートプロバイダーをサポートしており、各エンドポイントごとに異なるアラートを
説明や閾値を設定して構成できます。

アラートはエンドポイントレベルで以下のように設定します:

| パラメーター                     | 説明                                                                          | デフォルト       |
|:-------------------------------|:-----------------------------------------------------------------------------|:----------------|
| `alerts`                       | 指定したエンドポイントのすべてのアラートのリスト。                            | `[]`            |
| `alerts[].type`                | アラートの種類。<br />有効な種類は下記の表を参照してください。                 | 必須 `""`       |
| `alerts[].enabled`             | アラートを有効にするかどうか。                                                | `true`          |
| `alerts[].failure-threshold`   | アラートを発動するまでに連続して必要な失敗回数。                              | `3`             |
| `alerts[].success-threshold`   | 連続成功回数。これにより進行中のインシデントが解決済みとしてマークされる。      | `2`             |
| `alerts[].send-on-resolved`    | 発動したアラートが解決済みとしてマークされた際に通知を送るかどうか。            | `false`         |
| `alerts[].description`         | アラートの説明。送信されるアラートに含まれます。                              | `""`            |
| `alerts[].provider-override`   | 指定されたアラートタイプのアラートプロバイダー設定のオーバーライド。            | `{}`            |

以下はエンドポイントレベルでのアラート設定の例です:

```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
        description: "healthcheck failed"
        send-on-resolved: true
```
グローバルプロバイダー設定は、`alerts[].provider-override`を使用して上書きすることもできます。例えば次のように:

```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
        provider-override:
          webhook-url: "https://hooks.slack.com/services/**********/**********/**********"
```
> 📝 アラートプロバイダーが正しく構成されていない場合、そのプロバイダーのタイプで設定されたすべてのアラートは
> 無視されます。

| パラメーター                  | 説明                                                                                                                               | デフォルト |
|:---------------------------|:----------------------------------------------------------------------------------------------------------------------------------|:----------|
| `alerting.awsses`          | `awsses`タイプのアラートの設定。 <br />[AWS SESアラートの設定](#configuring-aws-ses-alerts) を参照してください。               | `{}`      |
| `alerting.custom`          | 失敗時やアラート時のカスタムアクションの設定。 <br />[カスタムアラートの設定](#configuring-custom-alerts) を参照してください。   | `{}`      |
| `alerting.discord`         | `discord`タイプのアラートの設定。 <br />[Discordアラートの設定](#configuring-discord-alerts) を参照してください。              | `{}`      |
| `alerting.email`           | `email`タイプのアラートの設定。 <br />[Emailアラートの設定](#configuring-email-alerts) を参照してください。                    | `{}`      |
| `alerting.gitea`           | `gitea`タイプのアラートの設定。 <br />[Giteaアラートの設定](#configuring-gitea-alerts) を参照してください。                    | `{}`      |
| `alerting.github`          | `github`タイプのアラートの設定。 <br />[GitHubアラートの設定](#configuring-github-alerts) を参照してください。                 | `{}`      |
| `alerting.gitlab`          | `gitlab`タイプのアラートの設定。 <br />[GitLabアラートの設定](#configuring-gitlab-alerts) を参照してください。                 | `{}`      |
| `alerting.googlechat`      | `googlechat`タイプのアラートの設定。 <br />[Google Chatアラートの設定](#configuring-google-chat-alerts) を参照してください。 | `{}`      |
| `alerting.gotify`          | `gotify`タイプのアラートの設定。 <br />[Gotifyアラートの設定](#configuring-gotify-alerts) を参照してください。                 | `{}`      |
| `alerting.ilert`           | `ilert`タイプのアラートの設定。 <br />[ilertアラートの設定](#configuring-ilert-alerts) を参照してください。                   | `{}`      |
| `alerting.incident-io`     | `incident-io`タイプのアラートの設定。 <br />[Incident.ioアラートの設定](#configuring-incidentio-alerts) を参照してください。  | `{}`      |
| `alerting.jetbrainsspace`  | `jetbrainsspace`タイプのアラートの設定。 <br />[JetBrains Spaceアラートの設定](#configuring-jetbrains-space-alerts) を参照してください。 | `{}`      |
| `alerting.matrix`          | `matrix`タイプのアラートの設定。 <br />[Matrixアラートの設定](#configuring-matrix-alerts) を参照してください。               | `{}`      |
| `alerting.mattermost`      | `mattermost`タイプのアラートの設定。 <br />[Mattermostアラートの設定](#configuring-mattermost-alerts) を参照してください。   | `{}`      |
| `alerting.messagebird`     | `messagebird`タイプのアラートの設定。 <br />[Messagebirdアラートの設定](#configuring-messagebird-alerts) を参照してください。 | `{}`      |
| `alerting.ntfy`            | `ntfy`タイプのアラートの設定。 <br />[Ntfyアラートの設定](#configuring-ntfy-alerts) を参照してください。                     | `{}`      |
| `alerting.opsgenie`        | `opsgenie`タイプのアラートの設定。 <br />[Opsgenieアラートの設定](#configuring-opsgenie-alerts) を参照してください。           | `{}`      |
| `alerting.pagerduty`       | `pagerduty`タイプのアラートの設定。 <br />[PagerDutyアラートの設定](#configuring-pagerduty-alerts) を参照してください。         | `{}`      |
| `alerting.pushover`        | `pushover`タイプのアラートの設定。 <br />[Pushoverアラートの設定](#configuring-pushover-alerts) を参照してください。           | `{}`      |
| `alerting.slack`           | `slack`タイプのアラートの設定。 <br />[Slackアラートの設定](#configuring-slack-alerts) を参照してください。                  | `{}`      |
| `alerting.teams`           | `teams`タイプのアラートの設定。*(非推奨)* <br />[Teamsアラートの設定](#configuring-teams-alerts-deprecated) を参照してください。 | `{}`      |
| `alerting.teams-workflows` | `teams-workflows`タイプのアラートの設定。 <br />[Teams Workflowアラートの設定](#configuring-teams-workflow-alerts) を参照してください。 | `{}`      |
| `alerting.telegram`        | `telegram`タイプのアラートの設定。 <br />[Telegramアラートの設定](#configuring-telegram-alerts) を参照してください。           | `{}`      |
| `alerting.twilio`          | `twilio`タイプのアラートの設定。 <br />[Twilioアラートの設定](#configuring-twilio-alerts) を参照してください。                | `{}`      |
| `alerting.zulip`           | `zulip`タイプのアラートの設定。 <br />[Zulipアラートの設定](#configuring-zulip-alerts) を参照してください。                    | `{}`      |
| `alerting.homeassistant`   | `homeassistant`タイプのアラートの設定。 <br />[HomeAssistantアラートの設定](#configuring-homeassistant-alerts) を参照してください。 | `{}`      |


#### AWS SESアラートの設定
| パラメーター                            | 説明                                                                                      | デフォルト     |
|:-------------------------------------|:-----------------------------------------------------------------------------------------|:--------------|
| `alerting.aws-ses`                   | `aws-ses`タイプのアラートの設定                                                           | `{}`          |
| `alerting.aws-ses.access-key-id`     | AWSアクセスキーID                                                                          | 任意 `""`     |
| `alerting.aws-ses.secret-access-key` | AWSシークレットアクセスキー                                                                | 任意 `""`     |
| `alerting.aws-ses.region`            | AWSリージョン                                                                             | 必須 `""`     |
| `alerting.aws-ses.from`              | メール送信元のメールアドレス（SESに登録されている必要があります）                         | 必須 `""`     |
| `alerting.aws-ses.to`                | 通知先メールアドレスのカンマ区切りリスト                                                | 必須 `""`     |
| `alerting.aws-ses.default-alert`     | デフォルトのアラート設定。 <br />[デフォルトアラートの設定](#setting-a-default-alert) を参照してください。 | N/A           |


```yaml
alerting:
  aws-ses:
    access-key-id: "..."
    secret-access-key: "..."
    region: "us-east-1"
    from: "status@example.com"
    to: "user@example.com"

endpoints:
  - name: website
    interval: 30s
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: aws-ses
        failure-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```
`access-key-id` と `secret-access-key` が定義されていない場合、Gatus は IAM 認証にフォールバックします。

`ses:SendEmail` を使用できることを確認してください。


#### Discord アラートの設定
| パラメーター                         | 説明                                                                                      | デフォルト                          |
|:-------------------------------------|:------------------------------------------------------------------------------------------|:-----------------------------------|
| `alerting.discord`                   | `discord` タイプのアラート設定                                                            | `{}`                               |
| `alerting.discord.webhook-url`       | Discord の Webhook URL                                                                     | 必須 `""`                         |
| `alerting.discord.title`             | 通知のタイトル                                                                             | `":helmet_with_white_cross: Gatus"` |
| `alerting.discord.default-alert`     | デフォルトのアラート設定。<br />詳細は [デフォルトアラートの設定](#setting-a-default-alert) を参照 | N/A                                |
| `alerting.discord.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                             | `[]`                               |
| `alerting.discord.overrides[].group` | この設定によってオーバーライドされるエンドポイントグループ                               | `""`                               |
| `alerting.discord.overrides[].*`     | `alerting.discord.*` パラメーターを参照                                                  | `{}`                               |


```yaml
alerting:
  discord:
    webhook-url: "https://discord.com/api/webhooks/**********/**********"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: discord
        description: "healthcheck failed"
        send-on-resolved: true
```
#### メールアラートの設定
| パラメータ                          | 説明                                                                                         | デフォルト   |
|:-----------------------------------|:----------------------------------------------------------------------------------------------|:------------|
| `alerting.email`                   | `email`タイプのアラートの設定                                                                | `{}`        |
| `alerting.email.from`              | アラート送信用のメールアドレス                                                                | 必須 `""`   |
| `alerting.email.username`          | アラート送信に使用するSMTPサーバーのユーザー名。空の場合は`alerting.email.from`を使用。      | `""`        |
| `alerting.email.password`          | アラート送信に使用するSMTPサーバーのパスワード。空の場合は認証を行わない。                    | `""`        |
| `alerting.email.host`              | メールサーバーのホスト名（例：`smtp.gmail.com`）                                             | 必須 `""`   |
| `alerting.email.port`              | メールサーバーがリッスンしているポート（例：`587`）                                         | 必須 `0`    |
| `alerting.email.to`                | アラートを送信するメールアドレス（複数可）                                                    | 必須 `""`   |
| `alerting.email.default-alert`     | デフォルトのアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照  | N/A         |
| `alerting.email.client.insecure`   | TLS検証をスキップするかどうか                                                               | `false`     |
| `alerting.email.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                               | `[]`        |
| `alerting.email.overrides[].group` | この設定によってオーバーライドされるエンドポイントグループ                                 | `""`        |
| `alerting.email.overrides[].*`     | `alerting.email.*`パラメータを参照                                                         | `{}`        |



```yaml
alerting:
  email:
    from: "from@example.com"
    username: "from@example.com"
    password: "hunter2"
    host: "mail.example.com"
    port: 587
    to: "recipient1@example.com,recipient2@example.com"
    client:
      insecure: false
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "core"
        to: "recipient3@example.com,recipient4@example.com"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: email
        description: "healthcheck failed"
        send-on-resolved: true

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: email
        description: "healthcheck failed"
        send-on-resolved: true
```
> ⚠ 一部のメールサーバーは非常に遅い場合があります。

#### Giteaアラートの設定

| パラメーター                       | 説明                                                                                                    | デフォルト       |
|:--------------------------------|:-------------------------------------------------------------------------------------------------------|:--------------|
| `alerting.gitea`                | `gitea`タイプのアラートの設定                                                                           | `{}`          |
| `alerting.gitea.repository-url` | GiteaリポジトリのURL（例：`https://gitea.com/TwiN/example`）                                           | 必須 `""`     |
| `alerting.gitea.token`          | 認証に使用するパーソナルアクセストークン。<br />issuesに対してはRW以上、metadataに対してはRO以上が必要。 | 必須 `""`     |
| `alerting.github.default-alert` | デフォルトのアラート設定。<br />詳細は[デフォルトアラートの設定](#setting-a-default-alert)を参照。      | N/A           |

Giteaアラートプロバイダーは、各アラートごとに`alert(gatus):`で始まりエンドポイントの表示名で終わるissueを作成します。  
エンドポイントのアラートで`send-on-resolved`が`true`に設定されている場合、アラートが解決すると自動的にissueが閉じられます。



```yaml
alerting:
  gitea:
    repository-url: "https://gitea.com/TwiN/test"
    token: "349d63f16......"

endpoints:
  - name: example
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 75"
    alerts:
      - type: gitea
        failure-threshold: 2
        success-threshold: 3
        send-on-resolved: true
        description: "Everything's burning AAAAAHHHHHHHHHHHHHHH"
```
![Gitea alert](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gitea-alerts.png)

#### GitHubアラートの設定

| パラメータ                        | 説明                                                                                                      | デフォルト       |
|:---------------------------------|:---------------------------------------------------------------------------------------------------------|:--------------|
| `alerting.github`                | `github`タイプのアラートの設定                                                                             | `{}`          |
| `alerting.github.repository-url` | GitHubリポジトリのURL（例: `https://github.com/TwiN/example`）                                            | 必須 `""`     |
| `alerting.github.token`          | 認証に使用するパーソナルアクセストークン。<br />issuesに対して最低RW、metadataに対してROの権限が必要。      | 必須 `""`     |
| `alerting.github.default-alert`  | デフォルトのアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照。               | N/A           |

GitHubアラートプロバイダーは、各アラートに対して`alert(gatus):`で始まりエンドポイントの表示名で終わるissueを作成します。  
エンドポイントアラートで`send-on-resolved`が`true`に設定されている場合、アラートが解決されるとissueは自動的に閉じられます。



```yaml
alerting:
  github:
    repository-url: "https://github.com/TwiN/test"
    token: "github_pat_12345..."

endpoints:
  - name: example
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 75"
    alerts:
      - type: github
        failure-threshold: 2
        success-threshold: 3
        send-on-resolved: true
        description: "Everything's burning AAAAAHHHHHHHHHHHHHHH"
```
![GitHub alert](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/github-alerts.png)

#### GitLabアラートの設定
| パラメーター                         | 説明                                                                                                               | デフォルト       |
|:------------------------------------|:------------------------------------------------------------------------------------------------------------------|:----------------|
| `alerting.gitlab`                   | `gitlab`タイプのアラートの設定                                                                                      | `{}`            |
| `alerting.gitlab.webhook-url`       | GitLabアラートのWebhook URL（例: `https://gitlab.com/yourusername/example/alerts/notify/gatus/xxxxxxxxxxxxxxxx.json`） | 必須 `""`       |
| `alerting.gitlab.authorization-key` | GitLabアラートの認証キー。                                                                                           | 必須 `""`       |
| `alerting.gitlab.severity`          | デフォルトの重大度（critical）を上書き可能。`critical, high, medium, low, info, unknown` のいずれか。               | `""`            |
| `alerting.gitlab.monitoring-tool`   | 監視ツール名（gatus）を上書き。                                                                                      | `"gatus"`       |
| `alerting.gitlab.environment-name`  | GitLab環境の名前を設定。ダッシュボードにアラートを表示するには必須。                                                | `""`            |
| `alerting.gitlab.service`           | エンドポイント表示名を上書き。                                                                                        | `""`            |
| `alerting.gitlab.default-alert`     | デフォルトアラートの設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照。                        | 該当なし         |

GitLabアラートプロバイダーは、各アラートに対して `alert(gatus):` で始まりエンドポイントの表示名で終わるアラートを作成します。  
エンドポイントアラートで `send-on-resolved` が `true` に設定されている場合、アラートが解決されると自動的に閉じられます。  
設定方法は https://docs.gitlab.com/ee/operations/incident_management/integrations.html#configuration を参照してください。



```yaml
alerting:
  gitlab:
    webhook-url: "https://gitlab.com/hlidotbe/example/alerts/notify/gatus/xxxxxxxxxxxxxxxx.json"
    authorization-key: "12345"

endpoints:
  - name: example
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 75"
    alerts:
      - type: gitlab
        failure-threshold: 2
        success-threshold: 3
        send-on-resolved: true
        description: "Everything's burning AAAAAHHHHHHHHHHHHHHH"
```
![GitLab alert](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gitlab-alerts.png)


#### Google Chatアラートの設定
| パラメータ                               | 説明                                                                                       | デフォルト       |
|:----------------------------------------|:--------------------------------------------------------------------------------------------|:--------------|
| `alerting.googlechat`                   | `googlechat`タイプのアラートの設定                                                        | `{}`          |
| `alerting.googlechat.webhook-url`       | Google ChatのWebhook URL                                                                   | 必須 `""`     |
| `alerting.googlechat.client`            | クライアント設定。 <br />[クライアント設定](#client-configuration)を参照。                  | `{}`          |
| `alerting.googlechat.default-alert`     | デフォルトアラート設定。 <br />[デフォルトアラートの設定](#setting-a-default-alert)を参照。 | N/A           |
| `alerting.googlechat.overrides`         | デフォルト設定より優先される場合があるオーバーライドのリスト                               | `[]`          |
| `alerting.googlechat.overrides[].group` | この設定によって上書きされるエンドポイントグループ                                        | `""`          |
| `alerting.googlechat.overrides[].*`     | `alerting.googlechat.*`パラメータを参照                                                   | `{}`          |


```yaml
alerting:
  googlechat:
    webhook-url: "https://chat.googleapis.com/v1/spaces/*******/messages?key=**********&token=********"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: googlechat
        description: "healthcheck failed"
        send-on-resolved: true
```
#### Gotifyアラートの設定
| パラメーター                                     | 説明                                                                                      | デフォルト               |
|:----------------------------------------------|:-----------------------------------------------------------------------------------------|:----------------------|
| `alerting.gotify`                             | `gotify`タイプのアラートの設定                                                           | `{}`                  |
| `alerting.gotify.server-url`                  | GotifyサーバーのURL                                                                        | 必須 `""`              |
| `alerting.gotify.token`                       | 認証に使用されるトークン                                                                   | 必須 `""`              |
| `alerting.gotify.priority`                    | Gotify基準に基づくアラートの優先度                                                        | `5`                   |
| `alerting.gotify.title`                       | 通知のタイトル                                                                            | `"Gatus: <endpoint>"` |
| `alerting.gotify.default-alert`               | デフォルトアラートの設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照 | N/A                   |

#### ilertアラートの設定
| パラメーター                              | 説明                                                                                      | デフォルト |
|:---------------------------------------|:-----------------------------------------------------------------------------------------|:--------|
| `alerting.ilert`                   | `ilert`タイプのアラートの設定                                                          | `{}`    |
| `alerting.ilert.integration-key`   | ilertアラートソースの統合キー                                                           | `""`    |
| `alerting.ilert.default-alert`     | デフォルトアラートの設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照 | N/A     |
| `alerting.ilert.overrides`         | デフォルト設定より優先される可能性があるオーバーライドのリスト                           | `[]`    |
| `alerting.ilert.overrides[].group` | この設定で上書きされるエンドポイントグループ                                           | `""`    |
| `alerting.ilert.overrides[].*`     | `alerting.ilert.*`のパラメーターを参照                                                  | `{}`    |

`ilert`タイプのアラートについては、`endpoints[].alerts[].send-on-resolved`を`true`に設定することを強く推奨します。  
他のアラートとは異なり、このパラメーターを`true`に設定した場合、別のアラートは作成されず、  
代わりにilert上でアラートが解決済みとしてマークされます。

動作:
- デフォルトでは、`alerting.ilert.integration-key`が統合キーとして使用されます
- 評価対象のエンドポイントが`alerting.ilert.overrides[].group`の値と一致するグループ（`endpoints[].group`）に属している場合、  
  プロバイダーは`alerting.ilert.integration-key`の代わりに該当オーバーライドの統合キーを使用します



```yaml
alerting:
  ilert:
    integration-key: "********************************"
    # You can also add group-specific integration keys, which will
    # override the integration key above for the specified groups
    overrides:
      - group: "core"
        integration-key: "********************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: ilert
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```

```yaml
alerting:
  gotify:
    server-url: "https://gotify.example"
    token: "**************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: gotify
        description: "healthcheck failed"
        send-on-resolved: true
```


通知の例は以下の通りです：

![Gotifyの通知](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gotify-alerts.png)


#### HomeAssistantアラートの設定
HomeAssistantアラートを設定するには、設定ファイルに以下を追加する必要があります：


```yaml
alerting:
  homeassistant:
    url: "http://homeassistant:8123"  # URL of your HomeAssistant instance
    token: "YOUR_LONG_LIVED_ACCESS_TOKEN"  # Long-lived access token from HomeAssistant

endpoints:
  - name: my-service
    url: "https://my-service.com"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: homeassistant
        enabled: true
        send-on-resolved: true
        description: "My service health check"
        failure-threshold: 3
        success-threshold: 2
```


アラートは `gatus_alert` イベントタイプとして HomeAssistant にイベントとして送信されます。イベントデータには以下が含まれます：
- `status`: 「triggered」または「resolved」
- `endpoint`: 監視対象のエンドポイント名
- `description`: 提供されていればアラートの説明
- `conditions`: 条件とその結果のリスト
- `failure_count`: 連続失敗回数（トリガー時）
- `success_count`: 連続成功回数（解決時）

これらのイベントは HomeAssistant のオートメーションで以下に利用可能です：
- 通知の送信
- デバイスの制御
- シーンのトリガー
- 履歴へのログ記録
- その他多数

HomeAssistant オートメーションの例：


```yaml
automation:
  - alias: "Gatus Alert Handler"
    trigger:
      platform: event
      event_type: gatus_alert
    action:
      - service: notify.notify
        data_template:
          title: "Gatus Alert: {{ trigger.event.data.endpoint }}"
          message: >
            Status: {{ trigger.event.data.status }}
            {% if trigger.event.data.description %}
            Description: {{ trigger.event.data.description }}
            {% endif %}
            {% for condition in trigger.event.data.conditions %}
            {{ '✅' if condition.success else '❌' }} {{ condition.condition }}
            {% endfor %}
```
ホームアシスタントの長期間有効なアクセストークンを取得するには：
1. HomeAssistantを開く
2. プロフィール名をクリック（左下）
3. 「長期間有効なアクセストークン」までスクロール
4. 「トークンを作成」をクリック
5. 名前を付ける（例：「Gatus」）
6. トークンをコピー - 一度しか表示されません！


#### Incident.ioアラートの設定
| パラメーター                             | 説明                                                                                      | デフォルト     |
|:-----------------------------------------|:-------------------------------------------------------------------------------------------|:--------------|
| `alerting.incident-io`                   | `incident-io`タイプのアラート設定                                                         | `{}`          |
| `alerting.incident-io.url`               | アラートイベントをトリガーするURL                                                         | 必須 `""`     |
| `alerting.incident-io.auth-token`        | 認証に使用されるトークン                                                                   | 必須 `""`     |
| `alerting.incident-io.source-url`        | ソースURL                                                                                | `""`          |
| `alerting.incident-io.default-alert`     | デフォルトのアラート設定。 <br />[デフォルトアラートの設定](#setting-a-default-alert)を参照 | N/A           |
| `alerting.incident-io.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                            | `[]`          |
| `alerting.incident-io.overrides[].group` | この設定で上書きされるエンドポイントグループ                                            | `""`          |
| `alerting.incident-io.overrides[].*`     | `alerting.incident-io.*`パラメーターを参照                                               | `{}`          |


```yaml
alerting:
  incident-io:
    url: "*****************"
    auth-token: "********************************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: incident-io
        description: "healthcheck failed"
        send-on-resolved: true
```

必要なアラートソースの設定IDと認証トークンを取得するには、HTTPアラートソースを設定する必要があります。

> **_注意:_** ソース設定IDは `https://api.incident.io/v2/alert_events/http/$ID` の形式であり、トークンは以下のようにベアラートークンとして渡されることが期待されます：`Authorization: Bearer $TOKEN`


#### JetBrains Space アラートの設定
| パラメータ                                   | 説明                                                                                      | デフォルト       |
|:--------------------------------------------|:------------------------------------------------------------------------------------------|:----------------|
| `alerting.jetbrainsspace`                   | `jetbrainsspace` タイプのアラートの設定                                                  | `{}`            |
| `alerting.jetbrainsspace.project`           | JetBrains Space プロジェクト名                                                            | 必須 `""`       |
| `alerting.jetbrainsspace.channel-id`        | JetBrains Space チャットチャンネルID                                                     | 必須 `""`       |
| `alerting.jetbrainsspace.token`             | 認証に使用されるトークン                                                                   | 必須 `""`       |
| `alerting.jetbrainsspace.default-alert`     | デフォルトのアラート設定。<br />詳細は [デフォルトアラートの設定](#setting-a-default-alert) を参照 | 該当なし           |
| `alerting.jetbrainsspace.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                            | `[]`            |
| `alerting.jetbrainsspace.overrides[].group` | この設定により上書きされるエンドポイントグループ                                        | `""`            |
| `alerting.jetbrainsspace.overrides[].*`     | `alerting.jetbrainsspace.*` パラメータを参照                                            | `{}`            |


```yaml
alerting:
  jetbrainsspace:
    project: myproject
    channel-id: ABCDE12345
    token: "**************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: jetbrainsspace
        description: "healthcheck failed"
        send-on-resolved: true
```
Here's an example of what the notifications look like:

![JetBrains Space notifications](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/jetbrains-space-alerts.png)


#### Matrixアラートの設定
| パラメーター                                | 説明                                                                                          | デフォルト                          |
|:-----------------------------------------|:---------------------------------------------------------------------------------------------|:-----------------------------------|
| `alerting.matrix`                        | `matrix`タイプのアラートの設定                                                                | `{}`                               |
| `alerting.matrix.server-url`             | ホームサーバーのURL                                                                           | `https://matrix-client.matrix.org` |
| `alerting.matrix.access-token`           | ボットユーザーのアクセストークン（https://webapps.stackexchange.com/q/131056 を参照）          | 必須 `""`                         |
| `alerting.matrix.internal-room-id`       | アラート送信用の内部ルームID（ルーム設定 > 詳細設定で確認可能）                                | 必須 `""`                         |
| `alerting.matrix.default-alert`          | デフォルトのアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert) を参照    | 該当なし                          |


```yaml
alerting:
  matrix:
    server-url: "https://matrix-client.matrix.org"
    access-token: "123456"
    internal-room-id: "!example:matrix.org"

endpoints:
  - name: website
    interval: 5m
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: matrix
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Mattermostアラートの設定
| パラメータ                                     | 説明                                                                                       | デフォルト     |
|:----------------------------------------------|:--------------------------------------------------------------------------------------------|:--------------|
| `alerting.mattermost`                         | `mattermost`タイプのアラート設定                                                           | `{}`          |
| `alerting.mattermost.webhook-url`             | MattermostのWebhook URL                                                                     | 必須 `""`     |
| `alerting.mattermost.channel`                 | Mattermostチャネル名の上書き（オプション）                                                 | `""`          |
| `alerting.mattermost.client`                  | クライアント設定。<br />[クライアント設定](#client-configuration)を参照。                  | `{}`          |
| `alerting.mattermost.default-alert`           | デフォルトアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照。 | N/A           |
| `alerting.mattermost.overrides`               | デフォルト設定より優先される可能性のあるオーバーライドのリスト                             | `[]`          |
| `alerting.mattermost.overrides[].group`       | この設定で上書きされるエンドポイントグループ                                             | `""`          |
| `alerting.mattermost.overrides[].*`           | `alerting.mattermost.*`パラメータを参照                                                   | `{}`          |



```yaml
alerting:
  mattermost:
    webhook-url: "http://**********/hooks/**********"
    client:
      insecure: true

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: mattermost
        description: "healthcheck failed"
        send-on-resolved: true
```
以下は通知の例です：

![Mattermost notifications](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/mattermost-alerts.png)


#### Messagebirdアラートの設定
| パラメーター                         | 説明                                                                                      | デフォルト     |
|:-------------------------------------|:-------------------------------------------------------------------------------------------|:--------------|
| `alerting.messagebird`               | `messagebird`タイプのアラートの設定                                                        | `{}`          |
| `alerting.messagebird.access-key`    | Messagebirdアクセスキー                                                                    | 必須 `""`     |
| `alerting.messagebird.originator`    | メッセージの送信者                                                                         | 必須 `""`     |
| `alerting.messagebird.recipients`    | メッセージの受信者                                                                         | 必須 `""`     |
| `alerting.messagebird.default-alert` | デフォルトのアラート設定。 <br />詳細は[デフォルトアラートの設定](#setting-a-default-alert) | なし           |

Messagebirdを使用した**SMS**テキストメッセージアラートの例：

```yaml
alerting:
  messagebird:
    access-key: "..."
    originator: "31619191918"
    recipients: "31619191919,31619191920"

endpoints:
  - name: website
    interval: 5m
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: messagebird
        failure-threshold: 3
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Ntfyアラートの設定
| パラメータ                             | 説明                                                                                                                                        | デフォルト       |
|:-------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------|:----------------|
| `alerting.ntfy`                      | `ntfy`タイプのアラート設定                                                                                                                  | `{}`            |
| `alerting.ntfy.topic`                | アラートが送信されるトピック                                                                                                                | 必須 `""`       |
| `alerting.ntfy.url`                  | 対象サーバーのURL                                                                                                                           | `https://ntfy.sh` |
| `alerting.ntfy.token`                | 制限付きトピック用の[アクセストークン](https://docs.ntfy.sh/publish/#access-tokens)                                                          | `""`            |
| `alerting.ntfy.email`                | 追加のメール通知用メールアドレス                                                                                                            | `""`            |
| `alerting.ntfy.click`                | 通知がクリックされた時に開くウェブサイト                                                                                                    | `""`            |
| `alerting.ntfy.priority`             | アラートの優先度                                                                                                                             | `3`             |
| `alerting.ntfy.disable-firebase`     | firebase経由のメッセージプッシュ配信を無効にするか。[ntfy.shはデフォルトで有効](https://docs.ntfy.sh/publish/#disable-firebase)               | `false`         |
| `alerting.ntfy.disable-cache`        | サーバー側のメッセージキャッシュを無効にするか。[ntfy.shはデフォルトで有効](https://docs.ntfy.sh/publish/#message-caching)                   | `false`         |
| `alerting.ntfy.default-alert`        | デフォルトのアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照                                                  | N/A             |
| `alerting.ntfy.overrides`            | デフォルト設定より優先される可能性のある上書き設定のリスト                                                                                   | `[]`            |
| `alerting.ntfy.overrides[].group`    | この設定によって上書きされるエンドポイントグループ                                                                                          | `""`            |
| `alerting.ntfy.overrides[].*`        | `alerting.ntfy.*`パラメータを参照                                                                                                           | `{}`            |

[ntfy](https://github.com/binwiederhier/ntfy)は、デスクトップおよびモバイル通知の購読を可能にする素晴らしいプロジェクトであり、Gatusにとって素晴らしい追加機能です。

例：



```yaml
alerting:
  ntfy:
    topic: "gatus-test-topic"
    priority: 2
    token: faketoken
    default-alert:
      failure-threshold: 3
      send-on-resolved: true
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "other"
        topic: "gatus-other-test-topic"
        priority: 4
        click: "https://example.com"

endpoints:
  - name: website
    interval: 5m
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: ntfy
  - name: other example
    group: other
    interval: 30m
    url: "https://example.com"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
    alerts:
      - type: ntfy
        description: example
```
#### Opsgenieアラートの設定
| パラメーター                     | 説明                                                                                      | デフォルト            |
|:--------------------------------|:------------------------------------------------------------------------------------------|:----------------------|
| `alerting.opsgenie`             | `opsgenie`タイプのアラート設定                                                           | `{}`                  |
| `alerting.opsgenie.api-key`     | Opsgenie APIキー                                                                          | 必須 `""`             |
| `alerting.opsgenie.priority`    | アラートの優先度レベル                                                                    | `P1`                  |
| `alerting.opsgenie.source`      | アラートのソースフィールド                                                                | `gatus`               |
| `alerting.opsgenie.entity-prefix` | エンティティフィールドの接頭辞                                                           | `gatus-`              |
| `alerting.opsgenie.alias-prefix`  | エイリアスフィールドの接頭辞                                                             | `gatus-healthcheck-`  |
| `alerting.opsgenie.tags`        | アラートのタグ                                                                            | `[]`                  |
| `alerting.opsgenie.default-alert` | デフォルトアラート設定 <br />[デフォルトアラートの設定](#setting-a-default-alert)を参照  | なし                  |

Opsgenieプロバイダーはアラートの自動オープンとクローズを行います。



```yaml
alerting:
  opsgenie:
    api-key: "00000000-0000-0000-0000-000000000000"
```
#### PagerDutyアラートの設定
| パラメータ                            | 説明                                                                                   | デフォルト |
|:-------------------------------------|:---------------------------------------------------------------------------------------|:----------|
| `alerting.pagerduty`                 | `pagerduty`タイプのアラートの設定                                                        | `{}`      |
| `alerting.pagerduty.integration-key` | PagerDuty Events API v2の統合キー                                                        | `""`      |
| `alerting.pagerduty.default-alert`   | デフォルトのアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照  | N/A       |
| `alerting.pagerduty.overrides`       | デフォルト設定より優先される可能性のあるオーバーライドのリスト                             | `[]`      |
| `alerting.pagerduty.overrides[].group` | この設定によりオーバーライドされるエンドポイントグループ                                  | `""`      |
| `alerting.pagerduty.overrides[].*`   | `alerting.pagerduty.*`パラメータを参照                                                  | `{}`      |

`pagerduty`タイプのアラートには、`endpoints[].alerts[].send-on-resolved`を`true`に設定することを強く推奨します。  
これは他のアラートとは異なり、このパラメータを`true`に設定した場合の操作は別のインシデントを作成せず、  
PagerDuty上のインシデントを解決済みとしてマークするためです。

動作:
- デフォルトでは、`alerting.pagerduty.integration-key`が統合キーとして使用されます
- 評価対象のエンドポイントが`endpoints[].group`に属し、`alerting.pagerduty.overrides[].group`の値と一致する場合は、  
  プロバイダーは`alerting.pagerduty.integration-key`の代わりにそのオーバーライドの統合キーを使用します



```yaml
alerting:
  pagerduty:
    integration-key: "********************************"
    # You can also add group-specific integration keys, which will
    # override the integration key above for the specified groups
    overrides:
      - group: "core"
        integration-key: "********************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: pagerduty
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: pagerduty
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Pushoverアラートの設定
| パラメーター                             | 説明                                                                                                      | デフォルト                   |
|:--------------------------------------|:---------------------------------------------------------------------------------------------------------|:----------------------------|
| `alerting.pushover`                   | `pushover`タイプのアラートの設定                                                                           | `{}`                        |
| `alerting.pushover.application-token` | Pushoverアプリケーショントークン                                                                           | `""`                        |
| `alerting.pushover.user-key`          | ユーザーまたはグループキー                                                                                 | `""`                        |
| `alerting.pushover.title`             | Pushover経由で送信されるすべてのメッセージの固定タイトル                                                  | `"Gatus: <endpoint>"`       |
| `alerting.pushover.priority`          | すべてのメッセージの優先度、-2（非常に低い）から2（緊急）まで                                              | `0`                         |
| `alerting.pushover.resolved-priority` | 解決済みメッセージの優先度を上書き、-2（非常に低い）から2（緊急）まで                                      | `0`                         |
| `alerting.pushover.sound`             | すべてのメッセージのサウンド<br />有効な選択肢は[sounds](https://pushover.net/api#sounds)を参照してください。 | `""`                        |
| `alerting.pushover.ttl`               | メッセージのTime-to-liveを設定し、Pushover通知から自動的に削除される時間                                   | `0`                         |
| `alerting.pushover.device`            | メッセージを送信するデバイス（オプション）<br/>詳細は[devices](https://pushover.net/api#identifiers)を参照 | `""`（全デバイス）           |
| `alerting.pushover.default-alert`     | デフォルトのアラート設定。 <br />[デフォルトアラートの設定](#setting-a-default-alert)を参照                  | N/A                         |



```yaml
alerting:
  pushover:
    application-token: "******************************"
    user-key: "******************************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: pushover
        failure-threshold: 3
        success-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Slackアラートの設定
| パラメーター                       | 説明                                                                                      | デフォルト     |
|:-----------------------------------|:------------------------------------------------------------------------------------------|:--------------|
| `alerting.slack`                   | `slack`タイプのアラートの設定                                                            | `{}`          |
| `alerting.slack.webhook-url`       | SlackのWebhook URL                                                                        | 必須 `""`     |
| `alerting.slack.default-alert`     | デフォルトのアラート設定。<br />詳細は[デフォルトアラートの設定](#setting-a-default-alert)参照 | N/A           |
| `alerting.slack.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                            | `[]`          |
| `alerting.slack.overrides[].group` | この設定によってオーバーライドされるエンドポイントグループ                               | `""`          |
| `alerting.slack.overrides[].*`     | `alerting.slack.*`パラメーターを参照                                                    | `{}`          |



```yaml
alerting:
  slack:
    webhook-url: "https://hooks.slack.com/services/**********/**********/**********"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: slack
        description: "healthcheck failed 3 times in a row"
        send-on-resolved: true
      - type: slack
        failure-threshold: 5
        description: "healthcheck failed 5 times in a row"
        send-on-resolved: true
```
以下は通知の例です:

![Slack notifications](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/slack-alerts.png)


#### Teams アラートの設定 *(非推奨)*

> [!CAUTION]
> **非推奨:** Microsoft Teams 内の Office 365 コネクタは廃止予定です ([出典: Microsoft DevBlog](https://devblogs.microsoft.com/microsoft365dev/retirement-of-office-365-connectors-within-microsoft-teams/))。
> 既存のコネクタは2025年12月まで動作します。このレガシー設定の代わりに Microsoft Workflows と共に新しい [Teams ワークフローアラート](#configuring-teams-workflow-alerts) を使用してください。

| パラメータ                          | 説明                                                                                       | デフォルト           |
|:-----------------------------------|:-------------------------------------------------------------------------------------------|:--------------------|
| `alerting.teams`                   | `teams` タイプのアラートの設定                                                             | `{}`                |
| `alerting.teams.webhook-url`       | Teams の Webhook URL                                                                        | 必須 `""`           |
| `alerting.teams.default-alert`     | デフォルトのアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert) を参照 | N/A                 |
| `alerting.teams.title`             | 通知のタイトル                                                                             | `"&#x1F6A8; Gatus"` |
| `alerting.teams.client.insecure`   | TLS 検証をスキップするかどうか                                                              | `false`             |
| `alerting.teams.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                               | `[]`                |
| `alerting.teams.overrides[].group` | この設定で上書きされるエンドポイントグループ                                               | `""`                |
| `alerting.teams.overrides[].*`     | `alerting.teams.*` パラメータを参照                                                       | `{}`                |


```yaml
alerting:
  teams:
    webhook-url: "https://********.webhook.office.com/webhookb2/************"
    client:
      insecure: false
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "core"
        webhook-url: "https://********.webhook.office.com/webhookb3/************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: teams
        description: "healthcheck failed"
        send-on-resolved: true

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: teams
        description: "healthcheck failed"
        send-on-resolved: true
```
以下は通知の例です：

![Teams通知](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/teams-alerts.png)

#### Teams Workflowアラートの設定

> [!注意]
> このアラートはMicrosoft TeamsのWorkflowsと互換性があります。ワークフローの設定とWebhook URLの取得については、[Microsoftドキュメント](https://support.microsoft.com/en-us/office/create-incoming-webhooks-with-workflows-for-microsoft-teams-8ae491c7-0394-4861-ba59-055e33f75498)をご参照ください。

| パラメーター                                | 説明                                                                                     | デフォルト          |
|:-------------------------------------------|:-----------------------------------------------------------------------------------------|:-------------------|
| `alerting.teams-workflows`                  | `teams`タイプのアラートの設定                                                             | `{}`               |
| `alerting.teams-workflows.webhook-url`      | TeamsのWebhook URL                                                                        | 必須 `""`          |
| `alerting.teams-workflows.title`            | 通知のタイトル                                                                            | `"&#x26D1; Gatus"` |
| `alerting.teams-workflows.default-alert`    | デフォルトアラート設定。<br />詳細は[デフォルトアラートの設定](#setting-a-default-alert)参照 | なし                |
| `alerting.teams-workflows.overrides`        | デフォルト設定より優先される可能性のある上書き設定のリスト                                | `[]`               |
| `alerting.teams-workflows.overrides[].group`| この設定により上書きされるエンドポイントグループ                                        | `""`               |
| `alerting.teams-workflows.overrides[].*`    | `alerting.teams-workflows.*`パラメーターを参照                                           | `{}`               |


```yaml
alerting:
  teams-workflows:
    webhook-url: "https://********.webhook.office.com/webhookb2/************"
    # You can also add group-specific to keys, which will
    # override the to key above for the specified groups
    overrides:
      - group: "core"
        webhook-url: "https://********.webhook.office.com/webhookb3/************"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: teams-workflows
        description: "healthcheck failed"
        send-on-resolved: true

  - name: back-end
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[CERTIFICATE_EXPIRATION] > 48h"
    alerts:
      - type: teams-workflows
        description: "healthcheck failed"
        send-on-resolved: true
```
Here's an example of what the notifications look like:

![Teams Workflow notifications](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/teams-workflows-alerts.png)


#### Telegramアラートの設定
| パラメーター                         | 説明                                                                                      | デフォルト                  |
|:--------------------------------------|:-------------------------------------------------------------------------------------------|:---------------------------|
| `alerting.telegram`                   | `telegram`タイプのアラートの設定                                                         | `{}`                       |
| `alerting.telegram.token`             | Telegramボットトークン                                                                     | 必須 `""`                  |
| `alerting.telegram.id`                | TelegramユーザーID                                                                        | 必須 `""`                  |
| `alerting.telegram.topic-id`          | グループ内のTelegramトピックIDはTelegram APIの`message_thread_id`に対応                   | `""`                       |    
| `alerting.telegram.api-url`           | Telegram APIのURL                                                                         | `https://api.telegram.org` |
| `alerting.telegram.client`            | クライアント設定。<br />[クライアント設定](#client-configuration)を参照                   | `{}`                       |
| `alerting.telegram.default-alert`     | デフォルトのアラート設定。<br />[デフォルトアラートの設定](#setting-a-default-alert)を参照 | N/A                        |
| `alerting.telegram.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                           | `[]`                       |
| `alerting.telegram.overrides[].group` | この設定で上書きされるエンドポイントグループ                                            | `""`                       |
| `alerting.telegram.overrides[].*`     | `alerting.telegram.*`パラメーターを参照                                                 | `{}`                       |


```yaml
alerting:
  telegram:
    token: "123456:ABC-DEF1234ghIkl-zyx57W2v1u123ew11"
    id: "0123456789"
    topic-id: "7"

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
    alerts:
      - type: telegram
        send-on-resolved: true
```
以下は通知の例です：

![Telegram notifications](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/telegram-alerts.png)


#### Twilioアラートの設定
| パラメータ                       | 説明                                                                                      | デフォルト   |
|:--------------------------------|:------------------------------------------------------------------------------------------|:------------|
| `alerting.twilio`               | `twilio`タイプのアラート設定                                                              | `{}`        |
| `alerting.twilio.sid`           | TwilioアカウントSID                                                                        | 必須 `""`   |
| `alerting.twilio.token`         | Twilio認証トークン                                                                         | 必須 `""`   |
| `alerting.twilio.from`          | Twilioアラート送信元の番号                                                                 | 必須 `""`   |
| `alerting.twilio.to`            | Twilioアラート送信先の番号                                                                 | 必須 `""`   |
| `alerting.twilio.default-alert` | デフォルトのアラート設定。 <br />詳細は[デフォルトアラートの設定](#setting-a-default-alert)参照 | なし         |


```yaml
alerting:
  twilio:
    sid: "..."
    token: "..."
    from: "+1-234-567-8901"
    to: "+1-234-567-8901"

endpoints:
  - name: website
    interval: 30s
    url: "https://twin.sh/health"
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: twilio
        failure-threshold: 5
        send-on-resolved: true
        description: "healthcheck failed"
```
#### Zulipアラートの設定
| パラメータ                          | 説明                                                                                 | デフォルト    |
|:-----------------------------------|:------------------------------------------------------------------------------------|:--------------|
| `alerting.zulip`                   | `discord`タイプのアラート設定                                                        | `{}`          |
| `alerting.zulip.bot-email`         | ボットのメールアドレス                                                               | 必須 `""`     |
| `alerting.zulip.bot-api-key`       | ボットのAPIキー                                                                      | 必須 `""`     |
| `alerting.zulip.domain`            | 組織の完全ドメイン名（例：yourZulipDomain.zulipchat.com）                            | 必須 `""`     |
| `alerting.zulip.channel-id`        | Gatusがアラートを送信するチャンネルID                                               | 必須 `""`     |
| `alerting.zulip.overrides`         | デフォルト設定より優先される可能性のあるオーバーライドのリスト                       | `[]`          |
| `alerting.zulip.overrides[].group` | この設定でオーバーライドされるエンドポイントグループ                               | `""`          |
| `alerting.zulip.overrides[].*`     | `alerting.zulip.*`パラメータを参照                                                 | `{}`          |



```yaml
alerting:
  zulip:
    bot-email: gatus-bot@some.zulip.org
    bot-api-key: "********************************"
    domain: some.zulip.org
    channel-id: 123456

endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: zulip
        description: "healthcheck failed"
        send-on-resolved: true
```
#### カスタムアラートの設定
| パラメータ                      | 説明                                                                                      | デフォルト     |
|:--------------------------------|:-------------------------------------------------------------------------------------------|:--------------|
| `alerting.custom`               | 失敗時やアラート時のカスタムアクションの設定                                               | `{}`          |
| `alerting.custom.url`           | カスタムアラートリクエストのURL                                                           | 必須 `""`     |
| `alerting.custom.method`        | リクエストメソッド                                                                         | `GET`         |
| `alerting.custom.body`          | カスタムアラートリクエストボディ                                                           | `""`          |
| `alerting.custom.headers`       | カスタムアラートリクエストヘッダー                                                         | `{}`          |
| `alerting.custom.client`        | クライアント設定。 <br />[クライアント設定](#client-configuration) を参照してください。     | `{}`          |
| `alerting.custom.default-alert` | デフォルトアラート設定。 <br />[デフォルトアラートの設定](#setting-a-default-alert) を参照 | N/A           |

アラートと呼ばれていますが、この機能を使って何でも呼び出すことができます。

例えば、新しいデプロイを追跡するアプリケーションを自動化し、Gatusを利用してエンドポイントが失敗し始めた際にそのアプリケーションのエンドポイントを呼び出すことができます。  
アプリケーションは失敗し始めたエンドポイントが最近デプロイされたアプリケーションの一部かどうかを確認し、そうであれば自動的にロールバックします。

さらに、以下のプレースホルダーをボディ（`alerting.custom.body`）とURL（`alerting.custom.url`）で使用できます：
- `[ALERT_DESCRIPTION]` (`endpoints[].alerts[].description`から解決)
- `[ENDPOINT_NAME]` (`endpoints[].name`から解決)
- `[ENDPOINT_GROUP]` (`endpoints[].group`から解決)
- `[ENDPOINT_URL]` (`endpoints[].url`から解決)
- `[RESULT_ERRORS]` (特定のヘルスチェックのヘルス評価から解決)

`custom` プロバイダーで `send-on-resolved` を `true` に設定したアラートがある場合は、  
通知を区別するために `[ALERT_TRIGGERED_OR_RESOLVED]` プレースホルダーを使うことができます。  
このプレースホルダーは状況に応じて `TRIGGERED` または `RESOLVED` に置き換えられますが、  
（詳細はこのセクションの最後を参照）変更することも可能です。

実際のところ、ここではSlackのWebhookでカスタムアラートを設定しますが、呼び出す先は何でも構いません。




```yaml
alerting:
  custom:
    url: "https://hooks.slack.com/services/**********/**********/**********"
    method: "POST"
    body: |
      {
        "text": "[ALERT_TRIGGERED_OR_RESOLVED]: [ENDPOINT_GROUP] - [ENDPOINT_NAME] - [ALERT_DESCRIPTION] - [RESULT_ERRORS]"
      }
endpoints:
  - name: website
    url: "https://twin.sh/health"
    interval: 30s
    conditions:
      - "[STATUS] == 200"
      - "[BODY].status == UP"
      - "[RESPONSE_TIME] < 300"
    alerts:
      - type: custom
        failure-threshold: 10
        success-threshold: 3
        send-on-resolved: true
        description: "health check failed"
```


`[ALERT_TRIGGERED_OR_RESOLVED]` プレースホルダーの解決済み値は、次のようにカスタマイズできることに注意してください：

```yaml
alerting:
  custom:
    placeholders:
      ALERT_TRIGGERED_OR_RESOLVED:
        TRIGGERED: "partial_outage"
        RESOLVED: "operational"
```
As a result, the `[ALERT_TRIGGERED_OR_RESOLVED]` in the body of first example of this section would be replaced by
`partial_outage` when an alert is triggered and `operational` when an alert is resolved.


#### デフォルトアラートの設定
| パラメータ                                    | 説明                                                                          | デフォルト |
|:---------------------------------------------|:------------------------------------------------------------------------------|:--------|
| `alerting.*.default-alert.enabled`           | アラートを有効にするかどうか                                                 | 該当なし  |
| `alerting.*.default-alert.failure-threshold` | アラートをトリガーする前に連続して必要な失敗回数                              | 該当なし  |
| `alerting.*.default-alert.success-threshold` | 進行中のインシデントが解決済みとマークされる前の連続成功回数                  | 該当なし  |
| `alerting.*.default-alert.send-on-resolved`  | トリガーされたアラートが解決済みとマークされたときに通知を送信するかどうか    | 該当なし  |
| `alerting.*.default-alert.description`       | アラートの説明。送信されるアラートに含まれます                              | 該当なし  |

> ⚠ プロバイダーのデフォルトアラートを設定している場合でも、エンドポイント設定でアラートの `type` を指定する必要があります。

エンドポイント定義で直接アラート設定を指定することもできますが、面倒で非常に長い設定ファイルになる可能性があります。

そのような問題を避けるために、各プロバイダー設定に存在する `default-alert` パラメータを使用できます:

```yaml
alerting:
  slack:
    webhook-url: "https://hooks.slack.com/services/**********/**********/**********"
    default-alert:
      description: "health check failed"
      send-on-resolved: true
      failure-threshold: 5
      success-threshold: 5
```


その結果、あなたのGatusの設定はずっと整然と見えます：

```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack

  - name: other-example
    url: "https://example.com"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
```
これにより、次のようなことも可能になります：


```yaml
endpoints:
  - name: example
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
        failure-threshold: 5
      - type: slack
        failure-threshold: 10
      - type: slack
        failure-threshold: 15
```
もちろん、アラートタイプを混在させることもできます：


```yaml
alerting:
  slack:
    webhook-url: "https://hooks.slack.com/services/**********/**********/**********"
    default-alert:
      failure-threshold: 3
  pagerduty:
    integration-key: "********************************"
    default-alert:
      failure-threshold: 5

endpoints:
  - name: endpoint-1
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
      - type: pagerduty

  - name: endpoint-2
    url: "https://example.org"
    conditions:
      - "[STATUS] == 200"
    alerts:
      - type: slack
      - type: pagerduty
```
### メンテナンス
メンテナンスウィンドウがある場合、アラートに煩わされたくないかもしれません。
そのためには、メンテナンス設定を使用する必要があります：

| パラメーター               | 説明                                                                                                                                                                                       | デフォルト     |
|:--------------------------|:-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------|
| `maintenance.enabled`     | メンテナンス期間が有効かどうか                                                                                                                                                            | `true`        |
| `maintenance.start`       | メンテナンスウィンドウの開始時間（`hh:mm`形式、例：`23:00`）                                                                                                                               | 必須 `""`     |
| `maintenance.duration`    | メンテナンスウィンドウの期間（例：`1h`、`30m`）                                                                                                                                           | 必須 `""`     |
| `maintenance.timezone`    | メンテナンスウィンドウのタイムゾーン（例：`Europe/Amsterdam`）。<br />詳細は[tzデータベースのタイムゾーン一覧](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)を参照             | `UTC`         |
| `maintenance.every`       | メンテナンス期間が適用される曜日（例：`[Monday, Thursday]`）。<br />空の場合、メンテナンスウィンドウは毎日適用されます                                                                   | `[]`          |

例を示します：


```yaml
maintenance:
  start: 23:00
  duration: 1h
  timezone: "Europe/Amsterdam"
  every: [Monday, Thursday]
```
それぞれの日を別々の行に指定することもできることに注意してください:
```yaml
maintenance:
  start: 23:00
  duration: 1h
  timezone: "Europe/Amsterdam"
  every:
    - Monday
    - Thursday
```
エンドポイントごとにメンテナンスウィンドウを指定することもできます：
```yaml
endpoints:
  - name: endpoint-1
    url: "https://example.org"
    maintenance-windows:
      - start: "07:30"
        duration: 40m
        timezone: "Europe/Berlin"
      - start: "14:30"
        duration: 1h
        timezone: "Europe/Berlin"
```
### セキュリティ
| パラメータ           | 説明                         | デフォルト |
|:---------------------|:-----------------------------|:----------|
| `security`           | セキュリティ設定             | `{}`      |
| `security.basic`     | HTTP Basic 設定              | `{}`      |
| `security.oidc`      | OpenID Connect 設定          | `{}`      |


#### ベーシック認証
| パラメータ                               | 説明                                                                             | デフォルト       |
|:----------------------------------------|:---------------------------------------------------------------------------------|:----------------|
| `security.basic`                        | HTTP Basic 設定                                                                  | `{}`            |
| `security.basic.username`               | ベーシック認証用のユーザー名                                                     | 必須 `""`       |
| `security.basic.password-bcrypt-base64` | Bcryptでハッシュ化し、base64でエンコードしたベーシック認証用のパスワード           | 必須 `""`       |

以下の例では、ユーザー名 `john.doe` とパスワード `hunter2` で認証を要求します:


```yaml
security:
  basic:
    username: "john.doe"
    password-bcrypt-base64: "JDJhJDEwJHRiMnRFakxWazZLdXBzRERQazB1TE8vckRLY05Yb1hSdnoxWU0yQ1FaYXZRSW1McmladDYu"
```
> ⚠ bcryptハッシュのコストは慎重に選択してください。コストが高いほどハッシュの計算に時間がかかり、
> ベーシック認証は毎回のリクエストでパスワードをハッシュと照合します。2023-01-06時点で、コストは9を推奨します。


#### OIDC
| パラメーター                      | 説明                                                         | デフォルト      |
|:---------------------------------|:-------------------------------------------------------------|:--------------|
| `security.oidc`                  | OpenID Connectの設定                                         | `{}`          |
| `security.oidc.issuer-url`       | 発行者URL                                                   | 必須 `""`     |
| `security.oidc.redirect-url`     | リダイレクトURL。必ず`/authorization-code/callback`で終わること | 必須 `""`     |
| `security.oidc.client-id`        | クライアントID                                              | 必須 `""`     |
| `security.oidc.client-secret`    | クライアントシークレット                                    | 必須 `""`     |
| `security.oidc.scopes`           | リクエストするスコープ。必要なのは`openid`のみです。          | 必須 `[]`     |
| `security.oidc.allowed-subjects` | 許可するサブジェクトのリスト。空の場合は全てのサブジェクトを許可 | `[]`          |


```yaml
security:
  oidc:
    issuer-url: "https://example.okta.com"
    redirect-url: "https://status.example.com/authorization-code/callback"
    client-id: "123456789"
    client-secret: "abcdefghijk"
    scopes: ["openid"]
    # You may optionally specify a list of allowed subjects. If this is not specified, all subjects will be allowed.
    #allowed-subjects: ["johndoe@example.com"]
```
混乱していますか？[Auth0を使ったOIDCによるGatusのセキュリティ強化](https://twin.sh/articles/56/securing-gatus-with-oidc-using-auth0)をお読みください。


### TLS暗号化
GatusはTLSによる基本的な暗号化をサポートしています。これを有効にするには、PEM形式の証明書ファイルを提供する必要があります。

以下の例は、Gatusがポート4443でHTTPSリクエストに応答する設定例を示しています：

```yaml
web:
  port: 4443
  tls:
    certificate-file: "certificate.crt"
    private-key-file: "private.key"
```
### メトリクス
メトリクスを有効にするには、`metrics` を `true` に設定する必要があります。これにより、Prometheus対応のメトリクスがアプリケーションが実行されている同じポートの `/metrics` エンドポイントに公開されます（`web.port`）。

| メトリクス名                                  | 種類    | 説明                                                                      | ラベル                          | 関連エンドポイントタイプ   |
|:---------------------------------------------|:--------|:---------------------------------------------------------------------------|:--------------------------------|:------------------------|
| gatus_results_total                          | counter | エンドポイントごとの成功状態別の結果数                                   | key, group, name, type, success | 全て                     |
| gatus_results_code_total                     | counter | コード別の結果の合計数                                                     | key, group, name, type, code    | DNS, HTTP               |
| gatus_results_connected_total                | counter | 接続が正常に確立された結果の合計数                                         | key, group, name, type          | 全て                     |
| gatus_results_duration_seconds               | gauge   | リクエストの所要時間（秒）                                                 | key, group, name, type          | 全て                     |
| gatus_results_certificate_expiration_seconds | gauge   | 証明書が失効するまでの秒数                                                 | key, group, name, type          | HTTP, STARTTLS          |
| gatus_results_endpoint_success               | gauge   | エンドポイントの成功状態を表示（0=失敗、1=成功）                          | key, group, name, type          | 全て                     |

詳細なドキュメントや例は[examples/docker-compose-grafana-prometheus](.examples/docker-compose-grafana-prometheus) を参照してください。


### 接続性
| パラメーター                     | 説明                                      | デフォルト     |
|:--------------------------------|:-----------------------------------------|:--------------|
| `connectivity`                  | 接続性の設定                             | `{}`          |
| `connectivity.checker`          | 接続性チェッカーの設定                   | 必須 `{}`     |
| `connectivity.checker.target`   | 接続性の検証に使用するホスト             | 必須 `""`     |
| `connectivity.checker.interval` | 接続性を検証する間隔                     | `1m`          |

Gatusは他のサービスを監視するために使用されますが、Gatus自身がインターネット接続を失う可能性があります。  
Gatus自身が不健康な場合にエンドポイントを不健康と報告しないように、Gatusが定期的にインターネット接続をチェックするよう設定できます。

接続チェッカーが接続がダウンしていると判断している間は、すべてのエンドポイント実行がスキップされます。





```yaml
connectivity:
  checker:
    target: 1.1.1.1:53
    interval: 60s
```
### リモートインスタンス（実験的機能）
この機能は、リモートのGatusインスタンスからエンドポイントの状態を取得することを可能にします。

主な使用例は次の2つです：
- 複数のGatusインスタンスが異なるマシンで稼働しており、単一のダッシュボードで状態を視覚的に表示したい場合
- 1つ以上のGatusインスタンスが公開されていない（例：ファイアウォールの背後にある）場合に状態を取得したい場合

これは実験的な機能です。いつでも削除または破壊的に更新される可能性があります。さらに、
この機能には既知の問題があります。フィードバックがある場合は、[#64](https://github.com/TwiN/gatus/issues/64)にコメントをお願いします。
自己責任でご利用ください。

| パラメーター                          | 説明                                        | デフォルト     |
|:-----------------------------------|:---------------------------------------------|:--------------|
| `remote`                           | リモート設定                               | `{}`          |
| `remote.instances`                 | リモートインスタンスのリスト               | 必須 `[]`     |
| `remote.instances.endpoint-prefix` | すべてのエンドポイント名に付ける接頭辞    | `""`          |
| `remote.instances.url`             | エンドポイントの状態を取得するURL          | 必須 `""`     |



```yaml
remote:
  instances:
    - endpoint-prefix: "status.example.org-"
      url: "https://status.example.org/api/v1/endpoints/statuses"
```
## デプロイメント
多くの例は[.examples](.examples)フォルダにありますが、このセクションではGatusをデプロイする最も一般的な方法に焦点を当てます。


### Docker
DockerでGatusをローカルで実行するには：


```console
docker run -p 8080:8080 --name gatus twinproduction/gatus
```


[.examples](.examples)フォルダーにある例のいずれかを使用する以外に、
設定ファイルを作成してローカルで試すこともできます。ここでは例として`config.yaml`と呼び、
次のコマンドを実行します：

```console
docker run -p 8080:8080 --mount type=bind,source="$(pwd)"/config.yaml,target=/config/config.yaml --name gatus twinproduction/gatus
```


Windowsを使用している場合は、`"$(pwd)"` を現在のディレクトリの絶対パスに置き換えてください。例：

```console
docker run -p 8080:8080 --mount type=bind,source=C:/Users/Chris/Desktop/config.yaml,target=/config/config.yaml --name gatus twinproduction/gatus
```
ローカルでイメージをビルドするには：

```console
docker build . -t twinproduction/gatus
```



### Helm チャート
チャートを使用するには[Helm](https://helm.sh)をインストールする必要があります。
開始するにはHelmの[ドキュメント](https://helm.sh/docs/)を参照してください。

Helmが適切に設定されたら、リポジトリを次のように追加します：


```console
helm repo add twin https://twin.github.io/helm-charts
helm repo update
helm install gatus twin/gatus
```


詳細については、[チャートの設定](https://github.com/TwiN/helm-charts/blob/master/charts/gatus/README.md)をご確認ください。


### Terraform
Gatusは以下のモジュールを使用してTerraform上にデプロイできます: [terraform-kubernetes-gatus](https://github.com/TwiN/terraform-kubernetes-gatus).


## テストの実行

```console
go test -v ./...
```



## 本番環境での使用
[Deployment](#deployment) セクションを参照してください。


## FAQ
### GraphQLリクエストの送信
`endpoints[].graphql` を true に設定すると、ボディは自動的に標準の GraphQL `query` パラメータでラップされます。

例えば、以下の設定：

```yaml
endpoints:
  - name: filter-users-by-gender
    url: http://localhost:8080/playground
    method: POST
    graphql: true
    body: |
      {
        users(gender: "female") {
          id
          name
          gender
          avatar
        }
      }
    conditions:
      - "[STATUS] == 200"
      - "[BODY].data.users[0].gender == female"
```
`http://localhost:8080/playground` に対して、以下の内容の `POST` リクエストを送信します:

```json
{"query":"      {\n        users(gender: \"female\") {\n          id\n          name\n          gender\n          avatar\n        }\n      }"}
```
### 推奨間隔
> 📝 `disable-monitoring-lock` が `true` に設定されている場合は適用されません。監視ロックは
> Gatusに一度に一つのエンドポイントのみ評価させる役割を果たします。

Gatusが信頼性の高い正確な結果（例えば応答時間）を提供するために、Gatusは一度に一つのエンドポイントのみ評価します。
言い換えれば、同じ間隔で複数のエンドポイントがあっても、それらは同時に実行されません。

非常に短く非現実的な間隔（例：1ms）で複数のエンドポイントを設定してGatusを実行すれば、
応答時間が変動しないことに気づくでしょう。これはエンドポイントは異なるゴルーチンで評価されますが、
複数のエンドポイントが同時に実行されるのを防ぐグローバルロックが存在するためです。

残念ながら欠点もあります。多数のエンドポイントがあり、その中に非常に遅いかタイムアウトしやすいものがある場合
（デフォルトのタイムアウトは10秒）、リクエストの全期間中、他のエンドポイントは評価できません。

間隔にはリクエスト自体の時間は含まれないため、エンドポイントの間隔が30秒で
リクエストに2秒かかる場合、2回の評価間のタイムスタンプは30秒ではなく32秒になります。

これはGatusが他のすべてのエンドポイントのヘルスチェックを実行するのを妨げるものではありませんが、
設定した間隔を守れない可能性があります。例えば：
- エンドポイントAは間隔5秒、タイムアウトは10秒
- エンドポイントBは間隔5秒、完了に1ms
- エンドポイントBは5秒毎に実行できません。なぜならエンドポイントAの評価に間隔より長い時間がかかるためです

まとめると、Gatusはどんな間隔も処理可能ですが、遅いリクエストは
より長い間隔を設定した方が良いでしょう。

経験則として、私は複雑なヘルスチェックの間隔を `5m`（5分）に、
アラート用（PagerDuty/Twilio）の簡単なヘルスチェックを `30s` に設定しています。


### デフォルトのタイムアウト
| エンドポイントタイプ | タイムアウト |
|:---------------------|:------------|
| HTTP                 | 10秒        |
| TCP                  | 10秒        |
| ICMP                 | 10秒        |

タイムアウトを変更するには、[クライアント設定](#client-configuration)を参照してください。


### TCPエンドポイントの監視
`endpoints[].url` に `tcp://` をプレフィックスとして付けることで、非常に基本的なレベルでTCPエンドポイントを監視できます：


```yaml
endpoints:
  - name: redis
    url: "tcp://127.0.0.1:6379"
    interval: 30s
    conditions:
      - "[CONNECTED] == true"
```

`endpoints[].body` が設定されている場合、それが送信され、レスポンスの最初の1024バイトが `[BODY]` に含まれます。

プレースホルダー `[STATUS]` およびフィールド `endpoints[].headers`、
`endpoints[].method`、`endpoints[].graphql` は TCP エンドポイントではサポートされていません。

これは、データベース（Postgres、MySQL など）やキャッシュ（Redis、Memcached など）などのアプリケーションで機能します。

> 📝 `[CONNECTED] == true` はエンドポイント自体が正常であることを保証するものではありません - これは
> 指定されたアドレスに何かが指定されたポートで待ち受けており、そのアドレスへの接続が正常に確立されたことのみを保証します。


### UDP エンドポイントの監視
`endpoints[].url` に `udp://` をプレフィックスとして付けることで、UDP エンドポイントを非常に基本的なレベルで監視できます：


```yaml
endpoints:
  - name: example
    url: "udp://example.org:80"
    conditions:
      - "[CONNECTED] == true"
```
`endpoints[].body` が設定されている場合、それが送信され、レスポンスの最初の1024バイトが `[BODY]` に含まれます。

プレースホルダー `[STATUS]` およびフィールド `endpoints[].headers`、
`endpoints[].method`、`endpoints[].graphql` はUDPエンドポイントではサポートされていません。

これはUDPベースのアプリケーションで動作します。


### SCTPエンドポイントの監視
`endpoints[].url` に `sctp://` をプレフィックスとして付けることで、非常に基本的なレベルでストリーム制御伝送プロトコル（SCTP）エンドポイントを監視できます：

```yaml
endpoints:
  - name: example
    url: "sctp://127.0.0.1:38412"
    conditions:
      - "[CONNECTED] == true"
```


プレースホルダー `[STATUS]` および `[BODY]` と、フィールド `endpoints[].body`、`endpoints[].headers`、  
`endpoints[].method` および `endpoints[].graphql` は SCTP エンドポイントではサポートされていません。  

これは SCTP ベースのアプリケーションで動作します。  


### WebSocket エンドポイントの監視  
`endpoints[].url` の先頭に `ws://` または `wss://` を付けることで、非常に基本的なレベルで WebSocket エンドポイントを監視できます：


```yaml
endpoints:
  - name: example
    url: "wss://example.com/"
    body: "status"
    conditions:
      - "[CONNECTED] == true"
      - "[BODY].result >= 0"
```
`[BODY]` プレースホルダーにはクエリの出力が含まれ、`[CONNECTED]`  
は接続が正常に確立されたかどうかを示します。Goのテンプレート  
構文を使用できます。LocalAddr関数や長さを指定したRandomString関数が使えます。  


### ICMPを使ったエンドポイントの監視  
`endpoints[].url` の先頭に `icmp://` を付けることで、ICMPを使って非常に基本的なレベルでエンドポイントを監視できます。  
これは一般に「ping」や「エコー」として知られています：

```yaml
endpoints:
  - name: ping-example
    url: "icmp://example.com"
    conditions:
      - "[CONNECTED] == true"
```


ICMPタイプのエンドポイントでは、プレースホルダー `[CONNECTED]`、`[IP]`、および `[RESPONSE_TIME]` のみがサポートされています。  
`icmp://` を前置したドメイン名、または `icmp://` を前置したIPアドレスを指定できます。  

Linux上でGatusを実行する場合は、問題が発生した際に https://github.com/prometheus-community/pro-bing#linux のLinuxセクションをお読みください。  


### DNSクエリを使用したエンドポイントの監視  
エンドポイントに `dns` 設定を定義すると、そのエンドポイントは自動的にDNSタイプのエンドポイントとしてマークされます：


```yaml
endpoints:
  - name: example-dns-query
    url: "8.8.8.8" # Address of the DNS server to use
    dns:
      query-name: "example.com"
      query-type: "A"
    conditions:
      - "[BODY] == 93.184.215.14"
      - "[DNS_RCODE] == NOERROR"
```


DNSタイプのエンドポイントの条件で使用できるプレースホルダーが2つあります：
- プレースホルダー`[BODY]`はクエリの出力に解決されます。例えば、タイプ`A`のクエリはIPv4を返します。
- プレースホルダー`[DNS_RCODE]`はクエリが返すレスポンスコードに関連付けられた名前に解決されます。例として
`NOERROR`、`FORMERR`、`SERVFAIL`、`NXDOMAIN`などがあります。


### SSHを使ったエンドポイントの監視
`endpoints[].url`の先頭に`ssh://`を付けることで、SSHを使ったエンドポイントの監視が可能です：

```yaml
endpoints:
  - name: ssh-example
    url: "ssh://example.com:22" # port is optional. Default is 22.
    ssh:
      username: "username"
      password: "password"
    body: |
      {
        "command": "uptime"
      }
    interval: 1m
    conditions:
      - "[CONNECTED] == true"
      - "[STATUS] == 0"
```


ユーザー名とパスワードのフィールドを指定しないことで、
認証なしでエンドポイントを監視することもできます。


```yaml
endpoints:
  - name: ssh-example
    url: "ssh://example.com:22" # port is optional. Default is 22.
    ssh:
      username: ""
      password: ""

    interval: 1m
    conditions:
      - "[CONNECTED] == true"
      - "[STATUS] == 0"
```


SSHタイプのエンドポイントに対して以下のプレースホルダーがサポートされています：
- `[CONNECTED]` はSSH接続が成功した場合に`true`、それ以外は`false`に解決されます
- `[STATUS]` はリモートサーバーで実行されたコマンドの終了コードに解決されます（例：成功の場合は`0`）


### STARTTLSを使用したエンドポイントの監視
問題がないことを確認したいメールサーバーがある場合、STARTTLSによる監視は
良い初期指標として機能します：


```yaml
endpoints:
  - name: starttls-smtp-example
    url: "starttls://smtp.gmail.com:587"
    interval: 30m
    client:
      timeout: 5s
    conditions:
      - "[CONNECTED] == true"
      - "[CERTIFICATE_EXPIRATION] > 48h"
```
### TLSを使用したエンドポイントの監視
LDAP over TLSのようなSSL/TLS暗号化を使用したエンドポイントの監視は、証明書の有効期限切れを検出するのに役立ちます:


```yaml
endpoints:
  - name: tls-ldaps-example
    url: "tls://ldap.example.com:636"
    interval: 30m
    client:
      timeout: 5s
    conditions:
      - "[CONNECTED] == true"
      - "[CERTIFICATE_EXPIRATION] > 48h"
```


`endpoints[].body` が設定されている場合、それが送信され、レスポンスの最初の1024バイトが `[BODY]` に含まれます。

プレースホルダー `[STATUS]` およびフィールド `endpoints[].headers`、
`endpoints[].method`、`endpoints[].graphql` は TLS エンドポイントではサポートされていません。


### ドメインの有効期限の監視
DNS を除くすべてのエンドポイントタイプで、`[DOMAIN_EXPIRATION]`
プレースホルダーを使用してドメインの有効期限を監視できます：


```yaml
endpoints:
  - name: check-domain-and-certificate-expiration
    url: "https://example.org"
    interval: 1h
    conditions:
      - "[DOMAIN_EXPIRATION] > 720h"
      - "[CERTIFICATE_EXPIRATION] > 240h"
```
> ⚠ `[DOMAIN_EXPIRATION]` プレースホルダーの使用には、Gatus が公式の IANA WHOIS サービスへ[ライブラリ経由で](https://github.com/TwiN/whois)リクエストを送信する必要があります。  
> また場合によっては、TLD 固有の WHOIS サーバー（例：`whois.nic.sh`）への二次的なリクエストも行われます。  
> WHOIS サービスがリクエスト過多であなたの IP アドレスを制限しないように、Gatus は  
> インターバルが `5m` 未満のエンドポイントでの `[DOMAIN_EXPIRATION]` プレースホルダーの使用を禁止します。  


### disable-monitoring-lock  
`disable-monitoring-lock` を `true` に設定すると、複数のエンドポイントを同時に監視できるようになります（すなわち並列実行）。  

この動作は一般的には問題ありませんが、`[RESPONSE_TIME]` プレースホルダーを使用する条件は  
複数のエンドポイントが同時に評価されることで影響を受ける可能性があるため、このパラメータのデフォルト値は `false` です。  

`disable-monitoring-lock` を無効にしたい主な理由は以下の3つです：  
- Gatus を負荷テストに使用している（各エンドポイントは異なるゴルーチンで定期的に評価されるため、  
技術的には1秒間隔で100個のエンドポイントを作成すると、Gatus は1秒間に100リクエストを送信します）  
- 監視対象のエンドポイントが非常に多い  
- 非常に短い間隔（< 5秒）で複数のエンドポイントをテストしたい  


### 設定ファイルの動的再読み込み  
利便性のため、Gatus は実行中に設定ファイルが更新された場合、自動的に設定を動的に再読み込みします。  

デフォルトでは、更新された設定が無効な場合、アプリケーションは終了しますが、  
`skip-invalid-config-update` を `true` に設定することで、無効な設定ファイルが更新された場合でも  
Gatus を継続して実行させることができます。  

Gatus 実行中に設定ファイルを更新した際は、ログを確認して以下のメッセージが表示されていないことを  
必ず確認し、設定ファイルの有効性を担保することが最善策であることを覚えておいてください：



```
The configuration file was updated, but it is not valid. The old configuration will continue being used.
```

アプリケーションが何らかの理由で再起動された場合、Gatusが起動できなくなる可能性があります。

このような状況を避けるために、`skip-invalid-config-update`を`true`に設定しないことをお勧めしますが、最終的な判断はあなた次第です。

**ファイルストレージを使用していない場合**、Gatusが稼働中に設定を更新することは、実質的にアプリケーションを再起動するのと同じです。

> 📝 設定ファイルがフォルダではなくバインドされている場合、更新が検出されないことがあります。詳細は[#151](https://github.com/TwiN/gatus/issues/151)をご覧ください。


### エンドポイントグループ
エンドポイントグループは、ダッシュボード上で複数のエンドポイントをまとめるために使用されます。




```yaml
endpoints:
  - name: frontend
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: backend
    group: core
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: monitoring
    group: internal
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: nas
    group: internal
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"

  - name: random endpoint that is not part of a group
    url: "https://example.org/"
    interval: 5m
    conditions:
      - "[STATUS] == 200"
```
上記の設定により、以下のようなダッシュボードが表示されます：

![Gatus Endpoint Groups](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/endpoint-groups.png)


### カスタムパスでのGatusの公開
現在、GatusのUIは `status.example.org` のような完全修飾ドメイン名（FQDN）で公開できます。ただし、パスベースのルーティングはサポートしていないため、`example.org/status/` のようなURLでの公開はできません。

詳細については https://github.com/TwiN/gatus/issues/88 を参照してください。


### カスタムポートでのGatusの公開
デフォルトでは、Gatusはポート `8080` で公開されますが、`web.port` パラメータを設定することで別のポートを指定できます：

```yaml
web:
  port: 8081
```


Herokuのようにカスタムポートの設定を許可せず、環境変数を通じてポートを公開するPaaSを使用している場合、
その環境変数を設定ファイル内で直接使用できます：

```yaml
web:
  port: ${PORT}
```
### 起動遅延の設定
何らかの理由で、アプリケーション起動時にエンドポイントの監視を開始する前に一定時間待機させたい場合は、`GATUS_DELAY_START_SECONDS` 環境変数を使用してGatusを起動時にスリープさせることができます。


### 設定ファイルを小さく保つ方法
Gatus固有ではありませんが、YAMLアンカーを活用してデフォルト設定を作成できます。
大きな設定ファイルがある場合、これにより整理がしやすくなります。

<details>
  <summary>例</summary>
</details>


```yaml
default-endpoint: &defaults
  group: core
  interval: 5m
  client:
    insecure: true
    timeout: 30s
  conditions:
    - "[STATUS] == 200"

endpoints:
  - name: anchor-example-1
    <<: *defaults               # This will merge the configuration under &defaults with this endpoint
    url: "https://example.org"

  - name: anchor-example-2
    <<: *defaults
    group: example              # This will override the group defined in &defaults
    url: "https://example.com"

  - name: anchor-example-3
    <<: *defaults
    url: "https://twin.sh/health"
    conditions:                # This will override the conditions defined in &defaults
      - "[STATUS] == 200"
      - "[BODY].status == UP"
```

</details>


### プロキシクライアントの設定
クライアントの設定で `proxy-url` パラメータを設定することで、クライアントが使用するプロキシを構成できます。


```yaml
endpoints:
  - name: website
    url: "https://twin.sh/health"
    client:
      proxy-url: http://proxy.example.com:8080
    conditions:
      - "[STATUS] == 200"
```
### 431 Request Header Fields Too Large エラーの修正方法
環境のデプロイ先や、Gatus の前に配置されているミドルウェアやリバースプロキシの種類によっては、
この問題が発生することがあります。これは、リクエストヘッダーが大きすぎる場合、例えば大きなクッキーが原因です。

デフォルトでは、`web.read-buffer-size` は `8192` に設定されていますが、次のようにこの値を増やすことで読み取りバッファサイズを増加させることができます：


```yaml
web:
  read-buffer-size: 32768
```
### バッジ
#### アップタイム
![アップタイム 1時間](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/1h/badge.svg)
![アップタイム 24時間](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/24h/badge.svg)
![アップタイム 7日間](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/7d/badge.svg)
![アップタイム 30日間](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/30d/badge.svg)

Gatusは監視しているエンドポイントのSVGバッジを自動生成できます。
これにより、個々のアプリケーションのREADMEにバッジを貼り付けたり、
必要に応じて独自のステータスページを作成したりすることが可能です。

バッジを生成するパスは以下の通りです：


```
/api/v1/endpoints/{key}/uptimes/{duration}/badge.svg
```
Where:
- `{duration}` は `30d`、`7d`、`24h` または `1h` です
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` のパターンで、両方の変数は ` `、`/`、`_`、`,`、`.`、`#` が `-` に置き換えられます

例えば、グループ `core` のエンドポイント `frontend` の過去24時間の稼働時間を取得したい場合、
URLは次のようになります:

```
https://example.com/api/v1/endpoints/core_frontend/uptimes/7d/badge.svg
```
グループに属さないエンドポイントを表示したい場合は、グループの値を空にする必要があります：
```
https://example.com/api/v1/endpoints/_frontend/uptimes/7d/badge.svg
```
例：
```
![Uptime 24h](https://status.twin.sh/api/v1/endpoints/core_blog-external/uptimes/24h/badge.svg)
```

各バッジの視覚的な例を見たい場合は、エンドポイントの詳細ページに移動するだけです。


#### ヘルス
![ヘルス](https://status.twin.sh/api/v1/endpoints/core_blog-external/health/badge.svg)

バッジを生成するパスは次のとおりです：

```
/api/v1/endpoints/{key}/health/badge.svg
```

ここで：
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` というパターンで、両方の変数は ` `、`/`、`_`、`,`、`.`、および `#` が `-` に置き換えられます。

例えば、グループ `core` のエンドポイント `frontend` の現在の状態を取得したい場合、
URL は次のようになります：

```
https://example.com/api/v1/endpoints/core_frontend/health/badge.svg
```
#### ヘルス (Shields.io)
![Health](https://img.shields.io/endpoint?url=https%3A%2F%2Fstatus.twin.sh%2Fapi%2Fv1%2Fendpoints%2Fcore_blog-external%2Fhealth%2Fbadge.shields)

バッジを生成するパスは次の通りです：


```
/api/v1/endpoints/{key}/health/badge.shields
```

場所：
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` のパターンで、両方の変数の ` `、`/`、`_`、`,`、`.`、および `#` が `-` に置き換えられています。

例えば、グループ `core` のエンドポイント `frontend` の現在のステータスを取得したい場合、
URL は次のようになります：

```
https://example.com/api/v1/endpoints/core_frontend/health/badge.shields
```

See more information about the Shields.io badge endpoint [here](https://shields.io/badges/endpoint-badge).


#### Response time
![Response time 1h](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/1h/badge.svg)
![Response time 24h](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/24h/badge.svg)
![Response time 7d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/7d/badge.svg)
![Response time 30d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/30d/badge.svg)

The endpoint to generate a badge is the following:
```
/api/v1/endpoints/{key}/response-times/{duration}/badge.svg
```
Where:
- `{duration}` は `30d`、`7d`、`24h` または `1h` です
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` のパターンで、両方の変数は ` `、`/`、`_`、`,`、`.`、`#` が `-` に置き換えられています

#### 応答時間（チャート）
![Response time 24h](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/24h/chart.svg)
![Response time 7d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/7d/chart.svg)
![Response time 30d](https://status.twin.sh/api/v1/endpoints/core_blog-external/response-times/30d/chart.svg)

応答時間チャートを生成するエンドポイントは以下の通りです：
```
/api/v1/endpoints/{key}/response-times/{duration}/chart.svg
```

次のように:
- `{duration}` は `30d`、`7d`、または `24h`
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` というパターンで、両変数の ` `、`/`、`_`、`,`、`.`、および `#` は `-` に置換されます。

##### 応答時間バッジの色の閾値を変更する方法
応答時間バッジの閾値を変更するには、対応する設定をエンドポイントに追加できます。
配列内の値はレベル [Awesome, Great, Good, Passable, Bad] に対応します。
5つの値すべてをミリ秒（ms）で指定する必要があります。


```yaml
endpoints:
- name: nas
  group: internal
  url: "https://example.org/"
  interval: 5m
  conditions:
    - "[STATUS] == 200"
  ui:
    badge:
      response-time:
        thresholds: [550, 850, 1350, 1650, 1750]
```
### API
Gatusは、エンドポイントのステータスと履歴をプログラムで判定するためにクエリ可能なシンプルな読み取り専用APIを提供します。

すべてのエンドポイントは、以下のエンドポイントへのGETリクエストで利用可能です：


```
/api/v1/endpoints/statuses
````
Example: https://status.twin.sh/api/v1/endpoints/statuses

特定のエンドポイントは、次のパターンを使用してクエリを実行することもできます:
```
/api/v1/endpoints/{group}_{endpoint}/statuses
```
Example: https://status.twin.sh/api/v1/endpoints/core_blog-home/statuses

`Accept-Encoding` HTTPヘッダーに`gzip`が含まれている場合、Gzip圧縮が使用されます。

APIは`Content-Type`レスポンスヘッダーが`application/json`に設定されたJSONペイロードを返します。
APIをクエリするためにそのようなヘッダーは必要ありません。

#### 生データ
Gatusは監視対象のエンドポイントの生データを公開します。
これにより、監視対象エンドポイントのデータを独自のアプリケーションで追跡および集計することが可能になります。例えば、7日以上の期間の稼働時間を追跡したい場合などです。

##### 稼働時間
エンドポイントの生稼働時間データを取得するパスは次のとおりです:
```
/api/v1/endpoints/{key}/uptimes/{duration}
```

ここで：
- `{duration}` は `30d`、`7d`、`24h`、または `1h` です
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` のパターンで、両方の変数内の ` `、`/`、`_`、`,`、`.`、および `#` は `-` に置き換えられます。

例えば、グループ `core` のエンドポイント `frontend` から過去24時間の生の稼働時間データを取得したい場合、URLは次のようになります：

```
https://example.com/api/v1/endpoints/core_frontend/uptimes/24h
```
##### 応答時間  
エンドポイントの生の応答時間データを取得するためのパスは次のとおりです：

```
/api/v1/endpoints/{key}/response-times/{duration}
```
Where:
- `{duration}` は `30d`、`7d`、`24h` または `1h` です
- `{key}` は `<GROUP_NAME>_<ENDPOINT_NAME>` のパターンで、両方の変数内の ` `、`/`、`_`、`,`、`.`、および `#` が `-` に置き換えられています

たとえば、グループ `core` のエンドポイント `frontend` から過去24時間の生の応答時間データを取得したい場合、URLは次のようになります：
```
https://example.com/api/v1/endpoints/core_frontend/response-times/24h
```
### バイナリとしてのインストール
次のコマンドを使用して、Gatusをバイナリとしてダウンロードできます：


```
go install github.com/TwiN/gatus/v5@latest
```


### High level design overview
![Gatus diagram](https://raw.githubusercontent.com/TwiN/gatus/master/.github/assets/gatus-diagram.jpg)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---