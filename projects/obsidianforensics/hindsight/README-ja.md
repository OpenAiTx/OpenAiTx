<img src="https://raw.githubusercontent.com/obsidianforensics/hindsight/main/./pyhindsight/static/h.png" height="100px"/> Hindsight
=========

Google Chrome/Chromiumのインターネット履歴フォレンジック

Hindsightはウェブアーティファクトを解析する無料ツールです。Google Chromeウェブブラウザの閲覧履歴から始まり、他のChromiumベースのアプリケーションもサポートするよう拡張されています（今後さらに対応予定！）。HindsightはURL、ダウンロード履歴、キャッシュ記録、ブックマーク、自動入力記録、保存パスワード、設定、ブラウザ拡張機能、HTTPクッキー、ローカルストレージ記録（HTML5クッキー）など、さまざまな種類のウェブアーティファクトを解析できます。各ファイルからデータを抽出した後、他の履歴ファイルのデータと相関付けされ、タイムラインに配置されます。

シンプルなウェブUIを備えており、起動するには "hindsight_gui.py"（Windowsではパッケージ化された "hindsight_gui.exe"）を実行し、ブラウザで http://localhost:8080 にアクセスしてください：

<img src="https://raw.githubusercontent.com/obsidianforensics/hindsight/main/documentation/interface-v2.gif"/>

必須入力フィールドは「Profile Path」のみです。これは解析したいChromeプロファイルの場所です（異なるOSのデフォルトプロファイルパスはこのページ下部に記載）。「Run」をクリックすると結果ページに移動し、結果をスプレッドシート（または他の形式）で保存できます。

## 手動インストール

Hindsight（コマンドラインツールとウェブインターフェイスの両方）をインストールするには、以下を実行してください：
```sh
pip install pyhindsight
pip install git+https://github.com/cclgroupltd/ccl_chromium_reader.git
```
<translate-content>
Hindsightのウェブインターフェースで「ブラウザでSQLite DBを見る」機能を使用したい場合は、別のインストールコマンドを実行する必要があります：</translate-content>
```sh
curl -sSL https://raw.githubusercontent.com/obsidianforensics/hindsight/master/install-js.sh | sh
```
## コマンドライン

Hindsightにはコマンドライン版もあります - hindsight.py または hindsight.exeです。ドキュメントフォルダ内のユーザーガイドには多くのトピックが含まれていますが、以下の情報がコマンドライン版の開始に役立つはずです：

使用例:  \> C:\\hindsight.py -i "C:\Users\Ryan\AppData\Local\Google\Chrome\User Data\Default" -o test_case

コマンドラインオプション:

| オプション         | 説明                                               |
| -------------- | -------------------------------------------------- |
| -i または --input  | Chrome(ium)の「Default」ディレクトリへのパス |
| -o または --output | 出力ファイル名（拡張子なし） |
| -f または --format | 出力形式（デフォルトはXLSX、他の選択肢はSQLiteおよびJSONL） |
| -c または --cache  | キャッシュディレクトリへのパス；指定された「input」ディレクトリ外にある場合のみ必要。Macシステムはデフォルトでこの設定です。 |
| -b または --browser_type | 入力ファイルが属するブラウザの種類。対応しているのはChrome（デフォルト）とBraveです。 |
| -l または --log	 | Hindsightがログを記録する場所（存在する場合は追記されます） |
| -h または --help   | これらのオプションとデフォルトのChromeデータの場所を表示 |
| -t または --timezone | XLSX出力のタイムスタンプに表示するタイムゾーン |

## デフォルトプロファイルパス

Chromeのデフォルトプロファイルフォルダのデフォルト場所は以下の通りです：
* WinXP:   \[userdir\]\Local Settings\Application Data\Google\Chrome\User Data\Default
* Vista/7/8/10: \[userdir\]\AppData\Local\Google\Chrome\User Data\Default
* Linux:   \[userdir\]/.config/google-chrome/Default
* OS X:    \[userdir\]/Library/Application Support/Google/Chrome/Default
* iOS:   \Applications\com.google.chrome.ios\Library\Application Support\Google\Chrome\Default
* Android: /userdata/data/com.android.chrome/app_chrome/Default
* CrOS: \home\user\\<GUID\>

## 機能リクエスト

新機能のアイデアがある場合（または何か問題を見つけた場合）は、[issueを提出してください](https://github.com/obsidianforensics/hindsight/issues/new/choose)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---