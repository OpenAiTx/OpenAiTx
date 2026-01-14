# brainrot.nvim

Boom de vigne quand une nouvelle erreur apparaît. Phonk + superposition sombre + image meme lorsque vous effacez la dernière erreur.


https://github.com/user-attachments/assets/e68578ee-69e5-4fc6-b45a-493a98e8d225


## Exigences
- Neovim 0.9+
- Lecteur audio
  - Linux : `paplay`, `ffplay` ou `mpv`
  - macOS/Windows : `ffplay` ou `mpv`
- [image.nvim](https://github.com/3rd/image.nvim) (Optionnel, pour les images)

## Installation (lazy.nvim)
```lua
{
  'sahaj-b/brainrot.nvim',
  event = 'VeryLazy',
  opts = {
    -- defaults:

    disable_phonk = false,    -- skip phonk/overlay on "no errors"
    phonk_time = 2.5,         -- seconds the phonk/image overlay stays
    min_error_duration = 0.5, -- minimum seconds errors must exist before phonk triggers (0 = instant)
    block_input = true,       -- block input during phonk/overlay
    dim_level = 60,           -- phonk overlay darkness 0..100

    sound_enabled = true,     -- enable sounds
    image_enabled = true,     -- enable images (needs image.nvim)

    boom_volume = 50,         -- volume for vine boom sound (0..100)
    phonk_volume = 50,        -- volume for phonk sound (0..100)

    boom_sound = nil,         -- custom boom sound path (e.g., "~/sounds/boom.ogg")
    phonk_dir = nil,          -- custom phonk folder path (e.g., "~/sounds/phonks")
    image_dir = nil,          -- custom image folder path (e.g., "~/memes/images")

    lsp_wide = false,         -- track errors workspace-wide(get ALL lsp errors)

  },
}
```

## Ce que ça fait
- Nouvelle erreur détectée : joue Vine Boom une fois.
- Passage de "avait des erreurs" à "pas d'erreurs" : joue un morceau de phonk aléatoire et affiche un PNG aléatoire, avec une superposition plein écran tamisée (bloquant éventuellement les entrées) pendant `phonk_time` secondes.
- Ne se déclenche qu'en mode Normal (ne s'active pas pendant la frappe). Il se met à jour lors de `DiagnosticChanged` et des changements de mode vers/depuis Normal.

### mode lsp_wide
Lorsque `lsp_wide = true`, il suit TOUTES les erreurs dans l'espace de travail, pas seulement le tampon actuel (si votre lsp le supporte)
- Le phonk ne joue que lorsque **TOUTES** les erreurs dans l'espace de travail sont effacées, pas seulement dans le fichier en cours.
- Le Vine boom joue lorsqu'une nouvelle erreur apparaît n'importe où dans l'espace de travail.

## Commandes
- `:Brainrot boom` : déclenche le son vine boom maintenant
- `:Brainrot boom toggle` : active/désactive les sons boom
- `:Brainrot boom enable` : active les sons boom
- `:Brainrot boom disable` : désactive les sons boom
- `:Brainrot phonk` : déclenche la superposition + phonk aléatoire maintenant
- `:Brainrot phonk toggle` : active/désactive le phonk automatique
- `:Brainrot phonk enable` : active le phonk automatique
- `:Brainrot phonk disable` : désactive le phonk automatique

## Utilisation de l'API
Vous pouvez utiliser les fonctions de brainrot directement dans votre configuration ou d'autres plugins. Obtenez le module et appelez l'une de ces fonctions :

```lua
local brainrot = require('brainrot')

-- Trigger the phonk overlay + random phonk sound
brainrot.phonk()

-- Trigger vine boom sound
brainrot.boom()

-- Toggle/enable/disable boom sounds
brainrot.toggle_boom()
brainrot.enable_boom()
brainrot.disable_boom()

-- Toggle/enable/disable auto-phonk
brainrot.toggle_phonk()
brainrot.enable_phonk()
brainrot.disable_phonk()
```

### Exemple : Phonk à l'enregistrement du fichier
```lua
-- inside init.lua
vim.api.nvim_create_autocmd('BufWritePost', {
  callback = function()
    require('brainrot').phonk()
  end,
})
```

## Problèmes connus
- Lorsque vous appuyez sur `<CR>` (Entrée) à l’intérieur d’une paire de crochets comme `{|}` pour l’auto-extension en bloc (lors de l’utilisation d’un plugin autopair), cela détecte des erreurs et joue un effet sonore vine boom. La solution consiste à désactiver l’auto-extension (par ex. : `map_cr = false` dans `nvim-autopairs`).

## ...POURQUOI ?
[parce que pourquoi pas](https://x.com/sahaj__b/status/1981749009350811966)

## Licence
MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---