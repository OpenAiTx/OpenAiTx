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

# Google Nest Mini ৰ বাবে MiciMike drop-in PCB প্ৰতিস্থাপন

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) হৈছে ["Google Nest Mini" (Google ৰ দ্বিতীয় প্ৰজন্মৰ স্মাৰ্ট স্পীকাৰ য’ত barrel connector চাৰ্জিং প’ৰ্ট আছে)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) ৰ বাবে এটা drop-in PCB প্ৰতিস্থাপন, যি ESP32 আৰু XMOS মাইক্ৰ’কন্ট্ৰ’লাৰৰ ওপৰত আধাৰিত আৰু মুক্ত উৎস ফাৰ্মৱেৰ চলাব পাৰে।

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

টিপ! যদি আপুনি "Google Home Mini" (Google ৰ প্ৰথম প্ৰজন্মৰ স্মাৰ্ট স্পীকাৰ য’ত Micro-USB চাৰ্জিং প’ৰ্ট আছে) ৰ বাবে এনেদৰে drop-in PCB প্ৰতিস্থাপন বিচাৰি থাকেনে, তেন্তে অনুগ্ৰহ কৰি https://github.com/iMike78/home-mini-v1-drop-in-pcb এই সহোদৰ প্ৰকল্পটো চাওক।

