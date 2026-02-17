# ipregion

![image](https://i.imgur.com/CRxBuVR.gif)

## 使い方

### ローカルにダウンロードして実行する

```bash
wget -O ipregion.sh https://ipregion.vrnt.xyz
chmod +x ipregion.sh
```

### GitHubから直接実行する

```bash
bash <(wget -qO- https://ipregion.vrnt.xyz)
```

### Docker

#### IPv4用コンテナの実行（デフォルトのDockerブリッジネットワーク）

これは、ホストネットワークモードを必要とせず、IPv4のみを使用してIPジオロケーションチェックを実行します：

```bash
docker run --rm vernette/ipregion:latest
```
必要に応じて追加のスクリプトオプションを付加できます。例えば：


```
docker run --rm vernette/ipregion:latest --group geoip
```

#### ホストネットワーク（IPv4 & IPv6またはカスタムインターフェース）でコンテナを実行する

ホストの実際のネットワークインターフェースでIPv4とIPv6の両方にアクセスするか、カスタムネットワークインターフェース（例：eth1）を指定するには、Dockerのホストネットワークモードを使用します：

```bash
docker run --rm --network=host vernette/ipregion:latest
```

```bash
docker run --rm --network=host vernette/ipregion:latest --interface eth1
```

> [!注意]
> `--network=host` を使用すると、コンテナはホストのネットワークスタックを共有し、ネットワークの分離は低減しますが、インターフェースへの完全なアクセスが可能になります。`--network=host` を使わない場合、コンテナはDockerのブリッジネットワークを使用し、IPv6が公開されなかったりインターフェースの選択ができない場合があります。

## 機能

- 複数のGeoIP APIおよびウェブサービス（YouTube、Netflix、ChatGPT、Spotifyなど）
- SOCKS5プロキシおよびカスタムネットワークインターフェース対応のIPv4/IPv6サポート
- JSON出力および色分けされた表

## 依存関係

- bash
- curl
- jq
- util-linux/bsdmainutils

## 主要オプション

```bash
./ipregion.sh --help # Show all options
./ipregion.sh --group primary # GeoIP services only
./ipregion.sh --group custom # Popular websites only
./ipregion.sh --ipv4 # IPv4 only
./ipregion.sh --ipv6 # IPv6 only
./ipregion.sh --proxy 127.0.0.1:1080 # Use SOCKS5 proxy
./ipregion.sh --json # JSON output
./ipregion.sh --debug # Debug mode
```
すべてのオプションは組み合わせ可能です。

## 国コード

スクリプトは国コードをISO 3166-1 alpha-2形式（例：RU、US、DE）で出力します。

任意の国コードの意味は公式ISOウェブサイトで確認できます：[https://www.iso.org/obp/ui/#search/code/](https://www.iso.org/obp/ui/#search/code/)

検索ボックスにコードを入力すると、正式な国名が表示されます。

## 貢献について

貢献は大歓迎です！新しいサービスの追加やスクリプトの機能改善のためのプルリクエストを自由に提出してください。

![Star History Chart](https://api.star-history.com/svg?repos=vernette/ipregion&type=Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---