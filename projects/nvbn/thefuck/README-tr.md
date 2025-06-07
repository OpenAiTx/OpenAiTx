# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck*, [@liamosaur](https://twitter.com/liamosaur/)’un
[twiti](https://twitter.com/liamosaur/status/506975850596536320)nden esinlenen harika bir uygulamadır; önceki konsol komutlarındaki hataları düzeltir.

*The Fuck* çok mu yavaş? [Deneysel anında modu deneyin!](#experimental-instant-mode)

[![örneklerle gif][examples-link]][examples-link]

Daha fazla örnek:

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

Düzeltilen komutları körü körüne çalıştırmaktan korkmuyorsanız,
`require_confirmation` [ayarını](#settings) devre dışı bırakabilirsiniz:

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

## İçindekiler

1. [Gereksinimler](#requirements)
2. [Kurulum](#installation)
3. [Güncelleme](#updating)
4. [Nasıl çalışır](#how-it-works)
5. [Kendi kurallarınızı oluşturma](#creating-your-own-rules)
6. [Ayarlar](#settings)
7. [Kurallı üçüncü taraf paketler](#third-party-packages-with-rules)
8. [Deneysel anında mod](#experimental-instant-mode)
9. [Geliştirme](#developing)
10. [Lisans](#license-mit)

## Gereksinimler

- python (3.5+)
- pip
- python-dev

##### [İçindekilere Dön](#contents)

## Kurulum

macOS veya Linux üzerinde *The Fuck*'ı [Homebrew][homebrew] ile kurabilirsiniz:

```bash
brew install thefuck
```

Ubuntu / Mint üzerinde *The Fuck* aşağıdaki komutlarla kurulur:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

FreeBSD üzerinde *The Fuck* aşağıdaki komutlarla kurulur:
```bash
pkg install thefuck
```

ChromeOS üzerinde *The Fuck*, [chromebrew](https://github.com/skycocker/chromebrew) ile şu komutla kurulur:
```bash
crew install thefuck
```

Arch tabanlı sistemlerde *The Fuck* aşağıdaki komutla kurulur:
```
sudo pacman -S thefuck
```

Diğer sistemlerde *The Fuck*'ı `pip` ile kurabilirsiniz:

```bash
pip install thefuck
```

[Alternatif olarak, bir işletim sistemi paket yöneticisi (OS X, Ubuntu, Arch) de kullanılabilir.](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Bu komutu `.bash_profile`, `.bashrc`, `.zshrc` veya başka bir başlangıç betiğinize eklemeniz önerilir:

```bash
eval $(thefuck --alias)
# Pazartesiler için başka bir kısayol da kullanabilirsiniz:
eval $(thefuck --alias FUCK)
```

[Ya da kabuk yapılandırmanıza (Bash, Zsh, Fish, Powershell, tcsh) ekleyin.](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Değişiklikler yalnızca yeni bir kabuk oturumunda geçerli olur. Değişiklikleri hemen etkinleştirmek için `source ~/.bashrc` (veya `.zshrc` gibi kabuk dosyanızı) çalıştırın.

Düzeltilen komutları onay almadan çalıştırmak için `--yeah` seçeneğini kullanın (veya kısaca `-y`, veya özellikle sinirliyseniz `--hard`):

```bash
fuck --yeah
```

Komutları başarılı olana kadar özyinelemeli olarak düzeltmek için `-r` seçeneğini kullanın:

```bash
fuck -r
```

##### [İçindekilere Dön](#contents)

## Güncelleme

```bash
pip3 install thefuck --upgrade
```

**Not: *The Fuck*'ın v1.34 sürümünde takma ad işlevi değişmiştir.**

## Kaldırma

*The Fuck*'ı kaldırmak için kurulum işlemini tersine çevirin:
- Bash, Zsh, Fish, Powershell, tcsh, ... kabuk yapılandırmanızdan *thefuck* takma ad satırını silin veya yorum satırı yapın.
- Paket yöneticinizi (brew, pip3, pkg, crew, pip) kullanarak ikili dosyaları kaldırın.

## Nasıl çalışır

*The Fuck*, önceki komutu bir kuralla eşleştirmeye çalışır. Eşleşme bulunursa, eşleşen kurala göre yeni bir komut oluşturulup çalıştırılır. Aşağıdaki kurallar varsayılan olarak etkindir:

* `adb_unknown_command` &ndash; `adb logcta` gibi yanlış yazılmış komutları düzeltir;
* `ag_literal` &ndash; önerildiğinde `ag`'ye `-Q` ekler;
* `aws_cli` &ndash; `aws dynamdb scan` gibi yanlış yazılmış komutları düzeltir;
* `az_cli` &ndash; `az providers` gibi yanlış yazılmış komutları düzeltir;
* `cargo` &ndash; `cargo` yerine `cargo build` çalıştırır;
* `cargo_no_command` &ndash; `cargo buid` gibi yanlış komutları düzeltir;
* `cat_dir` &ndash; bir dizini `cat` ile göstermeye çalışırken `cat` yerine `ls` ile değiştirir;
* `cd_correction` &ndash; cd komutlarının yazımını kontrol eder ve düzeltir;
* `cd_cs` &ndash; `cs`'yi `cd` ile değiştirir;
* `cd_mkdir` &ndash; bir dizine cd yapmadan önce dizini oluşturur;
* `cd_parent` &ndash; `cd..`'yi `cd ..` ile değiştirir;
* `chmod_x` &ndash; çalıştırma izni ekler;
* `choco_install` &ndash; chocolatey paketleri için yaygın sonekler ekler;
* `composer_not_command` &ndash; composer komut adını düzeltir;
* `conda_mistype` &ndash; conda komutlarını düzeltir;
* `cp_create_destination` &ndash; var olmayan bir dizine `cp` veya `mv` yaparken yeni bir dizin oluşturur;
* `cp_omitting_directory` &ndash; bir dizini `cp` ile kopyalarken `-a` ekler;
* `cpp11` &ndash; `g++` veya `clang++`'ya eksik `-std=c++11` ekler;
* `dirty_untar` &ndash; mevcut dizinde açılan `tar x` komutunu düzeltir;
* `dirty_unzip` &ndash; mevcut dizinde açılan `unzip` komutunu düzeltir;
* `django_south_ghost` &ndash; hayalet django south migration'ı nedeniyle başarısız olanlara `--delete-ghost-migrations` ekler;
* `django_south_merge` &ndash; tutarsız django south migration'lara `--merge` ekler;
* `docker_login` &ndash; bir `docker login` çalıştırır ve önceki komutu tekrarlar;
* `docker_not_command` &ndash; `docker tags` gibi yanlış docker komutlarını düzeltir;
* `docker_image_being_used_by_container` &ndash; bir görüntüyü silmeden önce o görüntüyü kullanan konteyneri kaldırır;
* `dry` &ndash; `git git push` gibi tekrarları düzeltir;
* `fab_command_not_found` &ndash; yanlış yazılmış fabric komutlarını düzeltir;
* `fix_alt_space` &ndash; Alt+Space karakterini Space ile değiştirir;
* `fix_file` &ndash; hatalı bir dosyayı `$EDITOR` ile açar;
* `gem_unknown_command` &ndash; yanlış `gem` komutlarını düzeltir;
* `git_add` &ndash; *"pathspec 'foo' did not match any file(s) known to git."* hatasını düzeltir;
* `git_add_force` &ndash; .gitignore'daki yollar için `git add <pathspec>...`'a `--force` ekler;
* `git_bisect_usage` &ndash; bisect sırasında `git bisect strt`, `git bisect goood`, `git bisect rset` gibi komutları düzeltir;
* `git_branch_delete` &ndash; `git branch -d`'yi `git branch -D` ile değiştirir;
* `git_branch_delete_checked_out` &ndash; çıkarılmış bir dalı silmeye çalışırken `git branch -d`'yi `git checkout master && git branch -D` ile değiştirir;
* `git_branch_exists` &ndash; zaten var olan bir dal oluşturulurken `git branch -d foo`, `git branch -D foo` veya `git checkout foo` önerir;
* `git_branch_list` &ndash; `git branch list`'i yakalar ve oluşturulan dalı kaldırır;
* `git_branch_0flag` &ndash; `git branch 0v` ve `git branch 0r` gibi komutları düzeltir, oluşturulan dalı kaldırır;
* `git_checkout` &ndash; dal adını düzeltir veya yeni dal oluşturur;
* `git_clone_git_clone` &ndash; `git clone git clone ...`'u `git clone ...` ile değiştirir;
* `git_clone_missing` &ndash; git deposuna bağlantı içeren URL'lere `git clone` ekler;
* `git_commit_add` &ndash; önceki commit başarısız olduysa `git commit -a ...` veya `git commit -p ...` önerir;
* `git_commit_amend` &ndash; önceki commit sonrası `git commit --amend` önerir;
* `git_commit_reset` &ndash; önceki commit sonrası `git reset HEAD~` önerir;
* `git_diff_no_index` &ndash; izlenmeyen dosyalarda önceki `git diff`'ye `--no-index` ekler;
* `git_diff_staged` &ndash; beklenmeyen çıktıda önceki `git diff`'ye `--staged` ekler;
* `git_fix_stash` &ndash; `git stash` komutlarını düzeltir (yanlış yazılmış alt komut ve eksik `save`);
* `git_flag_after_filename` &ndash; `fatal: bad flag '...' after filename` hatasını düzeltir;
* `git_help_aliased` &ndash; `<alias>` ile `git help <alias>` komutlarını aliased komutla değiştirir;
* `git_hook_bypass` &ndash; `git am`, `git commit` veya `git push` komutuna öncesinde `--no-verify` bayrağı ekler;
* `git_lfs_mistype` &ndash; yanlış yazılmış `git lfs <command>` komutlarını düzeltir;
* `git_main_master` &ndash; `main` ve `master` arasında yanlış dal adı düzeltir;
* `git_merge` &ndash; dal adlarına remote ekler;
* `git_merge_unrelated` &ndash; gerektiğinde `--allow-unrelated-histories` ekler;
* `git_not_command` &ndash; `git brnch` gibi yanlış git komutlarını düzeltir;
* `git_pull` &ndash; önceki `git pull`'dan önce upstream ayarlar;
* `git_pull_clone` &ndash; depo yoksa çekmek yerine klonlar;
* `git_pull_uncommitted_changes` &ndash; çekmeden önce değişiklikleri saklar ve sonra geri alır;
* `git_push` &ndash; başarısız `git push`'dan sonra `--set-upstream origin $branch` ekler;
* `git_push_different_branch_names` &ndash; yerel ve uzak dal adları uyuşmadığında push işlemini düzeltir;
* `git_push_pull` &ndash; push reddedildiğinde `git pull` çalıştırır;
* `git_push_without_commits` &ndash; yeni proje kurarken commit yapmayı unuttuysanız ilk commit oluşturur;
* `git_rebase_no_changes` &ndash; değişiklik yoksa `git rebase --continue` yerine `git rebase --skip` çalıştırır;
* `git_remote_delete` &ndash; `git remote delete remote_name`'i `git remote remove remote_name` ile değiştirir;
* `git_rm_local_modifications` &ndash; yerel değişiklikli dosyayı silmeye çalışırken `-f` veya `--cached` ekler;
* `git_rm_recursive` &ndash; bir dizini silmeye çalışırken `-r` ekler;
* `git_rm_staged` &ndash; sahneye alınmış değişikliğe sahip dosyayı silerken `-f` veya `--cached` ekler;
* `git_rebase_merge_dir` &ndash; rebase sırasında `git rebase (--continue | --abort | --skip)` veya `.git/rebase-merge` dizinini kaldırma seçeneği sunar;
* `git_remote_seturl_add` &ndash; mevcut olmayan remote'a `git remote set_url` yerine `git remote add` çalıştırır;
* `git_stash` &ndash; yeniden tabanlama veya dal değiştirme öncesi yerel değişiklikleri saklar;
* `git_stash_pop` &ndash; saklananları geri getirirken yerel değişiklikleri ekler, ardından sıfırlar;
* `git_tag_force` &ndash; etiket zaten varsa `git tag <tagname>`'e `--force` ekler;
* `git_two_dashes` &ndash; `git commit -amend` veya `git rebase -continue` gibi komutlara eksik tire ekler;
* `go_run` &ndash; Go programı derlerken/çalıştırırken `.go` uzantısı ekler;
* `go_unknown_command` &ndash; `go bulid` gibi yanlış go komutlarını düzeltir;
* `gradle_no_task` &ndash; bulunamayan veya belirsiz `gradle` görevlerini düzeltir;
* `gradle_wrapper` &ndash; `gradle`'i `./gradlew` ile değiştirir;
* `grep_arguments_order` &ndash; `grep -lir . test` gibi durumlarda `grep` argüman sıralamasını düzeltir;
* `grep_recursive` &ndash; bir dizinde `grep` yapmaya çalışırken `-r` ekler;
* `grunt_task_not_found` &ndash; yanlış yazılmış `grunt` komutlarını düzeltir;
* `gulp_not_task` &ndash; yanlış yazılmış `gulp` görevlerini düzeltir;
* `has_exists_script` &ndash; script/ikili dosya varsa başına `./` ekler;
* `heroku_multiple_apps` &ndash; `heroku pg` gibi komutlara `--app <app>` ekler;
* `heroku_not_command` &ndash; `heroku log` gibi yanlış komutları düzeltir;
* `history` &ndash; komutu geçmişteki en benzer komutla değiştirir;
* `hostscli` &ndash; `hostscli` kullanımını düzeltir;
* `ifconfig_device_not_found` &ndash; `wlan0` gibi yanlış aygıt adlarını `wlp2s0` ile düzeltir;
* `java` &ndash; Java programı çalıştırırken `.java` uzantısını kaldırır;
* `javac` &ndash; Java dosyalarını derlerken eksik `.java` ekler;
* `lein_not_task` &ndash; `lein rpl` gibi yanlış lein görevlerini düzeltir;
* `long_form_help` &ndash; kısa form desteklenmiyorsa `-h`'yi `--help` ile değiştirir;
* `ln_no_hard_link` &ndash; dizinlerde hard link oluşturmayı yakalar, sembolik bağlantı önerir;
* `ln_s_order` &ndash; `ln -s` argüman sırasını düzeltir;
* `ls_all` &ndash; çıktı boşsa `ls`'ye `-A` ekler;
* `ls_lah` &ndash; `ls`'ye `-lah` ekler;
* `man` &ndash; kılavuz bölümünü değiştirir;
* `man_no_space` &ndash; `mandiff` gibi arada boşluk olmayan man komutlarını düzeltir;
* `mercurial` &ndash; yanlış `hg` komutlarını düzeltir;
* `missing_space_before_subcommand` &ndash; `npminstall` gibi alt komut öncesi eksik boşluğu düzeltir;
* `mkdir_p` &ndash; ebeveyni olmayan bir dizin oluşturmaya çalışırken `-p` ekler;
* `mvn_no_command` &ndash; `mvn`'ye `clean package` ekler;
* `mvn_unknown_lifecycle_phase` &ndash; yanlış yazılmış yaşam döngüsü fazlarını düzeltir;
* `npm_missing_script` &ndash; `npm run-script <script>`'te `npm` özel script adını düzeltir;
* `npm_run_script` &ndash; özel `npm` scriptleri için eksik `run-script` ekler;
* `npm_wrong_command` &ndash; `npm urgrade` gibi yanlış npm komutlarını düzeltir;
* `no_command` &ndash; `vom/vim` gibi yanlış konsol komutlarını düzeltir;
* `no_such_file` &ndash; `mv` ve `cp` komutlarıyla eksik dizinleri oluşturur;
* `omnienv_no_such_command` &ndash; `goenv`, `nodenv`, `pyenv` ve `rbenv` için yanlış komutları düzeltir (örn: `pyenv isntall` veya `goenv list`);
* `open` &ndash; `open`'a verilen adrese `http://` ekler veya yeni bir dosya/dizin oluşturup onu open'a verir;
* `pip_install` &ndash; `pip install` komutlarında izin sorunlarını `--user` ekleyerek veya gerekirse başına `sudo` ekleyerek düzeltir;
* `pip_unknown_command` &ndash; `pip instatl/pip install` gibi yanlış pip komutlarını düzeltir;
* `php_s` &ndash; yerel php sunucu çalıştırırken `-s`'yi `-S` ile değiştirir;
* `port_already_in_use` &ndash; portu kullanan işlemi sonlandırır;
* `prove_recursively` &ndash; dizin ile çağrıldığında `-r` ekler;
* `python_command` &ndash; çalıştırılabilir/`./` olmadan python scripti çalıştırmaya çalışırken başına `python` ekler;
* `python_execute` &ndash; Python dosyalarını çalıştırırken eksik `.py` ekler;
* `python_module_error` &ndash; eksik modülü `pip install` ile yüklemeye çalışarak ModuleNotFoundError hatasını düzeltir;
* `quotation_marks` &ndash; argümanlarda `'` ve `"` dengesiz kullanımını düzeltir;
* `path_from_history` &ndash; bulunamayan yolu geçmişten benzer mutlak bir yol ile değiştirir;
* `rails_migrations_pending` &ndash; bekleyen migration'ları çalıştırır;
* `react_native_command_unrecognized` &ndash; tanınmayan `react-native` komutlarını düzeltir;
* `remove_shell_prompt_literal` &ndash; belgelerden komut kopyalarken baştaki `$` işaretini kaldırır;
* `remove_trailing_cedilla` &ndash; Avrupa klavye düzenlerinde yaygın bir hata olan sondaki cedilla `ç` karakterini kaldırır;
* `rm_dir` &ndash; bir dizini silmeye çalışırken `-rf` ekler;
* `scm_correction` &ndash; yanlış scm'yi düzeltir, örn: `hg log`'u `git log` ile değiştirir;
* `sed_unterminated_s` &ndash; `sed`'in `s` komutlarına eksik '/' ekler;
* `sl_ls` &ndash; `sl`'yi `ls` ile değiştirir;
* `ssh_known_hosts` &ndash; uyarıda `known_hosts`'tan hostu kaldırır;
* `sudo` &ndash; izin nedeniyle başarısız olan önceki komutun başına `sudo` ekler;
* `sudo_command_from_user_path` &ndash; kullanıcı `$PATH`'indeki komutları `sudo` ile çalıştırır;
* `switch_lang` &ndash; komutu yerel klavye düzeninizden en'ye çevirir;
* `systemctl` &ndash; kafa karıştırıcı `systemctl` parametrelerini doğru sıralar;
* `terraform_init.py` &ndash; plan veya apply'dan önce `terraform init` çalıştırır;
* `terraform_no_command.py` &ndash; tanınmayan `terraform` komutlarını düzeltir;
* `test.py` &ndash; `test.py` yerine `pytest` çalıştırır;
* `touch` &ndash; "touch" işlemi öncesi eksik dizinleri oluşturur;
* `tsuru_login` &ndash; kimlik doğrulaması yapılmamışsa veya oturum süresi dolmuşsa `tsuru login` çalıştırır;
* `tsuru_not_command` &ndash; `tsuru shell` gibi yanlış `tsuru` komutlarını düzeltir;
* `tmux` &ndash; `tmux` komutlarını düzeltir;
* `unknown_command` &ndash; hadoop hdfs-tarzı "unknown command" hatalarını düzeltir, örneğin `hdfs dfs ls`'de komuta eksik '-' ekler;
* `unsudo` &ndash; önceki komuttan `sudo`'yu kaldırır, eğer bir süreç süper kullanıcı ayrıcalığıyla çalışmayı reddederse;
* `vagrant_up` &ndash; vagrant örneğini başlatır;
* `whois` &ndash; `whois` komutunu düzeltir;
* `workon_doesnt_exists` &ndash; `virtualenvwrapper` ortam adını düzeltir veya yenisini oluşturmayı önerir;
* `wrong_hyphen_before_subcommand` &ndash; yanlış yerleştirilmiş tireyi kaldırır (`apt-install` -> `apt install`, `git-log` -> `git log`, vb.);
* `yarn_alias` &ndash; `yarn ls` gibi aliased `yarn` komutlarını düzeltir;
* `yarn_command_not_found` &ndash; yanlış yazılmış `yarn` komutlarını düzeltir;
* `yarn_command_replaced` &ndash; değiştirilmiş `yarn` komutlarını düzeltir;
* `yarn_help` &ndash; `yarn` dokümantasyonunu açmayı kolaylaştırır;

##### [İçindekilere Dön](#contents)

Aşağıdaki kurallar yalnızca belirli platformlarda varsayılan olarak etkindir:

* `apt_get` &ndash; uygulama yüklü değilse apt ile yükler (gerektirir: `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; `apt-get` ile arama girişimini `apt-cache` ile aramaya değiştirir;
* `apt_invalid_operation` &ndash; `apt-get isntall vim` gibi geçersiz `apt` ve `apt-get` çağrılarını düzeltir;
* `apt_list_upgradable` &ndash; `apt update` sonrası `apt list --upgradable` çalıştırmanıza yardımcı olur;
* `apt_upgrade` &ndash; `apt list --upgradable` sonrası `apt upgrade` çalıştırmanıza yardımcı olur;
* `brew_cask_dependency` &ndash; cask bağımlılıklarını yükler;
* `brew_install` &ndash; `brew install` için formül adını düzeltir;
* `brew_reinstall` &ndash; `brew install <formül>`'ü `brew reinstall <formül>`'e çevirir;
* `brew_link` &ndash; bağlantı başarısızsa `--overwrite --dry-run` ekler;
* `brew_uninstall` &ndash; birden fazla sürüm yüklüyse `brew uninstall`'a `--force` ekler;
* `brew_unknown_command` &ndash; `brew docto/brew doctor` gibi yanlış brew komutlarını düzeltir;
* `brew_update_formula` &ndash; `brew update <formül>`'ü `brew upgrade <formül>`'e çevirir;
* `dnf_no_such_command` &ndash; yanlış yazılmış DNF komutlarını düzeltir;
* `nixos_cmd_not_found` &ndash; NixOS'ta uygulama kurar;
* `pacman` &ndash; uygulama yüklü değilse `pacman` ile yükler (`yay`, `pikaur` veya `yaourt` varsa onları kullanır);
* `pacman_invalid_option` &ndash; küçük harfli `pacman` seçeneklerini büyük harf ile değiştirir;
* `pacman_not_found` &ndash; `pacman`, `yay`, `pikaur` veya `yaourt` ile paket adını düzeltir;
* `yum_invalid_operation` &ndash; `yum isntall vim` gibi geçersiz `yum` çağrılarını düzeltir;

Aşağıdaki komutlar *The Fuck* ile birlikte gelir, fakat varsayılan olarak etkin değildir:

* `git_push_force` &ndash; bir `git push`'a `--force-with-lease` ekler ( `git_push_pull` ile çakışabilir );
* `rm_root` &ndash; `rm -rf /` komutuna `--no-preserve-root` ekler.

##### [İçindekilere Dön](#contents)

## Kendi kurallarınızı oluşturma

Kendi kuralınızı eklemek için `~/.config/thefuck/rules` dizininde
`your-rule-name.py` adında bir dosya oluşturun. Kural dosyası şu iki fonksiyonu içermelidir:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Ek olarak, kurallar isteğe bağlı fonksiyonlar da içerebilir:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Kurallar ayrıca `enabled_by_default`, `requires_output` ve `priority` gibi isteğe bağlı değişkenler de içerebilir.

`Command` üç özelliğe sahiptir: `script`, `output` ve `script_parts`.
Kuralınız `Command`'ı değiştirmemelidir.

**Kurallar API'si 3.0'da değişti:** Bir kuralın ayarlarına erişmek için şunu içe aktarın:
 `from thefuck.conf import settings`

`settings`, `~/.config/thefuck/settings.py` ve ortam değişkenlerinden ([aşağıya bakınız](#settings)) derlenen özel bir nesnedir.

Bir scripti `sudo` ile çalıştırmak için basit bir örnek kural:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Opsiyonel:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Küçük öncelik önce, varsayılan 1000'dir

requires_output = True
```

[Daha fazla kural örneği](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[kurallar için yardımcı fonksiyonlar](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[uygulama/işletim sistemi özel yardımcılar](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [İçindekilere Dön](#contents)

## Ayarlar

Birçok *The Fuck* parametresi, `$XDG_CONFIG_HOME/thefuck/settings.py` dosyasında
(`$XDG_CONFIG_HOME` varsayılan olarak `~/.config`) değiştirilebilir:

* `rules` &ndash; etkin kuralların listesi, varsayılan olarak `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; devre dışı bırakılan kuralların listesi, varsayılan olarak `[]`;
* `require_confirmation` &ndash; yeni komutu çalıştırmadan önce onay ister, varsayılanı `True`;
* `wait_command` &ndash; önceki komut çıktısını almak için maksimum saniye;
* `no_colors` &ndash; renkli çıktıyı devre dışı bırakır;
* `priority` &ndash; kuralların öncelik sözlüğü, düşük `priority` ilk eşleşir;
* `debug` &ndash; hata ayıklama çıktısını etkinleştirir, varsayılanı `False`;
* `history_limit` &ndash; kaç komutun geçmişte taranacağını sayısal olarak belirtir, örn: `2000`;
* `alter_history` &ndash; düzeltilen komutu geçmişe ekler, varsayılanı `True`;
* `wait_slow_command` &ndash; `slow_commands` listesindeyse önceki komut çıktısını almak için maksimum saniye;
* `slow_commands` &ndash; yavaş komutlar listesi;
* `num_close_matches` &ndash; önerilecek en fazla benzer komut sayısı, varsayılan `3`;
* `excluded_search_path_prefixes` &ndash; komut ararken göz ardı edilecek yol önekleri, varsayılanı `[]`.

Bir `settings.py` örneği:

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

Veya ortam değişkenleriyle:

* `THEFUCK_RULES` &ndash; etkin kuralların listesi, örn: `DEFAULT_RULES:rm_root` veya `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; devre dışı bırakılan kurallar, örn: `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; yeni komutu çalıştırmadan önce onay ister, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; önceki komut çıktısını almak için maksimum saniye;
* `THEFUCK_NO_COLORS` &ndash; renkli çıktıyı devre dışı bırakır, `true/false`;
* `THEFUCK_PRIORITY` &ndash; kuralların önceliği, örn: `no_command=9999:apt_get=100`, düşük `priority` ilk eşleşir;
* `THEFUCK_DEBUG` &ndash; hata ayıklama çıktısını etkinleştirir, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; kaç komutun geçmişte taranacağı, örn: `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; düzeltilen komutu geçmişe ekler, `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; `slow_commands` listesinde ise önceki komut çıktısını almak için maksimum saniye;
* `THEFUCK_SLOW_COMMANDS` &ndash; yavaş komutlar listesi, örn: `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; önerilecek maksimum benzer komut sayısı, örn: `5`;
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; komut ararken göz ardı edilecek yol önekleri, varsayılanı `[]`.

Örneğin:

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

##### [İçindekilere Dön](#contents)

## Kurallı üçüncü taraf paketler

Özel bir dizi kapalı kural oluşturmak istiyor, fakat başkalarıyla da paylaşmak istiyorsanız, aşağıdaki yapıda `thefuck_contrib_*` adlı bir paket oluşturun:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *üçüncü taraf kurallar*
    __init__.py
    *üçüncü taraf yardımcılar*
  setup.py
```

*The Fuck* kuralları `rules` modülünde bulacaktır.

##### [İçindekilere Dön](#contents)

## Deneysel anında mod

*The Fuck*'ın varsayılan davranışı, önceki komutları tekrar çalıştırmak için zaman gerektirir.
Anında modda, *The Fuck* [script](https://en.wikipedia.org/wiki/Script_(Unix)) ile çıktıyı kaydederek zamandan tasarruf eder ve kaydı okur.

[![instant mode ile gif][instant-mode-gif-link]][instant-mode-gif-link]

Şu anda anında mod yalnızca bash veya zsh ile Python 3'ü desteklemektedir. thefuck'ın düzgün çalışması için zsh'nin otomatik düzeltme işlevinin de devre dışı bırakılması gerekir.

Anında modu etkinleştirmek için `.bashrc`, `.bash_profile` veya `.zshrc`'daki alias başlatma kısmına `--enable-experimental-instant-mode` ekleyin.

Örneğin:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [İçindekilere Dön](#contents)

## Geliştirme

[CONTRIBUTING.md](CONTRIBUTING.md)'ye bakınız

## Lisans MIT
Proje lisansı [burada](LICENSE.md) bulunabilir.


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

##### [İçindekilere Dön](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---