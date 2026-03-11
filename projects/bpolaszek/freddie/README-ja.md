[![Application](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml/badge.svg)](https://github.com/bpolaszek/mercure-x/actions/workflows/app.yml)
[![Coverage](https://codecov.io/gh/bpolaszek/freddie/branch/main/graph/badge.svg?token=uB4gRHyS6r)](https://codecov.io/gh/bpolaszek/freddie)

# Freddie

Freddieは[Mercure Hub仕様](https://mercure.rocks/spec)のPHP実装です。

これは非常に高速で、偉大な先人たちの上に築かれています：
- [PHP](https://www.php.net/releases/8.1/en.php) 8.1
- [Framework X](https://framework-x.org/) と [ReactPHP](https://reactphp.org/)
- [Symfony](https://symfony.com/) 6
- [Redis](https://redis.io/)（オプション）

どの機能が対応済みで、どの機能がまだかは[こちら](#feature-coverage)をご覧ください。

## インストール

ハブを実行するにはPHP 8.1以上が必要です。

### 単独のMercureハブとして

```bash
composer create-project freddie/mercure-x freddie && cd freddie
bin/freddie
```

これは匿名購読が有効な状態で、`127.0.0.1:8080`上にFreddieインスタンスを起動します。

`HMAC SHA256`アルゴリズムで`!ChangeMe!`キーに署名された有効なJWTを生成することで、ハブに更新を公開できます。

これらの値を変更するには、[セキュリティ](#security)を参照してください。

### 既存のSymfonyアプリケーションのバンドルとして

```bash
composer req freddie/mercure-x
```

次に、ハブを起動するには以下を実行します:

```bash
bin/console freddie:serve
```
`.env.local` ファイル内の関連する環境変数や、`config/services.yaml` 内のサービスを通常通り上書きできます。

その後、サービス内で `Freddie\Hub\HubInterface` を注入することで、`$hub->publish($update)` を呼び出したり、
CLI コンテキストでディスパッチされたアップデートをリッスンしたりできます 👍

これは Redis トランスポートを使用している場合のみ動作することに注意してください。

⚠️ **Freddie** は独自のルーティング／認証システムを使用しています（非同期／イベントループのため）。

公開されるコントローラーは `routes.yaml` にインポートできず、`security.yaml` のスコープ外になります。

## 使用方法



```bash
./bin/freddie
```

`127.0.0.1:8080`で新しいMercureハブを起動します。  
このアドレスを変更するには、`X_LISTEN`環境変数を使用してください。  

```bash
X_LISTEN="0.0.0.0:8000" ./bin/freddie
```
### セキュリティ

デフォルトのJWTキーは `!ChangeMe!` で、署名アルゴリズムは `HS256` です。

環境変数（`.env.local` またはOSレベル）を変更することで異なる値を設定できます：
`X_LISTEN`、`JWT_SECRET_KEY`、`JWT_ALGORITHM`、`JWT_PUBLIC_KEY`、およびRS512やECDSAを使用する場合は `JWT_PASSPHRASE`

パブリッシャーおよび/またはサブスクライバーとして認証するには、Mercure仕様の[認可](https://mercure.rocks/spec#authorization)セクションを参照してください。

### PHPトランスポート（デフォルト）

デフォルトでは、ハブは単一のPHPプロセス内でシンプルなイベントディスパッチャーとして動作します。

これは基本的な使用には一般的なニーズに対応できますが、このトランスポートを使用するとスケーラビリティが制限されます。
別のプロセスを開いても同じイベントエミッターを共有しないためです。

次の場合には十分に使用可能です：
- 1秒あたり数百件を超える更新を期待しない場合
- アプリケーションが単一サーバーから提供されている場合

### Redisトランスポート

一方で、Redisトランスポートを使用すると、**複数のポート**および/または**複数のサーバー**でハブを起動できます
（同じRedisインスタンスを共有している限り）、そして任意でロードバランサーを使用してトラフィックを分散できます。

公式のオープンソース版ハブは、_bolt_ トランスポートの同時実行制限によりスケーリングを許可していません。

Redisトランスポートでハブを起動するには、`TRANSPORT_DSN` 環境変数を変更してください：



```bash
TRANSPORT_DSN="redis://127.0.0.1:6379" ./bin/freddie
```

DSNのクエリ文字列に渡すことができるオプションパラメータ：
- `pingInterval` - Redis接続を定期的にpingし、障害検出を助ける（デフォルト `2.0`）
- `readTimeout` - pingまたはpublishリクエストの最大秒数（デフォルト `0.0`：無効とみなされる）

_あるいは、この変数を `.env.local` に設定することもできます。_

## 利点と制限

この実装はSSLやHTTP2終端を提供しないため、前段にリバースプロキシを置くことを推奨します。

### Nginx設定例

```nginx
upstream freddie {
    # Example with a single node
    server 127.0.0.1:8080;

    # Example with several nodes (they must share the same Redis instance)
    # 2 instances on 10.1.2.3
    server 10.1.2.3:8080;
    server 10.1.2.3:8081;

    # 2 instances on 10.1.2.4
    server 10.1.2.4:8080;
    server 10.1.2.4:8081;
}

server {
    
    listen 443 ssl http2;
    listen [::]:443 ssl http2;
    server_name example.com;

    ssl_certificate /etc/ssl/certs/example.com/example.com.cert;
    ssl_certificate_key /etc/ssl/certs/example.com/example.com.key;
    ssl_ciphers EECDH+CHACHA20:EECDH+AES128:RSA+AES128:EECDH+AES256:RSA+AES256:EECDH+3DES:RSA+3DES:!MD5;

    location /.well-known/mercure {
        proxy_pass http://freddie;
        proxy_read_timeout 24h;
        proxy_http_version 1.1;
        proxy_set_header Connection "";
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
        proxy_set_header X-Forwarded-Host $host;
        proxy_set_header X-Forwarded-Proto $scheme;
    }
}
```

### Caddyの設定例

#### 単一ノード

```caddy
example.com

reverse_proxy 127.0.0.1:8080
```

#### 複数ノードの場合

```caddy
example.com

reverse_proxy 10.1.2.3:8080 10.1.2.3:8081 10.1.2.4:8080 10.1.2.4:8081
```
### ペイロード制限
⚠ [Framework-X](https://framework-x.org/docs/api/request/)にはリクエストボディが[64 KB](https://github.com/reactphp/http/issues/412)を超えないという既知の制限があります。  
執筆時点では、この制限はFramework-XがHTTPサーバーのインスタンス化をカプセル化しているため引き上げられません。

Freddieへの大きなアップデート（少なくともHTTP経由）は400エラーを引き起こす可能性があります。

## 機能対応状況

| 機能                                         | 対応状況                               |
|---------------------------------------------|---------------------------------------|
| `Authorization`ヘッダーによるJWT             | ✅                                     |
| `mercureAuthorization`クッキーによるJWT      | ✅                                     |
| 匿名購読者の許可                             | ✅                                     |
| 代替トピック                                | ✅️                                    |
| プライベートアップデート                     | ✅                                     |
| トピックのURIテンプレート                    | ✅                                     |
| HMAC SHA256 JWT署名                          | ✅                                     |
| RS512 JWT署名                               | ✅                                     |
| 環境変数による設定                           | ✅                                     |
| カスタムメッセージID                         | ✅                                     |
| 最終イベントID（`earliest`含む）             | ✅️                                    |
| カスタマイズ可能なイベントタイプ              | ✅️                                    |
| カスタマイズ可能な`retry`ディレクティブ       | ✅️                                    |
| CORS                                        | ❌（ウェブサーバーで設定してください）  |
| ヘルスチェックエンドポイント                   | ❌（PR歓迎）                          |
| ロギング                                     | ❌（PR歓迎）️                        |
| メトリクス                                   | ❌（PR歓迎）️                        |
| 購読者／発行者で異なるJWT                     | ❌（PR歓迎）                          |
| サブスクリプションAPI                        | ❌️（TODO）                           |


## テスト

このプロジェクトは[Pest](https://pestphp.com/)のテストで100%カバーされています。


```bash
composer tests:run
```

## 貢献する

このプロジェクトを改善したい場合は、PRを自由に提出してください：

- [PSR-12コーディング標準](https://www.php-fig.org/psr/psr-12/)に従わないとCIが警告します
- 新機能の場合はテストを必ず添付してください
- [PHPStan](https://phpstan.org/)の解析はレベル8で合格する必要があります

すべてのCI要件を満たしていることを確認するために、コミット前に以下のコマンドを実行できます：

```bash
composer ci:check
```

## ライセンス

GNU一般公衆利用許諾契約書バージョン3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---