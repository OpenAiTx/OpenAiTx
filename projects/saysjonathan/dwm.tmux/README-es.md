dwm.tmux
===
Administrador de ventanas y paneles en mosaico para Tmux inspirado en [dwm](http://dwm.suckless.org/).

![](https://raw.githubusercontent.com/saysjonathan/dwm.tmux/master/screenshot.png)

## Dependencias
dwm.tmux requiere tmux >= 3.2.

## Instalación
### Vía TPM (recomendado)
Agregar a `~/.tmux.conf`:

```sh
set -g @plugin 'saysjonathan/dwm.tmux'
```

Recargar y ejecutar `prefix-I` para obtener.

### Instalación manual (legado)
Para instalar, use el `Makefile` proporcionado:

```sh
git clone https://github.com/saysjonathan/dwm.tmux.git
cd dwm.tmux
make
```
Por defecto, `dwm.tmux` utiliza `/usr/local` como su prefijo. Para cambiar el prefijo:


```sh
make PREFIX=$HOME
```

Asegúrese de que `$PREFIX/bin` esté en su `PATH`.

Para usarlo, cargue la configuración de tmux `dwm.tmux` con source:

```sh
echo 'source-file /usr/local/lib/dwm.tmux' >> $HOME/.tmux.conf
```

## Uso
`dwm.tmux` define los siguientes alias de comandos, cada uno con un atajo de teclado predeterminado:

- `newpane` `Meta-n` Crear un nuevo panel y colocarlo en el panel principal
- `newpanecurdir` `Meta-w` Crear un nuevo panel que comience en el mismo directorio y colocarlo en el panel principal
- `killpane` `Meta-c` Cerrar el panel actual. Si el panel está en el panel principal, cerrar el panel y promover el primer panel en la pila a panel principal
- `movepane[0-9]` `Meta-Shift-[0-9]` Mover el panel actual a la ventana especificada
- `nextpane` `Meta-j` Seleccionar el siguiente panel (en sentido horario); intercambia el panel de pantalla completa en modo monocle
- `prevpane` `Meta-k` Seleccionar el panel anterior (en sentido antihorario); intercambia el panel de pantalla completa en modo monocle
- `stackup` `Meta-J` Mover el panel enfocado hacia arriba en la pila
- `stackdown` `Meta-K` Mover el panel enfocado hacia abajo en la pila
- `rotateccw` `Meta-<` Rotar los paneles en sentido antihorario
- `rotatecw` `Meta->` Rotar los paneles en sentido horario
- `tile` `Meta-t` Volver al diseño en mosaico, saliendo del modo monocle si está activo
- `monocle` `Meta-Space` Alternar modo monocle (pantalla completa del panel actual)
- `zoom` `Meta-Enter` Colocar el panel seleccionado en el panel principal
- `decmfact` `Meta-h` Disminuir el factor de espacio del panel principal
- `incmfact` `Meta-l` Aumentar el factor de espacio del panel principal
- `window[0-9]` `Meta-[0-9]` Seleccionar la ventana objetivo por ID
- `newwindow` `Meta-N` Crear una nueva ventana comenzando en el mismo directorio que el panel actual
- `killwindow` `Meta-X` Eliminar la ventana activa actual
- `popup` `Meta-p` Mostrar un panel emergente flotante en el directorio del panel actual
- `incpfact` `Meta-.` Aumentar el tamaño del panel enfocado en la pila, relativo a los otros paneles
- `decpfact` `Meta-,` Disminuir el tamaño del panel enfocado en la pila, relativo a los otros paneles
- `resetpfact` `Meta-=` Restablecer el pfact del panel enfocado

También se incluyen atajos adicionales para ciclar ventanas:
- `Meta-[` Ventana anterior
- `Meta-]` Ventana siguiente

Además, se definen opciones globales para ajustar el comportamiento:

- `mfact` Factor de espacio del panel principal, el tamaño del panel principal como porcentaje del tamaño total de la ventana
- `killlast` Si el valor es mayor que `0`, eliminar el panel incluso si es el último panel en una ventana
- `monocle` Rastrea el modo de diseño activo; 0 para mosaico, 1 para monocle. Se establece automáticamente pero puede leerse para inspeccionar el estado actual.
- `pfact` Factor de tamaño de la pila por panel, escala de 1 a 9, valor predeterminado 5. Valores más altos dan al panel mayor altura relativa en la pila

### Personalizaciones
Los atajos de teclado y valores predeterminados pueden configurarse en un archivo de configuración. Al usar TPM, estos deben establecerse después de la línea `run '~/.tmux/plugins/tpm/tpm'` en `~/.tmux.conf`.

Ejemplos:

```
setenv -g killlast 1 # kill pane even if it's the last
set-option -wg @mfact 60
set-option -wg @pfact 4
bind -n M-q killpane
bind -n M-w newpanecurdir
```

## Detalles

Similar a dwm, las ventanas siempre se organizan de la siguiente manera:

```
 ====================================
|                 |        S1        |
|                 |==================
|      M(0)       |        S2        |
|                 |==================
|                 |        S3        |
 ====================================
```

Un panel principal grande se coloca en el lado izquierdo de la pantalla mientras que una pila de paneles más pequeños se coloca a la derecha. El panel principal siempre es el panel 0, mientras que la pila de paneles se numera secuencialmente en orden ascendente.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-03

---