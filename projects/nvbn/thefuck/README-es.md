# The Fuck [![Versión][version-badge]][version-link] [![Estado de compilación][workflow-badge]][workflow-link] [![Cobertura][coverage-badge]][coverage-link] [![Licencia MIT][license-badge]](LICENSE.md)

*The Fuck* es una aplicación magnífica, inspirada por un [tweet de @liamosaur](https://twitter.com/liamosaur/status/506975850596536320), que corrige errores en comandos anteriores de la consola.

¿*The Fuck* es demasiado lento? [¡Prueba el modo instantáneo experimental!](#experimental-instant-mode)

[![gif con ejemplos][examples-link]][examples-link]

Más ejemplos:

```bash
➜ apt-get install vim
E: No se pudo abrir el archivo de bloqueo /var/lib/dpkg/lock - open (13: Permiso denegado)
E: No se pudo bloquear el directorio de administración (/var/lib/dpkg/), ¿eres root?

➜ fuck
sudo apt-get install vim [enter/↑/↓/ctrl+c]
[sudo] contraseña para nvbn:
Leyendo listas de paquetes... Hecho
...
```

```bash
➜ git push
fatal: La rama actual master no tiene una rama upstream.
Para enviar la rama actual y establecer el remoto como upstream, usa

    git push --set-upstream origin master

➜ fuck
git push --set-upstream origin master [enter/↑/↓/ctrl+c]
Contando objetos: 9, hecho.
...
```

```bash
➜ puthon
No se encontró el comando 'puthon', ¿quiso decir:
 Comando 'python' del paquete 'python-minimal' (main)
 Comando 'python' del paquete 'python3' (main)
zsh: comando no encontrado: puthon

➜ fuck
python [enter/↑/↓/ctrl+c]
Python 3.4.2 (por defecto, Oct  8 2014, 13:08:17)
...
```

```bash
➜ git brnch
git: 'brnch' no es un comando git. Ver 'git --help'.

¿Quiso decir esto?
    branch

➜ fuck
git branch [enter/↑/↓/ctrl+c]
* master
```

```bash
➜ lein rpl
'rpl' no es una tarea. Ver 'lein help'.

¿Quiso decir esto?
         repl

➜ fuck
lein repl [enter/↑/↓/ctrl+c]
Servidor nREPL iniciado en el puerto 54848 en el host 127.0.0.1 - nrepl://127.0.0.1:54848
REPL-y 0.3.1
...
```

Si no tienes miedo de ejecutar comandos corregidos a ciegas, la opción `require_confirmation` en [configuración](#settings) puede ser deshabilitada:

```bash
➜ apt-get install vim
E: No se pudo abrir el archivo de bloqueo /var/lib/dpkg/lock - open (13: Permiso denegado)
E: No se pudo bloquear el directorio de administración (/var/lib/dpkg/), ¿eres root?

➜ fuck
sudo apt-get install vim
[sudo] contraseña para nvbn:
Leyendo listas de paquetes... Hecho
...
```

## Contenido

1. [Requisitos](#requirements)
2. [Instalación](#installation)
3. [Actualización](#updating)
4. [Cómo funciona](#how-it-works)
5. [Crear tus propias reglas](#creating-your-own-rules)
6. [Configuración](#settings)
7. [Paquetes de terceros con reglas](#third-party-packages-with-rules)
8. [Modo instantáneo experimental](#experimental-instant-mode)
9. [Desarrollo](#developing)
10. [Licencia](#license-mit)

## Requisitos

- python (3.5+)
- pip
- python-dev

##### [Volver al Contenido](#contents)

## Instalación

En macOS o Linux, puedes instalar *The Fuck* vía [Homebrew][homebrew]:

```bash
brew install thefuck
```

En Ubuntu / Mint, instala *The Fuck* con los siguientes comandos:
```bash
sudo apt update
sudo apt install python3-dev python3-pip python3-setuptools
pip3 install thefuck --user
```

En FreeBSD, instala *The Fuck* con los siguientes comandos:
```bash
pkg install thefuck
```

En ChromeOS, instala *The Fuck* usando [chromebrew](https://github.com/skycocker/chromebrew) con el siguiente comando:
```bash
crew install thefuck
```

En sistemas basados en Arch, instala *The Fuck* con el siguiente comando:
```
sudo pacman -S thefuck
```

En otros sistemas, instala *The Fuck* usando `pip`:

```bash
pip install thefuck
```

[Alternativamente, puedes usar un gestor de paquetes del SO (OS X, Ubuntu, Arch).](https://github.com/nvbn/thefuck/wiki/Installation)

<a href='#manual-installation' name='manual-installation'>#</a>
Se recomienda que coloques este comando en tu `.bash_profile`, `.bashrc`, `.zshrc` u otro script de inicio:

```bash
eval $(thefuck --alias)
# Puedes usar el alias que quieras, por ejemplo para los lunes:
eval $(thefuck --alias FUCK)
```

[O en la configuración de tu shell (Bash, Zsh, Fish, Powershell, tcsh).](https://github.com/nvbn/thefuck/wiki/Shell-aliases)

Los cambios solo estarán disponibles en una nueva sesión de shell. Para hacer los cambios disponibles inmediatamente, ejecuta `source ~/.bashrc` (o el archivo de configuración de tu shell como `.zshrc`).

Para ejecutar comandos corregidos sin confirmación, usa la opción `--yeah` (o simplemente `-y` para abreviar, o `--hard` si estás especialmente frustrado):

```bash
fuck --yeah
```

Para corregir comandos recursivamente hasta tener éxito, usa la opción `-r`:

```bash
fuck -r
```

##### [Volver al Contenido](#contents)

## Actualización

```bash
pip3 install thefuck --upgrade
```

**Nota: La funcionalidad de alias cambió en la versión 1.34 de *The Fuck***

## Desinstalación

Para eliminar *The Fuck*, revierte el proceso de instalación:
- borra o comenta la línea del alias *thefuck* de la configuración de tu shell Bash, Zsh, Fish, Powershell, tcsh, ...
- utiliza tu gestor de paquetes (brew, pip3, pkg, crew, pip) para desinstalar los binarios

## Cómo funciona

*The Fuck* intenta hacer coincidir el comando anterior con una regla. Si encuentra una coincidencia, crea un nuevo comando usando la regla coincidente y lo ejecuta. Las siguientes reglas están habilitadas por defecto:

* `adb_unknown_command` &ndash; corrige comandos mal escritos como `adb logcta`;
* `ag_literal` &ndash; añade `-Q` a `ag` cuando se sugiere;
* `aws_cli` &ndash; corrige comandos mal escritos como `aws dynamdb scan`;
* `az_cli` &ndash; corrige comandos mal escritos como `az providers`;
* `cargo` &ndash; ejecuta `cargo build` en lugar de `cargo`;
* `cargo_no_command` &ndash; corrige comandos erróneos como `cargo buid`;
* `cat_dir` &ndash; reemplaza `cat` por `ls` cuando intentas `cat` en un directorio;
* `cd_correction` &ndash; revisa y corrige comandos cd fallidos;
* `cd_cs` &ndash; cambia `cs` por `cd`;
* `cd_mkdir` &ndash; crea directorios antes de entrar con cd;
* `cd_parent` &ndash; cambia `cd..` por `cd ..`;
* `chmod_x` &ndash; añade el bit de ejecución;
* `choco_install` &ndash; añade sufijos comunes para paquetes de chocolatey;
* `composer_not_command` &ndash; corrige el nombre del comando de composer;
* `conda_mistype` &ndash; corrige comandos de conda;
* `cp_create_destination` &ndash; crea un nuevo directorio cuando intentas `cp` o `mv` a uno inexistente;
* `cp_omitting_directory` &ndash; añade `-a` cuando haces `cp` a un directorio;
* `cpp11` &ndash; añade el faltante `-std=c++11` a `g++` o `clang++`;
* `dirty_untar` &ndash; corrige el comando `tar x` que descomprime en el directorio actual;
* `dirty_unzip` &ndash; corrige el comando `unzip` que descomprime en el directorio actual;
* `django_south_ghost` &ndash; añade `--delete-ghost-migrations` a migraciones fantasma fallidas de django south;
* `django_south_merge` &ndash; añade `--merge` a migraciones inconsistentes de django south;
* `docker_login` &ndash; ejecuta un `docker login` y repite el comando anterior;
* `docker_not_command` &ndash; corrige comandos erróneos de docker como `docker tags`;
* `docker_image_being_used_by_container` &ndash; elimina el contenedor que está usando la imagen antes de eliminar la imagen;
* `dry` &ndash; corrige repeticiones como `git git push`;
* `fab_command_not_found` &ndash; corrige comandos mal escritos de fabric;
* `fix_alt_space` &ndash; reemplaza Alt+Espacio por un espacio;
* `fix_file` &ndash; abre un archivo con error en tu `$EDITOR`;
* `gem_unknown_command` &ndash; corrige comandos erróneos de `gem`;
* `git_add` &ndash; corrige *"pathspec 'foo' no coincide con ningún archivo conocido por git."*;
* `git_add_force` &ndash; añade `--force` a `git add <pathspec>...` cuando las rutas están en .gitignore;
* `git_bisect_usage` &ndash; corrige `git bisect strt`, `git bisect goood`, `git bisect rset`, etc. durante bisect;
* `git_branch_delete` &ndash; cambia `git branch -d` por `git branch -D`;
* `git_branch_delete_checked_out` &ndash; cambia `git branch -d` por `git checkout master && git branch -D` al intentar borrar una rama activa;
* `git_branch_exists` &ndash; sugiere `git branch -d foo`, `git branch -D foo` o `git checkout foo` cuando se crea una rama que ya existe;
* `git_branch_list` &ndash; detecta `git branch list` en lugar de `git branch` y elimina la rama creada;
* `git_branch_0flag` &ndash; corrige comandos como `git branch 0v` y `git branch 0r` eliminando la rama creada;
* `git_checkout` &ndash; corrige el nombre de la rama o crea una nueva rama;
* `git_clone_git_clone` &ndash; reemplaza `git clone git clone ...` por `git clone ...`
* `git_clone_missing` &ndash; añade `git clone` a URLs que parecen enlazar a un repositorio git.
* `git_commit_add` &ndash; sugiere `git commit -a ...` o `git commit -p ...` después de un commit fallido por no haber archivos en stage;
* `git_commit_amend` &ndash; sugiere `git commit --amend` después de un commit anterior;
* `git_commit_reset` &ndash; sugiere `git reset HEAD~` después de un commit anterior;
* `git_diff_no_index` &ndash; añade `--no-index` al `git diff` anterior en archivos no rastreados;
* `git_diff_staged` &ndash; añade `--staged` al `git diff` anterior con salida inesperada;
* `git_fix_stash` &ndash; corrige comandos `git stash` (subcomando mal escrito o falta `save`);
* `git_flag_after_filename` &ndash; corrige `fatal: bad flag '...' after filename`
* `git_help_aliased` &ndash; corrige comandos `git help <alias>` reemplazando <alias> por el comando alias;
* `git_hook_bypass` &ndash; añade `--no-verify` antes de `git am`, `git commit` o `git push`;
* `git_lfs_mistype` &ndash; corrige comandos mal escritos de `git lfs <command>`;
* `git_main_master` &ndash; corrige nombre de rama incorrecto entre `main` y `master`
* `git_merge` &ndash; añade remoto a nombres de rama;
* `git_merge_unrelated` &ndash; añade `--allow-unrelated-histories` cuando es necesario;
* `git_not_command` &ndash; corrige comandos erróneos de git como `git brnch`;
* `git_pull` &ndash; establece upstream antes de ejecutar `git pull` anterior;
* `git_pull_clone` &ndash; clona en lugar de hacer pull cuando el repo no existe;
* `git_pull_uncommitted_changes` &ndash; guarda cambios antes de hacer pull y los restaura después;
* `git_push` &ndash; añade `--set-upstream origin $branch` al `git push` fallido;
* `git_push_different_branch_names` &ndash; corrige push cuando el nombre de la rama local no coincide con el remoto;
* `git_push_pull` &ndash; ejecuta `git pull` cuando el push fue rechazado;
* `git_push_without_commits` &ndash; crea un commit inicial si olvidaste y solo hiciste `git add .` al crear un nuevo proyecto;
* `git_rebase_no_changes` &ndash; ejecuta `git rebase --skip` en lugar de `git rebase --continue` cuando no hay cambios;
* `git_remote_delete` &ndash; reemplaza `git remote delete remote_name` por `git remote remove remote_name`;
* `git_rm_local_modifications` &ndash; añade `-f` o `--cached` cuando intentas `rm` un archivo modificado localmente;
* `git_rm_recursive` &ndash; añade `-r` cuando intentas `rm` un directorio;
* `git_rm_staged` &ndash; añade `-f` o `--cached` cuando intentas `rm` un archivo con cambios en stage;
* `git_rebase_merge_dir` &ndash; sugiere `git rebase (--continue | --abort | --skip)` o eliminar el directorio `.git/rebase-merge` cuando hay un rebase en progreso;
* `git_remote_seturl_add` &ndash; ejecuta `git remote add` cuando haces `git remote set_url` sobre un remoto inexistente;
* `git_stash` &ndash; guarda tus modificaciones locales antes de rebasear o cambiar de rama;
* `git_stash_pop` &ndash; añade tus modificaciones locales antes de aplicar stash, luego restablece;
* `git_tag_force` &ndash; añade `--force` a `git tag <tagname>` cuando la etiqueta ya existe;
* `git_two_dashes` &ndash; añade un guion faltante a comandos como `git commit -amend` o `git rebase -continue`;
* `go_run` &ndash; añade la extensión `.go` al compilar/ejecutar programas Go;
* `go_unknown_command` &ndash; corrige comandos erróneos de `go`, por ejemplo `go bulid`;
* `gradle_no_task` &ndash; corrige tareas de `gradle` no encontradas o ambiguas;
* `gradle_wrapper` &ndash; reemplaza `gradle` por `./gradlew`;
* `grep_arguments_order` &ndash; corrige el orden de argumentos de `grep` para situaciones como `grep -lir . test`;
* `grep_recursive` &ndash; añade `-r` cuando intentas `grep` en un directorio;
* `grunt_task_not_found` &ndash; corrige comandos mal escritos de `grunt`;
* `gulp_not_task` &ndash; corrige tareas mal escritas de `gulp`;
* `has_exists_script` &ndash; antepone `./` cuando el script/binario existe;
* `heroku_multiple_apps` &ndash; añade `--app <app>` a comandos de `heroku` como `heroku pg`;
* `heroku_not_command` &ndash; corrige comandos erróneos de `heroku` como `heroku log`;
* `history` &ndash; intenta reemplazar el comando con el más similar del historial;
* `hostscli` &ndash; intenta corregir el uso de `hostscli`;
* `ifconfig_device_not_found` &ndash; corrige nombres de dispositivos erróneos como `wlan0` a `wlp2s0`;
* `java` &ndash; elimina la extensión `.java` al ejecutar programas Java;
* `javac` &ndash; añade la extensión `.java` faltante al compilar archivos Java;
* `lein_not_task` &ndash; corrige tareas erróneas de `lein` como `lein rpl`;
* `long_form_help` &ndash; cambia `-h` por `--help` cuando la versión corta no es soportada;
* `ln_no_hard_link` &ndash; detecta creación de enlaces duros en directorios, sugiere enlace simbólico;
* `ln_s_order` &ndash; corrige el orden de argumentos de `ln -s`;
* `ls_all` &ndash; añade `-A` a `ls` cuando la salida está vacía;
* `ls_lah` &ndash; añade `-lah` a `ls`;
* `man` &ndash; cambia la sección del manual;
* `man_no_space` &ndash; corrige comandos man sin espacio, por ejemplo `mandiff`;
* `mercurial` &ndash; corrige comandos erróneos de `hg`;
* `missing_space_before_subcommand` &ndash; corrige comandos sin espacio, como `npminstall`;
* `mkdir_p` &ndash; añade `-p` cuando intentas crear un directorio sin padre;
* `mvn_no_command` &ndash; añade `clean package` a `mvn`;
* `mvn_unknown_lifecycle_phase` &ndash; corrige fases del ciclo de vida mal escritas con `mvn`;
* `npm_missing_script` &ndash; corrige el nombre del script personalizado en `npm run-script <script>`;
* `npm_run_script` &ndash; añade el `run-script` faltante para scripts personalizados de `npm`;
* `npm_wrong_command` &ndash; corrige comandos erróneos de npm como `npm urgrade`;
* `no_command` &ndash; corrige comandos de consola erróneos, por ejemplo `vom/vim`;
* `no_such_file` &ndash; crea directorios faltantes con comandos `mv` y `cp`;
* `omnienv_no_such_command` &ndash; corrige comandos erróneos para `goenv`, `nodenv`, `pyenv` y `rbenv` (ej.: `pyenv isntall` o `goenv list`);
* `open` &ndash; antepone `http://` a la dirección pasada a `open` o crea un nuevo archivo/directorio y lo pasa a `open`;
* `pip_install` &ndash; corrige problemas de permisos en comandos `pip install` añadiendo `--user` o anteponiendo `sudo` si es necesario;
* `pip_unknown_command` &ndash; corrige comandos erróneos de `pip`, por ejemplo `pip instatl/pip install`;
* `php_s` &ndash; reemplaza `-s` por `-S` al intentar ejecutar un servidor local de php;
* `port_already_in_use` &ndash; mata el proceso que ocupa el puerto;
* `prove_recursively` &ndash; añade `-r` cuando se llama con un directorio;
* `python_command` &ndash; antepone `python` cuando intentas ejecutar un script python sin ejecutar o sin `./`;
* `python_execute` &ndash; añade la extensión `.py` faltante al ejecutar archivos Python;
* `python_module_error` &ndash; corrige ModuleNotFoundError intentando `pip install` ese módulo;
* `quotation_marks` &ndash; corrige uso desigual de `'` y `"` al contener argumentos;
* `path_from_history` &ndash; reemplaza rutas no encontradas por una ruta absoluta similar del historial;
* `rails_migrations_pending` &ndash; ejecuta migraciones pendientes;
* `react_native_command_unrecognized` &ndash; corrige comandos no reconocidos de `react-native`;
* `remove_shell_prompt_literal` &ndash; elimina el símbolo de prompt `$` al inicio, común al copiar comandos de documentación;
* `remove_trailing_cedilla` &ndash; elimina cedillas finales `ç`, un error común en teclados europeos;
* `rm_dir` &ndash; añade `-rf` cuando intentas eliminar un directorio;
* `scm_correction` &ndash; corrige scm erróneos como `hg log` a `git log`;
* `sed_unterminated_s` &ndash; añade '/' faltante a los comandos `s` de `sed`;
* `sl_ls` &ndash; cambia `sl` por `ls`;
* `ssh_known_hosts` &ndash; elimina el host de `known_hosts` en la advertencia;
* `sudo` &ndash; antepone `sudo` al comando anterior si falló por permisos;
* `sudo_command_from_user_path` &ndash; ejecuta comandos desde `$PATH` de usuario con `sudo`;
* `switch_lang` &ndash; cambia el comando de tu disposición local a inglés;
* `systemctl` &ndash; ordena correctamente los parámetros de `systemctl`;
* `terraform_init.py` &ndash; ejecuta `terraform init` antes de plan o apply;
* `terraform_no_command.py` &ndash; corrige comandos de `terraform` no reconocidos;
* `test.py` &ndash; ejecuta `pytest` en lugar de `test.py`;
* `touch` &ndash; crea directorios faltantes antes de "touch";
* `tsuru_login` &ndash; ejecuta `tsuru login` si no está autenticado o la sesión expiró;
* `tsuru_not_command` &ndash; corrige comandos erróneos de `tsuru` como `tsuru shell`;
* `tmux` &ndash; corrige comandos de `tmux`;
* `unknown_command` &ndash; corrige "comando desconocido" estilo hadoop hdfs, por ejemplo, añade '-' faltante al comando en `hdfs dfs ls`;
* `unsudo` &ndash; elimina `sudo` del comando anterior si un proceso se niega a ejecutarse como superusuario.
* `vagrant_up` &ndash; inicia la instancia de vagrant;
* `whois` &ndash; corrige el comando `whois`;
* `workon_doesnt_exists` &ndash; corrige el nombre del entorno de `virtualenvwrapper` o sugiere crear uno nuevo.
* `wrong_hyphen_before_subcommand` &ndash; elimina un guion mal colocado (`apt-install` -> `apt install`, `git-log` -> `git log`, etc.)
* `yarn_alias` &ndash; corrige comandos alias de `yarn` como `yarn ls`;
* `yarn_command_not_found` &ndash; corrige comandos mal escritos de `yarn`;
* `yarn_command_replaced` &ndash; corrige comandos reemplazados de `yarn`;
* `yarn_help` &ndash; facilita abrir la documentación de `yarn`;

##### [Volver al Contenido](#contents)

Las siguientes reglas están habilitadas por defecto solo en plataformas específicas:

* `apt_get` &ndash; instala la aplicación desde apt si no está instalada (requiere `python-commandnotfound` / `python3-commandnotfound`);
* `apt_get_search` &ndash; cambia la búsqueda usando `apt-get` por búsqueda usando `apt-cache`;
* `apt_invalid_operation` &ndash; corrige llamadas inválidas de `apt` y `apt-get`, como `apt-get isntall vim`;
* `apt_list_upgradable` &ndash; te ayuda a ejecutar `apt list --upgradable` después de `apt update`;
* `apt_upgrade` &ndash; te ayuda a ejecutar `apt upgrade` después de `apt list --upgradable`;
* `brew_cask_dependency` &ndash; instala dependencias de cask;
* `brew_install` &ndash; corrige el nombre de la fórmula para `brew install`;
* `brew_reinstall` &ndash; convierte `brew install <fórmula>` en `brew reinstall <fórmula>`;
* `brew_link` &ndash; añade `--overwrite --dry-run` si falla el enlace;
* `brew_uninstall` &ndash; añade `--force` a `brew uninstall` si había múltiples versiones instaladas;
* `brew_unknown_command` &ndash; corrige comandos erróneos de brew, por ejemplo `brew docto/brew doctor`;
* `brew_update_formula` &ndash; convierte `brew update <fórmula>` en `brew upgrade <fórmula>`;
* `dnf_no_such_command` &ndash; corrige comandos DNF mal escritos;
* `nixos_cmd_not_found` &ndash; instala aplicaciones en NixOS;
* `pacman` &ndash; instala la app con `pacman` si no está instalada (usa `yay`, `pikaur` o `yaourt` si están disponibles);
* `pacman_invalid_option` &ndash; reemplaza opciones minúsculas de `pacman` por mayúsculas.
* `pacman_not_found` &ndash; corrige el nombre del paquete con `pacman`, `yay`, `pikaur` o `yaourt`.
* `yum_invalid_operation` &ndash; corrige llamadas inválidas de `yum`, como `yum isntall vim`;

Los siguientes comandos vienen con *The Fuck*, pero no están habilitados por defecto:

* `git_push_force` &ndash; añade `--force-with-lease` a un `git push` (puede entrar en conflicto con `git_push_pull`);
* `rm_root` &ndash; añade `--no-preserve-root` al comando `rm -rf /`.

##### [Volver al Contenido](#contents)

## Crear tus propias reglas

Para agregar tu propia regla, crea un archivo llamado `tu-nombre-de-regla.py` en `~/.config/thefuck/rules`. El archivo de regla debe contener dos funciones:

```python
match(command: Command) -> bool
get_new_command(command: Command) -> str | list[str]
```

Adicionalmente, las reglas pueden contener funciones opcionales:

```python
side_effect(old_command: Command, fixed_command: str) -> None
```
Las reglas también pueden contener las variables opcionales `enabled_by_default`, `requires_output` y `priority`.

`Command` tiene tres atributos: `script`, `output` y `script_parts`.
Tu regla no debe modificar `Command`.

**La API de reglas cambió en 3.0:** Para acceder a la configuración de una regla, impórtala con
 `from thefuck.conf import settings`

`settings` es un objeto especial ensamblado desde `~/.config/thefuck/settings.py`, y valores del entorno ([ver más abajo](#settings)).

Un ejemplo simple de regla para ejecutar un script con `sudo`:

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

priority = 1000  # Menor es primero, por defecto es 1000

requires_output = True
```

[Más ejemplos de reglas](https://github.com/nvbn/thefuck/tree/master/thefuck/rules),
[funciones utilitarias para reglas](https://github.com/nvbn/thefuck/tree/master/thefuck/utils.py),
[ayudas específicas de app/SO](https://github.com/nvbn/thefuck/tree/master/thefuck/specific/).

##### [Volver al Contenido](#contents)

## Configuración

Varios parámetros de *The Fuck* pueden cambiarse en el archivo `$XDG_CONFIG_HOME/thefuck/settings.py`
(`$XDG_CONFIG_HOME` por defecto es `~/.config`):

* `rules` &ndash; lista de reglas habilitadas, por defecto `thefuck.const.DEFAULT_RULES`;
* `exclude_rules` &ndash; lista de reglas deshabilitadas, por defecto `[]`;
* `require_confirmation` &ndash; requiere confirmación antes de ejecutar el nuevo comando, por defecto `True`;
* `wait_command` &ndash; tiempo máximo en segundos para obtener la salida del comando anterior;
* `no_colors` &ndash; desactiva la salida con colores;
* `priority` &ndash; diccionario con prioridades de reglas, la regla con menor `priority` se compara primero;
* `debug` &ndash; activa la salida de depuración, por defecto `False`;
* `history_limit` &ndash; valor numérico de cuántos comandos del historial serán escaneados, como `2000`;
* `alter_history` &ndash; coloca el comando corregido en el historial, por defecto `True`;
* `wait_slow_command` &ndash; tiempo máximo en segundos para obtener la salida del comando anterior si está en la lista `slow_commands`;
* `slow_commands` &ndash; lista de comandos lentos;
* `num_close_matches` &ndash; número máximo de coincidencias cercanas a sugerir, por defecto `3`.
* `excluded_search_path_prefixes` &ndash; prefijos de ruta a ignorar al buscar comandos, por defecto `[]`.

Un ejemplo de `settings.py`:

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

O mediante variables de entorno:

* `THEFUCK_RULES` &ndash; lista de reglas habilitadas, como `DEFAULT_RULES:rm_root` o `sudo:no_command`;
* `THEFUCK_EXCLUDE_RULES` &ndash; lista de reglas deshabilitadas, como `git_pull:git_push`;
* `THEFUCK_REQUIRE_CONFIRMATION` &ndash; requiere confirmación antes de ejecutar el nuevo comando, `true/false`;
* `THEFUCK_WAIT_COMMAND` &ndash; tiempo máximo en segundos para obtener la salida del comando anterior;
* `THEFUCK_NO_COLORS` &ndash; desactiva la salida con colores, `true/false`;
* `THEFUCK_PRIORITY` &ndash; prioridad de las reglas, como `no_command=9999:apt_get=100`,
la regla con menor `priority` se compara primero;
* `THEFUCK_DEBUG` &ndash; activa la salida de depuración, `true/false`;
* `THEFUCK_HISTORY_LIMIT` &ndash; cuántos comandos del historial serán escaneados, como `2000`;
* `THEFUCK_ALTER_HISTORY` &ndash; coloca el comando corregido en el historial `true/false`;
* `THEFUCK_WAIT_SLOW_COMMAND` &ndash; tiempo máximo en segundos para obtener la salida del comando anterior si está en la lista `slow_commands`;
* `THEFUCK_SLOW_COMMANDS` &ndash; lista de comandos lentos, como `lein:gradle`;
* `THEFUCK_NUM_CLOSE_MATCHES` &ndash; número máximo de coincidencias cercanas a sugerir, como `5`.
* `THEFUCK_EXCLUDED_SEARCH_PATH_PREFIXES` &ndash; prefijos de ruta a ignorar al buscar comandos, por defecto `[]`.

Por ejemplo:

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

##### [Volver al Contenido](#contents)

## Paquetes de terceros con reglas

Si quieres hacer un conjunto específico de reglas no públicas, pero quieres compartirlas con otros, crea un paquete llamado `thefuck_contrib_*` con la siguiente estructura:

```
thefuck_contrib_foo
  thefuck_contrib_foo
    rules
      __init__.py
      *reglas de terceros*
    __init__.py
    *utilidades de terceros*
  setup.py
```

*The Fuck* encontrará reglas ubicadas en el módulo `rules`.

##### [Volver al Contenido](#contents)

## Modo instantáneo experimental

El comportamiento por defecto de *The Fuck* requiere tiempo para volver a ejecutar los comandos anteriores. En modo instantáneo, *The Fuck* ahorra tiempo registrando la salida con [script](https://es.wikipedia.org/wiki/Script_(Unix)), luego leyendo el log.

[![gif con modo instantáneo][instant-mode-gif-link]][instant-mode-gif-link]

Actualmente, el modo instantáneo solo soporta Python 3 con bash o zsh. Es necesario también deshabilitar la función de autocorrección de zsh para que thefuck funcione correctamente.

Para habilitar el modo instantáneo, añade `--enable-experimental-instant-mode`
a la inicialización del alias en `.bashrc`, `.bash_profile` o `.zshrc`.

Por ejemplo:

```bash
eval $(thefuck --alias --enable-experimental-instant-mode)
```

##### [Volver al Contenido](#contents)

## Desarrollo

Ver [CONTRIBUTING.md](CONTRIBUTING.md)

## Licencia MIT
La licencia del proyecto puede encontrarse [aquí](LICENSE.md).


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

##### [Volver al Contenido](#contents)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---