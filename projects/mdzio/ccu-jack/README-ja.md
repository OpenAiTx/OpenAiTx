# CCU-Jack

CCU-Jackは、[eQ-3](http://www.eq-3.de/)社のホームオートメーションシステムHomeMaticの中央ユニット（CCU）のデータポイントに対し、簡単で安全な**REST**および**MQTT**ベースのアクセスを提供します。これには、多くのプログラミング言語で簡単に使用可能な[Very Easy Automation Protocol](https://github.com/mdzio/veap)と、IoTで広く使われている[MQTTプロトコル](https://de.wikipedia.org/wiki/MQTT)が実装されています。さらに、これらのプロトコルを使って外部機器もCCUに接続可能です。

CCU-Jackが追求する目的は以下の通りです：

**CCU-Jackは他のアプリケーションにCCUのデータポイントへの簡単なアクセスを可能にすることを目的としています。** 例えば、HM、HM-Wired、HM-IPデバイスを含むCCUへのアクセスには、合計9つのネットワーク接続が必要であり、時にはリターンチャネルや異なるプロトコルも使われます。さらに、CCUのネットワークインターフェースは暗号化されておらず、ファイアウォールで許可するべきではありません。CCU-Jackは、すべてのデバイスとシステム変数へのアクセスを統一されたプロトコルと暗号化接続で標準化します。

**また、可能な限り簡単に外部機器（例：Wi-Fi対応のスマートプラグ）をCCUに接続し、自動化できるようにします。** 接続された外部機器はCCU上で元のHMデバイスのように表示され、CCUのWeb UIから同様に操作・監視できます。さらに、CCUプログラムで制限なく使用可能です。

**複数のCCUやMQTTサーバーを備えた他の自動化機器は、CCU-Jackを介して相互にネットワーク接続され、値の変更を交換できます。** これにはCCU-JackがMQTTブリッジを提供します。CCUはクラウドのMQTTサーバーに接続することも可能です。

機能的には、CCU-Jackは[XML-API Add-On](https://github.com/jens-maus/XML-API)の代替です。XML-API Add-Onは長期間更新されておらず、未修正のバグやセキュリティホールがあります。さらに、CCU-Jackは２つのAdd-Onである[hm2mqtt](https://github.com/owagner/hm2mqtt)と[Mosquitto](https://github.com/hobbyquaker/ccu-addon-mosquitto)の組み合わせの代わりにもなります。hm2mqttも長期間更新されていません。

外部機器の接続に関しては、CCU-Jackは多くの複雑で手間のかかるソリューションを置き換え、同時により多くの機能を提供します。

# Anwenderhandbuch

ユーザー向けの情報（例：インストール、設定）はすべて[**Anwenderhandbuch**](https://github.com/mdzio/ccu-jack/wiki)にあります。インストール前に必ずご一読ください！

# Download

CCU-Jackの公式リリース版は右の[Releases](https://github.com/mdzio/ccu-jack/releases)から入手可能です。

最新の開発版は[Actions](https://github.com/mdzio/ccu-jack/actions)から入手できます。そこでワークフローを選択し、_Artifacts_にて各プラットフォーム向けのダウンロードが可能です。これらのバージョンは新機能やバグ修正を早期に含みますが、テストはされていません！

# Umfeld vom CCU-Jack

CCU-Jackに関連して他のプロジェクトも生まれました：
* [CCU-Jack to HomeAssistant](https://github.com/kaistraube/ccujack_homeassistant)（HomeMatic CCUをCCU-Jack経由でHomeAssistantに接続）
* [node-red-contrib-ccu-jack](https://github.com/ptweety/node-red-contrib-ccu-jack)（HomeMatic CCUをCCU-Jack経由でNode-REDに接続）
* [ngx-ccu-jack-client](https://github.com/pottio/ngx-ccu-jack-client)（CCU-JackをAngularアプリに統合）

# Entwicklung

## Bauen aus den Quellen

CCU-Jackは[Go言語](https://golang.org/)で書かれています。CCU-Jackのすべてのディストリビューションは、Windows、Linux、MacOSなどあらゆるプラットフォームで非常に簡単かつ迅速にビルド可能です。任意のディレクトリにGitリポジトリをクローンするか、ソースコードをコピーしてください。その後、そのディレクトリでコマンドラインを開き、以下のコマンドを入力します：
```
cd build
go run .
```
メインディレクトリで全てのディストリビューションがビルドされます。

開発には開発環境として[Visual Studio Code](https://code.visualstudio.com/)がおすすめです。メインディレクトリを開くだけで、必要な拡張機能が自動的にインストール提案されます。

## 参加

参加者はもちろん歓迎します。ドキュメント作成、テスト、[HomeMaticフォーラム](https://homematic-forum.de/forum/viewtopic.php?f=41&t=53553)でのサポート、バグ修正や新機能の実装などです。コードの提供にはライセンス（GPL v3）を遵守してください。コードの提供は常に`master`ブランチとは別の新しいブランチで開発するべきです。

## 著者

* [Mathias Dz.](https://github.com/mdzio)
* [martgras](https://github.com/martgras)（Raspberry Pi 4、証明書管理）
* [twendt](https://github.com/twendt)（CUxD用BIN-RPC）
* [Theta Gamma](https://github.com/ThetaGamma)（Dockerイメージ）

## ライセンスおよび免責事項

ライセンスおよび免責事項はファイル[LICENSE.txt](https://raw.githubusercontent.com/mdzio/ccu-jack/master/LICENSE.txt)に記載されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---