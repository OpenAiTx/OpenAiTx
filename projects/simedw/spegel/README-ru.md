# Spegel – Отражайте веб через ИИ

Автоматически переписывает веб-сайты в markdown, оптимизированный для просмотра в терминале.
Прочитайте вводный блог-пост [здесь](https://simedw.com/2025/06/23/introducing-spegel/)

Это прототип, ожидаются ошибки, но не стесняйтесь создавать issue или pull request.

##  Скриншот
Иногда не хочется читать чью-то биографию, чтобы добраться до рецепта
![Recipe Example](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Установка

Требуется Python 3.11+

```
pip install spegel
```
или клонируйте репозиторий и установите в режиме редактирования

```bash
# Клонируйте и войдите в директорию
$ git clone <repo-url>
$ cd spegel

# Установите зависимости и CLI
$ pip install -e .
```

## API-ключи
Spegel в настоящее время поддерживает только Gemini 2.5 Flash, для использования необходимо указать свой API-ключ в переменной окружения

```
GEMINI_API_KEY=...
```


## Использование

### Запуск браузера

```bash
spegel                # Запуск с приветственным экраном
spegel bbc.com        # Сразу открыть URL
```

Или, эквивалентно:

```bash
python -m spegel      # Запуск с приветственным экраном
python -m spegel bbc.com
```

### Основные команды
- `/`         – Открыть ввод URL
- `Tab`/`Shift+Tab` – Переключение между ссылками
- `Enter`     – Открыть выбранную ссылку
- `e`         – Редактировать LLM-промпт для текущего вида
- `b`         – Назад
- `q`         – Выйти

## Редактирование настроек

Spegel загружает настройки из конфигурационного файла TOML. Вы можете настроить виды, промпты и параметры интерфейса.

**Порядок поиска конфиг-файла:**
1. `./.spegel.toml` (текущая директория)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Для редактирования настроек:
1. Скопируйте пример конфига:
   ```bash
   cp example_config.toml .spegel.toml
   # или создайте ~/.spegel.toml
   ```
2. Отредактируйте `.spegel.toml` в любимом редакторе.

Пример фрагмента:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

Для подробностей смотрите код или создайте issue!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---