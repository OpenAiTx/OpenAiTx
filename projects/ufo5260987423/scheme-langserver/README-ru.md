<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Вы можете ознакомиться с моей [статьей](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) и процитировать её так:
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Поскольку GitHub может блокировать IP-адреса из Китая, мне пришлось скопировать этот репозиторий [сюда](https://codeberg.org/ufo5260987423/scheme-langserver) и [сюда](https://gitee.com/ufo5260987423/scheme-langserver). Я буду продолжать обновлять все репозитории, но не могу гарантировать это. Сейчас я также сотрудничаю с [XmacsLabs](https://github.com/XmacsLabs), вы также можете найти форк [здесь](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Теперь VSCode может использовать scheme-langserver!** Пожалуйста, смотрите [ЗДЕСЬ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>ПРИМЕЧАНИЕ: В scheme-langserver очень много багов. Я их исправляю и обращаюсь за помощью к сообществу. Пожалуйста, проявите терпение.

>ПРИМЕЧАНИЕ: Автоматически сгенерированную информацию о типах можно найти [здесь](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). В настоящее время она используется в основном для дальнейшей разработки (возможно, включая AKKU) и отладки.

Реализация поддержки таких функций, как автодополнение, переход к определению или документация при наведении, является значительным трудом для программирования. Однако по сравнению с такими языками, как java, python, javascript и c, реализация language server protocol для lisp-языков создаётся практически в вакууме. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) и [swish-lint](https://github.com/becls/swish-lint) и др. — их работа основана на `repl` (Read-Eval-Print Loop) или токенизаторе ключевых слов, а не на программном анализе. Например, если программист пишет код для незавершённого проекта, где код не полностью исполняемый, [Geiser](https://gitlab.com/emacs-geiser) или другие смогут автодополнить только идентификаторы верхнего уровня, перечисленные функцией `environment-symbols` (для [Chez](https://cisco.github.io/ChezScheme/)), или дополнят только символы, но не идентификаторы. Это значит, что для локальных связываний и незавершённого кода, несмотря на важность поддержки программирования, [Geiser](https://gitlab.com/emacs-geiser) и аналоги не помогают в распознавании области видимости идентификаторов. Похожие ситуации наблюдаются с переходом к определению и многими другими функциями.

Основная причина в том, что для scheme и других диалектов lisp их обилие структур данных и гибкость управляющих конструкций создают серьёзные сложности для анализа программ. Особенно макросы — кажется, что scheme в основном используется для гениального и мета/макро-программирования. Но я считаю иначе. Scheme может быть интересным для многих задач, если обеспечить хорошую среду разработки. И сейчас вы можете [**НАЧАТЬ ЗДЕСЬ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Этот пакет — реализация language server protocol, помогающая при разработке на scheme. Он обеспечивает автодополнение, переход к определению и вывод типов. Эти функции основаны на статическом анализе кода по [стандарту r6rs](http://www.r6rs.org/) и некоторым очевидным правилам для незавершённого кода. Сам пакет и связанные с ним библиотеки опубликованы или будут опубликованы с помощью [Akku](https://akkuscm.org/) — менеджера пакетов для Scheme.

Пакет протестирован с [Chez Scheme](https://cisco.github.io/ChezScheme/) версий 9.4 и 9.5. Подробное тестирование для версии 10.0.0 будет проведено после обновления ОС на моём ноутбуке.

Я занимаюсь этим open source проектом только в свободное время и могу внести много отличных идей в сообщество, например, интеграция анализа потоков данных в scheme-langserver и многое другое. Я постоянно прошу о донатах или финансировании. Вы можете поддержать меня через [эту страницу Patreon](https://www.patreon.com/PoorProgrammer/membership) или [爱发电](https://afdian.com/a/ufo5260987423).


## Компиляция, установка и настройка [ЗДЕСЬ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Последний статус
Я продолжаю исправлять баги, профилировать код и собирать информацию для своей большой книги о самодельной системе вывода типов. Это займёт у меня примерно 1 год. В дальнейшем планируется разработка [плагина для VScode](https://code.visualstudio.com/) и анализ потоков данных. Но на самом деле сейчас этот open source проект для меня — работа на полставки, и я не могу гарантировать сроки.

## Релиз 
1.2.9 Теперь можно использовать вывод типов!

О предыдущих релизах смотрите [этот файл](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Возможности
1. Автодополнение идентификаторов верхнего уровня и локальных связываний.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Переход к определению.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Совместимость с менеджером пакетов Akku.
4. Синхронизация изменений файлов и обновление соответствующего индекса.
5. Наведение (hover).
6. Поиск ссылок и подсветка документа (ссылки в пределах документа).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Символы документа.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Обработка *-syntax (define-syntax, let-syntax и др.) для локального связывания идентификаторов.
9. Кроссплатформенная параллельная индексация.
10. Собственный аннотатор исходного кода для поддержки файлов .sps.
11. Peephole-оптимизация для API-запросов с приостанавливаемыми задачами.
12. Вывод типов с помощью самодельного интерпретатора DSL (я очень этим горжусь!). Сейчас он встроен в автодополнение. Как показано на рисунке ниже, "length-b" и "length-a" с типом "integer?" находятся в начале списка рекомендуемых опций, потому что они соответствуют требуемому типу параметра для "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Тест это подтверждает, просто выполните `scheme --script tests/protocol/apis/test-completion.sps`, и в файле журнала `scheme-langserver.log` появятся результаты вроде:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Абстрактный интерпретатор для поиска идентификаторов между файлами с расширениями scm, ss, sps, sls и sld.

### TODO
14. Переименование.
15. Полная совместимость со [стандартом r6rs](http://www.r6rs.org/).
16. Пошаговый макро-экспандер: на самом деле, я уже реализовал его и хотел использовать для поиска связываний идентификаторов в пользовательских макросах. Сейчас я вижу, что эта задача намного сложнее, чем я думал, и сам экспандер — не знаю, где он может пригодиться.
17. Выполнение кода.
18. Диагностика кода.
19. Добавить поддержку семантики для разных языков. Может ли поддержка Java, C, Python и многих других языков осуществляться с помощью трансформатора AST?
20. Выделение выражений/операторов в процедуру.

## TODO: Вклад в проект

## Отладка

### Как отлаживать
https://www.scheme.com/debug/debug.html#g1

### Журнал вывода
Следуя советам из разделов [Сборка](#building), [Установка для Lunar Vim](#installation-for-lunarvim) и [Установка для VScode](#todo-installation-for-vscode), если кто-то хочет заняться разработкой и записать что-то в журнал, будет удобно добавить `path-to-log-file` и переписать файл `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` следующим образом:
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
`scheme-langserver`, реализация протокола серверов языка для Scheme
]]   ,
  },
}
```
### Повторение с журналом 
С вышеуказанным [журналом вывода](#output-log) вы можете использовать `tests/log-debug.sps` для повторного воспроизведения ошибок:
1. Переименуйте `{path-to-log}` (обычно `~/scheme-langserver.log`) в `~/ready-for-analyse.log`;
2. Запустите `scheme --script tests/log-debug.sps`. Если вы хотите воспроизвести многопоточное окружение, также можно выполнить `scheme --script tests/log-debug.sps`.

## Тестирование
Почти все ключевые процедуры и API протестированы. Моя работа довольно грубая, но полезная, возможно, вы захотите посмотреть, что я сделал в каталоге `tests` или просто выполнить следующую команду в `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>ПРИМЕЧАНИЕ
Сложно тестировать в многопоточном окружении. Поэтому текущие тесты ориентированы на однопоточность.

## Использование Scheme-langserver для других целей
### Script-Fu в GIMP
Script-Fu основан на интерпретируемом языке Scheme и работает с помощью функций, взаимодействующих с внутренними функциями GIMP. Взяв в качестве примера скрипт с [этой страницы](https://dalelane.co.uk/blog/?p=628), вы можете применять scheme-langserver к скриптам с расширением "SCM".

### Другое

Я также интересуюсь [OMN (Opusmodus Notation)](https://opusmodus.com/) и AutoLisp. Но у меня еще много дел.

## Подсчет строк кода
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Подробная документация
1. [Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Отслеживание привязок идентификаторов](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Синхронизация](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Вывод типов](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[Типизация](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Устарело, сейчас я пишу книгу на китайском по этой теме)
5. [Анализ API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## История звёзд

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Участники

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---