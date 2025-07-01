![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

私の[論文](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)を読むことができ、以下のように引用できます。
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

GitHubが中国のIPアドレスをブロックする可能性があるため、このリポジトリを[こちら](https://codeberg.org/ufo5260987423/scheme-langserver)および[こちら](https://gitee.com/ufo5260987423/scheme-langserver)にコピーしました。すべてのリポジトリを継続的に更新しますが、保証はできません。また、[XmacsLabs](https://github.com/XmacsLabs)とも協力しており、[こちら](https://github.com/XmacsLabs/scheme-langserver)にもフォークがあります。

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**現在、VSCodeでscheme-langserverが利用可能です！** 詳細は[こちら](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)を参照してください。

>注意: scheme-langserverには多くのバグがあります。現在修正中で、コミュニティからの協力も求めています。ご理解ください。

>注意: 自動生成された型情報は[こちら](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)から確認できます。これは主に次の開発ステージ（おそらくAKKUを含む）やデバッグに使われています。

オートコンプリート、定義へ移動、ホバー時のドキュメント表示などのサポートを実装するのは、プログラミングにおいて大きな労力です。しかし、Java、Python、JavaScript、Cなど他の言語と比較すると、Lisp系言語のLanguage Server Protocol実装は真空状態で作られています。[Geiser](https://gitlab.com/emacs-geiser)、[racket langserver](https://github.com/jeapostrophe/racket-langserver)、[swish-lint](https://github.com/becls/swish-lint)などは、`repl`(Read-Eval-Print Loop)やキーワードトークナイザーに依存しており、プログラミング的な実装ではありません。例えば、プログラマーが未完成のプロジェクトでコードを書いている場合、そのコードが完全に実行可能でなくても、[Geiser](https://gitlab.com/emacs-geiser)等は`environment-symbols`手続き（[Chez](https://cisco.github.io/ChezScheme/)の場合）でリストされたトップレベルのバインディング識別子のみを補完したり、識別子でなくシンボルの補完しかできません。つまり、ローカルバインディングや未完成のコードについて、プログラミング上最も重要とされる支援は[Geiser](https://gitlab.com/emacs-geiser)や類似ツールでは識別子の有効スコープ認識の支援ができません。定義へのジャンプやその他多くの機能でも同様の問題が発生します。

主な原因は、Schemeや他のLisp方言では多様なデータセットや柔軟な制御構造があり、プログラム解析の大きな課題となっていることです。特にマクロについては、Schemeは天才やメタ／マクロプログラミング向けの言語だと思われがちですが、私はそうは思いません。より良いプログラミング環境があればSchemeで多くの面白いことができます。そして、今すぐ[**こちらから始められます**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

このパッケージはSchemeプログラミングを支援するLanguage Server Protocol実装です。補完、定義、型推論を提供します。これらの機能は[r6rs標準](http://www.r6rs.org/)および未完成コード向けの明確なルールに基づいた静的コード解析で実現されています。このパッケージおよび関連ライブラリは[Akku](https://akkuscm.org/)（Scheme用パッケージマネージャ）で公開または公開予定です。

このパッケージは[Chez Scheme](https://cisco.github.io/ChezScheme/)バージョン9.4および9.5でテストされています。バージョン10.0.0については、私のノートPCのOSを新しいバージョンにアップグレードした後に詳細なテストを行います。

このオープンソース活動は私の余暇時間で行っており、データフロー解析の組み込みなど多くの素晴らしいアイデアをコミュニティに貢献できます。また、より多くの寄付や支援を継続してお願いしています。[Patreonページ](https://www.patreon.com/PoorProgrammer/membership)や[愛発電](https://afdian.com/a/ufo5260987423)からご支援いただけます。


## コンパイル・インストール・設定は[こちら](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## 最近の状況
バグ修正、コードプロファイリング、自作型推論システムに関する巨大な書籍のための情報収集を続けています。これには約1年かかる予定です。今後の開発計画には[VScode](https://code.visualstudio.com/)プラグインやデータフロー解析も含まれます。しかし、現在はこのオープンソース活動をパートタイムとしており、スケジュールの保証はできません。

## リリース
1.2.9 現在、型推論をお楽しみください！

過去のリリースについては[こちらのファイル](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)を参照してください。

### 機能一覧
1. トップレベルおよびローカル識別子バインディングの補完。
![トップレベルおよびローカル識別子バインディング](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 定義へのジャンプ。
![telescope.nvimによる定義へのジャンプ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. パッケージマネージャAkkuとの互換性。
4. ファイル変更の同期と対応するインデックスの変更。
5. ホバー。
6. 参照とドキュメントハイライト（ドキュメントスコープの参照）。
![telescope.nvimによる参照検索](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. ドキュメントシンボル。
![telescope.nvimによるドキュメントシンボル検索](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. *-syntax(define-syntax, let-syntax等)ベースのローカル識別子バインディングの捕捉。
9. クロスプラットフォーム並列インデックス化。
10. .spsファイル互換の自作ソースコードアノテーター。
11. サスペンド可能タスクによるAPIリクエストのピープホール最適化。
12. 自作DSLインタプリタによる型推論（これは非常に誇りに思っています！）。現在、オートコンプリートにも組み込まれています。下図のように、「length-b」と「length-a」が「integer?」型であり、「<=」が要求するパラメータ型と一致するため、推奨オプションの先頭に表示されています。
![型推論付きオートコンプリート](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
この結果を証明するテストは、`scheme --script tests/protocol/apis/test-completion.sps`を実行し、ログファイル`scheme-langserver.log`に次のような結果が含まれていることを確認してください。
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. scm、ss、sps、sls、sldなど異なるファイル拡張子間での識別子捕捉のための抽象インタプリタ。

### 今後の課題
14. リネーム機能。
15. [r6rs標準](http://www.r6rs.org/)への完全対応。
16. ステップバイステップマクロ展開器：実は一つ実装しましたが、自作マクロ内の識別子バインディング捕捉の要となるステップにしたかったのですが、想像以上に難しく、どこで使えば良いのかも分からなくなりました。
17. コード実行。
18. コード診断。
19. クロス言語セマンティックサポートの追加。Java、C、Pythonなど多くの言語もASTトランスフォーマでサポートできるでしょうか？
20. 式／文を手続きに抽出。

## TODO: コントリビューション 

## デバッグ

### デバッグ方法
https://www.scheme.com/debug/debug.html#g1

### 出力ログ
[ビルド](#building)、[Lunar Vim用インストール](#installation-for-lunarvim)、[VScode用インストール](#todo-installation-for-vscode)の各説明に従い、開発やログ取得をしたい場合は、`path-to-log-file`を追加し、ファイル`~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua`を以下のように書き換えると便利です。
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
}
```
### ログを使った再現
上記の[出力ログ](#output-log)を使用して、`tests/log-debug.sps`でバグを再現できます。
1. `{path-to-log}`（通常は `~/scheme-langserver.log`）を `~/ready-for-analyse.log` にリネームします。
2. `scheme --script tests/log-debug.sps` を実行します。マルチスレッド環境を再現したい場合も、`scheme --script tests/log-debug.sps` を実行することで可能です。

## テスト
ほとんど全ての主要な手続きとAPIはテストされています。私の作業は粗いですが役立つものです。`tests`ディレクトリで私が行ったことを見つけるか、もしくは `{scheme-langserver-root-directory}` で以下のコマンドを実行してみてください。
``` bash
bash test.sh
```
>注意  
スレッド環境でのテストは難しいです。そのため、現在のテストはシングルスレッドに焦点を当てています。

## 他の用途でのScheme-langserverの利用
### GIMPでのScript-Fu
Script-FuはSchemeというインタプリタ言語に基づいており、GIMPの内部関数とやり取りする関数を使って動作します。[このページ](https://dalelane.co.uk/blog/?p=628)のスクリプトを例に取ると、拡張子「SCM」のスクリプトファイルに対してscheme-langserverを適用できます。

### その他

私は[OMN (Opusmodus Notation)](https://opusmodus.com/)やAutoLispにも興味があります。しかし、まだやるべきことがたくさんあります。

## コード行数のカウント
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 詳細ドキュメント
1. [Scheme-langserver: Schemeコード編集を第一級の関心事として扱う](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)
2. [識別子バインディングの捕捉](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [同期処理](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [型推論](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)、~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~（非推奨、現在中国語の書籍を執筆中）
5. [API解析](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## コントリビューター

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---