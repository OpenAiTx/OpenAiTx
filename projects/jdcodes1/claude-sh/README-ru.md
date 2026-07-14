
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=jdcodes1&project=claude-sh&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# claude.sh

Код Claude переписан как bash-скрипт. ~1,500 строк. Никаких npm-пакетов.

## Почему

Оригинальный Claude Code — это ~380,000 строк TypeScript с 266 зависимостями npm. Этот скрипт выполняет ту же основную задачу на bash, используя только `curl` и `jq`.

## Возможности

- **Потоковая передача в реальном времени** через FIFO-канал — текст появляется по мере генерации Claude
- **6 инструментов**: Bash, Read, Edit, Write, Glob, Grep
- **Связывание инструментов** — до 25 вызовов инструментов за один ход
- **Запрос разрешения** — спрашивает перед запуском небезопасных команд (`y/n/a`)
- **Загрузка CLAUDE.md** — читает инструкции проекта из файлов CLAUDE.md по иерархии каталогов
- **Контекст, учитывающий Git** — ветка, статус и последние коммиты в системной подсказке
- **Сохранение/возобновление сессии** — автосохранение при выходе, возобновление с `--resume <id>`
- **Повтор с обратным отсчетом** — экспоненциальная повторная попытка при ограничениях 429/529
- **Отслеживание стоимости** — по каждому ходу и за всю сессию
- **Спиннер** — с оригинальными глаголами спиннера (Clauding, Flibbertigibbeting и др.)
- **Слэш-команды** — `/help`, `/cost`, `/model`, `/clear`, `/save`, `/resume`, `/commit`, `/diff`
- **Режим канала** — `echo "объясни это" | ./claude.sh`

## Установка

```bash
git clone https://github.com/jdcodes1/claude.sh.git
cd claude.sh
chmod +x claude.sh
```

## Зависимости

- `curl`
- `jq`
- Необязательно: `rg` (ripgrep) для улучшенного поиска
- Необязательно: `python3` для инструмента редактирования

Версии среды выполнения закреплены в `.tool-versions`. Установите их с помощью [mise](https://mise.jdx.dev/):

```bash
mise install
```

## Использование

```bash
export ANTHROPIC_API_KEY="sk-ant-..."
./claude.sh
```

### Переменные среды

| Переменная | Значение по умолчанию | Описание |
| --- | --- | --- |
| `ANTHROPIC_API_KEY` | (обязательно) | Ваш API-ключ Anthropic |
| `CLAUDE_MODEL` | `claude-sonnet-4-6` | Используемая модель |
| `CLAUDE_MAX_TOKENS` | `8192` | Максимальное количество токенов в выводе |
| `ANTHROPIC_API_URL` | `https://api.anthropic.com` | Базовый URL API |
| `CLAUDE_SH_PERMISSIONS` | `ask` | Режим разрешений: `ask`, `allow` или `deny` |

### Команды

```txt
/help      — Show help
/cost      — Show session cost
/model     — Show/change model
/clear     — Clear conversation
/save      — Save current session
/resume    — List/resume saved sessions
/commit    — Auto-generate a git commit
/diff      — Show git diff
/quit      — Exit
```

### Возобновить сессию

```bash
# List saved sessions
./claude.sh
> /resume

# Resume by number
> /resume 1

# Resume from CLI
./claude.sh --resume 20240101-120000-12345
```

## Архитектура

```txt
claude.sh          # Main REPL loop, slash commands, process_turn()
lib/
  api.sh           # Anthropic API client, SSE streaming via FIFO, retry
  json.sh          # Message construction, session persistence, CLAUDE.md, git context
  tools.sh         # 6 tool implementations + permission system
  tui.sh           # ANSI colors, spinner, display helpers
```

## Как это работает

1. Считывание пользовательского ввода
2. Формирование JSON-запроса с помощью `jq` (сообщения, инструменты, системный промпт)
3. Стриминг ответа через `curl` через FIFO-пайп
4. Парсинг SSE-событий построчно, вывод текстовых изменений в реальном времени
5. При получении tool_use-блоков выполняются инструменты
6. Результаты инструментов возвращаются как сообщения
7. Цикл продолжается, пока Claude не перестанет вызывать инструменты

## Сравнение

| | claude.sh | Claude Code (TypeScript) |
| --- | --- | --- |
| Количество строк кода | ~1,500 | ~380,000 |
| Зависимости | curl, jq | 266 npm пакетов |
| Размер бинарника | 0 (скрипт) | ~200MB node_modules |
| Время запуска | Мгновенно | ~500мс |

### Тестирование

Тесты используют [bats](https://github.com/bats-core/bats-core) (Bash Automated Testing System):

```bash
bats test/
```

## License

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-14

---