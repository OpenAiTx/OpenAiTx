# YankBank

Un plugin de Neovim para llevar un registro de los yanks y eliminaciones más recientes y exponerlos en un menú de acceso rápido.

## Qué Hace

YankBank almacena los N yanks recientes en el registro sin nombre ("), luego llena una ventana emergente con estos yanks recientes, permitiendo un acceso rápido al historial reciente de yanks.
Al abrir el menú emergente, el contenido actual del registro unnamedplus (+) también se añade al menú (si es diferente del contenido actual del registro sin nombre).

Seleccionar una entrada del menú (presionando enter) la pegará en el buffer actualmente abierto en la posición del cursor.

YankBank también ofrece persistencia entre sesiones, lo que significa que no perderás tus yanks después de cerrar y reabrir una sesión (ver [persistencia](#Persistence)).

### Capturas de Pantalla

![Ventana emergente de YankBank ampliada](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/assets/screenshot-2.png)

El menú es específico para la sesión actual, y solo contendrá el contenido del registro unnamedplus actual al abrirse en una sesión completamente nueva.
Se irá llenando más con cada yank o eliminación en esa sesión.

## Instalación y Configuración

#### Con Persistencia (Recomendado)

Usando lazy.nvim
```lua
{
    "ptdewey/yankbank-nvim",
    dependencies = "kkharji/sqlite.lua",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup({
            persist_type = "sqlite",
        })
    end,
}
```

#### Sin persistencia:

Usando lazy.nvim
```lua
{
    "ptdewey/yankbank-nvim",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup()
    end,
}
```

#### Carga perezosa

Según las [mejores prácticas](https://github.com/nvim-neorocks/nvim-best-practices?tab=readme-ov-file#sleeping_bed-lazy-loading), la huella de inicialización de YankBank es muy mínima, y las funcionalidades solo se cargan cuando se necesitan. Por lo tanto, establezco `lazy=false` en mi configuración, y obtengo un tiempo de inicio de <1ms.

```lua
-- plugins/yankbank.lua
return {
    {
        "ptdewey/yankbank-nvim",
        lazy = false,
        config = function()
            -- ...
        end,
    },
    {
        "kkharji/sqlite.lua",
        lazy = true,
    },
}
```
Si no quieres cargar YankBank al iniciar, anteriormente lo cargaba al presionar las teclas que copian texto (`y`, `Y`, `d`, `D`, `x`), el evento `FocusGained` y el comando `YankBank`.

```lua
{
    "ptdewey/yankbank-nvim",
    dependencies = "kkharji/sqlite.lua",
    keys = {
        { "y" },
        { "Y", "y$" }, -- redefine Y behavior to y$ to avoid breaking lazy
        { "D" },
        { "d" },
        { "x" },
        { "<leader>p", desc = "Open YankBank" },
    },
    cmd = { "YankBank" },
    event = { "FocusGained" },
    config = function()
        require("yankbank").setup({
            -- ...
        })
    end
}
```


### Opciones de Configuración

La función de configuración también admite recibir una tabla de opciones:
| Opción | Tipo | Predeterminado |
|-------------|--------------------------------------------|----------------|
| max_entries | número entero de entradas para mostrar en el popup | `10` |
| sep | separador de cadena para mostrar entre las entradas de la tabla | `"-----"` |
| keymaps | tabla que contiene las anulaciones de keymap | `{}` |
| keymaps.navigation_next | cadena | `"j"` |
| keymaps.navigation_prev | cadena | `"k"` |
| keymaps.paste | cadena | `"<CR>"` |
| keymaps.paste_back | cadena | `"P"` |
| keymaps.yank | cadena | `"yy"` |
| keymaps.close | tabla de cadenas | `{ "<Esc>", "<C-c>", "q" }` |
| num_behavior | cadena que define el comportamiento del salto "prefix" o "jump" | `"prefix"` |
| focus_gain_poll | booleano | `false` |
| registers | contenedor de tabla para anulaciones de registros | `{ }` |
| registers.yank_register | registro predeterminado para copiar desde el popup a | `"+"` |
| persist_type | cadena que define el tipo de persistencia "sqlite" o nil | `nil` |
| db_path | cadena que define la ruta del archivo de base de datos para usar con persistencia sqlite | directorio de instalación del plugin |
| bind_indices | cadena opcional para usar como prefijo de keybind para pegar por número de índice (p. ej. "<leader>p") | `nil` |


#### Ejemplo de Configuración

```lua
{
    "ptdewey/yankbank-nvim",
    config = function()
        require('yankbank').setup({
            max_entries = 9,
            sep = "-----",
            num_behavior = "jump",
            focus_gain_poll = true,
            persist_type = "sqlite",
            keymaps = {
                paste = "<CR>",
                paste_back = "P",
            },
            registers = {
                yank_register = "+",
            },
            bind_indices = "<leader>p"
        })
    end,
}
```
Si no se desea un separador, pase una cadena vacía para `sep`

La opción 'num_behavior' define el comportamiento de navegación en el popup al presionar teclas numéricas.
- `num_behavior = "prefix"` funciona de manera similar a la navegación tradicional de vim con '3j' moviéndose hacia abajo 3 entradas en el banco.
- `num_behavior = "jump"` salta a la entrada que coincide con la tecla numérica presionada (es decir, '3' salta a la entrada 3)
    - Nota: Si 'max_entries' es un número de dos dígitos, habrá un retraso al presionar números que son prefijos de una entrada válida.

La opción 'focus_gain_poll' permite habilitar un autocomando adicional que vigila las ganancias de foco (reenfoque de la ventana Neovim), y verifica cambios en el registro unnamedplus ('+'), agregando al yankbank cuando se encuentran nuevos contenidos. Esto permite agregar automáticamente texto copiado de otras fuentes (como un navegador) al yankbank sin que se active la apertura del banco. Está desactivado por defecto, pero recomiendo encarecidamente activarlo con `focus_gain_poll = true`.

### Persistencia
Para la mejor experiencia con YankBank, se recomienda encarecidamente habilitar la persistencia.
Si la persistencia está habilitada, sqlite.lua se usará para crear un almacenamiento persistente para los yanks recientes en el directorio raíz del plugin.
Para utilizar la persistencia sqlite, `"kkharji/sqlite.lua"` debe añadirse como dependencia en su configuración, y `persist_type` debe establecerse en `"sqlite"`:


```lua
-- lazy
return {
    "ptdewey/yankbank-nvim",
    dependencies = "kkharji/sqlite.lua",
    config = function()
        require('yankbank').setup({
            -- other options...
            persist_type = "sqlite"
        })
    end,
}
```
Nota: La base de datos puede ser limpiada con el comando `:YankBankClearDB` o eliminando el archivo db (que se encuentra en el directorio de instalación del plugin por defecto).

Si encuentras algún problema relacionado con SQL, por favor reporta un problema en GitHub. (Como solución temporal, también puedes intentar limpiar la base de datos)


Si tienes problemas de permisos al crear el archivo db (por ejemplo, al instalar usando Nix), usa la opción `db_path` para cambiar la ruta del archivo por defecto. (`vim.fn.stdpath("data")` debería funcionar)

## Uso

El menú emergente puede abrirse con el comando:`:YankBank`, una entrada se pega en la posición actual del cursor al presionar enter, y el menú puede cerrarse presionando escape, ctrl-c, o q.
Una entrada del menú también puede copiarse al registro unnamedplus presionando yy.

Personalmente también recomendaría configurar un atajo de teclado para abrir el menú.

```lua
-- map to '<leader>y'
vim.keymap.set("n", "<leader>y", "<cmd>YankBank<CR>", { noremap = true })
```

---

## API (EN PROGRESO)

Algunos elementos internos del complemento también son accesibles a través de la API de YankBank.

Ejemplos:
```lua
-- get the ith entry in the bank
---@param i integer index to get
-- output format: { yank_text = "entry", reg_type = "v" }
local e = require("yankbank.api").get_entry(i)

-- add an entry to the bank
---@param yank_text string yank text to add to YANKS table
---@param reg_type string register type "v", "V", or "^V" (visual, v-line, v-block respectively)
require("yankbank.api").add_entry("yank_text", "reg_type")

-- remove an entry from the bank by index
---@param i integer index to remove
require("yankbank.api").remove_entry(i)

--- pin entry to yankbank so that it won't be removed when its position exceeds the max number of entries
---@param i integer index to pin
require("yankbank.api").pin_entry(i)


--- unpin bank entry
---@param i integer index to unpin
require("yankbank.api").unpin_entry(i)
```

Para más detalles sobre la API vea [lua/yankbank/api.lua](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/lua/yankbank/api.lua)

---

## Mejoras Potenciales
- integración con nvim-cmp
- integración con fzf
- integración con telescope

## Alternativas

- [nvim-neoclip](https://github.com/AckslD/nvim-neoclip.lua)
- [yanky.nvim](https://github.com/gbprod/yanky.nvim)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---