# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* è un'app magnifica, ispirata da un [tweet di @liamosaur](https://twitter.com/liamosaur/status/506975850596536320), che corregge gli errori nei comandi precedenti della console.

*The Fuck* è troppo lento? [Prova la modalità istantanea sperimentale!](#experimental-instant-mode)

[![gif con esempi][examples-link]][examples-link]

Altri esempi:

```bash
➜ apt-get install vim
E: Impossibile aprire il file di blocco /var/lib/dpkg/lock - open (13: Permesso negato)
E: Impossibile bloccare la directory di amministrazione (/var/lib/dpkg/), sei root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[password sudo per nvbn]:
Lettura dell'elenco dei pacchetti... Fatto
...
```

```bash
➜ git push
fatal: Il branch corrente master non ha un branch upstream.
Per pushare il branch corrente e impostare il remoto come upstream, usa

    git push --set-upstream origin master


➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Conteggio degli oggetti: 9, fatto.
...
```

```bash
➜ puthon
Nessun comando 'puthon' trovato, volevi dire:
 Comando 'python' dal pacchetto 'python-minimal' (main)
 Comando 'python' dal pacchetto 'python3' (main)
zsh: comando non trovato: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' non è un comando git. Vedi 'git --help'.

Intendevi questo?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' non è un task. Vedi 'lein help'.

Intendevi questo?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL server started on port 54848 on host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Se non hai paura di eseguire ciecamente i comandi corretti, l'opzione
`require_confirmation` nelle [impostazioni](#settings) può essere disabilitata:

```bash
➜ apt-get install vim
E: Impossibile aprire il file di blocco /var/lib/dpkg/lock - open (13: Permesso negato)
E: Impossibile bloccare la directory di amministrazione (/var/lib/dpkg/), sei root?

➜ fuck
sudo apt-get install vim
[password sudo per nvbn]:
Lettura dell'elenco dei pacchetti... Fatto
...
```

## Indice

1. [Requisiti](#requirements)
2. [Installazione](#installation)
3. [Aggiornamento](#updating)
4. [Come funziona](#how-it-works)
5. [Creare le proprie regole](#creating-your-own-rules)
6. [Impostazioni](#settings)
7. [Pacchetti di terze parti con regole](#third-party-packages-with-rules)
8. [Modalità istantanea sperimentale](#experimental-instant-mode)
9. [Sviluppo](#developing)
10. [Licenza](#license-mit)

## Requisiti

- python (3.5+)
- pip
- python-dev

##### [Torna all'indice](#contents)

## Installazione

Su macOS o Linux, puoi installare *The Fuck* tramite [Homebrew][homebrew]:

```bash
brew install thefuck
```

Su Ubuntu / Mint, installa *The Fuck* con i seguenti comandi:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

Su FreeBSD, installa *The Fuck* con i seguenti comandi:
```bash
pkg install thefuck
```

Su ChromeOS, installa *The Fuck* usando [chromebrew](https://github.com/skycocker/chromebrew) con il seguente comando:
```bash
crew install thefuck
```

Su sistemi basati su Arch, installa *The Fuck* con il seguente comando:
```
sudo pacman -S thefuck
```

Su altri sistemi, installa *The Fuck* usando `pip`:

```bash
pip install thefuck
```

[In alternativa, puoi usare un gestore di pacchetti del sistema operativo (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Si raccomanda di inserire questo comando nel tuo `.bash_profile`,
`.bashrc`, `.zshrc` o altro script di avvio:

```bash
eval $(thefuck --alias)
# Puoi usare qualsiasi alias tu voglia, ad esempio per i lunedì:
eval $(thefuck --alias FUCK)
```

[Oppure nella configurazione della tua shell (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Le modifiche sono disponibili solo in una nuova sessione della shell. Per renderle disponibili immediatamente,
esegui `source ~/.bashrc` (o il file di configurazione della tua shell come `.zshrc`).

Per eseguire i comandi corretti senza conferma, usa l'opzione `--yeah` (o semplicemente `-y` come abbreviazione, o `--hard` se sei particolarmente frustrato):

```bash
fuck --yeah
```

Per correggere i comandi ricorsivamente fino al successo, usa l'opzione `-r`:

```bash
fuck -r
```

##### [Torna all'indice](#contents)

## Aggiornamento

```bash
pip3 install thefuck --upgrade
```

**Nota: La funzionalità di alias è cambiata nella versione v1.34 di *The Fuck***

## Disinstallazione

Per rimuovere *The Fuck*, esegui il processo inverso di installazione:
- cancella o commenta la riga dell'alias *thefuck* dal file di configurazione della tua shell (Bash, Zsh, Fish, Powershell, tcsh, ...)
- usa il tuo gestore di pacchetti (brew, pip3, pkg, crew, pip) per disinstallare i binari

## Come funziona

*The Fuck* cerca di abbinare il comando precedente a una regola. Se trova una corrispondenza,
viene creato un nuovo comando usando la regola trovata ed eseguito. Le
seguenti regole sono abilitate di default:

* `adb_unknown_command` &ndash; corregge comandi scritti male come `adb logcta`;
* `ag_literal` &ndash; aggiunge `-Q` a `ag` quando suggerito;
* `aws_cli` &ndash; corregge comandi scritti male come `aws dynamdb scan`;
* `az_cli` &ndash; corregge comandi scritti male come `az providers`;
* `cargo` &ndash; esegue `cargo build` invece di `cargo`;
* `cargo_no_command` &ndash; corregge comandi errati come `cargo buid`;
* `cat_dir` &ndash; sostituisce `cat` con `ls` quando provi a fare `cat` su una directory;
* `cd_correction` &ndash; controlla l'ortografia e corregge i comandi cd falliti;
* `cd_cs` &ndash; cambia `cs` in `cd`;
* `cd_mkdir` &ndash; crea directory prima di entrarvi con cd;
* `cd_parent` &ndash; cambia `cd..` in `cd ..`;
* `chmod_x` &ndash; aggiunge il bit di esecuzione;
* `choco_install` &ndash; aggiunge suffissi comuni per pacchetti chocolatey;
* `composer_not_command` &ndash; corregge il nome del comando composer;
* `conda_mistype` &ndash; corregge i comandi conda;
* `cp_create_destination` &ndash; crea una nuova directory quando tenti di `cp` o `mv` verso una non esistente;
* `cp_omitting_directory` &ndash; aggiunge `-a` quando fai `cp` di una directory;
* `cpp11` &ndash; aggiunge `-std=c++11` mancante a `g++` o `clang++`;
* `dirty_untar` &ndash; corregge il comando `tar x` che scompatta nella directory corrente;
* `dirty_unzip` &ndash; corregge il comando `unzip` che scompatta nella directory corrente;
* `django_south_ghost` &ndash; aggiunge `--delete-ghost-migrations` se fallisce a causa di ghost migration django south;
* `django_south_merge` &ndash; aggiunge `--merge` a migrazione django south incoerente;
* `docker_login` &ndash; esegue un `docker login` e ripete il comando precedente;
* `docker_not_command` &ndash; corregge comandi docker errati come `docker tags`;
* `docker_image_being_used_by_container` &dash; rimuove il container che sta usando l'immagine prima di rimuovere l'immagine;
* `dry` &ndash; corregge ripetizioni come `git git push`;
* `fab_command_not_found` &ndash; corregge comandi fabric scritti male;
* `fix_alt_space` &ndash; sostituisce Alt+Spazio con carattere Spazio;
* `fix_file` &ndash; apre un file con errore nel tuo `$EDITOR`;
* `gem_unknown_command` &ndash; corregge comandi `gem` errati;
* `git_add` &ndash; corregge *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` &ndash; aggiunge `--force` a `git add <pathspec>...` quando i percorsi sono in .gitignore;
* `git_bisect_usage` &ndash; corregge `git bisect strt`, `git bisect goood`, `git bisect rset`, ecc. durante il bisect;
* `git_branch_delete` &ndash; cambia `git branch -d` in `git branch -D`;
* `git_branch_delete_checked_out` &ndash; cambia `git branch -d` in `git checkout master && git branch -D` quando provi a cancellare un branch attivo;
* `git_branch_exists` &ndash; offre `git branch -d foo`, `git branch -D foo` o `git checkout foo` quando crei un branch già esistente;
* `git_branch_list` &ndash; intercetta `git branch list` invece di `git branch` e rimuove il branch creato;
* `git_branch_0flag` &ndash; corregge comandi come `git branch 0v` e `git branch 0r` rimuovendo il branch creato;
* `git_checkout` &ndash; corregge il nome del branch o ne crea uno nuovo;
* `git_clone_git_clone` &ndash; sostituisce `git clone git clone ...` con `git clone ...`
* `git_clone_missing` &ndash; aggiunge `git clone` a URL che sembrano puntare a un repository git.
* `git_commit_add` &ndash; offre `git commit -a ...` o `git commit -p ...` dopo il commit precedente se fallito perché nulla era stato aggiunto;
* `git_commit_amend` &ndash; offre `git commit --amend` dopo il commit precedente;
* `git_commit_reset` &ndash; offre `git reset HEAD~` dopo il commit precedente;
* `git_diff_no_index` &ndash; aggiunge `--no-index` al precedente `git diff` su file non tracciati;
* `git_diff_staged` &ndash; aggiunge `--staged` al precedente `git diff` con output inaspettato;
* `git_fix_stash` &ndash; corregge i comandi `git stash` (sottocomando errato o `save` mancante);
* `git_flag_after_filename` &ndash; corregge `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; corregge i comandi `git help <alias>` sostituendo <alias> con il comando aliasato;
* `git_hook_bypass` &ndash; aggiunge il flag `--no-verify` prima di `git am`, `git commit` o `git push`;
* `git_lfs_mistype` &ndash; corregge errori di battitura nei comandi `git lfs <command>`;
* `git_main_master` &ndash; corregge il nome errato del branch tra `main` e `master`
* `git_merge` &ndash; aggiunge il remoto ai nomi dei branch;
* `git_merge_unrelated` &ndash; aggiunge `--allow-unrelated-histories` quando richiesto
* `git_not_command` &ndash; corregge comandi git errati come `git brnch`;
* `git_pull` &ndash; imposta upstream prima di eseguire il precedente `git pull`;
* `git_pull_clone` &ndash; clona invece di fare pull quando il repo non esiste;
* `git_pull_uncommitted_changes` &ndash; fa stash delle modifiche prima del pull e le ripristina dopo;
* `git_push` &ndash; aggiunge `--set-upstream origin $branch` al precedente `git push` fallito;
* `git_push_different_branch_names` &ndash; corregge push quando il nome del branch locale non corrisponde al nome del branch remoto;
* `git_push_pull` &ndash; esegue `git pull` quando il `push` viene rifiutato;
* `git_push_without_commits` &ndash; crea un commit iniziale se lo dimentichi e fai solo `git add .` quando imposti un nuovo progetto;
* `git_rebase_no_changes` &ndash; esegue `git rebase --skip` invece di `git rebase --continue` quando non ci sono cambiamenti;
* `git_remote_delete` &ndash; sostituisce `git remote delete remote_name` con `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; aggiunge `-f` o `--cached` quando provi a `rm` un file modificato localmente;
* `git_rm_recursive` &ndash; aggiunge `-r` quando provi a `rm` una directory;
* `git_rm_staged` &ndash;  aggiunge `-f` o `--cached` quando provi a `rm` un file con cambiamenti in stage
* `git_rebase_merge_dir` &ndash; offre `git rebase (--continue | --abort | --skip)` o la rimozione della directory `.git/rebase-merge` durante un rebase;
* `git_remote_seturl_add` &ndash; esegue `git remote add` quando `git remote set_url` su un remoto inesistente;
* `git_stash` &ndash; fa stash delle modifiche locali prima di rebasing o cambio branch;
* `git_stash_pop` &ndash; aggiunge le modifiche locali prima di poppare lo stash, poi resetta;
* `git_tag_force` &ndash; aggiunge `--force` a `git tag <tagname>` quando il tag esiste già;
* `git_two_dashes` &ndash; aggiunge un trattino mancante a comandi come `git commit -amend` o `git rebase -continue`;
* `go_run` &ndash; aggiunge l'estensione `.go` quando si compilano/eseguono programmi Go;
* `go_unknown_command` &ndash; corregge comandi `go` errati, ad esempio `go bulid`;
* `gradle_no_task` &ndash; corregge task `gradle` non trovati o ambigui;
* `gradle_wrapper` &ndash; sostituisce `gradle` con `./gradlew`;
* `grep_arguments_order` &ndash; corregge l'ordine degli argomenti di `grep` per casi come `grep -lir . test`;
* `grep_recursive` &ndash; aggiunge `-r` quando provi a fare `grep` su una directory;
* `grunt_task_not_found` &ndash; corregge comandi `grunt` scritti male;
* `gulp_not_task` &ndash; corregge task `gulp` scritte male;
* `has_exists_script` &ndash; antepone `./` quando lo script/binario esiste;
* `heroku_multiple_apps` &ndash; aggiunge `--app <app>` ai comandi `heroku` come `heroku pg`;
* `heroku_not_command` &ndash; corregge comandi `heroku` errati come `heroku log`;
* `history` &ndash; cerca di sostituire il comando con quello più simile nella cronologia;
* `hostscli` &ndash; cerca di correggere l'uso di `hostscli`;
* `ifconfig_device_not_found` &ndash; corregge nomi di dispositivi errati come `wlan0` in `wlp2s0`;
* `java` &ndash; rimuove l'estensione `.java` quando esegui programmi Java;
* `javac` &ndash; aggiunge `.java` mancante durante la compilazione di file Java;
* `lein_not_task` &ndash; corregge task `lein` errate come `lein rpl`;
* `long_form_help` &ndash; cambia `-h` in `--help` quando la versione corta non è supportata
* `ln_no_hard_link` &ndash; intercetta la creazione di hard link su directory, suggerisce link simbolico;
* `ln_s_order` &ndash; corregge l'ordine degli argomenti di `ln -s`;
* `ls_all` &ndash; aggiunge `-A` a `ls` quando l'output è vuoto;
* `ls_lah` &ndash; aggiunge `-lah` a `ls`;
* `man` &ndash; cambia la sezione del manuale;
* `man_no_space` &ndash; corregge comandi man senza spazi, ad esempio `mandiff`;
* `mercurial` &ndash; corregge comandi `hg` errati;
* `missing_space_before_subcommand` &ndash; corregge comandi senza spazio come `npminstall`;
* `mkdir_p` &ndash; aggiunge `-p` quando provi a creare una directory senza padre;
* `mvn_no_command` &ndash; aggiunge `clean package` a `mvn`;
* `mvn_unknown_lifecycle_phase` &ndash; corregge fasi di ciclo di vita scritte male con `mvn`;
* `npm_missing_script` &ndash; corregge il nome dello script personalizzato in `npm run-script <script>`;
* `npm_run_script` &ndash; aggiunge `run-script` mancante per script personalizzati `npm`;
* `npm_wrong_command` &ndash; corregge comandi npm errati come `npm urgrade`;
* `no_command` &ndash; corregge comandi della console errati, ad esempio `vom/vim`;
* `no_such_file` &ndash; crea directory mancanti con i comandi `mv` e `cp`;
* `omnienv_no_such_command` &ndash; corregge comandi errati per `goenv`, `nodenv`, `pyenv` e `rbenv` (es.: `pyenv isntall` o `goenv list`);
* `open` &ndash; antepone `http://` all'indirizzo passato a `open` o crea un nuovo file o directory e lo passa a `open`;
* `pip_install` &ndash; corregge problemi di permessi con `pip install` aggiungendo `--user` o anteponendo `sudo` se necessario;
* `pip_unknown_command` &ndash; corregge comandi `pip` errati, ad esempio `pip instatl/pip install`;
* `php_s` &ndash; sostituisce `-s` con `-S` quando provi a eseguire un server php locale;
* `port_already_in_use` &ndash; uccide il processo che occupa la porta;
* `prove_recursively` &ndash; aggiunge `-r` quando chiamato con una directory;
* `python_command` &ndash; antepone `python` quando provi a eseguire uno script python non eseguibile/senza `./`;
* `python_execute` &ndash; aggiunge `.py` mancante nell'esecuzione di file Python;
* `python_module_error` &ndash; corregge ModuleNotFoundError provando a fare `pip install` di quel modulo;
* `quotation_marks` &ndash; corregge l'uso non bilanciato di `'` e `"` negli argomenti;
* `path_from_history` &ndash; sostituisce un percorso non trovato con un percorso assoluto simile dalla cronologia;
* `rails_migrations_pending` &ndash; esegue le migrazioni in sospeso;
* `react_native_command_unrecognized` &ndash; corregge comandi `react-native` non riconosciuti;
* `remove_shell_prompt_literal` &ndash; rimuove il simbolo del prompt della shell `$` all'inizio, comune quando si copiano comandi dalla documentazione;
* `remove_trailing_cedilla` &ndash; rimuove le cediglie finali `ç`, errore comune con tastiere europee;
* `rm_dir` &ndash; aggiunge `-rf` quando provi a rimuovere una directory;
* `scm_correction` &ndash; corregge scm errati come `hg log` in `git log`;
* `sed_unterminated_s` &ndash; aggiunge '/' mancante ai comandi `s` di `sed`;
* `sl_ls` &ndash; cambia `sl` in `ls`;
* `ssh_known_hosts` &ndash; rimuove l'host da `known_hosts` in caso di avviso;
* `sudo` &ndash; antepone `sudo` al comando precedente se fallisce per permessi;
* `sudo_command_from_user_path` &ndash; esegue comandi dal `$PATH` dell'utente con `sudo`;
* `switch_lang` &ndash; cambia il comando dal tuo layout locale a en;
* `systemctl` &ndash; ordina correttamente i parametri di `systemctl` confusi;
* `terraform_init.py` &ndash; esegue `terraform init` prima di plan o apply;
* `terraform_no_command.py` &ndash; corregge comandi `terraform` non riconosciuti;
* `test.py` &ndash; esegue `pytest` invece di `test.py`;
* `touch` &ndash; crea directory mancanti prima di fare "touch";
* `tsuru_login` &ndash; esegue `tsuru login` se non autenticato o sessione scaduta;
* `tsuru_not_command` &ndash; corregge comandi `tsuru` errati come `tsuru shell`;
* `tmux` &ndash; corregge comandi `tmux`;
* `unknown_command` &ndash; corregge "unknown command" in stile hadoop hdfs, ad esempio aggiunge '-' mancante al comando su `hdfs dfs ls`;
* `unsudo` &ndash; rimuove `sudo` dal comando precedente se un processo rifiuta di essere eseguito con privilegi di superutente.
* `vagrant_up` &ndash; avvia l'istanza vagrant;
* `whois` &ndash; corregge il comando `whois`;
* `workon_doesnt_exists` &ndash; corregge il nome dell'env di `virtualenvwrapper` o suggerisce di crearne uno nuovo.
* `wrong_hyphen_before_subcommand` &ndash; rimuove un trattino impropriamente posizionato (`apt-install` -> `apt install`, `git-log` -> `git log`, ecc.)
* `yarn_alias` &ndash; corregge comandi alias `yarn` come `yarn ls`;
* `yarn_command_not_found` &ndash; corregge comandi `yarn` scritti male;
* `yarn_command_replaced` &ndash; corregge comandi `yarn` sostituiti;
* `yarn_help` &ndash; facilita l'apertura della documentazione di `yarn`;

##### [Torna all'indice](#contents)

Le seguenti regole sono abilitate di default solo su alcune piattaforme:

* `apt_get` &ndash; installa l'app con apt se non è installata (richiede `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; cambia la ricerca tramite `apt-get` con quella tramite `apt-cache`;
* `apt_invalid_operation` &ndash; corregge chiamate non valide di `apt` e `apt-get`, come `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; ti aiuta a eseguire `apt list --upgradable` dopo `apt update`;
* `apt_upgrade` &ndash; ti aiuta a eseguire `apt upgrade` dopo `apt list --upgradable`;
* `brew_cask_dependency` &ndash; installa le dipendenze cask;
* `brew_install` &ndash; corregge il nome della formula per `brew install`;
* `brew_reinstall` &ndash; trasforma `brew install <formula>` in `brew reinstall <formula>`;
* `brew_link` &ndash; aggiunge `--overwrite --dry-run` se il linking fallisce;
* `brew_uninstall` &ndash; aggiunge `--force` a `brew uninstall` se erano installate più versioni;
* `brew_unknown_command` &ndash; corregge comandi brew errati, ad esempio `brew docto/brew doctor`;
* `brew_update_formula` &ndash; trasforma `brew update <formula>` in `brew upgrade <formula>`;
* `dnf_no_such_command` &ndash; corregge comandi DNF scritti male;
* `nixos_cmd_not_found` &ndash; installa app su NixOS;
* `pacman` &ndash; installa l'app con `pacman` se non è installata (usa `yay`, `pikaur` o `yaourt` se disponibili);
* `pacman_invalid_option` &ndash; sostituisce le opzioni minuscole di `pacman` con quelle maiuscole.
* `pacman_not_found` &ndash; corregge il nome del pacchetto con `pacman`, `yay`, `pikaur` o `yaourt`.
* `yum_invalid_operation` &ndash; corregge chiamate non valide di `yum`, come `yum isntall vim`;

I seguenti comandi sono inclusi con *The Fuck*, ma non sono abilitati
di default:

* `git_push_force` &ndash; aggiunge `--force-with-lease` a un `git push` (può entrare in conflitto con `git_push_pull`);
* `rm_root` &ndash; aggiunge `--no-preserve-root` al comando `rm -rf /`.

##### [Torna all'indice](#contents)

## Creare le proprie regole

Per aggiungere una tua regola, crea un file chiamato `nome-della-tua-regola.py`
in `~/.config/thefuck/rules`. Il file della regola deve contenere due funzioni:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Inoltre, le regole possono contenere funzioni opzionali:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Le regole possono anche contenere le variabili opzionali `enabled_by_default`, `requires_output` e `priority`.

`Command` ha tre attributi: `script`, `output` e `script_parts`.
La tua regola non dovrebbe modificare `Command`.

**Le API delle regole sono cambiate nella versione 3.0:** per accedere alle impostazioni di una regola, importale con
 `from thefuck.conf import settings`

`settings` è un oggetto speciale assemblato da `~/.config/thefuck/settings.py`,
e dai valori delle variabili d'ambiente ([vedi sotto](#settings)).

Un semplice esempio di regola per eseguire uno script con `sudo`:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Opzionale:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Più basso prima, il default è 1000

requires_output = True
```

[Altri esempi di regole](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[funzioni di utilità per le regole](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[helper specifici per app/os](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Torna all'indice](#contents)

## Impostazioni

Diversi parametri di *The Fuck* possono essere modificati nel file `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` di default è `~/.config`):

* `rules` &ndash; lista delle regole abilitate, per default `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; lista delle regole disabilitate, per default `[]`;
* `require_confirmation` &ndash; richiede conferma prima di eseguire il nuovo comando, per default `True`;
* `wait_command` &ndash; tempo massimo in secondi per ottenere l'output del comando precedente;
* `no_colors` &ndash; disabilita l'output colorato;
* `priority` &ndash; dizionario con priorità delle regole, la regola con priorità più bassa sarà abbinata per prima;
* `debug` &ndash; abilita l'output di debug, per default `False`;
* `history_limit` &ndash; numero di comandi della cronologia che verranno scansionati, ad esempio `2000`;
* `alter_history` &ndash; aggiunge il comando corretto alla cronologia, per default `True`;
* `wait_slow_command` &ndash; tempo massimo in secondi per ottenere l'output del comando precedente se è nella lista `slow_commands`;
* `slow_commands` &ndash; elenco dei comandi lenti;
* `num_close_matches` &ndash; numero massimo di suggerimenti di corrispondenza, per default `3`.
* `excluded_search_path_prefixes` &ndash; prefissi di percorso da ignorare durante la ricerca dei comandi, per default `[]`.

Un esempio di `settings.py`:

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

Oppure tramite variabili d'ambiente:

* `THEFUCK_RULES` &ndash; elenco delle regole abilitate, come `DEFAULT_RULES:rm_root` o `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; elenco delle regole disabilitate, come `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; richiede conferma prima di eseguire il nuovo comando, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; tempo massimo in secondi per ottenere l'output del comando precedente;
* `THEFUCK_NO_COLORS` &ndash; disabilita l'output colorato, `true/false`;
* `THEFUCK_PRIORITY` &ndash; priorità delle regole, come `no_command=9999:apt_get=100`,
la regola con priorità più bassa sarà abbinata per prima;
* `THEFUCK_DEBUG` &ndash; abilita l'output di debug, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; quanti comandi della cronologia verranno scansionati, ad esempio `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; aggiunge il comando corretto alla cronologia `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; tempo massimo in secondi per ottenere l'output del comando precedente se è nella lista `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` &ndash; elenco dei comandi lenti, come `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; numero massimo di suggerimenti di corrispondenza, ad esempio `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; prefissi di percorso da ignorare durante la ricerca dei comandi, per default `[]`.

Ad esempio:

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

##### [Torna all'indice](#contents)

## Pacchetti di terze parti con regole

Se vuoi creare un set specifico di regole non pubbliche, ma desideri comunque
condividerle con altri, crea un pacchetto chiamato `thefuck_contrib_*` con
la seguente struttura:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *regole di terze parti*
    __init__.py
    *utilità di terze parti*
  setup.py
```

*The Fuck* troverà le regole nel modulo `rules`.

##### [Torna all'indice](#contents)

## Modalità istantanea sperimentale

Il comportamento predefinito di *The Fuck* richiede tempo per rieseguire i comandi precedenti.
In modalità istantanea, *The Fuck* risparmia tempo registrando l'output con [script](https://en.wikipedia.org/wiki/Script_(Unix)),
e poi leggendo il log.

[![gif con modalità istantanea][instant-mode-gif-link]][instant-mode-gif-link]

Attualmente, la modalità istantanea supporta solo Python 3 con bash o zsh. La funzione autocorrect di zsh deve essere disabilitata affinché thefuck funzioni correttamente.

Per abilitare la modalità istantanea, aggiungi `--enable-experimental-instant-mode`
all'inizializzazione dell'alias in `.bashrc`, `.bash_profile` o `.zshrc`.

Ad esempio:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Torna all'indice](#contents)

## Sviluppo

Vedi [CONTRIBUTING.md](CONTRIBUTING.md)

## Licenza MIT
La licenza del progetto è disponibile [qui](LICENSE.md).


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

##### [Torna all'indice](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---