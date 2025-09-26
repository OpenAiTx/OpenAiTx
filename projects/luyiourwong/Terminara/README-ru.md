
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Спросить DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Поддержка Python](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

Терминальная игра-симулятор с искусственным интеллектом.

## Как использовать

Вы можете скачать исполняемое приложение с [последнего релиза](https://github.com/luyiourwong/Terminara/releases/latest).

Полный архив содержит исполняемый файл и файл настроек мира по умолчанию. Если вы обновляете игру до последней версии, можно скачать только исполняемый файл.

| ОС      | Версия                                           |
|---------|--------------------------------------------------|
| Windows | Windows 10, Windows 11                           |
| Linux   | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS |
| MacOS   | macOS 13, macOS 14, macOS 15, macOS 26           |

<details>
<summary><strong>Ручной запуск</strong></summary>

### Установка

1.  **Клонируйте репозиторий:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Создайте виртуальное окружение:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    В Windows используйте `.venv\Scripts\activate`

3.  **Установите зависимости:**
    ```bash
    pip install -e .
    ```

### Метод запуска 1: Использование установленной команды (Рекомендуется)
После установки запустите игру с помощью:
```bash
terminara
```

### Способ запуска 2: Прямое выполнение
Кроссплатформенный способ
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
В Windows используйте `terminara\main.py`

для получения дополнительной информации смотрите [Руководство по вкладу и разработке](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## Настройка ИИ

После запуска приложения необходимо настроить параметры ИИ из главного меню.

![Настройки ИИ](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Вам нужно заполнить следующие поля: (API, совместимый с OpenAI)
- **Host**: Конечная точка API. Оставьте пустым для использования стандартной конечной точки OpenAI.
- **API Key**: Ваш API-ключ для AI-сервиса.
- **Model**: Модель, которую вы хотите использовать.

Нажмите "Применить", чтобы сохранить настройки.

### Примеры

#### 1. [OpenAI](https://platform.openai.com/) (по умолчанию)
- **Host**: (оставьте пустым)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## Настройка мира

### Хранение конфигурации
Настройки мира хранятся в директории `terminara/data/worlds`. (в полном релизе)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Создание нового мира
Существует пример мира [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Вы можете следовать [схеме](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) для создания нового мира.

## Ссылки

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [GitHub Репозиторий](https://github.com/luyiourwong/Terminara)
- [Руководство по участию и разработке](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Лицензия

Этот проект лицензирован по [лицензии MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---