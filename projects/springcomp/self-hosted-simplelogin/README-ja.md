# SimpleLogin

これは[SimpleLogin](https://simplelogin.io)のセルフホスト型docker-compose構成です。

## 前提条件

- Linuxサーバー（VMまたは専用サーバーのいずれか）。このドキュメントはUbuntu 18.04 LTSのセットアップを示していますが、手順は他の一般的なLinuxディストリビューションにも適応可能です。ほとんどのコンポーネントがDockerコンテナとして動作し、Dockerはやや重いため、最低でも2GBのRAMを推奨します。サーバーはポート25（メール）、80、443（Webアプリ用）、22（SSH接続用）を開放している必要があります。

- DNSを設定できるドメイン。サブドメインでも構いません。以降のドキュメントでは、メール用に`mydomain.com`、SimpleLoginのWebアプリ用に`app.mydomain.com`とします。これらの値はドキュメント内の該当箇所すべてにおいて、ご自身のドメイン名およびサブドメイン名に置き換えてください。私たちが使う裏技として、このREADMEファイルをパソコンにダウンロードし、すべての`mydomain.com`と`app.mydomain.com`を自分のドメインに置換する方法があります。

DNS設定は通常ドメイン登録業者のインターフェースで行いますが、以下の手順はすべてサーバー上で実行します。コマンドは`bash`（または`zsh`などのbash互換シェル）を使用してください。`fish`など他のシェルを使う場合は、コマンドを適宜調整してください。

- セットアップを検証するために使用するユーティリティパッケージ。以下のコマンドでインストールします。

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```
## DNS 設定

_詳細については、[参考ドキュメント](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration)を参照してください_

> **ご注意** DNSの変更が反映されるまで最大24時間かかる場合があります。実際にはかなり速く（テストでは約1分程度）反映されます。DNS設定では、絶対ドメインを強制するために末尾にドット（`.`）を付けたドメインを使用することが一般的です。

以下のDNSレコードを設定する必要があります：

- **A**：ドメインをサーバーのIPv4アドレスにマッピングします。
- **AAAA**：ドメインをサーバーのIPv6アドレスにマッピングします。
- **MX**：受信メールをメールサーバーに転送します（`*`ワイルドカードを含む）。
- **PTR**：サーバーのIPアドレスをドメイン名に逆引きします。

必須のセキュリティポリシーを設定してください：

- **DKIM**：送信メールにデジタル署名をして正当性を検証します。
- **DMARC**：認証に失敗したメールの処理方法を受信側に指示します。
- **SPF**：特定のメールサーバーがドメインからメールを送信することを許可します。

追加の手順：

- **CAA**：どの認証局がドメインのSSL証明書を発行できるかを指定します。
- **MTA-STS**：メールサーバー間の安全な暗号化接続を強制します。
- **TLS-RPT**：TLS接続の失敗を報告し、メール配信のセキュリティを向上させます。

**警告**：CAAレコードを設定すると、どの認証局がドメインのSSL証明書を発行できるかが制限されます。
これにより、Let's Encryptのステージングサーバーからの証明書発行ができなくなります。証明書が正常に発行されるまで、このDNSレコードは後回しにすることをお勧めします。

## Docker

サーバーにDockerがまだインストールされていない場合は、[Docker CE for Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/)の手順に従ってDockerをインストールしてください。

また、[docker-install](https://github.com/docker/docker-install)スクリプトを使用してDockerをインストールすることもできます。これは


```bash
curl -fsSL https://get.docker.com | sh
```

[デフォルトのブリッジネットワーク](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)でIPv6を有効にする

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
この手順では、Dockerコンテナを使用してスタック全体を実行する方法を案内します。  
これには以下が含まれます：

- traefik  
- [SimpleLoginアプリ](https://github.com/simple-login/app)のコンテナ  
- postfix  

DockerコンテナからSimpleLoginを実行する方法：

1. `/opt/simplelogin`にこのリポジトリをクローンします。  
1. `.env.example`を`.env`にコピーし、適切な値を設定します。  

    - `DOMAIN`変数をあなたのドメインに設定します。  
    - `SUBDOMAIN`変数をあなたのドメインに設定します。デフォルト値は`app`です。  
    - `POSTGRES_USER`変数をpostgresの認証情報に合わせて設定します（初めての場合は`simplelogin`を使用）。  
    - `POSTGRES_PASSWORD`をpostgresの認証情報に合わせて設定します（初めての場合はランダムなキーを設定）。  
    - `FLASK_SECRET`を任意のシークレットキーに設定します。  

### Postgres SQL  

このリポジトリはDockerコンテナ内でpostgres SQLを実行します。  

**警告**: このリポジトリの以前のバージョンは`12.1`を使用していました。  
詳細とアップグレード手順については、[参考ドキュメント](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL)を参照してください。  

### アプリケーションの実行  

以下のコマンドを使用してアプリケーションを実行します：



```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

この時点で[証明書認証局の認可（CAA）](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa)を設定することをお勧めします。

## 次のステップ

上記のすべての手順が成功したら、<https://app.mydomain.com/> を開いて最初のアカウントを作成してください！

デフォルトでは、新しいアカウントはプレミアムではないため、無制限のエイリアスはありません。アカウントをプレミアムにするには、
データベースの "users" テーブルに移動し、"lifetime" カラムを "1" または "TRUE" に設定してください：

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```
すべての希望するログインアカウントを作成したら、さらなる登録を無効にするためにこれらの行を `.env` に追加してください：


```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

その後、Webアプリを再起動するには、次のコマンドを適用してください: `docker compose restart app`

## その他

### Postfix設定 - Spamhaus

Spamhausプロジェクトは、スパムの発信元として知られるIPアドレスの信頼できるリストを管理しています。
特定のIPアドレスがそのリストに含まれているかどうかは、DNSインフラにクエリを送信して確認できます。

Spamhausはパブリック（オープン）DNSリゾルバからのクエリをブロックするため（参照: <https://check.spamhaus.org/returnc/pub>）、お使いのpostfixコンテナが
デフォルトでパブリックリゾルバを使用する場合は、無料の
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
に登録し、Spamhaus DQSキーを取得することを推奨します。

このキーを `.env` の `SPAMHAUS_DQS_KEY` として貼り付けてください。

DQSキーが提供されていない場合、postfixコンテナはSpamhausのパブリックミラーがクエリを受け入れるかどうかをチェックし、受け入れる場合はそちらを使用します。
Spamhausがpostfixコンテナからのパブリックミラーへのクエリを拒否した場合、機能は完全に無効になります。

### Postfix設定 - バーチャルエイリアス

postfix設定は `postfix/conf.d/virtual` および `postfix/conf.d/virtual-regexp` ファイルを使用したバーチャルエイリアスをサポートしています。
これらのファイルは、対応する[`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
および [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) テンプレートファイルに基づいて起動時に自動生成されます。

デフォルトの設定は以下の通りです:

#### virtual.tpl

`virtual` ファイルはpostfixの `virtual_alias_maps` 設定をサポートしています。
これは、存在しないエイリアスに対応する特定のアドレス `unknown@mydomain.com` からのメールを、存在する別のアドレス `contact@mydomain.com` に転送するルールを含みます。


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

`virtual-regexp`ファイルはポストフィックスの`virtual_alias_maps`設定をサポートします。  
存在しないエイリアスに対応しない任意のサブドメイン宛のメールを、  
サブドメイン名から取られたディレクトリに属する新しいエイリアスに書き換えるルールを含んでいます。  
そのエイリアスは存在しない場合、動的に作成されることがあります。

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```
たとえば、`someone@directory.mydomain.com` に送信されたメールは、postfix によって `directory/someone@mydomain.com` にルーティングされます。

## 3.4.0 からのアップグレード方法

_このセクションは[参考ドキュメント](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)に移動しました_

## 以前のNGinxベースのセットアップからのアップグレード方法

_このセクションは[参考ドキュメント](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)に移動しました_



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-14

---