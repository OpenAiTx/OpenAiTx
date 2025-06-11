<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim 社区仓库</h1>

AstroNvim 的社区仓库包含插件配置规范——由社区贡献的一系列适用于 AstroNvim（一个 NeoVim 配置）的插件。这些规范帮助管理 AstroNvim 中使用的各种插件。

## 📦 安装

要集成社区插件，请将提供的配置添加到你的 `plugins` 设置中，最好在导入你自己的插件之前添加，以确保所有 AstroCommunity 的更改都在你的自定义覆盖之前加载。如果你正在使用 [AstroNvim 模板](https://github.com/AstroNvim/template)，可以在你的 `lua/community.lua` 文件中完成此操作。如果你不熟悉插件配置，建议参考 [AstroNvim 文档](https://docs.astronvim.com/configuration/customizing_plugins/)。

### 导入 AstroCommunity 插件

在你的 `lua/community.lua` 文件中集成以下内容：

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/astrocommunity.colorscheme.catppuccin" },
  -- ... 在此导入任何社区贡献的插件
}
```

### 自定义 AstroCommunity 安装

一旦你在 `lua/community.lua` 中定义了 AstroCommunity 的导入，就可以在你自己的插件定义中进一步自定义安装（通常在 `lua/plugins/` 目录中完成）。以下示例假设你已按上面示例安装了 Catppuccin。

```lua
return {
  { -- 进一步自定义社区设置的选项
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

**注意：**

- 要禁用导入，请将 `enabled` 选项设置为 `false`。修改已有插件时有两种方式：使用完整仓库名（例如 `"m4xshen/smartcolumn.nvim"`）或模块名（例如 `"catppuccin"`）。请注意，模块名可能与文件夹名不同。
- 推荐在自定义插件时使用完整的导入路径，而不是仅用仓库名的简写。
- 你可以覆盖社区插件的许多方面，包括设置、依赖和版本。更多可用选项请参考 [lazy.nvim 文档](https://lazy.folke.io/)。

## 贡献

如果你编写了插件配置并希望将其添加到 AstroCommunity 仓库，请遵循我们的[贡献指南](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md)并提交拉取请求。提交前请确保你已对更改进行了严格测试。此仓库不是官方仓库，其稳定性依赖社区贡献。我们期待看到这个项目如何成长和发展！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---