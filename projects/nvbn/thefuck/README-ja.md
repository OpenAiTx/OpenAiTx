# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* は、[@liamosaur](https://twitter.com/liamosaur/)の
[tweet](https://twitter.com/liamosaur/status/506975850596536320) に触発された素晴らしいアプリで、直前のコンソールコマンドのエラーを修正します。

*The Fuck* が遅すぎると感じますか？ [実験的なインスタントモードをお試しください！](#experimental-instant-mode)

[![例付きのgif][examples-link]][examples-link]

他の例：

```bash
➜ apt-get install vim
E: Could not open lock file /var/lib/dpkg/lock - open (13: Permission denied)
E: Unable to lock the administration directory (/var/lib/dpkg/), are you root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] password for nvbn:
Reading package lists... Done
...
```

```bash
➜ git push
fatal: The current branch master has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin master


➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Counting objects: 9, done.
...
```

```bash
➜ puthon
No command 'puthon' found, did you mean:
 Command 'python' from package 'python-minimal' (main)
 Command 'python' from package 'python3' (main)
zsh: command not found: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' is not a git command. See 'git --help'.

Did you mean this?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' is not a task. See 'lein help'.

Did you mean this?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL server started on port 54848 on host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

修正されたコマンドを無条件に実行することに抵抗がない場合は、
`require_confirmation` [設定](#settings) オプションを無効にできます：

```bash
➜ apt-get install vim
E: Could not open lock file /var/lib/dpkg/lock - open (13: Permission denied)
E: Unable to lock the administration directory (/var/lib/dpkg/), are you root?

➜ fuck
sudo apt-get install vim
[sudo] password for nvbn:
Reading package lists... Done
...
```

## 目次

1. [必要要件](#requirements)
2. [インストール](#installation)
3. [アップデート](#updating)
4. [仕組み](#how-it-works)
5. [独自ルールの作成](#creating-your-own-rules)
6. [設定](#settings)
7. [サードパーティパッケージのルール](#third-party-packages-with-rules)
8. [実験的インスタントモード](#experimental-instant-mode)
9. [開発](#developing)
10. [ライセンス](#license-mit)

## 必要要件

- python (3.5以上)
- pip
- python-dev

##### [目次に戻る](#contents)

## インストール

macOSまたはLinuxでは、[Homebrew][homebrew] を使って *The Fuck* をインストールできます：

```bash
brew install thefuck
```

Ubuntu / Mint では、以下のコマンドで *The Fuck* をインストールします：
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

FreeBSD では、以下のコマンドで *The Fuck* をインストールします：
```bash
pkg install thefuck
```

ChromeOS では、[chromebrew](https://github.com/skycocker/chromebrew) を使用して以下のコマンドでインストールします：
```bash
crew install thefuck
```

Arch系システムでは、以下のコマンドでインストールします：
```
sudo pacman -S thefuck
```

その他のシステムでは、`pip` を使って *The Fuck* をインストールしてください：

```bash
pip install thefuck
```

[また、OSのパッケージマネージャー（OS X、Ubuntu、Arch）を利用することもできます。](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
このコマンドを `.bash_profile`、`.bashrc`、`.zshrc` などのスタートアップスクリプトに記載することを推奨します：

```bash
eval $(thefuck --alias)
# 任意のエイリアス名を利用可能です。例：月曜日用
eval $(thefuck --alias FUCK)
```

[または、シェル設定（Bash、Zsh、Fish、Powershell、tcsh）に追加してください。](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

設定の変更は新しいシェルセッションでのみ反映されます。すぐに反映させるには `source ~/.bashrc`（または `.zshrc` など）を実行してください。

確認なしで修正コマンドを実行したい場合は、`--yeah` オプション（または短縮の `-y`、特に苛立っている場合は `--hard`）を使います：

```bash
fuck --yeah
```

成功するまでコマンドを再帰的に修正したい場合は、`-r` オプションを使います：

```bash
fuck -r
```

##### [目次に戻る](#contents)

## アップデート

```bash
pip3 install thefuck --upgrade
```

**注意: v1.34 でエイリアス機能が変更されました**

## アンインストール

*The Fuck* を削除するには、インストール手順を逆に実行してください：
- Bash、Zsh、Fish、Powershell、tcsh などのシェル設定から *thefuck* のエイリアス行を削除またはコメントアウト
- パッケージマネージャー（brew, pip3, pkg, crew, pipなど）でバイナリをアンインストール

## 仕組み

*The Fuck* は直前のコマンドとルールを照合し、一致すれば新しいコマンドを生成して実行します。
以下のルールがデフォルトで有効です：

* `adb_unknown_command` &ndash; `adb logcta` のようなスペルミスを修正
* `ag_literal` &ndash; `ag` に `-Q` を追加
* `aws_cli` &ndash; `aws dynamdb scan` のようなスペルミスを修正
* `az_cli` &ndash; `az providers` のようなスペルミスを修正
* `cargo` &ndash; `cargo` の代わりに `cargo build` を実行
* `cargo_no_command` &ndash; `cargo buid` のような間違いを修正
* `cat_dir` &ndash; ディレクトリに `cat` しようとした場合 `ls` に置換
* `cd_correction` &ndash; cdコマンドのスペルチェックと修正
* `cd_cs` &ndash; `cs` を `cd` に変更
* `cd_mkdir` &ndash; ディレクトリがなければ作成してからcd
* `cd_parent` &ndash; `cd..` を `cd ..` に修正
* `chmod_x` &ndash; 実行権限を追加
* `choco_install` &ndash; chocolateyパッケージの一般的なサフィックスを追加
* `composer_not_command` &ndash; composerコマンド名の修正
* `conda_mistype` &ndash; condaコマンドの修正
* `cp_create_destination` &ndash; 存在しないディレクトリに `cp` や `mv` しようとした場合にディレクトリを作成
* `cp_omitting_directory` &ndash; ディレクトリを `cp` する際に `-a` を追加
* `cpp11` &ndash; `g++` や `clang++` に足りない `-std=c++11` を追加
* `dirty_untar` &ndash; 現在のディレクトリで展開してしまった `tar x` コマンドを修正
* `dirty_unzip` &ndash; 現在のディレクトリで展開してしまった `unzip` コマンドを修正
* `django_south_ghost` &ndash; ゴーストによる失敗に `--delete-ghost-migrations` を追加
* `django_south_merge` &ndash; 一貫性のないマイグレーションに `--merge` を追加
* `docker_login` &ndash; `docker login` を実行し、前回のコマンドを再実行
* `docker_not_command` &ndash; `docker tags` など間違ったdockerコマンドを修正
* `docker_image_being_used_by_container` &dash; イメージを使用しているコンテナを削除してからイメージを削除
* `dry` &ndash; `git git push` のような繰り返しを修正
* `fab_command_not_found` &ndash; fabricコマンドのスペルミスを修正
* `fix_alt_space` &ndash; Alt+Space をスペースに置換
* `fix_file` &ndash; `$EDITOR` でエラーのあるファイルを開く
* `gem_unknown_command` &ndash; `gem` コマンドのミスを修正
* `git_add` &ndash; *"pathspec 'foo' did not match any file(s) known to git."* を修正
* `git_add_force` &ndash; .gitignore対象のパスで `git add <pathspec>...` に `--force` を追加
* `git_bisect_usage` &ndash; `git bisect strt`, `git bisect goood`, `git bisect rset` などの修正
* `git_branch_delete` &ndash; `git branch -d` を `git branch -D` に変更
* `git_branch_delete_checked_out` &ndash; チェックアウト中のブランチ削除時に `git checkout master && git branch -D` に変更
* `git_branch_exists` &ndash; 既存ブランチ作成時に各種オプションを提案
* `git_branch_list` &ndash; `git branch list` を検知し、作成したブランチを削除
* `git_branch_0flag` &ndash; `git branch 0v` などの修正
* `git_checkout` &ndash; ブランチ名修正または新規作成
* `git_clone_git_clone` &ndash; `git clone git clone ...` を `git clone ...` に置換
* `git_clone_missing` &ndash; gitリポジトリURLに `git clone` を追加
* `git_commit_add` &ndash; ステージされていない場合に `git commit -a ...` や `git commit -p ...` を提案
* `git_commit_amend` &ndash; コミット後に `git commit --amend` を提案
* `git_commit_reset` &ndash; コミット後に `git reset HEAD~` を提案
* `git_diff_no_index` &ndash; 未追跡ファイルで `git diff` に `--no-index` を追加
* `git_diff_staged` &ndash; 予期しない出力時に `git diff` に `--staged` を追加
* `git_fix_stash` &ndash; `git stash` のサブコマンドや `save` のスペルミスを修正
* `git_flag_after_filename` &ndash; `fatal: bad flag '...' after filename` の修正
* `git_help_aliased` &ndash; `git help <alias>` をエイリアスのコマンドに置換
* `git_hook_bypass` &ndash; `--no-verify` を `git am`, `git commit`, `git push` に追加
* `git_lfs_mistype` &ndash; `git lfs <command>` のスペルミスを修正
* `git_main_master` &ndash; `main` と `master` 間のブランチ名の間違い修正
* `git_merge` &ndash; ブランチ名にリモートを追加
* `git_merge_unrelated` &ndash; 必要時に `--allow-unrelated-histories` を追加
* `git_not_command` &ndash; `git brnch` などのスペルミスを修正
* `git_pull` &ndash; アップストリーム設定後に `git pull` を実行
* `git_pull_clone` &ndash; リポジトリが存在しない場合は `pull` の代わりに `clone`
* `git_pull_uncommitted_changes` &ndash; スタッシュしてから `pull`、その後ポップ
* `git_push` &ndash; 失敗した `git push` に `--set-upstream origin $branch` を追加
* `git_push_different_branch_names` &ndash; ローカルとリモートのブランチ名不一致時の修正
* `git_push_pull` &ndash; `push` が拒否されたら `git pull` を実行
* `git_push_without_commits` &ndash; 初回コミットを忘れたときに作成
* `git_rebase_no_changes` &ndash; 変更がない場合 `git rebase --continue` の代わりに `git rebase --skip`
* `git_remote_delete` &ndash; `git remote delete remote_name` を `git remote remove remote_name` に置換
* `git_rm_local_modifications` &ndash; ローカル修正ファイル削除時に `-f` や `--cached` を追加
* `git_rm_recursive` &ndash; ディレクトリ削除時に `-r` を追加
* `git_rm_staged` &ndash; ステージされたファイル削除時に `-f` または `--cached` を追加
* `git_rebase_merge_dir` &ndash; リベース中に `git rebase (--continue | --abort | --skip)` や `.git/rebase-merge` ディレクトリの削除を提案
* `git_remote_seturl_add` &ndash; 存在しないリモートで `git remote set_url` 実行時に `git remote add` を実行
* `git_stash` &ndash; リベースやブランチ切り替え前にローカル変更をスタッシュ
* `git_stash_pop` &ndash; スタッシュポップ前にローカル変更を追加、その後リセット
* `git_tag_force` &ndash; 既存タグの際に `git tag <tagname>` に `--force` を追加
* `git_two_dashes` &ndash; `git commit -amend` や `git rebase -continue` のようなコマンドにダッシュを追加
* `go_run` &ndash; Goプログラムのコンパイル/実行時に `.go` 拡張子を追加
* `go_unknown_command` &ndash; `go bulid` などのスペルミスを修正
* `gradle_no_task` &ndash; 未発見または曖昧な `gradle` タスクの修正
* `gradle_wrapper` &ndash; `gradle` を `./gradlew` に置換
* `grep_arguments_order` &ndash; `grep -lir . test` のような引数順の修正
* `grep_recursive` &ndash; ディレクトリ検索時に `-r` を追加
* `grunt_task_not_found` &ndash; `grunt` コマンドのスペルミスを修正
* `gulp_not_task` &ndash; `gulp` タスクのスペルミスを修正
* `has_exists_script` &ndash; スクリプト/バイナリが存在する場合 `./` を前置
* `heroku_multiple_apps` &ndash; `heroku pg` などに `--app <app>` を追加
* `heroku_not_command` &ndash; `heroku log` などのスペルミスを修正
* `history` &ndash; 履歴から最も類似したコマンドに置換
* `hostscli` &ndash; `hostscli` の使用を修正
* `ifconfig_device_not_found` &ndash; `wlan0` を `wlp2s0` など正しいデバイス名に修正
* `java` &ndash; Javaプログラム実行時に `.java` 拡張子を削除
* `javac` &ndash; Javaファイルコンパイル時に `.java` を追加
* `lein_not_task` &ndash; `lein rpl` などのタスクミスを修正
* `long_form_help` &ndash; `-h` を `--help` に変更
* `ln_no_hard_link` &ndash; ディレクトリにハードリンクを作成しようとした場合、シンボリックリンクを提案
* `ln_s_order` &ndash; `ln -s` の引数順を修正
* `ls_all` &ndash; `ls` の出力が空の場合 `-A` を追加
* `ls_lah` &ndash; `ls` に `-lah` を追加
* `man` &ndash; マニュアルセクションを変更
* `man_no_space` &ndash; `mandiff` などスペースなしのmanコマンドを修正
* `mercurial` &ndash; `hg` コマンドのスペルミスを修正
* `missing_space_before_subcommand` &ndash; `npminstall` のようなサブコマンド前のスペース忘れを修正
* `mkdir_p` &ndash; 親ディレクトリなしでディレクトリ作成時に `-p` を追加
* `mvn_no_command` &ndash; `mvn` に `clean package` を追加
* `mvn_unknown_lifecycle_phase` &ndash; `mvn` のライフサイクルフェーズのスペルミスを修正
* `npm_missing_script` &ndash; `npm run-script <script>` のカスタムスクリプト名の修正
* `npm_run_script` &ndash; カスタム `npm` スクリプトに `run-script` を追加
* `npm_wrong_command` &ndash; `npm urgrade` などのスペルミスを修正
* `no_command` &ndash; `vom/vim` などのコマンドミスを修正
* `no_such_file` &ndash; `mv` や `cp` で足りないディレクトリを作成
* `omnienv_no_such_command` &ndash; `goenv`, `nodenv`, `pyenv`, `rbenv` などのコマンドミスを修正
* `open` &ndash; アドレスに `http://` を追加または新しいファイル/ディレクトリを作成して `open` へ渡す
* `pip_install` &ndash; 必要に応じて `--user` を追加したり `sudo` を前置して `pip install` の権限問題を修正
* `pip_unknown_command` &ndash; `pip instatl/pip install` などのスペルミスを修正
* `php_s` &ndash; ローカルphpサーバー起動時 `-s` を `-S` に置換
* `port_already_in_use` &ndash; 使用中のポートをバインドしているプロセスをkill
* `prove_recursively` &ndash; ディレクトリ指定時に `-r` を追加
* `python_command` &ndash; 実行権限なしや `./` なしのpythonスクリプトに `python` を前置
* `python_execute` &ndash; Pythonファイル実行時に `.py` を追加
* `python_module_error` &ndash; ModuleNotFoundError発生時に該当モジュールを `pip install`
* `quotation_marks` &ndash; 引数内の `'` や `"` の不一致を修正
* `path_from_history` &ndash; 見つからないパスを履歴から類似の絶対パスに置換
* `rails_migrations_pending` &ndash; 保留中のマイグレーションを実行
* `react_native_command_unrecognized` &ndash; 認識されない `react-native` コマンドの修正
* `remove_shell_prompt_literal` &ndash; ドキュメントからコピーした際の先頭の `$` を削除
* `remove_trailing_cedilla` &ndash; ヨーロッパキーボードでよくある末尾の `ç` を削除
* `rm_dir` &ndash; ディレクトリ削除時に `-rf` を追加
* `scm_correction` &ndash; `hg log` を `git log` など正しいscmに修正
* `sed_unterminated_s` &ndash; `sed` の `s` コマンドに足りない `/` を追加
* `sl_ls` &ndash; `sl` を `ls` に変更
* `ssh_known_hosts` &ndash; 警告時に `known_hosts` からホストを削除
* `sudo` &ndash; 権限エラー時に前回コマンドへ `sudo` を前置
* `sudo_command_from_user_path` &ndash; ユーザーの `$PATH` にあるコマンドを `sudo` で実行
* `switch_lang` &ndash; コマンドをローカルレイアウトからenに変換
* `systemctl` &ndash; 分かりにくい `systemctl` のパラメータ順を修正
* `terraform_init.py` &ndash; `plan` または `apply` 前に `terraform init` を実行
* `terraform_no_command.py` &ndash; 未認識の `terraform` コマンドを修正
* `test.py` &ndash; `test.py` の代わりに `pytest` を実行
* `touch` &ndash; "touch" 前にディレクトリを作成
* `tsuru_login` &ndash; 認証されていないかセッション切れの場合 `tsuru login` を実行
* `tsuru_not_command` &ndash; `tsuru shell` などのスペルミスを修正
* `tmux` &ndash; `tmux` コマンドの修正
* `unknown_command` &ndash; hadoop hdfs系の "unknown command" を修正。例えば `hdfs dfs ls` で足りない `-` を追加
* `unsudo` &ndash; スーパーユーザー権限での実行を拒否された場合に前回コマンドから `sudo` を削除
* `vagrant_up` &ndash; vagrantインスタンスを起動
* `whois` &ndash; `whois` コマンドを修正
* `workon_doesnt_exists` &ndash; `virtualenvwrapper` の環境名が存在しない場合に修正または新規作成を提案
* `wrong_hyphen_before_subcommand` &ndash; サブコマンド前の誤ったハイフン（`apt-install` -> `apt install`、`git-log` -> `git log` など）を削除
* `yarn_alias` &ndash; `yarn ls` などのエイリアスコマンドを修正
* `yarn_command_not_found` &ndash; `yarn` コマンドのスペルミスを修正
* `yarn_command_replaced` &ndash; 置換された `yarn` コマンドを修正
* `yarn_help` &ndash; `yarn` ドキュメントの表示を簡単に

##### [目次に戻る](#contents)

以下のルールは特定プラットフォームでのみデフォルト有効です：

* `apt_get` &ndash; アプリ未インストール時にaptからインストール（`python-commandnotfound` / `python3-commandnotfound` が必要）
* `apt_get_search` &ndash; `apt-get` での検索を `apt-cache` に置換
* `apt_invalid_operation` &ndash; `apt-get isntall vim` などの無効なaptコールを修正
* `apt_list_upgradable` &ndash; `apt update` の後に `apt list --upgradable` を実行
* `apt_upgrade` &ndash; `apt list --upgradable` の後に `apt upgrade` を実行
* `brew_cask_dependency` &ndash; cask依存関係をインストール
* `brew_install` &ndash; `brew install` のformula名を修正
* `brew_reinstall` &ndash; `brew install <formula>` を `brew reinstall <formula>` に変換
* `brew_link` &ndash; リンク失敗時に `--overwrite --dry-run` を追加
* `brew_uninstall` &ndash; 複数バージョンインストール時に `brew uninstall` に `--force` を追加
* `brew_unknown_command` &ndash; `brew docto/brew doctor` などのスペルミスを修正
* `brew_update_formula` &ndash; `brew update <formula>` を `brew upgrade <formula>` に変換
* `dnf_no_such_command` &ndash; DNFコマンドのスペルミスを修正
* `nixos_cmd_not_found` &ndash; NixOSでアプリをインストール
* `pacman` &ndash; インストールされていない場合pacmanでアプリをインストール（`yay`、`pikaur`、`yaourt`利用可）
* `pacman_invalid_option` &ndash; 小文字のpacmanオプションを大文字に変換
* `pacman_not_found` &ndash; `pacman`、`yay`、`pikaur`、`yaourt` でパッケージ名を修正
* `yum_invalid_operation` &ndash; `yum isntall vim` などの無効なyumコールを修正

以下のコマンドは *The Fuck* にバンドルされていますが、デフォルトでは有効になっていません：

* `git_push_force` &ndash; `git push` に `--force-with-lease` を追加（`git_push_pull` と競合する場合あり）
* `rm_root` &ndash; `rm -rf /` コマンドに `--no-preserve-root` を追加

##### [目次に戻る](#contents)

## 独自ルールの作成

独自ルールを追加するには、`~/.config/thefuck/rules` に `your-rule-name.py` というファイルを作成します。ルールファイルには次の2つの関数が必要です：

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

加えて、以下のようなオプション関数も追加できます：

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
また、`enabled_by_default`、`requires_output`、`priority` というオプション変数も設定可能です。

`Command` には `script`、`output`、`script_parts` の3つの属性があります。
ルールで `Command` を変更しないでください。

**3.0でRules API変更：** ルールの設定にアクセスするには
 `from thefuck.conf import settings` を使います。

`settings` は `~/.config/thefuck/settings.py` と環境変数から構成される特別なオブジェクトです（[詳細は下記](#settings)）。

`sudo` でスクリプトを実行する簡単なルール例：

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# オプション:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # 小さいほど優先、デフォルトは1000

requires_output = True
```

[ルールの他の例](https://github.com/nvbn/thefuck/tree/master/thefuck/rules)、
[ルール用ユーティリティ関数](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py)、
[アプリ/OS固有のヘルパー](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/)。

##### [目次に戻る](#contents)

## 設定

*The Fuck* の各種パラメータは `$XDG_CONFIG_HOME/thefuck/settings.py`
（`$XDG_CONFIG_HOME` のデフォルトは `~/.config`）で変更できます：

* `rules` &ndash; 有効なルールのリスト。デフォルトは `thefuck.const.DEFAULT_RULES`
* `exclude_rules` &ndash; 無効化ルールのリスト。デフォルトは `[]`
* `require_confirmation` &ndash; 新しいコマンド実行前に確認。デフォルト `True`
* `wait_command` &ndash; 前回コマンド出力取得の最大秒数
* `no_colors` &ndash; カラー出力無効化
* `priority` &ndash; ルールごとの優先度。値が小さいほど先にマッチ
* `debug` &ndash; デバッグ出力有効化。デフォルト `False`
* `history_limit` &ndash; 履歴コマンド走査数。例：`2000`
* `alter_history` &ndash; 修正コマンドを履歴に追加。デフォルト `True`
* `wait_slow_command` &ndash; `slow_commands` リストのコマンド出力取得の最大秒数
* `slow_commands` &ndash; 遅いコマンドのリスト
* `num_close_matches` &ndash; 類似候補の最大数。デフォルト `3`
* `excluded_search_path_prefixes` &ndash; コマンド検索時に無視するパスプレフィックス。デフォルト `[]`

`settings.py` の例：

```python
rules = ['sudo', 'no_command']
exclude_rules = ['git_push']
require_confirmation = True
wait_command = 10
no_colors = False
priority = {'sudo': 100, 'no_command': 9999}
debug = False
history_limit = 9999
wait_slow_command = 20
slow_commands = ['react-native', 'gradle']
num_close_matches = 5
```

または環境変数でも設定できます：

* `THEFUCK_RULES` &ndash; 有効なルールリスト。例：`DEFAULT_RULES:rm_root` または `sudo:no_command`
* `THEFUCK_EXCLUDE_RULES` &ndash; 無効化ルールリスト。例：`git_pull:git_push`
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; 新コマンド実行前に確認。`true/false`
* `THEFUCK_WAIT_COMMAND` &ndash; 前回コマンド出力取得の最大秒数
* `THEFUCK_NO_COLORS` &ndash; カラー出力無効化。`true/false`
* `THEFUCK_PRIORITY` &ndash; ルール優先度。例：`no_command=9999:apt_get=100`
* `THEFUCK_DEBUG` &ndash; デバッグ出力有効化。`true/false`
* `THEFUCK_HISTORY_LIMIT` &ndash; 履歴コマンド走査数。例：`2000`
* `THEFUCK_ALTER_HISTORY` &ndash; 修正コマンドを履歴に追加。`true/false`
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; `slow_commands` コマンド出力取得の最大秒数
* `THEFUCK_SLOW_COMMANDS` &ndash; 遅いコマンドリスト。例：`lein:gradle`
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; 類似候補の最大数。例：`5`
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; コマンド検索時に無視するパスプレフィックス。デフォルト `[]`

例えば：

```bash
export THEFUCK_RULES='sudo:no_command'
export THEFUCK_EXCLUDE_RULES='git_pull:git_push'
export THEFUCK_REQUIRE_CONFIRMATION='true'
export THEFUCK_WAIT_COMMAND=10
export THEFUCK_NO_COLORS='false'
export THEFUCK_PRIORITY='no_command=9999:apt_get=100'
export THEFUCK_HISTORY_LIMIT='2000'
export THEFUCK_NUM_CLOSE_MATCHES='5'
```

##### [目次に戻る](#contents)

## サードパーティパッケージのルール

特定の非公開ルールセットを作りつつ他の人と共有したい場合は、`thefuck_contrib_*` という名前で次の構成のパッケージを作成してください：

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *サードパーティルール*
    __init__.py
    *サードパーティユーティリティ*
  setup.py
```

*The Fuck* は `rules` モジュール内のルールを自動で検出します。

##### [目次に戻る](#contents)

## 実験的インスタントモード

*The Fuck* のデフォルト動作では、前回コマンドを再実行するために時間がかかります。
インスタントモードでは、[script](https://en.wikipedia.org/wiki/Script_(Unix)) で出力をログに残し、それを読み取ることで時間短縮を図ります。

[![インスタントモードのgif][instant-mode-gif-link]][instant-mode-gif-link]

現在、インスタントモードはPython 3かつbashまたはzshのみ対応しています。zshの場合、thefuckが正しく動作するためzshのautocorrect機能を無効にする必要があります。

インスタントモードを有効にするには、`.bashrc`、`.bash_profile`、`.zshrc` のエイリアス初期化に `--enable-experimental-instant-mode` を追加します。

例：

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [目次に戻る](#contents)

## 開発

[CONTRIBUTING.md](CONTRIBUTING.md) を参照してください。

## ライセンス MIT
プロジェクトのライセンスは[こちら](LICENSE.md)です。

[version-badge]:   https://img.shields.io/pypi/v/thefuck.svg?label=version
[version-link]:    https://pypi.python.org/pypi/thefuck/
[workflow-badge]:  https://github.com/nvbn/thefuck/workflows/Tests/badge.svg
[workflow-link]:   https://github.com/nvbn/thefuck/actions?query=workflow%3ATests
[coverage-badge]:  https://img.shields.io/coveralls/nvbn/thefuck.svg
[coverage-link]:   https://coveralls.io/github/nvbn/thefuck
[license-badge]:   https://img.shields.io/badge/license-MIT-007EC7.svg
[examples-link]:   https://raw.githubusercontent.com/nvbn/thefuck/master/example.gif
[instant-mode-gif-link]:   https://raw.githubusercontent.com/nvbn/thefuck/master/example_instant_mode.gif
[homebrew]:        https://brew.sh/

##### [目次に戻る](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---