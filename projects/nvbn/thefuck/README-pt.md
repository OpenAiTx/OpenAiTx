# The Fuck [![Version][version-badge]][version-link] [![Build Status][workflow-badge]][workflow-link] [![Coverage][coverage-badge]][coverage-link] [![MIT License][license-badge]](LICENSE.md)

*The Fuck* é um aplicativo magnífico, inspirado por um [tweet do @liamosaur](https://twitter.com/liamosaur/status/506975850596536320), que corrige erros em comandos anteriores do console.

*The Fuck* está muito lento? [Experimente o modo instantâneo experimental!](#experimental-instant-mode)

[![gif com exemplos][examples-link]][examples-link]

Mais exemplos:

```bash
➜ apt-get install vim
E: Não foi possível abrir o arquivo de bloqueio /var/lib/dpkg/lock - open (13: Permissão negada)
E: Não foi possível bloquear o diretório de administração (/var/lib/dpkg/), você é root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] senha para nvbn:
Lendo listas de pacotes... Pronto
...
```

```bash
➜ git push
fatal: O branch atual master não possui um branch upstream.
Para enviar o branch atual e definir o remoto como upstream, use

    git push --set-upstream origin master

➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Contando objetos: 9, pronto.
...
```

```bash
➜ puthon
Nenhum comando 'puthon' encontrado, você quis dizer:
 Comando 'python' do pacote 'python-minimal' (main)
 Comando 'python' do pacote 'python3' (main)
zsh: comando não encontrado: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (default, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' não é um comando git. Veja 'git --help'.

Você quis dizer isso?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' não é uma tarefa. Veja 'lein help'.

Você quis dizer isso?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
nREPL server started on port 54848 on host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Se você não tem medo de executar comandos corrigidos cegamente, a opção
`require_confirmation` nas [configurações](#settings) pode ser desabilitada:

```bash
➜ apt-get install vim
E: Não foi possível abrir o arquivo de bloqueio /var/lib/dpkg/lock - open (13: Permissão negada)
E: Não foi possível bloquear o diretório de administração (/var/lib/dpkg/), você é root?

➜ fuck
sudo apt-get install vim
[sudo] senha para nvbn:
Lendo listas de pacotes... Pronto
...
```

## Conteúdo

1. [Requisitos](#requirements)
2. [Instalação](#installation)
3. [Atualização](#updating)
4. [Como funciona](#how-it-works)
5. [Criando suas próprias regras](#creating-your-own-rules)
6. [Configurações](#settings)
7. [Pacotes de terceiros com regras](#third-party-packages-with-rules)
8. [Modo instantâneo experimental](#experimental-instant-mode)
9. [Desenvolvimento](#developing)
10. [Licença](#license-mit)

## Requisitos

- python (3.5+)
- pip
- python-dev

##### [Voltar ao Conteúdo](#contents)

## Instalação

No macOS ou Linux, você pode instalar o *The Fuck* via [Homebrew][homebrew]:

```bash
brew install thefuck
```

No Ubuntu / Mint, instale o *The Fuck* com os seguintes comandos:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

No FreeBSD, instale o *The Fuck* com os seguintes comandos:
```bash
pkg install thefuck
```

No ChromeOS, instale o *The Fuck* usando o [chromebrew](https://github.com/skycocker/chromebrew) com o seguinte comando:
```bash
crew install thefuck
```

Em sistemas baseados em Arch, instale o *The Fuck* com o seguinte comando:
```
sudo pacman -S thefuck
```

Em outros sistemas, instale o *The Fuck* usando o `pip`:

```bash
pip install thefuck
```

[Alternativamente, você pode usar um gerenciador de pacotes do sistema operacional (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
É recomendado que você coloque este comando no seu `.bash_profile`,
`.bashrc`, `.zshrc` ou outro script de inicialização:

```bash
eval $(thefuck --alias)
# Você pode usar qualquer alias que quiser, por exemplo para as segundas-feiras:
eval $(thefuck --alias FUCK)
```

[Ou em sua configuração de shell (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

As alterações só estarão disponíveis em uma nova sessão do shell. Para aplicar imediatamente, execute `source ~/.bashrc` (ou seu arquivo de configuração de shell, como `.zshrc`).

Para executar comandos corrigidos sem confirmação, use a opção `--yeah` (ou apenas `-y` para abreviar, ou `--hard` se estiver especialmente frustrado):

```bash
fuck --yeah
```

Para corrigir comandos recursivamente até obter sucesso, use a opção `-r`:

```bash
fuck -r
```

##### [Voltar ao Conteúdo](#contents)

## Atualização

```bash
pip3 install thefuck --upgrade
```

**Nota: A funcionalidade de alias mudou na versão v1.34 do *The Fuck***

## Desinstalação

Para remover o *The Fuck*, reverta o processo de instalação:
- apague ou comente a linha do alias *thefuck* do seu Bash, Zsh, Fish, Powershell, tcsh, ... configuração do shell
- use seu gerenciador de pacotes (brew, pip3, pkg, crew, pip) para desinstalar os binários

## Como funciona

*The Fuck* tenta corresponder o comando anterior com uma regra. Se for encontrada uma correspondência, um novo comando é criado usando a regra correspondente e executado. As seguintes regras estão habilitadas por padrão:

* `adb_unknown_command` &ndash; corrige comandos digitados incorretamente como `adb logcta`;
* `ag_literal` &ndash; adiciona `-Q` ao `ag` quando sugerido;
* `aws_cli` &ndash; corrige comandos digitados incorretamente como `aws dynamdb scan`;
* `az_cli` &ndash; corrige comandos digitados incorretamente como `az providers`;
* `cargo` &ndash; executa `cargo build` em vez de `cargo`;
* `cargo_no_command` &ndash; corrige comandos errados como `cargo buid`;
* `cat_dir` &ndash; substitui `cat` por `ls` quando você tenta dar `cat` em um diretório;
* `cd_correction` &ndash; verifica ortografia e corrige comandos `cd` que falharam;
* `cd_cs` &ndash; muda `cs` para `cd`;
* `cd_mkdir` &ndash; cria diretórios antes de entrar neles com cd;
* `cd_parent` &ndash; muda `cd..` para `cd ..`;
* `chmod_x` &ndash; adiciona permissão de execução;
* `choco_install` &ndash; adiciona sufixos comuns para pacotes chocolatey;
* `composer_not_command` &ndash; corrige nome de comando do composer;
* `conda_mistype` &ndash; corrige comandos do conda;
* `cp_create_destination` &ndash; cria um novo diretório quando você tenta `cp` ou `mv` para um que não existe
* `cp_omitting_directory` &ndash; adiciona `-a` quando você tenta `cp` em um diretório;
* `cpp11` &ndash; adiciona o `-std=c++11` ausente ao `g++` ou `clang++`;
* `dirty_untar` &ndash; corrige comando `tar x` que extraiu na pasta atual;
* `dirty_unzip` &ndash; corrige comando `unzip` que descompactou na pasta atual;
* `django_south_ghost` &ndash; adiciona `--delete-ghost-migrations` para falhas por migração ghost do django south;
* `django_south_merge` &ndash; adiciona `--merge` para migração inconsistente do django south;
* `docker_login` &ndash; executa um `docker login` e repete o comando anterior;
* `docker_not_command` &ndash; corrige comandos errados do docker como `docker tags`;
* `docker_image_being_used_by_container` &dash; remove o container que está usando a imagem antes de remover a imagem;
* `dry` &ndash; corrige repetições como `git git push`;
* `fab_command_not_found` &ndash; corrige comandos digitados incorretamente do fabric;
* `fix_alt_space` &ndash; substitui Alt+Espaço por espaço;
* `fix_file` &ndash; abre um arquivo com erro no seu `$EDITOR`;
* `gem_unknown_command` &ndash; corrige comandos errados do `gem`;
* `git_add` &ndash; corrige *"pathspec 'foo' did not match any file(s) known to git."*;
* `git_add_force` &ndash; adiciona `--force` ao `git add <pathspec>...` quando caminhos estão no .gitignore;
* `git_bisect_usage` &ndash; corrige `git bisect strt`, `git bisect goood`, `git bisect rset`, etc. durante bisect;
* `git_branch_delete` &ndash; muda `git branch -d` para `git branch -D`;
* `git_branch_delete_checked_out` &ndash; muda `git branch -d` para `git checkout master && git branch -D` ao tentar deletar um branch em uso;
* `git_branch_exists` &ndash; sugere `git branch -d foo`, `git branch -D foo` ou `git checkout foo` ao criar um branch já existente;
* `git_branch_list` &ndash; captura `git branch list` no lugar de `git branch` e remove o branch criado;
* `git_branch_0flag` &ndash; corrige comandos como `git branch 0v` e `git branch 0r` removendo o branch criado;
* `git_checkout` &ndash; corrige nome do branch ou cria novo branch;
* `git_clone_git_clone` &ndash; substitui `git clone git clone ...` por `git clone ...`
* `git_clone_missing` &ndash; adiciona `git clone` a URLs que parecem apontar para um repositório git.
* `git_commit_add` &ndash; sugere `git commit -a ...` ou `git commit -p ...` após commit anterior se falhou por nada ter sido preparado;
* `git_commit_amend` &ndash; sugere `git commit --amend` após commit anterior;
* `git_commit_reset` &ndash; sugere `git reset HEAD~` após commit anterior;
* `git_diff_no_index` &ndash; adiciona `--no-index` ao `git diff` anterior em arquivos não rastreados;
* `git_diff_staged` &ndash; adiciona `--staged` ao `git diff` anterior com saída inesperada;
* `git_fix_stash` &ndash; corrige comandos `git stash` (subcomando digitado incorretamente e ausência de `save`);
* `git_flag_after_filename` &ndash; corrige `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; corrige comandos `git help <alias>` substituindo <alias> pelo comando real;
* `git_hook_bypass` &ndash; adiciona flag `--no-verify` antes de `git am`, `git commit` ou `git push`;
* `git_lfs_mistype` &ndash; corrige comandos `git lfs <command>` digitados incorretamente;
* `git_main_master` &ndash; corrige nome de branch incorreto entre `main` e `master`
* `git_merge` &ndash; adiciona remoto aos nomes de branch;
* `git_merge_unrelated` &ndash; adiciona `--allow-unrelated-histories` quando necessário
* `git_not_command` &ndash; corrige comandos errados do git como `git brnch`;
* `git_pull` &ndash; define upstream antes de executar `git pull` anterior;
* `git_pull_clone` &ndash; faz clone ao invés de pull quando o repo não existe;
* `git_pull_uncommitted_changes` &ndash; faz stash das alterações antes do pull e restaura depois;
* `git_push` &ndash; adiciona `--set-upstream origin $branch` ao `git push` anterior que falhou;
* `git_push_different_branch_names` &ndash; corrige push quando o nome do branch local não corresponde ao do remoto;
* `git_push_pull` &ndash; executa `git pull` quando o push foi rejeitado;
* `git_push_without_commits` &ndash; cria um commit inicial se você esquecer e apenas fizer `git add .` ao configurar um novo projeto;
* `git_rebase_no_changes` &ndash; executa `git rebase --skip` ao invés de `git rebase --continue` quando não há alterações;
* `git_remote_delete` &ndash; substitui `git remote delete remote_name` por `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; adiciona `-f` ou `--cached` ao tentar `rm` um arquivo modificado localmente;
* `git_rm_recursive` &ndash; adiciona `-r` ao tentar `rm` um diretório;
* `git_rm_staged` &ndash; adiciona `-f` ou `--cached` ao tentar `rm` um arquivo com alterações staged
* `git_rebase_merge_dir` &ndash; sugere `git rebase (--continue | --abort | --skip)` ou remover o dir `.git/rebase-merge` quando um rebase está em andamento;
* `git_remote_seturl_add` &ndash; executa `git remote add` ao usar `git remote set_url` em um remoto inexistente;
* `git_stash` &ndash; faz stash das modificações locais antes de rebase ou troca de branch;
* `git_stash_pop` &ndash; adiciona suas modificações locais antes de aplicar o stash, depois faz reset;
* `git_tag_force` &ndash; adiciona `--force` ao `git tag <tagname>` quando a tag já existe;
* `git_two_dashes` &ndash; adiciona um traço ausente a comandos como `git commit -amend` ou `git rebase -continue`;
* `go_run` &ndash; adiciona extensão `.go` ao compilar/executar programas Go;
* `go_unknown_command` &ndash; corrige comandos errados do `go`, por exemplo `go bulid`;
* `gradle_no_task` &ndash; corrige task não encontrada ou ambígua do `gradle`;
* `gradle_wrapper` &ndash; substitui `gradle` por `./gradlew`;
* `grep_arguments_order` &ndash; corrige ordem de argumentos do `grep` para situações como `grep -lir . test`;
* `grep_recursive` &ndash; adiciona `-r` ao tentar `grep` em diretório;
* `grunt_task_not_found` &ndash; corrige comandos `grunt` digitados incorretamente;
* `gulp_not_task` &ndash; corrige tasks `gulp` digitadas incorretamente;
* `has_exists_script` &ndash; adiciona `./` quando script/binário existe;
* `heroku_multiple_apps` &ndash; adiciona `--app <app>` aos comandos `heroku` como `heroku pg`;
* `heroku_not_command` &ndash; corrige comandos errados do `heroku` como `heroku log`;
* `history` &ndash; tenta substituir comando pelo mais similar do histórico;
* `hostscli` &ndash; tenta corrigir uso do `hostscli`;
* `ifconfig_device_not_found` &ndash; corrige nomes de dispositivos errados como `wlan0` para `wlp2s0`;
* `java` &ndash; remove extensão `.java` ao executar programas Java;
* `javac` &ndash; adiciona `.java` ausente ao compilar arquivos Java;
* `lein_not_task` &ndash; corrige tasks erradas do `lein` como `lein rpl`;
* `long_form_help` &ndash; muda `-h` para `--help` quando a versão curta não é suportada
* `ln_no_hard_link` &ndash; captura criação de hard link em diretórios, sugere link simbólico;
* `ln_s_order` &ndash; corrige ordem dos argumentos do `ln -s`;
* `ls_all` &ndash; adiciona `-A` ao `ls` quando a saída está vazia;
* `ls_lah` &ndash; adiciona `-lah` ao `ls`;
* `man` &ndash; muda seção do manual;
* `man_no_space` &ndash; corrige comandos man sem espaços, por exemplo `mandiff`;
* `mercurial` &ndash; corrige comandos errados do `hg`;
* `missing_space_before_subcommand` &ndash; corrige comando sem espaço como `npminstall`;
* `mkdir_p` &ndash; adiciona `-p` ao tentar criar diretório sem pai;
* `mvn_no_command` &ndash; adiciona `clean package` ao `mvn`;
* `mvn_unknown_lifecycle_phase` &ndash; corrige estágios do ciclo de vida digitados incorretamente no `mvn`;
* `npm_missing_script` &ndash; corrige nome de script customizado em `npm run-script <script>`;
* `npm_run_script` &ndash; adiciona `run-script` ausente para scripts customizados do `npm`;
* `npm_wrong_command` &ndash; corrige comandos errados do npm como `npm urgrade`;
* `no_command` &ndash; corrige comandos de console errados, por exemplo `vom/vim`;
* `no_such_file` &ndash; cria diretórios ausentes com comandos `mv` e `cp`;
* `omnienv_no_such_command` &ndash; corrige comandos errados para `goenv`, `nodenv`, `pyenv` e `rbenv` (ex.: `pyenv isntall` ou `goenv list`);
* `open` &ndash; adiciona `http://` ao endereço passado para `open` ou cria um novo arquivo ou diretório e o passa para `open`;
* `pip_install` &ndash; corrige problemas de permissão com `pip install` adicionando `--user` ou antecedendo `sudo` se necessário;
* `pip_unknown_command` &ndash; corrige comandos errados do `pip`, por exemplo `pip instatl/pip install`;
* `php_s` &ndash; substitui `-s` por `-S` ao tentar rodar um servidor local php;
* `port_already_in_use` &ndash; mata processo que está usando a porta;
* `prove_recursively` &ndash; adiciona `-r` ao ser chamado com diretório;
* `python_command` &ndash; adiciona `python` ao tentar rodar script python não executável/sem `./`;
* `python_execute` &ndash; adiciona `.py` ausente ao executar arquivos Python;
* `python_module_error` &ndash; corrige ModuleNotFoundError tentando `pip install` do módulo;
* `quotation_marks` &ndash; corrige uso desigual de `'` e `"` nos argumentos;
* `path_from_history` &ndash; substitui caminho não encontrado por um semelhante absoluto do histórico;
* `rails_migrations_pending` &ndash; executa migrações pendentes;
* `react_native_command_unrecognized` &ndash; corrige comandos não reconhecidos do `react-native`;
* `remove_shell_prompt_literal` &ndash; remove símbolo do prompt `$` ao copiar comandos de documentações;
* `remove_trailing_cedilla` &ndash; remove cedilhas finais `ç`, um erro comum em teclados europeus;
* `rm_dir` &ndash; adiciona `-rf` ao tentar remover um diretório;
* `scm_correction` &ndash; corrige scm errados como `hg log` para `git log`;
* `sed_unterminated_s` &ndash; adiciona '/' ausente aos comandos `s` do `sed`;
* `sl_ls` &ndash; muda `sl` para `ls`;
* `ssh_known_hosts` &ndash; remove host de `known_hosts` ao receber aviso;
* `sudo` &ndash; adiciona `sudo` ao comando anterior se ele falhou por permissão;
* `sudo_command_from_user_path` &ndash; executa comandos do `$PATH` do usuário com `sudo`;
* `switch_lang` &ndash; troca comando do layout local para en;
* `systemctl` &ndash; ordena corretamente parâmetros confusos do `systemctl`;
* `terraform_init.py` &ndash; executa `terraform init` antes de plan ou apply;
* `terraform_no_command.py` &ndash; corrige comandos não reconhecidos do `terraform`;
* `test.py` &ndash; executa `pytest` em vez de `test.py`;
* `touch` &ndash; cria diretórios ausentes antes de "tocar" o arquivo;
* `tsuru_login` &ndash; executa `tsuru login` se não autenticado ou sessão expirada;
* `tsuru_not_command` &ndash; corrige comandos errados do `tsuru` como `tsuru shell`;
* `tmux` &ndash; corrige comandos do `tmux`;
* `unknown_command` &ndash; corrige comandos desconhecidos no estilo hadoop hdfs, por exemplo adiciona '-' ausente no comando `hdfs dfs ls`;
* `unsudo` &ndash; remove `sudo` do comando anterior se o processo recusar rodar como superusuário.
* `vagrant_up` &ndash; inicia a instância vagrant;
* `whois` &ndash; corrige comando `whois`;
* `workon_doesnt_exists` &ndash; corrige nome do env do `virtualenvwrapper` ou sugere criar novo.
* `wrong_hyphen_before_subcommand` &ndash; remove hífen indevido (`apt-install` -> `apt install`, `git-log` -> `git log`, etc.)
* `yarn_alias` &ndash; corrige comandos alias do `yarn` como `yarn ls`;
* `yarn_command_not_found` &ndash; corrige comandos digitados incorretamente do `yarn`;
* `yarn_command_replaced` &ndash; corrige comandos substituídos do `yarn`;
* `yarn_help` &ndash; facilita abrir a documentação do `yarn`;

##### [Voltar ao Conteúdo](#contents)

As seguintes regras estão habilitadas por padrão apenas em plataformas específicas:

* `apt_get` &ndash; instala app via apt se não estiver instalado (requer `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; muda pesquisa via `apt-get` para pesquisa via `apt-cache`;
* `apt_invalid_operation` &ndash; corrige chamadas inválidas de `apt` e `apt-get`, como `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; ajuda você a rodar `apt list --upgradable` após `apt update`;
* `apt_upgrade` &ndash; ajuda você a rodar `apt upgrade` após `apt list --upgradable`;
* `brew_cask_dependency` &ndash; instala dependências cask;
* `brew_install` &ndash; corrige nome da fórmula para `brew install`;
* `brew_reinstall` &ndash; transforma `brew install <formula>` em `brew reinstall <formula>`;
* `brew_link` &ndash; adiciona `--overwrite --dry-run` se o link falhar;
* `brew_uninstall` &ndash; adiciona `--force` ao `brew uninstall` se múltiplas versões estiverem instaladas;
* `brew_unknown_command` &ndash; corrige comandos errados do brew, por exemplo `brew docto/brew doctor`;
* `brew_update_formula` &ndash; transforma `brew update <formula>` em `brew upgrade <formula>`;
* `dnf_no_such_command` &ndash; corrige comandos DNF digitados incorretamente;
* `nixos_cmd_not_found` &ndash; instala apps no NixOS;
* `pacman` &ndash; instala app com `pacman` se não estiver instalado (usa `yay`, `pikaur` ou `yaourt` se disponível);
* `pacman_invalid_option` &ndash; substitui opções minúsculas do `pacman` por maiúsculas.
* `pacman_not_found` &ndash; corrige nome do pacote com `pacman`, `yay`, `pikaur` ou `yaourt`.
* `yum_invalid_operation` &ndash; corrige chamadas inválidas do `yum`, como `yum isntall vim`;

Os seguintes comandos são fornecidos com o *The Fuck*, mas não estão habilitados por padrão:

* `git_push_force` &ndash; adiciona `--force-with-lease` a um `git push` (pode conflitar com `git_push_pull`);
* `rm_root` &ndash; adiciona `--no-preserve-root` ao comando `rm -rf /`.

##### [Voltar ao Conteúdo](#contents)

## Criando suas próprias regras

Para adicionar sua própria regra, crie um arquivo chamado `seu-nome-de-regra.py`
em `~/.config/thefuck/rules`. O arquivo de regra deve conter duas funções:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Adicionalmente, regras podem conter funções opcionais:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Regras também podem conter as variáveis opcionais `enabled_by_default`, `requires_output` e `priority`.

`Command` tem três atributos: `script`, `output` e `script_parts`.
Sua regra não deve alterar `Command`.

**A API de regras mudou na 3.0:** Para acessar as configurações de uma regra, importe com
`from thefuck.conf import settings`

`settings` é um objeto especial montado a partir de `~/.config/thefuck/settings.py`,
e valores de env ([veja mais abaixo](#settings)).

Um exemplo simples de regra para rodar um script com `sudo`:

```python
def match(command):
    return ('permission denied' in command.output.lower()
            or 'EACCES' in command.output)


def get_new_command(command):
    return 'sudo {}'.format(command.script)

# Opcional:
enabled_by_default = True

def side_effect(command, fixed_command):
    subprocess.call('chmod 777 .', shell=True)

priority = 1000  # Menor primeiro, padrão é 1000

requires_output = True
```

[Mais exemplos de regras](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[funções utilitárias para regras](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[ajudantes específicos para app/sistema operacional](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Voltar ao Conteúdo](#contents)

## Configurações

Vários parâmetros do *The Fuck* podem ser alterados no arquivo `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` padrão é `~/.config`):

* `rules` &ndash; lista de regras habilitadas, padrão `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; lista de regras desabilitadas, padrão `[]`;
* `require_confirmation` &ndash; requer confirmação antes de rodar o novo comando, padrão `True`;
* `wait_command` &ndash; tempo máximo em segundos para obter a saída do comando anterior;
* `no_colors` &ndash; desabilita saída colorida;
* `priority` &ndash; dicionário com prioridades das regras, regra com menor `priority` será correspondida primeiro;
* `debug` &ndash; habilita saída de depuração, padrão `False`;
* `history_limit` &ndash; valor numérico de quantos comandos do histórico serão analisados, como `2000`;
* `alter_history` &ndash; envia comando corrigido para o histórico, padrão `True`;
* `wait_slow_command` &ndash; tempo máximo em segundos para obter saída do comando anterior caso esteja na lista `slow_commands`;
* `slow_commands` &ndash; lista de comandos lentos;
* `num_close_matches` &ndash; número máximo de sugestões de comandos próximos, padrão `3`.
* `excluded_search_path_prefixes` &ndash; prefixos de caminho para ignorar ao procurar comandos, padrão `[]`.

Um exemplo de `settings.py`:

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

Ou via variáveis de ambiente:

* `THEFUCK_RULES` &ndash; lista de regras habilitadas, como `DEFAULT_RULES:rm_root` ou `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; lista de regras desabilitadas, como `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; requer confirmação antes de rodar novo comando, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; tempo máximo em segundos para obter a saída do comando anterior;
* `THEFUCK_NO_COLORS` &ndash; desabilita saída colorida, `true/false`;
* `THEFUCK_PRIORITY` &ndash; prioridade das regras, como `no_command=9999:apt_get=100`,
regra com menor `priority` será correspondida primeiro;
* `THEFUCK_DEBUG` &ndash; habilita saída de depuração, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; quantos comandos do histórico serão analisados, como `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; envia comando corrigido para o histórico `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; tempo máximo em segundos para obter a saída do comando anterior caso esteja em `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` &ndash; lista de comandos lentos, como `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; número máximo de sugestões de comandos próximos, como `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; prefixos de caminho para ignorar ao procurar comandos, padrão `[]`.

Por exemplo:

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

##### [Voltar ao Conteúdo](#contents)

## Pacotes de terceiros com regras

Se você quiser criar um conjunto específico de regras não públicas, mas ainda assim compartilhá-las com outros, crie um pacote chamado `thefuck_contrib_*` com a seguinte estrutura:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *regras de terceiros*
    __init__.py
    *utils de terceiros*
  setup.py
```

*The Fuck* encontrará regras localizadas no módulo `rules`.

##### [Voltar ao Conteúdo](#contents)

## Modo instantâneo experimental

O comportamento padrão do *The Fuck* requer tempo para reexecutar comandos anteriores.
No modo instantâneo, *The Fuck* economiza tempo registrando a saída com o [script](https://en.wikipedia.org/wiki/Script_(Unix)),
e então lendo o log.

[![gif com modo instantâneo][instant-mode-gif-link]][instant-mode-gif-link]

Atualmente, o modo instantâneo só suporta Python 3 com bash ou zsh. A função de autocorreção do zsh também precisa ser desativada para que o thefuck funcione corretamente.

Para ativar o modo instantâneo, adicione `--enable-experimental-instant-mode`
à inicialização do alias em `.bashrc`, `.bash_profile` ou `.zshrc`.

Por exemplo:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Voltar ao Conteúdo](#contents)

## Desenvolvimento

Veja [CONTRIBUTING.md](CONTRIBUTING.md)

## Licença MIT
A licença do projeto pode ser encontrada [aqui](LICENSE.md).


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

##### [Voltar ao Conteúdo](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---