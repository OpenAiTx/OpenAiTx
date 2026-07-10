# Obsidian Orgmode CM6

[Orgmode](https://orgmode.org) は [Obsidian](https://obsidian.md) 用です。

![Screenshot](https://raw.githubusercontent.com/BBazard/obsidian-orgmode-cm6/master/./screenshot.png)

## 使用方法

デフォルトでは org ファイルはサイドバーに表示されません。
表示するには、Obsidian の設定の「Files and links」セクションに入り、「Detect all file extensions」をチェックする必要があります。

![detect-all-file-extensions](https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/e6a91e66-295d-4057-bf80-e43dcdb8e3e7)

ボールト内に org ファイルを作成するには、現在 Obsidian では非マークダウンファイルの作成ができないため、Obsidian の外で作成する必要があります。

まだ org ファイルを持っていない場合は、`todo.org` という名前のファイルを以下の内容で作成してみてください：

```org
* TODO [#A] A task with *high* priority

The description of the task

* A collapsed section

You cannot see the description when collapsed

* DONE something done already :sometag:
SCHEDULED: <2023-12-08 Fri 11:13>
:PROPERTIES:
:CREATED: [2023-12-03 Sun 10:48]
:END:

a [[https://github.com/BBazard/obsidian-orgmode-cm6][link]]

#+begin_src javascript
const block = "highlighted"
#+end_src
```
## サポートされている機能

### Orgmode エディター

- ライブプレビュー
- シンタックスハイライト（上書き可能なCSSクラス付き）
- 設定でカスタマイズ可能なTodoキーワード
- 折りたたみ（要素の最初の行のガターをクリックすると折りたたみ可能）
- Wikiリンク（`[[unicorn]]` はボールト内の unicorn.org ファイルを開くか、なければ unicorn.md にフォールバック）
- インライン画像（`[[myimage.png]]` はボールト内に画像があれば表示）
- IDリンク（`[[id:12345]]` はボールト内の任意のorgファイルのプロパティドロワー内の対応する :ID: を持つ見出しにリダイレクト）
- Vimサポート（Obsidianで有効化されている場合）
- ソースブロックのハイライト（対応言語: c, c++, css, html, java, javascript, json, php, python, rust, sass, xml）

### Orgmode パーサー（シンタックスハイライト）

[Org Syntax](https://orgmode.org/worg/org-syntax.html) に準拠

- [x] 見出し（ネスト対応、COMMENT見出しは非対応）
- [x] セクション（ゼロセクションを含む）
- [x] テキストマークアップ（太字、斜体、下線など）
- [x] リンク（通常リンク、角括弧リンク、プレーンリンク）
- [x] マークアップとリンクの組み合わせ
- [x] コメント行
- [x] キーワード行
- [x] プランニング行
- [x] プロパティドロワー
- [x] 小ブロック（ソースブロックを除きフォーマットなし）
- [ ] 動的ブロック（Obsidianがプラグインで任意実行を許可しないため不可能）
- [ ] ドロワー
- [ ] リストとチェックボックス
- [ ] 水平線
- [ ] タイムスタンプ
- [ ] クロック
- [ ] 日記S式
- [ ] 脚注
- [ ] テーブル
- [ ] LaTeX
- [ ] 固定幅行（代わりにブロックを使用可能）

## 実装の詳細

- orgmode ファイルは、マークダウンファイルで使用されるものとは別の [codemirror 6](https://codemirror.net) インスタンスで処理されます。つまり、プラグインはマークダウンファイルで動作するすべての機能を再実装する必要があります。

- パーサーは orgmode ファイルを読み込み、カスタムトークナイザーを使用した [lezer](https://lezer.codemirror.net) 文法により構文ノードのツリーを構築します。このアプローチは Emacs の正規表現ベースの手法よりもトークンのマッチングを正確に行うことを可能にします。例えば、プランニング行は見出しの後にのみマッチし、セクションの途中ではマッチしません。

- 重複するトークンは有効とみなされません。例えば `*one _two three* four_` を考えてみましょう。Emacs は正規表現を使い、`*one _two three*` を太字、`_two three* four_` を下線とします。lezer パーサーは代わりに `*one _two three*` を太字、` four_` を通常テキストとみなし、テキストマークアップの範囲を独自の構文ノードとして持つことを可能にしています。

- 見出しのレベル（Inlinetask のようなもの）は無制限であり、テキストマークアップの行数にも制限はありません。

## マークダウンファイルに orgmode タスクを表示する

この機能は不安定であり、将来的に互換性を壊す形で変更される可能性があります。

現在は TODO と DONE のみが処理されます。

https://github.com/BBazard/obsidian-orgmode-cm6/assets/10139245/b071b2c8-b56e-4050-8fcf-02a922fdd1c0

フィルターには [orgzly 検索式](https://www.orgzly.com/docs#search) がサポートされています（実装済み：s, d, c, i, it, ad）。


```orgmode-tasks
filepath: Orgmode/Orgmode file.org
query: it.todo or it.done
```

## 開発

```
git clone https://github.com/bbazard/obsidian-orgmode-cm6
cd obsidian-orgmode-cm6
npm install
npm run build
npm test
cp main.js styles.css manifest.json "$OBSIDIAN_VAULT"/.obsidian/plugins/obsidian-orgmode-cm6/
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-10

---