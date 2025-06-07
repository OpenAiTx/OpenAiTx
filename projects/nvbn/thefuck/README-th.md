# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* คือแอปพลิเคชันที่ยอดเยี่ยม ได้รับแรงบันดาลใจจาก [@liamosaur](https://twitter.com/liamosaur/)
[tweet](https://twitter.com/liamosaur/status/506975850596536320),
ที่ช่วยแก้ไขข้อผิดพลาดในคำสั่งคอนโซลก่อนหน้า

*The Fuck* ช้าจนเกินไปหรือไม่? [ลองโหมด Instant แบบทดลอง!](#experimental-instant-mode)

[![gif with examples][examples-link]][examples-link]

ตัวอย่างเพิ่มเติม:

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

หากคุณไม่กลัวที่จะรันคำสั่งที่ได้รับการแก้ไขโดยไม่ตรวจสอบ `require_confirmation` [ตัวเลือกการตั้งค่า](#settings) สามารถปิดการใช้งานได้:

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

## สารบัญ

1. [ความต้องการ](#requirements)
2. [การติดตั้ง](#installation)
3. [อัปเดต](#updating)
4. [วิธีการทำงาน](#how-it-works)
5. [สร้างกฎของคุณเอง](#creating-your-own-rules)
6. [การตั้งค่า](#settings)
7. [แพ็กเกจบุคคลที่สามพร้อมกฎ](#third-party-packages-with-rules)
8. [โหมด Instant แบบทดลอง](#experimental-instant-mode)
9. [การพัฒนา](#developing)
10. [ไลเซนส์](#license-mit)

## ความต้องการ

- python (3.5+)
- pip
- python-dev

##### [กลับไปที่สารบัญ](#contents)

## การติดตั้ง

บน macOS หรือ Linux คุณสามารถติดตั้ง *The Fuck* ผ่าน [Homebrew][homebrew]:

```bash
brew install thefuck
```

บน Ubuntu / Mint ติดตั้ง *The Fuck* ด้วยคำสั่งต่อไปนี้:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

บน FreeBSD ติดตั้ง *The Fuck* ด้วยคำสั่งต่อไปนี้:
```bash
pkg install thefuck
```

บน ChromeOS ติดตั้ง *The Fuck* โดยใช้ [chromebrew](https://github.com/skycocker/chromebrew) ด้วยคำสั่งต่อไปนี้:
```bash
crew install thefuck
```

บนระบบที่ใช้ Arch ติดตั้ง *The Fuck* ด้วยคำสั่งต่อไปนี้:
```
sudo pacman -S thefuck
```

บนระบบอื่น ๆ ติดตั้ง *The Fuck* โดยใช้ `pip`:

```bash
pip install thefuck
```

[หรือคุณอาจใช้ตัวจัดการแพ็คเกจของ OS (OS X, Ubuntu, Arch)](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
แนะนำให้คุณเพิ่มคำสั่งนี้ในไฟล์ `.bash_profile`, `.bashrc`, `.zshrc` หรือสคริปต์เริ่มต้นอื่น ๆ ของคุณ:

```bash
eval $(thefuck --alias)
# คุณสามารถใช้ alias อื่น ๆ ได้ เช่นสำหรับวันจันทร์:
eval $(thefuck --alias FUCK)
```

[หรือใน config ของ shell ของคุณ (Bash, Zsh, Fish, Powershell, tcsh)](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

การเปลี่ยนแปลงจะมีผลเฉพาะในเซสชัน shell ใหม่ หากต้องการให้เปลี่ยนแปลงมีผลทันที ให้รัน `source ~/.bashrc` (หรือ config shell ของคุณ เช่น `.zshrc`)

หากต้องการรันคำสั่งที่ได้รับการแก้ไขโดยไม่ต้องยืนยัน ให้ใช้ตัวเลือก `--yeah` (หรือแค่ `-y` สำหรับสั้น ๆ หรือ `--hard` หากคุณหงุดหงิดมาก):

```bash
fuck --yeah
```

หากต้องการแก้ไขคำสั่งแบบ recursive จนกว่าจะสำเร็จ ให้ใช้ตัวเลือก `-r`:

```bash
fuck -r
```

##### [กลับไปที่สารบัญ](#contents)

## อัปเดต

```bash
pip3 install thefuck --upgrade
```

**หมายเหตุ: ฟังก์ชัน alias มีการเปลี่ยนแปลงใน v1.34 ของ *The Fuck***

## ถอนการติดตั้ง

เมื่อต้องการลบ *The Fuck* ให้ย้อนกระบวนการติดตั้ง:
- ลบหรือ comment บรรทัด alias *thefuck* ออกจาก config ของ shell เช่น Bash, Zsh, Fish, Powershell, tcsh, ...
- ใช้ package manager ของคุณ (brew, pip3, pkg, crew, pip) เพื่อลบไบนารี

## วิธีการทำงาน

*The Fuck* จะพยายามจับคู่คำสั่งก่อนหน้ากับกฎ หากพบการจับคู่ จะสร้างคำสั่งใหม่โดยใช้กฎที่จับคู่ได้และดำเนินการ ค่าต่อไปนี้คือกฎที่เปิดใช้งานโดยค่าเริ่มต้น:

* `adb_unknown_command` – แก้ไขคำสั่งที่สะกดผิด เช่น `adb logcta`
* `ag_literal` – เพิ่ม `-Q` ให้ `ag` เมื่อมีการแนะนำ
* `aws_cli` – แก้ไขคำสั่งที่สะกดผิด เช่น `aws dynamdb scan`
* `az_cli` – แก้ไขคำสั่งที่สะกดผิด เช่น `az providers`
* `cargo` – รัน `cargo build` แทน `cargo`
* `cargo_no_command` – แก้ไขคำสั่งผิด เช่น `cargo buid`
* `cat_dir` – แทนที่ `cat` ด้วย `ls` เมื่อคุณพยายาม `cat` ไดเรกทอรี
* `cd_correction` – ตรวจสอบการสะกดและแก้ไขคำสั่ง cd ที่ล้มเหลว
* `cd_cs` – เปลี่ยน `cs` เป็น `cd`
* `cd_mkdir` – สร้างไดเรกทอรีก่อน cd เข้าไป
* `cd_parent` – เปลี่ยน `cd..` เป็น `cd ..`
* `chmod_x` – เพิ่มสิทธิ์การรัน
* `choco_install` – เติมคำลงท้ายที่พบบ่อยสำหรับแพ็คเกจ chocolatey
* `composer_not_command` – แก้ไขชื่อคำสั่ง composer
* `conda_mistype` – แก้ไขคำสั่ง conda ที่ผิด
* `cp_create_destination` – สร้างไดเรกทอรีใหม่เมื่อคุณพยายาม `cp` หรือ `mv` ไปยังที่ที่ไม่มีอยู่
* `cp_omitting_directory` – เพิ่ม `-a` เมื่อคุณ `cp` ไดเรกทอรี
* `cpp11` – เพิ่ม `-std=c++11` ที่ขาดหายให้ `g++` หรือ `clang++`
* `dirty_untar` – แก้ไขคำสั่ง `tar x` ที่ untar ในไดเรกทอรีปัจจุบัน
* `dirty_unzip` – แก้ไขคำสั่ง `unzip` ที่ unzip ในไดเรกทอรีปัจจุบัน
* `django_south_ghost` – เพิ่ม `--delete-ghost-migrations` ให้ migration south ของ django ที่ล้มเหลวเพราะ ghost
* `django_south_merge` – เพิ่ม `--merge` ให้ migration south ของ django ที่ไม่สอดคล้องกัน
* `docker_login` – ดำเนินการ `docker login` แล้วรันคำสั่งก่อนหน้าอีกครั้ง
* `docker_not_command` – แก้ไขคำสั่ง docker ที่ผิด เช่น `docker tags`
* `docker_image_being_used_by_container` – ลบ container ที่ใช้ image ก่อนลบ image
* `dry` – แก้ไขการซ้ำซ้อน เช่น `git git push`
* `fab_command_not_found` – แก้ไขคำสั่ง fabric ที่สะกดผิด
* `fix_alt_space` – แทนที่ Alt+Space ด้วย Space ปกติ
* `fix_file` – เปิดไฟล์ที่มี error ด้วย `$EDITOR` ของคุณ
* `gem_unknown_command` – แก้ไขคำสั่ง `gem` ที่ผิด
* `git_add` – แก้ไข *"pathspec 'foo' did not match any file(s) known to git."*
* `git_add_force` – เพิ่ม `--force` ให้ `git add <pathspec>...` เมื่อ path อยู่ใน .gitignore
* `git_bisect_usage` – แก้ไข `git bisect strt`, `git bisect goood`, `git bisect rset` ฯลฯ ขณะ bisecting
* `git_branch_delete` – เปลี่ยน `git branch -d` เป็น `git branch -D`
* `git_branch_delete_checked_out` – เปลี่ยน `git branch -d` เป็น `git checkout master && git branch -D` เมื่อพยายามลบ branch ที่ checkout อยู่
* `git_branch_exists` – เสนอตัวเลือก `git branch -d foo`, `git branch -D foo` หรือ `git checkout foo` เมื่อสร้าง branch ที่มีอยู่แล้ว
* `git_branch_list` – ดักจับ `git branch list` แทน `git branch` และลบ branch ที่สร้าง
* `git_branch_0flag` – แก้ไขคำสั่ง เช่น `git branch 0v` และ `git branch 0r` โดยลบ branch ที่สร้าง
* `git_checkout` – แก้ไขชื่อ branch หรือสร้าง branch ใหม่
* `git_clone_git_clone` – แทนที่ `git clone git clone ...` ด้วย `git clone ...`
* `git_clone_missing` – เพิ่ม `git clone` ให้ URL ที่ดูเหมือนจะเป็น git repository
* `git_commit_add` – เสนอ `git commit -a ...` หรือ `git commit -p ...` หลัง commit ก่อนหน้าหากล้มเหลวเพราะไม่มี stage
* `git_commit_amend` – เสนอ `git commit --amend` หลัง commit ก่อนหน้า
* `git_commit_reset` – เสนอ `git reset HEAD~` หลัง commit ก่อนหน้า
* `git_diff_no_index` – เพิ่ม `--no-index` ให้ `git diff` ก่อนหน้าบนไฟล์ที่ไม่ได้ track
* `git_diff_staged` – เพิ่ม `--staged` ให้ `git diff` ก่อนหน้าที่ output ผิดปกติ
* `git_fix_stash` – แก้ไขคำสั่ง `git stash` (subcommand ผิดและขาด `save`)
* `git_flag_after_filename` – แก้ไข `fatal: bad flag '...' after filename`
* `git_help_aliased` – แก้ไขคำสั่ง `git help <alias>` โดยแทนที่ <alias> ด้วยคำสั่งที่ alias ไว้
* `git_hook_bypass` – เพิ่ม flag `--no-verify` ก่อน `git am`, `git commit` หรือ `git push`
* `git_lfs_mistype` – แก้ไขคำสั่ง `git lfs <command>` ที่สะกดผิด
* `git_main_master` – แก้ไขชื่อ branch ระหว่าง `main` และ `master` ที่ไม่ถูกต้อง
* `git_merge` – เพิ่ม remote ให้ชื่อ branch
* `git_merge_unrelated` – เพิ่ม `--allow-unrelated-histories` เมื่อจำเป็น
* `git_not_command` – แก้ไขคำสั่ง git ที่ผิด เช่น `git brnch`
* `git_pull` – ตั้งค่า upstream ก่อนรัน `git pull` ก่อนหน้า
* `git_pull_clone` – clone แทนการ pull เมื่อ repo ไม่มีอยู่
* `git_pull_uncommitted_changes` – stash การเปลี่ยนแปลงก่อน pull และ pop หลังจากนั้น
* `git_push` – เพิ่ม `--set-upstream origin $branch` ให้ `git push` ที่ล้มเหลวก่อนหน้า
* `git_push_different_branch_names` – แก้ไขการ push เมื่อชื่อ branch local ไม่ตรงกับ remote
* `git_push_pull` – รัน `git pull` เมื่อ `push` ถูกปฏิเสธ
* `git_push_without_commits` – สร้าง initial commit หากคุณลืมและมีแค่ `git add .` ขณะตั้งโปรเจกต์ใหม่
* `git_rebase_no_changes` – รัน `git rebase --skip` แทน `git rebase --continue` เมื่อไม่มีการเปลี่ยนแปลง
* `git_remote_delete` – แทนที่ `git remote delete remote_name` ด้วย `git remote remove remote_name`
* `git_rm_local_modifications` – เพิ่ม `-f` หรือ `--cached` เมื่อคุณพยายาม `rm` ไฟล์ที่แก้ไขแบบ local
* `git_rm_recursive` – เพิ่ม `-r` เมื่อคุณพยายาม `rm` ไดเรกทอรี
* `git_rm_staged` – เพิ่ม `-f` หรือ `--cached` เมื่อคุณพยายาม `rm` ไฟล์ที่มีการ staged
* `git_rebase_merge_dir` – เสนอ `git rebase (--continue | --abort | --skip)` หรือการลบ dir `.git/rebase-merge` เมื่อ rebase กำลังดำเนินการอยู่
* `git_remote_seturl_add` – รัน `git remote add` เมื่อ `git remote set_url` กับ remote ที่ไม่มีอยู่
* `git_stash` – stash การแก้ไข local ก่อน rebase หรือเปลี่ยน branch
* `git_stash_pop` – เพิ่มการแก้ไข local ก่อน pop stash แล้ว reset
* `git_tag_force` – เพิ่ม `--force` ให้ `git tag <tagname>` เมื่อ tag มีอยู่แล้ว
* `git_two_dashes` – เพิ่ม dash ที่ขาดหายให้คำสั่ง เช่น `git commit -amend` หรือ `git rebase -continue`
* `go_run` – เติมนามสกุล `.go` เมื่อ compile/รันโปรแกรม Go
* `go_unknown_command` – แก้ไขคำสั่ง go ที่ผิด เช่น `go bulid`
* `gradle_no_task` – แก้ไข task `gradle` ที่ไม่พบหรือคลุมเครือ
* `gradle_wrapper` – แทนที่ `gradle` ด้วย `./gradlew`
* `grep_arguments_order` – แก้ไขลำดับ arguments ของ `grep` เช่น `grep -lir . test`
* `grep_recursive` – เพิ่ม `-r` เมื่อคุณพยายาม `grep` ไดเรกทอรี
* `grunt_task_not_found` – แก้ไขคำสั่ง `grunt` ที่สะกดผิด
* `gulp_not_task` – แก้ไข task `gulp` ที่สะกดผิด
* `has_exists_script` – เติม `./` เมื่อ script/binary มีอยู่
* `heroku_multiple_apps` – เพิ่ม `--app <app>` ให้คำสั่ง heroku เช่น `heroku pg`
* `heroku_not_command` – แก้ไขคำสั่ง heroku ที่ผิด เช่น `heroku log`
* `history` – พยายามแทนที่คำสั่งด้วยคำสั่งที่คล้ายที่สุดจาก history
* `hostscli` – พยายามแก้ไขการใช้งาน `hostscli`
* `ifconfig_device_not_found` – แก้ไขชื่ออุปกรณ์ผิด เช่น `wlan0` เป็น `wlp2s0`
* `java` – ลบส่วนขยาย `.java` เมื่อรันโปรแกรม Java
* `javac` – เติม `.java` ที่ขาดหายเมื่อ compile ไฟล์ Java
* `lein_not_task` – แก้ไข task `lein` ที่ผิด เช่น `lein rpl`
* `long_form_help` – เปลี่ยน `-h` เป็น `--help` เมื่อแบบสั้นไม่รองรับ
* `ln_no_hard_link` – ดักจับการสร้าง hard link บนไดเรกทอรี แนะนำ symbolic link
* `ln_s_order` – แก้ไขลำดับ arguments ของ `ln -s`
* `ls_all` – เพิ่ม `-A` ให้ `ls` เมื่อ output ว่างเปล่า
* `ls_lah` – เพิ่ม `-lah` ให้ `ls`
* `man` – เปลี่ยน section ของคู่มือ
* `man_no_space` – แก้ไข man ที่ไม่มีช่องว่าง เช่น `mandiff`
* `mercurial` – แก้ไขคำสั่ง hg ที่ผิด
* `missing_space_before_subcommand` – แก้ไขคำสั่งที่ขาดช่องว่าง เช่น `npminstall`
* `mkdir_p` – เพิ่ม `-p` เมื่อคุณพยายามสร้างไดเรกทอรีโดยไม่มี parent
* `mvn_no_command` – เพิ่ม `clean package` ให้ `mvn`
* `mvn_unknown_lifecycle_phase` – แก้ไข phase ที่สะกดผิดของ lifecycle ใน `mvn`
* `npm_missing_script` – แก้ไขชื่อ script custom ใน `npm run-script <script>`
* `npm_run_script` – เพิ่ม `run-script` ที่ขาดหายสำหรับ custom script
* `npm_wrong_command` – แก้ไขคำสั่ง npm ที่ผิด เช่น `npm urgrade`
* `no_command` – แก้ไขคำสั่งคอนโซลที่ผิด เช่น `vom/vim`
* `no_such_file` – สร้างไดเรกทอรีที่ขาดหายกับคำสั่ง `mv` และ `cp`
* `omnienv_no_such_command` – แก้ไขคำสั่งผิดสำหรับ `goenv`, `nodenv`, `pyenv` และ `rbenv` (เช่น `pyenv isntall` หรือ `goenv list`)
* `open` – เติม `http://` ให้ address ที่ส่งให้ `open` หรือสร้างไฟล์/ไดเรกทอรีใหม่แล้วส่งให้ `open`
* `pip_install` – แก้ไขปัญหาสิทธิ์กับ `pip install` ด้วยการเพิ่ม `--user` หรือเติม `sudo` หากจำเป็น
* `pip_unknown_command` – แก้ไขคำสั่ง pip ที่ผิด เช่น `pip instatl/pip install`
* `php_s` – แทนที่ `-s` ด้วย `-S` เมื่อรัน php server local
* `port_already_in_use` – ฆ่า process ที่ bind port ไว้
* `prove_recursively` – เพิ่ม `-r` เมื่อเรียกใช้กับไดเรกทอรี
* `python_command` – เติม `python` เมื่อคุณพยายามรัน python script ที่ไม่ executable/ไม่มี `./`
* `python_execute` – เติม `.py` ที่ขาดหายเมื่อรันไฟล์ Python
* `python_module_error` – แก้ไข ModuleNotFoundError ด้วยการพยายาม `pip install` module นั้น
* `quotation_marks` – แก้ไขการใช้ `'` และ `"` ที่ไม่เท่ากันเมื่อมี args
* `path_from_history` – แทน path ที่ไม่พบด้วย absolute path ที่คล้ายจาก history
* `rails_migrations_pending` – รัน migration ที่ยังไม่ได้ทำ
* `react_native_command_unrecognized` – แก้ไขคำสั่ง `react-native` ที่ไม่รู้จัก
* `remove_shell_prompt_literal` – ลบเครื่องหมาย prompt shell `$` ที่นำหน้าเมื่อ copy คำสั่งจากเอกสาร
* `remove_trailing_cedilla` – ลบ cedilla `ç` ที่ตามท้ายซึ่งเป็น typo บนคีย์บอร์ดยุโรป
* `rm_dir` – เพิ่ม `-rf` เมื่อคุณพยายามลบไดเรกทอรี
* `scm_correction` – แก้ไข scm ที่ผิด เช่น `hg log` เป็น `git log`
* `sed_unterminated_s` – เติม '/' ที่ขาดหายให้ `sed`'s `s`
* `sl_ls` – เปลี่ยน `sl` เป็น `ls`
* `ssh_known_hosts` – ลบ host ออกจาก `known_hosts` เมื่อมี warning
* `sudo` – เติม `sudo` ให้คำสั่งก่อนหน้าหากล้มเหลวเพราะสิทธิ์
* `sudo_command_from_user_path` – รันคำสั่งจาก `$PATH` ของผู้ใช้ด้วย `sudo`
* `switch_lang` – สลับคำสั่งจาก layout ท้องถิ่นของคุณเป็น en
* `systemctl` – จัดเรียงพารามิเตอร์ของ `systemctl` ที่สับสนให้ถูกต้อง
* `terraform_init.py` – รัน `terraform init` ก่อน plan หรือ apply
* `terraform_no_command.py` – แก้ไขคำสั่ง `terraform` ที่ไม่รู้จัก
* `test.py` – รัน `pytest` แทน `test.py`
* `touch` – สร้างไดเรกทอรีที่ขาดหายก่อน "touch"
* `tsuru_login` – รัน `tsuru login` หากยังไม่ authenticate หรือ session หมดอายุ
* `tsuru_not_command` – แก้ไขคำสั่ง `tsuru` ที่ผิด เช่น `tsuru shell`
* `tmux` – แก้ไขคำสั่ง `tmux`
* `unknown_command` – แก้ไข hadoop hdfs-style "unknown command" เช่น เติม '-' ที่ขาดหายให้คำสั่งบน `hdfs dfs ls`
* `unsudo` – ลบ `sudo` จากคำสั่งก่อนหน้าหาก process ปฏิเสธการรันบนสิทธิ์ superuser
* `vagrant_up` – สตาร์ทอินสแตนซ์ vagrant
* `whois` – แก้ไขคำสั่ง `whois`
* `workon_doesnt_exists` – แก้ไขชื่อ env `virtualenvwrapper` ที่ไม่มี หรือเสนอให้สร้างใหม่
* `wrong_hyphen_before_subcommand` – ลบ hyphen ที่วางผิด (เช่น `apt-install` -> `apt install`, `git-log` -> `git log`, ฯลฯ)
* `yarn_alias` – แก้ไขคำสั่ง `yarn` ที่ alias เช่น `yarn ls`
* `yarn_command_not_found` – แก้ไขคำสั่ง `yarn` ที่สะกดผิด
* `yarn_command_replaced` – แก้ไขคำสั่ง `yarn` ที่ถูกแทนที่
* `yarn_help` – ช่วยเปิดเอกสาร `yarn` ได้ง่ายขึ้น

##### [กลับไปที่สารบัญ](#contents)

กฎต่อไปนี้เปิดใช้งานโดยค่าเริ่มต้นเฉพาะบางแพลตฟอร์มเท่านั้น:

* `apt_get` – ติดตั้งแอปจาก apt หากยังไม่ได้ติดตั้ง (ต้องการ `python-commandnotfound` / `python3-commandnotfound`)
* `apt_get_search` – เปลี่ยนความพยายามค้นหาด้วย `apt-get` เป็นค้นหาด้วย `apt-cache`
* `apt_invalid_operation` – แก้ไขการเรียก `apt` และ `apt-get` ที่ไม่ถูกต้อง เช่น `apt-get isntall vim`
* `apt_list_upgradable` – ช่วยให้คุณรัน `apt list --upgradable` หลัง `apt update`
* `apt_upgrade` – ช่วยให้คุณรัน `apt upgrade` หลัง `apt list --upgradable`
* `brew_cask_dependency` – ติดตั้ง cask dependencies
* `brew_install` – แก้ไขชื่อสูตรสำหรับ `brew install`
* `brew_reinstall` – เปลี่ยน `brew install <formula>` เป็น `brew reinstall <formula>`
* `brew_link` – เพิ่ม `--overwrite --dry-run` หาก linking ล้มเหลว
* `brew_uninstall` – เพิ่ม `--force` ให้ `brew uninstall` หากติดตั้งหลายเวอร์ชัน
* `brew_unknown_command` – แก้ไขคำสั่ง brew ที่ผิด เช่น `brew docto/brew doctor`
* `brew_update_formula` – เปลี่ยน `brew update <formula>` เป็น `brew upgrade <formula>`
* `dnf_no_such_command` – แก้ไขคำสั่ง DNF ที่สะกดผิด
* `nixos_cmd_not_found` – ติดตั้งแอปบน NixOS
* `pacman` – ติดตั้งแอปด้วย `pacman` หากยังไม่ได้ติดตั้ง (ใช้ `yay`, `pikaur` หรือ `yaourt` หากมี)
* `pacman_invalid_option` – แทนที่ options ตัวพิมพ์เล็กของ `pacman` ด้วยตัวพิมพ์ใหญ่
* `pacman_not_found` – แก้ไขชื่อ package ด้วย `pacman`, `yay`, `pikaur` หรือ `yaourt`
* `yum_invalid_operation` – แก้ไขการเรียก `yum` ที่ไม่ถูกต้อง เช่น `yum isntall vim`

คำสั่งต่อไปนี้รวมอยู่ใน *The Fuck* แต่ไม่ได้เปิดใช้โดยค่าเริ่มต้น:

* `git_push_force` – เพิ่ม `--force-with-lease` ให้ `git push` (อาจขัดแย้งกับ `git_push_pull`)
* `rm_root` – เพิ่ม `--no-preserve-root` ให้คำสั่ง `rm -rf /`

##### [กลับไปที่สารบัญ](#contents)

## สร้างกฎของคุณเอง

หากต้องการเพิ่มกฎของคุณเอง ให้สร้างไฟล์ชื่อ `your-rule-name.py`
ใน `~/.config/thefuck/rules` ไฟล์กฎต้องมีสองฟังก์ชัน:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

นอกจากนี้ กฎสามารถมีฟังก์ชันเสริมได้:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
กฎสามารถมีตัวแปรเสริม `enabled_by_default`, `requires_output` และ `priority`

`Command` มีสาม attribute: `script`, `output` และ `script_parts`
กฎของคุณไม่ควรเปลี่ยนแปลง `Command`

**API ของกฎเปลี่ยนในเวอร์ชัน 3.0:** หากต้องการเข้าถึง setting ของกฎ ให้ import ด้วย
 `from thefuck.conf import settings`

`settings` เป็นอ็อบเจกต์พิเศษที่ประกอบจาก `~/.config/thefuck/settings.py`
และค่าจาก env ([ดูรายละเอียดเพิ่มเติมด้านล่าง](#settings))

ตัวอย่างกฎง่าย ๆ สำหรับรัน script ด้วย `sudo`:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Optional:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # ค่าน้อยมาก่อน ค่าปกติคือ 1000

requires_output = True
```

[ดูตัวอย่างกฎเพิ่มเติม](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[ฟังก์ชันอรรถประโยชน์สำหรับกฎ](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[helper เฉพาะแอป/OS](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/)

##### [กลับไปที่สารบัญ](#contents)

## การตั้งค่า

สามารถเปลี่ยนพารามิเตอร์ของ *The Fuck* ได้ในไฟล์ `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` โดยปกติคือ `~/.config`):

* `rules` – รายชื่อกฎที่เปิดใช้ โดยปกติคือ `thefuck.const.DEFAULT_RULES`
* `exclude_rules` – รายชื่อกฎที่ปิดใช้ โดยปกติคือ `[]`
* `require_confirmation` – ต้องการยืนยันก่อนรันคำสั่งใหม่ โดยปกติคือ `True`
* `wait_command` – เวลาสูงสุด (วินาที) สำหรับรับ output ของคำสั่งก่อนหน้า
* `no_colors` – ปิดการแสดงผลแบบมีสี
* `priority` – dict ของ priority กฎ กฎที่ priority น้อยจะจับคู่ก่อน
* `debug` – เปิด debug output โดยปกติคือ `False`
* `history_limit` – จำนวนคำสั่ง history ที่จะ scan เช่น `2000`
* `alter_history` – push คำสั่งที่แก้ไขแล้วเข้า history โดยปกติคือ `True`
* `wait_slow_command` – เวลาสูงสุด (วินาที) สำหรับ output คำสั่งที่อยู่ใน `slow_commands`
* `slow_commands` – รายชื่อคำสั่งที่ช้า
* `num_close_matches` – จำนวนสูงสุดของคำสั่งที่ใกล้เคียงที่จะแนะนำ โดยปกติคือ `3`
* `excluded_search_path_prefixes` – prefix path ที่จะไม่สนใจเมื่อค้นหาคำสั่ง โดยปกติคือ `[]`

ตัวอย่าง `settings.py`:

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

หรือผ่านตัวแปร environment:

* `THEFUCK_RULES` – รายชื่อกฎที่เปิดใช้ เช่น `DEFAULT_RULES:rm_root` หรือ `sudo:no_command`
* `THEFUCK_EXCLUDE_RULES` – รายชื่อกฎที่ปิดใช้ เช่น `git_pull:git_push`
* `THEFUCK_REQUIRE_CONFIRMATION` – ต้องการยืนยันก่อนรันคำสั่งใหม่ `true/false`
* `THEFUCK_WAIT_COMMAND` – เวลาสูงสุด (วินาที) สำหรับรับ output ของคำสั่งก่อนหน้า
* `THEFUCK_NO_COLORS` – ปิด output สี `true/false`
* `THEFUCK_PRIORITY` – priority ของกฎ เช่น `no_command=9999:apt_get=100`
กฎที่ priority ต่ำจะจับคู่ก่อน
* `THEFUCK_DEBUG` – เปิด debug output `true/false`
* `THEFUCK_HISTORY_LIMIT` – จำนวนคำสั่ง history ที่จะ scan เช่น `2000`
* `THEFUCK_ALTER_HISTORY` – push คำสั่งที่แก้ไขแล้วเข้า history `true/false`
* `THEFUCK_WAIT_SLOW_COMMAND` – เวลาสูงสุด (วินาที) สำหรับรับ output คำสั่งที่อยู่ใน `slow_commands`
* `THEFUCK_SLOW_COMMANDS` – รายชื่อคำสั่งที่ช้า เช่น `lein:gradle`
* `THEFUCK_NUM_CLOSE_MATCHES` – จำนวนสูงสุดของคำสั่งที่ใกล้เคียงที่จะแนะนำ เช่น `5`
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` – prefix path ที่จะไม่สนใจเมื่อค้นหาคำสั่ง โดยปกติคือ `[]`

ตัวอย่าง:

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

##### [กลับไปที่สารบัญ](#contents)

## แพ็กเกจบุคคลที่สามพร้อมกฎ

หากคุณต้องการสร้างกฎเฉพาะกลุ่มที่ไม่เป็นสาธารณะ แต่ยังต้องการแบ่งปันกับผู้อื่น ให้สร้างแพ็กเกจชื่อ `thefuck_contrib_*` ด้วยโครงสร้างดังนี้:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *third-party rules*
    __init__.py
    *third-party-utils*
  setup.py
```

*The Fuck* จะค้นหากฎที่อยู่ในโมดูล `rules`

##### [กลับไปที่สารบัญ](#contents)

## โหมด Instant แบบทดลอง

พฤติกรรมเริ่มต้นของ *The Fuck* ต้องใช้เวลาสำหรับรันคำสั่งก่อนหน้าใหม่ ในโหมด instant *The Fuck* จะประหยัดเวลาด้วยการบันทึก output ด้วย [script](https://en.wikipedia.org/wiki/Script_(Unix))
แล้วอ่าน log

[![gif with instant mode][instant-mode-gif-link]][instant-mode-gif-link]

ปัจจุบันโหมด instant รองรับเฉพาะ Python 3 กับ bash หรือ zsh เท่านั้น ฟังก์ชัน autocorrect ของ zsh ต้องปิดเพื่อให้ thefuck ทำงานได้ถูกต้อง

เพื่อเปิดใช้งานโหมด instant ให้เพิ่ม `--enable-experimental-instant-mode`
ใน alias initialization ใน `.bashrc`, `.bash_profile` หรือ `.zshrc`

ตัวอย่าง:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [กลับไปที่สารบัญ](#contents)

## การพัฒนา

ดู [CONTRIBUTING.md](CONTRIBUTING.md)

## ไลเซนส์ MIT
ไลเซนส์ของโปรเจกต์ดูได้ที่ [ที่นี่](LICENSE.md)

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

##### [กลับไปที่สารบัญ](#contents)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---