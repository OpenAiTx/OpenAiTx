# nvim-dap-repl-highlights
Agrega resaltado de sintaxis al buffer REPL de [nvim-dap](https://github.com/mfussenegger/nvim-dap) usando treesitter.
| Antes                                                                                                           | Después                                                                                                         |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Requisitos
* Neovim 0.9 o posterior
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Configuración
Instala el plugin y los requisitos usando tu método favorito. Una vez instalado, asegúrate de configurar el [resaltado](https://github.com/nvim-treesitter/nvim-treesitter#modules) de treesitter y luego añade lo siguiente a tu configuración lua
```lua
require('nvim-dap-repl-highlights').setup()
```
Después de configurar inicialmente el complemento, es necesario instalar el analizador dap_repl, esto se puede hacer manualmente ejecutando `:TSInstall dap_repl`.

O automáticamente a través de la configuración de Treesitter:

**Usando `ensure_installed` (rama master de nvim-treesitter)**
> ⚠️ **NOTA:** Debes llamar a nvim-dap-repl-highlights.setup() antes de Treesitter, o no se encontrará el analizador dap_repl.
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter.configs').setup {
  highlight = {
    enable = true,
  },
  ensure_installed = { 'dap_repl', ... },
  ...
}
```
**Uso de `nvim-treesitter.install` (rama principal de nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Si esto deja de funcionar o la API cambia, consulta la documentación oficial de Treesitter para el método de instalación más reciente:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Uso
Por defecto, el plugin detecta el lenguaje a usar en el REPL observando el **tipo de archivo** utilizado para lanzar dap. Obviamente, para tener resaltado de sintaxis para cierto lenguaje necesitarás tener un parser de treesitter para ese lenguaje, junto con el parser `dap_repl`.
Esto puede no ajustarse a todos los casos de uso.

En su lugar, podrías usar el comando `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` que establecerá los resaltados de python en el buffer REPL actual.
Alternativamente, la función puede llamarse sin especificar el lenguaje, lo que solicitará al usuario un lenguaje.

Adicionalmente podrías especificar en la configuración de **dap** el lenguaje del repl a usar, por ejemplo si quieres que tu repl de python tenga resaltado de javascript:
```lua
local dap = require('dap')
dap.configurations.python = {
  {
    name = "Python with javascript repl because I like to watch the world burn 🔥🔥🔥",
    type = "python",
    request = "launch",
    program = "${file}",
    repl_lang = "javascript"
  },
}
```
La opción repl_lang tiene prioridad sobre el tipo de archivo.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---