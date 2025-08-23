# telescope-tabs
Parcourez vos onglets dans neovim ✈️

<p align="center">
	<img src="https://github.com/LukasPietzschmann/telescope-tabs/assets/49213919/e749d458-4ffd-4af2-aba9-86d0e3fb4862" width="300px" />
</p>

## Note importante
Si vous ne souhaitez pas utiliser telescope, il existe également une version utilisant `vim.ui.select` au lieu de telescope. Consultez la branche [`vim_ui_select`](https://github.com/LukasPietzschmann/telescope-tabs/tree/vim_ui_select) :)

## Utilisation
Vous pouvez afficher le sélecteur depuis la ligne de commande de neovim en exécutant
```
:Telescope telescope-tabs list_tabs
```
Ou directement depuis le chemin du plugin avec lua

```viml
:lua require('telescope-tabs').list_tabs()
```

Vous pouvez appuyer sur `C-d` (mode insertion) ou `D` (mode normal) sur n’importe quel élément dans le sélecteur pour fermer l’onglet (respectivement toutes les fenêtres qu’il contient). Pour changer le raccourci, consultez [configure](https://github.com/LukasPietzschmann/telescope-tabs#configure).
<p align="center">
	<img src="https://user-images.githubusercontent.com/49213919/216813167-45ca1908-b15f-4904-a441-6420d82dcb16.png" width="550"  />
</p>

Mais `telescope-tabs` ne fournit pas uniquement un sélecteur ! Vous pouvez aussi appeler
```viml
:lua require('telescope-tabs').go_to_previous()
```
pour basculer immédiatement vers l’onglet ouvert en dernier.
Cela fonctionne non seulement lors du changement d’onglets avec cette extension, mais aussi lorsque vous utilisez les méthodes intégrées de déplacement d’onglets de Neovim.

Ce plugin améliore le raccourci déjà présent `g<Tab>` en gardant une trace d’une « pile des derniers onglets affichés ». Par conséquent, si vous fermez l’onglet visité en dernier, `g<Tab>` échouera. Cependant, telescope-tabs affichera volontiers l’avant-dernier onglet.

Je recommande de lier ceci à un raccourci si vous souhaitez l’utiliser régulièrement :^)


## Installation
Installez avec votre gestionnaire de paquets Neovim préféré.

Exemple avec lazy.nvim :
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

Exemple avec packer.nvim :
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
## Configurer
Différentes configurations peuvent être consultées dans le [wiki des configs](https://github.com/LukasPietzschmann/telescope-tabs/wiki/Configs#configs). N'hésitez pas à ajouter la vôtre !

Si vous souhaitez créer votre propre configuration, voici les paramètres que vous pouvez ajuster :

### entry_formatter
Cela modifie la façon dont un onglet est représenté dans le sélecteur. Par défaut, la fonction suivante est utilisée :
```lua
entry_formatter = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	local entry_string = table.concat(file_names, ', ')
	return string.format('%d: %s%s', tab_id, entry_string, is_current and ' <' or '')
end,
```
Pour modifier ce comportement, il suffit d’assigner votre propre fonction.

### entry_ordinal
Cela modifie les requêtes auxquelles un onglet correspond. La fonction suivante est utilisée par défaut :
```lua
entry_ordinal = function(tab_id, buffer_ids, file_names, file_paths, is_current)
	return table.concat(file_names, ' ')
end,
```

### show_preview
Cela contrôle si un aperçu est affiché ou non. La valeur par défaut est `true` :
```lua
show_preview = true,
```

### close_tab_shortcut
Ces raccourcis vous permettent de fermer un onglet sélectionné directement depuis le sélecteur. Les valeurs par défaut sont...
```lua
close_tab_shortcut_i = '<C-d>', -- if you're in insert mode
close_tab_shortcut_n = 'D',     -- if you're in normal mode
```
Notez que leur valeur n'est pas analysée ni vérifiée, elles doivent donc suivre le format régulier pour les raccourcis clavier.

## Documentation
Voir [telescope-tabs.txt](https://github.com/LukasPietzschmann/telescope-tabs/blob/master/doc/telescope-tabs.txt).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---