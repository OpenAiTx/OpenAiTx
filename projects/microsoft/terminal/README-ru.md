![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Добро пожаловать в репозиторий Windows Terminal, Console и Command-Line

<details>
  <summary><strong>Содержание</strong></summary>

- [Установка и запуск Windows Terminal](#установка-и-запуск-windows-terminal)
  - [Microsoft Store \[Рекомендуется\]](#microsoft-store-рекомендуется)
  - [Другие способы установки](#другие-способы-установки)
    - [Через GitHub](#через-github)
    - [Через Windows Package Manager CLI (winget)](#через-windows-package-manager-cli-winget)
    - [Через Chocolatey (неофициально)](#через-chocolatey-неофициально)
    - [Через Scoop (неофициально)](#через-scoop-неофициально)
- [Установка Windows Terminal Canary](#установка-windows-terminal-canary)
- [Дорожная карта Windows Terminal](#дорожная-карта-windows-terminal)
- [Обзор Terminal и Console](#обзор-terminal-и-console)
  - [Windows Terminal](#windows-terminal)
  - [The Windows Console Host](#the-windows-console-host)
  - [Общие компоненты](#общие-компоненты)
  - [Создание нового Windows Terminal](#создание-нового-windows-terminal)
- [Ресурсы](#ресурсы)
- [FAQ](#faq)
  - [Я собрал и запустил новый Terminal, но он выглядит как старый консольный](#я-собрал-и-запустил-новый-terminal-но-он-выглядит-как-старый-консольный)
- [Документация](#документация)
- [Вклад в проект](#вклад-в-проект)
- [Связь с командой](#связь-с-командой)
- [Руководство для разработчиков](#руководство-для-разработчиков)
- [Требования](#требования)
- [Сборка кода](#сборка-кода)
  - [Сборка в PowerShell](#сборка-в-powershell)
  - [Сборка в Cmd](#сборка-в-cmd)
- [Запуск и отладка](#запуск-и-отладка)
  - [Рекомендации по кодированию](#рекомендации-по-кодированию)
- [Кодекс поведения](#кодекс-поведения)

</details>

<br />

В этом репозитории находится исходный код для:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows console host (`conhost.exe`)
* Компоненты, общие для обоих проектов
* [ColorTool](./src/tools/ColorTool)
* [Примеры проектов](./samples),
  демонстрирующих, как использовать Windows Console API

Связанные репозитории:

* [Документация по Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Репозиторий: Внести вклад в документацию](https://github.com/MicrosoftDocs/terminal))
* [Документация по Console API](https://github.com/MicrosoftDocs/Console-Docs)
* [Шрифт Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Установка и запуск Windows Terminal

> [!ПРИМЕЧАНИЕ]
> Windows Terminal требует Windows 10 2004 (сборка 19041) или новее

### Microsoft Store [Рекомендуется]

Установите [Windows Terminal из Microsoft Store][store-install-link].
Это позволит вам всегда иметь последнюю версию с автоматическими обновлениями при выходе новых сборок.

Это наш предпочтительный способ установки.

### Другие способы установки

#### Через GitHub

Для пользователей, которые не могут установить Windows Terminal из Microsoft Store,
выпущенные сборки можно вручную скачать со страницы [Releases](https://github.com/microsoft/terminal/releases) этого репозитория.

Скачайте файл `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` из раздела **Assets**. Для установки приложения просто дважды кликните по файлу `.msixbundle`, и установщик приложения должен автоматически запуститься. Если это не сработает, попробуйте выполнить следующую команду в PowerShell:

```powershell
# ПРИМЕЧАНИЕ: Если вы используете PowerShell 7+, пожалуйста, выполните
# Import-Module Appx -UseWindowsPowerShell
# перед использованием Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!ПРИМЕЧАНИЕ]
> Если вы устанавливаете Terminal вручную:
>
> * Возможно, вам потребуется установить [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Это необходимо только на старых версиях Windows 10 и только если возникает ошибка о недостающих пакетах фреймворка.
> * Terminal не будет автоматически обновляться при выходе новых версий, поэтому вам нужно будет регулярно устанавливать последние выпуски Terminal, чтобы получать все свежие исправления и улучшения!

#### Через Windows Package Manager CLI (winget)

Пользователи [winget](https://github.com/microsoft/winget-cli) могут скачать и установить последнюю версию Terminal, установив пакет `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!ПРИМЕЧАНИЕ]
> Поддержка зависимостей доступна в WinGet версии [1.6.2631 или новее](https://github.com/microsoft/winget-cli/releases). Для установки стабильной версии Terminal 1.18 или новее, пожалуйста, убедитесь, что у вас обновленная версия клиента WinGet.

#### Через Chocolatey (неофициально)

Пользователи [Chocolatey](https://chocolatey.org) могут скачать и установить последнюю версию Terminal, установив пакет `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

Для обновления Windows Terminal через Chocolatey выполните:

```powershell
choco upgrade microsoft-windows-terminal
```

Если возникают проблемы при установке/обновлении пакета, перейдите на [страницу пакета Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) и следуйте [процессу триажа Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### Через Scoop (неофициально)

Пользователи [Scoop](https://scoop.sh) могут скачать и установить последнюю версию Terminal, установив пакет `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Для обновления Windows Terminal через Scoop выполните:

```powershell
scoop update windows-terminal
```

Если возникли проблемы при установке/обновлении пакета, пожалуйста, найдите или сообщите об этом на [странице проблем](https://github.com/lukesampson/scoop-extras/issues) репозитория Scoop Extras bucket.

---

## Установка Windows Terminal Canary
Windows Terminal Canary — это ночная сборка Windows Terminal. Эта версия содержит последний код из нашей ветки `main`, давая вам возможность опробовать функции до того, как они появятся в Windows Terminal Preview.

Windows Terminal Canary — наименее стабильная версия, поэтому вы можете обнаружить ошибки раньше, чем мы их исправим.

Windows Terminal Canary доступен как в виде дистрибутива App Installer, так и в виде портативного ZIP-архива.

Дистрибутив App Installer поддерживает автоматические обновления. Из-за ограничений платформы этот установщик работает только на Windows 11.

Портативный ZIP-архив является переносимым приложением. Он не обновляется автоматически и не проверяет наличие обновлений. Этот портативный ZIP-архив работает на Windows 10 (19041+) и Windows 11.

| Дистрибутив   | Архитектура     | Ссылка                                               |
|---------------|:---------------:|------------------------------------------------------|
| App Installer | x64, arm64, x86 | [скачать](https://aka.ms/terminal-canary-installer)  |
| Portable ZIP  | x64             | [скачать](https://aka.ms/terminal-canary-zip-x64)    |
| Portable ZIP  | ARM64           | [скачать](https://aka.ms/terminal-canary-zip-arm64)  |
| Portable ZIP  | x86             | [скачать](https://aka.ms/terminal-canary-zip-x86)    |

_Подробнее о [типах дистрибутивов Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Дорожная карта Windows Terminal

План развития Windows Terminal [описан здесь](/doc/roadmap-2023.md) и будет обновляться по мере развития проекта.

## Обзор Terminal и Console

Перед тем как приступить к работе с кодом, ознакомьтесь с кратким обзором ниже:

### Windows Terminal

Windows Terminal — это новое, современное, функциональное, производительное терминальное приложение для пользователей командной строки. Оно включает многие часто запрашиваемые функции, такие как поддержка вкладок, расширенное форматирование текста, глобализация, настройка, темы и стилизация и многое другое.

Terminal также должен соответствовать нашим целям и критериям, чтобы оставаться быстрым и эффективным, не потреблять много памяти или энергии.

### The Windows Console Host

Windows Console host (`conhost.exe`) — это оригинальный интерфейс командной строки Windows. Он также является хостом инфраструктуры командной строки Windows и сервером Windows Console API, движком ввода, движком отрисовки, пользовательскими настройками и т.д. Код консольного хоста в этом репозитории — это исходный код, из которого собирается `conhost.exe` в самой Windows.

С 2014 года, когда команда взяла на себя развитие командной строки Windows, в Console были добавлены такие функции, как прозрачность фона, выделение строк, поддержка [ANSI / Virtual Terminal последовательностей](https://en.wikipedia.org/wiki/ANSI_escape_code), [24-битный цвет](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/) и другие.

Однако, поскольку основной целью Windows Console является поддержка обратной совместимости, мы не смогли добавить многие функции, которых хотело сообщество (и сама команда), включая вкладки, Unicode-текст и эмодзи.

Эти ограничения привели к созданию нового Windows Terminal.

> Подробнее об эволюции командной строки вообще и командной строки Windows в частности читайте в [серии сопровождающих блог-постов](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) в блоге команды Command-Line.

### Общие компоненты

В процессе модернизации Windows Console мы существенно обновили кодовую базу, чётко разделили логические сущности на модули и классы, добавили ключевые точки расширяемости, заменили устаревшие самописные коллекции и контейнеры на более безопасные и эффективные [STL-контейнеры](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022), а также упростили и обезопасили код с помощью [Windows Implementation Libraries — WIL](https://github.com/Microsoft/wil) от Microsoft.

В результате этого ряда изменений несколько ключевых компонентов Console стали доступны для повторного использования в любых терминальных приложениях на Windows. Среди них: новый движок разметки и рендеринга текста на базе DirectWrite, текстовый буфер, поддерживающий хранение UTF-16 и UTF-8, парсер/эмиттер VT и другие.

### Создание нового Windows Terminal

Начав планирование нового приложения Windows Terminal, мы рассмотрели и оценили несколько подходов и технологических стеков. В итоге мы решили, что наши цели лучше всего достигнуты при дальнейшем развитии нашей C++-кодовой базы, что позволяет использовать многие из модернизированных компонентов как в существующем Console, так и в новом Terminal. Более того, это позволило нам реализовать большую часть ядра Terminal как повторно используемый UI-контрол, который другие смогут использовать в своих приложениях.

Результаты этой работы находятся в данном репозитории и доступны как приложение Windows Terminal, которое можно скачать из Microsoft Store или [непосредственно из релизов этого репозитория](https://github.com/microsoft/terminal/releases).

---

## Ресурсы

Больше информации о Windows Terminal вы найдете в следующих ресурсах:

* [Блог Command-Line](https://devblogs.microsoft.com/commandline)
* [Серия блогов Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Запуск Windows Terminal: [Terminal "Sizzle Video"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Запуск Windows Terminal: [Build 2019 Session](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal с Ричардом Тернером](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Эпизод 54 - Кайла Синнамон и Рич Тернер о DevOps и команде Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [Современная командная строка Windows: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### Я собрал и запустил новый Terminal, но он выглядит как старый консольный

Причина: Вы запускаете неправильное решение в Visual Studio.

Решение: Убедитесь, что вы собираете и развертываете проект `CascadiaPackage` в Visual Studio.

> [!ПРИМЕЧАНИЕ]
> `OpenConsole.exe` — это локально собранный `conhost.exe`, классическая консоль Windows, которая хостит инфраструктуру командной строки. OpenConsole используется Windows Terminal для подключения и взаимодействия с приложениями командной строки (через [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Документация

Вся документация по проекту расположена по адресу [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Если вы хотите внести вклад в документацию, пожалуйста, отправьте pull request в [репозиторий документации Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Вклад в проект

Мы рады работать вместе с вами, нашим замечательным сообществом, чтобы развивать и улучшать Windows Terminal!

***ПРЕЖДЕ чем начать работу над новой функцией/исправлением***, пожалуйста, прочитайте и следуйте нашему [Руководству для участников](./CONTRIBUTING.md), чтобы избежать лишних или дублирующих усилий.

## Связь с командой

Самый простой способ связаться с командой — через GitHub issues.

Пожалуйста, создавайте новые issues, запросы на функции и предложения, но **ОБЯЗАТЕЛЬНО ищите похожие открытые/закрытые существующие issues, прежде чем создавать новый.**

Если вы хотите задать вопрос, который, по вашему мнению, пока не заслуживает создания issue, свяжитесь с нами через Twitter:

* Кристофер Нгуен, менеджер продукта: [@nguyen_dows](https://twitter.com/nguyen_dows)
* Дастин Хауэтт, руководитель разработки: [@dhowett](https://twitter.com/DHowett)
* Майк Грис, старший разработчик: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Карлос Замора, разработчик: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Панкадж Бходжвани, разработчик
* Леонард Хекер, разработчик: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Руководство для разработчиков

## Требования

Вы можете подготовить вашу среду для сборки Terminal одним из двух способов:

### Использование WinGet configuration file

После клонирования репозитория вы можете использовать [конфигурационный файл WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine) для настройки вашей среды. [Файл конфигурации по умолчанию](.config/configuration.winget) устанавливает Visual Studio 2022 Community и остальные необходимые инструменты. В директории [.config](.config) есть еще два варианта файла конфигурации для Enterprise и Professional редакций Visual Studio 2022. Чтобы запустить файл конфигурации по умолчанию, дважды кликните его в проводнике или выполните команду:

```powershell
winget configure .config\configuration.winget
```

### Ручная настройка

* Вы должны использовать Windows 10 2004 (сборка >= 10.0.19041.0) или новее для запуска Windows Terminal
* Необходимо [включить Режим разработчика в приложении Параметры Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development) для локальной установки и запуска Windows Terminal
* Должен быть установлен [PowerShell 7 или новее](https://github.com/PowerShell/PowerShell/releases/latest)
* Должен быть установлен [SDK Windows 11 (10.0.22621.0)](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
* Должен быть установлен [VS 2022](https://visualstudio.microsoft.com/downloads/)
* Необходимо установить следующие Workloads через VS Installer. Примечание: При открытии решения в VS 2022 вас [попросят установить недостающие компоненты автоматически](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desktop Development with C++
  * Universal Windows Platform Development
  * **Следующие индивидуальные компоненты**
    * C++ (v143) Universal Windows Platform Tools
* Для сборки тестовых проектов необходимо установить [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack)

## Сборка кода

OpenConsole.sln можно собирать в Visual Studio или из командной строки с помощью набора скриптов и инструментов из директории **/tools**:

### Сборка в PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Сборка в Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Запуск и отладка

Для отладки Windows Terminal в VS кликните правой кнопкой по `CascadiaPackage` (в обозревателе решений) и выберите свойства. В меню Debug поменяйте "Application process" и "Background task process" на "Native Only".

После этого вы сможете собрать и отладить проект Terminal, нажав <kbd>F5</kbd>. Убедитесь, что выбрана платформа "x64" или "x86" — Terminal не собирается для "Any Cpu" (так как это приложение на C++, а не на C#).

> 👉 Вы _не сможете_ запустить Terminal напрямую, запустив WindowsTerminal.exe. Подробнее почему — смотрите [#926](https://github.com/microsoft/terminal/issues/926), [#4043](https://github.com/microsoft/terminal/issues/4043)

### Рекомендации по кодированию

Пожалуйста, ознакомьтесь с краткими документами ниже о наших практиках кодирования.

> 👉 Если вы обнаружили, что чего-то не хватает в документации, не стесняйтесь внести свой вклад в любой файл документации в репозитории (или написать новый!)

Документация будет пополняться по мере того, как мы узнаем, что нужно для эффективного вклада в наш проект.

* [Стиль кодирования](./doc/STYLE.md)
* [Организация кода](./doc/ORGANIZATION.md)
* [Исключения в нашем устаревшем коде](./doc/EXCEPTIONS.md)
* [Умные указатели и макросы для работы с Windows в WIL](./doc/WIL.md)

---

## Кодекс поведения

Этот проект использует [Кодекс поведения Microsoft Open Source][conduct-code]. Для дополнительной информации смотрите [FAQ по кодексу поведения][conduct-FAQ] или пишите на [opencode@microsoft.com][conduct-email] с дополнительными вопросами или комментариями.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---