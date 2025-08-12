# Stixview

[![npm version](https://badge.fury.io/js/stixview.svg)](https://badge.fury.io/js/stixview)

[Stixview](https://github.com/traut/stixview) は埋め込み可能なインタラクティブな STIX2 グラフのための JS ライブラリです。

> [!NOTE]  
> Stixview のホスティング版は [CTIChef.com](https://ctichef.com) で利用可能です

![Stixview graph](https://raw.githubusercontent.com/traut/stixview/master/.github/stixview-graph.png)

## 動機

CTI（サイバー脅威インテリジェンス）は非常に物語を語ることに関係しています。情報は文脈を伴い物語の中に配置されることでインテリジェンスとなります。これらの物語は通常、インテリジェンス提供者によってレポートに結晶化され、顧客に配布されます。

インテリジェンス提供者が構造化された機械可読の CTI を重視する場合、作成されるレポートには [STIX2](https://oasis-open.github.io/cti-documentation/) バンドルが補足されます。レポートで語られる物語と、STIX2 バンドルで表現される構造化された CTI スナップショットの間にはギャップがあります。

[Stixview](https://github.com/traut/stixview) ライブラリの目的は、必要なレベルのインタラクティビティを備えた埋め込み可能な STIX2 グラフを提供し、CTI コミュニティが情報豊かで魅力的な物語を作成できるようにすることです。

## デモ

Stixview の動作を見るには、以下のデモページをご覧ください：

* [STIX2.1 デモ](https://traut.github.io/stixview/dist/demos/stix21-demo.html) — 全ての STIX 2.1 オブジェクトを含むサンプルグラフ。
* [ストーリーライン](https://traut.github.io/stixview/dist/demos/story.html) — 複数のグラフをページに表示し、同一 STIX バンドルから選択したエンティティを描画。
* [ビューア](https://traut.github.io/stixview/dist/demos/viewer.html) — カスタムコントロール付きグラフビューア。
* [ドラッグアンドドロップ](https://traut.github.io/stixview/dist/demos/drag-n-drop.html) — ドラッグアンドドロップが有効なグラフビュー。
* [インラインデータからのダークテーマグラフ](https://traut.github.io/stixview/dist/demos/load-data.html) — インラインの STIX2 バンドルとカスタムスタイルからのグラフ描画。
* [TLP タグとカスタムサイドバーコンテンツレンダラー](https://traut.github.io/stixview/dist/demos/tags-and-custom-sidebar.html) — タグとして表示される TLP マーキング定義と、提供された関数でレンダリングされるサイドバー。
* [様々な設定例](https://traut.github.io/stixview/dist/demos/misc.html)

## 使用方法

ブラウザで Stixview を使用するには、`dist` ディレクトリの最新ビルド (`stixview.bundle.js`) をダウンロードし、HTML ファイルから参照してください：

```html
<script src="stixview.bundle.js" type="text/javascript"></script>
```
または [unpkg](https://unpkg.com) CDN サービスを使用してください:


```html
<script src="https://unpkg.com/stixview/dist/stixview.bundle.js" type="text/javascript"></script>
```

## API

このライブラリは[データ属性](https://developer.mozilla.org/en-US/docs/Learn/HTML/Howto/Use_data_attributes)に大きく依存しています。  
ページの読み込み時に、Stixviewは`data-stix-gist-id`、`data-stix-url`、または`data-stix-allow-dragdrop`が設定されたすべてのHTML要素を見つけ、これらの要素をグラフホルダーとして使用します。  

グラフホルダーdivの例:

```html
<div data-stix-gist-id="6a0fbb0f6e7faf063c748b23f9c7dc62"
     data-show-sidebar=true
     data-enable-mouse-zoom=false
     data-graph-width=500
     data-graph-height=300>
</div>
```
### データ属性

すべてのホルダー要素は、`data-stix-gist-id`、`data-stix-url`、または `data-stix-allow-dragdrop` のいずれかを設定している必要があります。設定されていない場合、ライブラリによって検出されません。

Stixview は以下の `data-` 属性をサポートしています：

* `stix-gist-id` — STIX2 バンドルを含む gist のID。`gist-file` が指定されていない場合は最初のファイルが使用されます。
* `gist-file` — gist 内のファイル名で、STIX2 バンドルとして使用されます。`stix-gist-id` が設定されている場合のみ使用されます。
* `stix-url` — リモートの STIX2 バンドル JSON ファイルを指すURL。
* `stix-allow-dragdrop`（デフォルトは `false`）— STIX2 バンドルをグラフ要素にドラッグアンドドロップできる機能を有効にします。このプロパティが `true` に設定され、かつ `stix-gist-id` と `stix-url` が指定されていない場合は、空のグラフがレンダリングされます。
* `caption` — グラフのタイトル。`caption` が設定されていない場合、ヘッダーは表示されません。
* `show-footer`（デフォルトは `true`）— STIX2 バンドルおよび PNG ファイルのダウンロードリンクを含むフッターを表示します。
* `show-sidebar`（デフォルトは `true`）— オブジェクトの詳細を表示するサイドバーを有効にし、オブジェクトがクリックされたときに開きます。
* `show-tlp-as-tags`（デフォルトは `true`）— 関連付けられた TLP マーキング定義オブジェクトをエンティティのタグとして表示します。
* `show-marking-nodes`（デフォルトは `true`）— マーキング定義ノードを表示します。
* `show-labels`（デフォルトは `true`）— ノードラベルを表示します。
* `show-idrefs`（デフォルトは `false`）— 関係内で言及されているがバンドルに存在しないIDのプレースホルダーオブジェクトを表示します。
* `graph-layout`（デフォルトは `cola`）— グラフレイアウトアルゴリズムの名前。サポートされているアルゴリズムは `cola`、`klay`、`cose-bilkent`、`cise`、`grid`、`dagre` です。
* `enable-mouse-zoom`（デフォルトは `true`）— マウスホイールズームを有効にします。
* `enable-panning`（デフォルトは `true`）— グラフのパン操作を有効にします。`false` の場合、グラフのビューは固定されますが、ユーザーはノードをドラッグできます。
* `highlighted-objects` — カンマ区切りの STIX2 ID の文字列。設定されている場合、グラフには _指定されたIDのオブジェクトのみ_ が含まれます。
* `hidden-objects` — カンマ区切りの STIX2 ID の文字列。設定されている場合、指定されたIDのオブジェクトはスキップされ、グラフにレンダリングされません。
* `min-zoom`（デフォルトは `0.3`）— 許可される最小ズーム。
* `max-zoom`（デフォルトは `2.5`）— 許可される最大ズーム。
* `graph-width`（デフォルトは利用可能な幅すべて）— グラフ要素の幅。ピクセル値とパーセント値の両方をサポート（詳細はmiscデモページ参照）。
* `graph-height`（デフォルトは `600` ピクセル）— グラフ要素の高さ。ピクセル値とパーセント値の両方をサポート（詳細はmiscデモページ参照）。

### ブラウザオブジェクト

ブラウザで使用する場合、ライブラリは `window` オブジェクトに `stixview` 変数を登録し、以下のプロパティを持ちます：

* `registry` — ページ上で初期化されたグラフのレジストリ。
* `onInit(selector, callback)` — 指定された `selector` にマッチする DOM 要素のグラフ初期化イベントのリスナーフック（使用例は[デモ](https://traut.github.io/stixview/dist/demos/viewer.html)参照）。コールバックはグラフインターフェースのインスタンスを受け取ります。
* `onLoad(selector, callback)` — 指定された `selector` にマッチする DOM 要素のグラフロードイベントのリスナーフック（使用例は[デモ](https://traut.github.io/stixview/dist/demos/viewer.html)参照）。コールバックはグラフインターフェースのインスタンスを受け取ります。
* `init(element, properties, initCallback, loadCallback)` — 指定した `element` にデフォルトを上書きする `properties` を使ってグラフビューを初期化するメソッド（使用例は[デモ](https://traut.github.io/stixview/dist/demos/load-data.html)参照）。

### グラフオブジェクト

グラフは以下のプロパティを持つオブジェクトです：


* `cy` – [cytoscape.js](http://js.cytoscape.org) グラフオブジェクト。
* `element` — グラフを保持するDOM要素。
* `dataProps` – 設定されたデータフィルタリングプロパティ。
* `viewProps` – 設定された表示プロパティ。
* `runLayout(name)` — 指定したレイアウトをグラフに適用する。
* `reloadData()` — 新しいデータフィルタリングプロパティでグラフデータを再読み込みする。
* `fit()` — グラフをビューに完全にフィットさせる。
* `toggleLabels(<bool-value>)` — ノードラベルの表示/非表示を切り替える。
* `toggleLoading(<bool-value>)` — ローディングオーバーレイの表示/非表示を切り替える。
* `loadData(data)` — `data` JSONオブジェクトからSTIX2バンドルを読み込み、グラフに描画する。
* `loadDataFromFile(file)` — `file` ファイルオブジェクトからSTIX2バンドルを読み込み、グラフに描画する。
* `loadDataFromUrl(url)` — リモートURLからSTIX2バンドルを読み込み、グラフに描画する。
* `loadDataFromParamUrl(paramName)` — HTTP GETパラメータ名`paramName`で設定されたリモートURLからSTIX2バンドルを読み込み、グラフに描画する。

## ビルド

```shell
yarn build
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---