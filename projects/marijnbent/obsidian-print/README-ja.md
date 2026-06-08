# Print

Printプラグインは、Obsidianの作業スペースに印刷ツールを追加します。現在のノート、テキストの選択範囲、またはフォルダ内のすべてのノートをコマンドパレット、プリンタリボン、またはコンテキストメニューから印刷できます。もし気に入ったり役立った場合は、GitHubで[スター ![GitHub Repo stars](https://img.shields.io/github/stars/marijnbent/obsidian-print?style=social)](https://github.com/marijnbent/obsidian-print)をつけていただけると嬉しいです。

https://github.com/user-attachments/assets/5882f08c-19e6-46da-b808-608b95376979

*プラグイン使用中の画面録画。*

## 機能

- **現在のノートを印刷**：コマンドパレット、プリンタリボン、またはノートの右クリックから印刷をトリガーします。
- **選択範囲を印刷**：アクティブエディターで選択したテキストのみを印刷します。
- **フォルダ内のすべてのノートを印刷**：フォルダを右クリックするか、コマンドパレットを使用してそのフォルダ内のすべてのマークダウンノートを印刷します。

印刷アクションにショートカットを追加して、さらに素早くアクセスすることも可能です。

| | |
|:------:|:-------------------------:|
|![image](https://github.com/user-attachments/assets/8ba2959c-20a2-4cab-8ae7-c2f5f2475217)|![image](https://github.com/user-attachments/assets/ddb54bd0-4b58-410f-9d69-0f6a58b2ddfd)

## サポート

このプラグインを楽しんでいただけているなら、ぜひ[https://www.buymeacoffee.com/marijnbent](https://www.buymeacoffee.com/marijnbent)でコーヒーをご馳走して、私の仕事と情熱を支援してください。

<a href="https://www.buymeacoffee.com/marijnbent"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a coffee&emoji=&slug=marijnbent&button_colour=6495ED&font_colour=ffffff&font_family=Lato&outline_colour=000000&coffee_colour=FFDD00"></a>

## はじめに

### コミュニティプラグインストアからインストール

1. Obsidianを開き、**設定** > **コミュニティプラグイン**に移動します。
2. **ブラウズ**をクリックし、**Print**を検索します。
3. **インストール**をクリックしてプラグインをObsidianに追加します。
4. インストール後、プラグインを有効化し、必要に応じて設定ページに移動します。

頻繁に印刷する場合は、1つ以上の印刷コマンドにショートカットを追加することをお勧めします。**設定** > **ホットキー**に行き、`print`で検索し、お好みのショートカットを割り当ててください。

## 設定


- **ノートタイトルを印刷**: 印刷時にノートタイトルを含めます。  
- **プロパティを印刷**: 印刷ノートの先頭にノートのプロパティ/フロントマターを含めます。  
- **フォントサイズと見出しサイズ**: **Normalize style** が有効な場合、本文テキストと見出しのサイズを調整します。  
- **フォルダ内のノートを結合**: フォルダ内の全ノートを印刷する際にノート間の改ページを削除します。  
- **水平線を改ページとして扱う**: `---` セパレーターを印刷時のページ区切りとして解釈します。  
- **デバッグモード**: 生成されたHTMLとCSSの別ウィンドウを開き、スタイルの問題をトラブルシュートできます。  
- **ノートの `cssclasses` を継承**: Obsidianノートの `cssclasses` を印刷出力に適用し、ノート固有の印刷CSSを引き継ぎます。  
- **Normalize style**: アクティブなObsidianテーマのスタイルを引き継ぐ代わりに、中立的な組み込み印刷スタイルを使用します。  
- **カスタムCSS**: 詳細設定で、ObsidianのCSSスニペットフォルダ内の `print.css` スニペットを利用可能な場合、有効化できます。  

![image](https://github.com/user-attachments/assets/2ffed185-cc8f-43d9-8444-7cb9657d61f7)  

## CSSのカスタマイズ  

設定では、タイトルを非表示にするオプションがあり、**Normalize style** が有効な場合は本文テキストと見出しのフォントサイズも調整可能です。  

印刷ノートの外観をさらにカスタマイズするには、`.obsidian/snippets` に `print.css` スニペットを作成し、Obsidianが検出したらプラグイン設定から有効化できます。印刷されたドキュメントの本文には `obsidian-print` クラスが含まれます。CSSは必ず `@media print` で囲むか、印刷専用CSSを `.obsidian-print` でプレフィックスして印刷時のみ適用されるようにしてください。**Inherit note `cssclasses`** を有効にすると、ノートレベルのObsidianクラスも印刷出力に反映されます。コードブロックやMathJaxのテーマスタイルも必要に応じて印刷ドキュメントに引き継がれますが、**Normalize style** を有効にするとプラグインの中立的なフォールバックスタイルが使われます。デフォルトのスタイルは [このファイル](/styles.css) で確認できます。各ノートには `obsidian-print-note` クラスが含まれます。  

スタイルに問題がある場合は、デバッグモードを有効にして生成された印刷ドキュメントの検査ウィンドウを開いてください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---