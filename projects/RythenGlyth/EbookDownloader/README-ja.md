# EbookDownloader
購入した電子書籍をさまざまな出版社からダウンロードするツール。

![Preview](https://raw.githubusercontent.com/RythenGlyth/EbookDownloader/master/preview.png)

## 目次
- [対応出版社（ウェブサイト）](#supported-publishers-websites)
- [自動インストール](#automatic-installation)
- [手動インストール](#manual-installation)
- [実行方法](#running)
- [認証情報の保存](#saving-credentials-to-avoid-entering-them-every-time-optional)
- [Bildungslogin（Cornelsen / Westermann）](#bildungslogin)

## 対応出版社（ウェブサイト）
| 出版社 | ウェブサイト | 最高品質 | テキスト選択可能 | ハイパーリンク | 備考 |
| --- | --- | --- | --- | --- | --- |
| Cornelsen（「新方式」） | cornelsen.de | ロスレスPDF | &check; | &check; |  |
| Cornelsen（「旧方式」） | cornelsen.de | 画像（8617px x 11792px）合成 | &check; | &cross; |  |
| Cornelsen.CH | ebooks.cornelsen.ch | ロスレスPDF | &check; | &cross; |  |
| Cornelsen | scook.de | 画像（？）合成 | &cross; | &cross; | |
| Allango Klett | allango.net | ロスレスPDF | &check; | ? | [1] |
| Klett | klett.de | 画像（3072px x 4096px）合成 | &check; | &check; | |
| Westermann | westermann.de | 画像（2244px x 3071px）合成 | &check; | &cross; | |
| C.C.BUCHNER | click-and-study.de | 画像（1658px x 2211px）合成 | &check; | &cross; | |
| C.C.BUCHNER | click-and-teach.de | 画像（1658px x 2211px）合成 | &check; | &cross; | |
| Book2Look | book2look.com | ロスレスPDF | &check; | ? | [2] |
| kiosquemag | kiosquemag.com | 画像（？）合成 | &cross; | &cross; | |
| Helbling Media App | helbling.com | ロスレスPDF | &check; | &cross; | |

[1]: ウェブサイトは所有していないファイルのダウンロードを許可しています

[2]: アカウント不要、書籍IDのみで利用可能

## 自動インストール
まずリポジトリをクローンするかダウンロードしてください。

このツールは画像処理ライブラリを使用し、nodejsで実行するため、いくつかの依存関係が必要です。

インストールスクリプト（Windows用は`init.bat`、Debian系ディストリビューション用は`init.sh`）を使用するか、手動インストールを行うことができます。インストールスクリプトは必要な依存関係をすべてダウンロードします。実行するには、Windowsでは`.bat`ファイルをダブルクリックし、Linuxでは`.sh`ファイルに実行権限を付与してからターミナルで実行してください。

## 手動インストール
まず、リポジトリをクローンまたはダウンロードします。次に、以下のOS別の指示に従ってください：

### Windows
1. http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf から `unifont-15.0.01.ttf` をダウンロードし、プロジェクトのルートに置きます
1. `ffmpeg` をインストールし、ffmpeg実行ファイル（名前は `ffmpeg`）をプロジェクトのルートに置くか、パス環境変数に追加してください。ヘルプが必要なら [こちら](https://phoenixnap.com/kb/ffmpeg-windows) のチュートリアルを参照してください
1. `mutool` をインストールし、mutool実行ファイル（名前は `mutool`）をプロジェクトのルートに置くか、パス環境変数に追加してください。最新のビルドは [こちら](https://mupdf.com/releases) で見つけられます。リリースで `windows` を検索してください。（book2look と cornelsen.ch のみ必要）
1. `nodejs` と `npm` をまだインストールしていない場合は、[こちら](https://phoenixnap.com/kb/install-node-js-npm-on-windows) を参考にしてください
1. `npm install` を実行します
1. オプションで `image magick` をインストールし、magick実行ファイル（名前は `magick`）をプロジェクトのルートに置くか、パス環境変数に追加してください（cornelsen の「旧方式」のみ必要）

### Linux
1. `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"` を実行します
1. パッケージマネージャーを使い、`ffmpeg`、`nodejs`、`mutool`/`mupdf-tools`/`mupdf`（book2look と cornelsen.ch のみ必要）、およびオプションで `imagemagick`（cornelsen の「旧方式」のみ必要）をインストールします
1. `npm install` を実行します

### Linux/Darwin with Nix
- nix-direnv を使っている場合は、すべての依存関係を取得するために `direnv allow` を実行します
- それ以外の場合は、`nix-shell` を実行します
- `wget "http://www.unifoundry.com/pub/unifont/unifont-15.0.01/font-builds/unifont-15.0.01.ttf"` を実行します

## 実行
プロジェクトディレクトリで `npm install` を実行してセットアップを完了し、
プロジェクトディレクトリから `npm start` を実行してプログラムを起動します。

## 毎回入力する手間を省くための認証情報の保存（任意）
プログラム起動時に毎回認証情報を入力しなくて済むように、`config.json` ファイルに認証情報を保存できます。プロジェクトのルートに `config.json` という名前のファイルを作成し、以下の内容を追加してください：

```json
{
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    },
    "[PUBLISHER]": {
        "email": "[YOUR_USERNAME_OR_EMAIL]", 
        "passwd": "[YOUR_PASSWORD]"
    }
    [...]
}
```

Replace all the square brackets with your data. Publisher keys are: `cornelsen`, `klett`, `allango`, `scook`, `westermann`, `clicknstudy`, `clicknteach`, `kiosquemag`, `cornelsench`, `book2look`, `helbling`

## Bildungslogin

Cornelsen、Click-n-Study、Klett、およびWestermannはトークンログインをサポートしており、Bildungsloginアカウントを使用してログインできます。

### Cornelsen

1. Bildungsloginを開いてログインする  
1. ストレージ開発者ツールに入る（SHIFT+F9、または代わりにCTRL+SHIFT+Iを押してStorageタブをクリック）  
1. 本を開く  
1. 開発者ツールでLocal storageを選択する（場合によってはウェブサイトも選択する必要がある）  
1. 開いたテーブルを下にスクロールして`id_token`を見つける。長い英数字の文字列であるはず。  
1. それをコピーする。（ダブルクリックしてからCtrl+C）  
1. パスワードとして使用し、ユーザー名は`token`を使用する。  

### Click-and-Study

1. Bildungsloginを開いてログインする  
1. 本を開く  
1. ストレージ開発者ツールに入る（SHIFT+F9、または代わりにCTRL+SHIFT+Iを押してStorageタブをクリック）  
1. 開発者ツールでCookiesを選択する（場合によってはウェブサイトも選択する必要がある）  
1. 開いたテーブルを下にスクロールして`CASSID`を見つける。その後に英数字の文字列が続くはず。  
1. それをコピーする（ランダムに見える文字列）。（ダブルクリックしてからCtrl+C）  
1. パスワードとして使用し、ユーザー名は`token`を使用する。  

### Klett

1. Bildungsloginを開いてログインする  
1. 本を開く  
1. ストレージ開発者ツールに入る（SHIFT+F9、または代わりにCTRL+SHIFT+Iを押してStorageタブをクリック）  
1. 開発者ツールでCookiesを選択する（場合によってはウェブサイトも選択する必要がある）  
1. 開いたテーブルを下にスクロールして`SESSION`を見つける。その後に英数字の文字列が続くはず。  
1. それをコピーする（ランダムに見える文字列）。（ダブルクリックしてからCtrl+C）  
1. パスワードとして使用し、**現在アクセスしている書籍ビューアのURL**をユーザー名として使用する。  

### Westermann

1. Bildungsloginを開いてログインする  
1. 本を開く  
1. ネットワーキング開発ツールを開く（CTRL+SHIFT+E、またはCTRL+SHIFT+Iを押してNetworkタブをクリック）  
1. `Persist logs` にチェックを入れる（ギアメニューにある可能性が高く、右上あたり）  
1. ページをリロードする  
1. devtoolsの「Filter URLs」欄に `/api/user` と入力する  
1. OPTIONS と表示されていない最初のエントリをクリックする  
1. 横に小さなペインが開くはずです。そのHeadersタブをクリックする  
1. 「Filter headers」欄に `auth` と入力する（あれば）  
1. 長い英数字の文字列が見つかるまでスクロールする  
1. それをコピーしてテキストドキュメントに貼り付ける  
1. そこから再度コピーするが、「Authorization: Bearer 」の部分は選択せず、末尾の長い文字列のみを選択すること  
1. パスワードとして使用し、ユーザー名は `token` とする  

## 貢献について  

プロジェクトへの貢献として、Issueやプルリクエストの作成を自由に行ってください。  

## 免責事項  
このプロジェクトは教育目的のみです。本ソフトウェアの誤用に対してプロジェクトは一切の責任を負いません。あなたの管轄区域によっては、出版社の同意なしにこのソフトウェアを使用して電子書籍をダウンロードすることは違法となる場合があります。別の管轄区域では、個人利用のみのために電子書籍をダウンロードすることが合法である場合もあります。ソフトウェアを使用する前に必ず地元の法律を確認してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-02

---