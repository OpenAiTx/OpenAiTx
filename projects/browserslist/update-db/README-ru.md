# Обновление базы данных Browserslist

<img width="120" height="120" alt="Логотип Browserslist от Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

CLI-инструмент для обновления `caniuse-lite` с базой данных браузеров
из [конфига Browserslist](https://github.com/browserslist/browserslist/).

Некоторые запросы, такие как `last 2 versions` или `>1%`, зависят от актуальных данных
из `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Спонсировано Evil Martians" width="236" height="54">
</a>

## Почему нужно вызывать это регулярно

`npx update-browserslist-db@latest` обновляет версию `caniuse-lite`
в вашем lock-файле npm, yarn или pnpm.

Это обновление принесёт данные о новых браузерах для инструментов полифиллов,
таких как Autoprefixer или Babel, и уменьшит количество уже ненужных полифиллов.

Делать это нужно регулярно по трём причинам:

1. Чтобы использовать последние версии браузеров и статистику в запросах типа
   `last 2 versions` или `>1%`. Например, если вы создали проект
   2 года назад и не обновляли зависимости, `last 1 version`
   вернёт данные двухлетней давности.
2. Актуальные данные о браузерах приведут к использованию меньшего количества полифиллов. Это уменьшит
   размер JS и CSS файлов и повысит производительность сайта.
3. Дедупликация `caniuse-lite`: для синхронизации версий в разных инструментах.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---