
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

# Замена платы PCB MiciMike для Google Nest Mini

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) — это сменная плата PCB для ["Google Nest Mini" (второе поколение умной колонки Google с разъемом для зарядки типа Barrel)](https://ru.wikipedia.org/wiki/Google_Nest_(smart_speakers)), выполненная на базе микроконтроллеров ESP32 и XMOS для работы с открытым программным обеспечением.

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

Совет! Если вы ищете похожую сменную плату PCB для "Google Home Mini" (аппаратное обеспечение первого поколения умной колонки Google с разъемом Micro-USB), то ознакомьтесь с этим проектом: https://github.com/iMike78/home-mini-v1-drop-in-pcb

Оба этих проекта являются полностью открытыми аппаратными проектами, берущими некоторые концепции из [Onju Voice](https://github.com/justLV/onju-voice), однако ориентированы на соблюдение [стандарта открытых голосовых ассистентов Open Home Foundation с Home Assistant Voice Preview Edition в качестве эталона](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) для проектирования и спецификаций печатных плат.

# Область проекта

Цель этого проекта и репозитория (аналогичного [Onju Voice](https://github.com/justLV/onju-voice), но под полностью открытой аппаратной лицензией) — разработать замену печатной платы (PCB) с аппаратными схемами, которую любой сможет изготовить или заказать у производителя PCB как индивидуальную замену для Google Nest Mini (2-го поколения).

В первую очередь проект ориентирован на людей, желающих переделать/перепрофилировать свои старые умные колонки Google Nest Mini в открытое аппаратное обеспечение для [Голосового управления Home Assistant](https://www.home-assistant.io/voice_control/) и/или вывода звука медиаплеера для [Music Assistant](https://www.music-assistant.io), (однако оборудование, вероятно, может использоваться и в других приложениях с разной прошивкой, поскольку основано на популярной платформе Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Конструкция аппаратной части будет (как и [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) включать SoC ESP32-S3 для Wi-Fi, BLE и [встроенного детектирования ключевого слова](https://www.home-assistant.io/voice_control/about_wake_word/) (с использованием прошивки [ESPHome без программирования](https://esphome.io/)) + чип XMOS xCORE XU316 для расширенной обработки аудио (с кастомной прошивкой для очистки микрофона, увеличения возможностей распознавания речи за счет локальных алгоритмов подавления шума, акустического эхоподавления, подавления помех и автоматической регулировки усиления).

По функциональности аппаратная часть в основном совместима с эталонной схемой [Home Assistant Voice Preview Edition (также известной как Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/), которая выпущена как открытая аппаратная разработка Open Home Foundation в сотрудничестве с Nabu Casa. Основное отличие заключается в ограничениях, накладываемых корпусом и компонентами Google Nest Mini, (то есть проект nest-mini-drop-in-pcb будет ограничен теми же физическими входами, что и оригинальное оборудование Google).

Таким образом, область этого проекта/репозитория не включает разработку новых функций для прошивки ESPHome, поэтому если вам это нужно, обратитесь к разработке прошивки Home Assistant Voice Preview Edition и к основному коду ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Запрос на сотрудничество

Если у вас есть опыт разработки компоновки печатных плат, (особенно в трассировке, заливке земли или в проектировании цифрово-аналоговых схем с чувствительностью к шуму), **ваша помощь очень ценна**! Пожалуйста, открывайте новые вопросы, предлагайте идеи/запросы, оставляйте отзывы к существующим вопросам или форкните репозиторий.

Для получения дополнительной информации о концепции/идее ознакомьтесь и внесите вклад в обсуждение на форуме сообщества Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Текущий статус

- ✅ Схема завершена
- ✅ Расположение компонентов выполнено
- ✅ Трассировка завершена
- ✅ Заливка земли, стратегия экранирования и вопросы ЭМИ учтены
- ⚠️ Первый тестовый запуск провален по двум ошибкам — исправлено
- 🕓 ожидание второго тестового запуска

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Используемые инструменты

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC для поиска посадочных мест

## Известные аппаратные характеристики

- 4-слойная печатная плата
- Чип ESP32-S3R8 (ESP32-S3 для WiFi, BLE и встроенного распознавания ключевых слов)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP аудио обработка)
- Двойная SPI флэш-память
- Два I²S шины (для одновременного использования I2S интерфейсов, т.е. одновременный аудиовыход и аудиовход)
- MAX98357 для вывода на динамик (I2S моно аудиоусилитель класса D)
- 2x MEMS микрофона (MSM261DHP)
- Светодиоды SK6812
- Специальный вход USB-C и питание 14В

---

> ⚠️ Прошивка через USB-C требует отключения основного входа питания 14В. Подробности см. на шелкографии на печатной плате.

## Ссылки

### Ресурсы Home Assistant Voice Preview Edition, включая файлы проекта печатной платы
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Прошивка ESPHome для Home Assistant Voice PE (также использует комбинацию ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC чип

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Прошивка XMOS от проекта ESPHome для оборудования Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Лицензия

Этот проект лицензирован по [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Любая модифицированная версия этого оборудования также должна распространяться по той же лицензии.

☕ Если вы хотите поддержать этот проект, можете [купить мне кофе на Ko-fi](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---