# トリマー

[![ci](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml/badge.svg?branch=master)](https://github.com/jonlabelle/Trimmer/actions/workflows/ci.yml)
[![Package Control Installs](https://img.shields.io/packagecontrol/dt/Trimmer.svg?label=installs)](https://packagecontrol.io/packages/Trimmer)
[![Latest Release](https://img.shields.io/github/tag/jonlabelle/Trimmer.svg?label=version)](https://github.com/jonlabelle/Trimmer/releases)
[![MIT License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/jonlabelle/Trimmer/blob/master/LICENSE.md)

> [Trimmer](https://github.com/jonlabelle/Trimmer) は、[Sublime Text](http://www.sublimetext.com) 用の空白をクリーンアップするプラグインです。

## 機能

- 各行の末尾の空白をトリムします。
- 各行の先頭の空白をトリムします。
- 各行の先頭と末尾の空白をトリムします。
- 選択範囲の空白をトリムします。
- 空行（空白のみの行）を削除します。
- 複数連続する空行を1行にまとめます。
- 複数連続するスペースを1つのスペースにまとめます。
- ファイルの先頭と末尾の空白のみの空行をトリムします。
- 空白文字を削除します。
- スペースを正規化します（連続スペースを縮小、空行を削除、行をトリム）。
- 連続するスペースを縮小し、前後のスペースをトリムして文字列をトークン化します。
- 空の空白のみのHTMLおよびXMLタグを削除します。
- コードコメントを削除し、行をまとめます。
- 隣接する重複行を削除します。

## 追加機能

以下の処理を行う**スマート文字の置換**コマンド：

- **スマートシングルクォート:** `’` _を_ `'`
- **スマートダブルクォート:** `“` _を_ `"`
- **プライム:** `′` _を_ `'`
- **ダブルプライム:** `″` _を_ `"`
- **ドイツ語の引用符:** `„` _を_ `"` および `‚` _を_ `'`
- **省略記号:** `…` _を_ `...`
- **エムダッシュ:** `—` _を_ `---`
- **エンダッシュ:** `–` _を_ `--`
- **箇条書き:** `•` _を_ `*`
- **中黒:** `·` _を_ `-`
- **Emスペース** _は_ スペース3つに
- **Enスペース** _は_ スペース2つに
- **改行しないスペース** _は_ スペース1つに
- **細いスペース** _は_ スペース1つに
- **髪スペース** _は_ スペース1つに
- **左かぎ括弧:** `«` _は_ `<<` に
- **右かぎ括弧:** `»` _は_ `>>` に
- **著作権記号:** `©` _は_ `(C)` に
- **商標記号:** `™` _は_ `(T)` に
- **登録商標記号:** `®` _は_ `(R)` に

![スクリーンショット](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)

[**クイックデモ**](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/demo.gif)を視聴

## インストール

TrimmerはSublime Text 2および3とすべてのサポートされているOSに対応しています。

### パッケージコントロール

Trimmerをインストールする最も簡単で推奨される方法は[パッケージコントロール](https://packagecontrol.io)を使用することです。

メインアプリケーションメニューから、次へ移動します：

- `ツール` -> `コマンドパレット...` -> `Package Control: Install Package`を選択し、
  **_Trimmer_** と入力して選択するとインストールが完了します。

### Git

Gitを使ってTrimmerをインストールするには、**Sublime Textのパッケージ**ディレクトリに移動し、
[Trimmerリポジトリ](https://github.com/jonlabelle/Trimmer)をクローンしてください。

例えば、**OS X**では... 新しい**ターミナル**セッションを開始し、以下のコマンドを入力します：


```shell
$ cd ~/Library/Application\ Support/Sublime\ Text\ 3/Packages/
$ git clone https://github.com/jonlabelle/Trimmer
```
### 手動でのインストール

**ダウンロード**して[zip](https://github.com/jonlabelle/Trimmer/zipball/master)
または[tarball](https://github.com/jonlabelle/Trimmer/tarball/master)を
Sublime Textのパッケージディレクトリに**解凍**してください。

**Sublime Textのデフォルトパッケージパス:**

- **OS X:** `~/Library/Application Support/Sublime Text [2|3]/Packages`
- **Linux:** `~/.Sublime Text [2|3]/Packages`
- **Windows:** `%APPDATA%/Sublime Text [2|3]/Packages`

> **注意** `[2|3]` 部分はインストールしているSublime Textの
> バージョンに合わせて置き換えてください。

## 使い方

すべてのコマンドは **Command Palette** でプレフィックス
**_Trimmer_** を使ってアクセスでき、また **メインメニュー** の `Edit` -> `Line` -> _Trimmer_ コマンドからも利用可能です。

- [Command Paletteのスクリーンショット](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/command_palette.png)
- [メインメニューのスクリーンショット](https://raw.githubusercontent.com/jonlabelle/Trimmer/master/screenshots/main_menu.png)

### キーバインディング

デフォルトのキーバインディングはファイル全体の各行の末尾の
トレーリングホワイトスペースをトリムします。

- **OS X**: `Ctrl + S`
- **Linux**: `Ctrl + Alt + S`
- **Windows**: `Ctrl + Alt + S`

### TrimmerコマンドAPI

| コマンド                            | 説明                                                                                                  | コンテキスト               |
| ---------------------------------- | ------------------------------------------------------------------------------------------------------ | ------------------------- |
| `trimmer`                          | 各行の末尾のホワイトスペースをトリムします                                                              | ファイル全体               |
| `trim_leading_whitespace`          | 各行の先頭のホワイトスペースをトリムします                                                              | 選択範囲またはファイル全体 |
| `trim_leading_trailing_whitespace` | 各行の先頭と末尾のホワイトスペースをトリムします                                                        | 選択範囲またはファイル全体 |

| `trim_selections`                  | 選択範囲の空白をトリムする                                                                              | 選択範囲                   |
| `delete_empty_lines`               | 空行および空白のみの行を削除する                                                                       | 選択範囲、またはファイル全体 |
| `collapse_lines`                   | 連続する複数の空行を1行の空行にまとめる                                                               | 選択範囲、またはファイル全体 |
| `collapse_spaces`                  | 連続する複数のスペースを1つのスペースにまとめる                                                       | 選択範囲、またはファイル全体 |
| `trim_edges`                       | ファイルの先頭と末尾の空行および空白のみの行をトリムする                                               | ファイル全体               |
| `remove_blank_spaces`              | すべての空白文字（タブ、CR、FF、VT、スペース）を削除する                                               | 選択範囲、またはファイル全体 |
| `normalize_spaces`                 | 連続するスペースを削減し、空行を削除し、行をトリムする                                                 | 選択範囲、またはファイル全体 |
| `replace_smart_characters`         | スマート文字（スマートクオート、エムダッシュ／エンダッシュ、三点リーダー、ノーブレークスペース）を置換する | 選択範囲、またはファイル全体 |
| `tokenize_string`                  | 文字列をトークンに変換する（連続スペースをまとめ、前後のスペースをトリム）                            | 選択範囲、またはファイル全体 |
| `delete_empty_tags`                | 空の、または空白のみのHTMLおよびXMLタグを削除する                                                     | 選択範囲、またはファイル全体 |
| `remove_comments`                  | コードコメントを削除し、行をまとめる                                                                   | 選択範囲、またはファイル全体 |
| `delete_adjacent_duplicate_lines`  | 隣接する重複行を削除する                                                                               | 選択範囲、またはファイル全体 |

## 作者

[Jon LaBelle](https://jonlabelle.com)

## ライセンス

Trimmerは[MITライセンス](http://opensource.org/licenses/MIT)のもとでライセンスされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-15

---