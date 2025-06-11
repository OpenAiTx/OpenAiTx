<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Dépôt Communautaire AstroNvim</h1>

Le dépôt communautaire d'AstroNvim contient des spécifications de configuration de plugins — une collection de plugins fournis par la communauté pour AstroNvim, une configuration de NeoVim. Ces spécifications aident à gérer la variété des plugins utilisés dans AstroNvim.

## 📦 Installation

Pour intégrer les plugins communautaires, ajoutez les configurations fournies à votre setup `plugins`, de préférence avant d'importer vos propres plugins afin de garantir que toutes les modifications d'AstroCommunity sont chargées avant vos propres surcharges. Si vous utilisez le [Template AstroNvim](https://github.com/AstroNvim/template), cela peut être fait dans votre fichier `lua/community.lua`. Si vous n'êtes pas familier avec la configuration des plugins, nous recommandons de consulter la [documentation AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Importer les plugins AstroCommunity

Intégrez le contenu suivant dans votre fichier `lua/community.lua` :

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... importez ici tous les plugins contribué par la communauté
}
```

### Personnaliser les installations AstroCommunity

Une fois que vous avez défini les imports AstroCommunity dans votre `lua/community.lua`, vous pouvez ensuite personnaliser davantage les installations dans vos propres définitions de plugins (généralement dans le répertoire `lua/plugins/`). Voici un exemple en supposant que vous avez installé Catppuccin comme montré ci-dessus.

```lua
return {
  { -- personnaliser davantage les options définies par la communauté
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

**Notes :**

- Pour désactiver des imports, définissez l'option `enabled` à `false`. Vous avez deux approches pour modifier un plugin existant : utilisez le nom complet du dépôt (par exemple, "m4xshen/smartcolumn.nvim") ou le nom du module (par exemple, "catppuccin"). Notez que le nom du module peut différer du nom du dossier.
- Il est recommandé d'utiliser le chemin complet d'importation lors de la personnalisation d'un plugin, et non la notation abrégée avec seulement le nom du dépôt.
- Vous pouvez surcharger de nombreux aspects des plugins communautaires, y compris les réglages, dépendances et versions. Pour plus de détails sur les options disponibles, référez-vous à la [documentation lazy.nvim](https://lazy.folke.io/).

## Contribution

Si vous avez écrit une configuration de plugin et souhaitez l'ajouter au dépôt AstroCommunity, veuillez suivre nos [Lignes Directrices de Contribution](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) et soumettre une pull request. Assurez-vous d'avoir testé rigoureusement vos modifications avant de les soumettre. Ce n'est pas un dépôt officiel, donc sa stabilité dépend des contributions de la communauté. Nous sommes impatients de voir comment ce projet grandira et évoluera !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---