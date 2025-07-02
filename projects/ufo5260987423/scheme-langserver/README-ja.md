<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

私の[論文](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)をお読みいただき、以下のように引用してください
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

GitHubが中国のIPアドレスをブロックする可能性があるため、このリポジトリを[こちら](https://codeberg.org/ufo5260987423/scheme-langserver)および[こちら](https://gitee.com/ufo5260987423/scheme-langserver)にもコピーしています。全てのリポジトリを継続的に更新しますが、保証はできません。また、現在は[XmacsLabs](https://github.com/XmacsLabs)とも協力しており、[こちら](https://github.com/XmacsLabs/scheme-langserver)にもフォークがあります。

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**現在、VSCode で scheme-langserver が利用可能です！** 詳細は[こちら](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)をご参照ください。

>注意: scheme-langserver には多くのバグがあります。私は修正中であり、コミュニティからの協力も求めています。どうかご辛抱ください。

>注意: 自動生成された型情報は[こちら](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result)からご覧いただけます。これは現在、次の開発段階（AKKUを含むかもしれません）やデバッグに主に使用されています。

オートコンプリート、定義へのジャンプ、ホバー時のドキュメント表示などのサポートを実装するのは、プログラミングにおいて大きな労力が必要です。しかし、Java、Python、JavaScript、Cなど他の言語と比較すると、Lisp系言語の Language Server Protocol 実装は真空状態で作られていると言えます。[Geiser](https://gitlab.com/emacs-geiser)、[racket langserver](https://github.com/jeapostrophe/racket-langserver)、[swish-lint](https://github.com/becls/swish-lint) などのツールは、すべて `repl`（Read-Eval-Print Loop）やキーワードトークナイザーに依存しており、本格的なプログラミングには基づいていません。例えば、プログラマーが未完成のプロジェクトでコードを書いている場合、コードが完全に実行可能でない限り、[Geiser](https://gitlab.com/emacs-geiser) や他のツールは `environment-symbols` プロシージャ（[Chez](https://cisco.github.io/ChezScheme/) 用）でリストされるトップレベルのバインディング識別子のみを補完したり、識別子ではなくシンボルを補完するだけです。つまり、ローカルバインディングや未完成コードの場合、プログラミングに最も重要な支援が求められる場面であっても、[Geiser](https://gitlab.com/emacs-geiser) やその類似ツールは識別子の有効なスコープの認識には全く役立ちません。同様の問題は、定義へのジャンプやその他多くの機能でも発生します。

主な原因として、Scheme やその他の Lisp 方言では豊富なデータセットや柔軟な制御構造により、プログラム解析が非常に困難になることが挙げられます。特にマクロに関しては、Schemeは天才やメタ・マクロプログラミングのためだけに使われているようにも見えます。しかし私はそうは思いません。より良いプログラミング環境があれば、Scheme でも多くの面白いことができます。そして今、[**ここから始めることができます**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)。

このパッケージは、Scheme プログラミングを支援する Language Server Protocol の実装です。補完、定義ジャンプ、型推論を提供します。これらの機能は[r6rs標準](http://www.r6rs.org/)および未完成コード向けの明確なルールに基づいた静的コード解析によって実現されています。このパッケージ自身および関連ライブラリは、Scheme のパッケージマネージャである [Akku](https://akkuscm.org/) にて公開・公開予定です。

このパッケージは [Chez Scheme](https://cisco.github.io/ChezScheme/) バージョン9.4および9.5でテスト済みです。バージョン10.0.0に関する詳細なテストは、私のノートパソコンのOSを新しいバージョンにアップグレードした後に実施する予定です。

私はこのオープンソース活動を余暇で行っており、scheme-langserver へのデータフロー解析の組み込みなど、コミュニティに多くの素晴らしいアイデアを貢献できます。また、さらなる寄付や資金援助を継続的にお願いしています。[この patreon ページ](https://www.patreon.com/PoorProgrammer/membership) または [爱发电](https://afdian.com/a/ufo5260987423) から寄付できます。


## コンパイル、インストール＆設定方法は[こちら](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## 最近の状況
バグ修正、コードのプロファイリング、自作型推論システムに関する大著のための情報収集を継続します。これには約1年かかる予定です。今後の開発には [VScode](https://code.visualstudio.com/) プラグインやデータフロー解析なども含まれます。しかし実際には、このオープンソース活動は現在パートタイムの仕事となっており、スケジュールは保証できません。

## リリース
1.2.9 現在、型推論をお楽しみください！

過去のリリースについては[このファイル](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md)をご参照ください。

### 機能
1. トップレベルおよびローカル識別子のバインディング補完。
![トップレベルおよびローカル識別子のバインディング](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. 定義へのジャンプ。
![telescope.nvimによる定義へのジャンプ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. パッケージマネージャAkkuとの互換性。
4. ファイル変更の同期および対応するインデックスの変更。
5. ホバー表示。
6. 参照とドキュメントハイライト（ドキュメントスコープの参照）。
![telescope.nvimで参照を検索](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. ドキュメントシンボル。
![telescope.nvimでドキュメントシンボルを検索](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. *-syntax（define-syntax, let-syntaxなど）に基づくローカル識別子バインディングのキャッチ。
9. クロスプラットフォームな並列インデックス作成。
10. .spsファイルとの互換性のための自作ソースコードアノテータ。
11. サスペンド可能タスクによるAPIリクエストのピープホール最適化。
12. 自作DSLインタープリタによる型推論（これには非常に自信があります！）。現在はオートコンプリートにも組み込まれています。下図のように、「length-b」と「length-a」が「integer?」型を持ち、"<="が要求するパラメータ型と一致するため、推薦候補の先頭に表示されています。
![型推論付きオートコンプリート](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
この結果はテストでも証明できます。`scheme --script tests/protocol/apis/test-completion.sps` を実行し、ログファイル `scheme-langserver.log` に以下のような結果が含まれます:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. scm、ss、sps、sls、sldなど異なるファイル拡張子間での識別子キャッチ用の抽象インタープリタ。

### TODO
14. リネーム対応。
15. [r6rs標準](http://www.r6rs.org/)への完全対応。
16. ステップバイステップのマクロ展開器：実は既に実装済みですが、自己定義マクロでの識別子バインディング検出の重要な段階にしたいと考えています。ただし、この検出は思った以上に難しく、展開器がどこまで機能するかわかりません。
17. コードの評価。
18. コード診断。
19. クロス言語セマンティックサポートの追加。さて、ASTトランスフォーマを用いれば、Java、C、Python、その他多くの言語をサポートできるだろうか？
20. 式/文を手続きに抽出する。

## TODO:貢献

## デバッグ

### デバッグ方法
https://www.scheme.com/debug/debug.html#g1

### 出力ログ
[ビルド](#building)、[Lunar Vim用インストール](#installation-for-lunarvim)、[VScode用インストール](#todo-installation-for-vscode)の手順を参考に、開発中に何かをログしたい場合は、`path-to-log-file` を追加し、ファイル `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` を以下のように書き換えると便利です。
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
`scheme-langserver` は Scheme 用の言語サーバプロトコル実装です
]]   ,
  },
}
```
### ログを用いた再現 
上記の[出力ログ](#output-log)を使い、`tests/log-debug.sps` でバグを再現できます：
1. `{path-to-log}`（通常は `~/scheme-langserver.log`）を `~/ready-for-analyse.log` にリネームします。
2. `scheme --script tests/log-debug.sps` を実行します。マルチスレッド環境を再現したい場合も、`scheme --script tests/log-debug.sps` を実行すれば利用可能です。

## テスト
ほぼすべての主要な手続きとAPIがテストされています。私の作業はとても粗いですが有用です。`tests` ディレクトリで実施内容を確認するか、`{scheme-langserver-root-directory}` で以下のコマンドを実行してください。
``` bash
bash test.sh
```
>注意  
スレッド環境でのテストは困難です。そのため、現状のテストはシングルスレッドに焦点を当てています。

## Scheme-langserverを他の用途で使う
### GIMPのScript-Fu
Script-FuはSchemeというインタプリタ型言語に基づいており、GIMPの内部関数とやり取りする関数を使って動作します。[このページ](https://dalelane.co.uk/blog/?p=628)のスクリプトを例に、拡張子 "SCM" のスクリプトファイルにscheme-langserverを適用できます。

### その他

OMN (Opusmodus Notation)[https://opusmodus.com/] やAutoLispにも興味があります。しかし、まだやることがたくさんあります。

## コード行数カウント
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## 詳細ドキュメント
1. [Scheme-langserver: Schemeコード編集を第一級の関心事として扱う](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)
2. [識別子バインディングの捕捉](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [同期化](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [型推論](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)、~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~（非推奨、現在中国語の書籍を執筆中）
5. [API分析](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## コントリビューター

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---