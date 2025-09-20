# kubectl-tmux-exec

![GitHub release version](https://img.shields.io/github/v/release/predatorray/kubectl-tmux-exec)
![License](https://img.shields.io/github/license/predatorray/kubectl-tmux-exec)
![Build Status](https://img.shields.io/github/actions/workflow/status/predatorray/kubectl-tmux-exec/ci.yml?branch=master)
![GitHub all releases](https://img.shields.io/github/downloads/predatorray/kubectl-tmux-exec/total)

A **kubectl** plugin for executing commands interactively across multiple pods or containers using [**tmux**](https://github.com/tmux/tmux),
like `csshX` or `pssh` but for **Kubernetes**.

![screenshot](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot.png?raw=true)

To execute command across all the Nginx containers using `bash` for example, run:

```sh
kubectl tmux-exec -l app=nginx /bin/bash
```
## Instalación 

### Homebrew

> **Nota**: Esto es solo para usuarios de Mac.

1. Instale [Homebrew](https://brew.sh/).

2. `brew install predatorray/brew/kubectl-tmux-exec`

Finalmente, asegúrese de que `/usr/local/bin/kubectl-tmux_exec` esté en su `$PATH`.

### Krew

> **Nota**: Se recomienda para usuarios de Linux.
> 
> Aunque funciona tanto en Mac como en Linux, no se recomienda para usuarios de Mac, ya que aún puede ser necesario instalar la dependencia `gnu-getopt` con la ayuda de Homebrew.

1. Instale [Krew](https://krew.sigs.k8s.io/) siguiendo [la guía del usuario](https://krew.sigs.k8s.io/docs/user-guide/setup/install/).

2. `kubectl krew install tmux-exec`

3. Instale las dependencias. ([Wiki: Cómo-instalar-dependencias](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

### Manualmente

1. Descargue la [última versión](https://github.com/predatorray/kubectl-tmux-exec/releases/latest).

2. Descomprima el archivo kubectl-tmux-exec-*.tar.gz y copie todos los archivos a un directorio, por ejemplo, `/usr/local/kubectl-tmux-exec`.

3. Añada el directorio `bin/` a su `$PATH`. Por ejemplo, agregue esta línea a su archivo rc: `export PATH="$PATH:/usr/local/kubectl-tmux-exec/bin"`.

4. Instale las dependencias. ([Wiki: Cómo-instalar-dependencias](https://github.com/predatorray/kubectl-tmux-exec/wiki/How-to-Install-Dependencies))

## Uso

Asegúrese de tener `kubectl` ≥ 1.12 ([soporte para plugins]), idealmente la última versión.

De lo contrario, ejecute el script directamente: `kubectl-tmux_exec [...ARGS]`.


Verifique si el script se ha agregado con éxito mediante:

```sh
kubectl plugin list
```
La salida debería ser así


```txt
The following compatible plugins are available:

/usr/local/bin/kubectl-tmux_exec
```

Si no aparece en la lista, verifica nuevamente la variable de entorno `$PATH`.

Puedes usar el siguiente comando para obtener el uso del script.

```sh
kubectl tmux-exec --help

# or
kubectl-tmux_exec --help
```

### Opciones

| Bandera                         | Uso                                                                                                                                                           |
|---------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------|
| `-V`<br>`--version`             | Imprimir la información de la versión                                                                                                                        |
| `-l`<br>`--selector`            | Selector (consulta de etiquetas) para filtrar, soporta '=', '==', y '!='.(ej. -l key1=value1,key2=value2)<br>Debe usar la opción `--selector` o `--file`.     |
| `-f`<br>`--file`                | Leer nombres de pods línea por línea desde un archivo.<br>Debe usar la opción `--selector` o `--file`.                                                        |
| `-c`<br>`--container`           | Nombre del contenedor. Si se omite, se elegirá el primer contenedor en el pod                                                                                 |
| `-i`<br>`--stdin`               | Pasar stdin al contenedor (**obsoleto**, ya que está habilitado por defecto)                                                                                   |
| `-t`<br>`--tty`                 | Stdin es un TTY (**obsoleto**, ya que está habilitado por defecto)                                                                                            |
| `-d`<br>`--detach`              | Hacer que la sesión de Tmux esté separada                                                                                                                    |
| `-n`<br>`--namespace=`          | El ámbito del namespace para esta solicitud CLI (puede aplicarse varias veces)                                                                                |
| `--context`                     | El nombre del contexto kubeconfig a usar (puede aplicarse varias veces)                                                                                       |
| `-A`<br>`--all-namespaces`      | Si está presente, lista y ejecuta el/los objeto(s) solicitado(s) en todos los namespaces. El namespace en el contexto actual se ignora incluso si se especifica con --namespace. |
| `-C`<br>`--enable-control-mode` | Iniciar tmux en modo control y el eco está deshabilitado. (Ver: [Integración iTerm2](#iterm2-integration))                                                    |
| `--remain-on-exit`              | Mantener la ventana de Tmux al salir                                                                                                                         |
| `--select-layout`               | Uno de los cinco layouts predefinidos de Tmux: even-horizontal, even-vertical, main-horizontal, main-vertical, o tiled.                                     |
| `--session-mode`                | Dónde se abre tmux: auto, new-session, current-session                                                                                                        |

El uso de estas opciones también está disponible con `--help`.

### Ejemplo

El `tmux-exec` es similar a `exec`, excepto que requiere selectores de etiquetas mientras que `exec` requiere un nombre de pod.

Para entrar en bash en todos los contenedores de pods que comparten algunas etiquetas comunes, por ejemplo, `foo=bar`.

```sh
kubectl tmux-exec -l foo=bar /bin/bash
```

Después de que hayas accedido con éxito mediante `bash` a tus contenedores seleccionados, en realidad se abre una ventana de Tmux, donde cada panel muestra el resultado de la ejecución de cada contenedor del pod. Tus entradas de teclado se sincronizarán en todos esos paneles.

Si no estás familiarizado con Tmux, puedes consultar la página man de tmux o tutoriales en línea. O puedes ver la [chuleta](#tmux-cheatsheet) a continuación, que creo será suficiente.

### Integración con iTerm2

Con `-C` o `--enable-control-mode`, se ejecuta en modo de control y delega la entrada del panel a la función "Broadcast Input" de [iTerm2],
no es necesario usar combinaciones de teclas de tmux.

Usa <kbd>⌘</kbd> + <kbd>⌥</kbd> + <kbd>i</kbd> para activar o desactivar la transmisión en iTerm2. (`synchronize-panes` se desactivará automáticamente en este modo.)

(ver: [Integración tmux](https://iterm2.com/documentation-tmux-integration.html) para más información)

#### Ejemplo

```sh
kubectl tmux-exec -C -l app=nginx /bin/bash
```

![captura de pantalla](https://raw.githubusercontent.com/predatorray/kubectl-tmux-exec/master/../assets/screenshot-iterm2-integration.png?raw=true)

### Autocompletado de Shell

Por favor, consulte [esta wiki](https://github.com/predatorray/kubectl-tmux-exec/wiki/Shell-Auto-completion) para más información.

### Hoja de trucos de Tmux

Todos los comandos de Tmux comienzan con un `PREFIX`. Por defecto el `PREFIX` es <kbd>Ctrl</kbd> + <kbd>b</kbd>. Usaré `C-b` a continuación para representarlo.

`C-b d`, desconectar de la sesión. Después de eso, Tmux seguirá ejecutándose en segundo plano. Puedes escribir `tmux a` para volver a conectar.

`C-b :setw synchronize-panes off`, desactivar la sincronización de entradas en todos los paneles.

`C-b :setw synchronize-panes on`, activar la sincronización de entradas en todos los paneles.

`C-b <TECLA-DE-FLECHA>`, mover el cursor entre los paneles.

`C-b xy`, cerrar el panel actual.

`C-b &y`, cerrar la ventana incluyendo todos los paneles.

## Comunidad y Soporte

- Reporta problemas o solicitudes de funciones a través de [GitHub Issues]((https://github.com/predatorray/kubectl-tmux-exec/issues/new))
- Únete al [Grupo de Google](https://groups.google.com/g/kubectl-tmux-exec) para discusiones

## Otros plugins

[kubectl-alias](https://github.com/predatorray/kubectl-alias): el comando alias que faltaba para kubectl.

## Invítame un café

Si te ahorra tiempo, siéntete libre de [invitarme un café] 🙌

[![](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)][invítame un café]

[invítame un café]: https://buymeacoffee.com/predatorray
[iTerm2]: https://iterm2.com/index.html
[soporte de plugin]: https://kubernetes.io/docs/tasks/extend-kubectl/kubectl-plugins/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---