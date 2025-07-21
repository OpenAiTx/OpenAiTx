<translate-content># acme-tiny

[![Tests](https://github.com/diafygi/acme-tiny/actions/workflows/full-tests-with-coverage.yml/badge.svg?branch=main)](https://github.com/diafygi/acme-tiny/actions/workflows/full-tests-with-coverage.yml)
[![Coverage Status](https://coveralls.io/repos/github/diafygi/acme-tiny/badge.svg?branch=main)](https://coveralls.io/github/diafygi/acme-tiny?branch=main)

これはサーバー上で動作させて[Let's Encrypt](https://letsencrypt.org/)の証明書を発行および更新するための
非常に小さく監査可能なスクリプトです。サーバー上で実行し、
あなたのプライベートなLet's Encryptアカウントキーにアクセスできる必要があるため、
できるだけ小さく（現在200行未満）しようとしました。
必要条件はpythonとopensslだけです。

**必ずソースコードを読んでください！あなたのプライベートアカウントキーを信頼する必要があります！**

## 寄付

このスクリプトが役に立ったら、ぜひEFFに寄付してください。私はそこでは働いていませんが、
彼らは素晴らしい仕事をしています。

[https://eff.org/donate/](https://eff.org/donate/)

## このスクリプトの使い方

すでにLet's Encryptで発行された証明書を持っていて更新だけしたい場合は、
ステップ3と6だけを実行すればよいです。

### ステップ1：Let's Encryptアカウントの秘密鍵を作成する（まだ作成していない場合）

Let's Encryptに登録された公開鍵を持ち、対応する秘密鍵でリクエストに署名する必要があります。
もし上記の内容がよくわからない場合は、このスクリプトはあなた向きではない可能性が高いです！
公式のLet's Encrypt[クライアント](https://github.com/letsencrypt/letsencrypt)を使用してください。
これを実現するために、acme-tinyが使用できるキーを最初に作成し、
アカウントを登録し、以降の全てのリクエストに署名します。


```
openssl genrsa 4096 > account.key
```
#### 既存の Let's Encrypt キーを使用する

あるいは、元の Let's Encrypt クライアントで以前に生成したキーを変換することもできます。

Let's Encrypt クライアントのプライベートアカウントキーは
[JWK](https://tools.ietf.org/html/rfc7517) 形式で保存されています。`acme-tiny` は PEM
キー形式を使用しています。キーを変換するには、JonLundy による
[変換スクリプト](https://gist.github.com/JonLundy/f25c99ee0770e19dc595) ツールを使用できます：



```sh
# Download the script
wget -O - "https://gist.githubusercontent.com/JonLundy/f25c99ee0770e19dc595/raw/6035c1c8938fae85810de6aad1ecf6e2db663e26/conv.py" > conv.py

# Copy your private key to your working directory
cp /etc/letsencrypt/accounts/acme-v01.api.letsencrypt.org/directory/<id>/private_key.json private_key.json

# Create a DER encoded private key
openssl asn1parse -noout -out private_key.der -genconf <(python2 conv.py private_key.json)

# Convert to PEM
openssl rsa -in private_key.der -inform der > account.key
```
### ステップ 2: ドメイン用の証明書署名要求（CSR）を作成します。

ACMEプロトコル（Let's Encryptが使用するもの）は、更新の場合でもCSRファイルの提出を
要求します。同じCSRを複数回の更新に使用できます。注意：
アカウントの秘密鍵をドメインの秘密鍵として使用することはできません！


```
# Generate a domain private key (if you haven't already)
openssl genrsa 4096 > domain.key
```

```
# For a single domain
openssl req -new -sha256 -key domain.key -subj "/CN=yoursite.com" > domain.csr

# For multiple domains (use this one if you want both www.yoursite.com and yoursite.com)
openssl req -new -sha256 -key domain.key -subj "/" -addext "subjectAltName = DNS:yoursite.com, DNS:www.yoursite.com" > domain.csr

# For multiple domains (same as above but works with openssl < 1.1.1)
openssl req -new -sha256 -key domain.key -subj "/" -reqexts SAN -config <(cat /etc/ssl/openssl.cnf <(printf "[SAN]\nsubjectAltName=DNS:yoursite.com,DNS:www.yoursite.com")) > domain.csr
```
### ステップ3: ウェブサイトにチャレンジファイルを配置する

証明書を取得したいドメインの所有権を証明する必要があるため、Let's Encrypt
ではそれらのドメインにファイルをホストすることを要求します。このスクリプトは、
指定したフォルダにそれらのファイルを生成して書き込むので、あなたがするべきことは
このフォルダが".well-known/acme-challenge/"のURLパスで提供されていることを確認することです。注意: Let's
Encryptはサーバーのポート80に対してプレーンなHTTPリクエストを行うため、
チャレンジファイルはHTTP経由で提供する必要があります（HTTPSへのリダイレクトでも問題ありません）。


```
# Make some challenge folder (modify to suit your needs)
mkdir -p /var/www/challenges/
```

```nginx
# Example for nginx
server {
    listen 80;
    server_name yoursite.com www.yoursite.com;

    location /.well-known/acme-challenge/ {
        alias /var/www/challenges/;
        try_files $uri =404;
    }

    ...the rest of your config
}
```
### ステップ4：署名済み証明書を取得しましょう！

サーバーの設定と必要なファイルの生成が完了したら、
上記のフォルダーに書き込みができ、アカウントの秘密鍵とCSRを読み取る権限を持つ状態で、
サーバー上でこのスクリプトを実行してください。


```
# Run the script on your server
python acme_tiny.py --account-key ./account.key --csr ./domain.csr --acme-dir /var/www/challenges/ > ./signed_chain.crt
```
### ステップ5：証明書のインストール

このスクリプトによって出力される署名済みのhttps証明書チェーンは、
秘密鍵とともにhttpsサーバーを実行するために使用できます。これらを
ウェブサーバーの設定のhttps設定に含める必要があります。nginxサーバーの
設定例は以下の通りです：


```nginx
server {
    listen 443 ssl;
    server_name yoursite.com www.yoursite.com;

    ssl_certificate /path/to/signed_chain.crt;
    ssl_certificate_key /path/to/domain.key;
    ssl_session_timeout 5m;
    ssl_protocols TLSv1.2;
    ssl_ciphers ECDHE-RSA-AES256-GCM-SHA384:ECDHE-RSA-AES128-GCM-SHA256:DHE-RSA-AES256-GCM-SHA384;
    ssl_session_cache shared:SSL:50m;
    ssl_dhparam /path/to/server.dhparam;
    ssl_prefer_server_ciphers on;

    ...the rest of your config
}

server {
    listen 80;
    server_name yoursite.com www.yoursite.com;

    location /.well-known/acme-challenge/ {
        alias /var/www/challenges/;
        try_files $uri =404;
    }

    ...the rest of your config
}
```
### ステップ6: 自動更新のcronジョブ設定

おめでとうございます！あなたのウェブサイトは今やhttpsを使用しています！残念ながら、Let's Encryptの
証明書は90日間しか有効ではないため、頻繁に更新する必要があります。心配いりません！
自動化されています！bashスクリプトを作成し、それをcrontabに追加するだけです（以下に
例のスクリプトを示します）。

`renew_cert.sh` の例：

```sh
#!/usr/bin/sh
python /path/to/acme_tiny.py --account-key /path/to/account.key --csr /path/to/domain.csr --acme-dir /var/www/challenges/ > /path/to/signed_chain.crt.tmp || exit
mv /path/to/signed_chain.crt.tmp /path/to/signed_chain.crt
service nginx reload
```

```
# Example line in your crontab (runs once per month)
0 0 1 * * /path/to/renew_cert.sh 2>> /var/log/acme_tiny.log
```
**注意:** Let's EncryptのACME v2リリース（acme-tiny 4.0.0以降）により、中間証明書は発行された証明書のダウンロードに含まれるようになったため、  
中間証明書を独立してダウンロードし、署名済み証明書に連結する必要はなくなりました。もしacme-tiny 4.0未満（例: 2018-03-17以前）を使ったシェルスクリプトやMakefileがあり、  
acme-tiny 4.0.0以降で使用している場合、中間証明書をsigned_chain.crtに二重に追加してしまっている可能性があります（これにより  
[少なくともGnuTLS 3.7.0で問題が発生します](https://gitlab.com/gnutls/gnutls/-/issues/1131)し、証明書のサイズも必要以上に大きくなります）。  
修正するには、中間証明書をダウンロードしacme-tinyの証明書出力に追加しているbashコードを単純に削除してください。

## パーミッション

このスクリプトのセットアップや実行時に最も遭遇する問題はパーミッションです。アカウントの秘密鍵やチャレンジ用ウェブフォルダへのアクセスを  
可能な限り制限したいでしょう。特にこのスクリプト、アカウント秘密鍵、チャレンジフォルダを扱う専用ユーザーを作成することをお勧めします。  
そしてそのユーザーにインストール済み証明書ファイル（例: `/path/to/signed_chain.crt`）への書き込み権限とウェブサーバのリロード権限を付与してください。  
こうすることで、cronスクリプトは必要な処理を実行し、古い証明書を上書きし、ウェブサーバをリロードしますが、それ以外の操作権限は持ちません。

**必ず行うこと:**
* アカウント秘密鍵（例: `account.key`）のバックアップを取ること
* このスクリプトにドメイン秘密鍵を読み取る権限を与えないこと！
* このスクリプトをrootで実行しないこと！

## ステージング環境

Let's Encryptは新しい設定をステージングサーバーでテストすることを推奨しています。  
新しい設定を試す際は、`--directory-url https://acme-staging-v02.api.letsencrypt.org/directory` を使用して、  
本番のLet's Encryptサーバーではなくテスト用の偽証明書を発行できます。詳細は  
[https://letsencrypt.org/docs/staging-environment/](https://letsencrypt.org/docs/staging-environment/) をご参照ください。

## フィードバック／貢献

このプロジェクトは非常に限定的な範囲とコードベースを持っています。バグ報告やプルリクエストは歓迎しますが、新機能の追加はご遠慮ください。  
このスクリプトは200行未満に保ち、誰でも簡単に監査できるようにする必要があります。

ご自身の環境で使いやすくするために機能追加をしたい場合は、どうぞご自由に！オープンソースですので、フォークして必要に応じて修正してください。

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---