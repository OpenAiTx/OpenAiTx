# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* هو تطبيق رائع، مستوحى من [تغريدة](https://twitter.com/liamosaur/status/506975850596536320) لـ [@liamosaur](https://twitter.com/liamosaur/) يصحح الأخطاء في أوامر الطرفية السابقة.

هل *The Fuck* بطيء جداً؟ [جرّب وضع السرعة الفورية التجريبي!](#experimental-instant-mode)

[![gif مع أمثلة][examples-link]][examples-link]

المزيد من الأمثلة:

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

إذا لم تكن تخشى تشغيل أوامر مصححة دون مراجعة، يمكنك تعطيل خيار `require_confirmation` في [الإعدادات](#settings):

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

## الفهرس

1. [المتطلبات](#requirements)
2. [التثبيت](#installation)
3. [التحديث](#updating)
4. [كيف يعمل](#how-it-works)
5. [إنشاء قواعدك الخاصة](#creating-your-own-rules)
6. [الإعدادات](#settings)
7. [حزم طرف ثالث مع قواعد](#third-party-packages-with-rules)
8. [وضع السرعة الفورية التجريبي](#experimental-instant-mode)
9. [التطوير](#developing)
10. [الترخيص](#license-mit)

## المتطلبات

- python (3.5+)
- pip
- python-dev

##### [العودة إلى الفهرس](#contents)

## التثبيت

على macOS أو Linux، يمكنك تثبيت *The Fuck* عبر [Homebrew][homebrew]:

```bash
brew install thefuck
```

على Ubuntu / Mint، ثبّت *The Fuck* بالأوامر التالية:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

على FreeBSD، ثبّت *The Fuck* بالأوامر التالية:
```bash
pkg install thefuck
```

على ChromeOS، ثبّت *The Fuck* باستخدام [chromebrew](https://github.com/skycocker/chromebrew) بالأمر التالي:
```bash
crew install thefuck
```

على الأنظمة المبنية على Arch، ثبّت *The Fuck* بالأمر التالي:
```
sudo pacman -S thefuck
```

على الأنظمة الأخرى، ثبّت *The Fuck* باستخدام `pip`:

```bash
pip install thefuck
```

[بدلاً من ذلك، يمكنك استخدام مدير الحزم الخاص بنظام التشغيل (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
يُنصح بإضافة هذا الأمر في ملف `.bash_profile` أو `.bashrc` أو `.zshrc` أو أي ملف تهيئة آخر لصدفتك:

```bash
eval $(thefuck --alias)
# يمكنك استخدام أي اسم مستعار تريده، مثلاً ليوم الاثنين:
eval $(thefuck --alias FUCK)
```

[أو في ملف تهيئة الصدفة (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

التغييرات تتوفر فقط في جلسة صدفة جديدة. لجعل التغييرات فورية، شغّل `source ~/.bashrc` (أو ملف إعداد صدفتك مثل `.zshrc`).

لتشغيل الأوامر المصححة بدون تأكيد، استخدم الخيار `--yeah` (أو فقط `-y` للاختصار، أو `--hard` إذا كنت منزعجاً جداً):

```bash
fuck --yeah
```

لتصحيح الأوامر بشكل متكرر حتى تنجح، استخدم الخيار `-r`:

```bash
fuck -r
```

##### [العودة إلى الفهرس](#contents)

## التحديث

```bash
pip3 install thefuck --upgrade
```

**ملاحظة: تم تغيير وظيفة الاسم المستعار في الإصدار v1.34 من *The Fuck***

## إزالة التثبيت

لإزالة *The Fuck*، اعكس عملية التثبيت:
- احذف أو علّق سطر الاسم المستعار *thefuck* من ملف إعداد صدفتك (Bash, Zsh, Fish, Powershell, tcsh, ...)
- استخدم مدير الحزم الخاص بك (brew, pip3, pkg, crew, pip) لإزالة الملفات التنفيذية

## كيف يعمل

يحاول *The Fuck* مطابقة الأمر السابق مع قاعدة. إذا تم العثور على تطابق، يتم إنشاء أمر جديد باستخدام القاعدة المطابقة وتنفيذه. القواعد التالية مفعلة بشكل افتراضي:

* `adb_unknown_command` &ndash; يصحح أوامر adb المكتوبة بشكل خاطئ مثل `adb logcta`;
* `ag_literal` &ndash; يضيف `-Q` إلى `ag` عند الحاجة؛
* `aws_cli` &ndash; يصحح أوامر aws المكتوبة بشكل خاطئ مثل `aws dynamdb scan`;
* `az_cli` &ndash; يصحح أوامر az المكتوبة بشكل خاطئ مثل `az providers`;
* `cargo` &ndash; يشغل `cargo build` بدلاً من `cargo`;
* `cargo_no_command` &ndash; يصحح أوامر cargo الخاطئة مثل `cargo buid`;
* `cat_dir` &ndash; يستبدل `cat` بـ `ls` عند محاولة قراءة مجلد؛
* `cd_correction` &ndash; يصحح أوامر cd الفاشلة إملائياً؛
* `cd_cs` &ndash; يغير `cs` إلى `cd`;
* `cd_mkdir` &ndash; ينشئ مجلدات قبل الانتقال إليها بـ cd؛
* `cd_parent` &ndash; يغير `cd..` إلى `cd ..`;
* `chmod_x` &ndash; يضيف إذن التنفيذ؛
* `choco_install` &ndash; يضيف لاحقات شائعة لحزم chocolatey؛
* `composer_not_command` &ndash; يصحح اسم أمر composer؛
* `conda_mistype` &ndash; يصحح أوامر conda؛
* `cp_create_destination` &ndash; ينشئ مجلداً جديداً عند محاولة النسخ أو النقل إلى وجهة غير موجودة؛
* `cp_omitting_directory` &ndash; يضيف `-a` عند نسخ مجلد؛
* `cpp11` &ndash; يضيف `-std=c++11` المفقود إلى `g++` أو `clang++`;
* `dirty_untar` &ndash; يصحح أمر tar الذي يفك الضغط في الدليل الحالي؛
* `dirty_unzip` &ndash; يصحح أمر unzip الذي يفك الضغط في الدليل الحالي؛
* `django_south_ghost` &ndash; يضيف `--delete-ghost-migrations` عند فشل هجرة django south بسبب الأشباح؛
* `django_south_merge` &ndash; يضيف `--merge` للهجرة غير المتسقة في django south؛
* `docker_login` &ndash; ينفذ `docker login` ويكرر الأمر السابق؛
* `docker_not_command` &ndash; يصحح أوامر docker الخاطئة مثل `docker tags`;
* `docker_image_being_used_by_container` &dash; يزيل الحاوية التي تستخدم الصورة قبل إزالة الصورة؛
* `dry` &ndash; يصحح التكرارات مثل `git git push`;
* `fab_command_not_found` &ndash; يصحح أوامر fabric المكتوبة بشكل خاطئ؛
* `fix_alt_space` &ndash; يستبدل Alt+Space بحرف Space عادي؛
* `fix_file` &ndash; يفتح ملفاً به خطأ في `$EDITOR` الخاص بك؛
* `gem_unknown_command` &ndash; يصحح أوامر gem الخاطئة؛
* `git_add` &ndash; يصحح رسالة *"pathspec 'foo' did not match any file(s) known to git."*؛
* `git_add_force` &ndash; يضيف `--force` إلى `git add <pathspec>...` عند تجاهل المسارات بواسطة .gitignore؛
* `git_bisect_usage` &ndash; يصحح أوامر git bisect الخاطئة؛
* `git_branch_delete` &ndash; يغير `git branch -d` إلى `git branch -D`;
* `git_branch_delete_checked_out` &ndash; يغير `git branch -d` إلى `git checkout master && git branch -D` عند محاولة حذف فرع مستخدم؛
* `git_branch_exists` &ndash; يقترح أوامر عند محاولة إنشاء فرع موجود بالفعل؛
* `git_branch_list` &ndash; يلتقط `git branch list` بدلاً من `git branch` ويزيل الفرع الذي تم إنشاؤه؛
* `git_branch_0flag` &ndash; يصحح أوامر مثل `git branch 0v` ويزيل الفرع الذي تم إنشاؤه؛
* `git_checkout` &ndash; يصحح اسم الفرع أو ينشئ فرعاً جديداً؛
* `git_clone_git_clone` &ndash; يستبدل `git clone git clone ...` بـ `git clone ...`
* `git_clone_missing` &ndash; يضيف `git clone` إلى الروابط التي تظهر كمستودعات git.
* `git_commit_add` &ndash; يقترح `git commit -a ...` أو `git commit -p ...` إذا فشل الالتزام السابق؛
* `git_commit_amend` &ndash; يقترح `git commit --amend` بعد الالتزام السابق؛
* `git_commit_reset` &ndash; يقترح `git reset HEAD~` بعد الالتزام السابق؛
* `git_diff_no_index` &ndash; يضيف `--no-index` إلى `git diff` السابق على الملفات غير المتعقبة؛
* `git_diff_staged` &ndash; يضيف `--staged` إلى `git diff` السابق عند وجود ناتج غير متوقع؛
* `git_fix_stash` &ndash; يصحح أوامر `git stash`؛
* `git_flag_after_filename` &ndash; يصحح الخطأ `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; يصحح أوامر `git help <alias>` باستبدال <alias> بالأمر الأصلي؛
* `git_hook_bypass` &ndash; يضيف علامة `--no-verify` قبل `git am` أو `git commit` أو `git push`;
* `git_lfs_mistype` &ndash; يصحح أوامر `git lfs <command>` المكتوبة بشكل خاطئ؛
* `git_main_master` &ndash; يصحح اسم الفرع بين `main` و`master`
* `git_merge` &ndash; يضيف الريموت إلى أسماء الفروع؛
* `git_merge_unrelated` &ndash; يضيف `--allow-unrelated-histories` عند الحاجة؛
* `git_not_command` &ndash; يصحح أوامر git الخاطئة مثل `git brnch`;
* `git_pull` &ndash; يضبط الـ upstream قبل تنفيذ `git pull` السابق؛
* `git_pull_clone` &ndash; يستنسخ بدلاً من السحب عند عدم وجود المستودع؛
* `git_pull_uncommitted_changes` &ndash; يخزن التغييرات قبل السحب ثم يعيدها بعد ذلك؛
* `git_push` &ndash; يضيف `--set-upstream origin $branch` إلى `git push` الفاشلة؛
* `git_push_different_branch_names` &ndash; يصحح الدفع عند اختلاف أسماء الفروع المحلية والبعيدة؛
* `git_push_pull` &ndash; يشغل `git pull` عند رفض الدفع؛
* `git_push_without_commits` &ndash; ينشئ أول التزام إذا نسيت وقمت فقط بـ `git add .` عند إعداد مشروع جديد؛
* `git_rebase_no_changes` &ndash; يشغل `git rebase --skip` بدلاً من `git rebase --continue` عند عدم وجود تغييرات؛
* `git_remote_delete` &ndash; يستبدل `git remote delete remote_name` بـ `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; يضيف `-f` أو `--cached` عند محاولة إزالة ملف معدل محلياً؛
* `git_rm_recursive` &ndash; يضيف `-r` عند محاولة إزالة مجلد؛
* `git_rm_staged` &ndash; يضيف `-f` أو `--cached` عند محاولة إزالة ملف به تغييرات في الـ stage؛
* `git_rebase_merge_dir` &ndash; يقترح أوامر `git rebase (--continue | --abort | --skip)` أو إزالة مجلد `.git/rebase-merge` عند وجود إعادة ترتيب جارية؛
* `git_remote_seturl_add` &ndash; يشغل `git remote add` عند محاولة `git remote set_url` على ريموت غير موجود؛
* `git_stash` &ndash; يخزن التعديلات المحلية قبل إعادة الترتيب أو تبديل الفرع؛
* `git_stash_pop` &ndash; يضيف التعديلات المحلية قبل استرجاع التخزين ثم يعيد التعيين؛
* `git_tag_force` &ndash; يضيف `--force` إلى `git tag <tagname>` عند وجود العلامة بالفعل؛
* `git_two_dashes` &ndash; يضيف الشرطة الناقصة إلى الأوامر مثل `git commit -amend` أو `git rebase -continue`;
* `go_run` &ndash; يضيف امتداد `.go` عند تجميع/تشغيل برامج Go؛
* `go_unknown_command` &ndash; يصحح أوامر go الخاطئة، مثل `go bulid`;
* `gradle_no_task` &ndash; يصحح مهمة gradle المفقودة أو الغامضة؛
* `gradle_wrapper` &ndash; يستبدل `gradle` بـ `./gradlew`;
* `grep_arguments_order` &ndash; يصحح ترتيب وسيطات grep في حالات مثل `grep -lir . test`;
* `grep_recursive` &ndash; يضيف `-r` عند محاولة grep على مجلد؛
* `grunt_task_not_found` &ndash; يصحح أوامر grunt المكتوبة بشكل خاطئ؛
* `gulp_not_task` &ndash; يصحح مهام gulp المكتوبة بشكل خاطئ؛
* `has_exists_script` &ndash; يضيف `./` عند وجود سكريبت/ملف تنفيذي؛
* `heroku_multiple_apps` &ndash; يضيف `--app <app>` إلى أوامر heroku مثل `heroku pg`;
* `heroku_not_command` &ndash; يصحح أوامر heroku الخاطئة مثل `heroku log`;
* `history` &ndash; يحاول استبدال الأمر بأقرب أمر مشابه من السجل؛
* `hostscli` &ndash; يحاول تصحيح استخدام hostscli؛
* `ifconfig_device_not_found` &ndash; يصحح أسماء الأجهزة الخاطئة مثل `wlan0` إلى `wlp2s0`;
* `java` &ndash; يزيل امتداد `.java` عند تشغيل برامج جافا؛
* `javac` &ndash; يضيف الامتداد `.java` المفقود عند تجميع ملفات جافا؛
* `lein_not_task` &ndash; يصحح مهام lein الخاطئة مثل `lein rpl`;
* `long_form_help` &ndash; يغير `-h` إلى `--help` عند عدم دعم النسخة المختصرة؛
* `ln_no_hard_link` &ndash; يكشف عن محاولة إنشاء رابط ثابت لمجلد ويقترح رابط رمزي؛
* `ln_s_order` &ndash; يصحح ترتيب وسائط `ln -s`;
* `ls_all` &ndash; يضيف `-A` إلى ls عند خروج ناتج فارغ؛
* `ls_lah` &ndash; يضيف `-lah` إلى ls؛
* `man` &ndash; يغير قسم الدليل؛
* `man_no_space` &ndash; يصحح أوامر man بدون مسافات، مثل `mandiff`;
* `mercurial` &ndash; يصحح أوامر hg الخاطئة؛
* `missing_space_before_subcommand` &ndash; يصحح الأوامر بدون مسافة مثل `npminstall`;
* `mkdir_p` &ndash; يضيف `-p` عند محاولة إنشاء مجلد بدون أصل؛
* `mvn_no_command` &ndash; يضيف `clean package` إلى `mvn`;
* `mvn_unknown_lifecycle_phase` &ndash; يصحح مراحل lifecycle المكتوبة بشكل خاطئ مع mvn؛
* `npm_missing_script` &ndash; يصحح اسم السكريبت المخصص في `npm run-script <script>`;
* `npm_run_script` &ndash; يضيف `run-script` المفقود للسكريبتات المخصصة في npm؛
* `npm_wrong_command` &ndash; يصحح أوامر npm الخاطئة مثل `npm urgrade`;
* `no_command` &ndash; يصحح أوامر الطرفية الخاطئة، مثل `vom/vim`;
* `no_such_file` &ndash; ينشئ المجلدات المفقودة مع أوامر mv و cp؛
* `omnienv_no_such_command` &ndash; يصحح أوامر goenv و nodenv و pyenv و rbenv الخاطئة؛
* `open` &ndash; يضيف `http://` إلى العنوان أو ينشئ ملفاً/مجلداً جديداً ويمرره إلى open؛
* `pip_install` &ndash; يصحح مشاكل الصلاحيات في pip install بإضافة `--user` أو `sudo`؛
* `pip_unknown_command` &ndash; يصحح أوامر pip الخاطئة مثل `pip instatl/pip install`;
* `php_s` &ndash; يستبدل `-s` بـ `-S` عند محاولة تشغيل خادم php محلي؛
* `port_already_in_use` &ndash; يقتل العملية التي تستخدم المنفذ؛
* `prove_recursively` &ndash; يضيف `-r` عند استدعاء المجلد؛
* `python_command` &ndash; يضيف `python` عند محاولة تشغيل سكريبت بايثون غير قابل للتنفيذ؛
* `python_execute` &ndash; يضيف الامتداد `.py` المفقود عند تنفيذ ملفات بايثون؛
* `python_module_error` &ndash; يصحح ModuleNotFoundError بمحاولة تثبيت الوحدة؛
* `quotation_marks` &ndash; يصحح الاستخدام غير المتساوي لـ `'` و `"` في الوسائط؛
* `path_from_history` &ndash; يستبدل المسار غير الموجود بمسار مماثل من السجل؛
* `rails_migrations_pending` &ndash; يشغل الهجرات المعلقة؛
* `react_native_command_unrecognized` &ndash; يصحح أوامر react-native غير المعروفة؛
* `remove_shell_prompt_literal` &ndash; يزيل رمز موجه الصدفة `$` عند نسخ الأوامر من الوثائق؛
* `remove_trailing_cedilla` &ndash; يزيل cedilla `ç` في نهاية الأمر، وهو خطأ شائع في لوحات المفاتيح الأوروبية؛
* `rm_dir` &ndash; يضيف `-rf` عند محاولة حذف مجلد؛
* `scm_correction` &ndash; يصحح scm الخاطئ مثل `hg log` إلى `git log`;
* `sed_unterminated_s` &ndash; يضيف `/` المفقود في أوامر sed من نوع s؛
* `sl_ls` &ndash; يغير `sl` إلى `ls`;
* `ssh_known_hosts` &ndash; يزيل المضيف من known_hosts عند ظهور تحذير؛
* `sudo` &ndash; يضيف `sudo` للأمر السابق إذا فشل بسبب الصلاحيات؛
* `sudo_command_from_user_path` &ndash; يشغل الأوامر من `$PATH` للمستخدم باستخدام sudo؛
* `switch_lang` &ndash; يبدّل الأمر من تخطيطك المحلي إلى الإنجليزية؛
* `systemctl` &ndash; يرتب وسيطات systemctl بشكل صحيح؛
* `terraform_init.py` &ndash; يشغل `terraform init` قبل plan أو apply؛
* `terraform_no_command.py` &ndash; يصحح أوامر terraform غير المعروفة؛
* `test.py` &ndash; يشغل pytest بدلاً من test.py؛
* `touch` &ndash; ينشئ المجلدات المفقودة قبل استخدام touch؛
* `tsuru_login` &ndash; يشغل tsuru login إذا لم يكن هناك مصادقة أو انتهت الجلسة؛
* `tsuru_not_command` &ndash; يصحح أوامر tsuru الخاطئة مثل `tsuru shell`;
* `tmux` &ndash; يصحح أوامر tmux؛
* `unknown_command` &ndash; يصحح أوامر hadoop hdfs من نوع "unknown command"؛
* `unsudo` &ndash; يزيل sudo من الأمر السابق إذا رفضت العملية العمل بصلاحيات الجذر؛
* `vagrant_up` &ndash; يشغّل نسخة vagrant؛
* `whois` &ndash; يصحح أمر whois؛
* `workon_doesnt_exists` &ndash; يصحح اسم بيئة virtualenvwrapper أو يقترح إنشاء واحدة جديدة.
* `wrong_hyphen_before_subcommand` &ndash; يزيل الشرطة الموضوعة بشكل خاطئ (`apt-install` -> `apt install`, `git-log` -> `git log`, إلخ)
* `yarn_alias` &ndash; يصحح أوامر yarn المستعارة مثل `yarn ls`;
* `yarn_command_not_found` &ndash; يصحح أوامر yarn المكتوبة بشكل خاطئ؛
* `yarn_command_replaced` &ndash; يصحح أوامر yarn المستبدلة؛
* `yarn_help` &ndash; يسهل فتح توثيق yarn؛

##### [العودة إلى الفهرس](#contents)

القواعد التالية مفعلة بشكل افتراضي فقط على منصات محددة:

* `apt_get` &ndash; يثبت التطبيقات من apt إذا لم تكن مثبتة (يتطلب `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; يغير محاولة البحث باستخدام `apt-get` إلى البحث باستخدام `apt-cache`;
* `apt_invalid_operation` &ndash; يصحح أوامر apt و apt-get غير الصالحة، مثل `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; يساعدك على تشغيل `apt list --upgradable` بعد `apt update`;
* `apt_upgrade` &ndash; يساعدك على تشغيل `apt upgrade` بعد `apt list --upgradable`;
* `brew_cask_dependency` &ndash; يثبت تبعيات cask؛
* `brew_install` &ndash; يصحح اسم الصيغة في `brew install`;
* `brew_reinstall` &ndash; يحول `brew install <formula>` إلى `brew reinstall <formula>`;
* `brew_link` &ndash; يضيف `--overwrite --dry-run` إذا فشل الربط؛
* `brew_uninstall` &ndash; يضيف `--force` إلى `brew uninstall` إذا كانت هناك نسخ متعددة مثبتة؛
* `brew_unknown_command` &ndash; يصحح أوامر brew الخاطئة مثل `brew docto/brew doctor`;
* `brew_update_formula` &ndash; يحول `brew update <formula>` إلى `brew upgrade <formula>`;
* `dnf_no_such_command` &ndash; يصحح أوامر DNF المكتوبة بشكل خاطئ؛
* `nixos_cmd_not_found` &ndash; يثبت التطبيقات على NixOS؛
* `pacman` &ndash; يثبت التطبيقات مع pacman إذا لم تكن مثبتة (يستخدم yay أو pikaur أو yaourt إذا كانت متوفرة)؛
* `pacman_invalid_option` &ndash; يستبدل خيارات pacman الصغيرة بأحرف كبيرة.
* `pacman_not_found` &ndash; يصحح اسم الحزمة مع pacman أو yay أو pikaur أو yaourt.
* `yum_invalid_operation` &ndash; يصحح أوامر yum غير الصالحة مثل `yum isntall vim`;

الأوامر التالية مضمنة مع *The Fuck* ولكنها غير مفعلة افتراضياً:

* `git_push_force` &ndash; يضيف `--force-with-lease` إلى `git push` (قد يتعارض مع `git_push_pull`);
* `rm_root` &ndash; يضيف `--no-preserve-root` إلى أمر `rm -rf /`.

##### [العودة إلى الفهرس](#contents)

## إنشاء قواعدك الخاصة

لإضافة قاعدة خاصة بك، أنشئ ملفاً باسم `your-rule-name.py`
في `~/.config/thefuck/rules`. يجب أن يحتوي ملف القاعدة على دالتين:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

بالإضافة إلى ذلك، يمكن أن تحتوي القواعد على دوال اختيارية:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
يمكن أن تحتوي القواعد أيضاً على المتغيرات الاختيارية `enabled_by_default` و `requires_output` و `priority`.

يحتوي كائن `Command` على ثلاث خصائص: `script`, `output` و `script_parts`.
يجب ألا تغيّر القاعدة كائن `Command`.


**تغيّر واجهة برمجة تطبيقات القواعد في 3.0:** للوصول إلى إعدادات القاعدة، استخدم
 `from thefuck.conf import settings`

كائن `settings` يتم تجميعه من `~/.config/thefuck/settings.py`،
وقيم من المتغيرات البيئية ([انظر المزيد أدناه](#settings)).

مثال بسيط لقاعدة لتشغيل سكريبت باستخدام sudo:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# اختياري:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # الأقل أولاً، الافتراضي 1000

requires_output = True
```

[المزيد من أمثلة القواعد](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[دوال مساعدة للقواعد](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[مساعدات خاصة بالتطبيق/النظام](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [العودة إلى الفهرس](#contents)

## الإعدادات

يمكن تعديل عدة معلمات في *The Fuck* في الملف `$XDG_CONFIG_HOME/thefuck/settings.py`
(افتراضياً `$XDG_CONFIG_HOME` هو `~/.config`):

* `rules` &ndash; قائمة القواعد المفعلة، افتراضياً `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; قائمة القواعد المعطلة، افتراضياً `[]`;
* `require_confirmation` &ndash; يتطلب التأكيد قبل تشغيل الأمر الجديد، افتراضياً `True`;
* `wait_command` &ndash; الحد الأقصى بالثواني للحصول على إخراج الأمر السابق؛
* `no_colors` &ndash; تعطيل الإخراج الملون؛
* `priority` &ndash; معجم بأولويات القواعد، القاعدة ذات الأولوية الأقل يتم مطابقتها أولاً؛
* `debug` &ndash; تفعيل إخراج التصحيح، افتراضياً `False`;
* `history_limit` &ndash; القيمة العددية لعدد أوامر السجل التي سيتم فحصها، مثل `2000`;
* `alter_history` &ndash; إضافة الأمر المصحح للسجل، افتراضياً `True`;
* `wait_slow_command` &ndash; الحد الأقصى بالثواني للحصول على إخراج الأمر السابق إذا كان في قائمة `slow_commands`;
* `slow_commands` &ndash; قائمة بالأوامر البطيئة؛
* `num_close_matches` &ndash; الحد الأقصى لعدد الاقتراحات المتشابهة، افتراضياً `3`.
* `excluded_search_path_prefixes` &ndash; بادئات المسارات التي يجب تجاهلها عند البحث عن الأوامر، افتراضياً `[]`.

مثال على `settings.py`:

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

أو عبر المتغيرات البيئية:

* `THEFUCK_RULES` &ndash; قائمة القواعد المفعلة، مثل `DEFAULT_RULES:rm_root` أو `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; قائمة القواعد المعطلة، مثل `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; يتطلب التأكيد قبل تشغيل الأمر الجديد، `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; الحد الأقصى بالثواني للحصول على إخراج الأمر السابق؛
* `THEFUCK_NO_COLORS` &ndash; تعطيل الإخراج الملون، `true/false`;
* `THEFUCK_PRIORITY` &ndash; أولوية القواعد، مثل `no_command=9999:apt_get=100`,
القاعدة ذات الأولوية الأقل يتم مطابقتها أولاً؛
* `THEFUCK_DEBUG` &ndash; تفعيل إخراج التصحيح، `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; عدد أوامر السجل التي سيتم فحصها، مثل `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; إضافة الأمر المصحح للسجل `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; الحد الأقصى بالثواني للحصول على إخراج الأمر السابق إذا كان في قائمة `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` &ndash; قائمة الأوامر البطيئة، مثل `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; الحد الأقصى لعدد الاقتراحات المتشابهة، مثل `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; بادئات المسارات لتجاهلها عند البحث عن الأوامر، افتراضياً `[]`.

مثال:

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

##### [العودة إلى الفهرس](#contents)

## حزم طرف ثالث مع قواعد

إذا كنت ترغب في إنشاء مجموعة قواعد غير عامة، ولكنك تريد مشاركتها مع الآخرين، أنشئ حزمة باسم `thefuck_contrib_*` بالهيكل التالي:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *قواعد الطرف الثالث*
    __init__.py
    *أدوات الطرف الثالث*
  setup.py
```

سيجد *The Fuck* القواعد الموجودة في وحدة `rules`.

##### [العودة إلى الفهرس](#contents)

## وضع السرعة الفورية التجريبي

السلوك الافتراضي لـ *The Fuck* يتطلب وقتاً لإعادة تشغيل الأوامر السابقة.
في وضع السرعة الفورية، يوفر *The Fuck* الوقت عبر تسجيل الإخراج باستخدام [script](https://en.wikipedia.org/wiki/Script_(Unix))، ثم قراءة السجل.

[![gif مع وضع السرعة الفورية][instant-mode-gif-link]][instant-mode-gif-link]

حالياً، وضع السرعة الفورية يدعم فقط Python 3 مع bash أو zsh. يجب أيضاً تعطيل خاصية التصحيح التلقائي في zsh ليعمل thefuck بشكل صحيح.

لتفعيل وضع السرعة الفورية، أضف `--enable-experimental-instant-mode`
إلى تهيئة الاسم المستعار في `.bashrc` أو `.bash_profile` أو `.zshrc`.

مثال:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [العودة إلى الفهرس](#contents)

## التطوير

انظر [CONTRIBUTING.md](CONTRIBUTING.md)

## رخصة MIT
يمكن العثور على رخصة المشروع [هنا](LICENSE.md).


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

##### [العودة إلى الفهرس](#contents)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---