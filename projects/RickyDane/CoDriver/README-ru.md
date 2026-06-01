
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Купить мне кофе на ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Простой файловый менеджер, который был создан, потому что я хотел изучить язык Rust.
  <br>
  Он не зависит от операционной системы и оптимизирован для производительности.
</p>

<br/><br/>

Производительность достигается благодаря ["jwalk"](https://crates.io/crates/jwalk/versions) и ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver не использует кэширование путей для доступа к файлам и папкам, поэтому производительность обеспечивается Rust, скоростью диска и мощностью процессора.

⁉️ Имейте в виду, что это программное обеспечение все еще находится в разработке и может содержать ошибки!
<br/><br/>

# Ссылки
- <a href="#basic-features">Базовые возможности</a>
- <a href="#advanced-features">Расширенные возможности</a>
- <a href="#dependencies-if-not-working-instantly">Зависимости</a>
- <a href="#-ftp-sftp-integration">Интеграция FTP / SFTP</a>
- <a href="#-known-issues">Известные проблемы</a>
- <a href="#-todos">Задачи</a>
- <a href="#user-interface">Пользовательский интерфейс</a>

## Основные функции
- Навигация по каталогам, как вы привыкли
- Копирование и вставка, удаление, создание и переименование файлов и папок
- Переключение между режимами сетки, списка и колонок Миллера
- Закрытие всплывающих окон клавишей Esc
- Переход к каталогу с помощью Ctrl / Cmd + G, введя путь
- Сортировка элементов в режиме списка по размеру, имени или дате изменения

## Расширенные функции
- Сжатие файлов и папок
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Распаковка архивов
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Переход в каталог с помощью сочетания LAlt + 1 / 2 / 3 | (на macOS option + 1 / 2 / 3)
  - Настройте пути самостоятельно в настройках
- Создать файл с помощью F6
- Создать папку с помощью F7
- Двухпанельный режим
  - Поиск файлов с помощью F8
  - Копировать выбранный элемент в другую панель с помощью F5
  - Переместить выбранный элемент в другую панель с помощью LShift + F5
- Перетаскивание файлов в проводник для копирования их в текущий каталог
- Массовое переименование выбранных элементов с помощью Ctrl / Cmd + LShift + M
  - Запуск массового переименования с помощью Ctrl / Cmd + Enter
- Быстрый просмотр файла -> Выберите элемент и нажмите пробел.
  - Поддерживаемые файлы: все изображения (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Для других элементов будет отображаться небольшая плитка с информацией (путь, размер, дата изменения)
- Мгновенная навигация -> Начните вводить, и записи каталога будут автоматически фильтроваться, что иногда <br/>
  значительно ускоряет переход к нужному месту

## Зависимости (если не работает сразу)

<details>
<summary>Развернуть для просмотра</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Арх
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ Интеграция FTP / SFTP

CoDriver обеспечивает полностью нативную, готовую к использованию поддержку удалённых подключений по FTP и SFTP. Не требуются внешние зависимости, FUSE-слои или монтирования через `sshfs`! Просто подключайте свои удалённые серверы напрямую через боковую панель.

## 🏴‍☠️ Языковая поддержка
- Английский
  - Возможность выбора между языками появится в ближайшее время ...

## ⚠️ Известные проблемы:
- Перетаскивание за пределы окна на данный момент не всегда работает в Linux
- В Windows может потребоваться установка [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Права в ms-windows немного необычные
  - Возможно, потребуется запускать программу от имени администратора, если возникают проблемы с копированием элементов или чем-то подобным
- Может возникнуть проблема с необходимостью установки openssl1.1 на Linux, если программа не запускается

## 📝 Задачи:
- Многоязычность
- Избранное
- Доступ к облачным сервисам хранения (Google Drive и др.)

## Интерфейс пользователя
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## Как внести вклад
Настройте вашу машину для разработки приложений tauri v1: [Tauri prerequisites](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Когда это будет сделано, просто выполните ```git clone https://github.com/RickyDane/CoDriver``` или ```gh repo clone RickyDane/CoDriver``` в нужной папке на вашем компьютере.
</br></br>
Вы сможете запустить ```cargo tauri dev``` в корневой директории этого проекта для сборки и запуска CoDriver.
</br>
Убедитесь, что установлен tauri-cli: ```cargo install tauri-cli```
</br>

## Подпись релиза

Релизные артефакты для macOS должны быть подписаны и нотариально заверены, чтобы избежать сообщений Gatekeeper о поврежденном приложении. См. [Подпись и нотариализация macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) для получения необходимых секретов GitHub Actions и команд проверки.

## История звезд

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Другое стороннее ПО
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---