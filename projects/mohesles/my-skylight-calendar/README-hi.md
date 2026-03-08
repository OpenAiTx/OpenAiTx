<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# DIY स्मार्ट होम फैमिली कैलेंडर (स्काईलाइट क्लोन)

![स्काईलाइट कैलेंडर](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY स्काईलाइट](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 परिचय

हाल ही में मेरी पत्नी को सोशल मीडिया पर स्मार्ट होम कैलेंडर (स्काईलाइट, कोजिला, हेर्थ) के विज्ञापनों से भरपूर बमबारी का सामना करना पड़ा और वह एक पर $300 से अधिक खर्च करने को तैयार थीं। उन्हें हरी झंडी देने से पहले, मैंने उनसे इन्हें शोधने का एक मौका मांगा।

मैंने देखा कि अधिकांश में समान कार्यक्षमता थी लेकिन कीमत में काफी अंतर था। सबसे महत्वपूर्ण बात, मुझे कोई ऐसी विशेषता नहीं दिखी जिसे मैं **Home Assistant** में लागू न कर सकूं।

**लक्ष्य:** एक WAF-स्वीकृत (Wife Acceptance Factor), काउंटरटॉप-फ्रेंडली टचस्क्रीन कैलेंडर जो हमारे स्मार्ट होम में गहराई से एकीकृत हो और मासिक शुल्क न ले।

## 💡 DIY क्यों?

Home Assistant के साथ DIY मार्ग चुनने से Skylight/Hearth डिस्प्ले खरीदने की तुलना में कई लाभ मिले:

* **कोई मासिक शुल्क नहीं:** "प्रीमियम" फीचर्स के लिए सब्सक्रिप्शन से बचाता है।
* **सुव्यवस्थित एकीकरण:** यह हमारे लाइट्स, काम (Grocy), और प्रेजेंस सेंसर से बात करता है।
* **पुराना हार्डवेयर:** एक Mini PC और सामान्य मॉनिटर का पुनः उपयोग किया गया।
* **गोपनीयता:** कोई विक्रेता लॉक-इन या कंपनी के बंद होने का जोखिम नहीं।

## 🛠 हार्डवेयर चयन

यह वर्तमान में किसी भी HD (1920x1080) डिस्प्ले पर डैशबोर्ड दिखाने के लिए बनाया गया है।

मेरे मामले में, आवश्यकता थी कि यह "स्काइलाइट जैसा" दिखे, टचस्क्रीन हो, काउंटरटॉप हो, और विभिन्न स्थानों पर ले जाने की संभावना हो। इसलिए मैंने नीचे वर्णित हार्डवेयर चुना।
फिर भी, आपका मामला अलग हो सकता है और आपको इसे अपनी आवश्यकता अनुसार समायोजित करना होगा, उदाहरण के लिए यदि आप इसे टैबलेट या किसी अन्य डिवाइस पर दिखाना चाहते हैं।

मैंने जो हार्डवेयर मूल रूप से चुना, वह ऊपर बताए गए कारणों के आधार पर था, साथ ही भविष्य में वेबकैम, स्पीकर और माइक्रोफोन का उपयोग करके कार्यक्षमता बढ़ाने की आशा में। अभी मैं शायद इसे अलग तरीके से बनाऊं, क्योंकि मुझे इन अतिरिक्त हार्डवेयर विचारों को लागू करने का समय नहीं मिला।

* **मॉनिटर:** [HP Engage 15-इंच टचस्क्रीन](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor)। मैंने इसे सामान्य पोर्टेबल मॉनिटर के बजाय चुना क्योंकि इसमें इनबिल्ट **स्पीकर, वेबकैम और माइक्रोफोन** हैं, जिससे भविष्य में वॉयस कंट्रोल या वीडियो कॉल संभव है।
* **कंप्यूटर:** एक पुराना Mini PC (NUC/Tiny PC) जो Windows/Linux में किओस्क मोड में चलता है, या Raspberry Pi 4।~~

## ✨ विशेषताएँ

* **परिवार-व्यापी और व्यक्तिगत दृश्य:** विशिष्ट परिवार सदस्यों के कैलेंडर ऑन/ऑफ करें।
* **दो-तरफा सिंक:** स्क्रीन या हमारे फोन (Google Calendar) पर इवेंट्स संपादित करें।
* **"इवेंट जोड़ें" पॉपअप:** स्क्रीन से सीधे विशिष्ट कैलेंडर में इवेंट जोड़ने के लिए कस्टम UI।
* **मौसम और तिथि:** सुंदर, देखने योग्य हेडर।
* **उत्तरदायी:** स्क्रीन चौड़ाई के अनुसार दिन की संख्या स्वचालित रूप से समायोजित करता है (मोबाइल बनाम डेस्कटॉप)।

---

## ⚙️ इंस्टॉलेशन गाइड

*नोट: यह सेटअप एक **YAML पैकेज** का उपयोग करता है ताकि आपके लिए आवश्यक सभी हेल्पर्स, स्क्रिप्ट्स और वेरिएबल्स स्वचालित रूप से बनाए जा सकें। आपको इन्हें मैन्युअली बनाने की आवश्यकता नहीं है।*



### 1. आवश्यक पूर्व-आवश्यकताएँ (HACS)

आपके पास [HACS](https://hacs.xyz/) इंस्टॉल होना चाहिए। कृपया निम्नलिखित **Frontend** इंटीग्रेशन इंस्टॉल करें:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (पॉपअप काम करने के लिए आवश्यक)
* `layout-card` (Sections दृश्य के लिए आवश्यक)
* `button-card` (ईवेंट जोड़ने के पॉपअप के लिए आवश्यक)

*नोट: सेटिंग्स → डिवाइस और सर्विसेज में, सुनिश्चित करें कि ब्राउज़र मॉड एक इंटीग्रेशन (टाइल) के रूप में दिखाई दे रहा है, केवल HACS के अंतर्गत नहीं। 
यदि यह वहाँ नहीं है, तो Add Integration → Browser Mod पर क्लिक करें और प्रक्रिया पूरी करें, फिर HA को पुनः प्रारंभ करें।
HACS के माध्यम से इंस्टॉल करने से केवल फाइलें डाउनलोड होती हैं; आपको इंटीग्रेशन जोड़ना होगा ताकि HA इसकी क्रियाओं/एंटिटीज को रजिस्टर कर सके।

### 2. बैकएंड (दिमाग)

1. Home Assistant में अपनी `configuration.yaml` फाइल खोलें।
2. पैकेज सक्षम करने के लिए `homeassistant:` के अंतर्गत यह लाइन जोड़ी हो, सुनिश्चित करें:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. अपने HA कॉन्फ़िगरेशन डायरेक्टरी में `packages` नामक एक फ़ोल्डर बनाएं (यदि आपके पास नहीं है)।
4. इस रिपॉजिटरी से [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) डाउनलोड करें।
5. स्ट्रिंग [ #<--- UPDATE THIS ENTITY] खोजें और अपने वातावरण के अनुसार कैलेंडर एंटिटी आईडी को अपडेट करें। अधिक विवरण के लिए सेक्शन 3 देखें।
6. फ़ाइल को अपने `packages/` फ़ोल्डर में रखें।
7. **Home Assistant को पुनः प्रारंभ करें**।

### 3. कैलेंडर

आप **Google Calendars** या **Local Calendars** का उपयोग कर सकते हैं।

#### विकल्प A: कैलेंडर नाम पुन: उपयोग करें (सबसे आसान)


1. **Settings > Devices & Services** पर जाएं।
2. **Local Calendar** एकीकरण जोड़ें।
3. बिल्कुल इन्हीं नामों के कैलेंडर बनाएं: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`।
    * *यदि आप ये नाम उपयोग करते हैं, तो कोड तुरंत काम करता है!*

#### विकल्प B: कस्टम कैलेंडर

1. **Settings > Devices & Services** पर जाएं।
2. **Local Calendar** एकीकरण या **Google Calendar** जोड़ें।
3. **Configuration > Integrations > Local Calendar** या **Google Calendar** में जाएं और "Add Entry" चुनें।
4. प्रत्येक बनाए गए एंट्री के लिए, डैशबोर्ड.yaml फ़ाइल अपडेट करने हेतु एंटिटी आईडी प्राप्त करें।
5. `dashboard.yaml` खोलें।
6. `# <--- UPDATE THIS ENTITY` खोजें।
7. अपने वातावरण के अनुसार एंटिटी आईडी अपडेट करें।


#### छुट्टियां सेटअप करना

Home Assistant के अपडेट्स के बाद, छुट्टियां अब UI के माध्यम से जोड़ी जाती हैं:

1. **Settings > Devices & Services > Add Integration > Holiday** पर जाएं।
2. अपना देश चुनें।
3. एंटिटी आईडी जांचें (जैसे, `calendar.holidays`)। यदि यह डिफ़ॉल्ट से भिन्न है, तो इसे डैशबोर्ड YAML में अपडेट करें।

### 4. डैशबोर्ड (दिखावट)


1. **सेटिंग्स > डैशबोर्ड** पर जाएँ
2. **डैशबोर्ड जोड़ें** पर क्लिक करें (विकल्प "नई डैशबोर्ड स्क्रैच से" चुनें, सुनिश्चित करें कि "साइडबार में जोड़ें" चुना गया है)।
3. बाएँ मेनू में, नए बनाए गए डैशबोर्ड को चुनें और उसे संपादित करने के लिए पेंसिल आइकन पर क्लिक करें।
5. तीन डॉट्स आइकन चुनें और "रॉ कॉन्फ़िगरेटर एडिटर" का चयन करें।
6. [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) से कोड कॉपी करें और पेस्ट करें।

### चरण 5: थीम (वैकल्पिक)

विशेष फ़ॉन्ट लुक (Ovo) प्राप्त करने के लिए:

1. सुनिश्चित करें कि आपकी `configuration.yaml` में `frontend:` के अंतर्गत यह पंक्ति हो:

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. अपने कॉन्फ़िग डाइरेक्टरी में `themes` नामक एक फ़ोल्डर बनाएं।
3. [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) डाउनलोड करें और उसे उस फ़ोल्डर में रखें।
4. फ़ाइल एडिटर का उपयोग करें और calbackgrd.png को /www/ फ़ोल्डर में अपलोड करें, जो डैशबोर्ड पर आंतरिक रूप से /local में बदल जाता है।
5. होम असिस्टेंट को रीस्टार्ट करें।
6. अपनी प्रोफ़ाइल (यूज़र आइकन नीचे बाएं) पर जाएं और **Theme** को `Skylight` में बदलें।
नोट: यह थीम पूरी तरह से व्यापक नहीं है, इसलिए इसे ध्यान में रखें

---

## 📐 यह कैसे काम करता है (अंदर से)

### फ़िल्टर लॉजिक

`week-planner-card` मूल रूप से ऑन-द-फ्लाई विशिष्ट कैलेंडर छुपाने का समर्थन नहीं करता है। इसे हल करने के लिए, मैंने **Input Texts** का उपयोग किया है जो Regex फ़िल्टर्स की तरह कार्य करते हैं।

* जब आप किसी व्यक्ति के बटन पर क्लिक करते हैं, तो उसका फ़िल्टर `.*` (सब दिखाएं) और `^$` (कुछ न दिखाएं) के बीच टॉगल करता है।
* `config-template-card` इन वेरिएबल्स को डायनामिक रूप से कैलेंडर कार्ड में इंजेक्ट करता है।

### इवेंट निर्माण स्क्रिप्ट

"Add Event" पॉपअप एक ही स्क्रिप्ट का उपयोग करता है, जो कई लोगों और इवेंट प्रकारों (All Day बनाम Timed) के लिए लॉजिक को संभालता है।


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```
## नोट्स

मेरी मूल पोस्ट का उद्देश्य केवल यह बताना था कि इसे कैसे किया जाए और लोगों को कोड को उनके विशिष्ट परिदृश्यों के अनुसार समायोजित करने की अनुमति देना था।

विशेष रूप से मैंने ऐसा इसलिए किया क्योंकि हर डिस्प्ले और आवश्यकता अलग होती है। मैं सभी संभावित डिस्प्ले साइज, डैशबोर्ड आदि के लिए विकास नहीं कर सकता। इसलिए इसे मैंने उसी डिस्प्ले (1920x1080) के लिए तैयार किया है, लेकिन इसे अन्य के लिए भी संपादित किया जा सकता है।

डिस्प्ले की बात करें तो, मैंने शुरू में उसी डिस्प्ले का सुझाव दिया था क्योंकि वह उस समय Woot पर सेल में था और टचस्क्रीन डिस्प्ले पाने का एक बहुत किफायती तरीका था। अब शायद ऐसा न हो, तो जो भी डिस्प्ले आपके लिए उपयुक्त हो, उसे इस्तेमाल करें। टैबलेट, टचस्क्रीन, फोन, जो भी हो। मुख्य चीज जिसे आपको संपादित करना होगा, वह है डैशबोर्ड।




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---