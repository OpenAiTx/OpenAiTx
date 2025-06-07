# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* adalah aplikasi luar biasa, terinspirasi oleh [@liamosaur](https://twitter.com/liamosaur/)
[tweet](https://twitter.com/liamosaur/status/506975850596536320),
yang memperbaiki kesalahan pada perintah konsol sebelumnya.

Apakah *The Fuck* terlalu lambat? [Coba mode instan eksperimental!](#experimental-instant-mode)

[![gif with examples][examples-link]][examples-link]

Lebih banyak contoh:

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

Jika Anda tidak takut menjalankan perintah yang telah diperbaiki secara otomatis,
opsi `require_confirmation` pada [pengaturan](#settings) dapat dinonaktifkan:

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

## Daftar Isi

1. [Persyaratan](#requirements)
2. [Instalasi](#installation)
3. [Pembaruan](#updating)
4. [Cara kerja](#how-it-works)
5. [Membuat aturan sendiri](#creating-your-own-rules)
6. [Pengaturan](#settings)
7. [Paket pihak ketiga dengan aturan](#third-party-packages-with-rules)
8. [Mode instan eksperimental](#experimental-instant-mode)
9. [Pengembangan](#developing)
10. [Lisensi](#license-mit)

## Persyaratan

- python (3.5+)
- pip
- python-dev

##### [Kembali ke Daftar Isi](#contents)

## Instalasi

Pada macOS atau Linux, Anda dapat menginstal *The Fuck* melalui [Homebrew][homebrew]:

```bash
brew install thefuck
```

Pada Ubuntu / Mint, instal *The Fuck* dengan perintah berikut:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

Pada FreeBSD, instal *The Fuck* dengan perintah berikut:
```bash
pkg install thefuck
```

Pada ChromeOS, instal *The Fuck* menggunakan [chromebrew](https://github.com/skycocker/chromebrew) dengan perintah berikut:
```bash
crew install thefuck
```

Pada sistem berbasis Arch, instal *The Fuck* dengan perintah berikut:
```
sudo pacman -S thefuck
```

Pada sistem lain, instal *The Fuck* menggunakan `pip`:

```bash
pip install thefuck
```

[Atau, Anda dapat menggunakan manajer paket OS (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Disarankan untuk menempatkan perintah ini pada `.bash_profile`,
`.bashrc`, `.zshrc` atau skrip startup lainnya Anda:

```bash
eval $(thefuck --alias)
# Anda dapat menggunakan alias apa saja, misal untuk hari Senin:
eval $(thefuck --alias FUCK)
```

[Atau di konfigurasi shell Anda (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Perubahan hanya tersedia pada sesi shell baru. Untuk segera menerapkan perubahan,
jalankan `source ~/.bashrc` (atau file konfigurasi shell Anda seperti `.zshrc`).

Untuk menjalankan perintah yang telah diperbaiki tanpa konfirmasi, gunakan opsi `--yeah` (atau cukup `-y` untuk singkatnya, atau `--hard` jika Anda sangat frustrasi):

```bash
fuck --yeah
```

Untuk memperbaiki perintah secara rekursif hingga berhasil, gunakan opsi `-r`:

```bash
fuck -r
```

##### [Kembali ke Daftar Isi](#contents)

## Pembaruan

```bash
pip3 install thefuck --upgrade
```

**Catatan: Fungsi alias diubah pada v1.34 dari *The Fuck***

## Uninstall

Untuk menghapus *The Fuck*, balikkan proses instalasi:
- hapus atau komentari baris alias *thefuck* pada konfigurasi shell Anda (Bash, Zsh, Fish, Powershell, tcsh, ...)
- gunakan manajer paket Anda (brew, pip3, pkg, crew, pip) untuk menghapus biner

## Cara kerja

*The Fuck* mencoba mencocokkan perintah sebelumnya dengan sebuah aturan. Jika ditemukan kecocokan, perintah baru akan dibuat menggunakan aturan yang cocok dan dieksekusi. Aturan-aturan berikut diaktifkan secara default:

* `adb_unknown_command` &ndash; memperbaiki perintah typo seperti `adb logcta`;
* `ag_literal` &ndash; menambahkan `-Q` ke `ag` saat disarankan;
* `aws_cli` &ndash; memperbaiki perintah typo seperti `aws dynamdb scan`;
* `az_cli` &ndash; memperbaiki perintah typo seperti `az providers`;
* `cargo` &ndash; menjalankan `cargo build` alih-alih `cargo`;
* `cargo_no_command` &ndash; memperbaiki perintah salah seperti `cargo buid`;
* `cat_dir` &ndash; mengganti `cat` dengan `ls` saat Anda mencoba `cat` pada direktori;
* `cd_correction` &ndash; memeriksa ejaan dan memperbaiki perintah cd yang gagal;
* `cd_cs` &ndash; mengubah `cs` menjadi `cd`;
* `cd_mkdir` &ndash; membuat direktori sebelum menjalankan cd ke dalamnya;
* `cd_parent` &ndash; mengubah `cd..` menjadi `cd ..`;
* `chmod_x` &ndash; menambahkan bit eksekusi;
* `choco_install` &ndash; menambahkan akhiran umum untuk paket chocolatey;
* `composer_not_command` &ndash; memperbaiki nama perintah composer;
* `conda_mistype` &ndash; memperbaiki perintah conda;
* `cp_create_destination` &ndash; membuat direktori baru saat Anda mencoba `cp` atau `mv` ke direktori yang tidak ada;
* `cp_omitting_directory` &ndash; menambahkan `-a` saat Anda `cp` direktori;
* `cpp11` &ndash; menambahkan `-std=c++11` yang hilang ke `g++` atau `clang++`;
* `dirty_untar` &ndash; memperbaiki perintah `tar x` yang mengekstrak file di direktori saat ini;
* `dirty_unzip` &ndash; memperbaiki perintah `unzip` yang mengekstrak file di direktori saat ini;
* `django_south_ghost` &ndash; menambahkan `--delete-ghost-migrations` pada kegagalan migrasi ghost django south;
* `django_south_merge` &ndash; menambahkan `--merge` pada migrasi south django yang tidak konsisten;
* `docker_login` &ndash; menjalankan `docker login` dan mengulangi perintah sebelumnya;
* `docker_not_command` &ndash; memperbaiki perintah docker yang salah seperti `docker tags`;
* `docker_image_being_used_by_container` &dash; menghapus container yang memakai image sebelum menghapus imagenya;
* `dry` &ndash; memperbaiki pengulangan seperti `git git push`;
* `fab_command_not_found` &ndash; memperbaiki perintah fabric typo;
* `fix_alt_space` &ndash; mengganti Alt+Space dengan karakter Spasi;
* `fix_file` &ndash; membuka file dengan error di `$EDITOR` Anda;
* `gem_unknown_command` &ndash; memperbaiki perintah `gem` yang salah;
* `git_add` &ndash; memperbaiki *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` &ndash; menambahkan `--force` ke `git add <pathspec>...` jika path .gitignore;
* `git_bisect_usage` &ndash; memperbaiki `git bisect strt`, `git bisect goood`, `git bisect rset`, dll saat bisecting;
* `git_branch_delete` &ndash; mengubah `git branch -d` menjadi `git branch -D`;
* `git_branch_delete_checked_out` &ndash; mengubah `git branch -d` menjadi `git checkout master && git branch -D` saat mencoba menghapus branch yang sedang aktif;
* `git_branch_exists` &ndash; menawarkan `git branch -d foo`, `git branch -D foo` atau `git checkout foo` saat membuat branch yang sudah ada;
* `git_branch_list` &ndash; menangkap `git branch list` sebagai pengganti `git branch` dan menghapus branch yang dibuat;
* `git_branch_0flag` &ndash; memperbaiki perintah seperti `git branch 0v` dan `git branch 0r` dengan menghapus branch yang dibuat;
* `git_checkout` &ndash; memperbaiki nama branch atau membuat branch baru;
* `git_clone_git_clone` &ndash; mengganti `git clone git clone ...` dengan `git clone ...`
* `git_clone_missing` &ndash; menambahkan `git clone` ke URL yang tampak seperti repositori git.
* `git_commit_add` &ndash; menawarkan `git commit -a ...` atau `git commit -p ...` setelah commit sebelumnya gagal karena tidak ada yang di-stage;
* `git_commit_amend` &ndash; menawarkan `git commit --amend` setelah commit sebelumnya;
* `git_commit_reset` &ndash; menawarkan `git reset HEAD~` setelah commit sebelumnya;
* `git_diff_no_index` &ndash; menambahkan `--no-index` ke `git diff` sebelumnya pada file yang tidak ter-track;
* `git_diff_staged` &ndash; menambahkan `--staged` ke `git diff` sebelumnya dengan output tak terduga;
* `git_fix_stash` &ndash; memperbaiki perintah `git stash` (subcommand typo dan `save` yang hilang);
* `git_flag_after_filename` &ndash; memperbaiki `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; memperbaiki perintah `git help <alias>` dengan mengganti <alias> ke perintah asli;
* `git_hook_bypass` &ndash; menambahkan flag `--no-verify` pada `git am`, `git commit`, atau `git push` sebelumnya;
* `git_lfs_mistype` &ndash; memperbaiki typo pada perintah `git lfs <command>`;
* `git_main_master` &ndash; memperbaiki nama branch antara `main` dan `master`
* `git_merge` &ndash; menambahkan remote ke nama branch;
* `git_merge_unrelated` &ndash; menambahkan `--allow-unrelated-histories` jika diperlukan
* `git_not_command` &ndash; memperbaiki perintah git yang salah seperti `git brnch`;
* `git_pull` &ndash; mengatur upstream sebelum menjalankan `git pull` sebelumnya;
* `git_pull_clone` &ndash; clone alih-alih pull jika repo tidak ada;
* `git_pull_uncommitted_changes` &ndash; stash perubahan sebelum pull dan pop setelahnya;
* `git_push` &ndash; menambahkan `--set-upstream origin $branch` ke `git push` yang gagal sebelumnya;
* `git_push_different_branch_names` &ndash; memperbaiki push ketika nama branch lokal tidak sama dengan remote;
* `git_push_pull` &ndash; menjalankan `git pull` saat `push` ditolak;
* `git_push_without_commits` &ndash; membuat commit awal jika Anda lupa dan hanya `git add .`, saat setup project baru;
* `git_rebase_no_changes` &ndash; menjalankan `git rebase --skip` alih-alih `git rebase --continue` saat tidak ada perubahan;
* `git_remote_delete` &ndash; mengganti `git remote delete remote_name` dengan `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; menambahkan `-f` atau `--cached` saat Anda mencoba `rm` file yang sudah dimodifikasi lokal;
* `git_rm_recursive` &ndash; menambahkan `-r` saat Anda mencoba `rm` direktori;
* `git_rm_staged` &ndash;  menambahkan `-f` atau `--cached` saat Anda mencoba `rm` file dengan perubahan yang di-stage
* `git_rebase_merge_dir` &ndash; menawarkan `git rebase (--continue | --abort | --skip)` atau menghapus direktori `.git/rebase-merge` saat rebase berlangsung;
* `git_remote_seturl_add` &ndash; menjalankan `git remote add` saat `git remote set_url` pada remote yang tidak ada;
* `git_stash` &ndash; stash modifikasi lokal Anda sebelum rebase atau berpindah branch;
* `git_stash_pop` &ndash; menambahkan modifikasi lokal sebelum stash pop, lalu reset;
* `git_tag_force` &ndash; menambahkan `--force` ke `git tag <tagname>` saat tag sudah ada;
* `git_two_dashes` &ndash; menambahkan dash yang hilang pada perintah seperti `git commit -amend` atau `git rebase -continue`;
* `go_run` &ndash; menambahkan ekstensi `.go` saat kompilasi/menjalankan program Go;
* `go_unknown_command` &ndash; memperbaiki perintah `go` yang salah, misal `go bulid`;
* `gradle_no_task` &ndash; memperbaiki task `gradle` yang tidak ditemukan atau ambigu;
* `gradle_wrapper` &ndash; mengganti `gradle` dengan `./gradlew`;
* `grep_arguments_order` &ndash; memperbaiki urutan argumen `grep` seperti `grep -lir . test`;
* `grep_recursive` &ndash; menambahkan `-r` saat Anda mencoba `grep` direktori;
* `grunt_task_not_found` &ndash; memperbaiki perintah `grunt` typo;
* `gulp_not_task` &ndash; memperbaiki task `gulp` typo;
* `has_exists_script` &ndash; menambahkan `./` saat script/biner ada;
* `heroku_multiple_apps` &ndash; menambahkan `--app <app>` pada perintah `heroku` seperti `heroku pg`;
* `heroku_not_command` &ndash; memperbaiki perintah `heroku` yang salah seperti `heroku log`;
* `history` &ndash; mencoba mengganti perintah dengan yang paling mirip dari riwayat;
* `hostscli` &ndash; mencoba memperbaiki penggunaan `hostscli`;
* `ifconfig_device_not_found` &ndash; memperbaiki nama device yang salah seperti `wlan0` menjadi `wlp2s0`;
* `java` &ndash; menghapus ekstensi `.java` saat menjalankan program Java;
* `javac` &ndash; menambahkan `.java` yang hilang saat kompilasi file Java;
* `lein_not_task` &ndash; memperbaiki task `lein` yang salah seperti `lein rpl`;
* `long_form_help` &ndash; mengubah `-h` menjadi `--help` saat versi short tidak didukung
* `ln_no_hard_link` &ndash; menangkap hard link pada direktori, menyarankan symbolic link;
* `ln_s_order` &ndash; memperbaiki urutan argumen `ln -s`;
* `ls_all` &ndash; menambahkan `-A` ke `ls` saat output kosong;
* `ls_lah` &ndash; menambahkan `-lah` ke `ls`;
* `man` &ndash; mengubah bagian manual;
* `man_no_space` &ndash; memperbaiki perintah man tanpa spasi, seperti `mandiff`;
* `mercurial` &ndash; memperbaiki perintah `hg` yang salah;
* `missing_space_before_subcommand` &ndash; memperbaiki perintah tanpa spasi seperti `npminstall`;
* `mkdir_p` &ndash; menambahkan `-p` saat Anda membuat direktori tanpa parent;
* `mvn_no_command` &ndash; menambahkan `clean package` ke `mvn`;
* `mvn_unknown_lifecycle_phase` &ndash; memperbaiki typo life cycle pada `mvn`;
* `npm_missing_script` &ndash; memperbaiki nama script custom pada `npm run-script <script>`;
* `npm_run_script` &ndash; menambahkan `run-script` yang hilang untuk script custom `npm`;
* `npm_wrong_command` &ndash; memperbaiki perintah npm yang salah seperti `npm urgrade`;
* `no_command` &ndash; memperbaiki perintah konsol yang salah, misal `vom/vim`;
* `no_such_file` &ndash; membuat direktori yang hilang dengan perintah `mv` dan `cp`;
* `omnienv_no_such_command` &ndash; memperbaiki perintah salah untuk `goenv`, `nodenv`, `pyenv` dan `rbenv` (misal: `pyenv isntall` atau `goenv list`);
* `open` &ndash; menambahkan `http://` ke alamat yang diberikan ke `open` atau membuat file/direktori baru dan memberikannya ke `open`;
* `pip_install` &ndash; memperbaiki masalah permission pada perintah `pip install` dengan menambahkan `--user` atau menambahkan `sudo` jika perlu;
* `pip_unknown_command` &ndash; memperbaiki perintah pip yang salah, misal `pip instatl/pip install`;
* `php_s` &ndash; mengganti `-s` dengan `-S` saat menjalankan server lokal php;
* `port_already_in_use` &ndash; membunuh proses yang memakai port tersebut;
* `prove_recursively` &ndash; menambahkan `-r` saat dipanggil dengan direktori;
* `python_command` &ndash; menambahkan `python` saat Anda mencoba menjalankan script python non-eksekusi/tanpa `./`;
* `python_execute` &ndash; menambahkan `.py` yang hilang saat mengeksekusi file Python;
* `python_module_error` &ndash; memperbaiki ModuleNotFoundError dengan mencoba `pip install` modul tersebut;
* `quotation_marks` &ndash; memperbaiki penggunaan `'` dan `"` yang tidak seimbang pada argumen;
* `path_from_history` &ndash; mengganti path yang tidak ditemukan dengan path absolut mirip dari riwayat;
* `rails_migrations_pending` &ndash; menjalankan migrasi yang tertunda;
* `react_native_command_unrecognized` &ndash; memperbaiki perintah `react-native` yang tidak dikenali;
* `remove_shell_prompt_literal` &ndash; menghapus simbol prompt shell `$` di depan, umum saat copy perintah dari dokumentasi;
* `remove_trailing_cedilla` &ndash; menghapus cedillas `ç` di akhir, typo umum untuk layout keyboard Eropa;
* `rm_dir` &ndash; menambahkan `-rf` saat Anda mencoba menghapus direktori;
* `scm_correction` &ndash; memperbaiki scm yang salah seperti `hg log` menjadi `git log`;
* `sed_unterminated_s` &ndash; menambahkan '/' yang hilang pada perintah `s` di `sed`;
* `sl_ls` &ndash; mengubah `sl` menjadi `ls`;
* `ssh_known_hosts` &ndash; menghapus host dari `known_hosts` saat ada peringatan;
* `sudo` &ndash; menambahkan `sudo` ke perintah sebelumnya jika gagal karena permission;
* `sudo_command_from_user_path` &ndash; menjalankan perintah dari `$PATH` user dengan `sudo`;
* `switch_lang` &ndash; mengganti perintah dari layout lokal Anda ke en;
* `systemctl` &ndash; mengurutkan parameter `systemctl` yang membingungkan dengan benar;
* `terraform_init.py` &ndash; menjalankan `terraform init` sebelum plan atau apply;
* `terraform_no_command.py` &ndash; memperbaiki perintah `terraform` yang tidak dikenali;
* `test.py` &ndash; menjalankan `pytest` alih-alih `test.py`;
* `touch` &ndash; membuat direktori yang hilang sebelum "touch";
* `tsuru_login` &ndash; menjalankan `tsuru login` jika belum otentikasi atau sesi kedaluwarsa;
* `tsuru_not_command` &ndash; memperbaiki perintah `tsuru` yang salah seperti `tsuru shell`;
* `tmux` &ndash; memperbaiki perintah `tmux`;
* `unknown_command` &ndash; memperbaiki perintah "unknown command" gaya hadoop hdfs, misal menambahkan `-` yang hilang pada perintah `hdfs dfs ls`;
* `unsudo` &ndash; menghapus `sudo` dari perintah sebelumnya jika proses menolak dijalankan dengan hak superuser.
* `vagrant_up` &ndash; menyalakan instance vagrant;
* `whois` &ndash; memperbaiki perintah `whois`;
* `workon_doesnt_exists` &ndash; memperbaiki nama env `virtualenvwrapper` atau menyarankan membuat baru.
* `wrong_hyphen_before_subcommand` &ndash; menghapus hyphen yang salah tempat (`apt-install` -> `apt install`, `git-log` -> `git log`, dll)
* `yarn_alias` &ndash; memperbaiki perintah alias `yarn` seperti `yarn ls`;
* `yarn_command_not_found` &ndash; memperbaiki perintah `yarn` typo;
* `yarn_command_replaced` &ndash; memperbaiki perintah `yarn` yang diganti;
* `yarn_help` &ndash; mempermudah membuka dokumentasi `yarn`;

##### [Kembali ke Daftar Isi](#contents)

Aturan-aturan berikut hanya diaktifkan secara default pada platform tertentu:

* `apt_get` &ndash; menginstal aplikasi dari apt jika belum terinstal (membutuhkan `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; mengubah pencarian menggunakan `apt-get` menjadi pencarian menggunakan `apt-cache`;
* `apt_invalid_operation` &ndash; memperbaiki pemanggilan `apt` dan `apt-get` yang salah, seperti `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; membantu Anda menjalankan `apt list --upgradable` setelah `apt update`;
* `apt_upgrade` &ndash; membantu Anda menjalankan `apt upgrade` setelah `apt list --upgradable`;
* `brew_cask_dependency` &ndash; menginstal dependensi cask;
* `brew_install` &ndash; memperbaiki nama formula untuk `brew install`;
* `brew_reinstall` &ndash; mengubah `brew install <formula>` menjadi `brew reinstall <formula>`;
* `brew_link` &ndash; menambahkan `--overwrite --dry-run` jika gagal linking;
* `brew_uninstall` &ndash; menambahkan `--force` ke `brew uninstall` jika banyak versi terinstal;
* `brew_unknown_command` &ndash; memperbaiki perintah brew yang salah, misal `brew docto/brew doctor`;
* `brew_update_formula` &ndash; mengubah `brew update <formula>` menjadi `brew upgrade <formula>`;
* `dnf_no_such_command` &ndash; memperbaiki typo pada perintah DNF;
* `nixos_cmd_not_found` &ndash; menginstal aplikasi di NixOS;
* `pacman` &ndash; menginstal aplikasi dengan `pacman` jika belum terinstal (menggunakan `yay`, `pikaur` atau `yaourt` jika tersedia);
* `pacman_invalid_option` &ndash; mengganti opsi `pacman` huruf kecil dengan huruf besar.
* `pacman_not_found` &ndash; memperbaiki nama paket dengan `pacman`, `yay`, `pikaur` atau `yaourt`.
* `yum_invalid_operation` &ndash; memperbaiki pemanggilan `yum` yang salah, seperti `yum isntall vim`;

Perintah berikut dibundel dengan *The Fuck*, tapi tidak diaktifkan secara default:

* `git_push_force` &ndash; menambahkan `--force-with-lease` pada `git push` (bisa konflik dengan `git_push_pull`);
* `rm_root` &ndash; menambahkan `--no-preserve-root` pada perintah `rm -rf /`.

##### [Kembali ke Daftar Isi](#contents)

## Membuat aturan sendiri

Untuk menambahkan aturan sendiri, buat file bernama `your-rule-name.py`
di `~/.config/thefuck/rules`. File aturan harus berisi dua fungsi:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Selain itu, aturan dapat berisi fungsi opsional:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Aturan juga dapat berisi variabel opsional `enabled_by_default`, `requires_output` dan `priority`.

`Command` memiliki tiga atribut: `script`, `output` dan `script_parts`.
Aturan Anda tidak boleh mengubah `Command`.

**API aturan berubah di 3.0:** Untuk mengakses pengaturan aturan, impor dengan
 `from thefuck.conf import settings`

`settings` adalah objek khusus yang dikumpulkan dari `~/.config/thefuck/settings.py`,
dan nilai dari env ([lihat lebih lanjut di bawah](#settings)).

Contoh aturan sederhana untuk menjalankan script dengan `sudo`:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Opsional:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Semakin kecil semakin prioritas, default 1000

requires_output = True
```

[Contoh aturan lainnya](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[fungsi utilitas untuk aturan](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[helper khusus app/os](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Kembali ke Daftar Isi](#contents)

## Pengaturan

Beberapa parameter *The Fuck* dapat diubah pada file `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` default ke `~/.config`):

* `rules` &ndash; daftar aturan yang diaktifkan, default `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; daftar aturan yang dinonaktifkan, default `[]`;
* `require_confirmation` &ndash; butuh konfirmasi sebelum menjalankan perintah baru, default `True`;
* `wait_command` &ndash; waktu maksimum dalam detik untuk mendapatkan output perintah sebelumnya;
* `no_colors` &ndash; nonaktifkan output berwarna;
* `priority` &ndash; dict dengan prioritas aturan, aturan dengan `priority` lebih kecil akan dicocokkan lebih dulu;
* `debug` &ndash; aktifkan output debug, default `False`;
* `history_limit` &ndash; nilai numerik berapa banyak perintah riwayat yang akan dipindai, misal `2000`;
* `alter_history` &ndash; push perintah yang diperbaiki ke riwayat, default `True`;
* `wait_slow_command` &ndash; waktu maksimum dalam detik untuk mendapatkan output perintah sebelumnya jika ada pada daftar `slow_commands`;
* `slow_commands` &ndash; daftar perintah lambat;
* `num_close_matches` &ndash; jumlah maksimum saran yang mirip, default `3`.
* `excluded_search_path_prefixes` &ndash; prefix path yang diabaikan saat mencari perintah, default `[]`.

Contoh `settings.py`:

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

Atau lewat variabel lingkungan:

* `THEFUCK_RULES` &ndash; daftar aturan yang diaktifkan, misal `DEFAULT_RULES:rm_root` atau `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; daftar aturan yang dinonaktifkan, misal `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; butuh konfirmasi sebelum menjalankan perintah baru, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; waktu maksimum dalam detik untuk mendapatkan output perintah sebelumnya;
* `THEFUCK_NO_COLORS` &ndash; nonaktifkan output berwarna, `true/false`;
* `THEFUCK_PRIORITY` &ndash; prioritas aturan, misal `no_command=9999:apt_get=100`,
aturan dengan `priority` lebih kecil akan dicocokkan lebih dulu;
* `THEFUCK_DEBUG` &ndash; aktifkan output debug, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; berapa banyak perintah riwayat yang akan dipindai, misal `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; push perintah yang diperbaiki ke riwayat `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; waktu maksimum dalam detik untuk mendapatkan output perintah sebelumnya jika ada pada daftar `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` &ndash; daftar perintah lambat, misal `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; jumlah maksimum saran yang mirip, misal `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; prefix path yang diabaikan saat mencari perintah, default `[]`.

Sebagai contoh:

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

##### [Kembali ke Daftar Isi](#contents)

## Paket pihak ketiga dengan aturan

Jika Anda ingin membuat set aturan non-publik khusus, tapi tetap ingin membagikannya pada orang lain, buat paket bernama `thefuck_contrib_*` dengan struktur berikut:

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

*The Fuck* akan menemukan aturan yang berada di modul `rules`.

##### [Kembali ke Daftar Isi](#contents)

## Mode instan eksperimental

Perilaku default *The Fuck* membutuhkan waktu untuk menjalankan ulang perintah sebelumnya.
Pada mode instan, *The Fuck* menghemat waktu dengan mencatat output menggunakan [script](https://en.wikipedia.org/wiki/Script_(Unix)),
lalu membaca log.

[![gif dengan mode instan][instant-mode-gif-link]][instant-mode-gif-link]

Saat ini, mode instan hanya mendukung Python 3 dengan bash atau zsh. Fungsi autocorrect zsh juga harus dinonaktifkan agar thefuck dapat berjalan dengan benar.

Untuk mengaktifkan mode instan, tambahkan `--enable-experimental-instant-mode`
pada inisialisasi alias di `.bashrc`, `.bash_profile` atau `.zshrc`.

Sebagai contoh:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Kembali ke Daftar Isi](#contents)

## Pengembangan

Lihat [CONTRIBUTING.md](CONTRIBUTING.md)

## Lisensi MIT
Lisensi Proyek dapat ditemukan [di sini](LICENSE.md).


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

##### [Kembali ke Daftar Isi](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---