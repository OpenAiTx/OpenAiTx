# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* 是一个极为出色的应用，灵感来源于 [@liamosaur](https://twitter.com/liamosaur/)
的 [推文](https://twitter.com/liamosaur/status/506975850596536320)，
它可以修正之前控制台命令中的错误。

觉得 *The Fuck* 太慢？[试试实验性的极速模式！](#experimental-instant-mode)

[![示例 gif][examples-link]][examples-link]

更多示例：

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

如果你不担心盲目执行修正后的命令，可以禁用
`require_confirmation` [设置](#settings) 选项：

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

## 目录

1. [环境要求](#requirements)
2. [安装](#installation)
3. [升级](#updating)
4. [工作原理](#how-it-works)
5. [自定义规则](#creating-your-own-rules)
6. [设置](#settings)
7. [带有规则的第三方包](#third-party-packages-with-rules)
8. [实验性极速模式](#experimental-instant-mode)
9. [开发](#developing)
10. [许可协议](#license-mit)

## 环境要求

- python (3.5+)
- pip
- python-dev

##### [返回目录](#contents)

## 安装

在 macOS 或 Linux 上，你可以通过 [Homebrew][homebrew] 安装 *The Fuck*：

```bash
brew install thefuck
```

在 Ubuntu / Mint 上，使用以下命令安装 *The Fuck*：
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

在 FreeBSD 上，使用以下命令安装 *The Fuck*：
```bash
pkg install thefuck
```

在 ChromeOS 上，使用 [chromebrew](https://github.com/skycocker/chromebrew) 安装 *The Fuck*：
```bash
crew install thefuck
```

在 Arch 系统上，使用以下命令安装 *The Fuck*：
```
sudo pacman -S thefuck
```

在其他系统上，可以通过 `pip` 安装 *The Fuck*：

```bash
pip install thefuck
```

[或者，你也可以使用操作系统自带的包管理器（OS X、Ubuntu、Arch）。](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
建议你将以下命令添加到你的 `.bash_profile`、`.bashrc`、`.zshrc` 或其他启动脚本中：

```bash
eval $(thefuck --alias)
# 你可以自定义别名，比如用于周一：
eval $(thefuck --alias FUCK)
```

[或添加到你的 shell 配置（Bash、Zsh、Fish、Powershell、tcsh）。](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

更改只在新 shell 会话中生效。要立即生效，请执行 `source ~/.bashrc`（或者你的 shell 配置文件如 `.zshrc`）。

要在无需确认的情况下直接执行修正命令，使用 `--yeah` 选项（简写为 `-y`，若特别沮丧可用 `--hard`）：

```bash
fuck --yeah
```

要递归修正命令直到成功，使用 `-r` 选项：

```bash
fuck -r
```

##### [返回目录](#contents)

## 升级

```bash
pip3 install thefuck --upgrade
```

**注意：别名功能在 *The Fuck* v1.34 版本中有变更**

## 卸载

要移除 *The Fuck*，请逆向操作安装步骤：
- 删除或注释掉 shell 配置文件中的 *thefuck* 别名行（Bash、Zsh、Fish、Powershell、tcsh 等）
- 使用你的包管理器（brew、pip3、pkg、crew、pip）卸载程序

## 工作原理

*The Fuck* 会尝试将上一个命令与规则进行匹配。如果匹配成功，则使用匹配的规则生成新的命令并执行。默认启用以下规则：

* `adb_unknown_command` &ndash; 修正拼写错误的 adb 命令，如 `adb logcta`;
* `ag_literal` &ndash; 按建议为 `ag` 命令添加 `-Q`;
* `aws_cli` &ndash; 修正拼写错误的 aws 命令，如 `aws dynamdb scan`;
* `az_cli` &ndash; 修正拼写错误的 az 命令，如 `az providers`;
* `cargo` &ndash; 运行 `cargo build` 替代 `cargo`;
* `cargo_no_command` &ndash; 修正错误命令，如 `cargo buid`;
* `cat_dir` &ndash; 当你试图 `cat` 目录时，将其替换为 `ls`;
* `cd_correction` &ndash; 拼写检查并修正失败的 cd 命令;
* `cd_cs` &ndash; 将 `cs` 改为 `cd`;
* `cd_mkdir` &ndash; 在 cd 进入之前创建目录;
* `cd_parent` &ndash; 将 `cd..` 改为 `cd ..`;
* `chmod_x` &ndash; 添加可执行权限;
* `choco_install` &ndash; 为 chocolatey 包附加常见后缀;
* `composer_not_command` &ndash; 修正 composer 命令名称;
* `conda_mistype` &ndash; 修正 conda 命令;
* `cp_create_destination` &ndash; 当你试图 `cp` 或 `mv` 到不存在的目录时创建新目录;
* `cp_omitting_directory` &ndash; 当你复制目录时为 `cp` 添加 `-a`;
* `cpp11` &ndash; 为 `g++` 或 `clang++` 添加缺失的 `-std=c++11`;
* `dirty_untar` &ndash; 修正 `tar x` 命令导致的解压到当前目录;
* `dirty_unzip` &ndash; 修正 `unzip` 命令导致的解压到当前目录;
* `django_south_ghost` &ndash; 针对 ghost django south migration 失败时添加 `--delete-ghost-migrations`;
* `django_south_merge` &ndash; 针对不一致的 django south migration 添加 `--merge`;
* `docker_login` &ndash; 执行 `docker login` 并重复上一个命令;
* `docker_not_command` &ndash; 修正错误的 docker 命令，如 `docker tags`;
* `docker_image_being_used_by_container` &dash; 在移除镜像前移除正在使用该镜像的容器;
* `dry` &ndash; 修正如 `git git push` 这样的重复命令;
* `fab_command_not_found` &ndash; 修正拼写错误的 fabric 命令;
* `fix_alt_space` &ndash; 将 Alt+Space 替换为空格字符;
* `fix_file` &ndash; 用你的 `$EDITOR` 打开出错的文件;
* `gem_unknown_command` &ndash; 修正错误的 `gem` 命令;
* `git_add` &ndash; 修正 *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` &ndash; 当路径被 .gitignore 时，为 `git add <pathspec>...` 添加 `--force`;
* `git_bisect_usage` &ndash; 在二分调试时修正 `git bisect strt`、`git bisect goood`、`git bisect rset` 等命令;
* `git_branch_delete` &ndash; 将 `git branch -d` 改为 `git branch -D`;
* `git_branch_delete_checked_out` &ndash; 当尝试删除已签出的分支时，将 `git branch -d` 改为 `git checkout master && git branch -D`;
* `git_branch_exists` &ndash; 当创建已存在分支时，提供 `git branch -d foo`、`git branch -D foo` 或 `git checkout foo`;
* `git_branch_list` &ndash; 捕获 `git branch list` 替代 `git branch` 并移除已创建分支;
* `git_branch_0flag` &ndash; 修正如 `git branch 0v`、`git branch 0r` 等命令并移除已创建分支;
* `git_checkout` &ndash; 修正分支名或创建新分支;
* `git_clone_git_clone` &ndash; 将 `git clone git clone ...` 替换为 `git clone ...`
* `git_clone_missing` &ndash; 为像 git 仓库链接的 URL 添加 `git clone`；
* `git_commit_add` &ndash; 在上次提交失败（无暂存内容）时，提供 `git commit -a ...` 或 `git commit -p ...`;
* `git_commit_amend` &ndash; 在上次提交后，提供 `git commit --amend`;
* `git_commit_reset` &ndash; 在上次提交后，提供 `git reset HEAD~`;
* `git_diff_no_index` &ndash; 针对未跟踪文件的上一条 `git diff` 添加 `--no-index`;
* `git_diff_staged` &ndash; 针对输出异常的上一条 `git diff` 添加 `--staged`;
* `git_fix_stash` &ndash; 修正 `git stash` 命令（子命令拼写错误或缺少 `save`）;
* `git_flag_after_filename` &ndash; 修正 `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; 修正 `git help <alias>` 命令，将 <alias> 替换为别名对应命令;
* `git_hook_bypass` &ndash; 在 `git am`、`git commit` 或 `git push` 命令前添加 `--no-verify` 标志;
* `git_lfs_mistype` &ndash; 修正拼写错误的 `git lfs <command>` 命令;
* `git_main_master` &ndash; 修正 `main` 和 `master` 分支名混淆问题;
* `git_merge` &ndash; 为分支名添加远程;
* `git_merge_unrelated` &ndash; 在需要时添加 `--allow-unrelated-histories`
* `git_not_command` &ndash; 修正错误的 git 命令，如 `git brnch`;
* `git_pull` &ndash; 在执行上一条 `git pull` 前设置 upstream;
* `git_pull_clone` &ndash; 当仓库不存在时，使用 clone 替代 pull;
* `git_pull_uncommitted_changes` &ndash; 拉取前暂存更改，拉取后恢复;
* `git_push` &ndash; 为失败的 `git push` 添加 `--set-upstream origin $branch`;
* `git_push_different_branch_names` &ndash; 当本地分支名与远程分支名不一致时修正 push;
* `git_push_pull` &ndash; 当 push 被拒绝时运行 `git pull`;
* `git_push_without_commits` &ndash; 在新建项目时，如果你只执行了 `git add .` 却忘记提交，创建初始提交;
* `git_rebase_no_changes` &ndash; 当无更改时，替代 `git rebase --continue` 为 `git rebase --skip`;
* `git_remote_delete` &ndash; 将 `git remote delete remote_name` 替换为 `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; 当你试图删除本地修改文件时，添加 `-f` 或 `--cached`;
* `git_rm_recursive` &ndash; 当你试图删除目录时，添加 `-r`;
* `git_rm_staged` &ndash; 当你试图删除带暂存更改的文件时，添加 `-f` 或 `--cached`
* `git_rebase_merge_dir` &ndash; 当正在 rebase 时，提供 `git rebase (--continue | --abort | --skip)` 或移除 `.git/rebase-merge` 目录;
* `git_remote_seturl_add` &ndash; 当 `git remote set_url` 针对不存在的远程时，运行 `git remote add`;
* `git_stash` &ndash; rebase 或切换分支前暂存本地更改;
* `git_stash_pop` &ndash; 在 pop stash 前暂存本地更改，然后重置;
* `git_tag_force` &ndash; 当标签已存在时，为 `git tag <tagname>` 添加 `--force`;
* `git_two_dashes` &ndash; 为如 `git commit -amend` 或 `git rebase -continue` 的命令添加缺失的连字符;
* `go_run` &ndash; 在编译/运行 Go 程序时自动补充 `.go` 扩展名;
* `go_unknown_command` &ndash; 修正错误的 go 命令，如 `go bulid`;
* `gradle_no_task` &ndash; 修正未找到或歧义的 gradle 任务;
* `gradle_wrapper` &ndash; 将 `gradle` 替换为 `./gradlew`;
* `grep_arguments_order` &ndash; 修正 `grep` 参数顺序，如 `grep -lir . test`;
* `grep_recursive` &ndash; 当你试图 `grep` 目录时添加 `-r`;
* `grunt_task_not_found` &ndash; 修正拼写错误的 grunt 命令;
* `gulp_not_task` &ndash; 修正拼写错误的 gulp 任务;
* `has_exists_script` &ndash; 当脚本/二进制存在时前置 `./`;
* `heroku_multiple_apps` &ndash; 为 `heroku` 命令（如 `heroku pg`）添加 `--app <app>`;
* `heroku_not_command` &ndash; 修正错误的 heroku 命令，如 `heroku log`;
* `history` &ndash; 尝试用历史中最相似的命令替换当前命令;
* `hostscli` &ndash; 尝试修正 hostscli 用法;
* `ifconfig_device_not_found` &ndash; 修正错误的设备名，如 `wlan0` 改为 `wlp2s0`;
* `java` &ndash; 运行 Java 程序时移除 `.java` 扩展名;
* `javac` &ndash; 编译 Java 文件时自动补充缺失的 `.java`;
* `lein_not_task` &ndash; 修正错误的 lein 任务，如 `lein rpl`;
* `long_form_help` &ndash; 当不支持短参数时将 `-h` 换为 `--help`
* `ln_no_hard_link` &ndash; 捕获目录硬链接创建，建议使用符号链接;
* `ln_s_order` &ndash; 修正 `ln -s` 参数顺序;
* `ls_all` &ndash; 当输出为空时为 `ls` 添加 `-A`;
* `ls_lah` &ndash; 为 `ls` 添加 `-lah`;
* `man` &ndash; 更改 man 手册章节;
* `man_no_space` &ndash; 修正无空格的 man 命令，如 `mandiff`;
* `mercurial` &ndash; 修正错误的 hg 命令;
* `missing_space_before_subcommand` &ndash; 修正缺少空格的命令，如 `npminstall`;
* `mkdir_p` &ndash; 当你创建没有父级的目录时添加 `-p`;
* `mvn_no_command` &ndash; 为 `mvn` 添加 `clean package`;
* `mvn_unknown_lifecycle_phase` &ndash; 修正 mvn 生命周期阶段拼写错误;
* `npm_missing_script` &ndash; 修正 `npm run-script <script>` 中的自定义脚本名;
* `npm_run_script` &ndash; 为自定义 `npm` 脚本补充缺失的 `run-script`;
* `npm_wrong_command` &ndash; 修正错误的 npm 命令，如 `npm urgrade`;
* `no_command` &ndash; 修正错误的控制台命令，如 `vom/vim`;
* `no_such_file` &ndash; 用 `mv` 和 `cp` 命令创建缺失的目录;
* `omnienv_no_such_command` &ndash; 修正 `goenv`、`nodenv`、`pyenv`、`rbenv` 的错误命令（如：`pyenv isntall` 或 `goenv list`）;
* `open` &ndash; 为传递给 `open` 的地址补全 `http://`，或创建新文件/目录并传递给 `open`;
* `pip_install` &ndash; 通过添加 `--user` 或前置 `sudo` 修正 `pip install` 权限问题;
* `pip_unknown_command` &ndash; 修正错误的 pip 命令，如 `pip instatl/pip install`;
* `php_s` &ndash; 本地 php 服务运行时将 `-s` 替换为 `-S`;
* `port_already_in_use` &ndash; 杀死占用端口的进程;
* `prove_recursively` &ndash; 以目录参数调用时添加 `-r`;
* `python_command` &ndash; 当你运行不可执行/无 `./` 的 python 脚本时前置 `python`;
* `python_execute` &ndash; 执行 Python 文件时自动补充缺失的 `.py`;
* `python_module_error` &ndash; 通过尝试 `pip install` 修正 ModuleNotFoundError;
* `quotation_marks` &ndash; 修正 `'` 和 `"` 不匹配的情况;
* `path_from_history` &ndash; 用历史中相似的绝对路径替换未找到的路径;
* `rails_migrations_pending` &ndash; 运行未完成的迁移;
* `react_native_command_unrecognized` &ndash; 修正无法识别的 `react-native` 命令;
* `remove_shell_prompt_literal` &ndash; 移除命令前的 shell 提示符 `$`，常见于文档复制命令时;
* `remove_trailing_cedilla` &ndash; 移除结尾的 cedilla `ç`，这是欧洲键盘布局常见的拼写错误;
* `rm_dir` &ndash; 当你试图删除目录时添加 `-rf`;
* `scm_correction` &ndash; 修正错误的 scm，如将 `hg log` 替换为 `git log`;
* `sed_unterminated_s` &ndash; 为 `sed` 的 `s` 命令补全缺失的 `/`;
* `sl_ls` &ndash; 将 `sl` 改为 `ls`;
* `ssh_known_hosts` &ndash; 在警告时从 `known_hosts` 移除主机;
* `sudo` &ndash; 当因权限失败时为上一个命令前置 `sudo`;
* `sudo_command_from_user_path` &ndash; 用 `sudo` 运行用户 `$PATH` 下的命令;
* `switch_lang` &ndash; 将命令从本地布局切换为英文;
* `systemctl` &ndash; 正确排序混淆的 `systemctl` 参数;
* `terraform_init.py` &ndash; 在 plan 或 apply 前运行 `terraform init`;
* `terraform_no_command.py` &ndash; 修正无法识别的 terraform 命令;
* `test.py` &ndash; 用 `pytest` 替代 `test.py`;
* `touch` &ndash; 在 "touch" 之前创建缺失的目录;
* `tsuru_login` &ndash; 如果未认证或会话过期则运行 `tsuru login`;
* `tsuru_not_command` &ndash; 修正错误的 tsuru 命令，如 `tsuru shell`;
* `tmux` &ndash; 修正 tmux 命令;
* `unknown_command` &ndash; 修正 hadoop hdfs 类 "unknown command"，如在 `hdfs dfs ls` 上添加缺失的 `-`;
* `unsudo` &ndash; 如果进程拒绝以超级用户权限运行，则移除上一个命令的 `sudo`;
* `vagrant_up` &ndash; 启动 vagrant 实例;
* `whois` &ndash; 修正 whois 命令;
* `workon_doesnt_exists` &ndash; 修正 `virtualenvwrapper` 环境名或建议新建;
* `wrong_hyphen_before_subcommand` &ndash; 移除错误位置的连字符（如 `apt-install` -> `apt install`，`git-log` -> `git log` 等）
* `yarn_alias` &ndash; 修正 yarn 别名命令，如 `yarn ls`;
* `yarn_command_not_found` &ndash; 修正拼写错误的 yarn 命令;
* `yarn_command_replaced` &ndash; 修正被替换的 yarn 命令;
* `yarn_help` &ndash; 更便捷地打开 yarn 文档;

##### [返回目录](#contents)

以下规则仅在特定平台默认启用：

* `apt_get` &ndash; 若未安装则通过 apt 安装应用（需 `python-commandnotfound` / `python3-commandnotfound`）;
* `apt_get_search` &ndash; 将试图用 `apt-get` 搜索的操作改为用 `apt-cache` 搜索;
* `apt_invalid_operation` &ndash; 修正无效的 apt 和 apt-get 调用，如 `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; 在 `apt update` 后帮助你运行 `apt list --upgradable`;
* `apt_upgrade` &ndash; 在 `apt list --upgradable` 后帮助你运行 `apt upgrade`;
* `brew_cask_dependency` &ndash; 安装 cask 依赖项;
* `brew_install` &ndash; 修正 `brew install` 的 formula 名称;
* `brew_reinstall` &ndash; 将 `brew install <formula>` 改为 `brew reinstall <formula>`;
* `brew_link` &ndash; 若链接失败则添加 `--overwrite --dry-run`;
* `brew_uninstall` &ndash; 若安装了多个版本，为 `brew uninstall` 添加 `--force`;
* `brew_unknown_command` &ndash; 修正错误的 brew 命令，如 `brew docto/brew doctor`;
* `brew_update_formula` &ndash; 将 `brew update <formula>` 改为 `brew upgrade <formula>`;
* `dnf_no_such_command` &ndash; 修正拼写错误的 DNF 命令;
* `nixos_cmd_not_found` &ndash; 在 NixOS 上安装应用;
* `pacman` &ndash; 若未安装则用 `pacman` 安装应用（如有 `yay`、`pikaur` 或 `yaourt` 则优先使用）;
* `pacman_invalid_option` &ndash; 将小写 pacman 选项替换为大写。
* `pacman_not_found` &ndash; 用 `pacman`、`yay`、`pikaur` 或 `yaourt` 修正包名。
* `yum_invalid_operation` &ndash; 修正无效的 yum 调用，如 `yum isntall vim`;

以下命令随 *The Fuck* 一起提供，但默认未启用：

* `git_push_force` &ndash; 为 `git push` 添加 `--force-with-lease`（可能与 `git_push_pull` 冲突）;
* `rm_root` &ndash; 为 `rm -rf /` 命令添加 `--no-preserve-root`。

##### [返回目录](#contents)

## 自定义规则

要添加自定义规则，在 `~/.config/thefuck/rules` 下新建名为 `your-rule-name.py` 的文件。规则文件需包含两个函数：

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

此外，规则可以包含可选函数：

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
规则还可包含可选变量 `enabled_by_default`、`requires_output` 和 `priority`。

`Command` 有三个属性：`script`、`output` 和 `script_parts`。
你的规则不应修改 `Command`。

**3.0 版本规则 API 有变更：** 若需访问规则设置，请通过
 `from thefuck.conf import settings` 导入

`settings` 是一个特殊对象，由 `~/.config/thefuck/settings.py` 和环境变量值（[详情见下文](#settings)）组合生成。

以下是一个用 `sudo` 运行脚本的简单规则示例：

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# 可选：
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # 数值越小优先级越高，默认 1000

requires_output = True
```

[更多规则示例](https://github.com/nvbn/thefuck/tree/master/thefuck/rules)，
[规则工具函数](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py)，
[应用/操作系统特定辅助工具](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/)。

##### [返回目录](#contents)

## 设置

部分 *The Fuck* 参数可在 `$XDG_CONFIG_HOME/thefuck/settings.py` 文件中修改
（`$XDG_CONFIG_HOME` 默认为 `~/.config`）：

* `rules` &ndash; 启用规则列表，默认 `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; 禁用规则列表，默认 `[]`;
* `require_confirmation` &ndash; 是否在运行新命令前要求确认，默认 `True`;
* `wait_command` &ndash; 获取上一个命令输出的最大等待秒数；
* `no_colors` &ndash; 是否禁用彩色输出；
* `priority` &ndash; 规则优先级字典，优先级数值小的规则优先匹配；
* `debug` &ndash; 是否启用调试输出，默认 `False`;
* `history_limit` &ndash; 扫描历史命令数量，如 `2000`;
* `alter_history` &ndash; 是否将修正命令推送到历史，默认 `True`;
* `wait_slow_command` &ndash; 如命令在 `slow_commands` 列表中，获取上一个命令输出的最大等待秒数；
* `slow_commands` &ndash; 慢命令列表；
* `num_close_matches` &ndash; 建议的相似命令最大数量，默认 `3`。
* `excluded_search_path_prefixes` &ndash; 搜索命令时忽略的路径前缀，默认 `[]`。

`settings.py` 示例：

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

也可通过环境变量设置：

* `THEFUCK_RULES` &ndash; 启用规则列表，如 `DEFAULT_RULES:rm_root` 或 `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; 禁用规则列表，如 `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; 是否在运行新命令前要求确认，`true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; 获取上一个命令输出的最大等待秒数；
* `THEFUCK_NO_COLORS` &ndash; 是否禁用彩色输出，`true/false`;
* `THEFUCK_PRIORITY` &ndash; 规则优先级，如 `no_command=9999:apt_get=100`，优先级数值小的规则优先匹配；
* `THEFUCK_DEBUG` &ndash; 是否启用调试输出，`true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; 扫描历史命令数量，如 `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; 是否将修正命令推送到历史，`true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; 如命令在 `slow_commands` 列表中，获取上一个命令输出的最大等待秒数；
* `THEFUCK_SLOW_COMMANDS` &ndash; 慢命令列表，如 `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; 建议的相似命令最大数量，如 `5`。
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; 搜索命令时忽略的路径前缀，默认 `[]`。

示例：

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

##### [返回目录](#contents)

## 带有规则的第三方包

如果你想制作一套专用的非公开规则并与他人分享，可创建名为 `thefuck_contrib_*` 的包，
其结构如下：

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *第三方规则*
    __init__.py
    *第三方工具*
  setup.py
```

*The Fuck* 会自动查找 `rules` 模块下的规则。

##### [返回目录](#contents)

## 实验性极速模式

*The Fuck* 默认需要时间重新运行上一个命令。
在极速模式下，*The Fuck* 通过用 [script](https://en.wikipedia.org/wiki/Script_(Unix)) 记录输出来节省时间，然后读取日志。

[![极速模式 gif][instant-mode-gif-link]][instant-mode-gif-link]

目前，极速模式仅支持 Python 3 的 bash 或 zsh。zsh 的自动纠错功能需关闭，thefuck 才能正常工作。

要启用极速模式，请在 `.bashrc`、`.bash_profile` 或 `.zshrc` 的别名初始化中添加 `--enable-experimental-instant-mode`。

例如：

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [返回目录](#contents)

## 开发

参见 [CONTRIBUTING.md](CONTRIBUTING.md)

## 许可协议 MIT
项目许可协议见 [此处](LICENSE.md)。

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

##### [返回目录](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---