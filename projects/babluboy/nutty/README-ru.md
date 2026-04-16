
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
Сетевая утилита

Автор: Сиддхартха Дас

Простое приложение, созданное для elementary OS, чтобы предоставлять основную информацию о сетевых аспектах. Информация представлена на следующих вкладках.<br>
1. Моя информация: Предоставляет основную и подробную информацию о сетевой карте устройства<br>
2. Использование: Показывает использование сетевых данных в двух режимах — историческое использование и текущее использование<br>
3. Скорость: Проверяйте скорость загрузки и скачивания, а также получайте время маршрута до хоста<br>
4. Порты: Предоставляет информацию об активных портах и приложениях, использующих их на локальном устройстве<br>
5. Устройства: Отслеживает, оповещает и предоставляет информацию о других устройствах, подключённых к сети<br>

Смотрите сайт Nutty для подробностей о функциях, горячих клавишах, руководствах по установке для Ubuntu и других поддерживаемых дистрибутивов и т.д.: <br>
https://babluboy.github.io/nutty/

## Сборка, тестирование и установка из исходников

Для сборки потребуются следующие зависимости:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

Для работы требуются следующие зависимости:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Иногда vnstat не запускается после установки, используйте соответствующую команду инициализации для запуска демона vnstat, например: `sudo systemctl enable vnstat`

Выполните `meson build` для настройки среды сборки и `ninja test` для сборки

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
Для установки используйте `sudo ninja install`, затем выполните команду `com.github.babluboy.nutty`


```
sudo ninja install
com.github.babluboy.nutty
```
Чтобы удалить, перейдите в каталог сборки и выполните

```
sudo ninja uninstall
```

### Установка из пакета Deb

Чтобы установить Nutty из пакета `.deb`, убедитесь, что у вас установлены все вышеуказанные зависимости для выполнения Nutty (зависимости для сборки не требуются). Затем выполните следующую команду
```bash
sudo dpkg -i <deb-package-name>.deb
```
  
А чтобы удалить Nutty, установленный через пакет `.deb`, выполните
```bash
sudo apt autoremove com.github.babluboy.nutty
```
Если вы хотите самостоятельно собрать пакет `.deb` Nutty, установите вышеуказанные зависимости для сборки, а затем выполните

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---