# केल्प

उन लोगों के लिए एक UI लाइब्रेरी जो HTML से प्यार करते हैं, आधुनिक CSS और वेब कंपोनेंट्स द्वारा संचालित।

**[डॉक्स पढ़ें &rarr;](https://kelpui.com)**

_**नोट:** केल्प फिलहाल अल्फा में विकासाधीन है। कृपया इसका उपयोग करें, प्रयोग करें और बग्स की रिपोर्ट करें, लेकिन समझें कि समय के साथ चीज़ें बदल सकती हैं और बदलेंगी।_



## त्वरित प्रारंभ

केल्प को किसी भी बिल्ड स्टेप की आवश्यकता नहीं है।

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) सबसे तेज़ और सरल तरीका है शुरुआत करने का, लेकिन आप चाहें तो [GitHub से फाइलें डाउनलोड](https://github.com/cferdinandi/kelp) कर सकते हैं।

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

केल्प सेमांटिक वर्शनिंग का उपयोग करता है। आप CDN से `@1.2.3` सिंटैक्स के साथ कोई भी मेजर, माइनर या पैच वर्शन ले सकते हैं। सभी उपलब्ध वर्शन आप [रिलीज़ेज़ के तहत](https://github.com/cferdinandi/kelp/tags) देख सकते हैं।



## डेमो

शामिल `index.html` फ़ाइल केल्प का एक किचन सिंक डेमो है। इसमें हर फीचर और कंपोनेंट एक विशाल फ़ाइल में शामिल है।

बीटा के दौरान, केल्प में कोई कम्पाइल स्टेप नहीं है। वेब कंपोनेंट्स ES इम्पोर्ट्स का उपयोग करते हैं, और इन्हें चलाने के लिए एक लोकल सर्वर की आवश्यकता होती है।

अपना पसंदीदा सर्वर उपयोग करें, या शामिल `http-server` का उपयोग `npm run dev` चलाकर करें।

```bash
npm install
npm run dev
```

जैसे ही केल्प v1 के करीब पहुंचेगा, यह एक कम्पाइल स्टेप का उपयोग करेगा ताकि यह अनावश्यक हो जाए।



## परीक्षण

केल्प उपयोग करता है... 

- परीक्षण के लिए [Playwright](https://playwright.dev)
- लिंटिंग और फॉर्मेटिंग के लिए [Biome](https://biomejs.dev)
- डिप्लॉय और PRs पर एक कंटिन्यूअस इंटीग्रेशन प्रक्रिया

```bash
# परीक्षण चलाएं
npm run test

# लिंटर चलाएं
npm run lint
```



## लाइसेंस

[केल्प कॉमन्स लाइसेंस](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md) के तहत नि:शुल्क उपयोग के लिए उपलब्ध। साथ ही [व्यावसायिक लाइसेंस विकल्प](/license/) भी उपलब्ध हैं।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---