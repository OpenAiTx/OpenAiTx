# `acexy` - Goで書かれたAceStreamプロキシ！ ⚡

[![Go Build](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml/badge.svg)](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml)
[![Docker Release](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml/badge.svg?event=release)](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml)

## 目次

- [仕組みは？ 🛠](#how-it-works-)
- [主な特徴 🔗](#key-features-)
- [使い方 📐](#usage-)
- [最適化 🚀](#optimizing-)
  - [代替案 🧃](#alternative-)
- [設定オプション ⚙](#configuration-options-)

## 仕組みは？ 🛠

このプロジェクトは
[AceStreamミドルウェアHTTP API](https://docs.acestream.net/developers/start-playback/#using-middleware)のラッパーで、
[HLS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming)および
[MPEG-TS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming)のストリーム再生を可能にします。

AceStreamの制限やストリーム再生時に存在するいくつかの問題に疲れていました📽。例えば、
**1つのクライアントのみ**同じチャンネルを再生可能です。
複数のクライアントで**異なるストリーム**を再生する場合は、
クライアントごとにユニークな`pid`を手動で追加しなければなりません。
送信中にエラーが発生すると、**ストリーム全体が停止**してしまうなどです。

家庭内ネットワークで単一のサーバーと複数のクライアントを使い、
リソースを最適化しようとした際のAceStreamの使用感はかなりフラストレーションが溜まりました。
私がAceStreamを使用しているトポロジーは以下の通りです。

![AceStream Topology For My Network](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/topology.svg)

いくつかの問題があります：

* 同時に**1台のクライアント**のみ同じストリームを再生可能です🚫。
* 各クライアントがそれぞれAceStreamを動かすのはリソースの無駄であり、
  ネットワークが飽和します📉。


* 複数のクライアントは、ユニークな `pid`（プレイヤーID）が関連付けられていれば、異なるストリームを再生できます 🔓。
* 標準の AceStream HTTP API はエラーに対して十分な耐性がなく、伝送が停止するとすべてのクライアントで停止します ❌。

## 主な特徴 🔗

`acexy` を使用すると、自動的に以下が利用可能です：

* すべての AceStream ストリームを実行する単一の集中型サーバー ⛓。
* クライアントごと、ストリームごとにユニークな `pid`（プレイヤーID）を自動割り当て 🪪。
* **ストリーム多重化** 🕎：同じストリームを *複数のクライアントで同時に* 再生可能。
* HTTP ミドルウェアによる **耐障害性、エラー耐性** のあるストリーミング 🛡。
* Go 言語で書かれた *超高速、最小限のプロキシ* ☄！

このプロキシを使うことで、以下のアーキテクチャが可能になります：

![acexy トポロジー](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/acexy.svg)

## 使い方 📐

`acexy` は Docker イメージとして提供されています。最新の [Docker](https://docker.com) イメージがインストールされて利用可能であることを確認してください。

Acexy コンテナは AceStream サーバーに接続します。Docker イメージをデプロイし、同じネットワーク内で Acexy をリンクするか、ホスト上で稼働中の AceStream バージョンに接続し、Acexy をホストネットワークモードで実行する必要があります。

> **情報**：リポジトリには `docker-compose.yml` ファイルがあり、これを使って全体のブロックを直接起動できます。これは **`v0.2.0` 以降推奨される設定** です。

サービスブロックを起動するには、まず `docker-compose.yml` ファイルを取得し、次のコマンドを実行してください：










```shell
wget https://raw.githubusercontent.com/Javinator9889/acexy/refs/heads/main/docker-compose.yml
docker compose run -d
```

Docker Composeを使用したくない場合、すでにAceStreamサーバーをお持ちであれば、別の方法としては以下のようになります：


```shell
docker run --network host ghcr.io/javinator9889/acexy
```
> **注意**: 便宜上、すべての調整可能なパラメータを含む `docker-compose.yml` ファイルが提供されています。  
> すぐに実行できる状態であり、`v0.2.0` 以降の推奨される開始方法です。

デフォルトでは、プロキシはMPEG-TSモードで動作します。モードを切り替えるには、  
**`-m3u8` フラグを追加するか、`ACEXY_M3U8=true` 環境変数を設定する必要があります**。

> **注意**: HLSモード - `ACEXY_M3U8` または `-m3u8` フラグ - は未検証の状態です。  
> 使用は推奨されず、正常に動作する保証はありません。

利用可能なエンドポイントは1つだけです: `/ace/getstream` であり、標準の  
[AceStream Middleware/HTTP API](https://docs.acestream.net/developers/api-reference/) と同じパラメータを受け取ります。  
したがって、ストリームを実行するには、お好みのアプリケーション（例: VLC）で以下のリンクを開くだけです。





```
http://127.0.0.1:8080/ace/getstream?id=dd1e67078381739d14beca697356ab76d49d1a2
```
where `dd1e67078381739d14beca697356ab76d49d1a2` is the ID of the AceStream 
channel.

## 最適化 🚀

プロキシの背後で動作しているAceStreamエンジンには、パフォーマンスを最適化するために公開できる複数のポートがあります。デフォルトでは以下の通りです：

- `8621/tcp`
- `8621/udp`

> 注意：これらはDocker内の`EXTRA_FLAGS`変数を使い、`--port`フラグで調整可能です。

これらのポートを公開することで、より安定したストリーミング体験が得られるはずです。ゲートウェイ側でもこれらのポートを開放する必要があることに注意してください。

参考までに、Dockerコマンドの実行例は以下の通りです：





```shell
docker run -t -p 8080:8080 -p 8621:8621 ghcr.io/javinator9889/acexy
```

### 代替案 🧃

AceStream は内部で UPnP IGD を使用してリモートマシンに接続しようとします。
問題は、Docker によって追加されたブリッジ層のためにこれが機能しないことです
(参照: https://docs.docker.com/engine/network/drivers/bridge/)。

Acexy の単一インスタンスと AceStream の単一インスタンスを実行している場合、
ホストネットワーキングでコンテナを実行することは安全です。これは以下を意味します：

- コンテナはあなたのメインネットワークにブリッジされた他のアプリケーションに**アクセス可能**です。
- どのポートも**公開する必要はありません**。
- パフォーマンスが**少し最適化**されます。

> 注：これは Linux 環境でのみ動作します。詳細は https://docs.docker.com/engine/network/drivers/host/ を参照してください。

コマンドは非常に簡単です：


```shell
docker run -t --network host ghcr.io/javinator9889/acexy
```
AceStreamがUPnPを自由に使用できるようになるはずです。

## 設定オプション ⚙

Acexyには動作をカスタマイズできる多数の設定オプションがあります。すべてに
最適な体験を得るためにテストされたデフォルト値がありますが、必要に応じて
調整する必要があるかもしれません。

> **プロのヒント**: `acexy -help` を実行すると、利用可能なすべてのオプションを
> 完全に確認できます。

AcexyはDockerコンテナ内で実行されることを想定しているため、すべての変数と設定は
環境変数を使って調整可能です。


<table>
  <thead>
    <tr>
      <th>フラグ</th>
      <th>環境変数</th>
      <th>説明</th>
      <th>デフォルト</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th><code>-license</code></th>
      <th>-</th>
      <th>プログラムのライセンスを表示して終了</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-help</code></th>
      <th>-</th>
      <th>ヘルプメッセージを表示して終了</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-addr</code></th>
      <th><code>ACEXY_LISTEN_ADDR</code></th>
      <th>Acexyが待ち受けているアドレス。<code>host</code>モードで実行する際に便利です。</th>
      <th><code>:8080</code></th>
    <tr>
    <tr>
      <th><code>-scheme</code></th>
      <th><code>ACEXY_SCHEME</code></th>
      <th>
        AceStreamミドルウェアのスキーム。AceStreamをHTTPSで動作するように設定している場合は、この値を調整する必要があります。
      </th>
      <th><code>http</code></th>
    <tr>
    <tr>
      <th><code>-acestream-host</code></th>
      <th><code>ACEXY_HOST</code></th>
      <th>
        AceStreamミドルウェアの場所。異なるAceStreamエンジンに接続する必要がある場合は変更してください。
      </th>
      <th><code>localhost</code></th>
    <tr>
    <tr>
      <th><code>-acestream-port</code></th>
      <th><code>ACEXY_PORT</code></th>
      <th>
        AceStreamミドルウェアに接続するポート。異なるAceStreamエンジンに接続する必要がある場合は変更してください。
      </th>
      <th><code>6878</code></th>
    <tr>
    <tr>
      <th><code>-m3u8-stream-timeout</code></th>
      <th><code>ACEXY_M3U8_STREAM_TIMEOUT</code></th>
      <th>
        AcexyをM3U8モードで実行する際、ストリームが終了したと見なすタイムアウト時間。
      </th>
      <th><code>60s</code></th>
    <tr>
    <tr>
      <th><code>-m3u8</code></th>



      <th><code>ACEXY_M3U8</code></th>
      <th>
        AcexyでM3U8モードを有効にします。<b>警告</b>: このモードは実験的であり、期待通りに動作しない場合があります。
      </th>
      <th>無効</th>
    <tr>
    <tr>
      <th><code>-empty-timeout</code></th>
      <th><code>ACEXY_EMPTY_TIMEOUT</code></th>
      <th>
        ミドルウェアから空の情報が受信された後、ストリームが終了したと見なすためのタイムアウト時間。M3U8モードでは無意味です。
      </th>
      <th><code>1m</code></th>
    <tr>
    <tr>
      <th><code>-buffer-size</code></th>
      <th><code>ACEXY_BUFFER_SIZE</code></th>
      <th>
        プレイヤーにデータをコピーする前に、ストリームの最大<code>buffer-size</code>バイトをバッファリングします。再生の安定性向上に役立ちます。
      </th>
      <th><code>4.2MiB</code></th>
    <tr>
    <tr>
      <th><code>-no-response-timeout</code></th>
      <th><code>ACEXY_NO_RESPONSE_TIMEOUT</code></th>
      <th>
        新しく開かれたストリームに対してAceStreamミドルウェアが応答を返すまでの待機時間。インターネット接続が非常に悪くない限り（例：非常に高い遅延がある場合）、できるだけ短くする必要があります。
      </th>
      <th><code>1s</code></th>
    <tr>
  </tbody>
</table>

> **注意**: オプションのリストは膨大ですが、古くなっている可能性があります。疑問がある場合は常にAcexyバイナリの`-help`出力を参照してください。







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---