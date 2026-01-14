# brainrot.nvim

Explosión de vid cuando aparece un nuevo error. Phonk + superposición tenue + imagen meme cuando borras el último error.


https://github.com/user-attachments/assets/e68578ee-69e5-4fc6-b45a-493a98e8d225


## Requisitos
- Neovim 0.9+
- Reproductor de audio
  - Linux: `paplay`, `ffplay` o `mpv`
  - macOS/Windows: `ffplay` o `mpv`
- [image.nvim](https://github.com/3rd/image.nvim) (Opcional, para imágenes)

## Instalación (lazy.nvim)
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

## Qué hace
- Nuevo error detectado: reproduce Vine Boom una vez.
- Pasó de "tener errores" a "sin errores": reproduce una pista phonk aleatoria y muestra un PNG aleatorio, con una superposición tenue en pantalla completa (opcionalmente bloqueando entradas) durante `phonk_time` segundos.
- Solo se activa en modo Normal (no se activa mientras escribes). Se actualiza en `DiagnosticChanged` y en los cambios de modo hacia/fuera de Normal.

### modo lsp_wide
Cuando `lsp_wide = true`, rastrea TODOS los errores en el espacio de trabajo, no solo el búfer actual (si tu lsp lo soporta)
- Phonk solo se reproduce cuando se eliminan **TODOS** los errores en el espacio de trabajo, no solo en el archivo actual.
- Vine boom se reproduce cuando aparece un nuevo error en cualquier parte del espacio de trabajo.

## Comandos
- `:Brainrot boom`: reproduce el sonido vine boom ahora
- `:Brainrot boom toggle`: alternar sonidos boom activados/desactivados
- `:Brainrot boom enable`: activar sonidos boom
- `:Brainrot boom disable`: desactivar sonidos boom
- `:Brainrot phonk`: activar la superposición + phonk aleatorio ahora
- `:Brainrot phonk toggle`: alternar auto-phonk activado/desactivado
- `:Brainrot phonk enable`: activar auto-phonk
- `:Brainrot phonk disable`: desactivar auto-phonk

## Uso de la API
Puedes usar las funciones de brainrot directamente en tu configuración u otros plugins. Obtén el módulo y llama cualquiera de estos:

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

### Ejemplo: Phonk al guardar el archivo
```lua
-- inside init.lua
vim.api.nvim_create_autocmd('BufWritePost', {
  callback = function()
    require('brainrot').phonk()
  end,
})
```

## Problemas conocidos
- Al presionar `<CR>` (Enter) dentro de un par de corchetes como `{|}` para autoexpandir en un bloque (al usar un plugin de autoparejas), detectará errores y reproducirá un sonido de explosión de vid. La solución es desactivar la autoexpansión (por ejemplo: `map_cr = false` en `nvim-autopairs`).

## ...¿POR QUÉ?
[porque sí](https://x.com/sahaj__b/status/1981749009350811966)

## Licencia
MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---