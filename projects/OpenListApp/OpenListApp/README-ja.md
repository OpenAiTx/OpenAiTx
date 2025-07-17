# OpenList アプリ
### AList、OpenListのクロスプラットフォームクライアントで、現在はOpenListサーバーが組み込まれており、追加のサーバー接続は不要です。iOS、macOS、Windows、Android、Linuxをサポートしています。

### 組み込みの[DDNS-GO(MIT)](https://github.com/jeessy2/ddns-go)により、デバイスが**グローバルIPを持っている場合**はDDNS-GOを使ってリモートアクセスが可能で、スマホをリモートサーバーとして利用できます。

### 組み込みの[GATEWAY-GO(MIT)](https://github.com/OpenIoTHub/gateway-go)により、デバイスが**グローバルIPを持っていない場合**はGATEWAY-GOを使ってリモートアクセスが可能で、スマホをリモートサーバーとして利用できます。

### CIビルドを通じて、本プロジェクトはAPIサーバーを提供しておらず、サーバーは上流のOpenList等のコミュニティが提供しています。
### プロジェクトは2種類のUIを提供しています。1つは従来のWebインターフェースの直接読み込み版、もう1つは現在コア機能が完成しているネイティブインターフェース版で、現在はLinuxがデフォルトでネイティブUIを使用し、その他はWeb UIを使用しています。

### 本プロジェクトはフロントエンドプロジェクトとしてAListフロントエンドを参考に、寛容な[MIT](LICENSE)コードライセンスで公開されています。パッケージ名を変更してアプリ市場（特にiOS）に公開することを歓迎しますが、本プロジェクトを基に開発したことを常に明記してください（本プロジェクトのURLを含む）。

#### 本プロジェクトのコンパイルについて：
* [OpenListLib](https://github.com/OpenListApp/OpenListLib/releases)から関連ライブラリをダウンロードしてコンパイルが必要です。

### QQグループ:251405953
![QQGroup.jpg](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/contact/QQGroup.jpg)
### プロジェクト構成
* [openlist](/lib/main.dart) アプリ入口プロジェクト
* [openlist_api](/openlist_api) コアAPIラッパー
* [openlist_utils](/openlist_utils) ユーティリティ
* [openlist_background_service](/openlist_background_service) openlist(AList)ライブラリラッパー
* [openlist_global](/openlist_global) グローバル共有コード
* [openlist_config](/openlist_config) 設定ファイル
* [openlist_native_ui](/openlist_native_ui) ネイティブUIコード
* [openlist_web_ui](/openlist_web_ui) Web UIコード（現在デフォルト）

![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/android/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/macos/storages.png) ![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/macos/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/ios/storages.png) ![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/ios/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/windows/storages.png)

### 注意事項：
* 初期ユーザーは上流のデフォルト権限に従い、デフォルトでwebdavは無効になっていますのでご注意ください。
* その他

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---