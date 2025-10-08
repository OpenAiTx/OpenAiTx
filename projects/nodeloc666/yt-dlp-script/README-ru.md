
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp инструмент для массовой загрузки видео (поддержка Windows / Linux)

> Однокнопочный скрипт для скачивания видео на основе [yt-dlp](https://github.com/yt-dlp/yt-dlp), вдохновлённый [постом NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Поддерживает загрузку одного видео и массовую загрузку, совместим с Windows и основными дистрибутивами Linux (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Особенности

* 📥 **Запуск одним кликом**: не требует ручной настройки, просто следуйте подсказкам для начала загрузки
* 🍪 **Поддержка пользовательских Cookie**: подходит для загрузки видео, доступных только после авторизации (⚠️ Функция не проверена, возможны ошибки)
* 📂 **Выбор каталога сохранения**: легко сохраняйте файлы в нужную папку
* 📃 **Массовая загрузка**: автоматически читает ссылки из файла `urls.txt` для скачивания
* ⚙️ **Автоматическая установка зависимостей**: в Linux автоматически устанавливаются `yt-dlp` и `ffmpeg`

---

## 🖼️ Пример скриншотов

| Пример 1                                                                | Пример 2                                                                |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| ![Пример 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Пример 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Пример 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Пример 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Инструкция для Windows

1. Скачайте следующие файлы:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` для Windows](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. После распаковки поместите следующие файлы в одну папку (например, в папку `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (скриптовый файл)

3. Запустите `yt-dlp.bat` двойным кликом и следуйте инструкциям для загрузки видео.
4. Редактируйте config/config.ini для изменения настроек по умолчанию

---

## 🐧 Инструкция для Linux (в последнем скрипте мастера科技lion также интегрирована аналогичная функциональность)

**Supported Systems**: Debian / Ubuntu / Alpine / CentOS

One-click deployment or update and run:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Для удаления:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Рекомендации для Android

1. Используйте приложение [Seal](https://github.com/JunkFood02/Seal) для работы с функциями `yt-dlp` на Android.
2. Установка Debian через termux также позволяет скачивать, но в этом нет необходимости — Seal отлично справляется.

---

## ⚠️ Важные замечания

1. **Режим пакетной загрузки**: скрипт автоматически читает файл `config\urls.txt` в текущей директории, по одной ссылке на видео в строке. Если файл отсутствует, он будет создан автоматически.
2. **Предупреждение о ресурсах**: на устройствах с небольшим объёмом памяти избегайте одновременной загрузки нескольких крупных видео или слишком большого количества потоков.
3. **Особенности CentOS**: из-за специфики окружения тестирование было не полным, рекомендуется использовать вне продакшн-среды. Все остальные популярные системы проверены и работают.
4. Мелкий баг Linux-версии: при переходе на главную страницу скрипт проверяет зависимости, принцип — лишь бы работало, менять не стал.
5. Мелкий баг Windows-версии: когда с других страниц возвращаетесь на главную и делаете выбор, опция по умолчанию может не сработать, возможен зацикливание, не удалось исправить.
Два варианта решения:
    1. Выйти и запустить заново
    2. Не использовать по умолчанию, а выбирать по номеру

---

## 📄 Лицензия

Этот проект распространяется по лицензии [MIT License](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---