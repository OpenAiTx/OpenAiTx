# Action Hero

## Action Heroとは何ですか？

Action Heroは、AWSの最小権限IAMポリシー作成を支援するサイドカー形式のユーティリティです。

## なぜ必要ですか？

一般的に開発者は、管理者アクセス権を持つより許可範囲の広いロールでインフラをコード化し、迅速に反復を行います。しかし、より細かく権限を絞ったセットを作成するのは苦痛で時間がかかります。

Action Heroは、より許可範囲の広い反復中に必要なすべての権限をキャプチャする手段を提供し、必要な権限のみを持つIAMロールの作成を容易にします。

## どのように動作しますか？

Action HeroはAWS SDKのクライアントサイドモニタリング機能を使用します。この機能はAWS APIコールをローカルのUDPポート（デフォルトは31000）に送信します。

Summit Routeはこの機能についてこの[投稿](https://summitroute.com/blog/2020/05/25/client_side_monitoring/)で説明しています（このツールの着想となったものです）

## 前提条件

上記の投稿で説明されているように、``export AWS_CSM_ENABLED=true``をシェルで実行するか、SDKを使用するツールが実行されるプロファイルに設定する必要があります。例えばterraformを使う場合は、plan/applyを実行するシェルでエクスポートが必要です。

環境変数``AWS_CSM_PORT``を使用してCSMアクションが送信されるポートおよびAction Heroがリッスンするポートを上書きすることもできます。使用する場合は両方のシェルでエクスポートが必要です。

## インストール

バイナリは[リリース](https://github.com/princespaghetti/actionhero/releases)ページから入手可能です。

Dockerイメージも[docker hub](https://hub.docker.com/r/princespaghetti/actionhero)から利用できます。

## Action Heroの実行

SDKを使用している端末とは別の端末でバイナリを実行します。

``./actionhero``

またはdocker runコマンドを使用できます。

``docker run -e "IN_DOCKER=True" -p 127.0.0.1:31000:31000/udp --rm princespaghetti/actionhero:latest``

Ctrl+C はプロセスを安全に終了するために使用できます

## ウォークスルー

ツールの使用例については、この[ブログ記事](https://dev.to/prince_of_pasta/action-hero-to-the-rescue-creating-least-privilege-aws-iam-policies-53o2)をご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---