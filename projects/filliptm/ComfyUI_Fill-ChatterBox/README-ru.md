<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Если вам нравится этот проект, поддержите меня на Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Пользовательское расширение узла для ComfyUI, добавляющее возможности преобразования текста в речь (TTS) и конвертации голоса (VC) с использованием библиотеки Chatterbox.
Поддерживается МАКСИМАЛЬНАЯ длина 40 секунд. Я пытался снять это ограничение, но модель работает очень плохо с более длинными аудиофрагментами, поэтому ограничение оставлено.

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Установка

1. Клонируйте этот репозиторий в директорию custom_nodes вашего ComfyUI:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Установите основные зависимости:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Необязательно) Установите поддержку водяных знаков:

   ```bash
   pip install resemble-perth
   ```
**Примечание**: Пакет `resemble-perth` может иметь проблемы совместимости с Python 3.12+. Если возникают ошибки импорта, узлы будут работать и без водяных знаков.


## Использование

### Узел преобразования текста в речь (FL Chatterbox TTS)
- Добавьте узел "FL Chatterbox TTS" в свой рабочий процесс
- Настройте текстовый ввод и параметры (exaggeration, cfg_weight, temperature)
- При необходимости укажите аудиоподсказку для клонирования голоса

### Узел преобразования голоса (FL Chatterbox VC)
- Добавьте узел "FL Chatterbox VC" в свой рабочий процесс
- Подключите входное аудио и целевой голос
- Оба узла поддерживают работу на CPU при ошибках CUDA

## Журнал изменений

### 24.06.2025
- Добавлен параметр seed для узлов TTS и VC для воспроизводимости генерации
- Диапазон seed: от 0 до 4 294 967 295 (32-битное целое)
- Обеспечивает стабильный аудиовывод для отладки и управления рабочим процессом
- Сделана возможность отключения водяных знаков Perth для устранения проблем с Python 3.12+
- Теперь узлы работают без водяных знаков, если импорт resemble-perth не удался

### 31.05.2025
- Добавлена загрузка постоянных моделей и функция индикатора загрузки
- Добавлена поддержка Mac (требуется тестирование, пишите)
- удалена библиотека chatterbox-tts и реализован собственный код инференса.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---