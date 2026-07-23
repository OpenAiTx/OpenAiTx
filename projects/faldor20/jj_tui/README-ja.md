# 呪術TUI
[![nix](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml/badge.svg)](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml)

呪術バージョン管理システムのためのTUI
ここでの焦点は以下の通りです:
- **パフォーマンス**: jj_tuiは高速に起動し、決して遅くならないこと、コミットやファイルの閲覧が非常に迅速に感じられること
- **直感的**: キーバインディングは簡単に覚えられ、不要なポップアップなしで筋肉記憶に素早く定着すること
- **インタラクティブ**: jj_tuiはjjのレンダラーを完全に再実装しているため、リベースの見た目を考えながらグラフのリアルタイムプレビューを表示可能（`r`ebase `p`reviewで試せます！）

![jj_tui-ezgif com-optimize](https://github.com/faldor20/jj_tui/assets/26968035/fb053320-484a-4d6f-9b66-e5b9d0d49e5d)


`?`を押すとヘルプが表示されます。（コマンドはグラフビューとファイルビューで異なります）
`矢印キー`または`hjkl`でウィンドウやアイテムをナビゲート
`Space`でリビジョンを選択/選択解除（グラフビューでの複数選択）
`Enter`で差分を広げてスクロール可能

## 主な機能

### 通常のjj操作
- `c`ommit（コミット）
- `r`ebase（リベース）
- `g`itのプッシュとプル
- `b`ookmarksの追加、移動、削除
- `s`quash（まとめ）と`s`plit（分割）コミット
- `space`で複数コミットの選択（コピー、リベースなど）、上に`n`ew commitを開始などに使用可能

### ファイルビューからのコミット作成:
- `space`でファイルを選択し、別々に`c`ommitしたり、別のコミットに`m`ove可能
- ファイルは`N`extまたは`P`reviousコミットに送ることが可能

### revsetによるフィルタリング
- 好きなrevsetで`f`ilter可能

グラフコマンド一覧:

![jj_tui commands](https://github.com/user-attachments/assets/1e446a3d-1736-4207-b311-29d8e4bdc333)

## インストール
`linux`: 最新リリースを入手してください。静的リンクされており、どのLinuxマシンでも動作するはずです。
`mac`: 事前ビルドを取得してください。Macでのテストができないため、問題があれば教えてください。

nixでjj_tuiのシェルを開くには: `nix shell github:faldor20/jj_tui`

## 依存関係
jujutsu CLI（最低バージョン0.30.0）
WindowsやMacではテストしていません。
Unix以外では動作しないと思われるため、Windowsユーザーは現在wslを使用する必要があります。


# 設定ファイル:
キー入力をカスタマイズするために、以下のディレクトリに`config.yaml`設定ファイルを作成できます
`linux`: $XDG_CONFIG_HOME/jj_tui/
`macos`: ~/Library/preferences/jj_tui/
キー マップの仕様については`./jj_tui/lib/key_map.ml`、設定については`./jj_tui/lib/config.ml`を参照してください
キーマップ設定では、すべてのコマンドとそのサブメニューを完全にカスタマイズできるほか、矢印キーのリマップも可能です。

例:
``` yaml
key_map:
  remap:
   h: "left"
   j: "down"
   k: "up"
   l: "right"
  graph:
    #Simple mapping from key to command_id
    p: prev
    #Command sub menu
    s:
      title: "Squash"
      sub:
        # sub menu command
        s: "squash_into_parent"
# If the terminal is smaller than this width, the UI will change to a single pane view
single_pane_width_threshold: 110
# Sets the limit to how many commits are ever rendered in jj_tui. Usefull for not slowing down too much when viewing 'all()' revest.
max_commits: 100
```
コマンドIDの完全なリストについては[`jj_tui/bin/graph_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/graph_commands.ml)および[`jj_tui/bin/file_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/file_commands.ml)を参照してください。

# ログ:
`linux`: $XDG_STATE_HOME/jj_tui/
`macos`: ~/Library/logs/jj_tui/

# 開発
nixで`nix build`を使ってビルド可能、または`nix develop`でnixシェルを開けます
注意: nix開発シェルを使用し、duneでビルドしたい場合は`dune build --pkg disabled`を使い、nixが提供する依存関係でビルドしてください
直接Duneパッケージ管理で`dune build`を使ってビルドすることも可能です。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---