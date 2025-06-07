# ch32fun

Открытая среда разработки (инструменты, заголовки, примеры) для [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (и многих других микросхем из семейства CH32V) с использованием gcc-riscv64, которая может работать в Windows (нативно), Linux и/или WSL. CH32V003 — это микросхема стоимостью 10 центов с ядром RISC-V EC, работающая на частоте 48 МГц, имеющая 16 кБ флеша и 2 кБ ОЗУ, а также множество периферийных устройств. Выпускается в корпусах SOP-8, QFN-20 и SOIC. Даташит можно получить [здесь](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

Цель этого проекта — разработать инструменты и среду для эффективного использования CH32V003. Избегайте сложных HAL, используйте "железо" напрямую! Существующий EVT огромен, а среда разработки тяжеловесна. Этот проект специально избегает HAL и позволяет использовать только [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html). В отличие от этого, blinky занимает всего 500 байт с ch32fun, загружается быстрее и значительно проще в целом.

ch32fun включает:
1. Примеры использования ch32fun, хотя их меньше, чем при использовании HAL. Большинство из них ориентированы на ch32v003, но многие совместимы и с другими процессорами.
2. "minichlink", который использует WCH CH-Link с libusb для кроссплатформенной работы.
   * Программатор STM32F042 — [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * Программатор ESP32S2 — [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * Официальный программатор WCH Link-E.
   * Arduino-интерфейс — [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * Поддержка отладки в стиле gdbserver для Visual Studio.
   * Поддержка printf через одну линию (примерно 400 кБод).
3. Дополнительная копия libgcc для возможности использования нестандартных riscv-цепочек сборки, находится в `misc/libgcc.a`.
4. Папка "ch32fun", содержащая один самостоятельный исходный файл и заголовок для компиляции приложений под ch32v003.
5. На некоторых системах — возможность "printf" обратно через интерфейс программирования.
6. Демонстрационный загрузчик.

## Поддержка других семейств

В данный момент экспериментально поддерживаются ch32v103, ch32v203, ch32v208, ch32v303, ch32v305 и ch32v307. GDB в основном протестирован на 003, но работает в ограниченном режиме и с другими процессорами.

## Начало работы

Инструкции по установке и настройке смотрите на [wiki-странице](https://github.com/cnlohr/ch32fun/wiki/Installation)

## Возможности!

### Быстрый "printf" для отладки через интерфейс программирования

И под "быстрый" имеется в виду очень быстрый — обычно около 36кБ/сек.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

Вы можете просто попробовать проект debugprintf или вызвать SetupDebugPrintf(); и использовать printf().

### Поддержка отладки!

Через встроенный в minichlink gdbserver! Работает с `gdb-multiarch`, а также в Visual Studio Code.

## Сборка и прошивка

```
cd examples/blink
make
```

text = код, data = константы и инициализационные значения, bss = неинициализированные значения.  
dec — это сумма этих трёх и отражает количество байт флеша, которое займёт программа.

Сгенерированный .bin используется minichlink, а файл .hex совместим с официальным инструментом WCH для прошивки.

## VSCode +/- PlatformIO

Примечание: PlatformIO в основном используется для CI в этом репозитории. Хотя PlatformIO можно использовать для написания кода и отладки проекта ch32fun в VSCode, можно работать и без PlatformIO: для этого смотрите [шаблон проекта](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

Проект можно собирать, загружать и отлаживать в VSCode с расширением PlatformIO. Просто клонируйте и откройте проект в VSCode с установленным расширением PlatformIO. Используйте [переключатель окружений проекта](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks), чтобы выбрать конкретный пример, например "blink".

Чтобы создать новый проект прошивки PlatformIO на базе ch32fun, используйте мастер "New Project" в [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) и установите "Framework" в "ch32v003fun". Есть [различные примеры](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

Эквивалентная команда [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli):
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

Если вы хотите добавить свой код непосредственно в проект ch32fun, расширьте доступные окружения в `platformio.ini` [по инструкции](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

Также обратите внимание, что при открытии проекта в PlatformIO вы можете использовать [переключатель окружений проекта](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) в нижней части панели задач VSCode для выбора конкретной папки с примером. В противном случае по умолчанию при "Build" будут собраны **все** примеры.

Подробнее о платформе и установке смотрите [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v).

## clangd

Если сервер языка C/C++ clangd не может найти `ch32fun.h`, необходимо очистить пример командой `make clean` и собрать один раз с помощью `bear -- make build`, чтобы был сгенерирован `compile_commands.json`, который clangd использует для поиска путей include из makefile.  
`make clangd` делает это за один шаг.
`build_all_clangd.sh` из `build scripts` делает это для всех примеров.

## Краткая справка
 * **ОБЯЗАТЕЛЬНО** для программирования/отладки: `SWIO` находится на `PD1`. Не используйте PD1 для нескольких функций одновременно.
 * **ОПЦИОНАЛЬНО** `NRST` находится на `PD7`. Не требуется, по умолчанию работает как GPIO в некоторых конфигурациях.
 * **ОПЦИОНАЛЬНО** UART `TX` находится на `PD5`. Рекомендуем использовать SWIO для отладки через printf.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## Больше примеров / проектов?

Другие сторонние инструменты добавляют множество примеров и т.д. Смотрите следующие репозитории для дополнительных библиотек и прочего:
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## Поддержка

Вы можете открыть тикет на github или присоединиться к моему Discord-каналу #ch32fun. Сейчас приглашения приватные, поэтому просто напишите мне @cnlohr для получения ссылки. Личные сообщения открыты.

### Сноски/ссылки

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf Руководство по отладке
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html Руководство по процессору
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html Техническое описание (TRM)
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html Даташит
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md Детали сжатой ISA для этого чипа
 * CH32V003 поддерживает xv-расширения, можно использовать эту модифицированную версию rvcodec.js для работы с его опкодами: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---