# telescope-tabs
在 neovim 中飞速切换标签页 ✈️

<p align="center">
	<img src="https://github.com/LukasPietzschmann/telescope-tabs/assets/49213919/e749d458-4ffd-4af2-aba9-86d0e3fb4862" width="300px" />
</p>

## 重要提示
如果你不想使用 telescope，也有一个版本使用 `vim.ui.select` 替代 telescope。请查看 [`vim_ui_select`](https://github.com/LukasPietzschmann/telescope-tabs/tree/vim_ui_select) 分支 :)

## 使用方法
你可以通过在 neovim 的命令行执行来显示选择器
```
:Telescope telescope-tabs list_tabs
```
或者直接从插件的路径用 lua

```viml
:lua require('telescope-tabs').list_tabs()
```
你可以在选择器中的任意条目上按 `C-d`（插入模式）或 `D`（普通模式）来关闭标签页（分别关闭其中的所有窗口）。要更改按键绑定，请查看 [configure](https://github.com/LukasPietzschmann/telescope-tabs#configure)。
<p align="center">
	<img src="https://user-images.githubusercontent.com/49213919/216813167-45ca1908-b15f-4904-a441-6420d82dcb16.png" width="550"  />
</p>

但 `telescope-tabs` 不仅仅提供选择器！你还可以调用

```viml
:lua require('telescope-tabs').go_to_previous()
```
立即切换到最后打开的标签页。  
这不仅适用于使用此扩展切换标签页时，也适用于使用 Neovim 内置的标签页切换方法时。  

此插件在已有的 `g<Tab>` 快捷键基础上进行了改进，通过维护一个“最近显示标签页栈”。因此，如果关闭了最近访问的标签页，`g<Tab>` 将失效。然而，telescope-tabs 会愉快地显示倒数第二个标签页。  

如果你想经常使用此功能，建议绑定一个快捷键 :^)  


## 安装  
使用你喜欢的 Neovim 包管理器进行安装。  

使用 lazy.nvim 的示例：
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

packer.nvim 示例：
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
## 配置
不同的配置可以在 [configs wiki](https://github.com/LukasPietzschmann/telescope-tabs/wiki/Configs#configs) 中查看。欢迎添加你自己的配置！

如果你想自定义配置，可以调整以下设置：

### entry_formatter
这会改变标签在选择器中的显示方式。默认使用以下函数：
```lua
entry_formatter = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	local entry_string = table.concat(file_names, ', ')
	return string.format('%d: %s%s', tab_id, entry_string, is_current and ' <' or '')
end,
```
要更改此行为，只需分配您自己的函数。

### entry_ordinal
这会改变标签匹配的查询。默认使用以下函数：
```lua
entry_ordinal = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	return table.concat(file_names, ' ')
end,
```

### show_preview
这控制是否显示预览。默认值为 `true`：
```lua
show_preview = true,
```

### close_tab_shortcut
这些快捷键允许您直接从选择器关闭选定的标签页。默认设置是...
```lua
close_tab_shortcut_i = '<C-d>', -- if you're in insert mode
close_tab_shortcut_n = 'D',     -- if you're in normal mode
```
请注意，它们的值不会被解析或检查，因此它们应遵循键绑定的常规格式。

## 文档
请参阅 [telescope-tabs.txt](https://github.com/LukasPietzschmann/telescope-tabs/blob/master/doc/telescope-tabs.txt) 。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---