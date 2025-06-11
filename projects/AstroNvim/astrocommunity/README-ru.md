<div align="center" id="madewithlua">
  <img
    src="https://astronvim.com/logo/astronvim.svg"
    width="110"
    ,
    height="100"
  />
</div>
<h1 align="center">Репозиторий сообщества AstroNvim</h1>

Репозиторий сообщества AstroNvim содержит спецификации конфигураций плагинов — коллекцию плагинов, предоставленных сообществом для AstroNvim, конфигурации NeoVim. Эти спецификации помогают управлять разнообразием плагинов, используемых в AstroNvim.

## 📦 Установка

Чтобы интегрировать плагины сообщества, добавьте предоставленные конфигурации в вашу настройку `plugins`, желательно до того, как вы импортируете свои собственные плагины, чтобы гарантировать, что все изменения AstroCommunity загрузятся до ваших собственных переопределений. Если вы используете [шаблон AstroNvim](https://github.com/AstroNvim/template), это можно сделать в вашем файле `lua/community.lua`. Если вы не знакомы с настройкой плагинов, рекомендуем ознакомиться с [документацией AstroNvim](https://docs.astronvim.com/configuration/customizing_plugins/).

### Импорт плагинов AstroCommunity

Добавьте следующий код в файл `lua/community.lua`:

```lua
return {
  "AstroNvim/astrocommunity",
  { import = "https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/colorscheme/catppuccin" },
  -- ... импортируйте здесь любые плагины, предоставленные сообществом
}
```

### Настройка установок AstroCommunity

После того, как вы определили импорты AstroCommunity в вашем `lua/community.lua`, вы можете дополнительно настроить установки в ваших собственных определениях плагинов (обычно в директории `lua/plugins/`). Вот пример, предполагающий, что у вас установлен Catppuccin, как показано выше.

```lua
return {
  { -- дополнительная настройка опций, заданных сообществом
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

**Примечания:**

- Чтобы отключить импорт, установите опцию `enabled` в `false`. У вас есть два способа изменить существующий плагин: используйте полное имя репозитория (например, "m4xshen/smartcolumn.nvim") или имя модуля (например, "catppuccin"). Помните, что имя модуля может отличаться от имени папки.
- Рекомендуется использовать полный путь импорта при настройке плагина, а не сокращённую запись только с именем репозитория.
- Вы можете переопределять многие аспекты плагинов сообщества, включая настройки, зависимости и версии. Для подробной информации об доступных опциях обратитесь к [документации lazy.nvim](https://lazy.folke.io/).

## Вклад

Если вы написали конфигурацию плагина и хотите добавить её в репозиторий AstroCommunity, пожалуйста, следуйте нашим [Руководствам по внесению изменений](https://raw.githubusercontent.com/AstroNvim/astrocommunity/main/CONTRIBUTING.md) и отправьте pull request. Убедитесь, что вы тщательно протестировали ваши изменения перед отправкой. Это неофициальный репозиторий, поэтому его стабильность зависит от вклада сообщества. Мы с нетерпением ждём, как этот проект будет расти и развиваться!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---