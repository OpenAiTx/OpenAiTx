<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim Community Repository</h1>

Das Community-Repository von AstroNvim enthält Plugin-Konfigurationsspezifikationen — eine Sammlung von Plugins, die von der Community für AstroNvim, eine NeoVim-Konfiguration, beigetragen wurden. Diese Spezifikationen helfen bei der Verwaltung der Vielzahl von Plugins, die in AstroNvim verwendet werden.

## 📦 Einrichtung

Um die Community-Plugins zu integrieren, fügen Sie die bereitgestellten Konfigurationen zu Ihrem `plugins`-Setup hinzu, vorzugsweise bevor Sie Ihre eigenen Plugins importieren, um sicherzustellen, dass alle Änderungen von AstroCommunity vor Ihren eigenen Überschreibungen geladen werden. Wenn Sie die [AstroNvim Vorlage](https://github.com/AstroNvim/template) verwenden, kann dies in Ihrer `lua/community.lua` Datei erfolgen. Wenn Sie mit der Plugin-Konfiguration nicht vertraut sind, empfehlen wir, die [AstroNvim-Dokumentation](https://docs.astronvim.com/configuration/customizing_plugins/) zu konsultieren.

### Importieren von AstroCommunity-Plugins

Integrieren Sie den folgenden Inhalt in Ihre `lua/community.lua` Datei:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/astrocommunity.colorscheme.catppuccin" },
  -- ... importieren Sie hier beliebige von der Community beigetragene Plugins
}
```

### Anpassen von AstroCommunity-Installationen

Sobald Sie AstroCommunity-Imports in Ihrer `lua/community.lua` definiert haben, können Sie die Installationen in Ihren eigenen Plugin-Definitionen (typischerweise im Verzeichnis `lua/plugins/`) weiter anpassen. Hier ein Beispiel, das davon ausgeht, dass Sie Catppuccin wie oben installiert haben.

```lua
return {
  { -- weitere Anpassungen der von der Community gesetzten Optionen
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

**Hinweise:**

- Um Importe zu deaktivieren, setzen Sie die Option `enabled` auf `false`. Sie haben zwei Möglichkeiten, ein bestehendes Plugin zu modifizieren: Verwenden Sie den vollständigen Repository-Namen (z. B. "m4xshen/smartcolumn.nvim") oder den Modulnamen (z. B. "catppuccin"). Beachten Sie, dass der Modulname vom Ordnernamen abweichen kann.
- Es wird empfohlen, beim Anpassen eines Plugins den vollständigen Importpfad zu verwenden und nicht die Kurzschreibweise nur mit dem Repository-Namen.
- Sie können viele Aspekte von Community-Plugins überschreiben, einschließlich Einstellungen, Abhängigkeiten und Versionen. Für weitere Details zu verfügbaren Optionen siehe die [lazy.nvim Dokumentation](https://lazy.folke.io/).

## Mitwirken

Wenn Sie eine Plugin-Konfiguration geschrieben haben und diese im AstroCommunity-Repository hinzufügen möchten, folgen Sie bitte unseren [Beitragsrichtlinien](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) und reichen Sie einen Pull Request ein. Stellen Sie sicher, dass Sie Ihre Änderungen vor der Einreichung gründlich getestet haben. Dies ist kein offizielles Repository, daher beruht seine Stabilität auf den Beiträgen der Community. Wir freuen uns darauf zu sehen, wie sich dieses Projekt entwickelt und wächst!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---