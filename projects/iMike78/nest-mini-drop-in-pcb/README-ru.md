
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

**Внимание!** Предстоящая краудфандинговая кампания по проекту "MiciMike Home Mini Drop-In PCB" (1-е поколение Google Home Mini) теперь размещена на этапе предпродажи в Crowd Supply (только предпросмотр проекта), и если она будет успешной, планируется аналогичная кампания для Nest Mini, поэтому ознакомьтесь здесь:

* https://www.crowdsupply.com/micimike-rev-devices/micimike-home-mini-drop-in-pcb

Оба этих проекта являются полностью открытым аппаратным обеспечением, частично вдохновлены концепцией [Onju Voice](https://github.com/justLV/onju-voice), но ориентированы на следование [стандарту открытых голосовых ассистентов Open Home Foundation с Home Assistant Voice Preview Edition в качестве примера](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) для проектирования и спецификаций PCB.

# Область проекта

Цель данного проекта и репозитория (который похож на [Onju Voice](https://github.com/justLV/onju-voice), но под полностью открытой лицензией на аппаратное обеспечение) — разработать заменяемую печатную плату (PCB) с аппаратными схемами, которые любой может изготовить/собрать или заказать у производителя как индивидуальную замену для Google Nest Mini (2-е поколение).

Это в первую очередь предназначено для тех, кто хочет переделать/перепрофилировать свои старые Google Nest Mini в устройства с открытой аппаратной платформой для [голосового управления Home Assistant](https://www.home-assistant.io/voice_control/) и/или в качестве аудиовыхода медиаплеера для [Music Assistant](https://www.music-assistant.io), (однако аппаратная часть, вероятно, также может быть использована в других приложениях с другим ПО, так как построена на популярной платформе Espressif ESP32).

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

Аппаратная часть будет (подобно [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/)) интегрировать ESP32-S3 SoC для WiFi, BLE и [обнаружения ключевого слова](https://www.home-assistant.io/voice_control/about_wake_word/) на борту (с помощью no-code [прошивки ESPHome](https://esphome.io/)) + чип XMOS xCORE XU316 для продвинутой обработки аудио (с пользовательской прошивкой для разгрузки микрофонной обработки для лучшего распознавания речи с локальными алгоритмами подавления шума, акустической эхоподавления, подавления помех и автоматического контроля усиления).

По функциональности она в основном аппаратно совместима с [Home Assistant Voice Preview Edition (также известной как Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) (эталонный дизайн, который был выпущен как открытая разработка аппаратного обеспечения фондом Open Home совместно с Nabu Casa). Главное отличие связано с ограничениями, определяемыми корпусом и компонентами Google Nest Mini (т.е. проект nest-mini-drop-in-pcb будет ограничен тем же типом физических входов, что и оригинальное устройство Google).

Таким образом, цель данного проекта/репозитория не разработка новых функций/возможностей для прошивки ESPHome; если вам это необходимо, обратитесь к разработке прошивки Home Assistant Voice Preview Edition, а также к основному коду ESPHome:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## Призыв к сотрудничеству

Если у вас есть опыт проектирования плат, (особенно трассировка, заливка земли или цифрово-аналоговая разводка, чувствительная к шуму), **ваша помощь очень приветствуется**! Не стесняйтесь открывать новые issue, предлагать/запрашивать доработки, оставлять отзывы и предложения к существующим задачам или форкать этот репозиторий.

Подробнее о концепции/идее и чтобы принять участие в обсуждении, смотрите также эту ветку форума сообщества Home Assistant:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### Текущий статус

- ✅ Схема готова
- ✅ Размещение компонентов завершено
- ✅ Трассировка завершена
- ✅ Заливка земли, стратегия экранирования и учет ЭМИ выполнены
- ⚠️ Первый тестовый тираж провален из-за двух ошибок — исправлено
- 🕓 ожидание второй тестовой партии

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## Используемые инструменты

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC для поиска посадочных мест

## Известные аппаратные характеристики

- 4-слойная печатная плата
- Чип ESP32-S3R8 без корпуса (ESP32-S3 для WiFi, BLE и встроенного распознавания ключевых слов)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP для аудиообработки)
- Двойная SPI флеш-память (так как у ESP32 и XMOS свои SPI флеш)
- Два интерфейса I²S (для одновременного использования интерфейсов I2S, т.е. одновременный аудиовывод и ввод)
- TAS5805M (TAS5805MPWPR) для вывода на динамик (I2S моноусилитель класса D с DSP-конфигурированием по I2C)
- 2x MEMS-микрофона (двойные MMICT390200012 с межмикрофонным расстоянием 68 мм)
- 6x SK6812 RGB светодиодов
- Пользовательский USB-C и вход питания 14В (Внимание! USB-C и разъем питания не могут быть подключены одновременно)

---

> ⚠️ Прошивка через USB-C требует отключения основного 14В питания. См. пометку на шелкографии платы для подробностей.

## Ссылки

### Ресурсы Home Assistant Voice Preview Edition, включая файлы схем печатных плат
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Прошивка ESPHome для Home Assistant Voice PE (также использует ту же комбинацию ESP32-S3 + XMOS XU316):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) микроконтроллер

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### XMOS прошивка из проекта ESPHome для аппаратного обеспечения Home Assistant Voice Preview Edition:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## Лицензия

Этот проект лицензируется по [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)]
Любая модифицированная версия этого оборудования также должна распространяться по той же лицензии.

☕ Если вы хотите поддержать этот проект, можете [купить мне кофе на Ko-fi](https://ko-fi.com/imike78)!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---