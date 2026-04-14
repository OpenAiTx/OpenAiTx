Yuebing 🥮
==========
Yuebingは動画ホスティングサイトを運営するためのオープンソースソフトウェアです。

Yuebingはソース動画を自動的にストリーミング用に最新フォーマットで準備し、
どのデバイスでもどの接続でも再生可能にします。

YuebingはAmazon S3またはBackblaze B2のいずれかをバックエンドストレージとして使用でき、多くの高度な機能を備えています。

### ソース
* [GitHubのyuebing](https://github.com/cobbzilla/yuebing)
* [npmのyuebing](https://www.npmjs.com/package/yuebing)
* [DockerHubのyuebing](https://hub.docker.com/r/cobbzilla/yuebing)

# 他の言語で読む
このREADME.mdドキュメントは、[hokeylization](https://github.com/cobbzilla/hokeylization)を通じて
多くの言語に翻訳されています。

完璧ではないかもしれませんが、何もないよりは良いことを願っています！

&nbsp;&nbsp;&nbsp;[🇸🇦 アラビア語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ar/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇩 ベンガル語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/bn/README.md)
&nbsp;&nbsp;&nbsp;[🇩🇪 ドイツ語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/de/README.md)
&nbsp;&nbsp;&nbsp;[🇺🇸 英語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/en/README.md)
&nbsp;&nbsp;&nbsp;[🇪🇸 スペイン語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/es/README.md)
&nbsp;&nbsp;&nbsp;[🇫🇷 フランス語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/fr/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇩 ハウサ語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ha/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 ヒンディー語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/hi/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇩 インドネシア語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/id/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇹 イタリア語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/it/README.md)
&nbsp;&nbsp;&nbsp;[🇯🇵 日本語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ja/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇷 韓国語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ko/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 マラーティー語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/mr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇱 ポーランド語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pl/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇷 ポルトガル語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pt/README.md)
&nbsp;&nbsp;&nbsp;[🇷🇺 ロシア語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ru/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇪 スワヒリ語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/sw/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇭 タガログ語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tl/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇷 トルコ語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇰 ウルドゥー語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ur/README.md)
&nbsp;&nbsp;&nbsp;[🇻🇳 ベトナム語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/vi/README.md)
&nbsp;&nbsp;&nbsp;[🇨🇳 中国語](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/zh/README.md)
----

# 目次
* [インスピレーション](#Inspiration)
* [特徴](#Features)
* [インストール](#Installation)
  * [Docker](#Docker)
  * [npmパッケージ](#npm-package)
  * [ソースから](#From-source)
* [設定](#Configuration)
  * [nginx設定](#nginx-config)
* [なぜyuebingという名前？](#Why-the-name-yuebing?)

## インスピレーション
昨年、母が大量の時間（そしてお金！）をかけて古い家族ビデオのアーカイブを整理しデジタル化しました。
中には1940年代まで遡る非常に古いものもあり、本当に美しいクラシックな作品です。

これらを家族とプライベートに共有したかったのですが、*大手テック企業とは共有したくありませんでした*。
大手プロバイダの「無料」動画ホスティングは選択肢から外しました。

私たちが求めていたのは：
* セルフホスト型で、完全に**手間いらずで簡単**に運用・維持できること
* 適応ビットレートを含む現代的な動画フォーマットでストリーミング
* デスクトップでもモバイルでもどんなデバイスでも動画が再生できること
* 高帯域幅接続なら動画品質は最高で、可能な限り最高の品質
  * **接続が悪くても**、再生品質は十分で*スキップやバッファリングがない*
* 暗号化されたストレージで、公共クラウドストレージも安心して使えること
* ステートレスサーバー：重要なものは高耐久のストレージに永続化
  * **バックアップを気にしたくない！**
  * *これは望ましい機能でした。実際にはそんなものはどこにもありません。Yuebingにはあります！*
* すべての動画をトランスコードするために高性能インスタンスを使い、その後は長期的に安価な環境で運用
  * Yuebingは月10ドル以下で運用可能で、今後さらに最適化してもっと安くできる見込みです

数週間かけて既存のものを調査しました。要求をかなり緩めても
まともなものは見つかりませんでした。複数のオープンソースプロジェクトを検討しましたが、
どれも複数の明らかな欠点があり、ここでは名前を挙げません。

それで、どうせたいしたことないだろうと考えました。S3をffmpegに繋ぎ、
そこにそこそこのモダンなフロントエンドを載せれば完成、ですよね？
... ええと、作業の大部分は数か月かかりましたが、楽しすぎて止められませんでした！  
皆さんも楽しんでいただけると嬉しいです！

### <a style="text-decoration: none; color: inherit" href="https://open.spotify.com/track/0HEYFRBo4pBLLWjXsAZjod?si=riLTqMknTji7_X_4XzSkGQ&context=spotify%3Aalbum%3A20KGjm5xRROTqP0UY1EVRg">**セルフホスティングの動画サイトを超簡単に作ろう！**</a>

## 機能  
* S3（またはB2）の動画バケットを友人や家族向けのプライベート動画サイトに変換！  
* 1つ以上のソースバケットを接続して生メディアファイルを提供  
* Yuebingはソース動画を最新かつ最も広くサポートされている適応ビットレートストリーミング形式（DASH/mp4）に自動的にトランスコード  
* 全てのデータは宛先バケットに保存されるため、サーバーはいつでも破棄可能  
  * 初期トランスコーディングはCPU最適化インスタンスで実行し、その後ははるかに安価なインスタンスで24/7/365サービスを実行可能  
  * 完全暗号化ストレージ対応（アプリ側暗号化、キーはあなただけが保持）  
  * ソースは常に読み取り専用で、ソース内容は決して変更しない  
  * 新しいメディアファイルの自動および手動スキャン  
* どの程度プライベートまたはパブリックにしたいか？Yuebingは以下をサポート：  
  * 完全プライベート：匿名ユーザーにはメディア非表示、承認されたメールアドレスのみがアカウント作成可能  
  * セミプライベート：匿名ユーザーにはメディア非表示、誰でもユーザーアカウント作成可能  
  * 登録制限付きパブリック：全員にメディア表示、承認されたメールアドレスのみアカウント作成可能  
  * 完全パブリック：全員にメディア表示、誰でもユーザーアカウント作成可能  
* 完全多言語対応！ユーザーに表示されるテキスト（およびその他のロケール固有の要素）はすべてローカライズされたリソースから提供  
  * [コミュニティを支援し、Yuebingを新しい言語に翻訳しよう！](https://github.com/cobbzilla/yuebing/blob/master/docs/localize.md)  
* フル機能の管理コンソール  
* キーワード検索やタグクラウドからの動画検索  
* <a href="https://www.patreon.com/cobbzilla">**あなたの支援でまもなく対応予定**</a>：  
  * より多くのメディアタイプ対応（オーディオ、画像など）  
  * ユーザーアップロードメディア  
  * いいね、シェア、プッシュ通知  
  * 新しい「ソースタイプ」：別のYuebingインスタンス！  
    * 友好的なインスタンス間のフェデレーション：統合検索、ユーザーアカウントなど  

## 匿名ユーザー機能（サイトが匿名訪問者を許可するよう設定されている場合）  
* メディア閲覧  
* メディア視聴！  
* アカウント作成（サイトがアカウント登録を許可するよう設定されている場合）  

## ログインユーザー機能  
* メディア閲覧  
* メディア視聴！  
* コメント追加、コメント編集、コメント削除！

* 友達を招待
* アカウント情報を編集
* アカウントを削除すると、あなたのコメントを含むすべてが削除されます

## 管理者ユーザー機能
* メディアメタデータの編集、サムネイルの表示、選択サムネイルの変更
* メディア変換キューとジョブのステータスを表示
* 新しいスキャンおよびソースメディアのインデックス作成を開始

## サーバー/バックエンド機能
* トランジェント対応、コンテナ内に永続的/重要なデータは一切保存されません。
  * すべての耐久性のあるデータは宛先バケットに保存されます。基本的に、S3をデータベースとして使用しています
* ソースバケットの新しいメディアの自動定期スキャン
* メディアメタデータの追加および変更；編集は宛先バケットに保存され、ソースメディアは決して変更されません
* 出力プロファイルの設定が可能。デフォルトは複数のサブプロファイルを持つDASH-mp4
* ユーザーアカウント情報も宛先バケットに保存され、オプションで暗号化されます
  * 暗号化キーが変更された場合、管理者はWeb管理コンソールでユーザーを新しいキーに移行できます

## インストール
`yuebing`はdocker、npm、またはソースから直接インストールして実行できます。

### Docker
dockerがあれば、Yuebingをすぐに始められます:

    docker run -it cobbzilla/yuebing

### npmパッケージ
    # npmでグローバルインストール
    npm i -g yuebing

    # yarnでグローバルインストール
    yarn global add yuebing

    # これで 'yuebing' コマンドがPATHに入ります
    yuebing

### ソースから
ソースから実行するには、nodejs v16+ と yarn が必要です

    # ソースをクローンして依存関係をインストール
    git clone https://github.com/cobbzilla/yuebing.git
    cd yuebing
    yarn install

    # gitリポジトリの 'yuebing' コマンドを使用
    ./yuebing

    # または、ソースがあるので任意の `yarn` スクリプトを実行可能
    yarn docker-run-dev    # 最速のビルド＆起動、開発用dockerイメージ
    yarn docker-run        # 実行時に高速、製品版dockerイメージ
    yarn dev               # 開発モードでローカルにyuebingを起動
    yarn build             # 製品モード用にローカルでyuebingをビルド
    yarn start             # 製品モードでローカルにyuebingを起動

詳細は[開発者ドキュメント](https://github.com/cobbzilla/yuebing/blob/master/docs/developer.md)を参照してください

## 設定
Yuebingを試すには、何も設定せずに起動しても問題ありません。
`yuebing` を実行すると、起動時に最小限の設定入力を求められます。

長期間Yuebingを運用する予定がある場合は、[設定ドキュメント](https://github.com/cobbzilla/yuebing/blob/master/docs/config.md)を参照して
設定方法の詳細を確認してください。

### nginx設定
YuebingはNuxtアプリであり、nginx（または他のウェブサーバー）を
前段に置いてSSLや必要に応じたレート制限などを処理することを想定しています。

nginxを使用する場合は、こちらの[サンプル設定](https://github.com/cobbzilla/yuebing/blob/master/docs/sample-yuebing-nginx.conf)を利用できます。

## なぜyuebingという名前か？
[ウーロンというウサギ](https://en.wikipedia.org/wiki/Oolong_(rabbit))は、愛らしく有名な
[初期のインターネットミーム](https://duckduckgo.com/?q=oolong+rabbit&ia=images&iax=images)でした。ウーロンは2003年に亡くなり、
ある大人気の動画サービスが登場する2年前のことです！

ウーロンの後継はYuebingと名付けられました。Yuebingはウーロンほど有名ではありませんでしたが、それが問題だったでしょうか？
Yuebingはそれでも成功しました。

さらに興味深いのは、yuebingは[月餅](https://en.wikipedia.org/wiki/Mooncake)
（中国語: [月饼](https://zh.wikipedia.org/wiki/%E6%9C%88%E9%A5%BC)、
日本語: [月餅](https://ja.wikipedia.org/wiki/%E6%9C%88%E9%A4%85)）を意味します。月餅は非常に美味しく、見つけることができます。
さまざまな風味とスタイルがあります。伝統的な地域のスタイルを楽しむもよし、現代の
ベーカーが探求する美味しい未知の領域のエキゾチックなケーキに挑戦するもよし！誰にでもぴったりの月餅があります！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---