# janitor
## 目的
Janitorはスタンドアロンのツールで、IOTデバイスの稼働状況を監視し、デバイスが消失したりデータ送信を停止した場合に通知します。特に多数のセンサーを持ち、ハードウェアや接続が不安定な場合に有用で、問題発生時に対応を行い、デバイスの安定性を監視できます。

Janitorは追加機能の実装を目的としておらず、他のホームオートメーションソフトウェア（例：HASS）の代替ではありません。この機能に特化することで、ツールをシンプルかつ効率的に保つことが可能です。

Janitorは現在以下の監視方法をサポートしています：
* **MQTT:** Janitorは事前定義されたMQTTトピックを購読し、受信メッセージを監視します。各チャネルの平均送信頻度が計算され、この間隔内に新しいメッセージが届かない場合に通知します（しきい値は平均頻度の倍数またはトピックごとの絶対値として設定可能）。この方法はMQTTを介して定期的にデータを送信するあらゆる種類のセンサー（例：温度）に特に有効です。
* **Ping:** Janitorは事前定義されたホストに設定された頻度（ホストごとに設定可能）でpingを送り、応答がない場合に通知します（連続して応答が無いping回数のしきい値を設定可能）。この方法はセンサーやカメラなどあらゆるIOTデバイスに適しています。
* **HTTP:** Janitorは事前定義されたアドレスにHTTP GETリクエストを送信し、応答の有無および任意で応答に事前定義された文字列が含まれているかをチェックします。設定されたしきい値を超える連続失敗時に通知します。頻度とタイムアウトもアドレスごとに設定可能です。この方法はウェブインターフェイスを持つあらゆるサービス（例：API、ホスティングサービス）に適しています。
* **Exec:** Janitorは事前に設定されたコマンドを実行し、終了コードをチェックします。設定されたしきい値を超える連続失敗時に通知します。頻度とタイムアウトもコマンドごとに設定可能です。この方法でカスタム監視を実装できます。

Janitorは現在以下の通知方法をサポートしています：
* **Telegram:** Janitorは事前定義されたTelegramチャンネルにメッセージを送信します。
* **Gotify:** JanitorはGotifyにプッシュメッセージを送信します。
* **MQTT:** Janitorは事前設定されたMQTTサーバーのトピックにJSONペイロードを含むメッセージを公開します（サンプル設定を参照）。これはHASS等の自動化に適しています。
* **Exec:** Janitorは事前設定されたコマンドを実行します。これにより任意のカスタム通知方法を作成可能です。

さらに、Janitorには現在のステータスや履歴データを確認し、アイテムの削除、タイムアウト、間隔、しきい値の変更、設定ファイルのリロードを行えるウェブインターフェイスがあります（下のスクリーンショット参照）。

最後に、Janitorは以下のエンドポイントを持つシンプルなJSON APIを含みます：
* `/api/data` は監視関連すべてのデータのスナップショットを提供します。
* `/api/stats` は機能中/機能不全状態の監視対象数を提供します。
* `/api/metrics` はPrometheusメトリクス形式でターゲット統計を提供します。

## スクリーンショット
![Screenshot](https://raw.githubusercontent.com/a-bali/janitor/master/docs/screenshot.png)

## ビルドとインストール

JanitorはGoで書かれており、単一のスタンドアロンバイナリにコンパイルされます。LinuxおよびWindowsでのコンパイルと動作が可能です。

コンパイルにはGoバージョン1.16以上を使用し、以下のコマンドでリポジトリをクローンしバイナリをビルドしてください：

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ go build

これにより`janitor`という名前のスタンドアロンバイナリが作成され、任意の場所に配置できます。リリース用の事前ビルドバイナリはGithubで入手可能です。

## 設定と使用方法

設定には、YAML形式のファイルが必要です。[サンプル設定ファイル](https://raw.githubusercontent.com/a-bali/janitor/master/config.yml)を使用し、ファイル内のコメントに従って必要に応じて変更してください。ほとんどの変数はオプションであり、合理的なデフォルト値があります。詳細はコメントをご参照ください。環境変数は `$ENV_VAR` または `${ENV_VAR}` で参照でき、存在すればその値に置き換えられます（存在しない場合は空文字列になります）。

最小限で実用的な設定は以下のように短くできます（JanitorのWebインターフェースがデフォルトのポート8080で利用可能であることを想定）：

    monitor:
      mqtt:
        server: mymqtt.server
        targets:
        - topic: "/sensors/#"
    alert:
      gotify:
        server: "http://mygotify.server:1234"
        token: gotify_token

設定ファイルを作成したら、以下のようにしてJanitorを起動できます：

    $ janitor path/to/your/configfile.yml

Janitorは標準出力にログを出力します。ログはWebインターフェースでも閲覧可能で、監視対象の削除や設定ファイルのリロード（新しいターゲットを追加した場合や設定を変更した場合など）ができます。

Janitorは自身をデーモン化しません。継続的に稼働させたい場合は、systemdサービスを作成することを推奨します。

## Dockerでの実行

最新バージョンのJanitorはDocker Hubの [`abali/janitor`](https://hub.docker.com/repository/docker/abali/janitor) で利用可能です。設定ファイルを `/janitor/config.yml` にマッピングして使用してください：

    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 abali/janitor

または、提供されているDockerfileを使って自分でコンテナをビルドすることもできます：

    $ git clone https://github.com/a-bali/janitor.git
    $ cd janitor
    $ docker build . -t janitor
    $ docker run -v $(pwd)/config.yml:/janitor/config.yml -p 8080:8080 janitor

## 今後の計画と貢献について


Janitorの目的は明確かつシンプルです：IOTデバイスの稼働状況と可用性を監視し、問題があった場合に警告を出すことです。将来の改善はこの目的に沿って行われるべきであり、新たな監視方法の追加か新たな警告方法の追加に限定されます。

Janitorはオープンソースソフトウェアであり、ソフトウェアを改善するプルリクエストをGithub経由で送ることが推奨されています。

## ライセンス

JanitorはGPL 3.0のもとでライセンスされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-25

---