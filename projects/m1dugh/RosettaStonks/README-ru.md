
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Введение](#introduction)
- [Установка](#install)
  - [Chrome](#chrome-based-browsers)
    - [Визуальное руководство](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [Как пользоваться](#how-to-use)
  - [Добавление времени](#adding-time)
    - [Основы](#adding-time-in-foundations)
    - [Тренажёр беглости](#adding-time-in-fluency-builder)
  - [Проверка урока](#validating-lesson)
    - [Основы](#validating-lesson-in-foundations)
    - [Тренажёр беглости](#validating-lesson-in-fluency-builder)

## Введение

RosettaStonks — это расширение для браузера, позволяющее добавлять время и проверять
уроки на платформе изучения языков Rosetta Stone.

> RosettaStonks, и ваш rosetta stone становится stonks.

## Установка

### Браузеры на базе Chrome

➡️ **Впервые устанавливаете расширения Chrome вручную?** Ознакомьтесь с [Пошаговым визуальным руководством](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — включает полезные скриншоты! 🖼️

#### 1. Использование релиза на GitHub

Чтобы использовать расширение в браузере на базе Chrome, вам нужно:

- скачать файл `rosettastonks-chrome.tar.gz` из последнего релиза на
  свой компьютер.
- создать папку с именем `rosettastonks` где-нибудь на вашем компьютере для хранения
  расширения
- выполнить следующую команду в папке `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Использование менеджера пакетов nix

Вместо предыдущих команд, если вы используете nix-систему **с поддержкой
flakes**, вы можете выполнить следующие команды, которые установят папку
по пути `/tmp/rosettastonks` со всеми файлами.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

Папка теперь установлена в `/tmp/rosettastonks/`

**Эта часть предназначена для всех пользователей, независимо от того, используете ли вы метод github
или метод nix.**

В вашем браузере:

- перейдите на `chrome://extensions`
- включите переключатель `Режим разработчика`
- нажмите `Загрузить распакованное`
- выберите вашу папку `rosettastonks`

### Браузеры на базе Firefox

- скачайте файл `rosettastonks.xpi` из последнего релиза.
- альтернативно, если используете пакетный менеджер nix с поддержкой flake, вы можете выполнить
  следующую команду.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- перейдите на страницу `about:addons` в вашем браузере
- нажмите кнопку настроек и выберите `Отладка дополнений`.
- нажмите `Загрузить временное дополнение`
- выберите файл `/tmp/rosettastonks.xpi` в проводнике файлов.

_Внимание: Этот способ устанавливает расширение только временно, то есть если
вы закроете браузер, дополнение будет удалено. Это связано с политикой Firefox,
которая не позволяет использовать непроверенные расширения._

## Как использовать

### Добавление времени

#### Добавление времени в Foundations

Чтобы добавить время в продукте `foundations`, вам нужно перейти к вашим упражнениям и
нажать игнорировать или решить хотя бы один вопрос. После этого поле для времени
должно появиться на странице расширения, где вы сможете добавить свое время.

#### Добавление времени в Fluency builder

Чтобы добавить время в продукте `fluency builder`, вам нужно перейти к упражнениям и
ответить хотя бы на одно упражнение. Если поле для добавления времени не появляется, это
означает, что запрос времени не был зафиксирован, вам нужно обновить вопрос и ответить на
него снова. Чтобы время было добавлено, нужно завершить урок, в котором вы добавляли время.

_Примечание: Если вы не видите поле для добавления времени, значит ваши действия на сайте
Rosetta Stone не привели к добавлению легитимного времени, поэтому вам нужно ответить на
другие вопросы._

### Проверка урока

#### Проверка урока в Foundations

Чтобы проверить урок, нужно начать урок и пройти все вопросы, используя кнопку
`игнорировать` внизу справа. После просмотра всех вопросов, нажатие кнопки
`проверить урок` должно завершить проверку урока. Если нет, вернитесь на домашнюю страницу, нажмите на тот же урок, он


должен спросить вас: `Хотите продолжить или сбросить?`, вы можете выбрать любой вариант и
повторно проверить урок до тех пор, пока он не заработает. Обычно это работает после 3-4 попыток максимум.

#### Проверка урока в Fluency builder

В настоящее время функция проверки урока недоступна в rosetta stonks.

## Сборка приложения

### Сборка worker

Worker можно упаковать с помощью следующей команды

```
$ deno task build:worker
```

Это создает упакованный файл `/dist/worker.esm.js`, который является упакованным
файлом для воркера.

### Сборка фронтенда

Воркер можно упаковать с помощью следующей команды

```
$ deno task build:frontend
```

Который создает упакованный файл `/dist/frontend.esm.js`, являющийся
упакованным файлом для фронтенда.

## Упаковка расширения

### Chrome

Чтобы упаковать расширение для Chrome, можно выполнить следующую команду:

```
$ make chrome
```

### Firefox

Чтобы упаковать расширение для Firefox, можно выполнить следующую команду:

```
$ make firefox
```

Это создаст файл `rosettastonks.xpi` — расширение, которое можно загрузить в Firefox.

📸 Предпочитаете визуальные инструкции? Ознакомьтесь с [Руководством по установке для Chrome с изображениями](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---