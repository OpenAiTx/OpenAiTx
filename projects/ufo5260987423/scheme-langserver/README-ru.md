![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Вы можете прочитать мою [статью](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) и цитировать следующим образом: 
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Поскольку GitHub может блокировать китайские IP-адреса, мне пришлось скопировать этот репозиторий [сюда](https://codeberg.org/ufo5260987423/scheme-langserver) и [сюда](https://gitee.com/ufo5260987423/scheme-langserver). Я буду продолжать обновлять все репозитории, но не могу гарантировать. Сейчас я также сотрудничаю с [XmacsLabs](https://github.com/XmacsLabs), вы также можете найти форк [здесь](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Теперь VSCode может использовать scheme-langserver!** Пожалуйста, смотрите [ЗДЕСЬ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>ПРИМЕЧАНИЕ: В scheme-langserver много багов. Я сейчас их исправляю и прошу помощи у сообщества. Пожалуйста, наберитесь терпения.

>ПРИМЕЧАНИЕ: вы можете найти автоматически сгенерированную информацию о типах [здесь](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Сейчас она в основном используется для дальнейшей разработки (возможно, включая AKKU) и отладки.

Реализация поддержки таких функций, как автодополнение, переход к определению или документация при наведении, требует значительных усилий при программировании. Однако, по сравнению с такими языками, как java, python, javascript и c, реализации протокола language server для языков семейства lisp создаются практически в вакууме. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) и [swish-lint](https://github.com/becls/swish-lint) и др. работают на основе `repl` (Read-Eval-Print Loop) или токенизации по ключевым словам, а не полноценного программного анализа. Например, если программист работает над незавершённым проектом, где код не полностью исполним, [Geiser](https://gitlab.com/emacs-geiser) или любой другой инструмент завершит только идентификаторы верхнего уровня, перечисленные через процедуру `environment-symbols` (для [Chez](https://cisco.github.io/ChezScheme/)), или завершит символы вместо идентификаторов. Это означает, что для локальных привязок и незавершённого кода, несмотря на важность программного анализа, [Geiser](https://gitlab.com/emacs-geiser) и его аналоги никак не помогают распознать область видимости идентификатора. Похожие проблемы встречаются при переходе к определению и многих других функциях.

Основная причина в том, что для scheme и других диалектов lisp их обилие структур данных и гибкие управляющие конструкции делают анализ программ очень сложным. Особенно макросы — кажется, что scheme в основном предназначен для гениального и мета/макро программирования. Но я считаю, что это не так. Scheme может быть использован для множества интересных задач, если предоставить хорошую среду разработки. И теперь вы можете [**НАЧАТЬ ЗДЕСЬ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Этот пакет — реализация протокола language server, помогающая при программировании на scheme. Он предоставляет автодополнение, переход к определению и вывод типов. Эти функции основаны на статическом анализе кода с учетом [стандарта r6rs](http://www.r6rs.org/) и некоторых очевидных правил для незавершённого кода. Сам пакет и связанные с ним библиотеки опубликованы или будут опубликованы через [Akku](https://akkuscm.org/), который является менеджером пакетов для Scheme.

Этот пакет также был протестирован с [Chez Scheme](https://cisco.github.io/ChezScheme/) версий 9.4 и 9.5. Подробное тестирование на версии 10.0.0 будет проведено после обновления моей ОС ноутбука до более новой версии.

Я занимаюсь этим open source проектом только в свободное время и могу внести в сообщество множество интересных идей, например, встраивание анализа потоков данных в scheme-langserver и многое другое. Я также постоянно прошу о пожертвованиях и финансировании. Вы можете поддержать меня через [эту страницу на Patreon](https://www.patreon.com/PoorProgrammer/membership) или через [爱发电](https://afdian.com/a/ufo5260987423).


## Компиляция, установка и настройка [ЗДЕСЬ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Текущий статус
Я продолжаю исправлять баги, профилировать код и собирать материал для моей большой книги о системе вывода типов. Это займёт около года. Дальнейшая разработка включает в себя плагин для [VScode](https://code.visualstudio.com/) и анализ потоков данных. Но сейчас я воспринимаю эту open source работу как подработку и не могу гарантировать сроки.

## Релиз 
1.2.9 Теперь доступен вывод типов!

Информацию о предыдущих релизах смотрите в [этом файле](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Возможности
1. Автодополнение идентификаторов верхнего уровня и локальных идентификаторов.
![Автодополнение идентификаторов верхнего уровня и локальных идентификаторов](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Переход к определению.
![Переход к определению с telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Совместимость с менеджером пакетов Akku.
4. Синхронизация изменений файлов и соответствующее обновление индекса.
5. Наведение (hover).
6. Поиск ссылок и подсветка документа (references внутри документа).
![Поиск ссылок с telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Символы документа.
![Поиск символов документа с telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Обработка локальных привязок идентификаторов через *-syntax (define-syntax, let-syntax и др.).
9. Кроссплатформенная параллельная индексация.
10. Собственный аннотатор исходного кода для поддержки .sps файлов.
11. Peephole-оптимизация запросов API с приостановимыми задачами.
12. Вывод типов с помощью собственного интерпретатора DSL (я этим очень горжусь!). Теперь он встроен в автодополнение. Как видно на рисунке ниже, "length-b" и "length-a" с типом "integer?" находятся в начале рекомендуемых вариантов, потому что они соответствуют требуемому типу параметра для "<=".
![Автодополнение с выводом типов](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Тест может подтвердить этот результат, просто выполните `scheme --script tests/protocol/apis/test-completion.sps` и лог-файл `scheme-langserver.log` будет содержать следующие строки:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Абстрактный интерпретатор для поиска идентификаторов в различных расширениях файлов: scm, ss, sps, sls и sld.

### В ПЛАНАХ
14. Переименование.
15. Полная совместимость со [стандартом r6rs](http://www.r6rs.org/).
16. Пошаговый макро-расширитель: на самом деле я уже реализовал один и хотел сделать его ключевым этапом для поиска привязок идентификаторов в пользовательских макросах. Сейчас я понимаю, что это сложнее, чем я думал, и не знаю, где именно этот расширитель будет работать.
17. Выполнение кода.
18. Диагностика кода.
19. Добавить поддержку кросс-языковой семантики. Можно ли реализовать поддержку java, c, python и других языков с помощью AST-трансформатора?
20. Выделение выражений/операторов в отдельную процедуру.

## TODO: Вклад в проект

## Отладка

### Как отлаживать
https://www.scheme.com/debug/debug.html#g1

### Вывод логов
Следуя советам из разделов [Сборка](#building), [Установка для Lunar Vim](#installation-for-lunarvim) и [Установка для VScode](#todo-installation-for-vscode), если кто-то хочет заняться разработкой и логировать что-то, будет удобно добавить `path-to-log-file` и переписать файл `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` следующим образом:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
}
```
### Повторное использование с журналом (Log)
С помощью приведенного выше [журнала вывода](#output-log) вы можете использовать `tests/log-debug.sps` для воспроизведения ошибок:
1. Переименуйте `{path-to-log}` (обычно `~/scheme-langserver.log`) в `~/ready-for-analyse.log`;
2. Запустите `scheme --script tests/log-debug.sps`. Если вы хотите воспроизвести многопоточную среду, также возможно запустить `scheme --script tests/log-debug.sps`.

## Тестирование
Почти все ключевые процедуры и API протестированы. Моя работа довольно грубая, но полезная, возможно, вам будет интересно посмотреть, что я сделал в каталоге `tests`, или просто выполните следующую команду в `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>ПРИМЕЧАНИЕ
Трудно тестировать в многопоточной среде. Поэтому текущие тесты сосредоточены на одном потоке.

## Использование Scheme-langserver для других целей
### Script-Fu в GIMP
Script-Fu основан на интерпретируемом языке Scheme и работает с помощью функций, которые взаимодействуют с внутренними функциями GIMP. Взяв за пример скрипт с [этой страницы](https://dalelane.co.uk/blog/?p=628), вы можете применять scheme-langserver к файлам скриптов с расширением "SCM".

### Прочее

Я также интересуюсь [OMN (Opusmodus Notation)](https://opusmodus.com/) и AutoLisp. Но у меня еще много дел.

## Подсчет строк кода
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Подробная документация
1. [Scheme-langserver: Относитесь к редактированию кода Scheme как к первостепенной задаче](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Отслеживание привязок идентификаторов](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Синхронизация](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Вывод типов](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[Типовое выведение](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Устарело, и я пишу по этому поводу книгу на китайском)
5. [Анализ API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## История звезд

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Участники

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---