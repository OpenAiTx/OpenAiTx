# getmic.ro

![Test](https://github.com/benweissmann/getmic.ro/workflows/Test/badge.svg)

[Micro](https://micro-editor.github.io/) をインストールする最速の方法

```Bash
# local install just for your user
curl https://getmic.ro | bash
```

あるいは、`curl`の代わりに`wget`を使用し、`bash`の代わりに任意の`sh`シェルインタプリタを使用する場合：

```Bash
# local install just for your user
wget -O- https://getmic.ro | sh
```
このスクリプトは、現在のディレクトリにmicroをインストールします。別の場所にインストールする場合（例：/usr/local/bin）、そのディレクトリに移動して書き込み権限があることを確認してください。例：`cd /usr/local/bin; curl https://getmic.ro | sudo sh` のようにします。


```Bash
# global install for all users
cd /usr/bin
curl https://getmic.ro | sudo sh
```
このスクリプトは、update-alternatives を使用して micro をシステムのテキストエディタとして登録することもできます。  
例えば、これにより `crontab -e` で cron ファイルを micro で開くことが可能になります。  

この機能を有効にするには、`GETMICRO_REGISTER` 変数を定義するか、  
URL `https://getmic.ro/r` を使用してください。これを行う際は、  
すべてのユーザーがアクセス可能なディレクトリ（通常は /usr/bin）に  
micro をインストールする必要があることに注意してください。

```Bash
# global install for all users, registering with update-alternatives
cd /usr/bin
curl https://getmic.ro/r | sudo sh
```

> 英語がわかりませんか？フランス語を話しますか？**フランス語の[*LISEZ-MOI*](https://raw.githubusercontent.com/benweissmann/getmic.ro/master/./README.fr.md)を見てください！**

## 高度な使い方

getmic.roでできる他のことがいくつかあります。以下に選択可能な環境変数を示します：

* `GETMICRO_HTTP=<COMMAND ...ARGS>`
    + このコマンドを引数とともにスペースで区切って使用し、インターネットからファイルをダウンロードします。
        - リダイレクト（HTTP Locationヘッダー経由）に必ず従う必要があります。
        - 結果のファイル内容を標準出力に出力する必要があります。
        - 次の引数としてダウンロードするファイルのURLを受け入れる必要があります。
        - GitHub認証のフォールバック用の非必須パラメータとして `--header` を受け入れることも可能です（任意）。
    + 例えば、`curl`を強制的に使うには、`curl https://getmic.ro | GETMICRO_HTTP="curl -L" sh` とします。
    + 例えば、`wget`を強制的に使うには、`wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" sh` とします。
* `GETMICRO_PLATFORM=[freebsd32 | freebsd64 linux-arm | linux-arm64 | linux32 | linux64 | linux64-static | macos-arm64 | netbsd32 | netbsd64 | openbsd32 | openbsd64 | osx | win32 | win64]`
    + これはプラットフォーム検出機構を手動で上書きし、指定したプラットフォーム用のバイナリをダウンロードします。
    + 例えば、互換性のないlibc実装（muslなど）を使う場合に、`https://getmic.ro | GETMICRO_PLATFORM=linux64-static sh` を指定します。
* `GETMICRO_REGISTER=[y | n]`
    + `update-alternatives` にmicroを登録して、システムのテキストエディタとしてシームレスに使えるようにするかどうか。
        - y => はい
        - n => いいえ（デフォルト）
    + GETMICRO_REGISTERが定義されていても、システムが`update-alternatives`をサポートしていなければ、このオプションは無視されます。
    + 有効にすると、getmicroは`update-alternatives`を使うために十分な権限（通常はrootユーザー）で実行されている必要があり、そうでなければエラーで終了します。
    + 省略形として、`https://getmic.ro/r` を使うと `GETMICRO_REGISTER=y` が定義されます。

まとめると、以下のコマンドラインは常にwgetを使い、常にlinux32バイナリをインストールし、常に`update-alternatives`に登録します：

```Bash
wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" GETMICRO_PLATFORM=linux32 GETMICRO_REGISTER=y sh
```

### スクリプトのチェックサムを検証する

スクリプトを検証するには、ダウンロードしてチェックサムを計算します。sha256 チェックサムは `d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35` です。

```Bash
gmcr="$(curl https://getmic.ro)" && [ $(echo "$gmcr" | shasum -a 256 | cut -d' ' -f1) = d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35 ] && echo "$gmcr" | sh
```
別の方法として、以下の手動による方法を使用できます。


```Bash
# 1. Manually verify that this outputs d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35
curl https://getmic.ro | shasum -a 256

# 2. If #1 was successful, then execute getmicro
curl https://getmic.ro | sh
```

## コントリビューティング

ご協力ありがとうございます！私たちはGithubのプルリクエストワークフローを使用しています：このリポジトリをフォークし、変更を加え、プルリクエストを提出してください。PRをマージするために必要なことがいくつかあります：

- すべてのテストが通ることを確認してください。PRページを開くとGithub Actionsがテストの失敗を報告します。

- 新しい動作を導入した場合は、その動作をテストするためにGithub Actionsのテスト（[`.github/workflows/test.yml`](https://github.com/benweissmann/getmic.ro/blob/master/.github/workflows/test.yml)）を更新してください。

- 新しいユーザー向けのオプションや動作を追加した場合は、その動作をドキュメント化するためにREADMEファイルを更新してください（対象ファイルの言語がわからない場合は翻訳しなくて構いません）。

これらの方法がわからない場合は、作業途中の状態でもかまいませんので、質問とともにPRを開いてください！

## 謝辞：

- Micro、もちろん：https://micro-editor.github.io/

- Chefのcurl|bashをゆるくベースにしています：https://docs.chef.io/install_omnibus.html

- ASCIIアートはfigletの提供によるもの：http://www.figlet.org/

<!--shasum=d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---