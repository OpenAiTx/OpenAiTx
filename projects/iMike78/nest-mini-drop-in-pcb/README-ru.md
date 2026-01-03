
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=iMike78&project=nest-mini-drop-in-pcb&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# MiciMike сменная плата (PCB) для Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) — это сменная печатная плата (PCB) для ["Google Nest Mini" (вторая версия умной колонки Google с разъемом питания-баррелем)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)), но на базе микроконтроллеров ESP32 и XMOS для запуска open-source прошивки.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Совет! Если вы ищете аналогичную сменную плату для "Google Home Mini" (первое поколение умной колонки Google с разъемом Micro-USB), ознакомьтесь с проектом-спутником по адресу https://github.com/iMike78/home-mini-v1-drop-in-pcb
Оба этих проекта являются полностью открытыми аппаратными решениями, вдохновлёнными некоторыми концепциями [Onju Voice](https://github.com/justLV/onju-voice), но ориентированными на следование [стандарту открытых голосовых ассистентов Open Home Foundation с Home Assistant Voice Preview Edition в качестве примера](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) для разработок и спецификаций печатных плат.

# Объем проекта

Цель этого проекта и репозитория (который похож на [Onju Voice](https://github.com/justLV/onju-voice), но под полностью открытой аппаратной лицензией) — разработать заменяемую печатную плату (PCB) с аппаратными схемами, которую любой может изготовить/собрать или заказать у производителя печатных плат как индивидуальную замену PCB для Google Nest Mini (2-го поколения).

В первую очередь это ориентировано на людей, желающих переделать/переосмыслить свои старые смарт-колонки Google Nest Mini в открытое аппаратное решение для [Голосового управления Home Assistant](https://www.home-assistant.io/voice_control/) и/или вывода аудио для [Music Assistant](https://www.music-assistant.io), (однако аппаратное обеспечение, вероятно, может использоваться и для других целей с другим ПО, так как оно основано на популярной платформе Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Аппаратная часть (как и [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) будет включать ESP32-S3 SoC для WiFi, BLE и [локального определения ключевого слова](https://www.home-assistant.io/voice_control/about_wake_word/) (с помощью no-code [ESPHome прошивки](https://esphome.io/)) + XMOS xCORE XU316 для продвинутой обработки аудио (с кастомной прошивкой для очистки микрофонного сигнала — для лучшего распознавания речи с использованием локальных алгоритмов подавления шума, акустической эхокомпенсации, подавления помех и автоматической регулировки усиления).

По функционалу устройство будет в основном аппаратно совместимо с [Home Assistant Voice Preview Edition (также известен как Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) — референсная плата, выпущенная как open-source hardware дизайном Open Home Foundation в сотрудничестве с Nabu Casa). Главное отличие — ограничения, определяемые корпусом и компонентами Google Nest Mini (то есть hardware проекта nest-mini-drop-in-pcb будет ограничено теми же типами физических входов, что и оригинальное устройство Google).

Таким образом, задача этого проекта/репозитория — не разработка новых функций для прошивки ESPHome, если вам нужны такие возможности, обратитесь к разработке прошивки Home Assistant Voice Preview Edition, а также к основному коду ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Запрос на сотрудничество

Если у вас есть опыт проектирования печатных плат (особенно трассировки, заливки земли или разводки для цифровых/аналоговых схем с низким уровнем шума), **ваша помощь очень ценится**! Не стесняйтесь открывать новый issue, вносить предложения/запросы, оставлять комментарии к существующим задачам или форкать репозиторий.

Для получения дополнительной информации о концепции/идее, а также для участия в обсуждении смотрите и пишите в соответствующей теме на форуме Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Текущий статус

- ✅ Схема завершена
- ✅ Расстановка компонентов выполнена
- ✅ Трассировка завершена
- ✅ Заливка земли, стратегия экранирования и вопросы ЭМИ проработаны
- ⚠️ Первая тестовая партия провалена из-за двух ошибок — исправлено
- 🕓 ожидание второй тестовой партии

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## Используемые инструменты

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC для поиска посадочных мест

## Известные аппаратные характеристики

- 4-слойная печатная плата
- Чип ESP32-S3R8 (ESP32-S3 для WiFi, BLE и встроенного обнаружения ключевого слова)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP для обработки аудио)
- Двойная SPI-флэш-память (ESP32 и XMOS имеют свою собственную SPI-флэш)
- Два шины I²S (для одновременного использования I2S-интерфейсов, т.е. одновременный аудиовыход и аудиовход)
- MAX98357 для вывода на динамик (I2S моно аудиоусилитель класса D)
- 2x MEMS-микрофона (двойной MMICT390200012 с расстоянием между микрофонами 68 мм)
- 6x SK6812 RGB светодиодов
- Специальный USB-C и вход питания 14V (Внимание! USB-C и разъем питания не могут быть подключены одновременно)

---

> ⚠️ Прошивка через USB-C требует отключения основного входа питания 14В. См. примечание на печатной плате.

## Ссылки

### Ресурсы Home Assistant Voice Preview Edition, включая файлы дизайна печатной платы
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/ru/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf

#### Прошивка ESPHome для Home Assistant Voice PE (также использует ту же комбинацию ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) микроконтроллерный чип

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Прошивка XMOS из проекта ESPHome для аппаратного обеспечения Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Лицензия

Этот проект лицензируется по [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Любая модифицированная версия этого аппаратного обеспечения также должна распространяться по той же лицензии.

☕ Если вы хотите поддержать этот проект, не стесняйтесь [купить мне кофе на Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---