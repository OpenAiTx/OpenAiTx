# i3-quickterm

[![Packaging status](https://repology.org/badge/vertical-allrepos/python:i3-quickterm.svg)](https://repology.org/project/python:i3-quickterm/versions)

[i3wm](https://i3wm.org/) と [sway](https://swaywm.org/) 向けの小さなドロップダウン端末

## 特徴

* お気に入りの端末エミュレーターを使用可能
* [dmenu](http://tools.suckless.org/dmenu/) / [rofi](https://github.com/DaveDavenport/rofi) でシェルを選択可能
* 画面幅に適応
* マルチモニター対応

## インストール

pip経由で:

```
pip install i3-quickterm
```

または、上記のrepologyバッジを確認して、あなたのディストリビューションでパッケージ化されているか確認してください。

## 使用法

起動時に、現在の画面にquicktermがあればそれを最小化します。そうでない場合は、ユーザーに開くシェルを選択させるか、引数で指定されたシェルを使用します。

要求されたシェルが別の画面ですでに開かれている場合は、現在の画面に移動されます。

i3のバインディングにマッピングすることを推奨します：

```
# with prompt
bindsym $mod+p exec i3-quickterm
# always bring up standard shell, without the menu
bindsym $mod+b exec i3-quickterm shell
```
## 設定

設定は `~/.config/i3-quickterm/config.json` または `~/.config/i3/i3-quickterm.json` から読み込まれます。

* `menu`: シェルを選択するために使用される dmenu 互換のアプリケーション
* `term`: 使用するターミナルエミュレーター
* `history`: 最後に使用したシェルの順序を保存するファイル。null に設定すると最後に使用した順序の保存は無効になります
* `width`: 画面幅に対する使用率（パーセンテージ）
* `height`: 画面高さに対する使用率（パーセンテージ）
* `pos`: ターミナルを表示する位置（`top` または `bottom`）
* `shells`: 登録されたシェル（`{ name: command }`）

`term` は以下のいずれかです：
- [対応しているリスト](#supported-terminals) の中からのターミナル名
- `auto` で、上記リストの中で最初に存在するターミナルを選択（友好的なデフォルトを提供するためのみ推奨、それ以外は推奨しません）
- フォーマット文字列、例えば：`urxvt -t {title} -e {expanded}` のように、ターミナルの正しい引数形式で指定します。xfce4-terminal のようにコマンド引数を文字列として渡す必要がある場合は、`{expanded}` を `{string}` に置き換えます

`menu`、`term`、`history`、`shell` には環境変数のプレースホルダ `{$var}` を含めることができます。

未指定のキーはデフォルト値から継承されます：


```
{
    "menu": "rofi -dmenu -p 'quickterm: ' -no-custom -auto-select",
    "term": "auto",
    "history": "{$HOME}/.cache/i3-quickterm/shells.order",
    "width": 1.0,
    "height": 0.25,
    "pos": "top",
    "shells": {
        "js": "node",
        "python": "ipython3 --no-banner",
        "shell": "{$SHELL}"
    }
}
```
## 対応ターミナル

* alacritty
* foot
* gnome-terminal
* kitty
* roxterm
* st
* terminator
* termite
* urxvt
* urxvtc
* xfce4-terminal
* xterm

もし他のターミナルを追加したい場合（または誤りを修正したい場合）は、プルリクエストを開いてください。

## 要件

* python >= 3.8
* i3 >= v3.11 または sway >= 1.2
* [i3ipc-python](https://i3ipc-python.readthedocs.io/en/latest/) >= v2.0.1
* dmenu または rofi（任意）



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---