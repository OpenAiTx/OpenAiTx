<p align="center">
	<img src="https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/logo.png" width="100">
<br>

</p>

# 製品紹介

HummingBird（蜂鳥）はGolang言語で実装された超軽量のIoT開発プラットフォームであり、そのコアサービスは全てチーム内で独自に開発されています。このプラットフォームの設計当初から、軽量かつ高性能を開発方針の一つとして掲げています。したがって、サービスはすべてGolang言語で記述されており、メモリ消費が非常に低いです。データストレージには革新的にSQLiteとLevelDBを使用しており、SQLiteの軽量性とLevelDBの高スループット・高圧縮性能を活かし、実際のテストでは1C/1G、100Gストレージの物理マシン上で数千台のデバイス接続と8000万件のメッセージ保存を実現しています。

もちろん、信頼性や大容量ストレージなどの要件がある場合は、SQLiteとLevelDBをMySQLやTDengineに置き換えることも可能です。HummingBird IoTプラットフォームは複数のデータベース接続に対応しており、ユーザーは自身のビジネスニーズに合わせて適切なデータベースを選択できます。

「雀（蜂鳥）は小さいが、五臓はすべて揃っている」 超軽量IoTプラットフォームでありながら、HummingBirdのコア機能は削減されていません。デバイス接続、製品管理、物モデル、アラートセンター、ルールエンジン…これらのすべてのIoTプラットフォームの標準機能は、本プラットフォームで見つけることができます。



![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/architecture.png)



# 一部ページの表示

| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/1.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/2.png)  |
|:--------------------------|:---------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/3.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/4.png)  |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/5.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/6.png)  |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/9.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/10.png) |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/7.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/8.png)  |

# ミニプログラムページの表示

| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge1.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge2.png) |
|:---------------------------------------|:---------------------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge3.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge4.png) |

# 公式ドキュメントURL
https://doc.hummingbird.winc-link.com/

# クイックスタート

git clone https://gitee.com/winc-link/hummingbird.git

cd hummingbird/manifest/docker 

docker-compose up -d

# 主な機能

- 製品管理
- デバイス管理
- イメージ管理
- ドライバー管理
- ドライバーマーケット
- システム監視
- アラートセンター
- リソース管理
- ルールエンジン
- シナリオ連動
- プラグインマーケット
- データダッシュボード

# 製品の強み

- **無料オープンソース**：ソースコードはすべてオープンソースで、個人学習に利用可能です。
- **高性能**：実際のテストでは2C4Gホストで6万台のデバイス接続をサポート。4千台のデバイスが1000ms間隔で16kbの属性データをサーバーに送信しても、CPU使用率は60％前後、メモリ使用率は16％前後で安定しています。
- **多データベース対応**：プラットフォームはSQLite、LevelDB、MySQL、TDengineをサポートしており、ユーザーはプロジェクトのニーズに応じて適切なデータベースを選択可能です。
- **可視化ダッシュボード対応**：ユーザーは簡単なドラッグ＆ドロップ操作だけで、コードを書かずに可視化ダッシュボードの開発・設計を完了できます。
- **製品テンプレートライブラリ内蔵**：プラットフォームには390種類の製品テンプレートがあらかじめ用意されており、ユーザーはワンクリックで製品作成が可能です。
- **明確なドキュメント**：プラットフォームのドキュメントは明確かつ完全で、多数の使用例やビデオチュートリアルが含まれており、ユーザーが製品を迅速に理解し利用できるよう支援します。
- **簡単なデプロイ**：プラットフォームの全サービスはDocker形式で動作し、docker-composeコマンドでワンクリック起動が可能です。
- **コスト優位性**：中小規模のIoTプロジェクト（デバイス数<=5000）においては2C4Gホストで十分であり、ローカルデプロイにも対応しています。

# お問い合わせ

私たちはHummingBirdのユーザーグループを開設しています。本製品の使用中に何か問題があれば、グループに参加してご相談ください。


| WeChatグループ（友達追加後にグループ参加希望とメモしてください）                    | QQグループ                                                               |
|:------------------------------------------------------------------------|:--------------------------------------------------------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/qweixin.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/qq.png) |

# オープンソースへの貢献

-   `master` ブランチから新しいブランチを `checkout` します（**注意**：`master` コードが最新であることを必ず確認してください）
-   新しいブランチの命名形式は `feature/username/description` です。例：`feature/pick/mqtt_driver`
-   新しいブランチでドキュメントやコードを編集し、コミットしてください
-   `PR` を送信して `develop` ブランチにマージを依頼し、作者のマージを待ちます

# オープンソースライセンス

`Hummingbird` オープンプラットフォームは [Apache 2.0 ライセンス](https://www.apache.org/licenses/LICENSE-2.0.html) に準拠しています。HummingBird IoTプラットフォームを商用利用する場合は、事前に作者に許諾を得てください！



## Stargazersの推移

[![Stargazers over time](https://starchart.cc/winc-link/hummingbird.svg)](https://starchart.cc/winc-link/hummingbird)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---