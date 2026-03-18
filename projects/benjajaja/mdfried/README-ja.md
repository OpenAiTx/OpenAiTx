# mdfried

`mdfried` は、ヘッダーを他のテキストよりも**大きな文字**で表示するターミナル用のMarkdownビューアです。

## スクリーンショット

![Screenshot](https://raw.githubusercontent.com/benjajaja/mdfried/master/./assets/screenshot_1.png)

[`master` からの最新テストスクリーンショット配列](https://benjajaja.github.io/mdfried-screenshots/)

## ビデオ

https://github.com/user-attachments/assets/e69154a7-bea8-4e14-a677-be7ccf0d3cac

# なぜ？

ターミナルを*[調理](https://ratatui.rs/)*できますが、ターミナルを**ディープフライ**できますか？
*はい！* あなたの `tty` を**調理 *かつ* 揚げる**ことができます！ ~~手遅れになる前に走れ！~~

> ターミナルは通常「調理済み」モード、つまりカノニカルモードです。
> `ratatui`🐁 では、rawモードですが、「調理」を代わりに行います。

Markdownはターミナル上でかなり綺麗にレンダリングできますが、重要な要素が欠けています：
Big Headers™ はテキストをより読みやすくし、画像をインラインで表示できるのは非常に便利です。

# どうやって？

ヘッダーを [ratatuiでの画像](https://github.com/benjajaja/ratatui-image)としてレンダリングし、
Sixels、Kitty、iTerm2などの複数のターミナルグラフィックスプロトコルのいずれかを使用します。
Kittyターミナルはさらに、画像としてレンダリングせずにテキストを直接拡大できる
[テキストサイズプロトコル](https://sw.kovidgoyal.net/kitty/text-sizing-protocol/)も実装しています！

お使いのターミナルがグラフィックスをサポートしているかどうかや詳細は
[ratatui-image](https://github.com/benjajaja/ratatui-image?tab=readme-ov-file#compatibility-matrix)をご覧ください。

一般的に、Kitty、WezTerm、iTerm2、Ghostty、Foot、`xterm -ti vt340` は*動作する*はずです。

Alacrittyのようにグラフィックスを全く持たないターミナルでは、Chafaで画像をレンダリングします。


# インストール

* Rust cargo: `cargo install mdfried`
  * ソースから : `cargo install --path .`
  * 通常は `libchafa-dev`、`libchafa-devel`、または単に `libchafa`、あるいは `chafa` と呼ばれる開発用ヘッダ付きの chafa パッケージが必要です。
  * chafa がまったく利用できない、または端末が何らかのグラフィックプロトコルをサポートしているため気にしない場合は、`--no-default-features` を使用してください。
  * `cargo install ...` が失敗した場合は、`--locked` オプションを付けて試すか、問題を報告してください。
* Nix flake: `github:benjajaja/mdfried`
* Nixpkgs: [`mdfried`](https://search.nixos.org/packages?channel=unstable&query=mdfried)
* Arch Linux: `pacman -S mdfried` ([extra リポジトリ](https://archlinux.org/packages/extra/x86_64/mdfried/))
* Ubuntu: [リリース .deb をダウンロード](https://github.com/benjajaja/mdfried/releases/latest)
* Mac: `brew install mdfried` または [リリースバイナリ](https://github.com/benjajaja/mdfried/releases/latest)
* Windows: [リリース .exe をダウンロード](https://github.com/benjajaja/mdfried/releases/latest)

# 使い方

### 実行方法

```
mdfried ./path/to.md
```

Kittyのバージョンが0.40以上でない場合、またはグラフィックスプロトコルをサポートしない端末を使用している場合、
初めて`mdfried`を実行するとフォントを選択する必要があります。
端末で使用しているのと同じフォントを選択するのが望ましいですが、任意のフォントを選ぶことも可能です。
フォント設定画面ではシステムフォントを検索でき、端末で使用している同じフォントを選択するのが良いでしょう。
フォントはプレビューとして直接レンダリングされます。
確認後、その選択は設定ファイルに書き込まれます。

フォントが正しくない場合は、`--setup`を使って再度フォント設定を強制できます。

Markdownをパイプで渡すことも可能です：


```
readable https://lobste.rs | markdownify | mdfried
```
### キーバインディング

キー | 説明
----|------------
`q` または `Ctrl-c` | 終了して端末に内容を残す
`r` | ファイルを再読み込み（パイプされた標準入力では無効）
`j` | 1行スクロールダウン
`k` | 1行スクロールアップ
`d` または `Ctrl-d` | 半ページスクロールダウン
`u` または `Ctrl-u` | 半ページスクロールアップ
`f` または `PageDown` または `Space` | 1ページスクロールダウン
`b` または `PageUp` | 1ページスクロールアップ
`g` | ファイルの先頭へ移動
`G` | ファイルの末尾へ移動
`<number>G` または `<number>g` | 番号#\<number>の文字列へ移動
`/` | テキスト検索
`n` | 次の一致またはリンクへジャンプ
`N` | 前の一致またはリンクへジャンプ
`Enter` | 選択したリンクを `xdg-open` で開く
`Esc` | 検索またはリンクモードを終了

移動の前に数字を入力すると、その回数だけ移動が適用されます。

マウススクロールは設定で `enable_mouse_capture = true` にすると動作しますが、
その場合テキストの選択はできません。

### 設定

`~/.config/mdfried/config.toml` は初回起動時に自動的に作成されます。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---