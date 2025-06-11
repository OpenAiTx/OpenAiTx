<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">AstroNvim Community Repository</h1>

De community repository van AstroNvim bevat specificaties voor pluginconfiguraties — een verzameling plugins bijgedragen door de community voor AstroNvim, een NeoVim-configuratie. Deze specificaties helpen bij het beheren van de verscheidenheid aan plugins die in AstroNvim worden gebruikt.

## 📦 Installatie

Om de community-plugins te integreren, voeg je de meegeleverde configuraties toe aan je `plugins`-setup, bij voorkeur voordat je je eigen plugins importeert om te garanderen dat alle AstroCommunity-wijzigingen worden geladen vóór je eigen aanpassingen. Als je de [AstroNvim Template](https://github.com/AstroNvim/template) gebruikt, kan dit worden gedaan in je `lua/community.lua` bestand. Als je niet bekend bent met het configureren van plugins, raden we aan de [AstroNvim documentatie](https://docs.astronvim.com/configuration/customizing_plugins/) te raadplegen.

### AstroCommunity Plugins importeren

Integreer de volgende inhoud in je `lua/community.lua` bestand:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "astrocommunity.colorscheme.catppuccin" },
  -- ... importeer hier eventuele door de community bijgedragen plugins
}
```

### AstroCommunity Installaties aanpassen

Zodra je AstroCommunity-imports hebt gedefinieerd in je `lua/community.lua` kun je de installaties verder aanpassen in je eigen plugindefinities (doorgaans gedaan in de `lua/plugins/` map). Hier is een voorbeeld ervan uitgaande dat je Catppuccin hebt geïnstalleerd zoals hierboven getoond.

```lua
return {
  { -- pas de opties die door de community zijn ingesteld verder aan
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

**Opmerkingen:**

- Om imports uit te schakelen, zet je de `enabled` optie op `false`. Je hebt twee manieren om een bestaande plugin aan te passen: gebruik de volledige repositorynaam (bijv. "m4xshen/smartcolumn.nvim") of de modulenaam (bijv. "catppuccin"). Houd er rekening mee dat de modulenaam kan verschillen van de mapnaam.
- Het wordt aanbevolen om het volledige importpad te gebruiken bij het aanpassen van een plugin, en niet de afkorting van alleen de repositorynaam.
- Je kunt veel aspecten van community-plugins overschrijven, inclusief instellingen, afhankelijkheden en versies. Voor meer details over beschikbare opties, raadpleeg de [lazy.nvim documentatie](https://lazy.folke.io/).

## Bijdragen

Als je een pluginconfiguratie hebt geschreven en deze wilt toevoegen aan de AstroCommunity repository, volg dan onze [Bijdragingsrichtlijnen](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) en dien een pull request in. Zorg ervoor dat je je wijzigingen grondig hebt getest vóór het indienen. Dit is geen officiële repository, dus de stabiliteit hangt af van bijdragen uit de community. We zijn enthousiast om te zien hoe dit project groeit en zich ontwikkelt!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---