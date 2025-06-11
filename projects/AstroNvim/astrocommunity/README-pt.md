<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Repositório da Comunidade AstroNvim</h1>

O repositório da comunidade AstroNvim contém especificações de configuração de plugins — uma coleção de plugins contribuídos pela comunidade para o AstroNvim, uma configuração do NeoVim. Essas especificações ajudam a gerenciar a variedade de plugins usados no AstroNvim.

## 📦 Configuração

Para integrar os plugins da comunidade, adicione as configurações fornecidas ao seu setup de `plugins`, preferencialmente antes de importar seus próprios plugins para garantir que todas as alterações do AstroCommunity sejam carregadas antes das suas próprias sobrescritas. Se você estiver usando o [Template AstroNvim](https://github.com/AstroNvim/template), isso pode ser feito no seu arquivo `lua/community.lua`. Se você não estiver familiarizado com a configuração de plugins, recomendamos consultar a [documentação do AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Importando Plugins do AstroCommunity

Integre o seguinte conteúdo no seu arquivo `lua/community.lua`:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... importe aqui quaisquer plugins contribuídos pela comunidade
}
```

### Personalizando Instalações do AstroCommunity

Depois de definir as importações do AstroCommunity no seu `lua/community.lua`, você pode personalizar ainda mais as instalações nas suas próprias definições de plugins (normalmente feitas no diretório `lua/plugins/`). Aqui está um exemplo assumindo que você tenha o Catppuccin instalado como mostrado acima.

```lua
return {
  { -- personaliza ainda mais as opções definidas pela comunidade
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

- Para desabilitar importações, defina a opção `enabled` como `false`. Você tem duas abordagens para modificar um plugin existente: use o nome completo do repositório (ex.: "m4xshen/smartcolumn.nvim") ou o nome do módulo (ex.: "catppuccin"). Lembre-se, o nome do módulo pode diferir do nome da pasta.
- Recomenda-se usar o caminho completo da importação ao personalizar um plugin, e não a notação abreviada apenas com o nome do repositório.
- Você pode sobrescrever muitos aspectos dos plugins da comunidade, incluindo configurações, dependências e versões. Para mais detalhes sobre as opções disponíveis, consulte a [documentação do lazy.nvim](https://lazy.folke.io/).

## Contribuindo

Se você escreveu uma configuração de plugin e deseja adicioná-la ao repositório AstroCommunity, por favor siga nossas [Diretrizes de Contribuição](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) e envie um pull request. Certifique-se de ter testado rigorosamente suas alterações antes da submissão. Este não é um repositório oficial, portanto sua estabilidade depende das contribuições da comunidade. Estamos entusiasmados para ver como este projeto cresce e evolui!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---