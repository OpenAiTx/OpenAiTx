# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# शाओमी फिटनेस ऑटोमैटिक स्टेप्स बढ़ाने का टूल

> शाओमी फिटनेस ऑटोमैटिक स्टेप्स बढ़ाने का टूल

## Github Actions डिप्लॉय गाइड

### 1. इस रिपॉजिटरी को Fork करें

### 2. अकाउंट और पासवर्ड सेट करें
# 20230224 नया जोड़ा गया
**CONFIG** नाम का एक वेरिएबल जोड़ें: Settings-->Secrets-->New secret , नीचे दिए गए json टेम्पलेट का उपयोग कर मल्टी-अकाउंट कॉन्फ़िगर करें, ईमेल और मोबाइल नंबर दोनों का समर्थन करता है
```
{
  "TG_BOT_TOKEN": "टेलीग्राम TG_BOT_TOKEN, अगर नहीं है तो खाली छोड़ दें",
  "TG_USER_ID": "टेलीग्राम TG_USER_ID, अगर नहीं है तो खाली छोड़ दें",
  "SKEY": "कू टुई skey, अगर नहीं है तो खाली छोड़ दें",
  "SCKEY": "server酱 sckey, अगर नहीं है तो खाली छोड़ दें",
  "POSITION": "क्या एंटरप्राइज वीचैट नोटिफिकेशन ऑन करें, अगर नहीं है तो खाली छोड़ दें",
  "CORPID": "एंटरप्राइज आईडी, एंटरप्राइज वीचैट लॉगिन करके देखें, अगर नहीं है तो खाली छोड़ दें",
  "CORPSECRET": "एंटरप्राइज वीचैट कस्टम एप्लिकेशन का सीक्रेट, हर एप्लिकेशन का अलग secret होता है, अगर नहीं है तो खाली छोड़ दें",
  "AGENTID": "अपने एंटरप्राइज वीचैट कस्टम एप्लिकेशन का आईडी डालें, बिना कोट्स के, एक पूर्णांक मान, अगर नहीं है तो खाली छोड़ दें",
  "TOUSER": "संदेश प्राप्त करने वाले यूजर के आईडी, कई यूजर हों तो '|' से अलग करें, अधिकतम 1000 यूजर, विशेष स्थिति: '@all' से सभी को भेजें, अगर नहीं है तो खाली छोड़ दें",
  "TOPARTY": "संदेश प्राप्त करने वाले डिपार्टमेंट के आईडी, कई हों तो '|' से अलग करें, अधिकतम 100 डिपार्टमेंट, touser '@all' हो तो '@all' भरें, अगर नहीं है तो खाली छोड़ दें",
  "TOTAG": "संदेश प्राप्त करने वाले टैग के आईडी, कई हों तो '|' से अलग करें, अधिकतम 100 टैग, touser '@all' हो तो '@all' भरें, अगर नहीं है तो खाली छोड़ दें",
  "OPEN_GET_WEATHER": "क्या लोकेशन के मौसम के अनुसार स्टेप्स घटाने की सुविधा ऑन करें, अगर नहीं है तो खाली छोड़ दें",
  "AREA": "मौसम के लिए लोकेशन सेट करें (ऊपर वाले को ऑन करने के बाद जरूरी), जैसे 'बीजिंग', अगर नहीं है तो खाली छोड़ दें",
  "QWEATHER": "यहाँ HeWeather का Private KEY भरें, आवेदन करें: https://console.qweather.com/#/apps, अगर नहीं है तो खाली छोड़ दें",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "मल्टी-अकाउंट के लिए अधिकतम स्टेप्स ऊपर देखें",
      "min_step": "मल्टी-अकाउंट के लिए न्यूनतम स्टेप्स ऊपर देखें",
      "password": "मल्टी-अकाउंट का पासवर्ड ऊपर देखें",
      "user": "मल्टी-अकाउंट का मोबाइल नंबर ऊपर देखें"
    }
  ]
}
```
> **PAT** नाम का वेरिएबल जोड़ें: Settings-->Secrets-->New secret

| Secrets |  फॉर्मेट  |
| -------- | ----- |
| PAT |   यहाँ **PAT** के लिए GitHub token अप्लाई करना होगा, गाइड: https://www.jianshu.com/p/bb82b3ad1d11 , repo और workflow परमिशन जरूरी है, यह आवश्यक है, git push परमिशन एरर से बचने के लिए। |

**CONFIG** उदाहरण
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "मल्टी-अकाउंट के लिए अधिकतम स्टेप्स ऊपर देखें",
      "min_step": "मल्टी-अकाउंट के लिए न्यूनतम स्टेप्स ऊपर देखें",
      "password": "मल्टी-अकाउंट का पासवर्ड ऊपर देखें",
      "user": "मल्टी-अकाउंट का मोबाइल नंबर ऊपर देखें"
    }
  ]
}
```

### 3. कस्टम स्टार्ट टाइम

**random_cron.sh** एडिट करें  
उसमें **if** कंडीशन का टाइम UTC टाइम में सेट करें, यानी **बीजिंग टाइम -8** (जैसे बीजिंग 8 बजे = UTC 0 बजे), रन टाइम -8 करके UTC टाइम में भरें



## ध्यान देने योग्य बातें

1. हर दिन 7 बार रन करता है, random_cron.sh द्वारा कंट्रोल होता है, मिनट रैंडम होंगे

2. मल्टी-अकाउंट की संख्या और पासवर्ड मेल खाने चाहिए, वरना काम नहीं करेगा!!!

3. स्टार्ट टाइम UTC में ही भरें!

4. server酱 रजिस्ट्रेशन लिंक [यहाँ क्लिक करें](https://sct.ftqq.com/)

5. अगर अलीपे में स्टेप्स अपडेट नहीं होते हैं, तो शाओमी फिटनेस->सेटिंग्स->अकाउंट->लॉगआउट->डेटा क्लियर करें, फिर से लॉगिन करें और थर्ड पार्टी को रिबाइंड करें

6. शाओमी फिटनेस में स्टेप्स अपडेट नहीं होते, केवल लिंक्ड अकाउंट में सिंक होते हैं!!!!!!

7. कृपया उपयोग के समय [मुख्य ब्रांच](https://github.com/xunichanghuan/mimotion-run/) को ही Fork करें, अनावश्यक बग से बचने के लिए।

8. ध्यान दें, अकाउंट [शाओमी अकाउंट] नहीं है, बल्कि [शाओमी फिटनेस] का अकाउंट है।

## ऐतिहासिक Star संख्या 

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---