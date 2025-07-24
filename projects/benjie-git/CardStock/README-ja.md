# CardStock

## 概要

**CardStock** は、**スタック** と呼ばれるグラフィカルなプログラムを迅速かつ簡単に構築できるクロスプラットフォームツールで、複数のページで構成される **カード** から成り立っています。GUIを構築するためのドローイングプログラムのようなエディタと、イベント駆動型のPythonコードを追加するためのコードエディタを提供します。

![Pong example](https://github.com/benjie-git/CardStock/wiki/images/pong.png?raw=true)

過去にはHyperCardの楽しさとシンプルさを再現しようとした多くのオープンソースプロジェクトがありましたが、私の意見では、HyperCardの魔法のような感覚をもたらしたオープンエンドな可能性と使いやすさを提供したものはありませんでした。そこで、オープンソースの伝統に則り、自分自身で作りました。

CardStockに対する私のビジョンの指針は、重要度の順に以下の通りです：
1. Python初心者から最も経験豊富なシニアソフトウェアエンジニアまで、手軽で理解しやすく、シンプルかつ効率的に使えるように保つこと。
2. 不必要な複雑さを加えずに、可能な限り高い能力を持たせること。

## 機能

### 基本機能
* CardStockはMacOS、Windows、GNU/Linuxでスタックを設計できます。これらのプラットフォーム上で、またChromebookやスマートフォンを含むあらゆる最新のウェブブラウザ上でCardStockスタックを実行できます。
* テキストやグラフィック、画像、ボタン、テキスト入力フィールド、ウェブビューなどのオブジェクトを用いてプログラムを構築できます。
* 独自のPythonコードを使ってオブジェクトを操作し、マウスやキーボードのイベントに応答できます。
* コードからサウンドファイルを再生できます。
* https://openclipart.org と連携し、スタック内でクリップアートを検索・利用できます。
* 必要な場所にコンテキストヘルプが表示され、不要になればオフにできます。
* 完全なUndo/Redoやコードやオブジェクトプロパティ全体にわたる検索・置換機能など、一般的なアプリケーションに期待される快適な機能を備えています。

### 上級機能
* オブジェクトのほとんどのプロパティの変更をアニメーション化し、作品に命を吹き込めます。
* オブジェクトに速度を持たせ、他のオブジェクトに自動でバウンドさせることができます。
* 他のPythonモジュールをコードに**インポート**し、ウェブリクエストの送信や結果の表示、ロボット制御、機械学習コードの実行などをCardStockスタック内で行えます。
* 構文ハイライト、編集中の構文エラーの下線表示、オブジェクト・変数・関数・メソッド・プロパティのオートコンプリートなどの基本的なIDE機能。
* スタック実行中にインタラクティブなコンソールウィンドウでPythonコマンドを実行し、変数値の確認・設定や関数呼び出しなど任意のPythonコードを実行できます。
* 実行中のスタックの変数やオブジェクトをブラウズし、変数ウィンドウでライブに変更できます。
* スタック全体で使用されているすべてのコードを一箇所で閲覧し、行をクリックして該当するオブジェクトのコードエディタのそのイベントの行にジャンプできます。
* 最近のエラーメッセージを表示し、クリックするとDesignerアプリの問題のあるコード行にジャンプできます。
* スタックをスタンドアロンアプリケーションとしてエクスポートし、共有・配布したり、https://cardstock.run 上にアップロードできます。

### 今後の予定
* 使えるサウンドのライブラリを内蔵し、自分でサウンドを録音する機能を追加。
* ループ再生機能の追加。
* CardStockおよびCardStockで学ぶPythonのチュートリアルを増やす。
* 形状をカラ―グラデーションで塗りつぶす機能を追加。
* アプリアイコンの追加。
* バウンド物理演算と衝突検出のパフォーマンス改善。

________
## 既知の問題
* TextFieldやWebViewは常に図形や画像の前面に表示されます。図形や画像はカードビュー上に直接描画されます。
* 視覚的選択表示（青い点線のアウトライン）はネイティブビューの後ろに描画されるため、重なったテキストフィールドやウェブビューの後ろに隠れることがあります。
* スタックは、ソースから実行している場合のみ、追加モジュールのインポートとそれらを含むスタックのエクスポートが可能です。プリビルトアプリケーションではできません。（プリビルトアプリにはrequests、pyserialなどいくつかの追加ライブラリが含まれており、リクエストにより追加も可能です。）
* 皮肉なことに、WebViewは https://cardstock.run のウェブビューアでは動作しません。
* パフォーマンスの理由から、現在ウェブビューア上ではマウスイベントは最前面のオブジェクト、その親グループ、カードの順にしか伝播しません。すべての重なったオブジェクトには伝播しません。

## 動作環境
MacおよびWindowsのプリビルトアプリケーションは外部依存関係なしで動作します。

ソースからCardStockを実行するにはPython 3.9以降（3.11以上推奨）とwxPython 4.1以降（wxPython 4.2.x推奨）が必要です。
attrdict3（Linuxのみ）、wxpython、simpleaudio、PyInstaller、requestsのPythonモジュールのインストールが必要です。  
mp3再生をサポートする場合は、lameパッケージ（mp3デコーダ）とPythonのstreamp3-313compatをインストールする必要があります。

## インストール
以下のいずれかの方法でインストールできます：

### 1. MacまたはWindows用の最新のプリビルトCardStockアプリケーションをダウンロード
#### （Windowsユーザーにはソースからのビルドはかなり大変なので強く推奨します。）
1. こちらからMacまたはWindows用のCardStockをダウンロード：https://github.com/benjie-git/CardStock/releases/latest
2. プリビルトのWindowsアプリはまだコード署名されていないため、初回起動時にWindowsから警告が出ることがあります。「WindowsがPCを保護しました」というウィンドウが表示された場合、警告文末の「詳細情報」をクリックし、ウィンドウ下部に表示される「実行」ボタンをクリックしてください。

### 2. ソースから実行する場合：
1. Python3をインストール
2. このリポジトリをダウンロードまたはクローン
3. Linuxのみ：apt install libasound2-dev libmp3lame-dev libwebkit2gtk-4.0-dev  # Debian/Ubuntu系以外は相当のパッケージ
4. Macのみ：brew install lame
5. mp3サポートを含める場合：pip3 install streamp3-313compat

   lameのヘッダーとライブラリを見つけるためにLDFLAGSとCPPFLAGSの設定が必要な場合があります。

    次のように実行する必要があるかもしれません：

   `CPPFLAGS=-I/opt/homebrew/include LDFLAGS=-L/opt/homebrew/lib pip3 install streamp3-313compat` または 

    `CPPFLAGS=-I/usr/local/include LDFLAGS=-L/usr/local/lib pip3 install streamp3-313compat`

    lameライブラリのインストール場所によります。

6. pip3 install attrdict3  # wxpythonの前にこれをインストールする必要があります
7. pip3 install -r requirements.txt  # wxpythonのビルドには時間がかかることがあります
8. python3 designer.py を実行
9. 必要に応じてbuild.pyを実行し、CardStock Designerアプリケーションのスタンドアロンアプリを作成

### 3. pip/pypiでインストール：
1. Linuxのみ：apt install libasound2-dev libmp3lame-dev libwebkit2gtk-4.0-dev  # Debian/Ubuntu系以外は相当のパッケージ
2. Macのみ：brew install lame
3. mp3サポートを含める場合：pip3 install streamp3-313compat

   lameのヘッダーとライブラリを見つけるためにLDFLAGSとCPPFLAGSの設定が必要な場合があります。

    次のように実行する必要があるかもしれません：

   `CPPFLAGS=-I/opt/homebrew/include LDFLAGS=-L/opt/homebrew/lib pip3 install streamp3-313compat` または 

    `CPPFLAGS=-I/usr/local/include LDFLAGS=-L/usr/local/lib pip3 install streamp3-313compat`

    lameライブラリがどこにインストールされたかによります。
4. pip3 install attrdict3  # wxpythonのためにこれを最初にインストールする必要があります
5. pip3 install cardstock  # 依存関係のwxpythonのビルドには非常に長い時間がかかることがあります
6. 新しくインストールされたcardstockコマンドを使って実行します


## 参考資料
* [CardStock Wiki](https://github.com/benjie-git/CardStock/wiki)
* [CardStock on Reddit](https://www.reddit.com/r/CardStockPython/)
* [CardStock マニュアル](https://github.com/benjie-git/CardStock/wiki/Manual)
* [CardStock チュートリアル](https://github.com/benjie-git/CardStock/wiki/Tutorial-Dice)
* [CardStock リファレンスガイド](https://github.com/benjie-git/CardStock/wiki/Reference)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---