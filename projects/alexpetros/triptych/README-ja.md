<translate-content># トリプティック - HTMLの新しい属性

[トリプティック](https://alexanderpetros.com/triptych) は、3つの小さなHTML提案のためのポリフィルです：

1. [フォームでPUT、PATCH、DELETEをサポート](https://alexanderpetros.com/triptych/form-http-methods)（[WHATWG issue](https://github.com/whatwg/html/issues/3577#issuecomment-2294931398)）
2. [フォームに包まれていないボタンでHTTPリクエストを可能にする](https://alexanderpetros.com/triptych/button-actions)
3. リンク、フォーム、ボタンがDOMの一部をターゲットにして置換できるようにする

これらの提案の作業は進行中です：最初のものは公開済みで、残りの2つはまもなく公開予定です。
もし関心があれば、ぜひご連絡ください！

ステータス更新はこちらで： [https://alexanderpetros.com/triptych#status](https://alexanderpetros.com/triptych#status)

## 例

リンクがクリックされると、`<main>` が `GET /home:` の結果で置き換えられます：  
</translate-content>
```html
<a href="/home" target="main">Home</a>
<main> <!-- Existing page content --> </main>
```
ボタンがクリックされると、ページ全体を `DELETE /users/354` の結果で置き換えます：

```html
<button action="/users/354" method="DELETE"></button>
```
ボタンがクリックされたとき、ボタンを`DELETE /users/354`の結果に置き換えます。

```html
<button action="/users/354" method="DELETE" target="_this"></button>
```
フォームが送信されると、`<div id=user-info>`を`PUT /users/354`の結果で置き換えます。

```html
<div id="user-info"></div>
<form action="/users/354" method="PUT" target="#user-info">
  <input type="text" name="name">
  <input type="text" name="bio">
  <button>Submit</button>
</form>
```
## 背景と設計目標

Triptychは、HTMLのコア機能であり、かつライブラリエコシステムで最近大きな注目を集めている機能セットの標準互換実装です：宣言的HTTPリクエストと部分的なページ置換。
これらの提案の根拠については、[Big Sky Dev Con 2024での私の講演](https://unplannedobsolescence.com/blog/life-and-death-of-htmx/)に概要を示しています。

HTMLは常に宣言的リクエストをサポートしてきました。
ハイパーリンクはウェブの文法の基本であり、`<a>`タグは開発者にHTTPリクエストとその後のページ遷移を指定させます。
HTML 2.0では`<form>`要素が導入され、開発者は代替HTTPメソッド（`POST`）を指定し、URLクエリパラメータやリクエストボディ経由でユーザー入力を受け取ることができます。

宣言的HTTPリクエストの既存のセマンティクスには2つの大きな欠落があります：HTTPメソッドの全セット（特に`PUT`、`PATCH`、`DELETE`）をサポートしておらず、遷移とフォーム送信という比較的厳格なパラダイムのみをサポートしています。

ライブラリエコシステムはこれら2つの機能に加え、3つ目の機能：ネットワークリクエストの結果を用いたDOMの部分置換に対しても大きな需要を示しています。
これらの機能をサポートする[最も話題のライブラリ](https://risingstars.js.org/2023/en#section-framework)は[htmx](https://htmx.org/)ですが、これだけではありません。
Ruby on Railsを発明した37Signalsは、HTMLインターフェースを持つHTML-over-the-wireフレームワークである[Hotwired](https://hotwired.dev/)を維持しており、部分的なページ置換のための[Turbo](https://turbo.hotwired.dev/)を提供しています。
[Unpoly](https://unpoly.com/)は、ページのフラグメントを置換対象に指定できる属性を追加し、HTTPメソッドの全範囲をサポートしています。

Triptychは、属性ベースのDOM置換をHTML標準に組み込もうとする試みであり、
既存のHTMLセマンティクスに最も適した方法を目指しています。これらの提案の有効性を示し、
HTML標準への追加を推進し、追加されるまでの間はポリフィルとしてその機能を提供することを目的としています。
設計は主に[htmx](https://htmx.org/)と[htmz](https://leanrada.com/htmz/)に触発されています。

Triptychの目標はHTML標準に組み込まれることなので、名前空間付きカスタム属性（`ng-*`、`hx-*`など）を使わず、
既存の（あるいは妥当な）HTML標準属性を後方互換的に使用します。
スクリプトの複雑さの多くは、`target`や`method`などの既存の属性の既存利用を壊さないようにする必要から生じています。


## インストール

まだCDNはありませんが、たとえアップロードしても、[多分使うべきではありません](https://blog.wesleyac.com/posts/why-not-javascript-cdn)。

代わりに、次のようにインストールしてください：

1. `triptych.js`をプロジェクトのフォルダにコピーします。例：`/vendor/triptych-0.1.0.js`
1. そのURLで非常に長いキャッシュ時間（通常は1年）で配信します
1. ドキュメントに次のように含めます：


```html
<script src="/vendor/triptych-0.1-0.js"></script>
```
ファイル名にバージョン番号を必ず含めてください。そうすれば、更新した際にキャッシュされているユーザーが新しいバージョンをダウンロードします。

私は近日中に `npm` にアップロードする予定なので、依存関係として含めて node_modules から直接提供できます（コピーする代わりに）。

## 制限事項

これらの機能は標準に組み込まれることを意図しているため、JavaScript の能力の限界まで望ましいブラウザの動作をシミュレートします。

主な制限はページ全体のナビゲーションに関わります。
POST フォームを送信する際、デフォルトの動作はその URL を URL バーにプッシュし、フォームからの結果の HTML を表示します；
リフレッシュボタンをクリックすると、ユーザーが意図したことを確認した後に POST リクエストが再送信されます。

ボタンやフォームに `target` が指定されていない場合、Triptych は可能な限りページ全体の動作をシミュレートします。
ドキュメント全体を置き換え、[history API](https://developer.mozilla.org/en-US/docs/Web/API/History) を使ってブラウザの URL と履歴を更新します。
「戻る」ボタンの動作は基本的に期待通りに動作するはずです。

しかし、JavaScript の（非常に妥当な）制限により、Triptych はリフレッシュボタンの動作を変更して PUT を再送信させることはできません。
また、POST-リダイレクトパターンの主な利点の一つである現在の JS 環境をリセットすることもシミュレートできません。

さらに、これらすべてのリクエストに対して、リンクをクリックした時と同様にブラウザがロードバーを表示するべきです。
この動作は JavaScript でシミュレート不可能ですが、ブラウザに組み込まれればユーザーに大きな利益をもたらします—これは *すべての* JavaScript フレームワークに欠けている主な要素の一つです。

## 開発

ソース全体は `./triptych.js` にあります。

テストを実行するには、まず `npm install` で開発依存関係をインストールしてください。
その後、ブラウザで `./test/index.html` を開いてテストを実行します。

また、`npm run dev` を実行して手動テストを試すこともできます。

### To-do

* 既存の GET/POST フォームに影響がないことを検証する全ページテストの追加
* サーバーサイドのリターゲティング制御の調査（おそらくヘッダー）
* 進行中のリクエストに対する CSS 属性の調査

## FAQ

### プロジェクトで使うべきですか？

はい、かついいえです。

ポリフィルの伝統的な目的は、その機能が標準になる前にウェブページに機能を提供することです。
Triptych の場合、その機能の一部は JavaScript でシミュレートできません（上記の制限事項を参照）。

この「ポリフィル」の目的は、これらの提案が基本的な HTML の機能をどのように変えるかを示すデモンストレーションを提供することです。
このライブラリの機能セットはサポートしている提案に追随し、フィードバックを組み込む必要があるため、初期段階で強力な後方互換性の保証はできません。
しかし、HTML の作成がどのようになるかを理解するためにぜひ使ってみてください。

### 複数の要素がターゲットにマッチした場合は？

ターゲットは [querySelector API](https://developer.mozilla.org/en-US/docs/Web/API/Document/querySelector) を使って決定されます。これはドキュメントノードを深さ優先の事前順で走査します。
ターゲットはそのアルゴリズムで最初に見つかったマッチする要素になります。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---