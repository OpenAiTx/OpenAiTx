# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* یک برنامه فوق‌العاده است که با الهام از [توییت @liamosaur](https://twitter.com/liamosaur/status/506975850596536320)
خطاهای دستورات قبلی کنسول را اصلاح می‌کند.

آیا *The Fuck* برای شما کند است؟ [حالت آزمایشی فوری را امتحان کنید!](#experimental-instant-mode)

[![gif با مثال‌ها][examples-link]][examples-link]

نمونه‌های بیشتر:

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

اگر نگرانی از اجرای کورکورانه دستورات اصلاح‌شده ندارید، گزینه
`require_confirmation` در [تنظیمات](#settings) را می‌توانید غیرفعال کنید:

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

## فهرست مطالب

1. [پیش‌نیازها](#requirements)
2. [نصب](#installation)
3. [بروزرسانی](#updating)
4. [نحوه کار](#how-it-works)
5. [ساخت قوانین شخصی](#creating-your-own-rules)
6. [تنظیمات](#settings)
7. [پکیج‌های شخص ثالث با قوانین](#third-party-packages-with-rules)
8. [حالت آزمایشی فوری](#experimental-instant-mode)
9. [توسعه](#developing)
10. [مجوز](#license-mit)

## پیش‌نیازها

- پایتون (۳.۵ به بالا)
- pip
- python-dev

##### [بازگشت به فهرست مطالب](#contents)

## نصب

در macOS یا لینوکس، می‌توانید *The Fuck* را از طریق [Homebrew][homebrew] نصب کنید:

```bash
brew install thefuck
```

در Ubuntu / Mint، *The Fuck* را با دستورات زیر نصب کنید:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

در FreeBSD، *The Fuck* را با دستورات زیر نصب کنید:
```bash
pkg install thefuck
```

در ChromeOS، *The Fuck* را با استفاده از [chromebrew](https://github.com/skycocker/chromebrew) با دستور زیر نصب کنید:
```bash
crew install thefuck
```

در سیستم‌های مبتنی بر Arch، *The Fuck* را با دستور زیر نصب کنید:
```
sudo pacman -S thefuck
```

در سایر سیستم‌ها، *The Fuck* را با استفاده از `pip` نصب کنید:

```bash
pip install thefuck
```

[یا می‌توانید از مدیر بسته سیستم عامل خود (OS X، Ubuntu، Arch) استفاده کنید.](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
توصیه می‌شود این دستور را در فایل `.bash_profile`،
`.bashrc`، `.zshrc` یا سایر اسکریپت‌های ابتدایی خود قرار دهید:

```bash
eval $(thefuck --alias)
# می‌توانید هر نام مستعاری که خواستید استفاده کنید، مثلاً برای روزهای دوشنبه:
eval $(thefuck --alias FUCK)
```

[یا در تنظیمات شل خود (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

تغییرات فقط در نشست جدید شل در دسترس هستند. برای اعمال فوری تغییرات،
دستور `source ~/.bashrc` (یا فایل تنظیمات شل خود مانند `.zshrc`) را اجرا کنید.

برای اجرای دستورات اصلاح‌شده بدون تأیید، از گزینه `--yeah` (یا فقط `-y` برای کوتاهی، یا `--hard` اگر خیلی ناراحت هستید) استفاده کنید:

```bash
fuck --yeah
```

برای اصلاح بازگشتی دستورات تا موفقیت، از گزینه `-r` استفاده کنید:

```bash
fuck -r
```

##### [بازگشت به فهرست مطالب](#contents)

## بروزرسانی

```bash
pip3 install thefuck --upgrade
```

**توجه: عملکرد alias در نسخه v1.34 *The Fuck* تغییر کرد**

## حذف نصب

برای حذف *The Fuck*، مراحل نصب را معکوس کنید:
- خط alias مربوط به *thefuck* را از فایل تنظیمات شل خود (Bash, Zsh, Fish, Powershell, tcsh و ...) پاک یا کامنت کنید.
- با استفاده از مدیر بسته خود (brew, pip3, pkg, crew, pip) فایل‌های اجرایی را حذف کنید.

## نحوه کار

*The Fuck* تلاش می‌کند دستور قبلی را با یک قانون مطابقت دهد. اگر مطابقتی پیدا شد، یک دستور جدید بر اساس قانون مطابقت داده شده ایجاد و اجرا می‌شود. قوانین زیر به طور پیش‌فرض فعال هستند:

* `adb_unknown_command` &ndash; اصلاح دستورات اشتباه مانند `adb logcta`;
* `ag_literal` &ndash; افزودن `-Q` به `ag` در صورت نیاز;
* `aws_cli` &ndash; اصلاح دستورات اشتباه مانند `aws dynamdb scan`;
* `az_cli` &ndash; اصلاح دستورات اشتباه مانند `az providers`;
* `cargo` &ndash; اجرای `cargo build` به جای `cargo`;
* `cargo_no_command` &ndash; اصلاح دستورات اشتباه مانند `cargo buid`;
* `cat_dir` &ndash; جایگزینی `cat` با `ls` هنگام تلاش برای `cat` یک پوشه;
* `cd_correction` &ndash; اصلاح و تصحیح دستورات `cd` ناموفق;
* `cd_cs` &ndash; تغییر `cs` به `cd`;
* `cd_mkdir` &ndash; ایجاد دایرکتوری قبل از وارد شدن با `cd`;
* `cd_parent` &ndash; تغییر `cd..` به `cd ..`;
* `chmod_x` &ndash; افزودن بیت اجرایی;
* `choco_install` &ndash; افزودن پسوندهای متداول برای بسته‌های chocolatey;
* `composer_not_command` &ndash; اصلاح نام دستور composer;
* `conda_mistype` &ndash; اصلاح دستورات اشتباه conda;
* `cp_create_destination` &ndash; ایجاد پوشه جدید هنگام تلاش برای `cp` یا `mv` به مقصد ناموجود
* `cp_omitting_directory` &ndash; افزودن `-a` هنگام `cp` پوشه;
* `cpp11` &ndash; افزودن `-std=c++11` گمشده به `g++` یا `clang++`;
* `dirty_untar` &ndash; اصلاح دستور `tar x` که فایل‌ها را در پوشه فعلی استخراج کرده است;
* `dirty_unzip` &ndash; اصلاح دستور `unzip` که فایل‌ها را در پوشه فعلی استخراج کرده است;
* `django_south_ghost` &ndash; افزودن `--delete-ghost-migrations` به مهاجرت اشتباه south جنگو;
* `django_south_merge` &ndash; افزودن `--merge` به مهاجرت ناسازگار south جنگو;
* `docker_login` &ndash; اجرای `docker login` و تکرار دستور قبلی;
* `docker_not_command` &ndash; اصلاح دستورات اشتباه docker مانند `docker tags`;
* `docker_image_being_used_by_container` &ndash; حذف کانتینری که تصویر را استفاده می‌کند قبل از حذف تصویر;
* `dry` &ndash; اصلاح تکرار مانند `git git push`;
* `fab_command_not_found` &ndash; اصلاح دستورات اشتباه fabric;
* `fix_alt_space` &ndash; جایگزینی Alt+Space با فضای معمولی;
* `fix_file` &ndash; باز کردن فایل دارای خطا در `$EDITOR` شما;
* `gem_unknown_command` &ndash; اصلاح دستورات اشتباه `gem`;
* `git_add` &ndash; اصلاح *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` &ndash; افزودن `--force` به `git add <pathspec>...` هنگام وجود مسیرهای .gitignore;
* `git_bisect_usage` &ndash; اصلاح دستورات اشتباه هنگام bisect کردن مانند `git bisect strt`, `git bisect goood`, `git bisect rset` و غیره;
* `git_branch_delete` &ndash; تغییر `git branch -d` به `git branch -D`;
* `git_branch_delete_checked_out` &ndash; تغییر `git branch -d` به `git checkout master && git branch -D` هنگام تلاش برای حذف شاخه در حال استفاده;
* `git_branch_exists` &ndash; پیشنهاد `git branch -d foo`, `git branch -D foo` یا `git checkout foo` هنگام ساخت شاخه‌ای که وجود دارد;
* `git_branch_list` &ndash; گرفتن `git branch list` به جای `git branch` و حذف شاخه ساخته شده;
* `git_branch_0flag` &ndash; اصلاح دستورات مانند `git branch 0v` و `git branch 0r` با حذف شاخه ایجاد شده;
* `git_checkout` &ndash; اصلاح نام شاخه یا ساخت شاخه جدید;
* `git_clone_git_clone` &ndash; جایگزینی `git clone git clone ...` با `git clone ...`
* `git_clone_missing` &ndash; افزودن `git clone` به URLهایی که به مخزن git اشاره دارند.
* `git_commit_add` &ndash; پیشنهاد `git commit -a ...` یا `git commit -p ...` اگر کامیت قبلی به دلیل عدم stage شدن شکست خورده باشد;
* `git_commit_amend` &ndash; پیشنهاد `git commit --amend` پس از کامیت قبلی;
* `git_commit_reset` &ndash; پیشنهاد `git reset HEAD~` پس از کامیت قبلی;
* `git_diff_no_index` &ndash; افزودن `--no-index` به `git diff` قبلی روی فایل‌های ردیابی نشده;
* `git_diff_staged` &ndash; افزودن `--staged` به `git diff` قبلی با خروجی غیرمنتظره;
* `git_fix_stash` &ndash; اصلاح دستورات `git stash` (زیردستور اشتباه و نبودن `save`);
* `git_flag_after_filename` &ndash; اصلاح `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; اصلاح دستورات `git help <alias>` با جایگزینی <alias> با دستور علیاس شده;
* `git_hook_bypass` &ndash; افزودن پرچم `--no-verify` قبل از اجرای `git am`, `git commit`, یا `git push`;
* `git_lfs_mistype` &ndash; اصلاح دستورات اشتباه `git lfs <command>`;
* `git_main_master` &ndash; اصلاح نام شاخه اشتباه بین `main` و `master`
* `git_merge` &ndash; افزودن remote به نام شاخه‌ها;
* `git_merge_unrelated` &ndash; افزودن `--allow-unrelated-histories` در صورت نیاز
* `git_not_command` &ndash; اصلاح دستورات اشتباه git مانند `git brnch`;
* `git_pull` &ndash; تنظیم upstream قبل از اجرای `git pull` قبلی;
* `git_pull_clone` &ndash; کلون کردن به جای pull زمانی که مخزن وجود ندارد;
* `git_pull_uncommitted_changes` &ndash; stash کردن تغییرات قبل از pull و pop کردن آن‌ها بعد از آن;
* `git_push` &ndash; افزودن `--set-upstream origin $branch` به `git push` شکست‌خورده قبلی;
* `git_push_different_branch_names` &ndash; اصلاح pushها زمانی که نام شاخه محلی با remote متفاوت است;
* `git_push_pull` &ndash; اجرای `git pull` زمانی که push رد شده است;
* `git_push_without_commits` &ndash; ساخت کامیت اولیه اگر فقط `git add .` انجام داده‌اید، هنگام راه‌اندازی پروژه جدید;
* `git_rebase_no_changes` &ndash; اجرای `git rebase --skip` به جای `git rebase --continue` زمانی که هیچ تغییری وجود ندارد;
* `git_remote_delete` &ndash; جایگزینی `git remote delete remote_name` با `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; افزودن `-f` یا `--cached` هنگام تلاش برای حذف فایل محلی تغییر داده شده;
* `git_rm_recursive` &ndash; افزودن `-r` هنگام تلاش برای حذف پوشه;
* `git_rm_staged` &ndash;  افزودن `-f` یا `--cached` هنگام تلاش برای حذف فایل با تغییرات stage شده;
* `git_rebase_merge_dir` &ndash; پیشنهاد اجرای `git rebase (--continue | --abort | --skip)` یا حذف دایرکتوری `.git/rebase-merge` در جریان rebase;
* `git_remote_seturl_add` &ndash; اجرای `git remote add` هنگام استفاده از `git remote set_url` روی remote ناموجود;
* `git_stash` &ndash; stash کردن تغییرات محلی قبل از rebase یا تعویض شاخه;
* `git_stash_pop` &ndash; افزودن تغییرات محلی قبل از اجرای stash pop، سپس reset;
* `git_tag_force` &ndash; افزودن `--force` به `git tag <tagname>` زمانی که تگ قبلاً وجود دارد;
* `git_two_dashes` &ndash; افزودن خط تیره گمشده به دستورات مانند `git commit -amend` یا `git rebase -continue`;
* `go_run` &ndash; افزودن پسوند `.go` هنگام کامپایل/اجرای برنامه‌های Go;
* `go_unknown_command` &ndash; اصلاح دستورات اشتباه go، مثل `go bulid`;
* `gradle_no_task` &ndash; اصلاح کار gradle پیدا نشد یا مبهم;
* `gradle_wrapper` &ndash; جایگزینی `gradle` با `./gradlew`;
* `grep_arguments_order` &ndash; اصلاح ترتیب آرگومان‌های grep برای موقعیت‌هایی مانند `grep -lir . test`;
* `grep_recursive` &ndash; افزودن `-r` هنگام تلاش برای grep گرفتن پوشه;
* `grunt_task_not_found` &ndash; اصلاح دستورات اشتباه grunt;
* `gulp_not_task` &ndash; اصلاح وظایف اشتباه gulp;
* `has_exists_script` &ndash; افزودن `./` هنگام وجود اسکریپت/باینری;
* `heroku_multiple_apps` &ndash; افزودن `--app <app>` به دستورات heroku مانند `heroku pg`;
* `heroku_not_command` &ndash; اصلاح دستورات اشتباه heroku مانند `heroku log`;
* `history` &ndash; تلاش برای جایگزینی دستور با شبیه‌ترین دستور از تاریخچه;
* `hostscli` &ndash; تلاش برای اصلاح استفاده از hostscli;
* `ifconfig_device_not_found` &ndash; اصلاح نام دستگاه اشتباه مانند `wlan0` به `wlp2s0`;
* `java` &ndash; حذف پسوند `.java` هنگام اجرای برنامه‌های جاوا;
* `javac` &ndash; افزودن پسوند `.java` گمشده هنگام کامپایل فایل‌های جاوا;
* `lein_not_task` &ndash; اصلاح وظایف اشتباه lein مانند `lein rpl`;
* `long_form_help` &ndash; تغییر `-h` به `--help` وقتی نسخه کوتاه پشتیبانی نمی‌شود;
* `ln_no_hard_link` &ndash; گرفتن تلاش برای ساخت hard link روی پوشه، پیشنهاد symbolic link;
* `ln_s_order` &ndash; اصلاح ترتیب آرگومان‌های `ln -s`;
* `ls_all` &ndash; افزودن `-A` به `ls` هنگام خالی بودن خروجی;
* `ls_lah` &ndash; افزودن `-lah` به `ls`;
* `man` &ndash; تغییر بخش manual;
* `man_no_space` &ndash; اصلاح دستورات man بدون فاصله، مانند `mandiff`;
* `mercurial` &ndash; اصلاح دستورات اشتباه hg;
* `missing_space_before_subcommand` &ndash; اصلاح دستور بدون فاصله مانند `npminstall`;
* `mkdir_p` &ndash; افزودن `-p` هنگام ساخت پوشه بدون والد;
* `mvn_no_command` &ndash; افزودن `clean package` به `mvn`;
* `mvn_unknown_lifecycle_phase` &ndash; اصلاح فازهای اشتباه lifecycle در mvn;
* `npm_missing_script` &ndash; اصلاح نام اسکریپت سفارشی npm در `npm run-script <script>`;
* `npm_run_script` &ndash; افزودن `run-script` گمشده برای اسکریپت‌های سفارشی npm;
* `npm_wrong_command` &ndash; اصلاح دستورات اشتباه npm مانند `npm urgrade`;
* `no_command` &ndash; اصلاح دستورات کنسول اشتباه، مثلاً `vom/vim`;
* `no_such_file` &ndash; ایجاد پوشه‌های گمشده با دستورات mv و cp;
* `omnienv_no_such_command` &ndash; اصلاح دستورات اشتباه برای goenv, nodenv, pyenv و rbenv (مثلاً: `pyenv isntall` یا `goenv list`);
* `open` &ndash; یا افزودن `http://` به آدرس داده‌شده به open یا ساخت فایل/پوشه جدید و ارسال آن به open;
* `pip_install` &ndash; اصلاح مشکلات دسترسی در دستورات pip install با افزودن `--user` یا `sudo` در صورت نیاز;
* `pip_unknown_command` &ndash; اصلاح دستورات اشتباه pip مانند `pip instatl/pip install`;
* `php_s` &ndash; جایگزینی `-s` با `-S` هنگام اجرای سرور محلی php;
* `port_already_in_use` &ndash; کشتن فرآیندی که پورت را اشغال کرده است;
* `prove_recursively` &ndash; افزودن `-r` هنگام فراخوانی با پوشه;
* `python_command` &ndash; افزودن python هنگام اجرای اسکریپت غیر اجرایی/بدون `./` پایتون;
* `python_execute` &ndash; افزودن `.py` گمشده هنگام اجرای فایل‌های پایتون;
* `python_module_error` &ndash; اصلاح ModuleNotFoundError با تلاش برای نصب ماژول با pip;
* `quotation_marks` &ndash; اصلاح استفاده نامتوازن از `'` و `"` در آرگومان‌ها;
* `path_from_history` &ndash; جایگزینی مسیر یافت‌نشده با مسیر مطلق مشابه از تاریخچه;
* `rails_migrations_pending` &ndash; اجرای مهاجرت‌های معلق;
* `react_native_command_unrecognized` &ndash; اصلاح دستورات ناشناخته react-native;
* `remove_shell_prompt_literal` &ndash; حذف نماد ابتدایی شل `$`، رایج هنگام کپی دستورات از مستندات;
* `remove_trailing_cedilla` &ndash; حذف cedilla انتهایی `ç`، اشتباه رایج در کیبوردهای اروپایی;
* `rm_dir` &ndash; افزودن `-rf` هنگام حذف پوشه;
* `scm_correction` &ndash; تصحیح scm اشتباه مانند `hg log` به `git log`;
* `sed_unterminated_s` &ndash; افزودن `/` گمشده به دستورات `s` در sed;
* `sl_ls` &ndash; تغییر `sl` به `ls`;
* `ssh_known_hosts` &ndash; حذف host از `known_hosts` هنگام هشدار;
* `sudo` &ndash; افزودن sudo به دستور قبلی در صورت شکست به علت دسترسی;
* `sudo_command_from_user_path` &ndash; اجرای دستورات از `$PATH` کاربر با sudo;
* `switch_lang` &ndash; تغییر دستور از layout محلی به انگلیسی;
* `systemctl` &ndash; ترتیب صحیح پارامترهای گیج‌کننده systemctl;
* `terraform_init.py` &ndash; اجرای `terraform init` قبل از plan یا apply;
* `terraform_no_command.py` &ndash; اصلاح دستورات ناشناخته terraform;
* `test.py` &ndash; اجرای pytest به جای test.py;
* `touch` &ndash; ایجاد پوشه‌های گمشده قبل از اجرای touch;
* `tsuru_login` &ndash; اجرای tsuru login در صورت عدم احراز هویت یا انقضا نشست;
* `tsuru_not_command` &ndash; اصلاح دستورات اشتباه tsuru مانند `tsuru shell`;
* `tmux` &ndash; اصلاح دستورات tmux;
* `unknown_command` &ndash; اصلاح خطای "unknown command" hadoop/hdfs، مثلاً افزودن `-` گمشده به دستور در `hdfs dfs ls`;
* `unsudo` &ndash; حذف sudo از دستور قبلی اگر فرآیند از اجرای با امتیاز superuser امتناع کند.
* `vagrant_up` &ndash; راه‌اندازی نمونه vagrant;
* `whois` &ndash; اصلاح دستور whois;
* `workon_doesnt_exists` &ndash; اصلاح نام env virtualenvwrapper یا پیشنهاد ساخت جدید.
* `wrong_hyphen_before_subcommand` &ndash; حذف خط تیره اشتباه (`apt-install` -> `apt install`, `git-log` -> `git log`, و غیره.)
* `yarn_alias` &ndash; اصلاح دستورات علیاس شده yarn مانند `yarn ls`;
* `yarn_command_not_found` &ndash; اصلاح دستورات اشتباه yarn;
* `yarn_command_replaced` &ndash; اصلاح دستورات جایگزین شده yarn;
* `yarn_help` &ndash; آسان‌تر کردن باز کردن مستندات yarn;

##### [بازگشت به فهرست مطالب](#contents)

قوانین زیر فقط روی پلتفرم‌های خاص به طور پیش‌فرض فعال هستند:

* `apt_get` &ndash; نصب برنامه با apt اگر نصب نشده باشد (نیازمند `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; تغییر جستجو با `apt-get` به جستجو با `apt-cache`;
* `apt_invalid_operation` &ndash; اصلاح فراخوانی اشتباه apt و apt-get مانند `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; کمک به اجرای `apt list --upgradable` بعد از `apt update`;
* `apt_upgrade` &ndash; کمک به اجرای `apt upgrade` بعد از `apt list --upgradable`;
* `brew_cask_dependency` &ndash; نصب وابستگی‌های cask;
* `brew_install` &ndash; اصلاح نام فرمول برای `brew install`;
* `brew_reinstall` &ndash; تبدیل `brew install <formula>` به `brew reinstall <formula>`;
* `brew_link` &ndash; افزودن `--overwrite --dry-run` در صورت شکست لینک;
* `brew_uninstall` &ndash; افزودن `--force` به `brew uninstall` اگر چند نسخه نصب شده باشد;
* `brew_unknown_command` &ndash; اصلاح دستورات اشتباه brew، مثل `brew docto/brew doctor`;
* `brew_update_formula` &ndash; تبدیل `brew update <formula>` به `brew upgrade <formula>`;
* `dnf_no_such_command` &ndash; اصلاح دستورات اشتباه DNF;
* `nixos_cmd_not_found` &ndash; نصب برنامه‌ها در NixOS;
* `pacman` &ndash; نصب برنامه با pacman اگر نصب نشده باشد (از yay، pikaur یا yaourt اگر موجود باشد استفاده می‌کند);
* `pacman_invalid_option` &ndash; جایگزینی گزینه‌های کوچک pacman با بزرگ.
* `pacman_not_found` &ndash; اصلاح نام بسته با pacman، yay، pikaur یا yaourt.
* `yum_invalid_operation` &ndash; اصلاح فراخوانی اشتباه yum مانند `yum isntall vim`;

دستورات زیر با *The Fuck* ارائه می‌شوند، اما به طور پیش‌فرض فعال نیستند:

* `git_push_force` &ndash; افزودن `--force-with-lease` به `git push` (ممکن است با `git_push_pull` تداخل داشته باشد);
* `rm_root` &ndash; افزودن `--no-preserve-root` به دستور `rm -rf /`.

##### [بازگشت به فهرست مطالب](#contents)

## ساخت قوانین شخصی

برای افزودن قانون خود، فایلی با نام `your-rule-name.py` در مسیر
`~/.config/thefuck/rules` بسازید. فایل قانون باید شامل دو تابع باشد:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

علاوه بر این، قوانین می‌توانند توابع اختیاری نیز داشته باشند:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
قوانین همچنین می‌توانند متغیرهای اختیاری `enabled_by_default`، `requires_output` و `priority` را داشته باشند.

`Command` دارای سه ویژگی است: `script`، `output` و `script_parts`.
قانون شما نباید Command را تغییر دهد.


**API قوانین در نسخه ۳.۰ تغییر کرده است:** برای دسترسی به تنظیمات قانون،
آن را با `from thefuck.conf import settings` وارد کنید.

`settings` یک شیء ویژه است که از `~/.config/thefuck/settings.py`
و مقادیر env ([در ادامه ببینید](#settings)) ساخته می‌شود.

مثالی ساده از قانون برای اجرای یک اسکریپت با sudo:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# اختیاری:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # کوچکتر اول، پیش‌فرض 1000

requires_output = True
```

[نمونه‌های بیشتر قوانین](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[توابع کمکی برای قوانین](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[ابزارهای ویژه برای برنامه/سیستم‌عامل](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [بازگشت به فهرست مطالب](#contents)

## تنظیمات

چندین پارامتر *The Fuck* را می‌توان در فایل `$XDG_CONFIG_HOME/thefuck/settings.py`
(به طور پیش‌فرض `$XDG_CONFIG_HOME` برابر `~/.config` است) تغییر داد:

* `rules` &ndash; لیست قوانین فعال، به طور پیش‌فرض `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; لیست قوانین غیرفعال، به طور پیش‌فرض `[]`;
* `require_confirmation` &ndash; نیاز به تأیید قبل از اجرای دستور جدید، به طور پیش‌فرض `True`;
* `wait_command` &ndash; حداکثر زمان (ثانیه) برای دریافت خروجی دستور قبلی;
* `no_colors` &ndash; غیرفعال کردن خروجی رنگی;
* `priority` &ndash; دیکشنری با اولویت قوانین، قانونی با اولویت پایین‌تر زودتر بررسی می‌شود;
* `debug` &ndash; فعال‌سازی خروجی debug، به طور پیش‌فرض `False`;
* `history_limit` &ndash; تعداد دستورات تاریخچه که اسکن می‌شوند، مانند `2000`;
* `alter_history` &ndash; افزودن دستور اصلاح‌شده به تاریخچه، به طور پیش‌فرض `True`;
* `wait_slow_command` &ndash; حداکثر زمان (ثانیه) برای دریافت خروجی دستور قبلی اگر در لیست `slow_commands` باشد;
* `slow_commands` &ndash; لیست دستورات کند;
* `num_close_matches` &ndash; حداکثر تعداد پیشنهاد دستورات مشابه، پیش‌فرض `3`.
* `excluded_search_path_prefixes` &ndash; پیشوند مسیرهایی که در جستجوی دستورات نادیده گرفته می‌شوند، پیش‌فرض `[]`.

نمونه‌ای از `settings.py`:

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

یا از طریق متغیرهای محیطی:

* `THEFUCK_RULES` &ndash; لیست قوانین فعال، مانند `DEFAULT_RULES:rm_root` یا `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; لیست قوانین غیرفعال، مانند `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; نیاز به تأیید قبل از اجرای دستور جدید، `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; حداکثر زمان (ثانیه) برای دریافت خروجی دستور قبلی;
* `THEFUCK_NO_COLORS` &ndash; غیرفعال کردن خروجی رنگی، `true/false`;
* `THEFUCK_PRIORITY` &ndash; اولویت قوانین، مانند `no_command=9999:apt_get=100`,
قانون با اولویت پایین‌تر زودتر بررسی می‌شود;
* `THEFUCK_DEBUG` &ndash; فعال‌سازی خروجی debug، `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; تعداد دستورات تاریخچه که اسکن می‌شوند، مانند `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; افزودن دستور اصلاح‌شده به تاریخچه `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; حداکثر زمان (ثانیه) برای دریافت خروجی دستور قبلی اگر در لیست `slow_commands` باشد;
* `THEFUCK_SLOW_COMMANDS` &ndash; لیست دستورات کند، مانند `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; حداکثر تعداد پیشنهاد دستورات مشابه، مانند `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; پیشوند مسیرهایی که در جستجوی دستورات نادیده گرفته می‌شوند، پیش‌فرض `[]`.

برای مثال:

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

##### [بازگشت به فهرست مطالب](#contents)

## پکیج‌های شخص ثالث با قوانین

اگر دوست دارید مجموعه‌ای از قوانین غیرعمومی بسازید و همچنان آن‌ها را با دیگران به اشتراک بگذارید، یک پکیج با نام `thefuck_contrib_*` با ساختار زیر بسازید:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *قوانین شخص ثالث*
    __init__.py
    *ابزارهای شخص ثالث*
  setup.py
```

*The Fuck* قوانین موجود در ماژول `rules` را پیدا خواهد کرد.

##### [بازگشت به فهرست مطالب](#contents)

## حالت آزمایشی فوری

رفتار پیش‌فرض *The Fuck* نیاز به زمان برای اجرای مجدد دستورات قبلی دارد.
در حالت فوری، *The Fuck* با ثبت خروجی توسط [script](https://en.wikipedia.org/wiki/Script_(Unix)),
سپس خواندن لاگ، زمان را ذخیره می‌کند.

[![gif با حالت فوری][instant-mode-gif-link]][instant-mode-gif-link]

در حال حاضر، حالت فوری فقط Python 3 با bash یا zsh را پشتیبانی می‌کند. عملکرد autocorrect در zsh نیز باید غیرفعال شود تا thefuck درست کار کند.

برای فعال‌سازی حالت فوری، `--enable-experimental-instant-mode`
را به مقداردهی اولیه alias در `.bashrc`, `.bash_profile` یا `.zshrc` اضافه کنید.

برای مثال:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [بازگشت به فهرست مطالب](#contents)

## توسعه

[CONTRIBUTING.md](CONTRIBUTING.md) را ببینید.

## مجوز MIT
مجوز پروژه را می‌توانید [اینجا](LICENSE.md) مشاهده کنید.


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

##### [بازگشت به فهرست مطالب](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---