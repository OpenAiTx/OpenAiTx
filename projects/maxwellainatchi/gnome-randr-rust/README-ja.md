# gnome-randr-rust

Wayland上のGnome向けに `xrandr` を再実装したもので、特に `wlr-output-management-unstable-v1` をサポートしないシステム（例：Manjaro）向けです。パフォーマンスと楽しさを追求してRustで一から書き直しました。これが私の初めてのRustプロジェクトなので、どんな提案でも歓迎します！

> [!NOTE]  
> 現在、動作するLinuxマシンを持っていないためメンテナンスができません。もしメンテナンスに興味がある方がいれば、ご連絡ください！
>
> Gnome 48以降では、付属の [gdctl](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/doc/man/gdctl.rst) CLIを試してみてください。こちらが今後も最新に保たれる可能性が高いです。

（非Gnomeコンポジタの場合は https://arewewaylandyet.com/ のディスプレイ設定リンクを参照してください）

## インストール

インストールにはRustツールチェーンの一部である `pkg-config` と `cargo` が必要です。[Cargo/Rustのインストール手順](https://doc.rust-lang.org/cargo/getting-started/installation.html)。

このツールをインストールするには、`cargo install gnome-randr` を実行してください。他のRustプログラムで使用できるライブラリも提供しています。

## 方法

`gnome-randr-rust` は `dbus` オブジェクト `org.gnome.Mutter.DisplayConfig` を使用しています。元の提案は https://wiki.gnome.org/Initiatives/Wayland/Gaps/DisplayConfig を参照してください。ただし、そこに記載された仕様はやや古くなっています（Gnome shell 40.5で `dbus introspect` を実行して確認）。Gnomeは進化するXMLファイルを [こちら](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/data/dbus-interfaces/org.gnome.Mutter.DisplayConfig.xml) で管理しています。

`GetCurrentState` メソッドはディスプレイ情報の一覧取得に使われ、`ApplyMonitorsConfig` は現在の設定を変更するのに使われます。

## インスピレーション

このプロジェクトは `xrandr`（当然ですが）と [`gnome-randr`](https://gitlab.com/Oschowa/gnome-randr/) に大いに触発されました。残念ながら、私のGnomeバージョン（40.5）では `gnome-randr.py` はディスプレイ設定を変更しようとすると壊れているようです。

`gnome-randr.py` は私のRustによる再実装よりも遅く、3モニター環境でPythonスクリプトのクエリは約30msかかるのに対し、Rust実装は約3msです（`xrandr` は約1.5msですが、`xrandr` のブリッジの制限により表示情報が異なります）。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-30

---