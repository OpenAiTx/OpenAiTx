
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# Google Nest Mini के लिए MiciMike ड्रॉप-इन पीसीबी रिप्लेसमेंट

[MiciMike Nest Mini](https://github.com/iMike78/nest-mini-drop-in-pcb) एक ड्रॉप-इन पीसीबी रिप्लेसमेंट है ["Google Nest Mini" (गूगल का दूसरी पीढ़ी का स्मार्ट स्पीकर जिसमें बैरल कनेक्टर चार्जिंग पोर्ट है)](https://en.wikipedia.org/wiki/Google_Nest_(smart_speakers)) के लिए, लेकिन यह ओपन-सोर्स फर्मवेयर चलाने के लिए ESP32 और XMOS माइक्रोकंट्रोलर्स पर आधारित है।

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_1.png" width="1000">

सुझाव! यदि आप "Google Home Mini" (गूगल का पहली पीढ़ी का स्मार्ट स्पीकर हार्डवेयर जिसमें माइक्रो-यूएसबी चार्जिंग पोर्ट है) के लिए इसी तरह का ड्रॉप-इन पीसीबी रिप्लेसमेंट ढूंढ रहे हैं, तो बहन-प्रोजेक्ट https://github.com/iMike78/home-mini-v1-drop-in-pcb पर जाएं

ये दोनों पूरी तरह से ओपन-सोर्स हार्डवेयर प्रोजेक्ट हैं, जो कुछ अवधारणा प्रेरणा [Onju Voice](https://github.com/justLV/onju-voice) से लेते हैं, लेकिन [Open Home Foundation के ओपन वॉयस असिस्टेंट स्टैंडर्ड और Home Assistant Voice Preview Edition को संदर्भ](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) के रूप में अपनाने का लक्ष्य रखते हैं, PCB डिज़ाइन और विनिर्देशों के लिए।

# परियोजना का दायरा

इस परियोजना और रिपॉजिटरी (जो [Onju Voice](https://github.com/justLV/onju-voice) के समान है लेकिन पूरी तरह से ओपन-सोर्स हार्डवेयर लाइसेंस के तहत है) का लक्ष्य एक ड्रॉप-इन रिप्लेसमेंट PCB (प्रिंटेड सर्किट बोर्ड) डिजाइन करना है जिसमें हार्डवेयर स्कीमैटिक्स हों, जिसे कोई भी बना सकता है/ऑर्डर कर सकता है एक वन-स्टॉप PCB निर्माता से एक कस्टम ड्रॉप-इन रिप्लेसमेंट PCB के रूप में Google Nest Mini (2nd Gen) के लिए।

यह मुख्य रूप से उन लोगों को लक्षित करता है जो अपने पुराने Google Nest Mini स्मार्ट स्पीकर्स को ओपन-सोर्स हार्डवेयर में बदलना/पुनः प्रयोज्य बनाना चाहते हैं [Home Assistant के वॉयस कंट्रोल](https://www.home-assistant.io/voice_control/) के लिए और/या मीडिया प्लेयर स्पीकर आउटपुट के लिए [Music Assistant](https://www.music-assistant.io), (हालांकि हार्डवेयर शायद अन्य अनुप्रयोगों के साथ भी इस्तेमाल किया जा सकता है अन्य फर्मवेयर के साथ, क्योंकि यह लोकप्रिय Espressif ESP32 प्लेटफ़ॉर्म पर आधारित है)।

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/MiciMike_Nest__PCB_Prototype_2.png" width="1000">

हार्डवेयर डिज़ाइन (ठीक [Home Assistant Voice Preview Edition](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) के समान) में WiFi, BLE, और [ऑनबोर्ड वेक-वर्ड डिटेक्शन](https://www.home-assistant.io/voice_control/about_wake_word/) के लिए एक ESP32-S3 SoC एकीकृत किया जाएगा (नो-कोड [ESPHome फर्मवेयर](https://esphome.io/) का उपयोग करते हुए) + उन्नत ऑडियो प्रोसेसिंग के लिए एक XMOS xCORE XU316 चिप (माइक्रोफोन क्लीनअप ऑफलोडिंग के लिए कस्टम फर्मवेयर के साथ बेहतर वॉयस रिकग्निशन क्षमताओं के लिए, जिसमें लोकली रनिंग एल्गोरिदम द्वारा Noise Suppression, Acoustic Echo Cancellation, Interference Cancellation, और Automatic Gain Control शामिल हैं)।

फंक्शनैलिटी की दृष्टि से इसे [Home Assistant Voice Preview Edition (a.k.a. Home Assistant Voice PE](https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/) संदर्भ डिज़ाइन के साथ ज्यादातर हार्डवेयर संगत बनाया गया है (जिसे Open Home Foundation द्वारा Nabu Casa के सहयोग से ओपन-सोर्स हार्डवेयर डिज़ाइन के रूप में जारी किया गया है)। मुख्य अंतर Google Nest Mini के आवरण और घटकों द्वारा परिभाषित सीमाओं के कारण होगा, (यानी, nest-mini-drop-in-pcb परियोजना हार्डवेयर डिज़ाइन Google के मूल हार्डवेयर के समान ही भौतिक इनपुट प्रकार से सीमित रहेगी)।

इसलिए इस परियोजना/रिपॉजिटरी का दायरा ESPHome फर्मवेयर के लिए नई सुविधाएँ/फंक्शन्स विकसित करना नहीं है, तो यदि आप ऐसा चाहते हैं तो आपको Home Assistant Voice Preview Edition के फर्मवेयर डेवलपमेंट के साथ-साथ अपस्ट्रीम ESPHome मेनलाइन कोड की ओर जाना होगा:

- https://github.com/esphome/home-assistant-voice-pe
  - https://github.com/esphome/esphome
      - https://github.com/esphome/feature-requests

## सहयोग के लिए अनुरोध

यदि आपके पास PCB लेआउट डिज़ाइन का अनुभव है, (और विशेषकर PCB राउटिंग, ग्राउंड पोरिंग, या शोर-संवेदनशील डिजिटल+एनालॉग लेआउट्स के साथ), **आपकी सहायता अत्यंत सराहनीय है**! कृपया नया इश्यू खोलें, सुझाव/अनुरोध सबमिट करें, मौजूदा इश्यूज़ में इनपुट/फीडबैक जोड़ें, या इस रिपॉजिटरी को फोर्क करें।

अवधारणा/विचार के बारे में अधिक जानकारी के लिए संबंधित चर्चा देखें और इसमें योगदान करें, साथ ही इस Home Assistant समुदाय फोरम थ्रेड को भी देखें:

- https://community.home-assistant.io/t/any-news-on-alternative-to-onju-voice-pcb-repacement-design-for-google-nest-home-mini-speakers-with-added-xmos-chip-to-match-official-home-assistant-voice-preview-edition-reference-hardware/860001/

### वर्तमान स्थिति

- ✅ स्कीमैटिक पूर्ण
- ✅ घटक प्लेसमेंट पूर्ण
- ✅ राउटिंग पूर्ण
- ✅ ग्राउंड पोर, शील्डिंग रणनीति, और EMI विचार पूर्ण
- ⚠️ प्रथम परीक्षण बैच दो त्रुटियों पर विफल - सुधार कर लिया गया
- 🕓 दूसरे परीक्षण बैच की प्रतीक्षा

<img src="https://raw.githubusercontent.com/iMike78/nest-mini-drop-in-pcb/main/pics/3D.png" width="1000">

## उपयोग किए गए टूल्स

- 🛠️ KiCad 9
- 🧰 फुटप्रिंट स्रोत के लिए SnapEDA / LCSC

## ज्ञात हार्डवेयर विशिष्टताएँ

- 4-लेयर पीसीबी
- ESP32-S3R8 बेयर चिप (WiFi, BLE, और ऑनबोर्ड वेक-वर्ड डिटेक्शन के लिए ESP32-S3)
- XMOS XU316-1024-QF60B-C32 (XMOS XU316 xCORE DSP ऑडियो प्रोसेसिंग)
- ड्यूल SPI फ्लैश
- ड्यूल I²S बसें (एक ही समय में I2S इंटरफेस की अनुमति देने के लिए, यानी एक साथ ऑडियो आउटपुट और ऑडियो इनपुट)
- स्पीकर आउटपुट के लिए MAX98357 (I2S क्लास-D मोनो ऑडियो एम्प्लीफायर)
- 2x MEMS माइक्रोफोन (MSM261DHP)
- SK6812 एलईडी
- कस्टम USB-C और 14V पावर इनपुट

---

> ⚠️ USB-C के माध्यम से फ्लैशिंग के लिए मुख्य 14V पावर इनपुट को डिस्कनेक्ट करना आवश्यक है। विवरण के लिए पीसीबी पर सिल्कस्क्रीन नोट देखें।

## संदर्भ

### Home Assistant Voice Preview Edition संसाधन सहित पीसीबी डिज़ाइन फ़ाइलें
- https://www.home-assistant.io/blog/2024/12/19/voice-preview-edition-the-era-of-open-voice/
  - https://voice-pe.home-assistant.io/resources/
    - https://support.nabucasa.com/hc/en-us/articles/26195279589277-Home-Assistant-Voice-Preview-Edition-PCB-design-files
      - https://raw.githubusercontent.com/NabuCasa/support/refs/heads/main/static/docs/voice/home_assistant_voice_pe_schematic_v1.0_241009.pdf
     
#### Home Assistant Voice PE के लिए ESPHome फर्मवेयर (जो समान ESP32-S3 + XMOS XU316 संयोजन का उपयोग करते हैं):

- https://github.com/esphome/home-assistant-voice-pe
  - https://esphome.github.io/home-assistant-voice-pe/
- https://voice-pe.home-assistant.io/

### XMOS xCORE DSP (XU316-1024-QF60B-C32) MCU IC चिप

- https://www.xmos.com/download/XU316-1024-QF60B-xcore.ai-Datasheet(3).pdf
- https://www.xmos.com/software-tools/
  - https://www.xmos.com/develop/xcore-voice
  - https://www.xmos.com/usb-multichannel-audio/
  - https://www.xmos.com/xcore-ai
 
#### होम असिस्टेंट वॉयस प्रीव्यू एडिशन हार्डवेयर के लिए ESPHome प्रोजेक्ट से XMOS फर्मवेयर:

- https://github.com/esphome/voice-kit-xmos-firmware
  - https://github.com/esphome/xmos_fwk_rtos
  - https://github.com/esphome/xmos_fwk_io

## लाइसेंस

यह परियोजना [CERN ओपन हार्डवेयर लाइसेंस संस्करण 2 - स्ट्रॉन्गली रेसिप्रोकल (CERN-OHL-S v2)] के तहत लाइसेंस प्राप्त है।
इस हार्डवेयर के किसी भी संशोधित संस्करण को भी इसी लाइसेंस के तहत वितरित किया जाना चाहिए।

☕ यदि आप इस परियोजना का समर्थन करना चाहते हैं, तो [Ko-fi पर मुझे कॉफी खरीद सकते हैं](https://ko-fi.com/imike78)!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---