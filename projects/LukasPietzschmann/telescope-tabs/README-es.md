# telescope-tabs
Vuela a través de tus pestañas en neovim ✈️

<p align="center">
	<img src="https://github.com/LukasPietzschmann/telescope-tabs/assets/49213919/e749d458-4ffd-4af2-aba9-86d0e3fb4862" width="300px" />
</p>

## Nota importante
Si no quieres usar telescope, también hay una versión que usa `vim.ui.select` en lugar de telescope. Consulta la rama [`vim_ui_select`](https://github.com/LukasPietzschmann/telescope-tabs/tree/vim_ui_select) :)

## Uso
Puedes mostrar el selector desde la línea de comandos de neovim ejecutando
```
:Telescope telescope-tabs list_tabs
```
O directamente desde la ruta del plugin con lua

```viml
:lua require('telescope-tabs').list_tabs()
```
Puedes presionar `C-d` (modo insertar) o `D` (modo normal) en cualquier elemento del selector para cerrar la pestaña (respectivamente todas las ventanas en ella). Para cambiar la combinación de teclas, consulta [configurar](https://github.com/LukasPietzschmann/telescope-tabs#configure).
<p align="center">
	<img src="https://user-images.githubusercontent.com/49213919/216813167-45ca1908-b15f-4904-a441-6420d82dcb16.png" width="550"  />
</p>

¡Pero `telescope-tabs` no solo proporciona un selector! También puedes llamar

```viml
:lua require('telescope-tabs').go_to_previous()
```
para cambiar inmediatamente a la última pestaña abierta.
Esto no solo funciona al cambiar de pestañas con esta extensión, sino también cuando usas los métodos integrados de movimiento de pestañas de Neovim.

Este plugin mejora el atajo ya existente `g<Tab>` al mantener un seguimiento de una "pila de pestañas mostradas recientemente". En consecuencia, si cierras la pestaña visitada más recientemente, `g<Tab>` fallará. Sin embargo, telescope-tabs mostrará encantado la penúltima pestaña.

Recomendaría asignar esto a un atajo si quieres usarlo regularmente :^)


## Instalación
Instala con tu gestor de paquetes favorito de Neovim.

Ejemplo con lazy.nvim:
```lua
{
	'LukasPietzschmann/telescope-tabs',
	config = function()
		require('telescope').load_extension 'telescope-tabs'
		require('telescope-tabs').setup {
			-- Your custom config :^)
		}
	end,
	dependencies = { 'nvim-telescope/telescope.nvim' },
}
```
Ejemplo con packer.nvim:

```lua
use {
	'LukasPietzschmann/telescope-tabs',
	requires = { 'nvim-telescope/telescope.nvim' },
	config = function()
		require'telescope-tabs'.setup{
			-- Your custom config :^)
		}
	end
}
```
## Configurar
Se pueden ver diferentes configuraciones en el [wiki de configs](https://github.com/LukasPietzschmann/telescope-tabs/wiki/Configs#configs). ¡No dudes en agregar la tuya!

Si quieres crear tu propia configuración, estos son los ajustes que puedes modificar:

### entry_formatter
Esto cambia cómo se representa una pestaña en el selector. Por defecto se usa la siguiente función:
```lua
entry_formatter = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	local entry_string = table.concat(file_names, ', ')
	return string.format('%d: %s%s', tab_id, entry_string, is_current and ' <' or '')
end,
```
Para alterar este comportamiento, simplemente asigne su propia función.

### entry_ordinal
Esto cambia qué consultas coincide una pestaña. La siguiente función se usa por defecto:
```lua
entry_ordinal = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	return table.concat(file_names, ' ')
end,
```

### show_preview
Esto controla si se muestra una vista previa o no. El valor predeterminado es `true`:
```lua
show_preview = true,
```

### close_tab_shortcut
Estos atajos te permiten cerrar una pestaña seleccionada directamente desde el selector. Los valores predeterminados son...
```lua
close_tab_shortcut_i = '<C-d>', -- if you're in insert mode
close_tab_shortcut_n = 'D',     -- if you're in normal mode
```
Tenga en cuenta que su valor no se analiza ni verifica, por lo que deben seguir el formato habitual para asignaciones de teclas.

## Documentación
Consulte [telescope-tabs.txt](https://github.com/LukasPietzschmann/telescope-tabs/blob/master/doc/telescope-tabs.txt).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---