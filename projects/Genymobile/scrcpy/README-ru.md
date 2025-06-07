**Этот репозиторий GitHub (<https://github.com/Genymobile/scrcpy>) является единственным официальным источником проекта. Не скачивайте релизы со случайных сайтов, даже если в их названии есть `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_произносится как "**scr**een **c**o**py**"_

Это приложение отображает Android-устройства (видео и аудио), подключённые через USB или [TCP/IP](doc/connection.md#tcpip-wireless), и позволяет управлять ими с помощью клавиатуры и мыши компьютера. Не требует _root_-доступа или установки приложения на устройство. Работает на _Linux_, _Windows_ и _macOS_.

![скриншот](assets/screenshot-debian-600.jpg)

Основные принципы:

 - **Лёгкость**: нативное, отображает только экран устройства
 - **Производительность**: 30~120 кадров/сек, зависит от устройства
 - **Качество**: 1920×1080 и выше
 - **Малая задержка**: [35~70мс][lowlatency]
 - **Быстрый запуск**: ~1 секунда до появления первого изображения
 - **Неинвазивность**: ничего не остаётся установленным на Android-устройстве
 - **Польза для пользователя**: не требуется аккаунт, реклама и интернет
 - **Свобода**: свободное и открытое ПО

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Возможности:
 - [передача аудио](doc/audio.md) (Android 11+)
 - [запись](doc/recording.md)
 - [виртуальный дисплей](doc/virtual_display.md)
 - дублирование с [выключенным экраном Android-устройства](doc/device.md#turn-screen-off)
 - [копирование и вставка](doc/control.md#copy-paste) в обе стороны
 - [настраиваемое качество](doc/video.md)
 - [дублирование камеры](doc/camera.md) (Android 12+)
 - [отображение как веб-камера (V4L2)](doc/v4l2.md) (только Linux)
 - аппаратная [эмуляция клавиатуры][hid-keyboard] и [мыши][hid-mouse] (HID)
 - поддержка [геймпада](doc/gamepad.md)
 - [режим OTG](doc/otg.md)
 - и многое другое…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Необходимые условия

Устройство Android требует как минимум API 21 (Android 5.0).

[Передача аудио](doc/audio.md) поддерживается для API >= 30 (Android 11+).

Убедитесь, что вы [включили отладку по USB][enable-adb] на своём устройстве.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

На некоторых устройствах (особенно Xiaomi) может возникнуть следующая ошибка:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

В таком случае необходимо включить [дополнительную опцию][control] `Отладка по USB (Настройки безопасности)` (это отдельный пункт от `Отладка по USB`), чтобы управлять устройством с помощью клавиатуры и мыши. После установки этой опции требуется перезагрузить устройство.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Обратите внимание, что отладка по USB не требуется для запуска scrcpy в [режиме OTG](doc/otg.md).


## Скачать приложение

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (см. [как запустить](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Важные советы

 - [Уменьшение разрешения](doc/video.md#size) может значительно повысить производительность (`scrcpy -m1024`)
 - [_Правая кнопка мыши_](doc/mouse.md#mouse-bindings) вызывает `BACK`
 - [_Средняя кнопка мыши_](doc/mouse.md#mouse-bindings) вызывает `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> переключает [полноэкранный режим](doc/window.md#fullscreen)
 - Есть много других [горячих клавиш](doc/shortcuts.md)


## Примеры использования

Существует множество опций, [описанных](#user-documentation) на отдельных страницах. Вот некоторые типовые примеры.

 - Захват экрана в H.265 (лучшее качество), ограничение размера до 1920, ограничение частоты кадров до 60fps, отключение аудио и управление устройством с эмуляцией аппаратной клавиатуры:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # короткая версия
    ```

 - Запуск VLC на новом виртуальном дисплее (отдельно от дисплея устройства):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Запись камеры устройства в H.265 при 1920x1080 (и микрофона) в файл MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Захват фронтальной камеры устройства и экспорт как веб-камеры на компьютере (в Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Управление устройством без зеркалирования через эмуляцию аппаратной клавиатуры и мыши (отладка по USB не требуется):

    ```bash
    scrcpy --otg
    ```

 - Управление устройством с помощью геймпадов, подключённых к компьютеру:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # короткая версия
    ```

## Документация для пользователей

Приложение предлагает множество возможностей и параметров настройки. Они описаны на следующих страницах:

 - [Подключение](doc/connection.md)
 - [Видео](doc/video.md)
 - [Аудио](doc/audio.md)
 - [Управление](doc/control.md)
 - [Клавиатура](doc/keyboard.md)
 - [Мышь](doc/mouse.md)
 - [Геймпад](doc/gamepad.md)
 - [Устройство](doc/device.md)
 - [Окно](doc/window.md)
 - [Запись](doc/recording.md)
 - [Виртуальный дисплей](doc/virtual_display.md)
 - [Туннели](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Камера](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Горячие клавиши](doc/shortcuts.md)


## Ресурсы

 - [FAQ](FAQ.md)
 - [Переводы][wiki] (могут быть неактуальны)
 - [Инструкции по сборке](doc/build.md)
 - [Разработчикам](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Статьи

- [Знакомство с scrcpy][article-intro]
- [Scrcpy теперь работает по беспроводной сети][article-tcpip]
- [Scrcpy 2.0, с поддержкой аудио][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Контакты

Вы можете открыть [issue] для сообщений об ошибках, запросов функций или общих вопросов.

Перед отправкой сообщения об ошибке, пожалуйста, сначала прочитайте [FAQ](FAQ.md) — возможно, вы сразу найдёте решение своей проблемы.

[issue]: https://github.com/Genymobile/scrcpy/issues

Также доступны:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Поддержать проект

Я [@rom1v](https://github.com/rom1v), автор и сопровождающий _scrcpy_.

Если вам нравится это приложение, вы можете [поддержать мою работу над open source][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Лицензия

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Лицензировано по лицензии Apache, версия 2.0 ("Лицензия");
    вы не можете использовать этот файл иначе, чем в соответствии с Лицензией.
    Копию Лицензии можно получить по адресу:

        http://www.apache.org/licenses/LICENSE-2.0

    Если не требуется иное по действующему законодательству или не согласовано письменно,
    программное обеспечение распространяется на условиях "КАК ЕСТЬ",
    БЕЗ КАКИХ-ЛИБО ГАРАНТИЙ ИЛИ УСЛОВИЙ,
    явных или подразумеваемых.
    См. Лицензию для определения конкретных разрешений и ограничений.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---