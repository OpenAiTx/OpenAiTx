# smart_workspace_switcher.wezterm

Un cambiador inteligente de espacios de trabajo para Wezterm inspirado en [t-smart-tmux-session-manager](https://github.com/joshmedeski/t-smart-tmux-session-manager) y su sucesor [sesh](https://github.com/joshmedeski/sesh)

## Uso

💨 Mejora tu flujo de trabajo cambiando entre espacios de trabajo ⚡ ***RÁPIDAMENTE*** ⚡ con 1️⃣ pulsación de tecla, el poder de la búsqueda difusa y zoxide! 💨

![Demo gif](https://github.com/MLFlexer/smart_workspace_switcher.wezterm/assets/75012728/a4f82fcf-5304-4891-a1e2-346767678dc6)

## Dependencias

* zoxide

### Configuración

1. Requiere el complemento:

    ```lua
    local wezterm = require("wezterm")
    local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
    ```
2. Aplica la asignación de teclas predeterminada a la configuración:


    ```lua
    workspace_switcher.apply_to_config(config)
    ```
O crear tu propia asignación de teclas, consulta [Configuración - Asignación de teclas](#Keybinding).

### Configuración:
#### Asignación de teclas
Para agregar una asignación de teclas personalizada:


  ```lua
  config.keys = {
    -- ...
    -- your other keybindings
    {
      key = "s",
      mods = "LEADER",
      action = workspace_switcher.switch_workspace(),
    },
    {
      key = "S",
      mods = "LEADER",
      action = workspace_switcher.switch_to_prev_workspace(),
    }
  }
  ```

#### Cambiar el nombre predeterminado del espacio de trabajo
Puedes establecer un nombre predeterminado para el espacio de trabajo:

```lua
config.default_workspace = "~"
```
#### Filtrado Adicional

Puedes incluir `extra_args` en la llamada a `switch_workspace` para filtrar aún más los resultados de la consulta de zoxide. El `extra_args` es simplemente una cadena concatenada al comando de esta forma: `zoxide query -l <extra_args>`. Por ejemplo, para seleccionar proyectos de una lista predefinida en `~/.projects`, llama al plugin así:


  ```lua
  workspace_switcher.switch_workspace({ extra_args = " | rg -Fxf ~/.projects" })
  ```
#### Cambiar elementos del buscador difuso

Puedes cambiar la lista de elementos del buscador difuso configurando una nueva función para `get_choices` de la siguiente manera:


```lua
local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
workspace_switcher.get_choices = function(opts)
  -- this will ONLY show the workspace elements, NOT the Zoxide results
  return workspace_switcher.choices.get_workspace_elements({})
end
```
Por defecto, la función utiliza las siguientes funciones para crear una lista:


```lua
workspace_switcher.choices.get_workspace_elements({ id: string, label: string }[])
workspace_switcher.choices.get_zoxide_elements({ id: string, label: string }[], {extra_args?: string, workspace_ids?: workspace_ids}?)
```
#### Actualizando el estado derecho con la ruta

Para agregar la ruta seleccionada a la barra de estado derecha, utiliza el evento `smart_workspace_switcher.workspace_switcher.chosen` emitido al elegir un espacio de trabajo:


  ```lua
  wezterm.on("smart_workspace_switcher.workspace_switcher.chosen", function(window, workspace)
    local gui_win = window:gui_window()
    local base_path = string.gsub(workspace, "(.*[/\\])(.*)", "%2")
    gui_win:set_right_status(wezterm.format({
      { Foreground = { Color = "green" } },
      { Text = base_path .. "  " },
    }))
  end)

  wezterm.on("smart_workspace_switcher.workspace_switcher.created", function(window, workspace)
    local gui_win = window:gui_window()
    local base_path = string.gsub(workspace, "(.*[/\\])(.*)", "%2")
    gui_win:set_right_status(wezterm.format({
      { Foreground = { Color = "green" } },
      { Text = base_path .. "  " },
    }))
  end)
  ```
#### Eventos

Los siguientes eventos están disponibles y pueden usarse para activar comportamientos personalizados:

* `smart_workspace_switcher.workspace_switcher.start` - Se activa cuando el buscador difuso comienza.
* `smart_workspace_switcher.workspace_switcher.canceled` - Se activa si no se elige ningún elemento.
* `smart_workspace_switcher.workspace_switcher.selected` - Se activa cuando se selecciona un elemento.
* `smart_workspace_switcher.workspace_switcher.created` - Se activa después de crear y cambiar a un nuevo espacio de trabajo.
* `smart_workspace_switcher.workspace_switcher.chosen` - Se activa después de cambiar a un espacio de trabajo.
* `smart_workspace_switcher.workspace_switcher.switched_to_prev` - Se activa después de cambiar a un espacio de trabajo anterior.

> [!NOTA]
> Los eventos `created` y `chosen` emiten objetos [MuxWindow](https://wezfurlong.org/wezterm/config/lua/mux-window/) mientras que los otros emiten objetos [GuiWindow](https://wezfurlong.org/wezterm/config/lua/window/index.html). 

Ejemplo de uso:


  ```lua
  wezterm.on("smart_workspace_switcher.workspace_switcher.chosen", function(window, workspace)
    wezterm.log_info("THIS IS EMITTED FROM THE CALLBACK")
  end)
  ```

#### Formateador de espacio de trabajo

Establezca un formateador personalizado para el espacio de trabajo usando el siguiente ejemplo. Para más información, consulte la [documentación de formateo de Wezterm](https://wezfurlong.org/wezterm/config/lua/wezterm/format.html):

  ```lua
  workspace_switcher.workspace_formatter = function(label)
    return wezterm.format({
      { Attribute = { Italic = true } },
      { Foreground = { Color = "green" } },
      { Background = { Color = "black" } },
      { Text = "󱂬: " .. label },
    })
  end
  ```

#### Ruta de Zoxide

Para definir una ruta personalizada a `zoxide`:

  ```lua
  workspace_switcher.zoxide_path = "/path/to/zoxide"
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---