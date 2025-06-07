# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* ist eine großartige App, inspiriert von einem [@liamosaur](https://twitter.com/liamosaur/)
[Tweet](https://twitter.com/liamosaur/status/506975850596536320),
die Fehler in vorherigen Konsolenbefehlen korrigiert.

Ist *The Fuck* zu langsam? [Probiere den experimentellen Instant-Modus!](#experimental-instant-mode)

[![gif mit Beispielen][examples-link]][examples-link]

Weitere Beispiele:

```bash
➜ apt-get install vim
E: Could not open lock file /var/lib/dpkg/lock - open (13: Permission denied)
E: Unable to lock the administration directory (/var/lib/dpkg/), are you root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] Passwort für nvbn:
Paketlisten werden gelesen... Fertig
...
```

```bash
➜ git push
fatal: Der aktuelle Branch master hat keinen Upstream-Branch.
Um den aktuellen Branch zu pushen und den Remote als Upstream zu setzen, benutze

    git push --set-upstream origin master


➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Zähle Objekte: 9, fertig.
...
```

```bash
➜ puthon
Kein Befehl 'puthon' gefunden, meinten Sie:
 Befehl 'python' aus dem Paket 'python-minimal' (main)
 Befehl 'python' aus dem Paket 'python3' (main)
zsh: Befehl nicht gefunden: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' ist kein git-Befehl. Siehe 'git --help'.

Meinten Sie diesen?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' ist keine Aufgabe. Siehe 'lein help'.

Meinten Sie diese?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL-Server gestartet auf Port 54848 auf Host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Wenn du keine Angst davor hast, korrigierte Befehle blind auszuführen, kann die
Option `require_confirmation` in den [Einstellungen](#settings) deaktiviert werden:

```bash
➜ apt-get install vim
E: Could not open lock file /var/lib/dpkg/lock - open (13: Permission denied)
E: Unable to lock the administration directory (/var/lib/dpkg/), are you root?

➜ fuck
sudo apt-get install vim
[sudo] Passwort für nvbn:
Paketlisten werden gelesen... Fertig
...
```

## Inhalt

1. [Voraussetzungen](#requirements)
2. [Installation](#installation)
3. [Aktualisierung](#updating)
4. [Funktionsweise](#how-it-works)
5. [Eigene Regeln erstellen](#creating-your-own-rules)
6. [Einstellungen](#settings)
7. [Drittanbieter-Pakete mit Regeln](#third-party-packages-with-rules)
8. [Experimenteller Instant-Modus](#experimental-instant-mode)
9. [Entwicklung](#developing)
10. [Lizenz](#license-mit)

## Voraussetzungen

- python (3.5+)
- pip
- python-dev

##### [Zurück zum Inhalt](#contents)

## Installation

Unter macOS oder Linux kannst du *The Fuck* über [Homebrew][homebrew] installieren:

```bash
brew install thefuck
```

Unter Ubuntu / Mint installiere *The Fuck* mit folgenden Befehlen:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

Unter FreeBSD installiere *The Fuck* mit folgenden Befehlen:
```bash
pkg install thefuck
```

Unter ChromeOS installiere *The Fuck* mit [chromebrew](https://github.com/skycocker/chromebrew) und folgendem Befehl:
```bash
crew install thefuck
```

Unter Arch-basierten Systemen installiere *The Fuck* mit folgendem Befehl:
```
sudo pacman -S thefuck
```

Auf anderen Systemen installiere *The Fuck* mit `pip`:

```bash
pip install thefuck
```

[Alternativ kannst du einen Paketmanager des Betriebssystems (OS X, Ubuntu, Arch) verwenden.](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Es wird empfohlen, diesen Befehl in deine `.bash_profile`,
`.bashrc`, `.zshrc` oder ein anderes Startskript einzutragen:

```bash
eval $(thefuck --alias)
# Du kannst auch ein beliebiges Alias verwenden, z.B. für Montage:
eval $(thefuck --alias FUCK)
```

[Oder in deiner Shell-Konfiguration (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Änderungen sind nur in einer neuen Shell-Sitzung verfügbar. Um Änderungen sofort
wirksam zu machen, führe `source ~/.bashrc` (oder deine Shell-Konfigurationsdatei wie `.zshrc`) aus.

Um korrigierte Befehle ohne Bestätigung auszuführen, verwende die Option `--yeah` (oder kurz `-y`, oder `--hard`, wenn du besonders frustriert bist):

```bash
fuck --yeah
```

Um Befehle rekursiv zu korrigieren, bis sie erfolgreich sind, verwende die Option `-r`:

```bash
fuck -r
```

##### [Zurück zum Inhalt](#contents)

## Aktualisierung

```bash
pip3 install thefuck --upgrade
```

**Hinweis: Die Alias-Funktionalität wurde in Version 1.34 von *The Fuck* geändert**

## Deinstallation

Um *The Fuck* zu entfernen, führe die Installationsschritte rückwärts aus:
- Entferne oder kommentiere die Alias-Zeile für *thefuck* aus deiner Bash-, Zsh-, Fish-, Powershell-, tcsh-, ... Shell-Konfiguration
- Deinstalliere die Binärdateien mit deinem Paketmanager (brew, pip3, pkg, crew, pip)

## Funktionsweise

*The Fuck* versucht, den vorherigen Befehl mit einer Regel abzugleichen. Wird eine Übereinstimmung gefunden, wird ein neuer Befehl mit der passenden Regel erstellt und ausgeführt. Die folgenden Regeln sind standardmäßig aktiviert:

* `adb_unknown_command` &ndash; korrigiert falsch geschriebene Befehle wie `adb logcta`;
* `ag_literal` &ndash; fügt `-Q` zu `ag` hinzu, wenn vorgeschlagen;
* `aws_cli` &ndash; korrigiert falsch geschriebene Befehle wie `aws dynamdb scan`;
* `az_cli` &ndash; korrigiert falsch geschriebene Befehle wie `az providers`;
* `cargo` &ndash; führt `cargo build` statt `cargo` aus;
* `cargo_no_command` &ndash; korrigiert falsche Befehle wie `cargo buid`;
* `cat_dir` &ndash; ersetzt `cat` durch `ls`, wenn versucht wird, ein Verzeichnis mit `cat` zu öffnen;
* `cd_correction` &ndash; Rechtschreibprüfung und Korrektur fehlgeschlagener cd-Befehle;
* `cd_cs` &ndash; ändert `cs` in `cd`;
* `cd_mkdir` &ndash; erstellt Verzeichnisse, bevor mit cd hineingegangen wird;
* `cd_parent` &ndash; ändert `cd..` in `cd ..`;
* `chmod_x` &ndash; fügt das Ausführungsbit hinzu;
* `choco_install` &ndash; hängt gängige Suffixe an chocolatey-Pakete an;
* `composer_not_command` &ndash; korrigiert composer-Befehlsnamen;
* `conda_mistype` &ndash; korrigiert conda-Befehle;
* `cp_create_destination` &ndash; erstellt ein neues Verzeichnis, wenn du versuchst, mit `cp` oder `mv` in ein nicht existierendes zu kopieren/verschieben;
* `cp_omitting_directory` &ndash; fügt `-a` hinzu, wenn du ein Verzeichnis mit `cp` kopierst;
* `cpp11` &ndash; fügt fehlendes `-std=c++11` zu `g++` oder `clang++` hinzu;
* `dirty_untar` &ndash; korrigiert `tar x`, das ins aktuelle Verzeichnis entpackt hat;
* `dirty_unzip` &ndash; korrigiert `unzip`, das ins aktuelle Verzeichnis entpackt hat;
* `django_south_ghost` &ndash; fügt `--delete-ghost-migrations` zu fehlgeschlagenen Ghosts Django South Migrationen hinzu;
* `django_south_merge` &ndash; fügt `--merge` zu inkonsistenten Django South Migrationen hinzu;
* `docker_login` &ndash; führt ein `docker login` aus und wiederholt den vorherigen Befehl;
* `docker_not_command` &ndash; korrigiert falsche docker-Befehle wie `docker tags`;
* `docker_image_being_used_by_container` &ndash; entfernt den Container, der das Image verwendet, bevor das Image entfernt wird;
* `dry` &ndash; korrigiert Wiederholungen wie `git git push`;
* `fab_command_not_found` &ndash; korrigiert falsch geschriebene fabric-Befehle;
* `fix_alt_space` &ndash; ersetzt Alt+Space durch das Leerzeichen;
* `fix_file` &ndash; öffnet eine Datei mit Fehler im `$EDITOR`;
* `gem_unknown_command` &ndash; korrigiert falsche `gem`-Befehle;
* `git_add` &ndash; korrigiert *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` &ndash; fügt `--force` zu `git add <pathspec>...` hinzu, wenn Pfade in .gitignore stehen;
* `git_bisect_usage` &ndash; korrigiert `git bisect strt`, `git bisect goood`, `git bisect rset` usw. beim Bisecten;
* `git_branch_delete` &ndash; ändert `git branch -d` zu `git branch -D`;
* `git_branch_delete_checked_out` &ndash; ändert `git branch -d` zu `git checkout master && git branch -D`, wenn versucht wird, einen ausgecheckten Branch zu löschen;
* `git_branch_exists` &ndash; bietet `git branch -d foo`, `git branch -D foo` oder `git checkout foo` an, wenn versucht wird, einen existierenden Branch zu erstellen;
* `git_branch_list` &ndash; fängt `git branch list` anstelle von `git branch` ab und entfernt den erstellten Branch;
* `git_branch_0flag` &ndash; korrigiert Befehle wie `git branch 0v` und `git branch 0r` durch Entfernen des erstellten Branches;
* `git_checkout` &ndash; korrigiert Branch-Namen oder erstellt neuen Branch;
* `git_clone_git_clone` &ndash; ersetzt `git clone git clone ...` durch `git clone ...`
* `git_clone_missing` &ndash; fügt `git clone` zu URLs hinzu, die auf ein Git-Repository verweisen;
* `git_commit_add` &ndash; bietet `git commit -a ...` oder `git commit -p ...` nach vorherigem Commit an, wenn kein Staging stattfand;
* `git_commit_amend` &ndash; bietet `git commit --amend` nach vorherigem Commit an;
* `git_commit_reset` &ndash; bietet `git reset HEAD~` nach vorherigem Commit an;
* `git_diff_no_index` &ndash; fügt `--no-index` zum vorherigen `git diff` bei nicht getrackten Dateien hinzu;
* `git_diff_staged` &ndash; fügt `--staged` zum vorherigen `git diff` mit unerwarteter Ausgabe hinzu;
* `git_fix_stash` &ndash; korrigiert `git stash`-Befehle (falsch geschriebene Subcommands und fehlendes `save`);
* `git_flag_after_filename` &ndash; korrigiert `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; korrigiert `git help <alias>` und ersetzt <alias> mit dem Alias-Befehl;
* `git_hook_bypass` &ndash; fügt das Flag `--no-verify` vor `git am`, `git commit` oder `git push` hinzu;
* `git_lfs_mistype` &ndash; korrigiert falsch geschriebene `git lfs <command>` Befehle;
* `git_main_master` &ndash; korrigiert den Branch-Namen zwischen `main` und `master`
* `git_merge` &ndash; fügt Remote zu Branch-Namen hinzu;
* `git_merge_unrelated` &ndash; fügt `--allow-unrelated-histories` bei Bedarf hinzu
* `git_not_command` &ndash; korrigiert falsche git-Befehle wie `git brnch`;
* `git_pull` &ndash; setzt Upstream, bevor vorheriges `git pull` ausgeführt wird;
* `git_pull_clone` &ndash; klont statt zu pullen, wenn das Repository nicht existiert;
* `git_pull_uncommitted_changes` &ndash; stash't Änderungen vor dem Pull und poppt sie danach wieder;
* `git_push` &ndash; fügt `--set-upstream origin $branch` zum vorherigen fehlgeschlagenen `git push` hinzu;
* `git_push_different_branch_names` &ndash; korrigiert Pushes, wenn der lokale Branch-Name nicht mit dem Remote-Branch-Name übereinstimmt;
* `git_push_pull` &ndash; führt `git pull` aus, wenn `push` abgelehnt wurde;
* `git_push_without_commits` &ndash; erstellt einen Initial-Commit, wenn du nur `git add .` ausführst und ein neues Projekt aufsetzt;
* `git_rebase_no_changes` &ndash; führt `git rebase --skip` statt `git rebase --continue` aus, wenn keine Änderungen vorhanden sind;
* `git_remote_delete` &ndash; ersetzt `git remote delete remote_name` durch `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; fügt `-f` oder `--cached` hinzu, wenn du versuchst, eine lokal modifizierte Datei zu entfernen;
* `git_rm_recursive` &ndash; fügt `-r` hinzu, wenn du versuchst, ein Verzeichnis zu entfernen;
* `git_rm_staged` &ndash;  fügt `-f` oder `--cached` hinzu, wenn du eine Datei mit gestagten Änderungen entfernen möchtest;
* `git_rebase_merge_dir` &ndash; bietet `git rebase (--continue | --abort | --skip)` oder das Entfernen des `.git/rebase-merge`-Verzeichnisses an, wenn ein Rebase läuft;
* `git_remote_seturl_add` &ndash; führt `git remote add` aus, wenn `git remote set_url` auf nicht existierendem Remote;
* `git_stash` &ndash; stash't lokale Änderungen vor Rebase oder Branchwechsel;
* `git_stash_pop` &ndash; fügt lokale Änderungen vor `stash pop` hinzu, dann reset;
* `git_tag_force` &ndash; fügt `--force` zu `git tag <tagname>` hinzu, wenn der Tag bereits existiert;
* `git_two_dashes` &ndash; fügt ein fehlendes Minuszeichen zu Befehlen wie `git commit -amend` oder `git rebase -continue` hinzu;
* `go_run` &ndash; hängt `.go`-Erweiterung beim Kompilieren/Ausführen von Go-Programmen an;
* `go_unknown_command` &ndash; korrigiert falsche `go`-Befehle, z.B. `go bulid`;
* `gradle_no_task` &ndash; korrigiert nicht gefundene oder mehrdeutige `gradle`-Aufgaben;
* `gradle_wrapper` &ndash; ersetzt `gradle` durch `./gradlew`;
* `grep_arguments_order` &ndash; korrigiert die Reihenfolge der `grep`-Argumente für Situationen wie `grep -lir . test`;
* `grep_recursive` &ndash; fügt `-r` hinzu, wenn du versuchst, ein Verzeichnis mit `grep` zu durchsuchen;
* `grunt_task_not_found` &ndash; korrigiert falsch geschriebene `grunt`-Befehle;
* `gulp_not_task` &ndash; korrigiert falsch geschriebene `gulp`-Tasks;
* `has_exists_script` &ndash; fügt `./` voran, wenn das Skript/Binary existiert;
* `heroku_multiple_apps` &ndash; fügt `--app <app>` zu `heroku`-Befehlen wie `heroku pg` hinzu;
* `heroku_not_command` &ndash; korrigiert falsche `heroku`-Befehle wie `heroku log`;
* `history` &ndash; versucht, den Befehl mit dem ähnlichsten aus der Historie zu ersetzen;
* `hostscli` &ndash; versucht, die Verwendung von `hostscli` zu korrigieren;
* `ifconfig_device_not_found` &ndash; korrigiert falsche Gerätenamen wie `wlan0` zu `wlp2s0`;
* `java` &ndash; entfernt `.java`-Erweiterung beim Ausführen von Java-Programmen;
* `javac` &ndash; hängt fehlendes `.java` beim Kompilieren von Java-Dateien an;
* `lein_not_task` &ndash; korrigiert falsche `lein`-Tasks wie `lein rpl`;
* `long_form_help` &ndash; ändert `-h` zu `--help`, wenn die Kurzversion nicht unterstützt wird;
* `ln_no_hard_link` &ndash; erkennt Hardlink-Erstellung bei Verzeichnissen und schlägt symbolischen Link vor;
* `ln_s_order` &ndash; korrigiert die Reihenfolge der Argumente von `ln -s`;
* `ls_all` &ndash; fügt `-A` zu `ls` hinzu, wenn die Ausgabe leer ist;
* `ls_lah` &ndash; fügt `-lah` zu `ls` hinzu;
* `man` &ndash; ändert die Handbuchsektion;
* `man_no_space` &ndash; korrigiert man-Befehle ohne Leerzeichen, z.B. `mandiff`;
* `mercurial` &ndash; korrigiert falsche `hg`-Befehle;
* `missing_space_before_subcommand` &ndash; korrigiert Befehle mit fehlendem Leerzeichen wie `npminstall`;
* `mkdir_p` &ndash; fügt `-p` hinzu, wenn du ein Verzeichnis ohne Elternverzeichnis erstellen willst;
* `mvn_no_command` &ndash; fügt `clean package` zu `mvn` hinzu;
* `mvn_unknown_lifecycle_phase` &ndash; korrigiert falsch geschriebene Lifecycle-Phasen bei `mvn`;
* `npm_missing_script` &ndash; korrigiert benutzerdefinierten Skriptnamen in `npm run-script <script>`;
* `npm_run_script` &ndash; fügt fehlendes `run-script` für benutzerdefinierte `npm`-Skripte hinzu;
* `npm_wrong_command` &ndash; korrigiert falsche npm-Befehle wie `npm urgrade`;
* `no_command` &ndash; korrigiert falsche Konsolenbefehle, z.B. `vom/vim`;
* `no_such_file` &ndash; erstellt fehlende Verzeichnisse bei `mv` und `cp`-Befehlen;
* `omnienv_no_such_command` &ndash; korrigiert falsche Befehle für `goenv`, `nodenv`, `pyenv` und `rbenv` (z.B.: `pyenv isntall` oder `goenv list`);
* `open` &ndash; fügt entweder `http://` vor einer Adresse für `open` hinzu oder erstellt eine neue Datei/ein Verzeichnis und übergibt es an `open`;
* `pip_install` &ndash; korrigiert Berechtigungsprobleme bei `pip install` durch Hinzufügen von `--user` oder Präfix `sudo`, falls nötig;
* `pip_unknown_command` &ndash; korrigiert falsche `pip`-Befehle, z.B. `pip instatl/pip install`;
* `php_s` &ndash; ersetzt `-s` durch `-S` beim lokalen php-Serverstart;
* `port_already_in_use` &ndash; beendet den Prozess, der den Port belegt;
* `prove_recursively` &ndash; fügt `-r` hinzu, wenn mit Verzeichnis aufgerufen;
* `python_command` &ndash; fügt `python` voran, wenn du versuchst, ein nicht ausführbares/ohne `./` Python-Skript zu starten;
* `python_execute` &ndash; hängt fehlendes `.py` beim Ausführen von Python-Dateien an;
* `python_module_error` &ndash; korrigiert ModuleNotFoundError durch Versuch, das Modul mit `pip install` zu installieren;
* `quotation_marks` &ndash; korrigiert ungleiche Benutzung von `'` und `"` in Argumenten;
* `path_from_history` &ndash; ersetzt nicht gefundenen Pfad durch einen ähnlichen absoluten Pfad aus der Historie;
* `rails_migrations_pending` &ndash; führt ausstehende Migrationen aus;
* `react_native_command_unrecognized` &ndash; korrigiert nicht erkannte `react-native`-Befehle;
* `remove_shell_prompt_literal` &ndash; entfernt führendes Shell-Prompt-Symbol `$`, häufig beim Kopieren von Befehlen aus Dokumentationen;
* `remove_trailing_cedilla` &ndash; entfernt abschließende Cedillas `ç`, ein häufiger Tippfehler für europäische Tastaturen;
* `rm_dir` &ndash; fügt `-rf` hinzu, wenn du ein Verzeichnis löschen möchtest;
* `scm_correction` &ndash; korrigiert falsches scm wie `hg log` zu `git log`;
* `sed_unterminated_s` &ndash; fügt fehlendes '/' zu `sed`'s `s`-Befehlen hinzu;
* `sl_ls` &ndash; ändert `sl` in `ls`;
* `ssh_known_hosts` &ndash; entfernt Host aus `known_hosts` bei Warnung;
* `sudo` &ndash; fügt `sudo` zum vorherigen Befehl hinzu, wenn er aufgrund von Berechtigungen fehlgeschlagen ist;
* `sudo_command_from_user_path` &ndash; führt Befehle aus dem `$PATH` des Benutzers mit `sudo` aus;
* `switch_lang` &ndash; wechselt den Befehl von deinem lokalen Layout auf en;
* `systemctl` &ndash; ordnet Parameter von `systemctl` korrekt;
* `terraform_init.py` &ndash; führt `terraform init` vor plan oder apply aus;
* `terraform_no_command.py` &ndash; korrigiert nicht erkannte `terraform`-Befehle;
* `test.py` &ndash; führt `pytest` statt `test.py` aus;
* `touch` &ndash; erstellt fehlende Verzeichnisse vor "touch";
* `tsuru_login` &ndash; führt `tsuru login` aus, wenn nicht authentifiziert oder Sitzung abgelaufen;
* `tsuru_not_command` &ndash; korrigiert falsche `tsuru`-Befehle wie `tsuru shell`;
* `tmux` &ndash; korrigiert `tmux`-Befehle;
* `unknown_command` &ndash; korrigiert hadoop/hdfs-"unknown command", z.B. fügt fehlendes '-' zum Befehl auf `hdfs dfs ls` hinzu;
* `unsudo` &ndash; entfernt `sudo` vom vorherigen Befehl, wenn ein Prozess nicht mit Superuser-Rechten laufen will.
* `vagrant_up` &ndash; startet die Vagrant-Instanz;
* `whois` &ndash; korrigiert `whois`-Befehl;
* `workon_doesnt_exists` &ndash; korrigiert `virtualenvwrapper`-Umgebungsnamen oder schlägt vor, eine neue zu erstellen.
* `wrong_hyphen_before_subcommand` &ndash; entfernt einen falsch platzierten Bindestrich (`apt-install` -> `apt install`, `git-log` -> `git log`, etc.)
* `yarn_alias` &ndash; korrigiert aliasierte `yarn`-Befehle wie `yarn ls`;
* `yarn_command_not_found` &ndash; korrigiert falsch geschriebene `yarn`-Befehle;
* `yarn_command_replaced` &ndash; korrigiert ersetzte `yarn`-Befehle;
* `yarn_help` &ndash; erleichtert das Öffnen der `yarn`-Dokumentation;

##### [Zurück zum Inhalt](#contents)

Die folgenden Regeln sind standardmäßig nur auf bestimmten Plattformen aktiviert:

* `apt_get` &ndash; installiert Apps mit apt, falls nicht installiert (benötigt `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; ändert Suchversuche mit `apt-get` zu einer Suche mit `apt-cache`;
* `apt_invalid_operation` &ndash; korrigiert ungültige `apt`- und `apt-get`-Aufrufe, wie `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; hilft dir, nach `apt update` `apt list --upgradable` auszuführen;
* `apt_upgrade` &ndash; hilft dir, nach `apt list --upgradable` `apt upgrade` auszuführen;
* `brew_cask_dependency` &ndash; installiert cask-Abhängigkeiten;
* `brew_install` &ndash; korrigiert den Formulanamen für `brew install`;
* `brew_reinstall` &ndash; wandelt `brew install <formula>` in `brew reinstall <formula>` um;
* `brew_link` &ndash; fügt `--overwrite --dry-run` hinzu, falls Linking fehlschlägt;
* `brew_uninstall` &ndash; fügt `--force` zu `brew uninstall` hinzu, wenn mehrere Versionen installiert waren;
* `brew_unknown_command` &ndash; korrigiert falsche brew-Befehle, z.B. `brew docto/brew doctor`;
* `brew_update_formula` &ndash; wandelt `brew update <formula>` in `brew upgrade <formula>` um;
* `dnf_no_such_command` &ndash; korrigiert falsch geschriebene DNF-Befehle;
* `nixos_cmd_not_found` &ndash; installiert Apps auf NixOS;
* `pacman` &ndash; installiert Apps mit `pacman`, falls nicht installiert (verwendet `yay`, `pikaur` oder `yaourt`, falls verfügbar);
* `pacman_invalid_option` &ndash; ersetzt Kleinbuchstaben-Optionen von `pacman` durch Großbuchstaben;
* `pacman_not_found` &ndash; korrigiert Paketnamen mit `pacman`, `yay`, `pikaur` oder `yaourt`;
* `yum_invalid_operation` &ndash; korrigiert ungültige `yum`-Aufrufe, wie `yum isntall vim`;

Die folgenden Befehle sind mit *The Fuck* gebündelt, aber nicht standardmäßig aktiviert:

* `git_push_force` &ndash; fügt `--force-with-lease` zu einem `git push` hinzu (kann mit `git_push_pull` kollidieren);
* `rm_root` &ndash; fügt `--no-preserve-root` zum Befehl `rm -rf /` hinzu.

##### [Zurück zum Inhalt](#contents)

## Eigene Regeln erstellen

Um eine eigene Regel hinzuzufügen, erstelle eine Datei mit dem Namen `your-rule-name.py`
in `~/.config/thefuck/rules`. Die Regeldatei muss zwei Funktionen enthalten:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Zusätzlich können Regeln optionale Funktionen enthalten:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Regeln können auch die optionalen Variablen `enabled_by_default`, `requires_output` und `priority` enthalten.

`Command` hat drei Attribute: `script`, `output` und `script_parts`.
Deine Regel sollte `Command` nicht verändern.


**Regel-API geändert in 3.0:** Um auf die Einstellungen einer Regel zuzugreifen, importiere sie mit
 `from thefuck.conf import settings`

`settings` ist ein spezielles Objekt, das aus `~/.config/thefuck/settings.py` und Werten aus der Umgebung zusammengesetzt wird ([siehe unten](#settings)).

Ein einfaches Beispiel für eine Regel, um ein Skript mit `sudo` auszuführen:

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

priority = 1000  # Niedriger zuerst, Standard ist 1000

requires_output = True
```

[Weitere Regelbeispiele](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[Hilfsfunktionen für Regeln](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[App/OS-spezifische Helfer](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Zurück zum Inhalt](#contents)

## Einstellungen

Mehrere *The Fuck*-Parameter können in der Datei `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` ist standardmäßig `~/.config`) geändert werden:

* `rules` &ndash; Liste der aktivierten Regeln, standardmäßig `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; Liste der deaktivierten Regeln, standardmäßig `[]`;
* `require_confirmation` &ndash; verlangt eine Bestätigung, bevor ein neuer Befehl ausgeführt wird, standardmäßig `True`;
* `wait_command` &ndash; maximale Zeit in Sekunden, um die Ausgabe des vorherigen Befehls zu erhalten;
* `no_colors` &ndash; deaktiviert farbige Ausgabe;
* `priority` &ndash; Dictionary mit Regel-Prioritäten, Regel mit niedrigerem `priority` wird zuerst abgeglichen;
* `debug` &ndash; aktiviert Debug-Ausgabe, standardmäßig `False`;
* `history_limit` &ndash; wie viele Befehle der Historie durchsucht werden, z.B. `2000`;
* `alter_history` &ndash; fügt korrigierte Befehle zur Historie hinzu, standardmäßig `True`;
* `wait_slow_command` &ndash; maximale Zeit in Sekunden für die Ausgabe des vorherigen Befehls, falls er in der Liste `slow_commands` steht;
* `slow_commands` &ndash; Liste langsamer Befehle;
* `num_close_matches` &ndash; maximale Anzahl ähnlicher Vorschläge, standardmäßig `3`;
* `excluded_search_path_prefixes` &ndash; zu ignorierende Pfad-Präfixe bei der Suche nach Befehlen, standardmäßig `[]`;

Ein Beispiel für `settings.py`:

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

Oder über Umgebungsvariablen:

* `THEFUCK_RULES` &ndash; Liste aktivierter Regeln, wie `DEFAULT_RULES:rm_root` oder `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; Liste deaktivierter Regeln, wie `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; verlangt Bestätigung vor dem Ausführen eines neuen Befehls, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; maximale Zeit in Sekunden für die Ausgabe des vorherigen Befehls;
* `THEFUCK_NO_COLORS` &ndash; deaktiviert farbige Ausgabe, `true/false`;
* `THEFUCK_PRIORITY` &ndash; Priorität der Regeln, z.B. `no_command=9999:apt_get=100`,
Regel mit niedrigerer `priority` wird zuerst abgeglichen;
* `THEFUCK_DEBUG` &ndash; aktiviert Debug-Ausgabe, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; wie viele Befehle der Historie durchsucht werden, z.B. `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; fügt korrigierte Befehle zur Historie hinzu `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; maximale Zeit in Sekunden für die Ausgabe des vorherigen Befehls, falls er in `slow_commands` steht;
* `THEFUCK_SLOW_COMMANDS` &ndash; Liste langsamer Befehle, z.B. `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; maximale Anzahl ähnlicher Vorschläge, z.B. `5`;
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; zu ignorierende Pfad-Präfixe bei der Suche nach Befehlen, standardmäßig `[]`;

Zum Beispiel:

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

##### [Zurück zum Inhalt](#contents)

## Drittanbieter-Pakete mit Regeln

Wenn du einen bestimmten Satz nicht-öffentlicher Regeln erstellen, aber dennoch mit anderen teilen möchtest, erstelle ein Paket mit dem Namen `thefuck_contrib_*` mit folgender Struktur:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *drittanbieter-Regeln*
    __init__.py
    *drittanbieter-Utils*
  setup.py
```

*The Fuck* findet Regeln, die sich im Modul `rules` befinden.

##### [Zurück zum Inhalt](#contents)

## Experimenteller Instant-Modus

Das Standardverhalten von *The Fuck* benötigt Zeit, um vorherige Befehle erneut auszuführen.
Im Instant-Modus spart *The Fuck* Zeit, indem es die Ausgabe mit [script](https://de.wikipedia.org/wiki/Script_(Unix))
protokolliert und dann das Protokoll liest.

[![gif mit Instant-Modus][instant-mode-gif-link]][instant-mode-gif-link]

Aktuell unterstützt der Instant-Modus nur Python 3 mit bash oder zsh. Die Autokorrektur-Funktion von zsh muss deaktiviert werden, damit thefuck korrekt funktioniert.

Um den Instant-Modus zu aktivieren, füge `--enable-experimental-instant-mode`
zur Alias-Initialisierung in `.bashrc`, `.bash_profile` oder `.zshrc` hinzu.

Zum Beispiel:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Zurück zum Inhalt](#contents)

## Entwicklung

Siehe [CONTRIBUTING.md](CONTRIBUTING.md)

## Lizenz MIT
Die Projektlizenz findest du [hier](LICENSE.md).


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

##### [Zurück zum Inhalt](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---