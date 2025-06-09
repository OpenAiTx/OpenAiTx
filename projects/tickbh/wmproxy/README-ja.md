# wmproxy
[![crates.io](https://img.shields.io/crates/v/wmproxy.svg)](https://crates.io/crates/wmproxy)
[![rustc 1.70.0](https://img.shields.io/badge/rust-1.70%2B-orange.svg)](https://img.shields.io/badge/rust-1.70%2B-orange.svg)
[![Released API docs](https://docs.rs/wmproxy/badge.svg)](https://docs.rs/wmproxy)

`wmproxy`は`Rust`で実装された`http/https`プロキシ、`socks5`プロキシ、リバースプロキシ、ロードバランシング、静的ファイルサーバー、`websocket`プロキシ、レイヤ4 TCP/UDPフォワーディング、イントラネット貫通などを提供します。

## 📦 インストール & 🏃 使用方法

### インストール

```bash
cargo install wmproxy
```

または

```bash
git clone https://github.com/tickbh/wmproxy
cd wmproxy
cargo install --path .
```

```docker
docker pull dreamwhat/wmproxy
docker run -p 8090:8090 --name proxy_bash dreamwhat/wmproxy /bin/./wmproxy proxy -b 0.0.0.0:8090
```

### 使用方法
デフォルトポートは8090、デフォルトのリッスンアドレスは127.0.0.1です。
```bash
# デフォルトパラメータで直接起動
wmproxy proxy

# アカウントとパスワードの設定
wmproxy proxy -b 0.0.0.0:8090 --user wmproxy --pass wmproxy

# その他のコマンド
wmproxy --help

# 設定ファイルで起動
wmproxy config -c config/client.toml
```

##### セカンダリプロキシの起動
1. ローカルでプロキシを起動
```bash
wmproxy proxy -b 127.0.0.1:8090 -S 127.0.0.1:8091 --ts
```
または
```bash
wmproxy config -c config/client.toml
```
設定ファイル例:
```toml
[proxy]
# サーバー接続アドレス
#server = "127.0.0.1:8091"
bind_addr = "0.0.0.0:8090"
flag = "http https socks5"
# サーバーへの接続を暗号化するかどうか
ts = true
two_way_tls = true
# username = "wmproxy"
# password = "wmproxy"

# 内部ネットワークマッピング設定の配列

  # localhostのドメインをローカル127.0.0.1:8080へ転送
[[proxy.mappings]]
name = "web"
mode = "http"
local_addr = "127.0.0.1:8080"
domain = "localhost"

headers = [
  "proxy x-forward-for {client_ip}",
  "proxy + from $url",
  "+ last-modified 'from proxy'",
  "- etag",
]

# TCPトラフィックを無条件で127.0.0.1:8080へ転送
[[proxy.mappings]]
name = "tcp"
mode = "tcp"
local_addr = "127.0.0.1:8080"
domain = ""
```

単なるフォワーディングのため、現在のノードでアカウント・パスワードの設定は無意味です。`-S`は接続するセカンダリプロキシのアドレスを示し、**このパラメータがある場合は中継プロキシ、それ以外はエンドプロキシとなります。**```--ts```は親プロキシに接続する際に暗号化接続を使用することを示します。

2. リモートでプロキシを起動
```bash
wmproxy proxy --user proxy --pass proxy -b 0.0.0.0:8091 --tc
```
または
```bash
wmproxy config -c config/server.toml
```
設定ファイル例:
```toml
[proxy]
# バインドするIPアドレス
bind_addr = "127.0.0.1:8091"

# プロキシがサポートする機能、1はhttp、2はhttps、4はsocks5
# flag = "7"
username = "wmproxy"
password = "wmproxy"

# 内部ネットワークHTTPマッピングのバインドアドレス
map_http_bind = "127.0.0.1:8001"
# 内部ネットワークTCPマッピングのバインドアドレス
map_tcp_bind = "127.0.0.1:8002"
# 内部ネットワークHTTPSマッピングのバインドアドレス
map_https_bind = "127.0.0.1:8003"
# 内部ネットワークマッピングの公開証明書。空の場合はデフォルト証明書
# map_cert = 
# 内部ネットワークマッピングの秘密鍵証明書。空の場合はデフォルト証明書
# map_key =
# 双方向認証
two_way_tls = true
# クライアントが暗号化クライアントかどうかを受け入れる
tc = true
# 現在のサービスモード。serverはサーバー、clientはクライアント
mode = "server"
```

```--tc```は子プロキシからの接続時に暗号化を必要とすることを示し、```--cert```で証明書の公開鍵、```--key```で証明書の秘密鍵、```--domain```で証明書のドメインを指定できます。指定しない場合はデフォルトの証明書パラメータが使用されます。
> この方法でプロキシ経由でアクセスした場合、本当のリクエスト元アドレスは取得できず、プロキシが発信したリクエストのみ取得可能です。

### プロキシ間の認証
> 現在、2種類の認証方式を提供しています。```two_way_tls```でクライアント証明書認証を有効化、もう一つはサーバー側で```username```と```password```を設定し、クライアント側も同じユーザー名とパスワードを設定することで認証を有効化します。2つの方法は併用も単独使用も可能です。
> 設定追加例:

```yaml
proxy:
  two_way_tls: true
  username: wmproxy
  password: wmproxy
```

# 🚥 ロードマップ
### socks5

- [x] IPV6 サポート
- [x] `SOCKS5` 認証方式
  - [x] `NOAUTH`
  - [x] `USERPASS`
- [x] `SOCKS5` コマンド
  - [x] `CONNECT`
  - [x] `UDP ASSOCIATE`

### http/https

- [x] IPV6 サポート

### 内部ネットワーク貫通

- [x] Http サポート
- [x] Https サポート
- [x] Tcp サポート

### リバースプロキシ

- [x] 静的ファイルサーバー
- [x] パッシブヘルスチェック
- [x] アクティブヘルスチェック
- [x] 設定ホットリロード
- [x] ロードバランシング
- [x] レイヤ4 TCPバランス
- [x] レイヤ4 UDPバランス
- [x] トラフィック制御
- [x] websocketフォワーディング

### 基本機能
- [x] ログ

#### 拡張機能

- [x] リクエストレート制限(limit_req)
- [x] HTTPリクエストヘッダの変更
- [x] HTTP2の内部ネットワーク貫通サポート
- [x] コントロールミニクライアント
- [x] try_paths
- [x] tcpからwebsocketへの変換
- [x] websocketからtcpへの変換


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=tickbh/wmproxy&type=Date)](https://star-history.com/#tickbh/wmproxy&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---