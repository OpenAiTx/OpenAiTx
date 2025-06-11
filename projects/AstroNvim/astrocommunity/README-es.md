<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Repositorio de la Comunidad AstroNvim</h1>

El repositorio de la comunidad de AstroNvim contiene especificaciones de configuración de plugins — una colección de plugins aportados por la comunidad para AstroNvim, una configuración de NeoVim. Estas especificaciones ayudan a gestionar la variedad de plugins usados en AstroNvim.

## 📦 Configuración

Para integrar los plugins de la comunidad, añade las configuraciones proporcionadas a tu configuración de `plugins`, preferiblemente antes de importar tus propios plugins para garantizar que todos los cambios de AstroCommunity se carguen antes de tus propias modificaciones. Si estás usando la [Plantilla AstroNvim](https://github.com/AstroNvim/template), esto puede hacerse en tu archivo `lua/community.lua`. Si no estás familiarizado con la configuración de plugins, recomendamos consultar la [documentación de AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Importando Plugins de AstroCommunity

Integra el siguiente contenido dentro de tu archivo `lua/community.lua`:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... importa aquí cualquier plugin aportado por la comunidad
}
```

### Personalizando Instalaciones de AstroCommunity

Una vez que tengas las importaciones de AstroCommunity definidas en tu `lua/community.lua`, puedes personalizar aún más las instalaciones en tus propias definiciones de plugins (normalmente en el directorio `lua/plugins/`). Aquí hay un ejemplo asumiendo que tienes instalado Catppuccin como se mostró arriba.

```lua
return {
  { -- personaliza más las opciones establecidas por la comunidad
    "catppuccin",
    opts = {
      integrations = {
        sandwich = false,
        noice = true,
        mini = true,
        leap = true,
        markdown = true,
        neotest = true,
        cmp = true,
        overseer = true,
        lsp_trouble = true,
        rainbow_delimiters = true,
      },
    },
  },
}
```

**Notas:**

- Para deshabilitar importaciones, establece la opción `enabled` en `false`. Tienes dos formas de modificar un plugin existente: usa el nombre completo del repositorio (por ejemplo, "m4xshen/smartcolumn.nvim") o el nombre del módulo (por ejemplo, "catppuccin"). Recuerda que el nombre del módulo puede diferir del nombre de la carpeta.
- Se recomienda usar la ruta completa de importación al personalizar un plugin, y no la notación abreviada que solo usa el nombre del repositorio.
- Puedes sobrescribir muchos aspectos de los plugins comunitarios, incluyendo configuraciones, dependencias y versiones. Para más detalles sobre las opciones disponibles, consulta la [documentación de lazy.nvim](https://lazy.folke.io/).

## Contribuir

Si has escrito una configuración de plugin y deseas añadirla al repositorio AstroCommunity, por favor sigue nuestras [Directrices de Contribución](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) y envía una solicitud de extracción. Asegúrate de haber probado rigurosamente tus cambios antes de enviarlos. Este no es un repositorio oficial, por lo que su estabilidad depende de las contribuciones de la comunidad. ¡Estamos entusiasmados de ver cómo crece y evoluciona este proyecto!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---