<h1 align="center">ModernZ - Стильный альтернативный OSC для mpv</h1>

Стильный и современный OSC для [mpv](https://mpv.io/), этот проект является форком ModernX, разработанным для расширения функционала за счёт добавления новых возможностей, при этом сохраняя основные стандарты OSC mpv.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>Установка »</strong></a>
  <br>
  <a href="#configuration">Конфигурация</a>
  ·
  <a href="#controls">Управление</a>
  ·
  <a href="#interactive-menus">Интерактивные меню</a>
  ·
  <a href="#translations">Языки OSC</a>
  ·
  <a href="#extras">Дополнительные скрипты</a>
</p>

## Особенности

- 🎨 Современный, настраиваемый интерфейс [[опции](#configuration)]
- 📷 Режим просмотра изображений с контролем масштабирования [[подробнее](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ Кнопки: загрузка, плейлист, управление скоростью, скриншот, закрепить, повтор, кэш и многое другое. [[подробнее](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 Интерактивные меню для плейлиста, субтитров, глав, аудиодорожек и аудиоустройств [[подробнее](#interactive-menus)]
- 🌐 Многоязычная поддержка с интеграцией JSON [locale](#translations)
- ⌨️ Настраиваемое управление [[подробнее](#controls)]
- 🖼️ Превью видео с помощью [thumbfast](https://github.com/po5/thumbfast)

## Настройка

Вы можете изменить тему иконок на `fluent` или `material` в соответствии с вашими предпочтениями, используя опцию `icon_theme` в вашем файле `modernz.conf`

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

Не любите белые кнопки и текст? Вы полностью контролируете цвета и расположение кнопок, чтобы идеально отразить ваш стиль.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

См. раздел [Настройка цветов](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) в руководстве по конфигурации для деталей о том, как настроить цвета и кнопки.

## Интерактивные меню

ModernZ поддерживает встроенную консоль/селект mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) для плейлиста, субтитров, навигации по главам и другого.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## Установка

1. **Отключите стандартный OSC**

   - Добавьте `osc=no` в ваш `mpv.conf`

2. **Скопируйте файлы**

   - Поместите `modernz.lua` в папку скриптов mpv
   - Поместите `fluent-system-icons.ttf` и `material-design-icons.ttf` в папку шрифтов mpv
   - (НЕОБЯЗАТЕЛЬНО) Поместите `thumbfast.lua` в папку скриптов mpv

3. **Расположение**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **Структура папок** [[mpv manual](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (необязательно)
   ```

## Конфигурация

1. Создайте `modernz.conf` в папке `/script-opts` для настройки параметров

   - [Скачать стандартный modernz.conf](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. Пример короткой конфигурации:

   ```EditorConfig
   # Цвет бегунка (в формате hex)
   seekbarfg_color=#B7410E

   # Опции интерфейса
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

Для полного списка опций, [посмотрите подробный список здесь](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## Управление

### Взаимодействия с кнопками

- Левый клик: Основное действие
- Правый клик: Второстепенное действие
- Средний клик/Shift+Левый клик: Альтернативное действие

> [!NOTE]
> Средний клик выполняет ту же функцию, что и `Shift+левая кнопка мыши`, позволяя использовать одной рукой

Для полного списка взаимодействий ознакомьтесь с [Руководством по взаимодействию с кнопками](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### Горячие клавиши

ModernZ по умолчанию не назначает горячие клавиши, чтобы не мешать вашей текущей настройке. Вы можете добавить горячие клавиши в `input.conf`, если хотите:

```
w   script-binding modernz/progress-toggle           # Переключить индикатор прогресса
x   script-message-to modernz osc-show               # Показать OSC
y   script-message-to modernz osc-visibility cycle   # Переключить режимы видимости
z   script-message-to modernz osc-idlescreen         # Переключить экран простоя
```

## Переводы

ModernZ в настоящее время доступен на английском языке, но вы легко можете переключить его на предпочитаемый язык! Вот как:

1. **Скачайте пакет локализации:**

Возьмите файл [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) из этого репозитория. Этот файл содержит переводы на разные языки.

2. **Добавьте локали в mpv:**

Скопируйте скачанный файл `modernz-locale.json` в папку `/script-opts` вашего mpv.

3. **Выберите язык:**

Существует два способа установки предпочитаемого языка:

- **Рекомендуется:** Использовать файл `modernz.conf`

  ```ini
  # Пример конфигурации в modernz.conf
  # Установить язык на упрощённый китайский
  language=zh
  ```

- **Альтернативный:** Отредактировать скрипт `modernz.lua`

  Откройте `modernz.lua` и найдите секцию `user_opts` в начале файла. Измените значение `language` на нужный код:

  ```lua
  local user_opts = {
      -- Общие настройки
      language = "en",  -- Измените на код желаемого языка
      ...
  }
  ```

**Нужна дополнительная информация?**

Для полного списка доступных языков, правил участия и подробной документации по переводу посетите [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## Дополнительно

Ниже перечислены скрипты, которые я написал и поддерживаю, вы можете использовать их, если они вам полезны.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - Простой скрипт, отображающий индикатор паузы

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - Простой скрипт для mpv, автоматически меняющий `ytdl-format` (yt-dlp) для заданных доменов.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - Простой скрипт для mpv, автоматически меняющий соотношение сторон видео 4:3 на 16:9.

Для ещё большего количества полезных скриптов посетите [Wiki пользовательских скриптов mpv](https://github.com/mpv-player/mpv/wiki/User-Scripts). Там представлен широкий выбор скриптов от сообщества для улучшения вашего опыта с mpv.

## История

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - форк от [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - форк от [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - форк от [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**Зачем снова форкать?**

- Чтобы добавить множество функций: [Настройка цветов](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [Опции](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) и [Интеграция локалей](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- Чтобы интегрировать консоль и селект в OSC, что вдохновило mpv применить это в стандартном OSC. [см. [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- Чтобы добавить отдельный макет для изображений. [[подробнее](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- Полностью переделать проект в соответствии со стандартами стандартного OSC mpv для обеспечения совместимости
- Устранить старые ошибки и избыточность в коде
    - Что позволяет другим форкам `Modern` использовать ModernZ в качестве базы, например [zydezu/ModernX](https://github.com/zydezu/ModernX). [[Ссылка](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

В сущности, чтобы поддерживать и возрождать происхождение `modern-osc`.
С учетом сказанного, ModernZ все еще использует части старого кода, и каждый предыдущий и текущий автор форка и участник заслуживает признания (включая стандартный osc mpv), поэтому они упомянуты подробно.

#### Благодарности:

- Шрифт: UI Fluent System Icons [[подробности](https://github.com/microsoft/fluentui-system-icons)] [[файл шрифта](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- Шрифт модифицирован [Xurdejl](https://github.com/Xurdejl) для использования в ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) и их [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua), так как ModernZ osc основан на стандартах стандартного osc и применяет обновления из него
- Все современные источники osc и их форки, как указано в [истории](#history)
- Все [участники](https://github.com/Samillion/ModernZ/graphs/contributors), тестировщики и пользователи, которые помогали напрямую или косвенно с ModernZ osc ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---