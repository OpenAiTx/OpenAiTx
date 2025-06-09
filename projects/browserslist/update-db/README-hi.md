# ब्राउज़रलिस्ट DB अपडेट करें

<img width="120" height="120" alt="एंटोन पोपोव द्वारा बनाया गया ब्राउज़रलिस्ट लोगो"
     src="https://browsersl.ist/logo.svg" align="right">

CLI टूल जो `caniuse-lite` को ब्राउज़र DB के साथ अपडेट करता है
[Browserslist](https://github.com/browserslist/browserslist/) कॉन्फ़िग से।

कुछ क्वेरी जैसे `last 2 versions` या `>1%` का वास्तविक डेटा
`caniuse-lite` पर निर्भर करता है।

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsored by Evil Martians" width="236" height="54">
</a>

## आपको इसे नियमित रूप से क्यों चलाना चाहिए

`npx update-browserslist-db@latest` आपके npm, yarn, या pnpm लॉक फ़ाइल में
`caniuse-lite` संस्करण को अपडेट करता है।

यह अपडेट पॉलीफिल टूल्स जैसे Autoprefixer या Babel को नए ब्राउज़र के डेटा
लाएगा और पहले से गैर-ज़रूरी पॉलीफिल्स को कम करेगा।

इसे नियमित रूप से करने के तीन कारण हैं:

1. क्वेरीज़ जैसे `last 2 versions` या `>1%` में नवीनतम ब्राउज़र के संस्करण
   और आंकड़े इस्तेमाल करने के लिए। उदाहरण के लिए, यदि आपने अपना प्रोजेक्ट
   2 साल पहले बनाया था और अपनी डिपेंडेंसीज़ को अपडेट नहीं किया, तो `last 1 version`
   2 साल पुराने ब्राउज़र दिखाएगा।
2. वास्तविक ब्राउज़र डेटा कम पॉलीफिल्स के उपयोग की ओर ले जाएगा। इससे JS और CSS
   फ़ाइलों का आकार कम होगा और वेबसाइट की परफॉर्मेंस बेहतर होगी।
3. `caniuse-lite` डीडुप्लीकेशन: विभिन्न टूल्स में संस्करणों को सिंक्रोनाइज़ करने के लिए।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---