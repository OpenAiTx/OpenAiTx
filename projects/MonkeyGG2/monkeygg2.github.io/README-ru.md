<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Ваш дружелюбный игровой сайт по соседству.</p>
<br>

Добро пожаловать на MonkeyGG2 — многофункциональный игровой сайт, созданный для вас! Более 150 игр на выбор, уникальный и настраиваемый игровой опыт. Будь вы геймером, разработчиком или обычным пользователем, MonkeyGG2 предоставляет удобную и приятную игровую среду.

> Поставьте нам звёздочку! Особенно если вы сделали форк этого репозитория или нашли для него другое применение.

## Возможности

-   Более 150 игр
-   Простота использования
-   Лёгкое развёртывание
-   Настраиваемость
-   Прокси
-   И многое другое...

## Настройка

### Настройки

#### Клоакинг

Клоакинг — это открытие страницы во вкладке `about:blank`. Это поведение включено по умолчанию, но его можно отключить. Доступны предустановки для ссылки перенаправления, однако вы можете настроить её вручную.

#### Маскировка

Маскировка — это изменение иконки и названия вкладки about:blank. Доступны предустановки для иконки и названия вкладки, однако их также можно настроить вручную.

#### Горячие клавиши

Можно создавать пользовательские сочетания клавиш для выполнения различных задач. Например, выход из игры, маскировка вкладки и выполнение собственного JavaScript поддерживаются.
> Примечание: если вы хотите выполнить свой JavaScript, убедитесь, что понимаете, что делаете. Если что-то сломается, перезагрузка страницы всегда поможет.

#### Тема

В настоящее время поддерживаются следующие настройки темы:
- Отключение фоновой анимации (если вы беспокоитесь о производительности во время игры, не волнуйтесь — она автоматически отключается при запуске игры)
- Цвет фона
- Цвет блоков
- Цвет кнопок
- Цвет игр
- Цвет наведения
- Цвет полосы прокрутки
- Цвет трека прокрутки
- Цвет шрифта

> Примечание: если вы случайно изменили цвета так, что сайт стал неработоспособным, очистите cookies и local storage.

### Расширенная настройка

> Дисклеймер: следующие настройки доступны только владельцам репозитория или его форков.

Файл `config.jsonc` содержит конфигурацию для всего сайта. В настоящее время поддерживаются следующие элементы:
- Игры
- Темы (скоро)
- Настройки прокси

#### Игры

Каждая запись игры имеет ключ, представляющий название игры для отображения, а значение — объект с тремя парами ключ-значение:
- `"path"`: Путь к игре от каталога `./games`
- `"aliases"`: Список альтернативных названий игры для улучшения поиска
- `"categories"`: Список категорий, к которым относится игра (поддержка добавления иконок скоро появится)

Добавление записи вручную возможно, но утомительно, особенно если вы хотите отсортировать список по алфавиту (для работы конфигурации это не требуется!)
Поэтому был создан скрипт `add-game-entry.js` — простой способ добавить новую игру в конфигурацию без ручного редактирования файла.

```bash
# Вы можете использовать любой js-движок, например node.js, bun или deno
# Для примера будет использован bun, так как зависимости устанавливаются автоматически
bun add-game-script.js
# Ответьте на появившиеся вопросы, и конфигурация будет обновлена
```

#### Темы

Стандарт тем ещё не реализован (TODO)

#### Прокси

Настройки прокси находятся под ключом **"config"**. 
Значение ключа `"proxy"` — это boolean-значение, включающее или отключающее функцию прокси. Если `"proxy"` установлено в false, пользователю будет показано окно ошибки при попытке зайти через прокси.
Значение ключа `"proxyPath"` — это путь к прокси. Он может быть абсолютным или относительным, но прокси должен поддерживать **CORS**, так как страница прокси будет отображаться на сайте в виде iframe.


## Развёртывание

### Без прокси

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

В качестве альтернативы, вы можете просто форкнуть этот репозиторий на [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) или [Codeberg](https://codeberg.org/MonkeyGG2/pages) и развернуть на GitHub Pages или Codeberg Pages соответственно.

### С прокси

Посетите страницу [VioletGG2](https://github.com/MonkeyGG2/VioletGG2), чтобы узнать больше о размещении MonkeyGG2 с прокси.

### Запуск локально

```bash
# ВНИМАНИЕ: если у вас есть папка с именем "monkeygg2", эта команда удалит все файлы внутри неё
# пожалуйста, измените имя директории в следующих двух командах
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# отсюда вы можете использовать любой инструмент для запуска статического сервера, здесь будет использован "live-server" из npm
npm install -g live-server # только если он ещё не установлен
npx live-server
```

## Лицензия

Распространяется под лицензией WTFPL. Подробнее см. [здесь](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---