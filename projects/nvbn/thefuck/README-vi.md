# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* là một ứng dụng tuyệt vời, lấy cảm hứng từ một [tweet của @liamosaur](https://twitter.com/liamosaur/status/506975850596536320), giúp sửa các lỗi trong các lệnh console trước đó.

*The Fuck* chạy quá chậm? [Hãy thử chế độ instant mode thử nghiệm!](#experimental-instant-mode)

[![gif với các ví dụ][examples-link]][examples-link]

Một số ví dụ khác:

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

Nếu bạn không lo ngại về việc chạy các lệnh đã sửa mà không xác nhận, bạn có thể tắt tùy chọn `require_confirmation` trong [cài đặt](#settings):

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

## Mục lục

1. [Yêu cầu](#requirements)
2. [Cài đặt](#installation)
3. [Cập nhật](#updating)
4. [Cách hoạt động](#how-it-works)
5. [Tạo quy tắc riêng](#creating-your-own-rules)
6. [Cài đặt](#settings)
7. [Gói bên thứ ba với các quy tắc](#third-party-packages-with-rules)
8. [Chế độ instant thử nghiệm](#experimental-instant-mode)
9. [Phát triển](#developing)
10. [Giấy phép](#license-mit)

## Yêu cầu

- python (3.5+)
- pip
- python-dev

##### [Quay lại Mục lục](#contents)

## Cài đặt

Trên macOS hoặc Linux, bạn có thể cài đặt *The Fuck* thông qua [Homebrew][homebrew]:

```bash
brew install thefuck
```

Trên Ubuntu / Mint, cài đặt *The Fuck* với các lệnh sau:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

Trên FreeBSD, cài đặt *The Fuck* với các lệnh sau:
```bash
pkg install thefuck
```

Trên ChromeOS, cài đặt *The Fuck* bằng [chromebrew](https://github.com/skycocker/chromebrew) với lệnh sau:
```bash
crew install thefuck
```

Trên các hệ thống dựa trên Arch, cài đặt *The Fuck* với lệnh sau:
```
sudo pacman -S thefuck
```

Trên các hệ thống khác, cài đặt *The Fuck* bằng `pip`:

```bash
pip install thefuck
```

[Hoặc, bạn có thể sử dụng trình quản lý gói hệ điều hành (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Nên thêm lệnh này vào `.bash_profile`, `.bashrc`, `.zshrc` hoặc script khởi động khác của bạn:

```bash
eval $(thefuck --alias)
# Bạn có thể dùng bất kỳ alias nào bạn muốn, ví dụ cho ngày thứ Hai:
eval $(thefuck --alias FUCK)
```

[Hoặc trong file cấu hình shell của bạn (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Các thay đổi chỉ có hiệu lực trong phiên shell mới. Để áp dụng ngay lập tức, chạy `source ~/.bashrc` (hoặc file cấu hình shell của bạn như `.zshrc`).

Để chạy các lệnh đã sửa mà không cần xác nhận, sử dụng tùy chọn `--yeah` (hoặc chỉ `-y` cho ngắn gọn, hoặc `--hard` nếu bạn thực sự bực):

```bash
fuck --yeah
```

Để sửa lệnh đệ quy cho đến khi thành công, dùng tùy chọn `-r`:

```bash
fuck -r
```

##### [Quay lại Mục lục](#contents)

## Cập nhật

```bash
pip3 install thefuck --upgrade
```

**Lưu ý: Chức năng alias đã được thay đổi từ phiên bản v1.34 của *The Fuck***

## Gỡ cài đặt

Để gỡ bỏ *The Fuck*, hãy đảo ngược quá trình cài đặt:
- xóa hoặc comment dòng alias *thefuck* khỏi file cấu hình shell Bash, Zsh, Fish, Powershell, tcsh, ...
- dùng trình quản lý gói của bạn (brew, pip3, pkg, crew, pip) để gỡ cài đặt binary

## Cách hoạt động

*The Fuck* sẽ cố gắng khớp lệnh trước đó với một quy tắc. Nếu tìm thấy khớp, một lệnh mới sẽ được tạo ra từ quy tắc đó và thực thi. Các quy tắc sau được bật mặc định:

* `adb_unknown_command` – sửa các lệnh adb viết sai như `adb logcta`;
* `ag_literal` – thêm `-Q` cho `ag` khi được gợi ý;
* `aws_cli` – sửa các lệnh aws viết sai như `aws dynamdb scan`;
* `az_cli` – sửa các lệnh az viết sai như `az providers`;
* `cargo` – chạy `cargo build` thay vì `cargo`;
* `cargo_no_command` – sửa các lệnh sai như `cargo buid`;
* `cat_dir` – thay `cat` bằng `ls` khi bạn cố gắng `cat` một thư mục;
* `cd_correction` – kiểm tra chính tả và sửa lệnh cd thất bại;
* `cd_cs` – thay `cs` bằng `cd`;
* `cd_mkdir` – tạo thư mục trước khi cd vào đó;
* `cd_parent` – thay `cd..` bằng `cd ..`;
* `chmod_x` – thêm quyền thực thi;
* `choco_install` – thêm hậu tố phổ biến cho các gói chocolatey;
* `composer_not_command` – sửa tên lệnh composer;
* `conda_mistype` – sửa các lệnh conda sai;
* `cp_create_destination` – tạo thư mục mới khi bạn cố `cp` hoặc `mv` vào một thư mục chưa tồn tại;
* `cp_omitting_directory` – thêm `-a` khi bạn `cp` thư mục;
* `cpp11` – thêm thiếu `-std=c++11` cho `g++` hoặc `clang++`;
* `dirty_untar` – sửa lệnh `tar x` giải nén vào thư mục hiện tại;
* `dirty_unzip` – sửa lệnh `unzip` giải nén vào thư mục hiện tại;
* `django_south_ghost` – thêm `--delete-ghost-migrations` cho lỗi migration ghost của django south;
* `django_south_merge` – thêm `--merge` cho migration django south không nhất quán;
* `docker_login` – thực hiện `docker login` và lặp lại lệnh trước;
* `docker_not_command` – sửa các lệnh docker sai như `docker tags`;
* `docker_image_being_used_by_container` – xóa container đang sử dụng image trước khi xóa image;
* `dry` – sửa các lệnh lặp lại như `git git push`;
* `fab_command_not_found` – sửa các lệnh fabric viết sai;
* `fix_alt_space` – thay Alt+Space bằng ký tự Space thông thường;
* `fix_file` – mở file có lỗi trong `$EDITOR` của bạn;
* `gem_unknown_command` – sửa các lệnh `gem` sai;
* `git_add` – sửa lỗi *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` – thêm `--force` vào `git add <pathspec>...` khi các path bị .gitignore;
* `git_bisect_usage` – sửa các lệnh như `git bisect strt`, `git bisect goood`, `git bisect rset`,... khi đang bisect;
* `git_branch_delete` – đổi `git branch -d` thành `git branch -D`;
* `git_branch_delete_checked_out` – đổi `git branch -d` thành `git checkout master && git branch -D` khi cố xóa nhánh hiện tại;
* `git_branch_exists` – gợi ý `git branch -d foo`, `git branch -D foo` hoặc `git checkout foo` khi tạo nhánh đã tồn tại;
* `git_branch_list` – bắt lỗi `git branch list` thay vì `git branch` và xóa nhánh đã tạo;
* `git_branch_0flag` – sửa các lệnh như `git branch 0v` và `git branch 0r`, xóa nhánh đã tạo;
* `git_checkout` – sửa tên nhánh hoặc tạo nhánh mới;
* `git_clone_git_clone` – thay `git clone git clone ...` thành `git clone ...`
* `git_clone_missing` – thêm `git clone` vào URL có vẻ là repo git.
* `git_commit_add` – gợi ý `git commit -a ...` hoặc `git commit -p ...` sau commit trước nếu thất bại vì không có gì staged;
* `git_commit_amend` – gợi ý `git commit --amend` sau commit trước;
* `git_commit_reset` – gợi ý `git reset HEAD~` sau commit trước;
* `git_diff_no_index` – thêm `--no-index` vào `git diff` trước đó trên file chưa tracked;
* `git_diff_staged` – thêm `--staged` vào `git diff` trước đó với output không như mong đợi;
* `git_fix_stash` – sửa các lệnh `git stash` (sai subcommand hoặc thiếu `save`);
* `git_flag_after_filename` – sửa lỗi `fatal: bad flag '...' after filename`
* `git_help_aliased` – sửa lệnh `git help <alias>` bằng cách thay <alias> bằng lệnh thực tế;
* `git_hook_bypass` – thêm flag `--no-verify` trước các lệnh `git am`, `git commit` hoặc `git push`;
* `git_lfs_mistype` – sửa các lệnh `git lfs <command>` viết sai;
* `git_main_master` – sửa tên nhánh không đúng giữa `main` và `master`
* `git_merge` – thêm remote vào tên nhánh;
* `git_merge_unrelated` – thêm `--allow-unrelated-histories` khi cần thiết
* `git_not_command` – sửa các lệnh git sai như `git brnch`;
* `git_pull` – thiết lập upstream trước khi thực hiện `git pull` trước đó;
* `git_pull_clone` – clone thay vì pull khi repo không tồn tại;
* `git_pull_uncommitted_changes` – stash thay đổi trước khi pull và pop sau đó;
* `git_push` – thêm `--set-upstream origin $branch` vào lệnh `git push` thất bại trước đó;
* `git_push_different_branch_names` – sửa push khi tên nhánh local khác tên nhánh remote;
* `git_push_pull` – chạy `git pull` khi `push` bị từ chối;
* `git_push_without_commits` – tạo commit đầu tiên nếu bạn quên và chỉ `git add .` khi tạo project mới;
* `git_rebase_no_changes` – chạy `git rebase --skip` thay cho `git rebase --continue` khi không có thay đổi;
* `git_remote_delete` – thay `git remote delete remote_name` bằng `git remote remove remote_name`;
* `git_rm_local_modifications` – thêm `-f` hoặc `--cached` khi bạn cố xóa file đã chỉnh sửa local;
* `git_rm_recursive` – thêm `-r` khi bạn cố xóa thư mục;
* `git_rm_staged` – thêm `-f` hoặc `--cached` khi bạn cố xóa file có thay đổi đã staged
* `git_rebase_merge_dir` – gợi ý `git rebase (--continue | --abort | --skip)` hoặc xóa thư mục `.git/rebase-merge` khi đang rebase;
* `git_remote_seturl_add` – chạy `git remote add` khi `git remote set_url` cho remote không tồn tại;
* `git_stash` – stash thay đổi local trước khi rebase hoặc chuyển nhánh;
* `git_stash_pop` – thêm thay đổi local trước khi pop stash, sau đó reset;
* `git_tag_force` – thêm `--force` vào `git tag <tagname>` khi tag đã tồn tại;
* `git_two_dashes` – thêm dấu gạch ngang còn thiếu cho các lệnh như `git commit -amend` hoặc `git rebase -continue`;
* `go_run` – thêm phần mở rộng `.go` khi biên dịch/chạy chương trình Go;
* `go_unknown_command` – sửa các lệnh `go` sai, ví dụ `go bulid`;
* `gradle_no_task` – sửa task `gradle` không tìm thấy hoặc không rõ ràng;
* `gradle_wrapper` – thay `gradle` bằng `./gradlew`;
* `grep_arguments_order` – sửa thứ tự tham số `grep` cho các trường hợp như `grep -lir . test`;
* `grep_recursive` – thêm `-r` khi bạn cố grep thư mục;
* `grunt_task_not_found` – sửa các lệnh grunt viết sai;
* `gulp_not_task` – sửa các task gulp viết sai;
* `has_exists_script` – thêm `./` khi script/binary đã tồn tại;
* `heroku_multiple_apps` – thêm `--app <app>` vào lệnh `heroku` như `heroku pg`;
* `heroku_not_command` – sửa các lệnh heroku sai như `heroku log`;
* `history` – cố gắng thay thế lệnh bằng lệnh tương tự nhất từ history;
* `hostscli` – cố gắng sửa cách dùng `hostscli`;
* `ifconfig_device_not_found` – sửa tên thiết bị sai như `wlan0` thành `wlp2s0`;
* `java` – xóa phần mở rộng `.java` khi chạy chương trình Java;
* `javac` – thêm thiếu `.java` khi biên dịch file Java;
* `lein_not_task` – sửa các task lein sai như `lein rpl`;
* `long_form_help` – đổi `-h` thành `--help` khi dạng ngắn không hỗ trợ
* `ln_no_hard_link` – bắt lỗi tạo hard link lên thư mục, gợi ý symbolic link;
* `ln_s_order` – sửa thứ tự tham số `ln -s`;
* `ls_all` – thêm `-A` cho `ls` khi output rỗng;
* `ls_lah` – thêm `-lah` cho `ls`;
* `man` – đổi section của manual;
* `man_no_space` – sửa lệnh man thiếu dấu cách, ví dụ `mandiff`;
* `mercurial` – sửa các lệnh `hg` sai;
* `missing_space_before_subcommand` – sửa lệnh thiếu dấu cách như `npminstall`;
* `mkdir_p` – thêm `-p` khi tạo thư mục không có thư mục cha;
* `mvn_no_command` – thêm `clean package` vào `mvn`;
* `mvn_unknown_lifecycle_phase` – sửa giai đoạn lifecycle sai với `mvn`;
* `npm_missing_script` – sửa tên script tùy chỉnh trong `npm run-script <script>`;
* `npm_run_script` – thêm thiếu `run-script` cho các script tùy chỉnh của `npm`;
* `npm_wrong_command` – sửa các lệnh npm sai như `npm urgrade`;
* `no_command` – sửa các lệnh console sai, ví dụ `vom/vim`;
* `no_such_file` – tạo thư mục thiếu với các lệnh `mv` và `cp`;
* `omnienv_no_such_command` – sửa lệnh sai cho `goenv`, `nodenv`, `pyenv` và `rbenv` (vd: `pyenv isntall` hoặc `goenv list`);
* `open` – thêm tiền tố `http://` cho địa chỉ truyền vào `open` hoặc tạo file/thư mục mới và truyền cho `open`;
* `pip_install` – sửa lỗi quyền với lệnh `pip install` bằng cách thêm `--user` hoặc thêm `sudo` nếu cần;
* `pip_unknown_command` – sửa các lệnh pip sai, ví dụ `pip instatl/pip install`;
* `php_s` – thay `-s` bằng `-S` khi chạy server php local;
* `port_already_in_use` – kill tiến trình đang chiếm port;
* `prove_recursively` – thêm `-r` khi chạy với thư mục;
* `python_command` – thêm `python` khi bạn chạy script python chưa có quyền thực thi hoặc thiếu `./`;
* `python_execute` – thêm thiếu `.py` khi chạy file Python;
* `python_module_error` – sửa lỗi ModuleNotFoundError bằng cách thử `pip install` module đó;
* `quotation_marks` – sửa lỗi sử dụng không cân bằng dấu `'` và `"` khi có tham số;
* `path_from_history` – thay đường dẫn không tìm thấy bằng một đường dẫn tuyệt đối tương tự từ history;
* `rails_migrations_pending` – chạy các migration còn thiếu;
* `react_native_command_unrecognized` – sửa các lệnh `react-native` không nhận diện được;
* `remove_shell_prompt_literal` – xóa ký tự shell prompt `$` ở đầu, thường gặp khi copy lệnh từ tài liệu;
* `remove_trailing_cedilla` – xóa ký tự cedilla `ç` ở cuối, một lỗi gõ phổ biến với bàn phím châu Âu;
* `rm_dir` – thêm `-rf` khi bạn cố xóa thư mục;
* `scm_correction` – sửa scm sai như `hg log` thành `git log`;
* `sed_unterminated_s` – thêm thiếu '/' cho lệnh `s` của `sed`;
* `sl_ls` – đổi `sl` thành `ls`;
* `ssh_known_hosts` – xóa host khỏi `known_hosts` khi có cảnh báo;
* `sudo` – thêm `sudo` vào lệnh trước nếu thất bại vì quyền;
* `sudo_command_from_user_path` – chạy lệnh từ `$PATH` của user với `sudo`;
* `switch_lang` – chuyển lệnh từ layout bàn phím local sang en;
* `systemctl` – sắp xếp đúng tham số cho `systemctl` khó hiểu;
* `terraform_init.py` – chạy `terraform init` trước khi plan hoặc apply;
* `terraform_no_command.py` – sửa lệnh `terraform` không nhận diện được;
* `test.py` – chạy `pytest` thay cho `test.py`;
* `touch` – tạo thư mục còn thiếu trước khi "touch";
* `tsuru_login` – chạy `tsuru login` nếu chưa xác thực hoặc hết hạn phiên;
* `tsuru_not_command` – sửa các lệnh tsuru sai như `tsuru shell`;
* `tmux` – sửa các lệnh `tmux`;
* `unknown_command` – sửa lỗi "unknown command" kiểu hadoop hdfs, ví dụ thêm thiếu '-' vào lệnh `hdfs dfs ls`;
* `unsudo` – xóa `sudo` khỏi lệnh trước nếu tiến trình từ chối chạy với quyền superuser.
* `vagrant_up` – khởi động instance vagrant;
* `whois` – sửa lệnh `whois`;
* `workon_doesnt_exists` – sửa tên môi trường `virtualenvwrapper` hoặc gợi ý tạo mới.
* `wrong_hyphen_before_subcommand` – xóa dấu gạch ngang đặt sai (`apt-install` -> `apt install`, `git-log` -> `git log`, v.v.)
* `yarn_alias` – sửa các lệnh alias `yarn` như `yarn ls`;
* `yarn_command_not_found` – sửa các lệnh `yarn` viết sai;
* `yarn_command_replaced` – sửa các lệnh `yarn` bị thay thế;
* `yarn_help` – giúp mở tài liệu `yarn` dễ hơn;

##### [Quay lại Mục lục](#contents)

Các quy tắc sau chỉ được bật mặc định trên một số nền tảng cụ thể:

* `apt_get` – cài đặt ứng dụng từ apt nếu chưa cài (cần `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` – đổi tìm kiếm bằng `apt-get` thành tìm kiếm bằng `apt-cache`;
* `apt_invalid_operation` – sửa các lệnh `apt` và `apt-get` không hợp lệ, như `apt-get isntall vim`;
* `apt_list_upgradable` – giúp chạy `apt list --upgradable` sau `apt update`;
* `apt_upgrade` – giúp chạy `apt upgrade` sau `apt list --upgradable`;
* `brew_cask_dependency` – cài đặt các phụ thuộc cask;
* `brew_install` – sửa tên công thức cho `brew install`;
* `brew_reinstall` – đổi `brew install <formula>` thành `brew reinstall <formula>`;
* `brew_link` – thêm `--overwrite --dry-run` nếu linking thất bại;
* `brew_uninstall` – thêm `--force` cho `brew uninstall` nếu đã cài nhiều phiên bản;
* `brew_unknown_command` – sửa các lệnh brew sai, ví dụ `brew docto/brew doctor`;
* `brew_update_formula` – đổi `brew update <formula>` thành `brew upgrade <formula>`;
* `dnf_no_such_command` – sửa các lệnh DNF viết sai;
* `nixos_cmd_not_found` – cài đặt ứng dụng trên NixOS;
* `pacman` – cài đặt ứng dụng bằng `pacman` nếu chưa có (dùng `yay`, `pikaur` hoặc `yaourt` nếu có);
* `pacman_invalid_option` – thay các tùy chọn `pacman` viết thường bằng viết hoa.
* `pacman_not_found` – sửa tên gói với `pacman`, `yay`, `pikaur` hoặc `yaourt`.
* `yum_invalid_operation` – sửa các lệnh `yum` không hợp lệ, như `yum isntall vim`;

Các lệnh sau được đóng gói cùng *The Fuck*, nhưng không được bật mặc định:

* `git_push_force` – thêm `--force-with-lease` vào lệnh `git push` (có thể xung đột với `git_push_pull`);
* `rm_root` – thêm `--no-preserve-root` vào lệnh `rm -rf /`.

##### [Quay lại Mục lục](#contents)

## Tạo quy tắc riêng

Để thêm quy tắc riêng, tạo một file tên `your-rule-name.py` trong `~/.config/thefuck/rules`. File quy tắc phải có hai hàm:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Ngoài ra, quy tắc có thể có các hàm tùy chọn:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Quy tắc cũng có thể có các biến tùy chọn `enabled_by_default`, `requires_output` và `priority`.

`Command` có ba thuộc tính: `script`, `output` và `script_parts`.
Quy tắc của bạn không nên thay đổi `Command`.


**API quy tắc thay đổi từ 3.0:** Để truy cập cài đặt của quy tắc, import với
 `from thefuck.conf import settings`

`settings` là một object đặc biệt được xây dựng từ `~/.config/thefuck/settings.py`,
và các giá trị từ biến môi trường ([xem thêm bên dưới](#settings)).

Ví dụ quy tắc đơn giản cho chạy script với `sudo`:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Tùy chọn:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Số nhỏ hơn ưu tiên trước, mặc định là 1000

requires_output = True
```

[Thêm ví dụ về quy tắc](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[Hàm tiện ích cho quy tắc](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[Trợ lý đặc thù app/hệ điều hành](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Quay lại Mục lục](#contents)

## Cài đặt

Một số tham số của *The Fuck* có thể thay đổi trong file `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` mặc định là `~/.config`):

* `rules` – danh sách quy tắc bật, mặc định là `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` – danh sách quy tắc tắt, mặc định `[]`;
* `require_confirmation` – yêu cầu xác nhận trước khi chạy lệnh mới, mặc định `True`;
* `wait_command` – thời gian tối đa (giây) để lấy output lệnh trước;
* `no_colors` – tắt màu sắc output;
* `priority` – dict với độ ưu tiên các quy tắc, quy tắc có `priority` nhỏ sẽ được xét trước;
* `debug` – bật output debug, mặc định `False`;
* `history_limit` – số lượng lệnh history sẽ được quét, ví dụ `2000`;
* `alter_history` – đẩy lệnh đã sửa vào history, mặc định `True`;
* `wait_slow_command` – thời gian tối đa (giây) lấy output lệnh trước nếu nó thuộc danh sách `slow_commands`;
* `slow_commands` – danh sách các lệnh chậm;
* `num_close_matches` – số lượng gợi ý gần đúng tối đa, mặc định `3`.
* `excluded_search_path_prefixes` – tiền tố path cần bỏ qua khi tìm lệnh, mặc định `[]`.

Ví dụ file `settings.py`:

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

Hoặc qua biến môi trường:

* `THEFUCK_RULES` – danh sách quy tắc bật, ví dụ `DEFAULT_RULES:rm_root` hoặc `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` – danh sách quy tắc tắt, ví dụ `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` – yêu cầu xác nhận trước khi chạy lệnh mới, `true/false`;
* `THEFUCK_WAIT_COMMAND` – thời gian tối đa (giây) lấy output lệnh trước;
* `THEFUCK_NO_COLORS` – tắt màu sắc output, `true/false`;
* `THEFUCK_PRIORITY` – độ ưu tiên quy tắc, ví dụ `no_command=9999:apt_get=100`,
quy tắc có `priority` nhỏ sẽ được xét trước;
* `THEFUCK_DEBUG` – bật output debug, `true/false`;
* `THEFUCK_HISTORY_LIMIT` – số lượng lệnh history sẽ được quét, ví dụ `2000`;
* `THEFUCK_ALTER_HISTORY` – đẩy lệnh đã sửa vào history `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` – thời gian tối đa (giây) lấy output lệnh trước nếu nó thuộc danh sách `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` – danh sách các lệnh chậm, ví dụ `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` – số lượng gợi ý gần đúng tối đa, ví dụ `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` – tiền tố path cần bỏ qua khi tìm lệnh, mặc định `[]`.

Ví dụ:

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

##### [Quay lại Mục lục](#contents)

## Gói bên thứ ba với các quy tắc

Nếu bạn muốn tạo một bộ quy tắc riêng không công khai, nhưng vẫn muốn chia sẻ với người khác, hãy tạo một package tên `thefuck_contrib_*` với cấu trúc sau:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *quy tắc bên thứ ba*
    __init__.py
    *tiện ích bên thứ ba*
  setup.py
```

*The Fuck* sẽ tìm các quy tắc trong module `rules`.

##### [Quay lại Mục lục](#contents)

## Chế độ instant thử nghiệm

Hành vi mặc định của *The Fuck* cần thời gian để chạy lại lệnh trước đó.
Ở chế độ instant, *The Fuck* tiết kiệm thời gian bằng cách ghi lại output với [script](https://en.wikipedia.org/wiki/Script_(Unix)),
sau đó đọc log.

[![gif với instant mode][instant-mode-gif-link]][instant-mode-gif-link]

Hiện tại, instant mode chỉ hỗ trợ Python 3 với bash hoặc zsh. Cần tắt chức năng autocorrect của zsh để thefuck hoạt động đúng.

Để bật instant mode, thêm `--enable-experimental-instant-mode`
vào alias trong `.bashrc`, `.bash_profile` hoặc `.zshrc`.

Ví dụ:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Quay lại Mục lục](#contents)

## Phát triển

Xem [CONTRIBUTING.md](CONTRIBUTING.md)

## Giấy phép MIT
Giấy phép của dự án có thể xem [tại đây](LICENSE.md).


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

##### [Quay lại Mục lục](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---