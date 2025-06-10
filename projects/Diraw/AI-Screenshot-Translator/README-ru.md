# AI Screenshot Translator (AI 截图翻译工具)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Введение

Этот инструмент с помощью **простых операций скриншота** отправляет изображение в AI-модель для распознавания и перевода текста, а затем отображает результат перевода в интерактивном HTML-формате в отдельном окне.

Инструмент поддерживает **настраиваемые горячие клавиши для запуска, управление несколькими окнами результатов и работу через системный трей**, что значительно повышает эффективность перевода в повседневной работе и учебе.

**Особенности инструмента**: 1. Перевод скриншотов, запуск по горячей клавише; 2. Перевод и закрепление скриншотов, свободное перемещение и масштабирование, возможность создавать несколько групп закрепленных переводов; 3. Для формул доступно переключение на исходный текст для удобного копирования; 4. Настраиваемый API-интерфейс.

**Проблемы, которые решает инструмент**: 1. Существующие на рынке решения для перевода целых документов избыточны и неудобны; 2. При копировании текста из PDF для перевода формульные блоки часто искажаются или не поддаются копированию; 3. Для отсканированных PDF-изображений невозможно скопировать текст.

# Демонстрация

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Окна приложения

Окно перевода:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Окно настроек:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Более подробное описание опций конфигурации можно посмотреть внутри программы или на веб-странице [Подсказка](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Установка

Вы можете скачать исходный код для запуска или перейти на страницу [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) для загрузки исполняемого файла.

### 1. Клонировать репозиторий

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Создать виртуальное окружение и запустить

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# План обновлений

- ~~Добавлен GUI для настройки API, оптимизирована логика ручной настройки yaml-файла, теперь файл генерируется автоматически (реализовано в v0.3.0)~~
- Добавление системы хранения изображений и формул для удобного последующего использования (ожидается в v0.4)
- (Для предложений новых функций — создавайте issue или вносите вклад через PR)

# Прочее

- Иконка программы взята с [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Благодарность Gemini 2.5 Flash и DeepSeek-V3-0324 за помощь в поиске багов

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---