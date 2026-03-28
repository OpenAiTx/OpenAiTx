
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Графический интерфейс Wine на базе Zenity — играйте и делитесь!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Скачать на Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Что такое WineZGUI

WineZGUI (произносится как Вайн-Зи-Гу-И) — это графический интерфейс для Wine, предназначенный для легкого запуска Windows-игр через Wine. Это набор Bash-скриптов для управления префиксами Wine и интеграции с рабочим столом Linux для более простого игрового опыта с помощью Zenity. Позволяет быстро запускать exe-файлы (без установки) напрямую из файлового менеджера, например Nautilus, и создавать отдельный префикс Wine для каждого исполняемого файла Windows.

## Почему WineZGUI?

1. Запускает Windows-игры или exe-файлы из файлового менеджера.
2. Создает ярлык приложения для быстрого доступа.
3. Сфокусирован на запуске игр, а не настройке префиксов.
4. Позволяет создавать резервные копии и восстанавливать префиксы для последующего использования.
5. Создает игровые пакеты для обмена (префикс+игра).

## Как это работает

1. Когда Windows-исполняемый файл или exe открывается с помощью WineZGUI,
2. Создается новый префикс (копируется шаблон) и ярлык на рабочем столе с именем exe-файла.
3. Когда пользователь запускает скрипт, exe-файл запускается.
4. Если это установщик, он определит установленный exe и создаст ярлыки в категории меню "Игры".

## Как запустить игру или программу на другом диске или в другой директории

Откройте терминал и введите:

`flatpak override --user --filesystem=/path/to/your/drive io.github.fastrizwaan.WineZGUI`

### Установка WineZGUI

WineZGUI доступен как Flatpak на Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Скачать на Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

Flathub WineZGUI имеет доступ только к папкам Desktop, Documents, Downloads, Music, Pictures, Videos. Для доступа к файлам из других мест или с других смонтированных разделов или дисков скопируйте их в указанные папки (например, Downloads) или выдайте разрешение на чтение через приложение Flatseal или командой  `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Я настоятельно рекомендую использовать flatpak-версию, так как wine из репозитория дистрибутива (wine-staging) часто обновляется, из-за чего игры могут переставать работать. Лучше использовать стабильную версию wine из flathub или wine stable 5.0 или 7.0 из дистрибутива.

#### Установите WineZGUI flatpak на [поддерживаемых дистрибутивах Linux](https://flatpak.org/setup/)

WineZGUI входит в flatpak-wine, поддерживаемый мной. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) мой другой flatpak теперь не поддерживается [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)


### УСТАНОВКА на системе Linux, см. [Требования](https://github.com/fastrizwaan/WineZGUI#requirements)

Установка происходит мгновенно, так как копируются несколько файлов в определённые директории.

##### Версия 0.99.13

Скачайте исходный код [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) или используйте `git tag 0.99.13`

##### Использование tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Версия для разработки

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Удаление WineZGUI

##### Удаление Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Система удаления

Запустите `uninstall` из той же директории, где находится источник установки

```
sudo ./setup --uninstall
```

## Требования

`wine` - основная программа

`winetricks` - необходимый скрипт-дополнение для wine

`perl‑image‑exiftool` - для извлечения имени приложения/игры

`icoutils` - для извлечения значка из exe файла

`gnome-terminal` - (необязательно) для доступа к каталогу префикса в оболочке

## Установка требований для Linux ОС

### Дистрибутивы с поддержкой Flatpak

Получите [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases), который включает все зависимости. Полезно для дистрибутивов, не поставляющих wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Необходимые зависимости во время выполнения:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### Контроллеры, совместимые с XBOX

соберите и установите драйверы ядра для контроллеров, совместимых с xbox 360, с https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---