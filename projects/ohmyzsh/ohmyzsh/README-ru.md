<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh — это открытый, управляемый сообществом фреймворк для управления вашей [zsh](https://www.zsh.org/)
конфигурацией.

Звучит скучно. Давайте попробуем ещё раз.

**Oh My Zsh не сделает из вас разработчика в 10 раз продуктивнее... но вы можете почувствовать себя таким.**

После установки ваш терминал станет предметом обсуждения в городе _или вернём деньги!_ С каждым нажатием клавиши
в командной строке вы будете использовать сотни мощных плагинов и красивые темы.
Незнакомцы будут подходить к вам в кафе и спрашивать: _"Это потрясающе! Вы какой-то гений?"_

Наконец, вы начнёте получать то внимание, которого всегда были достойны. ...или, может быть, вы воспользуетесь сэкономленным временем, чтобы чаще пользоваться зубной нитью. 😬

Чтобы узнать больше, посетите [ohmyz.sh](https://ohmyz.sh), подпишитесь на [@ohmyzsh](https://x.com/ohmyzsh) в X (ранее
Twitter) и присоединяйтесь к нам в [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Содержание</summary>

- [Начало работы](#getting-started)
  - [Совместимость с операционными системами](#operating-system-compatibility)
  - [Предварительные требования](#prerequisites)
  - [Базовая установка](#basic-installation)
    - [Ручная проверка](#manual-inspection)
- [Использование Oh My Zsh](#using-oh-my-zsh)
  - [Плагины](#plugins)
    - [Включение плагинов](#enabling-plugins)
    - [Использование плагинов](#using-plugins)
  - [Темы](#themes)
    - [Выбор темы](#selecting-a-theme)
  - [Часто задаваемые вопросы](#faq)
- [Продвинутые темы](#advanced-topics)
  - [Расширенная установка](#advanced-installation)
    - [Пользовательский каталог](#custom-directory)
    - [Безоперационная установка](#unattended-install)
    - [Установка из форкнутого репозитория](#installing-from-a-forked-repository)
    - [Ручная установка](#manual-installation)
  - [Проблемы с установкой](#installation-problems)
  - [Пользовательские плагины и темы](#custom-plugins-and-themes)
  - [Включение GNU ls в macOS и freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Пропуск алиасов](#skip-aliases)
  - [Асинхронный git prompt](#async-git-prompt)
- [Обновления](#getting-updates)
  - [Информативность обновлений](#updates-verbosity)
  - [Ручное обновление](#manual-updates)
- [Удаление Oh My Zsh](#uninstalling-oh-my-zsh)
- [Как внести вклад в Oh My Zsh?](#how-do-i-contribute-to-oh-my-zsh)
  - [Не присылайте нам темы](#do-not-send-us-themes)
- [Участники](#contributors)
- [Следите за нами](#follow-us)
- [Мерч](#merchandise)
- [Лицензия](#license)
- [О Planet Argon](#about-planet-argon)

</details>

## Начало работы

### Совместимость с операционными системами

| ОС            | Статус |
| :------------ | :----: |
| Android       |   ✅   |
| freeBSD       |   ✅   |
| LCARS         |   🛸   |
| Linux         |   ✅   |
| macOS         |   ✅   |
| OS/2 Warp     |   ❌   |
| Windows (WSL2)|   ✅   |

### Предварительные требования

- Должен быть установлен [Zsh](https://www.zsh.org) (версия 4.3.9 или новее, но предпочтительно 5.0.8 и выше). Если не установлен (проверьте командой `zsh --version`), следуйте инструкциям: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- Должен быть установлен `curl` или `wget`
- Должен быть установлен `git` (рекомендуется v2.4.11 или новее)

### Базовая установка

Oh My Zsh устанавливается выполнением одной из следующих команд в вашем терминале. Вы можете установить его через командную строку с помощью `curl`, `wget` или другого аналогичного инструмента.

| Метод     | Команда                                                                                          |
| :-------- | :----------------------------------------------------------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`|
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`  |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`|

Кроме того, установщик также зеркалируется вне GitHub. Использование этой ссылки может потребоваться, если вы находитесь в странах, таких как Китай или Индия (или у определённых провайдеров), где заблокирован `raw.githubusercontent.com`:

| Метод     | Команда                                         |
| :-------- | :---------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Обратите внимание, что предыдущий `.zshrc` будет переименован в `.zshrc.pre-oh-my-zsh`. После установки вы можете перенести нужные настройки в новый `.zshrc`._

#### Ручная проверка

Рекомендуется проверить скрипт установки из незнакомых вам проектов. Для этого сначала скачайте скрипт, посмотрите его содержимое, а затем выполните:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Если указанный выше URL недоступен или не работает, попробуйте заменить его на `https://install.ohmyz.sh`.

## Использование Oh My Zsh

### Плагины

Oh My Zsh поставляется с огромным количеством плагинов. Посмотрите каталог [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) и/или [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins), чтобы узнать, что доступно.

#### Включение плагинов

Когда вы найдёте плагины, которые хотите использовать с Oh My Zsh, вам нужно включить их в файле `.zshrc`. Этот файл находится в вашем каталоге `$HOME`. Откройте его в любимом текстовом редакторе и укажите нужные плагины.

```sh
vi ~/.zshrc
```

Например, это может выглядеть так:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Обратите внимание, что плагины разделяются пробелами (пробелы, табуляции, переносы строк...). **Не используйте** запятые между ними — это приведёт к ошибке._

#### Использование плагинов

Каждый встроенный плагин содержит **README**, где описаны его возможности, алиасы (если есть) и дополнительные функции.

### Темы

Признаёмся. В начале существования Oh My Zsh мы, возможно, слишком увлеклись темами. Сейчас их более 150. Большинство имеют [скриншоты](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) на wiki (мы работаем над обновлением!). Ознакомьтесь!

#### Выбор темы

_Тема Robby используется по умолчанию. Она не самая стильная и не самая простая. Она просто подходящая (для него)._

Когда вы найдёте тему, которую хотите использовать, отредактируйте файл `~/.zshrc`. Найдите там переменную окружения (в верхнем регистре), похожую на:

```sh
ZSH_THEME="robbyrussell"
```

Чтобы использовать другую тему, просто замените значение на имя желаемой темы. Например:

```sh
ZSH_THEME="agnoster" # (одна из красивых)
# см. https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> Часто бывает, что вы видите скриншот темы zsh, пробуете её, но внешний вид отличается.
>
> Это потому, что многие темы требуют установки [Powerline Font](https://github.com/powerline/fonts) или
> [Nerd Font](https://github.com/ryanoasis/nerd-fonts) для корректного отображения. Без них темы показывают странные символы в приглашении. Подробнее см. [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt).
>
> Также обратите внимание, что темы влияют только на внешний вид приглашения — текст перед или после курсора, где вы вводите команды. Темы не управляют цветовой схемой терминала или его шрифтом. Эти параметры можно изменить в настройках вашего эмулятора терминала. Подробнее см.: [что такое тема zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Откройте новое окно терминала, и ваше приглашение будет выглядеть примерно так:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Если вы не нашли подходящую тему, загляните на wiki в раздел [больше тем](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Если хотите развлечься, можете позволить компьютеру выбирать случайную тему при каждом запуске терминала.

```sh
ZSH_THEME="random" # (...пусть будет пирог... пусть будет пирог...)
```

А если хотите выбирать случайную тему только из любимых:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Если вы знаете только те темы, которые не нравятся, добавьте их в список игнорируемых:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### Часто задаваемые вопросы

Если у вас есть вопросы или проблемы, возможно, вы найдёте решение в нашем [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Продвинутые темы

Если вы любите «покопаться под капотом», эти разделы для вас.

### Расширенная установка

Некоторые пользователи могут захотеть установить Oh My Zsh вручную или изменить путь установки и другие параметры (описаны в начале скрипта установки).

#### Пользовательский каталог

Каталог по умолчанию — `~/.oh-my-zsh` (скрытый в домашнем каталоге, доступен по `cd ~/.oh-my-zsh`)

Для изменения каталога установки используйте переменную окружения `ZSH` — либо задайте её командой `export ZSH=/your/path` перед установкой, либо укажите прямо в конце команды установки:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Безоперационная установка

Если вы запускаете установку Oh My Zsh в автоматическом режиме, передайте флаг `--unattended` скрипту `install.sh`. В этом случае не будет попытки изменить shell по умолчанию, и не будет автоматического запуска `zsh` после установки.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Если вы в Китае, Индии или другой стране, где заблокирован `raw.githubusercontent.com`, используйте вместо него ссылку `https://install.ohmyz.sh`.

#### Установка из форкнутого репозитория

Скрипт установки также принимает следующие переменные для установки из другого репозитория:

- `REPO` (по умолчанию: `ohmyzsh/ohmyzsh`): указывается как `владелец/репозиторий`. Если задать эту переменную, установщик будет искать репозиторий по адресу `https://github.com/{owner}/{repository}`.

- `REMOTE` (по умолчанию: `https://github.com/${REPO}.git`): полный URL клона git-репозитория. Используйте, если хотите установить из форка не на GitHub (например, GitLab, Bitbucket) или клонировать по SSH (`git@github.com:user/project.git`).

  _ПРИМЕЧАНИЕ: несовместимо с установкой переменной `REPO`. Этот параметр имеет приоритет._

- `BRANCH` (по умолчанию: `master`): используйте, чтобы изменить ветку, которая будет выбрана при клонировании. Может пригодиться для тестирования pull request или использования другой ветки.

Пример:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Ручная установка

##### 1. Клонировать репозиторий <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _По желанию_, создать резервную копию существующего файла `~/.zshrc` <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Создать новый файл конфигурации Zsh <!-- omit in toc -->

Можно создать новый файл конфигурации, скопировав предоставленный шаблон:

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Изменить shell по умолчанию <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Вам нужно выйти из текущей сессии пользователя и войти снова, чтобы увидеть изменения.

##### 5. Инициализировать новую конфигурацию Zsh <!-- omit in toc -->

После открытия нового окна терминала должен загрузиться zsh с конфигурацией Oh My Zsh.

### Проблемы с установкой

Если возникли проблемы с установкой, вот несколько распространённых решений:

- Возможно, потребуется изменить `PATH` в `~/.zshrc`, если некоторые команды не находятся после перехода на oh-my-zsh.
- Если вы устанавливали вручную или меняли каталог установки, проверьте переменную окружения `ZSH` в `~/.zshrc`.

### Пользовательские плагины и темы

Если вы хотите переопределить стандартное поведение, просто добавьте новый файл с расширением `.zsh` в каталог `custom/`.

Если у вас есть набор функций, хорошо работающих вместе, поместите их в файл `XYZ.plugin.zsh` в каталоге `custom/plugins/` и затем включите этот плагин.

Если вы хотите переопределить функционал плагина из комплекта Oh My Zsh, создайте плагин с таким же именем в `custom/plugins/`, и он будет загружен вместо оригинального из `plugins/`.

### Включение GNU ls в macOS и freeBSD

<a name="enable-gnu-ls"></a>

По умолчанию Oh My Zsh использует BSD `ls` в macOS и FreeBSD. Если установлен GNU `ls` (как команда `gls`), вы можете использовать его вместо BSD. Для этого укажите следующую настройку zstyle до подключения `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Примечание: не совместимо с `DISABLE_LS_COLORS=true`_

### Пропуск алиасов

<a name="remove-directories-aliases"></a>

Если вы хотите пропустить стандартные алиасы Oh My Zsh (определённые в файлах `lib/*`) или алиасы плагинов, используйте настройки ниже в вашем `~/.zshrc` **до загрузки Oh My Zsh**. Есть разные способы пропустить алиасы, в зависимости от ваших целей.

```sh
# Пропустить все алиасы (lib и плагины)
zstyle ':omz:*' aliases no

# Пропустить все алиасы в lib
zstyle ':omz:lib:*' aliases no
# Пропустить только алиасы из lib файла directories.zsh
zstyle ':omz:lib:directories' aliases no

# Пропустить все алиасы плагинов
zstyle ':omz:plugins:*' aliases no
# Пропустить только алиасы из git-плагина
zstyle ':omz:plugins:git' aliases no
```

Можно комбинировать настройки — более специфичные области имеют приоритет:

```sh
# Пропустить все алиасы плагинов, кроме git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

В предыдущей версии использовалась настройка:

```sh
zstyle ':omz:directories' aliases no
```

Теперь используйте:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Замечание <!-- omit in toc -->

> Эта функция находится на стадии тестирования и может измениться в будущем. Также она несовместима с менеджерами плагинов, такими как zpm или zinit, которые не запускают скрипт инициализации (`oh-my-zsh.sh`), где реализована эта функция.

> Также она не учитывает «алиасы», определённые как функции (например, `gccd`, `ggf` или `ggl` из git-плагина).

### Асинхронный git prompt

Асинхронные функции приглашения — экспериментальная функция (введена 3 апреля 2024), позволяющая Oh My Zsh отображать информацию о git-приглашении асинхронно. Это может ускорить прорисовку приглашения, но может работать не со всеми конфигурациями. Если у вас возникли проблемы с этой функцией, вы можете отключить её, добавив в `.zshrc` до загрузки Oh My Zsh:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Если git-приглашение вообще не появляется, попробуйте принудительно включить его:

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

Если всё равно не работает, откройте issue с описанием вашего случая.

## Обновления

По умолчанию вам будет предложено проверить обновления раз в 2 недели. Можно выбрать другой режим обновления, добавив строку в ваш `~/.zshrc` **до загрузки Oh My Zsh**:

1. Автоматическое обновление без подтверждения:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Только напоминание каждые несколько дней, если есть обновления:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Полностью отключить автоматические обновления:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

ПРИМЕЧАНИЕ: можно управлять частотой проверки обновлений так:

```sh
# Проверка обновлений каждые 7 дней
zstyle ':omz:update' frequency 7
# Проверять обновления при каждом запуске терминала (не рекомендуется)
zstyle ':omz:update' frequency 0
```

### Информативность обновлений

Вы также можете ограничить информативность обновлений следующими настройками:

```sh
zstyle ':omz:update' verbose default # стандартное сообщение

zstyle ':omz:update' verbose minimal # минимально

zstyle ':omz:update' verbose silent # только ошибки
```

### Ручное обновление

Если хотите обновиться в любой момент (например, только что вышел новый плагин и ждать неделю не хочется), просто выполните:

```sh
omz update
```

> [!NOTE]
> Для автоматизации процесса в скрипте вызывайте напрямую скрипт `upgrade`, так:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Больше опций смотрите в [FAQ: Как обновить Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **Использование `omz update --unattended` было удалено из-за побочных эффектов**.

Магия! 🎉

## Удаление Oh My Zsh

Oh My Zsh подходит не всем. Мы будем скучать, но хотим, чтобы расставание было простым.

Чтобы удалить `oh-my-zsh`, просто выполните в командной строке `uninstall_oh_my_zsh`. Это удалит себя и восстановит вашу предыдущую конфигурацию `bash` или `zsh`.

## Как внести вклад в Oh My Zsh?

Перед тем как присоединиться к нашему сообществу, пожалуйста, ознакомьтесь с [кодексом поведения](CODE_OF_CONDUCT.md).

Я далёк от звания эксперта по [Zsh](https://www.zsh.org/) и уверен, что есть много способов улучшить проект — если у вас есть идеи, как сделать конфигурацию проще для поддержки (и быстрее), не стесняйтесь создавать форк и присылать pull request!

Нам также нужны тестировщики для pull request'ов. Загляните в [открытые задачи](https://github.com/ohmyzsh/ohmyzsh/issues) и помогите, где можете.

Подробнее см. в [Contributing](CONTRIBUTING.md).

### Не присылайте нам темы

У нас (более чем) достаточно тем. Пожалуйста, добавьте свою тему на страницу [внешние темы](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) на wiki.

## Участники

У Oh My Zsh яркое сообщество довольных пользователей и замечательных контрибьюторов. Без вашей помощи проект не был бы таким классным.

Спасибо вам огромное!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Следите за нами

Мы в соцсетях:

- [@ohmyzsh](https://x.com/ohmyzsh) в X (ранее Twitter). Подписывайтесь!
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) — пишите нам.
- [Instagram](https://www.instagram.com/_ohmyzsh/) — отмечайте нас на фото с Oh My Zsh!
- [Discord](https://discord.gg/ohmyzsh) — для общения!

## Мерч

У нас есть
[стикеры, футболки и кружки](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)
— покажите свою любовь к Oh My Zsh! Снова вы станете предметом обсуждения в городе!

## Лицензия

Oh My Zsh распространяется под [лицензией MIT](LICENSE.txt).

## О Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh был создан командой [Planet Argon](https://www.planetargon.com/?utm_source=github), [агентством по разработке Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github).
Ознакомьтесь с нашими [другими open source проектами](https://www.planetargon.com/open-source?utm_source=github).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---