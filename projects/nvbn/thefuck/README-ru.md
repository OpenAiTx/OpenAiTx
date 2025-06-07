# The Fuck [![Версия][version-badge]][version-link] [![Статус сборки][workflow-badge]][workflow-link] [![Покрытие][coverage-badge]][coverage-link] [![Лицензия MIT][license-badge]](LICENSE.md)

*The Fuck* — это великолепное приложение, вдохновлённое [твитом](https://twitter.com/liamosaur/status/506975850596536320) [@liamosaur](https://twitter.com/liamosaur/),
которое исправляет ошибки в предыдущих командах консоли.

*The Fuck* слишком медленный? [Попробуйте экспериментальный мгновенный режим!](#experimental-instant-mode)

[![gif с примерами][examples-link]][examples-link]

Больше примеров:

```bash
➜ apt-get install vim
E: Не удалось открыть файл блокировки /var/lib/dpkg/lock - open (13: Permission denied)
E: Не удалось заблокировать каталог администрирования (/var/lib/dpkg/), вы root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] пароль для nvbn:
Чтение списков пакетов... Готово
...
```

```bash
➜ git push
fatal: Текущая ветка master не имеет upstream ветки.
Чтобы отправить текущую ветку и установить remote как upstream, используйте

    git push --set-upstream origin master


➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Подсчёт объектов: 9, готово.
...
```

```bash
➜ puthon
Команда 'puthon' не найдена, возможно вы имели в виду:
 Команда 'python' из пакета 'python-minimal' (main)
 Команда 'python' из пакета 'python3' (main)
zsh: команда не найдена: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' не является командой git. Смотрите 'git --help'.

Возможно вы имели в виду?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' не является задачей. Смотрите 'lein help'.

Возможно вы имели в виду?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL server started on port 54848 on host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Если вы не боитесь автоматически запускать исправленные команды, опцию
`require_confirmation` в [настройках](#settings) можно отключить:

```bash
➜ apt-get install vim
E: Не удалось открыть файл блокировки /var/lib/dpkg/lock - open (13: Permission denied)
E: Не удалось заблокировать каталог администрирования (/var/lib/dpkg/), вы root?

➜ fuck
sudo apt-get install vim
[sudo] пароль для nvbn:
Чтение списков пакетов... Готово
...
```

## Содержание

1. [Требования](#requirements)
2. [Установка](#installation)
3. [Обновление](#updating)
4. [Как это работает](#how-it-works)
5. [Создание собственных правил](#creating-your-own-rules)
6. [Настройки](#settings)
7. [Сторонние пакеты с правилами](#third-party-packages-with-rules)
8. [Экспериментальный мгновенный режим](#experimental-instant-mode)
9. [Разработка](#developing)
10. [Лицензия](#license-mit)

## Требования

- python (3.5+)
- pip
- python-dev

##### [Вернуться к содержанию](#contents)

## Установка

На macOS или Linux вы можете установить *The Fuck* с помощью [Homebrew][homebrew]:

```bash
brew install thefuck
```

На Ubuntu / Mint установите *The Fuck* следующими командами:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

На FreeBSD установите *The Fuck* следующей командой:
```bash
pkg install thefuck
```

На ChromeOS установите *The Fuck* с помощью [chromebrew](https://github.com/skycocker/chromebrew) командой:
```bash
crew install thefuck
```

На системах на базе Arch установите *The Fuck* так:
```
sudo pacman -S thefuck
```

На других системах установите *The Fuck* с помощью `pip`:

```bash
pip install thefuck
```

[В качестве альтернативы, вы можете использовать менеджер пакетов ОС (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Рекомендуется добавить эту команду в ваш `.bash_profile`,
`.bashrc`, `.zshrc` или другой файл инициализации оболочки:

```bash
eval $(thefuck --alias)
# Вы можете использовать любой алиас, например для понедельников:
eval $(thefuck --alias FUCK)
```

[Или в конфиг вашей оболочки (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Изменения будут доступны только в новой сессии оболочки. Чтобы изменения вступили в силу сразу,
выполните `source ~/.bashrc` (или соответствующий конфиг вашей оболочки, например `.zshrc`).

Чтобы запускать исправленные команды без подтверждения, используйте опцию `--yeah` (или просто `-y`, либо `--hard`, если вы особенно раздражены):

```bash
fuck --yeah
```

Чтобы исправлять команды рекурсивно до успешного выполнения, используйте опцию `-r`:

```bash
fuck -r
```

##### [Вернуться к содержанию](#contents)

## Обновление

```bash
pip3 install thefuck --upgrade
```

**Примечание: Функциональность алиасов была изменена в v1.34 *The Fuck***

## Удаление

Чтобы удалить *The Fuck*, выполните обратные действия установки:
- удалите или закомментируйте строку с алиасом *thefuck* из конфигурационного файла вашей оболочки (Bash, Zsh, Fish, Powershell, tcsh и др.)
- используйте ваш менеджер пакетов (brew, pip3, pkg, crew, pip) для удаления бинарных файлов

## Как это работает

*The Fuck* пытается сопоставить предыдущую команду с правилом. Если найдено соответствие,
создаётся новая команда, которая формируется согласно правилу и выполняется. По умолчанию включены следующие правила:

* `adb_unknown_command` – исправляет опечатки в командах типа `adb logcta`;
* `ag_literal` – добавляет `-Q` к `ag`, если это предлагается;
* `aws_cli` – исправляет опечатки в командах типа `aws dynamdb scan`;
* `az_cli` – исправляет опечатки в командах типа `az providers`;
* `cargo` – запускает `cargo build` вместо `cargo`;
* `cargo_no_command` – исправляет неверные команды типа `cargo buid`;
* `cat_dir` – заменяет `cat` на `ls`, если вы пытаетесь просмотреть каталог;
* `cd_correction` – проверка орфографии и исправление неудачных команд cd;
* `cd_cs` – заменяет `cs` на `cd`;
* `cd_mkdir` – создаёт директории перед переходом в них через cd;
* `cd_parent` – заменяет `cd..` на `cd ..`;
* `chmod_x` – добавляет бит выполнения;
* `choco_install` – добавляет распространённые суффиксы для пакетов chocolatey;
* `composer_not_command` – исправляет имя команды composer;
* `conda_mistype` – исправляет команды conda;
* `cp_create_destination` – создаёт новую директорию, если вы пытаетесь `cp` или `mv` в несуществующую;
* `cp_omitting_directory` – добавляет `-a`, если вы копируете директорию;
* `cpp11` – добавляет недостающий `-std=c++11` к `g++` или `clang++`;
* `dirty_untar` – исправляет команду `tar x`, которая распаковала в текущую директорию;
* `dirty_unzip` – исправляет команду `unzip`, которая разархивировала в текущую директорию;
* `django_south_ghost` – добавляет `--delete-ghost-migrations` к неудачным миграциям django south;
* `django_south_merge` – добавляет `--merge` к неконсистентным миграциям django south;
* `docker_login` – выполняет `docker login` и повторяет предыдущую команду;
* `docker_not_command` – исправляет неверные команды docker типа `docker tags`;
* `docker_image_being_used_by_container` – удаляет контейнер, использующий образ, перед его удалением;
* `dry` – исправляет повторения типа `git git push`;
* `fab_command_not_found` – исправляет опечатки в командах fabric;
* `fix_alt_space` – заменяет Alt+Space на обычный пробел;
* `fix_file` – открывает файл с ошибкой в вашем `$EDITOR`;
* `gem_unknown_command` – исправляет неверные команды `gem`;
* `git_add` – исправляет *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` – добавляет `--force` к `git add <pathspec>...`, если пути в .gitignore;
* `git_bisect_usage` – исправляет `git bisect strt`, `git bisect goood`, `git bisect rset` и т.д. при работе с bisect;
* `git_branch_delete` – заменяет `git branch -d` на `git branch -D`;
* `git_branch_delete_checked_out` – заменяет `git branch -d` на `git checkout master && git branch -D` при попытке удалить активную ветку;
* `git_branch_exists` – предлагает `git branch -d foo`, `git branch -D foo` или `git checkout foo` при создании уже существующей ветки;
* `git_branch_list` – ловит `git branch list` вместо `git branch` и удаляет созданную ветку;
* `git_branch_0flag` – исправляет команды типа `git branch 0v` и `git branch 0r`, удаляя созданную ветку;
* `git_checkout` – исправляет имя ветки или создаёт новую ветку;
* `git_clone_git_clone` – заменяет `git clone git clone ...` на `git clone ...`;
* `git_clone_missing` – добавляет `git clone` к URL, похожим на репозиторий git;
* `git_commit_add` – предлагает `git commit -a ...` или `git commit -p ...` после неудачного коммита, если ничего не было подготовлено;
* `git_commit_amend` – предлагает `git commit --amend` после предыдущего коммита;
* `git_commit_reset` – предлагает `git reset HEAD~` после предыдущего коммита;
* `git_diff_no_index` – добавляет `--no-index` к предыдущему `git diff` на нетреканных файлах;
* `git_diff_staged` – добавляет `--staged` к предыдущему `git diff` с неожиданным выводом;
* `git_fix_stash` – исправляет команды `git stash` (опечатки в подкомандах и отсутствие `save`);
* `git_flag_after_filename` – исправляет `fatal: bad flag '...' after filename`;
* `git_help_aliased` – исправляет команды `git help <alias>`, заменяя <alias> на команду;
* `git_hook_bypass` – добавляет флаг `--no-verify` к командам `git am`, `git commit` или `git push`;
* `git_lfs_mistype` – исправляет опечатки в командах `git lfs <command>`;
* `git_main_master` – исправляет неправильное имя ветки между `main` и `master`;
* `git_merge` – добавляет remote к именам веток;
* `git_merge_unrelated` – добавляет `--allow-unrelated-histories`, когда это требуется;
* `git_not_command` – исправляет неверные команды git типа `git brnch`;
* `git_pull` – устанавливает upstream перед выполнением предыдущего `git pull`;
* `git_pull_clone` – клонирует, если репозиторий не существует, вместо pull;
* `git_pull_uncommitted_changes` – делает stash перед pull и возвращает изменения после;
* `git_push` – добавляет `--set-upstream origin $branch` к неудавшемуся `git push`;
* `git_push_different_branch_names` – исправляет push, если локальное имя ветки не совпадает с remote;
* `git_push_pull` – выполняет `git pull`, если push был отклонён;
* `git_push_without_commits` – создаёт первый коммит, если вы забыли и сделали только `git add .` при создании нового проекта;
* `git_rebase_no_changes` – выполняет `git rebase --skip` вместо `git rebase --continue`, если нет изменений;
* `git_remote_delete` – заменяет `git remote delete remote_name` на `git remote remove remote_name`;
* `git_rm_local_modifications` – добавляет `-f` или `--cached`, если вы пытаетесь удалить локально изменённый файл;
* `git_rm_recursive` – добавляет `-r`, если вы пытаетесь удалить директорию;
* `git_rm_staged` – добавляет `-f` или `--cached`, если вы пытаетесь удалить файл с подготовленными изменениями;
* `git_rebase_merge_dir` – предлагает `git rebase (--continue | --abort | --skip)` или удаление `.git/rebase-merge` при активном rebase;
* `git_remote_seturl_add` – выполняет `git remote add`, если `git remote set_url` на несуществующий remote;
* `git_stash` – делает stash ваших локальных изменений перед rebase или сменой ветки;
* `git_stash_pop` – добавляет ваши локальные изменения перед pop stash, затем сбрасывает;
* `git_tag_force` – добавляет `--force` к `git tag <tagname>`, если тег уже существует;
* `git_two_dashes` – добавляет недостающий дефис к командам типа `git commit -amend` или `git rebase -continue`;
* `go_run` – добавляет расширение `.go` при компиляции/запуске Go-программ;
* `go_unknown_command` – исправляет неверные команды `go`, например `go bulid`;
* `gradle_no_task` – исправляет не найденные или неоднозначные задачи gradle;
* `gradle_wrapper` – заменяет `gradle` на `./gradlew`;
* `grep_arguments_order` – исправляет порядок аргументов `grep` для случаев типа `grep -lir . test`;
* `grep_recursive` – добавляет `-r`, если вы пытаетесь `grep` директорию;
* `grunt_task_not_found` – исправляет опечатки в командах grunt;
* `gulp_not_task` – исправляет опечатки в задачах gulp;
* `has_exists_script` – добавляет `./`, если скрипт/бинарник существует;
* `heroku_multiple_apps` – добавляет `--app <app>` к командам heroku типа `heroku pg`;
* `heroku_not_command` – исправляет неверные команды heroku типа `heroku log`;
* `history` – пытается заменить команду самой похожей из истории;
* `hostscli` – пытается исправить использование `hostscli`;
* `ifconfig_device_not_found` – исправляет имена устройств типа `wlan0` на `wlp2s0`;
* `java` – убирает расширение `.java` при запуске Java-программ;
* `javac` – добавляет недостающее `.java` при компиляции файлов Java;
* `lein_not_task` – исправляет неверные задачи lein типа `lein rpl`;
* `long_form_help` – заменяет `-h` на `--help`, если короткая форма не поддерживается;
* `ln_no_hard_link` – ловит попытки создания жёсткой ссылки на директории, предлагает символическую;
* `ln_s_order` – исправляет порядок аргументов `ln -s`;
* `ls_all` – добавляет `-A` к `ls`, если вывод пуст;
* `ls_lah` – добавляет `-lah` к `ls`;
* `man` – меняет секцию мануала;
* `man_no_space` – исправляет команды man без пробела, например `mandiff`;
* `mercurial` – исправляет неверные команды hg;
* `missing_space_before_subcommand` – исправляет команды без пробела, например `npminstall`;
* `mkdir_p` – добавляет `-p`, если вы создаёте директорию без родителя;
* `mvn_no_command` – добавляет `clean package` к `mvn`;
* `mvn_unknown_lifecycle_phase` – исправляет опечатки в фазах жизненного цикла mvn;
* `npm_missing_script` – исправляет имя кастомного скрипта npm в `npm run-script <script>`;
* `npm_run_script` – добавляет недостающий `run-script` для кастомных скриптов npm;
* `npm_wrong_command` – исправляет неверные команды npm типа `npm urgrade`;
* `no_command` – исправляет неверные команды консоли, например `vom/vim`;
* `no_such_file` – создаёт недостающие директории с командами `mv` и `cp`;
* `omnienv_no_such_command` – исправляет неверные команды для `goenv`, `nodenv`, `pyenv` и `rbenv` (например: `pyenv isntall` или `goenv list`);
* `open` – либо добавляет `http://` к адресу для `open`, либо создаёт новый файл/директорию и передаёт их в `open`;
* `pip_install` – исправляет проблемы с правами для `pip install`, добавляя `--user` или подготавливая `sudo` при необходимости;
* `pip_unknown_command` – исправляет неверные команды pip, например `pip instatl/pip install`;
* `php_s` – заменяет `-s` на `-S` при попытке запустить локальный php сервер;
* `port_already_in_use` – завершает процесс, который занимает порт;
* `prove_recursively` – добавляет `-r` при вызове с директорией;
* `python_command` – добавляет `python` при попытке запустить неисполняемый или без `./` python-скрипт;
* `python_execute` – добавляет недостающее `.py` при выполнении Python-файлов;
* `python_module_error` – исправляет ModuleNotFoundError, пытаясь выполнить `pip install` для этого модуля;
* `quotation_marks` – исправляет несимметричное использование `'` и `"`;
* `path_from_history` – заменяет не найденный путь на похожий абсолютный из истории;
* `rails_migrations_pending` – запускает ожидающие миграции;
* `react_native_command_unrecognized` – исправляет нераспознанные команды `react-native`;
* `remove_shell_prompt_literal` – удаляет ведущий символ приглашения `$`, часто встречается при копировании команд из документации;
* `remove_trailing_cedilla` – удаляет конечные седильи `ç`, распространённая опечатка для европейских раскладок;
* `rm_dir` – добавляет `-rf` при попытке удалить директорию;
* `scm_correction` – исправляет неверные scm, например `hg log` на `git log`;
* `sed_unterminated_s` – добавляет недостающий '/' к командам `sed` типа `s`;
* `sl_ls` – меняет `sl` на `ls`;
* `ssh_known_hosts` – удаляет хост из `known_hosts` при предупреждении;
* `sudo` – добавляет `sudo` к предыдущей команде, если она завершилась ошибкой из-за прав;
* `sudo_command_from_user_path` – запускает команды из пользовательского `$PATH` с `sudo`;
* `switch_lang` – переключает команду с локальной раскладки на en;
* `systemctl` – правильно упорядочивает параметры для запутанных команд systemctl;
* `terraform_init.py` – выполняет `terraform init` перед планом или применением;
* `terraform_no_command.py` – исправляет нераспознанные команды terraform;
* `test.py` – запускает `pytest` вместо `test.py`;
* `touch` – создаёт недостающие директории перед использованием "touch";
* `tsuru_login` – выполняет `tsuru login`, если не аутентифицирован или сессия истекла;
* `tsuru_not_command` – исправляет неверные команды tsuru типа `tsuru shell`;
* `tmux` – исправляет команды tmux;
* `unknown_command` – исправляет hadoop/hdfs-стиль "unknown command", например, добавляет недостающий '-' к команде `hdfs dfs ls`;
* `unsudo` – удаляет `sudo` из предыдущей команды, если процесс отказывается работать с привилегиями суперпользователя;
* `vagrant_up` – запускает экземпляр vagrant;
* `whois` – исправляет команду whois;
* `workon_doesnt_exists` – исправляет имя окружения `virtualenvwrapper` или предлагает создать новое;
* `wrong_hyphen_before_subcommand` – удаляет неправильно размещённый дефис (`apt-install` -> `apt install`, `git-log` -> `git log` и т.д.);
* `yarn_alias` – исправляет алиасированные команды yarn типа `yarn ls`;
* `yarn_command_not_found` – исправляет опечатки в командах yarn;
* `yarn_command_replaced` – исправляет заменённые команды yarn;
* `yarn_help` – облегчает открытие документации yarn;

##### [Вернуться к содержанию](#contents)

Следующие правила включены по умолчанию только на определённых платформах:

* `apt_get` – устанавливает приложение через apt, если оно не установлено (требует `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` – меняет попытки поиска через `apt-get` на поиск через `apt-cache`;
* `apt_invalid_operation` – исправляет неправильные вызовы `apt` и `apt-get`, например `apt-get isntall vim`;
* `apt_list_upgradable` – предлагает выполнить `apt list --upgradable` после `apt update`;
* `apt_upgrade` – предлагает выполнить `apt upgrade` после `apt list --upgradable`;
* `brew_cask_dependency` – устанавливает зависимости cask;
* `brew_install` – исправляет имя формулы для `brew install`;
* `brew_reinstall` – превращает `brew install <formula>` в `brew reinstall <formula>`;
* `brew_link` – добавляет `--overwrite --dry-run` при неудачной ссылке;
* `brew_uninstall` – добавляет `--force` к `brew uninstall`, если установлено несколько версий;
* `brew_unknown_command` – исправляет неверные команды brew, например `brew docto/brew doctor`;
* `brew_update_formula` – превращает `brew update <formula>` в `brew upgrade <formula>`;
* `dnf_no_such_command` – исправляет опечатки в командах DNF;
* `nixos_cmd_not_found` – устанавливает приложения в NixOS;
* `pacman` – устанавливает приложение через `pacman`, если оно не установлено (использует `yay`, `pikaur` или `yaourt`, если доступны);
* `pacman_invalid_option` – заменяет строчные опции pacman на прописные;
* `pacman_not_found` – исправляет имя пакета с помощью `pacman`, `yay`, `pikaur` или `yaourt`;
* `yum_invalid_operation` – исправляет неправильные вызовы `yum`, например `yum isntall vim`;

Следующие команды входят в комплект *The Fuck*, но по умолчанию не включены:

* `git_push_force` – добавляет `--force-with-lease` к `git push` (может конфликтовать с `git_push_pull`);
* `rm_root` – добавляет `--no-preserve-root` к команде `rm -rf /`;

##### [Вернуться к содержанию](#contents)

## Создание собственных правил

Чтобы добавить своё правило, создайте файл с именем `your-rule-name.py`
в `~/.config/thefuck/rules`. Файл правила должен содержать две функции:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Дополнительно правило может содержать необязательные функции:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Правила могут также содержать необязательные переменные `enabled_by_default`, `requires_output` и `priority`.

`Command` имеет три атрибута: `script`, `output` и `script_parts`.
Ваше правило не должно изменять объект `Command`.


**API правил изменился в 3.0:** Для доступа к настройкам правила импортируйте его так:
 `from thefuck.conf import settings`

`settings` — специальный объект, собираемый из `~/.config/thefuck/settings.py`
и переменных окружения ([подробнее ниже](#settings)).

Простой пример правила для запуска скрипта с `sudo`:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Необязательно:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Меньше — раньше, по умолчанию 1000

requires_output = True
```

[Больше примеров правил](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[вспомогательные функции для правил](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[специфические для приложений/ОС функции](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Вернуться к содержанию](#contents)

## Настройки

Несколько параметров *The Fuck* можно изменить в файле `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` по умолчанию — `~/.config`):

* `rules` – список включённых правил, по умолчанию `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` – список отключённых правил, по умолчанию `[]`;
* `require_confirmation` – требуется подтверждение перед запуском новой команды, по умолчанию `True`;
* `wait_command` – максимальное время (в секундах) ожидания вывода предыдущей команды;
* `no_colors` – отключить цветной вывод;
* `priority` – словарь с приоритетами правил, правило с меньшим `priority` будет выбрано первым;
* `debug` – включить отладочный вывод, по умолчанию `False`;
* `history_limit` – количество команд истории, которые будут просканированы, например, `2000`;
* `alter_history` – добавлять исправленную команду в историю, по умолчанию `True`;
* `wait_slow_command` – максимальное время ожидания вывода предыдущей команды из списка `slow_commands`;
* `slow_commands` – список медленных команд;
* `num_close_matches` – максимальное количество близких вариантов для предложения, по умолчанию `3`;
* `excluded_search_path_prefixes` – префиксы путей, игнорируемые при поиске команд, по умолчанию `[]`.

Пример `settings.py`:

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

Или через переменные окружения:

* `THEFUCK_RULES` – список включённых правил, например `DEFAULT_RULES:rm_root` или `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` – список отключённых правил, например `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` – требуется подтверждение перед запуском новой команды, `true/false`;
* `THEFUCK_WAIT_COMMAND` – максимальное время ожидания вывода предыдущей команды (секунды);
* `THEFUCK_NO_COLORS` – отключить цветной вывод, `true/false`;
* `THEFUCK_PRIORITY` – приоритеты правил, например `no_command=9999:apt_get=100`,
правило с меньшим `priority` будет выбрано первым;
* `THEFUCK_DEBUG` – включить отладочный вывод, `true/false`;
* `THEFUCK_HISTORY_LIMIT` – сколько команд истории будет просканировано, например, `2000`;
* `THEFUCK_ALTER_HISTORY` – добавлять исправленную команду в историю, `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` – максимальное время ожидания вывода предыдущей команды из списка `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` – список медленных команд, например `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` – максимальное количество близких вариантов, например `5`;
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` – префиксы путей для игнорирования при поиске команд, по умолчанию `[]`.

Например:

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

##### [Вернуться к содержанию](#contents)

## Сторонние пакеты с правилами

Если вы хотите создать набор непубличных правил, но при этом делиться ими с другими, создайте пакет с именем `thefuck_contrib_*` со следующей структурой:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *сторонние правила*
    __init__.py
    *сторонние утилиты*
  setup.py
```

*The Fuck* найдёт правила, расположенные в модуле `rules`.

##### [Вернуться к содержанию](#contents)

## Экспериментальный мгновенный режим

Стандартное поведение *The Fuck* требует времени на повторный запуск предыдущих команд.
В мгновенном режиме *The Fuck* экономит время, логируя вывод с помощью [script](https://en.wikipedia.org/wiki/Script_(Unix)),
а затем читая лог.

[![gif с мгновенным режимом][instant-mode-gif-link]][instant-mode-gif-link]

В данный момент мгновенный режим поддерживает только Python 3 с bash или zsh. Также функцию автокоррекции zsh необходимо отключить, чтобы thefuck работал корректно.

Чтобы включить мгновенный режим, добавьте `--enable-experimental-instant-mode`
к инициализации алиаса в `.bashrc`, `.bash_profile` или `.zshrc`.

Например:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Вернуться к содержанию](#contents)

## Разработка

Смотрите [CONTRIBUTING.md](CONTRIBUTING.md)

## Лицензия MIT
Лицензию проекта можно найти [здесь](LICENSE.md).


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

##### [Вернуться к содержанию](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---