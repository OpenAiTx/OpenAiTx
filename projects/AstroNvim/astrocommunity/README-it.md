<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Repository della Comunità di AstroNvim</h1>

Il repository della comunità di AstroNvim contiene specifiche di configurazione dei plugin — una raccolta di plugin contribuiti dalla comunità per AstroNvim, una configurazione di NeoVim. Queste specifiche aiutano a gestire la varietà di plugin utilizzati in AstroNvim.

## 📦 Configurazione

Per integrare i plugin della comunità, aggiungi le configurazioni fornite al tuo setup `plugins`, preferibilmente prima di importare i tuoi plugin, per garantire che tutte le modifiche di AstroCommunity vengano caricate prima delle tue sovrascritture. Se stai utilizzando il [Template di AstroNvim](https://github.com/AstroNvim/template) questo può essere fatto nel file `lua/community.lua`. Se non hai familiarità con la configurazione dei plugin, ti consigliamo di fare riferimento alla [documentazione di AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Importazione dei Plugin AstroCommunity

Integra il seguente contenuto all'interno del tuo file `lua/community.lua`:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... importa qui qualsiasi plugin contribuito dalla comunità
}
```

### Personalizzazione delle Installazioni AstroCommunity

Una volta definite le importazioni di AstroCommunity nel tuo `lua/community.lua`, puoi quindi personalizzare ulteriormente le installazioni nelle tue definizioni di plugin (tipicamente fatte nella directory `lua/plugins/`). Ecco un esempio assumendo che tu abbia installato Catppuccin come mostrato sopra.

```lua
return {
  { -- personalizza ulteriormente le opzioni impostate dalla comunità
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

**Note:**

- Per disabilitare le importazioni, imposta l'opzione `enabled` su `false`. Hai due modi per modificare un plugin esistente: usa il nome completo del repository (es. "m4xshen/smartcolumn.nvim") oppure il nome del modulo (es. "catppuccin"). Ricorda che il nome del modulo potrebbe differire dal nome della cartella.
- È consigliato utilizzare il percorso completo di importazione quando personalizzi un plugin, e non la notazione abbreviata con solo il nome del repository.
- Puoi sovrascrivere molti aspetti dei plugin della comunità inclusi impostazioni, dipendenze e versioni. Per maggiori dettagli sulle opzioni disponibili, consulta la [documentazione di lazy.nvim](https://lazy.folke.io/).

## Contribuire

Se hai scritto una configurazione di plugin e desideri aggiungerla al repository AstroCommunity, per favore segui le nostre [Linee Guida per il Contributo](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) e invia una pull request. Assicurati di aver testato rigorosamente le tue modifiche prima della sottomissione. Questo non è un repository ufficiale, quindi la sua stabilità dipende dai contributi della comunità. Siamo entusiasti di vedere come questo progetto crescerà ed evolverà!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---