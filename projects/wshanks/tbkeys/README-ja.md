[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg)](code_of_conduct.md)

# <a name="intro"></a>tbkeys

`tbkeys` は Thunderbird のアドオンで、[Mousetrap](https://craig.is/killing/mice) を使用してキーシーケンスをカスタムコマンドにバインドします。

## インストール

- [GitHubリリースページ](https://github.com/willsALMANJ/tbkeys/releases)に掲載されているリリースのいずれかから tbkeys.xpi ファイルをダウンロードします。
- Thunderbird のアドオンマネージャーを開きます（ツール->アドオン）。
- 右上の歯車アイコンをクリックして「ファイルからアドオンをインストール...」を選択し、ダウンロードした tbkeys.xpi ファイルを選択します。
- 将来のアップデートがリリースされると、アドオンは GitHubリリースページから自動更新されます。

[addons.thunderbird.net](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/) からも "tbkeys-lite" を検索して Thunderbird アドオンマネージャー経由で、またはこのページから xpi ファイルをダウンロードして上記の手順でインストールできます。

## デフォルトのキー割り当て

メインウィンドウのデフォルトキー割り当ては GMail のキー割り当てをモデルにしています。

| キー | 機能                                             |
| --- | ------------------------------------------------- |
| c   | 新規メッセージの作成                             |
| r   | 返信                                             |
| a   | 全員に返信                                       |
| f   | 転送                                             |
| #   | 削除                                             |
| u   | メールを更新。メッセージタブが開いている場合は閉じる。 |
| j   | 次のメッセージ                                   |
| k   | 前のメッセージ                                   |
| o   | メッセージを開く                                 |
| x   | メッセージをアーカイブ                           |

## キー割り当てのカスタマイズ

キー割り当てをカスタマイズするには、アドオンマネージャーのアドオン項目からアクセスできるアドオンの設定画面の「key bindings」エントリーを編集してください。
キー割り当て設定時に考慮すべき点は以下の通りです：

- 「key bindings」エントリーは JSON オブジェクトで、Mousetrapの構文（[こちら](https://craig.is/killing/mice)参照）に従ったキー割り当てを有効なコマンド（[コマンド構文](#command-syntax)セクション参照）にマッピングします。
- 設定画面には Thunderbird メインウィンドウ用と作成ウィンドウ用に分かれたフィールドがあります。
  他のウィンドウではキー割り当ては発火しません。
- テキスト入力フィールドでは、最初のキーコンボに `shift` 以外の修飾キーが含まれていない限り、キー操作は発動しません。
- 設定ページでは無効なJSONの送信は許可されませんが、キー割り当ての妥当性チェックはそれ以外では行いません。
- この[古いKeyconfigに関するWikiページ](http://kb.mozillazine.org/Keyconfig_extension:_Thunderbird)にも、まだ有効なコマンドがいくつかあります。
- 開発者ツールボックス（メニューの ツール -> 開発者ツール -> 開発者ツールボックス）は、UIを調べて関数を呼び出す要素名を見つけるのに便利です。
- 最初のキーコンビネーションが組み込みショートカットと同じキーシーケンス（例：`ctrl+j ctrl+k`）の定義はサポートされていません。
  修飾キー付きの単一キーは組み込みショートカットを上書きするように割り当て可能ですが、シーケンスは不可です。

### コマンド構文

キー割り当てにはいくつかの異なる形式のコマンドを指定できます。
それらは以下の通りです：

- **シンプルコマンド**: これらのコマンドは `cmd:<command_name>` 形式で、`<command_name>` は Thunderbird の `goDoCommand()` で実行可能なコマンド名です。
  ほとんどのコマンド名は[Thunderbirdのソースコード内のメインコマンドセットファイル](https://hg.mozilla.org/comm-central/file/tip/mail/base/content/mainCommandSet.inc.xhtml)にあります。
- **シンプル関数呼び出し**: これらは `func:<func_name>` 形式で、`<func_name>` は Thunderbird のウィンドウオブジェクト上で定義された関数名です。
  この関数は引数なしで呼び出されます。
- **カスタム関数呼び出し**: これらは `tbkeys:<func_name>` 形式で、`<func_name>` は tbkeys 内で書かれたカスタム関数の名前です。
  現在使用可能なカスタム関数は `closeMessageAndRefresh` のみで、これは最初のタブでなければ開いているタブを閉じて全アカウントを更新します。
  この動作はGMailのキー割り当て `u` の動作を模倣しています。
- **割り当て解除**: これらのエントリは単に `unset` と記述されます。
  `unset` キーバインディングが発動しても何も起きません。
  誤って発動させたくない組み込みのThunderbirdキー割り当てを解除するのに便利です。
- **MailExtensionメッセージ**: これらは `memsg:<extensionID>:<message>` 形式で、`<extensionID>` はメッセージを送るThunderbird拡張機能のID、`<message>` は `browser.runtime.sendMessage()` MailExtension APIを使って拡張機能に送る文字列メッセージです。
  現状、`tbkeys` はコマンドを文字列で保存しているため文字列メッセージのみサポートされていますが、将来的にこの制限は緩和される可能性があります。
- <a name="eval"></a>**Evalコマンド**: これらのエントリは任意のJavaScriptコードを含むことができ、キー割り当てが発動した際に `eval()` で実行されます。
  他のコマンドタイプのプレフィックスに合致しないエントリはすべてevalコマンドとして扱われます。
  **注意:** evalコマンドはtbkeys-liteでは利用できず、代わりにunsetコマンドと同様に動作します。

## よく使われるキー割り当て例

よく使われるキー割り当てのevalコマンド例は以下の通りです：

- **次のタブ**: `window.document.getElementById('tabmail-tabs').advanceSelectedTab(1, true)`
- **前のタブ**: `window.document.getElementById('tabmail-tabs').advanceSelectedTab(-1, true)`
- **タブを閉じる**: `func:CloseTabOrWindow`
- **メッセージ一覧を下にスクロール**: `window.document.getElementById('threadTree').scrollByLines(1)`
- **メッセージ一覧を上にスクロール**: `window.document.getElementById('threadTree').scrollByLines(-1)`
- **メッセージ本文を下にスクロール**:
  - v115+: `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, 100)`
  - v102: `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, 100)`
- **メッセージ本文をスクロールアップ**:
  - v115+: `window.gTabmail.currentAboutMessage.getMessagePaneBrowser().contentWindow.scrollBy(0, -100)`
  - v102: `window.document.getElementById('messagepane').contentDocument.documentElement.getElementsByTagName('body')[0].scrollBy(0, -100)`
- **新しいフォルダーを作成**: `window.goDoCommand('cmd_newFolder')`
- **フィードを購読**: `window.openSubscriptionsDialog(window.GetSelectedMsgFolders()[0])`

## デフォルトのキー割り当ての解除

設定ペインの「Unset singles」ボタンは、メインウィンドウのThunderbirdのデフォルトの単一キー割り当てを解除するために使用できます。
この機能は、tbkeysの設定で現在設定されていない限り、Thunderbirdのすべてのデフォルト単一キーショートカットを`unset`に設定します（つまり、tbkeysの既存の単一キーショートカット設定は上書きしません）。

## <a name="tbkeys-lite"></a>tbkeys と tbkeys-lite

tbkeys-liteは、任意のJavaScriptを実行する機能を除いたtbkeysのバージョンです。

## セキュリティ、プライバシー、および実装

インストール前に、Thunderbirdは拡張機能が「Thunderbirdおよびコンピューターへの完全かつ制限のないアクセス権を持つ」ことを許可するかどうかを尋ねます。
この権限要求の理由は、tbkeysがキー割り当てを監視するためにThunderbirdのユーザーインターフェースにキーリスナーを注入する必要があるためです。
そのために、tbkeysはMailExtensionsより前の古いThunderbird拡張機能インターフェースを使用しています。
このインターフェースは、Thunderbird 68以前のすべての拡張機能が使用していました。
拡張機能ができることをより厳密に制御する新しいMailExtensions APIには、キーボードショートカットAPIがありません。
ThunderbirdにキーボードショートカットAPIを追加することに興味がある場合は、ぜひプロジェクトにコードを貢献してください。
おそらく[このチケット](https://bugzilla.mozilla.org/show_bug.cgi?id=1591730)がThunderbirdの問題トラッカーで出発点になるかもしれません。

tbkeysに関連するセキュリティ考慮事項をさらに議論するためには、その実装を確認する必要があります。
[イントロ](#intro)で述べたように、tbkeysはキー割り当ての管理にMousetrapライブラリを利用しています。
tbkeysのロジックの大部分は[implementation.js](https://raw.githubusercontent.com/wshanks/tbkeys/main/addon/implementation.js)にあり、これは[MailExtension実験](https://developer.thunderbird.net/add-ons/mailextensions/experiments)です。
`implementation.js`は、tbkeysの標準的な（範囲が制限された）MailExtensionから呼び出される実験APIを設定し、キーボードショートカットを関数（解除用のnull関数を含む）にバインドしたり、他の拡張機能に送信するメッセージにバインドしたりすることができます。
`implementation.js`はまた、各ThunderbirdウィンドウにMousetrapを読み込み、Thunderbird特有のUI要素を考慮したMousetrapのキーイベント捕捉条件を調整し、ユーザーが指定した各キー割り当ての動作を実行する関数を定義します。
`implementation.js`が行うのはこれだけです。
ローカルファイルシステムやメッセージデータにアクセスせず、ネットワークにもアクセスしません。

tbkeysがサポートするコマンドモードの一つに[eval](#eval)があります。
このモードは`eval()`を使用して、`implementation.js`内でユーザーが提供した任意のコードをThunderbirdの内部に完全にアクセス可能な状態で実行します。
任意のコードにバインドする必要がない場合は、evalコマンドをサポートしない[tbkeys-lite](#tbkeys-lite)を使うことで多少のセキュリティ向上が期待できます。
tbkeys-liteは[Thunderbirdのアドオンページ](https://addons.thunderbird.net/en-US/thunderbird/addon/tbkeys-lite/)に公開されているバージョンです。
そこに公開されているアドオンは独立した手動レビューを受けています。
開発者と自分の間にそのようなレビューの壁があることで、追加のセキュリティ層が提供されます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---