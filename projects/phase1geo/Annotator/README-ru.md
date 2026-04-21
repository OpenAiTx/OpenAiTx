<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Скачать в AppCenter"/>
  </a>
</p>


![<center><b>Главное окно - Светлая тема</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Аннотирование изображений для Elementary OS")

## Обзор

Аннотируйте свои изображения и пусть картинка расскажет 1000 слов.

- Загружайте изображения из файловой системы, буфера обмена или создавайте скриншоты для аннотирования.
- Добавляйте фигуры, стикеры, изображения, текст, рисунки и другие элементы для выделения деталей изображения.
- Добавляйте увеличительные стекла для детализации изображения.
- Размывайте части изображения для сокрытия данных.
- Обрезайте, изменяйте размер и добавляйте рамки к изображениям.
- Управляйте цветами, толщиной линий и параметрами шрифта.
- Поддержка масштабирования.
- Поддержка выбора цвета внутри загруженного изображения.
- Неограниченное количество отмен/повторов любых изменений.
- Перетаскивание PNG-копий аннотированного изображения.
- Экспорт в форматы изображений JPEG, PNG, TIFF, BMP, PDF, SVG и WebP.
- Поддержка копирования аннотированного изображения в буфер обмена.
- Поддержка печати.

## Установка

### Debian (из исходников)

Для сборки Annotator вам понадобятся следующие зависимости:

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

Для установки Annotator из исходников выполните команду `./app install`.

Чтобы запустить Annotator, выполните `com.github.phase1geo.annotator`.

### Ubuntu (PPA)

Вы можете воспользоваться [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/), поддерживаемым @PandaJim. PPA поддерживает Ubuntu 20.04+. Введите следующие команды одну за другой

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

Если вы пользователь Arch Linux, существует
[AUR-пакет](https://aur.archlinux.org/packages/annotator/)
`annotator`:

```
% yay -S annotator
```

### Flatpak

Кроме того, Annotator можно установить и запускать через Flatpak.

Чтобы собрать elementary Flatpak из исходников, выполните команду `./app elementary`.

Чтобы собрать Flathub Flatpak из исходников, выполните команду `./app flathub`.

После этого вы можете запустить его через: `./app run-flatpak`.

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Получить в AppCenter"/>
  </a>
</p>

## Благодарности

Включает `document-edit-symbolic.svg` и `image-crop-symbolic.svg` из
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic),
на условиях лицензии GPL v3.0.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---