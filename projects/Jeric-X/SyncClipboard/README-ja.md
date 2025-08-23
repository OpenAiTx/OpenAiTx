# SyncClipboard
[![build](https://github.com/Jeric-X/SyncClipboard/actions/workflows/build-entry.yml/badge.svg?branch=master)](https://github.com/Jeric-X/SyncClipboard/actions?query=branch%3Amaster)

中文 | [English](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/README_EN.md)  

<details>
<summary>目次</summary>

- [SyncClipboard](#syncclipboard)
  - [機能](#機能)
  - [サーバー](#サーバー)
    - [独立サーバー](#独立サーバー)
      - [サーバー設定](#サーバー設定)
      - [Docker](#docker)
      - [Arch Linux](#arch-linux)
    - [クライアント内蔵サーバー](#クライアント内蔵サーバー)
    - [WebDAVサーバー](#webdavサーバー)
  - [クライアント](#クライアント)
    - [Windows](#windows)
      - [ポータブル版](#ポータブル版)
      - [常駐除外](#常駐除外)
    - [macOS](#macos)
      - [手動インストール](#手動インストール)
      - [常駐除外](#常駐除外-1)
    - [Linux](#linux)
      - [手動インストール](#手動インストール-1)
      - [Arch Linux](#arch-linux-1)
      - [常駐除外](#常駐除外-2)
    - [デスクトップクライアントコマンドライン引数](#デスクトップクライアントコマンドライン引数)
      - [--shutdown-previous](#--shutdown-previous)
      - [--command-{command-name}](#--command-command-name)
    - [iOS](#ios)
      - [ショートカットの使用](#ショートカットの使用)
    - [Android](#android)
      - [HTTP Request Shortcutsの使用](#http-request-shortcutsの使用)
      - [Autox.jsの使用](#autoxjsの使用)
      - [SmsForwarderの使用](#smsforwarderの使用)
      - [Taskerの使用](#taskerの使用)
    - [クライアント設定説明](#クライアント設定説明)
  - [API](#api)
    - [クリップボードの取得/アップロード（テキスト）](#获取上传剪贴板文字)
    - [クリップボードの取得/アップロード（画像/ファイル）](#获取上传剪贴板图片文件)
    - [SyncClipboard.json](#syncclipboardjson)
  - [プロジェクト依存関係](#项目依赖)

</details>

## 機能

- クリップボード同期、テキスト、画像、ファイルに対応。サーバー/クライアント構成で、クライアント内蔵サーバー、独立サーバーのほか、WebDAV対応のクラウドストレージをサーバーとして利用可能  
- 画像タイプのクリップボードを最適化し、機能は以下の通り：
  - 任意の場所から画像をコピーした際、ファイルシステムに直接画像ファイルを貼り付け可能、逆も同様
  - ブラウザから画像をコピーした後、バックグラウンドで元画像をローカルにダウンロードし、動的画像のコピー不可問題を解決（多くのサイトで認証が必要なため適用範囲は限定的、bilibili動的画像に対応）
  - ファイルシステムから新しいフォーマットの画像ファイル（webp/heicなど）をコピーした場合、クリップボード内にgifまたはjpg形式で保存し、画像対応テキストボックスへ直接貼り付け可能

## サーバー
### 独立サーバー
[SyncClipboard.Server](https://github.com/Jeric-X/SyncClipboard/releases/)はクロスプラットフォームで動作し、[ASP.NET Core 8.0](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0)に依存しています。`ASP.NET Core ランタイム`をインストール後、以下のコマンドで起動します
```
dotnet /path/to/SyncClipboard.Server.dll --contentRoot ./
```
作業ディレクトリはdllがあるディレクトリと同じで、書き込み権限が必要です。作業ディレクトリを変更する場合は、`appsettings.json`を新しい作業ディレクトリにコピーし、`--contentRoot`の後のパスを変更してください  

#### サーバー構成
サーバーは`appsettings.json`ファイルを通じて構成され、形式は以下の通りです：
```jsonc
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Kestrel": {
    "Endpoints": {
      "http": {
        "Url": "http://*:5033"
      },
      //"https": {
      //  "Url": "https://*:5033"
      //}
    },
    //"Certificates": {
    //  "Default": {
    //    "Path": "/path/to/pem",
    //    "KeyPath": "/path/to/pem_key"
    //  }
    //}
  },
  "AppSettings": {
    "UserName": "your_username",
    "Password": "your_password"
  }
}
```
HTTPSを有効にするには、`https`および`Certificates`の部分のコメントを解除し、HTTPS証明書のパスを設定してください。最後に`http`部分をコメントアウトまたは削除して安全でない接続を無効にします。HTTPとHTTPSを同時に有効にする場合は、両者の`Url`を異なるポート番号に設定してください  
異なる種類の証明書の設定方法については[マイクロソフト公式ドキュメント](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel/endpoints?view=aspnetcore-8.0#configure-https-in-appsettingsjson)を参照してください

ユーザー名とパスワードは環境変数での設定をサポートしており、環境変数`SYNCCLIPBOARD_USERNAME`、`SYNCCLIPBOARD_PASSWORD`が両方とも空でない場合、これらの環境変数が優先的にユーザー名とパスワードとして使用されます  

環境変数`ASPNETCORE_hostBuilder__reloadConfigOnChange`はappsettings.jsonの変更を自動検出して設定をリロードするかどうかを設定するためのもので、デフォルト値は`false`です。`false`以外の値に変更するとこの機能が有効になります

> [!WARNING]  
> HTTPは平文での通信を行うため、公共ネットワークでサーバーを展開する場合はHTTPSを有効にするか、リバースプロキシツールを使用してHTTPSを設定してください。証明書発行機関から証明書を取得できない場合は、オープンソースツール[mkcert](https://github.com/FiloSottile/mkcert)やその他の方法で自己署名証明書を生成することを推奨します

#### Docker

```shell
# docker
docker run -d \
  --name=syncclipboard-server \
  -p 5033:5033 \
  -e SYNCCLIPBOARD_USERNAME=your_username \
  -e SYNCCLIPBOARD_PASSWORD=your_password \
  --restart unless-stopped \
  jericx/syncclipboard-server:latest

# docker compose
curl -sL https://github.com/Jeric-X/SyncClipboard/raw/master/src/SyncClipboard.Server/docker-compose.yml
docker compose up -d
```
HTTPSを構成する必要がある場合は、`appsettings.json`と証明書ファイルを手動でマッピングしてください。`appsettings.json`のコンテナ内パスは`/app/appsettings.json`です。

#### Arch Linux

[AUR](https://aur.archlinux.org/packages/syncclipboard-server)から直接インストールできます（[@devome](https://github.com/devome)によってメンテナンスされています）：

```shell
paru -Sy syncclipboard-server
```

設定ファイルのパスは`/etc/syncclipboard/appsettings.json`で、設定を変更した後は`systemctl`コマンドを使って起動してください：

```shell
sudo systemctl enable --now syncclipboard.service
```
### クライアント内蔵サーバー

デスクトップクライアント（Windows/Linux/macOS）にはサーバー機能が内蔵されており、視覚的なインターフェースで設定できます

### WebDAVサーバー
WebDAVプロトコルをサポートするクラウドストレージをサーバーとして使用可能  
テスト済みのサーバー：   

- [x] [Nextcloud](https://nextcloud.com/) 
- [x] [AList](https://alist.nn.ci/)
- [x] [InfiniCLOUD](https://infini-cloud.net/en/)
- [x] [aliyundrive-webdav](https://github.com/messense/aliyundrive-webdav)

## クライアント

デスクトップクライアント（Windows/Linux/macOS）はバックグラウンドで動作中にクリップボードを自動同期します
<details>
<summary>スクリーンショットの表示/非表示</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/WinUI.png)

</details>

### Windows
#### ポータブル版

[Release](https://github.com/Jeric-X/SyncClipboard/releases/latest)ページから名前が`SyncClipboard_win_`で始まるzipファイルをダウンロードし、解凍後に`SyncClipboard.exe`を実行してください

#### よくある問題と対処
- 対応最低システムバージョンはWindows10 2004です
- Windows 10でSyncClipboardを実行するとUIアイコンが大幅に崩れる場合は、Microsoftの[Segoe Fluent Icons](https://aka.ms/SegoeFluentIcons)アイコンフォントをインストールしてください

### macOS
#### 手動インストール
[Release](https://github.com/Jeric-X/SyncClipboard/releases/latest)ページから名前が`SyncClipboard_macos_`で始まるインストーラーをダウンロードし、ダブルクリック後にSyncClipboardアイコンをApplicationsフォルダへドラッグしてください

#### よくある問題と対処
- 「開発元を検証できないため、“SyncClipboard”を開けません」メッセージが表示される場合： 
macOSの「設定」->「プライバシーとセキュリティ」画面で「それでも開く」をクリックしてください

- システムが「SyncClipboardは破損しているため開けません」と表示する場合：ターミナルで`sudo xattr -d com.apple.quarantine /Applications/SyncClipboard.app`を実行してください
- ショートカットキーはアクセシビリティ権限に依存しており、ソフトウェアは必要に応じて許可を求めるポップアップを表示します

### Linux
#### 手動インストール
[Release](https://github.com/Jeric-X/SyncClipboard/releases/latest)ページから`SyncClipboard_linux_`で始まるインストーラーをダウンロードしてください

#### Arch Linux

Arch Linuxユーザーは[AUR](https://aur.archlinux.org/packages/syncclipboard-desktop)から直接インストール可能です（[@devome](https://github.com/devome)によってメンテナンスされています）：

```shell
paru -Sy syncclipboard-desktop
```
インストール後、メニューから起動してください。コマンドラインで`syncclipboard-desktop`コマンドを使用して起動時にエラーが発生する場合は、環境変数`LANG`を`en_US.UTF-8`に設定し、`LANG=en_US.UTF-8 syncclipboard-desktop`で起動してください。

#### トラブルシューティング
- クリップボードの同期が遅い、同期できない、アップロードした文字化け：システムに`xclip`（X11）または`wl-clipboard`（Wayland）をインストールすることを推奨します。SyncClipboardはこれらのツールを使用してクリップボード取得の安定性を向上させます。`xclip -version`または`wl-paste -version`コマンドでインストール確認可能
- `deb`、`rpm`パッケージでアップグレードが失敗した場合は、旧バージョンをアンインストールしてから新バージョンをインストールしてください
- `AppImage`パッケージを使用する場合は、AppImageファイルに実行権限があることを確認してください
- Wayland環境ではショートカットキーが使えない場合があります
- 言語を自動認識できない場合は英語がデフォルトです。起動後にSyncClipboardの設定で変更可能です

> [!NOTE]  
> SyncClipboardを完全に削除する場合は設定ファイルと一時ファイルのディレクトリも手動で削除してください：  
> `%AppData%\SyncClipboard\`(Windows)、`~/Library/Application Support/SyncClipboard/`(macOS)、`~/.config/SyncClipboard/`(Linux)

### デスクトップクライアントコマンドライン引数

#### --shutdown-previous
既に実行中のSyncClipboardを終了し、新しいインスタンスを起動します

#### --command-{command-name}
指定したコマンドを実行します。`{command-name}`はコマンド名で、ショートカットキー設定後に設定ファイルで確認可能です。ショートカットキー設定を解除してもコマンドライン引数は有効です  
既にSyncClipboardが実行中の場合は新しいインスタンスを起動せず、実行中のSyncClipboardにコマンドを実行させます。実行中のSyncClipboardがない場合は起動完了後に直ちにコマンドを実行します  
複数の`--command-{command-name}`引数を指定して複数コマンドを同時に実行可能です

> [!NOTE]  
> macOSでコマンドライン引数を使用する場合は、実行可能プログラムのフルパス`/Applications/SyncClipboard.app/Contents/MacOS/SyncClipboard.Desktop.MacOS`を使用してください

### IOS 
#### [ショートカット](https://apps.apple.com/cn/app/%E5%BF%AB%E6%8D%B7%E6%8C%87%E4%BB%A4/id1462947752)の使用  

- 手動同期：この[ショートカット](https://www.icloud.com/shortcuts/d1b9e49556e04c2ca290590294afbd99)をインポートし、手動でアップロードまたはダウンロードをトリガーします
- 自動同期：この[ショートカット](https://www.icloud.com/shortcuts/1ced32f011bc4d3498dca9960dc2c0d5)をインポートし実行すると、デバイスがバックグラウンドでクリップボード内容を自動同期します。このショートカットは無制限の実行時間となるため手動で停止が必要で、同期後の通知送信や問い合わせ間隔（秒数）を手動で変更できます
- SMS認証コードの自動アップロードは、こちらの投稿のビデオチュートリアルを参照してください https://github.com/Jeric-X/SyncClipboard/discussions/60

### Android
#### [HTTP Request Shortcuts](https://github.com/Waboodoo/HTTP-Shortcuts)の使用
この[設定ファイル](/script/shortcuts.zip)をインポートし、`変数`内の`UserName`、`UserToken`、`url`を変更してください。`url`はスラッシュ`/`で終わらないようにします。`HTTP Request Shortcuts`はドロップダウンメニュー、ウィジェット、ホーム画面アイコン、共有メニューから利用可能です

<details>
<summary>設定ファイルをインポート後の設定画面</summary>

![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android1.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android2.jpg)
![](https://raw.githubusercontent.com/Jeric-X/SyncClipboard/master/docs/image/android3.jpg)

</details>

#### 使用[Autox.js](https://github.com/kkevsekk1/AutoX)

- 自動同期、この[jsファイル](/script/SyncAutoxJs.js)を使用します。Androidシステムの制限により、Android 10以上のシステムではアプリがバックグラウンドでクリップボードを読み取ることができませんが、Root権限を利用したツール（Magisk/Xposed）を使ってアプリのバックグラウンドクリップボード読み取り権限を解除できます。例として[Riru-ClipboardWhitelist](https://github.com/Kr328/Riru-ClipboardWhitelist)、[Clipboard Whitelist](https://modules.lsposed.org/module/io.github.tehcneko.clipboardwhitelist)があります。Android 13以上ではユーザーが手動で許可しないとアプリがシステムログ（クリップボード）にアクセスできませんが、Xposedを使いアプリにシステムログアクセス権限を自動付与することも可能です。例：[DisableLogRequest/ログアクセス要求無効化](https://github.com/QueallyTech/DisableLogRequest)
- 自動で認証コードをアップロード、この[jsファイル](/script/UploadVerificationCode.js)を使用します。このスクリプトはバックグラウンドで動作し、すべての通知を読み取り、認証コードの通知を検出するとサーバーにコードをアップロードします。

jsファイルをインポートし、各ファイルのヘッダーにあるユーザー設定を修正後、手動で実行するか、または各jsファイルにトリガーを設定します。例：起動時トリガー

#### 使用[SmsForwarder](https://github.com/pppscn/SmsForwarder)

- 自動で認証コードをアップロード、 https://github.com/Jeric-X/SyncClipboard/discussions/109

#### 使用[Tasker](https://tasker.joaoapps.com/)

- https://github.com/forrestgao/taskerforSyncClipboard 、作者：[forrestgao](https://github.com/forrestgao)

TaskerはAndroid上の非常に強力な自動化ツールです。SyncClipboardのAPIを利用して、自分に合った設定ファイルを作成できます。もしあなたの設定ファイルが汎用的で共有したい場合は、ぜひご連絡ください。ここに掲載します。


### クライアント設定説明

全プラットフォームで必要な3つの設定があります（設定の綴りは異なる場合がありますが、意味は同じです）。
- user
- password
- url、形式は http(s)://ip（またはドメイン名）:port。WebDavサーバーを利用する場合、urlは既存のフォルダを作業ディレクトリとして指定する必要があります。例：`https://domain.com/dav/folder1/working%20folder`。特殊文字はURLエンコードしてください。このフォルダに他のファイルを保存しないでください。デスクトップクライアント（Windows/Linux/macOS）を使わない場合は、作業ディレクトリ内にさらに`file`フォルダを作成しファイル同期用にしてください。デスクトップクライアントはサーバー設定時に自動で`file`フォルダを作成します。urlは斜線`/`で終わらないようにしてください。一部クライアントで問題が発生します。

## API

APIはWebDAVに基づいています。独立したサーバー環境で環境変数ASPNETCORE_ENVIRONMENTをDevelopmentに設定しサーバーを起動するか、デスクトップクライアントでサーバーを起動し設定の診断モードを有効にすると、
`http://ip:ポート/swagger/index.html`にアクセスしてAPIページを開けます。以下は主要なAPIの一部です。

### クリップボードの取得/アップロード（テキスト）

```
GET /SyncClipboard.json
PUT /SyncClipboard.json
```
### クリップボードの取得/アップロード（画像/ファイル）

```
GET  /SyncClipboard.json
HEAD /file/filename         // optional
GET  /file/filename

PUT /file/filename
PUT /SyncClipboard.json
```

### SyncClipboard.json
```
{
    "Type" : "Text"
    "Clipboard" : "Content",
    "File":""
}

{
    "Type": "Image", // or "File", "Group"
    "Clipboard": "hash, optional",
    "File": "filename"
}
```

## 项目依赖
[NativeNotification](https://github.com/Jeric-X/NativeNotification)  
[Magick.NET](https://github.com/dlemstra/Magick.NET)  
[.NET Community Toolkit](https://github.com/CommunityToolkit/dotnet)  
[H.NotifyIcon](https://github.com/HavenDV/H.NotifyIcon)  
[WinUIEx](https://github.com/dotMorten/WinUIEx)  
[moq](https://github.com/moq/moq)  
[Avalonia](https://avaloniaui.net/)  
[FluentAvalonia.BreadcrumbBar](https://github.com/indigo-san/FluentAvalonia.BreadcrumbBar)  
[FluentAvalonia](https://github.com/amwx/FluentAvalonia)  
[Vanara](https://github.com/dahall/Vanara)  
[Tmds.DBus](https://github.com/tmds/Tmds.DBus)  
[SharpHook](https://github.com/TolikPylypchuk/SharpHook)  
[DotNetZip.Semverd](https://github.com/haf/DotNetZip.Semverd)  
[Quartz.NET](https://github.com/quartznet/quartznet)  
[MiSans](https://hyperos.mi.com/font)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---