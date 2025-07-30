# smart_workspace_switcher.wezterm

Un commutateur intelligent d’espaces de travail Wezterm inspiré par [t-smart-tmux-session-manager](https://github.com/joshmedeski/t-smart-tmux-session-manager) et son successeur [sesh](https://github.com/joshmedeski/sesh)

## Utilisation

💨 Améliorez votre flux de travail en passant d’un espace de travail à un autre ⚡ ***ULTRA RAPIDEMENT*** ⚡ avec 1️⃣ seule pression de touche, la puissance de la recherche floue et zoxide ! 💨

![Demo gif](https://github.com/MLFlexer/smart_workspace_switcher.wezterm/assets/75012728/a4f82fcf-5304-4891-a1e2-346767678dc6)

## Dépendances

* zoxide

### Installation

1. Inclure le plugin :

    ```lua
    local wezterm = require("wezterm")
    local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
    ```

2. Appliquer le raccourci clavier par défaut à la configuration :

    ```lua
    workspace_switcher.apply_to_config(config)
    ```

Ou créez votre propre raccourci clavier, voir [Configuration - Raccourci clavier](#Keybinding).

### Configuration :
#### Raccourci clavier
Pour ajouter un raccourci clavier personnalisé :

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

#### Changer le nom de l’espace de travail par défaut
Vous pouvez définir un nom d’espace de travail par défaut :

```lua
config.default_workspace = "~"
```

#### Filtrage supplémentaire

Vous pouvez inclure `extra_args` dans l'appel à `switch_workspace` pour affiner davantage les résultats de la requête zoxide. Le `extra_args` est simplement une chaîne de caractères concaténée à la commande comme ceci : `zoxide query -l <extra_args>`. Par exemple, pour sélectionner des projets à partir d'une liste prédéfinie dans `~/.projects`, appelez le plugin ainsi :

  ```lua
  workspace_switcher.switch_workspace({ extra_args = " | rg -Fxf ~/.projects" })
  ```

#### Modifier les éléments du sélecteur flou

Vous pouvez modifier la liste des éléments du sélecteur flou en définissant une nouvelle fonction pour `get_choices` comme suit :

```lua
local workspace_switcher = wezterm.plugin.require("https://github.com/MLFlexer/smart_workspace_switcher.wezterm")
workspace_switcher.get_choices = function(opts)
  -- this will ONLY show the workspace elements, NOT the Zoxide results
  return workspace_switcher.choices.get_workspace_elements({})
end
```
Par défaut, la fonction utilise les fonctions suivantes pour créer une liste :


```lua
workspace_switcher.choices.get_workspace_elements({ id: string, label: string }[])
workspace_switcher.choices.get_zoxide_elements({ id: string, label: string }[], {extra_args?: string, workspace_ids?: workspace_ids}?)
```

#### Mise à jour du statut droit avec le chemin

Pour ajouter le chemin sélectionné à la barre d’état droite, utilisez l’événement `smart_workspace_switcher.workspace_switcher.chosen` émis lors du choix d’un espace de travail :

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

#### Événements

Les événements suivants sont disponibles et peuvent être utilisés pour déclencher un comportement personnalisé :

* `smart_workspace_switcher.workspace_switcher.start` - Déclenché lorsque le chercheur flou démarre.
* `smart_workspace_switcher.workspace_switcher.canceled` - Déclenché si aucun élément n'est choisi.
* `smart_workspace_switcher.workspace_switcher.selected` - Déclenché lorsqu'un élément est sélectionné.
* `smart_workspace_switcher.workspace_switcher.created` - Déclenché après la création et le changement vers un nouvel espace de travail.
* `smart_workspace_switcher.workspace_switcher.chosen` - Déclenché après le changement vers un espace de travail.
* `smart_workspace_switcher.workspace_switcher.switched_to_prev` - Déclenché après le changement vers un espace de travail précédent.

> [!NOTE]
> Les événements `created` et `chosen` émettent des objets [MuxWindow](https://wezfurlong.org/wezterm/config/lua/mux-window/) tandis que les autres émettent des objets [GuiWindow](https://wezfurlong.org/wezterm/config/lua/window/index.html).

Exemple d'utilisation :

  ```lua
  wezterm.on("smart_workspace_switcher.workspace_switcher.chosen", function(window, workspace)
    wezterm.log_info("THIS IS EMITTED FROM THE CALLBACK")
  end)
  ```

#### Formateur d’espace de travail

Définissez un formateur d’espace de travail personnalisé en utilisant l’exemple suivant. Pour plus d’informations, consultez la [documentation de formatage Wezterm](https://wezfurlong.org/wezterm/config/lua/wezterm/format.html) :

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

#### Chemin Zoxide

Pour définir un chemin personnalisé vers `zoxide` :

  ```lua
  workspace_switcher.zoxide_path = "/path/to/zoxide"
  ```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---