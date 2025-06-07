# Discord GNOME Theme

Тема GNOME для Discord, выполненная в стиле Adwaita и с учетом Руководства по человеческому интерфейсу GNOME (в пределах того, что позволяет CSS Discord).

## Требования

1. Vesktop

   Для включения заголовка окна Windows.

2. Настройки > Язык > Выберите "English (US)"

   Это позволяет использовать пользовательские иконки из-за особенностей их идентификации в Discord. Вы можете [локализовать](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss) тему, но ознакомьтесь с примечанием по локализации.

3. Настройки > Плагины > Включите "ThemeAttributes"

   Это позволяет использовать иконки в диалоговом окне настроек.

4. Настройки > Vesktop Settings > Включите "Discord Titlebar"

   Необязательно, но рекомендуется, если у вас есть заголовки окон.

### Дополнительные опции

1. Удалить упоминания о Nitro: https://github.com/CroissantDuNord/discord-adblock

## Философия оформления

### Руководство по человеческому интерфейсу

Тема может не полностью соответствовать HIG из-за ограничений CSS или дизайна Discord, либо по моим собственным соображениям.

### Поддержка

Не поддерживаются:

- Эксперименты Discord

  Я не работаю в Discord, поэтому не могу знать, изменяются ли эти эксперименты, устаревают и т.д., то есть это дополнительная нагрузка по сопровождению — я поддерживаю ещё несколько других проектов

- Nitro

  Исключения — всё, что доступно с помощью плагина FakeNitro.

Вы \*можете\* создать issue по любому из этих пунктов, но оно будет исправлено только в случае простой доработки, например, отсутствующей иконки.

## Установка

### Без настройки

Скопируйте следующее в текстовое поле в Настройки > Темы > Онлайн темы:

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### С настройкой

Поместите [gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) в ~/.config/vesktop/themes. Она всё равно будет обновляться автоматически.

## Предпросмотр

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---