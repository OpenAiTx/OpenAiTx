# telescope-tabs
neovimでタブを高速に切り替え ✈️

<p align="center">
	<img src="https://github.com/LukasPietzschmann/telescope-tabs/assets/49213919/e749d458-4ffd-4af2-aba9-86d0e3fb4862" width="300px" />
</p>

## 重要な注意点
telescopeを使いたくない場合は、telescopeの代わりに`vim.ui.select`を使ったバージョンもあります。[`vim_ui_select`](https://github.com/LukasPietzschmann/telescope-tabs/tree/vim_ui_select)ブランチをチェックしてください :)

## 使い方
neovimのコマンドラインからピッカーを表示するには以下を実行します
```
:Telescope telescope-tabs list_tabs
```
または lua を使ってプラグインのパスから直接読み込みます

```viml
:lua require('telescope-tabs').list_tabs()
```

ピッカー内の任意のアイテムで `C-d`（挿入モード）または `D`（ノーマルモード）を押すとタブを閉じることができます（それぞれその中のすべてのウィンドウを閉じます）。キー割り当てを変更するには、[configure](https://github.com/LukasPietzschmann/telescope-tabs#configure) を参照してください。
<p align="center">
	<img src="https://user-images.githubusercontent.com/49213919/216813167-45ca1908-b15f-4904-a441-6420d82dcb16.png" width="550"  />
</p>

しかし `telescope-tabs` は単にピッカーを提供するだけではありません！呼び出すこともできます
```viml
:lua require('telescope-tabs').go_to_previous()
```
最後に開いたタブに即座に切り替えます。  
これはこの拡張機能でタブを切り替える場合だけでなく、Neovimの組み込みタブ移動方法を使用するときにも機能します。  

このプラグインは、既に存在する `g<Tab>` ショートカットを改良し、「最後に表示したタブのスタック」を記録します。  
したがって、最も最近訪れたタブを閉じると `g<Tab>` は失敗しますが、telescope-tabs は喜んで2番目に最後のタブを表示します。  

これを定期的に使用したい場合はショートカットに割り当てることをお勧めします :^)  


## インストール  
お好みのNeovimパッケージマネージャーでインストールしてください。  

lazy.nvimの例:
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

packer.nvimの例:
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
## 設定
さまざまな設定は[configs wiki](https://github.com/LukasPietzschmann/telescope-tabs/wiki/Configs#configs)で確認できます。自由に自分の設定を追加してください！

独自の設定を考えたい場合は、調整できる設定は以下の通りです：

### entry_formatter
これはピッカー内でのタブの表示方法を変更します。デフォルトでは以下の関数が使用されます：
```lua
entry_formatter = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	local entry_string = table.concat(file_names, ', ')
	return string.format('%d: %s%s', tab_id, entry_string, is_current and ' <' or '')
end,
```
この動作を変更するには、自分の関数を割り当ててください。

### entry_ordinal
これはタブが一致するクエリを変更します。デフォルトで使用される関数は次のとおりです。
```lua
entry_ordinal = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	return table.concat(file_names, ' ')
end,
```

### show_preview
これはプレビューを表示するかどうかを制御します。デフォルトは`true`です：
```lua
show_preview = true,
```

### close_tab_shortcut
これらのショートカットは、ピッカーから選択したタブを閉じることを可能にします。デフォルトは...
```lua
close_tab_shortcut_i = '<C-d>', -- if you're in insert mode
close_tab_shortcut_n = 'D',     -- if you're in normal mode
```
値は解析やチェックされないため、キーバインディングの通常の形式に従う必要があることに注意してください。

## ドキュメント
[telescope-tabs.txt](https://github.com/LukasPietzschmann/telescope-tabs/blob/master/doc/telescope-tabs.txt) を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---