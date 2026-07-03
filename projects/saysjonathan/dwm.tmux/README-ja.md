dwm.tmux
===
[Tmux](http://dwm.suckless.org/)に触発されたタイル型ペインおよびウィンドウマネージャー。

![](https://raw.githubusercontent.com/saysjonathan/dwm.tmux/master/screenshot.png)

## 依存関係
dwm.tmux は tmux >= 3.2 を必要とします。

## インストール
### TPM経由（推奨）
`~/.tmux.conf`に追加してください：

```sh
set -g @plugin 'saysjonathan/dwm.tmux'
```

`prefix-I` をリロードして実行し、取得します。

### 手動インストール（レガシー）
インストールするには、提供された `Makefile` を使用します：

```sh
git clone https://github.com/saysjonathan/dwm.tmux.git
cd dwm.tmux
make
```
デフォルトで `dwm.tmux` は `/usr/local` をプレフィックスとして使用します。プレフィックスを変更するには：


```sh
make PREFIX=$HOME
```

`$PREFIX/bin` が `PATH` に含まれていることを確認してください。

使用するには、`dwm.tmux` tmux 設定をソースしてください：

```sh
echo 'source-file /usr/local/lib/dwm.tmux' >> $HOME/.tmux.conf
```
## 使用方法
`dwm.tmux` は、以下のコマンドエイリアスを定義しており、それぞれにデフォルトのキーバインディングが設定されています:

- `newpane` `Meta-n` 新しいペインを作成し、メインペインに配置する
- `newpanecurdir` `Meta-w` 同じディレクトリで新しいペインを作成し、メインペインに配置する
- `killpane` `Meta-c` 現在のペインを閉じる。メインペインの場合は、ペインを閉じてスタックの最初のペインをメインペインに昇格させる
- `movepane[0-9]` `Meta-Shift-[0-9]` 現在のペインを指定したウィンドウに移動する
- `nextpane` `Meta-j` 次のペイン（時計回り）を選択する；モノクルモードでフルスクリーンのペインを入れ替える
- `prevpane` `Meta-k` 前のペイン（反時計回り）を選択する；モノクルモードでフルスクリーンのペインを入れ替える
- `stackup` `Meta-J` フォーカスされたペインをスタック内で上に移動する
- `stackdown` `Meta-K` フォーカスされたペインをスタック内で下に移動する
- `rotateccw` `Meta-<` ペインを反時計回りに回転する
- `rotatecw` `Meta->` ペインを時計回りに回転する
- `tile` `Meta-t` タイルレイアウトに戻り、アクティブならモノクルモードを終了する
- `monocle` `Meta-Space` モノクルモード（現在のペインをフルスクリーン）を切り替える
- `zoom` `Meta-Enter` 選択したペインをメインペインに配置する
- `decmfact` `Meta-h` メインペインのスペースファクターを減少させる
- `incmfact` `Meta-l` メインペインのスペースファクターを増加させる
- `window[0-9]` `Meta-[0-9]` IDでターゲットウィンドウを選択する
- `newwindow` `Meta-N` 現在のペインと同じディレクトリで新しいウィンドウを作成する
- `killwindow` `Meta-X` 現在のアクティブウィンドウを削除する
- `popup` `Meta-p` 現在のペインのディレクトリでフローティングペインのポップアップを表示する
- `incpfact` `Meta-.` フォーカスされたペインのスタック内のサイズを他のペインに対して増加させる
- `decpfact` `Meta-,` フォーカスされたペインのスタック内のサイズを他のペインに対して減少させる
- `resetpfact` `Meta-=` フォーカスされたペインのpfactをリセットする

ウィンドウの切り替えに関する追加のキーバインディングも含まれています:
- `Meta-[` 前のウィンドウ
- `Meta-]` 次のウィンドウ

また、動作を調整するグローバルオプションも定義されています:

- `mfact` メインペインのスペースファクター。メインペインのサイズをウィンドウ全体のパーセンテージで表す
- `killlast` 値が `0` より大きい場合、ウィンドウ内で最後のペインであってもペインを殺す
- `monocle` アクティブなレイアウトモードを追跡。0がタイル、1がモノクル。自動設定されるが、現在の状態を調べるために読むことができる
- `pfact` ペインごとのスタックサイズファクター。スケールは1～9、デフォルトは5。値が大きいほどスタック内で相対的に高さが大きくなる

### カスタマイズ
キーバインディングやデフォルト値は設定ファイルで設定できます。TPMを使用する場合、これらは `~/.tmux.conf` の `run '~/.tmux/plugins/tpm/tpm'` 行の後に設定する必要があります。


例：

```
setenv -g killlast 1 # kill pane even if it's the last
set-option -wg @mfact 60
set-option -wg @pfact 4
bind -n M-q killpane
bind -n M-w newpanecurdir
```

## 詳細

dwmと同様に、ウィンドウは常に次のように整理されます：

```
 ====================================
|                 |        S1        |
|                 |==================
|      M(0)       |        S2        |
|                 |==================
|                 |        S3        |
 ====================================
```
画面の左側に大きなメインペインが配置され、右側には複数の小さなペインのスタックが配置されます。メインペインは常にペイン0であり、ペインのスタックは昇順で連続して番号付けされます。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---