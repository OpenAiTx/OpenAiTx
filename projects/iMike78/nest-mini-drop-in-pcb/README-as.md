<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# Google Nest Mini-ৰ বাবে MiciMike drop-in PCB পৰিৱৰ্তন

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) হৈছে ["Google Nest Mini" (Google-ৰ দ্বিতীয় প্ৰজন্মৰ স্মাৰ্ট স্পীকাৰ যাৰ barrel connector charging port আছে)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers))-ৰ বাবে এটা drop-in PCB পৰিৱৰ্তন, কিন্তু ESP32 আৰু XMOS মাইক্ৰ’কন্ট্ৰ’লাৰ-ৰ ওপৰত আধাৰিত যাতে ওপেন-চৰ্চ ফাৰ্মৱেৰ চলাব পাৰি।

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

টিপ! যদি আপুনি "Google Home Mini" (Google-ৰ প্ৰথম প্ৰজন্মৰ স্মাৰ্ট স্পীকাৰ যাৰ Micro-USB charging port আছে) ৰ বাবে সদৃশ drop-in PCB পৰিৱৰ্তনৰ সন্ধানত আছ, তেন্তে https://github.com/iMike78/home-mini-v1-drop-in-pcb ত থকা sister-projectটো চাব পাৰে


এই দুয়োটাই সম্পূৰ্ণৰূপে মুক্ত উৎসৰ হাৰ্ডৱেৰ প্ৰকল্প, যিয়ে [Onju Voice](https://github.com/justLV/onju-voice) ৰ পৰা কিছু ধাৰণা লয় যদিও [Open Home Foundationৰ open voice assistants standard  আৰু Home Assistant Voice Preview Edition ৰ সংজ্ঞা](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) অনুসৰণ কৰিবলৈ উদ্দেশ্য ৰাখে PCB ডিজাইন আৰু স্পেসিফিকেশ্যনসমূহৰ বাবে।

# প্ৰকল্পৰ পৰিসৰ

এই প্ৰকল্প আৰু ৰেপ'জিট'ৰীৰ লক্ষ্য (যি [Onju Voice](https://github.com/justLV/onju-voice) ৰ দৰে কিন্তু সম্পূৰ্ণ মুক্ত উৎসৰ হাৰ্ডৱেৰ লাইচেঞ্চত) হৈছে এটা drop-in replacement PCB (Printed Circuit Board) ডিজাইন কৰা, যাৰ হাৰ্ডৱেৰ স্কিমেটিক যে কোনোবাই বনাব/নির্মাণ কৰিব পাৰে বা এখন one-stop PCB manufacturer ৰ পৰা order কৰিব পাৰে, Google Nest Mini (2nd Gen) ৰ বাবে এটা কাষ্টম drop-in replacement PCB হিচাপে।

এইটো প্ৰধানকৈ সেই সকল লোকক লক্ষ্য কৰি তৈয়াৰ কৰা হৈছে, যিয়ে তেওঁলোকৰ পুৰণা Google Nest Mini স্মাৰ্ট স্পীকাৰক মুক্ত উৎসৰ হাৰ্ডৱেৰলৈ ৰূপান্তৰ/পুনৰুপযোগী কৰিব বিচাৰে [Home Assistant ৰ Voice Control](https://www.home-assistant.io/voice_control/) ৰ বাবে আৰু/অথবা [Music Assistant](https://www.music-assistant.io) ৰ বাবে মিডিয়া প্লেয়াৰ স্পীকাৰ output হিচাপে, (হাৰ্ডৱেৰটো সম্ভবত অন্য এপ্লিকেশ্যনসমূহৰ লগতো ব্যৱহাৰ কৰিব পৰা যাব, কাৰণ এইটো জনপ্ৰিয় Espressif ESP32 platform ৰ ওপৰত আধাৰিত)।

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

হাৰ্ডৱেৰ ডিজাইনটো ( [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) ৰ দৰে) ESP32-S3 SoC সংহত কৰিব WiFi, BLE, আৰু [onboard wake-word detection](https://www.home-assistant.io/voice_control/about_wake_word/) ৰ বাবে (no-code [ESPHome firmware](https://esphome.io/) ব্যৱহাৰ কৰি) + XMOS xCORE XU316 চিপ advanced audio processing ৰ বাবে (custom firmwareৰে microphone cleanup offloading, local algorithmৰে Noise Suppression, Acoustic Echo Cancellation, Interference Cancellation, আৰু Automatic Gain Control ব্যৱহাৰ কৰি উন্নত voice recognition সক্ষমতাৰ বাবে)।

কাৰ্যক্ষমতাৰ দিশত, এইটো [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) reference design ৰ সৈতে প্ৰায় hardware compatible হিচাপে তৈয়াৰ কৰা হৈছে (Open Home Foundation আৰু Nabu Casa ৰ সহযোগিতাত মুক্ত উৎসৰ হাৰ্ডৱেৰ ডিজাইন হিচাপে মুক্ত কৰা হৈছে)। মূল পাৰ্থক্য থাকিব Google Nest Mini ৰ enclosure আৰু components দ্বাৰা সংজ্ঞায়িত constraint ৰ বাবে, (অর্থাৎ nest-mini-drop-in-pcb প্ৰকল্পৰ হাৰ্ডৱেৰ ডিজাইন Google ৰ মূল hardware ৰ দৰে একে physical capacity inputs ৰ সীমিত থাকিব)।

এইদৰে, এই প্ৰকল্প/ৰেপ'জিট'ৰীৰ পৰিসৰ ESPHome firmware ৰ বাবে নতুন feature/function উন্নয়ন কৰা নহয়, সেয়া বিচাৰিলে Home Assistant Voice Preview Edition ৰ firmware development আৰু upstream ESPHome mainline code লৈ যাব লাগিব:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## সহযোগিতাৰ বাবে অনুৰোধ

যদি আপোনাৰ PCB layout design ৰ অভিজ্ঞতা আছে, (বিশেষকৈ PCB routing, ground pouring, বা noise-sensitive digital+analog layout ৰ ক্ষেত্ৰত), **আপোনাৰ সহায় অতি মূল্যবান**! অনুগ্ৰহ কৰি নতুন issue খুলক, suggestion/request দিয়া, আৰু বৰ্তমান issue ৰ input/feedback যোগ কৰক, বা এই repository fork কৰক।

ধাৰণা/আইডিয়াৰ বিষয়ে অধিক তথ্যৰ বাবে, অনুগ্ৰহ কৰি এই Home Assistant community forum thread চাওক আৰু আলোচনা যোগদান কৰক:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### বৰ্তমান অৱস্থা

- ✅ স্কিমেটিক সম্পূর্ণ
- ✅ কম্প’নেন্ট স্থাপন সম্পন্ন
- ✅ Routing সম্পন্ন
- ✅ Ground pour, shielding strategy, আৰু EMI বিবেচনা সম্পন্ন
- ⚠️ ১ম test batch দুটা ভুলত ব্যর্থ - ঠিক কৰা হৈছে
- 🕓 ২য় test batch ৰ বাবে অপেক্ষা

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## ব্যৱহৃত সঁজুলি
- 🛠️ KiCad 9
- 🧰 Footprint উৎসৰ বাবে SnapEDA / LCSC

## পৰিচিত হাৰ্ডৱেৰ বিশেষত্ব

- ৪-স্তৰ PCB
- ESP32-S3R8 খালি চিপ (WiFi, BLE, আৰু অন-বৰ্ড ৱেক-ৱৰ্ড চিনাক্তকৰণৰ বাবে ESP32-S3)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP অডিঅ' প্ৰসেছিং)
- ডুয়েল SPI ফ্লেশ
- ডুয়েল I²S বাছ (একেটা সময়ত একাধিক I2S ইণ্টাৰফেছৰ বাবে, অৰ্থাৎ একেলগে অডিঅ' আউটপুট আৰু ইনপুট)
- MAX98357 স্পীকাৰ আউটপুটৰ বাবে (I2S Class-D মনো অডিঅ' এম্প্লিফায়াৰ)
- ২টা MEMS মাইক্ৰ'ফোন (MSM261DHP)
- SK6812 LED
- কাষ্টম USB-C আৰু 14V পাওৰ ইনপুট

---

> ⚠️ USB-Cৰ জৰিয়তে ফ্লেছিং কৰিবলৈ মুখ্য 14V পাওৰ ইনপুট বিচ্ছিন্ন কৰিব লাগিব। PCB-ত থকা ছিল্কস্ক্ৰিন টোকাত অধিক তথ্য চাওক।

## References

### Home Assistant Voice Preview Editionৰ উৎসসমূহ য'ত PCB ডিজাইন ফাইল অন্তর্ভুক্ত
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PEৰ ESPHome ফাৰ্মৱেৰ (য'ত একে ESP32-S3 + XMOS XU316 সংমিশ্ৰণ ব্যৱহাৰ কৰা হৈছে):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC চিপ

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/

  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Edition হাৰ্ডৱেৰৰ বাবে ESPHome প্ৰকল্পৰ XMOS ফাৰ্মৱেৰ:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## লাইচেঞ্চ

এই প্ৰকল্পটো [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] ত অধীন।
এই হাৰ্ডৱেৰটোৰ যিকোনো পৰিবৰ্তিত সংস্কৰণো একে লাইচেঞ্চৰ অধীনত বিতৰণ কৰিব লাগিব।

☕ যদি আপুনি এই প্ৰকল্পটো সমৰ্থন কৰিব বিচাৰে, অনুগ্ৰহ কৰি [Ko-fi-ত মোক কফি ক্ৰয় কৰক](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---