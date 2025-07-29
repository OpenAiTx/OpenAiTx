# i3-quickterm

[![Estado del empaquetado](https://repology.org/badge/vertical-allrepos/python:i3-quickterm.svg)](https://repology.org/project/python:i3-quickterm/versions)

Un pequeño terminal desplegable para [i3wm](https://i3wm.org/) y [sway](https://swaywm.org/)

## Características

* usa tu emulador de terminal favorito
* puede seleccionar una shell con [dmenu](http://tools.suckless.org/dmenu/) / [rofi](https://github.com/DaveDavenport/rofi)
* se adapta al ancho de la pantalla
* compatible con múltiples monitores

## Instalación

A través de pip:

```
pip install i3-quickterm
```

O consulte la insignia de repology arriba para ver si está empaquetado por su distribución.

## Uso

Al iniciarse, minimizará el quickterm en la pantalla actual si hay uno. De lo contrario, solicitará al usuario la shell para abrir o usará la que se suministre como argumento.

Si la shell solicitada ya está abierta en otra pantalla, se moverá a la pantalla actual.

Se recomienda asignarlo a una combinación de teclas de i3:

```
# with prompt
bindsym $mod+p exec i3-quickterm
# always bring up standard shell, without the menu
bindsym $mod+b exec i3-quickterm shell
```
## Configuración

La configuración se lee desde `~/.config/i3-quickterm/config.json` o `~/.config/i3/i3-quickterm.json`.

* `menu`: la aplicación compatible con dmenu usada para seleccionar el shell
* `term`: el emulador de terminal elegido
* `history`: un archivo para guardar el orden de shells usados recientemente, el orden por último uso se desactiva si se establece en null
* `width`: el porcentaje del ancho de la pantalla a usar
* `height`: el porcentaje del alto de la pantalla a usar
* `pos`: dónde aparecerá el terminal (`top` o `bottom`)
* `shells`: shells registrados (`{ name: command }`)

`term` puede ser:
- el nombre de un terminal de la [lista soportada](#supported-terminals).
- `auto` para seleccionar el primer terminal existente de la lista anterior (solo para proporcionar valores predeterminados más amigables, no recomendado de otra forma)
- una cadena de formato, como esta: `urxvt -t {title} -e {expanded}` con el formato correcto de argumentos de tu terminal. Algunos terminales, como xfce4-terminal, necesitan que el argumento comando se pase como una cadena. En este caso, reemplaza `{expanded}` por `{string}`

`menu`, `term`, `history` y `shell` pueden contener marcadores para variables de entorno: `{$var}`.

Las claves no especificadas se heredan de los valores predeterminados:


```
{
    "menu": "rofi -dmenu -p 'quickterm: ' -no-custom -auto-select",
    "term": "auto",
    "history": "{$HOME}/.cache/i3-quickterm/shells.order",
    "width": 1.0,
    "height": 0.25,
    "pos": "top",
    "shells": {
        "js": "node",
        "python": "ipython3 --no-banner",
        "shell": "{$SHELL}"
    }
}
```

## Terminales compatibles

* alacritty
* foot
* gnome-terminal
* kitty
* roxterm
* st
* terminator
* termite
* urxvt
* urxvtc
* xfce4-terminal
* xterm

Si deseas agregar otro terminal (o corregir un error), por favor abre una solicitud de extracción.

## Requisitos

* python >= 3.8
* i3 >= v3.11 o sway >= 1.2
* [i3ipc-python](https://i3ipc-python.readthedocs.io/en/latest/) >= v2.0.1
* dmenu o rofi (opcional)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---