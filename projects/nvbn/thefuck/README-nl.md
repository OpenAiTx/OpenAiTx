# The Fuck [![Versie][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT Licentie][license-badge]](LICENSE.md)

*The Fuck* is een schitterende app, geïnspireerd door een [@liamosaur](https://twitter.com/liamosaur/)
[tweet](https://twitter.com/liamosaur/status/506975850596536320),
die fouten in eerdere consolecommando's corrigeert.

Is *The Fuck* te traag? [Probeer de experimentele instant-modus!](#experimental-instant-mode)

[![gif met voorbeelden][examples-link]][examples-link]

Meer voorbeelden:

```bash
➜ apt-get install vim
E: Kan het lockbestand /var/lib/dpkg/lock niet openen - open (13: Toegang geweigerd)
E: Kan de administratie map (/var/lib/dpkg/) niet vergrendelen, ben je root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] wachtwoord voor nvbn:
Pakketlijsten worden ingelezen... Klaar
...
```

```bash
➜ git push
fatal: De huidige branch master heeft geen upstream branch.
Om de huidige branch te pushen en de remote als upstream in te stellen, gebruik

    git push --set-upstream origin master


➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Aantal objecten tellen: 9, klaar.
...
```

```bash
➜ puthon
Geen commando 'puthon' gevonden, bedoelde je:
 Commando 'python' uit pakket 'python-minimal' (main)
 Commando 'python' uit pakket 'python3' (main)
zsh: commando niet gevonden: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' is geen git-commando. Zie 'git --help'.

Bedoelde je dit?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' is geen taak. Zie 'lein help'.

Bedoelde je dit?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL server gestart op poort 54848 op host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Als je niet bang bent om gecorrigeerde commando's blindelings uit te voeren, kan de
`require_confirmation` [instelling](#settings) worden uitgeschakeld:

```bash
➜ apt-get install vim
E: Kan het lockbestand /var/lib/dpkg/lock niet openen - open (13: Toegang geweigerd)
E: Kan de administratie map (/var/lib/dpkg/) niet vergrendelen, ben je root?

➜ fuck
sudo apt-get install vim
[sudo] wachtwoord voor nvbn:
Pakketlijsten worden ingelezen... Klaar
...
```

## Inhoud

1. [Vereisten](#requirements)
2. [Installatie](#installation)
3. [Updaten](#updating)
4. [Hoe het werkt](#how-it-works)
5. [Eigen regels maken](#creating-your-own-rules)
6. [Instellingen](#settings)
7. [Derde partij pakketten met regels](#third-party-packages-with-rules)
8. [Experimentele instant-modus](#experimental-instant-mode)
9. [Ontwikkelen](#developing)
10. [Licentie](#license-mit)

## Vereisten

- python (3.5+)
- pip
- python-dev

##### [Terug naar Inhoud](#contents)

## Installatie

Op macOS of Linux kun je *The Fuck* installeren via [Homebrew][homebrew]:

```bash
brew install thefuck
```

Op Ubuntu / Mint, installeer *The Fuck* met de volgende commando's:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

Op FreeBSD, installeer *The Fuck* met de volgende commando's:
```bash
pkg install thefuck
```

Op ChromeOS, installeer *The Fuck* via [chromebrew](https://github.com/skycocker/chromebrew) met het volgende commando:
```bash
crew install thefuck
```

Op Arch-gebaseerde systemen, installeer *The Fuck* met het volgende commando:
```
sudo pacman -S thefuck
```

Op andere systemen, installeer *The Fuck* met `pip`:

```bash
pip install thefuck
```

[Je kunt ook een OS pakketbeheerder gebruiken (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Het wordt aanbevolen om dit commando toe te voegen aan je `.bash_profile`,
`.bashrc`, `.zshrc` of een ander opstartscript:

```bash
eval $(thefuck --alias)
# Je kunt elke gewenste alias gebruiken, bijvoorbeeld voor maandagen:
eval $(thefuck --alias FUCK)
```

[Of in je shellconfiguratie (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Wijzigingen zijn alleen beschikbaar in een nieuwe shellsessie. Om wijzigingen direct
beschikbaar te maken, voer `source ~/.bashrc` uit (of jouw shellconfiguratiebestand zoals `.zshrc`).

Om gecorrigeerde commando's zonder bevestiging uit te voeren, gebruik de `--yeah` optie (of gewoon `-y` als afkorting, of `--hard` als je erg gefrustreerd bent):

```bash
fuck --yeah
```

Om commando's recursief te herstellen tot succes, gebruik de `-r` optie:

```bash
fuck -r
```

##### [Terug naar Inhoud](#contents)

## Updaten

```bash
pip3 install thefuck --upgrade
```

**Let op: Aliasfunctionaliteit is gewijzigd in v1.34 van *The Fuck***

## Verwijderen

Om *The Fuck* te verwijderen, draai het installatieproces terug:
- verwijder of zet commentaar op de *thefuck* aliasregel uit je Bash, Zsh, Fish, Powershell, tcsh, ... shellconfiguratie
- gebruik je pakketbeheerder (brew, pip3, pkg, crew, pip) om de binaries te verwijderen

## Hoe het werkt

*The Fuck* probeert het vorige commando te matchen met een regel. Als er een match is,
wordt er een nieuw commando gemaakt met de gematchte regel en uitgevoerd. De
volgende regels zijn standaard ingeschakeld:

* `adb_unknown_command` – corrigeert verkeerd gespelde commando's zoals `adb logcta`;
* `ag_literal` – voegt `-Q` toe aan `ag` wanneer gesuggereerd;
* `aws_cli` – corrigeert verkeerd gespelde commando's zoals `aws dynamdb scan`;
* `az_cli` – corrigeert verkeerd gespelde commando's zoals `az providers`;
* `cargo` – voert `cargo build` uit in plaats van `cargo`;
* `cargo_no_command` – corrigeert foute commando's zoals `cargo buid`;
* `cat_dir` – vervangt `cat` door `ls` wanneer je een directory probeert te caten;
* `cd_correction` – spellcheckt en corrigeert mislukte cd-commando's;
* `cd_cs` – verandert `cs` naar `cd`;
* `cd_mkdir` – maakt mappen aan voordat er naartoe wordt gegaan met cd;
* `cd_parent` – verandert `cd..` naar `cd ..`;
* `chmod_x` – voegt uitvoerrechten toe;
* `choco_install` – voegt veelgebruikte achtervoegsels toe voor chocolatey-pakketten;
* `composer_not_command` – corrigeert composer-commando's;
* `conda_mistype` – corrigeert conda-commando's;
* `cp_create_destination` – maakt een nieuwe map aan als je `cp` of `mv` gebruikt naar een niet-bestaande;
* `cp_omitting_directory` – voegt `-a` toe wanneer je een map kopieert;
* `cpp11` – voegt ontbrekende `-std=c++11` toe aan `g++` of `clang++`;
* `dirty_untar` – corrigeert `tar x` die in de huidige map heeft uitgepakt;
* `dirty_unzip` – corrigeert `unzip` die in de huidige map heeft uitgepakt;
* `django_south_ghost` – voegt `--delete-ghost-migrations` toe aan gefaalde django south migraties door ghosts;
* `django_south_merge` – voegt `--merge` toe aan inconsistente django south migraties;
* `docker_login` – voert een `docker login` uit en herhaalt het vorige commando;
* `docker_not_command` – corrigeert verkeerde docker-commando's zoals `docker tags`;
* `docker_image_being_used_by_container` – verwijdert de container die het image gebruikt voordat het image wordt verwijderd;
* `dry` – corrigeert herhalingen zoals `git git push`;
* `fab_command_not_found` – corrigeert verkeerd gespelde fabric-commando's;
* `fix_alt_space` – vervangt Alt+Space door een spatie;
* `fix_file` – opent een bestand met een fout in je `$EDITOR`;
* `gem_unknown_command` – corrigeert foute `gem`-commando's;
* `git_add` – corrigeert *"pathspec 'foo' komt niet overeen met een bestaand bestand in git."*;
* `git_add_force` – voegt `--force` toe aan `git add <pad>...` als het pad in .gitignore staat;
* `git_bisect_usage` – corrigeert `git bisect strt`, `git bisect goood`, `git bisect rset`, etc. bij bisecten;
* `git_branch_delete` – verandert `git branch -d` naar `git branch -D`;
* `git_branch_delete_checked_out` – verandert `git branch -d` naar `git checkout master && git branch -D` bij het verwijderen van de huidige branch;
* `git_branch_exists` – biedt `git branch -d foo`, `git branch -D foo` of `git checkout foo` aan als een branch al bestaat;
* `git_branch_list` – vangt `git branch list` in plaats van `git branch` en verwijdert aangemaakte branch;
* `git_branch_0flag` – corrigeert commando's als `git branch 0v` en `git branch 0r` door de aangemaakte branch te verwijderen;
* `git_checkout` – corrigeert branchnamen of maakt nieuwe branch aan;
* `git_clone_git_clone` – vervangt `git clone git clone ...` door `git clone ...`
* `git_clone_missing` – voegt `git clone` toe aan URL's die naar een git-repository lijken te verwijzen.
* `git_commit_add` – biedt `git commit -a ...` of `git commit -p ...` aan na vorige commit als er niets gestaged was;
* `git_commit_amend` – biedt `git commit --amend` aan na vorige commit;
* `git_commit_reset` – biedt `git reset HEAD~` aan na vorige commit;
* `git_diff_no_index` – voegt `--no-index` toe aan vorige `git diff` op niet-getrackte bestanden;
* `git_diff_staged` – voegt `--staged` toe aan vorige `git diff` met onverwachte output;
* `git_fix_stash` – corrigeert `git stash`-commando's (verkeerd gespelde subcommand en ontbrekende `save`);
* `git_flag_after_filename` – corrigeert `fatal: bad flag '...' after filename`
* `git_help_aliased` – corrigeert `git help <alias>` door <alias> te vervangen door het bijbehorende commando;
* `git_hook_bypass` – voegt `--no-verify` toe aan `git am`, `git commit`, of `git push`;
* `git_lfs_mistype` – corrigeert verkeerd getypte `git lfs <command>` commando's;
* `git_main_master` – corrigeert foute branchnaam tussen `main` en `master`
* `git_merge` – voegt remote toe aan branchnamen;
* `git_merge_unrelated` – voegt `--allow-unrelated-histories` toe indien nodig
* `git_not_command` – corrigeert verkeerde git-commando's zoals `git brnch`;
* `git_pull` – stelt upstream in voordat vorige `git pull` wordt uitgevoerd;
* `git_pull_clone` – clonet in plaats van pullen als de repo niet bestaat;
* `git_pull_uncommitted_changes` – stash't wijzigingen voor het pullen en popt ze daarna;
* `git_push` – voegt `--set-upstream origin $branch` toe aan mislukte `git push`;
* `git_push_different_branch_names` – corrigeert pushen wanneer lokale branchnaam niet overeenkomt met remote branchnaam;
* `git_push_pull` – voert `git pull` uit als `push` werd geweigerd;
* `git_push_without_commits` – maakt een eerste commit als je dat vergeet en alleen `git add .` doet bij het opzetten van een nieuw project;
* `git_rebase_no_changes` – voert `git rebase --skip` uit in plaats van `git rebase --continue` als er geen wijzigingen zijn;
* `git_remote_delete` – vervangt `git remote delete remote_name` door `git remote remove remote_name`;
* `git_rm_local_modifications` – voegt `-f` of `--cached` toe als je een lokaal gewijzigd bestand probeert te verwijderen;
* `git_rm_recursive` – voegt `-r` toe als je een map probeert te verwijderen;
* `git_rm_staged` – voegt `-f` of `--cached` toe als je een bestand met gestagede wijzigingen probeert te verwijderen
* `git_rebase_merge_dir` – biedt `git rebase (--continue | --abort | --skip)` of het verwijderen van de `.git/rebase-merge` map aan als een rebase bezig is;
* `git_remote_seturl_add` – voert `git remote add` uit als `git remote set_url` op een niet-bestaande remote;
* `git_stash` – stash't lokale wijzigingen voor het rebasen of switchen van branch;
* `git_stash_pop` – voegt je lokale wijzigingen toe voor het poppen van stash, en reset daarna;
* `git_tag_force` – voegt `--force` toe aan `git tag <tagname>` als de tag al bestaat;
* `git_two_dashes` – voegt een ontbrekend streepje toe aan commando's zoals `git commit -amend` of `git rebase -continue`;
* `go_run` – voegt `.go` extensie toe bij compileren/uitvoeren van Go-programma's;
* `go_unknown_command` – corrigeert verkeerde `go`-commando's, bijvoorbeeld `go bulid`;
* `gradle_no_task` – corrigeert niet gevonden of dubbele `gradle`-taak;
* `gradle_wrapper` – vervangt `gradle` door `./gradlew`;
* `grep_arguments_order` – corrigeert volgorde van grep-argumenten zoals `grep -lir . test`;
* `grep_recursive` – voegt `-r` toe als je een map probeert te greppen;
* `grunt_task_not_found` – corrigeert verkeerd gespelde `grunt`-commando's;
* `gulp_not_task` – corrigeert verkeerd gespelde `gulp`-taken;
* `has_exists_script` – zet `./` voor scripts/binaries die bestaan;
* `heroku_multiple_apps` – voegt `--app <app>` toe aan `heroku`-commando's zoals `heroku pg`;
* `heroku_not_command` – corrigeert verkeerde `heroku`-commando's zoals `heroku log`;
* `history` – probeert commando te vervangen door het meest gelijkende uit de geschiedenis;
* `hostscli` – probeert `hostscli`-gebruik te corrigeren;
* `ifconfig_device_not_found` – corrigeert verkeerde apparaatnamen zoals `wlan0` naar `wlp2s0`;
* `java` – verwijdert `.java` extensie bij het uitvoeren van Java-programma's;
* `javac` – voegt ontbrekende `.java` toe bij het compileren van Java-bestanden;
* `lein_not_task` – corrigeert verkeerde `lein`-taken zoals `lein rpl`;
* `long_form_help` – verandert `-h` naar `--help` als de korte versie niet wordt ondersteund
* `ln_no_hard_link` – vangt aanmaken van hardlinks op mappen, stelt symbolische link voor;
* `ln_s_order` – corrigeert argumentvolgorde van `ln -s`;
* `ls_all` – voegt `-A` toe aan `ls` als de output leeg is;
* `ls_lah` – voegt `-lah` toe aan `ls`;
* `man` – verandert manualsectie;
* `man_no_space` – corrigeert man-commando's zonder spatie, bijvoorbeeld `mandiff`;
* `mercurial` – corrigeert verkeerde `hg`-commando's;
* `missing_space_before_subcommand` – corrigeert commando's zonder spatie zoals `npminstall`;
* `mkdir_p` – voegt `-p` toe als je een map zonder ouder probeert te maken;
* `mvn_no_command` – voegt `clean package` toe aan `mvn`;
* `mvn_unknown_lifecycle_phase` – corrigeert verkeerd gespelde lifecycle-fases met `mvn`;
* `npm_missing_script` – corrigeert custom scriptnaam in `npm run-script <script>`;
* `npm_run_script` – voegt ontbrekende `run-script` toe voor custom `npm`-scripts;
* `npm_wrong_command` – corrigeert verkeerde npm-commando's zoals `npm urgrade`;
* `no_command` – corrigeert verkeerde consolecommando's, bijvoorbeeld `vom/vim`;
* `no_such_file` – maakt ontbrekende mappen aan met `mv` en `cp` commando's;
* `omnienv_no_such_command` – corrigeert verkeerde commando's voor `goenv`, `nodenv`, `pyenv` en `rbenv` (bijv. `pyenv isntall` of `goenv list`);
* `open` – zet `http://` voor adres bij `open` of maakt nieuw bestand/map aan en opent het;
* `pip_install` – corrigeert permissieproblemen met `pip install` door `--user` toe te voegen of `sudo` voor te zetten indien nodig;
* `pip_unknown_command` – corrigeert verkeerde `pip`-commando's, bijvoorbeeld `pip instatl/pip install`;
* `php_s` – vervangt `-s` door `-S` bij het draaien van een lokale php-server;
* `port_already_in_use` – beëindigt proces dat poort bezet;
* `prove_recursively` – voegt `-r` toe bij aanroep met map;
* `python_command` – zet `python` voor een niet-uitvoerbaar python-script zonder `./`;
* `python_execute` – voegt ontbrekende `.py` toe bij uitvoeren van Python-bestanden;
* `python_module_error` – corrigeert ModuleNotFoundError door te proberen het module te installeren met pip;
* `quotation_marks` – corrigeert ongelijkmatig gebruik van `'` en `"` in argumenten;
* `path_from_history` – vervangt niet gevonden pad door soortgelijk absoluut pad uit geschiedenis;
* `rails_migrations_pending` – voert openstaande migraties uit;
* `react_native_command_unrecognized` – corrigeert onbekende `react-native`-commando's;
* `remove_shell_prompt_literal` – verwijdert vooraanstaande promptsymbolen `$`, vaak bij kopiëren uit documentatie;
* `remove_trailing_cedilla` – verwijdert afsluitende cedilla's `ç`, een veelgemaakte fout op Europese toetsenborden;
* `rm_dir` – voegt `-rf` toe als je een map probeert te verwijderen;
* `scm_correction` – corrigeert verkeerde scm zoals `hg log` naar `git log`;
* `sed_unterminated_s` – voegt ontbrekende '/' toe aan `sed`'s `s`-commando's;
* `sl_ls` – verandert `sl` in `ls`;
* `ssh_known_hosts` – verwijdert host uit `known_hosts` bij waarschuwing;
* `sudo` – zet `sudo` voor het vorige commando als het faalde wegens permissies;
* `sudo_command_from_user_path` – voert commando's uit gebruikers `$PATH` uit met `sudo`;
* `switch_lang` – wisselt commando van lokale naar en layout;
* `systemctl` – ordent parameters van verwarrende `systemctl` correct;
* `terraform_init.py` – voert `terraform init` uit voor plan of apply;
* `terraform_no_command.py` – corrigeert onbekende `terraform`-commando's;
* `test.py` – voert `pytest` uit in plaats van `test.py`;
* `touch` – maakt ontbrekende mappen aan voordat 'touch' wordt uitgevoerd;
* `tsuru_login` – voert `tsuru login` uit als niet geauthenticeerd of sessie verlopen;
* `tsuru_not_command` – corrigeert verkeerde `tsuru`-commando's zoals `tsuru shell`;
* `tmux` – corrigeert `tmux`-commando's;
* `unknown_command` – corrigeert hadoop hdfs-achtige "unknown command", bijvoorbeeld voegt ontbrekende '-' toe op `hdfs dfs ls`;
* `unsudo` – verwijdert `sudo` van vorig commando als een proces niet op superuser wil draaien.
* `vagrant_up` – start de vagrant-instantie;
* `whois` – corrigeert `whois`-commando;
* `workon_doesnt_exists` – corrigeert `virtualenvwrapper` env naam of stelt voor om een nieuwe te maken.
* `wrong_hyphen_before_subcommand` – verwijdert een verkeerd geplaatste koppelteken (`apt-install` -> `apt install`, `git-log` -> `git log`, enz.)
* `yarn_alias` – corrigeert gealiasede `yarn`-commando's zoals `yarn ls`;
* `yarn_command_not_found` – corrigeert verkeerd gespelde `yarn`-commando's;
* `yarn_command_replaced` – corrigeert vervangen `yarn`-commando's;
* `yarn_help` – maakt het makkelijker om `yarn` documentatie te openen;

##### [Terug naar Inhoud](#contents)

De volgende regels zijn standaard alleen op specifieke platforms ingeschakeld:

* `apt_get` – installeert app met apt als deze niet geïnstalleerd is (vereist `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` – verandert proberen te zoeken met `apt-get` naar zoeken met `apt-cache`;
* `apt_invalid_operation` – corrigeert ongeldige `apt` en `apt-get` oproepen, zoals `apt-get isntall vim`;
* `apt_list_upgradable` – helpt je `apt list --upgradable` uit te voeren na `apt update`;
* `apt_upgrade` – helpt je `apt upgrade` uit te voeren na `apt list --upgradable`;
* `brew_cask_dependency` – installeert cask-afhankelijkheden;
* `brew_install` – corrigeert formulenaam voor `brew install`;
* `brew_reinstall` – maakt van `brew install <formula>` `brew reinstall <formula>`;
* `brew_link` – voegt `--overwrite --dry-run` toe als linken mislukt;
* `brew_uninstall` – voegt `--force` toe aan `brew uninstall` als meerdere versies geïnstalleerd zijn;
* `brew_unknown_command` – corrigeert verkeerde brew-commando's, zoals `brew docto/brew doctor`;
* `brew_update_formula` – maakt van `brew update <formula>` `brew upgrade <formula>`;
* `dnf_no_such_command` – corrigeert verkeerd getypte DNF-commando's;
* `nixos_cmd_not_found` – installeert apps op NixOS;
* `pacman` – installeert app met `pacman` als deze niet geïnstalleerd is (gebruikt `yay`, `pikaur` of `yaourt` indien beschikbaar);
* `pacman_invalid_option` – vervangt kleine letters bij pacman-opties door hoofdletters.
* `pacman_not_found` – corrigeert pakketnaam met `pacman`, `yay`, `pikaur` of `yaourt`.
* `yum_invalid_operation` – corrigeert ongeldige `yum`-opdrachten, zoals `yum isntall vim`;

De volgende commando's zijn meegeleverd met *The Fuck*, maar zijn niet standaard ingeschakeld:

* `git_push_force` – voegt `--force-with-lease` toe aan een `git push` (kan conflicteren met `git_push_pull`);
* `rm_root` – voegt `--no-preserve-root` toe aan het `rm -rf /` commando.

##### [Terug naar Inhoud](#contents)

## Eigen regels maken

Om een eigen regel toe te voegen, maak een bestand genaamd `jouw-regelnaam.py`
in `~/.config/thefuck/rules`. Het regelbestand moet twee functies bevatten:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Daarnaast kunnen regels optionele functies bevatten:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Regels kunnen ook de optionele variabelen `enabled_by_default`, `requires_output` en `priority` bevatten.

`Command` heeft drie attributen: `script`, `output` en `script_parts`.
Je regel mag `Command` niet wijzigen.

**Rules api gewijzigd in 3.0:** Om toegang te krijgen tot de instellingen van een regel, importeer met
 `from thefuck.conf import settings`

`settings` is een speciaal object samengesteld uit `~/.config/thefuck/settings.py`,
en waarden uit env ([zie hieronder](#settings)).

Een eenvoudig voorbeeld van een regel om een script met `sudo` uit te voeren:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Optioneel:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Lager eerst, standaard is 1000

requires_output = True
```

[Meer voorbeelden van regels](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[hulpfuncties voor regels](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[app/os-specifieke helpers](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Terug naar Inhoud](#contents)

## Instellingen

Diverse *The Fuck* parameters kunnen worden aangepast in het bestand `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` is standaard `~/.config`):

* `rules` – lijst van ingeschakelde regels, standaard `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` – lijst van uitgeschakelde regels, standaard `[]`;
* `require_confirmation` – vraagt bevestiging voor het uitvoeren van nieuwe commando's, standaard `True`;
* `wait_command` – maximale tijd in seconden om uitvoer van vorig commando op te halen;
* `no_colors` – schakel gekleurde uitvoer uit;
* `priority` – dict met regelprioriteiten, regel met lagere `priority` wordt als eerste gematcht;
* `debug` – schakelt debuguitvoer in, standaard `False`;
* `history_limit` – numerieke waarde hoeveel opdrachten uit geschiedenis worden gescand, zoals `2000`;
* `alter_history` – plaatst gecorrigeerde opdracht in geschiedenis, standaard `True`;
* `wait_slow_command` – maximale tijd in seconden voor ophalen van uitvoer als commando in `slow_commands` staat;
* `slow_commands` – lijst van trage commando's;
* `num_close_matches` – maximaal aantal suggesties voor gelijkende commando's, standaard `3`.
* `excluded_search_path_prefixes` – padprefixen om te negeren bij zoeken naar commando's, standaard `[]`.

Een voorbeeld van `settings.py`:

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

Of via omgevingsvariabelen:

* `THEFUCK_RULES` – lijst van ingeschakelde regels, zoals `DEFAULT_RULES:rm_root` of `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` – lijst van uitgeschakelde regels, zoals `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` – vraag bevestiging voor uitvoeren nieuwe commando, `true/false`;
* `THEFUCK_WAIT_COMMAND` – maximale tijd in seconden voor ophalen uitvoer vorig commando;
* `THEFUCK_NO_COLORS` – schakel gekleurde uitvoer uit, `true/false`;
* `THEFUCK_PRIORITY` – prioriteit van regels, zoals `no_command=9999:apt_get=100`,
regel met lagere `priority` wordt als eerste gematcht;
* `THEFUCK_DEBUG` – schakelt debuguitvoer in, `true/false`;
* `THEFUCK_HISTORY_LIMIT` – hoeveel opdrachten uit geschiedenis worden gescand, zoals `2000`;
* `THEFUCK_ALTER_HISTORY` – plaats gecorrigeerde opdracht in geschiedenis `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` – maximale tijd in seconden voor ophalen uitvoer als commando in `slow_commands` staat;
* `THEFUCK_SLOW_COMMANDS` – lijst van trage commando's, zoals `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` – maximaal aantal suggesties voor gelijkende commando's, zoals `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` – padprefixen om te negeren bij zoeken naar commando's, standaard `[]`.

Bijvoorbeeld:

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

##### [Terug naar Inhoud](#contents)

## Derde partij pakketten met regels

Als je een specifieke set niet-openbare regels wilt maken, maar ze toch wilt
delen met anderen, maak dan een pakket genaamd `thefuck_contrib_*` met
de volgende structuur:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *derde-partij-regels*
    __init__.py
    *derde-partij-utils*
  setup.py
```

*The Fuck* zal regels vinden in de module `rules`.

##### [Terug naar Inhoud](#contents)

## Experimentele instant-modus

Het standaardgedrag van *The Fuck* kost tijd om vorige commando's opnieuw uit te voeren.
In de instant-modus bespaart *The Fuck* tijd door uitvoer te loggen met [script](https://en.wikipedia.org/wiki/Script_(Unix)),
en vervolgens het logbestand te lezen.

[![gif met instant-modus][instant-mode-gif-link]][instant-mode-gif-link]

Momenteel ondersteunt instant-modus alleen Python 3 met bash of zsh. De autocorrect functie van zsh moet ook zijn uitgeschakeld om thefuck correct te laten werken.

Om instant-modus in te schakelen, voeg `--enable-experimental-instant-mode`
toe aan de alias-initialisatie in `.bashrc`, `.bash_profile` of `.zshrc`.

Bijvoorbeeld:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Terug naar Inhoud](#contents)

## Ontwikkelen

Zie [CONTRIBUTING.md](CONTRIBUTING.md)

## Licentie MIT
Projectlicentie is te vinden [hier](LICENSE.md).


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

##### [Terug naar Inhoud](#contents)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---