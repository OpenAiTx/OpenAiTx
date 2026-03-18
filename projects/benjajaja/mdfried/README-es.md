# mdfried

`mdfried` es un visor de markdown para la terminal que muestra los encabezados como **Texto Más Grande** que el
resto.

## Capturas de pantalla

![Captura de pantalla](https://raw.githubusercontent.com/benjajaja/mdfried/master/./assets/screenshot_1.png)

[Último conjunto de capturas de pantalla de prueba desde `master`](https://benjajaja.github.io/mdfried-screenshots/)

## Video

https://github.com/user-attachments/assets/e69154a7-bea8-4e14-a677-be7ccf0d3cac

# ¿Por qué?

Puedes *[cocinar](https://ratatui.rs/)* una terminal. ¿Pero puedes **freír** profundamente una terminal?
*¡SÍ!* ¡Puedes **cocinar *y* freír** tu `tty`! ~~Corre antes de que sea demasiado tarde!~~

> La terminal usualmente está en modo "cocinado", o modo canónico.
> Con `ratatui`🐁, está en modo raw, pero "cocina" por ti.

Markdown obviamente puede renderizarse bastante bien en terminales, pero falta un aspecto clave: 
Los Encabezados Grandes™ hacen el texto más legible, y mostrar imágenes en línea es muy conveniente.

# ¿Cómo?

Renderizando los encabezados como [imágenes con ratatui](https://github.com/benjajaja/ratatui-image),
y usando uno de varios protocolos gráficos de terminal: Sixels, Kitty, o iTerm2.
La terminal Kitty también implementa un [Protocolo de Tamaño de Texto](https://sw.kovidgoyal.net/kitty/text-sizing-protocol/)
para escalar texto directamente sin necesidad de renderizar como imágenes.

Consulta [ratatui-image](https://github.com/benjajaja/ratatui-image?tab=readme-ov-file#compatibility-matrix)
para ver si tu terminal tiene soporte gráfico, y para más detalles.

En general, Kitty, WezTerm, iTerm2, Ghostty, Foot, `xterm -ti vt340`, *deberían* funcionar.

En terminales sin gráficos en absoluto, como Alacritty, las imágenes se renderizan con Chafa.

# Instalación

* Rust cargo: `cargo install mdfried`
  * Desde el código fuente: `cargo install --path .`
  * Requiere un paquete chafa con encabezados de desarrollo, usualmente llamado algo así como `libchafa-dev`, `libchafa-devel`, o simplemente `libchafa`, o incluso solo `chafa`.
  * Si chafa no está disponible en absoluto, o no te importa porque tu terminal soporta algún protocolo gráfico, entonces usa `--no-default-features`.
  * Si `cargo install ...` falla, intenta con `--locked`, y/o reporta un problema.
* Nix flake: `github:benjajaja/mdfried`
* Nixpkgs: [`mdfried`](https://search.nixos.org/packages?channel=unstable&query=mdfried)
* Arch Linux: `pacman -S mdfried` ([repositorio extra](https://archlinux.org/packages/extra/x86_64/mdfried/))
* Ubuntu: [Descargar release .deb](https://github.com/benjajaja/mdfried/releases/latest)
* Mac: `brew install mdfried` o [binarios release](https://github.com/benjajaja/mdfried/releases/latest)
* Windows: [Descargar release .exe](https://github.com/benjajaja/mdfried/releases/latest)

# Uso

### Ejecución

```
mdfried ./path/to.md
```

A menos que estés usando Kitty versión 0.40 o superior, o un terminal que no soporte ningún protocolo gráfico,
la primera vez que ejecutes `mdfried` tendrás que elegir una fuente.
Deberías elegir la misma fuente que está usando tu terminal, pero podrías elegir cualquier otra.
La pantalla de configuración de fuente te permite buscar las fuentes del sistema - querrás elegir la misma fuente que
tu terminal está usando.
La fuente se renderiza directamente como una vista previa.
Una vez confirmada, la elección se escribe en el archivo de configuración.

Usa `--setup` para forzar la configuración de fuente nuevamente si la fuente no es la correcta.

También puedes pasarle markdown a través de una tubería:

```
readable https://lobste.rs | markdownify | mdfried
```
### Atajos de teclado

Tecla | Descripción
------|------------
`q` o `Ctrl-c` | Salir y dejar el contenido en la terminal
`r` | Recargar el archivo (a menos que sea entrada estándar canalizada)
`j` | Desplazarse una línea hacia abajo
`k` | Desplazarse una línea hacia arriba
`d` o `Ctrl-d` | Desplazarse media página hacia abajo
`u` o `Ctrl-u` | Desplazarse media página hacia arriba
`f` o `PageDown` o `Space` | Desplazarse una página hacia abajo
`b` o `PageUp` | Desplazarse una página hacia arriba
`g` | Ir al inicio del archivo
`G` | Ir al final del archivo
`<número>G` o `<número>g` | Ir a la cadena #\<número>
`/` | Buscar texto
`n` | Saltar a la siguiente coincidencia o enlace
`N` | Saltar a la coincidencia o enlace anterior
`Enter` | Abrir enlace seleccionado con `xdg-open`
`Esc` | Salir de los modos de búsqueda o enlace

Ingresar un número antes del movimiento aplica el movimiento esa cantidad de veces.

El desplazamiento con el ratón solo funciona si está habilitado en la configuración como `enable_mouse_capture = true`, pero entonces no se puede
seleccionar texto.

### Configuración

`~/.config/mdfried/config.toml` se crea automáticamente en la primera ejecución.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---