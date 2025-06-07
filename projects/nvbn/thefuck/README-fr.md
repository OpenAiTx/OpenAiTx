# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* est une application magnifique, inspirée par un [tweet](https://twitter.com/liamosaur/status/506975850596536320) de [@liamosaur](https://twitter.com/liamosaur/), qui corrige les erreurs dans les commandes console précédentes.

*The Fuck* est-il trop lent ? [Essayez le mode instantané expérimental !](#experimental-instant-mode)

[![gif avec exemples][examples-link]][examples-link]

Plus d'exemples :

```bash
➜ apt-get install vim
E: Impossible d’ouvrir le fichier de verrouillage /var/lib/dpkg/lock - open (13: Permission non accordée)
E: Impossible de verrouiller le répertoire d’administration (/var/lib/dpkg/), êtes-vous root ?

➜ fuck
sudo apt-get install vim [entrée/↑/↓/ctrl+c]
[sudo] mot de passe pour nvbn :
Lecture des listes de paquets... Fait
...
```

```bash
➜ git push
fatal: La branche courante master n’a pas de branche upstream.
Pour pousser la branche courante et définir le remote comme upstream, utilisez

    git push --set-upstream origin master

➜ fuck
git push --set-upstream origin master [entrée/↑/↓/ctrl+c]
Décompte des objets : 9, fait.
...
```

```bash
➜ puthon
Aucune commande 'puthon' trouvée, vouliez-vous dire :
 Commande 'python' du paquet 'python-minimal' (main)
 Commande 'python' du paquet 'python3' (main)
zsh: commande introuvable : puthon

➜ fuck
python [entrée/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git : 'brnch' n’est pas une commande git. Voir 'git --help'.

Vouliez-vous dire ceci ?
    branch

➜ fuck
git branch [entrée/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' n’est pas une tâche. Voir 'lein help'.

Vouliez-vous dire ceci ?
         repl

➜ fuck
lein repl [entrée/↑/↓/ctrl+c]
nREPL server démarré sur le port 54848 sur l’hôte 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Si vous n’avez pas peur d’exécuter aveuglément les commandes corrigées, l’option `require_confirmation` dans les [paramètres](#settings) peut être désactivée :

```bash
➜ apt-get install vim
E: Impossible d’ouvrir le fichier de verrouillage /var/lib/dpkg/lock - open (13: Permission non accordée)
E: Impossible de verrouiller le répertoire d’administration (/var/lib/dpkg/), êtes-vous root ?

➜ fuck
sudo apt-get install vim
[sudo] mot de passe pour nvbn :
Lecture des listes de paquets... Fait
...
```

## Sommaire

1. [Prérequis](#requirements)
2. [Installation](#installation)
3. [Mise à jour](#updating)
4. [Comment ça marche](#how-it-works)
5. [Créer vos propres règles](#creating-your-own-rules)
6. [Paramètres](#settings)
7. [Paquets tiers avec des règles](#third-party-packages-with-rules)
8. [Mode instantané expérimental](#experimental-instant-mode)
9. [Développement](#developing)
10. [Licence](#license-mit)

## Prérequis

- python (3.5+)
- pip
- python-dev

##### [Retour au Sommaire](#contents)

## Installation

Sur macOS ou Linux, vous pouvez installer *The Fuck* via [Homebrew][homebrew] :

```bash
brew install thefuck
```

Sur Ubuntu / Mint, installez *The Fuck* avec les commandes suivantes :
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

Sur FreeBSD, installez *The Fuck* avec les commandes suivantes :
```bash
pkg install thefuck
```

Sur ChromeOS, installez *The Fuck* en utilisant [chromebrew](https://github.com/skycocker/chromebrew) avec la commande suivante :
```bash
crew install thefuck
```

Sur les systèmes basés sur Arch, installez *The Fuck* avec la commande suivante :
```
sudo pacman -S thefuck
```

Sur d’autres systèmes, installez *The Fuck* avec `pip` :

```bash
pip install thefuck
```

[Vous pouvez également utiliser un gestionnaire de paquets de votre OS (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Il est recommandé d’ajouter cette commande dans votre `.bash_profile`,
`.bashrc`, `.zshrc` ou autre script de démarrage :

```bash
eval $(thefuck --alias)
# Vous pouvez utiliser l’alias que vous voulez, par exemple pour le lundi :
eval $(thefuck --alias FUCK)
```

[Ou dans votre configuration de shell (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Les changements ne sont disponibles que dans une nouvelle session de shell. Pour rendre les changements disponibles immédiatement, exécutez `source ~/.bashrc` (ou le fichier de config de votre shell comme `.zshrc`).

Pour exécuter les commandes corrigées sans confirmation, utilisez l’option `--yeah` (ou simplement `-y` pour faire court, ou `--hard` si vous êtes particulièrement frustré) :

```bash
fuck --yeah
```

Pour corriger les commandes de façon récursive jusqu’à réussir, utilisez l’option `-r` :

```bash
fuck -r
```

##### [Retour au Sommaire](#contents)

## Mise à jour

```bash
pip3 install thefuck --upgrade
```

**Remarque : La fonctionnalité d’alias a changé dans la version 1.34 de *The Fuck***

## Désinstallation

Pour supprimer *The Fuck*, inversez le processus d’installation :
- supprimez ou commentez la ligne d’alias *thefuck* de votre fichier de configuration de shell Bash, Zsh, Fish, Powershell, tcsh, ...
- utilisez votre gestionnaire de paquets (brew, pip3, pkg, crew, pip) pour désinstaller les binaires

## Comment ça marche

*The Fuck* tente de faire correspondre la commande précédente avec une règle. Si une correspondance est trouvée, une nouvelle commande est créée à l’aide de la règle correspondante et exécutée. Les règles suivantes sont activées par défaut :

* `adb_unknown_command` &ndash; corrige les commandes mal orthographiées comme `adb logcta` ;
* `ag_literal` &ndash; ajoute `-Q` à `ag` si suggéré ;
* `aws_cli` &ndash; corrige les commandes mal orthographiées comme `aws dynamdb scan` ;
* `az_cli` &ndash; corrige les commandes mal orthographiées comme `az providers` ;
* `cargo` &ndash; exécute `cargo build` au lieu de `cargo` ;
* `cargo_no_command` &ndash; corrige les commandes erronées comme `cargo buid` ;
* `cat_dir` &ndash; remplace `cat` par `ls` si vous essayez de `cat` un répertoire ;
* `cd_correction` &ndash; corrige l’orthographe des commandes cd échouées ;
* `cd_cs` &ndash; change `cs` en `cd` ;
* `cd_mkdir` &ndash; crée les répertoires avant d’y accéder avec cd ;
* `cd_parent` &ndash; change `cd..` en `cd ..` ;
* `chmod_x` &ndash; ajoute le bit d’exécution ;
* `choco_install` &ndash; ajoute des suffixes courants pour les paquets chocolatey ;
* `composer_not_command` &ndash; corrige le nom de la commande composer ;
* `conda_mistype` &ndash; corrige les commandes conda ;
* `cp_create_destination` &ndash; crée un nouveau répertoire lorsque vous tentez de `cp` ou `mv` vers un répertoire inexistant
* `cp_omitting_directory` &ndash; ajoute `-a` quand vous copiez un répertoire avec `cp` ;
* `cpp11` &ndash; ajoute le `-std=c++11` manquant à `g++` ou `clang++` ;
* `dirty_untar` &ndash; corrige la commande `tar x` qui a extrait dans le répertoire courant ;
* `dirty_unzip` &ndash; corrige la commande `unzip` qui a extrait dans le répertoire courant ;
* `django_south_ghost` &ndash; ajoute `--delete-ghost-migrations` à l’échec de migration ghost django south ;
* `django_south_merge` &ndash; ajoute `--merge` à une migration django south incohérente ;
* `docker_login` &ndash; exécute un `docker login` puis répète la commande précédente ;
* `docker_not_command` &ndash; corrige les mauvaises commandes docker comme `docker tags` ;
* `docker_image_being_used_by_container` &ndash; supprime le conteneur qui utilise l’image avant de supprimer l’image ;
* `dry` &ndash; corrige les répétitions comme `git git push` ;
* `fab_command_not_found` &ndash; corrige les commandes fabric mal orthographiées ;
* `fix_alt_space` &ndash; remplace Alt+Espace par un espace classique ;
* `fix_file` &ndash; ouvre un fichier avec une erreur dans votre `$EDITOR` ;
* `gem_unknown_command` &ndash; corrige les mauvaises commandes `gem` ;
* `git_add` &ndash; corrige *"pathspec 'foo' did not match any file(s) known to git."* ;
* `git_add_force` &ndash; ajoute `--force` à `git add <pathspec>...` quand les chemins sont .gitignore’d ;
* `git_bisect_usage` &ndash; corrige `git bisect strt`, `git bisect goood`, `git bisect rset`, etc. lors du bisect ;
* `git_branch_delete` &ndash; change `git branch -d` en `git branch -D` ;
* `git_branch_delete_checked_out` &ndash; change `git branch -d` en `git checkout master && git branch -D` lors de la suppression d’une branche actuellement check-out ;
* `git_branch_exists` &ndash; propose `git branch -d foo`, `git branch -D foo` ou `git checkout foo` lors de la création d’une branche existante ;
* `git_branch_list` &ndash; intercepte `git branch list` au lieu de `git branch` et supprime la branche créée ;
* `git_branch_0flag` &ndash; corrige des commandes telles que `git branch 0v` et `git branch 0r` en supprimant la branche créée ;
* `git_checkout` &ndash; corrige le nom de la branche ou en crée une nouvelle ;
* `git_clone_git_clone` &ndash; remplace `git clone git clone ...` par `git clone ...`
* `git_clone_missing` &ndash; ajoute `git clone` à des URLs ressemblant à des dépôts git.
* `git_commit_add` &ndash; propose `git commit -a ...` ou `git commit -p ...` après un commit précédent échoué car rien n’était préparé ;
* `git_commit_amend` &ndash; propose `git commit --amend` après le commit précédent ;
* `git_commit_reset` &ndash; propose `git reset HEAD~` après le commit précédent ;
* `git_diff_no_index` &ndash; ajoute `--no-index` au `git diff` précédent sur des fichiers non suivis ;
* `git_diff_staged` &ndash; ajoute `--staged` au `git diff` précédent avec une sortie inattendue ;
* `git_fix_stash` &ndash; corrige les commandes `git stash` (sous-commande mal orthographiée et `save` manquant) ;
* `git_flag_after_filename` &ndash; corrige `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; corrige les commandes `git help <alias>` en remplaçant <alias> par la commande réelle ;
* `git_hook_bypass` &ndash; ajoute l’option `--no-verify` avant `git am`, `git commit` ou `git push` ;
* `git_lfs_mistype` &ndash; corrige les commandes `git lfs <command>` mal orthographiées ;
* `git_main_master` &ndash; corrige le nom de branche entre `main` et `master`
* `git_merge` &ndash; ajoute le remote aux noms de branche ;
* `git_merge_unrelated` &ndash; ajoute `--allow-unrelated-histories` si nécessaire
* `git_not_command` &ndash; corrige les mauvaises commandes git comme `git brnch` ;
* `git_pull` &ndash; définit l’upstream avant d’exécuter le précédent `git pull` ;
* `git_pull_clone` &ndash; clone au lieu de pull si le repo n’existe pas ;
* `git_pull_uncommitted_changes` &ndash; stash les modifications avant de pull puis les restaure ;
* `git_push` &ndash; ajoute `--set-upstream origin $branch` au précédent `git push` échoué ;
* `git_push_different_branch_names` &ndash; corrige les pushs lorsque le nom de la branche locale ne correspond pas au remote ;
* `git_push_pull` &ndash; exécute `git pull` quand le push est rejeté ;
* `git_push_without_commits` &ndash; crée un commit initial si vous oubliez après un simple `git add .` en créant un nouveau projet ;
* `git_rebase_no_changes` &ndash; exécute `git rebase --skip` au lieu de `git rebase --continue` si aucun changement ;
* `git_remote_delete` &ndash; remplace `git remote delete remote_name` par `git remote remove remote_name` ;
* `git_rm_local_modifications` &ndash; ajoute `-f` ou `--cached` lors de la suppression d’un fichier modifié localement ;
* `git_rm_recursive` &ndash; ajoute `-r` lors de la suppression d’un répertoire ;
* `git_rm_staged` &ndash; ajoute `-f` ou `--cached` lors de la suppression d’un fichier avec des modifications dans l’index
* `git_rebase_merge_dir` &ndash; propose `git rebase (--continue | --abort | --skip)` ou supprime le dossier `.git/rebase-merge` lors d’un rebase en cours ;
* `git_remote_seturl_add` &ndash; exécute `git remote add` lors d’un `git remote set_url` sur un remote inexistant ;
* `git_stash` &ndash; stash vos modifications locales avant un rebase ou un changement de branche ;
* `git_stash_pop` &ndash; ajoute vos modifications locales avant de restaurer le stash, puis fait un reset ;
* `git_tag_force` &ndash; ajoute `--force` à `git tag <tagname>` si le tag existe déjà ;
* `git_two_dashes` &ndash; ajoute un tiret manquant aux commandes comme `git commit -amend` ou `git rebase -continue` ;
* `go_run` &ndash; ajoute l’extension `.go` lors de la compilation/exécution de programmes Go ;
* `go_unknown_command` &ndash; corrige les mauvaises commandes go, par exemple `go bulid` ;
* `gradle_no_task` &ndash; corrige les tâches `gradle` introuvables ou ambiguës ;
* `gradle_wrapper` &ndash; remplace `gradle` par `./gradlew` ;
* `grep_arguments_order` &ndash; corrige l’ordre des arguments de `grep` pour des cas comme `grep -lir . test` ;
* `grep_recursive` &ndash; ajoute `-r` quand vous tentez de `grep` un répertoire ;
* `grunt_task_not_found` &ndash; corrige les tâches grunt mal orthographiées ;
* `gulp_not_task` &ndash; corrige les tâches gulp mal orthographiées ;
* `has_exists_script` &ndash; ajoute `./` si le script/binaire existe ;
* `heroku_multiple_apps` &ndash; ajoute `--app <app>` aux commandes heroku comme `heroku pg` ;
* `heroku_not_command` &ndash; corrige les mauvaises commandes heroku comme `heroku log` ;
* `history` &ndash; tente de remplacer la commande par la plus similaire de l’historique ;
* `hostscli` &ndash; tente de corriger l’utilisation de `hostscli` ;
* `ifconfig_device_not_found` &ndash; corrige les mauvais noms de périphériques comme `wlan0` en `wlp2s0` ;
* `java` &ndash; retire l’extension `.java` lors de l’exécution de programmes Java ;
* `javac` &ndash; ajoute l’extension `.java` manquante lors de la compilation de fichiers Java ;
* `lein_not_task` &ndash; corrige les mauvaises tâches lein comme `lein rpl` ;
* `long_form_help` &ndash; change `-h` en `--help` quand la version courte n’est pas supportée
* `ln_no_hard_link` &ndash; intercepte la création de lien dur sur des dossiers, suggère un lien symbolique ;
* `ln_s_order` &ndash; corrige l’ordre des arguments de `ln -s` ;
* `ls_all` &ndash; ajoute `-A` à `ls` si la sortie est vide ;
* `ls_lah` &ndash; ajoute `-lah` à `ls` ;
* `man` &ndash; change la section du manuel ;
* `man_no_space` &ndash; corrige les commandes man sans espace, par exemple `mandiff` ;
* `mercurial` &ndash; corrige les mauvaises commandes `hg` ;
* `missing_space_before_subcommand` &ndash; corrige les commandes sans espace avant la sous-commande comme `npminstall` ;
* `mkdir_p` &ndash; ajoute `-p` lors de la création d’un dossier sans parent ;
* `mvn_no_command` &ndash; ajoute `clean package` à `mvn` ;
* `mvn_unknown_lifecycle_phase` &ndash; corrige les phases du cycle de vie mal orthographiées avec `mvn` ;
* `npm_missing_script` &ndash; corrige le nom du script custom dans `npm run-script <script>` ;
* `npm_run_script` &ndash; ajoute le `run-script` manquant pour les scripts custom `npm` ;
* `npm_wrong_command` &ndash; corrige les mauvaises commandes npm comme `npm urgrade` ;
* `no_command` &ndash; corrige les mauvaises commandes console, par exemple `vom/vim` ;
* `no_such_file` &ndash; crée les dossiers manquants avec les commandes `mv` et `cp` ;
* `omnienv_no_such_command` &ndash; corrige les mauvaises commandes pour `goenv`, `nodenv`, `pyenv` et `rbenv` (ex : `pyenv isntall` ou `goenv list`) ;
* `open` &ndash; ajoute soit `http://` à l’adresse passée à `open`, soit crée un nouveau fichier ou dossier et le passe à `open` ;
* `pip_install` &ndash; corrige les problèmes de permissions avec les commandes `pip install` en ajoutant `--user` ou en préfixant par `sudo` si nécessaire ;
* `pip_unknown_command` &ndash; corrige les mauvaises commandes pip, par exemple `pip instatl/pip install` ;
* `php_s` &ndash; remplace `-s` par `-S` lors de l’exécution d’un serveur php local ;
* `port_already_in_use` &ndash; tue le processus occupant le port ;
* `prove_recursively` &ndash; ajoute `-r` lorsqu’appelée avec un dossier ;
* `python_command` &ndash; préfixe par `python` si vous essayez d’exécuter un script python non exécutable/sans `./` ;
* `python_execute` &ndash; ajoute l’extension `.py` manquante lors de l’exécution de fichiers Python ;
* `python_module_error` &ndash; corrige ModuleNotFoundError en tentant de faire un `pip install` du module ;
* `quotation_marks` &ndash; corrige l’utilisation inégale de `'` et `"` dans les arguments ;
* `path_from_history` &ndash; remplace un chemin introuvable par un chemin absolu similaire de l’historique ;
* `rails_migrations_pending` &ndash; exécute les migrations en attente ;
* `react_native_command_unrecognized` &ndash; corrige les commandes `react-native` non reconnues ;
* `remove_shell_prompt_literal` &ndash; supprime le symbole de prompt shell `$`, fréquent lors de la copie de commandes depuis une documentation ;
* `remove_trailing_cedilla` &ndash; supprime les cédilles finales `ç`, erreur fréquente avec les claviers européens ;
* `rm_dir` &ndash; ajoute `-rf` lorsque vous essayez de supprimer un dossier ;
* `scm_correction` &ndash; corrige le mauvais gestionnaire de source comme `hg log` en `git log` ;
* `sed_unterminated_s` &ndash; ajoute le `/` manquant aux commandes `s` de `sed` ;
* `sl_ls` &ndash; change `sl` en `ls` ;
* `ssh_known_hosts` &ndash; retire l’hôte de `known_hosts` en cas d’avertissement ;
* `sudo` &ndash; ajoute `sudo` à la commande précédente si elle a échoué à cause des permissions ;
* `sudo_command_from_user_path` &ndash; exécute les commandes du `$PATH` utilisateur avec `sudo` ;
* `switch_lang` &ndash; change la commande de votre disposition locale vers en ;
* `systemctl` &ndash; ordonne correctement les paramètres du déroutant `systemctl` ;
* `terraform_init.py` &ndash; exécute `terraform init` avant plan ou apply ;
* `terraform_no_command.py` &ndash; corrige les commandes `terraform` non reconnues ;
* `test.py` &ndash; exécute `pytest` au lieu de `test.py` ;
* `touch` &ndash; crée les dossiers manquants avant de faire un "touch" ;
* `tsuru_login` &ndash; exécute `tsuru login` si non authentifié ou session expirée ;
* `tsuru_not_command` &ndash; corrige les mauvaises commandes tsuru comme `tsuru shell` ;
* `tmux` &ndash; corrige les commandes tmux ;
* `unknown_command` &ndash; corrige les erreurs de type "unknown command" hadoop hdfs, par exemple en ajoutant le tiret manquant à la commande sur `hdfs dfs ls` ;
* `unsudo` &ndash; retire `sudo` de la commande précédente si un process refuse de s’exécuter en superutilisateur.
* `vagrant_up` &ndash; démarre l’instance vagrant ;
* `whois` &ndash; corrige la commande whois ;
* `workon_doesnt_exists` &ndash; corrige le nom d’environnement virtualenvwrapper ou propose d’en créer un nouveau.
* `wrong_hyphen_before_subcommand` &ndash; retire un tiret mal placé (`apt-install` -> `apt install`, `git-log` -> `git log`, etc.)
* `yarn_alias` &ndash; corrige les commandes aliasées yarn comme `yarn ls` ;
* `yarn_command_not_found` &ndash; corrige les commandes yarn mal orthographiées ;
* `yarn_command_replaced` &ndash; corrige les commandes yarn remplacées ;
* `yarn_help` &ndash; facilite l’ouverture de la documentation yarn ;

##### [Retour au Sommaire](#contents)

Les règles suivantes sont activées par défaut uniquement sur certaines plateformes :

* `apt_get` &ndash; installe l’application via apt si elle n’est pas installée (nécessite `python-commandnotfound` / `python3-commandnotfound`) ;
* `apt_get_search` &ndash; remplace la recherche via `apt-get` par `apt-cache` ;
* `apt_invalid_operation` &ndash; corrige les appels invalides à `apt` et `apt-get`, comme `apt-get isntall vim` ;
* `apt_list_upgradable` &ndash; vous aide à exécuter `apt list --upgradable` après `apt update` ;
* `apt_upgrade` &ndash; vous aide à exécuter `apt upgrade` après `apt list --upgradable` ;
* `brew_cask_dependency` &ndash; installe les dépendances de cask ;
* `brew_install` &ndash; corrige le nom de la formule dans `brew install` ;
* `brew_reinstall` &ndash; transforme `brew install <formula>` en `brew reinstall <formula>` ;
* `brew_link` &ndash; ajoute `--overwrite --dry-run` si le lien échoue ;
* `brew_uninstall` &ndash; ajoute `--force` à `brew uninstall` si plusieurs versions sont installées ;
* `brew_unknown_command` &ndash; corrige les mauvaises commandes brew, par exemple `brew docto/brew doctor` ;
* `brew_update_formula` &ndash; transforme `brew update <formula>` en `brew upgrade <formula>` ;
* `dnf_no_such_command` &ndash; corrige les commandes DNF mal orthographiées ;
* `nixos_cmd_not_found` &ndash; installe des applications sur NixOS ;
* `pacman` &ndash; installe l’application avec `pacman` si elle n’est pas installée (utilise `yay`, `pikaur` ou `yaourt` si disponibles) ;
* `pacman_invalid_option` &ndash; remplace les options minuscules de pacman par des majuscules.
* `pacman_not_found` &ndash; corrige le nom du paquet avec `pacman`, `yay`, `pikaur` ou `yaourt`.
* `yum_invalid_operation` &ndash; corrige les appels invalides à `yum`, comme `yum isntall vim` ;

Les commandes suivantes sont fournies avec *The Fuck*, mais ne sont pas activées par défaut :

* `git_push_force` &ndash; ajoute `--force-with-lease` à un `git push` (peut entrer en conflit avec `git_push_pull`) ;
* `rm_root` &ndash; ajoute `--no-preserve-root` à la commande `rm -rf /` .

##### [Retour au Sommaire](#contents)

## Créer vos propres règles

Pour ajouter votre propre règle, créez un fichier nommé `your-rule-name.py` dans `~/.config/thefuck/rules`. Le fichier de règle doit contenir deux fonctions :

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

De plus, les règles peuvent contenir des fonctions optionnelles :

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Les règles peuvent aussi contenir les variables optionnelles `enabled_by_default`, `requires_output` et `priority`.

`Command` a trois attributs : `script`, `output` et `script_parts`.
Votre règle ne doit pas modifier `Command`.


**L’API des règles a changé en 3.0 :** Pour accéder aux paramètres d’une règle, importez-les via  
 `from thefuck.conf import settings`

`settings` est un objet spécial assemblé à partir de `~/.config/thefuck/settings.py`, et des valeurs d’environnement ([voir plus bas](#settings)).

Un exemple simple de règle pour exécuter un script avec `sudo` :

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Optionnel :
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Plus bas en premier, 1000 par défaut

requires_output = True
```

[Plus d’exemples de règles](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[fonctions utilitaires pour les règles](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[outils spécifiques à une app/OS](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Retour au Sommaire](#contents)

## Paramètres

Plusieurs paramètres de *The Fuck* peuvent être modifiés dans le fichier `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` vaut par défaut `~/.config`) :

* `rules` &ndash; liste des règles activées, par défaut `thefuck.const.DEFAULT_RULES` ;
* `exclude_rules` &ndash; liste des règles désactivées, par défaut `[]` ;
* `require_confirmation` &ndash; demande confirmation avant d’exécuter la nouvelle commande, par défaut `True` ;
* `wait_command` &ndash; temps maximal (en secondes) pour obtenir la sortie de la commande précédente ;
* `no_colors` &ndash; désactive la sortie colorée ;
* `priority` &ndash; dictionnaire des priorités des règles, une règle avec une priorité plus basse sera testée en premier ;
* `debug` &ndash; active la sortie de debug, par défaut `False` ;
* `history_limit` &ndash; nombre de commandes historiques à analyser, par exemple `2000` ;
* `alter_history` &ndash; pousse la commande corrigée dans l’historique, par défaut `True` ;
* `wait_slow_command` &ndash; temps maximal (en secondes) pour obtenir la sortie de la commande précédente si elle figure dans la liste `slow_commands` ;
* `slow_commands` &ndash; liste de commandes lentes ;
* `num_close_matches` &ndash; nombre maximal de suggestions de correspondances proches, par défaut `3` ;
* `excluded_search_path_prefixes` &ndash; préfixes de chemin à ignorer lors de la recherche de commandes, par défaut `[]` ;

Un exemple de `settings.py` :

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

Ou via les variables d’environnement :

* `THEFUCK_RULES` &ndash; liste des règles activées, comme `DEFAULT_RULES:rm_root` ou `sudo:no_command` ;
* `THEFUCK_EXCLUDE_RULES` &ndash; liste des règles désactivées, comme `git_pull:git_push` ;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; demande confirmation avant d’exécuter la nouvelle commande, `true/false` ;
* `THEFUCK_WAIT_COMMAND` &ndash; temps maximal (en secondes) pour obtenir la sortie de la commande précédente ;
* `THEFUCK_NO_COLORS` &ndash; désactive la sortie colorée, `true/false` ;
* `THEFUCK_PRIORITY` &ndash; priorité des règles, comme `no_command=9999:apt_get=100`, une règle avec une priorité plus basse sera testée en premier ;
* `THEFUCK_DEBUG` &ndash; active la sortie de debug, `true/false` ;
* `THEFUCK_HISTORY_LIMIT` &ndash; nombre de commandes historiques à analyser, par exemple `2000` ;
* `THEFUCK_ALTER_HISTORY` &ndash; pousse la commande corrigée dans l’historique, `true/false` ;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; temps maximal (en secondes) pour obtenir la sortie de la commande précédente si elle figure dans la liste `slow_commands` ;
* `THEFUCK_SLOW_COMMANDS` &ndash; liste de commandes lentes, comme `lein:gradle` ;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; nombre maximal de suggestions de correspondances proches, comme `5` ;
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; préfixes de chemin à ignorer lors de la recherche de commandes, par défaut `[]` ;

Par exemple :

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

##### [Retour au Sommaire](#contents)

## Paquets tiers avec des règles

Si vous souhaitez créer un ensemble spécifique de règles non publiques, mais souhaitez quand même les partager avec d’autres, créez un paquet nommé `thefuck_contrib_*` avec la structure suivante :

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *règles tierces*
    __init__.py
    *utilitaires tiers*
  setup.py
```

*The Fuck* trouvera les règles situées dans le module `rules`.

##### [Retour au Sommaire](#contents)

## Mode instantané expérimental

Le comportement par défaut de *The Fuck* nécessite du temps pour relancer les commandes précédentes.
En mode instantané, *The Fuck* gagne du temps en journalisant la sortie avec [script](https://en.wikipedia.org/wiki/Script_(Unix)), puis en lisant le log.

[![gif avec mode instantané][instant-mode-gif-link]][instant-mode-gif-link]

Actuellement, le mode instantané ne supporte que Python 3 avec bash ou zsh. La fonction autocorrect de zsh doit également être désactivée pour que thefuck fonctionne correctement.

Pour activer le mode instantané, ajoutez `--enable-experimental-instant-mode`
à l’initialisation de l’alias dans `.bashrc`, `.bash_profile` ou `.zshrc`.

Par exemple :

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Retour au Sommaire](#contents)

## Développement

Voir [CONTRIBUTING.md](CONTRIBUTING.md)

## Licence MIT
La licence du projet se trouve [ici](LICENSE.md).


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

##### [Retour au Sommaire](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---