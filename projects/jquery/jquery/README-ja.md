# [jQuery](https://jquery.com/) — 新世代JavaScript

ミーティングは現在、[matrix.orgプラットフォーム](https://matrix.to/#/#jquery_meeting:gitter.im)で開催されています。

ミーティングの議事録は[meetings.jquery.org](https://meetings.jquery.org/category/core/)で閲覧できます。

jQueryの最新バージョンは[https://jquery.com/download/](https://jquery.com/download/)から入手可能です。

## バージョンサポート

| バージョン | ブランチ      | ステータス |
| ---------- | ------------ | ---------- |
| 4.x        | main         | Beta       |
| 3.x        | 3.x-stable   | Active     |
| 2.x        | 2.x-stable   | Inactive   |
| 1.x        | 1.x-stable   | Inactive   |

4.0.0の正式版がリリースされると、3.xブランチは期間限定でアップデートが続けられます。2.xおよび1.xブランチは既にサポートされていません。

非アクティブバージョンの商用サポートは[HeroDevs](https://herodevs.com/nes)から提供されています。

[バージョンサポート](https://jquery.com/support/)の詳細についてはこちらをご覧ください。

## コントリビューションガイド

オープンソースソフトウェア開発の精神に則り、jQueryは常にコミュニティによるコードの貢献を奨励しています。コーディングを始める前に、以下の重要なコントリビューションガイドラインを必ずよく読んでください。

1. [参加方法](https://contribute.jquery.org/)
2. [コアスタイルガイド](https://contribute.jquery.org/style-guide/js/)
3. [jQueryプロジェクト向けのコードの書き方](https://contribute.jquery.org/code/)

### イシュー/PRへの参照

GitHubのイシュー/PRは通常、`gh-NUMBER`の形式で参照されます。`NUMBER`はイシュー/PRの数値IDです。該当するイシュー/PRは`https://github.com/jquery/jquery/issues/NUMBER`で確認できます。

jQueryは過去にTracベースの異なるバグトラッカーを使用しており、[bugs.jquery.com](https://bugs.jquery.com/)で閲覧可能です。これはリードオンリーモードで保持されており、過去の議論を参照できます。jQueryのソースがこれらのイシューを参照する場合、`trac-NUMBER`の形式を使用します。該当するイシューは`https://bugs.jquery.com/ticket/NUMBER`で確認できます。

## jQueryが使用できる環境

- [ブラウザサポート](https://jquery.com/browser-support/)
- jQueryはNode、ブラウザ拡張機能、その他の非ブラウザ環境もサポートしています。

## jQueryをビルドするために必要なもの

jQueryをビルドするには、最新のNode.js/npmとgit 1.7以降が必要です。以前のバージョンでも動作する可能性はありますが、サポートされていません。

Windowsの場合は、[git](https://git-scm.com/downloads)および[Node.js](https://nodejs.org/en/download/)をダウンロードしてインストールしてください。

macOSユーザーは[Homebrew](https://brew.sh/)をインストールしてください。Homebrewをインストール後、`brew install git`でgitを、`brew install node`でNode.jsをインストールします。

Linux/BSDユーザーは、各自のパッケージマネージャを使ってgitとNode.jsをインストールするか、ソースからビルドしてください。簡単です。

## jQueryのビルド方法

まず、[jQueryのgitリポジトリをクローン](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)します。

その後、jqueryディレクトリに入り、依存関係をインストールし、ビルドスクリプトを実行します。

```bash
cd jquery
npm install
npm run build
```

ビルドされたjQueryは`dist/`ディレクトリに配置され、ミニファイされたコピーと関連するマップファイルも含まれます。

## 全jQueryリリースファイルのビルド

すべてのjQueryバリアントをビルドするには、以下のコマンドを実行します。

```bash
npm run build:all
```

この操作により、`jquery.js`、`jquery.slim.js`、`jquery.module.js`、`jquery.slim.module.js`など、リリースに含まれる全てのバリアントと、それぞれのミニファイ版・ソースマップが作成されます。

`jquery.module.js`および`jquery.slim.module.js`は[ECMAScriptモジュール](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)で、`jQuery`と`$`を名前付きエクスポートとしてエクスポートし、`dist/`ディレクトリではなく`dist-module/`ディレクトリに配置されます。

## カスタムjQueryのビルド

ビルドスクリプトを使って、必要なモジュールだけを含めたカスタムjQueryを作成できます。

`core`以外のどのモジュールも除外可能です。`selector`を除外した場合、完全に削除されるのではなく、ネイティブの`querySelectorAll`の小さなラッパーに置き換えられます（詳細は下記参照）。

### ビルドスクリプトのヘルプ

ビルドスクリプトの利用可能な全オプションを見るには、次のコマンドを実行してください。

```bash
npm run build -- --help
```

### モジュール

モジュールを除外するには、`src`フォルダからの相対パス（`.js`拡張子なし）を`--exclude`オプションに渡します。`--include`オプションを使うと、デフォルトのインクルードが省かれ、指定したモジュールのみでビルドされます。

除外または含めることができる主なモジュール例は以下の通りです。

- **ajax**: すべてのAJAX機能：`$.ajax()`、`$.get()`、`$.post()`、`$.ajaxSetup()`、`.load()`、トランスポート、`.ajaxStart()`などのAJAXイベントショートハンド。
- **ajax/xhr**: XMLHTTPRequest AJAXトランスポートのみ。
- **ajax/script**: `<script>`AJAXトランスポートのみ。スクリプトの取得に使用。
- **ajax/jsonp**: JSONP AJAXトランスポートのみ。ajax/scriptトランスポートに依存。
- **css**: `.css()`メソッド。また、cssに依存する**全て**のモジュール（**effects**、**dimensions**、**offset**を含む）も削除。
- **css/showHide**: 非アニメーションの`.show()`、`.hide()`、`.toggle()`；クラスや明示的な`.css()`で`display`プロパティを設定する場合は除外可。**effects**モジュールも削除。
- **deprecated**: 非推奨としてドキュメント化されているが未削除のメソッド。
- **dimensions**: `.width()`、`.height()`メソッドおよび`inner-`/`outer-`バリエーション。
- **effects**: `.animate()`メソッドおよび`.slideUp()`や`.hide("slow")`などのショートハンド。
- **event**: `.on()`、`.off()`メソッドと全イベント機能。
- **event/trigger**: `.trigger()`、`.triggerHandler()`メソッド。
- **offset**: `.offset()`、`.position()`、`.offsetParent()`、`.scrollLeft()`、`.scrollTop()`メソッド。
- **wrap**: `.wrap()`、`.wrapAll()`、`.wrapInner()`、`.unwrap()`メソッド。
- **core/ready**: スクリプトをbodyの末尾に配置する場合、readyモジュールを除外可。`jQuery()`でバインドされたreadyコールバックは即時実行されますが、`jQuery(document).ready()`は関数ではなくなり、`.on("ready", ...)`等は発火しません。
- **deferred**: jQuery.Deferredを除外。これに依存する**ajax**、**effects**、**queue**も同時に除外されますが、**core/ready**は**core/ready-no-deferred**に置き換えられます。
- **exports/global**: グローバルなjQuery変数（$とjQuery）をwindowにアタッチしないようにする。
- **exports/amd**: AMD定義を除外。

- **selector**: jQueryのフルセレクターエンジン。このモジュールを除外すると、ブラウザの`querySelectorAll`を利用した簡易セレクターエンジンに置き換えられ、jQueryセレクター拡張や高度なセマンティクスはサポートされません。詳細は[selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js)ファイルを参照してください。

*注意*: フル`selector`モジュールを除外すると、全てのjQueryセレクター拡張（`effects/animatedSelector`や`css/hiddenVisibleSelectors`など）も除外されます。

##### AMD名

jQueryのAMD定義のモジュール名を設定できます。デフォルトでは"jquery"ですが、変更したい場合は`--amd`パラメータに指定してください。

```bash
npm run build -- --amd="custom-name"
```

あるいは、無名で定義したい場合は名前を空欄にします。

```bash
npm run build -- --amd
```

##### ファイル名とディレクトリ

ビルドされたjQueryファイルのデフォルト名は`jquery.js`で、`dist/`ディレクトリ下に配置されます。`--filename`でファイル名、`--dir`でディレクトリを変更可能です。`--dir`はプロジェクトルートからの相対パスです。

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

この場合、スリム版jQueryが`tmp/jquery.slim.js`に配置されます。

##### ECMAScriptモジュール（ESM）モード

デフォルトでは、jQueryは通常のスクリプトJavaScriptファイルを生成します。`--esm`パラメータを使うと、`jQuery`をデフォルトエクスポートするECMAScriptモジュールを生成できます。

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### ファクトリーモード

デフォルトではjQueryはグローバルな`window`に依存します。`window`が存在しない環境向けには、外部から`window`を受け取る関数を公開するファクトリービルドを生成できます（利用方法は[公開パッケージの`README`](build/fixtures/README.md)を参照）。`--factory`パラメータで生成できます。

```bash
npm run build -- --filename=jquery.factory.js --factory
```

このオプションは、`--esm`や`--slim`など他のオプションと組み合わせて利用可能です。

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### カスタムビルド例

`npm run build`を使い、除外するモジュールを列挙してカスタムビルドを作成します。トップレベルモジュールを除外すると、対応するディレクトリ内のモジュールも同時に除外されます。

**ajax**機能を全て除外：

```bash
npm run build -- --exclude=ajax
```

**css**を除外すると、CSSに依存する**effects**、**offset**、**dimensions**も削除されます。

```bash
npm run build -- --exclude=css
```

複数のモジュールを除外（`-e`は`--exclude`のエイリアス）：

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

公式のjQuery Slimビルドと同じ構成でビルドする特別なエイリアスもあります。

```bash
npm run build -- --filename=jquery.slim.js --slim
```

また、スリムビルドをesmモジュールとして作成する場合：

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*非公式のカスタムビルドは定期的にテストされていません。自己責任でご利用ください。*

## ユニットテストの実行

必要な依存関係をインストールしてください:

```bash
npm install
```

作業中に自動的にjQueryをビルドするには `npm start` を起動します:

```bash
npm start
```

PHPをサポートするローカルサーバーでユニットテストを実行します。サイトはルートディレクトリから実行し、「test」ディレクトリからではないことを確認してください。データベースは不要です。WindowsおよびMac向けの事前設定済みPHPローカルサーバーが利用可能です。以下はその例です:

- Windows: [WAMPダウンロード](https://www.wampserver.com/en/)
- Mac: [MAMPダウンロード](https://www.mamp.info/en/downloads/)
- Linux: [LAMPのセットアップ](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose（ほとんどのプラットフォーム）](https://code.google.com/p/mongoose/)

## 必須のGit操作

ソースコードはGitバージョン管理システムで管理されているため、よく使われる機能について知っておくと便利です。

### クリーンアップ

作業ディレクトリをupstreamの状態に戻したい場合、以下のコマンドを使用できます（これらを実行すると作業内容はすべて消去されるのでご注意ください）:

```bash
git reset --hard upstream/main
git clean -fdx
```

### リベース

機能/トピックブランチでは、常に`git pull`に`--rebase`フラグを使うべきです。また、一時的な「githubプルリクエスト予定」のブランチを多く扱う場合は、以下を実行して自動化できます:

```bash
git config branch.autosetuprebase local
```

（詳細は `man git-config` を参照してください）

### マージコンフリクトの処理

マージ時にコンフリクトが発生した場合、手動でファイルを編集する代わりに
`git mergetool` 機能を使うことができます。デフォルトのツール`xxdiff`は見た目が古いですが、非常に便利です。

ここで使える主なコマンドは以下の通りです:

- `Ctrl + Alt + M` - 可能な限り自動マージ
- `b` - 次のマージコンフリクトにジャンプ
- `s` - コンフリクトした行の順序を変更
- `u` - マージを元に戻す
- `左クリック` - ブロックを勝者としてマーク
- `中クリック` - 行を勝者としてマーク
- `Ctrl + S` - 保存
- `Ctrl + Q` - 終了

## [QUnit](https://api.qunitjs.com) リファレンス

### テストメソッド

```js
expect( numAssertions );
stop();
start();
```

*注*: QUnitのstop/startへの引数追加予定は本テストスイートでは無視されています。そのため、startやstopをコールバックとして渡す際に引数を気にする必要はありません。

### テストアサーション

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## テストスイートの便利なメソッドリファレンス

[https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js](https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js) を参照してください。

### 指定したIDを持つ要素の配列を返す

```js
q( ... );
```

例:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### セレクタが指定したIDにマッチするかアサートする

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

例:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### jQueryを経由せずにネイティブDOMイベントを発火

```js
fireNative( node, eventType );
```

例:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### キャッシュ防止のためURLにランダムな数値を追加

```js
url( "some/url" );
```

例:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### iframe内でテストを実行

一部のテストは標準のテストフィクスチャとは異なるドキュメントを必要とする場合があり、
これらは別のiframe内で実行できます。実際のテストコードやアサーションは
jQueryのメインテストファイルに残し、iframeファイルには最小限のテストフィクスチャマークアップと
セットアップコードのみを配置するようにしてください。

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

これは fileName `"./data/" + fileName` でURLを構築しページを読み込みます。
iframe化されたページは「/test/data/iframeTest.js」スクリプトを含め、
適切なタイミングで `startIframeTest( [ additional args ] )` を呼び出すことで
テストコールバックの実行タイミングを決定します。多くの場合、これは
document readyまたは`window.onload`後になります。

`testCallback`はこのテストのために`testIframe`によって生成されたQUnitの`assert`オブジェクト、
続いてiframe内のグローバルな`jQuery`、`window`、`document`を受け取ります。
iframeコードが`startIframeTest`に引数を渡した場合、それらは`document`引数の後に続きます。

## 質問がありますか？

ご質問がある場合は、[Developing jQuery Core フォーラム](https://forum.jquery.com/developing-jquery-core) または [libera](https://web.libera.chat/) の #jquery チャンネルでお気軽にお尋ねください。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---