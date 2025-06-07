# Microsoft PowerToys

![Hero image for Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Как использовать PowerToys][usingPowerToys-docs-link] | [Загрузки и примечания к выпуску][github-release-link] | [Вклад в развитие PowerToys](#contributing) | [Что нового](#whats-happening) | [Дорожная карта](#powertoys-roadmap)

## О программе

Microsoft PowerToys — это набор утилит для опытных пользователей, позволяющий настраивать и оптимизировать работу с Windows для повышения продуктивности. Подробнее о [PowerToys, обзорах и использовании утилит][usingPowerToys-docs-link], а также других инструментах и ресурсах для [разработки под Windows](https://learn.microsoft.com/windows/dev-environment/overview) читайте на [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Текущие утилиты:      |              |
|--------------|----------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Environment Variables](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [File Explorer Add-ons](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts File Editor](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Image Resizer](https://aka.ms/PowerToysOverview_ImageResizer) | [Keyboard Manager](https://aka.ms/PowerToysOverview_KeyboardManager) | [Mouse utilities](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Вставить как обычный текст](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registry Preview](https://aka.ms/PowerToysOverview_RegistryPreview) | [Screen Ruler](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Shortcut Guide](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Text Extractor](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Установка и запуск Microsoft PowerToys

### Требования

- Windows 11 или Windows 10 версии 2004 (кодовое имя 20H1 / номер сборки 19041) или новее.
- Процессор x64 или ARM64
- Наш установщик установит следующие компоненты:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) bootstrapper. Будет установлена последняя версия.

### Через GitHub с EXE [Рекомендуется]

Перейдите на [страницу релизов Microsoft PowerToys на GitHub][github-release-link] и нажмите `Assets` внизу, чтобы увидеть доступные файлы релиза. Пожалуйста, используйте подходящий установщик PowerToys, соответствующий архитектуре вашего компьютера и области установки. Для большинства пользователей это `x64` и установка для текущего пользователя.

<!-- элементы, которые нужно обновлять при каждом релизе -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Описание     | Имя файла | sha256 хеш  |
|---------------|-----------|-------------|
| Для пользователя - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Для пользователя - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Для всех пользователей - x64 | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Для всех пользователей - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Это наш предпочтительный способ установки.

### Через Microsoft Store

Установите из [страницы PowerToys в Microsoft Store][microsoft-store-link]. Вы должны использовать [новый Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/), который доступен как для Windows 11, так и для Windows 10.

### Через WinGet
Загрузите PowerToys с помощью [WinGet][winget-link]. При обновлении PowerToys через winget учитывается текущая область установки PowerToys. Для установки PowerToys выполните следующую команду в командной строке / PowerShell:

#### Установщик для пользователя [по умолчанию]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Установщик для всех пользователей

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Другие способы установки

Существуют [альтернативные способы установки](./doc/unofficialInstallMethods.md) от сообщества, такие как Chocolatey и Scoop. Если вы предпочитаете эти решения, инструкции по установке доступны там.

## Сторонние плагины Run

Существует коллекция [сторонних плагинов](./doc/thirdPartyRunPlugins.md), созданных сообществом, которые не распространяются вместе с PowerToys.

## Вклад в развитие

Этот проект приветствует всевозможные вклады. Помимо программирования новых функций и исправления ошибок, вы можете помочь с написанием спецификаций, дизайном, документацией и поиском ошибок. Мы рады работать с сообществом опытных пользователей, чтобы создать набор инструментов, помогающих получить максимум от Windows.

**Перед тем как приступить к работе над желаемой функцией**, пожалуйста, ознакомьтесь с нашим [руководством для участников](CONTRIBUTING.md). Мы с радостью поможем выбрать лучший подход, предоставим консультации и наставничество на протяжении всего процесса и поможем избежать лишней или дублирующейся работы.

Большинство вкладов требует согласия с [Соглашением о лицензии участника (CLA)][oss-CLA], подтверждающим, что вы предоставляете нам права на использование вашего вклада и имеете на это разрешение.

Для получения подробной информации о разработке для PowerToys ознакомьтесь с [документацией для разработчиков](/doc/devdocs). Там описано, как подготовить компьютер к компиляции проекта.

## Что нового

### Дорожная карта PowerToys

Наша [приоритетная дорожная карта][roadmap] функций и утилит, на которых сосредоточена основная команда.

### 0.91 — обновление за май 2025 года

В этом выпуске основной акцент сделан на новые функции, стабильность и автоматизацию.

**✨Основные моменты**

 - Мы значительно улучшили производительность Command Palette и исправили множество ошибок. Среди новых функций:
 - Добавлена возможность поиска любого файла через резервную команду в Command Palette.
 - Добавлена возможность сделать глобальную горячую клавишу Command Palette низкоуровневым перехватчиком клавиатуры.
 - Добавлена резервная команда открытия URL для расширения WebSearch — теперь можно открывать URL напрямую из Command Palette.
 - Теперь можно задавать собственные форматы для плагинов Дата и Время в PT Run и Command Palette. Спасибо [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - Исправлена ошибка, из-за которой Advanced Paste не создавал движок OCR для некоторых языковых тегов английского (например, en-CA) — теперь движок инициализируется на языке профиля пользователя. Спасибо [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - Исправлена утечка ресурсов, приводившая к зависаниям или сбоям, за счет корректного освобождения объекта Graphics. Спасибо [@dcog989](https://github.com/dcog989)!
 - Исправлена ошибка, из-за которой Color Picker завершал работу при нажатии Backspace — теперь закрытие происходит только при фокусе и согласовано поведение Escape/Backspace. Спасибо [@PesBandi](https://github.com/PesBandi)!
 - Добавлена поддержка цветовых форматов Oklab и Oklch в Color Picker. Спасибо [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - Обновлен скрипт WinGet Command Not Found: экспериментальные функции включаются только если действительно существуют.

### Command Palette

 - Обновлен шаблон ошибок, теперь включает модуль Command Palette.
 - Исправлен масштаб тостового окна для DPI — больше нет проблем с отображением при масштабировании экрана.
 - Исправлена ошибка: навигация клавишами Up/Down не перемещала выделение, если курсор был в позиции 0; добавлена непрерывная навигация как в PT Run v1. Спасибо [@davidegiacometti](https://github.com/davidegiacometti)!
 - Код расширения Time and Date упрощён и стал более понятным.
 - Исправлена ошибка: команда с заглавной буквой не срабатывала при переходе к указателю мыши — теперь команда переводится в нижний регистр.
 - Добавлена резервная команда открытия URL для расширения WebSearch — теперь можно открывать URL напрямую из Command Palette. Спасибо [@htcfreek](https://github.com/htcfreek)!
 - Добавлена настройка включения/отключения значка в системном трее для CmdPal и унификация терминологии с Windows 11. Спасибо [@davidegiacometti](https://github.com/davidegiacometti)!
 - Исправлено обновление алиасов: при установке нового алиаса старый удаляется.
 - Решён конфликт регистров GitHub путем переноса Exts и exts в новую директорию ext, что обеспечивает единую структуру и предотвращает фрагментацию путей.
 - Исправлена ошибка: команда "Создать новое расширение" создавала пустые имена файлов.
 - Добавлена возможность делать глобальную горячую клавишу низкоуровневым перехватчиком клавиатуры.
 - Добавлена поддержка JUMBO-миниатюр, что обеспечивает доступ к иконкам высокого разрешения.
 - Исправлены сбои при автоматическом скрытии CmdPal во время открытого диалога MSAL — теперь скрытие не происходит, если CmdPal отключен.
 - Добавлена поддержка мгновенного выделения поискового текста при загрузке страницы.
 - Исправлен баг: страницы настроек расширений не перезагружались при повторном открытии — теперь форма обновляется при сохранении настроек расширения.
 - Исправлена ошибка запуска Command Palette из runner.
 - Рефакторинг и перенос логики калькулятора из PowerToys Run v1 в Command Palette, добавлена поддержка настроек и улучшено поведение резервных команд.
 - Восстановлена поддержка горячих клавиш для элементов списка.
 - Улучшена доступность Command Palette — добавлены корректные метки, оптимизированы анимации, улучшена локализация, исправлены ошибки доступности.
 - Добавлена поддержка пользовательских форматов в плагин Time and Date, реорганизованы и очищены настройки, улучшены сообщения об ошибках и предотвращены сбои в граничных случаях. Спасибо [@htcfreek](https://github.com/htcfreek)!
 - Добавлен резервный элемент для системной команды.
 - Исправлен баг в Windows System Command: для действия "Открыть корзину" некорректно отображался "Empty" в подсказке клавиши. Спасибо [@jironemo](https://github.com/jironemo)!
 - Исправлена ошибка: в списке "больше команд" отображались неактуальные команды. Спасибо [@davidegiacometti](https://github.com/davidegiacometti)!
 - Исправлена ошибка: в режиме подробного просмотра отображалась слишком большая иконка и смещённый текст — теперь поведение соответствует Windows Search.
 - Исправлен баг: длинные подписи приводили к обрезке контента экрана и командной панели — теперь верстка корректна.
 - Улучшена интеграция CmdPal с WinGet: исправлен вывод версий для установленных пакетов, добавлены иконки для обновлений, переход на стабильную версию API winget.
 - Исправлен баг: команды для ContentPage обновлялись только после выхода, теперь контекстные меню инициализируются сразу при изменении.
 - Добавлена поддержка резервных запросов в расширение TimeDate — теперь можно делать прямые запросы даты/времени без выбора команды.
 - Добавлен импорт Common.Dotnet.AotCompatibility.props в несколько проектов CmdPal для улучшения поддержки AoT-компиляции.
 - Исправлен сбой настроек CmdPal из-за отсутствия HotKey при отсутствии settings.json или незаданной горячей клавиши. Спасибо [@davidegiacometti](https://github.com/davidegiacometti)!
 - Добавлена поддержка фильтруемых вложенных контекстных меню в CmdPal, включая строку поиска с сохранением поведения фокуса.
 - Рефакторинг классов CmdPal для улучшения сериализации JSON и введение новых контекстов сериализации для повышения производительности и удобства поддержки.
 - Добавлена поддержка компиляции ahead-of-time (AoT).
 - Добавлен механизм повторного запуска CmdPal.
 - Удалены неиспользуемые файлы из CmdPal.Common для упрощения кода и подготовки к AoT-совместимости.
 - Исправлен баг: из-за гонки при обновлении SearchText курсор в поле ввода перескакивал в конец строки — теперь SearchText обновляется только при фактическом изменении.
 - Добавлена поддержка поиска любого файла в резервной команде.
 - Очищен код, связанный с AoT, чтобы предотвратить дублирование операций при тестировании.
 - Сокращено время загрузки CmdPal за счет параллельного запуска расширений и таймаутов для предотвращения блокировки из-за некорректных расширений.
 - Улучшено поведение UI: панель подробностей скрывается при очистке списка, предотвращая некорректные визуальные состояния.
 - Добавлена возможность сбрасывать резервную команду в CmdPal при отсутствии совпадений, что обеспечивает более чистое поведение при перезагрузке.
 - Исправлена утечка в шаблоне расширения CmdPal, связанная с неправильным использованием ComServer.
 - Отключено разворачивание окна CmdPal на весь экран по двойному клику по заголовку. Спасибо [@davidegiacometti](https://github.com/davidegiacometti)!
 - Исправлена ошибка: окно настроек запускалось слишком маленьким — теперь размеры DPI-зависимы и установлен минимальный размер через WinUIEx.
 - Исправлены белая вспышка и проблемы с анимацией при первом запуске CmdPal — теперь окно маскируется вместо скрытия.
 - Исправлен баг: все настройки расширений загружались при старте — теперь используется ленивое получение настроек, что снижает нагрузку при инициализации.
 - Добавлена защита CmdPal от сбоев при ошибках парсинга Adaptive Card.
 - Заменено shell:AppsFolder на URI-активацию в CmdPal для повышения надежности.
 - Добавлена возможность открывать настройки CmdPal из настроек PowerToys.
 - Добавлена возможность CmdPal отслеживать и динамически обновлять детали расширений при изменениях выбранного элемента.
 - Обновлена версия набора инструментов в шаблоне расширения CmdPal до 0.2.0.

### Image Resizer

 - Исправлена ошибка, из-за которой при удалении пресета Image Resizer удалялся неверный пресет.

### Keyboard Manager

 - Исправлена ошибка: модификаторная клавиша без уточнения левой/правой могла "залипать" из-за неправильной обработки — теперь отслеживаются нажатые клавиши и отправляется корректная клавиша. Спасибо [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Улучшено форматирование времени в PowerRename: добавлены 12-часовые форматы с поддержкой AM/PM. Спасибо [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Добавлена поддержка пользовательских форматов в плагин "Время и дата" и улучшены сообщения об ошибках для некорректных форматов. Спасибо [@htcfreek](https://github.com/htcfreek)!
 - Исправлены два сбоя: для WFT на очень ранних датах и при вычислении недели месяца на очень поздних датах (например, 31.12.9999), а также реорганизованы настройки интерфейса. Спасибо [@htcfreek](https://github.com/htcfreek)!
 - Исправлена ошибка: команда с заглавной буквой не срабатывала при переходе к указателю мыши — теперь команда переводится в нижний регистр.
 - Добавлены сведения о версии в сообщения об ошибках плагинов для 'Loading error' и 'Init error'. Спасибо [@htcfreek](https://github.com/htcfreek)!
 - Улучшена модель результатов: теперь можно предотвращать сортировку на основе использования, что дает разработчикам плагинов больше контроля. Спасибо [@CoreyHayward](https://github.com/CoreyHayward) и [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Обновлено сопоставление букв в GetDefaultLetterKeyEPO: "ǔ" заменено на "ŭ" для VK_U согласно фонетике эсперанто. Спасибо [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Исправлена ошибка: Quick Accent работал некорректно при использовании экранной клавиатуры. Спасибо [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - Расширен функционал Registry Preview: теперь можно вставлять ключи и значения реестра без ручного добавления заголовка файла, добавлена кнопка сброса приложения. Спасибо [@htcfreek](https://github.com/htcfreek)!

### Настройки

 - Исправлена ошибка, из-за которой приложение настроек случайным образом показывало пустую иконку на панели задач — теперь иконка задается при активации окна.
 - Добавлена возможность разворачивать окно "Что нового" для комфортного чтения.

### Workspaces

 - Исправлены ошибки: игры Steam не захватывались или запускались корректно — теперь фильтрация окон и поддержка протокола Steam URL обновлены.

### Документация

 - Добавлены QuickNotes в документацию сторонних плагинов PowerToys Run. Спасибо [@ruslanlap](https://github.com/ruslanlap)!
 - Добавлены плагины Weather и Pomodoro в документацию сторонних плагинов PowerToys Run. Спасибо [@ruslanlap](https://github.com/ruslanlap)!
 - Добавлен плагин Linear в документацию сторонних плагинов PowerToys Run. Спасибо [@vednig](https://github.com/vednig)!
 - Исправлены ошибки форматирования в документации, обновлены сведения об участниках и членах команды. Спасибо [@DanielEScherzer](https://github.com/DanielEScherzer) и [@RokyZevon](https://github.com/RokyZevon)!

### Разработка

 - Обновлен GitHub Action для установки .NET 9 для поддержки релиза MSStore.
 - Обновлен шаблон версии в bug_report.yml для предотвращения некорректной версии v0.70.0 в отчетах об ошибках.
 - Обновлен GitHub Action: actions/setup-dotnet обновлен с версии 3 до 4 для выпуска в MSStore.
 - Добавлен securityContext в конфиги WinGet, что позволяет вызывать из контекста пользователя и запрашивать одно UAC для привилегированных ресурсов в отдельном процессе. Спасибо [@mdanish-kh](https://github.com/mdanish-kh)!
 - Изменено расширение логов с .txt на .log для корректных ассоциаций файлов и совместимости с инструментами, добавлены логи для Workspace. Спасибо [@benwa](https://github.com/benwa)!
 - Обновлены зависимости тестовых фреймворков, приведены версии пакетов к единому виду.
 - Обновлены зависимости для устранения уязвимостей.
 - Повышена безопасность репозитория: GitHub Actions и Docker-теги закреплены за неизменяемыми коммитами, добавлено автоматическое сканирование зависимостей на уязвимости через Dependency Review Workflow. Спасибо [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Обновлены зависимости Boost до новой версии.
 - Обновлен набор инструментов до последней версии, подавлены предупреждения, связанные с AoT.
 - Исправлена ошибка сборки из-за отсутствия подписи для новых файлов.
 - Обновлен релизный pipeline для запрета публикации приватных символов на 100 лет.
 - Внедрено fuzzing-тестирование для PowerRename для повышения надежности, добавлены инструкции по расширению fuzzing на другие C++ модули.
 - Добавлено централизованное предварительное создание генерируемых папок для всех проектов .csproj для предотвращения сбоев сборки.
 - Обновлен WinAppSDK до последней версии 1.7.
 - Обновлены зависимости Boost до последней версии для проекта PowerRename Fuzzing.
 - Обновлен путь ADO area в tsa.json для устранения ошибок TSA pipeline, вызванных устаревшим путем.
 - Инициирована поддержка AoT для CmdPal — базовые работы в процессе.

### Инструменты/Общее

 - Добавлена автоматизация создания отчетов об ошибках — теперь генерируется предзаполненная ссылка на GitHub с системной и диагностической информацией. Спасибо [@donlaci](https://github.com/donlaci)!
 - Добавлены скрипты для локальной сборки установщика, обеспечивающие запуск CmdPal в локальной среде.
 - Удалена логика экспорта PFX для устранения жестко заданного пароля и предупреждения безопасности PSScriptAnalyzer.
 - Добавлен скрипт PowerShell и интеграция с CI для обеспечения единого использования Common.Dotnet.CsWinRT.props во всех C# проектах в папке src.
   
### Что планируется в версии 0.92

Для [v0.92][github-next-release-work] в работе следующие задачи:

 - Дальнейшая доработка Command Palette
 - Новые тесты UI Automation
 - Работа над обновлениями установщика
 - Улучшение интерфейса редактора Keyboard Manager
 - Повышение стабильности / исправление ошибок

## Сообщество PowerToys

Команда PowerToys чрезвычайно благодарна за [поддержку активного сообщества][community-link]. Ваша работа очень важна. Без вашей помощи — отчетов об ошибках, обновления документации, участия в дизайне и разработки новых функций — PowerToys не был бы тем, чем он является. Мы хотим поблагодарить вас и отметить ваш вклад. Каждый месяц вы делаете PowerToys лучше.

## Кодекс поведения

В этом проекте принят [Кодекс поведения Microsoft Open Source][oss-conduct-code].

## Заявление о конфиденциальности

Приложение ведет базовый диагностический журнал (телеметрию). Подробнее о конфиденциальности и собираемых данных читайте в [документации по данным и конфиденциальности PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---