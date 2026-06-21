# gnome-shell-extension-ideapad
Lenovo IdeaPad向けのGNOME Shell拡張機能

*現時点では、この拡張機能はLenovo IdeaPadノートパソコンで利用可能なバッテリー節約モードを簡単かつユーザーフレンドリーに切り替え、その現在の状態を視覚的に表示する機能のみを提供しています。*

# インストール
拡張機能は[公式のGNOME拡張機能ウェブサイト](https://extensions.gnome.org/extension/2992/ideapad/)からインストールするのが簡単で推奨されます。もしくは、リポジトリを手動でダウンロードまたはクローンして、`~/.local/share/gnome-shell/extensions/ideapad@laurento.frittella`に配置してください。

どちらの場合も、いくつかの追加手順が必要です。詳細は以下の専用セクションをご確認ください。

コードを確認したい場合は、`master`ブランチが最新の安定版GNOME Shellを対象としていることにご注意ください。以前のバージョンは専用のブランチ（例：`pre-43`）で引き続きサポートされています。

# 使い方
拡張機能はパネルに「節約モード切替」*Toggle Conservation Mode*の新しいエントリを追加し、バッテリー節約モードが有効な場合にステータスメニューにアイコンを表示します。

お使いのノートパソコンのモデルが対応している場合、節約モードはバッテリー充電を容量の55～60%に制限し、バッテリー寿命を延ばします。特にノートパソコンを外部電源で使用することが多い場合に有効です。

| GNOME Shell < 43    | GNOME Shell >= 43      |
|---------------------|------------------------|
| ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot.png) | ![](https://raw.githubusercontent.com/laurento/gnome-shell-extension-ideapad/master/screenshot-43.png) |

# 追加の必要設定
デスクトップユーザーは通常root所有の特定のsysfsファイルに対し読み書きアクセス権が必要です。最も簡単な方法は`sudo`を使うことです。以下の手順はDebianでテストされていますが、ほとんどの最新GNU/Linuxシステムで動作するはずです。不明な場合は、ご利用のディストリビューションのドキュメントを参照してください。

* ディストリビューションによっては、ここで`sudo`グループ（例：DebianやUbuntu）または`wheel`グループ（例：ArchやFedora）を使用する必要があります。不明な場合は端末で`groups`コマンドを実行し、どちらのグループが表示されるか確認してください。

  以下のエントリをシステムのsudoers設定ファイル（例：`/etc/sudoers.d/ideapad`）に追加してください。**必要に応じて**`%sudo`を`%wheel`に置き換えることを忘れないでください。
  ~~~
  %sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode
  ~~~

* `ideapad_laptop`カーネルモジュールが起動時に自動的に読み込まれるよう、単に`/etc/modules`ファイルに追加してください。

まとめとして、参照用に…
~~~
# 必要に応じて %sudo を %wheel に置き換えるのを忘れずに！
#
$ echo "%sudo ALL=(ALL) NOPASSWD: /usr/bin/tee /sys/bus/platform/drivers/ideapad_acpi/VPC????\:??/conservation_mode" | sudo tee /etc/sudoers.d/ideapad
$ echo "ideapad_laptop" | sudo tee -a /etc/modules
~~~

# 間違ったバッテリー推定が表示される
使用しているカーネルのバージョンによっては、軽微な見た目の問題がまだ存在するかもしれません。ただし、GNOMEで「推定中...」のバッテリー状態が常に表示されて気になる場合は、解決策もあります。

実際、この問題はカーネル5.19以降で修正されているはずです。古いカーネルを使用している場合は、[こちらのパッチ](https://git.kernel.org/pub/scm/linux/kernel/git/torvalds/linux.git/commit/?id=185d20694a8aceb4eda9fc1314cbaad0df0aab07)を適用してみてください。指摘してくれたMartino Fontanaに感謝します。

あるいは、私が最初に提案したパッチを[このuPowerのマージリクエスト](https://gitlab.freedesktop.org/upower/upower/-/merge_requests/46)で使うこともできます。ただし、個人的にはカーネルパッチを推奨します。よりクリーンな解決策です。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---