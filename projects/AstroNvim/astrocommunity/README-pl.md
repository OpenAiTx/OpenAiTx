<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Repozytorium Społeczności AstroNvim</h1>

Repozytorium społeczności AstroNvim zawiera specyfikacje konfiguracji wtyczek — zbiór wtyczek wniesionych przez społeczność dla AstroNvim, konfiguracji NeoVim. Specyfikacje te pomagają zarządzać różnorodnością wtyczek używanych w AstroNvim.

## 📦 Konfiguracja

Aby zintegrować wtyczki społeczności, dodaj dostarczone konfiguracje do swojego setupu `plugins`, najlepiej przed importem własnych wtyczek, aby zapewnić załadowanie wszystkich zmian AstroCommunity przed własnymi nadpisaniami. Jeśli używasz [AstroNvim Template](https://github.com/AstroNvim/template), można to zrobić w pliku `lua/community.lua`. Jeśli nie znasz się na konfiguracji wtyczek, zalecamy zapoznanie się z [dokumentacją AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Importowanie wtyczek AstroCommunity

Wstaw następującą zawartość do pliku `lua/community.lua`:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/astrocommunity/colorscheme/catppuccin" },
  -- ... zaimportuj tutaj dowolne wtyczki wniesione przez społeczność
}
```

### Dostosowywanie instalacji AstroCommunity

Gdy masz już zdefiniowane importy AstroCommunity w `lua/community.lua`, możesz dalej dostosowywać instalacje we własnych definicjach wtyczek (zazwyczaj w katalogu `lua/plugins/`). Oto przykład zakładając, że masz zainstalowany Catppuccin jak powyżej.

```lua
return {
  { -- dalsze dostosowywanie opcji ustawionych przez społeczność
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

**Uwagi:**

- Aby wyłączyć importy, ustaw opcję `enabled` na `false`. Masz dwie metody modyfikacji istniejącej wtyczki: użyj pełnej nazwy repozytorium (np. "m4xshen/smartcolumn.nvim") lub nazwy modułu (np. "catppuccin"). Pamiętaj, że nazwa modułu może różnić się od nazwy folderu.
- Zaleca się używanie pełnej ścieżki importu przy dostosowywaniu wtyczki, a nie skróconej notacji samej nazwy repozytorium.
- Możesz nadpisać wiele aspektów wtyczek społeczności, w tym ustawienia, zależności i wersje. Aby uzyskać więcej informacji o dostępnych opcjach, zapoznaj się z [dokumentacją lazy.nvim](https://lazy.folke.io/).

## Wkład w projekt

Jeśli napisałeś konfigurację wtyczki i chcesz dodać ją do repozytorium AstroCommunity, prosimy o zapoznanie się z naszymi [Wytycznymi Wkładu](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) i przesłanie pull requesta. Upewnij się, że dokładnie przetestowałeś swoje zmiany przed wysłaniem. To nie jest oficjalne repozytorium, więc jego stabilność zależy od wkładu społeczności. Z niecierpliwością czekamy na rozwój i ewolucję tego projektu!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---