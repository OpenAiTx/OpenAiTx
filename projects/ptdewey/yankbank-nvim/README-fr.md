# YankBank

Un plugin Neovim pour garder une trace des yanks et suppressions les plus récents et les exposer dans un menu d’accès rapide.

## Ce qu’il fait

YankBank stocke les N derniers yanks dans le registre non nommé ("), puis remplit une fenêtre popup avec ces yanks récents, permettant un accès rapide à l’historique des yanks récents.  
Lors de l’ouverture du menu popup, le contenu actuel du registre unnamedplus (+) est également ajouté au menu (s’il est différent du contenu actuel du registre non nommé).

Choisir une entrée dans le menu (en appuyant sur entrée) la collera dans le buffer ouvert à la position du curseur.

YankBank offre également une persistance entre les sessions, ce qui signifie que vous ne perdrez pas vos yanks après avoir fermé et rouvert une session (voir [persistance](#Persistence)).

### Captures d’écran

![Fenêtre popup YankBank zoomée](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/assets/screenshot-2.png)

Le menu est spécifique à la session en cours, et ne contiendra que le contenu du registre unnamedplus actuel à l’ouverture dans une toute nouvelle session.  
Il sera ensuite complété pour chaque yank ou suppression dans cette session.

## Installation et configuration

#### Avec persistance (recommandé)

Utilisation de lazy.nvim
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

#### Sans persistance :

Utilisation de lazy.nvim
```lua
{
    "ptdewey/yankbank-nvim",
    cmd = { "YankBank" },
    config = function()
        require('yankbank').setup()
    end,
}
```

#### Chargement paresseux

Selon les [meilleures pratiques](https://github.com/nvim-neorocks/nvim-best-practices?tab=readme-ov-file#sleeping_bed-lazy-loading), l'empreinte d'initialisation de YankBank est très minimale, et les fonctionnalités ne sont chargées que lorsqu'elles sont nécessaires. Ainsi, j'ai défini `lazy=false` dans ma configuration, et j'obtiens un temps de démarrage de <1ms.

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

Si vous ne souhaitez pas charger YankBank au démarrage, je l'ai précédemment chargé lors des pressions sur les touches qui copient du texte (`y`, `Y`, `d`, `D`, `x`), lors de l'événement `FocusGained`, et avec la commande `YankBank`.
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


### Options de configuration

La fonction de configuration prend également en charge une table d’options :
| Option | Type | Par défaut |
|-------------|--------------------------------------------|----------------|
| max_entries | nombre entier d’entrées à afficher dans le popup | `10` |
| sep | séparateur de chaîne à afficher entre les entrées du tableau | `"-----"` |
| keymaps | table contenant les remplacements des raccourcis clavier | `{}` |
| keymaps.navigation_next | chaîne | `"j"` |
| keymaps.navigation_prev | chaîne | `"k"` |
| keymaps.paste | chaîne | `"<CR>"` |
| keymaps.paste_back | chaîne | `"P"` |
| keymaps.yank | chaîne | `"yy"` |
| keymaps.close | table de chaînes | `{ "<Esc>", "<C-c>", "q" }` |
| num_behavior | chaîne définissant le comportement de saut "prefix" ou "jump" | `"prefix"` |
| focus_gain_poll | booléen | `false` |
| registers | table contenant les remplacements des registres | `{ }` |
| registers.yank_register | registre par défaut pour copier depuis le popup vers | `"+"` |
| persist_type | chaîne définissant le type de persistance "sqlite" ou nil | `nil` |
| db_path | chaîne définissant le chemin du fichier de base de données pour l’utilisation avec la persistance sqlite | répertoire d’installation du plugin |
| bind_indices | chaîne optionnelle à utiliser comme préfixe de raccourci pour coller par numéro d’index (ex. "<leader>p") | `nil` |


#### Exemple de configuration

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

Si aucun séparateur n'est souhaité, passez une chaîne vide pour `sep`

L'option 'num_behavior' définit le comportement de navigation dans la popup lors de la pression des touches numériques.
- `num_behavior = "prefix"` fonctionne de manière similaire à la navigation traditionnelle vim avec '3j' qui descend de 3 entrées dans la banque.
- `num_behavior = "jump"` saute à l'entrée correspondant à la touche numérique pressée (c.-à-d. '3' saute à l'entrée 3)
    - Remarque : Si 'max_entries' est un nombre à deux chiffres, il y aura un délai lors de la pression de chiffres qui préfixent une entrée valide.

L'option 'focus_gain_poll' permet d'activer un autocommand supplémentaire qui surveille les gains de focus (re-focalisation de la fenêtre Neovim), et vérifie les changements dans le registre unnamedplus ('+'), ajoutant à yankbank lorsque de nouveaux contenus sont détectés. Cela permet d'ajouter automatiquement du texte copié depuis d'autres sources (comme un navigateur) à la yankbank sans déclencher l'ouverture de la banque. Désactivé par défaut, mais je recommande fortement de l'activer avec `focus_gain_poll = true`.

### Persistance
Pour une meilleure expérience avec YankBank, il est fortement recommandé d'activer la persistance.
Si la persistance est activée, sqlite.lua sera utilisé pour créer un stockage persistant des yanks récents dans le répertoire racine du plugin.
Pour utiliser la persistance sqlite, `"kkharji/sqlite.lua"` doit être ajouté comme dépendance dans votre configuration, et `persist_type` doit être défini sur `"sqlite"`:

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

Note : La base de données peut être effacée avec la commande `:YankBankClearDB` ou en supprimant le fichier db (trouvé dans le répertoire d'installation du plugin par défaut).

Si vous rencontrez des problèmes liés à SQL, veuillez ouvrir un ticket sur GitHub. (Comme solution temporaire, vous pouvez aussi essayer de vider la base de données)


Si vous rencontrez des problèmes de permissions lors de la création du fichier db (par exemple lors de l'installation avec Nix), utilisez l'option `db_path` pour changer le chemin de fichier par défaut. (`vim.fn.stdpath("data")` devrait fonctionner)

## Utilisation

Le menu popup peut être ouvert avec la commande : `:YankBank`, une entrée est collée à la position actuelle du curseur en appuyant sur entrée, et le menu peut être fermé en appuyant sur échappement, ctrl-c, ou q.
Une entrée du menu peut aussi être copiée dans le registre unnamedplus en appuyant sur yy.

Je recommanderais personnellement aussi de définir un raccourci clavier pour ouvrir le menu.
```lua
-- map to '<leader>y'
vim.keymap.set("n", "<leader>y", "<cmd>YankBank<CR>", { noremap = true })
```

---

## API (EN COURS)

Certaines parties internes du plugin sont également accessibles via l'API YankBank.

Exemples :
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

Pour plus de détails sur l'API, voir [lua/yankbank/api.lua](https://raw.githubusercontent.com/ptdewey/yankbank-nvim/main/lua/yankbank/api.lua)

---

## Améliorations potentielles
- intégration nvim-cmp
- intégration fzf
- intégration telescope

## Alternatives

- [nvim-neoclip](https://github.com/AckslD/nvim-neoclip.lua)
- [yanky.nvim](https://github.com/gbprod/yanky.nvim)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---