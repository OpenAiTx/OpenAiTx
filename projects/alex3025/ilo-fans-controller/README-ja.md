<h1 align="center">iLO ファンコントローラー</h1>

<p align="center">
  <img width="800" src="https://raw.githubusercontent.com/alex3025/ilo-fans-controller/main/screenshot.png" alt="Webpage Screenshot">
  <br>
  <i>どこからでも簡単にHPサーバーのファン速度を管理！</i>
</p>

---

<h3 align="center"> 🎉 <code>1,000+</code> コンテナプルありがとうございます！ 🎉 </h3>

> ℹ **注意：** v1.0.0 はツールの **完全な書き直し** なので、ご意見をお待ちしています！<br>
> バグを見つけた場合やご提案があれば、ぜひ[イシューを開いてください](https://github.com/alex3025/ilo-fans-controller/issues)。ありがとうございます！ 😄

## FAQ

### どのように動作しますか？ 🛠

このツールは `php-curl` 拡張を使って **iLO REST API から現在のサーバーファン速度を取得し、** `php-ssh2` 拡張を使って **[パッチ適用済みのiLO SSHインターフェース](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F) を通じてファン速度を設定する、単一のPHPスクリプトです。** また、[Alpine.js](https://alpinejs.dev/) と [TailwindCSS](https://tailwindcss.com/) を使用した **シンプルでクリーンなウェブインターフェース** で、特定のファン設定をワンクリックで適用できる **カスタムプリセットの作成も可能です。**

### このツールは私のHPサーバーで使えますか？ 🖥️

このツールは、ファン速度を操作するためのコマンドを iLO SSH インターフェースに公開する **パッチ適用済みのiLOファームウェア** が必要です。パッチの詳細は [こちらのReddit投稿](https://www.reddit.com/r/homelab/comments/sx3ldo/hp_ilo4_v277_unlocked_access_to_fan_controls/) にあります。

現時点では、このパッチ（および本ツール）は **iLO 4搭載のGen8およびGen9サーバーのみで動作します。**

> 🚫 iLO 5/6/7搭載のGen10/11/12サーバーはサポート対象外（おそらく将来的にも対応しません）。

### なぜPHPを使っているのですか？ 📄

私の意見では、PHPは単純なサーバーサイド処理が必要で、導入も簡単（PHPがインストールされたウェブサーバーがあればよい）なこの種のタスクに最適です。

### なぜこのツールを作ったのですか？ 🤔

このツールの背景は、私の [r/homelab での元コメント](https://www.reddit.com/r/homelab/comments/rcel73/comment/hnu3iyp/?utm_source=share&utm_medium=web2x&context=3) をご覧ください！

### このプロジェクトが気に入りましたか？ ピザを一切れください！ 🍕

このツールが役立った場合は、[PayPal](https://paypal.me/alex3025) または [GitHub Sponsors](https://github.com/sponsors/alex3025) を通じてピザの一切れ（または丸ごと）を提供していただけると嬉しいです！応援ありがとうございます！ 🙏

---

## Getting started with Docker / Docker Compose

If you already have a Docker environment, you can be up and running in minutes using the following command (obviously you need to change the value):

```sh
docker run -d --name ilo-fans-controller --restart always \
    -p 8000:80 \
    -e ILO_HOST='your-ilo-address' \
    -e ILO_USERNAME='your-ilo-username' \
    -e ILO_PASSWORD='your-ilo-password' \
    ghcr.io/alex3025/ilo-fans-controller:latest
```
または、`docker compose` を使用することもできます。 [docker-compose.yaml](https://github.com/alex3025/ilo-fans-controller/blob/main/docker-compose.yaml) ファイルも提供されています。

**利用可能な環境変数はすべて [`config.inc.php`](https://github.com/alex3025/ilo-fans-controller/blob/main/config.inc.php) を確認してください！**

---

> ⚠ **重要！** ⚠
>
> このツールは、ファンの速度を操作するためのコマンドをiLO SSHインターフェースに公開する**[パッチ済みのiLOファームウェア](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F)**のおかげで動作します。
>
> **このパッチはツールを使用するために必須です！**

## 手動インストール

### 以下の環境でガイドを実行しました

* **HP ProLiant DL380e Gen8** サーバー
* **パッチ済みiLO 4** Advanced **v2.77** (2020年12月7日)
* **Ubuntu 22.04** を実行するProxmoxコンテナ (LXC)
* **Apache 2** & **PHP 8.1**

### 環境の準備

1. システムを更新します:


    ```sh
    sudo apt-get update && sudo apt-get upgrade
    ```
2. 必要なパッケージ（`apache2`、`php`、`php-curl`、および `php-ssh2`）をインストールします:


    ```sh
    sudo apt-get install apache2 php php-curl php-ssh2
    ```

### ツールのダウンロード

1. `wget` と `tar` を使用して最新のソースコードをダウンロードし、解凍します:

    ```sh
    wget -qL https://github.com/alex3025/ilo-fans-controller/archive/refs/heads/main.tar.gz -O - | tar -xz
    ```

2. ディレクトリに移動します:

    ```sh
    cd ilo-fans-controller-main
    ```

### ツールの設定とインストール

1. お好みのテキストエディタで `config.inc.php` ファイルを開き、設定に応じて変数を変更します。

    > ℹ **注意:** `$ILO_HOST` はサーバー自体ではなく、iLOインターフェースのIPアドレスであることを忘れないでください。

    > ℹ **注意:** SSHインターフェースとREST API（リモートコンソールアクセス）にアクセスするために必要最低限の権限を持つ新しいiLOユーザーを作成することを推奨します。

    例を示します：

    ```php
    /*
    ILO ACCESS CREDENTIALS
    --------------
    These are used to connect to the iLO
    interface and manage the fan speeds.
    */

    $ILO_HOST = '192.168.1.69';
    $ILO_USERNAME = 'Administrator';
    $ILO_PASSWORD = 'AdministratorPassword1234';
    ```
2. 作業が完了したら、Webサーバーのルートディレクトリ（通常は `/var/www/html/`）に新しいサブディレクトリを作成し、`config.inc.php`、`ilo-fans-controller.php`、および `favicon.ico` をそこにコピーしてください。


    ```sh
    sudo mkdir /var/www/html/ilo-fans-controller
    sudo cp config.inc.php ilo-fans-controller.php favicon.ico /var/www/html/ilo-fans-controller/
    ```

    それから `ilo-fans-controller.php` を `index.php` にリネームします（URLでファイル名を指定せずに動作させるため）：

    ```sh
    sudo mv /var/www/html/ilo-fans-controller/ilo-fans-controller.php /var/www/html/ilo-fans-controller/index.php
    ```

3. これで完了です！ツールには `http://<your-server-ip>/ilo-fans-controller/` （またはAPIリクエストの場合は `http://<your-server-ip>/ilo-fans-controller/index.php`）でアクセスできます。

> ℹ **注意：** このツールをインストールしたウェブサーバーが**ネットワーク外部からアクセス可能な場合は**、必ず**認証の設定**（Basic認証など）を行い、_午前2時の無許可ファン制御_を防いでください。

---

## トラブルシューティング

問題が発生したら、まずは**ログを確認する**ことが重要です。

> Apacheを使用している場合、PHPのエラーは `/var/log/apache2/error.log` ファイルに記録されます。

バグを見つけたと思われる場合は、[issueを開いて](https://github.com/alex3025/ilo-fans-controller/issues)ください。確認いたします。

以下に一般的な問題とその解決策を示します。

### プリセットが保存されない

新しいプリセットを作成した際にログに以下のエラーが表示される場合：

```log
PHP Warning:  file_put_contents(presets.json): Failed to open stream: Permission denied in .../index.php on line X
```

これはおそらく、`presets.json` ファイルがウェブサーバーユーザーによって書き込み可能でないためです。<br>
これを修正するには、次のコマンドを実行してファイルの所有者を `www-data`（デフォルトのApacheユーザー）に変更してください：

```sh
sudo chown www-data:www-data /var/www/html/ilo-fans-controller/presets.json
```

---

## APIドキュメント

このツールは以下の操作に使用できるシンプルなAPIを提供します：

* iLOから現在のファンスピードを取得する
* ファンスピードを設定する
* すべてのプリセットを取得する
* プリセットを作成する

> 以下の例ではcURLを使用してAPIの使い方を示していますが、他の任意のツールを使用してもかまいません。

### ファンAPI

以下のAPIを使用するには、URLの末尾に`?api=fans`を追加する必要があります。

#### ファンスピードの取得（`GET`）

<details>
<summary>JSON構造（レスポンス）</summary>

```jsonc
{
    "Fan 1": 85,
    "Fan 2": 48,
    "Fan 3": 69,
    "Fan 4": 18,
    "Fan 5": 44,
    "Fan 6": 96
}
```

</details>

<details>
<summary>cURLの例</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=fans'
```

</details>

#### ファンスピードの設定（`POST`）

<details>
<summary>JSON構造の例</summary>

```jsonc
{
    "action": "fans",
    // You can use either an object or a single number value (that will be applied to all fans):
    // Example: `fans: { ... }` or `fans: 50`
    "fans": {
        "Fan 1": 40,
        "Fan 2": 23,
        "Fan 5": 70
        // ...
    }
}
```

</details>

<details>
<summary>cURLの例</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "fans", "fans": 50}'
```
このコマンドはすべてのファンを50%に設定します。<br>
_私は個人的にサーバー起動時にファンを自動的に遅くするためにこのコマンドを使用しています。_
</details>

### プリセットAPI

以下のAPIを使用するには、URLの末尾に `?api=preset` を追加する必要があります。

#### すべてのプリセットを取得 (`GET`)

<details>
<summary>JSON構造（レスポンス）</summary>


```jsonc
[
    {
        "name": "Silent Mode",
        "speeds": [15]  // Like when setting the speeds, this number applies to all fans.
    },
    {
        "name": "Normal Mode",
        "speeds": [50]
    },
    {
        "name": "Turbo Mode",
        "speeds": [100]
    },
    {
        "name": "My Custom Preset",
        "speeds": [10, 10, 25, 30, 10, 15]  // Here you can see the different speeds for each fan.
    }
]
```

</details>

<details>
<summary>cURL の例</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=presets'
```

</details>

#### プリセットの作成 (`POST`)

<details>
<summary>JSON構造の例</summary>

```jsonc
{
    "action": "presets",
    // WARNING: The API will replace all the saved presets with the new data!
    // To add a preset you should get all the presets first and then add the new one to the existing array.
    "presets": [
        {
            "name": "Silent Mode",
            "speeds": [15]
        },
        {
            "name": "Normal Mode",
            "speeds": [50]
        },
        {
            "name": "Turbo Mode",
            "speeds": [100]
        },
        {
            "name": "My Custom Preset",
            "speeds": [10, 10, 25, 30, 10, 15]
        }
    ]
}
```

</details>

<details>
<summary>cURL の例</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "presets", "presets": [{"My Custom Preset 1": [50], "My Custom Preset 2": [10, 20, 30, 30, 20, 10]}]}'
```

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-10

---