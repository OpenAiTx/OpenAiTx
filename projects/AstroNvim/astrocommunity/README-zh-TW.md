<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim 社群資源庫</h1>

AstroNvim 的社群資源庫包含插件配置規範 — 這是一組由社群貢獻給 AstroNvim（一個 NeoVim 配置）的插件合集。這些規範有助於管理 AstroNvim 使用的各種插件。

## 📦 安裝設定

要整合社群插件，請將提供的配置加入你的 `plugins` 設定中，最好放在你自己的插件導入之前，以確保所有 AstroCommunity 的更改先於你的覆寫加載。如果你使用的是 [AstroNvim 範本](https://github.com/AstroNvim/template)，這可在你的 `lua/community.lua` 檔案中完成。如果你不熟悉插件配置，建議參考 [AstroNvim 文件](https://docs.astronvim.com/configuration/customizing_plugins/)。

### 導入 AstroCommunity 插件

將以下內容整合到你的 `lua/community.lua` 檔案中：

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/astrocommunity.colorscheme.catppuccin" },
  -- ... 在此導入任何社群貢獻的插件
}
```

### 自訂 AstroCommunity 插件安裝

當你在 `lua/community.lua` 中定義了 AstroCommunity 的導入後，接著可以在自己的插件定義中進一步自訂安裝（通常在 `lua/plugins/` 目錄下）。以下範例假設你已如上所示安裝了 Catppuccin。

```lua
return {
  { -- 進一步自訂社群設定的選項
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

**注意事項：**

- 若要停用導入，請將 `enabled` 選項設為 `false`。修改現有插件有兩種方式：使用完整的倉庫名稱（例如 "m4xshen/smartcolumn.nvim"）或模組名稱（例如 "catppuccin"）。請記得，模組名稱可能與資料夾名稱不同。
- 建議在自訂插件時使用完整的導入路徑，而非僅使用倉庫名稱的簡寫。
- 你可以覆寫社群插件的許多部分，包括設定、依賴和版本。更多可用選項請參閱 [lazy.nvim 文件](https://lazy.folke.io/)。

## 貢獻指南

如果你撰寫了插件配置並希望將其加入 AstroCommunity 資源庫，請遵循我們的 [貢獻指南](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) 並提交拉取請求。請確保你在提交前已充分測試你的變更。這不是官方資源庫，因此其穩定性依賴社群貢獻。我們期待看到這個專案的成長與演變！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---