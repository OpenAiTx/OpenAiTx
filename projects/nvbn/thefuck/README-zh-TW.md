# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* 是一個絕妙的應用程式，靈感來自於 [@liamosaur](https://twitter.com/liamosaur/) 的
[tweet](https://twitter.com/liamosaur/status/506975850596536320)，
可修正先前終端機指令的錯誤。

覺得 *The Fuck* 太慢嗎？[試試實驗性的即時模式！](#experimental-instant-mode)

[![範例動畫][examples-link]][examples-link]

更多範例：

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

如果你不擔心盲目執行修正後的指令，可以將
`require_confirmation` [設定](#settings) 選項關閉：

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

## 目錄

1. [系統需求](#requirements)
2. [安裝](#installation)
3. [更新](#updating)
4. [運作方式](#how-it-works)
5. [自訂規則](#creating-your-own-rules)
6. [設定](#settings)
7. [含規則的第三方套件](#third-party-packages-with-rules)
8. [實驗性即時模式](#experimental-instant-mode)
9. [開發](#developing)
10. [授權](#license-mit)

## 系統需求

- python (3.5+)
- pip
- python-dev

##### [回目錄](#contents)

## 安裝

在 macOS 或 Linux 上，你可以透過 [Homebrew][homebrew] 安裝 *The Fuck*：

```bash
brew install thefuck
```

在 Ubuntu / Mint 上，使用以下指令安裝 *The Fuck*：
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

在 FreeBSD 上，使用以下指令安裝 *The Fuck*：
```bash
pkg install thefuck
```

在 ChromeOS 上，使用 [chromebrew](https://github.com/skycocker/chromebrew) 安裝 *The Fuck*：
```bash
crew install thefuck
```

在 Arch 系統上，使用以下指令安裝 *The Fuck*：
```
sudo pacman -S thefuck
```

在其他系統上，可使用 `pip` 安裝 *The Fuck*：

```bash
pip install thefuck
```

[你也可以選擇使用 OS 套件管理工具（OS X、Ubuntu、Arch）。](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
建議你將下列指令放入你的 `.bash_profile`、
`.bashrc`、`.zshrc` 或其他啟動腳本中：

```bash
eval $(thefuck --alias)
# 你可以自訂別名，例如專屬星期一的:
eval $(thefuck --alias FUCK)
```

[或放在你的 shell 設定檔（Bash、Zsh、Fish、Powershell、tcsh）。](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

更動只會在新開的 shell session 有效。若要立即生效，請執行 `source ~/.bashrc`（或你的 shell 設定檔，如 `.zshrc`）。

若要無需確認直接執行修正後指令，請加上 `--yeah` 參數（或簡寫 `-y`，或當你特別火大時用 `--hard`）：

```bash
fuck --yeah
```

若要遞迴修正指令直到成功，使用 `-r` 參數：

```bash
fuck -r
```

##### [回目錄](#contents)

## 更新

```bash
pip3 install thefuck --upgrade
```

**注意：*The Fuck* v1.34 起 alias 功能有所變更**

## 移除安裝

要移除 *The Fuck*，請反向操作安裝流程：
- 刪除或註解 shell 設定檔（Bash、Zsh、Fish、Powershell、tcsh ...）中的 *thefuck* 別名行
- 使用你的套件管理工具（brew、pip3、pkg、crew、pip）解除安裝 binary 檔案

## 運作方式

*The Fuck* 會嘗試將先前的指令與規則比對。如果有符合的規則，就會用該規則建立新指令並執行。以下規則預設啟用：

* `adb_unknown_command` &ndash; 修正像是 `adb logcta` 拼錯的指令；
* `ag_literal` &ndash; 建議時為 `ag` 加上 `-Q`；
* `aws_cli` &ndash; 修正像 `aws dynamdb scan` 的拼錯指令；
* `az_cli` &ndash; 修正像 `az providers` 的拼錯指令；
* `cargo` &ndash; 將 `cargo` 執行替換為 `cargo build`；
* `cargo_no_command` &ndash; 修正像 `cargo buid` 這種錯誤指令；
* `cat_dir` &ndash; 當你對資料夾執行 `cat` 時，自動改為 `ls`；
* `cd_correction` &ndash; 拼字檢查並修正失敗的 cd 指令；
* `cd_cs` &ndash; 將 `cs` 改為 `cd`；
* `cd_mkdir` &ndash; 在 cd 前先建立資料夾；
* `cd_parent` &ndash; 將 `cd..` 改為 `cd ..`；
* `chmod_x` &ndash; 加上執行權限；
* `choco_install` &ndash; 自動補全 chocolatey 套件常見字尾；
* `composer_not_command` &ndash; 修正 composer 指令名稱；
* `conda_mistype` &ndash; 修正 conda 指令；
* `cp_create_destination` &ndash; 當你嘗試用 `cp` 或 `mv` 到不存在的資料夾時自動建立新資料夾；
* `cp_omitting_directory` &ndash; 當你對資料夾使用 `cp` 時加上 `-a`；
* `cpp11` &ndash; 幫 `g++` 或 `clang++` 加上缺少的 `-std=c++11`；
* `dirty_untar` &ndash; 修正將 tar 解壓到目前目錄的 `tar x` 指令；
* `dirty_unzip` &ndash; 修正將 unzip 解壓到目前目錄的指令；
* `django_south_ghost` &ndash; 為因 ghost 導致失敗的 django south migration 加上 `--delete-ghost-migrations`；
* `django_south_merge` &ndash; 為不一致的 django south migration 加上 `--merge`；
* `docker_login` &ndash; 執行 `docker login` 並重複執行上個指令；
* `docker_not_command` &ndash; 修正像 `docker tags` 這類拼錯的 docker 指令；
* `docker_image_being_used_by_container` &ndash; 在移除映像檔前先移除正在使用該映像檔的 container；
* `dry` &ndash; 修正像 `git git push` 這類重複輸入的指令；
* `fab_command_not_found` &ndash; 修正拼錯的 fabric 指令；
* `fix_alt_space` &ndash; 將 Alt+Space 替換為 Space 字元；
* `fix_file` &ndash; 用你的 `$EDITOR` 開啟有錯誤的檔案；
* `gem_unknown_command` &ndash; 修正錯誤的 `gem` 指令；
* `git_add` &ndash; 修正 *"pathspec 'foo' did not match any file(s) known to git."*；
* `git_add_force` &ndash; 當路徑被 .gitignore 時，對 `git add <pathspec>...` 加上 `--force`；
* `git_bisect_usage` &ndash; 修正 bisecting 時的 `git bisect strt`、`git bisect goood`、`git bisect rset` 等指令；
* `git_branch_delete` &ndash; 將 `git branch -d` 改為 `git branch -D`；
* `git_branch_delete_checked_out` &ndash; 當嘗試刪除已簽出的分支時，將 `git branch -d` 改為 `git checkout master && git branch -D`；
* `git_branch_exists` &ndash; 建立已存在分支時，提供 `git branch -d foo`、`git branch -D foo` 或 `git checkout foo` 選項；
* `git_branch_list` &ndash; 捕捉 `git branch list` 取代 `git branch` 並移除建立的分支；
* `git_branch_0flag` &ndash; 修正如 `git branch 0v`、`git branch 0r` 等指令，並移除建立的分支；
* `git_checkout` &ndash; 修正分支名稱或建立新分支；
* `git_clone_git_clone` &ndash; 將 `git clone git clone ...` 改為 `git clone ...`
* `git_clone_missing` &ndash; 當 URL 看起來像 git repo 時，自動加上 `git clone`；
* `git_commit_add` &ndash; 若 commit 失敗因為沒 staged，提供 `git commit -a ...` 或 `git commit -p ...`；
* `git_commit_amend` &ndash; commit 之後提供 `git commit --amend`；
* `git_commit_reset` &ndash; commit 之後提供 `git reset HEAD~`；
* `git_diff_no_index` &ndash; 在對未追蹤檔案執行 `git diff` 時加上 `--no-index`；
* `git_diff_staged` &ndash; 在 `git diff` 出現非預期輸出時加上 `--staged`；
* `git_fix_stash` &ndash; 修正 `git stash` 指令（拼錯子指令或缺少 `save`）；
* `git_flag_after_filename` &ndash; 修正 `fatal: bad flag '...' after filename`；
* `git_help_aliased` &ndash; 修正 `git help <alias>` 指令，將 <alias> 替換為其別名指令；
* `git_hook_bypass` &ndash; 在 `git am`、`git commit` 或 `git push` 前加上 `--no-verify`；
* `git_lfs_mistype` &ndash; 修正拼錯的 `git lfs <command>` 指令；
* `git_main_master` &ndash; 修正 `main` 與 `master` 分支名稱錯誤；
* `git_merge` &ndash; 為分支名稱加上 remote；
* `git_merge_unrelated` &ndash; 需要時加上 `--allow-unrelated-histories`；
* `git_not_command` &ndash; 修正像 `git brnch` 這類錯誤的 git 指令；
* `git_pull` &ndash; 執行之前先設定 upstream；
* `git_pull_clone` &ndash; repo 不存在時改用 clone 取代 pull；
* `git_pull_uncommitted_changes` &ndash; pull 前先 stash 變更，pull 後再 pop 回來；
* `git_push` &ndash; 針對失敗的 `git push` 加上 `--set-upstream origin $branch`；
* `git_push_different_branch_names` &ndash; 當本地與遠端分支名稱不一致時修正 push；
* `git_push_pull` &ndash; push 被拒時自動執行 `git pull`；
* `git_push_without_commits` &ndash; 設定新專案時若只做 `git add .`，自動建立初始 commit；
* `git_rebase_no_changes` &ndash; 當沒有變更時，改為執行 `git rebase --skip` 取代 `git rebase --continue`；
* `git_remote_delete` &ndash; 將 `git remote delete remote_name` 改為 `git remote remove remote_name`；
* `git_rm_local_modifications` &ndash; 嘗試移除本地變更檔時自動加上 `-f` 或 `--cached`；
* `git_rm_recursive` &ndash; 嘗試移除資料夾時自動加上 `-r`；
* `git_rm_staged` &ndash; 嘗試移除已 staged 變更檔時加上 `-f` 或 `--cached`
* `git_rebase_merge_dir` &ndash; 執行 rebase 進行中時，提供 `git rebase (--continue | --abort | --skip)` 或移除 `.git/rebase-merge` 目錄選項；
* `git_remote_seturl_add` &ndash; 在不存在的 remote 上執行 `git remote set_url` 時自動執行 `git remote add`；
* `git_stash` &ndash; rebase 或切換分支前自動 stash 本地變更；
* `git_stash_pop` &ndash; pop stash 前先加回本地變更，然後重置；
* `git_tag_force` &ndash; 標籤已存在時，對 `git tag <tagname>` 加上 `--force`；
* `git_two_dashes` &ndash; 修正像 `git commit -amend` 或 `git rebase -continue` 缺少的 dash；
* `go_run` &ndash; 編譯/執行 Go 程式時自動補上 `.go` 副檔名；
* `go_unknown_command` &ndash; 修正像 `go bulid` 這類拼錯的 go 指令；
* `gradle_no_task` &ndash; 修正找不到或模糊的 gradle 任務；
* `gradle_wrapper` &ndash; 將 `gradle` 替換為 `./gradlew`；
* `grep_arguments_order` &ndash; 修正像 `grep -lir . test` 這類 grep 參數順序；
* `grep_recursive` &ndash; 嘗試對資料夾執行 grep 時加上 `-r`；
* `grunt_task_not_found` &ndash; 修正拼錯的 grunt 指令；
* `gulp_not_task` &ndash; 修正拼錯的 gulp 任務；
* `has_exists_script` &ndash; script/binary 存在時自動加上 `./`；
* `heroku_multiple_apps` &ndash; 為像 `heroku pg` 這類指令加上 `--app <app>`；
* `heroku_not_command` &ndash; 修正像 `heroku log` 這類錯誤的 heroku 指令；
* `history` &ndash; 嘗試用歷史紀錄中最相似的指令取代；
* `hostscli` &ndash; 嘗試修正 `hostscli` 用法；
* `ifconfig_device_not_found` &ndash; 修正像 `wlan0` 改為 `wlp2s0` 這類錯誤的裝置名稱；
* `java` &ndash; 執行 Java 程式時移除 `.java` 副檔名；
* `javac` &ndash; 編譯 Java 檔案時自動補上缺少的 `.java`；
* `lein_not_task` &ndash; 修正像 `lein rpl` 這類錯誤的 lein 任務；
* `long_form_help` &ndash; 當不支援短參數時，將 `-h` 改為 `--help`
* `ln_no_hard_link` &ndash; 捕捉對目錄建立硬連結，建議使用符號連結；
* `ln_s_order` &ndash; 修正 `ln -s` 參數順序；
* `ls_all` &ndash; 當 ls 輸出為空時加上 `-A`；
* `ls_lah` &ndash; 為 ls 加上 `-lah`；
* `man` &ndash; 更換手冊 section；
* `man_no_space` &ndash; 修正如 `mandiff` 這類沒有空白的 man 指令；
* `mercurial` &ndash; 修正錯誤的 `hg` 指令；
* `missing_space_before_subcommand` &ndash; 修正像 `npminstall` 這類缺少空白的指令；
* `mkdir_p` &ndash; 當父目錄不存在時，自動加上 `-p` 建立；
* `mvn_no_command` &ndash; 對 `mvn` 自動加上 `clean package`；
* `mvn_unknown_lifecycle_phase` &ndash; 修正 mvn 拼錯的生命週期階段；
* `npm_missing_script` &ndash; 修正 `npm run-script <script>` 裡的自訂 script 名稱；
* `npm_run_script` &ndash; 為自訂 npm script 補上缺少的 `run-script`；
* `npm_wrong_command` &ndash; 修正像 `npm urgrade` 這類錯誤的 npm 指令；
* `no_command` &ndash; 修正像 `vom/vim` 這類錯誤的終端指令；
* `no_such_file` &ndash; 用 `mv`、`cp` 指令時自動建立缺少的目錄；
* `omnienv_no_such_command` &ndash; 修正 `goenv`、`nodenv`、`pyenv`、`rbenv` 的錯誤指令（如：`pyenv isntall` 或 `goenv list`）；
* `open` &ndash; 將傳給 `open` 的位址自動補上 `http://` 或建立新檔案/目錄後傳給 `open`；
* `pip_install` &ndash; 修正 `pip install` 權限問題，必要時加上 `--user` 或 `sudo`；
* `pip_unknown_command` &ndash; 修正像 `pip instatl/pip install` 這類拼錯的 pip 指令；
* `php_s` &ndash; 嘗試執行本機 php server 時，將 `-s` 替換為 `-S`；
* `port_already_in_use` &ndash; 關閉佔用埠口的程式；
* `prove_recursively` &ndash; 指定目錄時加上 `-r`；
* `python_command` &ndash; 嘗試執行非執行檔或沒加 `./` 的 python script 時自動補上 python；
* `python_execute` &ndash; 執行 Python 檔案時自動補上缺少的 `.py`；
* `python_module_error` &ndash; 嘗試 `pip install` 缺少模組修正 ModuleNotFoundError；
* `quotation_marks` &ndash; 修正參數內 `'` 和 `"` 使用不均；
* `path_from_history` &ndash; 當找不到路徑時，用歷史紀錄中相似的絕對路徑取代；
* `rails_migrations_pending` &ndash; 執行未完成的 migration；
* `react_native_command_unrecognized` &ndash; 修正未識別的 `react-native` 指令；
* `remove_shell_prompt_literal` &ndash; 移除複製文件指令時常見的 shell prompt `$`；
* `remove_trailing_cedilla` &ndash; 移除尾端的 cedilla `ç`，歐洲鍵盤常見錯字；
* `rm_dir` &ndash; 嘗試移除資料夾時自動加上 `-rf`；
* `scm_correction` &ndash; 修正錯誤的 scm，如將 `hg log` 改為 `git log`；
* `sed_unterminated_s` &ndash; 為 `sed` 的 `s` 指令補上缺少的 `/`；
* `sl_ls` &ndash; 將 `sl` 改為 `ls`；
* `ssh_known_hosts` &ndash; 發出警告時，從 `known_hosts` 移除主機；
* `sudo` &ndash; 權限不足時，自動在指令前加上 sudo；
* `sudo_command_from_user_path` &ndash; 用 sudo 執行用戶 `$PATH` 中的指令；
* `switch_lang` &ndash; 將指令從本地鍵盤布局轉換成英文；
* `systemctl` &ndash; 正確排序複雜的 systemctl 參數；
* `terraform_init.py` &ndash; 在 plan 或 apply 前自動執行 `terraform init`；
* `terraform_no_command.py` &ndash; 修正未識別的 terraform 指令；
* `test.py` &ndash; 用 `pytest` 取代 `test.py` 執行；
* `touch` &ndash; 在 "touch" 前自動建立缺少的目錄；
* `tsuru_login` &ndash; 未驗證或 session 過期時自動執行 `tsuru login`；
* `tsuru_not_command` &ndash; 修正像 `tsuru shell` 這類錯誤的 tsuru 指令；
* `tmux` &ndash; 修正 tmux 指令；
* `unknown_command` &ndash; 修正 hadoop hdfs 風格 "unknown command"，例如在 `hdfs dfs ls` 補上缺少的 '-'；
* `unsudo` &ndash; 若程式拒絕以超級用戶執行，則移除前一指令的 sudo。
* `vagrant_up` &ndash; 啟動 vagrant 實例；
* `whois` &ndash; 修正 whois 指令；
* `workon_doesnt_exists` &ndash; 修正 `virtualenvwrapper` 環境名稱，或建議建立新環境。
* `wrong_hyphen_before_subcommand` &ndash; 移除錯誤的連字符（`apt-install` -> `apt install`、`git-log` -> `git log` 等）
* `yarn_alias` &ndash; 修正如 `yarn ls` 這類 yarn 別名指令；
* `yarn_command_not_found` &ndash; 修正拼錯的 yarn 指令；
* `yarn_command_replaced` &ndash; 修正被取代的 yarn 指令；
* `yarn_help` &ndash; 讓查閱 yarn 文件更方便；

##### [回目錄](#contents)

以下規則僅在特定平台預設啟用：

* `apt_get` &ndash; 若應用程式未安裝則用 apt 安裝（需 `python-commandnotfound` / `python3-commandnotfound`）；
* `apt_get_search` &ndash; 將用 `apt-get` 搜尋替換為用 `apt-cache` 搜尋；
* `apt_invalid_operation` &ndash; 修正無效的 `apt` 和 `apt-get` 呼叫，如 `apt-get isntall vim`；
* `apt_list_upgradable` &ndash; 幫助你在 `apt update` 後執行 `apt list --upgradable`；
* `apt_upgrade` &ndash; 幫助你在 `apt list --upgradable` 後執行 `apt upgrade`；
* `brew_cask_dependency` &ndash; 安裝 cask 依賴；
* `brew_install` &ndash; 修正 `brew install` 的 formula 名稱；
* `brew_reinstall` &ndash; 將 `brew install <formula>` 轉為 `brew reinstall <formula>`；
* `brew_link` &ndash; link 失敗時加上 `--overwrite --dry-run`；
* `brew_uninstall` &ndash; 如有多個版本已安裝，解除安裝時加上 `--force`；
* `brew_unknown_command` &ndash; 修正像 `brew docto/brew doctor` 這類錯誤的 brew 指令；
* `brew_update_formula` &ndash; 將 `brew update <formula>` 轉為 `brew upgrade <formula>`；
* `dnf_no_such_command` &ndash; 修正拼錯的 DNF 指令；
* `nixos_cmd_not_found` &ndash; 在 NixOS 上安裝應用程式；
* `pacman` &ndash; 若應用程式未安裝則用 `pacman` 安裝（若有 `yay`、`pikaur` 或 `yaourt` 則優先使用）；
* `pacman_invalid_option` &ndash; 將 pacman 小寫選項改為大寫。
* `pacman_not_found` &ndash; 用 `pacman`、`yay`、`pikaur` 或 `yaourt` 修正套件名稱。
* `yum_invalid_operation` &ndash; 修正無效的 yum 呼叫，如 `yum isntall vim`；

以下指令已隨 *The Fuck* 一起提供，但預設未啟用：

* `git_push_force` &ndash; 為 `git push` 加上 `--force-with-lease`（可能與 `git_push_pull` 衝突）；
* `rm_root` &ndash; 對 `rm -rf /` 指令加上 `--no-preserve-root`。

##### [回目錄](#contents)

## 自訂規則

若要新增自訂規則，請在 `~/.config/thefuck/rules` 新增名為 `your-rule-name.py` 的檔案。規則檔必須包含兩個函式：

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

另外，規則可選擇性包含下列函式：

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
規則也可包含可選變數 `enabled_by_default`、`requires_output` 和 `priority`。

`Command` 有三個屬性：`script`、`output` 和 `script_parts`。
你的規則不應改變 `Command`。

**3.0 版起 Rules api 有變更：** 若要存取規則設定，請用
 `from thefuck.conf import settings` 匯入

`settings` 是一個由 `~/.config/thefuck/settings.py` 及環境變數組成的特殊物件（[見下文](#settings)）。

一個簡單的 sudo 規則範例：

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# 可選：
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # 數值越小優先度越高，預設 1000

requires_output = True
```

[更多規則範例](https://github.com/nvbn/thefuck/tree/master/thefuck/rules)，
[規則輔助函式](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py)，
[應用/作業系統專屬輔助程式](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/)。

##### [回目錄](#contents)

## 設定

多個 *The Fuck* 參數可在 `$XDG_CONFIG_HOME/thefuck/settings.py`
（`$XDG_CONFIG_HOME` 預設為 `~/.config`）檔案中修改：

* `rules` &ndash; 啟用規則列表，預設為 `thefuck.const.DEFAULT_RULES`；
* `exclude_rules` &ndash; 停用規則列表，預設為 `[]`；
* `require_confirmation` &ndash; 執行新指令前是否需確認，預設為 `True`；
* `wait_command` &ndash; 取得上個指令輸出的最長等待秒數；
* `no_colors` &ndash; 關閉彩色輸出；
* `priority` &ndash; 規則優先權 dict，priority 越小的規則會優先比對；
* `debug` &ndash; 啟用 debug 輸出，預設為 `False`；
* `history_limit` &ndash; 掃描歷史指令的數量上限，如 `2000`；
* `alter_history` &ndash; 是否將修正後的指令加入歷史紀錄，預設為 `True`；
* `wait_slow_command` &ndash; 若在 `slow_commands` 列表時，取得指令輸出的最長等待秒數；
* `slow_commands` &ndash; 慢速指令列表；
* `num_close_matches` &ndash; 建議相似指令的數量上限，預設為 `3`。
* `excluded_search_path_prefixes` &ndash; 搜尋指令時需忽略的路徑前綴，預設為 `[]`。

`settings.py` 範例：

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

或透過環境變數：

* `THEFUCK_RULES` &ndash; 啟用規則列表，如 `DEFAULT_RULES:rm_root` 或 `sudo:no_command`；
* `THEFUCK_EXCLUDE_RULES` &ndash; 停用規則列表，如 `git_pull:git_push`；
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; 執行新指令前是否需確認，`true/false`；
* `THEFUCK_WAIT_COMMAND` &ndash; 取得上個指令輸出的最長等待秒數；
* `THEFUCK_NO_COLORS` &ndash; 關閉彩色輸出，`true/false`；
* `THEFUCK_PRIORITY` &ndash; 規則優先權，如 `no_command=9999:apt_get=100`，
priority 越小的規則會優先比對；
* `THEFUCK_DEBUG` &ndash; 啟用 debug 輸出，`true/false`；
* `THEFUCK_HISTORY_LIMIT` &ndash; 掃描歷史指令的數量上限，如 `2000`；
* `THEFUCK_ALTER_HISTORY` &ndash; 是否將修正後的指令加入歷史紀錄 `true/false`；
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; 若在 `slow_commands` 列表時，取得指令輸出的最長等待秒數；
* `THEFUCK_SLOW_COMMANDS` &ndash; 慢速指令列表，如 `lein:gradle`；
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; 建議相似指令的數量上限，如 `5`。
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; 搜尋指令時需忽略的路徑前綴，預設為 `[]`。

例如：

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

##### [回目錄](#contents)

## 含規則的第三方套件

如果你想建立一組特定但不公開的規則，並希望與其他人分享，可以建立一個名為 `thefuck_contrib_*` 的套件，結構如下：

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *第三方規則*
    __init__.py
    *第三方輔助工具*
  setup.py
```

*The Fuck* 會自動尋找 `rules` 模組內的規則。

##### [回目錄](#contents)

## 實驗性即時模式

*The Fuck* 的預設行為需要花時間重新執行上一個指令。
在即時模式下，*The Fuck* 透過用 [script](https://en.wikipedia.org/wiki/Script_(Unix)) 記錄輸出、再讀取 log 來節省時間。

[![即時模式動畫][instant-mode-gif-link]][instant-mode-gif-link]

目前即時模式僅支援 Python 3 搭配 bash 或 zsh。zsh 也需關閉自動校正功能，thefuck 才能正常運作。

啟用即時模式，請在 `.bashrc`、`.bash_profile` 或 `.zshrc` 的 alias 初始化中加上 `--enable-experimental-instant-mode`。

例如：

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [回目錄](#contents)

## 開發

請參閱 [CONTRIBUTING.md](CONTRIBUTING.md)

## 授權 MIT
專案授權條款請見[這裡](LICENSE.md)。

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

##### [回目錄](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---