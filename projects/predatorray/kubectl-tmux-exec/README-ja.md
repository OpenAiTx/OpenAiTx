# kubectl-tmux-exec

![GitHub release version](https://img.shields.io/github/v/release/predatorray/kubectl-tmux-exec)
![License](https://img.shields.io/github/license/predatorray/kubectl-tmux-exec)
![Build Status](https://img.shields.io/github/actions/workflow/status/predatorray/kubectl-tmux-exec/ci.yml?branch=master)
![GitHub all releases](https://img.shields.io/github/downloads/predatorray/kubectl-tmux-exec/total)

A **kubectl** plugin for executing commands interactively across multiple pods or containers using [**tmux**](https://github.com/tmux/tmux),
like `csshX` or `pssh` but for **Kubernetes**.

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot.png?raw=true)

To execute command across all the Nginx containers using `bash` for example, run:

```sh
kubectl tmux-exec -l app=nginx /bin/bash
```
## インストール

### Homebrew

> **注意**: これはMacユーザー向けです。

1. [Homebrew](https://brew.sh/)をインストールします。

2. `brew install predatorray/brew/kubectl-tmux-exec`

最後に、`/usr/local/bin/kubectl-tmux_exec` があなたの `$PATH` に含まれていることを確認してください。

### Krew

> **注意**: Linuxユーザーに推奨されます。  
>  
> MacとLinuxの両方で動作しますが、Macユーザーには推奨されません。Homebrewを使って依存関係の `gnu-getopt` をインストールする必要があるためです。

1. [Krew](https://krew.sigs.k8s.io/) を[ユーザーガイド](https://krew.sigs.k8s.io/docs/user-guide/setup/install/)に従ってインストールします。

2. `kubectl krew install tmux-exec`

3. 依存関係をインストールします。([Wiki: 依存関係のインストール方法](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

### 手動インストール

1. [最新リリース](https://github.com/predatorray/kubectl-tmux-exec/releases/latest) をダウンロードします。

2. kubectl-tmux-exec-*.tar.gz ファイルを展開し、すべてのファイルを任意のディレクトリ（例: `/usr/local/kubectl-tmux-exec`）にコピーします。

3. `bin/` ディレクトリを `$PATH` に追加します。例えば、rcファイルに次の行を追加します: `export PATH="$PATH:/usr/local/kubectl-tmux-exec/bin"`。

4. 依存関係をインストールします。([Wiki: 依存関係のインストール方法](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

## 使用方法

`kubectl` ≥ 1.12 ([プラグインサポート]) を使用していることを確認してください。理想的には最新バージョンです。

それ以外の場合は、スクリプトを直接実行します: `kubectl-tmux_exec [...ARGS]`。


スクリプトが正常に追加されたかどうかを確認するには：

```sh
kubectl plugin list
```
出力は以下のようになります


```txt
The following compatible plugins are available:

/usr/local/bin/kubectl-tmux_exec
```

リストに表示されない場合は、再度 `$PATH` 環境変数を確認してください。

以下のコマンドを使用して、スクリプトの使用法を取得できます。

```sh
kubectl tmux-exec --help

# or
kubectl-tmux_exec --help
```

### オプション

| フラグ                            | 使用法                                                                                                                                                      |
|---------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `-V`<br>`--version`             | バージョン情報を表示                                                                                                                                        |
| `-l`<br>`--selector`            | フィルタリングに使うセレクター（ラベルクエリ）、'=', '==', '!='をサポート (例: -l key1=value1,key2=value2)<br> `--selector` または `--file` オプションのいずれかを使用する必要があります。 |
| `-f`<br>`--file`                | ファイルからポッド名を1行ずつ読み込む。<br> `--selector` または `--file` オプションのいずれかを使用する必要があります。                                      |
| `-c`<br>`--container`           | コンテナ名。省略した場合はポッド内の最初のコンテナが選択されます                                                                                             |
| `-i`<br>`--stdin`               | 標準入力をコンテナに渡す（**非推奨**、デフォルトで有効なため）                                                                                            |
| `-t`<br>`--tty`                 | 標準入力がTTYになる（**非推奨**、デフォルトで有効なため）                                                                                                   |
| `-d`<br>`--detach`              | Tmuxセッションをデタッチ状態で開始                                                                                                                         |
| `-n`<br>`--namespace=`          | このCLIリクエストの名前空間スコープ（複数回指定可能）                                                                                                       |
| `--context`                     | 使用するkubeconfigコンテキスト名（複数回指定可能）                                                                                                         |
| `-A`<br>`--all-namespaces`      | 指定された場合、すべての名前空間の対象オブジェクトを一覧表示および実行。 `--namespace` 指定があっても現在のコンテキストの名前空間は無視されます。           |
| `-C`<br>`--enable-control-mode` | Tmuxをコントロールモードで起動し、エコーを無効にする。（参照：[iTerm2連携](#iterm2-integration)）                                                          |
| `--remain-on-exit`              | 終了後もTmuxウィンドウを残す                                                                                                                               |
| `--select-layout`               | 5つのTmuxプリセットレイアウトのいずれか: even-horizontal, even-vertical, main-horizontal, main-vertical, tiled。                                         |
| `--session-mode`                | Tmuxを開く場所: auto, new-session, current-session                                                                                                         |

これらのオプションの使用法は `--help` でも確認できます。

### 例

`tmux-exec` は `exec` と似ていますが、`exec` がポッド名を必要とするのに対し、ラベルセレクターを必要とします。

共通のラベル、例えば `foo=bar` を持つすべてのポッドのコンテナに `bash` で入るには。

```sh
kubectl tmux-exec -l foo=bar /bin/bash
```

選択したコンテナに `bash` で正常に入ると、実際には Tmux ウィンドウが開き、各ペインに各ポッドのコンテナの実行結果が表示されます。キーボード入力はすべてのペインに同期されます。

Tmux に不慣れな場合は、tmux のマニュアルページやオンラインチュートリアルを参照してください。また、以下の[チートシート](#tmux-cheatsheet)も十分役立つと思います。

### iTerm2 統合

`-C` または `--enable-control-mode` オプションで制御モードで実行し、ペインの入力を [iTerm2] の「Broadcast Input」機能に委譲します。
tmux のキーバインドは不要です。

iTerm2 でのブロードキャスト切り替えは <kbd>⌘</kbd> + <kbd>⌥</kbd> + <kbd>i</kbd> を使用します。（このモードでは `synchronize-panes` は自動的に無効になります。）

（詳細は [tmux Integration](https://iterm2.com/documentation-tmux-integration.html) を参照してください）

#### 例

```sh
kubectl tmux-exec -C -l app=nginx /bin/bash
```

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot-iterm2-integration.png?raw=true)

### シェルの自動補完

詳細は[このWiki](https://github.com/predatorray/kubectl-tmux-exec/wiki/Shell-Auto-completion)をご覧ください。

### Tmux チートシート

すべてのTmuxコマンドは `PREFIX` で始まります。デフォルトの `PREFIX` は <kbd>Ctrl</kbd> + <kbd>b</kbd> です。以下ではこれを `C-b` と表記します。

`C-b d`、セッションからデタッチします。その後、Tmuxはバックグラウンドで動作しています。`tmux a` と入力して再アタッチできます。

`C-b :setw synchronize-panes off`、すべてのペインへの入力同期をオフにします。

`C-b :setw synchronize-panes on`、すべてのペインへの入力同期をオンにします。

`C-b <ARROW-KEY>`、ペイン間でカーソルを移動します。

`C-b xy`、現在のペインを閉じます。

`C-b &y`、すべてのペインを含むウィンドウを閉じます。

## コミュニティとサポート

- [GitHub Issues]((https://github.com/predatorray/kubectl-tmux-exec/issues/new)) を通じて問題報告や機能リクエストを行えます。
- 議論のために [Googleグループ](https://groups.google.com/g/kubectl-tmux-exec) に参加してください。

## その他のプラグイン

[kubectl-alias](https://github.com/predatorray/kubectl-alias): kubectlのための欠けていたエイリアスコマンド。

## コーヒーをおごってください

時間の節約になったら、どうぞ[コーヒーをおごってください] 🙌

[![](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)][buy me a coffee]

[buy me a coffee]: https://buymeacoffee.com/predatorray
[iTerm2]: https://iterm2.com/index.html
[プラグインサポート]: https://kubernetes.io/docs/tasks/extend-kubectl/kubectl-plugins/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---