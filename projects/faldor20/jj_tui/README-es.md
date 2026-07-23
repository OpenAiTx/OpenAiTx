# Jujutsu TUI
[![nix](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml/badge.svg)](https://github.com/faldor20/jj_tui/actions/workflows/build-nix.yml)

Un TUI para el sistema de control de versiones Jujutsu
Nuestro enfoque aquí es en:
- **Rendimiento**: jj_tui debe iniciarse rápido y nunca ralentizarte, debe sentirse extremadamente ágil para navegar por tus commits y archivos
- **Intuitivo**: Las combinaciones de teclas deben ser fáciles de memorizar y rápidas de grabar en la memoria muscular sin popups innecesarios
- **Interactividad**: jj_tui reimplementa completamente el renderizador de jj para que podamos mostrar vistas previas en tiempo real del gráfico mientras decides cómo debe verse tu rebase (¡Usa `r`ebase `p`review para probarlo!)

![jj_tui-ezgif com-optimize](https://github.com/faldor20/jj_tui/assets/26968035/fb053320-484a-4d6f-9b66-e5b9d0d49e5d)


Presiona `?` para mostrar la ayuda. (los comandos son diferentes entre la vista de gráfico y archivos).
`Flechas` o `hjkl` para navegar entre ventanas/elementos
`Espacio` para seleccionar/deseleccionar revisiones (selección múltiple en la vista de gráfico)
`Enter` para ampliar el diff y desplazarte por él

## Características principales

### Operaciones normales de jj
- `c`ommiting
- `r`ebasing
- `g`it pushing y pulling
- Añadir, mover y borrar `b`ookmarks
- `s`quashing y `s`plitting commits
- `space` puede usarse para seleccionar múltiples commits para copiar, rebasear, etc., iniciar un `n`uevo commit encima, etc.

### Crear commits desde la vista de archivos:
- `space` puede usarse para seleccionar archivos para `c`ommitir separadamente o `m`over a otro commit
- Los archivos pueden enviarse a commits `N`ext o `P`revious

### Filtrado por revsets
- `f`iltrar por cualquier revset que desees

Lista de comandos del gráfico:

![jj_tui commands](https://github.com/user-attachments/assets/1e446a3d-1736-4207-b311-29d8e4bdc333)

## Instalación
`linux`: Descarga la última versión. Está enlazada estáticamente y debería funcionar en cualquier máquina Linux.
`mac`: Descarga una versión precompilada. Avísame si tienes algún problema ya que no puedo probar en un mac.

Para abrir un shell con jj_tui en nix: `nix shell github:faldor20/jj_tui`

## Dependencias
El CLI de jujutsu (versión mínima 0.30.0)
No he probado en Windows o Mac.
Creo que no funcionará fuera de Unix, por lo que los usuarios de Windows tendrán que usar wsl por ahora.

# Archivo de configuración:
Puedes crear un archivo de configuración `config.yaml` en los siguientes directorios para personalizar las entradas de teclas
`linux`: $XDG_CONFIG_HOME/jj_tui/
`macos`: ~/Library/preferences/jj_tui/
Consulta `./jj_tui/lib/key_map.ml` para una especificación del mapa de teclas y `./jj_tui/lib/config.ml` para la configuración
La configuración del mapa de teclas te permite personalizar completamente todos los comandos y sus submenús, así como reasignar las teclas de flecha.

Ej:

``` yaml
key_map:
  remap:
   h: "left"
   j: "down"
   k: "up"
   l: "right"
  graph:
    #Simple mapping from key to command_id
    p: prev
    #Command sub menu
    s:
      title: "Squash"
      sub:
        # sub menu command
        s: "squash_into_parent"
# If the terminal is smaller than this width, the UI will change to a single pane view
single_pane_width_threshold: 110
# Sets the limit to how many commits are ever rendered in jj_tui. Usefull for not slowing down too much when viewing 'all()' revest.
max_commits: 100
```
Para una lista completa de identificadores de comandos, consulte [`jj_tui/bin/graph_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/graph_commands.ml) y [`jj_tui/bin/file_commands.ml`](https://raw.githubusercontent.com/faldor20/jj_tui/main/jj_tui/bin/file_commands.ml)

# registros:
`linux`: $XDG_STATE_HOME/jj_tui/
`macos`: ~/Library/logs/jj_tui/

# Desarrollo
Se puede compilar con nix `nix build` o abrir un shell nix con `nix develop`
NOTA: si está usando el shell de desarrollo nix y desea compilar con dune, use `dune build --pkg disabled` para compilar usando las dependencias proporcionadas por nix
También se puede compilar directamente con la gestión de paquetes Dune mediante `dune build`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---