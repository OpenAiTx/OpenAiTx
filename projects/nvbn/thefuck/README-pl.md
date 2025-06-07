# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* to wspaniała aplikacja inspirowana [tweetem](https://twitter.com/liamosaur/status/506975850596536320) [@liamosaur](https://twitter.com/liamosaur/), która poprawia błędy w poprzednich poleceniach konsoli.

Czy *The Fuck* jest za wolny? [Wypróbuj eksperymentalny tryb natychmiastowy!](#experimental-instant-mode)

[![gif z przykładami][examples-link]][examples-link]

Więcej przykładów:

```bash
➜ apt-get install vim
E: Nie można otworzyć pliku blokady /var/lib/dpkg/lock - open (13: Brak uprawnień)
E: Nie można zablokować katalogu administracyjnego (/var/lib/dpkg/), czy jesteś rootem?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] hasło dla nvbn:
Odczytywanie listy pakietów... Gotowe
...
```

```bash
➜ git push
fatal: Bieżąca gałąź master nie ma gałęzi nadrzędnej.
Aby przesłać bieżącą gałąź i ustawić zdalną jako nadrzędną, użyj

    git push --set-upstream origin master


➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Zliczanie obiektów: 9, gotowe.
...
```

```bash
➜ puthon
Nie znaleziono polecenia 'puthon', czy chodziło ci o:
 Polecenie 'python' z pakietu 'python-minimal' (main)
 Polecenie 'python' z pakietu 'python3' (main)
zsh: polecenie nie znalezione: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' nie jest poleceniem git. Zobacz 'git --help'.

Czy chodziło ci o to?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' nie jest zadaniem. Zobacz 'lein help'.

Czy chodziło ci o to?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL server started on port 54848 on host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Jeśli nie boisz się ślepo uruchamiać poprawionych poleceń, opcję `require_confirmation` w [ustawieniach](#settings) można wyłączyć:

```bash
➜ apt-get install vim
E: Nie można otworzyć pliku blokady /var/lib/dpkg/lock - open (13: Brak uprawnień)
E: Nie można zablokować katalogu administracyjnego (/var/lib/dpkg/), czy jesteś rootem?

➜ fuck
sudo apt-get install vim
[sudo] hasło dla nvbn:
Odczytywanie listy pakietów... Gotowe
...
```

## Spis treści

1. [Wymagania](#requirements)
2. [Instalacja](#installation)
3. [Aktualizacja](#updating)
4. [Jak to działa](#how-it-works)
5. [Tworzenie własnych reguł](#creating-your-own-rules)
6. [Ustawienia](#settings)
7. [Zewnętrzne pakiety z regułami](#third-party-packages-with-rules)
8. [Eksperymentalny tryb natychmiastowy](#experimental-instant-mode)
9. [Rozwój](#developing)
10. [Licencja](#license-mit)

## Wymagania

- python (3.5+)
- pip
- python-dev

##### [Powrót do spisu treści](#contents)

## Instalacja

Na macOS lub Linuksie możesz zainstalować *The Fuck* za pomocą [Homebrew][homebrew]:

```bash
brew install thefuck
```

Na Ubuntu / Mint zainstaluj *The Fuck* za pomocą następujących poleceń:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

Na FreeBSD zainstaluj *The Fuck* za pomocą następujących poleceń:
```bash
pkg install thefuck
```

Na ChromeOS zainstaluj *The Fuck* korzystając z [chromebrew](https://github.com/skycocker/chromebrew) za pomocą polecenia:
```bash
crew install thefuck
```

W systemach opartych na Arch zainstaluj *The Fuck* poleceniem:
```
sudo pacman -S thefuck
```

W innych systemach zainstaluj *The Fuck* używając `pip`:

```bash
pip install thefuck
```

[Alternatywnie możesz użyć menedżera pakietów systemu operacyjnego (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Zaleca się dodanie tej komendy do swojego `.bash_profile`,
`.bashrc`, `.zshrc` lub innego skryptu startowego:

```bash
eval $(thefuck --alias)
# Możesz użyć dowolnej nazwy aliasu, np. na poniedziałki:
eval $(thefuck --alias FUCK)
```

[Lub do konfiguracji powłoki (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Zmiany będą dostępne tylko w nowej sesji powłoki. Aby zmiany były dostępne natychmiast,
uruchom `source ~/.bashrc` (lub odpowiedni plik konfiguracyjny powłoki, np. `.zshrc`).

Aby uruchamiać poprawione polecenia bez potwierdzenia, użyj opcji `--yeah` (lub krótszej `-y`, albo `--hard`, jeśli jesteś szczególnie sfrustrowany):

```bash
fuck --yeah
```

Aby poprawiać polecenia rekurencyjnie aż do skutku, użyj opcji `-r`:

```bash
fuck -r
```

##### [Powrót do spisu treści](#contents)

## Aktualizacja

```bash
pip3 install thefuck --upgrade
```

**Uwaga: Funkcjonalność aliasu została zmieniona w wersji v1.34 *The Fuck***

## Odinstalowanie

Aby usunąć *The Fuck*, odwróć proces instalacji:
- usuń lub zakomentuj linię aliasu *thefuck* ze swojego pliku konfiguracyjnego powłoki (Bash, Zsh, Fish, Powershell, tcsh, ...)
- użyj menedżera pakietów (brew, pip3, pkg, crew, pip), aby odinstalować pliki binarne

## Jak to działa

*The Fuck* próbuje dopasować poprzednie polecenie do reguły. Jeśli zostanie znalezione dopasowanie, zostanie utworzone nowe polecenie na podstawie dopasowanej reguły i wykonane. Następujące reguły są domyślnie włączone:

* `adb_unknown_command` – poprawia błędnie napisane polecenia, np. `adb logcta`;
* `ag_literal` – dodaje `-Q` do `ag`, gdy jest sugerowane;
* `aws_cli` – poprawia błędnie napisane polecenia, np. `aws dynamdb scan`;
* `az_cli` – poprawia błędnie napisane polecenia, np. `az providers`;
* `cargo` – uruchamia `cargo build` zamiast `cargo`;
* `cargo_no_command` – poprawia błędne polecenia, np. `cargo buid`;
* `cat_dir` – zamienia `cat` na `ls`, gdy próbujesz wykonać `cat` na katalogu;
* `cd_correction` – sprawdza pisownię i poprawia nieudane polecenia cd;
* `cd_cs` – zmienia `cs` na `cd`;
* `cd_mkdir` – tworzy katalogi przed wejściem do nich poleceniem cd;
* `cd_parent` – zamienia `cd..` na `cd ..`;
* `chmod_x` – dodaje bit wykonywalności;
* `choco_install` – dodaje popularne sufiksy do pakietów chocolatey;
* `composer_not_command` – poprawia nazwę polecenia composer;
* `conda_mistype` – poprawia polecenia conda;
* `cp_create_destination` – tworzy nowy katalog, gdy próbujesz `cp` lub `mv` do nieistniejącego;
* `cp_omitting_directory` – dodaje `-a` podczas kopiowania katalogu;
* `cpp11` – dodaje brakujące `-std=c++11` do `g++` lub `clang++`;
* `dirty_untar` – poprawia polecenie `tar x`, które rozpakowało pliki w bieżącym katalogu;
* `dirty_unzip` – poprawia polecenie `unzip`, które rozpakowało pliki w bieżącym katalogu;
* `django_south_ghost` – dodaje `--delete-ghost-migrations` do nieudanej migracji south django z powodu duchów;
* `django_south_merge` – dodaje `--merge` do niespójnej migracji south django;
* `docker_login` – wykonuje `docker login` i powtarza poprzednie polecenie;
* `docker_not_command` – poprawia błędne polecenia docker, np. `docker tags`;
* `docker_image_being_used_by_container` – usuwa kontener korzystający z obrazu przed usunięciem obrazu;
* `dry` – poprawia powtórzenia, np. `git git push`;
* `fab_command_not_found` – poprawia błędnie napisane polecenia fabric;
* `fix_alt_space` – zamienia Alt+Space na zwykłą spację;
* `fix_file` – otwiera plik z błędem w twoim `$EDITOR`;
* `gem_unknown_command` – poprawia błędne polecenia `gem`;
* `git_add` – poprawia *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` – dodaje `--force` do `git add <pathspec>...` dla plików z .gitignore;
* `git_bisect_usage` – poprawia `git bisect strt`, `git bisect goood`, `git bisect rset` itd. podczas bisektowania;
* `git_branch_delete` – zamienia `git branch -d` na `git branch -D`;
* `git_branch_delete_checked_out` – zamienia `git branch -d` na `git checkout master && git branch -D` przy próbie usunięcia aktualnej gałęzi;
* `git_branch_exists` – sugeruje `git branch -d foo`, `git branch -D foo` lub `git checkout foo` przy tworzeniu istniejącej już gałęzi;
* `git_branch_list` – łapie `git branch list` zamiast `git branch` i usuwa utworzoną gałąź;
* `git_branch_0flag` – poprawia polecenia takie jak `git branch 0v` i `git branch 0r` usuwając utworzoną gałąź;
* `git_checkout` – poprawia nazwę gałęzi lub tworzy nową;
* `git_clone_git_clone` – zamienia `git clone git clone ...` na `git clone ...`
* `git_clone_missing` – dodaje `git clone` do adresów URL, które wyglądają na repozytorium git.
* `git_commit_add` – sugeruje `git commit -a ...` lub `git commit -p ...` po nieudanym poprzednim commitcie, jeśli nic nie było przygotowane;
* `git_commit_amend` – sugeruje `git commit --amend` po poprzednim commitcie;
* `git_commit_reset` – sugeruje `git reset HEAD~` po poprzednim commitcie;
* `git_diff_no_index` – dodaje `--no-index` do poprzedniego `git diff` na nieśledzonych plikach;
* `git_diff_staged` – dodaje `--staged` do poprzedniego `git diff` z nieoczekiwanym wynikiem;
* `git_fix_stash` – poprawia polecenia `git stash` (błędna podkomenda lub brak `save`);
* `git_flag_after_filename` – poprawia `fatal: bad flag '...' after filename`
* `git_help_aliased` – poprawia polecenia `git help <alias>` zamieniając <alias> na właściwe polecenie;
* `git_hook_bypass` – dodaje flagę `--no-verify` przed `git am`, `git commit` lub `git push`;
* `git_lfs_mistype` – poprawia błędnie napisane polecenia `git lfs <command>`;
* `git_main_master` – poprawia nieprawidłową nazwę gałęzi między `main` a `master`
* `git_merge` – dodaje zdalne do nazw gałęzi;
* `git_merge_unrelated` – dodaje `--allow-unrelated-histories` gdy jest to wymagane
* `git_not_command` – poprawia błędne polecenia git, np. `git brnch`;
* `git_pull` – ustawia upstream przed wykonaniem poprzedniego `git pull`;
* `git_pull_clone` – klonuje zamiast pobierać, gdy repozytorium nie istnieje;
* `git_pull_uncommitted_changes` – zapisuje zmiany przed pobraniem i przywraca je później;
* `git_push` – dodaje `--set-upstream origin $branch` do poprzedniego nieudanego `git push`;
* `git_push_different_branch_names` – poprawia wysyłki, gdy nazwa lokalnej gałęzi nie odpowiada nazwie zdalnej;
* `git_push_pull` – uruchamia `git pull`, gdy `push` został odrzucony;
* `git_push_without_commits` – tworzy pierwszy commit, jeśli zapomniałeś i wykonałeś tylko `git add .` podczas tworzenia nowego projektu;
* `git_rebase_no_changes` – uruchamia `git rebase --skip` zamiast `git rebase --continue`, gdy nie ma zmian;
* `git_remote_delete` – zamienia `git remote delete remote_name` na `git remote remove remote_name`;
* `git_rm_local_modifications` – dodaje `-f` lub `--cached`, gdy próbujesz usunąć lokalnie zmodyfikowany plik;
* `git_rm_recursive` – dodaje `-r`, gdy próbujesz usunąć katalog;
* `git_rm_staged` – dodaje `-f` lub `--cached`, gdy próbujesz usunąć plik z przygotowanymi zmianami
* `git_rebase_merge_dir` – sugeruje `git rebase (--continue | --abort | --skip)` lub usunięcie katalogu `.git/rebase-merge` podczas trwającego rebase;
* `git_remote_seturl_add` – uruchamia `git remote add`, gdy `git remote set_url` na nieistniejącym remote;
* `git_stash` – zapisuje lokalne modyfikacje przed rebase lub zmianą gałęzi;
* `git_stash_pop` – dodaje lokalne modyfikacje przed przywróceniem stash, potem resetuje;
* `git_tag_force` – dodaje `--force` do `git tag <tagname>`, gdy tag już istnieje;
* `git_two_dashes` – dodaje brakujący myślnik do poleceń typu `git commit -amend` lub `git rebase -continue`;
* `go_run` – dodaje rozszerzenie `.go` podczas kompilacji/uruchamiania programów Go;
* `go_unknown_command` – poprawia błędne polecenia `go`, np. `go bulid`;
* `gradle_no_task` – poprawia niezidentyfikowane lub niejednoznaczne zadania `gradle`;
* `gradle_wrapper` – zamienia `gradle` na `./gradlew`;
* `grep_arguments_order` – poprawia kolejność argumentów `grep` w sytuacjach typu `grep -lir . test`;
* `grep_recursive` – dodaje `-r` podczas próby grep na katalogu;
* `grunt_task_not_found` – poprawia błędnie napisane polecenia grunt;
* `gulp_not_task` – poprawia błędnie napisane zadania gulp;
* `has_exists_script` – poprzedza `./`, gdy istnieje skrypt/binarka;
* `heroku_multiple_apps` – dodaje `--app <app>` do poleceń heroku typu `heroku pg`;
* `heroku_not_command` – poprawia błędne polecenia heroku, np. `heroku log`;
* `history` – próbuje zamienić polecenie na najbardziej podobne z historii;
* `hostscli` – próbuje poprawić użycie `hostscli`;
* `ifconfig_device_not_found` – poprawia błędne nazwy urządzeń, np. `wlan0` na `wlp2s0`;
* `java` – usuwa rozszerzenie `.java` podczas uruchamiania programów Java;
* `javac` – dodaje brakujące `.java` przy kompilacji plików Java;
* `lein_not_task` – poprawia błędne zadania lein, np. `lein rpl`;
* `long_form_help` – zamienia `-h` na `--help`, gdy skrócona wersja nie jest obsługiwana
* `ln_no_hard_link` – wykrywa próbę utworzenia twardego dowiązania do katalogu, sugeruje dowiązanie symboliczne;
* `ln_s_order` – poprawia kolejność argumentów `ln -s`;
* `ls_all` – dodaje `-A` do `ls`, gdy wynik jest pusty;
* `ls_lah` – dodaje `-lah` do `ls`;
* `man` – zmienia sekcję manuala;
* `man_no_space` – poprawia polecenia man bez spacji, np. `mandiff`;
* `mercurial` – poprawia błędne polecenia `hg`;
* `missing_space_before_subcommand` – poprawia brakującą spację przed podkomendą, np. `npminstall`;
* `mkdir_p` – dodaje `-p`, gdy próbujesz utworzyć katalog bez nadrzędnego;
* `mvn_no_command` – dodaje `clean package` do `mvn`;
* `mvn_unknown_lifecycle_phase` – poprawia błędne fazy cyklu życia w `mvn`;
* `npm_missing_script` – poprawia niestandardową nazwę skryptu w `npm run-script <script>`;
* `npm_run_script` – dodaje brakujące `run-script` dla niestandardowych skryptów npm;
* `npm_wrong_command` – poprawia błędne polecenia npm, np. `npm urgrade`;
* `no_command` – poprawia błędne polecenia konsoli, np. `vom/vim`;
* `no_such_file` – tworzy brakujące katalogi przy poleceniach mv i cp;
* `omnienv_no_such_command` – poprawia błędne polecenia dla `goenv`, `nodenv`, `pyenv` i `rbenv` (np. `pyenv isntall` lub `goenv list`);
* `open` – poprzedza `http://` adres przekazany do `open` lub tworzy nowy plik/katalog i przekazuje do open;
* `pip_install` – poprawia problemy z uprawnieniami przy `pip install` przez dodanie `--user` lub poprzedzenie `sudo` jeśli to konieczne;
* `pip_unknown_command` – poprawia błędne polecenia pip, np. `pip instatl/pip install`;
* `php_s` – zamienia `-s` na `-S` przy próbie uruchomienia lokalnego serwera php;
* `port_already_in_use` – zabija proces korzystający z portu;
* `prove_recursively` – dodaje `-r` przy wywołaniu na katalogu;
* `python_command` – poprzedza `python` gdy próbujesz uruchomić nie-wykonywalny skrypt python lub bez `./`;
* `python_execute` – dodaje brakujące `.py` podczas uruchamiania plików Python;
* `python_module_error` – poprawia ModuleNotFoundError próbując `pip install` danego modułu;
* `quotation_marks` – poprawia nierównomierne użycie `'` i `"`, gdy występują w argumentach;
* `path_from_history` – zamienia nieistniejącą ścieżkę na podobną absolutną z historii;
* `rails_migrations_pending` – uruchamia zaległe migracje;
* `react_native_command_unrecognized` – poprawia niezrozumiane polecenia `react-native`;
* `remove_shell_prompt_literal` – usuwa początkowy znak zachęty powłoki `$`, częsty przy kopiowaniu poleceń z dokumentacji;
* `remove_trailing_cedilla` – usuwa końcową cedillę `ç`, częsty błąd na europejskich klawiaturach;
* `rm_dir` – dodaje `-rf` podczas usuwania katalogu;
* `scm_correction` – poprawia błędny scm, np. `hg log` na `git log`;
* `sed_unterminated_s` – dodaje brakujący '/' do poleceń `s` w `sed`;
* `sl_ls` – zamienia `sl` na `ls`;
* `ssh_known_hosts` – usuwa hosta z `known_hosts` przy ostrzeżeniu;
* `sudo` – poprzedza poprzednie polecenie `sudo`, jeśli nie powiodło się z powodu uprawnień;
* `sudo_command_from_user_path` – uruchamia polecenia z `$PATH` użytkownika z `sudo`;
* `switch_lang` – zamienia polecenie z układu lokalnego na en;
* `systemctl` – poprawnie porządkuje parametry mylącego `systemctl`;
* `terraform_init.py` – uruchamia `terraform init` przed planem lub apply;
* `terraform_no_command.py` – poprawia niezrozumiane polecenia `terraform`;
* `test.py` – uruchamia `pytest` zamiast `test.py`;
* `touch` – tworzy brakujące katalogi przed "dotykaniem";
* `tsuru_login` – uruchamia `tsuru login`, jeśli nie zalogowano lub sesja wygasła;
* `tsuru_not_command` – poprawia błędne polecenia tsuru, np. `tsuru shell`;
* `tmux` – poprawia polecenia tmux;
* `unknown_command` – poprawia "unknown command" stylu hadoop hdfs, np. dodaje brakujący '-' do polecenia `hdfs dfs ls`;
* `unsudo` – usuwa `sudo` z poprzedniego polecenia, jeśli proces odmawia działania na uprawnieniach superużytkownika.
* `vagrant_up` – uruchamia instancję vagrant;
* `whois` – poprawia polecenie whois;
* `workon_doesnt_exists` – poprawia nazwę środowiska virtualenvwrapper lub sugeruje utworzenie nowego.
* `wrong_hyphen_before_subcommand` – usuwa nieprawidłowo umieszczony myślnik (`apt-install` -> `apt install`, `git-log` -> `git log`, itd.)
* `yarn_alias` – poprawia zaliasowane polecenia yarn, np. `yarn ls`;
* `yarn_command_not_found` – poprawia błędnie napisane polecenia yarn;
* `yarn_command_replaced` – poprawia zamienione polecenia yarn;
* `yarn_help` – ułatwia otwarcie dokumentacji yarn;

##### [Powrót do spisu treści](#contents)

Następujące reguły są domyślnie włączone tylko na wybranych platformach:

* `apt_get` – instaluje aplikację z apt, jeśli nie jest zainstalowana (wymaga `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` – zamienia próbę wyszukiwania za pomocą `apt-get` na wyszukiwanie przez `apt-cache`;
* `apt_invalid_operation` – poprawia nieprawidłowe wywołania `apt` i `apt-get`, np. `apt-get isntall vim`;
* `apt_list_upgradable` – pomaga uruchomić `apt list --upgradable` po `apt update`;
* `apt_upgrade` – pomaga uruchomić `apt upgrade` po `apt list --upgradable`;
* `brew_cask_dependency` – instaluje zależności cask;
* `brew_install` – poprawia nazwę formuły dla `brew install`;
* `brew_reinstall` – zamienia `brew install <formula>` na `brew reinstall <formula>`;
* `brew_link` – dodaje `--overwrite --dry-run` jeśli linkowanie się nie powiodło;
* `brew_uninstall` – dodaje `--force` do `brew uninstall` jeśli zainstalowano wiele wersji;
* `brew_unknown_command` – poprawia błędne polecenia brew, np. `brew docto/brew doctor`;
* `brew_update_formula` – zamienia `brew update <formula>` na `brew upgrade <formula>`;
* `dnf_no_such_command` – poprawia błędnie napisane polecenia DNF;
* `nixos_cmd_not_found` – instaluje aplikacje na NixOS;
* `pacman` – instaluje aplikację za pomocą `pacman`, jeśli nie jest zainstalowana (używa `yay`, `pikaur` lub `yaourt`, jeśli dostępne);
* `pacman_invalid_option` – zamienia małe litery opcji `pacman` na wielkie.
* `pacman_not_found` – poprawia nazwę pakietu z `pacman`, `yay`, `pikaur` lub `yaourt`.
* `yum_invalid_operation` – poprawia nieprawidłowe wywołania `yum`, np. `yum isntall vim`;

Następujące polecenia są dostarczane z *The Fuck*, ale nie są domyślnie włączone:

* `git_push_force` – dodaje `--force-with-lease` do `git push` (może kolidować z `git_push_pull`);
* `rm_root` – dodaje `--no-preserve-root` do polecenia `rm -rf /`.

##### [Powrót do spisu treści](#contents)

## Tworzenie własnych reguł

Aby dodać własną regułę, utwórz plik o nazwie `twoja-nazwa-reguły.py`
w `~/.config/thefuck/rules`. Plik reguły musi zawierać dwie funkcje:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Dodatkowo reguły mogą zawierać opcjonalne funkcje:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Reguły mogą także zawierać opcjonalne zmienne `enabled_by_default`, `requires_output` i `priority`.

`Command` ma trzy atrybuty: `script`, `output` i `script_parts`.
Twoja reguła nie powinna zmieniać `Command`.


**API reguł zmieniło się w wersji 3.0:** Aby uzyskać dostęp do ustawień reguły, zaimportuj je przez
 `from thefuck.conf import settings`

`settings` to specjalny obiekt zbudowany z `~/.config/thefuck/settings.py` oraz wartości ze zmiennych środowiskowych ([zobacz więcej poniżej](#settings)).

Prosty przykład reguły uruchamiającej skrypt z `sudo`:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Opcjonalnie:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Niższa wartość wcześniej, domyślnie 1000

requires_output = True
```

[Więcej przykładów reguł](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[funkcje pomocnicze dla reguł](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[aplikacje/pomocniki specyficzni dla OS](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Powrót do spisu treści](#contents)

## Ustawienia

Wiele parametrów *The Fuck* można zmienić w pliku `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` domyślnie to `~/.config`):

* `rules` – lista włączonych reguł, domyślnie `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` – lista wyłączonych reguł, domyślnie `[]`;
* `require_confirmation` – wymaga potwierdzenia przed uruchomieniem nowego polecenia, domyślnie `True`;
* `wait_command` – maksymalny czas (w sekundach) oczekiwania na wynik poprzedniego polecenia;
* `no_colors` – wyłącza kolorowe wyjście;
* `priority` – słownik z priorytetami reguł, reguła o niższym `priority` będzie dopasowana pierwsza;
* `debug` – włącza wyjście debugowania, domyślnie `False`;
* `history_limit` – liczba poleceń z historii, które będą przeszukiwane, np. `2000`;
* `alter_history` – dodaje poprawione polecenie do historii, domyślnie `True`;
* `wait_slow_command` – maksymalny czas (w sekundach) oczekiwania na wynik poprzedniego polecenia, jeśli znajduje się na liście `slow_commands`;
* `slow_commands` – lista wolnych poleceń;
* `num_close_matches` – maksymalna liczba podobnych wyników do zasugerowania, domyślnie `3`.
* `excluded_search_path_prefixes` – prefiksy ścieżek do zignorowania podczas szukania poleceń, domyślnie `[]`.

Przykład pliku `settings.py`:

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

Lub przez zmienne środowiskowe:

* `THEFUCK_RULES` – lista włączonych reguł, np. `DEFAULT_RULES:rm_root` lub `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` – lista wyłączonych reguł, np. `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` – wymagaj potwierdzenia przed uruchomieniem nowego polecenia, `true/false`;
* `THEFUCK_WAIT_COMMAND` – maksymalny czas (w sekundach) oczekiwania na wynik poprzedniego polecenia;
* `THEFUCK_NO_COLORS` – wyłącza kolorowe wyjście, `true/false`;
* `THEFUCK_PRIORITY` – priorytet reguł, np. `no_command=9999:apt_get=100`,
reguła o niższym `priority` będzie dopasowana pierwsza;
* `THEFUCK_DEBUG` – włącza wyjście debugowania, `true/false`;
* `THEFUCK_HISTORY_LIMIT` – ile poleceń z historii będzie przeszukiwanych, np. `2000`;
* `THEFUCK_ALTER_HISTORY` – dodaje poprawione polecenie do historii `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` – maksymalny czas (w sekundach) oczekiwania na wynik poprzedniego polecenia, jeśli znajduje się na liście `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` – lista wolnych poleceń, np. `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` – maksymalna liczba podobnych wyników do zasugerowania, np. `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` – prefiksy ścieżek do ignorowania podczas szukania poleceń, domyślnie `[]`.

Na przykład:

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

##### [Powrót do spisu treści](#contents)

## Zewnętrzne pakiety z regułami

Jeśli chcesz przygotować zestaw niepublicznych reguł, ale jednocześnie udostępniać je innym, utwórz pakiet o nazwie `thefuck_contrib_*` o następującej strukturze:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *zewnętrzne reguły*
    __init__.py
    *zewnętrzne funkcje pomocnicze*
  setup.py
```

*The Fuck* znajdzie reguły znajdujące się w module `rules`.

##### [Powrót do spisu treści](#contents)

## Eksperymentalny tryb natychmiastowy

Domyślne zachowanie *The Fuck* wymaga czasu na ponowne uruchomienie poprzednich poleceń.
W trybie natychmiastowym *The Fuck* oszczędza czas, logując wyjście za pomocą [script](https://en.wikipedia.org/wiki/Script_(Unix)),
a następnie odczytując log.

[![gif z trybem natychmiastowym][instant-mode-gif-link]][instant-mode-gif-link]

Obecnie tryb natychmiastowy obsługuje jedynie Pythona 3 z bash lub zsh. Funkcja autocorrect w zsh musi być wyłączona, aby thefuck działał poprawnie.

Aby włączyć tryb natychmiastowy, dodaj `--enable-experimental-instant-mode`
do inicjalizacji aliasu w `.bashrc`, `.bash_profile` lub `.zshrc`.

Na przykład:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Powrót do spisu treści](#contents)

## Rozwój

Zobacz [CONTRIBUTING.md](CONTRIBUTING.md)

## Licencja MIT
Licencja projektu znajduje się [tutaj](LICENSE.md).


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

##### [Powrót do spisu treści](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---