
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

**Внимание!** В настоящее время проходит краудфандинговая кампания на "MiciMike Home Mini Drop-In PCB" (1-е поколение Google Home Mini), которая сейчас доступна на Crowd Supply в фазе предварительной продажи (только предпросмотр проекта). Если кампания окажется успешной, будет запланирована аналогичная кампания для новых Nest Mini (2-е поколение), поэтому ознакомьтесь и поддержите проект, если можете:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Оба этих проекта являются полностью открытым аппаратным обеспечением, черпая концептуальное вдохновение из [Onju Voice](https://github.com/justLV/onju-voice), однако целью является следование [открытому стандарту голосовых ассистентов Open Home Foundation с Home Assistant Voice Preview Edition в качестве референса](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) при разработке и спецификациях печатных плат.

# Объем проекта

Цель данного проекта и репозитория (аналогично проекту [Onju Voice](https://github.com/justLV/onju-voice), но под полностью открытой лицензией) — разработать печатную плату (PCB) с аппаратными схемами, которую любой желающий сможет изготовить/заказать у производителя как индивидуальную замену платы для Google Nest Mini (2-е поколение).

В первую очередь проект ориентирован на тех, кто хочет переделать/переиспользовать свои старые Google Nest Mini в устройства с открытой аппаратной платформой для [Голосового управления Home Assistant](https://www.home-assistant.io/voice_control/) и/или в качестве аудиовыхода для [Music Assistant](https://www.music-assistant.io), (однако аппаратное обеспечение, вероятно, может использоваться и в других приложениях с другой прошивкой, так как основано на популярной платформе Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/front_render.jpg" width="1000" alt="First test PCB">

Аппаратная часть будет (подобно [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) интегрировать ESP32-S3 SoC для WiFi, BLE и [детекции ключевого слова на борту](https://www.home-assistant.io/voice_control/about_wake_word/) (с использованием безкодовои прошивки [ESPHome](https://esphome.io/)) + чип XMOS xCORE XU316 для продвинутой обработки аудио (с собственной прошивкой для очистки микрофона и улучшенного распознавания речи за счет локальных алгоритмов подавления шума, акустической эхоподавления, подавления помех и автоматического контроля усиления).

По функциональности аппаратно проект максимально совместим с [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) референсным дизайном (который выпущен как open-source аппаратное решение Open Home Foundation совместно с Nabu Casa). Главное отличие будет связано с ограничениями корпуса Google Nest Mini и компонентов (т.е. аппаратный дизайн nest-mini-drop-in-pcb будет ограничен теми же типами физических входов, что и оригинальное устройство Google).

Таким образом, задачей этого проекта/репозитория не является разработка новых функций/возможностей для прошивки ESPHome, поэтому если вы хотите этого — обратитесь к разработке прошивки Home Assistant Voice Preview Edition или к основному коду ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Приглашение к сотрудничеству

Если у вас есть опыт проектирования печатных плат (особенно трассировки, заливки земли или разводки смешанных цифровых и аналоговых цепей), **ваша помощь очень приветствуется**! Пожалуйста, открывайте новые задачи, предлагайте улучшения/запросы, оставляйте отзывы или делайте форк репозитория.

Подробнее о концепции/идее можно узнать и поучаствовать в обсуждении в этой ветке форума сообщества Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Текущее состояние

- ✅ Схема завершена
- ✅ Расстановка компонентов выполнена
- ✅ Трассировка завершена
- ✅ Заливка земли, стратегия экранирования и EMI учтены
- ⛔ Первая тестовая партия провалена по двум ошибкам — исправлено
- ⚠️ Вторая тестовая партия работает частично
- ✅ Добавлен режим отладки XTAG4 для следующей партии

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/back_render.jpg" width="1000">

## Используемые инструменты

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC для подбора посадочных мест

## Известные аппаратные характеристики

- 4-слойная печатная плата
- Голый чип ESP32-S3R8 (ESP32-S3 для WiFi, BLE и onboard распознавания ключевого слова)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP аудио обработка)
- 16 МБ SPI флэш (ESP32-S3)
- 4 МБ SPI флэш (XMOS XU316)
- Два I²S интерфейса (одновременный ввод и вывод аудио)
- TAS5805M (TAS5805MPWPR) стерео усилитель класса D с интегрированным DSP (I2S аудио, I2C управление), настроен для моно BTL выхода на динамик
- 3 MEMS микрофона (MMICT390200012), размещённых по дуге радиусом 34 мм - текущая прошивка использует 2 микрофона, аппаратная поддержка массива из 3 микрофонов уже реализована
- 6 SK6812 RGB светодиодов
- Индивидуальный вход USB-C и 14В питания (Внимание! USB-C и разъём питания не могут быть подключены одновременно)
- MPR121 емкостной контроллер касания (используется для ввода касанием вместо встроенного сенсора ESP32-S3)

---

> ⚠️ Прошивка через USB-C требует отключения основного 14В питания. Подробнее см. надпись на плате.

## Ссылки

### Ресурсы Home Assistant Voice Preview Edition, включая файлы дизайна печатной платы
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Прошивка ESPHome для Home Assistant Voice PE (использует ту же комбинацию ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C24) МК микросхема

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

Этот проект лицензирован по [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Любая модифицированная версия данного аппаратного обеспечения также должна распространяться по той же лицензии.

☕ Если вы хотите поддержать этот проект, вы можете [купить мне кофе на Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---