এই দুটা সম্পূৰ্ণৰূপে মুক্ত উৎস হাৰ্ডৱেৰ প্ৰকল্প, যিয়ে [Onju Voice](https://github.com/justLV/onju-voice) ৰ পৰা কিছু ধাৰণা আহৰণ কৰিছে যদিও, মূলত [Open Home Foundation ৰ মুক্ত ভয়েছ সহায়কৰ মানদণ্ড আৰু Home Assistant Voice Preview Edition ৰ উল্লেখ](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) অনুসৰণ কৰি PCB ডিজাইন আৰু স্পেছিফিকেশ্যন প্ৰস্তুত কৰাৰ লক্ষ্য লৈ আগবাঢ়িছে।

# প্ৰকল্পৰ পৰিসৰ

এই প্ৰকল্প আৰু ৰেপ’জিটৰীৰ লক্ষ্য (যি [Onju Voice](https://github.com/justLV/onju-voice) ৰ দৰে কিন্তু সম্পূৰ্ণ মুক্ত উৎস হাৰ্ডৱেৰ লাইচেঞ্চৰ অধীনত) হৈছে এক drop-in replacement PCB (Printed Circuit Board) ডিজাইন কৰা, যাৰ হাৰ্ডৱেৰ স্কিমেটিক যে কোনো লোকেই নিজে বনাব পাৰে বা এক-ঠাই PCB নিৰ্মাতাৰ পৰা অর্ডাৰ কৰিব পাৰে Google Nest Mini (2nd Gen) ৰ বাবে এক কাষ্টম drop-in replacement PCB হিচাপে।

এইটো প্ৰধানকৈ সেইসকল লোকৰ লক্ষ্য কৰিছে, যিয়ে নিজৰ পুৰণি Google Nest Mini স্মাৰ্ট স্পীকাৰক [Home Assistant ৰ Voice Control](https://www.home-assistant.io/voice_control/) ৰ বাবে মুক্ত উৎস হাৰ্ডৱেৰত ৰূপান্তৰ/পুনঃব্যৱহাৰ কৰিব বিচাৰে আৰু/বা [Music Assistant](https://www.music-assistant.io) ৰ বাবে মিডিয়া প্লেয়াৰ স্পীকাৰ আউটপুট হিচাপে ব্যৱহাৰ কৰিব বিচাৰে, (হাৰ্ডৱেৰটো যদিও সম্ভৱত অন্যান্য এপ্লিকেশ্যনৰ লগতো ব্যৱহাৰ কৰিব পাৰি, কাৰণ ইয়াত জনপ্রিয় Espressif ESP32 প্লেটফৰ্ম ব্যৱহাৰ কৰা হৈছে)।

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

হাৰ্ডৱেৰ ডিজাইনটো ( [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) ৰ দৰে) ESP32-S3 SoC সংযুক্ত কৰিব WiFi, BLE, আৰু [onboard wake-word detection](https://www.home-assistant.io/voice_control/about_wake_word/) ৰ বাবে (no-code [ESPHome firmware](https://esphome.io/) ব্যৱহাৰ কৰি) + XMOS xCORE XU316 চিপ উন্নত অডিঅ’ প্ৰসেছিংৰ বাবে (মাইক্ৰ’ফোন ক্লিনআপ অফল’ডিংৰ বাবে কাষ্টম ফাৰ্মৱেৰ, যাতে লোকেলি চলা এলগৰিদম ব্যৱহাৰ কৰি Noise Suppression, Acoustic Echo Cancellation, Interference Cancellation, আৰু Automatic Gain Control দ্বাৰা ভাল ভয়েছ চিনাক্তকৰণ সম্ভৱ হয়)।

ফাংচনেলিটিৰ ক্ষেত্ৰত এইটো প্ৰায় [Home Assistant Voice Preview Edition (Home Assistant Voice PE)](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) ৰ ৰেফাৰেন্স ডিজাইনটোৰ সৈতে হাৰ্ডৱেৰ কম্পেটিবল, (Open Home Foundation ৰ পৰা মুক্ত উৎস হাৰ্ডৱেৰ ডিজাইন হিচাপে Nabu Casa ৰ সহযোগত মুক্ত কৰা হৈছে)। মূল পাৰ্থক্যটো Google Nest Mini ৰ এনক্ল’জাৰ আৰু কম্প’নেন্টৰ দ্বাৰা নিৰ্ধাৰিত সীমাবদ্ধতাৰ বাবে হ’ব, (অর্থাৎ nest-mini-drop-in-pcb প্ৰকল্পৰ হাৰ্ডৱেৰ ডিজাইন Google ৰ মূল হাৰ্ডৱেৰটোৰ দৰে শারীৰিক ইনপুটৰ ক্ষমতাৰ সীমাত থাকিব)।

এইদৰে, এই প্ৰকল্প/ৰেপ’জিটৰীৰ উদ্দেশ্য ESPHome ফাৰ্মৱেৰলৈ নতুন ফিচাৰ/ফাংশন বিকাশ কৰা নহয়, সেয়া বিচাৰিলে আপোনাক Home Assistant Voice Preview Edition ৰ ফাৰ্মৱেৰ ডেভেলপমেণ্ট আৰু ESPHome মেইনলাইন ক’ডলৈ মন দিব লাগিব:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## সহযোগিতাৰ বাবে অনুৰোধ

আপোনাৰ যদি PCB লেআউট ডিজাইন, (বিশেষকৈ PCB ৰাউটিং, গ্ৰাউন্ড প’ৰিং, বা noise-sensitive digital+analog লেআউট) ত অভিজ্ঞতা থাকে, **আপোনাৰ সহায় অতি প্ৰয়োজনীয়**! অনুগ্ৰহ কৰি নতুন issue খোলক, সলাহ/অনুৰোধ জমা দিয়ক, বিদ্যমান issue ত input/feedback যোগ দিয়ক, বা এই ৰেপ’জিটৰীৰ ফ’র্ক কৰক।

ধাৰণা/বিষয়টোৰ বিষয়ে অধিক তথ্যৰ বাবে আৰু আলোচনা যোগদান কৰিবলৈ এই Home Assistant কমিউনিটি ফ’ৰাম থ্ৰেডটো চাওক:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### বৰ্তমান অৱস্থা

- ✅ স্কিমেটিক সম্পূৰ্ণ
- ✅ কম্প’নেন্ট স্থাপন সম্পন্ন
- ✅ ৰাউটিং সম্পন্ন
- ✅ গ্ৰাউন্ড প’ৰ, শিল্ডিং কৌশল, আৰু EMI বিবেচনা সম্পন্ন
- ⚠️ প্ৰথম টেষ্ট ব্যাচত দুটা ত্ৰুটিত বিফল - সংশোধন কৰা হৈছে
- 🕓 দ্বিতীয় টেষ্ট ব্যাচৰ বাবে অপেক্ষা

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">


## ব্যৱহৃত সঁজুলি

- 🛠️ KiCad 9
- 🧰 SnapEDA / LCSC ফুটপ্ৰিন্ট উৎসৰ বাবে

## Known hardware specifications

- ৪-স্তৰৰ PCB
- ESP32-S3R8 নাঙ্গল চিপ (WiFi, BLE আৰু অন-ব'ৰ্ড ৱেক-ৱ'ৰ্ড চিনাক্তকৰণৰ বাবে ESP32-S3)
- XMOS XU316-1024-QF60B-C24 (XMOS XU316 xCORE DSP অডিঅ' প্ৰ'চেছিং)
- ডুৱেল SPI ফ্লাশ (ESP32 আৰু XMOS-ৰ নিজৰ SPI ফ্লাশ আছে)
- ডুৱেল I²S বাছ (একেই সময়ত I2S ইণ্টাৰফেছসমূহৰ সুবিধা, অৰ্থাৎ একেলগে অডিঅ' আউটপুট আৰু ইনপুট)
- স্পীকাৰ আউটপুটৰ বাবে MAX98357 (I2S ক্লাছ-D ম'ন' অডিঅ' এম্প্লিফায়াৰ)
- ২টা MEMS মাইক্ৰ'ফোন (ডুৱেল MMICT390200012, ৬৮মিমি মাইক্ৰ'ফোনৰ মাজৰ দূৰত্ব)
- ৬টা SK6812 RGB LED
- কাষ্টম USB-C আৰু ১৪V পাওৱাৰ ইনপুট (দ্ৰষ্টব্য! USB-C আৰু বেৰেল-কনেক্টৰ একেলগে সংযোগ কৰিব নোৱাৰি)

---

> ⚠️ USB-C ৰ মাধ্যমে ফ্লাশিং কৰাৰ সময়ত প্ৰধান ১৪V পাওৱাৰ ইনপুট বিচ্ছিন্ন কৰিব লাগিব। PCB-ৰ সিল্কস্ক্ৰিন টোকাত বিশদ চাওক।

## References

### Home Assistant Voice Preview Edition ৰ উৎসসমূহ য'ত PCB ডিজাইন ফাইলসমূহ অন্তৰ্ভুক্ত
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE-ৰ ESPHome ফাৰ্মৱেৰ (এইটো ESP32-S3 + XMOS XU316 কম্বিনেশ্যন ব্যৱহাৰ কৰে):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC চিপ

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### Home Assistant Voice Preview Edition হাৰ্ডৱেৰ বাবে ESPHome প্ৰকল্পৰ XMOS ফাৰ্মৱেৰ:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## লাইচেঞ্চ

এই প্ৰকল্প [CERN Open Hardware License Version 2 - Strongly Reciprocal (CERN-OHL-S v2)] অনুসৰি লাইচেঞ্চ কৰা হৈছে।
এই হাৰ্ডৱেৰটোৰ পৰিৱৰ্তিত যিকোনো সংস্কৰণো একে লাইচেঞ্চত বিতৰণ কৰিব লাগিব।

☕ আপুনি যদি এই প্ৰকল্পক সহায় কৰিব বিচাৰে, তেন্তে [Ko-fi-ত মোক কফি কিনি সহায় কৰিব পাৰে](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---