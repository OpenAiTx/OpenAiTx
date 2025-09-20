
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Дампы PIC16/Xyclops с оригинального Xbox и базы данных IDA с некоторыми элементами реверс-инжиниринга.

![Изображение PIC16LC63A с оригинального Xbox](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Прошивка Xyclops (XycloMod)
См. [директорию Xyclops и README](/Xyclops)

# Дампы
Файл .bin для каждого дампа PIC имеет переставленные байты для корректной загрузки в IDA. Поэтому первое слово памяти PIC — это byte_0 + byte_1 << 8.

Базы данных .idb для IDA содержат информацию о переменных и некоторые наблюдения на блокноте базы данных.

См. эту страницу вики для разбора версий SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Дамп снят с Xbox DVT3. Тот же конфигурационный код, что и у P01. В области конфигурации также записан идентификатор устройства 0000 0000 000B 002A, в отличие от серийных PIC.

Полностью отсутствует boot challenge.

## D01
Дамп снят с Xbox XDK BETA 2. Идентичен P01, за исключением отсутствующего boot challenge. Функция вычисления ожидаемого ответа на boot challenge всё ещё присутствует, но никогда не вызывается.

## DXF
Дамп снят с XDK D2 debug kit. Очень похож на D01, но с немного отличающейся логикой лотка, перегрева и загрузки. Boot challenge отсутствует так же, как и у D01.

## D2E
Дамп снят с Tuscany (v1.6) dev kit. Чип Xyclops помечен как X01202-001 и не имеет линии A-A02 или A-B01, которые присутствуют в розничных устройствах.

Отладочный серийный код по адресу FC00 совпадает с розничным дампом P2L. С 0x4000 по 0xFBFF наблюдается странный паттерн данных.

## P01
Дамп снят с Xbox v1.0. Конфигурационное слово — 0x86:
- CP1:CP0 = 0 (Защита кода включена для всей памяти)
- BODEN = 0 (Сброс по понижению напряжения отключён)
- ~PWRTE = 0 (Таймер включения питания включён)
- WDTE = 1 (Таймер сторожевого контроля включён)
- FOSC1:FOSC0 = 2 (HS-осциллятор)

Значение конфигурации 0x3FB6 подходит для SMC-клонов, чтобы у них не была включена защита кода.

## P11
Дамп снят с Xbox v1.3. Такое же конфигурационное слово, как у P01.

В P11 по сравнению с P01 есть несколько небольших изменений, включая дополнительную команду SMBus (запись 0x22), другой приоритет светодиодов и более мягкие тайминги загрузки.

Я сравнил зашифрованные дампы v1.3 с v1.4, и они совпали. Это означает, что, скорее всего, у них одна и та же программа.

## P2L
Считано с Xbox версии 1.6. Ревизия Xyclops A-A02. Содержит код Intel 8051, но имеет много специальных регистров, назначение которых неизвестно.

Дебаг-сериал управляется кодом по адресу FC00. Похоже на примитивный отладчик, который может приостанавливать выполнение, сбрасывать данные и записывать в регистры/ОЗУ.

# Считывание Xyclops

Чип Xyclops имеет 3 пина для 'отладки': TXD (пин 64), RXD (пин 63) и DEBUG (пин 29). Установите DEBUG-пин в высокий уровень, чтобы активировать последовательный порт на пинах TX и RX. Последовательный порт работает на скорости 9600 бод.

Протокол основан на 4-байтовых командах, которые обычно имеют формат `<cmd>` `<старший байт адреса>` `<младший байт адреса>` `<неважно>`

Команда 0x14 выводит по 64 байта данных BIOS за раз, а 0x15 — по 64 байта данных программы SMC за раз. Дамп с Xyclops, P2L.bin, включён в репозиторий. Также включён [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) для самостоятельного дампа вашей машины.

# Методика считывания PIC
Полное описание на https://wiki.recessim.com/view/PIC_Burnout

На PIC включена защита кода, поэтому все данные читаются как 0000. Я использовал некоторый трюк для получения зашифрованных данных, выяснил алгоритм шифрования с помощью жертвенного чипа, затем использовал эксплойт для изменения данных ПЗУ, чтобы исправить некоторые биты до известных значений. После этого я смог извлечь нужную информацию из нескольких зашифрованных дампов и восстановить исходные данные.

# PICProgrammer
PICProgrammer — один из Arduino-проектов для RP2040, которые я использовал в исследовании. Он предоставляет простой интерфейс командной строки для выполнения ICSP (программирования микросхем в цепи) на PIC. Это предпочтительнее, чем использовать специализированный программатор типа PICkit благодаря гибкости и возможности выполнять действия, не предусмотренные производителем.

Рекомендуется хорошо разбираться в электронике и программировании перед использованием, а также внимательно изучить команды перед их выполнением.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---