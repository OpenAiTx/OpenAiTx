# <a href="https://denchisoft.com"><img src="https://raw.githubusercontent.com/DenchiSoft/VTubeStudio/master/Images/vtube_studio_logo_nyan_2.png" width="542" /></a><br> [![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/DenchiSoft/VTubeStudio/blob/master/LICENSE) [![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=shield)](https://discord.gg/VTubeStudio) [![Stars](https://img.shields.io/github/stars/DenchiSoft/VTubeStudio?style=social)](https://github.com/DenchiSoft/VTubeStudio) [![Twitter Follow](https://img.shields.io/twitter/follow/VTubeStudio.svg?style=social)](https://twitter.com/VTubeStudio)


[![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=banner2)](https://discord.gg/VTubeStudio)

## [VTube Studioマニュアル](https://github.com/DenchiSoft/VTubeStudio/wiki)をお探しですか？

こちらで見つかります：https://github.com/DenchiSoft/VTubeStudio/wiki

## [VTube Studioプラグインの一覧](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins)をお探しですか？

こちらのページをご覧ください：https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins

## VTube Studio iPhoneアプリからトラッキングデータを受け取る方法を探している開発者ですか？

VTube Studio iOSアプリからトラッキングデータをリクエストする方法はこちらに記載されています：https://github.com/DenchiSoft/VTubeStudioBlendshapeUDPReceiverTest

## VTube Studioプラグインの作成方法を学びたい開発者ですか？

必要な情報はすべてこのページにあります。質問がある場合は[Discord](https://discord.gg/VTubeStudio)でお尋ねください。

## 目次

- [一般情報](#general-info)
- [法的情報](#legal-info)
- [利用可能なプラグインと例](#available-examples)
- [イベントAPI](#event-api)
- [API詳細](#api-details)
  - [APIパーミッション](#api-permissions)
  - [APIサーバー検出（UDP）](#api-server-discovery-udp)
  - [認証](#authentication)
  - [イベントの購読および購読解除](#subscribing-to-and-unsubscribing-from-events)
  - [現在のVTS統計情報の取得](#getting-current-vts-statistics)
  - [VTSフォルダーのリスト取得](#getting-list-of-vts-folders)
  - [現在読み込まれているモデルの取得](#getting-the-currently-loaded-model)
  - [利用可能なVTSモデルのリスト取得](#getting-a-list-of-available-vts-models)
  - [IDによるVTSモデルの読み込み](#loading-a-vts-model-by-its-id)
  - [現在読み込まれているVTSモデルの移動](#moving-the-currently-loaded-vts-model)
  - [現在または他のVTSモデルで利用可能なホットキーのリスト要求](#requesting-list-of-hotkeys-available-in-current-or-other-vts-model)
  - [ホットキーの実行要求](#requesting-execution-of-hotkeys)
  - [表情の一覧とその状態の要求](#requesting-current-expression-state-list)
  - [表情の有効化/無効化の要求](#requesting-activation-or-deactivation-of-expressions)
  - [現在のモデルのArtMesh一覧の要求](#requesting-list-of-artmeshes-in-current-model)
  - [ArtMeshに色を付ける](#tint-artmeshes-with-color)
  - [シーンの照明オーバーレイカラーの取得](#getting-scene-lighting-overlay-color)
  - [トラッカーが現在顔を検出しているかの確認](#checking-if-face-is-currently-found-by-tracker)
  - [利用可能なトラッキングパラメータ一覧の要求](#requesting-list-of-available-tracking-parameters)
  - [特定パラメータ（デフォルトまたはカスタム）の値を取得](#get-the-value-for-one-specific-parameter-default-or-custom)
  - [現在のモデル内のすべてのLive2Dパラメータの値を取得](#get-the-value-for-all-live2d-parameters-in-the-current-model)
  - [新しいトラッキングパラメータ（「カスタムパラメータ」）の追加](#adding-new-tracking-parameters-custom-parameters)
  - [カスタムパラメータの削除](#delete-custom-parameters)
  - [デフォルトまたはカスタムパラメータへのデータ入力](#feeding-in-data-for-default-or-custom-parameters)
  - [現在読み込まれているVTSモデルの物理設定の取得](#getting-physics-settings-of-currently-loaded-vts-model)
  - [現在読み込まれているVTSモデルの物理設定の上書き](#overriding-physics-settings-of-currently-loaded-vts-model)
  - [NDI設定の取得および設定](#get-and-set-ndi-settings)
  - [利用可能なアイテムやシーン内のアイテム一覧の要求](#requesting-list-of-available-items-or-items-in-scene)
  - [シーンへのアイテムの読み込み](#loading-item-into-the-scene)
  - [シーンからのアイテムの削除](#removing-item-from-the-scene)
  - [アイテムおよびアイテムアニメーションの制御](#controling-items-and-item-animations)
  - [シーン内のアイテムの移動](#moving-items-in-the-scene)
  - [アイテムのモデル内ソート順の設定](#set-item-within-model-sorting-order)
  - [ユーザーにArtMesh選択を促す](#asking-user-to-select-artmeshes)
  - [モデルへのアイテムのピン留め](#pin-items-to-the-model)
  - [ポストプロセス効果の一覧と状態の取得](#get-list-of-post-processing-effects-and-state)
  - [ポストプロセス効果の設定](#set-post-processing-effects)
  
## 一般情報

VTube Studioには**公開API**があります。これは、ホットキーのトリガー、顔トラッキングデータの入力、アイテムの読み込み、モデルの読み込み、各種イベントの通知取得、モデルのArtMeshの色付けなどを行うプラグインやスクリプトを作成できることを意味します。

VTube Studioで使えるプラグインやアプリを開発した場合は、PRを開いていただければこのページのリストに追加します。

## 法的情報

VTube Studio向けのプラグインは自由に作成・公開・販売できます。許可は不要で、ライセンス料やロイヤリティもありません。

## 利用可能な例

VTube Studioのユーザーで使えるプラグインを探している場合は、[プラグイン一覧のWikiページ](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins)をご覧ください。

もしあなたがVTube Studio APIをアプリに統合しやすくするための例やライブラリを探している開発者であれば、以下の表をご覧ください。

:warning: **もし何か作成してここに掲載したい場合は、修正した表と共にプルリクエストを開いてください！！** :warning:

| プラグイン | 開発者 | タイプ | 説明 |
| --- | --- | --- | --- |
| [Cheers Bot](https://cheers.hawk.bar/) | [Hawkbar](https://twitter.com/HawkbarGaming) | アプリ | チャット参加者がチャンネルポイントを使用した際にVTube Studioでアクションをトリガーできる、Twitch連携のウェブベースプラットフォームなど多くの機能を持つ。 |
| [VTubeStudioJS](https://github.com/Hawkbat/VTubeStudioJS) | [Hawkbar](https://twitter.com/HawkbarGaming) | ライブラリ | 他のプラグイン開発者向けのJavaScriptライブラリで、VTube StudioのWebSocket APIを実装。NodeJSとブラウザ両方に対応。 |
| [VTS Linker - SMB1](https://github.com/Renpona/VTStudio-Linker-SMB1) | [Renpona](https://twitter.com/renpona) | 例 | エミュレートされたスーパーマリオブラザーズのデータを読み取り、そのデータに基づきゲーム内の状況に応じてVTSのLive2Dモデルを自動で移動・色変更するプロトタイプ。 |
| [VTchaos](https://github.com/Raelice/VTchaos) | [Raelice](https://twitter.com/theraelice) | アプリ | YouTubeとTwitchのチャットを読み取り、チャットコマンドでモデルの切り替え、回転、ホットキー、移動などをVTube Studioで実行するプログラム。 |
| [Mix It Up](https://mixitupapp.com/) | [Mix It Up](https://twitter.com/mixitupapp) | アプリ | チャットやイベントなど多彩な機能を持つストリーミングソフトウェアボット！ |
| [VsPyYt](https://github.com/mlo40/VsPyYt) | [emlo40](https://emlo40.com) | アプリ/フレームワーク | YouTubeチャットを読み取りtoken.jsonに保存されたコマンドを実行できるコマンドプロンプトアプリ。VTube Studioと連携するPythonプログラムの基盤としても使用可能。 |
| [VTS-Sharp](https://github.com/FomTarro/VTS-Sharp) | [Skeletom](https://www.twitter.com/FomTarro) | ライブラリ | Unity/C#向けのライブラリで、VTube StudioのWebSocket APIを実装。他のプラグイン開発者向け。 |
| [node-red-contrib-vts](https://github.com/eslym/node-red-contrib-vts) | [0nepeop1e](https://github.com/eslym) | ライブラリ | Node-REDでVTube Studioと連携するためのノードを提供するライブラリパッケージ。 |
| [VTS Mod](https://github.com/MechaWolfVtuberShin/VTS-Mod/releases/tag/vts-mod) | [MechaWolfVtuber_Shin](https://github.com/MechaWolfVtuberShin) | アプリ | モデルの表面色（RGB含む）を変更したり、モデルの回転を変更したりできるプログラム。 |
| [Tie Tools: VTS Color Editor](https://tie-tools.tiberiusx.me) | [Prof. Tiberius](https://www.twitter.com/prof_tiberius) | アプリ | モデルの特定部位の色や不透明度を詳細に調整できるウェブアプリ。 |
| [vtubestudio-rs](https://github.com/walfie/vtubestudio-rs) | [Walfie](https://www.twitter.com/walfieee) | ライブラリ | 他のプラグイン開発者向けのRustライブラリで、VTube StudioのWebSocket APIを実装。 |
| [vts-heartrate](https://skeletom-ch.itch.io/vts-heartrate) | [Skeletom](https://www.twitter.com/FomTarro) | アプリ | リアルタイム心拍数データをVTube Studioに接続し、動的なモデルの色調変化や脈拍に基づくカスタム追跡パラメータを提供するプラグイン。 |
| [vts-chameleon](https://satetsu888.github.io/vts-chameleon/) | [satetsu888](https://www.twitter.com/satetsu888) | アプリ | 色調を適用するプラグイン。髪、肌、制服などモデルの色調を自由に変更可能。 |
| [ViewLink](https://kawaentertainment.itch.io/viewlink) | [KawaEntertainment](https://twitter.com/kawa_entertain) | アプリ | VRゲーム配信したいがLive2Dモデルしか持っていないVTuber向け。ViewLinkを使えば特別な設定や追加ハードなしでLive2DアバターをVRゲームプレイに反応させられる。 |
| [VTS Desktop Audio](https://lualucky.itch.io/vts-desktop-audio-plugin) | [Lua Lucky](https://twitter.com/LuaVLucky) | アプリ | デスクトップオーディオをVTSの入力パラメータとして利用できるプラグイン。 |
| [pyvts](https://github.com/Genteki/pyvts) | [Genteki](https://github.com/Genteki) | ライブラリ | VTube Studio APIと連携するPythonライブラリ。 |
| [DSYS: Dummy System](https://github.com/chuigda/Project-WG/tree/master/extra/dsys) | [Chuigda](https://github.com/chuigda) | アプリ | VTSモデルパラメータの記録・再生・半自動操縦ができるシンプルなプラグイン。 |
| [SAMMIVtubeStudioExtension](https://github.com/HueVirtualCreature/SAMMIVtubeStudioExtension) | [hue](https://twitter.com/Hue_SwordDevil) | プラグイン | ストリーム自動化ツール[SAMMI](https://sammi.solutions/)用のプラグイン。 |
| [Streamer.bot](https://streamer.bot) | [Streamer.bot](https://streamer.bot) | アプリ | 公式の[VTubeStudio統合](https://docs.streamer.bot/guide/integrations/vtube-studio)を備えた高度なマルチプラットフォームストリーミングソフトウェア。 |
| [coovts](https://github.com/lgc2333/coovts) | [LgCookie](https://github.com/lgc2333) | ライブラリ | PythonでVTube Studioプラグインを作成するための別のライブラリ（開発初期段階）。完全な型ヒント・非同期設計・Pydanticベースのデータ検証。 |
| [VTS Terminal](https://www.nekomaido.com/plugin/vts-terminal) | [Neko Maido](https://www.nekomaido.com) | アプリ | 多くのユーティリティを提供し、ホットキーのトリガー、モデル位置や視覚効果の調整、Live2DモデルのPDFマニュアル生成が可能なプラグイン。 |

# イベントAPI

VTube Studioで発生するモデル読み込みやホットキー実行などのイベントに登録できる**イベントAPI**については、別のWikiページがあります。イベントに関するページを[こちら](Events/)でご確認ください。

# API詳細

VTube StudioのWebSocketサーバーは `ws://localhost:8001` で動作します。これはデフォルトですが、ユーザーはアプリ内でポートを変更することも可能です。WebSocketは一般的に`binary`と`text`メッセージをサポートしますが、VTube Studioは常に`text`メッセージで応答し、APIへも`text`メッセージを送信することが推奨されます。`binary`メッセージを送信する場合は、UTF-8でエンコードされていることを確認してください。

プラグインがWebSocketサーバーに接続できない場合は、ユーザーにポートが正しいか、ファイアウォールやアンチウイルスの設定で接続が妨げられていないか確認してもらってください。最も重要なのは、ユーザーにVTube Studioのメイン設定画面で「プラグインAPIアクセスを許可」するよう伝えることです。
また、プラグインが接続に使用するポートを設定できるように対応しているかも確認してください。


接続できる場合、最初に試せることはセッションの状態を確認することです。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "MyIDWithLessThan64Characters",
	"messageType": "APIStateRequest"
}
```
**`応答`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"messageType": "APIStateResponse",
	"requestID": "MyIDWithLessThan64Characters",
	"data": {
		"active": true,
		"vTubeStudioVersion": "1.9.0",
		"currentSessionAuthenticated": false
	}
}
```
すべてのリクエストには `"apiName" : "VTubeStudioPublicAPI"` と使用するAPIバージョン（最初のリリース時点では `"1.0"`）を含める必要があります。  
このAPIバージョンは、動作やペイロードに互換性のない変更が行われるまで同じままです。つまり、新しい機能（既存のペイロードに新しいフィールドを追加するなど）がバージョンを上げずにAPIに追加される場合があります。アプリがこれに対応でき、デシリアライズ時に未知のフィールドがあっても壊れないようにしてください。  

互換性のない変更の例としては、既存のフィールド名の変更やペイロードからの削除があります。互換性のない変更があった場合はAPIバージョンが上げられ、古いAPIもそのまま使用可能となります。  

すべてのリクエストに `"requestID"` フィールドを追加できます。これは任意ですが推奨されます。なぜなら、これによりレスポンスをリクエストごとに識別できるためです。  
このIDはVTube Studioのログにも記録され、エラーがあればそれとともにログに残ります。何か問題が発生した場合、このIDを参照してログのエラーを確認できます。  

同じIDを使っても、リクエストごとに異なるIDを使っても構いません。IDを指定する場合、ASCII文字のみを含み、1文字以上64文字以下である必要があります。  
`"requestID"` フィールドを追加しない場合、VTube Studioはリクエストに対してランダムに生成したUUIDを付与し、レスポンスで返します。  

`"currentSessionAuthenticated"` は現在のセッションが認証済みかどうかを示します。  

すべての可能なエラーIDは、[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) のページに一覧があります。  

接続後、クライアントはいつでも現在のアプリ状態の情報をポーリングできます。  

## APIの権限  

VTube Studio APIで提供される特定の機能は、認証後にプラグインがリクエストしなければならない追加の**権限**の背後にロックされています。iOSやAndroidの権限と同様に、これはプラグインがリスクや潜在的に危険な機能（任意の画像をアイテムとして読み込むなど）を使用する場合にユーザーが理解できるようにするためです。  

権限をリクエストすると、ポップアップが表示され、その権限の内容が説明されます。ユーザーは許可または拒否を選択できます。権限のリクエスト方法や必要な理由の詳細は、[permissionsページ](Permissions/)をご覧ください。  

[![VTube Studio Permission Request Screen](/Images/vts_api_permissions_1_transparent.png)](Permissions/)  

## APIサーバーの検出（UDP）  

VTube Studioは、ローカルネットワーク上でUDPのポート47779を通じてAPI状態をブロードキャストします。これは、ユーザーがAPIをオフにしていても2秒ごとに行われます。  
`instanceID` は、VTube Studioインスタンス起動時に生成されるランダムなIDです。このインスタンスが動作している間は変わらず、複数のVTube Studioインスタンスはそれぞれ異なるIDを持ちます。  

`windowTitle` はウィンドウのタイトルテキストです。Windowsでは、異なるVTSインスタンスで異なります。複数のインスタンスが起動されると、最初のインスタンスはタイトルが `VTube Studio`、2番目は `VTube Studio Window 2` となり、以下同様です。macOSでは、すべてのインスタンスでタイトルが `VTube Studio` となります。



```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1630159656406,
	"messageType": "VTubeStudioAPIStateBroadcast",
	"requestID": "VTubeStudioAPIStateBroadcast",
	"data": {
		"active": false,
		"port": 8001,
		"instanceID": "93aa0d0494304fddb057ae8a295c4e59",
		"windowTitle": "VTube Studio"
	}
}
```

## 認証

APIを使用する前に、一度認証を行う必要があります。そのために、プラグイン名と開発者名を提供してください。どちらも3文字以上32文字以下である必要があります。

これは、プラグイン用のトークンをリクエストすることで行います。以下のリクエストを送信してください：

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"pluginIcon": "iVBORw0.........KGgoA="
	}
}
```

ユーザーがAPIアクセスを有効にしている場合、VTS内にポップアップが表示され、ユーザーに `"My Name"` の `"My Cool Plugin"` プラグインがVTube Studioを制御することを許可するかどうかを尋ねます。 `"pluginIcon"` はオプションで追加可能です。これは正確に128x128ピクセルのbase64エンコードされたPNGまたはJPG画像でなければなりません。これを追加すると、ユーザーに表示されるプラグインアクセス要求ポップアップでアイコンが使用されます。ユーザーが「許可」をクリックすると、次の応答が得られます。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenResponse",
	"data": {
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

フィールド `"authenticationToken"` は、API 認証に使用されるトークンとなるASCII文字列を含みます。長さは最大64文字です。
アクセスが拒否された場合、以下のエラーが返されます：

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "APIError",
	"data": {
		"errorID": 50,
		"message": "User has denied API access for your plugin."
	}
}
```
ユーザーはいつでもVTube Studio内からプラグインのAPIアクセスを取り消すことができます。取り消された場合、リクエストを送信しようとするとこのエラーが発生します。この場合は再認証を試みることができます。

トークンは一度取得すれば十分です。このトークンを使って現在のセッションを認証できます。次のセッション（例えばVTSが再起動された場合やプラグインが何らかの理由でVTSに再接続する必要がある場合）でも、同じトークンを使って再度認証できるため、トークンを取得するリクエストを再度送信する必要はなく、ユーザーはプラグインの許可を一度だけ求められます。

1セッション分の認証を行うには、トークンを用いて以下のリクエストを送信してください：

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

`"pluginName"` と `"pluginDeveloper"` は、トークンを要求した際に使用した値と一致している必要があります。そうでないと認証リクエストは失敗します。

トークンが有効であり、ユーザーによってAPIアクセスが取り消されていなければ、次のような応答が得られます。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationResponse",
	"data": {
		"authenticated": true,
		"reason": "Token valid. The plugin is authenticated for the duration of this session."
	}
}
```

おめでとうございます。認証が完了し、VTube Studio APIを使用できます。

必須フィールドが欠落している場合、エラー応答が返されます。すべてのフィールドが存在し正しくフォーマットされているが、トークンが無効またはユーザーによって取り消されている場合、`"authenticated"`は`false`として返されます。

**`data`フィールドについての注意:** 一部のリクエストには`data`というJSONオブジェクトフィールドが含まれ、一部には含まれません。利便性のため、必要ないリクエストにもこのフィールドを含めることができます。空でも、`null`や`undefined`に設定してもVTube Studioは無視します。VTube Studioはすべてのリクエストに対してこのフィールドを返し、プラグインの逆シリアル化を容易にします。応答にデータがない場合、このフィールドは空のJSONオブジェクトになります。

**`timestamp`フィールドについての注意:** すべての応答には、リクエスト処理時のUNIXミリ秒タイムスタンプを含む`"timestamp"`フィールドもあります。リクエストに`"timestamp"`フィールドを含めることもできますが、無視されます。

## [イベント](Events/)の購読と購読解除

以前のAPIバージョンでは、ロードされたモデルやアイテムの情報をプラグインが繰り返しポーリングする必要がありました。現在、VTube Studioは**「イベント」**の購読をサポートしており、プラグインに関連する何かが起きるたびにメッセージを送信します。イベントにはアイテムのロード通知、トラッキングの喪失・回復、モデルのクリックなど多くの通知が含まれます。

イベントに関するページは[こちら](Events/)をご覧ください。

## 現在のVTS統計情報の取得

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "StatisticsRequest"
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "StatisticsResponse",
	"data": {
		"uptime": 1439384,
		"framerate": 73,
		"vTubeStudioVersion": "1.9.0",
		"allowedPlugins": 7,
		"connectedPlugins": 2,
		"startedWithSteam": true,
		"windowWidth": 1031,
		"windowHeight": 812,
		"windowIsFullscreen": false
	}
}
```
`"uptime"` は VTube Studio が起動してからのミリ秒数を含みます。 `"framerate"` は現在のレンダリングFPS値です。 `"allowedPlugins"` はユーザーが現在 VTube Studio の使用を許可しているプラグインの数、 `"connectedPlugins"` は現在 VTube Studio API に接続されているプラグインの数です。 `"startedWithSteam"` はアプリが Steam を使って起動された場合は true、それ以外は false（`.bat` ファイルを使って Steam なしで VTS を起動した場合）です。

ウィンドウの幅と高さはピクセル単位です。

## VTSフォルダーのリスト取得

さまざまな VTube Studio フォルダーの名前を返します。これらはゲームファイル内の `StreamingAssets` フォルダーにあります。

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoRequest"
}
```

**`レスポンス`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoResponse",
	"data": {
		"models": "Live2DModels",
		"backgrounds": "Backgrounds",
		"items": "Items",
		"config": "Config",
		"logs": "Logs",
		"backup": "Backup"
	}
}
```

## 現在読み込まれているモデルの取得

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "CurrentModelRequest"
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "CurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDToIdentifyThisModelBy",
		"vtsModelName": "Model.vtube.json",
		"vtsModelIconName": "ModelIconPNGorJPG.png",
		"live2DModelName": "Model.model3.json",
		"modelLoadTime": 3021,
		"timeSinceModelLoaded": 419903,
		"numberOfLive2DParameters": 29,
		"numberOfLive2DArtmeshes": 136,
		"hasPhysicsFile": true,
		"numberOfTextures": 2,
		"textureResolution": 4096,
		"modelPosition": {
			"positionX": -0.1,
			"positionY": 0.4,
			"rotation": 9.33,
			"size": -61.9
		}
	}
}
```

`"modelLoaded"` はモデルが現在読み込まれている場合に `true` になります。モデルが読み込まれていないか、読み込み中の場合は `false` になります。この場合、他のすべての値は空（整数の場合はゼロ）になります。

`"modelLoadTime"` は現在のモデルの読み込みにかかった時間をミリ秒単位で示します。`"timeSinceModelLoaded"` はモデルが読み込まれてからの経過時間をミリ秒単位で含みます。

`"vtsModelIconName"` はVTube Studioのモデル選択バーでこのモデルに使用されるアイコンの名前を含みます。モデルにアイコンが設定されていない場合、これは空の文字列になります。このリクエストで返されるファイル名はすべて、各モデルフォルダに対する相対パスです。

`"modelPosition"` 配列には現在のモデルの位置、回転、サイズが含まれます。これらの値の解釈方法の詳細は `MoveModelRequest` を参照してください。

## 利用可能なVTSモデルのリストを取得する

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AvailableModelsRequest"
}
```
**`応答`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AvailableModelsResponse",
	"data": {
		"numberOfModels": 2,
		"availableModels": [
			{
				"modelLoaded": false,
				"modelName": "My First Model",
				"modelID": "UniqueIDToIdentifyThisModelBy1",
				"vtsModelName": "Model_1.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			},
			{
				"modelLoaded": true,
				"modelName": "My Second Model",
				"modelID": "UniqueIDToIdentifyThisModelBy2",
				"vtsModelName": "Model_2.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			}
		]
	}
}
```
`"modelLoaded"` は、該当するモデルが現在 VTube Studio に読み込まれている場合は `true`、それ以外は `false` です。

## ID で VTS モデルを読み込む

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ModelLoadRequest",
	"data": {
		"modelID": "UniqueIDOfModelToLoad"
	}
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ModelLoadResponse",
	"data": {
		"modelID": "UniqueIDOfModelThatWasJustLoaded"
	}
}
```

アプリが現在モデルの読み込み/アンロードができない状態にある場合、この操作は失敗してエラーを返すことがあります。これには設定ウィンドウが開いている場合や、モデルの読み込み操作がすでに進行中の場合が含まれます。このリクエストにはグローバルで2秒のクールダウンもあります。

空のモデルIDを渡した場合、現在読み込まれているモデルがアンロードされます（モデルが読み込まれていなければ何もしません）。

## 現在読み込まれているVTSモデルの移動

モデルが読み込まれている場合、位置、回転、サイズを変更できます。モデルが読み込まれていなければエラーを返します。詳細は[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)を参照してください。

このリクエストで必要なフィールドは `"timeInSeconds"` と `"valuesAreRelativeToModel"` です。 `"timeInSeconds"` は移動にかける秒数で、0から2の間の浮動小数点値でなければなりません。0に設定すると、モデルは指定位置に即座に移動します。これより大きい値を設定すると、モデルは指定位置に滑らかに移動、回転、拡大/縮小します（フェードイン/アウトを伴います）。移動中はユーザーはドラッグでモデルを手動で動かせません。移動完了後約0.5秒で再び手動移動が可能になります。

進行中の `MoveModelRequest` があっても待たずに次のリクエストを送信できます。進行中のリクエストは中断され、新しいリクエストに置き換えられます。 `"timeInSeconds"` を0にして毎フレームリクエストを送れば、移動を完全に制御することも可能です。

`"size"` は -100（最小）から +100（最大）までの浮動小数点で指定します。 `"positionX"`, `"positionY"`, `"rotation"` については以下の画像を参照してください：

#### VTS座標系
![The VTS Coordinate System](/Images/coordinate_explanation.png)

猫の数字は `"positionX"` と `"positionY"` で渡せる **[X/Y]** 座標を表しています。たとえば [0/0] を送るとモデルの中央が画面中央に配置されます。「モデルの中央」が何かはLive2D Cubismで自由に設定でき、モデルによって異なります。もちろん、もっと大きい/小さい値を送ってモデルを画面外に移動させることも可能です。 `"positionX"` と `"positionY"` は -1000 から 1000 の範囲でなければなりません。

円周の数字は `"rotation"` で設定できる角度を表しています。この値は -360 から 360 の範囲で指定します。角度には時計回りが正、反時計回りが負の2通りの表現があります。どちらを使っても違いはありません。`CurrentModelRequest` を送るとレスポンスにモデルの位置/回転/サイズも含まれますが、その場合角度は常に正の表記になります。

リクエストにすべての値を含める必要はありません。位置だけ、回転だけ、その他の組み合わせだけを指定することもできます。リクエストに含まれない値は無視され、位置/回転/サイズの設定には影響しません。たとえば、X座標だけ変更し、他はそのままにすることが可能です。

`"valuesAreRelativeToModel"` が `false` の場合、リクエストの値は絶対値として扱われ、モデルはその位置に移動します。`"valuesAreRelativeToModel"` が `true` の場合、値は現在のモデル位置に対する相対値とみなされます。たとえばこれを `true` にして回転だけ10度指定した場合、モデルは現在の回転から時計回りに10度回転し、位置とサイズは変わりません。これは画面上の位置に関わらずモデルをその場で揺らすなどのエフェクト実装に非常に便利です。

モデルを固定ピクセル位置やピクセル単位で移動したい場合は、座標を自分で計算する必要があります。`StatisticsRequest` を使ってウィンドウの幅と高さをピクセル単位で取得し計算してください。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "MoveModelRequest",
	"data": {
		"timeInSeconds": 0.2,
		"valuesAreRelativeToModel": false,
		"positionX": 0.1,
		"positionY": -0.7,
		"rotation": 16.3,
		"size": -22.5
	}
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "MoveModelResponse",
	"data": { }
}
```


## 現在または他のVTSモデルで利用可能なホットキーのリスト要求

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelRequest",
	"data": {
		"modelID": "Optional_UniqueIDOfModel",
		"live2DItemFileName": "Optional_Live2DItemFileName"
	}
}
```
`"modelID"`（およびここでの `"data"` オブジェクト全般）はオプションです。提供されない場合、現在のモデルのホットキーが返されます。モデルIDが提供された場合、指定されたモデルIDのモデルのホットキーが返されます。そのIDのモデルが見つからない場合は、エラーが返されます（[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) の `ModelIDNotFound` を参照）。

これは任意の利用可能な Live2D アイテムのホットキーも返すことができます。そのためには、単に `"live2DItemFileName"` フィールドにアイテムのファイル名を渡してください。利用可能なすべての Live2D アイテムの（ユニークな）ファイル名は `ItemListRequest` を使って取得できます。

もし `"modelID"` と `"live2DItemFileName"` の両方が提供された場合は、 `"modelID"` のみが使用され、もう一方のフィールドは無視されます。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"availableHotkeys": [
			{
				"name": "My first hotkey",
				"type": "ToggleExpression",
				"description": "Toggles an expression",
				"file": "myExpression_1.exp3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith1",
				"keyCombination": [],
                		"onScreenButtonID": 8
			},
			{
				"name": "My second hotkey",
				"type": "TriggerAnimation",
				"description": "Triggers an animation",
				"file": "myAnimation.motion3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith2",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My third hotkey",
				"type": "ChangeVTSModel",
				"description": "Changes the VTS model",
				"file": "someOtherModel.vtube.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith3",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fourth hotkey",
				"type": "MoveModel",
				"description": "Moves the Live2D model",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith4",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fifth hotkey",
				"type": "Unset",
				"description": "No action set for hotkey",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith5",
				"keyCombination": [],
                		"onScreenButtonID": 5
			}
		]
	}
}
```

リクエストでモデルIDが指定されておらず、モデルがロードされていない場合、`"modelLoaded"` は false となり、`"availableHotkeys"` 配列は空になります。ID が指定されている場合、`"modelLoaded"` フィールドは、指定されたIDのモデルが現在ロードされているかどうかに応じて `true` または `false` になります。

`"file"` フィールドは、`TriggerAnimation`、`ChangeIdleAnimation`、`ToggleExpression`、および `ChangeVTSModel` タイプのホットキーに対応する表情/アニメーション/モデルのファイル名を含みます。`ChangeBackground` ホットキーの場合、ファイル拡張子なしの背景名が含まれます。その他すべてのタイプでは、空文字列が含まれます。

`"description"` フィールドには、ホットキーが何を行うかの説明が含まれています。ホットキーのタイプがプラグインで認識できない場合（例えば、VTube Studio に新しく追加されたホットキータイプの場合）、プラグインのUIにこの文字列を表示できます。

`"keyCombination"` 配列には、ホットキーをトリガーするキーボード（またはマウスキー）の組み合わせが含まれています。すべての可能な値については [RestrictedRawKey.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/RestrictedRawKey.cs) を参照してください。配列が空の場合、キーの組み合わせは設定されていません。**重要：** セキュリティ上の理由から、現在 `"keyCombination"` 配列は**常に空**であり、このデータは現時点でプラグインで利用できません。将来のアップデートで再度追加される可能性があります。

`"onScreenButtonID"` フィールドには、ホットキーをトリガーするすべての画面上ボタンID（1（上）から8（下）または -1）が含まれます。値が `-1` の場合、このホットキーに対して画面上ボタンは設定されていません。

すべてのホットキータイプの文字列は、[HotkeyActions.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/HotkeyAction.cs) のページで確認できます。

## ホットキーの実行をリクエストする

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerRequest",
	"data": {
		"hotkeyID": "HotkeyNameOrUniqueIdOfHotkeyToExecute",
		"itemInstanceID": "Optional_ItemInstanceIdOfLive2DItemToTriggerThisHotkeyFor"
	}
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerResponse",
	"data": {
		"hotkeyID": "UniqueIdOfHotkeyThatWasExecuted"
	}
}
```

これは、"itemInstanceID" を空にするか全く指定しない場合、現在読み込まれているVTube Studioモデルのホットキーをトリガーします。もしそのフィールドにIDを指定すると、代わりに指定されたLive2Dアイテムモデルのホットキーをトリガーします（詳細は下記参照）。

ホットキーは一意のIDまたはホットキー名（大文字小文字を区別しない）でトリガーできます。同じ名前のホットキーが複数ある場合、最初のものだけが実行されます（順序はUIに表示される順です）。名前が空のホットキーはIDでのみトリガー可能です。

ホットキーIDまたは名前が見つからない、または何らかの理由でホットキーを実行できない場合はエラーが返されることがあります。理由としては、現在モデルが読み込まれていない、またはホットキーのクールダウンが終了していない（特定のホットキーは5フレームごとに一度しかトリガーできません）などがあります。複数のホットキーを連続で送信すると、それらはキューに入ります。5フレームごとにキューから1つのホットキーが取り出され実行されます。キューの容量は32個です。キューが満杯でさらにホットキーを送ろうとするとエラーが返されます。

### Live2Dアイテム内のホットキーのトリガー

このリクエストはLive2Dアイテム内のホットキーをトリガーするのにも使えます。Live2Dアイテムの詳細は[こちらのページ](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)を参照してください。

方法は、"itemInstanceID" にLive2DアイテムのインスタンスIDを設定するだけです。指定したインスタンスIDのLive2Dアイテムが現在読み込まれていない場合はエラーが返されます。現在読み込まれている全アイテムのインスタンスIDを取得するには、`ItemListRequest` を使います。

## 現在の表情状態リストの取得

特定の表情、またはすべての表情の現在の状態（アクティブか非アクティブか）を取得できます。"expressionFile" を含めると、その表情のみの状態が返されます。含めないか空文字列の場合は、現在のモデルのすべての表情の状態が返されます。

ファイル名を指定しても無効（`.exp3.json`で終わっていない）か、現在のモデルに存在しない場合はエラーが返されます（"[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"を参照）。

"details" を true に設定すると、レスポンスにもう少し詳細が返されます（具体的には、"details" が false の場合、"usedInHotkeys" と "parameters" 配列は空になります）。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionStateRequest",
	"data": {
		"details": true,
		"expressionFile": "myExpression_optional_1.exp3.json",
	}
}
```

`expressions` 配列は、モデルがロードされていない場合は空になります。そうでなければ、現在ロードされているモデルの利用可能な表情に関する情報が含まれます。

`"file"` フィールドは、表情のファイル名で、モデルフォルダに保存されているものです。`"name"` は `.exp3.json` 拡張子を除いた同じ名前です。`"active"` はその表情が現在アクティブかどうかを示します。

表情がホットキーで有効化された場合、`"deactivateWhenKeyIsLetGo"` と `"autoDeactivateAfterSeconds"` は、それらのオプションが表情ホットキーに対して有効かどうかを示します。`"autoDeactivateAfterSeconds"` が `true` の場合、自動的に表情が無効化されるまでの残り時間が `"secondsRemaining"` に返されます（そうでなければ 0 です）。

リクエストで `"details"` が `true` に設定されていた場合、`"usedInHotkeys"` 配列にはこの表情が使用されているすべてのホットキーのリストが含まれます。また、`"parameters"` 配列には表情の内容、つまり表情で使用されているすべての Live2D パラメータ ID と目標値が含まれます。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionStateResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"expressions": [
			{
				"name": "myExpression_optional_1",
				"file": "myExpression_optional_1 .exp3.json",
				"active": false,
				"deactivateWhenKeyIsLetGo": false,
				"autoDeactivateAfterSeconds": false,
				"secondsRemaining": 0,
				"usedInHotkeys": [
					{
						"name": "Some Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith1"
					},
					{
						"name": "Some other Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith2"
					}
				],
				"parameters": [
					{
						"name": "SomeLive2DParamID",
						"value": 0
					}
				]
			}
		]
	}
}
```

## 表情の有効化または無効化のリクエスト

表情はホットキーで有効化することを推奨します。そうしないと、ホットキーが設定されていないために無効化できない有効化された表情がユーザーに残る可能性があるからです。ただし、プラグインで必要な場合はホットキーを直接有効化および無効化することもできます。これは、表情ファイル名と表情を有効化するか無効化するかを指定して行います。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionActivationRequest",
	"data": {
		"expressionFile": "myExpression_1.exp3.json",
		"fadeTime": 0.5,
		"active": true
	}
}
```

リクエストが成功した場合、この応答は空になります。ファイル名が無効（`.exp3.json`で終わらない）か、現在のモデルに存在しないか、モデルが読み込まれていない場合は、エラーが返されます（"[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"を参照）。
`fadeTime`パラメータは0秒から2秒の範囲に制限されます。デフォルトは0.25秒です。VTSアニメーションシステムの制限により、フェードイン中のみフェード時間を設定できます。表情をフェードアウトする場合、フェードイン時と同じ時間が常に使用されます。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionActivationResponse",
	"data": { }
}
```

## 現在のモデル内のArtMeshリストの要求

APIでは `ArtMesh Name` という用語を使用していますが、これは実際にはLive2D Cubism Editorによってモデルごとに一意に管理されるArtMesh IDを指します。`ArtMesh Tags` はArtMeshを選択し、UserDataフィールドに記入することで追加できます。タグを使用する場合は、`Export UserData file (userdata3.json)` にチェックを入れてください。その後、モデルをVTube StudioのLive2DModelsフォルダーにコピーする際に `.userdata3.json` ファイルを含める必要があります。

`"artMeshTags"` 配列に返されるArtMeshタグは重複するタグを含みません。

モデルがロードされていない場合、`"modelLoaded"` は `false` となり、配列は空になります。

**タグについての注意:** タグはLive2D Cubism Editorの「UserData」フィールドにArtMeshごとに追加できます。エディター内のそのフィールドに任意のテキストを入力可能です。VTube Studioはそのテキストをスペースと改行文字で分割します。つまり、タグテキストが「my tag」の場合、VTSでは「my」と「tag」の2つのタグになります。各ArtMeshに好きなだけタグを追加できます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshListRequest"
}
```

**`レスポンス`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshListResponse",
	"data": {
		"modelLoaded": true,
		"numberOfArtMeshNames": 5,
		"numberOfArtMeshTags": 2,
		"artMeshNames": ["ArtMesh1", "ArtMesh2", "HairFront1", "HairFront2", "SomeArtMesh"],
		"artMeshTags": ["my_tag", "SomeOtherTag"]
	}
}
```

## ArtMeshを色で着色する

色と一致基準を指定することでArtMeshを着色できます。指定された基準のいずれかに一致するArtMeshは、指定された色で着色されます。ArtMeshの色をリセットするには、白（R=G=B=A=255）で着色してください。このリクエストではArtMeshを白にすることはできず、暗くすることのみ可能です。

色の値のいずれかが指定されていなかったり、0〜255の範囲外の場合はエラーが返されます。モデルが読み込まれていない状態でこのリクエストを送信しようとするとエラーになります。

オプションで0から1の間の`mixWithSceneLightingColor`を指定できます。指定した場合、シーン照明システムの色と着色色の混合度を決定します（詳細は[こちら](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)を参照）。1に設定すると、指定した色がシーン照明の色を完全に上書きします。0にするとシーン照明の色が指定色を上書きします。その間の値は両者の色を混合します。シーン照明がオフの場合は効果がありません。`mixWithSceneLightingColor`を指定しない場合はデフォルトで1となり、指定色がシーン照明を完全に上書きします。

`"artMeshMatcher"`オブジェクト内の全ての配列は任意です。含めた場合、ArtMeshの名前またはタグが指定された文字列に完全一致するか、（`"nameContains"`/`"tagContains"`配列を使用した場合は）含むかどうかで選択します。`"artMeshNumber"`配列はモデル内の順序に基づきArtMeshを選択します。モデル全体を着色したい場合は、マッチャー配列を含めず、代わりに`"tintAll"`をtrueに設定してください。

セッションが切断されると、そのセッションで着色された全てのArtMeshはデフォルト（完全不透明の白）にリセットされます。複数のプラグインやセッションがArtMeshの色を上書きする場合、最も新しいリクエストで設定された色が適用されます。

マッチングは常に**大文字・小文字を区別せずに**実行されます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ColorTintRequest",
	"data": {
		"colorTint": {
			"colorR": 255,
			"colorG": 150,
			"colorB": 0,
			"colorA": 255,
			"mixWithSceneLightingColor": 1
		},
		"artMeshMatcher": {
			"tintAll": false,
			"artMeshNumber": [1, 3, 5],
			"nameExact": ["eye_white_left", "eye_white_right"],
			"nameContains": ["mouth"],
			"tagExact": [],
			"tagContains": ["MyTag"]
		}
	}
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ColorTintResponse",
	"data": {
		"matchedArtMeshes": 3
	}
}
```

## シーン照明オーバーレイカラーの取得

VTube Studioには、画面（macOS/Windows）または特定のウィンドウ（Windowsのみ）から取得した平均色でモデルにオーバーレイする機能があります。詳細は[こちらのドキュメントページ](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)をご覧ください。

APIを通じて、シーン照明オーバーレイシステムの現在のユーザー設定とカラーを取得できます。

レスポンスのトップレベルには、照明オーバーレイがオンかどうかを示す`active`フィールドがあります。`itemsIncluded`がtrueの場合、すべてのアイテムが照明オーバーレイの影響を受けます。`isWindowCapture`が`true`ならVTube Studioはウィンドウの平均色をキャプチャする設定です。`false`の場合は画面をキャプチャしています。

`baseBrightness`（0から100）、`colorBoost`（0から100）、`smoothing`（0から60）はユーザーがUIのスライダーで選択できる3つの値です。説明は[この機能のドキュメントページ](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)をご確認ください。

`leftCapturePart`、`middleCapturePart`、`rightCapturePart`は、キャプチャされたウィンドウまたは画面のそれぞれの部分の平均色を示します。`active`フィールドは、その画面部分がユーザーによって有効になっているかを示します。

すべての有効な画面部分から計算された平均色は`colorAvg`フィールド（R、G、Bは0から255）にあります。

ArtMeshesにオーバーレイされる最終色は`colorOverlay`フィールド（R、G、Bは0から459）にあります。これは255を超える値を許容します。最終色は次のように計算されます：

`colorAvg` *  (`colorBoost` / 50) + `WHITE_COLOR` * (`baseBrightness` / 100)

これによりR、G、Bは最大で2 * 255の値になることがあります。値は1.8 * 255 = 459で制限されています。

照明オーバーレイシステムがオフの場合、トップのペイロードレベルの`active`は`false`となり、すべての色は白で返されます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoRequest"
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoResponse",
	"data": {
		"active": true,
		"itemsIncluded": true,
		"isWindowCapture": false,
		"baseBrightness": 16,
		"colorBoost": 35,
		"smoothing": 6,
		"colorOverlayR": 206,
		"colorOverlayG": 150,
		"colorOverlayB": 153,
		"colorAvgR": 237,
		"colorAvgG": 157,
		"colorAvgB": 162,
		"leftCapturePart": {
			"active": true,
			"colorR": 243,
			"colorG": 231,
			"colorB": 234
		},
		"middleCapturePart": {
			"active": true,
			"colorR": 230,
			"colorG": 83,
			"colorB": 89
		},
		"rightCapturePart": {
			"active": false,
			"colorR": 235,
			"colorG": 95,
			"colorB": 101
		}
	}
}
```


## トラッカーによって顔が現在検出されているかの確認

顔が現在アクティブなトラッカー（ネットワーク/USB経由のスマートフォンまたはウェブカメラトラッカー）によって検出されているかどうかを返します。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "FaceFoundRequest"
}
```

**`レスポンス`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "FaceFoundResponse",
	"data": {
		"found": true
	}
}
```

## 利用可能なトラッキングパラメーターのリストの要求

現在VTube Studioで利用可能なパラメーターのリストを要求できます。
これにはすべての通常のパラメーターとプラグインによって作成されたすべてのカスタムパラメーターが含まれます。プラグインによって作成されたパラメーターは、VTube Studioのパラメーターリストから選択するとその旨が表示されます。また、作成したプラグインの名前も表示されます。

**重要:** これは大量のデータを返す可能性があります。高頻度（60FPS以上）でこのリクエストを送信することは推奨されません。遅いPCでパフォーマンス問題を引き起こす可能性があります。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InputParameterListRequest"
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InputParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"customParameters": [
			{
				"name": "MyCustomParamName1",
				"addedBy": "My Plugin Name",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName2",
				"addedBy": "My Plugin Name",
				"value": 0.833,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName3",
				"addedBy": "My Other Plugin Name",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		],
		"defaultParameters": [
			{
				"name": "FaceAngleX",
				"addedBy": "VTube Studio",
				"value": 45.78,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "FacePositionX",
				"addedBy": "VTube Studio",
				"value": 8.33,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			}
		]
	}
}
```
**注:** この例のペイロード内の `"defaultParameters"` 配列は不完全です。これは VTube Studio が提供するすべてのデフォルトの顔・マウスなどのトラッキングパラメータを含みます。

## 1つの特定のパラメータ（デフォルトまたはカスタム）の値を取得する

要求された入力パラメータが存在しない場合、エラーが返されます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterValueRequest",
	"data": {
		"name": "MyCustomParamName1"
	}
}
```

**`レスポンス`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterValueResponse",
	"data": {
		"name": "MyCustomParamName1",
		"addedBy": "My Plugin Name",
		"value": 12.4,
		"min": -30,
		"max": 30,
		"defaultValue": 0
	}
}
```

## 現在のモデルのすべてのLive2Dパラメータの値を取得する

モデルが読み込まれていない場合、エラーが返されます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "Live2DParameterListRequest"
}
```

**`レスポンス`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "Live2DParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"parameters": [
			{
				"name": "MyLive2DParameterID1",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyLive2DParameterID2",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		]
	}
}
```

モデルが読み込まれていない場合、`"modelLoaded"` は false となり、パラメータ配列は空になります。他のすべてのフィールドは空文字列になります。

## 新しいトラッキングパラメータ（「カスタムパラメータ」）の追加

独自の新しいトラッキングパラメータを追加して、VTube Studio のモデルで使用することもできます。これらは「カスタム」パラメータと呼ばれます。プラグインによって追加された後、ユーザーは Live2D パラメータマッピングの入力としてあなたのパラメータを選択できます。

パラメータ名は一意である必要があり、英数字（スペースは不可）で、4文字以上32文字以下でなければなりません。新しいトラッキングパラメータは次のように作成されます：

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterCreationRequest",
	"data": {
		"parameterName": "MyNewParamName",
		"explanation": "This is my new parameter.",
		"min": -50,
		"max": 50,
		"defaultValue": 10
	}
}
```

**`レスポンス`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterCreationResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

パラメーター名が無効な場合、リクエストは失敗しエラーを返すことがあります。

同じ名前のパラメーターが別のプラグインによってすでに作成されている場合も失敗します。同じプラグイン名で複数回パラメーターを作成すると、リクエストは成功します。その方法で `min`、`max`、および `defaultValue` の値を上書きすることも可能です。

最小値／最大値／デフォルト値は `-1000000` から `1000000` の間の浮動小数点数でなければなりません。min/max の値は実際にパラメーターで許容される最小値および最大値ではありません。これらは、このパラメーターを使って新しいパラメーターマッピングが作成される際にデフォルトの下限および上限値として使用される値です。

説明はオプションで、256文字未満の短い説明文で、パラメーターが何をするか、ユーザーがモデルでどのように使用すべきかを記述します。リクエストにこれを含めると、ユーザーがこのカスタムパラメーターの詳細を表示したときに表示されます。

VTSにはカスタムパラメーターのグローバル制限が300個、プラグインごとに100個の制限があります。これを超えて作成しようとするとエラーが返されます。

これらのカスタムパラメーターは、VTube Studio の設定の一部として `StreamingAssets` フォルダー内の `Config` フォルダーにある `custom_parameters.json` ファイルに保存されます。プラグインの認証トークンを取り消すと、そのプラグインが作成したすべてのカスタムパラメーターも削除されます。これらは使用された VTube Studio モデルには設定されたままですが、入力パラメーターが存在しないことを示すため赤文字で表示されます。プラグインはいつでも別のトークンを取得してこれらのパラメーターを再作成でき、動作を継続します。

## カスタムパラメーターの削除

カスタムパラメーターは削除できます。デフォルトパラメーターは削除できません。また、このセッションの認証に使用したプラグイン以外が作成したパラメーターも削除できません。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterDeletionRequest",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterDeletionResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

## デフォルトまたはカスタムパラメータへのデータ入力

任意のデフォルトまたはカスタムパラメータにデータを入力できます。これらのトラッキングパラメータは、読み込まれたVTube Studioモデルおよび読み込まれた[Live2Dアイテム](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)の入力として使用されます。

ペイロードは次のようになります：

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InjectParameterDataRequest",
	"data": {
		"faceFound": false,
		"mode": "set",
		"parameterValues": [
			{
				"id": "FaceAngleX",
				"value": 12.31
			},
			{
				"id": "MyNewParamName",
				"weight": 0.8,
				"value": 0.7
			}
		]
	}
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InjectParameterDataResponse",
	"data": { }
}
```
もし一つ以上のパラメータが存在しない場合、エラーペイロードが返されます。

値は `-1000000` から `1000000` の間の浮動小数点数でなければなりません。その範囲外の値もエラーを返します。

ウェブカメラ/iOS/Androidのトラッキングからこれらのパラメータの値が存在する場合、APIからの値がAPI経由でデータを送信し続ける限り、それらを上書きします。
プラグインで制御したいパラメータのデータは、**少なくとも1秒に1回**再送信する必要があります。これを怠ると、そのパラメータは「失われた」と見なされ、以前に制御していたものの値に戻ります。もし他に制御しているものがなければ、デフォルト値に戻ります。

オプションで `"weight"` パラメータを0から1の間で追加できます。これは、パラメータに送る `"value"` と顔トラッキングから設定された値を混合するために使えます。例えば、パラメータを50％顔トラッキングで、50％APIで制御することが可能です。ただし、一度に一つのAPIプラグインしか一つのパラメータを書き込めません。利用例としては、APIで制御を開始した瞬間に「ジャンプ」しないように顔トラッキングパラメータの制御をフェードイン/アウトすることなどがあります。リクエストに `"weight"` パラメータを含めない場合、値は1とみなされ、対象パラメータはプラグインから提供された値に即座に設定されます。

これらのパラメータは通常のトラッキングパラメータと同様に扱われることにも注意してください。そのため、VTube Studioのパラメータマッピングの通常の入力として選択でき、UIのスライダーでスムージングを適用できます。モデルが使用中にカスタムパラメータを削除しても問題は発生せず、いつでも再作成可能です。

オプションとして `"faceFound": true` を渡すことができ、これによりVTube Studioはユーザーの顔が検出されたとみなします。これにより「トラッキングロスト」アニメーションの再生タイミングを制御できます。

### 複数のプラグインで一つのパラメータを制御する

一般に、別のプラグインがすでに一つの（デフォルトまたはカスタム）パラメータを制御している場合、エラーが返されます。これは一度に一つのプラグインのみが特定パラメータを「設定」（上書き）できるためで、このリクエストのデフォルトモードです。 `"mode"` フィールドに値を指定しないか、`"set"` に設定した場合に使われるモードです。

代わりに `"mode"` フィールドを `"add"` に設定できます。これは送信した値を現在のパラメータ値に加算します。この場合 `"weight"` の値は使われません。複数のプラグインが同時に特定パラメータの `"add"` モードを使用可能です。これは **ボンク/投げ** タイプのプラグインやその他のユースケースに有用です。

## 現在読み込まれているVTSモデルの物理設定の取得

ユーザーはVTube Studioで物理設定をカスタマイズ可能です。次の設定を変更できます:

- **基本物理強度（モデル単位）:** 0（オフ）から100（最大）の整数。デフォルトは50で、Live2D Cubism Editorと同様の物理挙動になります。
- **基本風強度（モデル単位）:** 0（オフ）から100（最大）の整数。デフォルトは0。
- **物理乗数（物理グループ単位）:** 各物理グループ（Live2D Cubismで設定可能）に対して乗数を設定できます。基本物理値にこの値が乗算されて物理グループを処理します。0から2の浮動小数点数で、デフォルトは1で基本値は変更されません。
- **風乗数（物理グループ単位）:** 各物理グループに対して乗数を設定できます。基本風値にこの値が乗算されて風を処理します。0から2の浮動小数点数で、デフォルトは1で基本値は変更されません。

ユーザーが設定したこれらの値はAPI経由で読み取れ、一時的に上書きも可能です（`SetCurrentModelPhysicsRequest`を参照）。

現在読み込まれているモデルの値を読むには、次のリクエストを使用してください:


**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsRequest"
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"modelHasPhysics": true,
		"physicsSwitchedOn": true,
		"usingLegacyPhysics": false,
		"physicsFPSSetting": -1,
		"baseStrength": 50,
		"baseWind": 17,
		"apiPhysicsOverrideActive": false,
		"apiPhysicsOverridePluginName": "",
		"physicsGroups": [
			{
				"groupID": "PhysicsSetting1",
				"groupName": "Hair Front Physics",
				"strengthMultiplier": 1.5,
				"windMultiplier": 0.3
			},
			{
				"groupID": "PhysicsSetting2",
				"groupName": "Clothes Physics",
				"strengthMultiplier": 1,
				"windMultiplier": 2
			}
		]
	}
}
```
モデルが読み込まれていない場合、`modelLoaded` は `false` になります。その場合、他の値は意味を持たず、`physicsGroups` 配列は空になります。

モデルが読み込まれている場合、`modelHasPhysics` フィールドはモデルに有効な物理設定があるかどうかを示します。一部のモデルは物理設定がないか、破損した物理ファイルがあり、物理システムが正しく起動しません。`physicsSwitchedOn` は、ユーザーが VTube Studio でこのモデルに対して「物理を使用」トグルを有効にした場合に true になります。`usingLegacyPhysics` は「レガシー物理」トグルの状態です。

`physicsFPSSetting` はこのモデルの物理 FPS 設定を含み、30、60、120、または -1 で、-1 はユーザーが「アプリと同じ FPS を使用」を選択したことを示します。

`apiPhysicsOverrideActive` と `apiPhysicsOverridePluginName` フィールドは、プラグインが現在物理設定の一部をオーバーライドしているかどうかを示します。active フィールドが true の場合、name フィールドにはプラグイン名が入ります。物理システムを制御できるプラグインは同時に一つだけです。これは `SetCurrentModelPhysicsRequest` リクエストの説明にも含まれています。

`SetCurrentModelPhysicsRequest` を使って物理または風の基本値や乗数をオーバーライドした場合、これらの変更はこの取得リクエストには**反映されません**。自分でオーバーライドを管理する必要があります。

`physicsGroup` 配列についての注意：すべてのグループには ID がありますが、すべてのグループに名前があるわけではありません。その場合、対応する `groupName` フィールドは空文字列になります。

## 現在読み込まれている VTS モデルの物理設定をオーバーライドする

このリクエストを使って、現在読み込まれているモデルの物理設定をオーバーライドできます。一つのプラグインがこの API を通じて物理システムの制御を取得すると、最初のプラグインが制御権を放棄するまで他のプラグインはこの API を使えません。これを試みると、対応するエラーが返されます。詳細は "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"（`SetCurrentModelPhysicsRequestPhysicsControlledByOtherPlugin`）をご覧ください。モデルが読み込まれていない場合、現在のモデルに存在しない物理グループ ID を指定した場合、またはオーバーライドに値を指定し忘れた場合もエラーが返されます。

ユーザーが現在読み込まれているモデルの物理をオフにしている場合、この API で物理をオンにすることはできません。物理/風の基本値や乗数のオーバーライドのみ可能です。

上記の `GetCurrentModelPhysicsRequest` セクションで説明したように、物理/風の乗数の値は 0 から 2 の間、物理/風の基本値は 0 から 100 の整数であるべきです（これはアプリ上での表示方法にも準じます）。範囲外の値は自動的にクランプされます。

特定の物理グループの強さや風の乗数を設定したい場合は、`strengthOverrides` および `windOverrides` 配列を使用し、該当グループ ID と `setBaseValue` を false に設定してください。`setBaseValue` を true にすると、指定値が物理強度または風の基本値として設定され、特定のグループには適用されません。その場合はグループ ID (`id`) を空にして構いません。

一般的に、この API で設定した値はアプリ内でユーザーが設定した値をオーバーライドするために使われます。UI 上には表示されず、保存もされません。`overrideSeconds` で設定したタイマーが切れるとオーバーライド値は自動的に解除されます。オーバーライドを継続したい場合は、このリクエストを繰り返し送信する必要があります。

すべてのタイマーが切れると、API はプラグインが物理システムを制御していないとみなし、別のプラグインが制御を開始できるようになります。

オーバーライドタイマーの値は 0.5 秒から 5 秒の間である必要があります。範囲外の値は自動的にクランプされます。

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsRequest",
	"data": {
		"strengthOverrides": [
			{
				"id": "PhysicsSetting1",
				"value": 1.5,
				"setBaseValue": false,
				"overrideSeconds": 2
			}
		],
		"windOverrides": [
			{
				"id": "",
				"value": 85,
				"setBaseValue": true,
				"overrideSeconds": 5
			}
		]
	}
}
```

**`応答`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsResponse",
	"data": { }
}
```

## NDI設定の取得と設定

現在のNDI設定をAPI経由で取得および変更できます。これにより、NDIのオン/オフ切り替え、カスタム固定解像度の設定などが可能です。

NDIおよびVTube Studioでの使用方法については、こちらのページをご覧ください：https://github.com/DenchiSoft/VTubeStudio/wiki/Streaming-to-Mac-PC

`"setNewConfig"`を`false`に設定すると、現在の設定のみが返されます。その場合、他のフィールドは無視されます。`true`に設定すると、与えられた設定が有効であれば設定されます。

`"ndiActive"`はNDIのオン/オフを切り替えます。NDIがオンの場合、`"useNDI5"`はNDI 4ではなくNDI 5を使用します（NDI 5の使用を推奨します）。

`"useCustomResolution"`を`true`に設定すると、NDIストリームの解像度はVTube Studioウィンドウの解像度とは異なり、UIで設定されたカスタム解像度を使用します。この解像度は`"customWidthNDI"`および`"customHeightNDI"`フィールドを使ってAPI経由で変更することも可能です。両方とも256から8192の範囲内である必要があります。幅は16の倍数、高さは8の倍数でなければなりません。リクエストで両方を`-1`に設定すると、それらの設定をスキップし、ブール値フィールドのみを設定します。これにより、解像度を変更せずにNDIのオン/オフを切り替えることが可能です。

NDI解像度がウィンドウ解像度と異なる場合、VTube Studioは自動的にビデオストリームを切り取りおよびスケーリングします。VTube Studioは常にアスペクト比を正しく保つようにし、上下または左右の一部が切り取られる場合があります。

**重要:** このリクエストには3秒のクールダウン期間があります。あまりに早く連続して実行すると、`NDIConfigCooldownNotOver`タイプのエラーが返されます（"[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"を参照）。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "NDIConfigRequest",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```
レスポンスには現在の設定のみが含まれます（新しい設定の適用を要求した場合はその新しい設定）。レスポンス内の `"setNewConfig"` フィールドには特別な意味はありません。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "NDIConfigResponse",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```

## 利用可能なアイテムやシーン内のアイテムのリストをリクエストする

このリクエストでは、現在シーン内にあるアイテムのリストを取得できます。また、ユーザーのPC上で読み込み可能なLive2Dアイテムやアニメーションフォルダなどのアイテムファイルのリストも取得できます。

今すぐアイテムを読み込める注文スポットがどれか知りたい場合は、`"includeAvailableSpots"`を`true`に設定してください。そうでなければ、レスポンスの`"availableSpots"`配列は空になります。

今シーン内に読み込まれているアイテムを知りたい場合は、`"includeItemInstancesInScene"`を`true`に設定してください。そうでなければ、レスポンスの`"itemInstancesInScene"`配列は空になります。

読み込み可能なアイテムファイルを知りたい場合は、`"includeAvailableItemFiles"`を`true`に設定してください。そうでなければ、レスポンスの`"availableItemFiles"`配列は空になります。**重要：** これはユーザーのPCからアイテムファイルの全リストを読み込みます。アプリが一瞬遅くなる可能性があるため、`"includeAvailableItemFiles"`を`true`にしてこのリクエストを頻繁に使用しないでください。本当にアイテムファイルのリストを更新する必要がある場合のみ使用してください。それ以外の場合は`false`に設定してください。

#### 特定のアイテムでフィルタリングする

特定のアイテムインスタンスIDやファイル名を持つアイテムだけをリストに含めたい場合は、それぞれ`"onlyItemsWithInstanceID"`および`"onlyItemsWithFileName"`フィールドに指定できます。

シーン内に同じインスタンスIDを持つアイテムは最大で1つだけですが、同じファイル名を持つアイテムは複数読み込めるため、複数存在する可能性があります。

また、**アイテムのファイル名は一意**であり、同じファイル名のアイテムファイルが2つ存在することはありません。ファイル名は**大文字小文字を区別**するため、特定のファイルを指定する際は大文字小文字を変えないよう注意してください。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemListRequest",
	"data": {
		"includeAvailableSpots": true,
		"includeItemInstancesInScene": true,
		"includeAvailableItemFiles": false,
		"onlyItemsWithFileName": "OPTIONAL_my_item_filename.png",
		"onlyItemsWithInstanceID": "OPTIONAL_InstanceIdOfItemInScene"
	}
}
```
レスポンス内のフィールドはほとんど自明であるべきです。

filename はアイテムファイルの名前です。これはシーンにアイテムのインスタンスを読み込むために使用できる名前です。JPG/PNG/GIF アイテムの場合、これはファイル拡張子を含むフルファイル名（パスなし）です（例："my_item.jpg"）。アニメーションフォルダの場合はフォルダ名です。Live2D アイテムの場合もフォルダ名です。

アイテムタイプは `"type"` フィールドにあります。可能な値は `PNG`、`JPG`、`GIF`、`AnimationFolder` または `Live2D` です。もう一つの可能な値は `Unknown` です。これは API が更新される前に VTube Studio に別のアイテムタイプが追加された場合にのみ発生し得るもので、通常は起こりません。

`"canLoadItemsRightNow"` はユーザーが VTube Studio で特定のメニューやダイアログを開いている場合に `false` になることがあります。これは通常、アイテムの読み込みやホットキーの使用などの操作を防止します。

`"framerate"` と `"frameCount"` はアニメーションアイテム（GIF とアニメーションフレームフォルダ）のみで利用可能です。

`"pinnedToModel"` が true の場合、`"pinnedModelID"` はアイテムがピン留めされているモデルのモデルID（現在読み込まれているモデル）を含み、`"pinnedArtMeshID"` はアイテムがピン留めされている ArtMesh の ID を含みます。

`"includeAvailableItemFiles"` を `true` に設定すると、`"availableItemFiles"` にユーザーの `Items` フォルダ内の全アイテムファイルのリストが含まれます。ここで返されたファイル名を使用して、`ItemLoadRequest` を使ってシーンにアイテムを読み込むことができます。

**`RESPONSE`**

```json
{
    "apiName": "VTubeStudioPublicAPI",
    "apiVersion": "1.0",
    "timestamp": 1625405710728,
    "messageType": "ItemListResponse",
    "requestID": "SomeID",
    "data": {
        "itemsInSceneCount": 2,
        "totalItemsAllowedCount": 60,
        "canLoadItemsRightNow": true,
        "availableSpots":
	[
            -30,-29,-28,-27,-26,-25,-24,-23,-22,-21,-20,-19,-18,-17,-16,-15,-14,
            -13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,3,4,5,6,7,8,9,10,11,12,13,
            14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30
        ],
        "itemInstancesInScene": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "instanceID": "18de53dc47154b00afdd382a6ebd2194",
                "order": 1,
                "type": "Live2D",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 0.0,
                "frameCount": -1,
                "currentFrame": -1,
                "pinnedToModel": true,
                "pinnedModelID": "47c71722c5304a039b0570b60a189875",
                "pinnedArtMeshID": "D_FACE_00",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "instanceID": "716cddf2e12a438ab5da05bbbf8b341c",
                "order": 2,
                "type": "AnimationFolder",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 15.0,
                "frameCount": 7,
                "currentFrame": 0,
                "pinnedToModel": false,
                "pinnedModelID": "",
                "pinnedArtMeshID": "",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            }
        ],
        "availableItemFiles": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "type": "Live2D",
                "loadedCount": 1
            },
            {
                "fileName": "ANIM_headpat",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "workshop_2801215328_ANIM_loading gif",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "type": "AnimationFolder",
                "loadedCount": 1
            },
            {
                "fileName": "b_woozy (@denchisoft).png",
                "type": "PNG",
                "loadedCount": 0
            }
        ]
    }
}
```
## シーンへのアイテムの読み込み

このリクエストを使うと、シーンにアイテムを読み込むことができます。アイテムはユーザーのPC上の「Items」フォルダーから読み込まれます。

利用可能なアイテムファイルの一覧を取得するには、`ItemListRequest`を使用してください。その名前を`"fileName"`フィールドに使用できます。

アイテムは`"positionX/Y"`、`"size"`、`"rotation"`フィールドで位置調整・拡大縮小・回転が可能です。これらの値の使い方については、[VTube Studio座標系](#the-vts-coordinate-system)の画像を参照してください。サイズは`0`から`1`の間でなければならず、`0.32`がユーザーが手動で読み込んだときの「デフォルト」の大きさにだいたい相当します。

プラグインは自身のアイテムを必ず整理する必要があります。ユーザーが**「シーン内の全アイテムを削除」**ボタンを使わないとアクセスできなくなるような見えない場所にアイテムを放置してはいけません。これを簡単にするために、`"unloadWhenPluginDisconnects"`をtrueに設定できます。

`"fadeTime"`フィールドはアイテムのフェードイン・アウト時間（0～2秒）を指定します。0に設定するとアイテムは即座に表示されます。

シーン内でアイテムを読み込む際の描画順序は`"order"`フィールドで指定できます。その順序がすでに使用されている場合、次に高い空き順序で自動的に読み込まれ、すべての上位順序が埋まっている場合は下位順序をチェックします。指定した順序が使われている場合に読み込みを失敗させたい場合は、`failIfOrderTaken`をtrueにしてください。その場合、`ItemOrderAlreadyTaken`タイプのエラーが返されます（[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)参照）。

いくつかの値には制限があります。サイズは`0`～`1`、位置は`-1000`～`1000`（ただし画面端は`-1`/`1`）、フェード時間は`0`～`2`秒、スムージングは`0`～`1`でなければなりません。これらの制限を超えると`ItemLoadValuesInvalid`タイプのエラーが返されます。

### カスタムデータアイテム

プラグインはこのリクエストを使い、`customDataBase64`フィールドで任意のPNG/JPG/GIFデータ（base64エンコードされたJPG、PNG、またはGIFファイル）をアイテムとして読み込むこともできます。使わない場合は空またはNULLにしてください。

これを使うには、`LoadCustomImagesAsItems`権限が必要です。権限の申請方法は[permissionsページ](Permissions/)を参照してください。権限がない場合、カスタムデータ画像の読み込みを試みると`RequestRequiresPermission`エラーが返されます（[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)参照）。

任意のデータをアイテムとして読み込むには、`customDataBase64`にPNG、JPG、GIFファイルの有効なデータを含める必要があります。カスタムデータのLive2Dアイテムは現在対応していません。寸法は64～2048ピクセル（両端を含む）であり、データサイズは5MB未満（base64エンコード前のバイナリサイズ）でなければなりません。GIFの場合はフレーム数が1～1024で、すべてのフレームが同じサイズである必要があります。

カスタムデータを提供する場合でも、`fileName`フィールドにファイル名を指定しなければなりません。`fileName`は英数字（ハイフン含む）で、`.jpg`、`.png`、`.gif`のいずれかで終わり、長さは8～32文字（両端を含む）である必要があります。

カスタムデータの読み込みには2つの方法があります：
* カスタムデータアイテムを即座に読み込む。
* 小さなポップアップ（アイテムのサムネイル付き）をユーザーに表示し、読み込みの承認を求める。

ユースケースに応じて適切な方法を選択してください。プラグインがユーザーに問題を引き起こす可能性のある画像を読み込まないようにする責任はあなたにあります。

すぐに読み込みたい場合は、`customDataAskUserFirst`をfalseに設定してください。

ユーザーに最初にポップアップを表示したい場合は、`customDataAskUserFirst`をtrueに設定してください。そうすると以下のポップアップが表示されます：

![Custom Image Load Popup](/Images/vts_load_custom_image_1.png)

このようなポップアップは同時に6つまで表示可能で（ポップアップは縦に積み重ねられます）、すでに6つ表示されている場合、追加のリクエストはエラーになります。


ポップアップを表示する際、このリクエストの応答はユーザーが決定を下すまで返されません。ユーザーがカスタムデータ項目の読み込みを拒否した場合、エラー（`ItemCustomDataLoadRequestRejectedByUser`）が返されます。ユーザーが項目の読み込みを決定した場合、項目は読み込まれ、通常の応答が返されます。これにより、プラグインのホワイトリストにも追加され、同じ項目（SHA256ハッシュによって決定される）の後続の読み込みではポップアップが表示されなくなります。毎回ポップアップを強制的に表示したい場合は、`customDataSkipAskingUserIfWhitelisted`をfalseに設定できます。

`customDataAskTimer`フィールドを使ってポップアップのタイムアウトを設定できます。これを0（またはそれ以下）に設定すると、ユーザーがOKまたはキャンセルをクリックするまでポップアップは永遠に表示されます。正の数に設定すると、その秒数だけポップアップが表示され、ユーザーにカウントダウンが表示されます。カウントダウンが終了する前にユーザーが決定しなかった場合、項目の読み込みリクエストはユーザーによって拒否されたと見なされます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemLoadRequest",
	"data": {
		"fileName": "some_item_name.jpg",
		"positionX": 0,
		"positionY": 0.5,
		"size": 0.33,
		"rotation": 90,
		"fadeTime": 0.5,
		"order": 4,
		"failIfOrderTaken": false,
		"smoothing": 0,
		"censored": false,
		"flipped": false,
		"locked": false,
		"unloadWhenPluginDisconnects": true,
		"customDataBase64": "",
		"customDataAskUserFirst": true,
		"customDataSkipAskingUserIfWhitelisted": true,
		"customDataAskTimer": -1,
	}
}
```
レスポンスには、新たに読み込まれたアイテムのインスタンスIDが`instanceID`フィールドに含まれています。また、ファイル名も含まれています。

カスタムデータアイテムを読み込んだ場合、ファイル名はVTube Studioによって生成されるため、渡したファイル名とは異なります。そのファイル名を使用して、カスタムデータを渡さずに再度そのアイテムの読み込みをリクエストできます。ただし、VTube Studioを再起動すると、すべての一時ファイルがクリアされ、カスタムデータアイテムも含まれます。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemLoadResponse",
	"data": {
		"instanceID": "SomeUniqueItemInstanceId",
		"fileName": "some_item_name.jpg"
	}
}
```

## シーンからアイテムを削除する

このリクエストを使用して、現在シーンに読み込まれているアイテムをアンロードできます。

`"unloadAllInScene"` を `true` に設定すると、すべてのアイテムがアンロードされます。その場合、他のすべてのフィールドは無視されます。

`"unloadAllLoadedByThisPlugin"` を `true` に設定すると、このプラグインによって読み込まれたすべてのアイテムがアンロードされます。

ユーザーや他のプラグインによって読み込まれたアイテムのアンロードを防ぎたい場合は、`"allowUnloadingItemsLoadedByUserOrOtherPlugins"` を `false` に設定してください。

また、オプションの `"instanceIDs"` と `"fileNames"` 配列を使用して、特定のアイテムインスタンスや特定のファイル名から読み込まれたアイテムインスタンスをリクエストすることもできます。これらのアイテムがシーンに見つからなくても、リクエストはエラーを返しません。空の配列を含むレスポンスが返されます。

ユーザーが現在、VTSがアイテムの読み込み/アンロードを妨げるメニューを開いている場合、`CannotCurrentlyUnloadItem` タイプのエラーが返されることがあります。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemUnloadRequest",
    	"data": {
		"unloadAllInScene": false,
		"unloadAllLoadedByThisPlugin": false,
		"allowUnloadingItemsLoadedByUserOrOtherPlugins": true,
		"instanceIDs":
		[
			"SomeInstanceIdOfItemToUnload", "SomeOtherInstanceIdOfItemToUnload"
		],
		"fileNames":
		[
			"UnloadAllItemInstancesWithThisFileName", "SomeOtherFileName"
		]
    	}
}
```
レスポンスには、アンロードされたアイテムのインスタンスIDとファイル名が含まれています。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemUnloadResponse",
    	"data": {
		"unloadedItems":
		[
		    {
			"instanceID": "SomeInstanceId",
			"fileName": "SomeFileName"
		    },
		    {
			"instanceID": "SomeOtherInstanceId",
			"fileName": "SomeFileName"
		    }
		]
    	}
}
```

## アイテムとアイテムアニメーションの制御

シーン内のアイテムの特定の側面を制御できます。このリクエストでは、アイテムを暗くする（黒のオーバーレイ）、不透明度の変更、およびアニメーションアイテムのアニメーション制御が可能です。このリクエストはLive2Dアイテムには対応しておらず、試みると `ItemAnimationControlUnsupportedItemType` タイプのエラーが返されます（詳細は [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) を参照）。これは「リアクティブPNG」タイプのプラグインなどに役立ちます。

アニメーションアイテムに対しては、フレームレート（fps単位、`0.1`から`120`の範囲に自動で制限されます）を設定できます。また、`"frame"` フィールドを使って手動で特定のフレームにジャンプさせることも可能です。無効なフレームインデックスの場合はエラーが返されます。例えば20フレームのアニメーションアイテムでは、0（最初のフレーム）から19（最後のフレーム）が有効なフレームインデックスです。アニメーションアイテムのフレーム数は `ItemListRequest` で取得可能です。通常のJPG/PNGアイテムに対してこれを行うと、`ItemAnimationControlSimpleImageDoesNotSupportAnim` タイプのエラーが返されます。

フレームレート、現在のフレーム、明るさ、不透明度を変更したくない場合は、これらのフィールドに `-1` を渡せます（ペイロードからフィールドを省略した場合のデフォルト値でもあります）。

`"animationPlayState"` フィールドを使ってアニメーションの再生/停止が可能です（`true` = アニメーション再生、`false` = アニメーション停止）。このフィールドは `"setAnimationPlayState"` を `true` に設定した場合のみ使用され、それ以外ではアニメーションの再生状態は変更されません。

#### 自動停止フレームの使用

アニメーションが自動的に停止するフレームインデックスのリストを `"autoStopFrames"` 配列で設定できます。この配列は `"setAutoStopFrames"` を `true` に設定した場合のみ使用され、それ以外では自動停止フレームは変更されません。自動停止フレームを削除したい場合は、`"setAutoStopFrames"` を `true` にして `"autoStopFrames"` に空の配列を設定してください。自動停止フレームは最大1024個まで設定可能です。

アニメーションがこれらのフレームのいずれかに達すると再生を停止し、再び開始するにはAPIを使ってこのリクエストでアニメーション再生状態を `true` に設定する必要があります（上記参照）。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlRequest",
	"data": {
		"itemInstanceID": "ItemInstanceId",
		"framerate": 12,
		"frame": 3,
		"brightness": 1,
		"opacity": 1,
		"setAutoStopFrames": true,
		"autoStopFrames": [0, 7, 26],
		"setAnimationPlayState": true,
		"animationPlayState": true
	}
}
```
レスポンスには現在のフレームインデックスとアニメーションが再生中かどうかが含まれます（アニメーションアイテムのみ対象で、他のアイテムタイプではこれらのフィールドは無視してください）。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlResponse",
	"data": {
		"frame": 3,
		"animationPlaying": true
	}
}
```
## シーン内のアイテムの移動

シーン内のアイテムを移動させることができます。そのためには、移動させたいすべてのアイテムを `"itemsToMove"` 配列に記入してください。レスポンス配列（`"movedItems"`）には要求された各アイテムごとにエントリが含まれ、移動要求が成功したかどうかが表示されます（該当の `"success"` フィールドを参照）。成功しなかった場合は、`"errorID"` フィールドにエラーコードが含まれ、何が問題だったかを示します（[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)を参照）。成功した場合は、`"success"` が `true` で、`"errorID"` は `-1` になります。

`"itemsToMove"` 配列には最大64件のエントリを含めることができます。それを超えるエントリは無視されます。配列内に重複するアイテムインスタンスIDがある場合は、そのIDの最後のエントリが使用されます。

位置を即座に設定したい場合（例えば毎フレーム新しい位置を設定したい場合）は、`"timeInSeconds"` を `0` に設定してください。そうでなければ、このフィールドを使用して移動フェードにかかる時間を設定できます（0から30秒の範囲で制限されます）。

アイテムの反転状態を設定したい場合は、`"setFlip"` を true に設定してください。反転状態は `"flip"` フィールドで設定できます。

アイテムの順序を変更したい場合は、`"order"` フィールドを使用できます。変更できる順序は空いている順序スポットのみです（`ItemListResponse` を参照）。順序を変更しない場合は、このフィールドを -1000 以下に設定するか、またはアイテムの現在の順序値に設定してください。また、ユーザーが設定ウィンドウを開いている間は順序を変更できません。順序は他のパラメータのようにフェードされるのではなく、リクエストを受け取った時点で即座に要求された値に変更されます。

移動のターゲットとなるフィールド（`"positionX"`, `"positionY"`, `"size"`, `"rotation"`）については、`ItemLoadRequest` のドキュメントを参照してください。唯一の違いは、この `ItemMoveRequest` は値が高すぎる/低すぎる場合にエラーを返さないことです。代わりに、該当フィールドを無視したい場合は `-1000` 以下の値を設定できます。そうすると、そのフィールドは移動に含まれず、代わりに現在の値が使用されます。


#### アイテム移動のトランジションフェードタイプ

位置/回転/サイズのフェードの移動タイプは、`"fadeMode"` フィールドで設定できます。受け入れ可能な値は `"linear"`, `"easeIn"`, `"easeOut"`, `"easeBoth"`, `"overshoot"`, `"zip"` です。これらは `"timeInSeconds"` フィールドが 0 より大きい場合にのみ適用されます。

移動中にアイテムをクリック/ドラッグしてユーザーが移動を停止できるようにしたい場合は、`"userCanStop"` を `true` に設定してください。`false` にすると、移動中はユーザーがアイテムを操作できなくなります。

移動モードの視覚的表現は以下の通りです：

![VTube Studio Movement Modes](/Images/vts_movement_modes_smooth.png)

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemMoveRequest",
	"data": {
		"itemsToMove":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"timeInSeconds": 1,
				"fadeMode": "easeOut",
				"positionX": 0.2,
				"positionY": -0.8,
				"size": 0.6,
				"rotation": 180,
				"order": -1000,
				"setFlip": true,
				"flip": false,
				"userCanStop": true
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"timeInSeconds": 0.5,
				"fadeMode": "zip",
				"positionX": 1,
				"positionY": 1,
				"size": 0.3,
				"rotation": 0,
				"order": 25,
				"setFlip": false,
				"flip": false,
				"userCanStop": false
			}
		]
	}
}
```
リクエストが成功した場合、要求されたすべての項目のステータスを含む応答を受け取ります。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemMoveResponse",
	"data": {
		"movedItems":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"success": true,
				"errorID": -1
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"success": false,
				"errorID": 900
			}
		]
	}
}
```

## モデル内ソート順のアイテム設定

#### ⚠️ このリクエストは現在[パブリックベータブランチ](https://github.com/DenchiSoft/VTubeStudio/wiki/Joining-the-Beta)でのみ利用可能です ⚠️

VTube Studioでは、メインモデルの**レイヤー間で**アイテムのソートおよびピン留めが可能です。仕組みの一般的な情報については、「[レイヤー間アイテムピン留め](https://github.com/DenchiSoft/VTubeStudio/wiki/Between-Layer-Item-Pinning)」のページをご覧ください。

特に[Live2Dアイテム](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)については、**Live2Dアイテムモデル**を前部と後部に分割し、メインモデルに別々に挿入することもできます。

設定を変更したいアイテムを特定するには、`"itemInstanceID"`フィールドでそのアイテムのインスタンスIDを渡します。そのIDのアイテムが見つからない場合は`ItemSortRequestInstanceIDNotFound`エラーが返されます。読み込まれているすべてのアイテムのインスタンスIDを取得するには、`ItemListRequest`を使用できます。IDはAPI経由でアイテムをロードする`ItemLoadRequest`でも直接返されます。

このリクエストが返すすべてのエラーについては「[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)」を参照してください。

*注意:* 通常のアイテム（Live2D以外のアイテム）には「後部」や「分割ポイント」がないため、このリクエストで通常のアイテムに対して後部/分割のフィールドは完全に無視されます。空または`null`のままにして構いません。以下の説明はLive2Dアイテムに対してこのリクエストを使う場合を想定しています。また、VTube Studioは後部を前部の前に設定しても、後部が前部を越えて移動しないようにします。

モデルにアイテムを挿入するには、`"frontOn"`を`true`に設定します。Live2Dアイテムの後部をモデルのさらに後ろに挿入したい場合は、`"backOn"`も`true`に設定できます（Live2D以外のアイテムでは無視されます）。

分割ポイントと前後の挿入位置は、`"splitAt"`、`"withinModelOrderFront"`、および`"withinModelOrderBack"`で設定します。これらのフィールドの解釈は、`"setSplitPoint"`、`"setFrontOrder"`、および`"setBackOrder"`に渡す値によって異なります。

以下のフィールドを使ってアイテムの分割ポイントと挿入位置を設定します：

* `"splitAt"`: Live2Dアイテムモデルを前部と後部に分割するための分割ポイントを設定します。
  * Live2D以外のアイテムでは無視されます。
  * `"setSplitPoint"`が`"Unchanged"`に設定されている場合：`"splitAt"`の値は無視され、分割ポイントは変更されません。
  * `"setSplitPoint"`が`"UseArtMeshID"`に設定されている場合：`"splitAt"`はLive2Dアイテムモデル内に存在するArtMesh IDを期待し、そのArtMesh IDが存在しない場合は`ItemSortRequestInvalidSplitPoint`エラーを返します。
* `"withinModelOrderFront"`: メインモデル（またはLive2Dアイテムの場合は前部）にアイテムを挿入する位置を設定します。
  * `"setFrontOrder"`が`"Unchanged"`に設定されている場合：`"withinModelOrderFront"`の値は無視され、前部の挿入位置は変更されません。
  * `"setFrontOrder"`が`"UseArtMeshID"`に設定されている場合：`"withinModelOrderFront"`はメインLive2Dモデル内に存在するArtMesh IDを期待しますが、存在しなくても現在読み込まれていないLive2DモデルのIDである可能性があるためリクエストは正常に返されます。
  * `"setFrontOrder"`が`"UseSpecialID"`に設定されている場合：`"withinModelOrderFront"`は`"FullyInFront"`または`"FullyInBack"`のいずれかを期待し、アイテム（前部）を読み込まれているメインモデルの完全な前面または完全な背面に配置します。それ以外の値は`ItemSortRequestInvalidFrontOrder`エラーを返します。
* `"withinModelOrderBack"`: Live2Dアイテムの後部をメインモデルに挿入する位置を設定します。
  * Live2D以外のアイテムでは無視されます。
  * `"setBackOrder"`が`"Unchanged"`に設定されている場合：`"withinModelOrderBack"`の値は無視され、後部の挿入位置は変更されません。
  * `"setBackOrder"`が`"UseArtMeshID"`に設定されている場合：`"withinModelOrderBack"`はメインLive2Dモデル内に存在するArtMesh IDを期待しますが、存在しなくても現在読み込まれていないLive2DモデルのIDである可能性があるためリクエストは正常に返されます。
  * `"setBackOrder"`が`"UseSpecialID"`に設定されている場合：`"withinModelOrderBack"`は`"FullyInBack"`を期待し、アイテム（後部）を読み込まれているメインモデルの完全な背面に配置します。それ以外の値は`ItemSortRequestInvalidBackOrder`エラーを返します。

`"setSplitPoint"`、`"setFrontOrder"`、および`"setBackOrder"`に無効な値が指定されると`ItemSortRequestInvalidValueSetType`エラーが返されます。

また、モデル内ソートウィンドウが現在開いている場合（ユーザーが挿入順を手動設定している状態）、`ItemSortRequestItemConfigWindowOpen`エラーも返されます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemSortRequest",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"frontOn": true,
		"backOn": true,
		"setSplitPoint": "UseArtMeshID",
		"setFrontOrder": "UseArtMeshID",
		"setBackOrder": "UseSpecialID",
		"splitAt": "MyArtMeshIDInItemModel91",		
		"withinModelOrderFront": "MyArtMeshIDInMainModel73",
		"withinModelOrderBack": "FullyInBack"
	}
}
```
リクエストが成功した場合、次の応答を受け取ります。

`"itemInstanceID"` はリクエストされたアイテムのインスタンスIDを返します。

メインモデルが現在読み込まれている場合、`"modelLoaded"` は `true` となり、`"modelID"` と `"modelName"` はモデルのIDと名前を含みます。モデルが読み込まれていない場合、これらのフィールドは空になります。

メインモデルが読み込まれている場合、`"loadedModelHadRequestedFrontLayer"` と `"loadedModelHadRequestedBackLayer"` は、提供した前面/背面の挿入ポイントが現在読み込まれているモデル内に存在するかどうかを示します。挿入ポイントが変更されていない場合、これらのフィールドは `false` に設定されます。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemSortResponse",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"modelLoaded": true,
		"modelID": "d87b771d2902473bbaa0226d03ef4754",
		"modelName": "Akari",
		"loadedModelHadRequestedFrontLayer": true,
		"loadedModelHadRequestedBackLayer": true
	}
}
```


## ArtMeshesの選択をユーザーに求める

このリクエストを使用すると、現在読み込まれているメインのLive2DモデルのすべてのArtMeshesを含むリストをVTube Studioに表示し、ユーザーに1つ以上を選択させることができます。ユーザーがArtMeshesの選択を終えると、ArtMesh IDが返されます。これらのArtMesh IDは、例えば色のティントを適用したり非表示にしたりするなど、他のさまざまなAPIリクエストで使用できます。

現在モデルが読み込まれていないか、他のウィンドウが開いている場合、このリクエストはエラーを返します。

ユーザーはArtMeshesにカーソルを合わせるとそのIDが表示され、クリックするとクリック位置の下にあるすべてのArtMeshesでリストがフィルタリングされます。このリクエストで表示されるUIは以下のようになります：

![API ArtMesh selection request screen](/Images/vts_request_select_artmeshes.png)

`requestedArtMeshCount`フィールドを使用して、ユーザーが有効化しなければならないArtMeshesの数を指定します。指定された数と完全に一致するまで「OKボタン」は使用できません。`requestedArtMeshCount`を0以下に設定すると、ユーザーは任意の数のArtMeshes（ただし少なくとも1つ）を選択するよう求められます。

リスト内のArtMeshesを事前に有効化したい場合は、`activeArtMeshes`リストにいくつかのArtMesh IDを渡すことができます。これらのIDのいずれかが現在のモデルに含まれていない場合、エラーが返されます。現在読み込まれているモデルのすべてのArtMeshesのリストが必要な場合は、`ArtMeshListRequest`を使用してください。

上のスクリーンショットでわかるように、リストにはプラグイン用のArtMeshesの選択をユーザーに求めるデフォルトのテキストが表示されます。同じテキストは右上の`?`ボタン（ヘルプ）を押したときのポップアップにも表示されます。これらの文字列はそれぞれ`textOverride`および`helpOverride`フィールドを使用して上書きできます。空文字列、null、またはペイロードから省略した場合は、上記のデフォルトメッセージが使用されます。これらのメッセージを上書きする場合、提供する文字列は4文字以上1024文字以下でなければならず、それ以外の場合はデフォルトが使用されます。文字列内で改行を指定するには`\n`を使用できます。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionRequest",
	"data": {
		"textOverride": "This text is shown over the ArtMesh selection list.",
		"helpOverride": "This text is shown when the user presses the ? button."
		"requestedArtMeshCount": 5
		"activeArtMeshes": [
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```

リクエストが成功すると、選択リストがユーザーに表示されます。即時の応答はありません。応答はユーザーが「OK」または「キャンセル」ボタンをクリックした時に返されます。「キャンセル」ボタンは常に利用可能ですが、「OK」ボタンは要求された数のArtMeshesが選択された場合にのみクリック可能になります。

アクティブ化/非アクティブ化されたArtMeshesは、それぞれ`activeArtMeshes`および`inactiveArtMeshes`配列で返されます。これらの配列間に**重複はありません**ので、これらの配列のArtMeshesを組み合わせればモデル内のすべてのArtMeshesのリストになります。

ユーザーが「OK」をクリックした場合、`success`フィールドは`true`になります。ユーザーが「キャンセル」をクリックした場合、`success`フィールドは`false`になります（その場合、`activeArtMeshes`および`inactiveArtMeshes`配列は無視するのが望ましいですが、それらは引き続き返されます）。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionResponse",
	"data": {
		"success": true
		"activeArtMeshes": [
			"D_BROW_00",
			"D_EYE_BALL_03",
			"D_EYE_BALL_02",
			"D_EYE_BALL_01",
			"D_EYE_BALL_00",
			"D_EYE_11"
		],
		"inactiveArtMeshes": [
			"D_EAR_06",
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```
## モデルへのアイテムの固定

このリクエストを使って、シーン内のアイテムを現在読み込まれているモデルに固定できます。

固定するアイテムを識別するために、`itemInstanceID` フィールドにアイテムインスタンスIDを指定する必要があります。アイテムの固定を解除したい場合は、`pin` を `false` に設定するだけでよく、その場合は他の情報を提供する必要はありません。そのIDのアイテムが現在読み込まれていない場合はエラーが返されます（[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) を参照）。

アイテムを固定したい場合は、`pinInfo` オブジェクトに固定位置を指定する必要があります。アイテムを固定する方法は様々です。例えば、正確な位置を指定して固定することもできますし、ArtMesh を指定してVTSにその中心やArtMesh上のランダムな位置に固定させることも可能です。具体的な方法は以下で説明します。

`ItemMoveRequest` がアクティブなアイテムに対して `ItemPinRequest` を送信すると、`ItemMoveRequest` は自動的にキャンセルされます。

また、あなたのプラグイン（または複数の異なるプラグイン）が同じアイテムに対して複数のピンリクエストを送り、それらがVTSの同一フレーム内に受信された場合、最後に受信したピンリクエストのみが実行され、それ以外は破棄されます。

### ピン留めのオプション

`pinInfo` に渡されたデータの解釈方法を決定する3つのフィールドがあります：

* `angleRelativeTo`: 指定された角度をどのように解釈するか？
  * `RelativeToWorld`: 絶対角度。つまり角度に0を指定すると、VTSウィンドウに対して角度0でアイテムが直立して固定されます。VTSウィンドウに対して特定の方向を向かせたい場合に使います。
  * `RelativeToCurrentItemRotation`: 現在のアイテムの角度に対する相対角度。角度に0を指定すると、アイテムは現在の角度のまま固定され、回転は変更されません。アイテムの回転を変えたくなくて、そのまま固定したい場合に使います。
  * `RelativeToModel`: モデルの回転に対する相対角度。角度に0を指定すると、ユーザーがモデルを回転していても、モデルに対して直立した状態でアイテムが固定されます。この「モデルの回転」はLive2D ArtMeshの変形による回転は含まず、VTube Studioがモデル全体に適用する実際の回転のみを指します。モデルの現在の回転に対してアイテムを特定の方向に向けたい場合に使います。
  * `RelativeToPinPosition`: ピン位置に対する相対角度。特定のArtMesh内の特定の位置にアイテムを固定し、その角度をモデルの回転やArtMeshの変形に関わらず常に同じにしたい場合に使います。ただし、望む効果を得るために指定すべき角度はピン位置ごとに完全に異なります。
* `sizeRelativeTo`:
  * `RelativeToWorld`: 絶対サイズ。0（最小）から1（最大）まで。`ItemLoadRequest` も参照。
  * `RelativeToCurrentItemSize`: 現在のアイテムサイズに対する相対サイズ。`-1` から `1` の範囲で数値を指定でき、現在のアイテムサイズに加算されます。アイテムの現在のサイズのまま固定したい場合は0を指定します。
* `vertexPinType`: 
  * `Provided`: 指定したArtMeshのピン位置を、`vertexID1`、`vertexID2`、`vertexID3`、`vertexWeight1`、`vertexWeight2`、`vertexWeight3` フィールドで提供してアイテムを固定します。詳細は以下で説明。
  * `Center`: 指定したArtMeshの「中心」にアイテムを固定します。空間的な中心ではなく、メッシュの三角形リストの中央にある三角形です。これにより、特定のArtMeshに対して毎回同じ位置が得られます。
  * `Random`: 指定したArtMesh内のランダムな三角形にアイテムを固定します。

指定したモデルIDが読み込まれているモデルと一致しない場合はエラーが返されます。モデルIDを空にすると、現在読み込まれているモデル（もしあれば）にピン留めしようとします。

モデルに指定したArtMesh IDのArtMeshが存在しない場合はエラーが返されます。ArtMesh IDを空にすると、モデル内のランダムなArtMeshが選択されます。

例えば、モデルIDとArtMesh IDの両方を空にして `vertexPinType` を `Random` に設定すると、現在読み込まれているモデルのランダムなArtMesh上のランダムな位置にアイテムを固定します。

### 特定位置へのピン留め

`vertexPinType` を `Provided` に設定した場合は、`modelID` と `artMeshID` で選択したArtMesh上の有効な位置を指定するために、`vertexID1`、`vertexID2`、`vertexID3`、`vertexWeight1`、`vertexWeight2`、`vertexWeight3` フィールドを使用する必要があります。


三つの頂点IDフィールドは、指定されたArtMesh内の三角形の頂点IDでなければなりません。特定の三角形内の位置を定義するには、頂点ウェイトフィールドを使用します。これらのフィールドは頂点位置に乗算され、三角形内の位置を定義します。ウェイトの合計は正確に1でなければならないことに注意してください。そうでないと結果の位置は三角形の外部になり（エラーが返されます）。これらは[重心座標](https://ja.wikipedia.org/wiki/%E9%87%8D%E5%BF%83%E5%BA%A7%E6%A8%99)です。

これらの位置の一つを取得するには、[ModelClickedEvent](https://github.com/DenchiSoft/VTubeStudio/tree/master/Events#model-clicked-event)を使用できます。このイベントは、モデルがクリックされたときに`ItemPinRequest`で使用可能なピン位置を返します。

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemPinRequest",
	"data": {
		"pin": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"angleRelativeTo": "RelativeToModel",
		"sizeRelativeTo": "RelativeToWorld",
		"vertexPinType": "Provided",
		"pinInfo": {
			"modelID": "d87b771d2902473bbaa0226d03ef4754",
			"artMeshID": "hair_right_4",
			"angle": 23.938,
			"size": 0.33,
			"vertexID1": 17,
			"vertexID2": 9,
			"vertexID3": 55,
			"vertexWeight1": 0.25928378105163576,
			"vertexWeight2": 0.6850675940513611,
			"vertexWeight3": 0.055648624897003177
		}
	}
}
```

成功した場合、レスポンスにはアイテムID、アイテムファイル名、およびアイテムが現在ピン留めされているかどうかが含まれます。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemPinResponse",
	"data": {
		"isPinned": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"itemFileName": "my_test_item_2.png",
	}
}
```

## ポストプロセス効果と状態の一覧取得

**注意:** 本ドキュメントでは、ビジュアルエフェクト、VFX、およびポストプロセス効果は同義語として使用されています。

VTube Studioには組み込みのポストプロセス機能があり、シーンに直接ビジュアルエフェクトを追加できます。これはWindowsおよびmacOSで利用可能です。詳細については、["Visual Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects)のページを参照してください。

このリクエストは、ポストプロセスシステムの一般的な状態、すべての既存（ユーザー作成）ポストプロセスプリセットのリスト、および現在の値（現在のポストプロセス状態）を持つすべての利用可能なポストプロセス効果のリストを返します。

`fillPostProcessingPresetsArray`を`false`に設定すると、レスポンスペイロード内の`postProcessingPresets`配列は空になります。ポストプロセスプリセットのリストを要求するにはプリセットファイルをディスクから読み込む必要があり（VTS内で一時的にキャッシュされていますが）、これには時間がかかる場合があります。このリクエストを高頻度で送信する場合は、`fillPostProcessingPresetsArray`が`true`でないことを確認してください。そうしないとディスクI/Oによる遅延が発生する可能性があります。

`fillPostProcessingEffectsArray`を`false`に設定すると、レスポンスペイロード内の`postProcessingEffects`配列は空になります。ポストプロセス効果とその値の完全なリストが不要な場合は、レスポンスペイロードが非常に大きくなる可能性があるため、`fillPostProcessingEffectsArray`を`false`に設定することを推奨します。

特定のポストプロセス効果のみが必要な場合は、`effectIDFilter`配列にそれらをリストアップできます。そうでなければ、フィルターを適用しないために配列を空のままにしてください。すべての現在の効果のリストは以下で確認できます：https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/Effects.cs

**注意:** これらのIDは多様な形式で受け入れられるため、任意のenumスタイルでenumを作成できます。大文字小文字を区別せず、`_`や`-`は無視されます。例えば、`ChromaticAberration`の代わりに`Chromatic_Aberration`、`chromatic_aberration`、`CHROMATIC_ABERRATION`など、最適なスタイルで記述可能です。

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingListRequest",
	"data":
	{
		"fillPostProcessingPresetsArray": true,
		"fillPostProcessingEffectsArray": true,
		"effectIDFilter":
		[
			"ASCII",
			"ColorGrading",
			"WeatherEffects",
			"ChromaticAberration"
		]
	}
}
```
レスポンスには、ポストプロセッシングシステムの状態に関する一般情報と、要求された場合は `postProcessingEffects` および `postProcessingPresets` 配列が含まれます。

`postProcessingSupported` はプラットフォームがポストプロセッシングをサポートしているかどうかをチェックします。Windows および macOS では常に `true` であるはずです。`postProcessingActive` フィールドにはユーザーがポストプロセッシングをオンにしているかどうかが含まれます。API を使って `PostProcessingUpdateRequest`（次に説明）を通じてオン/オフを切り替えることも可能です。`PostProcessingUpdateRequest` の使用は、特にポストプロセッシング設定に関連するウィンドウやポップアップが VTube Studio で開いている場合には不可能なことがあります。この場合、`canSendPostProcessingUpdateRequestRightNow` は `false` になります。

制限付き/実験的なエフェクトがいくつかあります（["Restricted/Experimental Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects) を参照）。ユーザーはこれらのエフェクトを使用することを明示的に許可する必要があります。これらのエフェクトの使用をユーザーが許可しているかどうかは `restrictedEffectsAllowed` フィールドで返されます。

ポストプロセッシングプリセットがアクティブかどうかは `presetIsActive` フィールドで返されます。アクティブなプリセットがある場合は、その名前が `activePreset` フィールドに入り、そうでなければそのフィールドは空になります。

`presetCount` には `postProcessingPresets` 配列内のポストプロセッシングプリセットの数が入ります。配列を要求していなければ、`presetCount` は 0 になります。

`activeEffectCount` はアクティブなポストプロセッシングエフェクトの数です。エフェクトが「アクティブ」と見なされる意味はこのセクションの後半で説明します。

`effectCount` と `configCount` フィールドには、フィルター適用前後のすべてのエフェクトおよび全設定数が含まれます（フィルターを要求した場合）。

### `postProcessingEffects` 配列

`postProcessingEffects` 配列にはすべてのエフェクトのリストが含まれます。これらは VTube Studio の VFX リストに表示されるのと同じエフェクトです。各エフェクトは複数の「設定（configs）」を持ち、例えば強度や色などエフェクトの特定の側面を設定します。

エフェクトを識別するために使用する ID は `enumID` フィールドで返されます。`internalID` フィールドには VTube Studio が内部でそのエフェクトに使用する ID が入ります。これはポストプロセッシングプリセットの JSON ファイルで使用される ID なので、多くのユースケースでは関係ありません。ただし、何らかの理由で API でエフェクトを参照したい場合にはこれらの ID も使えます。

設定はすべて次のいずれかのタイプを持ちます（設定の `type` フィールドで返されます）：
* Float
* Int
* Bool
* String
* Color
* SceneItem

一つのエフェクトの設定は `configEntries` 配列で返されます。各設定には `internalID` と `enumID` もあります。すべてのエフェクトの設定 ID と説明はここにあります：https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

一つの設定については、その設定のタイプに合致するフィールドのみが値を持ちます。他のフィールドは空かデフォルト値で無視してください。例えば float 設定の場合、`intMin` や `colorValue` は空（この場合は 0 や空文字列）です。すべてのタイプにデフォルト値がありますが、`Float` と `Int` にはさらに `min` と `max` もあります。

色を含むフィールドは RGBA の 16 進形式文字列（例："77CCAAFF"）で返され、`colorHasAlpha` でその設定がアルファを持つかどうかがわかります。`false` の場合、アルファは常に `FF` です。

`SceneItem` タイプの設定は基本的に文字列設定ですが、値は VTube Studio の「Items」フォルダに存在するファイル名（末尾が .jpg または .png）でなければなりません。これはカスタムパーティクルエフェクトなどで使われます。

### エフェクトが「アクティブ」と見なされるのはいつか？



各エフェクトには少なくとも1つのfloat設定（複数ある場合もある）があり、その`activationConfig`は`true`に設定されています。あるエフェクトのその設定の1つが0より大きい値を持つ場合、そのエフェクトは`active`とみなされます。

例えば、`ColorGrading`エフェクトの場合、それは`ColorGrading_Strength`という設定になります。

**注意：** このレスポンスペイロードの`postProcessingEffects`は大幅に短縮されています。フィルターが適用されていない場合、250以上のエフェクト設定があるため、数千行に及ぶことがあります。

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingListResponse",
	"data": {
		"postProcessingSupported": true,
		"postProcessingActive": true,
		"canSendPostProcessingUpdateRequestRightNow": true,
		"restrictedEffectsAllowed": false,
		"presetIsActive": true,
		"activePreset": "some_effects_preset_3",
		"presetCount": 70,
		"activeEffectCount": 5,
		"effectCountBeforeFilter": 29,
		"configCountBeforeFilter": 258,
		"effectCountAfterFilter": 4,
		"configCountAfterFilter": 31,
		"postProcessingEffects": [
			{
				"internalID": "color_grading",
				"enumID": "ColorGrading",
				"explanation": "Color grading",
				"effectIsActive": false,
				"effectIsRestricted": false,
				"configEntries": [
					{
						"internalID": "color_grading-strength",
						"enumID": "ColorGrading_Strength",
						"explanation": "Effect on/off",
						"type": "Float",
						"activationConfig": true,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 1.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "",
						"colorDefault": "",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					},
					{
						"internalID": "color_grading-color_filter",
						"enumID": "ColorGrading_ColorFilter",
						"explanation": "Color filter",
						"type": "color",
						"activationConfig": false,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 0.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "FFFFFFFF",
						"colorDefault": "FFFFFFFF",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					}
				]
			}
		],
		"postProcessingPresets": [
			"My Cool Preset",
			"some_effects_preset_1",
			"some_effects_preset_2",
			"some_effects_preset_3",
			"test asdf 123456",
			"blur and color grading",
		]
	}
}
```
## ポストプロセス効果の設定

**注意:** 本ドキュメントでは、視覚効果、VFX、およびポストプロセス効果という用語を同義で使用しています。

VTube Studioにはビルトインのポストプロセス機能があり、シーンに直接視覚効果を追加できます。これはWindowsおよびmacOSで利用可能です。詳細は["Visual Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects)のページをご覧ください。

`PostProcessingUpdateRequest`を使用すると、ポストプロセスシステムを制御できます。オン/オフの切り替え、プリセットの読み込み/アンロード、さらには個別の設定項目（色、強度など）を直接かつ詳細に制御できます。

このアップデートは、ポストプロセス設定に関連するウィンドウが開いていない場合にのみ送信可能です。そうでない場合、`PostProcessingUpdateReqestCannotUpdateRightNow` エラーが返されます。返される可能性のあるすべてのエラーについては、["ErrorsID.cs"](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)を参照してください。

`postProcessingOn`を使ってポストプロセスをグローバルにオン/オフできます。これはVTS UIのポストプロセストグルを切り替えるのと同じ動作をします。プリセットや個別の設定値は、ポストプロセスをオフにしている場合でも同じリクエストで設定可能です。値は設定されますが画面上には何も反映されません。VTube Studioのポストプロセス設定ウィンドウを開くと、要求した値が設定されているのが確認でき、ポストプロセスをオンにすると表示されます。プリセットを設定して同じリクエストでポストプロセスをオフにした場合でも、プリセットのすべての値は設定されますが、UI上でそのプリセットは「アクティブ」ではなく表示されません。ポストプロセスを再度オンにするとプリセットのすべての値が表示されます。

ポストプロセス設定項目の値は2つの方法で設定できます：
* ポストプロセスプリセットの設定: `setPostProcessingPreset`を`true`にし、`presetToSet`フィールドにプリセット名を指定します（拡張子なしのプリセット名のみ）。プリセットが存在しない場合、`PostProcessingUpdateRequestPresetFileLoadFailed`エラーが返されます。
* 個別の設定値の設定: `setPostProcessingValues`を`true`にし、`postProcessingValues`配列に設定キー/値のリストを提供します。

同時にはできません：`setPostProcessingPreset`と`setPostProcessingValues`が両方`true`の場合、`PostProcessingUpdateRequestLoadingPresetAndValues`エラーが返されます。ただし、両方`false`でも構いません。その場合、値は設定されません。これは、現在の設定を変更せずにグローバルにポストプロセスをオン/オフしたい場合に有用です。

設定値を直接またはプリセット経由で変更する場合、設定値は古い値から新しい値へスムーズにフェードします。フェード時間は`postProcessingFadeTime`フィールドに秒単位で指定し、0から2秒の範囲でなければなりません。範囲外の値は`PostProcessingUpdateRequestFadeTimeInvalid`エラーが返されます。

個別の値を設定する際、`setAllOtherValuesToDefault`フィールドは、ペイロードに含まれていないその他すべての値を変更せずに保持するか、デフォルト値にフェードバックするかを決定します。未指定の効果はすべてオフになります。

設定値を直接設定する場合に[制限付き/実験的効果](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects)を使用するなら、ペイロード内で`usingRestrictedEffects`を`true`に設定してください。これは誤ってこれらの効果を使用しないようにするための安全チェックです。そうしないと、`PostProcessingUpdateRequestTriedToLoadRestrictedEffect`エラーが返されます。このエラーはユーザーがVTube StudioのVFX設定でこれらの効果の使用を有効にしていない場合にも返されます。これはユーザーが手動で設定する必要があります。プリセットに制限付き効果が含まれている場合は完全に読み込まれますが、エラーは発生せず制限付き効果は有効になりません。

すべての効果設定をランダム化することもできます。これは遊び目的の機能です。`randomizeAll`を`true`に設定してください。`randomizeAll`が`true`の場合、ペイロード内の設定値やプリセットは無視されます。多くの効果が同時にアクティブになると単なるランダムノイズになるため、効果数は制限され、設定値も過激になりすぎません。これは`randomizeAllChaosLevel`フィールドで制御でき、0から1の値を受け入れます（範囲外の値はクランプされます）。`0`は1～2の効果が穏やかな値でアクティブになり、`1`は画面上に完全な混沌を生み出します。良い効果のためには0.4～0.5の範囲が推奨されます。制限付き効果は`usingRestrictedEffects`が`true`であり、ユーザーが使用を許可している場合のみランダム化に含まれます。

### 個別の設定値を設定する方法

ポストプロセス設定を詳細に制御したい場合、`setPostProcessingValues`を`true`にし、`postProcessingValues`配列で値を設定します。`configID`は設定したい効果のIDで、`configValue`は設定したい値を文字列で指定します。

* `configID`: 設定したい設定のID。全設定IDの一覧は[こちら](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs)を参照。これらのIDは多様な形式を受け入れ、任意のenumスタイルでenumを作成可能です。大文字小文字は区別されず、`_`や`-`は無視されます。例えば、`Backlight_OutlineSize`の代わりに`Backlight_Outline_Size`、`backlight_outlinesize`、`BACKLIGHT_OUTLINESIZE`、`backlight-outline_size`などが使用できます（`PostProcessingListResponse`の`configEntries`配列内の`enumID`フィールドも参照）。
* `configValue`: 設定する値を文字列で。floatやintの場合、設定の最小/最大範囲外の値はクランプされます。bool値は大文字小文字を区別しないので、`"True"`や`"true"`（または`"TRUE"`など）も有効です。

配列に重複キーがある場合は`PostProcessingUpdateRequestValueListContainsDuplicates`エラーが、無効なキー（見つからない）や無効な値（floatやboolのデシリアライズ失敗など）がある場合は`PostProcessingUpdateRequestValueListInvalid`エラーが返されます。

**効果を「オン」にする方法:** 効果は複数の設定項目を持つことがあります。各効果には少なくとも1つ（多くの場合複数）の設定項目があり、その値が0より大きいと効果が「オン」になります。`PostProcessingListResponse`ペイロード内では、それらの設定（常にfloat型設定）が`"activationConfig": true`でマークされています。すべての効果設定リストでも、これらの特別な設定は`sets_active: True`でマークされています。参照：https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

### 一般的な使用アドバイス


このリクエストを高頻度、例えば毎フレーム送信するべきではありません。値をフェードさせたい場合は、`postProcessingFadeTime` フィールドを使用して適切なフェード時間を設定してください。設定の組み合わせによっては、頻繁な更新が*可能*な場合もありますが、慎重にテストする必要があります。ポストプロセッシングシステムは頻繁な設定更新には最適化されていないため、プラグインを公開する前に遅延が発生しないか確認してください。


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateRequest",
	"data":
	{
		"postProcessingOn": true,
		"setPostProcessingPreset": false,
		"setPostProcessingValues": true,
		"presetToSet": "",
		"postProcessingFadeTime": 1.3,
		"setAllOtherValuesToDefault": true,
		"usingRestrictedEffects": false,
		"randomizeAll": false,
		"randomizeAllChaosLevel" : 0.0,
		"postProcessingValues": [
			{
				"configID": "Backlight_Strength",
				"configValue": "0.8"
			},
			{
				"configID": "Bloom_Strength",
				"configValue": "1.0"
			},
			{
				"configID": "Bloom_StreakVertical",
				"configValue": "false"
			},
			{
				"configID": "Bloom_StreakColorTint",
				"configValue": "220308FF"
			}
		]
	}
}
```
エラーがなければ、要求された更新後の新しいポストプロセッシング状態に関する一般情報を含む以下の応答が届きます。

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateResponse",
	"data":
	{
		"postProcessingActive": true,
		"presetIsActive": false,
		"activePreset": "",
		"activeEffectCount": 2
	}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---